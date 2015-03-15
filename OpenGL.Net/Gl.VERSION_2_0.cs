
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
		[AliasOf("GL_BLEND_EQUATION_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BLEND_EQUATION_RGB = 0x8009;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_ENABLED symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_SIZE symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_STRIDE symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_TYPE symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_ATTRIB symbol.
		/// </summary>
		[AliasOf("GL_CURRENT_VERTEX_ATTRIB_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int CURRENT_VERTEX_ATTRIB = 0x8626;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_POINT_SIZE symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_POINTER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FUNC symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FUNC_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_FUNC = 0x8800;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FAIL symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_FAIL = 0x8801;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_FAIL symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_PASS symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

		/// <summary>
		/// Value of GL_MAX_DRAW_BUFFERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_DRAW_BUFFERS_ARB")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_DRAW_BUFFERS = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER0_ARB")]
		[AliasOf("GL_DRAW_BUFFER0_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER0 = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER1_ARB")]
		[AliasOf("GL_DRAW_BUFFER1_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER1 = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER2_ARB")]
		[AliasOf("GL_DRAW_BUFFER2_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER2 = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER3_ARB")]
		[AliasOf("GL_DRAW_BUFFER3_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER3 = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER4_ARB")]
		[AliasOf("GL_DRAW_BUFFER4_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER4 = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER5_ARB")]
		[AliasOf("GL_DRAW_BUFFER5_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER5 = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER6_ARB")]
		[AliasOf("GL_DRAW_BUFFER6_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER6 = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER7_ARB")]
		[AliasOf("GL_DRAW_BUFFER7_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER7 = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER8_ARB")]
		[AliasOf("GL_DRAW_BUFFER8_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER8 = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER9_ARB")]
		[AliasOf("GL_DRAW_BUFFER9_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER9 = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER10_ARB")]
		[AliasOf("GL_DRAW_BUFFER10_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER10 = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER11_ARB")]
		[AliasOf("GL_DRAW_BUFFER11_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER11 = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER12_ARB")]
		[AliasOf("GL_DRAW_BUFFER12_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER12 = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER13_ARB")]
		[AliasOf("GL_DRAW_BUFFER13_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER13 = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER14_ARB")]
		[AliasOf("GL_DRAW_BUFFER14_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER14 = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER15_ARB")]
		[AliasOf("GL_DRAW_BUFFER15_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int DRAW_BUFFER15 = 0x8834;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BLEND_EQUATION_ALPHA = 0x883D;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_ATTRIBS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_ATTRIBS = 0x8869;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_NORMALIZED symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER symbol.
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FRAGMENT_SHADER = 0x8B30;

		/// <summary>
		/// Value of GL_VERTEX_SHADER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int VERTEX_SHADER = 0x8B31;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;

		/// <summary>
		/// Value of GL_MAX_VARYING_FLOATS symbol.
		/// </summary>
		[AliasOf("GL_MAX_VARYING_FLOATS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VARYING_FLOATS = 0x8B4B;

		/// <summary>
		/// Value of GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS symbol.
		/// </summary>
		[AliasOf("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
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
		[AliasOf("GL_FLOAT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC2 = 0x8B50;

		/// <summary>
		/// Value of GL_FLOAT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC3 = 0x8B51;

		/// <summary>
		/// Value of GL_FLOAT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_VEC4 = 0x8B52;

		/// <summary>
		/// Value of GL_INT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC2 = 0x8B53;

		/// <summary>
		/// Value of GL_INT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC3 = 0x8B54;

		/// <summary>
		/// Value of GL_INT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int INT_VEC4 = 0x8B55;

		/// <summary>
		/// Value of GL_BOOL symbol.
		/// </summary>
		[AliasOf("GL_BOOL_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL = 0x8B56;

		/// <summary>
		/// Value of GL_BOOL_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC2 = 0x8B57;

		/// <summary>
		/// Value of GL_BOOL_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC3 = 0x8B58;

		/// <summary>
		/// Value of GL_BOOL_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int BOOL_VEC4 = 0x8B59;

		/// <summary>
		/// Value of GL_FLOAT_MAT2 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT2 = 0x8B5A;

		/// <summary>
		/// Value of GL_FLOAT_MAT3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT3 = 0x8B5B;

		/// <summary>
		/// Value of GL_FLOAT_MAT4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FLOAT_MAT4 = 0x8B5C;

		/// <summary>
		/// Value of GL_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_1D = 0x8B5D;

		/// <summary>
		/// Value of GL_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_2D = 0x8B5E;

		/// <summary>
		/// Value of GL_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_3D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_3D = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_CUBE = 0x8B60;

		/// <summary>
		/// Value of GL_SAMPLER_1D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int SAMPLER_1D_SHADOW = 0x8B61;

		/// <summary>
		/// Value of GL_SAMPLER_2D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_SHADOW_ARB")]
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
		[AliasOf("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

		/// <summary>
		/// Value of GL_SHADING_LANGUAGE_VERSION symbol.
		/// </summary>
		[AliasOf("GL_SHADING_LANGUAGE_VERSION_ARB")]
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
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_PROGRAM_TWO_SIDE = 0x8643;

		/// <summary>
		/// Value of GL_POINT_SPRITE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_POINT_SPRITE_ARB")]
		[AliasOf("GL_POINT_SPRITE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SPRITE = 0x8861;

		/// <summary>
		/// Value of GL_COORD_REPLACE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COORD_REPLACE_ARB")]
		[AliasOf("GL_COORD_REPLACE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COORD_REPLACE = 0x8862;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_COORDS symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_COORDS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_COORDS_NV")]
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
		public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparate != null, "pglBlendEquationSeparate not implemented");
			Delegates.pglBlendEquationSeparate((int)modeRGB, (int)modeAlpha);
			CallLog("glBlendEquationSeparate({0}, {1})", modeRGB, modeAlpha);
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
		public static void DrawBuffers(params int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffers != null, "pglDrawBuffers not implemented");
					Delegates.pglDrawBuffers((Int32)bufs.Length, p_bufs);
					CallLog("glDrawBuffers({0}, {1})", bufs.Length, bufs);
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
		public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOpSeparate != null, "pglStencilOpSeparate not implemented");
			Delegates.pglStencilOpSeparate((int)face, (int)sfail, (int)dpfail, (int)dppass);
			CallLog("glStencilOpSeparate({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
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
		public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparate != null, "pglStencilFuncSeparate not implemented");
			Delegates.pglStencilFuncSeparate((int)face, (int)func, @ref, mask);
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
		public static void StencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMaskSeparate != null, "pglStencilMaskSeparate not implemented");
			Delegates.pglStencilMaskSeparate((int)face, mask);
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
			Debug.Assert(Delegates.pglAttachShader != null, "pglAttachShader not implemented");
			Delegates.pglAttachShader(program, shader);
			CallLog("glAttachShader({0}, {1})", program, shader);
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
			Debug.Assert(Delegates.pglBindAttribLocation != null, "pglBindAttribLocation not implemented");
			Delegates.pglBindAttribLocation(program, index, name);
			CallLog("glBindAttribLocation({0}, {1}, {2})", program, index, name);
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
			Debug.Assert(Delegates.pglCompileShader != null, "pglCompileShader not implemented");
			Delegates.pglCompileShader(shader);
			CallLog("glCompileShader({0})", shader);
			DebugCheckErrors();
		}

		/// <summary>
		/// Creates a program object
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static UInt32 CreateProgram()
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateProgram != null, "pglCreateProgram not implemented");
			retValue = Delegates.pglCreateProgram();
			CallLog("glCreateProgram() = {0}", retValue);
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

			Debug.Assert(Delegates.pglCreateShader != null, "pglCreateShader not implemented");
			retValue = Delegates.pglCreateShader(type);
			CallLog("glCreateShader({0}) = {1}", type, retValue);
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
			Debug.Assert(Delegates.pglDetachShader != null, "pglDetachShader not implemented");
			Delegates.pglDetachShader(program, shader);
			CallLog("glDetachShader({0}, {1})", program, shader);
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
			Debug.Assert(Delegates.pglDisableVertexAttribArray != null, "pglDisableVertexAttribArray not implemented");
			Delegates.pglDisableVertexAttribArray(index);
			CallLog("glDisableVertexAttribArray({0})", index);
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
			Debug.Assert(Delegates.pglEnableVertexAttribArray != null, "pglEnableVertexAttribArray not implemented");
			Delegates.pglEnableVertexAttribArray(index);
			CallLog("glEnableVertexAttribArray({0})", index);
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
					Debug.Assert(Delegates.pglGetActiveAttrib != null, "pglGetActiveAttrib not implemented");
					Delegates.pglGetActiveAttrib(program, index, bufSize, p_length, p_size, p_type, name);
					CallLog("glGetActiveAttrib({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
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
					Debug.Assert(Delegates.pglGetActiveUniform != null, "pglGetActiveUniform not implemented");
					Delegates.pglGetActiveUniform(program, index, bufSize, p_length, p_size, p_type, name);
					CallLog("glGetActiveUniform({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
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
		public static void GetAttachedShaders(UInt32 program, out Int32 count, UInt32[] shaders)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglGetAttachedShaders != null, "pglGetAttachedShaders not implemented");
					Delegates.pglGetAttachedShaders(program, (Int32)shaders.Length, p_count, p_shaders);
					CallLog("glGetAttachedShaders({0}, {1}, {2}, {3})", program, shaders.Length, count, shaders);
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

			Debug.Assert(Delegates.pglGetAttribLocation != null, "pglGetAttribLocation not implemented");
			retValue = Delegates.pglGetAttribLocation(program, name);
			CallLog("glGetAttribLocation({0}, {1}) = {2}", program, name, retValue);
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetShader(UInt32 shader, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
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
					Debug.Assert(Delegates.pglGetShaderSource != null, "pglGetShaderSource not implemented");
					Delegates.pglGetShaderSource(shader, bufSize, p_length, source);
					CallLog("glGetShaderSource({0}, {1}, {2}, {3})", shader, bufSize, length, source);
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

			Debug.Assert(Delegates.pglGetUniformLocation != null, "pglGetUniformLocation not implemented");
			retValue = Delegates.pglGetUniformLocation(program, name);
			CallLog("glGetUniformLocation({0}, {1}) = {2}", program, name, retValue);
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
					Debug.Assert(Delegates.pglGetUniformfv != null, "pglGetUniformfv not implemented");
					Delegates.pglGetUniformfv(program, location, p_params);
					CallLog("glGetUniformfv({0}, {1}, {2})", program, location, @params);
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
					Debug.Assert(Delegates.pglGetUniformiv != null, "pglGetUniformiv not implemented");
					Delegates.pglGetUniformiv(program, location, p_params);
					CallLog("glGetUniformiv({0}, {1}, {2})", program, location, @params);
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
					Debug.Assert(Delegates.pglGetVertexAttribdv != null, "pglGetVertexAttribdv not implemented");
					Delegates.pglGetVertexAttribdv(index, pname, p_params);
					CallLog("glGetVertexAttribdv({0}, {1}, {2})", index, pname, @params);
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
					Debug.Assert(Delegates.pglGetVertexAttribfv != null, "pglGetVertexAttribfv not implemented");
					Delegates.pglGetVertexAttribfv(index, pname, p_params);
					CallLog("glGetVertexAttribfv({0}, {1}, {2})", index, pname, @params);
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
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					CallLog("glGetVertexAttribiv({0}, {1}, {2})", index, pname, @params);
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_2_0")]
		public static void GetVertexAttrib(UInt32 index, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					CallLog("glGetVertexAttribiv({0}, {1}, {2})", index, pname, @params);
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
		public static void GetVertexAttribPointer(UInt32 index, int pname, out IntPtr pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = &pointer)
				{
					Debug.Assert(Delegates.pglGetVertexAttribPointerv != null, "pglGetVertexAttribPointerv not implemented");
					Delegates.pglGetVertexAttribPointerv(index, pname, p_pointer);
					CallLog("glGetVertexAttribPointerv({0}, {1}, {2})", index, pname, pointer);
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
		public static void GetVertexAttribPointer(UInt32 index, int pname, Object pointer)
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
			Debug.Assert(Delegates.pglLinkProgram != null, "pglLinkProgram not implemented");
			Delegates.pglLinkProgram(program);
			CallLog("glLinkProgram({0})", program);
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
		public static void ShaderSource(UInt32 shader, String[] @string, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglShaderSource != null, "pglShaderSource not implemented");
					Delegates.pglShaderSource(shader, (Int32)@string.Length, @string, p_length);
					CallLog("glShaderSource({0}, {1}, {2}, {3})", shader, @string.Length, @string, length);
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
			Debug.Assert(Delegates.pglUseProgram != null, "pglUseProgram not implemented");
			Delegates.pglUseProgram(program);
			CallLog("glUseProgram({0})", program);
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
			Debug.Assert(Delegates.pglUniform1f != null, "pglUniform1f not implemented");
			Delegates.pglUniform1f(location, v0);
			CallLog("glUniform1f({0}, {1})", location, v0);
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
			Debug.Assert(Delegates.pglUniform2f != null, "pglUniform2f not implemented");
			Delegates.pglUniform2f(location, v0, v1);
			CallLog("glUniform2f({0}, {1}, {2})", location, v0, v1);
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
			Debug.Assert(Delegates.pglUniform3f != null, "pglUniform3f not implemented");
			Delegates.pglUniform3f(location, v0, v1, v2);
			CallLog("glUniform3f({0}, {1}, {2}, {3})", location, v0, v1, v2);
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
			Debug.Assert(Delegates.pglUniform4f != null, "pglUniform4f not implemented");
			Delegates.pglUniform4f(location, v0, v1, v2, v3);
			CallLog("glUniform4f({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
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
			Debug.Assert(Delegates.pglUniform1i != null, "pglUniform1i not implemented");
			Delegates.pglUniform1i(location, v0);
			CallLog("glUniform1i({0}, {1})", location, v0);
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
			Debug.Assert(Delegates.pglUniform2i != null, "pglUniform2i not implemented");
			Delegates.pglUniform2i(location, v0, v1);
			CallLog("glUniform2i({0}, {1}, {2})", location, v0, v1);
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
			Debug.Assert(Delegates.pglUniform3i != null, "pglUniform3i not implemented");
			Delegates.pglUniform3i(location, v0, v1, v2);
			CallLog("glUniform3i({0}, {1}, {2}, {3})", location, v0, v1, v2);
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
			Debug.Assert(Delegates.pglUniform4i != null, "pglUniform4i not implemented");
			Delegates.pglUniform4i(location, v0, v1, v2, v3);
			CallLog("glUniform4i({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
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
					Debug.Assert(Delegates.pglUniform1fv != null, "pglUniform1fv not implemented");
					Delegates.pglUniform1fv(location, count, p_value);
					CallLog("glUniform1fv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform2fv != null, "pglUniform2fv not implemented");
					Delegates.pglUniform2fv(location, count, p_value);
					CallLog("glUniform2fv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform3fv != null, "pglUniform3fv not implemented");
					Delegates.pglUniform3fv(location, count, p_value);
					CallLog("glUniform3fv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform4fv != null, "pglUniform4fv not implemented");
					Delegates.pglUniform4fv(location, count, p_value);
					CallLog("glUniform4fv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform1iv != null, "pglUniform1iv not implemented");
					Delegates.pglUniform1iv(location, count, p_value);
					CallLog("glUniform1iv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform2iv != null, "pglUniform2iv not implemented");
					Delegates.pglUniform2iv(location, count, p_value);
					CallLog("glUniform2iv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform3iv != null, "pglUniform3iv not implemented");
					Delegates.pglUniform3iv(location, count, p_value);
					CallLog("glUniform3iv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniform4iv != null, "pglUniform4iv not implemented");
					Delegates.pglUniform4iv(location, count, p_value);
					CallLog("glUniform4iv({0}, {1}, {2})", location, count, value);
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
					Debug.Assert(Delegates.pglUniformMatrix2fv != null, "pglUniformMatrix2fv not implemented");
					Delegates.pglUniformMatrix2fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
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
					Debug.Assert(Delegates.pglUniformMatrix3fv != null, "pglUniformMatrix3fv not implemented");
					Delegates.pglUniformMatrix3fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
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
					Debug.Assert(Delegates.pglUniformMatrix4fv != null, "pglUniformMatrix4fv not implemented");
					Delegates.pglUniformMatrix4fv(location, count, transpose, p_value);
					CallLog("glUniformMatrix4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
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
			Debug.Assert(Delegates.pglValidateProgram != null, "pglValidateProgram not implemented");
			Delegates.pglValidateProgram(program);
			CallLog("glValidateProgram({0})", program);
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
			Debug.Assert(Delegates.pglVertexAttrib1d != null, "pglVertexAttrib1d not implemented");
			Delegates.pglVertexAttrib1d(index, x);
			CallLog("glVertexAttrib1d({0}, {1})", index, x);
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
					Debug.Assert(Delegates.pglVertexAttrib1dv != null, "pglVertexAttrib1dv not implemented");
					Delegates.pglVertexAttrib1dv(index, p_v);
					CallLog("glVertexAttrib1dv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib1f != null, "pglVertexAttrib1f not implemented");
			Delegates.pglVertexAttrib1f(index, x);
			CallLog("glVertexAttrib1f({0}, {1})", index, x);
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
					Debug.Assert(Delegates.pglVertexAttrib1fv != null, "pglVertexAttrib1fv not implemented");
					Delegates.pglVertexAttrib1fv(index, p_v);
					CallLog("glVertexAttrib1fv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib1s != null, "pglVertexAttrib1s not implemented");
			Delegates.pglVertexAttrib1s(index, x);
			CallLog("glVertexAttrib1s({0}, {1})", index, x);
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
					Debug.Assert(Delegates.pglVertexAttrib1sv != null, "pglVertexAttrib1sv not implemented");
					Delegates.pglVertexAttrib1sv(index, p_v);
					CallLog("glVertexAttrib1sv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib2d != null, "pglVertexAttrib2d not implemented");
			Delegates.pglVertexAttrib2d(index, x, y);
			CallLog("glVertexAttrib2d({0}, {1}, {2})", index, x, y);
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
					Debug.Assert(Delegates.pglVertexAttrib2dv != null, "pglVertexAttrib2dv not implemented");
					Delegates.pglVertexAttrib2dv(index, p_v);
					CallLog("glVertexAttrib2dv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib2f != null, "pglVertexAttrib2f not implemented");
			Delegates.pglVertexAttrib2f(index, x, y);
			CallLog("glVertexAttrib2f({0}, {1}, {2})", index, x, y);
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
					Debug.Assert(Delegates.pglVertexAttrib2fv != null, "pglVertexAttrib2fv not implemented");
					Delegates.pglVertexAttrib2fv(index, p_v);
					CallLog("glVertexAttrib2fv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib2s != null, "pglVertexAttrib2s not implemented");
			Delegates.pglVertexAttrib2s(index, x, y);
			CallLog("glVertexAttrib2s({0}, {1}, {2})", index, x, y);
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
					Debug.Assert(Delegates.pglVertexAttrib2sv != null, "pglVertexAttrib2sv not implemented");
					Delegates.pglVertexAttrib2sv(index, p_v);
					CallLog("glVertexAttrib2sv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib3d != null, "pglVertexAttrib3d not implemented");
			Delegates.pglVertexAttrib3d(index, x, y, z);
			CallLog("glVertexAttrib3d({0}, {1}, {2}, {3})", index, x, y, z);
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
					Debug.Assert(Delegates.pglVertexAttrib3dv != null, "pglVertexAttrib3dv not implemented");
					Delegates.pglVertexAttrib3dv(index, p_v);
					CallLog("glVertexAttrib3dv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib3f != null, "pglVertexAttrib3f not implemented");
			Delegates.pglVertexAttrib3f(index, x, y, z);
			CallLog("glVertexAttrib3f({0}, {1}, {2}, {3})", index, x, y, z);
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
					Debug.Assert(Delegates.pglVertexAttrib3fv != null, "pglVertexAttrib3fv not implemented");
					Delegates.pglVertexAttrib3fv(index, p_v);
					CallLog("glVertexAttrib3fv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib3s != null, "pglVertexAttrib3s not implemented");
			Delegates.pglVertexAttrib3s(index, x, y, z);
			CallLog("glVertexAttrib3s({0}, {1}, {2}, {3})", index, x, y, z);
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
					Debug.Assert(Delegates.pglVertexAttrib3sv != null, "pglVertexAttrib3sv not implemented");
					Delegates.pglVertexAttrib3sv(index, p_v);
					CallLog("glVertexAttrib3sv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4Nbv != null, "pglVertexAttrib4Nbv not implemented");
					Delegates.pglVertexAttrib4Nbv(index, p_v);
					CallLog("glVertexAttrib4Nbv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4Niv != null, "pglVertexAttrib4Niv not implemented");
					Delegates.pglVertexAttrib4Niv(index, p_v);
					CallLog("glVertexAttrib4Niv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4Nsv != null, "pglVertexAttrib4Nsv not implemented");
					Delegates.pglVertexAttrib4Nsv(index, p_v);
					CallLog("glVertexAttrib4Nsv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib4Nub != null, "pglVertexAttrib4Nub not implemented");
			Delegates.pglVertexAttrib4Nub(index, x, y, z, w);
			CallLog("glVertexAttrib4Nub({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
					Debug.Assert(Delegates.pglVertexAttrib4Nubv != null, "pglVertexAttrib4Nubv not implemented");
					Delegates.pglVertexAttrib4Nubv(index, p_v);
					CallLog("glVertexAttrib4Nubv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4Nuiv != null, "pglVertexAttrib4Nuiv not implemented");
					Delegates.pglVertexAttrib4Nuiv(index, p_v);
					CallLog("glVertexAttrib4Nuiv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4Nusv != null, "pglVertexAttrib4Nusv not implemented");
					Delegates.pglVertexAttrib4Nusv(index, p_v);
					CallLog("glVertexAttrib4Nusv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4bv != null, "pglVertexAttrib4bv not implemented");
					Delegates.pglVertexAttrib4bv(index, p_v);
					CallLog("glVertexAttrib4bv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib4d != null, "pglVertexAttrib4d not implemented");
			Delegates.pglVertexAttrib4d(index, x, y, z, w);
			CallLog("glVertexAttrib4d({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
					Debug.Assert(Delegates.pglVertexAttrib4dv != null, "pglVertexAttrib4dv not implemented");
					Delegates.pglVertexAttrib4dv(index, p_v);
					CallLog("glVertexAttrib4dv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib4f != null, "pglVertexAttrib4f not implemented");
			Delegates.pglVertexAttrib4f(index, x, y, z, w);
			CallLog("glVertexAttrib4f({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
					Debug.Assert(Delegates.pglVertexAttrib4fv != null, "pglVertexAttrib4fv not implemented");
					Delegates.pglVertexAttrib4fv(index, p_v);
					CallLog("glVertexAttrib4fv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4iv != null, "pglVertexAttrib4iv not implemented");
					Delegates.pglVertexAttrib4iv(index, p_v);
					CallLog("glVertexAttrib4iv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttrib4s != null, "pglVertexAttrib4s not implemented");
			Delegates.pglVertexAttrib4s(index, x, y, z, w);
			CallLog("glVertexAttrib4s({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
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
					Debug.Assert(Delegates.pglVertexAttrib4sv != null, "pglVertexAttrib4sv not implemented");
					Delegates.pglVertexAttrib4sv(index, p_v);
					CallLog("glVertexAttrib4sv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4ubv != null, "pglVertexAttrib4ubv not implemented");
					Delegates.pglVertexAttrib4ubv(index, p_v);
					CallLog("glVertexAttrib4ubv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4uiv != null, "pglVertexAttrib4uiv not implemented");
					Delegates.pglVertexAttrib4uiv(index, p_v);
					CallLog("glVertexAttrib4uiv({0}, {1})", index, v);
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
					Debug.Assert(Delegates.pglVertexAttrib4usv != null, "pglVertexAttrib4usv not implemented");
					Delegates.pglVertexAttrib4usv(index, p_v);
					CallLog("glVertexAttrib4usv({0}, {1})", index, v);
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
			Debug.Assert(Delegates.pglVertexAttribPointer != null, "pglVertexAttribPointer not implemented");
			Delegates.pglVertexAttribPointer(index, size, type, normalized, stride, pointer);
			CallLog("glVertexAttribPointer({0}, {1}, {2}, {3}, {4}, {5})", index, size, type, normalized, stride, pointer);
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
