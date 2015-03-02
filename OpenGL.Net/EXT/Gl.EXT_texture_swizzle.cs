
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
		/// Value of GL_TEXTURE_SWIZZLE_R_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_R_EXT = 0x8E42;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_G_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_G_EXT = 0x8E43;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_B_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_B_EXT = 0x8E44;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_A_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_A_EXT = 0x8E45;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;

	}

}
