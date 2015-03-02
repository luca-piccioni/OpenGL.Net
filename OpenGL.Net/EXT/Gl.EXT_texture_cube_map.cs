
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
		/// Value of GL_NORMAL_MAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int NORMAL_MAP_EXT = 0x8511;

		/// <summary>
		/// Value of GL_REFLECTION_MAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int REFLECTION_MAP_EXT = 0x8512;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_EXT = 0x8513;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;

		/// <summary>
		/// Value of GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;

	}

}
