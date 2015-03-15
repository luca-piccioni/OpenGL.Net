
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
		/// Value of GL_UNSIGNED_BYTE_3_3_2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_BYTE_3_3_2_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_BYTE_3_3_2 = 0x8032;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_4_4_4_4_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_5_5_1 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_5_5_5_1_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_8_8_8_8_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8 = 0x8035;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10_10_10_2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_10_10_10_2_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_10_10_10_2 = 0x8036;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_3D = 0x806A;

		/// <summary>
		/// Value of GL_PACK_SKIP_IMAGES symbol.
		/// </summary>
		[AliasOf("GL_PACK_SKIP_IMAGES_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_SKIP_IMAGES = 0x806B;

		/// <summary>
		/// Value of GL_PACK_IMAGE_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_PACK_IMAGE_HEIGHT_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_IMAGE_HEIGHT = 0x806C;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_IMAGES symbol.
		/// </summary>
		[AliasOf("GL_UNPACK_SKIP_IMAGES_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNPACK_SKIP_IMAGES = 0x806D;

		/// <summary>
		/// Value of GL_UNPACK_IMAGE_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_UNPACK_IMAGE_HEIGHT_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNPACK_IMAGE_HEIGHT = 0x806E;

		/// <summary>
		/// Value of GL_TEXTURE_3D symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_3D_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_3D = 0x806F;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_3D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_3D_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PROXY_TEXTURE_3D = 0x8070;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_DEPTH = 0x8071;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_R symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_WRAP_R_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_WRAP_R = 0x8072;

		/// <summary>
		/// Value of GL_MAX_3D_TEXTURE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_MAX_3D_TEXTURE_SIZE_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_3D_TEXTURE_SIZE = 0x8073;

		/// <summary>
		/// Value of GL_UNSIGNED_BYTE_2_3_3_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_BYTE_2_3_3_REV = 0x8362;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_6_5 = 0x8363;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_6_5_REV = 0x8364;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_1_5_5_5_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8_REV = 0x8367;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_2_10_10_10_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public const int UNSIGNED_INT_2_10_10_10_REV = 0x8368;

		/// <summary>
		/// Value of GL_BGR symbol.
		/// </summary>
		[AliasOf("GL_BGR_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int BGR = 0x80E0;

		/// <summary>
		/// Value of GL_BGRA symbol.
		/// </summary>
		[AliasOf("GL_BGRA_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_array_bgra")]
		[RequiredByFeature("GL_EXT_vertex_array_bgra")]
		public const int BGRA = 0x80E1;

		/// <summary>
		/// Value of GL_MAX_ELEMENTS_VERTICES symbol.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_VERTICES_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_VERTICES = 0x80E8;

		/// <summary>
		/// Value of GL_MAX_ELEMENTS_INDICES symbol.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_INDICES_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_INDICES = 0x80E9;

		/// <summary>
		/// Value of GL_CLAMP_TO_EDGE symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_TO_EDGE_SGIS"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int CLAMP_TO_EDGE = 0x812F;

		/// <summary>
		/// Value of GL_TEXTURE_MIN_LOD symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_MIN_LOD_SGIS"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MIN_LOD = 0x813A;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_LOD symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LOD_SGIS"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LOD = 0x813B;

		/// <summary>
		/// Value of GL_TEXTURE_BASE_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BASE_LEVEL_SGIS"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_BASE_LEVEL = 0x813C;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LEVEL_SGIS"]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LEVEL = 0x813D;

		/// <summary>
		/// Value of GL_ALIASED_LINE_WIDTH_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;

		/// <summary>
		/// Value of GL_RESCALE_NORMAL symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_RESCALE_NORMAL_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RESCALE_NORMAL = 0x803A;

		/// <summary>
		/// Value of GL_LIGHT_MODEL_COLOR_CONTROL symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LIGHT_MODEL_COLOR_CONTROL_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

		/// <summary>
		/// Value of GL_SINGLE_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SINGLE_COLOR_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SINGLE_COLOR = 0x81F9;

		/// <summary>
		/// Value of GL_SEPARATE_SPECULAR_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SEPARATE_SPECULAR_COLOR_EXT"]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SEPARATE_SPECULAR_COLOR = 0x81FA;

		/// <summary>
		/// Value of GL_ALIASED_POINT_SIZE_RANGE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALIASED_POINT_SIZE_RANGE = 0x846D;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in indices.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in indices.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void DrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			if        (Delegates.pglDrawRangeElements != null) {
				Delegates.pglDrawRangeElements((int)mode, start, end, count, (int)type, indices);
				CallLog("glDrawRangeElements({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else if (Delegates.pglDrawRangeElementsEXT != null) {
				Delegates.pglDrawRangeElementsEXT((int)mode, start, end, count, (int)type, indices);
				CallLog("glDrawRangeElementsEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else
				throw new NotImplementedException("glDrawRangeElements (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in indices.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in indices.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void DrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, Object indices)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElements(mode, start, end, count, type, pin_indices.AddrOfPinnedObject());
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexImage3D != null) {
				Delegates.pglTexImage3D((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
				CallLog("glTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else if (Delegates.pglTexImage3DEXT != null) {
				Delegates.pglTexImage3DEXT((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
				CallLog("glTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else
				throw new NotImplementedException("glTexImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage3D. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage3D != null) {
				Delegates.pglTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
				CallLog("glTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else if (Delegates.pglTexSubImage3DEXT != null) {
				Delegates.pglTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
				CallLog("glTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage3D. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// copy a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/>
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void CopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyTexSubImage3D != null) {
				Delegates.pglCopyTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage3DEXT != null) {
				Delegates.pglCopyTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
