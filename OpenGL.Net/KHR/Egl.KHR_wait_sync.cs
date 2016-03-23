
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
		/// Binding for eglWaitSyncKHR.
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
		[RequiredByFeature("EGL_KHR_wait_sync")]
		public static int WaitSyncKHR(IntPtr dpy, IntPtr sync, int flags)
		{
			int retValue;

			Debug.Assert(Delegates.peglWaitSyncKHR != null, "peglWaitSyncKHR not implemented");
			retValue = Delegates.peglWaitSyncKHR(dpy, sync, flags);
			LogFunction("eglWaitSyncKHR(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), sync.ToString("X8"), flags, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
