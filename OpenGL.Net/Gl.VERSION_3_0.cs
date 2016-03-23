
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
		/// Value of GL_CLIP_DISTANCE6 symbol.
		/// </summary>
		[AliasOf("GL_CLIP_DISTANCE6_APPLE")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
		public const int CLIP_DISTANCE6 = 0x3006;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE7 symbol.
		/// </summary>
		[AliasOf("GL_CLIP_DISTANCE7_APPLE")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
		public const int CLIP_DISTANCE7 = 0x3007;

		/// <summary>
		/// Gl.Get: data returns one value, the major version number of the OpenGL API supported by the current context.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int MAJOR_VERSION = 0x821B;

		/// <summary>
		/// Gl.Get: data returns one value, the minor version number of the OpenGL API supported by the current context.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int MINOR_VERSION = 0x821C;

		/// <summary>
		/// Gl.Get: data returns one value, the number of extensions supported by the GL implementation for the current context. See 
		/// Gl.GetString.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int NUM_EXTENSIONS = 0x821D;

		/// <summary>
		/// Gl.Get: data returns one value, the flags with which the context was created (such as debugging functionality).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		public const int CONTEXT_FLAGS = 0x821E;

		/// <summary>
		/// Value of GL_COMPRESSED_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RED = 0x8225;

		/// <summary>
		/// Value of GL_COMPRESSED_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RG = 0x8226;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_RGBA32F symbol.
		/// </summary>
		[AliasOf("GL_RGBA32F_ARB")]
		[AliasOf("GL_RGBA32F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RGBA32F = 0x8814;

		/// <summary>
		/// Value of GL_RGB32F symbol.
		/// </summary>
		[AliasOf("GL_RGB32F_ARB")]
		[AliasOf("GL_RGB32F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RGB32F = 0x8815;

		/// <summary>
		/// Value of GL_RGBA16F symbol.
		/// </summary>
		[AliasOf("GL_RGBA16F_ARB")]
		[AliasOf("GL_RGBA16F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RGBA16F = 0x881A;

		/// <summary>
		/// Value of GL_RGB16F symbol.
		/// </summary>
		[AliasOf("GL_RGB16F_ARB")]
		[AliasOf("GL_RGB16F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RGB16F = 0x881B;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if fixed-point data types for the vertex 
		/// attribute array indicated by index have integer data types, and 0 (false) otherwise. The initial value is 0 (Gl.FALSE).
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

		/// <summary>
		/// Gl.Get: data returns one value. The value indicates the maximum number of layers allowed in an array texture, and must 
		/// be at least 256. See Gl.TexImage2D.
		/// </summary>
		[AliasOf("GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

		/// <summary>
		/// Gl.Get: data returns one value, the minimum texel offset allowed in a texture lookup, which must be at most -8.
		/// </summary>
		[AliasOf("GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
		[AliasOf("GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MIN_PROGRAM_TEXEL_OFFSET = 0x8904;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum texel offset allowed in a texture lookup, which must be at least 7.
		/// </summary>
		[AliasOf("GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
		[AliasOf("GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

		/// <summary>
		/// Value of GL_CLAMP_READ_COLOR symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_READ_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int CLAMP_READ_COLOR = 0x891C;

		/// <summary>
		/// Value of GL_FIXED_ONLY symbol.
		/// </summary>
		[AliasOf("GL_FIXED_ONLY_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int FIXED_ONLY = 0x891D;

		/// <summary>
		/// Gl.Get: data returns one value, the number components for varying variables, which must be at least 60.
		/// </summary>
		[AliasOf("GL_MAX_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VARYING_COMPONENTS = 0x8B4B;

		/// <summary>
		/// Value of GL_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_1D_ARRAY = 0x8C18;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;

		/// <summary>
		/// Value of GL_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_2D_ARRAY = 0x8C1A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_1D_ARRAY. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_2D_ARRAY. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_array")]
		public const int TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

		/// <summary>
		/// Value of GL_R11F_G11F_B10F symbol.
		/// </summary>
		[AliasOf("GL_R11F_G11F_B10F_APPLE")]
		[AliasOf("GL_R11F_G11F_B10F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_float")]
		public const int R11F_G11F_B10F = 0x8C3A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10F_11F_11F_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
		[AliasOf("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_10f_11f_11f_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_float")]
		public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

		/// <summary>
		/// Value of GL_RGB9_E5 symbol.
		/// </summary>
		[AliasOf("GL_RGB9_E5_APPLE")]
		[AliasOf("GL_RGB9_E5_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_shared_exponent")]
		public const int RGB9_E5 = 0x8C3D;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_5_9_9_9_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
		[AliasOf("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_shared_exponent")]
		public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

		/// <summary>
		/// Value of GL_TEXTURE_SHARED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_SHARED_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_shared_exponent")]
		public const int TEXTURE_SHARED_SIZE = 0x8C3F;

		/// <summary>
		/// Gl.GetProgram: params returns the length of the longest variable name to be used for transform feedback, including the 
		/// null-terminator.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

		/// <summary>
		/// Gl.GetProgram: params returns a symbolic constant indicating the buffer mode used when transform feedback is active. 
		/// This may be Gl.SEPARATE_ATTRIBS or Gl.INTERLEAVED_ATTRIBS.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

		/// <summary>
		/// Gl.GetProgram: params returns the number of varying variables to capture in transform feedback mode for the program.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the start 
		/// offset of the binding range for each transform feedback attribute stream. The initial value is 0 for all streams. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the size of 
		/// the binding range for each transform feedback attribute stream. The initial value is 0 for all streams. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED symbol.
		/// </summary>
		[AliasOf("GL_PRIMITIVES_GENERATED_EXT")]
		[AliasOf("GL_PRIMITIVES_GENERATED_NV")]
		[AliasOf("GL_PRIMITIVES_GENERATED_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int PRIMITIVES_GENERATED = 0x8C87;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

		/// <summary>
		/// Gl.Enable: if enabled, primitives are discarded after the optional transform feedback stage, but before rasterization. 
		/// Furthermore, when enabled, Gl.Clear, Gl.ClearBufferData, Gl.ClearBufferSubData, Gl.ClearTexImage, and 
		/// Gl.ClearTexSubImage are ignored.
		/// </summary>
		[AliasOf("GL_RASTERIZER_DISCARD_EXT")]
		[AliasOf("GL_RASTERIZER_DISCARD_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int RASTERIZER_DISCARD = 0x8C89;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;

		/// <summary>
		/// Value of GL_INTERLEAVED_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_INTERLEAVED_ATTRIBS_EXT")]
		[AliasOf("GL_INTERLEAVED_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int INTERLEAVED_ATTRIBS = 0x8C8C;

		/// <summary>
		/// Value of GL_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_SEPARATE_ATTRIBS_EXT")]
		[AliasOf("GL_SEPARATE_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SEPARATE_ATTRIBS = 0x8C8D;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active buffer binding points to which output variables in 
		/// the Gl.TRANSFORM_FEEDBACK_VARYING interface are written.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active buffer binding points to which output variables 
		/// in the Gl.TRANSFORM_FEEDBACK_VARYING interface are written.
		/// </para>
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

		/// <summary>
		/// Gl.Get: when used with non-indexed variants of glGet (such as glGetIntegerv), data returns a single value, the name of 
		/// the buffer object currently bound to the target Gl.TRANSFORM_FEEDBACK_BUFFER. If no buffer object is bound to this 
		/// target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns a single value, 
		/// the name of the buffer object bound to the indexed transform feedback attribute stream. The initial value is 0 for all 
		/// targets. See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

		/// <summary>
		/// Value of GL_RGBA32UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA32UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA32UI = 0x8D70;

		/// <summary>
		/// Value of GL_RGB32UI symbol.
		/// </summary>
		[AliasOf("GL_RGB32UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB32UI = 0x8D71;

		/// <summary>
		/// Value of GL_RGBA16UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA16UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA16UI = 0x8D76;

		/// <summary>
		/// Value of GL_RGB16UI symbol.
		/// </summary>
		[AliasOf("GL_RGB16UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB16UI = 0x8D77;

		/// <summary>
		/// Value of GL_RGBA8UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA8UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA8UI = 0x8D7C;

		/// <summary>
		/// Value of GL_RGB8UI symbol.
		/// </summary>
		[AliasOf("GL_RGB8UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB8UI = 0x8D7D;

		/// <summary>
		/// Value of GL_RGBA32I symbol.
		/// </summary>
		[AliasOf("GL_RGBA32I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA32I = 0x8D82;

		/// <summary>
		/// Value of GL_RGB32I symbol.
		/// </summary>
		[AliasOf("GL_RGB32I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB32I = 0x8D83;

		/// <summary>
		/// Value of GL_RGBA16I symbol.
		/// </summary>
		[AliasOf("GL_RGBA16I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA16I = 0x8D88;

		/// <summary>
		/// Value of GL_RGB16I symbol.
		/// </summary>
		[AliasOf("GL_RGB16I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB16I = 0x8D89;

		/// <summary>
		/// Value of GL_RGBA8I symbol.
		/// </summary>
		[AliasOf("GL_RGBA8I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA8I = 0x8D8E;

		/// <summary>
		/// Value of GL_RGB8I symbol.
		/// </summary>
		[AliasOf("GL_RGB8I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB8I = 0x8D8F;

		/// <summary>
		/// Value of GL_RED_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RED_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RED_INTEGER = 0x8D94;

		/// <summary>
		/// Value of GL_GREEN_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_GREEN_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int GREEN_INTEGER = 0x8D95;

		/// <summary>
		/// Value of GL_BLUE_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BLUE_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BLUE_INTEGER = 0x8D96;

		/// <summary>
		/// Value of GL_RGB_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RGB_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB_INTEGER = 0x8D98;

		/// <summary>
		/// Value of GL_RGBA_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RGBA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA_INTEGER = 0x8D99;

		/// <summary>
		/// Value of GL_BGR_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BGR_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BGR_INTEGER = 0x8D9A;

		/// <summary>
		/// Value of GL_BGRA_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BGRA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BGRA_INTEGER = 0x8D9B;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_1D_ARRAY = 0x8DC0;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_2D_ARRAY = 0x8DC1;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
		[AliasOf("GL_SAMPLER_2D_ARRAY_SHADOW_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_shadow_samplers_array", Api = "gles2")]
		public const int SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_SHADOW_EXT")]
		[AliasOf("GL_SAMPLER_CUBE_SHADOW_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_shadow_samplers_cube", Api = "gles2")]
		public const int SAMPLER_CUBE_SHADOW = 0x8DC5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC2_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC2 = 0x8DC6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC3_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC3 = 0x8DC7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC4_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC4 = 0x8DC8;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_1D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_1D = 0x8DC9;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D = 0x8DCA;

		/// <summary>
		/// Value of GL_INT_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_3D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_3D = 0x8DCB;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_CUBE = 0x8DCC;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_1D_ARRAY = 0x8DCE;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D_ARRAY = 0x8DCF;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_1D = 0x8DD1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D = 0x8DD2;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_3D = 0x8DD3;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

		/// <summary>
		/// Value of GL_QUERY_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public const int QUERY_WAIT = 0x8E13;

		/// <summary>
		/// Value of GL_QUERY_NO_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_NO_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public const int QUERY_NO_WAIT = 0x8E14;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BY_REGION_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public const int QUERY_BY_REGION_WAIT = 0x8E15;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_NO_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BY_REGION_NO_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public const int QUERY_BY_REGION_NO_WAIT = 0x8E16;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object (the value of the access 
		/// parameter bitfield passed to glMapBufferRange). If the buffer was mapped with glMapBuffer, the access policy is 
		/// determined by translating the enums in that access parameter to the corresponding bits for glMapBufferRange as described 
		/// in the OpenGL Specification. The initial value is zero.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int BUFFER_ACCESS_FLAGS = 0x911F;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the length of the mapping into the buffer object established with glMapBuffer*. 
		/// The i64v versions of these queries should be used for this parameter. The initial value is zero.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int BUFFER_MAP_LENGTH = 0x9120;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the offset of the mapping into the buffer object established with glMapBuffer*. 
		/// The i64v versions of these queries should be used for this parameter. The initial value is zero.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int BUFFER_MAP_OFFSET = 0x9121;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
		public const int DEPTH_COMPONENT32F = 0x8CAC;

		/// <summary>
		/// Value of GL_DEPTH32F_STENCIL8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
		public const int DEPTH32F_STENCIL8 = 0x8CAD;

		/// <summary>
		/// Value of GL_FLOAT_32_UNSIGNED_INT_24_8_REV symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

		/// <summary>
		/// Gl.GetError: the framebuffer object is not complete. The offending command is ignored and has no other side effect than 
		/// to set the error flag.
		/// </summary>
		[AliasOf("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
		[AliasOf("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int FRAMEBUFFER_DEFAULT = 0x8218;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNDEFINED symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_UNDEFINED_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_surfaceless_context", Api = "gles2")]
		public const int FRAMEBUFFER_UNDEFINED = 0x8219;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;

		/// <summary>
		/// Gl.Get: data returns one value. The value indicates the maximum supported size for renderbuffers. See 
		/// Gl.FramebufferRenderbuffer.
		/// </summary>
		[AliasOf("GL_MAX_RENDERBUFFER_SIZE_EXT")]
		[AliasOf("GL_MAX_RENDERBUFFER_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int MAX_RENDERBUFFER_SIZE = 0x84E8;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: values are taken from both the depth and stencil buffers. The type parameter must be Gl.UNSIGNED_INT_24_8 
		/// or Gl.FLOAT_32_UNSIGNED_INT_24_8_REV.
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a pair of depth and stencil values. The depth component of the pair is interpreted as in 
		/// Gl.DEPTH_COMPONENT. The stencil component is interpreted based on specified the depth + stencil internal format.
		/// </para>
		/// </summary>
		[AliasOf("GL_DEPTH_STENCIL_EXT")]
		[AliasOf("GL_DEPTH_STENCIL_NV")]
		[AliasOf("GL_DEPTH_STENCIL_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_NV_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		public const int DEPTH_STENCIL = 0x84F9;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_24_8 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_24_8_EXT")]
		[AliasOf("GL_UNSIGNED_INT_24_8_NV")]
		[AliasOf("GL_UNSIGNED_INT_24_8_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_NV_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		public const int UNSIGNED_INT_24_8 = 0x84FA;

		/// <summary>
		/// Value of GL_DEPTH24_STENCIL8 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH24_STENCIL8_EXT")]
		[AliasOf("GL_DEPTH24_STENCIL8_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int DEPTH24_STENCIL8 = 0x88F0;

		/// <summary>
		/// Value of GL_TEXTURE_STENCIL_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_STENCIL_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		public const int TEXTURE_STENCIL_SIZE = 0x88F1;

		/// <summary>
		/// Gl.GetTexLevelParameter: the data type used to store the component. The types Gl.NONE, Gl.SIGNED_NORMALIZED, 
		/// Gl.UNSIGNED_NORMALIZED, Gl.FLOAT, Gl.INT, and Gl.UNSIGNED_INT may be returned to indicate signed normalized fixed-point, 
		/// unsigned normalized fixed-point, floating-point, integer unnormalized, and unsigned integer unnormalized components, 
		/// respectively.
		/// </summary>
		[AliasOf("GL_TEXTURE_RED_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_RED_TYPE = 0x8C10;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_GREEN_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_GREEN_TYPE = 0x8C11;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BLUE_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_BLUE_TYPE = 0x8C12;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_ALPHA_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_ALPHA_TYPE = 0x8C13;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_DEPTH_TYPE = 0x8C16;

		/// <summary>
		/// Value of GL_UNSIGNED_NORMALIZED symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_NORMALIZED_ARB")]
		[AliasOf("GL_UNSIGNED_NORMALIZED_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		public const int UNSIGNED_NORMALIZED = 0x8C17;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_BINDING_EXT")]
		[AliasOf("GL_FRAMEBUFFER_BINDING_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Gl.Get: data returns one value, the name of the framebuffer object currently bound to the Gl.DRAW_FRAMEBUFFER target. If 
		/// the default framebuffer is bound, this value will be zero. The initial value is zero. See Gl.BindFramebuffer.
		/// </summary>
		[AliasOf("GL_DRAW_FRAMEBUFFER_BINDING_ANGLE")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_BINDING_APPLE")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		public const int DRAW_FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the renderbuffer object currently bound to the target Gl.RENDERBUFFER. 
		/// If no renderbuffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindRenderbuffer.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_BINDING_EXT")]
		[AliasOf("GL_RENDERBUFFER_BINDING_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_BINDING = 0x8CA7;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_READ_FRAMEBUFFER_ANGLE")]
		[AliasOf("GL_READ_FRAMEBUFFER_APPLE")]
		[AliasOf("GL_READ_FRAMEBUFFER_EXT")]
		[AliasOf("GL_READ_FRAMEBUFFER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		public const int READ_FRAMEBUFFER = 0x8CA8;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_DRAW_FRAMEBUFFER_ANGLE")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_APPLE")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_EXT")]
		[AliasOf("GL_DRAW_FRAMEBUFFER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		public const int DRAW_FRAMEBUFFER = 0x8CA9;

		/// <summary>
		/// Gl.Get: data returns one value, the name of the framebuffer object currently bound to the Gl.READ_FRAMEBUFFER target. If 
		/// the default framebuffer is bound, this value will be zero. The initial value is zero. See Gl.BindFramebuffer.
		/// </summary>
		[AliasOf("GL_READ_FRAMEBUFFER_BINDING_ANGLE")]
		[AliasOf("GL_READ_FRAMEBUFFER_BINDING_APPLE")]
		[AliasOf("GL_READ_FRAMEBUFFER_BINDING_EXT")]
		[AliasOf("GL_READ_FRAMEBUFFER_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		public const int READ_FRAMEBUFFER_BINDING = 0x8CAA;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_SAMPLES_ANGLE")]
		[AliasOf("GL_RENDERBUFFER_SAMPLES_APPLE")]
		[AliasOf("GL_RENDERBUFFER_SAMPLES_EXT")]
		[AliasOf("GL_RENDERBUFFER_SAMPLES_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		public const int RENDERBUFFER_SAMPLES = 0x8CAB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_texture_array")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_COMPLETE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_COMPLETE_EXT")]
		[AliasOf("GL_FRAMEBUFFER_COMPLETE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_COMPLETE = 0x8CD5;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNSUPPORTED symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
		[AliasOf("GL_FRAMEBUFFER_UNSUPPORTED_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

		/// <summary>
		/// Value of GL_MAX_COLOR_ATTACHMENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_COLOR_ATTACHMENTS_EXT")]
		[AliasOf("GL_MAX_COLOR_ATTACHMENTS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int MAX_COLOR_ATTACHMENTS = 0x8CDF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT0_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT0_NV")]
		[AliasOf("GL_COLOR_ATTACHMENT0_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int COLOR_ATTACHMENT0 = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT1 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT1_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT1_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT1 = 0x8CE1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT2 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT2_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT2_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT2 = 0x8CE2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT3 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT3_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT3_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT3 = 0x8CE3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT4 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT4_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT4_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT4 = 0x8CE4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT5 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT5_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT5_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT5 = 0x8CE5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT6 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT6_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT6_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT6 = 0x8CE6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT7 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT7_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT7_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT7 = 0x8CE7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT8 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT8_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT8_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT8 = 0x8CE8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT9 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT9_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT9_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT9 = 0x8CE9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT10 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT10_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT10_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT10 = 0x8CEA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT11 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT11_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT11_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT11 = 0x8CEB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT12 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT12_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT12_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT12 = 0x8CEC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT13 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT13_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT13_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT13 = 0x8CED;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT14 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT14_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT14_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT14 = 0x8CEE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT15 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT15_EXT")]
		[AliasOf("GL_COLOR_ATTACHMENT15_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		public const int COLOR_ATTACHMENT15 = 0x8CEF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT16 = 0x8CF0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT17 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT17 = 0x8CF1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT18 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT18 = 0x8CF2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT19 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT19 = 0x8CF3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT20 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT20 = 0x8CF4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT21 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT21 = 0x8CF5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT22 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT22 = 0x8CF6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT23 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT23 = 0x8CF7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT24 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT24 = 0x8CF8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT25 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT25 = 0x8CF9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT26 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT26 = 0x8CFA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT27 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT27 = 0x8CFB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT28 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT28 = 0x8CFC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT29 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT29 = 0x8CFD;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT30 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT30 = 0x8CFE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT31 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int COLOR_ATTACHMENT31 = 0x8CFF;

		/// <summary>
		/// Value of GL_DEPTH_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_ATTACHMENT_EXT")]
		[AliasOf("GL_DEPTH_ATTACHMENT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int DEPTH_ATTACHMENT = 0x8D00;

		/// <summary>
		/// Value of GL_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_ATTACHMENT_EXT")]
		[AliasOf("GL_STENCIL_ATTACHMENT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int STENCIL_ATTACHMENT = 0x8D20;

		/// <summary>
		/// Value of GL_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_EXT")]
		[AliasOf("GL_FRAMEBUFFER_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER = 0x8D40;

		/// <summary>
		/// Value of GL_RENDERBUFFER symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_EXT")]
		[AliasOf("GL_RENDERBUFFER_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER = 0x8D41;

		/// <summary>
		/// Gl.GetRenderbufferParameter: params returns the width in pixels, the height in pixels, internal format, or the number of 
		/// samples, respectively, of the image of the specified renderbuffer object.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_WIDTH_EXT")]
		[AliasOf("GL_RENDERBUFFER_WIDTH_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_WIDTH = 0x8D42;

		/// <summary>
		/// Value of GL_RENDERBUFFER_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_HEIGHT_EXT")]
		[AliasOf("GL_RENDERBUFFER_HEIGHT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_HEIGHT = 0x8D43;

		/// <summary>
		/// Value of GL_RENDERBUFFER_INTERNAL_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
		[AliasOf("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;

		/// <summary>
		/// Value of GL_STENCIL_INDEX1 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX1_EXT")]
		[AliasOf("GL_STENCIL_INDEX1_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_stencil1", Api = "gles1|gles2")]
		public const int STENCIL_INDEX1 = 0x8D46;

		/// <summary>
		/// Value of GL_STENCIL_INDEX4 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX4_EXT")]
		[AliasOf("GL_STENCIL_INDEX4_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_stencil4", Api = "gles1|gles2")]
		public const int STENCIL_INDEX4 = 0x8D47;

		/// <summary>
		/// Value of GL_STENCIL_INDEX8 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX8_EXT")]
		[AliasOf("GL_STENCIL_INDEX8_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_stencil8", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_stencil8", Api = "gles1")]
		[RequiredByFeature("GL_OES_texture_stencil8", Api = "gles2")]
		public const int STENCIL_INDEX8 = 0x8D48;

		/// <summary>
		/// Value of GL_STENCIL_INDEX16 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX16_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_INDEX16 = 0x8D49;

		/// <summary>
		/// Gl.GetRenderbufferParameter: params returns the actual resolution in bits (not the resolution specified when the image 
		/// was defined) for the red, green, blue, alpha, depth or stencil components, respectively, of the image of the 
		/// renderbuffer object.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_RED_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_RED_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_RED_SIZE = 0x8D50;

		/// <summary>
		/// Value of GL_RENDERBUFFER_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_GREEN_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_BLUE_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;

		/// <summary>
		/// Value of GL_RENDERBUFFER_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;

		/// <summary>
		/// Value of GL_RENDERBUFFER_DEPTH_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;

		/// <summary>
		/// Value of GL_RENDERBUFFER_STENCIL_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
		[AliasOf("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;

		/// <summary>
		/// Value of GL_MAX_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_MAX_SAMPLES_ANGLE")]
		[AliasOf("GL_MAX_SAMPLES_APPLE")]
		[AliasOf("GL_MAX_SAMPLES_EXT")]
		[AliasOf("GL_MAX_SAMPLES_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		public const int MAX_SAMPLES = 0x8D57;

		/// <summary>
		/// Value of GL_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public const int INDEX = 0x8222;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_LUMINANCE_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_LUMINANCE_TYPE = 0x8C14;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_INTENSITY_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_INTENSITY_TYPE = 0x8C15;

		/// <summary>
		/// Gl.Enable: if enabled and the value of Gl.FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING for the framebuffer attachment 
		/// corresponding to the destination buffer is Gl.SRGB, the R, G, and B destination color values (after conversion from 
		/// fixed-point to floating-point) are considered to be encoded for the sRGB color space and hence are linearized prior to 
		/// their use in blending.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_SRGB_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_sRGB", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_sRGB")]
		[RequiredByFeature("GL_EXT_sRGB_write_control", Api = "gles2")]
		public const int FRAMEBUFFER_SRGB = 0x8DB9;

		/// <summary>
		/// Value of GL_HALF_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_HALF_FLOAT_ARB")]
		[AliasOf("GL_HALF_FLOAT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_half_float_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_half_float_pixel")]
		[RequiredByFeature("GL_NV_half_float")]
		public const int HALF_FLOAT = 0x140B;

		/// <summary>
		/// Value of GL_MAP_READ_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_READ_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_READ_BIT = 0x0001;

		/// <summary>
		/// Value of GL_MAP_WRITE_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_WRITE_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_WRITE_BIT = 0x0002;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_RANGE_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_INVALIDATE_RANGE_BIT = 0x0004;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_INVALIDATE_BUFFER_BIT = 0x0008;

		/// <summary>
		/// Value of GL_MAP_FLUSH_EXPLICIT_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_FLUSH_EXPLICIT_BIT = 0x0010;

		/// <summary>
		/// Value of GL_MAP_UNSYNCHRONIZED_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_UNSYNCHRONIZED_BIT = 0x0020;

		/// <summary>
		/// Value of GL_COMPRESSED_RED_RGTC1 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RED_RGTC1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_compression_rgtc")]
		public const int COMPRESSED_RED_RGTC1 = 0x8DBB;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RED_RGTC1 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_compression_rgtc")]
		public const int COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;

		/// <summary>
		/// Value of GL_COMPRESSED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		public const int COMPRESSED_RG_RGTC2 = 0x8DBD;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		public const int COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

		/// <summary>
		/// <para>
		/// Gl.TexImage1D: each element is a single red/green double The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a red/green double. The GL converts it to floating point and assembles it into an RGBA 
		/// element by attaching 0 for blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a red and green pair. The GL converts each to floating point and assembles it into an 
		/// RGBA element by attaching 0 for blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// </summary>
		[AliasOf("GL_RG_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		public const int RG = 0x8227;

		/// <summary>
		/// Value of GL_RG_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG_INTEGER = 0x8228;

		/// <summary>
		/// Value of GL_R8 symbol.
		/// </summary>
		[AliasOf("GL_R8_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int R8 = 0x8229;

		/// <summary>
		/// Value of GL_R16 symbol.
		/// </summary>
		[AliasOf("GL_R16_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		public const int R16 = 0x822A;

		/// <summary>
		/// Value of GL_RG8 symbol.
		/// </summary>
		[AliasOf("GL_RG8_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RG8 = 0x822B;

		/// <summary>
		/// Value of GL_RG16 symbol.
		/// </summary>
		[AliasOf("GL_RG16_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		public const int RG16 = 0x822C;

		/// <summary>
		/// Value of GL_R16F symbol.
		/// </summary>
		[AliasOf("GL_R16F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int R16F = 0x822D;

		/// <summary>
		/// Value of GL_R32F symbol.
		/// </summary>
		[AliasOf("GL_R32F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int R32F = 0x822E;

		/// <summary>
		/// Value of GL_RG16F symbol.
		/// </summary>
		[AliasOf("GL_RG16F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RG16F = 0x822F;

		/// <summary>
		/// Value of GL_RG32F symbol.
		/// </summary>
		[AliasOf("GL_RG32F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int RG32F = 0x8230;

		/// <summary>
		/// Value of GL_R8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R8I = 0x8231;

		/// <summary>
		/// Value of GL_R8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R8UI = 0x8232;

		/// <summary>
		/// Value of GL_R16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R16I = 0x8233;

		/// <summary>
		/// Value of GL_R16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R16UI = 0x8234;

		/// <summary>
		/// Value of GL_R32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R32I = 0x8235;

		/// <summary>
		/// Value of GL_R32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int R32UI = 0x8236;

		/// <summary>
		/// Value of GL_RG8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG8I = 0x8237;

		/// <summary>
		/// Value of GL_RG8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG8UI = 0x8238;

		/// <summary>
		/// Value of GL_RG16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG16I = 0x8239;

		/// <summary>
		/// Value of GL_RG16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG16UI = 0x823A;

		/// <summary>
		/// Value of GL_RG32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG32I = 0x823B;

		/// <summary>
		/// Value of GL_RG32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		public const int RG32UI = 0x823C;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the vertex array object currently bound to the context. If no vertex 
		/// array object is bound to the context, 0 is returned. The initial value is 0. See Gl.BindVertexArray.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_BINDING_APPLE")]
		[AliasOf("GL_VERTEX_ARRAY_BINDING_OES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public const int VERTEX_ARRAY_BINDING = 0x85B5;

		/// <summary>
		/// Value of GL_CLAMP_VERTEX_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLAMP_VERTEX_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_VERTEX_COLOR = 0x891A;

		/// <summary>
		/// Value of GL_CLAMP_FRAGMENT_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLAMP_FRAGMENT_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_FRAGMENT_COLOR = 0x891B;

		/// <summary>
		/// Value of GL_ALPHA_INTEGER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_INTEGER = 0x8D97;

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="buf">
		/// For Gl.ColorMaski, specifies the index of the draw buffer whose color mask to set.
		/// </param>
		/// <param name="red">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="green">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="blue">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="alpha">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilMask"/>
		[AliasOf("glColorMaskIndexedEXT")]
		[AliasOf("glColorMaskiEXT")]
		[AliasOf("glColorMaskiOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public static void ColorMask(UInt32 buf, bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglColorMaski != null, "pglColorMaski not implemented");
			Delegates.pglColorMaski(buf, red, green, blue, alpha);
			LogFunction("glColorMaski({0}, {1}, {2}, {3}, {4})", buf, red, green, blue, alpha);
			DebugCheckErrors(null);
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
		[AliasOf("glGetBooleanIndexedvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		public static void Get(Int32 target, UInt32 index, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
					Delegates.pglGetBooleani_v(target, index, p_data);
					LogFunction("glGetBooleani_v({0}, {1}, {2})", LogEnumName(target), index, LogValue(data));
				}
			}
			DebugCheckErrors(null);
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
		[AliasOf("glGetBooleanIndexedvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		public static void Get(Int32 target, UInt32 index, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
					Delegates.pglGetBooleani_v(target, index, p_data);
					LogFunction("glGetBooleani_v({0}, {1}, {2})", LogEnumName(target), index, data);
				}
			}
			DebugCheckErrors(null);
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
		[AliasOf("glGetIntegerIndexedvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		public static void Get(Int32 target, UInt32 index, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
					Delegates.pglGetIntegeri_v(target, index, p_data);
					LogFunction("glGetIntegeri_v({0}, {1}, {2})", LogEnumName(target), index, LogValue(data));
				}
			}
			DebugCheckErrors(null);
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
		[AliasOf("glGetIntegerIndexedvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		public static void Get(Int32 target, UInt32 index, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
					Delegates.pglGetIntegeri_v(target, index, p_data);
					LogFunction("glGetIntegeri_v({0}, {1}, {2})", LogEnumName(target), index, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the switch to disable (for Gl.Enablei and Gl.Disablei only).
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.Enablei and Gl.Disablei if <paramref name="index"/> is greater than or equal to the 
		/// number of indexed capabilities for <paramref name="cap"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[AliasOf("glEnableIndexedEXT")]
		[AliasOf("glEnableiEXT")]
		[AliasOf("glEnableiNV")]
		[AliasOf("glEnableiOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public static void Enable(Int32 cap, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnablei != null, "pglEnablei not implemented");
			Delegates.pglEnablei(cap, index);
			LogFunction("glEnablei({0}, {1})", LogEnumName(cap), index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the switch to disable (for Gl.Enablei and Gl.Disablei only).
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.Enablei and Gl.Disablei if <paramref name="index"/> is greater than or equal to the 
		/// number of indexed capabilities for <paramref name="cap"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[AliasOf("glDisableIndexedEXT")]
		[AliasOf("glDisableiEXT")]
		[AliasOf("glDisableiNV")]
		[AliasOf("glDisableiOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public static void Disable(Int32 cap, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisablei != null, "pglDisablei not implemented");
			Delegates.pglDisablei(cap, index);
			LogFunction("glDisablei({0}, {1})", LogEnumName(cap), index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the capability.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.IsEnabledi if <paramref name="index"/> is outside the valid range for the indexed 
		/// state <paramref name="cap"/>.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Disable"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glIsEnabledIndexedEXT")]
		[AliasOf("glIsEnablediEXT")]
		[AliasOf("glIsEnablediNV")]
		[AliasOf("glIsEnablediOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_draw_buffers2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public static bool IsEnabled(Int32 cap, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabledi != null, "pglIsEnabledi not implemented");
			retValue = Delegates.pglIsEnabledi(cap, index);
			LogFunction("glIsEnabledi({0}, {1}) = {2}", LogEnumName(cap), index, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		/// <param name="primitiveMode">
		/// Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform 
		/// feedback.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginTransformFeedback is executed while transform feedback is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.EndTransformFeedback is executed while transform feedback is not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by glDrawArrays if no geometry shader is present, transform feedback is active and 
		/// <paramref name="mode"/> is not one of the allowed modes.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by glDrawArrays if a geometry shader is present, transform feedback is active and the 
		/// output primitive type of the geometry shader does not match the transform feedback <paramref name="primitiveMode"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EndTransformFeedback if any binding point used in transform feedback mode does 
		/// not have a buffer object bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EndTransformFeedback if no binding points would be used, either because no 
		/// program object is active of because the active program object has specified no varying variables to record.
		/// </exception>
		[AliasOf("glBeginTransformFeedbackEXT")]
		[AliasOf("glBeginTransformFeedbackNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BeginTransformFeedback(Int32 primitiveMode)
		{
			Debug.Assert(Delegates.pglBeginTransformFeedback != null, "pglBeginTransformFeedback not implemented");
			Delegates.pglBeginTransformFeedback(primitiveMode);
			LogFunction("glBeginTransformFeedback({0})", LogEnumName(primitiveMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginTransformFeedback is executed while transform feedback is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.EndTransformFeedback is executed while transform feedback is not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by glDrawArrays if no geometry shader is present, transform feedback is active and 
		/// <paramref name="mode"/> is not one of the allowed modes.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by glDrawArrays if a geometry shader is present, transform feedback is active and the 
		/// output primitive type of the geometry shader does not match the transform feedback <paramref name="primitiveMode"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EndTransformFeedback if any binding point used in transform feedback mode does 
		/// not have a buffer object bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EndTransformFeedback if no binding points would be used, either because no 
		/// program object is active of because the active program object has specified no varying variables to record.
		/// </exception>
		[AliasOf("glEndTransformFeedbackEXT")]
		[AliasOf("glEndTransformFeedbackNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void EndTransformFeedback()
		{
			Debug.Assert(Delegates.pglEndTransformFeedback != null, "pglEndTransformFeedback not implemented");
			Delegates.pglEndTransformFeedback();
			LogFunction("glEndTransformFeedback()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a range within a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. <paramref name="target"/> must be one of Gl.ATOMIC_COUNTER_BUFFER, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER, or Gl.SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by <paramref name="target"/>.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point.
		/// </param>
		/// <param name="offset">
		/// The starting offset in basic machine units into the buffer object <paramref name="buffer"/>.
		/// </param>
		/// <param name="size">
		/// The amount of data in machine units that can be read from the buffer object while used as an indexed target.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of Gl.ATOMIC_COUNTER_BUFFER, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of <paramref 
		/// name="target"/>-specific indexed binding points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to zero, or if <paramref name="offset"/> 
		/// + <paramref name="size"/> is greater than the value of Gl.BUFFER_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Additional errors may be generated if <paramref name="offset"/> violates any <paramref name="target"/>-specific 
		/// alignmemt restrictions.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBindBufferRangeEXT")]
		[AliasOf("glBindBufferRangeNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferRange(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglBindBufferRange != null, "pglBindBufferRange not implemented");
			Delegates.pglBindBufferRange(target, index, buffer, offset, size);
			LogFunction("glBindBufferRange({0}, {1}, {2}, 0x{3}, {4})", LogEnumName(target), index, buffer, offset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. <paramref name="target"/> must be one of Gl.ATOMIC_COUNTER_BUFFER, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by <paramref name="target"/>.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.ATOMIC_COUNTER_BUFFER, Gl.TRANSFORM_FEEDBACK_BUFFER, 
		/// Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of <paramref 
		/// name="target"/>-specific indexed binding points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> does not have an associated data store, or if the size of 
		/// that store is zero.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBindBufferBaseEXT")]
		[AliasOf("glBindBufferBaseNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferBase(Int32 target, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferBase != null, "pglBindBufferBase not implemented");
			Delegates.pglBindBufferBase(target, index, buffer);
			LogFunction("glBindBufferBase({0}, {1}, {2})", LogEnumName(target), index, buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify values to record in transform feedback buffers
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="varyings">
		/// An array of <paramref name="count"/> zero-terminated strings specifying the names of the varying variables to use for 
		/// transform feedback.
		/// </param>
		/// <param name="bufferMode">
		/// Identifies the mode used to capture the varying variables when transform feedback is active. <paramref 
		/// name="bufferMode"/> must be Gl.INTERLEAVED_ATTRIBS or Gl.SEPARATE_ATTRIBS.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufferMode"/> is Gl.SEPARATE_ATTRIBS and <paramref name="count"/> is 
		/// greater than the implementation-dependent limit Gl.MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.GetTransformFeedbackVarying"/>
		[AliasOf("glTransformFeedbackVaryingsEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void TransformFeedbackVaryings(UInt32 program, String[] varyings, Int32 bufferMode)
		{
			Debug.Assert(Delegates.pglTransformFeedbackVaryings != null, "pglTransformFeedbackVaryings not implemented");
			Delegates.pglTransformFeedbackVaryings(program, (Int32)varyings.Length, varyings, bufferMode);
			LogFunction("glTransformFeedbackVaryings({0}, {1}, {2}, {3})", program, varyings.Length, LogValue(varyings), LogEnumName(bufferMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about varying variables selected for transform feedback
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="index">
		/// The index of the varying variable whose information to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// The maximum number of characters, including the null terminator, that may be written into <paramref name="name"/>.
		/// </param>
		/// <param name="length">
		/// The address of a variable which will receive the number of characters written into <paramref name="name"/>, excluding 
		/// the null-terminator. If <paramref name="length"/> is Gl.L no length is returned.
		/// </param>
		/// <param name="size">
		/// The address of a variable that will receive the size of the varying.
		/// </param>
		/// <param name="type">
		/// The address of a variable that will recieve the type of the varying.
		/// </param>
		/// <param name="name">
		/// The address of a buffer into which will be written the name of the varying.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater or equal to the value of 
		/// Gl.TRANSFORM_FEEDBACK_VARYINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated <paramref name="program"/> has not been linked.
		/// </exception>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.TransformFeedbackVaryings"/>
		/// <seealso cref="Gl.GetProgram"/>
		[AliasOf("glGetTransformFeedbackVaryingEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackVarying != null, "pglGetTransformFeedbackVarying not implemented");
					Delegates.pglGetTransformFeedbackVarying(program, index, bufSize, p_length, p_size, p_type, name);
					LogFunction("glGetTransformFeedbackVarying({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, LogEnumName(type), name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify whether data read via glReadPixels should be clamped
		/// </summary>
		/// <param name="target">
		/// Target for color clamping. <paramref name="target"/> must be Gl.CLAMP_READ_COLOR.
		/// </param>
		/// <param name="clamp">
		/// Specifies whether to apply color clamping. <paramref name="clamp"/> must be Gl.TRUE or Gl.FALSE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CLAMP_READ_COLOR.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="clamp"/> is not Gl.TRUE or Gl.FALSE.
		/// </exception>
		[AliasOf("glClampColorARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public static void ClampColor(Int32 target, Int32 clamp)
		{
			Debug.Assert(Delegates.pglClampColor != null, "pglClampColor not implemented");
			Delegates.pglClampColor(target, clamp);
			LogFunction("glClampColor({0}, {1})", LogEnumName(target), LogEnumName(clamp));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		/// <param name="id">
		/// Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are 
		/// discarded.
		/// </param>
		/// <param name="mode">
		/// Specifies how Gl.BeginConditionalRender interprets the results of the occlusion query.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of an existing query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginConditionalRender is called while conditional rendering is active, or if 
		/// Gl.EndConditionalRender is called while conditional rendering is inactive.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a query object with a target other than 
		/// Gl.SAMPLES_PASSED or Gl.ANY_SAMPLES_PASSED.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a query currently in progress.
		/// </exception>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.BeginQuery"/>
		[AliasOf("glBeginConditionalRenderNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public static void BeginConditionalRender(UInt32 id, Int32 mode)
		{
			Debug.Assert(Delegates.pglBeginConditionalRender != null, "pglBeginConditionalRender not implemented");
			Delegates.pglBeginConditionalRender(id, mode);
			LogFunction("glBeginConditionalRender({0}, {1})", id, LogEnumName(mode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of an existing query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginConditionalRender is called while conditional rendering is active, or if 
		/// Gl.EndConditionalRender is called while conditional rendering is inactive.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a query object with a target other than 
		/// Gl.SAMPLES_PASSED or Gl.ANY_SAMPLES_PASSED.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a query currently in progress.
		/// </exception>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.BeginQuery"/>
		[AliasOf("glEndConditionalRenderNV")]
		[AliasOf("glEndConditionalRenderNVX")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NVX_conditional_render")]
		[RequiredByFeature("GL_NV_conditional_render", Api = "gl|gles2")]
		public static void EndConditionalRender()
		{
			Debug.Assert(Delegates.pglEndConditionalRender != null, "pglEndConditionalRender not implemented");
			Delegates.pglEndConditionalRender();
			LogFunction("glEndConditionalRender()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribIPointerEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribIPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribIPointer != null, "pglVertexAttribIPointer not implemented");
			Delegates.pglVertexAttribIPointer(index, size, type, stride, pointer);
			LogFunction("glVertexAttribIPointer({0}, {1}, {2}, {3}, 0x{4})", index, size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribIPointerEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribIPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribIPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribIivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void GetVertexAttribI(UInt32 index, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIiv != null, "pglGetVertexAttribIiv not implemented");
					Delegates.pglGetVertexAttribIiv(index, pname, p_params);
					LogFunction("glGetVertexAttribIiv({0}, {1}, {2})", index, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribIuivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void GetVertexAttribI(UInt32 index, Int32 pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIuiv != null, "pglGetVertexAttribIuiv not implemented");
					Delegates.pglGetVertexAttribIuiv(index, pname, p_params);
					LogFunction("glGetVertexAttribIuiv({0}, {1}, {2})", index, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI1iEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1(UInt32 index, Int32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1i != null, "pglVertexAttribI1i not implemented");
			Delegates.pglVertexAttribI1i(index, x);
			LogFunction("glVertexAttribI1i({0}, {1})", index, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI2iEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2(UInt32 index, Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2i != null, "pglVertexAttribI2i not implemented");
			Delegates.pglVertexAttribI2i(index, x, y);
			LogFunction("glVertexAttribI2i({0}, {1}, {2})", index, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI3iEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3i != null, "pglVertexAttribI3i not implemented");
			Delegates.pglVertexAttribI3i(index, x, y, z);
			LogFunction("glVertexAttribI3i({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4iEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4i != null, "pglVertexAttribI4i not implemented");
			Delegates.pglVertexAttribI4i(index, x, y, z, w);
			LogFunction("glVertexAttribI4i({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI1uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1(UInt32 index, UInt32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1ui != null, "pglVertexAttribI1ui not implemented");
			Delegates.pglVertexAttribI1ui(index, x);
			LogFunction("glVertexAttribI1ui({0}, {1})", index, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI2uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2(UInt32 index, UInt32 x, UInt32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2ui != null, "pglVertexAttribI2ui not implemented");
			Delegates.pglVertexAttribI2ui(index, x, y);
			LogFunction("glVertexAttribI2ui({0}, {1}, {2})", index, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI3uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3ui != null, "pglVertexAttribI3ui not implemented");
			Delegates.pglVertexAttribI3ui(index, x, y, z);
			LogFunction("glVertexAttribI3ui({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4ui != null, "pglVertexAttribI4ui not implemented");
			Delegates.pglVertexAttribI4ui(index, x, y, z, w);
			LogFunction("glVertexAttribI4ui({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI1ivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1iv != null, "pglVertexAttribI1iv not implemented");
					Delegates.pglVertexAttribI1iv(index, p_v);
					LogFunction("glVertexAttribI1iv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI2ivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2iv != null, "pglVertexAttribI2iv not implemented");
					Delegates.pglVertexAttribI2iv(index, p_v);
					LogFunction("glVertexAttribI2iv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI3ivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3iv != null, "pglVertexAttribI3iv not implemented");
					Delegates.pglVertexAttribI3iv(index, p_v);
					LogFunction("glVertexAttribI3iv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4ivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4iv != null, "pglVertexAttribI4iv not implemented");
					Delegates.pglVertexAttribI4iv(index, p_v);
					LogFunction("glVertexAttribI4iv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI1uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1uiv != null, "pglVertexAttribI1uiv not implemented");
					Delegates.pglVertexAttribI1uiv(index, p_v);
					LogFunction("glVertexAttribI1uiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI2uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2uiv != null, "pglVertexAttribI2uiv not implemented");
					Delegates.pglVertexAttribI2uiv(index, p_v);
					LogFunction("glVertexAttribI2uiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI3uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3uiv != null, "pglVertexAttribI3uiv not implemented");
					Delegates.pglVertexAttribI3uiv(index, p_v);
					LogFunction("glVertexAttribI3uiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4uiv != null, "pglVertexAttribI4uiv not implemented");
					Delegates.pglVertexAttribI4uiv(index, p_v);
					LogFunction("glVertexAttribI4uiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4bvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4bv != null, "pglVertexAttribI4bv not implemented");
					Delegates.pglVertexAttribI4bv(index, p_v);
					LogFunction("glVertexAttribI4bv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4svEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4sv != null, "pglVertexAttribI4sv not implemented");
					Delegates.pglVertexAttribI4sv(index, p_v);
					LogFunction("glVertexAttribI4sv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4ubvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4ubv != null, "pglVertexAttribI4ubv not implemented");
					Delegates.pglVertexAttribI4ubv(index, p_v);
					LogFunction("glVertexAttribI4ubv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribI4usvEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4usv != null, "pglVertexAttribI4usv not implemented");
					Delegates.pglVertexAttribI4usv(index, p_v);
					LogFunction("glVertexAttribI4usv({0}, {1})", index, LogValue(v));
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
		[AliasOf("glGetUniformuivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformuiv != null, "pglGetUniformuiv not implemented");
					Delegates.pglGetUniformuiv(program, location, p_params);
					LogFunction("glGetUniformuiv({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a user-defined varying out variable to a fragment shader color number
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to modify
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to modify
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="colorNumber"/> is greater than or equal to Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> starts with the reserved Gl. prefix.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.ogram is not the name of a program object.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.GetFragDataLocation"/>
		[AliasOf("glBindFragDataLocationEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void BindFragDataLocation(UInt32 program, UInt32 color, String name)
		{
			Debug.Assert(Delegates.pglBindFragDataLocation != null, "pglBindFragDataLocation not implemented");
			Delegates.pglBindFragDataLocation(program, color, name);
			LogFunction("glBindFragDataLocation({0}, {1}, {2})", program, color, name);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the bindings of color numbers to user-defined varying out variables
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to query
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to query
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.BindFragDataLocation"/>
		[AliasOf("glGetFragDataLocationEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static Int32 GetFragDataLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFragDataLocation != null, "pglGetFragDataLocation not implemented");
			retValue = Delegates.pglGetFragDataLocation(program, name);
			LogFunction("glGetFragDataLocation({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform1(Int32 location, UInt32 v0)
		{
			Debug.Assert(Delegates.pglUniform1ui != null, "pglUniform1ui not implemented");
			Delegates.pglUniform1ui(location, v0);
			LogFunction("glUniform1ui({0}, {1})", location, v0);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform2(Int32 location, UInt32 v0, UInt32 v1)
		{
			Debug.Assert(Delegates.pglUniform2ui != null, "pglUniform2ui not implemented");
			Delegates.pglUniform2ui(location, v0, v1);
			LogFunction("glUniform2ui({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform3(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			Debug.Assert(Delegates.pglUniform3ui != null, "pglUniform3ui not implemented");
			Delegates.pglUniform3ui(location, v0, v1, v2);
			LogFunction("glUniform3ui({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4uiEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform4(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			Debug.Assert(Delegates.pglUniform4ui != null, "pglUniform4ui not implemented");
			Delegates.pglUniform4ui(location, v0, v1, v2, v3);
			LogFunction("glUniform4ui({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform1(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
					Delegates.pglUniform1uiv(location, count, p_value);
					LogFunction("glUniform1uiv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static unsafe void Uniform1(Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
			Delegates.pglUniform1uiv(location, count, value);
			LogFunction("glUniform1uiv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform2(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
					Delegates.pglUniform2uiv(location, count, p_value);
					LogFunction("glUniform2uiv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static unsafe void Uniform2(Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
			Delegates.pglUniform2uiv(location, count, value);
			LogFunction("glUniform2uiv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform3(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
					Delegates.pglUniform3uiv(location, count, p_value);
					LogFunction("glUniform3uiv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static unsafe void Uniform3(Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
			Delegates.pglUniform3uiv(location, count, value);
			LogFunction("glUniform3uiv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static void Uniform4(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
					Delegates.pglUniform4uiv(location, count, p_value);
					LogFunction("glUniform4uiv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4uivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public static unsafe void Uniform4(Int32 location, Int32 count, UInt32* value)
		{
			Debug.Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
			Delegates.pglUniform4uiv(location, count, value);
			LogFunction("glUniform4uiv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexParameter functions. Must be one of Gl.TEXTURE_1D, 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, or Gl.TEXTURE_RECTANGLE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_COMPARE_FUNC, Gl.TEXTURE_COMPARE_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_SWIZZLE_R, Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, or Gl.TEXTURE_WRAP_R.
		/// </param>
		/// <param name="params">
		/// For the vector commands, specifies a pointer to an array where the value or values of <paramref name="pname"/> are 
		/// stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TexParameter if <paramref name="target"/> is not one of the accepted defined values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted defined values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.TexParameter{if} or Gl.TextureParameter{if} is called for a non-scalar parameter 
		/// (pname Gl.TEXTURE_BORDER_COLOR or Gl.TEXTURE_SWIZZLE_RGBA).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is either Gl.TEXTURE_2D_MULTISAMPLE or 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, and <paramref name="pname"/> is any of the sampler states.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is Gl.TEXTURE_RECTANGLE and either of pnames Gl.TEXTURE_WRAP_S or 
		/// Gl.TEXTURE_WRAP_T is set to either Gl.MIRROR_CLAMP_TO_EDGE, Gl.MIRRORED_REPEAT or Gl.REPEAT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is Gl.TEXTURE_RECTANGLE and pname Gl.TEXTURE_MIN_FILTER is set to a 
		/// value other than Gl.NEAREST or Gl.LINEAR (no mipmap filtering is permitted).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the effective target is either Gl.TEXTURE_2D_MULTISAMPLE or 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, and pname Gl.TEXTURE_BASE_LEVEL is set to a value other than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureParameter if texture is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the effective target is Gl.TEXTURE_RECTANGLE and pname Gl.TEXTURE_BASE_LEVEL is set 
		/// to any value other than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.TEXTURE_BASE_LEVEL or Gl.TEXTURE_MAX_LEVEL, and 
		/// <paramref name="param"/> or <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glTexParameterIivEXT")]
		[AliasOf("glTexParameterIivOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void TexParameterI(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIiv != null, "pglTexParameterIiv not implemented");
					Delegates.pglTexParameterIiv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexParameterIiv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexParameter functions. Must be one of Gl.TEXTURE_1D, 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, or Gl.TEXTURE_RECTANGLE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_COMPARE_FUNC, Gl.TEXTURE_COMPARE_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_SWIZZLE_R, Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, or Gl.TEXTURE_WRAP_R.
		/// </param>
		/// <param name="params">
		/// For the vector commands, specifies a pointer to an array where the value or values of <paramref name="pname"/> are 
		/// stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TexParameter if <paramref name="target"/> is not one of the accepted defined values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted defined values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.TexParameter{if} or Gl.TextureParameter{if} is called for a non-scalar parameter 
		/// (pname Gl.TEXTURE_BORDER_COLOR or Gl.TEXTURE_SWIZZLE_RGBA).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is either Gl.TEXTURE_2D_MULTISAMPLE or 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, and <paramref name="pname"/> is any of the sampler states.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is Gl.TEXTURE_RECTANGLE and either of pnames Gl.TEXTURE_WRAP_S or 
		/// Gl.TEXTURE_WRAP_T is set to either Gl.MIRROR_CLAMP_TO_EDGE, Gl.MIRRORED_REPEAT or Gl.REPEAT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the effective target is Gl.TEXTURE_RECTANGLE and pname Gl.TEXTURE_MIN_FILTER is set to a 
		/// value other than Gl.NEAREST or Gl.LINEAR (no mipmap filtering is permitted).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the effective target is either Gl.TEXTURE_2D_MULTISAMPLE or 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, and pname Gl.TEXTURE_BASE_LEVEL is set to a value other than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureParameter if texture is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the effective target is Gl.TEXTURE_RECTANGLE and pname Gl.TEXTURE_BASE_LEVEL is set 
		/// to any value other than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.TEXTURE_BASE_LEVEL or Gl.TEXTURE_MAX_LEVEL, and 
		/// <paramref name="param"/> or <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[AliasOf("glTexParameterIuivEXT")]
		[AliasOf("glTexParameterIuivOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void TexParameterI(TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIuiv != null, "pglTexParameterIuiv not implemented");
					Delegates.pglTexParameterIuiv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexParameterIuiv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[AliasOf("glGetTexParameterIivEXT")]
		[AliasOf("glGetTexParameterIivOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
					Delegates.pglGetTexParameterIiv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexParameterIiv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[AliasOf("glGetTexParameterIuivEXT")]
		[AliasOf("glGetTexParameterIuivOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
					Delegates.pglGetTexParameterIuiv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexParameterIuiv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ClearBuffer(Int32 buffer, Int32 drawbuffer, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferiv != null, "pglClearBufferiv not implemented");
					Delegates.pglClearBufferiv(buffer, drawbuffer, p_value);
					LogFunction("glClearBufferiv({0}, {1}, {2})", LogEnumName(buffer), drawbuffer, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ClearBuffer(Int32 buffer, Int32 drawbuffer, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferuiv != null, "pglClearBufferuiv not implemented");
					Delegates.pglClearBufferuiv(buffer, drawbuffer, p_value);
					LogFunction("glClearBufferuiv({0}, {1}, {2})", LogEnumName(buffer), drawbuffer, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ClearBuffer(Int32 buffer, Int32 drawbuffer, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferfv != null, "pglClearBufferfv not implemented");
					Delegates.pglClearBufferfv(buffer, drawbuffer, p_value);
					LogFunction("glClearBufferfv({0}, {1}, {2})", LogEnumName(buffer), drawbuffer, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="depth">
		/// The value to clear the depth buffer to.
		/// </param>
		/// <param name="stencil">
		/// The value to clear the stencil buffer to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ClearBuffer(Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil)
		{
			Debug.Assert(Delegates.pglClearBufferfi != null, "pglClearBufferfi not implemented");
			Delegates.pglClearBufferfi(buffer, drawbuffer, depth, stencil);
			LogFunction("glClearBufferfi({0}, {1}, {2}, {3})", LogEnumName(buffer), drawbuffer, depth, stencil);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of Gl.VENDOR, Gl.RENDERER, Gl.VERSION, or Gl.SHADING_LANGUAGE_VERSION. Additionally, 
		/// Gl.GetStringi accepts the Gl.EXTENSIONS token.
		/// </param>
		/// <param name="index">
		/// For Gl.GetStringi, specifies the index of the string to return.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="name"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.GetStringi if <paramref name="index"/> is outside the valid range for indexed state 
		/// <paramref name="name"/>.
		/// </exception>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static String GetString(Int32 name, UInt32 index)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglGetStringi != null, "pglGetStringi not implemented");
			retValue = Delegates.pglGetStringi(name, index);
			LogFunction("glGetStringi({0}, {1}) = {2}", LogEnumName(name), index, Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// determine if a name corresponds to a renderbuffer object
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies a value that may be the name of a renderbuffer object.
		/// </param>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[AliasOf("glIsRenderbufferEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static bool IsRenderbuffer(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbuffer != null, "pglIsRenderbuffer not implemented");
			retValue = Delegates.pglIsRenderbuffer(renderbuffer);
			LogFunction("glIsRenderbuffer({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// bind a renderbuffer to a renderbuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the renderbuffer target of the binding operation. <paramref name="target"/> must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object to bind.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="renderbuffer"/> is not zero or the name of a renderbuffer 
		/// previously returned from a call to glGenRenderbuffers.
		/// </exception>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.IsRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public static void BindRenderbuffer(Int32 target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbuffer != null, "pglBindRenderbuffer not implemented");
			Delegates.pglBindRenderbuffer(target, renderbuffer);
			LogFunction("glBindRenderbuffer({0}, {1})", LogEnumName(target), renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete renderbuffer objects
		/// </summary>
		/// <param name="renderbuffers">
		/// A pointer to an array containing <paramref name="n"/> renderbuffer objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		[AliasOf("glDeleteRenderbuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteRenderbuffers(params UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffers != null, "pglDeleteRenderbuffers not implemented");
					Delegates.pglDeleteRenderbuffers((Int32)renderbuffers.Length, p_renderbuffers);
					LogFunction("glDeleteRenderbuffers({0}, {1})", renderbuffers.Length, LogValue(renderbuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate renderbuffer object names
		/// </summary>
		/// <param name="renderbuffers">
		/// Specifies an array in which the generated renderbuffer object names are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[AliasOf("glGenRenderbuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenRenderbuffers(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffers != null, "pglGenRenderbuffers not implemented");
					Delegates.pglGenRenderbuffers((Int32)renderbuffers.Length, p_renderbuffers);
					LogFunction("glGenRenderbuffers({0}, {1})", renderbuffers.Length, LogValue(renderbuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate renderbuffer object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[AliasOf("glGenRenderbuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static UInt32 GenRenderbuffer()
		{
			UInt32[] retValue = new UInt32[1];
			GenRenderbuffers(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// establish data storage, format and dimensions of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for Gl.RenderbufferStorage function. Must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.RenderbufferStorage if <paramref name="target"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by glNamedRenderbufferStorage if <paramref name="renderbuffer"/> is not the name of an 
		/// existing renderbuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either of <paramref name="width"/> or <paramref name="height"/> is negative, or greater 
		/// than the value of Gl.MAX_RENDERBUFFER_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a color-renderable, depth-renderable, or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[AliasOf("glRenderbufferStorageEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void RenderbufferStorage(Int32 target, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorage != null, "pglRenderbufferStorage not implemented");
			Delegates.pglRenderbufferStorage(target, internalformat, width, height);
			LogFunction("glRenderbufferStorage({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query a named parameter of a renderbuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the renderbuffer object is bound for Gl.GetRenderbufferParameteriv. <paramref 
		/// name="target"/> must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the renderbuffer object to query.
		/// </param>
		/// <param name="params">
		/// Returns the value of parameter <paramref name="pname"/> for the renderbuffer object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetRenderbufferParameteriv if <paramref name="target"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetRenderbufferParameteriv if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedRenderbufferParameteriv if <paramref name="renderbuffer"/> is not the 
		/// name of an existing renderbuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted parameter names described above.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		[AliasOf("glGetRenderbufferParameterivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GetRenderbufferParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
					Delegates.pglGetRenderbufferParameteriv(target, pname, p_params);
					LogFunction("glGetRenderbufferParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// determine if a name corresponds to a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies a value that may be the name of a framebuffer object.
		/// </param>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		[AliasOf("glIsFramebufferEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static bool IsFramebuffer(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebuffer != null, "pglIsFramebuffer not implemented");
			retValue = Delegates.pglIsFramebuffer(framebuffer);
			LogFunction("glIsFramebuffer({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// bind a framebuffer to a framebuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the framebuffer target of the binding operation.
		/// </param>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object to bind.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.DRAW_FRAMEBUFFER, Gl.READ_FRAMEBUFFER or 
		/// Gl.FRAMEBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="framebuffer"/> is not zero or the name of a framebuffer previously 
		/// returned from a call to glGenFramebuffers.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		/// <seealso cref="Gl.FramebufferTextureLayer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.IsFramebuffer"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		public static void BindFramebuffer(Int32 target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebuffer != null, "pglBindFramebuffer not implemented");
			Delegates.pglBindFramebuffer(target, framebuffer);
			LogFunction("glBindFramebuffer({0}, {1})", LogEnumName(target), framebuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete framebuffer objects
		/// </summary>
		/// <param name="framebuffers">
		/// A pointer to an array containing <paramref name="n"/> framebuffer objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		[AliasOf("glDeleteFramebuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteFramebuffers(params UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffers != null, "pglDeleteFramebuffers not implemented");
					Delegates.pglDeleteFramebuffers((Int32)framebuffers.Length, p_framebuffers);
					LogFunction("glDeleteFramebuffers({0}, {1})", framebuffers.Length, LogValue(framebuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate framebuffer object names
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		[AliasOf("glGenFramebuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenFramebuffers(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffers != null, "pglGenFramebuffers not implemented");
					Delegates.pglGenFramebuffers((Int32)framebuffers.Length, p_framebuffers);
					LogFunction("glGenFramebuffers({0}, {1})", framebuffers.Length, LogValue(framebuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate framebuffer object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		[AliasOf("glGenFramebuffersEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static UInt32 GenFramebuffer()
		{
			UInt32[] retValue = new UInt32[1];
			GenFramebuffers(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// check the completeness status of a framebuffer
		/// </summary>
		/// <param name="target">
		/// Specify the target to which the framebuffer is bound for Gl.CheckFramebufferStatus, and the target against which 
		/// framebuffer completeness of <paramref name="framebuffer"/> is checked for Gl.CheckNamedFramebufferStatus.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.DRAW_FRAMEBUFFER, Gl.READ_FRAMEBUFFER or 
		/// Gl.FRAMEBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CheckNamedFramebufferStatus if <paramref name="framebuffer"/> is not zero or the 
		/// name of an existing framebuffer object.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		[AliasOf("glCheckFramebufferStatusEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static Int32 CheckFramebufferStatus(Int32 target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatus != null, "pglCheckFramebufferStatus not implemented");
			retValue = Delegates.pglCheckFramebufferStatus(target);
			LogFunction("glCheckFramebufferStatus({0}) = {1}", LogEnumName(target), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
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
		/// <param name="textarget">
		/// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is 
		/// expected in the <paramref name="texture"/> parameter, or for cube map textures, which face is to be attached.
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
		[AliasOf("glFramebufferTexture1DEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferTexture1D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture1D != null, "pglFramebufferTexture1D not implemented");
			Delegates.pglFramebufferTexture1D(target, attachment, textarget, texture, level);
			LogFunction("glFramebufferTexture1D({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(attachment), LogEnumName(textarget), texture, level);
			DebugCheckErrors(null);
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
		/// <param name="textarget">
		/// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is 
		/// expected in the <paramref name="texture"/> parameter, or for cube map textures, which face is to be attached.
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
		[AliasOf("glFramebufferTexture2DEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferTexture2D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2D != null, "pglFramebufferTexture2D not implemented");
			Delegates.pglFramebufferTexture2D(target, attachment, textarget, texture, level);
			LogFunction("glFramebufferTexture2D({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(attachment), LogEnumName(textarget), texture, level);
			DebugCheckErrors(null);
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
		/// <param name="textarget">
		/// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is 
		/// expected in the <paramref name="texture"/> parameter, or for cube map textures, which face is to be attached.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
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
		[AliasOf("glFramebufferTexture3DEXT")]
		[AliasOf("glFramebufferTexture3DOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public static void FramebufferTexture3D(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglFramebufferTexture3D != null, "pglFramebufferTexture3D not implemented");
			Delegates.pglFramebufferTexture3D(target, attachment, textarget, texture, level, layer);
			LogFunction("glFramebufferTexture3D({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(attachment), LogEnumName(textarget), texture, level, layer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for Gl.FramebufferRenderbuffer.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="renderbuffertarget">
		/// Specifies the renderbuffer target. Must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of an existing renderbuffer object of type <paramref name="renderbuffertarget"/> to attach.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferRenderbuffer if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferRenderbuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferRenderbuffer if <paramref name="framebuffer"/> is not the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="renderbuffertarget"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="renderbuffertarget"/> is not zero or the name of an existing 
		/// renderbuffer object of type Gl.RENDERBUFFER.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		[AliasOf("glFramebufferRenderbufferEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferRenderbuffer(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbuffer != null, "pglFramebufferRenderbuffer not implemented");
			Delegates.pglFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
			LogFunction("glFramebufferRenderbuffer({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(attachment), LogEnumName(renderbuffertarget), renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferAttachmentParameteriv.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment of the framebuffer object to query.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of <paramref name="attachment"/> to query.
		/// </param>
		/// <param name="params">
		/// Returns the value of parameter <paramref name="pname"/> for <paramref name="attachment"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetFramebufferAttachmentParameteriv if <paramref name="target"/> is not one of the 
		/// accepted framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedFramebufferAttachmentParameteriv if <paramref name="framebuffer"/> is 
		/// not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not valid for the value of 
		/// Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, as described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is not one of the accepted framebuffer attachment 
		/// points, as described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is Gl.NONE and <paramref 
		/// name="pname"/> is not Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_NAME or Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is Gl.DEPTH_STENCIL_ATTACHMENT and different objects 
		/// are bound to the depth and stencil attachment points of <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is Gl.DEPTH_STENCIL_ATTACHMENT and <paramref 
		/// name="pname"/> is Gl.FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		[AliasOf("glGetFramebufferAttachmentParameterivEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GetFramebufferAttachmentParameter(Int32 target, Int32 attachment, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
					Delegates.pglGetFramebufferAttachmentParameteriv(target, attachment, pname, p_params);
					LogFunction("glGetFramebufferAttachmentParameteriv({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(attachment), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate mipmaps for a specified texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.GenerateMipmap. Must be one of Gl.TEXTURE_1D, 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_CUBE_MAP, or 
		/// Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GenerateMipmap if <paramref name="target"/> is not one of the accepted texture 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GenerateTextureMipmap if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP or Gl.TEXTURE_CUBE_MAP_ARRAY, and 
		/// the specified texture object is not cube complete or cube array complete, respectively.
		/// </exception>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GenTextures"/>
		[AliasOf("glGenerateMipmapEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenerateMipmap(Int32 target)
		{
			Debug.Assert(Delegates.pglGenerateMipmap != null, "pglGenerateMipmap not implemented");
			Delegates.pglGenerateMipmap(target);
			LogFunction("glGenerateMipmap({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="srcX0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are Gl.COLOR_BUFFER_BIT, 
		/// Gl.DEPTH_BUFFER_BIT and Gl.STENCIL_BUFFER_BIT.
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be Gl.NEAREST or Gl.LINEAR.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.itNamedFramebuffer if <paramref name="readFramebuffer"/> or <paramref 
		/// name="drawFramebuffer"/> is not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains any of the Gl.DEPTH_BUFFER_BIT or 
		/// Gl.STENCIL_BUFFER_BIT and <paramref name="filter"/> is not Gl.NEAREST.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains Gl.COLOR_BUFFER_BIT and any of the following 
		/// conditions hold: The read buffer contains fixed-point or floating-point values and any draw buffer contains neither 
		/// fixed-point nor floating-point values. The read buffer contains unsigned integer values and any draw buffer does not 
		/// contain unsigned integer values. The read buffer contains signed integer values and any draw buffer does not contain 
		/// signed integer values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains Gl.DEPTH_BUFFER_BIT or Gl.STENCIL_BUFFER_BIT and 
		/// the source and destination depth and stencil formats do not match.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="filter"/> is Gl.LINEAR and the read buffer contains integer data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the effective value of Gl.SAMPLES for the read and draw framebuffers is not 
		/// identical.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.SAMPLE_BUFFERS for both read and draw buffers is greater than zero 
		/// and the dimensions of the source and destination rectangles is not identical.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_FRAMEBUFFER_OPERATION is generated if the specified read and draw framebuffers are not framebuffer complete.
		/// </exception>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		[AliasOf("glBlitFramebufferEXT")]
		[AliasOf("glBlitFramebufferNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		public static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, Int32 filter)
		{
			Debug.Assert(Delegates.pglBlitFramebuffer != null, "pglBlitFramebuffer not implemented");
			Delegates.pglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (UInt32)mask, filter);
			LogFunction("glBlitFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, LogEnumName(filter));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// establish data storage, format, dimensions and sample count of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for Gl.RenderbufferStorageMultisample function. Must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="samples">
		/// Specifies the number of samples to be used for the renderbuffer object's storage.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.RenderbufferStorageMultisample function if <paramref name="target"/> is not 
		/// Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedRenderbufferStorageMultisample function if <paramref name="renderbuffer"/> 
		/// is not the name of an existing renderbuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is greater than Gl.MAX_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a color-renderable, depth-renderable, or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either of <paramref name="width"/> or <paramref name="height"/> is negative, or greater 
		/// than the value of Gl.MAX_RENDERBUFFER_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[AliasOf("glRenderbufferStorageMultisampleEXT")]
		[AliasOf("glRenderbufferStorageMultisampleNV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		public static void RenderbufferStorageMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisample != null, "pglRenderbufferStorageMultisample not implemented");
			Delegates.pglRenderbufferStorageMultisample(target, samples, internalformat, width, height);
			LogFunction("glRenderbufferStorageMultisample({0}, {1}, {2}, {3}, {4})", LogEnumName(target), samples, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for Gl.FramebufferTextureLayer.
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
		/// <param name="layer">
		/// Specifies the layer of the texture object to attach.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferTexture if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferTexture if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferTexture if <paramref name="framebuffer"/> is not the name of an 
		/// existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is not zero and is not the name of an existing 
		/// three-dimensional, two-dimensional multisample array, one- or two-dimensional array, cube map, or cube map array 
		/// texture.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="level"/> is not a supported 
		/// texture level for <paramref name="texture"/>, as described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="layer"/> is larger than the 
		/// value of Gl.MAX_3D_TEXTURE_SIZE minus one (for three-dimensional texture objects), or larger than the value of 
		/// Gl.MAX_ARRAY_TEXTURE_LAYERS minus one (for array texture objects).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="layer"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		[AliasOf("glFramebufferTextureLayerARB")]
		[AliasOf("glFramebufferTextureLayerEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_texture_array")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureLayer(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglFramebufferTextureLayer != null, "pglFramebufferTextureLayer not implemented");
			Delegates.pglFramebufferTextureLayer(target, attachment, texture, level, layer);
			LogFunction("glFramebufferTextureLayer({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(attachment), texture, level, layer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// map all or part of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.MapBufferRange, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the starting offset within the buffer of the range to be mapped.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the range to be mapped.
		/// </param>
		/// <param name="access">
		/// Specifies a combination of access flags indicating the desired access to the mapped range.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.MapBufferRange if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapBufferRange if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapNamedBufferRange if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="length"/> is negative, if $offset + 
		/// length$ is greater than the value of Gl.BUFFER_SIZE for the buffer object, or if <paramref name="access"/> has any bits 
		/// set other than those defined above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated for any of the following conditions: <paramref name="length"/> is zero. The buffer 
		/// object is already in a mapped state. Neither Gl.MAP_READ_BIT nor Gl.MAP_WRITE_BIT is set. Gl.MAP_READ_BIT is set and any 
		/// of Gl.MAP_INVALIDATE_RANGE_BIT, Gl.MAP_INVALIDATE_BUFFER_BIT or Gl.MAP_UNSYNCHRONIZED_BIT is set. 
		/// Gl.MAP_FLUSH_EXPLICIT_BIT is set and Gl.MAP_WRITE_BIT is not set. Any of Gl.MAP_READ_BIT, Gl.MAP_WRITE_BIT, 
		/// Gl.MAP_PERSISTENT_BIT, or Gl.MAP_COHERENT_BIT are set, but the same bit is not included in the buffer's storage flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// No error is generated if memory outside the mapped range is modified or queried, but the result is undefined and system 
		/// errors (possibly including program termination) may occur.
		/// </exception>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferStorage"/>
		[AliasOf("glMapBufferRangeEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		public static IntPtr MapBufferRange(BufferTargetARB target, IntPtr offset, UInt32 length, UInt32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferRange != null, "pglMapBufferRange not implemented");
			retValue = Delegates.pglMapBufferRange((Int32)target, offset, length, access);
			LogFunction("glMapBufferRange({0}, 0x{1}, {2}, {3}) = {4}", target, offset.ToString("X8"), length, access, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// indicate modifications to a range of a mapped buffer
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.FlushMappedBufferRange, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the start of the buffer subrange, in basic machine units.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the buffer subrange, in basic machine units.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.FlushMappedBufferRange if <paramref name="target"/> is not one of the buffer binding 
		/// targets listed above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.FlushMappedBufferRange if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.FlushMappedNamedBufferRange if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="length"/> is negative, or if <paramref 
		/// name="offset"/> + <paramref name="length"/> exceeds the size of the mapping.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is not mapped, or is mapped without the Gl.MAP_FLUSH_EXPLICIT_BIT 
		/// flag.
		/// </exception>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glFlushMappedBufferRangeAPPLE")]
		[AliasOf("glFlushMappedBufferRangeEXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedBufferRange != null, "pglFlushMappedBufferRange not implemented");
			Delegates.pglFlushMappedBufferRange((Int32)target, offset, length);
			LogFunction("glFlushMappedBufferRange({0}, 0x{1}, {2})", target, offset.ToString("X8"), length);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies the name of the vertex array to bind.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="array"/> is not zero or the name of a vertex array object 
		/// previously returned from a call to glGenVertexArrays.
		/// </exception>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glBindVertexArrayOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public static void BindVertexArray(UInt32 array)
		{
			Debug.Assert(Delegates.pglBindVertexArray != null, "pglBindVertexArray not implemented");
			Delegates.pglBindVertexArray(array);
			LogFunction("glBindVertexArray({0})", array);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete vertex array objects
		/// </summary>
		/// <param name="arrays">
		/// Specifies the address of an array containing the <paramref name="n"/> names of the objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.BindVertexArray"/>
		[AliasOf("glDeleteVertexArraysAPPLE")]
		[AliasOf("glDeleteVertexArraysOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public static void DeleteVertexArrays(params UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglDeleteVertexArrays != null, "pglDeleteVertexArrays not implemented");
					Delegates.pglDeleteVertexArrays((Int32)arrays.Length, p_arrays);
					LogFunction("glDeleteVertexArrays({0}, {1})", arrays.Length, LogValue(arrays));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate vertex array object names
		/// </summary>
		/// <param name="arrays">
		/// Specifies an array in which the generated vertex array object names are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		[AliasOf("glGenVertexArraysAPPLE")]
		[AliasOf("glGenVertexArraysOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public static void GenVertexArrays(UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglGenVertexArrays != null, "pglGenVertexArrays not implemented");
					Delegates.pglGenVertexArrays((Int32)arrays.Length, p_arrays);
					LogFunction("glGenVertexArrays({0}, {1})", arrays.Length, LogValue(arrays));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate vertex array object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		[AliasOf("glGenVertexArraysAPPLE")]
		[AliasOf("glGenVertexArraysOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public static UInt32 GenVertexArray()
		{
			UInt32[] retValue = new UInt32[1];
			GenVertexArrays(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies a value that may be the name of a vertex array object.
		/// </param>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		[AliasOf("glIsVertexArrayAPPLE")]
		[AliasOf("glIsVertexArrayOES")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		[RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
		public static bool IsVertexArray(UInt32 array)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVertexArray != null, "pglIsVertexArray not implemented");
			retValue = Delegates.pglIsVertexArray(array);
			LogFunction("glIsVertexArray({0}) = {1}", array, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
