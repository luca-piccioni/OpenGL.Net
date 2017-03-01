
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
		/// Binding for glXCopyBufferSubDataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="writeTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_copy_buffer")]
		public static void CopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglXCopyBufferSubDataNV != null, "pglXCopyBufferSubDataNV not implemented");
			Delegates.pglXCopyBufferSubDataNV(dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
			LogFunction("glXCopyBufferSubDataNV(0x{0}, 0x{1}, 0x{2}, {3}, {4}, 0x{5}, 0x{6}, {7})", dpy.ToString("X8"), readCtx.ToString("X8"), writeCtx.ToString("X8"), LogEnumName(readTarget), LogEnumName(writeTarget), readOffset.ToString("X8"), writeOffset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glXNamedCopyBufferSubDataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="writeBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_copy_buffer")]
		public static void NamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglXNamedCopyBufferSubDataNV != null, "pglXNamedCopyBufferSubDataNV not implemented");
			Delegates.pglXNamedCopyBufferSubDataNV(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
			LogFunction("glXNamedCopyBufferSubDataNV(0x{0}, 0x{1}, 0x{2}, {3}, {4}, 0x{5}, 0x{6}, {7})", dpy.ToString("X8"), readCtx.ToString("X8"), writeCtx.ToString("X8"), readBuffer, writeBuffer, readOffset.ToString("X8"), writeOffset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXNamedCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXNamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_copy_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			internal static glXCopyBufferSubDataNV pglXCopyBufferSubDataNV;

			[RequiredByFeature("GLX_NV_copy_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXNamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			internal static glXNamedCopyBufferSubDataNV pglXNamedCopyBufferSubDataNV;

		}
	}

}
