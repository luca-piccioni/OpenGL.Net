
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
		/// Binding for glProgramEnvParameters4fvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_gpu_program_parameters")]
		public static void ProgramEnvParameters4EXT(Int32 target, UInt32 index, Int32 count, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameters4fvEXT != null, "pglProgramEnvParameters4fvEXT not implemented");
					Delegates.pglProgramEnvParameters4fvEXT(target, index, count, p_params);
					LogFunction("glProgramEnvParameters4fvEXT({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParameters4fvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_gpu_program_parameters")]
		public static void ProgramLocalParameters4EXT(Int32 target, UInt32 index, Int32 count, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameters4fvEXT != null, "pglProgramLocalParameters4fvEXT not implemented");
					Delegates.pglProgramLocalParameters4fvEXT(target, index, count, p_params);
					LogFunction("glProgramLocalParameters4fvEXT({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
