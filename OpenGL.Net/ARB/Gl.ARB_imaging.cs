
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
		[AliasOf("GL_BLEND_COLOR_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int BLEND_COLOR = 0x8005;

		/// <summary>
		/// Value of GL_BLEND_EQUATION symbol.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int BLEND_EQUATION = 0x8009;

		/// <summary>
		/// Value of GL_CONVOLUTION_1D symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_1D_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_1D = 0x8010;

		/// <summary>
		/// Value of GL_CONVOLUTION_2D symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_2D_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_2D = 0x8011;

		/// <summary>
		/// Value of GL_SEPARABLE_2D symbol.
		/// </summary>
		[AliasOf("GL_SEPARABLE_2D_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int SEPARABLE_2D = 0x8012;

		/// <summary>
		/// Value of GL_CONVOLUTION_BORDER_MODE symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_BORDER_MODE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_BORDER_MODE = 0x8013;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_SCALE symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FILTER_SCALE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FILTER_SCALE = 0x8014;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_BIAS symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FILTER_BIAS_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FILTER_BIAS = 0x8015;

		/// <summary>
		/// Value of GL_REDUCE symbol.
		/// </summary>
		[AliasOf("GL_REDUCE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int REDUCE = 0x8016;

		/// <summary>
		/// Value of GL_CONVOLUTION_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FORMAT_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_FORMAT = 0x8017;

		/// <summary>
		/// Value of GL_CONVOLUTION_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_WIDTH_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_WIDTH = 0x8018;

		/// <summary>
		/// Value of GL_CONVOLUTION_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_HEIGHT_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_HEIGHT = 0x8019;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_MAX_CONVOLUTION_WIDTH_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_CONVOLUTION_WIDTH = 0x801A;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_MAX_CONVOLUTION_HEIGHT_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_CONVOLUTION_HEIGHT = 0x801B;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_RED_SCALE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_RED_SCALE = 0x801C;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_GREEN_SCALE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_GREEN_SCALE = 0x801D;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_BLUE_SCALE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_BLUE_SCALE = 0x801E;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_ALPHA_SCALE = 0x801F;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_RED_BIAS_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_RED_BIAS = 0x8020;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_GREEN_BIAS_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_GREEN_BIAS = 0x8021;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_BLUE_BIAS_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_BLUE_BIAS = 0x8022;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_ALPHA_BIAS = 0x8023;

		/// <summary>
		/// Value of GL_HISTOGRAM symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM = 0x8024;

		/// <summary>
		/// Value of GL_PROXY_HISTOGRAM symbol.
		/// </summary>
		[AliasOf("GL_PROXY_HISTOGRAM_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_HISTOGRAM = 0x8025;

		/// <summary>
		/// Value of GL_HISTOGRAM_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_WIDTH_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_WIDTH = 0x8026;

		/// <summary>
		/// Value of GL_HISTOGRAM_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_FORMAT_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_FORMAT = 0x8027;

		/// <summary>
		/// Value of GL_HISTOGRAM_RED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_RED_SIZE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_RED_SIZE = 0x8028;

		/// <summary>
		/// Value of GL_HISTOGRAM_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_GREEN_SIZE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_GREEN_SIZE = 0x8029;

		/// <summary>
		/// Value of GL_HISTOGRAM_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_BLUE_SIZE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_BLUE_SIZE = 0x802A;

		/// <summary>
		/// Value of GL_HISTOGRAM_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_ALPHA_SIZE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_ALPHA_SIZE = 0x802B;

		/// <summary>
		/// Value of GL_HISTOGRAM_LUMINANCE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_LUMINANCE_SIZE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_LUMINANCE_SIZE = 0x802C;

		/// <summary>
		/// Value of GL_HISTOGRAM_SINK symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_SINK_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int HISTOGRAM_SINK = 0x802D;

		/// <summary>
		/// Value of GL_MINMAX symbol.
		/// </summary>
		[AliasOf("GL_MINMAX_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX = 0x802E;

		/// <summary>
		/// Value of GL_MINMAX_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_MINMAX_FORMAT_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX_FORMAT = 0x802F;

		/// <summary>
		/// Value of GL_MINMAX_SINK symbol.
		/// </summary>
		[AliasOf("GL_MINMAX_SINK_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MINMAX_SINK = 0x8030;

		/// <summary>
		/// Value of GL_TABLE_TOO_LARGE symbol.
		/// </summary>
		[AliasOf("GL_TABLE_TOO_LARGE_EXT"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int TABLE_TOO_LARGE = 0x8031;

		/// <summary>
		/// Value of GL_COLOR_MATRIX symbol.
		/// </summary>
		[AliasOf("GL_COLOR_MATRIX_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_MATRIX = 0x80B1;

		/// <summary>
		/// Value of GL_COLOR_MATRIX_STACK_DEPTH symbol.
		/// </summary>
		[AliasOf("GL_COLOR_MATRIX_STACK_DEPTH_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_MATRIX_STACK_DEPTH = 0x80B2;

		/// <summary>
		/// Value of GL_MAX_COLOR_MATRIX_STACK_DEPTH symbol.
		/// </summary>
		[AliasOf("GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_RED_SCALE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_RED_SCALE = 0x80B4;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_SCALE symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_RED_BIAS_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_RED_BIAS = 0x80B8;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_BIAS symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

		/// <summary>
		/// Value of GL_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE = 0x80D0;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_CONVOLUTION_COLOR_TABLE = 0x80D1;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;

		/// <summary>
		/// Value of GL_PROXY_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_COLOR_TABLE = 0x80D3;

		/// <summary>
		/// Value of GL_PROXY_POST_CONVOLUTION_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;

		/// <summary>
		/// Value of GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;

		/// <summary>
		/// Value of GL_COLOR_TABLE_SCALE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_SCALE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_SCALE = 0x80D6;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BIAS symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_BIAS_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_BIAS = 0x80D7;

		/// <summary>
		/// Value of GL_COLOR_TABLE_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_FORMAT_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_FORMAT = 0x80D8;

		/// <summary>
		/// Value of GL_COLOR_TABLE_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_WIDTH_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_WIDTH = 0x80D9;

		/// <summary>
		/// Value of GL_COLOR_TABLE_RED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_RED_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_RED_SIZE = 0x80DA;

		/// <summary>
		/// Value of GL_COLOR_TABLE_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_GREEN_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_GREEN_SIZE = 0x80DB;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_BLUE_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_BLUE_SIZE = 0x80DC;

		/// <summary>
		/// Value of GL_COLOR_TABLE_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_ALPHA_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_ALPHA_SIZE = 0x80DD;

		/// <summary>
		/// Value of GL_COLOR_TABLE_LUMINANCE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;

		/// <summary>
		/// Value of GL_COLOR_TABLE_INTENSITY_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_INTENSITY_SIZE_SGI"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

		/// <summary>
		/// Value of GL_CONSTANT_BORDER symbol.
		/// </summary>
		[AliasOf("GL_CONSTANT_BORDER_HP"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_BORDER = 0x8151;

		/// <summary>
		/// Value of GL_REPLICATE_BORDER symbol.
		/// </summary>
		[AliasOf("GL_REPLICATE_BORDER_HP"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int REPLICATE_BORDER = 0x8153;

		/// <summary>
		/// Value of GL_CONVOLUTION_BORDER_COLOR symbol.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_BORDER_COLOR_HP"]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONVOLUTION_BORDER_COLOR = 0x8154;

		/// <summary>
		/// define a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.PROXY_COLOR_TABLE"/>, <see 
		/// cref="Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the color table. The allowable values are <see cref="Gl.ALPHA"/>, <see cref="Gl.ALPHA4"/>, <see 
		/// cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see cref="Gl.LUMINANCE16"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see cref="Gl.LUMINANCE6_ALPHA2"/>, <see 
		/// cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see cref="Gl.LUMINANCE12_ALPHA12"/>, <see 
		/// cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, 
		/// <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see 
		/// cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see 
		/// cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, and <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The number of entries in the color lookup table specified by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.PROXY_COLOR_TABLE"/>, <see 
		/// cref="Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the color table. The allowable values are <see cref="Gl.ALPHA"/>, <see cref="Gl.ALPHA4"/>, <see 
		/// cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see cref="Gl.LUMINANCE16"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see cref="Gl.LUMINANCE6_ALPHA2"/>, <see 
		/// cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see cref="Gl.LUMINANCE12_ALPHA12"/>, <see 
		/// cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, 
		/// <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see 
		/// cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see 
		/// cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, and <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The number of entries in the color lookup table specified by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void ColorTable(int target, int internalformat, Int32 width, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				ColorTable(target, internalformat, width, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// set color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a texture color lookup table parameter. Must be one of <see cref="Gl.COLOR_TABLE_SCALE"/> or <see 
		/// cref="Gl.COLOR_TABLE_BIAS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// set color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a texture color lookup table parameter. Must be one of <see cref="Gl.COLOR_TABLE_SCALE"/> or <see 
		/// cref="Gl.COLOR_TABLE_BIAS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// copy pixels into a color table
		/// </summary>
		/// <param name="target">
		/// The color table target. Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal storage format of the texture image. Must be one of the following symbolic constants: <see 
		/// cref="Gl.ALPHA"/>, <see cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, 
		/// <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="x">
		/// The x coordinate of the lower-left corner of the pixel rectangle to be transferred to the color table.
		/// </param>
		/// <param name="y">
		/// The y coordinate of the lower-left corner of the pixel rectangle to be transferred to the color table.
		/// </param>
		/// <param name="width">
		/// The width of the pixel rectangle.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// retrieve contents of a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="table"/>. The possible values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="table"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="table">
		/// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// retrieve contents of a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="table"/>. The possible values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="table"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="table">
		/// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetColorTable(int target, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetColorTable(target, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// get color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.PROXY_COLOR_TABLE"/>, <see 
		/// cref="Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a color lookup table parameter. Must be one of <see cref="Gl.COLOR_TABLE_BIAS"/>, <see 
		/// cref="Gl.COLOR_TABLE_SCALE"/>, <see cref="Gl.COLOR_TABLE_FORMAT"/>, <see cref="Gl.COLOR_TABLE_WIDTH"/>, <see 
		/// cref="Gl.COLOR_TABLE_RED_SIZE"/>, <see cref="Gl.COLOR_TABLE_GREEN_SIZE"/>, <see cref="Gl.COLOR_TABLE_BLUE_SIZE"/>, <see 
		/// cref="Gl.COLOR_TABLE_ALPHA_SIZE"/>, <see cref="Gl.COLOR_TABLE_LUMINANCE_SIZE"/>, or <see 
		/// cref="Gl.COLOR_TABLE_INTENSITY_SIZE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.PROXY_COLOR_TABLE"/>, <see 
		/// cref="Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a color lookup table parameter. Must be one of <see cref="Gl.COLOR_TABLE_BIAS"/>, <see 
		/// cref="Gl.COLOR_TABLE_SCALE"/>, <see cref="Gl.COLOR_TABLE_FORMAT"/>, <see cref="Gl.COLOR_TABLE_WIDTH"/>, <see 
		/// cref="Gl.COLOR_TABLE_RED_SIZE"/>, <see cref="Gl.COLOR_TABLE_GREEN_SIZE"/>, <see cref="Gl.COLOR_TABLE_BLUE_SIZE"/>, <see 
		/// cref="Gl.COLOR_TABLE_ALPHA_SIZE"/>, <see cref="Gl.COLOR_TABLE_LUMINANCE_SIZE"/>, or <see 
		/// cref="Gl.COLOR_TABLE_INTENSITY_SIZE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// respecify a portion of a color table
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="start">
		/// The starting index of the portion of the color table to be replaced.
		/// </param>
		/// <param name="count">
		/// The number of table entries to replace.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="data">
		/// Pointer to a one-dimensional array of pixel data that is processed to replace the specified region of the color table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// respecify a portion of a color table
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="start">
		/// The starting index of the portion of the color table to be replaced.
		/// </param>
		/// <param name="count">
		/// The number of table entries to replace.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, and <see 
		/// cref="Gl.BGRA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="data">
		/// Pointer to a one-dimensional array of pixel data that is processed to replace the specified region of the color table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void ColorSubTable(int target, Int32 start, Int32 count, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ColorSubTable(target, start, count, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// respecify a portion of a color table
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// </param>
		/// <param name="start">
		/// The starting index of the portion of the color table to be replaced.
		/// </param>
		/// <param name="x">
		/// The window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// The window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// The number of table entries to replace.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_1D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_1D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void ConvolutionFilter1D(int target, int internalformat, Int32 width, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter1D(target, internalformat, width, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// define a two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_2D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="height">
		/// The height of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define a two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_2D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="height">
		/// The height of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter2D(target, internalformat, width, height, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be <see cref="Gl.CONVOLUTION_BORDER_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be <see cref="Gl.CONVOLUTION_BORDER_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be <see cref="Gl.CONVOLUTION_BORDER_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be <see cref="Gl.CONVOLUTION_BORDER_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// copy pixels into a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_1D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="x">
		/// The window space coordinates of the lower-left coordinate of the pixel array to copy.
		/// </param>
		/// <param name="y">
		/// The window space coordinates of the lower-left coordinate of the pixel array to copy.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array to copy.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// copy pixels into a two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.CONVOLUTION_2D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="x">
		/// The window space coordinates of the lower-left coordinate of the pixel array to copy.
		/// </param>
		/// <param name="y">
		/// The window space coordinates of the lower-left coordinate of the pixel array to copy.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array to copy.
		/// </param>
		/// <param name="height">
		/// The height of the pixel array to copy.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get current 1D or 2D convolution filter kernel
		/// </summary>
		/// <param name="target">
		/// The filter to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_1D"/> or <see cref="Gl.CONVOLUTION_2D"/>.
		/// </param>
		/// <param name="format">
		/// Format of the output image. Must be one of <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output image. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, 
		/// <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// Pointer to storage for the output image.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetConvolutionFilter(int target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, (int)format, (int)type, image);
			CallLog("glGetConvolutionFilter({0}, {1}, {2}, {3})", target, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// get current 1D or 2D convolution filter kernel
		/// </summary>
		/// <param name="target">
		/// The filter to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_1D"/> or <see cref="Gl.CONVOLUTION_2D"/>.
		/// </param>
		/// <param name="format">
		/// Format of the output image. Must be one of <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output image. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, 
		/// <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="image">
		/// Pointer to storage for the output image.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetConvolutionFilter(int target, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilter(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// get convolution parameters
		/// </summary>
		/// <param name="target">
		/// The filter whose parameters are to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_BORDER_MODE"/>, <see 
		/// cref="Gl.CONVOLUTION_BORDER_COLOR"/>, <see cref="Gl.CONVOLUTION_FILTER_SCALE"/>, <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/>, <see cref="Gl.CONVOLUTION_FORMAT"/>, <see cref="Gl.CONVOLUTION_WIDTH"/>, <see 
		/// cref="Gl.CONVOLUTION_HEIGHT"/>, <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>, or <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get convolution parameters
		/// </summary>
		/// <param name="target">
		/// The filter whose parameters are to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of <see cref="Gl.CONVOLUTION_BORDER_MODE"/>, <see 
		/// cref="Gl.CONVOLUTION_BORDER_COLOR"/>, <see cref="Gl.CONVOLUTION_FILTER_SCALE"/>, <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/>, <see cref="Gl.CONVOLUTION_FORMAT"/>, <see cref="Gl.CONVOLUTION_WIDTH"/>, <see 
		/// cref="Gl.CONVOLUTION_HEIGHT"/>, <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>, or <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get separable convolution filter kernel images
		/// </summary>
		/// <param name="target">
		/// The separable filter to be retrieved. Must be <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="format">
		/// Format of the output images. Must be one of <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/><see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output images. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, 
		/// <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to storage for the row filter image.
		/// </param>
		/// <param name="column">
		/// Pointer to storage for the column filter image.
		/// </param>
		/// <param name="span">
		/// Pointer to storage for the span filter image (currently unused).
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetSeparableFilter(int target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, (int)format, (int)type, row, column, span);
			CallLog("glGetSeparableFilter({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// get separable convolution filter kernel images
		/// </summary>
		/// <param name="target">
		/// The separable filter to be retrieved. Must be <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="format">
		/// Format of the output images. Must be one of <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/><see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output images. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, 
		/// <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to storage for the row filter image.
		/// </param>
		/// <param name="column">
		/// Pointer to storage for the column filter image.
		/// </param>
		/// <param name="span">
		/// Pointer to storage for the span filter image (currently unused).
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetSeparableFilter(int target, PixelFormat format, PixelType type, Object row, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilter(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// define a separable two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The number of elements in the pixel array referenced by <paramref name="row"/>. (This is the width of the separable 
		/// filter kernel.)
		/// </param>
		/// <param name="height">
		/// The number of elements in the pixel array referenced by <paramref name="column"/>. (This is the height of the separable 
		/// filter kernel.)
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="row"/> and <paramref name="column"/>. The allowable values are <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.LUMINANCE"/>, 
		/// and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="row"/> and <paramref name="column"/>. Symbolic constants <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see 
		/// cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the row filter kernel.
		/// </param>
		/// <param name="column">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the column filter kernel.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define a separable two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.SEPARABLE_2D"/>.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see 
		/// cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.INTENSITY"/>, <see 
		/// cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see cref="Gl.INTENSITY16"/>, <see 
		/// cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see 
		/// cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see 
		/// cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, 
		/// or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="width">
		/// The number of elements in the pixel array referenced by <paramref name="row"/>. (This is the width of the separable 
		/// filter kernel.)
		/// </param>
		/// <param name="height">
		/// The number of elements in the pixel array referenced by <paramref name="column"/>. (This is the height of the separable 
		/// filter kernel.)
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="row"/> and <paramref name="column"/>. The allowable values are <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.INTENSITY"/>, <see cref="Gl.LUMINANCE"/>, 
		/// and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="row"/> and <paramref name="column"/>. Symbolic constants <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see 
		/// cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the row filter kernel.
		/// </param>
		/// <param name="column">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the column filter kernel.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object row, Object column)
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
		/// get histogram table
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.HISTOGRAM"/>.
		/// </param>
		/// <param name="reset">
		/// If <see cref="Gl.TRUE"/>, each component counter that is actually returned is reset to zero. (Other counters are 
		/// unaffected.) If <see cref="Gl.FALSE"/>, none of the counters in the histogram table is modified.
		/// </param>
		/// <param name="format">
		/// The format of values to be returned in <paramref name="values"/>. Must be one of <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of values to be returned in <paramref name="values"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned histogram table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetHistogram(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, (int)format, (int)type, values);
			CallLog("glGetHistogram({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// get histogram table
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.HISTOGRAM"/>.
		/// </param>
		/// <param name="reset">
		/// If <see cref="Gl.TRUE"/>, each component counter that is actually returned is reset to zero. (Other counters are 
		/// unaffected.) If <see cref="Gl.FALSE"/>, none of the counters in the histogram table is modified.
		/// </param>
		/// <param name="format">
		/// The format of values to be returned in <paramref name="values"/>. Must be one of <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// The type of values to be returned in <paramref name="values"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned histogram table.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetHistogram(int target, bool reset, PixelFormat format, PixelType type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetHistogram(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// get histogram parameters
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.HISTOGRAM"/> or <see cref="Gl.PROXY_HISTOGRAM"/>.
		/// </param>
		/// <param name="pname">
		/// The name of the parameter to be retrieved. Must be one of <see cref="Gl.HISTOGRAM_WIDTH"/>, <see 
		/// cref="Gl.HISTOGRAM_FORMAT"/>, <see cref="Gl.HISTOGRAM_RED_SIZE"/>, <see cref="Gl.HISTOGRAM_GREEN_SIZE"/>, <see 
		/// cref="Gl.HISTOGRAM_BLUE_SIZE"/>, <see cref="Gl.HISTOGRAM_ALPHA_SIZE"/>, <see cref="Gl.HISTOGRAM_LUMINANCE_SIZE"/>, or 
		/// <see cref="Gl.HISTOGRAM_SINK"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get histogram parameters
		/// </summary>
		/// <param name="target">
		/// Must be one of <see cref="Gl.HISTOGRAM"/> or <see cref="Gl.PROXY_HISTOGRAM"/>.
		/// </param>
		/// <param name="pname">
		/// The name of the parameter to be retrieved. Must be one of <see cref="Gl.HISTOGRAM_WIDTH"/>, <see 
		/// cref="Gl.HISTOGRAM_FORMAT"/>, <see cref="Gl.HISTOGRAM_RED_SIZE"/>, <see cref="Gl.HISTOGRAM_GREEN_SIZE"/>, <see 
		/// cref="Gl.HISTOGRAM_BLUE_SIZE"/>, <see cref="Gl.HISTOGRAM_ALPHA_SIZE"/>, <see cref="Gl.HISTOGRAM_LUMINANCE_SIZE"/>, or 
		/// <see cref="Gl.HISTOGRAM_SINK"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get minimum and maximum pixel values
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		/// <param name="reset">
		/// If <see cref="Gl.TRUE"/>, all entries in the minmax table that are actually returned are reset to their initial values. 
		/// (Other entries are unaltered.) If <see cref="Gl.FALSE"/>, the minmax table is unaltered.
		/// </param>
		/// <param name="format">
		/// The format of the data to be returned in <paramref name="values"/>. Must be one of <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetMinmax(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, (int)format, (int)type, values);
			CallLog("glGetMinmax({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// get minimum and maximum pixel values
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		/// <param name="reset">
		/// If <see cref="Gl.TRUE"/>, all entries in the minmax table that are actually returned are reset to their initial values. 
		/// (Other entries are unaltered.) If <see cref="Gl.FALSE"/>, the minmax table is unaltered.
		/// </param>
		/// <param name="format">
		/// The format of the data to be returned in <paramref name="values"/>. Must be one of <see cref="Gl.RED"/>, <see 
		/// cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
		public static void GetMinmax(int target, bool reset, PixelFormat format, PixelType type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetMinmax(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// get minmax parameters
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of <see cref="Gl.MINMAX_FORMAT"/> or <see cref="Gl.MINMAX_SINK"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// get minmax parameters
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of <see cref="Gl.MINMAX_FORMAT"/> or <see cref="Gl.MINMAX_SINK"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define histogram table
		/// </summary>
		/// <param name="target">
		/// The histogram whose parameters are to be set. Must be one of <see cref="Gl.HISTOGRAM"/> or <see 
		/// cref="Gl.PROXY_HISTOGRAM"/>.
		/// </param>
		/// <param name="width">
		/// The number of entries in the histogram table. Must be a power of 2.
		/// </param>
		/// <param name="internalformat">
		/// The format of entries in the histogram table. Must be one of <see cref="Gl.ALPHA"/>, <see cref="Gl.ALPHA4"/>, <see 
		/// cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see cref="Gl.LUMINANCE16"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see cref="Gl.LUMINANCE6_ALPHA2"/>, <see 
		/// cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see cref="Gl.LUMINANCE12_ALPHA12"/>, <see 
		/// cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see 
		/// cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="sink">
		/// If <see cref="Gl.TRUE"/>, pixels will be consumed by the histogramming process and no drawing or texture loading will 
		/// take place. If <see cref="Gl.FALSE"/>, pixels will proceed to the minmax process after histogramming.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// define minmax table
		/// </summary>
		/// <param name="target">
		/// The minmax table whose parameters are to be set. Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		/// <param name="internalformat">
		/// The format of entries in the minmax table. Must be one of <see cref="Gl.ALPHA"/>, <see cref="Gl.ALPHA4"/>, <see 
		/// cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see cref="Gl.LUMINANCE"/>, <see 
		/// cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see cref="Gl.LUMINANCE12"/>, <see cref="Gl.LUMINANCE16"/>, <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.LUMINANCE4_ALPHA4"/>, <see cref="Gl.LUMINANCE6_ALPHA2"/>, <see 
		/// cref="Gl.LUMINANCE8_ALPHA8"/>, <see cref="Gl.LUMINANCE12_ALPHA4"/>, <see cref="Gl.LUMINANCE12_ALPHA12"/>, <see 
		/// cref="Gl.LUMINANCE16_ALPHA16"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGB4"/>, <see 
		/// cref="Gl.RGB5"/>, <see cref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see 
		/// cref="Gl.RGBA"/>, <see cref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>, <see cref="Gl.RGBA12"/>, or <see cref="Gl.RGBA16"/>.
		/// </param>
		/// <param name="sink">
		/// If <see cref="Gl.TRUE"/>, pixels will be consumed by the minmax process and no drawing or texture loading will take 
		/// place. If <see cref="Gl.FALSE"/>, pixels will proceed to the final conversion process after minmax.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// reset histogram table entries to zero
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.HISTOGRAM"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
		/// reset minmax table entries to initial values
		/// </summary>
		/// <param name="target">
		/// Must be <see cref="Gl.MINMAX"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_imaging")]
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
