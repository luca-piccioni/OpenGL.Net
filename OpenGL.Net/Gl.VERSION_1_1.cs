
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
		/// Gl.Clear: indicates the depth buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const uint DEPTH_BUFFER_BIT = 0x00000100;

		/// <summary>
		/// Gl.Clear: indicates the stencil buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const uint STENCIL_BUFFER_BIT = 0x00000400;

		/// <summary>
		/// Gl.Clear: indicates the buffers currently enabled for color writing.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const uint COLOR_BUFFER_BIT = 0x00004000;

		/// <summary>
		/// Value of GL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FALSE = 0;

		/// <summary>
		/// Value of GL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TRUE = 1;

		/// <summary>
		/// Gl.Begin: treats each vertex as a single point. Vertex n defines point n. N points are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINTS = 0x0000;

		/// <summary>
		/// Gl.Begin: treats each pair of vertices as an independent line segment. Vertices 2⁢n-1 and 2⁢n define line n. N2 lines 
		/// are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINES = 0x0001;

		/// <summary>
		/// Gl.Begin: draws a connected group of line segments from the first vertex to the last, then back to the first. Vertices n 
		/// and n+1 define line n. The last line, however, is defined by vertices N and 1. N lines are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_LOOP = 0x0002;

		/// <summary>
		/// Gl.Begin: draws a connected group of line segments from the first vertex to the last. Vertices n and n+1 define line n. 
		/// N-1 lines are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_STRIP = 0x0003;

		/// <summary>
		/// Gl.Begin: treats each triplet of vertices as an independent triangle. Vertices 3⁢n-2, 3⁢n-1, and 3⁢n define triangle n. 
		/// N3 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int TRIANGLES = 0x0004;

		/// <summary>
		/// Gl.Begin: draws a connected group of triangles. One triangle is defined for each vertex presented after the first two 
		/// vertices. For odd n, vertices n, n+1, and n+2 define triangle n. For even n, vertices n+1, n, and n+2 define triangle n. 
		/// N-2 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TRIANGLE_STRIP = 0x0005;

		/// <summary>
		/// Gl.Begin: draws a connected group of triangles. One triangle is defined for each vertex presented after the first two 
		/// vertices. Vertices 1, n+1, and n+2 define triangle n. N-2 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TRIANGLE_FAN = 0x0006;

		/// <summary>
		/// Gl.Begin: treats each group of four vertices as an independent quadrilateral. Vertices 4⁢n-3, 4⁢n-2, 4⁢n-1, and 4⁢n 
		/// define quadrilateral n. N4 quadrilaterals are drawn.
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
		/// <para>
		/// Gl.DepthFunc: never passes.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: always fails.
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: always fails.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NEVER = 0x0200;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is less than the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LESS = 0x0201;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int EQUAL = 0x0202;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is less than or equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LEQUAL = 0x0203;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is greater than the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int GREATER = 0x0204;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is not equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NOTEQUAL = 0x0205;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: passes if the incoming depth value is greater than or equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int GEQUAL = 0x0206;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: always passes.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: always passes.
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: always passes.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ALWAYS = 0x0207;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: sets the stencil buffer value to 0.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: sets the stencil buffer value to 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int ZERO = 0;

		/// <summary>
		/// Value of GL_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ONE = 1;

		/// <summary>
		/// Value of GL_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SRC_COLOR = 0x0300;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ONE_MINUS_SRC_COLOR = 0x0301;

		/// <summary>
		/// Value of GL_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SRC_ALPHA = 0x0302;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ONE_MINUS_SRC_ALPHA = 0x0303;

		/// <summary>
		/// Value of GL_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DST_ALPHA = 0x0304;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ONE_MINUS_DST_ALPHA = 0x0305;

		/// <summary>
		/// Value of GL_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DST_COLOR = 0x0306;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int ONE_MINUS_DST_COLOR = 0x0307;

		/// <summary>
		/// Value of GL_SRC_ALPHA_SATURATE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SRC_ALPHA_SATURATE = 0x0308;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: no color buffers are written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: the fragment shader output value is not written into any color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_context_flush_control")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int NONE = 0;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: only the front left color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: the fragment shader output value is written into the front left color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_LEFT = 0x0400;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: only the front right color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: the fragment shader output value is written into the front right color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_RIGHT = 0x0401;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: only the back left color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: the fragment shader output value is written into the back left color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BACK_LEFT = 0x0402;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: only the back right color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: the fragment shader output value is written into the back right color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BACK_RIGHT = 0x0403;

		/// <summary>
		/// Gl.DrawBuffer: only the front left and front right color buffers are written. If there is no front right color buffer, 
		/// only the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT = 0x0404;

		/// <summary>
		/// Gl.DrawBuffer: only the back left and back right color buffers are written. If there is no back right color buffer, only 
		/// the back left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility")]
		public const int BACK = 0x0405;

		/// <summary>
		/// Gl.DrawBuffer: only the front left and back left color buffers are written. If there is no back left color buffer, only 
		/// the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LEFT = 0x0406;

		/// <summary>
		/// Gl.DrawBuffer: only the front right and back right color buffers are written. If there is no back right color buffer, 
		/// only the front right color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RIGHT = 0x0407;

		/// <summary>
		/// Gl.DrawBuffer: all the front and back color buffers (front left, front right, back left, back right) are written. If 
		/// there are no back color buffers, only the front left and front right color buffers are written. If there are no right 
		/// color buffers, only the front left and back left color buffers are written. If there are no right or back color buffers, 
		/// only the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_AND_BACK = 0x0408;

		/// <summary>
		/// <para>
		/// Gl.GetError: no error has been recorded. The value of this symbolic constant is guaranteed to be 0.
		/// </para>
		/// <para>
		/// Gl.GetGraphicsResetStatus: indicates that the GL context has not been in a reset state since the last call.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_robustness")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int NO_ERROR = 0;

		/// <summary>
		/// Gl.GetError: an unacceptable value is specified for an enumerated argument. The offending command is ignored and has no 
		/// other side effect than to set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int INVALID_ENUM = 0x0500;

		/// <summary>
		/// Gl.GetError: a numeric argument is out of range. The offending command is ignored and has no other side effect than to 
		/// set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int INVALID_VALUE = 0x0501;

		/// <summary>
		/// Gl.GetError: the specified operation is not allowed in the current state. The offending command is ignored and has no 
		/// other side effect than to set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int INVALID_OPERATION = 0x0502;

		/// <summary>
		/// Gl.GetError: there is not enough memory left to execute the command. The state of the GL is undefined, except for the 
		/// state of the error flags, after this error is recorded.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int OUT_OF_MEMORY = 0x0505;

		/// <summary>
		/// Value of GL_CW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int CW = 0x0900;

		/// <summary>
		/// Value of GL_CCW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_tessellation_shader")]
		public const int CCW = 0x0901;

		/// <summary>
		/// Gl.Get: data returns one value, the point size as specified by Gl.PointSize. The initial value is 1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT_SIZE = 0x0B11;

		/// <summary>
		/// Gl.Get: data returns two values: the smallest and largest supported sizes for antialiased points. The smallest size must 
		/// be at most 1, and the largest size must be at least 1. See Gl.PointSize.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT_SIZE_RANGE = 0x0B12;

		/// <summary>
		/// Gl.Get: data returns one value, the size difference between adjacent supported sizes for antialiased points. See 
		/// Gl.PointSize.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT_SIZE_GRANULARITY = 0x0B13;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, draw lines with correct filtering. Otherwise, draw aliased lines. See Gl.LineWidth.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether antialiasing of lines is enabled. The initial value is 
		/// Gl.FALSE. See Gl.LineWidth.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_SMOOTH = 0x0B20;

		/// <summary>
		/// Gl.Get: data returns one value, the line width as specified with Gl.LineWidth. The initial value is 1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_WIDTH = 0x0B21;

		/// <summary>
		/// Gl.Get: params returns two values: the smallest and largest supported widths for antialiased lines. See Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_WIDTH_RANGE = 0x0B22;

		/// <summary>
		/// Gl.Get: params returns one value, the width difference between adjacent supported widths for antialiased lines. See 
		/// Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_WIDTH_GRANULARITY = 0x0B23;

		/// <summary>
		/// Gl.Get: params returns two values: symbolic constants indicating whether front-facing and back-facing polygons are 
		/// rasterized as points, lines, or filled polygons. The initial value is Gl.FILL. See Gl.PolygonMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_MODE = 0x0B40;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, draw polygons with proper filtering. Otherwise, draw aliased polygons. For correct antialiased 
		/// polygons, an alpha buffer is needed and the polygons must be sorted front to back.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether antialiasing of polygons is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PolygonMode.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_SMOOTH = 0x0B41;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, cull polygons based on their winding in window coordinates. See Gl.CullFace.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether polygon culling is enabled. The initial value is 
		/// Gl.FALSE. See Gl.CullFace.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int CULL_FACE = 0x0B44;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which polygon faces are to be culled. The initial value 
		/// is Gl.BACK. See Gl.CullFace.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int CULL_FACE_MODE = 0x0B45;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether clockwise or counterclockwise polygon winding 
		/// is treated as front-facing. The initial value is Gl.CCW. See Gl.FrontFace.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FRONT_FACE = 0x0B46;

		/// <summary>
		/// Gl.Get: data returns two values: the near and far mapping limits for the depth buffer. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 1). See 
		/// Gl.DepthRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int DEPTH_RANGE = 0x0B70;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, do depth comparisons and update the depth buffer. Note that even if the depth buffer exists and 
		/// the depth mask is non-zero, the depth buffer is not updated if the depth test is disabled. See Gl.DepthFunc and 
		/// Gl.DepthRange.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether depth testing of fragments is enabled. The initial value 
		/// is Gl.FALSE. See Gl.DepthFunc and Gl.DepthRange.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH_TEST = 0x0B71;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating if the depth buffer is enabled for writing. The initial value is 
		/// Gl.TRUE. See Gl.DepthMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH_WRITEMASK = 0x0B72;

		/// <summary>
		/// Gl.Get: data returns one value, the value that is used to clear the depth buffer. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is 1. See 
		/// Gl.ClearDepth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH_CLEAR_VALUE = 0x0B73;

		/// <summary>
		/// Gl.Get: data returns one value, the symbolic constant that indicates the depth comparison function. The initial value is 
		/// Gl.LESS. See Gl.DepthFunc.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH_FUNC = 0x0B74;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, do stencil testing and update the stencil buffer. See Gl.StencilFunc and Gl.StencilOp.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether stencil testing of fragments is enabled. The initial 
		/// value is Gl.FALSE. See Gl.StencilFunc and Gl.StencilOp.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_TEST = 0x0B90;

		/// <summary>
		/// Gl.Get: data returns one value, the index to which the stencil bitplanes are cleared. The initial value is 0. See 
		/// Gl.ClearStencil.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_CLEAR_VALUE = 0x0B91;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what function is used to compare the stencil reference 
		/// value with the stencil buffer value. The initial value is Gl.ALWAYS. See Gl.StencilFunc. This stencil state only affects 
		/// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_FUNC = 0x0B92;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that is used to mask both the stencil reference value and the stencil buffer 
		/// value before they are compared. The initial value is all 1's. See Gl.StencilFunc. This stencil state only affects 
		/// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_VALUE_MASK = 0x0B93;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test fails. The 
		/// initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and front-facing polygons. 
		/// Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_FAIL = 0x0B94;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test passes, but 
		/// the depth test fails. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and 
		/// front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test passes and the 
		/// depth test passes. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and 
		/// front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;

		/// <summary>
		/// Gl.Get: data returns one value, the reference value that is compared with the contents of the stencil buffer. The 
		/// initial value is 0. See Gl.StencilFunc. This stencil state only affects non-polygons and front-facing polygons. 
		/// Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_REF = 0x0B97;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that controls writing of the stencil bitplanes. The initial value is all 1's. 
		/// See Gl.StencilMask. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use 
		/// separate stencil state. See Gl.StencilMaskSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL_WRITEMASK = 0x0B98;

		/// <summary>
		/// Gl.Get: when used with non-indexed variants of glGet (such as glGetIntegerv), data returns four values: the x and y 
		/// window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates are both 
		/// set to 0, and the width and height are set to the width and height of the window into which the GL will do its 
		/// rendering. See Gl.Viewport. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns four 
		/// values: the x and y window coordinates of the indexed viewport, followed by its width and height. Initially the x and y 
		/// window coordinates are both set to 0, and the width and height are set to the width and height of the window into which 
		/// the GL will do its rendering. See Gl.ViewportIndexedf.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int VIEWPORT = 0x0BA2;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, dither color components or indices before they are written to the color buffer.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether dithering of fragment colors and indices is enabled. The 
		/// initial value is Gl.TRUE.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DITHER = 0x0BD0;

		/// <summary>
		/// Value of GL_BLEND_DST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BLEND_DST = 0x0BE0;

		/// <summary>
		/// Value of GL_BLEND_SRC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BLEND_SRC = 0x0BE1;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, blend the computed fragment color values with the values in the color buffers. See Gl.BlendFunc.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether blending is enabled. The initial value is Gl.FALSE. See 
		/// Gl.BlendFunc.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int BLEND = 0x0BE2;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating the selected logic operation mode. The initial value is 
		/// Gl.COPY. See Gl.LogicOp.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LOGIC_OP_MODE = 0x0BF0;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, apply the currently selected logical operation to the computed fragment color and color buffer 
		/// values. See Gl.LogicOp.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether a fragment's RGBA color values are merged into the 
		/// framebuffer using a logical operation. The initial value is Gl.FALSE. See Gl.LogicOp.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COLOR_LOGIC_OP = 0x0BF2;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating which buffers are being drawn to. See Gl.DrawBuffer. The 
		/// initial value is Gl.BACK if there are back buffers, otherwise it is Gl.FRONT.
		/// </para>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating which buffers are being drawn to by the corresponding 
		/// output color. See Gl.DrawBuffers. The initial value of Gl.DRAW_BUFFER0 is Gl.BACK if there are back buffers, otherwise 
		/// it is Gl.FRONT. The initial values of draw buffers for all other output colors is Gl.NONE.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DRAW_BUFFER = 0x0C01;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating which color buffer is selected for reading. The initial 
		/// value is Gl.BACK if there is a back buffer, otherwise it is Gl.FRONT. See Gl.ReadPixels.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int READ_BUFFER = 0x0C02;

		/// <summary>
		/// Gl.Get: data returns four values: the x and y window coordinates of the scissor box, followed by its width and height. 
		/// Initially the x and y window coordinates are both 0 and the width and height are set to the size of the window. See 
		/// Gl.Scissor.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int SCISSOR_BOX = 0x0C10;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, discard fragments that are outside the scissor rectangle. See Gl.Scissor.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether scissoring is enabled. The initial value is Gl.FALSE. See 
		/// Gl.Scissor.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int SCISSOR_TEST = 0x0C11;

		/// <summary>
		/// Gl.Get: data returns four values: the red, green, blue, and alpha values used to clear the color buffers. Integer 
		/// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most 
		/// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value 
		/// is (0, 0, 0, 0). See Gl.ClearColor.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COLOR_CLEAR_VALUE = 0x0C22;

		/// <summary>
		/// Gl.Get: data returns four boolean values: the red, green, blue, and alpha write enables for the color buffers. The 
		/// initial value is (Gl.TRUE, Gl.TRUE, Gl.TRUE, Gl.TRUE). See Gl.ColorMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COLOR_WRITEMASK = 0x0C23;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether double buffering is supported.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a boolean value indicating whether double buffering is supported for the 
		/// framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DOUBLEBUFFER = 0x0C32;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether stereo buffers (left and right) are supported.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a boolean value indicating whether stereo buffers (left and right) are 
		/// supported for the framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STEREO = 0x0C33;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating the mode of the line antialiasing hint. The initial value 
		/// is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the sampling quality of antialiased lines. If a larger filter function is applied, hinting Gl.NICEST 
		/// can result in more pixel fragments being generated during rasterization.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE_SMOOTH_HINT = 0x0C52;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating the mode of the polygon antialiasing hint. The initial 
		/// value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the sampling quality of antialiased polygons. Hinting Gl.NICEST can result in more pixel fragments 
		/// being generated during rasterization, if a larger filter function is applied.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_SMOOTH_HINT = 0x0C53;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and 
		/// components are swapped after being read from memory. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if true, byte ordering for multibyte color components, depth components, or stencil indices is reversed. 
		/// That is, if a four-byte component consists of bytes b0, b1, b2, b3, it is taken from memory as b3, b2, b1, b0 if 
		/// Gl.UNPACK_SWAP_BYTES is true. Gl.UNPACK_SWAP_BYTES has no effect on the memory order of components within a pixel, only 
		/// on the order of bytes within components or indices. For example, the three components of a Gl.RGB format pixel are 
		/// always stored with red first, green second, and blue third, regardless of the value of Gl.UNPACK_SWAP_BYTES.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_SWAP_BYTES = 0x0CF0;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether single-bit pixels being read from memory are read first 
		/// from the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if true, bits are ordered within a byte from least significant to most significant; otherwise, the first 
		/// bit in each byte is the most significant one.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_LSB_FIRST = 0x0CF1;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the row length used for reading pixel data from memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if greater than 0, Gl.UNPACK_ROW_LENGTH defines the number of pixels in a row. If the first pixel of a 
		/// row is placed at location p in memory, then the location of the first pixel of the next row is obtained by skipping 
		/// k=n⁢las⁢s⁢n⁢la⁢s&gt;=as&lt;a components or indices, where n is the number of components or indices in a pixel, l is the 
		/// number of pixels in a row (Gl.UNPACK_ROW_LENGTH if it is greater than 0, the width argument to the pixel routine 
		/// otherwise), a is the value of Gl.UNPACK_ALIGNMENT, and s is the size, in bytes, of a single component (if a&lt;s, then 
		/// it is as if a=s). In the case of 1-bit values, the location of the next row is obtained by skipping k=8⁢a⁢n⁢l8⁢a 
		/// components or indices. The word component in this description refers to the nonindex values red, green, blue, alpha, and 
		/// depth. Storage format Gl.RGB, for example, has three components per pixel: first red, then green, and finally blue.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_ROW_LENGTH = 0x0CF2;

		/// <summary>
		/// Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is read from 
		/// memory. The initial value is 0. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_SKIP_ROWS = 0x0CF3;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is read from memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: these values are provided as a convenience to the programmer; they provide no functionality that cannot 
		/// be duplicated by incrementing the pointer passed to Gl.TexImage1D, Gl.TexImage2D, Gl.TexSubImage1D or Gl.TexSubImage2D. 
		/// Setting Gl.UNPACK_SKIP_PIXELS to i is equivalent to incrementing the pointer by i⁢n components or indices, where n is 
		/// the number of components or indices in each pixel. Setting Gl.UNPACK_SKIP_ROWS to j is equivalent to incrementing the 
		/// pointer by j⁢k components or indices, where k is the number of components or indices per row, as just computed in the 
		/// Gl.UNPACK_ROW_LENGTH section.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_SKIP_PIXELS = 0x0CF4;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the byte alignment used for reading pixel data from memory. The initial value is 4. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: specifies the alignment requirements for the start of each pixel row in memory. The allowable values are 
		/// 1 (byte-alignment), 2 (rows aligned to even-numbered bytes), 4 (word-alignment), and 8 (rows start on double-word 
		/// boundaries).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNPACK_ALIGNMENT = 0x0CF5;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and 
		/// components are swapped before being written to memory. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if true, byte ordering for multibyte color components, depth components, or stencil indices is reversed. 
		/// That is, if a four-byte component consists of bytes b0, b1, b2, b3, it is stored in memory as b3, b2, b1, b0 if 
		/// Gl.PACK_SWAP_BYTES is true. Gl.PACK_SWAP_BYTES has no effect on the memory order of components within a pixel, only on 
		/// the order of bytes within components or indices. For example, the three components of a Gl.RGB format pixel are always 
		/// stored with red first, green second, and blue third, regardless of the value of Gl.PACK_SWAP_BYTES.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_SWAP_BYTES = 0x0D00;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether single-bit pixels being written to memory are written 
		/// first to the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if true, bits are ordered within a byte from least significant to most significant; otherwise, the first 
		/// bit in each byte is the most significant one.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_LSB_FIRST = 0x0D01;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the row length used for writing pixel data to memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: if greater than 0, Gl.PACK_ROW_LENGTH defines the number of pixels in a row. If the first pixel of a row 
		/// is placed at location p in memory, then the location of the first pixel of the next row is obtained by skipping 
		/// k=n⁢las⁢s⁢n⁢la⁢s&gt;=as&lt;a components or indices, where n is the number of components or indices in a pixel, l is the 
		/// number of pixels in a row (Gl.PACK_ROW_LENGTH if it is greater than 0, the width argument to the pixel routine 
		/// otherwise), a is the value of Gl.PACK_ALIGNMENT, and s is the size, in bytes, of a single component (if a&lt;s, then it 
		/// is as if a=s). In the case of 1-bit values, the location of the next row is obtained by skipping k=8⁢a⁢n⁢l8⁢a components 
		/// or indices. The word component in this description refers to the nonindex values red, green, blue, alpha, and depth. 
		/// Storage format Gl.RGB, for example, has three components per pixel: first red, then green, and finally blue.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_ROW_LENGTH = 0x0D02;

		/// <summary>
		/// Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is written into 
		/// memory. The initial value is 0. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_SKIP_ROWS = 0x0D03;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is written into memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: these values are provided as a convenience to the programmer; they provide no functionality that cannot 
		/// be duplicated simply by incrementing the pointer passed to Gl.ReadPixels. Setting Gl.PACK_SKIP_PIXELS to i is equivalent 
		/// to incrementing the pointer by i⁢n components or indices, where n is the number of components or indices in each pixel. 
		/// Setting Gl.PACK_SKIP_ROWS to j is equivalent to incrementing the pointer by j⁢m components or indices, where m is the 
		/// number of components or indices per row, as just computed in the Gl.PACK_ROW_LENGTH section. Setting Gl.PACK_SKIP_IMAGES 
		/// to k is equivalent to incrementing the pointer by k⁢p, where p is the number of components or indices per image, as 
		/// computed in the Gl.PACK_IMAGE_HEIGHT section.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_SKIP_PIXELS = 0x0D04;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the byte alignment used for writing pixel data to memory. The initial value is 4. See 
		/// Gl.PixelStore.
		/// </para>
		/// <para>
		/// Gl.PixelStore: specifies the alignment requirements for the start of each pixel row in memory. The allowable values are 
		/// 1 (byte-alignment), 2 (rows aligned to even-numbered bytes), 4 (word-alignment), and 8 (rows start on double-word 
		/// boundaries).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int PACK_ALIGNMENT = 0x0D05;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can handle. The 
		/// value must be at least 1024. Use a proxy texture target such as Gl.PROXY_TEXTURE_1D or Gl.PROXY_TEXTURE_2D to determine 
		/// if a texture is too large. See Gl.TexImage1D and Gl.TexImage2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int MAX_TEXTURE_SIZE = 0x0D33;

		/// <summary>
		/// Gl.Get: data returns two values: the maximum supported width and height of the viewport. These must be at least as large 
		/// as the visible dimensions of the display being rendered to. See Gl.Viewport.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int MAX_VIEWPORT_DIMS = 0x0D3A;

		/// <summary>
		/// Gl.Get: data returns one value, an estimate of the number of bits of subpixel resolution that are used to position 
		/// rasterized geometry in window coordinates. The value must be at least 4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SUBPIXEL_BITS = 0x0D50;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D texture mapping is enabled. The initial value is 
		/// Gl.FALSE. See Gl.TexImage1D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, one-dimensional texturing is performed (unless two- or 
		/// three-dimensional or cube-mapped texturing is also enabled). See Gl.TexImage1D.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_1D = 0x0DE0;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D texture mapping is enabled. The initial value is 
		/// Gl.FALSE. See Gl.TexImage2D.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, two-dimensional texturing is performed (unless three-dimensional 
		/// or cube-mapped texturing is also enabled). See Gl.TexImage2D.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_2D = 0x0DE1;

		/// <summary>
		/// Gl.Get: data returns one value. This value is multiplied by an implementation-specific value and then added to the depth 
		/// value of each fragment generated when a polygon is rasterized. The initial value is 0. See Gl.PolygonOffset.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_UNITS = 0x2A00;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, an offset is added to depth values of a polygon's fragments before the depth comparison is 
		/// performed, if the polygon is rendered in Gl.POINT mode. See Gl.PolygonOffset.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in point mode. The 
		/// initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_POINT = 0x2A01;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, and if the polygon is rendered in Gl.LINE mode, an offset is added to depth values of a polygon's 
		/// fragments before the depth comparison is performed. See Gl.PolygonOffset.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in line mode. The 
		/// initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_LINE = 0x2A02;

		/// <summary>
		/// <para>
		/// Gl.Enable: if enabled, and if the polygon is rendered in Gl.FILL mode, an offset is added to depth values of a polygon's 
		/// fragments before the depth comparison is performed. See Gl.PolygonOffset.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether polygon offset is enabled for polygons in fill mode. The 
		/// initial value is Gl.FALSE. See Gl.PolygonOffset.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POLYGON_OFFSET_FILL = 0x8037;

		/// <summary>
		/// Gl.Get: data returns one value, the scaling factor used to determine the variable offset that is added to the depth 
		/// value of each fragment generated when a polygon is rasterized. The initial value is 0. See Gl.PolygonOffset.
		/// </summary>
		[AliasOf("GL_POLYGON_OFFSET_FACTOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_polygon_offset")]
		public const int POLYGON_OFFSET_FACTOR = 0x8038;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_1D. The initial 
		/// value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_1D = 0x8068;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_2D. The initial 
		/// value is 0. See Gl.BindTexture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_2D = 0x8069;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the width of the texture image. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_WIDTH = 0x1000;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the height of the texture image. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_HEIGHT = 0x1001;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the internal format of the texture image.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_INTERNAL_FORMAT = 0x1003;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns four integer or floating-point numbers that comprise the RGBA color of the texture 
		/// border. Floating-point values are returned in the range 01. Integer values are returned as a linear mapping of the 
		/// internal floating-point representation such that 1.0 maps to the most positive representable integer and -1.0 maps to 
		/// the most negative representable integer. The initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns four integer or floating-point numbers that comprise the RGBA color of the texture border. 
		/// Floating-point values are returned in the range 01. Integer values are returned as a linear mapping of the internal 
		/// floating-point representation such that 1.0 maps to the most positive representable integer and -1.0 maps to the most 
		/// negative representable integer. The initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: the data in params specifies four values that define the border values that should be used for 
		/// border texels. If a texel is sampled from the border of the texture, the values of Gl.TEXTURE_BORDER_COLOR are 
		/// interpreted as an RGBA color to match the texture's internal format and substituted for the non-existent texel data. If 
		/// the texture contains depth components, the first component of Gl.TEXTURE_BORDER_COLOR is interpreted as a depth value. 
		/// The initial value is 0.0,0.0,0.0,0.0.
		/// </para>
		/// <para>
		/// Gl.TexParameter: the data in params specifies four values that define the border values that should be used for border 
		/// texels. If a texel is sampled from the border of the texture, the values of Gl.TEXTURE_BORDER_COLOR are interpreted as 
		/// an RGBA color to match the texture's internal format and substituted for the non-existent texel data. If the texture 
		/// contains depth components, the first component of Gl.TEXTURE_BORDER_COLOR is interpreted as a depth value. The initial 
		/// value is 0.0,0.0,0.0,0.0. If the values for Gl.TEXTURE_BORDER_COLOR are specified with glTexParameterIiv or 
		/// glTexParameterIuiv, the values are stored unmodified with an internal data type of integer. If specified with 
		/// glTexParameteriv, they are converted to floating point with the following equation: f=2c+12b-1. If specified with 
		/// glTexParameterfv, they are stored unmodified as floating-point values.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_BORDER_COLOR = 0x1004;

		/// <summary>
		/// Gl.GetTexLevelParameter: the internal storage resolution of an individual component. The resolution chosen by the GL 
		/// will be a close match for the resolution requested by the user with the component argument of Gl.TexImage1D, 
		/// Gl.TexImage2D, Gl.TexImage3D, Gl.CopyTexImage1D, and Gl.CopyTexImage2D. The initial value is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_RED_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_RED_SIZE = 0x805C;

		/// <summary>
		/// Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_GREEN_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_GREEN_SIZE = 0x805D;

		/// <summary>
		/// Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_BLUE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_BLUE_SIZE = 0x805E;

		/// <summary>
		/// Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_ALPHA_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_ALPHA_SIZE = 0x805F;

		/// <summary>
		/// Gl.Hint: no preference.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DONT_CARE = 0x1100;

		/// <summary>
		/// Gl.Hint: the most efficient option should be chosen.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FASTEST = 0x1101;

		/// <summary>
		/// Gl.Hint: the most correct, or highest quality, option should be chosen.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NICEST = 0x1102;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed bytes, each in the range -128 through 127.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public const int BYTE = 0x1400;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes, each in the range 0 through 255.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNSIGNED_BYTE = 0x1401;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed two-byte integers, each in the range -32768 through 32767.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SHORT = 0x1402;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned two-byte integers, each in the range 0 through 65535.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNSIGNED_SHORT = 0x1403;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed four-byte integers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int INT = 0x1404;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned four-byte integers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int UNSIGNED_INT = 0x1405;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of four-byte floating-point values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT = 0x1406;

		/// <summary>
		/// Value of GL_DOUBLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public const int DOUBLE = 0x140A;

		/// <summary>
		/// Gl.GetError: an attempt has been made to perform an operation that would cause an internal stack to overflow.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int STACK_OVERFLOW = 0x0503;

		/// <summary>
		/// Gl.GetError: an attempt has been made to perform an operation that would cause an internal stack to underflow.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
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
		public const int CLEAR = 0x1500;

		/// <summary>
		/// Value of GL_AND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int AND = 0x1501;

		/// <summary>
		/// Value of GL_AND_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int AND_REVERSE = 0x1502;

		/// <summary>
		/// Value of GL_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COPY = 0x1503;

		/// <summary>
		/// Value of GL_AND_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int AND_INVERTED = 0x1504;

		/// <summary>
		/// Value of GL_NOOP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NOOP = 0x1505;

		/// <summary>
		/// Value of GL_XOR symbol.
		/// </summary>
		[AliasOf("GL_XOR_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int XOR = 0x1506;

		/// <summary>
		/// Value of GL_OR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int OR = 0x1507;

		/// <summary>
		/// Value of GL_NOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NOR = 0x1508;

		/// <summary>
		/// Value of GL_EQUIV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int EQUIV = 0x1509;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: bitwise inverts the current stencil buffer value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: bitwise inverts the current stencil buffer value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int INVERT = 0x150A;

		/// <summary>
		/// Value of GL_OR_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int OR_REVERSE = 0x150B;

		/// <summary>
		/// Value of GL_COPY_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COPY_INVERTED = 0x150C;

		/// <summary>
		/// Value of GL_OR_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int OR_INVERTED = 0x150D;

		/// <summary>
		/// Value of GL_NAND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NAND = 0x150E;

		/// <summary>
		/// Value of GL_SET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int SET = 0x150F;

		/// <summary>
		/// Gl.MatrixMode: applies subsequent matrix operations to the texture matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE = 0x1702;

		/// <summary>
		/// <para>
		/// Gl.CopyPixels: indices or RGBA colors are read from the buffer currently specified as the read source buffer (see 
		/// Gl.ReadBuffer). If the GL is in color index mode, each index that is read from this buffer is converted to a fixed-point 
		/// format with an unspecified number of bits to the right of the binary point. Each index is then shifted left by 
		/// Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either 
		/// case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_COLOR is true, the index is replaced 
		/// with the value that it references in lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of the index is 
		/// done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in a color index 
		/// buffer. If the GL is in RGBA mode, the red, green, blue, and alpha components of each pixel that is read are converted 
		/// to an internal floating-point format with unspecified precision. The conversion maps the largest representable component 
		/// value to 1.0, and component value 0 to 0.0. The resulting floating-point color values are then multiplied by Gl.c_SCALE 
		/// and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, and ALPHA for the respective color components. The results are 
		/// clamped to the range [0,1]. If Gl.MAP_COLOR is true, each color component is scaled by the size of lookup table 
		/// Gl.PIXEL_MAP_c_TO_c, then replaced by the value that it references in that table. c is R, G, B, or A. If the ARB_imaging 
		/// extension is supported, the color values may be additionally processed by color-table lookups, color-matrix 
		/// transformations, and convolution filters. The GL then converts the resulting indices or RGBA colors to fragments by 
		/// attaching the current raster position z coordinate and texture coordinates to each pixel, then assigning window 
		/// coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in the jth row. These 
		/// pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or polygons. Texture 
		/// mapping, fog, and all the fragment operations are applied before the fragments are written to the frame buffer.
		/// </para>
		/// <para>
		/// Gl.MatrixMode: applies subsequent matrix operations to the color matrix stack.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int COLOR = 0x1800;

		/// <summary>
		/// Gl.CopyPixels: depth values are read from the depth buffer and converted directly to an internal floating-point format 
		/// with unspecified precision. The resulting floating-point depth value is then multiplied by Gl.DEPTH_SCALE and added to 
		/// Gl.DEPTH_BIAS. The result is clamped to the range [0,1]. The GL then converts the resulting depth components to 
		/// fragments by attaching the current raster position color or color index and texture coordinates to each pixel, then 
		/// assigning window coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in the 
		/// jth row. These pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or 
		/// polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments are written to the 
		/// frame buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH = 0x1801;

		/// <summary>
		/// Gl.CopyPixels: stencil indices are read from the stencil buffer and converted to an internal fixed-point format with an 
		/// unspecified number of bits to the right of the binary point. Each fixed-point index is then shifted left by 
		/// Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either 
		/// case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_STENCIL is true, the index is replaced 
		/// with the value that it references in lookup table Gl.PIXEL_MAP_S_TO_S. Whether the lookup replacement of the index is 
		/// done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in the stencil buffer. 
		/// The resulting stencil indices are then written to the stencil buffer such that the index read from the ith location of 
		/// the jth row is written to location xr+iyr+j, where xryr is the current raster position. Only the pixel ownership test, 
		/// the scissor test, and the stencil writemask affect these write operations.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int STENCIL = 0x1802;

		/// <summary>
		/// Gl.ReadPixels: stencil values are read from the stencil buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_texture_stencil8")]
		public const int STENCIL_INDEX = 0x1901;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: depth values are read from the depth buffer. Each component is converted to floating point such that the 
		/// minimum depth value maps to 0 and the maximum value maps to 1. Each component is clamped to the range 01.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single depth value. The GL converts it to floating point and clamps to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single depth value. The GL converts it to floating point and clamps to the range [0,1].
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DEPTH_COMPONENT = 0x1902;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: color values are taken from the color buffer.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// </summary>
		[AliasOf("GL_RED_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int RED = 0x1903;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a single green component. This component is converted to the internal floating-point format 
		/// in the same way the green component of an RGBA pixel is. It is then converted to an RGBA pixel with red and blue set to 
		/// 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[AliasOf("GL_GREEN_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int GREEN = 0x1904;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a single blue component. This component is converted to the internal floating-point format 
		/// in the same way the blue component of an RGBA pixel is. It is then converted to an RGBA pixel with red and green set to 
		/// 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[AliasOf("GL_BLUE_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced")]
		public const int BLUE = 0x1905;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a single alpha component. This component is converted to the internal floating-point format 
		/// in the same way the alpha component of an RGBA pixel is. It is then converted to an RGBA pixel with red, green, and blue 
		/// set to 0. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int ALPHA = 0x1906;

		/// <summary>
		/// <para>
		/// Gl.TexImage1D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is an RGB triple. The GL converts it to floating point and assembles it into an RGBA element 
		/// by attaching 1 for alpha. Each component is clamped to the range [0,1].
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGB = 0x1907;

		/// <summary>
		/// <para>
		/// Gl.TexImage1D: each element contains all four components. Each component clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element contains all four components. Each component is clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element contains all four components. Each component is clamped to the range [0,1].
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RGBA = 0x1908;

		/// <summary>
		/// Gl.PolygonMode: polygon vertices that are marked as the start of a boundary edge are drawn as points. Point attributes 
		/// such as Gl.POINT_SIZE and Gl.POINT_SMOOTH control the rasterization of the points. Polygon rasterization attributes 
		/// other than Gl.POLYGON_MODE have no effect.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int POINT = 0x1B00;

		/// <summary>
		/// Gl.PolygonMode: boundary edges of the polygon are drawn as line segments. Line attributes such as Gl.LINE_WIDTH and 
		/// Gl.LINE_SMOOTH control the rasterization of the lines. Polygon rasterization attributes other than Gl.POLYGON_MODE have 
		/// no effect.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINE = 0x1B01;

		/// <summary>
		/// Gl.PolygonMode: the interior of the polygon is filled. Polygon attributes such as Gl.POLYGON_SMOOTH control the 
		/// rasterization of the polygon.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int FILL = 0x1B02;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: keeps the current value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: keeps the current value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int KEEP = 0x1E00;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int REPLACE = 0x1E01;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: increments the current stencil buffer value. Clamps to the maximum representable unsigned value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: increments the current stencil buffer value. Clamps to the maximum representable unsigned value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int INCR = 0x1E02;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: decrements the current stencil buffer value. Clamps to 0.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: decrements the current stencil buffer value. Clamps to 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int DECR = 0x1E03;

		/// <summary>
		/// Gl.GetString: returns the company responsible for this GL implementation. This name does not change from release to 
		/// release.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int VENDOR = 0x1F00;

		/// <summary>
		/// Gl.GetString: returns the name of the renderer. This name is typically specific to a particular configuration of a 
		/// hardware platform. It does not change from release to release.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int RENDERER = 0x1F01;

		/// <summary>
		/// Gl.GetString: returns a version or release number.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int VERSION = 0x1F02;

		/// <summary>
		/// Gl.GetString: for glGetStringi only, returns the extension string supported by the implementation at index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int EXTENSIONS = 0x1F03;

		/// <summary>
		/// Value of GL_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NEAREST = 0x2600;

		/// <summary>
		/// Value of GL_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINEAR = 0x2601;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NEAREST_MIPMAP_NEAREST = 0x2700;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINEAR_MIPMAP_NEAREST = 0x2701;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int NEAREST_MIPMAP_LINEAR = 0x2702;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int LINEAR_MIPMAP_LINEAR = 0x2703;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture magnification filter, a symbolic constant. The initial value 
		/// is Gl.LINEAR.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture magnification filter, a symbolic constant. The initial value is 
		/// Gl.LINEAR.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: the texture magnification function is used when the pixel being textured maps to an area less than 
		/// or equal to one texture element. It sets the texture magnification function to either Gl.NEAREST or Gl.LINEAR (see 
		/// below). Gl.NEAREST is generally faster than Gl.LINEAR, but it can produce textured images with sharper edges because the 
		/// transition between texture elements is not as smooth. The initial value of Gl.TEXTURE_MAG_FILTER is Gl.LINEAR. 
		/// Gl.NEAREST Returns the value of the texture element that is nearest (in Manhattan distance) to the center of the pixel 
		/// being textured. Gl.LINEAR Returns the weighted average of the four texture elements that are closest to the center of 
		/// the pixel being textured. These can include border texture elements, depending on the values of Gl.TEXTURE_WRAP_S and 
		/// Gl.TEXTURE_WRAP_T, and on the exact mapping.
		/// </para>
		/// <para>
		/// Gl.TexParameter: the texture magnification function is used whenever the level-of-detail function used when sampling 
		/// from the texture determines that the texture should be magified. It sets the texture magnification function to either 
		/// Gl.NEAREST or Gl.LINEAR (see below). Gl.NEAREST is generally faster than Gl.LINEAR, but it can produce textured images 
		/// with sharper edges because the transition between texture elements is not as smooth. The initial value of 
		/// Gl.TEXTURE_MAG_FILTER is Gl.LINEAR. Gl.NEAREST Returns the value of the texture element that is nearest (in Manhattan 
		/// distance) to the specified texture coordinates. Gl.LINEAR Returns the weighted average of the texture elements that are 
		/// closest to the specified texture coordinates. These can include items wrapped or repeated from other parts of a texture, 
		/// depending on the values of Gl.TEXTURE_WRAP_S and Gl.TEXTURE_WRAP_T, and on the exact mapping.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_MAG_FILTER = 0x2800;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued texture minification filter, a symbolic constant. The initial value is 
		/// Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued texture minification filter, a symbolic constant. The initial value is 
		/// Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: the texture minifying function is used whenever the pixel being textured maps to an area greater 
		/// than one texture element. There are six defined minifying functions. Two of them use the nearest one or nearest four 
		/// texture elements to compute the texture value. The other four use mipmaps. A mipmap is an ordered set of arrays 
		/// representing the same image at progressively lower resolutions. If the texture has dimensions 2n×2m, there are max⁡nm+1 
		/// mipmaps. The first mipmap is the original texture, with dimensions 2n×2m. Each subsequent mipmap has dimensions 
		/// 2k-1×2l-1, where 2k×2l are the dimensions of the previous mipmap, until either k=0 or l=0. At that point, subsequent 
		/// mipmaps have dimension 1×2l-1 or 2k-1×1 until the final mipmap, which has dimension 1×1. To define the mipmaps, call 
		/// Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.CopyTexImage1D, or Gl.CopyTexImage2D with the level argument indicating 
		/// the order of the mipmaps. Level 0 is the original texture; level max⁡nm is the final 1×1 mipmap. params supplies a 
		/// function for minifying the texture as one of the following: Gl.NEAREST Returns the value of the texture element that is 
		/// nearest (in Manhattan distance) to the center of the pixel being textured. Gl.LINEAR Returns the weighted average of the 
		/// four texture elements that are closest to the center of the pixel being textured. These can include border texture 
		/// elements, depending on the values of Gl.TEXTURE_WRAP_S and Gl.TEXTURE_WRAP_T, and on the exact mapping. 
		/// Gl.NEAREST_MIPMAP_NEAREST Chooses the mipmap that most closely matches the size of the pixel being textured and uses the 
		/// Gl.NEAREST criterion (the texture element nearest to the center of the pixel) to produce a texture value. 
		/// Gl.LINEAR_MIPMAP_NEAREST Chooses the mipmap that most closely matches the size of the pixel being textured and uses the 
		/// Gl.LINEAR criterion (a weighted average of the four texture elements that are closest to the center of the pixel) to 
		/// produce a texture value. Gl.NEAREST_MIPMAP_LINEAR Chooses the two mipmaps that most closely match the size of the pixel 
		/// being textured and uses the Gl.NEAREST criterion (the texture element nearest to the center of the pixel) to produce a 
		/// texture value from each mipmap. The final texture value is a weighted average of those two values. 
		/// Gl.LINEAR_MIPMAP_LINEAR Chooses the two mipmaps that most closely match the size of the pixel being textured and uses 
		/// the Gl.LINEAR criterion (a weighted average of the four texture elements that are closest to the center of the pixel) to 
		/// produce a texture value from each mipmap. The final texture value is a weighted average of those two values. As more 
		/// texture elements are sampled in the minification process, fewer aliasing artifacts will be apparent. While the 
		/// Gl.NEAREST and Gl.LINEAR minification functions can be faster than the other four, they sample only one or four texture 
		/// elements to determine the texture value of the pixel being rendered and can produce moire patterns or ragged 
		/// transitions. The initial value of Gl.TEXTURE_MIN_FILTER is Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// <para>
		/// Gl.TexParameter: the texture minifying function is used whenever the level-of-detail function used when sampling from 
		/// the texture determines that the texture should be minified. There are six defined minifying functions. Two of them use 
		/// either the nearest texture elements or a weighted average of multiple texture elements to compute the texture value. The 
		/// other four use mipmaps. A mipmap is an ordered set of arrays representing the same image at progressively lower 
		/// resolutions. If the texture has dimensions 2n×2m, there are max⁡nm+1 mipmaps. The first mipmap is the original texture, 
		/// with dimensions 2n×2m. Each subsequent mipmap has dimensions 2k-1×2l-1, where 2k×2l are the dimensions of the previous 
		/// mipmap, until either k=0 or l=0. At that point, subsequent mipmaps have dimension 1×2l-1 or 2k-1×1 until the final 
		/// mipmap, which has dimension 1×1. To define the mipmaps, call Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, 
		/// Gl.CopyTexImage1D, or Gl.CopyTexImage2D with the level argument indicating the order of the mipmaps. Level 0 is the 
		/// original texture; level max⁡nm is the final 1×1 mipmap. params supplies a function for minifying the texture as one of 
		/// the following: Gl.NEAREST Returns the value of the texture element that is nearest (in Manhattan distance) to the 
		/// specified texture coordinates. Gl.LINEAR Returns the weighted average of the four texture elements that are closest to 
		/// the specified texture coordinates. These can include items wrapped or repeated from other parts of a texture, depending 
		/// on the values of Gl.TEXTURE_WRAP_S and Gl.TEXTURE_WRAP_T, and on the exact mapping. Gl.NEAREST_MIPMAP_NEAREST Chooses 
		/// the mipmap that most closely matches the size of the pixel being textured and uses the Gl.NEAREST criterion (the texture 
		/// element closest to the specified texture coordinates) to produce a texture value. Gl.LINEAR_MIPMAP_NEAREST Chooses the 
		/// mipmap that most closely matches the size of the pixel being textured and uses the Gl.LINEAR criterion (a weighted 
		/// average of the four texture elements that are closest to the specified texture coordinates) to produce a texture value. 
		/// Gl.NEAREST_MIPMAP_LINEAR Chooses the two mipmaps that most closely match the size of the pixel being textured and uses 
		/// the Gl.NEAREST criterion (the texture element closest to the specified texture coordinates ) to produce a texture value 
		/// from each mipmap. The final texture value is a weighted average of those two values. Gl.LINEAR_MIPMAP_LINEAR Chooses the 
		/// two mipmaps that most closely match the size of the pixel being textured and uses the Gl.LINEAR criterion (a weighted 
		/// average of the texture elements that are closest to the specified texture coordinates) to produce a texture value from 
		/// each mipmap. The final texture value is a weighted average of those two values. As more texture elements are sampled in 
		/// the minification process, fewer aliasing artifacts will be apparent. While the Gl.NEAREST and Gl.LINEAR minification 
		/// functions can be faster than the other four, they sample only one or multiple texture elements to determine the texture 
		/// value of the pixel being rendered and can produce moire patterns or ragged transitions. The initial value of 
		/// Gl.TEXTURE_MIN_FILTER is Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_MIN_FILTER = 0x2801;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued wrapping function for texture coordinate s, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued wrapping function for texture coordinate s, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: sets the wrap parameter for texture coordinate s to either Gl.CLAMP_TO_EDGE, Gl.MIRRORED_REPEAT, 
		/// Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. Gl.CLAMP_TO_BORDER causes the s coordinate to be clamped to the range -12N1+12N, 
		/// where N is the size of the texture in the direction of clamping.Gl.CLAMP_TO_EDGE causes s coordinates to be clamped to 
		/// the range 12N1-12N, where N is the size of the texture in the direction of clamping. Gl.REPEAT causes the integer part 
		/// of the s coordinate to be ignored; the GL uses only the fractional part, thereby creating a repeating pattern. 
		/// Gl.MIRRORED_REPEAT causes the s coordinate to be set to the fractional part of the texture coordinate if the integer 
		/// part of s is even; if the integer part of s is odd, then the s texture coordinate is set to 1-frac⁡s, where frac⁡s 
		/// represents the fractional part of s. Gl.MIRROR_CLAMP_TO_EDGE causes the the s coordinate to be repeated as for 
		/// Gl.MIRRORED_REPEAT for one reptition of the texture, at which point the coordinate to be clamped as in Gl.CLAMP_TO_EDGE. 
		/// Initially, Gl.TEXTURE_WRAP_S is set to Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the wrap parameter for texture coordinate s to either Gl.CLAMP_TO_EDGE, Gl.CLAMP_TO_BORDER, 
		/// Gl.MIRRORED_REPEAT, Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. Gl.CLAMP_TO_EDGE causes s coordinates to be clamped to the 
		/// range 12N1-12N, where N is the size of the texture in the direction of clamping. Gl.CLAMP_TO_BORDER evaluates s 
		/// coordinates in a similar manner to Gl.CLAMP_TO_EDGE. However, in cases where clamping would have occurred in 
		/// Gl.CLAMP_TO_EDGE mode, the fetched texel data is substituted with the values specified by Gl.TEXTURE_BORDER_COLOR. 
		/// Gl.REPEAT causes the integer part of the s coordinate to be ignored; the GL uses only the fractional part, thereby 
		/// creating a repeating pattern. Gl.MIRRORED_REPEAT causes the s coordinate to be set to the fractional part of the texture 
		/// coordinate if the integer part of s is even; if the integer part of s is odd, then the s texture coordinate is set to 
		/// 1-frac⁡s, where frac⁡s represents the fractional part of s. Gl.MIRROR_CLAMP_TO_EDGE causes the the s coordinate to be 
		/// repeated as for Gl.MIRRORED_REPEAT for one reptition of the texture, at which point the coordinate to be clamped as in 
		/// Gl.CLAMP_TO_EDGE. Initially, Gl.TEXTURE_WRAP_S is set to Gl.REPEAT.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_WRAP_S = 0x2802;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns the single-valued wrapping function for texture coordinate t, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns the single-valued wrapping function for texture coordinate t, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.SamplerParameter: sets the wrap parameter for texture coordinate t to either Gl.CLAMP_TO_EDGE, Gl.MIRRORED_REPEAT, 
		/// Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. See the discussion under Gl.TEXTURE_WRAP_S. Initially, Gl.TEXTURE_WRAP_T is set 
		/// to Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.TexParameter: sets the wrap parameter for texture coordinate t to either Gl.CLAMP_TO_EDGE, Gl.CLAMP_TO_BORDER, 
		/// Gl.MIRRORED_REPEAT, Gl.REPEAT, or Gl.MIRROR_CLAMP_TO_EDGE. See the discussion under Gl.TEXTURE_WRAP_S. Initially, 
		/// Gl.TEXTURE_WRAP_T is set to Gl.REPEAT.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int TEXTURE_WRAP_T = 0x2803;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_1D = 0x8063;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_2D = 0x8064;

		/// <summary>
		/// Value of GL_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int REPEAT = 0x2901;

		/// <summary>
		/// Value of GL_R3_G3_B2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		public const int R3_G3_B2 = 0x2A10;

		/// <summary>
		/// Value of GL_RGB4 symbol.
		/// </summary>
		[AliasOf("GL_RGB4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB4 = 0x804F;

		/// <summary>
		/// Value of GL_RGB5 symbol.
		/// </summary>
		[AliasOf("GL_RGB5_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB5 = 0x8050;

		/// <summary>
		/// Value of GL_RGB8 symbol.
		/// </summary>
		[AliasOf("GL_RGB8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB8 = 0x8051;

		/// <summary>
		/// Value of GL_RGB10 symbol.
		/// </summary>
		[AliasOf("GL_RGB10_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB10 = 0x8052;

		/// <summary>
		/// Value of GL_RGB12 symbol.
		/// </summary>
		[AliasOf("GL_RGB12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB12 = 0x8053;

		/// <summary>
		/// Value of GL_RGB16 symbol.
		/// </summary>
		[AliasOf("GL_RGB16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB16 = 0x8054;

		/// <summary>
		/// Value of GL_RGBA2 symbol.
		/// </summary>
		[AliasOf("GL_RGBA2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA2 = 0x8055;

		/// <summary>
		/// Value of GL_RGBA4 symbol.
		/// </summary>
		[AliasOf("GL_RGBA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA4 = 0x8056;

		/// <summary>
		/// Value of GL_RGB5_A1 symbol.
		/// </summary>
		[AliasOf("GL_RGB5_A1_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB5_A1 = 0x8057;

		/// <summary>
		/// Value of GL_RGBA8 symbol.
		/// </summary>
		[AliasOf("GL_RGBA8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA8 = 0x8058;

		/// <summary>
		/// Value of GL_RGB10_A2 symbol.
		/// </summary>
		[AliasOf("GL_RGB10_A2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB10_A2 = 0x8059;

		/// <summary>
		/// Value of GL_RGBA12 symbol.
		/// </summary>
		[AliasOf("GL_RGBA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA12 = 0x805A;

		/// <summary>
		/// Value of GL_RGBA16 symbol.
		/// </summary>
		[AliasOf("GL_RGBA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
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
		/// Gl.Clear: indicates the accumulation buffer.
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
		/// Gl.Begin: draws a connected group of quadrilaterals. One quadrilateral is defined for each pair of vertices presented 
		/// after the first pair. Vertices 2⁢n-1, 2⁢n, 2⁢n+2, and 2⁢n+1 define quadrilateral n. N2-1 quadrilaterals are drawn. Note 
		/// that the order in which vertices are used to construct a quadrilateral from strip data is different from that used with 
		/// independent data.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int QUAD_STRIP = 0x0008;

		/// <summary>
		/// Gl.Begin: draws a single, convex polygon. Vertices 1 through N define this polygon.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POLYGON = 0x0009;

		/// <summary>
		/// Gl.Accum: obtains R, G, B, and A values from the buffer currently selected for reading (see Gl.ReadBuffer). Each 
		/// component value is divided by 2n-1, where n is the number of bits allocated to each color component in the currently 
		/// selected buffer. The result is a floating-point value in the range 01, which is multiplied by value and added to the 
		/// corresponding pixel component in the accumulation buffer, thereby updating the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM = 0x0100;

		/// <summary>
		/// Gl.Accum: similar to Gl.ACCUM, except that the current value in the accumulation buffer is not used in the calculation 
		/// of the new value. That is, the R, G, B, and A values from the currently selected buffer are divided by 2n-1, multiplied 
		/// by value, and then stored in the corresponding accumulation buffer cell, overwriting the current value.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LOAD = 0x0101;

		/// <summary>
		/// Gl.Accum: transfers accumulation buffer values to the color buffer or buffers currently selected for writing. Each R, G, 
		/// B, and A component is multiplied by value, then multiplied by 2n-1, clamped to the range 02n-1, and stored in the 
		/// corresponding display buffer cell. The only fragment operations that are applied to this transfer are pixel ownership, 
		/// scissor, dithering, and color writemasks.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RETURN = 0x0102;

		/// <summary>
		/// Gl.Accum: multiplies each R, G, B, and A in the accumulation buffer by value and returns the scaled component to its 
		/// corresponding accumulation buffer location.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MULT = 0x0103;

		/// <summary>
		/// Gl.Accum: adds value to each R, G, B, and A in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EXP = 0x0800;

		/// <summary>
		/// Value of GL_EXP2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EXP2 = 0x0801;

		/// <summary>
		/// Gl.GetMap: v returns the control points for the evaluator function. One-dimensional evaluators return order control 
		/// points, and two-dimensional evaluators return uorder×vorder control points. Each control point consists of one, two, 
		/// three, or four integer, single-precision floating-point, or double-precision floating-point values, depending on the 
		/// type of the evaluator. The GL returns two-dimensional control points in row-major order, incrementing the uorder index 
		/// quickly and the vorder index after each row. Integer values, when requested, are computed by rounding the internal 
		/// floating-point values to the nearest integer values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COEFF = 0x0A00;

		/// <summary>
		/// Gl.GetMap: v returns the order of the evaluator function. One-dimensional evaluators return a single value, order. The 
		/// initial value is 1. Two-dimensional evaluators return two values, uorder and vorder. The initial value is 1,1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ORDER = 0x0A01;

		/// <summary>
		/// Gl.GetMap: v returns the linear u and v mapping parameters. One-dimensional evaluators return two values, u1 and u2, as 
		/// specified by Gl.Map1. Two-dimensional evaluators return four values (u1, u2, v1, and v2) as specified by Gl.Map2. 
		/// Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer 
		/// values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOMAIN = 0x0A02;

		/// <summary>
		/// Gl.PixelMap: maps color indices to color indices.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_I = 0x0C70;

		/// <summary>
		/// Gl.PixelMap: maps stencil indices to stencil indices.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_S_TO_S = 0x0C71;

		/// <summary>
		/// Gl.PixelMap: maps color indices to red components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_R = 0x0C72;

		/// <summary>
		/// Gl.PixelMap: maps color indices to green components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_G = 0x0C73;

		/// <summary>
		/// Gl.PixelMap: maps color indices to blue components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_B = 0x0C74;

		/// <summary>
		/// Gl.PixelMap: maps color indices to alpha components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_A = 0x0C75;

		/// <summary>
		/// Gl.PixelMap: maps red components to red components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_R_TO_R = 0x0C76;

		/// <summary>
		/// Gl.PixelMap: maps green components to green components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_G_TO_G = 0x0C77;

		/// <summary>
		/// Gl.PixelMap: maps blue components to blue components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_B_TO_B = 0x0C78;

		/// <summary>
		/// Gl.PixelMap: maps alpha components to alpha components.
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
		[AliasOf("GL_VERTEX_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_POINTER = 0x808E;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_POINTER = 0x808F;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_POINTER = 0x8090;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_POINTER = 0x8091;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_POINTER = 0x8092;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
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
		/// Gl.Get: params returns four values: the red, green, blue, and alpha values of the current color. Integer values, if 
		/// requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive 
		/// representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (1, 1, 
		/// 1, 1). See Gl.Color.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_COLOR = 0x0B00;

		/// <summary>
		/// Gl.Get: params returns one value, the current color index. The initial value is 1. See Gl.Index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_INDEX = 0x0B01;

		/// <summary>
		/// Gl.Get: params returns three values: the x, y, and z values of the current normal. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 0, 1). See 
		/// Gl.Normal.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_NORMAL = 0x0B02;

		/// <summary>
		/// Gl.Get: params returns four values: the s, t, r, and q current texture coordinates. The initial value is (0, 0, 0, 1). 
		/// See Gl.MultiTexCoord.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_TEXTURE_COORDS = 0x0B03;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha color values of the current raster position. Integer 
		/// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most 
		/// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value 
		/// is (1, 1, 1, 1). See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_COLOR = 0x0B04;

		/// <summary>
		/// Gl.Get: params returns one value, the color index of the current raster position. The initial value is 1. See 
		/// Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_INDEX = 0x0B05;

		/// <summary>
		/// Gl.Get: params returns four values: the s, t, r, and q texture coordinates of the current raster position. The initial 
		/// value is (0, 0, 0, 1). See Gl.RasterPos and Gl.MultiTexCoord.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

		/// <summary>
		/// Gl.Get: params returns four values: the x, y, z, and w components of the current raster position. x, y, and z are in 
		/// window coordinates, and w is in clip coordinates. The initial value is (0, 0, 0, 1). See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_POSITION = 0x0B07;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the current raster position is valid. The initial value 
		/// is Gl.TRUE. See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_POSITION_VALID = 0x0B08;

		/// <summary>
		/// Gl.Get: params returns one value, the distance from the eye to the current raster position. The initial value is 0. See 
		/// Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_DISTANCE = 0x0B09;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether antialiasing of points is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PointSize.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, draw points with proper filtering. Otherwise, draw aliased points. See Gl.PointSize.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SMOOTH = 0x0B10;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether stippling of lines is enabled. The initial value is 
		/// Gl.FALSE. See Gl.LineStipple.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, use the current line stipple pattern when drawing lines. See Gl.LineStipple.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE = 0x0B24;

		/// <summary>
		/// Gl.Get: params returns one value, the 16-bit line stipple pattern. The initial value is all 1's. See Gl.LineStipple.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE_PATTERN = 0x0B25;

		/// <summary>
		/// Gl.Get: params returns one value, the line stipple repeat factor. The initial value is 1. See Gl.LineStipple.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINE_STIPPLE_REPEAT = 0x0B26;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating the construction mode of the display list currently 
		/// under construction. The initial value is 0. See Gl.NewList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_MODE = 0x0B30;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum recursion depth allowed during display-list traversal. The value must be 
		/// at least 64. See Gl.CallList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_LIST_NESTING = 0x0B31;

		/// <summary>
		/// Gl.Get: params returns one value, the base offset added to all names in arrays presented to Gl.CallLists. The initial 
		/// value is 0. See Gl.ListBase.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_BASE = 0x0B32;

		/// <summary>
		/// Gl.Get: params returns one value, the name of the display list currently under construction. 0 is returned if no display 
		/// list is currently under construction. The initial value is 0. See Gl.NewList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIST_INDEX = 0x0B33;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether polygon stippling is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PolygonStipple.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, use the current polygon stipple pattern when rendering polygons. See Gl.PolygonStipple.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POLYGON_STIPPLE = 0x0B42;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the current edge flag is Gl.TRUE or Gl.FALSE. The 
		/// initial value is Gl.TRUE. See Gl.EdgeFlag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG = 0x0B43;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether lighting is enabled. The initial value is Gl.FALSE. See 
		/// Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, use the current lighting parameters to compute the vertex color or 
		/// index. Otherwise, simply associate the current color or index with each vertex. See Gl.Material, Gl.LightModel, and 
		/// Gl.Light.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHTING = 0x0B50;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether specular reflection calculations treat the viewer as 
		/// being local to the scene. The initial value is Gl.FALSE. See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params is a single integer or floating-point value that specifies how specular reflection angles are 
		/// computed. If params is 0 (or 0.0), specular reflection angles take the view direction to be parallel to and in the 
		/// direction of the -z axis, regardless of the location of the vertex in eye coordinates. Otherwise, specular reflections 
		/// are computed from the origin of the eye coordinate system. The initial value is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether separate materials are used to compute lighting for 
		/// front- and back-facing polygons. The initial value is Gl.FALSE. See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params is a single integer or floating-point value that specifies whether one- or two-sided lighting 
		/// calculations are done for polygons. It has no effect on the lighting calculations for points, lines, or bitmaps. If 
		/// params is 0 (or 0.0), one-sided lighting is specified, and only the front material parameters are used in the lighting 
		/// equation. Otherwise, two-sided lighting is specified. In this case, vertices of back-facing polygons are lighted using 
		/// the back material parameters and have their normals reversed before the lighting equation is evaluated. Vertices of 
		/// front-facing polygons are always lighted using the front material parameters, with no change to their normals. The 
		/// initial value is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_TWO_SIDE = 0x0B52;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha components of the ambient intensity of the entire 
		/// scene. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 
		/// returns the most positive representable integer value, and -1.0 returns the most negative representable integer value. 
		/// The initial value is (0.2, 0.2, 0.2, 1.0). See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params contains four integer or floating-point values that specify the ambient RGBA intensity of the 
		/// entire scene. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the 
		/// most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor 
		/// floating-point values are clamped. The initial ambient scene intensity is (0.2, 0.2, 0.2, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_AMBIENT = 0x0B53;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether the shading mode is flat or smooth. The initial 
		/// value is Gl.SMOOTH. See Gl.ShadeModel.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SHADE_MODEL = 0x0B54;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which materials have a parameter that is tracking the 
		/// current color. The initial value is Gl.FRONT_AND_BACK. See Gl.ColorMaterial.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL_FACE = 0x0B55;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which material parameters are tracking the current 
		/// color. The initial value is Gl.AMBIENT_AND_DIFFUSE. See Gl.ColorMaterial.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL_PARAMETER = 0x0B56;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether one or more material parameters are tracking the 
		/// current color. The initial value is Gl.FALSE. See Gl.ColorMaterial.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, have one or more material parameters track the current color. See Gl.ColorMaterial.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_MATERIAL = 0x0B57;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether fogging is enabled. The initial value is Gl.FALSE. See 
		/// Gl.Fog.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, blend a fog color into the post-texturing color. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG = 0x0B60;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies if, the fog color index. The initial fog index 
		/// is 0.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the fog color index. The initial value is 0. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_INDEX = 0x0B61;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies density, the fog density used in both 
		/// exponential fog equations. Only nonnegative densities are accepted. The initial fog density is 1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the fog density parameter. The initial value is 1. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_DENSITY = 0x0B62;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies start, the near distance used in the linear 
		/// fog equation. The initial near distance is 0.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the start factor for the linear fog equation. The initial value is 0. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_START = 0x0B63;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies end, the far distance used in the linear fog 
		/// equation. The initial far distance is 1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the end factor for the linear fog equation. The initial value is 1. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_END = 0x0B64;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies the equation to be used to compute the fog 
		/// blend factor, f. Three symbolic constants are accepted: Gl.LINEAR, Gl.EXP, and Gl.EXP2. The equations corresponding to 
		/// these symbolic constants are defined below. The initial fog mode is Gl.EXP.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating which fog equation is selected. The initial value is 
		/// Gl.EXP. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_MODE = 0x0B65;

		/// <summary>
		/// <para>
		/// Gl.Fog: params contains four integer or floating-point values that specify Cf, the fog color. Integer values are mapped 
		/// linearly such that the most positive representable value maps to 1.0, and the most negative representable value maps to 
		/// -1.0. Floating-point values are mapped directly. After conversion, all color components are clamped to the range 01. The 
		/// initial fog color is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha components of the fog color. Integer values, if 
		/// requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive 
		/// representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 0, 
		/// 0, 0). See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COLOR = 0x0B66;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha values used to clear the accumulation buffer. 
		/// Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns 
		/// the most positive representable integer value, and -1.0 returns the most negative representable integer value. The 
		/// initial value is (0, 0, 0, 0). See Gl.ClearAccum.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_CLEAR_VALUE = 0x0B80;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which matrix stack is currently the target of all 
		/// matrix operations. The initial value is Gl.MODELVIEW. See Gl.MatrixMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MATRIX_MODE = 0x0BA0;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether normals are automatically scaled to unit length after 
		/// they have been transformed to eye coordinates. The initial value is Gl.FALSE. See Gl.Normal.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, normal vectors are normalized to unit length after transformation 
		/// and before lighting. This method is generally less efficient than Gl.RESCALE_NORMAL. See Gl.Normal and Gl.NormalPointer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMALIZE = 0x0BA1;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the modelview matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW_STACK_DEPTH = 0x0BA3;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the projection matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION_STACK_DEPTH = 0x0BA4;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the texture matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_STACK_DEPTH = 0x0BA5;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the modelview matrix on the top of the modelview matrix stack. Initially this 
		/// matrix is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW_MATRIX = 0x0BA6;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the projection matrix on the top of the projection matrix stack. Initially this 
		/// matrix is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION_MATRIX = 0x0BA7;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the texture matrix on the top of the texture matrix stack. Initially this matrix 
		/// is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_MATRIX = 0x0BA8;

		/// <summary>
		/// Gl.Get: params returns one value, the depth of the attribute stack. If the stack is empty, 0 is returned. The initial 
		/// value is 0. See Gl.PushAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ATTRIB_STACK_DEPTH = 0x0BB0;

		/// <summary>
		/// Gl.Get: params returns one value indicating the depth of the attribute stack. The initial value is 0. See 
		/// Gl.PushClientAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether alpha testing of fragments is enabled. The initial 
		/// value is Gl.FALSE. See Gl.AlphaFunc.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, do alpha testing. See Gl.AlphaFunc.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST = 0x0BC0;

		/// <summary>
		/// Gl.Get: the symbolic name of the alpha test function. The initial value is Gl.ALWAYS. See Gl.AlphaFunc.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST_FUNC = 0x0BC1;

		/// <summary>
		/// Gl.Get: params returns one value, the reference value for the alpha test. The initial value is 0. See Gl.AlphaFunc. An 
		/// integer value, if requested, is linearly mapped from the internal floating-point representation such that 1.0 returns 
		/// the most positive representable integer value, and -1.0 returns the most negative representable integer value.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_TEST_REF = 0x0BC2;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether a fragment's index values are merged into the 
		/// framebuffer using a logical operation. The initial value is Gl.FALSE. See Gl.LogicOp.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, apply the currently selected logical operation to the incoming index and color buffer indices. 
		/// See Gl.LogicOp.
		/// </para>
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
		/// Gl.Get: params returns one value, the number of auxiliary color buffers available.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUX_BUFFERS = 0x0C00;

		/// <summary>
		/// Gl.Get: params returns one value, the color index used to clear the color index buffers. The initial value is 0. See 
		/// Gl.ClearIndex.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_CLEAR_VALUE = 0x0C20;

		/// <summary>
		/// Gl.Get: params returns one value, a mask indicating which bitplanes of each color index buffer can be written. The 
		/// initial value is all 1's. See Gl.IndexMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_WRITEMASK = 0x0C21;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the GL is in color index mode (Gl.TRUE) or RGBA mode 
		/// (Gl.FALSE).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_MODE = 0x0C30;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the GL is in RGBA mode (true) or color index mode 
		/// (false). See Gl.Color.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RGBA_MODE = 0x0C31;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether the GL is in render, select, or feedback mode. 
		/// The initial value is Gl.RENDER. See Gl.RenderMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RENDER_MODE = 0x0C40;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the perspective correction hint. The 
		/// initial value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the quality of color, texture coordinate, and fog coordinate interpolation. If perspective-corrected 
		/// parameter interpolation is not efficiently supported by the GL implementation, hinting Gl.DONT_CARE or Gl.FASTEST can 
		/// result in simple linear interpolation of colors and/or texture coordinates.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PERSPECTIVE_CORRECTION_HINT = 0x0C50;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the point antialiasing hint. The initial 
		/// value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the sampling quality of antialiased points. If a larger filter function is applied, hinting Gl.NICEST 
		/// can result in more pixel fragments being generated during rasterization.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SMOOTH_HINT = 0x0C51;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the fog hint. The initial value is 
		/// Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the accuracy of fog calculation. If per-pixel fog calculation is not efficiently supported by the GL 
		/// implementation, hinting Gl.DONT_CARE or Gl.FASTEST can result in per-vertex calculation of fog effects.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_HINT = 0x0C54;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the S texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, the s texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current s texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_S = 0x0C60;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the T texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, the t texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current t texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_T = 0x0C61;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the r texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, the r texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current r texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_R = 0x0C62;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the q texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no vertex shader is active, the q texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current q texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_Q = 0x0C63;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-index pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the stencil-to-stencil pixel translation table. The initial value is 1. 
		/// See Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-red pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-green pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-blue pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-alpha pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the red-to-red pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the green-to-green pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the blue-to-blue pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the alpha-to-alpha pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating if colors and color indices are to be replaced by table lookup 
		/// during pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP_COLOR = 0x0D10;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating if stencil indices are to be replaced by table lookup during 
		/// pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP_STENCIL = 0x0D11;

		/// <summary>
		/// Gl.Get: params returns one value, the amount that color and stencil indices are shifted during pixel transfers. The 
		/// initial value is 0. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_SHIFT = 0x0D12;

		/// <summary>
		/// Gl.Get: params returns one value, the offset added to color and stencil indices during pixel transfers. The initial 
		/// value is 0. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_OFFSET = 0x0D13;

		/// <summary>
		/// Gl.Get: params returns one value, the red scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_SCALE = 0x0D14;

		/// <summary>
		/// Gl.Get: params returns one value, the red bias factor used during pixel transfers. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_BIAS = 0x0D15;

		/// <summary>
		/// Gl.Get: params returns one value, the x pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ZOOM_X = 0x0D16;

		/// <summary>
		/// Gl.Get: params returns one value, the y pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ZOOM_Y = 0x0D17;

		/// <summary>
		/// Gl.Get: params returns one value, the green scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_SCALE = 0x0D18;

		/// <summary>
		/// Gl.Get: params returns one value, the green bias factor used during pixel transfers. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_BIAS = 0x0D19;

		/// <summary>
		/// Gl.Get: params returns one value, the blue scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_SCALE = 0x0D1A;

		/// <summary>
		/// Gl.Get: params returns one value, the blue bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_BIAS = 0x0D1B;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, the alpha scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </para>
		/// <para>
		/// Gl.GetTexEnv: params returns a single floating-point value representing the current alpha texture combiner scaling 
		/// factor. The initial value is 1.0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_SCALE = 0x0D1C;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_BIAS = 0x0D1D;

		/// <summary>
		/// Gl.Get: params returns one value, the depth scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_SCALE = 0x0D1E;

		/// <summary>
		/// Gl.Get: params returns one value, the depth bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_BIAS = 0x0D1F;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum equation order supported by 1D and 2D evaluators. The value must be at 
		/// least 8. See Gl.Map1 and Gl.Map2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_EVAL_ORDER = 0x0D30;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum number of lights. The value must be at least 8. See Gl.Light.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_LIGHTS = 0x0D31;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum number of application-defined clipping planes. The value must be at least 
		/// 6. See Gl.ClipPlane.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_CLIP_PLANES = 0x0D32;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported size of a Gl.PixelMap lookup table. The value must be at least 
		/// 32. See Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_PIXEL_MAP_TABLE = 0x0D34;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the attribute stack. The value must be at least 16. See 
		/// Gl.PushAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_ATTRIB_STACK_DEPTH = 0x0D35;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value must be at least 
		/// 32. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the selection name stack. The value must be at least 
		/// 64. See Gl.PushName.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_NAME_STACK_DEPTH = 0x0D37;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the projection matrix stack. The value must be at least 
		/// 2. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_PROJECTION_STACK_DEPTH = 0x0D38;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the texture matrix stack. The value must be at least 2. 
		/// See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_TEXTURE_STACK_DEPTH = 0x0D39;

		/// <summary>
		/// Gl.Get: params returns one value indicating the maximum supported depth of the client attribute stack. See 
		/// Gl.PushClientAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in each color index buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_BITS = 0x0D51;

		/// <summary>
		/// Gl.Get: params returns one value, the number of red bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RED_BITS = 0x0D52;

		/// <summary>
		/// Gl.Get: params returns one value, the number of green bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GREEN_BITS = 0x0D53;

		/// <summary>
		/// Gl.Get: params returns one value, the number of blue bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int BLUE_BITS = 0x0D54;

		/// <summary>
		/// Gl.Get: params returns one value, the number of alpha bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_BITS = 0x0D55;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in the depth buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_BITS = 0x0D56;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in the stencil buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int STENCIL_BITS = 0x0D57;

		/// <summary>
		/// Gl.Get: params returns one value, the number of red bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_RED_BITS = 0x0D58;

		/// <summary>
		/// Gl.Get: params returns one value, the number of green bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_GREEN_BITS = 0x0D59;

		/// <summary>
		/// Gl.Get: params returns one value, the number of blue bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_BLUE_BITS = 0x0D5A;

		/// <summary>
		/// Gl.Get: params returns one value, the number of alpha bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ACCUM_ALPHA_BITS = 0x0D5B;

		/// <summary>
		/// Gl.Get: params returns one value, the number of names on the selection name stack. The initial value is 0. See 
		/// Gl.PushName.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NAME_STACK_DEPTH = 0x0D70;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D map evaluation automatically generates surface 
		/// normals. The initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, generate normal vectors when either Gl.MAP2_VERTEX_3 or Gl.MAP2_VERTEX_4 is used to generate 
		/// vertices. See Gl.Map2.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AUTO_NORMAL = 0x0D80;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates colors. The initial value is 
		/// Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate RGBA values. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is four floating-point values representing red, green, blue, and alpha. Internal Gl.Color4 
		/// commands are generated when the map is evaluated but the current color is not updated with the value of these Gl.Color4 
		/// commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_COLOR_4 = 0x0D90;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates color indices. The initial 
		/// value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate color indices. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is a single floating-point value representing a color index. Internal Gl.Index commands are 
		/// generated when the map is evaluated but the current index is not updated with the value of these Gl.Index commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_INDEX = 0x0D91;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates normals. The initial value is 
		/// Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate normals. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is three floating-point values representing the x, y, and z components of a normal vector. 
		/// Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated with the value 
		/// of these Gl.Normal commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_NORMAL = 0x0D92;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 1D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s texture coordinates. See 
		/// Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is a single floating-point value representing the s texture coordinate. Internal 
		/// Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_1 = 0x0D93;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 2D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s and t texture coordinates. See 
		/// Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is two floating-point values representing the s and t texture coordinates. Internal 
		/// Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_2 = 0x0D94;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, and r texture coordinates. 
		/// See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is three floating-point values representing the s, t, and r texture coordinates. Internal 
		/// Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_3 = 0x0D95;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, r, and q texture 
		/// coordinates. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is four floating-point values representing the s, t, r, and q texture coordinates. Internal 
		/// Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_TEXTURE_COORD_4 = 0x0D96;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate x, y, and z vertex coordinates. 
		/// See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_VERTEX_3 = 0x0D97;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate homogeneous x, y, z, and w 
		/// vertex coordinates. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_VERTEX_4 = 0x0D98;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates colors. The initial value is 
		/// Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate RGBA values. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is four floating-point values representing red, green, blue, and alpha. Internal Gl.Color4 
		/// commands are generated when the map is evaluated but the current color is not updated with the value of these Gl.Color4 
		/// commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_COLOR_4 = 0x0DB0;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates color indices. The initial 
		/// value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate color indices. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is a single floating-point value representing a color index. Internal Gl.Index commands are 
		/// generated when the map is evaluated but the current index is not updated with the value of these Gl.Index commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_INDEX = 0x0DB1;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates normals. The initial value is 
		/// Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate normals. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is three floating-point values representing the x, y, and z components of a normal vector. 
		/// Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated with the value 
		/// of these Gl.Normal commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_NORMAL = 0x0DB2;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 1D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s texture coordinates. See 
		/// Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is a single floating-point value representing the s texture coordinate. Internal 
		/// Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_1 = 0x0DB3;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 2D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s and t texture coordinates. See 
		/// Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is two floating-point values representing the s and t texture coordinates. Internal 
		/// Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_2 = 0x0DB4;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, and r texture coordinates. 
		/// See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is three floating-point values representing the s, t, and r texture coordinates. Internal 
		/// Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_3 = 0x0DB5;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, r, and q texture 
		/// coordinates. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is four floating-point values representing the s, t, r, and q texture coordinates. Internal 
		/// Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_TEXTURE_COORD_4 = 0x0DB6;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate x, y, and z vertex coordinates. 
		/// See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_VERTEX_3 = 0x0DB7;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate homogeneous x, y, z, and w 
		/// vertex coordinates. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_VERTEX_4 = 0x0DB8;

		/// <summary>
		/// Gl.Get: params returns two values: the endpoints of the 1D map's grid domain. The initial value is (0, 1). See 
		/// Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_GRID_DOMAIN = 0x0DD0;

		/// <summary>
		/// Gl.Get: params returns one value, the number of partitions in the 1D map's grid domain. The initial value is 1. See 
		/// Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP1_GRID_SEGMENTS = 0x0DD1;

		/// <summary>
		/// Gl.Get: params returns four values: the endpoints of the 2D map's i and j grid domains. The initial value is (0,1; 0,1). 
		/// See Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_GRID_DOMAIN = 0x0DD2;

		/// <summary>
		/// Gl.Get: params returns two values: the number of partitions in the 2D map's i and j grid domains. The initial value is 
		/// (1,1). See Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAP2_GRID_SEGMENTS = 0x0DD3;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the feedback buffer. See Gl.FeedbackBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK_BUFFER_SIZE = 0x0DF1;

		/// <summary>
		/// Gl.Get: params returns one value, the type of the feedback buffer. See Gl.FeedbackBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK_BUFFER_TYPE = 0x0DF2;

		/// <summary>
		/// Gl.Get: params return one value, the size of the selection buffer. See Gl.SelectBuffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SELECTION_BUFFER_SIZE = 0x0DF4;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the vertex array is enabled. The initial value is 
		/// Gl.FALSE. See Gl.VertexPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the vertex array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.VertexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY = 0x8074;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value, indicating whether the normal array is enabled. The initial value is 
		/// Gl.FALSE. See Gl.NormalPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the normal array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.NormalPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY = 0x8075;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the color array is enabled. The initial value is 
		/// Gl.FALSE. See Gl.ColorPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the color array is enabled for writing and used during rendering when Gl.ArrayElement, 
		/// Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is called. See 
		/// Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY = 0x8076;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the color index array is enabled. The initial value is 
		/// Gl.FALSE. See Gl.IndexPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the index array is enabled for writing and used during rendering when Gl.ArrayElement, 
		/// Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is called. See 
		/// Gl.IndexPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY = 0x8077;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the texture coordinate array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.TexCoordPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the texture coordinate array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.TexCoordPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY = 0x8078;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the edge flag array is enabled. The initial value is 
		/// Gl.FALSE. See Gl.EdgeFlagPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the edge flag array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.EdgeFlagPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY = 0x8079;

		/// <summary>
		/// Gl.Get: params returns one value, the number of coordinates per vertex in the vertex array. The initial value is 4. See 
		/// Gl.VertexPointer.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_SIZE = 0x807A;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of each coordinate in the vertex array. The initial value is Gl.FLOAT. 
		/// See Gl.VertexPointer.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_TYPE = 0x807B;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive vertices in the vertex array. The initial value is 
		/// 0. See Gl.VertexPointer.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_STRIDE = 0x807C;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of each coordinate in the normal array. The initial value is Gl.FLOAT. 
		/// See Gl.NormalPointer.
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_TYPE = 0x807E;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive normals in the normal array. The initial value is 
		/// 0. See Gl.NormalPointer.
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_STRIDE = 0x807F;

		/// <summary>
		/// Gl.Get: params returns one value, the number of components per color in the color array. The initial value is 4. See 
		/// Gl.ColorPointer.
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_SIZE = 0x8081;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of each component in the color array. The initial value is Gl.FLOAT. See 
		/// Gl.ColorPointer.
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_TYPE = 0x8082;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive colors in the color array. The initial value is 0. 
		/// See Gl.ColorPointer.
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_STRIDE = 0x8083;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of indexes in the color index array. The initial value is Gl.FLOAT. See 
		/// Gl.IndexPointer.
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_TYPE = 0x8085;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive color indexes in the color index array. The 
		/// initial value is 0. See Gl.IndexPointer.
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_STRIDE = 0x8086;

		/// <summary>
		/// Gl.Get: params returns one value, the number of coordinates per element in the texture coordinate array. The initial 
		/// value is 4. See Gl.TexCoordPointer.
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_SIZE = 0x8088;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of the coordinates in the texture coordinate array. The initial value is 
		/// Gl.FLOAT. See Gl.TexCoordPointer.
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_TYPE = 0x8089;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive elements in the texture coordinate array. The 
		/// initial value is 0. See Gl.TexCoordPointer.
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive edge flags in the edge flag array. The initial 
		/// value is 0. See Gl.EdgeFlagPointer.
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
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
		/// Gl.GetTexLevelParameter: params returns a single value, the width in pixels of the border of the texture image. The 
		/// initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_BORDER = 0x1005;

		/// <summary>
		/// Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_LUMINANCE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_LUMINANCE_SIZE = 0x8060;

		/// <summary>
		/// Gl.GetTexLevelParameter: 
		/// </summary>
		[AliasOf("GL_TEXTURE_INTENSITY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_INTENSITY_SIZE = 0x8061;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns the residence priority of the target texture (or the named texture bound to it). The initial 
		/// value is 1. See Gl.PrioritizeTextures.
		/// </para>
		/// <para>
		/// Gl.TexParameter: specifies the texture residence priority of the currently bound texture. Permissible values are in the 
		/// range 01. See Gl.PrioritizeTextures and Gl.BindTexture for more information.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_PRIORITY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_PRIORITY = 0x8066;

		/// <summary>
		/// Gl.GetTexParameter: returns the residence status of the target texture. If the value returned in params is Gl.TRUE, the 
		/// texture is resident in texture memory. See Gl.AreTexturesResident.
		/// </summary>
		[AliasOf("GL_TEXTURE_RESIDENT_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_RESIDENT = 0x8067;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the ambient intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the ambient reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0.2, 0.2, 0.2, 1.0)
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the ambient RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial ambient light intensity is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the ambient RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial ambient reflectance for both front- and back-facing materials is (0.2, 0.2, 0.2, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AMBIENT = 0x1200;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the diffuse intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the diffuse reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0.8, 0.8, 0.8, 1.0).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the diffuse RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the diffuse RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial diffuse reflectance for both front- and back-facing materials is (0.8, 0.8, 0.8, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DIFFUSE = 0x1201;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the specular intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the specular reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the specular RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the specular RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial specular reflectance for both front- and back-facing materials is (0, 0, 0, 1).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPECULAR = 0x1202;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the position of the light source. Integer 
		/// values, when requested, are computed by rounding the internal floating-point values to the nearest integer value. The 
		/// returned values are those maintained in eye coordinates. They will not be equal to the values specified using Gl.Light, 
		/// unless the modelview matrix was identity at the time Gl.Light was called. The initial value is (0, 0, 1, 0).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the position of the light in homogeneous 
		/// object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The position is transformed by the modelview matrix when glLight is called (just as if it were a 
		/// point), and it is stored in eye coordinates. If the w component of the position is 0, the light is treated as a 
		/// directional source. Diffuse and specular lighting calculations take the light's direction, but not its actual position, 
		/// into account, and attenuation is disabled. Otherwise, diffuse and specular lighting calculations are based on the actual 
		/// location of the light in eye coordinates, and attenuation is enabled. The initial position is (0, 0, 1, 0); thus, the 
		/// initial light source is directional, parallel to, and in the direction of the -z axis.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POSITION = 0x1203;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns three integer or floating-point values representing the direction of the light source. 
		/// Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer 
		/// value. The returned values are those maintained in eye coordinates. They will not be equal to the values specified using 
		/// Gl.Light, unless the modelview matrix was identity at the time Gl.Light was called. Although spot direction is 
		/// normalized before being used in the lighting equation, the returned values are the transformed versions of the specified 
		/// values prior to normalization. The initial value is 00-1.
		/// </para>
		/// <para>
		/// Gl.Light: params contains three integer or floating-point values that specify the direction of the light in homogeneous 
		/// object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The spot direction is transformed by the upper 3x3 of the modelview matrix when glLight is called, 
		/// and it is stored in eye coordinates. It is significant only when Gl.SPOT_CUTOFF is not 180, which it is initially. The 
		/// initial direction is 00-1.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_DIRECTION = 0x1204;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the spot exponent of the light. An 
		/// integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies the intensity distribution of the light. 
		/// Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. Effective light 
		/// intensity is attenuated by the cosine of the angle between the direction of the light and the direction from the light 
		/// to the vertex being lighted, raised to the power of the spot exponent. Thus, higher spot exponents result in a more 
		/// focused light source, regardless of the spot cutoff angle (see Gl.SPOT_CUTOFF, next paragraph). The initial spot 
		/// exponent is 0, resulting in uniform light distribution.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_EXPONENT = 0x1205;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the spot cutoff angle of the light. An 
		/// integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 180.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies the maximum spread angle of a light source. 
		/// Integer and floating-point values are mapped directly. Only values in the range 090 and the special value 180 are 
		/// accepted. If the angle between the direction of the light and the direction from the light to the vertex being lighted 
		/// is greater than the spot cutoff angle, the light is completely masked. Otherwise, its intensity is controlled by the 
		/// spot exponent and the attenuation factors. The initial spot cutoff is 180, resulting in uniform light distribution.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SPOT_CUTOFF = 0x1206;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the constant (not distance-related) 
		/// attenuation of the light. An integer value, when requested, is computed by rounding the internal floating-point 
		/// representation to the nearest integer. The initial value is 1.
		/// </para>
		/// <para>
		/// Gl.Light: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CONSTANT_ATTENUATION = 0x1207;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the linear attenuation of the light. 
		/// An integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LINEAR_ATTENUATION = 0x1208;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the quadratic attenuation of the 
		/// light. An integer value, when requested, is computed by rounding the internal floating-point representation to the 
		/// nearest integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies one of the three light attenuation factors. 
		/// Integer and floating-point values are mapped directly. Only nonnegative values are accepted. If the light is positional, 
		/// rather than directional, its intensity is attenuated by the reciprocal of the sum of the constant factor, the linear 
		/// factor times the distance between the light and the vertex being lighted, and the quadratic factor times the square of 
		/// the same distance. The initial attenuation factors are (1, 0, 0), resulting in no attenuation.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int QUADRATIC_ATTENUATION = 0x1209;

		/// <summary>
		/// Gl.NewList: commands are merely compiled.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPILE = 0x1300;

		/// <summary>
		/// Gl.NewList: commands are executed as they are compiled into the display list.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPILE_AND_EXECUTE = 0x1301;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each pair of bytes specifies a single display-list name. 
		/// The value of the pair is computed as 256 times the unsigned value of the first byte plus the unsigned value of the 
		/// second byte.
		/// </summary>
		[AliasOf("GL_2_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _2_BYTES = 0x1407;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each triplet of bytes specifies a single display-list 
		/// name. The value of the triplet is computed as 65536 times the unsigned value of the first byte, plus 256 times the 
		/// unsigned value of the second byte, plus the unsigned value of the third byte.
		/// </summary>
		[AliasOf("GL_3_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _3_BYTES = 0x1408;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each quadruplet of bytes specifies a single display-list 
		/// name. The value of the quadruplet is computed as 16777216 times the unsigned value of the first byte, plus 65536 times 
		/// the unsigned value of the second byte, plus 256 times the unsigned value of the third byte, plus the unsigned value of 
		/// the fourth byte.
		/// </summary>
		[AliasOf("GL_4_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int _4_BYTES = 0x1409;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the emitted light intensity of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the RGBA emitted light intensity of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial emission intensity for both front- and back-facing materials is (0, 0, 0, 1).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EMISSION = 0x1600;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns one integer or floating-point value representing the specular exponent of the material. 
		/// Integer values, when requested, are computed by rounding the internal floating-point value to the nearest integer value. 
		/// The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Material: params is a single integer or floating-point value that specifies the RGBA specular exponent of the 
		/// material. Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. The initial 
		/// specular exponent for both front- and back-facing materials is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SHININESS = 0x1601;

		/// <summary>
		/// Gl.Material: equivalent to calling glMaterial twice with the same parameter values, once with Gl.AMBIENT and once with 
		/// Gl.DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int AMBIENT_AND_DIFFUSE = 0x1602;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns three integer or floating-point values representing the ambient, diffuse, and specular 
		/// indices of the material. These indices are used only for color index lighting. (All the other parameters are used only 
		/// for RGBA lighting.) Integer values, when requested, are computed by rounding the internal floating-point values to the 
		/// nearest integer values.
		/// </para>
		/// <para>
		/// Gl.Material: params contains three integer or floating-point values specifying the color indices for ambient, diffuse, 
		/// and specular lighting. These three values, and Gl.SHININESS, are the only material values used by the color index mode 
		/// lighting equation. Refer to the Gl.LightModel reference page for a discussion of color index lighting.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_INDEXES = 0x1603;

		/// <summary>
		/// Gl.MatrixMode: applies subsequent matrix operations to the modelview matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODELVIEW = 0x1700;

		/// <summary>
		/// Gl.MatrixMode: applies subsequent matrix operations to the projection matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PROJECTION = 0x1701;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: color indices are read from the color buffer selected by Gl.ReadBuffer. Each index is converted to fixed 
		/// point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. If 
		/// Gl.MAP_COLOR is Gl.TRUE, indices are replaced by their mappings in the table Gl.PIXEL_MAP_I_TO_I.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a single value, a color index. It is converted to fixed-point format, with an unspecified 
		/// number of bits to the right of the binary point, regardless of the memory data type. Floating-point values convert to 
		/// true fixed-point values. Signed and unsigned integer data is converted with all fraction bits set to 0. Bitmap data 
		/// convert to either 0 or 1. Each fixed-point index is then shifted left by Gl.INDEX_SHIFT bits and added to 
		/// Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either case, zero bits fill otherwise 
		/// unspecified bit locations in the result. If the GL is in RGBA mode, the resulting index is converted to an RGBA pixel 
		/// with the help of the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables. If 
		/// the GL is in color index mode, and if Gl.MAP_COLOR is true, the index is replaced with the value that it references in 
		/// lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of the index is done or not, the integer part of the 
		/// index is then ANDed with 2b-1, where b is the number of bits in a color index buffer. The GL then converts the resulting 
		/// indices or RGBA colors to fragments by attaching the current raster position z coordinate and texture coordinates to 
		/// each pixel, then assigning x and y window coordinates to the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr 
		/// is the current raster position. These pixel fragments are then treated just like the fragments generated by rasterizing 
		/// points, lines, or polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments are 
		/// written to the frame buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_INDEX = 0x1900;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a single luminance component. This component is converted to the internal floating-point 
		/// format in the same way the red component of an RGBA pixel is. It is then converted to an RGBA pixel with red, green, and 
		/// blue set to the converted luminance value, and alpha set to 1. After this conversion, the pixel is treated as if it had 
		/// been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE = 0x1909;

		/// <summary>
		/// <para>
		/// Gl.ReadPixels: processing differs depending on whether color buffers store color indices or RGBA color components. If 
		/// color indices are stored, they are read from the color buffer selected by Gl.ReadBuffer. Each index is converted to 
		/// fixed point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. 
		/// Indices are then replaced by the red, green, blue, and alpha values obtained by indexing the tables Gl.PIXEL_MAP_I_TO_R, 
		/// Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A. Each table must be of size 2n, but n may be different 
		/// for different tables. Before an index is used to look up a value in a table of size 2n, it must be masked against 2n-1. 
		/// If RGBA color components are stored in the color buffers, they are read from the color buffer selected by Gl.ReadBuffer. 
		/// Each color component is converted to floating point such that zero intensity maps to 0.0 and full intensity maps to 1.0. 
		/// Each component is then multiplied by Gl.c_SCALE and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, or ALPHA. Finally, 
		/// if Gl.MAP_COLOR is Gl.TRUE, each component is clamped to the range 01, scaled to the size of its corresponding table, 
		/// and is then replaced by its mapping in the table Gl.PIXEL_MAP_c_TO_c, where c is R, G, B, or A. Unneeded data is then 
		/// discarded. For example, Gl.RED discards the green, blue, and alpha components, while Gl.RGB discards only the alpha 
		/// component. Gl.LUMINANCE computes a single-component value as the sum of the red, green, and blue components, and 
		/// Gl.LUMINANCE_ALPHA does the same, while keeping alpha as a second value. The final values are clamped to the range 01.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.DrawPixels: each pixel is a two-component group: luminance first, followed by alpha. The two components are converted 
		/// to the internal floating-point format in the same way the red component of an RGBA pixel is. They are then converted to 
		/// an RGBA pixel with red, green, and blue set to the converted luminance value, and alpha set to the converted alpha 
		/// value. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
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
		/// <para>
		/// Gl.RenderMode: render mode. Primitives are rasterized, producing pixel fragments, which are written into the frame 
		/// buffer. This is the normal mode and also the default mode.
		/// </para>
		/// <para>
		/// Gl.RenderMode: 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RENDER = 0x1C00;

		/// <summary>
		/// <para>
		/// Gl.RenderMode: feedback mode. No pixel fragments are produced, and no change to the frame buffer contents is made. 
		/// Instead, the coordinates and attributes of vertices that would have been drawn if the render mode had been Gl.RENDER is 
		/// returned in a feedback buffer, which must be created (see Gl.FeedbackBuffer) before feedback mode is entered.
		/// </para>
		/// <para>
		/// Gl.RenderMode: the number of values (not vertices) transferred to the feedback buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FEEDBACK = 0x1C01;

		/// <summary>
		/// <para>
		/// Gl.RenderMode: selection mode. No pixel fragments are produced, and no change to the frame buffer contents is made. 
		/// Instead, a record of the names of primitives that would have been drawn if the render mode had been Gl.RENDER is 
		/// returned in a select buffer, which must be created (see Gl.SelectBuffer) before selection mode is entered.
		/// </para>
		/// <para>
		/// Gl.RenderMode: the number of hit records transferred to the select buffer.
		/// </para>
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FLAT = 0x1D00;

		/// <summary>
		/// Value of GL_SMOOTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MODULATE = 0x2100;

		/// <summary>
		/// Value of GL_DECAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DECAL = 0x2101;

		/// <summary>
		/// Gl.GetTexEnv: params returns the single-valued texture environment mode, a symbolic constant. The initial value is 
		/// Gl.MODULATE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV_MODE = 0x2200;

		/// <summary>
		/// Gl.GetTexEnv: params returns four integer or floating-point values that are the texture environment color. Integer 
		/// values, when requested, are linearly mapped from the internal floating-point representation such that 1.0 maps to the 
		/// most positive representable integer, and -1.0 maps to the most negative representable integer. The initial value is (0, 
		/// 0, 0, 0).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV_COLOR = 0x2201;

		/// <summary>
		/// Value of GL_TEXTURE_ENV symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_ENV = 0x2300;

		/// <summary>
		/// Value of GL_EYE_LINEAR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_EYE_LINEAR_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EYE_LINEAR = 0x2400;

		/// <summary>
		/// Value of GL_OBJECT_LINEAR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_OBJECT_LINEAR_NV")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_path_rendering")]
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
		/// Gl.GetTexGen: params returns the single-valued texture generation function, a symbolic constant. The initial value is 
		/// Gl.EYE_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_GEN_MODE = 0x2500;

		/// <summary>
		/// Gl.GetTexGen: params returns the four plane equation coefficients that specify object linear-coordinate generation. 
		/// Integer values, when requested, are mapped directly from the internal floating-point representation.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OBJECT_PLANE = 0x2501;

		/// <summary>
		/// Gl.GetTexGen: params returns the four plane equation coefficients that specify eye linear-coordinate generation. Integer 
		/// values, when requested, are mapped directly from the internal floating-point representation. The returned values are 
		/// those maintained in eye coordinates. They are not equal to the values specified using Gl.TexGen, unless the modelview 
		/// matrix was identity when Gl.TexGen was called.
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
		[AliasOf("GL_ALPHA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA4 = 0x803B;

		/// <summary>
		/// Value of GL_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA8 = 0x803C;

		/// <summary>
		/// Value of GL_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA12 = 0x803D;

		/// <summary>
		/// Value of GL_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA16 = 0x803E;

		/// <summary>
		/// Value of GL_LUMINANCE4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE4 = 0x803F;

		/// <summary>
		/// Value of GL_LUMINANCE8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE8 = 0x8040;

		/// <summary>
		/// Value of GL_LUMINANCE12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12 = 0x8041;

		/// <summary>
		/// Value of GL_LUMINANCE16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE16 = 0x8042;

		/// <summary>
		/// Value of GL_LUMINANCE4_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE4_ALPHA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE4_ALPHA4 = 0x8043;

		/// <summary>
		/// Value of GL_LUMINANCE6_ALPHA2 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE6_ALPHA2_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE6_ALPHA2 = 0x8044;

		/// <summary>
		/// Value of GL_LUMINANCE8_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE8_ALPHA8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE8_ALPHA8 = 0x8045;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_ALPHA4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12_ALPHA4 = 0x8046;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE12_ALPHA12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE12_ALPHA12 = 0x8047;

		/// <summary>
		/// Value of GL_LUMINANCE16_ALPHA16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_LUMINANCE16_ALPHA16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LUMINANCE16_ALPHA16 = 0x8048;

		/// <summary>
		/// <para>
		/// Gl.TexImage1D: each element is a single intensity value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is then 
		/// multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] 
		/// (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: each element is a single intensity value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is then 
		/// multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] 
		/// (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: each element is a single intensity value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the intensity value three times for red, green, blue, and alpha. Each component is then 
		/// multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] 
		/// (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[AliasOf("GL_INTENSITY_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY = 0x8049;

		/// <summary>
		/// Value of GL_INTENSITY4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY4_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY4 = 0x804A;

		/// <summary>
		/// Value of GL_INTENSITY8 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY8_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY8 = 0x804B;

		/// <summary>
		/// Value of GL_INTENSITY12 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY12_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTENSITY12 = 0x804C;

		/// <summary>
		/// Value of GL_INTENSITY16 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_INTENSITY16_EXT")]
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE0 = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_PLANE1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE1 = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_PLANE2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE2 = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_PLANE3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE3 = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_PLANE4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE4 = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_PLANE5 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIP_PLANE5 = 0x3005;

		/// <summary>
		/// Value of GL_LIGHT0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT0 = 0x4000;

		/// <summary>
		/// Value of GL_LIGHT1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT1 = 0x4001;

		/// <summary>
		/// Value of GL_LIGHT2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT2 = 0x4002;

		/// <summary>
		/// Value of GL_LIGHT3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT3 = 0x4003;

		/// <summary>
		/// Value of GL_LIGHT4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT4 = 0x4004;

		/// <summary>
		/// Value of GL_LIGHT5 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT5 = 0x4005;

		/// <summary>
		/// Value of GL_LIGHT6 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT6 = 0x4006;

		/// <summary>
		/// Value of GL_LIGHT7 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT7 = 0x4007;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void DrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawArrays != null, "pglDrawArrays not implemented");
			Delegates.pglDrawArrays((Int32)mode, first, count);
			CallLog("glDrawArrays({0}, {1}, {2})", mode, first, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void DrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawElements != null, "pglDrawElements not implemented");
			Delegates.pglDrawElements((Int32)mode, count, (Int32)type, indices);
			CallLog("glDrawElements({0}, {1}, {2}, {3})", mode, count, type, indices);
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void DrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices)
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
		/// Specifies the pointer to be returned. Must be one of Gl.DEBUG_CALLBACK_FUNCTION or Gl.DEBUG_CALLBACK_USER_PARAM.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPointer(GetPointervPName pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetPointerv != null, "pglGetPointerv not implemented");
					Delegates.pglGetPointerv((Int32)pname, p_params);
					CallLog("glGetPointerv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the address of the specified pointer
		/// </summary>
		/// <param name="pname">
		/// Specifies the pointer to be returned. Must be one of Gl.DEBUG_CALLBACK_FUNCTION or Gl.DEBUG_CALLBACK_USER_PARAM.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DebugMessageCallback"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_KHR_debug")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPointer(GetPointervPName pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetPointer(pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
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
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_1")]
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
		/// Specifies the target texture. Must be Gl.TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: Gl.COMPRESSED_RED, 
		/// Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, Gl.COMPRESSED_SRGB_ALPHA. 
		/// Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.STENCIL_INDEX8, Gl.RED, Gl.RG, 
		/// Gl.RGB, Gl.R3_G3_B2, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
		/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the left corner of the row of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image. The height of the texture image is 1.
		/// </param>
		/// <param name="border">
		/// Must be 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalformat"/> is not an allowable value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32 and there is no depth buffer.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void CopyTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage1D != null, "pglCopyTexImage1D not implemented");
			Delegates.pglCopyTexImage1D((Int32)target, level, internalformat, x, y, width, border);
			CallLog("glCopyTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels into a 2D texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format of the texture. Must be one of the following symbolic constants: Gl.COMPRESSED_RED, 
		/// Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, Gl.COMPRESSED_SRGB_ALPHA. 
		/// Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.STENCIL_INDEX8, Gl.RED, Gl.RG, 
		/// Gl.RGB, Gl.R3_G3_B2, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
		/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image.
		/// </param>
		/// <param name="border">
		/// Must be 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁢max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalformat"/> is not an accepted format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32 and there is no depth buffer.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void CopyTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage2D != null, "pglCopyTexImage2D not implemented");
			Delegates.pglCopyTexImage2D((Int32)target, level, internalformat, x, y, width, height, border);
			CallLog("glCopyTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.CopyTexSubImage1D function. Must be Gl.TEXTURE_1D.
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CopyTexSubImage1D if <paramref name="target"/> is not Gl.TEXTURE_1D.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_FRAMEBUFFER_OPERATION is generated if the object bound to Gl.READ_FRAMEBUFFER_BINDING is not framebuffer 
		/// complete.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyTextureSubImage1D if <paramref name="texture"/> is not the name of an 
		/// existing texture object, or if the effective target of <paramref name="texture"/> is not Gl.TEXTURE_1D.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D, 
		/// glCopyTexImage1D, or glTexStorage1D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if level&gt;log2⁡max, where max is the returned value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;0, or xoffset+width&gt;w, where w is the Gl.TEXTURE_WIDTH of the texture 
		/// image being modified.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if:
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// the read buffer is Gl.NONE, orthe value of Gl.READ_FRAMEBUFFER_BINDING is non-zero, and:the read buffer selects an 
		/// attachment that has no image attached, orthe effective value of Gl.SAMPLE_BUFFERS for the read framebuffer is one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void CopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage1D != null, "pglCopyTexSubImage1D not implemented");
			Delegates.pglCopyTexSubImage1D((Int32)target, level, xoffset, x, y, width);
			CallLog("glCopyTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for Gl.CopyTexSubImage2D function. Must be 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_RECTANGLE.
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.TEXTURE_1D_ARRAY, or Gl.RECTANGLE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_FRAMEBUFFER_OPERATION is generated if the object bound to Gl.READ_FRAMEBUFFER_BINDING is not framebuffer 
		/// complete.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D, glTexStorage2D 
		/// or glCopyTexImage2D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyTextureSubImage2D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyTextureSubImage2D if the effective target of texture does not correspond to 
		/// one of the texture targets supported by the function.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the effective target is Gl.TEXTURE_RECTANGLE and <paramref name="level"/> is not zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if level&gt;log2⁡max, where max is the returned value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;0, xoffset+width&gt;w, yoffset&lt;0, or yoffset+height&gt;0,, where w is the 
		/// Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT and of the texture image being modified.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if:
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// the read buffer is Gl.NONE, orthe value of Gl.READ_FRAMEBUFFER_BINDING is non-zero, and:the read buffer selects an 
		/// attachment that has no image attached, orthe effective value of Gl.SAMPLE_BUFFERS for the read framebuffer is one.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void CopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage2D != null, "pglCopyTexSubImage2D not implemented");
			Delegates.pglCopyTexSubImage2D((Int32)target, level, xoffset, yoffset, x, y, width, height);
			CallLog("glCopyTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage1D. Must be Gl.TEXTURE_1D.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage1D != null, "pglTexSubImage1D not implemented");
			Delegates.pglTexSubImage1D((Int32)target, level, xoffset, width, (Int32)format, (Int32)type, pixels);
			CallLog("glTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage1D. Must be Gl.TEXTURE_1D.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, Object pixels)
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
		/// Specifies the target to which the texture is bound for Gl.TexSubImage2D. Must be Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexSubImage2D != null, "pglTexSubImage2D not implemented");
			Delegates.pglTexSubImage2D((Int32)target, level, xoffset, yoffset, width, height, (Int32)format, (Int32)type, pixels);
			CallLog("glTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexSubImage2D. Must be Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
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
		/// Specifies the target to which the texture is bound. Must be one of Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, 
		/// Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_BUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of a texture.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is not a name returned from a previous call to glGenTextures.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> was previously created with a target that doesn't match 
		/// that of <paramref name="target"/>.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void BindTexture(TextureTarget target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTexture != null, "pglBindTexture not implemented");
			Delegates.pglBindTexture((Int32)target, texture);
			CallLog("glBindTexture({0}, {1})", target, texture);
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
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void DeleteTextures(params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTextures != null, "pglDeleteTextures not implemented");
					Delegates.pglDeleteTextures((Int32)textures.Length, p_textures);
					CallLog("glDeleteTextures({0}, {1})", textures.Length, textures);
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
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static void GenTextures(UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTextures != null, "pglGenTextures not implemented");
					Delegates.pglGenTextures((Int32)textures.Length, p_textures);
					CallLog("glGenTextures({0}, {1})", textures.Length, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate texture names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
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
		[RequiredByFeature("GL_VERSION_1_1")]
		public static UInt32 GenTexture()
		{
			UInt32[] retValue = new UInt32[1];
			GenTextures(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a texture
		/// </summary>
		/// <param name="texture">
		/// Specifies a value that may be the name of a texture.
		/// </param>
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
		[RequiredByFeature("GL_VERSION_1_1")]
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
		/// render a vertex using the specified vertex array element
		/// </summary>
		/// <param name="i">
		/// Specifies an index into the enabled vertex data arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="i"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ArrayElement(Int32 i)
		{
			Debug.Assert(Delegates.pglArrayElement != null, "pglArrayElement not implemented");
			Delegates.pglArrayElement(i);
			CallLog("glArrayElement({0})", i);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3 or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglColorPointer != null, "pglColorPointer not implemented");
			Delegates.pglColorPointer(size, (Int32)type, stride, pointer);
			CallLog("glColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3 or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// enable or disable client-side capability
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.EnableClientState is not allowed between the execution of Gl\.Begin and the corresponding Gl\.End, but an error may 
		/// or may not be generated. If no error is generated, the behavior is undefined.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DisableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglDisableClientState != null, "pglDisableClientState not implemented");
			Delegates.pglDisableClientState((Int32)array);
			CallLog("glDisableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of edge flags
		/// </summary>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive edge flags. If <paramref name="stride"/> is 0, the edge flags are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first edge flag in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlagPointer(Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglEdgeFlagPointer != null, "pglEdgeFlagPointer not implemented");
			Delegates.pglEdgeFlagPointer(stride, pointer);
			CallLog("glEdgeFlagPointer({0}, {1})", stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of edge flags
		/// </summary>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive edge flags. If <paramref name="stride"/> is 0, the edge flags are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first edge flag in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
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
		/// enable or disable client-side capability
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.EnableClientState is not allowed between the execution of Gl\.Begin and the corresponding Gl\.End, but an error may 
		/// or may not be generated. If no error is generated, the behavior is undefined.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EnableClientState(EnableCap array)
		{
			Debug.Assert(Delegates.pglEnableClientState != null, "pglEnableClientState not implemented");
			Delegates.pglEnableClientState((Int32)array);
			CallLog("glEnableClientState({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of color indexes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each color index in the array. Symbolic constants Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.INT, 
		/// Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive color indexes. If <paramref name="stride"/> is 0, the color indexes are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first index in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglIndexPointer != null, "pglIndexPointer not implemented");
			Delegates.pglIndexPointer((Int32)type, stride, pointer);
			CallLog("glIndexPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of color indexes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each color index in the array. Symbolic constants Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.INT, 
		/// Gl.FLOAT, and Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive color indexes. If <paramref name="stride"/> is 0, the color indexes are 
		/// understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first index in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexPointer(IndexPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				IndexPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// simultaneously specify and enable several interleaved arrays
		/// </summary>
		/// <param name="format">
		/// Specifies the type of array to enable. Symbolic constants Gl.V2F, Gl.V3F, Gl.C4UB_V2F, Gl.C4UB_V3F, Gl.C3F_V3F, 
		/// Gl.N3F_V3F, Gl.C4F_N3F_V3F, Gl.T2F_V3F, Gl.T4F_V4F, Gl.T2F_C4UB_V3F, Gl.T2F_C3F_V3F, Gl.T2F_N3F_V3F, Gl.T2F_C4F_N3F_V3F, 
		/// and Gl.T4F_C4F_N3F_V4F are accepted.
		/// </param>
		/// <param name="stride">
		/// Specifies the offset in bytes between each aggregate array element.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglInterleavedArrays != null, "pglInterleavedArrays not implemented");
			Delegates.pglInterleavedArrays((Int32)format, stride, pointer);
			CallLog("glInterleavedArrays({0}, {1}, {2})", format, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// simultaneously specify and enable several interleaved arrays
		/// </summary>
		/// <param name="format">
		/// Specifies the type of array to enable. Symbolic constants Gl.V2F, Gl.V3F, Gl.C4UB_V2F, Gl.C4UB_V3F, Gl.C3F_V3F, 
		/// Gl.N3F_V3F, Gl.C4F_N3F_V3F, Gl.T2F_V3F, Gl.T4F_V4F, Gl.T2F_C4UB_V3F, Gl.T2F_C3F_V3F, Gl.T2F_N3F_V3F, Gl.T2F_C4F_N3F_V3F, 
		/// and Gl.T4F_C4F_N3F_V4F are accepted.
		/// </param>
		/// <param name="stride">
		/// Specifies the offset in bytes between each aggregate array element.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.GetPointerv"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InterleavedArrays(InterleavedArrayFormat format, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				InterleavedArrays(format, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of normals
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.BYTE, Gl.SHORT, Gl.INT, Gl.FLOAT, and 
		/// Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive normals. If <paramref name="stride"/> is 0, the normals are understood to 
		/// be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglNormalPointer != null, "pglNormalPointer not implemented");
			Delegates.pglNormalPointer((Int32)type, stride, pointer);
			CallLog("glNormalPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of normals
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.BYTE, Gl.SHORT, Gl.INT, Gl.FLOAT, and 
		/// Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive normals. If <paramref name="stride"/> is 0, the normals are understood to 
		/// be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NormalPointer(NormalPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				NormalPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of texture coordinates
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each texture coordinate. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive texture coordinate sets. If <paramref name="stride"/> is 0, the array 
		/// elements are understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTexCoordPointer != null, "pglTexCoordPointer not implemented");
			Delegates.pglTexCoordPointer(size, (Int32)type, stride, pointer);
			CallLog("glTexCoordPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of texture coordinates
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each texture coordinate. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive texture coordinate sets. If <paramref name="stride"/> is 0, the array 
		/// elements are understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TexCoordPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of vertex data
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive vertices. If <paramref name="stride"/> is 0, the vertices are understood 
		/// to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 2, 3, or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexPointer != null, "pglVertexPointer not implemented");
			Delegates.pglVertexPointer(size, (Int32)type, stride, pointer);
			CallLog("glVertexPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of vertex data
		/// </summary>
		/// <param name="size">
		/// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each coordinate in the array. Symbolic constants Gl.SHORT, Gl.INT, Gl.FLOAT, or Gl.DOUBLE are 
		/// accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive vertices. If <paramref name="stride"/> is 0, the vertices are understood 
		/// to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 2, 3, or 4.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// determine if textures are loaded in texture memory
		/// </summary>
		/// <param name="n">
		/// Specifies the number of textures to be queried.
		/// </param>
		/// <param name="textures">
		/// Specifies an array containing the names of the textures to be queried.
		/// </param>
		/// <param name="residences">
		/// Specifies an array in which the texture residence status is returned. The residence status of a texture named by an 
		/// element of <paramref name="textures"/> is returned in the corresponding element of <paramref name="residences"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any element in <paramref name="textures"/> is 0 or does not name a texture. In that 
		/// case, the function returns Gl.FALSE and the contents of <paramref name="residences"/> is indeterminate.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.AreTexturesResident is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static bool AreTexturesResident(UInt32[] textures, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResident != null, "pglAreTexturesResident not implemented");
					retValue = Delegates.pglAreTexturesResident((Int32)textures.Length, p_textures, p_residences);
					CallLog("glAreTexturesResident({0}, {1}, {2}) = {3}", textures.Length, textures, residences, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// set texture residence priority
		/// </summary>
		/// <param name="n">
		/// Specifies the number of textures to be prioritized.
		/// </param>
		/// <param name="textures">
		/// Specifies an array containing the names of the textures to be prioritized.
		/// </param>
		/// <param name="priorities">
		/// Specifies an array containing the texture priorities. A priority given in an element of <paramref name="priorities"/> 
		/// applies to the texture named by the corresponding element of <paramref name="textures"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.PrioritizeTextures is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AreTexturesResident"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PrioritizeTextures(UInt32[] textures, params float[] priorities)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (float* p_priorities = priorities)
				{
					Debug.Assert(Delegates.pglPrioritizeTextures != null, "pglPrioritizeTextures not implemented");
					Delegates.pglPrioritizeTextures((Int32)textures.Length, p_textures, p_priorities);
					CallLog("glPrioritizeTextures({0}, {1}, {2})", textures.Length, textures, priorities);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(byte c)
		{
			Debug.Assert(Delegates.pglIndexub != null, "pglIndexub not implemented");
			Delegates.pglIndexub(c);
			CallLog("glIndexub({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
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
		/// push and pop the client attribute stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushClientAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopClientAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopClientAttrib()
		{
			Debug.Assert(Delegates.pglPopClientAttrib != null, "pglPopClientAttrib not implemented");
			Delegates.pglPopClientAttrib();
			CallLog("glPopClientAttrib()");
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the client attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushClientAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopClientAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushClientAttrib(ClientAttribMask mask)
		{
			Debug.Assert(Delegates.pglPushClientAttrib != null, "pglPushClientAttrib not implemented");
			Delegates.pglPushClientAttrib((UInt32)mask);
			CallLog("glPushClientAttrib({0})", mask);
			DebugCheckErrors();
		}

	}

}
