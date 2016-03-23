
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
		/// Gl.Get: data returns one value, a symbolic constant indicating whether the RGB blend equation is Gl.FUNC_ADD, 
		/// Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN or Gl.MAX. See Gl.BlendEquationSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_RGB_EXT")]
		[AliasOf("GL_BLEND_EQUATION_RGB_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
		public const int BLEND_EQUATION_RGB = 0x8009;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if the vertex attribute array for index is 
		/// enabled and 0 (false) if it is disabled. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value, the size of the vertex attribute array for index. The size is the 
		/// number of values for each element of the vertex attribute array, and it will be 1, 2, 3, or 4. The initial value is 4.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value, the array stride for (number of bytes between successive elements in) 
		/// the vertex attribute array for index. A value of 0 indicates that the array elements are stored sequentially in memory. 
		/// The initial value is 0.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value, a symbolic constant indicating the array type for the vertex 
		/// attribute array for index. Possible values are Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.UNSIGNED_SHORT, Gl.INT, 
		/// Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE. The initial value is Gl.FLOAT.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns four values that represent the current value for the generic vertex attribute 
		/// specified by index. Generic vertex attribute 0 is unique in that it has no current state, so an error will be generated 
		/// if index is 0. The initial value for all other generic vertex attributes is (0,0,0,1).glGetVertexAttribdv and 
		/// glGetVertexAttribfv return the current attribute values as four single-precision floating-point values; 
		/// glGetVertexAttribiv reads them as floating-point values and converts them to four integer values; glGetVertexAttribIiv 
		/// and glGetVertexAttribIuiv read and return them as signed or unsigned integer values, respectively; glGetVertexAttribLdv 
		/// reads and returns them as four double-precision floating-point values.
		/// </summary>
		[AliasOf("GL_CURRENT_VERTEX_ATTRIB_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int CURRENT_VERTEX_ATTRIB = 0x8626;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether vertex program point size mode is enabled. If enabled, 
		/// and a vertex shader is active, then the point size is taken from the shader built-in gl_PointSize. If disabled, and a 
		/// vertex shader is active, then the point size is taken from the point state as specified by Gl.PointSize. The initial 
		/// value is Gl.FALSE.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and a vertex shader is active, then the derived point size is taken from the (potentially clipped) 
		/// shader builtin Gl.PointSize and clamped to the implementation-dependent point size range.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_POINTER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what function is used for back-facing polygons to compare 
		/// the stencil reference value with the stencil buffer value. The initial value is Gl.ALWAYS. See Gl.StencilFuncSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FUNC_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FUNC = 0x8800;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the 
		/// stencil test fails. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FAIL = 0x8801;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the 
		/// stencil test passes, but the depth test fails. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the 
		/// stencil test passes and the depth test passes. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of simultaneous outputs that may be written in a fragment shader. The 
		/// value must be at least 8. See Gl.DrawBuffers.
		/// </summary>
		[AliasOf("GL_MAX_DRAW_BUFFERS_ARB")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_ATI")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_EXT")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int MAX_DRAW_BUFFERS = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER0_ARB")]
		[AliasOf("GL_DRAW_BUFFER0_ATI")]
		[AliasOf("GL_DRAW_BUFFER0_EXT")]
		[AliasOf("GL_DRAW_BUFFER0_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER0 = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER1_ARB")]
		[AliasOf("GL_DRAW_BUFFER1_ATI")]
		[AliasOf("GL_DRAW_BUFFER1_EXT")]
		[AliasOf("GL_DRAW_BUFFER1_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER1 = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER2_ARB")]
		[AliasOf("GL_DRAW_BUFFER2_ATI")]
		[AliasOf("GL_DRAW_BUFFER2_EXT")]
		[AliasOf("GL_DRAW_BUFFER2_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER2 = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER3_ARB")]
		[AliasOf("GL_DRAW_BUFFER3_ATI")]
		[AliasOf("GL_DRAW_BUFFER3_EXT")]
		[AliasOf("GL_DRAW_BUFFER3_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER3 = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER4_ARB")]
		[AliasOf("GL_DRAW_BUFFER4_ATI")]
		[AliasOf("GL_DRAW_BUFFER4_EXT")]
		[AliasOf("GL_DRAW_BUFFER4_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER4 = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER5_ARB")]
		[AliasOf("GL_DRAW_BUFFER5_ATI")]
		[AliasOf("GL_DRAW_BUFFER5_EXT")]
		[AliasOf("GL_DRAW_BUFFER5_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER5 = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER6_ARB")]
		[AliasOf("GL_DRAW_BUFFER6_ATI")]
		[AliasOf("GL_DRAW_BUFFER6_EXT")]
		[AliasOf("GL_DRAW_BUFFER6_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER6 = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER7_ARB")]
		[AliasOf("GL_DRAW_BUFFER7_ATI")]
		[AliasOf("GL_DRAW_BUFFER7_EXT")]
		[AliasOf("GL_DRAW_BUFFER7_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER7 = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER8_ARB")]
		[AliasOf("GL_DRAW_BUFFER8_ATI")]
		[AliasOf("GL_DRAW_BUFFER8_EXT")]
		[AliasOf("GL_DRAW_BUFFER8_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER8 = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER9_ARB")]
		[AliasOf("GL_DRAW_BUFFER9_ATI")]
		[AliasOf("GL_DRAW_BUFFER9_EXT")]
		[AliasOf("GL_DRAW_BUFFER9_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER9 = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER10_ARB")]
		[AliasOf("GL_DRAW_BUFFER10_ATI")]
		[AliasOf("GL_DRAW_BUFFER10_EXT")]
		[AliasOf("GL_DRAW_BUFFER10_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER10 = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER11_ARB")]
		[AliasOf("GL_DRAW_BUFFER11_ATI")]
		[AliasOf("GL_DRAW_BUFFER11_EXT")]
		[AliasOf("GL_DRAW_BUFFER11_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER11 = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER12_ARB")]
		[AliasOf("GL_DRAW_BUFFER12_ATI")]
		[AliasOf("GL_DRAW_BUFFER12_EXT")]
		[AliasOf("GL_DRAW_BUFFER12_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER12 = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER13_ARB")]
		[AliasOf("GL_DRAW_BUFFER13_ATI")]
		[AliasOf("GL_DRAW_BUFFER13_EXT")]
		[AliasOf("GL_DRAW_BUFFER13_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER13 = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER14_ARB")]
		[AliasOf("GL_DRAW_BUFFER14_ATI")]
		[AliasOf("GL_DRAW_BUFFER14_EXT")]
		[AliasOf("GL_DRAW_BUFFER14_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER14 = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER15_ARB")]
		[AliasOf("GL_DRAW_BUFFER15_ATI")]
		[AliasOf("GL_DRAW_BUFFER15_EXT")]
		[AliasOf("GL_DRAW_BUFFER15_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER15 = 0x8834;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating whether the Alpha blend equation is Gl.FUNC_ADD, 
		/// Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN or Gl.MAX. See Gl.BlendEquationSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_ALPHA_EXT")]
		[AliasOf("GL_BLEND_EQUATION_ALPHA_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
		public const int BLEND_EQUATION_ALPHA = 0x883D;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of 4-component generic vertex attributes accessible to a vertex 
		/// shader. The value must be at least 16. See Gl.VertexAttrib.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_ATTRIBS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_ATTRIBS = 0x8869;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if fixed-point data types for the vertex 
		/// attribute array indicated by index are normalized when they are converted to floating point, and 0 (false) otherwise. 
		/// The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps from 
		/// the fragment shader. The value must be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER symbol.
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		public const int FRAGMENT_SHADER = 0x8B30;

		/// <summary>
		/// Value of GL_VERTEX_SHADER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_SHADER = 0x8B31;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that can be 
		/// held in uniform variable storage for a fragment shader. The value must be at least 1024. See Gl.Uniform.
		/// </summary>
		[AliasOf("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that can be 
		/// held in uniform variable storage for a vertex shader. The value must be at least 1024. See Gl.Uniform.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of interpolators available for processing varying variables used by 
		/// vertex and fragment shaders. This value represents the number of individual floating-point values that can be 
		/// interpolated; varying variables declared as vectors, matrices, and arrays will all consume multiple interpolators. The 
		/// value must be at least 32.
		/// </summary>
		[AliasOf("GL_MAX_VARYING_FLOATS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VARYING_FLOATS = 0x8B4B;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps from 
		/// the vertex shader. The value may be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program3")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps from 
		/// the vertex shader and the fragment processor combined. If both the vertex shader and the fragment processing stage 
		/// access the same texture image unit, then that counts as using two texture image units against this limit. The value must 
		/// be at least 48. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

		/// <summary>
		/// Gl.GetShader: params returns Gl.VERTEX_SHADER if shader is a vertex shader object, Gl.GEOMETRY_SHADER if shader is a 
		/// geometry shader object, and Gl.FRAGMENT_SHADER if shader is a fragment shader object.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int SHADER_TYPE = 0x8B4F;

		/// <summary>
		/// Value of GL_FLOAT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC2 = 0x8B50;

		/// <summary>
		/// Value of GL_FLOAT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC3 = 0x8B51;

		/// <summary>
		/// Value of GL_FLOAT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC4 = 0x8B52;

		/// <summary>
		/// Value of GL_INT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC2 = 0x8B53;

		/// <summary>
		/// Value of GL_INT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC3 = 0x8B54;

		/// <summary>
		/// Value of GL_INT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC4 = 0x8B55;

		/// <summary>
		/// Value of GL_BOOL symbol.
		/// </summary>
		[AliasOf("GL_BOOL_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL = 0x8B56;

		/// <summary>
		/// Value of GL_BOOL_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC2 = 0x8B57;

		/// <summary>
		/// Value of GL_BOOL_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC3 = 0x8B58;

		/// <summary>
		/// Value of GL_BOOL_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC4 = 0x8B59;

		/// <summary>
		/// Value of GL_FLOAT_MAT2 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT2 = 0x8B5A;

		/// <summary>
		/// Value of GL_FLOAT_MAT3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT3 = 0x8B5B;

		/// <summary>
		/// Value of GL_FLOAT_MAT4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT4 = 0x8B5C;

		/// <summary>
		/// Value of GL_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D = 0x8B5D;

		/// <summary>
		/// Value of GL_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D = 0x8B5E;

		/// <summary>
		/// Value of GL_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_3D_ARB")]
		[AliasOf("GL_SAMPLER_3D_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int SAMPLER_3D = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_CUBE = 0x8B60;

		/// <summary>
		/// Value of GL_SAMPLER_1D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D_SHADOW = 0x8B61;

		/// <summary>
		/// Value of GL_SAMPLER_2D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_SHADOW_ARB")]
		[AliasOf("GL_SAMPLER_2D_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		public const int SAMPLER_2D_SHADOW = 0x8B62;

		/// <summary>
		/// <para>
		/// Gl.GetProgram: params returns Gl.TRUE if program is currently flagged for deletion, and Gl.FALSE otherwise.
		/// </para>
		/// <para>
		/// Gl.GetShader: params returns Gl.TRUE if shader is currently flagged for deletion, and Gl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DELETE_STATUS = 0x8B80;

		/// <summary>
		/// Gl.GetShader: params returns Gl.TRUE if the last compile operation on shader was successful, and Gl.FALSE otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int COMPILE_STATUS = 0x8B81;

		/// <summary>
		/// Gl.GetProgram: params returns Gl.TRUE if the last link operation on program was successful, and Gl.FALSE otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINK_STATUS = 0x8B82;

		/// <summary>
		/// Gl.GetProgram: params returns Gl.TRUE or if the last validation operation on program was successful, and Gl.FALSE 
		/// otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int VALIDATE_STATUS = 0x8B83;

		/// <summary>
		/// <para>
		/// Gl.GetProgram: params returns the number of characters in the information log for program including the null termination 
		/// character (i.e., the size of the character buffer required to store the information log). If program has no information 
		/// log, a value of 0 is returned.
		/// </para>
		/// <para>
		/// Gl.GetShader: params returns the number of characters in the information log for shader including the null termination 
		/// character (i.e., the size of the character buffer required to store the information log). If shader has no information 
		/// log, a value of 0 is returned.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INFO_LOG_LENGTH = 0x8B84;

		/// <summary>
		/// Gl.GetProgram: params returns the number of shader objects attached to program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ATTACHED_SHADERS = 0x8B85;

		/// <summary>
		/// Gl.GetProgram: params returns the number of active uniform variables for program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_UNIFORMS = 0x8B86;

		/// <summary>
		/// Gl.GetProgram: params returns the length of the longest active uniform variable name for program, including the null 
		/// termination character (i.e., the size of the character buffer required to store the longest uniform variable name). If 
		/// no active uniform variables exist, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;

		/// <summary>
		/// Gl.GetShader: params returns the length of the concatenation of the source strings that make up the shader source for 
		/// the shader, including the null termination character. (i.e., the size of the character buffer required to store the 
		/// shader source). If no source code exists, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int SHADER_SOURCE_LENGTH = 0x8B88;

		/// <summary>
		/// Gl.GetProgram: params returns the number of active attribute variables for program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_ATTRIBUTES = 0x8B89;

		/// <summary>
		/// Gl.GetProgram: params returns the length of the longest active attribute name for program, including the null 
		/// termination character (i.e., the size of the character buffer required to store the longest attribute name). If no 
		/// active attributes exist, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating the mode of the derivative accuracy hint for fragment 
		/// shaders. The initial value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the accuracy of the derivative calculation for the GL shading language fragment processing built-in 
		/// functions: Gl.x, Gl.y, and Gl.dth.
		/// </para>
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
		[AliasOf("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		[RequiredByFeature("GL_OES_standard_derivatives", Api = "gles2")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

		/// <summary>
		/// Gl.GetString: returns a version or release number for the shading language.
		/// </summary>
		[AliasOf("GL_SHADING_LANGUAGE_VERSION_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shading_language_100")]
		public const int SHADING_LANGUAGE_VERSION = 0x8B8C;

		/// <summary>
		/// Gl.Get: data returns one value, the name of the program object that is currently active, or 0 if no program object is 
		/// active. See Gl.UseProgram.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int CURRENT_PROGRAM = 0x8B8D;

		/// <summary>
		/// Gl.PointParameter: params is a single enum specifying the point sprite texture coordinate origin, either Gl.LOWER_LEFT 
		/// or Gl.UPPER_LEFT. The default value is Gl.UPPER_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

		/// <summary>
		/// Value of GL_LOWER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int LOWER_LEFT = 0x8CA1;

		/// <summary>
		/// Value of GL_UPPER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int UPPER_LEFT = 0x8CA2;

		/// <summary>
		/// Gl.Get: data returns one value, the reference value that is compared with the contents of the stencil buffer for 
		/// back-facing polygons. The initial value is 0. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_BACK_REF = 0x8CA3;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that is used for back-facing polygons to mask both the stencil reference value 
		/// and the stencil buffer value before they are compared. The initial value is all 1's. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that controls writing of the stencil bitplanes for back-facing polygons. The 
		/// initial value is all 1's. See Gl.StencilMaskSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_BACK_WRITEMASK = 0x8CA5;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether vertex program two-sided color mode is enabled. If 
		/// enabled, and a vertex shader is active, then the GL chooses the back color output for back-facing polygons, and the 
		/// front color output for non-polygons and front-facing polygons. If disabled, and a vertex shader is active, then the 
		/// front color output is always selected. The initial value is Gl.FALSE.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and a vertex shader is active, it specifies that the GL will choose between front and back colors 
		/// based on the polygon's face direction of which the vertex being shaded is a part. It has no effect on points or lines.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_PROGRAM_TWO_SIDE = 0x8643;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether point sprite is enabled. The initial value is Gl.FALSE.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled, calculate texture coordinates for points based on texture environment and point parameter 
		/// settings. Otherwise texture coordinates are constant across points.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_SPRITE_ARB")]
		[AliasOf("GL_POINT_SPRITE_NV")]
		[AliasOf("GL_POINT_SPRITE_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_point_sprite")]
		[RequiredByFeature("GL_NV_point_sprite")]
		[RequiredByFeature("GL_OES_point_sprite", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SPRITE = 0x8861;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single boolean value representing the current point sprite texture coordinate replacement 
		/// enable state. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_COORD_REPLACE_ARB")]
		[AliasOf("GL_COORD_REPLACE_NV")]
		[AliasOf("GL_COORD_REPLACE_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_point_sprite")]
		[RequiredByFeature("GL_NV_point_sprite")]
		[RequiredByFeature("GL_OES_point_sprite", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COORD_REPLACE = 0x8862;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum number of texture coordinate sets available to vertex and fragment 
		/// shaders. The value must be at least 2. See Gl.ActiveTexture and Gl.ClientActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_COORDS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_COORDS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_fragment_program")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_TEXTURE_COORDS = 0x8871;

		/// <summary>
		/// set the RGB blend equation and the alpha blend equation separately
		/// </summary>
		/// <param name="modeRGB">
		/// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are 
		/// combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <param name="modeAlpha">
		/// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must 
		/// be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="modeRGB"/> or <paramref name="modeAlpha"/> is not one of 
		/// Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MAX, or Gl.MIN.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.BlendEquationSeparatei if <paramref name="buf"/> is greater than or equal to the 
		/// value of Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		[AliasOf("glBlendEquationSeparateEXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparate != null, "pglBlendEquationSeparate not implemented");
			Delegates.pglBlendEquationSeparate((Int32)modeRGB, (Int32)modeAlpha);
			LogFunction("glBlendEquationSeparate({0}, {1})", modeRGB, modeAlpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies a list of color buffers to be drawn into
		/// </summary>
		/// <param name="bufs">
		/// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be 
		/// written.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffers if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if one of the values in <paramref name="bufs"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the API call refers to the default framebuffer and one or more of the values in 
		/// <paramref name="bufs"/> is one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if the API call refers to a framebuffer object and one or more of the values in <paramref 
		/// name="bufs"/> is anything other than Gl.NONE or one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="n"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a symbolic constant other than Gl.NONE appears more than once in <paramref 
		/// name="bufs"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any of the entries in <paramref name="bufs"/> (other than Gl.NONE ) indicates a 
		/// color buffer that does not exist in the current GL context.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="bufs"/> is Gl.BACK, and <paramref name="n"/> is not 
		/// one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is greater than Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[AliasOf("glDrawBuffersARB")]
		[AliasOf("glDrawBuffersATI")]
		[AliasOf("glDrawBuffersEXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		public static void DrawBuffers(params Int32[] bufs)
		{
			unsafe {
				fixed (Int32* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffers != null, "pglDrawBuffers not implemented");
					Delegates.pglDrawBuffers((Int32)bufs.Length, p_bufs);
					LogFunction("glDrawBuffers({0}, {1})", bufs.Length, LogEnumName(bufs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and/or back stencil test actions
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO, 
		/// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. <paramref name="dpfail"/> accepts 
		/// the same symbolic constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. <paramref name="dppass"/> accepts the same symbolic 
		/// constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> is any value other than Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="sfail"/>, <paramref name="dpfail"/>, or <paramref name="dppass"/> is any 
		/// value other than the eight defined constant values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		[AliasOf("glStencilOpSeparateATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOpSeparate != null, "pglStencilOpSeparate not implemented");
			Delegates.pglStencilOpSeparate((Int32)face, (Int32)sfail, (Int32)dpfail, (Int32)dppass);
			LogFunction("glStencilOpSeparate({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and/or back function and reference value for stencil testing
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL, 
		/// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value for the stencil test. <paramref name="ref"/> is clamped to the range 02n-1, where n is the 
		/// number of bitplanes in the stencil buffer. The initial value is 0.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not one of the eight accepted values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparate != null, "pglStencilFuncSeparate not implemented");
			Delegates.pglStencilFuncSeparate((Int32)face, (Int32)func, @ref, mask);
			LogFunction("glStencilFuncSeparate({0}, {1}, {2}, {3})", face, func, @ref, mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the front and/or back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="face">
		/// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Gl.FRONT, 
		/// Gl.BACK, and Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMaskSeparate != null, "pglStencilMaskSeparate not implemented");
			Delegates.pglStencilMaskSeparate((Int32)face, mask);
			LogFunction("glStencilMaskSeparate({0}, {1})", face, mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Attaches a shader object to a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to which a shader object will be attached.
		/// </param>
		/// <param name="shader">
		/// Specifies the shader object that is to be attached.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="program"/> or <paramref name="shader"/> is not a value generated 
		/// by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is already attached to <paramref name="program"/>.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glAttachObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void AttachShader(UInt32 program, UInt32 shader)
		{
			Debug.Assert(Delegates.pglAttachShader != null, "pglAttachShader not implemented");
			Delegates.pglAttachShader(program, shader);
			LogFunction("glAttachShader({0}, {1})", program, shader);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Associates a generic vertex attribute index with a named attribute variable
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object in which the association is to be made.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be bound.
		/// </param>
		/// <param name="name">
		/// Specifies a null terminated string containing the name of the vertex shader attribute variable to which <paramref 
		/// name="index"/> is to be bound.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> starts with the reserved prefix "gl_".
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glBindAttribLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void BindAttribLocation(UInt32 program, UInt32 index, String name)
		{
			Debug.Assert(Delegates.pglBindAttribLocation != null, "pglBindAttribLocation not implemented");
			Delegates.pglBindAttribLocation(program, index, name);
			LogFunction("glBindAttribLocation({0}, {1}, {2})", program, index, name);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Compiles a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be compiled.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glCompileShaderARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void CompileShader(UInt32 shader)
		{
			Debug.Assert(Delegates.pglCompileShader != null, "pglCompileShader not implemented");
			Delegates.pglCompileShader(shader);
			LogFunction("glCompileShader({0})", shader);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Creates a program object
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// This function returns 0 if an error occurs creating the program object.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[AliasOf("glCreateProgramObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 CreateProgram()
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateProgram != null, "pglCreateProgram not implemented");
			retValue = Delegates.pglCreateProgram();
			LogFunction("glCreateProgram() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Creates a shader object
		/// </summary>
		/// <param name="shaderType">
		/// Specifies the type of shader to be created. Must be one of Gl.COMPUTE_SHADER, Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, 
		/// Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER, or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// This function returns 0 if an error occurs creating the shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glCreateShaderObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 CreateShader(Int32 shaderType)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShader != null, "pglCreateShader not implemented");
			retValue = Delegates.pglCreateShader(shaderType);
			LogFunction("glCreateShader({0}) = {1}", LogEnumName(shaderType), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Deletes a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DeleteProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglDeleteProgram != null, "pglDeleteProgram not implemented");
			Delegates.pglDeleteProgram(program);
			LogFunction("glDeleteProgram({0})", program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Deletes a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DeleteShader(UInt32 shader)
		{
			Debug.Assert(Delegates.pglDeleteShader != null, "pglDeleteShader not implemented");
			Delegates.pglDeleteShader(shader);
			LogFunction("glDeleteShader({0})", shader);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Detaches a shader object from a program object to which it is attached
		/// </summary>
		/// <param name="program">
		/// Specifies the program object from which to detach the shader object.
		/// </param>
		/// <param name="shader">
		/// Specifies the shader object to be detached.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="program"/> or <paramref name="shader"/> is a value that was not 
		/// generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not attached to <paramref name="program"/>.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		[AliasOf("glDetachObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void DetachShader(UInt32 program, UInt32 shader)
		{
			Debug.Assert(Delegates.pglDetachShader != null, "pglDetachShader not implemented");
			Delegates.pglDetachShader(program, shader);
			LogFunction("glDetachShader({0}, {1})", program, shader);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glDisableVertexAttribArrayARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void DisableVertexAttribArray(UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexAttribArray != null, "pglDisableVertexAttribArray not implemented");
			Delegates.pglDisableVertexAttribArray(index);
			LogFunction("glDisableVertexAttribArray({0})", index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glEnableVertexAttribArrayARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void EnableVertexAttribArray(UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexAttribArray != null, "pglEnableVertexAttribArray not implemented");
			Delegates.pglEnableVertexAttribArray(index);
			LogFunction("glEnableVertexAttribArray({0})", index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns information about an active attribute variable for the specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the attribute variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by <paramref name="name"/> 
		/// (excluding the null terminator) if a value other than Gl.L is passed.
		/// </param>
		/// <param name="size">
		/// Returns the size of the attribute variable.
		/// </param>
		/// <param name="type">
		/// Returns the data type of the attribute variable.
		/// </param>
		/// <param name="name">
		/// Returns a null terminated string containing the name of the attribute variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of active attribute 
		/// variables in <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetActiveAttribARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveAttrib != null, "pglGetActiveAttrib not implemented");
					Delegates.pglGetActiveAttrib(program, index, bufSize, p_length, p_size, p_type, name);
					LogFunction("glGetActiveAttrib({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, LogEnumName(type), name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns information about an active uniform variable for the specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by <paramref name="name"/> 
		/// (excluding the null terminator) if a value other than Gl.L is passed.
		/// </param>
		/// <param name="size">
		/// Returns the size of the uniform variable.
		/// </param>
		/// <param name="type">
		/// Returns the data type of the uniform variable.
		/// </param>
		/// <param name="name">
		/// Returns a null terminated string containing the name of the uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of active uniform 
		/// variables in <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glGetActiveUniformARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveUniform != null, "pglGetActiveUniform not implemented");
					Delegates.pglGetActiveUniform(program, index, bufSize, p_length, p_size, p_type, name);
					LogFunction("glGetActiveUniform({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, LogEnumName(type), name);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the handles of the shader objects attached to a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="count">
		/// Returns the number of names actually returned in <paramref name="shaders"/>.
		/// </param>
		/// <param name="shaders">
		/// Specifies an array that is used to return the names of attached shader objects.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxCount"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetAttachedShaders(UInt32 program, out Int32 count, [Out] UInt32[] shaders)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglGetAttachedShaders != null, "pglGetAttachedShaders not implemented");
					Delegates.pglGetAttachedShaders(program, (Int32)shaders.Length, p_count, p_shaders);
					LogFunction("glGetAttachedShaders({0}, {1}, {2}, {3})", program, shaders.Length, count, LogValue(shaders));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the location of an attribute variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="name">
		/// Points to a null terminated string containing the name of the attribute variable whose location is to be queried.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetAttribLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static Int32 GetAttribLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetAttribLocation != null, "pglGetAttribLocation not implemented");
			retValue = Delegates.pglGetAttribLocation(program, name);
			LogFunction("glGetAttribLocation({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns a parameter from a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.DELETE_STATUS, Gl.LINK_STATUS, Gl.VALIDATE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.ATTACHED_SHADERS, Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS, Gl.ACTIVE_ATTRIBUTES, 
		/// Gl.ACTIVE_ATTRIBUTE_MAX_LENGTH, Gl.ACTIVE_UNIFORMS, Gl.ACTIVE_UNIFORM_BLOCKS, Gl.ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
		/// Gl.ACTIVE_UNIFORM_MAX_LENGTH, Gl.COMPUTE_WORK_GROUP_SIZEGl.PROGRAM_BINARY_LENGTH, Gl.TRANSFORM_FEEDBACK_BUFFER_MODE, 
		/// Gl.TRANSFORM_FEEDBACK_VARYINGS, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, Gl.GEOMETRY_VERTICES_OUT, 
		/// Gl.GEOMETRY_INPUT_TYPE, and Gl.GEOMETRY_OUTPUT_TYPE.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.GEOMETRY_VERTICES_OUT, Gl.GEOMETRY_INPUT_TYPE, or 
		/// Gl.GEOMETRY_OUTPUT_TYPE, and <paramref name="program"/> does not contain a geometry shader.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.COMPUTE_WORK_GROUP_SIZE and <paramref 
		/// name="program"/> does not contain a binary for the compute shader stage.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetProgram(UInt32 program, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramiv != null, "pglGetProgramiv not implemented");
					Delegates.pglGetProgramiv(program, pname, p_params);
					LogFunction("glGetProgramiv({0}, {1}, {2})", program, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns a parameter from a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.DELETE_STATUS, Gl.LINK_STATUS, Gl.VALIDATE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.ATTACHED_SHADERS, Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS, Gl.ACTIVE_ATTRIBUTES, 
		/// Gl.ACTIVE_ATTRIBUTE_MAX_LENGTH, Gl.ACTIVE_UNIFORMS, Gl.ACTIVE_UNIFORM_BLOCKS, Gl.ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
		/// Gl.ACTIVE_UNIFORM_MAX_LENGTH, Gl.COMPUTE_WORK_GROUP_SIZEGl.PROGRAM_BINARY_LENGTH, Gl.TRANSFORM_FEEDBACK_BUFFER_MODE, 
		/// Gl.TRANSFORM_FEEDBACK_VARYINGS, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, Gl.GEOMETRY_VERTICES_OUT, 
		/// Gl.GEOMETRY_INPUT_TYPE, and Gl.GEOMETRY_OUTPUT_TYPE.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.GEOMETRY_VERTICES_OUT, Gl.GEOMETRY_INPUT_TYPE, or 
		/// Gl.GEOMETRY_OUTPUT_TYPE, and <paramref name="program"/> does not contain a geometry shader.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.COMPUTE_WORK_GROUP_SIZE and <paramref 
		/// name="program"/> does not contain a binary for the compute shader stage.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetProgram(UInt32 program, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetProgramiv != null, "pglGetProgramiv not implemented");
					Delegates.pglGetProgramiv(program, pname, p_params);
					LogFunction("glGetProgramiv({0}, {1}, {2})", program, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the information log for a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object whose information log is to be queried.
		/// </param>
		/// <param name="maxLength">
		/// Specifies the size of the character buffer for storing the returned information log.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="infoLog"/> (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxLength"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetProgramInfoLog(UInt32 program, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramInfoLog != null, "pglGetProgramInfoLog not implemented");
					Delegates.pglGetProgramInfoLog(program, maxLength, p_length, infoLog);
					LogFunction("glGetProgramInfoLog({0}, {1}, {2}, {3})", program, maxLength, length, infoLog);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns a parameter from a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.SHADER_TYPE, Gl.DELETE_STATUS, Gl.COMPILE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.SHADER_SOURCE_LENGTH.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> does not refer to a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShader(UInt32 shader, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetShaderiv != null, "pglGetShaderiv not implemented");
					Delegates.pglGetShaderiv(shader, pname, p_params);
					LogFunction("glGetShaderiv({0}, {1}, {2})", shader, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns a parameter from a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.SHADER_TYPE, Gl.DELETE_STATUS, Gl.COMPILE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.SHADER_SOURCE_LENGTH.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> does not refer to a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShader(UInt32 shader, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetShaderiv != null, "pglGetShaderiv not implemented");
					Delegates.pglGetShaderiv(shader, pname, p_params);
					LogFunction("glGetShaderiv({0}, {1}, {2})", shader, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the information log for a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object whose information log is to be queried.
		/// </param>
		/// <param name="maxLength">
		/// Specifies the size of the character buffer for storing the returned information log.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="infoLog"/> (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxLength"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShaderInfoLog(UInt32 shader, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderInfoLog != null, "pglGetShaderInfoLog not implemented");
					Delegates.pglGetShaderInfoLog(shader, maxLength, p_length, infoLog);
					LogFunction("glGetShaderInfoLog({0}, {1}, {2}, {3})", shader, maxLength, length, infoLog);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the source code string from a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the character buffer for storing the returned source code string.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="source"/> (excluding the null terminator).
		/// </param>
		/// <param name="source">
		/// Specifies an array of characters that is used to return the source code string.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glGetShaderSourceARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetShaderSource(UInt32 shader, Int32 bufSize, out Int32 length, [Out] StringBuilder source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderSource != null, "pglGetShaderSource not implemented");
					Delegates.pglGetShaderSource(shader, bufSize, p_length, source);
					LogFunction("glGetShaderSource({0}, {1}, {2}, {3})", shader, bufSize, length, source);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the location of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="name">
		/// Points to a null terminated string containing the name of the uniform variable whose location is to be queried.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static Int32 GetUniformLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetUniformLocation != null, "pglGetUniformLocation not implemented");
			retValue = Delegates.pglGetUniformLocation(program, name);
			LogFunction("glGetUniformLocation({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformfvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformfv != null, "pglGetUniformfv not implemented");
					Delegates.pglGetUniformfv(program, location, p_params);
					LogFunction("glGetUniformfv({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformiv != null, "pglGetUniformiv not implemented");
					Delegates.pglGetUniformiv(program, location, p_params);
					LogFunction("glGetUniformiv({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribdvARB")]
		[AliasOf("glGetVertexAttribdvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribdv != null, "pglGetVertexAttribdv not implemented");
					Delegates.pglGetVertexAttribdv(index, pname, p_params);
					LogFunction("glGetVertexAttribdv({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribfvARB")]
		[AliasOf("glGetVertexAttribfvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribfv != null, "pglGetVertexAttribfv not implemented");
					Delegates.pglGetVertexAttribfv(index, pname, p_params);
					LogFunction("glGetVertexAttribfv({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribivARB")]
		[AliasOf("glGetVertexAttribivNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					LogFunction("glGetVertexAttribiv({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribivARB")]
		[AliasOf("glGetVertexAttribivNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					LogFunction("glGetVertexAttribiv({0}, {1}, {2})", index, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the address of the specified generic vertex attribute pointer
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be returned.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be 
		/// Gl.VERTEX_ATTRIB_ARRAY_POINTER.
		/// </param>
		/// <param name="pointer">
		/// Returns the pointer value.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no vertex array object is currently bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribPointervARB")]
		[AliasOf("glGetVertexAttribPointervNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttribPointer(UInt32 index, Int32 pname, out IntPtr pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = &pointer)
				{
					Debug.Assert(Delegates.pglGetVertexAttribPointerv != null, "pglGetVertexAttribPointerv not implemented");
					Delegates.pglGetVertexAttribPointerv(index, pname, p_pointer);
					LogFunction("glGetVertexAttribPointerv({0}, {1}, 0x{2})", index, LogEnumName(pname), pointer.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the address of the specified generic vertex attribute pointer
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be returned.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be 
		/// Gl.VERTEX_ATTRIB_ARRAY_POINTER.
		/// </param>
		/// <param name="pointer">
		/// Returns the pointer value.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if no vertex array object is currently bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribPointervARB")]
		[AliasOf("glGetVertexAttribPointervNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttribPointer(UInt32 index, Int32 pname, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				GetVertexAttribPointer(index, pname, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Determines if a name corresponds to a program object
		/// </summary>
		/// <param name="program">
		/// Specifies a potential program object.
		/// </param>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsProgram(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgram != null, "pglIsProgram not implemented");
			retValue = Delegates.pglIsProgram(program);
			LogFunction("glIsProgram({0}) = {1}", program, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Determines if a name corresponds to a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies a potential shader object.
		/// </param>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsShader(UInt32 shader)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsShader != null, "pglIsShader not implemented");
			retValue = Delegates.pglIsShader(shader);
			LogFunction("glIsShader({0}) = {1}", shader, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Links a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be linked.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is the currently active program object and transform 
		/// feedback mode is active.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[AliasOf("glLinkProgramARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void LinkProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglLinkProgram != null, "pglLinkProgram not implemented");
			Delegates.pglLinkProgram(program);
			LogFunction("glLinkProgram({0})", program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Replaces the source code in a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the handle of the shader object whose source code is to be replaced.
		/// </param>
		/// <param name="string">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <param name="length">
		/// Specifies an array of string lengths.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		[AliasOf("glShaderSourceARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void ShaderSource(UInt32 shader, String[] @string, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglShaderSource != null, "pglShaderSource not implemented");
					Delegates.pglShaderSource(shader, (Int32)@string.Length, @string, p_length);
					LogFunction("glShaderSource({0}, {1}, {2}, {3})", shader, @string.Length, LogValue(@string), LogValue(length));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Installs a program object as part of current rendering state
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object whose executables are to be used as part of current rendering state.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is neither 0 nor a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> could not be made part of current state.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if transform feedback mode is active.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glUseProgramObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UseProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgram != null, "pglUseProgram not implemented");
			Delegates.pglUseProgram(program);
			LogFunction("glUseProgram({0})", program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, float v0)
		{
			Debug.Assert(Delegates.pglUniform1f != null, "pglUniform1f not implemented");
			Delegates.pglUniform1f(location, v0);
			LogFunction("glUniform1f({0}, {1})", location, v0);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, float v0, float v1)
		{
			Debug.Assert(Delegates.pglUniform2f != null, "pglUniform2f not implemented");
			Delegates.pglUniform2f(location, v0, v1);
			LogFunction("glUniform2f({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, float v0, float v1, float v2)
		{
			Debug.Assert(Delegates.pglUniform3f != null, "pglUniform3f not implemented");
			Delegates.pglUniform3f(location, v0, v1, v2);
			LogFunction("glUniform3f({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, float v0, float v1, float v2, float v3)
		{
			Debug.Assert(Delegates.pglUniform4f != null, "pglUniform4f not implemented");
			Delegates.pglUniform4f(location, v0, v1, v2, v3);
			LogFunction("glUniform4f({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 v0)
		{
			Debug.Assert(Delegates.pglUniform1i != null, "pglUniform1i not implemented");
			Delegates.pglUniform1i(location, v0);
			LogFunction("glUniform1i({0}, {1})", location, v0);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 v0, Int32 v1)
		{
			Debug.Assert(Delegates.pglUniform2i != null, "pglUniform2i not implemented");
			Delegates.pglUniform2i(location, v0, v1);
			LogFunction("glUniform2i({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			Debug.Assert(Delegates.pglUniform3i != null, "pglUniform3i not implemented");
			Delegates.pglUniform3i(location, v0, v1, v2);
			LogFunction("glUniform3i({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			Debug.Assert(Delegates.pglUniform4i != null, "pglUniform4i not implemented");
			Delegates.pglUniform4i(location, v0, v1, v2, v3);
			LogFunction("glUniform4i({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1fv != null, "pglUniform1fv not implemented");
					Delegates.pglUniform1fv(location, count, p_value);
					LogFunction("glUniform1fv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform1(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform1fv != null, "pglUniform1fv not implemented");
			Delegates.pglUniform1fv(location, count, value);
			LogFunction("glUniform1fv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2fv != null, "pglUniform2fv not implemented");
					Delegates.pglUniform2fv(location, count, p_value);
					LogFunction("glUniform2fv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform2(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform2fv != null, "pglUniform2fv not implemented");
			Delegates.pglUniform2fv(location, count, value);
			LogFunction("glUniform2fv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3fv != null, "pglUniform3fv not implemented");
					Delegates.pglUniform3fv(location, count, p_value);
					LogFunction("glUniform3fv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform3(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform3fv != null, "pglUniform3fv not implemented");
			Delegates.pglUniform3fv(location, count, value);
			LogFunction("glUniform3fv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4fv != null, "pglUniform4fv not implemented");
					Delegates.pglUniform4fv(location, count, p_value);
					LogFunction("glUniform4fv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform4(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform4fv != null, "pglUniform4fv not implemented");
			Delegates.pglUniform4fv(location, count, value);
			LogFunction("glUniform4fv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1iv != null, "pglUniform1iv not implemented");
					Delegates.pglUniform1iv(location, count, p_value);
					LogFunction("glUniform1iv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform1(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform1iv != null, "pglUniform1iv not implemented");
			Delegates.pglUniform1iv(location, count, value);
			LogFunction("glUniform1iv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2iv != null, "pglUniform2iv not implemented");
					Delegates.pglUniform2iv(location, count, p_value);
					LogFunction("glUniform2iv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform2(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform2iv != null, "pglUniform2iv not implemented");
			Delegates.pglUniform2iv(location, count, value);
			LogFunction("glUniform2iv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3iv != null, "pglUniform3iv not implemented");
					Delegates.pglUniform3iv(location, count, p_value);
					LogFunction("glUniform3iv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform3(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform3iv != null, "pglUniform3iv not implemented");
			Delegates.pglUniform3iv(location, count, value);
			LogFunction("glUniform3iv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4iv != null, "pglUniform4iv not implemented");
					Delegates.pglUniform4iv(location, count, p_value);
					LogFunction("glUniform4iv({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform4(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform4iv != null, "pglUniform4iv not implemented");
			Delegates.pglUniform4iv(location, count, value);
			LogFunction("glUniform4iv({0}, {1}, 0x{2})", location, count, new IntPtr(value).ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2fv != null, "pglUniformMatrix2fv not implemented");
					Delegates.pglUniformMatrix2fv(location, count, transpose, p_value);
					LogFunction("glUniformMatrix2fv({0}, {1}, {2}, {3})", location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3fv != null, "pglUniformMatrix3fv not implemented");
					Delegates.pglUniformMatrix3fv(location, count, transpose, p_value);
					LogFunction("glUniformMatrix3fv({0}, {1}, {2}, {3})", location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4fv != null, "pglUniformMatrix4fv not implemented");
					Delegates.pglUniformMatrix4fv(location, count, transpose, p_value);
					LogFunction("glUniformMatrix4fv({0}, {1}, {2}, {3})", location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Validates a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be validated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glValidateProgramARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void ValidateProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglValidateProgram != null, "pglValidateProgram not implemented");
			Delegates.pglValidateProgram(program);
			LogFunction("glValidateProgram({0})", program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1dARB")]
		[AliasOf("glVertexAttrib1dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1d != null, "pglVertexAttrib1d not implemented");
			Delegates.pglVertexAttrib1d(index, x);
			LogFunction("glVertexAttrib1d({0}, {1})", index, x);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1dvARB")]
		[AliasOf("glVertexAttrib1dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1dv != null, "pglVertexAttrib1dv not implemented");
					Delegates.pglVertexAttrib1dv(index, p_v);
					LogFunction("glVertexAttrib1dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1fARB")]
		[AliasOf("glVertexAttrib1fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, float x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1f != null, "pglVertexAttrib1f not implemented");
			Delegates.pglVertexAttrib1f(index, x);
			LogFunction("glVertexAttrib1f({0}, {1})", index, x);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1fvARB")]
		[AliasOf("glVertexAttrib1fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1fv != null, "pglVertexAttrib1fv not implemented");
					Delegates.pglVertexAttrib1fv(index, p_v);
					LogFunction("glVertexAttrib1fv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1sARB")]
		[AliasOf("glVertexAttrib1sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, Int16 x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1s != null, "pglVertexAttrib1s not implemented");
			Delegates.pglVertexAttrib1s(index, x);
			LogFunction("glVertexAttrib1s({0}, {1})", index, x);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1svARB")]
		[AliasOf("glVertexAttrib1svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1sv != null, "pglVertexAttrib1sv not implemented");
					Delegates.pglVertexAttrib1sv(index, p_v);
					LogFunction("glVertexAttrib1sv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2dARB")]
		[AliasOf("glVertexAttrib2dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2d != null, "pglVertexAttrib2d not implemented");
			Delegates.pglVertexAttrib2d(index, x, y);
			LogFunction("glVertexAttrib2d({0}, {1}, {2})", index, x, y);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2dvARB")]
		[AliasOf("glVertexAttrib2dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2dv != null, "pglVertexAttrib2dv not implemented");
					Delegates.pglVertexAttrib2dv(index, p_v);
					LogFunction("glVertexAttrib2dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2fARB")]
		[AliasOf("glVertexAttrib2fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, float x, float y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2f != null, "pglVertexAttrib2f not implemented");
			Delegates.pglVertexAttrib2f(index, x, y);
			LogFunction("glVertexAttrib2f({0}, {1}, {2})", index, x, y);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2fvARB")]
		[AliasOf("glVertexAttrib2fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2fv != null, "pglVertexAttrib2fv not implemented");
					Delegates.pglVertexAttrib2fv(index, p_v);
					LogFunction("glVertexAttrib2fv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2sARB")]
		[AliasOf("glVertexAttrib2sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2s != null, "pglVertexAttrib2s not implemented");
			Delegates.pglVertexAttrib2s(index, x, y);
			LogFunction("glVertexAttrib2s({0}, {1}, {2})", index, x, y);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2svARB")]
		[AliasOf("glVertexAttrib2svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2sv != null, "pglVertexAttrib2sv not implemented");
					Delegates.pglVertexAttrib2sv(index, p_v);
					LogFunction("glVertexAttrib2sv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3dARB")]
		[AliasOf("glVertexAttrib3dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3d != null, "pglVertexAttrib3d not implemented");
			Delegates.pglVertexAttrib3d(index, x, y, z);
			LogFunction("glVertexAttrib3d({0}, {1}, {2}, {3})", index, x, y, z);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3dvARB")]
		[AliasOf("glVertexAttrib3dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3dv != null, "pglVertexAttrib3dv not implemented");
					Delegates.pglVertexAttrib3dv(index, p_v);
					LogFunction("glVertexAttrib3dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3fARB")]
		[AliasOf("glVertexAttrib3fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3f != null, "pglVertexAttrib3f not implemented");
			Delegates.pglVertexAttrib3f(index, x, y, z);
			LogFunction("glVertexAttrib3f({0}, {1}, {2}, {3})", index, x, y, z);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3fvARB")]
		[AliasOf("glVertexAttrib3fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3fv != null, "pglVertexAttrib3fv not implemented");
					Delegates.pglVertexAttrib3fv(index, p_v);
					LogFunction("glVertexAttrib3fv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3sARB")]
		[AliasOf("glVertexAttrib3sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3s != null, "pglVertexAttrib3s not implemented");
			Delegates.pglVertexAttrib3s(index, x, y, z);
			LogFunction("glVertexAttrib3s({0}, {1}, {2}, {3})", index, x, y, z);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3svARB")]
		[AliasOf("glVertexAttrib3svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3sv != null, "pglVertexAttrib3sv not implemented");
					Delegates.pglVertexAttrib3sv(index, p_v);
					LogFunction("glVertexAttrib3sv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NbvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nbv != null, "pglVertexAttrib4Nbv not implemented");
					Delegates.pglVertexAttrib4Nbv(index, p_v);
					LogFunction("glVertexAttrib4Nbv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Niv != null, "pglVertexAttrib4Niv not implemented");
					Delegates.pglVertexAttrib4Niv(index, p_v);
					LogFunction("glVertexAttrib4Niv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NsvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nsv != null, "pglVertexAttrib4Nsv not implemented");
					Delegates.pglVertexAttrib4Nsv(index, p_v);
					LogFunction("glVertexAttrib4Nsv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NubARB")]
		[AliasOf("glVertexAttrib4ubNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4N(UInt32 index, byte x, byte y, byte z, byte w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4Nub != null, "pglVertexAttrib4Nub not implemented");
			Delegates.pglVertexAttrib4Nub(index, x, y, z, w);
			LogFunction("glVertexAttrib4Nub({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NubvARB")]
		[AliasOf("glVertexAttrib4ubvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4N(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nubv != null, "pglVertexAttrib4Nubv not implemented");
					Delegates.pglVertexAttrib4Nubv(index, p_v);
					LogFunction("glVertexAttrib4Nubv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NuivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nuiv != null, "pglVertexAttrib4Nuiv not implemented");
					Delegates.pglVertexAttrib4Nuiv(index, p_v);
					LogFunction("glVertexAttrib4Nuiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NusvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nusv != null, "pglVertexAttrib4Nusv not implemented");
					Delegates.pglVertexAttrib4Nusv(index, p_v);
					LogFunction("glVertexAttrib4Nusv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4bvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4bv != null, "pglVertexAttrib4bv not implemented");
					Delegates.pglVertexAttrib4bv(index, p_v);
					LogFunction("glVertexAttrib4bv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4dARB")]
		[AliasOf("glVertexAttrib4dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4d != null, "pglVertexAttrib4d not implemented");
			Delegates.pglVertexAttrib4d(index, x, y, z, w);
			LogFunction("glVertexAttrib4d({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4dvARB")]
		[AliasOf("glVertexAttrib4dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4dv != null, "pglVertexAttrib4dv not implemented");
					Delegates.pglVertexAttrib4dv(index, p_v);
					LogFunction("glVertexAttrib4dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4fARB")]
		[AliasOf("glVertexAttrib4fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4f != null, "pglVertexAttrib4f not implemented");
			Delegates.pglVertexAttrib4f(index, x, y, z, w);
			LogFunction("glVertexAttrib4f({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4fvARB")]
		[AliasOf("glVertexAttrib4fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4fv != null, "pglVertexAttrib4fv not implemented");
					Delegates.pglVertexAttrib4fv(index, p_v);
					LogFunction("glVertexAttrib4fv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4iv != null, "pglVertexAttrib4iv not implemented");
					Delegates.pglVertexAttrib4iv(index, p_v);
					LogFunction("glVertexAttrib4iv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4sARB")]
		[AliasOf("glVertexAttrib4sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4s != null, "pglVertexAttrib4s not implemented");
			Delegates.pglVertexAttrib4s(index, x, y, z, w);
			LogFunction("glVertexAttrib4s({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4svARB")]
		[AliasOf("glVertexAttrib4svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4sv != null, "pglVertexAttrib4sv not implemented");
					Delegates.pglVertexAttrib4sv(index, p_v);
					LogFunction("glVertexAttrib4sv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4ubvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ub(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4ubv != null, "pglVertexAttrib4ubv not implemented");
					Delegates.pglVertexAttrib4ubv(index, p_v);
					LogFunction("glVertexAttrib4ubv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4uivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4uiv != null, "pglVertexAttrib4uiv not implemented");
					Delegates.pglVertexAttrib4uiv(index, p_v);
					LogFunction("glVertexAttrib4uiv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4usvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4usv != null, "pglVertexAttrib4usv not implemented");
					Delegates.pglVertexAttrib4usv(index, p_v);
					LogFunction("glVertexAttrib4usv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For Gl.VertexAttribPointer, specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted 
		/// directly as fixed-point values (Gl.FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribPointerARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribPointer != null, "pglVertexAttribPointer not implemented");
			Delegates.pglVertexAttribPointer(index, size, type, normalized, stride, pointer);
			LogFunction("glVertexAttribPointer({0}, {1}, {2}, {3}, {4}, 0x{5})", index, size, LogEnumName(type), normalized, stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For Gl.VertexAttribPointer, specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted 
		/// directly as fixed-point values (Gl.FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribPointerARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribPointer(index, size, type, normalized, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
