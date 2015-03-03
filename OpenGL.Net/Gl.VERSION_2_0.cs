
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
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int BLEND_EQUATION_RGB = 0x8009;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_ENABLED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_ATTRIB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
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
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FUNC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_FUNC = 0x8800;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_FAIL = 0x8801;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_FAIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_PASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

		/// <summary>
		/// Value of GL_MAX_DRAW_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_DRAW_BUFFERS = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER0 = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER1 = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER2 = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER3 = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER4 = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER5 = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER6 = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER7 = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER8 = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER9 = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER10 = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER11 = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER12 = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER13 = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER14 = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DRAW_BUFFER15 = 0x8834;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed")]
		public const int BLEND_EQUATION_ALPHA = 0x883D;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIBS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_VERTEX_ATTRIBS = 0x8869;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_NORMALIZED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FRAGMENT_SHADER = 0x8B30;

		/// <summary>
		/// Value of GL_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_SHADER = 0x8B31;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
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
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

		/// <summary>
		/// Value of GL_SHADER_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SHADER_TYPE = 0x8B4F;

		/// <summary>
		/// Value of GL_FLOAT_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FLOAT_VEC2 = 0x8B50;

		/// <summary>
		/// Value of GL_FLOAT_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FLOAT_VEC3 = 0x8B51;

		/// <summary>
		/// Value of GL_FLOAT_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FLOAT_VEC4 = 0x8B52;

		/// <summary>
		/// Value of GL_INT_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INT_VEC2 = 0x8B53;

		/// <summary>
		/// Value of GL_INT_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INT_VEC3 = 0x8B54;

		/// <summary>
		/// Value of GL_INT_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INT_VEC4 = 0x8B55;

		/// <summary>
		/// Value of GL_BOOL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BOOL = 0x8B56;

		/// <summary>
		/// Value of GL_BOOL_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BOOL_VEC2 = 0x8B57;

		/// <summary>
		/// Value of GL_BOOL_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BOOL_VEC3 = 0x8B58;

		/// <summary>
		/// Value of GL_BOOL_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BOOL_VEC4 = 0x8B59;

		/// <summary>
		/// Value of GL_FLOAT_MAT2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FLOAT_MAT2 = 0x8B5A;

		/// <summary>
		/// Value of GL_FLOAT_MAT3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int FLOAT_MAT3 = 0x8B5B;

		/// <summary>
		/// Value of GL_FLOAT_MAT4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
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
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLER_2D = 0x8B5E;

		/// <summary>
		/// Value of GL_SAMPLER_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SAMPLER_3D = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SAMPLER_2D_SHADOW = 0x8B62;

		/// <summary>
		/// Value of GL_DELETE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DELETE_STATUS = 0x8B80;

		/// <summary>
		/// Value of GL_COMPILE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int COMPILE_STATUS = 0x8B81;

		/// <summary>
		/// Value of GL_LINK_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int LINK_STATUS = 0x8B82;

		/// <summary>
		/// Value of GL_VALIDATE_STATUS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VALIDATE_STATUS = 0x8B83;

		/// <summary>
		/// Value of GL_INFO_LOG_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int INFO_LOG_LENGTH = 0x8B84;

		/// <summary>
		/// Value of GL_ATTACHED_SHADERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ATTACHED_SHADERS = 0x8B85;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ACTIVE_UNIFORMS = 0x8B86;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;

		/// <summary>
		/// Value of GL_SHADER_SOURCE_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SHADER_SOURCE_LENGTH = 0x8B88;

		/// <summary>
		/// Value of GL_ACTIVE_ATTRIBUTES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ACTIVE_ATTRIBUTES = 0x8B89;

		/// <summary>
		/// Value of GL_ACTIVE_ATTRIBUTE_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_DERIVATIVE_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

		/// <summary>
		/// Value of GL_SHADING_LANGUAGE_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SHADING_LANGUAGE_VERSION = 0x8B8C;

		/// <summary>
		/// Value of GL_CURRENT_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
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
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_REF = 0x8CA3;

		/// <summary>
		/// Value of GL_STENCIL_BACK_VALUE_MASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;

		/// <summary>
		/// Value of GL_STENCIL_BACK_WRITEMASK symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
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
		/// <remarks>
		/// The blend equations determines how a new pixel (the ''source'' color) is combined with a pixel already in the 
		/// framebuffer (the ''destination'' color). This function specifies one blend equation for the RGB-color components and one 
		/// blend equation for the alpha component.
		/// The blend equations use the source and destination blend factors specified by either Gl.BlendFunc or 
		/// Gl.BlendFuncSeparate. See Gl.BlendFunc or Gl.BlendFuncSeparate for a description of the various blend factors.
		/// In the equations that follow, source and destination color components are referred to as RsGsBsAs and RdGdBdAd, 
		/// respectively. The result color is referred to as RrGrBrAr. The source and destination blend factors are denoted sRsGsBsA 
		/// and dRdGdBdA, respectively. For these equations all color components are understood to have values in the range 01. Mode 
		/// RGB Components Alpha Component <see cref="Gl.FUNC_ADD"/>Rr=Rs⁢sR+Rd⁢dRGr=Gs⁢sG+Gd⁢dGBr=Bs⁢sB+Bd⁢dBAr=As⁢sA+Ad⁢dA<see 
		/// cref="Gl.FUNC_SUBTRACT"/>Rr=Rs⁢sR-Rd⁢dRGr=Gs⁢sG-Gd⁢dGBr=Bs⁢sB-Bd⁢dBAr=As⁢sA-Ad⁢dA<see 
		/// cref="Gl.FUNC_REVERSE_SUBTRACT"/>Rr=Rd⁢dR-Rs⁢sRGr=Gd⁢dG-Gs⁢sGBr=Bd⁢dB-Bs⁢sBAr=Ad⁢dA-As⁢sA<see 
		/// cref="Gl.MIN"/>Rr=min⁡RsRdGr=min⁡GsGdBr=min⁡BsBdAr=min⁡AsAd<see 
		/// cref="Gl.MAX"/>Rr=max⁡RsRdGr=max⁡GsGdBr=max⁡BsBdAr=max⁡AsAd
		/// The results of these equations are clamped to the range 01.
		/// The <see cref="Gl.MIN"/> and <see cref="Gl.MAX"/> equations are useful for applications that analyze image data (image 
		/// thresholding against a constant color, for example). The <see cref="Gl.FUNC_ADD"/> equation is useful for antialiasing 
		/// and transparency, among other things.
		/// Initially, both the RGB blend equation and the alpha blend equation are set to <see cref="Gl.FUNC_ADD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="modeRGB"/> or <paramref name="modeAlpha"/> is not 
		///   one of <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see 
		///   cref="Gl.MAX"/>, or <see cref="Gl.MIN"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendEquationSeparate"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_RGB"/>
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_ALPHA"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
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
		/// <remarks>
		/// The blend equations determines how a new pixel (the ''source'' color) is combined with a pixel already in the 
		/// framebuffer (the ''destination'' color). This function specifies one blend equation for the RGB-color components and one 
		/// blend equation for the alpha component.
		/// The blend equations use the source and destination blend factors specified by either Gl.BlendFunc or 
		/// Gl.BlendFuncSeparate. See Gl.BlendFunc or Gl.BlendFuncSeparate for a description of the various blend factors.
		/// In the equations that follow, source and destination color components are referred to as RsGsBsAs and RdGdBdAd, 
		/// respectively. The result color is referred to as RrGrBrAr. The source and destination blend factors are denoted sRsGsBsA 
		/// and dRdGdBdA, respectively. For these equations all color components are understood to have values in the range 01. Mode 
		/// RGB Components Alpha Component <see cref="Gl.FUNC_ADD"/>Rr=Rs⁢sR+Rd⁢dRGr=Gs⁢sG+Gd⁢dGBr=Bs⁢sB+Bd⁢dBAr=As⁢sA+Ad⁢dA<see 
		/// cref="Gl.FUNC_SUBTRACT"/>Rr=Rs⁢sR-Rd⁢dRGr=Gs⁢sG-Gd⁢dGBr=Bs⁢sB-Bd⁢dBAr=As⁢sA-Ad⁢dA<see 
		/// cref="Gl.FUNC_REVERSE_SUBTRACT"/>Rr=Rd⁢dR-Rs⁢sRGr=Gd⁢dG-Gs⁢sGBr=Bd⁢dB-Bs⁢sBAr=Ad⁢dA-As⁢sA<see 
		/// cref="Gl.MIN"/>Rr=min⁡RsRdGr=min⁡GsGdBr=min⁡BsBdAr=min⁡AsAd<see 
		/// cref="Gl.MAX"/>Rr=max⁡RsRdGr=max⁡GsGdBr=max⁡BsBdAr=max⁡AsAd
		/// The results of these equations are clamped to the range 01.
		/// The <see cref="Gl.MIN"/> and <see cref="Gl.MAX"/> equations are useful for applications that analyze image data (image 
		/// thresholding against a constant color, for example). The <see cref="Gl.FUNC_ADD"/> equation is useful for antialiasing 
		/// and transparency, among other things.
		/// Initially, both the RGB blend equation and the alpha blend equation are set to <see cref="Gl.FUNC_ADD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="modeRGB"/> or <paramref name="modeAlpha"/> is not 
		///   one of <see cref="Gl.FUNC_ADD"/>, <see cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see 
		///   cref="Gl.MAX"/>, or <see cref="Gl.MIN"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendEquationSeparate"/> is executed between the 
		///   execution of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_RGB"/>
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_ALPHA"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
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
		/// <remarks>
		/// glDrawBuffers and glNamedFramebufferDrawBuffers define an array of buffers into which outputs from the fragment shader 
		/// data will be written. If a fragment shader writes a value to one or more user defined output variables, then the value 
		/// of each variable will be written into the buffer specified at a location within bufs corresponding to the location 
		/// assigned to that user defined output. The draw buffer used for user defined outputs assigned to locations greater than 
		/// or equal to n is implicitly set to GL_NONE and any data written to such an output is discarded.
		/// For glDrawBuffers, the framebuffer object that is bound to the GL_DRAW_FRAMEBUFFER binding will be used. For 
		/// glNamedFramebufferDrawBuffers, framebuffer is the name of the framebuffer object. If framebuffer is zero, then the 
		/// default framebuffer is affected.
		/// The symbolic constants contained in bufs may be any of the following:
		/// Except for GL_NONE, the preceding symbolic constants may not appear more than once in bufs. The maximum number of draw 
		/// buffers supported is implementation dependent and can be queried by calling glGet with the argument GL_MAX_DRAW_BUFFERS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated by glNamedFramebufferDrawBuffers if framebuffer is not zero or the name of an 
		///   existing framebuffer object.
		/// - GL_INVALID_ENUM is generated if one of the values in bufs is not an accepted value.
		/// - GL_INVALID_ENUM is generated if the API call refers to the default framebuffer and one or more of the values in bufs is 
		///   one of the GL_COLOR_ATTACHMENTn tokens.
		/// - GL_INVALID_ENUM is generated if the API call refers to a framebuffer object and one or more of the values in bufs is 
		///   anything other than GL_NONE or one of the GL_COLOR_ATTACHMENTn tokens.
		/// - GL_INVALID_ENUM is generated if n is less than 0.
		/// - GL_INVALID_OPERATION is generated if a symbolic constant other than GL_NONE appears more than once in bufs.
		/// - GL_INVALID_OPERATION is generated if any of the entries in bufs (other than GL_NONE ) indicates a color buffer that does 
		///   not exist in the current GL context.
		/// - GL_INVALID_OPERATION is generated if any value in bufs is GL_BACK, and n is not one.
		/// - GL_INVALID_VALUE is generated if n is greater than GL_MAX_DRAW_BUFFERS.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_DRAW_BUFFERS
		/// - glGet with argument GL_DRAW_BUFFERi where i indicates the number of the draw buffer whose value is to be queried
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void DrawBuffers(Int32 n, int[] bufs)
		{
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
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// using GL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen. Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining, and constructive solid geometry rendering.
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the value in the stencil 
		/// buffer and a reference value. To enable and disable the test, call glEnable and glDisable with argument GL_STENCIL_TEST; 
		/// to control it, call glStencilFunc or glStencilFuncSeparate.
		/// There can be two separate sets of sfail, dpfail, and dppass parameters; one affects back-facing polygons, and the other 
		/// affects front-facing polygons as well as other non-polygon primitives. glStencilOp sets both front and back stencil 
		/// state to the same values, as if glStencilOpSeparate were called with face set to GL_FRONT_AND_BACK.
		/// glStencilOpSeparate takes three arguments that indicate what happens to the stored stencil value while stenciling is 
		/// enabled. If the stencil test fails, no change is made to the pixel's color or depth buffers, and sfail specifies what 
		/// happens to the stencil buffer contents. The following eight actions are possible.
		/// Stencil buffer values are treated as unsigned integers. When incremented and decremented, values are clamped to 0 and 
		/// 2n-1, where n is the value returned by querying GL_STENCIL_BITS.
		/// The other two arguments to glStencilOpSeparate specify stencil buffer actions that depend on whether subsequent depth 
		/// buffer tests succeed (dppass) or fail (dpfail) (see glDepthFunc). The actions are specified using the same eight 
		/// symbolic constants as sfail. Note that dpfail is ignored when there is no depth buffer, or when the depth buffer is not 
		/// enabled. In these cases, sfail and dppass specify stencil action when the stencil test fails and passes, respectively.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if face is any value other than GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
		/// - GL_INVALID_ENUM is generated if sfail, dpfail, or dppass is any value other than the eight defined constant values.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FAIL, GL_STENCIL_PASS_DEPTH_PASS, GL_STENCIL_PASS_DEPTH_FAIL, GL_STENCIL_BACK_FAIL, 
		///   GL_STENCIL_BACK_PASS_DEPTH_PASS, GL_STENCIL_BACK_PASS_DEPTH_FAIL, or GL_STENCIL_BITS
		/// - glIsEnabled with argument GL_STENCIL_TEST
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
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
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// using GL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen. Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining, and constructive solid geometry rendering.
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the value in the stencil 
		/// buffer and a reference value. To enable and disable the test, call glEnable and glDisable with argument GL_STENCIL_TEST; 
		/// to control it, call glStencilFunc or glStencilFuncSeparate.
		/// There can be two separate sets of sfail, dpfail, and dppass parameters; one affects back-facing polygons, and the other 
		/// affects front-facing polygons as well as other non-polygon primitives. glStencilOp sets both front and back stencil 
		/// state to the same values, as if glStencilOpSeparate were called with face set to GL_FRONT_AND_BACK.
		/// glStencilOpSeparate takes three arguments that indicate what happens to the stored stencil value while stenciling is 
		/// enabled. If the stencil test fails, no change is made to the pixel's color or depth buffers, and sfail specifies what 
		/// happens to the stencil buffer contents. The following eight actions are possible.
		/// Stencil buffer values are treated as unsigned integers. When incremented and decremented, values are clamped to 0 and 
		/// 2n-1, where n is the value returned by querying GL_STENCIL_BITS.
		/// The other two arguments to glStencilOpSeparate specify stencil buffer actions that depend on whether subsequent depth 
		/// buffer tests succeed (dppass) or fail (dpfail) (see glDepthFunc). The actions are specified using the same eight 
		/// symbolic constants as sfail. Note that dpfail is ignored when there is no depth buffer, or when the depth buffer is not 
		/// enabled. In these cases, sfail and dppass specify stencil action when the stencil test fails and passes, respectively.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if face is any value other than GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
		/// - GL_INVALID_ENUM is generated if sfail, dpfail, or dppass is any value other than the eight defined constant values.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FAIL, GL_STENCIL_PASS_DEPTH_PASS, GL_STENCIL_PASS_DEPTH_FAIL, GL_STENCIL_BACK_FAIL, 
		///   GL_STENCIL_BACK_PASS_DEPTH_PASS, GL_STENCIL_BACK_PASS_DEPTH_FAIL, or GL_STENCIL_BITS
		/// - glIsEnabled with argument GL_STENCIL_TEST
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
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
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// using GL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen. Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining, and constructive solid geometry rendering.
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the reference value and 
		/// the value in the stencil buffer. To enable and disable the test, call glEnable and glDisable with argument 
		/// GL_STENCIL_TEST. To specify actions based on the outcome of the stencil test, call glStencilOp or glStencilOpSeparate.
		/// There can be two separate sets of func, ref, and mask parameters; one affects back-facing polygons, and the other 
		/// affects front-facing polygons as well as other non-polygon primitives. glStencilFunc sets both front and back stencil 
		/// state to the same values, as if glStencilFuncSeparate were called with face set to GL_FRONT_AND_BACK.
		/// func is a symbolic constant that determines the stencil comparison function. It accepts one of eight values, shown in 
		/// the following list. ref is an integer reference value that is used in the stencil comparison. It is clamped to the range 
		/// 02n-1, where n is the number of bitplanes in the stencil buffer. mask is bitwise ANDed with both the reference value and 
		/// the stored stencil value, with the ANDed values participating in the comparison.
		/// If stencil represents the value stored in the corresponding stencil buffer location, the following list shows the effect 
		/// of each comparison function that can be specified by func. Only if the comparison succeeds is the pixel passed through 
		/// to the next stage in the rasterization process (see glStencilOp). All tests treat stencil values as unsigned integers in 
		/// the range 02n-1, where n is the number of bitplanes in the stencil buffer.
		/// The following values are accepted by func:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not one of the eight accepted values.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FUNC, GL_STENCIL_VALUE_MASK, GL_STENCIL_REF, GL_STENCIL_BACK_FUNC, 
		///   GL_STENCIL_BACK_VALUE_MASK, GL_STENCIL_BACK_REF, or GL_STENCIL_BITS
		/// - glIsEnabled with argument GL_STENCIL_TEST
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
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
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// using GL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen. Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining, and constructive solid geometry rendering.
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the reference value and 
		/// the value in the stencil buffer. To enable and disable the test, call glEnable and glDisable with argument 
		/// GL_STENCIL_TEST. To specify actions based on the outcome of the stencil test, call glStencilOp or glStencilOpSeparate.
		/// There can be two separate sets of func, ref, and mask parameters; one affects back-facing polygons, and the other 
		/// affects front-facing polygons as well as other non-polygon primitives. glStencilFunc sets both front and back stencil 
		/// state to the same values, as if glStencilFuncSeparate were called with face set to GL_FRONT_AND_BACK.
		/// func is a symbolic constant that determines the stencil comparison function. It accepts one of eight values, shown in 
		/// the following list. ref is an integer reference value that is used in the stencil comparison. It is clamped to the range 
		/// 02n-1, where n is the number of bitplanes in the stencil buffer. mask is bitwise ANDed with both the reference value and 
		/// the stored stencil value, with the ANDed values participating in the comparison.
		/// If stencil represents the value stored in the corresponding stencil buffer location, the following list shows the effect 
		/// of each comparison function that can be specified by func. Only if the comparison succeeds is the pixel passed through 
		/// to the next stage in the rasterization process (see glStencilOp). All tests treat stencil values as unsigned integers in 
		/// the range 02n-1, where n is the number of bitplanes in the stencil buffer.
		/// The following values are accepted by func:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not one of the eight accepted values.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FUNC, GL_STENCIL_VALUE_MASK, GL_STENCIL_REF, GL_STENCIL_BACK_FUNC, 
		///   GL_STENCIL_BACK_VALUE_MASK, GL_STENCIL_BACK_REF, or GL_STENCIL_BITS
		/// - glIsEnabled with argument GL_STENCIL_TEST
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
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
		/// <remarks>
		/// glStencilMaskSeparate controls the writing of individual bits in the stencil planes. The least significant n bits of 
		/// mask, where n is the number of bits in the stencil buffer, specify a mask. Where a 1 appears in the mask, it's possible 
		/// to write to the corresponding bit in the stencil buffer. Where a 0 appears, the corresponding bit is write-protected. 
		/// Initially, all bits are enabled for writing.
		/// There can be two separate mask writemasks; one affects back-facing polygons, and the other affects front-facing polygons 
		/// as well as other non-polygon primitives. glStencilMask sets both front and back stencil writemasks to the same values, 
		/// as if glStencilMaskSeparate were called with face set to GL_FRONT_AND_BACK.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if face is not one of the accepted tokens.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_WRITEMASK, GL_STENCIL_BACK_WRITEMASK, or GL_STENCIL_BITS
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
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
		/// <remarks>
		/// In order to create a complete shader program, there must be a way to specify the list of things that will be linked 
		/// together. Program objects provide this mechanism. Shaders that are to be linked together in a program object must first 
		/// be attached to that program object. glAttachShader attaches the shader object specified by shader to the program object 
		/// specified by program. This indicates that shader will be included in link operations that will be performed on program.
		/// All operations that can be performed on a shader object are valid whether or not the shader object is attached to a 
		/// program object. It is permissible to attach a shader object to a program object before source code has been loaded into 
		/// the shader object or before the shader object has been compiled. It is permissible to attach multiple shader objects of 
		/// the same type because each may contain a portion of the complete shader. It is also permissible to attach a shader 
		/// object to more than one program object. If a shader object is deleted while it is attached to a program object, it will 
		/// be flagged for deletion, and deletion will not occur until glDetachShader is called to detach it from all program 
		/// objects to which it is attached.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if either program or shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// - GL_INVALID_OPERATION is generated if shader is already attached to program.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetAttachedShaders with the handle of a valid program object
		/// - glGetShaderInfoLog
		/// - glGetShaderSource
		/// - glIsProgram
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glBindAttribLocation is used to associate a user-defined attribute variable in the program object specified by program 
		/// with a generic vertex attribute index. The name of the user-defined attribute variable is passed as a null terminated 
		/// string in name. The generic vertex attribute index to be bound to this variable is specified by index. When program is 
		/// made part of current state, values provided via the generic vertex attribute index will modify the value of the 
		/// user-defined attribute variable specified by name.
		/// If name refers to a matrix attribute variable, index refers to the first column of the matrix. Other matrix columns are 
		/// then automatically bound to locations index+1 for a matrix of type mat2; index+1 and index+2 for a matrix of type mat3; 
		/// and index+1, index+2, and index+3 for a matrix of type mat4.
		/// This command makes it possible for vertex shaders to use descriptive names for attribute variables rather than generic 
		/// variables that are numbered from zero to the value of GL_MAX_VERTEX_ATTRIBS minus one. The values sent to each generic 
		/// attribute index are part of current state. If a different program object is made current by calling glUseProgram, the 
		/// generic vertex attributes are tracked in such a way that the same values will be observed by attributes in the new 
		/// program object that are also bound to index.
		/// Attribute variable name-to-generic attribute index bindings for a program object can be explicitly assigned at any time 
		/// by calling glBindAttribLocation. Attribute bindings do not go into effect until glLinkProgram is called. After a program 
		/// object has been linked successfully, the index values for generic attributes remain fixed (and their values can be 
		/// queried) until the next link command occurs.
		/// Any attribute binding that occurs after the program object has been linked will not take effect until the next time the 
		/// program object is linked.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_OPERATION is generated if name starts with the reserved prefix "gl_".
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetActiveAttrib with argument program
		/// - glGetAttribLocation with arguments program and name
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glCompileShader compiles the source code strings that have been stored in the shader object specified by shader.
		/// The compilation status will be stored as part of the shader object's state. This value will be set to GL_TRUE if the 
		/// shader was compiled without errors and is ready for use, and GL_FALSE otherwise. It can be queried by calling 
		/// glGetShader with arguments shader and GL_COMPILE_STATUS.
		/// Compilation of a shader can fail for a number of reasons as specified by the OpenGL Shading Language Specification. 
		/// Whether or not the compilation was successful, information about the compilation can be obtained from the shader 
		/// object's information log by calling glGetShaderInfoLog.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShaderInfoLog with argument shader
		/// - glGetShader with arguments shader and GL_COMPILE_STATUS
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glCreateProgram creates an empty program object and returns a non-zero value by which it can be referenced. A program 
		/// object is an object to which shader objects can be attached. This provides a mechanism to specify the shader objects 
		/// that will be linked to create a program. It also provides a means for checking the compatibility of the shaders that 
		/// will be used to create a program (for instance, checking the compatibility between a vertex shader and a fragment 
		/// shader). When no longer needed as part of a program object, shader objects can be detached.
		/// One or more executables are created in a program object by successfully attaching shader objects to it with 
		/// glAttachShader, successfully compiling the shader objects with glCompileShader, and successfully linking the program 
		/// object with glLinkProgram. These executables are made part of current state when glUseProgram is called. Program objects 
		/// can be deleted by calling glDeleteProgram. The memory associated with the program object will be deleted when it is no 
		/// longer part of current rendering state for any context.
		/// <para>
		/// The following errors can be generated:
		/// - This function returns 0 if an error occurs creating the program object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with a valid program object and the index of an active attribute variable
		/// - glGetActiveUniform with a valid program object and the index of an active uniform variable
		/// - glGetAttachedShaders with a valid program object
		/// - glGetAttribLocation with a valid program object and the name of an attribute variable
		/// - glGetProgram with a valid program object and the parameter to be queried
		/// - glGetProgramInfoLog with a valid program object
		/// - glGetUniform with a valid program object and the location of a uniform variable
		/// - glGetUniformLocation with a valid program object and the name of a uniform variable
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glCreateShader creates an empty shader object and returns a non-zero value by which it can be referenced. A shader 
		/// object is used to maintain the source code strings that define a shader. shaderType indicates the type of shader to be 
		/// created. Five types of shader are supported. A shader of type GL_COMPUTE_SHADER is a shader that is intended to run on 
		/// the programmable compute processor. A shader of type GL_VERTEX_SHADER is a shader that is intended to run on the 
		/// programmable vertex processor. A shader of type GL_TESS_CONTROL_SHADER is a shader that is intended to run on the 
		/// programmable tessellation processor in the control stage. A shader of type GL_TESS_EVALUATION_SHADER is a shader that is 
		/// intended to run on the programmable tessellation processor in the evaluation stage. A shader of type GL_GEOMETRY_SHADER 
		/// is a shader that is intended to run on the programmable geometry processor. A shader of type GL_FRAGMENT_SHADER is a 
		/// shader that is intended to run on the programmable fragment processor.
		/// When created, a shader object's GL_SHADER_TYPE parameter is set to either GL_COMPUTE_SHADER, GL_VERTEX_SHADER, 
		/// GL_TESS_CONTROL_SHADER, GL_TESS_EVALUATION_SHADER, GL_GEOMETRY_SHADER or GL_FRAGMENT_SHADER, depending on the value of 
		/// shaderType.
		/// <para>
		/// The following errors can be generated:
		/// - This function returns 0 if an error occurs creating the shader object.
		/// - GL_INVALID_ENUM is generated if shaderType is not an accepted value.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShader with a valid shader object and the parameter to be queried
		/// - glGetShaderInfoLog with a valid shader object
		/// - glGetShaderSource with a valid shader object
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glDeleteProgram frees the memory and invalidates the name associated with the program object specified by program. This 
		/// command effectively undoes the effects of a call to glCreateProgram.
		/// If a program object is in use as part of current rendering state, it will be flagged for deletion, but it will not be 
		/// deleted until it is no longer part of current state for any rendering context. If a program object to be deleted has 
		/// shader objects attached to it, those shader objects will be automatically detached but not deleted unless they have 
		/// already been flagged for deletion by a previous call to glDeleteShader. A value of 0 for program will be silently 
		/// ignored.
		/// To determine whether a program object has been flagged for deletion, call glGetProgram with arguments program and 
		/// GL_DELETE_STATUS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_CURRENT_PROGRAM
		/// - glGetProgram with arguments program and GL_DELETE_STATUS
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glDeleteShader frees the memory and invalidates the name associated with the shader object specified by shader. This 
		/// command effectively undoes the effects of a call to glCreateShader.
		/// If a shader object to be deleted is attached to a program object, it will be flagged for deletion, but it will not be 
		/// deleted until it is no longer attached to any program object, for any rendering context (i.e., it must be detached from 
		/// wherever it was attached before it will be deleted). A value of 0 for shader will be silently ignored.
		/// To determine whether an object has been flagged for deletion, call glGetShader with arguments shader and 
		/// GL_DELETE_STATUS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetAttachedShaders with the program object to be queried
		/// - glGetShader with arguments shader and GL_DELETE_STATUS
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glDetachShader detaches the shader object specified by shader from the program object specified by program. This command 
		/// can be used to undo the effect of the command glAttachShader.
		/// If shader has already been flagged for deletion by a call to glDeleteShader and it is not attached to any other program 
		/// object, it will be deleted after it has been detached.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if either program or shader is a value that was not generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// - GL_INVALID_OPERATION is generated if shader is not attached to program.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetAttachedShaders with the handle of a valid program object
		/// - glGetShader with arguments shader and GL_DELETE_STATUS
		/// - glIsProgram
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
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
		/// <remarks>
		/// glEnableVertexAttribArray and glEnableVertexArrayAttrib enable the generic vertex attribute array specified by index. 
		/// glEnableVertexAttribArray uses currently bound vertex array object for the operation, whereas glEnableVertexArrayAttrib 
		/// updates state of the vertex array object with ID vaobj.
		/// glDisableVertexAttribArray and glDisableVertexArrayAttrib disable the generic vertex attribute array specified by index. 
		/// glDisableVertexAttribArray uses currently bound vertex array object for the operation, whereas 
		/// glDisableVertexArrayAttrib updates state of the vertex array object with ID vaobj.
		/// By default, all client-side capabilities are disabled, including all generic vertex attribute arrays. If enabled, the 
		/// values in the generic vertex attribute array will be accessed and used for rendering when calls are made to vertex array 
		/// commands such as glDrawArrays, glDrawElements, glDrawRangeElements, glMultiDrawElements, or glMultiDrawArrays.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glEnableVertexAttribArray and glDisableVertexAttribArray if no vertex array object 
		///   is bound.
		/// - GL_INVALID_OPERATION is generated by glEnableVertexArrayAttrib and glDisableVertexArrayAttrib if vaobj is not the name 
		///   of an existing vertex array object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glEnableVertexAttribArray and glEnableVertexArrayAttrib enable the generic vertex attribute array specified by index. 
		/// glEnableVertexAttribArray uses currently bound vertex array object for the operation, whereas glEnableVertexArrayAttrib 
		/// updates state of the vertex array object with ID vaobj.
		/// glDisableVertexAttribArray and glDisableVertexArrayAttrib disable the generic vertex attribute array specified by index. 
		/// glDisableVertexAttribArray uses currently bound vertex array object for the operation, whereas 
		/// glDisableVertexArrayAttrib updates state of the vertex array object with ID vaobj.
		/// By default, all client-side capabilities are disabled, including all generic vertex attribute arrays. If enabled, the 
		/// values in the generic vertex attribute array will be accessed and used for rendering when calls are made to vertex array 
		/// commands such as glDrawArrays, glDrawElements, glDrawRangeElements, glMultiDrawElements, or glMultiDrawArrays.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glEnableVertexAttribArray and glDisableVertexAttribArray if no vertex array object 
		///   is bound.
		/// - GL_INVALID_OPERATION is generated by glEnableVertexArrayAttrib and glDisableVertexArrayAttrib if vaobj is not the name 
		///   of an existing vertex array object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetActiveAttrib returns information about an active attribute variable in the program object specified by program. The 
		/// number of active attributes can be obtained by calling glGetProgram with the value GL_ACTIVE_ATTRIBUTES. A value of 0 
		/// for index selects the first active attribute variable. Permissible values for index range from zero to the number of 
		/// active attribute variables minus one.
		/// A vertex shader may use either built-in attribute variables, user-defined attribute variables, or both. Built-in 
		/// attribute variables have a prefix of "gl_" and reference conventional OpenGL vertex attribtes (e.g., gl_Vertex, 
		/// gl_Normal, etc., see the OpenGL Shading Language specification for a complete list.) User-defined attribute variables 
		/// have arbitrary names and obtain their values through numbered generic vertex attributes. An attribute variable (either 
		/// built-in or user-defined) is considered active if it is determined during the link operation that it may be accessed 
		/// during program execution. Therefore, program should have previously been the target of a call to glLinkProgram, but it 
		/// is not necessary for it to have been linked successfully.
		/// The size of the character buffer required to store the longest attribute variable name in program can be obtained by 
		/// calling glGetProgram with the value GL_ACTIVE_ATTRIBUTE_MAX_LENGTH. This value should be used to allocate a buffer of 
		/// sufficient size to store the returned attribute name. The size of this character buffer is passed in bufSize, and a 
		/// pointer to this character buffer is passed in name.
		/// glGetActiveAttrib returns the name of the attribute variable indicated by index, storing it in the character buffer 
		/// specified by name. The string returned will be null terminated. The actual number of characters written into this buffer 
		/// is returned in length, and this count does not include the null termination character. If the length of the returned 
		/// string is not required, a value of NULL can be passed in the length argument.
		/// The type argument specifies a pointer to a variable into which the attribute variable's data type will be written. The 
		/// symbolic constants GL_FLOAT, GL_FLOAT_VEC2, GL_FLOAT_VEC3, GL_FLOAT_VEC4, GL_FLOAT_MAT2, GL_FLOAT_MAT3, GL_FLOAT_MAT4, 
		/// GL_FLOAT_MAT2x3, GL_FLOAT_MAT2x4, GL_FLOAT_MAT3x2, GL_FLOAT_MAT3x4, GL_FLOAT_MAT4x2, GL_FLOAT_MAT4x3, GL_INT, 
		/// GL_INT_VEC2, GL_INT_VEC3, GL_INT_VEC4, GL_UNSIGNED_INT, GL_UNSIGNED_INT_VEC2, GL_UNSIGNED_INT_VEC3, 
		/// GL_UNSIGNED_INT_VEC4, GL_DOUBLE, GL_DOUBLE_VEC2, GL_DOUBLE_VEC3, GL_DOUBLE_VEC4, GL_DOUBLE_MAT2, GL_DOUBLE_MAT3, 
		/// GL_DOUBLE_MAT4, GL_DOUBLE_MAT2x3, GL_DOUBLE_MAT2x4, GL_DOUBLE_MAT3x2, GL_DOUBLE_MAT3x4, GL_DOUBLE_MAT4x2, or 
		/// GL_DOUBLE_MAT4x3 may be returned. The size argument will return the size of the attribute, in units of the type returned 
		/// in type.
		/// The list of active attribute variables may include both built-in attribute variables (which begin with the prefix "gl_") 
		/// as well as user-defined attribute variable names.
		/// This function will return as much information as it can about the specified active attribute variable. If no information 
		/// is available, length will be 0, and name will be an empty string. This situation could occur if this function is called 
		/// after a link operation that failed. If an error occurs, the return values length, size, type, and name will be 
		/// unmodified.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of active attribute variables in program.
		/// - GL_INVALID_VALUE is generated if bufSize is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS.
		/// - glGetProgram with argument GL_ACTIVE_ATTRIBUTES or GL_ACTIVE_ATTRIBUTE_MAX_LENGTH.
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetActiveUniform returns information about an active uniform variable in the program object specified by program. The 
		/// number of active uniform variables can be obtained by calling glGetProgram with the value GL_ACTIVE_UNIFORMS. A value of 
		/// 0 for index selects the first active uniform variable. Permissible values for index range from zero to the number of 
		/// active uniform variables minus one.
		/// Shaders may use either built-in uniform variables, user-defined uniform variables, or both. Built-in uniform variables 
		/// have a prefix of "gl_" and reference existing OpenGL state or values derived from such state (e.g., 
		/// gl_DepthRangeParameters, see the OpenGL Shading Language specification for a complete list.) User-defined uniform 
		/// variables have arbitrary names and obtain their values from the application through calls to glUniform. A uniform 
		/// variable (either built-in or user-defined) is considered active if it is determined during the link operation that it 
		/// may be accessed during program execution. Therefore, program should have previously been the target of a call to 
		/// glLinkProgram, but it is not necessary for it to have been linked successfully.
		/// The size of the character buffer required to store the longest uniform variable name in program can be obtained by 
		/// calling glGetProgram with the value GL_ACTIVE_UNIFORM_MAX_LENGTH. This value should be used to allocate a buffer of 
		/// sufficient size to store the returned uniform variable name. The size of this character buffer is passed in bufSize, and 
		/// a pointer to this character buffer is passed in name.
		/// glGetActiveUniform returns the name of the uniform variable indicated by index, storing it in the character buffer 
		/// specified by name. The string returned will be null terminated. The actual number of characters written into this buffer 
		/// is returned in length, and this count does not include the null termination character. If the length of the returned 
		/// string is not required, a value of NULL can be passed in the length argument.
		/// The type argument will return a pointer to the uniform variable's data type. The symbolic constants returned for uniform 
		/// types are shown in the table below. Returned Symbolic Contant Shader Uniform Type 
		/// GL_FLOATfloatGL_FLOAT_VEC2vec2GL_FLOAT_VEC3vec3GL_FLOAT_VEC4vec4GL_DOUBLEdoubleGL_DOUBLE_VEC2dvec2GL_DOUBLE_VEC3dvec3GL_DOUBLE_VEC4dvec4GL_INTintGL_INT_VEC2ivec2GL_INT_VEC3ivec3GL_INT_VEC4ivec4GL_UNSIGNED_INTunsigned 
		/// intGL_UNSIGNED_INT_VEC2uvec2GL_UNSIGNED_INT_VEC3uvec3GL_UNSIGNED_INT_VEC4uvec4GL_BOOLboolGL_BOOL_VEC2bvec2GL_BOOL_VEC3bvec3GL_BOOL_VEC4bvec4GL_FLOAT_MAT2mat2GL_FLOAT_MAT3mat3GL_FLOAT_MAT4mat4GL_FLOAT_MAT2x3mat2x3GL_FLOAT_MAT2x4mat2x4GL_FLOAT_MAT3x2mat3x2GL_FLOAT_MAT3x4mat3x4GL_FLOAT_MAT4x2mat4x2GL_FLOAT_MAT4x3mat4x3GL_DOUBLE_MAT2dmat2GL_DOUBLE_MAT3dmat3GL_DOUBLE_MAT4dmat4GL_DOUBLE_MAT2x3dmat2x3GL_DOUBLE_MAT2x4dmat2x4GL_DOUBLE_MAT3x2dmat3x2GL_DOUBLE_MAT3x4dmat3x4GL_DOUBLE_MAT4x2dmat4x2GL_DOUBLE_MAT4x3dmat4x3GL_SAMPLER_1Dsampler1DGL_SAMPLER_2Dsampler2DGL_SAMPLER_3Dsampler3DGL_SAMPLER_CUBEsamplerCubeGL_SAMPLER_1D_SHADOWsampler1DShadowGL_SAMPLER_2D_SHADOWsampler2DShadowGL_SAMPLER_1D_ARRAYsampler1DArrayGL_SAMPLER_2D_ARRAYsampler2DArrayGL_SAMPLER_1D_ARRAY_SHADOWsampler1DArrayShadowGL_SAMPLER_2D_ARRAY_SHADOWsampler2DArrayShadowGL_SAMPLER_2D_MULTISAMPLEsampler2DMSGL_SAMPLER_2D_MULTISAMPLE_ARRAYsampler2DMSArrayGL_SAMPLER_CUBE_SHADOWsamplerCubeShadowGL_SAMPLER_BUFFERsamplerBufferGL_SAMPLER_2D_RECTsampler2DRectGL_SAMPLER_2D_RECT_SHADOWsampler2DRectShadowGL_INT_SAMPLER_1Disampler1DGL_INT_SAMPLER_2Disampler2DGL_INT_SAMPLER_3Disampler3DGL_INT_SAMPLER_CUBEisamplerCubeGL_INT_SAMPLER_1D_ARRAYisampler1DArrayGL_INT_SAMPLER_2D_ARRAYisampler2DArrayGL_INT_SAMPLER_2D_MULTISAMPLEisampler2DMSGL_INT_SAMPLER_2D_MULTISAMPLE_ARRAYisampler2DMSArrayGL_INT_SAMPLER_BUFFERisamplerBufferGL_INT_SAMPLER_2D_RECTisampler2DRectGL_UNSIGNED_INT_SAMPLER_1Dusampler1DGL_UNSIGNED_INT_SAMPLER_2Dusampler2DGL_UNSIGNED_INT_SAMPLER_3Dusampler3DGL_UNSIGNED_INT_SAMPLER_CUBEusamplerCubeGL_UNSIGNED_INT_SAMPLER_1D_ARRAYusampler2DArrayGL_UNSIGNED_INT_SAMPLER_2D_ARRAYusampler2DArrayGL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLEusampler2DMSGL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAYusampler2DMSArrayGL_UNSIGNED_INT_SAMPLER_BUFFERusamplerBufferGL_UNSIGNED_INT_SAMPLER_2D_RECTusampler2DRectGL_IMAGE_1Dimage1DGL_IMAGE_2Dimage2DGL_IMAGE_3Dimage3DGL_IMAGE_2D_RECTimage2DRectGL_IMAGE_CUBEimageCubeGL_IMAGE_BUFFERimageBufferGL_IMAGE_1D_ARRAYimage1DArrayGL_IMAGE_2D_ARRAYimage2DArrayGL_IMAGE_2D_MULTISAMPLEimage2DMSGL_IMAGE_2D_MULTISAMPLE_ARRAYimage2DMSArrayGL_INT_IMAGE_1Diimage1DGL_INT_IMAGE_2Diimage2DGL_INT_IMAGE_3Diimage3DGL_INT_IMAGE_2D_RECTiimage2DRectGL_INT_IMAGE_CUBEiimageCubeGL_INT_IMAGE_BUFFERiimageBufferGL_INT_IMAGE_1D_ARRAYiimage1DArrayGL_INT_IMAGE_2D_ARRAYiimage2DArrayGL_INT_IMAGE_2D_MULTISAMPLEiimage2DMSGL_INT_IMAGE_2D_MULTISAMPLE_ARRAYiimage2DMSArrayGL_UNSIGNED_INT_IMAGE_1Duimage1DGL_UNSIGNED_INT_IMAGE_2Duimage2DGL_UNSIGNED_INT_IMAGE_3Duimage3DGL_UNSIGNED_INT_IMAGE_2D_RECTuimage2DRectGL_UNSIGNED_INT_IMAGE_CUBEuimageCubeGL_UNSIGNED_INT_IMAGE_BUFFERuimageBufferGL_UNSIGNED_INT_IMAGE_1D_ARRAYuimage1DArrayGL_UNSIGNED_INT_IMAGE_2D_ARRAYuimage2DArrayGL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLEuimage2DMSGL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAYuimage2DMSArrayGL_UNSIGNED_INT_ATOMIC_COUNTERatomic_uint
		/// If one or more elements of an array are active, the name of the array is returned in name, the type is returned in type, 
		/// and the size parameter returns the highest array element index used, plus one, as determined by the compiler and/or 
		/// linker. Only one active uniform variable will be reported for a uniform array.
		/// Uniform variables that are declared as structures or arrays of structures will not be returned directly by this 
		/// function. Instead, each of these uniform variables will be reduced to its fundamental components containing the "." and 
		/// "[]" operators such that each of the names is valid as an argument to glGetUniformLocation. Each of these reduced 
		/// uniform variables is counted as one active uniform variable and is assigned an index. A valid name cannot be a 
		/// structure, an array of structures, or a subcomponent of a vector or matrix.
		/// The size of the uniform variable will be returned in size. Uniform variables other than arrays will have a size of 1. 
		/// Structures and arrays of structures will be reduced as described earlier, such that each of the names returned will be a 
		/// data type in the earlier list. If this reduction results in an array, the size returned will be as described for uniform 
		/// arrays; otherwise, the size returned will be 1.
		/// The list of active uniform variables may include both built-in uniform variables (which begin with the prefix "gl_") as 
		/// well as user-defined uniform variable names.
		/// This function will return as much information as it can about the specified active uniform variable. If no information 
		/// is available, length will be 0, and name will be an empty string. This situation could occur if this function is called 
		/// after a link operation that failed. If an error occurs, the return values length, size, type, and name will be 
		/// unmodified.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of active uniform variables in program.
		/// - GL_INVALID_VALUE is generated if bufSize is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_UNIFORM_COMPONENTS, GL_MAX_GEOMETRY_UNIFORM_COMPONENTS, 
		///   GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS, GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS, GL_MAX_FRAGMENT_UNIFORM_COMPONENTS.
		/// - glGetProgram with argument GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH.
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glGetAttachedShaders returns the names of the shader objects attached to program. The names of shader objects that are 
		/// attached to program will be returned in shaders. The actual number of shader names written into shaders is returned in 
		/// count. If no shader objects are attached to program, count is set to 0. The maximum number of shader names that may be 
		/// returned in shaders is specified by maxCount.
		/// If the number of names actually returned is not required (for instance, if it has just been obtained by calling 
		/// glGetProgram), a value of NULL may be passed for count. If no shader objects are attached to program, a value of 0 will 
		/// be returned in count. The actual number of attached shaders can be obtained by calling glGetProgram with the value 
		/// GL_ATTACHED_SHADERS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_VALUE is generated if maxCount is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgram with argument GL_ATTACHED_SHADERS
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		public static void GetAttachedShaders(UInt32 program, Int32 maxCount, out Int32 count, UInt32[] shaders)
		{
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
		/// <remarks>
		/// glGetAttribLocation queries the previously linked program object specified by program for the attribute variable 
		/// specified by name and returns the index of the generic vertex attribute that is bound to that attribute variable. If 
		/// name is a matrix attribute variable, the index of the first column of the matrix is returned. If the named attribute 
		/// variable is not an active attribute in the specified program object or if name starts with the reserved prefix "gl_", a 
		/// value of -1 is returned.
		/// The association between an attribute variable name and a generic attribute index can be specified at any time by calling 
		/// glBindAttribLocation. Attribute bindings do not go into effect until glLinkProgram is called. After a program object has 
		/// been linked successfully, the index values for attribute variables remain fixed until the next link command occurs. The 
		/// attribute values can only be queried after a link if the link was successful. glGetAttribLocation returns the binding 
		/// that actually went into effect the last time glLinkProgram was called for the specified program object. Attribute 
		/// bindings that have been specified since the last link operation are not returned by glGetAttribLocation.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveAttrib with argument program and the index of an active attribute
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetProgram returns in params the value of a parameter for a specific program object. The following parameters are 
		/// defined:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program does not refer to a program object.
		/// - GL_INVALID_OPERATION is generated if pname is GL_GEOMETRY_VERTICES_OUT, GL_GEOMETRY_INPUT_TYPE, or 
		///   GL_GEOMETRY_OUTPUT_TYPE, and program does not contain a geometry shader.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// - GL_INVALID_OPERATION is generated if pname is GL_COMPUTE_WORK_GROUP_SIZE and program does not contain a binary for the 
		///   compute shader stage.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveAttrib with argument program
		/// - glGetActiveUniform with argument program
		/// - glGetAttachedShaders with argument program
		/// - glGetProgramInfoLog with argument program
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glGetProgramInfoLog returns the information log for the specified program object. The information log for a program 
		/// object is modified when the program object is linked or validated. The string that is returned will be null terminated.
		/// glGetProgramInfoLog returns in infoLog as much of the information log as it can, up to a maximum of maxLength 
		/// characters. The number of characters actually returned, excluding the null termination character, is specified by 
		/// length. If the length of the returned string is not required, a value of NULL can be passed in the length argument. The 
		/// size of the buffer required to store the returned information log can be obtained by calling glGetProgram with the value 
		/// GL_INFO_LOG_LENGTH.
		/// The information log for a program object is either an empty string, or a string containing information about the last 
		/// link operation, or a string containing information about the last validation operation. It may contain diagnostic 
		/// messages, warning messages, and other information. When a program object is created, its information log will be a 
		/// string of length 0.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_VALUE is generated if maxLength is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgram with argument GL_INFO_LOG_LENGTH
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glGetShader returns in params the value of a parameter for a specific shader object. The following parameters are 
		/// defined:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if shader does not refer to a shader object.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShaderInfoLog with argument shader
		/// - glGetShaderSource with argument shader
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glGetShaderInfoLog returns the information log for the specified shader object. The information log for a shader object 
		/// is modified when the shader is compiled. The string that is returned will be null terminated.
		/// glGetShaderInfoLog returns in infoLog as much of the information log as it can, up to a maximum of maxLength characters. 
		/// The number of characters actually returned, excluding the null termination character, is specified by length. If the 
		/// length of the returned string is not required, a value of NULL can be passed in the length argument. The size of the 
		/// buffer required to store the returned information log can be obtained by calling glGetShader with the value 
		/// GL_INFO_LOG_LENGTH.
		/// The information log for a shader object is a string that may contain diagnostic messages, warning messages, and other 
		/// information about the last compile operation. When a shader object is created, its information log will be a string of 
		/// length 0.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// - GL_INVALID_VALUE is generated if maxLength is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShader with argument GL_INFO_LOG_LENGTH
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glGetShaderSource returns the concatenation of the source code strings from the shader object specified by shader. The 
		/// source code strings for a shader object are the result of a previous call to glShaderSource. The string returned by the 
		/// function will be null terminated.
		/// glGetShaderSource returns in source as much of the source code string as it can, up to a maximum of bufSize characters. 
		/// The number of characters actually returned, excluding the null termination character, is specified by length. If the 
		/// length of the returned string is not required, a value of NULL can be passed in the length argument. The size of the 
		/// buffer required to store the returned source code string can be obtained by calling glGetShader with the value 
		/// GL_SHADER_SOURCE_LENGTH.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// - GL_INVALID_VALUE is generated if bufSize is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShader with argument GL_SHADER_SOURCE_LENGTH
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glGetUniformLocation returns an integer that represents the location of a specific uniform variable within a program 
		/// object. name must be a null terminated string that contains no white space. name must be an active uniform variable name 
		/// in program that is not a structure, an array of structures, or a subcomponent of a vector or a matrix. This function 
		/// returns -1 if name does not correspond to an active uniform variable in program, if name starts with the reserved prefix 
		/// "gl_", or if name is associated with an atomic counter or a named uniform block.
		/// Uniform variables that are structures or arrays of structures may be queried by calling glGetUniformLocation for each 
		/// field within the structure. The array element operator "[]" and the structure field operator "." may be used in name in 
		/// order to select elements within an array or fields within a structure. The result of using these operators is not 
		/// allowed to be another structure, an array of structures, or a subcomponent of a vector or a matrix. Except if the last 
		/// part of name indicates a uniform variable array, the location of the first element of an array can be retrieved by using 
		/// the name of the array, or by using the name appended by "[0]".
		/// The actual locations assigned to uniform variables are not known until the program object is linked successfully. After 
		/// linking has occurred, the command glGetUniformLocation can be used to obtain the location of a uniform variable. This 
		/// location value can then be passed to glUniform to set the value of the uniform variable or to glGetUniform in order to 
		/// query the current value of the uniform variable. After a program object has been linked successfully, the index values 
		/// for uniform variables remain fixed until the next link command occurs. Uniform variable locations and values can only be 
		/// queried after a link if the link was successful.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH
		/// - glGetUniform with arguments program and the name of a uniform variable
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
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
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variable specified by location determines the number of values returned. If the uniform variable is defined in the 
		/// shader as a boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two 
		/// values will be returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query 
		/// values stored in uniform variables declared as arrays, call glGetUniform for each element of the array. To query values 
		/// stored in uniform variables declared as structures, call glGetUniform for each field in the structure. The values for 
		/// uniform variables declared as a matrix will be returned in column major order.
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred, the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// can then be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// program object has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// command occurs. The uniform variable values can only be queried after a link if the link was successful.
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// params buffer,as described by bufSize, is not large enough to hold the result data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked.
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   program object.
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   than bufSize.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH
		/// - glGetUniformLocation with arguments program and the name of a uniform variable
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
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
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variable specified by location determines the number of values returned. If the uniform variable is defined in the 
		/// shader as a boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two 
		/// values will be returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query 
		/// values stored in uniform variables declared as arrays, call glGetUniform for each element of the array. To query values 
		/// stored in uniform variables declared as structures, call glGetUniform for each field in the structure. The values for 
		/// uniform variables declared as a matrix will be returned in column major order.
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred, the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// can then be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// program object has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// command occurs. The uniform variable values can only be queried after a link if the link was successful.
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// params buffer,as described by bufSize, is not large enough to hold the result data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked.
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   program object.
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   than bufSize.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH
		/// - glGetUniformLocation with arguments program and the name of a uniform variable
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
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
		/// <remarks>
		/// glGetVertexAttrib returns in params the value of a generic vertex attribute parameter. The generic vertex attribute to 
		/// be queried is specified by index, and the parameter to be queried is specified by pname.
		/// The accepted parameter names are as follows:
		/// All of the parameters except GL_CURRENT_VERTEX_ATTRIB represent state stored in the currently bound vertex array object.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if pname is not GL_CURRENT_VERTEX_ATTRIB and there is no currently bound vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// - GL_INVALID_OPERATION is generated if index is 0 and pname is GL_CURRENT_VERTEX_ATTRIB.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetVertexAttrib returns in params the value of a generic vertex attribute parameter. The generic vertex attribute to 
		/// be queried is specified by index, and the parameter to be queried is specified by pname.
		/// The accepted parameter names are as follows:
		/// All of the parameters except GL_CURRENT_VERTEX_ATTRIB represent state stored in the currently bound vertex array object.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if pname is not GL_CURRENT_VERTEX_ATTRIB and there is no currently bound vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// - GL_INVALID_OPERATION is generated if index is 0 and pname is GL_CURRENT_VERTEX_ATTRIB.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetVertexAttrib returns in params the value of a generic vertex attribute parameter. The generic vertex attribute to 
		/// be queried is specified by index, and the parameter to be queried is specified by pname.
		/// The accepted parameter names are as follows:
		/// All of the parameters except GL_CURRENT_VERTEX_ATTRIB represent state stored in the currently bound vertex array object.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if pname is not GL_CURRENT_VERTEX_ATTRIB and there is no currently bound vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// - GL_INVALID_OPERATION is generated if index is 0 and pname is GL_CURRENT_VERTEX_ATTRIB.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glGetVertexAttribPointerv returns pointer information. index is the generic vertex attribute to be queried, pname is a 
		/// symbolic constant indicating the pointer to be returned, and params is a pointer to a location in which to place the 
		/// returned data.
		/// The pointer returned is a byte offset into the data store of the buffer object that was bound to the GL_ARRAY_BUFFER 
		/// target (see glBindBuffer) when the desired pointer was previously specified.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if no vertex array object is currently bound.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glIsProgram returns GL_TRUE if program is the name of a program object previously created with glCreateProgram and not 
		/// yet deleted with glDeleteProgram. If program is zero or a non-zero value that is not the name of a program object, or if 
		/// an error occurs, glIsProgram returns GL_FALSE.
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with arguments program and the index of an active attribute variable
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable
		/// - glGetAttachedShaders with argument program
		/// - glGetAttribLocation with arguments program and the name of an attribute variable
		/// - glGetProgram with arguments program and the parameter to be queried
		/// - glGetProgramInfoLog with argument program
		/// - glGetUniform with arguments program and the location of a uniform variable
		/// - glGetUniformLocation with arguments program and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glIsShader returns GL_TRUE if shader is the name of a shader object previously created with glCreateShader and not yet 
		/// deleted with glDeleteShader. If shader is zero or a non-zero value that is not the name of a shader object, or if an 
		/// error occurs, glIsShader returns GL_FALSE.
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetAttachedShaders with a valid program object
		/// - glGetShader with arguments shader and a parameter to be queried
		/// - glGetShaderInfoLog with argument object
		/// - glGetShaderSource with argument object
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
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
		/// <remarks>
		/// glLinkProgram links the program object specified by program. If any shader objects of type GL_VERTEX_SHADER are attached 
		/// to program, they will be used to create an executable that will run on the programmable vertex processor. If any shader 
		/// objects of type GL_GEOMETRY_SHADER are attached to program, they will be used to create an executable that will run on 
		/// the programmable geometry processor. If any shader objects of type GL_FRAGMENT_SHADER are attached to program, they will 
		/// be used to create an executable that will run on the programmable fragment processor.
		/// The status of the link operation will be stored as part of the program object's state. This value will be set to GL_TRUE 
		/// if the program object was linked without errors and is ready for use, and GL_FALSE otherwise. It can be queried by 
		/// calling glGetProgram with arguments program and GL_LINK_STATUS.
		/// As a result of a successful link operation, all active user-defined uniform variables belonging to program will be 
		/// initialized to 0, and each of the program object's active uniform variables will be assigned a location that can be 
		/// queried by calling glGetUniformLocation. Also, any active user-defined attribute variables that have not been bound to a 
		/// generic vertex attribute index will be bound to one at this time.
		/// Linking of a program object can fail for a number of reasons as specified in the OpenGL Shading Language Specification. 
		/// The following lists some of the conditions that will cause a link error.
		/// When a program object has been successfully linked, the program object can be made part of current state by calling 
		/// glUseProgram. Whether or not the link operation was successful, the program object's information log will be 
		/// overwritten. The information log can be retrieved by calling glGetProgramInfoLog.
		/// glLinkProgram will also install the generated executables as part of the current rendering state if the link operation 
		/// was successful and the specified program object is already currently in use as a result of a previous call to 
		/// glUseProgram. If the program object currently in use is relinked unsuccessfully, its link status will be set to GL_FALSE 
		/// , but the executables and associated state will remain part of the current state until a subsequent call to glUseProgram 
		/// removes it from use. After it is removed from use, it cannot be made part of current state until it has been 
		/// successfully relinked.
		/// If program contains shader objects of type GL_VERTEX_SHADER, and optionally of type GL_GEOMETRY_SHADER, but does not 
		/// contain shader objects of type GL_FRAGMENT_SHADER, the vertex shader executable will be installed on the programmable 
		/// vertex processor, the geometry shader executable, if present, will be installed on the programmable geometry processor, 
		/// but no executable will be installed on the fragment processor. The results of rasterizing primitives with such a program 
		/// will be undefined.
		/// The program object's information log is updated and the program is generated at the time of the link operation. After 
		/// the link operation, applications are free to modify attached shader objects, compile attached shader objects, detach 
		/// shader objects, delete shader objects, and attach additional shader objects. None of these operations affects the 
		/// information log or the program that is part of the program object.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program is the currently active program object and transform feedback mode is 
		///   active.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetActiveUniform with argument program and the index of an active uniform variable
		/// - glGetAttachedShaders with argument program
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetProgram with arguments program and GL_LINK_STATUS
		/// - glGetProgramInfoLog with argument program
		/// - glGetUniform with argument program and a uniform variable location
		/// - glGetUniformLocation with argument program and a uniform variable name
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
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
		/// <remarks>
		/// glShaderSource sets the source code in shader to the source code in the array of strings specified by string. Any source 
		/// code previously stored in the shader object is completely replaced. The number of strings in the array is specified by 
		/// count. If length is NULL, each string is assumed to be null terminated. If length is a value other than NULL, it points 
		/// to an array containing a string length for each of the corresponding elements of string. Each element in the length 
		/// array may contain the length of the corresponding string (the null character is not counted as part of the string 
		/// length) or a value less than 0 to indicate that the string is null terminated. The source code strings are not scanned 
		/// or parsed at this time; they are simply copied into the specified shader object.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if shader is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if shader is not a shader object.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetShader with arguments shader and GL_SHADER_SOURCE_LENGTH
		/// - glGetShaderSource with argument shader
		/// - glIsShader
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		public static void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length)
		{
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
		/// <remarks>
		/// glUseProgram installs the program object specified by program as part of current rendering state. One or more 
		/// executables are created in a program object by successfully attaching shader objects to it with glAttachShader, 
		/// successfully compiling the shader objects with glCompileShader, and successfully linking the program object with 
		/// glLinkProgram.
		/// A program object will contain an executable that will run on the vertex processor if it contains one or more shader 
		/// objects of type GL_VERTEX_SHADER that have been successfully compiled and linked. A program object will contain an 
		/// executable that will run on the geometry processor if it contains one or more shader objects of type GL_GEOMETRY_SHADER 
		/// that have been successfully compiled and linked. Similarly, a program object will contain an executable that will run on 
		/// the fragment processor if it contains one or more shader objects of type GL_FRAGMENT_SHADER that have been successfully 
		/// compiled and linked.
		/// While a program object is in use, applications are free to modify attached shader objects, compile attached shader 
		/// objects, attach additional shader objects, and detach or delete shader objects. None of these operations will affect the 
		/// executables that are part of the current state. However, relinking the program object that is currently in use will 
		/// install the program object as part of the current rendering state if the link operation was successful (see 
		/// glLinkProgram ). If the program object currently in use is relinked unsuccessfully, its link status will be set to 
		/// GL_FALSE, but the executables and associated state will remain part of the current state until a subsequent call to 
		/// glUseProgram removes it from use. After it is removed from use, it cannot be made part of current state until it has 
		/// been successfully relinked.
		/// If program is zero, then the current rendering state refers to an invalid program object and the results of shader 
		/// execution are undefined. However, this is not an error.
		/// If program does not contain shader objects of type GL_FRAGMENT_SHADER, an executable will be installed on the vertex, 
		/// and possibly geometry processors, but the results of fragment shader execution will be undefined.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is neither 0 nor a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_OPERATION is generated if program could not be made part of current state.
		/// - GL_INVALID_OPERATION is generated if transform feedback mode is active.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with a valid program object and the index of an active attribute variable
		/// - glGetActiveUniform with a valid program object and the index of an active uniform variable
		/// - glGetAttachedShaders with a valid program object
		/// - glGetAttribLocation with a valid program object and the name of an attribute variable
		/// - glGetProgram with a valid program object and the parameter to be queried
		/// - glGetProgramInfoLog with a valid program object
		/// - glGetUniform with a valid program object and the location of a uniform variable
		/// - glGetUniformLocation with a valid program object and the name of a uniform variable
		/// - glIsProgram
		/// </para>
		/// </remarks>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// glValidateProgram checks to see whether the executables contained in program can execute given the current OpenGL state. 
		/// The information generated by the validation process will be stored in program's information log. The validation 
		/// information may consist of an empty string, or it may be a string containing information about how the current program 
		/// object interacts with the rest of current OpenGL state. This provides a way for OpenGL implementers to convey more 
		/// information about why the current program is inefficient, suboptimal, failing to execute, and so on.
		/// The status of the validation operation will be stored as part of the program object's state. This value will be set to 
		/// GL_TRUE if the validation succeeded, and GL_FALSE otherwise. It can be queried by calling glGetProgram with arguments 
		/// program and GL_VALIDATE_STATUS. If validation is successful, program is guaranteed to execute given the current state. 
		/// Otherwise, program is guaranteed to not execute.
		/// This function is typically useful only during application development. The informational string stored in the 
		/// information log is completely implementation dependent; therefore, an application should not expect different OpenGL 
		/// implementations to produce identical information strings.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgram with arguments program and GL_VALIDATE_STATUS
		/// - glGetProgramInfoLog with argument program
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations.
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// is numbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individual elements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// be modified and a value for that element.
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// by index. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the 
		/// first component of the generic vertex attribute. The second and third components will be set to 0, and the fourth 
		/// component will be set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first 
		/// two components, the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// command indicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereas a 4 in the name indicates that values are provided for all four components.
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte, unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// such values.
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function:
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalized range according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understood to represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-point values in the range [0,1].
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers.
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type.
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputs declared as 64-bit double precision types.
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// be loaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// column major order, with one column of the matrix in each generic attribute slot.
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation. This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// change to the specified generic vertex attribute will be immediately reflected as a change to the corresponding 
		/// attribute variable in the vertex shader.
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// the state of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertex attribute is part of current state, just like standard vertex attributes, and it is maintained even if a 
		/// different program object is used.
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable. These values are simply maintained as part of current state and will not be accessed by the vertex shader. If 
		/// a generic vertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing, the vertex shader will repeatedly use the current value for the generic vertex attribute.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV, or GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable
		/// - glGetAttribLocation with argument program and an attribute variable name
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
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
		/// <remarks>
		/// glVertexAttribPointer, glVertexAttribIPointer and glVertexAttribLPointer specify the location and data format of the 
		/// array of generic vertex attributes at index index to use when rendering. size specifies the number of components per 
		/// attribute and must be 1, 2, 3, 4, or GL_BGRA. type specifies the data type of each component, and stride specifies the 
		/// byte stride from one attribute to the next, allowing vertices and attributes to be packed into a single array or stored 
		/// in separate arrays.
		/// For glVertexAttribPointer, if normalized is set to GL_TRUE, it indicates that values stored in an integer format are to 
		/// be mapped to the range [-1,1] (for signed values) or [0,1] (for unsigned values) when they are accessed and converted to 
		/// floating point. Otherwise, values will be converted to floats directly without normalization.
		/// For glVertexAttribIPointer, only the integer types GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, 
		/// GL_UNSIGNED_INT are accepted. Values are always left as integer values.
		/// glVertexAttribLPointer specifies state for a generic vertex attribute array associated with a shader attribute variable 
		/// declared with 64-bit double precision components. type must be GL_DOUBLE. index, size, and stride behave as described 
		/// for glVertexAttribPointer and glVertexAttribIPointer.
		/// If pointer is not NULL, a non-zero named buffer object must be bound to the GL_ARRAY_BUFFER target (see glBindBuffer), 
		/// otherwise an error is generated. pointer is treated as a byte offset into the buffer object's data store. The buffer 
		/// object binding (GL_ARRAY_BUFFER_BINDING) is saved as generic vertex attribute array state 
		/// (GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING) for index index.
		/// When a generic vertex attribute array is specified, size, type, normalized, stride, and pointer are saved as vertex 
		/// array state, in addition to the current vertex array buffer object binding.
		/// To enable and disable a generic vertex attribute array, call glEnableVertexAttribArray and glDisableVertexAttribArray 
		/// with index. If enabled, the generic vertex attribute array is used when glDrawArrays, glMultiDrawArrays, glDrawElements, 
		/// glMultiDrawElements, or glDrawRangeElements is called.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_VALUE is generated if size is not 1, 2, 3, 4 or (for glVertexAttribPointer), GL_BGRA.
		/// - GL_INVALID_ENUM is generated if type is not an accepted value.
		/// - GL_INVALID_VALUE is generated if stride is negative.
		/// - GL_INVALID_OPERATION is generated if size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or 
		///   GL_UNSIGNED_INT_2_10_10_10_REV.
		/// - GL_INVALID_OPERATION is generated if type is GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV and size is not 4 
		///   or GL_BGRA.
		/// - GL_INVALID_OPERATION is generated if type is GL_UNSIGNED_INT_10F_11F_11F_REV and size is not 3.
		/// - GL_INVALID_OPERATION is generated by glVertexAttribPointer if size is GL_BGRA and noramlized is GL_FALSE.
		/// - GL_INVALID_OPERATION is generated if zero is bound to the GL_ARRAY_BUFFER buffer object binding point and the pointer 
		///   argument is not NULL.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_SIZE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_TYPE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_NORMALIZED
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_STRIDE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
		/// - glGet with argument GL_ARRAY_BUFFER_BINDING
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
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
		/// <remarks>
		/// glVertexAttribPointer, glVertexAttribIPointer and glVertexAttribLPointer specify the location and data format of the 
		/// array of generic vertex attributes at index index to use when rendering. size specifies the number of components per 
		/// attribute and must be 1, 2, 3, 4, or GL_BGRA. type specifies the data type of each component, and stride specifies the 
		/// byte stride from one attribute to the next, allowing vertices and attributes to be packed into a single array or stored 
		/// in separate arrays.
		/// For glVertexAttribPointer, if normalized is set to GL_TRUE, it indicates that values stored in an integer format are to 
		/// be mapped to the range [-1,1] (for signed values) or [0,1] (for unsigned values) when they are accessed and converted to 
		/// floating point. Otherwise, values will be converted to floats directly without normalization.
		/// For glVertexAttribIPointer, only the integer types GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, 
		/// GL_UNSIGNED_INT are accepted. Values are always left as integer values.
		/// glVertexAttribLPointer specifies state for a generic vertex attribute array associated with a shader attribute variable 
		/// declared with 64-bit double precision components. type must be GL_DOUBLE. index, size, and stride behave as described 
		/// for glVertexAttribPointer and glVertexAttribIPointer.
		/// If pointer is not NULL, a non-zero named buffer object must be bound to the GL_ARRAY_BUFFER target (see glBindBuffer), 
		/// otherwise an error is generated. pointer is treated as a byte offset into the buffer object's data store. The buffer 
		/// object binding (GL_ARRAY_BUFFER_BINDING) is saved as generic vertex attribute array state 
		/// (GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING) for index index.
		/// When a generic vertex attribute array is specified, size, type, normalized, stride, and pointer are saved as vertex 
		/// array state, in addition to the current vertex array buffer object binding.
		/// To enable and disable a generic vertex attribute array, call glEnableVertexAttribArray and glDisableVertexAttribArray 
		/// with index. If enabled, the generic vertex attribute array is used when glDrawArrays, glMultiDrawArrays, glDrawElements, 
		/// glMultiDrawElements, or glDrawRangeElements is called.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS.
		/// - GL_INVALID_VALUE is generated if size is not 1, 2, 3, 4 or (for glVertexAttribPointer), GL_BGRA.
		/// - GL_INVALID_ENUM is generated if type is not an accepted value.
		/// - GL_INVALID_VALUE is generated if stride is negative.
		/// - GL_INVALID_OPERATION is generated if size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or 
		///   GL_UNSIGNED_INT_2_10_10_10_REV.
		/// - GL_INVALID_OPERATION is generated if type is GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV and size is not 4 
		///   or GL_BGRA.
		/// - GL_INVALID_OPERATION is generated if type is GL_UNSIGNED_INT_10F_11F_11F_REV and size is not 3.
		/// - GL_INVALID_OPERATION is generated by glVertexAttribPointer if size is GL_BGRA and noramlized is GL_FALSE.
		/// - GL_INVALID_OPERATION is generated if zero is bound to the GL_ARRAY_BUFFER buffer object binding point and the pointer 
		///   argument is not NULL.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_SIZE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_TYPE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_NORMALIZED
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_STRIDE
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
		/// - glGet with argument GL_ARRAY_BUFFER_BINDING
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER
		/// </para>
		/// </remarks>
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
