
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_NATIVE_BUFFER_USAGE_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
		public const int NATIVE_BUFFER_USAGE_ANDROID = 0x3143;

		/// <summary>
		/// [EGL] Value of EGL_NATIVE_BUFFER_USAGE_PROTECTED_BIT_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
		[Log(BitmaskName = "EGLNativeBufferUsageFlags")]
		public const uint NATIVE_BUFFER_USAGE_PROTECTED_BIT_ANDROID = 0x00000001;

		/// <summary>
		/// [EGL] Value of EGL_NATIVE_BUFFER_USAGE_RENDERBUFFER_BIT_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
		[Log(BitmaskName = "EGLNativeBufferUsageFlags")]
		public const uint NATIVE_BUFFER_USAGE_RENDERBUFFER_BIT_ANDROID = 0x00000002;

		/// <summary>
		/// [EGL] Value of EGL_NATIVE_BUFFER_USAGE_TEXTURE_BIT_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
		[Log(BitmaskName = "EGLNativeBufferUsageFlags")]
		public const uint NATIVE_BUFFER_USAGE_TEXTURE_BIT_ANDROID = 0x00000004;

		/// <summary>
		/// [EGL] Binding for eglCreateNativeClientBufferANDROID.
		/// </summary>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
		public static IntPtr CreateNativeClientBufferANDROID(int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateNativeClientBufferANDROID != null, "peglCreateNativeClientBufferANDROID not implemented");
					retValue = Delegates.peglCreateNativeClientBufferANDROID(p_attrib_list);
					LogCommand("eglCreateNativeClientBufferANDROID", retValue, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateNativeClientBufferANDROID", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateNativeClientBufferANDROID(int* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateNativeClientBufferANDROID(int* attrib_list);

			[RequiredByFeature("EGL_ANDROID_create_native_client_buffer")]
			internal static eglCreateNativeClientBufferANDROID peglCreateNativeClientBufferANDROID;

		}
	}

}
