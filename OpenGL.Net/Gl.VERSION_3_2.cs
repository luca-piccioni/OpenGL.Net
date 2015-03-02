
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;

		/// <summary>
		/// Value of GL_OBJECT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int OBJECT_TYPE = 0x9112;

		/// <summary>
		/// Value of GL_SYNC_CONDITION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_CONDITION = 0x9113;

		/// <summary>
		/// Value of GL_SYNC_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_STATUS = 0x9114;

		/// <summary>
		/// Value of GL_SYNC_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_FLAGS = 0x9115;

		/// <summary>
		/// Value of GL_SYNC_FENCE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_FENCE = 0x9116;

		/// <summary>
		/// Value of GL_SYNC_GPU_COMMANDS_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

		/// <summary>
		/// Value of GL_UNSIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int UNSIGNALED = 0x9118;

		/// <summary>
		/// Value of GL_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int SIGNALED = 0x9119;

		/// <summary>
		/// Value of GL_ALREADY_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int ALREADY_SIGNALED = 0x911A;

		/// <summary>
		/// Value of GL_TIMEOUT_EXPIRED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int TIMEOUT_EXPIRED = 0x911B;

		/// <summary>
		/// Value of GL_CONDITION_SATISFIED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int CONDITION_SATISFIED = 0x911C;

		/// <summary>
		/// Value of GL_WAIT_FAILED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const int WAIT_FAILED = 0x911D;

		/// <summary>
		/// Value of GL_TIMEOUT_IGNORED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// Value of GL_SYNC_FLUSH_COMMANDS_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_sync")]
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_SAMPLE_POSITION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_POSITION = 0x8E50;

		/// <summary>
		/// Value of GL_SAMPLE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_MASK = 0x8E51;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLE_MASK_VALUE = 0x8E52;

		/// <summary>
		/// Value of GL_MAX_SAMPLE_MASK_WORDS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_SAMPLE_MASK_WORDS = 0x8E59;

		/// <summary>
		/// Value of GL_TEXTURE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
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
		[RequiredByFeature("GL_ES_VERSION_3_1")]
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
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_SAMPLES = 0x9106;

		/// <summary>
		/// Value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

		/// <summary>
		/// Value of GL_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int SAMPLER_2D_MULTISAMPLE = 0x9108;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int INT_SAMPLER_2D_MULTISAMPLE = 0x9109;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
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
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

		/// <summary>
		/// Value of GL_MAX_DEPTH_TEXTURE_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

		/// <summary>
		/// Value of GL_MAX_INTEGER_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_multisample")]
		public const int MAX_INTEGER_SAMPLES = 0x9110;

		/// <summary>
		/// render primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsBaseVertex behaves identically to glDrawElements except that the ith element transferred by the 
		/// correspondingdraw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value 
		/// islarger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned 
		/// integers(with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsBaseVertex behaves identically to glDrawElements except that the ith element transferred by the 
		/// correspondingdraw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value 
		/// islarger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned 
		/// integers(with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsBaseVertex behaves identically to glDrawElements except that the ith element transferred by the 
		/// correspondingdraw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value 
		/// islarger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned 
		/// integers(with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex 
		/// matchthe corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the 
		/// arrayindices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range 
		/// [start,end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding 
		/// drawcall will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than 
		/// themaximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with 
		/// wrappingon overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_VALUE is generated if end &lt; start. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex 
		/// matchthe corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the 
		/// arrayindices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range 
		/// [start,end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding 
		/// drawcall will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than 
		/// themaximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with 
		/// wrappingon overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_VALUE is generated if end &lt; start. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex 
		/// matchthe corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the 
		/// arrayindices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range 
		/// [start,end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding 
		/// drawcall will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than 
		/// themaximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with 
		/// wrappingon overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_VALUE is generated if end &lt; start. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// render multiple instances of a set of primitives from array data with a per-element offset
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsInstancedBaseVertex behaves identically to glDrawElementsInstanced except that the ith element transferred 
		/// bythe corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting 
		/// valueis larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit 
		/// unsignedintegers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count or primcount is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsInstancedBaseVertex behaves identically to glDrawElementsInstanced except that the ith element transferred 
		/// bythe corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting 
		/// valueis larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit 
		/// unsignedintegers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count or primcount is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// GL_TRIANGLE_STRIP,GL_TRIANGLE_FAN, GL_TRIANGLES, GL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCYand GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glDrawElementsInstancedBaseVertex behaves identically to glDrawElementsInstanced except that the ith element transferred 
		/// bythe corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting 
		/// valueis larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit 
		/// unsignedintegers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count or primcount is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawRangeElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glMultiDrawElementsBaseVertex behaves identically to glDrawElementsBaseVertex, except that drawcount separate lists of 
		/// elementsare specifried instead. 
		/// It has the same effect as: for (int i = 0; i &lt; drawcount; i++) if (count[i] &gt; 0) glDrawElementsBaseVertex(mode, 
		/// count[i],type, indices[i], basevertex[i]); 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
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
		/// <remarks>
		/// glMultiDrawElementsBaseVertex behaves identically to glDrawElementsBaseVertex, except that drawcount separate lists of 
		/// elementsare specifried instead. 
		/// It has the same effect as: for (int i = 0; i &lt; drawcount; i++) if (count[i] &gt; 0) glDrawElementsBaseVertex(mode, 
		/// count[i],type, indices[i], basevertex[i]); 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// Flatshading a vertex shader varying output means to assign all vetices of the primitive the same value for that output. 
		/// Thevertex from which these values is derived is known as the provoking vertex and glProvokingVertex specifies which 
		/// vertexis to be used as the source of data for flat shaded varyings. 
		/// provokeMode must be either GL_FIRST_VERTEX_CONVENTION or GL_LAST_VERTEX_CONVENTION, and controls the selection of the 
		/// vertexwhose values are assigned to flatshaded varying outputs. The interpretation of these values for the supported 
		/// primitivetypes is: Primitive Type of Polygon i First Vertex Convention Last Vertex Convention point ii independent line 
		/// 2i- 1 2i line loop ii + 1, if i &lt; n 1, if i = n line strip ii + 1 independent triangle 3i - 2 3i triangle strip ii + 
		/// 2triangle fan i + 1 i + 2 line adjacency 4i - 2 4i - 1 line strip adjacency i + 1 i + 2 triangle adjacency 6i - 5 6i - 1 
		/// trianglestrip adjacency 2i - 1 2i + 3 
		/// If a vertex or geometry shader is active, user-defined varying outputs may be flatshaded by using the flat qualifier 
		/// whendeclaring the output. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if provokeMode is not an accepted value. 
		/// </para>
		/// </remarks>
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
		/// thisoperation and flags must be zero.flags is a placeholder for anticipated future extensions of fence sync object 
		/// capabilities.
		/// </param>
		/// <remarks>
		/// glFenceSync creates a new fence sync object, inserts a fence command into the GL command stream and associates it with 
		/// thatsync object, and returns a non-zero name corresponding to the sync object. 
		/// When the specified condition of the sync object is satisfied by the fence command, the sync object is signaled by the 
		/// GL,causing any glWaitSync, glClientWaitSync commands blocking in sync to unblock. No other state is affected by 
		/// glFenceSyncor by the execution of the associated fence command. 
		/// condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. This condition is satisfied by completion of the fence command 
		/// correspondingto the sync object and all preceding commands in the same command stream. The sync object will not be 
		/// signaleduntil all effects from these commands on GL client and server state and the framebuffer are fully realized. Note 
		/// thatcompletion of the fence command occurs once the state of the corresponding sync object has been changed, but 
		/// commandswaiting on that sync object may not be unblocked until after the fence command completes. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if condition is not GL_SYNC_GPU_COMMANDS_COMPLETE. 
		/// - GL_INVALID_VALUE is generated if flags is not zero. 
		/// - Additionally, if glFenceSync fails, it will return zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteSync"/>
		/// <seealso cref="Gl.GetSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
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
		/// <remarks>
		/// glIsSync returns GL_TRUE if sync is currently the name of a sync object. If sync is not the name of a sync object, or if 
		/// anerror occurs, glIsSync returns GL_FALSE. Note that zero is not the name of a sync object. 
		/// </remarks>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		/// <seealso cref="Gl.DeleteSync"/>
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
		/// <remarks>
		/// glDeleteSync deletes the sync object specified by sync. If the fence command corresponding to the specified sync object 
		/// hascompleted, or if no glWaitSync or glClientWaitSync commands are blocking on sync, the object is deleted immediately. 
		/// Otherwise,sync is flagged for deletion and will be deleted when it is no longer associated with any fence command and is 
		/// nolonger blocking any glWaitSync or glClientWaitSync command. In either case, after glDeleteSync returns, the name sync 
		/// isinvalid and can no longer be used to refer to the sync object. 
		/// glDeleteSync will silently ignore a sync value of zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if sync is neither zero or the name of a sync object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
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
		/// <remarks>
		/// glClientWaitSync causes the client to block and wait for the sync object specified by sync to become signaled. If sync 
		/// issignaled when glClientWaitSync is called, glClientWaitSync returns immediately, otherwise it will block and wait for 
		/// upto timeout nanoseconds for sync to become signaled. 
		/// The return value is one of four status values: GL_ALREADY_SIGNALED indicates that sync was signaled at the time that 
		/// glClientWaitSyncwas called. GL_TIMEOUT_EXPIRED indicates that at least timeout nanoseconds passed and sync did not 
		/// becomesignaled. GL_CONDITION_SATISFIED indicates that sync was signaled before the timeout expired. GL_WAIT_FAILED 
		/// indicatesthat an error occurred. Additionally, an OpenGL error will be generated. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if sync is not the name of an existing sync object. 
		/// - GL_INVALID_VALUE is generated if flags contains any unsupported flag. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.IsSync"/>
		/// <seealso cref="Gl.WaitSync"/>
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
		/// <remarks>
		/// glWaitSync causes the GL server to block and wait until sync becomes signaled. sync is the name of an existing sync 
		/// objectupon which to wait. flags and timeout are currently not used and must be set to zero and the special value 
		/// GL_TIMEOUT_IGNORED,respectivelyflags and timeout are placeholders for anticipated future extensions of sync object 
		/// capabilities.They must have these reserved values in order that existing code calling glWaitSync operate properly in the 
		/// presenceof such extensions.. glWaitSync will always wait no longer than an implementation-dependent timeout. The 
		/// durationof this timeout in nanoseconds may be queried by calling glGet with the parameter GL_MAX_SERVER_WAIT_TIMEOUT. 
		/// Thereis currently no way to determine whether glWaitSync unblocked because the timeout expired or because the sync 
		/// objectbeing waited on was signaled. 
		/// If an error occurs, glWaitSync does not cause the GL server to block. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if sync is not the name of a sync object. 
		/// - GL_INVALID_VALUE is generated if flags is not zero. 
		/// - GL_INVALID_VALUE is generated if timeout is not GL_TIMEOUT_IGNORED. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
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
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
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
		/// <remarks>
		/// glGetSynciv retrieves properties of a sync object. sync specifies the name of the sync object whose properties to 
		/// retrieve.
		/// On success, glGetSynciv replaces up to bufSize integers in values with the corresponding property values of the object 
		/// beingqueried. The actual number of integers replaced is returned in the variable whose address is specified in length. 
		/// Iflength is NULL, no length is returned. 
		/// If pname is GL_OBJECT_TYPE, a single value representing the specific type of the sync object is placed in values. The 
		/// onlytype supported is GL_SYNC_FENCE. 
		/// If pname is GL_SYNC_STATUS, a single value representing the status of the sync object (GL_SIGNALED or GL_UNSIGNALED) is 
		/// placedin values. 
		/// If pname is GL_SYNC_CONDITION, a single value representing the condition of the sync object is placed in values. The 
		/// onlycondition supported is GL_SYNC_GPU_COMMANDS_COMPLETE. 
		/// If pname is GL_SYNC_FLAGS, a single value representing the flags with which the sync object was created is placed in 
		/// values.No flags are currently supportedflags is expected to be used in future extensions to the sync objects.. 
		/// If an error occurs, nothing will be written to values or length. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if sync is not the name of a sync object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted tokens. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FenceSync"/>
		/// <seealso cref="Gl.WaitSync"/>
		/// <seealso cref="Gl.ClientWaitSync"/>
		public static void GetSync(int sync, int pname, Int32 bufSize, out Int32 length, Int32[] values)
		{
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
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
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
		/// beone of the buffer binding targets in the following table: 
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <remarks>
		/// These functions return in data a selected parameter of the specified buffer object. 
		/// pname names a specific buffer object parameter, as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferParameter* if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferParameter* if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferParameter* if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the buffer object parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
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
		/// <remarks>
		/// These commands attach a selected mipmap level or image of a texture object as one of the logical buffers of the 
		/// specifiedframebuffer object. Textures cannot be attached to the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For all commands exceptglNamedFramebufferTexture, the framebuffer object is that bound to target, which must be 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTexture, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, textarget specifies what type of texture 
		/// isnamed by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it 
		/// mustbe the name of an existing texture object with effective target textarget unless it is a cube map texture, in which 
		/// casetextarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_XGL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer 
		/// attachmentpoint named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, 
		/// texturemust be zero or the name of an existing texture with an effective target of textarget, or texture must be the 
		/// nameof an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be 
		/// zero.
		/// If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_3D_TEXTURE_SIZE. 
		/// If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be 
		/// greaterthan or equal to zero and less than or equal to $log_2$ of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. 
		/// For all other values of textarget, level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_TEXTURE_SIZE. 
		/// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture. 
		/// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if 
		/// textureis not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, 
		/// iftexture is not zero, then textarget must be GL_TEXTURE_3D. 
		/// For glFramebufferTexture and glNamedFramebufferTexture, if texture is the name of a three-dimensional, cube map array, 
		/// cubemap, one- or two-dimensional array, or two-dimensional multisample array texture, the specified texture level is an 
		/// arrayof images, and the framebuffer attachment is considered to be layered. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by all commands accepting a target parameter if it is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by all commands accepting a target parameter if zero is bound to that target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_VALUE is generated if texture is not zero or the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture. 
		/// - GL_INVALID_VALUE is generated by glFramebufferTexture3D if texture is not zero and layer is larger than the value of 
		///   GL_MAX_3D_TEXTURE_SIZEminus one. 
		/// - GL_INVALID_OPERATION is generated by all commands accepting a textarget parameter if texture is not zero, and textarget 
		///   andthe effective target of texture are not compatible. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
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
		/// depth-renderable,or stencil-renderable format. 
		/// </param>
		/// <param name="width">
		/// The width of the multisample texture's image, in texels. 
		/// </param>
		/// <param name="height">
		/// The height of the multisample texture's image, in texels. 
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexImage2DMultisample establishes the data storage, format, dimensions and number of samples of a multisample 
		/// texture'simage. 
		/// target must be GL_TEXTURE_2D_MULTISAMPLE or GL_PROXY_TEXTURE_2D_MULTISAMPLE. width and height are the dimensions in 
		/// texelsof the texture, and must be in the range zero to the value of GL_MAX_TEXTURE_SIZE minus one. samples specifies the 
		/// numberof samples in the image and must be in the range zero to the value of GL_MAX_SAMPLES minus one. 
		/// internalformat must be a color-renderable, depth-renderable, or stencil-renderable format. 
		/// If fixedsamplelocations is GL_TRUE, the image will use identical sample locations and the same number of samples for all 
		/// texelsin the image, and the sample locations will not depend on the internal format or size of the image. 
		/// When a multisample texture is accessed in a shader, the access takes one vector of integers describing which texel to 
		/// fetchand an integer corresponding to the sample numbers describing which sample within the texel to fetch. No standard 
		/// samplinginstructions are allowed on the multisample texture targets. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if internalformat is a depth- or stencil-renderable format and samples is greater than 
		///   thevalue of GL_MAX_DEPTH_TEXTURE_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if internalformat is a color-renderable format and samples is greater than the value 
		///   ofGL_MAX_COLOR_TEXTURE_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if internalformat is a signed or unsigned integer format and samples is greater than 
		///   thevalue of GL_MAX_INTEGER_SAMPLES. 
		/// - GL_INVALID_VALUE is generated if either width or height negative or is greater than GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if samples is greater than GL_MAX_SAMPLES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
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
		/// depth-renderable,or stencil-renderable format. 
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
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexImage3DMultisample establishes the data storage, format, dimensions and number of samples of a multisample 
		/// texture'simage. 
		/// target must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY or GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY. width and heightare the 
		/// dimensionsin texels of the texture, and must be in the range zero to the value of GL_MAX_TEXTURE_SIZE minus one. depth 
		/// isthe number of array slices in the array texture's image. samples specifies the number of samples in the image and must 
		/// bein the range zero to the value of GL_MAX_SAMPLES minus one. 
		/// internalformat must be a color-renderable, depth-renderable, or stencil-renderable format. 
		/// If fixedsamplelocations is GL_TRUE, the image will use identical sample locations and the same number of samples for all 
		/// texelsin the image, and the sample locations will not depend on the internal format or size of the image. 
		/// When a multisample texture is accessed in a shader, the access takes one vector of integers describing which texel to 
		/// fetchand an integer corresponding to the sample numbers describing which sample within the texel to fetch. No standard 
		/// samplinginstructions are allowed on the multisample texture targets. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if internalformat is a depth- or stencil-renderable format and samples is greater than 
		///   thevalue of GL_MAX_DEPTH_TEXTURE_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if internalformat is a color-renderable format and samples is greater than the value 
		///   ofGL_MAX_COLOR_TEXTURE_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if internalformat is a signed or unsigned integer format and samples is greater than 
		///   thevalue of GL_MAX_INTEGER_SAMPLES. 
		/// - GL_INVALID_VALUE is generated if either width or height negative or is greater than GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if depth is negative or is greater than GL_MAX_ARRAY_TEXTURE_LAYERS. 
		/// - GL_INVALID_VALUE is generated if samples is greater than GL_MAX_SAMPLES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
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
		/// <remarks>
		/// glGetMultisamplefv queries the location of a given sample. pname specifies the sample parameter to retrieve and must be 
		/// GL_SAMPLE_POSITION.index corresponds to the sample for which the location should be returned. The sample location is 
		/// returnedas two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations 
		/// respectivelyin the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center. index must be between 
		/// zeroand the value of GL_SAMPLES minus one. 
		/// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of 
		/// sampleswithin some pixels. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not one GL_SAMPLE_POSITION. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the value of GL_SAMPLES. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
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
		/// <remarks>
		/// glSampleMaski sets one 32-bit sub-word of the multi-word sample mask, GL_SAMPLE_MASK_VALUE. 
		/// maskIndex specifies which 32-bit sub-word of the sample mask to update, and mask specifies the new value to use for that 
		/// sub-word.maskIndex must be less than the value of GL_MAX_SAMPLE_MASK_WORDS. Bit B of mask word M corresponds to sample 
		/// 32x M + B. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if maskIndex is greater than or equal to the value of GL_MAX_SAMPLE_MASK_WORDS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void SampleMask(UInt32 maskNumber, uint mask)
		{
			Debug.Assert(Delegates.pglSampleMaski != null, "pglSampleMaski not implemented");
			Delegates.pglSampleMaski(maskNumber, mask);
			CallLog("glSampleMaski({0}, {1})", maskNumber, mask);
			DebugCheckErrors();
		}

	}

}
