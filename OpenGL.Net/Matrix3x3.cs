
// Copyright (C) 2009-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Square matrix of 3x3 components.
	/// </summary>
	public class Matrix3x3 : Matrix, IMatrix3x3
	{
		#region Constructors

		/// <summary>
		/// Construct a 3x3 matrix, initialized to identity.
		/// </summary>
		public Matrix3x3()
			: base(3, 3)
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a complement matrix of a <see cref="Matrix4x4"/>.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> on which is computed the complement matrix.
		/// </param>
		/// <param name="c">
		/// A <see cref="UInt32"/> that specify the index of the column that is excluded for
		/// computing the complement matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the index of the row that is excluded for
		/// computing the complement matrix.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater or equal to <paramref name="m"/> column count,
		/// or if <paramref name="r"/> is greater or equal to <paramref name="m"/> row count.
		/// </exception>
		public Matrix3x3(Matrix4x4 m, uint c, uint r)
			: base(m, c, r)
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
		/// Exception throw if <paramref name="values"/> length differs from 9.
		/// </exception>
		public Matrix3x3(float[] values)
			: base(values, 3, 3)
		{
		
		}

		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public Matrix3x3(Matrix3x3 m)
			: base(m)
		{

		}

		#endregion

		#region Operators

		/// <summary>
		/// Compute the product of a Matrix3x3 with a Vertex3f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> that specify the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and
		/// the vector <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m"/> is null.
		/// </exception>
		public static Vertex3f operator *(Matrix3x3 m, Vertex3f v)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			Vertex3f result;

			result.x = m[0, 0] * v.x + m[1, 0] * v.y + m[2, 0] * v.z;
			result.y = m[0, 1] * v.x + m[1, 1] * v.y + m[2, 1] * v.z;
			result.z = m[0, 2] * v.x + m[1, 2] * v.y + m[2, 2] * v.z;

			return (result);
		}

		/// <summary>
		/// Compute the product of a Matrix3x3 with a Vertex4f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the right vector operand. This parameter is implicitly
		/// converted to a <see cref="Vertex3f"/> by using the explicit cast to (indeed performing the perspective
		/// division by the W component).
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and
		/// the vector <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m"/> is null.
		/// </exception>
		public static Vertex3f operator *(Matrix3x3 m, Vertex4f v)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			return (m * (Vertex3f) v);
		}

		/// <summary>
		/// Compute the product of two Matrix4x4.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x3"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x3"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3"/> resulting from the product of the matrix <paramref name="m1"/> and
		/// the matrix <paramref name="m2"/>. This operator is used to concatenate successive transformations.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m1"/> or <paramref name="m2"/> is null.
		/// </exception>
		public static Matrix3x3 operator *(Matrix3x3 m1, Matrix3x3 m2)
		{
			// Allocate product matrix
			Matrix3x3 prod = new Matrix3x3();

			// COmpute product
			ComputeMatrixProduct(prod, m1, m2);

			return (prod);
		}

		/// <summary>
		/// Compute the product of two Matrix3x3.
		/// </summary>
		/// <param name="result">
		/// A <see cref="Matrix3x3"/> that stores the matrix multiplication result.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix3x3"/> that specify the right multiplication operand.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="result"/>, <paramref name="m"/> or <paramref name="n"/> is null.
		/// </exception>
		private static void ComputeMatrixProduct(Matrix3x3 result, Matrix3x3 m, Matrix3x3 n)
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
				fixed (float* pn = n.MatrixBuffer) {
					prodFix[0] = pm[0] * pn[0] + pm[3] * pn[1] + pm[6] * pn[2];
					prodFix[3] = pm[0] * pn[3] + pm[3] * pn[4] + pm[6] * pn[5];
					prodFix[6] = pm[0] * pn[6] + pm[3] * pn[7] + pm[6] * pn[8];

					prodFix[1] = pm[1] * pn[0] + pm[4] * pn[1] + pm[7] * pn[2];
					prodFix[4] = pm[1] * pn[3] + pm[4] * pn[4] + pm[7] * pn[5];
					prodFix[7] = pm[1] * pn[6] + pm[4] * pn[7] + pm[7] * pn[8];

					prodFix[2] = pm[2] * pn[0] + pm[5] * pn[1] + pm[8] * pn[2];
					prodFix[5] = pm[2] * pn[3] + pm[5] * pn[4] + pm[8] * pn[5];
					prodFix[8] = pm[2] * pn[6] + pm[5] * pn[7] + pm[8] * pn[8];
				}
			}
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from MatrixDouble3x3 to Matrix3x3 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="MatrixDouble3x3"/> to be converted to <see cref="Matrix3x3"/>.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static explicit operator Matrix3x3(MatrixDouble3x3 a)
		{
			if (a == null)
				return (null);
			
			Matrix3x3 matrix = new Matrix3x3();

			for (int i = 0; i < 9; i++)
				matrix.MatrixBuffer[i] = (float)a.MatrixBuffer[i];

			return (matrix);
		}

		#endregion

		#region Functions

		/// <summary>
		/// Compute the transpose of this Matrix3x3.
		/// </summary>
		/// <returns>
		/// A <see cref="Matrix3x3"/> which hold the transpose of this Matrix3x3.
		/// </returns>
		public new Matrix3x3 Transpose()
		{
			Matrix3x3 t = new Matrix3x3();

			// Transpose matrix
			for (uint c = 0; c < 3; c++)
				for (uint r = 0; r < 3; r++)
					t[r, c] = this[c, r];

			return (t);
		}

		#endregion

		#region Matrix Overrides

		/// <summary>
		/// Clone this Matrix3x3.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this Matrix4x4.
		/// </returns>
		public override Matrix Clone()
		{
			return (new Matrix3x3(this));
		}

		/// <summary>
		/// Matrix determinant.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Matrix is not square.
		/// </exception>
		public override float GetDeterminant()
		{
			unsafe {
				fixed (float* m = MatrixBuffer) {

					//     | a b c |
					// m = | d e f |
					//     | g h k |
					//
					// det = a(ek - fh) + b(fg - kd) + c(dh - eg)

					return (
						m[0] * (m[4] * m[8] - m[7] * m[5]) +
						m[3] * (m[7] * m[2] - m[8] * m[1]) +
						m[6] * (m[1] * m[5] - m[4] * m[2])
						);
				}
			}
		}

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="Matrix"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0 (i.e. non-invertible).
		/// </exception>
		public new Matrix3x3 GetInverseMatrix()
		{
			//        | a b c |
			// m    = | d e f |
			//        | g h k |
			//
			//        | A B C |(T)
			// m^-1 = | D E F |    * (1 / det(m))
			//        | G H K |
			// 
			// A = +(e * k - f * h) = (e * k - f * h)
			// B = -(d * k - f * g) = (f * g - d * k)
			// C = +(d * h - e * g) = (d * h - e * g)
			// D = -(b * k - c * h) = (c * h - b * k)
			// E = +(a * k - c * g) = (a * k - c * g)
			// F = -(a * h - b * g) = (b * g - a * h)
			// G = +(b * f - c * e) = (b * f - c * e)
			// H = -(a * f - c * d) = (c * d - a * f)
			// K = +(a * e - b * d) = (a * e - b * d)

			float determinant = GetDeterminant();

			if (Math.Abs(determinant) < Single.Epsilon)
				throw new InvalidOperationException("non-invertible");

			Matrix3x3 inverse = new Matrix3x3();
			float inv = 1.0f / determinant;

			unsafe {
				fixed (float* m = MatrixBuffer) {
				fixed (float* mi = inverse.MatrixBuffer) {
						float a = m[0], b = m[3], c = m[6];
						float d = m[1], e = m[4], f = m[7];
						float g = m[2], h = m[5], k = m[8];

						mi[0] = (e * k - f * h) * inv;
						mi[1] = (f * g - d * k) * inv;
						mi[2] = (d * h - e * g) * inv;
						mi[3] = (c * h - b * k) * inv;
						mi[4] = (a * k - c * g) * inv;
						mi[5] = (b * g - a * h) * inv;
						mi[6] = (b * f - c * e) * inv;
						mi[7] = (c * d - a * f) * inv;
						mi[8] = (a * e - b * d) * inv;
				}
				}
			}

			return (inverse);
		}

		#endregion

		#region IMatrix3x3 Implementation

		/// <summary>
		/// Inverse of this IMatrix3x3.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix3x3"/> representing the inverse matrix of this IMatrix3x3.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this IMatrix3x3 determinant is 0.0.
		/// </exception>
		IMatrix3x3 IMatrix3x3.GetInverseMatrix()
		{
			return (GetInverseMatrix());
		}

		/// <summary>
		/// Compute the transpose of this IMatrix3x3.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix3x3"/> which hold the transpose of this IMatrix3x3.
		/// </returns>
		IMatrix3x3 IMatrix3x3.Transpose()
		{
			return (Transpose());
		}

		/// <summary>
		/// Compute the product of a IMatrix3x3 with a Vertex3d (project a vertex on this matrix).
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> that specify the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> resulting from the product of this Vertex4d and the vector
		/// <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		public Vertex3d Multiply(Vertex3d v)
		{
			return ((Vertex3d)(this * (Vertex3f)v));
		}

		#endregion
	}
}
