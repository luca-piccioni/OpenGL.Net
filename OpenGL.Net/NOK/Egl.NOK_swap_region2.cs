
// Copyright (C) 2015-2017 Luca Piccioni
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
		/// [EGL] Binding for eglSwapBuffersRegion2NOK.
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
					LogCommand("eglSwapBuffersRegion2NOK", retValue, dpy, surface, numRects, rects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglSwapBuffersRegion2NOK", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NOK_swap_region2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[RequiredByFeature("EGL_NOK_swap_region2")]
			internal static eglSwapBuffersRegion2NOK peglSwapBuffersRegion2NOK;

		}
	}

}
