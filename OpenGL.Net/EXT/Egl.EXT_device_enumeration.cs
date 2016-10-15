
// Copyright (C) 2015-2016 Luca Piccioni
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
		[RequiredByFeature("EGL_EXT_device_enumeration")]
		public static bool QueryDevicesEXT(int max_devices, IntPtr[] devices, int[] num_devices)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_devices = devices)
				fixed (int* p_num_devices = num_devices)
				{
					Debug.Assert(Delegates.peglQueryDevicesEXT != null, "peglQueryDevicesEXT not implemented");
					retValue = Delegates.peglQueryDevicesEXT(max_devices, p_devices, p_num_devices);
					LogFunction("eglQueryDevicesEXT({0}, {1}, {2}) = {3}", max_devices, LogValue(devices), LogValue(num_devices), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDevicesEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			internal static eglQueryDevicesEXT peglQueryDevicesEXT;

		}
	}

}
