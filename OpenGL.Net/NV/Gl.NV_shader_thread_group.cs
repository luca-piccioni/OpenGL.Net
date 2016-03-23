
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
		/// Value of GL_WARP_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_thread_group")]
		public const int WARP_SIZE_NV = 0x9339;

		/// <summary>
		/// Value of GL_WARPS_PER_SM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_thread_group")]
		public const int WARPS_PER_SM_NV = 0x933A;

		/// <summary>
		/// Value of GL_SM_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_thread_group")]
		public const int SM_COUNT_NV = 0x933B;

	}

}
