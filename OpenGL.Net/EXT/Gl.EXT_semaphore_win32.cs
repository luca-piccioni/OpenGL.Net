
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_OPAQUE_WIN32_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;

		/// <summary>
		/// [GL] Value of GL_DEVICE_LUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int DEVICE_LUID_EXT = 0x9599;

		/// <summary>
		/// [GL] Value of GL_DEVICE_NODE_MASK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int DEVICE_NODE_MASK_EXT = 0x959A;

		/// <summary>
		/// [GL] Value of GL_LUID_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int LUID_SIZE_EXT = 8;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_D3D12_FENCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594;

		/// <summary>
		/// [GL] Value of GL_D3D12_FENCE_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int D3D12_FENCE_VALUE_EXT = 0x9595;

		/// <summary>
		/// Binding for glImportSemaphoreWin32HandleEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="handle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32HandleEXT(UInt32 semaphore, ExternalHandleType handleType, IntPtr handle)
		{
			Debug.Assert(Delegates.pglImportSemaphoreWin32HandleEXT != null, "pglImportSemaphoreWin32HandleEXT not implemented");
			Delegates.pglImportSemaphoreWin32HandleEXT(semaphore, (Int32)handleType, handle);
			LogCommand("glImportSemaphoreWin32HandleEXT", null, semaphore, handleType, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImportSemaphoreWin32NameEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32NameEXT(UInt32 semaphore, ExternalHandleType handleType, IntPtr name)
		{
			Debug.Assert(Delegates.pglImportSemaphoreWin32NameEXT != null, "pglImportSemaphoreWin32NameEXT not implemented");
			Delegates.pglImportSemaphoreWin32NameEXT(semaphore, (Int32)handleType, name);
			LogCommand("glImportSemaphoreWin32NameEXT", null, semaphore, handleType, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImportSemaphoreWin32NameEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32NameEXT(UInt32 semaphore, ExternalHandleType handleType, Object name)
		{
			GCHandle pin_name = GCHandle.Alloc(name, GCHandleType.Pinned);
			try {
				ImportSemaphoreWin32NameEXT(semaphore, handleType, pin_name.AddrOfPinnedObject());
			} finally {
				pin_name.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glImportSemaphoreWin32HandleEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportSemaphoreWin32HandleEXT(UInt32 semaphore, Int32 handleType, IntPtr handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glImportSemaphoreWin32NameEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportSemaphoreWin32NameEXT(UInt32 semaphore, Int32 handleType, IntPtr name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImportSemaphoreWin32HandleEXT(UInt32 semaphore, Int32 handleType, IntPtr handle);

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportSemaphoreWin32HandleEXT pglImportSemaphoreWin32HandleEXT;

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImportSemaphoreWin32NameEXT(UInt32 semaphore, Int32 handleType, IntPtr name);

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportSemaphoreWin32NameEXT pglImportSemaphoreWin32NameEXT;

		}
	}

}
