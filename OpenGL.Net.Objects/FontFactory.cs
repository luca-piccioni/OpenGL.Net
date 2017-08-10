
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Font factory.
	/// </summary>
	public static class FontFactory
	{
		/// <summary>
		/// The type of the implementation of the font rendering.
		/// </summary>
		public enum FontType
		{
			/// <summary>
			/// Polygon based font rendering.
			/// </summary>
			Vector,

			/// <summary>
			/// Texture based font rendering.
			/// </summary>
			Textured
		}

		/// <summary>
		/// Create an <see cref="IFont"/> implementation for the specified font.
		/// </summary>
		/// <param name="fontFamily"></param>
		/// <param name="emSize"></param>
		/// <param name="fontType"></param>
		/// <returns></returns>
		public static IFont CreateFont(FontFamily fontFamily, uint emSize, FontStyle fontStyle, FontType fontType, params FontFx[] effects)
		{
			switch (fontType) {
				case FontType.Vector:
					return new FontVertex(fontFamily, emSize, fontStyle, effects);
				case FontType.Textured:
					return new FontTextureArray2d(fontFamily, emSize, fontStyle, effects);
				default:
					throw new NotSupportedException(fontType + " is not supported");
			}
		}
	}
}
