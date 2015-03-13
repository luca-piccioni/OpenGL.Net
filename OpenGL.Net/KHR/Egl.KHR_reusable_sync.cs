
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
		/// Value of EGL_SYNC_STATUS_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_STATUS.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SYNC_STATUS_KHR = 0x30F1;

		/// <summary>
		/// Value of EGL_SIGNALED_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SIGNALED.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SIGNALED_KHR = 0x30F2;

		/// <summary>
		/// Value of EGL_UNSIGNALED_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to UNSIGNALED.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int UNSIGNALED_KHR = 0x30F3;

		/// <summary>
		/// Value of EGL_TIMEOUT_EXPIRED_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to TIMEOUT_EXPIRED.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int TIMEOUT_EXPIRED_KHR = 0x30F5;

		/// <summary>
		/// Value of EGL_CONDITION_SATISFIED_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CONDITION_SATISFIED.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int CONDITION_SATISFIED_KHR = 0x30F6;

		/// <summary>
		/// Value of EGL_SYNC_TYPE_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_TYPE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		[RequiredByFeature("EGL_NV_stream_sync")]
		public const int SYNC_TYPE_KHR = 0x30F7;

		/// <summary>
		/// Value of EGL_SYNC_REUSABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SYNC_REUSABLE_KHR = 0x30FA;

		/// <summary>
		/// Value of EGL_SYNC_FLUSH_COMMANDS_BIT_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_FLUSH_COMMANDS_BIT.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SYNC_FLUSH_COMMANDS_BIT_KHR = 0x0001;

		/// <summary>
		/// Value of EGL_FOREVER_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOREVER.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const ulong FOREVER_KHR = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// Value of EGL_NO_SYNC_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to NO_SYNC.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int NO_SYNC_KHR = 0;

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
			CallLog("eglSignalSyncKHR({0}, {1}, {2}) = {3}", dpy, sync, mode, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
