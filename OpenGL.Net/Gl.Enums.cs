
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

// Disable "'token' is obsolete" warnings
#pragma warning disable 618
using System;

namespace OpenGL
{
	/// <summary>
	/// Strongly typed enumeration AccumOp.
	/// </summary>
	public enum AccumOp
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM.
		/// </summary>
		Accum = Gl.ACCUM,

		/// <summary>
		/// Strongly typed for value GL_LOAD.
		/// </summary>
		Load = Gl.LOAD,

		/// <summary>
		/// Strongly typed for value GL_RETURN.
		/// </summary>
		Return = Gl.RETURN,

		/// <summary>
		/// Strongly typed for value GL_MULT.
		/// </summary>
		Mult = Gl.MULT,

		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		Add = Gl.ADD,

	}

	/// <summary>
	/// Strongly typed enumeration AttribMask.
	/// </summary>
	[Flags()]
	public enum AttribMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_BUFFER_BIT.
		/// </summary>
		AccumBufferBit = Gl.ACCUM_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ALL_ATTRIB_BITS.
		/// </summary>
		AllAttribBits = Gl.ALL_ATTRIB_BITS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_BUFFER_BIT.
		/// </summary>
		ColorBufferBit = Gl.COLOR_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_BIT.
		/// </summary>
		CurrentBit = Gl.CURRENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BUFFER_BIT.
		/// </summary>
		DepthBufferBit = Gl.DEPTH_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ENABLE_BIT.
		/// </summary>
		EnableBit = Gl.ENABLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_EVAL_BIT.
		/// </summary>
		EvalBit = Gl.EVAL_BIT,

		/// <summary>
		/// Strongly typed for value GL_FOG_BIT.
		/// </summary>
		FogBit = Gl.FOG_BIT,

		/// <summary>
		/// Strongly typed for value GL_HINT_BIT.
		/// </summary>
		HintBit = Gl.HINT_BIT,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING_BIT.
		/// </summary>
		LightingBit = Gl.LIGHTING_BIT,

		/// <summary>
		/// Strongly typed for value GL_LINE_BIT.
		/// </summary>
		LineBit = Gl.LINE_BIT,

		/// <summary>
		/// Strongly typed for value GL_LIST_BIT.
		/// </summary>
		ListBit = Gl.LIST_BIT,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_BIT, GL_MULTISAMPLE_BIT_3DFX, GL_MULTISAMPLE_BIT_ARB, GL_MULTISAMPLE_BIT_EXT.
		/// </summary>
		MultisampleBit = Gl.MULTISAMPLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MODE_BIT.
		/// </summary>
		PixelModeBit = Gl.PIXEL_MODE_BIT,

		/// <summary>
		/// Strongly typed for value GL_POINT_BIT.
		/// </summary>
		PointBit = Gl.POINT_BIT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_BIT.
		/// </summary>
		PolygonBit = Gl.POLYGON_BIT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE_BIT.
		/// </summary>
		PolygonStippleBit = Gl.POLYGON_STIPPLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_BIT.
		/// </summary>
		ScissorBit = Gl.SCISSOR_BIT,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BUFFER_BIT.
		/// </summary>
		StencilBufferBit = Gl.STENCIL_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BIT.
		/// </summary>
		TextureBit = Gl.TEXTURE_BIT,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_BIT.
		/// </summary>
		TransformBit = Gl.TRANSFORM_BIT,

		/// <summary>
		/// Strongly typed for value GL_VIEWPORT_BIT.
		/// </summary>
		ViewportBit = Gl.VIEWPORT_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration AlphaFunction.
	/// </summary>
	public enum AlphaFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration BlendEquationModeEXT.
	/// </summary>
	public enum BlendEquationModeEXT
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_MAX_SGIX.
		/// </summary>
		AlphaMaxSgix = Gl.ALPHA_MAX_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_MIN_SGIX.
		/// </summary>
		AlphaMinSgix = Gl.ALPHA_MIN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FUNC_ADD_EXT.
		/// </summary>
		FuncAdd = Gl.FUNC_ADD,

		/// <summary>
		/// Strongly typed for value GL_FUNC_REVERSE_SUBTRACT_EXT.
		/// </summary>
		FuncReverseSubtract = Gl.FUNC_REVERSE_SUBTRACT,

		/// <summary>
		/// Strongly typed for value GL_FUNC_SUBTRACT_EXT.
		/// </summary>
		FuncSubtract = Gl.FUNC_SUBTRACT,

		/// <summary>
		/// Strongly typed for value GL_LOGIC_OP.
		/// </summary>
		LogicOp = Gl.LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_MAX_EXT.
		/// </summary>
		Max = Gl.MAX,

		/// <summary>
		/// Strongly typed for value GL_MIN_EXT.
		/// </summary>
		Min = Gl.MIN,

	}

	/// <summary>
	/// Strongly typed enumeration BlendingFactorDest.
	/// </summary>
	public enum BlendingFactorDest
	{
		/// <summary>
		/// Strongly typed for value GL_CONSTANT_ALPHA_EXT.
		/// </summary>
		ConstantAlpha = Gl.CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_COLOR_EXT.
		/// </summary>
		ConstantColor = Gl.CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_DST_ALPHA.
		/// </summary>
		DstAlpha = Gl.DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE.
		/// </summary>
		One = Gl.ONE,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_ALPHA_EXT.
		/// </summary>
		OneMinusConstantAlpha = Gl.ONE_MINUS_CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_COLOR_EXT.
		/// </summary>
		OneMinusConstantColor = Gl.ONE_MINUS_CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_DST_ALPHA.
		/// </summary>
		OneMinusDstAlpha = Gl.ONE_MINUS_DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_SRC_ALPHA.
		/// </summary>
		OneMinusSrcAlpha = Gl.ONE_MINUS_SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_SRC_COLOR.
		/// </summary>
		OneMinusSrcColor = Gl.ONE_MINUS_SRC_COLOR,

		/// <summary>
		/// Strongly typed for value GL_SRC_ALPHA.
		/// </summary>
		SrcAlpha = Gl.SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_SRC_COLOR.
		/// </summary>
		SrcColor = Gl.SRC_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ZERO.
		/// </summary>
		Zero = Gl.ZERO,

	}

	/// <summary>
	/// Strongly typed enumeration BlendingFactorSrc.
	/// </summary>
	public enum BlendingFactorSrc
	{
		/// <summary>
		/// Strongly typed for value GL_CONSTANT_ALPHA_EXT.
		/// </summary>
		ConstantAlpha = Gl.CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_COLOR_EXT.
		/// </summary>
		ConstantColor = Gl.CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_DST_ALPHA.
		/// </summary>
		DstAlpha = Gl.DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_DST_COLOR.
		/// </summary>
		DstColor = Gl.DST_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE.
		/// </summary>
		One = Gl.ONE,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_ALPHA_EXT.
		/// </summary>
		OneMinusConstantAlpha = Gl.ONE_MINUS_CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_COLOR_EXT.
		/// </summary>
		OneMinusConstantColor = Gl.ONE_MINUS_CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_DST_ALPHA.
		/// </summary>
		OneMinusDstAlpha = Gl.ONE_MINUS_DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_DST_COLOR.
		/// </summary>
		OneMinusDstColor = Gl.ONE_MINUS_DST_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_SRC_ALPHA.
		/// </summary>
		OneMinusSrcAlpha = Gl.ONE_MINUS_SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_SRC_ALPHA.
		/// </summary>
		SrcAlpha = Gl.SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_SRC_ALPHA_SATURATE.
		/// </summary>
		SrcAlphaSaturate = Gl.SRC_ALPHA_SATURATE,

		/// <summary>
		/// Strongly typed for value GL_ZERO.
		/// </summary>
		Zero = Gl.ZERO,

	}

	/// <summary>
	/// Strongly typed enumeration Boolean.
	/// </summary>
	public enum Boolean
	{
		/// <summary>
		/// Strongly typed for value GL_FALSE.
		/// </summary>
		False = Gl.FALSE,

		/// <summary>
		/// Strongly typed for value GL_TRUE.
		/// </summary>
		True = Gl.TRUE,

	}

	/// <summary>
	/// Strongly typed enumeration ClearBufferMask.
	/// </summary>
	[Flags()]
	public enum ClearBufferMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_BUFFER_BIT.
		/// </summary>
		AccumBufferBit = Gl.ACCUM_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_BUFFER_BIT.
		/// </summary>
		ColorBufferBit = Gl.COLOR_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BUFFER_BIT.
		/// </summary>
		DepthBufferBit = Gl.DEPTH_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BUFFER_BIT.
		/// </summary>
		StencilBufferBit = Gl.STENCIL_BUFFER_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ClientAttribMask.
	/// </summary>
	[Flags()]
	public enum ClientAttribMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CLIENT_ALL_ATTRIB_BITS.
		/// </summary>
		ClientAllAttribBits = Gl.CLIENT_ALL_ATTRIB_BITS,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_PIXEL_STORE_BIT.
		/// </summary>
		ClientPixelStoreBit = Gl.CLIENT_PIXEL_STORE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_VERTEX_ARRAY_BIT.
		/// </summary>
		ClientVertexArrayBit = Gl.CLIENT_VERTEX_ARRAY_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ClipPlaneName.
	/// </summary>
	public enum ClipPlaneName
	{
		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE0, GL_CLIP_PLANE0.
		/// </summary>
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE1, GL_CLIP_PLANE1.
		/// </summary>
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE2, GL_CLIP_PLANE2.
		/// </summary>
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE3, GL_CLIP_PLANE3.
		/// </summary>
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE4, GL_CLIP_PLANE4.
		/// </summary>
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE5, GL_CLIP_PLANE5.
		/// </summary>
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE6.
		/// </summary>
		ClipDistance6 = Gl.CLIP_DISTANCE6,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE7.
		/// </summary>
		ClipDistance7 = Gl.CLIP_DISTANCE7,

	}

	/// <summary>
	/// Strongly typed enumeration ColorMaterialFace.
	/// </summary>
	public enum ColorMaterialFace
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration ColorMaterialParameter.
	/// </summary>
	public enum ColorMaterialParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_AMBIENT_AND_DIFFUSE.
		/// </summary>
		AmbientAndDiffuse = Gl.AMBIENT_AND_DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_EMISSION.
		/// </summary>
		Emission = Gl.EMISSION,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		Specular = Gl.SPECULAR,

	}

	/// <summary>
	/// Strongly typed enumeration ColorPointerType.
	/// </summary>
	public enum ColorPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		UnsignedShort = Gl.UNSIGNED_SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration ColorTableParameterPNameSGI.
	/// </summary>
	public enum ColorTableParameterPNameSGI
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BIAS, GL_COLOR_TABLE_BIAS_SGI.
		/// </summary>
		ColorTableBias = Gl.COLOR_TABLE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SCALE, GL_COLOR_TABLE_SCALE_SGI.
		/// </summary>
		ColorTableScale = Gl.COLOR_TABLE_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration ColorTableTargetSGI.
	/// </summary>
	public enum ColorTableTargetSGI
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE, GL_COLOR_TABLE_SGI.
		/// </summary>
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE, GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE, GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_COLOR_TABLE, GL_PROXY_COLOR_TABLE_SGI.
		/// </summary>
		ProxyColorTable = Gl.PROXY_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE, GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		ProxyPostColorMatrixColorTable = Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_POST_CONVOLUTION_COLOR_TABLE, GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		ProxyPostConvolutionColorTable = Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		ProxyTextureColorTableSgi = Gl.PROXY_TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

	}

	/// <summary>
	/// Strongly typed enumeration ContextFlagMask.
	/// </summary>
	[Flags()]
	public enum ContextFlagMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_DEBUG_BIT.
		/// </summary>
		ContextFlagDebugBit = Gl.CONTEXT_FLAG_DEBUG_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT.
		/// </summary>
		ContextFlagForwardCompatibleBit = Gl.CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB.
		/// </summary>
		ContextFlagRobustAccessBit = Gl.CONTEXT_FLAG_ROBUST_ACCESS_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ContextProfileMask.
	/// </summary>
	[Flags()]
	public enum ContextProfileMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CONTEXT_COMPATIBILITY_PROFILE_BIT.
		/// </summary>
		ContextCompatibilityProfileBit = Gl.CONTEXT_COMPATIBILITY_PROFILE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_CORE_PROFILE_BIT.
		/// </summary>
		ContextCoreProfileBit = Gl.CONTEXT_CORE_PROFILE_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionBorderModeEXT.
	/// </summary>
	public enum ConvolutionBorderModeEXT
	{
		/// <summary>
		/// Strongly typed for value GL_REDUCE, GL_REDUCE_EXT.
		/// </summary>
		Reduce = Gl.REDUCE,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionParameterEXT.
	/// </summary>
	public enum ConvolutionParameterEXT
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_BORDER_MODE, GL_CONVOLUTION_BORDER_MODE_EXT.
		/// </summary>
		ConvolutionBorderMode = Gl.CONVOLUTION_BORDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_BIAS, GL_CONVOLUTION_FILTER_BIAS_EXT.
		/// </summary>
		ConvolutionFilterBias = Gl.CONVOLUTION_FILTER_BIAS,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_SCALE, GL_CONVOLUTION_FILTER_SCALE_EXT.
		/// </summary>
		ConvolutionFilterScale = Gl.CONVOLUTION_FILTER_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionTargetEXT.
	/// </summary>
	public enum ConvolutionTargetEXT
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D, GL_CONVOLUTION_1D_EXT.
		/// </summary>
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D, GL_CONVOLUTION_2D_EXT.
		/// </summary>
		Convolution2d = Gl.CONVOLUTION_2D,

	}

	/// <summary>
	/// Strongly typed enumeration CullFaceMode.
	/// </summary>
	public enum CullFaceMode
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration DataType.
	/// </summary>
	[Flags()]
	public enum DataType : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration DepthFunction.
	/// </summary>
	public enum DepthFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration DrawBufferMode.
	/// </summary>
	public enum DrawBufferMode
	{
		/// <summary>
		/// Strongly typed for value GL_AUX0.
		/// </summary>
		Aux0 = Gl.AUX0,

		/// <summary>
		/// Strongly typed for value GL_AUX1.
		/// </summary>
		Aux1 = Gl.AUX1,

		/// <summary>
		/// Strongly typed for value GL_AUX2.
		/// </summary>
		Aux2 = Gl.AUX2,

		/// <summary>
		/// Strongly typed for value GL_AUX3.
		/// </summary>
		Aux3 = Gl.AUX3,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_BACK_LEFT.
		/// </summary>
		BackLeft = Gl.BACK_LEFT,

		/// <summary>
		/// Strongly typed for value GL_BACK_RIGHT.
		/// </summary>
		BackRight = Gl.BACK_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		FrontAndBack = Gl.FRONT_AND_BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT_LEFT.
		/// </summary>
		FrontLeft = Gl.FRONT_LEFT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_RIGHT.
		/// </summary>
		FrontRight = Gl.FRONT_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_LEFT.
		/// </summary>
		Left = Gl.LEFT,

		/// <summary>
		/// Strongly typed for value GL_NONE.
		/// </summary>
		None = Gl.NONE,

		/// <summary>
		/// Strongly typed for value GL_RIGHT.
		/// </summary>
		Right = Gl.RIGHT,

	}

	/// <summary>
	/// Strongly typed enumeration DrawElementsType.
	/// </summary>
	public enum DrawElementsType
	{
		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		UnsignedInt = Gl.UNSIGNED_INT,

	}

	/// <summary>
	/// Strongly typed enumeration EnableCap.
	/// </summary>
	public enum EnableCap
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST.
		/// </summary>
		AlphaTest = Gl.ALPHA_TEST,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		AsyncDrawPixelsSgix = Gl.ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		AsyncHistogramSgix = Gl.ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		AsyncReadPixelsSgix = Gl.ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		AsyncTexImageSgix = Gl.ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_AUTO_NORMAL.
		/// </summary>
		AutoNormal = Gl.AUTO_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_CALLIGRAPHIC_FRAGMENT_SGIX.
		/// </summary>
		CalligraphicFragmentSgix = Gl.CALLIGRAPHIC_FRAGMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE0.
		/// </summary>
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE1.
		/// </summary>
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE2.
		/// </summary>
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE3.
		/// </summary>
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE4.
		/// </summary>
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE5.
		/// </summary>
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY.
		/// </summary>
		ColorArray = Gl.COLOR_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_COLOR_LOGIC_OP.
		/// </summary>
		ColorLogicOp = Gl.COLOR_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL.
		/// </summary>
		ColorMaterial = Gl.COLOR_MATERIAL,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SGI.
		/// </summary>
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D_EXT.
		/// </summary>
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D_EXT.
		/// </summary>
		Convolution2d = Gl.CONVOLUTION_2D,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE.
		/// </summary>
		CullFace = Gl.CULL_FACE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_TEST.
		/// </summary>
		DepthTest = Gl.DEPTH_TEST,

		/// <summary>
		/// Strongly typed for value GL_DITHER.
		/// </summary>
		Dither = Gl.DITHER,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY.
		/// </summary>
		EdgeFlagArray = Gl.EDGE_FLAG_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_FOG.
		/// </summary>
		Fog = Gl.FOG,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_SGIX.
		/// </summary>
		FogOffsetSgix = Gl.FOG_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_SGIX.
		/// </summary>
		FragmentColorMaterialSgix = Gl.FRAGMENT_COLOR_MATERIAL_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT1_SGIX.
		/// </summary>
		FragmentLight1Sgix = Gl.FRAGMENT_LIGHT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT2_SGIX.
		/// </summary>
		FragmentLight2Sgix = Gl.FRAGMENT_LIGHT2_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT3_SGIX.
		/// </summary>
		FragmentLight3Sgix = Gl.FRAGMENT_LIGHT3_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT4_SGIX.
		/// </summary>
		FragmentLight4Sgix = Gl.FRAGMENT_LIGHT4_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT5_SGIX.
		/// </summary>
		FragmentLight5Sgix = Gl.FRAGMENT_LIGHT5_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT6_SGIX.
		/// </summary>
		FragmentLight6Sgix = Gl.FRAGMENT_LIGHT6_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT7_SGIX.
		/// </summary>
		FragmentLight7Sgix = Gl.FRAGMENT_LIGHT7_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHTING_SGIX.
		/// </summary>
		FragmentLightingSgix = Gl.FRAGMENT_LIGHTING_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_SGIX.
		/// </summary>
		FramezoomSgix = Gl.FRAMEZOOM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_EXT.
		/// </summary>
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY.
		/// </summary>
		IndexArray = Gl.INDEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_INDEX_LOGIC_OP.
		/// </summary>
		IndexLogicOp = Gl.INDEX_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_INTERLACE_SGIX.
		/// </summary>
		InterlaceSgix = Gl.INTERLACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_IR_INSTRUMENT1_SGIX.
		/// </summary>
		IrInstrument1Sgix = Gl.IR_INSTRUMENT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		Light7 = Gl.LIGHT7,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING.
		/// </summary>
		Lighting = Gl.LIGHTING,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH.
		/// </summary>
		LineSmooth = Gl.LINE_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE.
		/// </summary>
		LineStipple = Gl.LINE_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_EXT.
		/// </summary>
		Minmax = Gl.MINMAX,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_SGIS.
		/// </summary>
		Multisample = Gl.MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_NORMALIZE.
		/// </summary>
		Normalize = Gl.NORMALIZE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY.
		/// </summary>
		NormalArray = Gl.NORMAL_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEXTURE_SGIS.
		/// </summary>
		PixelTextureSgis = Gl.PIXEL_TEXTURE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_SGIX.
		/// </summary>
		PixelTexGenSgix = Gl.PIXEL_TEX_GEN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH.
		/// </summary>
		PointSmooth = Gl.POINT_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FILL.
		/// </summary>
		PolygonOffsetFill = Gl.POLYGON_OFFSET_FILL,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_LINE.
		/// </summary>
		PolygonOffsetLine = Gl.POLYGON_OFFSET_LINE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_POINT.
		/// </summary>
		PolygonOffsetPoint = Gl.POLYGON_OFFSET_POINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH.
		/// </summary>
		PolygonSmooth = Gl.POLYGON_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE.
		/// </summary>
		PolygonStipple = Gl.POLYGON_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_SGIX.
		/// </summary>
		ReferencePlaneSgix = Gl.REFERENCE_PLANE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESCALE_NORMAL_EXT.
		/// </summary>
		RescaleNormal = Gl.RESCALE_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_MASK_SGIS.
		/// </summary>
		SampleAlphaToMaskExt = Gl.SAMPLE_ALPHA_TO_MASK_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_ONE_SGIS.
		/// </summary>
		SampleAlphaToOne = Gl.SAMPLE_ALPHA_TO_ONE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_SGIS.
		/// </summary>
		SampleMaskSgis = Gl.SAMPLE_MASK_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_TEST.
		/// </summary>
		ScissorTest = Gl.SCISSOR_TEST,

		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D_EXT.
		/// </summary>
		Separable2d = Gl.SEPARABLE_2D,

		/// <summary>
		/// Strongly typed for value GL_SHARED_TEXTURE_PALETTE_EXT.
		/// </summary>
		SharedTexturePaletteExt = Gl.SHARED_TEXTURE_PALETTE_EXT,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_SGIX.
		/// </summary>
		SpriteSgix = Gl.SPRITE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_TEST.
		/// </summary>
		StencilTest = Gl.STENCIL_TEST,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_EXT.
		/// </summary>
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY.
		/// </summary>
		TextureCoordArray = Gl.TEXTURE_COORD_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_Q.
		/// </summary>
		TextureGenQ = Gl.TEXTURE_GEN_Q,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_R.
		/// </summary>
		TextureGenR = Gl.TEXTURE_GEN_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_S.
		/// </summary>
		TextureGenS = Gl.TEXTURE_GEN_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_T.
		/// </summary>
		TextureGenT = Gl.TEXTURE_GEN_T,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY.
		/// </summary>
		VertexArray = Gl.VERTEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_SRGB.
		/// </summary>
		FramebufferSrgb = Gl.FRAMEBUFFER_SRGB,

		/// <summary>
		/// Strongly typed for value GL_PRIMITIVE_RESTART.
		/// </summary>
		PrimitiveRestart = Gl.PRIMITIVE_RESTART,

		/// <summary>
		/// Strongly typed for value GL_PRIMITIVE_RESTART_NV.
		/// </summary>
		PrimitiveRestartNv = Gl.PRIMITIVE_RESTART_NV,

		/// <summary>
		/// Strongly typed for value GL_RASTERIZER_DISCARD.
		/// </summary>
		RasterizerDiscard = Gl.RASTERIZER_DISCARD,

	}

	/// <summary>
	/// Strongly typed enumeration ErrorCode.
	/// </summary>
	public enum ErrorCode
	{
		/// <summary>
		/// Strongly typed for value GL_INVALID_ENUM.
		/// </summary>
		InvalidEnum = Gl.INVALID_ENUM,

		/// <summary>
		/// Strongly typed for value GL_INVALID_FRAMEBUFFER_OPERATION, GL_INVALID_FRAMEBUFFER_OPERATION_EXT.
		/// </summary>
		InvalidFramebufferOperation = Gl.INVALID_FRAMEBUFFER_OPERATION,

		/// <summary>
		/// Strongly typed for value GL_INVALID_OPERATION.
		/// </summary>
		InvalidOperation = Gl.INVALID_OPERATION,

		/// <summary>
		/// Strongly typed for value GL_INVALID_VALUE.
		/// </summary>
		InvalidValue = Gl.INVALID_VALUE,

		/// <summary>
		/// Strongly typed for value GL_NO_ERROR.
		/// </summary>
		NoError = Gl.NO_ERROR,

		/// <summary>
		/// Strongly typed for value GL_OUT_OF_MEMORY.
		/// </summary>
		OutOfMemory = Gl.OUT_OF_MEMORY,

		/// <summary>
		/// Strongly typed for value GL_STACK_OVERFLOW.
		/// </summary>
		StackOverflow = Gl.STACK_OVERFLOW,

		/// <summary>
		/// Strongly typed for value GL_STACK_UNDERFLOW.
		/// </summary>
		StackUnderflow = Gl.STACK_UNDERFLOW,

		/// <summary>
		/// Strongly typed for value GL_TABLE_TOO_LARGE, GL_TABLE_TOO_LARGE_EXT.
		/// </summary>
		TableTooLarge = Gl.TABLE_TOO_LARGE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_TOO_LARGE_EXT.
		/// </summary>
		TextureTooLargeExt = Gl.TEXTURE_TOO_LARGE_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration FeedbackType.
	/// </summary>
	public enum FeedbackType
	{
		/// <summary>
		/// Strongly typed for value GL_2D.
		/// </summary>
		_2d = Gl._2D,

		/// <summary>
		/// Strongly typed for value GL_3D.
		/// </summary>
		_3d = Gl._3D,

		/// <summary>
		/// Strongly typed for value GL_3D_COLOR.
		/// </summary>
		_3dColor = Gl._3D_COLOR,

		/// <summary>
		/// Strongly typed for value GL_3D_COLOR_TEXTURE.
		/// </summary>
		_3dColorTexture = Gl._3D_COLOR_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_4D_COLOR_TEXTURE.
		/// </summary>
		_4dColorTexture = Gl._4D_COLOR_TEXTURE,

	}

	/// <summary>
	/// Strongly typed enumeration FeedBackToken.
	/// </summary>
	public enum FeedBackToken
	{
		/// <summary>
		/// Strongly typed for value GL_BITMAP_TOKEN.
		/// </summary>
		BitmapToken = Gl.BITMAP_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_COPY_PIXEL_TOKEN.
		/// </summary>
		CopyPixelToken = Gl.COPY_PIXEL_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_DRAW_PIXEL_TOKEN.
		/// </summary>
		DrawPixelToken = Gl.DRAW_PIXEL_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_LINE_RESET_TOKEN.
		/// </summary>
		LineResetToken = Gl.LINE_RESET_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_LINE_TOKEN.
		/// </summary>
		LineToken = Gl.LINE_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_PASS_THROUGH_TOKEN.
		/// </summary>
		PassThroughToken = Gl.PASS_THROUGH_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_POINT_TOKEN.
		/// </summary>
		PointToken = Gl.POINT_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_TOKEN.
		/// </summary>
		PolygonToken = Gl.POLYGON_TOKEN,

	}

	/// <summary>
	/// Strongly typed enumeration FfdMaskSGIX.
	/// </summary>
	[Flags()]
	public enum FfdMaskSGIX : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration FfdTargetSGIX.
	/// </summary>
	public enum FfdTargetSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_DEFORMATION_SGIX.
		/// </summary>
		GeometryDeformationSgix = Gl.GEOMETRY_DEFORMATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEFORMATION_SGIX.
		/// </summary>
		TextureDeformationSgix = Gl.TEXTURE_DEFORMATION_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration FogCoordinatePointerType.
	/// </summary>
	public enum FogCoordinatePointerType
	{
		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

	}

	/// <summary>
	/// Strongly typed enumeration FogMode.
	/// </summary>
	public enum FogMode
	{
		/// <summary>
		/// Strongly typed for value GL_EXP.
		/// </summary>
		Exp = Gl.EXP,

		/// <summary>
		/// Strongly typed for value GL_EXP2.
		/// </summary>
		Exp2 = Gl.EXP2,

		/// <summary>
		/// Strongly typed for value GL_FOG_FUNC_SGIS.
		/// </summary>
		FogFuncSgis = Gl.FOG_FUNC_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		Linear = Gl.LINEAR,

	}

	/// <summary>
	/// Strongly typed enumeration FogParameter.
	/// </summary>
	public enum FogParameter
	{
		/// <summary>
		/// Strongly typed for value GL_FOG_COLOR.
		/// </summary>
		FogColor = Gl.FOG_COLOR,

		/// <summary>
		/// Strongly typed for value GL_FOG_DENSITY.
		/// </summary>
		FogDensity = Gl.FOG_DENSITY,

		/// <summary>
		/// Strongly typed for value GL_FOG_END.
		/// </summary>
		FogEnd = Gl.FOG_END,

		/// <summary>
		/// Strongly typed for value GL_FOG_INDEX.
		/// </summary>
		FogIndex = Gl.FOG_INDEX,

		/// <summary>
		/// Strongly typed for value GL_FOG_MODE.
		/// </summary>
		FogMode = Gl.FOG_MODE,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_VALUE_SGIX.
		/// </summary>
		FogOffsetValueSgix = Gl.FOG_OFFSET_VALUE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_START.
		/// </summary>
		FogStart = Gl.FOG_START,

	}

	/// <summary>
	/// Strongly typed enumeration FogPointerTypeEXT.
	/// </summary>
	public enum FogPointerTypeEXT
	{
		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

	}

	/// <summary>
	/// Strongly typed enumeration FogPointerTypeIBM.
	/// </summary>
	public enum FogPointerTypeIBM
	{
		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

	}

	/// <summary>
	/// Strongly typed enumeration FragmentLightModelParameterSGIX.
	/// </summary>
	public enum FragmentLightModelParameterSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX.
		/// </summary>
		FragmentLightModelAmbientSgix = Gl.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX.
		/// </summary>
		FragmentLightModelLocalViewerSgix = Gl.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX.
		/// </summary>
		FragmentLightModelNormalInterpolationSgix = Gl.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX.
		/// </summary>
		FragmentLightModelTwoSideSgix = Gl.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration FrontFaceDirection.
	/// </summary>
	public enum FrontFaceDirection
	{
		/// <summary>
		/// Strongly typed for value GL_CCW.
		/// </summary>
		Ccw = Gl.CCW,

		/// <summary>
		/// Strongly typed for value GL_CW.
		/// </summary>
		Cw = Gl.CW,

	}

	/// <summary>
	/// Strongly typed enumeration GetColorTableParameterPNameSGI.
	/// </summary>
	public enum GetColorTableParameterPNameSGI
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_ALPHA_SIZE_SGI.
		/// </summary>
		ColorTableAlphaSize = Gl.COLOR_TABLE_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BIAS_SGI.
		/// </summary>
		ColorTableBias = Gl.COLOR_TABLE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BLUE_SIZE_SGI.
		/// </summary>
		ColorTableBlueSize = Gl.COLOR_TABLE_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_FORMAT_SGI.
		/// </summary>
		ColorTableFormat = Gl.COLOR_TABLE_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_GREEN_SIZE_SGI.
		/// </summary>
		ColorTableGreenSize = Gl.COLOR_TABLE_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_INTENSITY_SIZE_SGI.
		/// </summary>
		ColorTableIntensitySize = Gl.COLOR_TABLE_INTENSITY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_LUMINANCE_SIZE_SGI.
		/// </summary>
		ColorTableLuminanceSize = Gl.COLOR_TABLE_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_RED_SIZE_SGI.
		/// </summary>
		ColorTableRedSize = Gl.COLOR_TABLE_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SCALE_SGI.
		/// </summary>
		ColorTableScale = Gl.COLOR_TABLE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_WIDTH_SGI.
		/// </summary>
		ColorTableWidth = Gl.COLOR_TABLE_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration GetConvolutionParameter.
	/// </summary>
	public enum GetConvolutionParameter
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_BORDER_MODE_EXT.
		/// </summary>
		ConvolutionBorderMode = Gl.CONVOLUTION_BORDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_BIAS_EXT.
		/// </summary>
		ConvolutionFilterBias = Gl.CONVOLUTION_FILTER_BIAS,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_SCALE_EXT.
		/// </summary>
		ConvolutionFilterScale = Gl.CONVOLUTION_FILTER_SCALE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FORMAT_EXT.
		/// </summary>
		ConvolutionFormat = Gl.CONVOLUTION_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HEIGHT_EXT.
		/// </summary>
		ConvolutionHeight = Gl.CONVOLUTION_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_WIDTH_EXT.
		/// </summary>
		ConvolutionWidth = Gl.CONVOLUTION_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CONVOLUTION_HEIGHT_EXT.
		/// </summary>
		MaxConvolutionHeight = Gl.MAX_CONVOLUTION_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_MAX_CONVOLUTION_WIDTH_EXT.
		/// </summary>
		MaxConvolutionWidth = Gl.MAX_CONVOLUTION_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration GetHistogramParameterPNameEXT.
	/// </summary>
	public enum GetHistogramParameterPNameEXT
	{
		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_ALPHA_SIZE_EXT.
		/// </summary>
		HistogramAlphaSize = Gl.HISTOGRAM_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_BLUE_SIZE_EXT.
		/// </summary>
		HistogramBlueSize = Gl.HISTOGRAM_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_FORMAT_EXT.
		/// </summary>
		HistogramFormat = Gl.HISTOGRAM_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_GREEN_SIZE_EXT.
		/// </summary>
		HistogramGreenSize = Gl.HISTOGRAM_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_LUMINANCE_SIZE_EXT.
		/// </summary>
		HistogramLuminanceSize = Gl.HISTOGRAM_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_RED_SIZE_EXT.
		/// </summary>
		HistogramRedSize = Gl.HISTOGRAM_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_SINK_EXT.
		/// </summary>
		HistogramSink = Gl.HISTOGRAM_SINK,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_WIDTH_EXT.
		/// </summary>
		HistogramWidth = Gl.HISTOGRAM_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration GetMapQuery.
	/// </summary>
	public enum GetMapQuery
	{
		/// <summary>
		/// Strongly typed for value GL_COEFF.
		/// </summary>
		Coeff = Gl.COEFF,

		/// <summary>
		/// Strongly typed for value GL_DOMAIN.
		/// </summary>
		Domain = Gl.DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_ORDER.
		/// </summary>
		Order = Gl.ORDER,

	}

	/// <summary>
	/// Strongly typed enumeration GetMinmaxParameterPNameEXT.
	/// </summary>
	public enum GetMinmaxParameterPNameEXT
	{
		/// <summary>
		/// Strongly typed for value GL_MINMAX_FORMAT, GL_MINMAX_FORMAT_EXT.
		/// </summary>
		MinmaxFormat = Gl.MINMAX_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_SINK, GL_MINMAX_SINK_EXT.
		/// </summary>
		MinmaxSink = Gl.MINMAX_SINK,

	}

	/// <summary>
	/// Strongly typed enumeration GetPixelMap.
	/// </summary>
	public enum GetPixelMap
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A.
		/// </summary>
		PixelMapAToA = Gl.PIXEL_MAP_A_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B.
		/// </summary>
		PixelMapBToB = Gl.PIXEL_MAP_B_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G.
		/// </summary>
		PixelMapGToG = Gl.PIXEL_MAP_G_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A.
		/// </summary>
		PixelMapIToA = Gl.PIXEL_MAP_I_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B.
		/// </summary>
		PixelMapIToB = Gl.PIXEL_MAP_I_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G.
		/// </summary>
		PixelMapIToG = Gl.PIXEL_MAP_I_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I.
		/// </summary>
		PixelMapIToI = Gl.PIXEL_MAP_I_TO_I,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R.
		/// </summary>
		PixelMapIToR = Gl.PIXEL_MAP_I_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R.
		/// </summary>
		PixelMapRToR = Gl.PIXEL_MAP_R_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S.
		/// </summary>
		PixelMapSToS = Gl.PIXEL_MAP_S_TO_S,

	}

	/// <summary>
	/// Strongly typed enumeration GetPName.
	/// </summary>
	public enum GetPName
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_ALPHA_BITS.
		/// </summary>
		AccumAlphaBits = Gl.ACCUM_ALPHA_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_BLUE_BITS.
		/// </summary>
		AccumBlueBits = Gl.ACCUM_BLUE_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_CLEAR_VALUE.
		/// </summary>
		AccumClearValue = Gl.ACCUM_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_GREEN_BITS.
		/// </summary>
		AccumGreenBits = Gl.ACCUM_GREEN_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_RED_BITS.
		/// </summary>
		AccumRedBits = Gl.ACCUM_RED_BITS,

		/// <summary>
		/// Strongly typed for value GL_ALIASED_LINE_WIDTH_RANGE.
		/// </summary>
		AliasedLineWidthRange = Gl.ALIASED_LINE_WIDTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_ALIASED_POINT_SIZE_RANGE.
		/// </summary>
		AliasedPointSizeRange = Gl.ALIASED_POINT_SIZE_RANGE,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_BIAS.
		/// </summary>
		AlphaBias = Gl.ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_BITS.
		/// </summary>
		AlphaBits = Gl.ALPHA_BITS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_SCALE.
		/// </summary>
		AlphaScale = Gl.ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST.
		/// </summary>
		AlphaTest = Gl.ALPHA_TEST,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST_FUNC.
		/// </summary>
		AlphaTestFunc = Gl.ALPHA_TEST_FUNC,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST_REF.
		/// </summary>
		AlphaTestRef = Gl.ALPHA_TEST_REF,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		AsyncDrawPixelsSgix = Gl.ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		AsyncHistogramSgix = Gl.ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_MARKER_SGIX.
		/// </summary>
		AsyncMarkerSgix = Gl.ASYNC_MARKER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		AsyncReadPixelsSgix = Gl.ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		AsyncTexImageSgix = Gl.ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ATTRIB_STACK_DEPTH.
		/// </summary>
		AttribStackDepth = Gl.ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_AUTO_NORMAL.
		/// </summary>
		AutoNormal = Gl.AUTO_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_AUX_BUFFERS.
		/// </summary>
		AuxBuffers = Gl.AUX_BUFFERS,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_BLEND_COLOR_EXT.
		/// </summary>
		BlendColor = Gl.BLEND_COLOR,

		/// <summary>
		/// Strongly typed for value GL_BLEND_DST.
		/// </summary>
		BlendDst = Gl.BLEND_DST,

		/// <summary>
		/// Strongly typed for value GL_BLEND_EQUATION_EXT.
		/// </summary>
		BlendEquation = Gl.BLEND_EQUATION,

		/// <summary>
		/// Strongly typed for value GL_BLEND_SRC.
		/// </summary>
		BlendSrc = Gl.BLEND_SRC,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BIAS.
		/// </summary>
		BlueBias = Gl.BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BITS.
		/// </summary>
		BlueBits = Gl.BLUE_BITS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_SCALE.
		/// </summary>
		BlueScale = Gl.BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_CALLIGRAPHIC_FRAGMENT_SGIX.
		/// </summary>
		CalligraphicFragmentSgix = Gl.CALLIGRAPHIC_FRAGMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_ATTRIB_STACK_DEPTH.
		/// </summary>
		ClientAttribStackDepth = Gl.CLIENT_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE0.
		/// </summary>
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE1.
		/// </summary>
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE2.
		/// </summary>
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE3.
		/// </summary>
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE4.
		/// </summary>
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE5.
		/// </summary>
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY.
		/// </summary>
		ColorArray = Gl.COLOR_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_COUNT_EXT.
		/// </summary>
		ColorArrayCountExt = Gl.COLOR_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_SIZE.
		/// </summary>
		ColorArraySize = Gl.COLOR_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_STRIDE.
		/// </summary>
		ColorArrayStride = Gl.COLOR_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_TYPE.
		/// </summary>
		ColorArrayType = Gl.COLOR_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_CLEAR_VALUE.
		/// </summary>
		ColorClearValue = Gl.COLOR_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_LOGIC_OP.
		/// </summary>
		ColorLogicOp = Gl.COLOR_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL.
		/// </summary>
		ColorMaterial = Gl.COLOR_MATERIAL,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL_FACE.
		/// </summary>
		ColorMaterialFace = Gl.COLOR_MATERIAL_FACE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL_PARAMETER.
		/// </summary>
		ColorMaterialParameter = Gl.COLOR_MATERIAL_PARAMETER,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATRIX_SGI.
		/// </summary>
		ColorMatrix = Gl.COLOR_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATRIX_STACK_DEPTH_SGI.
		/// </summary>
		ColorMatrixStackDepth = Gl.COLOR_MATRIX_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SGI.
		/// </summary>
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_WRITEMASK.
		/// </summary>
		ColorWritemask = Gl.COLOR_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D_EXT.
		/// </summary>
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D_EXT.
		/// </summary>
		Convolution2d = Gl.CONVOLUTION_2D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HINT_SGIX.
		/// </summary>
		ConvolutionHintSgix = Gl.CONVOLUTION_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE.
		/// </summary>
		CullFace = Gl.CULL_FACE,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE_MODE.
		/// </summary>
		CullFaceMode = Gl.CULL_FACE_MODE,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_COLOR.
		/// </summary>
		CurrentColor = Gl.CURRENT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_INDEX.
		/// </summary>
		CurrentIndex = Gl.CURRENT_INDEX,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_NORMAL.
		/// </summary>
		CurrentNormal = Gl.CURRENT_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_COLOR.
		/// </summary>
		CurrentRasterColor = Gl.CURRENT_RASTER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_DISTANCE.
		/// </summary>
		CurrentRasterDistance = Gl.CURRENT_RASTER_DISTANCE,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_INDEX.
		/// </summary>
		CurrentRasterIndex = Gl.CURRENT_RASTER_INDEX,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_POSITION.
		/// </summary>
		CurrentRasterPosition = Gl.CURRENT_RASTER_POSITION,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_POSITION_VALID.
		/// </summary>
		CurrentRasterPositionValid = Gl.CURRENT_RASTER_POSITION_VALID,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_TEXTURE_COORDS.
		/// </summary>
		CurrentRasterTextureCoords = Gl.CURRENT_RASTER_TEXTURE_COORDS,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_TEXTURE_COORDS.
		/// </summary>
		CurrentTextureCoords = Gl.CURRENT_TEXTURE_COORDS,

		/// <summary>
		/// Strongly typed for value GL_DEFORMATIONS_MASK_SGIX.
		/// </summary>
		DeformationsMaskSgix = Gl.DEFORMATIONS_MASK_SGIX,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BIAS.
		/// </summary>
		DepthBias = Gl.DEPTH_BIAS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BITS.
		/// </summary>
		DepthBits = Gl.DEPTH_BITS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_CLEAR_VALUE.
		/// </summary>
		DepthClearValue = Gl.DEPTH_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_FUNC.
		/// </summary>
		DepthFunc = Gl.DEPTH_FUNC,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_RANGE.
		/// </summary>
		DepthRange = Gl.DEPTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_SCALE.
		/// </summary>
		DepthScale = Gl.DEPTH_SCALE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_TEST.
		/// </summary>
		DepthTest = Gl.DEPTH_TEST,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_WRITEMASK.
		/// </summary>
		DepthWritemask = Gl.DEPTH_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_2D_BINDING_SGIS.
		/// </summary>
		DetailTexture2dBindingSgis = Gl.DETAIL_TEXTURE_2D_BINDING_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DISTANCE_ATTENUATION_SGIS.
		/// </summary>
		DistanceAttenuationExt = Gl.DISTANCE_ATTENUATION_EXT,

		/// <summary>
		/// Strongly typed for value GL_DITHER.
		/// </summary>
		Dither = Gl.DITHER,

		/// <summary>
		/// Strongly typed for value GL_DOUBLEBUFFER.
		/// </summary>
		Doublebuffer = Gl.DOUBLEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRAW_BUFFER.
		/// </summary>
		DrawBuffer = Gl.DRAW_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG.
		/// </summary>
		EdgeFlag = Gl.EDGE_FLAG,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY.
		/// </summary>
		EdgeFlagArray = Gl.EDGE_FLAG_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_COUNT_EXT.
		/// </summary>
		EdgeFlagArrayCountExt = Gl.EDGE_FLAG_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_STRIDE.
		/// </summary>
		EdgeFlagArrayStride = Gl.EDGE_FLAG_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_SIZE.
		/// </summary>
		FeedbackBufferSize = Gl.FEEDBACK_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_TYPE.
		/// </summary>
		FeedbackBufferType = Gl.FEEDBACK_BUFFER_TYPE,

		/// <summary>
		/// Strongly typed for value GL_FOG.
		/// </summary>
		Fog = Gl.FOG,

		/// <summary>
		/// Strongly typed for value GL_FOG_COLOR.
		/// </summary>
		FogColor = Gl.FOG_COLOR,

		/// <summary>
		/// Strongly typed for value GL_FOG_DENSITY.
		/// </summary>
		FogDensity = Gl.FOG_DENSITY,

		/// <summary>
		/// Strongly typed for value GL_FOG_END.
		/// </summary>
		FogEnd = Gl.FOG_END,

		/// <summary>
		/// Strongly typed for value GL_FOG_FUNC_POINTS_SGIS.
		/// </summary>
		FogFuncPointsSgis = Gl.FOG_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_FOG_HINT.
		/// </summary>
		FogHint = Gl.FOG_HINT,

		/// <summary>
		/// Strongly typed for value GL_FOG_INDEX.
		/// </summary>
		FogIndex = Gl.FOG_INDEX,

		/// <summary>
		/// Strongly typed for value GL_FOG_MODE.
		/// </summary>
		FogMode = Gl.FOG_MODE,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_SGIX.
		/// </summary>
		FogOffsetSgix = Gl.FOG_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_VALUE_SGIX.
		/// </summary>
		FogOffsetValueSgix = Gl.FOG_OFFSET_VALUE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_START.
		/// </summary>
		FogStart = Gl.FOG_START,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX.
		/// </summary>
		FragmentColorMaterialFaceSgix = Gl.FRAGMENT_COLOR_MATERIAL_FACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX.
		/// </summary>
		FragmentColorMaterialParameterSgix = Gl.FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_SGIX.
		/// </summary>
		FragmentColorMaterialSgix = Gl.FRAGMENT_COLOR_MATERIAL_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHTING_SGIX.
		/// </summary>
		FragmentLightingSgix = Gl.FRAGMENT_LIGHTING_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX.
		/// </summary>
		FragmentLightModelAmbientSgix = Gl.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX.
		/// </summary>
		FragmentLightModelLocalViewerSgix = Gl.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX.
		/// </summary>
		FragmentLightModelNormalInterpolationSgix = Gl.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX.
		/// </summary>
		FragmentLightModelTwoSideSgix = Gl.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_FACTOR_SGIX.
		/// </summary>
		FramezoomFactorSgix = Gl.FRAMEZOOM_FACTOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_SGIX.
		/// </summary>
		FramezoomSgix = Gl.FRAMEZOOM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRONT_FACE.
		/// </summary>
		FrontFace = Gl.FRONT_FACE,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_HINT_SGIS.
		/// </summary>
		GenerateMipmapHint = Gl.GENERATE_MIPMAP_HINT,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BIAS.
		/// </summary>
		GreenBias = Gl.GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BITS.
		/// </summary>
		GreenBits = Gl.GREEN_BITS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_SCALE.
		/// </summary>
		GreenScale = Gl.GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_EXT.
		/// </summary>
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY.
		/// </summary>
		IndexArray = Gl.INDEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_COUNT_EXT.
		/// </summary>
		IndexArrayCountExt = Gl.INDEX_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_STRIDE.
		/// </summary>
		IndexArrayStride = Gl.INDEX_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_TYPE.
		/// </summary>
		IndexArrayType = Gl.INDEX_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_BITS.
		/// </summary>
		IndexBits = Gl.INDEX_BITS,

		/// <summary>
		/// Strongly typed for value GL_INDEX_CLEAR_VALUE.
		/// </summary>
		IndexClearValue = Gl.INDEX_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_LOGIC_OP, GL_LOGIC_OP.
		/// </summary>
		LogicOp = Gl.LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_INDEX_MODE.
		/// </summary>
		IndexMode = Gl.INDEX_MODE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_OFFSET.
		/// </summary>
		IndexOffset = Gl.INDEX_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_INDEX_SHIFT.
		/// </summary>
		IndexShift = Gl.INDEX_SHIFT,

		/// <summary>
		/// Strongly typed for value GL_INDEX_WRITEMASK.
		/// </summary>
		IndexWritemask = Gl.INDEX_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_INSTRUMENT_MEASUREMENTS_SGIX.
		/// </summary>
		InstrumentMeasurementsSgix = Gl.INSTRUMENT_MEASUREMENTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_INTERLACE_SGIX.
		/// </summary>
		InterlaceSgix = Gl.INTERLACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_IR_INSTRUMENT1_SGIX.
		/// </summary>
		IrInstrument1Sgix = Gl.IR_INSTRUMENT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		Light7 = Gl.LIGHT7,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING.
		/// </summary>
		Lighting = Gl.LIGHTING,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_ENV_MODE_SGIX.
		/// </summary>
		LightEnvModeSgix = Gl.LIGHT_ENV_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_AMBIENT.
		/// </summary>
		LightModelAmbient = Gl.LIGHT_MODEL_AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_COLOR_CONTROL.
		/// </summary>
		LightModelColorControl = Gl.LIGHT_MODEL_COLOR_CONTROL,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_LOCAL_VIEWER.
		/// </summary>
		LightModelLocalViewer = Gl.LIGHT_MODEL_LOCAL_VIEWER,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_TWO_SIDE.
		/// </summary>
		LightModelTwoSide = Gl.LIGHT_MODEL_TWO_SIDE,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH.
		/// </summary>
		LineSmooth = Gl.LINE_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH_HINT.
		/// </summary>
		LineSmoothHint = Gl.LINE_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE.
		/// </summary>
		LineStipple = Gl.LINE_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE_PATTERN.
		/// </summary>
		LineStipplePattern = Gl.LINE_STIPPLE_PATTERN,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE_REPEAT.
		/// </summary>
		LineStippleRepeat = Gl.LINE_STIPPLE_REPEAT,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH.
		/// </summary>
		LineWidth = Gl.LINE_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH_GRANULARITY, GL_SMOOTH_LINE_WIDTH_GRANULARITY.
		/// </summary>
		LineWidthGranularity = Gl.LINE_WIDTH_GRANULARITY,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH_RANGE, GL_SMOOTH_LINE_WIDTH_RANGE.
		/// </summary>
		LineWidthRange = Gl.LINE_WIDTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_LIST_BASE.
		/// </summary>
		ListBase = Gl.LIST_BASE,

		/// <summary>
		/// Strongly typed for value GL_LIST_INDEX.
		/// </summary>
		ListIndex = Gl.LIST_INDEX,

		/// <summary>
		/// Strongly typed for value GL_LIST_MODE.
		/// </summary>
		ListMode = Gl.LIST_MODE,

		/// <summary>
		/// Strongly typed for value GL_LOGIC_OP_MODE.
		/// </summary>
		LogicOpMode = Gl.LOGIC_OP_MODE,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_GRID_DOMAIN.
		/// </summary>
		Map1GridDomain = Gl.MAP1_GRID_DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_MAP1_GRID_SEGMENTS.
		/// </summary>
		Map1GridSegments = Gl.MAP1_GRID_SEGMENTS,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_GRID_DOMAIN.
		/// </summary>
		Map2GridDomain = Gl.MAP2_GRID_DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_MAP2_GRID_SEGMENTS.
		/// </summary>
		Map2GridSegments = Gl.MAP2_GRID_SEGMENTS,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP_COLOR.
		/// </summary>
		MapColor = Gl.MAP_COLOR,

		/// <summary>
		/// Strongly typed for value GL_MAP_STENCIL.
		/// </summary>
		MapStencil = Gl.MAP_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_MATRIX_MODE.
		/// </summary>
		MatrixMode = Gl.MATRIX_MODE,

		/// <summary>
		/// Strongly typed for value GL_MAX_3D_TEXTURE_SIZE_EXT.
		/// </summary>
		Max3dTextureSize = Gl.MAX_3D_TEXTURE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_MAX_4D_TEXTURE_SIZE_SGIS.
		/// </summary>
		Max4dTextureSizeSgis = Gl.MAX_4D_TEXTURE_SIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_MAX_ACTIVE_LIGHTS_SGIX.
		/// </summary>
		MaxActiveLightsSgix = Gl.MAX_ACTIVE_LIGHTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		MaxAsyncDrawPixelsSgix = Gl.MAX_ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		MaxAsyncHistogramSgix = Gl.MAX_ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		MaxAsyncReadPixelsSgix = Gl.MAX_ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		MaxAsyncTexImageSgix = Gl.MAX_ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ATTRIB_STACK_DEPTH.
		/// </summary>
		MaxAttribStackDepth = Gl.MAX_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIENT_ATTRIB_STACK_DEPTH.
		/// </summary>
		MaxClientAttribStackDepth = Gl.MAX_CLIENT_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		MaxClipmapDepthSgix = Gl.MAX_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		MaxClipmapVirtualDepthSgix = Gl.MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIP_DISTANCES, GL_MAX_CLIP_PLANES.
		/// </summary>
		MaxClipPlanes = Gl.MAX_CLIP_PLANES,

		/// <summary>
		/// Strongly typed for value GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI.
		/// </summary>
		MaxColorMatrixStackDepth = Gl.MAX_COLOR_MATRIX_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_EVAL_ORDER.
		/// </summary>
		MaxEvalOrder = Gl.MAX_EVAL_ORDER,

		/// <summary>
		/// Strongly typed for value GL_MAX_FOG_FUNC_POINTS_SGIS.
		/// </summary>
		MaxFogFuncPointsSgis = Gl.MAX_FOG_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_MAX_FRAGMENT_LIGHTS_SGIX.
		/// </summary>
		MaxFragmentLightsSgix = Gl.MAX_FRAGMENT_LIGHTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_FRAMEZOOM_FACTOR_SGIX.
		/// </summary>
		MaxFramezoomFactorSgix = Gl.MAX_FRAMEZOOM_FACTOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_LIGHTS.
		/// </summary>
		MaxLights = Gl.MAX_LIGHTS,

		/// <summary>
		/// Strongly typed for value GL_MAX_LIST_NESTING.
		/// </summary>
		MaxListNesting = Gl.MAX_LIST_NESTING,

		/// <summary>
		/// Strongly typed for value GL_MAX_MODELVIEW_STACK_DEPTH.
		/// </summary>
		MaxModelviewStackDepth = Gl.MAX_MODELVIEW_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_NAME_STACK_DEPTH.
		/// </summary>
		MaxNameStackDepth = Gl.MAX_NAME_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_PIXEL_MAP_TABLE.
		/// </summary>
		MaxPixelMapTable = Gl.MAX_PIXEL_MAP_TABLE,

		/// <summary>
		/// Strongly typed for value GL_MAX_PROJECTION_STACK_DEPTH.
		/// </summary>
		MaxProjectionStackDepth = Gl.MAX_PROJECTION_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_TEXTURE_SIZE.
		/// </summary>
		MaxTextureSize = Gl.MAX_TEXTURE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_MAX_TEXTURE_STACK_DEPTH.
		/// </summary>
		MaxTextureStackDepth = Gl.MAX_TEXTURE_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_VIEWPORT_DIMS.
		/// </summary>
		MaxViewportDims = Gl.MAX_VIEWPORT_DIMS,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_EXT.
		/// </summary>
		Minmax = Gl.MINMAX,

		/// <summary>
		/// Strongly typed for value GL_MODELVIEW0_MATRIX_EXT, GL_MODELVIEW_MATRIX.
		/// </summary>
		ModelviewMatrix = Gl.MODELVIEW_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_MODELVIEW0_STACK_DEPTH_EXT, GL_MODELVIEW_STACK_DEPTH.
		/// </summary>
		ModelviewStackDepth = Gl.MODELVIEW_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_SGIS.
		/// </summary>
		Multisample = Gl.MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_NAME_STACK_DEPTH.
		/// </summary>
		NameStackDepth = Gl.NAME_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_NORMALIZE.
		/// </summary>
		Normalize = Gl.NORMALIZE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY.
		/// </summary>
		NormalArray = Gl.NORMAL_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_COUNT_EXT.
		/// </summary>
		NormalArrayCountExt = Gl.NORMAL_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_STRIDE.
		/// </summary>
		NormalArrayStride = Gl.NORMAL_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_TYPE.
		/// </summary>
		NormalArrayType = Gl.NORMAL_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_PACK_ALIGNMENT.
		/// </summary>
		PackAlignment = Gl.PACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_PACK_CMYK_HINT_EXT.
		/// </summary>
		PackCmykHintExt = Gl.PACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		PackImageDepthSgis = Gl.PACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		PackImageHeight = Gl.PACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_PACK_LSB_FIRST.
		/// </summary>
		PackLsbFirst = Gl.PACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_SGIX.
		/// </summary>
		PackResampleSgix = Gl.PACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_ROW_LENGTH.
		/// </summary>
		PackRowLength = Gl.PACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_IMAGES_EXT.
		/// </summary>
		PackSkipImages = Gl.PACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_PIXELS.
		/// </summary>
		PackSkipPixels = Gl.PACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_ROWS.
		/// </summary>
		PackSkipRows = Gl.PACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		PackSkipVolumesSgis = Gl.PACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		PackSubsampleRateSgix = Gl.PACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_SWAP_BYTES.
		/// </summary>
		PackSwapBytes = Gl.PACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_PERSPECTIVE_CORRECTION_HINT.
		/// </summary>
		PerspectiveCorrectionHint = Gl.PERSPECTIVE_CORRECTION_HINT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A_SIZE.
		/// </summary>
		PixelMapAToASize = Gl.PIXEL_MAP_A_TO_A_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B_SIZE.
		/// </summary>
		PixelMapBToBSize = Gl.PIXEL_MAP_B_TO_B_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G_SIZE.
		/// </summary>
		PixelMapGToGSize = Gl.PIXEL_MAP_G_TO_G_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A_SIZE.
		/// </summary>
		PixelMapIToASize = Gl.PIXEL_MAP_I_TO_A_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B_SIZE.
		/// </summary>
		PixelMapIToBSize = Gl.PIXEL_MAP_I_TO_B_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G_SIZE.
		/// </summary>
		PixelMapIToGSize = Gl.PIXEL_MAP_I_TO_G_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I_SIZE.
		/// </summary>
		PixelMapIToISize = Gl.PIXEL_MAP_I_TO_I_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R_SIZE.
		/// </summary>
		PixelMapIToRSize = Gl.PIXEL_MAP_I_TO_R_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R_SIZE.
		/// </summary>
		PixelMapRToRSize = Gl.PIXEL_MAP_R_TO_R_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S_SIZE.
		/// </summary>
		PixelMapSToSSize = Gl.PIXEL_MAP_S_TO_S_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEXTURE_SGIS.
		/// </summary>
		PixelTextureSgis = Gl.PIXEL_TEXTURE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_MODE_SGIX.
		/// </summary>
		PixelTexGenModeSgix = Gl.PIXEL_TEX_GEN_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_SGIX.
		/// </summary>
		PixelTexGenSgix = Gl.PIXEL_TEX_GEN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX.
		/// </summary>
		PixelTileBestAlignmentSgix = Gl.PIXEL_TILE_BEST_ALIGNMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_INCREMENT_SGIX.
		/// </summary>
		PixelTileCacheIncrementSgix = Gl.PIXEL_TILE_CACHE_INCREMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_SIZE_SGIX.
		/// </summary>
		PixelTileCacheSizeSgix = Gl.PIXEL_TILE_CACHE_SIZE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_DEPTH_SGIX.
		/// </summary>
		PixelTileGridDepthSgix = Gl.PIXEL_TILE_GRID_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_HEIGHT_SGIX.
		/// </summary>
		PixelTileGridHeightSgix = Gl.PIXEL_TILE_GRID_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_WIDTH_SGIX.
		/// </summary>
		PixelTileGridWidthSgix = Gl.PIXEL_TILE_GRID_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_HEIGHT_SGIX.
		/// </summary>
		PixelTileHeightSgix = Gl.PIXEL_TILE_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_WIDTH_SGIX.
		/// </summary>
		PixelTileWidthSgix = Gl.PIXEL_TILE_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POINT_FADE_THRESHOLD_SIZE_SGIS.
		/// </summary>
		PointFadeThresholdSize = Gl.POINT_FADE_THRESHOLD_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE.
		/// </summary>
		PointSize = Gl.POINT_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_GRANULARITY, GL_SMOOTH_POINT_SIZE_GRANULARITY.
		/// </summary>
		PointSizeGranularity = Gl.POINT_SIZE_GRANULARITY,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MAX_SGIS.
		/// </summary>
		PointSizeMax = Gl.POINT_SIZE_MAX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MIN_SGIS.
		/// </summary>
		PointSizeMin = Gl.POINT_SIZE_MIN,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_RANGE, GL_SMOOTH_POINT_SIZE_RANGE.
		/// </summary>
		PointSizeRange = Gl.POINT_SIZE_RANGE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH.
		/// </summary>
		PointSmooth = Gl.POINT_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH_HINT.
		/// </summary>
		PointSmoothHint = Gl.POINT_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_MODE.
		/// </summary>
		PolygonMode = Gl.POLYGON_MODE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_BIAS_EXT.
		/// </summary>
		PolygonOffsetBiasExt = Gl.POLYGON_OFFSET_BIAS_EXT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FACTOR.
		/// </summary>
		PolygonOffsetFactor = Gl.POLYGON_OFFSET_FACTOR,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FILL.
		/// </summary>
		PolygonOffsetFill = Gl.POLYGON_OFFSET_FILL,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_LINE.
		/// </summary>
		PolygonOffsetLine = Gl.POLYGON_OFFSET_LINE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_POINT.
		/// </summary>
		PolygonOffsetPoint = Gl.POLYGON_OFFSET_POINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_UNITS.
		/// </summary>
		PolygonOffsetUnits = Gl.POLYGON_OFFSET_UNITS,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH.
		/// </summary>
		PolygonSmooth = Gl.POLYGON_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH_HINT.
		/// </summary>
		PolygonSmoothHint = Gl.POLYGON_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE.
		/// </summary>
		PolygonStipple = Gl.POLYGON_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI.
		/// </summary>
		PostColorMatrixAlphaBias = Gl.POST_COLOR_MATRIX_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI.
		/// </summary>
		PostColorMatrixAlphaScale = Gl.POST_COLOR_MATRIX_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI.
		/// </summary>
		PostColorMatrixBlueBias = Gl.POST_COLOR_MATRIX_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI.
		/// </summary>
		PostColorMatrixBlueScale = Gl.POST_COLOR_MATRIX_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI.
		/// </summary>
		PostColorMatrixGreenBias = Gl.POST_COLOR_MATRIX_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI.
		/// </summary>
		PostColorMatrixGreenScale = Gl.POST_COLOR_MATRIX_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_BIAS_SGI.
		/// </summary>
		PostColorMatrixRedBias = Gl.POST_COLOR_MATRIX_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_SCALE_SGI.
		/// </summary>
		PostColorMatrixRedScale = Gl.POST_COLOR_MATRIX_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_BIAS_EXT.
		/// </summary>
		PostConvolutionAlphaBias = Gl.POST_CONVOLUTION_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_SCALE_EXT.
		/// </summary>
		PostConvolutionAlphaScale = Gl.POST_CONVOLUTION_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_BIAS_EXT.
		/// </summary>
		PostConvolutionBlueBias = Gl.POST_CONVOLUTION_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_SCALE_EXT.
		/// </summary>
		PostConvolutionBlueScale = Gl.POST_CONVOLUTION_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_BIAS_EXT.
		/// </summary>
		PostConvolutionGreenBias = Gl.POST_CONVOLUTION_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_SCALE_EXT.
		/// </summary>
		PostConvolutionGreenScale = Gl.POST_CONVOLUTION_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_BIAS_EXT.
		/// </summary>
		PostConvolutionRedBias = Gl.POST_CONVOLUTION_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_SCALE_EXT.
		/// </summary>
		PostConvolutionRedScale = Gl.POST_CONVOLUTION_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX.
		/// </summary>
		PostTextureFilterBiasRangeSgix = Gl.POST_TEXTURE_FILTER_BIAS_RANGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX.
		/// </summary>
		PostTextureFilterScaleRangeSgix = Gl.POST_TEXTURE_FILTER_SCALE_RANGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION_MATRIX.
		/// </summary>
		ProjectionMatrix = Gl.PROJECTION_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION_STACK_DEPTH.
		/// </summary>
		ProjectionStackDepth = Gl.PROJECTION_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_READ_BUFFER.
		/// </summary>
		ReadBuffer = Gl.READ_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_RED_BIAS.
		/// </summary>
		RedBias = Gl.RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_RED_BITS.
		/// </summary>
		RedBits = Gl.RED_BITS,

		/// <summary>
		/// Strongly typed for value GL_RED_SCALE.
		/// </summary>
		RedScale = Gl.RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_EQUATION_SGIX.
		/// </summary>
		ReferencePlaneEquationSgix = Gl.REFERENCE_PLANE_EQUATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_SGIX.
		/// </summary>
		ReferencePlaneSgix = Gl.REFERENCE_PLANE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RENDER_MODE.
		/// </summary>
		RenderMode = Gl.RENDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_RESCALE_NORMAL_EXT.
		/// </summary>
		RescaleNormal = Gl.RESCALE_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_RGBA_MODE.
		/// </summary>
		RgbaMode = Gl.RGBA_MODE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLES_SGIS.
		/// </summary>
		Samples = Gl.SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_MASK_SGIS.
		/// </summary>
		SampleAlphaToMaskExt = Gl.SAMPLE_ALPHA_TO_MASK_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_ONE_SGIS.
		/// </summary>
		SampleAlphaToOne = Gl.SAMPLE_ALPHA_TO_ONE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_BUFFERS_SGIS.
		/// </summary>
		SampleBuffers = Gl.SAMPLE_BUFFERS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_INVERT_SGIS.
		/// </summary>
		SampleMaskInvertExt = Gl.SAMPLE_MASK_INVERT_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_SGIS.
		/// </summary>
		SampleMaskSgis = Gl.SAMPLE_MASK_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_VALUE_SGIS.
		/// </summary>
		SampleMaskValueSgis = Gl.SAMPLE_MASK_VALUE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_PATTERN_SGIS.
		/// </summary>
		SamplePatternExt = Gl.SAMPLE_PATTERN_EXT,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_BOX.
		/// </summary>
		ScissorBox = Gl.SCISSOR_BOX,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_TEST.
		/// </summary>
		ScissorTest = Gl.SCISSOR_TEST,

		/// <summary>
		/// Strongly typed for value GL_SELECTION_BUFFER_SIZE.
		/// </summary>
		SelectionBufferSize = Gl.SELECTION_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D_EXT.
		/// </summary>
		Separable2d = Gl.SEPARABLE_2D,

		/// <summary>
		/// Strongly typed for value GL_SHADE_MODEL.
		/// </summary>
		ShadeModel = Gl.SHADE_MODEL,

		/// <summary>
		/// Strongly typed for value GL_SHARED_TEXTURE_PALETTE_EXT.
		/// </summary>
		SharedTexturePaletteExt = Gl.SHARED_TEXTURE_PALETTE_EXT,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_AXIS_SGIX.
		/// </summary>
		SpriteAxisSgix = Gl.SPRITE_AXIS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_MODE_SGIX.
		/// </summary>
		SpriteModeSgix = Gl.SPRITE_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_SGIX.
		/// </summary>
		SpriteSgix = Gl.SPRITE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_TRANSLATION_SGIX.
		/// </summary>
		SpriteTranslationSgix = Gl.SPRITE_TRANSLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BITS.
		/// </summary>
		StencilBits = Gl.STENCIL_BITS,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_CLEAR_VALUE.
		/// </summary>
		StencilClearValue = Gl.STENCIL_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_FAIL.
		/// </summary>
		StencilFail = Gl.STENCIL_FAIL,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_FUNC.
		/// </summary>
		StencilFunc = Gl.STENCIL_FUNC,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_PASS_DEPTH_FAIL.
		/// </summary>
		StencilPassDepthFail = Gl.STENCIL_PASS_DEPTH_FAIL,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_PASS_DEPTH_PASS.
		/// </summary>
		StencilPassDepthPass = Gl.STENCIL_PASS_DEPTH_PASS,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_REF.
		/// </summary>
		StencilRef = Gl.STENCIL_REF,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_TEST.
		/// </summary>
		StencilTest = Gl.STENCIL_TEST,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_VALUE_MASK.
		/// </summary>
		StencilValueMask = Gl.STENCIL_VALUE_MASK,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_WRITEMASK.
		/// </summary>
		StencilWritemask = Gl.STENCIL_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_STEREO.
		/// </summary>
		Stereo = Gl.STEREO,

		/// <summary>
		/// Strongly typed for value GL_SUBPIXEL_BITS.
		/// </summary>
		SubpixelBits = Gl.SUBPIXEL_BITS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_BINDING_EXT, GL_TEXTURE_BINDING_3D.
		/// </summary>
		TextureBinding3d = Gl.TEXTURE_BINDING_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_EXT.
		/// </summary>
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_BINDING_SGIS.
		/// </summary>
		Texture4dBindingSgis = Gl.TEXTURE_4D_BINDING_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BINDING_1D.
		/// </summary>
		TextureBinding1d = Gl.TEXTURE_BINDING_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BINDING_2D.
		/// </summary>
		TextureBinding2d = Gl.TEXTURE_BINDING_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY.
		/// </summary>
		TextureCoordArray = Gl.TEXTURE_COORD_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_COUNT_EXT.
		/// </summary>
		TextureCoordArrayCountExt = Gl.TEXTURE_COORD_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_SIZE.
		/// </summary>
		TextureCoordArraySize = Gl.TEXTURE_COORD_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_STRIDE.
		/// </summary>
		TextureCoordArrayStride = Gl.TEXTURE_COORD_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_TYPE.
		/// </summary>
		TextureCoordArrayType = Gl.TEXTURE_COORD_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_Q.
		/// </summary>
		TextureGenQ = Gl.TEXTURE_GEN_Q,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_R.
		/// </summary>
		TextureGenR = Gl.TEXTURE_GEN_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_S.
		/// </summary>
		TextureGenS = Gl.TEXTURE_GEN_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_T.
		/// </summary>
		TextureGenT = Gl.TEXTURE_GEN_T,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MATRIX.
		/// </summary>
		TextureMatrix = Gl.TEXTURE_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_STACK_DEPTH.
		/// </summary>
		TextureStackDepth = Gl.TEXTURE_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ALIGNMENT.
		/// </summary>
		UnpackAlignment = Gl.UNPACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_CMYK_HINT_EXT.
		/// </summary>
		UnpackCmykHintExt = Gl.UNPACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		UnpackImageDepthSgis = Gl.UNPACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		UnpackImageHeight = Gl.UNPACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_LSB_FIRST.
		/// </summary>
		UnpackLsbFirst = Gl.UNPACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_SGIX.
		/// </summary>
		UnpackResampleSgix = Gl.UNPACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ROW_LENGTH.
		/// </summary>
		UnpackRowLength = Gl.UNPACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_IMAGES_EXT.
		/// </summary>
		UnpackSkipImages = Gl.UNPACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_PIXELS.
		/// </summary>
		UnpackSkipPixels = Gl.UNPACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_ROWS.
		/// </summary>
		UnpackSkipRows = Gl.UNPACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		UnpackSkipVolumesSgis = Gl.UNPACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		UnpackSubsampleRateSgix = Gl.UNPACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SWAP_BYTES.
		/// </summary>
		UnpackSwapBytes = Gl.UNPACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY.
		/// </summary>
		VertexArray = Gl.VERTEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_COUNT_EXT.
		/// </summary>
		VertexArrayCountExt = Gl.VERTEX_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_SIZE.
		/// </summary>
		VertexArraySize = Gl.VERTEX_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_STRIDE.
		/// </summary>
		VertexArrayStride = Gl.VERTEX_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_TYPE.
		/// </summary>
		VertexArrayType = Gl.VERTEX_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_HINT_SGIX.
		/// </summary>
		VertexPreclipHintSgix = Gl.VERTEX_PRECLIP_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_SGIX.
		/// </summary>
		VertexPreclipSgix = Gl.VERTEX_PRECLIP_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VIEWPORT.
		/// </summary>
		Viewport = Gl.VIEWPORT,

		/// <summary>
		/// Strongly typed for value GL_ZOOM_X.
		/// </summary>
		ZoomX = Gl.ZOOM_X,

		/// <summary>
		/// Strongly typed for value GL_ZOOM_Y.
		/// </summary>
		ZoomY = Gl.ZOOM_Y,

	}

	/// <summary>
	/// Strongly typed enumeration GetPointervPName.
	/// </summary>
	public enum GetPointervPName
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_POINTER, GL_COLOR_ARRAY_POINTER_EXT.
		/// </summary>
		ColorArrayPointer = Gl.COLOR_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER_EXT.
		/// </summary>
		EdgeFlagArrayPointer = Gl.EDGE_FLAG_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_POINTER.
		/// </summary>
		FeedbackBufferPointer = Gl.FEEDBACK_BUFFER_POINTER,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_POINTER, GL_INDEX_ARRAY_POINTER_EXT.
		/// </summary>
		IndexArrayPointer = Gl.INDEX_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_INSTRUMENT_BUFFER_POINTER_SGIX.
		/// </summary>
		InstrumentBufferPointerSgix = Gl.INSTRUMENT_BUFFER_POINTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER_EXT.
		/// </summary>
		NormalArrayPointer = Gl.NORMAL_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_SELECTION_BUFFER_POINTER.
		/// </summary>
		SelectionBufferPointer = Gl.SELECTION_BUFFER_POINTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER_EXT.
		/// </summary>
		TextureCoordArrayPointer = Gl.TEXTURE_COORD_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_POINTER, GL_VERTEX_ARRAY_POINTER_EXT.
		/// </summary>
		VertexArrayPointer = Gl.VERTEX_ARRAY_POINTER,

	}

	/// <summary>
	/// Strongly typed enumeration GetTextureParameter.
	/// </summary>
	public enum GetTextureParameter
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		DetailTextureFuncPointsSgis = Gl.DETAIL_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_LEVEL_SGIS.
		/// </summary>
		DetailTextureLevelSgis = Gl.DETAIL_TEXTURE_LEVEL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_MODE_SGIS.
		/// </summary>
		DetailTextureModeSgis = Gl.DETAIL_TEXTURE_MODE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_TEXTURE_SELECT_SGIS.
		/// </summary>
		DualTextureSelectSgis = Gl.DUAL_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_SGIS.
		/// </summary>
		GenerateMipmap = Gl.GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_SGIX.
		/// </summary>
		PostTextureFilterBiasSgix = Gl.POST_TEXTURE_FILTER_BIAS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_SGIX.
		/// </summary>
		PostTextureFilterScaleSgix = Gl.POST_TEXTURE_FILTER_SCALE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_QUAD_TEXTURE_SELECT_SGIS.
		/// </summary>
		QuadTextureSelectSgis = Gl.QUAD_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SHADOW_AMBIENT_SGIX.
		/// </summary>
		ShadowAmbientSgix = Gl.SHADOW_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		SharpenTextureFuncPointsSgis = Gl.SHARPEN_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4DSIZE_SGIS.
		/// </summary>
		Texture4dsizeSgis = Gl.TEXTURE_4DSIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ALPHA_SIZE.
		/// </summary>
		TextureAlphaSize = Gl.TEXTURE_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BASE_LEVEL_SGIS.
		/// </summary>
		TextureBaseLevel = Gl.TEXTURE_BASE_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BLUE_SIZE.
		/// </summary>
		TextureBlueSize = Gl.TEXTURE_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER.
		/// </summary>
		TextureBorder = Gl.TEXTURE_BORDER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER_COLOR.
		/// </summary>
		TextureBorderColor = Gl.TEXTURE_BORDER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_CENTER_SGIX.
		/// </summary>
		TextureClipmapCenterSgix = Gl.TEXTURE_CLIPMAP_CENTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		TextureClipmapDepthSgix = Gl.TEXTURE_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_FRAME_SGIX.
		/// </summary>
		TextureClipmapFrameSgix = Gl.TEXTURE_CLIPMAP_FRAME_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX.
		/// </summary>
		TextureClipmapLodOffsetSgix = Gl.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_OFFSET_SGIX.
		/// </summary>
		TextureClipmapOffsetSgix = Gl.TEXTURE_CLIPMAP_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		TextureClipmapVirtualDepthSgix = Gl.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_OPERATOR_SGIX.
		/// </summary>
		TextureCompareOperatorSgix = Gl.TEXTURE_COMPARE_OPERATOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_SGIX.
		/// </summary>
		TextureCompareSgix = Gl.TEXTURE_COMPARE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPONENTS, GL_TEXTURE_INTERNAL_FORMAT.
		/// </summary>
		TextureComponents = Gl.TEXTURE_COMPONENTS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEPTH_EXT.
		/// </summary>
		TextureDepth = Gl.TEXTURE_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_FILTER4_SIZE_SGIS.
		/// </summary>
		TextureFilter4SizeSgis = Gl.TEXTURE_FILTER4_SIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEQUAL_R_SGIX.
		/// </summary>
		TextureGequalRSgix = Gl.TEXTURE_GEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GREEN_SIZE.
		/// </summary>
		TextureGreenSize = Gl.TEXTURE_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_HEIGHT.
		/// </summary>
		TextureHeight = Gl.TEXTURE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_INTENSITY_SIZE.
		/// </summary>
		TextureIntensitySize = Gl.TEXTURE_INTENSITY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LEQUAL_R_SGIX.
		/// </summary>
		TextureLequalRSgix = Gl.TEXTURE_LEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_R_SGIX.
		/// </summary>
		TextureLodBiasRSgix = Gl.TEXTURE_LOD_BIAS_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_S_SGIX.
		/// </summary>
		TextureLodBiasSSgix = Gl.TEXTURE_LOD_BIAS_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_T_SGIX.
		/// </summary>
		TextureLodBiasTSgix = Gl.TEXTURE_LOD_BIAS_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LUMINANCE_SIZE.
		/// </summary>
		TextureLuminanceSize = Gl.TEXTURE_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAG_FILTER.
		/// </summary>
		TextureMagFilter = Gl.TEXTURE_MAG_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_R_SGIX.
		/// </summary>
		TextureMaxClampRSgix = Gl.TEXTURE_MAX_CLAMP_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_S_SGIX.
		/// </summary>
		TextureMaxClampSSgix = Gl.TEXTURE_MAX_CLAMP_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_T_SGIX.
		/// </summary>
		TextureMaxClampTSgix = Gl.TEXTURE_MAX_CLAMP_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LEVEL_SGIS.
		/// </summary>
		TextureMaxLevel = Gl.TEXTURE_MAX_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LOD_SGIS.
		/// </summary>
		TextureMaxLod = Gl.TEXTURE_MAX_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_FILTER.
		/// </summary>
		TextureMinFilter = Gl.TEXTURE_MIN_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_LOD_SGIS.
		/// </summary>
		TextureMinLod = Gl.TEXTURE_MIN_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_PRIORITY.
		/// </summary>
		TexturePriority = Gl.TEXTURE_PRIORITY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RED_SIZE.
		/// </summary>
		TextureRedSize = Gl.TEXTURE_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RESIDENT.
		/// </summary>
		TextureResident = Gl.TEXTURE_RESIDENT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WIDTH.
		/// </summary>
		TextureWidth = Gl.TEXTURE_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_Q_SGIS.
		/// </summary>
		TextureWrapQSgis = Gl.TEXTURE_WRAP_Q_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_R_EXT.
		/// </summary>
		TextureWrapR = Gl.TEXTURE_WRAP_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_S.
		/// </summary>
		TextureWrapS = Gl.TEXTURE_WRAP_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_T.
		/// </summary>
		TextureWrapT = Gl.TEXTURE_WRAP_T,

	}

	/// <summary>
	/// Strongly typed enumeration HintMode.
	/// </summary>
	public enum HintMode
	{
		/// <summary>
		/// Strongly typed for value GL_DONT_CARE.
		/// </summary>
		DontCare = Gl.DONT_CARE,

		/// <summary>
		/// Strongly typed for value GL_FASTEST.
		/// </summary>
		Fastest = Gl.FASTEST,

		/// <summary>
		/// Strongly typed for value GL_NICEST.
		/// </summary>
		Nicest = Gl.NICEST,

	}

	/// <summary>
	/// Strongly typed enumeration HintTarget.
	/// </summary>
	public enum HintTarget
	{
		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_FRG_HINT_PGI.
		/// </summary>
		AllowDrawFrgHintPgi = Gl.ALLOW_DRAW_FRG_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_MEM_HINT_PGI.
		/// </summary>
		AllowDrawMemHintPgi = Gl.ALLOW_DRAW_MEM_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_OBJ_HINT_PGI.
		/// </summary>
		AllowDrawObjHintPgi = Gl.ALLOW_DRAW_OBJ_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_WIN_HINT_PGI.
		/// </summary>
		AllowDrawWinHintPgi = Gl.ALLOW_DRAW_WIN_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALWAYS_FAST_HINT_PGI.
		/// </summary>
		AlwaysFastHintPgi = Gl.ALWAYS_FAST_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALWAYS_SOFT_HINT_PGI.
		/// </summary>
		AlwaysSoftHintPgi = Gl.ALWAYS_SOFT_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_BACK_NORMALS_HINT_PGI.
		/// </summary>
		BackNormalsHintPgi = Gl.BACK_NORMALS_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CLIP_FAR_HINT_PGI.
		/// </summary>
		ClipFarHintPgi = Gl.CLIP_FAR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CLIP_NEAR_HINT_PGI.
		/// </summary>
		ClipNearHintPgi = Gl.CLIP_NEAR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CLIP_VOLUME_CLIPPING_HINT_EXT.
		/// </summary>
		ClipVolumeClippingHintExt = Gl.CLIP_VOLUME_CLIPPING_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_CONSERVE_MEMORY_HINT_PGI.
		/// </summary>
		ConserveMemoryHintPgi = Gl.CONSERVE_MEMORY_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HINT_SGIX.
		/// </summary>
		ConvolutionHintSgix = Gl.CONVOLUTION_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_HINT.
		/// </summary>
		FogHint = Gl.FOG_HINT,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER_DERIVATIVE_HINT, GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB.
		/// </summary>
		FragmentShaderDerivativeHint = Gl.FRAGMENT_SHADER_DERIVATIVE_HINT,

		/// <summary>
		/// Strongly typed for value GL_FULL_STIPPLE_HINT_PGI.
		/// </summary>
		FullStippleHintPgi = Gl.FULL_STIPPLE_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_HINT, GL_GENERATE_MIPMAP_HINT_SGIS.
		/// </summary>
		GenerateMipmapHint = Gl.GENERATE_MIPMAP_HINT,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH_HINT.
		/// </summary>
		LineSmoothHint = Gl.LINE_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_MATERIAL_SIDE_HINT_PGI.
		/// </summary>
		MaterialSideHintPgi = Gl.MATERIAL_SIDE_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_MAX_VERTEX_HINT_PGI.
		/// </summary>
		MaxVertexHintPgi = Gl.MAX_VERTEX_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_FILTER_HINT_NV.
		/// </summary>
		MultisampleFilterHintNv = Gl.MULTISAMPLE_FILTER_HINT_NV,

		/// <summary>
		/// Strongly typed for value GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI.
		/// </summary>
		NativeGraphicsBeginHintPgi = Gl.NATIVE_GRAPHICS_BEGIN_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_NATIVE_GRAPHICS_END_HINT_PGI.
		/// </summary>
		NativeGraphicsEndHintPgi = Gl.NATIVE_GRAPHICS_END_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_PACK_CMYK_HINT_EXT.
		/// </summary>
		PackCmykHintExt = Gl.PACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_PERSPECTIVE_CORRECTION_HINT.
		/// </summary>
		PerspectiveCorrectionHint = Gl.PERSPECTIVE_CORRECTION_HINT,

		/// <summary>
		/// Strongly typed for value GL_PHONG_HINT_WIN.
		/// </summary>
		PhongHintWin = Gl.PHONG_HINT_WIN,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH_HINT.
		/// </summary>
		PointSmoothHint = Gl.POINT_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH_HINT.
		/// </summary>
		PolygonSmoothHint = Gl.POLYGON_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_PREFER_DOUBLEBUFFER_HINT_PGI.
		/// </summary>
		PreferDoublebufferHintPgi = Gl.PREFER_DOUBLEBUFFER_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_BINARY_RETRIEVABLE_HINT.
		/// </summary>
		ProgramBinaryRetrievableHint = Gl.PROGRAM_BINARY_RETRIEVABLE_HINT,

		/// <summary>
		/// Strongly typed for value GL_RECLAIM_MEMORY_HINT_PGI.
		/// </summary>
		ReclaimMemoryHintPgi = Gl.RECLAIM_MEMORY_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_SCALEBIAS_HINT_SGIX.
		/// </summary>
		ScalebiasHintSgix = Gl.SCALEBIAS_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STRICT_DEPTHFUNC_HINT_PGI.
		/// </summary>
		StrictDepthfuncHintPgi = Gl.STRICT_DEPTHFUNC_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_STRICT_LIGHTING_HINT_PGI.
		/// </summary>
		StrictLightingHintPgi = Gl.STRICT_LIGHTING_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_STRICT_SCISSOR_HINT_PGI.
		/// </summary>
		StrictScissorHintPgi = Gl.STRICT_SCISSOR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSION_HINT, GL_TEXTURE_COMPRESSION_HINT_ARB.
		/// </summary>
		TextureCompressionHint = Gl.TEXTURE_COMPRESSION_HINT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MULTI_BUFFER_HINT_SGIX.
		/// </summary>
		TextureMultiBufferHintSgix = Gl.TEXTURE_MULTI_BUFFER_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_STORAGE_HINT_APPLE.
		/// </summary>
		TextureStorageHintApple = Gl.TEXTURE_STORAGE_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_HINT_APPLE.
		/// </summary>
		TransformHintApple = Gl.TRANSFORM_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_CMYK_HINT_EXT.
		/// </summary>
		UnpackCmykHintExt = Gl.UNPACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_STORAGE_HINT_APPLE.
		/// </summary>
		VertexArrayStorageHintApple = Gl.VERTEX_ARRAY_STORAGE_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_CONSISTENT_HINT_PGI.
		/// </summary>
		VertexConsistentHintPgi = Gl.VERTEX_CONSISTENT_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_DATA_HINT_PGI.
		/// </summary>
		VertexDataHintPgi = Gl.VERTEX_DATA_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_HINT_SGIX.
		/// </summary>
		VertexPreclipHintSgix = Gl.VERTEX_PRECLIP_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_SGIX.
		/// </summary>
		VertexPreclipSgix = Gl.VERTEX_PRECLIP_SGIX,

		/// <summary>
		/// Strongly typed for value GL_WIDE_LINE_HINT_PGI.
		/// </summary>
		WideLineHintPgi = Gl.WIDE_LINE_HINT_PGI,

	}

	/// <summary>
	/// Strongly typed enumeration HistogramTargetEXT.
	/// </summary>
	public enum HistogramTargetEXT
	{
		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM, GL_HISTOGRAM_EXT.
		/// </summary>
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_PROXY_HISTOGRAM, GL_PROXY_HISTOGRAM_EXT.
		/// </summary>
		ProxyHistogram = Gl.PROXY_HISTOGRAM,

	}

	/// <summary>
	/// Strongly typed enumeration IndexPointerType.
	/// </summary>
	public enum IndexPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration InterleavedArrayFormat.
	/// </summary>
	public enum InterleavedArrayFormat
	{
		/// <summary>
		/// Strongly typed for value GL_C3F_V3F.
		/// </summary>
		C3fV3f = Gl.C3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_C4F_N3F_V3F.
		/// </summary>
		C4fN3fV3f = Gl.C4F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_C4UB_V2F.
		/// </summary>
		C4ubV2f = Gl.C4UB_V2F,

		/// <summary>
		/// Strongly typed for value GL_C4UB_V3F.
		/// </summary>
		C4ubV3f = Gl.C4UB_V3F,

		/// <summary>
		/// Strongly typed for value GL_N3F_V3F.
		/// </summary>
		N3fV3f = Gl.N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C3F_V3F.
		/// </summary>
		T2fC3fV3f = Gl.T2F_C3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C4F_N3F_V3F.
		/// </summary>
		T2fC4fN3fV3f = Gl.T2F_C4F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C4UB_V3F.
		/// </summary>
		T2fC4ubV3f = Gl.T2F_C4UB_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_N3F_V3F.
		/// </summary>
		T2fN3fV3f = Gl.T2F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_V3F.
		/// </summary>
		T2fV3f = Gl.T2F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T4F_C4F_N3F_V4F.
		/// </summary>
		T4fC4fN3fV4f = Gl.T4F_C4F_N3F_V4F,

		/// <summary>
		/// Strongly typed for value GL_T4F_V4F.
		/// </summary>
		T4fV4f = Gl.T4F_V4F,

		/// <summary>
		/// Strongly typed for value GL_V2F.
		/// </summary>
		V2f = Gl.V2F,

		/// <summary>
		/// Strongly typed for value GL_V3F.
		/// </summary>
		V3f = Gl.V3F,

	}

	/// <summary>
	/// Strongly typed enumeration LightEnvModeSGIX.
	/// </summary>
	public enum LightEnvModeSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		Add = Gl.ADD,

		/// <summary>
		/// Strongly typed for value GL_MODULATE.
		/// </summary>
		Modulate = Gl.MODULATE,

		/// <summary>
		/// Strongly typed for value GL_REPLACE.
		/// </summary>
		Replace = Gl.REPLACE,

	}

	/// <summary>
	/// Strongly typed enumeration LightEnvParameterSGIX.
	/// </summary>
	public enum LightEnvParameterSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_LIGHT_ENV_MODE_SGIX.
		/// </summary>
		LightEnvModeSgix = Gl.LIGHT_ENV_MODE_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration LightModelColorControl.
	/// </summary>
	public enum LightModelColorControl
	{
		/// <summary>
		/// Strongly typed for value GL_SEPARATE_SPECULAR_COLOR, GL_SEPARATE_SPECULAR_COLOR_EXT.
		/// </summary>
		SeparateSpecularColor = Gl.SEPARATE_SPECULAR_COLOR,

		/// <summary>
		/// Strongly typed for value GL_SINGLE_COLOR, GL_SINGLE_COLOR_EXT.
		/// </summary>
		SingleColor = Gl.SINGLE_COLOR,

	}

	/// <summary>
	/// Strongly typed enumeration LightModelParameter.
	/// </summary>
	public enum LightModelParameter
	{
		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_AMBIENT.
		/// </summary>
		LightModelAmbient = Gl.LIGHT_MODEL_AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_COLOR_CONTROL, GL_LIGHT_MODEL_COLOR_CONTROL_EXT.
		/// </summary>
		LightModelColorControl = Gl.LIGHT_MODEL_COLOR_CONTROL,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_LOCAL_VIEWER.
		/// </summary>
		LightModelLocalViewer = Gl.LIGHT_MODEL_LOCAL_VIEWER,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_TWO_SIDE.
		/// </summary>
		LightModelTwoSide = Gl.LIGHT_MODEL_TWO_SIDE,

	}

	/// <summary>
	/// Strongly typed enumeration LightName.
	/// </summary>
	public enum LightName
	{
		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT1_SGIX.
		/// </summary>
		FragmentLight1Sgix = Gl.FRAGMENT_LIGHT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT2_SGIX.
		/// </summary>
		FragmentLight2Sgix = Gl.FRAGMENT_LIGHT2_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT3_SGIX.
		/// </summary>
		FragmentLight3Sgix = Gl.FRAGMENT_LIGHT3_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT4_SGIX.
		/// </summary>
		FragmentLight4Sgix = Gl.FRAGMENT_LIGHT4_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT5_SGIX.
		/// </summary>
		FragmentLight5Sgix = Gl.FRAGMENT_LIGHT5_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT6_SGIX.
		/// </summary>
		FragmentLight6Sgix = Gl.FRAGMENT_LIGHT6_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT7_SGIX.
		/// </summary>
		FragmentLight7Sgix = Gl.FRAGMENT_LIGHT7_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		Light7 = Gl.LIGHT7,

	}

	/// <summary>
	/// Strongly typed enumeration LightParameter.
	/// </summary>
	public enum LightParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_ATTENUATION.
		/// </summary>
		ConstantAttenuation = Gl.CONSTANT_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_ATTENUATION.
		/// </summary>
		LinearAttenuation = Gl.LINEAR_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_POSITION.
		/// </summary>
		Position = Gl.POSITION,

		/// <summary>
		/// Strongly typed for value GL_QUADRATIC_ATTENUATION.
		/// </summary>
		QuadraticAttenuation = Gl.QUADRATIC_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		Specular = Gl.SPECULAR,

		/// <summary>
		/// Strongly typed for value GL_SPOT_CUTOFF.
		/// </summary>
		SpotCutoff = Gl.SPOT_CUTOFF,

		/// <summary>
		/// Strongly typed for value GL_SPOT_DIRECTION.
		/// </summary>
		SpotDirection = Gl.SPOT_DIRECTION,

		/// <summary>
		/// Strongly typed for value GL_SPOT_EXPONENT.
		/// </summary>
		SpotExponent = Gl.SPOT_EXPONENT,

	}

	/// <summary>
	/// Strongly typed enumeration ListMode.
	/// </summary>
	public enum ListMode
	{
		/// <summary>
		/// Strongly typed for value GL_COMPILE.
		/// </summary>
		Compile = Gl.COMPILE,

		/// <summary>
		/// Strongly typed for value GL_COMPILE_AND_EXECUTE.
		/// </summary>
		CompileAndExecute = Gl.COMPILE_AND_EXECUTE,

	}

	/// <summary>
	/// Strongly typed enumeration ListNameType.
	/// </summary>
	public enum ListNameType
	{
		/// <summary>
		/// Strongly typed for value GL_2_BYTES.
		/// </summary>
		_2Bytes = Gl._2_BYTES,

		/// <summary>
		/// Strongly typed for value GL_3_BYTES.
		/// </summary>
		_3Bytes = Gl._3_BYTES,

		/// <summary>
		/// Strongly typed for value GL_4_BYTES.
		/// </summary>
		_4Bytes = Gl._4_BYTES,

		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		UnsignedShort = Gl.UNSIGNED_SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration ListParameterName.
	/// </summary>
	public enum ListParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_LIST_PRIORITY_SGIX.
		/// </summary>
		ListPrioritySgix = Gl.LIST_PRIORITY_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration LogicOp.
	/// </summary>
	public enum LogicOp
	{
		/// <summary>
		/// Strongly typed for value GL_AND.
		/// </summary>
		And = Gl.AND,

		/// <summary>
		/// Strongly typed for value GL_AND_INVERTED.
		/// </summary>
		AndInverted = Gl.AND_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_AND_REVERSE.
		/// </summary>
		AndReverse = Gl.AND_REVERSE,

		/// <summary>
		/// Strongly typed for value GL_CLEAR.
		/// </summary>
		Clear = Gl.CLEAR,

		/// <summary>
		/// Strongly typed for value GL_COPY.
		/// </summary>
		Copy = Gl.COPY,

		/// <summary>
		/// Strongly typed for value GL_COPY_INVERTED.
		/// </summary>
		CopyInverted = Gl.COPY_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_EQUIV.
		/// </summary>
		Equiv = Gl.EQUIV,

		/// <summary>
		/// Strongly typed for value GL_INVERT.
		/// </summary>
		Invert = Gl.INVERT,

		/// <summary>
		/// Strongly typed for value GL_NAND.
		/// </summary>
		Nand = Gl.NAND,

		/// <summary>
		/// Strongly typed for value GL_NOOP.
		/// </summary>
		Noop = Gl.NOOP,

		/// <summary>
		/// Strongly typed for value GL_NOR.
		/// </summary>
		Nor = Gl.NOR,

		/// <summary>
		/// Strongly typed for value GL_OR.
		/// </summary>
		Or = Gl.OR,

		/// <summary>
		/// Strongly typed for value GL_OR_INVERTED.
		/// </summary>
		OrInverted = Gl.OR_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_OR_REVERSE.
		/// </summary>
		OrReverse = Gl.OR_REVERSE,

		/// <summary>
		/// Strongly typed for value GL_SET.
		/// </summary>
		Set = Gl.SET,

		/// <summary>
		/// Strongly typed for value GL_XOR.
		/// </summary>
		Xor = Gl.XOR,

	}

	/// <summary>
	/// Strongly typed enumeration MapBufferUsageMask.
	/// </summary>
	[Flags()]
	public enum MapBufferUsageMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CLIENT_STORAGE_BIT.
		/// </summary>
		ClientStorageBit = Gl.CLIENT_STORAGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_STORAGE_BIT.
		/// </summary>
		DynamicStorageBit = Gl.DYNAMIC_STORAGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_COHERENT_BIT.
		/// </summary>
		MapCoherentBit = Gl.MAP_COHERENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_FLUSH_EXPLICIT_BIT.
		/// </summary>
		MapFlushExplicitBit = Gl.MAP_FLUSH_EXPLICIT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_INVALIDATE_BUFFER_BIT.
		/// </summary>
		MapInvalidateBufferBit = Gl.MAP_INVALIDATE_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_INVALIDATE_RANGE_BIT.
		/// </summary>
		MapInvalidateRangeBit = Gl.MAP_INVALIDATE_RANGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_PERSISTENT_BIT.
		/// </summary>
		MapPersistentBit = Gl.MAP_PERSISTENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_READ_BIT.
		/// </summary>
		MapReadBit = Gl.MAP_READ_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_UNSYNCHRONIZED_BIT.
		/// </summary>
		MapUnsynchronizedBit = Gl.MAP_UNSYNCHRONIZED_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_WRITE_BIT.
		/// </summary>
		MapWriteBit = Gl.MAP_WRITE_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration MapTarget.
	/// </summary>
	public enum MapTarget
	{
		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_DEFORMATION_SGIX.
		/// </summary>
		GeometryDeformationSgix = Gl.GEOMETRY_DEFORMATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEFORMATION_SGIX.
		/// </summary>
		TextureDeformationSgix = Gl.TEXTURE_DEFORMATION_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration MapTextureFormatINTEL.
	/// </summary>
	public enum MapTextureFormatINTEL
	{
		/// <summary>
		/// Strongly typed for value GL_LAYOUT_DEFAULT_INTEL.
		/// </summary>
		LayoutDefaultIntel = Gl.LAYOUT_DEFAULT_INTEL,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_LINEAR_CPU_CACHED_INTEL.
		/// </summary>
		LayoutLinearCpuCachedIntel = Gl.LAYOUT_LINEAR_CPU_CACHED_INTEL,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_LINEAR_INTEL.
		/// </summary>
		LayoutLinearIntel = Gl.LAYOUT_LINEAR_INTEL,

	}

	/// <summary>
	/// Strongly typed enumeration MaterialFace.
	/// </summary>
	public enum MaterialFace
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration MaterialParameter.
	/// </summary>
	public enum MaterialParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_AMBIENT_AND_DIFFUSE.
		/// </summary>
		AmbientAndDiffuse = Gl.AMBIENT_AND_DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_INDEXES.
		/// </summary>
		ColorIndexes = Gl.COLOR_INDEXES,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_EMISSION.
		/// </summary>
		Emission = Gl.EMISSION,

		/// <summary>
		/// Strongly typed for value GL_SHININESS.
		/// </summary>
		Shininess = Gl.SHININESS,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		Specular = Gl.SPECULAR,

	}

	/// <summary>
	/// Strongly typed enumeration MatrixMode.
	/// </summary>
	public enum MatrixMode
	{
		/// <summary>
		/// Strongly typed for value GL_MODELVIEW, GL_MODELVIEW0_EXT.
		/// </summary>
		Modelview = Gl.MODELVIEW,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION.
		/// </summary>
		Projection = Gl.PROJECTION,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE.
		/// </summary>
		Texture = Gl.TEXTURE,

	}

	/// <summary>
	/// Strongly typed enumeration MemoryBarrierMask.
	/// </summary>
	[Flags()]
	public enum MemoryBarrierMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ALL_BARRIER_BITS, GL_ALL_BARRIER_BITS_EXT.
		/// </summary>
		AllBarrierBits = Gl.ALL_BARRIER_BITS,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT_EXT.
		/// </summary>
		AtomicCounterBarrierBit = Gl.ATOMIC_COUNTER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT_EXT.
		/// </summary>
		BufferUpdateBarrierBit = Gl.BUFFER_UPDATE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT.
		/// </summary>
		ClientMappedBufferBarrierBit = Gl.CLIENT_MAPPED_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COMMAND_BARRIER_BIT, GL_COMMAND_BARRIER_BIT_EXT.
		/// </summary>
		CommandBarrierBit = Gl.COMMAND_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ELEMENT_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT_EXT.
		/// </summary>
		ElementArrayBarrierBit = Gl.ELEMENT_ARRAY_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT_EXT.
		/// </summary>
		FramebufferBarrierBit = Gl.FRAMEBUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_BUFFER_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT_EXT.
		/// </summary>
		PixelBufferBarrierBit = Gl.PIXEL_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_QUERY_BUFFER_BARRIER_BIT.
		/// </summary>
		QueryBufferBarrierBit = Gl.QUERY_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV.
		/// </summary>
		ShaderGlobalAccessBarrierBitNv = Gl.SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV,

		/// <summary>
		/// Strongly typed for value GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT.
		/// </summary>
		ShaderImageAccessBarrierBit = Gl.SHADER_IMAGE_ACCESS_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_SHADER_STORAGE_BARRIER_BIT.
		/// </summary>
		ShaderStorageBarrierBit = Gl.SHADER_STORAGE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_FETCH_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT_EXT.
		/// </summary>
		TextureFetchBarrierBit = Gl.TEXTURE_FETCH_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_UPDATE_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT_EXT.
		/// </summary>
		TextureUpdateBarrierBit = Gl.TEXTURE_UPDATE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT.
		/// </summary>
		TransformFeedbackBarrierBit = Gl.TRANSFORM_FEEDBACK_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT_EXT.
		/// </summary>
		UniformBarrierBit = Gl.UNIFORM_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT.
		/// </summary>
		VertexAttribArrayBarrierBit = Gl.VERTEX_ATTRIB_ARRAY_BARRIER_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration MeshMode1.
	/// </summary>
	public enum MeshMode1
	{
		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration MeshMode2.
	/// </summary>
	public enum MeshMode2
	{
		/// <summary>
		/// Strongly typed for value GL_FILL.
		/// </summary>
		Fill = Gl.FILL,

		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration MinmaxTargetEXT.
	/// </summary>
	public enum MinmaxTargetEXT
	{
		/// <summary>
		/// Strongly typed for value GL_MINMAX, GL_MINMAX_EXT.
		/// </summary>
		Minmax = Gl.MINMAX,

	}

	/// <summary>
	/// Strongly typed enumeration NormalPointerType.
	/// </summary>
	public enum NormalPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration PixelCopyType.
	/// </summary>
	public enum PixelCopyType
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR.
		/// </summary>
		Color = Gl.COLOR,

		/// <summary>
		/// Strongly typed for value GL_DEPTH.
		/// </summary>
		Depth = Gl.DEPTH,

		/// <summary>
		/// Strongly typed for value GL_STENCIL.
		/// </summary>
		Stencil = Gl.STENCIL,

	}

	/// <summary>
	/// Strongly typed enumeration PixelFormat.
	/// </summary>
	public enum PixelFormat
	{
		/// <summary>
		/// Strongly typed for value GL_ABGR_EXT.
		/// </summary>
		AbgrExt = Gl.ABGR_EXT,

		/// <summary>
		/// Strongly typed for value GL_ALPHA.
		/// </summary>
		Alpha = Gl.ALPHA,

		/// <summary>
		/// Strongly typed for value GL_BLUE.
		/// </summary>
		Blue = Gl.BLUE,

		/// <summary>
		/// Strongly typed for value GL_CMYKA_EXT.
		/// </summary>
		CmykaExt = Gl.CMYKA_EXT,

		/// <summary>
		/// Strongly typed for value GL_CMYK_EXT.
		/// </summary>
		CmykExt = Gl.CMYK_EXT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_INDEX.
		/// </summary>
		ColorIndex = Gl.COLOR_INDEX,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT.
		/// </summary>
		DepthComponent = Gl.DEPTH_COMPONENT,

		/// <summary>
		/// Strongly typed for value GL_GREEN.
		/// </summary>
		Green = Gl.GREEN,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE.
		/// </summary>
		Luminance = Gl.LUMINANCE,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE_ALPHA.
		/// </summary>
		LuminanceAlpha = Gl.LUMINANCE_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_RED.
		/// </summary>
		Red = Gl.RED,

		/// <summary>
		/// Strongly typed for value GL_RGB.
		/// </summary>
		Rgb = Gl.RGB,

		/// <summary>
		/// Strongly typed for value GL_RGBA.
		/// </summary>
		Rgba = Gl.RGBA,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_INDEX.
		/// </summary>
		StencilIndex = Gl.STENCIL_INDEX,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_YCRCB_422_SGIX.
		/// </summary>
		Ycrcb422Sgix = Gl.YCRCB_422_SGIX,

		/// <summary>
		/// Strongly typed for value GL_YCRCB_444_SGIX.
		/// </summary>
		Ycrcb444Sgix = Gl.YCRCB_444_SGIX,

		/// <summary>
		/// Strongly typed for value GL_BGR.
		/// </summary>
		Bgr = Gl.BGR,

		/// <summary>
		/// Strongly typed for value GL_BGRA.
		/// </summary>
		Bgra = Gl.BGRA,

		/// <summary>
		/// Strongly typed for value GL_RG.
		/// </summary>
		Rg = Gl.RG,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_STENCIL.
		/// </summary>
		DepthStencil = Gl.DEPTH_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_RED_INTEGER.
		/// </summary>
		RedInteger = Gl.RED_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RG_INTEGER.
		/// </summary>
		RgInteger = Gl.RG_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RGB_INTEGER.
		/// </summary>
		RgbInteger = Gl.RGB_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RGBA_INTEGER.
		/// </summary>
		RgbaInteger = Gl.RGBA_INTEGER,

	}

	/// <summary>
	/// Strongly typed enumeration InternalFormat.
	/// </summary>
	public enum InternalFormat
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA12.
		/// </summary>
		Alpha12 = Gl.ALPHA12,

		/// <summary>
		/// Strongly typed for value GL_ALPHA16.
		/// </summary>
		Alpha16 = Gl.ALPHA16,

		/// <summary>
		/// Strongly typed for value GL_ALPHA4.
		/// </summary>
		Alpha4 = Gl.ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_ALPHA8.
		/// </summary>
		Alpha8 = Gl.ALPHA8,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT16_SGIX.
		/// </summary>
		DepthComponent16 = Gl.DEPTH_COMPONENT16,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT24_SGIX.
		/// </summary>
		DepthComponent24 = Gl.DEPTH_COMPONENT24,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT32_SGIX.
		/// </summary>
		DepthComponent32 = Gl.DEPTH_COMPONENT32,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA12_SGIS.
		/// </summary>
		DualAlpha12Sgis = Gl.DUAL_ALPHA12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA16_SGIS.
		/// </summary>
		DualAlpha16Sgis = Gl.DUAL_ALPHA16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA4_SGIS.
		/// </summary>
		DualAlpha4Sgis = Gl.DUAL_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA8_SGIS.
		/// </summary>
		DualAlpha8Sgis = Gl.DUAL_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY12_SGIS.
		/// </summary>
		DualIntensity12Sgis = Gl.DUAL_INTENSITY12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY16_SGIS.
		/// </summary>
		DualIntensity16Sgis = Gl.DUAL_INTENSITY16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY4_SGIS.
		/// </summary>
		DualIntensity4Sgis = Gl.DUAL_INTENSITY4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY8_SGIS.
		/// </summary>
		DualIntensity8Sgis = Gl.DUAL_INTENSITY8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE12_SGIS.
		/// </summary>
		DualLuminance12Sgis = Gl.DUAL_LUMINANCE12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE16_SGIS.
		/// </summary>
		DualLuminance16Sgis = Gl.DUAL_LUMINANCE16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE4_SGIS.
		/// </summary>
		DualLuminance4Sgis = Gl.DUAL_LUMINANCE4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE8_SGIS.
		/// </summary>
		DualLuminance8Sgis = Gl.DUAL_LUMINANCE8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE_ALPHA4_SGIS.
		/// </summary>
		DualLuminanceAlpha4Sgis = Gl.DUAL_LUMINANCE_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE_ALPHA8_SGIS.
		/// </summary>
		DualLuminanceAlpha8Sgis = Gl.DUAL_LUMINANCE_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY.
		/// </summary>
		Intensity = Gl.INTENSITY,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY12.
		/// </summary>
		Intensity12 = Gl.INTENSITY12,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY16.
		/// </summary>
		Intensity16 = Gl.INTENSITY16,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY4.
		/// </summary>
		Intensity4 = Gl.INTENSITY4,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY8.
		/// </summary>
		Intensity8 = Gl.INTENSITY8,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12.
		/// </summary>
		Luminance12 = Gl.LUMINANCE12,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12_ALPHA12.
		/// </summary>
		Luminance12Alpha12 = Gl.LUMINANCE12_ALPHA12,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12_ALPHA4.
		/// </summary>
		Luminance12Alpha4 = Gl.LUMINANCE12_ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE16.
		/// </summary>
		Luminance16 = Gl.LUMINANCE16,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE16_ALPHA16.
		/// </summary>
		Luminance16Alpha16 = Gl.LUMINANCE16_ALPHA16,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE4.
		/// </summary>
		Luminance4 = Gl.LUMINANCE4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE4_ALPHA4.
		/// </summary>
		Luminance4Alpha4 = Gl.LUMINANCE4_ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE6_ALPHA2.
		/// </summary>
		Luminance6Alpha2 = Gl.LUMINANCE6_ALPHA2,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE8.
		/// </summary>
		Luminance8 = Gl.LUMINANCE8,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE8_ALPHA8.
		/// </summary>
		Luminance8Alpha8 = Gl.LUMINANCE8_ALPHA8,

		/// <summary>
		/// Strongly typed for value GL_QUAD_ALPHA4_SGIS.
		/// </summary>
		QuadAlpha4Sgis = Gl.QUAD_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_ALPHA8_SGIS.
		/// </summary>
		QuadAlpha8Sgis = Gl.QUAD_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_INTENSITY4_SGIS.
		/// </summary>
		QuadIntensity4Sgis = Gl.QUAD_INTENSITY4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_INTENSITY8_SGIS.
		/// </summary>
		QuadIntensity8Sgis = Gl.QUAD_INTENSITY8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_LUMINANCE4_SGIS.
		/// </summary>
		QuadLuminance4Sgis = Gl.QUAD_LUMINANCE4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_LUMINANCE8_SGIS.
		/// </summary>
		QuadLuminance8Sgis = Gl.QUAD_LUMINANCE8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_R3_G3_B2.
		/// </summary>
		R3G3B2 = Gl.R3_G3_B2,

		/// <summary>
		/// Strongly typed for value GL_RGB10.
		/// </summary>
		Rgb10 = Gl.RGB10,

		/// <summary>
		/// Strongly typed for value GL_RGB10_A2.
		/// </summary>
		Rgb10A2 = Gl.RGB10_A2,

		/// <summary>
		/// Strongly typed for value GL_RGB12.
		/// </summary>
		Rgb12 = Gl.RGB12,

		/// <summary>
		/// Strongly typed for value GL_RGB16.
		/// </summary>
		Rgb16 = Gl.RGB16,

		/// <summary>
		/// Strongly typed for value GL_RGB2_EXT.
		/// </summary>
		Rgb2Ext = Gl.RGB2_EXT,

		/// <summary>
		/// Strongly typed for value GL_RGB4.
		/// </summary>
		Rgb4 = Gl.RGB4,

		/// <summary>
		/// Strongly typed for value GL_RGB5.
		/// </summary>
		Rgb5 = Gl.RGB5,

		/// <summary>
		/// Strongly typed for value GL_RGB5_A1.
		/// </summary>
		Rgb5A1 = Gl.RGB5_A1,

		/// <summary>
		/// Strongly typed for value GL_RGB8.
		/// </summary>
		Rgb8 = Gl.RGB8,

		/// <summary>
		/// Strongly typed for value GL_RGBA12.
		/// </summary>
		Rgba12 = Gl.RGBA12,

		/// <summary>
		/// Strongly typed for value GL_RGBA16.
		/// </summary>
		Rgba16 = Gl.RGBA16,

		/// <summary>
		/// Strongly typed for value GL_RGBA2.
		/// </summary>
		Rgba2 = Gl.RGBA2,

		/// <summary>
		/// Strongly typed for value GL_RGBA4.
		/// </summary>
		Rgba4 = Gl.RGBA4,

		/// <summary>
		/// Strongly typed for value GL_RGBA8.
		/// </summary>
		Rgba8 = Gl.RGBA8,

	}

	/// <summary>
	/// Strongly typed enumeration PixelMap.
	/// </summary>
	public enum PixelMap
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A.
		/// </summary>
		PixelMapAToA = Gl.PIXEL_MAP_A_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B.
		/// </summary>
		PixelMapBToB = Gl.PIXEL_MAP_B_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G.
		/// </summary>
		PixelMapGToG = Gl.PIXEL_MAP_G_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A.
		/// </summary>
		PixelMapIToA = Gl.PIXEL_MAP_I_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B.
		/// </summary>
		PixelMapIToB = Gl.PIXEL_MAP_I_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G.
		/// </summary>
		PixelMapIToG = Gl.PIXEL_MAP_I_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I.
		/// </summary>
		PixelMapIToI = Gl.PIXEL_MAP_I_TO_I,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R.
		/// </summary>
		PixelMapIToR = Gl.PIXEL_MAP_I_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R.
		/// </summary>
		PixelMapRToR = Gl.PIXEL_MAP_R_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S.
		/// </summary>
		PixelMapSToS = Gl.PIXEL_MAP_S_TO_S,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreParameter.
	/// </summary>
	public enum PixelStoreParameter
	{
		/// <summary>
		/// Strongly typed for value GL_PACK_ALIGNMENT.
		/// </summary>
		PackAlignment = Gl.PACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		PackImageDepthSgis = Gl.PACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_HEIGHT, GL_PACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		PackImageHeight = Gl.PACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_PACK_LSB_FIRST.
		/// </summary>
		PackLsbFirst = Gl.PACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_OML.
		/// </summary>
		PackResampleOml = Gl.PACK_RESAMPLE_OML,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_SGIX.
		/// </summary>
		PackResampleSgix = Gl.PACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_ROW_LENGTH.
		/// </summary>
		PackRowLength = Gl.PACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_IMAGES, GL_PACK_SKIP_IMAGES_EXT.
		/// </summary>
		PackSkipImages = Gl.PACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_PIXELS.
		/// </summary>
		PackSkipPixels = Gl.PACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_ROWS.
		/// </summary>
		PackSkipRows = Gl.PACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		PackSkipVolumesSgis = Gl.PACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		PackSubsampleRateSgix = Gl.PACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_SWAP_BYTES.
		/// </summary>
		PackSwapBytes = Gl.PACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_SIZE_SGIX.
		/// </summary>
		PixelTileCacheSizeSgix = Gl.PIXEL_TILE_CACHE_SIZE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_DEPTH_SGIX.
		/// </summary>
		PixelTileGridDepthSgix = Gl.PIXEL_TILE_GRID_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_HEIGHT_SGIX.
		/// </summary>
		PixelTileGridHeightSgix = Gl.PIXEL_TILE_GRID_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_WIDTH_SGIX.
		/// </summary>
		PixelTileGridWidthSgix = Gl.PIXEL_TILE_GRID_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_HEIGHT_SGIX.
		/// </summary>
		PixelTileHeightSgix = Gl.PIXEL_TILE_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_WIDTH_SGIX.
		/// </summary>
		PixelTileWidthSgix = Gl.PIXEL_TILE_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ALIGNMENT.
		/// </summary>
		UnpackAlignment = Gl.UNPACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		UnpackImageDepthSgis = Gl.UNPACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		UnpackImageHeight = Gl.UNPACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_LSB_FIRST.
		/// </summary>
		UnpackLsbFirst = Gl.UNPACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_OML.
		/// </summary>
		UnpackResampleOml = Gl.UNPACK_RESAMPLE_OML,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_SGIX.
		/// </summary>
		UnpackResampleSgix = Gl.UNPACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ROW_LENGTH.
		/// </summary>
		UnpackRowLength = Gl.UNPACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_IMAGES, GL_UNPACK_SKIP_IMAGES_EXT.
		/// </summary>
		UnpackSkipImages = Gl.UNPACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_PIXELS.
		/// </summary>
		UnpackSkipPixels = Gl.UNPACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_ROWS.
		/// </summary>
		UnpackSkipRows = Gl.UNPACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		UnpackSkipVolumesSgis = Gl.UNPACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		UnpackSubsampleRateSgix = Gl.UNPACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SWAP_BYTES.
		/// </summary>
		UnpackSwapBytes = Gl.UNPACK_SWAP_BYTES,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreResampleMode.
	/// </summary>
	public enum PixelStoreResampleMode
	{
		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_DECIMATE_SGIX.
		/// </summary>
		ResampleDecimateSgix = Gl.RESAMPLE_DECIMATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_REPLICATE_SGIX.
		/// </summary>
		ResampleReplicateSgix = Gl.RESAMPLE_REPLICATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_ZERO_FILL_SGIX.
		/// </summary>
		ResampleZeroFillSgix = Gl.RESAMPLE_ZERO_FILL_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreSubsampleRate.
	/// </summary>
	public enum PixelStoreSubsampleRate
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_2424_SGIX.
		/// </summary>
		PixelSubsample2424Sgix = Gl.PIXEL_SUBSAMPLE_2424_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_4242_SGIX.
		/// </summary>
		PixelSubsample4242Sgix = Gl.PIXEL_SUBSAMPLE_4242_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_4444_SGIX.
		/// </summary>
		PixelSubsample4444Sgix = Gl.PIXEL_SUBSAMPLE_4444_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTexGenMode.
	/// </summary>
	public enum PixelTexGenMode
	{
		/// <summary>
		/// Strongly typed for value GL_LUMINANCE.
		/// </summary>
		Luminance = Gl.LUMINANCE,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE_ALPHA.
		/// </summary>
		LuminanceAlpha = Gl.LUMINANCE_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_NONE.
		/// </summary>
		None = Gl.NONE,

		/// <summary>
		/// Strongly typed for value GL_RGB.
		/// </summary>
		Rgb = Gl.RGB,

		/// <summary>
		/// Strongly typed for value GL_RGBA.
		/// </summary>
		Rgba = Gl.RGBA,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTexGenParameterNameSGIS.
	/// </summary>
	public enum PixelTexGenParameterNameSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS.
		/// </summary>
		PixelFragmentAlphaSourceSgis = Gl.PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS.
		/// </summary>
		PixelFragmentRgbSourceSgis = Gl.PIXEL_FRAGMENT_RGB_SOURCE_SGIS,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTransferParameter.
	/// </summary>
	public enum PixelTransferParameter
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_BIAS.
		/// </summary>
		AlphaBias = Gl.ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_SCALE.
		/// </summary>
		AlphaScale = Gl.ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BIAS.
		/// </summary>
		BlueBias = Gl.BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_SCALE.
		/// </summary>
		BlueScale = Gl.BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BIAS.
		/// </summary>
		DepthBias = Gl.DEPTH_BIAS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_SCALE.
		/// </summary>
		DepthScale = Gl.DEPTH_SCALE,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BIAS.
		/// </summary>
		GreenBias = Gl.GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_SCALE.
		/// </summary>
		GreenScale = Gl.GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_OFFSET.
		/// </summary>
		IndexOffset = Gl.INDEX_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_INDEX_SHIFT.
		/// </summary>
		IndexShift = Gl.INDEX_SHIFT,

		/// <summary>
		/// Strongly typed for value GL_MAP_COLOR.
		/// </summary>
		MapColor = Gl.MAP_COLOR,

		/// <summary>
		/// Strongly typed for value GL_MAP_STENCIL.
		/// </summary>
		MapStencil = Gl.MAP_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_BIAS, GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI.
		/// </summary>
		PostColorMatrixAlphaBias = Gl.POST_COLOR_MATRIX_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_SCALE, GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI.
		/// </summary>
		PostColorMatrixAlphaScale = Gl.POST_COLOR_MATRIX_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_BIAS, GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI.
		/// </summary>
		PostColorMatrixBlueBias = Gl.POST_COLOR_MATRIX_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_SCALE, GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI.
		/// </summary>
		PostColorMatrixBlueScale = Gl.POST_COLOR_MATRIX_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_BIAS, GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI.
		/// </summary>
		PostColorMatrixGreenBias = Gl.POST_COLOR_MATRIX_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_SCALE, GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI.
		/// </summary>
		PostColorMatrixGreenScale = Gl.POST_COLOR_MATRIX_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_BIAS, GL_POST_COLOR_MATRIX_RED_BIAS_SGI.
		/// </summary>
		PostColorMatrixRedBias = Gl.POST_COLOR_MATRIX_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_SCALE, GL_POST_COLOR_MATRIX_RED_SCALE_SGI.
		/// </summary>
		PostColorMatrixRedScale = Gl.POST_COLOR_MATRIX_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_BIAS, GL_POST_CONVOLUTION_ALPHA_BIAS_EXT.
		/// </summary>
		PostConvolutionAlphaBias = Gl.POST_CONVOLUTION_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_SCALE, GL_POST_CONVOLUTION_ALPHA_SCALE_EXT.
		/// </summary>
		PostConvolutionAlphaScale = Gl.POST_CONVOLUTION_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_BIAS, GL_POST_CONVOLUTION_BLUE_BIAS_EXT.
		/// </summary>
		PostConvolutionBlueBias = Gl.POST_CONVOLUTION_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_SCALE, GL_POST_CONVOLUTION_BLUE_SCALE_EXT.
		/// </summary>
		PostConvolutionBlueScale = Gl.POST_CONVOLUTION_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_BIAS, GL_POST_CONVOLUTION_GREEN_BIAS_EXT.
		/// </summary>
		PostConvolutionGreenBias = Gl.POST_CONVOLUTION_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_SCALE, GL_POST_CONVOLUTION_GREEN_SCALE_EXT.
		/// </summary>
		PostConvolutionGreenScale = Gl.POST_CONVOLUTION_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_BIAS, GL_POST_CONVOLUTION_RED_BIAS_EXT.
		/// </summary>
		PostConvolutionRedBias = Gl.POST_CONVOLUTION_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_SCALE, GL_POST_CONVOLUTION_RED_SCALE_EXT.
		/// </summary>
		PostConvolutionRedScale = Gl.POST_CONVOLUTION_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_RED_BIAS.
		/// </summary>
		RedBias = Gl.RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_RED_SCALE.
		/// </summary>
		RedScale = Gl.RED_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration PixelType.
	/// </summary>
	public enum PixelType
	{
		/// <summary>
		/// Strongly typed for value GL_BITMAP.
		/// </summary>
		Bitmap = Gl.BITMAP,

		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_3_3_2_EXT.
		/// </summary>
		UnsignedByte332 = Gl.UNSIGNED_BYTE_3_3_2,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_10_10_10_2_EXT.
		/// </summary>
		UnsignedInt1010102 = Gl.UNSIGNED_INT_10_10_10_2,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_EXT.
		/// </summary>
		UnsignedInt8888 = Gl.UNSIGNED_INT_8_8_8_8,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_EXT.
		/// </summary>
		UnsignedShort4444 = Gl.UNSIGNED_SHORT_4_4_4_4,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_5_5_5_1_EXT.
		/// </summary>
		UnsignedShort5551 = Gl.UNSIGNED_SHORT_5_5_5_1,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_HALF_FLOAT.
		/// </summary>
		HalfFloat = Gl.HALF_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE_2_3_3_REV.
		/// </summary>
		UnsignedByte233Rev = Gl.UNSIGNED_BYTE_2_3_3_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_6_5.
		/// </summary>
		UnsignedShort565 = Gl.UNSIGNED_SHORT_5_6_5,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_1_5_5_5_REV.
		/// </summary>
		UnsignedShort1555Rev = Gl.UNSIGNED_SHORT_1_5_5_5_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_6_5_REV.
		/// </summary>
		UnsignedShort565Rev = Gl.UNSIGNED_SHORT_5_6_5_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </summary>
		UnsignedInt2101010Rev = Gl.UNSIGNED_INT_2_10_10_10_REV,

	}

	/// <summary>
	/// Strongly typed enumeration PointParameterNameSGIS.
	/// </summary>
	public enum PointParameterNameSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_DISTANCE_ATTENUATION_EXT, GL_DISTANCE_ATTENUATION_SGIS, GL_POINT_DISTANCE_ATTENUATION, 
		/// GL_POINT_DISTANCE_ATTENUATION_ARB.
		/// </summary>
		DistanceAttenuationExt = Gl.DISTANCE_ATTENUATION_EXT,

		/// <summary>
		/// Strongly typed for value GL_POINT_FADE_THRESHOLD_SIZE, GL_POINT_FADE_THRESHOLD_SIZE_ARB, 
		/// GL_POINT_FADE_THRESHOLD_SIZE_EXT, GL_POINT_FADE_THRESHOLD_SIZE_SGIS.
		/// </summary>
		PointFadeThresholdSize = Gl.POINT_FADE_THRESHOLD_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MAX, GL_POINT_SIZE_MAX_ARB, GL_POINT_SIZE_MAX_EXT, GL_POINT_SIZE_MAX_SGIS.
		/// </summary>
		PointSizeMax = Gl.POINT_SIZE_MAX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MIN, GL_POINT_SIZE_MIN_ARB, GL_POINT_SIZE_MIN_EXT, GL_POINT_SIZE_MIN_SGIS.
		/// </summary>
		PointSizeMin = Gl.POINT_SIZE_MIN,

	}

	/// <summary>
	/// Strongly typed enumeration PolygonMode.
	/// </summary>
	public enum PolygonMode
	{
		/// <summary>
		/// Strongly typed for value GL_FILL.
		/// </summary>
		Fill = Gl.FILL,

		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration PrimitiveType.
	/// </summary>
	public enum PrimitiveType
	{
		/// <summary>
		/// Strongly typed for value GL_LINES.
		/// </summary>
		Lines = Gl.LINES,

		/// <summary>
		/// Strongly typed for value GL_LINES_ADJACENCY, GL_LINES_ADJACENCY_ARB, GL_LINES_ADJACENCY_EXT.
		/// </summary>
		LinesAdjacency = Gl.LINES_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_LINE_LOOP.
		/// </summary>
		LineLoop = Gl.LINE_LOOP,

		/// <summary>
		/// Strongly typed for value GL_LINE_STRIP.
		/// </summary>
		LineStrip = Gl.LINE_STRIP,

		/// <summary>
		/// Strongly typed for value GL_LINE_STRIP_ADJACENCY, GL_LINE_STRIP_ADJACENCY_ARB, GL_LINE_STRIP_ADJACENCY_EXT.
		/// </summary>
		LineStripAdjacency = Gl.LINE_STRIP_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_PATCHES.
		/// </summary>
		Patches = Gl.PATCHES,

		/// <summary>
		/// Strongly typed for value GL_POINTS.
		/// </summary>
		Points = Gl.POINTS,

		/// <summary>
		/// Strongly typed for value GL_POLYGON.
		/// </summary>
		Polygon = Gl.POLYGON,

		/// <summary>
		/// Strongly typed for value GL_QUADS.
		/// </summary>
		Quads = Gl.QUADS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_STRIP.
		/// </summary>
		QuadStrip = Gl.QUAD_STRIP,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLES.
		/// </summary>
		Triangles = Gl.TRIANGLES,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLES_ADJACENCY, GL_TRIANGLES_ADJACENCY_ARB, GL_TRIANGLES_ADJACENCY_EXT.
		/// </summary>
		TrianglesAdjacency = Gl.TRIANGLES_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_FAN.
		/// </summary>
		TriangleFan = Gl.TRIANGLE_FAN,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_STRIP.
		/// </summary>
		TriangleStrip = Gl.TRIANGLE_STRIP,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY_ARB, GL_TRIANGLE_STRIP_ADJACENCY_EXT.
		/// </summary>
		TriangleStripAdjacency = Gl.TRIANGLE_STRIP_ADJACENCY,

	}

	/// <summary>
	/// Strongly typed enumeration OcclusionQueryEventMaskAMD.
	/// </summary>
	[Flags()]
	public enum OcclusionQueryEventMaskAMD : uint
	{
		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD.
		/// </summary>
		QueryDepthPassEventBitAmd = Gl.QUERY_DEPTH_PASS_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD.
		/// </summary>
		QueryDepthFailEventBitAmd = Gl.QUERY_DEPTH_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD.
		/// </summary>
		QueryStencilFailEventBitAmd = Gl.QUERY_STENCIL_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD.
		/// </summary>
		QueryDepthBoundsFailEventBitAmd = Gl.QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_ALL_EVENT_BITS_AMD.
		/// </summary>
		QueryAllEventBitsAmd = Gl.QUERY_ALL_EVENT_BITS_AMD,

	}

	/// <summary>
	/// Strongly typed enumeration ReadBufferMode.
	/// </summary>
	public enum ReadBufferMode
	{
		/// <summary>
		/// Strongly typed for value GL_AUX0.
		/// </summary>
		Aux0 = Gl.AUX0,

		/// <summary>
		/// Strongly typed for value GL_AUX1.
		/// </summary>
		Aux1 = Gl.AUX1,

		/// <summary>
		/// Strongly typed for value GL_AUX2.
		/// </summary>
		Aux2 = Gl.AUX2,

		/// <summary>
		/// Strongly typed for value GL_AUX3.
		/// </summary>
		Aux3 = Gl.AUX3,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_BACK_LEFT.
		/// </summary>
		BackLeft = Gl.BACK_LEFT,

		/// <summary>
		/// Strongly typed for value GL_BACK_RIGHT.
		/// </summary>
		BackRight = Gl.BACK_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_LEFT.
		/// </summary>
		FrontLeft = Gl.FRONT_LEFT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_RIGHT.
		/// </summary>
		FrontRight = Gl.FRONT_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_LEFT.
		/// </summary>
		Left = Gl.LEFT,

		/// <summary>
		/// Strongly typed for value GL_RIGHT.
		/// </summary>
		Right = Gl.RIGHT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT0.
		/// </summary>
		ColorAttachment0 = Gl.COLOR_ATTACHMENT0,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT1.
		/// </summary>
		ColorAttachment1 = Gl.COLOR_ATTACHMENT1,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT2.
		/// </summary>
		ColorAttachment2 = Gl.COLOR_ATTACHMENT2,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT3.
		/// </summary>
		ColorAttachment3 = Gl.COLOR_ATTACHMENT3,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT4.
		/// </summary>
		ColorAttachment4 = Gl.COLOR_ATTACHMENT4,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT5.
		/// </summary>
		ColorAttachment5 = Gl.COLOR_ATTACHMENT5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT6.
		/// </summary>
		ColorAttachment6 = Gl.COLOR_ATTACHMENT6,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT7.
		/// </summary>
		ColorAttachment7 = Gl.COLOR_ATTACHMENT7,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT8.
		/// </summary>
		ColorAttachment8 = Gl.COLOR_ATTACHMENT8,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT9.
		/// </summary>
		ColorAttachment9 = Gl.COLOR_ATTACHMENT9,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT10.
		/// </summary>
		ColorAttachment10 = Gl.COLOR_ATTACHMENT10,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT11.
		/// </summary>
		ColorAttachment11 = Gl.COLOR_ATTACHMENT11,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT12.
		/// </summary>
		ColorAttachment12 = Gl.COLOR_ATTACHMENT12,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT13.
		/// </summary>
		ColorAttachment13 = Gl.COLOR_ATTACHMENT13,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT14.
		/// </summary>
		ColorAttachment14 = Gl.COLOR_ATTACHMENT14,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT15.
		/// </summary>
		ColorAttachment15 = Gl.COLOR_ATTACHMENT15,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT16.
		/// </summary>
		ColorAttachment16 = Gl.COLOR_ATTACHMENT16,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT17.
		/// </summary>
		ColorAttachment17 = Gl.COLOR_ATTACHMENT17,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT18.
		/// </summary>
		ColorAttachment18 = Gl.COLOR_ATTACHMENT18,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT19.
		/// </summary>
		ColorAttachment19 = Gl.COLOR_ATTACHMENT19,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT20.
		/// </summary>
		ColorAttachment20 = Gl.COLOR_ATTACHMENT20,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT21.
		/// </summary>
		ColorAttachment21 = Gl.COLOR_ATTACHMENT21,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT22.
		/// </summary>
		ColorAttachment22 = Gl.COLOR_ATTACHMENT22,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT23.
		/// </summary>
		ColorAttachment23 = Gl.COLOR_ATTACHMENT23,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT24.
		/// </summary>
		ColorAttachment24 = Gl.COLOR_ATTACHMENT24,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT25.
		/// </summary>
		ColorAttachment25 = Gl.COLOR_ATTACHMENT25,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT26.
		/// </summary>
		ColorAttachment26 = Gl.COLOR_ATTACHMENT26,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT27.
		/// </summary>
		ColorAttachment27 = Gl.COLOR_ATTACHMENT27,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT28.
		/// </summary>
		ColorAttachment28 = Gl.COLOR_ATTACHMENT28,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT29.
		/// </summary>
		ColorAttachment29 = Gl.COLOR_ATTACHMENT29,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT30.
		/// </summary>
		ColorAttachment30 = Gl.COLOR_ATTACHMENT30,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT31.
		/// </summary>
		ColorAttachment31 = Gl.COLOR_ATTACHMENT31,

	}

	/// <summary>
	/// Strongly typed enumeration RenderingMode.
	/// </summary>
	public enum RenderingMode
	{
		/// <summary>
		/// Strongly typed for value GL_FEEDBACK.
		/// </summary>
		Feedback = Gl.FEEDBACK,

		/// <summary>
		/// Strongly typed for value GL_RENDER.
		/// </summary>
		Render = Gl.RENDER,

		/// <summary>
		/// Strongly typed for value GL_SELECT.
		/// </summary>
		Select = Gl.SELECT,

	}

	/// <summary>
	/// Strongly typed enumeration SamplePatternSGIS.
	/// </summary>
	public enum SamplePatternSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_1PASS_EXT, GL_1PASS_SGIS.
		/// </summary>
		_1passExt = Gl._1PASS_EXT,

		/// <summary>
		/// Strongly typed for value GL_2PASS_0_EXT, GL_2PASS_0_SGIS.
		/// </summary>
		_2pass0Ext = Gl._2PASS_0_EXT,

		/// <summary>
		/// Strongly typed for value GL_2PASS_1_EXT, GL_2PASS_1_SGIS.
		/// </summary>
		_2pass1Ext = Gl._2PASS_1_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_0_EXT, GL_4PASS_0_SGIS.
		/// </summary>
		_4pass0Ext = Gl._4PASS_0_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_1_EXT, GL_4PASS_1_SGIS.
		/// </summary>
		_4pass1Ext = Gl._4PASS_1_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_2_EXT, GL_4PASS_2_SGIS.
		/// </summary>
		_4pass2Ext = Gl._4PASS_2_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_3_EXT, GL_4PASS_3_SGIS.
		/// </summary>
		_4pass3Ext = Gl._4PASS_3_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration SeparableTargetEXT.
	/// </summary>
	public enum SeparableTargetEXT
	{
		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D, GL_SEPARABLE_2D_EXT.
		/// </summary>
		Separable2d = Gl.SEPARABLE_2D,

	}

	/// <summary>
	/// Strongly typed enumeration ShadingModel.
	/// </summary>
	public enum ShadingModel
	{
		/// <summary>
		/// Strongly typed for value GL_FLAT.
		/// </summary>
		Flat = Gl.FLAT,

		/// <summary>
		/// Strongly typed for value GL_SMOOTH.
		/// </summary>
		Smooth = Gl.SMOOTH,

	}

	/// <summary>
	/// Strongly typed enumeration StencilFaceDirection.
	/// </summary>
	public enum StencilFaceDirection
	{
		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration StencilFunction.
	/// </summary>
	public enum StencilFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration StencilOp.
	/// </summary>
	public enum StencilOp
	{
		/// <summary>
		/// Strongly typed for value GL_DECR.
		/// </summary>
		Decr = Gl.DECR,

		/// <summary>
		/// Strongly typed for value GL_INCR.
		/// </summary>
		Incr = Gl.INCR,

		/// <summary>
		/// Strongly typed for value GL_INVERT.
		/// </summary>
		Invert = Gl.INVERT,

		/// <summary>
		/// Strongly typed for value GL_KEEP.
		/// </summary>
		Keep = Gl.KEEP,

		/// <summary>
		/// Strongly typed for value GL_REPLACE.
		/// </summary>
		Replace = Gl.REPLACE,

		/// <summary>
		/// Strongly typed for value GL_ZERO.
		/// </summary>
		Zero = Gl.ZERO,

	}

	/// <summary>
	/// Strongly typed enumeration StringName.
	/// </summary>
	public enum StringName
	{
		/// <summary>
		/// Strongly typed for value GL_EXTENSIONS.
		/// </summary>
		Extensions = Gl.EXTENSIONS,

		/// <summary>
		/// Strongly typed for value GL_RENDERER.
		/// </summary>
		Renderer = Gl.RENDERER,

		/// <summary>
		/// Strongly typed for value GL_VENDOR.
		/// </summary>
		Vendor = Gl.VENDOR,

		/// <summary>
		/// Strongly typed for value GL_VERSION.
		/// </summary>
		Version = Gl.VERSION,

		/// <summary>
		/// Strongly typed for value GL_SHADING_LANGUAGE_VERSION.
		/// </summary>
		ShadingLanguageVersion = Gl.SHADING_LANGUAGE_VERSION,

	}

	/// <summary>
	/// Strongly typed enumeration TexCoordPointerType.
	/// </summary>
	public enum TexCoordPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration TextureCoordName.
	/// </summary>
	public enum TextureCoordName
	{
		/// <summary>
		/// Strongly typed for value GL_S.
		/// </summary>
		S = Gl.S,

		/// <summary>
		/// Strongly typed for value GL_T.
		/// </summary>
		T = Gl.T,

		/// <summary>
		/// Strongly typed for value GL_R.
		/// </summary>
		R = Gl.R,

		/// <summary>
		/// Strongly typed for value GL_Q.
		/// </summary>
		Q = Gl.Q,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvMode.
	/// </summary>
	public enum TextureEnvMode
	{
		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		Add = Gl.ADD,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_DECAL.
		/// </summary>
		Decal = Gl.DECAL,

		/// <summary>
		/// Strongly typed for value GL_MODULATE.
		/// </summary>
		Modulate = Gl.MODULATE,

		/// <summary>
		/// Strongly typed for value GL_REPLACE_EXT.
		/// </summary>
		ReplaceExt = Gl.REPLACE_EXT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_BIAS_SGIX.
		/// </summary>
		TextureEnvBiasSgix = Gl.TEXTURE_ENV_BIAS_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvParameter.
	/// </summary>
	public enum TextureEnvParameter
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_COLOR.
		/// </summary>
		TextureEnvColor = Gl.TEXTURE_ENV_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_MODE.
		/// </summary>
		TextureEnvMode = Gl.TEXTURE_ENV_MODE,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvTarget.
	/// </summary>
	public enum TextureEnvTarget
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV.
		/// </summary>
		TextureEnv = Gl.TEXTURE_ENV,

	}

	/// <summary>
	/// Strongly typed enumeration TextureFilterFuncSGIS.
	/// </summary>
	public enum TextureFilterFuncSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		Filter4Sgis = Gl.FILTER4_SGIS,

	}

	/// <summary>
	/// Strongly typed enumeration TextureGenMode.
	/// </summary>
	public enum TextureGenMode
	{
		/// <summary>
		/// Strongly typed for value GL_EYE_DISTANCE_TO_LINE_SGIS.
		/// </summary>
		EyeDistanceToLineSgis = Gl.EYE_DISTANCE_TO_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_DISTANCE_TO_POINT_SGIS.
		/// </summary>
		EyeDistanceToPointSgis = Gl.EYE_DISTANCE_TO_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_LINEAR.
		/// </summary>
		EyeLinear = Gl.EYE_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_DISTANCE_TO_LINE_SGIS.
		/// </summary>
		ObjectDistanceToLineSgis = Gl.OBJECT_DISTANCE_TO_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_DISTANCE_TO_POINT_SGIS.
		/// </summary>
		ObjectDistanceToPointSgis = Gl.OBJECT_DISTANCE_TO_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_LINEAR.
		/// </summary>
		ObjectLinear = Gl.OBJECT_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_SPHERE_MAP.
		/// </summary>
		SphereMap = Gl.SPHERE_MAP,

	}

	/// <summary>
	/// Strongly typed enumeration TextureGenParameter.
	/// </summary>
	public enum TextureGenParameter
	{
		/// <summary>
		/// Strongly typed for value GL_EYE_LINE_SGIS.
		/// </summary>
		EyeLineSgis = Gl.EYE_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_PLANE.
		/// </summary>
		EyePlane = Gl.EYE_PLANE,

		/// <summary>
		/// Strongly typed for value GL_EYE_POINT_SGIS.
		/// </summary>
		EyePointSgis = Gl.EYE_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_LINE_SGIS.
		/// </summary>
		ObjectLineSgis = Gl.OBJECT_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_PLANE.
		/// </summary>
		ObjectPlane = Gl.OBJECT_PLANE,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_POINT_SGIS.
		/// </summary>
		ObjectPointSgis = Gl.OBJECT_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_MODE.
		/// </summary>
		TextureGenMode = Gl.TEXTURE_GEN_MODE,

	}

	/// <summary>
	/// Strongly typed enumeration TextureMagFilter.
	/// </summary>
	public enum TextureMagFilter
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		Filter4Sgis = Gl.FILTER4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		Linear = Gl.LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_ALPHA_SGIS.
		/// </summary>
		LinearDetailAlphaSgis = Gl.LINEAR_DETAIL_ALPHA_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_COLOR_SGIS.
		/// </summary>
		LinearDetailColorSgis = Gl.LINEAR_DETAIL_COLOR_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_SGIS.
		/// </summary>
		LinearDetailSgis = Gl.LINEAR_DETAIL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_ALPHA_SGIS.
		/// </summary>
		LinearSharpenAlphaSgis = Gl.LINEAR_SHARPEN_ALPHA_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_COLOR_SGIS.
		/// </summary>
		LinearSharpenColorSgis = Gl.LINEAR_SHARPEN_COLOR_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_SGIS.
		/// </summary>
		LinearSharpenSgis = Gl.LINEAR_SHARPEN_SGIS,

		/// <summary>
		/// Strongly typed for value GL_NEAREST.
		/// </summary>
		Nearest = Gl.NEAREST,

	}

	/// <summary>
	/// Strongly typed enumeration TextureMinFilter.
	/// </summary>
	public enum TextureMinFilter
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		Filter4Sgis = Gl.FILTER4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		Linear = Gl.LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_CLIPMAP_LINEAR_SGIX.
		/// </summary>
		LinearClipmapLinearSgix = Gl.LINEAR_CLIPMAP_LINEAR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_CLIPMAP_NEAREST_SGIX.
		/// </summary>
		LinearClipmapNearestSgix = Gl.LINEAR_CLIPMAP_NEAREST_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_MIPMAP_LINEAR.
		/// </summary>
		LinearMipmapLinear = Gl.LINEAR_MIPMAP_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_MIPMAP_NEAREST.
		/// </summary>
		LinearMipmapNearest = Gl.LINEAR_MIPMAP_NEAREST,

		/// <summary>
		/// Strongly typed for value GL_NEAREST.
		/// </summary>
		Nearest = Gl.NEAREST,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_CLIPMAP_LINEAR_SGIX.
		/// </summary>
		NearestClipmapLinearSgix = Gl.NEAREST_CLIPMAP_LINEAR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_CLIPMAP_NEAREST_SGIX.
		/// </summary>
		NearestClipmapNearestSgix = Gl.NEAREST_CLIPMAP_NEAREST_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_MIPMAP_LINEAR.
		/// </summary>
		NearestMipmapLinear = Gl.NEAREST_MIPMAP_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_MIPMAP_NEAREST.
		/// </summary>
		NearestMipmapNearest = Gl.NEAREST_MIPMAP_NEAREST,

	}

	/// <summary>
	/// Strongly typed enumeration TextureParameterName.
	/// </summary>
	public enum TextureParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_LEVEL_SGIS.
		/// </summary>
		DetailTextureLevelSgis = Gl.DETAIL_TEXTURE_LEVEL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_MODE_SGIS.
		/// </summary>
		DetailTextureModeSgis = Gl.DETAIL_TEXTURE_MODE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_TEXTURE_SELECT_SGIS.
		/// </summary>
		DualTextureSelectSgis = Gl.DUAL_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP, GL_GENERATE_MIPMAP_SGIS.
		/// </summary>
		GenerateMipmap = Gl.GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_SGIX.
		/// </summary>
		PostTextureFilterBiasSgix = Gl.POST_TEXTURE_FILTER_BIAS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_SGIX.
		/// </summary>
		PostTextureFilterScaleSgix = Gl.POST_TEXTURE_FILTER_SCALE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_QUAD_TEXTURE_SELECT_SGIS.
		/// </summary>
		QuadTextureSelectSgis = Gl.QUAD_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SHADOW_AMBIENT_SGIX.
		/// </summary>
		ShadowAmbientSgix = Gl.SHADOW_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER_COLOR.
		/// </summary>
		TextureBorderColor = Gl.TEXTURE_BORDER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_CENTER_SGIX.
		/// </summary>
		TextureClipmapCenterSgix = Gl.TEXTURE_CLIPMAP_CENTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		TextureClipmapDepthSgix = Gl.TEXTURE_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_FRAME_SGIX.
		/// </summary>
		TextureClipmapFrameSgix = Gl.TEXTURE_CLIPMAP_FRAME_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX.
		/// </summary>
		TextureClipmapLodOffsetSgix = Gl.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_OFFSET_SGIX.
		/// </summary>
		TextureClipmapOffsetSgix = Gl.TEXTURE_CLIPMAP_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		TextureClipmapVirtualDepthSgix = Gl.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_SGIX.
		/// </summary>
		TextureCompareSgix = Gl.TEXTURE_COMPARE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_R_SGIX.
		/// </summary>
		TextureLodBiasRSgix = Gl.TEXTURE_LOD_BIAS_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_S_SGIX.
		/// </summary>
		TextureLodBiasSSgix = Gl.TEXTURE_LOD_BIAS_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_T_SGIX.
		/// </summary>
		TextureLodBiasTSgix = Gl.TEXTURE_LOD_BIAS_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAG_FILTER.
		/// </summary>
		TextureMagFilter = Gl.TEXTURE_MAG_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_R_SGIX.
		/// </summary>
		TextureMaxClampRSgix = Gl.TEXTURE_MAX_CLAMP_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_S_SGIX.
		/// </summary>
		TextureMaxClampSSgix = Gl.TEXTURE_MAX_CLAMP_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_T_SGIX.
		/// </summary>
		TextureMaxClampTSgix = Gl.TEXTURE_MAX_CLAMP_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_FILTER.
		/// </summary>
		TextureMinFilter = Gl.TEXTURE_MIN_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_PRIORITY, GL_TEXTURE_PRIORITY_EXT.
		/// </summary>
		TexturePriority = Gl.TEXTURE_PRIORITY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_Q_SGIS.
		/// </summary>
		TextureWrapQSgis = Gl.TEXTURE_WRAP_Q_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_R, GL_TEXTURE_WRAP_R_EXT.
		/// </summary>
		TextureWrapR = Gl.TEXTURE_WRAP_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_S.
		/// </summary>
		TextureWrapS = Gl.TEXTURE_WRAP_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_T.
		/// </summary>
		TextureWrapT = Gl.TEXTURE_WRAP_T,

	}

	/// <summary>
	/// Strongly typed enumeration TextureTarget.
	/// </summary>
	public enum TextureTarget
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_2D_SGIS.
		/// </summary>
		DetailTexture2dSgis = Gl.DETAIL_TEXTURE_2D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_1D, GL_PROXY_TEXTURE_1D_EXT.
		/// </summary>
		ProxyTexture1d = Gl.PROXY_TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_2D_EXT.
		/// </summary>
		ProxyTexture2d = Gl.PROXY_TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_3D_EXT.
		/// </summary>
		ProxyTexture3d = Gl.PROXY_TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_4D_SGIS.
		/// </summary>
		ProxyTexture4dSgis = Gl.PROXY_TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D, GL_TEXTURE_3D_EXT.
		/// </summary>
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BASE_LEVEL_SGIS.
		/// </summary>
		TextureBaseLevel = Gl.TEXTURE_BASE_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LEVEL_SGIS.
		/// </summary>
		TextureMaxLevel = Gl.TEXTURE_MAX_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LOD_SGIS.
		/// </summary>
		TextureMaxLod = Gl.TEXTURE_MAX_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_LOD, GL_TEXTURE_MIN_LOD_SGIS.
		/// </summary>
		TextureMinLod = Gl.TEXTURE_MIN_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RECTANGLE.
		/// </summary>
		TextureRectangle = Gl.TEXTURE_RECTANGLE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP.
		/// </summary>
		TextureCubeMap = Gl.TEXTURE_CUBE_MAP,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_X.
		/// </summary>
		TextureCubeMapPositiveX = Gl.TEXTURE_CUBE_MAP_POSITIVE_X,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_X.
		/// </summary>
		TextureCubeMapNegativeX = Gl.TEXTURE_CUBE_MAP_NEGATIVE_X,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_Y.
		/// </summary>
		TextureCubeMapPositiveY = Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_Y.
		/// </summary>
		TextureCubeMapNegativeY = Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_Z.
		/// </summary>
		TextureCubeMapPositiveZ = Gl.TEXTURE_CUBE_MAP_POSITIVE_Z,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </summary>
		TextureCubeMapNegativeZ = Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z,

	}

	/// <summary>
	/// Strongly typed enumeration TextureWrapMode.
	/// </summary>
	public enum TextureWrapMode
	{
		/// <summary>
		/// Strongly typed for value GL_CLAMP.
		/// </summary>
		Clamp = Gl.CLAMP,

		/// <summary>
		/// Strongly typed for value GL_CLAMP_TO_BORDER, GL_CLAMP_TO_BORDER_ARB, GL_CLAMP_TO_BORDER_SGIS.
		/// </summary>
		ClampToBorder = Gl.CLAMP_TO_BORDER,

		/// <summary>
		/// Strongly typed for value GL_CLAMP_TO_EDGE, GL_CLAMP_TO_EDGE_SGIS.
		/// </summary>
		ClampToEdge = Gl.CLAMP_TO_EDGE,

		/// <summary>
		/// Strongly typed for value GL_REPEAT.
		/// </summary>
		Repeat = Gl.REPEAT,

	}

	/// <summary>
	/// Strongly typed enumeration UseProgramStageMask.
	/// </summary>
	[Flags()]
	public enum UseProgramStageMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_VERTEX_SHADER_BIT.
		/// </summary>
		VertexShaderBit = Gl.VERTEX_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER_BIT.
		/// </summary>
		FragmentShaderBit = Gl.FRAGMENT_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SHADER_BIT.
		/// </summary>
		GeometryShaderBit = Gl.GEOMETRY_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SHADER_BIT.
		/// </summary>
		TessControlShaderBit = Gl.TESS_CONTROL_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SHADER_BIT.
		/// </summary>
		TessEvaluationShaderBit = Gl.TESS_EVALUATION_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COMPUTE_SHADER_BIT.
		/// </summary>
		ComputeShaderBit = Gl.COMPUTE_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ALL_SHADER_BITS.
		/// </summary>
		AllShaderBits = Gl.ALL_SHADER_BITS,

	}

	/// <summary>
	/// Strongly typed enumeration VertexPointerType.
	/// </summary>
	public enum VertexPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration BufferTargetARB.
	/// </summary>
	public enum BufferTargetARB
	{
		/// <summary>
		/// Strongly typed for value GL_ARRAY_BUFFER.
		/// </summary>
		ArrayBuffer = Gl.ARRAY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER.
		/// </summary>
		AtomicCounterBuffer = Gl.ATOMIC_COUNTER_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_COPY_READ_BUFFER.
		/// </summary>
		CopyReadBuffer = Gl.COPY_READ_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_COPY_WRITE_BUFFER.
		/// </summary>
		CopyWriteBuffer = Gl.COPY_WRITE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_DISPATCH_INDIRECT_BUFFER.
		/// </summary>
		DispatchIndirectBuffer = Gl.DISPATCH_INDIRECT_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRAW_INDIRECT_BUFFER.
		/// </summary>
		DrawIndirectBuffer = Gl.DRAW_INDIRECT_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_ELEMENT_ARRAY_BUFFER.
		/// </summary>
		ElementArrayBuffer = Gl.ELEMENT_ARRAY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_PACK_BUFFER.
		/// </summary>
		PixelPackBuffer = Gl.PIXEL_PACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_UNPACK_BUFFER.
		/// </summary>
		PixelUnpackBuffer = Gl.PIXEL_UNPACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_QUERY_BUFFER.
		/// </summary>
		QueryBuffer = Gl.QUERY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_SHADER_STORAGE_BUFFER.
		/// </summary>
		ShaderStorageBuffer = Gl.SHADER_STORAGE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BUFFER.
		/// </summary>
		TextureBuffer = Gl.TEXTURE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER.
		/// </summary>
		TransformFeedbackBuffer = Gl.TRANSFORM_FEEDBACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BUFFER.
		/// </summary>
		UniformBuffer = Gl.UNIFORM_BUFFER,

	}

	/// <summary>
	/// Strongly typed enumeration BufferUsageARB.
	/// </summary>
	public enum BufferUsageARB
	{
		/// <summary>
		/// Strongly typed for value GL_STREAM_DRAW.
		/// </summary>
		StreamDraw = Gl.STREAM_DRAW,

		/// <summary>
		/// Strongly typed for value GL_STREAM_READ.
		/// </summary>
		StreamRead = Gl.STREAM_READ,

		/// <summary>
		/// Strongly typed for value GL_STREAM_COPY.
		/// </summary>
		StreamCopy = Gl.STREAM_COPY,

		/// <summary>
		/// Strongly typed for value GL_STATIC_DRAW.
		/// </summary>
		StaticDraw = Gl.STATIC_DRAW,

		/// <summary>
		/// Strongly typed for value GL_STATIC_READ.
		/// </summary>
		StaticRead = Gl.STATIC_READ,

		/// <summary>
		/// Strongly typed for value GL_STATIC_COPY.
		/// </summary>
		StaticCopy = Gl.STATIC_COPY,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_DRAW.
		/// </summary>
		DynamicDraw = Gl.DYNAMIC_DRAW,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_READ.
		/// </summary>
		DynamicRead = Gl.DYNAMIC_READ,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_COPY.
		/// </summary>
		DynamicCopy = Gl.DYNAMIC_COPY,

	}

	/// <summary>
	/// Strongly typed enumeration BufferAccessARB.
	/// </summary>
	public enum BufferAccessARB
	{
		/// <summary>
		/// Strongly typed for value GL_READ_ONLY.
		/// </summary>
		ReadOnly = Gl.READ_ONLY,

		/// <summary>
		/// Strongly typed for value GL_WRITE_ONLY.
		/// </summary>
		WriteOnly = Gl.WRITE_ONLY,

		/// <summary>
		/// Strongly typed for value GL_READ_WRITE.
		/// </summary>
		ReadWrite = Gl.READ_WRITE,

	}


	}
