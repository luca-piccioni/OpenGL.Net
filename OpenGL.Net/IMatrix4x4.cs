
// Copyright (C) 2013-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;

namespace OpenGL
{
	/// <summary>
	/// Common interface implemented by <see cref="Matrix4x4"/> and <see cref="MatrixDouble4x4"/> classes.
	/// </summary>
	public interface IMatrix4x4 : IMatrix
	{
		#region Square Matrix

		/// <summary>
		/// Inverse of this IMatrix4x4.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix4x4"/> representing the inverse matrix of this IMatrix4x4.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this IMatrix4x4 determinant is 0.0.
		/// </exception>
		new IMatrix4x4 GetInverseMatrix();

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
		new IMatrix3x3 GetComplementMatrix(uint c, uint r);

		/// <summary>
		/// Compute the transpose of this IMatrix4x4.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix4x4"/> which hold the transpose of this IMatrix4x4.
		/// </returns>
		new IMatrix4x4 Transpose();

		/// <summary>
		/// Compute the product of this IMatrix with another IMatrix.
		/// </summary>
		/// <param name="a">
		/// A <see cref="IMatrix4x4"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="IMatrix"/> resulting from the product of this matrix and the matrix <paramref name="a"/>.
		/// </returns>
		IMatrix4x4 Multiply(IMatrix4x4 a);

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
		Vertex4d Multiply(Vertex4d v);

		#endregion
	}
}
