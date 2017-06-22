
// Copyright (C) 2015-2017 Luca Piccioni
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
		/// [GL] Value of GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int FRAGMENT_PROGRAM_NV = 0x8870;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int FRAGMENT_PROGRAM_BINDING_NV = 0x8873;

		/// <summary>
		/// [GL] Binding for glProgramNamedParameter4fNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(UInt32 id, Int32 len, byte[] name, float x, float y, float z, float w)
		{
			unsafe {
				fixed (byte* p_name = name)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4fNV != null, "pglProgramNamedParameter4fNV not implemented");
					Delegates.pglProgramNamedParameter4fNV(id, len, p_name, x, y, z, w);
					LogCommand("glProgramNamedParameter4fNV", null, id, len, name, x, y, z, w					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramNamedParameter4fvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(UInt32 id, Int32 len, byte[] name, float[] v)
		{
			unsafe {
				fixed (byte* p_name = name)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4fvNV != null, "pglProgramNamedParameter4fvNV not implemented");
					Delegates.pglProgramNamedParameter4fvNV(id, len, p_name, p_v);
					LogCommand("glProgramNamedParameter4fvNV", null, id, len, name, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramNamedParameter4dNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(UInt32 id, Int32 len, byte[] name, double x, double y, double z, double w)
		{
			unsafe {
				fixed (byte* p_name = name)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4dNV != null, "pglProgramNamedParameter4dNV not implemented");
					Delegates.pglProgramNamedParameter4dNV(id, len, p_name, x, y, z, w);
					LogCommand("glProgramNamedParameter4dNV", null, id, len, name, x, y, z, w					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramNamedParameter4dvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void ProgramNamedParameter4NV(UInt32 id, Int32 len, byte[] name, double[] v)
		{
			unsafe {
				fixed (byte* p_name = name)
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramNamedParameter4dvNV != null, "pglProgramNamedParameter4dvNV not implemented");
					Delegates.pglProgramNamedParameter4dvNV(id, len, p_name, p_v);
					LogCommand("glProgramNamedParameter4dvNV", null, id, len, name, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramNamedParameterfvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void GetProgramNamedParameterNV(UInt32 id, Int32 len, byte[] name, [Out] float[] @params)
		{
			unsafe {
				fixed (byte* p_name = name)
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramNamedParameterfvNV != null, "pglGetProgramNamedParameterfvNV not implemented");
					Delegates.pglGetProgramNamedParameterfvNV(id, len, p_name, p_params);
					LogCommand("glGetProgramNamedParameterfvNV", null, id, len, name, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramNamedParameterdvNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_program")]
		public static void GetProgramNamedParameterNV(UInt32 id, Int32 len, byte[] name, [Out] double[] @params)
		{
			unsafe {
				fixed (byte* p_name = name)
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramNamedParameterdvNV != null, "pglGetProgramNamedParameterdvNV not implemented");
					Delegates.pglGetProgramNamedParameterdvNV(id, len, p_name, p_params);
					LogCommand("glGetProgramNamedParameterdvNV", null, id, len, name, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramNamedParameter4fNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4fNV(UInt32 id, Int32 len, byte* name, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramNamedParameter4fvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4fvNV(UInt32 id, Int32 len, byte* name, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramNamedParameter4dNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4dNV(UInt32 id, Int32 len, byte* name, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramNamedParameter4dvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramNamedParameter4dvNV(UInt32 id, Int32 len, byte* name, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramNamedParameterfvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramNamedParameterfvNV(UInt32 id, Int32 len, byte* name, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramNamedParameterdvNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramNamedParameterdvNV(UInt32 id, Int32 len, byte* name, double* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4fNV(UInt32 id, Int32 len, byte* name, float x, float y, float z, float w);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4fNV pglProgramNamedParameter4fNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4fvNV(UInt32 id, Int32 len, byte* name, float* v);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4fvNV pglProgramNamedParameter4fvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4dNV(UInt32 id, Int32 len, byte* name, double x, double y, double z, double w);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4dNV pglProgramNamedParameter4dNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4dvNV(UInt32 id, Int32 len, byte* name, double* v);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glProgramNamedParameter4dvNV pglProgramNamedParameter4dvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramNamedParameterfvNV(UInt32 id, Int32 len, byte* name, float* @params);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glGetProgramNamedParameterfvNV pglGetProgramNamedParameterfvNV;

			[RequiredByFeature("GL_NV_fragment_program")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramNamedParameterdvNV(UInt32 id, Int32 len, byte* name, double* @params);

			[RequiredByFeature("GL_NV_fragment_program")]
			[ThreadStatic]
			internal static glGetProgramNamedParameterdvNV pglGetProgramNamedParameterdvNV;

		}
	}

}
