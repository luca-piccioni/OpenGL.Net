
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
		/// Value of GL_VERTEX_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_EXT = 0x8074;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_EXT = 0x8075;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_EXT = 0x8076;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_EXT = 0x8077;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_EXT = 0x8078;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int EDGE_FLAG_ARRAY_EXT = 0x8079;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_SIZE_EXT = 0x807A;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_TYPE_EXT = 0x807B;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_STRIDE_EXT = 0x807C;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_COUNT_EXT = 0x807D;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_TYPE_EXT = 0x807E;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_STRIDE_EXT = 0x807F;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_COUNT_EXT = 0x8080;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_SIZE_EXT = 0x8081;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_TYPE_EXT = 0x8082;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_STRIDE_EXT = 0x8083;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_COUNT_EXT = 0x8084;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_TYPE_EXT = 0x8085;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_STRIDE_EXT = 0x8086;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_COUNT_EXT = 0x8087;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_POINTER_EXT = 0x808E;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_POINTER_EXT = 0x808F;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_POINTER_EXT = 0x8090;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_POINTER_EXT = 0x8091;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093;

		/// <summary>
		/// Binding for glArrayElementEXT.
		/// </summary>
		/// <param name="i">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void ArrayElementEXT(Int32 i)
		{
			Debug.Assert(Delegates.pglArrayElementEXT != null, "pglArrayElementEXT not implemented");
			Delegates.pglArrayElementEXT(i);
			CallLog("glArrayElementEXT({0})", i);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void ColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointerEXT != null, "pglColorPointerEXT not implemented");
			Delegates.pglColorPointerEXT(size, type, stride, count, pointer);
			CallLog("glColorPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void ColorPointerEXT(Int32 size, ColorPointerType type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointerEXT != null, "pglColorPointerEXT not implemented");
			Delegates.pglColorPointerEXT(size, (int)type, stride, count, pointer);
			CallLog("glColorPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void ColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ColorPointerEXT(size, type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawArraysEXT.
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
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void DrawArraysEXT(int mode, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawArraysEXT != null, "pglDrawArraysEXT not implemented");
			Delegates.pglDrawArraysEXT(mode, first, count);
			CallLog("glDrawArraysEXT({0}, {1}, {2})", mode, first, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysEXT.
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
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void DrawArraysEXT(PrimitiveType mode, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawArraysEXT != null, "pglDrawArraysEXT not implemented");
			Delegates.pglDrawArraysEXT((int)mode, first, count);
			CallLog("glDrawArraysEXT({0}, {1}, {2})", mode, first, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEdgeFlagPointerEXT.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void EdgeFlagPointerEXT(Int32 stride, Int32 count, bool[] pointer)
		{
			unsafe {
				fixed (bool* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglEdgeFlagPointerEXT != null, "pglEdgeFlagPointerEXT not implemented");
					Delegates.pglEdgeFlagPointerEXT(stride, count, p_pointer);
					CallLog("glEdgeFlagPointerEXT({0}, {1}, {2})", stride, count, pointer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPointervEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void GetPointerEXT(int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetPointervEXT != null, "pglGetPointervEXT not implemented");
			Delegates.pglGetPointervEXT(pname, @params);
			CallLog("glGetPointervEXT({0}, {1})", pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPointervEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void GetPointerEXT(GetPointervPName pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetPointervEXT != null, "pglGetPointervEXT not implemented");
			Delegates.pglGetPointervEXT((int)pname, @params);
			CallLog("glGetPointervEXT({0}, {1})", pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void IndexPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointerEXT != null, "pglIndexPointerEXT not implemented");
			Delegates.pglIndexPointerEXT(type, stride, count, pointer);
			CallLog("glIndexPointerEXT({0}, {1}, {2}, {3})", type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void IndexPointerEXT(IndexPointerType type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointerEXT != null, "pglIndexPointerEXT not implemented");
			Delegates.pglIndexPointerEXT((int)type, stride, count, pointer);
			CallLog("glIndexPointerEXT({0}, {1}, {2}, {3})", type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void IndexPointerEXT(int type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				IndexPointerEXT(type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glNormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void NormalPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointerEXT != null, "pglNormalPointerEXT not implemented");
			Delegates.pglNormalPointerEXT(type, stride, count, pointer);
			CallLog("glNormalPointerEXT({0}, {1}, {2}, {3})", type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void NormalPointerEXT(NormalPointerType type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointerEXT != null, "pglNormalPointerEXT not implemented");
			Delegates.pglNormalPointerEXT((int)type, stride, count, pointer);
			CallLog("glNormalPointerEXT({0}, {1}, {2}, {3})", type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void NormalPointerEXT(int type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				NormalPointerEXT(type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glTexCoordPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void TexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointerEXT != null, "pglTexCoordPointerEXT not implemented");
			Delegates.pglTexCoordPointerEXT(size, type, stride, count, pointer);
			CallLog("glTexCoordPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void TexCoordPointerEXT(Int32 size, TexCoordPointerType type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointerEXT != null, "pglTexCoordPointerEXT not implemented");
			Delegates.pglTexCoordPointerEXT(size, (int)type, stride, count, pointer);
			CallLog("glTexCoordPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void TexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TexCoordPointerEXT(size, type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void VertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointerEXT != null, "pglVertexPointerEXT not implemented");
			Delegates.pglVertexPointerEXT(size, type, stride, count, pointer);
			CallLog("glVertexPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void VertexPointerEXT(Int32 size, VertexPointerType type, Int32 stride, Int32 count, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointerEXT != null, "pglVertexPointerEXT not implemented");
			Delegates.pglVertexPointerEXT(size, (int)type, stride, count, pointer);
			CallLog("glVertexPointerEXT({0}, {1}, {2}, {3}, {4})", size, type, stride, count, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void VertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexPointerEXT(size, type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
