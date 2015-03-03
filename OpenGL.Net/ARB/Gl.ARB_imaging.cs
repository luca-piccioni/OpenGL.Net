
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
		/// <remarks>
		/// <see cref="Gl.ColorTable"/> may be used in two ways: to test the actual size and color resolution of a lookup table 
		/// given a particular set of parameters, or to load the contents of a color lookup table. Use the targets <see 
		/// cref="Gl.PROXY_*"/> for the first case and the other targets for the second case.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a color table is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// If <paramref name="target"/> is <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.ColorTable"/> builds a color lookup table from an array of 
		/// pixels. The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and 
		/// <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing 
		/// stops after the final expansion to RGBA is completed.
		/// The four scale parameters and the four bias parameters that are defined for the table are then used to scale and bias 
		/// the R, G, B, and A components of each pixel. (Use <see cref="Gl.ColorTableParameter"/> to set these scale and bias 
		/// parameters.)
		/// Next, the R, G, B, and A values are clamped to the range 01. Each pixel is then converted to the internal format 
		/// specified by <paramref name="internalformat"/>. This conversion simply maps the component values of the pixel (R, G, B, 
		/// and A) to the values included in the internal format (red, green, blue, alpha, luminance, and intensity). The mapping is 
		/// as follows:
		/// Finally, the red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in the 
		/// color table. They form a one-dimensional table with indices in the range 0width-1.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_*"/>, <see cref="Gl.ColorTable"/> recomputes and stores the values 
		/// of the proxy color table's state variables <see cref="Gl.COLOR_TABLE_FORMAT"/>, <see cref="Gl.COLOR_TABLE_WIDTH"/>, <see 
		/// cref="Gl.COLOR_TABLE_RED_SIZE"/>, <see cref="Gl.COLOR_TABLE_GREEN_SIZE"/>, <see cref="Gl.COLOR_TABLE_BLUE_SIZE"/>, <see 
		/// cref="Gl.COLOR_TABLE_ALPHA_SIZE"/>, <see cref="Gl.COLOR_TABLE_LUMINANCE_SIZE"/>, and <see 
		/// cref="Gl.COLOR_TABLE_INTENSITY_SIZE"/>. There is no effect on the image or state of any actual color table. If the 
		/// specified color table is too large to be supported, then all the proxy state variables listed above are set to zero. 
		/// Otherwise, the color table could be supported by <see cref="Gl.ColorTable"/> using the corresponding non-proxy target, 
		/// and the proxy state variables are set as if that target were being defined.
		/// The proxy state variables can be retrieved by calling Gl.GetColorTableParameter with a target of <see 
		/// cref="Gl.PROXY_*"/>. This allows the application to decide if a particular <see cref="Gl.ColorTable"/> command would 
		/// succeed, and to determine what the resulting color table attributes would be.
		/// If a color table is enabled, and its width is non-zero, then its contents are used to replace a subset of the components 
		/// of each RGBA pixel group, based on the internal format of the table.
		/// Each pixel group has color components (R, G, B, A) that are in the range 0.01.0. The color components are rescaled to 
		/// the size of the color lookup table to form an index. Then a subset of the components based on the internal format of the 
		/// table are replaced by the table entry selected by that index. If the color components and contents of the table are 
		/// represented as follows:
		/// then the result of color table lookup is as follows:
		/// When <see cref="Gl.COLOR_TABLE"/> is enabled, the colors resulting from the pixel map operation (if it is enabled) are 
		/// mapped by the color lookup table before being passed to the convolution operation. The colors resulting from the 
		/// convolution operation are modified by the post convolution color lookup table when <see 
		/// cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/> is enabled. These modified colors are then sent to the color matrix operation. 
		/// Finally, if <see cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/> is enabled, the colors resulting from the color matrix 
		/// operation are mapped by the post color matrix color lookup table before being used by the histogram operation.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero.
		/// - <see cref="Gl.TABLE_TOO_LARGE"/> is generated if the requested color table is too large to be supported by the 
		///   implementation, and <paramref name="target"/> is not a <see cref="Gl.PROXY_*"/> target.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorTable"/> may be used in two ways: to test the actual size and color resolution of a lookup table 
		/// given a particular set of parameters, or to load the contents of a color lookup table. Use the targets <see 
		/// cref="Gl.PROXY_*"/> for the first case and the other targets for the second case.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a color table is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// If <paramref name="target"/> is <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.ColorTable"/> builds a color lookup table from an array of 
		/// pixels. The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and 
		/// <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing 
		/// stops after the final expansion to RGBA is completed.
		/// The four scale parameters and the four bias parameters that are defined for the table are then used to scale and bias 
		/// the R, G, B, and A components of each pixel. (Use <see cref="Gl.ColorTableParameter"/> to set these scale and bias 
		/// parameters.)
		/// Next, the R, G, B, and A values are clamped to the range 01. Each pixel is then converted to the internal format 
		/// specified by <paramref name="internalformat"/>. This conversion simply maps the component values of the pixel (R, G, B, 
		/// and A) to the values included in the internal format (red, green, blue, alpha, luminance, and intensity). The mapping is 
		/// as follows:
		/// Finally, the red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in the 
		/// color table. They form a one-dimensional table with indices in the range 0width-1.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_*"/>, <see cref="Gl.ColorTable"/> recomputes and stores the values 
		/// of the proxy color table's state variables <see cref="Gl.COLOR_TABLE_FORMAT"/>, <see cref="Gl.COLOR_TABLE_WIDTH"/>, <see 
		/// cref="Gl.COLOR_TABLE_RED_SIZE"/>, <see cref="Gl.COLOR_TABLE_GREEN_SIZE"/>, <see cref="Gl.COLOR_TABLE_BLUE_SIZE"/>, <see 
		/// cref="Gl.COLOR_TABLE_ALPHA_SIZE"/>, <see cref="Gl.COLOR_TABLE_LUMINANCE_SIZE"/>, and <see 
		/// cref="Gl.COLOR_TABLE_INTENSITY_SIZE"/>. There is no effect on the image or state of any actual color table. If the 
		/// specified color table is too large to be supported, then all the proxy state variables listed above are set to zero. 
		/// Otherwise, the color table could be supported by <see cref="Gl.ColorTable"/> using the corresponding non-proxy target, 
		/// and the proxy state variables are set as if that target were being defined.
		/// The proxy state variables can be retrieved by calling Gl.GetColorTableParameter with a target of <see 
		/// cref="Gl.PROXY_*"/>. This allows the application to decide if a particular <see cref="Gl.ColorTable"/> command would 
		/// succeed, and to determine what the resulting color table attributes would be.
		/// If a color table is enabled, and its width is non-zero, then its contents are used to replace a subset of the components 
		/// of each RGBA pixel group, based on the internal format of the table.
		/// Each pixel group has color components (R, G, B, A) that are in the range 0.01.0. The color components are rescaled to 
		/// the size of the color lookup table to form an index. Then a subset of the components based on the internal format of the 
		/// table are replaced by the table entry selected by that index. If the color components and contents of the table are 
		/// represented as follows:
		/// then the result of color table lookup is as follows:
		/// When <see cref="Gl.COLOR_TABLE"/> is enabled, the colors resulting from the pixel map operation (if it is enabled) are 
		/// mapped by the color lookup table before being passed to the convolution operation. The colors resulting from the 
		/// convolution operation are modified by the post convolution color lookup table when <see 
		/// cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/> is enabled. These modified colors are then sent to the color matrix operation. 
		/// Finally, if <see cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/> is enabled, the colors resulting from the color matrix 
		/// operation are mapped by the post color matrix color lookup table before being used by the histogram operation.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero.
		/// - <see cref="Gl.TABLE_TOO_LARGE"/> is generated if the requested color table is too large to be supported by the 
		///   implementation, and <paramref name="target"/> is not a <see cref="Gl.PROXY_*"/> target.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ColorTable"/> may be used in two ways: to test the actual size and color resolution of a lookup table 
		/// given a particular set of parameters, or to load the contents of a color lookup table. Use the targets <see 
		/// cref="Gl.PROXY_*"/> for the first case and the other targets for the second case.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a color table is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// If <paramref name="target"/> is <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>, <see cref="Gl.ColorTable"/> builds a color lookup table from an array of 
		/// pixels. The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and 
		/// <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing 
		/// stops after the final expansion to RGBA is completed.
		/// The four scale parameters and the four bias parameters that are defined for the table are then used to scale and bias 
		/// the R, G, B, and A components of each pixel. (Use <see cref="Gl.ColorTableParameter"/> to set these scale and bias 
		/// parameters.)
		/// Next, the R, G, B, and A values are clamped to the range 01. Each pixel is then converted to the internal format 
		/// specified by <paramref name="internalformat"/>. This conversion simply maps the component values of the pixel (R, G, B, 
		/// and A) to the values included in the internal format (red, green, blue, alpha, luminance, and intensity). The mapping is 
		/// as follows:
		/// Finally, the red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in the 
		/// color table. They form a one-dimensional table with indices in the range 0width-1.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_*"/>, <see cref="Gl.ColorTable"/> recomputes and stores the values 
		/// of the proxy color table's state variables <see cref="Gl.COLOR_TABLE_FORMAT"/>, <see cref="Gl.COLOR_TABLE_WIDTH"/>, <see 
		/// cref="Gl.COLOR_TABLE_RED_SIZE"/>, <see cref="Gl.COLOR_TABLE_GREEN_SIZE"/>, <see cref="Gl.COLOR_TABLE_BLUE_SIZE"/>, <see 
		/// cref="Gl.COLOR_TABLE_ALPHA_SIZE"/>, <see cref="Gl.COLOR_TABLE_LUMINANCE_SIZE"/>, and <see 
		/// cref="Gl.COLOR_TABLE_INTENSITY_SIZE"/>. There is no effect on the image or state of any actual color table. If the 
		/// specified color table is too large to be supported, then all the proxy state variables listed above are set to zero. 
		/// Otherwise, the color table could be supported by <see cref="Gl.ColorTable"/> using the corresponding non-proxy target, 
		/// and the proxy state variables are set as if that target were being defined.
		/// The proxy state variables can be retrieved by calling Gl.GetColorTableParameter with a target of <see 
		/// cref="Gl.PROXY_*"/>. This allows the application to decide if a particular <see cref="Gl.ColorTable"/> command would 
		/// succeed, and to determine what the resulting color table attributes would be.
		/// If a color table is enabled, and its width is non-zero, then its contents are used to replace a subset of the components 
		/// of each RGBA pixel group, based on the internal format of the table.
		/// Each pixel group has color components (R, G, B, A) that are in the range 0.01.0. The color components are rescaled to 
		/// the size of the color lookup table to form an index. Then a subset of the components based on the internal format of the 
		/// table are replaced by the table entry selected by that index. If the color components and contents of the table are 
		/// represented as follows:
		/// then the result of color table lookup is as follows:
		/// When <see cref="Gl.COLOR_TABLE"/> is enabled, the colors resulting from the pixel map operation (if it is enabled) are 
		/// mapped by the color lookup table before being passed to the convolution operation. The colors resulting from the 
		/// convolution operation are modified by the post convolution color lookup table when <see 
		/// cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/> is enabled. These modified colors are then sent to the color matrix operation. 
		/// Finally, if <see cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/> is enabled, the colors resulting from the color matrix 
		/// operation are mapped by the post color matrix color lookup table before being used by the histogram operation.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero.
		/// - <see cref="Gl.TABLE_TOO_LARGE"/> is generated if the requested color table is too large to be supported by the 
		///   implementation, and <paramref name="target"/> is not a <see cref="Gl.PROXY_*"/> target.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorTableParameter"/> is used to specify the scale factors and bias terms applied to color components 
		/// when they are loaded into a color table. <paramref name="target"/> indicates which color table the scale and bias terms 
		/// apply to; it must be set to <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// <paramref name="pname"/> must be <see cref="Gl.COLOR_TABLE_SCALE"/> to set the scale factors. In this case, <paramref 
		/// name="params"/> points to an array of four values, which are the scale factors for red, green, blue, and alpha, in that 
		/// order.
		/// <paramref name="pname"/> must be <see cref="Gl.COLOR_TABLE_BIAS"/> to set the bias terms. In this case, <paramref 
		/// name="params"/> points to an array of four values, which are the bias terms for red, green, blue, and alpha, in that 
		/// order.
		/// The color tables themselves are specified by calling Gl.ColorTable.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable 
		///   value.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorTableParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorTableParameter"/> is used to specify the scale factors and bias terms applied to color components 
		/// when they are loaded into a color table. <paramref name="target"/> indicates which color table the scale and bias terms 
		/// apply to; it must be set to <see cref="Gl.COLOR_TABLE"/>, <see cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see 
		/// cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/>.
		/// <paramref name="pname"/> must be <see cref="Gl.COLOR_TABLE_SCALE"/> to set the scale factors. In this case, <paramref 
		/// name="params"/> points to an array of four values, which are the scale factors for red, green, blue, and alpha, in that 
		/// order.
		/// <paramref name="pname"/> must be <see cref="Gl.COLOR_TABLE_BIAS"/> to set the bias terms. In this case, <paramref 
		/// name="params"/> points to an array of four values, which are the bias terms for red, green, blue, and alpha, in that 
		/// order.
		/// The color tables themselves are specified by calling Gl.ColorTable.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable 
		///   value.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorTableParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.CopyColorTable"/> loads a color table with pixels from the current <see cref="Gl.READ_BUFFER"/> (rather 
		/// than from main memory, as is the case for Gl.ColorTable).
		/// The screen-aligned pixel rectangle with lower-left corner at (<paramref name="x"/>,\ <paramref name="y"/>) having width 
		/// <paramref name="width"/> and height 1 is loaded into the color table. If any pixels within this region are outside the 
		/// window that is associated with the GL context, the values obtained for those pixels are undefined.
		/// The pixels in the rectangle are processed just as if Gl.ReadPixels were called, with <paramref name="internalformat"/> 
		/// set to RGBA, but processing stops after the final conversion to RGBA.
		/// The four scale parameters and the four bias parameters that are defined for the table are then used to scale and bias 
		/// the R, G, B, and A components of each pixel. The scale and bias parameters are set by calling Gl.ColorTableParameter.
		/// Next, the R, G, B, and A values are clamped to the range 01. Each pixel is then converted to the internal format 
		/// specified by <paramref name="internalformat"/>. This conversion simply maps the component values of the pixel (R, G, B, 
		/// and A) to the values included in the internal format (red, green, blue, alpha, luminance, and intensity). The mapping is 
		/// as follows:
		/// Finally, the red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in the 
		/// color table. They form a one-dimensional table with indices in the range 0width-1.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.TABLE_TOO_LARGE"/> is generated if the requested color table is too large to be supported by the 
		///   implementation.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTable, Gl.GetColorTableParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.ReadPixels"/>
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
		/// <remarks>
		/// <see cref="Gl.GetColorTable"/> returns in <paramref name="table"/> the contents of the color table specified by 
		/// <paramref name="target"/>. No pixel transfer operations are performed, but pixel storage modes that are applicable to 
		/// Gl.ReadPixels are performed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// histogram table is requested, <paramref name="table"/> is treated as a byte offset into the buffer object's data store.
		/// Color components that are requested in the specified <paramref name="format"/>, but which are not included in the 
		/// internal format of the color lookup table, are returned as zero. The assignments of internal color components to the 
		/// components requested by <paramref name="format"/> are
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="table"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.GetColorTable"/> returns in <paramref name="table"/> the contents of the color table specified by 
		/// <paramref name="target"/>. No pixel transfer operations are performed, but pixel storage modes that are applicable to 
		/// Gl.ReadPixels are performed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// histogram table is requested, <paramref name="table"/> is treated as a byte offset into the buffer object's data store.
		/// Color components that are requested in the specified <paramref name="format"/>, but which are not included in the 
		/// internal format of the color lookup table, are returned as zero. The assignments of internal color components to the 
		/// components requested by <paramref name="format"/> are
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="table"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetColorTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
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
		/// <remarks>
		/// Returns parameters specific to color table <paramref name="target"/>.
		/// When <paramref name="pname"/> is set to <see cref="Gl.COLOR_TABLE_SCALE"/> or <see cref="Gl.COLOR_TABLE_BIAS"/>, <see 
		/// cref="Gl.GetColorTableParameter"/> returns the color table scale or bias parameters for the table specified by <paramref 
		/// name="target"/>. For these queries, <paramref name="target"/> must be set to <see cref="Gl.COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/> and <paramref 
		/// name="params"/> points to an array of four elements, which receive the scale or bias factors for red, green, blue, and 
		/// alpha, in that order.
		/// <see cref="Gl.GetColorTableParameter"/> can also be used to retrieve the format and size parameters for a color table. 
		/// For these queries, set <paramref name="target"/> to either the color table target or the proxy color table target. The 
		/// format and size parameters are set by Gl.ColorTable.
		/// The following table lists the format and size parameters that may be queried. For each symbolic constant listed below 
		/// for <paramref name="pname"/>, <paramref name="params"/> must point to an array of the given length and receive the 
		/// values indicated.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable 
		///   value.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetColorTableParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
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
		/// <remarks>
		/// Returns parameters specific to color table <paramref name="target"/>.
		/// When <paramref name="pname"/> is set to <see cref="Gl.COLOR_TABLE_SCALE"/> or <see cref="Gl.COLOR_TABLE_BIAS"/>, <see 
		/// cref="Gl.GetColorTableParameter"/> returns the color table scale or bias parameters for the table specified by <paramref 
		/// name="target"/>. For these queries, <paramref name="target"/> must be set to <see cref="Gl.COLOR_TABLE"/>, <see 
		/// cref="Gl.POST_CONVOLUTION_COLOR_TABLE"/>, or <see cref="Gl.POST_COLOR_MATRIX_COLOR_TABLE"/> and <paramref 
		/// name="params"/> points to an array of four elements, which receive the scale or bias factors for red, green, blue, and 
		/// alpha, in that order.
		/// <see cref="Gl.GetColorTableParameter"/> can also be used to retrieve the format and size parameters for a color table. 
		/// For these queries, set <paramref name="target"/> to either the color table target or the proxy color table target. The 
		/// format and size parameters are set by Gl.ColorTable.
		/// The following table lists the format and size parameters that may be queried. For each symbolic constant listed below 
		/// for <paramref name="pname"/>, <paramref name="params"/> must point to an array of the given length and receive the 
		/// values indicated.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable 
		///   value.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetColorTableParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorSubTable"/> is used to respecify a contiguous portion of a color table previously defined using 
		/// Gl.ColorTable. The pixels referenced by <paramref name="data"/> replace the portion of the existing table from indices 
		/// <paramref name="start"/> to start+count-1, inclusive. This region may not include any entries outside the range of the 
		/// color table as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specification has no effect.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a portion of a color table is respecified, <paramref name="data"/> is treated as a byte offset into the buffer object's 
		/// data store.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if start+count&gt;width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorSubTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTable, Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorSubTable"/> is used to respecify a contiguous portion of a color table previously defined using 
		/// Gl.ColorTable. The pixels referenced by <paramref name="data"/> replace the portion of the existing table from indices 
		/// <paramref name="start"/> to start+count-1, inclusive. This region may not include any entries outside the range of the 
		/// color table as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specification has no effect.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a portion of a color table is respecified, <paramref name="data"/> is treated as a byte offset into the buffer object's 
		/// data store.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if start+count&gt;width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorSubTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTable, Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.ColorSubTable"/> is used to respecify a contiguous portion of a color table previously defined using 
		/// Gl.ColorTable. The pixels referenced by <paramref name="data"/> replace the portion of the existing table from indices 
		/// <paramref name="start"/> to start+count-1, inclusive. This region may not include any entries outside the range of the 
		/// color table as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specification has no effect.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a portion of a color table is respecified, <paramref name="data"/> is treated as a byte offset into the buffer object's 
		/// data store.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if start+count&gt;width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ColorSubTable"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTable, Gl.GetColorTableParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.CopyColorSubTable"/> is used to respecify a contiguous portion of a color table previously defined using 
		/// Gl.ColorTable. The pixels copied from the framebuffer replace the portion of the existing table from indices <paramref 
		/// name="start"/> to start+x-1, inclusive. This region may not include any entries outside the range of the color table, as 
		/// was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no 
		/// effect.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="target"/> is not a previously defined color table.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if start+x&gt;width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyColorSubTable"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetColorTable, Gl.GetColorTableParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter1D"/> builds a one-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and <paramref 
		/// name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing stops after 
		/// the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 1D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 1D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_1D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a one-dimensional filter kernel image indexed with coordinate i such that i starts 
		/// at 0 and increases from left to right. Kernel location i is derived from the ith pixel, counting from 0.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_1D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="type"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="type"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter1D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter1D"/> builds a one-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and <paramref 
		/// name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing stops after 
		/// the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 1D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 1D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_1D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a one-dimensional filter kernel image indexed with coordinate i such that i starts 
		/// at 0 and increases from left to right. Kernel location i is derived from the ith pixel, counting from 0.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_1D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="type"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="type"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter1D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter1D"/> builds a one-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, and <paramref 
		/// name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, but processing stops after 
		/// the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 1D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 1D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_1D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a one-dimensional filter kernel image indexed with coordinate i such that i starts 
		/// at 0 and increases from left to right. Kernel location i is derived from the ith pixel, counting from 0.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_1D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="type"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="type"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter1D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter2D"/> builds a two-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="height"/>, <paramref name="format"/>, <paramref 
		/// name="type"/>, and <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, 
		/// but processing stops after the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 2D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 2D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_2D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a two-dimensional filter kernel image indexed with coordinates i and j such that i 
		/// starts at zero and increases from left to right, and j starts at zero and increases from bottom to top. Kernel location 
		/// i,j is derived from the Nth pixel, where N is i+j*<paramref name="width"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter2D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter2D"/> builds a two-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="height"/>, <paramref name="format"/>, <paramref 
		/// name="type"/>, and <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, 
		/// but processing stops after the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 2D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 2D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_2D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a two-dimensional filter kernel image indexed with coordinates i and j such that i 
		/// starts at zero and increases from left to right, and j starts at zero and increases from bottom to top. Kernel location 
		/// i,j is derived from the Nth pixel, where N is i+j*<paramref name="width"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter2D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ConvolutionFilter2D"/> builds a two-dimensional convolution filter kernel from an array of pixels.
		/// The pixel array specified by <paramref name="width"/>, <paramref name="height"/>, <paramref name="format"/>, <paramref 
		/// name="type"/>, and <paramref name="data"/> is extracted from memory and processed just as if Gl.DrawPixels were called, 
		/// but processing stops after the final expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// The R, G, B, and A components of each pixel are next scaled by the four 2D <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> 
		/// parameters and biased by the four 2D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters 
		/// are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_2D"/> target and the names <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors 
		/// of four values that are applied to red, green, blue, and alpha, in that order.) The R, G, B, and A values are not 
		/// clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form a two-dimensional filter kernel image indexed with coordinates i and j such that i 
		/// starts at zero and increases from left to right, and j starts at zero and increases from bottom to top. Kernel location 
		/// i,j is derived from the Nth pixel, where N is i+j*<paramref name="width"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionFilter2D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionParameter"/> sets the value of a convolution parameter.
		/// <paramref name="target"/> selects the convolution filter to be affected: <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/> for the 1D, 2D, or separable 2D filter, respectively.
		/// <paramref name="pname"/> selects the parameter to be changed. <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> affect the definition of the convolution filter kernel; see Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D for details. In these cases, <paramref name="params"/>v is an array of 
		/// four values to be applied to red, green, blue, and alpha values, respectively. The initial value for <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> is (1, 1, 1, 1), and the initial value for <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// is (0, 0, 0, 0).
		/// A <paramref name="pname"/> value of <see cref="Gl.CONVOLUTION_BORDER_MODE"/> controls the convolution border mode. The 
		/// accepted modes are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is <see cref="Gl.CONVOLUTION_BORDER_MODE"/> and 
		///   <paramref name="params"/> is not one of <see cref="Gl.REDUCE"/>, <see cref="Gl.CONSTANT_BORDER"/>, or <see 
		///   cref="Gl.REPLICATE_BORDER"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionParameter"/> sets the value of a convolution parameter.
		/// <paramref name="target"/> selects the convolution filter to be affected: <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/> for the 1D, 2D, or separable 2D filter, respectively.
		/// <paramref name="pname"/> selects the parameter to be changed. <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> affect the definition of the convolution filter kernel; see Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D for details. In these cases, <paramref name="params"/>v is an array of 
		/// four values to be applied to red, green, blue, and alpha values, respectively. The initial value for <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> is (1, 1, 1, 1), and the initial value for <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// is (0, 0, 0, 0).
		/// A <paramref name="pname"/> value of <see cref="Gl.CONVOLUTION_BORDER_MODE"/> controls the convolution border mode. The 
		/// accepted modes are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is <see cref="Gl.CONVOLUTION_BORDER_MODE"/> and 
		///   <paramref name="params"/> is not one of <see cref="Gl.REDUCE"/>, <see cref="Gl.CONSTANT_BORDER"/>, or <see 
		///   cref="Gl.REPLICATE_BORDER"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionParameter"/> sets the value of a convolution parameter.
		/// <paramref name="target"/> selects the convolution filter to be affected: <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/> for the 1D, 2D, or separable 2D filter, respectively.
		/// <paramref name="pname"/> selects the parameter to be changed. <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> affect the definition of the convolution filter kernel; see Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D for details. In these cases, <paramref name="params"/>v is an array of 
		/// four values to be applied to red, green, blue, and alpha values, respectively. The initial value for <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> is (1, 1, 1, 1), and the initial value for <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// is (0, 0, 0, 0).
		/// A <paramref name="pname"/> value of <see cref="Gl.CONVOLUTION_BORDER_MODE"/> controls the convolution border mode. The 
		/// accepted modes are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is <see cref="Gl.CONVOLUTION_BORDER_MODE"/> and 
		///   <paramref name="params"/> is not one of <see cref="Gl.REDUCE"/>, <see cref="Gl.CONSTANT_BORDER"/>, or <see 
		///   cref="Gl.REPLICATE_BORDER"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.ConvolutionParameter"/> sets the value of a convolution parameter.
		/// <paramref name="target"/> selects the convolution filter to be affected: <see cref="Gl.CONVOLUTION_1D"/>, <see 
		/// cref="Gl.CONVOLUTION_2D"/>, or <see cref="Gl.SEPARABLE_2D"/> for the 1D, 2D, or separable 2D filter, respectively.
		/// <paramref name="pname"/> selects the parameter to be changed. <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> affect the definition of the convolution filter kernel; see Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D for details. In these cases, <paramref name="params"/>v is an array of 
		/// four values to be applied to red, green, blue, and alpha values, respectively. The initial value for <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> is (1, 1, 1, 1), and the initial value for <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// is (0, 0, 0, 0).
		/// A <paramref name="pname"/> value of <see cref="Gl.CONVOLUTION_BORDER_MODE"/> controls the convolution border mode. The 
		/// accepted modes are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is <see cref="Gl.CONVOLUTION_BORDER_MODE"/> and 
		///   <paramref name="params"/> is not one of <see cref="Gl.REDUCE"/>, <see cref="Gl.CONSTANT_BORDER"/>, or <see 
		///   cref="Gl.REPLICATE_BORDER"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.CopyConvolutionFilter1D"/> defines a one-dimensional convolution filter kernel with pixels from the 
		/// current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.ConvolutionFilter1D).
		/// The screen-aligned pixel rectangle with lower-left corner at (<paramref name="x"/>,\ <paramref name="y"/>), width 
		/// <paramref name="width"/> and height 1 is used to define the convolution filter. If any pixels within this region are 
		/// outside the window that is associated with the GL context, the values obtained for those pixels are undefined.
		/// The pixels in the rectangle are processed exactly as if Gl.ReadPixels had been called with format set to RGBA, but the 
		/// process stops just before final conversion. The R, G, B, and A components of each pixel are next scaled by the four 1D 
		/// <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> parameters and biased by the four 1D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// parameters. (The scale and bias parameters are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_1D"/> 
		/// target and the names <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The 
		/// parameters themselves are vectors of four values that are applied to red, green, blue, and alpha, in that order.) The R, 
		/// G, B, and A values are not clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format.
		/// Pixel ordering is such that lower x screen coordinates correspond to lower i filter image coordinates.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_1D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyConvolutionFilter1D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.CopyConvolutionFilter2D"/> defines a two-dimensional convolution filter kernel with pixels from the 
		/// current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.ConvolutionFilter2D).
		/// The screen-aligned pixel rectangle with lower-left corner at (<paramref name="x"/>,\ <paramref name="y"/>), width 
		/// <paramref name="width"/> and height <paramref name="height"/> is used to define the convolution filter. If any pixels 
		/// within this region are outside the window that is associated with the GL context, the values obtained for those pixels 
		/// are undefined.
		/// The pixels in the rectangle are processed exactly as if Gl.ReadPixels had been called with format set to RGBA, but the 
		/// process stops just before final conversion. The R, G, B, and A components of each pixel are next scaled by the four 2D 
		/// <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> parameters and biased by the four 2D <see cref="Gl.CONVOLUTION_FILTER_BIAS"/> 
		/// parameters. (The scale and bias parameters are set by Gl.ConvolutionParameter using the <see cref="Gl.CONVOLUTION_2D"/> 
		/// target and the names <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The 
		/// parameters themselves are vectors of four values that are applied to red, green, blue, and alpha, in that order.) The R, 
		/// G, B, and A values are not clamped to [0,1] at any time during this process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format.
		/// Pixel ordering is such that lower x screen coordinates correspond to lower i filter image coordinates, and lower y 
		/// screen coordinates correspond to lower j filter image coordinates.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.CONVOLUTION_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.CONVOLUTION_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyConvolutionFilter2D"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetConvolutionFilter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.GetConvolutionFilter"/> returns the current 1D or 2D convolution filter kernel as an image. The one- or 
		/// two-dimensional image is placed in <paramref name="image"/> according to the specifications in <paramref name="format"/> 
		/// and <paramref name="type"/>. No pixel transfer operations are performed on this image, but the relevant pixel storage 
		/// modes are applied.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// convolution filter is requested, <paramref name="image"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// Color components that are present in <paramref name="format"/> but not included in the internal format of the filter are 
		/// returned as zero. The assignments of internal color components to the components of <paramref name="format"/> are as 
		/// follows.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="image"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetConvolutionFilter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		public static void GetConvolutionFilter(int target, int format, int type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, format, type, image);
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
		/// <remarks>
		/// <see cref="Gl.GetConvolutionFilter"/> returns the current 1D or 2D convolution filter kernel as an image. The one- or 
		/// two-dimensional image is placed in <paramref name="image"/> according to the specifications in <paramref name="format"/> 
		/// and <paramref name="type"/>. No pixel transfer operations are performed on this image, but the relevant pixel storage 
		/// modes are applied.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// convolution filter is requested, <paramref name="image"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// Color components that are present in <paramref name="format"/> but not included in the internal format of the filter are 
		/// returned as zero. The assignments of internal color components to the components of <paramref name="format"/> are as 
		/// follows.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="image"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetConvolutionFilter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		public static void GetConvolutionFilter(int target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, (int)format, (int)type, image);
			CallLog("glGetConvolutionFilter({0}, {1}, {2}, {3})", target, format, type, image);
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
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetConvolutionParameter"/> retrieves convolution parameters. <paramref name="target"/> determines which 
		/// convolution filter is queried. <paramref name="pname"/> determines which parameter is returned:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is <see cref="Gl.CONVOLUTION_1D"/> and <paramref 
		///   name="pname"/> is <see cref="Gl.CONVOLUTION_HEIGHT"/> or <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.GetConvolutionParameter"/> retrieves convolution parameters. <paramref name="target"/> determines which 
		/// convolution filter is queried. <paramref name="pname"/> determines which parameter is returned:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is <see cref="Gl.CONVOLUTION_1D"/> and <paramref 
		///   name="pname"/> is <see cref="Gl.CONVOLUTION_HEIGHT"/> or <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetConvolutionParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
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
		/// <remarks>
		/// <see cref="Gl.GetSeparableFilter"/> returns the two one-dimensional filter kernel images for the current separable 2D 
		/// convolution filter. The row image is placed in <paramref name="row"/> and the column image is placed in <paramref 
		/// name="column"/> according to the specifications in <paramref name="format"/> and <paramref name="type"/>. (In the 
		/// current implementation, <paramref name="span"/> is not affected in any way.) No pixel transfer operations are performed 
		/// on the images, but the relevant pixel storage modes are applied.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// separable convolution filter is requested, <paramref name="row"/>, <paramref name="column"/>, and <paramref 
		/// name="span"/> are treated as a byte offset into the buffer object's data store.
		/// Color components that are present in <paramref name="format"/> but not included in the internal format of the filters 
		/// are returned as zero. The assignments of internal color components to the components of <paramref name="format"/> are as 
		/// follows:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.SEPARABLE_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="row"/> or <paramref name="column"/> is not evenly divisible 
		///   into the number of bytes needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetSeparableFilter"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		public static void GetSeparableFilter(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, format, type, row, column, span);
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
		/// <remarks>
		/// <see cref="Gl.GetSeparableFilter"/> returns the two one-dimensional filter kernel images for the current separable 2D 
		/// convolution filter. The row image is placed in <paramref name="row"/> and the column image is placed in <paramref 
		/// name="column"/> according to the specifications in <paramref name="format"/> and <paramref name="type"/>. (In the 
		/// current implementation, <paramref name="span"/> is not affected in any way.) No pixel transfer operations are performed 
		/// on the images, but the relevant pixel storage modes are applied.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// separable convolution filter is requested, <paramref name="row"/>, <paramref name="column"/>, and <paramref 
		/// name="span"/> are treated as a byte offset into the buffer object's data store.
		/// Color components that are present in <paramref name="format"/> but not included in the internal format of the filters 
		/// are returned as zero. The assignments of internal color components to the components of <paramref name="format"/> are as 
		/// follows:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.SEPARABLE_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="row"/> or <paramref name="column"/> is not evenly divisible 
		///   into the number of bytes needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetSeparableFilter"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		public static void GetSeparableFilter(int target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, (int)format, (int)type, row, column, span);
			CallLog("glGetSeparableFilter({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
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
		/// <remarks>
		/// <see cref="Gl.SeparableFilter2D"/> builds a two-dimensional separable convolution filter kernel from two arrays of 
		/// pixels.
		/// The pixel arrays specified by (<paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="row"/>) and (<paramref name="height"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="column"/>) are processed just as if they had been passed to Gl.DrawPixels, but processing stops after the final 
		/// expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="row"/> and <paramref name="column"/> are treated as byte offsets into 
		/// the buffer object's data store.
		/// Next, the R, G, B, and A components of all pixels in both arrays are scaled by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> parameters and biased by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters are set by Gl.ConvolutionParameter using 
		/// the <see cref="Gl.SEPARABLE_2D"/> target and the names <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors of four values that are applied to red, 
		/// green, blue, and alpha, in that order.) The R, G, B, and A values are not clamped to [0,1] at any time during this 
		/// process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form two one-dimensional filter kernel images. The row image is indexed by coordinate i 
		/// starting at zero and increasing from left to right. Each location in the row image is derived from element i of 
		/// <paramref name="row"/>. The column image is indexed by coordinate j starting at zero and increasing from bottom to top. 
		/// Each location in the column image is derived from element j of <paramref name="column"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.SEPARABLE_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="row"/> or <paramref name="column"/> is not evenly divisible 
		///   into the number of bytes needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.SeparableFilter2D"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetSeparableFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.SeparableFilter2D"/> builds a two-dimensional separable convolution filter kernel from two arrays of 
		/// pixels.
		/// The pixel arrays specified by (<paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="row"/>) and (<paramref name="height"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="column"/>) are processed just as if they had been passed to Gl.DrawPixels, but processing stops after the final 
		/// expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="row"/> and <paramref name="column"/> are treated as byte offsets into 
		/// the buffer object's data store.
		/// Next, the R, G, B, and A components of all pixels in both arrays are scaled by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> parameters and biased by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters are set by Gl.ConvolutionParameter using 
		/// the <see cref="Gl.SEPARABLE_2D"/> target and the names <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors of four values that are applied to red, 
		/// green, blue, and alpha, in that order.) The R, G, B, and A values are not clamped to [0,1] at any time during this 
		/// process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form two one-dimensional filter kernel images. The row image is indexed by coordinate i 
		/// starting at zero and increasing from left to right. Each location in the row image is derived from element i of 
		/// <paramref name="row"/>. The column image is indexed by coordinate j starting at zero and increasing from bottom to top. 
		/// Each location in the column image is derived from element j of <paramref name="column"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.SEPARABLE_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="row"/> or <paramref name="column"/> is not evenly divisible 
		///   into the number of bytes needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.SeparableFilter2D"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetSeparableFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.SeparableFilter2D"/> builds a two-dimensional separable convolution filter kernel from two arrays of 
		/// pixels.
		/// The pixel arrays specified by (<paramref name="width"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="row"/>) and (<paramref name="height"/>, <paramref name="format"/>, <paramref name="type"/>, <paramref 
		/// name="column"/>) are processed just as if they had been passed to Gl.DrawPixels, but processing stops after the final 
		/// expansion to RGBA is completed.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a convolution filter is specified, <paramref name="row"/> and <paramref name="column"/> are treated as byte offsets into 
		/// the buffer object's data store.
		/// Next, the R, G, B, and A components of all pixels in both arrays are scaled by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_SCALE"/> parameters and biased by the four separable 2D <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/> parameters. (The scale and bias parameters are set by Gl.ConvolutionParameter using 
		/// the <see cref="Gl.SEPARABLE_2D"/> target and the names <see cref="Gl.CONVOLUTION_FILTER_SCALE"/> and <see 
		/// cref="Gl.CONVOLUTION_FILTER_BIAS"/>. The parameters themselves are vectors of four values that are applied to red, 
		/// green, blue, and alpha, in that order.) The R, G, B, and A values are not clamped to [0,1] at any time during this 
		/// process.
		/// Each pixel is then converted to the internal format specified by <paramref name="internalformat"/>. This conversion 
		/// simply maps the component values of the pixel (R, G, B, and A) to the values included in the internal format (red, 
		/// green, blue, alpha, luminance, and intensity). The mapping is as follows:
		/// The red, green, blue, alpha, luminance, and/or intensity components of the resulting pixels are stored in floating-point 
		/// rather than integer format. They form two one-dimensional filter kernel images. The row image is indexed by coordinate i 
		/// starting at zero and increasing from left to right. Each location in the row image is derived from element i of 
		/// <paramref name="row"/>. The column image is indexed by coordinate j starting at zero and increasing from bottom to top. 
		/// Each location in the column image is derived from element j of <paramref name="column"/>.
		/// Note that after a convolution is performed, the resulting color components are also scaled by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_SCALE"/> parameters and biased by their corresponding <see 
		/// cref="Gl.POST_CONVOLUTION_c_BIAS"/> parameters (where c takes on the values RED, GREEN, BLUE, and ALPHA). These 
		/// parameters are set by Gl.PixelTransfer.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.SEPARABLE_2D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_WIDTH"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="height"/> is less than zero or greater than the maximum 
		///   supported value. This value may be queried with Gl.GetConvolutionParameter using target <see cref="Gl.SEPARABLE_2D"/> 
		///   and name <see cref="Gl.MAX_CONVOLUTION_HEIGHT"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="height"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="row"/> or <paramref name="column"/> is not evenly divisible 
		///   into the number of bytes needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.SeparableFilter2D"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetConvolutionParameter, Gl.GetSeparableFilter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
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
		/// <remarks>
		/// <see cref="Gl.GetHistogram"/> returns the current histogram table as a one-dimensional image with the same width as the 
		/// histogram. No pixel transfer operations are performed on this image, but pixel storage modes that are applicable to 1D 
		/// images are honored.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// histogram table is requested, <paramref name="values"/> is treated as a byte offset into the buffer object's data store.
		/// Color components that are requested in the specified <paramref name="format"/>, but which are not included in the 
		/// internal format of the histogram, are returned as zero. The assignments of internal color components to the components 
		/// requested by <paramref name="format"/> are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.HISTOGRAM"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="values"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetHistogram"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetHistogramParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
		public static void GetHistogram(int target, bool reset, int format, int type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, format, type, values);
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
		/// <remarks>
		/// <see cref="Gl.GetHistogram"/> returns the current histogram table as a one-dimensional image with the same width as the 
		/// histogram. No pixel transfer operations are performed on this image, but pixel storage modes that are applicable to 1D 
		/// images are honored.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// histogram table is requested, <paramref name="values"/> is treated as a byte offset into the buffer object's data store.
		/// Color components that are requested in the specified <paramref name="format"/>, but which are not included in the 
		/// internal format of the histogram, are returned as zero. The assignments of internal color components to the components 
		/// requested by <paramref name="format"/> are:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.HISTOGRAM"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="values"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetHistogram"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetHistogramParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
		public static void GetHistogram(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, (int)format, (int)type, values);
			CallLog("glGetHistogram({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
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
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetHistogramParameter"/> is used to query parameter values for the current histogram or for a proxy. The 
		/// histogram state information may be queried by calling <see cref="Gl.GetHistogramParameter"/> with a <paramref 
		/// name="target"/> of <see cref="Gl.HISTOGRAM"/> (to obtain information for the current histogram table) or <see 
		/// cref="Gl.PROXY_HISTOGRAM"/> (to obtain information from the most recent proxy request) and one of the following values 
		/// for the <paramref name="pname"/> argument:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetHistogramParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.Histogram"/>
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
		/// <remarks>
		/// <see cref="Gl.GetHistogramParameter"/> is used to query parameter values for the current histogram or for a proxy. The 
		/// histogram state information may be queried by calling <see cref="Gl.GetHistogramParameter"/> with a <paramref 
		/// name="target"/> of <see cref="Gl.HISTOGRAM"/> (to obtain information for the current histogram table) or <see 
		/// cref="Gl.PROXY_HISTOGRAM"/> (to obtain information from the most recent proxy request) and one of the following values 
		/// for the <paramref name="pname"/> argument:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetHistogramParameter"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.Histogram"/>
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetMinmax"/> returns the accumulated minimum and maximum pixel values (computed on a per-component basis) 
		/// in a one-dimensional image of width 2. The first set of return values are the minima, and the second set of return 
		/// values are the maxima. The format of the return values is determined by <paramref name="format"/>, and their type is 
		/// determined by <paramref name="types"/>.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// minimum and maximum pixel values are requested, <paramref name="values"/> is treated as a byte offset into the buffer 
		/// object's data store.
		/// No pixel transfer operations are performed on the return values, but pixel storage modes that are applicable to 
		/// one-dimensional images are performed. Color components that are requested in the specified <paramref name="format"/>, 
		/// but that are not included in the internal format of the minmax table, are returned as zero. The assignment of internal 
		/// color components to the components requested by <paramref name="format"/> are as follows:
		/// If <paramref name="reset"/> is <see cref="Gl.TRUE"/>, the minmax table entries corresponding to the return values are 
		/// reset to their initial values. Minimum and maximum values that are not returned are not modified, even if <paramref 
		/// name="reset"/> is <see cref="Gl.TRUE"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.MINMAX"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="types"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="types"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="types"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="values"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMinmax"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMinmaxParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
		public static void GetMinmax(int target, bool reset, int format, int type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, format, type, values);
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetMinmax"/> returns the accumulated minimum and maximum pixel values (computed on a per-component basis) 
		/// in a one-dimensional image of width 2. The first set of return values are the minima, and the second set of return 
		/// values are the maxima. The format of the return values is determined by <paramref name="format"/>, and their type is 
		/// determined by <paramref name="types"/>.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// minimum and maximum pixel values are requested, <paramref name="values"/> is treated as a byte offset into the buffer 
		/// object's data store.
		/// No pixel transfer operations are performed on the return values, but pixel storage modes that are applicable to 
		/// one-dimensional images are performed. Color components that are requested in the specified <paramref name="format"/>, 
		/// but that are not included in the internal format of the minmax table, are returned as zero. The assignment of internal 
		/// color components to the components requested by <paramref name="format"/> are as follows:
		/// If <paramref name="reset"/> is <see cref="Gl.TRUE"/>, the minmax table entries corresponding to the return values are 
		/// reset to their initial values. Minimum and maximum values that are not returned are not modified, even if <paramref 
		/// name="reset"/> is <see cref="Gl.TRUE"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.MINMAX"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="types"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="types"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="types"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and the data would be packed to the buffer object such that the memory writes 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/> target and <paramref name="values"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMinmax"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMinmaxParameter
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
		public static void GetMinmax(int target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, (int)format, (int)type, values);
			CallLog("glGetMinmax({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
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
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetMinmaxParameter"/> retrieves parameters for the current minmax table by setting <paramref 
		/// name="pname"/> to one of the following values:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.MINMAX"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMinmaxParameter"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.GetMinmax"/>
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
		/// <remarks>
		/// <see cref="Gl.GetMinmaxParameter"/> retrieves parameters for the current minmax table by setting <paramref 
		/// name="pname"/> to one of the following values:
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.MINMAX"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMinmaxParameter"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.GetMinmax"/>
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
		/// <remarks>
		/// When <see cref="Gl.HISTOGRAM"/> is enabled, RGBA color components are converted to histogram table indices by clamping 
		/// to the range [0,1], multiplying by the width of the histogram table, and rounding to the nearest integer. The table 
		/// entries selected by the RGBA indices are then incremented. (If the internal format of the histogram table includes 
		/// luminance, then the index derived from the R color component determines the luminance table entry to be incremented.) If 
		/// a histogram table entry is incremented beyond its maximum value, then its value becomes undefined. (This is not an 
		/// error.)
		/// Histogramming is performed only for RGBA pixels (though these may be specified originally as color indices and converted 
		/// to RGBA by index table lookup). Histogramming is enabled with Gl.Enable and disabled with Gl.Disable.
		/// When <paramref name="target"/> is <see cref="Gl.HISTOGRAM"/>, <see cref="Gl.Histogram"/> redefines the current histogram 
		/// table to have <paramref name="width"/> entries of the format specified by <paramref name="internalformat"/>. The entries 
		/// are indexed 0 through width-1, and all entries are initialized to zero. The values in the previous histogram table, if 
		/// any, are lost. If <paramref name="sink"/> is <see cref="Gl.TRUE"/>, then pixels are discarded after histogramming; no 
		/// further processing of the pixels takes place, and no drawing, texture loading, or pixel readback will result.
		/// When <paramref name="target"/> is <see cref="Gl.PROXY_HISTOGRAM"/>, <see cref="Gl.Histogram"/> computes all state 
		/// information as if the histogram table were to be redefined, but does not actually define the new table. If the requested 
		/// histogram table is too large to be supported, then the state information will be set to zero. This provides a way to 
		/// determine if a histogram table with the given parameters can be supported.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than zero or is not a power of 2.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.TABLE_TOO_LARGE"/> is generated if <paramref name="target"/> is <see cref="Gl.HISTOGRAM"/> and the 
		///   histogram table specified is too large for the implementation.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Histogram"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetHistogramParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
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
		/// <remarks>
		/// When <see cref="Gl.MINMAX"/> is enabled, the RGBA components of incoming pixels are compared to the minimum and maximum 
		/// values for each component, which are stored in the two-element minmax table. (The first element stores the minima, and 
		/// the second element stores the maxima.) If a pixel component is greater than the corresponding component in the maximum 
		/// element, then the maximum element is updated with the pixel component value. If a pixel component is less than the 
		/// corresponding component in the minimum element, then the minimum element is updated with the pixel component value. (In 
		/// both cases, if the internal format of the minmax table includes luminance, then the R color component of incoming pixels 
		/// is used for comparison.) The contents of the minmax table may be retrieved at a later time by calling Gl.GetMinmax. The 
		/// minmax operation is enabled or disabled by calling Gl.Enable or Gl.Disable, respectively, with an argument of <see 
		/// cref="Gl.MINMAX"/>.
		/// <see cref="Gl.Minmax"/> redefines the current minmax table to have entries of the format specified by <paramref 
		/// name="internalformat"/>. The maximum element is initialized with the smallest possible component values, and the minimum 
		/// element is initialized with the largest possible component values. The values in the previous minmax table, if any, are 
		/// lost. If <paramref name="sink"/> is <see cref="Gl.TRUE"/>, then pixels are discarded after minmax; no further processing 
		/// of the pixels takes place, and no drawing, texture loading, or pixel readback will result.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Minmax"/> is executed between the execution of Gl.Begin 
		///   and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMinmaxParameter
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
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
		/// <remarks>
		/// <see cref="Gl.ResetHistogram"/> resets all the elements of the current histogram table to zero.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.HISTOGRAM"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ResetHistogram"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Histogram"/>
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
		/// <remarks>
		/// <see cref="Gl.ResetMinmax"/> resets the elements of the current minmax table to their initial values: the ``maximum'' 
		/// element receives the minimum possible component values, and the ``minimum'' element receives the maximum possible 
		/// component values.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.MINMAX"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ResetMinmax"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Minmax"/>
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
