
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int VERTEX_ARRAY_ADDRESS_NV = 0x8F21;

		/// <summary>
		/// [GL] Value of GL_NORMAL_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int NORMAL_ARRAY_ADDRESS_NV = 0x8F22;

		/// <summary>
		/// [GL] Value of GL_COLOR_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int COLOR_ARRAY_ADDRESS_NV = 0x8F23;

		/// <summary>
		/// [GL] Value of GL_INDEX_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int INDEX_ARRAY_ADDRESS_NV = 0x8F24;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;

		/// <summary>
		/// [GL] Value of GL_EDGE_FLAG_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;

		/// <summary>
		/// [GL] Value of GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;

		/// <summary>
		/// [GL] Value of GL_FOG_COORD_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int VERTEX_ARRAY_LENGTH_NV = 0x8F2B;

		/// <summary>
		/// [GL] Value of GL_NORMAL_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int NORMAL_ARRAY_LENGTH_NV = 0x8F2C;

		/// <summary>
		/// [GL] Value of GL_COLOR_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int COLOR_ARRAY_LENGTH_NV = 0x8F2D;

		/// <summary>
		/// [GL] Value of GL_INDEX_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int INDEX_ARRAY_LENGTH_NV = 0x8F2E;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;

		/// <summary>
		/// [GL] Value of GL_EDGE_FLAG_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;

		/// <summary>
		/// [GL] Value of GL_SECONDARY_COLOR_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;

		/// <summary>
		/// [GL] Value of GL_FOG_COORD_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int ELEMENT_ARRAY_LENGTH_NV = 0x8F33;

		/// <summary>
		/// [GL] Value of GL_DRAW_INDIRECT_UNIFIED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int DRAW_INDIRECT_UNIFIED_NV = 0x8F40;

		/// <summary>
		/// [GL] Value of GL_DRAW_INDIRECT_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int DRAW_INDIRECT_ADDRESS_NV = 0x8F41;

		/// <summary>
		/// [GL] Value of GL_DRAW_INDIRECT_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public const int DRAW_INDIRECT_LENGTH_NV = 0x8F42;

		/// <summary>
		/// [GL] Binding for glBufferAddressRangeNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void BufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length)
		{
			Debug.Assert(Delegates.pglBufferAddressRangeNV != null, "pglBufferAddressRangeNV not implemented");
			Delegates.pglBufferAddressRangeNV(pname, index, address, length);
			LogCommand("glBufferAddressRangeNV", null, pname, index, address, length			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void VertexFormatNV(Int32 size, VertexPointerType type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexFormatNV != null, "pglVertexFormatNV not implemented");
			Delegates.pglVertexFormatNV(size, (Int32)type, stride);
			LogCommand("glVertexFormatNV", null, size, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormalFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void NormalFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglNormalFormatNV != null, "pglNormalFormatNV not implemented");
			Delegates.pglNormalFormatNV(type, stride);
			LogCommand("glNormalFormatNV", null, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColorFormatNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void ColorFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglColorFormatNV != null, "pglColorFormatNV not implemented");
			Delegates.pglColorFormatNV(size, type, stride);
			LogCommand("glColorFormatNV", null, size, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIndexFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void IndexFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglIndexFormatNV != null, "pglIndexFormatNV not implemented");
			Delegates.pglIndexFormatNV(type, stride);
			LogCommand("glIndexFormatNV", null, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoordFormatNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void TexCoordFormatNV(Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglTexCoordFormatNV != null, "pglTexCoordFormatNV not implemented");
			Delegates.pglTexCoordFormatNV(size, type, stride);
			LogCommand("glTexCoordFormatNV", null, size, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEdgeFlagFormatNV.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void EdgeFlagFormatNV(Int32 stride)
		{
			Debug.Assert(Delegates.pglEdgeFlagFormatNV != null, "pglEdgeFlagFormatNV not implemented");
			Delegates.pglEdgeFlagFormatNV(stride);
			LogCommand("glEdgeFlagFormatNV", null, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSecondaryColorFormatNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:ColorPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void SecondaryColorFormatNV(Int32 size, ColorPointerType type, Int32 stride)
		{
			Debug.Assert(Delegates.pglSecondaryColorFormatNV != null, "pglSecondaryColorFormatNV not implemented");
			Delegates.pglSecondaryColorFormatNV(size, (Int32)type, stride);
			LogCommand("glSecondaryColorFormatNV", null, size, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogCoordFormatNV.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void FogCoordFormatNV(Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglFogCoordFormatNV != null, "pglFogCoordFormatNV not implemented");
			Delegates.pglFogCoordFormatNV(type, stride);
			LogCommand("glFogCoordFormatNV", null, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribFormatNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void VertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribFormatNV != null, "pglVertexAttribFormatNV not implemented");
			Delegates.pglVertexAttribFormatNV(index, size, type, normalized, stride);
			LogCommand("glVertexAttribFormatNV", null, index, size, type, normalized, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribIFormatNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void VertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribIFormatNV != null, "pglVertexAttribIFormatNV not implemented");
			Delegates.pglVertexAttribIFormatNV(index, size, type, stride);
			LogCommand("glVertexAttribIFormatNV", null, index, size, type, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetIntegerui64i_vNV.
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
		[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
		public static void GetIntegerNV(Int32 value, UInt32 index, [Out] UInt64[] result)
		{
			unsafe {
				fixed (UInt64* p_result = result)
				{
					Debug.Assert(Delegates.pglGetIntegerui64i_vNV != null, "pglGetIntegerui64i_vNV not implemented");
					Delegates.pglGetIntegerui64i_vNV(value, index, p_result);
					LogCommand("glGetIntegerui64i_vNV", null, value, index, result					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBufferAddressRangeNV", ExactSpelling = true)]
			internal extern static void glBufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexFormatNV", ExactSpelling = true)]
			internal extern static void glVertexFormatNV(Int32 size, Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glNormalFormatNV", ExactSpelling = true)]
			internal extern static void glNormalFormatNV(Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glColorFormatNV", ExactSpelling = true)]
			internal extern static void glColorFormatNV(Int32 size, Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIndexFormatNV", ExactSpelling = true)]
			internal extern static void glIndexFormatNV(Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoordFormatNV", ExactSpelling = true)]
			internal extern static void glTexCoordFormatNV(Int32 size, Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEdgeFlagFormatNV", ExactSpelling = true)]
			internal extern static void glEdgeFlagFormatNV(Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glSecondaryColorFormatNV", ExactSpelling = true)]
			internal extern static void glSecondaryColorFormatNV(Int32 size, Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFogCoordFormatNV", ExactSpelling = true)]
			internal extern static void glFogCoordFormatNV(Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttribFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttribIFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetIntegerui64i_vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerui64i_vNV(Int32 value, UInt32 index, UInt64* result);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBufferAddressRangeNV(Int32 pname, UInt32 index, UInt64 address, UInt32 length);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glBufferAddressRangeNV pglBufferAddressRangeNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexFormatNV(Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexFormatNV pglVertexFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glNormalFormatNV(Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNormalFormatNV pglNormalFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glColorFormatNV pglColorFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glIndexFormatNV(Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glIndexFormatNV pglIndexFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexCoordFormatNV(Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTexCoordFormatNV pglTexCoordFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glEdgeFlagFormatNV(Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glEdgeFlagFormatNV pglEdgeFlagFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSecondaryColorFormatNV(Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glSecondaryColorFormatNV pglSecondaryColorFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFogCoordFormatNV(Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glFogCoordFormatNV pglFogCoordFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttribFormatNV(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribFormatNV pglVertexAttribFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttribIFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribIFormatNV pglVertexAttribIFormatNV;

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetIntegerui64i_vNV(Int32 value, UInt32 index, UInt64* result);

			[RequiredByFeature("GL_NV_vertex_buffer_unified_memory", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetIntegerui64i_vNV pglGetIntegerui64i_vNV;

		}
	}

}
