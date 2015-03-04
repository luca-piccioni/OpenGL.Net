
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
		/// Value of GL_COVERAGE_BUFFER_BIT_NV symbol.
		/// </summary>
		public const uint COVERAGE_BUFFER_BIT_NV = 0x00008000;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_DEBUG_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const uint CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002;

		/// <summary>
		/// Value of GL_MAP_READ_BIT_EXT symbol.
		/// </summary>
		public const int MAP_READ_BIT_EXT = 0x0001;

		/// <summary>
		/// Value of GL_MAP_WRITE_BIT_EXT symbol.
		/// </summary>
		public const int MAP_WRITE_BIT_EXT = 0x0002;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_RANGE_BIT_EXT symbol.
		/// </summary>
		public const int MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_BUFFER_BIT_EXT symbol.
		/// </summary>
		public const int MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;

		/// <summary>
		/// Value of GL_MAP_FLUSH_EXPLICIT_BIT_EXT symbol.
		/// </summary>
		public const int MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;

		/// <summary>
		/// Value of GL_MAP_UNSYNCHRONIZED_BIT_EXT symbol.
		/// </summary>
		public const int MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;

		/// <summary>
		/// Value of GL_SYNC_FLUSH_COMMANDS_BIT_APPLE symbol.
		/// </summary>
		public const uint SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const uint VERTEX_SHADER_BIT_EXT = 0x00000001;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const uint FRAGMENT_SHADER_BIT_EXT = 0x00000002;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_BIT_EXT symbol.
		/// </summary>
		public const uint GEOMETRY_SHADER_BIT_EXT = 0x00000004;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_BIT_OES symbol.
		/// </summary>
		public const uint GEOMETRY_SHADER_BIT_OES = 0x00000004;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_BIT_EXT symbol.
		/// </summary>
		public const uint TESS_CONTROL_SHADER_BIT_EXT = 0x00000008;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_BIT_OES symbol.
		/// </summary>
		public const uint TESS_CONTROL_SHADER_BIT_OES = 0x00000008;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_BIT_EXT symbol.
		/// </summary>
		public const uint TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_BIT_OES symbol.
		/// </summary>
		public const uint TESS_EVALUATION_SHADER_BIT_OES = 0x00000010;

		/// <summary>
		/// Value of GL_ALL_SHADER_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const uint ALL_SHADER_BITS_EXT = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_TRACE_OPERATIONS_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_OPERATIONS_BIT_MESA = 0x0001;

		/// <summary>
		/// Value of GL_TRACE_PRIMITIVES_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_PRIMITIVES_BIT_MESA = 0x0002;

		/// <summary>
		/// Value of GL_TRACE_ARRAYS_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_ARRAYS_BIT_MESA = 0x0004;

		/// <summary>
		/// Value of GL_TRACE_TEXTURES_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_TEXTURES_BIT_MESA = 0x0008;

		/// <summary>
		/// Value of GL_TRACE_PIXELS_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_PIXELS_BIT_MESA = 0x0010;

		/// <summary>
		/// Value of GL_TRACE_ERRORS_BIT_MESA symbol.
		/// </summary>
		public const int TRACE_ERRORS_BIT_MESA = 0x0020;

		/// <summary>
		/// Value of GL_TRACE_ALL_BITS_MESA symbol.
		/// </summary>
		public const int TRACE_ALL_BITS_MESA = 0xFFFF;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT0_QCOM = 0x00000001;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT1_QCOM = 0x00000002;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT2_QCOM = 0x00000004;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT3_QCOM = 0x00000008;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT4_QCOM = 0x00000010;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT5_QCOM = 0x00000020;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT6_QCOM = 0x00000040;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		public const uint COLOR_BUFFER_BIT7_QCOM = 0x00000080;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT0_QCOM = 0x00000100;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT1_QCOM = 0x00000200;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT2_QCOM = 0x00000400;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT3_QCOM = 0x00000800;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT4_QCOM = 0x00001000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT5_QCOM = 0x00002000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT6_QCOM = 0x00004000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		public const uint DEPTH_BUFFER_BIT7_QCOM = 0x00008000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT0_QCOM = 0x00010000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT1_QCOM = 0x00020000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT2_QCOM = 0x00040000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT3_QCOM = 0x00080000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT4_QCOM = 0x00100000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT5_QCOM = 0x00200000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT6_QCOM = 0x00400000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		public const uint STENCIL_BUFFER_BIT7_QCOM = 0x00800000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		public const uint MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000;

		/// <summary>
		/// Value of GL_NONE_OES symbol.
		/// </summary>
		public const int NONE_OES = 0;

		/// <summary>
		/// Value of GL_TIMEOUT_IGNORED_APPLE symbol.
		/// </summary>
		public const ulong TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// Value of GL_VERSION_ES_CL_1_0 symbol.
		/// </summary>
		public const int VERSION_ES_CL_1_0 = 1;

		/// <summary>
		/// Value of GL_VERSION_ES_CM_1_1 symbol.
		/// </summary>
		public const int VERSION_ES_CM_1_1 = 1;

		/// <summary>
		/// Value of GL_VERSION_ES_CL_1_1 symbol.
		/// </summary>
		public const int VERSION_ES_CL_1_1 = 1;

		/// <summary>
		/// Value of GL_QUADS_EXT symbol.
		/// </summary>
		public const int QUADS_EXT = 0x0007;

		/// <summary>
		/// Value of GL_QUADS_OES symbol.
		/// </summary>
		public const int QUADS_OES = 0x0007;

		/// <summary>
		/// Value of GL_LINES_ADJACENCY_OES symbol.
		/// </summary>
		public const int LINES_ADJACENCY_OES = 0x000A;

		/// <summary>
		/// Value of GL_LINE_STRIP_ADJACENCY_OES symbol.
		/// </summary>
		public const int LINE_STRIP_ADJACENCY_OES = 0x000B;

		/// <summary>
		/// Value of GL_TRIANGLES_ADJACENCY_OES symbol.
		/// </summary>
		public const int TRIANGLES_ADJACENCY_OES = 0x000C;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP_ADJACENCY_OES symbol.
		/// </summary>
		public const int TRIANGLE_STRIP_ADJACENCY_OES = 0x000D;

		/// <summary>
		/// Value of GL_PATCHES_EXT symbol.
		/// </summary>
		public const int PATCHES_EXT = 0x000E;

		/// <summary>
		/// Value of GL_PATCHES_OES symbol.
		/// </summary>
		public const int PATCHES_OES = 0x000E;

		/// <summary>
		/// Value of GL_STACK_OVERFLOW_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int STACK_OVERFLOW_KHR = 0x0503;

		/// <summary>
		/// Value of GL_STACK_UNDERFLOW_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int STACK_UNDERFLOW_KHR = 0x0504;

		/// <summary>
		/// Value of GL_INVALID_FRAMEBUFFER_OPERATION_OES symbol.
		/// </summary>
		public const int INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506;

		/// <summary>
		/// Value of GL_CONTEXT_LOST_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int CONTEXT_LOST_KHR = 0x0507;

		/// <summary>
		/// Value of GL_ALPHA_TEST_QCOM symbol.
		/// </summary>
		public const int ALPHA_TEST_QCOM = 0x0BC0;

		/// <summary>
		/// Value of GL_ALPHA_TEST_FUNC_QCOM symbol.
		/// </summary>
		public const int ALPHA_TEST_FUNC_QCOM = 0x0BC1;

		/// <summary>
		/// Value of GL_ALPHA_TEST_REF_QCOM symbol.
		/// </summary>
		public const int ALPHA_TEST_REF_QCOM = 0x0BC2;

		/// <summary>
		/// Value of GL_DRAW_BUFFER_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER_EXT = 0x0C01;

		/// <summary>
		/// Value of GL_READ_BUFFER_EXT symbol.
		/// </summary>
		public const int READ_BUFFER_EXT = 0x0C02;

		/// <summary>
		/// Value of GL_READ_BUFFER_NV symbol.
		/// </summary>
		public const int READ_BUFFER_NV = 0x0C02;

		/// <summary>
		/// Value of GL_UNPACK_ROW_LENGTH_EXT symbol.
		/// </summary>
		public const int UNPACK_ROW_LENGTH_EXT = 0x0CF2;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_ROWS_EXT symbol.
		/// </summary>
		public const int UNPACK_SKIP_ROWS_EXT = 0x0CF3;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_PIXELS_EXT symbol.
		/// </summary>
		public const int UNPACK_SKIP_PIXELS_EXT = 0x0CF4;

		/// <summary>
		/// Value of GL_MAX_CLIP_PLANES_IMG symbol.
		/// </summary>
		public const int MAX_CLIP_PLANES_IMG = 0x0D32;

		/// <summary>
		/// Value of GL_MAX_CLIP_DISTANCES_APPLE symbol.
		/// </summary>
		public const int MAX_CLIP_DISTANCES_APPLE = 0x0D32;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER_COLOR_EXT symbol.
		/// </summary>
		public const int TEXTURE_BORDER_COLOR_EXT = 0x1004;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER_COLOR_NV symbol.
		/// </summary>
		public const int TEXTURE_BORDER_COLOR_NV = 0x1004;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER_COLOR_OES symbol.
		/// </summary>
		public const int TEXTURE_BORDER_COLOR_OES = 0x1004;

		/// <summary>
		/// Value of GL_DOUBLE_EXT symbol.
		/// </summary>
		public const int DOUBLE_EXT = 0x140A;

		/// <summary>
		/// Value of GL_COLOR_EXT symbol.
		/// </summary>
		public const int COLOR_EXT = 0x1800;

		/// <summary>
		/// Value of GL_DEPTH_EXT symbol.
		/// </summary>
		public const int DEPTH_EXT = 0x1801;

		/// <summary>
		/// Value of GL_STENCIL_EXT symbol.
		/// </summary>
		public const int STENCIL_EXT = 0x1802;

		/// <summary>
		/// Value of GL_STENCIL_INDEX_OES symbol.
		/// </summary>
		public const int STENCIL_INDEX_OES = 0x1901;

		/// <summary>
		/// Value of GL_RED_EXT symbol.
		/// </summary>
		public const int RED_EXT = 0x1903;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_MODE_OES symbol.
		/// </summary>
		public const int TEXTURE_GEN_MODE_OES = 0x2500;

		/// <summary>
		/// Value of GL_CLIP_PLANE0_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE0_IMG = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE0_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE0_APPLE = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_PLANE1_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE1_IMG = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE1_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE1_APPLE = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_PLANE2_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE2_IMG = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE2_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE2_APPLE = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_PLANE3_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE3_IMG = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE3_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE3_APPLE = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_PLANE4_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE4_IMG = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE4_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE4_APPLE = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_PLANE5_IMG symbol.
		/// </summary>
		public const int CLIP_PLANE5_IMG = 0x3005;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE5_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE5_APPLE = 0x3005;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE6_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE6_APPLE = 0x3006;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE7_APPLE symbol.
		/// </summary>
		public const int CLIP_DISTANCE7_APPLE = 0x3007;

		/// <summary>
		/// Value of GL_FUNC_ADD_OES symbol.
		/// </summary>
		public const int FUNC_ADD_OES = 0x8006;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_OES symbol.
		/// </summary>
		public const int BLEND_EQUATION_OES = 0x8009;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_RGB_OES symbol.
		/// </summary>
		public const int BLEND_EQUATION_RGB_OES = 0x8009;

		/// <summary>
		/// Value of GL_FUNC_SUBTRACT_OES symbol.
		/// </summary>
		public const int FUNC_SUBTRACT_OES = 0x800A;

		/// <summary>
		/// Value of GL_FUNC_REVERSE_SUBTRACT_OES symbol.
		/// </summary>
		public const int FUNC_REVERSE_SUBTRACT_OES = 0x800B;

		/// <summary>
		/// Value of GL_ALPHA8_OES symbol.
		/// </summary>
		public const int ALPHA8_OES = 0x803C;

		/// <summary>
		/// Value of GL_LUMINANCE8_OES symbol.
		/// </summary>
		public const int LUMINANCE8_OES = 0x8040;

		/// <summary>
		/// Value of GL_LUMINANCE4_ALPHA4_OES symbol.
		/// </summary>
		public const int LUMINANCE4_ALPHA4_OES = 0x8043;

		/// <summary>
		/// Value of GL_LUMINANCE8_ALPHA8_OES symbol.
		/// </summary>
		public const int LUMINANCE8_ALPHA8_OES = 0x8045;

		/// <summary>
		/// Value of GL_RGB8_OES symbol.
		/// </summary>
		public const int RGB8_OES = 0x8051;

		/// <summary>
		/// Value of GL_RGBA4_OES symbol.
		/// </summary>
		public const int RGBA4_OES = 0x8056;

		/// <summary>
		/// Value of GL_RGB5_A1_OES symbol.
		/// </summary>
		public const int RGB5_A1_OES = 0x8057;

		/// <summary>
		/// Value of GL_RGBA8_OES symbol.
		/// </summary>
		public const int RGBA8_OES = 0x8058;

		/// <summary>
		/// Value of GL_TEXTURE_3D_BINDING_OES symbol.
		/// </summary>
		public const int TEXTURE_3D_BINDING_OES = 0x806A;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_3D_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_3D_OES = 0x806A;

		/// <summary>
		/// Value of GL_TEXTURE_3D_OES symbol.
		/// </summary>
		public const int TEXTURE_3D_OES = 0x806F;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_R_OES symbol.
		/// </summary>
		public const int TEXTURE_WRAP_R_OES = 0x8072;

		/// <summary>
		/// Value of GL_MAX_3D_TEXTURE_SIZE_OES symbol.
		/// </summary>
		public const int MAX_3D_TEXTURE_SIZE_OES = 0x8073;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int VERTEX_ARRAY_KHR = 0x8074;

		/// <summary>
		/// Value of GL_BLEND_DST_RGB_OES symbol.
		/// </summary>
		public const int BLEND_DST_RGB_OES = 0x80C8;

		/// <summary>
		/// Value of GL_BLEND_SRC_RGB_OES symbol.
		/// </summary>
		public const int BLEND_SRC_RGB_OES = 0x80C9;

		/// <summary>
		/// Value of GL_BLEND_DST_ALPHA_OES symbol.
		/// </summary>
		public const int BLEND_DST_ALPHA_OES = 0x80CA;

		/// <summary>
		/// Value of GL_BLEND_SRC_ALPHA_OES symbol.
		/// </summary>
		public const int BLEND_SRC_ALPHA_OES = 0x80CB;

		/// <summary>
		/// Value of GL_BGRA_IMG symbol.
		/// </summary>
		public const int BGRA_IMG = 0x80E1;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER_EXT symbol.
		/// </summary>
		public const int CLAMP_TO_BORDER_EXT = 0x812D;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER_NV symbol.
		/// </summary>
		public const int CLAMP_TO_BORDER_NV = 0x812D;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER_OES symbol.
		/// </summary>
		public const int CLAMP_TO_BORDER_OES = 0x812D;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_LEVEL_APPLE symbol.
		/// </summary>
		public const int TEXTURE_MAX_LEVEL_APPLE = 0x813D;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_Q_CEILING_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_Q_ROUND_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX symbol.
		/// </summary>
		public const int PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT16_OES symbol.
		/// </summary>
		public const int DEPTH_COMPONENT16_OES = 0x81A5;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT24_OES symbol.
		/// </summary>
		public const int DEPTH_COMPONENT24_OES = 0x81A6;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32_OES symbol.
		/// </summary>
		public const int DEPTH_COMPONENT32_OES = 0x81A7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNDEFINED_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_UNDEFINED_OES = 0x8219;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES symbol.
		/// </summary>
		public const int PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES = 0x8221;

		/// <summary>
		/// Value of GL_RG_EXT symbol.
		/// </summary>
		public const int RG_EXT = 0x8227;

		/// <summary>
		/// Value of GL_R8_EXT symbol.
		/// </summary>
		public const int R8_EXT = 0x8229;

		/// <summary>
		/// Value of GL_R16_EXT symbol.
		/// </summary>
		public const int R16_EXT = 0x822A;

		/// <summary>
		/// Value of GL_RG8_EXT symbol.
		/// </summary>
		public const int RG8_EXT = 0x822B;

		/// <summary>
		/// Value of GL_RG16_EXT symbol.
		/// </summary>
		public const int RG16_EXT = 0x822C;

		/// <summary>
		/// Value of GL_R16F_EXT symbol.
		/// </summary>
		public const int R16F_EXT = 0x822D;

		/// <summary>
		/// Value of GL_R32F_EXT symbol.
		/// </summary>
		public const int R32F_EXT = 0x822E;

		/// <summary>
		/// Value of GL_RG16F_EXT symbol.
		/// </summary>
		public const int RG16F_EXT = 0x822F;

		/// <summary>
		/// Value of GL_RG32F_EXT symbol.
		/// </summary>
		public const int RG32F_EXT = 0x8230;

		/// <summary>
		/// Value of GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242;

		/// <summary>
		/// Value of GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_FUNCTION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_CALLBACK_FUNCTION_KHR = 0x8244;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_USER_PARAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_API_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_API_KHR = 0x8246;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_SHADER_COMPILER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_THIRD_PARTY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_APPLICATION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_APPLICATION_KHR = 0x824A;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_OTHER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SOURCE_OTHER_KHR = 0x824B;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_ERROR_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_ERROR_KHR = 0x824C;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PORTABILITY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PORTABILITY_KHR = 0x824F;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PERFORMANCE_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PERFORMANCE_KHR = 0x8250;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_OTHER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_OTHER_KHR = 0x8251;

		/// <summary>
		/// Value of GL_LOSE_CONTEXT_ON_RESET_EXT symbol.
		/// </summary>
		public const int LOSE_CONTEXT_ON_RESET_EXT = 0x8252;

		/// <summary>
		/// Value of GL_LOSE_CONTEXT_ON_RESET_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int LOSE_CONTEXT_ON_RESET_KHR = 0x8252;

		/// <summary>
		/// Value of GL_GUILTY_CONTEXT_RESET_EXT symbol.
		/// </summary>
		public const int GUILTY_CONTEXT_RESET_EXT = 0x8253;

		/// <summary>
		/// Value of GL_GUILTY_CONTEXT_RESET_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int GUILTY_CONTEXT_RESET_KHR = 0x8253;

		/// <summary>
		/// Value of GL_INNOCENT_CONTEXT_RESET_EXT symbol.
		/// </summary>
		public const int INNOCENT_CONTEXT_RESET_EXT = 0x8254;

		/// <summary>
		/// Value of GL_INNOCENT_CONTEXT_RESET_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int INNOCENT_CONTEXT_RESET_KHR = 0x8254;

		/// <summary>
		/// Value of GL_UNKNOWN_CONTEXT_RESET_EXT symbol.
		/// </summary>
		public const int UNKNOWN_CONTEXT_RESET_EXT = 0x8255;

		/// <summary>
		/// Value of GL_UNKNOWN_CONTEXT_RESET_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int UNKNOWN_CONTEXT_RESET_KHR = 0x8255;

		/// <summary>
		/// Value of GL_RESET_NOTIFICATION_STRATEGY_EXT symbol.
		/// </summary>
		public const int RESET_NOTIFICATION_STRATEGY_EXT = 0x8256;

		/// <summary>
		/// Value of GL_RESET_NOTIFICATION_STRATEGY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int RESET_NOTIFICATION_STRATEGY_KHR = 0x8256;

		/// <summary>
		/// Value of GL_PROGRAM_SEPARABLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const int PROGRAM_SEPARABLE_EXT = 0x8258;

		/// <summary>
		/// Value of GL_PROGRAM_PIPELINE_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public const int PROGRAM_PIPELINE_BINDING_EXT = 0x825A;

		/// <summary>
		/// Value of GL_MAX_VIEWPORTS_NV symbol.
		/// </summary>
		public const int MAX_VIEWPORTS_NV = 0x825B;

		/// <summary>
		/// Value of GL_VIEWPORT_SUBPIXEL_BITS_EXT symbol.
		/// </summary>
		public const int VIEWPORT_SUBPIXEL_BITS_EXT = 0x825C;

		/// <summary>
		/// Value of GL_VIEWPORT_SUBPIXEL_BITS_NV symbol.
		/// </summary>
		public const int VIEWPORT_SUBPIXEL_BITS_NV = 0x825C;

		/// <summary>
		/// Value of GL_VIEWPORT_BOUNDS_RANGE_EXT symbol.
		/// </summary>
		public const int VIEWPORT_BOUNDS_RANGE_EXT = 0x825D;

		/// <summary>
		/// Value of GL_VIEWPORT_BOUNDS_RANGE_NV symbol.
		/// </summary>
		public const int VIEWPORT_BOUNDS_RANGE_NV = 0x825D;

		/// <summary>
		/// Value of GL_LAYER_PROVOKING_VERTEX_EXT symbol.
		/// </summary>
		public const int LAYER_PROVOKING_VERTEX_EXT = 0x825E;

		/// <summary>
		/// Value of GL_LAYER_PROVOKING_VERTEX_OES symbol.
		/// </summary>
		public const int LAYER_PROVOKING_VERTEX_OES = 0x825E;

		/// <summary>
		/// Value of GL_VIEWPORT_INDEX_PROVOKING_VERTEX_EXT symbol.
		/// </summary>
		public const int VIEWPORT_INDEX_PROVOKING_VERTEX_EXT = 0x825F;

		/// <summary>
		/// Value of GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV symbol.
		/// </summary>
		public const int VIEWPORT_INDEX_PROVOKING_VERTEX_NV = 0x825F;

		/// <summary>
		/// Value of GL_UNDEFINED_VERTEX_EXT symbol.
		/// </summary>
		public const int UNDEFINED_VERTEX_EXT = 0x8260;

		/// <summary>
		/// Value of GL_UNDEFINED_VERTEX_OES symbol.
		/// </summary>
		public const int UNDEFINED_VERTEX_OES = 0x8260;

		/// <summary>
		/// Value of GL_NO_RESET_NOTIFICATION_EXT symbol.
		/// </summary>
		public const int NO_RESET_NOTIFICATION_EXT = 0x8261;

		/// <summary>
		/// Value of GL_NO_RESET_NOTIFICATION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int NO_RESET_NOTIFICATION_KHR = 0x8261;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_MARKER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_MARKER_KHR = 0x8268;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PUSH_GROUP_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_POP_GROUP_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_TYPE_POP_GROUP_KHR = 0x826A;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_NOTIFICATION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B;

		/// <summary>
		/// Value of GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C;

		/// <summary>
		/// Value of GL_DEBUG_GROUP_STACK_DEPTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LEVEL_EXT symbol.
		/// </summary>
		public const int TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LEVEL_OES symbol.
		/// </summary>
		public const int TEXTURE_VIEW_MIN_LEVEL_OES = 0x82DB;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LEVELS_EXT symbol.
		/// </summary>
		public const int TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LEVELS_OES symbol.
		/// </summary>
		public const int TEXTURE_VIEW_NUM_LEVELS_OES = 0x82DC;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LAYER_EXT symbol.
		/// </summary>
		public const int TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_MIN_LAYER_OES symbol.
		/// </summary>
		public const int TEXTURE_VIEW_MIN_LAYER_OES = 0x82DD;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LAYERS_EXT symbol.
		/// </summary>
		public const int TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;

		/// <summary>
		/// Value of GL_TEXTURE_VIEW_NUM_LAYERS_OES symbol.
		/// </summary>
		public const int TEXTURE_VIEW_NUM_LAYERS_OES = 0x82DE;

		/// <summary>
		/// Value of GL_BUFFER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int BUFFER_KHR = 0x82E0;

		/// <summary>
		/// Value of GL_SHADER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int SHADER_KHR = 0x82E1;

		/// <summary>
		/// Value of GL_PROGRAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int PROGRAM_KHR = 0x82E2;

		/// <summary>
		/// Value of GL_QUERY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int QUERY_KHR = 0x82E3;

		/// <summary>
		/// Value of GL_SAMPLER_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int SAMPLER_KHR = 0x82E6;

		/// <summary>
		/// Value of GL_MAX_LABEL_LENGTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_LABEL_LENGTH_KHR = 0x82E8;

		/// <summary>
		/// Value of GL_CONTEXT_RELEASE_BEHAVIOR_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_context_flush_control")]
		public const int CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB;

		/// <summary>
		/// Value of GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_context_flush_control")]
		public const int CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC;

		/// <summary>
		/// Value of GL_DEPTH_PASS_INSTRUMENT_SGIX symbol.
		/// </summary>
		public const int DEPTH_PASS_INSTRUMENT_SGIX = 0x8310;

		/// <summary>
		/// Value of GL_DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX symbol.
		/// </summary>
		public const int DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311;

		/// <summary>
		/// Value of GL_DEPTH_PASS_INSTRUMENT_MAX_SGIX symbol.
		/// </summary>
		public const int DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312;

		/// <summary>
		/// Value of GL_FRAGMENTS_INSTRUMENT_SGIX symbol.
		/// </summary>
		public const int FRAGMENTS_INSTRUMENT_SGIX = 0x8313;

		/// <summary>
		/// Value of GL_FRAGMENTS_INSTRUMENT_COUNTERS_SGIX symbol.
		/// </summary>
		public const int FRAGMENTS_INSTRUMENT_COUNTERS_SGIX = 0x8314;

		/// <summary>
		/// Value of GL_FRAGMENTS_INSTRUMENT_MAX_SGIX symbol.
		/// </summary>
		public const int FRAGMENTS_INSTRUMENT_MAX_SGIX = 0x8315;

		/// <summary>
		/// Value of GL_UNPACK_COMPRESSED_SIZE_SGIX symbol.
		/// </summary>
		public const int UNPACK_COMPRESSED_SIZE_SGIX = 0x831A;

		/// <summary>
		/// Value of GL_PACK_MAX_COMPRESSED_SIZE_SGIX symbol.
		/// </summary>
		public const int PACK_MAX_COMPRESSED_SIZE_SGIX = 0x831B;

		/// <summary>
		/// Value of GL_PACK_COMPRESSED_SIZE_SGIX symbol.
		/// </summary>
		public const int PACK_COMPRESSED_SIZE_SGIX = 0x831C;

		/// <summary>
		/// Value of GL_SLIM8U_SGIX symbol.
		/// </summary>
		public const int SLIM8U_SGIX = 0x831D;

		/// <summary>
		/// Value of GL_SLIM10U_SGIX symbol.
		/// </summary>
		public const int SLIM10U_SGIX = 0x831E;

		/// <summary>
		/// Value of GL_SLIM12S_SGIX symbol.
		/// </summary>
		public const int SLIM12S_SGIX = 0x831F;

		/// <summary>
		/// Value of GL_LINE_QUALITY_HINT_SGIX symbol.
		/// </summary>
		public const int LINE_QUALITY_HINT_SGIX = 0x835B;

		/// <summary>
		/// Value of GL_UNSIGNED_BYTE_2_3_3_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_BYTE_2_3_3_REV_EXT = 0x8362;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5_EXT symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_5_6_5_EXT = 0x8363;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_5_6_5_REV_EXT = 0x8364;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_INT_8_8_8_8_REV_EXT = 0x8367;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_2_10_10_10_REV_EXT symbol.
		/// </summary>
		public const int UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368;

		/// <summary>
		/// Value of GL_MIRRORED_REPEAT_OES symbol.
		/// </summary>
		public const int MIRRORED_REPEAT_OES = 0x8370;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_S3TC_DXT3_ANGLE = 0x83F2;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_S3TC_DXT5_ANGLE = 0x83F3;

		/// <summary>
		/// Value of GL_MAX_RENDERBUFFER_SIZE_OES symbol.
		/// </summary>
		public const int MAX_RENDERBUFFER_SIZE_OES = 0x84E8;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_OES symbol.
		/// </summary>
		public const int DEPTH_STENCIL_OES = 0x84F9;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_24_8_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_24_8_OES = 0x84FA;

		/// <summary>
		/// Value of GL_INCR_WRAP_OES symbol.
		/// </summary>
		public const int INCR_WRAP_OES = 0x8507;

		/// <summary>
		/// Value of GL_DECR_WRAP_OES symbol.
		/// </summary>
		public const int DECR_WRAP_OES = 0x8508;

		/// <summary>
		/// Value of GL_NORMAL_MAP_OES symbol.
		/// </summary>
		public const int NORMAL_MAP_OES = 0x8511;

		/// <summary>
		/// Value of GL_REFLECTION_MAP_OES symbol.
		/// </summary>
		public const int REFLECTION_MAP_OES = 0x8512;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_OES = 0x8513;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_CUBE_MAP_OES = 0x8514;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A;

		/// <summary>
		/// Value of GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES symbol.
		/// </summary>
		public const int MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BINDING_OES symbol.
		/// </summary>
		public const int VERTEX_ARRAY_BINDING_OES = 0x85B5;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNITS_OES symbol.
		/// </summary>
		public const int MAX_VERTEX_UNITS_OES = 0x86A4;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_TYPE_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_TYPE_OES = 0x86A9;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_STRIDE_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_STRIDE_OES = 0x86AA;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_SIZE_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_SIZE_OES = 0x86AB;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_POINTER_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_POINTER_OES = 0x86AC;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_OES = 0x86AD;

		/// <summary>
		/// Value of GL_DOT3_RGBA_IMG symbol.
		/// </summary>
		public const int DOT3_RGBA_IMG = 0x86AF;

		/// <summary>
		/// Value of GL_Z400_BINARY_AMD symbol.
		/// </summary>
		public const int Z400_BINARY_AMD = 0x8740;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_LENGTH_OES symbol.
		/// </summary>
		public const int PROGRAM_BINARY_LENGTH_OES = 0x8741;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_MESA symbol.
		/// </summary>
		public const int DEPTH_STENCIL_MESA = 0x8750;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_24_8_MESA symbol.
		/// </summary>
		public const int UNSIGNED_INT_24_8_MESA = 0x8751;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_24_REV_MESA symbol.
		/// </summary>
		public const int UNSIGNED_INT_8_24_REV_MESA = 0x8752;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_15_1_MESA symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_15_1_MESA = 0x8753;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_1_15_REV_MESA symbol.
		/// </summary>
		public const int UNSIGNED_SHORT_1_15_REV_MESA = 0x8754;

		/// <summary>
		/// Value of GL_TRACE_MASK_MESA symbol.
		/// </summary>
		public const int TRACE_MASK_MESA = 0x8755;

		/// <summary>
		/// Value of GL_TRACE_NAME_MESA symbol.
		/// </summary>
		public const int TRACE_NAME_MESA = 0x8756;

		/// <summary>
		/// Value of GL_DEBUG_OBJECT_MESA symbol.
		/// </summary>
		public const int DEBUG_OBJECT_MESA = 0x8759;

		/// <summary>
		/// Value of GL_DEBUG_PRINT_MESA symbol.
		/// </summary>
		public const int DEBUG_PRINT_MESA = 0x875A;

		/// <summary>
		/// Value of GL_DEBUG_ASSERT_MESA symbol.
		/// </summary>
		public const int DEBUG_ASSERT_MESA = 0x875B;

		/// <summary>
		/// Value of GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD symbol.
		/// </summary>
		public const int ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;

		/// <summary>
		/// Value of GL_3DC_X_AMD symbol.
		/// </summary>
		public const int _3DC_X_AMD = 0x87F9;

		/// <summary>
		/// Value of GL_3DC_XY_AMD symbol.
		/// </summary>
		public const int _3DC_XY_AMD = 0x87FA;

		/// <summary>
		/// Value of GL_NUM_PROGRAM_BINARY_FORMATS_OES symbol.
		/// </summary>
		public const int NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_FORMATS_OES symbol.
		/// </summary>
		public const int PROGRAM_BINARY_FORMATS_OES = 0x87FF;

		/// <summary>
		/// Value of GL_RGBA32F_EXT symbol.
		/// </summary>
		public const int RGBA32F_EXT = 0x8814;

		/// <summary>
		/// Value of GL_RGB32F_EXT symbol.
		/// </summary>
		public const int RGB32F_EXT = 0x8815;

		/// <summary>
		/// Value of GL_ALPHA32F_EXT symbol.
		/// </summary>
		public const int ALPHA32F_EXT = 0x8816;

		/// <summary>
		/// Value of GL_LUMINANCE32F_EXT symbol.
		/// </summary>
		public const int LUMINANCE32F_EXT = 0x8818;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA32F_EXT symbol.
		/// </summary>
		public const int LUMINANCE_ALPHA32F_EXT = 0x8819;

		/// <summary>
		/// Value of GL_RGBA16F_EXT symbol.
		/// </summary>
		public const int RGBA16F_EXT = 0x881A;

		/// <summary>
		/// Value of GL_RGB16F_EXT symbol.
		/// </summary>
		public const int RGB16F_EXT = 0x881B;

		/// <summary>
		/// Value of GL_ALPHA16F_EXT symbol.
		/// </summary>
		public const int ALPHA16F_EXT = 0x881C;

		/// <summary>
		/// Value of GL_LUMINANCE16F_EXT symbol.
		/// </summary>
		public const int LUMINANCE16F_EXT = 0x881E;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA16F_EXT symbol.
		/// </summary>
		public const int LUMINANCE_ALPHA16F_EXT = 0x881F;

		/// <summary>
		/// Value of GL_WRITEONLY_RENDERING_QCOM symbol.
		/// </summary>
		public const int WRITEONLY_RENDERING_QCOM = 0x8823;

		/// <summary>
		/// Value of GL_MAX_DRAW_BUFFERS_EXT symbol.
		/// </summary>
		public const int MAX_DRAW_BUFFERS_EXT = 0x8824;

		/// <summary>
		/// Value of GL_MAX_DRAW_BUFFERS_NV symbol.
		/// </summary>
		public const int MAX_DRAW_BUFFERS_NV = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER0_EXT = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER0_NV = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER1_EXT = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER1_NV = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER2_EXT = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER2_NV = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER3_EXT = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER3_NV = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER4_EXT = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER4_NV = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER5_EXT = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER5_NV = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER6_EXT = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER6_NV = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER7_EXT = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER7_NV = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER8_EXT = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER8_NV = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER9_EXT = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER9_NV = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER10_EXT = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER10_NV = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER11_EXT = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER11_NV = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER12_EXT = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER12_NV = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER13_EXT = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER13_NV = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER14_EXT = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER14_NV = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15_EXT symbol.
		/// </summary>
		public const int DRAW_BUFFER15_EXT = 0x8834;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15_NV symbol.
		/// </summary>
		public const int DRAW_BUFFER15_NV = 0x8834;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ALPHA_3DC_ATI symbol.
		/// </summary>
		public const int COMPRESSED_LUMINANCE_ALPHA_3DC_ATI = 0x8837;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_ALPHA_OES symbol.
		/// </summary>
		public const int BLEND_EQUATION_ALPHA_OES = 0x883D;

		/// <summary>
		/// Value of GL_MATRIX_PALETTE_OES symbol.
		/// </summary>
		public const int MATRIX_PALETTE_OES = 0x8840;

		/// <summary>
		/// Value of GL_MAX_PALETTE_MATRICES_OES symbol.
		/// </summary>
		public const int MAX_PALETTE_MATRICES_OES = 0x8842;

		/// <summary>
		/// Value of GL_CURRENT_PALETTE_MATRIX_OES symbol.
		/// </summary>
		public const int CURRENT_PALETTE_MATRIX_OES = 0x8843;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_OES = 0x8844;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_SIZE_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_TYPE_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_STRIDE_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_POINTER_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_MODE_EXT symbol.
		/// </summary>
		public const int TEXTURE_COMPARE_MODE_EXT = 0x884C;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_FUNC_EXT symbol.
		/// </summary>
		public const int TEXTURE_COMPARE_FUNC_EXT = 0x884D;

		/// <summary>
		/// Value of GL_COMPARE_REF_TO_TEXTURE_EXT symbol.
		/// </summary>
		public const int COMPARE_REF_TO_TEXTURE_EXT = 0x884E;

		/// <summary>
		/// Value of GL_POINT_SPRITE_OES symbol.
		/// </summary>
		public const int POINT_SPRITE_OES = 0x8861;

		/// <summary>
		/// Value of GL_COORD_REPLACE_OES symbol.
		/// </summary>
		public const int COORD_REPLACE_OES = 0x8862;

		/// <summary>
		/// Value of GL_QUERY_COUNTER_BITS_EXT symbol.
		/// </summary>
		public const int QUERY_COUNTER_BITS_EXT = 0x8864;

		/// <summary>
		/// Value of GL_CURRENT_QUERY_EXT symbol.
		/// </summary>
		public const int CURRENT_QUERY_EXT = 0x8865;

		/// <summary>
		/// Value of GL_QUERY_RESULT_EXT symbol.
		/// </summary>
		public const int QUERY_RESULT_EXT = 0x8866;

		/// <summary>
		/// Value of GL_QUERY_RESULT_AVAILABLE_EXT symbol.
		/// </summary>
		public const int QUERY_RESULT_AVAILABLE_EXT = 0x8867;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT = 0x886C;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_INPUT_COMPONENTS_OES = 0x886C;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT = 0x886D;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES = 0x886D;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_INVOCATIONS_EXT symbol.
		/// </summary>
		public const int GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_INVOCATIONS_OES symbol.
		/// </summary>
		public const int GEOMETRY_SHADER_INVOCATIONS_OES = 0x887F;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_BUFFER_BINDING_OES symbol.
		/// </summary>
		public const int WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E;

		/// <summary>
		/// Value of GL_WRITE_ONLY_OES symbol.
		/// </summary>
		public const int WRITE_ONLY_OES = 0x88B9;

		/// <summary>
		/// Value of GL_BUFFER_ACCESS_OES symbol.
		/// </summary>
		public const int BUFFER_ACCESS_OES = 0x88BB;

		/// <summary>
		/// Value of GL_BUFFER_MAPPED_OES symbol.
		/// </summary>
		public const int BUFFER_MAPPED_OES = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER_OES symbol.
		/// </summary>
		public const int BUFFER_MAP_POINTER_OES = 0x88BD;

		/// <summary>
		/// Value of GL_ETC1_SRGB8_NV symbol.
		/// </summary>
		public const int ETC1_SRGB8_NV = 0x88EE;

		/// <summary>
		/// Value of GL_DEPTH24_STENCIL8_OES symbol.
		/// </summary>
		public const int DEPTH24_STENCIL8_OES = 0x88F0;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE symbol.
		/// </summary>
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT symbol.
		/// </summary>
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR_EXT = 0x88FE;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV symbol.
		/// </summary>
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR_NV = 0x88FE;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_VERTICES_OUT_EXT symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_VERTICES_OUT_OES symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_VERTICES_OUT_OES = 0x8916;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_INPUT_TYPE_EXT symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_INPUT_TYPE_OES symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_INPUT_TYPE_OES = 0x8917;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918;

		/// <summary>
		/// Value of GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES symbol.
		/// </summary>
		public const int GEOMETRY_LINKED_OUTPUT_TYPE_OES = 0x8918;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_TYPE_OES symbol.
		/// </summary>
		public const int POINT_SIZE_ARRAY_TYPE_OES = 0x898A;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_STRIDE_OES symbol.
		/// </summary>
		public const int POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_POINTER_OES symbol.
		/// </summary>
		public const int POINT_SIZE_ARRAY_POINTER_OES = 0x898C;

		/// <summary>
		/// Value of GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		public const int MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D;

		/// <summary>
		/// Value of GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		public const int PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E;

		/// <summary>
		/// Value of GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		public const int TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_UNIFORM_BLOCKS_OES = 0x8A2C;

		/// <summary>
		/// Value of GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32;

		/// <summary>
		/// Value of GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8A32;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT symbol.
		/// </summary>
		public const int FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;

		/// <summary>
		/// Value of GL_SYNC_OBJECT_APPLE symbol.
		/// </summary>
		public const int SYNC_OBJECT_APPLE = 0x8A53;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;

		/// <summary>
		/// Value of GL_SAMPLER_3D_OES symbol.
		/// </summary>
		public const int SAMPLER_3D_OES = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_2D_SHADOW_EXT symbol.
		/// </summary>
		public const int SAMPLER_2D_SHADOW_EXT = 0x8B62;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x3_NV symbol.
		/// </summary>
		public const int FLOAT_MAT2x3_NV = 0x8B65;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x4_NV symbol.
		/// </summary>
		public const int FLOAT_MAT2x4_NV = 0x8B66;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x2_NV symbol.
		/// </summary>
		public const int FLOAT_MAT3x2_NV = 0x8B67;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x4_NV symbol.
		/// </summary>
		public const int FLOAT_MAT3x4_NV = 0x8B68;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x2_NV symbol.
		/// </summary>
		public const int FLOAT_MAT4x2_NV = 0x8B69;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x3_NV symbol.
		/// </summary>
		public const int FLOAT_MAT4x3_NV = 0x8B6A;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES symbol.
		/// </summary>
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_OES symbol.
		/// </summary>
		public const int POINT_SIZE_ARRAY_OES = 0x8B9C;

		/// <summary>
		/// Value of GL_TEXTURE_CROP_RECT_OES symbol.
		/// </summary>
		public const int TEXTURE_CROP_RECT_OES = 0x8B9D;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES symbol.
		/// </summary>
		public const int MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES symbol.
		/// </summary>
		public const int POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;

		/// <summary>
		/// Value of GL_FRAGMENT_PROGRAM_POSITION_MESA symbol.
		/// </summary>
		public const int FRAGMENT_PROGRAM_POSITION_MESA = 0x8BB0;

		/// <summary>
		/// Value of GL_FRAGMENT_PROGRAM_CALLBACK_MESA symbol.
		/// </summary>
		public const int FRAGMENT_PROGRAM_CALLBACK_MESA = 0x8BB1;

		/// <summary>
		/// Value of GL_FRAGMENT_PROGRAM_CALLBACK_FUNC_MESA symbol.
		/// </summary>
		public const int FRAGMENT_PROGRAM_CALLBACK_FUNC_MESA = 0x8BB2;

		/// <summary>
		/// Value of GL_FRAGMENT_PROGRAM_CALLBACK_DATA_MESA symbol.
		/// </summary>
		public const int FRAGMENT_PROGRAM_CALLBACK_DATA_MESA = 0x8BB3;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_POSITION_MESA symbol.
		/// </summary>
		public const int VERTEX_PROGRAM_POSITION_MESA = 0x8BB4;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_CALLBACK_MESA symbol.
		/// </summary>
		public const int VERTEX_PROGRAM_CALLBACK_MESA = 0x8BB5;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_CALLBACK_FUNC_MESA symbol.
		/// </summary>
		public const int VERTEX_PROGRAM_CALLBACK_FUNC_MESA = 0x8BB6;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_CALLBACK_DATA_MESA symbol.
		/// </summary>
		public const int VERTEX_PROGRAM_CALLBACK_DATA_MESA = 0x8BB7;

		/// <summary>
		/// Value of GL_TEXTURE_WIDTH_QCOM symbol.
		/// </summary>
		public const int TEXTURE_WIDTH_QCOM = 0x8BD2;

		/// <summary>
		/// Value of GL_TEXTURE_HEIGHT_QCOM symbol.
		/// </summary>
		public const int TEXTURE_HEIGHT_QCOM = 0x8BD3;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_QCOM symbol.
		/// </summary>
		public const int TEXTURE_DEPTH_QCOM = 0x8BD4;

		/// <summary>
		/// Value of GL_TEXTURE_INTERNAL_FORMAT_QCOM symbol.
		/// </summary>
		public const int TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;

		/// <summary>
		/// Value of GL_TEXTURE_FORMAT_QCOM symbol.
		/// </summary>
		public const int TEXTURE_FORMAT_QCOM = 0x8BD6;

		/// <summary>
		/// Value of GL_TEXTURE_TYPE_QCOM symbol.
		/// </summary>
		public const int TEXTURE_TYPE_QCOM = 0x8BD7;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_VALID_QCOM symbol.
		/// </summary>
		public const int TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;

		/// <summary>
		/// Value of GL_TEXTURE_NUM_LEVELS_QCOM symbol.
		/// </summary>
		public const int TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;

		/// <summary>
		/// Value of GL_TEXTURE_TARGET_QCOM symbol.
		/// </summary>
		public const int TEXTURE_TARGET_QCOM = 0x8BDA;

		/// <summary>
		/// Value of GL_TEXTURE_OBJECT_VALID_QCOM symbol.
		/// </summary>
		public const int TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;

		/// <summary>
		/// Value of GL_STATE_RESTORE symbol.
		/// </summary>
		public const int STATE_RESTORE = 0x8BDC;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;

		/// <summary>
		/// Value of GL_MODULATE_COLOR_IMG symbol.
		/// </summary>
		public const int MODULATE_COLOR_IMG = 0x8C04;

		/// <summary>
		/// Value of GL_RECIP_ADD_SIGNED_ALPHA_IMG symbol.
		/// </summary>
		public const int RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		public const int TEXTURE_ALPHA_MODULATE_IMG = 0x8C06;

		/// <summary>
		/// Value of GL_FACTOR_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		public const int FACTOR_ALPHA_MODULATE_IMG = 0x8C07;

		/// <summary>
		/// Value of GL_FRAGMENT_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		public const int FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08;

		/// <summary>
		/// Value of GL_ADD_BLEND_IMG symbol.
		/// </summary>
		public const int ADD_BLEND_IMG = 0x8C09;

		/// <summary>
		/// Value of GL_SGX_BINARY_IMG symbol.
		/// </summary>
		public const int SGX_BINARY_IMG = 0x8C0A;

		/// <summary>
		/// Value of GL_UNSIGNED_NORMALIZED_EXT symbol.
		/// </summary>
		public const int UNSIGNED_NORMALIZED_EXT = 0x8C17;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES = 0x8C29;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_OES = 0x8C2A;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_BINDING_EXT symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_BINDING_EXT = 0x8C2A;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_BINDING_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_BINDING_OES = 0x8C2A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_BUFFER_SIZE_OES symbol.
		/// </summary>
		public const int MAX_TEXTURE_BUFFER_SIZE_OES = 0x8C2B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_BUFFER_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_BUFFER_OES = 0x8C2C;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_DATA_STORE_BINDING_OES = 0x8C2D;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED_EXT symbol.
		/// </summary>
		public const int ANY_SAMPLES_PASSED_EXT = 0x8C2F;

		/// <summary>
		/// Value of GL_SAMPLE_SHADING_OES symbol.
		/// </summary>
		public const int SAMPLE_SHADING_OES = 0x8C36;

		/// <summary>
		/// Value of GL_MIN_SAMPLE_SHADING_VALUE_OES symbol.
		/// </summary>
		public const int MIN_SAMPLE_SHADING_VALUE_OES = 0x8C37;

		/// <summary>
		/// Value of GL_R11F_G11F_B10F_APPLE symbol.
		/// </summary>
		public const int R11F_G11F_B10F_APPLE = 0x8C3A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE symbol.
		/// </summary>
		public const int UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;

		/// <summary>
		/// Value of GL_RGB9_E5_APPLE symbol.
		/// </summary>
		public const int RGB9_E5_APPLE = 0x8C3D;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_5_9_9_9_REV_APPLE symbol.
		/// </summary>
		public const int UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;

		/// <summary>
		/// Value of GL_SRGB8_NV symbol.
		/// </summary>
		public const int SRGB8_NV = 0x8C41;

		/// <summary>
		/// Value of GL_SLUMINANCE_ALPHA_NV symbol.
		/// </summary>
		public const int SLUMINANCE_ALPHA_NV = 0x8C44;

		/// <summary>
		/// Value of GL_SLUMINANCE8_ALPHA8_NV symbol.
		/// </summary>
		public const int SLUMINANCE8_ALPHA8_NV = 0x8C45;

		/// <summary>
		/// Value of GL_SLUMINANCE_NV symbol.
		/// </summary>
		public const int SLUMINANCE_NV = 0x8C46;

		/// <summary>
		/// Value of GL_SLUMINANCE8_NV symbol.
		/// </summary>
		public const int SLUMINANCE8_NV = 0x8C47;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_S3TC_DXT1_NV symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED_OES symbol.
		/// </summary>
		public const int PRIMITIVES_GENERATED_OES = 0x8C87;

		/// <summary>
		/// Value of GL_ATC_RGB_AMD symbol.
		/// </summary>
		public const int ATC_RGB_AMD = 0x8C92;

		/// <summary>
		/// Value of GL_ATC_RGBA_EXPLICIT_ALPHA_AMD symbol.
		/// </summary>
		public const int ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING_ANGLE symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING_APPLE symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING_NV symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_BINDING_NV = 0x8CA6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING_ANGLE symbol.
		/// </summary>
		public const int FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_BINDING_OES = 0x8CA6;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BINDING_ANGLE symbol.
		/// </summary>
		public const int RENDERBUFFER_BINDING_ANGLE = 0x8CA7;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BINDING_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_BINDING_OES = 0x8CA7;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_ANGLE symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_ANGLE = 0x8CA8;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_APPLE symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_APPLE = 0x8CA8;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_NV symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_NV = 0x8CA8;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_ANGLE symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_APPLE symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_APPLE = 0x8CA9;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_NV symbol.
		/// </summary>
		public const int DRAW_FRAMEBUFFER_NV = 0x8CA9;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING_ANGLE symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING_APPLE symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING_NV symbol.
		/// </summary>
		public const int READ_FRAMEBUFFER_BINDING_NV = 0x8CAA;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES_ANGLE symbol.
		/// </summary>
		public const int RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES_APPLE symbol.
		/// </summary>
		public const int RENDERBUFFER_SAMPLES_APPLE = 0x8CAB;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES_NV symbol.
		/// </summary>
		public const int RENDERBUFFER_SAMPLES_NV = 0x8CAB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_COMPLETE_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_COMPLETE_OES = 0x8CD5;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES = 0x8CDB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES = 0x8CDC;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNSUPPORTED_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD;

		/// <summary>
		/// Value of GL_MAX_COLOR_ATTACHMENTS_NV symbol.
		/// </summary>
		public const int MAX_COLOR_ATTACHMENTS_NV = 0x8CDF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT0_NV = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0_OES symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT0_OES = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT1_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT1_NV = 0x8CE1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT2_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT2_NV = 0x8CE2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT3_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT3_NV = 0x8CE3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT4_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT4_NV = 0x8CE4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT5_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT5_NV = 0x8CE5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT6_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT6_NV = 0x8CE6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT7_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT7_NV = 0x8CE7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT8_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT8_NV = 0x8CE8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT9_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT9_NV = 0x8CE9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT10_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT10_NV = 0x8CEA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT11_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT11_NV = 0x8CEB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT12_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT12_NV = 0x8CEC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT13_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT13_NV = 0x8CED;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT14_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT14_NV = 0x8CEE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT15_NV symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT15_NV = 0x8CEF;

		/// <summary>
		/// Value of GL_DEPTH_ATTACHMENT_OES symbol.
		/// </summary>
		public const int DEPTH_ATTACHMENT_OES = 0x8D00;

		/// <summary>
		/// Value of GL_STENCIL_ATTACHMENT_OES symbol.
		/// </summary>
		public const int STENCIL_ATTACHMENT_OES = 0x8D20;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_OES = 0x8D40;

		/// <summary>
		/// Value of GL_RENDERBUFFER_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_OES = 0x8D41;

		/// <summary>
		/// Value of GL_RENDERBUFFER_WIDTH_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_WIDTH_OES = 0x8D42;

		/// <summary>
		/// Value of GL_RENDERBUFFER_HEIGHT_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_HEIGHT_OES = 0x8D43;

		/// <summary>
		/// Value of GL_RENDERBUFFER_INTERNAL_FORMAT_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44;

		/// <summary>
		/// Value of GL_STENCIL_INDEX1_OES symbol.
		/// </summary>
		public const int STENCIL_INDEX1_OES = 0x8D46;

		/// <summary>
		/// Value of GL_STENCIL_INDEX4_OES symbol.
		/// </summary>
		public const int STENCIL_INDEX4_OES = 0x8D47;

		/// <summary>
		/// Value of GL_STENCIL_INDEX8_OES symbol.
		/// </summary>
		public const int STENCIL_INDEX8_OES = 0x8D48;

		/// <summary>
		/// Value of GL_RENDERBUFFER_RED_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_RED_SIZE_OES = 0x8D50;

		/// <summary>
		/// Value of GL_RENDERBUFFER_GREEN_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_GREEN_SIZE_OES = 0x8D51;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BLUE_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_BLUE_SIZE_OES = 0x8D52;

		/// <summary>
		/// Value of GL_RENDERBUFFER_ALPHA_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53;

		/// <summary>
		/// Value of GL_RENDERBUFFER_DEPTH_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54;

		/// <summary>
		/// Value of GL_RENDERBUFFER_STENCIL_SIZE_OES symbol.
		/// </summary>
		public const int RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;

		/// <summary>
		/// Value of GL_MAX_SAMPLES_ANGLE symbol.
		/// </summary>
		public const int MAX_SAMPLES_ANGLE = 0x8D57;

		/// <summary>
		/// Value of GL_MAX_SAMPLES_APPLE symbol.
		/// </summary>
		public const int MAX_SAMPLES_APPLE = 0x8D57;

		/// <summary>
		/// Value of GL_MAX_SAMPLES_NV symbol.
		/// </summary>
		public const int MAX_SAMPLES_NV = 0x8D57;

		/// <summary>
		/// Value of GL_TEXTURE_GEN_STR_OES symbol.
		/// </summary>
		public const int TEXTURE_GEN_STR_OES = 0x8D60;

		/// <summary>
		/// Value of GL_HALF_FLOAT_OES symbol.
		/// </summary>
		public const int HALF_FLOAT_OES = 0x8D61;

		/// <summary>
		/// Value of GL_RGB565_OES symbol.
		/// </summary>
		public const int RGB565_OES = 0x8D62;

		/// <summary>
		/// Value of GL_ETC1_RGB8_OES symbol.
		/// </summary>
		public const int ETC1_RGB8_OES = 0x8D64;

		/// <summary>
		/// Value of GL_TEXTURE_EXTERNAL_OES symbol.
		/// </summary>
		public const int TEXTURE_EXTERNAL_OES = 0x8D65;

		/// <summary>
		/// Value of GL_SAMPLER_EXTERNAL_OES symbol.
		/// </summary>
		public const int SAMPLER_EXTERNAL_OES = 0x8D66;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_EXTERNAL_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;

		/// <summary>
		/// Value of GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES symbol.
		/// </summary>
		public const int REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT symbol.
		/// </summary>
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED_OES = 0x8DA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES = 0x8DA8;

		/// <summary>
		/// Value of GL_SAMPLER_BUFFER_OES symbol.
		/// </summary>
		public const int SAMPLER_BUFFER_OES = 0x8DC2;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_SHADOW_NV symbol.
		/// </summary>
		public const int SAMPLER_2D_ARRAY_SHADOW_NV = 0x8DC4;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_SHADOW_NV symbol.
		/// </summary>
		public const int SAMPLER_CUBE_SHADOW_NV = 0x8DC5;

		/// <summary>
		/// Value of GL_INT_SAMPLER_BUFFER_OES symbol.
		/// </summary>
		public const int INT_SAMPLER_BUFFER_OES = 0x8DD0;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_BUFFER_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_SAMPLER_BUFFER_OES = 0x8DD8;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_OES symbol.
		/// </summary>
		public const int GEOMETRY_SHADER_OES = 0x8DD9;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8DDF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_OUTPUT_VERTICES_OES = 0x8DE0;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES = 0x8DE1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10_10_10_2_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_10_10_10_2_OES = 0x8DF6;

		/// <summary>
		/// Value of GL_INT_10_10_10_2_OES symbol.
		/// </summary>
		public const int INT_10_10_10_2_OES = 0x8DF7;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E1E;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E1E;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E1F;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E1F;

		/// <summary>
		/// Value of GL_TIMESTAMP_EXT symbol.
		/// </summary>
		public const int TIMESTAMP_EXT = 0x8E28;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT16_NONLINEAR_NV symbol.
		/// </summary>
		public const int DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C;

		/// <summary>
		/// Value of GL_FIRST_VERTEX_CONVENTION_OES symbol.
		/// </summary>
		public const int FIRST_VERTEX_CONVENTION_OES = 0x8E4D;

		/// <summary>
		/// Value of GL_LAST_VERTEX_CONVENTION_OES symbol.
		/// </summary>
		public const int LAST_VERTEX_CONVENTION_OES = 0x8E4E;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_SHADER_INVOCATIONS_OES = 0x8E5A;

		/// <summary>
		/// Value of GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES symbol.
		/// </summary>
		public const int MIN_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5B;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES symbol.
		/// </summary>
		public const int MAX_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5C;

		/// <summary>
		/// Value of GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES symbol.
		/// </summary>
		public const int FRAGMENT_INTERPOLATION_OFFSET_BITS_OES = 0x8E5D;

		/// <summary>
		/// Value of GL_PATCH_VERTICES_EXT symbol.
		/// </summary>
		public const int PATCH_VERTICES_EXT = 0x8E72;

		/// <summary>
		/// Value of GL_PATCH_VERTICES_OES symbol.
		/// </summary>
		public const int PATCH_VERTICES_OES = 0x8E72;

		/// <summary>
		/// Value of GL_PATCH_DEFAULT_INNER_LEVEL_EXT symbol.
		/// </summary>
		public const int PATCH_DEFAULT_INNER_LEVEL_EXT = 0x8E73;

		/// <summary>
		/// Value of GL_PATCH_DEFAULT_OUTER_LEVEL_EXT symbol.
		/// </summary>
		public const int PATCH_DEFAULT_OUTER_LEVEL_EXT = 0x8E74;

		/// <summary>
		/// Value of GL_TESS_CONTROL_OUTPUT_VERTICES_EXT symbol.
		/// </summary>
		public const int TESS_CONTROL_OUTPUT_VERTICES_EXT = 0x8E75;

		/// <summary>
		/// Value of GL_TESS_CONTROL_OUTPUT_VERTICES_OES symbol.
		/// </summary>
		public const int TESS_CONTROL_OUTPUT_VERTICES_OES = 0x8E75;

		/// <summary>
		/// Value of GL_TESS_GEN_MODE_EXT symbol.
		/// </summary>
		public const int TESS_GEN_MODE_EXT = 0x8E76;

		/// <summary>
		/// Value of GL_TESS_GEN_MODE_OES symbol.
		/// </summary>
		public const int TESS_GEN_MODE_OES = 0x8E76;

		/// <summary>
		/// Value of GL_TESS_GEN_SPACING_EXT symbol.
		/// </summary>
		public const int TESS_GEN_SPACING_EXT = 0x8E77;

		/// <summary>
		/// Value of GL_TESS_GEN_SPACING_OES symbol.
		/// </summary>
		public const int TESS_GEN_SPACING_OES = 0x8E77;

		/// <summary>
		/// Value of GL_TESS_GEN_VERTEX_ORDER_EXT symbol.
		/// </summary>
		public const int TESS_GEN_VERTEX_ORDER_EXT = 0x8E78;

		/// <summary>
		/// Value of GL_TESS_GEN_VERTEX_ORDER_OES symbol.
		/// </summary>
		public const int TESS_GEN_VERTEX_ORDER_OES = 0x8E78;

		/// <summary>
		/// Value of GL_TESS_GEN_POINT_MODE_EXT symbol.
		/// </summary>
		public const int TESS_GEN_POINT_MODE_EXT = 0x8E79;

		/// <summary>
		/// Value of GL_TESS_GEN_POINT_MODE_OES symbol.
		/// </summary>
		public const int TESS_GEN_POINT_MODE_OES = 0x8E79;

		/// <summary>
		/// Value of GL_ISOLINES_EXT symbol.
		/// </summary>
		public const int ISOLINES_EXT = 0x8E7A;

		/// <summary>
		/// Value of GL_ISOLINES_OES symbol.
		/// </summary>
		public const int ISOLINES_OES = 0x8E7A;

		/// <summary>
		/// Value of GL_FRACTIONAL_ODD_EXT symbol.
		/// </summary>
		public const int FRACTIONAL_ODD_EXT = 0x8E7B;

		/// <summary>
		/// Value of GL_FRACTIONAL_ODD_OES symbol.
		/// </summary>
		public const int FRACTIONAL_ODD_OES = 0x8E7B;

		/// <summary>
		/// Value of GL_FRACTIONAL_EVEN_EXT symbol.
		/// </summary>
		public const int FRACTIONAL_EVEN_EXT = 0x8E7C;

		/// <summary>
		/// Value of GL_FRACTIONAL_EVEN_OES symbol.
		/// </summary>
		public const int FRACTIONAL_EVEN_OES = 0x8E7C;

		/// <summary>
		/// Value of GL_MAX_PATCH_VERTICES_EXT symbol.
		/// </summary>
		public const int MAX_PATCH_VERTICES_EXT = 0x8E7D;

		/// <summary>
		/// Value of GL_MAX_PATCH_VERTICES_OES symbol.
		/// </summary>
		public const int MAX_PATCH_VERTICES_OES = 0x8E7D;

		/// <summary>
		/// Value of GL_MAX_TESS_GEN_LEVEL_EXT symbol.
		/// </summary>
		public const int MAX_TESS_GEN_LEVEL_EXT = 0x8E7E;

		/// <summary>
		/// Value of GL_MAX_TESS_GEN_LEVEL_OES symbol.
		/// </summary>
		public const int MAX_TESS_GEN_LEVEL_OES = 0x8E7E;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E7F;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E7F;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E80;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E80;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT = 0x8E81;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES = 0x8E81;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT = 0x8E82;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES = 0x8E82;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT = 0x8E83;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES = 0x8E83;

		/// <summary>
		/// Value of GL_MAX_TESS_PATCH_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_PATCH_COMPONENTS_EXT = 0x8E84;

		/// <summary>
		/// Value of GL_MAX_TESS_PATCH_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_PATCH_COMPONENTS_OES = 0x8E84;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8E85;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES = 0x8E85;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT = 0x8E86;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES = 0x8E86;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_EXT symbol.
		/// </summary>
		public const int TESS_EVALUATION_SHADER_EXT = 0x8E87;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_OES symbol.
		/// </summary>
		public const int TESS_EVALUATION_SHADER_OES = 0x8E87;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_EXT symbol.
		/// </summary>
		public const int TESS_CONTROL_SHADER_EXT = 0x8E88;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_OES symbol.
		/// </summary>
		public const int TESS_CONTROL_SHADER_OES = 0x8E88;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT = 0x8E89;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES = 0x8E89;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT = 0x8E8A;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES = 0x8E8A;

		/// <summary>
		/// Value of GL_COVERAGE_COMPONENT_NV symbol.
		/// </summary>
		public const int COVERAGE_COMPONENT_NV = 0x8ED0;

		/// <summary>
		/// Value of GL_COVERAGE_COMPONENT4_NV symbol.
		/// </summary>
		public const int COVERAGE_COMPONENT4_NV = 0x8ED1;

		/// <summary>
		/// Value of GL_COVERAGE_ATTACHMENT_NV symbol.
		/// </summary>
		public const int COVERAGE_ATTACHMENT_NV = 0x8ED2;

		/// <summary>
		/// Value of GL_COVERAGE_BUFFERS_NV symbol.
		/// </summary>
		public const int COVERAGE_BUFFERS_NV = 0x8ED3;

		/// <summary>
		/// Value of GL_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		public const int COVERAGE_SAMPLES_NV = 0x8ED4;

		/// <summary>
		/// Value of GL_COVERAGE_ALL_FRAGMENTS_NV symbol.
		/// </summary>
		public const int COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;

		/// <summary>
		/// Value of GL_COVERAGE_EDGE_FRAGMENTS_NV symbol.
		/// </summary>
		public const int COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;

		/// <summary>
		/// Value of GL_COVERAGE_AUTOMATIC_NV symbol.
		/// </summary>
		public const int COVERAGE_AUTOMATIC_NV = 0x8ED7;

		/// <summary>
		/// Value of GL_COPY_READ_BUFFER_NV symbol.
		/// </summary>
		public const int COPY_READ_BUFFER_NV = 0x8F36;

		/// <summary>
		/// Value of GL_COPY_WRITE_BUFFER_NV symbol.
		/// </summary>
		public const int COPY_WRITE_BUFFER_NV = 0x8F37;

		/// <summary>
		/// Value of GL_MALI_SHADER_BINARY_ARM symbol.
		/// </summary>
		public const int MALI_SHADER_BINARY_ARM = 0x8F60;

		/// <summary>
		/// Value of GL_MALI_PROGRAM_BINARY_ARM symbol.
		/// </summary>
		public const int MALI_PROGRAM_BINARY_ARM = 0x8F61;

		/// <summary>
		/// Value of GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT symbol.
		/// </summary>
		public const int MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;

		/// <summary>
		/// Value of GL_SHADER_PIXEL_LOCAL_STORAGE_EXT symbol.
		/// </summary>
		public const int SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;

		/// <summary>
		/// Value of GL_FETCH_PER_SAMPLE_ARM symbol.
		/// </summary>
		public const int FETCH_PER_SAMPLE_ARM = 0x8F65;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM symbol.
		/// </summary>
		public const int FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66;

		/// <summary>
		/// Value of GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT symbol.
		/// </summary>
		public const int MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;

		/// <summary>
		/// Value of GL_R16_SNORM_EXT symbol.
		/// </summary>
		public const int R16_SNORM_EXT = 0x8F98;

		/// <summary>
		/// Value of GL_RG16_SNORM_EXT symbol.
		/// </summary>
		public const int RG16_SNORM_EXT = 0x8F99;

		/// <summary>
		/// Value of GL_RGB16_SNORM_EXT symbol.
		/// </summary>
		public const int RGB16_SNORM_EXT = 0x8F9A;

		/// <summary>
		/// Value of GL_RGBA16_SNORM_EXT symbol.
		/// </summary>
		public const int RGBA16_SNORM_EXT = 0x8F9B;

		/// <summary>
		/// Value of GL_PERFMON_GLOBAL_MODE_QCOM symbol.
		/// </summary>
		public const int PERFMON_GLOBAL_MODE_QCOM = 0x8FA0;

		/// <summary>
		/// Value of GL_BINNING_CONTROL_HINT_QCOM symbol.
		/// </summary>
		public const int BINNING_CONTROL_HINT_QCOM = 0x8FB0;

		/// <summary>
		/// Value of GL_CPU_OPTIMIZED_QCOM symbol.
		/// </summary>
		public const int CPU_OPTIMIZED_QCOM = 0x8FB1;

		/// <summary>
		/// Value of GL_GPU_OPTIMIZED_QCOM symbol.
		/// </summary>
		public const int GPU_OPTIMIZED_QCOM = 0x8FB2;

		/// <summary>
		/// Value of GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM symbol.
		/// </summary>
		public const int RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;

		/// <summary>
		/// Value of GL_GPU_DISJOINT_EXT symbol.
		/// </summary>
		public const int GPU_DISJOINT_EXT = 0x8FBB;

		/// <summary>
		/// Value of GL_SHADER_BINARY_VIV symbol.
		/// </summary>
		public const int SHADER_BINARY_VIV = 0x8FC4;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_CUBE_MAP_ARRAY_OES = 0x900A;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		public const int SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int SAMPLER_CUBE_MAP_ARRAY_OES = 0x900C;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT symbol.
		/// </summary>
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES symbol.
		/// </summary>
		public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES = 0x900D;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		public const int INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900E;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900F;

		/// <summary>
		/// Value of GL_IMAGE_BUFFER_OES symbol.
		/// </summary>
		public const int IMAGE_BUFFER_OES = 0x9051;

		/// <summary>
		/// Value of GL_IMAGE_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int IMAGE_CUBE_MAP_ARRAY_OES = 0x9054;

		/// <summary>
		/// Value of GL_INT_IMAGE_BUFFER_OES symbol.
		/// </summary>
		public const int INT_IMAGE_BUFFER_OES = 0x905C;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x905F;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_BUFFER_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_IMAGE_BUFFER_OES = 0x9067;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x906A;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT = 0x90CB;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES = 0x90CB;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT = 0x90CC;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES = 0x90CC;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_IMAGE_UNIFORMS_OES = 0x90CD;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES = 0x90D7;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT = 0x90D8;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES = 0x90D8;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT = 0x90D9;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES = 0x90D9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT_EXT symbol.
		/// </summary>
		public const int COLOR_ATTACHMENT_EXT = 0x90F0;

		/// <summary>
		/// Value of GL_MULTIVIEW_EXT symbol.
		/// </summary>
		public const int MULTIVIEW_EXT = 0x90F1;

		/// <summary>
		/// Value of GL_MAX_MULTIVIEW_BUFFERS_EXT symbol.
		/// </summary>
		public const int MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;

		/// <summary>
		/// Value of GL_CONTEXT_ROBUST_ACCESS_EXT symbol.
		/// </summary>
		public const int CONTEXT_ROBUST_ACCESS_EXT = 0x90F3;

		/// <summary>
		/// Value of GL_CONTEXT_ROBUST_ACCESS_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public const int CONTEXT_ROBUST_ACCESS_KHR = 0x90F3;

		/// <summary>
		/// Value of GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES symbol.
		/// </summary>
		public const int TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES symbol.
		/// </summary>
		public const int TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105;

		/// <summary>
		/// Value of GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES symbol.
		/// </summary>
		public const int SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES symbol.
		/// </summary>
		public const int INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES symbol.
		/// </summary>
		public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D;

		/// <summary>
		/// Value of GL_MAX_SERVER_WAIT_TIMEOUT_APPLE symbol.
		/// </summary>
		public const int MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;

		/// <summary>
		/// Value of GL_OBJECT_TYPE_APPLE symbol.
		/// </summary>
		public const int OBJECT_TYPE_APPLE = 0x9112;

		/// <summary>
		/// Value of GL_SYNC_CONDITION_APPLE symbol.
		/// </summary>
		public const int SYNC_CONDITION_APPLE = 0x9113;

		/// <summary>
		/// Value of GL_SYNC_STATUS_APPLE symbol.
		/// </summary>
		public const int SYNC_STATUS_APPLE = 0x9114;

		/// <summary>
		/// Value of GL_SYNC_FLAGS_APPLE symbol.
		/// </summary>
		public const int SYNC_FLAGS_APPLE = 0x9115;

		/// <summary>
		/// Value of GL_SYNC_FENCE_APPLE symbol.
		/// </summary>
		public const int SYNC_FENCE_APPLE = 0x9116;

		/// <summary>
		/// Value of GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE symbol.
		/// </summary>
		public const int SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;

		/// <summary>
		/// Value of GL_UNSIGNALED_APPLE symbol.
		/// </summary>
		public const int UNSIGNALED_APPLE = 0x9118;

		/// <summary>
		/// Value of GL_SIGNALED_APPLE symbol.
		/// </summary>
		public const int SIGNALED_APPLE = 0x9119;

		/// <summary>
		/// Value of GL_ALREADY_SIGNALED_APPLE symbol.
		/// </summary>
		public const int ALREADY_SIGNALED_APPLE = 0x911A;

		/// <summary>
		/// Value of GL_TIMEOUT_EXPIRED_APPLE symbol.
		/// </summary>
		public const int TIMEOUT_EXPIRED_APPLE = 0x911B;

		/// <summary>
		/// Value of GL_CONDITION_SATISFIED_APPLE symbol.
		/// </summary>
		public const int CONDITION_SATISFIED_APPLE = 0x911C;

		/// <summary>
		/// Value of GL_WAIT_FAILED_APPLE symbol.
		/// </summary>
		public const int WAIT_FAILED_APPLE = 0x911D;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_INPUT_COMPONENTS_OES = 0x9123;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_OUTPUT_COMPONENTS_OES = 0x9124;

		/// <summary>
		/// Value of GL_TEXTURE_IMMUTABLE_FORMAT_EXT symbol.
		/// </summary>
		public const int TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;

		/// <summary>
		/// Value of GL_SGX_PROGRAM_BINARY_IMG symbol.
		/// </summary>
		public const int SGX_PROGRAM_BINARY_IMG = 0x9130;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES_IMG symbol.
		/// </summary>
		public const int RENDERBUFFER_SAMPLES_IMG = 0x9133;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG symbol.
		/// </summary>
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;

		/// <summary>
		/// Value of GL_MAX_SAMPLES_IMG symbol.
		/// </summary>
		public const int MAX_SAMPLES_IMG = 0x9135;

		/// <summary>
		/// Value of GL_TEXTURE_SAMPLES_IMG symbol.
		/// </summary>
		public const int TEXTURE_SAMPLES_IMG = 0x9136;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_PVRTC_2BPPV2_IMG = 0x9137;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_PVRTC_4BPPV2_IMG = 0x9138;

		/// <summary>
		/// Value of GL_MAX_DEBUG_MESSAGE_LENGTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143;

		/// <summary>
		/// Value of GL_MAX_DEBUG_LOGGED_MESSAGES_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144;

		/// <summary>
		/// Value of GL_DEBUG_LOGGED_MESSAGES_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_LOGGED_MESSAGES_KHR = 0x9145;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_HIGH_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_HIGH_KHR = 0x9146;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_MEDIUM_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_MEDIUM_KHR = 0x9147;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_LOW_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_SEVERITY_LOW_KHR = 0x9148;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET_EXT symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_OFFSET_EXT = 0x919D;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_OFFSET_OES = 0x919D;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_SIZE_EXT symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_SIZE_EXT = 0x919E;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_SIZE_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_SIZE_OES = 0x919E;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT = 0x919F;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES symbol.
		/// </summary>
		public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES = 0x919F;

		/// <summary>
		/// Value of GL_UNPACK_FLIP_Y_WEBGL symbol.
		/// </summary>
		public const int UNPACK_FLIP_Y_WEBGL = 0x9240;

		/// <summary>
		/// Value of GL_UNPACK_PREMULTIPLY_ALPHA_WEBGL symbol.
		/// </summary>
		public const int UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;

		/// <summary>
		/// Value of GL_CONTEXT_LOST_WEBGL symbol.
		/// </summary>
		public const int CONTEXT_LOST_WEBGL = 0x9242;

		/// <summary>
		/// Value of GL_UNPACK_COLORSPACE_CONVERSION_WEBGL symbol.
		/// </summary>
		public const int UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;

		/// <summary>
		/// Value of GL_BROWSER_DEFAULT_WEBGL symbol.
		/// </summary>
		public const int BROWSER_DEFAULT_WEBGL = 0x9244;

		/// <summary>
		/// Value of GL_SHADER_BINARY_DMP symbol.
		/// </summary>
		public const int SHADER_BINARY_DMP = 0x9250;

		/// <summary>
		/// Value of GL_SMAPHS30_PROGRAM_BINARY_DMP symbol.
		/// </summary>
		public const int SMAPHS30_PROGRAM_BINARY_DMP = 0x9251;

		/// <summary>
		/// Value of GL_SMAPHS_PROGRAM_BINARY_DMP symbol.
		/// </summary>
		public const int SMAPHS_PROGRAM_BINARY_DMP = 0x9252;

		/// <summary>
		/// Value of GL_DMP_PROGRAM_BINARY_DMP symbol.
		/// </summary>
		public const int DMP_PROGRAM_BINARY_DMP = 0x9253;

		/// <summary>
		/// Value of GL_GCCSO_SHADER_BINARY_FJ symbol.
		/// </summary>
		public const int GCCSO_SHADER_BINARY_FJ = 0x9260;

		/// <summary>
		/// Value of GL_COMPRESSED_R11_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_R11_EAC_OES = 0x9270;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_R11_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_SIGNED_R11_EAC_OES = 0x9271;

		/// <summary>
		/// Value of GL_COMPRESSED_RG11_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_RG11_EAC_OES = 0x9272;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG11_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_SIGNED_RG11_EAC_OES = 0x9273;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_ETC2_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGB8_ETC2_OES = 0x9274;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ETC2_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ETC2_OES = 0x9275;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES = 0x9276;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES = 0x9277;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA8_ETC2_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA8_ETC2_EAC_OES = 0x9278;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC_OES = 0x9279;

		/// <summary>
		/// Value of GL_PRIMITIVE_BOUNDING_BOX_EXT symbol.
		/// </summary>
		public const int PRIMITIVE_BOUNDING_BOX_EXT = 0x92BE;

		/// <summary>
		/// Value of GL_PRIMITIVE_BOUNDING_BOX_OES symbol.
		/// </summary>
		public const int PRIMITIVE_BOUNDING_BOX_OES = 0x92BE;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CD;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES = 0x92CD;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CE;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES = 0x92CE;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES = 0x92CF;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT = 0x92D3;

		/// <summary>
		/// Value of GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES symbol.
		/// </summary>
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES = 0x92D3;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT = 0x92D4;

		/// <summary>
		/// Value of GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES symbol.
		/// </summary>
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES = 0x92D4;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT symbol.
		/// </summary>
		public const int MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES symbol.
		/// </summary>
		public const int MAX_GEOMETRY_ATOMIC_COUNTERS_OES = 0x92D5;

		/// <summary>
		/// Value of GL_DEBUG_OUTPUT_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public const int DEBUG_OUTPUT_KHR = 0x92E0;

		/// <summary>
		/// Value of GL_IS_PER_PATCH_EXT symbol.
		/// </summary>
		public const int IS_PER_PATCH_EXT = 0x92E7;

		/// <summary>
		/// Value of GL_IS_PER_PATCH_OES symbol.
		/// </summary>
		public const int IS_PER_PATCH_OES = 0x92E7;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT symbol.
		/// </summary>
		public const int REFERENCED_BY_TESS_CONTROL_SHADER_EXT = 0x9307;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES symbol.
		/// </summary>
		public const int REFERENCED_BY_TESS_CONTROL_SHADER_OES = 0x9307;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT symbol.
		/// </summary>
		public const int REFERENCED_BY_TESS_EVALUATION_SHADER_EXT = 0x9308;

		/// <summary>
		/// Value of GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES symbol.
		/// </summary>
		public const int REFERENCED_BY_TESS_EVALUATION_SHADER_OES = 0x9308;

		/// <summary>
		/// Value of GL_REFERENCED_BY_GEOMETRY_SHADER_EXT symbol.
		/// </summary>
		public const int REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309;

		/// <summary>
		/// Value of GL_REFERENCED_BY_GEOMETRY_SHADER_OES symbol.
		/// </summary>
		public const int REFERENCED_BY_GEOMETRY_SHADER_OES = 0x9309;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT symbol.
		/// </summary>
		public const int FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT_LAYERS_OES symbol.
		/// </summary>
		public const int FRAMEBUFFER_DEFAULT_LAYERS_OES = 0x9312;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_LAYERS_EXT symbol.
		/// </summary>
		public const int MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317;

		/// <summary>
		/// Value of GL_MAX_FRAMEBUFFER_LAYERS_OES symbol.
		/// </summary>
		public const int MAX_FRAMEBUFFER_LAYERS_OES = 0x9317;

		/// <summary>
		/// Value of GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE symbol.
		/// </summary>
		public const int TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;

		/// <summary>
		/// Value of GL_BGRA8_EXT symbol.
		/// </summary>
		public const int BGRA8_EXT = 0x93A1;

		/// <summary>
		/// Value of GL_TEXTURE_USAGE_ANGLE symbol.
		/// </summary>
		public const int TEXTURE_USAGE_ANGLE = 0x93A2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_ANGLE symbol.
		/// </summary>
		public const int FRAMEBUFFER_ATTACHMENT_ANGLE = 0x93A3;

		/// <summary>
		/// Value of GL_PACK_REVERSE_ROW_ORDER_ANGLE symbol.
		/// </summary>
		public const int PACK_REVERSE_ROW_ORDER_ANGLE = 0x93A4;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_ANGLE symbol.
		/// </summary>
		public const int PROGRAM_BINARY_ANGLE = 0x93A6;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_3x3x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x3x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x4x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x5x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6x6_OES symbol.
		/// </summary>
		public const int COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES symbol.
		/// </summary>
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG symbol.
		/// </summary>
		public const int COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1;

		/// <summary>
		/// Binding for glActiveShaderProgramEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgramEXT != null, "pglActiveShaderProgramEXT not implemented");
			Delegates.pglActiveShaderProgramEXT(pipeline, program);
			CallLog("glActiveShaderProgramEXT({0}, {1})", pipeline, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFuncQCOM.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void AlphaFuncQCOM(int func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncQCOM != null, "pglAlphaFuncQCOM not implemented");
			Delegates.pglAlphaFuncQCOM(func, @ref);
			CallLog("glAlphaFuncQCOM({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFuncx.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void AlphaFunc(int func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncx != null, "pglAlphaFuncx not implemented");
			Delegates.pglAlphaFuncx(func, @ref);
			CallLog("glAlphaFuncx({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBeginQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BeginQueryEXT(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryEXT != null, "pglBeginQueryEXT not implemented");
			Delegates.pglBeginQueryEXT(target, id);
			CallLog("glBeginQueryEXT({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindFramebufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BindFramebufferOES(int target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferOES != null, "pglBindFramebufferOES not implemented");
			Delegates.pglBindFramebufferOES(target, framebuffer);
			CallLog("glBindFramebufferOES({0}, {1})", target, framebuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void BindProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipelineEXT != null, "pglBindProgramPipelineEXT not implemented");
			Delegates.pglBindProgramPipelineEXT(pipeline);
			CallLog("glBindProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BindRenderbufferOES(int target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferOES != null, "pglBindRenderbufferOES not implemented");
			Delegates.pglBindRenderbufferOES(target, renderbuffer);
			CallLog("glBindRenderbufferOES({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindVertexArrayOES.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BindVertexArrayOES(UInt32 array)
		{
			Debug.Assert(Delegates.pglBindVertexArrayOES != null, "pglBindVertexArrayOES not implemented");
			Delegates.pglBindVertexArrayOES(array);
			CallLog("glBindVertexArrayOES({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationOES(int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationOES != null, "pglBlendEquationOES not implemented");
			Delegates.pglBlendEquationOES(mode);
			CallLog("glBlendEquationOES({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparateOES.
		/// </summary>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationSeparateOES(int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateOES != null, "pglBlendEquationSeparateOES not implemented");
			Delegates.pglBlendEquationSeparateOES(modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparateOES({0}, {1})", modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparateiEXT.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationSeparateiEXT(UInt32 buf, int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateiEXT != null, "pglBlendEquationSeparateiEXT not implemented");
			Delegates.pglBlendEquationSeparateiEXT(buf, modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparateiEXT({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparateiOES.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationSeparateiOES(UInt32 buf, int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateiOES != null, "pglBlendEquationSeparateiOES not implemented");
			Delegates.pglBlendEquationSeparateiOES(buf, modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparateiOES({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationiEXT.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationEXT(UInt32 buf, int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationiEXT != null, "pglBlendEquationiEXT not implemented");
			Delegates.pglBlendEquationiEXT(buf, mode);
			CallLog("glBlendEquationiEXT({0}, {1})", buf, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationiOES.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationOES(UInt32 buf, int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationiOES != null, "pglBlendEquationiOES not implemented");
			Delegates.pglBlendEquationiOES(buf, mode);
			CallLog("glBlendEquationiOES({0}, {1})", buf, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparateOES.
		/// </summary>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFuncSeparateOES(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateOES != null, "pglBlendFuncSeparateOES not implemented");
			Delegates.pglBlendFuncSeparateOES(srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparateOES({0}, {1}, {2}, {3})", srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparateiEXT.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFuncSeparateiEXT(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateiEXT != null, "pglBlendFuncSeparateiEXT not implemented");
			Delegates.pglBlendFuncSeparateiEXT(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparateiEXT({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparateiOES.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFuncSeparateiOES(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateiOES != null, "pglBlendFuncSeparateiOES not implemented");
			Delegates.pglBlendFuncSeparateiOES(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparateiOES({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFunciEXT.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFunciEXT(UInt32 buf, int src, int dst)
		{
			Debug.Assert(Delegates.pglBlendFunciEXT != null, "pglBlendFunciEXT not implemented");
			Delegates.pglBlendFunciEXT(buf, src, dst);
			CallLog("glBlendFunciEXT({0}, {1}, {2})", buf, src, dst);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFunciOES.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFunciOES(UInt32 buf, int src, int dst)
		{
			Debug.Assert(Delegates.pglBlendFunciOES != null, "pglBlendFunciOES not implemented");
			Delegates.pglBlendFunciOES(buf, src, dst);
			CallLog("glBlendFunciOES({0}, {1}, {2})", buf, src, dst);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlitFramebufferANGLE.
		/// </summary>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebufferANGLE != null, "pglBlitFramebufferANGLE not implemented");
			Delegates.pglBlitFramebufferANGLE(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			CallLog("glBlitFramebufferANGLE({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlitFramebufferNV.
		/// </summary>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebufferNV != null, "pglBlitFramebufferNV not implemented");
			Delegates.pglBlitFramebufferNV(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			CallLog("glBlitFramebufferNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCheckFramebufferStatusOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static int CheckFramebufferStatusOES(int target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusOES != null, "pglCheckFramebufferStatusOES not implemented");
			retValue = Delegates.pglCheckFramebufferStatusOES(target);
			CallLog("glCheckFramebufferStatusOES({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glClearColorx.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ClearColor(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearColorx != null, "pglClearColorx not implemented");
			Delegates.pglClearColorx(red, green, blue, alpha);
			CallLog("glClearColorx({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClearDepthx.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ClearDepth(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthx != null, "pglClearDepthx not implemented");
			Delegates.pglClearDepthx(depth);
			CallLog("glClearDepthx({0})", depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClientWaitSyncAPPLE.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		public static int ClientWaitSyncAPPLE(int sync, uint flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.pglClientWaitSyncAPPLE != null, "pglClientWaitSyncAPPLE not implemented");
			retValue = Delegates.pglClientWaitSyncAPPLE(sync, flags, timeout);
			CallLog("glClientWaitSyncAPPLE({0}, {1}, {2}) = {3}", sync, flags, timeout, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glClipPlanef.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ClipPlane(int p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanef != null, "pglClipPlanef not implemented");
					Delegates.pglClipPlanef(p, p_eqn);
					CallLog("glClipPlanef({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanefIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ClipPlaneIMG(int p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanefIMG != null, "pglClipPlanefIMG not implemented");
					Delegates.pglClipPlanefIMG(p, p_eqn);
					CallLog("glClipPlanefIMG({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void ClipPlane(int plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanex != null, "pglClipPlanex not implemented");
					Delegates.pglClipPlanex(plane, p_equation);
					CallLog("glClipPlanex({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanexIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void ClipPlaneIMG(int p, IntPtr[] eqn)
		{
			unsafe {
				fixed (IntPtr* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanexIMG != null, "pglClipPlanexIMG not implemented");
					Delegates.pglClipPlanexIMG(p, p_eqn);
					CallLog("glClipPlanexIMG({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4x.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Color4(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglColor4x != null, "pglColor4x not implemented");
			Delegates.pglColor4x(red, green, blue, alpha);
			CallLog("glColor4x({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorMaskiEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void ColorMaskEXT(UInt32 index, bool r, bool g, bool b, bool a)
		{
			Debug.Assert(Delegates.pglColorMaskiEXT != null, "pglColorMaskiEXT not implemented");
			Delegates.pglColorMaskiEXT(index, r, g, b, a);
			CallLog("glColorMaskiEXT({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorMaskiOES.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void ColorMaskOES(UInt32 index, bool r, bool g, bool b, bool a)
		{
			Debug.Assert(Delegates.pglColorMaskiOES != null, "pglColorMaskiOES not implemented");
			Delegates.pglColorMaskiOES(index, r, g, b, a);
			CallLog("glColorMaskiOES({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void CompressedTexImage3DOES(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexImage3DOES != null, "pglCompressedTexImage3DOES not implemented");
			Delegates.pglCompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data);
			CallLog("glCompressedTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void CompressedTexImage3DOES(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void CompressedTexSubImage3DOES(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTexSubImage3DOES != null, "pglCompressedTexSubImage3DOES not implemented");
			Delegates.pglCompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			CallLog("glCompressedTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompressedTexSubImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void CompressedTexSubImage3DOES(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyBufferSubDataNV.
		/// </summary>
		/// <param name="readTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="writeTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void CopyBufferSubDataNV(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglCopyBufferSubDataNV != null, "pglCopyBufferSubDataNV not implemented");
			Delegates.pglCopyBufferSubDataNV(readTarget, writeTarget, readOffset, writeOffset, size);
			CallLog("glCopyBufferSubDataNV({0}, {1}, {2}, {3}, {4})", readTarget, writeTarget, readOffset, writeOffset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyImageSubDataEXT.
		/// </summary>
		/// <param name="srcName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcWidth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcHeight">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcDepth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void CopyImageSubDataEXT(UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			Debug.Assert(Delegates.pglCopyImageSubDataEXT != null, "pglCopyImageSubDataEXT not implemented");
			Delegates.pglCopyImageSubDataEXT(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			CallLog("glCopyImageSubDataEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyImageSubDataOES.
		/// </summary>
		/// <param name="srcName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcWidth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcHeight">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcDepth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void CopyImageSubDataOES(UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			Debug.Assert(Delegates.pglCopyImageSubDataOES != null, "pglCopyImageSubDataOES not implemented");
			Delegates.pglCopyImageSubDataOES(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			CallLog("glCopyImageSubDataOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
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
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void CopyTexSubImage3DOES(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage3DOES != null, "pglCopyTexSubImage3DOES not implemented");
			Delegates.pglCopyTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			CallLog("glCopyTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTextureLevelsAPPLE.
		/// </summary>
		/// <param name="destinationTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceBaseLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sourceLevelCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
		{
			Debug.Assert(Delegates.pglCopyTextureLevelsAPPLE != null, "pglCopyTextureLevelsAPPLE not implemented");
			Delegates.pglCopyTextureLevelsAPPLE(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			CallLog("glCopyTextureLevelsAPPLE({0}, {1}, {2}, {3})", destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverageMaskNV.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void CoverageMaskNV(bool mask)
		{
			Debug.Assert(Delegates.pglCoverageMaskNV != null, "pglCoverageMaskNV not implemented");
			Delegates.pglCoverageMaskNV(mask);
			CallLog("glCoverageMaskNV({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverageOperationNV.
		/// </summary>
		/// <param name="operation">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void CoverageOpNV(int operation)
		{
			Debug.Assert(Delegates.pglCoverageOperationNV != null, "pglCoverageOperationNV not implemented");
			Delegates.pglCoverageOperationNV(operation);
			CallLog("glCoverageOperationNV({0})", operation);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCreateShaderProgramvEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="strings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static UInt32 CreateShaderProgramEXT(int type, Int32 count, String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramvEXT != null, "pglCreateShaderProgramvEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramvEXT(type, count, strings);
			CallLog("glCreateShaderProgramvEXT({0}, {1}, {2}) = {3}", type, count, strings, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glCurrentPaletteMatrixOES.
		/// </summary>
		/// <param name="matrixpaletteindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixOES != null, "pglCurrentPaletteMatrixOES not implemented");
			Delegates.pglCurrentPaletteMatrixOES(matrixpaletteindex);
			CallLog("glCurrentPaletteMatrixOES({0})", matrixpaletteindex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageCallbackKHR.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void DebugMessageCallbackKHR(IntPtr callback, IntPtr userParam)
		{
			Debug.Assert(Delegates.pglDebugMessageCallbackKHR != null, "pglDebugMessageCallbackKHR not implemented");
			Delegates.pglDebugMessageCallbackKHR(callback, userParam);
			CallLog("glDebugMessageCallbackKHR({0}, {1})", callback, userParam);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageCallbackKHR.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void DebugMessageCallbackKHR(IntPtr callback, Object userParam)
		{
			GCHandle pin_userParam = GCHandle.Alloc(userParam, GCHandleType.Pinned);
			try {
				DebugMessageCallbackKHR(callback, pin_userParam.AddrOfPinnedObject());
			} finally {
				pin_userParam.Free();
			}
		}

		/// <summary>
		/// Binding for glDebugMessageControlKHR.
		/// </summary>
		/// <param name="source">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="enabled">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void DebugMessageControlKHR(int source, int type, int severity, Int32 count, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDebugMessageControlKHR != null, "pglDebugMessageControlKHR not implemented");
					Delegates.pglDebugMessageControlKHR(source, type, severity, count, p_ids, enabled);
					CallLog("glDebugMessageControlKHR({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, count, ids, enabled);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageInsertKHR.
		/// </summary>
		/// <param name="source">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buf">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void DebugMessageInsertKHR(int source, int type, UInt32 id, int severity, Int32 length, String buf)
		{
			Debug.Assert(Delegates.pglDebugMessageInsertKHR != null, "pglDebugMessageInsertKHR not implemented");
			Delegates.pglDebugMessageInsertKHR(source, type, id, severity, length, buf);
			CallLog("glDebugMessageInsertKHR({0}, {1}, {2}, {3}, {4}, {5})", source, type, id, severity, length, buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteFramebuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteFramebuffersOES(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersOES != null, "pglDeleteFramebuffersOES not implemented");
					Delegates.pglDeleteFramebuffersOES(n, p_framebuffers);
					CallLog("glDeleteFramebuffersOES({0}, {1})", n, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteProgramPipelinesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void DeleteProgramPipelinesEXT(Int32 n, UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelinesEXT != null, "pglDeleteProgramPipelinesEXT not implemented");
					Delegates.pglDeleteProgramPipelinesEXT(n, p_pipelines);
					CallLog("glDeleteProgramPipelinesEXT({0}, {1})", n, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteQueriesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteQueriesEXT(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesEXT != null, "pglDeleteQueriesEXT not implemented");
					Delegates.pglDeleteQueriesEXT(n, p_ids);
					CallLog("glDeleteQueriesEXT({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteRenderbuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteRenderbufferOES(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersOES != null, "pglDeleteRenderbuffersOES not implemented");
					Delegates.pglDeleteRenderbuffersOES(n, p_renderbuffers);
					CallLog("glDeleteRenderbuffersOES({0}, {1})", n, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteSyncAPPLE.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void DeleteSyncAPPLE(int sync)
		{
			Debug.Assert(Delegates.pglDeleteSyncAPPLE != null, "pglDeleteSyncAPPLE not implemented");
			Delegates.pglDeleteSyncAPPLE(sync);
			CallLog("glDeleteSyncAPPLE({0})", sync);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteVertexArraysOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="arrays">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteVertexArraysOES(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglDeleteVertexArraysOES != null, "pglDeleteVertexArraysOES not implemented");
					Delegates.pglDeleteVertexArraysOES(n, p_arrays);
					CallLog("glDeleteVertexArraysOES({0}, {1})", n, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangeArrayfvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void DepthRangeArrayNV(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvNV != null, "pglDepthRangeArrayfvNV not implemented");
					Delegates.pglDepthRangeArrayfvNV(first, count, p_v);
					CallLog("glDepthRangeArrayfvNV({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangeIndexedfNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void DepthRangeIndexedNV(UInt32 index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfNV != null, "pglDepthRangeIndexedfNV not implemented");
			Delegates.pglDepthRangeIndexedfNV(index, n, f);
			CallLog("glDepthRangeIndexedfNV({0}, {1}, {2})", index, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangex.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DepthRange(IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglDepthRangex != null, "pglDepthRangex not implemented");
			Delegates.pglDepthRangex(n, f);
			CallLog("glDepthRangex({0}, {1})", n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglDisableDriverControlQCOM != null, "pglDisableDriverControlQCOM not implemented");
			Delegates.pglDisableDriverControlQCOM(driverControl);
			CallLog("glDisableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableiEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableEXT(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableiEXT != null, "pglDisableiEXT not implemented");
			Delegates.pglDisableiEXT(target, index);
			CallLog("glDisableiEXT({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableNV(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableiNV != null, "pglDisableiNV not implemented");
			Delegates.pglDisableiNV(target, index);
			CallLog("glDisableiNV({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableiOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableOES(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableiOES != null, "pglDisableiOES not implemented");
			Delegates.pglDisableiOES(target, index);
			CallLog("glDisableiOES({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDiscardFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numAttachments">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachments">
		/// A <see cref="T:int[]"/>.
		/// </param>
		public static void DiscardFramebufferEXT(int target, Int32 numAttachments, int[] attachments)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglDiscardFramebufferEXT != null, "pglDiscardFramebufferEXT not implemented");
					Delegates.pglDiscardFramebufferEXT(target, numAttachments, p_attachments);
					CallLog("glDiscardFramebufferEXT({0}, {1}, {2})", target, numAttachments, attachments);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawArraysInstancedANGLE(int mode, Int32 first, Int32 count, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedANGLE != null, "pglDrawArraysInstancedANGLE not implemented");
			Delegates.pglDrawArraysInstancedANGLE(mode, first, count, primcount);
			CallLog("glDrawArraysInstancedANGLE({0}, {1}, {2}, {3})", mode, first, count, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawArraysInstancedANGLE(PrimitiveType mode, Int32 first, Int32 count, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedANGLE != null, "pglDrawArraysInstancedANGLE not implemented");
			Delegates.pglDrawArraysInstancedANGLE((int)mode, first, count, primcount);
			CallLog("glDrawArraysInstancedANGLE({0}, {1}, {2}, {3})", mode, first, count, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawArraysInstancedBaseInstanceEXT(int mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedBaseInstanceEXT != null, "pglDrawArraysInstancedBaseInstanceEXT not implemented");
			Delegates.pglDrawArraysInstancedBaseInstanceEXT(mode, first, count, instancecount, baseinstance);
			CallLog("glDrawArraysInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedBaseInstanceEXT != null, "pglDrawArraysInstancedBaseInstanceEXT not implemented");
			Delegates.pglDrawArraysInstancedBaseInstanceEXT((int)mode, first, count, instancecount, baseinstance);
			CallLog("glDrawArraysInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4})", mode, first, count, instancecount, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawArraysInstancedNV(int mode, Int32 first, Int32 count, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedNV != null, "pglDrawArraysInstancedNV not implemented");
			Delegates.pglDrawArraysInstancedNV(mode, first, count, primcount);
			CallLog("glDrawArraysInstancedNV({0}, {1}, {2}, {3})", mode, first, count, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawArraysInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawArraysInstancedNV(PrimitiveType mode, Int32 first, Int32 count, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedNV != null, "pglDrawArraysInstancedNV not implemented");
			Delegates.pglDrawArraysInstancedNV((int)mode, first, count, primcount);
			CallLog("glDrawArraysInstancedNV({0}, {1}, {2}, {3})", mode, first, count, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		public static void DrawBuffersEXT(Int32 n, int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersEXT != null, "pglDrawBuffersEXT not implemented");
					Delegates.pglDrawBuffersEXT(n, p_bufs);
					CallLog("glDrawBuffersEXT({0}, {1})", n, bufs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersIndexedEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void DrawBuffersIndexedEXT(Int32 n, int[] location, Int32[] indices)
		{
			unsafe {
				fixed (int* p_location = location)
				fixed (Int32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglDrawBuffersIndexedEXT != null, "pglDrawBuffersIndexedEXT not implemented");
					Delegates.pglDrawBuffersIndexedEXT(n, p_location, p_indices);
					CallLog("glDrawBuffersIndexedEXT({0}, {1}, {2})", n, location, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		public static void DrawBuffersNV(Int32 n, int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersNV != null, "pglDrawBuffersNV not implemented");
					Delegates.pglDrawBuffersNV(n, p_bufs);
					CallLog("glDrawBuffersNV({0}, {1})", n, bufs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexEXT(int mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertexEXT != null, "pglDrawElementsBaseVertexEXT not implemented");
			Delegates.pglDrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
			CallLog("glDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexEXT(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertexEXT != null, "pglDrawElementsBaseVertexEXT not implemented");
			Delegates.pglDrawElementsBaseVertexEXT((int)mode, count, type, indices, basevertex);
			CallLog("glDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexEXT(int mode, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsBaseVertexEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexEXT(PrimitiveType mode, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsBaseVertexEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexOES(int mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertexOES != null, "pglDrawElementsBaseVertexOES not implemented");
			Delegates.pglDrawElementsBaseVertexOES(mode, count, type, indices, basevertex);
			CallLog("glDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexOES(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsBaseVertexOES != null, "pglDrawElementsBaseVertexOES not implemented");
			Delegates.pglDrawElementsBaseVertexOES((int)mode, count, type, indices, basevertex);
			CallLog("glDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexOES(int mode, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsBaseVertexOES(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsBaseVertexOES(PrimitiveType mode, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsBaseVertexOES(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedANGLE(int mode, Int32 count, int type, IntPtr indices, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedANGLE != null, "pglDrawElementsInstancedANGLE not implemented");
			Delegates.pglDrawElementsInstancedANGLE(mode, count, type, indices, primcount);
			CallLog("glDrawElementsInstancedANGLE({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedANGLE(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedANGLE != null, "pglDrawElementsInstancedANGLE not implemented");
			Delegates.pglDrawElementsInstancedANGLE((int)mode, count, type, indices, primcount);
			CallLog("glDrawElementsInstancedANGLE({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedANGLE(int mode, Int32 count, int type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedANGLE(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedANGLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedANGLE(PrimitiveType mode, Int32 count, int type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedANGLE(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseInstanceEXT(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseInstanceEXT != null, "pglDrawElementsInstancedBaseInstanceEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
			CallLog("glDrawElementsInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseInstanceEXT != null, "pglDrawElementsInstancedBaseInstanceEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseInstanceEXT((int)mode, count, type, indices, instancecount, baseinstance);
			CallLog("glDrawElementsInstancedBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseInstanceEXT(int mode, Int32 count, int type, Object indices, Int32 instancecount, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseInstanceEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseInstanceEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexEXT(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexEXT != null, "pglDrawElementsInstancedBaseVertexEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
			CallLog("glDrawElementsInstancedBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexEXT != null, "pglDrawElementsInstancedBaseVertexEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexEXT((int)mode, count, type, indices, instancecount, basevertex);
			CallLog("glDrawElementsInstancedBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexEXT(int mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexOES(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexOES != null, "pglDrawElementsInstancedBaseVertexOES not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexOES(mode, count, type, indices, instancecount, basevertex);
			CallLog("glDrawElementsInstancedBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexOES != null, "pglDrawElementsInstancedBaseVertexOES not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexOES((int)mode, count, type, indices, instancecount, basevertex);
			CallLog("glDrawElementsInstancedBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, instancecount, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexOES(int mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexOES(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexOES(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT != null, "pglDrawElementsInstancedBaseVertexBaseInstanceEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);
			CallLog("glDrawElementsInstancedBaseVertexBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT != null, "pglDrawElementsInstancedBaseVertexBaseInstanceEXT not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexBaseInstanceEXT((int)mode, count, type, indices, instancecount, basevertex, baseinstance);
			CallLog("glDrawElementsInstancedBaseVertexBaseInstanceEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, count, type, indices, instancecount, basevertex, baseinstance);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(int mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstanceEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, Int32 count, int type, Object indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedNV(int mode, Int32 count, int type, IntPtr indices, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedNV != null, "pglDrawElementsInstancedNV not implemented");
			Delegates.pglDrawElementsInstancedNV(mode, count, type, indices, primcount);
			CallLog("glDrawElementsInstancedNV({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedNV(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedNV != null, "pglDrawElementsInstancedNV not implemented");
			Delegates.pglDrawElementsInstancedNV((int)mode, count, type, indices, primcount);
			CallLog("glDrawElementsInstancedNV({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedNV(int mode, Int32 count, int type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedNV(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawElementsInstancedNV(PrimitiveType mode, Int32 count, int type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedNV(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertexEXT != null, "pglDrawRangeElementsBaseVertexEXT not implemented");
			Delegates.pglDrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
			CallLog("glDrawRangeElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertexEXT != null, "pglDrawRangeElementsBaseVertexEXT not implemented");
			Delegates.pglDrawRangeElementsBaseVertexEXT((int)mode, start, end, count, type, indices, basevertex);
			CallLog("glDrawRangeElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertexEXT(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertexEXT(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexOES(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertexOES != null, "pglDrawRangeElementsBaseVertexOES not implemented");
			Delegates.pglDrawRangeElementsBaseVertexOES(mode, start, end, count, type, indices, basevertex);
			CallLog("glDrawRangeElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsBaseVertexOES != null, "pglDrawRangeElementsBaseVertexOES not implemented");
			Delegates.pglDrawRangeElementsBaseVertexOES((int)mode, start, end, count, type, indices, basevertex);
			CallLog("glDrawRangeElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, start, end, count, type, indices, basevertex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexOES(int mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertexOES(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawRangeElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices, Int32 basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsBaseVertexOES(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawTexfOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void DrawTexOES(float x, float y, float z, float width, float height)
		{
			Debug.Assert(Delegates.pglDrawTexfOES != null, "pglDrawTexfOES not implemented");
			Delegates.pglDrawTexfOES(x, y, z, width, height);
			CallLog("glDrawTexfOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexfvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void DrawTexOES(float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexfvOES != null, "pglDrawTexfvOES not implemented");
					Delegates.pglDrawTexfvOES(p_coords);
					CallLog("glDrawTexfvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexiOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawTexOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglDrawTexiOES != null, "pglDrawTexiOES not implemented");
			Delegates.pglDrawTexiOES(x, y, z, width, height);
			CallLog("glDrawTexiOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexivOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void DrawTexOES(Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexivOES != null, "pglDrawTexivOES not implemented");
					Delegates.pglDrawTexivOES(p_coords);
					CallLog("glDrawTexivOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexsOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int16"/>.
		/// </param>
		public static void DrawTexOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
		{
			Debug.Assert(Delegates.pglDrawTexsOES != null, "pglDrawTexsOES not implemented");
			Delegates.pglDrawTexsOES(x, y, z, width, height);
			CallLog("glDrawTexsOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexsvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		public static void DrawTexOES(Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexsvOES != null, "pglDrawTexsvOES not implemented");
					Delegates.pglDrawTexsvOES(p_coords);
					CallLog("glDrawTexsvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexxOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DrawTexOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height)
		{
			Debug.Assert(Delegates.pglDrawTexxOES != null, "pglDrawTexxOES not implemented");
			Delegates.pglDrawTexxOES(x, y, z, width, height);
			CallLog("glDrawTexxOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexxvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void DrawTexOES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexxvOES != null, "pglDrawTexxvOES not implemented");
					Delegates.pglDrawTexxvOES(p_coords);
					CallLog("glDrawTexxvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEGLImageTargetRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void EGLImageTargetRenderbufferStorageOES(int target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetRenderbufferStorageOES != null, "pglEGLImageTargetRenderbufferStorageOES not implemented");
			Delegates.pglEGLImageTargetRenderbufferStorageOES(target, image);
			CallLog("glEGLImageTargetRenderbufferStorageOES({0}, {1})", target, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEGLImageTargetTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void EGLImageTargetTexture2DOES(int target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetTexture2DOES != null, "pglEGLImageTargetTexture2DOES not implemented");
			Delegates.pglEGLImageTargetTexture2DOES(target, image);
			CallLog("glEGLImageTargetTexture2DOES({0}, {1})", target, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglEnableDriverControlQCOM != null, "pglEnableDriverControlQCOM not implemented");
			Delegates.pglEnableDriverControlQCOM(driverControl);
			CallLog("glEnableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableiEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableEXT(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableiEXT != null, "pglEnableiEXT not implemented");
			Delegates.pglEnableiEXT(target, index);
			CallLog("glEnableiEXT({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableNV(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableiNV != null, "pglEnableiNV not implemented");
			Delegates.pglEnableiNV(target, index);
			CallLog("glEnableiNV({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableiOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableOES(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableiOES != null, "pglEnableiOES not implemented");
			Delegates.pglEnableiOES(target, index);
			CallLog("glEnableiOES({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void EndQueryEXT(int target)
		{
			Debug.Assert(Delegates.pglEndQueryEXT != null, "pglEndQueryEXT not implemented");
			Delegates.pglEndQueryEXT(target);
			CallLog("glEndQueryEXT({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndTilingQCOM.
		/// </summary>
		/// <param name="preserveMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static void EndQCOM(uint preserveMask)
		{
			Debug.Assert(Delegates.pglEndTilingQCOM != null, "pglEndTilingQCOM not implemented");
			Delegates.pglEndTilingQCOM(preserveMask);
			CallLog("glEndTilingQCOM({0})", preserveMask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetBufferPointervQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ExtGetBufferPointervQCOM(int target, IntPtr @params)
		{
			Debug.Assert(Delegates.pglExtGetBufferPointervQCOM != null, "pglExtGetBufferPointervQCOM not implemented");
			Delegates.pglExtGetBufferPointervQCOM(target, @params);
			CallLog("glExtGetBufferPointervQCOM({0}, {1})", target, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetBuffersQCOM.
		/// </summary>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxBuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numBuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetBuffersQCOM(UInt32[] buffers, Int32 maxBuffers, Int32[] numBuffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (Int32* p_numBuffers = numBuffers)
				{
					Debug.Assert(Delegates.pglExtGetBuffersQCOM != null, "pglExtGetBuffersQCOM not implemented");
					Delegates.pglExtGetBuffersQCOM(p_buffers, maxBuffers, p_numBuffers);
					CallLog("glExtGetBuffersQCOM({0}, {1}, {2})", buffers, maxBuffers, numBuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetFramebuffersQCOM.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxFramebuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numFramebuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetFramebuffersQCOM(UInt32[] framebuffers, Int32 maxFramebuffers, Int32[] numFramebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				fixed (Int32* p_numFramebuffers = numFramebuffers)
				{
					Debug.Assert(Delegates.pglExtGetFramebuffersQCOM != null, "pglExtGetFramebuffersQCOM not implemented");
					Delegates.pglExtGetFramebuffersQCOM(p_framebuffers, maxFramebuffers, p_numFramebuffers);
					CallLog("glExtGetFramebuffersQCOM({0}, {1}, {2})", framebuffers, maxFramebuffers, numFramebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetProgramBinarySourceQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="shadertype">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetProgramBinarySourceQCOM(UInt32 program, int shadertype, String source, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglExtGetProgramBinarySourceQCOM != null, "pglExtGetProgramBinarySourceQCOM not implemented");
					Delegates.pglExtGetProgramBinarySourceQCOM(program, shadertype, source, p_length);
					CallLog("glExtGetProgramBinarySourceQCOM({0}, {1}, {2}, {3})", program, shadertype, source, length);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetProgramsQCOM.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxPrograms">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numPrograms">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetProgramsQCOM(UInt32[] programs, Int32 maxPrograms, Int32[] numPrograms)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (Int32* p_numPrograms = numPrograms)
				{
					Debug.Assert(Delegates.pglExtGetProgramsQCOM != null, "pglExtGetProgramsQCOM not implemented");
					Delegates.pglExtGetProgramsQCOM(p_programs, maxPrograms, p_numPrograms);
					CallLog("glExtGetProgramsQCOM({0}, {1}, {2})", programs, maxPrograms, numPrograms);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetRenderbuffersQCOM.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxRenderbuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numRenderbuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetRenderbuffersQCOM(UInt32[] renderbuffers, Int32 maxRenderbuffers, Int32[] numRenderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				fixed (Int32* p_numRenderbuffers = numRenderbuffers)
				{
					Debug.Assert(Delegates.pglExtGetRenderbuffersQCOM != null, "pglExtGetRenderbuffersQCOM not implemented");
					Delegates.pglExtGetRenderbuffersQCOM(p_renderbuffers, maxRenderbuffers, p_numRenderbuffers);
					CallLog("glExtGetRenderbuffersQCOM({0}, {1}, {2})", renderbuffers, maxRenderbuffers, numRenderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetShadersQCOM.
		/// </summary>
		/// <param name="shaders">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxShaders">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numShaders">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetShadersQCOM(UInt32[] shaders, Int32 maxShaders, Int32[] numShaders)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				fixed (Int32* p_numShaders = numShaders)
				{
					Debug.Assert(Delegates.pglExtGetShadersQCOM != null, "pglExtGetShadersQCOM not implemented");
					Delegates.pglExtGetShadersQCOM(p_shaders, maxShaders, p_numShaders);
					CallLog("glExtGetShadersQCOM({0}, {1}, {2})", shaders, maxShaders, numShaders);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexLevelParameterivQCOM.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetTexLevelParameterivQCOM(UInt32 texture, int face, Int32 level, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglExtGetTexLevelParameterivQCOM != null, "pglExtGetTexLevelParameterivQCOM not implemented");
					Delegates.pglExtGetTexLevelParameterivQCOM(texture, face, level, pname, p_params);
					CallLog("glExtGetTexLevelParameterivQCOM({0}, {1}, {2}, {3}, {4})", texture, face, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexSubImageQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ExtGetTexSubImageQCOM(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr texels)
		{
			Debug.Assert(Delegates.pglExtGetTexSubImageQCOM != null, "pglExtGetTexSubImageQCOM not implemented");
			Delegates.pglExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
			CallLog("glExtGetTexSubImageQCOM({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexturesQCOM.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxTextures">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numTextures">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetTexturesQCOM(UInt32[] textures, Int32 maxTextures, Int32[] numTextures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (Int32* p_numTextures = numTextures)
				{
					Debug.Assert(Delegates.pglExtGetTexturesQCOM != null, "pglExtGetTexturesQCOM not implemented");
					Delegates.pglExtGetTexturesQCOM(p_textures, maxTextures, p_numTextures);
					CallLog("glExtGetTexturesQCOM({0}, {1}, {2})", textures, maxTextures, numTextures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtIsProgramBinaryQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool ExtIsProgramBinaryQCOM(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglExtIsProgramBinaryQCOM != null, "pglExtIsProgramBinaryQCOM not implemented");
			retValue = Delegates.pglExtIsProgramBinaryQCOM(program);
			CallLog("glExtIsProgramBinaryQCOM({0}) = {1}", program, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glExtTexObjectStateOverrideiQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ExtTexObjectStateOverrideiQCOM(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglExtTexObjectStateOverrideiQCOM != null, "pglExtTexObjectStateOverrideiQCOM not implemented");
			Delegates.pglExtTexObjectStateOverrideiQCOM(target, pname, param);
			CallLog("glExtTexObjectStateOverrideiQCOM({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFenceSyncAPPLE.
		/// </summary>
		/// <param name="condition">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static int FenceSyncAPPLE(int condition, uint flags)
		{
			int retValue;

			Debug.Assert(Delegates.pglFenceSyncAPPLE != null, "pglFenceSyncAPPLE not implemented");
			retValue = Delegates.pglFenceSyncAPPLE(condition, flags);
			CallLog("glFenceSyncAPPLE({0}, {1}) = {2}", condition, flags, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glFlushMappedBufferRangeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void FlushMappedBufferRangeEXT(int target, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedBufferRangeEXT != null, "pglFlushMappedBufferRangeEXT not implemented");
			Delegates.pglFlushMappedBufferRangeEXT(target, offset, length);
			CallLog("glFlushMappedBufferRangeEXT({0}, {1}, {2})", target, offset, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Fog(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogx != null, "pglFogx not implemented");
			Delegates.pglFogx(pname, param);
			CallLog("glFogx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Fog(int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxv != null, "pglFogxv not implemented");
					Delegates.pglFogxv(pname, p_param);
					CallLog("glFogxv({0}, {1})", pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void FramebufferRenderbufferOES(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferOES != null, "pglFramebufferRenderbufferOES not implemented");
			Delegates.pglFramebufferRenderbufferOES(target, attachment, renderbuffertarget, renderbuffer);
			CallLog("glFramebufferRenderbufferOES({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DMultisampleEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleEXT != null, "pglFramebufferTexture2DMultisampleEXT not implemented");
			Delegates.pglFramebufferTexture2DMultisampleEXT(target, attachment, textarget, texture, level, samples);
			CallLog("glFramebufferTexture2DMultisampleEXT({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, samples);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DMultisampleIMG(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleIMG != null, "pglFramebufferTexture2DMultisampleIMG not implemented");
			Delegates.pglFramebufferTexture2DMultisampleIMG(target, attachment, textarget, texture, level, samples);
			CallLog("glFramebufferTexture2DMultisampleIMG({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, samples);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DOES(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DOES != null, "pglFramebufferTexture2DOES not implemented");
			Delegates.pglFramebufferTexture2DOES(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture2DOES({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture3DOES(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			Debug.Assert(Delegates.pglFramebufferTexture3DOES != null, "pglFramebufferTexture3DOES not implemented");
			Delegates.pglFramebufferTexture3DOES(target, attachment, textarget, texture, level, zoffset);
			CallLog("glFramebufferTexture3DOES({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTextureOES(int target, int attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTextureOES != null, "pglFramebufferTextureOES not implemented");
			Delegates.pglFramebufferTextureOES(target, attachment, texture, level);
			CallLog("glFramebufferTextureOES({0}, {1}, {2}, {3})", target, attachment, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFrustumf.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Frustum(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumf != null, "pglFrustumf not implemented");
			Delegates.pglFrustumf(l, r, b, t, n, f);
			CallLog("glFrustumf({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFrustumx.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Frustum(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglFrustumx != null, "pglFrustumx not implemented");
			Delegates.pglFrustumx(l, r, b, t, n, f);
			CallLog("glFrustumx({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenFramebuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenFramebuffersOES(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersOES != null, "pglGenFramebuffersOES not implemented");
					Delegates.pglGenFramebuffersOES(n, p_framebuffers);
					CallLog("glGenFramebuffersOES({0}, {1})", n, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenProgramPipelinesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GenProgramPipelinesEXT(Int32 n, UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelinesEXT != null, "pglGenProgramPipelinesEXT not implemented");
					Delegates.pglGenProgramPipelinesEXT(n, p_pipelines);
					CallLog("glGenProgramPipelinesEXT({0}, {1})", n, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenQueriesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenQueriesEXT(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesEXT != null, "pglGenQueriesEXT not implemented");
					Delegates.pglGenQueriesEXT(n, p_ids);
					CallLog("glGenQueriesEXT({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenRenderbuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenRenderbufferOES(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersOES != null, "pglGenRenderbuffersOES not implemented");
					Delegates.pglGenRenderbuffersOES(n, p_renderbuffers);
					CallLog("glGenRenderbuffersOES({0}, {1})", n, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenVertexArraysOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="arrays">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenVertexArraysOES(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglGenVertexArraysOES != null, "pglGenVertexArraysOES not implemented");
					Delegates.pglGenVertexArraysOES(n, p_arrays);
					CallLog("glGenVertexArraysOES({0}, {1})", n, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenerateMipmapOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void GenerateMipmapOES(int target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapOES != null, "pglGenerateMipmapOES not implemented");
			Delegates.pglGenerateMipmapOES(target);
			CallLog("glGenerateMipmapOES({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBufferPointervOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetBufferPointerOES(int target, int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetBufferPointervOES != null, "pglGetBufferPointervOES not implemented");
			Delegates.pglGetBufferPointervOES(target, pname, @params);
			CallLog("glGetBufferPointervOES({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlanef.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetClipPlane(int plane, float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanef != null, "pglGetClipPlanef not implemented");
					Delegates.pglGetClipPlanef(plane, p_equation);
					CallLog("glGetClipPlanef({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetClipPlane(int plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanex != null, "pglGetClipPlanex not implemented");
					Delegates.pglGetClipPlanex(plane, p_equation);
					CallLog("glGetClipPlanex({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetDebugMessageLogKHR.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sources">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="types">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="severities">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="lengths">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="messageLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static UInt32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, int[] sources, int[] types, UInt32[] ids, int[] severities, Int32[] lengths, [Out] StringBuilder messageLog)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_sources = sources)
				fixed (int* p_types = types)
				fixed (UInt32* p_ids = ids)
				fixed (int* p_severities = severities)
				fixed (Int32* p_lengths = lengths)
				{
					Debug.Assert(Delegates.pglGetDebugMessageLogKHR != null, "pglGetDebugMessageLogKHR not implemented");
					retValue = Delegates.pglGetDebugMessageLogKHR(count, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
					CallLog("glGetDebugMessageLogKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", count, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetDriverControlStringQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControlString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32[] length, [Out] StringBuilder driverControlString)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglGetDriverControlStringQCOM != null, "pglGetDriverControlStringQCOM not implemented");
					Delegates.pglGetDriverControlStringQCOM(driverControl, bufSize, p_length, driverControlString);
					CallLog("glGetDriverControlStringQCOM({0}, {1}, {2}, {3})", driverControl, bufSize, length, driverControlString);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetDriverControlsQCOM.
		/// </summary>
		/// <param name="num">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="driverControls">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetDriverControlsQCOM(Int32[] num, Int32 size, UInt32[] driverControls)
		{
			unsafe {
				fixed (Int32* p_num = num)
				fixed (UInt32* p_driverControls = driverControls)
				{
					Debug.Assert(Delegates.pglGetDriverControlsQCOM != null, "pglGetDriverControlsQCOM not implemented");
					Delegates.pglGetDriverControlsQCOM(p_num, size, p_driverControls);
					CallLog("glGetDriverControlsQCOM({0}, {1}, {2})", num, size, driverControls);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFixedv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetFixed(int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedv != null, "pglGetFixedv not implemented");
					Delegates.pglGetFixedv(pname, p_params);
					CallLog("glGetFixedv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFloati_vNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetFloatNV(int target, UInt32 index, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloati_vNV != null, "pglGetFloati_vNV not implemented");
					Delegates.pglGetFloati_vNV(target, index, p_data);
					CallLog("glGetFloati_vNV({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFramebufferAttachmentParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetFramebufferAttachmentParameterOES(int target, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivOES != null, "pglGetFramebufferAttachmentParameterivOES not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivOES(target, attachment, pname, p_params);
					CallLog("glGetFramebufferAttachmentParameterivOES({0}, {1}, {2}, {3})", target, attachment, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetGraphicsResetStatusEXT.
		/// </summary>
		public static int GetGraphicsResetStatusEXT()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusEXT != null, "pglGetGraphicsResetStatusEXT not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusEXT();
			CallLog("glGetGraphicsResetStatusEXT() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetGraphicsResetStatusKHR.
		/// </summary>
		[RequiredByFeature("GL_KHR_robustness")]
		public static int GetGraphicsResetStatusKHR()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusKHR != null, "pglGetGraphicsResetStatusKHR not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusKHR();
			CallLog("glGetGraphicsResetStatusKHR() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetInteger64vAPPLE.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		public static void GetInteger64vAPPLE(int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInteger64vAPPLE != null, "pglGetInteger64vAPPLE not implemented");
					Delegates.pglGetInteger64vAPPLE(pname, p_params);
					CallLog("glGetInteger64vAPPLE({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetIntegeri_vEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetIntegeri_vEXT(int target, UInt32 index, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_vEXT != null, "pglGetIntegeri_vEXT not implemented");
					Delegates.pglGetIntegeri_vEXT(target, index, p_data);
					CallLog("glGetIntegeri_vEXT({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetLightxv(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxv != null, "pglGetLightxv not implemented");
					Delegates.pglGetLightxv(light, pname, p_params);
					CallLog("glGetLightxv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetLightxvOES(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxvOES != null, "pglGetLightxvOES not implemented");
					Delegates.pglGetLightxvOES(light, pname, p_params);
					CallLog("glGetLightxvOES({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetMaterial(int face, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxv != null, "pglGetMaterialxv not implemented");
					Delegates.pglGetMaterialxv(face, pname, p_params);
					CallLog("glGetMaterialxv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetMaterialOES(int face, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxvOES != null, "pglGetMaterialxvOES not implemented");
					Delegates.pglGetMaterialxvOES(face, pname, p_params);
					CallLog("glGetMaterialxvOES({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetObjectLabelKHR.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void GetObjectKHR(int identifier, UInt32 name, Int32 bufSize, Int32[] length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglGetObjectLabelKHR != null, "pglGetObjectLabelKHR not implemented");
					Delegates.pglGetObjectLabelKHR(identifier, name, bufSize, p_length, label);
					CallLog("glGetObjectLabelKHR({0}, {1}, {2}, {3}, {4})", identifier, name, bufSize, length, label);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetObjectPtrLabelKHR.
		/// </summary>
		/// <param name="ptr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void GetObjectKHR(IntPtr ptr, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetObjectPtrLabelKHR != null, "pglGetObjectPtrLabelKHR not implemented");
					Delegates.pglGetObjectPtrLabelKHR(ptr, bufSize, p_length, label);
					CallLog("glGetObjectPtrLabelKHR({0}, {1}, {2}, {3})", ptr, bufSize, length, label);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetObjectPtrLabelKHR.
		/// </summary>
		/// <param name="ptr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void GetObjectKHR(Object ptr, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
			try {
				GetObjectKHR(pin_ptr.AddrOfPinnedObject(), bufSize, out length, label);
			} finally {
				pin_ptr.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPointervKHR.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void GetPointerKHR(int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetPointervKHR != null, "pglGetPointervKHR not implemented");
			Delegates.pglGetPointervKHR(pname, @params);
			CallLog("glGetPointervKHR({0}, {1})", pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramBinaryOES.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="binary">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetProgramBinaryOES(UInt32 program, Int32 bufSize, out Int32 length, out int binaryFormat, IntPtr binary)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (int* p_binaryFormat = &binaryFormat)
				{
					Debug.Assert(Delegates.pglGetProgramBinaryOES != null, "pglGetProgramBinaryOES not implemented");
					Delegates.pglGetProgramBinaryOES(program, bufSize, p_length, p_binaryFormat, binary);
					CallLog("glGetProgramBinaryOES({0}, {1}, {2}, {3}, {4})", program, bufSize, length, binaryFormat, binary);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramPipelineInfoLogEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="infoLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLogEXT != null, "pglGetProgramPipelineInfoLogEXT not implemented");
					Delegates.pglGetProgramPipelineInfoLogEXT(pipeline, bufSize, p_length, infoLog);
					CallLog("glGetProgramPipelineInfoLogEXT({0}, {1}, {2}, {3})", pipeline, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramPipelineivEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GetProgramPipelineEXT(UInt32 pipeline, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineivEXT != null, "pglGetProgramPipelineivEXT not implemented");
					Delegates.pglGetProgramPipelineivEXT(pipeline, pname, p_params);
					CallLog("glGetProgramPipelineivEXT({0}, {1}, {2})", pipeline, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetQueryObjectEXT(UInt32 id, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectivEXT != null, "pglGetQueryObjectivEXT not implemented");
					Delegates.pglGetQueryObjectivEXT(id, pname, p_params);
					CallLog("glGetQueryObjectivEXT({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetQueryObjectuivEXT(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, pname, p_params);
					CallLog("glGetQueryObjectuivEXT({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryivEXT.
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
		public static void GetQueryEXT(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT(target, pname, p_params);
					CallLog("glGetQueryivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetRenderbufferParameterivOES.
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
		public static void GetRenderbufferParameterOES(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivOES != null, "pglGetRenderbufferParameterivOES not implemented");
					Delegates.pglGetRenderbufferParameterivOES(target, pname, p_params);
					CallLog("glGetRenderbufferParameterivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSamplerParameterIivEXT.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetSamplerParameterIivEXT(UInt32 sampler, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIivEXT != null, "pglGetSamplerParameterIivEXT not implemented");
					Delegates.pglGetSamplerParameterIivEXT(sampler, pname, p_params);
					CallLog("glGetSamplerParameterIivEXT({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSamplerParameterIivOES.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetSamplerParameterIivOES(UInt32 sampler, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIivOES != null, "pglGetSamplerParameterIivOES not implemented");
					Delegates.pglGetSamplerParameterIivOES(sampler, pname, p_params);
					CallLog("glGetSamplerParameterIivOES({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSamplerParameterIuivEXT.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetSamplerParameterIuivEXT(UInt32 sampler, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIuivEXT != null, "pglGetSamplerParameterIuivEXT not implemented");
					Delegates.pglGetSamplerParameterIuivEXT(sampler, pname, p_params);
					CallLog("glGetSamplerParameterIuivEXT({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSamplerParameterIuivOES.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetSamplerParameterIuivOES(UInt32 sampler, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIuivOES != null, "pglGetSamplerParameterIuivOES not implemented");
					Delegates.pglGetSamplerParameterIuivOES(sampler, pname, p_params);
					CallLog("glGetSamplerParameterIuivOES({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSyncivAPPLE.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetSyncAPPLE(int sync, int pname, Int32 bufSize, Int32[] length, Int32[] values)
		{
			unsafe {
				fixed (Int32* p_length = length)
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetSyncivAPPLE != null, "pglGetSyncivAPPLE not implemented");
					Delegates.pglGetSyncivAPPLE(sync, pname, bufSize, p_length, p_values);
					CallLog("glGetSyncivAPPLE({0}, {1}, {2}, {3}, {4})", sync, pname, bufSize, length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetTexEnv(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxv != null, "pglGetTexEnvxv not implemented");
					Delegates.pglGetTexEnvxv(target, pname, p_params);
					CallLog("glGetTexEnvxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetTexGenOES(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfvOES != null, "pglGetTexGenfvOES not implemented");
					Delegates.pglGetTexGenfvOES(coord, pname, p_params);
					CallLog("glGetTexGenfvOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetTexGenOES(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenivOES != null, "pglGetTexGenivOES not implemented");
					Delegates.pglGetTexGenivOES(coord, pname, p_params);
					CallLog("glGetTexGenivOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIivOES.
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
		public static void GetTexParameterIivOES(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIivOES != null, "pglGetTexParameterIivOES not implemented");
					Delegates.pglGetTexParameterIivOES(target, pname, p_params);
					CallLog("glGetTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIivOES.
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
		public static void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIivOES != null, "pglGetTexParameterIivOES not implemented");
					Delegates.pglGetTexParameterIivOES((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIuivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetTexParameterIuivOES(int target, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIuivOES != null, "pglGetTexParameterIuivOES not implemented");
					Delegates.pglGetTexParameterIuivOES(target, pname, p_params);
					CallLog("glGetTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIuivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIuivOES != null, "pglGetTexParameterIuivOES not implemented");
					Delegates.pglGetTexParameterIuivOES((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetTexParameter(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxv != null, "pglGetTexParameterxv not implemented");
					Delegates.pglGetTexParameterxv(target, pname, p_params);
					CallLog("glGetTexParameterxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTranslatedShaderSourceANGLE.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, out Int32 length, String source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetTranslatedShaderSourceANGLE != null, "pglGetTranslatedShaderSourceANGLE not implemented");
					Delegates.pglGetTranslatedShaderSourceANGLE(shader, bufsize, p_length, source);
					CallLog("glGetTranslatedShaderSourceANGLE({0}, {1}, {2}, {3})", shader, bufsize, length, source);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformfvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetnUniformEXT(UInt32 program, Int32 location, Int32 bufSize, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvEXT != null, "pglGetnUniformfvEXT not implemented");
					Delegates.pglGetnUniformfvEXT(program, location, bufSize, p_params);
					CallLog("glGetnUniformfvEXT({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformfvKHR.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniformKHR(UInt32 program, Int32 location, Int32 bufSize, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvKHR != null, "pglGetnUniformfvKHR not implemented");
					Delegates.pglGetnUniformfvKHR(program, location, bufSize, p_params);
					CallLog("glGetnUniformfvKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetnUniformEXT(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivEXT != null, "pglGetnUniformivEXT not implemented");
					Delegates.pglGetnUniformivEXT(program, location, bufSize, p_params);
					CallLog("glGetnUniformivEXT({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformivKHR.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniformKHR(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivKHR != null, "pglGetnUniformivKHR not implemented");
					Delegates.pglGetnUniformivKHR(program, location, bufSize, p_params);
					CallLog("glGetnUniformivKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformuivKHR.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniformKHR(UInt32 program, Int32 location, Int32 bufSize, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuivKHR != null, "pglGetnUniformuivKHR not implemented");
					Delegates.pglGetnUniformuivKHR(program, location, bufSize, p_params);
					CallLog("glGetnUniformuivKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsEnablediEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsEnablediEXT(int target, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnablediEXT != null, "pglIsEnablediEXT not implemented");
			retValue = Delegates.pglIsEnablediEXT(target, index);
			CallLog("glIsEnablediEXT({0}, {1}) = {2}", target, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsEnablediOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsEnablediOES(int target, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnablediOES != null, "pglIsEnablediOES not implemented");
			retValue = Delegates.pglIsEnablediOES(target, index);
			CallLog("glIsEnablediOES({0}, {1}) = {2}", target, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsEnablediNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsEnablediNV(int target, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnablediNV != null, "pglIsEnablediNV not implemented");
			retValue = Delegates.pglIsEnablediNV(target, index);
			CallLog("glIsEnablediNV({0}, {1}) = {2}", target, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsFramebufferOES.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsFramebufferOES(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebufferOES != null, "pglIsFramebufferOES not implemented");
			retValue = Delegates.pglIsFramebufferOES(framebuffer);
			CallLog("glIsFramebufferOES({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static bool IsProgramPipelineEXT(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipelineEXT != null, "pglIsProgramPipelineEXT not implemented");
			retValue = Delegates.pglIsProgramPipelineEXT(pipeline);
			CallLog("glIsProgramPipelineEXT({0}) = {1}", pipeline, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsQueryEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsQueryEXT(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQueryEXT != null, "pglIsQueryEXT not implemented");
			retValue = Delegates.pglIsQueryEXT(id);
			CallLog("glIsQueryEXT({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsRenderbufferOES.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsRenderbufferOES(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbufferOES != null, "pglIsRenderbufferOES not implemented");
			retValue = Delegates.pglIsRenderbufferOES(renderbuffer);
			CallLog("glIsRenderbufferOES({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsSyncAPPLE.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:int"/>.
		/// </param>
		public static bool IsSyncAPPLE(int sync)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSyncAPPLE != null, "pglIsSyncAPPLE not implemented");
			retValue = Delegates.pglIsSyncAPPLE(sync);
			CallLog("glIsSyncAPPLE({0}) = {1}", sync, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsVertexArrayOES.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsVertexArrayOES(UInt32 array)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVertexArrayOES != null, "pglIsVertexArrayOES not implemented");
			retValue = Delegates.pglIsVertexArrayOES(array);
			CallLog("glIsVertexArrayOES({0}) = {1}", array, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glLightModelx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void LightModel(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelx != null, "pglLightModelx not implemented");
			Delegates.pglLightModelx(pname, param);
			CallLog("glLightModelx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void LightModel(int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxv != null, "pglLightModelxv not implemented");
					Delegates.pglLightModelxv(pname, p_param);
					CallLog("glLightModelxv({0}, {1})", pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightx.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Lightx(int light, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightx != null, "pglLightx not implemented");
			Delegates.pglLightx(light, pname, param);
			CallLog("glLightx({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Lightxv(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxv != null, "pglLightxv not implemented");
					Delegates.pglLightxv(light, pname, p_params);
					CallLog("glLightxv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLineWidthx.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void LineWidth(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthx != null, "pglLineWidthx not implemented");
			Delegates.pglLineWidthx(width);
			CallLog("glLineWidthx({0})", width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void LoadMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixx != null, "pglLoadMatrixx not implemented");
					Delegates.pglLoadMatrixx(p_m);
					CallLog("glLoadMatrixx({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadPaletteFromModelViewMatrixOES.
		/// </summary>
		public static void LoadPaletteFromModelViewMatrixOES()
		{
			Debug.Assert(Delegates.pglLoadPaletteFromModelViewMatrixOES != null, "pglLoadPaletteFromModelViewMatrixOES not implemented");
			Delegates.pglLoadPaletteFromModelViewMatrixOES();
			CallLog("glLoadPaletteFromModelViewMatrixOES()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMapBufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		public static IntPtr MapBufferOES(int target, int access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferOES != null, "pglMapBufferOES not implemented");
			retValue = Delegates.pglMapBufferOES(target, access);
			CallLog("glMapBufferOES({0}, {1}) = {2}", target, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMapBufferRangeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static IntPtr MapBufferRangeEXT(int target, IntPtr offset, UInt32 length, uint access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferRangeEXT != null, "pglMapBufferRangeEXT not implemented");
			retValue = Delegates.pglMapBufferRangeEXT(target, offset, length, access);
			CallLog("glMapBufferRangeEXT({0}, {1}, {2}, {3}) = {4}", target, offset, length, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMaterialx.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Material(int face, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialx != null, "pglMaterialx not implemented");
			Delegates.pglMaterialx(face, pname, param);
			CallLog("glMaterialx({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Material(int face, int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxv != null, "pglMaterialxv not implemented");
					Delegates.pglMaterialxv(face, pname, p_param);
					CallLog("glMaterialxv({0}, {1}, {2})", face, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
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
		public static void MatrixIndexPointerOES(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerOES != null, "pglMatrixIndexPointerOES not implemented");
			Delegates.pglMatrixIndexPointerOES(size, type, stride, pointer);
			CallLog("glMatrixIndexPointerOES({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
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
		public static void MatrixIndexPointerOES(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glMinSampleShadingOES.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void MinSampleShadingOES(float value)
		{
			Debug.Assert(Delegates.pglMinSampleShadingOES != null, "pglMinSampleShadingOES not implemented");
			Delegates.pglMinSampleShadingOES(value);
			CallLog("glMinSampleShadingOES({0})", value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void MultMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixx != null, "pglMultMatrixx not implemented");
					Delegates.pglMultMatrixx(p_m);
					CallLog("glMultMatrixx({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void MultiDrawArraysIndirectEXT(int mode, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectEXT != null, "pglMultiDrawArraysIndirectEXT not implemented");
			Delegates.pglMultiDrawArraysIndirectEXT(mode, indirect, drawcount, stride);
			CallLog("glMultiDrawArraysIndirectEXT({0}, {1}, {2}, {3})", mode, indirect, drawcount, stride);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void MultiDrawArraysIndirectEXT(int mode, Object indirect, Int32 drawcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirectEXT(mode, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void MultiDrawElementsBaseVertexEXT(int mode, Int32[] count, int type, IntPtr indices, Int32 primcount, Int32[] basevertex)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (Int32* p_basevertex = basevertex)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsBaseVertexEXT != null, "pglMultiDrawElementsBaseVertexEXT not implemented");
					Delegates.pglMultiDrawElementsBaseVertexEXT(mode, p_count, type, indices, primcount, p_basevertex);
					CallLog("glMultiDrawElementsBaseVertexEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, primcount, basevertex);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsBaseVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void MultiDrawElementsBaseVertexEXT(int mode, Int32[] count, int type, Object indices, Int32 primcount, Int32[] basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElementsBaseVertexEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void MultiDrawElementsBaseVertexOES(int mode, Int32[] count, int type, IntPtr indices, Int32 primcount, Int32[] basevertex)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (Int32* p_basevertex = basevertex)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsBaseVertexOES != null, "pglMultiDrawElementsBaseVertexOES not implemented");
					Delegates.pglMultiDrawElementsBaseVertexOES(mode, p_count, type, indices, primcount, p_basevertex);
					CallLog("glMultiDrawElementsBaseVertexOES({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, primcount, basevertex);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsBaseVertexOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void MultiDrawElementsBaseVertexOES(int mode, Int32[] count, int type, Object indices, Int32 primcount, Int32[] basevertex)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElementsBaseVertexOES(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void MultiDrawElementsIndirectEXT(int mode, int type, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectEXT != null, "pglMultiDrawElementsIndirectEXT not implemented");
			Delegates.pglMultiDrawElementsIndirectEXT(mode, type, indirect, drawcount, stride);
			CallLog("glMultiDrawElementsIndirectEXT({0}, {1}, {2}, {3}, {4})", mode, type, indirect, drawcount, stride);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void MultiDrawElementsIndirectEXT(int mode, int type, Object indirect, Int32 drawcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirectEXT(mode, type, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexCoord4x.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void MultiTexCoord4(int texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4x != null, "pglMultiTexCoord4x not implemented");
			Delegates.pglMultiTexCoord4x(texture, s, t, r, q);
			CallLog("glMultiTexCoord4x({0}, {1}, {2}, {3}, {4})", texture, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3x.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Normal3(IntPtr nx, IntPtr ny, IntPtr nz)
		{
			Debug.Assert(Delegates.pglNormal3x != null, "pglNormal3x not implemented");
			Delegates.pglNormal3x(nx, ny, nz);
			CallLog("glNormal3x({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glObjectLabelKHR.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void ObjectKHR(int identifier, UInt32 name, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglObjectLabelKHR != null, "pglObjectLabelKHR not implemented");
			Delegates.pglObjectLabelKHR(identifier, name, length, label);
			CallLog("glObjectLabelKHR({0}, {1}, {2}, {3})", identifier, name, length, label);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glObjectPtrLabelKHR.
		/// </summary>
		/// <param name="ptr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void ObjectKHR(IntPtr ptr, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglObjectPtrLabelKHR != null, "pglObjectPtrLabelKHR not implemented");
			Delegates.pglObjectPtrLabelKHR(ptr, length, label);
			CallLog("glObjectPtrLabelKHR({0}, {1}, {2})", ptr, length, label);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glObjectPtrLabelKHR.
		/// </summary>
		/// <param name="ptr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void ObjectKHR(Object ptr, Int32 length, String label)
		{
			GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
			try {
				ObjectKHR(pin_ptr.AddrOfPinnedObject(), length, label);
			} finally {
				pin_ptr.Free();
			}
		}

		/// <summary>
		/// Binding for glOrthof.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Ortho(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthof != null, "pglOrthof not implemented");
			Delegates.pglOrthof(l, r, b, t, n, f);
			CallLog("glOrthof({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glOrthox.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Orthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglOrthox != null, "pglOrthox not implemented");
			Delegates.pglOrthox(l, r, b, t, n, f);
			CallLog("glOrthox({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPatchParameteriEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void PatchParameterEXT(int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPatchParameteriEXT != null, "pglPatchParameteriEXT not implemented");
			Delegates.pglPatchParameteriEXT(pname, value);
			CallLog("glPatchParameteriEXT({0}, {1})", pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPatchParameteriOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void PatchParameterOES(int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglPatchParameteriOES != null, "pglPatchParameteriOES not implemented");
			Delegates.pglPatchParameteriOES(pname, value);
			CallLog("glPatchParameteriOES({0}, {1})", pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PointParameter(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterx != null, "pglPointParameterx not implemented");
			Delegates.pglPointParameterx(pname, param);
			CallLog("glPointParameterx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PointParameterOES(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterxOES != null, "pglPointParameterxOES not implemented");
			Delegates.pglPointParameterxOES(pname, param);
			CallLog("glPointParameterxOES({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void PointParameter(int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterxv != null, "pglPointParameterxv not implemented");
					Delegates.pglPointParameterxv(pname, p_params);
					CallLog("glPointParameterxv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointSizePointerOES.
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
		public static void PointSizePointerOES(int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPointSizePointerOES != null, "pglPointSizePointerOES not implemented");
			Delegates.pglPointSizePointerOES(type, stride, pointer);
			CallLog("glPointSizePointerOES({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointSizePointerOES.
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
		public static void PointSizePointerOES(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				PointSizePointerOES(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glPointSizex.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PointSize(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizex != null, "pglPointSizex not implemented");
			Delegates.pglPointSizex(size);
			CallLog("glPointSizex({0})", size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPolygonOffsetx.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PolygonOffset(IntPtr factor, IntPtr units)
		{
			Debug.Assert(Delegates.pglPolygonOffsetx != null, "pglPolygonOffsetx not implemented");
			Delegates.pglPolygonOffsetx(factor, units);
			CallLog("glPolygonOffsetx({0}, {1})", factor, units);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopDebugGroupKHR.
		/// </summary>
		[RequiredByFeature("GL_KHR_debug")]
		public static void PopDebugGroupKHR()
		{
			Debug.Assert(Delegates.pglPopDebugGroupKHR != null, "pglPopDebugGroupKHR not implemented");
			Delegates.pglPopDebugGroupKHR();
			CallLog("glPopDebugGroupKHR()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPrimitiveBoundingBoxEXT.
		/// </summary>
		/// <param name="minX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minW">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxW">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void PrimitiveEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Debug.Assert(Delegates.pglPrimitiveBoundingBoxEXT != null, "pglPrimitiveBoundingBoxEXT not implemented");
			Delegates.pglPrimitiveBoundingBoxEXT(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			CallLog("glPrimitiveBoundingBoxEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPrimitiveBoundingBoxOES.
		/// </summary>
		/// <param name="minX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minW">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxW">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void PrimitiveOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Debug.Assert(Delegates.pglPrimitiveBoundingBoxOES != null, "pglPrimitiveBoundingBoxOES not implemented");
			Delegates.pglPrimitiveBoundingBoxOES(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			CallLog("glPrimitiveBoundingBoxOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramBinaryOES.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="binary">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ProgramBinaryOES(UInt32 program, int binaryFormat, IntPtr binary, Int32 length)
		{
			Debug.Assert(Delegates.pglProgramBinaryOES != null, "pglProgramBinaryOES not implemented");
			Delegates.pglProgramBinaryOES(program, binaryFormat, binary, length);
			CallLog("glProgramBinaryOES({0}, {1}, {2}, {3})", program, binaryFormat, binary, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramBinaryOES.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="binary">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ProgramBinaryOES(UInt32 program, int binaryFormat, Object binary, Int32 length)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				ProgramBinaryOES(program, binaryFormat, pin_binary.AddrOfPinnedObject(), length);
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// Binding for glPushDebugGroupKHR.
		/// </summary>
		/// <param name="source">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="message">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_debug")]
		public static void PushDebugGroupKHR(int source, UInt32 id, Int32 length, String message)
		{
			Debug.Assert(Delegates.pglPushDebugGroupKHR != null, "pglPushDebugGroupKHR not implemented");
			Delegates.pglPushDebugGroupKHR(source, id, length, message);
			CallLog("glPushDebugGroupKHR({0}, {1}, {2}, {3})", source, id, length, message);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glQueryCounterEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void QueryCounterEXT(UInt32 id, int target)
		{
			Debug.Assert(Delegates.pglQueryCounterEXT != null, "pglQueryCounterEXT not implemented");
			Delegates.pglQueryCounterEXT(id, target);
			CallLog("glQueryCounterEXT({0}, {1})", id, target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadBufferIndexedEXT.
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ReadBufferIndexedEXT(int src, Int32 index)
		{
			Debug.Assert(Delegates.pglReadBufferIndexedEXT != null, "pglReadBufferIndexedEXT not implemented");
			Delegates.pglReadBufferIndexedEXT(src, index);
			CallLog("glReadBufferIndexedEXT({0}, {1})", src, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadBufferNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void ReadBufferNV(int mode)
		{
			Debug.Assert(Delegates.pglReadBufferNV != null, "pglReadBufferNV not implemented");
			Delegates.pglReadBufferNV(mode);
			CallLog("glReadBufferNV({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadnPixelsEXT.
		/// </summary>
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixelsEXT != null, "pglReadnPixelsEXT not implemented");
			Delegates.pglReadnPixelsEXT(x, y, width, height, format, type, bufSize, data);
			CallLog("glReadnPixelsEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadnPixelsKHR.
		/// </summary>
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_robustness")]
		public static void ReadnPixelsKHR(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixelsKHR != null, "pglReadnPixelsKHR not implemented");
			Delegates.pglReadnPixelsKHR(x, y, width, height, format, type, bufSize, data);
			CallLog("glReadnPixelsKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadnPixelsKHR.
		/// </summary>
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_KHR_robustness")]
		public static void ReadnPixelsKHR(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixelsKHR != null, "pglReadnPixelsKHR not implemented");
			Delegates.pglReadnPixelsKHR(x, y, width, height, (int)format, (int)type, bufSize, data);
			CallLog("glReadnPixelsKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleANGLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
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
		public static void RenderbufferStorageMultisampleANGLE(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleANGLE != null, "pglRenderbufferStorageMultisampleANGLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleANGLE(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleANGLE({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
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
		public static void RenderbufferStorageMultisampleAPPLE(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleAPPLE != null, "pglRenderbufferStorageMultisampleAPPLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleAPPLE(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleAPPLE({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
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
		public static void RenderbufferStorageMultisampleIMG(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleIMG != null, "pglRenderbufferStorageMultisampleIMG not implemented");
			Delegates.pglRenderbufferStorageMultisampleIMG(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleIMG({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
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
		public static void RenderbufferStorageMultisampleNV(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleNV != null, "pglRenderbufferStorageMultisampleNV not implemented");
			Delegates.pglRenderbufferStorageMultisampleNV(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleNV({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageOES.
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
		public static void RenderbufferStorageOES(int target, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageOES != null, "pglRenderbufferStorageOES not implemented");
			Delegates.pglRenderbufferStorageOES(target, internalformat, width, height);
			CallLog("glRenderbufferStorageOES({0}, {1}, {2}, {3})", target, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResolveMultisampleFramebufferAPPLE.
		/// </summary>
		public static void ResolveMultisampleFramebufferAPPLE()
		{
			Debug.Assert(Delegates.pglResolveMultisampleFramebufferAPPLE != null, "pglResolveMultisampleFramebufferAPPLE not implemented");
			Delegates.pglResolveMultisampleFramebufferAPPLE();
			CallLog("glResolveMultisampleFramebufferAPPLE()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRotatex.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Rotate(IntPtr angle, IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRotatex != null, "pglRotatex not implemented");
			Delegates.pglRotatex(angle, x, y, z);
			CallLog("glRotatex({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSampleCoveragex.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void SampleCoverage(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragex != null, "pglSampleCoveragex not implemented");
			Delegates.pglSampleCoveragex(value, invert);
			CallLog("glSampleCoveragex({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSampleCoveragexOES.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void SampleCoverageOES(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragexOES != null, "pglSampleCoveragexOES not implemented");
			Delegates.pglSampleCoveragexOES(value, invert);
			CallLog("glSampleCoveragexOES({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIivEXT.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void SamplerParameterIivEXT(UInt32 sampler, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIivEXT != null, "pglSamplerParameterIivEXT not implemented");
					Delegates.pglSamplerParameterIivEXT(sampler, pname, p_param);
					CallLog("glSamplerParameterIivEXT({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIivOES.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void SamplerParameterIivOES(UInt32 sampler, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIivOES != null, "pglSamplerParameterIivOES not implemented");
					Delegates.pglSamplerParameterIivOES(sampler, pname, p_param);
					CallLog("glSamplerParameterIivOES({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIuivEXT.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void SamplerParameterIuivEXT(UInt32 sampler, int pname, UInt32[] param)
		{
			unsafe {
				fixed (UInt32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIuivEXT != null, "pglSamplerParameterIuivEXT not implemented");
					Delegates.pglSamplerParameterIuivEXT(sampler, pname, p_param);
					CallLog("glSamplerParameterIuivEXT({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIuivOES.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void SamplerParameterIuivOES(UInt32 sampler, int pname, UInt32[] param)
		{
			unsafe {
				fixed (UInt32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIuivOES != null, "pglSamplerParameterIuivOES not implemented");
					Delegates.pglSamplerParameterIuivOES(sampler, pname, p_param);
					CallLog("glSamplerParameterIuivOES({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScalex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Scale(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglScalex != null, "pglScalex not implemented");
			Delegates.pglScalex(x, y, z);
			CallLog("glScalex({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScissorArrayvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ScissorArrayNV(UInt32 first, Int32 count, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorArrayvNV != null, "pglScissorArrayvNV not implemented");
					Delegates.pglScissorArrayvNV(first, count, p_v);
					CallLog("glScissorArrayvNV({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScissorIndexedNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="left">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ScissorIndexedNV(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissorIndexedNV != null, "pglScissorIndexedNV not implemented");
			Delegates.pglScissorIndexedNV(index, left, bottom, width, height);
			CallLog("glScissorIndexedNV({0}, {1}, {2}, {3}, {4})", index, left, bottom, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScissorIndexedvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ScissorIndexedNV(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorIndexedvNV != null, "pglScissorIndexedvNV not implemented");
					Delegates.pglScissorIndexedvNV(index, p_v);
					CallLog("glScissorIndexedvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStartTilingQCOM.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="preserveMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static void StartQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, uint preserveMask)
		{
			Debug.Assert(Delegates.pglStartTilingQCOM != null, "pglStartTilingQCOM not implemented");
			Delegates.pglStartTilingQCOM(x, y, width, height, preserveMask);
			CallLog("glStartTilingQCOM({0}, {1}, {2}, {3}, {4})", x, y, width, height, preserveMask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexBufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TexBufferOES(int target, int internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTexBufferOES != null, "pglTexBufferOES not implemented");
			Delegates.pglTexBufferOES(target, internalformat, buffer);
			CallLog("glTexBufferOES({0}, {1}, {2})", target, internalformat, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexBufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TexBufferOES(TextureTarget target, int internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTexBufferOES != null, "pglTexBufferOES not implemented");
			Delegates.pglTexBufferOES((int)target, internalformat, buffer);
			CallLog("glTexBufferOES({0}, {1}, {2})", target, internalformat, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexBufferRangeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TexBufferRangeEXT(int target, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTexBufferRangeEXT != null, "pglTexBufferRangeEXT not implemented");
			Delegates.pglTexBufferRangeEXT(target, internalformat, buffer, offset, size);
			CallLog("glTexBufferRangeEXT({0}, {1}, {2}, {3}, {4})", target, internalformat, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexBufferRangeOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TexBufferRangeOES(int target, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTexBufferRangeOES != null, "pglTexBufferRangeOES not implemented");
			Delegates.pglTexBufferRangeOES(target, internalformat, buffer, offset, size);
			CallLog("glTexBufferRangeOES({0}, {1}, {2}, {3}, {4})", target, internalformat, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexEnvx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexEnv(int target, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvx != null, "pglTexEnvx not implemented");
			Delegates.pglTexEnvx(target, pname, param);
			CallLog("glTexEnvx({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void TexEnv(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxv != null, "pglTexEnvxv not implemented");
					Delegates.pglTexEnvxv(target, pname, p_params);
					CallLog("glTexEnvxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenfOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenfOES != null, "pglTexGenfOES not implemented");
			Delegates.pglTexGenfOES(coord, pname, param);
			CallLog("glTexGenfOES({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfvOES != null, "pglTexGenfvOES not implemented");
					Delegates.pglTexGenfvOES(coord, pname, p_params);
					CallLog("glTexGenfvOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGeniOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeniOES != null, "pglTexGeniOES not implemented");
			Delegates.pglTexGeniOES(coord, pname, param);
			CallLog("glTexGeniOES({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenivOES != null, "pglTexGenivOES not implemented");
					Delegates.pglTexGenivOES(coord, pname, p_params);
					CallLog("glTexGenivOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexImage3DOES(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage3DOES != null, "pglTexImage3DOES not implemented");
			Delegates.pglTexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels);
			CallLog("glTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexImage3DOES(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTexParameterIivOES.
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
		public static void TexParameterIivOES(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIivOES != null, "pglTexParameterIivOES not implemented");
					Delegates.pglTexParameterIivOES(target, pname, p_params);
					CallLog("glTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIivOES.
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
		public static void TexParameterIivOES(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIivOES != null, "pglTexParameterIivOES not implemented");
					Delegates.pglTexParameterIivOES((int)target, (int)pname, p_params);
					CallLog("glTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void TexParameterIuivOES(int target, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIuivOES != null, "pglTexParameterIuivOES not implemented");
					Delegates.pglTexParameterIuivOES(target, pname, p_params);
					CallLog("glTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIuivOES != null, "pglTexParameterIuivOES not implemented");
					Delegates.pglTexParameterIuivOES((int)target, (int)pname, p_params);
					CallLog("glTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexParameter(int target, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterx != null, "pglTexParameterx not implemented");
			Delegates.pglTexParameterx(target, pname, param);
			CallLog("glTexParameterx({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void TexParameter(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxv != null, "pglTexParameterxv not implemented");
					Delegates.pglTexParameterxv(target, pname, p_params);
					CallLog("glTexParameterxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TexStorage1DEXT(int target, Int32 levels, int internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTexStorage1DEXT != null, "pglTexStorage1DEXT not implemented");
			Delegates.pglTexStorage1DEXT(target, levels, internalformat, width);
			CallLog("glTexStorage1DEXT({0}, {1}, {2}, {3})", target, levels, internalformat, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
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
		public static void TexStorage2DEXT(int target, Int32 levels, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTexStorage2DEXT != null, "pglTexStorage2DEXT not implemented");
			Delegates.pglTexStorage2DEXT(target, levels, internalformat, width, height);
			CallLog("glTexStorage2DEXT({0}, {1}, {2}, {3}, {4})", target, levels, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TexStorage3DEXT(int target, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTexStorage3DEXT != null, "pglTexStorage3DEXT not implemented");
			Delegates.pglTexStorage3DEXT(target, levels, internalformat, width, height, depth);
			CallLog("glTexStorage3DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, levels, internalformat, width, height, depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexStorage3DMultisampleOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
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
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void TexStorage3DMultisampleOES(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTexStorage3DMultisampleOES != null, "pglTexStorage3DMultisampleOES not implemented");
			Delegates.pglTexStorage3DMultisampleOES(target, samples, internalformat, width, height, depth, fixedsamplelocations);
			CallLog("glTexStorage3DMultisampleOES({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, samples, internalformat, width, height, depth, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexSubImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexSubImage3DOES(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage3DOES != null, "pglTexSubImage3DOES not implemented");
			Delegates.pglTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			CallLog("glTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexSubImage3DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexSubImage3DOES(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureViewEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="origtexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="minlevel">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numlevels">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minlayer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numlayers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TextureEXT(UInt32 texture, int target, UInt32 origtexture, int internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			Debug.Assert(Delegates.pglTextureViewEXT != null, "pglTextureViewEXT not implemented");
			Delegates.pglTextureViewEXT(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			CallLog("glTextureViewEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureViewOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="origtexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="minlevel">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numlevels">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minlayer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numlayers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void TextureOES(UInt32 texture, int target, UInt32 origtexture, int internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			Debug.Assert(Delegates.pglTextureViewOES != null, "pglTextureViewOES not implemented");
			Delegates.pglTextureViewOES(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			CallLog("glTextureViewOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTranslatex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Translate(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglTranslatex != null, "pglTranslatex not implemented");
			Delegates.pglTranslatex(x, y, z);
			CallLog("glTranslatex({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix2x3fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix2x3NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x3fvNV != null, "pglUniformMatrix2x3fvNV not implemented");
					Delegates.pglUniformMatrix2x3fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x3fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix2x4fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix2x4NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2x4fvNV != null, "pglUniformMatrix2x4fvNV not implemented");
					Delegates.pglUniformMatrix2x4fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix2x4fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix3x2fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix3x2NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x2fvNV != null, "pglUniformMatrix3x2fvNV not implemented");
					Delegates.pglUniformMatrix3x2fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x2fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix3x4fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix3x4NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3x4fvNV != null, "pglUniformMatrix3x4fvNV not implemented");
					Delegates.pglUniformMatrix3x4fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix3x4fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix4x2fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix4x2NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x2fvNV != null, "pglUniformMatrix4x2fvNV not implemented");
					Delegates.pglUniformMatrix4x2fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x2fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix4x3fvNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix4x3NV(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4x3fvNV != null, "pglUniformMatrix4x3fvNV not implemented");
					Delegates.pglUniformMatrix4x3fvNV(location, count, transpose, p_value);
					CallLog("glUniformMatrix4x3fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUnmapBufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static bool UnmapBufferOES(int target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapBufferOES != null, "pglUnmapBufferOES not implemented");
			retValue = Delegates.pglUnmapBufferOES(target);
			CallLog("glUnmapBufferOES({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glUseProgramStagesEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stages">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void UseProgramStageEXT(UInt32 pipeline, uint stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStagesEXT != null, "pglUseProgramStagesEXT not implemented");
			Delegates.pglUseProgramStagesEXT(pipeline, stages, program);
			CallLog("glUseProgramStagesEXT({0}, {1}, {2})", pipeline, stages, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glValidateProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ValidateProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipelineEXT != null, "pglValidateProgramPipelineEXT not implemented");
			Delegates.pglValidateProgramPipelineEXT(pipeline);
			CallLog("glValidateProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribDivisorANGLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexAttribDivisorANGLE != null, "pglVertexAttribDivisorANGLE not implemented");
			Delegates.pglVertexAttribDivisorANGLE(index, divisor);
			CallLog("glVertexAttribDivisorANGLE({0}, {1})", index, divisor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribDivisorEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexAttribDivisorEXT != null, "pglVertexAttribDivisorEXT not implemented");
			Delegates.pglVertexAttribDivisorEXT(index, divisor);
			CallLog("glVertexAttribDivisorEXT({0}, {1})", index, divisor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribDivisorNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void VertexAttribDivisorNV(UInt32 index, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexAttribDivisorNV != null, "pglVertexAttribDivisorNV not implemented");
			Delegates.pglVertexAttribDivisorNV(index, divisor);
			CallLog("glVertexAttribDivisorNV({0}, {1})", index, divisor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportArrayvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ViewportArrayNV(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportArrayvNV != null, "pglViewportArrayvNV not implemented");
					Delegates.pglViewportArrayvNV(first, count, p_v);
					CallLog("glViewportArrayvNV({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportIndexedfNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void ViewportIndexedNV(UInt32 index, float x, float y, float w, float h)
		{
			Debug.Assert(Delegates.pglViewportIndexedfNV != null, "pglViewportIndexedfNV not implemented");
			Delegates.pglViewportIndexedfNV(index, x, y, w, h);
			CallLog("glViewportIndexedfNV({0}, {1}, {2}, {3}, {4})", index, x, y, w, h);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportIndexedfvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ViewportIndexedNV(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportIndexedfvNV != null, "pglViewportIndexedfvNV not implemented");
					Delegates.pglViewportIndexedfvNV(index, p_v);
					CallLog("glViewportIndexedfvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWaitSyncAPPLE.
		/// </summary>
		/// <param name="sync">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		public static void WaitSyncAPPLE(int sync, uint flags, UInt64 timeout)
		{
			Debug.Assert(Delegates.pglWaitSyncAPPLE != null, "pglWaitSyncAPPLE not implemented");
			Delegates.pglWaitSyncAPPLE(sync, flags, timeout);
			CallLog("glWaitSyncAPPLE({0}, {1}, {2})", sync, flags, timeout);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
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
		public static void WeightPointerOES(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerOES != null, "pglWeightPointerOES not implemented");
			Delegates.pglWeightPointerOES(size, type, stride, pointer);
			CallLog("glWeightPointerOES({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
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
		public static void WeightPointerOES(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				WeightPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
