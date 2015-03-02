
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
		/// Value of GL_TEXTURE_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_1D_ARRAY_EXT = 0x8C18;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;

		/// <summary>
		/// Value of GL_TEXTURE_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_2D_ARRAY_EXT = 0x8C1A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;

		/// <summary>
		/// Value of GL_MAX_ARRAY_TEXTURE_LAYERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;

		/// <summary>
		/// Value of GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;

	}

}
