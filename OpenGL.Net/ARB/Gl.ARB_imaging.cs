
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
		/// Value of GL_BLEND_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int BLEND_COLOR = 0x8005;

		/// <summary>
		/// Value of GL_BLEND_EQUATION symbol.
		/// </summary>
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int BLEND_EQUATION = 0x8009;

		/// <summary>
		/// Value of GL_CONVOLUTION_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_1D = 0x8010;

		/// <summary>
		/// Value of GL_CONVOLUTION_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_2D = 0x8011;

		/// <summary>
		/// Value of GL_SEPARABLE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int SEPARABLE_2D = 0x8012;

		/// <summary>
		/// Value of GL_CONVOLUTION_BORDER_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_BORDER_MODE = 0x8013;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FILTER_SCALE = 0x8014;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FILTER_BIAS = 0x8015;

		/// <summary>
		/// Value of GL_REDUCE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int REDUCE = 0x8016;

		/// <summary>
		/// Value of GL_CONVOLUTION_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FORMAT = 0x8017;

		/// <summary>
		/// Value of GL_CONVOLUTION_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_WIDTH = 0x8018;

		/// <summary>
		/// Value of GL_CONVOLUTION_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_HEIGHT = 0x8019;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_CONVOLUTION_WIDTH = 0x801A;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_CONVOLUTION_HEIGHT = 0x801B;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_RED_SCALE = 0x801C;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_GREEN_SCALE = 0x801D;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_BLUE_SCALE = 0x801E;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_ALPHA_SCALE = 0x801F;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_RED_BIAS = 0x8020;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_GREEN_BIAS = 0x8021;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_BLUE_BIAS = 0x8022;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_ALPHA_BIAS = 0x8023;

		/// <summary>
		/// Value of GL_HISTOGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM = 0x8024;

		/// <summary>
		/// Value of GL_PROXY_HISTOGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_HISTOGRAM = 0x8025;

		/// <summary>
		/// Value of GL_HISTOGRAM_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_WIDTH = 0x8026;

		/// <summary>
		/// Value of GL_HISTOGRAM_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_FORMAT = 0x8027;

		/// <summary>
		/// Value of GL_HISTOGRAM_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_RED_SIZE = 0x8028;

		/// <summary>
		/// Value of GL_HISTOGRAM_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_GREEN_SIZE = 0x8029;

		/// <summary>
		/// Value of GL_HISTOGRAM_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_BLUE_SIZE = 0x802A;

		/// <summary>
		/// Value of GL_HISTOGRAM_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_ALPHA_SIZE = 0x802B;

		/// <summary>
		/// Value of GL_HISTOGRAM_LUMINANCE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_LUMINANCE_SIZE = 0x802C;

		/// <summary>
		/// Value of GL_HISTOGRAM_SINK symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_SINK = 0x802D;

		/// <summary>
		/// Value of GL_MINMAX symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX = 0x802E;

		/// <summary>
		/// Value of GL_MINMAX_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX_FORMAT = 0x802F;

		/// <summary>
		/// Value of GL_MINMAX_SINK symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX_SINK = 0x8030;

		/// <summary>
		/// Value of GL_TABLE_TOO_LARGE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int TABLE_TOO_LARGE = 0x8031;

		/// <summary>
		/// Value of GL_COLOR_MATRIX symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_MATRIX = 0x80B1;

		/// <summary>
		/// Value of GL_COLOR_MATRIX_STACK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_MATRIX_STACK_DEPTH = 0x80B2;

		/// <summary>
		/// Value of GL_MAX_COLOR_MATRIX_STACK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_RED_SCALE = 0x80B4;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_RED_BIAS = 0x80B8;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

		/// <summary>
		/// Value of GL_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE = 0x80D0;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_COLOR_TABLE = 0x80D1;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;

		/// <summary>
		/// Value of GL_PROXY_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_COLOR_TABLE = 0x80D3;

		/// <summary>
		/// Value of GL_PROXY_POST_CONVOLUTION_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;

		/// <summary>
		/// Value of GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;

		/// <summary>
		/// Value of GL_COLOR_TABLE_SCALE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_SCALE = 0x80D6;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_BIAS = 0x80D7;

		/// <summary>
		/// Value of GL_COLOR_TABLE_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_FORMAT = 0x80D8;

		/// <summary>
		/// Value of GL_COLOR_TABLE_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_WIDTH = 0x80D9;

		/// <summary>
		/// Value of GL_COLOR_TABLE_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_RED_SIZE = 0x80DA;

		/// <summary>
		/// Value of GL_COLOR_TABLE_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_GREEN_SIZE = 0x80DB;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_BLUE_SIZE = 0x80DC;

		/// <summary>
		/// Value of GL_COLOR_TABLE_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_ALPHA_SIZE = 0x80DD;

		/// <summary>
		/// Value of GL_COLOR_TABLE_LUMINANCE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;

		/// <summary>
		/// Value of GL_COLOR_TABLE_INTENSITY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

		/// <summary>
		/// Value of GL_CONSTANT_BORDER symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_BORDER = 0x8151;

		/// <summary>
		/// Value of GL_REPLICATE_BORDER symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int REPLICATE_BORDER = 0x8153;

		/// <summary>
		/// Value of GL_CONVOLUTION_BORDER_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_BORDER_COLOR = 0x8154;

		/// <summary>
		/// Binding for glColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorTable(int target, int internalformat, Int32 width, int format, int type, IntPtr table)
		{
			if        (Delegates.pglColorTable != null) {
				Delegates.pglColorTable(target, internalformat, width, format, type, table);
				CallLog("glColorTable({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else if (Delegates.pglColorTableEXT != null) {
				Delegates.pglColorTableEXT(target, internalformat, width, format, type, table);
				CallLog("glColorTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else if (Delegates.pglColorTableSGI != null) {
				Delegates.pglColorTableSGI(target, internalformat, width, format, type, table);
				CallLog("glColorTableSGI({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else
				throw new NotImplementedException("glColorTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorTable(int target, int internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr table)
		{
			if        (Delegates.pglColorTable != null) {
				Delegates.pglColorTable(target, internalformat, width, (int)format, (int)type, table);
				CallLog("glColorTable({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else if (Delegates.pglColorTableEXT != null) {
				Delegates.pglColorTableEXT(target, internalformat, width, (int)format, (int)type, table);
				CallLog("glColorTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else if (Delegates.pglColorTableSGI != null) {
				Delegates.pglColorTableSGI(target, internalformat, width, (int)format, (int)type, table);
				CallLog("glColorTableSGI({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			} else
				throw new NotImplementedException("glColorTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorTable(int target, int internalformat, Int32 width, int format, int type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				ColorTable(target, internalformat, width, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glColorTableParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorTableParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglColorTableParameterfv != null) {
						Delegates.pglColorTableParameterfv(target, pname, p_params);
						CallLog("glColorTableParameterfv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglColorTableParameterfvSGI != null) {
						Delegates.pglColorTableParameterfvSGI(target, pname, p_params);
						CallLog("glColorTableParameterfvSGI({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glColorTableParameterfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTableParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorTableParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglColorTableParameteriv != null) {
						Delegates.pglColorTableParameteriv(target, pname, p_params);
						CallLog("glColorTableParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglColorTableParameterivSGI != null) {
						Delegates.pglColorTableParameterivSGI(target, pname, p_params);
						CallLog("glColorTableParameterivSGI({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glColorTableParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width)
		{
			if        (Delegates.pglCopyColorTable != null) {
				Delegates.pglCopyColorTable(target, internalformat, x, y, width);
				CallLog("glCopyColorTable({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			} else if (Delegates.pglCopyColorTableSGI != null) {
				Delegates.pglCopyColorTableSGI(target, internalformat, x, y, width);
				CallLog("glCopyColorTableSGI({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			} else
				throw new NotImplementedException("glCopyColorTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetColorTable(int target, int format, int type, IntPtr table)
		{
			if        (Delegates.pglGetColorTable != null) {
				Delegates.pglGetColorTable(target, format, type, table);
				CallLog("glGetColorTable({0}, {1}, {2}, {3})", target, format, type, table);
			} else if (Delegates.pglGetColorTableEXT != null) {
				Delegates.pglGetColorTableEXT(target, format, type, table);
				CallLog("glGetColorTableEXT({0}, {1}, {2}, {3})", target, format, type, table);
			} else
				throw new NotImplementedException("glGetColorTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetColorTable(int target, PixelFormat format, PixelType type, IntPtr table)
		{
			if        (Delegates.pglGetColorTable != null) {
				Delegates.pglGetColorTable(target, (int)format, (int)type, table);
				CallLog("glGetColorTable({0}, {1}, {2}, {3})", target, format, type, table);
			} else if (Delegates.pglGetColorTableEXT != null) {
				Delegates.pglGetColorTableEXT(target, (int)format, (int)type, table);
				CallLog("glGetColorTableEXT({0}, {1}, {2}, {3})", target, format, type, table);
			} else
				throw new NotImplementedException("glGetColorTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetColorTableParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglGetColorTableParameterfv != null) {
						Delegates.pglGetColorTableParameterfv(target, pname, p_params);
						CallLog("glGetColorTableParameterfv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetColorTableParameterfvEXT != null) {
						Delegates.pglGetColorTableParameterfvEXT(target, pname, p_params);
						CallLog("glGetColorTableParameterfvEXT({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetColorTableParameterfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetColorTableParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetColorTableParameteriv != null) {
						Delegates.pglGetColorTableParameteriv(target, pname, p_params);
						CallLog("glGetColorTableParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetColorTableParameterivEXT != null) {
						Delegates.pglGetColorTableParameterivEXT(target, pname, p_params);
						CallLog("glGetColorTableParameterivEXT({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetColorTableParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorSubTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, IntPtr data)
		{
			if        (Delegates.pglColorSubTable != null) {
				Delegates.pglColorSubTable(target, start, count, format, type, data);
				CallLog("glColorSubTable({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			} else if (Delegates.pglColorSubTableEXT != null) {
				Delegates.pglColorSubTableEXT(target, start, count, format, type, data);
				CallLog("glColorSubTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			} else
				throw new NotImplementedException("glColorSubTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorSubTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorSubTable(int target, Int32 start, Int32 count, PixelFormat format, PixelType type, IntPtr data)
		{
			if        (Delegates.pglColorSubTable != null) {
				Delegates.pglColorSubTable(target, start, count, (int)format, (int)type, data);
				CallLog("glColorSubTable({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			} else if (Delegates.pglColorSubTableEXT != null) {
				Delegates.pglColorSubTableEXT(target, start, count, (int)format, (int)type, data);
				CallLog("glColorSubTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			} else
				throw new NotImplementedException("glColorSubTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorSubTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ColorSubTable(target, start, count, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyColorSubTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width)
		{
			if        (Delegates.pglCopyColorSubTable != null) {
				Delegates.pglCopyColorSubTable(target, start, x, y, width);
				CallLog("glCopyColorSubTable({0}, {1}, {2}, {3}, {4})", target, start, x, y, width);
			} else if (Delegates.pglCopyColorSubTableEXT != null) {
				Delegates.pglCopyColorSubTableEXT(target, start, x, y, width);
				CallLog("glCopyColorSubTableEXT({0}, {1}, {2}, {3}, {4})", target, start, x, y, width);
			} else
				throw new NotImplementedException("glCopyColorSubTable (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, IntPtr image)
		{
			if        (Delegates.pglConvolutionFilter1D != null) {
				Delegates.pglConvolutionFilter1D(target, internalformat, width, format, type, image);
				CallLog("glConvolutionFilter1D({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, image);
			} else if (Delegates.pglConvolutionFilter1DEXT != null) {
				Delegates.pglConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
				CallLog("glConvolutionFilter1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, image);
			} else
				throw new NotImplementedException("glConvolutionFilter1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter1D(int target, int internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr image)
		{
			if        (Delegates.pglConvolutionFilter1D != null) {
				Delegates.pglConvolutionFilter1D(target, internalformat, width, (int)format, (int)type, image);
				CallLog("glConvolutionFilter1D({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, image);
			} else if (Delegates.pglConvolutionFilter1DEXT != null) {
				Delegates.pglConvolutionFilter1DEXT(target, internalformat, width, (int)format, (int)type, image);
				CallLog("glConvolutionFilter1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, image);
			} else
				throw new NotImplementedException("glConvolutionFilter1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter1D(target, internalformat, width, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image)
		{
			if        (Delegates.pglConvolutionFilter2D != null) {
				Delegates.pglConvolutionFilter2D(target, internalformat, width, height, format, type, image);
				CallLog("glConvolutionFilter2D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, width, height, format, type, image);
			} else if (Delegates.pglConvolutionFilter2DEXT != null) {
				Delegates.pglConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
				CallLog("glConvolutionFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, width, height, format, type, image);
			} else
				throw new NotImplementedException("glConvolutionFilter2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr image)
		{
			if        (Delegates.pglConvolutionFilter2D != null) {
				Delegates.pglConvolutionFilter2D(target, internalformat, width, height, (int)format, (int)type, image);
				CallLog("glConvolutionFilter2D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, width, height, format, type, image);
			} else if (Delegates.pglConvolutionFilter2DEXT != null) {
				Delegates.pglConvolutionFilter2DEXT(target, internalformat, width, height, (int)format, (int)type, image);
				CallLog("glConvolutionFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, width, height, format, type, image);
			} else
				throw new NotImplementedException("glConvolutionFilter2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter2D(target, internalformat, width, height, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionParameterf.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionParameter(int target, int pname, float @params)
		{
			if        (Delegates.pglConvolutionParameterf != null) {
				Delegates.pglConvolutionParameterf(target, pname, @params);
				CallLog("glConvolutionParameterf({0}, {1}, {2})", target, pname, @params);
			} else if (Delegates.pglConvolutionParameterfEXT != null) {
				Delegates.pglConvolutionParameterfEXT(target, pname, @params);
				CallLog("glConvolutionParameterfEXT({0}, {1}, {2})", target, pname, @params);
			} else
				throw new NotImplementedException("glConvolutionParameterf (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglConvolutionParameterfv != null) {
						Delegates.pglConvolutionParameterfv(target, pname, p_params);
						CallLog("glConvolutionParameterfv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglConvolutionParameterfvEXT != null) {
						Delegates.pglConvolutionParameterfvEXT(target, pname, p_params);
						CallLog("glConvolutionParameterfvEXT({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glConvolutionParameterfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameteri.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionParameter(int target, int pname, Int32 @params)
		{
			if        (Delegates.pglConvolutionParameteri != null) {
				Delegates.pglConvolutionParameteri(target, pname, @params);
				CallLog("glConvolutionParameteri({0}, {1}, {2})", target, pname, @params);
			} else if (Delegates.pglConvolutionParameteriEXT != null) {
				Delegates.pglConvolutionParameteriEXT(target, pname, @params);
				CallLog("glConvolutionParameteriEXT({0}, {1}, {2})", target, pname, @params);
			} else
				throw new NotImplementedException("glConvolutionParameteri (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ConvolutionParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglConvolutionParameteriv != null) {
						Delegates.pglConvolutionParameteriv(target, pname, p_params);
						CallLog("glConvolutionParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglConvolutionParameterivEXT != null) {
						Delegates.pglConvolutionParameterivEXT(target, pname, p_params);
						CallLog("glConvolutionParameterivEXT({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glConvolutionParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyConvolutionFilter1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width)
		{
			if        (Delegates.pglCopyConvolutionFilter1D != null) {
				Delegates.pglCopyConvolutionFilter1D(target, internalformat, x, y, width);
				CallLog("glCopyConvolutionFilter1D({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			} else if (Delegates.pglCopyConvolutionFilter1DEXT != null) {
				Delegates.pglCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
				CallLog("glCopyConvolutionFilter1DEXT({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			} else
				throw new NotImplementedException("glCopyConvolutionFilter1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyConvolutionFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyConvolutionFilter2D != null) {
				Delegates.pglCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
				CallLog("glCopyConvolutionFilter2D({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, x, y, width, height);
			} else if (Delegates.pglCopyConvolutionFilter2DEXT != null) {
				Delegates.pglCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
				CallLog("glCopyConvolutionFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyConvolutionFilter2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetConvolutionFilter(int target, int format, int type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, format, type, image);
			CallLog("glGetConvolutionFilter({0}, {1}, {2}, {3})", target, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetConvolutionFilter(int target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, (int)format, (int)type, image);
			CallLog("glGetConvolutionFilter({0}, {1}, {2}, {3})", target, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetConvolutionParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfv != null, "pglGetConvolutionParameterfv not implemented");
					Delegates.pglGetConvolutionParameterfv(target, pname, p_params);
					CallLog("glGetConvolutionParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetConvolutionParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameteriv != null, "pglGetConvolutionParameteriv not implemented");
					Delegates.pglGetConvolutionParameteriv(target, pname, p_params);
					CallLog("glGetConvolutionParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetSeparableFilter(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, format, type, row, column, span);
			CallLog("glGetSeparableFilter({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetSeparableFilter(int target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, (int)format, (int)type, row, column, span);
			CallLog("glGetSeparableFilter({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSeparableFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column)
		{
			if        (Delegates.pglSeparableFilter2D != null) {
				Delegates.pglSeparableFilter2D(target, internalformat, width, height, format, type, row, column);
				CallLog("glSeparableFilter2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, internalformat, width, height, format, type, row, column);
			} else if (Delegates.pglSeparableFilter2DEXT != null) {
				Delegates.pglSeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);
				CallLog("glSeparableFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, internalformat, width, height, format, type, row, column);
			} else
				throw new NotImplementedException("glSeparableFilter2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSeparableFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
		{
			if        (Delegates.pglSeparableFilter2D != null) {
				Delegates.pglSeparableFilter2D(target, internalformat, width, height, (int)format, (int)type, row, column);
				CallLog("glSeparableFilter2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, internalformat, width, height, format, type, row, column);
			} else if (Delegates.pglSeparableFilter2DEXT != null) {
				Delegates.pglSeparableFilter2DEXT(target, internalformat, width, height, (int)format, (int)type, row, column);
				CallLog("glSeparableFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, internalformat, width, height, format, type, row, column);
			} else
				throw new NotImplementedException("glSeparableFilter2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSeparableFilter2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, Object row, Object column)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			try {
				SeparableFilter2D(target, internalformat, width, height, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
			}
		}

		/// <summary>
		/// Binding for glGetHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetHistogram(int target, bool reset, int format, int type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, format, type, values);
			CallLog("glGetHistogram({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetHistogram(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, (int)format, (int)type, values);
			CallLog("glGetHistogram({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetHistogramParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetHistogramParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterfv != null, "pglGetHistogramParameterfv not implemented");
					Delegates.pglGetHistogramParameterfv(target, pname, p_params);
					CallLog("glGetHistogramParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetHistogramParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetHistogramParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameteriv != null, "pglGetHistogramParameteriv not implemented");
					Delegates.pglGetHistogramParameteriv(target, pname, p_params);
					CallLog("glGetHistogramParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMinmax(int target, bool reset, int format, int type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, format, type, values);
			CallLog("glGetMinmax({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMinmax(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, (int)format, (int)type, values);
			CallLog("glGetMinmax({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMinmaxParameterfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMinmaxParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterfv != null, "pglGetMinmaxParameterfv not implemented");
					Delegates.pglGetMinmaxParameterfv(target, pname, p_params);
					CallLog("glGetMinmaxParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMinmaxParameteriv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMinmaxParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameteriv != null, "pglGetMinmaxParameteriv not implemented");
					Delegates.pglGetMinmaxParameteriv(target, pname, p_params);
					CallLog("glGetMinmaxParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sink">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Histogram(int target, Int32 width, int internalformat, bool sink)
		{
			if        (Delegates.pglHistogram != null) {
				Delegates.pglHistogram(target, width, internalformat, sink);
				CallLog("glHistogram({0}, {1}, {2}, {3})", target, width, internalformat, sink);
			} else if (Delegates.pglHistogramEXT != null) {
				Delegates.pglHistogramEXT(target, width, internalformat, sink);
				CallLog("glHistogramEXT({0}, {1}, {2}, {3})", target, width, internalformat, sink);
			} else
				throw new NotImplementedException("glHistogram (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sink">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Minmax(int target, int internalformat, bool sink)
		{
			if        (Delegates.pglMinmax != null) {
				Delegates.pglMinmax(target, internalformat, sink);
				CallLog("glMinmax({0}, {1}, {2})", target, internalformat, sink);
			} else if (Delegates.pglMinmaxEXT != null) {
				Delegates.pglMinmaxEXT(target, internalformat, sink);
				CallLog("glMinmaxEXT({0}, {1}, {2})", target, internalformat, sink);
			} else
				throw new NotImplementedException("glMinmax (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResetHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ResetHistogram(int target)
		{
			if        (Delegates.pglResetHistogram != null) {
				Delegates.pglResetHistogram(target);
				CallLog("glResetHistogram({0})", target);
			} else if (Delegates.pglResetHistogramEXT != null) {
				Delegates.pglResetHistogramEXT(target);
				CallLog("glResetHistogramEXT({0})", target);
			} else
				throw new NotImplementedException("glResetHistogram (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResetMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ResetMinmax(int target)
		{
			if        (Delegates.pglResetMinmax != null) {
				Delegates.pglResetMinmax(target);
				CallLog("glResetMinmax({0})", target);
			} else if (Delegates.pglResetMinmaxEXT != null) {
				Delegates.pglResetMinmaxEXT(target);
				CallLog("glResetMinmaxEXT({0})", target);
			} else
				throw new NotImplementedException("glResetMinmax (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
