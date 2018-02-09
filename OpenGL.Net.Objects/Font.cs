
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
using System.Drawing;
using System.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Font abstracton.
	/// </summary>
	abstract class Font : UserGraphicsResource, IFont
	{
		#region Constructors

		/// <summary>
		/// Construct a Font specifying the font properties.
		/// </summary>
		/// <param name="fontFamily">
		/// The <see cref="FontFamily"/> that specifies the family of the font.
		/// </param>
		/// <param name="emSize">
		/// The <see cref="UInt32"/> that specifies the font size.
		/// </param>
		/// <param name="fontStyle">
		/// The <see cref="FontStyle"/> that specifies the stryle of the font.
		/// </param>
		protected Font(FontFamily fontFamily, uint emSize, FontStyle fontStyle, params FontFx[] effects) : base(fontFamily.Name + "+" + emSize)
		{
			Family = fontFamily;
			Size = emSize;
			Style = fontStyle;

			if (effects != null) {
				_FxShadow = (FontFxShadow)Array.FindLast(effects, delegate(FontFx item) { return (item is FontFxShadow); });
				_FxHalo = (FontFxHalo)Array.FindLast(effects, delegate(FontFx item) { return (item is FontFxHalo); });
			}
		}

		#endregion

		#region Font Information

		/// <summary>
		/// The family of the font.
		/// </summary>
		public readonly FontFamily Family;

		/// <summary>
		/// The size of the font.
		/// </summary>
		public uint Size;

		/// <summary>
		/// The style of the font.
		/// </summary>
		public FontStyle Style;

		#endregion

		#region Effect Support

		/// <summary>
		/// Shadow effect.
		/// </summary>
		protected FontFxShadow _FxShadow;

		/// <summary>
		/// Halo effect.
		/// </summary>
		protected FontFxHalo _FxHalo;

		#endregion

		#region Glyph

		/// <summary>
		/// Basic glyph information
		/// </summary>
		protected class GlyphBase
		{
			#region Constructors

			public GlyphBase(char glyphChar, SizeF glyphSize)
			{
				GlyphChar = glyphChar;
				GlyphSize = glyphSize;
			}

			#endregion

			#region Information

			/// <summary>
			/// The character represented by this glyph.
			/// </summary>
			public readonly char GlyphChar;

			/// <summary>
			/// The size of the glyph.
			/// </summary>
			public readonly SizeF GlyphSize;

			#endregion
		}

		/// <summary>
		/// Get the characters to be included in font glyphs.
		/// </summary>
		/// <returns></returns>
		protected static string GetFontCharacters()
		{
			StringBuilder sb = new StringBuilder();
			
			for (int i = 1; i <= 127; i++) {
				string asciiChar = Char.ConvertFromUtf32(i);

				if (Char.IsControl(asciiChar[0]))
					continue;

				sb.Append(asciiChar);
			}

			return (sb.ToString());
		}

		#endregion

		#region IFont Implementation

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
		public abstract void DrawString(GraphicsContext ctx, Matrix4x4f modelview, ColorRGBAF color, string s);

		#endregion
	}
}
