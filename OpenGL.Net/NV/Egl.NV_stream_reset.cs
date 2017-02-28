
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_SUPPORT_RESET_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public const int SUPPORT_RESET_NV = 0x3334;

		/// <summary>
		/// Value of EGL_SUPPORT_REUSE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public const int SUPPORT_REUSE_NV = 0x3335;

		/// <summary>
		/// Binding for eglResetStreamNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public static bool ResetStreamNV(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglResetStreamNV != null, "peglResetStreamNV not implemented");
			retValue = Delegates.peglResetStreamNV(dpy, stream);
			LogFunction("eglResetStreamNV(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglResetStreamNV", ExactSpelling = true)]
			internal extern static unsafe bool eglResetStreamNV(IntPtr dpy, IntPtr stream);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_reset")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglResetStreamNV(IntPtr dpy, IntPtr stream);

			internal static eglResetStreamNV peglResetStreamNV;

		}
	}

}
