
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
		/// Value of GL_NUM_SHADING_LANGUAGE_VERSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		public const int NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_LONG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		public const int VERTEX_ATTRIB_ARRAY_LONG = 0x874E;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_RGB8_ETC2 = 0x9274;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_SRGB8_ETC2 = 0x9275;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_RGBA8_ETC2_EAC = 0x9278;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;

		/// <summary>
		/// Value of GL_COMPRESSED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_R11_EAC = 0x9270;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_SIGNED_R11_EAC = 0x9271;

		/// <summary>
		/// Value of GL_COMPRESSED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_RG11_EAC = 0x9272;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int COMPRESSED_SIGNED_RG11_EAC = 0x9273;

		/// <summary>
		/// Gl.Enable: enables primitive restarting with a fixed index. If enabled, any one of the draw commands which transfers a 
		/// set of generic attribute array elements to the GL will restart the primitive when the index of the vertex is equal to 
		/// the fixed primitive index for the specified index type. The fixed index is equal to 2n−1 where n is equal to 8 for 
		/// Gl.UNSIGNED_BYTE, 16 for Gl.UNSIGNED_SHORT and 32 for Gl.UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED_CONSERVATIVE symbol.
		/// </summary>
		[AliasOf("GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum index that may be specified during the transfer of generic vertex 
		/// attributes to the GL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		public const int MAX_ELEMENT_INDEX = 0x8D6B;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int COMPUTE_SHADER = 0x91B9;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform blocks per compute shader. The value must be at least 14. 
		/// See Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps from 
		/// the compute shader. The value may be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_SHARED_MEMORY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that can be 
		/// held in uniform variable storage for a compute shader. The value must be at least 1024. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a compute 
		/// shader.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to compute shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;

		/// <summary>
		/// Gl.Get: data returns one value, the number of words for compute shader uniform variables in all uniform blocks 
		/// (including default). The value must be at least 1. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;

		/// <summary>
		/// Gl.Get: data returns one value, the number of invocations in a single local work group (i.e., the product of the three 
		/// dimensions) that may be dispatched to a compute shader.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

		/// <summary>
		/// Gl.Get: accepted by the indexed versions of glGet. data the maximum number of work groups that may be dispatched to a 
		/// compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;

		/// <summary>
		/// Gl.Get: accepted by the indexed versions of glGet. data the maximum size of a work groups that may be used during 
		/// compilation of a compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

		/// <summary>
		/// Gl.GetProgram: params returns an array of three integers containing the local work group size of the compute program as 
		/// specified by its input layout qualifier(s). program must be the name of a program object that has been previously linked 
		/// successfully and contains a binary for the compute shader stage.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int COMPUTE_WORK_GROUP_SIZE = 0x8267;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;

		/// <summary>
		/// Value of GL_DISPATCH_INDIRECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target 
		/// Gl.DISPATCH_INDIRECT_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See 
		/// Gl.BindBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		[Log(BitmaskName = "GL")]
		public const uint COMPUTE_SHADER_BIT = 0x00000020;

		/// <summary>
		/// Gl.Enable: if enabled, debug messages are produced synchronously by a debug context. If disabled, debug messages may be 
		/// produced asynchronously. In particular, they may be delayed relative to the execution of GL commands, and the debug 
		/// callback function may be called from a thread other than that in which the commands are executed. See 
		/// Gl.DebugMessageCallback.
		/// </summary>
		[AliasOf("GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB")]
		[AliasOf("GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;

		/// <summary>
		/// Value of GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB")]
		[AliasOf("GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;

		/// <summary>
		/// Gl.GetPointer: returns the current callback function set with the callback argument of Gl.DebugMessageCallback.
		/// </summary>
		[AliasOf("GL_DEBUG_CALLBACK_FUNCTION_ARB")]
		[AliasOf("GL_DEBUG_CALLBACK_FUNCTION_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_CALLBACK_FUNCTION = 0x8244;

		/// <summary>
		/// Gl.GetPointer: returns the user parameter to the current callback function set with the userParam argument of 
		/// Gl.DebugMessageCallback.
		/// </summary>
		[AliasOf("GL_DEBUG_CALLBACK_USER_PARAM_ARB")]
		[AliasOf("GL_DEBUG_CALLBACK_USER_PARAM_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_CALLBACK_USER_PARAM = 0x8245;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_API symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_API_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_API_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_API = 0x8246;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_WINDOW_SYSTEM symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_SHADER_COMPILER symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_SHADER_COMPILER_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_SHADER_COMPILER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_SHADER_COMPILER = 0x8248;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_THIRD_PARTY symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_THIRD_PARTY_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_THIRD_PARTY_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_THIRD_PARTY = 0x8249;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_APPLICATION symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_APPLICATION_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_APPLICATION_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_APPLICATION = 0x824A;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_OTHER symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SOURCE_OTHER_ARB")]
		[AliasOf("GL_DEBUG_SOURCE_OTHER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SOURCE_OTHER = 0x824B;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_ERROR symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_ERROR_ARB")]
		[AliasOf("GL_DEBUG_TYPE_ERROR_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_ERROR = 0x824C;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB")]
		[AliasOf("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB")]
		[AliasOf("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PORTABILITY symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_PORTABILITY_ARB")]
		[AliasOf("GL_DEBUG_TYPE_PORTABILITY_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_PORTABILITY = 0x824F;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PERFORMANCE symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_PERFORMANCE_ARB")]
		[AliasOf("GL_DEBUG_TYPE_PERFORMANCE_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_PERFORMANCE = 0x8250;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_OTHER symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_OTHER_ARB")]
		[AliasOf("GL_DEBUG_TYPE_OTHER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_OTHER = 0x8251;

		/// <summary>
		/// Value of GL_MAX_DEBUG_MESSAGE_LENGTH symbol.
		/// </summary>
		[AliasOf("GL_MAX_DEBUG_MESSAGE_LENGTH_AMD")]
		[AliasOf("GL_MAX_DEBUG_MESSAGE_LENGTH_ARB")]
		[AliasOf("GL_MAX_DEBUG_MESSAGE_LENGTH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int MAX_DEBUG_MESSAGE_LENGTH = 0x9143;

		/// <summary>
		/// Value of GL_MAX_DEBUG_LOGGED_MESSAGES symbol.
		/// </summary>
		[AliasOf("GL_MAX_DEBUG_LOGGED_MESSAGES_AMD")]
		[AliasOf("GL_MAX_DEBUG_LOGGED_MESSAGES_ARB")]
		[AliasOf("GL_MAX_DEBUG_LOGGED_MESSAGES_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int MAX_DEBUG_LOGGED_MESSAGES = 0x9144;

		/// <summary>
		/// Value of GL_DEBUG_LOGGED_MESSAGES symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_LOGGED_MESSAGES_AMD")]
		[AliasOf("GL_DEBUG_LOGGED_MESSAGES_ARB")]
		[AliasOf("GL_DEBUG_LOGGED_MESSAGES_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_LOGGED_MESSAGES = 0x9145;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_HIGH symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SEVERITY_HIGH_AMD")]
		[AliasOf("GL_DEBUG_SEVERITY_HIGH_ARB")]
		[AliasOf("GL_DEBUG_SEVERITY_HIGH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SEVERITY_HIGH = 0x9146;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_MEDIUM symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SEVERITY_MEDIUM_AMD")]
		[AliasOf("GL_DEBUG_SEVERITY_MEDIUM_ARB")]
		[AliasOf("GL_DEBUG_SEVERITY_MEDIUM_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SEVERITY_MEDIUM = 0x9147;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_LOW symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SEVERITY_LOW_AMD")]
		[AliasOf("GL_DEBUG_SEVERITY_LOW_ARB")]
		[AliasOf("GL_DEBUG_SEVERITY_LOW_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SEVERITY_LOW = 0x9148;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_MARKER symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_MARKER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_MARKER = 0x8268;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PUSH_GROUP symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_PUSH_GROUP_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_PUSH_GROUP = 0x8269;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_POP_GROUP symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_TYPE_POP_GROUP_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_TYPE_POP_GROUP = 0x826A;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_NOTIFICATION symbol.
		/// </summary>
		[AliasOf("GL_DEBUG_SEVERITY_NOTIFICATION_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_SEVERITY_NOTIFICATION = 0x826B;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum depth of the debug message group stack.
		/// </summary>
		[AliasOf("GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;

		/// <summary>
		/// Gl.Get: data returns a single value, the current depth of the debug message group stack.
		/// </summary>
		[AliasOf("GL_DEBUG_GROUP_STACK_DEPTH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_GROUP_STACK_DEPTH = 0x826D;

		/// <summary>
		/// Value of GL_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_BUFFER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int BUFFER = 0x82E0;

		/// <summary>
		/// Value of GL_SHADER symbol.
		/// </summary>
		[AliasOf("GL_SHADER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int SHADER = 0x82E1;

		/// <summary>
		/// Value of GL_PROGRAM symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int PROGRAM = 0x82E2;

		/// <summary>
		/// Value of GL_QUERY symbol.
		/// </summary>
		[AliasOf("GL_QUERY_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int QUERY = 0x82E3;

		/// <summary>
		/// Value of GL_PROGRAM_PIPELINE symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_PIPELINE_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int PROGRAM_PIPELINE = 0x82E4;

		/// <summary>
		/// Value of GL_SAMPLER symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int SAMPLER = 0x82E6;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum length of a label that may be assigned to an object. See Gl.ObjectLabel and 
		/// Gl.ObjectPtrLabel.
		/// </summary>
		[AliasOf("GL_MAX_LABEL_LENGTH_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int MAX_LABEL_LENGTH = 0x82E8;

		/// <summary>
		/// Gl.Enable: if enabled, debug messages are produced by a debug context. When disabled, the debug message log is silenced. 
		/// Note that in a non-debug context, very few, if any messages might be produced, even when Gl.DEBUG_OUTPUT is enabled.
		/// </summary>
		[AliasOf("GL_DEBUG_OUTPUT_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DEBUG_OUTPUT = 0x92E0;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_DEBUG_BIT symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of explicitly assignable uniform locations, which must be at least 
		/// 1024.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_explicit_uniform_location", Api = "gl|glcore")]
		public const int MAX_UNIFORM_LOCATIONS = 0x826E;

		/// <summary>
		/// <para>
		/// Gl.FramebufferParameter: param specifies the assumed with for a framebuffer object with no attachments. If a framebuffer 
		/// has attachments then the width of those attachments is used, otherwise the value of Gl.FRAMEBUFFER_DEFAULT_WIDTH is used 
		/// for the framebuffer. param must be greater than or equal to zero and less than or equal to the value of 
		/// Gl.MAX_FRAMEBUFFER_WIDTH.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_WIDTH for the framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;

		/// <summary>
		/// <para>
		/// Gl.FramebufferParameter: param specifies the assumed height for a framebuffer object with no attachments. If a 
		/// framebuffer has attachments then the height of those attachments is used, otherwise the value of 
		/// Gl.FRAMEBUFFER_DEFAULT_HEIGHT is used for the framebuffer. param must be greater than or equal to zero and less than or 
		/// equal to the value of Gl.MAX_FRAMEBUFFER_HEIGHT.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_HEIGHT for the framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;

		/// <summary>
		/// <para>
		/// Gl.FramebufferParameter: param specifies the assumed number of layers for a framebuffer object with no attachments. If a 
		/// framebuffer has attachments then the layer count of those attachments is used, otherwise the value of 
		/// Gl.FRAMEBUFFER_DEFAULT_LAYERS is used for the framebuffer. param must be greater than or equal to zero and less than or 
		/// equal to the value of Gl.MAX_FRAMEBUFFER_LAYERS.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_LAYERS for the framebuffer object.
		/// </para>
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT")]
		[AliasOf("GL_FRAMEBUFFER_DEFAULT_LAYERS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;

		/// <summary>
		/// <para>
		/// Gl.FramebufferParameter: param specifies the assumed number of samples in a framebuffer object with no attachments. If a 
		/// framebuffer has attachments then the sample count of those attachments is used, otherwise the value of 
		/// Gl.FRAMEBUFFER_DEFAULT_SAMPLES is used for the framebuffer. param must be greater than or equal to zero and less than or 
		/// equal to the value of Gl.MAX_FRAMEBUFFER_SAMPLE.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_SAMPLES for the framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;

		/// <summary>
		/// <para>
		/// Gl.FramebufferParameter: param specifies whether the framebuffer should assume identical sample locations and the same 
		/// number of samples for all texels in the virtual image. If param is zero, then the implementation may vary the position 
		/// or the count of samples within the virtual image from pixel to pixel, otherwise it will use the same sample position and 
		/// count for all pixels in the virtual image.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: params returns the boolean value of Gl.FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum width for a framebuffer that has no attachments, which must be at least 
		/// 16384. See Gl.FramebufferParameter.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int MAX_FRAMEBUFFER_WIDTH = 0x9315;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum height for a framebuffer that has no attachments, which must be at least 
		/// 16384. See Gl.FramebufferParameter.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int MAX_FRAMEBUFFER_HEIGHT = 0x9316;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of layers for a framebuffer that has no attachments, which must be at 
		/// least 2048. See Gl.FramebufferParameter.
		/// </summary>
		[AliasOf("GL_MAX_FRAMEBUFFER_LAYERS_EXT")]
		[AliasOf("GL_MAX_FRAMEBUFFER_LAYERS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_FRAMEBUFFER_LAYERS = 0x9317;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum samples in a framebuffer that has no attachments, which must be at least 4. 
		/// See Gl.FramebufferParameter.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public const int MAX_FRAMEBUFFER_SAMPLES = 0x9318;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_SUPPORTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_SUPPORTED = 0x826F;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_PREFERRED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_PREFERRED = 0x8270;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_RED_SIZE = 0x8271;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_GREEN_SIZE = 0x8272;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_BLUE_SIZE = 0x8273;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_ALPHA_SIZE = 0x8274;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_DEPTH_SIZE = 0x8275;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_STENCIL_SIZE = 0x8276;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_SHARED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_SHARED_SIZE = 0x8277;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_RED_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_RED_TYPE = 0x8278;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_GREEN_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_GREEN_TYPE = 0x8279;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_BLUE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_BLUE_TYPE = 0x827A;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_ALPHA_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_ALPHA_TYPE = 0x827B;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_DEPTH_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_DEPTH_TYPE = 0x827C;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_STENCIL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int INTERNALFORMAT_STENCIL_TYPE = 0x827D;

		/// <summary>
		/// Value of GL_MAX_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MAX_WIDTH = 0x827E;

		/// <summary>
		/// Value of GL_MAX_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MAX_HEIGHT = 0x827F;

		/// <summary>
		/// Value of GL_MAX_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MAX_DEPTH = 0x8280;

		/// <summary>
		/// Value of GL_MAX_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MAX_LAYERS = 0x8281;

		/// <summary>
		/// Value of GL_MAX_COMBINED_DIMENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MAX_COMBINED_DIMENSIONS = 0x8282;

		/// <summary>
		/// Value of GL_COLOR_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int COLOR_COMPONENTS = 0x8283;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int DEPTH_COMPONENTS = 0x8284;

		/// <summary>
		/// Value of GL_STENCIL_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int STENCIL_COMPONENTS = 0x8285;

		/// <summary>
		/// Value of GL_COLOR_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int COLOR_RENDERABLE = 0x8286;

		/// <summary>
		/// Value of GL_DEPTH_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int DEPTH_RENDERABLE = 0x8287;

		/// <summary>
		/// Value of GL_STENCIL_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int STENCIL_RENDERABLE = 0x8288;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FRAMEBUFFER_RENDERABLE = 0x8289;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_RENDERABLE_LAYERED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BLEND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FRAMEBUFFER_BLEND = 0x828B;

		/// <summary>
		/// Value of GL_READ_PIXELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int READ_PIXELS = 0x828C;

		/// <summary>
		/// Value of GL_READ_PIXELS_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int READ_PIXELS_FORMAT = 0x828D;

		/// <summary>
		/// Value of GL_READ_PIXELS_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int READ_PIXELS_TYPE = 0x828E;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_IMAGE_FORMAT = 0x828F;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_IMAGE_TYPE = 0x8290;

		/// <summary>
		/// Value of GL_GET_TEXTURE_IMAGE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int GET_TEXTURE_IMAGE_FORMAT = 0x8291;

		/// <summary>
		/// Value of GL_GET_TEXTURE_IMAGE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int GET_TEXTURE_IMAGE_TYPE = 0x8292;

		/// <summary>
		/// Value of GL_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MIPMAP = 0x8293;

		/// <summary>
		/// Value of GL_MANUAL_GENERATE_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int MANUAL_GENERATE_MIPMAP = 0x8294;

		/// <summary>
		/// Value of GL_AUTO_GENERATE_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int AUTO_GENERATE_MIPMAP = 0x8295;

		/// <summary>
		/// Value of GL_COLOR_ENCODING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int COLOR_ENCODING = 0x8296;

		/// <summary>
		/// Value of GL_SRGB_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SRGB_READ = 0x8297;

		/// <summary>
		/// Value of GL_SRGB_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SRGB_WRITE = 0x8298;

		/// <summary>
		/// Value of GL_FILTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FILTER = 0x829A;

		/// <summary>
		/// Value of GL_VERTEX_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VERTEX_TEXTURE = 0x829B;

		/// <summary>
		/// Value of GL_TESS_CONTROL_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TESS_CONTROL_TEXTURE = 0x829C;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TESS_EVALUATION_TEXTURE = 0x829D;

		/// <summary>
		/// Value of GL_GEOMETRY_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int GEOMETRY_TEXTURE = 0x829E;

		/// <summary>
		/// Value of GL_FRAGMENT_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FRAGMENT_TEXTURE = 0x829F;

		/// <summary>
		/// Value of GL_COMPUTE_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int COMPUTE_TEXTURE = 0x82A0;

		/// <summary>
		/// Value of GL_TEXTURE_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_SHADOW = 0x82A1;

		/// <summary>
		/// Value of GL_TEXTURE_GATHER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_GATHER = 0x82A2;

		/// <summary>
		/// Value of GL_TEXTURE_GATHER_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_GATHER_SHADOW = 0x82A3;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_LOAD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SHADER_IMAGE_LOAD = 0x82A4;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_STORE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SHADER_IMAGE_STORE = 0x82A5;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_ATOMIC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SHADER_IMAGE_ATOMIC = 0x82A6;

		/// <summary>
		/// Value of GL_IMAGE_TEXEL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_TEXEL_SIZE = 0x82A7;

		/// <summary>
		/// Value of GL_IMAGE_COMPATIBILITY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_COMPATIBILITY_CLASS = 0x82A8;

		/// <summary>
		/// Value of GL_IMAGE_PIXEL_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_PIXEL_FORMAT = 0x82A9;

		/// <summary>
		/// Value of GL_IMAGE_PIXEL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_PIXEL_TYPE = 0x82AA;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;

		/// <summary>
		/// Value of GL_CLEAR_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int CLEAR_BUFFER = 0x82B4;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_VIEW = 0x82B5;

		/// <summary>
		/// Value of GL_VIEW_COMPATIBILITY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_COMPATIBILITY_CLASS = 0x82B6;

		/// <summary>
		/// Value of GL_FULL_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int FULL_SUPPORT = 0x82B7;

		/// <summary>
		/// Value of GL_CAVEAT_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int CAVEAT_SUPPORT = 0x82B8;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_4_X_32 = 0x82B9;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_2_X_32 = 0x82BA;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_1_X_32 = 0x82BB;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_4_X_16 = 0x82BC;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_2_X_16 = 0x82BD;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_1_X_16 = 0x82BE;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_4_X_8 = 0x82BF;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_2_X_8 = 0x82C0;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_1_X_8 = 0x82C1;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_11_11_10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_11_11_10 = 0x82C2;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_10_10_10_2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int IMAGE_CLASS_10_10_10_2 = 0x82C3;

		/// <summary>
		/// Value of GL_VIEW_CLASS_128_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_128_BITS = 0x82C4;

		/// <summary>
		/// Value of GL_VIEW_CLASS_96_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_96_BITS = 0x82C5;

		/// <summary>
		/// Value of GL_VIEW_CLASS_64_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_64_BITS = 0x82C6;

		/// <summary>
		/// Value of GL_VIEW_CLASS_48_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_48_BITS = 0x82C7;

		/// <summary>
		/// Value of GL_VIEW_CLASS_32_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_32_BITS = 0x82C8;

		/// <summary>
		/// Value of GL_VIEW_CLASS_24_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_24_BITS = 0x82C9;

		/// <summary>
		/// Value of GL_VIEW_CLASS_16_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_16_BITS = 0x82CA;

		/// <summary>
		/// Value of GL_VIEW_CLASS_8_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_8_BITS = 0x82CB;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT1_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT1_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT3_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT5_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;

		/// <summary>
		/// Value of GL_VIEW_CLASS_RGTC1_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_RGTC1_RED = 0x82D0;

		/// <summary>
		/// Value of GL_VIEW_CLASS_RGTC2_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_RGTC2_RG = 0x82D1;

		/// <summary>
		/// Value of GL_VIEW_CLASS_BPTC_UNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_BPTC_UNORM = 0x82D2;

		/// <summary>
		/// Value of GL_VIEW_CLASS_BPTC_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int VIEW_CLASS_BPTC_FLOAT = 0x82D3;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active uniforms within program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active uniforms within program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active uniforms within program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int UNIFORM = 0x92E1;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active uniform blocks within program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active uniform blocks within program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active uniform blocks within program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int UNIFORM_BLOCK = 0x92E2;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active input variables used by the first shader stage of 
		/// program. If program contains multiple shader stages then input variables from any stage other than the first will not be 
		/// enumerated.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active input variables used by the first shader stage of 
		/// program. If program contains multiple shader stages then input variables from any stage other than the first will not be 
		/// enumerated.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active input variables used by the first shader stage of 
		/// program. If program contains multiple shader stages then input variables from any stage other than the first will not be 
		/// enumerated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int PROGRAM_INPUT = 0x92E3;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active output variables produced by the last shader stage of 
		/// program. If program contains multiple shader stages then output variables from any stage other than the last will not be 
		/// enumerated.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active output variables produced by the last shader 
		/// stage of program. If program contains multiple shader stages then output variables from any stage other than the last 
		/// will not be enumerated.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active output variables produced by the last shader stage 
		/// of program. If program contains multiple shader stages then output variables from any stage other than the last will not 
		/// be enumerated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int PROGRAM_OUTPUT = 0x92E4;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active buffer variables used by program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active buffer variables used by program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active buffer variables used by program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int BUFFER_VARIABLE = 0x92E5;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active shader storage blocks used by program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active shader storage blocks used by program.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active shader storage blocks used by program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BLOCK = 0x92E6;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active subroutines for the vertex, tessellation control, 
		/// tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active subroutines for the vertex, tessellation control, 
		/// tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active subroutines for the vertex, tessellation control, 
		/// tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int VERTEX_SUBROUTINE = 0x92E8;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TESS_CONTROL_SUBROUTINE = 0x92E9;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TESS_EVALUATION_SUBROUTINE = 0x92EA;

		/// <summary>
		/// Value of GL_GEOMETRY_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int GEOMETRY_SUBROUTINE = 0x92EB;

		/// <summary>
		/// Value of GL_FRAGMENT_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int FRAGMENT_SUBROUTINE = 0x92EC;

		/// <summary>
		/// Value of GL_COMPUTE_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int COMPUTE_SUBROUTINE = 0x92ED;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of active subroutine uniform variables used by the vertex, 
		/// tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of active subroutine uniform variables used by the vertex, 
		/// tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of active subroutine uniform variables used by the vertex, 
		/// tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int VERTEX_SUBROUTINE_UNIFORM = 0x92EE;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;

		/// <summary>
		/// Value of GL_GEOMETRY_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;

		/// <summary>
		/// Value of GL_FRAGMENT_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;

		/// <summary>
		/// Value of GL_COMPUTE_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;

		/// <summary>
		/// <para>
		/// Gl.GetProgramInterface: the query is targeted at the set of output variables from the last non-fragment stage of program 
		/// that would be captured if transform feedback were active.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceIndex: the query is targeted at the set of output variables from the last non-fragment stage of 
		/// program that would be captured if transform feedback were active.
		/// </para>
		/// <para>
		/// Gl.GetProgramResourceName: the query is targeted at the set of output variables from the last non-fragment stage of 
		/// program that would be captured if transform feedback were active.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TRANSFORM_FEEDBACK_VARYING = 0x92F4;

		/// <summary>
		/// Value of GL_ACTIVE_RESOURCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int ACTIVE_RESOURCES = 0x92F5;

		/// <summary>
		/// Value of GL_MAX_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int MAX_NAME_LENGTH = 0x92F6;

		/// <summary>
		/// Value of GL_MAX_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int MAX_NUM_ACTIVE_VARIABLES = 0x92F7;

		/// <summary>
		/// Value of GL_MAX_NUM_COMPATIBLE_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;

		/// <summary>
		/// Value of GL_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int NAME_LENGTH = 0x92F9;

		/// <summary>
		/// Value of GL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TYPE = 0x92FA;

		/// <summary>
		/// Value of GL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int ARRAY_SIZE = 0x92FB;

		/// <summary>
		/// Value of GL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int OFFSET = 0x92FC;

		/// <summary>
		/// Value of GL_BLOCK_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int BLOCK_INDEX = 0x92FD;

		/// <summary>
		/// Value of GL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int ARRAY_STRIDE = 0x92FE;

		/// <summary>
		/// Value of GL_MATRIX_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int MATRIX_STRIDE = 0x92FF;

		/// <summary>
		/// Value of GL_IS_ROW_MAJOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int IS_ROW_MAJOR = 0x9300;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;

		/// <summary>
		/// Value of GL_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int BUFFER_BINDING = 0x9302;

		/// <summary>
		/// Value of GL_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int BUFFER_DATA_SIZE = 0x9303;

		/// <summary>
		/// Value of GL_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int NUM_ACTIVE_VARIABLES = 0x9304;

		/// <summary>
		/// Value of GL_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int ACTIVE_VARIABLES = 0x9305;

		/// <summary>
		/// Value of GL_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int REFERENCED_BY_VERTEX_SHADER = 0x9306;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[AliasOf("GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT")]
		[AliasOf("GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[AliasOf("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT")]
		[AliasOf("GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;

		/// <summary>
		/// Value of GL_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[AliasOf("GL_REFERENCED_BY_GEOMETRY_SHADER_EXT")]
		[AliasOf("GL_REFERENCED_BY_GEOMETRY_SHADER_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int REFERENCED_BY_GEOMETRY_SHADER = 0x9309;

		/// <summary>
		/// Value of GL_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int REFERENCED_BY_FRAGMENT_SHADER = 0x930A;

		/// <summary>
		/// Value of GL_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int REFERENCED_BY_COMPUTE_SHADER = 0x930B;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TOP_LEVEL_ARRAY_SIZE = 0x930C;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int TOP_LEVEL_ARRAY_STRIDE = 0x930D;

		/// <summary>
		/// Value of GL_LOCATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public const int LOCATION = 0x930E;

		/// <summary>
		/// Value of GL_LOCATION_INDEX symbol.
		/// </summary>
		[AliasOf("GL_LOCATION_INDEX_EXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int LOCATION_INDEX = 0x930F;

		/// <summary>
		/// Value of GL_IS_PER_PATCH symbol.
		/// </summary>
		[AliasOf("GL_IS_PER_PATCH_EXT")]
		[AliasOf("GL_IS_PER_PATCH_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int IS_PER_PATCH = 0x92E7;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BUFFER = 0x90D2;

		/// <summary>
		/// Gl.Get: when used with non-indexed variants of glGet (such as glGetIntegerv), data returns a single value, the name of 
		/// the buffer object currently bound to the target Gl.SHADER_STORAGE_BUFFER. If no buffer object is bound to this target, 0 
		/// is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns a single value, the name 
		/// of the buffer object bound to the indexed shader storage buffer binding points. The initial value is 0 for all targets. 
		/// See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the start 
		/// offset of the binding range for each indexed shader storage buffer binding. The initial value is 0 for all bindings. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BUFFER_START = 0x90D4;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the size of 
		/// the binding range for each indexed shader storage buffer binding. The initial value is 0 for all bindings. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a vertex 
		/// shader.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a geometry 
		/// shader.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a 
		/// tessellation control shader.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a 
		/// tessellation evaluation shader.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a fragment 
		/// shader.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a compute 
		/// shader.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum total number of active shader storage blocks that may be accessed by all 
		/// active shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of shader storage buffer binding points on the context, which must be 
		/// at least 8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;

		/// <summary>
		/// Value of GL_MAX_SHADER_STORAGE_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;

		/// <summary>
		/// Gl.Get: data returns a single value, the minimum required alignment for shader storage buffer sizes and offset. The 
		/// initial value is 1. See Gl.ShaderStorateBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public const int SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[Log(BitmaskName = "GL")]
		public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns the single-value depth stencil texture mode, a symbolic constant. The initial value is 
		/// Gl.DEPTH_COMPONENT.
		/// </para>
		/// <para>
		/// Gl.TexParameter: specifies the mode used to read from depth-stencil format textures. params must be one of 
		/// Gl.DEPTH_COMPONENT or Gl.STENCIL_COMPONENT. If the depth stencil mode is Gl.DEPTH_COMPONENT, then reads from 
		/// depth-stencil format textures will return the depth component of the texel in Rt and the stencil component will be 
		/// discarded. If the depth stencil mode is Gl.STENCIL_COMPONENT then the stencil component is returned in Rt and the depth 
		/// component is discarded. The initial value is Gl.DEPTH_COMPONENT.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_stencil_texturing", Api = "gl|glcore")]
		public const int DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single integer value, the offset into the data store of the buffer bound to a 
		/// buffer texture. Gl.TexBufferRange.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_OFFSET_EXT")]
		[AliasOf("GL_TEXTURE_BUFFER_OFFSET_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int TEXTURE_BUFFER_OFFSET = 0x919D;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single integer value, the size of the range of a data store of the buffer 
		/// bound to a buffer texture. Gl.TexBufferRange.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_SIZE_EXT")]
		[AliasOf("GL_TEXTURE_BUFFER_SIZE_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int TEXTURE_BUFFER_SIZE = 0x919E;

		/// <summary>
		/// Gl.Get: data returns a single value, the minimum required alignment for texture buffer sizes and offset. The initial 
		/// value is 1. See Gl.UniformBlockBinding.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT")]
		[AliasOf("GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

		/// <summary>
		/// Gl.GetTexParameter: returns a single-valued base level of a texture view relative to its parent. The initial value is 0. 
		/// See Gl.TextureView.
		/// </summary>
		[AliasOf("GL_TEXTURE_VIEW_MIN_LEVEL_EXT")]
		[AliasOf("GL_TEXTURE_VIEW_MIN_LEVEL_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public const int TEXTURE_VIEW_MIN_LEVEL = 0x82DB;

		/// <summary>
		/// Gl.GetTexParameter: returns a single-valued number of levels of detail of a texture view. See Gl.TextureView.
		/// </summary>
		[AliasOf("GL_TEXTURE_VIEW_NUM_LEVELS_EXT")]
		[AliasOf("GL_TEXTURE_VIEW_NUM_LEVELS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public const int TEXTURE_VIEW_NUM_LEVELS = 0x82DC;

		/// <summary>
		/// Gl.GetTexParameter: returns a single-valued first level of a texture array view relative to its parent. See 
		/// Gl.TextureView.
		/// </summary>
		[AliasOf("GL_TEXTURE_VIEW_MIN_LAYER_EXT")]
		[AliasOf("GL_TEXTURE_VIEW_MIN_LAYER_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public const int TEXTURE_VIEW_MIN_LAYER = 0x82DD;

		/// <summary>
		/// Gl.GetTexParameter: returns a single-valued number of layers in a texture array view. See Gl.TextureView.
		/// </summary>
		[AliasOf("GL_TEXTURE_VIEW_NUM_LAYERS_EXT")]
		[AliasOf("GL_TEXTURE_VIEW_NUM_LAYERS_OES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public const int TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

		/// <summary>
		/// Gl.GetTexParameter: returns a single-valued number of immutable texture levels in a texture view. See Gl.TextureView.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int VERTEX_ATTRIB_BINDING = 0x82D4;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

		/// <summary>
		/// Gl.Get: accepted by the indexed forms. data returns a single integer value representing the instance step divisor of the 
		/// first element in the bound buffer's data store for vertex attribute bound to index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int VERTEX_BINDING_DIVISOR = 0x82D6;

		/// <summary>
		/// Gl.Get: accepted by the indexed forms. data returns a single integer value representing the byte offset of the first 
		/// element in the bound buffer's data store for vertex attribute bound to index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int VERTEX_BINDING_OFFSET = 0x82D7;

		/// <summary>
		/// Gl.Get: accepted by the indexed forms. data returns a single integer value representing the byte offset between the 
		/// start of each element in the bound buffer's data store for vertex attribute bound to index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int VERTEX_BINDING_STRIDE = 0x82D8;

		/// <summary>
		/// Gl.Get: data returns a single integer value containing the maximum offset that may be added to a vertex binding offset.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;

		/// <summary>
		/// Gl.Get: data returns a single integer value containing the maximum number of vertex buffers that may be bound.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public const int VERTEX_BINDING_BUFFER = 0x8F4F;

		/// <summary>
		/// Value of GL_DISPLAY_LIST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public const int DISPLAY_LIST = 0x82E7;

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.ClearBufferData, which must must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferData if <paramref name="target"/> is not one of the generic buffer binding 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferData if no buffer is bound <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
		public static void ClearBufferData(Int32 target, Int32 internalformat, Int32 format, Int32 type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearBufferData != null, "pglClearBufferData not implemented");
			Delegates.pglClearBufferData(target, internalformat, format, type, data);
			LogFunction("glClearBufferData({0}, {1}, {2}, {3}, 0x{4})", LogEnumName(target), LogEnumName(internalformat), LogEnumName(format), LogEnumName(type), data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.ClearBufferData, which must must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferData if <paramref name="target"/> is not one of the generic buffer binding 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferData if no buffer is bound <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
		public static void ClearBufferData(Int32 target, Int32 internalformat, Int32 format, Int32 type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearBufferData(target, internalformat, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.ClearBufferSubData, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="offset">
		/// The offset in basic machine units into the buffer object's data store at which to start filling.
		/// </param>
		/// <param name="size">
		/// The size in basic machine units of the range of the data store to fill.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferSubData if no buffer is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="range"/> are not multiples of the number 
		/// of basic machine units per-element for the internal format specified by <paramref name="internalformat"/>. This value 
		/// may be computed by multiplying the number of components for <paramref name="internalformat"/> from the table by the size 
		/// of the base type from the table.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferData"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
		public static void ClearBufferSubData(Int32 target, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearBufferSubData != null, "pglClearBufferSubData not implemented");
			Delegates.pglClearBufferSubData(target, internalformat, offset, size, format, type, data);
			LogFunction("glClearBufferSubData({0}, {1}, 0x{2}, {3}, {4}, {5}, 0x{6})", LogEnumName(target), LogEnumName(internalformat), offset.ToString("X8"), size, LogEnumName(format), LogEnumName(type), data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.ClearBufferSubData, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="offset">
		/// The offset in basic machine units into the buffer object's data store at which to start filling.
		/// </param>
		/// <param name="size">
		/// The size in basic machine units of the range of the data store to fill.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferSubData if no buffer is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="range"/> are not multiples of the number 
		/// of basic machine units per-element for the internal format specified by <paramref name="internalformat"/>. This value 
		/// may be computed by multiplying the number of components for <paramref name="internalformat"/> from the table by the size 
		/// of the base type from the table.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferData"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
		public static void ClearBufferSubData(Int32 target, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearBufferSubData(target, internalformat, offset, size, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// launch one or more compute work groups
		/// </summary>
		/// <param name="num_groups_x">
		/// The number of work groups to be launched in the X dimension.
		/// </param>
		/// <param name="num_groups_y">
		/// The number of work groups to be launched in the Y dimension.
		/// </param>
		/// <param name="num_groups_z">
		/// The number of work groups to be launched in the Z dimension.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no active program for the compute shader stage.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any of <paramref name="num_groups_x"/>, <paramref name="num_groups_y"/>, or <paramref 
		/// name="num_groups_z"/> is greater than or equal to the maximum work-group count for the corresponding dimension.
		/// </exception>
		/// <seealso cref="Gl.DispatchComputeIndirect"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public static void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
		{
			Debug.Assert(Delegates.pglDispatchCompute != null, "pglDispatchCompute not implemented");
			Delegates.pglDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
			LogFunction("glDispatchCompute({0}, {1}, {2})", num_groups_x, num_groups_y, num_groups_z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// launch one or more compute work groups using parameters stored in a buffer
		/// </summary>
		/// <param name="indirect">
		/// The offset into the buffer object currently bound to the Gl.DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch 
		/// parameters are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no active program for the compute shader stage.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="indirect"/> is less than zero or not a multiple of four.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no buffer is bound to the Gl.DISPATCH_INDIRECT_BUFFER target or if the command 
		/// would source data beyond the end of the buffer object's data store.
		/// </exception>
		/// <seealso cref="Gl.DispatchCompute"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		public static void DispatchComputeIndirect(IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDispatchComputeIndirect != null, "pglDispatchComputeIndirect not implemented");
			Delegates.pglDispatchComputeIndirect(indirect);
			LogFunction("glDispatchComputeIndirect(0x{0})", indirect.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// perform a raw data copy between two images
		/// </summary>
		/// <param name="srcName">
		/// The name of a texture or renderbuffer object from which to copy.
		/// </param>
		/// <param name="srcTarget">
		/// The target representing the namespace of the source name <paramref name="srcName"/>.
		/// </param>
		/// <param name="srcLevel">
		/// The mipmap level to read from the source.
		/// </param>
		/// <param name="srcX">
		/// The X coordinate of the left edge of the souce region to copy.
		/// </param>
		/// <param name="srcY">
		/// The Y coordinate of the top edge of the souce region to copy.
		/// </param>
		/// <param name="srcZ">
		/// The Z coordinate of the near edge of the souce region to copy.
		/// </param>
		/// <param name="dstName">
		/// The name of a texture or renderbuffer object to which to copy.
		/// </param>
		/// <param name="dstTarget">
		/// The target representing the namespace of the destination name <paramref name="dstName"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// The X coordinate of the left edge of the destination region.
		/// </param>
		/// <param name="dstY">
		/// The Y coordinate of the top edge of the destination region.
		/// </param>
		/// <param name="dstZ">
		/// The Z coordinate of the near edge of the destination region.
		/// </param>
		/// <param name="srcWidth">
		/// The width of the region to be copied.
		/// </param>
		/// <param name="srcHeight">
		/// The height of the region to be copied.
		/// </param>
		/// <param name="srcDepth">
		/// The depth of the region to be copied.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texel size of the uncompressed image is not equal to the block size of the 
		/// compressed image.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either target parameter is not Gl.RENDERBUFFER, a valid non-proxy texture target other 
		/// than Gl.TEXTURE_BUFFER, or is one of the cubemap face selectors.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> does not match the type of the object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if either object is a texture and the texture is not complete.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the source and destination internal formats are not compatible, or if the number of 
		/// samples do not match.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either name does not correspond to a valid renderbuffer or texture object according to 
		/// the corresponding target parameter.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the specified level of either the source or destination is not a valid level for the 
		/// corresponding image.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the dimensions of the either subregion exceeds the boundaries of the corresponding 
		/// image object, or if the image format is compressed and the dimensions of the subregion fail to meet the alignment 
		/// constraints of the format.
		/// </exception>
		/// <seealso cref="Gl.DispatchComputeIndirect"/>
		[AliasOf("glCopyImageSubDataEXT")]
		[AliasOf("glCopyImageSubDataOES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_copy_image", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_copy_image", Api = "gles2")]
		[RequiredByFeature("GL_OES_copy_image", Api = "gles2")]
		public static void CopyImageSubData(UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			Debug.Assert(Delegates.pglCopyImageSubData != null, "pglCopyImageSubData not implemented");
			Delegates.pglCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			LogFunction("glCopyImageSubData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, LogEnumName(srcTarget), srcLevel, srcX, srcY, srcZ, dstName, LogEnumName(dstTarget), dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set a named parameter of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for Gl.FramebufferParameteri.
		/// </param>
		/// <param name="pname">
		/// Specifies the framebuffer parameter to be modified.
		/// </param>
		/// <param name="param">
		/// The new value for the parameter named <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferParameteri if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferParameteri if the default framebuffer is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferParameteri if <paramref name="framebuffer"/> is not the name of 
		/// an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_WIDTH and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_WIDTH.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_HEIGHT and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_HEIGHT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_LAYERS and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_LAYERS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_SAMPLES and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CreateFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public static void FramebufferParameter(Int32 target, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFramebufferParameteri != null, "pglFramebufferParameteri not implemented");
			Delegates.pglFramebufferParameteri(target, pname, param);
			LogFunction("glFramebufferParameteri({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query a named parameter of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferParameteriv.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the framebuffer object to query.
		/// </param>
		/// <param name="params">
		/// Returns the value of parameter <paramref name="pname"/> for the framebuffer object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetFramebufferParameteriv if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedFramebufferAttachmentParameteriv if <paramref name="framebuffer"/> is 
		/// not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted parameter names.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a default framebuffer is queried, and <paramref name="pname"/> is not one of 
		/// Gl.DOUBLEBUFFER, Gl.IMPLEMENTATION_COLOR_READ_FORMAT, Gl.IMPLEMENTATION_COLOR_READ_TYPE, Gl.SAMPLES, Gl.SAMPLE_BUFFERS 
		/// or Gl.STEREO.
		/// </exception>
		/// <seealso cref="Gl.FramebufferParameteri"/>
		/// <seealso cref="Gl.GetFramebufferAttachmentParameter"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		public static void GetFramebufferParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
					Delegates.pglGetFramebufferParameteriv(target, pname, p_params);
					LogFunction("glGetFramebufferParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about implementation-dependent support for internal formats
		/// </summary>
		/// <param name="target">
		/// Indicates the usage of the internal format. <paramref name="target"/> must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, Gl.TEXTURE_RECTANGLE, 
		/// Gl.TEXTURE_BUFFER, Gl.RENDERBUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format about which to retrieve information.
		/// </param>
		/// <param name="pname">
		/// Specifies the type of information to query.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable into which to write the retrieved information.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not Gl.SAMPLES or Gl.NUM_SAMPLE_COUNTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not color-, depth-, or stencil-renderable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of Gl.TEXTURE_2D_MULTISAMPLE, 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or Gl.RENDERBUFFER.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public static void GetInternalformat(Int32 target, Int32 internalformat, Int32 pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformati64v != null, "pglGetInternalformati64v not implemented");
					Delegates.pglGetInternalformati64v(target, internalformat, pname, (Int32)@params.Length, p_params);
					LogFunction("glGetInternalformati64v({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(internalformat), LogEnumName(pname), @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate a region of a texture image
		/// </summary>
		/// <param name="texture">
		/// The name of a texture object a subregion of which to invalidate.
		/// </param>
		/// <param name="level">
		/// The level of detail of the texture object within which the region resides.
		/// </param>
		/// <param name="xoffset">
		/// The X offset of the region to be invalidated.
		/// </param>
		/// <param name="yoffset">
		/// The Y offset of the region to be invalidated.
		/// </param>
		/// <param name="zoffset">
		/// The Z offset of the region to be invalidated.
		/// </param>
		/// <param name="width">
		/// The width of the region to be invalidated.
		/// </param>
		/// <param name="height">
		/// The height of the region to be invalidated.
		/// </param>
		/// <param name="depth">
		/// The depth of the region to be invalidated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref name="zoffset"/> is 
		/// less than zero, or if any of them is greater than the size of the image in the corresponding dimension.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or if it is greater or equal to the base 2 
		/// logarithm of the maximum texture width, height, or depth.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the target of <paramref name="texture"/> is any of Gl.TEXTURE_RECTANGLE, 
		/// Gl.TEXTURE_BUFFER, Gl.TEXTURE_2D_MULTISAMPLE, or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglInvalidateTexSubImage != null, "pglInvalidateTexSubImage not implemented");
			Delegates.pglInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
			LogFunction("glInvalidateTexSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, level, xoffset, yoffset, zoffset, width, height, depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the entirety a texture image
		/// </summary>
		/// <param name="texture">
		/// The name of a texture object to invalidate.
		/// </param>
		/// <param name="level">
		/// The level of detail of the texture object to invalidate.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or if it is greater or equal to the base 2 
		/// logarithm of the maximum texture width, height, or depth.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the target of <paramref name="texture"/> is any of Gl.TEXTURE_RECTANGLE, 
		/// Gl.TEXTURE_BUFFER, Gl.TEXTURE_2D_MULTISAMPLE, or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateTexImage(UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglInvalidateTexImage != null, "pglInvalidateTexImage not implemented");
			Delegates.pglInvalidateTexImage(texture, level);
			LogFunction("glInvalidateTexImage({0}, {1})", texture, level);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate a region of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// The name of a buffer object, a subrange of whose data store to invalidate.
		/// </param>
		/// <param name="offset">
		/// The offset within the buffer's data store of the start of the range to be invalidated.
		/// </param>
		/// <param name="length">
		/// The length of the range within the buffer's data store to be invalidated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="length"/> is negative, or if <paramref 
		/// name="offset"/> + <paramref name="length"/> is greater than the value of Gl.BUFFER_SIZE for <paramref name="buffer"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of <paramref name="buffer"/> is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglInvalidateBufferSubData != null, "pglInvalidateBufferSubData not implemented");
			Delegates.pglInvalidateBufferSubData(buffer, offset, length);
			LogFunction("glInvalidateBufferSubData({0}, 0x{1}, {2})", buffer, offset.ToString("X8"), length);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the content of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// The name of a buffer object whose data store to invalidate.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of <paramref name="buffer"/> is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateBufferData(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglInvalidateBufferData != null, "pglInvalidateBufferData not implemented");
			Delegates.pglInvalidateBufferData(buffer);
			LogFunction("glInvalidateBufferData({0})", buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the content of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is attached for Gl.InvalidateFramebuffer.
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.InvalidateFramebuffer if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.InvalidateNamedFramebufferData if <paramref name="framebuffer"/> is not zero or 
		/// the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="numAttachments"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if any element of <paramref name="attachments"/> is not one of the accepted framebuffer 
		/// attachment points, as described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if element of <paramref name="attachments"/> is Gl.COLOR_ATTACHMENTm where m is 
		/// greater than or equal to the value of Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateFramebuffer(Int32 target, params Int32[] attachments)
		{
			unsafe {
				fixed (Int32* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateFramebuffer != null, "pglInvalidateFramebuffer not implemented");
					Delegates.pglInvalidateFramebuffer(target, (Int32)attachments.Length, p_attachments);
					LogFunction("glInvalidateFramebuffer({0}, {1}, {2})", LogEnumName(target), attachments.Length, LogEnumName(attachments));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the content of a region of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is attached for Gl.InvalidateSubFramebuffer.
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated.
		/// </param>
		/// <param name="x">
		/// Specifies the X offset of the region to be invalidated.
		/// </param>
		/// <param name="y">
		/// Specifies the Y offset of the region to be invalidated.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the region to be invalidated.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the region to be invalidated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM by Gl.InvalidateSubFramebuffer if <paramref name="target"/> is not one of the accepted framebuffer 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION by Gl.InvalidateNamedFramebufferSubData if <paramref name="framebuffer"/> is not zero of the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="numAttachments"/>, <paramref name="width"/> or <paramref 
		/// name="height"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if any element of <paramref name="attachments"/> is not one of the accepted framebuffer 
		/// attachment points, as described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if element of <paramref name="attachments"/> is Gl.COLOR_ATTACHMENTm where m is 
		/// greater than or equal to the value of Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
		public static void InvalidateSubFramebuffer(Int32 target, Int32[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			unsafe {
				fixed (Int32* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateSubFramebuffer != null, "pglInvalidateSubFramebuffer not implemented");
					Delegates.pglInvalidateSubFramebuffer(target, (Int32)attachments.Length, p_attachments, x, y, width, height);
					LogFunction("glInvalidateSubFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6})", LogEnumName(target), attachments.Length, LogEnumName(attachments), x, y, width, height);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple sets of primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of an array of structures containing the draw parameters.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the the number of elements in the array of draw parameter structures.
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is not a multiple of four.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
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
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.MultiDrawElementsIndirect"/>
		[AliasOf("glMultiDrawArraysIndirectAMD")]
		[AliasOf("glMultiDrawArraysIndirectEXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
		public static void MultiDrawArraysIndirect(Int32 mode, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirect != null, "pglMultiDrawArraysIndirect not implemented");
			Delegates.pglMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
			LogFunction("glMultiDrawArraysIndirect({0}, 0x{1}, {2}, {3})", LogEnumName(mode), indirect.ToString("X8"), drawcount, stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple sets of primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of an array of structures containing the draw parameters.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the the number of elements in the array of draw parameter structures.
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is not a multiple of four.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
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
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.MultiDrawElementsIndirect"/>
		[AliasOf("glMultiDrawArraysIndirectAMD")]
		[AliasOf("glMultiDrawArraysIndirectEXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
		public static void MultiDrawArraysIndirect(Int32 mode, Object indirect, Int32 drawcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirect(mode, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
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
		/// Specifies the address of a structure containing an array of draw parameters.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the number of elements in the array addressed by <paramref name="indirect"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is not a multiple of four.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
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
		/// <seealso cref="Gl.DrawElementsIndirect"/>
		/// <seealso cref="Gl.MultiDrawArraysIndirect"/>
		[AliasOf("glMultiDrawElementsIndirectAMD")]
		[AliasOf("glMultiDrawElementsIndirectEXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
		public static void MultiDrawElementsIndirect(Int32 mode, Int32 type, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirect != null, "pglMultiDrawElementsIndirect not implemented");
			Delegates.pglMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
			LogFunction("glMultiDrawElementsIndirect({0}, {1}, 0x{2}, {3}, {4})", LogEnumName(mode), LogEnumName(type), indirect.ToString("X8"), drawcount, stride);
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
		/// Specifies the address of a structure containing an array of draw parameters.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the number of elements in the array addressed by <paramref name="indirect"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is not a multiple of four.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
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
		/// <seealso cref="Gl.DrawElementsIndirect"/>
		/// <seealso cref="Gl.MultiDrawArraysIndirect"/>
		[AliasOf("glMultiDrawElementsIndirectAMD")]
		[AliasOf("glMultiDrawElementsIndirectEXT")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
		public static void MultiDrawElementsIndirect(Int32 mode, Int32 type, Object indirect, Int32 drawcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirect(mode, type, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// query a property of an interface in a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose interface to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> to query.
		/// </param>
		/// <param name="pname">
		/// The name of the parameter within <paramref name="programInterface"/> to query.
		/// </param>
		/// <param name="params">
		/// The address of a variable to retrieve the value of <paramref name="pname"/> for the program interface.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="identifier"/> is not one of the accepted object types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.MAX_NAME_LENGTH and <paramref 
		/// name="programInterface"/> is Gl.ATOMIC_COUNTER_BUFFER or Gl.TRANSFORM_FEEDBACK_BUFFER, since active atomic counter and 
		/// transform feedback buffer resources are not assigned name strings.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="pname"/> is Gl.MAX_NUM_ACTIVE_VARIABLES and <paramref 
		/// name="programInterface"/> is not Gl.UNIFORM_BLOCK, Gl.SHADER_STORAGE_BLOCK, Gl.ATOMIC_COUNTER_BUFFER, or 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// If not NULL, <paramref name="length"/> and <paramref name="label"/> should be addresses to which the client has write 
		/// access, otherwise undefined behavior, including process termination may occur.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static void GetProgramInterface(UInt32 program, Int32 programInterface, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramInterfaceiv != null, "pglGetProgramInterfaceiv not implemented");
					Delegates.pglGetProgramInterfaceiv(program, programInterface, pname, p_params);
					LogFunction("glGetProgramInterfaceiv({0}, {1}, {2}, {3})", program, LogEnumName(programInterface), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the index of a named resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> containing the resource named <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the index of.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is Gl.ATOMIC_COUNTER_BUFFER or 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, since active atomic counter and transform feedback buffer resources are not assigned name 
		/// strings.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Although not an error, Gl.INVALID_INDEX is returned if <paramref name="name"/> is not the name of a resource within the 
		/// interface identified by <paramref name="programInterface"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static UInt32 GetProgramResourceIndex(UInt32 program, Int32 programInterface, String name)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceIndex != null, "pglGetProgramResourceIndex not implemented");
			retValue = Delegates.pglGetProgramResourceIndex(program, programInterface, name);
			LogFunction("glGetProgramResourceIndex({0}, {1}, {2}) = {3}", program, LogEnumName(programInterface), name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// query the name of an indexed resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> containing the indexed resource.
		/// </param>
		/// <param name="index">
		/// The index of the resource within <paramref name="programInterface"/> of <paramref name="program"/>.
		/// </param>
		/// <param name="bufSize">
		/// The size of the character array whose address is given by <paramref name="name"/>.
		/// </param>
		/// <param name="length">
		/// The address of a variable which will receive the length of the resource name.
		/// </param>
		/// <param name="name">
		/// The address of a character array into which will be written the name of the resource.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="progam"/> is not the name of an existing program.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of entries in the 
		/// active resource list for <paramref name="programInterface"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is Gl.ATOMIC_COUNTER_BUFFER or 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, since active atomic counter and transform feedback buffer resources are not assigned name 
		/// strings.
		/// </exception>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static void GetProgramResourceName(UInt32 program, Int32 programInterface, UInt32 index, Int32 bufSize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramResourceName != null, "pglGetProgramResourceName not implemented");
					Delegates.pglGetProgramResourceName(program, programInterface, index, bufSize, p_length, name);
					LogFunction("glGetProgramResourceName({0}, {1}, {2}, {3}, {4}, {5})", program, LogEnumName(programInterface), index, bufSize, length, name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve values for multiple properties of a single active resource within a program object
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> containing the resource named <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="props">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="propCount"/> is zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVLALID_ENUM is generated if any value in <paramref name="props"/> is not one of the accepted tokens for the 
		/// interface <paramref name="programInterface"/>
		/// </exception>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetGetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static void GetProgramResource(UInt32 program, Int32 programInterface, UInt32 index, Int32[] props, out Int32 length, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_props = props)
				fixed (Int32* p_length = &length)
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramResourceiv != null, "pglGetProgramResourceiv not implemented");
					Delegates.pglGetProgramResourceiv(program, programInterface, index, (Int32)props.Length, p_props, (Int32)@params.Length, p_length, p_params);
					LogFunction("glGetProgramResourceiv({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", program, LogEnumName(programInterface), index, props.Length, LogEnumName(props), @params.Length, length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the location of a named resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> containing the resource named <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the location of.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been linked successfully.
		/// </exception>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static Int32 GetProgramResourceLocation(UInt32 program, Int32 programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocation != null, "pglGetProgramResourceLocation not implemented");
			retValue = Delegates.pglGetProgramResourceLocation(program, programInterface, name);
			LogFunction("glGetProgramResourceLocation({0}, {1}, {2}) = {3}", program, LogEnumName(programInterface), name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// query the fragment color index of a named variable within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query.
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within <paramref name="program"/> containing the resource named <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the location of.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="programInterface"/> is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been linked successfully.
		/// </exception>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		public static Int32 GetProgramResourceLocationIndex(UInt32 program, Int32 programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocationIndex != null, "pglGetProgramResourceLocationIndex not implemented");
			retValue = Delegates.pglGetProgramResourceLocationIndex(program, programInterface, name);
			LogFunction("glGetProgramResourceLocationIndex({0}, {1}, {2}) = {3}", program, LogEnumName(programInterface), name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// change an active shader storage block binding
		/// </summary>
		/// <param name="program">
		/// The name of the program containing the block whose binding to change.
		/// </param>
		/// <param name="storageBlockIndex">
		/// The index storage block within the program.
		/// </param>
		/// <param name="storageBlockBinding">
		/// The index storage block binding to associate with the specified storage block.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no vertex array object is bound.
		/// </exception>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		public static void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
		{
			Debug.Assert(Delegates.pglShaderStorageBlockBinding != null, "pglShaderStorageBlockBinding not implemented");
			Delegates.pglShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
			LogFunction("glShaderStorageBlockBinding({0}, {1}, {2})", program, storageBlockIndex, storageBlockBinding);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a range of a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexBufferRange. Must be Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the data in the store belonging to <paramref name="buffer"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset of the start of the range of the buffer's data store to attach.
		/// </param>
		/// <param name="size">
		/// Specifies the size of the range of the buffer's data store to attach.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TexBufferRange if <paramref name="target"/> is not Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureBufferRange if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TextureBufferRange if the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the sized internal formats described 
		/// above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="buffer"/> is not zero and is not the name of an existing buffer 
		/// object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> is negative, if <paramref name="size"/> is less than or equal 
		/// to zero, or if <paramref name="offset"/> + <paramref name="size"/> is greater than the value of Gl.BUFFER_SIZE for 
		/// <paramref name="buffer"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> is not an integer multiple of the value of 
		/// Gl.TEXTURE_BUFFER_OFFSET_ALIGNMENT.
		/// </exception>
		/// <seealso cref="Gl.TexBuffer"/>
		[AliasOf("glTexBufferRangeEXT")]
		[AliasOf("glTexBufferRangeOES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public static void TexBufferRange(Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTexBufferRange != null, "pglTexBufferRange not implemented");
			Delegates.pglTexBufferRange(target, internalformat, buffer, offset, size);
			LogFunction("glTexBufferRange({0}, {1}, {2}, 0x{3}, {4})", LogEnumName(target), LogEnumName(internalformat), buffer, offset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexStorage2DMultisample. Must be one of 
		/// Gl.TEXTURE_2D_MULTISAMPLE or Gl.PROXY_TEXTURE_2D_MULTISAMPLE.
		/// </param>
		/// <param name="samples">
		/// Specify the number of samples in the texture.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the sized internal format to be used to store texture image data.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture, in texels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture, in texels.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage2DMultisample if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage2DMultisample if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid color-renderable, depth-renderable or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> are less than 1 or greater than 
		/// the value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="levels"/> is less than 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is greater than the value of Gl.MAX_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for the texture bound to <paramref 
		/// name="target"/> is not Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
		public static void TexStorage2DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexStorage2DMultisample != null, "pglTexStorage2DMultisample not implemented");
			Delegates.pglTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
			LogFunction("glTexStorage2DMultisample({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), samples, LogEnumName(internalformat), width, height, fixedsamplelocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample array texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexStorage3DMultisample. Must be one of 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="samples">
		/// Specify the number of samples in the texture.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the sized internal format to be used to store texture image data.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture, in texels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture, in texels.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture, in layers.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage3DMultisample if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage3DMultisample if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid color-renderable, depth-renderable or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> are less than 1 or greater than 
		/// the value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="depth"/> is less than 1 or greater than the value of 
		/// Gl.MAX_ARRAY_TEXTURE_LAYERS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="levels"/> is less than 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is greater than the value of Gl.MAX_SAMPLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for the texture bound to <paramref 
		/// name="target"/> is not Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[AliasOf("glTexStorage3DMultisampleOES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		public static void TexStorage3DMultisample(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexStorage3DMultisample != null, "pglTexStorage3DMultisample not implemented");
			Delegates.pglTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
			LogFunction("glTexStorage3DMultisample({0}, {1}, {2}, {3}, {4}, {5}, {6})", LogEnumName(target), samples, LogEnumName(internalformat), width, height, depth, fixedsamplelocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// initialize a texture as a data alias of another texture's data store
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object to be initialized as a view.
		/// </param>
		/// <param name="target">
		/// Specifies the target to be used for the newly initialized texture.
		/// </param>
		/// <param name="origtexture">
		/// Specifies the name of a texture object of which to make a view.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format for the newly created view.
		/// </param>
		/// <param name="minlevel">
		/// Specifies lowest level of detail of the view.
		/// </param>
		/// <param name="numlevels">
		/// Specifies the number of levels of detail to include in the view.
		/// </param>
		/// <param name="minlayer">
		/// Specifies the index of the first layer to include in the view.
		/// </param>
		/// <param name="numlayers">
		/// Specifies the number of layers to include in the view.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="minlayer"/> or <paramref name="minlevel"/> are larger than the greatest 
		/// layer or level of <paramref name="origtexture"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not compatible with the target of <paramref 
		/// name="origtexture"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the dimensions of <paramref name="origtexture"/> are greater than the maximum 
		/// supported dimensions for <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is not compatible with the internal format of 
		/// <paramref name="origtexture"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has already been bound or otherwise given a target.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for <paramref name="origtexture"/> is not 
		/// Gl.TRUE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="origtexture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generaged if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP and <paramref name="numlayers"/> is 
		/// not 6, or if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP_ARRAY and <paramref name="numlayers"/> is not an integer 
		/// multiple of 6.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_RECTANGLE, or Gl.TEXTURE_2D_MULTISAMPLE and <paramref name="numlayers"/> does not equal 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> zero or is not the name of a texture previously returned 
		/// from a successful call to glGenTextures.
		/// </exception>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		[AliasOf("glTextureViewEXT")]
		[AliasOf("glTextureViewOES")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
		public static void Texture(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			Debug.Assert(Delegates.pglTextureView != null, "pglTextureView not implemented");
			Delegates.pglTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			LogFunction("glTextureView({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, LogEnumName(target), origtexture, LogEnumName(internalformat), minlevel, numlevels, minlayer, numlayers);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a buffer to a vertex buffer bind point
		/// </summary>
		/// <param name="bindingindex">
		/// The index of the vertex buffer binding point to which to bind the buffer.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer to bind to the vertex buffer binding point.
		/// </param>
		/// <param name="offset">
		/// The offset of the first element of the buffer.
		/// </param>
		/// <param name="stride">
		/// The distance between elements within the buffer.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BindVertexBuffer if no vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayVertexBuffer if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="stride"/> is less than zero, or if stride 
		/// is greater than the value of Gl.MAX_VERTEX_ATTRIB_STRIDE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is not zero or the name of an existing buffer object (as 
		/// returned by Gl.GenBuffers or Gl.CreateBuffers).
		/// </exception>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			Debug.Assert(Delegates.pglBindVertexBuffer != null, "pglBindVertexBuffer not implemented");
			Delegates.pglBindVertexBuffer(bindingindex, buffer, offset, stride);
			LogFunction("glBindVertexBuffer({0}, {1}, 0x{2}, {3})", bindingindex, buffer, offset.ToString("X8"), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="normalized">
		/// The distance between elements within the buffer.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void VertexAttribFormat(UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribFormat != null, "pglVertexAttribFormat not implemented");
			Delegates.pglVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
			LogFunction("glVertexAttribFormat({0}, {1}, {2}, {3}, {4})", attribindex, size, LogEnumName(type), normalized, relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void VertexAttribIFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribIFormat != null, "pglVertexAttribIFormat not implemented");
			Delegates.pglVertexAttribIFormat(attribindex, size, type, relativeoffset);
			LogFunction("glVertexAttribIFormat({0}, {1}, {2}, {3})", attribindex, size, LogEnumName(type), relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void VertexAttribLFormat(UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribLFormat != null, "pglVertexAttribLFormat not implemented");
			Delegates.pglVertexAttribLFormat(attribindex, size, type, relativeoffset);
			LogFunction("glVertexAttribLFormat({0}, {1}, {2}, {3})", attribindex, size, LogEnumName(type), relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// associate a vertex attribute and a vertex buffer binding for a vertex array object
		/// </summary>
		/// <param name="attribindex">
		/// The index of the attribute to associate with a vertex buffer binding.
		/// </param>
		/// <param name="bindingindex">
		/// The index of the vertex buffer binding with which to associate the generic vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribBinding if no vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribBinding if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
		{
			Debug.Assert(Delegates.pglVertexAttribBinding != null, "pglVertexAttribBinding not implemented");
			Delegates.pglVertexAttribBinding(attribindex, bindingindex);
			LogFunction("glVertexAttribBinding({0}, {1})", attribindex, bindingindex);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// modify the rate at which generic vertex attributes advance
		/// </summary>
		/// <param name="bindingindex">
		/// The index of the binding whose divisor to modify.
		/// </param>
		/// <param name="divisor">
		/// The new value for the instance step rate to apply.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION by Gl.VertexBindingDivisor is generated if no vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayBindingDivisor if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		public static void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexBindingDivisor != null, "pglVertexBindingDivisor not implemented");
			Delegates.pglVertexBindingDivisor(bindingindex, divisor);
			LogFunction("glVertexBindingDivisor({0}, {1})", bindingindex, divisor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the reporting of debug messages in a debug context
		/// </summary>
		/// <param name="source">
		/// The source of debug messages to enable or disable.
		/// </param>
		/// <param name="type">
		/// The type of debug messages to enable or disable.
		/// </param>
		/// <param name="severity">
		/// The severity of debug messages to enable or disable.
		/// </param>
		/// <param name="ids">
		/// The address of an array of unsigned integers contianing the ids of the messages to enable or disable.
		/// </param>
		/// <param name="enabled">
		/// A Boolean flag determining whether the selected messages should be enabled or disabled.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if any of <paramref name="source"/>, <paramref name="type"/> or <paramref name="severity"/> 
		/// is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is non-zero and either <paramref name="source"/> or 
		/// <paramref name="type"/> is Gl.DONT_CARE or if <paramref name="severity"/> is not Gl.DONT_CARE.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		[AliasOf("glDebugMessageControlARB")]
		[AliasOf("glDebugMessageControlKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void DebugMessageControl(Int32 source, Int32 type, Int32 severity, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDebugMessageControl != null, "pglDebugMessageControl not implemented");
					Delegates.pglDebugMessageControl(source, type, severity, (Int32)ids.Length, p_ids, enabled);
					LogFunction("glDebugMessageControl({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(source), LogEnumName(type), LogEnumName(severity), ids.Length, LogValue(ids), enabled);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// inject an application-supplied message into the debug message queue
		/// </summary>
		/// <param name="source">
		/// The source of the debug message to insert.
		/// </param>
		/// <param name="type">
		/// The type of the debug message insert.
		/// </param>
		/// <param name="id">
		/// The user-supplied identifier of the message to insert.
		/// </param>
		/// <param name="severity">
		/// The severity of the debug messages to insert.
		/// </param>
		/// <param name="length">
		/// The length string contained in the character array whose address is given by <paramref name="message"/>.
		/// </param>
		/// <param name="buf">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if any of <paramref name="source"/>, <paramref name="type"/> or <paramref name="severity"/> 
		/// is not one of the accepted interface types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the length of the message is greater than the value of Gl.MAX_DEBUG_MESSAGE_LENGTH.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		[AliasOf("glDebugMessageInsertARB")]
		[AliasOf("glDebugMessageInsertKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void DebugMessageInsert(Int32 source, Int32 type, UInt32 id, Int32 severity, Int32 length, String buf)
		{
			Debug.Assert(Delegates.pglDebugMessageInsert != null, "pglDebugMessageInsert not implemented");
			Delegates.pglDebugMessageInsert(source, type, id, severity, length, buf);
			LogFunction("glDebugMessageInsert({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(source), LogEnumName(type), id, LogEnumName(severity), length, buf);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a callback to receive debugging messages from the GL
		/// </summary>
		/// <param name="callback">
		/// The address of a callback function that will be called when a debug message is generated.
		/// </param>
		/// <param name="userParam">
		/// A user supplied pointer that will be passed on each invocation of <paramref name="callback"/>.
		/// </param>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		[AliasOf("glDebugMessageCallbackARB")]
		[AliasOf("glDebugMessageCallbackKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void DebugMessageCallback(Gl.DebugProc callback, IntPtr userParam)
		{
			Debug.Assert(Delegates.pglDebugMessageCallback != null, "pglDebugMessageCallback not implemented");
			Delegates.pglDebugMessageCallback(callback, userParam);
			LogFunction("glDebugMessageCallback({0}, 0x{1})", callback, userParam.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a callback to receive debugging messages from the GL
		/// </summary>
		/// <param name="callback">
		/// The address of a callback function that will be called when a debug message is generated.
		/// </param>
		/// <param name="userParam">
		/// A user supplied pointer that will be passed on each invocation of <paramref name="callback"/>.
		/// </param>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		[AliasOf("glDebugMessageCallbackARB")]
		[AliasOf("glDebugMessageCallbackKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void DebugMessageCallback(Gl.DebugProc callback, Object userParam)
		{
			GCHandle pin_userParam = GCHandle.Alloc(userParam, GCHandleType.Pinned);
			try {
				DebugMessageCallback(callback, pin_userParam.AddrOfPinnedObject());
			} finally {
				pin_userParam.Free();
			}
		}

		/// <summary>
		/// retrieve messages from the debug message log
		/// </summary>
		/// <param name="bufSize">
		/// The size of the buffer whose address is given by <paramref name="messageLog"/>.
		/// </param>
		/// <param name="sources">
		/// The address of an array of variables to receive the sources of the retrieved messages.
		/// </param>
		/// <param name="types">
		/// The address of an array of variables to receive the types of the retrieved messages.
		/// </param>
		/// <param name="ids">
		/// The address of an array of unsigned integers to receive the ids of the retrieved messages.
		/// </param>
		/// <param name="severities">
		/// The address of an array of variables to receive the severites of the retrieved messages.
		/// </param>
		/// <param name="lengths">
		/// The address of an array of variables to receive the lengths of the received messages.
		/// </param>
		/// <param name="messageLog">
		/// The address of an array of characters that will receive the messages.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="bufSize"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.DebugMessageControl"/>
		[AliasOf("glGetDebugMessageLogARB")]
		[AliasOf("glGetDebugMessageLogKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static UInt32 GetDebugMessageLog(Int32 bufSize, [Out] Int32[] sources, [Out] Int32[] types, [Out] UInt32[] ids, [Out] Int32[] severities, [Out] Int32[] lengths, [Out] StringBuilder messageLog)
		{
			UInt32 retValue;

			unsafe {
				fixed (Int32* p_sources = sources)
				fixed (Int32* p_types = types)
				fixed (UInt32* p_ids = ids)
				fixed (Int32* p_severities = severities)
				fixed (Int32* p_lengths = lengths)
				{
					Debug.Assert(Delegates.pglGetDebugMessageLog != null, "pglGetDebugMessageLog not implemented");
					retValue = Delegates.pglGetDebugMessageLog((UInt32)sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
					LogFunction("glGetDebugMessageLog({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", sources.Length, bufSize, LogEnumName(sources), LogEnumName(types), LogValue(ids), LogEnumName(severities), LogValue(lengths), messageLog, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// push a named debug group into the command stream
		/// </summary>
		/// <param name="source">
		/// The source of the debug message.
		/// </param>
		/// <param name="id">
		/// The identifier of the message.
		/// </param>
		/// <param name="length">
		/// The length of the message to be sent to the debug output stream.
		/// </param>
		/// <param name="message">
		/// The a string containing the message to be sent to the debug output stream.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the value of <paramref name="source"/> is neither Gl.DEBUG_SOURCE_APPLICATION nor 
		/// Gl.DEBUG_SOURCE_THIRD_PARTY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="length"/> is negative and the number of characters in <paramref 
		/// name="message"/>, excluding the null-terminator, is not less than the value of Gl.MAX_DEBUG_MESSAGE_LENGTH.
		/// </exception>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		[AliasOf("glPushDebugGroupKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void PushDebugGroup(Int32 source, UInt32 id, Int32 length, String message)
		{
			Debug.Assert(Delegates.pglPushDebugGroup != null, "pglPushDebugGroup not implemented");
			Delegates.pglPushDebugGroup(source, id, length, message);
			LogFunction("glPushDebugGroup({0}, {1}, {2}, {3})", LogEnumName(source), id, length, message);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// pop the active debug group
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.STACK_UNDERFLOW is generated if an attempt is made to pop the default debug group from the stack.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		[AliasOf("glPopDebugGroupKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void PopDebugGroup()
		{
			Debug.Assert(Delegates.pglPopDebugGroup != null, "pglPopDebugGroup not implemented");
			Delegates.pglPopDebugGroup();
			LogFunction("glPopDebugGroup()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// label a named object identified within a namespace
		/// </summary>
		/// <param name="identifier">
		/// The namespace from which the name of the object is allocated.
		/// </param>
		/// <param name="name">
		/// The name of the object to label.
		/// </param>
		/// <param name="length">
		/// The length of the label to be used for the object.
		/// </param>
		/// <param name="label">
		/// The address of a string containing the label to assign to the object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="identifier"/> is not one of the accepted object types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> is not the name of an existing object of the type specified 
		/// by <paramref name="identifier"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the number of characters in <paramref name="label"/>, excluding the null terminator 
		/// when <paramref name="length"/> is negative, is greater than the value of Gl.MAX_LABEL_LENGTH.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		[AliasOf("glObjectLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void Object(Int32 identifier, UInt32 name, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglObjectLabel != null, "pglObjectLabel not implemented");
			Delegates.pglObjectLabel(identifier, name, length, label);
			LogFunction("glObjectLabel({0}, {1}, {2}, {3})", LogEnumName(identifier), name, length, label);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the label of a named object identified within a namespace
		/// </summary>
		/// <param name="identifier">
		/// The namespace from which the name of the object is allocated.
		/// </param>
		/// <param name="name">
		/// The name of the object whose label to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// The length of the buffer whose address is in <paramref name="label"/>.
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label.
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="identifier"/> is not one of the accepted object types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> is not the name of an existing object of the type specified 
		/// by <paramref name="identifier"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// If not NULL, <paramref name="length"/> and <paramref name="label"/> should be addresses to which the client has write 
		/// access, otherwise undefined behavior, including process termination may occur.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectPtrLabel"/>
		[AliasOf("glGetObjectLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void GetObject(Int32 identifier, UInt32 name, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetObjectLabel != null, "pglGetObjectLabel not implemented");
					Delegates.pglGetObjectLabel(identifier, name, bufSize, p_length, label);
					LogFunction("glGetObjectLabel({0}, {1}, {2}, {3}, {4})", LogEnumName(identifier), name, bufSize, length, label);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// label a a sync object identified by a pointer
		/// </summary>
		/// <param name="ptr">
		/// A pointer identifying a sync object.
		/// </param>
		/// <param name="length">
		/// The length of the label to be used for the object.
		/// </param>
		/// <param name="label">
		/// The address of a string containing the label to assign to the object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="ptr"/> is not a valid sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the number of characters in <paramref name="label"/>, excluding the null terminator 
		/// when <paramref name="length"/> is negative, is greater than the value of Gl.MAX_LABEL_LENGTH.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		[AliasOf("glObjectPtrLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void Object(IntPtr ptr, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglObjectPtrLabel != null, "pglObjectPtrLabel not implemented");
			Delegates.pglObjectPtrLabel(ptr, length, label);
			LogFunction("glObjectPtrLabel(0x{0}, {1}, {2})", ptr.ToString("X8"), length, label);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// label a a sync object identified by a pointer
		/// </summary>
		/// <param name="ptr">
		/// A pointer identifying a sync object.
		/// </param>
		/// <param name="length">
		/// The length of the label to be used for the object.
		/// </param>
		/// <param name="label">
		/// The address of a string containing the label to assign to the object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="ptr"/> is not a valid sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the number of characters in <paramref name="label"/>, excluding the null terminator 
		/// when <paramref name="length"/> is negative, is greater than the value of Gl.MAX_LABEL_LENGTH.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		[AliasOf("glObjectPtrLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void Object(Object ptr, Int32 length, String label)
		{
			GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
			try {
				Object(pin_ptr.AddrOfPinnedObject(), length, label);
			} finally {
				pin_ptr.Free();
			}
		}

		/// <summary>
		/// retrieve the label of a sync object identified by a pointer
		/// </summary>
		/// <param name="ptr">
		/// The name of the sync object whose label to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// The length of the buffer whose address is in <paramref name="label"/>.
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label.
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="identifier"/> is not one of the accepted object types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="ptr"/> is not the name of an existing sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// If not NULL, <paramref name="length"/> and <paramref name="label"/> should be addresses to which the client has write 
		/// access, otherwise undefined behavior, including process termination may occur.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
		[AliasOf("glGetObjectPtrLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void GetObject(IntPtr ptr, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetObjectPtrLabel != null, "pglGetObjectPtrLabel not implemented");
					Delegates.pglGetObjectPtrLabel(ptr, bufSize, p_length, label);
					LogFunction("glGetObjectPtrLabel(0x{0}, {1}, {2}, {3})", ptr.ToString("X8"), bufSize, length, label);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the label of a sync object identified by a pointer
		/// </summary>
		/// <param name="ptr">
		/// The name of the sync object whose label to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// The length of the buffer whose address is in <paramref name="label"/>.
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label.
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="identifier"/> is not one of the accepted object types.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="ptr"/> is not the name of an existing sync object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// If not NULL, <paramref name="length"/> and <paramref name="label"/> should be addresses to which the client has write 
		/// access, otherwise undefined behavior, including process termination may occur.
		/// </exception>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
		[AliasOf("glGetObjectPtrLabelKHR")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		public static void GetObject(Object ptr, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
			try {
				GetObject(pin_ptr.AddrOfPinnedObject(), bufSize, out length, label);
			} finally {
				pin_ptr.Free();
			}
		}

	}

}
