
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
		/// [GL] Value of GL_TEXTURE_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_POINTER_APPLE = 0x85B8;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_STORAGE_HINT_APPLE = 0x85BC;

		/// <summary>
		/// [GL] Value of GL_STORAGE_PRIVATE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int STORAGE_PRIVATE_APPLE = 0x85BD;

		/// <summary>
		/// [GL] Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void TextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTextureRangeAPPLE != null, "pglTextureRangeAPPLE not implemented");
			Delegates.pglTextureRangeAPPLE(target, length, pointer);
			LogCommand("glTextureRangeAPPLE", null, target, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void TextureRangeAPPLE(Int32 target, Int32 length, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TextureRangeAPPLE(target, length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glGetTexParameterPointervAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void GetTexParameterPointerAPPLE(Int32 target, Int32 pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTexParameterPointervAPPLE != null, "pglGetTexParameterPointervAPPLE not implemented");
					Delegates.pglGetTexParameterPointervAPPLE(target, pname, p_params);
					LogCommand("glGetTexParameterPointervAPPLE", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTexParameterPointervAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void GetTexParameterPointerAPPLE(Int32 target, Int32 pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetTexParameterPointerAPPLE(target, pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTextureRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glTextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexParameterPointervAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterPointervAPPLE(Int32 target, Int32 pname, IntPtr* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_texture_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_texture_range")]
			[ThreadStatic]
			internal static glTextureRangeAPPLE pglTextureRangeAPPLE;

			[RequiredByFeature("GL_APPLE_texture_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexParameterPointervAPPLE(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_APPLE_texture_range")]
			[ThreadStatic]
			internal static glGetTexParameterPointervAPPLE pglGetTexParameterPointervAPPLE;

		}
	}

}
