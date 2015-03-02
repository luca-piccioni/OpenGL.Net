
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
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLE_SHADING = 0x8C36;

		/// <summary>
		/// Value of GL_MIN_SAMPLE_SHADING_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int MIN_SAMPLE_SHADING_VALUE = 0x8C37;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_CUBE_MAP_ARRAY = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLER_CUBE_MAP_ARRAY = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_draw_indirect")]
		public const int DRAW_INDIRECT_BUFFER = 0x8F3F;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
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
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader5")]
		public const int MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_INTERPOLATION_OFFSET symbol.
		/// </summary>
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
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_VEC2 = 0x8FFC;

		/// <summary>
		/// Value of GL_DOUBLE_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_VEC3 = 0x8FFD;

		/// <summary>
		/// Value of GL_DOUBLE_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_VEC4 = 0x8FFE;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2 = 0x8F46;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3 = 0x8F47;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4 = 0x8F48;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x3 = 0x8F49;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x4 = 0x8F4A;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x2 = 0x8F4B;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x4 = 0x8F4C;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x2 = 0x8F4D;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x3 symbol.
		/// </summary>
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
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		[RequiredByFeature("GL_EXT_debug_label")]
		public const int TRANSFORM_FEEDBACK = 0x8E22;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
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
		/// <remarks>
		/// glMinSampleShading specifies the rate at which samples are shaded within a covered pixel. Sample-rate shading is enabled 
		/// bycalling glEnable with the parameter GL_SAMPLE_SHADING. If GL_MULTISAMPLE or GL_SAMPLE_SHADING is disabled, sample 
		/// shadinghas no effect. Otherwise, an implementation must provide at least as many unique color values for each covered 
		/// fragmentas specified by value times samples where samples is the value of GL_SAMPLES for the current framebuffer. At 
		/// least1 sample for each covered fragment is generated. 
		/// A value of 1.0 indicates that each sample in the framebuffer should be indpendently shaded. A value of 0.0 effectively 
		/// allowsthe GL to ignore sample rate shading. Any value between 0.0 and 1.0 allows the GL to shade only a subset of the 
		/// totalsamples within each covered fragment. Which samples are shaded and the algorithm used to select that subset of the 
		/// fragment'ssamples is implementation dependent. 
		/// <para>
		/// The following errors can be generated:
		/// - None. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MIN_SAMPLE_SHADING. 
		/// - glGet with argument GL_SAMPLES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.removedTypes"/>
		public static void MinSampleShading(float value)
		{
			if        (Delegates.pglMinSampleShading != null) {
				Delegates.pglMinSampleShading(value);
				CallLog("glMinSampleShading({0})", value);
			} else if (Delegates.pglMinSampleShadingARB != null) {
				Delegates.pglMinSampleShadingARB(value);
				CallLog("glMinSampleShadingARB({0})", value);
			} else if (Delegates.pglMinSampleShadingOES != null) {
				Delegates.pglMinSampleShadingOES(value);
				CallLog("glMinSampleShadingOES({0})", value);
			} else
				throw new NotImplementedException("glMinSampleShading (and other aliases) are not implemented");
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
		public static void BlendEquation(UInt32 buf, int mode)
		{
			if        (Delegates.pglBlendEquationi != null) {
				Delegates.pglBlendEquationi(buf, mode);
				CallLog("glBlendEquationi({0}, {1})", buf, mode);
			} else if (Delegates.pglBlendEquationIndexedAMD != null) {
				Delegates.pglBlendEquationIndexedAMD(buf, mode);
				CallLog("glBlendEquationIndexedAMD({0}, {1})", buf, mode);
			} else if (Delegates.pglBlendEquationiARB != null) {
				Delegates.pglBlendEquationiARB(buf, mode);
				CallLog("glBlendEquationiARB({0}, {1})", buf, mode);
			} else if (Delegates.pglBlendEquationiEXT != null) {
				Delegates.pglBlendEquationiEXT(buf, mode);
				CallLog("glBlendEquationiEXT({0}, {1})", buf, mode);
			} else if (Delegates.pglBlendEquationiOES != null) {
				Delegates.pglBlendEquationiOES(buf, mode);
				CallLog("glBlendEquationiOES({0}, {1})", buf, mode);
			} else
				throw new NotImplementedException("glBlendEquationi (and other aliases) are not implemented");
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
		public static void BlendEquationSeparatei(UInt32 buf, int modeRGB, int modeAlpha)
		{
			if        (Delegates.pglBlendEquationSeparatei != null) {
				Delegates.pglBlendEquationSeparatei(buf, modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparatei({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateIndexedAMD != null) {
				Delegates.pglBlendEquationSeparateIndexedAMD(buf, modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparateIndexedAMD({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateiARB != null) {
				Delegates.pglBlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparateiARB({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateiEXT != null) {
				Delegates.pglBlendEquationSeparateiEXT(buf, modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparateiEXT({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateiOES != null) {
				Delegates.pglBlendEquationSeparateiOES(buf, modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparateiOES({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			} else
				throw new NotImplementedException("glBlendEquationSeparatei (and other aliases) are not implemented");
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
		public static void BlendFunci(UInt32 buf, int src, int dst)
		{
			if        (Delegates.pglBlendFunci != null) {
				Delegates.pglBlendFunci(buf, src, dst);
				CallLog("glBlendFunci({0}, {1}, {2})", buf, src, dst);
			} else if (Delegates.pglBlendFuncIndexedAMD != null) {
				Delegates.pglBlendFuncIndexedAMD(buf, src, dst);
				CallLog("glBlendFuncIndexedAMD({0}, {1}, {2})", buf, src, dst);
			} else if (Delegates.pglBlendFunciARB != null) {
				Delegates.pglBlendFunciARB(buf, src, dst);
				CallLog("glBlendFunciARB({0}, {1}, {2})", buf, src, dst);
			} else if (Delegates.pglBlendFunciEXT != null) {
				Delegates.pglBlendFunciEXT(buf, src, dst);
				CallLog("glBlendFunciEXT({0}, {1}, {2})", buf, src, dst);
			} else if (Delegates.pglBlendFunciOES != null) {
				Delegates.pglBlendFunciOES(buf, src, dst);
				CallLog("glBlendFunciOES({0}, {1}, {2})", buf, src, dst);
			} else
				throw new NotImplementedException("glBlendFunci (and other aliases) are not implemented");
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
		public static void BlendFuncSeparatei(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			if        (Delegates.pglBlendFuncSeparatei != null) {
				Delegates.pglBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
				CallLog("glBlendFuncSeparatei({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			} else if (Delegates.pglBlendFuncSeparateIndexedAMD != null) {
				Delegates.pglBlendFuncSeparateIndexedAMD(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
				CallLog("glBlendFuncSeparateIndexedAMD({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			} else if (Delegates.pglBlendFuncSeparateiARB != null) {
				Delegates.pglBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
				CallLog("glBlendFuncSeparateiARB({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			} else if (Delegates.pglBlendFuncSeparateiEXT != null) {
				Delegates.pglBlendFuncSeparateiEXT(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
				CallLog("glBlendFuncSeparateiEXT({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			} else if (Delegates.pglBlendFuncSeparateiOES != null) {
				Delegates.pglBlendFuncSeparateiOES(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
				CallLog("glBlendFuncSeparateiOES({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			} else
				throw new NotImplementedException("glBlendFuncSeparatei (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. glDrawArraysIndirect 
		/// behavessimilarly to glDrawArraysInstancedBaseInstance, execept that the parameters to glDrawArraysInstancedBaseInstance 
		/// arestored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint first; uint baseInstance; } DrawArraysIndirectCommand; const DrawArraysIndirectCommand *cmd = 
		/// (constDrawArraysIndirectCommand *)indirect; glDrawArraysInstancedBaseInstance(mode, cmd-&gt;first, cmd-&gt;count, 
		/// cmd-&gt;primCount,cmd-&gt;baseInstance); 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawArraysIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and 
		/// out-of-rangeindices do not generate an error. 
		/// Vertex attributes that are modified by glDrawArraysIndirect have an unspecified value after glDrawArraysIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawArraysIndirect(int mode, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawArraysIndirect != null, "pglDrawArraysIndirect not implemented");
			Delegates.pglDrawArraysIndirect(mode, indirect);
			CallLog("glDrawArraysIndirect({0}, {1})", mode, indirect);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. glDrawArraysIndirect 
		/// behavessimilarly to glDrawArraysInstancedBaseInstance, execept that the parameters to glDrawArraysInstancedBaseInstance 
		/// arestored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint first; uint baseInstance; } DrawArraysIndirectCommand; const DrawArraysIndirectCommand *cmd = 
		/// (constDrawArraysIndirectCommand *)indirect; glDrawArraysInstancedBaseInstance(mode, cmd-&gt;first, cmd-&gt;count, 
		/// cmd-&gt;primCount,cmd-&gt;baseInstance); 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawArraysIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and 
		/// out-of-rangeindices do not generate an error. 
		/// Vertex attributes that are modified by glDrawArraysIndirect have an unspecified value after glDrawArraysIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. glDrawArraysIndirect 
		/// behavessimilarly to glDrawArraysInstancedBaseInstance, execept that the parameters to glDrawArraysInstancedBaseInstance 
		/// arestored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint first; uint baseInstance; } DrawArraysIndirectCommand; const DrawArraysIndirectCommand *cmd = 
		/// (constDrawArraysIndirectCommand *)indirect; glDrawArraysInstancedBaseInstance(mode, cmd-&gt;first, cmd-&gt;count, 
		/// cmd-&gt;primCount,cmd-&gt;baseInstance); 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawArraysIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and 
		/// out-of-rangeindices do not generate an error. 
		/// Vertex attributes that are modified by glDrawArraysIndirect have an unspecified value after glDrawArraysIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawArraysIndirect(int mode, Object indirect)
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
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. 
		/// glDrawElementsIndirectbehaves similarly to glDrawElementsInstancedBaseVertexBaseInstance, execpt that the parameters to 
		/// glDrawElementsInstancedBaseVertexBaseInstanceare stored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint firstIndex; uint baseVertex; uint baseInstance; } DrawElementsIndirectCommand; 
		/// glDrawElementsIndirect is equivalent to: 
		/// void glDrawElementsIndirect(GLenum mode, GLenum type, const void * indirect) { const DrawElementsIndirectCommand *cmd = 
		/// (constDrawElementsIndirectCommand *)indirect; glDrawElementsInstancedBaseVertexBaseInstance(mode, cmd-&gt;count, type, 
		/// cmd-&gt;firstIndex+ size-of-type, cmd-&gt;primCount, cmd-&gt;baseVertex, cmd-&gt;baseInstance); } 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawElementsIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// Note that indices stored in client memory are not supported. If no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER 
		/// binding,an error will be generated. 
		/// The results of the operation are undefined if the reservedMustBeZero member of the parameter structure is non-zero. 
		/// However,no error is generated in this case. 
		/// Vertex attributes that are modified by glDrawElementsIndirect have an unspecified value after glDrawElementsIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER binding, or if such a buffer's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawElementsIndirect(int mode, int type, IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDrawElementsIndirect != null, "pglDrawElementsIndirect not implemented");
			Delegates.pglDrawElementsIndirect(mode, type, indirect);
			CallLog("glDrawElementsIndirect({0}, {1}, {2})", mode, type, indirect);
			DebugCheckErrors();
		}

		/// <summary>
		/// render indexed primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. 
		/// glDrawElementsIndirectbehaves similarly to glDrawElementsInstancedBaseVertexBaseInstance, execpt that the parameters to 
		/// glDrawElementsInstancedBaseVertexBaseInstanceare stored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint firstIndex; uint baseVertex; uint baseInstance; } DrawElementsIndirectCommand; 
		/// glDrawElementsIndirect is equivalent to: 
		/// void glDrawElementsIndirect(GLenum mode, GLenum type, const void * indirect) { const DrawElementsIndirectCommand *cmd = 
		/// (constDrawElementsIndirectCommand *)indirect; glDrawElementsInstancedBaseVertexBaseInstance(mode, cmd-&gt;count, type, 
		/// cmd-&gt;firstIndex+ size-of-type, cmd-&gt;primCount, cmd-&gt;baseVertex, cmd-&gt;baseInstance); } 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawElementsIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// Note that indices stored in client memory are not supported. If no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER 
		/// binding,an error will be generated. 
		/// The results of the operation are undefined if the reservedMustBeZero member of the parameter structure is non-zero. 
		/// However,no error is generated in this case. 
		/// Vertex attributes that are modified by glDrawElementsIndirect have an unspecified value after glDrawElementsIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER binding, or if such a buffer's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing the draw parameters. 
		/// </param>
		/// <remarks>
		/// glDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. 
		/// glDrawElementsIndirectbehaves similarly to glDrawElementsInstancedBaseVertexBaseInstance, execpt that the parameters to 
		/// glDrawElementsInstancedBaseVertexBaseInstanceare stored in memory at the address given by indirect. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint primCount; uint firstIndex; uint baseVertex; uint baseInstance; } DrawElementsIndirectCommand; 
		/// glDrawElementsIndirect is equivalent to: 
		/// void glDrawElementsIndirect(GLenum mode, GLenum type, const void * indirect) { const DrawElementsIndirectCommand *cmd = 
		/// (constDrawElementsIndirectCommand *)indirect; glDrawElementsInstancedBaseVertexBaseInstance(mode, cmd-&gt;count, type, 
		/// cmd-&gt;firstIndex+ size-of-type, cmd-&gt;primCount, cmd-&gt;baseVertex, cmd-&gt;baseInstance); } 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawElementsIndirect, indirect is 
		/// interpretedas an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather 
		/// thanfrom client memory. 
		/// Note that indices stored in client memory are not supported. If no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER 
		/// binding,an error will be generated. 
		/// The results of the operation are undefined if the reservedMustBeZero member of the parameter structure is non-zero. 
		/// However,no error is generated in this case. 
		/// Vertex attributes that are modified by glDrawElementsIndirect have an unspecified value after glDrawElementsIndirect 
		/// returns.Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER binding, or if such a buffer's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or to the 
		///   GL_DRAW_INDIRECT_BUFFERbinding and the buffer object's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawElementsIndirect(int mode, int type, Object indirect)
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
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query. 
		/// </param>
		/// <remarks>
		/// glGetSubroutineUniformLocation returns the location of the subroutine uniform variable name in the shader stage of type 
		/// shadertypeattached to program, with behavior otherwise identical to glGetUniformLocation. 
		/// If name is not the name of a subroutine uniform in the shader stage, -1 is returned, but no error is generated. If name 
		/// isthe name of a subroutine uniform in the shader stage, a value between zero and the value of 
		/// GL_ACTIVE_SUBROUTINE_LOCATIONSminus one will be returned. Subroutine locations are assigned using consecutive integers 
		/// inthe range from zero to the value of GL_ACTIVE_SUBROUTINE_LOCATIONS minus one for the shader stage. For active 
		/// subroutineuniforms declared as arrays, the declared array elements are assigned consecutive locations. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype or pname is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="name">
		/// Specifies the name of the subroutine uniform whose index to query. 
		/// </param>
		/// <remarks>
		/// glGetSubroutineIndex returns the index of a subroutine uniform within a shader stage attached to a program object. 
		/// programcontains the name of the program to which the shader is attached. shadertype specifies the stage from which to 
		/// queryshader subroutine index. name contains the null-terminated name of the subroutine uniform whose name to query. 
		/// If name is not the name of a subroutine uniform in the shader stage, GL_INVALID_INDEX is returned, but no error is 
		/// generated.If name is the name of a subroutine uniform in the shader stage, a value between zero and the value of 
		/// GL_ACTIVE_SUBROUTINESminus one will be returned. Subroutine indices are assigned using consecutive integers in the range 
		/// fromzero to the value of GL_ACTIVE_SUBROUTINES minus one for the shader stage. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype or pname is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the shader subroutine uniform. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader subroutine uniform to query. pname must be GL_NUM_COMPATIBLE_SUBROUTINES, 
		/// GL_COMPATIBLE_SUBROUTINES,GL_UNIFORM_SIZE or GL_UNIFORM_NAME_LENGTH. 
		/// </param>
		/// <param name="values">
		/// Specifies the address of a into which the queried value or values will be placed. 
		/// </param>
		/// <remarks>
		/// glGetActiveSubroutineUniform queries a parameter of an active shader subroutine uniform. program contains the name of 
		/// theprogram containing the uniform. shadertype specifies the stage which which the uniform location, given by index, is 
		/// valid.index must be between zero and the value of GL_ACTIVE_SUBROUTINE_UNIFORMS minus one for the shader stage. 
		/// If pname is GL_NUM_COMPATIBLE_SUBROUTINES, a single integer indicating the number of subroutines that can be assigned to 
		/// theuniform is returned in values. 
		/// If pname is GL_COMPATIBLE_SUBROUTINES, an array of integers is returned in values, with each integer specifying the 
		/// indexof an active subroutine that can be assigned to the selected subroutine uniform. The number of integers returned is 
		/// thesame as the value returned for GL_NUM_COMPATIBLE_SUBROUTINES. 
		/// If pname is GL_UNIFORM_SIZE, a single integer is returned in values. If the selected subroutine uniform is an array, the 
		/// declaredsize of the array is returned; otherwise, one is returned. 
		/// If pname is GL_UNIFORM_NAME_LENGTH, a single integer specifying the length of the subroutine uniform name (including the 
		/// terminatingnull character) is returned in values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype or pname is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the value of GL_ACTIVE_SUBROUTINES. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgramStage with argument GL_ACTIVE_SUBROUTINE_UNIFORMS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetProgramStage"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
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
		/// <remarks>
		/// glGetActiveSubroutineUniformName retrieves the name of an active shader subroutine uniform. program contains the name of 
		/// theprogram containing the uniform. shadertype specifies the stage for which which the uniform location, given by index, 
		/// isvalid. index must be between zero and the value of GL_ACTIVE_SUBROUTINE_UNIFORMS minus one for the shader stage. 
		/// The uniform name is returned as a null-terminated string in name. The actual number of characters written into name, 
		/// excludingthe null terminator is returned in length. If length is NULL, no length is returned. The maximum number of 
		/// charactersthat may be written into name, including the null terminator, is specified by bufsize. The length of the 
		/// longestsubroutine uniform name in program and shadertype is given by the value of 
		/// GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH,which can be queried with glGetProgramStage. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype or pname is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the value of GL_ACTIVE_SUBROUTINES. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgramStage with argument GL_ACTIVE_SUBROUTINE_UNIFORMS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetProgramStage"/>
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
		/// <remarks>
		/// glGetActiveSubroutineName queries the name of an active shader subroutine uniform from the program object given in 
		/// program.index specifies the index of the shader subroutine uniform within the shader stage given by stage, and must 
		/// betweenzero and the value of GL_ACTIVE_SUBROUTINES minus one for the shader stage. 
		/// The name of the selected subroutine is returned as a null-terminated string in name. The actual number of characters 
		/// writteninto name, not including the null-terminator, is is returned in length. If length is NULL, no length is returned. 
		/// Themaximum number of characters that may be written into name, including the null-terminator, is given in bufsize. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the value of GL_ACTIVE_SUBROUTINES. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgramStage with argument GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetSubroutineIndex"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetProgramStage"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of uniform indices stored in indices. 
		/// </param>
		/// <param name="indices">
		/// Specifies the address of an array holding the indices to load into the shader subroutine variables. 
		/// </param>
		/// <remarks>
		/// glUniformSubroutines loads all active subroutine uniforms for shader stage shadertype of the current program with 
		/// subroutineindices from indices, storing indices[i] into the uniform at location i. count must be equal to the value of 
		/// GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONSfor the program currently in use at shader stage shadertype. Furthermore, all 
		/// valuesin indices must be less than the value of GL_ACTIVE_SUBROUTINES for the shader stage. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if no program object is current. 
		/// - GL_INVALID_VALUE is generated if count is not equal to the value of GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS for the 
		///   shaderstage shadertype of the current program. 
		/// - GL_INVALID_VALUE is generated if any value in indices is geater than or equal to the value of GL_ACTIVE_SUBROUTINES for 
		///   theshader stage shadertype of the current program. 
		/// - GL_INVALID_ENUM is generated if shadertype is not one of the accepted values. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgramStage with argument GL_ACTIVE_SUBROUTINES 
		/// - glGetProgramStage with argument GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetProgramStage"/>
		public static void UniformSubroutines(int shadertype, Int32 count, UInt32[] indices)
		{
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglUniformSubroutinesuiv != null, "pglUniformSubroutinesuiv not implemented");
					Delegates.pglUniformSubroutinesuiv(shadertype, count, p_indices);
					CallLog("glUniformSubroutinesuiv({0}, {1}, {2})", shadertype, count, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the value of a subroutine uniform of a given shader stage of the current program
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="location">
		/// Specifies the location of the subroutine uniform. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// glGetUniformSubroutine retrieves the value of the subroutine uniform at location location for shader stage shadertype of 
		/// thecurrent program. location must be less than the value of GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS for the shader 
		/// currentlyin use at shader stage shadertype. The value of the subroutine uniform is returned in values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if location is greater than or equal to the value of 
		///   GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONSfor the shader currently in use at shader stage shadertype. 
		/// - GL_INVALID_OPERATION is generated if no program is active. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
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
		/// GL_TESS_CONTROL_SHADER,GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the shader to query. pname must be GL_ACTIVE_SUBROUTINE_UNIFORMS, 
		/// GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS,GL_ACTIVE_SUBROUTINES, GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH, or 
		/// GL_ACTIVE_SUBROUTINE_MAX_LENGTH.
		/// </param>
		/// <param name="values">
		/// Specifies the address of a variable into which the queried value or values will be placed. 
		/// </param>
		/// <remarks>
		/// glGetProgramStage queries a parameter of a shader stage attached to a program object. program contains the name of the 
		/// programto which the shader is attached. shadertype specifies the stage from which to query the parameter. pname 
		/// specifieswhich parameter should be queried. The value or values of the parameter to be queried is returned in the 
		/// variablewhose address is given in values. 
		/// If pname is GL_ACTIVE_SUBROUTINE_UNIFORMS, the number of active subroutine variables in the stage is returned in values. 
		/// If pname is GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS, the number of active subroutine variable locations in the stage is 
		/// returnedin values. 
		/// If pname is GL_ACTIVE_SUBROUTINES, the number of active subroutines in the stage is returned in values. 
		/// If pname is GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH, the length of the longest subroutine uniform for the stage is 
		/// returnedin values. 
		/// If pname is GL_ACTIVE_SUBROUTINE_MAX_LENGTH, the length of the longest subroutine name for the stage is returned in 
		/// values.The returned name length includes space for the null-terminator. 
		/// If there is no shader present of type shadertype, the returned value will be consistent with a shader containing no 
		/// subroutinesor subroutine uniforms. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if shadertype or pname is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
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
		/// GL_PATCH_DEFAULT_INNER_LEVELare accepted. 
		/// </param>
		/// <param name="value">
		/// Specifies the new value for the parameter given by pname. 
		/// </param>
		/// <remarks>
		/// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to 
		/// modifyand must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For 
		/// glPatchParameteri,value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values 
		/// specifiesthe address of an array containing the new values for the parameter specified by pname. 
		/// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch 
		/// primitive.Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for 
		/// tessellation.When primitives are specified using glDrawArrays or a similar function, each patch will be made from 
		/// parametercontrol points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater 
		/// thanzero, and less than or equal to the value of GL_MAX_PATCH_VERTICES. 
		/// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array 
		/// contiainingthe default outer or inner tessellation levels, respectively, to be used when no tessellation control shader 
		/// ispresent. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if pname is GL_PATCH_VERTICES and value is less than or equal to zero, or greater than the 
		///   valueof GL_MAX_PATCH_VERTICES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void PatchParameter(int pname, Int32 value)
		{
			if        (Delegates.pglPatchParameteri != null) {
				Delegates.pglPatchParameteri(pname, value);
				CallLog("glPatchParameteri({0}, {1})", pname, value);
			} else if (Delegates.pglPatchParameteriEXT != null) {
				Delegates.pglPatchParameteriEXT(pname, value);
				CallLog("glPatchParameteriEXT({0}, {1})", pname, value);
			} else if (Delegates.pglPatchParameteriOES != null) {
				Delegates.pglPatchParameteriOES(pname, value);
				CallLog("glPatchParameteriOES({0}, {1})", pname, value);
			} else
				throw new NotImplementedException("glPatchParameteri (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specifies the parameters for patch primitives
		/// </summary>
		/// <param name="pname">
		/// Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and 
		/// GL_PATCH_DEFAULT_INNER_LEVELare accepted. 
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array containing the new values for the parameter given by pname. 
		/// </param>
		/// <remarks>
		/// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to 
		/// modifyand must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For 
		/// glPatchParameteri,value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values 
		/// specifiesthe address of an array containing the new values for the parameter specified by pname. 
		/// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch 
		/// primitive.Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for 
		/// tessellation.When primitives are specified using glDrawArrays or a similar function, each patch will be made from 
		/// parametercontrol points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater 
		/// thanzero, and less than or equal to the value of GL_MAX_PATCH_VERTICES. 
		/// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array 
		/// contiainingthe default outer or inner tessellation levels, respectively, to be used when no tessellation control shader 
		/// ispresent. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if pname is GL_PATCH_VERTICES and value is less than or equal to zero, or greater than the 
		///   valueof GL_MAX_PATCH_VERTICES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// <remarks>
		/// glBindTransformFeedback binds the transform feedback object with name id to the current GL state. id must be a name 
		/// previouslyreturned from a call to glGenTransformFeedbacks. If id has not previously been bound, a new transform feedback 
		/// objectwith name id and initialized with with the default transform state vector is created. 
		/// In the initial state, a default transform feedback object is bound and treated as a transform feedback object with a 
		/// nameof zero. If the name zero is subsequently bound, the default transform feedback object is again bound to the GL 
		/// state.
		/// While a transform feedback buffer object is bound, GL operations on the target to which it is bound affect the bound 
		/// transformfeedback object, and queries of the target to which a transform feedback object is bound return state from the 
		/// boundobject. When buffer objects are bound for transform feedback, they are attached to the currently bound transform 
		/// feedbackobject. Buffer objects are used for trans- form feedback only if they are attached to the currently bound 
		/// transformfeedback object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_TRANSFORM_FEEDBACK. 
		/// - GL_INVALID_OPERATION is generated if the transform feedback operation is active on the currently bound transform 
		///   feedbackobject, and that operation is not paused. 
		/// - GL_INVALID_OPERATION is generated if id is not zero or the name of a transform feedback object returned from a previous 
		///   callto glGenTransformFeedbacks, or if such a name has been deleted by glDeleteTransformFeedbacks. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TRANSFORM_FEEDBACK_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
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
		/// <remarks>
		/// glDeleteTransformFeedbacks deletes the n transform feedback objects whose names are stored in the array ids. Unused 
		/// namesin ids are ignored, as is the name zero. After a transform feedback object is deleted, its name is again unused and 
		/// ithas no contents. If an active transform feedback object is deleted, its name immediately becomes unused, but the 
		/// underlyingobject is not deleted until it is no longer active. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TRANSFORM_FEEDBACK_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		public static void DeleteTransformFeedback(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglDeleteTransformFeedbacks != null) {
						Delegates.pglDeleteTransformFeedbacks(n, p_ids);
						CallLog("glDeleteTransformFeedbacks({0}, {1})", n, ids);
					} else if (Delegates.pglDeleteTransformFeedbacksNV != null) {
						Delegates.pglDeleteTransformFeedbacksNV(n, p_ids);
						CallLog("glDeleteTransformFeedbacksNV({0}, {1})", n, ids);
					} else
						throw new NotImplementedException("glDeleteTransformFeedbacks (and other aliases) are not implemented");
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
		/// <remarks>
		/// glGenTransformFeedbacks returns n previously unused transform feedback object names in ids. These names are marked as 
		/// used,for the purposes of glGenTransformFeedbacks only, but they acquire transform feedback state only when they are 
		/// firstbound. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TRANSFORM_FEEDBACK_BINDING 
		/// - glIsTransformFeedback 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		public static void GenTransformFeedback(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglGenTransformFeedbacks != null) {
						Delegates.pglGenTransformFeedbacks(n, p_ids);
						CallLog("glGenTransformFeedbacks({0}, {1})", n, ids);
					} else if (Delegates.pglGenTransformFeedbacksNV != null) {
						Delegates.pglGenTransformFeedbacksNV(n, p_ids);
						CallLog("glGenTransformFeedbacksNV({0}, {1})", n, ids);
					} else
						throw new NotImplementedException("glGenTransformFeedbacks (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a transform feedback object
		/// </summary>
		/// <param name="id">
		/// Specifies a value that may be the name of a transform feedback object. 
		/// </param>
		/// <remarks>
		/// glIsTransformFeedback returns GL_TRUE if id is currently the name of a transform feedback object. If id is zero, or if 
		/// idis not the name of a transform feedback object, or if an error occurs, glIsTransformFeedback returns GL_FALSE. If id 
		/// isa name returned by glGenTransformFeedbacks, but that has not yet been bound through a call to glBindTransformFeedback, 
		/// thenthe name is not a transform feedback object and glIsTransformFeedback returns GL_FALSE. 
		/// </remarks>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		public static bool IsTransformFeedback(UInt32 id)
		{
			bool retValue;

			if        (Delegates.pglIsTransformFeedback != null) {
				retValue = Delegates.pglIsTransformFeedback(id);
				CallLog("glIsTransformFeedback({0}) = {1}", id, retValue);
			} else if (Delegates.pglIsTransformFeedbackNV != null) {
				retValue = Delegates.pglIsTransformFeedbackNV(id);
				CallLog("glIsTransformFeedbackNV({0}) = {1}", id, retValue);
			} else
				throw new NotImplementedException("glIsTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// pause transform feedback operations
		/// </summary>
		/// <remarks>
		/// glPauseTransformFeedback pauses transform feedback operations on the currently active transform feedback object. When 
		/// transformfeedback operations are paused, transform feedback is still considered active and changing most transform 
		/// feedbackstate related to the object results in an error. However, a new transform feedback object may be bound while 
		/// transformfeedback is paused. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if the currently bound transform feedback object is not active or is paused. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		public static void PauseTransformFeedback()
		{
			if        (Delegates.pglPauseTransformFeedback != null) {
				Delegates.pglPauseTransformFeedback();
				CallLog("glPauseTransformFeedback()");
			} else if (Delegates.pglPauseTransformFeedbackNV != null) {
				Delegates.pglPauseTransformFeedbackNV();
				CallLog("glPauseTransformFeedbackNV()");
			} else
				throw new NotImplementedException("glPauseTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// resume transform feedback operations
		/// </summary>
		/// <remarks>
		/// glResumeTransformFeedback resumes transform feedback operations on the currently active transform feedback object. When 
		/// transformfeedback operations are paused, transform feedback is still considered active and changing most transform 
		/// feedbackstate related to the object results in an error. However, a new transform feedback object may be bound while 
		/// transformfeedback is paused. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if the currently bound transform feedback object is not active or is not paused. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		public static void ResumeTransformFeedback()
		{
			if        (Delegates.pglResumeTransformFeedback != null) {
				Delegates.pglResumeTransformFeedback();
				CallLog("glResumeTransformFeedback()");
			} else if (Delegates.pglResumeTransformFeedbackNV != null) {
				Delegates.pglResumeTransformFeedbackNV();
				CallLog("glResumeTransformFeedbackNV()");
			} else
				throw new NotImplementedException("glResumeTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count. 
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback 
		/// specifiedby id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set 
		/// tozero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was 
		/// activeon the transform feedback object named by id. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   namedby id was bound. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		public static void DrawTransformFeedback(int mode, UInt32 id)
		{
			if        (Delegates.pglDrawTransformFeedback != null) {
				Delegates.pglDrawTransformFeedback(mode, id);
				CallLog("glDrawTransformFeedback({0}, {1})", mode, id);
			} else if (Delegates.pglDrawTransformFeedbackNV != null) {
				Delegates.pglDrawTransformFeedbackNV(mode, id);
				CallLog("glDrawTransformFeedbackNV({0}, {1})", mode, id);
			} else
				throw new NotImplementedException("glDrawTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count. 
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback 
		/// specifiedby id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set 
		/// tozero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was 
		/// activeon the transform feedback object named by id. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   namedby id was bound. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		public static void DrawTransformFeedback(PrimitiveType mode, UInt32 id)
		{
			if        (Delegates.pglDrawTransformFeedback != null) {
				Delegates.pglDrawTransformFeedback((int)mode, id);
				CallLog("glDrawTransformFeedback({0}, {1})", mode, id);
			} else if (Delegates.pglDrawTransformFeedbackNV != null) {
				Delegates.pglDrawTransformFeedbackNV((int)mode, id);
				CallLog("glDrawTransformFeedbackNV({0}, {1})", mode, id);
			} else
				throw new NotImplementedException("glDrawTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count. 
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count. 
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform 
		/// feedbackstream specified by stream of the transform feedback object specified by id. Calling 
		/// glDrawTransformFeedbackStreamis equivalent to calling glDrawArrays with mode as specified, first set to zero, and count 
		/// setto the number of vertices captured on vertex stream stream the last time transform feedback was active on the 
		/// transformfeedback object named by id. 
		/// Calling glDrawTransformFeedback is equivalent to calling glDrawTransformFeedbackStream with stream set to zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object. 
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   namedby id was bound. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		public static void DrawTransformFeedbackStream(int mode, UInt32 id, UInt32 stream)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStream != null, "pglDrawTransformFeedbackStream not implemented");
			Delegates.pglDrawTransformFeedbackStream(mode, id, stream);
			CallLog("glDrawTransformFeedbackStream({0}, {1}, {2})", mode, id, stream);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count. 
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count. 
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform 
		/// feedbackstream specified by stream of the transform feedback object specified by id. Calling 
		/// glDrawTransformFeedbackStreamis equivalent to calling glDrawArrays with mode as specified, first set to zero, and count 
		/// setto the number of vertices captured on vertex stream stream the last time transform feedback was active on the 
		/// transformfeedback object named by id. 
		/// Calling glDrawTransformFeedback is equivalent to calling glDrawTransformFeedbackStream with stream set to zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object. 
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   namedby id was bound. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
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
		/// Thesymbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object. 
		/// </param>
		/// <remarks>
		/// glBeginQueryIndexed and glEndQueryIndexed delimit the boundaries of a query object. query must be a name previously 
		/// returnedfrom a call to glGenQueries. If a query object with name id does not yet exist it is created with the type 
		/// determinedby target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is 
		/// asfollows. 
		/// index specifies the index of the query target and must be between a target-specific maximum. 
		/// If target is GL_SAMPLES_PASSED, id must be an unused name, or the name of an existing occlusion query object. When 
		/// glBeginQueryIndexedis executed, the query object's samples-passed counter is reset to 0. Subsequent rendering will 
		/// incrementthe counter for every sample that passes the depth test. If the value of GL_SAMPLE_BUFFERS is 0, then the 
		/// samples-passedcount is incremented by 1 for each fragment. If the value of GL_SAMPLE_BUFFERS is 1, then the 
		/// samples-passedcount is incremented by the number of samples whose coverage bit is set. However, implementations, at 
		/// theirdiscression may instead increase the samples-passed count by the value of GL_SAMPLES if any sample in the fragment 
		/// iscovered. When glEndQueryIndexed is executed, the samples-passed counter is assigned to the query object's result 
		/// value.This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. When target is GL_SAMPLES_PASSED, 
		/// indexmust be zero. 
		/// If target is GL_ANY_SAMPLES_PASSED, id must be an unused name, or the name of an existing boolean occlusion query 
		/// object.When glBeginQueryIndexed is executed, the query object's samples-passed flag is reset to GL_FALSE. Subsequent 
		/// renderingcauses the flag to be set to GL_TRUE if any sample passes the depth test. When glEndQueryIndexed is executed, 
		/// thesamples-passed flag is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. When target is GL_ANY_SAMPLES_PASSED, index must be zero. 
		/// If target is GL_PRIMITIVES_GENERATED, id must be an unused name, or the name of an existing primitive query object 
		/// previouslybound to the GL_PRIMITIVES_GENERATED query binding. When glBeginQueryIndexed is executed, the query object's 
		/// primitives-generatedcounter is reset to 0. Subsequent rendering will increment the counter once for every vertex that is 
		/// emittedfrom the geometry shader to the stream given by index, or from the vertex shader if index is zero and no geometry 
		/// shaderis present. When glEndQueryIndexed is executed, the primitives-generated counter for stream index is assigned to 
		/// thequery object's result value. This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. When 
		/// targetis GL_PRIMITIVES_GENERATED, index must be less than the value of GL_MAX_VERTEX_STREAMS. 
		/// If target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, id must be an unused name, or the name of an existing primitive 
		/// queryobject previously bound to the GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN query binding. When glBeginQueryIndexed is 
		/// executed,the query object's primitives-written counter for the stream specified by index is reset to 0. Subsequent 
		/// renderingwill increment the counter once for every vertex that is written into the bound transform feedback buffer(s) 
		/// forstream index. If transform feedback mode is not activated between the call to glBeginQueryIndexed and 
		/// glEndQueryIndexed,the counter will not be incremented. When glEndQueryIndexed is executed, the primitives-written 
		/// counterfor stream index is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. When target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, index must be less 
		/// thanthe value of GL_MAX_VERTEX_STREAMS. 
		/// If target is GL_TIME_ELAPSED, id must be an unused name, or the name of an existing timer query object previously bound 
		/// tothe GL_TIME_ELAPSED query binding. When glBeginQueryIndexed is executed, the query object's time counter is reset to 
		/// 0.When glEndQueryIndexed is executed, the elapsed server time that has passed since the call to glBeginQueryIndexed is 
		/// writteninto the query object's time counter. This value can be queried by calling glGetQueryObject with 
		/// pnameGL_QUERY_RESULT.When target is GL_TIME_ELAPSED, index must be zero. 
		/// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has 
		/// completedand the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately 
		/// availableor if the rendering is not yet complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the accepted tokens. 
		/// - GL_INVALID_VALUE is generated if index is greater than the query target-specific maximum. 
		/// - GL_INVALID_OPERATION is generated if glBeginQueryIndexed is executed while a query object of the same target is already 
		///   active.
		/// - GL_INVALID_OPERATION is generated if glEndQueryIndexed is executed when a query object of the same target is not active. 
		/// - GL_INVALID_OPERATION is generated if id is 0. 
		/// - GL_INVALID_OPERATION is generated if id is the name of an already active query object. 
		/// - GL_INVALID_OPERATION is generated if id refers to an existing query object whose type does not does not match target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
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
		/// Thesymbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the query target upon which to begin the query. 
		/// </param>
		/// <remarks>
		/// glBeginQueryIndexed and glEndQueryIndexed delimit the boundaries of a query object. query must be a name previously 
		/// returnedfrom a call to glGenQueries. If a query object with name id does not yet exist it is created with the type 
		/// determinedby target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is 
		/// asfollows. 
		/// index specifies the index of the query target and must be between a target-specific maximum. 
		/// If target is GL_SAMPLES_PASSED, id must be an unused name, or the name of an existing occlusion query object. When 
		/// glBeginQueryIndexedis executed, the query object's samples-passed counter is reset to 0. Subsequent rendering will 
		/// incrementthe counter for every sample that passes the depth test. If the value of GL_SAMPLE_BUFFERS is 0, then the 
		/// samples-passedcount is incremented by 1 for each fragment. If the value of GL_SAMPLE_BUFFERS is 1, then the 
		/// samples-passedcount is incremented by the number of samples whose coverage bit is set. However, implementations, at 
		/// theirdiscression may instead increase the samples-passed count by the value of GL_SAMPLES if any sample in the fragment 
		/// iscovered. When glEndQueryIndexed is executed, the samples-passed counter is assigned to the query object's result 
		/// value.This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. When target is GL_SAMPLES_PASSED, 
		/// indexmust be zero. 
		/// If target is GL_ANY_SAMPLES_PASSED, id must be an unused name, or the name of an existing boolean occlusion query 
		/// object.When glBeginQueryIndexed is executed, the query object's samples-passed flag is reset to GL_FALSE. Subsequent 
		/// renderingcauses the flag to be set to GL_TRUE if any sample passes the depth test. When glEndQueryIndexed is executed, 
		/// thesamples-passed flag is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. When target is GL_ANY_SAMPLES_PASSED, index must be zero. 
		/// If target is GL_PRIMITIVES_GENERATED, id must be an unused name, or the name of an existing primitive query object 
		/// previouslybound to the GL_PRIMITIVES_GENERATED query binding. When glBeginQueryIndexed is executed, the query object's 
		/// primitives-generatedcounter is reset to 0. Subsequent rendering will increment the counter once for every vertex that is 
		/// emittedfrom the geometry shader to the stream given by index, or from the vertex shader if index is zero and no geometry 
		/// shaderis present. When glEndQueryIndexed is executed, the primitives-generated counter for stream index is assigned to 
		/// thequery object's result value. This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. When 
		/// targetis GL_PRIMITIVES_GENERATED, index must be less than the value of GL_MAX_VERTEX_STREAMS. 
		/// If target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, id must be an unused name, or the name of an existing primitive 
		/// queryobject previously bound to the GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN query binding. When glBeginQueryIndexed is 
		/// executed,the query object's primitives-written counter for the stream specified by index is reset to 0. Subsequent 
		/// renderingwill increment the counter once for every vertex that is written into the bound transform feedback buffer(s) 
		/// forstream index. If transform feedback mode is not activated between the call to glBeginQueryIndexed and 
		/// glEndQueryIndexed,the counter will not be incremented. When glEndQueryIndexed is executed, the primitives-written 
		/// counterfor stream index is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. When target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, index must be less 
		/// thanthe value of GL_MAX_VERTEX_STREAMS. 
		/// If target is GL_TIME_ELAPSED, id must be an unused name, or the name of an existing timer query object previously bound 
		/// tothe GL_TIME_ELAPSED query binding. When glBeginQueryIndexed is executed, the query object's time counter is reset to 
		/// 0.When glEndQueryIndexed is executed, the elapsed server time that has passed since the call to glBeginQueryIndexed is 
		/// writteninto the query object's time counter. This value can be queried by calling glGetQueryObject with 
		/// pnameGL_QUERY_RESULT.When target is GL_TIME_ELAPSED, index must be zero. 
		/// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has 
		/// completedand the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately 
		/// availableor if the rendering is not yet complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the accepted tokens. 
		/// - GL_INVALID_VALUE is generated if index is greater than the query target-specific maximum. 
		/// - GL_INVALID_OPERATION is generated if glBeginQueryIndexed is executed while a query object of the same target is already 
		///   active.
		/// - GL_INVALID_OPERATION is generated if glEndQueryIndexed is executed when a query object of the same target is not active. 
		/// - GL_INVALID_OPERATION is generated if id is 0. 
		/// - GL_INVALID_OPERATION is generated if id is the name of an already active query object. 
		/// - GL_INVALID_OPERATION is generated if id refers to an existing query object whose type does not does not match target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
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
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEGL_PRIMITIVES_GENERATED,GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or 
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
		/// <remarks>
		/// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and 
		/// index.index specifies the index of the query object target and must be between zero and a target-specific maxiumum. 
		/// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active 
		/// queryfor the specified index of target, or zero if no query is active, will be placed in params. If pname is 
		/// GL_QUERY_COUNTER_BITS,the implementation-dependent number of bits used to hold the result of queries for target is 
		/// returnedin params. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the target-specific maximum. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.IsQuery"/>
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
