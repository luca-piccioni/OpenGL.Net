
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
		/// Binding for eglSwapBuffersRegion2NOK.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numRects">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="rects">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NOK_swap_region2")]
		public static bool SwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int[] rects)
		{
			bool retValue;

			unsafe {
				fixed (int* p_rects = rects)
				{
					Debug.Assert(Delegates.peglSwapBuffersRegion2NOK != null, "peglSwapBuffersRegion2NOK not implemented");
					retValue = Delegates.peglSwapBuffersRegion2NOK(dpy, surface, numRects, p_rects);
					LogFunction("eglSwapBuffersRegion2NOK(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), surface.ToString("X8"), numRects, LogValue(rects), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
