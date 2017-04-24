
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
		/// Binding for glXCopySubBufferMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_copy_sub_buffer")]
		public static void CopySubBufferMESA(IntPtr dpy, IntPtr drawable, int x, int y, int width, int height)
		{
			Debug.Assert(Delegates.pglXCopySubBufferMESA != null, "pglXCopySubBufferMESA not implemented");
			Delegates.pglXCopySubBufferMESA(dpy, drawable, x, y, width, height);
			LogCommand("glXCopySubBufferMESA", null, dpy, drawable, x, y, width, height			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopySubBufferMESA", ExactSpelling = true)]
			internal extern static unsafe void glXCopySubBufferMESA(IntPtr dpy, IntPtr drawable, int x, int y, int width, int height);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_MESA_copy_sub_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopySubBufferMESA(IntPtr dpy, IntPtr drawable, int x, int y, int width, int height);

			internal static glXCopySubBufferMESA pglXCopySubBufferMESA;

		}
	}

}
