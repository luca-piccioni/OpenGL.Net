
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
		/// Binding for glImportMemoryFdEXT.
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
		/// <param name="fd">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
		public static void ImportMemoryEXT(UInt32 memory, UInt64 size, ExternalHandleType handleType, Int32 fd)
		{
			Debug.Assert(Delegates.pglImportMemoryFdEXT != null, "pglImportMemoryFdEXT not implemented");
			Delegates.pglImportMemoryFdEXT(memory, size, (Int32)handleType, fd);
			LogCommand("glImportMemoryFdEXT", null, memory, size, handleType, fd			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glImportMemoryFdEXT", ExactSpelling = true)]
			internal extern static void glImportMemoryFdEXT(UInt32 memory, UInt64 size, Int32 handleType, Int32 fd);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glImportMemoryFdEXT(UInt32 memory, UInt64 size, Int32 handleType, Int32 fd);

			[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportMemoryFdEXT pglImportMemoryFdEXT;

		}
	}

}
