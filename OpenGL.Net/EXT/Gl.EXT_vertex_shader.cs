
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
		/// Value of GL_VERTEX_SHADER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_EXT = 0x8780;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_BINDING_EXT = 0x8781;

		/// <summary>
		/// Value of GL_OP_INDEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_INDEX_EXT = 0x8782;

		/// <summary>
		/// Value of GL_OP_NEGATE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_NEGATE_EXT = 0x8783;

		/// <summary>
		/// Value of GL_OP_DOT3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_DOT3_EXT = 0x8784;

		/// <summary>
		/// Value of GL_OP_DOT4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_DOT4_EXT = 0x8785;

		/// <summary>
		/// Value of GL_OP_MUL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MUL_EXT = 0x8786;

		/// <summary>
		/// Value of GL_OP_ADD_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_ADD_EXT = 0x8787;

		/// <summary>
		/// Value of GL_OP_MADD_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MADD_EXT = 0x8788;

		/// <summary>
		/// Value of GL_OP_FRAC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_FRAC_EXT = 0x8789;

		/// <summary>
		/// Value of GL_OP_MAX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MAX_EXT = 0x878A;

		/// <summary>
		/// Value of GL_OP_MIN_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MIN_EXT = 0x878B;

		/// <summary>
		/// Value of GL_OP_SET_GE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_SET_GE_EXT = 0x878C;

		/// <summary>
		/// Value of GL_OP_SET_LT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_SET_LT_EXT = 0x878D;

		/// <summary>
		/// Value of GL_OP_CLAMP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_CLAMP_EXT = 0x878E;

		/// <summary>
		/// Value of GL_OP_FLOOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_FLOOR_EXT = 0x878F;

		/// <summary>
		/// Value of GL_OP_ROUND_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_ROUND_EXT = 0x8790;

		/// <summary>
		/// Value of GL_OP_EXP_BASE_2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_EXP_BASE_2_EXT = 0x8791;

		/// <summary>
		/// Value of GL_OP_LOG_BASE_2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_LOG_BASE_2_EXT = 0x8792;

		/// <summary>
		/// Value of GL_OP_POWER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_POWER_EXT = 0x8793;

		/// <summary>
		/// Value of GL_OP_RECIP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_RECIP_EXT = 0x8794;

		/// <summary>
		/// Value of GL_OP_RECIP_SQRT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_RECIP_SQRT_EXT = 0x8795;

		/// <summary>
		/// Value of GL_OP_SUB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_SUB_EXT = 0x8796;

		/// <summary>
		/// Value of GL_OP_CROSS_PRODUCT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_CROSS_PRODUCT_EXT = 0x8797;

		/// <summary>
		/// Value of GL_OP_MULTIPLY_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MULTIPLY_MATRIX_EXT = 0x8798;

		/// <summary>
		/// Value of GL_OP_MOV_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OP_MOV_EXT = 0x8799;

		/// <summary>
		/// Value of GL_OUTPUT_VERTEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_VERTEX_EXT = 0x879A;

		/// <summary>
		/// Value of GL_OUTPUT_COLOR0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_COLOR0_EXT = 0x879B;

		/// <summary>
		/// Value of GL_OUTPUT_COLOR1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_COLOR1_EXT = 0x879C;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD0_EXT = 0x879D;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD1_EXT = 0x879E;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD2_EXT = 0x879F;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD6_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD7_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD9_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD10_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD11_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD13_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD14_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD15_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD17_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD18_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD19_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD20_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD21_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD22_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD23_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD24_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD25_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD26_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD27_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD28_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD29_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD30_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;

		/// <summary>
		/// Value of GL_OUTPUT_TEXTURE_COORD31_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;

		/// <summary>
		/// Value of GL_OUTPUT_FOG_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int OUTPUT_FOG_EXT = 0x87BD;

		/// <summary>
		/// Value of GL_SCALAR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int SCALAR_EXT = 0x87BE;

		/// <summary>
		/// Value of GL_VECTOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VECTOR_EXT = 0x87BF;

		/// <summary>
		/// Value of GL_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MATRIX_EXT = 0x87C0;

		/// <summary>
		/// Value of GL_VARIANT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_EXT = 0x87C1;

		/// <summary>
		/// Value of GL_INVARIANT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int INVARIANT_EXT = 0x87C2;

		/// <summary>
		/// Value of GL_LOCAL_CONSTANT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int LOCAL_CONSTANT_EXT = 0x87C3;

		/// <summary>
		/// Value of GL_LOCAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int LOCAL_EXT = 0x87C4;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_VARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_INVARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;

		/// <summary>
		/// Value of GL_MAX_VERTEX_SHADER_LOCALS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;

		/// <summary>
		/// Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;

		/// <summary>
		/// Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;

		/// <summary>
		/// Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC;

		/// <summary>
		/// Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD;

		/// <summary>
		/// Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_INSTRUCTIONS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_VARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_VARIANTS_EXT = 0x87D0;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_INVARIANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_LOCALS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_LOCALS_EXT = 0x87D3;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_OPTIMIZED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;

		/// <summary>
		/// Value of GL_X_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int X_EXT = 0x87D5;

		/// <summary>
		/// Value of GL_Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int Y_EXT = 0x87D6;

		/// <summary>
		/// Value of GL_Z_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int Z_EXT = 0x87D7;

		/// <summary>
		/// Value of GL_W_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int W_EXT = 0x87D8;

		/// <summary>
		/// Value of GL_NEGATIVE_X_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NEGATIVE_X_EXT = 0x87D9;

		/// <summary>
		/// Value of GL_NEGATIVE_Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NEGATIVE_Y_EXT = 0x87DA;

		/// <summary>
		/// Value of GL_NEGATIVE_Z_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NEGATIVE_Z_EXT = 0x87DB;

		/// <summary>
		/// Value of GL_NEGATIVE_W_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NEGATIVE_W_EXT = 0x87DC;

		/// <summary>
		/// Value of GL_ZERO_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int ZERO_EXT = 0x87DD;

		/// <summary>
		/// Value of GL_ONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int ONE_EXT = 0x87DE;

		/// <summary>
		/// Value of GL_NEGATIVE_ONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NEGATIVE_ONE_EXT = 0x87DF;

		/// <summary>
		/// Value of GL_NORMALIZED_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int NORMALIZED_RANGE_EXT = 0x87E0;

		/// <summary>
		/// Value of GL_FULL_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int FULL_RANGE_EXT = 0x87E1;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int CURRENT_VERTEX_EXT = 0x87E2;

		/// <summary>
		/// Value of GL_MVP_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int MVP_MATRIX_EXT = 0x87E3;

		/// <summary>
		/// Value of GL_VARIANT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_VALUE_EXT = 0x87E4;

		/// <summary>
		/// Value of GL_VARIANT_DATATYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_DATATYPE_EXT = 0x87E5;

		/// <summary>
		/// Value of GL_VARIANT_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_ARRAY_STRIDE_EXT = 0x87E6;

		/// <summary>
		/// Value of GL_VARIANT_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_ARRAY_TYPE_EXT = 0x87E7;

		/// <summary>
		/// Value of GL_VARIANT_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_ARRAY_EXT = 0x87E8;

		/// <summary>
		/// Value of GL_VARIANT_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int VARIANT_ARRAY_POINTER_EXT = 0x87E9;

		/// <summary>
		/// Value of GL_INVARIANT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int INVARIANT_VALUE_EXT = 0x87EA;

		/// <summary>
		/// Value of GL_INVARIANT_DATATYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int INVARIANT_DATATYPE_EXT = 0x87EB;

		/// <summary>
		/// Value of GL_LOCAL_CONSTANT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int LOCAL_CONSTANT_VALUE_EXT = 0x87EC;

		/// <summary>
		/// Value of GL_LOCAL_CONSTANT_DATATYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public const int LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;

		/// <summary>
		/// Binding for glBeginVertexShaderEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void BeginVertexShaderEXT()
		{
			Debug.Assert(Delegates.pglBeginVertexShaderEXT != null, "pglBeginVertexShaderEXT not implemented");
			Delegates.pglBeginVertexShaderEXT();
			LogFunction("glBeginVertexShaderEXT()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndVertexShaderEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void EndVertexShaderEXT()
		{
			Debug.Assert(Delegates.pglEndVertexShaderEXT != null, "pglEndVertexShaderEXT not implemented");
			Delegates.pglEndVertexShaderEXT();
			LogFunction("glEndVertexShaderEXT()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindVertexShaderEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void BindVertexShaderEXT(UInt32 id)
		{
			Debug.Assert(Delegates.pglBindVertexShaderEXT != null, "pglBindVertexShaderEXT not implemented");
			Delegates.pglBindVertexShaderEXT(id);
			LogFunction("glBindVertexShaderEXT({0})", id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenVertexShadersEXT.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 GenVertexShadersEXT(UInt32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenVertexShadersEXT != null, "pglGenVertexShadersEXT not implemented");
			retValue = Delegates.pglGenVertexShadersEXT(range);
			LogFunction("glGenVertexShadersEXT({0}) = {1}", range, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glDeleteVertexShaderEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void DeleteVertexShaderEXT(UInt32 id)
		{
			Debug.Assert(Delegates.pglDeleteVertexShaderEXT != null, "pglDeleteVertexShaderEXT not implemented");
			Delegates.pglDeleteVertexShaderEXT(id);
			LogFunction("glDeleteVertexShaderEXT({0})", id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glShaderOp1EXT.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void ShaderOp1EXT(Int32 op, UInt32 res, UInt32 arg1)
		{
			Debug.Assert(Delegates.pglShaderOp1EXT != null, "pglShaderOp1EXT not implemented");
			Delegates.pglShaderOp1EXT(op, res, arg1);
			LogFunction("glShaderOp1EXT({0}, {1}, {2})", LogEnumName(op), res, arg1);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glShaderOp2EXT.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void ShaderOp2EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2)
		{
			Debug.Assert(Delegates.pglShaderOp2EXT != null, "pglShaderOp2EXT not implemented");
			Delegates.pglShaderOp2EXT(op, res, arg1, arg2);
			LogFunction("glShaderOp2EXT({0}, {1}, {2}, {3})", LogEnumName(op), res, arg1, arg2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glShaderOp3EXT.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void ShaderOp3EXT(Int32 op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3)
		{
			Debug.Assert(Delegates.pglShaderOp3EXT != null, "pglShaderOp3EXT not implemented");
			Delegates.pglShaderOp3EXT(op, res, arg1, arg2, arg3);
			LogFunction("glShaderOp3EXT({0}, {1}, {2}, {3}, {4})", LogEnumName(op), res, arg1, arg2, arg3);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSwizzleEXT.
		/// </summary>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="in">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="outX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outW">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void SwizzleEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW)
		{
			Debug.Assert(Delegates.pglSwizzleEXT != null, "pglSwizzleEXT not implemented");
			Delegates.pglSwizzleEXT(res, @in, outX, outY, outZ, outW);
			LogFunction("glSwizzleEXT({0}, {1}, {2}, {3}, {4}, {5})", res, @in, LogEnumName(outX), LogEnumName(outY), LogEnumName(outZ), LogEnumName(outW));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWriteMaskEXT.
		/// </summary>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="in">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="outX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="outW">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void WriteMaskEXT(UInt32 res, UInt32 @in, Int32 outX, Int32 outY, Int32 outZ, Int32 outW)
		{
			Debug.Assert(Delegates.pglWriteMaskEXT != null, "pglWriteMaskEXT not implemented");
			Delegates.pglWriteMaskEXT(res, @in, outX, outY, outZ, outW);
			LogFunction("glWriteMaskEXT({0}, {1}, {2}, {3}, {4}, {5})", res, @in, LogEnumName(outX), LogEnumName(outY), LogEnumName(outZ), LogEnumName(outW));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glInsertComponentEXT.
		/// </summary>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="num">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num)
		{
			Debug.Assert(Delegates.pglInsertComponentEXT != null, "pglInsertComponentEXT not implemented");
			Delegates.pglInsertComponentEXT(res, src, num);
			LogFunction("glInsertComponentEXT({0}, {1}, {2})", res, src, num);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtractComponentEXT.
		/// </summary>
		/// <param name="res">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="num">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num)
		{
			Debug.Assert(Delegates.pglExtractComponentEXT != null, "pglExtractComponentEXT not implemented");
			Delegates.pglExtractComponentEXT(res, src, num);
			LogFunction("glExtractComponentEXT({0}, {1}, {2})", res, src, num);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenSymbolsEXT.
		/// </summary>
		/// <param name="datatype">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="storagetype">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="components">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 GenSymbolsEXT(Int32 datatype, Int32 storagetype, Int32 range, UInt32 components)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenSymbolsEXT != null, "pglGenSymbolsEXT not implemented");
			retValue = Delegates.pglGenSymbolsEXT(datatype, storagetype, range, components);
			LogFunction("glGenSymbolsEXT({0}, {1}, {2}, {3}) = {4}", LogEnumName(datatype), LogEnumName(storagetype), LogEnumName(range), components, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glSetInvariantEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void SetInvariantEXT(UInt32 id, Int32 type, IntPtr addr)
		{
			Debug.Assert(Delegates.pglSetInvariantEXT != null, "pglSetInvariantEXT not implemented");
			Delegates.pglSetInvariantEXT(id, type, addr);
			LogFunction("glSetInvariantEXT({0}, {1}, 0x{2})", id, LogEnumName(type), addr.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetInvariantEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void SetInvariantEXT(UInt32 id, Int32 type, Object addr)
		{
			GCHandle pin_addr = GCHandle.Alloc(addr, GCHandleType.Pinned);
			try {
				SetInvariantEXT(id, type, pin_addr.AddrOfPinnedObject());
			} finally {
				pin_addr.Free();
			}
		}

		/// <summary>
		/// Binding for glSetLocalConstantEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void SetLocalConstantEXT(UInt32 id, Int32 type, IntPtr addr)
		{
			Debug.Assert(Delegates.pglSetLocalConstantEXT != null, "pglSetLocalConstantEXT not implemented");
			Delegates.pglSetLocalConstantEXT(id, type, addr);
			LogFunction("glSetLocalConstantEXT({0}, {1}, 0x{2})", id, LogEnumName(type), addr.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetLocalConstantEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void SetLocalConstantEXT(UInt32 id, Int32 type, Object addr)
		{
			GCHandle pin_addr = GCHandle.Alloc(addr, GCHandleType.Pinned);
			try {
				SetLocalConstantEXT(id, type, pin_addr.AddrOfPinnedObject());
			} finally {
				pin_addr.Free();
			}
		}

		/// <summary>
		/// Binding for glVariantbvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, sbyte[] addr)
		{
			unsafe {
				fixed (sbyte* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantbvEXT != null, "pglVariantbvEXT not implemented");
					Delegates.pglVariantbvEXT(id, p_addr);
					LogFunction("glVariantbvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantsvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, Int16[] addr)
		{
			unsafe {
				fixed (Int16* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantsvEXT != null, "pglVariantsvEXT not implemented");
					Delegates.pglVariantsvEXT(id, p_addr);
					LogFunction("glVariantsvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, Int32[] addr)
		{
			unsafe {
				fixed (Int32* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantivEXT != null, "pglVariantivEXT not implemented");
					Delegates.pglVariantivEXT(id, p_addr);
					LogFunction("glVariantivEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantfvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, float[] addr)
		{
			unsafe {
				fixed (float* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantfvEXT != null, "pglVariantfvEXT not implemented");
					Delegates.pglVariantfvEXT(id, p_addr);
					LogFunction("glVariantfvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantdvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, double[] addr)
		{
			unsafe {
				fixed (double* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantdvEXT != null, "pglVariantdvEXT not implemented");
					Delegates.pglVariantdvEXT(id, p_addr);
					LogFunction("glVariantdvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantubvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, byte[] addr)
		{
			unsafe {
				fixed (byte* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantubvEXT != null, "pglVariantubvEXT not implemented");
					Delegates.pglVariantubvEXT(id, p_addr);
					LogFunction("glVariantubvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantusvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, UInt16[] addr)
		{
			unsafe {
				fixed (UInt16* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantusvEXT != null, "pglVariantusvEXT not implemented");
					Delegates.pglVariantusvEXT(id, p_addr);
					LogFunction("glVariantusvEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantEXT(UInt32 id, UInt32[] addr)
		{
			unsafe {
				fixed (UInt32* p_addr = addr)
				{
					Debug.Assert(Delegates.pglVariantuivEXT != null, "pglVariantuivEXT not implemented");
					Delegates.pglVariantuivEXT(id, p_addr);
					LogFunction("glVariantuivEXT({0}, {1})", id, LogValue(addr));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantPointerEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantPointerEXT(UInt32 id, Int32 type, UInt32 stride, IntPtr addr)
		{
			Debug.Assert(Delegates.pglVariantPointerEXT != null, "pglVariantPointerEXT not implemented");
			Delegates.pglVariantPointerEXT(id, type, stride, addr);
			LogFunction("glVariantPointerEXT({0}, {1}, {2}, 0x{3})", id, LogEnumName(type), stride, addr.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantPointerEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="addr">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void VariantPointerEXT(UInt32 id, Int32 type, UInt32 stride, Object addr)
		{
			GCHandle pin_addr = GCHandle.Alloc(addr, GCHandleType.Pinned);
			try {
				VariantPointerEXT(id, type, stride, pin_addr.AddrOfPinnedObject());
			} finally {
				pin_addr.Free();
			}
		}

		/// <summary>
		/// Binding for glEnableVariantClientStateEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void EnableVariantClientStateEXT(UInt32 id)
		{
			Debug.Assert(Delegates.pglEnableVariantClientStateEXT != null, "pglEnableVariantClientStateEXT not implemented");
			Delegates.pglEnableVariantClientStateEXT(id);
			LogFunction("glEnableVariantClientStateEXT({0})", id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableVariantClientStateEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void DisableVariantClientStateEXT(UInt32 id)
		{
			Debug.Assert(Delegates.pglDisableVariantClientStateEXT != null, "pglDisableVariantClientStateEXT not implemented");
			Delegates.pglDisableVariantClientStateEXT(id);
			LogFunction("glDisableVariantClientStateEXT({0})", id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindLightParameterEXT.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:LightName"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:LightParameter"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 BindLightParameterEXT(LightName light, LightParameter value)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglBindLightParameterEXT != null, "pglBindLightParameterEXT not implemented");
			retValue = Delegates.pglBindLightParameterEXT((Int32)light, (Int32)value);
			LogFunction("glBindLightParameterEXT({0}, {1}) = {2}", light, value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindMaterialParameterEXT.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 BindMaterialParameterEXT(MaterialFace face, MaterialParameter value)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglBindMaterialParameterEXT != null, "pglBindMaterialParameterEXT not implemented");
			retValue = Delegates.pglBindMaterialParameterEXT((Int32)face, (Int32)value);
			LogFunction("glBindMaterialParameterEXT({0}, {1}) = {2}", face, value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindTexGenParameterEXT.
		/// </summary>
		/// <param name="unit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 BindTexGenParameterEXT(Int32 unit, TextureCoordName coord, TextureGenParameter value)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglBindTexGenParameterEXT != null, "pglBindTexGenParameterEXT not implemented");
			retValue = Delegates.pglBindTexGenParameterEXT(unit, (Int32)coord, (Int32)value);
			LogFunction("glBindTexGenParameterEXT({0}, {1}, {2}) = {3}", LogEnumName(unit), coord, value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindTextureUnitParameterEXT.
		/// </summary>
		/// <param name="unit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 BindTextureUnitParameterEXT(Int32 unit, Int32 value)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglBindTextureUnitParameterEXT != null, "pglBindTextureUnitParameterEXT not implemented");
			retValue = Delegates.pglBindTextureUnitParameterEXT(unit, value);
			LogFunction("glBindTextureUnitParameterEXT({0}, {1}) = {2}", LogEnumName(unit), LogEnumName(value), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindParameterEXT.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static UInt32 BindParameterEXT(Int32 value)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglBindParameterEXT != null, "pglBindParameterEXT not implemented");
			retValue = Delegates.pglBindParameterEXT(value);
			LogFunction("glBindParameterEXT({0}) = {1}", LogEnumName(value), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsVariantEnabledEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="cap">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static bool IsVariantEnabledEXT(UInt32 id, Int32 cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVariantEnabledEXT != null, "pglIsVariantEnabledEXT not implemented");
			retValue = Delegates.pglIsVariantEnabledEXT(id, cap);
			LogFunction("glIsVariantEnabledEXT({0}, {1}) = {2}", id, LogEnumName(cap), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetVariantBooleanvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetVariantBooleanEXT(UInt32 id, Int32 value, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetVariantBooleanvEXT != null, "pglGetVariantBooleanvEXT not implemented");
					Delegates.pglGetVariantBooleanvEXT(id, value, p_data);
					LogFunction("glGetVariantBooleanvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVariantIntegervEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetVariantIntegerEXT(UInt32 id, Int32 value, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetVariantIntegervEXT != null, "pglGetVariantIntegervEXT not implemented");
					Delegates.pglGetVariantIntegervEXT(id, value, p_data);
					LogFunction("glGetVariantIntegervEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVariantFloatvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetVariantFloatEXT(UInt32 id, Int32 value, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetVariantFloatvEXT != null, "pglGetVariantFloatvEXT not implemented");
					Delegates.pglGetVariantFloatvEXT(id, value, p_data);
					LogFunction("glGetVariantFloatvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVariantPointervEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetVariantPointerEXT(UInt32 id, Int32 value, [Out] IntPtr[] data)
		{
			unsafe {
				fixed (IntPtr* p_data = data)
				{
					Debug.Assert(Delegates.pglGetVariantPointervEXT != null, "pglGetVariantPointervEXT not implemented");
					Delegates.pglGetVariantPointervEXT(id, value, p_data);
					LogFunction("glGetVariantPointervEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetInvariantBooleanvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetInvariantBooleanEXT(UInt32 id, Int32 value, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInvariantBooleanvEXT != null, "pglGetInvariantBooleanvEXT not implemented");
					Delegates.pglGetInvariantBooleanvEXT(id, value, p_data);
					LogFunction("glGetInvariantBooleanvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetInvariantIntegervEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetInvariantIntegerEXT(UInt32 id, Int32 value, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInvariantIntegervEXT != null, "pglGetInvariantIntegervEXT not implemented");
					Delegates.pglGetInvariantIntegervEXT(id, value, p_data);
					LogFunction("glGetInvariantIntegervEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetInvariantFloatvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetInvariantFloatEXT(UInt32 id, Int32 value, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetInvariantFloatvEXT != null, "pglGetInvariantFloatvEXT not implemented");
					Delegates.pglGetInvariantFloatvEXT(id, value, p_data);
					LogFunction("glGetInvariantFloatvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLocalConstantBooleanvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetLocalConstantBooleanEXT(UInt32 id, Int32 value, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetLocalConstantBooleanvEXT != null, "pglGetLocalConstantBooleanvEXT not implemented");
					Delegates.pglGetLocalConstantBooleanvEXT(id, value, p_data);
					LogFunction("glGetLocalConstantBooleanvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLocalConstantIntegervEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetLocalConstantIntegerEXT(UInt32 id, Int32 value, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetLocalConstantIntegervEXT != null, "pglGetLocalConstantIntegervEXT not implemented");
					Delegates.pglGetLocalConstantIntegervEXT(id, value, p_data);
					LogFunction("glGetLocalConstantIntegervEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLocalConstantFloatvEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_shader")]
		public static void GetLocalConstantFloatEXT(UInt32 id, Int32 value, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetLocalConstantFloatvEXT != null, "pglGetLocalConstantFloatvEXT not implemented");
					Delegates.pglGetLocalConstantFloatvEXT(id, value, p_data);
					LogFunction("glGetLocalConstantFloatvEXT({0}, {1}, {2})", id, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
