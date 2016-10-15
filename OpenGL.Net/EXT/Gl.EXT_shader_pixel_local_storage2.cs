
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;

		/// <summary>
		/// Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;

		/// <summary>
		/// Binding for glFramebufferPixelLocalStorageSizeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static void FramebufferPixelLocalStorageSizeEXT(UInt32 target, Int32 size)
		{
			Debug.Assert(Delegates.pglFramebufferPixelLocalStorageSizeEXT != null, "pglFramebufferPixelLocalStorageSizeEXT not implemented");
			Delegates.pglFramebufferPixelLocalStorageSizeEXT(target, size);
			LogFunction("glFramebufferPixelLocalStorageSizeEXT({0}, {1})", target, size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFramebufferPixelLocalStorageSizeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static Int32 GetFramebufferPixelLocalStorageSizeEXT(UInt32 target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFramebufferPixelLocalStorageSizeEXT != null, "pglGetFramebufferPixelLocalStorageSizeEXT not implemented");
			retValue = Delegates.pglGetFramebufferPixelLocalStorageSizeEXT(target);
			LogFunction("glGetFramebufferPixelLocalStorageSizeEXT({0}) = {1}", target, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glClearPixelLocalStorageuiEXT.
		/// </summary>
		/// <param name="offset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static void ClearPixelLocalStorageEXT(Int32 offset, Int32 n, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglClearPixelLocalStorageuiEXT != null, "pglClearPixelLocalStorageuiEXT not implemented");
					Delegates.pglClearPixelLocalStorageuiEXT(offset, n, p_values);
					LogFunction("glClearPixelLocalStorageuiEXT({0}, {1}, {2})", offset, n, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferPixelLocalStorageSizeEXT", ExactSpelling = true)]
			internal extern static void glFramebufferPixelLocalStorageSizeEXT(UInt32 target, Int32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT", ExactSpelling = true)]
			internal extern static Int32 glGetFramebufferPixelLocalStorageSizeEXT(UInt32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearPixelLocalStorageuiEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearPixelLocalStorageuiEXT(Int32 offset, Int32 n, UInt32* values);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferPixelLocalStorageSizeEXT(UInt32 target, Int32 size);

			[ThreadStatic]
			internal static glFramebufferPixelLocalStorageSizeEXT pglFramebufferPixelLocalStorageSizeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetFramebufferPixelLocalStorageSizeEXT(UInt32 target);

			[ThreadStatic]
			internal static glGetFramebufferPixelLocalStorageSizeEXT pglGetFramebufferPixelLocalStorageSizeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearPixelLocalStorageuiEXT(Int32 offset, Int32 n, UInt32* values);

			[ThreadStatic]
			internal static glClearPixelLocalStorageuiEXT pglClearPixelLocalStorageuiEXT;

		}
	}

}
