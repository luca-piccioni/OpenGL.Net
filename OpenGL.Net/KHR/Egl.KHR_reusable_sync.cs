
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_SYNC_REUSABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SYNC_REUSABLE_KHR = 0x30FA;

		/// <summary>
		/// Binding for eglCreateSyncKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static IntPtr CreateSyncKHR(IntPtr dpy, uint type, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateSyncKHR != null, "peglCreateSyncKHR not implemented");
					retValue = Delegates.peglCreateSyncKHR(dpy, type, p_attrib_list);
					CallLog("eglCreateSyncKHR(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), type, attrib_list, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglSignalSyncKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static IntPtr SignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglSignalSyncKHR != null, "peglSignalSyncKHR not implemented");
			retValue = Delegates.peglSignalSyncKHR(dpy, sync, mode);
			CallLog("eglSignalSyncKHR(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), sync.ToString("X8"), mode, retValue.ToString("X8"));
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetSyncAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static IntPtr GetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, [Out] int[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttribKHR != null, "peglGetSyncAttribKHR not implemented");
					retValue = Delegates.peglGetSyncAttribKHR(dpy, sync, attribute, p_value);
					CallLog("eglGetSyncAttribKHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), sync.ToString("X8"), attribute, value, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
