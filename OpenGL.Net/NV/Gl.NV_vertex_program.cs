
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
		/// Value of GL_VERTEX_STATE_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_STATE_PROGRAM_NV = 0x8621;

		/// <summary>
		/// Value of GL_ATTRIB_ARRAY_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_SIZE_NV = 0x8623;

		/// <summary>
		/// Value of GL_ATTRIB_ARRAY_STRIDE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_STRIDE_NV = 0x8624;

		/// <summary>
		/// Value of GL_ATTRIB_ARRAY_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_TYPE_NV = 0x8625;

		/// <summary>
		/// Value of GL_CURRENT_ATTRIB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int CURRENT_ATTRIB_NV = 0x8626;

		/// <summary>
		/// Value of GL_MODELVIEW_PROJECTION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MODELVIEW_PROJECTION_NV = 0x8629;

		/// <summary>
		/// Value of GL_IDENTITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int IDENTITY_NV = 0x862A;

		/// <summary>
		/// Value of GL_INVERSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int INVERSE_NV = 0x862B;

		/// <summary>
		/// Value of GL_TRANSPOSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRANSPOSE_NV = 0x862C;

		/// <summary>
		/// Value of GL_INVERSE_TRANSPOSE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int INVERSE_TRANSPOSE_NV = 0x862D;

		/// <summary>
		/// Value of GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;

		/// <summary>
		/// Value of GL_MAX_TRACK_MATRICES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAX_TRACK_MATRICES_NV = 0x862F;

		/// <summary>
		/// Value of GL_MATRIX0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX0_NV = 0x8630;

		/// <summary>
		/// Value of GL_MATRIX1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX1_NV = 0x8631;

		/// <summary>
		/// Value of GL_MATRIX2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX2_NV = 0x8632;

		/// <summary>
		/// Value of GL_MATRIX3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX3_NV = 0x8633;

		/// <summary>
		/// Value of GL_MATRIX4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX4_NV = 0x8634;

		/// <summary>
		/// Value of GL_MATRIX5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX5_NV = 0x8635;

		/// <summary>
		/// Value of GL_MATRIX6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX6_NV = 0x8636;

		/// <summary>
		/// Value of GL_MATRIX7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MATRIX7_NV = 0x8637;

		/// <summary>
		/// Value of GL_PROGRAM_PARAMETER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_PARAMETER_NV = 0x8644;

		/// <summary>
		/// Value of GL_ATTRIB_ARRAY_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int ATTRIB_ARRAY_POINTER_NV = 0x8645;

		/// <summary>
		/// Value of GL_PROGRAM_TARGET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_TARGET_NV = 0x8646;

		/// <summary>
		/// Value of GL_PROGRAM_RESIDENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_RESIDENT_NV = 0x8647;

		/// <summary>
		/// Value of GL_TRACK_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRACK_MATRIX_NV = 0x8648;

		/// <summary>
		/// Value of GL_TRACK_MATRIX_TRANSFORM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int TRACK_MATRIX_TRANSFORM_NV = 0x8649;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_PROGRAM_BINDING_NV = 0x864A;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY0_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY0_NV = 0x8650;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY1_NV = 0x8651;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY2_NV = 0x8652;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY3_NV = 0x8653;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY4_NV = 0x8654;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY5_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY5_NV = 0x8655;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY6_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY6_NV = 0x8656;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY7_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY7_NV = 0x8657;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY8_NV = 0x8658;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY9_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY9_NV = 0x8659;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY10_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY10_NV = 0x865A;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY11_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY11_NV = 0x865B;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY12_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY12_NV = 0x865C;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY13_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY13_NV = 0x865D;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY14_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY14_NV = 0x865E;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY15_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_ATTRIB_ARRAY15_NV = 0x865F;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB0_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB1_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB2_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB3_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB4_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB5_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB6_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB7_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB8_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB9_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB10_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB11_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB12_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB13_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB14_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;

		/// <summary>
		/// Value of GL_MAP1_VERTEX_ATTRIB15_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB0_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB1_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB2_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB3_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB4_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB5_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB6_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB7_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB8_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB9_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB10_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB11_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB12_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB13_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB14_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;

		/// <summary>
		/// Value of GL_MAP2_VERTEX_ATTRIB15_4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;

		/// <summary>
		/// Binding for glAreProgramsResidentNV.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static bool AreProgramsResidentNV(UInt32[] programs, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreProgramsResidentNV != null, "pglAreProgramsResidentNV not implemented");
					retValue = Delegates.pglAreProgramsResidentNV((Int32)programs.Length, p_programs, p_residences);
					LogFunction("glAreProgramsResidentNV({0}, {1}, {2}) = {3}", programs.Length, LogValue(programs), LogValue(residences), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glExecuteProgramNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ExecuteProgramNV(Int32 target, UInt32 id, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglExecuteProgramNV != null, "pglExecuteProgramNV not implemented");
					Delegates.pglExecuteProgramNV(target, id, p_params);
					LogFunction("glExecuteProgramNV({0}, {1}, {2})", LogEnumName(target), id, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramParameterdvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramParameterdvNV != null, "pglGetProgramParameterdvNV not implemented");
					Delegates.pglGetProgramParameterdvNV(target, index, pname, p_params);
					LogFunction("glGetProgramParameterdvNV({0}, {1}, {2}, {3})", LogEnumName(target), index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramParameterfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramParameterNV(Int32 target, UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramParameterfvNV != null, "pglGetProgramParameterfvNV not implemented");
					Delegates.pglGetProgramParameterfvNV(target, index, pname, p_params);
					LogFunction("glGetProgramParameterfvNV({0}, {1}, {2}, {3})", LogEnumName(target), index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramNV(UInt32 id, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramivNV != null, "pglGetProgramivNV not implemented");
					Delegates.pglGetProgramivNV(id, pname, p_params);
					LogFunction("glGetProgramivNV({0}, {1}, {2})", id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramStringNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetProgramStringNV(UInt32 id, Int32 pname, [Out] byte[] program)
		{
			unsafe {
				fixed (byte* p_program = program)
				{
					Debug.Assert(Delegates.pglGetProgramStringNV != null, "pglGetProgramStringNV not implemented");
					Delegates.pglGetProgramStringNV(id, pname, p_program);
					LogFunction("glGetProgramStringNV({0}, {1}, {2})", id, LogEnumName(pname), LogValue(program));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTrackMatrixivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="address">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetTrackMatrixNV(Int32 target, UInt32 address, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTrackMatrixivNV != null, "pglGetTrackMatrixivNV not implemented");
					Delegates.pglGetTrackMatrixivNV(target, address, pname, p_params);
					LogFunction("glGetTrackMatrixivNV({0}, {1}, {2}, {3})", LogEnumName(target), address, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadProgramNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void LoadProgramNV(Int32 target, UInt32 id, byte[] program)
		{
			unsafe {
				fixed (byte* p_program = program)
				{
					Debug.Assert(Delegates.pglLoadProgramNV != null, "pglLoadProgramNV not implemented");
					Delegates.pglLoadProgramNV(target, id, (Int32)program.Length, p_program);
					LogFunction("glLoadProgramNV({0}, {1}, {2}, {3})", LogEnumName(target), id, program.Length, LogValue(program));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4dNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramParameter4dNV != null, "pglProgramParameter4dNV not implemented");
			Delegates.pglProgramParameter4dNV(target, index, x, y, z, w);
			LogFunction("glProgramParameter4dNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4dvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameter4dvNV != null, "pglProgramParameter4dvNV not implemented");
					Delegates.pglProgramParameter4dvNV(target, index, p_v);
					LogFunction("glProgramParameter4dvNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4fNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramParameter4fNV != null, "pglProgramParameter4fNV not implemented");
			Delegates.pglProgramParameter4fNV(target, index, x, y, z, w);
			LogFunction("glProgramParameter4fNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameter4fvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameter4NV(Int32 target, UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameter4fvNV != null, "pglProgramParameter4fvNV not implemented");
					Delegates.pglProgramParameter4fvNV(target, index, p_v);
					LogFunction("glProgramParameter4fvNV({0}, {1}, {2})", LogEnumName(target), index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameters4dvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameters4NV(Int32 target, UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameters4dvNV != null, "pglProgramParameters4dvNV not implemented");
					Delegates.pglProgramParameters4dvNV(target, index, count, p_v);
					LogFunction("glProgramParameters4dvNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramParameters4fvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void ProgramParameters4NV(Int32 target, UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglProgramParameters4fvNV != null, "pglProgramParameters4fvNV not implemented");
					Delegates.pglProgramParameters4fvNV(target, index, count, p_v);
					LogFunction("glProgramParameters4fvNV({0}, {1}, {2}, {3})", LogEnumName(target), index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRequestResidentProgramsNV.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void RequestResidentProgramsNV(UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					Debug.Assert(Delegates.pglRequestResidentProgramsNV != null, "pglRequestResidentProgramsNV not implemented");
					Delegates.pglRequestResidentProgramsNV((Int32)programs.Length, p_programs);
					LogFunction("glRequestResidentProgramsNV({0}, {1})", programs.Length, LogValue(programs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTrackMatrixNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="address">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="matrix">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transform">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void TrackMatrixNV(Int32 target, UInt32 address, Int32 matrix, Int32 transform)
		{
			Debug.Assert(Delegates.pglTrackMatrixNV != null, "pglTrackMatrixNV not implemented");
			Delegates.pglTrackMatrixNV(target, address, matrix, transform);
			LogFunction("glTrackMatrixNV({0}, {1}, {2}, {3})", LogEnumName(target), address, LogEnumName(matrix), LogEnumName(transform));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribPointerNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribPointerNV != null, "pglVertexAttribPointerNV not implemented");
			Delegates.pglVertexAttribPointerNV(index, fsize, type, stride, pointer);
			LogFunction("glVertexAttribPointerNV({0}, {1}, {2}, {3}, 0x{4})", index, fsize, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribPointerNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribPointerNV(UInt32 index, Int32 fsize, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribPointerNV(index, fsize, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexAttribs1dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1dvNV != null, "pglVertexAttribs1dvNV not implemented");
					Delegates.pglVertexAttribs1dvNV(index, (Int32)v.Length, p_v);
					LogFunction("glVertexAttribs1dvNV({0}, {1}, {2})", index, v.Length, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs1fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1fvNV != null, "pglVertexAttribs1fvNV not implemented");
					Delegates.pglVertexAttribs1fvNV(index, (Int32)v.Length, p_v);
					LogFunction("glVertexAttribs1fvNV({0}, {1}, {2})", index, v.Length, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs1svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs1NV(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1svNV != null, "pglVertexAttribs1svNV not implemented");
					Delegates.pglVertexAttribs1svNV(index, (Int32)v.Length, p_v);
					LogFunction("glVertexAttribs1svNV({0}, {1}, {2})", index, v.Length, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2dvNV != null, "pglVertexAttribs2dvNV not implemented");
					Delegates.pglVertexAttribs2dvNV(index, count, p_v);
					LogFunction("glVertexAttribs2dvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2fvNV != null, "pglVertexAttribs2fvNV not implemented");
					Delegates.pglVertexAttribs2fvNV(index, count, p_v);
					LogFunction("glVertexAttribs2fvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs2svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs2NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2svNV != null, "pglVertexAttribs2svNV not implemented");
					Delegates.pglVertexAttribs2svNV(index, count, p_v);
					LogFunction("glVertexAttribs2svNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3dvNV != null, "pglVertexAttribs3dvNV not implemented");
					Delegates.pglVertexAttribs3dvNV(index, count, p_v);
					LogFunction("glVertexAttribs3dvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3fvNV != null, "pglVertexAttribs3fvNV not implemented");
					Delegates.pglVertexAttribs3fvNV(index, count, p_v);
					LogFunction("glVertexAttribs3fvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs3svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs3NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3svNV != null, "pglVertexAttribs3svNV not implemented");
					Delegates.pglVertexAttribs3svNV(index, count, p_v);
					LogFunction("glVertexAttribs3svNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4dvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4dvNV != null, "pglVertexAttribs4dvNV not implemented");
					Delegates.pglVertexAttribs4dvNV(index, count, p_v);
					LogFunction("glVertexAttribs4dvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4fvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4fvNV != null, "pglVertexAttribs4fvNV not implemented");
					Delegates.pglVertexAttribs4fvNV(index, count, p_v);
					LogFunction("glVertexAttribs4fvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4svNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4svNV != null, "pglVertexAttribs4svNV not implemented");
					Delegates.pglVertexAttribs4svNV(index, count, p_v);
					LogFunction("glVertexAttribs4svNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribs4ubvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttribs4NV(UInt32 index, Int32 count, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4ubvNV != null, "pglVertexAttribs4ubvNV not implemented");
					Delegates.pglVertexAttribs4ubvNV(index, count, p_v);
					LogFunction("glVertexAttribs4ubvNV({0}, {1}, {2})", index, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
