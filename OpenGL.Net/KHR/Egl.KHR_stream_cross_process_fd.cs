
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
		/// Value of EGL_NO_FILE_DESCRIPTOR_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_cross_process_fd")]
		public const int NO_FILE_DESCRIPTOR_KHR = -1;

		/// <summary>
		/// Binding for eglGetStreamFileDescriptorKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_cross_process_fd")]
		public static int GetStreamFileDescriptorKHR(IntPtr dpy, IntPtr stream)
		{
			int retValue;

			Debug.Assert(Delegates.peglGetStreamFileDescriptorKHR != null, "peglGetStreamFileDescriptorKHR not implemented");
			retValue = Delegates.peglGetStreamFileDescriptorKHR(dpy, stream);
			LogFunction("eglGetStreamFileDescriptorKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreateStreamFromFileDescriptorKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="file_descriptor">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_cross_process_fd")]
		public static IntPtr CreateStreamFromFileDescriptorKHR(IntPtr dpy, int file_descriptor)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglCreateStreamFromFileDescriptorKHR != null, "peglCreateStreamFromFileDescriptorKHR not implemented");
			retValue = Delegates.peglCreateStreamFromFileDescriptorKHR(dpy, file_descriptor);
			LogFunction("eglCreateStreamFromFileDescriptorKHR(0x{0}, {1}) = {2}", dpy.ToString("X8"), file_descriptor, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
