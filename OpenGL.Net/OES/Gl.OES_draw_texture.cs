
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
		/// Value of GL_TEXTURE_CROP_RECT_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public const int TEXTURE_CROP_RECT_OES = 0x8B9D;

		/// <summary>
		/// Binding for glDrawTexsOES.
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
		/// <param name="width">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
		{
			Debug.Assert(Delegates.pglDrawTexsOES != null, "pglDrawTexsOES not implemented");
			Delegates.pglDrawTexsOES(x, y, z, width, height);
			LogFunction("glDrawTexsOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexiOES.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglDrawTexiOES != null, "pglDrawTexiOES not implemented");
			Delegates.pglDrawTexiOES(x, y, z, width, height);
			LogFunction("glDrawTexiOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexxOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height)
		{
			Debug.Assert(Delegates.pglDrawTexxOES != null, "pglDrawTexxOES not implemented");
			Delegates.pglDrawTexxOES(x, y, z, width, height);
			LogFunction("glDrawTexxOES(0x{0}, 0x{1}, 0x{2}, 0x{3}, 0x{4})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"), width.ToString("X8"), height.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexsvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexsvOES != null, "pglDrawTexsvOES not implemented");
					Delegates.pglDrawTexsvOES(p_coords);
					LogFunction("glDrawTexsvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexivOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexivOES != null, "pglDrawTexivOES not implemented");
					Delegates.pglDrawTexivOES(p_coords);
					LogFunction("glDrawTexivOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexxvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexxvOES != null, "pglDrawTexxvOES not implemented");
					Delegates.pglDrawTexxvOES(p_coords);
					LogFunction("glDrawTexxvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexfOES.
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
		/// <param name="width">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(float x, float y, float z, float width, float height)
		{
			Debug.Assert(Delegates.pglDrawTexfOES != null, "pglDrawTexfOES not implemented");
			Delegates.pglDrawTexfOES(x, y, z, width, height);
			LogFunction("glDrawTexfOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawTexfvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_draw_texture", Api = "gles1")]
		public static void DrawTexOES(float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexfvOES != null, "pglDrawTexfvOES not implemented");
					Delegates.pglDrawTexfvOES(p_coords);
					LogFunction("glDrawTexfvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexsOES", ExactSpelling = true)]
			internal extern static void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexiOES", ExactSpelling = true)]
			internal extern static void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexxOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexxOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexsvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexsvOES(Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexivOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexivOES(Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexxvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexxvOES(IntPtr* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexfOES", ExactSpelling = true)]
			internal extern static void glDrawTexfOES(float x, float y, float z, float width, float height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTexfvOES", ExactSpelling = true)]
			internal extern static unsafe void glDrawTexfvOES(float* coords);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);

			[ThreadStatic]
			internal static glDrawTexsOES pglDrawTexsOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glDrawTexiOES pglDrawTexiOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawTexxOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height);

			[ThreadStatic]
			internal static glDrawTexxOES pglDrawTexxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawTexsvOES(Int16* coords);

			[ThreadStatic]
			internal static glDrawTexsvOES pglDrawTexsvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawTexivOES(Int32* coords);

			[ThreadStatic]
			internal static glDrawTexivOES pglDrawTexivOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawTexxvOES(IntPtr* coords);

			[ThreadStatic]
			internal static glDrawTexxvOES pglDrawTexxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTexfOES(float x, float y, float z, float width, float height);

			[ThreadStatic]
			internal static glDrawTexfOES pglDrawTexfOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawTexfvOES(float* coords);

			[ThreadStatic]
			internal static glDrawTexfvOES pglDrawTexfvOES;

		}
	}

}
