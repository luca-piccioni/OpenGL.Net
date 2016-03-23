
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
		[AliasOf("GL_UNSIGNED_BYTE_3_3_2_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		public const int UNSIGNED_BYTE_3_3_2 = 0x8032;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_5_5_1 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_8_8_8_8_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		public const int UNSIGNED_INT_8_8_8_8 = 0x8035;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10_10_10_2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_10_10_10_2_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		public const int UNSIGNED_INT_10_10_10_2 = 0x8036;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_3D. The initial 
		/// value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_3D_OES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int TEXTURE_BINDING_3D = 0x806A;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is written into memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_PACK_SKIP_IMAGES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PACK_SKIP_IMAGES = 0x806B;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the image height used for writing pixel data to memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if greater than 0, Gl.PACK_IMAGE_HEIGHT defines the number of pixels in an image three-dimensional 
		/// texture volume, where ``image'' is defined by all pixels sharing the same third dimension index. If the first pixel of a 
		/// row is placed at location p in memory, then the location of the first pixel of the next row is obtained by skipping 
		/// k=n⁢l⁢has⁢s⁢n⁢l⁢ha⁢s&gt;=as&lt;a components or indices, where n is the number of components or indices in a pixel, l is 
		/// the number of pixels in a row (Gl.PACK_ROW_LENGTH if it is greater than 0, the width argument to Gl.TexImage3D 
		/// otherwise), h is the number of rows in a pixel image (Gl.PACK_IMAGE_HEIGHT if it is greater than 0, the height argument 
		/// to the Gl.TexImage3D routine otherwise), a is the value of Gl.PACK_ALIGNMENT, and s is the size, in bytes, of a single 
		/// component (if a&lt;s, then it is as if a=s). The word component in this description refers to the nonindex values red, 
		/// green, blue, alpha, and depth. Storage format Gl.RGB, for example, has three components per pixel: first red, then 
		/// green, and finally blue.
		/// </para>
		/// </summary>
		[AliasOf("GL_PACK_IMAGE_HEIGHT_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PACK_IMAGE_HEIGHT = 0x806C;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is read from memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_SKIP_IMAGES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int UNPACK_SKIP_IMAGES = 0x806D;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the image height used for reading pixel data from memory. The initial is 0. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if greater than 0, Gl.UNPACK_IMAGE_HEIGHT defines the number of pixels in an image of a three-dimensional 
		/// texture volume. Where ``image'' is defined by all pixel sharing the same third dimension index. If the first pixel of a 
		/// row is placed at location p in memory, then the location of the first pixel of the next row is obtained by skipping 
		/// k=n⁢l⁢has⁢s⁢n⁢l⁢ha⁢s&gt;=as&lt;a components or indices, where n is the number of components or indices in a pixel, l is 
		/// the number of pixels in a row (Gl.UNPACK_ROW_LENGTH if it is greater than 0, the width argument to Gl.TexImage3D 
		/// otherwise), h is the number of rows in an image (Gl.UNPACK_IMAGE_HEIGHT if it is greater than 0, the height argument to 
		/// Gl.TexImage3D otherwise), a is the value of Gl.UNPACK_ALIGNMENT, and s is the size, in bytes, of a single component (if 
		/// a&lt;s, then it is as if a=s). The word component in this description refers to the nonindex values red, green, blue, 
		/// alpha, and depth. Storage format Gl.RGB, for example, has three components per pixel: first red, then green, and finally 
		/// blue.
		/// </para>
		/// </summary>
		[AliasOf("GL_UNPACK_IMAGE_HEIGHT_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int UNPACK_IMAGE_HEIGHT = 0x806E;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 3D texture mapping is enabled. The initial value is 
		/// Gl.FALSE. See Gl.TexImage3D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, three-dimensional texturing is performed (unless cube-mapped 
		/// texturing is also enabled). See Gl.TexImage3D.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_3D_EXT")]
		[AliasOf("GL_TEXTURE_3D_OES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int TEXTURE_3D = 0x806F;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_3D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int PROXY_TEXTURE_3D = 0x8070;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the depth of the texture image. The initial value is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		public const int TEXTURE_DEPTH = 0x8071;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued wrapping function for texture coordinate r, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued wrapping function for texture coordinate r, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: sets the wrap parameter for texture coordinate r to either Gl.CLAMP_TO_EDGE, Gl.MIRRORED_REPEAT, 
		/// Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. See the discussion under Gl.TEXTURE_WRAP_S. Initially, Gl.TEXTURE_WRAP_R is set 
		/// to Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the wrap parameter for texture coordinate r to either Gl.CLAMP_TO_EDGE, Gl.CLAMP_TO_BORDER, 
		/// Gl.MIRRORED_REPEAT, Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. See the discussion under Gl.TEXTURE_WRAP_S. Initially, 
		/// Gl.TEXTURE_WRAP_R is set to Gl.REPEAT.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_WRAP_R_EXT")]
		[AliasOf("GL_TEXTURE_WRAP_R_OES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int TEXTURE_WRAP_R = 0x8072;

		/// <summary>
		/// Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value must be at 
		/// least 64. Use Gl.PROXY_TEXTURE_3D to determine if a texture is too large. See Gl.TexImage3D.
		/// </summary>
		[AliasOf("GL_MAX_3D_TEXTURE_SIZE_EXT")]
		[AliasOf("GL_MAX_3D_TEXTURE_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int UNSIGNED_SHORT_5_6_5 = 0x8363;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_6_5_REV = 0x8364;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
		[AliasOf("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
		[RequiredByFeature("GL_IMG_read_format", Api = "gles1|gles2")]
		public const int UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_1_5_5_5_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
		public const int UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8_REV = 0x8367;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_2_10_10_10_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_type_2_10_10_10_REV", Api = "gles2")]
		public const int UNSIGNED_INT_2_10_10_10_REV = 0x8368;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed 
		/// bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed 
		/// bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed 
		/// bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a three-component group: red first, followed by green, followed by blue; for Gl.BGR, the 
		/// first component is blue, followed by green and then red. Each component is converted to the internal floating-point 
		/// format in the same way the red, green, and blue components of an RGBA pixel are. The color triple is converted to an 
		/// RGBA pixel with alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[AliasOf("GL_BGR_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_bgra")]
		public const int BGR = 0x80E0;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element contains all four components. Each component is multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element contains all four components. Each component is multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element contains all four components. Each component is multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a four-component group: For Gl.RGBA, the red component is first, followed by green, 
		/// followed by blue, followed by alpha; for Gl.BGRA the order is blue, green, red and then alpha. Floating-point values are 
		/// converted directly to an internal floating-point format with unspecified precision. Signed integer values are mapped 
		/// linearly to the internal floating-point format such that the most positive representable integer value maps to 1.0, and 
		/// the most negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0.) 
		/// Unsigned integer data is mapped similarly: The largest integer value maps to 1.0, and 0 maps to 0.0. The resulting 
		/// floating-point color values are then multiplied by Gl.c_SCALE and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, and 
		/// ALPHA for the respective color components. The results are clamped to the range 01. If Gl.MAP_COLOR is true, each color 
		/// component is scaled by the size of lookup table Gl.PIXEL_MAP_c_TO_c, then replaced by the value that it references in 
		/// that table. c is R, G, B, or A respectively. The GL then converts the resulting RGBA colors to fragments by attaching 
		/// the current raster position z coordinate and texture coordinates to each pixel, then assigning x and y window 
		/// coordinates to the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr is the current raster position. These 
		/// pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or polygons. Texture 
		/// mapping, fog, and all the fragment operations are applied before the fragments are written to the frame buffer.
		/// </para>
		/// </summary>
		[AliasOf("GL_BGRA_EXT")]
		[AliasOf("GL_BGRA_IMG")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_array_bgra", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_array_bgra")]
		[RequiredByFeature("GL_APPLE_texture_format_BGRA8888", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_bgra")]
		[RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_texture_format_BGRA8888", Api = "gles1|gles2")]
		[RequiredByFeature("GL_IMG_read_format", Api = "gles1|gles2")]
		public const int BGRA = 0x80E1;

		/// <summary>
		/// Gl.Get: data returns one value, the recommended maximum number of vertex array vertices. See Gl.DrawRangeElements.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_VERTICES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_range_elements")]
		public const int MAX_ELEMENTS_VERTICES = 0x80E8;

		/// <summary>
		/// Gl.Get: data returns one value, the recommended maximum number of vertex array indices. See Gl.DrawRangeElements.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_INDICES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_range_elements")]
		public const int MAX_ELEMENTS_INDICES = 0x80E9;

		/// <summary>
		/// Value of GL_CLAMP_TO_EDGE symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_TO_EDGE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_edge_clamp")]
		public const int CLAMP_TO_EDGE = 0x812F;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture minimum level-of-detail value. The initial value is -1000.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture minimum level-of-detail value. The initial value is -1000.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: sets the minimum level-of-detail parameter. This floating-point value limits the selection of 
		/// highest resolution mipmap (lowest mipmap level). The initial value is -1000.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the minimum level-of-detail parameter. This floating-point value limits the selection of highest 
		/// resolution mipmap (lowest mipmap level). The initial value is -1000.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_MIN_LOD_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		public const int TEXTURE_MIN_LOD = 0x813A;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture maximum level-of-detail value. The initial value is 1000.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture maximum level-of-detail value. The initial value is 1000.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: sets the maximum level-of-detail parameter. This floating-point value limits the selection of the 
		/// lowest resolution mipmap (highest mipmap level). The initial value is 1000.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the maximum level-of-detail parameter. This floating-point value limits the selection of the 
		/// lowest resolution mipmap (highest mipmap level). The initial value is 1000.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LOD_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		public const int TEXTURE_MAX_LOD = 0x813B;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued base texture mipmap level. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.TexParameter: specifies the index of the lowest defined mipmap level. This is an integer value. The initial value is 
		/// 0.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_BASE_LEVEL_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		public const int TEXTURE_BASE_LEVEL = 0x813C;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued maximum texture mipmap array level. The initial value is 1000.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the index of the highest defined mipmap level. This is an integer value. The initial value is 
		/// 1000.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LEVEL_APPLE")]
		[AliasOf("GL_TEXTURE_MAX_LEVEL_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_max_level", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		public const int TEXTURE_MAX_LEVEL = 0x813D;

		/// <summary>
		/// Gl.Get: data returns a pair of values indicating the range of widths supported for aliased lines. See Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns single boolean value indicating whether normal rescaling is enabled. See Gl.Enable.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, normal vectors are scaled after transformation and before lighting 
		/// by a factor computed from the modelview matrix. If the modelview matrix scales space uniformly, this has the effect of 
		/// restoring the transformed normal to unit length. This method is generally more efficient than Gl.NORMALIZE. See 
		/// Gl.Normal and Gl.NormalPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_RESCALE_NORMAL_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_rescale_normal")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RESCALE_NORMAL = 0x803A;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns single enumerated value indicating whether specular reflection calculations are separated from 
		/// normal lighting computations. The initial value is Gl.SINGLE_COLOR.
		/// </para>
		/// <para>
		/// Gl.LightModel: params must be either Gl.SEPARATE_SPECULAR_COLOR or Gl.SINGLE_COLOR. Gl.SINGLE_COLOR specifies that a 
		/// single color is generated from the lighting computation for a vertex. Gl.SEPARATE_SPECULAR_COLOR specifies that the 
		/// specular color computation of lighting be stored separately from the remainder of the lighting computation. The specular 
		/// color is summed into the generated fragment's color after the application of texture mapping (if enabled). The initial 
		/// value is Gl.SINGLE_COLOR.
		/// </para>
		/// </summary>
		[AliasOf("GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

		/// <summary>
		/// Value of GL_SINGLE_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SINGLE_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SINGLE_COLOR = 0x81F9;

		/// <summary>
		/// Value of GL_SEPARATE_SPECULAR_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SEPARATE_SPECULAR_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SEPARATE_SPECULAR_COLOR = 0x81FA;

		/// <summary>
		/// Gl.Get: params returns two values, the smallest and largest supported sizes for aliased points.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALIASED_POINT_SIZE_RANGE = 0x846D;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in <paramref name="indices"/>.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in <paramref name="indices"/>.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// It is an error for indices to lie outside the range startend, but implementations may not check for this situation. Such 
		/// indices cause implementation-dependent behavior.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if end&lt;start.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		[AliasOf("glDrawRangeElementsEXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_range_elements")]
		public static void DrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawRangeElements != null, "pglDrawRangeElements not implemented");
			Delegates.pglDrawRangeElements((Int32)mode, start, end, count, (Int32)type, indices);
			LogFunction("glDrawRangeElements({0}, {1}, {2}, {3}, {4}, 0x{5})", mode, start, end, count, type, indices.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in <paramref name="indices"/>.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in <paramref name="indices"/>.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// It is an error for indices to lie outside the range startend, but implementations may not check for this situation. Such 
		/// indices cause implementation-dependent behavior.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if end&lt;start.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		[AliasOf("glDrawRangeElementsEXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_range_elements")]
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
		/// Specifies the target texture. Must be one of Gl.TEXTURE_3D, Gl.PROXY_TEXTURE_3D, Gl.TEXTURE_2D_ARRAY or 
		/// Gl.PROXY_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of 
		/// the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels 
		/// high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D 
		/// texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.RED_INTEGER, Gl.RG_INTEGER, Gl.RGB_INTEGER, Gl.BGR_INTEGER, Gl.RGBA_INTEGER, Gl.BGRA_INTEGER, 
		/// Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.DEPTH_STENCIL.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX and Gl.DEPTH_COMPONENT are accepted.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not one of the accepted resolution and format 
		/// symbolic constants.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0 or greater than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> or <paramref name="internalFormat"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexImage3DEXT")]
		[AliasOf("glTexImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void TexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglTexImage3D != null, "pglTexImage3D not implemented");
			Delegates.pglTexImage3D((Int32)target, level, internalformat, width, height, depth, border, (Int32)format, (Int32)type, data);
			LogFunction("glTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", target, level, internalformat, width, height, depth, border, format, type, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be one of Gl.TEXTURE_3D, Gl.PROXY_TEXTURE_3D, Gl.TEXTURE_2D_ARRAY or 
		/// Gl.PROXY_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of 
		/// the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels 
		/// high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D 
		/// texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.RED_INTEGER, Gl.RG_INTEGER, Gl.RGB_INTEGER, Gl.BGR_INTEGER, Gl.RGBA_INTEGER, Gl.BGRA_INTEGER, 
		/// Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.DEPTH_STENCIL.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX and Gl.DEPTH_COMPONENT are accepted.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not one of the accepted resolution and format 
		/// symbolic constants.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0 or greater than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> or <paramref name="internalFormat"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexImage3DEXT")]
		[AliasOf("glTexImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void TexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_pixels = GCHandle.Alloc(data, GCHandleType.Pinned);
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
		/// Specifies the target to which the texture is bound for Gl.TexSubImage3D. Must be Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage3D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		/// zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, d is the 
		/// Gl.TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		/// border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		/// operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexSubImage3DEXT")]
		[AliasOf("glTexSubImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void TexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage3D != null, "pglTexSubImage3D not implemented");
			Delegates.pglTexSubImage3D((Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, (Int32)type, pixels);
			LogFunction("glTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage3D. Must be Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage3D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		/// zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, d is the 
		/// Gl.TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		/// border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		/// operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glTexSubImage3DEXT")]
		[AliasOf("glTexSubImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
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
		/// Specifies the target to which the texture object is bound for Gl.CopyTexSubImage3D function. Must be Gl.TEXTURE_3D or 
		/// Gl.TEXTURE_2D_ARRAY.
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CopyTexSubImage3D if <paramref name="target"/> is not Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_2D_ARRAY or Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyTextureSubImage3D if the effective target is not Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_CUBE_MAP_ARRAY or Gl.TEXTURE_CUBE_MAP.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_FRAMEBUFFER_OPERATION is generated if the object bound to Gl.READ_FRAMEBUFFER_BINDING is not framebuffer 
		/// complete.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		/// operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyTextureSubImage3D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if level&gt;log2⁡max, where max is the returned value of Gl.MAX_3D_TEXTURE_SIZE if 
		/// <paramref name="target"/> is Gl.TEXTURE_3D or the returned value of Gl.MAX_ARRAY_TEXTURE_LAYERS if <paramref 
		/// name="target"/> is Gl.TEXTURE_2D_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;0, xoffset+width&gt;w, yoffset&lt;0, yoffset+height&gt;h, zoffset&lt;0, or 
		/// zoffset+1&gt;d, where w is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, d is the Gl.TEXTURE_DEPTH and of the 
		/// texture image being modified. Note that w, h, and d include twice the border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if:the read buffer is Gl.NONE, orthe value of Gl.READ_FRAMEBUFFER_BINDING is non-zero, 
		/// and:the read buffer selects an attachment that has no image attached, orthe effective value of Gl.SAMPLE_BUFFERS for the 
		/// read framebuffer is one.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glCopyTexSubImage3DEXT")]
		[AliasOf("glCopyTexSubImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_copy_texture")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void CopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage3D != null, "pglCopyTexSubImage3D not implemented");
			Delegates.pglCopyTexSubImage3D((Int32)target, level, xoffset, yoffset, zoffset, x, y, width, height);
			LogFunction("glCopyTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors(null);
		}

	}

}
