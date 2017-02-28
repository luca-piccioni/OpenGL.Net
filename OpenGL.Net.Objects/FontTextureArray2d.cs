
// Copyright (C) 2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Font implemented using array texture and vertex instancing.
	/// </summary>
	class FontTextureArray2d : Font
	{
		#region Constructors

		public FontTextureArray2d(FontFamily fontFamily, uint emSize, FontStyle fontStyle, params FontFx[] effects)
			: base(fontFamily, emSize, fontStyle, effects)
		{

		}

		#endregion

		#region Vertex Array

		/// <summary>
		/// Glyph metadata.
		/// </summary>
		class Glyph : GlyphBase
		{
			#region Constructors

			public Glyph(char glyphChar, SizeF glyphSize, uint layer, SizeF texScale) : base(glyphChar, glyphSize)
			{
				Layer = layer;
				TexScale = texScale;
			}

			#endregion

			#region Information

			/// <summary>
			/// Texture layer.
			/// </summary>
			public readonly uint Layer;

			/// <summary>
			/// Texture coordinate scale.
			/// </summary>
			public SizeF TexScale;

			#endregion
		}

		/// <summary>
		/// Characters set metadata.
		/// </summary>
		private Dictionary<char, Glyph> _GlyphMetadata;

		/// <summary>
		/// Instanced glyph array element.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		struct GlyphInstance
		{
			/// <summary>
			/// The model-view-projection of the glyph.
			/// </summary>
			public Matrix4x4f ModelViewProjection;

			/// <summary>
			/// The world-space scale and texture layer.
			/// </summary>
			public Vertex3f GlyphVertexParams;

			/// <summary>
			/// The texture coordinate scale, to support variable size glyphs.
			/// </summary>
			public Vertex2f GlyphTexParams;
		}

		/// <summary>
		/// Create a <see cref="VertexArrayObject"/> for rendering glyphs.
		/// </summary>
		/// <returns></returns>
		private void LinkSharedResources(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			StringFormat stringFormat = StringFormat.GenericTypographic;

			// Font-wide resources
			string resourceClassId = "OpenGL.Objects.FontTextureArray2d";
			string resourceBaseId = String.Format("{0}.{1}-{2}-{3}", resourceClassId, Family, Size, Style);

			#region Instances Array

			string instanceArrayId = resourceClassId + ".InstanceArray";

			_GlyphInstances = (ArrayBufferObjectInterleaved<GlyphInstance>)ctx.GetSharedResource(instanceArrayId);

			if (_GlyphInstances == null) {
				_GlyphInstances = new ArrayBufferObjectInterleaved<GlyphInstance>(BufferObjectHint.DynamicCpuDraw);
				_GlyphInstances.Create(256);
				// Share
				ctx.SetSharedResource(instanceArrayId, _GlyphInstances);
			}
			LinkResource(_GlyphInstances);

			#endregion

			#region Vertex Array

			string vertexArrayId = resourceClassId + ".VertexArray";

			_VertexArrays = (VertexArrayObject)ctx.GetSharedResource(vertexArrayId);

			if (_VertexArrays == null) {
				_VertexArrays = new VertexArrayObject();

				ArrayBufferObject<Vertex2f> arrayPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);
				arrayPosition.Create(new Vertex2f[] {
					new Vertex2f(0.0f, 1.0f),
					new Vertex2f(0.0f, 0.0f),
					new Vertex2f(1.0f, 1.0f),
					new Vertex2f(1.0f, 0.0f),
				});
				_VertexArrays.SetArray(arrayPosition, VertexArraySemantic.Position);
				_VertexArrays.SetInstancedArray(_GlyphInstances, 0, 1, "glo_GlyphModelViewProjection");
				_VertexArrays.SetInstancedArray(_GlyphInstances, 1, 1, "glo_GlyphVertexParams");
				_VertexArrays.SetInstancedArray(_GlyphInstances, 2, 1, "glo_GlyphTexParams");
				_VertexArrays.SetElementArray(PrimitiveType.TriangleStrip);
				// Share
				ctx.SetSharedResource(vertexArrayId, _VertexArrays);
			}
			LinkResource(_VertexArrays);

			#endregion

			#region Glyphs Metadata

			string glyphDbId = resourceBaseId + ".GlyphDb";
			
			_GlyphMetadata = (Dictionary<char, Glyph>)ctx.GetSharedResource(glyphDbId);
			
			if (_GlyphMetadata == null) {
				_GlyphMetadata = new Dictionary<char, Glyph>();

				char[] fontChars = GetFontCharacters().ToCharArray();
				uint layer = 0;

				using (Bitmap bitmap = new Bitmap(1, 1))
				using (Graphics g = Graphics.FromImage(bitmap))
				using (System.Drawing.Font font = new System.Drawing.Font(Family, Size, Style))
				{
					// Avoid grid fitting
					g.TextRenderingHint = TextRenderingHint.AntiAlias;

					float glyphHeight = font.GetHeight();

					foreach (char c in fontChars) {
						SizeF glyphSize;

						switch (c) {
							case ' ':
								glyphSize = g.MeasureString(c.ToString(), font, 0, StringFormat.GenericDefault);
								break;
							default:
								glyphSize = g.MeasureString(c.ToString(), font, 0, stringFormat);
								break;
						}
						
						Glyph glyph = new Glyph(c, glyphSize, layer++, new SizeF(1.0f, 1.0f));

						_GlyphMetadata.Add(c, glyph);
					}
				}

				// Share
				ctx.SetSharedResource(glyphDbId, _GlyphMetadata);
			}

			#endregion

			#region Glyph Texture

			string textureId = resourceBaseId + ".Texture";

			_FontTexture = (TextureArray2d)ctx.GetSharedResource(textureId);

			if (_FontTexture == null) {
				// Get the size required for all glyphs
				float w = 0.0f, h = 0.0f;
				uint z = 0;

				foreach (Glyph glyph in _GlyphMetadata.Values) {
					w = Math.Max(w, glyph.GlyphSize.Width);
					h = Math.Max(h, glyph.GlyphSize.Height);
					z = Math.Max(z, glyph.Layer);
				}

				// Create texture
				_FontTexture = new TextureArray2d((uint)Math.Ceiling(w), (uint)Math.Ceiling(h), z + 1, PixelLayout.R8);
				_FontTexture.Create(ctx);

				using (System.Drawing.Font font = new System.Drawing.Font(Family, Size, Style))
				using (Brush brush = new SolidBrush(Color.White))
				{
					foreach (Glyph glyph in _GlyphMetadata.Values) {
						using (Bitmap bitmap = new Bitmap((int)_FontTexture.Width, (int)_FontTexture.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb))
						using (Graphics g = Graphics.FromImage(bitmap)) {
							// Recompute texture scaling
							glyph.TexScale = new SizeF(
								glyph.GlyphSize.Width / bitmap.Width,
								glyph.GlyphSize.Height / bitmap.Height
							);

							// Avoid grid fitting
							g.TextRenderingHint = TextRenderingHint.AntiAlias;
							g.Clear(Color.Black);

							g.DrawString(glyph.GlyphChar.ToString(), font, brush, 0.0f, 0.0f, stringFormat);

							_FontTexture.Create(ctx, PixelLayout.R8, bitmap, glyph.Layer);
						}
					}
				}

				// Share
				ctx.SetSharedResource(textureId, _FontTexture);
			}
			LinkResource(_FontTexture);

			#endregion
		}

		#endregion

		#region FontBase Overrides

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx.Extensions.DrawInstanced_ARB) {
				// Get shared resources
				LinkSharedResources(ctx);
				// Get shader program for drawing font
				LinkResource(_FontProgram = ctx.CreateProgram("OpenGL.FontTextureArray"));
			} else {
				throw new NotImplementedException();
			}
			// Base implementation
			base.CreateObject(ctx);
		}

		/// <summary>
		/// Draw a character sequence.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="modelview">
		/// The <see cref="Matrix4x4"/> the model-view-projection matrix for the first character of <paramref name="s"/>.
		/// </param>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the glyph color.
		/// </param>
		/// <param name="s">
		/// A <see cref="String"/> that specifies the characters for be drawn.
		/// </param>
		public override void DrawString(GraphicsContext ctx, Matrix4x4 modelview, ColorRGBAF color, string s)
		{
			// Draw the string
			DrawStringCore(ctx, modelview, _FontTexture, color, s);

			// Shadow effect
			if (_FxShadow != null) {
				ModelMatrix shadowModel = new ModelMatrix(modelview);

				shadowModel.Translate(_FxShadow.Offset);

				DrawStringCore(ctx, shadowModel, _FontTexture, _FxShadow.Color, s);
			}
		}

		/// <summary>
		/// Draw a character sequence (base method).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="modelview">
		/// The <see cref="Matrix4x4"/> the model-view-projection matrix for the first character of <paramref name="s"/>.
		/// </param>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the glyph color.
		/// </param>
		/// <param name="s">
		/// A <see cref="String"/> that specifies the characters for be drawn.
		/// </param>
		private void DrawStringCore(GraphicsContext ctx, Matrix4x4 modelview, TextureArray2d texture, ColorRGBAF color, string s)
		{
			ModelMatrix charModel = new ModelMatrix(modelview);

			ctx.Bind(_FontProgram);

			// Set uniforms
			_FontProgram.SetUniform(ctx, "glo_UniformColor", color);
			_FontProgram.SetUniform(ctx, "glo_FontGlyph", texture);

			// Set instances
			char[] fontChars = s.ToCharArray();
			uint instances = 0;

			_GlyphInstances.Map(ctx, BufferAccessARB.WriteOnly);
			try {
				for (int i = 0; i < fontChars.Length; i++) {
					Glyph glyph;

					if (_GlyphMetadata.TryGetValue(fontChars[i], out glyph) == false)
						continue;
					
					// Set instance information
					Matrix4x4f modelViewProjection = new Matrix4x4f(
						new Vertex4f(charModel.GetColumn(0)),
						new Vertex4f(charModel.GetColumn(1)),
						new Vertex4f(charModel.GetColumn(2)),
						new Vertex4f(charModel.GetColumn(3))
					);
					Vertex3f glyphVertexParams = new Vertex3f(
						glyph.GlyphSize.Width, glyph.GlyphSize.Height,
						glyph.Layer
					);
					Vertex2f glyphTexParams = new Vertex2f(
						glyph.TexScale.Width, glyph.TexScale.Height
					);

					_GlyphInstances.SetElement(modelViewProjection, instances, 0);
					_GlyphInstances.SetElement(glyphVertexParams, instances, 1);
					_GlyphInstances.SetElement(glyphTexParams, instances, 2);

					// Count the instance
					instances++;

					// Move next
					charModel.Translate(glyph.GlyphSize.Width, 0.0f);
				}
			} finally {
				_GlyphInstances.Unmap(ctx);
			}

			// Rasterize it
			using (State.BlendState stateBlend = State.BlendState.AlphaBlending) {
				stateBlend.ApplyState(ctx, _FontProgram);

				_VertexArrays.DrawInstanced(ctx, _FontProgram, instances);
			}
		}

		/// <summary>
		/// The font glyph vertex array.
		/// </summary>
		private VertexArrayObject _VertexArrays;

		/// <summary>
		/// Glyph instances array buffer.
		/// </summary>
		private ArrayBufferObjectInterleaved<GlyphInstance> _GlyphInstances;

		/// <summary>
		/// Glyphs in texture array
		/// </summary>
		private TextureArray2d _FontTexture;

		/// <summary>
		/// Shader program used for drawing font glyphs.
		/// </summary>
		private ShaderProgram _FontProgram;

		#endregion
	}
}
