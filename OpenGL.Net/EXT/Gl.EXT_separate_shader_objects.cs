
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
		/// Value of GL_ACTIVE_PROGRAM_EXT symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CURRENT_PROGRAM.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const int ACTIVE_PROGRAM_EXT = 0x8B8D;

		/// <summary>
		/// Binding for glUseShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void UseShaderProgramEXT(int type, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseShaderProgramEXT != null, "pglUseShaderProgramEXT not implemented");
			Delegates.pglUseShaderProgramEXT(type, program);
			CallLog("glUseShaderProgramEXT({0}, {1})", type, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glActiveProgramEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void ActiveProgramEXT(UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveProgramEXT != null, "pglActiveProgramEXT not implemented");
			Delegates.pglActiveProgramEXT(program);
			CallLog("glActiveProgramEXT({0})", program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCreateShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String"/>.
		/// </param>
		public static UInt32 CreateShaderProgramEXT(int type, String @string)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramEXT != null, "pglCreateShaderProgramEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramEXT(type, @string);
			CallLog("glCreateShaderProgramEXT({0}, {1}) = {2}", type, @string, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
