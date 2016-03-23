
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
	public partial class Egl
	{
		/// <summary>
		/// Binding for eglGetPlatformDisplayEXT.
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
					LogFunction("eglGetPlatformDisplayEXT({0}, 0x{1}, {2}) = {3}", platform, native_display.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePlatformWindowSurfaceEXT.
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
					LogFunction("eglCreatePlatformWindowSurfaceEXT(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), native_window.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePlatformPixmapSurfaceEXT.
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
					LogFunction("eglCreatePlatformPixmapSurfaceEXT(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), native_pixmap.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
