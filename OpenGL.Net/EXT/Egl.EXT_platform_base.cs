
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Binding for eglGetPlatformDisplayEXT.
		/// </summary>
		/// <param name="platform">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="native_display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr GetPlatformDisplayEXT(uint platform, IntPtr native_display, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglGetPlatformDisplayEXT != null, "peglGetPlatformDisplayEXT not implemented");
					retValue = Delegates.peglGetPlatformDisplayEXT(platform, native_display, p_attrib_list);
					LogCommand("eglGetPlatformDisplayEXT", retValue, platform, native_display, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglCreatePlatformWindowSurfaceEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr CreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformWindowSurfaceEXT != null, "peglCreatePlatformWindowSurfaceEXT not implemented");
					retValue = Delegates.peglCreatePlatformWindowSurfaceEXT(dpy, config, native_window, p_attrib_list);
					LogCommand("eglCreatePlatformWindowSurfaceEXT", retValue, dpy, config, native_window, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglCreatePlatformPixmapSurfaceEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_platform_base")]
		public static IntPtr CreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformPixmapSurfaceEXT != null, "peglCreatePlatformPixmapSurfaceEXT not implemented");
					retValue = Delegates.peglCreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap, p_attrib_list);
					LogCommand("eglCreatePlatformPixmapSurfaceEXT", retValue, dpy, config, native_pixmap, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglGetPlatformDisplayEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglCreatePlatformWindowSurfaceEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglGetPlatformDisplayEXT peglGetPlatformDisplayEXT;

			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglCreatePlatformWindowSurfaceEXT peglCreatePlatformWindowSurfaceEXT;

			[RequiredByFeature("EGL_EXT_platform_base")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			[RequiredByFeature("EGL_EXT_platform_base")]
			internal static eglCreatePlatformPixmapSurfaceEXT peglCreatePlatformPixmapSurfaceEXT;

		}
	}

}
