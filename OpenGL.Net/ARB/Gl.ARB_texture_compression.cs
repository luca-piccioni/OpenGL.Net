
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
		/// Value of GL_COMPRESSED_ALPHA_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_ALPHA_ARB = 0x84E9;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_LUMINANCE_ARB = 0x84EA;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ALPHA_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;

		/// <summary>
		/// Value of GL_COMPRESSED_INTENSITY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_INTENSITY_ARB = 0x84EC;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_RGB_ARB = 0x84ED;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_RGBA_ARB = 0x84EE;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSION_HINT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSED_ARB = 0x86A1;

		/// <summary>
		/// Value of GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;

		/// <summary>
		/// Value of GL_COMPRESSED_TEXTURE_FORMATS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;

		/// <summary>
		/// Binding for glCompressedTexImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage3DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage3DARB != null, "pglCompressedTexImage3DARB not implemented");
			Delegates.pglCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
			CallLog("glCompressedTexImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage3DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage3DARB != null, "pglCompressedTexImage3DARB not implemented");
			Delegates.pglCompressedTexImage3DARB((int)target, level, internalformat, width, height, depth, border, imageSize, data);
			CallLog("glCompressedTexImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage3DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage2DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage2DARB != null, "pglCompressedTexImage2DARB not implemented");
			Delegates.pglCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
			CallLog("glCompressedTexImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage2DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage2DARB != null, "pglCompressedTexImage2DARB not implemented");
			Delegates.pglCompressedTexImage2DARB((int)target, level, internalformat, width, height, border, imageSize, data);
			CallLog("glCompressedTexImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage2DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage1DARB(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage1DARB != null, "pglCompressedTexImage1DARB not implemented");
			Delegates.pglCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
			CallLog("glCompressedTexImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage1DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage1DARB != null, "pglCompressedTexImage1DARB not implemented");
			Delegates.pglCompressedTexImage1DARB((int)target, level, internalformat, width, border, imageSize, data);
			CallLog("glCompressedTexImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage1DARB(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage3DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage3DARB != null, "pglCompressedTexSubImage3DARB not implemented");
			Delegates.pglCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			CallLog("glCompressedTexSubImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage3DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage3DARB != null, "pglCompressedTexSubImage3DARB not implemented");
			Delegates.pglCompressedTexSubImage3DARB((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage3DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage3DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage2DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage2DARB != null, "pglCompressedTexSubImage2DARB not implemented");
			Delegates.pglCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			CallLog("glCompressedTexSubImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage2DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage2DARB != null, "pglCompressedTexSubImage2DARB not implemented");
			Delegates.pglCompressedTexSubImage2DARB((int)target, level, xoffset, yoffset, width, height, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage2DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage2DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage1DARB(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage1DARB != null, "pglCompressedTexSubImage1DARB not implemented");
			Delegates.pglCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
			CallLog("glCompressedTexSubImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage1DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage1DARB != null, "pglCompressedTexSubImage1DARB not implemented");
			Delegates.pglCompressedTexSubImage1DARB((int)target, level, xoffset, width, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage1DARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage1DARB(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glGetCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void GetCompressedTexImageARB(int target, Int32 level, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedTexImageARB != null, "pglGetCompressedTexImageARB not implemented");
			Delegates.pglGetCompressedTexImageARB(target, level, img);
			CallLog("glGetCompressedTexImageARB({0}, {1}, {2})", target, level, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void GetCompressedTexImageARB(TextureTarget target, Int32 level, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedTexImageARB != null, "pglGetCompressedTexImageARB not implemented");
			Delegates.pglGetCompressedTexImageARB((int)target, level, img);
			CallLog("glGetCompressedTexImageARB({0}, {1}, {2})", target, level, img);
			DebugCheckErrors();
		}

	}

}
