
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
		/// Value of GL_TEXTURE0 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE0_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE0 = 0x84C0;

		/// <summary>
		/// Value of GL_TEXTURE1 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE1_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE1 = 0x84C1;

		/// <summary>
		/// Value of GL_TEXTURE2 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE2_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE2 = 0x84C2;

		/// <summary>
		/// Value of GL_TEXTURE3 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE3_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE3 = 0x84C3;

		/// <summary>
		/// Value of GL_TEXTURE4 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE4_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE4 = 0x84C4;

		/// <summary>
		/// Value of GL_TEXTURE5 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE5_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE5 = 0x84C5;

		/// <summary>
		/// Value of GL_TEXTURE6 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE6_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE6 = 0x84C6;

		/// <summary>
		/// Value of GL_TEXTURE7 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE7_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE7 = 0x84C7;

		/// <summary>
		/// Value of GL_TEXTURE8 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE8_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE8 = 0x84C8;

		/// <summary>
		/// Value of GL_TEXTURE9 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE9_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE9 = 0x84C9;

		/// <summary>
		/// Value of GL_TEXTURE10 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE10_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE10 = 0x84CA;

		/// <summary>
		/// Value of GL_TEXTURE11 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE11_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE11 = 0x84CB;

		/// <summary>
		/// Value of GL_TEXTURE12 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE12_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE12 = 0x84CC;

		/// <summary>
		/// Value of GL_TEXTURE13 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE13_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE13 = 0x84CD;

		/// <summary>
		/// Value of GL_TEXTURE14 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE14_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE14 = 0x84CE;

		/// <summary>
		/// Value of GL_TEXTURE15 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE15_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE15 = 0x84CF;

		/// <summary>
		/// Value of GL_TEXTURE16 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE16_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE16 = 0x84D0;

		/// <summary>
		/// Value of GL_TEXTURE17 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE17_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE17 = 0x84D1;

		/// <summary>
		/// Value of GL_TEXTURE18 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE18_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE18 = 0x84D2;

		/// <summary>
		/// Value of GL_TEXTURE19 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE19_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE19 = 0x84D3;

		/// <summary>
		/// Value of GL_TEXTURE20 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE20_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE20 = 0x84D4;

		/// <summary>
		/// Value of GL_TEXTURE21 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE21_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE21 = 0x84D5;

		/// <summary>
		/// Value of GL_TEXTURE22 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE22_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE22 = 0x84D6;

		/// <summary>
		/// Value of GL_TEXTURE23 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE23_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE23 = 0x84D7;

		/// <summary>
		/// Value of GL_TEXTURE24 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE24_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE24 = 0x84D8;

		/// <summary>
		/// Value of GL_TEXTURE25 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE25_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE25 = 0x84D9;

		/// <summary>
		/// Value of GL_TEXTURE26 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE26_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE26 = 0x84DA;

		/// <summary>
		/// Value of GL_TEXTURE27 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE27_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE27 = 0x84DB;

		/// <summary>
		/// Value of GL_TEXTURE28 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE28_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE28 = 0x84DC;

		/// <summary>
		/// Value of GL_TEXTURE29 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE29_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE29 = 0x84DD;

		/// <summary>
		/// Value of GL_TEXTURE30 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE30_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE30 = 0x84DE;

		/// <summary>
		/// Value of GL_TEXTURE31 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE31_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE31 = 0x84DF;

		/// <summary>
		/// Gl.Get: data returns a single value indicating the active multitexture unit. The initial value is Gl.TEXTURE0. See 
		/// Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_ACTIVE_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int ACTIVE_TEXTURE = 0x84E0;

		/// <summary>
		/// Gl.Enable: if enabled, use multiple fragment samples in computing the final color of a pixel. See Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_MULTISAMPLE_ARB")]
		[AliasOf("GL_MULTISAMPLE_EXT")]
		[AliasOf("GL_MULTISAMPLE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int MULTISAMPLE = 0x809D;

		/// <summary>
		/// Gl.Enable: if enabled, compute a temporary coverage value where each bit is determined by the alpha value at the 
		/// corresponding sample location. The temporary coverage value is then ANDed with the fragment coverage value.
		/// </summary>
		[AliasOf("GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

		/// <summary>
		/// Gl.Enable: if enabled, each sample alpha value is replaced by the maximum representable alpha value.
		/// </summary>
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_ARB")]
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_EXT")]
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_ALPHA_TO_ONE = 0x809F;

		/// <summary>
		/// Gl.Enable: if enabled, the fragment's coverage is ANDed with the temporary coverage value. If Gl.SAMPLE_COVERAGE_INVERT 
		/// is set to Gl.TRUE, invert the coverage value. See Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_COVERAGE = 0x80A0;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single integer value indicating the number of sample buffers associated with the framebuffer. See 
		/// Gl.SampleCoverage.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns an integer value indicating the number of sample buffers associated with the 
		/// framebuffer object. See Gl.SampleCoverage.
		/// </para>
		/// </summary>
		[AliasOf("GL_SAMPLE_BUFFERS_ARB")]
		[AliasOf("GL_SAMPLE_BUFFERS_EXT")]
		[AliasOf("GL_SAMPLE_BUFFERS_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_BUFFERS = 0x80A8;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single integer value indicating the coverage mask size. See Gl.SampleCoverage.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns an integer value indicating the coverage mask size for the framebuffer object. 
		/// See Gl.SampleCoverage.
		/// </para>
		/// </summary>
		[AliasOf("GL_SAMPLES_ARB")]
		[AliasOf("GL_SAMPLES_EXT")]
		[AliasOf("GL_SAMPLES_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SAMPLES = 0x80A9;

		/// <summary>
		/// Gl.Get: data returns a single positive floating-point value indicating the current sample coverage value. See 
		/// Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_VALUE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_COVERAGE_VALUE = 0x80AA;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating if the temporary coverage value should be inverted. See 
		/// Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_INVERT_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int SAMPLE_COVERAGE_INVERT = 0x80AB;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether cube-mapped texture mapping is enabled. The initial 
		/// value is Gl.FALSE. See Gl.TexImage2D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, cube-mapped texturing is performed. See Gl.TexImage2D.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_CUBE_MAP = 0x8513;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_CUBE_MAP. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the GL can handle. 
		/// The value must be at least 1024. Use Gl.PROXY_TEXTURE_CUBE_MAP to determine if a texture is too large. See 
		/// Gl.TexImage2D.
		/// </summary>
		[AliasOf("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
		[AliasOf("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int COMPRESSED_RGB = 0x84ED;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int COMPRESSED_RGBA = 0x84EE;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single value indicating the mode of the texture compression hint. The initial value is 
		/// Gl.DONT_CARE.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the quality and performance of the compressing texture images. Hinting Gl.FASTEST indicates that 
		/// texture images should be compressed as quickly as possible, while Gl.NICEST indicates that texture images should be 
		/// compressed with as little image quality loss as possible. Gl.NICEST should be selected if the texture is to be retrieved 
		/// by Gl.GetCompressedTexImage for reuse.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPRESSION_HINT_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_COMPRESSION_HINT = 0x84EF;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single integer value, the number of unsigned bytes of the compressed texture 
		/// image that would be returned from Gl.GetCompressedTexImage.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single boolean value indicating if the texture image is stored in a compressed 
		/// internal format. The initiali value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPRESSED_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_COMPRESSED = 0x86A1;

		/// <summary>
		/// Gl.Get: data returns a single integer value indicating the number of available compressed texture formats. The minimum 
		/// value is 4. See Gl.CompressedTexImage2D.
		/// </summary>
		[AliasOf("GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

		/// <summary>
		/// Gl.Get: data returns a list of symbolic constants of length Gl.NUM_COMPRESSED_TEXTURE_FORMATS indicating which 
		/// compressed texture formats are available. See Gl.CompressedTexImage2D.
		/// </summary>
		[AliasOf("GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_TO_BORDER_ARB")]
		[AliasOf("GL_CLAMP_TO_BORDER_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int CLAMP_TO_BORDER = 0x812D;

		/// <summary>
		/// Gl.Get: params returns a single integer value indicating the current client active multitexture unit. The initial value 
		/// is Gl.TEXTURE0. See Gl.ClientActiveTexture.
		/// </summary>
		[AliasOf("GL_CLIENT_ACTIVE_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIENT_ACTIVE_TEXTURE = 0x84E1;

		/// <summary>
		/// Gl.Get: params returns a single value indicating the number of conventional texture units supported. Each conventional 
		/// texture unit includes both a texture coordinate set and a texture image unit. Conventional texture units may be used for 
		/// fixed-function (non-shader) rendering. The value must be at least 2. Additional texture coordinate sets and texture 
		/// image units may be accessed from vertex and fragment shaders. See Gl.ActiveTexture and Gl.ClientActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_TEXTURE_UNITS = 0x84E2;

		/// <summary>
		/// Gl.Get: params returns 16 values, the elements of the modelview matrix in row-major order. See Gl.LoadTransposeMatrix.
		/// </summary>
		[AliasOf("GL_TRANSPOSE_MODELVIEW_MATRIX_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;

		/// <summary>
		/// Gl.Get: params returns 16 values, the elements of the projection matrix in row-major order. See Gl.LoadTransposeMatrix.
		/// </summary>
		[AliasOf("GL_TRANSPOSE_PROJECTION_MATRIX_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_PROJECTION_MATRIX = 0x84E4;

		/// <summary>
		/// Gl.Get: params returns 16 values, the elements of the texture matrix in row-major order. See Gl.LoadTransposeMatrix.
		/// </summary>
		[AliasOf("GL_TRANSPOSE_TEXTURE_MATRIX_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_TEXTURE_MATRIX = 0x84E5;

		/// <summary>
		/// Gl.Get: params returns 16 values, the elements of the color matrix in row-major order. See Gl.LoadTransposeMatrix.
		/// </summary>
		[AliasOf("GL_TRANSPOSE_COLOR_MATRIX_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_COLOR_MATRIX = 0x84E6;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BIT symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_MULTISAMPLE_BIT_ARB")]
		[AliasOf("GL_MULTISAMPLE_BIT_EXT")]
		[AliasOf("GL_MULTISAMPLE_BIT_3DFX")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint MULTISAMPLE_BIT = 0x20000000;

		/// <summary>
		/// Value of GL_NORMAL_MAP symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_NORMAL_MAP_ARB")]
		[AliasOf("GL_NORMAL_MAP_EXT")]
		[AliasOf("GL_NORMAL_MAP_NV")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_MAP = 0x8511;

		/// <summary>
		/// Value of GL_REFLECTION_MAP symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_REFLECTION_MAP_ARB")]
		[AliasOf("GL_REFLECTION_MAP_EXT")]
		[AliasOf("GL_REFLECTION_MAP_NV")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int REFLECTION_MAP = 0x8512;

		/// <summary>
		/// Value of GL_COMPRESSED_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_ALPHA_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_ALPHA = 0x84E9;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_LUMINANCE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_LUMINANCE = 0x84EA;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_LUMINANCE_ALPHA_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_LUMINANCE_ALPHA = 0x84EB;

		/// <summary>
		/// Value of GL_COMPRESSED_INTENSITY symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPRESSED_INTENSITY_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_INTENSITY = 0x84EC;

		/// <summary>
		/// Value of GL_COMBINE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMBINE_ARB")]
		[AliasOf("GL_COMBINE_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE = 0x8570;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the current RGB combine mode. The initial 
		/// value is Gl.MODULATE.
		/// </summary>
		[AliasOf("GL_COMBINE_RGB_ARB")]
		[AliasOf("GL_COMBINE_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE_RGB = 0x8571;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the current alpha combine mode. The initial 
		/// value is Gl.MODULATE.
		/// </summary>
		[AliasOf("GL_COMBINE_ALPHA_ARB")]
		[AliasOf("GL_COMBINE_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE_ALPHA = 0x8572;

		/// <summary>
		/// Value of GL_SOURCE0_RGB symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE0_RGB_ARB")]
		[AliasOf("GL_SOURCE0_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE0_RGB = 0x8580;

		/// <summary>
		/// Value of GL_SOURCE1_RGB symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE1_RGB_ARB")]
		[AliasOf("GL_SOURCE1_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE1_RGB = 0x8581;

		/// <summary>
		/// Value of GL_SOURCE2_RGB symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE2_RGB_ARB")]
		[AliasOf("GL_SOURCE2_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE2_RGB = 0x8582;

		/// <summary>
		/// Value of GL_SOURCE0_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE0_ALPHA_ARB")]
		[AliasOf("GL_SOURCE0_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE0_ALPHA = 0x8588;

		/// <summary>
		/// Value of GL_SOURCE1_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE1_ALPHA_ARB")]
		[AliasOf("GL_SOURCE1_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE1_ALPHA = 0x8589;

		/// <summary>
		/// Value of GL_SOURCE2_ALPHA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SOURCE2_ALPHA_ARB")]
		[AliasOf("GL_SOURCE2_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE2_ALPHA = 0x858A;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner zero's RGB operand. The 
		/// initial value is Gl.SRC_COLOR.
		/// </summary>
		[AliasOf("GL_OPERAND0_RGB_ARB")]
		[AliasOf("GL_OPERAND0_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND0_RGB = 0x8590;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner one's RGB operand. The 
		/// initial value is Gl.SRC_COLOR.
		/// </summary>
		[AliasOf("GL_OPERAND1_RGB_ARB")]
		[AliasOf("GL_OPERAND1_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND1_RGB = 0x8591;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner two's RGB operand. The 
		/// initial value is Gl.SRC_ALPHA.
		/// </summary>
		[AliasOf("GL_OPERAND2_RGB_ARB")]
		[AliasOf("GL_OPERAND2_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND2_RGB = 0x8592;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner zero's alpha operand. 
		/// The initial value is Gl.SRC_ALPHA.
		/// </summary>
		[AliasOf("GL_OPERAND0_ALPHA_ARB")]
		[AliasOf("GL_OPERAND0_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND0_ALPHA = 0x8598;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner one's alpha operand. The 
		/// initial value is Gl.SRC_ALPHA.
		/// </summary>
		[AliasOf("GL_OPERAND1_ALPHA_ARB")]
		[AliasOf("GL_OPERAND1_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND1_ALPHA = 0x8599;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner two's alpha operand. The 
		/// initial value is Gl.SRC_ALPHA.
		/// </summary>
		[AliasOf("GL_OPERAND2_ALPHA_ARB")]
		[AliasOf("GL_OPERAND2_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND2_ALPHA = 0x859A;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single floating-point value representing the current RGB texture combiner scaling factor. 
		/// The initial value is 1.0.
		/// </summary>
		[AliasOf("GL_RGB_SCALE_ARB")]
		[AliasOf("GL_RGB_SCALE_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RGB_SCALE = 0x8573;

		/// <summary>
		/// Value of GL_ADD_SIGNED symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ADD_SIGNED_ARB")]
		[AliasOf("GL_ADD_SIGNED_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ADD_SIGNED = 0x8574;

		/// <summary>
		/// Value of GL_INTERPOLATE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTERPOLATE_ARB")]
		[AliasOf("GL_INTERPOLATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTERPOLATE = 0x8575;

		/// <summary>
		/// Value of GL_SUBTRACT symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SUBTRACT_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SUBTRACT = 0x84E7;

		/// <summary>
		/// Value of GL_CONSTANT symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CONSTANT_ARB")]
		[AliasOf("GL_CONSTANT_EXT")]
		[AliasOf("GL_CONSTANT_NV")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CONSTANT = 0x8576;

		/// <summary>
		/// Value of GL_PRIMARY_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_PRIMARY_COLOR_ARB")]
		[AliasOf("GL_PRIMARY_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PRIMARY_COLOR = 0x8577;

		/// <summary>
		/// Value of GL_PREVIOUS symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_PREVIOUS_ARB")]
		[AliasOf("GL_PREVIOUS_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PREVIOUS = 0x8578;

		/// <summary>
		/// Value of GL_DOT3_RGB symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_DOT3_RGB_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOT3_RGB = 0x86AE;

		/// <summary>
		/// Value of GL_DOT3_RGBA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_DOT3_RGBA_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOT3_RGBA = 0x86AF;

		/// <summary>
		/// select active texture unit
		/// </summary>
		/// <param name="texture">
		/// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at 
		/// least 80. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of 
		/// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void ActiveTexture(int texture)
		{
			Debug.Assert(Delegates.pglActiveTexture != null, "pglActiveTexture not implemented");
			Delegates.pglActiveTexture(texture);
			CallLog("glActiveTexture({0})", texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify multisample coverage parameters
		/// </summary>
		/// <param name="value">
		/// Specify a single floating-point sample coverage value. The value is clamped to the range 01. The initial value is 1.0.
		/// </param>
		/// <param name="invert">
		/// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. 
		/// The initial value is GL_FALSE.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void SampleCoverage(float value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoverage != null, "pglSampleCoverage not implemented");
			Delegates.pglSampleCoverage(value, invert);
			CallLog("glSampleCoverage({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage3D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage3D != null, "pglCompressedTexImage3D not implemented");
			Delegates.pglCompressedTexImage3D((int)target, level, internalformat, width, height, depth, border, imageSize, data);
			CallLog("glCompressedTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage3D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture images 
		/// that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D 
		/// texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage2D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage2D != null, "pglCompressedTexImage2D not implemented");
			Delegates.pglCompressedTexImage2D((int)target, level, internalformat, width, height, border, imageSize, data);
			CallLog("glCompressedTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture images 
		/// that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D 
		/// texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage2D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage1D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage1D != null, "pglCompressedTexImage1D not implemented");
			Delegates.pglCompressedTexImage1D((int)target, level, internalformat, width, border, imageSize, data);
			CallLog("glCompressedTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexImage1D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage1D(target, level, internalformat, width, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage3D function. Must be GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_3D, or GL_TEXTURE_CUBE_MAP_ARRAY.
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
		/// A <see cref="T:Int32"/>.
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
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage3D != null, "pglCompressedTexSubImage3D not implemented");
			Delegates.pglCompressedTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage3D function. Must be GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_3D, or GL_TEXTURE_CUBE_MAP_ARRAY.
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
		/// A <see cref="T:Int32"/>.
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
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage2D function. Must be GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
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
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage2D != null, "pglCompressedTexSubImage2D not implemented");
			Delegates.pglCompressedTexSubImage2D((int)target, level, xoffset, yoffset, width, height, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage2D function. Must be GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
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
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for glCompressedTexSubImage1D function. Must be GL_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage1D != null, "pglCompressedTexSubImage1D not implemented");
			Delegates.pglCompressedTexSubImage1D((int)target, level, xoffset, width, (int)format, imageSize, data);
			CallLog("glCompressedTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for glCompressedTexSubImage1D function. Must be GL_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void CompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void GetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedTexImage != null, "pglGetCompressedTexImage not implemented");
			Delegates.pglGetCompressedTexImage((int)target, level, img);
			CallLog("glGetCompressedTexImage({0}, {1}, {2})", target, level, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		public static void GetCompressedTexImage(TextureTarget target, Int32 level, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetCompressedTexImage(target, level, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// select active texture unit
		/// </summary>
		/// <param name="texture">
		/// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at 
		/// least two. <paramref name="texture"/> must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to the value of 
		/// <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. The initial value is <see 
		/// cref="Gl.TEXTURE0"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClientActiveTexture(int texture)
		{
			Debug.Assert(Delegates.pglClientActiveTexture != null, "pglClientActiveTexture not implemented");
			Delegates.pglClientActiveTexture(texture);
			CallLog("glClientActiveTexture({0})", texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, double s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1d != null, "pglMultiTexCoord1d not implemented");
			Delegates.pglMultiTexCoord1d(target, s);
			CallLog("glMultiTexCoord1d({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1dv != null, "pglMultiTexCoord1dv not implemented");
					Delegates.pglMultiTexCoord1dv(target, p_v);
					CallLog("glMultiTexCoord1dv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, float s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1f != null, "pglMultiTexCoord1f not implemented");
			Delegates.pglMultiTexCoord1f(target, s);
			CallLog("glMultiTexCoord1f({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1fv != null, "pglMultiTexCoord1fv not implemented");
					Delegates.pglMultiTexCoord1fv(target, p_v);
					CallLog("glMultiTexCoord1fv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, Int32 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1i != null, "pglMultiTexCoord1i not implemented");
			Delegates.pglMultiTexCoord1i(target, s);
			CallLog("glMultiTexCoord1i({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1iv != null, "pglMultiTexCoord1iv not implemented");
					Delegates.pglMultiTexCoord1iv(target, p_v);
					CallLog("glMultiTexCoord1iv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, Int16 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1s != null, "pglMultiTexCoord1s not implemented");
			Delegates.pglMultiTexCoord1s(target, s);
			CallLog("glMultiTexCoord1s({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1sv != null, "pglMultiTexCoord1sv not implemented");
					Delegates.pglMultiTexCoord1sv(target, p_v);
					CallLog("glMultiTexCoord1sv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, double s, double t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2d != null, "pglMultiTexCoord2d not implemented");
			Delegates.pglMultiTexCoord2d(target, s, t);
			CallLog("glMultiTexCoord2d({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2dv != null, "pglMultiTexCoord2dv not implemented");
					Delegates.pglMultiTexCoord2dv(target, p_v);
					CallLog("glMultiTexCoord2dv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, float s, float t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2f != null, "pglMultiTexCoord2f not implemented");
			Delegates.pglMultiTexCoord2f(target, s, t);
			CallLog("glMultiTexCoord2f({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2fv != null, "pglMultiTexCoord2fv not implemented");
					Delegates.pglMultiTexCoord2fv(target, p_v);
					CallLog("glMultiTexCoord2fv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2i != null, "pglMultiTexCoord2i not implemented");
			Delegates.pglMultiTexCoord2i(target, s, t);
			CallLog("glMultiTexCoord2i({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2iv != null, "pglMultiTexCoord2iv not implemented");
					Delegates.pglMultiTexCoord2iv(target, p_v);
					CallLog("glMultiTexCoord2iv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2s != null, "pglMultiTexCoord2s not implemented");
			Delegates.pglMultiTexCoord2s(target, s, t);
			CallLog("glMultiTexCoord2s({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2sv != null, "pglMultiTexCoord2sv not implemented");
					Delegates.pglMultiTexCoord2sv(target, p_v);
					CallLog("glMultiTexCoord2sv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, double s, double t, double r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3d != null, "pglMultiTexCoord3d not implemented");
			Delegates.pglMultiTexCoord3d(target, s, t, r);
			CallLog("glMultiTexCoord3d({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3dv != null, "pglMultiTexCoord3dv not implemented");
					Delegates.pglMultiTexCoord3dv(target, p_v);
					CallLog("glMultiTexCoord3dv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, float s, float t, float r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3f != null, "pglMultiTexCoord3f not implemented");
			Delegates.pglMultiTexCoord3f(target, s, t, r);
			CallLog("glMultiTexCoord3f({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3fv != null, "pglMultiTexCoord3fv not implemented");
					Delegates.pglMultiTexCoord3fv(target, p_v);
					CallLog("glMultiTexCoord3fv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3i != null, "pglMultiTexCoord3i not implemented");
			Delegates.pglMultiTexCoord3i(target, s, t, r);
			CallLog("glMultiTexCoord3i({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3iv != null, "pglMultiTexCoord3iv not implemented");
					Delegates.pglMultiTexCoord3iv(target, p_v);
					CallLog("glMultiTexCoord3iv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3s != null, "pglMultiTexCoord3s not implemented");
			Delegates.pglMultiTexCoord3s(target, s, t, r);
			CallLog("glMultiTexCoord3s({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3sv != null, "pglMultiTexCoord3sv not implemented");
					Delegates.pglMultiTexCoord3sv(target, p_v);
					CallLog("glMultiTexCoord3sv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4d != null, "pglMultiTexCoord4d not implemented");
			Delegates.pglMultiTexCoord4d(target, s, t, r, q);
			CallLog("glMultiTexCoord4d({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4dv != null, "pglMultiTexCoord4dv not implemented");
					Delegates.pglMultiTexCoord4dv(target, p_v);
					CallLog("glMultiTexCoord4dv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4f != null, "pglMultiTexCoord4f not implemented");
			Delegates.pglMultiTexCoord4f(target, s, t, r, q);
			CallLog("glMultiTexCoord4f({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4fv != null, "pglMultiTexCoord4fv not implemented");
					Delegates.pglMultiTexCoord4fv(target, p_v);
					CallLog("glMultiTexCoord4fv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4i != null, "pglMultiTexCoord4i not implemented");
			Delegates.pglMultiTexCoord4i(target, s, t, r, q);
			CallLog("glMultiTexCoord4i({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4iv != null, "pglMultiTexCoord4iv not implemented");
					Delegates.pglMultiTexCoord4iv(target, p_v);
					CallLog("glMultiTexCoord4iv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4s != null, "pglMultiTexCoord4s not implemented");
			Delegates.pglMultiTexCoord4s(target, s, t, r, q);
			CallLog("glMultiTexCoord4s({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 
		/// to <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4sv != null, "pglMultiTexCoord4sv not implemented");
					Delegates.pglMultiTexCoord4sv(target, p_v);
					CallLog("glMultiTexCoord4sv({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixf != null, "pglLoadTransposeMatrixf not implemented");
					Delegates.pglLoadTransposeMatrixf(p_m);
					CallLog("glLoadTransposeMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixd != null, "pglLoadTransposeMatrixd not implemented");
					Delegates.pglLoadTransposeMatrixd(p_m);
					CallLog("glLoadTransposeMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixf != null, "pglMultTransposeMatrixf not implemented");
					Delegates.pglMultTransposeMatrixf(p_m);
					CallLog("glMultTransposeMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixd != null, "pglMultTransposeMatrixd not implemented");
					Delegates.pglMultTransposeMatrixd(p_m);
					CallLog("glMultTransposeMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
		}

	}

}
