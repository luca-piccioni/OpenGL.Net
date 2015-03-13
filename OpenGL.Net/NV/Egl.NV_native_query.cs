
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
		/// Binding for eglQueryNativeDisplayNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="display_id">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static IntPtr QueryNativeDisplayNV(IntPtr dpy, IntPtr[] display_id)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_display_id = display_id)
				{
					Debug.Assert(Delegates.peglQueryNativeDisplayNV != null, "peglQueryNativeDisplayNV not implemented");
					retValue = Delegates.peglQueryNativeDisplayNV(dpy, p_display_id);
					CallLog("eglQueryNativeDisplayNV({0}, {1}) = {2}", dpy, display_id, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryNativeWindowNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="window">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static IntPtr QueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr[] window)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_window = window)
				{
					Debug.Assert(Delegates.peglQueryNativeWindowNV != null, "peglQueryNativeWindowNV not implemented");
					retValue = Delegates.peglQueryNativeWindowNV(dpy, surf, p_window);
					CallLog("eglQueryNativeWindowNV({0}, {1}, {2}) = {3}", dpy, surf, window, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryNativePixmapNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static IntPtr QueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr[] pixmap)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_pixmap = pixmap)
				{
					Debug.Assert(Delegates.peglQueryNativePixmapNV != null, "peglQueryNativePixmapNV not implemented");
					retValue = Delegates.peglQueryNativePixmapNV(dpy, surf, p_pixmap);
					CallLog("eglQueryNativePixmapNV({0}, {1}, {2}) = {3}", dpy, surf, pixmap, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
