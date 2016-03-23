
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
		/// Value of EGL_READ_SURFACE_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		[Log(BitmaskName = "EGLLockUsageHintKHRMask")]
		public const int READ_SURFACE_BIT_KHR = 0x0001;

		/// <summary>
		/// Value of EGL_WRITE_SURFACE_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		[Log(BitmaskName = "EGLLockUsageHintKHRMask")]
		public const int WRITE_SURFACE_BIT_KHR = 0x0002;

		/// <summary>
		/// Value of EGL_LOCK_SURFACE_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int LOCK_SURFACE_BIT_KHR = 0x0080;

		/// <summary>
		/// Value of EGL_OPTIMAL_FORMAT_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int OPTIMAL_FORMAT_BIT_KHR = 0x0100;

		/// <summary>
		/// Value of EGL_MATCH_FORMAT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int MATCH_FORMAT_KHR = 0x3043;

		/// <summary>
		/// Value of EGL_FORMAT_RGB_565_EXACT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int FORMAT_RGB_565_EXACT_KHR = 0x30C0;

		/// <summary>
		/// Value of EGL_FORMAT_RGB_565_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int FORMAT_RGB_565_KHR = 0x30C1;

		/// <summary>
		/// Value of EGL_FORMAT_RGBA_8888_EXACT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int FORMAT_RGBA_8888_EXACT_KHR = 0x30C2;

		/// <summary>
		/// Value of EGL_FORMAT_RGBA_8888_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int FORMAT_RGBA_8888_KHR = 0x30C3;

		/// <summary>
		/// Value of EGL_MAP_PRESERVE_PIXELS_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int MAP_PRESERVE_PIXELS_KHR = 0x30C4;

		/// <summary>
		/// Value of EGL_LOCK_USAGE_HINT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int LOCK_USAGE_HINT_KHR = 0x30C5;

		/// <summary>
		/// Value of EGL_BITMAP_PITCH_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PITCH_KHR = 0x30C7;

		/// <summary>
		/// Value of EGL_BITMAP_ORIGIN_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_ORIGIN_KHR = 0x30C8;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_RED_OFFSET_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_RED_OFFSET_KHR = 0x30C9;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_GREEN_OFFSET_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_GREEN_OFFSET_KHR = 0x30CA;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_BLUE_OFFSET_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_BLUE_OFFSET_KHR = 0x30CB;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_ALPHA_OFFSET_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_ALPHA_OFFSET_KHR = 0x30CC;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_LUMINANCE_OFFSET_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_LUMINANCE_OFFSET_KHR = 0x30CD;

		/// <summary>
		/// Value of EGL_BITMAP_PIXEL_SIZE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface2")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_PIXEL_SIZE_KHR = 0x3110;

		/// <summary>
		/// Value of EGL_BITMAP_POINTER_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int BITMAP_POINTER_KHR = 0x30C6;

		/// <summary>
		/// Value of EGL_LOWER_LEFT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int LOWER_LEFT_KHR = 0x30CE;

		/// <summary>
		/// Value of EGL_UPPER_LEFT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public const int UPPER_LEFT_KHR = 0x30CF;

		/// <summary>
		/// Binding for eglLockSurfaceKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public static bool LockSurfaceKHR(IntPtr dpy, IntPtr surface, int[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglLockSurfaceKHR != null, "peglLockSurfaceKHR not implemented");
					retValue = Delegates.peglLockSurfaceKHR(dpy, surface, p_attrib_list);
					LogFunction("eglLockSurfaceKHR(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), surface.ToString("X8"), LogValue(attrib_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglUnlockSurfaceKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_lock_surface")]
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public static bool UnlockSurfaceKHR(IntPtr dpy, IntPtr surface)
		{
			bool retValue;

			Debug.Assert(Delegates.peglUnlockSurfaceKHR != null, "peglUnlockSurfaceKHR not implemented");
			retValue = Delegates.peglUnlockSurfaceKHR(dpy, surface);
			LogFunction("eglUnlockSurfaceKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), surface.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQuerySurface64KHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_lock_surface3")]
		public static bool QuerySurfaceKHR(IntPtr dpy, IntPtr surface, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQuerySurface64KHR != null, "peglQuerySurface64KHR not implemented");
					retValue = Delegates.peglQuerySurface64KHR(dpy, surface, attribute, p_value);
					LogFunction("eglQuerySurface64KHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), surface.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
