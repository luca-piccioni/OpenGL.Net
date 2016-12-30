
// Copyright (C) 2009-2016 Luca Piccioni
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

// Enable gluInvertMatrix implementation
#define ENABLE_INVERSE

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#if HAVE_NUMERICS
using System.Numerics;

using Mat4x4 = System.Numerics.Matrix4x4;
#endif

namespace OpenGL
{
	/// <summary>
	/// Square matrix of 4x4 components.
	/// </summary>
	public class Matrix4x4 : Matrix, IMatrix4x4
	{
		#region Constructors

		/// <summary>
		/// Square matrix constructor.
		/// </summary>
		public Matrix4x4() :
			base(4, 4)
		{

		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public Matrix4x4(float[] values) :
			base(values, 4, 4)
		{
		
		}

		/// <summary>
		/// Matrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/> to be copied.
		/// </param>
		public Matrix4x4(Matrix4x4 m) :
			base(m)
		{

		}

		/// <summary>
		/// Matrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/> to be copied.
		/// </param>
		public Matrix4x4(IMatrix4x4 m) :
			base(m)
		{

		}

		#endregion

		#region Operators

		/// <summary>
		/// Compute the product of a Matrix4x4 with a Vertex4f (project a vertex on this matrix).
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and
		/// the vector <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		public static Vertex4f operator *(Matrix4x4 m, Vertex4f v)
		{
			return (ComputeMatrixProduct(m, v));
		}

		/// <summary>
		/// Compute the product of two Matrix4x4.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4"/> resulting from the product of the matrix <paramref name="m1"/> and
		/// the matrix <paramref name="m2"/>. This operator is used to concatenate successive transformations.
		/// </returns>
		public static Matrix4x4 operator *(Matrix4x4 m1, Matrix4x4 m2)
		{
			Matrix4x4 prod = new Matrix4x4();

			// Compute product
			ComputeMatrixProduct(prod, m1, m2);

			return (prod);
		}

		/// <summary>
		/// Rotate a Matrix4x4 in three-dimensional space using Quaternion.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="q"></param>
		/// <returns></returns>
		public static Matrix4x4 operator *(Matrix4x4 m, Quaternion q)
		{
			Matrix4x4 prod = new Matrix4x4();

			// COmpute product
			ComputeMatrixProduct(prod, m, (Matrix4x4) q);

			return (prod);
		}

		/// <summary>
		/// Compute the product between Matrix4x4 and Vertex4f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the right multiplication operand.
		/// </param>
		protected static Vertex4f ComputeMatrixProduct(Matrix4x4 m, Vertex4f v)
		{
			float x, y, z, w;

			unsafe {
				fixed (float* pm = m.MatrixBuffer)
				{
					x = pm[0x0] * v.x + pm[0x4] * v.y + pm[0x8] * v.z + pm[0xC] * v.w;
					y = pm[0x1] * v.x + pm[0x5] * v.y + pm[0x9] * v.z + pm[0xD] * v.w;
					z = pm[0x2] * v.x + pm[0x6] * v.y + pm[0xA] * v.z + pm[0xE] * v.w;
					w = pm[0x3] * v.x + pm[0x7] * v.y + pm[0xB] * v.z + pm[0xF] * v.w;
				}
			}

			return (new Vertex4f(x, y, z, w));
		}

		/// <summary>
		/// Compute the product of two Matrix4x4.
		/// </summary>
		/// <param name="result">
		/// A <see cref="Matrix4x4"/> that stores the matrix multiplication result.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix4x4"/> that specify the right multiplication operand.
		/// </param>
		protected static void ComputeMatrixProduct(Matrix4x4 result, Matrix4x4 m, Matrix4x4 n)
		{
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

		/// <summary>
		/// Compute the product of Matrix4x4 by MatrixDouble4x4.
		/// </summary>
		/// <param name="result">
		/// A <see cref="Matrix4x4"/> that stores the matrix multiplication result.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="MatrixDouble4x4"/> that specify the right multiplication operand.
		/// </param>
		/// <remarks>
		/// If you to store the result in a <see cref="MatrixDouble4x4"/>, use the <see cref="MatrixDouble4x4.ComputeMatrixProduct(MatrixDouble4x4,MatrixDouble4x4,Matrix4x4)"/>.
		/// </remarks>
		protected static void ComputeMatrixProduct(Matrix4x4 result, Matrix4x4 m, MatrixDouble4x4 n)
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
				fixed (double* pn = n.MatrixBuffer) {
					prodFix[0x0] = (float)(pm[0x0]*pn[0x0] + pm[0x4]*pn[0x1] + pm[0x8]*pn[0x2] + pm[0xC]*pn[0x3]);
					prodFix[0x4] = (float)(pm[0x0]*pn[0x4] + pm[0x4]*pn[0x5] + pm[0x8]*pn[0x6] + pm[0xC]*pn[0x7]);
					prodFix[0x8] = (float)(pm[0x0]*pn[0x8] + pm[0x4]*pn[0x9] + pm[0x8]*pn[0xA] + pm[0xC]*pn[0xB]);
					prodFix[0xC] = (float)(pm[0x0]*pn[0xC] + pm[0x4]*pn[0xD] + pm[0x8]*pn[0xE] + pm[0xC]*pn[0xF]);

					prodFix[0x1] = (float)(pm[0x1]*pn[0x0] + pm[0x5]*pn[0x1] + pm[0x9]*pn[0x2] + pm[0xD]*pn[0x3]);
					prodFix[0x5] = (float)(pm[0x1]*pn[0x4] + pm[0x5]*pn[0x5] + pm[0x9]*pn[0x6] + pm[0xD]*pn[0x7]);
					prodFix[0x9] = (float)(pm[0x1]*pn[0x8] + pm[0x5]*pn[0x9] + pm[0x9]*pn[0xA] + pm[0xD]*pn[0xB]);
					prodFix[0xD] = (float)(pm[0x1]*pn[0xC] + pm[0x5]*pn[0xD] + pm[0x9]*pn[0xE] + pm[0xD]*pn[0xF]);

					prodFix[0x2] = (float)(pm[0x2]*pn[0x0] + pm[0x6]*pn[0x1] + pm[0xA]*pn[0x2] + pm[0xE]*pn[0x3]);
					prodFix[0x6] = (float)(pm[0x2]*pn[0x4] + pm[0x6]*pn[0x5] + pm[0xA]*pn[0x6] + pm[0xE]*pn[0x7]);
					prodFix[0xA] = (float)(pm[0x2]*pn[0x8] + pm[0x6]*pn[0x9] + pm[0xA]*pn[0xA] + pm[0xE]*pn[0xB]);
					prodFix[0xE] = (float)(pm[0x2]*pn[0xC] + pm[0x6]*pn[0xD] + pm[0xA]*pn[0xE] + pm[0xE]*pn[0xF]);

					prodFix[0x3] = (float)(pm[0x3]*pn[0x0] + pm[0x7]*pn[0x1] + pm[0xB]*pn[0x2] + pm[0xF]*pn[0x3]);
					prodFix[0x7] = (float)(pm[0x3]*pn[0x4] + pm[0x7]*pn[0x5] + pm[0xB]*pn[0x6] + pm[0xF]*pn[0x7]);
					prodFix[0xB] = (float)(pm[0x3]*pn[0x8] + pm[0x7]*pn[0x9] + pm[0xB]*pn[0xA] + pm[0xF]*pn[0xB]);
					prodFix[0xF] = (float)(pm[0x3]*pn[0xC] + pm[0x7]*pn[0xD] + pm[0xB]*pn[0xE] + pm[0xF]*pn[0xF]);
				}
			}
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from MatrixDouble4x4 to Matrix4x4 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="MatrixDouble4x4"/> to be converted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static explicit operator Matrix4x4(MatrixDouble4x4 a)
		{
			if (a == null)
				return (null);
			
			Matrix4x4 matrix = new Matrix4x4();

			for (int i = 0; i < 16; i++)
				matrix.MatrixBuffer[i] = (float)a.MatrixBuffer[i];

			return (matrix);
		}

#if HAVE_NUMERICS

		/// <summary>
		/// Cast from Matrix4x4 to System.Numerics.Matrix4x4.
		/// </summary>
		/// <param name="m"></param>
		public static implicit operator Mat4x4(Matrix4x4 m)
		{
			return (new Mat4x4(
				m.MatrixBuffer[0x0], m.MatrixBuffer[0x4], m.MatrixBuffer[0x8], m.MatrixBuffer[0xC],
				m.MatrixBuffer[0x1], m.MatrixBuffer[0x5], m.MatrixBuffer[0x9], m.MatrixBuffer[0xD],
				m.MatrixBuffer[0x2], m.MatrixBuffer[0x6], m.MatrixBuffer[0xA], m.MatrixBuffer[0xE],
				m.MatrixBuffer[0x3], m.MatrixBuffer[0x7], m.MatrixBuffer[0xB], m.MatrixBuffer[0xF]
			));
		}

		/// <summary>
		/// Cast from System.Numerics.Matrix4x4 to Matrix4x4.
		/// </summary>
		/// <param name="m"></param>
		public static implicit operator Matrix4x4(Mat4x4 m)
		{
			Matrix4x4 v = new Matrix4x4();

			CopyMat4x4(v, m);

			return (v);
		}

		private static void CopyMat4x4(Matrix4x4 matrix, Mat4x4 m)
		{
			unsafe
			{
				fixed (float *vm = matrix.MatrixBuffer) {
					vm[0x0] = m.M11; vm[0x4] = m.M12; vm[0x8] = m.M13; vm[0xC] = m.M14;
					vm[0x1] = m.M21; vm[0x5] = m.M22; vm[0x9] = m.M23; vm[0xD] = m.M24;
					vm[0x2] = m.M31; vm[0x6] = m.M32; vm[0xA] = m.M33; vm[0xE] = m.M34;
					vm[0x3] = m.M41; vm[0x7] = m.M42; vm[0xB] = m.M43; vm[0xF] = m.M44;
				}
			}
		}

#endif

		#endregion
		
		#region Methods

		/// <summary>
		/// Compute the complement matrix.
		/// </summary>
		/// <param name="c">
		/// A <see cref="UInt32"/> that specify the index of the column to exclude in complement
		/// matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the index of the row to exclude in complement
		/// matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IMatrix3x3"/> that is the complement matrix constructed from this IMatrix4x4,
		/// excluding the column <paramref name="c"/> and row <paramref name="r"/>.
		/// </returns>
		public Matrix3x3 GetComplementMatrix(uint c, uint r)
		{
			return (new Matrix3x3(this, c, r));
		}

		/// <summary>
		/// Compute the transpose of this Matrix4x4.
		/// </summary>
		/// <returns>
		/// A <see cref="Matrix4x4"/> which hold the transpose of this Matrix4x4.
		/// </returns>
		public new Matrix4x4 Transpose()
		{
			Matrix4x4 transpose = new Matrix4x4();

			// Transpose matrix
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		#endregion

		#region Matrix Overrides

		/// <summary>
		/// Clone this Matrix4x4.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this Matrix4x4.
		/// </returns>
		public override Matrix Clone()
		{
			return (new Matrix4x4(this));
		}

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="Matrix"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0.
		/// </exception>
		public new Matrix4x4 GetInverseMatrix()
		{
#if ENABLE_INVERSE
			float[] m = ToArray();
			float[] inv = new float[16], invOut = new float[16];
			float det;
			int i;

			inv[0] = m[5]  * m[10] * m[15] - 
					 m[5]  * m[11] * m[14] - 
					 m[9]  * m[6]  * m[15] + 
					 m[9]  * m[7]  * m[14] +
					 m[13] * m[6]  * m[11] - 
					 m[13] * m[7]  * m[10];

			inv[4] = -m[4]  * m[10] * m[15] + 
					  m[4]  * m[11] * m[14] + 
					  m[8]  * m[6]  * m[15] - 
					  m[8]  * m[7]  * m[14] - 
					  m[12] * m[6]  * m[11] + 
					  m[12] * m[7]  * m[10];

			inv[8] = m[4]  * m[9] * m[15] - 
					 m[4]  * m[11] * m[13] - 
					 m[8]  * m[5] * m[15] + 
					 m[8]  * m[7] * m[13] + 
					 m[12] * m[5] * m[11] - 
					 m[12] * m[7] * m[9];

			inv[12] = -m[4]  * m[9] * m[14] + 
					   m[4]  * m[10] * m[13] +
					   m[8]  * m[5] * m[14] - 
					   m[8]  * m[6] * m[13] - 
					   m[12] * m[5] * m[10] + 
					   m[12] * m[6] * m[9];

			inv[1] = -m[1]  * m[10] * m[15] + 
					  m[1]  * m[11] * m[14] + 
					  m[9]  * m[2] * m[15] - 
					  m[9]  * m[3] * m[14] - 
					  m[13] * m[2] * m[11] + 
					  m[13] * m[3] * m[10];

			inv[5] = m[0]  * m[10] * m[15] - 
					 m[0]  * m[11] * m[14] - 
					 m[8]  * m[2] * m[15] + 
					 m[8]  * m[3] * m[14] + 
					 m[12] * m[2] * m[11] - 
					 m[12] * m[3] * m[10];

			inv[9] = -m[0]  * m[9] * m[15] + 
					  m[0]  * m[11] * m[13] + 
					  m[8]  * m[1] * m[15] - 
					  m[8]  * m[3] * m[13] - 
					  m[12] * m[1] * m[11] + 
					  m[12] * m[3] * m[9];

			inv[13] = m[0]  * m[9] * m[14] - 
					  m[0]  * m[10] * m[13] - 
					  m[8]  * m[1] * m[14] + 
					  m[8]  * m[2] * m[13] + 
					  m[12] * m[1] * m[10] - 
					  m[12] * m[2] * m[9];

			inv[2] = m[1]  * m[6] * m[15] - 
					 m[1]  * m[7] * m[14] - 
					 m[5]  * m[2] * m[15] + 
					 m[5]  * m[3] * m[14] + 
					 m[13] * m[2] * m[7] - 
					 m[13] * m[3] * m[6];

			inv[6] = -m[0]  * m[6] * m[15] + 
					  m[0]  * m[7] * m[14] + 
					  m[4]  * m[2] * m[15] - 
					  m[4]  * m[3] * m[14] - 
					  m[12] * m[2] * m[7] + 
					  m[12] * m[3] * m[6];

			inv[10] = m[0]  * m[5] * m[15] - 
					  m[0]  * m[7] * m[13] - 
					  m[4]  * m[1] * m[15] + 
					  m[4]  * m[3] * m[13] + 
					  m[12] * m[1] * m[7] - 
					  m[12] * m[3] * m[5];

			inv[14] = -m[0]  * m[5] * m[14] + 
					   m[0]  * m[6] * m[13] + 
					   m[4]  * m[1] * m[14] - 
					   m[4]  * m[2] * m[13] - 
					   m[12] * m[1] * m[6] + 
					   m[12] * m[2] * m[5];

			inv[3] = -m[1] * m[6] * m[11] + 
					  m[1] * m[7] * m[10] + 
					  m[5] * m[2] * m[11] - 
					  m[5] * m[3] * m[10] - 
					  m[9] * m[2] * m[7] + 
					  m[9] * m[3] * m[6];

			inv[7] = m[0] * m[6] * m[11] - 
					 m[0] * m[7] * m[10] - 
					 m[4] * m[2] * m[11] + 
					 m[4] * m[3] * m[10] + 
					 m[8] * m[2] * m[7] - 
					 m[8] * m[3] * m[6];

			inv[11] = -m[0] * m[5] * m[11] + 
					   m[0] * m[7] * m[9] + 
					   m[4] * m[1] * m[11] - 
					   m[4] * m[3] * m[9] - 
					   m[8] * m[1] * m[7] + 
					   m[8] * m[3] * m[5];

			inv[15] = m[0] * m[5] * m[10] - 
					  m[0] * m[6] * m[9] - 
					  m[4] * m[1] * m[10] + 
					  m[4] * m[2] * m[9] + 
					  m[8] * m[1] * m[6] - 
					  m[8] * m[2] * m[5];

			det = m[0] * inv[0] + m[1] * inv[4] + m[2] * inv[8] + m[3] * inv[12];

			if (det == 0)
				throw new InvalidOperationException("not invertible");

			det = 1.0f / det;

			Matrix4x4 inverseMatrix = (Matrix4x4)Clone();
			for (i = 0; i < 16; i++)
				inverseMatrix.MatrixBuffer[i] = inv[i] * det;

			return (inverseMatrix);
#else
			return ((Matrix4x4)base.GetInverseMatrix());
#endif
		}

#endregion

		#region IMatrix4x4 Implementation

		/// <summary>
		/// Inverse of this IMatrix4x4.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix4x4"/> representing the inverse matrix of this IMatrix4x4.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this IMatrix4x4 is not square, or it's determinant is 0.0.
		/// </exception>
		IMatrix4x4 IMatrix4x4.GetInverseMatrix()
		{
			return (GetInverseMatrix());
		}

		/// <summary>
		/// Compute the complement matrix.
		/// </summary>
		/// <param name="c">
		/// A <see cref="UInt32"/> that specify the index of the column to exclude in complement
		/// matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the index of the row to exclude in complement
		/// matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IMatrix3x3"/> that is the complement matrix constructed from this IMatrix4x4,
		/// excluding the column <paramref name="c"/> and row <paramref name="r"/>.
		/// </returns>
		IMatrix3x3 IMatrix4x4.GetComplementMatrix(uint c, uint r)
		{
			return (new Matrix3x3(this, c, r));
		}

		/// <summary>
		/// Compute the transpose of this IMatrix4x4.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix4x4"/> which hold the transpose of this IMatrix4x4.
		/// </returns>
		IMatrix4x4 IMatrix4x4.Transpose()
		{
			return (Transpose());
		}

		/// <summary>
		/// Compute the product of this IMatrix with another IMatrix.
		/// </summary>
		/// <param name="a">
		/// A <see cref="IMatrix4x4"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="IMatrix"/> resulting from the product of this matrix and the matrix <paramref name="a"/>.
		/// </returns>
		IMatrix4x4 IMatrix4x4.Multiply(IMatrix4x4 a)
		{
			if (a == null)
				throw new ArgumentNullException("a");
			
			Matrix4x4 otherMatrix4x4 = a as Matrix4x4;
			if (otherMatrix4x4 != null)
				return (this * otherMatrix4x4);
			
			MatrixDouble4x4 otherMatrixDouble4x4 = a as MatrixDouble4x4;
			if (otherMatrixDouble4x4 != null)
				return ((MatrixDouble4x4)this * otherMatrixDouble4x4);
			
			throw new NotSupportedException("unknown IMatrix4x4 implementation");
		}

		/// <summary>
		/// Compute the product of a IMatrix4x4 with a Vertex4d (project a vertex on this matrix).
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> that specify the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> resulting from the product of this Vertex4d and the vector
		/// <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		Vertex4d IMatrix4x4.Multiply(Vertex4d v)
		{
			return ((Vertex4d)(this * (Vertex4f)v));
		}

		#endregion
	}
}
