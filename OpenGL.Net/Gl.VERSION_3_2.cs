
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
		/// Value of GL_CONTEXT_CORE_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_CONTEXT_COMPATIBILITY_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_LINES_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_LINES_ADJACENCY_ARB")]
		[AliasOf("GL_LINES_ADJACENCY_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int LINES_ADJACENCY = 0x000A;

		/// <summary>
		/// Value of GL_LINE_STRIP_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_LINE_STRIP_ADJACENCY_ARB")]
		[AliasOf("GL_LINE_STRIP_ADJACENCY_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int LINE_STRIP_ADJACENCY = 0x000B;

		/// <summary>
		/// Value of GL_TRIANGLES_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_TRIANGLES_ADJACENCY_ARB")]
		[AliasOf("GL_TRIANGLES_ADJACENCY_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int TRIANGLES_ADJACENCY = 0x000C;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
		[AliasOf("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int TRIANGLE_STRIP_ADJACENCY = 0x000D;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps from 
		/// the geometry shader. The value must be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER symbol.
		/// </summary>
		[AliasOf("GL_GEOMETRY_SHADER_ARB")]
		[AliasOf("GL_GEOMETRY_SHADER_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int GEOMETRY_SHADER = 0x8DD9;

		/// <summary>
		/// Gl.GetProgram: params returns the maximum number of vertices that the geometry shader in program will output.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_VERTICES_OUT = 0x8916;

		/// <summary>
		/// Gl.GetProgram: params returns a symbolic constant indicating the primitive type accepted as input to the geometry shader 
		/// contained in program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_INPUT_TYPE = 0x8917;

		/// <summary>
		/// Gl.GetProgram: params returns a symbolic constant indicating the primitive type that will be output by the geometry 
		/// shader contained in program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_OUTPUT_TYPE = 0x8918;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that can be 
		/// held in uniform variable storage for a geometry shader. The value must be at least 1024. See Gl.Uniform.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_VERTICES symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of components of output written by a vertex shader, which must be at 
		/// least 64.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of components of inputs read by a geometry shader, which must be at 
		/// least 64.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of components of outputs written by a geometry shader, which must be 
		/// at least 128.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader, which must 
		/// be at least 128.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

		/// <summary>
		/// Value of GL_CONTEXT_PROFILE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int CONTEXT_PROFILE_MASK = 0x9126;

		/// <summary>
		/// Gl.Enable: if enabled, the -wc≤zc≤wc plane equation is ignored by view volume clipping (effectively, there is no near or 
		/// far plane clipping). See Gl.DepthRange.
		/// </summary>
		[AliasOf("GL_DEPTH_CLAMP_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_depth_clamp")]
		[RequiredByFeature("GL_NV_depth_clamp")]
		public const int DEPTH_CLAMP = 0x864F;

		/// <summary>
		/// Value of GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

		/// <summary>
		/// Value of GL_FIRST_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_FIRST_VERTEX_CONVENTION_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int FIRST_VERTEX_CONVENTION = 0x8E4D;

		/// <summary>
		/// Value of GL_LAST_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_LAST_VERTEX_CONVENTION_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int LAST_VERTEX_CONVENTION = 0x8E4E;

		/// <summary>
		/// Gl.Get: data returns one value, the currently selected provoking vertex convention. The initial value is 
		/// Gl.LAST_VERTEX_CONVENTION. See Gl.ProvokingVertex.
		/// </summary>
		[AliasOf("GL_PROVOKING_VERTEX_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int PROVOKING_VERTEX = 0x8E4F;

		/// <summary>
		/// Gl.Enable: if enabled, cubemap textures are sampled such that when linearly sampling from the border between two 
		/// adjacent faces, texels from both faces are used to generate the final sample value. When disabled, texels from only a 
		/// single face are used to construct the final sample value.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_AMD_seamless_cubemap_per_texture")]
		[RequiredByFeature("GL_ARB_seamless_cube_map")]
		[RequiredByFeature("GL_ARB_seamless_cubemap_per_texture")]
		public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum Gl.WaitSync timeout interval.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;

		/// <summary>
		/// Value of GL_OBJECT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int OBJECT_TYPE = 0x9112;

		/// <summary>
		/// Value of GL_SYNC_CONDITION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_CONDITION = 0x9113;

		/// <summary>
		/// Value of GL_SYNC_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_STATUS = 0x9114;

		/// <summary>
		/// Value of GL_SYNC_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_FLAGS = 0x9115;

		/// <summary>
		/// Value of GL_SYNC_FENCE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_FENCE = 0x9116;

		/// <summary>
		/// Value of GL_SYNC_GPU_COMMANDS_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

		/// <summary>
		/// Value of GL_UNSIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int UNSIGNALED = 0x9118;

		/// <summary>
		/// Value of GL_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SIGNALED = 0x9119;

		/// <summary>
		/// Value of GL_ALREADY_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int ALREADY_SIGNALED = 0x911A;

		/// <summary>
		/// Value of GL_TIMEOUT_EXPIRED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int TIMEOUT_EXPIRED = 0x911B;

		/// <summary>
		/// Value of GL_CONDITION_SATISFIED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int CONDITION_SATISFIED = 0x911C;

		/// <summary>
		/// Value of GL_WAIT_FAILED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int WAIT_FAILED = 0x911D;

		/// <summary>
		/// Value of GL_TIMEOUT_IGNORED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// Value of GL_SYNC_FLUSH_COMMANDS_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_SAMPLE_POSITION symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_POSITION_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_POSITION = 0x8E50;

		/// <summary>
		/// Gl.Enable: if enabled, the sample coverage mask generated for a fragment during rasterization will be ANDed with the 
		/// value of Gl.SAMPLE_MASK_VALUE before shading occurs. See Gl.SampleMaski.
		/// </summary>
		[AliasOf("GL_SAMPLE_MASK_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK = 0x8E51;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_MASK_VALUE_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK_VALUE = 0x8E52;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of sample mask words.
		/// </summary>
		[AliasOf("GL_MAX_SAMPLE_MASK_WORDS_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int MAX_SAMPLE_MASK_WORDS = 0x8E59;

		/// <summary>
		/// Value of GL_TEXTURE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_internalformat_sample_query")]
		public const int TEXTURE_2D_MULTISAMPLE = 0x9100;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

		/// <summary>
		/// Value of GL_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		[RequiredByFeature("GL_NV_internalformat_sample_query")]
		public const int TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_2D_MULTISAMPLE. 
		/// The initial value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY. The initial value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

		/// <summary>
		/// Value of GL_TEXTURE_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_SAMPLES = 0x9106;

		/// <summary>
		/// Value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

		/// <summary>
		/// Value of GL_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLER_2D_MULTISAMPLE = 0x9108;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int INT_SAMPLER_2D_MULTISAMPLE = 0x9109;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;

		/// <summary>
		/// Value of GL_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of samples in a color multisample texture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of samples in a multisample depth or depth-stencil texture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of samples supported in integer format multisample buffers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_INTEGER_SAMPLES = 0x9110;

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertex != null, "pglDrawElementsBaseVertex not implemented");
			Delegates.pglDrawElementsBaseVertex((int)mode, count, (int)type, indices, basevertex);
			CallLog("glDrawElementsBaseVertex({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
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
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="end"/> &lt; <paramref name="start"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertex != null, "pglDrawRangeElementsBaseVertex not implemented");
			Delegates.pglDrawRangeElementsBaseVertex((int)mode, start, end, count, (int)type, indices, basevertex);
			CallLog("glDrawRangeElementsBaseVertex({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
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
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="end"/> &lt; <paramref name="start"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertex(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertex != null, "pglDrawElementsInstancedBaseVertex not implemented");
			Delegates.pglDrawElementsInstancedBaseVertex((int)mode, count, (int)type, indices, instancecount, basevertex);
			CallLog("glDrawElementsInstancedBaseVertex({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the <paramref name="count"/>, <paramref name="indices"/> and <paramref name="basevertex"/> arrays.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a pointer to the location where the base vertices are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void MultiDrawElementsBaseVertex(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 drawcount, Int32[] basevertex)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				fixed (Int32* p_basevertex = basevertex)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsBaseVertex != null, "pglMultiDrawElementsBaseVertex not implemented");
					Delegates.pglMultiDrawElementsBaseVertex((int)mode, p_count, (int)type, p_indices, drawcount, p_basevertex);
					CallLog("glMultiDrawElementsBaseVertex({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, drawcount, basevertex);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specifiy the vertex to be used as the source of data for flat shaded varyings
		/// </summary>
		/// <param name="provokeMode">
		/// Specifies the vertex to be used as the source of data for flat shaded varyings.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="provokeMode"/> is not an accepted value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		public static void ProvokingVertex(int provokeMode)
		{
			Debug.Assert(Delegates.pglProvokingVertex != null, "pglProvokingVertex not implemented");
			Delegates.pglProvokingVertex(provokeMode);
			CallLog("glProvokingVertex({0})", provokeMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// create a new sync object and insert it into the GL command stream
		/// </summary>
		/// <param name="condition">
		/// Specifies the condition that must be met to set the sync object's state to signaled. <paramref name="condition"/> must 
		/// be Gl.SYNC_GPU_COMMANDS_COMPLETE.
		/// </param>
		/// <param name="flags">
		/// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for 
		/// this operation and <paramref name="flags"/> must be zero.<paramref name="flags"/> is a placeholder for anticipated 
		/// future extensions of fence sync object capabilities.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="condition"/> is not Gl.SYNC_GPU_COMMANDS_COMPLETE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> is not zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Additionally, if Gl.FenceSync fails, it will return zero.
		/// </exception>
		/// <seealso cref="Gl.DeleteSync"/>
		/// <seealso cref="Gl.GetSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static int FenceSync(int condition, uint flags)
		{
			int retValue;

			Debug.Assert(Delegates.pglFenceSync != null, "pglFenceSync not implemented");
			retValue = Delegates.pglFenceSync(condition, flags);
			CallLog("glFenceSync({0}, {1}) = {2}", condition, flags, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// determine if a name corresponds to a sync object
		/// </summary>
		/// <param name="sync">
		/// Specifies a value that may be the name of a sync object.
		/// </param>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		/// <seealso cref="Gl.DeleteSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static bool IsSync(int sync)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSync != null, "pglIsSync not implemented");
			retValue = Delegates.pglIsSync(sync);
			CallLog("glIsSync({0}) = {1}", sync, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// delete a sync object
		/// </summary>
		/// <param name="sync">
		/// The sync object to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is neither zero or the name of a sync object.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void DeleteSync(int sync)
		{
			Debug.Assert(Delegates.pglDeleteSync != null, "pglDeleteSync not implemented");
			Delegates.pglDeleteSync(sync);
			CallLog("glDeleteSync({0})", sync);
			DebugCheckErrors();
		}

		/// <summary>
		/// block and wait for a sync object to become signaled
		/// </summary>
		/// <param name="sync">
		/// The sync object whose status to wait on.
		/// </param>
		/// <param name="flags">
		/// A bitfield controlling the command flushing behavior. <paramref name="flags"/> may be Gl.SYNC_FLUSH_COMMANDS_BIT.
		/// </param>
		/// <param name="timeout">
		/// The timeout, specified in nanoseconds, for which the implementation should wait for <paramref name="sync"/> to become 
		/// signaled.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of an existing sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains any unsupported flag.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.IsSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static int ClientWaitSync(int sync, uint flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.pglClientWaitSync != null, "pglClientWaitSync not implemented");
			retValue = Delegates.pglClientWaitSync(sync, flags, timeout);
			CallLog("glClientWaitSync({0}, {1}, {2}) = {3}", sync, flags, timeout, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// instruct the GL server to block until the specified sync object becomes signaled
		/// </summary>
		/// <param name="sync">
		/// Specifies the sync object whose status to wait on.
		/// </param>
		/// <param name="flags">
		/// A bitfield controlling the command flushing behavior. <paramref name="flags"/> may be zero.
		/// </param>
		/// <param name="timeout">
		/// Specifies the timeout that the server should wait before continuing. <paramref name="timeout"/> must be 
		/// Gl.TIMEOUT_IGNORED.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of a sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> is not zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="timeout"/> is not Gl.TIMEOUT_IGNORED.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void WaitSync(int sync, uint flags, UInt64 timeout)
		{
			Debug.Assert(Delegates.pglWaitSync != null, "pglWaitSync not implemented");
			Delegates.pglWaitSync(sync, flags, timeout);
			CallLog("glWaitSync({0}, {1}, {2})", sync, flags, timeout);
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void Get(int pname, Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v(pname, p_data);
					CallLog("glGetInteger64v({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void Get(int pname, out Int64 data)
		{
			unsafe {
				fixed (Int64* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v(pname, p_data);
					CallLog("glGetInteger64v({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the properties of a sync object
		/// </summary>
		/// <param name="sync">
		/// Specifies the sync object whose properties to query.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync"/>.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given in <paramref name="values"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of an variable to receive the number of integers placed in <paramref name="values"/>.
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array to receive the values of the queried parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of a sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void GetSync(int sync, int pname, out Int32 length, Int32[] values)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
					Delegates.pglGetSynciv(sync, pname, (Int32)values.Length, p_length, p_values);
					CallLog("glGetSynciv({0}, {1}, {2}, {3}, {4})", sync, pname, values.Length, length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void Get(int target, UInt32 index, Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
					Delegates.pglGetInteger64i_v(target, index, p_data);
					CallLog("glGetInteger64i_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void Get(int target, UInt32 index, out Int64 data)
		{
			unsafe {
				fixed (Int64* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
					Delegates.pglGetInteger64i_v(target, index, p_data);
					CallLog("glGetInteger64i_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferParameteriv and Gl.GetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void GetBufferParameter(BufferTargetARB target, int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameteri64v != null, "pglGetBufferParameteri64v not implemented");
					Delegates.pglGetBufferParameteri64v((int)target, pname, p_params);
					CallLog("glGetBufferParameteri64v({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptGl.NamedFramebufferTexture.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by all commands accepting a <paramref name="target"/> parameter if it is not one of the 
		/// accepted framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="target"/> parameter if zero is bound to 
		/// that target.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferTexture if <paramref name="framebuffer"/> is not the name of an 
		/// existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero or the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="level"/> is not a supported 
		/// texture level for <paramref name="texture"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.FramebufferTexture3D if <paramref name="texture"/> is not zero and <paramref 
		/// name="layer"/> is larger than the value of Gl.MAX_3D_TEXTURE_SIZE minus one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="textarget"/> parameter if <paramref 
		/// name="texture"/> is not zero, and <paramref name="textarget"/> and the effective target of <paramref name="texture"/> 
		/// are not compatible.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void FramebufferTexture(int target, int attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture != null, "pglFramebufferTexture not implemented");
			Delegates.pglFramebufferTexture(target, attachment, texture, level);
			CallLog("glFramebufferTexture({0}, {1}, {2}, {3})", target, attachment, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// establish the data storage, format, dimensions, and number of samples of a multisample texture's image
		/// </summary>
		/// <param name="target">
		/// Specifies the target of the operation. <paramref name="target"/> must be Gl.TEXTURE_2D_MULTISAMPLE or 
		/// Gl.PROXY_TEXTURE_2D_MULTISAMPLE.
		/// </param>
		/// <param name="samples">
		/// The number of samples in the multisample texture's image.
		/// </param>
		/// <param name="internalformat">
		/// The internal format to be used to store the multisample texture's image. <paramref name="internalformat"/> must specify 
		/// a color-renderable, depth-renderable, or stencil-renderable format.
		/// </param>
		/// <param name="width">
		/// The width of the multisample texture's image, in texels.
		/// </param>
		/// <param name="height">
		/// The height of the multisample texture's image, in texels.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a depth- or stencil-renderable format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_DEPTH_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a color-renderable format and <paramref 
		/// name="samples"/> is greater than the value of Gl.MAX_COLOR_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> negative or is greater 
		/// than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is greater than Gl.MAX_SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public static void TexImage2DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexImage2DMultisample != null, "pglTexImage2DMultisample not implemented");
			Delegates.pglTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
			CallLog("glTexImage2DMultisample({0}, {1}, {2}, {3}, {4}, {5})", target, samples, internalformat, width, height, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// establish the data storage, format, dimensions, and number of samples of a multisample texture's image
		/// </summary>
		/// <param name="target">
		/// Specifies the target of the operation. <paramref name="target"/> must be Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or 
		/// Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="samples">
		/// The number of samples in the multisample texture's image.
		/// </param>
		/// <param name="internalformat">
		/// The internal format to be used to store the multisample texture's image. <paramref name="internalformat"/> must specify 
		/// a color-renderable, depth-renderable, or stencil-renderable format.
		/// </param>
		/// <param name="width">
		/// The width of the multisample texture's image, in texels.
		/// </param>
		/// <param name="height">
		/// The height of the multisample texture's image, in texels.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a depth- or stencil-renderable format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_DEPTH_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a color-renderable format and <paramref 
		/// name="samples"/> is greater than the value of Gl.MAX_COLOR_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> negative or is greater 
		/// than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="depth"/> is negative or is greater than Gl.MAX_ARRAY_TEXTURE_LAYERS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is greater than Gl.MAX_SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public static void TexImage3DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexImage3DMultisample != null, "pglTexImage3DMultisample not implemented");
			Delegates.pglTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
			CallLog("glTexImage3DMultisample({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, samples, internalformat, width, height, depth, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the location of a sample
		/// </summary>
		/// <param name="pname">
		/// Specifies the sample parameter name. <paramref name="pname"/> must be Gl.SAMPLE_POSITION.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the sample whose position to query.
		/// </param>
		/// <param name="val">
		/// Specifies the address of an array to receive the position of the sample.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one Gl.SAMPLE_POSITION.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public static void GetMultisample(int pname, UInt32 index, float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					Debug.Assert(Delegates.pglGetMultisamplefv != null, "pglGetMultisamplefv not implemented");
					Delegates.pglGetMultisamplefv(pname, index, p_val);
					CallLog("glGetMultisamplefv({0}, {1}, {2})", pname, index, val);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the value of a sub-word of the sample mask
		/// </summary>
		/// <param name="maskNumber">
		/// Specifies which 32-bit sub-word of the sample mask to update.
		/// </param>
		/// <param name="mask">
		/// Specifies the new value of the mask sub-word.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maskIndex"/> is greater than or equal to the value of 
		/// Gl.MAX_SAMPLE_MASK_WORDS.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public static void SampleMask(UInt32 maskNumber, uint mask)
		{
			Debug.Assert(Delegates.pglSampleMaski != null, "pglSampleMaski not implemented");
			Delegates.pglSampleMaski(maskNumber, mask);
			CallLog("glSampleMaski({0}, {1})", maskNumber, mask);
			DebugCheckErrors();
		}

	}

}
