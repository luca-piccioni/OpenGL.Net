
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
		/// A <see cref="T:PrimitiveType"/>.
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
		/// A <see cref="T:PrimitiveType"/>.
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
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Object"/>.
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
		/// A <see cref="T:PrimitiveType"/>.
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
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Object"/>.
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
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_internalformat_query")]
		public static void GetInternalformat(int target, int internalformat, int pname, params Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformativ != null, "pglGetInternalformativ not implemented");
					Delegates.pglGetInternalformativ(target, internalformat, pname, (Int32)@params.Length, p_params);
					CallLog("glGetInternalformativ({0}, {1}, {2}, {3}, {4})", target, internalformat, pname, @params.Length, @params);
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
