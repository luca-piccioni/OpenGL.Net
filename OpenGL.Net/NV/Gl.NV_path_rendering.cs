
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
		/// Value of GL_PATH_FORMAT_SVG_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FORMAT_SVG_NV = 0x9070;

		/// <summary>
		/// Value of GL_PATH_FORMAT_PS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FORMAT_PS_NV = 0x9071;

		/// <summary>
		/// Value of GL_STANDARD_FONT_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int STANDARD_FONT_NAME_NV = 0x9072;

		/// <summary>
		/// Value of GL_SYSTEM_FONT_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SYSTEM_FONT_NAME_NV = 0x9073;

		/// <summary>
		/// Value of GL_FILE_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FILE_NAME_NV = 0x9074;

		/// <summary>
		/// Value of GL_PATH_STROKE_WIDTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STROKE_WIDTH_NV = 0x9075;

		/// <summary>
		/// Value of GL_PATH_END_CAPS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_END_CAPS_NV = 0x9076;

		/// <summary>
		/// Value of GL_PATH_INITIAL_END_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_INITIAL_END_CAP_NV = 0x9077;

		/// <summary>
		/// Value of GL_PATH_TERMINAL_END_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_TERMINAL_END_CAP_NV = 0x9078;

		/// <summary>
		/// Value of GL_PATH_JOIN_STYLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_JOIN_STYLE_NV = 0x9079;

		/// <summary>
		/// Value of GL_PATH_MITER_LIMIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MITER_LIMIT_NV = 0x907A;

		/// <summary>
		/// Value of GL_PATH_DASH_CAPS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_DASH_CAPS_NV = 0x907B;

		/// <summary>
		/// Value of GL_PATH_INITIAL_DASH_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_INITIAL_DASH_CAP_NV = 0x907C;

		/// <summary>
		/// Value of GL_PATH_TERMINAL_DASH_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_TERMINAL_DASH_CAP_NV = 0x907D;

		/// <summary>
		/// Value of GL_PATH_DASH_OFFSET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_DASH_OFFSET_NV = 0x907E;

		/// <summary>
		/// Value of GL_PATH_CLIENT_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_CLIENT_LENGTH_NV = 0x907F;

		/// <summary>
		/// Value of GL_PATH_FILL_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FILL_MODE_NV = 0x9080;

		/// <summary>
		/// Value of GL_PATH_FILL_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FILL_MASK_NV = 0x9081;

		/// <summary>
		/// Value of GL_PATH_FILL_COVER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FILL_COVER_MODE_NV = 0x9082;

		/// <summary>
		/// Value of GL_PATH_STROKE_COVER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STROKE_COVER_MODE_NV = 0x9083;

		/// <summary>
		/// Value of GL_PATH_STROKE_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STROKE_MASK_NV = 0x9084;

		/// <summary>
		/// Value of GL_COUNT_UP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int COUNT_UP_NV = 0x9088;

		/// <summary>
		/// Value of GL_COUNT_DOWN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int COUNT_DOWN_NV = 0x9089;

		/// <summary>
		/// Value of GL_PATH_OBJECT_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;

		/// <summary>
		/// Value of GL_CONVEX_HULL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CONVEX_HULL_NV = 0x908B;

		/// <summary>
		/// Value of GL_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int BOUNDING_BOX_NV = 0x908D;

		/// <summary>
		/// Value of GL_TRANSLATE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSLATE_X_NV = 0x908E;

		/// <summary>
		/// Value of GL_TRANSLATE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSLATE_Y_NV = 0x908F;

		/// <summary>
		/// Value of GL_TRANSLATE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSLATE_2D_NV = 0x9090;

		/// <summary>
		/// Value of GL_TRANSLATE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSLATE_3D_NV = 0x9091;

		/// <summary>
		/// Value of GL_AFFINE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int AFFINE_2D_NV = 0x9092;

		/// <summary>
		/// Value of GL_AFFINE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int AFFINE_3D_NV = 0x9094;

		/// <summary>
		/// Value of GL_TRANSPOSE_AFFINE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSPOSE_AFFINE_2D_NV = 0x9096;

		/// <summary>
		/// Value of GL_TRANSPOSE_AFFINE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRANSPOSE_AFFINE_3D_NV = 0x9098;

		/// <summary>
		/// Value of GL_UTF8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int UTF8_NV = 0x909A;

		/// <summary>
		/// Value of GL_UTF16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int UTF16_NV = 0x909B;

		/// <summary>
		/// Value of GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;

		/// <summary>
		/// Value of GL_PATH_COMMAND_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_COMMAND_COUNT_NV = 0x909D;

		/// <summary>
		/// Value of GL_PATH_COORD_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_COORD_COUNT_NV = 0x909E;

		/// <summary>
		/// Value of GL_PATH_DASH_ARRAY_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_DASH_ARRAY_COUNT_NV = 0x909F;

		/// <summary>
		/// Value of GL_PATH_COMPUTED_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_COMPUTED_LENGTH_NV = 0x90A0;

		/// <summary>
		/// Value of GL_PATH_FILL_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FILL_BOUNDING_BOX_NV = 0x90A1;

		/// <summary>
		/// Value of GL_PATH_STROKE_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;

		/// <summary>
		/// Value of GL_SQUARE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SQUARE_NV = 0x90A3;

		/// <summary>
		/// Value of GL_ROUND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ROUND_NV = 0x90A4;

		/// <summary>
		/// Value of GL_TRIANGULAR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int TRIANGULAR_NV = 0x90A5;

		/// <summary>
		/// Value of GL_BEVEL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int BEVEL_NV = 0x90A6;

		/// <summary>
		/// Value of GL_MITER_REVERT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int MITER_REVERT_NV = 0x90A7;

		/// <summary>
		/// Value of GL_MITER_TRUNCATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int MITER_TRUNCATE_NV = 0x90A8;

		/// <summary>
		/// Value of GL_SKIP_MISSING_GLYPH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SKIP_MISSING_GLYPH_NV = 0x90A9;

		/// <summary>
		/// Value of GL_USE_MISSING_GLYPH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int USE_MISSING_GLYPH_NV = 0x90AA;

		/// <summary>
		/// Value of GL_PATH_ERROR_POSITION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_ERROR_POSITION_NV = 0x90AB;

		/// <summary>
		/// Value of GL_ACCUM_ADJACENT_PAIRS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ACCUM_ADJACENT_PAIRS_NV = 0x90AD;

		/// <summary>
		/// Value of GL_ADJACENT_PAIRS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ADJACENT_PAIRS_NV = 0x90AE;

		/// <summary>
		/// Value of GL_FIRST_TO_REST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FIRST_TO_REST_NV = 0x90AF;

		/// <summary>
		/// Value of GL_PATH_GEN_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_GEN_MODE_NV = 0x90B0;

		/// <summary>
		/// Value of GL_PATH_GEN_COEFF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_GEN_COEFF_NV = 0x90B1;

		/// <summary>
		/// Value of GL_PATH_GEN_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_GEN_COMPONENTS_NV = 0x90B3;

		/// <summary>
		/// Value of GL_PATH_STENCIL_FUNC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STENCIL_FUNC_NV = 0x90B7;

		/// <summary>
		/// Value of GL_PATH_STENCIL_REF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STENCIL_REF_NV = 0x90B8;

		/// <summary>
		/// Value of GL_PATH_STENCIL_VALUE_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STENCIL_VALUE_MASK_NV = 0x90B9;

		/// <summary>
		/// Value of GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;

		/// <summary>
		/// Value of GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;

		/// <summary>
		/// Value of GL_PATH_COVER_DEPTH_FUNC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_COVER_DEPTH_FUNC_NV = 0x90BF;

		/// <summary>
		/// Value of GL_PATH_DASH_OFFSET_RESET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_DASH_OFFSET_RESET_NV = 0x90B4;

		/// <summary>
		/// Value of GL_MOVE_TO_RESETS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int MOVE_TO_RESETS_NV = 0x90B5;

		/// <summary>
		/// Value of GL_MOVE_TO_CONTINUES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int MOVE_TO_CONTINUES_NV = 0x90B6;

		/// <summary>
		/// Value of GL_CLOSE_PATH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CLOSE_PATH_NV = 0x00;

		/// <summary>
		/// Value of GL_MOVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int MOVE_TO_NV = 0x02;

		/// <summary>
		/// Value of GL_RELATIVE_MOVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_MOVE_TO_NV = 0x03;

		/// <summary>
		/// Value of GL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int LINE_TO_NV = 0x04;

		/// <summary>
		/// Value of GL_RELATIVE_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_LINE_TO_NV = 0x05;

		/// <summary>
		/// Value of GL_HORIZONTAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int HORIZONTAL_LINE_TO_NV = 0x06;

		/// <summary>
		/// Value of GL_RELATIVE_HORIZONTAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;

		/// <summary>
		/// Value of GL_VERTICAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int VERTICAL_LINE_TO_NV = 0x08;

		/// <summary>
		/// Value of GL_RELATIVE_VERTICAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_VERTICAL_LINE_TO_NV = 0x09;

		/// <summary>
		/// Value of GL_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int QUADRATIC_CURVE_TO_NV = 0x0A;

		/// <summary>
		/// Value of GL_RELATIVE_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;

		/// <summary>
		/// Value of GL_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CUBIC_CURVE_TO_NV = 0x0C;

		/// <summary>
		/// Value of GL_RELATIVE_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;

		/// <summary>
		/// Value of GL_SMOOTH_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;

		/// <summary>
		/// Value of GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;

		/// <summary>
		/// Value of GL_SMOOTH_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SMOOTH_CUBIC_CURVE_TO_NV = 0x10;

		/// <summary>
		/// Value of GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;

		/// <summary>
		/// Value of GL_SMALL_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SMALL_CCW_ARC_TO_NV = 0x12;

		/// <summary>
		/// Value of GL_RELATIVE_SMALL_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;

		/// <summary>
		/// Value of GL_SMALL_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int SMALL_CW_ARC_TO_NV = 0x14;

		/// <summary>
		/// Value of GL_RELATIVE_SMALL_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;

		/// <summary>
		/// Value of GL_LARGE_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int LARGE_CCW_ARC_TO_NV = 0x16;

		/// <summary>
		/// Value of GL_RELATIVE_LARGE_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;

		/// <summary>
		/// Value of GL_LARGE_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int LARGE_CW_ARC_TO_NV = 0x18;

		/// <summary>
		/// Value of GL_RELATIVE_LARGE_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;

		/// <summary>
		/// Value of GL_RESTART_PATH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RESTART_PATH_NV = 0xF0;

		/// <summary>
		/// Value of GL_DUP_FIRST_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;

		/// <summary>
		/// Value of GL_DUP_LAST_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;

		/// <summary>
		/// Value of GL_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RECT_NV = 0xF6;

		/// <summary>
		/// Value of GL_CIRCULAR_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CIRCULAR_CCW_ARC_TO_NV = 0xF8;

		/// <summary>
		/// Value of GL_CIRCULAR_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CIRCULAR_CW_ARC_TO_NV = 0xFA;

		/// <summary>
		/// Value of GL_CIRCULAR_TANGENT_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;

		/// <summary>
		/// Value of GL_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ARC_TO_NV = 0xFE;

		/// <summary>
		/// Value of GL_RELATIVE_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_ARC_TO_NV = 0xFF;

		/// <summary>
		/// Value of GL_BOLD_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int BOLD_BIT_NV = 0x01;

		/// <summary>
		/// Value of GL_ITALIC_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int ITALIC_BIT_NV = 0x02;

		/// <summary>
		/// Value of GL_GLYPH_WIDTH_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_WIDTH_BIT_NV = 0x01;

		/// <summary>
		/// Value of GL_GLYPH_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_HEIGHT_BIT_NV = 0x02;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_X_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;

		/// <summary>
		/// Value of GL_GLYPH_HAS_KERNING_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const int GLYPH_HAS_KERNING_BIT_NV = 0x100;

		/// <summary>
		/// Value of GL_FONT_X_MIN_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;

		/// <summary>
		/// Value of GL_FONT_Y_MIN_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;

		/// <summary>
		/// Value of GL_FONT_X_MAX_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;

		/// <summary>
		/// Value of GL_FONT_Y_MAX_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;

		/// <summary>
		/// Value of GL_FONT_UNITS_PER_EM_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_UNITS_PER_EM_BIT_NV = 0x00100000;

		/// <summary>
		/// Value of GL_FONT_ASCENDER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_ASCENDER_BIT_NV = 0x00200000;

		/// <summary>
		/// Value of GL_FONT_DESCENDER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_DESCENDER_BIT_NV = 0x00400000;

		/// <summary>
		/// Value of GL_FONT_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_HEIGHT_BIT_NV = 0x00800000;

		/// <summary>
		/// Value of GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;

		/// <summary>
		/// Value of GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;

		/// <summary>
		/// Value of GL_FONT_UNDERLINE_POSITION_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;

		/// <summary>
		/// Value of GL_FONT_UNDERLINE_THICKNESS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;

		/// <summary>
		/// Value of GL_FONT_HAS_KERNING_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_HAS_KERNING_BIT_NV = 0x10000000;

		/// <summary>
		/// Value of GL_ROUNDED_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ROUNDED_RECT_NV = 0xE8;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_ROUNDED_RECT_NV = 0xE9;

		/// <summary>
		/// Value of GL_ROUNDED_RECT2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ROUNDED_RECT2_NV = 0xEA;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_ROUNDED_RECT2_NV = 0xEB;

		/// <summary>
		/// Value of GL_ROUNDED_RECT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ROUNDED_RECT4_NV = 0xEC;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_ROUNDED_RECT4_NV = 0xED;

		/// <summary>
		/// Value of GL_ROUNDED_RECT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int ROUNDED_RECT8_NV = 0xEE;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_ROUNDED_RECT8_NV = 0xEF;

		/// <summary>
		/// Value of GL_RELATIVE_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_RECT_NV = 0xF7;

		/// <summary>
		/// Value of GL_FONT_GLYPHS_AVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FONT_GLYPHS_AVAILABLE_NV = 0x9368;

		/// <summary>
		/// Value of GL_FONT_TARGET_UNAVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FONT_TARGET_UNAVAILABLE_NV = 0x9369;

		/// <summary>
		/// Value of GL_FONT_UNAVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FONT_UNAVAILABLE_NV = 0x936A;

		/// <summary>
		/// Value of GL_FONT_UNINTELLIGIBLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FONT_UNINTELLIGIBLE_NV = 0x936B;

		/// <summary>
		/// Value of GL_CONIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int CONIC_CURVE_TO_NV = 0x1A;

		/// <summary>
		/// Value of GL_RELATIVE_CONIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int RELATIVE_CONIC_CURVE_TO_NV = 0x1B;

		/// <summary>
		/// Value of GL_FONT_NUM_GLYPH_INDICES_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;

		/// <summary>
		/// Value of GL_STANDARD_FONT_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int STANDARD_FONT_FORMAT_NV = 0x936C;

		/// <summary>
		/// Value of GL_PATH_FOG_GEN_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_FOG_GEN_MODE_NV = 0x90AC;

		/// <summary>
		/// Value of GL_PATH_GEN_COLOR_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_GEN_COLOR_FORMAT_NV = 0x90B2;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_PROJECTION_NV = 0x1701;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MODELVIEW_NV = 0x1700;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MODELVIEW_MATRIX_NV = 0x0BA6;

		/// <summary>
		/// Value of GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;

		/// <summary>
		/// Value of GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_PROJECTION_MATRIX_NV = 0x0BA7;

		/// <summary>
		/// Value of GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;

		/// <summary>
		/// Value of GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;

		/// <summary>
		/// Value of GL_FRAGMENT_INPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public const int FRAGMENT_INPUT_NV = 0x936D;

		/// <summary>
		/// Binding for glGenPathsNV.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static UInt32 GenPathsNV(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenPathsNV != null, "pglGenPathsNV not implemented");
			retValue = Delegates.pglGenPathsNV(range);
			LogFunction("glGenPathsNV({0}) = {1}", range, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glDeletePathsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void DeletePathsNV(UInt32 path, Int32 range)
		{
			Debug.Assert(Delegates.pglDeletePathsNV != null, "pglDeletePathsNV not implemented");
			Delegates.pglDeletePathsNV(path, range);
			LogFunction("glDeletePathsNV({0}, {1})", path, range);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static bool IsPathNV(UInt32 path)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPathNV != null, "pglIsPathNV not implemented");
			retValue = Delegates.pglIsPathNV(path);
			LogFunction("glIsPathNV({0}) = {1}", path, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathCommandsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numCommands">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commands">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathCommandsNV(UInt32 path, Int32 numCommands, byte[] commands, Int32 numCoords, Int32 coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathCommandsNV(path, numCommands, commands, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
		}

		/// <summary>
		/// Binding for glPathCommandsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commands">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathCommandsNV(UInt32 path, byte[] commands, Int32 numCoords, Int32 coordType, IntPtr coords)
		{
			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglPathCommandsNV != null, "pglPathCommandsNV not implemented");
					Delegates.pglPathCommandsNV(path, (Int32)commands.Length, p_commands, numCoords, coordType, coords);
					LogFunction("glPathCommandsNV({0}, {1}, {2}, {3}, {4}, 0x{5})", path, commands.Length, LogValue(commands), numCoords, LogEnumName(coordType), coords.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathCoordsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathCoordsNV(UInt32 path, Int32 numCoords, Int32 coordType, IntPtr coords)
		{
			Debug.Assert(Delegates.pglPathCoordsNV != null, "pglPathCoordsNV not implemented");
			Delegates.pglPathCoordsNV(path, numCoords, coordType, coords);
			LogFunction("glPathCoordsNV({0}, {1}, {2}, 0x{3})", path, numCoords, LogEnumName(coordType), coords.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathCoordsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathCoordsNV(UInt32 path, Int32 numCoords, Int32 coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathCoordsNV(path, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
		}

		/// <summary>
		/// Binding for glPathSubCommandsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commandStart">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commandsToDelete">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numCommands">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commands">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte[] commands, Int32 numCoords, Int32 coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
		}

		/// <summary>
		/// Binding for glPathSubCommandsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commandStart">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commandsToDelete">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commands">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, byte[] commands, Int32 numCoords, Int32 coordType, IntPtr coords)
		{
			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglPathSubCommandsNV != null, "pglPathSubCommandsNV not implemented");
					Delegates.pglPathSubCommandsNV(path, commandStart, commandsToDelete, (Int32)commands.Length, p_commands, numCoords, coordType, coords);
					LogFunction("glPathSubCommandsNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", path, commandStart, commandsToDelete, commands.Length, LogValue(commands), numCoords, LogEnumName(coordType), coords.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathSubCoordsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coordStart">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathSubCoordNV(UInt32 path, Int32 coordStart, Int32 numCoords, Int32 coordType, IntPtr coords)
		{
			Debug.Assert(Delegates.pglPathSubCoordsNV != null, "pglPathSubCoordsNV not implemented");
			Delegates.pglPathSubCoordsNV(path, coordStart, numCoords, coordType, coords);
			LogFunction("glPathSubCoordsNV({0}, {1}, {2}, {3}, 0x{4})", path, coordStart, numCoords, LogEnumName(coordType), coords.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathSubCoordsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coordStart">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numCoords">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coordType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathSubCoordNV(UInt32 path, Int32 coordStart, Int32 numCoords, Int32 coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathSubCoordNV(path, coordStart, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
		}

		/// <summary>
		/// Binding for glPathStringNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathString">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathStringNV(UInt32 path, Int32 format, Int32 length, IntPtr pathString)
		{
			Debug.Assert(Delegates.pglPathStringNV != null, "pglPathStringNV not implemented");
			Delegates.pglPathStringNV(path, format, length, pathString);
			LogFunction("glPathStringNV({0}, {1}, {2}, 0x{3})", path, LogEnumName(format), length, pathString.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathStringNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathString">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathStringNV(UInt32 path, Int32 format, Int32 length, Object pathString)
		{
			GCHandle pin_pathString = GCHandle.Alloc(pathString, GCHandleType.Pinned);
			try {
				PathStringNV(path, format, length, pin_pathString.AddrOfPinnedObject());
			} finally {
				pin_pathString.Free();
			}
		}

		/// <summary>
		/// Binding for glPathGlyphsNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="charcodes">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathGlyphsNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, Int32 numGlyphs, Int32 type, IntPtr charcodes, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Debug.Assert(Delegates.pglPathGlyphsNV != null, "pglPathGlyphsNV not implemented");
			Delegates.pglPathGlyphsNV(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
			LogFunction("glPathGlyphsNV({0}, {1}, 0x{2}, {3}, {4}, {5}, 0x{6}, {7}, {8}, {9})", firstPathName, LogEnumName(fontTarget), fontName.ToString("X8"), fontStyle, numGlyphs, LogEnumName(type), charcodes.ToString("X8"), LogEnumName(handleMissingGlyphs), pathParameterTemplate, emScale);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathGlyphsNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="charcodes">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathGlyphsNV(UInt32 firstPathName, Int32 fontTarget, Object fontName, UInt32 fontStyle, Int32 numGlyphs, Int32 type, Object charcodes, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			GCHandle pin_fontName = GCHandle.Alloc(fontName, GCHandleType.Pinned);
			GCHandle pin_charcodes = GCHandle.Alloc(charcodes, GCHandleType.Pinned);
			try {
				PathGlyphsNV(firstPathName, fontTarget, pin_fontName.AddrOfPinnedObject(), fontStyle, numGlyphs, type, pin_charcodes.AddrOfPinnedObject(), handleMissingGlyphs, pathParameterTemplate, emScale);
			} finally {
				pin_fontName.Free();
				pin_charcodes.Free();
			}
		}

		/// <summary>
		/// Binding for glPathGlyphRangeNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="firstGlyph">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathGlyphRangeNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyph, Int32 numGlyphs, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Debug.Assert(Delegates.pglPathGlyphRangeNV != null, "pglPathGlyphRangeNV not implemented");
			Delegates.pglPathGlyphRangeNV(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
			LogFunction("glPathGlyphRangeNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8})", firstPathName, LogEnumName(fontTarget), fontName.ToString("X8"), fontStyle, firstGlyph, numGlyphs, LogEnumName(handleMissingGlyphs), pathParameterTemplate, emScale);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathGlyphRangeNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="firstGlyph">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathGlyphRangeNV(UInt32 firstPathName, Int32 fontTarget, Object fontName, UInt32 fontStyle, UInt32 firstGlyph, Int32 numGlyphs, Int32 handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			GCHandle pin_fontName = GCHandle.Alloc(fontName, GCHandleType.Pinned);
			try {
				PathGlyphRangeNV(firstPathName, fontTarget, pin_fontName.AddrOfPinnedObject(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
			} finally {
				pin_fontName.Free();
			}
		}

		/// <summary>
		/// Binding for glWeightPathsNV.
		/// </summary>
		/// <param name="resultPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void WeightPathsNV(UInt32 resultPath, UInt32[] paths, float[] weights)
		{
			unsafe {
				fixed (UInt32* p_paths = paths)
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightPathsNV != null, "pglWeightPathsNV not implemented");
					Delegates.pglWeightPathsNV(resultPath, (Int32)paths.Length, p_paths, p_weights);
					LogFunction("glWeightPathsNV({0}, {1}, {2}, {3})", resultPath, paths.Length, LogValue(paths), LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyPathNV.
		/// </summary>
		/// <param name="resultPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CopyPathNV(UInt32 resultPath, UInt32 srcPath)
		{
			Debug.Assert(Delegates.pglCopyPathNV != null, "pglCopyPathNV not implemented");
			Delegates.pglCopyPathNV(resultPath, srcPath);
			LogFunction("glCopyPathNV({0}, {1})", resultPath, srcPath);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glInterpolatePathsNV.
		/// </summary>
		/// <param name="resultPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pathA">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pathB">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="weight">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void InterpolatePathsNV(UInt32 resultPath, UInt32 pathA, UInt32 pathB, float weight)
		{
			Debug.Assert(Delegates.pglInterpolatePathsNV != null, "pglInterpolatePathsNV not implemented");
			Delegates.pglInterpolatePathsNV(resultPath, pathA, pathB, weight);
			LogFunction("glInterpolatePathsNV({0}, {1}, {2}, {3})", resultPath, pathA, pathB, weight);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTransformPathNV.
		/// </summary>
		/// <param name="resultPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcPath">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void TransformPathNV(UInt32 resultPath, UInt32 srcPath, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglTransformPathNV != null, "pglTransformPathNV not implemented");
					Delegates.pglTransformPathNV(resultPath, srcPath, transformType, p_transformValues);
					LogFunction("glTransformPathNV({0}, {1}, {2}, {3})", resultPath, srcPath, LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathParameterivNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathParameterNV(UInt32 path, Int32 pname, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglPathParameterivNV != null, "pglPathParameterivNV not implemented");
					Delegates.pglPathParameterivNV(path, pname, p_value);
					LogFunction("glPathParameterivNV({0}, {1}, {2})", path, LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathParameteriNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathParameterNV(UInt32 path, Int32 pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPathParameteriNV != null, "pglPathParameteriNV not implemented");
			Delegates.pglPathParameteriNV(path, pname, value);
			LogFunction("glPathParameteriNV({0}, {1}, {2})", path, LogEnumName(pname), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathParameterfvNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathParameterNV(UInt32 path, Int32 pname, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglPathParameterfvNV != null, "pglPathParameterfvNV not implemented");
					Delegates.pglPathParameterfvNV(path, pname, p_value);
					LogFunction("glPathParameterfvNV({0}, {1}, {2})", path, LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathParameterfNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathParameterNV(UInt32 path, Int32 pname, float value)
		{
			Debug.Assert(Delegates.pglPathParameterfNV != null, "pglPathParameterfNV not implemented");
			Delegates.pglPathParameterfNV(path, pname, value);
			LogFunction("glPathParameterfNV({0}, {1}, {2})", path, LogEnumName(pname), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathDashArrayNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dashArray">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathDashArrayNV(UInt32 path, float[] dashArray)
		{
			unsafe {
				fixed (float* p_dashArray = dashArray)
				{
					Debug.Assert(Delegates.pglPathDashArrayNV != null, "pglPathDashArrayNV not implemented");
					Delegates.pglPathDashArrayNV(path, (Int32)dashArray.Length, p_dashArray);
					LogFunction("glPathDashArrayNV({0}, {1}, {2})", path, dashArray.Length, LogValue(dashArray));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathStencilFuncNV.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:StencilFunction"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathStencilFuncNV(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglPathStencilFuncNV != null, "pglPathStencilFuncNV not implemented");
			Delegates.pglPathStencilFuncNV((Int32)func, @ref, mask);
			LogFunction("glPathStencilFuncNV({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathStencilDepthOffsetNV.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathStencilDepthOffsetNV(float factor, float units)
		{
			Debug.Assert(Delegates.pglPathStencilDepthOffsetNV != null, "pglPathStencilDepthOffsetNV not implemented");
			Delegates.pglPathStencilDepthOffsetNV(factor, units);
			LogFunction("glPathStencilDepthOffsetNV({0}, {1})", factor, units);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFillPathNV != null, "pglStencilFillPathNV not implemented");
			Delegates.pglStencilFillPathNV(path, fillMode, mask);
			LogFunction("glStencilFillPathNV({0}, {1}, {2})", path, LogEnumName(fillMode), mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilStrokePathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilStrokePathNV(UInt32 path, Int32 reference, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilStrokePathNV != null, "pglStencilStrokePathNV not implemented");
			Delegates.pglStencilStrokePathNV(path, reference, mask);
			LogFunction("glStencilStrokePathNV({0}, {1}, {2})", path, reference, mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilFillPathInstancedNV != null, "pglStencilFillPathInstancedNV not implemented");
					Delegates.pglStencilFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, p_transformValues);
					LogFunction("glStencilFillPathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, LogEnumName(fillMode), mask, LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				StencilFillPathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, fillMode, mask, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glStencilStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilStrokePathInstancedNV != null, "pglStencilStrokePathInstancedNV not implemented");
					Delegates.pglStencilStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, p_transformValues);
					LogFunction("glStencilStrokePathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, reference, mask, LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				StencilStrokePathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, reference, mask, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glPathCoverDepthFuncNV.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:DepthFunction"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathCoverDepthFuncNV(DepthFunction func)
		{
			Debug.Assert(Delegates.pglPathCoverDepthFuncNV != null, "pglPathCoverDepthFuncNV not implemented");
			Delegates.pglPathCoverDepthFuncNV((Int32)func);
			LogFunction("glPathCoverDepthFuncNV({0})", func);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverFillPathNV(UInt32 path, Int32 coverMode)
		{
			Debug.Assert(Delegates.pglCoverFillPathNV != null, "pglCoverFillPathNV not implemented");
			Delegates.pglCoverFillPathNV(path, coverMode);
			LogFunction("glCoverFillPathNV({0}, {1})", path, LogEnumName(coverMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverStrokePathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverStrokePathNV(UInt32 path, Int32 coverMode)
		{
			Debug.Assert(Delegates.pglCoverStrokePathNV != null, "pglCoverStrokePathNV not implemented");
			Delegates.pglCoverStrokePathNV(path, coverMode);
			LogFunction("glCoverStrokePathNV({0}, {1})", path, LogEnumName(coverMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglCoverFillPathInstancedNV != null, "pglCoverFillPathInstancedNV not implemented");
					Delegates.pglCoverFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, p_transformValues);
					LogFunction("glCoverFillPathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, LogEnumName(coverMode), LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				CoverFillPathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, coverMode, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglCoverStrokePathInstancedNV != null, "pglCoverStrokePathInstancedNV not implemented");
					Delegates.pglCoverStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, p_transformValues);
					LogFunction("glCoverStrokePathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, LogEnumName(coverMode), LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void CoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				CoverStrokePathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, coverMode, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPathParameterivNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathParameterNV(UInt32 path, Int32 pname, [Out] Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathParameterivNV != null, "pglGetPathParameterivNV not implemented");
					Delegates.pglGetPathParameterivNV(path, pname, p_value);
					LogFunction("glGetPathParameterivNV({0}, {1}, {2})", path, LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathParameterfvNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathParameterNV(UInt32 path, Int32 pname, [Out] float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathParameterfvNV != null, "pglGetPathParameterfvNV not implemented");
					Delegates.pglGetPathParameterfvNV(path, pname, p_value);
					LogFunction("glGetPathParameterfvNV({0}, {1}, {2})", path, LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathCommandsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commands">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathCommandsNV(UInt32 path, [Out] byte[] commands)
		{
			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglGetPathCommandsNV != null, "pglGetPathCommandsNV not implemented");
					Delegates.pglGetPathCommandsNV(path, p_commands);
					LogFunction("glGetPathCommandsNV({0}, {1})", path, LogValue(commands));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathCoordsNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathCoordsNV(UInt32 path, [Out] float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglGetPathCoordsNV != null, "pglGetPathCoordsNV not implemented");
					Delegates.pglGetPathCoordsNV(path, p_coords);
					LogFunction("glGetPathCoordsNV({0}, {1})", path, LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathDashArrayNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dashArray">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathDashArrayNV(UInt32 path, [Out] float[] dashArray)
		{
			unsafe {
				fixed (float* p_dashArray = dashArray)
				{
					Debug.Assert(Delegates.pglGetPathDashArrayNV != null, "pglGetPathDashArrayNV not implemented");
					Delegates.pglGetPathDashArrayNV(path, p_dashArray);
					LogFunction("glGetPathDashArrayNV({0}, {1})", path, LogValue(dashArray));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathMetricsNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="metrics">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathMetricsNV(UInt32 metricQueryMask, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 stride, [Out] float[] metrics)
		{
			unsafe {
				fixed (float* p_metrics = metrics)
				{
					Debug.Assert(Delegates.pglGetPathMetricsNV != null, "pglGetPathMetricsNV not implemented");
					Delegates.pglGetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, p_metrics);
					LogFunction("glGetPathMetricsNV({0}, {1}, {2}, 0x{3}, {4}, {5}, {6})", metricQueryMask, numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, stride, LogValue(metrics));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathMetricsNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="metrics">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathMetricsNV(UInt32 metricQueryMask, Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 stride, [Out] float[] metrics)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				GetPathMetricsNV(metricQueryMask, numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, stride, metrics);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPathMetricRangeNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="metrics">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathMetricRangeNV(UInt32 metricQueryMask, UInt32 firstPathName, Int32 numPaths, Int32 stride, [Out] float[] metrics)
		{
			unsafe {
				fixed (float* p_metrics = metrics)
				{
					Debug.Assert(Delegates.pglGetPathMetricRangeNV != null, "pglGetPathMetricRangeNV not implemented");
					Delegates.pglGetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, p_metrics);
					LogFunction("glGetPathMetricRangeNV({0}, {1}, {2}, {3}, {4})", metricQueryMask, firstPathName, numPaths, stride, LogValue(metrics));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathSpacingNV.
		/// </summary>
		/// <param name="pathListMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="advanceScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="kerningScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="returnedSpacing">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathSpacingNV(Int32 pathListMode, Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, float advanceScale, float kerningScale, Int32 transformType, [Out] float[] returnedSpacing)
		{
			unsafe {
				fixed (float* p_returnedSpacing = returnedSpacing)
				{
					Debug.Assert(Delegates.pglGetPathSpacingNV != null, "pglGetPathSpacingNV not implemented");
					Delegates.pglGetPathSpacingNV(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, p_returnedSpacing);
					LogFunction("glGetPathSpacingNV({0}, {1}, {2}, 0x{3}, {4}, {5}, {6}, {7}, {8})", LogEnumName(pathListMode), numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, advanceScale, kerningScale, LogEnumName(transformType), LogValue(returnedSpacing));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathSpacingNV.
		/// </summary>
		/// <param name="pathListMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="advanceScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="kerningScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="returnedSpacing">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathSpacingNV(Int32 pathListMode, Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, float advanceScale, float kerningScale, Int32 transformType, [Out] float[] returnedSpacing)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				GetPathSpacingNV(pathListMode, numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glIsPointInFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static bool IsPointInFillPathNV(UInt32 path, UInt32 mask, float x, float y)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPointInFillPathNV != null, "pglIsPointInFillPathNV not implemented");
			retValue = Delegates.pglIsPointInFillPathNV(path, mask, x, y);
			LogFunction("glIsPointInFillPathNV({0}, {1}, {2}, {3}) = {4}", path, mask, x, y, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsPointInStrokePathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static bool IsPointInStrokePathNV(UInt32 path, float x, float y)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPointInStrokePathNV != null, "pglIsPointInStrokePathNV not implemented");
			retValue = Delegates.pglIsPointInStrokePathNV(path, x, y);
			LogFunction("glIsPointInStrokePathNV({0}, {1}, {2}) = {3}", path, x, y, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetPathLengthNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="startSegment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numSegments">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static float GetPathNV(UInt32 path, Int32 startSegment, Int32 numSegments)
		{
			float retValue;

			Debug.Assert(Delegates.pglGetPathLengthNV != null, "pglGetPathLengthNV not implemented");
			retValue = Delegates.pglGetPathLengthNV(path, startSegment, numSegments);
			LogFunction("glGetPathLengthNV({0}, {1}, {2}) = {3}", path, startSegment, numSegments, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glPointAlongPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="startSegment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numSegments">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="distance">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="tangentX">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="tangentY">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static bool PointAlongPathNV(UInt32 path, Int32 startSegment, Int32 numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
		{
			bool retValue;

			unsafe {
				fixed (float* p_x = x)
				fixed (float* p_y = y)
				fixed (float* p_tangentX = tangentX)
				fixed (float* p_tangentY = tangentY)
				{
					Debug.Assert(Delegates.pglPointAlongPathNV != null, "pglPointAlongPathNV not implemented");
					retValue = Delegates.pglPointAlongPathNV(path, startSegment, numSegments, distance, p_x, p_y, p_tangentX, p_tangentY);
					LogFunction("glPointAlongPathNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", path, startSegment, numSegments, distance, LogValue(x), LogValue(y), LogValue(tangentX), LogValue(tangentY), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMatrixLoad3x2fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixLoad3x2NV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoad3x2fNV != null, "pglMatrixLoad3x2fNV not implemented");
					Delegates.pglMatrixLoad3x2fNV(matrixMode, p_m);
					LogFunction("glMatrixLoad3x2fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixLoad3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixLoad3NV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoad3x3fNV != null, "pglMatrixLoad3x3fNV not implemented");
					Delegates.pglMatrixLoad3x3fNV(matrixMode, p_m);
					LogFunction("glMatrixLoad3x3fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixLoadTranspose3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixLoadTransposeNV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoadTranspose3x3fNV != null, "pglMatrixLoadTranspose3x3fNV not implemented");
					Delegates.pglMatrixLoadTranspose3x3fNV(matrixMode, p_m);
					LogFunction("glMatrixLoadTranspose3x3fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMult3x2fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixMult3x2NV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMult3x2fNV != null, "pglMatrixMult3x2fNV not implemented");
					Delegates.pglMatrixMult3x2fNV(matrixMode, p_m);
					LogFunction("glMatrixMult3x2fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMult3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixMult3x3NV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMult3x3fNV != null, "pglMatrixMult3x3fNV not implemented");
					Delegates.pglMatrixMult3x3fNV(matrixMode, p_m);
					LogFunction("glMatrixMult3x3fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMultTranspose3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void MatrixMultTransposeNV(Int32 matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultTranspose3x3fNV != null, "pglMatrixMultTranspose3x3fNV not implemented");
					Delegates.pglMatrixMultTranspose3x3fNV(matrixMode, p_m);
					LogFunction("glMatrixMultTranspose3x3fNV({0}, {1})", LogEnumName(matrixMode), LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverFillPathNV(UInt32 path, Int32 fillMode, UInt32 mask, Int32 coverMode)
		{
			Debug.Assert(Delegates.pglStencilThenCoverFillPathNV != null, "pglStencilThenCoverFillPathNV not implemented");
			Delegates.pglStencilThenCoverFillPathNV(path, fillMode, mask, coverMode);
			LogFunction("glStencilThenCoverFillPathNV({0}, {1}, {2}, {3})", path, LogEnumName(fillMode), mask, LogEnumName(coverMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilThenCoverStrokePathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverStrokePathNV(UInt32 path, Int32 reference, UInt32 mask, Int32 coverMode)
		{
			Debug.Assert(Delegates.pglStencilThenCoverStrokePathNV != null, "pglStencilThenCoverStrokePathNV not implemented");
			Delegates.pglStencilThenCoverStrokePathNV(path, reference, mask, coverMode);
			LogFunction("glStencilThenCoverStrokePathNV({0}, {1}, {2}, {3})", path, reference, mask, LogEnumName(coverMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilThenCoverFillPathInstancedNV != null, "pglStencilThenCoverFillPathInstancedNV not implemented");
					Delegates.pglStencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, p_transformValues);
					LogFunction("glStencilThenCoverFillPathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, LogEnumName(fillMode), mask, LogEnumName(coverMode), LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverFillPathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 fillMode, UInt32 mask, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				StencilThenCoverFillPathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glStencilThenCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilThenCoverStrokePathInstancedNV != null, "pglStencilThenCoverStrokePathInstancedNV not implemented");
					Delegates.pglStencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, p_transformValues);
					LogFunction("glStencilThenCoverStrokePathInstancedNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7}, {8})", numPaths, LogEnumName(pathNameType), paths.ToString("X8"), pathBase, reference, mask, LogEnumName(coverMode), LogEnumName(transformType), LogValue(transformValues));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStencilThenCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="reference">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void StencilThenCoverStrokePathInstancedNV(Int32 numPaths, Int32 pathNameType, Object paths, UInt32 pathBase, Int32 reference, UInt32 mask, Int32 coverMode, Int32 transformType, float[] transformValues)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				StencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, reference, mask, coverMode, transformType, transformValues);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glPathGlyphIndexRangeNV.
		/// </summary>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="baseAndCount">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathGlyphIndexRangeNV(Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32[] baseAndCount)
		{
			Int32 retValue;

			unsafe {
				fixed (UInt32* p_baseAndCount = baseAndCount)
				{
					Debug.Assert(Delegates.pglPathGlyphIndexRangeNV != null, "pglPathGlyphIndexRangeNV not implemented");
					retValue = Delegates.pglPathGlyphIndexRangeNV(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, p_baseAndCount);
					LogFunction("glPathGlyphIndexRangeNV({0}, 0x{1}, {2}, {3}, {4}, {5}) = {6}", LogEnumName(fontTarget), fontName.ToString("X8"), fontStyle, pathParameterTemplate, emScale, LogValue(baseAndCount), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathGlyphIndexRangeNV.
		/// </summary>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="baseAndCount">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathGlyphIndexRangeNV(Int32 fontTarget, Object fontName, UInt32 fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32[] baseAndCount)
		{
			GCHandle pin_fontName = GCHandle.Alloc(fontName, GCHandleType.Pinned);
			try {
				return (PathGlyphIndexRangeNV(fontTarget, pin_fontName.AddrOfPinnedObject(), fontStyle, pathParameterTemplate, emScale, baseAndCount));
			} finally {
				pin_fontName.Free();
			}
		}

		/// <summary>
		/// Binding for glPathGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="firstGlyphIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, IntPtr fontName, UInt32 fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglPathGlyphIndexArrayNV != null, "pglPathGlyphIndexArrayNV not implemented");
			retValue = Delegates.pglPathGlyphIndexArrayNV(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
			LogFunction("glPathGlyphIndexArrayNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6}, {7}) = {8}", firstPathName, LogEnumName(fontTarget), fontName.ToString("X8"), fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="firstGlyphIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, Object fontName, UInt32 fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			GCHandle pin_fontName = GCHandle.Alloc(fontName, GCHandleType.Pinned);
			try {
				return (PathGlyphIndexArrayNV(firstPathName, fontTarget, pin_fontName.AddrOfPinnedObject(), fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale));
			} finally {
				pin_fontName.Free();
			}
		}

		/// <summary>
		/// Binding for glPathMemoryGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontSize">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontData">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="faceIndex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="firstGlyphIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathMemoryGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, UInt32 fontSize, IntPtr fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglPathMemoryGlyphIndexArrayNV != null, "pglPathMemoryGlyphIndexArrayNV not implemented");
			retValue = Delegates.pglPathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
			LogFunction("glPathMemoryGlyphIndexArrayNV({0}, {1}, {2}, 0x{3}, {4}, {5}, {6}, {7}, {8}) = {9}", firstPathName, LogEnumName(fontTarget), fontSize, fontData.ToString("X8"), faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathMemoryGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fontSize">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontData">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="faceIndex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="firstGlyphIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static Int32 PathMemoryGlyphIndexArrayNV(UInt32 firstPathName, Int32 fontTarget, UInt32 fontSize, Object fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			GCHandle pin_fontData = GCHandle.Alloc(fontData, GCHandleType.Pinned);
			try {
				return (PathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, pin_fontData.AddrOfPinnedObject(), faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale));
			} finally {
				pin_fontData.Free();
			}
		}

		/// <summary>
		/// Binding for glProgramPathFragmentInputGenNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="genMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="components">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void ProgramPathFragmentInputGenNV(UInt32 program, Int32 location, Int32 genMode, Int32 components, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglProgramPathFragmentInputGenNV != null, "pglProgramPathFragmentInputGenNV not implemented");
					Delegates.pglProgramPathFragmentInputGenNV(program, location, genMode, components, p_coeffs);
					LogFunction("glProgramPathFragmentInputGenNV({0}, {1}, {2}, {3}, {4})", program, location, LogEnumName(genMode), components, LogValue(coeffs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramResourcefvNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="programInterface">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="propCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="props">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetProgramResourceNV(UInt32 program, Int32 programInterface, UInt32 index, Int32 propCount, Int32[] props, Int32 bufSize, [Out] Int32[] length, [Out] float[] @params)
		{
			unsafe {
				fixed (Int32* p_props = props)
				fixed (Int32* p_length = length)
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramResourcefvNV != null, "pglGetProgramResourcefvNV not implemented");
					Delegates.pglGetProgramResourcefvNV(program, programInterface, index, propCount, p_props, bufSize, p_length, p_params);
					LogFunction("glGetProgramResourcefvNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", program, LogEnumName(programInterface), index, propCount, LogEnumName(props), bufSize, LogValue(length), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathColorGenNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="genMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathColorGenNV(Int32 color, Int32 genMode, Int32 colorFormat, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglPathColorGenNV != null, "pglPathColorGenNV not implemented");
					Delegates.pglPathColorGenNV(color, genMode, colorFormat, p_coeffs);
					LogFunction("glPathColorGenNV({0}, {1}, {2}, {3})", LogEnumName(color), LogEnumName(genMode), LogEnumName(colorFormat), LogValue(coeffs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathTexGenNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="genMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="components">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathTexGenNV(Int32 texCoordSet, Int32 genMode, Int32 components, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglPathTexGenNV != null, "pglPathTexGenNV not implemented");
					Delegates.pglPathTexGenNV(texCoordSet, genMode, components, p_coeffs);
					LogFunction("glPathTexGenNV({0}, {1}, {2}, {3})", LogEnumName(texCoordSet), LogEnumName(genMode), components, LogValue(coeffs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPathFogGenNV.
		/// </summary>
		/// <param name="genMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void PathFogGenNV(Int32 genMode)
		{
			Debug.Assert(Delegates.pglPathFogGenNV != null, "pglPathFogGenNV not implemented");
			Delegates.pglPathFogGenNV(genMode);
			LogFunction("glPathFogGenNV({0})", LogEnumName(genMode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathColorGenivNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathColorGenNV(Int32 color, Int32 pname, [Out] Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathColorGenivNV != null, "pglGetPathColorGenivNV not implemented");
					Delegates.pglGetPathColorGenivNV(color, pname, p_value);
					LogFunction("glGetPathColorGenivNV({0}, {1}, {2})", LogEnumName(color), LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathColorGenfvNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathColorGenNV(Int32 color, Int32 pname, [Out] float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathColorGenfvNV != null, "pglGetPathColorGenfvNV not implemented");
					Delegates.pglGetPathColorGenfvNV(color, pname, p_value);
					LogFunction("glGetPathColorGenfvNV({0}, {1}, {2})", LogEnumName(color), LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathTexGenivNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathTexGenNV(Int32 texCoordSet, Int32 pname, [Out] Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathTexGenivNV != null, "pglGetPathTexGenivNV not implemented");
					Delegates.pglGetPathTexGenivNV(texCoordSet, pname, p_value);
					LogFunction("glGetPathTexGenivNV({0}, {1}, {2})", LogEnumName(texCoordSet), LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPathTexGenfvNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		public static void GetPathTexGenNV(Int32 texCoordSet, Int32 pname, [Out] float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathTexGenfvNV != null, "pglGetPathTexGenfvNV not implemented");
					Delegates.pglGetPathTexGenfvNV(texCoordSet, pname, p_value);
					LogFunction("glGetPathTexGenfvNV({0}, {1}, {2})", LogEnumName(texCoordSet), LogEnumName(pname), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
