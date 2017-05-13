
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
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_NV = 0x851D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_VALID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;

		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;

		/// <summary>
		/// Binding for glFlushVertexArrayRangeNV.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void FlushVertexArrayRangeNV()
		{
			Debug.Assert(Delegates.pglFlushVertexArrayRangeNV != null, "pglFlushVertexArrayRangeNV not implemented");
			Delegates.pglFlushVertexArrayRangeNV();
			LogCommand("glFlushVertexArrayRangeNV", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayRangeNV.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void VertexArrayRangeNV(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexArrayRangeNV != null, "pglVertexArrayRangeNV not implemented");
			Delegates.pglVertexArrayRangeNV(length, pointer);
			LogCommand("glVertexArrayRangeNV", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayRangeNV.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_array_range")]
		public static void VertexArrayRangeNV(Int32 length, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexArrayRangeNV(length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFlushVertexArrayRangeNV", ExactSpelling = true)]
			internal extern static void glFlushVertexArrayRangeNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayRangeNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayRangeNV(Int32 length, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushVertexArrayRangeNV();

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static glFlushVertexArrayRangeNV pglFlushVertexArrayRangeNV;

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayRangeNV(Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayRangeNV pglVertexArrayRangeNV;

		}
	}

}
