
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_SAMPLE_BUFFERS symbol.
		/// </summary>
		[AliasOf("GLX_SAMPLE_BUFFERS_ARB")]
		[AliasOf("GLX_SAMPLE_BUFFERS_SGIS")]
		[RequiredByFeature("GLX_VERSION_1_4")]
		[RequiredByFeature("GLX_ARB_multisample")]
		[RequiredByFeature("GLX_SGIS_multisample")]
		public const int SAMPLE_BUFFERS = 100000;

		/// <summary>
		/// [GLX] Value of GLX_SAMPLES symbol.
		/// </summary>
		[AliasOf("GLX_SAMPLES_ARB")]
		[AliasOf("GLX_SAMPLES_SGIS")]
		[RequiredByFeature("GLX_VERSION_1_4")]
		[RequiredByFeature("GLX_ARB_multisample")]
		[RequiredByFeature("GLX_SGIS_multisample")]
		public const int SAMPLES = 100001;

		/// <summary>
		/// [GL2.1] obtain a pointer to an OpenGL or GLX function
		/// </summary>
		/// <param name="procName">
		/// Specifies the name of the OpenGL or GLX function whose address is to be returned.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_4")]
		public static IntPtr GetProcAddress(byte[] procName)
		{
			IntPtr retValue;

			unsafe {
				fixed (byte* p_procName = procName)
				{
					Debug.Assert(Delegates.pglXGetProcAddress != null, "pglXGetProcAddress not implemented");
					retValue = Delegates.pglXGetProcAddress(p_procName);
					LogCommand("glXGetProcAddress", retValue, procName					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetProcAddress", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetProcAddress(byte* procName);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_VERSION_1_4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXGetProcAddress(byte* procName);

			[RequiredByFeature("GLX_VERSION_1_4")]
			internal static glXGetProcAddress pglXGetProcAddress;

		}
	}

}
