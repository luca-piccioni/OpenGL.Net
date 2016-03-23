
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
		/// Value of GL_MAX_PROGRAM_PATCH_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_tessellation_program5")]
		public const int MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;

		/// <summary>
		/// Value of GL_TESS_CONTROL_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_tessellation_program5")]
		public const int TESS_CONTROL_PROGRAM_NV = 0x891E;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_tessellation_program5")]
		public const int TESS_EVALUATION_PROGRAM_NV = 0x891F;

		/// <summary>
		/// Value of GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_tessellation_program5")]
		public const int TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_tessellation_program5")]
		public const int TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;

	}

}
