
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
	/// Common interface implemented by <see cref="Matrix3x3"/> and <see cref="MatrixDouble3x3"/> classes.
	/// </summary>
	public interface IMatrix3x3 : IMatrix
	{
		#region Square Matrix

		/// <summary>
		/// Inverse of this IMatrix3x3.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix3x3"/> representing the inverse matrix of this IMatrix3x3.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this IMatrix3x3 determinant is 0.0.
		/// </exception>
		new IMatrix3x3 GetInverseMatrix();

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this IMatrix3x3.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix3x3"/> which hold the transpose of this IMatrix3x3.
		/// </returns>
		new IMatrix3x3 Transpose();

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
		Vertex3d Multiply(Vertex3d v);

		#endregion
	}
}
