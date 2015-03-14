
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
		/// Value of GL_COLOR_SUM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int COLOR_SUM_ARB = 0x8458;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int VERTEX_PROGRAM_ARB = 0x8620;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_ATTRIB_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int CURRENT_VERTEX_ATTRIB_ARB = 0x8626;

		/// <summary>
		/// Value of GL_PROGRAM_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_LENGTH_ARB = 0x8627;

		/// <summary>
		/// Value of GL_PROGRAM_STRING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_STRING_ARB = 0x8628;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_MATRICES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_MATRICES_ARB = 0x862F;

		/// <summary>
		/// Value of GL_CURRENT_MATRIX_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;

		/// <summary>
		/// Value of GL_CURRENT_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int CURRENT_MATRIX_ARB = 0x8641;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_POINT_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_TWO_SIDE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;

		/// <summary>
		/// Value of GL_PROGRAM_ERROR_POSITION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ERROR_POSITION_ARB = 0x864B;

		/// <summary>
		/// Value of GL_PROGRAM_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_BINDING_ARB = 0x8677;

		/// <summary>
		/// Value of GL_MAX_VERTEX_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_ATTRIBS_ARB = 0x8869;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;

		/// <summary>
		/// Value of GL_PROGRAM_ERROR_STRING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ERROR_STRING_ARB = 0x8874;

		/// <summary>
		/// Value of GL_PROGRAM_FORMAT_ASCII_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_FORMAT_ASCII_ARB = 0x8875;

		/// <summary>
		/// Value of GL_PROGRAM_FORMAT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_FORMAT_ARB = 0x8876;

		/// <summary>
		/// Value of GL_PROGRAM_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_INSTRUCTIONS_ARB = 0x88A0;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;

		/// <summary>
		/// Value of GL_PROGRAM_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_TEMPORARIES_ARB = 0x88A4;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;

		/// <summary>
		/// Value of GL_PROGRAM_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_PARAMETERS_ARB = 0x88A8;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;

		/// <summary>
		/// Value of GL_PROGRAM_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ATTRIBS_ARB = 0x88AC;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;

		/// <summary>
		/// Value of GL_PROGRAM_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;

		/// <summary>
		/// Value of GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_ENV_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;

		/// <summary>
		/// Value of GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;

		/// <summary>
		/// Value of GL_TRANSPOSE_CURRENT_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;

		/// <summary>
		/// Value of GL_MATRIX0_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX0_ARB = 0x88C0;

		/// <summary>
		/// Value of GL_MATRIX1_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX1_ARB = 0x88C1;

		/// <summary>
		/// Value of GL_MATRIX2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX2_ARB = 0x88C2;

		/// <summary>
		/// Value of GL_MATRIX3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX3_ARB = 0x88C3;

		/// <summary>
		/// Value of GL_MATRIX4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX4_ARB = 0x88C4;

		/// <summary>
		/// Value of GL_MATRIX5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX5_ARB = 0x88C5;

		/// <summary>
		/// Value of GL_MATRIX6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX6_ARB = 0x88C6;

		/// <summary>
		/// Value of GL_MATRIX7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX7_ARB = 0x88C7;

		/// <summary>
		/// Value of GL_MATRIX8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX8_ARB = 0x88C8;

		/// <summary>
		/// Value of GL_MATRIX9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX9_ARB = 0x88C9;

		/// <summary>
		/// Value of GL_MATRIX10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX10_ARB = 0x88CA;

		/// <summary>
		/// Value of GL_MATRIX11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX11_ARB = 0x88CB;

		/// <summary>
		/// Value of GL_MATRIX12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX12_ARB = 0x88CC;

		/// <summary>
		/// Value of GL_MATRIX13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX13_ARB = 0x88CD;

		/// <summary>
		/// Value of GL_MATRIX14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX14_ARB = 0x88CE;

		/// <summary>
		/// Value of GL_MATRIX15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX15_ARB = 0x88CF;

		/// <summary>
		/// Value of GL_MATRIX16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX16_ARB = 0x88D0;

		/// <summary>
		/// Value of GL_MATRIX17_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX17_ARB = 0x88D1;

		/// <summary>
		/// Value of GL_MATRIX18_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX18_ARB = 0x88D2;

		/// <summary>
		/// Value of GL_MATRIX19_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX19_ARB = 0x88D3;

		/// <summary>
		/// Value of GL_MATRIX20_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX20_ARB = 0x88D4;

		/// <summary>
		/// Value of GL_MATRIX21_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX21_ARB = 0x88D5;

		/// <summary>
		/// Value of GL_MATRIX22_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX22_ARB = 0x88D6;

		/// <summary>
		/// Value of GL_MATRIX23_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX23_ARB = 0x88D7;

		/// <summary>
		/// Value of GL_MATRIX24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX24_ARB = 0x88D8;

		/// <summary>
		/// Value of GL_MATRIX25_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX25_ARB = 0x88D9;

		/// <summary>
		/// Value of GL_MATRIX26_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX26_ARB = 0x88DA;

		/// <summary>
		/// Value of GL_MATRIX27_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX27_ARB = 0x88DB;

		/// <summary>
		/// Value of GL_MATRIX28_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX28_ARB = 0x88DC;

		/// <summary>
		/// Value of GL_MATRIX29_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX29_ARB = 0x88DD;

		/// <summary>
		/// Value of GL_MATRIX30_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX30_ARB = 0x88DE;

		/// <summary>
		/// Value of GL_MATRIX31_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX31_ARB = 0x88DF;

		/// <summary>
		/// Binding for glVertexAttrib1dARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1dARB != null, "pglVertexAttrib1dARB not implemented");
			Delegates.pglVertexAttrib1dARB(index, x);
			CallLog("glVertexAttrib1dARB({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1dvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1dvARB != null, "pglVertexAttrib1dvARB not implemented");
					Delegates.pglVertexAttrib1dvARB(index, p_v);
					CallLog("glVertexAttrib1dvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1fARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, float x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1fARB != null, "pglVertexAttrib1fARB not implemented");
			Delegates.pglVertexAttrib1fARB(index, x);
			CallLog("glVertexAttrib1fARB({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1fvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1fvARB != null, "pglVertexAttrib1fvARB not implemented");
					Delegates.pglVertexAttrib1fvARB(index, p_v);
					CallLog("glVertexAttrib1fvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1sARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, Int16 x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1sARB != null, "pglVertexAttrib1sARB not implemented");
			Delegates.pglVertexAttrib1sARB(index, x);
			CallLog("glVertexAttrib1sARB({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1svARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib1ARB(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1svARB != null, "pglVertexAttrib1svARB not implemented");
					Delegates.pglVertexAttrib1svARB(index, p_v);
					CallLog("glVertexAttrib1svARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2dARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2dARB != null, "pglVertexAttrib2dARB not implemented");
			Delegates.pglVertexAttrib2dARB(index, x, y);
			CallLog("glVertexAttrib2dARB({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2dvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2dvARB != null, "pglVertexAttrib2dvARB not implemented");
					Delegates.pglVertexAttrib2dvARB(index, p_v);
					CallLog("glVertexAttrib2dvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2fARB.
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, float x, float y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2fARB != null, "pglVertexAttrib2fARB not implemented");
			Delegates.pglVertexAttrib2fARB(index, x, y);
			CallLog("glVertexAttrib2fARB({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2fvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2fvARB != null, "pglVertexAttrib2fvARB not implemented");
					Delegates.pglVertexAttrib2fvARB(index, p_v);
					CallLog("glVertexAttrib2fvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2sARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2sARB != null, "pglVertexAttrib2sARB not implemented");
			Delegates.pglVertexAttrib2sARB(index, x, y);
			CallLog("glVertexAttrib2sARB({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2svARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib2ARB(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2svARB != null, "pglVertexAttrib2svARB not implemented");
					Delegates.pglVertexAttrib2svARB(index, p_v);
					CallLog("glVertexAttrib2svARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3dARB.
		/// </summary>
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3dARB != null, "pglVertexAttrib3dARB not implemented");
			Delegates.pglVertexAttrib3dARB(index, x, y, z);
			CallLog("glVertexAttrib3dARB({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3dvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3dvARB != null, "pglVertexAttrib3dvARB not implemented");
					Delegates.pglVertexAttrib3dvARB(index, p_v);
					CallLog("glVertexAttrib3dvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3fARB.
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
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3fARB != null, "pglVertexAttrib3fARB not implemented");
			Delegates.pglVertexAttrib3fARB(index, x, y, z);
			CallLog("glVertexAttrib3fARB({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3fvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3fvARB != null, "pglVertexAttrib3fvARB not implemented");
					Delegates.pglVertexAttrib3fvARB(index, p_v);
					CallLog("glVertexAttrib3fvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3sARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3sARB != null, "pglVertexAttrib3sARB not implemented");
			Delegates.pglVertexAttrib3sARB(index, x, y, z);
			CallLog("glVertexAttrib3sARB({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3svARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib3ARB(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3svARB != null, "pglVertexAttrib3svARB not implemented");
					Delegates.pglVertexAttrib3svARB(index, p_v);
					CallLog("glVertexAttrib3svARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NbvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NbvARB != null, "pglVertexAttrib4NbvARB not implemented");
					Delegates.pglVertexAttrib4NbvARB(index, p_v);
					CallLog("glVertexAttrib4NbvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NivARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NivARB != null, "pglVertexAttrib4NivARB not implemented");
					Delegates.pglVertexAttrib4NivARB(index, p_v);
					CallLog("glVertexAttrib4NivARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NsvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NsvARB != null, "pglVertexAttrib4NsvARB not implemented");
					Delegates.pglVertexAttrib4NsvARB(index, p_v);
					CallLog("glVertexAttrib4NsvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NubARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, byte x, byte y, byte z, byte w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4NubARB != null, "pglVertexAttrib4NubARB not implemented");
			Delegates.pglVertexAttrib4NubARB(index, x, y, z, w);
			CallLog("glVertexAttrib4NubARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NubvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NubvARB != null, "pglVertexAttrib4NubvARB not implemented");
					Delegates.pglVertexAttrib4NubvARB(index, p_v);
					CallLog("glVertexAttrib4NubvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NuivARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NuivARB != null, "pglVertexAttrib4NuivARB not implemented");
					Delegates.pglVertexAttrib4NuivARB(index, p_v);
					CallLog("glVertexAttrib4NuivARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4NusvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4NARB(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4NusvARB != null, "pglVertexAttrib4NusvARB not implemented");
					Delegates.pglVertexAttrib4NusvARB(index, p_v);
					CallLog("glVertexAttrib4NusvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4bvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4bvARB != null, "pglVertexAttrib4bvARB not implemented");
					Delegates.pglVertexAttrib4bvARB(index, p_v);
					CallLog("glVertexAttrib4bvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4dARB.
		/// </summary>
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4dARB != null, "pglVertexAttrib4dARB not implemented");
			Delegates.pglVertexAttrib4dARB(index, x, y, z, w);
			CallLog("glVertexAttrib4dARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4dvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4dvARB != null, "pglVertexAttrib4dvARB not implemented");
					Delegates.pglVertexAttrib4dvARB(index, p_v);
					CallLog("glVertexAttrib4dvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4fARB.
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
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4fARB != null, "pglVertexAttrib4fARB not implemented");
			Delegates.pglVertexAttrib4fARB(index, x, y, z, w);
			CallLog("glVertexAttrib4fARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4fvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4fvARB != null, "pglVertexAttrib4fvARB not implemented");
					Delegates.pglVertexAttrib4fvARB(index, p_v);
					CallLog("glVertexAttrib4fvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4ivARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4ivARB != null, "pglVertexAttrib4ivARB not implemented");
					Delegates.pglVertexAttrib4ivARB(index, p_v);
					CallLog("glVertexAttrib4ivARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4sARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4sARB != null, "pglVertexAttrib4sARB not implemented");
			Delegates.pglVertexAttrib4sARB(index, x, y, z, w);
			CallLog("glVertexAttrib4sARB({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4svARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4svARB != null, "pglVertexAttrib4svARB not implemented");
					Delegates.pglVertexAttrib4svARB(index, p_v);
					CallLog("glVertexAttrib4svARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4ubvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ubARB(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4ubvARB != null, "pglVertexAttrib4ubvARB not implemented");
					Delegates.pglVertexAttrib4ubvARB(index, p_v);
					CallLog("glVertexAttrib4ubvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4uivARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4uivARB != null, "pglVertexAttrib4uivARB not implemented");
					Delegates.pglVertexAttrib4uivARB(index, p_v);
					CallLog("glVertexAttrib4uivARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4usvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ARB(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4usvARB != null, "pglVertexAttrib4usvARB not implemented");
					Delegates.pglVertexAttrib4usvARB(index, p_v);
					CallLog("glVertexAttrib4usvARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribPointerARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointerARB(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribPointerARB != null, "pglVertexAttribPointerARB not implemented");
			Delegates.pglVertexAttribPointerARB(index, size, type, normalized, stride, pointer);
			CallLog("glVertexAttribPointerARB({0}, {1}, {2}, {3}, {4}, {5})", index, size, type, normalized, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribPointerARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointerARB(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribPointerARB(index, size, type, normalized, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glEnableVertexAttribArrayARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void EnableVertexAttribArrayARB(UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexAttribArrayARB != null, "pglEnableVertexAttribArrayARB not implemented");
			Delegates.pglEnableVertexAttribArrayARB(index);
			CallLog("glEnableVertexAttribArrayARB({0})", index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableVertexAttribArrayARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void DisableVertexAttribArrayARB(UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexAttribArrayARB != null, "pglDisableVertexAttribArrayARB not implemented");
			Delegates.pglDisableVertexAttribArrayARB(index);
			CallLog("glDisableVertexAttribArrayARB({0})", index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramStringARB(int target, int format, Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglProgramStringARB != null, "pglProgramStringARB not implemented");
			Delegates.pglProgramStringARB(target, format, len, @string);
			CallLog("glProgramStringARB({0}, {1}, {2}, {3})", target, format, len, @string);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramStringARB(int target, int format, Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				ProgramStringARB(target, format, len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// Binding for glBindProgramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void BindProgramARB(int target, UInt32 program)
		{
			if        (Delegates.pglBindProgramARB != null) {
				Delegates.pglBindProgramARB(target, program);
				CallLog("glBindProgramARB({0}, {1})", target, program);
			} else if (Delegates.pglBindProgramNV != null) {
				Delegates.pglBindProgramNV(target, program);
				CallLog("glBindProgramNV({0}, {1})", target, program);
			} else
				throw new NotImplementedException("glBindProgramARB (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteProgramsARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void DeleteProgramsARB(params UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					if        (Delegates.pglDeleteProgramsARB != null) {
						Delegates.pglDeleteProgramsARB((Int32)programs.Length, p_programs);
						CallLog("glDeleteProgramsARB({0}, {1})", programs.Length, programs);
					} else if (Delegates.pglDeleteProgramsNV != null) {
						Delegates.pglDeleteProgramsNV((Int32)programs.Length, p_programs);
						CallLog("glDeleteProgramsNV({0}, {1})", programs.Length, programs);
					} else
						throw new NotImplementedException("glDeleteProgramsARB (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenProgramsARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GenProgramsARB(UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					if        (Delegates.pglGenProgramsARB != null) {
						Delegates.pglGenProgramsARB((Int32)programs.Length, p_programs);
						CallLog("glGenProgramsARB({0}, {1})", programs.Length, programs);
					} else if (Delegates.pglGenProgramsNV != null) {
						Delegates.pglGenProgramsNV((Int32)programs.Length, p_programs);
						CallLog("glGenProgramsNV({0}, {1})", programs.Length, programs);
					} else
						throw new NotImplementedException("glGenProgramsARB (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenProgramsARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static UInt32 GenProgramsARB()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramsARB(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glProgramEnvParameter4dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(int target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameter4dARB != null, "pglProgramEnvParameter4dARB not implemented");
			Delegates.pglProgramEnvParameter4dARB(target, index, x, y, z, w);
			CallLog("glProgramEnvParameter4dARB({0}, {1}, {2}, {3}, {4}, {5})", target, index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramEnvParameter4dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(int target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameter4dvARB != null, "pglProgramEnvParameter4dvARB not implemented");
					Delegates.pglProgramEnvParameter4dvARB(target, index, p_params);
					CallLog("glProgramEnvParameter4dvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramEnvParameter4fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(int target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameter4fARB != null, "pglProgramEnvParameter4fARB not implemented");
			Delegates.pglProgramEnvParameter4fARB(target, index, x, y, z, w);
			CallLog("glProgramEnvParameter4fARB({0}, {1}, {2}, {3}, {4}, {5})", target, index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramEnvParameter4fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(int target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameter4fvARB != null, "pglProgramEnvParameter4fvARB not implemented");
					Delegates.pglProgramEnvParameter4fvARB(target, index, p_params);
					CallLog("glProgramEnvParameter4fvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramLocalParameter4dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(int target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameter4dARB != null, "pglProgramLocalParameter4dARB not implemented");
			Delegates.pglProgramLocalParameter4dARB(target, index, x, y, z, w);
			CallLog("glProgramLocalParameter4dARB({0}, {1}, {2}, {3}, {4}, {5})", target, index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramLocalParameter4dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(int target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameter4dvARB != null, "pglProgramLocalParameter4dvARB not implemented");
					Delegates.pglProgramLocalParameter4dvARB(target, index, p_params);
					CallLog("glProgramLocalParameter4dvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramLocalParameter4fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(int target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameter4fARB != null, "pglProgramLocalParameter4fARB not implemented");
			Delegates.pglProgramLocalParameter4fARB(target, index, x, y, z, w);
			CallLog("glProgramLocalParameter4fARB({0}, {1}, {2}, {3}, {4}, {5})", target, index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramLocalParameter4fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(int target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameter4fvARB != null, "pglProgramLocalParameter4fvARB not implemented");
					Delegates.pglProgramLocalParameter4fvARB(target, index, p_params);
					CallLog("glProgramLocalParameter4fvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramEnvParameterdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramEnvParameterARB(int target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterdvARB != null, "pglGetProgramEnvParameterdvARB not implemented");
					Delegates.pglGetProgramEnvParameterdvARB(target, index, p_params);
					CallLog("glGetProgramEnvParameterdvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramEnvParameterfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramEnvParameterARB(int target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterfvARB != null, "pglGetProgramEnvParameterfvARB not implemented");
					Delegates.pglGetProgramEnvParameterfvARB(target, index, p_params);
					CallLog("glGetProgramEnvParameterfvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramLocalParameterdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramLocalParameterARB(int target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterdvARB != null, "pglGetProgramLocalParameterdvARB not implemented");
					Delegates.pglGetProgramLocalParameterdvARB(target, index, p_params);
					CallLog("glGetProgramLocalParameterdvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramLocalParameterfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramLocalParameterARB(int target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterfvARB != null, "pglGetProgramLocalParameterfvARB not implemented");
					Delegates.pglGetProgramLocalParameterfvARB(target, index, p_params);
					CallLog("glGetProgramLocalParameterfvARB({0}, {1}, {2})", target, index, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramARB(int target, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetProgramivARB != null, "pglGetProgramivARB not implemented");
					Delegates.pglGetProgramivARB(target, pname, p_params);
					CallLog("glGetProgramivARB({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramStringARB(int target, int pname, IntPtr @string)
		{
			Debug.Assert(Delegates.pglGetProgramStringARB != null, "pglGetProgramStringARB not implemented");
			Delegates.pglGetProgramStringARB(target, pname, @string);
			CallLog("glGetProgramStringARB({0}, {1}, {2})", target, pname, @string);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramStringARB(int target, int pname, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				GetProgramStringARB(target, pname, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// Binding for glGetVertexAttribdvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetVertexAttribARB(UInt32 index, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribdvARB != null, "pglGetVertexAttribdvARB not implemented");
					Delegates.pglGetVertexAttribdvARB(index, pname, p_params);
					CallLog("glGetVertexAttribdvARB({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribfvARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetVertexAttribARB(UInt32 index, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribfvARB != null, "pglGetVertexAttribfvARB not implemented");
					Delegates.pglGetVertexAttribfvARB(index, pname, p_params);
					CallLog("glGetVertexAttribfvARB({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribivARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetVertexAttribARB(UInt32 index, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribivARB != null, "pglGetVertexAttribivARB not implemented");
					Delegates.pglGetVertexAttribivARB(index, pname, p_params);
					CallLog("glGetVertexAttribivARB({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribPointervARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetVertexAttribPointerARB(UInt32 index, int pname, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglGetVertexAttribPointervARB != null, "pglGetVertexAttribPointervARB not implemented");
			Delegates.pglGetVertexAttribPointervARB(index, pname, pointer);
			CallLog("glGetVertexAttribPointervARB({0}, {1}, {2})", index, pname, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribPointervARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetVertexAttribPointerARB(UInt32 index, int pname, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				GetVertexAttribPointerARB(index, pname, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glIsProgramARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static bool IsProgramARB(UInt32 program)
		{
			bool retValue;

			if        (Delegates.pglIsProgramARB != null) {
				retValue = Delegates.pglIsProgramARB(program);
				CallLog("glIsProgramARB({0}) = {1}", program, retValue);
			} else if (Delegates.pglIsProgramNV != null) {
				retValue = Delegates.pglIsProgramNV(program);
				CallLog("glIsProgramNV({0}) = {1}", program, retValue);
			} else
				throw new NotImplementedException("glIsProgramARB (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

	}

}
