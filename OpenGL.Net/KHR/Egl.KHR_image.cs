
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
		/// Value of EGL_NATIVE_PIXMAP_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_pixmap")]
		public const int NATIVE_PIXMAP_KHR = 0x30B0;

		/// <summary>
		/// Value of EGL_NO_IMAGE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public const int NO_IMAGE_KHR = 0;

		/// <summary>
		/// Binding for eglCreateImageKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public static IntPtr CreateImageKHR(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateImageKHR != null, "peglCreateImageKHR not implemented");
					retValue = Delegates.peglCreateImageKHR(dpy, ctx, target, buffer, p_attrib_list);
					CallLog("eglCreateImageKHR({0}, {1}, {2}, {3}, {4}) = {5}", dpy, ctx, target, buffer, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroyImageKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public static IntPtr DestroyImageKHR(IntPtr dpy, IntPtr image)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglDestroyImageKHR != null, "peglDestroyImageKHR not implemented");
			retValue = Delegates.peglDestroyImageKHR(dpy, image);
			CallLog("eglDestroyImageKHR({0}, {1}) = {2}", dpy, image, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
