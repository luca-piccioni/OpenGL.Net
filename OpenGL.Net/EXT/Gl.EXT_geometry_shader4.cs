
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
		/// Value of GL_GEOMETRY_SHADER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int GEOMETRY_SHADER_EXT = 0x8DD9;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;

		/// <summary>
		/// Value of GL_MAX_VERTEX_VARYING_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;

		/// <summary>
		/// Value of GL_MAX_VARYING_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VARYING_COMPONENTS_EXT = 0x8B4B;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;

		/// <summary>
		/// Binding for glProgramParameteriEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ProgramParameterEXT(UInt32 program, int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglProgramParameteriEXT != null, "pglProgramParameteriEXT not implemented");
			Delegates.pglProgramParameteriEXT(program, pname, value);
			CallLog("glProgramParameteriEXT({0}, {1}, {2})", program, pname, value);
			DebugCheckErrors();
		}

	}

}
