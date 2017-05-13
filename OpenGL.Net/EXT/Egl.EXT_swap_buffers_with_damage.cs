
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
		public static bool SwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int[] rects, int n_rects)
		{
			bool retValue;

			unsafe {
				fixed (int* p_rects = rects)
				{
					Debug.Assert(Delegates.peglSwapBuffersWithDamageEXT != null, "peglSwapBuffersWithDamageEXT not implemented");
					retValue = Delegates.peglSwapBuffersWithDamageEXT(dpy, surface, p_rects, n_rects);
					LogCommand("eglSwapBuffersWithDamageEXT", retValue, dpy, surface, rects, n_rects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglSwapBuffersWithDamageEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[RequiredByFeature("EGL_EXT_swap_buffers_with_damage")]
			internal static eglSwapBuffersWithDamageEXT peglSwapBuffersWithDamageEXT;

		}
	}

}
