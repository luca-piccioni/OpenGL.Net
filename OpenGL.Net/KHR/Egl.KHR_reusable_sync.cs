
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
		/// [EGL] Value of EGL_SYNC_REUSABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public const int SYNC_REUSABLE_KHR = 0x30FA;

		/// <summary>
		/// [EGL] Binding for eglCreateSyncKHR.
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
					LogCommand("eglCreateSyncKHR", retValue, dpy, type, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglSignalSyncKHR.
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
		public static bool SignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSignalSyncKHR != null, "peglSignalSyncKHR not implemented");
			retValue = Delegates.peglSignalSyncKHR(dpy, sync, mode);
			LogCommand("eglSignalSyncKHR", retValue, dpy, sync, mode			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglGetSyncAttribKHR.
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
		public static bool GetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, [Out] int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttribKHR != null, "peglGetSyncAttribKHR not implemented");
					retValue = Delegates.peglGetSyncAttribKHR(dpy, sync, attribute, p_value);
					LogCommand("eglGetSyncAttribKHR", retValue, dpy, sync, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateSyncKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglSignalSyncKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetSyncAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			internal static eglCreateSyncKHR peglCreateSyncKHR;

			[RequiredByFeature("EGL_KHR_reusable_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			[RequiredByFeature("EGL_KHR_reusable_sync")]
			internal static eglSignalSyncKHR peglSignalSyncKHR;

			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

			[RequiredByFeature("EGL_KHR_fence_sync")]
			[RequiredByFeature("EGL_KHR_reusable_sync")]
			internal static eglGetSyncAttribKHR peglGetSyncAttribKHR;

		}
	}

}
