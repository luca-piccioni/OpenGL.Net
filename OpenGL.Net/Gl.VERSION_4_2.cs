
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
		/// Value of GL_COPY_READ_BUFFER_BINDING symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to COPY_READ_BUFFER.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COPY_READ_BUFFER_BINDING = 0x8F36;

		/// <summary>
		/// Value of GL_COPY_WRITE_BUFFER_BINDING symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to COPY_WRITE_BUFFER.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COPY_WRITE_BUFFER_BINDING = 0x8F37;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_ACTIVE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to TRANSFORM_FEEDBACK_BUFFER_ACTIVE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PAUSED symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to TRANSFORM_FEEDBACK_BUFFER_PAUSED.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int TRANSFORM_FEEDBACK_PAUSED = 0x8E23;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage")]
		public const int PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

		/// <summary>
		/// Value of GL_NUM_SAMPLE_COUNTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_internalformat_query")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int NUM_SAMPLE_COUNTS = 0x9380;

		/// <summary>
		/// Value of GL_MIN_MAP_BUFFER_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_map_buffer_alignment")]
		public const int MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_program_interface_query")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER = 0x92C0;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_START = 0x92C2;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;

		/// <summary>
		/// Value of GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;

		/// <summary>
		/// Value of GL_MAX_COMBINED_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;

		/// <summary>
		/// Value of GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;

		/// <summary>
		/// Value of GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

		/// <summary>
		/// Value of GL_ACTIVE_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

		/// <summary>
		/// Value of GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_ATOMIC_COUNTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public const int UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_UNIFORM_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint UNIFORM_BARRIER_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_TEXTURE_FETCH_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_ACCESS_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;

		/// <summary>
		/// Value of GL_COMMAND_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint COMMAND_BARRIER_BIT = 0x00000040;

		/// <summary>
		/// Value of GL_PIXEL_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;

		/// <summary>
		/// Value of GL_TEXTURE_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;

		/// <summary>
		/// Value of GL_BUFFER_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;

		/// <summary>
		/// Value of GL_ALL_BARRIER_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_MAX_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_IMAGE_UNITS = 0x8F38;

		/// <summary>
		/// Value of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object")]
		public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_NAME symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_NAME = 0x8F3A;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_LEVEL = 0x8F3B;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYERED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYERED = 0x8F3C;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYER = 0x8F3D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_ACCESS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_ACCESS = 0x8F3E;

		/// <summary>
		/// Value of GL_IMAGE_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_1D = 0x904C;

		/// <summary>
		/// Value of GL_IMAGE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_2D = 0x904D;

		/// <summary>
		/// Value of GL_IMAGE_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_3D = 0x904E;

		/// <summary>
		/// Value of GL_IMAGE_2D_RECT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_2D_RECT = 0x904F;

		/// <summary>
		/// Value of GL_IMAGE_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_CUBE = 0x9050;

		/// <summary>
		/// Value of GL_IMAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BUFFER = 0x9051;

		/// <summary>
		/// Value of GL_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_1D_ARRAY = 0x9052;

		/// <summary>
		/// Value of GL_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_2D_ARRAY = 0x9053;

		/// <summary>
		/// Value of GL_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_CUBE_MAP_ARRAY = 0x9054;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE = 0x9055;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_1D = 0x9057;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_2D = 0x9058;

		/// <summary>
		/// Value of GL_INT_IMAGE_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_3D = 0x9059;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_2D_RECT = 0x905A;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_CUBE = 0x905B;

		/// <summary>
		/// Value of GL_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_BUFFER = 0x905C;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_1D_ARRAY = 0x905D;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_2D_ARRAY = 0x905E;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE = 0x9060;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D = 0x9062;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D = 0x9063;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_3D = 0x9064;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE = 0x9066;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_BUFFER = 0x9067;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;

		/// <summary>
		/// Value of GL_MAX_IMAGE_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_IMAGE_SAMPLES = 0x906D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_BINDING_FORMAT = 0x906E;

		/// <summary>
		/// Value of GL_IMAGE_FORMAT_COMPATIBILITY_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

		/// <summary>
		/// Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;

		/// <summary>
		/// Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

		/// <summary>
		/// Value of GL_MAX_VERTEX_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;

		/// <summary>
		/// Value of GL_MAX_COMBINED_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public const int MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_BPTC_UNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		public const int COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

		/// <summary>
		/// Value of GL_TEXTURE_IMMUTABLE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage")]
		public const int TEXTURE_IMMUTABLE_FORMAT = 0x912F;

		/// <summary>
		/// Binding for glDrawArraysInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawArraysInstancedBaseInstance(int mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawArraysInstancedBaseInstance != null) {
				Delegates.pglDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
				CallLog("glDrawArraysInstancedBaseInstance({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			} else if (Delegates.pglDrawArraysInstancedBaseInstanceEXT != null) {
				Delegates.pglDrawArraysInstancedBaseInstanceEXT(mode, first, count, instancecount, baseinstance);
				CallLog("glDrawArraysInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			} else
				throw new NotImplementedException("glDrawArraysInstancedBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawArraysInstancedBaseInstance != null) {
				Delegates.pglDrawArraysInstancedBaseInstance((int)mode, first, count, instancecount, baseinstance);
				CallLog("glDrawArraysInstancedBaseInstance({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			} else if (Delegates.pglDrawArraysInstancedBaseInstanceEXT != null) {
				Delegates.pglDrawArraysInstancedBaseInstanceEXT((int)mode, first, count, instancecount, baseinstance);
				CallLog("glDrawArraysInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			} else
				throw new NotImplementedException("glDrawArraysInstancedBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseInstance(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawElementsInstancedBaseInstance != null) {
				Delegates.pglDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
				CallLog("glDrawElementsInstancedBaseInstance({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			} else if (Delegates.pglDrawElementsInstancedBaseInstanceEXT != null) {
				Delegates.pglDrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
				CallLog("glDrawElementsInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawElementsInstancedBaseInstance != null) {
				Delegates.pglDrawElementsInstancedBaseInstance((int)mode, count, type, indices, instancecount, baseinstance);
				CallLog("glDrawElementsInstancedBaseInstance({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			} else if (Delegates.pglDrawElementsInstancedBaseInstanceEXT != null) {
				Delegates.pglDrawElementsInstancedBaseInstanceEXT((int)mode, count, type, indices, instancecount, baseinstance);
				CallLog("glDrawElementsInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawElementsInstancedBaseVertexBaseInstance != null) {
				Delegates.pglDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
				CallLog("glDrawElementsInstancedBaseVertexBaseInstance({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT != null) {
				Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);
				CallLog("glDrawElementsInstancedBaseVertexBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseVertexBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			if        (Delegates.pglDrawElementsInstancedBaseVertexBaseInstance != null) {
				Delegates.pglDrawElementsInstancedBaseVertexBaseInstance((int)mode, count, type, indices, instancecount, basevertex, baseinstance);
				CallLog("glDrawElementsInstancedBaseVertexBaseInstance({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			} else if (Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT != null) {
				Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT((int)mode, count, type, indices, instancecount, basevertex, baseinstance);
				CallLog("glDrawElementsInstancedBaseVertexBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			} else
				throw new NotImplementedException("glDrawElementsInstancedBaseVertexBaseInstance (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			} finally {
				pin_indices.Free();
			}
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetInternalformativ and glGetInternalformati64v retrieve information about implementation-dependent support for 
		/// internal formats. target indicates the target with which the internal format will be used and must be one of 
		/// GL_RENDERBUFFER, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, corresponding to usage as a 
		/// renderbuffer, two-dimensional multisample texture or two-dimensional multisample array texture, respectively.
		/// internalformat specifies the internal format about which to retrieve information and must be a color-renderable, 
		/// depth-renderable or stencil-renderable format.
		/// The information retrieved will be written to memory addressed by the pointer specified in params. No more than bufSize 
		/// basic machine units will be written to this memory.
		/// If pname is GL_NUM_SAMPLE_COUNTS, the number of sample counts that would be returned by querying GL_SAMPLES will be 
		/// returned in params.
		/// If pname is GL_SAMPLES, the sample counts supported for internalformat and target are written into params in descending 
		/// numeric order. Only positive values are returned. Querying GL_SAMPLES with bufSize of one will return just the maximum 
		/// supported number of samples for this format. The maximum value in GL_SAMPLES is guaranteed to be at least the lowest of 
		/// the following: The value of GL_MAX_INTEGER_SAMPLES if internalformat is a signed or unsigned integer format. The value 
		/// of GL_MAX_DEPTH_TEXTURE_SAMPLES if internalformat is a depth- or stencil-renderable format and target is 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY. The value of GL_MAX_COLOR_TEXTURE_SAMPLES if internalformat 
		/// is a color-renderable format and target is GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. The value of 
		/// GL_MAX_SAMPLES.
		/// If pname is GL_INTERNALFORMAT_SUPPORTED, params is set to GL_TRUE if internalFormat is a supported internal format for 
		/// target and to GL_FALSE otherwise.
		/// If pname is GL_INTERNALFORMAT_PREFERRED, params is set to GL_TRUE if internalFormat is an format for target that is 
		/// preferred by the implementation and to GL_FALSE otherwise.
		/// If pname is GL_INTERNALFORMAT_RED_SIZE, GL_INTERNALFORMAT_GREEN_SIZE, GL_INTERNALFORMAT_BLUE_SIZE, 
		/// GL_INTERNALFORMAT_ALPHA_SIZE, GL_INTERNALFORMAT_DEPTH_SIZE, GL_INTERNALFORMAT_STENCIL_SIZE, or 
		/// GL_INTERNALFORMAT_SHARED_SIZE then params is set to the actual resolutions that would be used for storing image array 
		/// components for the resource for the red, green, blue, alpha, depth, stencil and shared channels respectively. If 
		/// internalFormat is a compressed internal format, then params is set to the component resolution of an uncompressed 
		/// internal format that produces an image of roughly the same quality as the compressed algorithm. If the internal format 
		/// is unsupported, or if a particular component is not present in the format, 0 is written to params.
		/// If pname is GL_INTERNALFORMAT_RED_TYPE, GL_INTERNALFORMAT_GREEN_TYPE, GL_INTERNALFORMAT_BLUE_TYPE, 
		/// GL_INTERNALFORMAT_ALPHA_TYPE, GL_INTERNALFORMAT_DEPTH_TYPE, or GL_INTERNALFORMAT_STENCIL_TYPE then params is set to a 
		/// token identifying the data type used to store the respective component. If the internalFormat represents a compressed 
		/// internal format then the types returned specify how components are interpreted after decompression.
		/// If pname is GL_MAX_WIDTH, GL_MAX_HEIGHT, GL_MAX_DEPTH, or GL_MAX_LAYERS then pname is filled with the maximum width, 
		/// height, depth or layer count for textures with internal format internalFormat, respectively. If pname is 
		/// GL_MAX_COMBINED_DIMENSIONS then pname is filled with the maximum combined dimensions of a texture of the specified 
		/// internal format.
		/// If pname is GL_COLOR_COMPONENTS then params is set to the value GL_TRUE if the internal format contains any color 
		/// component (i.e., red, green, blue or alpha) and to GL_FALSE otherwise. If pname is GL_DEPTH_COMPONENTS or 
		/// GL_STENCIL_COMPONENTS then params is set to GL_TRUE if the internal format contains a depth or stencil component, 
		/// respectively, and to GL_FALSE otherwise.
		/// If pname is GL_COLOR_RENDERABLE, GL_DEPTH_RENDERABLE or GL_STENCIL_RENDERABLE then params is set to GL_TRUE if the 
		/// specified internal format is color, depth or stencil renderable, respectively, and to GL_FALSE otherwise.
		/// If pname is GL_FRAMEBUFFER_RENDERABLE or GL_FRAMEBUFFER_RENDERABLE_LAYERED then params is set to one of GL_FULL_SUPPORT, 
		/// GL_CAVEAT_SUPPORT or GL_NONE to indicate that framebuffer attachments (layered attachments in the case of 
		/// GL_FRAMEBUFFER_RENDERABLE_LAYERED) with that internal format are either renderable with no restrictions, renderable with 
		/// some restrictions or not renderable at all.
		/// If pname is GL_FRAMEBUFFER_BLEND, params is set to GL_TRUE to indicate that the internal format is supported for 
		/// blending operations when attached to a framebuffer, and to GL_FALSE otherwise.
		/// If pname is GL_READ_PIXELS then params is set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to that either full 
		/// support, limited support or no support at all is supplied for reading pixels from framebuffer attachments in the 
		/// specified internal format.
		/// If pname is GL_READ_PIXELS_FORMAT or GL_READ_PIXELS_TYPE then params is filled with the format or type, respectively, 
		/// most recommended to obtain the highest image quality and performance. For GL_READ_PIXELS_FORMAT, the value returned in 
		/// params is a token that is accepted for the format argument to glReadPixels. For GL_READ_PIXELS_TYPE, the value returned 
		/// in params is a token that is accepted for the type argument to glReadPixels.
		/// If pname is GL_TEXTURE_IMAGE_FORMAT or GL_TEXTURE_IMAGE_TYPE then params is filled with the implementation-recommended 
		/// format or type to be used in calls to glTexImage2D and other similar functions. For GL_TEXTURE_IMAGE_FORMAT, params is 
		/// filled with a token suitable for use as the format argument to glTexImage2D. For GL_TEXTURE_IMAGE_TYPE, params is filled 
		/// with a token suitable for use as the type argument to glTexImage2D.
		/// If pname is GL_GET_TEXTURE_IMAGE_FORMAT or GL_GET_TEXTURE_IMAGE_TYPE then params is filled with the 
		/// implementation-recommended format or type to be used in calls to glGetTexImage2D and other similar functions. For 
		/// GL_GET_TEXTURE_IMAGE_FORMAT, params is filled with a token suitable for use as the format argument to glGetTexImage2D. 
		/// For GL_GET_TEXTURE_IMAGE_TYPE, params is filled with a token suitable for use as the type argument to glGetTexImage2D.
		/// If pname is GL_MIPMAP then pname is set to GL_TRUE to indicate that the specified internal format supports mipmaps and 
		/// to GL_FALSE otherwise.
		/// If pname is GL_GENERATE_MIPMAP or GL_AUTO_GENERATE_MIPMAP then params is indicates the level of support for manual or 
		/// automatic mipmap generation for the specified internal format, respectively. Returned values may be one of 
		/// GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT and GL_NONE to indicate either full support, limited support or no support at all.
		/// If pname is GL_COLOR_ENCODING then the color encoding for the resource is returned in params. Possible values for color 
		/// buffers are GL_LINEAR or GL_SRGB, for linear or sRGB-encoded color components, respectively. For non-color formats (such 
		/// as depth or stencil), or for unsupported resources, the value GL_NONE is returned.
		/// If pname is GL_SRGB_READ, or GL_SRGB_WRITE then params indicates the level of support for reading and writing to sRGB 
		/// encoded images, respectively. For GL_SRGB_READ, support for converting from sRGB colorspace on read operations is 
		/// returned in params and for GL_SRGB_WRITE, support for converting to sRGB colorspace on write operations to the resource 
		/// is returned in params. params may be set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, 
		/// limited support or no support at all, respecitively.
		/// If pname is GL_FILTER the params is set to either GL_TRUE or GL_FALSE to indicate support or lack thereof for filter 
		/// modes other than GL_NEAREST or GL_NEAREST_MIPMAP for the specified internal format.
		/// If pname is GL_VERTEX_TEXTURE, GL_TESS_CONTROL_TEXTURE, GL_TESS_EVALUATION_TEXTURE, GL_GEOMETRY_TEXTURE, 
		/// GL_FRAGMENT_TEXTURE, or GL_COMPUTE_TEXTURE, then the value written to params indicates support for use of the resource 
		/// as a source of texturing in the vertex, tessellation control, tessellation evaluation, geometry, fragment and compute 
		/// shader stages, respectively. params may be set to GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full 
		/// support, limited support or no support at all, respectively.
		/// If pname is GL_TEXTURE_SHADOW, GL_TEXTURE_GATHER or GL_TEXTURE_GATHER_SHADOW then the value written to params indicates 
		/// the level of support for using the resource with a shadow sampler, in gather operations or as a shadow sampler in gather 
		/// operations, respectively. Returned values may be GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full support, 
		/// limited support or no support at all, respectively.
		/// If pname is GL_SHADER_IMAGE_LOAD, GL_SHADER_IMAGE_STORE or GL_SHADER_IMAGE_ATOMIC then the value returned in params 
		/// indicates the level of support for image loads, stores and atomics for resources of the specified internal format. 
		/// Returned values may be GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT or GL_NONE to indicate full support, limited support or no 
		/// support at all, respectively.
		/// If pname is GL_IMAGE_TEXEL_SIZE then the size of a texel when the resource when used as an image texture is returned in 
		/// params. If the resource is not supported for image textures zero is returned.
		/// If pname is GL_IMAGE_COMPATIBILITY_CLASS then the compatibility class of the resource when used as an image texture is 
		/// returned in params. The possible values returned are GL_IMAGE_CLASS_4_X_32, GL_IMAGE_CLASS_2_X_32, 
		/// GL_IMAGE_CLASS_1_X_32, GL_IMAGE_CLASS_4_X_16, GL_IMAGE_CLASS_2_X_16, GL_IMAGE_CLASS_1_X_16, GL_IMAGE_CLASS_4_X_8, 
		/// GL_IMAGE_CLASS_2_X_8, GL_IMAGE_CLASS_1_X_8, GL_IMAGE_CLASS_11_11_10, and GL_IMAGE_CLASS_10_10_10_2, which correspond to 
		/// the 4x32, 2x32, 1x32, 4x16, 2x16, 1x16, 4x8, 2x8, 1x8, the class (a) 11/11/10 packed floating-point format, and the 
		/// class (b) 10/10/10/2 packed formats, respectively. If the resource is not supported for image textures, GL_NONE is 
		/// returned.
		/// If pname is GL_IMAGE_PIXEL_FORMAT or GL_IMAGE_PIXEL_TYPE then the pixel format or type of the resource when used as an 
		/// image texture is returned in params, respectively. In either case, the resource is not supported for image textures 
		/// GL_NONE is returned.
		/// If pname is GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, the matching criteria use for the resource when used as an image 
		/// textures is returned in params. Possible values returned in params are GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE or 
		/// GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS. If the resource is not supported for image textures, GL_NONE is returned.
		/// If pname is GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST or GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST, support for using the 
		/// resource both as a source for texture sampling while it is bound as a buffer for depth or stencil test, respectively, is 
		/// written to params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, 
		/// limited support or no support at all. If the resource or operation is not supported, GL_NONE is returned.
		/// If pname is GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE or GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE, support for using the 
		/// resource both as a source for texture sampling while performing depth or stencil writes to the resources, respectively, 
		/// is written to params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full 
		/// support, limited support or no support at all. If the resource or operation is not supported, GL_NONE is returned.
		/// If pname is GL_TEXTURE_COMPRESSED then GL_TRUE is returned in params if internalformat is a compressed internal format. 
		/// GL_FALSE is returned in params otherwise.
		/// If pname is GL_TEXTURE_COMPRESSED_BLOCK_WIDTH, GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT or GL_TEXTURE_COMPRESSED_BLOCK_SIZE 
		/// then the width, height or total size, respectively of a block (in basic machine units) is returned in params. If the 
		/// internal format is not compressed, or the resource is not supported, 0 is returned.
		/// If pname is GL_CLEAR_BUFFER, the level of support for using the resource with glClearBufferData and glClearBufferSubData 
		/// is returned in params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full 
		/// support, limited support or no support at all, respectively. If the resource or operation is not supported, GL_NONE is 
		/// returned.
		/// If pname is GL_TEXTURE_VIEW, the level of support for using the resource with the glTextureView command is returned in 
		/// params. Possible values returned are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to indicate full support, limited 
		/// support or no support at all, respectively. If the resource or operation is not supported, GL_NONE is returned.
		/// If pname is GL_VIEW_COMPATIBILITY_CLASS then the compatibility class of the resource when used as a texture view is 
		/// returned in params. The possible values returned are GL_VIEW_CLASS_128_BITS, GL_VIEW_CLASS_96_BITS, 
		/// GL_VIEW_CLASS_64_BITS, GL_VIEW_CLASS_48_BITS, GL_VIEW_CLASS_32_BITS, GL_VIEW_CLASS_24_BITS, GL_VIEW_CLASS_16_BITS, 
		/// GL_VIEW_CLASS_8_BITS, GL_VIEW_CLASS_S3TC_DXT1_RGB, GL_VIEW_CLASS_S3TC_DXT1_RGBA, GL_VIEW_CLASS_S3TC_DXT3_RGBA, 
		/// GL_VIEW_CLASS_S3TC_DXT5_RGBA, GL_VIEW_CLASS_RGTC1_RED, GL_VIEW_CLASS_RGTC2_RG, GL_VIEW_CLASS_BPTC_UNORM, and 
		/// GL_VIEW_CLASS_BPTC_FLOAT.
		/// If pname is GL_CLEAR_TEXTURE then the presence of support for using the glClearTexImage and glClearTexSubImage commands 
		/// with the resource is written to params. Possible values written are GL_FULL_SUPPORT, GL_CAVEAT_SUPPORT, or GL_NONE to 
		/// indicate full support, limited support or no support at all, respectively. If the resource or operation is not 
		/// supported, GL_NONE is returned.
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
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_internalformat_query")]
		public static void GetInternalformat(int target, int internalformat, int pname, Int32 bufSize, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformativ != null, "pglGetInternalformativ not implemented");
					Delegates.pglGetInternalformativ(target, internalformat, pname, bufSize, p_params);
					CallLog("glGetInternalformativ({0}, {1}, {2}, {3}, {4})", target, internalformat, pname, bufSize, @params);
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetActiveAtomicCounterBufferiv retrieves information about the set of active atomic counter buffers for a program 
		/// object. program is the name of a program object for which the command glLinkProgram has been issued in the past. It is 
		/// not necessary for program to have been linked successfully. The link may have failed because the number of active atomic 
		/// counters exceeded the limits.
		/// bufferIndex specifies the index of an active atomic counter buffer and must be in the range zero to the value of 
		/// GL_ACTIVE_ATOMIC_COUNTER_BUFFERS minus one. The value of GL_ACTIVE_ATOMIC_COUNTER_BUFFERS for program indicates the 
		/// number of active atomic counter buffer and can be queried with glGetProgram.
		/// If no error occurs, the parameter(s) specified by pname are returned in params. If an error is generated, the contents 
		/// of params are not modified.
		/// If pname is GL_ATOMIC_COUNTER_BUFFER_BINDING, then the index of the counter buffer binding point associated with the 
		/// active atomic counter buffer bufferIndex for program is returned.
		/// If pname is GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE, then the implementation-dependent minimum total buffer object size, in 
		/// baseic machine units, required to hold all active atomic counters in the atomic counter binding point identified by 
		/// bufferIndex is returned.
		/// If pname is GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS, then the number of active atomic counters for the atomic 
		/// counter buffer identified by bufferIndex is returned.
		/// If pname is GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES, then a list of the active atomic counter indices for 
		/// the atomic counter buffer identified by bufferIndex is returned. The number of elements that will be written into params 
		/// is the value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS for bufferIndex.
		/// If pname is GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER, 
		/// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER, 
		/// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER, GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER, 
		/// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER, GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER then a 
		/// boolean value indicating whether the atomic counter buffer identified by bufferIndex is referenced by the vertex, 
		/// tessellation control, tessellation evaluation, geometry, fragment or compute processing stages of program, respectively, 
		/// is returned.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of a program object for which glLinkProgram has been called in 
		///   the past.
		/// - GL_INVALID_VALUE is generated if bufferIndex is greater than or equal to the value of GL_ACTIVE_ATOMIC_COUNTER_BUFFERS 
		///   for program.
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted tokens.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters")]
		public static void GetActiveAtomicCounterBuffer(UInt32 program, UInt32 bufferIndex, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveAtomicCounterBufferiv != null, "pglGetActiveAtomicCounterBufferiv not implemented");
					Delegates.pglGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, p_params);
					CallLog("glGetActiveAtomicCounterBufferiv({0}, {1}, {2}, {3})", program, bufferIndex, pname, @params);
				}
			}
			DebugCheckErrors();
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
		/// If layered is GL_FALSE, specifies the layer of texture to be bound to the image unit. Ignored otherwise.
		/// </param>
		/// <param name="access">
		/// Specifies a token indicating the type of access that will be performed on the image.
		/// </param>
		/// <param name="format">
		/// Specifies the format that the elements of the image will be treated as for the purposes of formatted stores.
		/// </param>
		/// <remarks>
		/// glBindImageTexture binds a single level of a texture to an image unit for the purpose of reading and writing it from 
		/// shaders. unit specifies the zero-based index of the image unit to which to bind the texture level. texture specifies the 
		/// name of an existing texture object to bind to the image unit. If texture is zero, then any existing binding to the image 
		/// unit is broken. level specifies the level of the texture to bind to the image unit.
		/// If texture is the name of a one-, two-, or three-dimensional array texture, a cube map or cube map array texture, or a 
		/// two-dimensional multisample array texture, then it is possible to bind either the entire array, or only a single layer 
		/// of the array to the image unit. In such cases, if layered is GL_TRUE, the entire array is attached to the image unit and 
		/// layer is ignored. However, if layered is GL_FALSE then layer specifies the layer of the array to attach to the image 
		/// unit.
		/// access specifies the access types to be performed by shaders and may be set to GL_READ_ONLY, GL_WRITE_ONLY, or 
		/// GL_READ_WRITE to indicate read-only, write-only or read-write access, respectively. Violation of the access type 
		/// specified in access (for example, if a shader writes to an image bound with access set to GL_READ_ONLY) will lead to 
		/// undefined results, possibly including program termination.
		/// format specifies the format that is to be used when performing formatted stores into the image from shaders. format must 
		/// be compatible with the texture's internal format and must be one of the formats listed in the following table.
		/// Internal Image Formats Image Unit Format Format Qualifier 
		/// GL_RGBA32Frgba32fGL_RGBA16Frgba16fGL_RG32Frg32fGL_RG16Frg16fGL_R11F_G11F_B10Fr11f_g11f_b10fGL_R32Fr32fGL_R16Fr16fGL_RGBA32UIrgba32uiGL_RGBA16UIrgba16uiGL_RGB10_A2UIrgb10_a2uiGL_RGBA8UIrgba8uiGL_RG32UIrg32uiGL_RG16UIrg16uiGL_RG8UIrg8uiGL_R32UIr32uiGL_R16UIr16uiGL_R8UIr8uiGL_RGBA32Irgba32iGL_RGBA16Irgba16iGL_RGBA8Irgba8iGL_RG32Irg32iGL_RG16Irg16iGL_RG8Irg8iGL_R32Ir32iGL_R16Ir16iGL_R8Ir8iGL_RGBA16rgba16GL_RGB10_A2rgb10_a2GL_RGBA8rgba8GL_RG16rg16GL_RG8rg8GL_R16r16GL_R8r8GL_RGBA16_SNORMrgba16_snormGL_RGBA8_SNORMrgba8_snormGL_RG16_SNORMrg16_snormGL_RG8_SNORMrg8_snormGL_R16_SNORMr16_snormGL_R8_SNORMr8_snorm
		/// When a texture is bound to an image unit, the format parameter for the image unit need not exactly match the texture 
		/// internal format as long as the formats are considered compatible as defined in the OpenGL Specification. The matching 
		/// criterion used for a given texture may be determined by calling glGetTexParameter with value set to 
		/// GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, with return values of GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE and 
		/// GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS, specifying matches by size and class, respectively.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if unit greater than or equal to the value of GL_MAX_IMAGE_UNITS.
		/// - GL_INVALID_VALUE is generated if texture is not the name of an existing texture object.
		/// - GL_INVALID_VALUE is generated if level or layer is less than zero.
		/// - GL_INVALID_ENUM is generated if access or format is not one of the supported tokens.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_IMAGE_BINDING_NAME.
		/// - glGet with argument GL_IMAGE_BINDING_LEVEL.
		/// - glGet with argument GL_IMAGE_BINDING_LAYERED.
		/// - glGet with argument GL_IMAGE_BINDING_LAYER.
		/// - glGet with argument GL_IMAGE_BINDING_ACCESS.
		/// - glGet with argument GL_IMAGE_BINDING_FORMAT.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.BindTexture"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, int access, int format)
		{
			Debug.Assert(Delegates.pglBindImageTexture != null, "pglBindImageTexture not implemented");
			Delegates.pglBindImageTexture(unit, texture, level, layered, layer, access, format);
			CallLog("glBindImageTexture({0}, {1}, {2}, {3}, {4}, {5}, {6})", unit, texture, level, layered, layer, access, format);
			DebugCheckErrors();
		}

		/// <summary>
		/// defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="barriers">
		/// Specifies the barriers to insert.
		/// </param>
		/// <remarks>
		/// glMemoryBarrier defines a barrier ordering the memory transactions issued prior to the command relative to those issued 
		/// after the barrier. For the purposes of this ordering, memory transactions performed by shaders are considered to be 
		/// issued by the rendering command that triggered the execution of the shader. barriers is a bitfield indicating the set of 
		/// operations that are synchronized with shader stores; the bits used in barriers are as follows:
		/// GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT If set, vertex data sourced from buffer objects after the barrier will reflect data 
		/// written by shaders prior to the barrier. The set of buffer objects affected by this bit is derived from the buffer 
		/// object bindings used for generic vertex attributes derived from the GL_VERTEX_ATTRIB_ARRAY_BUFFER bindings. 
		/// GL_ELEMENT_ARRAY_BARRIER_BIT If set, vertex array indices sourced from buffer objects after the barrier will reflect 
		/// data written by shaders prior to the barrier. The buffer objects affected by this bit are derived from the 
		/// GL_ELEMENT_ARRAY_BUFFER binding. GL_UNIFORM_BARRIER_BIT Shader uniforms sourced from buffer objects after the barrier 
		/// will reflect data written by shaders prior to the barrier. GL_TEXTURE_FETCH_BARRIER_BIT Texture fetches from shaders, 
		/// including fetches from buffer object memory via buffer textures, after the barrier will reflect data written by shaders 
		/// prior to the barrier. GL_SHADER_IMAGE_ACCESS_BARRIER_BIT Memory accesses using shader image load, store, and atomic 
		/// built-in functions issued after the barrier will reflect data written by shaders prior to the barrier. Additionally, 
		/// image stores and atomics issued after the barrier will not execute until all memory accesses (e.g., loads, stores, 
		/// texture fetches, vertex fetches) initiated prior to the barrier complete. GL_COMMAND_BARRIER_BIT Command data sourced 
		/// from buffer objects by Draw*Indirect commands after the barrier will reflect data written by shaders prior to the 
		/// barrier. The buffer objects affected by this bit are derived from the GL_DRAW_INDIRECT_BUFFER binding. 
		/// GL_PIXEL_BUFFER_BARRIER_BIT Reads and writes of buffer objects via the GL_PIXEL_PACK_BUFFER and GL_PIXEL_UNPACK_BUFFER 
		/// bindings (via glReadPixels, glTexSubImage, etc.) after the barrier will reflect data written by shaders prior to the 
		/// barrier. Additionally, buffer object writes issued after the barrier will wait on the completion of all shader writes 
		/// initiated prior to the barrier. GL_TEXTURE_UPDATE_BARRIER_BIT Writes to a texture via glTex(Sub)Image*, 
		/// glCopyTex(Sub)Image*, glCompressedTex(Sub)Image*, and reads via glGetTexImage after the barrier will reflect data 
		/// written by shaders prior to the barrier. Additionally, texture writes from these commands issued after the barrier will 
		/// not execute until all shader writes initiated prior to the barrier complete. GL_BUFFER_UPDATE_BARRIER_BIT Reads or 
		/// writes via glBufferSubData, glCopyBufferSubData, or glGetBufferSubData, or to buffer object memory mapped by glMapBuffer 
		/// or glMapBufferRange after the barrier will reflect data written by shaders prior to the barrier. Additionally, writes 
		/// via these commands issued after the barrier will wait on the completion of any shader writes to the same memory 
		/// initiated prior to the barrier. GL_FRAMEBUFFER_BARRIER_BIT Reads and writes via framebuffer object attachments after the 
		/// barrier will reflect data written by shaders prior to the barrier. Additionally, framebuffer writes issued after the 
		/// barrier will wait on the completion of all shader writes issued prior to the barrier. GL_TRANSFORM_FEEDBACK_BARRIER_BIT 
		/// Writes via transform feedback bindings after the barrier will reflect data written by shaders prior to the barrier. 
		/// Additionally, transform feedback writes issued after the barrier will wait on the completion of all shader writes issued 
		/// prior to the barrier. GL_ATOMIC_COUNTER_BARRIER_BIT Accesses to atomic counters after the barrier will reflect writes 
		/// prior to the barrier. GL_SHADER_STORAGE_BARRIER_BIT Accesses to shader storage blocks after the barrier will reflect 
		/// writes prior to the barrier. GL_QUERY_BUFFER_BARRIER_BIT Writes of buffer objects via the GL_QUERY_BUFFER binding after 
		/// the barrier will reflect data written by shaders prior to the barrier. Additionally, buffer object writes issued after 
		/// the barrier will wait on the completion of all shader writes initiated prior to the barrier.
		/// If barriers is GL_ALL_BARRIER_BITS, shader memory accesses will be synchronized relative to all the operations described 
		/// above.
		/// Implementations may cache buffer object and texture image memory that could be written by shaders in multiple caches; 
		/// for example, there may be separate caches for texture, vertex fetching, and one or more caches for shader memory 
		/// accesses. Implementations are not required to keep these caches coherent with shader memory writes. Stores issued by one 
		/// invocation may not be immediately observable by other pipeline stages or other shader invocations because the value 
		/// stored may remain in a cache local to the processor executing the store, or because data overwritten by the store is 
		/// still in a cache elsewhere in the system. When glMemoryBarrier is called, the GL flushes and/or invalidates any caches 
		/// relevant to the operations specified by the barriers parameter to ensure consistent ordering of operations across the 
		/// barrier.
		/// To allow for independent shader invocations to communicate by reads and writes to a common memory address, image 
		/// variables in the OpenGL Shading Language may be declared as "coherent". Buffer object or texture image memory accessed 
		/// through such variables may be cached only if caches are automatically updated due to stores issued by any other shader 
		/// invocation. If the same address is accessed using both coherent and non-coherent variables, the accesses using variables 
		/// declared as coherent will observe the results stored using coherent variables in other invocations. Using variables 
		/// declared as "coherent" guarantees only that the results of stores will be immediately visible to shader invocations 
		/// using similarly-declared variables; calling glMemoryBarrier is required to ensure that the stores are visible to other 
		/// operations.
		/// The following guidelines may be helpful in choosing when to use coherent memory accesses and when to use barriers.
		/// Data that are read-only or constant may be accessed without using coherent variables or calling MemoryBarrier(). Updates 
		/// to the read-only data via API calls such as glBufferSubData will invalidate shader caches implicitly as required. Data 
		/// that are shared between shader invocations at a fine granularity (e.g., written by one invocation, consumed by another 
		/// invocation) should use coherent variables to read and write the shared data. Data written by one shader invocation and 
		/// consumed by other shader invocations launched as a result of its execution ("dependent invocations") should use coherent 
		/// variables in the producing shader invocation and call memoryBarrier() after the last write. The consuming shader 
		/// invocation should also use coherent variables. Data written to image variables in one rendering pass and read by the 
		/// shader in a later pass need not use coherent variables or memoryBarrier(). Calling glMemoryBarrier with the 
		/// SHADER_IMAGE_ACCESS_BARRIER_BIT set in barriers between passes is necessary. Data written by the shader in one rendering 
		/// pass and read by another mechanism (e.g., vertex or index buffer pulling) in a later pass need not use coherent 
		/// variables or memoryBarrier(). Calling glMemoryBarrier with the appropriate bits set in barriers between passes is 
		/// necessary.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if barriers is not the special value GL_ALL_BARRIER_BITS, and has any bits set other than 
		///   those described above for glMemoryBarrier or glMemoryBarrierByRegion respectively.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindImageTexture"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.moryBarrier"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store")]
		public static void MemoryBarrier(uint barriers)
		{
			if        (Delegates.pglMemoryBarrier != null) {
				Delegates.pglMemoryBarrier(barriers);
				CallLog("glMemoryBarrier({0})", barriers);
			} else if (Delegates.pglMemoryBarrierEXT != null) {
				Delegates.pglMemoryBarrierEXT(barriers);
				CallLog("glMemoryBarrierEXT({0})", barriers);
			} else
				throw new NotImplementedException("glMemoryBarrier (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage")]
		public static void TexStorage1D(int target, Int32 levels, int internalformat, Int32 width)
		{
			if        (Delegates.pglTexStorage1D != null) {
				Delegates.pglTexStorage1D(target, levels, internalformat, width);
				CallLog("glTexStorage1D({0}, {1}, {2}, {3})", target, levels, internalformat, width);
			} else if (Delegates.pglTexStorage1DEXT != null) {
				Delegates.pglTexStorage1DEXT(target, levels, internalformat, width);
				CallLog("glTexStorage1DEXT({0}, {1}, {2}, {3})", target, levels, internalformat, width);
			} else
				throw new NotImplementedException("glTexStorage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage")]
		public static void TexStorage2D(int target, Int32 levels, int internalformat, Int32 width, Int32 height)
		{
			if        (Delegates.pglTexStorage2D != null) {
				Delegates.pglTexStorage2D(target, levels, internalformat, width, height);
				CallLog("glTexStorage2D({0}, {1}, {2}, {3}, {4})", target, levels, internalformat, width, height);
			} else if (Delegates.pglTexStorage2DEXT != null) {
				Delegates.pglTexStorage2DEXT(target, levels, internalformat, width, height);
				CallLog("glTexStorage2DEXT({0}, {1}, {2}, {3}, {4})", target, levels, internalformat, width, height);
			} else
				throw new NotImplementedException("glTexStorage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage3D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage")]
		public static void TexStorage3D(int target, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth)
		{
			if        (Delegates.pglTexStorage3D != null) {
				Delegates.pglTexStorage3D(target, levels, internalformat, width, height, depth);
				CallLog("glTexStorage3D({0}, {1}, {2}, {3}, {4}, {5})", target, levels, internalformat, width, height, depth);
			} else if (Delegates.pglTexStorage3DEXT != null) {
				Delegates.pglTexStorage3DEXT(target, levels, internalformat, width, height, depth);
				CallLog("glTexStorage3DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, levels, internalformat, width, height, depth);
			} else
				throw new NotImplementedException("glTexStorage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackInstanced draws multiple copies of a range of primitives of a type specified by mode using a 
		/// count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. 
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawArraysInstanced with mode and primcount as 
		/// specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time 
		/// transform feedback was active on the transform feedback object named by id.
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawTransformFeedbackStreamInstanced with stream set 
		/// to zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object.
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active.
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   named by id was bound.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStreamInstanced"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced")]
		public static void DrawTransformFeedbackInstanced(int mode, UInt32 id, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackInstanced != null, "pglDrawTransformFeedbackInstanced not implemented");
			Delegates.pglDrawTransformFeedbackInstanced(mode, id, instancecount);
			CallLog("glDrawTransformFeedbackInstanced({0}, {1}, {2})", mode, id, instancecount);
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackInstanced draws multiple copies of a range of primitives of a type specified by mode using a 
		/// count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. 
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawArraysInstanced with mode and primcount as 
		/// specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time 
		/// transform feedback was active on the transform feedback object named by id.
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawTransformFeedbackStreamInstanced with stream set 
		/// to zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object.
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active.
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   named by id was bound.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStreamInstanced"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced")]
		public static void DrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackInstanced != null, "pglDrawTransformFeedbackInstanced not implemented");
			Delegates.pglDrawTransformFeedbackInstanced((int)mode, id, instancecount);
			CallLog("glDrawTransformFeedbackInstanced({0}, {1}, {2})", mode, id, instancecount);
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackStreamInstanced draws multiple copies of a range of primitives of a type specified by mode using 
		/// a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by 
		/// id. Calling glDrawTransformFeedbackStreamInstanced is equivalent to calling glDrawArraysInstanced with mode and 
		/// primcount as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the 
		/// last time transform feedback was active on the transform feedback object named by id.
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawTransformFeedbackStreamInstanced with stream set 
		/// to zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object.
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active.
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   named by id was bound.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced")]
		public static void DrawTransformFeedbackStreamInstanced(int mode, UInt32 id, UInt32 stream, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStreamInstanced != null, "pglDrawTransformFeedbackStreamInstanced not implemented");
			Delegates.pglDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
			CallLog("glDrawTransformFeedbackStreamInstanced({0}, {1}, {2}, {3})", mode, id, stream, instancecount);
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawTransformFeedbackStreamInstanced draws multiple copies of a range of primitives of a type specified by mode using 
		/// a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by 
		/// id. Calling glDrawTransformFeedbackStreamInstanced is equivalent to calling glDrawArraysInstanced with mode and 
		/// primcount as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the 
		/// last time transform feedback was active on the transform feedback object named by id.
		/// Calling glDrawTransformFeedbackInstanced is equivalent to calling glDrawTransformFeedbackStreamInstanced with stream set 
		/// to zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if id is not the name of a transform feedback object.
		/// - GL_INVALID_VALUE is generated if stream is greater than or equal to the value of GL_MAX_VERTEX_STREAMS.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if mode is GL_PATCHES and no tessellation control shader is active.
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback has never been called while the transform feedback object 
		///   named by id was bound.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced")]
		public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStreamInstanced != null, "pglDrawTransformFeedbackStreamInstanced not implemented");
			Delegates.pglDrawTransformFeedbackStreamInstanced((int)mode, id, stream, instancecount);
			CallLog("glDrawTransformFeedbackStreamInstanced({0}, {1}, {2}, {3})", mode, id, stream, instancecount);
			DebugCheckErrors();
		}

	}

}
