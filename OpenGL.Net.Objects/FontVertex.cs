
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Font renderer based on polygons.
	/// </summary>
	sealed class FontVertex : Font
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fontFamily"></param>
		/// <param name="emSize"></param>
		public FontVertex(FontFamily fontFamily, uint emSize, FontStyle fontStyle, params FontFx[] effects)
			: base(fontFamily, emSize, fontStyle, effects)
		{
			
		}

		#endregion

		#region Glyph Polygon

		/// <summary>
		/// Character glyph polygon.
		/// </summary>
		class GlyphPolygons : GlyphBase
		{
			#region Constructors

			public GlyphPolygons(char glyphChar, SizeF glyphSize, List<List<Vertex2f>> contours) : base(glyphChar, glyphSize)
			{
				if (contours == null)
					throw new ArgumentNullException("contours");

				_Contours = contours;
			}

			#endregion

			#region Polygons

			/// <summary>
			/// Contours defining the glyph geaometry.
			/// </summary>
			public ICollection<List<Vertex2f>> Contours { get { return (_Contours); } }

			/// <summary>
			/// Contours defining the glyph geaometry.
			/// </summary>
			private readonly List<List<Vertex2f>> _Contours;

			#endregion
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fontFamily"></param>
		/// <param name="size"></param>
		/// <returns></returns>
		private static List<GlyphPolygons> GenerateGlyphs(FontFamily fontFamily, uint size, FontStyle fontStyle)
		{
			List<GlyphPolygons> glyphs = new List<GlyphPolygons>();

			using (Bitmap bitmap = new Bitmap(1, 1))
			using (Graphics g = Graphics.FromImage(bitmap))
			using (System.Drawing.Font font = new System.Drawing.Font(fontFamily, size, fontStyle))
			using (GraphicsPath graphicsPath = new GraphicsPath()) {
				StringFormat stringFormat = StringFormat.GenericTypographic;

				// Avoid grid fitting
				g.TextRenderingHint = TextRenderingHint.AntiAlias;

				System.Drawing.Drawing2D.Matrix gPathMatrix = new System.Drawing.Drawing2D.Matrix();
				gPathMatrix.Translate(0.0f, size);
				gPathMatrix.Scale(+1.25f, -1.25f);	// Note: GraphicsPath is currently giving path points smaller than
													// the equivalent texture font.

				graphicsPath.FillMode = FillMode.Winding;

				foreach (char c in GetFontCharacters()) {
					graphicsPath.AddString(c.ToString(), fontFamily, (int)fontStyle, size, new PointF(0, 0), stringFormat);
					graphicsPath.Flatten();
					graphicsPath.Transform(gPathMatrix);

					List<List<Vertex2f>> vCountours = new List<List<Vertex2f>>();

					try {
						PointF[] gPoints = graphicsPath.PathPoints;
						byte[] gPathTypes = graphicsPath.PathTypes;

						List<Vertex2f> vCountour = null;
						int vCountourStartIndex = 0;

						for (int i = 0; i < gPoints.Length; i++) {
							switch (gPathTypes[i] & 0x07) {
								case 0:
									vCountour = new List<Vertex2f>();
									vCountourStartIndex = i;
									continue;
								case 1:
									if (vCountour == null)
										throw new InvalidOperationException("no start point");
									vCountour.Add(new Vertex2f(gPoints[i].X, gPoints[i].Y));
									break;
								default:
									throw new NotSupportedException();
							}

							if ((gPathTypes[i] & 0x80) != 0) {
								vCountour.Add(new Vertex2f(gPoints[vCountourStartIndex].X, gPoints[vCountourStartIndex].Y));
								vCountours.Add(vCountour);
							}
						}
					} catch (Exception) {
						vCountours.Clear();
					}

					SizeF cSize;

					switch (c) {
						case ' ':
							cSize = g.MeasureString(c.ToString(), font, 0, StringFormat.GenericDefault);
							break;
						default:
							cSize = g.MeasureString(c.ToString(), font, 0, stringFormat);
							break;
					}

					glyphs.Add(new GlyphPolygons(c, cSize, vCountours));
					graphicsPath.Reset();
				}
			}

			return (glyphs);
		}

		#endregion

		#region Vertex Array

		/// <summary>
		/// Glyph for FontPatch.
		/// </summary>
		class Glyph : GlyphBase
		{
			#region Constructors

			public Glyph(char glyphChar, SizeF glyphSize, int elementIndex) : base(glyphChar, glyphSize)
			{
				ElementIndex = elementIndex;
			}

			#endregion

			#region Information

			public readonly int ElementIndex;

			#endregion
		}

		/// <summary>
		/// Create a <see cref="VertexArrays"/> for rendering glyphs.
		/// </summary>
		private void LinkSharedResources(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			string resourceClassId = "OpenGL.Objects.FontPatch";
			string resourceBaseId = String.Format("{0}.{1}-{2}-{3}", resourceClassId, Family, Size, Style);

			string vertexArrayId = resourceBaseId + ".VertexArray";
			string glyphDbId = resourceBaseId + ".GlyphDb";

			#region Vertex Arrays

			_VertexArrays = (VertexArrays)ctx.GetSharedResource(vertexArrayId);
			Dictionary<char, Glyph> glyphsDb = null;

			if (_VertexArrays == null) {
				_VertexArrays = new VertexArrays();

				List<GlyphPolygons> glyphPolygons = GenerateGlyphs(Family, Size, Style);
				List<Vertex2f> glyphsVertices = new List<Vertex2f>();
				GlyphPolygons gGlyph = null;
				uint gVertexIndex = 0;

				glyphsDb = new Dictionary<char, Glyph>();

				using (Tessellator tessellator = new Tessellator()) {
					tessellator.Begin += delegate(object sender, TessellatorBeginEventArgs e) {
						gVertexIndex = (uint)glyphsVertices.Count;
					};
					tessellator.End += delegate(object sender, EventArgs e) {
						// Create element (range)
						int glyphIndex = _VertexArrays.SetElementArray(PrimitiveType.Triangles, gVertexIndex, (uint)glyphsVertices.Count - gVertexIndex);

						glyphsDb.Add(gGlyph.GlyphChar, new Glyph(gGlyph.GlyphChar, gGlyph.GlyphSize, glyphIndex));
					};
					tessellator.Vertex += delegate(object sender, TessellatorVertexEventArgs e) {
						glyphsVertices.Add(new Vertex2f((float)e.Vertex.x, (float)e.Vertex.y));
					};

					// Tessellate all glyphs
					foreach (GlyphPolygons glyph in glyphPolygons) {
						gGlyph = glyph;

						if (glyph.Contours.Count == 0) {
							glyphsDb.Add(gGlyph.GlyphChar, new Glyph(gGlyph.GlyphChar, gGlyph.GlyphSize, -1));
							continue;
						}

						tessellator.BeginPolygon();
						foreach (List<Vertex2f> countour in glyph.Contours)
							tessellator.AddContour(countour.ToArray(), Vertex3f.UnitZ);
						tessellator.EndPolygon();
					}
				}

				// Element vertices
				ArrayBuffer<Vertex2f> gVertexPosition = new ArrayBuffer<Vertex2f>();
				gVertexPosition.Create(glyphsVertices.ToArray());
				_VertexArrays.SetArray(gVertexPosition, VertexArraySemantic.Position);

				// Share
				ctx.SetSharedResource(vertexArrayId, _VertexArrays);
			}
			LinkResource(_VertexArrays);

			#endregion

			#region Glyph Metadata

			_Glyphs = (Dictionary<char, Glyph> )ctx.GetSharedResource(glyphDbId);

			if (glyphsDb != null)
				_Glyphs = glyphsDb;
			if (_Glyphs == null)
				throw new InvalidProgramException("no glyph metadata");

			// Share
			ctx.SetSharedResource(glyphDbId, _Glyphs);

			#endregion
		}

		/// <summary>
		/// Map between font characters and glyph information.
		/// </summary>
		private Dictionary<char, Glyph> _Glyphs;

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
			// Get vertex array
			LinkSharedResources(ctx);
			// Get shader program for drawing font
			LinkResource(_FontProgram = ctx.CreateProgram("OpenGL.FontPatch"));
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
		/// The <see cref="Matrix4x4f"/> the model-view-projection matrix for the first character of <paramref name="s"/>.
		/// </param>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the glyph color.
		/// </param>
		/// <param name="s">
		/// A <see cref="String"/> that specifies the characters for be drawn.
		/// </param>
		public override void DrawString(GraphicsContext ctx, Matrix4x4f modelview, ColorRGBAF color, string s)
		{
			// Draw the string
			DrawStringCore(ctx, modelview, color, s);

			// Shadow effect
			if (_FxShadow != null) {
				Matrix4x4f shadowModel = modelview;

				shadowModel.Translate(_FxShadow.Offset.x, _FxShadow.Offset.y, 0.0f);

				DrawStringCore(ctx, shadowModel, _FxShadow.Color, s);
			}
		}

		/// <summary>
		/// Draw a character sequence.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="modelview">
		/// The <see cref="Matrix4x4f"/> the model-view-projection matrix for the first character of <paramref name="s"/>.
		/// </param>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the glyph color.
		/// </param>
		/// <param name="s">
		/// A <see cref="String"/> that specifies the characters for be drawn.
		/// </param>
		private void DrawStringCore(GraphicsContext ctx, Matrix4x4f modelview, ColorRGBAF color, string s)
		{
			Matrix4x4f charModel = modelview;

			ctx.Bind(_FontProgram);

			_FontProgram.SetUniform(ctx, "glo_UniformColor", color);

			if (ctx.Extensions.ShaderDrawParameters_ARB) {
				List<VertexArrays.IElement> glyphElements = new List<VertexArrays.IElement>();
				int drawInstanceId = 0;

				foreach (char c in s) {
					Glyph glyph;

					if (_Glyphs.TryGetValue(c, out glyph) == false)
						continue;

					if (glyph.ElementIndex >= 0) {
						// Collect draw instance element
						glyphElements.Add(_VertexArrays.GetElementArray(glyph.ElementIndex));
						// Set model-view
						_FontProgram.SetUniform(ctx, "glo_CharModelViewProjection[" + drawInstanceId + "]", charModel);
						// Next instance
						drawInstanceId++;
					}
					// Move next
					charModel.Translate(glyph.GlyphSize.Width, 0.0f, 0.0f);
				}

				// Draw using Multi-Draw primitive
				VertexArrays.IElement multiElement = _VertexArrays.CombineArrayElements(glyphElements);

				_VertexArrays.Draw(ctx, _FontProgram, multiElement);

			} else {
				foreach (char c in s) {
					Glyph glyph;

					if (_Glyphs.TryGetValue(c, out glyph) == false)
						continue;

					if (glyph.ElementIndex >= 0) {
						// Set model-view
						_FontProgram.SetUniform(ctx, "glo_ModelViewProjection", charModel);
						// Rasterize it
						_VertexArrays.Draw(ctx, _FontProgram, glyph.ElementIndex);
					}
					// Move next
					charModel.Translate(glyph.GlyphSize.Width, 0.0f, 0.0f);
				}
			}
		}

		/// <summary>
		/// The font glyph vertex array.
		/// </summary>
		private VertexArrays _VertexArrays;

		/// <summary>
		/// Shader program used for drawing font glyphs.
		/// </summary>
		private ShaderProgram _FontProgram;

		#endregion
	}
}
