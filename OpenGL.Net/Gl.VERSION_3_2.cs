
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
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int LINES_ADJACENCY = 0x000A;

		/// <summary>
		/// Value of GL_LINE_STRIP_ADJACENCY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int LINE_STRIP_ADJACENCY = 0x000B;

		/// <summary>
		/// Value of GL_TRIANGLES_ADJACENCY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int TRIANGLES_ADJACENCY = 0x000C;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP_ADJACENCY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int TRIANGLE_STRIP_ADJACENCY = 0x000D;

		/// <summary>
		/// Value of GL_PROGRAM_POINT_SIZE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to VERTEX_PROGRAM_POINT_SIZE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int PROGRAM_POINT_SIZE = 0x8642;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_SHADER = 0x8DD9;

		/// <summary>
		/// Value of GL_GEOMETRY_VERTICES_OUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_VERTICES_OUT = 0x8916;

		/// <summary>
		/// Value of GL_GEOMETRY_INPUT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_INPUT_TYPE = 0x8917;

		/// <summary>
		/// Value of GL_GEOMETRY_OUTPUT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int GEOMETRY_OUTPUT_TYPE = 0x8918;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_VERTICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

		/// <summary>
		/// Value of GL_MAX_VERTEX_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_INPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_INPUT_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

		/// <summary>
		/// Value of GL_CONTEXT_PROFILE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		public const int CONTEXT_PROFILE_MASK = 0x9126;

		/// <summary>
		/// Value of GL_DEPTH_CLAMP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_depth_clamp")]
		public const int DEPTH_CLAMP = 0x864F;

		/// <summary>
		/// Value of GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

		/// <summary>
		/// Value of GL_FIRST_VERTEX_CONVENTION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int FIRST_VERTEX_CONVENTION = 0x8E4D;

		/// <summary>
		/// Value of GL_LAST_VERTEX_CONVENTION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int LAST_VERTEX_CONVENTION = 0x8E4E;

		/// <summary>
		/// Value of GL_PROVOKING_VERTEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int PROVOKING_VERTEX = 0x8E4F;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_SEAMLESS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_AMD_seamless_cubemap_per_texture")]
		[RequiredByFeature("GL_ARB_seamless_cube_map")]
		[RequiredByFeature("GL_ARB_seamless_cubemap_per_texture")]
		public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

		/// <summary>
		/// Value of GL_MAX_SERVER_WAIT_TIMEOUT symbol.
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
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_POSITION = 0x8E50;

		/// <summary>
		/// Value of GL_SAMPLE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_MASK = 0x8E51;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_MASK_VALUE = 0x8E52;

		/// <summary>
		/// Value of GL_MAX_SAMPLE_MASK_WORDS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
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
		/// Value of GL_TEXTURE_BINDING_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY symbol.
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
		/// Value of GL_MAX_COLOR_TEXTURE_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

		/// <summary>
		/// Value of GL_MAX_DEPTH_TEXTURE_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

		/// <summary>
		/// Value of GL_MAX_INTEGER_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_INTEGER_SAMPLES = 0x9110;

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(int mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			if        (Delegates.pglDrawElementsBaseVertex != null) {
				Delegates.pglDrawElementsBaseVertex(mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertex({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else if (Delegates.pglDrawElementsBaseVertexEXT != null) {
				Delegates.pglDrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else if (Delegates.pglDrawElementsBaseVertexOES != null) {
				Delegates.pglDrawElementsBaseVertexOES(mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else
				throw new NotImplementedException("glDrawElementsBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			if        (Delegates.pglDrawElementsBaseVertex != null) {
				Delegates.pglDrawElementsBaseVertex((int)mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertex({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else if (Delegates.pglDrawElementsBaseVertexEXT != null) {
				Delegates.pglDrawElementsBaseVertexEXT((int)mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else if (Delegates.pglDrawElementsBaseVertexOES != null) {
				Delegates.pglDrawElementsBaseVertexOES((int)mode, count, type, indices, basevertex);
				CallLog("glDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			} else
				throw new NotImplementedException("glDrawElementsBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(int mode, Int32 count, int type, Object indices, Int32 basevertex)
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsBaseVertex(PrimitiveType mode, Int32 count, int type, Object indices, Int32 basevertex)
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			if        (Delegates.pglDrawRangeElementsBaseVertex != null) {
				Delegates.pglDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertex({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else if (Delegates.pglDrawRangeElementsBaseVertexEXT != null) {
				Delegates.pglDrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else if (Delegates.pglDrawRangeElementsBaseVertexOES != null) {
				Delegates.pglDrawRangeElementsBaseVertexOES(mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else
				throw new NotImplementedException("glDrawRangeElementsBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			if        (Delegates.pglDrawRangeElementsBaseVertex != null) {
				Delegates.pglDrawRangeElementsBaseVertex((int)mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertex({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else if (Delegates.pglDrawRangeElementsBaseVertexEXT != null) {
				Delegates.pglDrawRangeElementsBaseVertexEXT((int)mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else if (Delegates.pglDrawRangeElementsBaseVertexOES != null) {
				Delegates.pglDrawRangeElementsBaseVertexOES((int)mode, start, end, count, type, indices, basevertex);
				CallLog("glDrawRangeElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			} else
				throw new NotImplementedException("glDrawRangeElementsBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(int mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertex(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			if        (Delegates.pglDrawElementsInstancedBaseVertex != null) {
				Delegates.pglDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertex({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexEXT != null) {
				Delegates.pglDrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexOES != null) {
				Delegates.pglDrawElementsInstancedBaseVertexOES(mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			if        (Delegates.pglDrawElementsInstancedBaseVertex != null) {
				Delegates.pglDrawElementsInstancedBaseVertex((int)mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertex({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexEXT != null) {
				Delegates.pglDrawElementsInstancedBaseVertexEXT((int)mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexOES != null) {
				Delegates.pglDrawElementsInstancedBaseVertexOES((int)mode, count, type, indices, instancecount, basevertex);
				CallLog("glDrawElementsInstancedBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(int mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex 
		/// arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count, indices and basevertex arrays.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a pointer to the location where the base vertices are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void MultiDrawElementsBaseVertex(int mode, Int32[] count, int type, IntPtr indices, Int32 drawcount, Int32[] basevertex)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (Int32* p_basevertex = basevertex)
				{
					if        (Delegates.pglMultiDrawElementsBaseVertex != null) {
						Delegates.pglMultiDrawElementsBaseVertex(mode, p_count, type, indices, drawcount, p_basevertex);
						CallLog("glMultiDrawElementsBaseVertex({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, drawcount, basevertex);
					} else if (Delegates.pglMultiDrawElementsBaseVertexEXT != null) {
						Delegates.pglMultiDrawElementsBaseVertexEXT(mode, p_count, type, indices, drawcount, p_basevertex);
						CallLog("glMultiDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, drawcount, basevertex);
					} else if (Delegates.pglMultiDrawElementsBaseVertexOES != null) {
						Delegates.pglMultiDrawElementsBaseVertexOES(mode, p_count, type, indices, drawcount, p_basevertex);
						CallLog("glMultiDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, drawcount, basevertex);
					} else
						throw new NotImplementedException("glMultiDrawElementsBaseVertex (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count, indices and basevertex arrays.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a pointer to the location where the base vertices are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_draw_elements_base_vertex")]
		public static void MultiDrawElementsBaseVertex(int mode, Int32[] count, int type, Object indices, Int32 drawcount, Int32[] basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElementsBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), drawcount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// specifiy the vertex to be used as the source of data for flat shaded varyings
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_provoking_vertex")]
		public static void ProvokingVertex(int mode)
		{
			if        (Delegates.pglProvokingVertex != null) {
				Delegates.pglProvokingVertex(mode);
				CallLog("glProvokingVertex({0})", mode);
			} else if (Delegates.pglProvokingVertexEXT != null) {
				Delegates.pglProvokingVertexEXT(mode);
				CallLog("glProvokingVertexEXT({0})", mode);
			} else
				throw new NotImplementedException("glProvokingVertex (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// create a new sync object and insert it into the GL command stream
		/// </summary>
		/// <param name="condition">
		/// Specifies the condition that must be met to set the sync object's state to signaled. condition must be 
		/// GL_SYNC_GPU_COMMANDS_COMPLETE.
		/// </param>
		/// <param name="flags">
		/// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for 
		/// this operation and flags must be zero.flags is a placeholder for anticipated future extensions of fence sync object 
		/// capabilities.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static int FenceSync(int condition, uint flags)
		{
			int retValue;

			if        (Delegates.pglFenceSync != null) {
				retValue = Delegates.pglFenceSync(condition, flags);
				CallLog("glFenceSync({0}, {1}) = {2}", condition, flags, retValue);
			} else if (Delegates.pglFenceSyncAPPLE != null) {
				retValue = Delegates.pglFenceSyncAPPLE(condition, flags);
				CallLog("glFenceSyncAPPLE({0}, {1}) = {2}", condition, flags, retValue);
			} else
				throw new NotImplementedException("glFenceSync (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// determine if a name corresponds to a sync object
		/// </summary>
		/// <param name="sync">
		/// Specifies a value that may be the name of a sync object.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static bool IsSync(int sync)
		{
			bool retValue;

			if        (Delegates.pglIsSync != null) {
				retValue = Delegates.pglIsSync(sync);
				CallLog("glIsSync({0}) = {1}", sync, retValue);
			} else if (Delegates.pglIsSyncAPPLE != null) {
				retValue = Delegates.pglIsSyncAPPLE(sync);
				CallLog("glIsSyncAPPLE({0}) = {1}", sync, retValue);
			} else
				throw new NotImplementedException("glIsSync (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// delete a sync object
		/// </summary>
		/// <param name="sync">
		/// The sync object to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void DeleteSync(int sync)
		{
			if        (Delegates.pglDeleteSync != null) {
				Delegates.pglDeleteSync(sync);
				CallLog("glDeleteSync({0})", sync);
			} else if (Delegates.pglDeleteSyncAPPLE != null) {
				Delegates.pglDeleteSyncAPPLE(sync);
				CallLog("glDeleteSyncAPPLE({0})", sync);
			} else
				throw new NotImplementedException("glDeleteSync (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// block and wait for a sync object to become signaled
		/// </summary>
		/// <param name="sync">
		/// The sync object whose status to wait on.
		/// </param>
		/// <param name="flags">
		/// A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.
		/// </param>
		/// <param name="timeout">
		/// The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static int ClientWaitSync(int sync, uint flags, UInt64 timeout)
		{
			int retValue;

			if        (Delegates.pglClientWaitSync != null) {
				retValue = Delegates.pglClientWaitSync(sync, flags, timeout);
				CallLog("glClientWaitSync({0}, {1}, {2}) = {3}", sync, flags, timeout, retValue);
			} else if (Delegates.pglClientWaitSyncAPPLE != null) {
				retValue = Delegates.pglClientWaitSyncAPPLE(sync, flags, timeout);
				CallLog("glClientWaitSyncAPPLE({0}, {1}, {2}) = {3}", sync, flags, timeout, retValue);
			} else
				throw new NotImplementedException("glClientWaitSync (and other aliases) are not implemented");
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
		/// A bitfield controlling the command flushing behavior. flags may be zero.
		/// </param>
		/// <param name="timeout">
		/// Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void WaitSync(int sync, uint flags, UInt64 timeout)
		{
			if        (Delegates.pglWaitSync != null) {
				Delegates.pglWaitSync(sync, flags, timeout);
				CallLog("glWaitSync({0}, {1}, {2})", sync, flags, timeout);
			} else if (Delegates.pglWaitSyncAPPLE != null) {
				Delegates.pglWaitSyncAPPLE(sync, flags, timeout);
				CallLog("glWaitSyncAPPLE({0}, {1}, {2})", sync, flags, timeout);
			} else
				throw new NotImplementedException("glWaitSync (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void GetInteger64v(int pname, Int64[] data)
		{
			unsafe {
				fixed (Int64* p_data = data)
				{
					if        (Delegates.pglGetInteger64v != null) {
						Delegates.pglGetInteger64v(pname, p_data);
						CallLog("glGetInteger64v({0}, {1})", pname, data);
					} else if (Delegates.pglGetInteger64vAPPLE != null) {
						Delegates.pglGetInteger64vAPPLE(pname, p_data);
						CallLog("glGetInteger64vAPPLE({0}, {1})", pname, data);
					} else
						throw new NotImplementedException("glGetInteger64v (and other aliases) are not implemented");
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
		/// Specifies the parameter whose value to retrieve from the sync object specified in sync.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given in values.
		/// </param>
		/// <param name="length">
		/// Specifies the address of an variable to receive the number of integers placed in values.
		/// </param>
		/// <param name="values">
		/// Specifies the address of an array to receive the values of the queried parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_sync")]
		public static void GetSync(int sync, int pname, Int32 bufSize, out Int32 length, Int32[] values)
		{
			Debug.Assert(values.Length >= bufSize);

			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_values = values)
				{
					if        (Delegates.pglGetSynciv != null) {
						Delegates.pglGetSynciv(sync, pname, bufSize, p_length, p_values);
						CallLog("glGetSynciv({0}, {1}, {2}, {3}, {4})", sync, pname, bufSize, length, values);
					} else if (Delegates.pglGetSyncivAPPLE != null) {
						Delegates.pglGetSyncivAPPLE(sync, pname, bufSize, p_length, p_values);
						CallLog("glGetSyncivAPPLE({0}, {1}, {2}, {3}, {4})", sync, pname, bufSize, length, values);
					} else
						throw new NotImplementedException("glGetSynciv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void GetInteger64i_v(int target, UInt32 index, Int64[] data)
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
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void GetBufferParameter(int target, int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameteri64v != null, "pglGetBufferParameteri64v not implemented");
					Delegates.pglGetBufferParameteri64v(target, pname, p_params);
					CallLog("glGetBufferParameteri64v({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture.
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
		[RequiredByFeature("GL_VERSION_3_2")]
		public static void FramebufferTexture(int target, int attachment, UInt32 texture, Int32 level)
		{
			if        (Delegates.pglFramebufferTexture != null) {
				Delegates.pglFramebufferTexture(target, attachment, texture, level);
				CallLog("glFramebufferTexture({0}, {1}, {2}, {3})", target, attachment, texture, level);
			} else if (Delegates.pglFramebufferTextureARB != null) {
				Delegates.pglFramebufferTextureARB(target, attachment, texture, level);
				CallLog("glFramebufferTextureARB({0}, {1}, {2}, {3})", target, attachment, texture, level);
			} else if (Delegates.pglFramebufferTextureEXT != null) {
				Delegates.pglFramebufferTextureEXT(target, attachment, texture, level);
				CallLog("glFramebufferTextureEXT({0}, {1}, {2}, {3})", target, attachment, texture, level);
			} else if (Delegates.pglFramebufferTextureOES != null) {
				Delegates.pglFramebufferTextureOES(target, attachment, texture, level);
				CallLog("glFramebufferTextureOES({0}, {1}, {2}, {3})", target, attachment, texture, level);
			} else
				throw new NotImplementedException("glFramebufferTexture (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// establish the data storage, format, dimensions, and number of samples of a multisample texture's image
		/// </summary>
		/// <param name="target">
		/// Specifies the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE or GL_PROXY_TEXTURE_2D_MULTISAMPLE.
		/// </param>
		/// <param name="samples">
		/// The number of samples in the multisample texture's image.
		/// </param>
		/// <param name="internalformat">
		/// The internal format to be used to store the multisample texture's image. internalformat must specify a color-renderable, 
		/// depth-renderable, or stencil-renderable format.
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
		/// Specifies the target of the operation. target must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY or 
		/// GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="samples">
		/// The number of samples in the multisample texture's image.
		/// </param>
		/// <param name="internalformat">
		/// The internal format to be used to store the multisample texture's image. internalformat must specify a color-renderable, 
		/// depth-renderable, or stencil-renderable format.
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
		/// Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the sample whose position to query.
		/// </param>
		/// <param name="val">
		/// Specifies the address of an array to receive the position of the sample.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public static void GetMultisample(int pname, UInt32 index, float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					if        (Delegates.pglGetMultisamplefv != null) {
						Delegates.pglGetMultisamplefv(pname, index, p_val);
						CallLog("glGetMultisamplefv({0}, {1}, {2})", pname, index, val);
					} else if (Delegates.pglGetMultisamplefvNV != null) {
						Delegates.pglGetMultisamplefvNV(pname, index, p_val);
						CallLog("glGetMultisamplefvNV({0}, {1}, {2})", pname, index, val);
					} else
						throw new NotImplementedException("glGetMultisamplefv (and other aliases) are not implemented");
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
