
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
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGB8_ETC2 = 0x9274;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_ETC2 = 0x9275;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RGBA8_ETC2_EAC = 0x9278;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;

		/// <summary>
		/// Value of GL_COMPRESSED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_R11_EAC = 0x9270;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_R11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SIGNED_R11_EAC = 0x9271;

		/// <summary>
		/// Value of GL_COMPRESSED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_RG11_EAC = 0x9272;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG11_EAC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int COMPRESSED_SIGNED_RG11_EAC = 0x9273;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_FIXED_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED_CONSERVATIVE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

		/// <summary>
		/// Value of GL_MAX_ELEMENT_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_ES3_compatibility")]
		public const int MAX_ELEMENT_INDEX = 0x8D6B;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int COMPUTE_SHADER = 0x91B9;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_SHARED_MEMORY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;

		/// <summary>
		/// Value of GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_COUNT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

		/// <summary>
		/// Value of GL_COMPUTE_WORK_GROUP_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;

		/// <summary>
		/// Value of GL_DISPATCH_INDIRECT_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
		public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_explicit_uniform_location")]
		public const int MAX_UNIFORM_LOCATIONS = 0x826E;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
		public const int MAX_FRAMEBUFFER_WIDTH = 0x9315;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int UNIFORM = 0x92E1;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int UNIFORM_BLOCK = 0x92E2;

		/// <summary>
		/// Value of GL_PROGRAM_INPUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int PROGRAM_INPUT = 0x92E3;

		/// <summary>
		/// Value of GL_PROGRAM_OUTPUT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int PROGRAM_OUTPUT = 0x92E4;

		/// <summary>
		/// Value of GL_BUFFER_VARIABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_VARIABLE = 0x92E5;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BLOCK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TRANSFORM_FEEDBACK_VARYING = 0x92F4;

		/// <summary>
		/// Value of GL_ACTIVE_RESOURCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ACTIVE_RESOURCES = 0x92F5;

		/// <summary>
		/// Value of GL_MAX_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MAX_NAME_LENGTH = 0x92F6;

		/// <summary>
		/// Value of GL_MAX_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int NAME_LENGTH = 0x92F9;

		/// <summary>
		/// Value of GL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TYPE = 0x92FA;

		/// <summary>
		/// Value of GL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ARRAY_SIZE = 0x92FB;

		/// <summary>
		/// Value of GL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int OFFSET = 0x92FC;

		/// <summary>
		/// Value of GL_BLOCK_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BLOCK_INDEX = 0x92FD;

		/// <summary>
		/// Value of GL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ARRAY_STRIDE = 0x92FE;

		/// <summary>
		/// Value of GL_MATRIX_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int MATRIX_STRIDE = 0x92FF;

		/// <summary>
		/// Value of GL_IS_ROW_MAJOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int IS_ROW_MAJOR = 0x9300;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;

		/// <summary>
		/// Value of GL_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_BINDING = 0x9302;

		/// <summary>
		/// Value of GL_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int BUFFER_DATA_SIZE = 0x9303;

		/// <summary>
		/// Value of GL_NUM_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int NUM_ACTIVE_VARIABLES = 0x9304;

		/// <summary>
		/// Value of GL_ACTIVE_VARIABLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int ACTIVE_VARIABLES = 0x9305;

		/// <summary>
		/// Value of GL_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_FRAGMENT_SHADER = 0x930A;

		/// <summary>
		/// Value of GL_REFERENCED_BY_COMPUTE_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int REFERENCED_BY_COMPUTE_SHADER = 0x930B;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TOP_LEVEL_ARRAY_SIZE = 0x930C;

		/// <summary>
		/// Value of GL_TOP_LEVEL_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public const int TOP_LEVEL_ARRAY_STRIDE = 0x930D;

		/// <summary>
		/// Value of GL_LOCATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER = 0x90D2;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_START = 0x90D4;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;

		/// <summary>
		/// Value of GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;

		/// <summary>
		/// Value of GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;

		/// <summary>
		/// Value of GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;

		/// <summary>
		/// Value of GL_MAX_SHADER_STORAGE_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

		/// <summary>
		/// Value of GL_SHADER_STORAGE_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_TEXTURE_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		[RequiredByFeature("GL_ARB_texture_view")]
		public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_ATTRIB_BINDING = 0x82D4;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_DIVISOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_DIVISOR = 0x82D6;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_OFFSET = 0x82D7;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int VERTEX_BINDING_STRIDE = 0x82D8;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIB_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
		public const int MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

		/// <summary>
		/// Value of GL_VERTEX_BINDING_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
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
		/// binding targets in the following table:
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object")]
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
		/// binding targets in the following table:
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object")]
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
		/// The format of the data in memory addressed by data.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object")]
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
		/// The format of the data in memory addressed by data.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_clear_buffer_object")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
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
		/// parameters are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_copy_image")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments")]
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
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_RECTANGLE, 
		/// GL_TEXTURE_BUFFER, GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public static void GetInternalformat(int target, int internalformat, int pname, params Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformati64v != null, "pglGetInternalformati64v not implemented");
					Delegates.pglGetInternalformati64v(target, internalformat, pname, (Int32)@params.Length, p_params);
					CallLog("glGetInternalformati64v({0}, {1}, {2}, {3}, {4})", target, internalformat, pname, @params.Length, @params);
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
		public static void InvalidateFramebuffer(int target, params int[] attachments)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateFramebuffer != null, "pglInvalidateFramebuffer not implemented");
					Delegates.pglInvalidateFramebuffer(target, (Int32)attachments.Length, p_attachments);
					CallLog("glInvalidateFramebuffer({0}, {1}, {2})", target, attachments.Length, attachments);
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_invalidate_subdata")]
		public static void InvalidateSubFramebuffer(int target, int[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateSubFramebuffer != null, "pglInvalidateSubFramebuffer not implemented");
					Delegates.pglInvalidateSubFramebuffer(target, (Int32)attachments.Length, p_attachments, x, y, width, height);
					CallLog("glInvalidateSubFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, attachments.Length, attachments, x, y, width, height);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives from array data, taking parameters from memory
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect")]
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
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect")]
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
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect")]
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
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_multi_draw_indirect")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		public static void GetProgram(UInt32 program, int programInterface, UInt32 index, int[] props, out Int32 length, params Int32[] @params)
		{
			unsafe {
				fixed (int* p_props = props)
				fixed (Int32* p_length = &length)
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramResourceiv != null, "pglGetProgramResourceiv not implemented");
					Delegates.pglGetProgramResourceiv(program, programInterface, index, (Int32)props.Length, p_props, (Int32)@params.Length, p_length, p_params);
					CallLog("glGetProgramResourceiv({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", program, programInterface, index, props.Length, props, @params.Length, length, @params);
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_buffer_range")]
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
		/// GL_TEXTURE_2D_MULTISAMPLE or GL_PROXY_TEXTURE_2D_MULTISAMPLE.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_storage_multisample")]
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
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAY or GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_storage_multisample")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_texture_view")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public static void DebugMessageControl(int source, int type, int severity, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglDebugMessageControl != null) {
						Delegates.pglDebugMessageControl(source, type, severity, (Int32)ids.Length, p_ids, enabled);
						CallLog("glDebugMessageControl({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, ids.Length, ids, enabled);
					} else if (Delegates.pglDebugMessageControlARB != null) {
						Delegates.pglDebugMessageControlARB(source, type, severity, (Int32)ids.Length, p_ids, enabled);
						CallLog("glDebugMessageControlARB({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, ids.Length, ids, enabled);
					} else if (Delegates.pglDebugMessageControlKHR != null) {
						Delegates.pglDebugMessageControlKHR(source, type, severity, (Int32)ids.Length, p_ids, enabled);
						CallLog("glDebugMessageControlKHR({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, ids.Length, ids, enabled);
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		public static UInt32 GetDebugMessageLog(Int32 bufSize, int[] sources, int[] types, UInt32[] ids, int[] severities, Int32[] lengths, [Out] StringBuilder messageLog)
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
						retValue = Delegates.pglGetDebugMessageLog((UInt32)sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLog({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", sources.Length, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
					} else if (Delegates.pglGetDebugMessageLogARB != null) {
						retValue = Delegates.pglGetDebugMessageLogARB((UInt32)sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLogARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", sources.Length, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
					} else if (Delegates.pglGetDebugMessageLogKHR != null) {
						retValue = Delegates.pglGetDebugMessageLogKHR((UInt32)sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
						CallLog("glGetDebugMessageLogKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", sources.Length, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
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
