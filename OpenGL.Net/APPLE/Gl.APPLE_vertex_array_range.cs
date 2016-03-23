
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
		/// Value of GL_VERTEX_ARRAY_RANGE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_APPLE = 0x851D;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;

		/// <summary>
		/// Value of GL_STORAGE_CLIENT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CLIENT_APPLE = 0x85B4;

		/// <summary>
		/// Value of GL_STORAGE_CACHED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CACHED_APPLE = 0x85BE;

		/// <summary>
		/// Value of GL_STORAGE_SHARED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_SHARED_APPLE = 0x85BF;

		/// <summary>
		/// Binding for glVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexArrayRangeAPPLE != null, "pglVertexArrayRangeAPPLE not implemented");
			Delegates.pglVertexArrayRangeAPPLE(length, pointer);
			LogFunction("glVertexArrayRangeAPPLE({0}, 0x{1})", length, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFlushVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void FlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFlushVertexArrayRangeAPPLE != null, "pglFlushVertexArrayRangeAPPLE not implemented");
			Delegates.pglFlushVertexArrayRangeAPPLE(length, pointer);
			LogFunction("glFlushVertexArrayRangeAPPLE({0}, 0x{1})", length, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayParameteriAPPLE.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayParameterAPPLE(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglVertexArrayParameteriAPPLE != null, "pglVertexArrayParameteriAPPLE not implemented");
			Delegates.pglVertexArrayParameteriAPPLE(pname, param);
			LogFunction("glVertexArrayParameteriAPPLE({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

	}

}
