
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
		/// Value of GL_VERTEX_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int VERTEX_ARRAY_LIST_IBM = 103070;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int NORMAL_ARRAY_LIST_IBM = 103071;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int COLOR_ARRAY_LIST_IBM = 103072;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int INDEX_ARRAY_LIST_IBM = 103073;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int TEXTURE_COORD_ARRAY_LIST_IBM = 103074;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int EDGE_FLAG_ARRAY_LIST_IBM = 103075;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int FOG_COORDINATE_ARRAY_LIST_IBM = 103076;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int COLOR_ARRAY_LIST_STRIDE_IBM = 103082;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int INDEX_ARRAY_LIST_STRIDE_IBM = 103083;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;

		/// <summary>
		/// Binding for glColorPointerListIBM.
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
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void ColorPointerListIBM(Int32 size, ColorPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglColorPointerListIBM != null, "pglColorPointerListIBM not implemented");
					Delegates.pglColorPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glColorPointerListIBM({0}, {1}, {2}, {3}, {4})", size, type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSecondaryColorPointerListIBM.
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
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void SecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglSecondaryColorPointerListIBM != null, "pglSecondaryColorPointerListIBM not implemented");
					Delegates.pglSecondaryColorPointerListIBM(size, type, stride, p_pointer, ptrstride);
					LogFunction("glSecondaryColorPointerListIBM({0}, {1}, {2}, {3}, {4})", size, LogEnumName(type), stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEdgeFlagPointerListIBM.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void EdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride)
		{
			Debug.Assert(Delegates.pglEdgeFlagPointerListIBM != null, "pglEdgeFlagPointerListIBM not implemented");
			Delegates.pglEdgeFlagPointerListIBM(stride, pointer, ptrstride);
			LogFunction("glEdgeFlagPointerListIBM({0}, {1}, {2})", stride, LogValue(pointer), ptrstride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogCoordPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:FogPointerTypeIBM"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void FogCoordPointerListIBM(FogPointerTypeIBM type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglFogCoordPointerListIBM != null, "pglFogCoordPointerListIBM not implemented");
					Delegates.pglFogCoordPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glFogCoordPointerListIBM({0}, {1}, {2}, {3})", type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:IndexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void IndexPointerListIBM(IndexPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglIndexPointerListIBM != null, "pglIndexPointerListIBM not implemented");
					Delegates.pglIndexPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glIndexPointerListIBM({0}, {1}, {2}, {3})", type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:NormalPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void NormalPointerListIBM(NormalPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglNormalPointerListIBM != null, "pglNormalPointerListIBM not implemented");
					Delegates.pglNormalPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glNormalPointerListIBM({0}, {1}, {2}, {3})", type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordPointerListIBM.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void TexCoordPointerListIBM(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglTexCoordPointerListIBM != null, "pglTexCoordPointerListIBM not implemented");
					Delegates.pglTexCoordPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glTexCoordPointerListIBM({0}, {1}, {2}, {3}, {4})", size, type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexPointerListIBM.
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
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void VertexPointerListIBM(Int32 size, VertexPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglVertexPointerListIBM != null, "pglVertexPointerListIBM not implemented");
					Delegates.pglVertexPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogFunction("glVertexPointerListIBM({0}, {1}, {2}, {3}, {4})", size, type, stride, LogValue(pointer), ptrstride);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
