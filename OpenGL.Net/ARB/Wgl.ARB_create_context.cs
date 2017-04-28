
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
		/// [WGL] Value of WGL_CONTEXT_DEBUG_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		[Log(BitmaskName = "WGLContextFlagsMask")]
		public const uint CONTEXT_DEBUG_BIT_ARB = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		[Log(BitmaskName = "WGLContextFlagsMask")]
		public const uint CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x00000002;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_MAJOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_MAJOR_VERSION_ARB = 0x2091;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_MINOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_MINOR_VERSION_ARB = 0x2092;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_LAYER_PLANE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_LAYER_PLANE_ARB = 0x2093;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_FLAGS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_FLAGS_ARB = 0x2094;

		/// <summary>
		/// [WGL] Value of ERROR_INVALID_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int ERROR_INVALID_VERSION_ARB = 0x2095;

		/// <summary>
		/// Binding for wglCreateContextAttribsARB.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hShareContext">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_create_context")]
		public static IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int[] attribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwglCreateContextAttribsARB != null, "pwglCreateContextAttribsARB not implemented");
					retValue = Delegates.pwglCreateContextAttribsARB(hDC, hShareContext, p_attribList);
					LogCommand("wglCreateContextAttribsARB", retValue, hDC, hShareContext, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateContextAttribsARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_create_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);

			[ThreadStatic]
			internal static wglCreateContextAttribsARB pwglCreateContextAttribsARB;

		}
	}

}
