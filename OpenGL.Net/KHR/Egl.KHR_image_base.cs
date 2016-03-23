
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
					LogFunction("eglCreateImageKHR(0x{0}, 0x{1}, {2}, 0x{3}, {4}) = {5}", dpy.ToString("X8"), ctx.ToString("X8"), target, buffer.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
