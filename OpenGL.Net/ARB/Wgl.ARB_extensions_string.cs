
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
	public partial class Wgl
	{
		/// <summary>
		/// Binding for wglGetExtensionsStringARB.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_extensions_string")]
		public static string GetExtensionsStringARB(IntPtr hdc)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetExtensionsStringARB != null, "pwglGetExtensionsStringARB not implemented");
			retValue = Delegates.pwglGetExtensionsStringARB(hdc);
			LogFunction("wglGetExtensionsStringARB(0x{0}) = {1}", hdc.ToString("X8"), Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetExtensionsStringARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetExtensionsStringARB(IntPtr hdc);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglGetExtensionsStringARB(IntPtr hdc);

			[ThreadStatic]
			internal static wglGetExtensionsStringARB pwglGetExtensionsStringARB;

		}
	}

}
