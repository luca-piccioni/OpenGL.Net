
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
		/// Binding for wglSwapIntervalEXT.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_swap_control")]
		public static bool SwapIntervalEXT(int interval)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSwapIntervalEXT != null, "pwglSwapIntervalEXT not implemented");
			retValue = Delegates.pwglSwapIntervalEXT(interval);
			LogFunction("wglSwapIntervalEXT({0}) = {1}", interval, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetSwapIntervalEXT.
		/// </summary>
		[RequiredByFeature("WGL_EXT_swap_control")]
		public static int GetSwapIntervalEXT()
		{
			int retValue;

			Debug.Assert(Delegates.pwglGetSwapIntervalEXT != null, "pwglGetSwapIntervalEXT not implemented");
			retValue = Delegates.pwglGetSwapIntervalEXT();
			LogFunction("wglGetSwapIntervalEXT() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapIntervalEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglSwapIntervalEXT(int interval);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetSwapIntervalEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static int wglGetSwapIntervalEXT();

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglSwapIntervalEXT(int interval);

			[ThreadStatic]
			internal static wglSwapIntervalEXT pwglSwapIntervalEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wglGetSwapIntervalEXT();

			[ThreadStatic]
			internal static wglGetSwapIntervalEXT pwglGetSwapIntervalEXT;

		}
	}

}
