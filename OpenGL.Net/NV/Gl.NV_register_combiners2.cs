
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
		/// Value of GL_PER_STAGE_CONSTANTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public const int PER_STAGE_CONSTANTS_NV = 0x8535;

		/// <summary>
		/// Binding for glCombinerStageParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public static void CombinerStageParameterNV(Int32 stage, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglCombinerStageParameterfvNV != null, "pglCombinerStageParameterfvNV not implemented");
					Delegates.pglCombinerStageParameterfvNV(stage, pname, p_params);
					LogFunction("glCombinerStageParameterfvNV({0}, {1}, {2})", LogEnumName(stage), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCombinerStageParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public static void GetCombinerStageParameterNV(Int32 stage, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerStageParameterfvNV != null, "pglGetCombinerStageParameterfvNV not implemented");
					Delegates.pglGetCombinerStageParameterfvNV(stage, pname, p_params);
					LogFunction("glGetCombinerStageParameterfvNV({0}, {1}, {2})", LogEnumName(stage), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
