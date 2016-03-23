
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
		/// Value of GL_EVAL_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_2D_NV = 0x86C0;

		/// <summary>
		/// Value of GL_EVAL_TRIANGULAR_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_TRIANGULAR_2D_NV = 0x86C1;

		/// <summary>
		/// Value of GL_MAP_TESSELLATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int MAP_TESSELLATION_NV = 0x86C2;

		/// <summary>
		/// Value of GL_MAP_ATTRIB_U_ORDER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int MAP_ATTRIB_U_ORDER_NV = 0x86C3;

		/// <summary>
		/// Value of GL_MAP_ATTRIB_V_ORDER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int MAP_ATTRIB_V_ORDER_NV = 0x86C4;

		/// <summary>
		/// Value of GL_EVAL_FRACTIONAL_TESSELLATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB0_NV = 0x86C6;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB1_NV = 0x86C7;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB2_NV = 0x86C8;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB3_NV = 0x86C9;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB4_NV = 0x86CA;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB5_NV = 0x86CB;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB6_NV = 0x86CC;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB7_NV = 0x86CD;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB8_NV = 0x86CE;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB9_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB9_NV = 0x86CF;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB10_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB10_NV = 0x86D0;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB11_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB11_NV = 0x86D1;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB12_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB12_NV = 0x86D2;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB13_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB13_NV = 0x86D3;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB14_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB14_NV = 0x86D4;

		/// <summary>
		/// Value of GL_EVAL_VERTEX_ATTRIB15_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int EVAL_VERTEX_ATTRIB15_NV = 0x86D5;

		/// <summary>
		/// Value of GL_MAX_MAP_TESSELLATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int MAX_MAP_TESSELLATION_NV = 0x86D6;

		/// <summary>
		/// Value of GL_MAX_RATIONAL_EVAL_ORDER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_evaluators")]
		public const int MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;

		/// <summary>
		/// Binding for glMapControlPointsNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="packed">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void MapControlPointNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points)
		{
			Debug.Assert(Delegates.pglMapControlPointsNV != null, "pglMapControlPointsNV not implemented");
			Delegates.pglMapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points);
			LogFunction("glMapControlPointsNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", LogEnumName(target), index, LogEnumName(type), ustride, vstride, uorder, vorder, packed, points.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapControlPointsNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="packed">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void MapControlPointNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, Object points)
		{
			GCHandle pin_points = GCHandle.Alloc(points, GCHandleType.Pinned);
			try {
				MapControlPointNV(target, index, type, ustride, vstride, uorder, vorder, packed, pin_points.AddrOfPinnedObject());
			} finally {
				pin_points.Free();
			}
		}

		/// <summary>
		/// Binding for glMapParameterivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void MapParameterNV(Int32 target, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMapParameterivNV != null, "pglMapParameterivNV not implemented");
					Delegates.pglMapParameterivNV(target, pname, p_params);
					LogFunction("glMapParameterivNV({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapParameterfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void MapParameterNV(Int32 target, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMapParameterfvNV != null, "pglMapParameterfvNV not implemented");
					Delegates.pglMapParameterfvNV(target, pname, p_params);
					LogFunction("glMapParameterfvNV({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapControlPointsNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="packed">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapControlPointNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, bool packed, IntPtr points)
		{
			Debug.Assert(Delegates.pglGetMapControlPointsNV != null, "pglGetMapControlPointsNV not implemented");
			Delegates.pglGetMapControlPointsNV(target, index, type, ustride, vstride, packed, points);
			LogFunction("glGetMapControlPointsNV({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", LogEnumName(target), index, LogEnumName(type), ustride, vstride, packed, points.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapControlPointsNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="packed">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapControlPointNV(Int32 target, UInt32 index, Int32 type, Int32 ustride, Int32 vstride, bool packed, Object points)
		{
			GCHandle pin_points = GCHandle.Alloc(points, GCHandleType.Pinned);
			try {
				GetMapControlPointNV(target, index, type, ustride, vstride, packed, pin_points.AddrOfPinnedObject());
			} finally {
				pin_points.Free();
			}
		}

		/// <summary>
		/// Binding for glGetMapParameterivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapParameterNV(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMapParameterivNV != null, "pglGetMapParameterivNV not implemented");
					Delegates.pglGetMapParameterivNV(target, pname, p_params);
					LogFunction("glGetMapParameterivNV({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapParameterfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapParameterNV(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMapParameterfvNV != null, "pglGetMapParameterfvNV not implemented");
					Delegates.pglGetMapParameterfvNV(target, pname, p_params);
					LogFunction("glGetMapParameterfvNV({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapAttribParameterivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapAttribParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMapAttribParameterivNV != null, "pglGetMapAttribParameterivNV not implemented");
					Delegates.pglGetMapAttribParameterivNV(target, index, pname, p_params);
					LogFunction("glGetMapAttribParameterivNV({0}, {1}, {2}, {3})", LogEnumName(target), index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapAttribParameterfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void GetMapAttribParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMapAttribParameterfvNV != null, "pglGetMapAttribParameterfvNV not implemented");
					Delegates.pglGetMapAttribParameterfvNV(target, index, pname, p_params);
					LogFunction("glGetMapAttribParameterfvNV({0}, {1}, {2}, {3})", LogEnumName(target), index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvalMapsNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_evaluators")]
		public static void EvalMapNV(Int32 target, Int32 mode)
		{
			Debug.Assert(Delegates.pglEvalMapsNV != null, "pglEvalMapsNV not implemented");
			Delegates.pglEvalMapsNV(target, mode);
			LogFunction("glEvalMapsNV({0}, {1})", LogEnumName(target), LogEnumName(mode));
			DebugCheckErrors(null);
		}

	}

}
