
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of GLX_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public const int SWAP_INTERVAL_EXT = 0x20F1;

		/// <summary>
		/// Value of GLX_MAX_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public const int MAX_SWAP_INTERVAL_EXT = 0x20F2;

		/// <summary>
		/// Binding for glXSwapIntervalEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="interval">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public static void SwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval)
		{
			Debug.Assert(Delegates.pglXSwapIntervalEXT != null, "pglXSwapIntervalEXT not implemented");
			Delegates.pglXSwapIntervalEXT(dpy, drawable, interval);
			LogFunction("glXSwapIntervalEXT(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), drawable.ToString("X8"), interval);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapIntervalEXT", ExactSpelling = true)]
			internal extern static unsafe void glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_EXT_swap_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);

			internal static glXSwapIntervalEXT pglXSwapIntervalEXT;

		}
	}

}
