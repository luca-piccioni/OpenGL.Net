
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
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Font renderer based on polygons.
	/// </summary>
	sealed class FontPatch : Font
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fontFamily"></param>
		/// <param name="emSize"></param>
		public FontPatch(FontFamily fontFamily, uint emSize, FontStyle fontStyle) : base(fontFamily, emSize, fontStyle)
		{
			
		}

		#endregion

		#region Glyph Polygon

		/// <summary>
		/// Character glyph polygon.
		/// </summary>
		protected class GlyphPolygons : GlyphBase
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
		/// Create a <see cref="VertexArrayObject"/> for rendering glyphs.
		/// </summary>
		/// <param name="fontFamily"></param>
		/// <param name="emSize"></param>
		/// <param name="glyphs"></param>
		/// <returns></returns>
		private static VertexArrayObject CreateVertexArray(GraphicsContext ctx, FontFamily fontFamily, uint emSize, FontStyle fontStyle, out Dictionary<char, Glyph> glyphs)
		{
			CheckCurrentContext(ctx);

			string resourceBaseId = String.Format("OpenGL.Objects.FontPatch.{0}-{1}-{2}", fontFamily, emSize, fontStyle);
			string vertexArrayId = resourceBaseId + ".VertexArray";
			string glyphDbId = resourceBaseId + ".GlyphDb";

			VertexArrayObject vertexArrays = (VertexArrayObject)ctx.GetSharedResource(vertexArrayId);
			Dictionary<char, Glyph> glyphsDb = (Dictionary<char, Glyph>)ctx.GetSharedResource(glyphDbId);

			if (vertexArrays != null && glyphsDb != null) {
				glyphs = glyphsDb;
				return (vertexArrays);
			}

			vertexArrays = new VertexArrayObject();
			glyphsDb = new Dictionary<char, Glyph>();

			List<GlyphPolygons> glyphPolygons = GenerateGlyphs(fontFamily, emSize, fontStyle);
			List<Vertex2f> glyphsVertices = new List<Vertex2f>();
			GlyphPolygons gGlyph = null;
			uint gVertexIndex = 0;

			glyphs = new Dictionary<char, Glyph>();

			using (Tessellator tessellator = new Tessellator()) {
				tessellator.Begin += delegate(object sender, TessellatorBeginEventArgs e) {
					gVertexIndex = (uint)glyphsVertices.Count;
				};
				tessellator.End += delegate(object sender, EventArgs e) {
					// Create element (range)
					int glyphIndex = vertexArrays.SetElementArray(PrimitiveType.Triangles, gVertexIndex, (uint)glyphsVertices.Count - gVertexIndex);

					glyphsDb.Add(gGlyph.GlyphChar, new Glyph(gGlyph.GlyphChar, gGlyph.GlyphSize, glyphIndex));
				};
				tessellator.Vertex += delegate(object sender, TessellatorVertexEventArgs e) {
					glyphsVertices.Add((Vertex2f)e.Vertex);
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
			ArrayBufferObject<Vertex2f> gVertexPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);
			gVertexPosition.Create(glyphsVertices.ToArray());
			vertexArrays.SetArray(gVertexPosition, VertexArraySemantic.Position);

			// Returns glyphs database
			glyphs = glyphsDb;

			// Share resources
			ctx.SetSharedResource(vertexArrayId, vertexArrays);
			ctx.SetSharedResource(glyphDbId, glyphsDb);

			return (vertexArrays);
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
			LinkResource(_VertexArrays = CreateVertexArray(ctx, Family, Size, Style, out _Glyphs));
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
			ModelMatrix charModel = new ModelMatrix(modelview);

			ctx.Bind(_FontProgram);

			_FontProgram.SetUniform(ctx, "glo_UniformColor", color);

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
				charModel.Translate(glyph.GlyphSize.Width, 0.0f);
			}
		}

		/// <summary>
		/// The font glyph vertex array.
		/// </summary>
		private VertexArrayObject _VertexArrays;

		/// <summary>
		/// Shader program used for drawing font glyphs.
		/// </summary>
		private ShaderProgram _FontProgram;

		#endregion
	}
}
