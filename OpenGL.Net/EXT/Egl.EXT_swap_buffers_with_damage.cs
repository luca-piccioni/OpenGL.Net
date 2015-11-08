
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Binding for eglSwapBuffersWithDamageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="rects">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="n_rects">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
		public static IntPtr SwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int[] rects, int n_rects)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_rects = rects)
				{
					Debug.Assert(Delegates.peglSwapBuffersWithDamageEXT != null, "peglSwapBuffersWithDamageEXT not implemented");
					retValue = Delegates.peglSwapBuffersWithDamageEXT(dpy, surface, p_rects, n_rects);
					CallLog("eglSwapBuffersWithDamageEXT(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), surface.ToString("X8"), rects, n_rects, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
