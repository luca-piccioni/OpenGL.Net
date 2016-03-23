
// Copyright (C) 2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_TEXTURE_COLOR_WRITEMASK_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_color_mask")]
		public const int TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;

		/// <summary>
		/// Binding for glTextureColorMaskSGIS.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_color_mask")]
		public static void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglTextureColorMaskSGIS != null, "pglTextureColorMaskSGIS not implemented");
			Delegates.pglTextureColorMaskSGIS(red, green, blue, alpha);
			LogFunction("glTextureColorMaskSGIS({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

	}

}
