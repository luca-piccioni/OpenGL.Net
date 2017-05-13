
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
		/// [GL] Value of GL_PACK_SKIP_VOLUMES_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PACK_SKIP_VOLUMES_SGIS = 0x8130;

		/// <summary>
		/// [GL] Value of GL_PACK_IMAGE_DEPTH_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PACK_IMAGE_DEPTH_SGIS = 0x8131;

		/// <summary>
		/// [GL] Value of GL_UNPACK_SKIP_VOLUMES_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int UNPACK_SKIP_VOLUMES_SGIS = 0x8132;

		/// <summary>
		/// [GL] Value of GL_UNPACK_IMAGE_DEPTH_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int UNPACK_IMAGE_DEPTH_SGIS = 0x8133;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4D_SGIS = 0x8134;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_4D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int PROXY_TEXTURE_4D_SGIS = 0x8135;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4DSIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4DSIZE_SGIS = 0x8136;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_WRAP_Q_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_WRAP_Q_SGIS = 0x8137;

		/// <summary>
		/// [GL] Value of GL_MAX_4D_TEXTURE_SIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_4D_BINDING_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public const int TEXTURE_4D_BINDING_SGIS = 0x814F;

		/// <summary>
		/// Binding for glTexImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexImage4DSGIS(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage4DSGIS != null, "pglTexImage4DSGIS not implemented");
			Delegates.pglTexImage4DSGIS((Int32)target, level, (Int32)internalformat, width, height, depth, size4d, border, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexImage4DSGIS", null, target, level, internalformat, width, height, depth, size4d, border, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexImage4DSGIS(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTexSubImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="woffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexSubImage4DSGIS(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage4DSGIS != null, "pglTexSubImage4DSGIS not implemented");
			Delegates.pglTexSubImage4DSGIS((Int32)target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexSubImage4DSGIS", null, target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexSubImage4DSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="woffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size4d">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture4D")]
		public static void TexSubImage4DSGIS(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage4DSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexImage4DSGIS(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexSubImage4DSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexSubImage4DSGIS(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 format, Int32 type, IntPtr pixels);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_texture4D")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage4DSGIS(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[RequiredByFeature("GL_SGIS_texture4D")]
			[ThreadStatic]
			internal static glTexImage4DSGIS pglTexImage4DSGIS;

			[RequiredByFeature("GL_SGIS_texture4D")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage4DSGIS(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 format, Int32 type, IntPtr pixels);

			[RequiredByFeature("GL_SGIS_texture4D")]
			[ThreadStatic]
			internal static glTexSubImage4DSGIS pglTexSubImage4DSGIS;

		}
	}

}
