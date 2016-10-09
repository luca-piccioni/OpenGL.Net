
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXBindSwapBarrierSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_swap_barrier")]
		public static void BindSwapBarrierSGIX(IntPtr dpy, IntPtr drawable, int barrier)
		{
			Debug.Assert(Delegates.pglXBindSwapBarrierSGIX != null, "pglXBindSwapBarrierSGIX not implemented");
			Delegates.pglXBindSwapBarrierSGIX(dpy, drawable, barrier);
			LogFunction("glXBindSwapBarrierSGIX(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), drawable.ToString("X8"), barrier);
		}

		/// <summary>
		/// Binding for glXQueryMaxSwapBarriersSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="max">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_swap_barrier")]
		public static bool QueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, int[] max)
		{
			bool retValue;

			unsafe {
				fixed (int* p_max = max)
				{
					Debug.Assert(Delegates.pglXQueryMaxSwapBarriersSGIX != null, "pglXQueryMaxSwapBarriersSGIX not implemented");
					retValue = Delegates.pglXQueryMaxSwapBarriersSGIX(dpy, screen, p_max);
					LogFunction("glXQueryMaxSwapBarriersSGIX(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), screen, LogValue(max), retValue);
				}
			}

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindSwapBarrierSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXBindSwapBarrierSGIX(IntPtr dpy, IntPtr drawable, int barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryMaxSwapBarriersSGIX", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, int* max);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXBindSwapBarrierSGIX(IntPtr dpy, IntPtr drawable, int barrier);

			internal static glXBindSwapBarrierSGIX pglXBindSwapBarrierSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, int* max);

			internal static glXQueryMaxSwapBarriersSGIX pglXQueryMaxSwapBarriersSGIX;

		}
	}

}
