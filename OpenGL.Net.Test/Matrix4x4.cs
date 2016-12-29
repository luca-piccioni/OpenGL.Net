
// Copyright (C) 2016 Luca Piccioni
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

using NUnit.Framework;

#if HAVE_NUMERICS
using System.Numerics;

using Mat4x4 = System.Numerics.Matrix4x4;
#endif

namespace OpenGL.Test
{
	[TestFixture]
	class Matrix4x4Test : BenchmarkBase
	{
		#region Constructors

		static Matrix4x4Test()
		{
			Random random = new Random();

			_MatArray = new Matrix4x4[MulArraySize];
			for (int i = 0; i < _MatArray.Length; i++)
				_MatArray[i] = new Matrix4x4();
		}

		#endregion

		#region Multiply

		[Test]
		public void BenchmarkMatrix4x44Mul()
		{
			RunBenchmarks<Matrix4x4Test>("BenchmarkMatrix4x44Mul");
		}

		[Benchmark("BenchmarkMulManaged", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Managed()
		{
			Matrix4x4 m1 = new Matrix4x4();
			m1.SetIdentity();

			for (int i = 0; i < _MatArray.Length; i++) {
				Matrix4x4 m2 = new Matrix4x4();
				ComputeMatrixProduct(m2, m1, _MatArray[i]);
				m1 = m2;
			}
		}

		[Benchmark("BenchmarkMulNumerics", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Numerics()
		{
			Matrix4x4 m1 = new Matrix4x4();
			m1.SetIdentity();

			for (int i = 0; i < _MatArray.Length; i++) {
				m1 = m1 * _MatArray[i];
			}
		}

		[Benchmark("BenchmarkMulNumerics2", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Numerics2()
		{
			Mat4x4 m1 = Mat4x4.Identity;
			
			for (int i = 0; i < _MatArray.Length; i++) {
				m1 = m1 * (Mat4x4)_MatArray[i];
			}
		}

		private static void ComputeMatrixProduct(Matrix4x4 result, Matrix4x4 m, Matrix4x4 n)
		{
			if (result == null)
				throw new ArgumentNullException("result");
			if (m == null)
				throw new ArgumentNullException("m");
			if (n == null)
				throw new ArgumentNullException("n");

			unsafe {
				fixed (float* prodFix = result.MatrixBuffer)
				fixed (float* pm = m.MatrixBuffer)
				fixed (float* pn = n.MatrixBuffer)
				{
					prodFix[0x0] = pm[0x0] * pn[0x0] + pm[0x4] * pn[0x1] + pm[0x8] * pn[0x2] + pm[0xC] * pn[0x3];
					prodFix[0x4] = pm[0x0] * pn[0x4] + pm[0x4] * pn[0x5] + pm[0x8] * pn[0x6] + pm[0xC] * pn[0x7];
					prodFix[0x8] = pm[0x0] * pn[0x8] + pm[0x4] * pn[0x9] + pm[0x8] * pn[0xA] + pm[0xC] * pn[0xB];
					prodFix[0xC] = pm[0x0] * pn[0xC] + pm[0x4] * pn[0xD] + pm[0x8] * pn[0xE] + pm[0xC] * pn[0xF];

					prodFix[0x1] = pm[0x1] * pn[0x0] + pm[0x5] * pn[0x1] + pm[0x9] * pn[0x2] + pm[0xD] * pn[0x3];
					prodFix[0x5] = pm[0x1] * pn[0x4] + pm[0x5] * pn[0x5] + pm[0x9] * pn[0x6] + pm[0xD] * pn[0x7];
					prodFix[0x9] = pm[0x1] * pn[0x8] + pm[0x5] * pn[0x9] + pm[0x9] * pn[0xA] + pm[0xD] * pn[0xB];
					prodFix[0xD] = pm[0x1] * pn[0xC] + pm[0x5] * pn[0xD] + pm[0x9] * pn[0xE] + pm[0xD] * pn[0xF];

					prodFix[0x2] = pm[0x2] * pn[0x0] + pm[0x6] * pn[0x1] + pm[0xA] * pn[0x2] + pm[0xE] * pn[0x3];
					prodFix[0x6] = pm[0x2] * pn[0x4] + pm[0x6] * pn[0x5] + pm[0xA] * pn[0x6] + pm[0xE] * pn[0x7];
					prodFix[0xA] = pm[0x2] * pn[0x8] + pm[0x6] * pn[0x9] + pm[0xA] * pn[0xA] + pm[0xE] * pn[0xB];
					prodFix[0xE] = pm[0x2] * pn[0xC] + pm[0x6] * pn[0xD] + pm[0xA] * pn[0xE] + pm[0xE] * pn[0xF];

					prodFix[0x3] = pm[0x3] * pn[0x0] + pm[0x7] * pn[0x1] + pm[0xB] * pn[0x2] + pm[0xF] * pn[0x3];
					prodFix[0x7] = pm[0x3] * pn[0x4] + pm[0x7] * pn[0x5] + pm[0xB] * pn[0x6] + pm[0xF] * pn[0x7];
					prodFix[0xB] = pm[0x3] * pn[0x8] + pm[0x7] * pn[0x9] + pm[0xB] * pn[0xA] + pm[0xF] * pn[0xB];
					prodFix[0xF] = pm[0x3] * pn[0xC] + pm[0x7] * pn[0xD] + pm[0xB] * pn[0xE] + pm[0xF] * pn[0xF];
				}
			}
		}

		private static Matrix4x4[] _MatArray;

		/// <summary>
		/// Size of the array used for testing: 50K vertices.
		/// </summary>
		private const uint MulArraySize = 1024;

		/// <summary>
		/// Number of repetitions for Min.
		/// </summary>
		private const int MulRepetitions = 10000;

		#endregion
	}
}
