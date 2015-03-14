
// Copyright (C) 2015 Luca Piccioni
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PACK_SKIP_IMAGES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PACK_SKIP_IMAGES_EXT = 0x806B;

		/// <summary>
		/// Value of GL_PACK_IMAGE_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PACK_IMAGE_HEIGHT_EXT = 0x806C;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_IMAGES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int UNPACK_SKIP_IMAGES_EXT = 0x806D;

		/// <summary>
		/// Value of GL_UNPACK_IMAGE_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int UNPACK_IMAGE_HEIGHT_EXT = 0x806E;

		/// <summary>
		/// Value of GL_TEXTURE_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int TEXTURE_3D_EXT = 0x806F;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PROXY_TEXTURE_3D_EXT = 0x8070;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int TEXTURE_DEPTH_EXT = 0x8071;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_R_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int TEXTURE_WRAP_R_EXT = 0x8072;

		/// <summary>
		/// Value of GL_MAX_3D_TEXTURE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int MAX_3D_TEXTURE_SIZE_EXT = 0x8073;

		/// <summary>
		/// Binding for glTexImage3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_EXT_texture3D")]
		public static void TexImage3DEXT(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage3DEXT != null, "pglTexImage3DEXT not implemented");
			Delegates.pglTexImage3DEXT((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
			CallLog("glTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexImage3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_EXT_texture3D")]
		public static void TexImage3DEXT(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTexSubImage3DEXT.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
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
		[RequiredByFeature("GL_EXT_texture3D")]
		public static void TexSubImage3DEXT(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage3DEXT != null, "pglTexSubImage3DEXT not implemented");
			Delegates.pglTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
			CallLog("glTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexSubImage3DEXT.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
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
		[RequiredByFeature("GL_EXT_texture3D")]
		public static void TexSubImage3DEXT(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

	}

}
