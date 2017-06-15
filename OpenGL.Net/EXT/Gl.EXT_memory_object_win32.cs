
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
		/// [GL] Value of GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_D3D12_RESOURCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_D3D11_IMAGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C;

		/// <summary>
		/// Binding for glImportMemoryWin32HandleEXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="handle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public static void ImportMemoryWin32HandleEXT(UInt32 memory, UInt64 size, ExternalHandleType handleType, IntPtr handle)
		{
			Debug.Assert(Delegates.pglImportMemoryWin32HandleEXT != null, "pglImportMemoryWin32HandleEXT not implemented");
			Delegates.pglImportMemoryWin32HandleEXT(memory, size, (Int32)handleType, handle);
			LogCommand("glImportMemoryWin32HandleEXT", null, memory, size, handleType, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImportMemoryWin32NameEXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public static void ImportMemoryWin32NameEXT(UInt32 memory, UInt64 size, ExternalHandleType handleType, IntPtr name)
		{
			Debug.Assert(Delegates.pglImportMemoryWin32NameEXT != null, "pglImportMemoryWin32NameEXT not implemented");
			Delegates.pglImportMemoryWin32NameEXT(memory, size, (Int32)handleType, name);
			LogCommand("glImportMemoryWin32NameEXT", null, memory, size, handleType, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImportMemoryWin32NameEXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		public static void ImportMemoryWin32NameEXT(UInt32 memory, UInt64 size, ExternalHandleType handleType, Object name)
		{
			GCHandle pin_name = GCHandle.Alloc(name, GCHandleType.Pinned);
			try {
				ImportMemoryWin32NameEXT(memory, size, handleType, pin_name.AddrOfPinnedObject());
			} finally {
				pin_name.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glImportMemoryWin32HandleEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportMemoryWin32HandleEXT(UInt32 memory, UInt64 size, Int32 handleType, IntPtr handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glImportMemoryWin32NameEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportMemoryWin32NameEXT(UInt32 memory, UInt64 size, Int32 handleType, IntPtr name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImportMemoryWin32HandleEXT(UInt32 memory, UInt64 size, Int32 handleType, IntPtr handle);

			[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportMemoryWin32HandleEXT pglImportMemoryWin32HandleEXT;

			[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImportMemoryWin32NameEXT(UInt32 memory, UInt64 size, Int32 handleType, IntPtr name);

			[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportMemoryWin32NameEXT pglImportMemoryWin32NameEXT;

		}
	}

}
