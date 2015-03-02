
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
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;

	}

}
