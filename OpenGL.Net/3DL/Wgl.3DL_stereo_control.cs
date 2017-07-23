
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
		/// [WGL] Value of WGL_STEREO_EMITTER_ENABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_ENABLE_3DL = 0x2055;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_EMITTER_DISABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_DISABLE_3DL = 0x2056;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_POLARITY_NORMAL_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_NORMAL_3DL = 0x2057;

		/// <summary>
		/// [WGL] Value of WGL_STEREO_POLARITY_INVERT_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_INVERT_3DL = 0x2058;

		/// <summary>
		/// [WGL] Binding for wglSetStereoEmitterState3DL.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uState">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public static bool SetStereoEmitter3DL(IntPtr hDC, UInt32 uState)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSetStereoEmitterState3DL != null, "pwglSetStereoEmitterState3DL not implemented");
			retValue = Delegates.pwglSetStereoEmitterState3DL(hDC, uState);
			LogCommand("wglSetStereoEmitterState3DL", retValue, hDC, uState			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglSetStereoEmitterState3DL", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetStereoEmitterState3DL(IntPtr hDC, UInt32 uState);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_3DL_stereo_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglSetStereoEmitterState3DL(IntPtr hDC, UInt32 uState);

			[RequiredByFeature("WGL_3DL_stereo_control")]
			[ThreadStatic]
			internal static wglSetStereoEmitterState3DL pwglSetStereoEmitterState3DL;

		}
	}

}
