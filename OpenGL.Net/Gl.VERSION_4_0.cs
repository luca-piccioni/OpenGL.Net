
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
		/// Value of GL_SAMPLE_SHADING symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_SHADING_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLE_SHADING = 0x8C36;

		/// <summary>
		/// Value of GL_MIN_SAMPLE_SHADING_VALUE symbol.
		/// </summary>
		[AliasOf("GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int MIN_SAMPLE_SHADING_VALUE = 0x8C37;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
		[AliasOf("GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
		[AliasOf("GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_CUBE_MAP_ARRAY = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLER_CUBE_MAP_ARRAY = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
		[RequiredByFeature("GL_VERSION_4_0")]
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
		public const int MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_INTERPOLATION_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
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
		public const int DOUBLE_VEC2 = 0x8FFC;

		/// <summary>
		/// Value of GL_DOUBLE_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_VEC3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_VEC3 = 0x8FFD;

		/// <summary>
		/// Value of GL_DOUBLE_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_VEC4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_VEC4 = 0x8FFE;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2 = 0x8F46;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3 = 0x8F47;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4 = 0x8F48;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2x3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x3 = 0x8F49;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT2x4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x4 = 0x8F4A;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3x2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x2 = 0x8F4B;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x4 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT3x4_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x4 = 0x8F4C;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x2 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4x2_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x2 = 0x8F4D;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x3 symbol.
		/// </summary>
		[AliasOf("GL_DOUBLE_MAT4x3_EXT")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
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
		public const int TRANSFORM_FEEDBACK = 0x8E22;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BINDING symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
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
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void MinSampleShading(float value)
		{
			Debug.Assert(Delegates.pglMinSampleShading != null, "pglMinSampleShading not implemented");
			Delegates.pglMinSampleShading(value);
			CallLog("glMinSampleShading({0})", value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationi.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendEquation(UInt32 buf, int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationi != null, "pglBlendEquationi not implemented");
			Delegates.pglBlendEquationi(buf, mode);
			CallLog("glBlendEquationi({0}, {1})", buf, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparatei.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendEquationSeparatei(UInt32 buf, int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparatei != null, "pglBlendEquationSeparatei not implemented");
			Delegates.pglBlendEquationSeparatei(buf, modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparatei({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFunci.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendFunci(UInt32 buf, int src, int dst)
		{
			Debug.Assert(Delegates.pglBlendFunci != null, "pglBlendFunci not implemented");
			Delegates.pglBlendFunci(buf, src, dst);
			CallLog("glBlendFunci({0}, {1}, {2})", buf, src, dst);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparatei.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		public static void BlendFuncSeparatei(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparatei != null, "pglBlendFuncSeparatei not implemented");
			Delegates.pglBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparatei({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawArraysIndirect != null, "pglDrawArraysIndirect not implemented");
			Delegates.pglDrawArraysIndirect((int)mode, indirect);
			CallLog("glDrawArraysIndirect({0}, {1})", mode, indirect);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawElementsIndirect(PrimitiveType mode, int type, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawElementsIndirect != null, "pglDrawElementsIndirect not implemented");
			Delegates.pglDrawElementsIndirect((int)mode, type, indirect);
			CallLog("glDrawElementsIndirect({0}, {1}, {2})", mode, type, indirect);
			DebugCheckErrors();
		}

		/// <summary>
		/// render indexed primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public static void DrawElementsIndirect(PrimitiveType mode, int type, Object indirect)
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
			DebugCheckErrors();
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
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		public static void GetUniform(UInt32 program, Int32 location, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformdv != null, "pglGetUniformdv not implemented");
					Delegates.pglGetUniformdv(program, location, p_params);
					CallLog("glGetUniformdv({0}, {1}, {2})", program, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the location of a subroutine uniform of a given shader stage within a program
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static Int32 GetSubroutineUniformLocation(UInt32 program, int shadertype, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetSubroutineUniformLocation != null, "pglGetSubroutineUniformLocation not implemented");
			retValue = Delegates.pglGetSubroutineUniformLocation(program, shadertype, name);
			CallLog("glGetSubroutineUniformLocation({0}, {1}, {2}) = {3}", program, shadertype, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// retrieve the index of a subroutine uniform of a given shader stage within a program
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static UInt32 GetSubroutineIndex(UInt32 program, int shadertype, String name)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetSubroutineIndex != null, "pglGetSubroutineIndex not implemented");
			retValue = Delegates.pglGetSubroutineIndex(program, shadertype, name);
			CallLog("glGetSubroutineIndex({0}, {1}, {2}) = {3}", program, shadertype, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// query a property of an active shader subroutine uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing the subroutine.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader subroutine uniform to query. pname must be GL_NUM_COMPATIBLE_SUBROUTINES, 
		/// GL_COMPATIBLE_SUBROUTINES, GL_UNIFORM_SIZE or GL_UNIFORM_NAME_LENGTH.
		/// </param>
		/// <param name="values">
		/// Specifies the address of a into which the queried value or values will be placed.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineUniform(UInt32 program, int shadertype, UInt32 index, int pname, Int32[] values)
		{
			unsafe {
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineUniformiv != null, "pglGetActiveSubroutineUniformiv not implemented");
					Delegates.pglGetActiveSubroutineUniformiv(program, shadertype, index, pname, p_values);
					CallLog("glGetActiveSubroutineUniformiv({0}, {1}, {2}, {3}, {4})", program, shadertype, index, pname, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the name of an active shader subroutine uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing the subroutine.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform.
		/// </param>
		/// <param name="bufsize">
		/// Specifies the size of the buffer whose address is given in name.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable into which is written the number of characters copied into name.
		/// </param>
		/// <param name="name">
		/// Specifies the address of a buffer that will receive the name of the specified shader subroutine uniform.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineUniformName(UInt32 program, int shadertype, UInt32 index, Int32 bufsize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineUniformName != null, "pglGetActiveSubroutineUniformName not implemented");
					Delegates.pglGetActiveSubroutineUniformName(program, shadertype, index, bufsize, p_length, name);
					CallLog("glGetActiveSubroutineUniformName({0}, {1}, {2}, {3}, {4}, {5})", program, shadertype, index, bufsize, length, name);
				}
			}
			DebugCheckErrors();
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
		/// Specifies the size of the buffer whose address is given in name.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable which is to receive the length of the shader subroutine uniform name.
		/// </param>
		/// <param name="name">
		/// Specifies the address of an array into which the name of the shader subroutine uniform will be written.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetActiveSubroutineName(UInt32 program, int shadertype, UInt32 index, Int32 bufsize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveSubroutineName != null, "pglGetActiveSubroutineName not implemented");
					Delegates.pglGetActiveSubroutineName(program, shadertype, index, bufsize, p_length, name);
					CallLog("glGetActiveSubroutineName({0}, {1}, {2}, {3}, {4}, {5})", program, shadertype, index, bufsize, length, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// load active subroutine uniforms
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="count">
		/// Specifies the number of uniform indices stored in indices.
		/// </param>
		/// <param name="indices">
		/// Specifies the address of an array holding the indices to load into the shader subroutine variables.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void UniformSubroutines(int shadertype, params UInt32[] indices)
		{
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglUniformSubroutinesuiv != null, "pglUniformSubroutinesuiv not implemented");
					Delegates.pglUniformSubroutinesuiv(shadertype, (Int32)indices.Length, p_indices);
					CallLog("glUniformSubroutinesuiv({0}, {1}, {2})", shadertype, indices.Length, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the value of a subroutine uniform of a given shader stage of the current program
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the subroutine uniform.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetUniformSubroutine(int shadertype, Int32 location, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetUniformSubroutineuiv != null, "pglGetUniformSubroutineuiv not implemented");
					Delegates.pglGetUniformSubroutineuiv(shadertype, location, p_params);
					CallLog("glGetUniformSubroutineuiv({0}, {1}, {2})", shadertype, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve properties of a program object corresponding to a specified shader stage
		/// </summary>
		/// <param name="program">
		/// Specifies the name of the program containing shader stage.
		/// </param>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader to query. pname must be GL_ACTIVE_SUBROUTINE_UNIFORMS, 
		/// GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS, GL_ACTIVE_SUBROUTINES, GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH, or 
		/// GL_ACTIVE_SUBROUTINE_MAX_LENGTH.
		/// </param>
		/// <param name="values">
		/// Specifies the address of a variable into which the queried value or values will be placed.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		public static void GetProgramStage(UInt32 program, int shadertype, int pname, out Int32 values)
		{
			unsafe {
				fixed (Int32* p_values = &values)
				{
					Debug.Assert(Delegates.pglGetProgramStageiv != null, "pglGetProgramStageiv not implemented");
					Delegates.pglGetProgramStageiv(program, shadertype, pname, p_values);
					CallLog("glGetProgramStageiv({0}, {1}, {2}, {3})", program, shadertype, pname, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specifies the parameters for patch primitives
		/// </summary>
		/// <param name="pname">
		/// Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and 
		/// GL_PATCH_DEFAULT_INNER_LEVEL are accepted.
		/// </param>
		/// <param name="value">
		/// Specifies the new value for the parameter given by pname.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public static void PatchParameter(int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPatchParameteri != null, "pglPatchParameteri not implemented");
			Delegates.pglPatchParameteri(pname, value);
			CallLog("glPatchParameteri({0}, {1})", pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// specifies the parameters for patch primitives
		/// </summary>
		/// <param name="pname">
		/// Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and 
		/// GL_PATCH_DEFAULT_INNER_LEVEL are accepted.
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array containing the new values for the parameter given by pname.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public static void PatchParameter(int pname, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPatchParameterfv != null, "pglPatchParameterfv not implemented");
					Delegates.pglPatchParameterfv(pname, p_values);
					CallLog("glPatchParameterfv({0}, {1})", pname, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a transform feedback object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which to bind the transform feedback object id. target must be GL_TRANSFORM_FEEDBACK.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void BindTransformFeedback(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBindTransformFeedback != null, "pglBindTransformFeedback not implemented");
			Delegates.pglBindTransformFeedback(target, id);
			CallLog("glBindTransformFeedback({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete transform feedback objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of transform feedback objects to delete.
		/// </param>
		/// <param name="ids">
		/// Specifies an array of names of transform feedback objects to delete.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void DeleteTransformFeedback(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteTransformFeedbacks != null, "pglDeleteTransformFeedbacks not implemented");
					Delegates.pglDeleteTransformFeedbacks((Int32)ids.Length, p_ids);
					CallLog("glDeleteTransformFeedbacks({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// reserve transform feedback object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of transform feedback object names to reserve.
		/// </param>
		/// <param name="ids">
		/// Specifies an array of into which the reserved names will be written.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void GenTransformFeedback(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenTransformFeedbacks != null, "pglGenTransformFeedbacks not implemented");
					Delegates.pglGenTransformFeedbacks((Int32)ids.Length, p_ids);
					CallLog("glGenTransformFeedbacks({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// reserve transform feedback object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static UInt32 GenTransformFeedback()
		{
			UInt32[] retValue = new UInt32[1];
			GenTransformFeedback(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a transform feedback object
		/// </summary>
		/// <param name="id">
		/// Specifies a value that may be the name of a transform feedback object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static bool IsTransformFeedback(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTransformFeedback != null, "pglIsTransformFeedback not implemented");
			retValue = Delegates.pglIsTransformFeedback(id);
			CallLog("glIsTransformFeedback({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// pause transform feedback operations
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void PauseTransformFeedback()
		{
			Debug.Assert(Delegates.pglPauseTransformFeedback != null, "pglPauseTransformFeedback not implemented");
			Delegates.pglPauseTransformFeedback();
			CallLog("glPauseTransformFeedback()");
			DebugCheckErrors();
		}

		/// <summary>
		/// resume transform feedback operations
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void ResumeTransformFeedback()
		{
			Debug.Assert(Delegates.pglResumeTransformFeedback != null, "pglResumeTransformFeedback not implemented");
			Delegates.pglResumeTransformFeedback();
			CallLog("glResumeTransformFeedback()");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public static void DrawTransformFeedback(PrimitiveType mode, UInt32 id)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedback != null, "pglDrawTransformFeedback not implemented");
			Delegates.pglDrawTransformFeedback((int)mode, id);
			CallLog("glDrawTransformFeedback({0}, {1})", mode, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void DrawTransformFeedbackStream(PrimitiveType mode, UInt32 id, UInt32 stream)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStream != null, "pglDrawTransformFeedbackStream not implemented");
			Delegates.pglDrawTransformFeedbackStream((int)mode, id, stream);
			CallLog("glDrawTransformFeedbackStream({0}, {1}, {2})", mode, id, stream);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the boundaries of a query object on an indexed target
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQueryIndexed and the subsequent glEndQueryIndexed. 
		/// The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void BeginQueryIndexed(int target, UInt32 index, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryIndexed != null, "pglBeginQueryIndexed not implemented");
			Delegates.pglBeginQueryIndexed(target, index, id);
			CallLog("glBeginQueryIndexed({0}, {1}, {2})", target, index, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the boundaries of a query object on an indexed target
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQueryIndexed and the subsequent glEndQueryIndexed. 
		/// The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void EndQueryIndexed(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEndQueryIndexed != null, "pglEndQueryIndexed not implemented");
			Delegates.pglEndQueryIndexed(target, index);
			CallLog("glEndQueryIndexed({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of an indexed query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEGL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or 
		/// GL_TIMESTAMP.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query object target.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or 
		/// GL_QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback3")]
		public static void GetQueryIndexed(int target, UInt32 index, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryIndexediv != null, "pglGetQueryIndexediv not implemented");
					Delegates.pglGetQueryIndexediv(target, index, pname, p_params);
					CallLog("glGetQueryIndexediv({0}, {1}, {2}, {3})", target, index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
