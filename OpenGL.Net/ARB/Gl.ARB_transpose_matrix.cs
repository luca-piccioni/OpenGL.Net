
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
		/// Value of GL_TRANSPOSE_MODELVIEW_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		public const int TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;

		/// <summary>
		/// Value of GL_TRANSPOSE_PROJECTION_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		public const int TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;

		/// <summary>
		/// Value of GL_TRANSPOSE_TEXTURE_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		public const int TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;

		/// <summary>
		/// Value of GL_TRANSPOSE_COLOR_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_transpose_matrix")]
		public const int TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;

		/// <summary>
		/// Binding for glLoadTransposeMatrixfARB.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void LoadTransposeMatrixARB(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixfARB != null, "pglLoadTransposeMatrixfARB not implemented");
					Delegates.pglLoadTransposeMatrixfARB(p_m);
					CallLog("glLoadTransposeMatrixfARB({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadTransposeMatrixdARB.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		public static void LoadTransposeMatrixARB(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixdARB != null, "pglLoadTransposeMatrixdARB not implemented");
					Delegates.pglLoadTransposeMatrixdARB(p_m);
					CallLog("glLoadTransposeMatrixdARB({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultTransposeMatrixfARB.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void MultTransposeMatrixARB(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixfARB != null, "pglMultTransposeMatrixfARB not implemented");
					Delegates.pglMultTransposeMatrixfARB(p_m);
					CallLog("glMultTransposeMatrixfARB({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultTransposeMatrixdARB.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		public static void MultTransposeMatrixARB(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixdARB != null, "pglMultTransposeMatrixdARB not implemented");
					Delegates.pglMultTransposeMatrixdARB(p_m);
					CallLog("glMultTransposeMatrixdARB({0})", m);
				}
			}
			DebugCheckErrors();
		}

	}

}
