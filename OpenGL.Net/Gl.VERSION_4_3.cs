
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGB8_ETC2 = 0x9274;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_ETC2 = 0x9275;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGBA8_ETC2_EAC = 0x9278;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;

		/// <summary>
		/// Value of GL_COMPRESSED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_R11_EAC = 0x9270;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SIGNED_R11_EAC = 0x9271;

		/// <summary>
		/// Value of GL_COMPRESSED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RG11_EAC = 0x9272;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SIGNED_RG11_EAC = 0x9273;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_FIXED_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED_CONSERVATIVE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

		/// <summary>
		/// Value of GL_MAX_ELEMENT_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int MAX_ELEMENT_INDEX = 0x8D6B;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int COMPUTE_SHADER = 0x91B9;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_SHARED_MEMORY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;

		/// <summary>
		/// Value of GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_COUNT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

		/// <summary>
		/// Value of GL_COMPUTE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int COMPUTE_WORK_GROUP_SIZE = 0x8267;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;

		/// <summary>
		/// Value of GL_DISPATCH_INDIRECT_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;

		/// <summary>
		/// Value of GL_DISPATCH_INDIRECT_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const uint COMPUTE_SHADER_BIT = 0x00000020;

		/// <summary>
		/// Value of GL_DEBUG_OUTPUT_SYNCHRONOUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;

		/// <summary>
		/// Value of GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_FUNCTION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_CALLBACK_FUNCTION = 0x8244;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_USER_PARAM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_CALLBACK_USER_PARAM = 0x8245;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_API symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_API = 0x8246;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_WINDOW_SYSTEM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_SHADER_COMPILER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_SHADER_COMPILER = 0x8248;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_THIRD_PARTY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_THIRD_PARTY = 0x8249;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_APPLICATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_APPLICATION = 0x824A;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_OTHER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_OTHER = 0x824B;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_ERROR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_ERROR = 0x824C;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PORTABILITY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PORTABILITY = 0x824F;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PERFORMANCE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PERFORMANCE = 0x8250;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_OTHER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_OTHER = 0x8251;

		/// <summary>
		/// Value of GL_MAX_DEBUG_MESSAGE_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_MESSAGE_LENGTH = 0x9143;

		/// <summary>
		/// Value of GL_MAX_DEBUG_LOGGED_MESSAGES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_LOGGED_MESSAGES = 0x9144;

		/// <summary>
		/// Value of GL_DEBUG_LOGGED_MESSAGES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_LOGGED_MESSAGES = 0x9145;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_HIGH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_HIGH = 0x9146;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_MEDIUM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_MEDIUM = 0x9147;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_LOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_LOW = 0x9148;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_MARKER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_MARKER = 0x8268;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PUSH_GROUP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PUSH_GROUP = 0x8269;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_POP_GROUP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_POP_GROUP = 0x826A;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_NOTIFICATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_NOTIFICATION = 0x826B;

		/// <summary>
		/// Value of GL_MAX_DEBUG_GROUP_STACK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;

		/// <summary>
		/// Value of GL_DEBUG_GROUP_STACK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_GROUP_STACK_DEPTH = 0x826D;

		/// <summary>
		/// Value of GL_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int BUFFER = 0x82E0;

		/// <summary>
		/// Value of GL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int SHADER = 0x82E1;

		/// <summary>
		/// Value of GL_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int PROGRAM = 0x82E2;

		/// <summary>
		/// Value of GL_QUERY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int QUERY = 0x82E3;

		/// <summary>
		/// Value of GL_PROGRAM_PIPELINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int PROGRAM_PIPELINE = 0x82E4;

		/// <summary>
		/// Value of GL_SAMPLER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_EXT_debug_label")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int SAMPLER = 0x82E6;

		/// <summary>
		/// Value of GL_MAX_LABEL_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_LABEL_LENGTH = 0x82E8;

		/// <summary>
		/// Value of GL_DEBUG_OUTPUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_OUTPUT = 0x92E0;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_DEBUG_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_MAX_UNIFORM_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_explicit_uniform_location")]
		public const int MAX_UNIFORM_LOCATIONS = 0x826E;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int MAX_FRAMEBUFFER_WIDTH = 0x9315;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int MAX_FRAMEBUFFER_HEIGHT = 0x9316;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int MAX_FRAMEBUFFER_LAYERS = 0x9317;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int MAX_FRAMEBUFFER_SAMPLES = 0x9318;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_SUPPORTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_SUPPORTED = 0x826F;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_PREFERRED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_PREFERRED = 0x8270;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_RED_SIZE = 0x8271;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_GREEN_SIZE = 0x8272;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_BLUE_SIZE = 0x8273;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_ALPHA_SIZE = 0x8274;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_DEPTH_SIZE = 0x8275;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_STENCIL_SIZE = 0x8276;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_SHARED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_SHARED_SIZE = 0x8277;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_RED_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_RED_TYPE = 0x8278;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_GREEN_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_GREEN_TYPE = 0x8279;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_BLUE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_BLUE_TYPE = 0x827A;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_ALPHA_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_ALPHA_TYPE = 0x827B;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_DEPTH_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_DEPTH_TYPE = 0x827C;

		/// <summary>
		/// Value of GL_INTERNALFORMAT_STENCIL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int INTERNALFORMAT_STENCIL_TYPE = 0x827D;

		/// <summary>
		/// Value of GL_MAX_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MAX_WIDTH = 0x827E;

		/// <summary>
		/// Value of GL_MAX_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MAX_HEIGHT = 0x827F;

		/// <summary>
		/// Value of GL_MAX_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MAX_DEPTH = 0x8280;

		/// <summary>
		/// Value of GL_MAX_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MAX_LAYERS = 0x8281;

		/// <summary>
		/// Value of GL_MAX_COMBINED_DIMENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MAX_COMBINED_DIMENSIONS = 0x8282;

		/// <summary>
		/// Value of GL_COLOR_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int COLOR_COMPONENTS = 0x8283;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int DEPTH_COMPONENTS = 0x8284;

		/// <summary>
		/// Value of GL_STENCIL_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int STENCIL_COMPONENTS = 0x8285;

		/// <summary>
		/// Value of GL_COLOR_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int COLOR_RENDERABLE = 0x8286;

		/// <summary>
		/// Value of GL_DEPTH_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int DEPTH_RENDERABLE = 0x8287;

		/// <summary>
		/// Value of GL_STENCIL_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int STENCIL_RENDERABLE = 0x8288;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FRAMEBUFFER_RENDERABLE = 0x8289;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_RENDERABLE_LAYERED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BLEND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FRAMEBUFFER_BLEND = 0x828B;

		/// <summary>
		/// Value of GL_READ_PIXELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int READ_PIXELS = 0x828C;

		/// <summary>
		/// Value of GL_READ_PIXELS_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int READ_PIXELS_FORMAT = 0x828D;

		/// <summary>
		/// Value of GL_READ_PIXELS_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int READ_PIXELS_TYPE = 0x828E;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_IMAGE_FORMAT = 0x828F;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_IMAGE_TYPE = 0x8290;

		/// <summary>
		/// Value of GL_GET_TEXTURE_IMAGE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int GET_TEXTURE_IMAGE_FORMAT = 0x8291;

		/// <summary>
		/// Value of GL_GET_TEXTURE_IMAGE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int GET_TEXTURE_IMAGE_TYPE = 0x8292;

		/// <summary>
		/// Value of GL_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MIPMAP = 0x8293;

		/// <summary>
		/// Value of GL_MANUAL_GENERATE_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int MANUAL_GENERATE_MIPMAP = 0x8294;

		/// <summary>
		/// Value of GL_AUTO_GENERATE_MIPMAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int AUTO_GENERATE_MIPMAP = 0x8295;

		/// <summary>
		/// Value of GL_COLOR_ENCODING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int COLOR_ENCODING = 0x8296;

		/// <summary>
		/// Value of GL_SRGB_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SRGB_READ = 0x8297;

		/// <summary>
		/// Value of GL_SRGB_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SRGB_WRITE = 0x8298;

		/// <summary>
		/// Value of GL_FILTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FILTER = 0x829A;

		/// <summary>
		/// Value of GL_VERTEX_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VERTEX_TEXTURE = 0x829B;

		/// <summary>
		/// Value of GL_TESS_CONTROL_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TESS_CONTROL_TEXTURE = 0x829C;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TESS_EVALUATION_TEXTURE = 0x829D;

		/// <summary>
		/// Value of GL_GEOMETRY_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int GEOMETRY_TEXTURE = 0x829E;

		/// <summary>
		/// Value of GL_FRAGMENT_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FRAGMENT_TEXTURE = 0x829F;

		/// <summary>
		/// Value of GL_COMPUTE_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int COMPUTE_TEXTURE = 0x82A0;

		/// <summary>
		/// Value of GL_TEXTURE_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_SHADOW = 0x82A1;

		/// <summary>
		/// Value of GL_TEXTURE_GATHER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_GATHER = 0x82A2;

		/// <summary>
		/// Value of GL_TEXTURE_GATHER_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_GATHER_SHADOW = 0x82A3;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_LOAD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SHADER_IMAGE_LOAD = 0x82A4;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_STORE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SHADER_IMAGE_STORE = 0x82A5;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_ATOMIC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SHADER_IMAGE_ATOMIC = 0x82A6;

		/// <summary>
		/// Value of GL_IMAGE_TEXEL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_TEXEL_SIZE = 0x82A7;

		/// <summary>
		/// Value of GL_IMAGE_COMPATIBILITY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_COMPATIBILITY_CLASS = 0x82A8;

		/// <summary>
		/// Value of GL_IMAGE_PIXEL_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_PIXEL_FORMAT = 0x82A9;

		/// <summary>
		/// Value of GL_IMAGE_PIXEL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_PIXEL_TYPE = 0x82AA;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;

		/// <summary>
		/// Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;

		/// <summary>
		/// Value of GL_CLEAR_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int CLEAR_BUFFER = 0x82B4;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_VIEW = 0x82B5;

		/// <summary>
		/// Value of GL_VIEW_COMPATIBILITY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_COMPATIBILITY_CLASS = 0x82B6;

		/// <summary>
		/// Value of GL_FULL_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int FULL_SUPPORT = 0x82B7;

		/// <summary>
		/// Value of GL_CAVEAT_SUPPORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int CAVEAT_SUPPORT = 0x82B8;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_4_X_32 = 0x82B9;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_2_X_32 = 0x82BA;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_1_X_32 = 0x82BB;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_4_X_16 = 0x82BC;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_2_X_16 = 0x82BD;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_1_X_16 = 0x82BE;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_4_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_4_X_8 = 0x82BF;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_2_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_2_X_8 = 0x82C0;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_1_X_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_1_X_8 = 0x82C1;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_11_11_10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_11_11_10 = 0x82C2;

		/// <summary>
		/// Value of GL_IMAGE_CLASS_10_10_10_2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int IMAGE_CLASS_10_10_10_2 = 0x82C3;

		/// <summary>
		/// Value of GL_VIEW_CLASS_128_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_128_BITS = 0x82C4;

		/// <summary>
		/// Value of GL_VIEW_CLASS_96_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_96_BITS = 0x82C5;

		/// <summary>
		/// Value of GL_VIEW_CLASS_64_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_64_BITS = 0x82C6;

		/// <summary>
		/// Value of GL_VIEW_CLASS_48_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_48_BITS = 0x82C7;

		/// <summary>
		/// Value of GL_VIEW_CLASS_32_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_32_BITS = 0x82C8;

		/// <summary>
		/// Value of GL_VIEW_CLASS_24_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_24_BITS = 0x82C9;

		/// <summary>
		/// Value of GL_VIEW_CLASS_16_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_16_BITS = 0x82CA;

		/// <summary>
		/// Value of GL_VIEW_CLASS_8_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_8_BITS = 0x82CB;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT1_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT1_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT3_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;

		/// <summary>
		/// Value of GL_VIEW_CLASS_S3TC_DXT5_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;

		/// <summary>
		/// Value of GL_VIEW_CLASS_RGTC1_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_RGTC1_RED = 0x82D0;

		/// <summary>
		/// Value of GL_VIEW_CLASS_RGTC2_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_RGTC2_RG = 0x82D1;

		/// <summary>
		/// Value of GL_VIEW_CLASS_BPTC_UNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_BPTC_UNORM = 0x82D2;

		/// <summary>
		/// Value of GL_VIEW_CLASS_BPTC_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int VIEW_CLASS_BPTC_FLOAT = 0x82D3;

		/// <summary>
		/// Value of GL_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int UNIFORM = 0x92E1;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int UNIFORM_BLOCK = 0x92E2;

		/// <summary>
		/// Value of GL_PROGRAM_INPUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int PROGRAM_INPUT = 0x92E3;

		/// <summary>
		/// Value of GL_PROGRAM_OUTPUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int PROGRAM_OUTPUT = 0x92E4;

		/// <summary>
		/// Value of GL_BUFFER_VARIABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_VARIABLE = 0x92E5;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BLOCK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int SHADER_STORAGE_BLOCK = 0x92E6;

		/// <summary>
		/// Value of GL_VERTEX_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int VERTEX_SUBROUTINE = 0x92E8;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TESS_CONTROL_SUBROUTINE = 0x92E9;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TESS_EVALUATION_SUBROUTINE = 0x92EA;

		/// <summary>
		/// Value of GL_GEOMETRY_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int GEOMETRY_SUBROUTINE = 0x92EB;

		/// <summary>
		/// Value of GL_FRAGMENT_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int FRAGMENT_SUBROUTINE = 0x92EC;

		/// <summary>
		/// Value of GL_COMPUTE_SUBROUTINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int COMPUTE_SUBROUTINE = 0x92ED;

		/// <summary>
		/// Value of GL_VERTEX_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int VERTEX_SUBROUTINE_UNIFORM = 0x92EE;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;

		/// <summary>
		/// Value of GL_GEOMETRY_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;

		/// <summary>
		/// Value of GL_FRAGMENT_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;

		/// <summary>
		/// Value of GL_COMPUTE_SUBROUTINE_UNIFORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TRANSFORM_FEEDBACK_VARYING = 0x92F4;

		/// <summary>
		/// Value of GL_ACTIVE_RESOURCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ACTIVE_RESOURCES = 0x92F5;

		/// <summary>
		/// Value of GL_MAX_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MAX_NAME_LENGTH = 0x92F6;

		/// <summary>
		/// Value of GL_MAX_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MAX_NUM_ACTIVE_VARIABLES = 0x92F7;

		/// <summary>
		/// Value of GL_MAX_NUM_COMPATIBLE_SUBROUTINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;

		/// <summary>
		/// Value of GL_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int NAME_LENGTH = 0x92F9;

		/// <summary>
		/// Value of GL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TYPE = 0x92FA;

		/// <summary>
		/// Value of GL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ARRAY_SIZE = 0x92FB;

		/// <summary>
		/// Value of GL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int OFFSET = 0x92FC;

		/// <summary>
		/// Value of GL_BLOCK_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BLOCK_INDEX = 0x92FD;

		/// <summary>
		/// Value of GL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ARRAY_STRIDE = 0x92FE;

		/// <summary>
		/// Value of GL_MATRIX_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MATRIX_STRIDE = 0x92FF;

		/// <summary>
		/// Value of GL_IS_ROW_MAJOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int IS_ROW_MAJOR = 0x9300;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;

		/// <summary>
		/// Value of GL_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_BINDING = 0x9302;

		/// <summary>
		/// Value of GL_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_DATA_SIZE = 0x9303;

		/// <summary>
		/// Value of GL_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int NUM_ACTIVE_VARIABLES = 0x9304;

		/// <summary>
		/// Value of GL_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ACTIVE_VARIABLES = 0x9305;

		/// <summary>
		/// Value of GL_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_VERTEX_SHADER = 0x9306;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;

		/// <summary>
		/// Value of GL_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_GEOMETRY_SHADER = 0x9309;

		/// <summary>
		/// Value of GL_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_FRAGMENT_SHADER = 0x930A;

		/// <summary>
		/// Value of GL_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_COMPUTE_SHADER = 0x930B;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TOP_LEVEL_ARRAY_SIZE = 0x930C;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TOP_LEVEL_ARRAY_STRIDE = 0x930D;

		/// <summary>
		/// Value of GL_LOCATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int LOCATION = 0x930E;

		/// <summary>
		/// Value of GL_LOCATION_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int LOCATION_INDEX = 0x930F;

		/// <summary>
		/// Value of GL_IS_PER_PATCH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int IS_PER_PATCH = 0x92E7;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER = 0x90D2;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_START = 0x90D4;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;

		/// <summary>
		/// Value of GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;

		/// <summary>
		/// Value of GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;

		/// <summary>
		/// Value of GL_MAX_SHADER_STORAGE_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;

		/// <summary>
		/// Value of GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_TEXTURE_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_stencil_texturing")]
		public const int DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_buffer_range")]
		public const int TEXTURE_BUFFER_OFFSET = 0x919D;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_buffer_range")]
		public const int TEXTURE_BUFFER_SIZE = 0x919E;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_buffer_range")]
		public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view")]
		public const int TEXTURE_VIEW_MIN_LEVEL = 0x82DB;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LEVELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view")]
		public const int TEXTURE_VIEW_NUM_LEVELS = 0x82DC;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LAYER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view")]
		public const int TEXTURE_VIEW_MIN_LAYER = 0x82DD;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view")]
		public const int TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

		/// <summary>
		/// Value of GL_TEXTURE_IMMUTABLE_LEVELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_view")]
		[RequiredByFeature("GL_EXT_texture_view")]
		[RequiredByFeature("GL_OES_texture_view")]
		public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_ATTRIB_BINDING = 0x82D4;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_DIVISOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_DIVISOR = 0x82D6;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_OFFSET = 0x82D7;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_STRIDE = 0x82D8;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIB_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int VERTEX_BINDING_BUFFER = 0x8F4F;

		/// <summary>
		/// Value of GL_DISPLAY_LIST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public const int DISPLAY_LIST = 0x82E7;

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glClearBufferData, which must must be one of the buffer 
		/// bindingtargets in the following table: 
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object. 
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferData and glClearNamedBufferData fill the entirety of a buffer object's data store with data from client 
		/// memory.
		/// Data, initially supplied in a format specified by format in data type type is read from the memory address given by data 
		/// andconverted into the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the buffer object's data store. If data is NULL, then the buffer's 
		/// datastore is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferData if no buffer is bound target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		public static void ClearBufferData(int target, int internalformat, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearBufferData != null, "pglClearBufferData not implemented");
			Delegates.pglClearBufferData(target, internalformat, format, type, data);
			CallLog("glClearBufferData({0}, {1}, {2}, {3}, {4})", target, internalformat, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glClearBufferData, which must must be one of the buffer 
		/// bindingtargets in the following table: 
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object. 
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferData and glClearNamedBufferData fill the entirety of a buffer object's data store with data from client 
		/// memory.
		/// Data, initially supplied in a format specified by format in data type type is read from the memory address given by data 
		/// andconverted into the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the buffer object's data store. If data is NULL, then the buffer's 
		/// datastore is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferData if no buffer is bound target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		public static void ClearBufferData(int target, int internalformat, int format, int type, Object data)
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
		/// Specifies the target to which the buffer object is bound for glClearBufferSubData, which must be one of the buffer 
		/// bindingtargets in the following table: 
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
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferSubData and glClearNamedBufferSubData fill a specified region of a buffer object's data store with data 
		/// fromclient memory. 
		/// offset and size specify the extent of the region within the data store of the buffer object to fill with data. Data, 
		/// initiallysupplied in a format specified by format in data type type is read from the memory address given by data and 
		/// convertedinto the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the specified region of the buffer object's data store. If data is 
		/// NULL,then the subrange of the buffer's data store is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferSubData if no buffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_VALUE is generated if offset or range are not multiples of the number of basic machine units per-element for 
		///   theinternal format specified by internalformat. This value may be computed by multiplying the number of components for 
		///   internalformatfrom the table by the size of the base type from the table. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferData"/>
		public static void ClearBufferSubData(int target, int internalformat, IntPtr offset, UInt32 size, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearBufferSubData != null, "pglClearBufferSubData not implemented");
			Delegates.pglClearBufferSubData(target, internalformat, offset, size, format, type, data);
			CallLog("glClearBufferSubData({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, offset, size, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glClearBufferSubData, which must be one of the buffer 
		/// bindingtargets in the following table: 
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
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferSubData and glClearNamedBufferSubData fill a specified region of a buffer object's data store with data 
		/// fromclient memory. 
		/// offset and size specify the extent of the region within the data store of the buffer object to fill with data. Data, 
		/// initiallysupplied in a format specified by format in data type type is read from the memory address given by data and 
		/// convertedinto the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the specified region of the buffer object's data store. If data is 
		/// NULL,then the subrange of the buffer's data store is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferSubData if no buffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_VALUE is generated if offset or range are not multiples of the number of basic machine units per-element for 
		///   theinternal format specified by internalformat. This value may be computed by multiplying the number of components for 
		///   internalformatfrom the table by the size of the base type from the table. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferData"/>
		public static void ClearBufferSubData(int target, int internalformat, IntPtr offset, UInt32 size, int format, int type, Object data)
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
		/// glDispatchCompute launches one or more compute work groups. Each work group is processed by the active program object 
		/// forthe compute shader stage. While the individual shader invocations within a work group are executed as a unit, work 
		/// groupsare executed completely independently and in unspecified order. num_groups_x, num_groups_y and num_groups_z 
		/// specifythe number of local work groups that will be dispatched in the X, Y and Z dimensions, respectively. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no active program for the compute shader stage. 
		/// - GL_INVALID_VALUE is generated if any of num_groups_x, num_groups_y, or num_groups_z is greater than or equal to the 
		///   maximumwork-group count for the corresponding dimension. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COMPUTE_WORK_GROUP_COUNT 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DispatchComputeIndirect"/>
		public static void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
		{
			Debug.Assert(Delegates.pglDispatchCompute != null, "pglDispatchCompute not implemented");
			Delegates.pglDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
			CallLog("glDispatchCompute({0}, {1}, {2})", num_groups_x, num_groups_y, num_groups_z);
			DebugCheckErrors();
		}

		/// <summary>
		/// launch one or more compute work groups using parameters stored in a buffer
		/// </summary>
		/// <param name="indirect">
		/// The offset into the buffer object currently bound to the GL_DISPATCH_INDIRECT_BUFFER buffer target at which the dispatch 
		/// parametersare stored. 
		/// </param>
		/// <remarks>
		/// glDispatchComputeIndirect launches one or more compute work groups using parameters stored in the buffer object 
		/// currentlybound to the GL_DISPATCH_INDIRECT_BUFFER target. Each work group is processed by the active program object for 
		/// thecompute shader stage. While the individual shader invocations within a work group are executed as a unit, work groups 
		/// areexecuted completely independently and in unspecified order. indirect contains the offset into the data store of the 
		/// bufferobject bound to the GL_DISPATCH_INDIRECT_BUFFER target at which the parameters are stored. 
		/// The parameters addressed by indirect are packed a structure, which takes the form (in C): typedef struct { uint 
		/// num_groups_x;uint num_groups_y; uint num_groups_z; } DispatchIndirectCommand; 
		/// A call to glDispatchComputeIndirect is equivalent, assuming no errors are generated, to: cmd = (const 
		/// DispatchIndirectCommand*)indirect; glDispatchComputeIndirect(cmd-&gt;num_groups_x, cmd-&gt;num_groups_y, 
		/// cmd-&gt;num_groups_z);
		/// Unlike glDispatchCompute, no error is generated if any of the num_groups_x, num_groups_y or num_groups_z members of the 
		/// DispatchIndirectCommandis larger than the value of GL_MAX_COMPUTE_WORK_GROUP_COUNT for the corresponding dimension. In 
		/// suchcircumstances, behavior is undefined and may lead to application termination. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no active program for the compute shader stage. 
		/// - GL_INVALID_VALUE is generated if indirect is less than zero or not a multiple of four. 
		/// - GL_INVALID_OPERATION is generated if no buffer is bound to the GL_DISPATCH_INDIRECT_BUFFER target or if the command 
		///   wouldsource data beyond the end of the buffer object's data store. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COMPUTE_WORK_GROUP_COUNT 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DispatchCompute"/>
		public static void DispatchComputeIndirect(IntPtr indirect)
		{
			Debug.Assert(Delegates.pglDispatchComputeIndirect != null, "pglDispatchComputeIndirect not implemented");
			Delegates.pglDispatchComputeIndirect(indirect);
			CallLog("glDispatchComputeIndirect({0})", indirect);
			DebugCheckErrors();
		}

		/// <summary>
		/// perform a raw data copy between two images
		/// </summary>
		/// <param name="srcName">
		/// The name of a texture or renderbuffer object from which to copy. 
		/// </param>
		/// <param name="srcTarget">
		/// The target representing the namespace of the source name srcName. 
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
		/// The target representing the namespace of the destination name dstName. 
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
		/// glCopyImageSubData may be used to copy data from one image (i.e. texture or renderbuffer) to another. glCopyImageSubData 
		/// doesnot perform general-purpose conversions such as scaling, resizing, blending, color-space, or format conversions. It 
		/// shouldbe considered to operate in a manner similar to a CPU memcpy. CopyImageSubData can copy between images with 
		/// differentinternal formats, provided the formats are compatible. 
		/// glCopyImageSubData also allows copying between certain types of compressed and uncompressed internal formats. This copy 
		/// doesnot perform on-the-fly compression or decompression. When copying from an uncompressed internal format to a 
		/// compressedinternal format, each texel of uncompressed data becomes a single block of compressed data. When copying from 
		/// acompressed internal format to an uncompressed internal format, a block of compressed data becomes a single texel of 
		/// uncompresseddata. The texel size of the uncompressed format must be the same size the block size of the compressed 
		/// formats.Thus it is permitted to copy between a 128-bit uncompressed format and a compressed format which uses 8-bit 4x4 
		/// blocks,or between a 64-bit uncompressed format and a compressed format which uses 4-bit 4x4 blocks. 
		/// The source object is identified by srcName and srcTarget and the destination object is identified by dstName and 
		/// dstTarget.The interpretation of the name depends on the value of the corresponding target parameter. If target is 
		/// GL_RENDERBUFFER,the name is interpreted as the name of a renderbuffer object. If the target parameter is a texture 
		/// target,the name is interpreted as a texture object. All non-proxy texture targets are accepted, with the exception of 
		/// GL_TEXTURE_BUFFERand the cubemap face selectors. 
		/// srcLevel and dstLevel identify the source and destination level of detail. For textures, this must be a valid level of 
		/// detailin the texture object. For renderbuffers, this value must be zero. 
		/// srcX, srcY, and srcZ specify the lower left texel coordinates of a srcWidth-wide by srcHeight-high by srcDepth-deep 
		/// rectangularsubregion of the source texel array. Similarly, dstX, dstY and dstZ specify the coordinates of a subregion of 
		/// thedestination texel array. The source and destination subregions must be contained entirely within the specified level 
		/// ofthe corresponding image objects. 
		/// The dimensions are always specified in texels, even for compressed texture formats. However, it should be noted that if 
		/// onlyone of the source and destination textures is compressed then the number of texels touched in the compressed image 
		/// willbe a factor of the block size larger than in the uncompressed image. 
		/// Slices of a GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP_ARRAYGL_TEXTURE_3D and faces of 
		/// GL_TEXTURE_CUBE_MAPare all compatible provided they share a compatible internal format, and multiple slices or faces may 
		/// becopied between these objects with a single call by specifying the starting slice with srcZ and dstZ, and the number of 
		/// slicesto be copied with srcDepth. Cubemap textures always have six faces which are selected by a zero-based face index. 
		/// For the purposes of CopyImageSubData, two internal formats are considered compatible if any of the following conditions 
		/// aremet: the formats are the same, the formats are considered compatible according to the compatibility rules used for 
		/// textureviews as defined in section 3.9.X. In particular, if both internal formats are listed in the same entry of Table 
		/// 3.X.2,they are considered compatible, or one format is compressed and the other is uncompressed and Table 4.X.1 lists 
		/// thetwo formats in the same row. If the formats are not compatible, an INVALID_OPERATION error is generated. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if the texel size of the uncompressed image is not equal to the block size of the 
		///   compressedimage. 
		/// - GL_INVALID_ENUM is generated if either target parameter is not GL_RENDERBUFFER, a valid non-proxy texture target other 
		///   thanGL_TEXTURE_BUFFER, or is one of the cubemap face selectors. 
		/// - GL_INVALID_ENUM is generated if target does not match the type of the object. 
		/// - GL_INVALID_OPERATION is generated if either object is a texture and the texture is not complete. 
		/// - GL_INVALID_OPERATION is generated if the source and destination internal formats are not compatible, or if the number of 
		///   samplesdo not match. 
		/// - GL_INVALID_VALUE is generated if either name does not correspond to a valid renderbuffer or texture object according to 
		///   thecorresponding target parameter. 
		/// - GL_INVALID_VALUE is generated if the specified level of either the source or destination is not a valid level for the 
		///   correspondingimage. 
		/// - GL_INVALID_VALUE is generated if the dimensions of the either subregion exceeds the boundaries of the corresponding 
		///   imageobject, or if the image format is compressed and the dimensions of the subregion fail to meet the alignment 
		///   constraintsof the format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COMPUTE_WORK_GROUP_COUNT 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DispatchComputeIndirect"/>
		public static void CopyImageSubData(UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			if        (Delegates.pglCopyImageSubData != null) {
				Delegates.pglCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
				CallLog("glCopyImageSubData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			} else if (Delegates.pglCopyImageSubDataEXT != null) {
				Delegates.pglCopyImageSubDataEXT(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
				CallLog("glCopyImageSubDataEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			} else if (Delegates.pglCopyImageSubDataOES != null) {
				Delegates.pglCopyImageSubDataOES(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
				CallLog("glCopyImageSubDataOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			} else
				throw new NotImplementedException("glCopyImageSubData (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set a named parameter of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for glFramebufferParameteri. 
		/// </param>
		/// <param name="pname">
		/// Specifies the framebuffer parameter to be modified. 
		/// </param>
		/// <param name="param">
		/// The new value for the parameter named pname. 
		/// </param>
		/// <remarks>
		/// glFramebufferParameteri and glNamedFramebufferParameteri modify the value of the parameter named pname in the specified 
		/// framebufferobject. There are no modifiable parameters of the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For glFramebufferParameteri, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferParameteri, framebuffer is the name of the framebuffer object. 
		/// pname specifies the parameter to be modified. The following values are accepted: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferParameteri if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferParameteri if the default framebuffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferParameteri if framebuffer is not the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_WIDTH and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_WIDTH. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_HEIGHT and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_HEIGHT. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_LAYERS and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_LAYERS. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_SAMPLES and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_SAMPLES. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetFramebufferParameteriv. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CreateFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		public static void FramebufferParameter(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFramebufferParameteri != null, "pglFramebufferParameteri not implemented");
			Delegates.pglFramebufferParameteri(target, pname, param);
			CallLog("glFramebufferParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// query a named parameter of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is bound for glGetFramebufferParameteriv. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the framebuffer object to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetFramebufferParameteriv and glGetNamedFramebufferParameteriv query parameters of a specified framebuffer object. 
		/// For glGetFramebufferParameteriv, the framebuffer object is that bound to target, which must be one of 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default 
		/// framebuffersmay also be queried if bound to target. 
		/// For glGetNamedFramebufferParameteriv, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is queried. 
		/// Upon successful return, param will contain the value of the framebuffer parameter specified by pname, as described 
		/// below.
		/// The following parameters can only be queried for framebuffer objects: 
		/// The following parameters can be queried for both default framebuffers and framebuffer objects: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetFramebufferParameteriv if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedFramebufferAttachmentParameteriv if framebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted parameter names. 
		/// - GL_INVALID_OPERATION is generated if a default framebuffer is queried, and pname is not one of GL_DOUBLEBUFFER, 
		///   GL_IMPLEMENTATION_COLOR_READ_FORMAT,GL_IMPLEMENTATION_COLOR_READ_TYPE, GL_SAMPLES, GL_SAMPLE_BUFFERS or GL_STEREO. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetFramebufferAttachmentParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FramebufferParameteri"/>
		/// <seealso cref="Gl.GetFramebufferAttachmentParameter"/>
		public static void GetFramebufferParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
					Delegates.pglGetFramebufferParameteriv(target, pname, p_params);
					CallLog("glGetFramebufferParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about implementation-dependent support for internal formats
		/// </summary>
		/// <param name="target">
		/// Indicates the usage of the internal format. target must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_RECTANGLE, 
		/// GL_TEXTURE_BUFFER,GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format about which to retrieve information. 
		/// </param>
		/// <param name="pname">
		/// Specifies the type of information to query. 
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of basic machine units that may be written to params by the function. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <remarks>
		/// glGetInternalformativ and glGetInternalformati64v retrieve information about implementation-dependent support for 
		/// internalformats. target indicates the target with which the internal format will be used and must be one of 
		/// GL_RENDERBUFFER,GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, corresponding to usage as a renderbuffer, 
		/// two-dimensionalmultisample texture or two-dimensional multisample array texture, respectively. 
		/// internalformat specifies the internal format about which to retrieve information and must be a color-renderable, 
		/// depth-renderableor stencil-renderable format. 
		/// The information retrieved will be written to memory addressed by the pointer specified in params. No more than bufSize 
		/// basicmachine units will be written to this memory. 
		/// If pname is GL_NUM_SAMPLE_COUNTS, the number of sample counts that would be returned by querying GL_SAMPLES will be 
		/// returnedin params. 
		/// If pname is GL_SAMPLES, the sample counts supported for internalformat and target are written into params in descending 
		/// numericorder. Only positive values are returned. Querying GL_SAMPLES with bufSize of one will return just the maximum 
		/// supportednumber of samples for this format. The maximum value in GL_SAMPLES is guaranteed to be at least the lowest of 
		/// thefollowing: The value of GL_MAX_INTEGER_SAMPLES if internalformat is a signed or unsigned integer format. The value of 
		/// GL_MAX_DEPTH_TEXTURE_SAMPLESif internalformat is a depth- or stencil-renderable format and target is 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY. The value of GL_MAX_COLOR_TEXTURE_SAMPLES if internalformat 
		/// isa color-renderable format and target is GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. The value of 
		/// GL_MAX_SAMPLES.
		/// If pname is GL_INTERNALFORMAT_SUPPORTED, params is set to GL_TRUE if internalFormat is a supported internal format for 
		/// targetand to GL_FALSE otherwise. 
		/// If pname is GL_INTERNALFORMAT_PREFERRED, params is set to GL_TRUE if internalFormat is an format for target that is 
		/// preferredby the implementation and to GL_FALSE otherwise. 
		/// If pname is GL_INTERNALFORMAT_RED_SIZE, GL_INTERNALFORMAT_GREEN_SIZE, GL_INTERNALFORMAT_BLUE_SIZE, 
		/// GL_INTERNALFORMAT_ALPHA_SIZE,GL_INTERNALFORMAT_DEPTH_SIZE, GL_INTERNALFORMAT_STENCIL_SIZE, or 
		/// GL_INTERNALFORMAT_SHARED_SIZEthen params is set to the actual resolutions that would be used for storing image array 
		/// componentsfor the resource for the red, green, blue, alpha, depth, stencil and shared channels respectively. If 
		/// internalFormatis a compressed internal format, then params is set to the component resolution of an uncompressed 
		/// internalformat that produces an image of roughly the same quality as the compressed algorithm. If the internal format is 
		/// unsupported,or if a particular component is not present in the format, 0 is written to params. 
		/// If pname is GL_INTERNALFORMAT_RED_TYPE, GL_INTERNALFORMAT_GREEN_TYPE, GL_INTERNALFORMAT_BLUE_TYPE, 
		/// GL_INTERNALFORMAT_ALPHA_TYPE,GL_INTERNALFORMAT_DEPTH_TYPE, or GL_INTERNALFORMAT_STENCIL_TYPE then params is set to a 
		/// tokenidentifying the data type used to store the respective component. If the internalFormat represents a compressed 
		/// internalformat then the types returned specify how components are interpreted after decompression. 
		/// If pname is GL_MAX_WIDTH, GL_MAX_HEIGHT, GL_MAX_DEPTH, or GL_MAX_LAYERS then pname is filled with the maximum width, 
		/// height,depth or layer count for textures with internal format internalFormat, respectively. If pname is 
		/// GL_MAX_COMBINED_DIMENSIONSthen pname is filled with the maximum combined dimensions of a texture of the specified 
		/// internalformat. 
		/// If pname is GL_COLOR_COMPONENTS then params is set to the value GL_TRUE if the internal format contains any color 
		/// component(i.e., red, green, blue or alpha) and to GL_FALSE otherwise. If pname is GL_DEPTH_COMPONENTS or 
		/// GL_STENCIL_COMPONENTSthen params is set to GL_TRUE if the internal format contains a depth or stencil component, 
		/// respectively,and to GL_FALSE otherwise. 
		/// If pname is GL_COLOR_RENDERABLE, GL_DEPTH_RENDERABLE or GL_STENCIL_RENDERABLE then params is set to GL_TRUE if the 
		/// specifiedinternal format is color, depth or stencil renderable, respectively, and to GL_FALSE otherwise. 
		/// If pname is GL_FRAMEBUFFER_RENDERABLE or GL_FRAMEBUFFER_RENDERABLE_LAYERED then params is set to one of GL_FULL_SUPPORT, 
		/// GL_CAVEAT_SUPPORTor GL_NONE to indicate that framebuffer attachments (layered attachments in the case of 
		/// GL_FRAMEBUFFER_RENDERABLE_LAYERED)with that internal format are either renderable with no restrictions, renderable with 
		/// somerestrictions or not renderable at all. 
		/// If pname is GL_FRAMEBUFFER_BLEND, params is set to GL_TRUE to indicate that the internal format is supported for 
		/// blendingoperations when attached to a framebuffer, and to GL_FALSE otherwise. 
		/// If pname is GL_READ_PIXELS then params is set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to that either full 
		/// support,limited support or no support at all is supplied for reading pixels from framebuffer attachments in the 
		/// specifiedinternal format. 
		/// If pname is GL_READ_PIXELS_FORMAT or GL_READ_PIXELS_TYPE then params is filled with the format or type, respectively, 
		/// mostrecommended to obtain the highest image quality and performance. For GL_READ_PIXELS_FORMAT, the value returned in 
		/// paramsis a token that is accepted for the format argument to glReadPixels. For GL_READ_PIXELS_TYPE, the value returned 
		/// inparams is a token that is accepted for the type argument to glReadPixels. 
		/// If pname is GL_TEXTURE_IMAGE_FORMAT or GL_TEXTURE_IMAGE_TYPE then params is filled with the implementation-recommended 
		/// formator type to be used in calls to glTexImage2D and other similar functions. For GL_TEXTURE_IMAGE_FORMAT, params is 
		/// filledwith a token suitable for use as the format argument to glTexImage2D. For GL_TEXTURE_IMAGE_TYPE, params is filled 
		/// witha token suitable for use as the type argument to glTexImage2D. 
		/// If pname is GL_GET_TEXTURE_IMAGE_FORMAT or GL_GET_TEXTURE_IMAGE_TYPE then params is filled with the 
		/// implementation-recommendedformat or type to be used in calls to glGetTexImage2D and other similar functions. For 
		/// GL_GET_TEXTURE_IMAGE_FORMAT,params is filled with a token suitable for use as the format argument to glGetTexImage2D. 
		/// ForGL_GET_TEXTURE_IMAGE_TYPE, params is filled with a token suitable for use as the type argument to glGetTexImage2D. 
		/// If pname is GL_MIPMAP then pname is set to GL_TRUE to indicate that the specified internal format supports mipmaps and 
		/// toGL_FALSE otherwise. 
		/// If pname is GL_GENERATE_MIPMAP or GL_AUTO_GENERATE_MIPMAP then params is indicates the level of support for manual or 
		/// automaticmipmap generation for the specified internal format, respectively. Returned values may be one of 
		/// GL_FULL_SUPPORT,GL_CAVEAT_SUPPORT and GL_NONE to indicate either full support, limited support or no support at all. 
		/// If pname is GL_COLOR_ENCODING then the color encoding for the resource is returned in params. Possible values for color 
		/// buffersare GL_LINEAR or GL_SRGB, for linear or sRGB-encoded color components, respectively. For non-color formats (such 
		/// asdepth or stencil), or for unsupported resources, the value GL_NONE is returned. 
		/// If pname is GL_SRGB_READ, or GL_SRGB_WRITE then params indicates the level of support for reading and writing to sRGB 
		/// encodedimages, respectively. For GL_SRGB_READ, support for converting from sRGB colorspace on read operations is 
		/// returnedin params and for GL_SRGB_WRITE, support for converting to sRGB colorspace on write operations to the resource 
		/// isreturned in params. params may be set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, 
		/// limitedsupport or no support at all, respecitively. 
		/// If pname is GL_FILTER the params is set to either GL_TRUE or GL_FALSE to indicate support or lack thereof for filter 
		/// modesother than GL_NEAREST or GL_NEAREST_MIPMAP for the specified internal format. 
		/// If pname is GL_VERTEX_TEXTURE, GL_TESS_CONTROL_TEXTURE, GL_TESS_EVALUATION_TEXTURE, GL_GEOMETRY_TEXTURE, 
		/// GL_FRAGMENT_TEXTURE,or GL_COMPUTE_TEXTURE, then the value written to params indicates support for use of the resource as 
		/// asource of texturing in the vertex, tessellation control, tessellation evaluation, geometry, fragment and compute shader 
		/// stages,respectively. params may be set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full support, 
		/// limitedsupport or no support at all, respectively. 
		/// If pname is GL_TEXTURE_SHADOW, GL_TEXTURE_GATHER or GL_TEXTURE_GATHER_SHADOW then the value written to params indicates 
		/// thelevel of support for using the resource with a shadow sampler, in gather operations or as a shadow sampler in gather 
		/// operations,respectively. Returned values may be GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full support, 
		/// limitedsupport or no support at all, respectively. 
		/// If pname is GL_SHADER_IMAGE_LOAD, GL_SHADER_IMAGE_STORE or GL_SHADER_IMAGE_ATOMIC then the value returned in params 
		/// indicatesthe level of support for image loads, stores and atomics for resources of the specified internal format. 
		/// Returnedvalues may be GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full support, limited support or no 
		/// supportat all, respectively. 
		/// If pname is GL_IMAGE_TEXEL_SIZE then the size of a texel when the resource when used as an image texture is returned in 
		/// params.If the resource is not supported for image textures zero is returned. 
		/// If pname is GL_IMAGE_COMPATIBILITY_CLASS then the compatibility class of the resource when used as an image texture is 
		/// returnedin params. The possible values returned are GL_IMAGE_CLASS_4_X_32, GL_IMAGE_CLASS_2_X_32, GL_IMAGE_CLASS_1_X_32, 
		/// GL_IMAGE_CLASS_4_X_16,GL_IMAGE_CLASS_2_X_16, GL_IMAGE_CLASS_1_X_16, GL_IMAGE_CLASS_4_X_8, GL_IMAGE_CLASS_2_X_8, 
		/// GL_IMAGE_CLASS_1_X_8,GL_IMAGE_CLASS_11_11_10, and GL_IMAGE_CLASS_10_10_10_2, which correspond to the 4x32, 2x32, 1x32, 
		/// 4x16,2x16, 1x16, 4x8, 2x8, 1x8, the class (a) 11/11/10 packed floating-point format, and the class (b) 10/10/10/2 packed 
		/// formats,respectively. If the resource is not supported for image textures, GL_NONE is returned. 
		/// If pname is GL_IMAGE_PIXEL_FORMAT or GL_IMAGE_PIXEL_TYPE then the pixel format or type of the resource when used as an 
		/// imagetexture is returned in params, respectively. In either case, the resource is not supported for image textures 
		/// GL_NONEis returned. 
		/// If pname is GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, the matching criteria use for the resource when used as an image 
		/// texturesis returned in params. Possible values returned in params are GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE or 
		/// GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS.If the resource is not supported for image textures, GL_NONE is returned. 
		/// If pname is GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST or GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST, support for using the 
		/// resourceboth as a source for texture sampling while it is bound as a buffer for depth or stencil test, respectively, is 
		/// writtento params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, 
		/// limitedsupport or no support at all. If the resource or operation is not supported, GL_NONE is returned. 
		/// If pname is GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE or GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE, support for using the 
		/// resourceboth as a source for texture sampling while performing depth or stencil writes to the resources, respectively, 
		/// iswritten to params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full 
		/// support,limited support or no support at all. If the resource or operation is not supported, GL_NONE is returned. 
		/// If pname is GL_TEXTURE_COMPRESSED then GL_TRUE is returned in params if internalformat is a compressed internal format. 
		/// GL_FALSEis returned in params otherwise. 
		/// If pname is GL_TEXTURE_COMPRESSED_BLOCK_WIDTH, GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT or GL_TEXTURE_COMPRESSED_BLOCK_SIZE 
		/// thenthe width, height or total size, respectively of a block (in basic machine units) is returned in params. If the 
		/// internalformat is not compressed, or the resource is not supported, 0 is returned. 
		/// If pname is GL_CLEAR_BUFFER, the level of support for using the resource with glClearBufferData and glClearBufferSubData 
		/// isreturned in params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full 
		/// support,limited support or no support at all, respectively. If the resource or operation is not supported, GL_NONE is 
		/// returned.
		/// If pname is GL_TEXTURE_VIEW, the level of support for using the resource with the glTextureView command is returned in 
		/// params.Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, limited 
		/// supportor no support at all, respectively. If the resource or operation is not supported, GL_NONE is returned. 
		/// If pname is GL_VIEW_COMPATIBILITY_CLASS then the compatibility class of the resource when used as a texture view is 
		/// returnedin params. The possible values returned are GL_VIEW_CLASS_128_BITS, GL_VIEW_CLASS_96_BITS, 
		/// GL_VIEW_CLASS_64_BITS,GL_VIEW_CLASS_48_BITS, GL_VIEW_CLASS_32_BITS, GL_VIEW_CLASS_24_BITS, GL_VIEW_CLASS_16_BITS, 
		/// GL_VIEW_CLASS_8_BITS,GL_VIEW_CLASS_S3TC_DXT1_RGB, GL_VIEW_CLASS_S3TC_DXT1_RGBA, GL_VIEW_CLASS_S3TC_DXT3_RGBA, 
		/// GL_VIEW_CLASS_S3TC_DXT5_RGBA,GL_VIEW_CLASS_RGTC1_RED, GL_VIEW_CLASS_RGTC2_RG, GL_VIEW_CLASS_BPTC_UNORM, and 
		/// GL_VIEW_CLASS_BPTC_FLOAT.
		/// If pname is GL_CLEAR_TEXTURE then the presence of support for using the glClearTexImage and glClearTexSubImage commands 
		/// withthe resource is written to params. Possible values written are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to 
		/// indicatefull support, limited support or no support at all, respectively. If the resource or operation is not supported, 
		/// GL_NONEis returned. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if bufSize is negative. 
		/// - GL_INVALID_ENUM is generated if pname is not GL_SAMPLES or GL_NUM_SAMPLE_COUNTS. 
		/// - GL_INVALID_ENUM is generated if internalformat is not color-, depth-, or stencil-renderable. 
		/// - GL_INVALID_ENUM is generated if target is not one of GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY or 
		///   GL_RENDERBUFFER.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Get"/>
		public static void GetInternalformat(int target, int internalformat, int pname, Int32 bufSize, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformati64v != null, "pglGetInternalformati64v not implemented");
					Delegates.pglGetInternalformati64v(target, internalformat, pname, bufSize, p_params);
					CallLog("glGetInternalformati64v({0}, {1}, {2}, {3}, {4})", target, internalformat, pname, bufSize, @params);
				}
			}
			DebugCheckErrors();
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
		/// glInvalidateTexSubImage invalidates all or part of a texture image. texture and level indicated which texture image is 
		/// beinginvalidated. After this command, data in that subregion have undefined values. xoffset, yoffset, zoffset, width, 
		/// height,and depth are interpreted as they are in glTexSubImage3D. For texture targets that don't have certain dimensions, 
		/// thiscommand treats those dimensions as having a size of 1. For example, to invalidate a portion of a two- dimensional 
		/// texture,the application would use zoffset equal to zero and depth equal to one. Cube map textures are treated as an 
		/// arrayof six slices in the z-dimension, where a value of zoffset is interpreted as specifying face 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X+ zoffset. 
		/// level must be greater than or equal to zero and be less than the base 2 logarithm of the maximum texture width, height, 
		/// ordepth. xoffset, yoffset and zoffset must be greater than or equal to zero and be less than the width, height or depth 
		/// ofthe image, respectively. Furthermore, xoffset + width, yoffset + height, and zoffset + depth must be less than or 
		/// equalto the width, height or depth of the image, respectively. 
		/// For textures of targets GL_TEXTURE_RECTANGLE, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAY,level must be zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if xoffset, yoffset or zoffset is less than zero, or if any of them is greater than the 
		///   sizeof the image in the corresponding dimension. 
		/// - GL_INVALID_VALUE is generated if level is less than zero or if it is greater or equal to the base 2 logarithm of the 
		///   maximumtexture width, height, or depth. 
		/// - GL_INVALID_VALUE is generated if the target of texture is any of GL_TEXTURE_RECTANGLE, GL_TEXTURE_BUFFER, 
		///   GL_TEXTURE_2D_MULTISAMPLE,or GL_TEXTURE_2D_MULTISAMPLE_ARRAY and level is not zero. 
		/// - GL_INVALID_VALUE is generated if texture is not the name of an existing texture object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_TEXTURE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglInvalidateTexSubImage != null, "pglInvalidateTexSubImage not implemented");
			Delegates.pglInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
			CallLog("glInvalidateTexSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, level, xoffset, yoffset, zoffset, width, height, depth);
			DebugCheckErrors();
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
		/// glInvalidateTexSubImage invalidates all of a texture image. texture and level indicated which texture image is being 
		/// invalidated.After this command, data in the texture image has undefined values. 
		/// level must be greater than or equal to zero and be less than the base 2 logarithm of the maximum texture width, height, 
		/// ordepth. 
		/// For textures of targets GL_TEXTURE_RECTANGLE, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAY,level must be zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if level is less than zero or if it is greater or equal to the base 2 logarithm of the 
		///   maximumtexture width, height, or depth. 
		/// - GL_INVALID_VALUE is generated if the target of texture is any of GL_TEXTURE_RECTANGLE, GL_TEXTURE_BUFFER, 
		///   GL_TEXTURE_2D_MULTISAMPLE,or GL_TEXTURE_2D_MULTISAMPLE_ARRAY and level is not zero. 
		/// - GL_INVALID_VALUE is generated if texture is not the name of an existing texture object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_TEXTURE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateTexImage(UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglInvalidateTexImage != null, "pglInvalidateTexImage not implemented");
			Delegates.pglInvalidateTexImage(texture, level);
			CallLog("glInvalidateTexImage({0}, {1})", texture, level);
			DebugCheckErrors();
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
		/// glInvalidateBufferSubData invalidates all or part of the content of the data store of a buffer object. After 
		/// invalidation,the content of the specified range of the buffer's data store becomes undefined. The start of the range is 
		/// givenby offset and its size is given by length, both measured in basic machine units. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if offset or length is negative, or if offset + length is greater than the value of 
		///   GL_BUFFER_SIZEfor buffer. 
		/// - GL_INVALID_VALUE is generated if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of buffer is currently mapped. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglInvalidateBufferSubData != null, "pglInvalidateBufferSubData not implemented");
			Delegates.pglInvalidateBufferSubData(buffer, offset, length);
			CallLog("glInvalidateBufferSubData({0}, {1}, {2})", buffer, offset, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// invalidate the content of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// The name of a buffer object whose data store to invalidate. 
		/// </param>
		/// <remarks>
		/// glInvalidateBufferData invalidates all of the content of the data store of a buffer object. After invalidation, the 
		/// contentof the buffer's data store becomes undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of buffer is currently mapped. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateBufferData(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglInvalidateBufferData != null, "pglInvalidateBufferData not implemented");
			Delegates.pglInvalidateBufferData(buffer);
			CallLog("glInvalidateBufferData({0})", buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// invalidate the content of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is attached for glInvalidateFramebuffer. 
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the attachments array. 
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated. 
		/// </param>
		/// <remarks>
		/// glInvalidateFramebuffer and glInvalidateNamedFramebufferData invalidate the entire contents of a specified set of 
		/// attachmentsof a framebuffer. 
		/// For glInvalidateFramebuffer, the framebuffer object is that bound to target. target must be GL_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_DRAW_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default framebuffers may 
		/// alsobe invalidated if bound to target. 
		/// For glInvalidateNamedFramebufferData, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is affected. 
		/// The set of attachments whose contents are to be invalidated are specified in the attachments array, which contains 
		/// numAttachmentselements. 
		/// If the specified framebuffer is a framebuffer object, each element of attachments must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_FRAMEBUFFER_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, each element of attachments must be one of GL_FRONT_LEFT, 
		/// GL_FRONT_RIGHT,GL_BACK_LEFT, GL_BACK_RIGHT, GL_AUXi, GL_ACCUM, GL_COLOR, GL_DEPTH, or GL_STENCIL. GL_COLOR, is treated 
		/// asGL_BACK_LEFT for a double-buffered context and GL_FRONT_LEFT for a single-buffered context. The other attachments 
		/// identifythe corresponding specific buffer. 
		/// The entire contents of each specified attachment become undefined after execution of glInvalidateFramebuffer or 
		/// glInvalidateNamedFramebufferData.
		/// If the framebuffer object is not complete, glInvalidateFramebuffer and glInvalidateNamedFramebufferData may be ignored. 
		/// Thisis not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glInvalidateFramebuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glInvalidateNamedFramebufferData if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_VALUE is generated if numAttachments is negative. 
		/// - GL_INVALID_ENUM is generated if any element of attachments is not one of the accepted framebuffer attachment points, as 
		///   describedabove. 
		/// - GL_INVALID_OPERATION is generated if element of attachments is GL_COLOR_ATTACHMENTm where m is greater than or equal to 
		///   thevalue of GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COLOR_ATTACHMENTS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateFramebuffer(int target, Int32 numAttachments, int[] attachments)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateFramebuffer != null, "pglInvalidateFramebuffer not implemented");
					Delegates.pglInvalidateFramebuffer(target, numAttachments, p_attachments);
					CallLog("glInvalidateFramebuffer({0}, {1}, {2})", target, numAttachments, attachments);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// invalidate the content of a region of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is attached for glInvalidateSubFramebuffer. 
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the attachments array. 
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
		/// glInvalidateSubFramebuffer and glInvalidateNamedFramebufferSubData invalidate the contents of a specified region of a 
		/// specifiedset of attachments of a framebuffer. 
		/// For glInvalidateSubFramebuffer, the framebuffer object is that bound to target, which must be one of GL_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_DRAW_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default framebuffers may 
		/// alsobe invalidated if bound to target. 
		/// For glInvalidateNamedFramebufferSubData, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is affected. 
		/// The set of attachments of which a region is to be invalidated are specified in the attachments array, which contains 
		/// numAttachmentselements. 
		/// If the specified framebuffer is a framebuffer object, each element of attachments must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_FRAMEBUFFER_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, each element of attachments must be one of GL_FRONT_LEFT, 
		/// GL_FRONT_RIGHT,GL_BACK_LEFT, GL_BACK_RIGHT, GL_AUXi, GL_ACCUM, GL_COLOR, GL_DEPTH, or GL_STENCIL. GL_COLOR, is treated 
		/// asGL_BACK_LEFT for a double-buffered context and GL_FRONT_LEFT for a single-buffered context. The other attachments 
		/// identifythe corresponding specific buffer. 
		/// The contents of the specified region of each specified attachment become undefined after execution of 
		/// glInvalidateSubFramebufferor glInvalidateNamedFramebufferSubData. The region to be invalidated is specified by x, y, 
		/// widthand height where x and y give the offset from the origin (with lower-left corner at $(0,0)$) and width and height 
		/// arethe width and height, respectively, of the region. Any pixels lying outside of the window allocated to the current GL 
		/// context(for the default framebuffer), or outside of the attachments of the framebuffer object, are ignored. If the 
		/// framebufferobject is not complete, these commands may be ignored. 
		/// If the framebuffer object is not complete, glInvalidateSubFramebuffer and glInvalidateNamedFramebufferSubData may be 
		/// ignored.This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM by glInvalidateSubFramebuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION by glInvalidateNamedFramebufferSubData if framebuffer is not zero of the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_VALUE is generated if numAttachments, width or height is negative. 
		/// - GL_INVALID_ENUM is generated if any element of attachments is not one of the accepted framebuffer attachment points, as 
		///   describedabove. 
		/// - GL_INVALID_OPERATION is generated if element of attachments is GL_COLOR_ATTACHMENTm where m is greater than or equal to 
		///   thevalue of GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COLOR_ATTACHMENTS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		public static void InvalidateSubFramebuffer(int target, Int32 numAttachments, int[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateSubFramebuffer != null, "pglInvalidateSubFramebuffer not implemented");
					Delegates.pglInvalidateSubFramebuffer(target, numAttachments, p_attachments, x, y, width, height);
					CallLog("glInvalidateSubFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, numAttachments, attachments, x, y, width, height);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
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
		/// glMultiDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. 
		/// glMultiDrawArraysIndirectbehaves similarly to a multitude of calls to glDrawArraysInstancedBaseInstance, execept that 
		/// theparameters to each call to glDrawArraysInstancedBaseInstance are stored in an array in memory at the address given by 
		/// indirect,separated by the stride, in basic machine units, specified by stride. If stride is zero, then the array is 
		/// assumedto be tightly packed in memory. 
		/// The parameters addressed by indirect are packed into an array of structures, each element of which takes the form (in 
		/// C):typedef struct { uint count; uint instanceCount; uint first; uint baseInstance; } DrawArraysIndirectCommand; 
		/// A single call to glMultiDrawArraysIndirect is equivalent, assuming no errors are generated to: GLsizei n; for (n = 0; n 
		/// &lt;drawcount; n++) { const DrawArraysIndirectCommand *cmd; if (stride != 0) { cmd = (const DrawArraysIndirectCommand 
		/// *)((uintptr)indirect+ n * stride); } else { cmd = (const DrawArraysIndirectCommand *)indirect + n; } 
		/// glDrawArraysInstancedBaseInstance(mode,cmd-&gt;first, cmd-&gt;count, cmd-&gt;instanceCount, cmd-&gt;baseInstance); } 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glMultiDrawArraysIndirect, indirect 
		/// isinterpreted as an offset, in basic machine units, into that buffer and the parameter data is read from the buffer 
		/// ratherthan from client memory. 
		/// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and 
		/// out-of-rangeindices do not generate an error. 
		/// Vertex attributes that are modified by glMultiDrawArraysIndirect have an unspecified value after 
		/// glMultiDrawArraysIndirectreturns. Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if stride is not a multiple of four. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
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
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.MultiDrawElementsIndirect"/>
		public static void MultiDrawArraysIndirect(int mode, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			if        (Delegates.pglMultiDrawArraysIndirect != null) {
				Delegates.pglMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
				CallLog("glMultiDrawArraysIndirect({0}, {1}, {2}, {3})", mode, indirect, drawcount, stride);
			} else if (Delegates.pglMultiDrawArraysIndirectAMD != null) {
				Delegates.pglMultiDrawArraysIndirectAMD(mode, indirect, drawcount, stride);
				CallLog("glMultiDrawArraysIndirectAMD({0}, {1}, {2}, {3})", mode, indirect, drawcount, stride);
			} else if (Delegates.pglMultiDrawArraysIndirectEXT != null) {
				Delegates.pglMultiDrawArraysIndirectEXT(mode, indirect, drawcount, stride);
				CallLog("glMultiDrawArraysIndirectEXT({0}, {1}, {2}, {3})", mode, indirect, drawcount, stride);
			} else
				throw new NotImplementedException("glMultiDrawArraysIndirect (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
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
		/// glMultiDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. 
		/// glMultiDrawArraysIndirectbehaves similarly to a multitude of calls to glDrawArraysInstancedBaseInstance, execept that 
		/// theparameters to each call to glDrawArraysInstancedBaseInstance are stored in an array in memory at the address given by 
		/// indirect,separated by the stride, in basic machine units, specified by stride. If stride is zero, then the array is 
		/// assumedto be tightly packed in memory. 
		/// The parameters addressed by indirect are packed into an array of structures, each element of which takes the form (in 
		/// C):typedef struct { uint count; uint instanceCount; uint first; uint baseInstance; } DrawArraysIndirectCommand; 
		/// A single call to glMultiDrawArraysIndirect is equivalent, assuming no errors are generated to: GLsizei n; for (n = 0; n 
		/// &lt;drawcount; n++) { const DrawArraysIndirectCommand *cmd; if (stride != 0) { cmd = (const DrawArraysIndirectCommand 
		/// *)((uintptr)indirect+ n * stride); } else { cmd = (const DrawArraysIndirectCommand *)indirect + n; } 
		/// glDrawArraysInstancedBaseInstance(mode,cmd-&gt;first, cmd-&gt;count, cmd-&gt;instanceCount, cmd-&gt;baseInstance); } 
		/// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glMultiDrawArraysIndirect, indirect 
		/// isinterpreted as an offset, in basic machine units, into that buffer and the parameter data is read from the buffer 
		/// ratherthan from client memory. 
		/// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and 
		/// out-of-rangeindices do not generate an error. 
		/// Vertex attributes that are modified by glMultiDrawArraysIndirect have an unspecified value after 
		/// glMultiDrawArraysIndirectreturns. Attributes that aren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if stride is not a multiple of four. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
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
		/// <seealso cref="Gl.DrawArraysIndirect"/>
		/// <seealso cref="Gl.MultiDrawElementsIndirect"/>
		public static void MultiDrawArraysIndirect(int mode, Object indirect, Int32 drawcount, Int32 stride)
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
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding. 
		/// </param>
		/// <param name="indirect">
		/// Specifies the address of a structure containing an array of draw parameters. 
		/// </param>
		/// <param name="drawcount">
		/// Specifies the number of elements in the array addressed by indirect. 
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array. 
		/// </param>
		/// <remarks>
		/// glMultiDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. 
		/// glMultiDrawElementsIndirectbehaves similarly to a multitude of calls to glDrawElementsInstancedBaseVertexBaseInstance, 
		/// execptthat the parameters to glDrawElementsInstancedBaseVertexBaseInstance are stored in an array in memory at the 
		/// addressgiven by indirect, separated by the stride, in basic machine units, specified by stride. If stride is zero, then 
		/// thearray is assumed to be tightly packed in memory. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint instanceCount; uint firstIndex; uint baseVertex; uint baseInstance; } DrawElementsIndirectCommand; 
		/// A single call to glMultiDrawElementsIndirect is equivalent, assuming no errors are generated to: GLsizei n; for (n = 0; 
		/// n&lt; drawcount; n++) { const DrawElementsIndirectCommand *cmd; if (stride != 0) { cmd = (const 
		/// DrawElementsIndirectCommand*)((uintptr)indirect + n * stride); } else { cmd = (const DrawElementsIndirectCommand 
		/// *)indirect+ n; } glDrawElementsInstancedBaseVertexBaseInstance(mode, cmd-&gt;count, type, cmd-&gt;firstIndex + 
		/// size-of-type,cmd-&gt;instanceCount, cmd-&gt;baseVertex, cmd-&gt;baseInstance); } 
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
		/// - GL_INVALID_VALUE is generated if stride is not a multiple of four. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
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
		/// <seealso cref="Gl.DrawElementsIndirect"/>
		/// <seealso cref="Gl.MultiDrawArraysIndirect"/>
		public static void MultiDrawElementsIndirect(int mode, int type, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			if        (Delegates.pglMultiDrawElementsIndirect != null) {
				Delegates.pglMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
				CallLog("glMultiDrawElementsIndirect({0}, {1}, {2}, {3}, {4})", mode, type, indirect, drawcount, stride);
			} else if (Delegates.pglMultiDrawElementsIndirectEXT != null) {
				Delegates.pglMultiDrawElementsIndirectEXT(mode, type, indirect, drawcount, stride);
				CallLog("glMultiDrawElementsIndirectEXT({0}, {1}, {2}, {3}, {4})", mode, type, indirect, drawcount, stride);
			} else if (Delegates.pglMultiDrawElementsIndirectAMD != null) {
				Delegates.pglMultiDrawElementsIndirectAMD(mode, type, indirect, drawcount, stride);
				CallLog("glMultiDrawElementsIndirectAMD({0}, {1}, {2}, {3}, {4})", mode, type, indirect, drawcount, stride);
			} else
				throw new NotImplementedException("glMultiDrawElementsIndirect (and other aliases) are not implemented");
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
		/// Specifies the address of a structure containing an array of draw parameters. 
		/// </param>
		/// <param name="drawcount">
		/// Specifies the number of elements in the array addressed by indirect. 
		/// </param>
		/// <param name="stride">
		/// Specifies the distance in basic machine units between elements of the draw parameter array. 
		/// </param>
		/// <remarks>
		/// glMultiDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. 
		/// glMultiDrawElementsIndirectbehaves similarly to a multitude of calls to glDrawElementsInstancedBaseVertexBaseInstance, 
		/// execptthat the parameters to glDrawElementsInstancedBaseVertexBaseInstance are stored in an array in memory at the 
		/// addressgiven by indirect, separated by the stride, in basic machine units, specified by stride. If stride is zero, then 
		/// thearray is assumed to be tightly packed in memory. 
		/// The parameters addressed by indirect are packed into a structure that takes the form (in C): typedef struct { uint 
		/// count;uint instanceCount; uint firstIndex; uint baseVertex; uint baseInstance; } DrawElementsIndirectCommand; 
		/// A single call to glMultiDrawElementsIndirect is equivalent, assuming no errors are generated to: GLsizei n; for (n = 0; 
		/// n&lt; drawcount; n++) { const DrawElementsIndirectCommand *cmd; if (stride != 0) { cmd = (const 
		/// DrawElementsIndirectCommand*)((uintptr)indirect + n * stride); } else { cmd = (const DrawElementsIndirectCommand 
		/// *)indirect+ n; } glDrawElementsInstancedBaseVertexBaseInstance(mode, cmd-&gt;count, type, cmd-&gt;firstIndex + 
		/// size-of-type,cmd-&gt;instanceCount, cmd-&gt;baseVertex, cmd-&gt;baseInstance); } 
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
		/// - GL_INVALID_VALUE is generated if stride is not a multiple of four. 
		/// - GL_INVALID_VALUE is generated if drawcount is negative. 
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
		/// <seealso cref="Gl.DrawElementsIndirect"/>
		/// <seealso cref="Gl.MultiDrawArraysIndirect"/>
		public static void MultiDrawElementsIndirect(int mode, int type, Object indirect, Int32 drawcount, Int32 stride)
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
		/// A token identifying the interface within program to query. 
		/// </param>
		/// <param name="pname">
		/// The name of the parameter within programInterface to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetProgramInterfaceiv queries the property of the interface identifed by programInterface in program, the property 
		/// nameof which is given by pname. 
		/// program must be the name of an existing program object. programInterface is the name of the interface within program to 
		/// queryand must be one of the following values: 
		/// pname identifies the property of programInterface to return in params. 
		/// If pname is GL_ACTIVE_RESOURCES, the value returned is the number of resources in the active resource list for 
		/// programInterface.If the list of active resources for programInterface is empty, zero is returned. 
		/// If pname is GL_MAX_NAME_LENGTH, the value returned is the length of the longest active name string for an active 
		/// resourcein programInterface. This length includes an extra character for the null terminator. If the list of active 
		/// resourcesfor programInterface is empty, zero is returned. It is an error to specify GL_MAX_NAME_LENGTH when 
		/// programInterfaceis GL_ATOMIC_COUNTER_BUFFER, as active atomic counter buffer resources are not assigned name strings. 
		/// If pname is GL_MAX_NUM_ACTIVE_VARIABLES, the value returned is the number of active variables belonging to the interface 
		/// blockor atomic counter buffer resource in programInterface with the most active variables. If the list of active 
		/// resourcesfor programInterface is empty, zero is returned. When pname is GL_MAX_NUM_ACTIVE_VARIABLES, programInterface 
		/// mustbe GL_UNIFORM_BLOCK, GL_ATOMIC_COUNTER_BUFFER, or GL_SHADER_STORAGE_BLOCK. 
		/// If pname is GL_MAX_NUM_COMPATIBLE_SUBROUTINES, the value returned is the number of compatible subroutines belonging to 
		/// theactive subroutine uniform in programInterface with the most compatible subroutines. If the list of active resources 
		/// forprogramInterface is empty, zero is returned. When pname is GL_MAX_NUM_COMPATIBLE_SUBROUTINES, programInterface must 
		/// beone of GL_VERTEX_SUBROUTINE_UNIFORM, GL_TESS_CONTROL_SUBROUTINE_UNIFORM, GL_TESS_EVALUATION_SUBROUTINE_UNIFORM, 
		/// GL_GEOMETRY_SUBROUTINE_UNIFORM,GL_FRAGMENT_SUBROUTINE_UNIFORM, or GL_COMPUTE_SUBROUTINE_UNIFORM. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if identifier is not one of the accepted object types. 
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing sync object. 
		/// - GL_INVALID_VALUE is generated if bufSize is zero. 
		/// - GL_INVALID_OPERATION is generated if pname is GL_MAX_NAME_LENGTH and programInterface is GL_ATOMIC_COUNTER_BUFFER or 
		///   GL_TRANSFORM_FEEDBACK_BUFFER,since active atomic counter and transform feedback buffer resources are not assigned name 
		///   strings.
		/// - GL_INVALID_OPERATION error is generated if pname is GL_MAX_NUM_ACTIVE_VARIABLES and programInterface is not 
		///   GL_UNIFORM_BLOCK,GL_SHADER_STORAGE_BLOCK, GL_ATOMIC_COUNTER_BUFFER, or GL_TRANSFORM_FEEDBACK_BUFFER. 
		/// - If not NULL, length and label should be addresses to which the client has write access, otherwise undefined behavior, 
		///   includingprocess termination may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
		public static void GetProgramInterface(UInt32 program, int programInterface, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramInterfaceiv != null, "pglGetProgramInterfaceiv not implemented");
					Delegates.pglGetProgramInterfaceiv(program, programInterface, pname, p_params);
					CallLog("glGetProgramInterfaceiv({0}, {1}, {2}, {3})", program, programInterface, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the index of a named resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query. 
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within program containing the resource named name. 
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the index of. 
		/// </param>
		/// <remarks>
		/// glGetProgramResourceIndex returns the unsigned integer index assigned to a resource named name in the interface type 
		/// programInterfaceof program object program. 
		/// program must be the name of an existing program object. programInterface is the name of the interface within program 
		/// whichcontains the resource named nameand must be one of the following values: 
		/// If name exactly matches the name string of one of the active resources for programInterface, the index of the matched 
		/// resourceis returned. Additionally, if name would exactly match the name string of an active resource if "[0]" were 
		/// appendedto name, the index of the matched resource is returned. Otherwise, name is considered not to be the name of an 
		/// activeresource, and GL_INVALID_INDEX is returned. 
		/// For the interface GL_TRANSFORM_FEEDBACK_VARYING, the value GL_INVALID_INDEX should be returned when querying the index 
		/// assignedto the special names gl_NextBuffer, gl_SkipComponents1, gl_SkipComponents2, gl_SkipComponents3, or 
		/// gl_SkipComponents4.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if programInterface is not one of the accepted interface types. 
		/// - GL_INVALID_ENUM is generated if programInterface is GL_ATOMIC_COUNTER_BUFFER or GL_TRANSFORM_FEEDBACK_BUFFER, since 
		///   activeatomic counter and transform feedback buffer resources are not assigned name strings. 
		/// - Although not an error, GL_INVALID_INDEX is returned if name is not the name of a resource within the interface 
		///   identifiedby programInterface. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		public static UInt32 GetProgramResourceIndex(UInt32 program, int programInterface, String name)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceIndex != null, "pglGetProgramResourceIndex not implemented");
			retValue = Delegates.pglGetProgramResourceIndex(program, programInterface, name);
			CallLog("glGetProgramResourceIndex({0}, {1}, {2}) = {3}", program, programInterface, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// query the name of an indexed resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query. 
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within program containing the indexed resource. 
		/// </param>
		/// <param name="index">
		/// The index of the resource within programInterface of program. 
		/// </param>
		/// <param name="bufSize">
		/// The size of the character array whose address is given by name. 
		/// </param>
		/// <param name="length">
		/// The address of a variable which will receive the length of the resource name. 
		/// </param>
		/// <param name="name">
		/// The address of a character array into which will be written the name of the resource. 
		/// </param>
		/// <remarks>
		/// glGetProgramResourceName retrieves the name string assigned to the single active resource with an index of index in the 
		/// interfaceprogramInterface of program object program. index must be less than the number of entries in the active 
		/// resourcelist for programInterface. 
		/// program must be the name of an existing program object. programInterface is the name of the interface within program 
		/// whichcontains the resource and must be one of the following values: 
		/// The name string assigned to the active resource identified by index is returned as a null-terminated string in the 
		/// characterarray whose address is given in name. The actual number of characters written into name, excluding the null 
		/// terminator,is returned in length. If length is NULL, no length is returned. The maximum number of characters that may be 
		/// writteninto name, including the null terminator, is specified by bufSize. If the length of the name string including the 
		/// nullterminator is greater than bufSize, the first bufSize-1 characters of the name string will be written to name, 
		/// followedby a null terminator. If bufSize is zero, no error will be generated but no characters will be written to name. 
		/// Thelength of the longest name string for programInterface&gt;, including a null terminator, can be queried by calling 
		/// glGetProgramInterfacewith a pname of GL_MAX_NAME_LENGTH. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if programInterface is not one of the accepted interface types. 
		/// - GL_INVALID_VALUE is generated if progam is not the name of an existing program. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of entries in the active resource list for 
		///   programInterface.
		/// - GL_INVALID_ENUM is generated if programInterface is GL_ATOMIC_COUNTER_BUFFER or GL_TRANSFORM_FEEDBACK_BUFFER, since 
		///   activeatomic counter and transform feedback buffer resources are not assigned name strings. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		public static void GetProgramResourceName(UInt32 program, int programInterface, UInt32 index, Int32 bufSize, out Int32 length, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramResourceName != null, "pglGetProgramResourceName not implemented");
					Delegates.pglGetProgramResourceName(program, programInterface, index, bufSize, p_length, name);
					CallLog("glGetProgramResourceName({0}, {1}, {2}, {3}, {4}, {5})", program, programInterface, index, bufSize, length, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve values for multiple properties of a single active resource within a program object
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query. 
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within program containing the resource named name. 
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="propCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="props">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetProgramResourceiv returns values for multiple properties of a single active resource with an index of index in the 
		/// interfaceprogramInterface of program object program. For each resource, values for propCount properties specified by the 
		/// arrayprops are returned. propCount may not be zero. An error is generated if any value in props is not one of the 
		/// propertiesdescribed immediately belowor if any value in props is not allowed for programInterface. The set of allowed 
		/// programInterfacevalues for each property can be found in the following table: 
		/// For the property GL_NAME_LENGTH, a single integer identifying the length of the name string associated with an active 
		/// variable,interface block, or subroutine is written to params. The name length includes a terminating null character. 
		/// For the property GL_TYPE, a single integer identifying the type of an active variable is written to params. The integer 
		/// returnedis one of the values found in table 2.16. 
		/// For the property GL_ARRAY_SIZE, a single integer identifying the number of active array elements of an active variable 
		/// iswritten to params. The array size returned is in units of the type associated with the property GL_TYPE. For active 
		/// variablesnot corresponding to an array of basic types, the value zero is written to params. 
		/// For the property GL_BLOCK_INDEX, a single integer identifying the index of the active interface block containing an 
		/// activevariable is written to params. If the variable is not the member of an interface block, the value -1 is written to 
		/// params.
		/// For the property GL_OFFSET, a single integer identifying the offset of an active variable is written to params. For 
		/// variablesin the GL_UNIFORM and GL_BUFFER_VARIABLE interfaces that are backed by a buffer object, the value written is 
		/// theoffset of that variable relative to the base of the buffer range holding its value. For variables in the 
		/// GL_TRANSFORM_FEEDBACK_VARYINGinterface, the value written is the offset in the transform feedback buffer storage 
		/// assignedto each vertex captured in transform feedback mode where the value of the variable will be stored. Such offsets 
		/// arespecified via the xfb_offset layout qualifier or assigned according to the variables position in the list of strings 
		/// passedto glTransformFeedbackVaryings. Offsets are expressed in basic machine units. For all variables not recorded in 
		/// transformfeedback mode, including the special names "gl_NextBuffer", "gl_SkipComponents1", "gl_SkipComponents2", 
		/// "gl_SkipComponents3",and "gl_SkipComponents4", -1 is written to params. 
		/// For the property GL_ARRAY_STRIDE, a single integer identifying the stride between array elements in an active variable 
		/// iswritten to params. For active variables declared as an array of basic types, the value written is the difference, in 
		/// basicmachine units, between the offsets of consecutive elements in an array. For active variables not declared as an 
		/// arrayof basic types, zero is written to params. For active variables not backed by a buffer object, -1 is written to 
		/// params,regardless of the variable type. 
		/// For the property GL_MATRIX_STRIDE, a single integer identifying the stride between columns of a column-major matrix or 
		/// rowsof a row-major matrix is written to params. For active variables declared a single matrix or array of matrices, the 
		/// valuewritten is the difference, in basic machine units, between the offsets of consecutive columns or rows in each 
		/// matrix.For active variables not declared as a matrix or array of matrices, zero is written to params. For active 
		/// variablesnot backed by a buffer object, -1 is written to params, regardless of the variable type. 
		/// For the property GL_IS_ROW_MAJOR, a single integer identifying whether an active variable is a row-major matrix is 
		/// writtento params. For active variables backed by a buffer object, declared as a single matrix or array of matrices, and 
		/// storedin row-major order, one is written to params. For all other active variables, zero is written to params. 
		/// For the property GL_ATOMIC_COUNTER_BUFFER_INDEX, a single integer identifying the index of the active atomic counter 
		/// buffercontaining an active variable is written to params. If the variable is not an atomic counter uniform, the value -1 
		/// iswritten to params. 
		/// For the property GL_BUFFER_BINDING, to index of the buffer binding point associated with the active uniform block, 
		/// shaderstorage block, atomic counter buffer or transform feedback buffer is written to params. 
		/// For the property GL_BUFFER_DATA_SIZE, then the implementation-dependent minimum total buffer object size, in basic 
		/// machineunits, required to hold all active variables associated with an active uniform block, shader storage block, or 
		/// atomiccounter buffer is written to params. If the final member of an active shader storage block is array with no 
		/// declaredsize, the minimum buffer size is computed assuming the array was declared as an array with one element. 
		/// For the property GL_NUM_ACTIVE_VARIABLES, the number of active variables associated with an active uniform block, shader 
		/// storageblock, atomic counter buffer or transform feedback buffer is written to params. 
		/// For the property GL_ACTIVE_VARIABLES, an array of active variable indices associated with an active uniform block, 
		/// shaderstorage block, atomic counter buffer or transform feedback buffer is written to params. The number of values 
		/// writtento params for an active resource is given by the value of the property GL_NUM_ACTIVE_VARIABLES for the resource. 
		/// For the properties GL_REFERENCED_BY_VERTEX_SHADER, GL_REFERENCED_BY_TESS_CONTROL_SHADER, 
		/// GL_REFERENCED_BY_TESS_EVALUATION_SHADER,GL_REFERENCED_BY_GEOMETRY_SHADER, GL_REFERENCED_BY_FRAGMENT_SHADER, and 
		/// GL_REFERENCED_BY_COMPUTE_SHADER,a single integer is written to params, identifying whether the active resource is 
		/// referencedby the vertex, tessellation control, tessellation evaluation, geometry, or fragment shaders, respectively, in 
		/// theprogram object. The value one is written to params if an active variable is referenced by the corresponding shader, 
		/// orif an active uniform block, shader storage block, or atomic counter buffer contains at least one variable referenced 
		/// bythe corresponding shader. Otherwise, the value zero is written to params. 
		/// For the property GL_TOP_LEVEL_ARRAY_SIZE, a single integer identifying the number of active array elements of the 
		/// top-levelshader storage block member containing to the active variable is written to params. If the top-level block 
		/// memberis not declared as an array, the value one is written to params. If the top-level block member is an array with no 
		/// declaredsize, the value zero is written to params. 
		/// For the property GL_TOP_LEVEL_ARRAY_STRIDE, a single integer identifying the stride between array elements of the 
		/// top-levelshader storage block member containing the active variable is written to params. For top-level block members 
		/// declaredas arrays, the value written is the difference, in basic machine units, between the offsets of the active 
		/// variablefor consecutive elements in the top-level array. For top-level block members not declared as an array, zero is 
		/// writtento params. 
		/// For the property GL_LOCATION, a single integer identifying the assigned location for an active uniform, input, output, 
		/// orsubroutine uniform variable is written to params. For input, output, or uniform variables with locations specified by 
		/// alayout qualifier, the specified location is used. For vertex shader input or fragment shader output variables without a 
		/// layoutqualifier, the location assigned when a program is linked is written to params. For all other input and output 
		/// variables,the value -1 is written to params. For uniforms in uniform blocks, the value -1 is written to params. 
		/// For the property GL_LOCATION_INDEX, a single integer identifying the fragment color index of an active fragment shader 
		/// outputvariable is written to params. If the active variable is an output for a non-fragment shader, the value -1 will be 
		/// writtento params. 
		/// For the property GL_IS_PER_PATCH, a single integer identifying whether the input or output is a per-patch attribute. If 
		/// theactive variable is a per-patch attribute (declared with the patch qualifier), the value one is written to params; 
		/// otherwise,the value zero is written to params. 
		/// For the property GL_LOCATION_COMPONENT, a single integer indicating the first component of the location assigned to an 
		/// activeinput or output variable is written to params. For input and output variables with a component specified by a 
		/// layoutqualifier, the specified component is written. For all other input and output variables, the value zero is 
		/// written.
		/// For the property GL_TRANSFORM_FEEDBACK_BUFFER_INDEX, a single integer identifying the index of the active transform 
		/// feedbackbuffer associated with an active variable is written to params. For variables corresponding to the special names 
		/// "gl_NextBuffer","gl_SkipComponents1", "gl_SkipComponents2", "gl_SkipComponents3", and "gl_SkipComponents4", -1 is 
		/// writtento params. 
		/// For the property GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE, a single integer identifying the stride, in basic machine units, 
		/// betweenconsecutive vertices written to the transform feedback buffer is written to params. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// - GL_INVALID_VALUE is generated if propCount is zero. 
		/// - GL_INVALID_ENUM is generated if programInterface is not one of the accepted interface types. 
		/// - GL_INVLALID_ENUM is generated if any value in props is not one of the accepted tokens for the interface programInterface 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetGetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetProgramResourceLocation"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		public static void GetProgram(UInt32 program, int programInterface, UInt32 index, Int32 propCount, int[] props, Int32 bufSize, out Int32 length, Int32[] @params)
		{
			unsafe {
				fixed (int* p_props = props)
				fixed (Int32* p_length = &length)
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramResourceiv != null, "pglGetProgramResourceiv not implemented");
					Delegates.pglGetProgramResourceiv(program, programInterface, index, propCount, p_props, bufSize, p_length, p_params);
					CallLog("glGetProgramResourceiv({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", program, programInterface, index, propCount, props, bufSize, length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the location of a named resource within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query. 
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within program containing the resource named name. 
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the location of. 
		/// </param>
		/// <remarks>
		/// glGetProgramResourceLocation returns the location assigned to the variable named name in interface programInterface of 
		/// programobject program. program must be the name of a program that has been linked successfully. programInterface must be 
		/// oneof GL_UNIFORM, GL_PROGRAM_INPUT, GL_PROGRAM_OUTPUT, GL_VERTEX_SUBROUTINE_UNIFORM, GL_TESS_CONTROL_SUBROUTINE_UNIFORM, 
		/// GL_TESS_EVALUATION_SUBROUTINE_UNIFORM,GL_GEOMETRY_SUBROUTINE_UNIFORM, GL_FRAGMENT_SUBROUTINE_UNIFORM, 
		/// GL_COMPUTE_SUBROUTINE_UNIFORM,or GL_TRANSFORM_FEEDBACK_BUFFER. 
		/// The value -1 will be returned if an error occurs, if name does not identify an active variable on programInterface, or 
		/// ifname identifies an active variable that does not have a valid location assigned, as described above. The locations 
		/// returnedby these commands are the same locations returned when querying the GL_LOCATION and GL_LOCATION_INDEX resource 
		/// properties.
		/// A string provided to glGetProgramResourceLocation is considered to match an active variable if: 
		/// Any other string is considered not to identify an active variable. If the string specifies an element of an array 
		/// variable,glGetProgramResourceLocation returns the location assigned to that element. If it specifies the base name of an 
		/// array,it identifies the resources associated with the first element of the array. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// - GL_INVALID_ENUM is generated if programInterface is not one of the accepted interface types. 
		/// - GL_INVALID_OPERATION is generated if program has not been linked successfully. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		public static Int32 GetProgramResourceLocation(UInt32 program, int programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocation != null, "pglGetProgramResourceLocation not implemented");
			retValue = Delegates.pglGetProgramResourceLocation(program, programInterface, name);
			CallLog("glGetProgramResourceLocation({0}, {1}, {2}) = {3}", program, programInterface, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// query the fragment color index of a named variable within a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object whose resources to query. 
		/// </param>
		/// <param name="programInterface">
		/// A token identifying the interface within program containing the resource named name. 
		/// </param>
		/// <param name="name">
		/// The name of the resource to query the location of. 
		/// </param>
		/// <remarks>
		/// glGetProgramResourceLocationIndex returns the fragment color index assigned to the variable named name in interface 
		/// programInterfaceof program object program. program must be the name of a program that has been linked successfully. 
		/// programInterfacemust be GL_PROGRAM_OUTPUT. 
		/// The value -1 will be returned if an error occurs, if name does not identify an active variable on programInterface, or 
		/// ifname identifies an active variable that does not have a valid location assigned, as described above. The locations 
		/// returnedby these commands are the same locations returned when querying the GL_LOCATION and GL_LOCATION_INDEX resource 
		/// properties.
		/// A string provided to glGetProgramResourceLocationIndex is considered to match an active variable if: 
		/// Any other string is considered not to identify an active variable. If the string specifies an element of an array 
		/// variable,glGetProgramResourceLocation returns the location assigned to that element. If it specifies the base name of an 
		/// array,it identifies the resources associated with the first element of the array. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of an existing program object. 
		/// - GL_INVALID_ENUM is generated if programInterface is not one of the accepted interface types. 
		/// - GL_INVALID_OPERATION is generated if program has not been linked successfully. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgramResourceName"/>
		/// <seealso cref="Gl.GetProgramResourceIndex"/>
		/// <seealso cref="Gl.GetGetProgramResource"/>
		/// <seealso cref="Gl.GetProgramResourceLocationIndex"/>
		public static Int32 GetProgramResourceLocationIndex(UInt32 program, int programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocationIndex != null, "pglGetProgramResourceLocationIndex not implemented");
			retValue = Delegates.pglGetProgramResourceLocationIndex(program, programInterface, name);
			CallLog("glGetProgramResourceLocationIndex({0}, {1}, {2}) = {3}", program, programInterface, name, retValue);
			DebugCheckErrors();

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
		/// glShaderStorageBlockBinding, changes the active shader storage block with an assigned index of storageBlockIndex in 
		/// programobject program. storageBlockIndex must be an active shader storage block index in program. storageBlockBinding 
		/// mustbe less than the value of GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS. If successful, glShaderStorageBinding specifies 
		/// thatprogram will use the data store of the buffer object bound to the binding point storageBlockBinding to read and 
		/// writethe values of the buffer variables in the shader storage block identified by storageBlockIndex. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_OPERATION is generated if no vertex array object is bound. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_SHADER_STORAGE_BUFFER_BINDING, GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS, 
		///   GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS,GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS, 
		///   GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS,GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS, 
		///   GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS,GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS or GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS, 
		///   GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS,or GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES. 
		/// </para>
		/// </remarks>
		public static void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
		{
			Debug.Assert(Delegates.pglShaderStorageBlockBinding != null, "pglShaderStorageBlockBinding not implemented");
			Delegates.pglShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
			CallLog("glShaderStorageBlockBinding({0}, {1}, {2})", program, storageBlockIndex, storageBlockBinding);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a range of a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for glTexBufferRange. Must be GL_TEXTURE_BUFFER. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
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
		/// glTexBufferRange and glTextureBufferRange attach a range of the data store of a specified buffer object to a specified 
		/// textureobject, and specify the storage format for the texture image found found in the buffer object. The texture object 
		/// mustbe a buffer texture. 
		/// If buffer is zero, any buffer object attached to the buffer texture is detached and no new buffer object is attached. If 
		/// bufferis non-zero, it must be the name of an existing buffer object. 
		/// The start and size of the range are specified by offset and size respectively, both measured in basic machine units. 
		/// offsetmust be greater than or equal to zero, size must be greater than zero, and the sum of offset and size must not 
		/// exceedthe value of GL_BUFFER_SIZE for buffer. Furthermore, offset must be an integer multiple of the value of 
		/// GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT.
		/// internalformat specifies the storage format, and must be one of the following sized internal formats: 
		/// When a range of a buffer object is attached to a buffer texture, the specified range of the buffer object's data store 
		/// istaken as the texture's texel array. The number of texels in the buffer texture's texel array is given by $$ 
		/// \left\lfloor{ size \over { components \times sizeof(base\_type) } } \right\rfloor $$ where $components$ and $base\_type$ 
		/// arethe element count and base data type for elements, as specified in the table above. The number of texels in the texel 
		/// arrayis then clamped to the value of the implementation-dependent limit GL_MAX_TEXTURE_BUFFER_SIZE. When a buffer 
		/// textureis accessed in a shader, the results of a texel fetch are undefined if the specified texel coordinate is 
		/// negative,or greater than or equal to the clamped number of texels in the texel array. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glTexBufferRange if target is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_OPERATION is generated by glTextureBufferRange if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glTextureBufferRange if the effective target of texture is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the sized internal formats described above. 
		/// - GL_INVALID_OPERATION is generated if buffer is not zero and is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset is negative, if size is less than or equal to zero, or if offset + size is 
		///   greaterthan the value of GL_BUFFER_SIZE for buffer. 
		/// - GL_INVALID_VALUE is generated if offset is not an integer multiple of the value of GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_BUFFER_OFFSET or GL_TEXTURE_BUFFER_SIZE. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexBuffer"/>
		public static void TexBufferRange(int target, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			if        (Delegates.pglTexBufferRange != null) {
				Delegates.pglTexBufferRange(target, internalformat, buffer, offset, size);
				CallLog("glTexBufferRange({0}, {1}, {2}, {3}, {4})", target, internalformat, buffer, offset, size);
			} else if (Delegates.pglTexBufferRangeEXT != null) {
				Delegates.pglTexBufferRangeEXT(target, internalformat, buffer, offset, size);
				CallLog("glTexBufferRangeEXT({0}, {1}, {2}, {3}, {4})", target, internalformat, buffer, offset, size);
			} else if (Delegates.pglTexBufferRangeOES != null) {
				Delegates.pglTexBufferRangeOES(target, internalformat, buffer, offset, size);
				CallLog("glTexBufferRangeOES({0}, {1}, {2}, {3}, {4})", target, internalformat, buffer, offset, size);
			} else
				throw new NotImplementedException("glTexBufferRange (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for glTexStorage2DMultisample. Must be one of 
		/// GL_TEXTURE_2D_MULTISAMPLEor GL_PROXY_TEXTURE_2D_MULTISAMPLE. 
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
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexStorage2DMultisample and glTextureStorage2DMultisample specify the storage requirements for a two-dimensional 
		/// multisampletexture. Once a texture is specified with this command, its format and dimensions become immutable unless it 
		/// isa proxy texture. The contents of the image may still be modified, however, its storage requirements may not change. 
		/// Sucha texture is referred to as an immutable-format texture. 
		/// samples specifies the number of samples to be used for the texture and must be greater than zero and less than or equal 
		/// tothe value of GL_MAX_SAMPLES. internalformat must be a color-renderable, depth-renderable, or stencil-renderable 
		/// format.width and height specify the width and height, respectively, of the texture. If fixedsamplelocations is GL_TRUE, 
		/// theimage will use identical sample locations and the same number of samples for all texels in the image, and the sample 
		/// locationswill not depend on the internal format or size of the image. 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glTexStorage2DMultisample if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glTextureStorage2DMultisample if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_ENUM is generated if internalformat is not a valid color-renderable, depth-renderable or stencil-renderable 
		///   format.
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the accepted targets described 
		///   above.
		/// - GL_INVALID_VALUE is generated if width or height are less than 1 or greater than the value of GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if levels is less than 1. 
		/// - GL_INVALID_VALUE is generated if samples is greater than the value of GL_MAX_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if the value of GL_TEXTURE_IMMUTABLE_FORMAT for the texture bound to target is not 
		///   GL_FALSE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		public static void TexStorage2DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexStorage2DMultisample != null, "pglTexStorage2DMultisample not implemented");
			Delegates.pglTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
			CallLog("glTexStorage2DMultisample({0}, {1}, {2}, {3}, {4}, {5})", target, samples, internalformat, width, height, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample array texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for glTexStorage3DMultisample. Must be one of 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYor GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY. 
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
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexStorage3DMultisample and glTextureStorage3DMultisample specify the storage requirements for a two-dimensional 
		/// multisamplearray texture. Once a texture is specified with this command, its format and dimensions become immutable 
		/// unlessit is a proxy texture. The contents of the image may still be modified, however, its storage requirements may not 
		/// change.Such a texture is referred to as an immutable-format texture. 
		/// samples specifies the number of samples to be used for the texture and must be greater than zero and less than or equal 
		/// tothe value of GL_MAX_SAMPLES. internalformat must be a color-renderable, depth-renderable, or stencil-renderable 
		/// format.width and height specify the width and height, respectively, of the texture and depth specifies the depth (or the 
		/// numberof layers) of the texture. If fixedsamplelocations is GL_TRUE, the image will use identical sample locations and 
		/// thesame number of samples for all texels in the image, and the sample locations will not depend on the internal format 
		/// orsize of the image. 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glTexStorage3DMultisample if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glTextureStorage3DMultisample if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_ENUM is generated if internalformat is not a valid color-renderable, depth-renderable or stencil-renderable 
		///   format.
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the accepted targets described 
		///   above.
		/// - GL_INVALID_VALUE is generated if width or height are less than 1 or greater than the value of GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if depth is less than 1 or greater than the value of GL_MAX_ARRAY_TEXTURE_LAYERS. 
		/// - GL_INVALID_VALUE is generated if levels is less than 1. 
		/// - GL_INVALID_VALUE is generated if samples is greater than the value of GL_MAX_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if the value of GL_TEXTURE_IMMUTABLE_FORMAT for the texture bound to target is not 
		///   GL_FALSE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetInteger with arguments GL_MAX_TEXTURE_SIZE, GL_MAX_ARRAY_TEXTURE_LEVELS, GL_TEXTURE_VIEW_MIN_LAYER, 
		///   GL_TEXTURE_VIEW_NUM_LAYERS,or GL_TEXTURE_IMMUTABLE_LEVELS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		public static void TexStorage3DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			if        (Delegates.pglTexStorage3DMultisample != null) {
				Delegates.pglTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
				CallLog("glTexStorage3DMultisample({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, samples, internalformat, width, height, depth, fixedsamplelocations);
			} else if (Delegates.pglTexStorage3DMultisampleOES != null) {
				Delegates.pglTexStorage3DMultisampleOES(target, samples, internalformat, width, height, depth, fixedsamplelocations);
				CallLog("glTexStorage3DMultisampleOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, samples, internalformat, width, height, depth, fixedsamplelocations);
			} else
				throw new NotImplementedException("glTexStorage3DMultisample (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
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
		/// glTextureView initializes a texture object as an alias, or view of another texture object, sharing some or all of the 
		/// parenttexture's data store with the initialized texture. texture specifies a name previously reserved by a successful 
		/// callto glGenTextures but that has not yet been bound or given a target. target specifies the target for the newly 
		/// initializedtexture and must be compatible with the target of the parent texture, given in origtexture as specified in 
		/// thefollowing table: 
		/// The value of GL_TEXTURE_IMMUTABLE_FORMAT for origtexture must be GL_TRUE. After initialization, texture inherits the 
		/// datastore of the parent texture, origtexture and is usable as a normal texture object with target target. Data in the 
		/// sharedstore is reinterpreted with the new internal format specified by internalformat. internalformat must be compatible 
		/// withthe internal format of the parent texture as specified in the following table: 
		/// If the original texture is an array or has multiple mipmap levels, the parameters minlayer, numlayers, minlevel, and 
		/// numlevelscontrol which of those slices and levels are considered part of the texture. The minlevel and minlayer 
		/// parametersare relative to the view of the original texture. If numlayers or numlevels extend beyond the original 
		/// texture,they are clamped to the max extent of the original texture. 
		/// If the new texture's target is GL_TEXTURE_CUBE_MAP, the clamped numlayers must be equal to 6. If the new texture's 
		/// targetis GL_TEXTURE_CUBE_MAP_ARRAY, then numlayers counts layer-faces rather than layers, and the clamped numlayers must 
		/// bea multiple of 6. If the new texture's target is GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY, the width and height 
		/// ofthe original texture's levels must be equal. 
		/// When the original texture's target is GL_TEXTURE_CUBE_MAP, the layer parameters are interpreted in the same order as if 
		/// itwere a GL_TEXTURE_CUBE_MAP_ARRAY with 6 layer-faces. 
		/// If target is GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_2D_MULTISAMPLE, numlayers 
		/// mustequal 1. 
		/// The dimensions of the original texture must be less than or equal to the maximum supported dimensions of the new target. 
		/// Forexample, if the original texture has a GL_TEXTURE_2D_ARRAY target and its width is greater than 
		/// GL_MAX_CUBE_MAP_TEXTURE_SIZE,an error will be generated if glTextureView is called to create a GL_TEXTURE_CUBE_MAP view. 
		/// Texture commands that take a level or layer parameter, such as glTexSubImage2D, interpret that parameter to be relative 
		/// tothe view of the texture. i.e. the mipmap level of the data store that would be updated via TexSubImage2D would be the 
		/// sumof level and the value of GL_TEXTURE_VIEW_MIN_LEVEL. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if minlayer or minlevel are larger than the greatest layer or level of origtexture. 
		/// - GL_INVALID_OPERATION is generated if target is not compatible with the target of origtexture. 
		/// - GL_INVALID_OPERATION is generated if the dimensions of origtexture are greater than the maximum supported dimensions for 
		///   target.
		/// - GL_INVALID_OPERATION is generated if internalformat is not compatible with the internal format of origtexture. 
		/// - GL_INVALID_OPERATION is generated if texture has already been bound or otherwise given a target. 
		/// - GL_INVALID_OPERATION is generated if the value of GL_TEXTURE_IMMUTABLE_FORMAT for origtexture is not GL_TRUE. 
		/// - GL_INVALID_OPERATION is generated if origtexture is not the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generaged if target is GL_TEXTURE_CUBE_MAP and numlayers is not 6, or if target is 
		///   GL_TEXTURE_CUBE_MAP_ARRAYand numlayers is not an integer multiple of 6. 
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, or 
		///   GL_TEXTURE_2D_MULTISAMPLEand numlayers does not equal 1. 
		/// - GL_INVALID_VALUE is generated if texture zero or is not the name of a texture previously returned from a successful call 
		///   toglGenTextures. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glTexParameter with arguments GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_VIEW_MIN_LAYER, 
		///   GL_TEXTURE_VIEW_NUM_LAYERS,or GL_TEXTURE_IMMUTABLE_LEVELS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		public static void Texture(UInt32 texture, int target, UInt32 origtexture, int internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			if        (Delegates.pglTextureView != null) {
				Delegates.pglTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
				CallLog("glTextureView({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			} else if (Delegates.pglTextureViewEXT != null) {
				Delegates.pglTextureViewEXT(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
				CallLog("glTextureViewEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			} else if (Delegates.pglTextureViewOES != null) {
				Delegates.pglTextureViewOES(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
				CallLog("glTextureViewOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			} else
				throw new NotImplementedException("glTextureView (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// glBindVertexBuffer and glVertexArrayVertexBuffer bind the buffer named buffer to the vertex buffer binding point whose 
		/// indexis given by bindingindex. glBindVertexBuffer modifies the binding of the currently bound vertex array object, 
		/// whereasglVertexArrayVertexBuffer allows the caller to specify ID of the vertex array object with an argument named 
		/// vaobj,for which the binding should be modified. offset and stride specify the offset of the first element within the 
		/// bufferand the distance between elements within the buffer, respectively, and are both measured in basic machine units. 
		/// bindingindexmust be less than the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. offset and stride must be greater than or 
		/// equalto zero. If buffer is zero, then any buffer currently bound to the specified binding point is unbound. 
		/// If buffer is not the name of an existing buffer object, the GL first creates a new state vector, initialized with a 
		/// zero-sizedmemory buffer and comprising all the state and with the same initial values as in case of glBindBuffer. buffer 
		/// isthen attached to the specified bindingindex of the vertex array object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glBindVertexBuffer if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayVertexBuffer if vaobj is not the name of an existing vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_VALUE is generated if offset or stride is less than zero, or if stride is greater than the value of 
		///   GL_MAX_VERTEX_ATTRIB_STRIDE.
		/// - GL_INVALID_VALUE is generated if buffer is not zero or the name of an existing buffer object (as returned by 
		///   glGenBuffersor glCreateBuffers). 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		public static void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			Debug.Assert(Delegates.pglBindVertexBuffer != null, "pglBindVertexBuffer not implemented");
			Delegates.pglBindVertexBuffer(bindingindex, buffer, offset, stride);
			CallLog("glBindVertexBuffer({0}, {1}, {2}, {3})", bindingindex, buffer, offset, stride);
			DebugCheckErrors();
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
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribFormat(UInt32 attribindex, Int32 size, int type, bool normalized, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribFormat != null, "pglVertexAttribFormat not implemented");
			Delegates.pglVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
			CallLog("glVertexAttribFormat({0}, {1}, {2}, {3}, {4})", attribindex, size, type, normalized, relativeoffset);
			DebugCheckErrors();
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
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribIFormat(UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribIFormat != null, "pglVertexAttribIFormat not implemented");
			Delegates.pglVertexAttribIFormat(attribindex, size, type, relativeoffset);
			CallLog("glVertexAttribIFormat({0}, {1}, {2}, {3})", attribindex, size, type, relativeoffset);
			DebugCheckErrors();
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
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribLFormat(UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexAttribLFormat != null, "pglVertexAttribLFormat not implemented");
			Delegates.pglVertexAttribLFormat(attribindex, size, type, relativeoffset);
			CallLog("glVertexAttribLFormat({0}, {1}, {2}, {3})", attribindex, size, type, relativeoffset);
			DebugCheckErrors();
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
		/// glVertexAttribBinding and glVertexArrayAttribBinding establishes an association between the generic vertex attribute of 
		/// avertex array object whose index is given by attribindex, and a vertex buffer binding whose index is given by 
		/// bindingindex.For glVertexAttribBinding, the vertex array object affected is that currently bound. For 
		/// glVertexArrayAttribBinding,vaobj is the name of the vertex array object. 
		/// attribindex must be less than the value of GL_MAX_VERTEX_ATTRIBS and bindingindex must be less than the value of 
		/// GL_MAX_VERTEX_ATTRIB_BINDINGS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glVertexAttribBinding if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribBinding if vaobj is not the name of an existing vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, GL_VERTEX_BINDING_DIVISOR. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
		{
			Debug.Assert(Delegates.pglVertexAttribBinding != null, "pglVertexAttribBinding not implemented");
			Delegates.pglVertexAttribBinding(attribindex, bindingindex);
			CallLog("glVertexAttribBinding({0}, {1})", attribindex, bindingindex);
			DebugCheckErrors();
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
		/// glVertexBindingDivisor and glVertexArrayBindingDivisor modify the rate at which generic vertex attributes advance when 
		/// renderingmultiple instances of primitives in a single draw command. If divisor is zero, the attributes using the buffer 
		/// boundto bindingindex advance once per vertex. If divisor is non-zero, the attributes advance once per divisor instances 
		/// ofthe set(s) of vertices being rendered. An attribute is referred to as instanced if the corresponding divisor value is 
		/// non-zero.
		/// glVertexBindingDivisor uses currently bound vertex array object , whereas glVertexArrayBindingDivisor updates state of 
		/// thevertex array object with ID vaobj. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_OPERATION by glVertexBindingDivisor is generated if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayBindingDivisor if vaobj is not the name of an existing vertex array 
		///   object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, GL_VERTEX_BINDING_DIVISOR. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexBindingDivisor != null, "pglVertexBindingDivisor not implemented");
			Delegates.pglVertexBindingDivisor(bindingindex, divisor);
			CallLog("glVertexBindingDivisor({0}, {1})", bindingindex, divisor);
			DebugCheckErrors();
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
		/// <param name="count">
		/// The length of the array ids. 
		/// </param>
		/// <param name="ids">
		/// The address of an array of unsigned integers contianing the ids of the messages to enable or disable. 
		/// </param>
		/// <param name="enabled">
		/// A Boolean flag determining whether the selected messages should be enabled or disabled. 
		/// </param>
		/// <remarks>
		/// glDebugMessageControl controls the reporting of debug messages generated by a debug context. The parameters source, type 
		/// andseverity form a filter to select messages from the pool of potential messages generated by the GL. 
		/// source may be GL_DEBUG_SOURCE_API, GL_DEBUG_SOURCE_WINDOW_SYSTEM_, GL_DEBUG_SOURCE_SHADER_COMPILER, 
		/// GL_DEBUG_SOURCE_THIRD_PARTY,GL_DEBUG_SOURCE_APPLICATION, GL_DEBUG_SOURCE_OTHER to select messages generated by usage of 
		/// theGL API, the window system, the shader compiler, third party tools or libraries, explicitly by the application or by 
		/// someother source, respectively. It may also take the value GL_DONT_CARE. If source is not GL_DONT_CARE then only 
		/// messageswhose source matches source will be referenced. 
		/// type may be one of GL_DEBUG_TYPE_ERROR, GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR, GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR, 
		/// GL_DEBUG_TYPE_PORTABILITY,GL_DEBUG_TYPE_PERFORMANCE, GL_DEBUG_TYPE_MARKER, GL_DEBUG_TYPE_PUSH_GROUP, 
		/// GL_DEBUG_TYPE_POP_GROUP,or GL_DEBUG_TYPE_OTHER to indicate the type of messages describing GL errors, attempted use of 
		/// deprecatedfeatures, triggering of undefined behavior, portability issues, performance notifications, markers, group push 
		/// andpop events, and other types of messages, respectively. It may also take the value GL_DONT_CARE. If type is not 
		/// GL_DONT_CAREthen only messages whose type matches type will be referenced. 
		/// severity may be one of GL_DEBUG_SEVERITY_LOW, GL_DEBUG_SEVERITY_MEDIUM, or GL_DEBUG_SEVERITY_HIGH to select messages of 
		/// low,medium or high severity messages or to GL_DEBUG_SEVERITY_NOTIFICATION for notifications. It may also take the value 
		/// GL_DONT_CARE.If severity is not GL_DONT_CARE then only messages whose severity matches severity will be referenced. 
		/// ids contains a list of count message identifiers to select specific messages from the pool of available messages. If 
		/// countis zero then the value of ids is ignored. Otherwise, only messages appearing in this list are selected. In this 
		/// case,source and type may not be GL_DONT_CARE and severity must be GL_DONT_CARE. 
		/// If enabled is GL_TRUE then messages that match the filter formed by source, type, severity and ids are enabled. 
		/// Otherwise,those messages are disabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_ENUM is generated if any of source, type or severity is not one of the accepted interface types. 
		/// - GL_INVALID_OPERATION is generated if count is non-zero and either source or type is GL_DONT_CARE or if severity is not 
		///   GL_DONT_CARE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		public static void DebugMessageControl(int source, int type, int severity, Int32 count, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglDebugMessageControl != null) {
						Delegates.pglDebugMessageControl(source, type, severity, count, p_ids, enabled);
						CallLog("glDebugMessageControl({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, count, ids, enabled);
					} else if (Delegates.pglDebugMessageControlARB != null) {
						Delegates.pglDebugMessageControlARB(source, type, severity, count, p_ids, enabled);
						CallLog("glDebugMessageControlARB({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, count, ids, enabled);
					} else if (Delegates.pglDebugMessageControlKHR != null) {
						Delegates.pglDebugMessageControlKHR(source, type, severity, count, p_ids, enabled);
						CallLog("glDebugMessageControlKHR({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, count, ids, enabled);
					} else
						throw new NotImplementedException("glDebugMessageControl (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// The length string contained in the character array whose address is given by message. 
		/// </param>
		/// <param name="buf">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <remarks>
		/// glDebugMessageInsert inserts a user-supplied message into the debug output queue. source specifies the source that will 
		/// beused to classify the message and must be GL_DEBUG_SOURCE_APPLICATION or GL_DEBUG_SOURCE_THIRD_PARTY. All other sources 
		/// arereserved for use by the GL implementation. type indicates the type of the message to be inserted and may be one of 
		/// GL_DEBUG_TYPE_ERROR,GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR, GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR, GL_DEBUG_TYPE_PORTABILITY, 
		/// GL_DEBUG_TYPE_PERFORMANCE,GL_DEBUG_TYPE_MARKER, GL_DEBUG_TYPE_PUSH_GROUP, GL_DEBUG_TYPE_POP_GROUP, or 
		/// GL_DEBUG_TYPE_OTHER.severity indicates the severity of the message and may be GL_DEBUG_SEVERITY_LOW, 
		/// GL_DEBUG_SEVERITY_MEDIUM,GL_DEBUG_SEVERITY_HIGH or GL_DEBUG_SEVERITY_NOTIFICATION. id is available for application 
		/// defineduse and may be any value. This value will be recorded and used to identify the message. 
		/// length contains a count of the characters in the character array whose address is given in message. If length is 
		/// negativethen message is treated as a null-terminated string. The length of the message, whether specified explicitly or 
		/// implicitly,must be less than or equal to the implementation defined constant GL_MAX_DEBUG_MESSAGE_LENGTH. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if any of source, type or severity is not one of the accepted interface types. 
		/// - GL_INVALID_VALUE is generated if the length of the message is greater than the value of GL_MAX_DEBUG_MESSAGE_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		public static void DebugMessageInsert(int source, int type, UInt32 id, int severity, Int32 length, String buf)
		{
			if        (Delegates.pglDebugMessageInsert != null) {
				Delegates.pglDebugMessageInsert(source, type, id, severity, length, buf);
				CallLog("glDebugMessageInsert({0}, {1}, {2}, {3}, {4}, {5})", source, type, id, severity, length, buf);
			} else if (Delegates.pglDebugMessageInsertARB != null) {
				Delegates.pglDebugMessageInsertARB(source, type, id, severity, length, buf);
				CallLog("glDebugMessageInsertARB({0}, {1}, {2}, {3}, {4}, {5})", source, type, id, severity, length, buf);
			} else if (Delegates.pglDebugMessageInsertKHR != null) {
				Delegates.pglDebugMessageInsertKHR(source, type, id, severity, length, buf);
				CallLog("glDebugMessageInsertKHR({0}, {1}, {2}, {3}, {4}, {5})", source, type, id, severity, length, buf);
			} else
				throw new NotImplementedException("glDebugMessageInsert (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a callback to receive debugging messages from the GL
		/// </summary>
		/// <param name="callback">
		/// The address of a callback function that will be called when a debug message is generated. 
		/// </param>
		/// <param name="userParam">
		/// A user supplied pointer that will be passed on each invocation of callback. 
		/// </param>
		/// <remarks>
		/// glDebugMessageCallback sets the current debug output callback function to the function whose address is given in 
		/// callback.The callback function should have the following prototype (in C), or be otherwise compatible with such a 
		/// prototype:
		/// This function is defined to have the same calling convention as the GL API functions. In most cases this is defined as 
		/// APIENTRY,although it will vary depending on platform, language and compiler. 
		/// Each time a debug message is generated the debug callback function will be invoked with source, type, id, and severity 
		/// associatedwith the message, and length set to the length of debug message whose character string is in the array pointed 
		/// toby messageuserParam will be set to the value passed in the userParam parameter to the most recent call to 
		/// glDebugMessageCallback.
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		public static void DebugMessageCallback(IntPtr callback, IntPtr userParam)
		{
			if        (Delegates.pglDebugMessageCallback != null) {
				Delegates.pglDebugMessageCallback(callback, userParam);
				CallLog("glDebugMessageCallback({0}, {1})", callback, userParam);
			} else if (Delegates.pglDebugMessageCallbackARB != null) {
				Delegates.pglDebugMessageCallbackARB(callback, userParam);
				CallLog("glDebugMessageCallbackARB({0}, {1})", callback, userParam);
			} else if (Delegates.pglDebugMessageCallbackKHR != null) {
				Delegates.pglDebugMessageCallbackKHR(callback, userParam);
				CallLog("glDebugMessageCallbackKHR({0}, {1})", callback, userParam);
			} else
				throw new NotImplementedException("glDebugMessageCallback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a callback to receive debugging messages from the GL
		/// </summary>
		/// <param name="callback">
		/// The address of a callback function that will be called when a debug message is generated. 
		/// </param>
		/// <param name="userParam">
		/// A user supplied pointer that will be passed on each invocation of callback. 
		/// </param>
		/// <remarks>
		/// glDebugMessageCallback sets the current debug output callback function to the function whose address is given in 
		/// callback.The callback function should have the following prototype (in C), or be otherwise compatible with such a 
		/// prototype:
		/// This function is defined to have the same calling convention as the GL API functions. In most cases this is defined as 
		/// APIENTRY,although it will vary depending on platform, language and compiler. 
		/// Each time a debug message is generated the debug callback function will be invoked with source, type, id, and severity 
		/// associatedwith the message, and length set to the length of debug message whose character string is in the array pointed 
		/// toby messageuserParam will be set to the value passed in the userParam parameter to the most recent call to 
		/// glDebugMessageCallback.
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageControl"/>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.GetDebugMessageLog"/>
		public static void DebugMessageCallback(IntPtr callback, Object userParam)
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
		/// <param name="count">
		/// The number of debug messages to retrieve from the log. 
		/// </param>
		/// <param name="bufSize">
		/// The size of the buffer whose address is given by messageLog. 
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
		/// glGetDebugMessageLog retrieves messages from the debug message log. A maximum of count messages are retrieved from the 
		/// log.If sources is not NULL then the source of each message is written into up to count elements of the array. If types 
		/// isnot NULL then the type of each message is written into up to count elements of the array. If id is not NULL then the 
		/// identifierof each message is written into up to count elements of the array. If severities is not NULL then the severity 
		/// ofeach message is written into up to count elements of the array. If lengths is not NULL then the length of each message 
		/// iswritten into up to count elements of the array. 
		/// messageLog specifies the address of a character array into which the debug messages will be written. Each message will 
		/// beconcatenated onto the array starting at the first element of messageLog. bufSize specifies the size of the array 
		/// messageLog.If a message will not fit into the remaining space in messageLog then the function terminates and returns the 
		/// numberof messages written so far, which may be zero. 
		/// If glGetDebugMessageLog returns zero then no messages are present in the debug log, or there was not enough space in 
		/// messageLogto retrieve the first message in the queue. If messageLog is NULL then no messages are written and the value 
		/// ofbufSize is ignored. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if count or bufSize is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEBUG_LOGGED_MESSAGES 
		/// - glGet with argument GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH 
		/// - glGet with argument GL_MAX_DEBUG_MESSAGE_LENGTH 
		/// - glGet with argument GL_MAX_DEBUG_LOGGED_MESSAGES 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageInsert"/>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		/// <seealso cref="Gl.DebugMessageControl"/>
		public static UInt32 GetDebugMessageLog(UInt32 count, Int32 bufSize, int[] sources, int[] types, UInt32[] ids, int[] severities, Int32[] lengths, [Out] StringBuilder messageLog)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_sources = sources)
				fixed (int* p_types = types)
				fixed (UInt32* p_ids = ids)
				fixed (int* p_severities = severities)
				fixed (Int32* p_lengths = lengths)
				{
					if        (Delegates.pglGetDebugMessageLog != null) {
						retValue = Delegates.pglGetDebugMessageLog(count, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLog({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", count, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
					} else if (Delegates.pglGetDebugMessageLogARB != null) {
						retValue = Delegates.pglGetDebugMessageLogARB(count, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLogARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", count, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
					} else if (Delegates.pglGetDebugMessageLogKHR != null) {
						retValue = Delegates.pglGetDebugMessageLogKHR(count, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLogKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", count, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
					} else
						throw new NotImplementedException("glGetDebugMessageLog (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();

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
		/// glPushDebugGroup pushes a debug group described by the string message into the command stream. The value of id specifies 
		/// theID of messages generated. The parameter length contains the number of characters in message. If length is negative, 
		/// itis implied that message contains a null terminated string. The message has the specified source and id, the 
		/// typeGL_DEBUG_TYPE_PUSH_GROUP,and severityGL_DEBUG_SEVERITY_NOTIFICATION. The GL will put a new debug group on top of the 
		/// debuggroup stack which inherits the control of the volume of debug output of the debug group previously residing on the 
		/// topof the debug group stack. Because debug groups are strictly hierarchical, any additional control of the debug output 
		/// volumewill only apply within the active debug group and the debug groups pushed on top of the active debug group. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if the value of source is neither GL_DEBUG_SOURCE_APPLICATION nor 
		///   GL_DEBUG_SOURCE_THIRD_PARTY.
		/// - GL_INVALID_VALUE is generated if length is negative and the number of characters in message, excluding the 
		///   null-terminator,is not less than the value of GL_MAX_DEBUG_MESSAGE_LENGTH. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_DEBUG_MESSAGE_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		public static void PushDebugGroup(int source, UInt32 id, Int32 length, String message)
		{
			if        (Delegates.pglPushDebugGroup != null) {
				Delegates.pglPushDebugGroup(source, id, length, message);
				CallLog("glPushDebugGroup({0}, {1}, {2}, {3})", source, id, length, message);
			} else if (Delegates.pglPushDebugGroupKHR != null) {
				Delegates.pglPushDebugGroupKHR(source, id, length, message);
				CallLog("glPushDebugGroupKHR({0}, {1}, {2}, {3})", source, id, length, message);
			} else
				throw new NotImplementedException("glPushDebugGroup (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// pop the active debug group
		/// </summary>
		/// <remarks>
		/// glPopDebugGroup pops the active debug group. After popping a debug group, the GL will also generate a debug output 
		/// messagedescribing its cause based on the message string, the source source, and an ID id submitted to the corresponding 
		/// glPushDebugGroupcommand. GL_DEBUG_TYPE_PUSH_GROUP and GL_DEBUG_TYPE_POP_GROUP share a single namespace for message id. 
		/// severityhas the value GL_DEBUG_SEVERITY_NOTIFICATION. The type has the value GL_DEBUG_TYPE_POP_GROUP. Popping a debug 
		/// grouprestores the debug output volume control of the parent debug group. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_STACK_UNDERFLOW is generated if an attempt is made to pop the default debug group from the stack. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_DEBUG_MESSAGE_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		public static void PopDebugGroup()
		{
			if        (Delegates.pglPopDebugGroup != null) {
				Delegates.pglPopDebugGroup();
				CallLog("glPopDebugGroup()");
			} else if (Delegates.pglPopDebugGroupKHR != null) {
				Delegates.pglPopDebugGroupKHR();
				CallLog("glPopDebugGroupKHR()");
			} else
				throw new NotImplementedException("glPopDebugGroup (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// glObjectLabel labels the object identified by name within the namespace given by identifier. identifier must be one of 
		/// GL_BUFFER,GL_SHADER, GL_PROGRAM, GL_VERTEX_ARRAY, GL_QUERY, GL_PROGRAM_PIPELINE, GL_TRANSFORM_FEEDBACK, GL_SAMPLER, 
		/// GL_TEXTURE,GL_RENDERBUFFER, GL_FRAMEBUFFER, to indicate the namespace containing the names of buffers, shaders, 
		/// programs,vertex array objects, query objects, program pipelines, transform feedback objects, samplers, textures, 
		/// renderbuffersand frame buffers, respectively. 
		/// label is the address of a string that will be used to label an object. length contains the number of characters in 
		/// label.If length is negative, it is implied that label contains a null-terminated string. If label is NULL, any debug 
		/// labelis effectively removed from the object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if identifier is not one of the accepted object types. 
		/// - GL_INVALID_OPERATION is generated if name is not the name of an existing object of the type specified by identifier. 
		/// - GL_INVALID_VALUE is generated if the number of characters in label, excluding the null terminator when length is 
		///   negative,is greater than the value of GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectPtrLabel"/>
		public static void Object(int identifier, UInt32 name, Int32 length, String label)
		{
			if        (Delegates.pglObjectLabel != null) {
				Delegates.pglObjectLabel(identifier, name, length, label);
				CallLog("glObjectLabel({0}, {1}, {2}, {3})", identifier, name, length, label);
			} else if (Delegates.pglObjectLabelKHR != null) {
				Delegates.pglObjectLabelKHR(identifier, name, length, label);
				CallLog("glObjectLabelKHR({0}, {1}, {2}, {3})", identifier, name, length, label);
			} else
				throw new NotImplementedException("glObjectLabel (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// The length of the buffer whose address is in label. 
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label. 
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label. 
		/// </param>
		/// <remarks>
		/// glGetObjectLabel retrieves the label of the object identified by name within the namespace given by identifier. 
		/// identifiermust be one of GL_BUFFER, GL_SHADER, GL_PROGRAM, GL_VERTEX_ARRAY, GL_QUERY, GL_PROGRAM_PIPELINE, 
		/// GL_TRANSFORM_FEEDBACK,GL_SAMPLER, GL_TEXTURE, GL_RENDERBUFFER, GL_FRAMEBUFFER, to indicate the namespace containing the 
		/// namesof buffers, shaders, programs, vertex array objects, query objects, program pipelines, transform feedback objects, 
		/// samplers,textures, renderbuffers and frame buffers, respectively. 
		/// label is the address of a string that will be used to store the object label. bufSize specifies the number of characters 
		/// inthe array identified by label. length contains the address of a variable which will receive the the number of 
		/// charactersin the object label. If length is NULL, then it is ignored and no data is written. Likewise, if label is NULL, 
		/// orif bufSize is zero then no data is written to label. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if identifier is not one of the accepted object types. 
		/// - GL_INVALID_OPERATION is generated if name is not the name of an existing object of the type specified by identifier. 
		/// - GL_INVALID_VALUE is generated if bufSize is zero. 
		/// - If not NULL, length and label should be addresses to which the client has write access, otherwise undefined behavior, 
		///   includingprocess termination may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectPtrLabel"/>
		public static void GetObject(int identifier, UInt32 name, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					if        (Delegates.pglGetObjectLabel != null) {
						Delegates.pglGetObjectLabel(identifier, name, bufSize, p_length, label);
						CallLog("glGetObjectLabel({0}, {1}, {2}, {3}, {4})", identifier, name, bufSize, length, label);
					} else if (Delegates.pglGetObjectLabelKHR != null) {
						Delegates.pglGetObjectLabelKHR(identifier, name, bufSize, p_length, label);
						CallLog("glGetObjectLabelKHR({0}, {1}, {2}, {3}, {4})", identifier, name, bufSize, length, label);
					} else
						throw new NotImplementedException("glGetObjectLabel (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// glObjectPtrLabel labels the sync object identified by ptr. 
		/// label is the address of a string that will be used to label the object. length contains the number of characters in 
		/// label.If length is negative, it is implied that label contains a null-terminated string. If label is NULL, any debug 
		/// labelis effectively removed from the object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if ptr is not a valid sync object. 
		/// - GL_INVALID_VALUE is generated if the number of characters in label, excluding the null terminator when length is 
		///   negative,is greater than the value of GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		public static void Object(IntPtr ptr, Int32 length, String label)
		{
			if        (Delegates.pglObjectPtrLabel != null) {
				Delegates.pglObjectPtrLabel(ptr, length, label);
				CallLog("glObjectPtrLabel({0}, {1}, {2})", ptr, length, label);
			} else if (Delegates.pglObjectPtrLabelKHR != null) {
				Delegates.pglObjectPtrLabelKHR(ptr, length, label);
				CallLog("glObjectPtrLabelKHR({0}, {1}, {2})", ptr, length, label);
			} else
				throw new NotImplementedException("glObjectPtrLabel (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// glObjectPtrLabel labels the sync object identified by ptr. 
		/// label is the address of a string that will be used to label the object. length contains the number of characters in 
		/// label.If length is negative, it is implied that label contains a null-terminated string. If label is NULL, any debug 
		/// labelis effectively removed from the object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if ptr is not a valid sync object. 
		/// - GL_INVALID_VALUE is generated if the number of characters in label, excluding the null terminator when length is 
		///   negative,is greater than the value of GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
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
		/// The length of the buffer whose address is in label. 
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label. 
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label. 
		/// </param>
		/// <remarks>
		/// glGetObjectPtrLabel retrieves the label of the sync object identified by ptr. 
		/// label is the address of a string that will be used to store the object label. bufSize specifies the number of characters 
		/// inthe array identified by label. length contains the address of a variable which will receive the the number of 
		/// charactersin the object label. If length is NULL, then it is ignored and no data is written. Likewise, if label is NULL, 
		/// orif bufSize is zero then no data is written to label. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if identifier is not one of the accepted object types. 
		/// - GL_INVALID_VALUE is generated if ptr is not the name of an existing sync object. 
		/// - GL_INVALID_VALUE is generated if bufSize is zero. 
		/// - If not NULL, length and label should be addresses to which the client has write access, otherwise undefined behavior, 
		///   includingprocess termination may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
		public static void GetObject(IntPtr ptr, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					if        (Delegates.pglGetObjectPtrLabel != null) {
						Delegates.pglGetObjectPtrLabel(ptr, bufSize, p_length, label);
						CallLog("glGetObjectPtrLabel({0}, {1}, {2}, {3})", ptr, bufSize, length, label);
					} else if (Delegates.pglGetObjectPtrLabelKHR != null) {
						Delegates.pglGetObjectPtrLabelKHR(ptr, bufSize, p_length, label);
						CallLog("glGetObjectPtrLabelKHR({0}, {1}, {2}, {3})", ptr, bufSize, length, label);
					} else
						throw new NotImplementedException("glGetObjectPtrLabel (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the label of a sync object identified by a pointer
		/// </summary>
		/// <param name="ptr">
		/// The name of the sync object whose label to retrieve. 
		/// </param>
		/// <param name="bufSize">
		/// The length of the buffer whose address is in label. 
		/// </param>
		/// <param name="length">
		/// The address of a variable to receive the length of the object label. 
		/// </param>
		/// <param name="label">
		/// The address of a string that will receive the object label. 
		/// </param>
		/// <remarks>
		/// glGetObjectPtrLabel retrieves the label of the sync object identified by ptr. 
		/// label is the address of a string that will be used to store the object label. bufSize specifies the number of characters 
		/// inthe array identified by label. length contains the address of a variable which will receive the the number of 
		/// charactersin the object label. If length is NULL, then it is ignored and no data is written. Likewise, if label is NULL, 
		/// orif bufSize is zero then no data is written to label. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if identifier is not one of the accepted object types. 
		/// - GL_INVALID_VALUE is generated if ptr is not the name of an existing sync object. 
		/// - GL_INVALID_VALUE is generated if bufSize is zero. 
		/// - If not NULL, length and label should be addresses to which the client has write access, otherwise undefined behavior, 
		///   includingprocess termination may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_LABEL_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PushDebugGroup"/>
		/// <seealso cref="Gl.PopDebugGroup"/>
		/// <seealso cref="Gl.ObjectLabel"/>
		/// <seealso cref="Gl.GetObjectLabel"/>
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
