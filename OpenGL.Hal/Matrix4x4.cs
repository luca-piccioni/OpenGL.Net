
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
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
		public Matrix4x4()
			: base(4, 4)
		{

		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="System.Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public Matrix4x4(float[] values)
			: base(values, 4, 4)
		{
		
		}

		/// <summary>
		/// Matrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/>
		/// </param>
		public Matrix4x4(Matrix4x4 m)
			: base(m)
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
			Vertex4f result;

			result.x = m[0, 0] * v.x + m[1, 0] * v.y + m[2, 0] * v.z + m[3, 0] * v.w;
			result.y = m[0, 1] * v.x + m[1, 1] * v.y + m[2, 1] * v.z + m[3, 1] * v.w;
			result.z = m[0, 2] * v.x + m[1, 2] * v.y + m[2, 2] * v.z + m[3, 2] * v.w;
			result.w = m[0, 3] * v.x + m[1, 3] * v.y + m[2, 3] * v.z + m[3, 3] * v.w;

			return (result);
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

		#endregion
		
		#region Methods

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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrices"></param>
		/// <returns></returns>
		public static Matrix4x4 Concatenate(params Matrix4x4[] matrices)
		{
			if (matrices.Length == 0)
				throw new ArgumentNullException("matrices", "no matric chain");

			Matrix4x4 m = new Matrix4x4();

			m.SetIdentity();

			unsafe {
				if (Memory.Matrix4x4_Concatenate != null) {
					List<GCHandle> gcHandles = new List<GCHandle>();

					try {
						float*[] matrixChain = new float*[matrices.Length + 1];

						GCHandle matrixData = GCHandle.Alloc(m.MatrixBuffer, GCHandleType.Pinned);
						gcHandles.Add(matrixData);
						matrixChain[0] = (float*)matrixData.AddrOfPinnedObject().ToPointer();

						for (int i = 0; i < matrices.Length; i++) {
							matrixData = GCHandle.Alloc(matrices[i].MatrixBuffer, GCHandleType.Pinned);
							gcHandles.Add(matrixData);

							matrixChain[i + 1] = (float*)matrixData.AddrOfPinnedObject().ToPointer();
						}

						Memory.Matrix4x4_Concatenate(matrixChain, (uint)matrixChain.Length);

					} finally {
						foreach (GCHandle gcHandle in gcHandles)
							gcHandle.Free();
					}
				} else {
					foreach (Matrix4x4 matrix in matrices)
						m = m * matrix;
				}
			}

			return (m);
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
#if XXX
			float px = Math.Abs(this[0, 3]), py = Math.Abs(this[1, 3]), pz = Math.Abs(this[2, 3]), ps = Math.Abs(this[3, 3] - 1.0f);

			if ((px > Single.Epsilon) || (py > Single.Epsilon) || (pz > Single.Epsilon) || (ps > Single.Epsilon))
#endif
				return ((Matrix4x4)base.GetInverseMatrix());	// Most general case, but rare
#if XXX
			else {
				Matrix3x3 rotMatrix = new Matrix3x3(this, 3, 3);
				Matrix4x4 inverseMatrix = (Matrix4x4) Clone();

				// Invert rotation matrix
				rotMatrix = rotMatrix.GetInverseMatrix();
				
				unsafe {
					fixed (float* src = rotMatrix.MatrixBuffer)
					fixed (float* dst = inverseMatrix.MatrixBuffer) {

						// Copy rotation matrix into the inverse
						dst[0] = src[0]; dst[4] = src[3]; dst[8]  = src[6];
						dst[1] = src[1]; dst[5] = src[4]; dst[9]  = src[7];
						dst[2] = src[2]; dst[6] = src[5]; dst[10] = src[8];
						dst[3] = 0.0f;   dst[7] = 0.0f;   dst[11] = 0.0f;   dst[15] = 1.0f;
					}

					fixed (float* src = MatrixBuffer)
					fixed (float* dst = inverseMatrix.MatrixBuffer) {

						// Negate translation
						dst[12] = -src[12];
						dst[13] = -src[13];
						dst[14] = -src[14];

					}
				}

				return (inverseMatrix);
			}
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
		/// A <see cref="System.UInt32"/> that specify the index of the column to exclude in complement
		/// matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the index of the row to exclude in complement
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
