
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int TEXTURE0 = 0x84C0;

		/// <summary>
		/// Value of GL_TEXTURE1 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE1_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int TEXTURE1 = 0x84C1;

		/// <summary>
		/// Value of GL_TEXTURE2 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE2_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE2 = 0x84C2;

		/// <summary>
		/// Value of GL_TEXTURE3 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE3_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE3 = 0x84C3;

		/// <summary>
		/// Value of GL_TEXTURE4 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE4_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE4 = 0x84C4;

		/// <summary>
		/// Value of GL_TEXTURE5 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE5_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE5 = 0x84C5;

		/// <summary>
		/// Value of GL_TEXTURE6 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE6_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE6 = 0x84C6;

		/// <summary>
		/// Value of GL_TEXTURE7 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE7_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE7 = 0x84C7;

		/// <summary>
		/// Value of GL_TEXTURE8 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE8_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE8 = 0x84C8;

		/// <summary>
		/// Value of GL_TEXTURE9 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE9_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE9 = 0x84C9;

		/// <summary>
		/// Value of GL_TEXTURE10 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE10_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE10 = 0x84CA;

		/// <summary>
		/// Value of GL_TEXTURE11 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE11_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE11 = 0x84CB;

		/// <summary>
		/// Value of GL_TEXTURE12 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE12_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE12 = 0x84CC;

		/// <summary>
		/// Value of GL_TEXTURE13 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE13_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE13 = 0x84CD;

		/// <summary>
		/// Value of GL_TEXTURE14 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE14_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE14 = 0x84CE;

		/// <summary>
		/// Value of GL_TEXTURE15 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE15_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE15 = 0x84CF;

		/// <summary>
		/// Value of GL_TEXTURE16 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE16_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE16 = 0x84D0;

		/// <summary>
		/// Value of GL_TEXTURE17 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE17_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE17 = 0x84D1;

		/// <summary>
		/// Value of GL_TEXTURE18 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE18_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE18 = 0x84D2;

		/// <summary>
		/// Value of GL_TEXTURE19 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE19_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE19 = 0x84D3;

		/// <summary>
		/// Value of GL_TEXTURE20 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE20_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE20 = 0x84D4;

		/// <summary>
		/// Value of GL_TEXTURE21 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE21_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE21 = 0x84D5;

		/// <summary>
		/// Value of GL_TEXTURE22 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE22_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE22 = 0x84D6;

		/// <summary>
		/// Value of GL_TEXTURE23 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE23_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE23 = 0x84D7;

		/// <summary>
		/// Value of GL_TEXTURE24 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE24_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE24 = 0x84D8;

		/// <summary>
		/// Value of GL_TEXTURE25 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE25_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE25 = 0x84D9;

		/// <summary>
		/// Value of GL_TEXTURE26 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE26_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE26 = 0x84DA;

		/// <summary>
		/// Value of GL_TEXTURE27 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE27_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE27 = 0x84DB;

		/// <summary>
		/// Value of GL_TEXTURE28 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE28_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE28 = 0x84DC;

		/// <summary>
		/// Value of GL_TEXTURE29 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE29_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE29 = 0x84DD;

		/// <summary>
		/// Value of GL_TEXTURE30 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE30_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE30 = 0x84DE;

		/// <summary>
		/// Value of GL_TEXTURE31 symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE31_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE31 = 0x84DF;

		/// <summary>
		/// Gl.Get: data returns a single value indicating the active multitexture unit. The initial value is Gl.TEXTURE0. See 
		/// Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_ACTIVE_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int ACTIVE_TEXTURE = 0x84E0;

		/// <summary>
		/// Gl.Enable: if enabled, use multiple fragment samples in computing the final color of a pixel. See Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_MULTISAMPLE_ARB")]
		[AliasOf("GL_MULTISAMPLE_EXT")]
		[AliasOf("GL_MULTISAMPLE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int MULTISAMPLE = 0x809D;

		/// <summary>
		/// Gl.Enable: if enabled, compute a temporary coverage value where each bit is determined by the alpha value at the 
		/// corresponding sample location. The temporary coverage value is then ANDed with the fragment coverage value.
		/// </summary>
		[AliasOf("GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

		/// <summary>
		/// Gl.Enable: if enabled, each sample alpha value is replaced by the maximum representable alpha value.
		/// </summary>
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_ARB")]
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_EXT")]
		[AliasOf("GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_ALPHA_TO_ONE = 0x809F;

		/// <summary>
		/// Gl.Enable: if enabled, the fragment's coverage is ANDed with the temporary coverage value. If Gl.SAMPLE_COVERAGE_INVERT 
		/// is set to Gl.TRUE, invert the coverage value. See Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_NV_multisample_coverage")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLES = 0x80A9;

		/// <summary>
		/// Gl.Get: data returns a single positive floating-point value indicating the current sample coverage value. See 
		/// Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_VALUE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_COVERAGE_VALUE = 0x80AA;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating if the temporary coverage value should be inverted. See 
		/// Gl.SampleCoverage.
		/// </summary>
		[AliasOf("GL_SAMPLE_COVERAGE_INVERT_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
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
		[AliasOf("GL_TEXTURE_CUBE_MAP_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP = 0x8513;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_CUBE_MAP. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_EXT")]
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
		[AliasOf("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the GL can handle. 
		/// The value must be at least 1024. Use Gl.PROXY_TEXTURE_CUBE_MAP to determine if a texture is too large. See 
		/// Gl.TexImage2D.
		/// </summary>
		[AliasOf("GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
		[AliasOf("GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT")]
		[AliasOf("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_RGB = 0x84ED;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSION_HINT = 0x84EF;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single integer value, the number of unsigned bytes of the compressed texture 
		/// image that would be returned from Gl.GetCompressedTexImage.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single boolean value indicating if the texture image is stored in a compressed 
		/// internal format. The initiali value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPRESSED_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int TEXTURE_COMPRESSED = 0x86A1;

		/// <summary>
		/// Gl.Get: data returns a single integer value indicating the number of available compressed texture formats. The minimum 
		/// value is 4. See Gl.CompressedTexImage2D.
		/// </summary>
		[AliasOf("GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

		/// <summary>
		/// Gl.Get: data returns a list of symbolic constants of length Gl.NUM_COMPRESSED_TEXTURE_FORMATS indicating which 
		/// compressed texture formats are available. See Gl.CompressedTexImage2D.
		/// </summary>
		[AliasOf("GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_TO_BORDER_ARB")]
		[AliasOf("GL_CLAMP_TO_BORDER_EXT")]
		[AliasOf("GL_CLAMP_TO_BORDER_NV")]
		[AliasOf("GL_CLAMP_TO_BORDER_SGIS")]
		[AliasOf("GL_CLAMP_TO_BORDER_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_border_clamp")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_border_clamp")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public const int CLAMP_TO_BORDER = 0x812D;

		/// <summary>
		/// Gl.Get: params returns a single integer value indicating the current client active multitexture unit. The initial value 
		/// is Gl.TEXTURE0. See Gl.ClientActiveTexture.
		/// </summary>
		[AliasOf("GL_CLIENT_ACTIVE_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multitexture")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multitexture")]
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
		[RequiredByFeature("GL_ARB_transpose_matrix")]
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
		[RequiredByFeature("GL_ARB_transpose_matrix")]
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
		[RequiredByFeature("GL_ARB_transpose_matrix")]
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
		[RequiredByFeature("GL_ARB_transpose_matrix")]
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
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_3DFX_multisample")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
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
		[AliasOf("GL_NORMAL_MAP_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_NV_texgen_reflection")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
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
		[AliasOf("GL_REFLECTION_MAP_OES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_NV_texgen_reflection")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
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
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
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
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_dot3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOT3_RGB = 0x86AE;

		/// <summary>
		/// Value of GL_DOT3_RGBA symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_DOT3_RGBA_ARB")]
		[AliasOf("GL_DOT3_RGBA_IMG")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_texture_env_dot3")]
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
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
		/// least 80. <paramref name="texture"/> must be one of Gl.TEXTUREi, where i ranges from zero to the value of 
		/// Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is Gl.TEXTURE0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="texture"/> is not one of Gl.TEXTUREi, where i ranges from zero to the 
		/// value of Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one.
		/// </exception>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
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
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glActiveTextureARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void ActiveTexture(Int32 texture)
		{
			Debug.Assert(Delegates.pglActiveTexture != null, "pglActiveTexture not implemented");
			Delegates.pglActiveTexture(texture);
			LogFunction("glActiveTexture({0})", LogEnumName(texture));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify multisample coverage parameters
		/// </summary>
		/// <param name="value">
		/// Specify a single floating-point sample coverage value. The value is clamped to the range 01. The initial value is 1.0.
		/// </param>
		/// <param name="invert">
		/// Specify a single boolean value representing if the coverage masks should be inverted. Gl.TRUE and Gl.FALSE are accepted. 
		/// The initial value is Gl.FALSE.
		/// </param>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glSampleCoverageARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_multisample")]
		public static void SampleCoverage(float value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoverage != null, "pglSampleCoverage not implemented");
			Delegates.pglSampleCoverage(value, invert);
			LogFunction("glSampleCoverage({0}, {1})", value, invert);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_3D, Gl.PROXY_TEXTURE_3D, Gl.TEXTURE_2D_ARRAY or 
		/// Gl.PROXY_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// deep.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage3DARB")]
		[AliasOf("glCompressedTexImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void CompressedTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage3D != null, "pglCompressedTexImage3D not implemented");
			Delegates.pglCompressedTexImage3D((Int32)target, level, internalformat, width, height, depth, border, imageSize, data);
			LogFunction("glCompressedTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", target, level, LogEnumName(internalformat), width, height, depth, border, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_3D, Gl.PROXY_TEXTURE_3D, Gl.TEXTURE_2D_ARRAY or 
		/// Gl.PROXY_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image. All implementations support 3D texture images that are at least 16 texels 
		/// deep.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage3DARB")]
		[AliasOf("glCompressedTexImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void CompressedTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object data)
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
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.PROXY_TEXTURE_1D_ARRAY, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at 
		/// least 16384 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are 
		/// at least 16384 texels high.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the specific compressed internal 
		/// formats: Gl.COMPRESSED_RED_RGTC1, Gl.COMPRESSED_SIGNED_RED_RGTC1, Gl.COMPRESSED_RG_RGTC2, Gl.COMPRESSED_SIGNED_RG_RGTC2. 
		/// Gl.COMPRESSED_RGBA_BPTC_UNORM, Gl.COMPRESSED_SRGB_ALPHA_BPTC_UNORM, Gl.COMPRESSED_RGB_BPTC_SIGNED_FLOAT, 
		/// Gl.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT, Gl.COMPRESSED_RGB8_ETC2, Gl.COMPRESSED_SRGB8_ETC2, 
		/// Gl.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2, Gl.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2, Gl.COMPRESSED_RGBA8_ETC2_EAC, 
		/// Gl.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC, Gl.COMPRESSED_R11_EAC, Gl.COMPRESSED_SIGNED_R11_EAC, Gl.COMPRESSED_RG11_EAC, or 
		/// Gl.COMPRESSED_SIGNED_RG11_EAC.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage2DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage2D != null, "pglCompressedTexImage2D not implemented");
			Delegates.pglCompressedTexImage2D((Int32)target, level, internalformat, width, height, border, imageSize, data);
			LogFunction("glCompressedTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", target, level, LogEnumName(internalformat), width, height, border, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.PROXY_TEXTURE_1D_ARRAY, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at 
		/// least 16384 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are 
		/// at least 16384 texels high.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the specific compressed internal 
		/// formats: Gl.COMPRESSED_RED_RGTC1, Gl.COMPRESSED_SIGNED_RED_RGTC1, Gl.COMPRESSED_RG_RGTC2, Gl.COMPRESSED_SIGNED_RG_RGTC2. 
		/// Gl.COMPRESSED_RGBA_BPTC_UNORM, Gl.COMPRESSED_SRGB_ALPHA_BPTC_UNORM, Gl.COMPRESSED_RGB_BPTC_SIGNED_FLOAT, 
		/// Gl.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT, Gl.COMPRESSED_RGB8_ETC2, Gl.COMPRESSED_SRGB8_ETC2, 
		/// Gl.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2, Gl.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2, Gl.COMPRESSED_RGBA8_ETC2_EAC, 
		/// Gl.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC, Gl.COMPRESSED_R11_EAC, Gl.COMPRESSED_SIGNED_R11_EAC, Gl.COMPRESSED_RG11_EAC, or 
		/// Gl.COMPRESSED_SIGNED_RG11_EAC.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage2DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object data)
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
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support texture images that are at least 64 texels wide. 
		/// The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a supported specific compressed internal 
		/// formats, or is one of the generic compressed internal formats: Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, 
		/// Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
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
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage1DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage1D != null, "pglCompressedTexImage1D not implemented");
			Delegates.pglCompressedTexImage1D((Int32)target, level, internalformat, width, border, imageSize, data);
			LogFunction("glCompressedTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", target, level, LogEnumName(internalformat), width, border, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. All implementations support texture images that are at least 64 texels wide. 
		/// The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// This value must be 0.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a supported specific compressed internal 
		/// formats, or is one of the generic compressed internal formats: Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, 
		/// Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
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
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexImage1DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, Object data)
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
		/// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage3D function. Must be Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage3D if <paramref name="target"/> is not Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage3D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage3DARB")]
		[AliasOf("glCompressedTexSubImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void CompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage3D != null, "pglCompressedTexSubImage3D not implemented");
			Delegates.pglCompressedTexSubImage3D((Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, imageSize, data);
			LogFunction("glCompressedTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage3D function. Must be Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage3D if <paramref name="target"/> is not Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage3D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage3DARB")]
		[AliasOf("glCompressedTexSubImage3DOES")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
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
		/// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage2D function. Must be Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage2D if <paramref name="target"/> is Gl.TEXTURE_RECTANGLE or 
		/// Gl.PROXY_TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if the effective target is Gl.TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage2DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage2D != null, "pglCompressedTexSubImage2D not implemented");
			Delegates.pglCompressedTexSubImage2D((Int32)target, level, xoffset, yoffset, width, height, (Int32)format, imageSize, data);
			LogFunction("glCompressedTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", target, level, xoffset, yoffset, width, height, format, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage2D function. Must be Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage2D if <paramref name="target"/> is Gl.TEXTURE_RECTANGLE or 
		/// Gl.PROXY_TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if the effective target is Gl.TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage2DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		/// Specifies the target, to which the texture is bound, for Gl.CompressedTexSubImage1D function. Must be Gl.TEXTURE_1D.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// GL_INVALID_OPERATION is generated by Gl.CompressedTextureSubImage1D function if texture is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage1DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void CompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage1D != null, "pglCompressedTexSubImage1D not implemented");
			Delegates.pglCompressedTexSubImage1D((Int32)target, level, xoffset, width, (Int32)format, imageSize, data);
			LogFunction("glCompressedTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", target, level, xoffset, width, format, imageSize, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for Gl.CompressedTexSubImage1D function. Must be Gl.TEXTURE_1D.
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
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
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
		/// GL_INVALID_OPERATION is generated by Gl.CompressedTextureSubImage1D function if texture is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[AliasOf("glCompressedTexSubImage1DARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		/// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage functions. 
		/// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glGetCompressedTexImageARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		public static void GetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedTexImage != null, "pglGetCompressedTexImage not implemented");
			Delegates.pglGetCompressedTexImage((Int32)target, level, img);
			LogFunction("glGetCompressedTexImage({0}, {1}, 0x{2})", target, level, img.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage functions. 
		/// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glGetCompressedTexImageARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
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
		/// least two. <paramref name="texture"/> must be one of Gl.TEXTUREi, where i ranges from 0 to the value of 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is Gl.TEXTURE0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="texture"/> is not one of Gl.TEXTUREi, where i ranges from 0 to the value 
		/// of Gl.MAX_TEXTURE_COORDS - 1.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		[AliasOf("glClientActiveTextureARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClientActiveTexture(Int32 texture)
		{
			Debug.Assert(Delegates.pglClientActiveTexture != null, "pglClientActiveTexture not implemented");
			Delegates.pglClientActiveTexture(texture);
			LogFunction("glClientActiveTexture({0})", LogEnumName(texture));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1dARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, double s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1d != null, "pglMultiTexCoord1d not implemented");
			Delegates.pglMultiTexCoord1d(target, s);
			LogFunction("glMultiTexCoord1d({0}, {1})", LogEnumName(target), s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1dvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1dv != null, "pglMultiTexCoord1dv not implemented");
					Delegates.pglMultiTexCoord1dv(target, p_v);
					LogFunction("glMultiTexCoord1dv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1fARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, float s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1f != null, "pglMultiTexCoord1f not implemented");
			Delegates.pglMultiTexCoord1f(target, s);
			LogFunction("glMultiTexCoord1f({0}, {1})", LogEnumName(target), s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1fvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1fv != null, "pglMultiTexCoord1fv not implemented");
					Delegates.pglMultiTexCoord1fv(target, p_v);
					LogFunction("glMultiTexCoord1fv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1iARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, Int32 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1i != null, "pglMultiTexCoord1i not implemented");
			Delegates.pglMultiTexCoord1i(target, s);
			LogFunction("glMultiTexCoord1i({0}, {1})", LogEnumName(target), s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1ivARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1iv != null, "pglMultiTexCoord1iv not implemented");
					Delegates.pglMultiTexCoord1iv(target, p_v);
					LogFunction("glMultiTexCoord1iv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1sARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, Int16 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1s != null, "pglMultiTexCoord1s not implemented");
			Delegates.pglMultiTexCoord1s(target, s);
			LogFunction("glMultiTexCoord1s({0}, {1})", LogEnumName(target), s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord1svARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord1(Int32 target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1sv != null, "pglMultiTexCoord1sv not implemented");
					Delegates.pglMultiTexCoord1sv(target, p_v);
					LogFunction("glMultiTexCoord1sv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2dARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, double s, double t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2d != null, "pglMultiTexCoord2d not implemented");
			Delegates.pglMultiTexCoord2d(target, s, t);
			LogFunction("glMultiTexCoord2d({0}, {1}, {2})", LogEnumName(target), s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2dvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2dv != null, "pglMultiTexCoord2dv not implemented");
					Delegates.pglMultiTexCoord2dv(target, p_v);
					LogFunction("glMultiTexCoord2dv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2fARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, float s, float t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2f != null, "pglMultiTexCoord2f not implemented");
			Delegates.pglMultiTexCoord2f(target, s, t);
			LogFunction("glMultiTexCoord2f({0}, {1}, {2})", LogEnumName(target), s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2fvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2fv != null, "pglMultiTexCoord2fv not implemented");
					Delegates.pglMultiTexCoord2fv(target, p_v);
					LogFunction("glMultiTexCoord2fv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2iARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2i != null, "pglMultiTexCoord2i not implemented");
			Delegates.pglMultiTexCoord2i(target, s, t);
			LogFunction("glMultiTexCoord2i({0}, {1}, {2})", LogEnumName(target), s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2ivARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2iv != null, "pglMultiTexCoord2iv not implemented");
					Delegates.pglMultiTexCoord2iv(target, p_v);
					LogFunction("glMultiTexCoord2iv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2sARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2s != null, "pglMultiTexCoord2s not implemented");
			Delegates.pglMultiTexCoord2s(target, s, t);
			LogFunction("glMultiTexCoord2s({0}, {1}, {2})", LogEnumName(target), s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord2svARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord2(Int32 target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2sv != null, "pglMultiTexCoord2sv not implemented");
					Delegates.pglMultiTexCoord2sv(target, p_v);
					LogFunction("glMultiTexCoord2sv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3dARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, double s, double t, double r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3d != null, "pglMultiTexCoord3d not implemented");
			Delegates.pglMultiTexCoord3d(target, s, t, r);
			LogFunction("glMultiTexCoord3d({0}, {1}, {2}, {3})", LogEnumName(target), s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3dvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3dv != null, "pglMultiTexCoord3dv not implemented");
					Delegates.pglMultiTexCoord3dv(target, p_v);
					LogFunction("glMultiTexCoord3dv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3fARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, float s, float t, float r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3f != null, "pglMultiTexCoord3f not implemented");
			Delegates.pglMultiTexCoord3f(target, s, t, r);
			LogFunction("glMultiTexCoord3f({0}, {1}, {2}, {3})", LogEnumName(target), s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3fvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3fv != null, "pglMultiTexCoord3fv not implemented");
					Delegates.pglMultiTexCoord3fv(target, p_v);
					LogFunction("glMultiTexCoord3fv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3iARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3i != null, "pglMultiTexCoord3i not implemented");
			Delegates.pglMultiTexCoord3i(target, s, t, r);
			LogFunction("glMultiTexCoord3i({0}, {1}, {2}, {3})", LogEnumName(target), s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3ivARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3iv != null, "pglMultiTexCoord3iv not implemented");
					Delegates.pglMultiTexCoord3iv(target, p_v);
					LogFunction("glMultiTexCoord3iv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3sARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3s != null, "pglMultiTexCoord3s not implemented");
			Delegates.pglMultiTexCoord3s(target, s, t, r);
			LogFunction("glMultiTexCoord3s({0}, {1}, {2}, {3})", LogEnumName(target), s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord3svARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord3(Int32 target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3sv != null, "pglMultiTexCoord3sv not implemented");
					Delegates.pglMultiTexCoord3sv(target, p_v);
					LogFunction("glMultiTexCoord3sv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4dARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4d != null, "pglMultiTexCoord4d not implemented");
			Delegates.pglMultiTexCoord4d(target, s, t, r, q);
			LogFunction("glMultiTexCoord4d({0}, {1}, {2}, {3}, {4})", LogEnumName(target), s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4dvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4dv != null, "pglMultiTexCoord4dv not implemented");
					Delegates.pglMultiTexCoord4dv(target, p_v);
					LogFunction("glMultiTexCoord4dv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4fARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4f != null, "pglMultiTexCoord4f not implemented");
			Delegates.pglMultiTexCoord4f(target, s, t, r, q);
			LogFunction("glMultiTexCoord4f({0}, {1}, {2}, {3}, {4})", LogEnumName(target), s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4fvARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4fv != null, "pglMultiTexCoord4fv not implemented");
					Delegates.pglMultiTexCoord4fv(target, p_v);
					LogFunction("glMultiTexCoord4fv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4iARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4i != null, "pglMultiTexCoord4i not implemented");
			Delegates.pglMultiTexCoord4i(target, s, t, r, q);
			LogFunction("glMultiTexCoord4i({0}, {1}, {2}, {3}, {4})", LogEnumName(target), s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4ivARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4iv != null, "pglMultiTexCoord4iv not implemented");
					Delegates.pglMultiTexCoord4iv(target, p_v);
					LogFunction("glMultiTexCoord4iv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
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
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4sARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4s != null, "pglMultiTexCoord4s not implemented");
			Delegates.pglMultiTexCoord4s(target, s, t, r, q);
			LogFunction("glMultiTexCoord4s({0}, {1}, {2}, {3}, {4})", LogEnumName(target), s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to 
		/// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glMultiTexCoord4svARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultiTexCoord4(Int32 target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4sv != null, "pglMultiTexCoord4sv not implemented");
					Delegates.pglMultiTexCoord4sv(target, p_v);
					LogFunction("glMultiTexCoord4sv({0}, {1})", LogEnumName(target), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadTransposeMatrix is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[AliasOf("glLoadTransposeMatrixfARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixf != null, "pglLoadTransposeMatrixf not implemented");
					Delegates.pglLoadTransposeMatrixf(p_m);
					LogFunction("glLoadTransposeMatrixf({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadTransposeMatrix is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[AliasOf("glLoadTransposeMatrixdARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixd != null, "pglLoadTransposeMatrixd not implemented");
					Delegates.pglLoadTransposeMatrixd(p_m);
					LogFunction("glLoadTransposeMatrixd({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultTransposeMatrix is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[AliasOf("glMultTransposeMatrixfARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixf != null, "pglMultTransposeMatrixf not implemented");
					Delegates.pglMultTransposeMatrixf(p_m);
					LogFunction("glMultTransposeMatrixf({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultTransposeMatrix is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[AliasOf("glMultTransposeMatrixdARB")]
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixd != null, "pglMultTransposeMatrixd not implemented");
					Delegates.pglMultTransposeMatrixd(p_m);
					LogFunction("glMultTransposeMatrixd({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
