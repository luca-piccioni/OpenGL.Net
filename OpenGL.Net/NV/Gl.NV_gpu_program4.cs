
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

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4iNV", ExactSpelling = true)]
			internal extern static void glProgramLocalParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParametersI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4uiNV", ExactSpelling = true)]
			internal extern static void glProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParameterI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramLocalParametersI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4iNV", ExactSpelling = true)]
			internal extern static void glProgramEnvParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParametersI4ivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4uiNV", ExactSpelling = true)]
			internal extern static void glProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParameterI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramEnvParametersI4uivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterIivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterIivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glProgramLocalParameterI4iNV pglProgramLocalParameterI4iNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glProgramLocalParameterI4ivNV pglProgramLocalParameterI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glProgramLocalParametersI4ivNV pglProgramLocalParametersI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glProgramLocalParameterI4uiNV pglProgramLocalParameterI4uiNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glProgramLocalParameterI4uivNV pglProgramLocalParameterI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramLocalParametersI4uivNV pglProgramLocalParametersI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glProgramEnvParameterI4iNV pglProgramEnvParameterI4iNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glProgramEnvParameterI4ivNV pglProgramEnvParameterI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glProgramEnvParametersI4ivNV pglProgramEnvParametersI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glProgramEnvParameterI4uiNV pglProgramEnvParameterI4uiNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glProgramEnvParameterI4uivNV pglProgramEnvParameterI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glProgramEnvParametersI4uivNV pglProgramEnvParametersI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterIivNV pglGetProgramLocalParameterIivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetProgramLocalParameterIuivNV pglGetProgramLocalParameterIuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterIivNV pglGetProgramEnvParameterIivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetProgramEnvParameterIuivNV pglGetProgramEnvParameterIuivNV;

		}
	}

}
