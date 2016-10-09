
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
		/// Binding for glXGetTransparentIndexSUN.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="overlay">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="underlay">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pTransparentIndex">
		/// A <see cref="T:long []"/>.
		/// </param>
		[RequiredByFeature("GLX_SUN_get_transparent_index")]
		public static Int32 GetTransparentIndexSUN(IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] long [] pTransparentIndex)
		{
			Int32 retValue;

			unsafe {
				fixed (long * p_pTransparentIndex = pTransparentIndex)
				{
					Debug.Assert(Delegates.pglXGetTransparentIndexSUN != null, "pglXGetTransparentIndexSUN not implemented");
					retValue = Delegates.pglXGetTransparentIndexSUN(dpy, overlay, underlay, p_pTransparentIndex);
					LogFunction("glXGetTransparentIndexSUN(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), overlay.ToString("X8"), underlay.ToString("X8"), LogValue(pTransparentIndex), retValue);
				}
			}

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetTransparentIndexSUN", ExactSpelling = true)]
			internal extern static unsafe Int32 glXGetTransparentIndexSUN(IntPtr dpy, IntPtr overlay, IntPtr underlay, long * pTransparentIndex);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glXGetTransparentIndexSUN(IntPtr dpy, IntPtr overlay, IntPtr underlay, long * pTransparentIndex);

			internal static glXGetTransparentIndexSUN pglXGetTransparentIndexSUN;

		}
	}

}
