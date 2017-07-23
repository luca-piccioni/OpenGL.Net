
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_CONTEXT_CORE_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_COMPATIBILITY_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_LINES_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_LINES_ADJACENCY_ARB")]
		[AliasOf("GL_LINES_ADJACENCY_EXT")]
		[AliasOf("GL_LINES_ADJACENCY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int LINES_ADJACENCY = 0x000A;

		/// <summary>
		/// [GL] Value of GL_LINE_STRIP_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_LINE_STRIP_ADJACENCY_ARB")]
		[AliasOf("GL_LINE_STRIP_ADJACENCY_EXT")]
		[AliasOf("GL_LINE_STRIP_ADJACENCY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int LINE_STRIP_ADJACENCY = 0x000B;

		/// <summary>
		/// [GL] Value of GL_TRIANGLES_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_TRIANGLES_ADJACENCY_ARB")]
		[AliasOf("GL_TRIANGLES_ADJACENCY_EXT")]
		[AliasOf("GL_TRIANGLES_ADJACENCY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int TRIANGLES_ADJACENCY = 0x000C;

		/// <summary>
		/// [GL] Value of GL_TRIANGLE_STRIP_ADJACENCY symbol.
		/// </summary>
		[AliasOf("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
		[AliasOf("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
		[AliasOf("GL_TRIANGLE_STRIP_ADJACENCY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int TRIANGLE_STRIP_ADJACENCY = 0x000D;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
		/// texture maps from the geometry shader. The value must be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_SHADER symbol.
		/// </summary>
		[AliasOf("GL_GEOMETRY_SHADER_ARB")]
		[AliasOf("GL_GEOMETRY_SHADER_EXT")]
		[AliasOf("GL_GEOMETRY_SHADER_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int GEOMETRY_SHADER = 0x8DD9;

		/// <summary>
		/// [GL4] Gl.GetProgram: params returns the maximum number of vertices that the geometry shader in program will output.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		public const int GEOMETRY_VERTICES_OUT = 0x8916;

		/// <summary>
		/// [GL4] Gl.GetProgram: params returns a symbolic constant indicating the primitive type accepted as input to the geometry 
		/// shader contained in program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		public const int GEOMETRY_INPUT_TYPE = 0x8917;

		/// <summary>
		/// [GL4] Gl.GetProgram: params returns a symbolic constant indicating the primitive type that will be output by the 
		/// geometry shader contained in program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		public const int GEOMETRY_OUTPUT_TYPE = 0x8918;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean 
		/// values that can be held in uniform variable storage for a geometry shader. The value must be at least 1024. See 
		/// Gl.Uniform.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vertices emit by a geometry shader, which must be at 
		/// least 256.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum total number of components of active outputs for all vertices 
		/// written by a geometry shader, which must be at least 1024.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
		[AliasOf("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of output written by a vertex shader, 
		/// which must be at least 64.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of inputs read by a geometry shader, 
		/// which must be at least 64.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of outputs written by a geometry shader, 
		/// which must be at least 128.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader, which 
		/// must be at least 128.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader, 
		/// which must be at least 60.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_PROFILE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int CONTEXT_PROFILE_MASK = 0x9126;

		/// <summary>
		/// [GL] Value of GL_DEPTH_CLAMP symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_CLAMP_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_depth_clamp", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_depth_clamp")]
		public const int DEPTH_CLAMP = 0x864F;

		/// <summary>
		/// [GL] Value of GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

		/// <summary>
		/// [GL] Value of GL_FIRST_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_FIRST_VERTEX_CONVENTION_EXT")]
		[AliasOf("GL_FIRST_VERTEX_CONVENTION_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int FIRST_VERTEX_CONVENTION = 0x8E4D;

		/// <summary>
		/// [GL] Value of GL_LAST_VERTEX_CONVENTION symbol.
		/// </summary>
		[AliasOf("GL_LAST_VERTEX_CONVENTION_EXT")]
		[AliasOf("GL_LAST_VERTEX_CONVENTION_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int LAST_VERTEX_CONVENTION = 0x8E4E;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the currently selected provoking vertex convention. The initial value is 
		/// Gl.LAST_VERTEX_CONVENTION. See Gl.ProvokingVertex.
		/// </summary>
		[AliasOf("GL_PROVOKING_VERTEX_EXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int PROVOKING_VERTEX = 0x8E4F;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CUBE_MAP_SEAMLESS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_AMD_seamless_cubemap_per_texture")]
		[RequiredByFeature("GL_ARB_seamless_cube_map", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_seamless_cubemap_per_texture", Api = "gl|glcore")]
		public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum Gl.WaitSync timeout interval.
		/// </summary>
		[AliasOf("GL_MAX_SERVER_WAIT_TIMEOUT_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;

		/// <summary>
		/// [GL] Value of GL_OBJECT_TYPE symbol.
		/// </summary>
		[AliasOf("GL_OBJECT_TYPE_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int OBJECT_TYPE = 0x9112;

		/// <summary>
		/// [GL] Value of GL_SYNC_CONDITION symbol.
		/// </summary>
		[AliasOf("GL_SYNC_CONDITION_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SYNC_CONDITION = 0x9113;

		/// <summary>
		/// [GL] Value of GL_SYNC_STATUS symbol.
		/// </summary>
		[AliasOf("GL_SYNC_STATUS_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SYNC_STATUS = 0x9114;

		/// <summary>
		/// [GL] Value of GL_SYNC_FLAGS symbol.
		/// </summary>
		[AliasOf("GL_SYNC_FLAGS_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SYNC_FLAGS = 0x9115;

		/// <summary>
		/// [GL] Value of GL_SYNC_FENCE symbol.
		/// </summary>
		[AliasOf("GL_SYNC_FENCE_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SYNC_FENCE = 0x9116;

		/// <summary>
		/// [GL] Value of GL_SYNC_GPU_COMMANDS_COMPLETE symbol.
		/// </summary>
		[AliasOf("GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

		/// <summary>
		/// [GL] Value of GL_UNSIGNALED symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNALED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int UNSIGNALED = 0x9118;

		/// <summary>
		/// [GL] Value of GL_SIGNALED symbol.
		/// </summary>
		[AliasOf("GL_SIGNALED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int SIGNALED = 0x9119;

		/// <summary>
		/// [GL] Value of GL_ALREADY_SIGNALED symbol.
		/// </summary>
		[AliasOf("GL_ALREADY_SIGNALED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int ALREADY_SIGNALED = 0x911A;

		/// <summary>
		/// [GL] Value of GL_TIMEOUT_EXPIRED symbol.
		/// </summary>
		[AliasOf("GL_TIMEOUT_EXPIRED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int TIMEOUT_EXPIRED = 0x911B;

		/// <summary>
		/// [GL] Value of GL_CONDITION_SATISFIED symbol.
		/// </summary>
		[AliasOf("GL_CONDITION_SATISFIED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int CONDITION_SATISFIED = 0x911C;

		/// <summary>
		/// [GL] Value of GL_WAIT_FAILED symbol.
		/// </summary>
		[AliasOf("GL_WAIT_FAILED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const int WAIT_FAILED = 0x911D;

		/// <summary>
		/// [GL] Value of GL_TIMEOUT_IGNORED symbol.
		/// </summary>
		[AliasOf("GL_TIMEOUT_IGNORED_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// [GL] Value of GL_SYNC_FLUSH_COMMANDS_BIT symbol.
		/// </summary>
		[AliasOf("GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_POSITION symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_POSITION_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_POSITION = 0x8E50;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_MASK symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_MASK_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK = 0x8E51;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_MASK_VALUE symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_MASK_VALUE_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK_VALUE = 0x8E52;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of sample mask words.
		/// </summary>
		[AliasOf("GL_MAX_SAMPLE_MASK_WORDS_NV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int MAX_SAMPLE_MASK_WORDS = 0x8E59;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int TEXTURE_2D_MULTISAMPLE = 0x9100;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public const int TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

		/// <summary>
		/// [GL] Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target 
		/// Gl.TEXTURE_2D_MULTISAMPLE. The initial value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY. The initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public const int TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

		/// <summary>
		/// [GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the number of samples of the texture image.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int TEXTURE_SAMPLES = 0x9106;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int SAMPLER_2D_MULTISAMPLE = 0x9108;

		/// <summary>
		/// [GL] Value of GL_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int INT_SAMPLER_2D_MULTISAMPLE = 0x9109;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public const int SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;

		/// <summary>
		/// [GL] Value of GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public const int INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples in a color multisample texture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the maximum number of samples in a multisample depth or depth-stencil texture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples supported in integer format multisample 
		/// buffers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public const int MAX_INTEGER_SAMPLES = 0x9110;

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] render primitives from array data with a per-element offset
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawElementsBaseVertexEXT")]
		[AliasOf("glDrawElementsBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
		public static void DrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertex != null, "pglDrawElementsBaseVertex not implemented");
			Delegates.pglDrawElementsBaseVertex((Int32)mode, count, (Int32)type, indices, basevertex);
			LogCommand("glDrawElementsBaseVertex", null, mode, count, type, indices, basevertex			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] render primitives from array data with a per-element offset
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawElementsBaseVertexEXT")]
		[AliasOf("glDrawElementsBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
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
		/// <para>
		/// [GL4|GLES3.2] render primitives from array data with a per-element offset
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="end"/> &lt; <paramref name="start"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawRangeElementsBaseVertexEXT")]
		[AliasOf("glDrawRangeElementsBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertex != null, "pglDrawRangeElementsBaseVertex not implemented");
			Delegates.pglDrawRangeElementsBaseVertex((Int32)mode, start, end, count, (Int32)type, indices, basevertex);
			LogCommand("glDrawRangeElementsBaseVertex", null, mode, start, end, count, type, indices, basevertex			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] render primitives from array data with a per-element offset
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="end"/> &lt; <paramref name="start"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawRangeElementsBaseVertexEXT")]
		[AliasOf("glDrawRangeElementsBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
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
		/// <para>
		/// [GL4|GLES3.2] render multiple instances of a set of primitives from array data with a per-element offset
		/// </para>
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
		/// <param name="primcount">
		/// Specifies the number of instances of the indexed geometry that should be drawn.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawElementsInstancedBaseVertexEXT")]
		[AliasOf("glDrawElementsInstancedBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertex != null, "pglDrawElementsInstancedBaseVertex not implemented");
			Delegates.pglDrawElementsInstancedBaseVertex((Int32)mode, count, (Int32)type, indices, primcount, basevertex);
			LogCommand("glDrawElementsInstancedBaseVertex", null, mode, count, type, indices, primcount, basevertex			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] render multiple instances of a set of primitives from array data with a per-element offset
		/// </para>
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
		/// <param name="primcount">
		/// Specifies the number of instances of the indexed geometry that should be drawn.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[AliasOf("glDrawElementsInstancedBaseVertexEXT")]
		[AliasOf("glDrawElementsInstancedBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices, Int32 primcount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// [GL4] render multiple sets of primitives by specifying indices of array data elements and an index to apply to each 
		/// index
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glMultiDrawElementsBaseVertexEXT")]
		[AliasOf("glMultiDrawElementsBaseVertexOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
		public static void MultiDrawElementsBaseVertex(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 drawcount, Int32[] basevertex)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				fixed (Int32* p_basevertex = basevertex)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsBaseVertex != null, "pglMultiDrawElementsBaseVertex not implemented");
					Delegates.pglMultiDrawElementsBaseVertex((Int32)mode, p_count, (Int32)type, p_indices, drawcount, p_basevertex);
					LogCommand("glMultiDrawElementsBaseVertex", null, mode, count, type, indices, drawcount, basevertex					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] specifiy the vertex to be used as the source of data for flat shaded varyings
		/// </summary>
		/// <param name="provokeMode">
		/// Specifies the vertex to be used as the source of data for flat shaded varyings.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="provokeMode"/> is not an accepted value.
		/// </exception>
		[AliasOf("glProvokingVertexEXT")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public static void ProvokingVertex(VertexProvokingMode provokeMode)
		{
			Debug.Assert(Delegates.pglProvokingVertex != null, "pglProvokingVertex not implemented");
			Delegates.pglProvokingVertex((Int32)provokeMode);
			LogCommand("glProvokingVertex", null, provokeMode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] create a new sync object and insert it into the GL command stream
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="condition"/> is not Gl.SYNC_GPU_COMMANDS_COMPLETE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> is not zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Additionally, if Gl.FenceSync fails, it will return zero.
		/// </exception>
		/// <seealso cref="Gl.DeleteSync"/>
		/// <seealso cref="Gl.GetSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[AliasOf("glFenceSyncAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static Int32 FenceSync(FenceSyncCondition condition, UInt32 flags)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglFenceSync != null, "pglFenceSync not implemented");
			retValue = Delegates.pglFenceSync((Int32)condition, flags);
			LogCommand("glFenceSync", retValue, condition, flags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] determine if a name corresponds to a sync object
		/// </para>
		/// </summary>
		/// <param name="sync">
		/// Specifies a value that may be the name of a sync object.
		/// </param>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		/// <seealso cref="Gl.DeleteSync"/>
		[AliasOf("glIsSyncAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static bool IsSync(Int32 sync)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSync != null, "pglIsSync not implemented");
			retValue = Delegates.pglIsSync(sync);
			LogCommand("glIsSync", retValue, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] delete a sync object
		/// </para>
		/// </summary>
		/// <param name="sync">
		/// The sync object to be deleted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is neither zero or the name of a sync object.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[AliasOf("glDeleteSyncAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void DeleteSync(Int32 sync)
		{
			Debug.Assert(Delegates.pglDeleteSync != null, "pglDeleteSync not implemented");
			Delegates.pglDeleteSync(sync);
			LogCommand("glDeleteSync", null, sync			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] block and wait for a sync object to become signaled
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of an existing sync object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains any unsupported flag.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.IsSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		[AliasOf("glClientWaitSyncAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static SyncStatus ClientWaitSync(Int32 sync, UInt32 flags, UInt64 timeout)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglClientWaitSync != null, "pglClientWaitSync not implemented");
			retValue = Delegates.pglClientWaitSync(sync, flags, timeout);
			LogCommand("glClientWaitSync", (SyncStatus)retValue, sync, flags, timeout			);
			DebugCheckErrors(retValue);

			return ((SyncStatus)retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] instruct the GL server to block until the specified sync object becomes signaled
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of a sync object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> is not zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="timeout"/> is not Gl.TIMEOUT_IGNORED.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[AliasOf("glWaitSyncAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void WaitSync(Int32 sync, UInt32 flags, UInt64 timeout)
		{
			Debug.Assert(Delegates.pglWaitSync != null, "pglWaitSync not implemented");
			Delegates.pglWaitSync(sync, flags, timeout);
			LogCommand("glWaitSync", null, sync, flags, timeout			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[AliasOf("glGetInteger64vAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void Get(Int32 pname, [Out] Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v(pname, p_data);
					LogCommand("glGetInteger64v", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[AliasOf("glGetInteger64vAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void Get(GetPName pname, [Out] Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v((Int32)pname, p_data);
					LogCommand("glGetInteger64v", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[AliasOf("glGetInteger64vAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void Get(Int32 pname, out Int64 data)
		{
			unsafe {
				fixed (Int64* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v(pname, p_data);
					LogCommand("glGetInteger64v", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[AliasOf("glGetInteger64vAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void Get(GetPName pname, out Int64 data)
		{
			unsafe {
				fixed (Int64* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
					Delegates.pglGetInteger64v((Int32)pname, p_data);
					LogCommand("glGetInteger64v", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] query the properties of a sync object
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of a sync object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[AliasOf("glGetSyncivAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void GetSync(Int32 sync, SyncParameterName pname, Int32 bufSize, out Int32 length, [Out] Int32[] values)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
					Delegates.pglGetSynciv(sync, (Int32)pname, bufSize, p_length, p_values);
					LogCommand("glGetSynciv", null, sync, pname, bufSize, length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] query the properties of a sync object
		/// </para>
		/// </summary>
		/// <param name="sync">
		/// Specifies the sync object whose properties to query.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of an variable to receive the number of integers placed in <paramref name="values"/>.
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array to receive the values of the queried parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sync"/> is not the name of a sync object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		[AliasOf("glGetSyncivAPPLE")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		public static void GetSync(Int32 sync, SyncParameterName pname, out Int32 length, [Out] Int32[] values)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
					Delegates.pglGetSynciv(sync, (Int32)pname, (Int32)values.Length, p_length, p_values);
					LogCommand("glGetSynciv", null, sync, pname, values.Length, length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, [Out] Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
					Delegates.pglGetInteger64i_v(target, index, p_data);
					LogCommand("glGetInteger64i_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the value or values of a selected parameter
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
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
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, out Int64 data)
		{
			unsafe {
				fixed (Int64* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
					Delegates.pglGetInteger64i_v(target, index, p_data);
					LogCommand("glGetInteger64i_v", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return parameters of a buffer object
		/// </para>
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferParameteriv and Gl.GetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="value">
		/// Specifies the name of the buffer object parameter to query.
		/// </param>
		/// <param name="data">
		/// Returns the requested parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void GetBufferParameter(BufferTarget target, Int32 value, [Out] Int64[] data)
		{
			unsafe {
				fixed (Int64* p_params = data)
				{
					Debug.Assert(Delegates.pglGetBufferParameteri64v != null, "pglGetBufferParameteri64v not implemented");
					Delegates.pglGetBufferParameteri64v((Int32)target, value, p_params);
					LogCommand("glGetBufferParameteri64v", null, target, value, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] attach a level of a texture object as a logical buffer of a framebuffer object
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by all commands accepting a <paramref name="target"/> parameter if it is not one of the 
		/// accepted framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="target"/> parameter if zero is bound to 
		/// that target.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferTexture if <paramref name="framebuffer"/> is not the name of an 
		/// existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero or the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="level"/> is not a supported 
		/// texture level for <paramref name="texture"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.FramebufferTexture3D if <paramref name="texture"/> is not zero and <paramref 
		/// name="layer"/> is larger than the value of Gl.MAX_3D_TEXTURE_SIZE minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="textarget"/> parameter if <paramref 
		/// name="texture"/> is not zero, and <paramref name="textarget"/> and the effective target of <paramref name="texture"/> 
		/// are not compatible.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		[AliasOf("glFramebufferTextureARB")]
		[AliasOf("glFramebufferTextureEXT")]
		[AliasOf("glFramebufferTextureOES")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture != null, "pglFramebufferTexture not implemented");
			Delegates.pglFramebufferTexture((Int32)target, (Int32)attachment, texture, level);
			LogCommand("glFramebufferTexture", null, target, attachment, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] establish the data storage, format, dimensions, and number of samples of a multisample texture's image
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a depth- or stencil-renderable format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_DEPTH_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a color-renderable format and <paramref 
		/// name="samples"/> is greater than the value of Gl.MAX_COLOR_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> negative or is greater 
		/// than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="samples"/> is greater than the maximum number of samples supported 
		/// for this <paramref name="target"/> and <paramref name="internalformat"/>.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public static void TexImage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexImage2DMultisample != null, "pglTexImage2DMultisample not implemented");
			Delegates.pglTexImage2DMultisample((Int32)target, samples, (Int32)internalformat, width, height, fixedsamplelocations);
			LogCommand("glTexImage2DMultisample", null, target, samples, internalformat, width, height, fixedsamplelocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] establish the data storage, format, dimensions, and number of samples of a multisample texture's image
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a depth- or stencil-renderable format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_DEPTH_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a color-renderable format and <paramref 
		/// name="samples"/> is greater than the value of Gl.MAX_COLOR_TEXTURE_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> negative or is greater 
		/// than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="depth"/> is negative or is greater than Gl.MAX_ARRAY_TEXTURE_LAYERS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="samples"/> is greater than the maximum number of samples supported 
		/// for this <paramref name="target"/> and <paramref name="internalformat"/>.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public static void TexImage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexImage3DMultisample != null, "pglTexImage3DMultisample not implemented");
			Delegates.pglTexImage3DMultisample((Int32)target, samples, (Int32)internalformat, width, height, depth, fixedsamplelocations);
			LogCommand("glTexImage3DMultisample", null, target, samples, internalformat, width, height, depth, fixedsamplelocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] retrieve the location of a sample
		/// </para>
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one Gl.SAMPLE_POSITION.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		[AliasOf("glGetMultisamplefvNV")]
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void GetMultisample(Int32 pname, UInt32 index, [Out] float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					Debug.Assert(Delegates.pglGetMultisamplefv != null, "pglGetMultisamplefv not implemented");
					Delegates.pglGetMultisamplefv(pname, index, p_val);
					LogCommand("glGetMultisamplefv", null, pname, index, val					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] set the value of a sub-word of the sample mask
		/// </para>
		/// </summary>
		/// <param name="maskNumber">
		/// Specifies which 32-bit sub-word of the sample mask to update.
		/// </param>
		/// <param name="mask">
		/// Specifies the new value of the mask sub-word.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maskIndex"/> is greater than or equal to the value of 
		/// Gl.MAX_SAMPLE_MASK_WORDS.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		public static void SampleMask(UInt32 maskNumber, UInt32 mask)
		{
			Debug.Assert(Delegates.pglSampleMaski != null, "pglSampleMaski not implemented");
			Delegates.pglSampleMaski(maskNumber, mask);
			LogCommand("glSampleMaski", null, maskNumber, mask			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawRangeElementsBaseVertex(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsBaseVertex(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount, Int32* basevertex);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
			internal extern static void glProvokingVertex(Int32 mode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
			internal extern static Int32 glFenceSync(Int32 condition, UInt32 flags);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsSync", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsSync(Int32 sync);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
			internal extern static void glDeleteSync(Int32 sync);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
			internal extern static Int32 glClientWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
			internal extern static void glWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
			internal extern static unsafe void glGetInteger64v(Int32 pname, Int64* data);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
			internal extern static unsafe void glGetSynciv(Int32 sync, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
			internal extern static unsafe void glGetInteger64i_v(Int32 target, UInt32 index, Int64* data);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameteri64v(Int32 target, Int32 pname, Int64* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
			internal extern static void glFramebufferTexture(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
			internal extern static void glTexImage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
			internal extern static void glTexImage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
			internal extern static unsafe void glGetMultisamplefv(Int32 pname, UInt32 index, float* val);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
			internal extern static void glSampleMaski(UInt32 maskNumber, UInt32 mask);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDrawElementsBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[AliasOf("glDrawElementsBaseVertex")]
			[AliasOf("glDrawElementsBaseVertexEXT")]
			[AliasOf("glDrawElementsBaseVertexOES")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			[ThreadStatic]
			internal static glDrawElementsBaseVertex pglDrawElementsBaseVertex;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDrawRangeElementsBaseVertex(Int32 mode, UInt32 start, UInt32 end, Int32 count, Int32 type, IntPtr indices, Int32 basevertex);

			[AliasOf("glDrawRangeElementsBaseVertex")]
			[AliasOf("glDrawRangeElementsBaseVertexEXT")]
			[AliasOf("glDrawRangeElementsBaseVertexOES")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			[ThreadStatic]
			internal static glDrawRangeElementsBaseVertex pglDrawRangeElementsBaseVertex;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDrawElementsInstancedBaseVertex(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex);

			[AliasOf("glDrawElementsInstancedBaseVertex")]
			[AliasOf("glDrawElementsInstancedBaseVertexEXT")]
			[AliasOf("glDrawElementsInstancedBaseVertexOES")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertex pglDrawElementsInstancedBaseVertex;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiDrawElementsBaseVertex(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount, Int32* basevertex);

			[AliasOf("glMultiDrawElementsBaseVertex")]
			[AliasOf("glMultiDrawElementsBaseVertexEXT")]
			[AliasOf("glMultiDrawElementsBaseVertexOES")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
			[RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
			[ThreadStatic]
			internal static glMultiDrawElementsBaseVertex pglMultiDrawElementsBaseVertex;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_provoking_vertex")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProvokingVertex(Int32 mode);

			[AliasOf("glProvokingVertex")]
			[AliasOf("glProvokingVertexEXT")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_provoking_vertex")]
			[ThreadStatic]
			internal static glProvokingVertex pglProvokingVertex;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glFenceSync(Int32 condition, UInt32 flags);

			[AliasOf("glFenceSync")]
			[AliasOf("glFenceSyncAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glFenceSync pglFenceSync;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsSync(Int32 sync);

			[AliasOf("glIsSync")]
			[AliasOf("glIsSyncAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glIsSync pglIsSync;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDeleteSync(Int32 sync);

			[AliasOf("glDeleteSync")]
			[AliasOf("glDeleteSyncAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDeleteSync pglDeleteSync;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glClientWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[AliasOf("glClientWaitSync")]
			[AliasOf("glClientWaitSyncAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClientWaitSync pglClientWaitSync;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glWaitSync(Int32 sync, UInt32 flags, UInt64 timeout);

			[AliasOf("glWaitSync")]
			[AliasOf("glWaitSyncAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glWaitSync pglWaitSync;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetInteger64v(Int32 pname, Int64* data);

			[AliasOf("glGetInteger64v")]
			[AliasOf("glGetInteger64vAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetInteger64v pglGetInteger64v;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetSynciv(Int32 sync, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[AliasOf("glGetSynciv")]
			[AliasOf("glGetSyncivAPPLE")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetSynciv pglGetSynciv;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetInteger64i_v(Int32 target, UInt32 index, Int64* data);

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetInteger64i_v pglGetInteger64i_v;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetBufferParameteri64v(Int32 target, Int32 pname, Int64* @params);

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetBufferParameteri64v pglGetBufferParameteri64v;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFramebufferTexture(Int32 target, Int32 attachment, UInt32 texture, Int32 level);

			[AliasOf("glFramebufferTexture")]
			[AliasOf("glFramebufferTextureARB")]
			[AliasOf("glFramebufferTextureEXT")]
			[AliasOf("glFramebufferTextureOES")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferTexture pglFramebufferTexture;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexImage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTexImage2DMultisample pglTexImage2DMultisample;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexImage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTexImage3DMultisample pglTexImage3DMultisample;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_explicit_multisample")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMultisamplefv(Int32 pname, UInt32 index, float* val);

			[AliasOf("glGetMultisamplefv")]
			[AliasOf("glGetMultisamplefvNV")]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_explicit_multisample")]
			[ThreadStatic]
			internal static glGetMultisamplefv pglGetMultisamplefv;

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSampleMaski(UInt32 maskNumber, UInt32 mask);

			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glSampleMaski pglSampleMaski;

		}
	}

}
