
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
		/// Binding for glExtGetShadersQCOM.
		/// </summary>
		/// <param name="shaders">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numShaders">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetShadersQCOM(UInt32[] shaders, Int32[] numShaders)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				fixed (Int32* p_numShaders = numShaders)
				{
					Debug.Assert(Delegates.pglExtGetShadersQCOM != null, "pglExtGetShadersQCOM not implemented");
					Delegates.pglExtGetShadersQCOM(p_shaders, (Int32)shaders.Length, p_numShaders);
					LogFunction("glExtGetShadersQCOM({0}, {1}, {2})", LogValue(shaders), shaders.Length, LogValue(numShaders));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetProgramsQCOM.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numPrograms">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetProgramsQCOM(UInt32[] programs, Int32[] numPrograms)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (Int32* p_numPrograms = numPrograms)
				{
					Debug.Assert(Delegates.pglExtGetProgramsQCOM != null, "pglExtGetProgramsQCOM not implemented");
					Delegates.pglExtGetProgramsQCOM(p_programs, (Int32)programs.Length, p_numPrograms);
					LogFunction("glExtGetProgramsQCOM({0}, {1}, {2})", LogValue(programs), programs.Length, LogValue(numPrograms));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtIsProgramBinaryQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static bool ExtIsProgramBinaryQCOM(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglExtIsProgramBinaryQCOM != null, "pglExtIsProgramBinaryQCOM not implemented");
			retValue = Delegates.pglExtIsProgramBinaryQCOM(program);
			LogFunction("glExtIsProgramBinaryQCOM({0}) = {1}", program, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glExtGetProgramBinarySourceQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="shadertype">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetProgramBinarySourceQCOM(UInt32 program, Int32 shadertype, String source, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglExtGetProgramBinarySourceQCOM != null, "pglExtGetProgramBinarySourceQCOM not implemented");
					Delegates.pglExtGetProgramBinarySourceQCOM(program, shadertype, source, p_length);
					LogFunction("glExtGetProgramBinarySourceQCOM({0}, {1}, {2}, {3})", program, LogEnumName(shadertype), source, LogValue(length));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
