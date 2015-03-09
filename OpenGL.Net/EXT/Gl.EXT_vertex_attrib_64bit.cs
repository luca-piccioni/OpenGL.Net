
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
		/// Value of GL_DOUBLE_VEC2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC2_EXT = 0x8FFC;

		/// <summary>
		/// Value of GL_DOUBLE_VEC3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC3_EXT = 0x8FFD;

		/// <summary>
		/// Value of GL_DOUBLE_VEC4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_VEC4_EXT = 0x8FFE;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2_EXT = 0x8F46;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3_EXT = 0x8F47;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4_EXT = 0x8F48;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x3_EXT = 0x8F49;

		/// <summary>
		/// Value of GL_DOUBLE_MAT2x4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT2x4_EXT = 0x8F4A;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x2_EXT = 0x8F4B;

		/// <summary>
		/// Value of GL_DOUBLE_MAT3x4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT3x4_EXT = 0x8F4C;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x2_EXT = 0x8F4D;

		/// <summary>
		/// Value of GL_DOUBLE_MAT4x3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE_MAT4x3_EXT = 0x8F4E;

		/// <summary>
		/// Binding for glVertexAttribL1dEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1EXT(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1dEXT != null, "pglVertexAttribL1dEXT not implemented");
			Delegates.pglVertexAttribL1dEXT(index, x);
			CallLog("glVertexAttribL1dEXT({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL2dEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2EXT(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2dEXT != null, "pglVertexAttribL2dEXT not implemented");
			Delegates.pglVertexAttribL2dEXT(index, x, y);
			CallLog("glVertexAttribL2dEXT({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL3dEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3EXT(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3dEXT != null, "pglVertexAttribL3dEXT not implemented");
			Delegates.pglVertexAttribL3dEXT(index, x, y, z);
			CallLog("glVertexAttribL3dEXT({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL4dEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4EXT(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4dEXT != null, "pglVertexAttribL4dEXT not implemented");
			Delegates.pglVertexAttribL4dEXT(index, x, y, z, w);
			CallLog("glVertexAttribL4dEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL1dvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1EXT(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1dvEXT != null, "pglVertexAttribL1dvEXT not implemented");
					Delegates.pglVertexAttribL1dvEXT(index, p_v);
					CallLog("glVertexAttribL1dvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL2dvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2EXT(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2dvEXT != null, "pglVertexAttribL2dvEXT not implemented");
					Delegates.pglVertexAttribL2dvEXT(index, p_v);
					CallLog("glVertexAttribL2dvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL3dvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3EXT(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3dvEXT != null, "pglVertexAttribL3dvEXT not implemented");
					Delegates.pglVertexAttribL3dvEXT(index, p_v);
					CallLog("glVertexAttribL3dvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL4dvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4EXT(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4dvEXT != null, "pglVertexAttribL4dvEXT not implemented");
					Delegates.pglVertexAttribL4dvEXT(index, p_v);
					CallLog("glVertexAttribL4dvEXT({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribLPointerEXT.
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
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribLPointerEXT != null, "pglVertexAttribLPointerEXT not implemented");
			Delegates.pglVertexAttribLPointerEXT(index, size, type, stride, pointer);
			CallLog("glVertexAttribLPointerEXT({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribLPointerEXT.
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
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribLPointerEXT(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glGetVertexAttribLdvEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void GetVertexAttribLEXT(UInt32 index, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLdvEXT != null, "pglGetVertexAttribLdvEXT not implemented");
					Delegates.pglGetVertexAttribLdvEXT(index, pname, p_params);
					CallLog("glGetVertexAttribLdvEXT({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
