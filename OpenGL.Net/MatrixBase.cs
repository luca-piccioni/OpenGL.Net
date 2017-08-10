
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Text;

#if HAVE_NUMERICS
using System.Numerics;
#endif

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
	public class Matrix : IMatrix, IEquatable<Matrix>
	{
		#region Constructors

		/// <summary>
		/// Construct a matrix.
		/// </summary>
		/// <remarks>
		/// The matrix components are all zeroes.
		/// </remarks>
		/// <param name="c">
		/// A <see cref="UInt32"/> that specify the matrix colum count.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the matrix row count.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw is <paramref name="c"/> or <paramref name="r"/> equals to 0.
		/// </exception>
		public Matrix(uint c, uint r)
		{
			if (c == 0)
				throw new ArgumentException("invalid", "c");
			if (r == 0)
				throw new ArgumentException("invalid", "r");

			// Store matrix extents
			_Width = c; _Height = r;
			// Allocate matrix
			MatrixBuffer = new float[_Width * _Height];
		}

		/// <summary>
		/// Construct a matrix that is a complement matrix of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/>
		/// </param>
		/// <param name="c">
		/// A <see cref="UInt32"/>  that specify the index of the column that is excluded for
		/// computing the complement matrix.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the index of the row that is excluded for
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
		public Matrix(Matrix m, uint c, uint r)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if ((m._Width <= 1) || (m._Height <= 1))
				throw new ArgumentException("too small", "m");
			if (c >= m._Width)
				throw new ArgumentOutOfRangeException("c", c, "column index greater than matrix width");
			if (r >= m._Height)
				throw new ArgumentOutOfRangeException("r", r, "row index greater than matrix height");

			// Store matrix extents
			_Width = m._Width - 1; _Height = m._Height - 1;
			// Allocate matrix
			MatrixBuffer = new float[_Width * _Height];
			// Copy complement matrix components (exclude colum c and row r)
			for (uint ic = 0; ic < _Width; ic++)
				for (uint ir = 0; ir < _Height; ir++)
					this[ic,ir] = m[(ic<c)?ic:ic+1,(ir<r)?ir:ir+1];
		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <param name="c">
		/// A <see cref="UInt32"/> that specify the matrix colums count.
		/// </param>
		/// <param name="r">
		/// A <see cref="UInt32"/> that specify the matrix rows count.
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
		public Matrix(float[] values, uint c, uint r)
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
			_Width = c; _Height = r;
			// Allocate matrix
			MatrixBuffer = new float[values.Length];
			// Copy complement matrix components (exclude colum c and row r)
			Array.Copy(values, MatrixBuffer, values.Length);
		}

		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public Matrix(Matrix m)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Store matrix extents
			_Width = m._Width; _Height = m._Height;
			// Allocate matrix
			MatrixBuffer = new float[_Width * _Height];

			// Copy matrix components
			unsafe {
				fixed (float* matrix = MatrixBuffer)
				fixed (float* otherMatrix = m.MatrixBuffer)
				{
					uint length = _Width * _Height;

					for (int i = 0; i < length; i++)
						matrix[i] = otherMatrix[i];
				}
			}
		}

		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public Matrix(IMatrix m)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Store matrix extents
			_Width = m.Width; _Height = m.Height;
			// Allocate matrix
			MatrixBuffer = new float[_Width * _Height];

			// Copy matrix components
			for (uint r = 0; r < _Height; r++) {
				for (uint c = 0; c < _Width; c++) {
					this[c, r] = (float)m[c, r];
				}
			}
		}

		#endregion

		#region Buffer

		/// <summary>
		/// Get the matrix components, in column-major order.
		/// </summary>
		public float[] Buffer
		{
			get
			{
				float[] buffer = new float[MatrixBuffer.Length];

				Array.Copy(MatrixBuffer, buffer, MatrixBuffer.Length);

				return (buffer);
			}
		}

		/// <summary>
		/// Matrix components.
		/// </summary>
		protected internal float[] MatrixBuffer;

		#endregion

		#region Operators

		/// <summary>
		/// Matrix component indexer.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> the specify the column index (zero based).
		/// </param>
		/// <param name="r">
		/// A <see cref="Int32"/> the specify the row index (zero based).
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="c"/> is greater than <see name="Matrix.Width"/> column count, or if <paramref name="r"/>
		/// is greater than <see name="Matrix.Height"/> row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get {
				return (MatrixBuffer[c * _Height + r]);
			}
			set {
				MatrixBuffer[c * _Height + r] = value;
			}
		}

		/// <summary>
		/// Add two Matrix.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix"/> that specify the left Matrix.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix"/> that specify the right Matrix.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix"/> resulting from the sum of the two Matrix specified as parameters.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m1"/> or <paramref name="m2"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m1"/> size and <paramref name="m2"/> size does not match.
		/// </exception>
		public static Matrix operator+(Matrix m1, Matrix m2)
		{
			if (m1 == null)
				throw new ArgumentNullException("m1");
			if (m2 == null)
				throw new ArgumentNullException("m2");
			if (m1._Width != m2._Width)
				throw new ArgumentException("matrices width mismatch");
			if (m1._Height != m2._Height)
				throw new ArgumentException("matrices height mismatch");

			// Allocate product matrix
			Matrix sum = new Matrix(m1._Width, m1._Height);

			unsafe {
				fixed (float* matrix1 = m1.MatrixBuffer)
				fixed (float* matrix2 = m2.MatrixBuffer)
				fixed (float* sumMatrix = sum.MatrixBuffer)
				{
					uint length = m1._Width * m1.Height;

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
		/// A <see cref="Matrix"/> that specify the left Matrix.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that multiply all matrix components.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix"/> resulted from the operation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public static Matrix operator*(Matrix m, float scalar)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Allocate product matrix
			Matrix prod = new Matrix(m._Width, m._Height);

			unsafe {
				fixed (float* matrix = m.MatrixBuffer)
				fixed (float* prodMatrix = prod.MatrixBuffer) {
					uint length = m._Width * m.Height;

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
		/// A <see cref="Matrix"/> that specify the left Matrix.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that divide all matrix components.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix"/> resulted from the operation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public static Matrix operator/(Matrix m, float scalar)
		{
			if (m == null)
				throw new ArgumentNullException("m");

			// Allocate product matrix
			Matrix div = new Matrix(m._Width, m._Height);

			unsafe {
				fixed (float* matrix = m.MatrixBuffer)
				fixed (float* divMatrix = div.MatrixBuffer)
				{
					uint length = m._Width * m.Height;

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
		/// A <see cref="Matrix"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> or <paramref name="n"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="m"/> width is different from <paramref name="n"/> height.
		/// </exception>
		public static Matrix operator*(Matrix m, Matrix n)
		{
			if (m == null)
				throw new ArgumentNullException("m");
			if (n == null)
				throw new ArgumentNullException("n");
			if (m._Width != n._Height)
				throw new ArgumentException("matrices width/height mismatch");

			// Allocate product matrix
			Matrix prod = new Matrix(n._Width, m._Height);

			unsafe {
				fixed (float* pm = m.MatrixBuffer)
				fixed (float* pn = n.MatrixBuffer)
				fixed (float* prodMatrix = prod.MatrixBuffer)
				{
					// Compute matrix product
					for (uint c = 0; c < n._Width; c++) {
						for (uint r = 0; r < prod._Height; r++) {
							float s = 0.0f;

							for (uint i = 0; i < m._Width; i++)
								s += pm[i * m._Height + r] * pn[c * n._Height + i];

							prodMatrix[c * prod._Height + r] = s;
						}
					}
				}
			}

			return (prod);
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from MatrixDouble to Matrix operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ModelMatrixDouble"/> to be converted to <see cref="Matrix"/>.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static explicit operator Matrix(MatrixDouble a)
		{
			if (a == null)
				return (null);
			
			Matrix matrix = new Matrix(a.Width, a.Height);

			for (int i = 0; i < a.Width * a.Height; i++)
				matrix.MatrixBuffer[i] = (float)a.MatrixBuffer[i];

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
		public static bool operator ==(Matrix m1, Matrix m2)
		{
			return (Equals(m1, m2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1"></param>
		/// <param name="m2"></param>
		/// <returns></returns>
		public static bool operator !=(Matrix m1, Matrix m2)
		{
			return (!Equals(m1, m2));
		}

		#endregion

		#region Matrix Functions

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
			if (m._Width != Width)
				throw new ArgumentException("matrix width mismatch");
			if (m._Height != Height)
				throw new ArgumentException("matrix height mismatch");

			unsafe {
				fixed (float* matrix = MatrixBuffer)
				fixed (float* otherMatrix = m.MatrixBuffer)
				{
					uint length = m._Width * m.Height;

					for (uint i = 0; i < length; i++)
						matrix[i] = otherMatrix[i];
				}
			}
		}

		/// <summary>
		/// Compute the transpose of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="Matrix"/> which hold the transpose of this Matrix.
		/// </returns>
		public virtual Matrix Transpose()
		{
			Matrix transpose;

			if (IsSquare)
				transpose = Clone();					// Allow to mantain type consistency with Matrix3x3, Matrix4x4 and other derived square matrices
			else
				transpose = new Matrix(Height, Width);	// Not square matrix should be a Matrix instance

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
		public virtual Matrix Clone()
		{
			return (new Matrix(this));
		}

		/// <summary>
		/// Get a matrix column.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the column index.
		/// </param>
		/// <returns>
		/// It returns the column components.
		/// </returns>
		public float[] GetColumn(uint index)
		{
			float[] column = new float[Height];

			for (uint i = 0; i < Height; i++)
				column[i] = this[index, i];

			return (column);
		}

		/// <summary>
		/// Get a matrix row.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the row index.
		/// </param>
		/// <returns>
		/// It returns the row components.
		/// </returns>
		public float[] GetRow(uint index)
		{
			float[] row = new float[Width];

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
		public float[] ToArray()
		{
			float[] matrixArray = new float[Width * Height];

			Array.Copy(MatrixBuffer, matrixArray, matrixArray.Length);

			return (matrixArray);
		}

		#endregion

		#region Square Matrix Functions

		/// <summary>
		/// Determine whether this matrix is an identity.
		/// </summary>
		/// <param name="precision">
		/// A <see cref="Single"/> that specify the precision used for testing identity.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating that this matrix is identity.
		/// </returns>
		/// <remarks>
		/// <para>This method can be used for testing matrix identity with a specific range of approximation.</para>
		/// <para>For a reasonable precision for matrices having translations and rotations use <see cref="IsIdentity()"/>.</para>
		/// </remarks>
		public bool IsIdentity(float precision)
		{
			if (IsSquare == false)
				throw new InvalidOperationException("non-square");

			unsafe {
				fixed (float* matrix = MatrixBuffer) {
					for (uint c = 0; c < _Width; c++) {
						for (uint r = 0; r < _Height; r++) {
							float value = matrix[c * _Width + r];

							if ((c != r) && (Math.Abs(value) > precision))
								return (false);
							if ((c == r) && (Math.Abs(1.0f - value) > precision))
								return (false);
						}
					}

					return (true);
				}
			}
		}

		/// <summary>
		/// Compute the matrix determinant.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Matrix is not square.
		/// </exception>
		public virtual float GetDeterminant()
		{
			if (IsSquare == false)
				throw new InvalidOperationException("not square");

			if (_Width > 2) {
				float d = 0.0f;

				for (uint r = 0; r < Height; r++) {
					Matrix complement = new Matrix(this, 0, r);
					float sng = ((r % 2) == 0) ? +1.0f : -1.0f;

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
		private static float GetComplement(Matrix m, uint c, uint r)
		{
			float sign;

			if (m == null)
				throw new ArgumentNullException("m");
			if (m.IsSquare == false)
				throw new InvalidOperationException("non-square");
			if (c >= m._Width)
				throw new ArgumentException("out of bounds", "c");
			if (r >= m._Height)
				throw new ArgumentException("out of bounds", "r");

			// Determine complement sign
			if (((c + r) % 2) == 0) sign = 1.0f; else sign = -1.0f;

			// Compute matrix component complement
			if (m._Width > 2) {
				Matrix complement = new Matrix(m, c, r);

				return (sign * complement.GetDeterminant());
			} else
				return (sign * m[(c==0)?1:(uint)0,(r==0)?1:(uint)0]);
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
		public virtual Matrix GetInverseMatrix()
		{
			// Matrix shall be square
			if (IsSquare == false)
				throw new InvalidOperationException("non-square");

			// Matrix shall not be singular
			float d = GetDeterminant();
			if (Math.Abs(d) < Single.Epsilon)
				throw new InvalidOperationException("singular");

			// Compute inverse matrix
			Matrix iMatrix = Clone();	// Again, use Clone to get the right type

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
		/// Returns a <see cref="String"/> that represents this Matrix.
		/// </returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("Matrix{0}x{1}:", Width, Height);
			for (uint c = 0; c < Width; c++) {
				sb.Append(" [");
				for (uint r = 0; r < Height; r++)
					sb.AppendFormat("{0}{1}", Math.Round(this[c, r], 4).ToString(NumberFormatInfo.InvariantInfo), (r < Height - 1) ? ", " : String.Empty);
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
			get { return (_Width); }
		}

		/// <summary>
		/// Matrix height (row count).
		/// </summary>
		public uint Height
		{
			get { return (_Height); }
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

			Matrix amatrix = matrix as Matrix;

			if (amatrix == null) {
				for (uint c = 0; c < Width; c++)
					for (uint r = 0; r < Height; r++)
						this[c, r] = (float)matrix[c, r];
			} else
				Array.Copy(amatrix.MatrixBuffer, MatrixBuffer, MatrixBuffer.Length);
		}

		/// <summary>
		/// Set to void matrix.
		/// </summary>
		public void SetVoid()
		{
			unsafe {
				fixed (float* matrix = MatrixBuffer) {
					uint length = _Width * Height;

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
				fixed (float* matrix = MatrixBuffer) {
					for (uint c = 0; c < _Width; c++)
						for (uint r = 0; r < _Height; r++)
							if (c == r) matrix[c * _Width + r] = 1.0f; else matrix[c * _Width + r] = 0.0f;
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
			return (IsIdentity(1e-5f));
		}

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
		public bool IsIdentity(double precision)
		{
			return (IsIdentity((float)precision));
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
		IMatrix IMatrix.GetComplementMatrix(uint c, uint r)
		{
			return (new Matrix(this, c, r));
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
			Matrix otherMatrix = a as Matrix;
			
			// Matrix * Matrix shortcut
			if (otherMatrix != null)
				return (this * otherMatrix);
			
			// Performs multiplication with another IMatrix using double-precision
			if (_Width != a.Height)
				throw new ArgumentException("matrices width/height mismatch");

			// Allocate product matrix
			MatrixDouble prod = new MatrixDouble(a.Height, _Width);

			uint w = _Width, h = _Height;

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
		/// A <see cref="UInt32"/> that specify the column index.
		/// </param>
		/// <returns>
		/// It returns the column components.
		/// </returns>
		double[] IMatrix.GetColumn(uint index)
		{
#if !NETCORE && !NETSTANDARD1_4
			return (Array.ConvertAll<float, double>(GetColumn(index), delegate(float input) { return ((double)input); }));
#else
			float[] items = GetColumn(index);
			double[] iitems = new double[items.Length];

			for (int i = 0; i < items.Length; i++)
				iitems[i] = items[i];

			return (iitems);
#endif
		}

		/// <summary>
		/// Get a matrix row.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the row index.
		/// </param>
		/// <returns>
		/// It returns the row components.
		/// </returns>
		double[] IMatrix.GetRow(uint index)
		{
#if !NETCORE && !NETSTANDARD1_4
			return (Array.ConvertAll<float, double>(GetRow(index), delegate(float input) { return ((double)input); }));
#else
			float[] items = GetRow(index);
			double[] iitems = new double[items.Length];

			for (int i = 0; i < items.Length; i++)
				iitems[i] = items[i];

			return (iitems);
#endif
		}

		/// <summary>
		/// Returns an array representation of this matrix, in column-major order.
		/// </summary>
		/// <returns>
		/// The array representing this matrix components.
		/// </returns>
		double[] IMatrix.ToArray()
		{
#if !NETCORE && !NETSTANDARD1_4
			return (Array.ConvertAll<float, double>(ToArray(), delegate(float input) { return ((double)input); }));
#else
			float[] items = ToArray();
			double[] iitems = new double[items.Length];

			for (int i = 0; i < items.Length; i++)
				iitems[i] = items[i];

			return (iitems);
#endif
		}

		/// <summary>
		/// Clone this IMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this IMatrix.
		/// </returns>
		IMatrix IMatrix.Clone()
		{
			return (Clone());
		}

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
		double IMatrix.this[uint c, uint r]
		{
			get { return (this[c, r]); }
			set { this[c, r] = (float)value; }
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
		private readonly uint _Width;

		/// <summary>
		/// Matrix height (row count).
		/// </summary>
		private readonly uint _Height;

		#endregion

		#region IEquatable<Matrix> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);
			if ((_Width != other.Width) || (_Height != other._Height))
				return (false);

			unsafe {
				fixed (float* m1 = MatrixBuffer)
				fixed (float* m2 = other.MatrixBuffer) {
					const float Epsilon = 1e-6f;

					float* m1Ptr = m1, m2Ptr = m2;
					uint w = _Width, h = Height, l = w * h;

					// Compare matrix elements
#if HAVE_NUMERICS
					if (Vector.IsHardwareAccelerated) {
						uint vecLen = l / (uint)Vector<float>.Count;

						for (uint i = 0; i < vecLen; i++, m1Ptr += Vector<float>.Count, m2Ptr += Vector<float>.Count) {
							if (Vector.EqualsAll(Unsafe.Read<Vector<float>>(m1Ptr), Unsafe.Read<Vector<float>>(m2Ptr)) == false)
								return (false);
						}

						l -= vecLen * (uint)Vector<float>.Count;
					}
#endif
					// Compare (remaining) matrix elements
					for (uint i = 0; i < l; i++) {
						if (Math.Abs(m1Ptr[i] - m2Ptr[i]) > Epsilon)
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
			try {
				return (Equals((Matrix)obj));
			} catch (InvalidCastException) {
				return (false);
			}
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

				result = (result * 397) ^ _Width.GetHashCode();

				result = (result * 397) ^ _Height.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}
