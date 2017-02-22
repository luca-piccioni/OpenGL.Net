
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
					return new FontPatch(fontFamily, emSize, fontStyle, effects);
				case FontType.Textured:
					return new FontTextureArray2d(fontFamily, emSize, fontStyle, effects);
				default:
					throw new NotSupportedException(fontType + " is not supported");
			}
		}
	}
}
