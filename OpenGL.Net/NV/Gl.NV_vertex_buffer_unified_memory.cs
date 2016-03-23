
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
		/// Value of GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int VERTEX_ARRAY_ADDRESS_NV = 0x8F21;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int NORMAL_ARRAY_ADDRESS_NV = 0x8F22;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int COLOR_ARRAY_ADDRESS_NV = 0x8F23;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int INDEX_ARRAY_ADDRESS_NV = 0x8F24;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int VERTEX_ARRAY_LENGTH_NV = 0x8F2B;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int NORMAL_ARRAY_LENGTH_NV = 0x8F2C;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int COLOR_ARRAY_LENGTH_NV = 0x8F2D;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int INDEX_ARRAY_LENGTH_NV = 0x8F2E;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int ELEMENT_ARRAY_LENGTH_NV = 0x8F33;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int DRAW_INDIRECT_UNIFIED_NV = 0x8F40;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int DRAW_INDIRECT_ADDRESS_NV = 0x8F41;

		/// <summary>
		/// Value of GL_DRAW_INDIRECT_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public const int DRAW_INDIRECT_LENGTH_NV = 0x8F42;

		/// <summary>
		/// Binding for glBufferAddressRangeNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="address">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void BufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length)
		{
			Debug.Assert(Delegates.pglBufferAddressRangeNV != null, "pglBufferAddressRangeNV not implemented");
			Delegates.pglBufferAddressRangeNV(pname, index, address, length);
			LogFunction("glBufferAddressRangeNV({0}, {1}, {2}, {3})", LogEnumName(pname), index, address, length);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void VertexFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexFormatNV != null, "pglVertexFormatNV not implemented");
			Delegates.pglVertexFormatNV(size, type, stride);
			LogFunction("glVertexFormatNV({0}, {1}, {2})", size, LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void NormalFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglNormalFormatNV != null, "pglNormalFormatNV not implemented");
			Delegates.pglNormalFormatNV(type, stride);
			LogFunction("glNormalFormatNV({0}, {1})", LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void ColorFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglColorFormatNV != null, "pglColorFormatNV not implemented");
			Delegates.pglColorFormatNV(size, type, stride);
			LogFunction("glColorFormatNV({0}, {1}, {2})", size, LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void IndexFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglIndexFormatNV != null, "pglIndexFormatNV not implemented");
			Delegates.pglIndexFormatNV(type, stride);
			LogFunction("glIndexFormatNV({0}, {1})", LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void TexCoordFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglTexCoordFormatNV != null, "pglTexCoordFormatNV not implemented");
			Delegates.pglTexCoordFormatNV(size, type, stride);
			LogFunction("glTexCoordFormatNV({0}, {1}, {2})", size, LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEdgeFlagFormatNV.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void EdgeFlagFormatNV(Int32 stride)
		{
			Debug.Assert(Delegates.pglEdgeFlagFormatNV != null, "pglEdgeFlagFormatNV not implemented");
			Delegates.pglEdgeFlagFormatNV(stride);
			LogFunction("glEdgeFlagFormatNV({0})", stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSecondaryColorFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void SecondaryColorFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglSecondaryColorFormatNV != null, "pglSecondaryColorFormatNV not implemented");
			Delegates.pglSecondaryColorFormatNV(size, type, stride);
			LogFunction("glSecondaryColorFormatNV({0}, {1}, {2})", size, LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogCoordFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void FogCoordFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglFogCoordFormatNV != null, "pglFogCoordFormatNV not implemented");
			Delegates.pglFogCoordFormatNV(type, stride);
			LogFunction("glFogCoordFormatNV({0}, {1})", LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribFormatNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void VertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribFormatNV != null, "pglVertexAttribFormatNV not implemented");
			Delegates.pglVertexAttribFormatNV(index, size, type, normalized, stride);
			LogFunction("glVertexAttribFormatNV({0}, {1}, {2}, {3}, {4})", index, size, LogEnumName(type), normalized, stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribIFormatNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void VertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribIFormatNV != null, "pglVertexAttribIFormatNV not implemented");
			Delegates.pglVertexAttribIFormatNV(index, size, type, stride);
			LogFunction("glVertexAttribIFormatNV({0}, {1}, {2}, {3})", index, size, LogEnumName(type), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetIntegerui64i_vNV.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="result">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory")]
		public static void GetIntegerNV(Int32 value, UInt32 index, [Out] UInt64[] result)
		{
			unsafe {
				fixed (UInt64* p_result = result)
				{
					Debug.Assert(Delegates.pglGetIntegerui64i_vNV != null, "pglGetIntegerui64i_vNV not implemented");
					Delegates.pglGetIntegerui64i_vNV(value, index, p_result);
					LogFunction("glGetIntegerui64i_vNV({0}, {1}, {2})", LogEnumName(value), index, LogValue(result));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
