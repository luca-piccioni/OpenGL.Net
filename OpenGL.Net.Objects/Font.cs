
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
		/// The <see cref="Matrix4x4"/> the model-view-projection matrix for the first character of <paramref name="s"/>.
		/// </param>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the glyph color.
		/// </param>
		/// <param name="s">
		/// A <see cref="String"/> that specifies the characters for be drawn.
		/// </param>
		public abstract void DrawString(GraphicsContext ctx, Matrix4x4 modelview, ColorRGBAF color, string s);

		#endregion
	}
}
