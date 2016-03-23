
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
		/// Value of EGL_SYNC_PRIOR_COMMANDS_COMPLETE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_PRIOR_COMMANDS_COMPLETE_NV = 0x30E6;

		/// <summary>
		/// Value of EGL_SYNC_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_STATUS_NV = 0x30E7;

		/// <summary>
		/// Value of EGL_SIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SIGNALED_NV = 0x30E8;

		/// <summary>
		/// Value of EGL_UNSIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int UNSIGNALED_NV = 0x30E9;

		/// <summary>
		/// Value of EGL_ALREADY_SIGNALED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int ALREADY_SIGNALED_NV = 0x30EA;

		/// <summary>
		/// Value of EGL_TIMEOUT_EXPIRED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int TIMEOUT_EXPIRED_NV = 0x30EB;

		/// <summary>
		/// Value of EGL_CONDITION_SATISFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int CONDITION_SATISFIED_NV = 0x30EC;

		/// <summary>
		/// Value of EGL_SYNC_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_TYPE_NV = 0x30ED;

		/// <summary>
		/// Value of EGL_SYNC_CONDITION_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_CONDITION_NV = 0x30EE;

		/// <summary>
		/// Value of EGL_SYNC_FENCE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_sync")]
		public const int SYNC_FENCE_NV = 0x30EF;

		/// <summary>
		/// Binding for eglCreateFenceSyncNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="condition">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static IntPtr CreateFenceSyncNV(IntPtr dpy, uint condition, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateFenceSyncNV != null, "peglCreateFenceSyncNV not implemented");
					retValue = Delegates.peglCreateFenceSyncNV(dpy, condition, p_attrib_list);
					LogFunction("eglCreateFenceSyncNV(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), condition, LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroySyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool DestroySyncNV(IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroySyncNV != null, "peglDestroySyncNV not implemented");
			retValue = Delegates.peglDestroySyncNV(sync);
			LogFunction("eglDestroySyncNV(0x{0}) = {1}", sync.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglFenceNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool FenceNV(IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglFenceNV != null, "peglFenceNV not implemented");
			retValue = Delegates.peglFenceNV(sync);
			LogFunction("eglFenceNV(0x{0}) = {1}", sync.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglClientWaitSyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static int ClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.peglClientWaitSyncNV != null, "peglClientWaitSyncNV not implemented");
			retValue = Delegates.peglClientWaitSyncNV(sync, flags, timeout);
			LogFunction("eglClientWaitSyncNV(0x{0}, {1}, {2}) = {3}", sync.ToString("X8"), flags, timeout, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglSignalSyncNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool SignalSyncNV(IntPtr sync, uint mode)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSignalSyncNV != null, "peglSignalSyncNV not implemented");
			retValue = Delegates.peglSignalSyncNV(sync, mode);
			LogFunction("eglSignalSyncNV(0x{0}, {1}) = {2}", sync.ToString("X8"), mode, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetSyncAttribNV.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_sync")]
		public static bool GetSyncAttribNV(IntPtr sync, int attribute, [Out] int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttribNV != null, "peglGetSyncAttribNV not implemented");
					retValue = Delegates.peglGetSyncAttribNV(sync, attribute, p_value);
					LogFunction("eglGetSyncAttribNV(0x{0}, {1}, {2}) = {3}", sync.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
