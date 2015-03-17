
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
		public const int UNSIGNED_BYTE_3_3_2 = 0x8032;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_5_5_1 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_8_8_8_8_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8 = 0x8035;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10_10_10_2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_10_10_10_2_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_10_10_10_2 = 0x8036;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_3D. The initial 
		/// value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_3D = 0x806A;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is written into memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_PACK_SKIP_IMAGES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_SKIP_IMAGES = 0x806B;

		/// <summary>
		/// Gl.Get: data returns one value, the image height used for writing pixel data to memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_PACK_IMAGE_HEIGHT_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_IMAGE_HEIGHT = 0x806C;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel images skipped before the first pixel is read from memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_SKIP_IMAGES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNPACK_SKIP_IMAGES = 0x806D;

		/// <summary>
		/// Gl.Get: data returns one value, the image height used for reading pixel data from memory. The initial is 0. See 
		/// Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_IMAGE_HEIGHT_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
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
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_3D = 0x806F;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_3D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PROXY_TEXTURE_3D = 0x8070;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the depth of the texture image. The initial value is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
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
		/// </summary>
		[AliasOf("GL_TEXTURE_WRAP_R_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_WRAP_R = 0x8072;

		/// <summary>
		/// Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value must be at 
		/// least 64. Use Gl.PROXY_TEXTURE_3D to determine if a texture is too large. See Gl.TexImage3D.
		/// </summary>
		[AliasOf("GL_MAX_3D_TEXTURE_SIZE_EXT")]
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
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_array_bgra")]
		[RequiredByFeature("GL_EXT_vertex_array_bgra")]
		public const int BGRA = 0x80E1;

		/// <summary>
		/// Gl.Get: data returns one value, the recommended maximum number of vertex array vertices. See Gl.DrawRangeElements.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_VERTICES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_VERTICES = 0x80E8;

		/// <summary>
		/// Gl.Get: data returns one value, the recommended maximum number of vertex array indices. See Gl.DrawRangeElements.
		/// </summary>
		[AliasOf("GL_MAX_ELEMENTS_INDICES_EXT")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_INDICES = 0x80E9;

		/// <summary>
		/// Value of GL_CLAMP_TO_EDGE symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_TO_EDGE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int CLAMP_TO_EDGE = 0x812F;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture minimum level-of-detail value. The initial value is -1000.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture minimum level-of-detail value. The initial value is -1000.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_MIN_LOD_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MIN_LOD = 0x813A;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture maximum level-of-detail value. The initial value is 1000.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture maximum level-of-detail value. The initial value is 1000.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LOD_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LOD = 0x813B;

		/// <summary>
		/// Gl.GetTexParameter: returns the single-valued base texture mipmap level. The initial value is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_BASE_LEVEL_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_BASE_LEVEL = 0x813C;

		/// <summary>
		/// Gl.GetTexParameter: returns the single-valued maximum texture mipmap array level. The initial value is 1000.
		/// </summary>
		[AliasOf("GL_TEXTURE_MAX_LEVEL_SGIS")]
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LEVEL = 0x813D;

		/// <summary>
		/// Gl.Get: data returns a pair of values indicating the range of widths supported for aliased lines. See Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SEPARATE_SPECULAR_COLOR = 0x81FA;

		/// <summary>
		/// Gl.Get: params returns two values, the smallest and largest supported sizes for aliased points.
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
			Debug.Assert(Delegates.pglDrawRangeElements != null, "pglDrawRangeElements not implemented");
			Delegates.pglDrawRangeElements((int)mode, start, end, count, (int)type, indices);
			CallLog("glDrawRangeElements({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
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
			Debug.Assert(Delegates.pglTexImage3D != null, "pglTexImage3D not implemented");
			Delegates.pglTexImage3D((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
			CallLog("glTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
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
			Debug.Assert(Delegates.pglTexSubImage3D != null, "pglTexSubImage3D not implemented");
			Delegates.pglTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
			CallLog("glTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
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
			Debug.Assert(Delegates.pglCopyTexSubImage3D != null, "pglCopyTexSubImage3D not implemented");
			Delegates.pglCopyTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
			CallLog("glCopyTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors();
		}

	}

}
