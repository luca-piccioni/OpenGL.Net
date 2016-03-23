
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
		/// Value of GL_REGISTER_COMBINERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int REGISTER_COMBINERS_NV = 0x8522;

		/// <summary>
		/// Value of GL_VARIABLE_A_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_A_NV = 0x8523;

		/// <summary>
		/// Value of GL_VARIABLE_B_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_B_NV = 0x8524;

		/// <summary>
		/// Value of GL_VARIABLE_C_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_C_NV = 0x8525;

		/// <summary>
		/// Value of GL_VARIABLE_D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_D_NV = 0x8526;

		/// <summary>
		/// Value of GL_VARIABLE_E_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_E_NV = 0x8527;

		/// <summary>
		/// Value of GL_VARIABLE_F_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_F_NV = 0x8528;

		/// <summary>
		/// Value of GL_VARIABLE_G_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int VARIABLE_G_NV = 0x8529;

		/// <summary>
		/// Value of GL_CONSTANT_COLOR0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int CONSTANT_COLOR0_NV = 0x852A;

		/// <summary>
		/// Value of GL_CONSTANT_COLOR1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int CONSTANT_COLOR1_NV = 0x852B;

		/// <summary>
		/// Value of GL_PRIMARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int PRIMARY_COLOR_NV = 0x852C;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SECONDARY_COLOR_NV = 0x852D;

		/// <summary>
		/// Value of GL_SPARE0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SPARE0_NV = 0x852E;

		/// <summary>
		/// Value of GL_SPARE1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SPARE1_NV = 0x852F;

		/// <summary>
		/// Value of GL_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int DISCARD_NV = 0x8530;

		/// <summary>
		/// Value of GL_E_TIMES_F_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int E_TIMES_F_NV = 0x8531;

		/// <summary>
		/// Value of GL_SPARE0_PLUS_SECONDARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;

		/// <summary>
		/// Value of GL_UNSIGNED_IDENTITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int UNSIGNED_IDENTITY_NV = 0x8536;

		/// <summary>
		/// Value of GL_UNSIGNED_INVERT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int UNSIGNED_INVERT_NV = 0x8537;

		/// <summary>
		/// Value of GL_EXPAND_NORMAL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int EXPAND_NORMAL_NV = 0x8538;

		/// <summary>
		/// Value of GL_EXPAND_NEGATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int EXPAND_NEGATE_NV = 0x8539;

		/// <summary>
		/// Value of GL_HALF_BIAS_NORMAL_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int HALF_BIAS_NORMAL_NV = 0x853A;

		/// <summary>
		/// Value of GL_HALF_BIAS_NEGATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int HALF_BIAS_NEGATE_NV = 0x853B;

		/// <summary>
		/// Value of GL_SIGNED_IDENTITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SIGNED_IDENTITY_NV = 0x853C;

		/// <summary>
		/// Value of GL_SIGNED_NEGATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SIGNED_NEGATE_NV = 0x853D;

		/// <summary>
		/// Value of GL_SCALE_BY_TWO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SCALE_BY_TWO_NV = 0x853E;

		/// <summary>
		/// Value of GL_SCALE_BY_FOUR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SCALE_BY_FOUR_NV = 0x853F;

		/// <summary>
		/// Value of GL_SCALE_BY_ONE_HALF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int SCALE_BY_ONE_HALF_NV = 0x8540;

		/// <summary>
		/// Value of GL_BIAS_BY_NEGATIVE_ONE_HALF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;

		/// <summary>
		/// Value of GL_COMBINER_INPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_INPUT_NV = 0x8542;

		/// <summary>
		/// Value of GL_COMBINER_MAPPING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_MAPPING_NV = 0x8543;

		/// <summary>
		/// Value of GL_COMBINER_COMPONENT_USAGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_COMPONENT_USAGE_NV = 0x8544;

		/// <summary>
		/// Value of GL_COMBINER_AB_DOT_PRODUCT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_AB_DOT_PRODUCT_NV = 0x8545;

		/// <summary>
		/// Value of GL_COMBINER_CD_DOT_PRODUCT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_CD_DOT_PRODUCT_NV = 0x8546;

		/// <summary>
		/// Value of GL_COMBINER_MUX_SUM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_MUX_SUM_NV = 0x8547;

		/// <summary>
		/// Value of GL_COMBINER_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_SCALE_NV = 0x8548;

		/// <summary>
		/// Value of GL_COMBINER_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_BIAS_NV = 0x8549;

		/// <summary>
		/// Value of GL_COMBINER_AB_OUTPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_AB_OUTPUT_NV = 0x854A;

		/// <summary>
		/// Value of GL_COMBINER_CD_OUTPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_CD_OUTPUT_NV = 0x854B;

		/// <summary>
		/// Value of GL_COMBINER_SUM_OUTPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER_SUM_OUTPUT_NV = 0x854C;

		/// <summary>
		/// Value of GL_MAX_GENERAL_COMBINERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int MAX_GENERAL_COMBINERS_NV = 0x854D;

		/// <summary>
		/// Value of GL_NUM_GENERAL_COMBINERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int NUM_GENERAL_COMBINERS_NV = 0x854E;

		/// <summary>
		/// Value of GL_COLOR_SUM_CLAMP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COLOR_SUM_CLAMP_NV = 0x854F;

		/// <summary>
		/// Value of GL_COMBINER0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER0_NV = 0x8550;

		/// <summary>
		/// Value of GL_COMBINER1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER1_NV = 0x8551;

		/// <summary>
		/// Value of GL_COMBINER2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER2_NV = 0x8552;

		/// <summary>
		/// Value of GL_COMBINER3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER3_NV = 0x8553;

		/// <summary>
		/// Value of GL_COMBINER4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER4_NV = 0x8554;

		/// <summary>
		/// Value of GL_COMBINER5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER5_NV = 0x8555;

		/// <summary>
		/// Value of GL_COMBINER6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER6_NV = 0x8556;

		/// <summary>
		/// Value of GL_COMBINER7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int COMBINER7_NV = 0x8557;

		/// <summary>
		/// Binding for glCombinerParameterfvNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerParameterNV(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglCombinerParameterfvNV != null, "pglCombinerParameterfvNV not implemented");
					Delegates.pglCombinerParameterfvNV(pname, p_params);
					LogFunction("glCombinerParameterfvNV({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCombinerParameterfNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerParameterNV(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglCombinerParameterfNV != null, "pglCombinerParameterfNV not implemented");
			Delegates.pglCombinerParameterfNV(pname, param);
			LogFunction("glCombinerParameterfNV({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCombinerParameterivNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerParameterNV(Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglCombinerParameterivNV != null, "pglCombinerParameterivNV not implemented");
					Delegates.pglCombinerParameterivNV(pname, p_params);
					LogFunction("glCombinerParameterivNV({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCombinerParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerParameterNV(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglCombinerParameteriNV != null, "pglCombinerParameteriNV not implemented");
			Delegates.pglCombinerParameteriNV(pname, param);
			LogFunction("glCombinerParameteriNV({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCombinerInputNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="input">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mapping">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="componentUsage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerInputNV(Int32 stage, Int32 portion, Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage)
		{
			Debug.Assert(Delegates.pglCombinerInputNV != null, "pglCombinerInputNV not implemented");
			Delegates.pglCombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
			LogFunction("glCombinerInputNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(stage), LogEnumName(portion), LogEnumName(variable), LogEnumName(input), LogEnumName(mapping), LogEnumName(componentUsage));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCombinerOutputNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="abOutput">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="cdOutput">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sumOutput">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="scale">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bias">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="abDotProduct">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="cdDotProduct">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="muxSum">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void CombinerOutputNV(Int32 stage, Int32 portion, Int32 abOutput, Int32 cdOutput, Int32 sumOutput, Int32 scale, Int32 bias, bool abDotProduct, bool cdDotProduct, bool muxSum)
		{
			Debug.Assert(Delegates.pglCombinerOutputNV != null, "pglCombinerOutputNV not implemented");
			Delegates.pglCombinerOutputNV(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
			LogFunction("glCombinerOutputNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", LogEnumName(stage), LogEnumName(portion), LogEnumName(abOutput), LogEnumName(cdOutput), LogEnumName(sumOutput), LogEnumName(scale), LogEnumName(bias), abDotProduct, cdDotProduct, muxSum);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFinalCombinerInputNV.
		/// </summary>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="input">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mapping">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="componentUsage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void FinalCombinerInputNV(Int32 variable, Int32 input, Int32 mapping, Int32 componentUsage)
		{
			Debug.Assert(Delegates.pglFinalCombinerInputNV != null, "pglFinalCombinerInputNV not implemented");
			Delegates.pglFinalCombinerInputNV(variable, input, mapping, componentUsage);
			LogFunction("glFinalCombinerInputNV({0}, {1}, {2}, {3})", LogEnumName(variable), LogEnumName(input), LogEnumName(mapping), LogEnumName(componentUsage));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCombinerInputParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetCombinerInputParameterNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerInputParameterfvNV != null, "pglGetCombinerInputParameterfvNV not implemented");
					Delegates.pglGetCombinerInputParameterfvNV(stage, portion, variable, pname, p_params);
					LogFunction("glGetCombinerInputParameterfvNV({0}, {1}, {2}, {3}, {4})", LogEnumName(stage), LogEnumName(portion), LogEnumName(variable), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCombinerInputParameterivNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetCombinerInputParameterNV(Int32 stage, Int32 portion, Int32 variable, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerInputParameterivNV != null, "pglGetCombinerInputParameterivNV not implemented");
					Delegates.pglGetCombinerInputParameterivNV(stage, portion, variable, pname, p_params);
					LogFunction("glGetCombinerInputParameterivNV({0}, {1}, {2}, {3}, {4})", LogEnumName(stage), LogEnumName(portion), LogEnumName(variable), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCombinerOutputParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetCombinerOutputParameterNV(Int32 stage, Int32 portion, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerOutputParameterfvNV != null, "pglGetCombinerOutputParameterfvNV not implemented");
					Delegates.pglGetCombinerOutputParameterfvNV(stage, portion, pname, p_params);
					LogFunction("glGetCombinerOutputParameterfvNV({0}, {1}, {2}, {3})", LogEnumName(stage), LogEnumName(portion), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCombinerOutputParameterivNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="portion">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetCombinerOutputParameterNV(Int32 stage, Int32 portion, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerOutputParameterivNV != null, "pglGetCombinerOutputParameterivNV not implemented");
					Delegates.pglGetCombinerOutputParameterivNV(stage, portion, pname, p_params);
					LogFunction("glGetCombinerOutputParameterivNV({0}, {1}, {2}, {3})", LogEnumName(stage), LogEnumName(portion), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFinalCombinerInputParameterfvNV.
		/// </summary>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetFinalCombinerInputParameterNV(Int32 variable, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFinalCombinerInputParameterfvNV != null, "pglGetFinalCombinerInputParameterfvNV not implemented");
					Delegates.pglGetFinalCombinerInputParameterfvNV(variable, pname, p_params);
					LogFunction("glGetFinalCombinerInputParameterfvNV({0}, {1}, {2})", LogEnumName(variable), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFinalCombinerInputParameterivNV.
		/// </summary>
		/// <param name="variable">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners")]
		public static void GetFinalCombinerInputParameterNV(Int32 variable, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFinalCombinerInputParameterivNV != null, "pglGetFinalCombinerInputParameterivNV not implemented");
					Delegates.pglGetFinalCombinerInputParameterivNV(variable, pname, p_params);
					LogFunction("glGetFinalCombinerInputParameterivNV({0}, {1}, {2})", LogEnumName(variable), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
