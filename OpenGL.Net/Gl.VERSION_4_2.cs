
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
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

		/// <summary>
		/// Value of GL_NUM_SAMPLE_COUNTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int NUM_SAMPLE_COUNTS = 0x9380;

		/// <summary>
		/// Gl.Get: data returns one value, the minimum alignment in basic machine units of pointers returned fromGl.MapBuffer and 
		/// Gl.MapBufferRange. This value must be a power of two and must be at least 64.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_map_buffer_alignment", Api = "gl|glcore")]
		public const int MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

		/// <summary>
		/// Gl.GetProgramInterface: the query is targeted at the set of active atomic counter buffer binding points within program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER = 0x92C0;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_START = 0x92C2;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;

		/// <summary>
		/// Value of GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to vertex shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation control shaders.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation evaluation shaders.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to geometry shaders.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to fragment shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;

		/// <summary>
		/// Gl.Get: data returns a single value, the maximum number of atomic counters available to all active shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;

		/// <summary>
		/// Value of GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;

		/// <summary>
		/// Value of GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

		/// <summary>
		/// Gl.GetProgram: params returns the number of active attribute atomic counter buffers used by program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

		/// <summary>
		/// Value of GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_ATOMIC_COUNTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_UNIFORM_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_UNIFORM_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint UNIFORM_BARRIER_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_TEXTURE_FETCH_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_ACCESS_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;

		/// <summary>
		/// Value of GL_COMMAND_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_COMMAND_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint COMMAND_BARRIER_BIT = 0x00000040;

		/// <summary>
		/// Value of GL_PIXEL_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;

		/// <summary>
		/// Value of GL_TEXTURE_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;

		/// <summary>
		/// Value of GL_BUFFER_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;

		/// <summary>
		/// Value of GL_ALL_BARRIER_BITS symbol.
		/// </summary>
		[AliasOf("GL_ALL_BARRIER_BITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_MAX_IMAGE_UNITS symbol.
		/// </summary>
		[AliasOf("GL_MAX_IMAGE_UNITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_UNITS = 0x8F38;

		/// <summary>
		/// Value of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_NAME symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_NAME_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_NAME = 0x8F3A;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LEVEL_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LEVEL = 0x8F3B;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYERED symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LAYERED_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYERED = 0x8F3C;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYER symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LAYER_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYER = 0x8F3D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_ACCESS symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_ACCESS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_ACCESS = 0x8F3E;

		/// <summary>
		/// Value of GL_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D = 0x904C;

		/// <summary>
		/// Value of GL_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D = 0x904D;

		/// <summary>
		/// Value of GL_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_3D = 0x904E;

		/// <summary>
		/// Value of GL_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_RECT = 0x904F;

		/// <summary>
		/// Value of GL_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_CUBE = 0x9050;

		/// <summary>
		/// Value of GL_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int IMAGE_BUFFER = 0x9051;

		/// <summary>
		/// Value of GL_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D_ARRAY = 0x9052;

		/// <summary>
		/// Value of GL_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_ARRAY = 0x9053;

		/// <summary>
		/// Value of GL_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int IMAGE_CUBE_MAP_ARRAY = 0x9054;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE = 0x9055;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D = 0x9057;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D = 0x9058;

		/// <summary>
		/// Value of GL_INT_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_3D = 0x9059;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_RECT = 0x905A;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_CUBE = 0x905B;

		/// <summary>
		/// Value of GL_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_INT_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int INT_IMAGE_BUFFER = 0x905C;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D_ARRAY = 0x905D;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_ARRAY = 0x905E;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE = 0x9060;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D = 0x9062;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D = 0x9063;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_3D = 0x9064;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE = 0x9066;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int UNSIGNED_INT_IMAGE_BUFFER = 0x9067;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;

		/// <summary>
		/// Value of GL_MAX_IMAGE_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_MAX_IMAGE_SAMPLES_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_SAMPLES = 0x906D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_FORMAT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_FORMAT = 0x906E;

		/// <summary>
		/// Gl.GetTexParameter: returns the matching criteria use for the texture when used as an image texture. Can return 
		/// Gl.IMAGE_FORMAT_COMPATIBILITY_BY_SIZE, Gl.IMAGE_FORMAT_COMPATIBILITY_BY_CLASS or Gl.NONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

		/// <summary>
		/// Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;

		/// <summary>
		/// Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

		/// <summary>
		/// Value of GL_MAX_VERTEX_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_IMAGE_UNIFORMS symbol.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;

		/// <summary>
		/// Value of GL_MAX_COMBINED_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_BPTC_UNORM symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

		/// <summary>
		/// Gl.GetTexParameter: returns non-zero if the texture has an immutable format. Textures become immutable if their storage 
		/// is specified with Gl.TexStorage1D, Gl.TexStorage2D or Gl.TexStorage3D. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int TEXTURE_IMMUTABLE_FORMAT = 0x912F;

		/// <summary>
		/// draw multiple instances of a range of elements with offset applied to instanced attributes
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLESGl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the specified range of indices to be rendered.
		/// </param>
		/// <param name="baseinstance">
		/// Specifies the base instance for use in fetching instanced vertex attributes.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		[AliasOf("glDrawArraysInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedBaseInstance != null, "pglDrawArraysInstancedBaseInstance not implemented");
			Delegates.pglDrawArraysInstancedBaseInstance((Int32)mode, first, count, primcount, baseinstance);
			LogFunction("glDrawArraysInstancedBaseInstance({0}, {1}, {2}, {3}, {4})", mode, first, count, primcount, baseinstance);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw multiple instances of a set of elements with offset applied to instanced attributes
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the specified range of indices to be rendered.
		/// </param>
		/// <param name="baseinstance">
		/// Specifies the base instance for use in fetching instanced vertex attributes.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, or Gl.TRIANGLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseInstance != null, "pglDrawElementsInstancedBaseInstance not implemented");
			Delegates.pglDrawElementsInstancedBaseInstance((Int32)mode, count, type, indices, primcount, baseinstance);
			LogFunction("glDrawElementsInstancedBaseInstance({0}, {1}, {2}, 0x{3}, {4}, {5})", mode, count, LogEnumName(type), indices.ToString("X8"), primcount, baseinstance);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw multiple instances of a set of elements with offset applied to instanced attributes
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the specified range of indices to be rendered.
		/// </param>
		/// <param name="baseinstance">
		/// Specifies the base instance for use in fetching instanced vertex attributes.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, or Gl.TRIANGLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, Int32 type, Object indices, Int32 primcount, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, baseinstance);
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
		/// <param name="primcount">
		/// Specifies the number of instances of the indexed geometry that should be drawn.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <param name="baseinstance">
		/// Specifies the base instance for use in fetching instanced vertex attributes.
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
		[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexBaseInstance != null, "pglDrawElementsInstancedBaseVertexBaseInstance not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexBaseInstance((Int32)mode, count, type, indices, primcount, basevertex, baseinstance);
			LogFunction("glDrawElementsInstancedBaseVertexBaseInstance({0}, {1}, {2}, 0x{3}, {4}, {5}, {6})", mode, count, LogEnumName(type), indices.ToString("X8"), primcount, basevertex, baseinstance);
			DebugCheckErrors(null);
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
		/// <param name="primcount">
		/// Specifies the number of instances of the indexed geometry that should be drawn.
		/// </param>
		/// <param name="basevertex">
		/// Specifies a constant that should be added to each element of <paramref name="indices"/> when chosing elements from the 
		/// enabled vertex arrays.
		/// </param>
		/// <param name="baseinstance">
		/// Specifies the base instance for use in fetching instanced vertex attributes.
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
		[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, Int32 type, Object indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex, baseinstance);
			} finally {
				pin_indices.Free();
			}
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
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
		public static void GetInternalformat(Int32 target, Int32 internalformat, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformativ != null, "pglGetInternalformativ not implemented");
					Delegates.pglGetInternalformativ(target, internalformat, pname, (Int32)@params.Length, p_params);
					LogFunction("glGetInternalformativ({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(internalformat), LogEnumName(pname), @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about the set of active atomic counter buffers for a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object from which to retrieve information.
		/// </param>
		/// <param name="bufferIndex">
		/// Specifies index of an active atomic counter buffer.
		/// </param>
		/// <param name="pname">
		/// Specifies which parameter of the atomic counter buffer to retrieve.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable into which to write the retrieved information.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object for which glLinkProgram 
		/// has been called in the past.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufferIndex"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS for <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public static void GetActiveAtomicCounterBuffer(UInt32 program, UInt32 bufferIndex, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveAtomicCounterBufferiv != null, "pglGetActiveAtomicCounterBufferiv not implemented");
					Delegates.pglGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, p_params);
					LogFunction("glGetActiveAtomicCounterBufferiv({0}, {1}, {2}, {3})", program, bufferIndex, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a level of a texture to an image unit
		/// </summary>
		/// <param name="unit">
		/// Specifies the index of the image unit to which to bind the texture
		/// </param>
		/// <param name="texture">
		/// Specifies the name of the texture to bind to the image unit.
		/// </param>
		/// <param name="level">
		/// Specifies the level of the texture that is to be bound.
		/// </param>
		/// <param name="layered">
		/// Specifies whether a layered texture binding is to be established.
		/// </param>
		/// <param name="layer">
		/// If <paramref name="layered"/> is Gl.FALSE, specifies the layer of <paramref name="texture"/> to be bound to the image 
		/// unit. Ignored otherwise.
		/// </param>
		/// <param name="access">
		/// Specifies a token indicating the type of access that will be performed on the image.
		/// </param>
		/// <param name="format">
		/// Specifies the format that the elements of the image will be treated as for the purposes of formatted stores.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="unit"/> greater than or equal to the value of Gl.MAX_IMAGE_UNITS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> or <paramref name="layer"/> is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="access"/> or <paramref name="format"/> is not one of the supported 
		/// tokens.
		/// </exception>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.BindTexture"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format)
		{
			Debug.Assert(Delegates.pglBindImageTexture != null, "pglBindImageTexture not implemented");
			Delegates.pglBindImageTexture(unit, texture, level, layered, layer, access, format);
			LogFunction("glBindImageTexture({0}, {1}, {2}, {3}, {4}, {5}, {6})", unit, texture, level, layered, layer, LogEnumName(access), LogEnumName(format));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="barriers">
		/// Specifies the barriers to insert.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="barriers"/> is not the special value Gl.ALL_BARRIER_BITS, and has any 
		/// bits set other than those described above for Gl.MemoryBarrier or Gl.MemoryBarrierByRegion respectively.
		/// </exception>
		/// <seealso cref="Gl.BindImageTexture"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.moryBarrier"/>
		[AliasOf("glMemoryBarrierEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public static void MemoryBarrier(UInt32 barriers)
		{
			Debug.Assert(Delegates.pglMemoryBarrier != null, "pglMemoryBarrier not implemented");
			Delegates.pglMemoryBarrier(barriers);
			LogFunction("glMemoryBarrier({0})", barriers);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// simultaneously specify storage for all levels of a one-dimensional texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexStorage1D. Must be one of Gl.TEXTURE_1D or 
		/// Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="levels">
		/// Specify the number of texture levels.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the sized internal format to be used to store texture image data.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture, in texels.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage1D if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid sized internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="levels"/> are less than 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="levels"/> is greater than log2width+1.
		/// </exception>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[AliasOf("glTexStorage1DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTexStorage1D != null, "pglTexStorage1D not implemented");
			Delegates.pglTexStorage1D(target, levels, internalformat, width);
			LogFunction("glTexStorage1D({0}, {1}, {2}, {3})", LogEnumName(target), levels, LogEnumName(internalformat), width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// simultaneously specify storage for all levels of a two-dimensional or one-dimensional array texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexStorage2D. Must be one of Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_RECTANGLE, 
		/// or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="levels">
		/// Specify the number of texture levels.
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage2D if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid sized internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/> or <paramref name="levels"/> are 
		/// less than 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is Gl.TEXTURE_1D_ARRAY or Gl.PROXY_TEXTURE_1D_ARRAY and 
		/// <paramref name="levels"/> is greater than log2width+1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not Gl.TEXTURE_1D_ARRAY or Gl.PROXY_TEXTURE_1D_ARRAY 
		/// and <paramref name="levels"/> is greater than log2maxwidth, height+1.
		/// </exception>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[AliasOf("glTexStorage2DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTexStorage2D != null, "pglTexStorage2D not implemented");
			Delegates.pglTexStorage2D(target, levels, internalformat, width, height);
			LogFunction("glTexStorage2D({0}, {1}, {2}, {3}, {4})", LogEnumName(target), levels, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// simultaneously specify storage for all levels of a three-dimensional, two-dimensional array or cube-map array texture
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.TexStorage3D. Must be one of Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_CUBE_ARRAY, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_2D_ARRAY or 
		/// Gl.PROXY_TEXTURE_CUBE_ARRAY.
		/// </param>
		/// <param name="levels">
		/// Specify the number of texture levels.
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
		/// Specifies the depth of the texture, in texels.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage3D if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage3D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid sized internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, <paramref name="depth"/> or 
		/// <paramref name="levels"/> are less than 1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D and <paramref 
		/// name="levels"/> is greater than log2maxwidth, height, depth+1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is Gl.TEXTURE_2D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.TEXURE_CUBE_ARRAY, or Gl.PROXY_TEXTURE_CUBE_MAP_ARRAY and <paramref name="levels"/> is greater than 
		/// log2maxwidth, height+1.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		[AliasOf("glTexStorage3DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTexStorage3D != null, "pglTexStorage3D not implemented");
			Delegates.pglTexStorage3D(target, levels, internalformat, width, height, depth);
			LogFunction("glTexStorage3D({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), levels, LogEnumName(internalformat), width, height, depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the geometry to render.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stream"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_STREAMS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStreamInstanced"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
		public static void DrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackInstanced != null, "pglDrawTransformFeedbackInstanced not implemented");
			Delegates.pglDrawTransformFeedbackInstanced((Int32)mode, id, primcount);
			LogFunction("glDrawTransformFeedbackInstanced({0}, {1}, {2})", mode, id, primcount);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the geometry to render.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stream"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_STREAMS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
		public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStreamInstanced != null, "pglDrawTransformFeedbackStreamInstanced not implemented");
			Delegates.pglDrawTransformFeedbackStreamInstanced((Int32)mode, id, stream, primcount);
			LogFunction("glDrawTransformFeedbackStreamInstanced({0}, {1}, {2}, {3})", mode, id, stream, primcount);
			DebugCheckErrors(null);
		}

	}

}
