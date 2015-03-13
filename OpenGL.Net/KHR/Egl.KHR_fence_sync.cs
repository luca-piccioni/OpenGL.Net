
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
		/// Value of EGL_SYNC_PRIOR_COMMANDS_COMPLETE_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_PRIOR_COMMANDS_COMPLETE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		public const int SYNC_PRIOR_COMMANDS_COMPLETE_KHR = 0x30F0;

		/// <summary>
		/// Value of EGL_SYNC_CONDITION_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_CONDITION.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		public const int SYNC_CONDITION_KHR = 0x30F8;

		/// <summary>
		/// Value of EGL_SYNC_FENCE_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_FENCE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		public const int SYNC_FENCE_KHR = 0x30F9;

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
					CallLog("eglCreateSyncKHR({0}, {1}, {2}) = {3}", dpy, type, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroySyncKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static IntPtr DestroySyncKHR(IntPtr dpy, IntPtr sync)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglDestroySyncKHR != null, "peglDestroySyncKHR not implemented");
			retValue = Delegates.peglDestroySyncKHR(dpy, sync);
			CallLog("eglDestroySyncKHR({0}, {1}) = {2}", dpy, sync, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglClientWaitSyncKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static int ClientWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.peglClientWaitSyncKHR != null, "peglClientWaitSyncKHR not implemented");
			retValue = Delegates.peglClientWaitSyncKHR(dpy, sync, flags, timeout);
			CallLog("eglClientWaitSyncKHR({0}, {1}, {2}, {3}) = {4}", dpy, sync, flags, timeout, retValue);
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
		public static IntPtr GetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttribKHR != null, "peglGetSyncAttribKHR not implemented");
					retValue = Delegates.peglGetSyncAttribKHR(dpy, sync, attribute, p_value);
					CallLog("eglGetSyncAttribKHR({0}, {1}, {2}, {3}) = {4}", dpy, sync, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
