
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
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D convolution is enabled. The initial value is 
		/// Gl.FALSE. See Gl.ConvolutionFilter1D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a 1D convolution operation on incoming RGBA color values. See Gl.ConvolutionFilter1D.
		/// </para>
		/// </summary>
		[AliasOf("GL_CONVOLUTION_1D_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_1D = 0x8010;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D convolution is enabled. The initial value is 
		/// Gl.FALSE. See Gl.ConvolutionFilter2D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a 2D convolution operation on incoming RGBA color values. See Gl.ConvolutionFilter2D.
		/// </para>
		/// </summary>
		[AliasOf("GL_CONVOLUTION_2D_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_2D = 0x8011;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D separable convolution is enabled. The initial value 
		/// is Gl.FALSE. See Gl.SeparableFilter2D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a two-dimensional convolution operation using a separable convolution filter on incoming 
		/// RGBA color values. See Gl.SeparableFilter2D.
		/// </para>
		/// </summary>
		[AliasOf("GL_SEPARABLE_2D_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int SEPARABLE_2D = 0x8012;

		/// <summary>
		/// Gl.GetConvolutionParameter: the convolution border mode. See Gl.ConvolutionParameter for a list of border modes.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_BORDER_MODE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_BORDER_MODE = 0x8013;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current filter scale factors. params must be a pointer to an array of four elements, 
		/// which will receive the red, green, blue, and alpha filter scale factors in that order.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FILTER_SCALE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FILTER_SCALE = 0x8014;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current filter bias factors. params must be a pointer to an array of four elements, 
		/// which will receive the red, green, blue, and alpha filter bias terms in that order.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FILTER_BIAS_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FILTER_BIAS = 0x8015;

		/// <summary>
		/// Gl.ConvolutionParameter: the image resulting from convolution is smaller than the source image. If the filter width is 
		/// Wf and height is Hf, and the source image width is Ws and height is Hs, then the convolved image width will be Ws-Wf+1 
		/// and height will be Hs-Hf+1. (If this reduction would generate an image with zero or negative width and/or height, the 
		/// output is simply null, with no error generated.) The coordinates of the image resulting from convolution are zero 
		/// through Ws-Wf in width and zero through Hs-Hf in height.
		/// </summary>
		[AliasOf("GL_REDUCE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int REDUCE = 0x8016;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current internal format. See Gl.ConvolutionFilter1D, Gl.ConvolutionFilter2D, and 
		/// Gl.SeparableFilter2D for lists of allowable formats.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_FORMAT_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FORMAT = 0x8017;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current filter image width.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_WIDTH_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_WIDTH = 0x8018;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current filter image height.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_HEIGHT_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_HEIGHT = 0x8019;

		/// <summary>
		/// Gl.GetConvolutionParameter: the maximum acceptable filter image width.
		/// </summary>
		[AliasOf("GL_MAX_CONVOLUTION_WIDTH_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int MAX_CONVOLUTION_WIDTH = 0x801A;

		/// <summary>
		/// Gl.GetConvolutionParameter: the maximum acceptable filter image height.
		/// </summary>
		[AliasOf("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int MAX_CONVOLUTION_HEIGHT = 0x801B;

		/// <summary>
		/// Gl.Get: params returns one value, the red scale factor applied to RGBA fragments after convolution. The initial value is 
		/// 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_RED_SCALE = 0x801C;

		/// <summary>
		/// Gl.Get: params returns one value, the green scale factor applied to RGBA fragments after convolution. The initial value 
		/// is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_GREEN_SCALE = 0x801D;

		/// <summary>
		/// Gl.Get: params returns one value, the blue scale factor applied to RGBA fragments after convolution. The initial value 
		/// is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_BLUE_SCALE = 0x801E;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha scale factor applied to RGBA fragments after convolution. The initial value 
		/// is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_ALPHA_SCALE = 0x801F;

		/// <summary>
		/// Gl.Get: params returns one value, the red bias factor applied to RGBA fragments after convolution. The initial value is 
		/// 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_RED_BIAS = 0x8020;

		/// <summary>
		/// Gl.Get: params returns one value, the green bias factor applied to RGBA fragments after convolution. The initial value 
		/// is 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_GREEN_BIAS = 0x8021;

		/// <summary>
		/// Gl.Get: params returns one value, the blue bias factor applied to RGBA fragments after convolution. The initial value is 
		/// 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_BLUE_BIAS = 0x8022;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha bias factor applied to RGBA fragments after convolution. The initial value 
		/// is 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_ALPHA_BIAS = 0x8023;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether histogram is enabled. The initial value is Gl.FALSE. 
		/// See Gl.Histogram.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, histogram incoming RGBA color values. See Gl.Histogram.
		/// </para>
		/// </summary>
		[AliasOf("GL_HISTOGRAM_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM = 0x8024;

		/// <summary>
		/// Value of GL_PROXY_HISTOGRAM symbol.
		/// </summary>
		[AliasOf("GL_PROXY_HISTOGRAM_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int PROXY_HISTOGRAM = 0x8025;

		/// <summary>
		/// Value of GL_HISTOGRAM_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_WIDTH_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_WIDTH = 0x8026;

		/// <summary>
		/// Value of GL_HISTOGRAM_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_FORMAT_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_FORMAT = 0x8027;

		/// <summary>
		/// Value of GL_HISTOGRAM_RED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_RED_SIZE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_RED_SIZE = 0x8028;

		/// <summary>
		/// Value of GL_HISTOGRAM_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_GREEN_SIZE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_GREEN_SIZE = 0x8029;

		/// <summary>
		/// Value of GL_HISTOGRAM_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_BLUE_SIZE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_BLUE_SIZE = 0x802A;

		/// <summary>
		/// Value of GL_HISTOGRAM_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_ALPHA_SIZE = 0x802B;

		/// <summary>
		/// Value of GL_HISTOGRAM_LUMINANCE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_LUMINANCE_SIZE = 0x802C;

		/// <summary>
		/// Value of GL_HISTOGRAM_SINK symbol.
		/// </summary>
		[AliasOf("GL_HISTOGRAM_SINK_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_SINK = 0x802D;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether pixel minmax values are computed. The initial value is 
		/// Gl.FALSE. See Gl.Minmax.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, compute the minimum and maximum values of incoming RGBA color values. See Gl.Minmax.
		/// </para>
		/// </summary>
		[AliasOf("GL_MINMAX_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX = 0x802E;

		/// <summary>
		/// Value of GL_MINMAX_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_MINMAX_FORMAT_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX_FORMAT = 0x802F;

		/// <summary>
		/// Value of GL_MINMAX_SINK symbol.
		/// </summary>
		[AliasOf("GL_MINMAX_SINK_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX_SINK = 0x8030;

		/// <summary>
		/// Gl.GetError: the specified table exceeds the implementation's maximum supported table size. The offending command is 
		/// ignored and has no other side effect than to set the error flag.
		/// </summary>
		[AliasOf("GL_TABLE_TOO_LARGE_EXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public const int TABLE_TOO_LARGE = 0x8031;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the color matrix on the top of the color matrix stack. Initially this matrix is 
		/// the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[AliasOf("GL_COLOR_MATRIX_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int COLOR_MATRIX = 0x80B1;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the projection matrix stack. The value must be at least 
		/// 2. See Gl.PushMatrix.
		/// </summary>
		[AliasOf("GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int COLOR_MATRIX_STACK_DEPTH = 0x80B2;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the color matrix stack. The value must be at least 2. 
		/// See Gl.PushMatrix.
		/// </summary>
		[AliasOf("GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;

		/// <summary>
		/// Gl.Get: params returns one value, the red scale factor applied to RGBA fragments after color matrix transformations. The 
		/// initial value is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_RED_SCALE = 0x80B4;

		/// <summary>
		/// Gl.Get: params returns one value, the green scale factor applied to RGBA fragments after color matrix transformations. 
		/// The initial value is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;

		/// <summary>
		/// Gl.Get: params returns one value, the blue scale factor applied to RGBA fragments after color matrix transformations. 
		/// The initial value is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha scale factor applied to RGBA fragments after color matrix transformations. 
		/// The initial value is 1. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;

		/// <summary>
		/// Gl.Get: params returns one value, the red bias factor applied to RGBA fragments after color matrix transformations. The 
		/// initial value is 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_RED_BIAS = 0x80B8;

		/// <summary>
		/// Gl.Get: params returns one value, the green bias factor applied to RGBA fragments after color matrix transformations. 
		/// The initial value is 0. See Gl.PixelTransfer
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;

		/// <summary>
		/// Gl.Get: params returns one value, the blue bias factor applied to RGBA fragments after color matrix transformations. The 
		/// initial value is 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha bias factor applied to RGBA fragments after color matrix transformations. 
		/// The initial value is 0. See Gl.PixelTransfer.
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the color table lookup is enabled. See Gl.ColorTable.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a color table lookup on the incoming RGBA color values. See Gl.ColorTable.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE = 0x80D0;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether post convolution lookup is enabled. The initial value 
		/// is Gl.FALSE. See Gl.ColorTable.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a color table lookup on RGBA color values after convolution. See Gl.ColorTable.
		/// </para>
		/// </summary>
		[AliasOf("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int POST_CONVOLUTION_COLOR_TABLE = 0x80D1;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether post color matrix transformation lookup is enabled. The 
		/// initial value is Gl.FALSE. See Gl.ColorTable.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, perform a color table lookup on RGBA color values after color matrix transformation. See 
		/// Gl.ColorTable.
		/// </para>
		/// </summary>
		[AliasOf("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;

		/// <summary>
		/// Value of GL_PROXY_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_COLOR_TABLE = 0x80D3;

		/// <summary>
		/// Value of GL_PROXY_POST_CONVOLUTION_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;

		/// <summary>
		/// Value of GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;

		/// <summary>
		/// Value of GL_COLOR_TABLE_SCALE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_SCALE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_SCALE = 0x80D6;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BIAS symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_BIAS_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_BIAS = 0x80D7;

		/// <summary>
		/// Value of GL_COLOR_TABLE_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_FORMAT_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_FORMAT = 0x80D8;

		/// <summary>
		/// Value of GL_COLOR_TABLE_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_WIDTH_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_WIDTH = 0x80D9;

		/// <summary>
		/// Value of GL_COLOR_TABLE_RED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_RED_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_RED_SIZE = 0x80DA;

		/// <summary>
		/// Value of GL_COLOR_TABLE_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_GREEN_SIZE = 0x80DB;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_BLUE_SIZE = 0x80DC;

		/// <summary>
		/// Value of GL_COLOR_TABLE_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_ALPHA_SIZE = 0x80DD;

		/// <summary>
		/// Value of GL_COLOR_TABLE_LUMINANCE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;

		/// <summary>
		/// Value of GL_COLOR_TABLE_INTENSITY_SIZE symbol.
		/// </summary>
		[AliasOf("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

		/// <summary>
		/// Gl.ConvolutionParameter: the image resulting from convolution is the same size as the source image, and processed as if 
		/// the source image were surrounded by pixels with their color specified by the Gl.CONVOLUTION_BORDER_COLOR.
		/// </summary>
		[AliasOf("GL_CONSTANT_BORDER_HP")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_HP_convolution_border_modes")]
		public const int CONSTANT_BORDER = 0x8151;

		/// <summary>
		/// Gl.ConvolutionParameter: the image resulting from convolution is the same size as the source image, and processed as if 
		/// the outermost pixel on the border of the source image were replicated.
		/// </summary>
		[AliasOf("GL_REPLICATE_BORDER_HP")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_HP_convolution_border_modes")]
		public const int REPLICATE_BORDER = 0x8153;

		/// <summary>
		/// Gl.GetConvolutionParameter: the current convolution border color. params must be a pointer to an array of four elements, 
		/// which will receive the red, green, blue, and alpha border colors.
		/// </summary>
		[AliasOf("GL_CONVOLUTION_BORDER_COLOR_HP")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_HP_convolution_border_modes")]
		public const int CONVOLUTION_BORDER_COLOR = 0x8154;

		/// <summary>
		/// define a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be one of Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, Gl.POST_COLOR_MATRIX_COLOR_TABLE, Gl.PROXY_COLOR_TABLE, 
		/// Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE, or Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the color table. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
		/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
		/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
		/// Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, 
		/// Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, and 
		/// Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The number of entries in the color lookup table specified by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.TABLE_TOO_LARGE is generated if the requested color table is too large to be supported by the implementation, and 
		/// <paramref name="target"/> is not a Gl.PROXY_* target.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorTable is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
		[AliasOf("glColorTableEXT")]
		[AliasOf("glColorTableSGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTable(Int32 target, Int32 internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglColorTable != null, "pglColorTable not implemented");
			Delegates.pglColorTable(target, internalformat, width, (Int32)format, (Int32)type, table);
			LogFunction("glColorTable({0}, {1}, {2}, {3}, {4}, 0x{5})", LogEnumName(target), LogEnumName(internalformat), width, format, type, table.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be one of Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, Gl.POST_COLOR_MATRIX_COLOR_TABLE, Gl.PROXY_COLOR_TABLE, 
		/// Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE, or Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the color table. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
		/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
		/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
		/// Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, 
		/// Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, and 
		/// Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The number of entries in the color lookup table specified by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.TABLE_TOO_LARGE is generated if the requested color table is too large to be supported by the implementation, and 
		/// <paramref name="target"/> is not a Gl.PROXY_* target.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorTable is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
		[AliasOf("glColorTableEXT")]
		[AliasOf("glColorTableSGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTable(Int32 target, Int32 internalformat, Int32 width, PixelFormat format, PixelType type, Object table)
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
		/// The target color table. Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a texture color lookup table parameter. Must be one of Gl.COLOR_TABLE_SCALE or Gl.COLOR_TABLE_BIAS.
		/// </param>
		/// <param name="params">
		/// A pointer to an array where the values of the parameters are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorTableParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glColorTableParameterfvSGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableParameter(Int32 target, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglColorTableParameterfv != null, "pglColorTableParameterfv not implemented");
					Delegates.pglColorTableParameterfv(target, pname, p_params);
					LogFunction("glColorTableParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a texture color lookup table parameter. Must be one of Gl.COLOR_TABLE_SCALE or Gl.COLOR_TABLE_BIAS.
		/// </param>
		/// <param name="params">
		/// A pointer to an array where the values of the parameters are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorTableParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glColorTableParameterivSGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableParameter(Int32 target, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglColorTableParameteriv != null, "pglColorTableParameteriv not implemented");
					Delegates.pglColorTableParameteriv(target, pname, p_params);
					LogFunction("glColorTableParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels into a color table
		/// </summary>
		/// <param name="target">
		/// The color table target. Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="internalformat">
		/// The internal storage format of the texture image. Must be one of the following symbolic constants: Gl.ALPHA, Gl.ALPHA4, 
		/// Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, 
		/// Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, 
		/// Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, 
		/// Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, 
		/// Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, or Gl.RGBA16.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.TABLE_TOO_LARGE is generated if the requested color table is too large to be supported by the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyColorTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[AliasOf("glCopyColorTableSGI")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		public static void CopyColorTable(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyColorTable != null, "pglCopyColorTable not implemented");
			Delegates.pglCopyColorTable(target, internalformat, x, y, width);
			LogFunction("glCopyColorTable({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(internalformat), x, y, width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve contents of a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="table"/>. The possible values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="table"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="table">
		/// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="table"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetColorTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		[AliasOf("glGetColorTableEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTable(Int32 target, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetColorTable != null, "pglGetColorTable not implemented");
			Delegates.pglGetColorTable(target, (Int32)format, (Int32)type, table);
			LogFunction("glGetColorTable({0}, {1}, {2}, 0x{3})", LogEnumName(target), format, type, table.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve contents of a color lookup table
		/// </summary>
		/// <param name="target">
		/// Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="table"/>. The possible values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="table"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="table">
		/// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="table"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetColorTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		[AliasOf("glGetColorTableEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTable(Int32 target, PixelFormat format, PixelType type, Object table)
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
		/// The target color table. Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, Gl.POST_COLOR_MATRIX_COLOR_TABLE, 
		/// Gl.PROXY_COLOR_TABLE, Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE, or Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a color lookup table parameter. Must be one of Gl.COLOR_TABLE_BIAS, Gl.COLOR_TABLE_SCALE, 
		/// Gl.COLOR_TABLE_FORMAT, Gl.COLOR_TABLE_WIDTH, Gl.COLOR_TABLE_RED_SIZE, Gl.COLOR_TABLE_GREEN_SIZE, 
		/// Gl.COLOR_TABLE_BLUE_SIZE, Gl.COLOR_TABLE_ALPHA_SIZE, Gl.COLOR_TABLE_LUMINANCE_SIZE, or Gl.COLOR_TABLE_INTENSITY_SIZE.
		/// </param>
		/// <param name="params">
		/// A pointer to an array where the values of the parameter will be stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetColorTableParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		[AliasOf("glGetColorTableParameterfvEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableParameter(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterfv != null, "pglGetColorTableParameterfv not implemented");
					Delegates.pglGetColorTableParameterfv(target, pname, p_params);
					LogFunction("glGetColorTableParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get color lookup table parameters
		/// </summary>
		/// <param name="target">
		/// The target color table. Must be Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, Gl.POST_COLOR_MATRIX_COLOR_TABLE, 
		/// Gl.PROXY_COLOR_TABLE, Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE, or Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="pname">
		/// The symbolic name of a color lookup table parameter. Must be one of Gl.COLOR_TABLE_BIAS, Gl.COLOR_TABLE_SCALE, 
		/// Gl.COLOR_TABLE_FORMAT, Gl.COLOR_TABLE_WIDTH, Gl.COLOR_TABLE_RED_SIZE, Gl.COLOR_TABLE_GREEN_SIZE, 
		/// Gl.COLOR_TABLE_BLUE_SIZE, Gl.COLOR_TABLE_ALPHA_SIZE, Gl.COLOR_TABLE_LUMINANCE_SIZE, or Gl.COLOR_TABLE_INTENSITY_SIZE.
		/// </param>
		/// <param name="params">
		/// A pointer to an array where the values of the parameter will be stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an acceptable value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetColorTableParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		[AliasOf("glGetColorTableParameterivEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameteriv != null, "pglGetColorTableParameteriv not implemented");
					Delegates.pglGetColorTableParameteriv(target, pname, p_params);
					LogFunction("glGetColorTableParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// respecify a portion of a color table
		/// </summary>
		/// <param name="target">
		/// Must be one of Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="start">
		/// The starting index of the portion of the color table to be replaced.
		/// </param>
		/// <param name="count">
		/// The number of table entries to replace.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="data">
		/// Pointer to a one-dimensional array of pixel data that is processed to replace the specified region of the color table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if start+count&gt;width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorSubTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
		[AliasOf("glColorSubTableEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTable(Int32 target, Int32 start, Int32 count, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglColorSubTable != null, "pglColorSubTable not implemented");
			Delegates.pglColorSubTable(target, start, count, (Int32)format, (Int32)type, data);
			LogFunction("glColorSubTable({0}, {1}, {2}, {3}, {4}, 0x{5})", LogEnumName(target), start, count, format, type, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// respecify a portion of a color table
		/// </summary>
		/// <param name="target">
		/// Must be one of Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
		/// </param>
		/// <param name="start">
		/// The starting index of the portion of the color table to be replaced.
		/// </param>
		/// <param name="count">
		/// The number of table entries to replace.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.LUMINANCE, Gl.LUMINANCE_ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, and Gl.BGRA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. The allowable values are Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="data">
		/// Pointer to a one-dimensional array of pixel data that is processed to replace the specified region of the color table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if start+count&gt;width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorSubTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
		[AliasOf("glColorSubTableEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTable(Int32 target, Int32 start, Int32 count, PixelFormat format, PixelType type, Object data)
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
		/// Must be one of Gl.COLOR_TABLE, Gl.POST_CONVOLUTION_COLOR_TABLE, or Gl.POST_COLOR_MATRIX_COLOR_TABLE.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is not a previously defined color table.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if start+x&gt;width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyColorSubTable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTableParameter"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.GetColorTable"/>
		[AliasOf("glCopyColorSubTableEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void CopyColorSubTable(Int32 target, Int32 start, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyColorSubTable != null, "pglCopyColorSubTable not implemented");
			Delegates.pglCopyColorSubTable(target, start, x, y, width);
			LogFunction("glCopyColorSubTable({0}, {1}, {2}, {3}, {4})", LogEnumName(target), start, x, y, width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.CONVOLUTION_1D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.ALPHA, Gl.LUMINANCE, 
		/// Gl.LUMINANCE_ALPHA, Gl.INTENSITY, Gl.RGB, and Gl.RGBA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_1D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="type"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="type"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionFilter1D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glConvolutionFilter1DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglConvolutionFilter1D != null, "pglConvolutionFilter1D not implemented");
			Delegates.pglConvolutionFilter1D(target, internalformat, width, (Int32)format, (Int32)type, image);
			LogFunction("glConvolutionFilter1D({0}, {1}, {2}, {3}, {4}, 0x{5})", LogEnumName(target), LogEnumName(internalformat), width, format, type, image.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.CONVOLUTION_1D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.ALPHA, Gl.LUMINANCE, 
		/// Gl.LUMINANCE_ALPHA, Gl.INTENSITY, Gl.RGB, and Gl.RGBA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_1D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="type"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="type"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionFilter1D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glConvolutionFilter1DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 width, PixelFormat format, PixelType type, Object image)
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
		/// Must be Gl.CONVOLUTION_2D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="height">
		/// The height of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="height"/> is less than zero or greater than the maximum supported 
		/// value. This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionFilter2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glConvolutionFilter2DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglConvolutionFilter2D != null, "pglConvolutionFilter2D not implemented");
			Delegates.pglConvolutionFilter2D(target, internalformat, width, height, (Int32)format, (Int32)type, image);
			LogFunction("glConvolutionFilter2D({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", LogEnumName(target), LogEnumName(internalformat), width, height, format, type, image.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.CONVOLUTION_2D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="width">
		/// The width of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="height">
		/// The height of the pixel array referenced by <paramref name="data"/>.
		/// </param>
		/// <param name="format">
		/// The format of the pixel data in <paramref name="data"/>. The allowable values are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="height"/> is less than zero or greater than the maximum supported 
		/// value. This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionFilter2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glConvolutionFilter2DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object image)
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
		/// The target for the convolution parameter. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be Gl.CONVOLUTION_BORDER_MODE.
		/// </param>
		/// <param name="params">
		/// The parameter value. Must be one of Gl.REDUCE, Gl.CONSTANT_BORDER, Gl.REPLICATE_BORDER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.CONVOLUTION_BORDER_MODE and <paramref name="params"/> is 
		/// not one of Gl.REDUCE, Gl.CONSTANT_BORDER, or Gl.REPLICATE_BORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
		[AliasOf("glConvolutionParameterfEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameter(Int32 target, Int32 pname, float @params)
		{
			Debug.Assert(Delegates.pglConvolutionParameterf != null, "pglConvolutionParameterf not implemented");
			Delegates.pglConvolutionParameterf(target, pname, @params);
			LogFunction("glConvolutionParameterf({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), @params);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be Gl.CONVOLUTION_BORDER_MODE.
		/// </param>
		/// <param name="params">
		/// The parameter value. Must be one of Gl.REDUCE, Gl.CONSTANT_BORDER, Gl.REPLICATE_BORDER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.CONVOLUTION_BORDER_MODE and <paramref name="params"/> is 
		/// not one of Gl.REDUCE, Gl.CONSTANT_BORDER, or Gl.REPLICATE_BORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
		[AliasOf("glConvolutionParameterfvEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameter(Int32 target, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameterfv != null, "pglConvolutionParameterfv not implemented");
					Delegates.pglConvolutionParameterfv(target, pname, p_params);
					LogFunction("glConvolutionParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be Gl.CONVOLUTION_BORDER_MODE.
		/// </param>
		/// <param name="params">
		/// The parameter value. Must be one of Gl.REDUCE, Gl.CONSTANT_BORDER, Gl.REPLICATE_BORDER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.CONVOLUTION_BORDER_MODE and <paramref name="params"/> is 
		/// not one of Gl.REDUCE, Gl.CONSTANT_BORDER, or Gl.REPLICATE_BORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
		[AliasOf("glConvolutionParameteriEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameter(Int32 target, Int32 pname, Int32 @params)
		{
			Debug.Assert(Delegates.pglConvolutionParameteri != null, "pglConvolutionParameteri not implemented");
			Delegates.pglConvolutionParameteri(target, pname, @params);
			LogFunction("glConvolutionParameteri({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), @params);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set convolution parameters
		/// </summary>
		/// <param name="target">
		/// The target for the convolution parameter. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be set. Must be Gl.CONVOLUTION_BORDER_MODE.
		/// </param>
		/// <param name="params">
		/// The parameter value. Must be one of Gl.REDUCE, Gl.CONSTANT_BORDER, Gl.REPLICATE_BORDER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.CONVOLUTION_BORDER_MODE and <paramref name="params"/> is 
		/// not one of Gl.REDUCE, Gl.CONSTANT_BORDER, or Gl.REPLICATE_BORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.GetConvolutionParameter"/>
		[AliasOf("glConvolutionParameterivEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameter(Int32 target, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameteriv != null, "pglConvolutionParameteriv not implemented");
					Delegates.pglConvolutionParameteriv(target, pname, p_params);
					LogFunction("glConvolutionParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels into a one-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.CONVOLUTION_1D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_1D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyConvolutionFilter1D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glCopyConvolutionFilter1DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void CopyConvolutionFilter1D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyConvolutionFilter1D != null, "pglCopyConvolutionFilter1D not implemented");
			Delegates.pglCopyConvolutionFilter1D(target, internalformat, x, y, width);
			LogFunction("glCopyConvolutionFilter1D({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(internalformat), x, y, width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels into a two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.CONVOLUTION_2D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.CONVOLUTION_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="height"/> is less than zero or greater than the maximum supported 
		/// value. This value may be queried with Gl\.GetConvolutionParameter using target Gl.CONVOLUTION_2D and name 
		/// Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyConvolutionFilter2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glCopyConvolutionFilter2DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void CopyConvolutionFilter2D(Int32 target, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyConvolutionFilter2D != null, "pglCopyConvolutionFilter2D not implemented");
			Delegates.pglCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
			LogFunction("glCopyConvolutionFilter2D({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(internalformat), x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get current 1D or 2D convolution filter kernel
		/// </summary>
		/// <param name="target">
		/// The filter to be retrieved. Must be one of Gl.CONVOLUTION_1D or Gl.CONVOLUTION_2D.
		/// </param>
		/// <param name="format">
		/// Format of the output image. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, 
		/// Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output image. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// Pointer to storage for the output image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="image"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetConvolutionFilter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetConvolutionFilter(Int32 target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilter != null, "pglGetConvolutionFilter not implemented");
			Delegates.pglGetConvolutionFilter(target, (Int32)format, (Int32)type, image);
			LogFunction("glGetConvolutionFilter({0}, {1}, {2}, 0x{3})", LogEnumName(target), format, type, image.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get current 1D or 2D convolution filter kernel
		/// </summary>
		/// <param name="target">
		/// The filter to be retrieved. Must be one of Gl.CONVOLUTION_1D or Gl.CONVOLUTION_2D.
		/// </param>
		/// <param name="format">
		/// Format of the output image. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, 
		/// Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output image. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="image">
		/// Pointer to storage for the output image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="image"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetConvolutionFilter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetConvolutionFilter(Int32 target, PixelFormat format, PixelType type, Object image)
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
		/// The filter whose parameters are to be retrieved. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or 
		/// Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of Gl.CONVOLUTION_BORDER_MODE, Gl.CONVOLUTION_BORDER_COLOR, 
		/// Gl.CONVOLUTION_FILTER_SCALE, Gl.CONVOLUTION_FILTER_BIAS, Gl.CONVOLUTION_FORMAT, Gl.CONVOLUTION_WIDTH, 
		/// Gl.CONVOLUTION_HEIGHT, Gl.MAX_CONVOLUTION_WIDTH, or Gl.MAX_CONVOLUTION_HEIGHT.
		/// </param>
		/// <param name="params">
		/// Pointer to storage for the parameters to be retrieved.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is Gl.CONVOLUTION_1D and <paramref name="pname"/> is 
		/// Gl.CONVOLUTION_HEIGHT or Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetConvolutionParameter(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfv != null, "pglGetConvolutionParameterfv not implemented");
					Delegates.pglGetConvolutionParameterfv(target, pname, p_params);
					LogFunction("glGetConvolutionParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get convolution parameters
		/// </summary>
		/// <param name="target">
		/// The filter whose parameters are to be retrieved. Must be one of Gl.CONVOLUTION_1D, Gl.CONVOLUTION_2D, or 
		/// Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of Gl.CONVOLUTION_BORDER_MODE, Gl.CONVOLUTION_BORDER_COLOR, 
		/// Gl.CONVOLUTION_FILTER_SCALE, Gl.CONVOLUTION_FILTER_BIAS, Gl.CONVOLUTION_FORMAT, Gl.CONVOLUTION_WIDTH, 
		/// Gl.CONVOLUTION_HEIGHT, Gl.MAX_CONVOLUTION_WIDTH, or Gl.MAX_CONVOLUTION_HEIGHT.
		/// </param>
		/// <param name="params">
		/// Pointer to storage for the parameters to be retrieved.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is Gl.CONVOLUTION_1D and <paramref name="pname"/> is 
		/// Gl.CONVOLUTION_HEIGHT or Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetConvolutionParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.GetSeparableFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetConvolutionParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameteriv != null, "pglGetConvolutionParameteriv not implemented");
					Delegates.pglGetConvolutionParameteriv(target, pname, p_params);
					LogFunction("glGetConvolutionParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get separable convolution filter kernel images
		/// </summary>
		/// <param name="target">
		/// The separable filter to be retrieved. Must be Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="format">
		/// Format of the output images. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGRGl.RGBA, Gl.BGRA, 
		/// Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output images. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.SEPARABLE_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="row"/> or <paramref name="column"/> is not evenly divisible into the number of bytes needed to store in 
		/// memory a datum indicated by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetSeparableFilter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetSeparableFilter(Int32 target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilter != null, "pglGetSeparableFilter not implemented");
			Delegates.pglGetSeparableFilter(target, (Int32)format, (Int32)type, row, column, span);
			LogFunction("glGetSeparableFilter({0}, {1}, {2}, 0x{3}, 0x{4}, 0x{5})", LogEnumName(target), format, type, row.ToString("X8"), column.ToString("X8"), span.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get separable convolution filter kernel images
		/// </summary>
		/// <param name="target">
		/// The separable filter to be retrieved. Must be Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="format">
		/// Format of the output images. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGRGl.RGBA, Gl.BGRA, 
		/// Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Data type of components in the output images. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
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
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.SEPARABLE_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="row"/> or <paramref name="column"/> is not evenly divisible into the number of bytes needed to store in 
		/// memory a datum indicated by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetSeparableFilter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetConvolutionFilter"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetSeparableFilter(Int32 target, PixelFormat format, PixelType type, Object row, Object column, Object span)
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
		/// Must be Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
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
		/// The format of the pixel data in <paramref name="row"/> and <paramref name="column"/>. The allowable values are Gl.RED, 
		/// Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.INTENSITY, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="row"/> and <paramref name="column"/>. Symbolic constants Gl.UNSIGNED_BYTE, 
		/// Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the row filter kernel.
		/// </param>
		/// <param name="column">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the column filter kernel.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.SEPARABLE_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.SEPARABLE_2D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="height"/> is less than zero or greater than the maximum supported 
		/// value. This value may be queried with Gl\.GetConvolutionParameter using target Gl.SEPARABLE_2D and name 
		/// Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="row"/> or <paramref name="column"/> is not evenly divisible into the number of bytes needed to store in 
		/// memory a datum indicated by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SeparableFilter2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glSeparableFilter2DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void SeparableFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
		{
			Debug.Assert(Delegates.pglSeparableFilter2D != null, "pglSeparableFilter2D not implemented");
			Delegates.pglSeparableFilter2D(target, internalformat, width, height, (Int32)format, (Int32)type, row, column);
			LogFunction("glSeparableFilter2D({0}, {1}, {2}, {3}, {4}, {5}, 0x{6}, 0x{7})", LogEnumName(target), LogEnumName(internalformat), width, height, format, type, row.ToString("X8"), column.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a separable two-dimensional convolution filter
		/// </summary>
		/// <param name="target">
		/// Must be Gl.SEPARABLE_2D.
		/// </param>
		/// <param name="internalformat">
		/// The internal format of the convolution filter kernel. The allowable values are Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, 
		/// Gl.ALPHA12, Gl.ALPHA16, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, 
		/// Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, 
		/// Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8, Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, 
		/// Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, 
		/// Gl.RGBA12, or Gl.RGBA16.
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
		/// The format of the pixel data in <paramref name="row"/> and <paramref name="column"/>. The allowable values are Gl.RED, 
		/// Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.INTENSITY, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of the pixel data in <paramref name="row"/> and <paramref name="column"/>. Symbolic constants Gl.UNSIGNED_BYTE, 
		/// Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="row">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the row filter kernel.
		/// </param>
		/// <param name="column">
		/// Pointer to a one-dimensional array of pixel data that is processed to build the column filter kernel.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.SEPARABLE_2D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or greater than the maximum supported value. 
		/// This value may be queried with Gl\.GetConvolutionParameter using target Gl.SEPARABLE_2D and name 
		/// Gl.MAX_CONVOLUTION_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="height"/> is less than zero or greater than the maximum supported 
		/// value. This value may be queried with Gl\.GetConvolutionParameter using target Gl.SEPARABLE_2D and name 
		/// Gl.MAX_CONVOLUTION_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="height"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="row"/> or <paramref name="column"/> is not evenly divisible into the number of bytes needed to store in 
		/// memory a datum indicated by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SeparableFilter2D is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.ConvolutionParameter"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[AliasOf("glSeparableFilter2DEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		public static void SeparableFilter2D(Int32 target, Int32 internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object row, Object column)
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
		/// Must be Gl.HISTOGRAM.
		/// </param>
		/// <param name="reset">
		/// If Gl.TRUE, each component counter that is actually returned is reset to zero. (Other counters are unaffected.) If 
		/// Gl.FALSE, none of the counters in the histogram table is modified.
		/// </param>
		/// <param name="format">
		/// The format of values to be returned in <paramref name="values"/>. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of values to be returned in <paramref name="values"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned histogram table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.HISTOGRAM.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="values"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetHistogram is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetHistogram(Int32 target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogram != null, "pglGetHistogram not implemented");
			Delegates.pglGetHistogram(target, reset, (Int32)format, (Int32)type, values);
			LogFunction("glGetHistogram({0}, {1}, {2}, {3}, 0x{4})", LogEnumName(target), reset, format, type, values.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get histogram table
		/// </summary>
		/// <param name="target">
		/// Must be Gl.HISTOGRAM.
		/// </param>
		/// <param name="reset">
		/// If Gl.TRUE, each component counter that is actually returned is reset to zero. (Other counters are unaffected.) If 
		/// Gl.FALSE, none of the counters in the histogram table is modified.
		/// </param>
		/// <param name="format">
		/// The format of values to be returned in <paramref name="values"/>. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// The type of values to be returned in <paramref name="values"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned histogram table.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.HISTOGRAM.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="values"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetHistogram is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetHistogram(Int32 target, bool reset, PixelFormat format, PixelType type, Object values)
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
		/// Must be one of Gl.HISTOGRAM or Gl.PROXY_HISTOGRAM.
		/// </param>
		/// <param name="pname">
		/// The name of the parameter to be retrieved. Must be one of Gl.HISTOGRAM_WIDTH, Gl.HISTOGRAM_FORMAT, 
		/// Gl.HISTOGRAM_RED_SIZE, Gl.HISTOGRAM_GREEN_SIZE, Gl.HISTOGRAM_BLUE_SIZE, Gl.HISTOGRAM_ALPHA_SIZE, 
		/// Gl.HISTOGRAM_LUMINANCE_SIZE, or Gl.HISTOGRAM_SINK.
		/// </param>
		/// <param name="params">
		/// Pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetHistogramParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.Histogram"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetHistogramParameter(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterfv != null, "pglGetHistogramParameterfv not implemented");
					Delegates.pglGetHistogramParameterfv(target, pname, p_params);
					LogFunction("glGetHistogramParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get histogram parameters
		/// </summary>
		/// <param name="target">
		/// Must be one of Gl.HISTOGRAM or Gl.PROXY_HISTOGRAM.
		/// </param>
		/// <param name="pname">
		/// The name of the parameter to be retrieved. Must be one of Gl.HISTOGRAM_WIDTH, Gl.HISTOGRAM_FORMAT, 
		/// Gl.HISTOGRAM_RED_SIZE, Gl.HISTOGRAM_GREEN_SIZE, Gl.HISTOGRAM_BLUE_SIZE, Gl.HISTOGRAM_ALPHA_SIZE, 
		/// Gl.HISTOGRAM_LUMINANCE_SIZE, or Gl.HISTOGRAM_SINK.
		/// </param>
		/// <param name="params">
		/// Pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetHistogramParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.Histogram"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetHistogramParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameteriv != null, "pglGetHistogramParameteriv not implemented");
					Delegates.pglGetHistogramParameteriv(target, pname, p_params);
					LogFunction("glGetHistogramParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get minimum and maximum pixel values
		/// </summary>
		/// <param name="target">
		/// Must be Gl.MINMAX.
		/// </param>
		/// <param name="reset">
		/// If Gl.TRUE, all entries in the minmax table that are actually returned are reset to their initial values. (Other entries 
		/// are unaltered.) If Gl.FALSE, the minmax table is unaltered.
		/// </param>
		/// <param name="format">
		/// The format of the data to be returned in <paramref name="values"/>. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.MINMAX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="types"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="types"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="types"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="values"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMinmax is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetMinmax(Int32 target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmax != null, "pglGetMinmax not implemented");
			Delegates.pglGetMinmax(target, reset, (Int32)format, (Int32)type, values);
			LogFunction("glGetMinmax({0}, {1}, {2}, {3}, 0x{4})", LogEnumName(target), reset, format, type, values.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get minimum and maximum pixel values
		/// </summary>
		/// <param name="target">
		/// Must be Gl.MINMAX.
		/// </param>
		/// <param name="reset">
		/// If Gl.TRUE, all entries in the minmax table that are actually returned are reset to their initial values. (Other entries 
		/// are unaltered.) If Gl.FALSE, the minmax table is unaltered.
		/// </param>
		/// <param name="format">
		/// The format of the data to be returned in <paramref name="values"/>. Must be one of Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, 
		/// Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A pointer to storage for the returned values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.MINMAX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="types"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="types"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="types"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="values"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMinmax is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetMinmax(Int32 target, bool reset, PixelFormat format, PixelType type, Object values)
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
		/// Must be Gl.MINMAX.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of Gl.MINMAX_FORMAT or Gl.MINMAX_SINK.
		/// </param>
		/// <param name="params">
		/// A pointer to storage for the retrieved parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.MINMAX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMinmaxParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.GetMinmax"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetMinmaxParameter(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterfv != null, "pglGetMinmaxParameterfv not implemented");
					Delegates.pglGetMinmaxParameterfv(target, pname, p_params);
					LogFunction("glGetMinmaxParameterfv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// get minmax parameters
		/// </summary>
		/// <param name="target">
		/// Must be Gl.MINMAX.
		/// </param>
		/// <param name="pname">
		/// The parameter to be retrieved. Must be one of Gl.MINMAX_FORMAT or Gl.MINMAX_SINK.
		/// </param>
		/// <param name="params">
		/// A pointer to storage for the retrieved parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.MINMAX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMinmaxParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.GetMinmax"/>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		public static void GetMinmaxParameter(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameteriv != null, "pglGetMinmaxParameteriv not implemented");
					Delegates.pglGetMinmaxParameteriv(target, pname, p_params);
					LogFunction("glGetMinmaxParameteriv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define histogram table
		/// </summary>
		/// <param name="target">
		/// The histogram whose parameters are to be set. Must be one of Gl.HISTOGRAM or Gl.PROXY_HISTOGRAM.
		/// </param>
		/// <param name="width">
		/// The number of entries in the histogram table. Must be a power of 2.
		/// </param>
		/// <param name="internalformat">
		/// The format of entries in the histogram table. Must be one of Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
		/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
		/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
		/// Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
		/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="sink">
		/// If Gl.TRUE, pixels will be consumed by the histogramming process and no drawing or texture loading will take place. If 
		/// Gl.FALSE, pixels will proceed to the minmax process after histogramming.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or is not a power of 2.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.TABLE_TOO_LARGE is generated if <paramref name="target"/> is Gl.HISTOGRAM and the histogram table specified is too 
		/// large for the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Histogram is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.ResetHistogram"/>
		[AliasOf("glHistogramEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public static void Histogram(Int32 target, Int32 width, Int32 internalformat, bool sink)
		{
			Debug.Assert(Delegates.pglHistogram != null, "pglHistogram not implemented");
			Delegates.pglHistogram(target, width, internalformat, sink);
			LogFunction("glHistogram({0}, {1}, {2}, {3})", LogEnumName(target), width, LogEnumName(internalformat), sink);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define minmax table
		/// </summary>
		/// <param name="target">
		/// The minmax table whose parameters are to be set. Must be Gl.MINMAX.
		/// </param>
		/// <param name="internalformat">
		/// The format of entries in the minmax table. Must be one of Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
		/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
		/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
		/// Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
		/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, or Gl.RGBA16.
		/// </param>
		/// <param name="sink">
		/// If Gl.TRUE, pixels will be consumed by the minmax process and no drawing or texture loading will take place. If 
		/// Gl.FALSE, pixels will proceed to the final conversion process after minmax.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Minmax is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.ResetMinmax"/>
		[AliasOf("glMinmaxEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public static void Minmax(Int32 target, Int32 internalformat, bool sink)
		{
			Debug.Assert(Delegates.pglMinmax != null, "pglMinmax not implemented");
			Delegates.pglMinmax(target, internalformat, sink);
			LogFunction("glMinmax({0}, {1}, {2})", LogEnumName(target), LogEnumName(internalformat), sink);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reset histogram table entries to zero
		/// </summary>
		/// <param name="target">
		/// Must be Gl.HISTOGRAM.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.HISTOGRAM.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ResetHistogram is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Histogram"/>
		[AliasOf("glResetHistogramEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public static void ResetHistogram(Int32 target)
		{
			Debug.Assert(Delegates.pglResetHistogram != null, "pglResetHistogram not implemented");
			Delegates.pglResetHistogram(target);
			LogFunction("glResetHistogram({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reset minmax table entries to initial values
		/// </summary>
		/// <param name="target">
		/// Must be Gl.MINMAX.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.MINMAX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ResetMinmax is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Minmax"/>
		[AliasOf("glResetMinmaxEXT")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		public static void ResetMinmax(Int32 target)
		{
			Debug.Assert(Delegates.pglResetMinmax != null, "pglResetMinmax not implemented");
			Delegates.pglResetMinmax(target);
			LogFunction("glResetMinmax({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

	}

}
