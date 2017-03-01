
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_FLOAT16_MAT2_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT2_AMD = 0x91C5;

		/// <summary>
		/// Value of GL_FLOAT16_MAT3_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT3_AMD = 0x91C6;

		/// <summary>
		/// Value of GL_FLOAT16_MAT4_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT4_AMD = 0x91C7;

		/// <summary>
		/// Value of GL_FLOAT16_MAT2x3_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT2x3_AMD = 0x91C8;

		/// <summary>
		/// Value of GL_FLOAT16_MAT2x4_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT2x4_AMD = 0x91C9;

		/// <summary>
		/// Value of GL_FLOAT16_MAT3x2_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT3x2_AMD = 0x91CA;

		/// <summary>
		/// Value of GL_FLOAT16_MAT3x4_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT3x4_AMD = 0x91CB;

		/// <summary>
		/// Value of GL_FLOAT16_MAT4x2_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT4x2_AMD = 0x91CC;

		/// <summary>
		/// Value of GL_FLOAT16_MAT4x3_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		public const int FLOAT16_MAT4x3_AMD = 0x91CD;

	}

}
