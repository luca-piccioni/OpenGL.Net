
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
		/// Value of GL_DEPTH_BUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const uint DEPTH_BUFFER_BIT = 0x00000100;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const uint STENCIL_BUFFER_BIT = 0x00000400;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const uint COLOR_BUFFER_BIT = 0x00004000;

		/// <summary>
		/// Value of GL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FALSE = 0;

		/// <summary>
		/// Value of GL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TRUE = 1;

		/// <summary>
		/// Value of GL_POINTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int POINTS = 0x0000;

		/// <summary>
		/// Value of GL_LINES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINES = 0x0001;

		/// <summary>
		/// Value of GL_LINE_LOOP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINE_LOOP = 0x0002;

		/// <summary>
		/// Value of GL_LINE_STRIP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINE_STRIP = 0x0003;

		/// <summary>
		/// Value of GL_TRIANGLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RequiredByFeature("GL_EXT_tessellation_shader")]
		[RequiredByFeature("GL_OES_tessellation_shader")]
		public const int TRIANGLES = 0x0004;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TRIANGLE_STRIP = 0x0005;

		/// <summary>
		/// Value of GL_TRIANGLE_FAN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TRIANGLE_FAN = 0x0006;

		/// <summary>
		/// Value of GL_QUADS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int QUADS = 0x0007;

		/// <summary>
		/// Value of GL_NEVER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NEVER = 0x0200;

		/// <summary>
		/// Value of GL_LESS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LESS = 0x0201;

		/// <summary>
		/// Value of GL_EQUAL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RequiredByFeature("GL_EXT_tessellation_shader")]
		[RequiredByFeature("GL_OES_tessellation_shader")]
		public const int EQUAL = 0x0202;

		/// <summary>
		/// Value of GL_LEQUAL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LEQUAL = 0x0203;

		/// <summary>
		/// Value of GL_GREATER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int GREATER = 0x0204;

		/// <summary>
		/// Value of GL_NOTEQUAL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NOTEQUAL = 0x0205;

		/// <summary>
		/// Value of GL_GEQUAL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int GEQUAL = 0x0206;

		/// <summary>
		/// Value of GL_ALWAYS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ALWAYS = 0x0207;

		/// <summary>
		/// Value of GL_ZERO symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ZERO = 0;

		/// <summary>
		/// Value of GL_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ONE = 1;

		/// <summary>
		/// Value of GL_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int SRC_COLOR = 0x0300;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ONE_MINUS_SRC_COLOR = 0x0301;

		/// <summary>
		/// Value of GL_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int SRC_ALPHA = 0x0302;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ONE_MINUS_SRC_ALPHA = 0x0303;

		/// <summary>
		/// Value of GL_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int DST_ALPHA = 0x0304;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ONE_MINUS_DST_ALPHA = 0x0305;

		/// <summary>
		/// Value of GL_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int DST_COLOR = 0x0306;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int ONE_MINUS_DST_COLOR = 0x0307;

		/// <summary>
		/// Value of GL_SRC_ALPHA_SATURATE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int SRC_ALPHA_SATURATE = 0x0308;

		/// <summary>
		/// Value of GL_NONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_KHR_context_flush_control")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int NONE = 0;

		/// <summary>
		/// Value of GL_FRONT_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_LEFT = 0x0400;

		/// <summary>
		/// Value of GL_FRONT_RIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_RIGHT = 0x0401;

		/// <summary>
		/// Value of GL_BACK_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BACK_LEFT = 0x0402;

		/// <summary>
		/// Value of GL_BACK_RIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BACK_RIGHT = 0x0403;

		/// <summary>
		/// Value of GL_FRONT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FRONT = 0x0404;

		/// <summary>
		/// Value of GL_BACK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility")]
		public const int BACK = 0x0405;

		/// <summary>
		/// Value of GL_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LEFT = 0x0406;

		/// <summary>
		/// Value of GL_RIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RIGHT = 0x0407;

		/// <summary>
		/// Value of GL_FRONT_AND_BACK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FRONT_AND_BACK = 0x0408;

		/// <summary>
		/// Value of GL_NO_ERROR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_robustness")]
		[RequiredByFeature("GL_EXT_robustness")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int NO_ERROR = 0;

		/// <summary>
		/// Value of GL_INVALID_ENUM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INVALID_ENUM = 0x0500;

		/// <summary>
		/// Value of GL_INVALID_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INVALID_VALUE = 0x0501;

		/// <summary>
		/// Value of GL_INVALID_OPERATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INVALID_OPERATION = 0x0502;

		/// <summary>
		/// Value of GL_OUT_OF_MEMORY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int OUT_OF_MEMORY = 0x0505;

		/// <summary>
		/// Value of GL_CW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RequiredByFeature("GL_EXT_tessellation_shader")]
		[RequiredByFeature("GL_OES_tessellation_shader")]
		public const int CW = 0x0900;

		/// <summary>
		/// Value of GL_CCW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		[RequiredByFeature("GL_EXT_tessellation_shader")]
		[RequiredByFeature("GL_OES_tessellation_shader")]
		public const int CCW = 0x0901;

		/// <summary>
		/// Value of GL_POINT_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int POINT_SIZE = 0x0B11;

		/// <summary>
		/// Value of GL_POINT_SIZE_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT_SIZE_RANGE = 0x0B12;

		/// <summary>
		/// Value of GL_POINT_SIZE_GRANULARITY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT_SIZE_GRANULARITY = 0x0B13;

		/// <summary>
		/// Value of GL_LINE_SMOOTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int LINE_SMOOTH = 0x0B20;

		/// <summary>
		/// Value of GL_LINE_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINE_WIDTH = 0x0B21;

		/// <summary>
		/// Value of GL_LINE_WIDTH_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_WIDTH_RANGE = 0x0B22;

		/// <summary>
		/// Value of GL_LINE_WIDTH_GRANULARITY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_WIDTH_GRANULARITY = 0x0B23;

		/// <summary>
		/// Value of GL_POLYGON_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_MODE = 0x0B40;

		/// <summary>
		/// Value of GL_POLYGON_SMOOTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_SMOOTH = 0x0B41;

		/// <summary>
		/// Value of GL_CULL_FACE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int CULL_FACE = 0x0B44;

		/// <summary>
		/// Value of GL_CULL_FACE_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int CULL_FACE_MODE = 0x0B45;

		/// <summary>
		/// Value of GL_FRONT_FACE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FRONT_FACE = 0x0B46;

		/// <summary>
		/// Value of GL_DEPTH_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_NV_viewport_array")]
		public const int DEPTH_RANGE = 0x0B70;

		/// <summary>
		/// Value of GL_DEPTH_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DEPTH_TEST = 0x0B71;

		/// <summary>
		/// Value of GL_DEPTH_WRITEMASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DEPTH_WRITEMASK = 0x0B72;

		/// <summary>
		/// Value of GL_DEPTH_CLEAR_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DEPTH_CLEAR_VALUE = 0x0B73;

		/// <summary>
		/// Value of GL_DEPTH_FUNC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DEPTH_FUNC = 0x0B74;

		/// <summary>
		/// Value of GL_STENCIL_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_TEST = 0x0B90;

		/// <summary>
		/// Value of GL_STENCIL_CLEAR_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_CLEAR_VALUE = 0x0B91;

		/// <summary>
		/// Value of GL_STENCIL_FUNC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_FUNC = 0x0B92;

		/// <summary>
		/// Value of GL_STENCIL_VALUE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_VALUE_MASK = 0x0B93;

		/// <summary>
		/// Value of GL_STENCIL_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_FAIL = 0x0B94;

		/// <summary>
		/// Value of GL_STENCIL_PASS_DEPTH_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;

		/// <summary>
		/// Value of GL_STENCIL_PASS_DEPTH_PASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;

		/// <summary>
		/// Value of GL_STENCIL_REF symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_REF = 0x0B97;

		/// <summary>
		/// Value of GL_STENCIL_WRITEMASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_WRITEMASK = 0x0B98;

		/// <summary>
		/// Value of GL_VIEWPORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_NV_viewport_array")]
		public const int VIEWPORT = 0x0BA2;

		/// <summary>
		/// Value of GL_DITHER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DITHER = 0x0BD0;

		/// <summary>
		/// Value of GL_BLEND_DST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int BLEND_DST = 0x0BE0;

		/// <summary>
		/// Value of GL_BLEND_SRC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int BLEND_SRC = 0x0BE1;

		/// <summary>
		/// Value of GL_BLEND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int BLEND = 0x0BE2;

		/// <summary>
		/// Value of GL_LOGIC_OP_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int LOGIC_OP_MODE = 0x0BF0;

		/// <summary>
		/// Value of GL_COLOR_LOGIC_OP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int COLOR_LOGIC_OP = 0x0BF2;

		/// <summary>
		/// Value of GL_DRAW_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DRAW_BUFFER = 0x0C01;

		/// <summary>
		/// Value of GL_READ_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int READ_BUFFER = 0x0C02;

		/// <summary>
		/// Value of GL_SCISSOR_BOX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_NV_viewport_array")]
		public const int SCISSOR_BOX = 0x0C10;

		/// <summary>
		/// Value of GL_SCISSOR_TEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		[RequiredByFeature("GL_NV_viewport_array")]
		public const int SCISSOR_TEST = 0x0C11;

		/// <summary>
		/// Value of GL_COLOR_CLEAR_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int COLOR_CLEAR_VALUE = 0x0C22;

		/// <summary>
		/// Value of GL_COLOR_WRITEMASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int COLOR_WRITEMASK = 0x0C23;

		/// <summary>
		/// Value of GL_DOUBLEBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DOUBLEBUFFER = 0x0C32;

		/// <summary>
		/// Value of GL_STEREO symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STEREO = 0x0C33;

		/// <summary>
		/// Value of GL_LINE_SMOOTH_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int LINE_SMOOTH_HINT = 0x0C52;

		/// <summary>
		/// Value of GL_POLYGON_SMOOTH_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_SMOOTH_HINT = 0x0C53;

		/// <summary>
		/// Value of GL_UNPACK_SWAP_BYTES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_SWAP_BYTES = 0x0CF0;

		/// <summary>
		/// Value of GL_UNPACK_LSB_FIRST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_LSB_FIRST = 0x0CF1;

		/// <summary>
		/// Value of GL_UNPACK_ROW_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNPACK_ROW_LENGTH = 0x0CF2;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_ROWS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNPACK_SKIP_ROWS = 0x0CF3;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_PIXELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNPACK_SKIP_PIXELS = 0x0CF4;

		/// <summary>
		/// Value of GL_UNPACK_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int UNPACK_ALIGNMENT = 0x0CF5;

		/// <summary>
		/// Value of GL_PACK_SWAP_BYTES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_SWAP_BYTES = 0x0D00;

		/// <summary>
		/// Value of GL_PACK_LSB_FIRST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_LSB_FIRST = 0x0D01;

		/// <summary>
		/// Value of GL_PACK_ROW_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int PACK_ROW_LENGTH = 0x0D02;

		/// <summary>
		/// Value of GL_PACK_SKIP_ROWS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int PACK_SKIP_ROWS = 0x0D03;

		/// <summary>
		/// Value of GL_PACK_SKIP_PIXELS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int PACK_SKIP_PIXELS = 0x0D04;

		/// <summary>
		/// Value of GL_PACK_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int PACK_ALIGNMENT = 0x0D05;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_TEXTURE_SIZE = 0x0D33;

		/// <summary>
		/// Value of GL_MAX_VIEWPORT_DIMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_VIEWPORT_DIMS = 0x0D3A;

		/// <summary>
		/// Value of GL_SUBPIXEL_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SUBPIXEL_BITS = 0x0D50;

		/// <summary>
		/// Value of GL_TEXTURE_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_1D = 0x0DE0;

		/// <summary>
		/// Value of GL_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_2D = 0x0DE1;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int POLYGON_OFFSET_UNITS = 0x2A00;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_POINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_POINT = 0x2A01;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_LINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_LINE = 0x2A02;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_FILL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int POLYGON_OFFSET_FILL = 0x8037;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_FACTOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int POLYGON_OFFSET_FACTOR = 0x8038;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_1D = 0x8068;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_2D = 0x8069;

		/// <summary>
		/// Value of GL_TEXTURE_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_WIDTH = 0x1000;

		/// <summary>
		/// Value of GL_TEXTURE_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_HEIGHT = 0x1001;

		/// <summary>
		/// Value of GL_TEXTURE_INTERNAL_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_INTERNAL_FORMAT = 0x1003;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_BORDER_COLOR = 0x1004;

		/// <summary>
		/// Value of GL_TEXTURE_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_RED_SIZE = 0x805C;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_GREEN_SIZE = 0x805D;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_BLUE_SIZE = 0x805E;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_ALPHA_SIZE = 0x805F;

		/// <summary>
		/// Value of GL_DONT_CARE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DONT_CARE = 0x1100;

		/// <summary>
		/// Value of GL_FASTEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FASTEST = 0x1101;

		/// <summary>
		/// Value of GL_NICEST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NICEST = 0x1102;

		/// <summary>
		/// Value of GL_BYTE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_render_snorm")]
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public const int BYTE = 0x1400;

		/// <summary>
		/// Value of GL_UNSIGNED_BYTE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int UNSIGNED_BYTE = 0x1401;

		/// <summary>
		/// Value of GL_SHORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_render_snorm")]
		public const int SHORT = 0x1402;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ANGLE_depth_texture")]
		[RequiredByFeature("GL_OES_depth_texture")]
		public const int UNSIGNED_SHORT = 0x1403;

		/// <summary>
		/// Value of GL_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INT = 0x1404;

		/// <summary>
		/// Value of GL_UNSIGNED_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ANGLE_depth_texture")]
		[RequiredByFeature("GL_OES_depth_texture")]
		[RequiredByFeature("GL_OES_element_index_uint")]
		public const int UNSIGNED_INT = 0x1405;

		/// <summary>
		/// Value of GL_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float")]
		public const int FLOAT = 0x1406;

		/// <summary>
		/// Value of GL_DOUBLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE = 0x140A;

		/// <summary>
		/// Value of GL_STACK_OVERFLOW symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int STACK_OVERFLOW = 0x0503;

		/// <summary>
		/// Value of GL_STACK_UNDERFLOW symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int STACK_UNDERFLOW = 0x0504;

		/// <summary>
		/// Value of GL_CLEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int CLEAR = 0x1500;

		/// <summary>
		/// Value of GL_AND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int AND = 0x1501;

		/// <summary>
		/// Value of GL_AND_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int AND_REVERSE = 0x1502;

		/// <summary>
		/// Value of GL_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int COPY = 0x1503;

		/// <summary>
		/// Value of GL_AND_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int AND_INVERTED = 0x1504;

		/// <summary>
		/// Value of GL_NOOP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int NOOP = 0x1505;

		/// <summary>
		/// Value of GL_XOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int XOR = 0x1506;

		/// <summary>
		/// Value of GL_OR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int OR = 0x1507;

		/// <summary>
		/// Value of GL_NOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int NOR = 0x1508;

		/// <summary>
		/// Value of GL_EQUIV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int EQUIV = 0x1509;

		/// <summary>
		/// Value of GL_INVERT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int INVERT = 0x150A;

		/// <summary>
		/// Value of GL_OR_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int OR_REVERSE = 0x150B;

		/// <summary>
		/// Value of GL_COPY_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int COPY_INVERTED = 0x150C;

		/// <summary>
		/// Value of GL_OR_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int OR_INVERTED = 0x150D;

		/// <summary>
		/// Value of GL_NAND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int NAND = 0x150E;

		/// <summary>
		/// Value of GL_SET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int SET = 0x150F;

		/// <summary>
		/// Value of GL_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE = 0x1702;

		/// <summary>
		/// Value of GL_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int COLOR = 0x1800;

		/// <summary>
		/// Value of GL_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DEPTH = 0x1801;

		/// <summary>
		/// Value of GL_STENCIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int STENCIL = 0x1802;

		/// <summary>
		/// Value of GL_STENCIL_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_stencil8")]
		public const int STENCIL_INDEX = 0x1901;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ANGLE_depth_texture")]
		[RequiredByFeature("GL_OES_depth_texture")]
		public const int DEPTH_COMPONENT = 0x1902;

		/// <summary>
		/// Value of GL_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int RED = 0x1903;

		/// <summary>
		/// Value of GL_GREEN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int GREEN = 0x1904;

		/// <summary>
		/// Value of GL_BLUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int BLUE = 0x1905;

		/// <summary>
		/// Value of GL_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int ALPHA = 0x1906;

		/// <summary>
		/// Value of GL_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int RGB = 0x1907;

		/// <summary>
		/// Value of GL_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int RGBA = 0x1908;

		/// <summary>
		/// Value of GL_POINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT = 0x1B00;

		/// <summary>
		/// Value of GL_LINE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE = 0x1B01;

		/// <summary>
		/// Value of GL_FILL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FILL = 0x1B02;

		/// <summary>
		/// Value of GL_KEEP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int KEEP = 0x1E00;

		/// <summary>
		/// Value of GL_REPLACE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int REPLACE = 0x1E01;

		/// <summary>
		/// Value of GL_INCR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INCR = 0x1E02;

		/// <summary>
		/// Value of GL_DECR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DECR = 0x1E03;

		/// <summary>
		/// Value of GL_VENDOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VENDOR = 0x1F00;

		/// <summary>
		/// Value of GL_RENDERER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int RENDERER = 0x1F01;

		/// <summary>
		/// Value of GL_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERSION = 0x1F02;

		/// <summary>
		/// Value of GL_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int EXTENSIONS = 0x1F03;

		/// <summary>
		/// Value of GL_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NEAREST = 0x2600;

		/// <summary>
		/// Value of GL_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINEAR = 0x2601;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NEAREST_MIPMAP_NEAREST = 0x2700;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINEAR_MIPMAP_NEAREST = 0x2701;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NEAREST_MIPMAP_LINEAR = 0x2702;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINEAR_MIPMAP_LINEAR = 0x2703;

		/// <summary>
		/// Value of GL_TEXTURE_MAG_FILTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_MAG_FILTER = 0x2800;

		/// <summary>
		/// Value of GL_TEXTURE_MIN_FILTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_MIN_FILTER = 0x2801;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_S symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_WRAP_S = 0x2802;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_T symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_WRAP_T = 0x2803;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PROXY_TEXTURE_1D = 0x8063;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PROXY_TEXTURE_2D = 0x8064;

		/// <summary>
		/// Value of GL_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int REPEAT = 0x2901;

		/// <summary>
		/// Value of GL_R3_G3_B2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int R3_G3_B2 = 0x2A10;

		/// <summary>
		/// Value of GL_RGB4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB4 = 0x804F;

		/// <summary>
		/// Value of GL_RGB5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB5 = 0x8050;

		/// <summary>
		/// Value of GL_RGB8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB8 = 0x8051;

		/// <summary>
		/// Value of GL_RGB10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB10 = 0x8052;

		/// <summary>
		/// Value of GL_RGB12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB12 = 0x8053;

		/// <summary>
		/// Value of GL_RGB16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB16 = 0x8054;

		/// <summary>
		/// Value of GL_RGBA2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGBA2 = 0x8055;

		/// <summary>
		/// Value of GL_RGBA4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int RGBA4 = 0x8056;

		/// <summary>
		/// Value of GL_RGB5_A1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int RGB5_A1 = 0x8057;

		/// <summary>
		/// Value of GL_RGBA8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA8 = 0x8058;

		/// <summary>
		/// Value of GL_RGB10_A2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB10_A2 = 0x8059;

		/// <summary>
		/// Value of GL_RGBA12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGBA12 = 0x805A;

		/// <summary>
		/// Value of GL_RGBA16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGBA16 = 0x805B;

		/// <summary>
		/// Value of GL_CURRENT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint CURRENT_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_POINT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint POINT_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_LINE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint LINE_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_POLYGON_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint POLYGON_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_POLYGON_STIPPLE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint POLYGON_STIPPLE_BIT = 0x00000010;

		/// <summary>
		/// Value of GL_PIXEL_MODE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint PIXEL_MODE_BIT = 0x00000020;

		/// <summary>
		/// Value of GL_LIGHTING_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint LIGHTING_BIT = 0x00000040;

		/// <summary>
		/// Value of GL_FOG_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint FOG_BIT = 0x00000080;

		/// <summary>
		/// Value of GL_ACCUM_BUFFER_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint ACCUM_BUFFER_BIT = 0x00000200;

		/// <summary>
		/// Value of GL_VIEWPORT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint VIEWPORT_BIT = 0x00000800;

		/// <summary>
		/// Value of GL_TRANSFORM_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint TRANSFORM_BIT = 0x00001000;

		/// <summary>
		/// Value of GL_ENABLE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint ENABLE_BIT = 0x00002000;

		/// <summary>
		/// Value of GL_HINT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint HINT_BIT = 0x00008000;

		/// <summary>
		/// Value of GL_EVAL_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint EVAL_BIT = 0x00010000;

		/// <summary>
		/// Value of GL_LIST_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint LIST_BIT = 0x00020000;

		/// <summary>
		/// Value of GL_TEXTURE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint TEXTURE_BIT = 0x00040000;

		/// <summary>
		/// Value of GL_SCISSOR_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint SCISSOR_BIT = 0x00080000;

		/// <summary>
		/// Value of GL_ALL_ATTRIB_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint ALL_ATTRIB_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_CLIENT_PIXEL_STORE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint CLIENT_PIXEL_STORE_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_CLIENT_VERTEX_ARRAY_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint CLIENT_VERTEX_ARRAY_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_CLIENT_ALL_ATTRIB_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_QUAD_STRIP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int QUAD_STRIP = 0x0008;

		/// <summary>
		/// Value of GL_POLYGON symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POLYGON = 0x0009;

		/// <summary>
		/// Value of GL_ACCUM symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM = 0x0100;

		/// <summary>
		/// Value of GL_LOAD symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LOAD = 0x0101;

		/// <summary>
		/// Value of GL_RETURN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RETURN = 0x0102;

		/// <summary>
		/// Value of GL_MULT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MULT = 0x0103;

		/// <summary>
		/// Value of GL_ADD symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ADD = 0x0104;

		/// <summary>
		/// Value of GL_AUX0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX0 = 0x0409;

		/// <summary>
		/// Value of GL_AUX1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX1 = 0x040A;

		/// <summary>
		/// Value of GL_AUX2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX2 = 0x040B;

		/// <summary>
		/// Value of GL_AUX3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX3 = 0x040C;

		/// <summary>
		/// Value of GL_2D symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _2D = 0x0600;

		/// <summary>
		/// Value of GL_3D symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _3D = 0x0601;

		/// <summary>
		/// Value of GL_3D_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _3D_COLOR = 0x0602;

		/// <summary>
		/// Value of GL_3D_COLOR_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _3D_COLOR_TEXTURE = 0x0603;

		/// <summary>
		/// Value of GL_4D_COLOR_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _4D_COLOR_TEXTURE = 0x0604;

		/// <summary>
		/// Value of GL_PASS_THROUGH_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PASS_THROUGH_TOKEN = 0x0700;

		/// <summary>
		/// Value of GL_POINT_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_TOKEN = 0x0701;

		/// <summary>
		/// Value of GL_LINE_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_TOKEN = 0x0702;

		/// <summary>
		/// Value of GL_POLYGON_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POLYGON_TOKEN = 0x0703;

		/// <summary>
		/// Value of GL_BITMAP_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BITMAP_TOKEN = 0x0704;

		/// <summary>
		/// Value of GL_DRAW_PIXEL_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DRAW_PIXEL_TOKEN = 0x0705;

		/// <summary>
		/// Value of GL_COPY_PIXEL_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COPY_PIXEL_TOKEN = 0x0706;

		/// <summary>
		/// Value of GL_LINE_RESET_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_RESET_TOKEN = 0x0707;

		/// <summary>
		/// Value of GL_EXP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EXP = 0x0800;

		/// <summary>
		/// Value of GL_EXP2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EXP2 = 0x0801;

		/// <summary>
		/// Value of GL_COEFF symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COEFF = 0x0A00;

		/// <summary>
		/// Value of GL_ORDER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ORDER = 0x0A01;

		/// <summary>
		/// Value of GL_DOMAIN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOMAIN = 0x0A02;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_I symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_I = 0x0C70;

		/// <summary>
		/// Value of GL_PIXEL_MAP_S_TO_S symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_S_TO_S = 0x0C71;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_R symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_R = 0x0C72;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_G symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_G = 0x0C73;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_B symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_B = 0x0C74;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_A symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_A = 0x0C75;

		/// <summary>
		/// Value of GL_PIXEL_MAP_R_TO_R symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_R_TO_R = 0x0C76;

		/// <summary>
		/// Value of GL_PIXEL_MAP_G_TO_G symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_G_TO_G = 0x0C77;

		/// <summary>
		/// Value of GL_PIXEL_MAP_B_TO_B symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_B_TO_B = 0x0C78;

		/// <summary>
		/// Value of GL_PIXEL_MAP_A_TO_A symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_A_TO_A = 0x0C79;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_POINTER = 0x808E;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_POINTER = 0x808F;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_POINTER = 0x8090;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_POINTER = 0x8091;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_POINTER = 0x8092;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY_POINTER = 0x8093;

		/// <summary>
		/// Value of GL_FEEDBACK_BUFFER_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK_BUFFER_POINTER = 0x0DF0;

		/// <summary>
		/// Value of GL_SELECTION_BUFFER_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SELECTION_BUFFER_POINTER = 0x0DF3;

		/// <summary>
		/// Value of GL_CURRENT_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_COLOR = 0x0B00;

		/// <summary>
		/// Value of GL_CURRENT_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_INDEX = 0x0B01;

		/// <summary>
		/// Value of GL_CURRENT_NORMAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_NORMAL = 0x0B02;

		/// <summary>
		/// Value of GL_CURRENT_TEXTURE_COORDS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_TEXTURE_COORDS = 0x0B03;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_COLOR = 0x0B04;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_INDEX = 0x0B05;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_TEXTURE_COORDS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_POSITION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_POSITION = 0x0B07;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_POSITION_VALID symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_POSITION_VALID = 0x0B08;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_DISTANCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_DISTANCE = 0x0B09;

		/// <summary>
		/// Value of GL_POINT_SMOOTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SMOOTH = 0x0B10;

		/// <summary>
		/// Value of GL_LINE_STIPPLE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE = 0x0B24;

		/// <summary>
		/// Value of GL_LINE_STIPPLE_PATTERN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE_PATTERN = 0x0B25;

		/// <summary>
		/// Value of GL_LINE_STIPPLE_REPEAT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE_REPEAT = 0x0B26;

		/// <summary>
		/// Value of GL_LIST_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_MODE = 0x0B30;

		/// <summary>
		/// Value of GL_MAX_LIST_NESTING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_LIST_NESTING = 0x0B31;

		/// <summary>
		/// Value of GL_LIST_BASE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_BASE = 0x0B32;

		/// <summary>
		/// Value of GL_LIST_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_INDEX = 0x0B33;

		/// <summary>
		/// Value of GL_POLYGON_STIPPLE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POLYGON_STIPPLE = 0x0B42;

		/// <summary>
		/// Value of GL_EDGE_FLAG symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG = 0x0B43;

		/// <summary>
		/// Value of GL_LIGHTING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHTING = 0x0B50;

		/// <summary>
		/// Value of GL_LIGHT_MODEL_LOCAL_VIEWER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

		/// <summary>
		/// Value of GL_LIGHT_MODEL_TWO_SIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_TWO_SIDE = 0x0B52;

		/// <summary>
		/// Value of GL_LIGHT_MODEL_AMBIENT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_AMBIENT = 0x0B53;

		/// <summary>
		/// Value of GL_SHADE_MODEL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SHADE_MODEL = 0x0B54;

		/// <summary>
		/// Value of GL_COLOR_MATERIAL_FACE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL_FACE = 0x0B55;

		/// <summary>
		/// Value of GL_COLOR_MATERIAL_PARAMETER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL_PARAMETER = 0x0B56;

		/// <summary>
		/// Value of GL_COLOR_MATERIAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL = 0x0B57;

		/// <summary>
		/// Value of GL_FOG symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG = 0x0B60;

		/// <summary>
		/// Value of GL_FOG_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_INDEX = 0x0B61;

		/// <summary>
		/// Value of GL_FOG_DENSITY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_DENSITY = 0x0B62;

		/// <summary>
		/// Value of GL_FOG_START symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_START = 0x0B63;

		/// <summary>
		/// Value of GL_FOG_END symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_END = 0x0B64;

		/// <summary>
		/// Value of GL_FOG_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_MODE = 0x0B65;

		/// <summary>
		/// Value of GL_FOG_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COLOR = 0x0B66;

		/// <summary>
		/// Value of GL_ACCUM_CLEAR_VALUE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_CLEAR_VALUE = 0x0B80;

		/// <summary>
		/// Value of GL_MATRIX_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MATRIX_MODE = 0x0BA0;

		/// <summary>
		/// Value of GL_NORMALIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMALIZE = 0x0BA1;

		/// <summary>
		/// Value of GL_MODELVIEW_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW_STACK_DEPTH = 0x0BA3;

		/// <summary>
		/// Value of GL_PROJECTION_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION_STACK_DEPTH = 0x0BA4;

		/// <summary>
		/// Value of GL_TEXTURE_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_STACK_DEPTH = 0x0BA5;

		/// <summary>
		/// Value of GL_MODELVIEW_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW_MATRIX = 0x0BA6;

		/// <summary>
		/// Value of GL_PROJECTION_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION_MATRIX = 0x0BA7;

		/// <summary>
		/// Value of GL_TEXTURE_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_MATRIX = 0x0BA8;

		/// <summary>
		/// Value of GL_ATTRIB_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ATTRIB_STACK_DEPTH = 0x0BB0;

		/// <summary>
		/// Value of GL_CLIENT_ATTRIB_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;

		/// <summary>
		/// Value of GL_ALPHA_TEST symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST = 0x0BC0;

		/// <summary>
		/// Value of GL_ALPHA_TEST_FUNC symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST_FUNC = 0x0BC1;

		/// <summary>
		/// Value of GL_ALPHA_TEST_REF symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST_REF = 0x0BC2;

		/// <summary>
		/// Value of GL_INDEX_LOGIC_OP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_LOGIC_OP = 0x0BF1;

		/// <summary>
		/// Value of GL_LOGIC_OP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LOGIC_OP = 0x0BF1;

		/// <summary>
		/// Value of GL_AUX_BUFFERS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX_BUFFERS = 0x0C00;

		/// <summary>
		/// Value of GL_INDEX_CLEAR_VALUE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_CLEAR_VALUE = 0x0C20;

		/// <summary>
		/// Value of GL_INDEX_WRITEMASK symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_WRITEMASK = 0x0C21;

		/// <summary>
		/// Value of GL_INDEX_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_MODE = 0x0C30;

		/// <summary>
		/// Value of GL_RGBA_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RGBA_MODE = 0x0C31;

		/// <summary>
		/// Value of GL_RENDER_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RENDER_MODE = 0x0C40;

		/// <summary>
		/// Value of GL_PERSPECTIVE_CORRECTION_HINT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PERSPECTIVE_CORRECTION_HINT = 0x0C50;

		/// <summary>
		/// Value of GL_POINT_SMOOTH_HINT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SMOOTH_HINT = 0x0C51;

		/// <summary>
		/// Value of GL_FOG_HINT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_HINT = 0x0C54;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_S symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_S = 0x0C60;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_T symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_T = 0x0C61;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_R symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_R = 0x0C62;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_Q symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_Q = 0x0C63;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_I_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

		/// <summary>
		/// Value of GL_PIXEL_MAP_S_TO_S_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_R_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_G_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_B_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

		/// <summary>
		/// Value of GL_PIXEL_MAP_I_TO_A_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

		/// <summary>
		/// Value of GL_PIXEL_MAP_R_TO_R_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

		/// <summary>
		/// Value of GL_PIXEL_MAP_G_TO_G_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

		/// <summary>
		/// Value of GL_PIXEL_MAP_B_TO_B_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

		/// <summary>
		/// Value of GL_PIXEL_MAP_A_TO_A_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

		/// <summary>
		/// Value of GL_MAP_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP_COLOR = 0x0D10;

		/// <summary>
		/// Value of GL_MAP_STENCIL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP_STENCIL = 0x0D11;

		/// <summary>
		/// Value of GL_INDEX_SHIFT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_SHIFT = 0x0D12;

		/// <summary>
		/// Value of GL_INDEX_OFFSET symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_OFFSET = 0x0D13;

		/// <summary>
		/// Value of GL_RED_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_SCALE = 0x0D14;

		/// <summary>
		/// Value of GL_RED_BIAS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_BIAS = 0x0D15;

		/// <summary>
		/// Value of GL_ZOOM_X symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ZOOM_X = 0x0D16;

		/// <summary>
		/// Value of GL_ZOOM_Y symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ZOOM_Y = 0x0D17;

		/// <summary>
		/// Value of GL_GREEN_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_SCALE = 0x0D18;

		/// <summary>
		/// Value of GL_GREEN_BIAS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_BIAS = 0x0D19;

		/// <summary>
		/// Value of GL_BLUE_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_SCALE = 0x0D1A;

		/// <summary>
		/// Value of GL_BLUE_BIAS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_BIAS = 0x0D1B;

		/// <summary>
		/// Value of GL_ALPHA_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_SCALE = 0x0D1C;

		/// <summary>
		/// Value of GL_ALPHA_BIAS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_BIAS = 0x0D1D;

		/// <summary>
		/// Value of GL_DEPTH_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_SCALE = 0x0D1E;

		/// <summary>
		/// Value of GL_DEPTH_BIAS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_BIAS = 0x0D1F;

		/// <summary>
		/// Value of GL_MAX_EVAL_ORDER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_EVAL_ORDER = 0x0D30;

		/// <summary>
		/// Value of GL_MAX_LIGHTS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_LIGHTS = 0x0D31;

		/// <summary>
		/// Value of GL_MAX_CLIP_PLANES symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_CLIP_PLANES = 0x0D32;

		/// <summary>
		/// Value of GL_MAX_PIXEL_MAP_TABLE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_PIXEL_MAP_TABLE = 0x0D34;

		/// <summary>
		/// Value of GL_MAX_ATTRIB_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_ATTRIB_STACK_DEPTH = 0x0D35;

		/// <summary>
		/// Value of GL_MAX_MODELVIEW_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

		/// <summary>
		/// Value of GL_MAX_NAME_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_NAME_STACK_DEPTH = 0x0D37;

		/// <summary>
		/// Value of GL_MAX_PROJECTION_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_PROJECTION_STACK_DEPTH = 0x0D38;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_TEXTURE_STACK_DEPTH = 0x0D39;

		/// <summary>
		/// Value of GL_MAX_CLIENT_ATTRIB_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

		/// <summary>
		/// Value of GL_INDEX_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_BITS = 0x0D51;

		/// <summary>
		/// Value of GL_RED_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_BITS = 0x0D52;

		/// <summary>
		/// Value of GL_GREEN_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_BITS = 0x0D53;

		/// <summary>
		/// Value of GL_BLUE_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_BITS = 0x0D54;

		/// <summary>
		/// Value of GL_ALPHA_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_BITS = 0x0D55;

		/// <summary>
		/// Value of GL_DEPTH_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_BITS = 0x0D56;

		/// <summary>
		/// Value of GL_STENCIL_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int STENCIL_BITS = 0x0D57;

		/// <summary>
		/// Value of GL_ACCUM_RED_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_RED_BITS = 0x0D58;

		/// <summary>
		/// Value of GL_ACCUM_GREEN_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_GREEN_BITS = 0x0D59;

		/// <summary>
		/// Value of GL_ACCUM_BLUE_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_BLUE_BITS = 0x0D5A;

		/// <summary>
		/// Value of GL_ACCUM_ALPHA_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_ALPHA_BITS = 0x0D5B;

		/// <summary>
		/// Value of GL_NAME_STACK_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NAME_STACK_DEPTH = 0x0D70;

		/// <summary>
		/// Value of GL_AUTO_NORMAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUTO_NORMAL = 0x0D80;

		/// <summary>
		/// Value of GL_MAP1_COLOR_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_COLOR_4 = 0x0D90;

		/// <summary>
		/// Value of GL_MAP1_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_INDEX = 0x0D91;

		/// <summary>
		/// Value of GL_MAP1_NORMAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_NORMAL = 0x0D92;

		/// <summary>
		/// Value of GL_MAP1_TEXTURE_COORD_1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_1 = 0x0D93;

		/// <summary>
		/// Value of GL_MAP1_TEXTURE_COORD_2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_2 = 0x0D94;

		/// <summary>
		/// Value of GL_MAP1_TEXTURE_COORD_3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_3 = 0x0D95;

		/// <summary>
		/// Value of GL_MAP1_TEXTURE_COORD_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_4 = 0x0D96;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_VERTEX_3 = 0x0D97;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_VERTEX_4 = 0x0D98;

		/// <summary>
		/// Value of GL_MAP2_COLOR_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_COLOR_4 = 0x0DB0;

		/// <summary>
		/// Value of GL_MAP2_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_INDEX = 0x0DB1;

		/// <summary>
		/// Value of GL_MAP2_NORMAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_NORMAL = 0x0DB2;

		/// <summary>
		/// Value of GL_MAP2_TEXTURE_COORD_1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_1 = 0x0DB3;

		/// <summary>
		/// Value of GL_MAP2_TEXTURE_COORD_2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_2 = 0x0DB4;

		/// <summary>
		/// Value of GL_MAP2_TEXTURE_COORD_3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_3 = 0x0DB5;

		/// <summary>
		/// Value of GL_MAP2_TEXTURE_COORD_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_4 = 0x0DB6;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_VERTEX_3 = 0x0DB7;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_VERTEX_4 = 0x0DB8;

		/// <summary>
		/// Value of GL_MAP1_GRID_DOMAIN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_GRID_DOMAIN = 0x0DD0;

		/// <summary>
		/// Value of GL_MAP1_GRID_SEGMENTS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_GRID_SEGMENTS = 0x0DD1;

		/// <summary>
		/// Value of GL_MAP2_GRID_DOMAIN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_GRID_DOMAIN = 0x0DD2;

		/// <summary>
		/// Value of GL_MAP2_GRID_SEGMENTS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_GRID_SEGMENTS = 0x0DD3;

		/// <summary>
		/// Value of GL_FEEDBACK_BUFFER_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK_BUFFER_SIZE = 0x0DF1;

		/// <summary>
		/// Value of GL_FEEDBACK_BUFFER_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK_BUFFER_TYPE = 0x0DF2;

		/// <summary>
		/// Value of GL_SELECTION_BUFFER_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SELECTION_BUFFER_SIZE = 0x0DF4;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY = 0x8074;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY = 0x8075;

		/// <summary>
		/// Value of GL_COLOR_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY = 0x8076;

		/// <summary>
		/// Value of GL_INDEX_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY = 0x8077;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY = 0x8078;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY = 0x8079;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_SIZE = 0x807A;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_TYPE = 0x807B;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_STRIDE = 0x807C;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_TYPE = 0x807E;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_STRIDE = 0x807F;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_SIZE = 0x8081;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_TYPE = 0x8082;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_STRIDE = 0x8083;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_TYPE = 0x8085;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_STRIDE = 0x8086;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_SIZE = 0x8088;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_TYPE = 0x8089;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY_STRIDE = 0x808C;

		/// <summary>
		/// Value of GL_TEXTURE_COMPONENTS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COMPONENTS = 0x1003;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_BORDER = 0x1005;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_LUMINANCE_SIZE = 0x8060;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_INTENSITY_SIZE = 0x8061;

		/// <summary>
		/// Value of GL_TEXTURE_PRIORITY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_PRIORITY = 0x8066;

		/// <summary>
		/// Value of GL_TEXTURE_RESIDENT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_RESIDENT = 0x8067;

		/// <summary>
		/// Value of GL_AMBIENT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AMBIENT = 0x1200;

		/// <summary>
		/// Value of GL_DIFFUSE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DIFFUSE = 0x1201;

		/// <summary>
		/// Value of GL_SPECULAR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPECULAR = 0x1202;

		/// <summary>
		/// Value of GL_POSITION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POSITION = 0x1203;

		/// <summary>
		/// Value of GL_SPOT_DIRECTION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_DIRECTION = 0x1204;

		/// <summary>
		/// Value of GL_SPOT_EXPONENT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_EXPONENT = 0x1205;

		/// <summary>
		/// Value of GL_SPOT_CUTOFF symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_CUTOFF = 0x1206;

		/// <summary>
		/// Value of GL_CONSTANT_ATTENUATION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CONSTANT_ATTENUATION = 0x1207;

		/// <summary>
		/// Value of GL_LINEAR_ATTENUATION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINEAR_ATTENUATION = 0x1208;

		/// <summary>
		/// Value of GL_QUADRATIC_ATTENUATION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int QUADRATIC_ATTENUATION = 0x1209;

		/// <summary>
		/// Value of GL_COMPILE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPILE = 0x1300;

		/// <summary>
		/// Value of GL_COMPILE_AND_EXECUTE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPILE_AND_EXECUTE = 0x1301;

		/// <summary>
		/// Value of GL_2_BYTES symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _2_BYTES = 0x1407;

		/// <summary>
		/// Value of GL_3_BYTES symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _3_BYTES = 0x1408;

		/// <summary>
		/// Value of GL_4_BYTES symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _4_BYTES = 0x1409;

		/// <summary>
		/// Value of GL_EMISSION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EMISSION = 0x1600;

		/// <summary>
		/// Value of GL_SHININESS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SHININESS = 0x1601;

		/// <summary>
		/// Value of GL_AMBIENT_AND_DIFFUSE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AMBIENT_AND_DIFFUSE = 0x1602;

		/// <summary>
		/// Value of GL_COLOR_INDEXES symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_INDEXES = 0x1603;

		/// <summary>
		/// Value of GL_MODELVIEW symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW = 0x1700;

		/// <summary>
		/// Value of GL_PROJECTION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION = 0x1701;

		/// <summary>
		/// Value of GL_COLOR_INDEX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_INDEX = 0x1900;

		/// <summary>
		/// Value of GL_LUMINANCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE = 0x1909;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE_ALPHA = 0x190A;

		/// <summary>
		/// Value of GL_BITMAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BITMAP = 0x1A00;

		/// <summary>
		/// Value of GL_RENDER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RENDER = 0x1C00;

		/// <summary>
		/// Value of GL_FEEDBACK symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK = 0x1C01;

		/// <summary>
		/// Value of GL_SELECT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SELECT = 0x1C02;

		/// <summary>
		/// Value of GL_FLAT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FLAT = 0x1D00;

		/// <summary>
		/// Value of GL_SMOOTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SMOOTH = 0x1D01;

		/// <summary>
		/// Value of GL_S symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int S = 0x2000;

		/// <summary>
		/// Value of GL_T symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T = 0x2001;

		/// <summary>
		/// Value of GL_R symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int R = 0x2002;

		/// <summary>
		/// Value of GL_Q symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int Q = 0x2003;

		/// <summary>
		/// Value of GL_MODULATE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODULATE = 0x2100;

		/// <summary>
		/// Value of GL_DECAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DECAL = 0x2101;

		/// <summary>
		/// Value of GL_TEXTURE_ENV_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV_MODE = 0x2200;

		/// <summary>
		/// Value of GL_TEXTURE_ENV_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV_COLOR = 0x2201;

		/// <summary>
		/// Value of GL_TEXTURE_ENV symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV = 0x2300;

		/// <summary>
		/// Value of GL_EYE_LINEAR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EYE_LINEAR = 0x2400;

		/// <summary>
		/// Value of GL_OBJECT_LINEAR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OBJECT_LINEAR = 0x2401;

		/// <summary>
		/// Value of GL_SPHERE_MAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPHERE_MAP = 0x2402;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_MODE = 0x2500;

		/// <summary>
		/// Value of GL_OBJECT_PLANE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OBJECT_PLANE = 0x2501;

		/// <summary>
		/// Value of GL_EYE_PLANE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_fog_distance")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EYE_PLANE = 0x2502;

		/// <summary>
		/// Value of GL_CLAMP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP = 0x2900;

		/// <summary>
		/// Value of GL_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA4 = 0x803B;

		/// <summary>
		/// Value of GL_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA8 = 0x803C;

		/// <summary>
		/// Value of GL_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA12 = 0x803D;

		/// <summary>
		/// Value of GL_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA16 = 0x803E;

		/// <summary>
		/// Value of GL_LUMINANCE4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE4 = 0x803F;

		/// <summary>
		/// Value of GL_LUMINANCE8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE8 = 0x8040;

		/// <summary>
		/// Value of GL_LUMINANCE12 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12 = 0x8041;

		/// <summary>
		/// Value of GL_LUMINANCE16 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE16 = 0x8042;

		/// <summary>
		/// Value of GL_LUMINANCE4_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE4_ALPHA4 = 0x8043;

		/// <summary>
		/// Value of GL_LUMINANCE6_ALPHA2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE6_ALPHA2 = 0x8044;

		/// <summary>
		/// Value of GL_LUMINANCE8_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE8_ALPHA8 = 0x8045;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12_ALPHA4 = 0x8046;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12_ALPHA12 = 0x8047;

		/// <summary>
		/// Value of GL_LUMINANCE16_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE16_ALPHA16 = 0x8048;

		/// <summary>
		/// Value of GL_INTENSITY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY = 0x8049;

		/// <summary>
		/// Value of GL_INTENSITY4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY4 = 0x804A;

		/// <summary>
		/// Value of GL_INTENSITY8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY8 = 0x804B;

		/// <summary>
		/// Value of GL_INTENSITY12 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY12 = 0x804C;

		/// <summary>
		/// Value of GL_INTENSITY16 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY16 = 0x804D;

		/// <summary>
		/// Value of GL_V2F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int V2F = 0x2A20;

		/// <summary>
		/// Value of GL_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int V3F = 0x2A21;

		/// <summary>
		/// Value of GL_C4UB_V2F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int C4UB_V2F = 0x2A22;

		/// <summary>
		/// Value of GL_C4UB_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int C4UB_V3F = 0x2A23;

		/// <summary>
		/// Value of GL_C3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int C3F_V3F = 0x2A24;

		/// <summary>
		/// Value of GL_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int N3F_V3F = 0x2A25;

		/// <summary>
		/// Value of GL_C4F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int C4F_N3F_V3F = 0x2A26;

		/// <summary>
		/// Value of GL_T2F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T2F_V3F = 0x2A27;

		/// <summary>
		/// Value of GL_T4F_V4F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T4F_V4F = 0x2A28;

		/// <summary>
		/// Value of GL_T2F_C4UB_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T2F_C4UB_V3F = 0x2A29;

		/// <summary>
		/// Value of GL_T2F_C3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T2F_C3F_V3F = 0x2A2A;

		/// <summary>
		/// Value of GL_T2F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T2F_N3F_V3F = 0x2A2B;

		/// <summary>
		/// Value of GL_T2F_C4F_N3F_V3F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T2F_C4F_N3F_V3F = 0x2A2C;

		/// <summary>
		/// Value of GL_T4F_C4F_N3F_V4F symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int T4F_C4F_N3F_V4F = 0x2A2D;

		/// <summary>
		/// Value of GL_CLIP_PLANE0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE0 = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_PLANE1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE1 = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_PLANE2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE2 = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_PLANE3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE3 = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_PLANE4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE4 = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_PLANE5 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE5 = 0x3005;

		/// <summary>
		/// Value of GL_LIGHT0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT0 = 0x4000;

		/// <summary>
		/// Value of GL_LIGHT1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT1 = 0x4001;

		/// <summary>
		/// Value of GL_LIGHT2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT2 = 0x4002;

		/// <summary>
		/// Value of GL_LIGHT3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT3 = 0x4003;

		/// <summary>
		/// Value of GL_LIGHT4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT4 = 0x4004;

		/// <summary>
		/// Value of GL_LIGHT5 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT5 = 0x4005;

		/// <summary>
		/// Value of GL_LIGHT6 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT6 = 0x4006;

		/// <summary>
		/// Value of GL_LIGHT7 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT7 = 0x4007;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered. 
		/// </param>
		/// <remarks>
		/// glDrawArrays specifies multiple geometric primitives with very few subroutine calls. Instead of calling a GL procedure 
		/// topass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate arrays of 
		/// vertices,normals, and colors and use them to construct a sequence of primitives with a single call to glDrawArrays. 
		/// When glDrawArrays is called, it uses count sequential elements from each enabled array to construct a sequence of 
		/// geometricprimitives, beginning with element first. mode specifies what kind of primitives are constructed and how the 
		/// arrayelements construct those primitives. 
		/// Vertex attributes that are modified by glDrawArrays have an unspecified value after glDrawArrays returns. Attributes 
		/// thataren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawArrays(int mode, Int32 first, Int32 count)
		{
			if        (Delegates.pglDrawArrays != null) {
				Delegates.pglDrawArrays(mode, first, count);
				CallLog("glDrawArrays({0}, {1}, {2})", mode, first, count);
			} else if (Delegates.pglDrawArraysEXT != null) {
				Delegates.pglDrawArraysEXT(mode, first, count);
				CallLog("glDrawArraysEXT({0}, {1}, {2})", mode, first, count);
			} else
				throw new NotImplementedException("glDrawArrays (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered. 
		/// </param>
		/// <remarks>
		/// glDrawArrays specifies multiple geometric primitives with very few subroutine calls. Instead of calling a GL procedure 
		/// topass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate arrays of 
		/// vertices,normals, and colors and use them to construct a sequence of primitives with a single call to glDrawArrays. 
		/// When glDrawArrays is called, it uses count sequential elements from each enabled array to construct a sequence of 
		/// geometricprimitives, beginning with element first. mode specifies what kind of primitives are constructed and how the 
		/// arrayelements construct those primitives. 
		/// Vertex attributes that are modified by glDrawArrays have an unspecified value after glDrawArrays returns. Attributes 
		/// thataren't modified remain well defined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   datastore is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			if        (Delegates.pglDrawArrays != null) {
				Delegates.pglDrawArrays((int)mode, first, count);
				CallLog("glDrawArrays({0}, {1}, {2})", mode, first, count);
			} else if (Delegates.pglDrawArraysEXT != null) {
				Delegates.pglDrawArraysEXT((int)mode, first, count);
				CallLog("glDrawArraysEXT({0}, {1}, {2})", mode, first, count);
			} else
				throw new NotImplementedException("glDrawArrays (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. 
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored. 
		/// </param>
		/// <remarks>
		/// glDrawElements specifies multiple geometric primitives with very few subroutine calls. Instead of calling a GL function 
		/// topass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate arrays of 
		/// vertices,normals, and so on, and use them to construct a sequence of primitives with a single call to glDrawElements. 
		/// When glDrawElements is called, it uses count sequential elements from an enabled array, starting at indices to construct 
		/// asequence of geometric primitives. mode specifies what kind of primitives are constructed and how the array elements 
		/// constructthese primitives. If more than one array is enabled, each is used. 
		/// Vertex attributes that are modified by glDrawElements have an unspecified value after glDrawElements returns. Attributes 
		/// thataren't modified maintain their previous values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawElements(int mode, Int32 count, int type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawElements != null, "pglDrawElements not implemented");
			Delegates.pglDrawElements(mode, count, type, indices);
			CallLog("glDrawElements({0}, {1}, {2}, {3})", mode, count, type, indices);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. 
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored. 
		/// </param>
		/// <remarks>
		/// glDrawElements specifies multiple geometric primitives with very few subroutine calls. Instead of calling a GL function 
		/// topass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate arrays of 
		/// vertices,normals, and so on, and use them to construct a sequence of primitives with a single call to glDrawElements. 
		/// When glDrawElements is called, it uses count sequential elements from an enabled array, starting at indices to construct 
		/// asequence of geometric primitives. mode specifies what kind of primitives are constructed and how the array elements 
		/// constructthese primitives. If more than one array is enabled, each is used. 
		/// Vertex attributes that are modified by glDrawElements have an unspecified value after glDrawElements returns. Attributes 
		/// thataren't modified maintain their previous values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawElements(PrimitiveType mode, Int32 count, int type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawElements != null, "pglDrawElements not implemented");
			Delegates.pglDrawElements((int)mode, count, type, indices);
			CallLog("glDrawElements({0}, {1}, {2}, {3})", mode, count, type, indices);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY,GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY,GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted. 
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered. 
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT. 
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored. 
		/// </param>
		/// <remarks>
		/// glDrawElements specifies multiple geometric primitives with very few subroutine calls. Instead of calling a GL function 
		/// topass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate arrays of 
		/// vertices,normals, and so on, and use them to construct a sequence of primitives with a single call to glDrawElements. 
		/// When glDrawElements is called, it uses count sequential elements from an enabled array, starting at indices to construct 
		/// asequence of geometric primitives. mode specifies what kind of primitives are constructed and how the array elements 
		/// constructthese primitives. If more than one array is enabled, each is used. 
		/// Vertex attributes that are modified by glDrawElements have an unspecified value after glDrawElements returns. Attributes 
		/// thataren't modified maintain their previous values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if count is negative. 
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   ofthe geometry shader in the currently installed program object. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   thebuffer object's data store is currently mapped. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		public static void DrawElements(int mode, Int32 count, int type, Object indices)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElements(mode, count, type, pin_indices.AddrOfPinnedObject());
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// return the address of the specified pointer
		/// </summary>
		/// <param name="pname">
		/// Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetPointerv returns pointer information. pname indicates the pointer to be returned, and params is a pointer to a 
		/// locationin which to place the returned data. The parameters that may be queried include: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		public static void GetPointer(int pname, IntPtr @params)
		{
			if        (Delegates.pglGetPointerv != null) {
				Delegates.pglGetPointerv(pname, @params);
				CallLog("glGetPointerv({0}, {1})", pname, @params);
			} else if (Delegates.pglGetPointervEXT != null) {
				Delegates.pglGetPointervEXT(pname, @params);
				CallLog("glGetPointervEXT({0}, {1})", pname, @params);
			} else if (Delegates.pglGetPointervKHR != null) {
				Delegates.pglGetPointervKHR(pname, @params);
				CallLog("glGetPointervKHR({0}, {1})", pname, @params);
			} else
				throw new NotImplementedException("glGetPointerv (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return the address of the specified pointer
		/// </summary>
		/// <param name="pname">
		/// Specifies the pointer to be returned. Must be one of GL_DEBUG_CALLBACK_FUNCTION or GL_DEBUG_CALLBACK_USER_PARAM. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetPointerv returns pointer information. pname indicates the pointer to be returned, and params is a pointer to a 
		/// locationin which to place the returned data. The parameters that may be queried include: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		public static void GetPointer(GetPointervPName pname, IntPtr @params)
		{
			if        (Delegates.pglGetPointerv != null) {
				Delegates.pglGetPointerv((int)pname, @params);
				CallLog("glGetPointerv({0}, {1})", pname, @params);
			} else if (Delegates.pglGetPointervEXT != null) {
				Delegates.pglGetPointervEXT((int)pname, @params);
				CallLog("glGetPointervEXT({0}, {1})", pname, @params);
			} else if (Delegates.pglGetPointervKHR != null) {
				Delegates.pglGetPointervKHR((int)pname, @params);
				CallLog("glGetPointervKHR({0}, {1})", pname, @params);
			} else
				throw new NotImplementedException("glGetPointerv (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the scale and units used to calculate depth values
		/// </summary>
		/// <param name="factor">
		/// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0. 
		/// </param>
		/// <param name="units">
		/// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0. 
		/// </param>
		/// <remarks>
		/// When <see cref="Gl.POLYGON_OFFSET_FILL"/>, <see cref="Gl.POLYGON_OFFSET_LINE"/>, or <see 
		/// cref="Gl.POLYGON_OFFSET_POINT"/>is enabled, each fragment's depth value will be offset after it is interpolated from the 
		/// depthvalues of the appropriate vertices. The value of the offset is factor×DZ+r×units, where DZ is a measurement of the 
		/// changein depth relative to the screen area of the polygon, and r is the smallest value that is guaranteed to produce a 
		/// resolvableoffset for a given implementation. The offset is added before the depth test is performed and before the value 
		/// iswritten into the depth buffer. 
		/// <see cref="Gl.PolygonOffset"/> is useful for rendering hidden-line images, for applying decals to surfaces, and for 
		/// renderingsolids with highlighted edges. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PolygonOffset"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.POLYGON_OFFSET_FILL"/>, <see cref="Gl.POLYGON_OFFSET_LINE"/>, or <see 
		///   cref="Gl.POLYGON_OFFSET_POINT"/>.
		/// - Gl.Get with argument <see cref="Gl.POLYGON_OFFSET_FACTOR"/> or <see cref="Gl.POLYGON_OFFSET_UNITS"/>. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void PolygonOffset(float factor, float units)
		{
			Debug.Assert(Delegates.pglPolygonOffset != null, "pglPolygonOffset not implemented");
			Delegates.pglPolygonOffset(factor, units);
			CallLog("glPolygonOffset({0}, {1})", factor, units);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels into a 1D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: <see cref="Gl.ALPHA"/>, 
		/// <seecref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_LUMINANCE"/>, <see cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.COMPRESSED_INTENSITY"/>,<see cref="Gl.COMPRESSED_RGB"/>, <see cref="Gl.COMPRESSED_RGBA"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT32"/>,<see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see 
		/// cref="Gl.LUMINANCE12"/>,<see cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE4_ALPHA4"/>,<see cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA4"/>,<see cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see 
		/// cref="Gl.INTENSITY"/>,<see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see 
		/// cref="Gl.INTENSITY16"/>,<see cref="Gl.RGB"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, 
		/// <seecref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, 
		/// <seecref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>,<see cref="Gl.RGBA12"/>, <see cref="Gl.RGBA16"/>, <see cref="Gl.SLUMINANCE"/>, <see 
		/// cref="Gl.SLUMINANCE8"/>,<see cref="Gl.SLUMINANCE_ALPHA"/>, <see cref="Gl.SLUMINANCE8_ALPHA8"/>, <see cref="Gl.SRGB"/>, 
		/// <seecref="Gl.SRGB8"/>, <see cref="Gl.SRGB_ALPHA"/>, or <see cref="Gl.SRGB8_ALPHA8"/>. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n. The height of the texture image 
		/// is1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexImage1D"/> defines a one-dimensional texture image with pixels from the current <see 
		/// cref="Gl.READ_BUFFER"/>.
		/// The screen-aligned pixel row with left corner at xy and with a length of width+2⁡border defines the texture array at the 
		/// mipmaplevel specified by <paramref name="level"/>. <paramref name="internalformat"/> specifies the internal format of 
		/// thetexture array. 
		/// The pixels in the row are processed exactly as if Gl.CopyPixels had been called, but the process stops just before final 
		/// conversion.At this point all pixel component values are clamped to the range 01 and then converted to the texture's 
		/// internalformat for storage in the texel array. 
		/// Pixel ordering is such that lower x screen coordinates correspond to lower texture coordinates. 
		/// If any of the pixels within the specified row of the current <see cref="Gl.READ_BUFFER"/> are outside the window 
		/// associatedwith the current rendering context, then the values obtained for those pixels are undefined. 
		/// <see cref="Gl.CopyTexImage1D"/> defines a one-dimensional texture image with pixels from the current <see 
		/// cref="Gl.READ_BUFFER"/>.
		/// When <paramref name="internalformat"/> is one of the sRGB types, the GL does not automatically convert the source pixels 
		/// tothe sRGB color space. In this case, the <see cref="Gl.PixelMap"/> function can be used to accomplish the conversion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalformat"/> is not an allowable value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>cannot be represented as 2n+2⁡border for some integer value of n. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexImage1D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalformat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>and there is no depth buffer. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			if        (Delegates.pglCopyTexImage1D != null) {
				Delegates.pglCopyTexImage1D(target, level, internalformat, x, y, width, border);
				CallLog("glCopyTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			} else if (Delegates.pglCopyTexImage1DEXT != null) {
				Delegates.pglCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
				CallLog("glCopyTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			} else
				throw new NotImplementedException("glCopyTexImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels into a 1D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: <see cref="Gl.ALPHA"/>, 
		/// <seecref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_LUMINANCE"/>, <see cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.COMPRESSED_INTENSITY"/>,<see cref="Gl.COMPRESSED_RGB"/>, <see cref="Gl.COMPRESSED_RGBA"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT32"/>,<see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see 
		/// cref="Gl.LUMINANCE12"/>,<see cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE4_ALPHA4"/>,<see cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA4"/>,<see cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see 
		/// cref="Gl.INTENSITY"/>,<see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see 
		/// cref="Gl.INTENSITY16"/>,<see cref="Gl.RGB"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, 
		/// <seecref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, 
		/// <seecref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>,<see cref="Gl.RGBA12"/>, <see cref="Gl.RGBA16"/>, <see cref="Gl.SLUMINANCE"/>, <see 
		/// cref="Gl.SLUMINANCE8"/>,<see cref="Gl.SLUMINANCE_ALPHA"/>, <see cref="Gl.SLUMINANCE8_ALPHA8"/>, <see cref="Gl.SRGB"/>, 
		/// <seecref="Gl.SRGB8"/>, <see cref="Gl.SRGB_ALPHA"/>, or <see cref="Gl.SRGB8_ALPHA8"/>. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n. The height of the texture image 
		/// is1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexImage1D"/> defines a one-dimensional texture image with pixels from the current <see 
		/// cref="Gl.READ_BUFFER"/>.
		/// The screen-aligned pixel row with left corner at xy and with a length of width+2⁡border defines the texture array at the 
		/// mipmaplevel specified by <paramref name="level"/>. <paramref name="internalformat"/> specifies the internal format of 
		/// thetexture array. 
		/// The pixels in the row are processed exactly as if Gl.CopyPixels had been called, but the process stops just before final 
		/// conversion.At this point all pixel component values are clamped to the range 01 and then converted to the texture's 
		/// internalformat for storage in the texel array. 
		/// Pixel ordering is such that lower x screen coordinates correspond to lower texture coordinates. 
		/// If any of the pixels within the specified row of the current <see cref="Gl.READ_BUFFER"/> are outside the window 
		/// associatedwith the current rendering context, then the values obtained for those pixels are undefined. 
		/// <see cref="Gl.CopyTexImage1D"/> defines a one-dimensional texture image with pixels from the current <see 
		/// cref="Gl.READ_BUFFER"/>.
		/// When <paramref name="internalformat"/> is one of the sRGB types, the GL does not automatically convert the source pixels 
		/// tothe sRGB color space. In this case, the <see cref="Gl.PixelMap"/> function can be used to accomplish the conversion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not one of the allowable values. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalformat"/> is not an allowable value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>cannot be represented as 2n+2⁡border for some integer value of n. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexImage1D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalformat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>and there is no depth buffer. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CopyTexImage1D(TextureTarget target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			if        (Delegates.pglCopyTexImage1D != null) {
				Delegates.pglCopyTexImage1D((int)target, level, internalformat, x, y, width, border);
				CallLog("glCopyTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			} else if (Delegates.pglCopyTexImage1DEXT != null) {
				Delegates.pglCopyTexImage1DEXT((int)target, level, internalformat, x, y, width, border);
				CallLog("glCopyTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			} else
				throw new NotImplementedException("glCopyTexImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels into a 2D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: <see cref="Gl.ALPHA"/>, 
		/// <seecref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_LUMINANCE"/>, <see cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.COMPRESSED_INTENSITY"/>,<see cref="Gl.COMPRESSED_RGB"/>, <see cref="Gl.COMPRESSED_RGBA"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT32"/>,<see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see 
		/// cref="Gl.LUMINANCE12"/>,<see cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE4_ALPHA4"/>,<see cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA4"/>,<see cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see 
		/// cref="Gl.INTENSITY"/>,<see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see 
		/// cref="Gl.INTENSITY16"/>,<see cref="Gl.RGB"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, 
		/// <seecref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, 
		/// <seecref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>,<see cref="Gl.RGBA12"/>, <see cref="Gl.RGBA16"/>, <see cref="Gl.SLUMINANCE"/>, <see 
		/// cref="Gl.SLUMINANCE8"/>,<see cref="Gl.SLUMINANCE_ALPHA"/>, <see cref="Gl.SLUMINANCE8_ALPHA8"/>, <see cref="Gl.SRGB"/>, 
		/// <seecref="Gl.SRGB8"/>, <see cref="Gl.SRGB_ALPHA"/>, or <see cref="Gl.SRGB8_ALPHA8"/>. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. Must be 0 or 2m+2⁡border for some integer m. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexImage2D"/> defines a two-dimensional texture image, or cube-map texture image with pixels from the 
		/// current<see cref="Gl.READ_BUFFER"/>. 
		/// The screen-aligned pixel rectangle with lower left corner at (<paramref name="x"/>, <paramref name="y"/>) and with a 
		/// widthof width+2⁡border and a height of height+2⁡border defines the texture array at the mipmap level specified by 
		/// <paramrefname="level"/>. <paramref name="internalformat"/> specifies the internal format of the texture array. 
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// finalconversion. At this point all pixel component values are clamped to the range 01 and then converted to the 
		/// texture'sinternal format for storage in the texel array. 
		/// Pixel ordering is such that lower x and y screen coordinates correspond to lower s and t texture coordinates. 
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the window 
		/// associatedwith the current rendering context, then the values obtained for those pixels are undefined. 
		/// When <paramref name="internalformat"/> is one of the sRGB types, the GL does not automatically convert the source pixels 
		/// tothe sRGB color space. In this case, the <see cref="Gl.PixelMap"/> function can be used to accomplish the conversion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,or <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>or <paramref name="depth"/> cannot be represented as 2k+2⁡border for some integer k. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalformat"/> is not an accepted format. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexImage2D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalformat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>and there is no depth buffer. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			if        (Delegates.pglCopyTexImage2D != null) {
				Delegates.pglCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
				CallLog("glCopyTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			} else if (Delegates.pglCopyTexImage2DEXT != null) {
				Delegates.pglCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
				CallLog("glCopyTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			} else
				throw new NotImplementedException("glCopyTexImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels into a 2D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: <see cref="Gl.ALPHA"/>, 
		/// <seecref="Gl.ALPHA4"/>, <see cref="Gl.ALPHA8"/>, <see cref="Gl.ALPHA12"/>, <see cref="Gl.ALPHA16"/>, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_LUMINANCE"/>, <see cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.COMPRESSED_INTENSITY"/>,<see cref="Gl.COMPRESSED_RGB"/>, <see cref="Gl.COMPRESSED_RGBA"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, <see 
		/// cref="Gl.DEPTH_COMPONENT32"/>,<see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE4"/>, <see cref="Gl.LUMINANCE8"/>, <see 
		/// cref="Gl.LUMINANCE12"/>,<see cref="Gl.LUMINANCE16"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE4_ALPHA4"/>,<see cref="Gl.LUMINANCE6_ALPHA2"/>, <see cref="Gl.LUMINANCE8_ALPHA8"/>, <see 
		/// cref="Gl.LUMINANCE12_ALPHA4"/>,<see cref="Gl.LUMINANCE12_ALPHA12"/>, <see cref="Gl.LUMINANCE16_ALPHA16"/>, <see 
		/// cref="Gl.INTENSITY"/>,<see cref="Gl.INTENSITY4"/>, <see cref="Gl.INTENSITY8"/>, <see cref="Gl.INTENSITY12"/>, <see 
		/// cref="Gl.INTENSITY16"/>,<see cref="Gl.RGB"/>, <see cref="Gl.R3_G3_B2"/>, <see cref="Gl.RGB4"/>, <see cref="Gl.RGB5"/>, 
		/// <seecref="Gl.RGB8"/>, <see cref="Gl.RGB10"/>, <see cref="Gl.RGB12"/>, <see cref="Gl.RGB16"/>, <see cref="Gl.RGBA"/>, 
		/// <seecref="Gl.RGBA2"/>, <see cref="Gl.RGBA4"/>, <see cref="Gl.RGB5_A1"/>, <see cref="Gl.RGBA8"/>, <see 
		/// cref="Gl.RGB10_A2"/>,<see cref="Gl.RGBA12"/>, <see cref="Gl.RGBA16"/>, <see cref="Gl.SLUMINANCE"/>, <see 
		/// cref="Gl.SLUMINANCE8"/>,<see cref="Gl.SLUMINANCE_ALPHA"/>, <see cref="Gl.SLUMINANCE8_ALPHA8"/>, <see cref="Gl.SRGB"/>, 
		/// <seecref="Gl.SRGB8"/>, <see cref="Gl.SRGB_ALPHA"/>, or <see cref="Gl.SRGB8_ALPHA8"/>. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. Must be 0 or 2n+2⁡border for some integer n. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image. Must be 0 or 2m+2⁡border for some integer m. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexImage2D"/> defines a two-dimensional texture image, or cube-map texture image with pixels from the 
		/// current<see cref="Gl.READ_BUFFER"/>. 
		/// The screen-aligned pixel rectangle with lower left corner at (<paramref name="x"/>, <paramref name="y"/>) and with a 
		/// widthof width+2⁡border and a height of height+2⁡border defines the texture array at the mipmap level specified by 
		/// <paramrefname="level"/>. <paramref name="internalformat"/> specifies the internal format of the texture array. 
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// finalconversion. At this point all pixel component values are clamped to the range 01 and then converted to the 
		/// texture'sinternal format for storage in the texel array. 
		/// Pixel ordering is such that lower x and y screen coordinates correspond to lower s and t texture coordinates. 
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the window 
		/// associatedwith the current rendering context, then the values obtained for those pixels are undefined. 
		/// When <paramref name="internalformat"/> is one of the sRGB types, the GL does not automatically convert the source pixels 
		/// tothe sRGB color space. In this case, the <see cref="Gl.PixelMap"/> function can be used to accomplish the conversion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,or <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>or <paramref name="depth"/> cannot be represented as 2k+2⁡border for some integer k. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalformat"/> is not an accepted format. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexImage2D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalformat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>and there is no depth buffer. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CopyTexImage2D(TextureTarget target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			if        (Delegates.pglCopyTexImage2D != null) {
				Delegates.pglCopyTexImage2D((int)target, level, internalformat, x, y, width, height, border);
				CallLog("glCopyTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			} else if (Delegates.pglCopyTexImage2DEXT != null) {
				Delegates.pglCopyTexImage2DEXT((int)target, level, internalformat, x, y, width, height, border);
				CallLog("glCopyTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			} else
				throw new NotImplementedException("glCopyTexImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies the texel offset within the texture array. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage1D"/> replaces a portion of a one-dimensional texture image with pixels from the current 
		/// <seecref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.TexSubImage1D). 
		/// The screen-aligned pixel row with left corner at (<paramref name="x"/>,\ <paramref name="y"/>), and with length 
		/// <paramrefname="width"/> replaces the portion of the texture array with x indices <paramref name="xoffset"/> through 
		/// xoffset+width-1,inclusive. The destination in the texture array may not include any texels outside the texture array as 
		/// itwas originally specified. 
		/// The pixels in the row are processed exactly as if Gl.CopyPixels had been called, but the process stops just before final 
		/// conversion.At this point, all pixel component values are clamped to the range 01 and then converted to the texture's 
		/// internalformat for storage in the texel array. 
		/// It is not an error to specify a subtexture with zero width, but such a specification has no effect. If any of the pixels 
		/// withinthe specified row of the current <see cref="Gl.READ_BUFFER"/> are outside the read window associated with the 
		/// currentrendering context, then the values obtained for those pixels are undefined. 
		/// No change is made to the internalformat, width, or border parameters of the specified texture array or to texel values 
		/// outsidethe specified subregion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if /<paramref name="target"/> is not <see cref="Gl.TEXTURE_1D"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage1D or 
		///   Gl.CopyTexImage1Doperation. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, or xoffset+width&gt;w-b, where w is the <see 
		///   cref="Gl.TEXTURE_WIDTH"/>and b is the <see cref="Gl.TEXTURE_BORDER"/> of the texture image being modified. Note that w 
		///   includestwice the border width. 
		/// -  
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			if        (Delegates.pglCopyTexSubImage1D != null) {
				Delegates.pglCopyTexSubImage1D(target, level, xoffset, x, y, width);
				CallLog("glCopyTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			} else if (Delegates.pglCopyTexSubImage1DEXT != null) {
				Delegates.pglCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
				CallLog("glCopyTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			} else
				throw new NotImplementedException("glCopyTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies the texel offset within the texture array. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage1D"/> replaces a portion of a one-dimensional texture image with pixels from the current 
		/// <seecref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.TexSubImage1D). 
		/// The screen-aligned pixel row with left corner at (<paramref name="x"/>,\ <paramref name="y"/>), and with length 
		/// <paramrefname="width"/> replaces the portion of the texture array with x indices <paramref name="xoffset"/> through 
		/// xoffset+width-1,inclusive. The destination in the texture array may not include any texels outside the texture array as 
		/// itwas originally specified. 
		/// The pixels in the row are processed exactly as if Gl.CopyPixels had been called, but the process stops just before final 
		/// conversion.At this point, all pixel component values are clamped to the range 01 and then converted to the texture's 
		/// internalformat for storage in the texel array. 
		/// It is not an error to specify a subtexture with zero width, but such a specification has no effect. If any of the pixels 
		/// withinthe specified row of the current <see cref="Gl.READ_BUFFER"/> are outside the read window associated with the 
		/// currentrendering context, then the values obtained for those pixels are undefined. 
		/// No change is made to the internalformat, width, or border parameters of the specified texture array or to texel values 
		/// outsidethe specified subregion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if /<paramref name="target"/> is not <see cref="Gl.TEXTURE_1D"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage1D or 
		///   Gl.CopyTexImage1Doperation. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, or xoffset+width&gt;w-b, where w is the <see 
		///   cref="Gl.TEXTURE_WIDTH"/>and b is the <see cref="Gl.TEXTURE_BORDER"/> of the texture image being modified. Note that w 
		///   includestwice the border width. 
		/// -  
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void CopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			if        (Delegates.pglCopyTexSubImage1D != null) {
				Delegates.pglCopyTexSubImage1D((int)target, level, xoffset, x, y, width);
				CallLog("glCopyTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			} else if (Delegates.pglCopyTexSubImage1DEXT != null) {
				Delegates.pglCopyTexSubImage1DEXT((int)target, level, xoffset, x, y, width);
				CallLog("glCopyTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			} else
				throw new NotImplementedException("glCopyTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage2D"/> replaces a rectangular portion of a two-dimensional texture image or cube-map texture 
		/// imagewith pixels from the current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for 
		/// Gl.TexSubImage2D).
		/// The screen-aligned pixel rectangle with lower left corner at xy and with width <paramref name="width"/> and height 
		/// <paramrefname="height"/> replaces the portion of the texture array with x indices <paramref name="xoffset"/> through 
		/// xoffset+width-1,inclusive, and y indices <paramref name="yoffset"/> through yoffset+height-1, inclusive, at the mipmap 
		/// levelspecified by <paramref name="level"/>. 
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// finalconversion. At this point, all pixel component values are clamped to the range 01 and then converted to the 
		/// texture'sinternal format for storage in the texel array. 
		/// The destination rectangle in the texture array may not include any texels outside the texture array as it was originally 
		/// specified.It is not an error to specify a subtexture with zero width or height, but such a specification has no effect. 
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the read 
		/// windowassociated with the current rendering context, then the values obtained for those pixels are undefined. 
		/// No change is made to the internalformat, width, height, or border parameters of the specified texture array or to texel 
		/// valuesoutside the specified subregion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,or <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage2D or 
		///   Gl.CopyTexImage2Doperation. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or 
		///   yoffset+height&gt;h-b,where w is the <see cref="Gl.TEXTURE_WIDTH"/>, h is the <see cref="Gl.TEXTURE_HEIGHT"/>, and b is 
		///   the<see cref="Gl.TEXTURE_BORDER"/> of the texture image being modified. Note that w and h include twice the border 
		///   width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexSubImage2D"/> is executed between the execution 
		///   ofGl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyTexSubImage2D != null) {
				Delegates.pglCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
				CallLog("glCopyTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage2DEXT != null) {
				Delegates.pglCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
				CallLog("glCopyTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage2D"/> replaces a rectangular portion of a two-dimensional texture image or cube-map texture 
		/// imagewith pixels from the current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for 
		/// Gl.TexSubImage2D).
		/// The screen-aligned pixel rectangle with lower left corner at xy and with width <paramref name="width"/> and height 
		/// <paramrefname="height"/> replaces the portion of the texture array with x indices <paramref name="xoffset"/> through 
		/// xoffset+width-1,inclusive, and y indices <paramref name="yoffset"/> through yoffset+height-1, inclusive, at the mipmap 
		/// levelspecified by <paramref name="level"/>. 
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// finalconversion. At this point, all pixel component values are clamped to the range 01 and then converted to the 
		/// texture'sinternal format for storage in the texel array. 
		/// The destination rectangle in the texture array may not include any texels outside the texture array as it was originally 
		/// specified.It is not an error to specify a subtexture with zero width or height, but such a specification has no effect. 
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the read 
		/// windowassociated with the current rendering context, then the values obtained for those pixels are undefined. 
		/// No change is made to the internalformat, width, height, or border parameters of the specified texture array or to texel 
		/// valuesoutside the specified subregion. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,or <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage2D or 
		///   Gl.CopyTexImage2Doperation. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or 
		///   yoffset+height&gt;h-b,where w is the <see cref="Gl.TEXTURE_WIDTH"/>, h is the <see cref="Gl.TEXTURE_HEIGHT"/>, and b is 
		///   the<see cref="Gl.TEXTURE_BORDER"/> of the texture image being modified. Note that w and h include twice the border 
		///   width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexSubImage2D"/> is executed between the execution 
		///   ofGl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void CopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyTexSubImage2D != null) {
				Delegates.pglCopyTexSubImage2D((int)target, level, xoffset, yoffset, x, y, width, height);
				CallLog("glCopyTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage2DEXT != null) {
				Delegates.pglCopyTexSubImage2DEXT((int)target, level, xoffset, yoffset, x, y, width, height);
				CallLog("glCopyTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage1D. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableor disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D. 
		/// glTexSubImage1D and glTextureSubImage1D redefine a contiguous subregion of an existing one-dimensional texture image. 
		/// Thetexels referenced by pixels replace the portion of the existing texture array with x indices xoffset and 
		/// xoffset+width-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the allowable values. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage1D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the GL_TEXTURE_WIDTH, and b is 
		///   thewidth of the GL_TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width. 
		/// - GL_INVALID_VALUE is generated if width is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage1D != null) {
				Delegates.pglTexSubImage1D(target, level, xoffset, width, format, type, pixels);
				CallLog("glTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, type, pixels);
			} else if (Delegates.pglTexSubImage1DEXT != null) {
				Delegates.pglTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
				CallLog("glTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage1D. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableor disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D. 
		/// glTexSubImage1D and glTextureSubImage1D redefine a contiguous subregion of an existing one-dimensional texture image. 
		/// Thetexels referenced by pixels replace the portion of the existing texture array with x indices xoffset and 
		/// xoffset+width-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the allowable values. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage1D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the GL_TEXTURE_WIDTH, and b is 
		///   thewidth of the GL_TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width. 
		/// - GL_INVALID_VALUE is generated if width is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage1D != null) {
				Delegates.pglTexSubImage1D((int)target, level, xoffset, width, (int)format, (int)type, pixels);
				CallLog("glTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, type, pixels);
			} else if (Delegates.pglTexSubImage1DEXT != null) {
				Delegates.pglTexSubImage1DEXT((int)target, level, xoffset, width, (int)format, (int)type, pixels);
				CallLog("glTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage1D. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableor disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D. 
		/// glTexSubImage1D and glTextureSubImage1D redefine a contiguous subregion of an existing one-dimensional texture image. 
		/// Thetexels referenced by pixels replace the portion of the existing texture array with x indices xoffset and 
		/// xoffset+width-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the allowable values. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage1D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the GL_TEXTURE_WIDTH, and b is 
		///   thewidth of the GL_TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width. 
		/// - GL_INVALID_VALUE is generated if width is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage1D(target, level, xoffset, width, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage2D. Must be GL_TEXTURE_2D, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage2D and glTextureSubImage2D redefine a contiguous subregion of an existing two-dimensional or 
		/// one-dimensionalarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, and y indices yoffset and yoffset+height-1, inclusive. This region 
		/// maynot include any texels outside the range of the texture array as it was originally specified. It is not an error to 
		/// specifya subtexture with zero width or height, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_2D, 
		///   GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		///   GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage2D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		///   isthe GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		///   thatw and h include twice the border width. 
		/// - GL_INVALID_VALUE is generated if width or height is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage2D != null) {
				Delegates.pglTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
				CallLog("glTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, type, pixels);
			} else if (Delegates.pglTexSubImage2DEXT != null) {
				Delegates.pglTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
				CallLog("glTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage2D. Must be GL_TEXTURE_2D, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage2D and glTextureSubImage2D redefine a contiguous subregion of an existing two-dimensional or 
		/// one-dimensionalarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, and y indices yoffset and yoffset+height-1, inclusive. This region 
		/// maynot include any texels outside the range of the texture array as it was originally specified. It is not an error to 
		/// specifya subtexture with zero width or height, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_2D, 
		///   GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		///   GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage2D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		///   isthe GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		///   thatw and h include twice the border width. 
		/// - GL_INVALID_VALUE is generated if width or height is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage2D != null) {
				Delegates.pglTexSubImage2D((int)target, level, xoffset, yoffset, width, height, (int)format, (int)type, pixels);
				CallLog("glTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, type, pixels);
			} else if (Delegates.pglTexSubImage2DEXT != null) {
				Delegates.pglTexSubImage2DEXT((int)target, level, xoffset, yoffset, width, height, (int)format, (int)type, pixels);
				CallLog("glTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage2D. Must be GL_TEXTURE_2D, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage2D and glTextureSubImage2D redefine a contiguous subregion of an existing two-dimensional or 
		/// one-dimensionalarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, and y indices yoffset and yoffset+height-1, inclusive. This region 
		/// maynot include any texels outside the range of the texture array as it was originally specified. It is not an error to 
		/// specifya subtexture with zero width or height, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_2D, 
		///   GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		///   GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage2D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		///   isthe GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		///   thatw and h include twice the border width. 
		/// - GL_INVALID_VALUE is generated if width or height is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// bind a named texture to a texturing target
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, 
		/// GL_TEXTURE_1D_ARRAY,GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_BUFFER,GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of a texture. 
		/// </param>
		/// <remarks>
		/// glBindTexture lets you create or use a named texture. Calling glBindTexture with target set to GL_TEXTURE_1D, 
		/// GL_TEXTURE_2D,GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, 
		/// GL_TEXTURE_CUBE_MAP_ARRAY,GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY and texture 
		/// setto the name of the new texture binds the texture name to the target. When a texture is bound to a target, the 
		/// previousbinding for that target is automatically broken. 
		/// Texture names are unsigned integers. The value zero is reserved to represent the default texture for each texture 
		/// target.Texture names and the corresponding texture contents are local to the shared object space of the current GL 
		/// renderingcontext; two rendering contexts share texture names only if they explicitly enable sharing between contexts 
		/// throughthe appropriate GL windows interfaces functions. 
		/// You must use glGenTextures to generate a set of new texture names. 
		/// When a texture is first bound, it assumes the specified target: A texture first bound to GL_TEXTURE_1D becomes 
		/// one-dimensionaltexture, a texture first bound to GL_TEXTURE_2D becomes two-dimensional texture, a texture first bound to 
		/// GL_TEXTURE_3Dbecomes three-dimensional texture, a texture first bound to GL_TEXTURE_1D_ARRAY becomes one-dimensional 
		/// arraytexture, a texture first bound to GL_TEXTURE_2D_ARRAY becomes two-dimensional array texture, a texture first bound 
		/// toGL_TEXTURE_RECTANGLE becomes rectangle texture, a texture first bound to GL_TEXTURE_CUBE_MAP becomes a cube-mapped 
		/// texture,a texture first bound to GL_TEXTURE_CUBE_MAP_ARRAY becomes a cube-mapped array texture, a texture first bound to 
		/// GL_TEXTURE_BUFFERbecomes a buffer texture, a texture first bound to GL_TEXTURE_2D_MULTISAMPLE becomes a two-dimensional 
		/// multisampledtexture, and a texture first bound to GL_TEXTURE_2D_MULTISAMPLE_ARRAY becomes a two-dimensional multisampled 
		/// arraytexture. The state of a one-dimensional texture immediately after it is first bound is equivalent to the state of 
		/// thedefault GL_TEXTURE_1D at GL initialization, and similarly for the other texture types. 
		/// While a texture is bound, GL operations on the target to which it is bound affect the bound texture, and queries of the 
		/// targetto which it is bound return state from the bound texture. In effect, the texture targets become aliases for the 
		/// texturescurrently bound to them, and the texture name zero refers to the default textures that were bound to them at 
		/// initialization.
		/// A texture binding created with glBindTexture remains active until a different texture is bound to the same target, or 
		/// untilthe bound texture is deleted with glDeleteTextures. 
		/// Once created, a named texture may be re-bound to its same original target as often as needed. It is usually much faster 
		/// touse glBindTexture to bind an existing named texture to one of the texture targets than it is to reload the texture 
		/// imageusing glTexImage1D, glTexImage2D, glTexImage3D or another similar function. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the allowable values. 
		/// - GL_INVALID_VALUE is generated if target is not a name returned from a previous call to glGenTextures. 
		/// - GL_INVALID_OPERATION is generated if texture was previously created with a target that doesn't match that of target. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BINDING_1D, GL_TEXTURE_BINDING_2D, GL_TEXTURE_BINDING_3D, GL_TEXTURE_BINDING_1D_ARRAY, 
		///   GL_TEXTURE_BINDING_2D_ARRAY,GL_TEXTURE_BINDING_RECTANGLE, GL_TEXTURE_BINDING_BUFFER, GL_TEXTURE_BINDING_CUBE_MAP, 
		///   GL_TEXTURE_BINDING_CUBE_MAP,GL_TEXTURE_BINDING_CUBE_MAP_ARRAY, GL_TEXTURE_BINDING_2D_MULTISAMPLE, or 
		///   GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void BindTexture(int target, UInt32 texture)
		{
			if        (Delegates.pglBindTexture != null) {
				Delegates.pglBindTexture(target, texture);
				CallLog("glBindTexture({0}, {1})", target, texture);
			} else if (Delegates.pglBindTextureEXT != null) {
				Delegates.pglBindTextureEXT(target, texture);
				CallLog("glBindTextureEXT({0}, {1})", target, texture);
			} else
				throw new NotImplementedException("glBindTexture (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a named texture to a texturing target
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, 
		/// GL_TEXTURE_1D_ARRAY,GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_BUFFER,GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of a texture. 
		/// </param>
		/// <remarks>
		/// glBindTexture lets you create or use a named texture. Calling glBindTexture with target set to GL_TEXTURE_1D, 
		/// GL_TEXTURE_2D,GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, 
		/// GL_TEXTURE_CUBE_MAP_ARRAY,GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY and texture 
		/// setto the name of the new texture binds the texture name to the target. When a texture is bound to a target, the 
		/// previousbinding for that target is automatically broken. 
		/// Texture names are unsigned integers. The value zero is reserved to represent the default texture for each texture 
		/// target.Texture names and the corresponding texture contents are local to the shared object space of the current GL 
		/// renderingcontext; two rendering contexts share texture names only if they explicitly enable sharing between contexts 
		/// throughthe appropriate GL windows interfaces functions. 
		/// You must use glGenTextures to generate a set of new texture names. 
		/// When a texture is first bound, it assumes the specified target: A texture first bound to GL_TEXTURE_1D becomes 
		/// one-dimensionaltexture, a texture first bound to GL_TEXTURE_2D becomes two-dimensional texture, a texture first bound to 
		/// GL_TEXTURE_3Dbecomes three-dimensional texture, a texture first bound to GL_TEXTURE_1D_ARRAY becomes one-dimensional 
		/// arraytexture, a texture first bound to GL_TEXTURE_2D_ARRAY becomes two-dimensional array texture, a texture first bound 
		/// toGL_TEXTURE_RECTANGLE becomes rectangle texture, a texture first bound to GL_TEXTURE_CUBE_MAP becomes a cube-mapped 
		/// texture,a texture first bound to GL_TEXTURE_CUBE_MAP_ARRAY becomes a cube-mapped array texture, a texture first bound to 
		/// GL_TEXTURE_BUFFERbecomes a buffer texture, a texture first bound to GL_TEXTURE_2D_MULTISAMPLE becomes a two-dimensional 
		/// multisampledtexture, and a texture first bound to GL_TEXTURE_2D_MULTISAMPLE_ARRAY becomes a two-dimensional multisampled 
		/// arraytexture. The state of a one-dimensional texture immediately after it is first bound is equivalent to the state of 
		/// thedefault GL_TEXTURE_1D at GL initialization, and similarly for the other texture types. 
		/// While a texture is bound, GL operations on the target to which it is bound affect the bound texture, and queries of the 
		/// targetto which it is bound return state from the bound texture. In effect, the texture targets become aliases for the 
		/// texturescurrently bound to them, and the texture name zero refers to the default textures that were bound to them at 
		/// initialization.
		/// A texture binding created with glBindTexture remains active until a different texture is bound to the same target, or 
		/// untilthe bound texture is deleted with glDeleteTextures. 
		/// Once created, a named texture may be re-bound to its same original target as often as needed. It is usually much faster 
		/// touse glBindTexture to bind an existing named texture to one of the texture targets than it is to reload the texture 
		/// imageusing glTexImage1D, glTexImage2D, glTexImage3D or another similar function. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the allowable values. 
		/// - GL_INVALID_VALUE is generated if target is not a name returned from a previous call to glGenTextures. 
		/// - GL_INVALID_OPERATION is generated if texture was previously created with a target that doesn't match that of target. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BINDING_1D, GL_TEXTURE_BINDING_2D, GL_TEXTURE_BINDING_3D, GL_TEXTURE_BINDING_1D_ARRAY, 
		///   GL_TEXTURE_BINDING_2D_ARRAY,GL_TEXTURE_BINDING_RECTANGLE, GL_TEXTURE_BINDING_BUFFER, GL_TEXTURE_BINDING_CUBE_MAP, 
		///   GL_TEXTURE_BINDING_CUBE_MAP,GL_TEXTURE_BINDING_CUBE_MAP_ARRAY, GL_TEXTURE_BINDING_2D_MULTISAMPLE, or 
		///   GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void BindTexture(TextureTarget target, UInt32 texture)
		{
			if        (Delegates.pglBindTexture != null) {
				Delegates.pglBindTexture((int)target, texture);
				CallLog("glBindTexture({0}, {1})", target, texture);
			} else if (Delegates.pglBindTextureEXT != null) {
				Delegates.pglBindTextureEXT((int)target, texture);
				CallLog("glBindTextureEXT({0}, {1})", target, texture);
			} else
				throw new NotImplementedException("glBindTexture (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// delete named textures
		/// </summary>
		/// <param name="n">
		/// Specifies the number of textures to be deleted. 
		/// </param>
		/// <param name="textures">
		/// Specifies an array of textures to be deleted. 
		/// </param>
		/// <remarks>
		/// glDeleteTextures deletes n textures named by the elements of the array textures. After a texture is deleted, it has no 
		/// contentsor dimensionality, and its name is free for reuse (for example by glGenTextures). If a texture that is currently 
		/// boundis deleted, the binding reverts to 0 (the default texture). 
		/// glDeleteTextures silently ignores 0's and names that do not correspond to existing textures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsTexture 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void DeleteTextures(Int32 n, UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTextures != null, "pglDeleteTextures not implemented");
					Delegates.pglDeleteTextures(n, p_textures);
					CallLog("glDeleteTextures({0}, {1})", n, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate texture names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of texture names to be generated. 
		/// </param>
		/// <param name="textures">
		/// Specifies an array in which the generated texture names are stored. 
		/// </param>
		/// <remarks>
		/// glGenTextures returns n texture names in textures. There is no guarantee that the names form a contiguous set of 
		/// integers;however, it is guaranteed that none of the returned names was in use immediately before the call to 
		/// glGenTextures.
		/// The generated textures have no dimensionality; they assume the dimensionality of the texture target to which they are 
		/// firstbound (see glBindTexture). 
		/// Texture names returned by a call to glGenTextures are not returned by subsequent calls, unless they are first deleted 
		/// withglDeleteTextures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsTexture 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GenTextures(Int32 n, UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTextures != null, "pglGenTextures not implemented");
					Delegates.pglGenTextures(n, p_textures);
					CallLog("glGenTextures({0}, {1})", n, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a texture
		/// </summary>
		/// <param name="texture">
		/// Specifies a value that may be the name of a texture. 
		/// </param>
		/// <remarks>
		/// glIsTexture returns GL_TRUE if texture is currently the name of a texture. If texture is zero, or is a non-zero value 
		/// thatis not currently the name of a texture, or if an error occurs, glIsTexture returns GL_FALSE. 
		/// A name returned by glGenTextures, but not yet associated with a texture by calling glBindTexture, is not the name of a 
		/// texture.
		/// </remarks>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static bool IsTexture(UInt32 texture)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTexture != null, "pglIsTexture not implemented");
			retValue = Delegates.pglIsTexture(texture);
			CallLog("glIsTexture({0}) = {1}", texture, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glArrayElement.
		/// </summary>
		/// <param name="i">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ArrayElement(Int32 i)
		{
			if        (Delegates.pglArrayElement != null) {
				Delegates.pglArrayElement(i);
				CallLog("glArrayElement({0})", i);
			} else if (Delegates.pglArrayElementEXT != null) {
				Delegates.pglArrayElementEXT(i);
				CallLog("glArrayElementEXT({0})", i);
			} else
				throw new NotImplementedException("glArrayElement (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void ColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointer != null, "pglColorPointer not implemented");
			Delegates.pglColorPointer(size, type, stride, pointer);
			CallLog("glColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointer != null, "pglColorPointer not implemented");
			Delegates.pglColorPointer(size, (int)type, stride, pointer);
			CallLog("glColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void ColorPointer(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glDisableClientState.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void DisableClientState(int array)
		{
			Debug.Assert(Delegates.pglDisableClientState != null, "pglDisableClientState not implemented");
			Delegates.pglDisableClientState(array);
			CallLog("glDisableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableClientState.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void DisableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglDisableClientState != null, "pglDisableClientState not implemented");
			Delegates.pglDisableClientState((int)array);
			CallLog("glDisableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEdgeFlagPointer.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EdgeFlagPointer(Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglEdgeFlagPointer != null, "pglEdgeFlagPointer not implemented");
			Delegates.pglEdgeFlagPointer(stride, pointer);
			CallLog("glEdgeFlagPointer({0}, {1})", stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEdgeFlagPointer.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EdgeFlagPointer(Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				EdgeFlagPointer(stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glEnableClientState.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EnableClientState(int array)
		{
			Debug.Assert(Delegates.pglEnableClientState != null, "pglEnableClientState not implemented");
			Delegates.pglEnableClientState(array);
			CallLog("glEnableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableClientState.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EnableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglEnableClientState != null, "pglEnableClientState not implemented");
			Delegates.pglEnableClientState((int)array);
			CallLog("glEnableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void IndexPointer(int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointer != null, "pglIndexPointer not implemented");
			Delegates.pglIndexPointer(type, stride, pointer);
			CallLog("glIndexPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void IndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointer != null, "pglIndexPointer not implemented");
			Delegates.pglIndexPointer((int)type, stride, pointer);
			CallLog("glIndexPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void IndexPointer(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				IndexPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glInterleavedArrays.
		/// </summary>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void InterleavedArrays(int format, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglInterleavedArrays != null, "pglInterleavedArrays not implemented");
			Delegates.pglInterleavedArrays(format, stride, pointer);
			CallLog("glInterleavedArrays({0}, {1}, {2})", format, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glInterleavedArrays.
		/// </summary>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void InterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglInterleavedArrays != null, "pglInterleavedArrays not implemented");
			Delegates.pglInterleavedArrays((int)format, stride, pointer);
			CallLog("glInterleavedArrays({0}, {1}, {2})", format, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glInterleavedArrays.
		/// </summary>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void InterleavedArrays(int format, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				InterleavedArrays(format, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glNormalPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void NormalPointer(int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointer != null, "pglNormalPointer not implemented");
			Delegates.pglNormalPointer(type, stride, pointer);
			CallLog("glNormalPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void NormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointer != null, "pglNormalPointer not implemented");
			Delegates.pglNormalPointer((int)type, stride, pointer);
			CallLog("glNormalPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalPointer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void NormalPointer(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				NormalPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glTexCoordPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void TexCoordPointer(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointer != null, "pglTexCoordPointer not implemented");
			Delegates.pglTexCoordPointer(size, type, stride, pointer);
			CallLog("glTexCoordPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void TexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointer != null, "pglTexCoordPointer not implemented");
			Delegates.pglTexCoordPointer(size, (int)type, stride, pointer);
			CallLog("glTexCoordPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void TexCoordPointer(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TexCoordPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void VertexPointer(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointer != null, "pglVertexPointer not implemented");
			Delegates.pglVertexPointer(size, type, stride, pointer);
			CallLog("glVertexPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointer != null, "pglVertexPointer not implemented");
			Delegates.pglVertexPointer(size, (int)type, stride, pointer);
			CallLog("glVertexPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexPointer.
		/// </summary>
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
		/// <remarks>
		/// </remarks>
		public static void VertexPointer(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glAreTexturesResident.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static bool AreTexturesResident(Int32 n, UInt32[] textures, bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResident != null, "pglAreTexturesResident not implemented");
					retValue = Delegates.pglAreTexturesResident(n, p_textures, p_residences);
					CallLog("glAreTexturesResident({0}, {1}, {2}) = {3}", n, textures, residences, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPrioritizeTextures.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="priorities">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PrioritizeTextures(Int32 n, UInt32[] textures, float[] priorities)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (float* p_priorities = priorities)
				{
					if        (Delegates.pglPrioritizeTextures != null) {
						Delegates.pglPrioritizeTextures(n, p_textures, p_priorities);
						CallLog("glPrioritizeTextures({0}, {1}, {2})", n, textures, priorities);
					} else if (Delegates.pglPrioritizeTexturesEXT != null) {
						Delegates.pglPrioritizeTexturesEXT(n, p_textures, p_priorities);
						CallLog("glPrioritizeTexturesEXT({0}, {1}, {2})", n, textures, priorities);
					} else
						throw new NotImplementedException("glPrioritizeTextures (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexub.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(byte c)
		{
			Debug.Assert(Delegates.pglIndexub != null, "pglIndexub not implemented");
			Delegates.pglIndexub(c);
			CallLog("glIndexub({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexubv.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(byte[] c)
		{
			unsafe {
				fixed (byte* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexubv != null, "pglIndexubv not implemented");
					Delegates.pglIndexubv(p_c);
					CallLog("glIndexubv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopClientAttrib.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void PopClientAttrib()
		{
			Debug.Assert(Delegates.pglPopClientAttrib != null, "pglPopClientAttrib not implemented");
			Delegates.pglPopClientAttrib();
			CallLog("glPopClientAttrib()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushClientAttrib.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PushClientAttrib(uint mask)
		{
			Debug.Assert(Delegates.pglPushClientAttrib != null, "pglPushClientAttrib not implemented");
			Delegates.pglPushClientAttrib(mask);
			CallLog("glPushClientAttrib({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushClientAttrib.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PushClientAttrib(ClientAttribMask mask)
		{
			Debug.Assert(Delegates.pglPushClientAttrib != null, "pglPushClientAttrib not implemented");
			Delegates.pglPushClientAttrib((uint)mask);
			CallLog("glPushClientAttrib({0})", mask);
			DebugCheckErrors();
		}

	}

}
