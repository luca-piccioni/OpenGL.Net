
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
		/// Value of EGL_STREAM_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int STREAM_BIT_KHR = 0x0800;

		/// <summary>
		/// Binding for eglCreateStreamProducerSurfaceKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
		public static IntPtr CreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamProducerSurfaceKHR != null, "peglCreateStreamProducerSurfaceKHR not implemented");
					retValue = Delegates.peglCreateStreamProducerSurfaceKHR(dpy, config, stream, p_attrib_list);
					LogFunction("eglCreateStreamProducerSurfaceKHR(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), stream.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
