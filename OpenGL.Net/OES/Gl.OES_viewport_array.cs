
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
		/// Binding for glDepthRangeArrayfvOES.
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
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void DepthRangeArrayOES(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvOES != null, "pglDepthRangeArrayfvOES not implemented");
					Delegates.pglDepthRangeArrayfvOES(first, count, p_v);
					LogCommand("glDepthRangeArrayfvOES", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthRangeIndexedfOES.
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
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public static void DepthRangeIndexedOES(UInt32 index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfOES != null, "pglDepthRangeIndexedfOES not implemented");
			Delegates.pglDepthRangeIndexedfOES(index, n, f);
			LogCommand("glDepthRangeIndexedfOES", null, index, n, f			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangeArrayfvOES", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangeArrayfvOES(UInt32 first, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangeIndexedfOES", ExactSpelling = true)]
			internal extern static void glDepthRangeIndexedfOES(UInt32 index, float n, float f);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangeArrayfvOES(UInt32 first, Int32 count, float* v);

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeArrayfvOES pglDepthRangeArrayfvOES;

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangeIndexedfOES(UInt32 index, float n, float f);

			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			[ThreadStatic]
			internal static glDepthRangeIndexedfOES pglDepthRangeIndexedfOES;

		}
	}

}
