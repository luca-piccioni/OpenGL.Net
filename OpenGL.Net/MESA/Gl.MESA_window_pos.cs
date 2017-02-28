
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Binding for glWindowPos4dMESA.
		/// </summary>
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglWindowPos4dMESA != null, "pglWindowPos4dMESA not implemented");
			Delegates.pglWindowPos4dMESA(x, y, z, w);
			LogFunction("glWindowPos4dMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4dvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4dvMESA != null, "pglWindowPos4dvMESA not implemented");
					Delegates.pglWindowPos4dvMESA(p_v);
					LogFunction("glWindowPos4dvMESA({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4fMESA.
		/// </summary>
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglWindowPos4fMESA != null, "pglWindowPos4fMESA not implemented");
			Delegates.pglWindowPos4fMESA(x, y, z, w);
			LogFunction("glWindowPos4fMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4fvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4fvMESA != null, "pglWindowPos4fvMESA not implemented");
					Delegates.pglWindowPos4fvMESA(p_v);
					LogFunction("glWindowPos4fvMESA({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4iMESA.
		/// </summary>
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglWindowPos4iMESA != null, "pglWindowPos4iMESA not implemented");
			Delegates.pglWindowPos4iMESA(x, y, z, w);
			LogFunction("glWindowPos4iMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4ivMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4ivMESA != null, "pglWindowPos4ivMESA not implemented");
					Delegates.pglWindowPos4ivMESA(p_v);
					LogFunction("glWindowPos4ivMESA({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4sMESA.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglWindowPos4sMESA != null, "pglWindowPos4sMESA not implemented");
			Delegates.pglWindowPos4sMESA(x, y, z, w);
			LogFunction("glWindowPos4sMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWindowPos4svMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4svMESA != null, "pglWindowPos4svMESA not implemented");
					Delegates.pglWindowPos4svMESA(p_v);
					LogFunction("glWindowPos4svMESA({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4dMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4dMESA(double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4dvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4dvMESA(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4fMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4fMESA(float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4fvMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4fvMESA(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4iMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4ivMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4ivMESA(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4sMESA", ExactSpelling = true)]
			internal extern static void glWindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos4svMESA", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos4svMESA(Int16* v);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4dMESA(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glWindowPos4dMESA pglWindowPos4dMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4dvMESA(double* v);

			[ThreadStatic]
			internal static glWindowPos4dvMESA pglWindowPos4dvMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4fMESA(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glWindowPos4fMESA pglWindowPos4fMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4fvMESA(float* v);

			[ThreadStatic]
			internal static glWindowPos4fvMESA pglWindowPos4fvMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glWindowPos4iMESA pglWindowPos4iMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4ivMESA(Int32* v);

			[ThreadStatic]
			internal static glWindowPos4ivMESA pglWindowPos4ivMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glWindowPos4sMESA pglWindowPos4sMESA;

			[RequiredByFeature("GL_MESA_window_pos")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4svMESA(Int16* v);

			[ThreadStatic]
			internal static glWindowPos4svMESA pglWindowPos4svMESA;

		}
	}

}
