
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Runtime.CompilerServices;

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
			for (int i = 0; i < _MatArray.Length; i++) {
				ModelMatrix modelMatrix = new ModelMatrix();
				modelMatrix.RotateX(random.NextDouble() * 360.0);
				modelMatrix.RotateY(random.NextDouble() * 360.0);
				modelMatrix.RotateZ(random.NextDouble() * 360.0);
				modelMatrix.Translate(random.NextDouble(), random.NextDouble(), random.NextDouble());

				_MatArray[i] = modelMatrix;
			}
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

			for (int i = 0; i <  _MatArray.Length; i++) {
				Matrix4x4 m2 = new Matrix4x4();
				ComputeMatrixProductManaged(m2, m1, _MatArray[i]);
				m1 = m2;
			}
		}

		private static void ComputeMatrixProductManaged(Matrix4x4 result, Matrix4x4 m, Matrix4x4 n)
		{
			if (result == null)
				throw new ArgumentNullException("result");
			if (m == null)
				throw new ArgumentNullException("m");
			if (n == null)
				throw new ArgumentNullException("n");

			float[] pm = m.MatrixBuffer, pn = n.MatrixBuffer;

			result.MatrixBuffer[0x0] = pm[0x0] * pn[0x0] + pm[0x4] * pn[0x1] + pm[0x8] * pn[0x2] + pm[0xC] * pn[0x3];
			result.MatrixBuffer[0x4] = pm[0x0] * pn[0x4] + pm[0x4] * pn[0x5] + pm[0x8] * pn[0x6] + pm[0xC] * pn[0x7];
			result.MatrixBuffer[0x8] = pm[0x0] * pn[0x8] + pm[0x4] * pn[0x9] + pm[0x8] * pn[0xA] + pm[0xC] * pn[0xB];
			result.MatrixBuffer[0xC] = pm[0x0] * pn[0xC] + pm[0x4] * pn[0xD] + pm[0x8] * pn[0xE] + pm[0xC] * pn[0xF];

			result.MatrixBuffer[0x1] = pm[0x1] * pn[0x0] + pm[0x5] * pn[0x1] + pm[0x9] * pn[0x2] + pm[0xD] * pn[0x3];
			result.MatrixBuffer[0x5] = pm[0x1] * pn[0x4] + pm[0x5] * pn[0x5] + pm[0x9] * pn[0x6] + pm[0xD] * pn[0x7];
			result.MatrixBuffer[0x9] = pm[0x1] * pn[0x8] + pm[0x5] * pn[0x9] + pm[0x9] * pn[0xA] + pm[0xD] * pn[0xB];
			result.MatrixBuffer[0xD] = pm[0x1] * pn[0xC] + pm[0x5] * pn[0xD] + pm[0x9] * pn[0xE] + pm[0xD] * pn[0xF];

			result.MatrixBuffer[0x2] = pm[0x2] * pn[0x0] + pm[0x6] * pn[0x1] + pm[0xA] * pn[0x2] + pm[0xE] * pn[0x3];
			result.MatrixBuffer[0x6] = pm[0x2] * pn[0x4] + pm[0x6] * pn[0x5] + pm[0xA] * pn[0x6] + pm[0xE] * pn[0x7];
			result.MatrixBuffer[0xA] = pm[0x2] * pn[0x8] + pm[0x6] * pn[0x9] + pm[0xA] * pn[0xA] + pm[0xE] * pn[0xB];
			result.MatrixBuffer[0xE] = pm[0x2] * pn[0xC] + pm[0x6] * pn[0xD] + pm[0xA] * pn[0xE] + pm[0xE] * pn[0xF];

			result.MatrixBuffer[0x3] = pm[0x3] * pn[0x0] + pm[0x7] * pn[0x1] + pm[0xB] * pn[0x2] + pm[0xF] * pn[0x3];
			result.MatrixBuffer[0x7] = pm[0x3] * pn[0x4] + pm[0x7] * pn[0x5] + pm[0xB] * pn[0x6] + pm[0xF] * pn[0x7];
			result.MatrixBuffer[0xB] = pm[0x3] * pn[0x8] + pm[0x7] * pn[0x9] + pm[0xB] * pn[0xA] + pm[0xF] * pn[0xB];
			result.MatrixBuffer[0xF] = pm[0x3] * pn[0xC] + pm[0x7] * pn[0xD] + pm[0xB] * pn[0xE] + pm[0xF] * pn[0xF];
		}

		[Benchmark("BenchmarkMulUnsafe", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Unsafe()
		{
			Matrix4x4 m1 = new Matrix4x4();
			m1.SetIdentity();

			for (int i = 0; i <  _MatArray.Length; i++) {
				Matrix4x4 m2 = new Matrix4x4();
				ComputeMatrixProductUnsafe(m2, m1, _MatArray[i]);
				m1 = m2;
			}
		}

		private static void ComputeMatrixProductUnsafe(Matrix4x4 result, Matrix4x4 m, Matrix4x4 n)
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

#if HAVE_NUMERICS

		[Benchmark("BenchmarkMulNumerics", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Numerics()
		{
			Matrix4x4 m1 = new Matrix4x4();
			m1.SetIdentity();

			for (int i = 0; i < _MatArray.Length; i++) {
				m1 = m1 * _MatArray[i];
			}
		}

		//[Benchmark("BenchmarkMulNumerics2", Repetitions = MulRepetitions)]
		public static void BenchmarkMatrix4x44Mul_Numerics2()
		{
			//Mat4x4 m1 = Mat4x4.Identity;
			
			//for (int i = 0; i < _MatArray.Length; i++) {
			//	m1 = m1 * (Mat4x4)_MatArray[i];
			//}
		}

#endif

		/// <summary>
		/// Arrays of matrices to be multiplied each other.
		/// </summary>
		private static Matrix4x4[] _MatArray;

		/// <summary>
		/// Size of the matrix array to test performance.
		/// </summary>
		private const uint MulArraySize = 128;

		/// <summary>
		/// Number of repetitions for Min.
		/// </summary>
		private const int MulRepetitions = 1000000;

		#endregion

		#region GetInverse()

		[Test]
		public void BenchmarkMatrix4x4_GetInverse_Correctness()
		{
			Matrix4x4 matIdentity = new Matrix4x4();
			matIdentity.SetIdentity();

			for (int i = 0; i <  _MatArray.Length; i++) {
				Matrix4x4 inv, id = new Matrix4x4();

				inv = ComputeInverse_Managed(_MatArray[i]);
				ComputeMatrixProductManaged(id, inv, _MatArray[i]);
				Assert.AreEqual(matIdentity, id);

				inv = ComputeInverse_Unsafe(_MatArray[i]);
				ComputeMatrixProductManaged(id, inv, _MatArray[i]);
				Assert.AreEqual(matIdentity, id);

#if HAVE_NUMERICS
				inv = ComputeInverse_Numerics_Matrix4x4(_MatArray[i]);
				ComputeMatrixProductManaged(id, inv, _MatArray[i]);
				Assert.AreEqual(matIdentity, id);

				inv = ComputeInverse_Numerics_Vector3(_MatArray[i]);
				ComputeMatrixProductManaged(id, inv, _MatArray[i]);
				Assert.AreEqual(matIdentity, id);
#endif
			}
		}

		[Test]
		public void BenchmarkMatrix4x4_GetInverse()
		{
			RunBenchmarks<Matrix4x4Test>("BenchmarkMatrix4x4_GetInverse");
		}

		[Benchmark("BenchmarkMatrix4x4_GetInverse_Managed", Repetitions = GetInverseRepetitions)]
		public static void BenchmarkMatrix4x4_GetInverse_Managed()
		{
			for (int i = 0; i <  _MatArray.Length; i++)
				ComputeInverse_Managed(_MatArray[i]);
		}

		private static Matrix4x4 ComputeInverse_Managed(Matrix4x4 matrix)
		{
			float[] m = matrix.MatrixBuffer;
			float[] inv = new float[16], invOut = new float[16];
			float det;

			inv[0x0] =  m[0x5] * m[0xA] * m[0xF] - 
					    m[0x5] * m[0xB] * m[0xE] - 
					    m[0x9] * m[0x6] * m[0xF] + 
					    m[0x9] * m[0x7] * m[0xE] +
					    m[0xD] * m[0x6] * m[0xB] - 
					    m[0xD] * m[0x7] * m[0xA];

			inv[0x4] = -m[0x4] * m[0xA] * m[0xF] + 
					    m[0x4] * m[0xB] * m[0xE] + 
					    m[0x8] * m[0x6] * m[0xF] - 
					    m[0x8] * m[0x7] * m[0xE] - 
					    m[0xC] * m[0x6] * m[0xB] + 
					    m[0xC] * m[0x7] * m[0xA];

			inv[0x8] =  m[0x4] * m[0x9] * m[0xF] - 
					    m[0x4] * m[0xB] * m[0xD] - 
					    m[0x8] * m[0x5] * m[0xF] + 
					    m[0x8] * m[0x7] * m[0xD] + 
					    m[0xC] * m[0x5] * m[0xB] - 
					    m[0xC] * m[0x7] * m[0x9];

			inv[0xC] = -m[0x4] * m[0x9] * m[0xE] + 
					    m[0x4] * m[0xA] * m[0xD] +
					    m[0x8] * m[0x5] * m[0xE] - 
					    m[0x8] * m[0x6] * m[0xD] - 
					    m[0xC] * m[0x5] * m[0xA] + 
					    m[0xC] * m[0x6] * m[0x9];

			inv[0x1] = -m[0x1] * m[0xA] * m[0xF] + 
					    m[0x1] * m[0xB] * m[0xE] + 
					    m[0x9] * m[0x2] * m[0xF] - 
					    m[0x9] * m[0x3] * m[0xE] - 
					    m[0xD] * m[0x2] * m[0xB] + 
					    m[0xD] * m[0x3] * m[0xA];

			inv[0x5] =  m[0x0] * m[0xA] * m[0xF] - 
					    m[0x0] * m[0xB] * m[0xE] - 
					    m[0x8] * m[0x2] * m[0xF] + 
					    m[0x8] * m[0x3] * m[0xE] + 
					    m[0xC] * m[0x2] * m[0xB] - 
					    m[0xC] * m[0x3] * m[0xA];

			inv[0x9] = -m[0x0] * m[0x9] * m[0xF] + 
					    m[0x0] * m[0xB] * m[0xD] + 
					    m[0x8] * m[0x1] * m[0xF] - 
					    m[0x8] * m[0x3] * m[0xD] - 
					    m[0xC] * m[0x1] * m[0xB] + 
					    m[0xC] * m[0x3] * m[0x9];

			inv[0xD] =  m[0x0] * m[0x9] * m[0xE] - 
					    m[0x0] * m[0xA] * m[0xD] - 
					    m[0x8] * m[0x1] * m[0xE] + 
					    m[0x8] * m[0x2] * m[0xD] + 
					    m[0xC] * m[0x1] * m[0xA] - 
					    m[0xC] * m[0x2] * m[0x9];

			inv[0x2] =  m[0x1] * m[0x6] * m[0xF] - 
					    m[0x1] * m[0x7] * m[0xE] - 
					    m[0x5] * m[0x2] * m[0xF] + 
					    m[0x5] * m[0x3] * m[0xE] + 
					    m[0xD] * m[0x2] * m[0x7] - 
					    m[0xD] * m[0x3] * m[0x6];

			inv[0x6] = -m[0x0] * m[0x6] * m[0xF] + 
					    m[0x0] * m[0x7] * m[0xE] + 
					    m[0x4] * m[0x2] * m[0xF] - 
					    m[0x4] * m[0x3] * m[0xE] - 
					    m[0xC] * m[0x2] * m[0x7] + 
					    m[0xC] * m[0x3] * m[0x6];

			inv[0xA] =  m[0x0] * m[0x5] * m[0xF] - 
					    m[0x0] * m[0x7] * m[0xD] - 
					    m[0x4] * m[0x1] * m[0xF] + 
					    m[0x4] * m[0x3] * m[0xD] + 
					    m[0xC] * m[0x1] * m[0x7] - 
					    m[0xC] * m[0x3] * m[0x5];

			inv[0xE] = -m[0x0] * m[0x5] * m[0xE] + 
					    m[0x0] * m[0x6] * m[0xD] + 
					    m[0x4] * m[0x1] * m[0xE] - 
					    m[0x4] * m[0x2] * m[0xD] - 
					    m[0xC] * m[0x1] * m[0x6] + 
					    m[0xC] * m[0x2] * m[0x5];

			inv[0x3] = -m[0x1] * m[0x6] * m[0xB] + 
					    m[0x1] * m[0x7] * m[0xA] + 
					    m[0x5] * m[0x2] * m[0xB] - 
					    m[0x5] * m[0x3] * m[0xA] - 
					    m[0x9] * m[0x2] * m[0x7] + 
					    m[0x9] * m[0x3] * m[0x6];

			inv[0x7] =  m[0x0] * m[0x6] * m[0xB] - 
					    m[0x0] * m[0x7] * m[0xA] - 
					    m[0x4] * m[0x2] * m[0xB] + 
					    m[0x4] * m[0x3] * m[0xA] + 
					    m[0x8] * m[0x2] * m[0x7] - 
					    m[0x8] * m[0x3] * m[0x6];

			inv[0xB] = -m[0x0] * m[0x5] * m[0xB] + 
					    m[0x0] * m[0x7] * m[0x9] + 
					    m[0x4] * m[0x1] * m[0xB] - 
					    m[0x4] * m[0x3] * m[0x9] - 
					    m[0x8] * m[0x1] * m[0x7] + 
					    m[0x8] * m[0x3] * m[0x5];

			inv[0xF] =  m[0x0] * m[0x5] * m[0xA] - 
					    m[0x0] * m[0x6] * m[0x9] - 
					    m[0x4] * m[0x1] * m[0xA] + 
					    m[0x4] * m[0x2] * m[0x9] + 
					    m[0x8] * m[0x1] * m[0x6] - 
					    m[0x8] * m[0x2] * m[0x5];

			det = m[0x0] * inv[0x0] + m[0x1] * inv[0x4] + m[0x2] * inv[0x8] + m[0x3] * inv[0xC];

			if (det == 0)
				throw new InvalidOperationException("not invertible");

			det = 1.0f / det;
			for (int i = 0; i < 16; i++)
				inv[i] = inv[i] * det;

			return (new Matrix4x4(inv));
		}

		[Benchmark("BenchmarkMatrix4x4_GetInverse_Unsafe", Repetitions = GetInverseRepetitions)]
		public static void BenchmarkMatrix4x4_GetInverse_Unsafe()
		{
			for (int i = 0; i <  _MatArray.Length; i++)
				ComputeInverse_Unsafe(_MatArray[i]);
		}

		private static Matrix4x4 ComputeInverse_Unsafe(Matrix4x4 matrix)
		{
			unsafe {
				fixed (float *m = matrix.MatrixBuffer)
				{
					float[] inv = new float[16], invOut = new float[16];
					float det;

					inv[0x0] =  m[0x5] * m[0xA] * m[0xF] - 
								m[0x5] * m[0xB] * m[0xE] - 
								m[0x9] * m[0x6] * m[0xF] + 
								m[0x9] * m[0x7] * m[0xE] +
								m[0xD] * m[0x6] * m[0xB] - 
								m[0xD] * m[0x7] * m[0xA];

					inv[0x4] = -m[0x4] * m[0xA] * m[0xF] + 
								m[0x4] * m[0xB] * m[0xE] + 
								m[0x8] * m[0x6] * m[0xF] - 
								m[0x8] * m[0x7] * m[0xE] - 
								m[0xC] * m[0x6] * m[0xB] + 
								m[0xC] * m[0x7] * m[0xA];

					inv[0x8] =  m[0x4] * m[0x9] * m[0xF] - 
								m[0x4] * m[0xB] * m[0xD] - 
								m[0x8] * m[0x5] * m[0xF] + 
								m[0x8] * m[0x7] * m[0xD] + 
								m[0xC] * m[0x5] * m[0xB] - 
								m[0xC] * m[0x7] * m[0x9];

					inv[0xC] = -m[0x4] * m[0x9] * m[0xE] + 
								m[0x4] * m[0xA] * m[0xD] +
								m[0x8] * m[0x5] * m[0xE] - 
								m[0x8] * m[0x6] * m[0xD] - 
								m[0xC] * m[0x5] * m[0xA] + 
								m[0xC] * m[0x6] * m[0x9];

					inv[0x1] = -m[0x1] * m[0xA] * m[0xF] + 
								m[0x1] * m[0xB] * m[0xE] + 
								m[0x9] * m[0x2] * m[0xF] - 
								m[0x9] * m[0x3] * m[0xE] - 
								m[0xD] * m[0x2] * m[0xB] + 
								m[0xD] * m[0x3] * m[0xA];

					inv[0x5] =  m[0x0] * m[0xA] * m[0xF] - 
								m[0x0] * m[0xB] * m[0xE] - 
								m[0x8] * m[0x2] * m[0xF] + 
								m[0x8] * m[0x3] * m[0xE] + 
								m[0xC] * m[0x2] * m[0xB] - 
								m[0xC] * m[0x3] * m[0xA];

					inv[0x9] = -m[0x0] * m[0x9] * m[0xF] + 
								m[0x0] * m[0xB] * m[0xD] + 
								m[0x8] * m[0x1] * m[0xF] - 
								m[0x8] * m[0x3] * m[0xD] - 
								m[0xC] * m[0x1] * m[0xB] + 
								m[0xC] * m[0x3] * m[0x9];

					inv[0xD] =  m[0x0] * m[0x9] * m[0xE] - 
								m[0x0] * m[0xA] * m[0xD] - 
								m[0x8] * m[0x1] * m[0xE] + 
								m[0x8] * m[0x2] * m[0xD] + 
								m[0xC] * m[0x1] * m[0xA] - 
								m[0xC] * m[0x2] * m[0x9];

					inv[0x2] =  m[0x1] * m[0x6] * m[0xF] - 
								m[0x1] * m[0x7] * m[0xE] - 
								m[0x5] * m[0x2] * m[0xF] + 
								m[0x5] * m[0x3] * m[0xE] + 
								m[0xD] * m[0x2] * m[0x7] - 
								m[0xD] * m[0x3] * m[0x6];

					inv[0x6] = -m[0x0] * m[0x6] * m[0xF] + 
								m[0x0] * m[0x7] * m[0xE] + 
								m[0x4] * m[0x2] * m[0xF] - 
								m[0x4] * m[0x3] * m[0xE] - 
								m[0xC] * m[0x2] * m[0x7] + 
								m[0xC] * m[0x3] * m[0x6];

					inv[0xA] =  m[0x0] * m[0x5] * m[0xF] - 
								m[0x0] * m[0x7] * m[0xD] - 
								m[0x4] * m[0x1] * m[0xF] + 
								m[0x4] * m[0x3] * m[0xD] + 
								m[0xC] * m[0x1] * m[0x7] - 
								m[0xC] * m[0x3] * m[0x5];

					inv[0xE] = -m[0x0] * m[0x5] * m[0xE] + 
								m[0x0] * m[0x6] * m[0xD] + 
								m[0x4] * m[0x1] * m[0xE] - 
								m[0x4] * m[0x2] * m[0xD] - 
								m[0xC] * m[0x1] * m[0x6] + 
								m[0xC] * m[0x2] * m[0x5];

					inv[0x3] = -m[0x1] * m[0x6] * m[0xB] + 
								m[0x1] * m[0x7] * m[0xA] + 
								m[0x5] * m[0x2] * m[0xB] - 
								m[0x5] * m[0x3] * m[0xA] - 
								m[0x9] * m[0x2] * m[0x7] + 
								m[0x9] * m[0x3] * m[0x6];

					inv[0x7] =  m[0x0] * m[0x6] * m[0xB] - 
								m[0x0] * m[0x7] * m[0xA] - 
								m[0x4] * m[0x2] * m[0xB] + 
								m[0x4] * m[0x3] * m[0xA] + 
								m[0x8] * m[0x2] * m[0x7] - 
								m[0x8] * m[0x3] * m[0x6];

					inv[0xB] = -m[0x0] * m[0x5] * m[0xB] + 
								m[0x0] * m[0x7] * m[0x9] + 
								m[0x4] * m[0x1] * m[0xB] - 
								m[0x4] * m[0x3] * m[0x9] - 
								m[0x8] * m[0x1] * m[0x7] + 
								m[0x8] * m[0x3] * m[0x5];

					inv[0xF] =  m[0x0] * m[0x5] * m[0xA] - 
								m[0x0] * m[0x6] * m[0x9] - 
								m[0x4] * m[0x1] * m[0xA] + 
								m[0x4] * m[0x2] * m[0x9] + 
								m[0x8] * m[0x1] * m[0x6] - 
								m[0x8] * m[0x2] * m[0x5];

					det = m[0x0] * inv[0x0] + m[0x1] * inv[0x4] + m[0x2] * inv[0x8] + m[0x3] * inv[0xC];

					if (det == 0)
						throw new InvalidOperationException("not invertible");

					det = 1.0f / det;

					det = 1.0f / det;
					for (int i = 0; i < 16; i++)
						inv[i] = inv[i] * det;

					return (new Matrix4x4(inv));
				}
			}
		}

#if HAVE_NUMERICS

		[Benchmark("BenchmarkMatrix4x4_GetInverse_Numerics_Matrix4x4", Repetitions = GetInverseRepetitions)]
		public static void BenchmarkMatrix4x4_GetInverse_Numerics()
		{
			for (int i = 0; i <  _MatArray.Length; i++)
				ComputeInverse_Numerics_Matrix4x4(_MatArray[i]);
		}

		private static Matrix4x4 ComputeInverse_Numerics_Matrix4x4(Matrix4x4 matrix)
		{
			Mat4x4 m = new Mat4x4(
				matrix.MatrixBuffer[0x0], matrix.MatrixBuffer[0x1], matrix.MatrixBuffer[0x2], matrix.MatrixBuffer[0x3],
				matrix.MatrixBuffer[0x4], matrix.MatrixBuffer[0x5], matrix.MatrixBuffer[0x6], matrix.MatrixBuffer[0x7],
				matrix.MatrixBuffer[0x8], matrix.MatrixBuffer[0x9], matrix.MatrixBuffer[0xA], matrix.MatrixBuffer[0xB],
				matrix.MatrixBuffer[0xC], matrix.MatrixBuffer[0xD], matrix.MatrixBuffer[0xE], matrix.MatrixBuffer[0xF]
			);
			Mat4x4 inv;

			Mat4x4.Invert(m, out inv);

			return new Matrix4x4(new float[] {
				inv.M11, inv.M12, inv.M13, inv.M14,
				inv.M21, inv.M22, inv.M23, inv.M24,
				inv.M31, inv.M32, inv.M33, inv.M34,
				inv.M41, inv.M42, inv.M43, inv.M44
			});
		}

		[Benchmark("BenchmarkMatrix4x4_GetInverse_Numerics_Matrix4x4 (2)", Repetitions = GetInverseRepetitions)]
		public static void BenchmarkMatrix4x4_GetInverse_Numerics2()
		{
			for (int i = 0; i <  _MatArray.Length; i++)
				ComputeInverse_Numerics_Matrix4x4_2(_MatArray[i]);
		}

		private static Matrix4x4 ComputeInverse_Numerics_Matrix4x4_2(Matrix4x4 matrix)
		{
			Matrix4x4 invMatrix4x4 = (Matrix4x4)matrix.Clone();

			unsafe {
				fixed (float* invVecPtr = invMatrix4x4.MatrixBuffer)
				fixed (float* mVecPtr = matrix.MatrixBuffer)
				{
					Mat4x4 mVec = Unsafe.Read<Mat4x4>(mVecPtr), invVec;

					if (Mat4x4.Invert(mVec, out invVec) == false)
						throw new InvalidOperationException("not invertible");

					Unsafe.Write(invVecPtr, invVec);
				}
			}

			return (invMatrix4x4);
		}

		[Benchmark("BenchmarkMatrix4x4_GetInverse_Numerics_Vector3", Repetitions = GetInverseRepetitions)]
		public static void BenchmarkMatrix4x4_GetInverse_Vector3()
		{
			for (int i = 0; i <  _MatArray.Length; i++)
				ComputeInverse_Numerics_Vector3(_MatArray[i]);
		}

		private static Matrix4x4 ComputeInverse_Numerics_Vector3(Matrix4x4 matrix)
		{
			float[] m = matrix.MatrixBuffer;
			float[] inv = new float[16], invOut = new float[16];
			float det;

			Vector3 a, b, c, d, e, f, v1, v2;

			// ---
			a = new Vector3( m[0x5], m[0x5], m[0x9]);
			b = new Vector3( m[0xA], m[0xB], m[0x6]);
			c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x9], m[0xD], m[0xD]);
			e = new Vector3( m[0x7], m[0x6], m[0x7]);
			f = new Vector3( m[0xE], m[0xB], m[0xA]);
			v2 = d * e * f;

			inv[0x0] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x4], m[0x4], m[0x8]);
			// b = new Vector3( m[0xA], m[0xB], m[0x6]);
			// c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3(-m[0x8], m[0xC], m[0xC]);
			// e = new Vector3( m[0x7], m[0x6], m[0x7]);
			// f = new Vector3( m[0xE], m[0xB], m[0xA]);
			v2 = d * e * f;

			inv[0x4] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x4], m[0x4], m[0x8]);
			b = new Vector3( m[0x9], m[0xB], m[0x5]);
			c = new Vector3( m[0xF], m[0xD], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x8], m[0xC], m[0xC]);
			e = new Vector3( m[0x7], m[0x5], m[0x7]);
			f = new Vector3( m[0xD], m[0xB], m[0x9]);
			v2 = d * e * f;

			inv[0x8] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x4], m[0x4], m[0x8]);
			b = new Vector3( m[0x9], m[0xA], m[0x5]);
			c = new Vector3( m[0xE], m[0xD], m[0xE]);
			v1 = a * b * c;

			// d = new Vector3( m[0x8], m[0xC], m[0xC]);
			e = new Vector3( m[0x6], m[0x5], m[0x6]);
			f = new Vector3( m[0xD], m[0xA], m[0x9]);
			v2 = d * e * f;

			inv[0xC] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3(-m[0x1], m[0x1], m[0x9]);
			b = new Vector3( m[0xA], m[0xB], m[0x2]);
			c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x9], m[0xD], m[0xD]);
			e = new Vector3( m[0x3], m[0x2], m[0x3]);
			f = new Vector3( m[0xE], m[0xB], m[0xA]);
			v2 = d * e * f;

			inv[0x1] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x0], m[0x0], m[0x8]);
			// b = new Vector3( m[0xA], m[0xB], m[0x2]);
			// c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x8], m[0xC], m[0xC]);
			// e = new Vector3( m[0x3], m[0x2], m[0x3]);
			// f = new Vector3( m[0xE], m[0xB], m[0xA]);
			v2 = d * e * f;

			inv[0x5] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x0], m[0x0], m[0x8]);
			b = new Vector3( m[0x9], m[0xB], m[0x1]);
			c = new Vector3( m[0xF], m[0xD], m[0xF]);
			v1 = a * b * c;

			// d = new Vector3( m[0x8], m[0xC], m[0xC]);
			e = new Vector3( m[0x3], m[0x1], m[0x3]);
			f = new Vector3( m[0xD], m[0xB], m[0x9]);
			v2 = d * e * f;

			inv[0x9] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x0], m[0x0], m[0x8]);
			b = new Vector3( m[0x9], m[0xA], m[0x1]);
			c = new Vector3( m[0xE], m[0xD], m[0xE]);
			v1 = a * b * c;

			// d = new Vector3( m[0x8], m[0xC], m[0xC]);
			e = new Vector3( m[0x2], m[0x1], m[0x2]);
			f = new Vector3( m[0xD], m[0xA], m[0x9]);
			v2 = d * e * f;

			inv[0xD] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3( m[0x1], m[0x1], m[0x5]);
			b = new Vector3( m[0x6], m[0x7], m[0x2]);
			c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x5], m[0xD], m[0xD]);
			e = new Vector3( m[0x3], m[0x2], m[0x3]);
			f = new Vector3( m[0xE], m[0x7], m[0x6]);
			v2 = d * e * f;

			inv[0x2] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x0], m[0x0], m[0x4]);
			// b = new Vector3( m[0x6], m[0x7], m[0x2]);
			// c = new Vector3( m[0xF], m[0xE], m[0xF]);
			v1 = a * b * c;

			d = new Vector3( m[0x4], m[0xC], m[0xC]);
			// e = new Vector3( m[0x3], m[0x2], m[0x3]);
			// f = new Vector3( m[0xE], m[0x7], m[0x6]);
			v2 = d * e * f;

			inv[0x6] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x0], m[0x0], m[0x4]);
			b = new Vector3( m[0x5], m[0x7], m[0x1]);
			c = new Vector3( m[0xF], m[0xD], m[0xF]);
			v1 = a * b * c;

			// d = new Vector3( m[0x4], m[0xC], m[0xC]);
			e = new Vector3( m[0x3], m[0x1], m[0x3]);
			f = new Vector3( m[0xD], m[0x7], m[0x5]);
			v2 = d * e * f;

			inv[0xA] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x0], m[0x0], m[0x4]);
			b = new Vector3( m[0x5], m[0x6], m[0x1]);
			c = new Vector3( m[0xE], m[0xD], m[0xE]);
			v1 = a * b * c;

			// d = new Vector3( m[0x4], m[0xC], m[0xC]);
			e = new Vector3( m[0x2], m[0x1], m[0x2]);
			f = new Vector3( m[0xD], m[0x6], m[0x5]);
			v2 = d * e * f;

			inv[0xE] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3(-m[0x1], m[0x1], m[0x5]);
			b = new Vector3( m[0x6], m[0x7], m[0x2]);
			c = new Vector3( m[0xB], m[0xA], m[0xB]);
			v1 = a * b * c;

			d = new Vector3( m[0x5], m[0x9], m[0x9]);
			e = new Vector3( m[0x3], m[0x2], m[0x3]);
			f = new Vector3( m[0xA], m[0x7], m[0x6]);
			v2 = d * e * f;

			inv[0x3] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x0], m[0x0], m[0x4]);
			// b = new Vector3( m[0x6], m[0x7], m[0x2]);
			// c = new Vector3( m[0xB], m[0xA], m[0xB]);
			v1 = a * b * c;

			d = new Vector3( m[0x4], m[0x8], m[0x8]);
			// e = new Vector3( m[0x3], m[0x2], m[0x3]);
			// f = new Vector3( m[0xA], m[0x7], m[0x6]);
			v2 = d * e * f;

			inv[0x7] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			// ---
			a = new Vector3(-m[0x0], m[0x0], m[0x4]);
			b = new Vector3( m[0x5], m[0x7], m[0x1]);
			c = new Vector3( m[0xB], m[0x9], m[0xB]);
			v1 = a * b * c;

			d = new Vector3( m[0x4], m[0x8], m[0x8]);
			e = new Vector3( m[0x3], m[0x1], m[0x3]);
			f = new Vector3( m[0x9], m[0x7], m[0x5]);
			v2 = d * e * f;

			inv[0xB] = v1.X + v1.Y + v1.Z - v2.X - v2.Y + v2.Z;

			// ---
			a = new Vector3( m[0x0], m[0x0], m[0x4]);
			b = new Vector3( m[0x5], m[0x6], m[0x1]);
			c = new Vector3( m[0xA], m[0x9], m[0xA]);
			v1 = a * b * c;

			// d = new Vector3( m[0x4], m[0x8], m[0x8]);
			e = new Vector3( m[0x2], m[0x1], m[0x2]);
			f = new Vector3( m[0x9], m[0x6], m[0x5]);
			v2 = d * e * f;

			inv[0xF] = v1.X - v1.Y - v1.Z + v2.X + v2.Y - v2.Z;

			//det = m[0x0] * inv[0x0] + m[0x1] * inv[0x4] + m[0x2] * inv[0x8] + m[0x3] * inv[0xC];
			Vector4 detm = new Vector4(m[0x0], m[0x1], m[0x2], m[0x3]);
			Vector4 deti = new Vector4(inv[0x0], inv[0x4], inv[0x8], inv[0xC]);
			Vector4 detv = detm * deti;

			det = detv.X + detv.Y + detv.Z + detv.W;

			if (det == 0)
				throw new InvalidOperationException("not invertible");

			det = 1.0f / det;

			return (new Matrix4x4(inv));
		}

#endif

		/// <summary>
		/// Number of repetitions for Min.
		/// </summary>
		private const int GetInverseRepetitions = 50000 * 2;

		#endregion
	}
}
