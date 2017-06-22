
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
		/// [EGL] Value of EGL_NO_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int NO_DEVICE_EXT = 0;

		/// <summary>
		/// [EGL] Value of EGL_BAD_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int BAD_DEVICE_EXT = 0x322B;

		/// <summary>
		/// [EGL] Value of EGL_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int DEVICE_EXT = 0x322C;

		/// <summary>
		/// [EGL] Binding for eglQueryDeviceAttribEXT.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public static bool QueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDeviceAttribEXT != null, "peglQueryDeviceAttribEXT not implemented");
					retValue = Delegates.peglQueryDeviceAttribEXT(device, attribute, p_value);
					LogCommand("eglQueryDeviceAttribEXT", retValue, device, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglQueryDeviceStringEXT.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public static string QueryDeviceStringEXT(IntPtr device, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryDeviceStringEXT != null, "peglQueryDeviceStringEXT not implemented");
			retValue = Delegates.peglQueryDeviceStringEXT(device, name);
			LogCommand("eglQueryDeviceStringEXT", Marshal.PtrToStringAnsi(retValue), device, name			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// [EGL] Binding for eglQueryDisplayAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[AliasOf("eglQueryDisplayAttribNV")]
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool QueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDisplayAttribEXT != null, "peglQueryDisplayAttribEXT not implemented");
					retValue = Delegates.peglQueryDisplayAttribEXT(dpy, attribute, p_value);
					LogCommand("eglQueryDisplayAttribEXT", retValue, dpy, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDeviceAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDeviceStringEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDisplayAttribEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			internal static eglQueryDeviceAttribEXT peglQueryDeviceAttribEXT;

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			internal static eglQueryDeviceStringEXT peglQueryDeviceStringEXT;

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[RequiredByFeature("EGL_NV_stream_metadata")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[AliasOf("eglQueryDisplayAttribEXT")]
			[AliasOf("eglQueryDisplayAttribNV")]
			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[RequiredByFeature("EGL_NV_stream_metadata")]
			internal static eglQueryDisplayAttribEXT peglQueryDisplayAttribEXT;

		}
	}

}
