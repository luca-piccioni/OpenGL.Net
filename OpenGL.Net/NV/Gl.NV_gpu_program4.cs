
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
		/// Value of GL_PROGRAM_ATTRIB_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;

		/// <summary>
		/// Value of GL_PROGRAM_RESULT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int PROGRAM_RESULT_COMPONENTS_NV = 0x8907;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_RESULT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_GENERIC_RESULTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;

		/// <summary>
		/// Binding for glProgramLocalParameterI4iNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4NV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameterI4iNV != null, "pglProgramLocalParameterI4iNV not implemented");
			Delegates.pglProgramLocalParameterI4iNV(target, index, x, y, z, w);
			LogFunction("glProgramLocalParameterI4iNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParameterI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4NV(Int32 target, UInt32 index, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameterI4ivNV != null, "pglProgramLocalParameterI4ivNV not implemented");
					Delegates.pglProgramLocalParameterI4ivNV(target, index, p_params);
					LogFunction("glProgramLocalParameterI4ivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParametersI4ivNV.
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParametersI4NV(Int32 target, UInt32 index, Int32 count, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParametersI4ivNV != null, "pglProgramLocalParametersI4ivNV not implemented");
					Delegates.pglProgramLocalParametersI4ivNV(target, index, count, p_params);
					LogFunction("glProgramLocalParametersI4ivNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParameterI4uiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameterI4uiNV != null, "pglProgramLocalParameterI4uiNV not implemented");
			Delegates.pglProgramLocalParameterI4uiNV(target, index, x, y, z, w);
			LogFunction("glProgramLocalParameterI4uiNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParameterI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameterI4uivNV != null, "pglProgramLocalParameterI4uivNV not implemented");
					Delegates.pglProgramLocalParameterI4uivNV(target, index, p_params);
					LogFunction("glProgramLocalParameterI4uivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramLocalParametersI4uivNV.
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
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParametersI4uiNV(Int32 target, UInt32 index, Int32 count, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParametersI4uivNV != null, "pglProgramLocalParametersI4uivNV not implemented");
					Delegates.pglProgramLocalParametersI4uivNV(target, index, count, p_params);
					LogFunction("glProgramLocalParametersI4uivNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParameterI4iNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4NV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameterI4iNV != null, "pglProgramEnvParameterI4iNV not implemented");
			Delegates.pglProgramEnvParameterI4iNV(target, index, x, y, z, w);
			LogFunction("glProgramEnvParameterI4iNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParameterI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4NV(Int32 target, UInt32 index, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameterI4ivNV != null, "pglProgramEnvParameterI4ivNV not implemented");
					Delegates.pglProgramEnvParameterI4ivNV(target, index, p_params);
					LogFunction("glProgramEnvParameterI4ivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParametersI4ivNV.
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParametersI4NV(Int32 target, UInt32 index, Int32 count, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParametersI4ivNV != null, "pglProgramEnvParametersI4ivNV not implemented");
					Delegates.pglProgramEnvParametersI4ivNV(target, index, count, p_params);
					LogFunction("glProgramEnvParametersI4ivNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParameterI4uiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameterI4uiNV != null, "pglProgramEnvParameterI4uiNV not implemented");
			Delegates.pglProgramEnvParameterI4uiNV(target, index, x, y, z, w);
			LogFunction("glProgramEnvParameterI4uiNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParameterI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameterI4uivNV != null, "pglProgramEnvParameterI4uivNV not implemented");
					Delegates.pglProgramEnvParameterI4uivNV(target, index, p_params);
					LogFunction("glProgramEnvParameterI4uivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramEnvParametersI4uivNV.
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
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParametersI4uiNV(Int32 target, UInt32 index, Int32 count, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParametersI4uivNV != null, "pglProgramEnvParametersI4uivNV not implemented");
					Delegates.pglProgramEnvParametersI4uivNV(target, index, count, p_params);
					LogFunction("glProgramEnvParametersI4uivNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramLocalParameterIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramLocalParameterINV(Int32 target, UInt32 index, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterIivNV != null, "pglGetProgramLocalParameterIivNV not implemented");
					Delegates.pglGetProgramLocalParameterIivNV(target, index, p_params);
					LogFunction("glGetProgramLocalParameterIivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramLocalParameterIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramLocalParameterINV(Int32 target, UInt32 index, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterIuivNV != null, "pglGetProgramLocalParameterIuivNV not implemented");
					Delegates.pglGetProgramLocalParameterIuivNV(target, index, p_params);
					LogFunction("glGetProgramLocalParameterIuivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramEnvParameterIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramEnvParameterINV(Int32 target, UInt32 index, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterIivNV != null, "pglGetProgramEnvParameterIivNV not implemented");
					Delegates.pglGetProgramEnvParameterIivNV(target, index, p_params);
					LogFunction("glGetProgramEnvParameterIivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramEnvParameterIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramEnvParameterINV(Int32 target, UInt32 index, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterIuivNV != null, "pglGetProgramEnvParameterIuivNV not implemented");
					Delegates.pglGetProgramEnvParameterIuivNV(target, index, p_params);
					LogFunction("glGetProgramEnvParameterIuivNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
