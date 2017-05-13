
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
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXDelayBeforeSwapNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="seconds">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_delay_before_swap")]
		public static bool DelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXDelayBeforeSwapNV != null, "pglXDelayBeforeSwapNV not implemented");
			retValue = Delegates.pglXDelayBeforeSwapNV(dpy, drawable, seconds);
			LogCommand("glXDelayBeforeSwapNV", retValue, dpy, drawable, seconds			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDelayBeforeSwapNV", ExactSpelling = true)]
			internal extern static unsafe bool glXDelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_delay_before_swap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXDelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds);

			[RequiredByFeature("GLX_NV_delay_before_swap")]
			internal static glXDelayBeforeSwapNV pglXDelayBeforeSwapNV;

		}
	}

}
