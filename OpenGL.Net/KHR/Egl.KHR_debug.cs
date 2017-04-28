
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
		/// [EGL] Value of EGL_OBJECT_THREAD_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_THREAD_KHR = 0x33B0;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_DISPLAY_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_DISPLAY_KHR = 0x33B1;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_CONTEXT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_CONTEXT_KHR = 0x33B2;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_SURFACE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_SURFACE_KHR = 0x33B3;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_IMAGE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_IMAGE_KHR = 0x33B4;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_SYNC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_SYNC_KHR = 0x33B5;

		/// <summary>
		/// [EGL] Value of EGL_OBJECT_STREAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int OBJECT_STREAM_KHR = 0x33B6;

		/// <summary>
		/// [EGL] Value of EGL_DEBUG_MSG_CRITICAL_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int DEBUG_MSG_CRITICAL_KHR = 0x33B9;

		/// <summary>
		/// [EGL] Value of EGL_DEBUG_MSG_ERROR_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int DEBUG_MSG_ERROR_KHR = 0x33BA;

		/// <summary>
		/// [EGL] Value of EGL_DEBUG_MSG_WARN_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int DEBUG_MSG_WARN_KHR = 0x33BB;

		/// <summary>
		/// [EGL] Value of EGL_DEBUG_MSG_INFO_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int DEBUG_MSG_INFO_KHR = 0x33BC;

		/// <summary>
		/// [EGL] Value of EGL_DEBUG_CALLBACK_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_debug")]
		public const int DEBUG_CALLBACK_KHR = 0x33B8;

		/// <summary>
		/// Binding for eglDebugMessageControlKHR.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:DebugProcKHR"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_debug")]
		public static int KHR(DebugProcKHR callback, IntPtr[] attrib_list)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglDebugMessageControlKHR != null, "peglDebugMessageControlKHR not implemented");
					retValue = Delegates.peglDebugMessageControlKHR(callback, p_attrib_list);
					LogCommand("eglDebugMessageControlKHR", retValue, callback, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryDebugKHR.
		/// </summary>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_debug")]
		public static bool QueryKHR(int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDebugKHR != null, "peglQueryDebugKHR not implemented");
					retValue = Delegates.peglQueryDebugKHR(attribute, p_value);
					LogCommand("eglQueryDebugKHR", retValue, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglLabelObjectKHR.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="objectType">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="object">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_debug")]
		public static int KHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label)
		{
			int retValue;

			Debug.Assert(Delegates.peglLabelObjectKHR != null, "peglLabelObjectKHR not implemented");
			retValue = Delegates.peglLabelObjectKHR(display, objectType, @object, label);
			LogCommand("eglLabelObjectKHR", retValue, display, objectType, @object, label			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglDebugMessageControlKHR", ExactSpelling = true)]
			internal extern static unsafe int eglDebugMessageControlKHR(DebugProcKHR callback, IntPtr* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDebugKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDebugKHR(int attribute, IntPtr* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglLabelObjectKHR", ExactSpelling = true)]
			internal extern static unsafe int eglLabelObjectKHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_debug")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglDebugMessageControlKHR(DebugProcKHR callback, IntPtr* attrib_list);

			internal static eglDebugMessageControlKHR peglDebugMessageControlKHR;

			[RequiredByFeature("EGL_KHR_debug")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDebugKHR(int attribute, IntPtr* value);

			internal static eglQueryDebugKHR peglQueryDebugKHR;

			[RequiredByFeature("EGL_KHR_debug")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglLabelObjectKHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label);

			internal static eglLabelObjectKHR peglLabelObjectKHR;

		}
	}

}
