
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
		/// Value of GL_GEOMETRY_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_PROGRAM_NV = 0x8C26;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_OUTPUT_VERTICES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;

		/// <summary>
		/// Value of GL_GEOMETRY_VERTICES_OUT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;

		/// <summary>
		/// Value of GL_GEOMETRY_INPUT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;

		/// <summary>
		/// Value of GL_GEOMETRY_OUTPUT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;

		/// <summary>
		/// Binding for glProgramVertexLimitNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="limit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void ProgramVertexLimitNV(Int32 target, Int32 limit)
		{
			Debug.Assert(Delegates.pglProgramVertexLimitNV != null, "pglProgramVertexLimitNV not implemented");
			Delegates.pglProgramVertexLimitNV(target, limit);
			LogFunction("glProgramVertexLimitNV({0}, {1})", LogEnumName(target), limit);
			DebugCheckErrors(null);
		}

	}

}
