
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FORMAT_SVG_NV = 0x9070;

		/// <summary>
		/// Value of GL_PATH_FORMAT_PS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FORMAT_PS_NV = 0x9071;

		/// <summary>
		/// Value of GL_STANDARD_FONT_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int STANDARD_FONT_NAME_NV = 0x9072;

		/// <summary>
		/// Value of GL_SYSTEM_FONT_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SYSTEM_FONT_NAME_NV = 0x9073;

		/// <summary>
		/// Value of GL_FILE_NAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FILE_NAME_NV = 0x9074;

		/// <summary>
		/// Value of GL_PATH_STROKE_WIDTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STROKE_WIDTH_NV = 0x9075;

		/// <summary>
		/// Value of GL_PATH_END_CAPS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_END_CAPS_NV = 0x9076;

		/// <summary>
		/// Value of GL_PATH_INITIAL_END_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_INITIAL_END_CAP_NV = 0x9077;

		/// <summary>
		/// Value of GL_PATH_TERMINAL_END_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_TERMINAL_END_CAP_NV = 0x9078;

		/// <summary>
		/// Value of GL_PATH_JOIN_STYLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_JOIN_STYLE_NV = 0x9079;

		/// <summary>
		/// Value of GL_PATH_MITER_LIMIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MITER_LIMIT_NV = 0x907A;

		/// <summary>
		/// Value of GL_PATH_DASH_CAPS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_DASH_CAPS_NV = 0x907B;

		/// <summary>
		/// Value of GL_PATH_INITIAL_DASH_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_INITIAL_DASH_CAP_NV = 0x907C;

		/// <summary>
		/// Value of GL_PATH_TERMINAL_DASH_CAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_TERMINAL_DASH_CAP_NV = 0x907D;

		/// <summary>
		/// Value of GL_PATH_DASH_OFFSET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_DASH_OFFSET_NV = 0x907E;

		/// <summary>
		/// Value of GL_PATH_CLIENT_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_CLIENT_LENGTH_NV = 0x907F;

		/// <summary>
		/// Value of GL_PATH_FILL_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FILL_MODE_NV = 0x9080;

		/// <summary>
		/// Value of GL_PATH_FILL_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FILL_MASK_NV = 0x9081;

		/// <summary>
		/// Value of GL_PATH_FILL_COVER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FILL_COVER_MODE_NV = 0x9082;

		/// <summary>
		/// Value of GL_PATH_STROKE_COVER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STROKE_COVER_MODE_NV = 0x9083;

		/// <summary>
		/// Value of GL_PATH_STROKE_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STROKE_MASK_NV = 0x9084;

		/// <summary>
		/// Value of GL_COUNT_UP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int COUNT_UP_NV = 0x9088;

		/// <summary>
		/// Value of GL_COUNT_DOWN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int COUNT_DOWN_NV = 0x9089;

		/// <summary>
		/// Value of GL_PATH_OBJECT_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;

		/// <summary>
		/// Value of GL_CONVEX_HULL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CONVEX_HULL_NV = 0x908B;

		/// <summary>
		/// Value of GL_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int BOUNDING_BOX_NV = 0x908D;

		/// <summary>
		/// Value of GL_TRANSLATE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSLATE_X_NV = 0x908E;

		/// <summary>
		/// Value of GL_TRANSLATE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSLATE_Y_NV = 0x908F;

		/// <summary>
		/// Value of GL_TRANSLATE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSLATE_2D_NV = 0x9090;

		/// <summary>
		/// Value of GL_TRANSLATE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSLATE_3D_NV = 0x9091;

		/// <summary>
		/// Value of GL_AFFINE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int AFFINE_2D_NV = 0x9092;

		/// <summary>
		/// Value of GL_AFFINE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int AFFINE_3D_NV = 0x9094;

		/// <summary>
		/// Value of GL_TRANSPOSE_AFFINE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSPOSE_AFFINE_2D_NV = 0x9096;

		/// <summary>
		/// Value of GL_TRANSPOSE_AFFINE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRANSPOSE_AFFINE_3D_NV = 0x9098;

		/// <summary>
		/// Value of GL_UTF8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int UTF8_NV = 0x909A;

		/// <summary>
		/// Value of GL_UTF16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int UTF16_NV = 0x909B;

		/// <summary>
		/// Value of GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;

		/// <summary>
		/// Value of GL_PATH_COMMAND_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_COMMAND_COUNT_NV = 0x909D;

		/// <summary>
		/// Value of GL_PATH_COORD_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_COORD_COUNT_NV = 0x909E;

		/// <summary>
		/// Value of GL_PATH_DASH_ARRAY_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_DASH_ARRAY_COUNT_NV = 0x909F;

		/// <summary>
		/// Value of GL_PATH_COMPUTED_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_COMPUTED_LENGTH_NV = 0x90A0;

		/// <summary>
		/// Value of GL_PATH_FILL_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FILL_BOUNDING_BOX_NV = 0x90A1;

		/// <summary>
		/// Value of GL_PATH_STROKE_BOUNDING_BOX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;

		/// <summary>
		/// Value of GL_SQUARE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SQUARE_NV = 0x90A3;

		/// <summary>
		/// Value of GL_ROUND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ROUND_NV = 0x90A4;

		/// <summary>
		/// Value of GL_TRIANGULAR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int TRIANGULAR_NV = 0x90A5;

		/// <summary>
		/// Value of GL_BEVEL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int BEVEL_NV = 0x90A6;

		/// <summary>
		/// Value of GL_MITER_REVERT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int MITER_REVERT_NV = 0x90A7;

		/// <summary>
		/// Value of GL_MITER_TRUNCATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int MITER_TRUNCATE_NV = 0x90A8;

		/// <summary>
		/// Value of GL_SKIP_MISSING_GLYPH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SKIP_MISSING_GLYPH_NV = 0x90A9;

		/// <summary>
		/// Value of GL_USE_MISSING_GLYPH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int USE_MISSING_GLYPH_NV = 0x90AA;

		/// <summary>
		/// Value of GL_PATH_ERROR_POSITION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_ERROR_POSITION_NV = 0x90AB;

		/// <summary>
		/// Value of GL_ACCUM_ADJACENT_PAIRS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ACCUM_ADJACENT_PAIRS_NV = 0x90AD;

		/// <summary>
		/// Value of GL_ADJACENT_PAIRS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ADJACENT_PAIRS_NV = 0x90AE;

		/// <summary>
		/// Value of GL_FIRST_TO_REST_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FIRST_TO_REST_NV = 0x90AF;

		/// <summary>
		/// Value of GL_PATH_GEN_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_GEN_MODE_NV = 0x90B0;

		/// <summary>
		/// Value of GL_PATH_GEN_COEFF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_GEN_COEFF_NV = 0x90B1;

		/// <summary>
		/// Value of GL_PATH_GEN_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_GEN_COMPONENTS_NV = 0x90B3;

		/// <summary>
		/// Value of GL_PATH_STENCIL_FUNC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STENCIL_FUNC_NV = 0x90B7;

		/// <summary>
		/// Value of GL_PATH_STENCIL_REF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STENCIL_REF_NV = 0x90B8;

		/// <summary>
		/// Value of GL_PATH_STENCIL_VALUE_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STENCIL_VALUE_MASK_NV = 0x90B9;

		/// <summary>
		/// Value of GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;

		/// <summary>
		/// Value of GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;

		/// <summary>
		/// Value of GL_PATH_COVER_DEPTH_FUNC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_COVER_DEPTH_FUNC_NV = 0x90BF;

		/// <summary>
		/// Value of GL_PATH_DASH_OFFSET_RESET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_DASH_OFFSET_RESET_NV = 0x90B4;

		/// <summary>
		/// Value of GL_MOVE_TO_RESETS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int MOVE_TO_RESETS_NV = 0x90B5;

		/// <summary>
		/// Value of GL_MOVE_TO_CONTINUES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int MOVE_TO_CONTINUES_NV = 0x90B6;

		/// <summary>
		/// Value of GL_CLOSE_PATH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CLOSE_PATH_NV = 0x00;

		/// <summary>
		/// Value of GL_MOVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int MOVE_TO_NV = 0x02;

		/// <summary>
		/// Value of GL_RELATIVE_MOVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_MOVE_TO_NV = 0x03;

		/// <summary>
		/// Value of GL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int LINE_TO_NV = 0x04;

		/// <summary>
		/// Value of GL_RELATIVE_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_LINE_TO_NV = 0x05;

		/// <summary>
		/// Value of GL_HORIZONTAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int HORIZONTAL_LINE_TO_NV = 0x06;

		/// <summary>
		/// Value of GL_RELATIVE_HORIZONTAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;

		/// <summary>
		/// Value of GL_VERTICAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int VERTICAL_LINE_TO_NV = 0x08;

		/// <summary>
		/// Value of GL_RELATIVE_VERTICAL_LINE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_VERTICAL_LINE_TO_NV = 0x09;

		/// <summary>
		/// Value of GL_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int QUADRATIC_CURVE_TO_NV = 0x0A;

		/// <summary>
		/// Value of GL_RELATIVE_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;

		/// <summary>
		/// Value of GL_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CUBIC_CURVE_TO_NV = 0x0C;

		/// <summary>
		/// Value of GL_RELATIVE_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;

		/// <summary>
		/// Value of GL_SMOOTH_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;

		/// <summary>
		/// Value of GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;

		/// <summary>
		/// Value of GL_SMOOTH_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SMOOTH_CUBIC_CURVE_TO_NV = 0x10;

		/// <summary>
		/// Value of GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;

		/// <summary>
		/// Value of GL_SMALL_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SMALL_CCW_ARC_TO_NV = 0x12;

		/// <summary>
		/// Value of GL_RELATIVE_SMALL_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;

		/// <summary>
		/// Value of GL_SMALL_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int SMALL_CW_ARC_TO_NV = 0x14;

		/// <summary>
		/// Value of GL_RELATIVE_SMALL_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;

		/// <summary>
		/// Value of GL_LARGE_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int LARGE_CCW_ARC_TO_NV = 0x16;

		/// <summary>
		/// Value of GL_RELATIVE_LARGE_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;

		/// <summary>
		/// Value of GL_LARGE_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int LARGE_CW_ARC_TO_NV = 0x18;

		/// <summary>
		/// Value of GL_RELATIVE_LARGE_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;

		/// <summary>
		/// Value of GL_RESTART_PATH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RESTART_PATH_NV = 0xF0;

		/// <summary>
		/// Value of GL_DUP_FIRST_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;

		/// <summary>
		/// Value of GL_DUP_LAST_CUBIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;

		/// <summary>
		/// Value of GL_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RECT_NV = 0xF6;

		/// <summary>
		/// Value of GL_CIRCULAR_CCW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CIRCULAR_CCW_ARC_TO_NV = 0xF8;

		/// <summary>
		/// Value of GL_CIRCULAR_CW_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CIRCULAR_CW_ARC_TO_NV = 0xFA;

		/// <summary>
		/// Value of GL_CIRCULAR_TANGENT_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;

		/// <summary>
		/// Value of GL_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ARC_TO_NV = 0xFE;

		/// <summary>
		/// Value of GL_RELATIVE_ARC_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_ARC_TO_NV = 0xFF;

		/// <summary>
		/// Value of GL_BOLD_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int BOLD_BIT_NV = 0x01;

		/// <summary>
		/// Value of GL_ITALIC_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ITALIC_BIT_NV = 0x02;

		/// <summary>
		/// Value of GL_GLYPH_WIDTH_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_WIDTH_BIT_NV = 0x01;

		/// <summary>
		/// Value of GL_GLYPH_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_HEIGHT_BIT_NV = 0x02;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;

		/// <summary>
		/// Value of GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_X_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;

		/// <summary>
		/// Value of GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;

		/// <summary>
		/// Value of GL_GLYPH_HAS_KERNING_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int GLYPH_HAS_KERNING_BIT_NV = 0x100;

		/// <summary>
		/// Value of GL_FONT_X_MIN_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;

		/// <summary>
		/// Value of GL_FONT_Y_MIN_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;

		/// <summary>
		/// Value of GL_FONT_X_MAX_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;

		/// <summary>
		/// Value of GL_FONT_Y_MAX_BOUNDS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;

		/// <summary>
		/// Value of GL_FONT_UNITS_PER_EM_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_UNITS_PER_EM_BIT_NV = 0x00100000;

		/// <summary>
		/// Value of GL_FONT_ASCENDER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_ASCENDER_BIT_NV = 0x00200000;

		/// <summary>
		/// Value of GL_FONT_DESCENDER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_DESCENDER_BIT_NV = 0x00400000;

		/// <summary>
		/// Value of GL_FONT_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_HEIGHT_BIT_NV = 0x00800000;

		/// <summary>
		/// Value of GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;

		/// <summary>
		/// Value of GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;

		/// <summary>
		/// Value of GL_FONT_UNDERLINE_POSITION_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;

		/// <summary>
		/// Value of GL_FONT_UNDERLINE_THICKNESS_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;

		/// <summary>
		/// Value of GL_FONT_HAS_KERNING_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_HAS_KERNING_BIT_NV = 0x10000000;

		/// <summary>
		/// Value of GL_ROUNDED_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ROUNDED_RECT_NV = 0xE8;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_ROUNDED_RECT_NV = 0xE9;

		/// <summary>
		/// Value of GL_ROUNDED_RECT2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ROUNDED_RECT2_NV = 0xEA;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_ROUNDED_RECT2_NV = 0xEB;

		/// <summary>
		/// Value of GL_ROUNDED_RECT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ROUNDED_RECT4_NV = 0xEC;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_ROUNDED_RECT4_NV = 0xED;

		/// <summary>
		/// Value of GL_ROUNDED_RECT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int ROUNDED_RECT8_NV = 0xEE;

		/// <summary>
		/// Value of GL_RELATIVE_ROUNDED_RECT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_ROUNDED_RECT8_NV = 0xEF;

		/// <summary>
		/// Value of GL_RELATIVE_RECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_RECT_NV = 0xF7;

		/// <summary>
		/// Value of GL_FONT_GLYPHS_AVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FONT_GLYPHS_AVAILABLE_NV = 0x9368;

		/// <summary>
		/// Value of GL_FONT_TARGET_UNAVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FONT_TARGET_UNAVAILABLE_NV = 0x9369;

		/// <summary>
		/// Value of GL_FONT_UNAVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FONT_UNAVAILABLE_NV = 0x936A;

		/// <summary>
		/// Value of GL_FONT_UNINTELLIGIBLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FONT_UNINTELLIGIBLE_NV = 0x936B;

		/// <summary>
		/// Value of GL_CONIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CONIC_CURVE_TO_NV = 0x1A;

		/// <summary>
		/// Value of GL_RELATIVE_CONIC_CURVE_TO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int RELATIVE_CONIC_CURVE_TO_NV = 0x1B;

		/// <summary>
		/// Value of GL_FONT_NUM_GLYPH_INDICES_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const uint FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;

		/// <summary>
		/// Value of GL_STANDARD_FONT_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int STANDARD_FONT_FORMAT_NV = 0x936C;

		/// <summary>
		/// Value of GL_2_BYTES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int _2_BYTES_NV = 0x1407;

		/// <summary>
		/// Value of GL_3_BYTES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int _3_BYTES_NV = 0x1408;

		/// <summary>
		/// Value of GL_4_BYTES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int _4_BYTES_NV = 0x1409;

		/// <summary>
		/// Value of GL_EYE_LINEAR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int EYE_LINEAR_NV = 0x2400;

		/// <summary>
		/// Value of GL_OBJECT_LINEAR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int OBJECT_LINEAR_NV = 0x2401;

		/// <summary>
		/// Value of GL_CONSTANT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int CONSTANT_NV = 0x8576;

		/// <summary>
		/// Value of GL_PATH_FOG_GEN_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_FOG_GEN_MODE_NV = 0x90AC;

		/// <summary>
		/// Value of GL_PATH_GEN_COLOR_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_GEN_COLOR_FORMAT_NV = 0x90B2;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_PROJECTION_NV = 0x1701;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MODELVIEW_NV = 0x1700;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;

		/// <summary>
		/// Value of GL_PATH_MODELVIEW_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MODELVIEW_MATRIX_NV = 0x0BA6;

		/// <summary>
		/// Value of GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;

		/// <summary>
		/// Value of GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;

		/// <summary>
		/// Value of GL_PATH_PROJECTION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_PROJECTION_MATRIX_NV = 0x0BA7;

		/// <summary>
		/// Value of GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;

		/// <summary>
		/// Value of GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;

		/// <summary>
		/// Value of GL_FRAGMENT_INPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering")]
		public const int FRAGMENT_INPUT_NV = 0x936D;

		/// <summary>
		/// Binding for glGenPathsNV.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static UInt32 GenNV(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenPathsNV != null, "pglGenPathsNV not implemented");
			retValue = Delegates.pglGenPathsNV(range);
			CallLog("glGenPathsNV({0}) = {1}", range, retValue);
			DebugCheckErrors();

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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void DeleteNV(UInt32 path, Int32 range)
		{
			Debug.Assert(Delegates.pglDeletePathsNV != null, "pglDeletePathsNV not implemented");
			Delegates.pglDeletePathsNV(path, range);
			CallLog("glDeletePathsNV({0}, {1})", path, range);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static bool IsNV(UInt32 path)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPathNV != null, "pglIsPathNV not implemented");
			retValue = Delegates.pglIsPathNV(path);
			CallLog("glIsPathNV({0}) = {1}", path, retValue);
			DebugCheckErrors();

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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 path, Int32 numCommands, byte[] commands, Int32 numCoords, int coordType, IntPtr coords)
		{
			Debug.Assert(commands.Length >= numCommands);

			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglPathCommandsNV != null, "pglPathCommandsNV not implemented");
					Delegates.pglPathCommandsNV(path, numCommands, p_commands, numCoords, coordType, coords);
					CallLog("glPathCommandsNV({0}, {1}, {2}, {3}, {4}, {5})", path, numCommands, commands, numCoords, coordType, coords);
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 path, Int32 numCommands, byte[] commands, Int32 numCoords, int coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				NV(path, numCommands, commands, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathCoordsNV(UInt32 path, Int32 numCoords, int coordType, IntPtr coords)
		{
			Debug.Assert(Delegates.pglPathCoordsNV != null, "pglPathCoordsNV not implemented");
			Delegates.pglPathCoordsNV(path, numCoords, coordType, coords);
			CallLog("glPathCoordsNV({0}, {1}, {2}, {3})", path, numCoords, coordType, coords);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathCoordsNV(UInt32 path, Int32 numCoords, int coordType, Object coords)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte[] commands, Int32 numCoords, int coordType, IntPtr coords)
		{
			Debug.Assert(commands.Length >= numCommands);

			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglPathSubCommandsNV != null, "pglPathSubCommandsNV not implemented");
					Delegates.pglPathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, p_commands, numCoords, coordType, coords);
					CallLog("glPathSubCommandsNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte[] commands, Int32 numCoords, int coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, pin_coords.AddrOfPinnedObject());
			} finally {
				pin_coords.Free();
			}
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathSubCoordsNV(UInt32 path, Int32 coordStart, Int32 numCoords, int coordType, IntPtr coords)
		{
			Debug.Assert(Delegates.pglPathSubCoordsNV != null, "pglPathSubCoordsNV not implemented");
			Delegates.pglPathSubCoordsNV(path, coordStart, numCoords, coordType, coords);
			CallLog("glPathSubCoordsNV({0}, {1}, {2}, {3}, {4})", path, coordStart, numCoords, coordType, coords);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathSubCoordsNV(UInt32 path, Int32 coordStart, Int32 numCoords, int coordType, Object coords)
		{
			GCHandle pin_coords = GCHandle.Alloc(coords, GCHandleType.Pinned);
			try {
				PathSubCoordsNV(path, coordStart, numCoords, coordType, pin_coords.AddrOfPinnedObject());
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathString">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathStringNV(UInt32 path, int format, Int32 length, IntPtr pathString)
		{
			Debug.Assert(Delegates.pglPathStringNV != null, "pglPathStringNV not implemented");
			Delegates.pglPathStringNV(path, format, length, pathString);
			CallLog("glPathStringNV({0}, {1}, {2}, {3})", path, format, length, pathString);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathStringNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathString">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathStringNV(UInt32 path, int format, Int32 length, Object pathString)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="charcodes">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, Int32 numGlyphs, int type, IntPtr charcodes, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Debug.Assert(Delegates.pglPathGlyphsNV != null, "pglPathGlyphsNV not implemented");
			Delegates.pglPathGlyphsNV(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
			CallLog("glPathGlyphsNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathGlyphsNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="charcodes">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 firstPathName, int fontTarget, Object fontName, uint fontStyle, Int32 numGlyphs, int type, Object charcodes, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			GCHandle pin_fontName = GCHandle.Alloc(fontName, GCHandleType.Pinned);
			GCHandle pin_charcodes = GCHandle.Alloc(charcodes, GCHandleType.Pinned);
			try {
				NV(firstPathName, fontTarget, pin_fontName.AddrOfPinnedObject(), fontStyle, numGlyphs, type, pin_charcodes.AddrOfPinnedObject(), handleMissingGlyphs, pathParameterTemplate, emScale);
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="firstGlyph">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathGlyphRangeNV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, UInt32 firstGlyph, Int32 numGlyphs, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			Debug.Assert(Delegates.pglPathGlyphRangeNV != null, "pglPathGlyphRangeNV not implemented");
			Delegates.pglPathGlyphRangeNV(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
			CallLog("glPathGlyphRangeNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathGlyphRangeNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="firstGlyph">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numGlyphs">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="handleMissingGlyphs">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pathParameterTemplate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="emScale">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathGlyphRangeNV(UInt32 firstPathName, int fontTarget, Object fontName, uint fontStyle, UInt32 firstGlyph, Int32 numGlyphs, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale)
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
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void WeightNV(UInt32 resultPath, Int32 numPaths, UInt32[] paths, float[] weights)
		{
			Debug.Assert(paths.Length >= numPaths);
			Debug.Assert(weights.Length >= numPaths);

			unsafe {
				fixed (UInt32* p_paths = paths)
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightPathsNV != null, "pglWeightPathsNV not implemented");
					Delegates.pglWeightPathsNV(resultPath, numPaths, p_paths, p_weights);
					CallLog("glWeightPathsNV({0}, {1}, {2}, {3})", resultPath, numPaths, paths, weights);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CopyNV(UInt32 resultPath, UInt32 srcPath)
		{
			Debug.Assert(Delegates.pglCopyPathNV != null, "pglCopyPathNV not implemented");
			Delegates.pglCopyPathNV(resultPath, srcPath);
			CallLog("glCopyPathNV({0}, {1})", resultPath, srcPath);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 resultPath, UInt32 pathA, UInt32 pathB, float weight)
		{
			Debug.Assert(Delegates.pglInterpolatePathsNV != null, "pglInterpolatePathsNV not implemented");
			Delegates.pglInterpolatePathsNV(resultPath, pathA, pathB, weight);
			CallLog("glInterpolatePathsNV({0}, {1}, {2}, {3})", resultPath, pathA, pathB, weight);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void TransformNV(UInt32 resultPath, UInt32 srcPath, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglTransformPathNV != null, "pglTransformPathNV not implemented");
					Delegates.pglTransformPathNV(resultPath, srcPath, transformType, p_transformValues);
					CallLog("glTransformPathNV({0}, {1}, {2}, {3})", resultPath, srcPath, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathParameterivNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathParameterivNV(UInt32 path, int pname, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglPathParameterivNV != null, "pglPathParameterivNV not implemented");
					Delegates.pglPathParameterivNV(path, pname, p_value);
					CallLog("glPathParameterivNV({0}, {1}, {2})", path, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathParameteriNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathParameteriNV(UInt32 path, int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPathParameteriNV != null, "pglPathParameteriNV not implemented");
			Delegates.pglPathParameteriNV(path, pname, value);
			CallLog("glPathParameteriNV({0}, {1}, {2})", path, pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathParameterfvNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathParameterfvNV(UInt32 path, int pname, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglPathParameterfvNV != null, "pglPathParameterfvNV not implemented");
					Delegates.pglPathParameterfvNV(path, pname, p_value);
					CallLog("glPathParameterfvNV({0}, {1}, {2})", path, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathParameterfNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathParameterfNV(UInt32 path, int pname, float value)
		{
			Debug.Assert(Delegates.pglPathParameterfNV != null, "pglPathParameterfNV not implemented");
			Delegates.pglPathParameterfNV(path, pname, value);
			CallLog("glPathParameterfNV({0}, {1}, {2})", path, pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathDashArrayNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dashCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dashArray">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathDashArrayNV(UInt32 path, Int32 dashCount, float[] dashArray)
		{
			Debug.Assert(dashArray.Length >= dashCount);

			unsafe {
				fixed (float* p_dashArray = dashArray)
				{
					Debug.Assert(Delegates.pglPathDashArrayNV != null, "pglPathDashArrayNV not implemented");
					Delegates.pglPathDashArrayNV(path, dashCount, p_dashArray);
					CallLog("glPathDashArrayNV({0}, {1}, {2})", path, dashCount, dashArray);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathStencilFuncNV.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathStencilFuncNV(int func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglPathStencilFuncNV != null, "pglPathStencilFuncNV not implemented");
			Delegates.pglPathStencilFuncNV(func, @ref, mask);
			CallLog("glPathStencilFuncNV({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathStencilFuncNV.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathStencilFuncNV(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglPathStencilFuncNV != null, "pglPathStencilFuncNV not implemented");
			Delegates.pglPathStencilFuncNV((int)func, @ref, mask);
			CallLog("glPathStencilFuncNV({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathStencilDepthOffsetNV(float factor, float units)
		{
			Debug.Assert(Delegates.pglPathStencilDepthOffsetNV != null, "pglPathStencilDepthOffsetNV not implemented");
			Delegates.pglPathStencilDepthOffsetNV(factor, units);
			CallLog("glPathStencilDepthOffsetNV({0}, {1})", factor, units);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilFillNV(UInt32 path, int fillMode, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFillPathNV != null, "pglStencilFillPathNV not implemented");
			Delegates.pglStencilFillPathNV(path, fillMode, mask);
			CallLog("glStencilFillPathNV({0}, {1}, {2})", path, fillMode, mask);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilNV(UInt32 path, Int32 reference, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilStrokePathNV != null, "pglStencilStrokePathNV not implemented");
			Delegates.pglStencilStrokePathNV(path, reference, mask);
			CallLog("glStencilStrokePathNV({0}, {1}, {2})", path, reference, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int fillMode, UInt32 mask, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilFillPathInstancedNV != null, "pglStencilFillPathInstancedNV not implemented");
					Delegates.pglStencilFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, p_transformValues);
					CallLog("glStencilFillPathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilFillPathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, int fillMode, UInt32 mask, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilStrokePathInstancedNV != null, "pglStencilStrokePathInstancedNV not implemented");
					Delegates.pglStencilStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, p_transformValues);
					CallLog("glStencilStrokePathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilStrokePathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, Int32 reference, UInt32 mask, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathCoverDepthFuncNV(int func)
		{
			Debug.Assert(Delegates.pglPathCoverDepthFuncNV != null, "pglPathCoverDepthFuncNV not implemented");
			Delegates.pglPathCoverDepthFuncNV(func);
			CallLog("glPathCoverDepthFuncNV({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathCoverDepthFuncNV.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathCoverDepthFuncNV(DepthFunction func)
		{
			Debug.Assert(Delegates.pglPathCoverDepthFuncNV != null, "pglPathCoverDepthFuncNV not implemented");
			Delegates.pglPathCoverDepthFuncNV((int)func);
			CallLog("glPathCoverDepthFuncNV({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CoverFillPathNV(UInt32 path, int coverMode)
		{
			Debug.Assert(Delegates.pglCoverFillPathNV != null, "pglCoverFillPathNV not implemented");
			Delegates.pglCoverFillPathNV(path, coverMode);
			CallLog("glCoverFillPathNV({0}, {1})", path, coverMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverStrokePathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void NV(UInt32 path, int coverMode)
		{
			Debug.Assert(Delegates.pglCoverStrokePathNV != null, "pglCoverStrokePathNV not implemented");
			Delegates.pglCoverStrokePathNV(path, coverMode);
			CallLog("glCoverStrokePathNV({0}, {1})", path, coverMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CoverFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int coverMode, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglCoverFillPathInstancedNV != null, "pglCoverFillPathInstancedNV not implemented");
					Delegates.pglCoverFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, p_transformValues);
					CallLog("glCoverFillPathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CoverFillPathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, int coverMode, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int coverMode, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglCoverStrokePathInstancedNV != null, "pglCoverStrokePathInstancedNV not implemented");
					Delegates.pglCoverStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, p_transformValues);
					CallLog("glCoverStrokePathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void CoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, int coverMode, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathParameterivNV(UInt32 path, int pname, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathParameterivNV != null, "pglGetPathParameterivNV not implemented");
					Delegates.pglGetPathParameterivNV(path, pname, p_value);
					CallLog("glGetPathParameterivNV({0}, {1}, {2})", path, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathParameterfvNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathParameterfvNV(UInt32 path, int pname, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathParameterfvNV != null, "pglGetPathParameterfvNV not implemented");
					Delegates.pglGetPathParameterfvNV(path, pname, p_value);
					CallLog("glGetPathParameterfvNV({0}, {1}, {2})", path, pname, value);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetNV(UInt32 path, byte[] commands)
		{
			unsafe {
				fixed (byte* p_commands = commands)
				{
					Debug.Assert(Delegates.pglGetPathCommandsNV != null, "pglGetPathCommandsNV not implemented");
					Delegates.pglGetPathCommandsNV(path, p_commands);
					CallLog("glGetPathCommandsNV({0}, {1})", path, commands);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathCoordsNV(UInt32 path, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglGetPathCoordsNV != null, "pglGetPathCoordsNV not implemented");
					Delegates.pglGetPathCoordsNV(path, p_coords);
					CallLog("glGetPathCoordsNV({0}, {1})", path, coords);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathDashArrayNV(UInt32 path, float[] dashArray)
		{
			unsafe {
				fixed (float* p_dashArray = dashArray)
				{
					Debug.Assert(Delegates.pglGetPathDashArrayNV != null, "pglGetPathDashArrayNV not implemented");
					Delegates.pglGetPathDashArrayNV(path, p_dashArray);
					CallLog("glGetPathDashArrayNV({0}, {1})", path, dashArray);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathMetricsNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetNV(uint metricQueryMask, Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 stride, float[] metrics)
		{
			unsafe {
				fixed (float* p_metrics = metrics)
				{
					Debug.Assert(Delegates.pglGetPathMetricsNV != null, "pglGetPathMetricsNV not implemented");
					Delegates.pglGetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, p_metrics);
					CallLog("glGetPathMetricsNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathMetricsNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetNV(uint metricQueryMask, Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, Int32 stride, float[] metrics)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				GetNV(metricQueryMask, numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, stride, metrics);
			} finally {
				pin_paths.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPathMetricRangeNV.
		/// </summary>
		/// <param name="metricQueryMask">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathMetricRangeNV(uint metricQueryMask, UInt32 firstPathName, Int32 numPaths, Int32 stride, float[] metrics)
		{
			unsafe {
				fixed (float* p_metrics = metrics)
				{
					Debug.Assert(Delegates.pglGetPathMetricRangeNV != null, "pglGetPathMetricRangeNV not implemented");
					Delegates.pglGetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, p_metrics);
					CallLog("glGetPathMetricRangeNV({0}, {1}, {2}, {3}, {4})", metricQueryMask, firstPathName, numPaths, stride, metrics);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathSpacingNV.
		/// </summary>
		/// <param name="pathListMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="returnedSpacing">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetNV(int pathListMode, Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, float advanceScale, float kerningScale, int transformType, float[] returnedSpacing)
		{
			unsafe {
				fixed (float* p_returnedSpacing = returnedSpacing)
				{
					Debug.Assert(Delegates.pglGetPathSpacingNV != null, "pglGetPathSpacingNV not implemented");
					Delegates.pglGetPathSpacingNV(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, p_returnedSpacing);
					CallLog("glGetPathSpacingNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathSpacingNV.
		/// </summary>
		/// <param name="pathListMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="returnedSpacing">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetNV(int pathListMode, Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, float advanceScale, float kerningScale, int transformType, float[] returnedSpacing)
		{
			GCHandle pin_paths = GCHandle.Alloc(paths, GCHandleType.Pinned);
			try {
				GetNV(pathListMode, numPaths, pathNameType, pin_paths.AddrOfPinnedObject(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static bool IsPointInFillPathNV(UInt32 path, UInt32 mask, float x, float y)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPointInFillPathNV != null, "pglIsPointInFillPathNV not implemented");
			retValue = Delegates.pglIsPointInFillPathNV(path, mask, x, y);
			CallLog("glIsPointInFillPathNV({0}, {1}, {2}, {3}) = {4}", path, mask, x, y, retValue);
			DebugCheckErrors();

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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static bool IsPointNV(UInt32 path, float x, float y)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsPointInStrokePathNV != null, "pglIsPointInStrokePathNV not implemented");
			retValue = Delegates.pglIsPointInStrokePathNV(path, x, y);
			CallLog("glIsPointInStrokePathNV({0}, {1}, {2}) = {3}", path, x, y, retValue);
			DebugCheckErrors();

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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static float GetNV(UInt32 path, Int32 startSegment, Int32 numSegments)
		{
			float retValue;

			Debug.Assert(Delegates.pglGetPathLengthNV != null, "pglGetPathLengthNV not implemented");
			retValue = Delegates.pglGetPathLengthNV(path, startSegment, numSegments);
			CallLog("glGetPathLengthNV({0}, {1}, {2}) = {3}", path, startSegment, numSegments, retValue);
			DebugCheckErrors();

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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static bool PointNV(UInt32 path, Int32 startSegment, Int32 numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY)
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
					CallLog("glPointAlongPathNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", path, startSegment, numSegments, distance, x, y, tangentX, tangentY, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMatrixLoad3x2fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixLoad3x2NV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoad3x2fNV != null, "pglMatrixLoad3x2fNV not implemented");
					Delegates.pglMatrixLoad3x2fNV(matrixMode, p_m);
					CallLog("glMatrixLoad3x2fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixLoad3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixLoad3NV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoad3x3fNV != null, "pglMatrixLoad3x3fNV not implemented");
					Delegates.pglMatrixLoad3x3fNV(matrixMode, p_m);
					CallLog("glMatrixLoad3x3fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixLoadTranspose3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixLoadTransposeNV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoadTranspose3x3fNV != null, "pglMatrixLoadTranspose3x3fNV not implemented");
					Delegates.pglMatrixLoadTranspose3x3fNV(matrixMode, p_m);
					CallLog("glMatrixLoadTranspose3x3fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixMult3x2fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixMult3x2NV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMult3x2fNV != null, "pglMatrixMult3x2fNV not implemented");
					Delegates.pglMatrixMult3x2fNV(matrixMode, p_m);
					CallLog("glMatrixMult3x2fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixMult3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixMult3x3NV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMult3x3fNV != null, "pglMatrixMult3x3fNV not implemented");
					Delegates.pglMatrixMult3x3fNV(matrixMode, p_m);
					CallLog("glMatrixMult3x3fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixMultTranspose3x3fNV.
		/// </summary>
		/// <param name="matrixMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void MatrixMultTransposeNV(int matrixMode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultTranspose3x3fNV != null, "pglMatrixMultTranspose3x3fNV not implemented");
					Delegates.pglMatrixMultTranspose3x3fNV(matrixMode, p_m);
					CallLog("glMatrixMultTranspose3x3fNV({0}, {1})", matrixMode, m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathNV.
		/// </summary>
		/// <param name="path">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilThenCoverFillPathNV(UInt32 path, int fillMode, UInt32 mask, int coverMode)
		{
			Debug.Assert(Delegates.pglStencilThenCoverFillPathNV != null, "pglStencilThenCoverFillPathNV not implemented");
			Delegates.pglStencilThenCoverFillPathNV(path, fillMode, mask, coverMode);
			CallLog("glStencilThenCoverFillPathNV({0}, {1}, {2}, {3})", path, fillMode, mask, coverMode);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilNV(UInt32 path, Int32 reference, UInt32 mask, int coverMode)
		{
			Debug.Assert(Delegates.pglStencilThenCoverStrokePathNV != null, "pglStencilThenCoverStrokePathNV not implemented");
			Delegates.pglStencilThenCoverStrokePathNV(path, reference, mask, coverMode);
			CallLog("glStencilThenCoverStrokePathNV({0}, {1}, {2}, {3})", path, reference, mask, coverMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilThenCoverFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int fillMode, UInt32 mask, int coverMode, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilThenCoverFillPathInstancedNV != null, "pglStencilThenCoverFillPathInstancedNV not implemented");
					Delegates.pglStencilThenCoverFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, p_transformValues);
					CallLog("glStencilThenCoverFillPathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilThenCoverFillPathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="paths">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pathBase">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fillMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilThenCoverFillPathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, int fillMode, UInt32 mask, int coverMode, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilThenCoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, int coverMode, int transformType, float[] transformValues)
		{
			unsafe {
				fixed (float* p_transformValues = transformValues)
				{
					Debug.Assert(Delegates.pglStencilThenCoverStrokePathInstancedNV != null, "pglStencilThenCoverStrokePathInstancedNV not implemented");
					Delegates.pglStencilThenCoverStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, p_transformValues);
					CallLog("glStencilThenCoverStrokePathInstancedNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilThenCoverStrokePathInstancedNV.
		/// </summary>
		/// <param name="numPaths">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pathNameType">
		/// A <see cref="T:int"/>.
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="transformValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void StencilThenCoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, Object paths, UInt32 pathBase, Int32 reference, UInt32 mask, int coverMode, int transformType, float[] transformValues)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathGlyphIndexRangeNV(int fontTarget, IntPtr fontName, uint fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32[] baseAndCount)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_baseAndCount = baseAndCount)
				{
					Debug.Assert(Delegates.pglPathGlyphIndexRangeNV != null, "pglPathGlyphIndexRangeNV not implemented");
					retValue = Delegates.pglPathGlyphIndexRangeNV(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, p_baseAndCount);
					CallLog("glPathGlyphIndexRangeNV({0}, {1}, {2}, {3}, {4}, {5}) = {6}", fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathGlyphIndexRangeNV.
		/// </summary>
		/// <param name="fontTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathGlyphIndexRangeNV(int fontTarget, Object fontName, uint fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32[] baseAndCount)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			int retValue;

			Debug.Assert(Delegates.pglPathGlyphIndexArrayNV != null, "pglPathGlyphIndexArrayNV not implemented");
			retValue = Delegates.pglPathGlyphIndexArrayNV(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
			CallLog("glPathGlyphIndexArrayNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="fontName">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fontStyle">
		/// A <see cref="T:uint"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, Object fontName, uint fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
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
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathMemoryGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, UInt32 fontSize, IntPtr fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
		{
			int retValue;

			Debug.Assert(Delegates.pglPathMemoryGlyphIndexArrayNV != null, "pglPathMemoryGlyphIndexArrayNV not implemented");
			retValue = Delegates.pglPathMemoryGlyphIndexArrayNV(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
			CallLog("glPathMemoryGlyphIndexArrayNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}) = {9}", firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPathMemoryGlyphIndexArrayNV.
		/// </summary>
		/// <param name="firstPathName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fontTarget">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static int PathMemoryGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, UInt32 fontSize, Object fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale)
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="components">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void ProgramPathFragmentInputGenNV(UInt32 program, Int32 location, int genMode, Int32 components, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglProgramPathFragmentInputGenNV != null, "pglProgramPathFragmentInputGenNV not implemented");
					Delegates.pglProgramPathFragmentInputGenNV(program, location, genMode, components, p_coeffs);
					CallLog("glProgramPathFragmentInputGenNV({0}, {1}, {2}, {3}, {4})", program, location, genMode, components, coeffs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramResourcefvNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="programInterface">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="propCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="props">
		/// A <see cref="T:int[]"/>.
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
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetProgramNV(UInt32 program, int programInterface, UInt32 index, Int32 propCount, int[] props, Int32 bufSize, Int32[] length, float[] @params)
		{
			unsafe {
				fixed (int* p_props = props)
				fixed (Int32* p_length = length)
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramResourcefvNV != null, "pglGetProgramResourcefvNV not implemented");
					Delegates.pglGetProgramResourcefvNV(program, programInterface, index, propCount, p_props, bufSize, p_length, p_params);
					CallLog("glGetProgramResourcefvNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", program, programInterface, index, propCount, props, bufSize, length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathColorGenNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="genMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="colorFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathColorGenNV(int color, int genMode, int colorFormat, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglPathColorGenNV != null, "pglPathColorGenNV not implemented");
					Delegates.pglPathColorGenNV(color, genMode, colorFormat, p_coeffs);
					CallLog("glPathColorGenNV({0}, {1}, {2}, {3})", color, genMode, colorFormat, coeffs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathTexGenNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="genMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="components">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coeffs">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathTexGenNV(int texCoordSet, int genMode, Int32 components, float[] coeffs)
		{
			unsafe {
				fixed (float* p_coeffs = coeffs)
				{
					Debug.Assert(Delegates.pglPathTexGenNV != null, "pglPathTexGenNV not implemented");
					Delegates.pglPathTexGenNV(texCoordSet, genMode, components, p_coeffs);
					CallLog("glPathTexGenNV({0}, {1}, {2}, {3})", texCoordSet, genMode, components, coeffs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPathFogGenNV.
		/// </summary>
		/// <param name="genMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void PathFogGenNV(int genMode)
		{
			Debug.Assert(Delegates.pglPathFogGenNV != null, "pglPathFogGenNV not implemented");
			Delegates.pglPathFogGenNV(genMode);
			CallLog("glPathFogGenNV({0})", genMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathColorGenivNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathColorGenivNV(int color, int pname, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathColorGenivNV != null, "pglGetPathColorGenivNV not implemented");
					Delegates.pglGetPathColorGenivNV(color, pname, p_value);
					CallLog("glGetPathColorGenivNV({0}, {1}, {2})", color, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathColorGenfvNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathColorGenfvNV(int color, int pname, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathColorGenfvNV != null, "pglGetPathColorGenfvNV not implemented");
					Delegates.pglGetPathColorGenfvNV(color, pname, p_value);
					CallLog("glGetPathColorGenfvNV({0}, {1}, {2})", color, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathTexGenivNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathTexGenivNV(int texCoordSet, int pname, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathTexGenivNV != null, "pglGetPathTexGenivNV not implemented");
					Delegates.pglGetPathTexGenivNV(texCoordSet, pname, p_value);
					CallLog("glGetPathTexGenivNV({0}, {1}, {2})", texCoordSet, pname, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPathTexGenfvNV.
		/// </summary>
		/// <param name="texCoordSet">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_path_rendering")]
		public static void GetPathTexGenfvNV(int texCoordSet, int pname, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglGetPathTexGenfvNV != null, "pglGetPathTexGenfvNV not implemented");
					Delegates.pglGetPathTexGenfvNV(texCoordSet, pname, p_value);
					CallLog("glGetPathTexGenfvNV({0}, {1}, {2})", texCoordSet, pname, value);
				}
			}
			DebugCheckErrors();
		}

	}

}
