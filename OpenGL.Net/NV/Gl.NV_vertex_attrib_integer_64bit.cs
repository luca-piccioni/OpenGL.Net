
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
		/// Binding for glVertexAttribL1i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, Int64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1i64NV != null, "pglVertexAttribL1i64NV not implemented");
			Delegates.pglVertexAttribL1i64NV(index, x);
			LogCommand("glVertexAttribL1i64NV", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL2i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2i64NV != null, "pglVertexAttribL2i64NV not implemented");
			Delegates.pglVertexAttribL2i64NV(index, x, y);
			LogCommand("glVertexAttribL2i64NV", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL3i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3i64NV != null, "pglVertexAttribL3i64NV not implemented");
			Delegates.pglVertexAttribL3i64NV(index, x, y, z);
			LogCommand("glVertexAttribL3i64NV", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL4i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4i64NV != null, "pglVertexAttribL4i64NV not implemented");
			Delegates.pglVertexAttribL4i64NV(index, x, y, z, w);
			LogCommand("glVertexAttribL4i64NV", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL1i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1i64vNV != null, "pglVertexAttribL1i64vNV not implemented");
					Delegates.pglVertexAttribL1i64vNV(index, p_v);
					LogCommand("glVertexAttribL1i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL2i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2i64vNV != null, "pglVertexAttribL2i64vNV not implemented");
					Delegates.pglVertexAttribL2i64vNV(index, p_v);
					LogCommand("glVertexAttribL2i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL3i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3i64vNV != null, "pglVertexAttribL3i64vNV not implemented");
					Delegates.pglVertexAttribL3i64vNV(index, p_v);
					LogCommand("glVertexAttribL3i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL4i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4i64vNV != null, "pglVertexAttribL4i64vNV not implemented");
					Delegates.pglVertexAttribL4i64vNV(index, p_v);
					LogCommand("glVertexAttribL4i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, UInt64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1ui64NV != null, "pglVertexAttribL1ui64NV not implemented");
			Delegates.pglVertexAttribL1ui64NV(index, x);
			LogCommand("glVertexAttribL1ui64NV", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL2ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2ui64NV != null, "pglVertexAttribL2ui64NV not implemented");
			Delegates.pglVertexAttribL2ui64NV(index, x, y);
			LogCommand("glVertexAttribL2ui64NV", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL3ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3ui64NV != null, "pglVertexAttribL3ui64NV not implemented");
			Delegates.pglVertexAttribL3ui64NV(index, x, y, z);
			LogCommand("glVertexAttribL3ui64NV", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL4ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4ui64NV != null, "pglVertexAttribL4ui64NV not implemented");
			Delegates.pglVertexAttribL4ui64NV(index, x, y, z, w);
			LogCommand("glVertexAttribL4ui64NV", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1ui64vNV != null, "pglVertexAttribL1ui64vNV not implemented");
					Delegates.pglVertexAttribL1ui64vNV(index, p_v);
					LogCommand("glVertexAttribL1ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL2ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2ui64vNV != null, "pglVertexAttribL2ui64vNV not implemented");
					Delegates.pglVertexAttribL2ui64vNV(index, p_v);
					LogCommand("glVertexAttribL2ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL3ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3ui64vNV != null, "pglVertexAttribL3ui64vNV not implemented");
					Delegates.pglVertexAttribL3ui64vNV(index, p_v);
					LogCommand("glVertexAttribL3ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL4ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4ui64vNV != null, "pglVertexAttribL4ui64vNV not implemented");
					Delegates.pglVertexAttribL4ui64vNV(index, p_v);
					LogCommand("glVertexAttribL4ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexAttribLi64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:VertexAttribPName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void GetVertexAttribLNV(UInt32 index, VertexAttribPName pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLi64vNV != null, "pglGetVertexAttribLi64vNV not implemented");
					Delegates.pglGetVertexAttribLi64vNV(index, (Int32)pname, p_params);
					LogCommand("glGetVertexAttribLi64vNV", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexAttribLui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:VertexAttribPName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void GetVertexAttribLNV(UInt32 index, VertexAttribPName pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLui64vNV != null, "pglGetVertexAttribLui64vNV not implemented");
					Delegates.pglGetVertexAttribLui64vNV(index, (Int32)pname, p_params);
					LogCommand("glGetVertexAttribLui64vNV", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribLFormatNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexAttribType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribLFormatNV(UInt32 index, Int32 size, VertexAttribType type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribLFormatNV != null, "pglVertexAttribLFormatNV not implemented");
			Delegates.pglVertexAttribLFormatNV(index, size, (Int32)type, stride);
			LogCommand("glVertexAttribLFormatNV", null, index, size, type, stride			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4i64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4ui64NV", ExactSpelling = true)]
			internal extern static void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexAttribLi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexAttribLui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribLFormatNV", ExactSpelling = true)]
			internal extern static void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1i64NV pglVertexAttribL1i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2i64NV pglVertexAttribL2i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3i64NV pglVertexAttribL3i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4i64NV pglVertexAttribL4i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1i64vNV pglVertexAttribL1i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2i64vNV pglVertexAttribL2i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3i64vNV pglVertexAttribL3i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4i64vNV pglVertexAttribL4i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1ui64NV pglVertexAttribL1ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2ui64NV pglVertexAttribL2ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3ui64NV pglVertexAttribL3ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4ui64NV pglVertexAttribL4ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1ui64vNV pglVertexAttribL1ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2ui64vNV pglVertexAttribL2ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3ui64vNV pglVertexAttribL3ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4ui64vNV pglVertexAttribL4ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexAttribLi64vNV pglGetVertexAttribLi64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexAttribLui64vNV pglGetVertexAttribLui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribLFormatNV pglVertexAttribLFormatNV;

		}
	}

}
