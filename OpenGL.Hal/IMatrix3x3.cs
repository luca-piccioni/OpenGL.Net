
// Copyright (C) 2013-2015 Luca Piccioni
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
		/// A <see cref="Vertex3d"/> that specifies the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> resulting from the product of this Vertex4d and the vector
		/// <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		Vertex3d Multiply(Vertex3d v);

		#endregion
	}
}
