
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
	/// Common interface implemented by <see cref="Matrix"/> and <see cref="MatrixDouble"/> classes.
	/// </summary>
	public interface IMatrix : IEquatable<IMatrix>
	{
		#region Extents

		/// <summary>
		/// Matrix width (column count).
		/// </summary>
		uint Width { get; }

		/// <summary>
		/// Matrix height (row count).
		/// </summary>
		uint Height { get; }

		/// <summary>
		/// Determine whether this IMatrix is square.
		/// </summary>
		bool IsSquare { get; }

		#endregion

		#region Set

		/// <summary>
		/// Set IMatrix components.
		/// </summary>
		/// <param name="matrix">
		/// A <see cref="IMatrix"/> the matrix components.
		/// </param>
		void Set(IMatrix matrix);

		/// <summary>
		/// Set to void matrix (all components set to zero).
		/// </summary>
		void SetVoid();

		#endregion

		#region Square Matrix

		/// <summary>
		/// Set to identity matrix.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this IMatrix is not square.
		/// </exception>
		void SetIdentity();

		/// <summary>
		/// Determine whether this matrix is an identity.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating that this matrix is identity.
		/// </returns>
		bool IsIdentity();

		/// <summary>
		/// Determine whether this matrix is an identity.
		/// </summary>
		/// <param name="precision">
		/// A <see cref="Double"/> that specify the precision used for testing identity.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating that this matrix is identity.
		/// </returns>
		/// <remarks>
		/// <para>This method can be used for testing matrix identity with a specific range of approximation.</para>
		/// <para>For a reasonable precision for matrices having translations and rotations use <see cref="IsIdentity()"/>.</para>
		/// </remarks>
		bool IsIdentity(double precision);

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0.
		/// </exception>
		IMatrix GetInverseMatrix();

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this IMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix"/> which hold the transpose of this Matrix.
		/// </returns>
		IMatrix Transpose();

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
		/// It returns a <see cref="IMatrix"/> that is the complement matrix constructed from this IMatrix,
		/// excluding the column <paramref name="c"/> and row <paramref name="r"/>.
		/// </returns>
		IMatrix GetComplementMatrix(uint c, uint r);

		/// <summary>
		/// Compute the product of this IMatrix with another IMatrix.
		/// </summary>
		/// <param name="a">
		/// A <see cref="IMatrix"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="IMatrix"/> resulting from the product of this matrix and the matrix <paramref name="a"/>.
		/// </returns>
		IMatrix Multiply(IMatrix a);

		/// <summary>
		/// Get a matrix column.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the column index.
		/// </param>
		/// <returns>
		/// It returns the column components.
		/// </returns>
		double[] GetColumn(uint index);

		/// <summary>
		/// Get a matrix row.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the row index.
		/// </param>
		/// <returns>
		/// It returns the row components.
		/// </returns>
		double[] GetRow(uint index);

		/// <summary>
		/// Returns an array representation of this matrix, in column-major order.
		/// </summary>
		/// <returns>
		/// The array representing this matrix components.
		/// </returns>
		double[] ToArray();

		#endregion

		#region Operators

		/// <summary>
		/// IMatrix component indexer.
		/// </summary>
		/// <param name="c">
		/// A <see cref="UInt32"/> the specify the column index (zero based).
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> the specify the row index (zero based).
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="c"/> is greater than <see name="Matrix.Width"/> column count, or if <paramref name="r"/>
		/// is greater than <see name="Matrix.Height"/> row count.
		/// </exception>
		double this[uint c, uint r] { get; set; }

		#endregion
	}
}
