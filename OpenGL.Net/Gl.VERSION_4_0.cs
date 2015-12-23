
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Gl.Enable: if enabled, the active fragment shader is run once for each covered sample, or at fraction of this rate as 
		/// determined by the current value of Gl.MIN_SAMPLE_SHADING_VALUE. See Gl.MinSampleShading.
		/// </summary>
		[AliasOf("GL_SAMPLE_SHADING_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_sample_shading")]
		public const int SAMPLE_SHADING = 0x8C36;

		/// <summary>
		/// Value of GL_MIN_SAMPLE_SHADING_VALUE symbol.
		/// </summary>
		[AliasOf("GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_sample_shading")]
		public const int MIN_SAMPLE_SHADING_VALUE = 0x8C37;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
		[AliasOf("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_gather")]
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
		[AliasOf("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_gather")]
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int TEXTURE_CUBE_MAP_ARRAY = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int SAMPLER_CUBE_MAP_ARRAY = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array")]
		public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public const int DRAW_INDIRECT_BUFFER = 0x8F3F;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public const int DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		[RequiredByFeature("GL_ARB_pipeline_statistics_query")]
		public const int GEOMETRY_SHADER_INVOCATIONS = 0x887F;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		public const int MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;

		/// <summary>
		/// Value of GL_MIN_FRAGMENT_INTERPOLATION_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_INTERPOLATION_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;

		/// <summary>
		/// Value of GL_FRAGMENT_INTERPOLATION_OFFSET_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		public const int FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;

		/// <summary>
		/// Value of GL_MAX_VERTEX_STREAMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public const int MAX_VERTEX_STREAMS = 0x8E71;

		/// <summary>
		/// Value of GL_DOUBLE_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_VEC2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC2 = 0x8FFC;

		/// <summary>
		/// Value of GL_DOUBLE_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_VEC3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC3 = 0x8FFD;

		/// <summary>
		/// Value of GL_DOUBLE_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_VEC4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC4 = 0x8FFE;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2 = 0x8F46;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3 = 0x8F47;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4 = 0x8F48;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2x3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x3 = 0x8F49;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2x4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x4 = 0x8F4A;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3x2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x2 = 0x8F4B;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3x4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x4 = 0x8F4C;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4x2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x2 = 0x8F4D;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4x3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x3 = 0x8F4E;

		/// <summary>
		/// Value of GL_ACTIVE_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int ACTIVE_SUBROUTINES = 0x8DE5;

		/// <summary>
		/// Value of GL_ACTIVE_SUBROUTINE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;

		/// <summary>
		/// Value of GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;

		/// <summary>
		/// Value of GL_ACTIVE_SUBROUTINE_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;

		/// <summary>
		/// Value of GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;

		/// <summary>
		/// Value of GL_MAX_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int MAX_SUBROUTINES = 0x8DE7;

		/// <summary>
		/// Value of GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;

		/// <summary>
		/// Value of GL_NUM_COMPATIBLE_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;

		/// <summary>
		/// Value of GL_COMPATIBLE_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public const int COMPATIBLE_SUBROUTINES = 0x8E4B;

		/// <summary>
		/// Value of GL_PATCHES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int PATCHES = 0x000E;

		/// <summary>
		/// Value of GL_PATCH_VERTICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int PATCH_VERTICES = 0x8E72;

		/// <summary>
		/// Value of GL_PATCH_DEFAULT_INNER_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int PATCH_DEFAULT_INNER_LEVEL = 0x8E73;

		/// <summary>
		/// Value of GL_PATCH_DEFAULT_OUTER_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;

		/// <summary>
		/// Value of GL_TESS_CONTROL_OUTPUT_VERTICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;

		/// <summary>
		/// Value of GL_TESS_GEN_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_GEN_MODE = 0x8E76;

		/// <summary>
		/// Value of GL_TESS_GEN_SPACING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_GEN_SPACING = 0x8E77;

		/// <summary>
		/// Value of GL_TESS_GEN_VERTEX_ORDER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_GEN_VERTEX_ORDER = 0x8E78;

		/// <summary>
		/// Value of GL_TESS_GEN_POINT_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_GEN_POINT_MODE = 0x8E79;

		/// <summary>
		/// Value of GL_ISOLINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int ISOLINES = 0x8E7A;

		/// <summary>
		/// Value of GL_FRACTIONAL_ODD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int FRACTIONAL_ODD = 0x8E7B;

		/// <summary>
		/// Value of GL_FRACTIONAL_EVEN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int FRACTIONAL_EVEN = 0x8E7C;

		/// <summary>
		/// Value of GL_MAX_PATCH_VERTICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_PATCH_VERTICES = 0x8E7D;

		/// <summary>
		/// Value of GL_MAX_TESS_GEN_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_GEN_LEVEL = 0x8E7E;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;

		/// <summary>
		/// Value of GL_MAX_TESS_PATCH_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_PATCH_COMPONENTS = 0x8E84;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_INPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_EVALUATION_SHADER = 0x8E87;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TESS_CONTROL_SHADER = 0x8E88;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		[RequiredByFeature("GL_EXT_debug_label")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK = 0x8E22;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BINDING symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BINDING = 0x8E25;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public const int MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;

		/// <summary>
		/// specifies minimum rate at which sample shaing takes place
		/// </summary>
		/// <param name="value">
		/// Specifies the rate at which samples are shaded within each covered pixel.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// None.
		/// </exception>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void MinSampleShading(float value)
		{
			Debug.Assert(Delegates.pglMinSampleShading != null, "pglMinSampleShading not implemented");
			Delegates.pglMinSampleShading(value);
			CallLog("glMinSampleShading({0})", value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the equation used for both the RGB blend equation and the Alpha blend equation
		/// </summary>
		/// <param name="buf">
		/// for Gl.BlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
		/// </param>
		/// <param name="mode">
		/// specifies how source and destination colors are combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, 
		/// Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, 
		/// Gl.FUNC_REVERSE_SUBTRACT, Gl.MAX, or Gl.MIN.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.BlendEquationi if <paramref name="buf"/> is greater than or equal to the value of 
		/// Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendEquation(UInt32 buf, Int32 mode)
		{
			Debug.Assert(Delegates.pglBlendEquationi != null, "pglBlendEquationi not implemented");
			Delegates.pglBlendEquationi(buf, mode);
			CallLog("glBlendEquationi({0}, {1})", buf, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the RGB blend equation and the alpha blend equation separately
		/// </summary>
		/// <param name="buf">
		/// for Gl.BlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations.
		/// </param>
		/// <param name="modeRGB">
		/// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are 
		/// combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <param name="modeAlpha">
		/// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must 
		/// be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="modeRGB"/> or <paramref name="modeAlpha"/> is not one of 
		/// Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MAX, or Gl.MIN.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.BlendEquationSeparatei if <paramref name="buf"/> is greater than or equal to the 
		/// value of Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendEquationSeparatei(UInt32 buf, Int32 modeRGB, Int32 modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparatei != null, "pglBlendEquationSeparatei not implemented");
			Delegates.pglBlendEquationSeparatei(buf, modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparatei({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="buf">
		/// For Gl.BlendFunci, specifies the index of the draw buffer for which to set the blend function.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="sfactor"/> or <paramref name="dfactor"/> is not an accepted 
		/// value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.BlendFunci if <paramref name="buf"/> is greater than or equal to the value of 
		/// Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendFunci(UInt32 buf, Int32 src, Int32 dst)
		{
			Debug.Assert(Delegates.pglBlendFunci != null, "pglBlendFunci not implemented");
			Delegates.pglBlendFunci(buf, src, dst);
			CallLog("glBlendFunci({0}, {1}, {2})", buf, src, dst);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify pixel arithmetic for RGB and alpha components separately
		/// </summary>
		/// <param name="buf">
		/// For Gl.BlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions.
		/// </param>
		/// <param name="srcRGB">
		/// Specifies how the red, green, and blue blending factors are computed. The initial value is Gl.ONE.
		/// </param>
		/// <param name="dstRGB">
		/// Specifies how the red, green, and blue destination blending factors are computed. The initial value is Gl.ZERO.
		/// </param>
		/// <param name="srcAlpha">
		/// Specified how the alpha source blending factor is computed. The initial value is Gl.ONE.
		/// </param>
		/// <param name="dstAlpha">
		/// Specified how the alpha destination blending factor is computed. The initial value is Gl.ZERO.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="srcRGB"/> or <paramref name="dstRGB"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.BlendFuncSeparatei if <paramref name="buf"/> is greater than or equal to the value 
		/// of Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendFuncSeparatei(UInt32 buf, Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparatei != null, "pglBlendFuncSeparatei not implemented");
			Delegates.pglBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparatei({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		/// Gl.DRAW_INDIRECT_BUFFER binding and the buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawArraysIndirect != null, "pglDrawArraysIndirect not implemented");
			Delegates.pglDrawArraysIndirect((Int32)mode, indirect);
			CallLog("glDrawArraysIndirect({0}, 0x{1})", mode, indirect.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		/// Gl.DRAW_INDIRECT_BUFFER binding and the buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawArraysIndirect(PrimitiveType mode, Object indirect)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				DrawArraysIndirect(mode, pin_indirect.AddrOfPinnedObject());
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// render indexed primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the Gl.ELEMENT_ARRAY_BUFFER binding.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no buffer is bound to the Gl.ELEMENT_ARRAY_BUFFER binding, or if such a buffer's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		/// Gl.DRAW_INDIRECT_BUFFER binding and the buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawElementsIndirect(PrimitiveType mode, Int32 type, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawElementsIndirect != null, "pglDrawElementsIndirect not implemented");
			Delegates.pglDrawElementsIndirect((Int32)mode, type, indirect);
			CallLog("glDrawElementsIndirect({0}, {1}, 0x{2})", mode, type, indirect.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render indexed primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the Gl.ELEMENT_ARRAY_BUFFER binding.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no buffer is bound to the Gl.ELEMENT_ARRAY_BUFFER binding, or if such a buffer's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		/// Gl.DRAW_INDIRECT_BUFFER binding and the buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawElementsIndirect(PrimitiveType mode, Int32 type, Object indirect)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				DrawElementsIndirect(mode, type, pin_indirect.AddrOfPinnedObject());
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// Binding for glUniform1d.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform1(Int32 location, double x)
		{
			Debug.Assert(Delegates.pglUniform1d != null, "pglUniform1d not implemented");
			Delegates.pglUniform1d(location, x);
			CallLog("glUniform1d({0}, {1})", location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2d.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform2(Int32 location, double x, double y)
		{
			Debug.Assert(Delegates.pglUniform2d != null, "pglUniform2d not implemented");
			Delegates.pglUniform2d(location, x, y);
			CallLog("glUniform2d({0}, {1}, {2})", location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3d.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform3(Int32 location, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglUniform3d != null, "pglUniform3d not implemented");
			Delegates.pglUniform3d(location, x, y, z);
			CallLog("glUniform3d({0}, {1}, {2}, {3})", location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4d.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform4(Int32 location, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglUniform4d != null, "pglUniform4d not implemented");
			Delegates.pglUniform4d(location, x, y, z, w);
			CallLog("glUniform4d({0}, {1}, {2}, {3}, {4})", location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform1(Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1dv != null, "pglUniform1dv not implemented");
					Delegates.pglUniform1dv(location, count, p_value);
					CallLog("glUniform1dv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform2(Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2dv != null, "pglUniform2dv not implemented");
					Delegates.pglUniform2dv(location, count, p_value);
					CallLog("glUniform2dv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform3(Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3dv != null, "pglUniform3dv not implemented");
					Delegates.pglUniform3dv(location, count, p_value);
					CallLog("glUniform3dv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void Uniform4(Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4dv != null, "pglUniform4dv not implemented");
					Delegates.pglUniform4dv(location, count, p_value);
					CallLog("glUniform4dv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix2dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix2(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2dv != null, "pglUniformMatrix2dv not implemented");
					Delegates.pglUniformMatrix2dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix3dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix3(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3dv != null, "pglUniformMatrix3dv not implemented");
					Delegates.pglUniformMatrix3dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix4dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix4(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4dv != null, "pglUniformMatrix4dv not implemented");
					Delegates.pglUniformMatrix4dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix2x3dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix2x3(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x3dv != null, "pglUniformMatrix2x3dv not implemented");
					Delegates.pglUniformMatrix2x3dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x3dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix2x4dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix2x4(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x4dv != null, "pglUniformMatrix2x4dv not implemented");
					Delegates.pglUniformMatrix2x4dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x4dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix3x2dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix3x2(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x2dv != null, "pglUniformMatrix3x2dv not implemented");
					Delegates.pglUniformMatrix3x2dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x2dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix3x4dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix3x4(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x4dv != null, "pglUniformMatrix3x4dv not implemented");
					Delegates.pglUniformMatrix3x4dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x4dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix4x2dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix4x2(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x2dv != null, "pglUniformMatrix4x2dv not implemented");
					Delegates.pglUniformMatrix4x2dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x2dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformMatrix4x3dv.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void UniformMatrix4x3(Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x3dv != null, "pglUniformMatrix4x3dv not implemented");
					Delegates.pglUniformMatrix4x3dv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x3dv({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformdv != null, "pglGetUniformdv not implemented");
					Delegates.pglGetUniformdv(program, location, p_params);
					CallLog("glGetUniformdv({0}, {1}, {2})", program, location, @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the location of a subroutine uniform of a given shader stage within a program
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> or <paramref name="pname"/> is not one of the accepted 
		/// values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static Int32 GetSubroutineUniformLocation(UInt32 program, Int32 shadertype, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetSubroutineUniformLocation != null, "pglGetSubroutineUniformLocation not implemented");
			retValue = Delegates.pglGetSubroutineUniformLocation(program, shadertype, name);
			CallLog("glGetSubroutineUniformLocation({0}, {1}, {2}) = {3}", program, shadertype, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// retrieve the index of a subroutine uniform of a given shader stage within a program
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> or <paramref name="pname"/> is not one of the accepted 
		/// values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static UInt32 GetSubroutineIndex(UInt32 program, Int32 shadertype, String name)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetSubroutineIndex != null, "pglGetSubroutineIndex not implemented");
			retValue = Delegates.pglGetSubroutineIndex(program, shadertype, name);
			CallLog("glGetSubroutineIndex({0}, {1}, {2}) = {3}", program, shadertype, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// query a property of an active shader subroutine uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing the subroutine.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader subroutine uniform to query. <paramref name="pname"/> must be 
		/// Gl.NUM_COMPATIBLE_SUBROUTINES, Gl.COMPATIBLE_SUBROUTINES, Gl.UNIFORM_SIZE or Gl.UNIFORM_NAME_LENGTH.
		/// </param>
		/// <param name="values">
		/// Specifies the address of a into which the queried value or values will be placed.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> or <paramref name="pname"/> is not one of the accepted 
		/// values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_SUBROUTINES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetProgramStage"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineUniform(UInt32 program, Int32 shadertype, UInt32 index, Int32 pname, [Out] Int32[] values)
		{
			unsafe {
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineUniformiv != null, "pglGetActiveSubroutineUniformiv not implemented");
					Delegates.pglGetActiveSubroutineUniformiv(program, shadertype, index, pname, p_values);
					CallLog("glGetActiveSubroutineUniformiv({0}, {1}, {2}, {3}, {4})", program, shadertype, index, pname, values);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the name of an active shader subroutine uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing the subroutine.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform.
		/// </param>
		/// <param name="bufsize">
		/// Specifies the size of the buffer whose address is given in <paramref name="name"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable into which is written the number of characters copied into <paramref name="name"/>.
		/// </param>
		/// <param name="name">
		/// Specifies the address of a buffer that will receive the name of the specified shader subroutine uniform.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> or <paramref name="pname"/> is not one of the accepted 
		/// values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_SUBROUTINES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetProgramStage"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineUniformName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineUniformName != null, "pglGetActiveSubroutineUniformName not implemented");
					Delegates.pglGetActiveSubroutineUniformName(program, shadertype, index, bufsize, p_length, name);
					CallLog("glGetActiveSubroutineUniformName({0}, {1}, {2}, {3}, {4}, {5})", program, shadertype, index, bufsize, length, name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the name of an active shader subroutine
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing the subroutine.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query the subroutine name.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform.
		/// </param>
		/// <param name="bufsize">
		/// Specifies the size of the buffer whose address is given in <paramref name="name"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable which is to receive the length of the shader subroutine uniform name.
		/// </param>
		/// <param name="name">
		/// Specifies the address of an array into which the name of the shader subroutine uniform will be written.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_SUBROUTINES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetProgramStage"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineName(UInt32 program, Int32 shadertype, UInt32 index, Int32 bufsize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineName != null, "pglGetActiveSubroutineName not implemented");
					Delegates.pglGetActiveSubroutineName(program, shadertype, index, bufsize, p_length, name);
					CallLog("glGetActiveSubroutineName({0}, {1}, {2}, {3}, {4}, {5})", program, shadertype, index, bufsize, length, name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load active subroutine uniforms
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="indices">
		/// Specifies the address of an array holding the indices to load into the shader subroutine variables.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no program object is current.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is not equal to the value of 
		/// Gl.ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS for the shader stage <paramref name="shadertype"/> of the current program.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any value in <paramref name="indices"/> is geater than or equal to the value of 
		/// Gl.ACTIVE_SUBROUTINES for the shader stage <paramref name="shadertype"/> of the current program.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> is not one of the accepted values.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetProgramStage"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void UniformSubroutines(Int32 shadertype, UInt32[] indices)
		{
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglUniformSubroutinesuiv != null, "pglUniformSubroutinesuiv not implemented");
					Delegates.pglUniformSubroutinesuiv(shadertype, (Int32)indices.Length, p_indices);
					CallLog("glUniformSubroutinesuiv({0}, {1}, {2})", shadertype, indices.Length, indices);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the value of a subroutine uniform of a given shader stage of the current program
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the subroutine uniform.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="location"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS for the shader currently in use at shader stage <paramref name="shadertype"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no program is active.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetUniformSubroutine(Int32 shadertype, Int32 location, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetUniformSubroutineuiv != null, "pglGetUniformSubroutineuiv not implemented");
					Delegates.pglGetUniformSubroutineuiv(shadertype, location, p_params);
					CallLog("glGetUniformSubroutineuiv({0}, {1}, {2})", shadertype, location, @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve properties of a program object corresponding to a specified shader stage
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. <paramref name="shadertype"/> must be one 
		/// of Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader to query. <paramref name="pname"/> must be Gl.ACTIVE_SUBROUTINE_UNIFORMS, 
		/// Gl.ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS, Gl.ACTIVE_SUBROUTINES, Gl.ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH, or 
		/// Gl.ACTIVE_SUBROUTINE_MAX_LENGTH.
		/// </param>
		/// <param name="values">
		/// Specifies the address of a variable into which the queried value or values will be placed.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shadertype"/> or <paramref name="pname"/> is not one of the accepted 
		/// values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetProgramStage(UInt32 program, Int32 shadertype, Int32 pname, out Int32 values)
		{
			unsafe {
				fixed (Int32* p_values = &values)
				{
					Debug.Assert(Delegates.pglGetProgramStageiv != null, "pglGetProgramStageiv not implemented");
					Delegates.pglGetProgramStageiv(program, shadertype, pname, p_values);
					CallLog("glGetProgramStageiv({0}, {1}, {2}, {3})", program, shadertype, pname, values);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specifies the parameters for patch primitives
		/// </summary>
		/// <param name="pname">
		/// Specifies the name of the parameter to set. The symbolc constants Gl.PATCH_VERTICES, Gl.PATCH_DEFAULT_OUTER_LEVEL, and 
		/// Gl.PATCH_DEFAULT_INNER_LEVEL are accepted.
		/// </param>
		/// <param name="value">
		/// Specifies the new value for the parameter given by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.PATCH_VERTICES and <paramref name="value"/> is less than 
		/// or equal to zero, or greater than the value of Gl.MAX_PATCH_VERTICES.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public static void PatchParameter(Int32 pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPatchParameteri != null, "pglPatchParameteri not implemented");
			Delegates.pglPatchParameteri(pname, value);
			CallLog("glPatchParameteri({0}, {1})", pname, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specifies the parameters for patch primitives
		/// </summary>
		/// <param name="pname">
		/// Specifies the name of the parameter to set. The symbolc constants Gl.PATCH_VERTICES, Gl.PATCH_DEFAULT_OUTER_LEVEL, and 
		/// Gl.PATCH_DEFAULT_INNER_LEVEL are accepted.
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array containing the new values for the parameter given by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.PATCH_VERTICES and <paramref name="value"/> is less than 
		/// or equal to zero, or greater than the value of Gl.MAX_PATCH_VERTICES.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public static void PatchParameter(Int32 pname, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPatchParameterfv != null, "pglPatchParameterfv not implemented");
					Delegates.pglPatchParameterfv(pname, p_values);
					CallLog("glPatchParameterfv({0}, {1})", pname, values);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a transform feedback object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which to bind the transform feedback object <paramref name="id"/>. <paramref name="target"/> 
		/// must be Gl.TRANSFORM_FEEDBACK.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TRANSFORM_FEEDBACK.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the transform feedback operation is active on the currently bound transform 
		/// feedback object, and that operation is not paused.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not zero or the name of a transform feedback object 
		/// returned from a previous call to glGenTransformFeedbacks, or if such a name has been deleted by 
		/// glDeleteTransformFeedbacks.
		/// </exception>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void BindTransformFeedback(Int32 target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBindTransformFeedback != null, "pglBindTransformFeedback not implemented");
			Delegates.pglBindTransformFeedback(target, id);
			CallLog("glBindTransformFeedback({0}, {1})", target, id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete transform feedback objects
		/// </summary>
		/// <param name="ids">
		/// Specifies an array of names of transform feedback objects to delete.
		/// </param>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void DeleteTransformFeedbacks(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteTransformFeedbacks != null, "pglDeleteTransformFeedbacks not implemented");
					Delegates.pglDeleteTransformFeedbacks((Int32)ids.Length, p_ids);
					CallLog("glDeleteTransformFeedbacks({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve transform feedback object names
		/// </summary>
		/// <param name="ids">
		/// Specifies an array of into which the reserved names will be written.
		/// </param>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void GenTransformFeedbacks(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenTransformFeedbacks != null, "pglGenTransformFeedbacks not implemented");
					Delegates.pglGenTransformFeedbacks((Int32)ids.Length, p_ids);
					CallLog("glGenTransformFeedbacks({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve transform feedback object names
		/// </summary>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static UInt32 GenTransformFeedback()
		{
			UInt32[] retValue = new UInt32[1];
			GenTransformFeedbacks(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a transform feedback object
		/// </summary>
		/// <param name="id">
		/// Specifies a value that may be the name of a transform feedback object.
		/// </param>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static bool IsTransformFeedback(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTransformFeedback != null, "pglIsTransformFeedback not implemented");
			retValue = Delegates.pglIsTransformFeedback(id);
			CallLog("glIsTransformFeedback({0}) = {1}", id, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// pause transform feedback operations
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the currently bound transform feedback object is not active or is paused.
		/// </exception>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void PauseTransformFeedback()
		{
			Debug.Assert(Delegates.pglPauseTransformFeedback != null, "pglPauseTransformFeedback not implemented");
			Delegates.pglPauseTransformFeedback();
			CallLog("glPauseTransformFeedback()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// resume transform feedback operations
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the currently bound transform feedback object is not active or is not paused.
		/// </exception>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void ResumeTransformFeedback()
		{
			Debug.Assert(Delegates.pglResumeTransformFeedback != null, "pglResumeTransformFeedback not implemented");
			Delegates.pglResumeTransformFeedback();
			CallLog("glResumeTransformFeedback()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void DrawTransformFeedback(PrimitiveType mode, UInt32 id)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedback != null, "pglDrawTransformFeedback not implemented");
			Delegates.pglDrawTransformFeedback((Int32)mode, id);
			CallLog("glDrawTransformFeedback({0}, {1})", mode, id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stream"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_STREAMS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void DrawTransformFeedbackStream(PrimitiveType mode, UInt32 id, UInt32 stream)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStream != null, "pglDrawTransformFeedbackStream not implemented");
			Delegates.pglDrawTransformFeedbackStream((Int32)mode, id, stream);
			CallLog("glDrawTransformFeedbackStream({0}, {1}, {2})", mode, id, stream);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the boundaries of a query object on an indexed target
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between Gl.BeginQueryIndexed and the subsequent glEndQueryIndexed. 
		/// The symbolic constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.PRIMITIVES_GENERATED, 
		/// Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than the query target-specific maximum.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginQueryIndexed is executed while a query object of the same <paramref 
		/// name="target"/> is already active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndQueryIndexed is executed when a query object of the same <paramref 
		/// name="target"/> is not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of an already active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> refers to an existing query object whose type does not does 
		/// not match <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void BeginQueryIndexed(Int32 target, UInt32 index, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryIndexed != null, "pglBeginQueryIndexed not implemented");
			Delegates.pglBeginQueryIndexed(target, index, id);
			CallLog("glBeginQueryIndexed({0}, {1}, {2})", target, index, id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the boundaries of a query object on an indexed target
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between Gl.BeginQueryIndexed and the subsequent glEndQueryIndexed. 
		/// The symbolic constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.PRIMITIVES_GENERATED, 
		/// Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than the query target-specific maximum.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginQueryIndexed is executed while a query object of the same <paramref 
		/// name="target"/> is already active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndQueryIndexed is executed when a query object of the same <paramref 
		/// name="target"/> is not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of an already active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> refers to an existing query object whose type does not does 
		/// not match <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void EndQueryIndexed(Int32 target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEndQueryIndexed != null, "pglEndQueryIndexed not implemented");
			Delegates.pglEndQueryIndexed(target, index);
			CallLog("glEndQueryIndexed({0}, {1})", target, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of an indexed query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, 
		/// Gl.ANY_SAMPLES_PASSED_CONSERVATIVEGl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, Gl.TIME_ELAPSED, or 
		/// Gl.TIMESTAMP.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query object target.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are Gl.CURRENT_QUERY or 
		/// Gl.QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the <paramref 
		/// name="target"/>-specific maximum.
		/// </exception>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.IsQuery"/>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void GetQueryIndexed(Int32 target, UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryIndexediv != null, "pglGetQueryIndexediv not implemented");
					Delegates.pglGetQueryIndexediv(target, index, pname, p_params);
					CallLog("glGetQueryIndexediv({0}, {1}, {2}, {3})", target, index, pname, @params);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
