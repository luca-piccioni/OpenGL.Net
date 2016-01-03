
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
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Generic matrix.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class defines a generic matrix and the most common operations on it.
	/// </para>
	/// </remarks>
	public class MatrixDouble : IMatrix, IEquatable<MatrixDouble>
	{
		#region Constructors

		/// <summary>
		/// Construct a matrix.
		/// </summary>
		/// <remarks>
		/// The matrix components are all zeroes.
		/// </remarks>
		/// <param name="c">
		/// A <see cref="System.UInt32"/> that specify the matrix colum count.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the matrix row count.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw is <paramref name="c"/> or <paramref name="r"/> equals to 0.
		/// </exception>
		public MatrixDouble(uint c, uint r)
		{
			if (c == 0)
				throw new ArgumentException("invalid", "c");
			if (r == 0)
				throw new ArgumentException("invalid", "r");

			// Store matrix extents
			mWidth = c; mHeight = r;
			// Allocate matrix
			MatrixBuffer = new double[mWidth * mHeight];
		}

		/// <summary>
		/// Construct a matrix that is a complement matrix of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/>
		/// </param>
		/// <param name="c">
		/// A <see cref="System.UInt32"/>  that specify the index of the column that is excluded for
		/// computing the complement matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the index of the row that is excluded for
		/// computing the complement matrix.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="m"/> is has width or height less or equal to one.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater or equal to <paramref name="m"/> column count,
		/// or if <paramref name="r"/> is greater or equal to <paramref name="m"/> row count.
		/// </exception>
		public MatrixDouble(MatrixDouble m, uint c, uint r)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if ((m.mWidth <= 1) || (m.mHeight <= 1))
				throw new ArgumentException("too small", "m");
			if (c >= m.mWidth)
				throw new ArgumentOutOfRangeException("c", c, "column index greater than matrix width");
			if (r >= m.mHeight)
				throw new ArgumentOutOfRangeException("r", r, "row index greater than matrix height");

			// Store matrix extents
			mWidth = m.mWidth - 1; mHeight = m.mHeight - 1;
			// Allocate matrix
			MatrixBuffer = new double[mWidth * mHeight];
			// Copy complement matrix components (exclude colum c and row r)
			for (uint ic = 0; ic < mWidth; ic++)
				for (uint ir = 0; ir < mHeight; ir++)
					this[ic,ir] = m[(ic<c)?ic:ic+1,(ir<r)?ir:ir+1];
		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="System.Double"/>, representing the matrix components in column-major order.
		/// </param>
		/// <param name="c">
		/// A <see cref="System.UInt32"/> that specify the matrix colums count.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the matrix rows count.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="c"/> or <paramref name="r"/> are zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from <paramref name="c"/> multiplied with <paramref name="r"/>.
		/// </exception>
		public MatrixDouble(double[] values, uint c, uint r)
		{
			if (values == null)
				throw new ArgumentNullException("values");
			if (c == 0)
				throw new ArgumentException("too small", "c");
			if (r == 0)
				throw new ArgumentException("too small", "r");
			if (values.Length != c * r)
				throw new ArgumentException("array length mismatch");

			// Store matrix extents
			mWidth = c; mHeight = r;
			// Allocate matrix
			MatrixBuffer = new double[values.Length];
			// Copy complement matrix components (exclude colum c and row r)
			Array.Copy(values, MatrixBuffer, values.Length);
		}

		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public MatrixDouble(MatrixDouble m)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Store matrix extents
			mWidth = m.mWidth; mHeight = m.mHeight;
			// Allocate matrix
			MatrixBuffer = new double[mWidth * mHeight];

			// Copy matrix components
			unsafe {
				fixed (double* matrix = MatrixBuffer)
				fixed (double* otherMatrix = m.MatrixBuffer)
				{
					uint length = mWidth * mHeight;

					for (int i = 0; i < length; i++)
						matrix[i] = otherMatrix[i];
				}
			}
		}
		
		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="IMatrix"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public MatrixDouble(IMatrix m)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			
			if (m is MatrixDouble) {
				// Store matrix extents
				mWidth = m.Width; mHeight = m.Height;
				// Allocate matrix
				MatrixBuffer = new double[mWidth * mHeight];
	
				// Copy matrix components
				unsafe {
					fixed (double* matrix = MatrixBuffer)
					fixed (double* otherMatrix = ((MatrixDouble)m).MatrixBuffer)
					{
						uint length = mWidth * mHeight;
	
						for (int i = 0; i < length; i++)
							matrix[i] = otherMatrix[i];
					}
				}
			} else {
				// Store matrix extents
				mWidth = m.Width; mHeight = m.Height;
				// Allocate matrix
				MatrixBuffer = new double[mWidth * mHeight];
	
				// Copy matrix components
				unsafe {
					fixed (double* matrix = MatrixBuffer)
					fixed (float* otherMatrix = ((Matrix)m).MatrixBuffer)
					{
						uint length = mWidth * mHeight;
	
						for (int i = 0; i < length; i++)
							matrix[i] = otherMatrix[i];
					}
				}
			}
		}

		/// <summary>
		/// Matrix components.
		/// </summary>
		protected internal double[] MatrixBuffer;

		#endregion

		#region Operators

		/// <summary>
		/// Add two Matrix.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="MatrixDouble"/> that specify the left Matrix.
		/// </param>
		/// <param name="m2">
		/// A <see cref="MatrixDouble"/> that specify the right Matrix.
		/// </param>
		/// <returns>
		/// A <see cref="MatrixDouble"/> resulting from the sum of the two Matrix specified as parameters.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m1"/> or <paramref name="m2"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m1"/> size and <paramref name="m2"/> size does not match.
		/// </exception>
		public static MatrixDouble operator+(MatrixDouble m1, MatrixDouble m2)
		{
			if (m1 == null)
				throw new ArgumentNullException("m1");
			if (m2 == null)
				throw new ArgumentNullException("m2");
			if (m1.mWidth != m2.mWidth)
				throw new ArgumentException("matrices width mismatch");
			if (m1.mHeight != m2.mHeight)
				throw new ArgumentException("matrices height mismatch");

			// Allocate product matrix
			MatrixDouble sum = new MatrixDouble(m1.mWidth, m1.mHeight);

			unsafe {
				fixed (double* matrix1 = m1.MatrixBuffer)
				fixed (double* matrix2 = m2.MatrixBuffer)
				fixed (double* sumMatrix = sum.MatrixBuffer)
				{
					uint length = m1.mWidth * m1.Height;

					for (uint i = 0; i < length; i++)
						sumMatrix[i] = matrix1[i] + matrix2[i];	
				}
			}

			return (sum);
		}

		/// <summary>
		/// Multiply a matrix with a scalar value.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> that specify the left Matrix.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="System.Double"/> that multiply all matrix components.
		/// </param>
		/// <returns>
		/// A <see cref="MatrixDouble"/> resulted from the operation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public static MatrixDouble operator*(MatrixDouble m, double scalar)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Allocate product matrix
			MatrixDouble prod = new MatrixDouble(m.mWidth, m.mHeight);

			unsafe {
				fixed (double* matrix = m.MatrixBuffer)
				fixed (double* prodMatrix = prod.MatrixBuffer) {
					uint length = m.mWidth * m.Height;

					for (uint i = 0; i < length; i++)
						prodMatrix[i] = matrix[i] * scalar;	
				}
			}

			return (prod);
		}

		/// <summary>
		/// Divide a matrix with a scalar value.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> that specify the left Matrix.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="System.Double"/> that divide all matrix components.
		/// </param>
		/// <returns>
		/// A <see cref="MatrixDouble"/> resulted from the operation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public static MatrixDouble operator /(MatrixDouble m, double scalar)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Allocate product matrix
			MatrixDouble div = new MatrixDouble(m.mWidth, m.mHeight);

			unsafe {
				fixed (double* matrix = m.MatrixBuffer)
				fixed (double* divMatrix = div.MatrixBuffer)
				{
					uint length = m.mWidth * m.Height;

					for (uint i = 0; i < length; i++)
						divMatrix[i] = matrix[i] / scalar;
				}
			}

			return (div);
		}

		/// <summary>
		/// Multiply two Matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="MatrixDouble"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="MatrixDouble"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> or <paramref name="n"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m"/> width is different from <paramref name="n"/> height.
		/// </exception>
		public static MatrixDouble operator *(MatrixDouble m, MatrixDouble n)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if (n == null)
				throw new ArgumentNullException("n");
			if (m.mWidth != n.mHeight)
				throw new ArgumentException("matrices width/height mismatch");

			// Allocate product matrix
			MatrixDouble prod = new MatrixDouble(n.mHeight, m.mWidth);

			unsafe {
				fixed (double* pm = m.MatrixBuffer)
				fixed (double* pn = n.MatrixBuffer)
				fixed (double* prodMatrix = prod.MatrixBuffer)
				{
					uint w = m.mWidth, h1 = m.Height;

					// Compute matrix product
					for (uint r = 0; r < h1; r++) {
						for (uint c = 0; c < w; c++) {
							double s = 0.0f;

							for (uint i = 0; i < h1; i++)
								s += pm[i * h1 + r] * pn[c * h1 + i];

							prodMatrix[c * h1 + r] = s;
						}
					}
				}
			}

			return (prod);
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from Matrix to MatrixDouble operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix"/> to be converted to <see cref="MatrixDouble"/>.
		/// </param>
		/// <returns>
		/// A <see cref="MatrixDouble"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static implicit operator MatrixDouble(Matrix a)
		{
			MatrixDouble matrix = new MatrixDouble(a.Width, a.Height);

			for (int i = 0; i < a.Width * a.Height; i++)
				matrix.MatrixBuffer[i] = a.MatrixBuffer[i];

			return (matrix);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1"></param>
		/// <param name="m2"></param>
		/// <returns></returns>
		public static bool operator ==(MatrixDouble m1, MatrixDouble m2)
		{
			return (Equals(m1, m2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1"></param>
		/// <param name="m2"></param>
		/// <returns></returns>
		public static bool operator !=(MatrixDouble m1, MatrixDouble m2)
		{
			return (!Equals(m1, m2));
		}

		#endregion

		#region Functions

		/// <summary>
		/// Set to arbitrary matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/>
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m"/> width and height are not equal to this Matrix width and height.
		/// </exception>
		public void Set(MatrixDouble m)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if (m.mWidth != Width)
				throw new ArgumentException("matrix width mismatch");
			if (m.mHeight != Height)
				throw new ArgumentException("matrix height mismatch");

			unsafe {
				fixed (double* matrix = MatrixBuffer)
				fixed (double* otherMatrix = m.MatrixBuffer)
				{
					uint length = m.mWidth * m.Height;

					for (uint i = 0; i < length; i++)
						matrix[i] = otherMatrix[i];
				}
			}
		}
		
		/// <summary>
		/// Set to arbitrary matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/>
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m"/> width and height are not equal to this Matrix width and height.
		/// </exception>
		public void Set(Matrix m)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if (m.Width != Width)
				throw new ArgumentException("matrix width mismatch");
			if (m.Height != Height)
				throw new ArgumentException("matrix height mismatch");

			unsafe {
				fixed (double* matrix = MatrixBuffer)
				fixed (float* otherMatrix = m.MatrixBuffer)
				{
					uint length = m.Width * m.Height;

					for (uint i = 0; i < length; i++)
						matrix[i] = otherMatrix[i];
				}
			}
		}

		/// <summary>
		/// Compute the transpose of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="MatrixDouble"/> which hold the transpose of this Matrix.
		/// </returns>
		public virtual MatrixDouble Transpose()
		{
			MatrixDouble transpose;

			if (IsSquare)
				transpose = Clone();					// Allow to mantain type consistency with Matrix3x3, Matrix4x4 and other derived square matrices
			else
				transpose = new MatrixDouble(Height, Width);	// Not square matrix should be a Matrix instance

			// Transpose matrix
			for (uint c = 0; c < Width; c++)
				for (uint r = 0; r < Height; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		/// <summary>
		/// Clone this Matrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this Matrix.
		/// </returns>
		public virtual MatrixDouble Clone()
		{
			return (new MatrixDouble(this));
		}

		#endregion

		#region Square Matrix Functions

		/// <summary>
		/// Compute the matrix determinant.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Matrix is not square.
		/// </exception>
		public virtual double GetDeterminant()
		{
			if (IsSquare == false)
				throw new InvalidOperationException("not square");

			if (mWidth > 2) {
				double d = 0.0f;

				for (uint r = 0; r < Height; r++) {
					MatrixDouble complement = new MatrixDouble(this, 0, r);
					double sng = ((r % 2) == 0) ? +1.0 : -1.0;

					d +=  sng * this[0, r] * complement.GetDeterminant();
				}

				return (d);
			} else {

				//     | a b |
				// m = | c d |
				//
				// det = ad - bc

				return (this[0, 0] * this[1, 1] - this[1, 0] * this[0, 1]);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="c"></param>
		/// <param name="r"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="m"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="c"/> is greater than <paramref name="m"/> column count, or if <paramref name="r"/>
		/// is greater than <paramref name="m"/> row count.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="m"/> is not a square matrix.
		/// </exception>
		private static double GetComplement(MatrixDouble m, uint c, uint r)
		{
			double sign;

			if (m == null)
				throw new ArgumentNullException("m");
			if (m.IsSquare == false)
				throw new InvalidOperationException("non-square");
			if (c >= m.mWidth)
				throw new ArgumentException("out of bounds", "c");
			if (r >= m.mHeight)
				throw new ArgumentException("out of bounds", "r");

			// Determine complement sign
			if (((c + r) % 2) == 0) sign = 1.0f; else sign = -1.0f;

			// Compute matrix component complement
			if (m.mWidth > 2) {
				MatrixDouble complement = new MatrixDouble(m, c, r);

				return (sign * complement.GetDeterminant());
			} else
				return (sign * m[(c==0)?1:(uint)0,(r==0)?1:(uint)0]);
		}

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="MatrixDouble"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0.
		/// </exception>
		public virtual MatrixDouble GetInverseMatrix()
		{
			// Matrix shall be square
			if (IsSquare == false)
				throw new InvalidOperationException("non-square");

			// Matrix shall not be singular
			double d = GetDeterminant();
			if (Math.Abs(d) < Double.Epsilon)
				throw new InvalidOperationException("singular");

			// Compute inverse matrix
			MatrixDouble iMatrix = Clone();

			for (uint c = 0; c < Width; c++)
				for (uint r = 0; r < Height; r++)
					iMatrix[r, c] = GetComplement(this, c, r) / d;

			return (iMatrix);
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="System.String"/> that represents this Matrix.
		/// </returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("MatrixDouble{0}x{1}:", Width, Height);
			for (uint c = 0; c < Width; c++) {
				sb.Append(" [");
				for (uint r = 0; r < Height; r++)
					sb.AppendFormat("{0}{1}", this[c, r], (r < Height - 1) ? ", " : String.Empty);
				sb.Append("]");
			}

			return (sb.ToString());
		}

		#endregion

		#region IMatrix Implementation

		/// <summary>
		/// Matrix width (column count).
		/// </summary>
		public uint Width
		{
			get { return (mWidth); }
		}

		/// <summary>
		/// Matrix height (row count).
		/// </summary>
		public uint Height
		{
			get { return (mHeight); }
		}

		/// <summary>
		/// Determine whether this matrix is square.
		/// </summary>
		public bool IsSquare
		{
			get { return (Width == Height); }
		}

		/// <summary>
		/// Set IMatrix components.
		/// </summary>
		/// <param name="matrix">
		/// A <see cref="IMatrix"/> the matrix components.
		/// </param>
		public void Set(IMatrix matrix)
		{
			if (matrix == null)
				throw new ArgumentNullException("matrix");
			if (matrix.Width != Width)
				throw new ArgumentException("width mismatch", "matrix");
			if (matrix.Height != Height)
				throw new ArgumentException("height mismatch", "matrix");

			for (uint c = 0; c < Width; c++)
				for (uint r = 0; r < Height; r++)
					this[c, r] = matrix[c, r];
		}

		/// <summary>
		/// Set to void matrix.
		/// </summary>
		public void SetVoid()
		{
			unsafe {
				fixed (double* matrix = MatrixBuffer) {
					uint length = mWidth * Height;

					for (uint i = 0; i < length; i++)
						matrix[i] = 0.0f;
				}
			}
		}

		/// <summary>
		/// Set to identity matrix.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Matrix is not square.
		/// </exception>
		public void SetIdentity()
		{
			if (IsSquare == false)
				throw new InvalidOperationException("non-square");

			unsafe {
				fixed (double* matrix = MatrixBuffer) {
					for (uint c = 0; c < mWidth; c++)
						for (uint r = 0; r < mHeight; r++)
							if (c == r) matrix[c * mWidth + r] = 1.0; else matrix[c * mWidth + r] = 0.0;
				}
			}
		}

		/// <summary>
		/// Determine whether this matrix is an identity.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating that this matrix is identity.
		/// </returns>
		public bool IsIdentity()
		{
			return (IsIdentity(1e-6f));
		}

		/// <summary>
		/// Determine whether this matrix is an identity.
		/// </summary>
		/// <param name="precision">
		/// A <see cref="System.Double"/> that specify the precision used for testing identity.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating that this matrix is identity.
		/// </returns>
		/// <remarks>
		/// <para>This method can be used for testing matrix identity with a specific range of approximation.</para>
		/// <para>For a reasonable precision for matrices having translations and rotations use <see cref="IsIdentity()"/>.</para>
		/// </remarks>
		public bool IsIdentity(double precision)
		{
			if (IsSquare == false)
				throw new InvalidOperationException("non-square");

			unsafe {
				fixed (double* matrix = MatrixBuffer) {
					for (uint c = 0; c < mWidth; c++) {
						for (uint r = 0; r < mHeight; r++) {
							double value = matrix[c * mWidth + r];

							if ((c != r) && (Math.Abs(value) > precision))
								return (false);
							if ((c == r) && (Math.Abs(1.0 - value) > precision))
								return (false);
						}
					}

					return (true);
				}
			}
		}

		/// <summary>
		/// Compute the transpose of this IMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix"/> which hold the transpose of this Matrix.
		/// </returns>
		IMatrix IMatrix.Transpose()
		{
			return (Transpose());
		}

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0.
		/// </exception>
		IMatrix IMatrix.GetInverseMatrix()
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
		/// It returns a <see cref="IMatrix"/> that is the complement matrix constructed from this IMatrix,
		/// excluding the column <paramref name="c"/> and row <paramref name="r"/>.
		/// </returns>
		IMatrix IMatrix.GetComplementMatrix(uint c, uint r)
		{
			return (new MatrixDouble(this, c, r));
		}

		/// <summary>
		/// Multiply this IMatrix with another IMatrix.
		/// </summary>
		/// <param name="a">
		/// A <see cref="IMatrix"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="IMatrix"/> resulting from the product of this matrix and the matrix <paramref name="a"/>.
		/// </returns>
		public IMatrix Multiply(IMatrix a)
		{
			MatrixDouble otherMatrix = a as MatrixDouble;
			
			// MatrixDouble * MatrixDouble shortcut
			if (otherMatrix != null)
				return (this * otherMatrix);
			
			// Allocate product matrix
			MatrixDouble prod = new MatrixDouble(a.Height, mWidth);

			uint w = mWidth, h = mHeight;

			// Compute matrix product
			for (uint r = 0; r < h; r++) {
				for (uint c = 0; c < w; c++) {
					double s = 0.0f;

					for (uint i = 0; i < h; i++)
						s += this[i, r] * a[c, i];

					prod[c, r] = s;
				}
			}
			
			return (prod);
		}

		/// <summary>
		/// Get a matrix column.
		/// </summary>
		/// <param name="index">
		/// A <see cref="System.UInt32"/> that specify the column index.
		/// </param>
		/// <returns>
		/// It returns the column components.
		/// </returns>
		public double[] GetColumn(uint index)
		{
			double[] column = new double[Height];

			for (uint i = 0; i < Height; i++)
				column[i] = this[index, i];

			return (column);
		}

		/// <summary>
		/// Get a matrix row.
		/// </summary>
		/// <param name="index">
		/// A <see cref="System.UInt32"/> that specify the row index.
		/// </param>
		/// <returns>
		/// It returns the row components.
		/// </returns>
		public double[] GetRow(uint index)
		{
			double[] row = new double[Width];

			for (uint i = 0; i < Width; i++)
				row[i] = this[i, index];

			return (row);
		}

		/// <summary>
		/// Returns an array representation of this matrix, in column-major order.
		/// </summary>
		/// <returns>
		/// The array representing this matrix components.
		/// </returns>
		public double[] ToArray()
		{
			double[] matrixArray = new double[Width * Height];

			Array.Copy(MatrixBuffer, matrixArray, matrixArray.Length);

			return (matrixArray);
		}

		/// <summary>
		/// Matrix component indexer.
		/// </summary>
		/// <param name="c">
		/// A <see cref="System.Int32"/> the specify the column index (zero based).
		/// </param>
		/// <param name="r">
		/// A <see cref="System.Int32"/> the specify the row index (zero based).
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="c"/> is greater than <see name="MatrixDouble.Width"/> column count, or if <paramref name="r"/>
		/// is greater than <see name="MatrixDouble.Height"/> row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				if (c >= mWidth)
					throw new ArgumentException("colum index greater than column count", "c");
				if (r >= mHeight)
					throw new ArgumentException("row index greater than row count", "r");

				unsafe {
					fixed (double* matrix = MatrixBuffer) {
						return (matrix[c * mHeight + r]);
					}
				}
			}
			set
			{
				if (c >= mWidth)
					throw new ArgumentException("colum index greater than column count", "c");
				if (r >= mHeight)
					throw new ArgumentException("row index greater than row count", "r");
				unsafe {
					fixed (double* matrix = MatrixBuffer) {
						matrix[c * mHeight + r] = value;
					}
				}
			}
		}

		/// <summary>
		/// Indicates whether the this IMatrix is equal to another IMatrix.
		/// </summary>
		/// <param name="other">
		/// A <see cref="IMatrix"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IMatrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IMatrix other)
		{
			return (Equals((object)other));
		}

		/// <summary>
		/// Matrix width (column count).
		/// </summary>
		private readonly uint mWidth;

		/// <summary>
		/// Matrix height (row count).
		/// </summary>
		private readonly uint mHeight;

		#endregion

		#region IEquatable<MatrixDouble> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A MatrixDouble to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(MatrixDouble other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);
			if ((mWidth != other.Width) || (mHeight != other.mHeight))
				return (false);

			unsafe {
				fixed (double* m1Fix = MatrixBuffer)
				fixed (double* m2Fix = other.MatrixBuffer)
				{
					uint w = mWidth, h = Height;

					// Compute matrix product
					for (uint c = 0; c < w * h; c++) {
						if (Math.Abs(m1Fix[c] - m2Fix[c]) > 1e-6f) 
							return (false);
					}
				}
			}

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);
			if ((obj.GetType() != typeof(MatrixDouble)) && (obj.GetType().IsSubclassOf(typeof(MatrixDouble)) == false))
				return (false);

			return (Equals((MatrixDouble)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = MatrixBuffer.GetHashCode();

				result = (result * 397) ^ mWidth.GetHashCode();

				result = (result * 397) ^ mHeight.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}
