
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
		/// [EGL] Value of EGL_POST_SUB_BUFFER_SUPPORTED_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_post_sub_buffer")]
		public const int POST_SUB_BUFFER_SUPPORTED_NV = 0x30BE;

		/// <summary>
		/// [EGL] Binding for eglPostSubBufferNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
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
		[RequiredByFeature("EGL_NV_post_sub_buffer")]
		public static bool PostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height)
		{
			bool retValue;

			Debug.Assert(Delegates.peglPostSubBufferNV != null, "peglPostSubBufferNV not implemented");
			retValue = Delegates.peglPostSubBufferNV(dpy, surface, x, y, width, height);
			LogCommand("eglPostSubBufferNV", retValue, dpy, surface, x, y, width, height			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglPostSubBufferNV", ExactSpelling = true)]
			internal extern static unsafe bool eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_post_sub_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

			[RequiredByFeature("EGL_NV_post_sub_buffer")]
			internal static eglPostSubBufferNV peglPostSubBufferNV;

		}
	}

}
