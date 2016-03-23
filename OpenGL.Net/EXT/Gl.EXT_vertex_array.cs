
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
		/// Value of GL_VERTEX_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int VERTEX_ARRAY_COUNT_EXT = 0x807D;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int NORMAL_ARRAY_COUNT_EXT = 0x8080;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int COLOR_ARRAY_COUNT_EXT = 0x8084;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int INDEX_ARRAY_COUNT_EXT = 0x8087;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public const int EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;

		/// <summary>
		/// Binding for glColorPointerEXT.
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
			Delegates.pglColorPointerEXT(size, (Int32)type, stride, count, pointer);
			LogFunction("glColorPointerEXT({0}, {1}, {2}, {3}, 0x{4})", size, type, stride, count, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorPointerEXT.
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
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void ColorPointerEXT(Int32 size, ColorPointerType type, Int32 stride, Int32 count, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ColorPointerEXT(size, type, stride, count, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
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
					LogFunction("glEdgeFlagPointerEXT({0}, {1}, {2})", stride, count, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:IndexPointerType"/>.
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
			Delegates.pglIndexPointerEXT((Int32)type, stride, count, pointer);
			LogFunction("glIndexPointerEXT({0}, {1}, {2}, 0x{3})", type, stride, count, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:IndexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void IndexPointerEXT(IndexPointerType type, Int32 stride, Int32 count, Object pointer)
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
		/// A <see cref="T:NormalPointerType"/>.
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
			Delegates.pglNormalPointerEXT((Int32)type, stride, count, pointer);
			LogFunction("glNormalPointerEXT({0}, {1}, {2}, 0x{3})", type, stride, count, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:NormalPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void NormalPointerEXT(NormalPointerType type, Int32 stride, Int32 count, Object pointer)
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
		/// A <see cref="T:TexCoordPointerType"/>.
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
			Delegates.pglTexCoordPointerEXT(size, (Int32)type, stride, count, pointer);
			LogFunction("glTexCoordPointerEXT({0}, {1}, {2}, {3}, 0x{4})", size, type, stride, count, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordPointerEXT.
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
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void TexCoordPointerEXT(Int32 size, TexCoordPointerType type, Int32 stride, Int32 count, Object pointer)
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
		/// A <see cref="T:VertexPointerType"/>.
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
			Delegates.pglVertexPointerEXT(size, (Int32)type, stride, count, pointer);
			LogFunction("glVertexPointerEXT({0}, {1}, {2}, {3}, 0x{4})", size, type, stride, count, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexPointerEXT.
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
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_array")]
		public static void VertexPointerEXT(Int32 size, VertexPointerType type, Int32 stride, Int32 count, Object pointer)
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
