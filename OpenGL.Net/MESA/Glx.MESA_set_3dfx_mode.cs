
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_3DFX_WINDOW_MODE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
		public const int _3DFX_WINDOW_MODE_MESA = 0x1;

		/// <summary>
		/// Value of GLX_3DFX_FULLSCREEN_MODE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_set_3dfx_mode")]
		public const int _3DFX_FULLSCREEN_MODE_MESA = 0x2;

		/// <summary>
		/// Binding for glXSet3DfxModeMESA.
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
			LogFunction("glXSet3DfxModeMESA({0}) = {1}", mode, retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSet3DfxModeMESA", ExactSpelling = true)]
			internal extern static bool glXSet3DfxModeMESA(int mode);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glXSet3DfxModeMESA(int mode);

			internal static glXSet3DfxModeMESA pglXSet3DfxModeMESA;

		}
	}

}
