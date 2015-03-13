
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
		/// Value of EGL_NO_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		public const int NO_DEVICE_EXT = 0;

		/// <summary>
		/// Value of EGL_BAD_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		public const int BAD_DEVICE_EXT = 0x322B;

		/// <summary>
		/// Value of EGL_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		public const int DEVICE_EXT = 0x322C;

		/// <summary>
		/// Binding for eglQueryDeviceAttribEXT.
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
		public static IntPtr QueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDeviceAttribEXT != null, "peglQueryDeviceAttribEXT not implemented");
					retValue = Delegates.peglQueryDeviceAttribEXT(device, attribute, p_value);
					CallLog("eglQueryDeviceAttribEXT({0}, {1}, {2}) = {3}", device, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryDeviceStringEXT.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		public static string QueryDeviceStringEXT(IntPtr device, int name)
		{
			string retValue;

			Debug.Assert(Delegates.peglQueryDeviceStringEXT != null, "peglQueryDeviceStringEXT not implemented");
			retValue = Delegates.peglQueryDeviceStringEXT(device, name);
			CallLog("eglQueryDeviceStringEXT({0}, {1}) = {2}", device, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryDevicesEXT.
		/// </summary>
		/// <param name="max_devices">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="devices">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="num_devices">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		public static IntPtr QueryDevicesEXT(int max_devices, IntPtr[] devices, int[] num_devices)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_devices = devices)
				fixed (int* p_num_devices = num_devices)
				{
					Debug.Assert(Delegates.peglQueryDevicesEXT != null, "peglQueryDevicesEXT not implemented");
					retValue = Delegates.peglQueryDevicesEXT(max_devices, p_devices, p_num_devices);
					CallLog("eglQueryDevicesEXT({0}, {1}, {2}) = {3}", max_devices, devices, num_devices, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryDisplayAttribEXT.
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
		[RequiredByFeature("EGL_EXT_device_base")]
		public static IntPtr QueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDisplayAttribEXT != null, "peglQueryDisplayAttribEXT not implemented");
					retValue = Delegates.peglQueryDisplayAttribEXT(dpy, attribute, p_value);
					CallLog("eglQueryDisplayAttribEXT({0}, {1}, {2}) = {3}", dpy, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
