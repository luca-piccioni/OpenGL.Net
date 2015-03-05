
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
		/// Value of GL_BLEND_EQUATION_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BLEND_EQUATION_RGB = 0x8009;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_ENABLED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_ATTRIB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int CURRENT_VERTEX_ATTRIB = 0x8626;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_POINT_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_POINTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FUNC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_FUNC = 0x8800;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_FAIL = 0x8801;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_PASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

		/// <summary>
		/// Value of GL_MAX_DRAW_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_DRAW_BUFFERS = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER0 = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER1 = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER2 = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER3 = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER4 = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER5 = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER6 = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER7 = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER8 = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER9 = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER10 = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER11 = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER12 = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER13 = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER14 = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER15 = 0x8834;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BLEND_EQUATION_ALPHA = 0x883D;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIBS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_ATTRIBS = 0x8869;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_NORMALIZED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FRAGMENT_SHADER = 0x8B30;

		/// <summary>
		/// Value of GL_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_SHADER = 0x8B31;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;

		/// <summary>
		/// Value of GL_MAX_VARYING_FLOATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VARYING_FLOATS = 0x8B4B;

		/// <summary>
		/// Value of GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

		/// <summary>
		/// Value of GL_SHADER_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SHADER_TYPE = 0x8B4F;

		/// <summary>
		/// Value of GL_FLOAT_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC2 = 0x8B50;

		/// <summary>
		/// Value of GL_FLOAT_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC3 = 0x8B51;

		/// <summary>
		/// Value of GL_FLOAT_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC4 = 0x8B52;

		/// <summary>
		/// Value of GL_INT_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC2 = 0x8B53;

		/// <summary>
		/// Value of GL_INT_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC3 = 0x8B54;

		/// <summary>
		/// Value of GL_INT_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC4 = 0x8B55;

		/// <summary>
		/// Value of GL_BOOL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL = 0x8B56;

		/// <summary>
		/// Value of GL_BOOL_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC2 = 0x8B57;

		/// <summary>
		/// Value of GL_BOOL_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC3 = 0x8B58;

		/// <summary>
		/// Value of GL_BOOL_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC4 = 0x8B59;

		/// <summary>
		/// Value of GL_FLOAT_MAT2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT2 = 0x8B5A;

		/// <summary>
		/// Value of GL_FLOAT_MAT3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT3 = 0x8B5B;

		/// <summary>
		/// Value of GL_FLOAT_MAT4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT4 = 0x8B5C;

		/// <summary>
		/// Value of GL_SAMPLER_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_1D = 0x8B5D;

		/// <summary>
		/// Value of GL_SAMPLER_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_2D = 0x8B5E;

		/// <summary>
		/// Value of GL_SAMPLER_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_3D = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_CUBE = 0x8B60;

		/// <summary>
		/// Value of GL_SAMPLER_1D_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_1D_SHADOW = 0x8B61;

		/// <summary>
		/// Value of GL_SAMPLER_2D_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_2D_SHADOW = 0x8B62;

		/// <summary>
		/// Value of GL_DELETE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DELETE_STATUS = 0x8B80;

		/// <summary>
		/// Value of GL_COMPILE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int COMPILE_STATUS = 0x8B81;

		/// <summary>
		/// Value of GL_LINK_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int LINK_STATUS = 0x8B82;

		/// <summary>
		/// Value of GL_VALIDATE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VALIDATE_STATUS = 0x8B83;

		/// <summary>
		/// Value of GL_INFO_LOG_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INFO_LOG_LENGTH = 0x8B84;

		/// <summary>
		/// Value of GL_ATTACHED_SHADERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int ATTACHED_SHADERS = 0x8B85;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int ACTIVE_UNIFORMS = 0x8B86;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;

		/// <summary>
		/// Value of GL_SHADER_SOURCE_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SHADER_SOURCE_LENGTH = 0x8B88;

		/// <summary>
		/// Value of GL_ACTIVE_ATTRIBUTES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int ACTIVE_ATTRIBUTES = 0x8B89;

		/// <summary>
		/// Value of GL_ACTIVE_ATTRIBUTE_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_DERIVATIVE_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

		/// <summary>
		/// Value of GL_SHADING_LANGUAGE_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SHADING_LANGUAGE_VERSION = 0x8B8C;

		/// <summary>
		/// Value of GL_CURRENT_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int CURRENT_PROGRAM = 0x8B8D;

		/// <summary>
		/// Value of GL_POINT_SPRITE_COORD_ORIGIN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

		/// <summary>
		/// Value of GL_LOWER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int LOWER_LEFT = 0x8CA1;

		/// <summary>
		/// Value of GL_UPPER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int UPPER_LEFT = 0x8CA2;

		/// <summary>
		/// Value of GL_STENCIL_BACK_REF symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_REF = 0x8CA3;

		/// <summary>
		/// Value of GL_STENCIL_BACK_VALUE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;

		/// <summary>
		/// Value of GL_STENCIL_BACK_WRITEMASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_WRITEMASK = 0x8CA5;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_TWO_SIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_PROGRAM_TWO_SIDE = 0x8643;

		/// <summary>
		/// Value of GL_POINT_SPRITE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SPRITE = 0x8861;

		/// <summary>
		/// Value of GL_COORD_REPLACE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COORD_REPLACE = 0x8862;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_COORDS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
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
		/// combined. It must be <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, 
		/// <see cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must 
		/// be <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see 
		/// cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void BlendEquationSeparate(int modeRGB, int modeAlpha)
		{
			if        (Delegates.pglBlendEquationSeparate != null) {
				Delegates.pglBlendEquationSeparate(modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparate({0}, {1})", modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateEXT != null) {
				Delegates.pglBlendEquationSeparateEXT(modeRGB, modeAlpha);
				CallLog("glBlendEquationSeparateEXT({0}, {1})", modeRGB, modeAlpha);
			} else
				throw new NotImplementedException("glBlendEquationSeparate (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the RGB blend equation and the alpha blend equation separately
		/// </summary>
		/// <param name="modeRGB">
		/// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are 
		/// combined. It must be <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, 
		/// <see cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must 
		/// be <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see 
		/// cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			if        (Delegates.pglBlendEquationSeparate != null) {
				Delegates.pglBlendEquationSeparate((int)modeRGB, (int)modeAlpha);
				CallLog("glBlendEquationSeparate({0}, {1})", modeRGB, modeAlpha);
			} else if (Delegates.pglBlendEquationSeparateEXT != null) {
				Delegates.pglBlendEquationSeparateEXT((int)modeRGB, (int)modeAlpha);
				CallLog("glBlendEquationSeparateEXT({0}, {1})", modeRGB, modeAlpha);
			} else
				throw new NotImplementedException("glBlendEquationSeparate (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies a list of color buffers to be drawn into
		/// </summary>
		/// <param name="n">
		/// Specifies the number of buffers in bufs.
		/// </param>
		/// <param name="bufs">
		/// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be 
		/// written.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void DrawBuffers(Int32 n, int[] bufs)
		{
			Debug.Assert(bufs.Length >= n);
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					if        (Delegates.pglDrawBuffers != null) {
						Delegates.pglDrawBuffers(n, p_bufs);
						CallLog("glDrawBuffers({0}, {1})", n, bufs);
					} else if (Delegates.pglDrawBuffersARB != null) {
						Delegates.pglDrawBuffersARB(n, p_bufs);
						CallLog("glDrawBuffersARB({0}, {1})", n, bufs);
					} else if (Delegates.pglDrawBuffersATI != null) {
						Delegates.pglDrawBuffersATI(n, p_bufs);
						CallLog("glDrawBuffersATI({0}, {1})", n, bufs);
					} else if (Delegates.pglDrawBuffersEXT != null) {
						Delegates.pglDrawBuffersEXT(n, p_bufs);
						CallLog("glDrawBuffersEXT({0}, {1})", n, bufs);
					} else
						throw new NotImplementedException("glDrawBuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and/or back stencil test actions
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK.
		/// </param>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, 
		/// GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic 
		/// constants as sfail. The initial value is GL_KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. 
		/// The initial value is GL_KEEP.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void StencilOpSeparate(int face, int sfail, int dpfail, int dppass)
		{
			if        (Delegates.pglStencilOpSeparate != null) {
				Delegates.pglStencilOpSeparate(face, sfail, dpfail, dppass);
				CallLog("glStencilOpSeparate({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			} else if (Delegates.pglStencilOpSeparateATI != null) {
				Delegates.pglStencilOpSeparateATI(face, sfail, dpfail, dppass);
				CallLog("glStencilOpSeparateATI({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			} else
				throw new NotImplementedException("glStencilOpSeparate (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and/or back stencil test actions
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK.
		/// </param>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, 
		/// GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic 
		/// constants as sfail. The initial value is GL_KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. 
		/// The initial value is GL_KEEP.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void StencilOpSeparate(int face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			if        (Delegates.pglStencilOpSeparate != null) {
				Delegates.pglStencilOpSeparate(face, (int)sfail, (int)dpfail, (int)dppass);
				CallLog("glStencilOpSeparate({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			} else if (Delegates.pglStencilOpSeparateATI != null) {
				Delegates.pglStencilOpSeparateATI(face, (int)sfail, (int)dpfail, (int)dppass);
				CallLog("glStencilOpSeparateATI({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			} else
				throw new NotImplementedException("glStencilOpSeparate (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and/or back function and reference value for stencil testing
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK.
		/// </param>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void StencilFuncSeparate(int face, int func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparate != null, "pglStencilFuncSeparate not implemented");
			Delegates.pglStencilFuncSeparate(face, func, @ref, mask);
			CallLog("glStencilFuncSeparate({0}, {1}, {2}, {3})", face, func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and/or back function and reference value for stencil testing
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK.
		/// </param>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void StencilFuncSeparate(int face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparate != null, "pglStencilFuncSeparate not implemented");
			Delegates.pglStencilFuncSeparate(face, (int)func, @ref, mask);
			CallLog("glStencilFuncSeparate({0}, {1}, {2}, {3})", face, func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the front and/or back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="face">
		/// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: GL_FRONT, 
		/// GL_BACK, and GL_FRONT_AND_BACK.
		/// </param>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void StencilMaskSeparate(int face, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMaskSeparate != null, "pglStencilMaskSeparate not implemented");
			Delegates.pglStencilMaskSeparate(face, mask);
			CallLog("glStencilMaskSeparate({0}, {1})", face, mask);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void AttachShader(UInt32 program, UInt32 shader)
		{
			if        (Delegates.pglAttachShader != null) {
				Delegates.pglAttachShader(program, shader);
				CallLog("glAttachShader({0}, {1})", program, shader);
			} else if (Delegates.pglAttachObjectARB != null) {
				Delegates.pglAttachObjectARB(program, shader);
				CallLog("glAttachObjectARB({0}, {1})", program, shader);
			} else
				throw new NotImplementedException("glAttachShader (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// Specifies a null terminated string containing the name of the vertex shader attribute variable to which index is to be 
		/// bound.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void BindAttribLocation(UInt32 program, UInt32 index, String name)
		{
			if        (Delegates.pglBindAttribLocation != null) {
				Delegates.pglBindAttribLocation(program, index, name);
				CallLog("glBindAttribLocation({0}, {1}, {2})", program, index, name);
			} else if (Delegates.pglBindAttribLocationARB != null) {
				Delegates.pglBindAttribLocationARB(program, index, name);
				CallLog("glBindAttribLocationARB({0}, {1}, {2})", program, index, name);
			} else
				throw new NotImplementedException("glBindAttribLocation (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Compiles a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be compiled.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void CompileShader(UInt32 shader)
		{
			if        (Delegates.pglCompileShader != null) {
				Delegates.pglCompileShader(shader);
				CallLog("glCompileShader({0})", shader);
			} else if (Delegates.pglCompileShaderARB != null) {
				Delegates.pglCompileShaderARB(shader);
				CallLog("glCompileShaderARB({0})", shader);
			} else
				throw new NotImplementedException("glCompileShader (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Creates a program object
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static UInt32 CreateProgram()
		{
			UInt32 retValue;

			if        (Delegates.pglCreateProgram != null) {
				retValue = Delegates.pglCreateProgram();
				CallLog("glCreateProgram() = {0}", retValue);
			} else if (Delegates.pglCreateProgramObjectARB != null) {
				retValue = Delegates.pglCreateProgramObjectARB();
				CallLog("glCreateProgramObjectARB() = {0}", retValue);
			} else
				throw new NotImplementedException("glCreateProgram (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Creates a shader object
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static UInt32 CreateShader(int type)
		{
			UInt32 retValue;

			if        (Delegates.pglCreateShader != null) {
				retValue = Delegates.pglCreateShader(type);
				CallLog("glCreateShader({0}) = {1}", type, retValue);
			} else if (Delegates.pglCreateShaderObjectARB != null) {
				retValue = Delegates.pglCreateShaderObjectARB(type);
				CallLog("glCreateShaderObjectARB({0}) = {1}", type, retValue);
			} else
				throw new NotImplementedException("glCreateShader (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Deletes a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void DeleteProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglDeleteProgram != null, "pglDeleteProgram not implemented");
			Delegates.pglDeleteProgram(program);
			CallLog("glDeleteProgram({0})", program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Deletes a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void DeleteShader(UInt32 shader)
		{
			Debug.Assert(Delegates.pglDeleteShader != null, "pglDeleteShader not implemented");
			Delegates.pglDeleteShader(shader);
			CallLog("glDeleteShader({0})", shader);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void DetachShader(UInt32 program, UInt32 shader)
		{
			if        (Delegates.pglDetachShader != null) {
				Delegates.pglDetachShader(program, shader);
				CallLog("glDetachShader({0}, {1})", program, shader);
			} else if (Delegates.pglDetachObjectARB != null) {
				Delegates.pglDetachObjectARB(program, shader);
				CallLog("glDetachObjectARB({0}, {1})", program, shader);
			} else
				throw new NotImplementedException("glDetachShader (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void DisableVertexAttribArray(UInt32 index)
		{
			if        (Delegates.pglDisableVertexAttribArray != null) {
				Delegates.pglDisableVertexAttribArray(index);
				CallLog("glDisableVertexAttribArray({0})", index);
			} else if (Delegates.pglDisableVertexAttribArrayARB != null) {
				Delegates.pglDisableVertexAttribArrayARB(index);
				CallLog("glDisableVertexAttribArrayARB({0})", index);
			} else
				throw new NotImplementedException("glDisableVertexAttribArray (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void EnableVertexAttribArray(UInt32 index)
		{
			if        (Delegates.pglEnableVertexAttribArray != null) {
				Delegates.pglEnableVertexAttribArray(index);
				CallLog("glEnableVertexAttribArray({0})", index);
			} else if (Delegates.pglEnableVertexAttribArrayARB != null) {
				Delegates.pglEnableVertexAttribArrayARB(index);
				CallLog("glEnableVertexAttribArrayARB({0})", index);
			} else
				throw new NotImplementedException("glEnableVertexAttribArray (and other aliases) are not implemented");
			DebugCheckErrors();
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
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null 
		/// terminator) if a value other than NULL is passed.
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					if        (Delegates.pglGetActiveAttrib != null) {
						Delegates.pglGetActiveAttrib(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetActiveAttrib({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else if (Delegates.pglGetActiveAttribARB != null) {
						Delegates.pglGetActiveAttribARB(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetActiveAttribARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else
						throw new NotImplementedException("glGetActiveAttrib (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by name (excluding the null 
		/// terminator) if a value other than NULL is passed.
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					if        (Delegates.pglGetActiveUniform != null) {
						Delegates.pglGetActiveUniform(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetActiveUniform({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else if (Delegates.pglGetActiveUniformARB != null) {
						Delegates.pglGetActiveUniformARB(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetActiveUniformARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else
						throw new NotImplementedException("glGetActiveUniform (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns the handles of the shader objects attached to a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="maxCount">
		/// Specifies the size of the array for storing the returned object names.
		/// </param>
		/// <param name="count">
		/// Returns the number of names actually returned in shaders.
		/// </param>
		/// <param name="shaders">
		/// Specifies an array that is used to return the names of attached shader objects.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetAttachedShaders(UInt32 program, Int32 maxCount, out Int32 count, UInt32[] shaders)
		{
			Debug.Assert(shaders.Length >= maxCount);
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglGetAttachedShaders != null, "pglGetAttachedShaders not implemented");
					Delegates.pglGetAttachedShaders(program, maxCount, p_count, p_shaders);
					CallLog("glGetAttachedShaders({0}, {1}, {2}, {3})", program, maxCount, count, shaders);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static Int32 GetAttribLocation(UInt32 program, String name)
		{
			Int32 retValue;

			if        (Delegates.pglGetAttribLocation != null) {
				retValue = Delegates.pglGetAttribLocation(program, name);
				CallLog("glGetAttribLocation({0}, {1}) = {2}", program, name, retValue);
			} else if (Delegates.pglGetAttribLocationARB != null) {
				retValue = Delegates.pglGetAttribLocationARB(program, name);
				CallLog("glGetAttribLocationARB({0}, {1}) = {2}", program, name, retValue);
			} else
				throw new NotImplementedException("glGetAttribLocation (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Returns a parameter from a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are GL_DELETE_STATUS, GL_LINK_STATUS, GL_VALIDATE_STATUS, 
		/// GL_INFO_LOG_LENGTH, GL_ATTACHED_SHADERS, GL_ACTIVE_ATOMIC_COUNTER_BUFFERS, GL_ACTIVE_ATTRIBUTES, 
		/// GL_ACTIVE_ATTRIBUTE_MAX_LENGTH, GL_ACTIVE_UNIFORMS, GL_ACTIVE_UNIFORM_BLOCKS, GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
		/// GL_ACTIVE_UNIFORM_MAX_LENGTH, GL_COMPUTE_WORK_GROUP_SIZEGL_PROGRAM_BINARY_LENGTH, GL_TRANSFORM_FEEDBACK_BUFFER_MODE, 
		/// GL_TRANSFORM_FEEDBACK_VARYINGS, GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, GL_GEOMETRY_VERTICES_OUT, 
		/// GL_GEOMETRY_INPUT_TYPE, and GL_GEOMETRY_OUTPUT_TYPE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetProgram(UInt32 program, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramiv != null, "pglGetProgramiv not implemented");
					Delegates.pglGetProgramiv(program, pname, p_params);
					CallLog("glGetProgramiv({0}, {1}, {2})", program, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns the information log for a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object whose information log is to be queried.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in infoLog (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetProgramInfoLog(UInt32 program, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramInfoLog != null, "pglGetProgramInfoLog not implemented");
					Delegates.pglGetProgramInfoLog(program, bufSize, p_length, infoLog);
					CallLog("glGetProgramInfoLog({0}, {1}, {2}, {3})", program, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns a parameter from a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, 
		/// GL_INFO_LOG_LENGTH, GL_SHADER_SOURCE_LENGTH.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetShader(UInt32 shader, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetShaderiv != null, "pglGetShaderiv not implemented");
					Delegates.pglGetShaderiv(shader, pname, p_params);
					CallLog("glGetShaderiv({0}, {1}, {2})", shader, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns the information log for a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object whose information log is to be queried.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in infoLog (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetShaderInfoLog(UInt32 shader, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderInfoLog != null, "pglGetShaderInfoLog not implemented");
					Delegates.pglGetShaderInfoLog(shader, bufSize, p_length, infoLog);
					CallLog("glGetShaderInfoLog({0}, {1}, {2}, {3})", shader, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors();
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
		/// Returns the length of the string returned in source (excluding the null terminator).
		/// </param>
		/// <param name="source">
		/// Specifies an array of characters that is used to return the source code string.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetShaderSource(UInt32 shader, Int32 bufSize, out Int32 length, [Out] StringBuilder source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					if        (Delegates.pglGetShaderSource != null) {
						Delegates.pglGetShaderSource(shader, bufSize, p_length, source);
						CallLog("glGetShaderSource({0}, {1}, {2}, {3})", shader, bufSize, length, source);
					} else if (Delegates.pglGetShaderSourceARB != null) {
						Delegates.pglGetShaderSourceARB(shader, bufSize, p_length, source);
						CallLog("glGetShaderSourceARB({0}, {1}, {2}, {3})", shader, bufSize, length, source);
					} else
						throw new NotImplementedException("glGetShaderSource (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static Int32 GetUniformLocation(UInt32 program, String name)
		{
			Int32 retValue;

			if        (Delegates.pglGetUniformLocation != null) {
				retValue = Delegates.pglGetUniformLocation(program, name);
				CallLog("glGetUniformLocation({0}, {1}) = {2}", program, name, retValue);
			} else if (Delegates.pglGetUniformLocationARB != null) {
				retValue = Delegates.pglGetUniformLocationARB(program, name);
				CallLog("glGetUniformLocationARB({0}, {1}) = {2}", program, name, retValue);
			} else
				throw new NotImplementedException("glGetUniformLocation (and other aliases) are not implemented");
			DebugCheckErrors();

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
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetUniform(UInt32 program, Int32 location, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglGetUniformfv != null) {
						Delegates.pglGetUniformfv(program, location, p_params);
						CallLog("glGetUniformfv({0}, {1}, {2})", program, location, @params);
					} else if (Delegates.pglGetUniformfvARB != null) {
						Delegates.pglGetUniformfvARB(program, location, p_params);
						CallLog("glGetUniformfvARB({0}, {1}, {2})", program, location, @params);
					} else
						throw new NotImplementedException("glGetUniformfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetUniform(UInt32 program, Int32 location, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetUniformiv != null) {
						Delegates.pglGetUniformiv(program, location, p_params);
						CallLog("glGetUniformiv({0}, {1}, {2})", program, location, @params);
					} else if (Delegates.pglGetUniformivARB != null) {
						Delegates.pglGetUniformivARB(program, location, p_params);
						CallLog("glGetUniformivARB({0}, {1}, {2})", program, location, @params);
					} else
						throw new NotImplementedException("glGetUniformiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetVertexAttrib(UInt32 index, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					if        (Delegates.pglGetVertexAttribdv != null) {
						Delegates.pglGetVertexAttribdv(index, pname, p_params);
						CallLog("glGetVertexAttribdv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribdvARB != null) {
						Delegates.pglGetVertexAttribdvARB(index, pname, p_params);
						CallLog("glGetVertexAttribdvARB({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribdvNV != null) {
						Delegates.pglGetVertexAttribdvNV(index, pname, p_params);
						CallLog("glGetVertexAttribdvNV({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribdv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetVertexAttrib(UInt32 index, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglGetVertexAttribfv != null) {
						Delegates.pglGetVertexAttribfv(index, pname, p_params);
						CallLog("glGetVertexAttribfv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribfvARB != null) {
						Delegates.pglGetVertexAttribfvARB(index, pname, p_params);
						CallLog("glGetVertexAttribfvARB({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribfvNV != null) {
						Delegates.pglGetVertexAttribfvNV(index, pname, p_params);
						CallLog("glGetVertexAttribfvNV({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetVertexAttrib(UInt32 index, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetVertexAttribiv != null) {
						Delegates.pglGetVertexAttribiv(index, pname, p_params);
						CallLog("glGetVertexAttribiv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribivARB != null) {
						Delegates.pglGetVertexAttribivARB(index, pname, p_params);
						CallLog("glGetVertexAttribivARB({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribivNV != null) {
						Delegates.pglGetVertexAttribivNV(index, pname, p_params);
						CallLog("glGetVertexAttribivNV({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the address of the specified generic vertex attribute pointer
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be returned.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be 
		/// GL_VERTEX_ATTRIB_ARRAY_POINTER.
		/// </param>
		/// <param name="pointer">
		/// Returns the pointer value.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetVertexAttribPointer(UInt32 index, int pname, IntPtr pointer)
		{
			if        (Delegates.pglGetVertexAttribPointerv != null) {
				Delegates.pglGetVertexAttribPointerv(index, pname, pointer);
				CallLog("glGetVertexAttribPointerv({0}, {1}, {2})", index, pname, pointer);
			} else if (Delegates.pglGetVertexAttribPointervARB != null) {
				Delegates.pglGetVertexAttribPointervARB(index, pname, pointer);
				CallLog("glGetVertexAttribPointervARB({0}, {1}, {2})", index, pname, pointer);
			} else if (Delegates.pglGetVertexAttribPointervNV != null) {
				Delegates.pglGetVertexAttribPointervNV(index, pname, pointer);
				CallLog("glGetVertexAttribPointervNV({0}, {1}, {2})", index, pname, pointer);
			} else
				throw new NotImplementedException("glGetVertexAttribPointerv (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Determines if a name corresponds to a program object
		/// </summary>
		/// <param name="program">
		/// Specifies a potential program object.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static bool IsProgram(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgram != null, "pglIsProgram not implemented");
			retValue = Delegates.pglIsProgram(program);
			CallLog("glIsProgram({0}) = {1}", program, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Determines if a name corresponds to a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies a potential shader object.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static bool IsShader(UInt32 shader)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsShader != null, "pglIsShader not implemented");
			retValue = Delegates.pglIsShader(shader);
			CallLog("glIsShader({0}) = {1}", shader, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Links a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be linked.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void LinkProgram(UInt32 program)
		{
			if        (Delegates.pglLinkProgram != null) {
				Delegates.pglLinkProgram(program);
				CallLog("glLinkProgram({0})", program);
			} else if (Delegates.pglLinkProgramARB != null) {
				Delegates.pglLinkProgramARB(program);
				CallLog("glLinkProgramARB({0})", program);
			} else
				throw new NotImplementedException("glLinkProgram (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Replaces the source code in a shader object
		/// </summary>
		/// <param name="shader">
		/// Specifies the handle of the shader object whose source code is to be replaced.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements in the string and length arrays.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String[]"/>.
		/// </param>
		/// <param name="length">
		/// Specifies an array of string lengths.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length)
		{
			Debug.Assert(@string.Length >= count);
			Debug.Assert(length.Length >= count);
			unsafe {
				fixed (Int32* p_length = length)
				{
					if        (Delegates.pglShaderSource != null) {
						Delegates.pglShaderSource(shader, count, @string, p_length);
						CallLog("glShaderSource({0}, {1}, {2}, {3})", shader, count, @string, length);
					} else if (Delegates.pglShaderSourceARB != null) {
						Delegates.pglShaderSourceARB(shader, count, @string, p_length);
						CallLog("glShaderSourceARB({0}, {1}, {2}, {3})", shader, count, @string, length);
					} else
						throw new NotImplementedException("glShaderSource (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Installs a program object as part of current rendering state
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object whose executables are to be used as part of current rendering state.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void UseProgram(UInt32 program)
		{
			if        (Delegates.pglUseProgram != null) {
				Delegates.pglUseProgram(program);
				CallLog("glUseProgram({0})", program);
			} else if (Delegates.pglUseProgramObjectARB != null) {
				Delegates.pglUseProgramObjectARB(program);
				CallLog("glUseProgramObjectARB({0})", program);
			} else
				throw new NotImplementedException("glUseProgram (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform1(Int32 location, float v0)
		{
			if        (Delegates.pglUniform1f != null) {
				Delegates.pglUniform1f(location, v0);
				CallLog("glUniform1f({0}, {1})", location, v0);
			} else if (Delegates.pglUniform1fARB != null) {
				Delegates.pglUniform1fARB(location, v0);
				CallLog("glUniform1fARB({0}, {1})", location, v0);
			} else
				throw new NotImplementedException("glUniform1f (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform2(Int32 location, float v0, float v1)
		{
			if        (Delegates.pglUniform2f != null) {
				Delegates.pglUniform2f(location, v0, v1);
				CallLog("glUniform2f({0}, {1}, {2})", location, v0, v1);
			} else if (Delegates.pglUniform2fARB != null) {
				Delegates.pglUniform2fARB(location, v0, v1);
				CallLog("glUniform2fARB({0}, {1}, {2})", location, v0, v1);
			} else
				throw new NotImplementedException("glUniform2f (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform3(Int32 location, float v0, float v1, float v2)
		{
			if        (Delegates.pglUniform3f != null) {
				Delegates.pglUniform3f(location, v0, v1, v2);
				CallLog("glUniform3f({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else if (Delegates.pglUniform3fARB != null) {
				Delegates.pglUniform3fARB(location, v0, v1, v2);
				CallLog("glUniform3fARB({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else
				throw new NotImplementedException("glUniform3f (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform4(Int32 location, float v0, float v1, float v2, float v3)
		{
			if        (Delegates.pglUniform4f != null) {
				Delegates.pglUniform4f(location, v0, v1, v2, v3);
				CallLog("glUniform4f({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else if (Delegates.pglUniform4fARB != null) {
				Delegates.pglUniform4fARB(location, v0, v1, v2, v3);
				CallLog("glUniform4fARB({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glUniform4f (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform1(Int32 location, Int32 v0)
		{
			if        (Delegates.pglUniform1i != null) {
				Delegates.pglUniform1i(location, v0);
				CallLog("glUniform1i({0}, {1})", location, v0);
			} else if (Delegates.pglUniform1iARB != null) {
				Delegates.pglUniform1iARB(location, v0);
				CallLog("glUniform1iARB({0}, {1})", location, v0);
			} else
				throw new NotImplementedException("glUniform1i (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform2(Int32 location, Int32 v0, Int32 v1)
		{
			if        (Delegates.pglUniform2i != null) {
				Delegates.pglUniform2i(location, v0, v1);
				CallLog("glUniform2i({0}, {1}, {2})", location, v0, v1);
			} else if (Delegates.pglUniform2iARB != null) {
				Delegates.pglUniform2iARB(location, v0, v1);
				CallLog("glUniform2iARB({0}, {1}, {2})", location, v0, v1);
			} else
				throw new NotImplementedException("glUniform2i (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform3(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			if        (Delegates.pglUniform3i != null) {
				Delegates.pglUniform3i(location, v0, v1, v2);
				CallLog("glUniform3i({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else if (Delegates.pglUniform3iARB != null) {
				Delegates.pglUniform3iARB(location, v0, v1, v2);
				CallLog("glUniform3iARB({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else
				throw new NotImplementedException("glUniform3i (and other aliases) are not implemented");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform4(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			if        (Delegates.pglUniform4i != null) {
				Delegates.pglUniform4i(location, v0, v1, v2, v3);
				CallLog("glUniform4i({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else if (Delegates.pglUniform4iARB != null) {
				Delegates.pglUniform4iARB(location, v0, v1, v2, v3);
				CallLog("glUniform4iARB({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glUniform4i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform1(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniform1fv != null) {
						Delegates.pglUniform1fv(location, count, p_value);
						CallLog("glUniform1fv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform1fvARB != null) {
						Delegates.pglUniform1fvARB(location, count, p_value);
						CallLog("glUniform1fvARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform1fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform2(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniform2fv != null) {
						Delegates.pglUniform2fv(location, count, p_value);
						CallLog("glUniform2fv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform2fvARB != null) {
						Delegates.pglUniform2fvARB(location, count, p_value);
						CallLog("glUniform2fvARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform3(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniform3fv != null) {
						Delegates.pglUniform3fv(location, count, p_value);
						CallLog("glUniform3fv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform3fvARB != null) {
						Delegates.pglUniform3fvARB(location, count, p_value);
						CallLog("glUniform3fvARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform4(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniform4fv != null) {
						Delegates.pglUniform4fv(location, count, p_value);
						CallLog("glUniform4fv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform4fvARB != null) {
						Delegates.pglUniform4fvARB(location, count, p_value);
						CallLog("glUniform4fvARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform1(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglUniform1iv != null) {
						Delegates.pglUniform1iv(location, count, p_value);
						CallLog("glUniform1iv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform1ivARB != null) {
						Delegates.pglUniform1ivARB(location, count, p_value);
						CallLog("glUniform1ivARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform1iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform2(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglUniform2iv != null) {
						Delegates.pglUniform2iv(location, count, p_value);
						CallLog("glUniform2iv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform2ivARB != null) {
						Delegates.pglUniform2ivARB(location, count, p_value);
						CallLog("glUniform2ivARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform2iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform3(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglUniform3iv != null) {
						Delegates.pglUniform3iv(location, count, p_value);
						CallLog("glUniform3iv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform3ivARB != null) {
						Delegates.pglUniform3ivARB(location, count, p_value);
						CallLog("glUniform3ivARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void Uniform4(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglUniform4iv != null) {
						Delegates.pglUniform4iv(location, count, p_value);
						CallLog("glUniform4iv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform4ivARB != null) {
						Delegates.pglUniform4ivARB(location, count, p_value);
						CallLog("glUniform4ivARB({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform4iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void UniformMatrix2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix2fv != null) {
						Delegates.pglUniformMatrix2fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix2fvARB != null) {
						Delegates.pglUniformMatrix2fvARB(location, count, transpose, p_value);
						CallLog("glUniformMatrix2fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void UniformMatrix3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix3fv != null) {
						Delegates.pglUniformMatrix3fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix3fvARB != null) {
						Delegates.pglUniformMatrix3fvARB(location, count, transpose, p_value);
						CallLog("glUniformMatrix3fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void UniformMatrix4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix4fv != null) {
						Delegates.pglUniformMatrix4fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix4fvARB != null) {
						Delegates.pglUniformMatrix4fvARB(location, count, transpose, p_value);
						CallLog("glUniformMatrix4fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Validates a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be validated.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void ValidateProgram(UInt32 program)
		{
			if        (Delegates.pglValidateProgram != null) {
				Delegates.pglValidateProgram(program);
				CallLog("glValidateProgram({0})", program);
			} else if (Delegates.pglValidateProgramARB != null) {
				Delegates.pglValidateProgramARB(program);
				CallLog("glValidateProgramARB({0})", program);
			} else
				throw new NotImplementedException("glValidateProgram (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, double x)
		{
			if        (Delegates.pglVertexAttrib1d != null) {
				Delegates.pglVertexAttrib1d(index, x);
				CallLog("glVertexAttrib1d({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1dARB != null) {
				Delegates.pglVertexAttrib1dARB(index, x);
				CallLog("glVertexAttrib1dARB({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1dNV != null) {
				Delegates.pglVertexAttrib1dNV(index, x);
				CallLog("glVertexAttrib1dNV({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttrib1d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttrib1dv != null) {
						Delegates.pglVertexAttrib1dv(index, p_v);
						CallLog("glVertexAttrib1dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1dvARB != null) {
						Delegates.pglVertexAttrib1dvARB(index, p_v);
						CallLog("glVertexAttrib1dvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1dvNV != null) {
						Delegates.pglVertexAttrib1dvNV(index, p_v);
						CallLog("glVertexAttrib1dvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib1dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, float x)
		{
			if        (Delegates.pglVertexAttrib1f != null) {
				Delegates.pglVertexAttrib1f(index, x);
				CallLog("glVertexAttrib1f({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1fARB != null) {
				Delegates.pglVertexAttrib1fARB(index, x);
				CallLog("glVertexAttrib1fARB({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1fNV != null) {
				Delegates.pglVertexAttrib1fNV(index, x);
				CallLog("glVertexAttrib1fNV({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttrib1f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglVertexAttrib1fv != null) {
						Delegates.pglVertexAttrib1fv(index, p_v);
						CallLog("glVertexAttrib1fv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1fvARB != null) {
						Delegates.pglVertexAttrib1fvARB(index, p_v);
						CallLog("glVertexAttrib1fvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1fvNV != null) {
						Delegates.pglVertexAttrib1fvNV(index, p_v);
						CallLog("glVertexAttrib1fvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib1fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, Int16 x)
		{
			if        (Delegates.pglVertexAttrib1s != null) {
				Delegates.pglVertexAttrib1s(index, x);
				CallLog("glVertexAttrib1s({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1sARB != null) {
				Delegates.pglVertexAttrib1sARB(index, x);
				CallLog("glVertexAttrib1sARB({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttrib1sNV != null) {
				Delegates.pglVertexAttrib1sNV(index, x);
				CallLog("glVertexAttrib1sNV({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttrib1s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib1(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib1sv != null) {
						Delegates.pglVertexAttrib1sv(index, p_v);
						CallLog("glVertexAttrib1sv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1svARB != null) {
						Delegates.pglVertexAttrib1svARB(index, p_v);
						CallLog("glVertexAttrib1svARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib1svNV != null) {
						Delegates.pglVertexAttrib1svNV(index, p_v);
						CallLog("glVertexAttrib1svNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib1sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, double x, double y)
		{
			if        (Delegates.pglVertexAttrib2d != null) {
				Delegates.pglVertexAttrib2d(index, x, y);
				CallLog("glVertexAttrib2d({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2dARB != null) {
				Delegates.pglVertexAttrib2dARB(index, x, y);
				CallLog("glVertexAttrib2dARB({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2dNV != null) {
				Delegates.pglVertexAttrib2dNV(index, x, y);
				CallLog("glVertexAttrib2dNV({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttrib2d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttrib2dv != null) {
						Delegates.pglVertexAttrib2dv(index, p_v);
						CallLog("glVertexAttrib2dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2dvARB != null) {
						Delegates.pglVertexAttrib2dvARB(index, p_v);
						CallLog("glVertexAttrib2dvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2dvNV != null) {
						Delegates.pglVertexAttrib2dvNV(index, p_v);
						CallLog("glVertexAttrib2dvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib2dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, float x, float y)
		{
			if        (Delegates.pglVertexAttrib2f != null) {
				Delegates.pglVertexAttrib2f(index, x, y);
				CallLog("glVertexAttrib2f({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2fARB != null) {
				Delegates.pglVertexAttrib2fARB(index, x, y);
				CallLog("glVertexAttrib2fARB({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2fNV != null) {
				Delegates.pglVertexAttrib2fNV(index, x, y);
				CallLog("glVertexAttrib2fNV({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttrib2f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglVertexAttrib2fv != null) {
						Delegates.pglVertexAttrib2fv(index, p_v);
						CallLog("glVertexAttrib2fv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2fvARB != null) {
						Delegates.pglVertexAttrib2fvARB(index, p_v);
						CallLog("glVertexAttrib2fvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2fvNV != null) {
						Delegates.pglVertexAttrib2fvNV(index, p_v);
						CallLog("glVertexAttrib2fvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, Int16 x, Int16 y)
		{
			if        (Delegates.pglVertexAttrib2s != null) {
				Delegates.pglVertexAttrib2s(index, x, y);
				CallLog("glVertexAttrib2s({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2sARB != null) {
				Delegates.pglVertexAttrib2sARB(index, x, y);
				CallLog("glVertexAttrib2sARB({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttrib2sNV != null) {
				Delegates.pglVertexAttrib2sNV(index, x, y);
				CallLog("glVertexAttrib2sNV({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttrib2s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib2(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib2sv != null) {
						Delegates.pglVertexAttrib2sv(index, p_v);
						CallLog("glVertexAttrib2sv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2svARB != null) {
						Delegates.pglVertexAttrib2svARB(index, p_v);
						CallLog("glVertexAttrib2svARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib2svNV != null) {
						Delegates.pglVertexAttrib2svNV(index, p_v);
						CallLog("glVertexAttrib2svNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib2sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, double x, double y, double z)
		{
			if        (Delegates.pglVertexAttrib3d != null) {
				Delegates.pglVertexAttrib3d(index, x, y, z);
				CallLog("glVertexAttrib3d({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3dARB != null) {
				Delegates.pglVertexAttrib3dARB(index, x, y, z);
				CallLog("glVertexAttrib3dARB({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3dNV != null) {
				Delegates.pglVertexAttrib3dNV(index, x, y, z);
				CallLog("glVertexAttrib3dNV({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttrib3d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttrib3dv != null) {
						Delegates.pglVertexAttrib3dv(index, p_v);
						CallLog("glVertexAttrib3dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3dvARB != null) {
						Delegates.pglVertexAttrib3dvARB(index, p_v);
						CallLog("glVertexAttrib3dvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3dvNV != null) {
						Delegates.pglVertexAttrib3dvNV(index, p_v);
						CallLog("glVertexAttrib3dvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib3dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, float x, float y, float z)
		{
			if        (Delegates.pglVertexAttrib3f != null) {
				Delegates.pglVertexAttrib3f(index, x, y, z);
				CallLog("glVertexAttrib3f({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3fARB != null) {
				Delegates.pglVertexAttrib3fARB(index, x, y, z);
				CallLog("glVertexAttrib3fARB({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3fNV != null) {
				Delegates.pglVertexAttrib3fNV(index, x, y, z);
				CallLog("glVertexAttrib3fNV({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttrib3f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglVertexAttrib3fv != null) {
						Delegates.pglVertexAttrib3fv(index, p_v);
						CallLog("glVertexAttrib3fv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3fvARB != null) {
						Delegates.pglVertexAttrib3fvARB(index, p_v);
						CallLog("glVertexAttrib3fvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3fvNV != null) {
						Delegates.pglVertexAttrib3fvNV(index, p_v);
						CallLog("glVertexAttrib3fvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			if        (Delegates.pglVertexAttrib3s != null) {
				Delegates.pglVertexAttrib3s(index, x, y, z);
				CallLog("glVertexAttrib3s({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3sARB != null) {
				Delegates.pglVertexAttrib3sARB(index, x, y, z);
				CallLog("glVertexAttrib3sARB({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttrib3sNV != null) {
				Delegates.pglVertexAttrib3sNV(index, x, y, z);
				CallLog("glVertexAttrib3sNV({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttrib3s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib3(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib3sv != null) {
						Delegates.pglVertexAttrib3sv(index, p_v);
						CallLog("glVertexAttrib3sv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3svARB != null) {
						Delegates.pglVertexAttrib3svARB(index, p_v);
						CallLog("glVertexAttrib3svARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib3svNV != null) {
						Delegates.pglVertexAttrib3svNV(index, p_v);
						CallLog("glVertexAttrib3svNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib3sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Nbv != null) {
						Delegates.pglVertexAttrib4Nbv(index, p_v);
						CallLog("glVertexAttrib4Nbv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NbvARB != null) {
						Delegates.pglVertexAttrib4NbvARB(index, p_v);
						CallLog("glVertexAttrib4NbvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Nbv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Niv != null) {
						Delegates.pglVertexAttrib4Niv(index, p_v);
						CallLog("glVertexAttrib4Niv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NivARB != null) {
						Delegates.pglVertexAttrib4NivARB(index, p_v);
						CallLog("glVertexAttrib4NivARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Niv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Nsv != null) {
						Delegates.pglVertexAttrib4Nsv(index, p_v);
						CallLog("glVertexAttrib4Nsv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NsvARB != null) {
						Delegates.pglVertexAttrib4NsvARB(index, p_v);
						CallLog("glVertexAttrib4NsvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Nsv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:byte"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, byte x, byte y, byte z, byte w)
		{
			if        (Delegates.pglVertexAttrib4Nub != null) {
				Delegates.pglVertexAttrib4Nub(index, x, y, z, w);
				CallLog("glVertexAttrib4Nub({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4NubARB != null) {
				Delegates.pglVertexAttrib4NubARB(index, x, y, z, w);
				CallLog("glVertexAttrib4NubARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4ubNV != null) {
				Delegates.pglVertexAttrib4ubNV(index, x, y, z, w);
				CallLog("glVertexAttrib4ubNV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttrib4Nub (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Nubv != null) {
						Delegates.pglVertexAttrib4Nubv(index, p_v);
						CallLog("glVertexAttrib4Nubv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NubvARB != null) {
						Delegates.pglVertexAttrib4NubvARB(index, p_v);
						CallLog("glVertexAttrib4NubvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4ubvNV != null) {
						Delegates.pglVertexAttrib4ubvNV(index, p_v);
						CallLog("glVertexAttrib4ubvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Nubv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Nuiv != null) {
						Delegates.pglVertexAttrib4Nuiv(index, p_v);
						CallLog("glVertexAttrib4Nuiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NuivARB != null) {
						Delegates.pglVertexAttrib4NuivARB(index, p_v);
						CallLog("glVertexAttrib4NuivARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Nuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4N(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4Nusv != null) {
						Delegates.pglVertexAttrib4Nusv(index, p_v);
						CallLog("glVertexAttrib4Nusv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4NusvARB != null) {
						Delegates.pglVertexAttrib4NusvARB(index, p_v);
						CallLog("glVertexAttrib4NusvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4Nusv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4bv != null) {
						Delegates.pglVertexAttrib4bv(index, p_v);
						CallLog("glVertexAttrib4bv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4bvARB != null) {
						Delegates.pglVertexAttrib4bvARB(index, p_v);
						CallLog("glVertexAttrib4bvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4bv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, double x, double y, double z, double w)
		{
			if        (Delegates.pglVertexAttrib4d != null) {
				Delegates.pglVertexAttrib4d(index, x, y, z, w);
				CallLog("glVertexAttrib4d({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4dARB != null) {
				Delegates.pglVertexAttrib4dARB(index, x, y, z, w);
				CallLog("glVertexAttrib4dARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4dNV != null) {
				Delegates.pglVertexAttrib4dNV(index, x, y, z, w);
				CallLog("glVertexAttrib4dNV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttrib4d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4dv != null) {
						Delegates.pglVertexAttrib4dv(index, p_v);
						CallLog("glVertexAttrib4dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4dvARB != null) {
						Delegates.pglVertexAttrib4dvARB(index, p_v);
						CallLog("glVertexAttrib4dvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4dvNV != null) {
						Delegates.pglVertexAttrib4dvNV(index, p_v);
						CallLog("glVertexAttrib4dvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, float x, float y, float z, float w)
		{
			if        (Delegates.pglVertexAttrib4f != null) {
				Delegates.pglVertexAttrib4f(index, x, y, z, w);
				CallLog("glVertexAttrib4f({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4fARB != null) {
				Delegates.pglVertexAttrib4fARB(index, x, y, z, w);
				CallLog("glVertexAttrib4fARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4fNV != null) {
				Delegates.pglVertexAttrib4fNV(index, x, y, z, w);
				CallLog("glVertexAttrib4fNV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttrib4f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4fv != null) {
						Delegates.pglVertexAttrib4fv(index, p_v);
						CallLog("glVertexAttrib4fv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4fvARB != null) {
						Delegates.pglVertexAttrib4fvARB(index, p_v);
						CallLog("glVertexAttrib4fvARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4fvNV != null) {
						Delegates.pglVertexAttrib4fvNV(index, p_v);
						CallLog("glVertexAttrib4fvNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4iv != null) {
						Delegates.pglVertexAttrib4iv(index, p_v);
						CallLog("glVertexAttrib4iv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4ivARB != null) {
						Delegates.pglVertexAttrib4ivARB(index, p_v);
						CallLog("glVertexAttrib4ivARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			if        (Delegates.pglVertexAttrib4s != null) {
				Delegates.pglVertexAttrib4s(index, x, y, z, w);
				CallLog("glVertexAttrib4s({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4sARB != null) {
				Delegates.pglVertexAttrib4sARB(index, x, y, z, w);
				CallLog("glVertexAttrib4sARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttrib4sNV != null) {
				Delegates.pglVertexAttrib4sNV(index, x, y, z, w);
				CallLog("glVertexAttrib4sNV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttrib4s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4sv != null) {
						Delegates.pglVertexAttrib4sv(index, p_v);
						CallLog("glVertexAttrib4sv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4svARB != null) {
						Delegates.pglVertexAttrib4svARB(index, p_v);
						CallLog("glVertexAttrib4svARB({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4svNV != null) {
						Delegates.pglVertexAttrib4svNV(index, p_v);
						CallLog("glVertexAttrib4svNV({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4ub(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4ubv != null) {
						Delegates.pglVertexAttrib4ubv(index, p_v);
						CallLog("glVertexAttrib4ubv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4ubvARB != null) {
						Delegates.pglVertexAttrib4ubvARB(index, p_v);
						CallLog("glVertexAttrib4ubvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4ubv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4uiv != null) {
						Delegates.pglVertexAttrib4uiv(index, p_v);
						CallLog("glVertexAttrib4uiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4uivARB != null) {
						Delegates.pglVertexAttrib4uivARB(index, p_v);
						CallLog("glVertexAttrib4uivARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttrib4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					if        (Delegates.pglVertexAttrib4usv != null) {
						Delegates.pglVertexAttrib4usv(index, p_v);
						CallLog("glVertexAttrib4usv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttrib4usvARB != null) {
						Delegates.pglVertexAttrib4usvARB(index, p_v);
						CallLog("glVertexAttrib4usvARB({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttrib4usv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted 
		/// directly as fixed-point values (GL_FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglVertexAttribPointer != null) {
				Delegates.pglVertexAttribPointer(index, size, type, normalized, stride, pointer);
				CallLog("glVertexAttribPointer({0}, {1}, {2}, {3}, {4}, {5})", index, size, type, normalized, stride, pointer);
			} else if (Delegates.pglVertexAttribPointerARB != null) {
				Delegates.pglVertexAttribPointerARB(index, size, type, normalized, stride, pointer);
				CallLog("glVertexAttribPointerARB({0}, {1}, {2}, {3}, {4}, {5})", index, size, type, normalized, stride, pointer);
			} else
				throw new NotImplementedException("glVertexAttribPointer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (GL_TRUE) or converted 
		/// directly as fixed-point values (GL_FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, Object pointer)
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
