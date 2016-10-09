
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL1NV(UInt32 index, Int64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1i64NV != null, "pglVertexAttribL1i64NV not implemented");
			Delegates.pglVertexAttribL1i64NV(index, x);
			LogFunction("glVertexAttribL1i64NV({0}, {1})", index, x);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL2NV(UInt32 index, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2i64NV != null, "pglVertexAttribL2i64NV not implemented");
			Delegates.pglVertexAttribL2i64NV(index, x, y);
			LogFunction("glVertexAttribL2i64NV({0}, {1}, {2})", index, x, y);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL3NV(UInt32 index, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3i64NV != null, "pglVertexAttribL3i64NV not implemented");
			Delegates.pglVertexAttribL3i64NV(index, x, y, z);
			LogFunction("glVertexAttribL3i64NV({0}, {1}, {2}, {3})", index, x, y, z);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL4NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4i64NV != null, "pglVertexAttribL4i64NV not implemented");
			Delegates.pglVertexAttribL4i64NV(index, x, y, z, w);
			LogFunction("glVertexAttribL4i64NV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL1NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1i64vNV != null, "pglVertexAttribL1i64vNV not implemented");
					Delegates.pglVertexAttribL1i64vNV(index, p_v);
					LogFunction("glVertexAttribL1i64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL2NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2i64vNV != null, "pglVertexAttribL2i64vNV not implemented");
					Delegates.pglVertexAttribL2i64vNV(index, p_v);
					LogFunction("glVertexAttribL2i64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL3NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3i64vNV != null, "pglVertexAttribL3i64vNV not implemented");
					Delegates.pglVertexAttribL3i64vNV(index, p_v);
					LogFunction("glVertexAttribL3i64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL4NV(UInt32 index, Int64[] v)
		{
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4i64vNV != null, "pglVertexAttribL4i64vNV not implemented");
					Delegates.pglVertexAttribL4i64vNV(index, p_v);
					LogFunction("glVertexAttribL4i64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL1NV(UInt32 index, UInt64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1ui64NV != null, "pglVertexAttribL1ui64NV not implemented");
			Delegates.pglVertexAttribL1ui64NV(index, x);
			LogFunction("glVertexAttribL1ui64NV({0}, {1})", index, x);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL2NV(UInt32 index, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2ui64NV != null, "pglVertexAttribL2ui64NV not implemented");
			Delegates.pglVertexAttribL2ui64NV(index, x, y);
			LogFunction("glVertexAttribL2ui64NV({0}, {1}, {2})", index, x, y);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL3NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3ui64NV != null, "pglVertexAttribL3ui64NV not implemented");
			Delegates.pglVertexAttribL3ui64NV(index, x, y, z);
			LogFunction("glVertexAttribL3ui64NV({0}, {1}, {2}, {3})", index, x, y, z);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL4NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4ui64NV != null, "pglVertexAttribL4ui64NV not implemented");
			Delegates.pglVertexAttribL4ui64NV(index, x, y, z, w);
			LogFunction("glVertexAttribL4ui64NV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL1NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1ui64vNV != null, "pglVertexAttribL1ui64vNV not implemented");
					Delegates.pglVertexAttribL1ui64vNV(index, p_v);
					LogFunction("glVertexAttribL1ui64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL2NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2ui64vNV != null, "pglVertexAttribL2ui64vNV not implemented");
					Delegates.pglVertexAttribL2ui64vNV(index, p_v);
					LogFunction("glVertexAttribL2ui64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL3NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3ui64vNV != null, "pglVertexAttribL3ui64vNV not implemented");
					Delegates.pglVertexAttribL3ui64vNV(index, p_v);
					LogFunction("glVertexAttribL3ui64vNV({0}, {1})", index, LogValue(v));
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
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribL4NV(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4ui64vNV != null, "pglVertexAttribL4ui64vNV not implemented");
					Delegates.pglVertexAttribL4ui64vNV(index, p_v);
					LogFunction("glVertexAttribL4ui64vNV({0}, {1})", index, LogValue(v));
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void GetVertexAttribLNV(UInt32 index, Int32 pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLi64vNV != null, "pglGetVertexAttribLi64vNV not implemented");
					Delegates.pglGetVertexAttribLi64vNV(index, pname, p_params);
					LogFunction("glGetVertexAttribLi64vNV({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void GetVertexAttribLNV(UInt32 index, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLui64vNV != null, "pglGetVertexAttribLui64vNV not implemented");
					Delegates.pglGetVertexAttribLui64vNV(index, pname, p_params);
					LogFunction("glGetVertexAttribLui64vNV({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public static void VertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribLFormatNV != null, "pglVertexAttribLFormatNV not implemented");
			Delegates.pglVertexAttribLFormatNV(index, size, type, stride);
			LogFunction("glVertexAttribLFormatNV({0}, {1}, {2}, {3})", index, size, LogEnumName(type), stride);
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
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[ThreadStatic]
			internal static glVertexAttribL1i64NV pglVertexAttribL1i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[ThreadStatic]
			internal static glVertexAttribL2i64NV pglVertexAttribL2i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[ThreadStatic]
			internal static glVertexAttribL3i64NV pglVertexAttribL3i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[ThreadStatic]
			internal static glVertexAttribL4i64NV pglVertexAttribL4i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL1i64vNV pglVertexAttribL1i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL2i64vNV pglVertexAttribL2i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL3i64vNV pglVertexAttribL3i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[ThreadStatic]
			internal static glVertexAttribL4i64vNV pglVertexAttribL4i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[ThreadStatic]
			internal static glVertexAttribL1ui64NV pglVertexAttribL1ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[ThreadStatic]
			internal static glVertexAttribL2ui64NV pglVertexAttribL2ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[ThreadStatic]
			internal static glVertexAttribL3ui64NV pglVertexAttribL3ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[ThreadStatic]
			internal static glVertexAttribL4ui64NV pglVertexAttribL4ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL1ui64vNV pglVertexAttribL1ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL2ui64vNV pglVertexAttribL2ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL3ui64vNV pglVertexAttribL3ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL4ui64vNV pglVertexAttribL4ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLi64vNV pglGetVertexAttribLi64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLui64vNV pglGetVertexAttribLui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[ThreadStatic]
			internal static glVertexAttribLFormatNV pglVertexAttribLFormatNV;

		}
	}

}
