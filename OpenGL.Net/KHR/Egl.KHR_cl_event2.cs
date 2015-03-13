
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
		/// Binding for eglCreateSync64KHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public static IntPtr CreateSyncKHR(IntPtr dpy, uint type, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateSync64KHR != null, "peglCreateSync64KHR not implemented");
					retValue = Delegates.peglCreateSync64KHR(dpy, type, p_attrib_list);
					CallLog("eglCreateSync64KHR({0}, {1}, {2}) = {3}", dpy, type, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
