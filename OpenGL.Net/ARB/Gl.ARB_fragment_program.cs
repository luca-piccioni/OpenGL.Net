
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
		/// Value of GL_FRAGMENT_PROGRAM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int FRAGMENT_PROGRAM_ARB = 0x8804;

		/// <summary>
		/// Value of GL_PROGRAM_ALU_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;

		/// <summary>
		/// Value of GL_PROGRAM_TEX_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;

		/// <summary>
		/// Value of GL_PROGRAM_TEX_INDIRECTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		public const int MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;

	}

}
