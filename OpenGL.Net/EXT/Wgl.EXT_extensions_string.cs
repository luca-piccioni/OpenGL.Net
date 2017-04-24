
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
		/// Binding for wglGetExtensionsStringEXT.
		/// </summary>
		[RequiredByFeature("WGL_EXT_extensions_string")]
		public static string GetExtensionsStringEXT()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetExtensionsStringEXT != null, "pwglGetExtensionsStringEXT not implemented");
			retValue = Delegates.pwglGetExtensionsStringEXT();
			LogCommand("wglGetExtensionsStringEXT", Marshal.PtrToStringAnsi(retValue)			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetExtensionsStringEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetExtensionsStringEXT();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_extensions_string")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetExtensionsStringEXT();

			[ThreadStatic]
			internal static wglGetExtensionsStringEXT pwglGetExtensionsStringEXT;

		}
	}

}
