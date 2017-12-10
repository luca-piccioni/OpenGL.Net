
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_3DFX_WINDOW_MODE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
		public const int _3DFX_WINDOW_MODE_MESA = 0x1;

		/// <summary>
		/// [GLX] Value of GLX_3DFX_FULLSCREEN_MODE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
		public const int _3DFX_FULLSCREEN_MODE_MESA = 0x2;

		/// <summary>
		/// [GLX] glXSet3DfxModeMESA: Binding for glXSet3DfxModeMESA.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
		public static bool Set3DfxModeMESA(int mode)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXSet3DfxModeMESA != null, "pglXSet3DfxModeMESA not implemented");
			retValue = Delegates.pglXSet3DfxModeMESA(mode);
			LogCommand("glXSet3DfxModeMESA", retValue, mode			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool glXSet3DfxModeMESA(int mode);

			[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
			internal static glXSet3DfxModeMESA pglXSet3DfxModeMESA;

		}
	}

}
