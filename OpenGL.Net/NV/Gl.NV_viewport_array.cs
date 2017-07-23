
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
		/// [GL] Binding for glDepthRangeArrayfvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void DepthRangeArrayNV(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvNV != null, "pglDepthRangeArrayfvNV not implemented");
					Delegates.pglDepthRangeArrayfvNV(first, count, p_v);
					LogCommand("glDepthRangeArrayfvNV", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDepthRangeIndexedfNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void DepthRangeIndexedNV(UInt32 index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfNV != null, "pglDepthRangeIndexedfNV not implemented");
			Delegates.pglDepthRangeIndexedfNV(index, n, f);
			LogCommand("glDepthRangeIndexedfNV", null, index, n, f			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDepthRangeArrayfvNV", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangeArrayfvNV(UInt32 first, Int32 count, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDepthRangeIndexedfNV", ExactSpelling = true)]
			internal extern static void glDepthRangeIndexedfNV(UInt32 index, float n, float f);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDepthRangeArrayfvNV(UInt32 first, Int32 count, float* v);

			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeArrayfvNV pglDepthRangeArrayfvNV;

			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDepthRangeIndexedfNV(UInt32 index, float n, float f);

			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeIndexedfNV pglDepthRangeIndexedfNV;

		}
	}

}
