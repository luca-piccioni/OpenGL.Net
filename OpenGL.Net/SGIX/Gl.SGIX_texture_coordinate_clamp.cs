
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
		/// Value of GL_TEXTURE_MAX_CLAMP_S_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		public const int TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_CLAMP_T_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		public const int TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_CLAMP_R_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		public const int TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;

	}

}
