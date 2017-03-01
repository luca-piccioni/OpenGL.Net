
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
	public partial class Wgl
	{
		/// <summary>
		/// Binding for wglMakeContextCurrentEXT.
		/// </summary>
		/// <param name="hDrawDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hReadDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_make_current_read")]
		public static bool MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeContextCurrentEXT != null, "pwglMakeContextCurrentEXT not implemented");
			retValue = Delegates.pwglMakeContextCurrentEXT(hDrawDC, hReadDC, hglrc);
			LogFunction("wglMakeContextCurrentEXT(0x{0}, 0x{1}, 0x{2}) = {3}", hDrawDC.ToString("X8"), hReadDC.ToString("X8"), hglrc.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetCurrentReadDCEXT.
		/// </summary>
		[RequiredByFeature("WGL_EXT_make_current_read")]
		public static IntPtr GetCurrentReadDCEXT()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentReadDCEXT != null, "pwglGetCurrentReadDCEXT not implemented");
			retValue = Delegates.pwglGetCurrentReadDCEXT();
			LogFunction("wglGetCurrentReadDCEXT() = {0}", retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeContextCurrentEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentReadDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentReadDCEXT();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_make_current_read")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			[ThreadStatic]
			internal static wglMakeContextCurrentEXT pwglMakeContextCurrentEXT;

			[RequiredByFeature("WGL_EXT_make_current_read")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentReadDCEXT();

			[ThreadStatic]
			internal static wglGetCurrentReadDCEXT pwglGetCurrentReadDCEXT;

		}
	}

}
