
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
		/// Value of GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public const int VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;

		/// <summary>
		/// Binding for glVertexAttribI1iEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1EXT(UInt32 index, Int32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1iEXT != null, "pglVertexAttribI1iEXT not implemented");
			Delegates.pglVertexAttribI1iEXT(index, x);
			CallLog("glVertexAttribI1iEXT({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI2iEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2EXT(UInt32 index, Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2iEXT != null, "pglVertexAttribI2iEXT not implemented");
			Delegates.pglVertexAttribI2iEXT(index, x, y);
			CallLog("glVertexAttribI2iEXT({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI3iEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3EXT(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3iEXT != null, "pglVertexAttribI3iEXT not implemented");
			Delegates.pglVertexAttribI3iEXT(index, x, y, z);
			CallLog("glVertexAttribI3iEXT({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4iEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4iEXT != null, "pglVertexAttribI4iEXT not implemented");
			Delegates.pglVertexAttribI4iEXT(index, x, y, z, w);
			CallLog("glVertexAttribI4iEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI1uiEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1EXT(UInt32 index, UInt32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1uiEXT != null, "pglVertexAttribI1uiEXT not implemented");
			Delegates.pglVertexAttribI1uiEXT(index, x);
			CallLog("glVertexAttribI1uiEXT({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI2uiEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2EXT(UInt32 index, UInt32 x, UInt32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2uiEXT != null, "pglVertexAttribI2uiEXT not implemented");
			Delegates.pglVertexAttribI2uiEXT(index, x, y);
			CallLog("glVertexAttribI2uiEXT({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI3uiEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3EXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3uiEXT != null, "pglVertexAttribI3uiEXT not implemented");
			Delegates.pglVertexAttribI3uiEXT(index, x, y, z);
			CallLog("glVertexAttribI3uiEXT({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4uiEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4uiEXT != null, "pglVertexAttribI4uiEXT not implemented");
			Delegates.pglVertexAttribI4uiEXT(index, x, y, z, w);
			CallLog("glVertexAttribI4uiEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI1ivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1EXT(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1ivEXT != null, "pglVertexAttribI1ivEXT not implemented");
					Delegates.pglVertexAttribI1ivEXT(index, p_v);
					CallLog("glVertexAttribI1ivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI2ivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2EXT(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2ivEXT != null, "pglVertexAttribI2ivEXT not implemented");
					Delegates.pglVertexAttribI2ivEXT(index, p_v);
					CallLog("glVertexAttribI2ivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI3ivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3EXT(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3ivEXT != null, "pglVertexAttribI3ivEXT not implemented");
					Delegates.pglVertexAttribI3ivEXT(index, p_v);
					CallLog("glVertexAttribI3ivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4ivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4ivEXT != null, "pglVertexAttribI4ivEXT not implemented");
					Delegates.pglVertexAttribI4ivEXT(index, p_v);
					CallLog("glVertexAttribI4ivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI1uivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI1EXT(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1uivEXT != null, "pglVertexAttribI1uivEXT not implemented");
					Delegates.pglVertexAttribI1uivEXT(index, p_v);
					CallLog("glVertexAttribI1uivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI2uivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI2EXT(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2uivEXT != null, "pglVertexAttribI2uivEXT not implemented");
					Delegates.pglVertexAttribI2uivEXT(index, p_v);
					CallLog("glVertexAttribI2uivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI3uivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI3EXT(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3uivEXT != null, "pglVertexAttribI3uivEXT not implemented");
					Delegates.pglVertexAttribI3uivEXT(index, p_v);
					CallLog("glVertexAttribI3uivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4uivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4uivEXT != null, "pglVertexAttribI4uivEXT not implemented");
					Delegates.pglVertexAttribI4uivEXT(index, p_v);
					CallLog("glVertexAttribI4uivEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4bvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4bvEXT != null, "pglVertexAttribI4bvEXT not implemented");
					Delegates.pglVertexAttribI4bvEXT(index, p_v);
					CallLog("glVertexAttribI4bvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4svEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4svEXT != null, "pglVertexAttribI4svEXT not implemented");
					Delegates.pglVertexAttribI4svEXT(index, p_v);
					CallLog("glVertexAttribI4svEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4ubvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4ubvEXT != null, "pglVertexAttribI4ubvEXT not implemented");
					Delegates.pglVertexAttribI4ubvEXT(index, p_v);
					CallLog("glVertexAttribI4ubvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribI4usvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribI4EXT(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4usvEXT != null, "pglVertexAttribI4usvEXT not implemented");
					Delegates.pglVertexAttribI4usvEXT(index, p_v);
					CallLog("glVertexAttribI4usvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribIPointerEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribIPointerEXT != null, "pglVertexAttribIPointerEXT not implemented");
			Delegates.pglVertexAttribIPointerEXT(index, size, type, stride, pointer);
			CallLog("glVertexAttribIPointerEXT({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribIPointerEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void VertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribIPointerEXT(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glGetVertexAttribIivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void GetVertexAttribIEXT(UInt32 index, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIivEXT != null, "pglGetVertexAttribIivEXT not implemented");
					Delegates.pglGetVertexAttribIivEXT(index, pname, p_params);
					CallLog("glGetVertexAttribIivEXT({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribIuivEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program4")]
		public static void GetVertexAttribIEXT(UInt32 index, int pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIuivEXT != null, "pglGetVertexAttribIuivEXT not implemented");
					Delegates.pglGetVertexAttribIuivEXT(index, pname, p_params);
					CallLog("glGetVertexAttribIuivEXT({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
