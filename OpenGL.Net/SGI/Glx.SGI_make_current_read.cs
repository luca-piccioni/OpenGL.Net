
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
		/// Binding for glXMakeCurrentReadSGI.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="draw">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="read">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGI_make_current_read")]
		public static bool MakeCurrentReadSGI(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXMakeCurrentReadSGI != null, "pglXMakeCurrentReadSGI not implemented");
			retValue = Delegates.pglXMakeCurrentReadSGI(dpy, draw, read, ctx);
			LogFunction("glXMakeCurrentReadSGI(0x{0}, 0x{1}, 0x{2}, 0x{3}) = {4}", dpy.ToString("X8"), draw.ToString("X8"), read.ToString("X8"), ctx.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetCurrentReadDrawableSGI.
		/// </summary>
		[RequiredByFeature("GLX_SGI_make_current_read")]
		public static IntPtr GetCurrentReadDrawableSGI()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentReadDrawableSGI != null, "pglXGetCurrentReadDrawableSGI not implemented");
			retValue = Delegates.pglXGetCurrentReadDrawableSGI();
			LogFunction("glXGetCurrentReadDrawableSGI() = {0}", retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeCurrentReadSGI", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeCurrentReadSGI(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentReadDrawableSGI", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentReadDrawableSGI();

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeCurrentReadSGI(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			internal static glXMakeCurrentReadSGI pglXMakeCurrentReadSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentReadDrawableSGI();

			internal static glXGetCurrentReadDrawableSGI pglXGetCurrentReadDrawableSGI;

		}
	}

}
