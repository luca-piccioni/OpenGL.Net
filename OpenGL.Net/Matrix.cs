
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
using System.Runtime.InteropServices;
using System.Threading;

#if HAVE_NUMERICS
using System.Numerics;
using System.Runtime.CompilerServices;

using Mat4x4 = System.Numerics.Matrix4x4;
#endif

// ReSharper disable InconsistentNaming
// ReSharper disable CompareOfFloatsByEqualityOperator

namespace OpenGL
{
	/// <summary>
	/// Matrix composed by 2 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x2f : IEquatable<Matrix2x2f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x2f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		public Matrix2x2f(float c00, float c01, float c10, float c11)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
		}

		/// <summary>
		/// Construct a Matrix2x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x2f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x2f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 4)
				throw new ArgumentException("length must be at least 4", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
		}

		/// <summary>
		/// Construct a Matrix2x2f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x2f to be copied into this instance.
		/// </param>
		public Matrix2x2f(Matrix2x2f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x2f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix2x2f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix2x2f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix2x2f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2f Column0
		{
			get { return new Vertex2f(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2f Column1
		{
			get { return new Vertex2f(_M10, _M11); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2f Row0
		{
			get { return new Vertex2f(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2f Row1
		{
			get { return new Vertex2f(_M01, _M11); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x2f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x2f operator*(Matrix2x2f m, float v)
		{
			Matrix2x2f r = new Matrix2x2f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix2x2f with a Vertex2f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex2f operator*(Matrix2x2f m, Vertex2f v)
		{
			Vertex2f r = new Vertex2f();

			r.x = m._M00 * v.x + m._M10 * v.y;
			r.y = m._M01 * v.x + m._M11 * v.y;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix2x2f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix2x2f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2f"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix2x2f operator*(Matrix2x2f m, Matrix2x2f n)
		{
			Matrix2x2f r = new Matrix2x2f();

			r._M00 = m._M00 * n._M00 + m._M10 * n._M01;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x2f m1, Matrix2x2f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x2f m1, Matrix2x2f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix2x2f a)
		{
			float[] m = new float[4];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x2d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix2x2d(Matrix2x2f a)
		{
			return new Matrix2x2d(
				a._M00, a._M01, 
				a._M10, a._M11
			);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix2x2f modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2f"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix2x2f RotatedZ(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix2x2f r = new Matrix2x2f();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix2x2f around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(float angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x2f.
		/// </summary>
		public Matrix2x2f Transposed
		{
			get
			{
				Matrix2x2f tranposed = new Matrix2x2f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix2x2f.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix2x2f.
		/// </summary>
		public float Determinant
		{
			get
			{
				return _M00 * _M11 - _M10 * _M01;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix2x2f.
		/// </summary>
		public Matrix2x2f Inverse
		{
			get
			{
				float det = Determinant;
				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");
				det = 1.0f / det;
				
				return new Matrix2x2f(
					+_M11 * det, -_M01 * det,
					-_M10 * det, +_M00 * det
				);
			}
		}

		/// <summary>
		/// Invert this Matrix2x2f.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x2f Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix2x2f Identity = new Matrix2x2f(
			1.0f, 0.0f, 
			0.0f, 1.0f
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x2f is equal to another Matrix2x2f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x2f"/> to compare with this Matrix2x2f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x2f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x2f is equal to another Matrix2x2f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x2f"/> to compare with this Matrix2x2f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x2f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11;
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
			if (obj.GetType() != typeof(Matrix2x2f))
				return (false);
			
			return (Equals((Matrix2x2f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x2f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x3f : IEquatable<Matrix2x3f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x3f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		public Matrix2x3f(float c00, float c01, float c02, float c10, float c11, float c12)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
		}

		/// <summary>
		/// Construct a Matrix2x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x3f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x3f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 6)
				throw new ArgumentException("length must be at least 6", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
		}

		/// <summary>
		/// Construct a Matrix2x3f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x3f to be copied into this instance.
		/// </param>
		public Matrix2x3f(Matrix2x3f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x3f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix2x3f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix2x3f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix2x3f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix2x3f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix2x3f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3f Column0
		{
			get { return new Vertex3f(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3f Column1
		{
			get { return new Vertex3f(_M10, _M11, _M12); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2f Row0
		{
			get { return new Vertex2f(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2f Row1
		{
			get { return new Vertex2f(_M01, _M11); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex2f Row2
		{
			get { return new Vertex2f(_M02, _M12); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x3f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x3f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x3f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x3f operator*(Matrix2x3f m, float v)
		{
			Matrix2x3f r = new Matrix2x3f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x3f m1, Matrix2x3f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x3f m1, Matrix2x3f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix2x3f a)
		{
			float[] m = new float[6];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x3d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x3d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix2x3d(Matrix2x3f a)
		{
			return new Matrix2x3d(
				a._M00, a._M01, a._M02, 
				a._M10, a._M11, a._M12
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x3f.
		/// </summary>
		public Matrix3x2f Transposed
		{
			get
			{
				Matrix3x2f tranposed = new Matrix3x2f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x3f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x3f is equal to another Matrix2x3f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x3f"/> to compare with this Matrix2x3f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x3f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x3f is equal to another Matrix2x3f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x3f"/> to compare with this Matrix2x3f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x3f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12;
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
			if (obj.GetType() != typeof(Matrix2x3f))
				return (false);
			
			return (Equals((Matrix2x3f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x3f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x4f : IEquatable<Matrix2x4f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x4f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		public Matrix2x4f(float c00, float c01, float c02, float c03, float c10, float c11, float c12, float c13)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
		}

		/// <summary>
		/// Construct a Matrix2x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x4f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x4f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 8)
				throw new ArgumentException("length must be at least 8", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
		}

		/// <summary>
		/// Construct a Matrix2x4f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x4f to be copied into this instance.
		/// </param>
		public Matrix2x4f(Matrix2x4f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x4f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix2x4f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix2x4f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix2x4f component: column 1, row 4.
		/// </summary>
		internal float _M03;

		/// <summary>
		/// Matrix2x4f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix2x4f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix2x4f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		/// <summary>
		/// Matrix2x4f component: column 2, row 4.
		/// </summary>
		internal float _M13;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4f Column0
		{
			get { return new Vertex4f(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4f Column1
		{
			get { return new Vertex4f(_M10, _M11, _M12, _M13); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2f Row0
		{
			get { return new Vertex2f(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2f Row1
		{
			get { return new Vertex2f(_M01, _M11); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex2f Row2
		{
			get { return new Vertex2f(_M02, _M12); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex2f Row3
		{
			get { return new Vertex2f(_M03, _M13); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x4f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x4f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x4f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x4f operator*(Matrix2x4f m, float v)
		{
			Matrix2x4f r = new Matrix2x4f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x4f m1, Matrix2x4f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x4f m1, Matrix2x4f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix2x4f a)
		{
			float[] m = new float[8];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x4d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x4d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix2x4d(Matrix2x4f a)
		{
			return new Matrix2x4d(
				a._M00, a._M01, a._M02, a._M03, 
				a._M10, a._M11, a._M12, a._M13
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x4f.
		/// </summary>
		public Matrix4x2f Transposed
		{
			get
			{
				Matrix4x2f tranposed = new Matrix4x2f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x4f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x4f is equal to another Matrix2x4f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x4f"/> to compare with this Matrix2x4f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x4f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x4f is equal to another Matrix2x4f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x4f"/> to compare with this Matrix2x4f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x4f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13;
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
			if (obj.GetType() != typeof(Matrix2x4f))
				return (false);
			
			return (Equals((Matrix2x4f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x4f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x4f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x2f : IEquatable<Matrix3x2f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x2f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		public Matrix3x2f(float c00, float c01, float c10, float c11, float c20, float c21)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
			_M20 = c20;
			_M21 = c21;
		}

		/// <summary>
		/// Construct a Matrix3x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x2f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x2f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 6)
				throw new ArgumentException("length must be at least 6", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
			_M20 = c[offset + 4];
			_M21 = c[offset + 5];
		}

		/// <summary>
		/// Construct a Matrix3x2f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x2f to be copied into this instance.
		/// </param>
		public Matrix3x2f(Matrix3x2f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
			_M20 = other._M20;
			_M21 = other._M21;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x2f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix3x2f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix3x2f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix3x2f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix3x2f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix3x2f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2f Column0
		{
			get { return new Vertex2f(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2f Column1
		{
			get { return new Vertex2f(_M10, _M11); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex2f Column2
		{
			get { return new Vertex2f(_M20, _M21); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3f Row0
		{
			get { return new Vertex3f(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3f Row1
		{
			get { return new Vertex3f(_M01, _M11, _M21); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x2f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x2f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x2f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x2f operator*(Matrix3x2f m, float v)
		{
			Matrix3x2f r = new Matrix3x2f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x2f m1, Matrix3x2f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x2f m1, Matrix3x2f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix3x2f a)
		{
			float[] m = new float[6];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;
			m[4] = a._M20;
			m[5] = a._M21;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x2d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x2d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix3x2d(Matrix3x2f a)
		{
			return new Matrix3x2d(
				a._M00, a._M01, 
				a._M10, a._M11, 
				a._M20, a._M21
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x2f.
		/// </summary>
		public Matrix2x3f Transposed
		{
			get
			{
				Matrix2x3f tranposed = new Matrix2x3f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x2f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x2f is equal to another Matrix3x2f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x2f"/> to compare with this Matrix3x2f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x2f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x2f is equal to another Matrix3x2f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x2f"/> to compare with this Matrix3x2f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x2f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11 && _M20 == other._M20 && _M21 == other._M21;
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
			if (obj.GetType() != typeof(Matrix3x2f))
				return (false);
			
			return (Equals((Matrix3x2f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x2f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||{_M20}, {_M21}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x3f : IEquatable<Matrix3x3f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x3f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		public Matrix3x3f(float c00, float c01, float c02, float c10, float c11, float c12, float c20, float c21, float c22)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
		}

		/// <summary>
		/// Construct a Matrix3x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x3f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x3f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 9)
				throw new ArgumentException("length must be at least 9", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
			_M20 = c[offset + 6];
			_M21 = c[offset + 7];
			_M22 = c[offset + 8];
		}

		/// <summary>
		/// Construct a Matrix3x3f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x3f to be copied into this instance.
		/// </param>
		public Matrix3x3f(Matrix3x3f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
		}

		/// <summary>
		/// Construct the complement matrix of a Matrix4x4f.
		/// </summary>
		/// <param name="other">
		/// The Matrix4x4f to be copied into this instance.
		/// </param>
		/// <param name="c">
		/// The index of column to be excluded to construct the complement matrix.
		/// </param>
		/// <param name="r">
		/// The index of row to be excluded to construct the complement matrix.
		/// </param>
		public Matrix3x3f(Matrix4x4f other, uint c, uint r)
		{
			if (c >= 4)
				throw new ArgumentOutOfRangeException(nameof(c));
			if (r >= 4)
				throw new ArgumentOutOfRangeException(nameof(r));

			_M00 = _M01 = _M02 = _M10 = _M11 = _M12 = _M20 = _M21 = _M22 =  0.0f;
			for (uint ic = 0; ic < 3; ic++)
				for (uint ir = 0; ir < 3; ir++)
					this[ic, ir] = other[ic < c ? ic : ic + 1, ir < r ? ir : ir + 1];
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x3f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix3x3f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix3x3f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix3x3f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix3x3f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix3x3f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		/// <summary>
		/// Matrix3x3f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix3x3f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		/// <summary>
		/// Matrix3x3f component: column 3, row 3.
		/// </summary>
		internal float _M22;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3f Column0
		{
			get { return new Vertex3f(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3f Column1
		{
			get { return new Vertex3f(_M10, _M11, _M12); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex3f Column2
		{
			get { return new Vertex3f(_M20, _M21, _M22); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3f Row0
		{
			get { return new Vertex3f(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3f Row1
		{
			get { return new Vertex3f(_M01, _M11, _M21); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex3f Row2
		{
			get { return new Vertex3f(_M02, _M12, _M22); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x3f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x3f operator*(Matrix3x3f m, float v)
		{
			Matrix3x3f r = new Matrix3x3f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix3x3f with a Vertex3f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex3f operator*(Matrix3x3f m, Vertex3f v)
		{
			Vertex3f r = new Vertex3f();

			r.x = m._M00 * v.x + m._M10 * v.y + m._M20 * v.z;
			r.y = m._M01 * v.x + m._M11 * v.y + m._M21 * v.z;
			r.z = m._M02 * v.x + m._M12 * v.y + m._M22 * v.z;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix3x3f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix3x3f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix3x3f operator*(Matrix3x3f m, Matrix3x3f n)
		{
			Matrix3x3f r = new Matrix3x3f();

			r._M00 = m._M00 * n._M00 + m._M10 * n._M01 + m._M20 * n._M02;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01 + m._M21 * n._M02;
			r._M02 = m._M02 * n._M00 + m._M12 * n._M01 + m._M22 * n._M02;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11 + m._M20 * n._M12;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11 + m._M21 * n._M12;
			r._M12 = m._M02 * n._M10 + m._M12 * n._M11 + m._M22 * n._M12;
			r._M20 = m._M00 * n._M20 + m._M10 * n._M21 + m._M20 * n._M22;
			r._M21 = m._M01 * n._M20 + m._M11 * n._M21 + m._M21 * n._M22;
			r._M22 = m._M02 * n._M20 + m._M12 * n._M21 + m._M22 * n._M22;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x3f m1, Matrix3x3f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x3f m1, Matrix3x3f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix3x3f a)
		{
			float[] m = new float[9];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;
			m[6] = a._M20;
			m[7] = a._M21;
			m[8] = a._M22;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x3d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix3x3d(Matrix3x3f a)
		{
			return new Matrix3x3d(
				a._M00, a._M01, a._M02, 
				a._M10, a._M11, a._M12, 
				a._M20, a._M21, a._M22
			);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix3x3f modelling a rotation around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> representing a matrix rotating on X axis.
		/// </returns>
		public static Matrix3x3f RotatedX(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix3x3f r = new Matrix3x3f();

			r._M11 = +cosa;
			r._M21 = -sina;
			r._M12 = +sina;
			r._M22 = +cosa;
			r._M00 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3f around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateX(float angle)
		{
			this = this * RotatedX(angle);
		}

		/// <summary>
		/// Construct a Matrix3x3f modelling a rotation around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> representing a matrix rotating on Y axis.
		/// </returns>
		public static Matrix3x3f RotatedY(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix3x3f r = new Matrix3x3f();

			r._M00 = +cosa;
			r._M20 = +sina;
			r._M02 = -sina;
			r._M22 = +cosa;
			r._M11 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3f around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateY(float angle)
		{
			this = this * RotatedY(angle);
		}

		/// <summary>
		/// Construct a Matrix3x3f modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix3x3f RotatedZ(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix3x3f r = new Matrix3x3f();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;
			r._M22 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3f around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(float angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Scaling

		/// <summary>
		/// Compute the scaled of this Matrix3x3f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the scale on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> representing a scaling matrix.
		/// </returns>
		public static Matrix3x3f Scaled(float x, float y, float z)
		{
			Matrix3x3f scaled = new Matrix3x3f();

			scaled._M00 = x;
			scaled._M11 = y;
			scaled._M22 = z;

			return scaled;
		}

		/// <summary>
		/// Scale this Matrix3x3f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the scale on Z axis.
		/// </param>
		public void Scale(float x, float y, float z)
		{
			this = this * Scaled(x, y, z);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x3f.
		/// </summary>
		public Matrix3x3f Transposed
		{
			get
			{
				Matrix3x3f tranposed = new Matrix3x3f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix3x3f.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
			_M02 = Interlocked.Exchange(ref _M20, _M02);
			_M12 = Interlocked.Exchange(ref _M21, _M12);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix3x3f.
		/// </summary>
		public float Determinant
		{
			get
			{
				float a = _M00, b = _M10, c = _M20;
				float d = _M01, e = _M11, f = _M21;
				float g = _M02, h = _M12, k = _M22;

				return (e * k - f * h) * a + -(d * k - f * g) * b + (d * h - e * g) * c;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix3x3f.
		/// </summary>
		public Matrix3x3f Inverse
		{
			get
			{
				float det = Determinant;
				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");
				det = 1.0f / det;

				float a = _M00, b = _M10, c = _M20;
				float d = _M01, e = _M11, f = _M21;
				float g = _M02, h = _M12, k = _M22;

				return new Matrix3x3f(
					 (e * k - f * h) * det, -(d * k - f * g) * det,  (d * h - e * g) * det,
					-(b * k - c * h) * det,  (a * k - c * g) * det, -(a * h - b * g) * det,
					 (b * f - c * e) * det, -(a * f - c * d) * det,  (a * e - b * d) * det
				);
			}
		}

		/// <summary>
		/// Invert this Matrix3x3f.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x3f Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix3x3f Identity = new Matrix3x3f(
			1.0f, 0.0f, 0.0f, 
			0.0f, 1.0f, 0.0f, 
			0.0f, 0.0f, 1.0f
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x3f is equal to another Matrix3x3f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x3f"/> to compare with this Matrix3x3f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x3f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x3f is equal to another Matrix3x3f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x3f"/> to compare with this Matrix3x3f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x3f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22;
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
			if (obj.GetType() != typeof(Matrix3x3f))
				return (false);
			
			return (Equals((Matrix3x3f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x3f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||{_M20}, {_M21}, {_M22}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x4f : IEquatable<Matrix3x4f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x4f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c23">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 3.
		/// </param>
		public Matrix3x4f(float c00, float c01, float c02, float c03, float c10, float c11, float c12, float c13, float c20, float c21, float c22, float c23)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M23 = c23;
		}

		/// <summary>
		/// Construct a Matrix3x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x4f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x4f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 12)
				throw new ArgumentException("length must be at least 12", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
			_M20 = c[offset + 8];
			_M21 = c[offset + 9];
			_M22 = c[offset + 10];
			_M23 = c[offset + 11];
		}

		/// <summary>
		/// Construct a Matrix3x4f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x4f to be copied into this instance.
		/// </param>
		public Matrix3x4f(Matrix3x4f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M23 = other._M23;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x4f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix3x4f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix3x4f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix3x4f component: column 1, row 4.
		/// </summary>
		internal float _M03;

		/// <summary>
		/// Matrix3x4f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix3x4f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix3x4f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		/// <summary>
		/// Matrix3x4f component: column 2, row 4.
		/// </summary>
		internal float _M13;

		/// <summary>
		/// Matrix3x4f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix3x4f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		/// <summary>
		/// Matrix3x4f component: column 3, row 3.
		/// </summary>
		internal float _M22;

		/// <summary>
		/// Matrix3x4f component: column 3, row 4.
		/// </summary>
		internal float _M23;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4f Column0
		{
			get { return new Vertex4f(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4f Column1
		{
			get { return new Vertex4f(_M10, _M11, _M12, _M13); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex4f Column2
		{
			get { return new Vertex4f(_M20, _M21, _M22, _M23); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3f Row0
		{
			get { return new Vertex3f(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3f Row1
		{
			get { return new Vertex3f(_M01, _M11, _M21); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex3f Row2
		{
			get { return new Vertex3f(_M02, _M12, _M22); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex3f Row3
		{
			get { return new Vertex3f(_M03, _M13, _M23); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							case 3: return _M23;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							case 3: _M23 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x4f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x4f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x4f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x4f operator*(Matrix3x4f m, float v)
		{
			Matrix3x4f r = new Matrix3x4f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M23 = m._M23 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x4f m1, Matrix3x4f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x4f m1, Matrix3x4f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix3x4f a)
		{
			float[] m = new float[12];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;
			m[8] = a._M20;
			m[9] = a._M21;
			m[10] = a._M22;
			m[11] = a._M23;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x4d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x4d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix3x4d(Matrix3x4f a)
		{
			return new Matrix3x4d(
				a._M00, a._M01, a._M02, a._M03, 
				a._M10, a._M11, a._M12, a._M13, 
				a._M20, a._M21, a._M22, a._M23
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x4f.
		/// </summary>
		public Matrix4x3f Transposed
		{
			get
			{
				Matrix4x3f tranposed = new Matrix4x3f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M32 = _M23;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x4f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x4f is equal to another Matrix3x4f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x4f"/> to compare with this Matrix3x4f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x4f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M23 - other._M23) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x4f is equal to another Matrix3x4f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x4f"/> to compare with this Matrix3x4f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x4f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M23 == other._M23;
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
			if (obj.GetType() != typeof(Matrix3x4f))
				return (false);
			
			return (Equals((Matrix3x4f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M23.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x4f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x4f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||{_M20}, {_M21}, {_M22}, {_M23}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x2f : IEquatable<Matrix4x2f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x2f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c30">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		public Matrix4x2f(float c00, float c01, float c10, float c11, float c20, float c21, float c30, float c31)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
			_M20 = c20;
			_M21 = c21;
			_M30 = c30;
			_M31 = c31;
		}

		/// <summary>
		/// Construct a Matrix4x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x2f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x2f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x2f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 8)
				throw new ArgumentException("length must be at least 8", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
			_M20 = c[offset + 4];
			_M21 = c[offset + 5];
			_M30 = c[offset + 6];
			_M31 = c[offset + 7];
		}

		/// <summary>
		/// Construct a Matrix4x2f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x2f to be copied into this instance.
		/// </param>
		public Matrix4x2f(Matrix4x2f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
			_M20 = other._M20;
			_M21 = other._M21;
			_M30 = other._M30;
			_M31 = other._M31;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x2f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix4x2f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix4x2f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix4x2f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix4x2f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix4x2f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		/// <summary>
		/// Matrix4x2f component: column 4, row 1.
		/// </summary>
		internal float _M30;

		/// <summary>
		/// Matrix4x2f component: column 4, row 2.
		/// </summary>
		internal float _M31;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2f Column0
		{
			get { return new Vertex2f(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2f Column1
		{
			get { return new Vertex2f(_M10, _M11); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex2f Column2
		{
			get { return new Vertex2f(_M20, _M21); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex2f Column3
		{
			get { return new Vertex2f(_M30, _M31); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4f Row0
		{
			get { return new Vertex4f(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4f Row1
		{
			get { return new Vertex4f(_M01, _M11, _M21, _M31); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x2f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x2f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x2f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x2f operator*(Matrix4x2f m, float v)
		{
			Matrix4x2f r = new Matrix4x2f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x2f m1, Matrix4x2f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x2f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x2f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x2f m1, Matrix4x2f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix4x2f a)
		{
			float[] m = new float[8];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;
			m[4] = a._M20;
			m[5] = a._M21;
			m[6] = a._M30;
			m[7] = a._M31;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x2d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x2d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix4x2d(Matrix4x2f a)
		{
			return new Matrix4x2d(
				a._M00, a._M01, 
				a._M10, a._M11, 
				a._M20, a._M21, 
				a._M30, a._M31
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x2f.
		/// </summary>
		public Matrix2x4f Transposed
		{
			get
			{
				Matrix2x4f tranposed = new Matrix2x4f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x2f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x2f is equal to another Matrix4x2f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x2f"/> to compare with this Matrix4x2f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x2f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x2f is equal to another Matrix4x2f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x2f"/> to compare with this Matrix4x2f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x2f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x2f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11 && _M20 == other._M20 && _M21 == other._M21 && _M30 == other._M30 && _M31 == other._M31;
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
			if (obj.GetType() != typeof(Matrix4x2f))
				return (false);
			
			return (Equals((Matrix4x2f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x2f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||{_M20}, {_M21}||{_M30}, {_M31}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x3f : IEquatable<Matrix4x3f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x3f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c30">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		/// <param name="c32">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 2.
		/// </param>
		public Matrix4x3f(float c00, float c01, float c02, float c10, float c11, float c12, float c20, float c21, float c22, float c30, float c31, float c32)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M30 = c30;
			_M31 = c31;
			_M32 = c32;
		}

		/// <summary>
		/// Construct a Matrix4x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x3f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x3f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x3f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 12)
				throw new ArgumentException("length must be at least 12", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
			_M20 = c[offset + 6];
			_M21 = c[offset + 7];
			_M22 = c[offset + 8];
			_M30 = c[offset + 9];
			_M31 = c[offset + 10];
			_M32 = c[offset + 11];
		}

		/// <summary>
		/// Construct a Matrix4x3f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x3f to be copied into this instance.
		/// </param>
		public Matrix4x3f(Matrix4x3f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M30 = other._M30;
			_M31 = other._M31;
			_M32 = other._M32;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x3f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix4x3f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix4x3f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix4x3f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix4x3f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix4x3f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		/// <summary>
		/// Matrix4x3f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix4x3f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		/// <summary>
		/// Matrix4x3f component: column 3, row 3.
		/// </summary>
		internal float _M22;

		/// <summary>
		/// Matrix4x3f component: column 4, row 1.
		/// </summary>
		internal float _M30;

		/// <summary>
		/// Matrix4x3f component: column 4, row 2.
		/// </summary>
		internal float _M31;

		/// <summary>
		/// Matrix4x3f component: column 4, row 3.
		/// </summary>
		internal float _M32;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3f Column0
		{
			get { return new Vertex3f(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3f Column1
		{
			get { return new Vertex3f(_M10, _M11, _M12); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex3f Column2
		{
			get { return new Vertex3f(_M20, _M21, _M22); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex3f Column3
		{
			get { return new Vertex3f(_M30, _M31, _M32); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4f Row0
		{
			get { return new Vertex4f(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4f Row1
		{
			get { return new Vertex4f(_M01, _M11, _M21, _M31); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex4f Row2
		{
			get { return new Vertex4f(_M02, _M12, _M22, _M32); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							case 2: return _M32;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							case 2: _M32 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x3f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x3f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x3f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x3f operator*(Matrix4x3f m, float v)
		{
			Matrix4x3f r = new Matrix4x3f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;
			r._M32 = m._M32 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x3f m1, Matrix4x3f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x3f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x3f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x3f m1, Matrix4x3f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix4x3f a)
		{
			float[] m = new float[12];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;
			m[6] = a._M20;
			m[7] = a._M21;
			m[8] = a._M22;
			m[9] = a._M30;
			m[10] = a._M31;
			m[11] = a._M32;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x3d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x3d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix4x3d(Matrix4x3f a)
		{
			return new Matrix4x3d(
				a._M00, a._M01, a._M02, 
				a._M10, a._M11, a._M12, 
				a._M20, a._M21, a._M22, 
				a._M30, a._M31, a._M32
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x3f.
		/// </summary>
		public Matrix3x4f Transposed
		{
			get
			{
				Matrix3x4f tranposed = new Matrix3x4f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;
				tranposed._M23 = _M32;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x3f Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x3f is equal to another Matrix4x3f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x3f"/> to compare with this Matrix4x3f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x3f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);
			if (Math.Abs(_M32 - other._M32) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x3f is equal to another Matrix4x3f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x3f"/> to compare with this Matrix4x3f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x3f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M30 == other._M30 && _M31 == other._M31 && _M32 == other._M32;
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
			if (obj.GetType() != typeof(Matrix4x3f))
				return (false);
			
			return (Equals((Matrix4x3f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();
				result = (result * 397) ^ _M32.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x3f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||{_M20}, {_M21}, {_M22}||{_M30}, {_M31}, {_M32}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x4f : IEquatable<Matrix4x4f>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x4f specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="float" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="float" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		/// <param name="c20">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c23">
		/// A <see cref="float" /> that specifies the matrix component at column 2 and row 3.
		/// </param>
		/// <param name="c30">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		/// <param name="c32">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 2.
		/// </param>
		/// <param name="c33">
		/// A <see cref="float" /> that specifies the matrix component at column 3 and row 3.
		/// </param>
		public Matrix4x4f(float c00, float c01, float c02, float c03, float c10, float c11, float c12, float c13, float c20, float c21, float c22, float c23, float c30, float c31, float c32, float c33)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M23 = c23;
			_M30 = c30;
			_M31 = c31;
			_M32 = c32;
			_M33 = c33;
		}

		/// <summary>
		/// Construct a Matrix4x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x4f(float[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x4f specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x4f(float[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 16)
				throw new ArgumentException("length must be at least 16", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
			_M20 = c[offset + 8];
			_M21 = c[offset + 9];
			_M22 = c[offset + 10];
			_M23 = c[offset + 11];
			_M30 = c[offset + 12];
			_M31 = c[offset + 13];
			_M32 = c[offset + 14];
			_M33 = c[offset + 15];
		}

		/// <summary>
		/// Construct a Matrix4x4f specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x4f to be copied into this instance.
		/// </param>
		public Matrix4x4f(Matrix4x4f other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M23 = other._M23;
			_M30 = other._M30;
			_M31 = other._M31;
			_M32 = other._M32;
			_M33 = other._M33;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x4f component: column 1, row 1.
		/// </summary>
		internal float _M00;

		/// <summary>
		/// Matrix4x4f component: column 1, row 2.
		/// </summary>
		internal float _M01;

		/// <summary>
		/// Matrix4x4f component: column 1, row 3.
		/// </summary>
		internal float _M02;

		/// <summary>
		/// Matrix4x4f component: column 1, row 4.
		/// </summary>
		internal float _M03;

		/// <summary>
		/// Matrix4x4f component: column 2, row 1.
		/// </summary>
		internal float _M10;

		/// <summary>
		/// Matrix4x4f component: column 2, row 2.
		/// </summary>
		internal float _M11;

		/// <summary>
		/// Matrix4x4f component: column 2, row 3.
		/// </summary>
		internal float _M12;

		/// <summary>
		/// Matrix4x4f component: column 2, row 4.
		/// </summary>
		internal float _M13;

		/// <summary>
		/// Matrix4x4f component: column 3, row 1.
		/// </summary>
		internal float _M20;

		/// <summary>
		/// Matrix4x4f component: column 3, row 2.
		/// </summary>
		internal float _M21;

		/// <summary>
		/// Matrix4x4f component: column 3, row 3.
		/// </summary>
		internal float _M22;

		/// <summary>
		/// Matrix4x4f component: column 3, row 4.
		/// </summary>
		internal float _M23;

		/// <summary>
		/// Matrix4x4f component: column 4, row 1.
		/// </summary>
		internal float _M30;

		/// <summary>
		/// Matrix4x4f component: column 4, row 2.
		/// </summary>
		internal float _M31;

		/// <summary>
		/// Matrix4x4f component: column 4, row 3.
		/// </summary>
		internal float _M32;

		/// <summary>
		/// Matrix4x4f component: column 4, row 4.
		/// </summary>
		internal float _M33;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4f Column0
		{
			get { return new Vertex4f(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4f Column1
		{
			get { return new Vertex4f(_M10, _M11, _M12, _M13); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex4f Column2
		{
			get { return new Vertex4f(_M20, _M21, _M22, _M23); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex4f Column3
		{
			get { return new Vertex4f(_M30, _M31, _M32, _M33); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4f Row0
		{
			get { return new Vertex4f(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4f Row1
		{
			get { return new Vertex4f(_M01, _M11, _M21, _M31); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex4f Row2
		{
			get { return new Vertex4f(_M02, _M12, _M22, _M32); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex4f Row3
		{
			get { return new Vertex4f(_M03, _M13, _M23, _M33); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							case 3: return _M23;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							case 2: return _M32;
							case 3: return _M33;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							case 3: _M23 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							case 2: _M32 = value; break;
							case 3: _M33 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x4f with a float.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="float"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x4f operator*(Matrix4x4f m, float v)
		{
			Matrix4x4f r = new Matrix4x4f();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M23 = m._M23 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;
			r._M32 = m._M32 * v;
			r._M33 = m._M33 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix4x4f with a Vertex4f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex4f operator*(Matrix4x4f m, Vertex4f v)
		{
			Vertex4f r = new Vertex4f();

			r.x = m._M00 * v.x + m._M10 * v.y + m._M20 * v.z + m._M30 * v.w;
			r.y = m._M01 * v.x + m._M11 * v.y + m._M21 * v.z + m._M31 * v.w;
			r.z = m._M02 * v.x + m._M12 * v.y + m._M22 * v.z + m._M32 * v.w;
			r.w = m._M03 * v.x + m._M13 * v.y + m._M23 * v.z + m._M33 * v.w;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix4x4f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4f"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix4x4f"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix4x4f operator*(Matrix4x4f m, Matrix4x4f n)
		{
			Matrix4x4f r = new Matrix4x4f();

#if HAVE_NUMERICS
			if (Vector.IsHardwareAccelerated) {
				unsafe {
					Unsafe.Write(&r, Unsafe.Read<Mat4x4>(&m) * Unsafe.Read<Mat4x4>(&n));
				}
			} else {
#endif
			r._M00 = m._M00 * n._M00 + m._M10 * n._M01 + m._M20 * n._M02 + m._M30 * n._M03;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01 + m._M21 * n._M02 + m._M31 * n._M03;
			r._M02 = m._M02 * n._M00 + m._M12 * n._M01 + m._M22 * n._M02 + m._M32 * n._M03;
			r._M03 = m._M03 * n._M00 + m._M13 * n._M01 + m._M23 * n._M02 + m._M33 * n._M03;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11 + m._M20 * n._M12 + m._M30 * n._M13;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11 + m._M21 * n._M12 + m._M31 * n._M13;
			r._M12 = m._M02 * n._M10 + m._M12 * n._M11 + m._M22 * n._M12 + m._M32 * n._M13;
			r._M13 = m._M03 * n._M10 + m._M13 * n._M11 + m._M23 * n._M12 + m._M33 * n._M13;
			r._M20 = m._M00 * n._M20 + m._M10 * n._M21 + m._M20 * n._M22 + m._M30 * n._M23;
			r._M21 = m._M01 * n._M20 + m._M11 * n._M21 + m._M21 * n._M22 + m._M31 * n._M23;
			r._M22 = m._M02 * n._M20 + m._M12 * n._M21 + m._M22 * n._M22 + m._M32 * n._M23;
			r._M23 = m._M03 * n._M20 + m._M13 * n._M21 + m._M23 * n._M22 + m._M33 * n._M23;
			r._M30 = m._M00 * n._M30 + m._M10 * n._M31 + m._M20 * n._M32 + m._M30 * n._M33;
			r._M31 = m._M01 * n._M30 + m._M11 * n._M31 + m._M21 * n._M32 + m._M31 * n._M33;
			r._M32 = m._M02 * n._M30 + m._M12 * n._M31 + m._M22 * n._M32 + m._M32 * n._M33;
			r._M33 = m._M03 * n._M30 + m._M13 * n._M31 + m._M23 * n._M32 + m._M33 * n._M33;
#if HAVE_NUMERICS
			}
#endif

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x4f m1, Matrix4x4f m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4f"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4f"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x4f m1, Matrix4x4f m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to float[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator float[](Matrix4x4f a)
		{
			float[] m = new float[16];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;
			m[8] = a._M20;
			m[9] = a._M21;
			m[10] = a._M22;
			m[11] = a._M23;
			m[12] = a._M30;
			m[13] = a._M31;
			m[14] = a._M32;
			m[15] = a._M33;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x4d.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> initialized with the matrix components.
		/// </returns>
		public static implicit operator Matrix4x4d(Matrix4x4f a)
		{
			return new Matrix4x4d(
				a._M00, a._M01, a._M02, a._M03, 
				a._M10, a._M11, a._M12, a._M13, 
				a._M20, a._M21, a._M22, a._M23, 
				a._M30, a._M31, a._M32, a._M33
			);
		}

		#endregion

		#region Projections

		/// <summary>
		/// Construct a Matrix4x4f modelling an orthographic projection.
		/// </summary>
		/// <param name="left">
		/// A <see cref="float"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="float"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="float"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="float"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="float"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="float"/> indicating the distance of the far plane, in world units
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing an orthographic projection matrix.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the parameter have an invalid set of values.
		/// </exception>
		public static Matrix4x4f Ortho(float left, float right, float bottom, float top, float near, float far)
		{
			if (Math.Abs(right - left) < float.Epsilon)
				throw new ArgumentException("left/right planes are coincident");
			if (Math.Abs(top - bottom) < float.Epsilon)
				throw new ArgumentException("top/bottom planes are coincident");
			if (Math.Abs(far - near) < float.Epsilon)
				throw new ArgumentException("far/near planes are coincident");

			Matrix4x4f r = new Matrix4x4f();

			r._M00 = 2.0f / (right - left);
			r._M11 = 2.0f / (top - bottom);
			r._M22 = -2.0f / (far - near);
			r._M30 = -(right + left) / (right - left);
			r._M31 = -(top + bottom) / (top - bottom);
			r._M32 = -(far + near) / (far - near);
			r._M33 = 1.0f;

			return r;
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a 2D orthographic projection.
		/// </summary>
		/// <param name="left">
		/// A <see cref="float"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="float"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="float"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="float"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a 2D orthographic projection matrix.
		/// </returns>
		public static Matrix4x4f Ortho2D(float left, float right, float bottom, float top)
		{
			return Ortho(left, right, bottom, top, -1.0f, +1.0f);
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a frustrum perspective projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="float"/> that specifies the frustum left plane distance.
		/// </param>
		/// <param name="right">
		/// A <see cref="float"/> that specifies the frustum right plane distance.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="float"/> that specifies the frustum bottom plane distance.
		/// </param>
		/// <param name="top">
		/// A <see cref="float"/> that specifies the frustum top plane distance.
		/// </param>
		/// <param name="near">
		/// A <see cref="float"/> that specifies the frustum near plane distance.
		/// </param>
		/// <param name="far">
		/// A <see cref="float"/> that specifies the frustum far plane distance.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the parameter have an invalid set of values.
		/// </exception>
		public static Matrix4x4f Frustrum(float left, float right, float bottom, float top, float near, float far)
		{
			if (Math.Abs(right - left) < float.Epsilon)
				throw new ArgumentException("left/right planes are coincident");
			if (Math.Abs(top - bottom) < float.Epsilon)
				throw new ArgumentException("top/bottom planes are coincident");
			if (Math.Abs(far - near) < float.Epsilon)
				throw new ArgumentException("far/near planes are coincident");

			Matrix4x4f r = new Matrix4x4f();

			r._M00 = 2.0f * near / (right - left);
			r._M11 = 2.0f * near / (top - bottom);
			r._M20 = (right + left) / (right - left);
			r._M21 = (top + bottom) / (top - bottom);
			r._M22 = (-far - near) / (far - near);
			r._M23 = -1.0f;
			r._M32 = -2.0f * far * near / (far - near);

			return r;
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a frustrum perspective projection matrix, using FOV angle.
		/// </summary>
		/// <param name="fovy">
		/// A <see cref="float"/> that specifies the vertical Field Of View angle, in degrees.
		/// </param>
		/// <param name="aspectRatio">
		/// A <see cref="float"/> that specifies the view aspect ratio (i.e. the width / height ratio).
		/// </param>
		/// <param name="near">
		/// A <see cref="float"/> that specifies the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="float"/> that specifies the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public static Matrix4x4f Perspective(float fovy, float aspectRatio, float near, float far)
		{
			if (fovy <= 0.0f || fovy >= 180.0f)
				throw new ArgumentOutOfRangeException(nameof(fovy), "not in range (0, 180)");
			if (Math.Abs(near) < float.Epsilon)
				throw new ArgumentOutOfRangeException(nameof(near), "zero not allowed");
			if (Math.Abs(far) < Math.Abs(near))
				throw new ArgumentOutOfRangeException(nameof(far), "less than near");

			float ymax = near * (float)Math.Tan(Angle.ToRadians(fovy / 2.0f));
			float xmax = ymax * aspectRatio;

			return Frustrum(-xmax, +xmax, -ymax, +ymax, near, far);
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling an asymmetric frustrum perspective projection matrix, using FOV angles.
		/// </summary>
		/// <param name="leftFov">
		/// A <see cref="float"/> that specifies the left plane FOV angle, in degrees.
		/// </param>
		/// <param name="rightFov">
		/// A <see cref="float"/> that specifies the right plane FOV angle, in degrees.
		/// </param>
		/// <param name="bottomFov">
		/// A <see cref="float"/> that specifies the bottom plane FOV angle, in degrees.
		/// </param>
		/// <param name="topFov">
		/// A <see cref="float"/> that specifies the top plane FOV angle, in degrees.
		/// </param>
		/// <param name="near">
		/// A <see cref="float"/> that specifies the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="float"/> that specifies the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public static Matrix4x4f Perspective(float leftFov, float rightFov, float bottomFov, float topFov, float near, float far)
		{
			return Frustrum(
				near * (float)Math.Tan(Angle.ToRadians(leftFov)),
				near * (float)Math.Tan(Angle.ToRadians(rightFov)),
				near * (float)Math.Tan(Angle.ToRadians(bottomFov)),
				near * (float)Math.Tan(Angle.ToRadians(topFov)),
				near, far
			);
		}

		#endregion

		#region View Model

		/// <summary>
		/// Get the translation of this Matrix4x4f.
		/// </summary>
		public Vertex3f Position
		{
			get { return ((Vertex3f)new Vertex4f(_M30, _M31, _M32, _M33)); }
		}

		/// <summary>
		/// Get the forward vector of this Matrix4x4f.
		/// </summary>
		public Vertex3f ForwardVector
		{
			get { return new Vertex3f(-_M20, -_M21, -_M22).Normalized; }
		}

		/// <summary>
		/// Get the right vector of this Matrix4x4f.
		/// </summary>
		public Vertex3f RightVector
		{
			get { return new Vertex3f(_M00, _M01, _M02).Normalized; }
		}

		/// <summary>
		/// Get the up vector of this Matrix4x4f.
		/// </summary>
		public Vertex3f UpVector
		{
			get { return new Vertex3f(_M10, _M11, _M12).Normalized; }
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a view transformation.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3f"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3f"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3f"/> that specify the up vector of the view camera abstraction.
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public static Matrix4x4f LookAt(Vertex3f eyePosition, Vertex3f targetPosition, Vertex3f upVector)
		{
			return LookAtDirection(eyePosition, targetPosition - eyePosition, upVector);
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a view transformation.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3f"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="forwardVector">
		/// A <see cref="Vertex3f"/> that specify the direction of the view. It will be normalized.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3f"/> that specify the up vector of the view camera abstraction. It will be normalized
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="forwardVector"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public static Matrix4x4f LookAtDirection(Vertex3f eyePosition, Vertex3f forwardVector, Vertex3f upVector)
		{
			Vertex3f rightVector;

			forwardVector.Normalize();
			
			rightVector = forwardVector ^ upVector.Normalized;
			if (rightVector.Module() <= 0.0f)
				rightVector = Vertex3f.UnitX;
			else
				rightVector.Normalize();

			upVector = (rightVector ^ forwardVector).Normalized;

			// Compute view matrix
			Matrix4x4f r = new Matrix4x4f();

			// Row 0: right vector
			r._M00 = rightVector.x;
			r._M10 = rightVector.y;
			r._M20 = rightVector.z;
			// Row 1: up vector
			r._M01 = upVector.x;
			r._M11 = upVector.y;
			r._M21 = upVector.z;
			// Row 2: opposite of forward vector
			r._M02 = -forwardVector.x;
			r._M12 = -forwardVector.y;
			r._M22 = -forwardVector.z;

			r._M33 = 1.0f;

			// Eye position
			r.Translate(-eyePosition.x, -eyePosition.y, -eyePosition.z);

			return r;
		}

		#endregion

		#region Translation

		/// <summary>
		/// Construct a Matrix4x4f modelling a translation.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the translation on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a translation matrix.
		/// </returns>
		public static Matrix4x4f Translated(float x, float y, float z)
		{
			Matrix4x4f r = new Matrix4x4f();

			r._M00 = r._M11 = r._M22 = r._M33 = 1.0f;
			r._M30 = x;
			r._M31 = y;
			r._M32 = z;

			return r;
		}

		/// <summary>
		/// Translates this Matrix4x4f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the translation on Z axis.
		/// </param>
		public void Translate(float x, float y, float z)
		{
			this = this * Translated(x, y, z);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix4x4f modelling a rotation around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a matrix rotating on X axis.
		/// </returns>
		public static Matrix4x4f RotatedX(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix4x4f r = new Matrix4x4f();

			r._M11 = +cosa;
			r._M21 = -sina;
			r._M12 = +sina;
			r._M22 = +cosa;
			r._M00 = r._M33 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4f around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateX(float angle)
		{
			this = this * RotatedX(angle);
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a rotation around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a matrix rotating on Y axis.
		/// </returns>
		public static Matrix4x4f RotatedY(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix4x4f r = new Matrix4x4f();

			r._M00 = +cosa;
			r._M20 = +sina;
			r._M02 = -sina;
			r._M22 = +cosa;
			r._M11 = r._M33 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4f around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateY(float angle)
		{
			this = this * RotatedY(angle);
		}

		/// <summary>
		/// Construct a Matrix4x4f modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix4x4f RotatedZ(float angle)
		{
			float a = Angle.ToRadians(angle);
			float cosa = (float)Math.Cos(a);
			float sina = (float)Math.Sin(a);
			Matrix4x4f r = new Matrix4x4f();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;
			r._M22 = r._M33 = 1.0f;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4f around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(float angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Scaling

		/// <summary>
		/// Compute the scaled of this Matrix4x4f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the scale on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> representing a scaling matrix.
		/// </returns>
		public static Matrix4x4f Scaled(float x, float y, float z)
		{
			Matrix4x4f scaled = new Matrix4x4f();

			scaled._M00 = x;
			scaled._M11 = y;
			scaled._M22 = z;
			scaled._M33 = 1.0f;

			return scaled;
		}

		/// <summary>
		/// Scale this Matrix4x4f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specifies the scale on Z axis.
		/// </param>
		public void Scale(float x, float y, float z)
		{
			this = this * Scaled(x, y, z);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x4f.
		/// </summary>
		public Matrix4x4f Transposed
		{
			get
			{
				Matrix4x4f tranposed = new Matrix4x4f();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M32 = _M23;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;
				tranposed._M23 = _M32;
				tranposed._M33 = _M33;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix4x4f.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
			_M02 = Interlocked.Exchange(ref _M20, _M02);
			_M12 = Interlocked.Exchange(ref _M21, _M12);
			_M03 = Interlocked.Exchange(ref _M30, _M03);
			_M13 = Interlocked.Exchange(ref _M31, _M13);
			_M23 = Interlocked.Exchange(ref _M32, _M23);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix4x4f.
		/// </summary>
		public float Determinant
		{
			get
			{
				Matrix3x3f c0 = new Matrix3x3f(this, 0, 0);
				Matrix3x3f c1 = new Matrix3x3f(this, 0, 1);
				Matrix3x3f c2 = new Matrix3x3f(this, 0, 2);
				Matrix3x3f c3 = new Matrix3x3f(this, 0, 3);

				return +c0.Determinant * _M00 + -c1.Determinant * _M01 + +c2.Determinant * _M02 + -c3.Determinant * _M03;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix4x4f.
		/// </summary>
		public Matrix4x4f Inverse
		{
			get
			{
#if HAVE_NUMERICS
				if (Vector.IsHardwareAccelerated) {
					Matrix4x4f inverse = new Matrix4x4f();

					unsafe {
						fixed (Matrix4x4f* thisPtr = &this) {
							Mat4x4 m = Unsafe.Read<Mat4x4>(thisPtr), i;

							if (Mat4x4.Invert(m, out i) == false)
								throw new InvalidOperationException("not invertible");

							Unsafe.Write(&inverse, i);
						}
					}

					return (inverse);
				} else {
#endif
				float inv00 =  _M11 * _M22 * _M33 - _M11 * _M23 * _M32 - _M21 * _M12 * _M33 + _M21 * _M13 * _M32 + _M31 * _M12 * _M23 - _M31 * _M13 * _M22;
				float inv10 = -_M10 * _M22 * _M33 + _M10 * _M23 * _M32 + _M20 * _M12 * _M33 - _M20 * _M13 * _M32 - _M30 * _M12 * _M23 + _M30 * _M13 * _M22;
				float inv20 =  _M10 * _M21 * _M33 - _M10 * _M23 * _M31 - _M20 * _M11 * _M33 + _M20 * _M13 * _M31 + _M30 * _M11 * _M23 - _M30 * _M13 * _M21;
				float inv30 = -_M10 * _M21 * _M32 + _M10 * _M22 * _M31 + _M20 * _M11 * _M32 - _M20 * _M12 * _M31 - _M30 * _M11 * _M22 + _M30 * _M12 * _M21;
				float inv01 = -_M01 * _M22 * _M33 + _M01 * _M23 * _M32 + _M21 * _M02 * _M33 - _M21 * _M03 * _M32 - _M31 * _M02 * _M23 + _M31 * _M03 * _M22;
				float inv11 =  _M00 * _M22 * _M33 - _M00 * _M23 * _M32 - _M20 * _M02 * _M33 + _M20 * _M03 * _M32 + _M30 * _M02 * _M23 - _M30 * _M03 * _M22;
				float inv21 = -_M00 * _M21 * _M33 + _M00 * _M23 * _M31 + _M20 * _M01 * _M33 - _M20 * _M03 * _M31 - _M30 * _M01 * _M23 + _M30 * _M03 * _M21;
				float inv31 =  _M00 * _M21 * _M32 - _M00 * _M22 * _M31 - _M20 * _M01 * _M32 + _M20 * _M02 * _M31 + _M30 * _M01 * _M22 - _M30 * _M02 * _M21;
				float inv02 =  _M01 * _M12 * _M33 - _M01 * _M13 * _M32 - _M11 * _M02 * _M33 + _M11 * _M03 * _M32 + _M31 * _M02 * _M13 - _M31 * _M03 * _M12;
				float inv12 = -_M00 * _M12 * _M33 + _M00 * _M13 * _M32 + _M10 * _M02 * _M33 - _M10 * _M03 * _M32 - _M30 * _M02 * _M13 + _M30 * _M03 * _M12;
				float inv22 =  _M00 * _M11 * _M33 - _M00 * _M13 * _M31 - _M10 * _M01 * _M33 + _M10 * _M03 * _M31 + _M30 * _M01 * _M13 - _M30 * _M03 * _M11;
				float inv32 = -_M00 * _M11 * _M32 + _M00 * _M12 * _M31 + _M10 * _M01 * _M32 - _M10 * _M02 * _M31 - _M30 * _M01 * _M12 + _M30 * _M02 * _M11;
				float inv03 = -_M01 * _M12 * _M23 + _M01 * _M13 * _M22 + _M11 * _M02 * _M23 - _M11 * _M03 * _M22 - _M21 * _M02 * _M13 + _M21 * _M03 * _M12;
				float inv13 =  _M00 * _M12 * _M23 - _M00 * _M13 * _M22 - _M10 * _M02 * _M23 + _M10 * _M03 * _M22 + _M20 * _M02 * _M13 - _M20 * _M03 * _M12;
				float inv23 = -_M00 * _M11 * _M23 + _M00 * _M13 * _M21 + _M10 * _M01 * _M23 - _M10 * _M03 * _M21 - _M20 * _M01 * _M13 + _M20 * _M03 * _M11;
				float inv33 =  _M00 * _M11 * _M22 - _M00 * _M12 * _M21 - _M10 * _M01 * _M22 + _M10 * _M02 * _M21 + _M20 * _M01 * _M12 - _M20 * _M02 * _M11;

				float det = _M00 * inv00 + _M01 * inv10 + _M02 * inv20 + _M03 * inv30;

				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");

				det = 1.0f / det;

				return new Matrix4x4f(
					det * inv00, det * inv01, det * inv02, det * inv03, 
					det * inv10, det * inv11, det * inv12, det * inv13, 
					det * inv20, det * inv21, det * inv22, det * inv23, 
					det * inv30, det * inv31, det * inv32, det * inv33
				);
#if HAVE_NUMERICS
				}
#endif
			}
		}

		/// <summary>
		/// Invert this Matrix4x4f.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x4f Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix4x4f Identity = new Matrix4x4f(
			1.0f, 0.0f, 0.0f, 0.0f, 
			0.0f, 1.0f, 0.0f, 0.0f, 
			0.0f, 0.0f, 1.0f, 0.0f, 
			0.0f, 0.0f, 0.0f, 1.0f
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x4f is equal to another Matrix4x4f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x4f"/> to compare with this Matrix4x4f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x4f other, float precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M23 - other._M23) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);
			if (Math.Abs(_M32 - other._M32) > precision)
				return (false);
			if (Math.Abs(_M33 - other._M33) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x4f is equal to another Matrix4x4f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x4f"/> to compare with this Matrix4x4f.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x4f other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M23 == other._M23 && _M30 == other._M30 && _M31 == other._M31 && _M32 == other._M32 && _M33 == other._M33;
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
			if (obj.GetType() != typeof(Matrix4x4f))
				return (false);
			
			return (Equals((Matrix4x4f)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M23.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();
				result = (result * 397) ^ _M32.GetHashCode();
				result = (result * 397) ^ _M33.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x4f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x4f.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||{_M20}, {_M21}, {_M22}, {_M23}||{_M30}, {_M31}, {_M32}, {_M33}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x2d : IEquatable<Matrix2x2d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x2d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		public Matrix2x2d(double c00, double c01, double c10, double c11)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
		}

		/// <summary>
		/// Construct a Matrix2x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x2d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x2d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 4)
				throw new ArgumentException("length must be at least 4", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
		}

		/// <summary>
		/// Construct a Matrix2x2d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x2d to be copied into this instance.
		/// </param>
		public Matrix2x2d(Matrix2x2d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x2d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix2x2d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix2x2d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix2x2d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2d Column0
		{
			get { return new Vertex2d(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2d Column1
		{
			get { return new Vertex2d(_M10, _M11); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2d Row0
		{
			get { return new Vertex2d(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2d Row1
		{
			get { return new Vertex2d(_M01, _M11); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x2d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x2d operator*(Matrix2x2d m, double v)
		{
			Matrix2x2d r = new Matrix2x2d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix2x2d with a Vertex2d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex2d operator*(Matrix2x2d m, Vertex2d v)
		{
			Vertex2d r = new Vertex2d();

			r.x = m._M00 * v.x + m._M10 * v.y;
			r.y = m._M01 * v.x + m._M11 * v.y;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix2x2d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x2d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix2x2d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2d"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix2x2d operator*(Matrix2x2d m, Matrix2x2d n)
		{
			Matrix2x2d r = new Matrix2x2d();

			r._M00 = m._M00 * n._M00 + m._M10 * n._M01;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x2d m1, Matrix2x2d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x2d m1, Matrix2x2d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix2x2d a)
		{
			double[] m = new double[4];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x2f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix2x2f(Matrix2x2d a)
		{
			return new Matrix2x2f(
				(float)a._M00, (float)a._M01, 
				(float)a._M10, (float)a._M11
			);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix2x2d modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x2d"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix2x2d RotatedZ(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix2x2d r = new Matrix2x2d();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix2x2d around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(double angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x2d.
		/// </summary>
		public Matrix2x2d Transposed
		{
			get
			{
				Matrix2x2d tranposed = new Matrix2x2d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix2x2d.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix2x2d.
		/// </summary>
		public double Determinant
		{
			get
			{
				return _M00 * _M11 - _M10 * _M01;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix2x2d.
		/// </summary>
		public Matrix2x2d Inverse
		{
			get
			{
				double det = Determinant;
				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");
				det = 1.0 / det;
				
				return new Matrix2x2d(
					+_M11 * det, -_M01 * det,
					-_M10 * det, +_M00 * det
				);
			}
		}

		/// <summary>
		/// Invert this Matrix2x2d.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x2d Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix2x2d Identity = new Matrix2x2d(
			1.0, 0.0, 
			0.0, 1.0
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x2d is equal to another Matrix2x2d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x2d"/> to compare with this Matrix2x2d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x2d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x2d is equal to another Matrix2x2d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x2d"/> to compare with this Matrix2x2d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x2d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11;
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
			if (obj.GetType() != typeof(Matrix2x2d))
				return (false);
			
			return (Equals((Matrix2x2d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x2d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x2d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x3d : IEquatable<Matrix2x3d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x3d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		public Matrix2x3d(double c00, double c01, double c02, double c10, double c11, double c12)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
		}

		/// <summary>
		/// Construct a Matrix2x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x3d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x3d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 6)
				throw new ArgumentException("length must be at least 6", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
		}

		/// <summary>
		/// Construct a Matrix2x3d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x3d to be copied into this instance.
		/// </param>
		public Matrix2x3d(Matrix2x3d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x3d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix2x3d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix2x3d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix2x3d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix2x3d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix2x3d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3d Column0
		{
			get { return new Vertex3d(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3d Column1
		{
			get { return new Vertex3d(_M10, _M11, _M12); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2d Row0
		{
			get { return new Vertex2d(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2d Row1
		{
			get { return new Vertex2d(_M01, _M11); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex2d Row2
		{
			get { return new Vertex2d(_M02, _M12); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x3d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x3d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x3d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x3d operator*(Matrix2x3d m, double v)
		{
			Matrix2x3d r = new Matrix2x3d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x3d m1, Matrix2x3d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x3d m1, Matrix2x3d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix2x3d a)
		{
			double[] m = new double[6];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x3f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x3f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix2x3f(Matrix2x3d a)
		{
			return new Matrix2x3f(
				(float)a._M00, (float)a._M01, (float)a._M02, 
				(float)a._M10, (float)a._M11, (float)a._M12
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x3d.
		/// </summary>
		public Matrix3x2d Transposed
		{
			get
			{
				Matrix3x2d tranposed = new Matrix3x2d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x3d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x3d is equal to another Matrix2x3d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x3d"/> to compare with this Matrix2x3d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x3d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x3d is equal to another Matrix2x3d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x3d"/> to compare with this Matrix2x3d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x3d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12;
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
			if (obj.GetType() != typeof(Matrix2x3d))
				return (false);
			
			return (Equals((Matrix2x3d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x3d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x3d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x4d : IEquatable<Matrix2x4d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix2x4d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		public Matrix2x4d(double c00, double c01, double c02, double c03, double c10, double c11, double c12, double c13)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
		}

		/// <summary>
		/// Construct a Matrix2x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix2x4d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix2x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix2x4d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 8)
				throw new ArgumentException("length must be at least 8", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
		}

		/// <summary>
		/// Construct a Matrix2x4d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix2x4d to be copied into this instance.
		/// </param>
		public Matrix2x4d(Matrix2x4d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x4d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix2x4d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix2x4d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix2x4d component: column 1, row 4.
		/// </summary>
		internal double _M03;

		/// <summary>
		/// Matrix2x4d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix2x4d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix2x4d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		/// <summary>
		/// Matrix2x4d component: column 2, row 4.
		/// </summary>
		internal double _M13;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4d Column0
		{
			get { return new Vertex4d(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4d Column1
		{
			get { return new Vertex4d(_M10, _M11, _M12, _M13); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex2d Row0
		{
			get { return new Vertex2d(_M00, _M10); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex2d Row1
		{
			get { return new Vertex2d(_M01, _M11); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex2d Row2
		{
			get { return new Vertex2d(_M02, _M12); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex2d Row3
		{
			get { return new Vertex2d(_M03, _M13); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 2 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix2x4d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix2x4d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x4d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix2x4d operator*(Matrix2x4d m, double v)
		{
			Matrix2x4d r = new Matrix2x4d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix2x4d m1, Matrix2x4d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix2x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix2x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix2x4d m1, Matrix2x4d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix2x4d a)
		{
			double[] m = new double[8];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix2x4f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix2x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix2x4f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix2x4f(Matrix2x4d a)
		{
			return new Matrix2x4f(
				(float)a._M00, (float)a._M01, (float)a._M02, (float)a._M03, 
				(float)a._M10, (float)a._M11, (float)a._M12, (float)a._M13
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix2x4d.
		/// </summary>
		public Matrix4x2d Transposed
		{
			get
			{
				Matrix4x2d tranposed = new Matrix4x2d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix2x4d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix2x4d is equal to another Matrix2x4d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x4d"/> to compare with this Matrix2x4d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x4d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix2x4d is equal to another Matrix2x4d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix2x4d"/> to compare with this Matrix2x4d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix2x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix2x4d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13;
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
			if (obj.GetType() != typeof(Matrix2x4d))
				return (false);
			
			return (Equals((Matrix2x4d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix2x4d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix2x4d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x2d : IEquatable<Matrix3x2d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x2d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		public Matrix3x2d(double c00, double c01, double c10, double c11, double c20, double c21)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
			_M20 = c20;
			_M21 = c21;
		}

		/// <summary>
		/// Construct a Matrix3x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x2d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x2d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 6)
				throw new ArgumentException("length must be at least 6", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
			_M20 = c[offset + 4];
			_M21 = c[offset + 5];
		}

		/// <summary>
		/// Construct a Matrix3x2d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x2d to be copied into this instance.
		/// </param>
		public Matrix3x2d(Matrix3x2d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
			_M20 = other._M20;
			_M21 = other._M21;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x2d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix3x2d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix3x2d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix3x2d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix3x2d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix3x2d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2d Column0
		{
			get { return new Vertex2d(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2d Column1
		{
			get { return new Vertex2d(_M10, _M11); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex2d Column2
		{
			get { return new Vertex2d(_M20, _M21); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3d Row0
		{
			get { return new Vertex3d(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3d Row1
		{
			get { return new Vertex3d(_M01, _M11, _M21); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x2d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x2d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x2d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x2d operator*(Matrix3x2d m, double v)
		{
			Matrix3x2d r = new Matrix3x2d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x2d m1, Matrix3x2d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x2d m1, Matrix3x2d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix3x2d a)
		{
			double[] m = new double[6];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;
			m[4] = a._M20;
			m[5] = a._M21;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x2f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x2f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix3x2f(Matrix3x2d a)
		{
			return new Matrix3x2f(
				(float)a._M00, (float)a._M01, 
				(float)a._M10, (float)a._M11, 
				(float)a._M20, (float)a._M21
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x2d.
		/// </summary>
		public Matrix2x3d Transposed
		{
			get
			{
				Matrix2x3d tranposed = new Matrix2x3d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x2d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x2d is equal to another Matrix3x2d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x2d"/> to compare with this Matrix3x2d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x2d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x2d is equal to another Matrix3x2d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x2d"/> to compare with this Matrix3x2d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x2d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11 && _M20 == other._M20 && _M21 == other._M21;
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
			if (obj.GetType() != typeof(Matrix3x2d))
				return (false);
			
			return (Equals((Matrix3x2d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x2d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x2d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||{_M20}, {_M21}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x3d : IEquatable<Matrix3x3d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x3d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		public Matrix3x3d(double c00, double c01, double c02, double c10, double c11, double c12, double c20, double c21, double c22)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
		}

		/// <summary>
		/// Construct a Matrix3x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x3d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x3d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 9)
				throw new ArgumentException("length must be at least 9", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
			_M20 = c[offset + 6];
			_M21 = c[offset + 7];
			_M22 = c[offset + 8];
		}

		/// <summary>
		/// Construct a Matrix3x3d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x3d to be copied into this instance.
		/// </param>
		public Matrix3x3d(Matrix3x3d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
		}

		/// <summary>
		/// Construct the complement matrix of a Matrix4x4d.
		/// </summary>
		/// <param name="other">
		/// The Matrix4x4d to be copied into this instance.
		/// </param>
		/// <param name="c">
		/// The index of column to be excluded to construct the complement matrix.
		/// </param>
		/// <param name="r">
		/// The index of row to be excluded to construct the complement matrix.
		/// </param>
		public Matrix3x3d(Matrix4x4d other, uint c, uint r)
		{
			if (c >= 4)
				throw new ArgumentOutOfRangeException(nameof(c));
			if (r >= 4)
				throw new ArgumentOutOfRangeException(nameof(r));

			_M00 = _M01 = _M02 = _M10 = _M11 = _M12 = _M20 = _M21 = _M22 =  0.0;
			for (uint ic = 0; ic < 3; ic++)
				for (uint ir = 0; ir < 3; ir++)
					this[ic, ir] = other[ic < c ? ic : ic + 1, ir < r ? ir : ir + 1];
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x3d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix3x3d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix3x3d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix3x3d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix3x3d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix3x3d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		/// <summary>
		/// Matrix3x3d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix3x3d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		/// <summary>
		/// Matrix3x3d component: column 3, row 3.
		/// </summary>
		internal double _M22;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3d Column0
		{
			get { return new Vertex3d(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3d Column1
		{
			get { return new Vertex3d(_M10, _M11, _M12); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex3d Column2
		{
			get { return new Vertex3d(_M20, _M21, _M22); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3d Row0
		{
			get { return new Vertex3d(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3d Row1
		{
			get { return new Vertex3d(_M01, _M11, _M21); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex3d Row2
		{
			get { return new Vertex3d(_M02, _M12, _M22); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x3d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x3d operator*(Matrix3x3d m, double v)
		{
			Matrix3x3d r = new Matrix3x3d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix3x3d with a Vertex3d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex3d operator*(Matrix3x3d m, Vertex3d v)
		{
			Vertex3d r = new Vertex3d();

			r.x = m._M00 * v.x + m._M10 * v.y + m._M20 * v.z;
			r.y = m._M01 * v.x + m._M11 * v.y + m._M21 * v.z;
			r.z = m._M02 * v.x + m._M12 * v.y + m._M22 * v.z;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix3x3d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x3d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix3x3d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix3x3d operator*(Matrix3x3d m, Matrix3x3d n)
		{
			Matrix3x3d r = new Matrix3x3d();

			r._M00 = m._M00 * n._M00 + m._M10 * n._M01 + m._M20 * n._M02;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01 + m._M21 * n._M02;
			r._M02 = m._M02 * n._M00 + m._M12 * n._M01 + m._M22 * n._M02;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11 + m._M20 * n._M12;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11 + m._M21 * n._M12;
			r._M12 = m._M02 * n._M10 + m._M12 * n._M11 + m._M22 * n._M12;
			r._M20 = m._M00 * n._M20 + m._M10 * n._M21 + m._M20 * n._M22;
			r._M21 = m._M01 * n._M20 + m._M11 * n._M21 + m._M21 * n._M22;
			r._M22 = m._M02 * n._M20 + m._M12 * n._M21 + m._M22 * n._M22;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x3d m1, Matrix3x3d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x3d m1, Matrix3x3d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix3x3d a)
		{
			double[] m = new double[9];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;
			m[6] = a._M20;
			m[7] = a._M21;
			m[8] = a._M22;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x3f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix3x3f(Matrix3x3d a)
		{
			return new Matrix3x3f(
				(float)a._M00, (float)a._M01, (float)a._M02, 
				(float)a._M10, (float)a._M11, (float)a._M12, 
				(float)a._M20, (float)a._M21, (float)a._M22
			);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix3x3d modelling a rotation around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> representing a matrix rotating on X axis.
		/// </returns>
		public static Matrix3x3d RotatedX(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix3x3d r = new Matrix3x3d();

			r._M11 = +cosa;
			r._M21 = -sina;
			r._M12 = +sina;
			r._M22 = +cosa;
			r._M00 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3d around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateX(double angle)
		{
			this = this * RotatedX(angle);
		}

		/// <summary>
		/// Construct a Matrix3x3d modelling a rotation around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> representing a matrix rotating on Y axis.
		/// </returns>
		public static Matrix3x3d RotatedY(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix3x3d r = new Matrix3x3d();

			r._M00 = +cosa;
			r._M20 = +sina;
			r._M02 = -sina;
			r._M22 = +cosa;
			r._M11 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3d around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateY(double angle)
		{
			this = this * RotatedY(angle);
		}

		/// <summary>
		/// Construct a Matrix3x3d modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix3x3d RotatedZ(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix3x3d r = new Matrix3x3d();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;
			r._M22 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix3x3d around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(double angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Scaling

		/// <summary>
		/// Compute the scaled of this Matrix3x3d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the scale on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x3d"/> representing a scaling matrix.
		/// </returns>
		public static Matrix3x3d Scaled(double x, double y, double z)
		{
			Matrix3x3d scaled = new Matrix3x3d();

			scaled._M00 = x;
			scaled._M11 = y;
			scaled._M22 = z;

			return scaled;
		}

		/// <summary>
		/// Scale this Matrix3x3d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the scale on Z axis.
		/// </param>
		public void Scale(double x, double y, double z)
		{
			this = this * Scaled(x, y, z);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x3d.
		/// </summary>
		public Matrix3x3d Transposed
		{
			get
			{
				Matrix3x3d tranposed = new Matrix3x3d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix3x3d.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
			_M02 = Interlocked.Exchange(ref _M20, _M02);
			_M12 = Interlocked.Exchange(ref _M21, _M12);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix3x3d.
		/// </summary>
		public double Determinant
		{
			get
			{
				double a = _M00, b = _M10, c = _M20;
				double d = _M01, e = _M11, f = _M21;
				double g = _M02, h = _M12, k = _M22;

				return (e * k - f * h) * a + -(d * k - f * g) * b + (d * h - e * g) * c;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix3x3d.
		/// </summary>
		public Matrix3x3d Inverse
		{
			get
			{
				double det = Determinant;
				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");
				det = 1.0 / det;

				double a = _M00, b = _M10, c = _M20;
				double d = _M01, e = _M11, f = _M21;
				double g = _M02, h = _M12, k = _M22;

				return new Matrix3x3d(
					 (e * k - f * h) * det, -(d * k - f * g) * det,  (d * h - e * g) * det,
					-(b * k - c * h) * det,  (a * k - c * g) * det, -(a * h - b * g) * det,
					 (b * f - c * e) * det, -(a * f - c * d) * det,  (a * e - b * d) * det
				);
			}
		}

		/// <summary>
		/// Invert this Matrix3x3d.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x3d Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix3x3d Identity = new Matrix3x3d(
			1.0, 0.0, 0.0, 
			0.0, 1.0, 0.0, 
			0.0, 0.0, 1.0
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x3d is equal to another Matrix3x3d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x3d"/> to compare with this Matrix3x3d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x3d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x3d is equal to another Matrix3x3d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x3d"/> to compare with this Matrix3x3d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x3d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22;
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
			if (obj.GetType() != typeof(Matrix3x3d))
				return (false);
			
			return (Equals((Matrix3x3d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x3d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x3d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||{_M20}, {_M21}, {_M22}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x4d : IEquatable<Matrix3x4d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix3x4d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c23">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 3.
		/// </param>
		public Matrix3x4d(double c00, double c01, double c02, double c03, double c10, double c11, double c12, double c13, double c20, double c21, double c22, double c23)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M23 = c23;
		}

		/// <summary>
		/// Construct a Matrix3x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix3x4d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix3x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix3x4d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 12)
				throw new ArgumentException("length must be at least 12", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
			_M20 = c[offset + 8];
			_M21 = c[offset + 9];
			_M22 = c[offset + 10];
			_M23 = c[offset + 11];
		}

		/// <summary>
		/// Construct a Matrix3x4d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix3x4d to be copied into this instance.
		/// </param>
		public Matrix3x4d(Matrix3x4d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M23 = other._M23;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x4d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix3x4d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix3x4d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix3x4d component: column 1, row 4.
		/// </summary>
		internal double _M03;

		/// <summary>
		/// Matrix3x4d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix3x4d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix3x4d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		/// <summary>
		/// Matrix3x4d component: column 2, row 4.
		/// </summary>
		internal double _M13;

		/// <summary>
		/// Matrix3x4d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix3x4d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		/// <summary>
		/// Matrix3x4d component: column 3, row 3.
		/// </summary>
		internal double _M22;

		/// <summary>
		/// Matrix3x4d component: column 3, row 4.
		/// </summary>
		internal double _M23;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4d Column0
		{
			get { return new Vertex4d(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4d Column1
		{
			get { return new Vertex4d(_M10, _M11, _M12, _M13); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex4d Column2
		{
			get { return new Vertex4d(_M20, _M21, _M22, _M23); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex3d Row0
		{
			get { return new Vertex3d(_M00, _M10, _M20); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex3d Row1
		{
			get { return new Vertex3d(_M01, _M11, _M21); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex3d Row2
		{
			get { return new Vertex3d(_M02, _M12, _M22); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex3d Row3
		{
			get { return new Vertex3d(_M03, _M13, _M23); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 3 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							case 3: return _M23;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							case 3: _M23 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix3x4d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix3x4d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x4d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix3x4d operator*(Matrix3x4d m, double v)
		{
			Matrix3x4d r = new Matrix3x4d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M23 = m._M23 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix3x4d m1, Matrix3x4d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix3x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix3x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix3x4d m1, Matrix3x4d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix3x4d a)
		{
			double[] m = new double[12];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;
			m[8] = a._M20;
			m[9] = a._M21;
			m[10] = a._M22;
			m[11] = a._M23;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix3x4f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix3x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix3x4f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix3x4f(Matrix3x4d a)
		{
			return new Matrix3x4f(
				(float)a._M00, (float)a._M01, (float)a._M02, (float)a._M03, 
				(float)a._M10, (float)a._M11, (float)a._M12, (float)a._M13, 
				(float)a._M20, (float)a._M21, (float)a._M22, (float)a._M23
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix3x4d.
		/// </summary>
		public Matrix4x3d Transposed
		{
			get
			{
				Matrix4x3d tranposed = new Matrix4x3d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M32 = _M23;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix3x4d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix3x4d is equal to another Matrix3x4d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x4d"/> to compare with this Matrix3x4d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x4d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M23 - other._M23) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix3x4d is equal to another Matrix3x4d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix3x4d"/> to compare with this Matrix3x4d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix3x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix3x4d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M23 == other._M23;
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
			if (obj.GetType() != typeof(Matrix3x4d))
				return (false);
			
			return (Equals((Matrix3x4d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M23.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix3x4d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix3x4d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||{_M20}, {_M21}, {_M22}, {_M23}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x2d : IEquatable<Matrix4x2d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x2d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c30">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		public Matrix4x2d(double c00, double c01, double c10, double c11, double c20, double c21, double c30, double c31)
		{
			_M00 = c00;
			_M01 = c01;
			_M10 = c10;
			_M11 = c11;
			_M20 = c20;
			_M21 = c21;
			_M30 = c30;
			_M31 = c31;
		}

		/// <summary>
		/// Construct a Matrix4x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x2d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x2d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x2d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 8)
				throw new ArgumentException("length must be at least 8", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M10 = c[offset + 2];
			_M11 = c[offset + 3];
			_M20 = c[offset + 4];
			_M21 = c[offset + 5];
			_M30 = c[offset + 6];
			_M31 = c[offset + 7];
		}

		/// <summary>
		/// Construct a Matrix4x2d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x2d to be copied into this instance.
		/// </param>
		public Matrix4x2d(Matrix4x2d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M10 = other._M10;
			_M11 = other._M11;
			_M20 = other._M20;
			_M21 = other._M21;
			_M30 = other._M30;
			_M31 = other._M31;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x2d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix4x2d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix4x2d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix4x2d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix4x2d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix4x2d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		/// <summary>
		/// Matrix4x2d component: column 4, row 1.
		/// </summary>
		internal double _M30;

		/// <summary>
		/// Matrix4x2d component: column 4, row 2.
		/// </summary>
		internal double _M31;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex2d Column0
		{
			get { return new Vertex2d(_M00, _M01); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex2d Column1
		{
			get { return new Vertex2d(_M10, _M11); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex2d Column2
		{
			get { return new Vertex2d(_M20, _M21); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex2d Column3
		{
			get { return new Vertex2d(_M30, _M31); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4d Row0
		{
			get { return new Vertex4d(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4d Row1
		{
			get { return new Vertex4d(_M01, _M11, _M21, _M31); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 2 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x2d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x2d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x2d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x2d operator*(Matrix4x2d m, double v)
		{
			Matrix4x2d r = new Matrix4x2d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x2d m1, Matrix4x2d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x2d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x2d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x2d m1, Matrix4x2d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix4x2d a)
		{
			double[] m = new double[8];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M10;
			m[3] = a._M11;
			m[4] = a._M20;
			m[5] = a._M21;
			m[6] = a._M30;
			m[7] = a._M31;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x2f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x2f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix4x2f(Matrix4x2d a)
		{
			return new Matrix4x2f(
				(float)a._M00, (float)a._M01, 
				(float)a._M10, (float)a._M11, 
				(float)a._M20, (float)a._M21, 
				(float)a._M30, (float)a._M31
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x2d.
		/// </summary>
		public Matrix2x4d Transposed
		{
			get
			{
				Matrix2x4d tranposed = new Matrix2x4d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x2d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x2d is equal to another Matrix4x2d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x2d"/> to compare with this Matrix4x2d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x2d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x2d is equal to another Matrix4x2d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x2d"/> to compare with this Matrix4x2d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x2d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x2d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M10 == other._M10 && _M11 == other._M11 && _M20 == other._M20 && _M21 == other._M21 && _M30 == other._M30 && _M31 == other._M31;
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
			if (obj.GetType() != typeof(Matrix4x2d))
				return (false);
			
			return (Equals((Matrix4x2d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x2d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x2d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}||{_M10}, {_M11}||{_M20}, {_M21}||{_M30}, {_M31}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x3d : IEquatable<Matrix4x3d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x3d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c30">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		/// <param name="c32">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 2.
		/// </param>
		public Matrix4x3d(double c00, double c01, double c02, double c10, double c11, double c12, double c20, double c21, double c22, double c30, double c31, double c32)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M30 = c30;
			_M31 = c31;
			_M32 = c32;
		}

		/// <summary>
		/// Construct a Matrix4x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x3d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x3d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x3d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 12)
				throw new ArgumentException("length must be at least 12", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M10 = c[offset + 3];
			_M11 = c[offset + 4];
			_M12 = c[offset + 5];
			_M20 = c[offset + 6];
			_M21 = c[offset + 7];
			_M22 = c[offset + 8];
			_M30 = c[offset + 9];
			_M31 = c[offset + 10];
			_M32 = c[offset + 11];
		}

		/// <summary>
		/// Construct a Matrix4x3d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x3d to be copied into this instance.
		/// </param>
		public Matrix4x3d(Matrix4x3d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M30 = other._M30;
			_M31 = other._M31;
			_M32 = other._M32;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x3d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix4x3d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix4x3d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix4x3d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix4x3d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix4x3d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		/// <summary>
		/// Matrix4x3d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix4x3d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		/// <summary>
		/// Matrix4x3d component: column 3, row 3.
		/// </summary>
		internal double _M22;

		/// <summary>
		/// Matrix4x3d component: column 4, row 1.
		/// </summary>
		internal double _M30;

		/// <summary>
		/// Matrix4x3d component: column 4, row 2.
		/// </summary>
		internal double _M31;

		/// <summary>
		/// Matrix4x3d component: column 4, row 3.
		/// </summary>
		internal double _M32;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex3d Column0
		{
			get { return new Vertex3d(_M00, _M01, _M02); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex3d Column1
		{
			get { return new Vertex3d(_M10, _M11, _M12); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex3d Column2
		{
			get { return new Vertex3d(_M20, _M21, _M22); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex3d Column3
		{
			get { return new Vertex3d(_M30, _M31, _M32); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4d Row0
		{
			get { return new Vertex4d(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4d Row1
		{
			get { return new Vertex4d(_M01, _M11, _M21, _M31); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex4d Row2
		{
			get { return new Vertex4d(_M02, _M12, _M22, _M32); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 3 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							case 2: return _M32;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							case 2: _M32 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x3d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x3d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x3d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x3d operator*(Matrix4x3d m, double v)
		{
			Matrix4x3d r = new Matrix4x3d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;
			r._M32 = m._M32 * v;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x3d m1, Matrix4x3d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x3d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x3d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x3d m1, Matrix4x3d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix4x3d a)
		{
			double[] m = new double[12];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M10;
			m[4] = a._M11;
			m[5] = a._M12;
			m[6] = a._M20;
			m[7] = a._M21;
			m[8] = a._M22;
			m[9] = a._M30;
			m[10] = a._M31;
			m[11] = a._M32;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x3f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x3f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix4x3f(Matrix4x3d a)
		{
			return new Matrix4x3f(
				(float)a._M00, (float)a._M01, (float)a._M02, 
				(float)a._M10, (float)a._M11, (float)a._M12, 
				(float)a._M20, (float)a._M21, (float)a._M22, 
				(float)a._M30, (float)a._M31, (float)a._M32
			);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x3d.
		/// </summary>
		public Matrix3x4d Transposed
		{
			get
			{
				Matrix3x4d tranposed = new Matrix3x4d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;
				tranposed._M23 = _M32;

				return tranposed;
			}
		}


		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x3d Zero;

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x3d is equal to another Matrix4x3d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x3d"/> to compare with this Matrix4x3d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x3d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);
			if (Math.Abs(_M32 - other._M32) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x3d is equal to another Matrix4x3d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x3d"/> to compare with this Matrix4x3d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x3d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M30 == other._M30 && _M31 == other._M31 && _M32 == other._M32;
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
			if (obj.GetType() != typeof(Matrix4x3d))
				return (false);
			
			return (Equals((Matrix4x3d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();
				result = (result * 397) ^ _M32.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x3d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x3d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}||{_M10}, {_M11}, {_M12}||{_M20}, {_M21}, {_M22}||{_M30}, {_M31}, {_M32}||";
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x4d : IEquatable<Matrix4x4d>
	{
		#region Constructors

		/// <summary>
		/// Construct a Matrix4x4d specifying the matrix components.
		/// </summary>
		/// <param name="c00">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 0.
		/// </param>
		/// <param name="c01">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 1.
		/// </param>
		/// <param name="c02">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 2.
		/// </param>
		/// <param name="c03">
		/// A <see cref="double" /> that specifies the matrix component at column 0 and row 3.
		/// </param>
		/// <param name="c10">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 0.
		/// </param>
		/// <param name="c11">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 1.
		/// </param>
		/// <param name="c12">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 2.
		/// </param>
		/// <param name="c13">
		/// A <see cref="double" /> that specifies the matrix component at column 1 and row 3.
		/// </param>
		/// <param name="c20">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 0.
		/// </param>
		/// <param name="c21">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 1.
		/// </param>
		/// <param name="c22">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 2.
		/// </param>
		/// <param name="c23">
		/// A <see cref="double" /> that specifies the matrix component at column 2 and row 3.
		/// </param>
		/// <param name="c30">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 0.
		/// </param>
		/// <param name="c31">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 1.
		/// </param>
		/// <param name="c32">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 2.
		/// </param>
		/// <param name="c33">
		/// A <see cref="double" /> that specifies the matrix component at column 3 and row 3.
		/// </param>
		public Matrix4x4d(double c00, double c01, double c02, double c03, double c10, double c11, double c12, double c13, double c20, double c21, double c22, double c23, double c30, double c31, double c32, double c33)
		{
			_M00 = c00;
			_M01 = c01;
			_M02 = c02;
			_M03 = c03;
			_M10 = c10;
			_M11 = c11;
			_M12 = c12;
			_M13 = c13;
			_M20 = c20;
			_M21 = c21;
			_M22 = c22;
			_M23 = c23;
			_M30 = c30;
			_M31 = c31;
			_M32 = c32;
			_M33 = c33;
		}

		/// <summary>
		/// Construct a Matrix4x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		public Matrix4x4d(double[] c) :
			this(c, 0)
		{
		
		}

		/// <summary>
		/// Construct a Matrix4x4d specifying the matrix components.
		/// </summary>
		/// <param name="c">
		/// An array holding the matrix components.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint" /> that specifies the index of the first matrix component.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="c"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="c"/> is does not contains enought elements.
		/// </exception>
		public Matrix4x4d(double[] c, uint offset)
		{
			if (c == null)
				throw new ArgumentNullException(nameof(c));
			if (c.Length - offset < 16)
				throw new ArgumentException("length must be at least 16", nameof(c));

			_M00 = c[offset + 0];
			_M01 = c[offset + 1];
			_M02 = c[offset + 2];
			_M03 = c[offset + 3];
			_M10 = c[offset + 4];
			_M11 = c[offset + 5];
			_M12 = c[offset + 6];
			_M13 = c[offset + 7];
			_M20 = c[offset + 8];
			_M21 = c[offset + 9];
			_M22 = c[offset + 10];
			_M23 = c[offset + 11];
			_M30 = c[offset + 12];
			_M31 = c[offset + 13];
			_M32 = c[offset + 14];
			_M33 = c[offset + 15];
		}

		/// <summary>
		/// Construct a Matrix4x4d specifying another matrix.
		/// </summary>
		/// <param name="other">
		/// The other Matrix4x4d to be copied into this instance.
		/// </param>
		public Matrix4x4d(Matrix4x4d other)
		{
			_M00 = other._M00;
			_M01 = other._M01;
			_M02 = other._M02;
			_M03 = other._M03;
			_M10 = other._M10;
			_M11 = other._M11;
			_M12 = other._M12;
			_M13 = other._M13;
			_M20 = other._M20;
			_M21 = other._M21;
			_M22 = other._M22;
			_M23 = other._M23;
			_M30 = other._M30;
			_M31 = other._M31;
			_M32 = other._M32;
			_M33 = other._M33;
		}


		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x4d component: column 1, row 1.
		/// </summary>
		internal double _M00;

		/// <summary>
		/// Matrix4x4d component: column 1, row 2.
		/// </summary>
		internal double _M01;

		/// <summary>
		/// Matrix4x4d component: column 1, row 3.
		/// </summary>
		internal double _M02;

		/// <summary>
		/// Matrix4x4d component: column 1, row 4.
		/// </summary>
		internal double _M03;

		/// <summary>
		/// Matrix4x4d component: column 2, row 1.
		/// </summary>
		internal double _M10;

		/// <summary>
		/// Matrix4x4d component: column 2, row 2.
		/// </summary>
		internal double _M11;

		/// <summary>
		/// Matrix4x4d component: column 2, row 3.
		/// </summary>
		internal double _M12;

		/// <summary>
		/// Matrix4x4d component: column 2, row 4.
		/// </summary>
		internal double _M13;

		/// <summary>
		/// Matrix4x4d component: column 3, row 1.
		/// </summary>
		internal double _M20;

		/// <summary>
		/// Matrix4x4d component: column 3, row 2.
		/// </summary>
		internal double _M21;

		/// <summary>
		/// Matrix4x4d component: column 3, row 3.
		/// </summary>
		internal double _M22;

		/// <summary>
		/// Matrix4x4d component: column 3, row 4.
		/// </summary>
		internal double _M23;

		/// <summary>
		/// Matrix4x4d component: column 4, row 1.
		/// </summary>
		internal double _M30;

		/// <summary>
		/// Matrix4x4d component: column 4, row 2.
		/// </summary>
		internal double _M31;

		/// <summary>
		/// Matrix4x4d component: column 4, row 3.
		/// </summary>
		internal double _M32;

		/// <summary>
		/// Matrix4x4d component: column 4, row 4.
		/// </summary>
		internal double _M33;

		#endregion

		#region Columns & Rows

		/// <summary>
		/// Get the column 0.
		/// </summary>
		public Vertex4d Column0
		{
			get { return new Vertex4d(_M00, _M01, _M02, _M03); }
		}
		/// <summary>
		/// Get the column 1.
		/// </summary>
		public Vertex4d Column1
		{
			get { return new Vertex4d(_M10, _M11, _M12, _M13); }
		}
		/// <summary>
		/// Get the column 2.
		/// </summary>
		public Vertex4d Column2
		{
			get { return new Vertex4d(_M20, _M21, _M22, _M23); }
		}
		/// <summary>
		/// Get the column 3.
		/// </summary>
		public Vertex4d Column3
		{
			get { return new Vertex4d(_M30, _M31, _M32, _M33); }
		}

		/// <summary>
		/// Get the row 0.
		/// </summary>
		public Vertex4d Row0
		{
			get { return new Vertex4d(_M00, _M10, _M20, _M30); }
		}
		/// <summary>
		/// Get the row 1.
		/// </summary>
		public Vertex4d Row1
		{
			get { return new Vertex4d(_M01, _M11, _M21, _M31); }
		}
		/// <summary>
		/// Get the row 2.
		/// </summary>
		public Vertex4d Row2
		{
			get { return new Vertex4d(_M02, _M12, _M22, _M32); }
		}
		/// <summary>
		/// Get the row 3.
		/// </summary>
		public Vertex4d Row3
		{
			get { return new Vertex4d(_M03, _M13, _M23, _M33); }
		}

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
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception throw if <paramref name="c"/> is greater than 4 column count, or if <paramref name="r"/>
		/// is greater than 4 row count.
		/// </exception>
		public double this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: return _M00;
							case 1: return _M01;
							case 2: return _M02;
							case 3: return _M03;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 1:
						switch (r) {
							case 0: return _M10;
							case 1: return _M11;
							case 2: return _M12;
							case 3: return _M13;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 2:
						switch (r) {
							case 0: return _M20;
							case 1: return _M21;
							case 2: return _M22;
							case 3: return _M23;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					case 3:
						switch (r) {
							case 0: return _M30;
							case 1: return _M31;
							case 2: return _M32;
							case 3: return _M33;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
			set
			{
				switch (c) {
					case 0:
						switch (r) {
							case 0: _M00 = value; break;
							case 1: _M01 = value; break;
							case 2: _M02 = value; break;
							case 3: _M03 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 1:
						switch (r) {
							case 0: _M10 = value; break;
							case 1: _M11 = value; break;
							case 2: _M12 = value; break;
							case 3: _M13 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 2:
						switch (r) {
							case 0: _M20 = value; break;
							case 1: _M21 = value; break;
							case 2: _M22 = value; break;
							case 3: _M23 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					case 3:
						switch (r) {
							case 0: _M30 = value; break;
							case 1: _M31 = value; break;
							case 2: _M32 = value; break;
							case 3: _M33 = value; break;
							default:
								throw new ArgumentOutOfRangeException(nameof(r));
						}
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(c));
				}
			}
		}

		/// <summary>
		/// Multiply a Matrix4x4d with a double.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="double"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> resulting from the product of the matrix <paramref name="m"/> and the scalar <paramref name="v"/>.
		/// </returns>
		public static Matrix4x4d operator*(Matrix4x4d m, double v)
		{
			Matrix4x4d r = new Matrix4x4d();

			r._M00 = m._M00 * v;
			r._M01 = m._M01 * v;
			r._M02 = m._M02 * v;
			r._M03 = m._M03 * v;
			r._M10 = m._M10 * v;
			r._M11 = m._M11 * v;
			r._M12 = m._M12 * v;
			r._M13 = m._M13 * v;
			r._M20 = m._M20 * v;
			r._M21 = m._M21 * v;
			r._M22 = m._M22 * v;
			r._M23 = m._M23 * v;
			r._M30 = m._M30 * v;
			r._M31 = m._M31 * v;
			r._M32 = m._M32 * v;
			r._M33 = m._M33 * v;

			return r;
		}

		/// <summary>
		/// Multiply a Matrix4x4d with a Vertex4d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> resulting from the product of the matrix <paramref name="m"/> and the vertex <paramref name="v"/>.
		/// </returns>
		public static Vertex4d operator*(Matrix4x4d m, Vertex4d v)
		{
			Vertex4d r = new Vertex4d();

			r.x = m._M00 * v.x + m._M10 * v.y + m._M20 * v.z + m._M30 * v.w;
			r.y = m._M01 * v.x + m._M11 * v.y + m._M21 * v.z + m._M31 * v.w;
			r.z = m._M02 * v.x + m._M12 * v.y + m._M22 * v.z + m._M32 * v.w;
			r.w = m._M03 * v.x + m._M13 * v.y + m._M23 * v.z + m._M33 * v.w;

			return r;
		}

		/// <summary>
		/// Multiply two Matrix4x4d.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4d"/> that specify the left multiplication operand.
		/// </param>
		/// <param name="n">
		/// A <see cref="Matrix4x4d"/> that specify the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> resulting from the product of the matrix <paramref name="m"/> and the matrix <paramref name="n"/>.
		/// </returns>
		public static Matrix4x4d operator*(Matrix4x4d m, Matrix4x4d n)
		{
			Matrix4x4d r = new Matrix4x4d();

			r._M00 = m._M00 * n._M00 + m._M10 * n._M01 + m._M20 * n._M02 + m._M30 * n._M03;
			r._M01 = m._M01 * n._M00 + m._M11 * n._M01 + m._M21 * n._M02 + m._M31 * n._M03;
			r._M02 = m._M02 * n._M00 + m._M12 * n._M01 + m._M22 * n._M02 + m._M32 * n._M03;
			r._M03 = m._M03 * n._M00 + m._M13 * n._M01 + m._M23 * n._M02 + m._M33 * n._M03;
			r._M10 = m._M00 * n._M10 + m._M10 * n._M11 + m._M20 * n._M12 + m._M30 * n._M13;
			r._M11 = m._M01 * n._M10 + m._M11 * n._M11 + m._M21 * n._M12 + m._M31 * n._M13;
			r._M12 = m._M02 * n._M10 + m._M12 * n._M11 + m._M22 * n._M12 + m._M32 * n._M13;
			r._M13 = m._M03 * n._M10 + m._M13 * n._M11 + m._M23 * n._M12 + m._M33 * n._M13;
			r._M20 = m._M00 * n._M20 + m._M10 * n._M21 + m._M20 * n._M22 + m._M30 * n._M23;
			r._M21 = m._M01 * n._M20 + m._M11 * n._M21 + m._M21 * n._M22 + m._M31 * n._M23;
			r._M22 = m._M02 * n._M20 + m._M12 * n._M21 + m._M22 * n._M22 + m._M32 * n._M23;
			r._M23 = m._M03 * n._M20 + m._M13 * n._M21 + m._M23 * n._M22 + m._M33 * n._M23;
			r._M30 = m._M00 * n._M30 + m._M10 * n._M31 + m._M20 * n._M32 + m._M30 * n._M33;
			r._M31 = m._M01 * n._M30 + m._M11 * n._M31 + m._M21 * n._M32 + m._M31 * n._M33;
			r._M32 = m._M02 * n._M30 + m._M12 * n._M31 + m._M22 * n._M32 + m._M32 * n._M33;
			r._M33 = m._M03 * n._M30 + m._M13 * n._M31 + m._M23 * n._M32 + m._M33 * n._M33;

			return r;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator ==(Matrix4x4d m1, Matrix4x4d m2)
		{
			return m1.Equals(m2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4d"/> that specify the left operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4d"/> that specify the left operand.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="m1"/> not equals <paramref name="m2"/>.
		/// </returns>
		public static bool operator !=(Matrix4x4d m1, Matrix4x4d m2)
		{
			return !m1.Equals(m2);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Operator casting to double[] .
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator double[](Matrix4x4d a)
		{
			double[] m = new double[16];

			m[0] = a._M00;
			m[1] = a._M01;
			m[2] = a._M02;
			m[3] = a._M03;
			m[4] = a._M10;
			m[5] = a._M11;
			m[6] = a._M12;
			m[7] = a._M13;
			m[8] = a._M20;
			m[9] = a._M21;
			m[10] = a._M22;
			m[11] = a._M23;
			m[12] = a._M30;
			m[13] = a._M31;
			m[14] = a._M32;
			m[15] = a._M33;

			return m;
		}

		/// <summary>
		/// Operator casting to Matrix4x4f.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Matrix4x4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4f"/> initialized with the matrix components.
		/// </returns>
		public static explicit operator Matrix4x4f(Matrix4x4d a)
		{
			return new Matrix4x4f(
				(float)a._M00, (float)a._M01, (float)a._M02, (float)a._M03, 
				(float)a._M10, (float)a._M11, (float)a._M12, (float)a._M13, 
				(float)a._M20, (float)a._M21, (float)a._M22, (float)a._M23, 
				(float)a._M30, (float)a._M31, (float)a._M32, (float)a._M33
			);
		}

		#endregion

		#region Projections

		/// <summary>
		/// Construct a Matrix4x4d modelling an orthographic projection.
		/// </summary>
		/// <param name="left">
		/// A <see cref="double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="double"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="double"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="double"/> indicating the distance of the far plane, in world units
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing an orthographic projection matrix.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the parameter have an invalid set of values.
		/// </exception>
		public static Matrix4x4d Ortho(double left, double right, double bottom, double top, double near, double far)
		{
			if (Math.Abs(right - left) < double.Epsilon)
				throw new ArgumentException("left/right planes are coincident");
			if (Math.Abs(top - bottom) < double.Epsilon)
				throw new ArgumentException("top/bottom planes are coincident");
			if (Math.Abs(far - near) < double.Epsilon)
				throw new ArgumentException("far/near planes are coincident");

			Matrix4x4d r = new Matrix4x4d();

			r._M00 = 2.0 / (right - left);
			r._M11 = 2.0 / (top - bottom);
			r._M22 = -2.0 / (far - near);
			r._M30 = -(right + left) / (right - left);
			r._M31 = -(top + bottom) / (top - bottom);
			r._M32 = -(far + near) / (far - near);
			r._M33 = 1.0;

			return r;
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a 2D orthographic projection.
		/// </summary>
		/// <param name="left">
		/// A <see cref="double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="double"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a 2D orthographic projection matrix.
		/// </returns>
		public static Matrix4x4d Ortho2D(double left, double right, double bottom, double top)
		{
			return Ortho(left, right, bottom, top, -1.0, +1.0);
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a frustrum perspective projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="double"/> that specifies the frustum left plane distance.
		/// </param>
		/// <param name="right">
		/// A <see cref="double"/> that specifies the frustum right plane distance.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="double"/> that specifies the frustum bottom plane distance.
		/// </param>
		/// <param name="top">
		/// A <see cref="double"/> that specifies the frustum top plane distance.
		/// </param>
		/// <param name="near">
		/// A <see cref="double"/> that specifies the frustum near plane distance.
		/// </param>
		/// <param name="far">
		/// A <see cref="double"/> that specifies the frustum far plane distance.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the parameter have an invalid set of values.
		/// </exception>
		public static Matrix4x4d Frustrum(double left, double right, double bottom, double top, double near, double far)
		{
			if (Math.Abs(right - left) < double.Epsilon)
				throw new ArgumentException("left/right planes are coincident");
			if (Math.Abs(top - bottom) < double.Epsilon)
				throw new ArgumentException("top/bottom planes are coincident");
			if (Math.Abs(far - near) < double.Epsilon)
				throw new ArgumentException("far/near planes are coincident");

			Matrix4x4d r = new Matrix4x4d();

			r._M00 = 2.0 * near / (right - left);
			r._M11 = 2.0 * near / (top - bottom);
			r._M20 = (right + left) / (right - left);
			r._M21 = (top + bottom) / (top - bottom);
			r._M22 = (-far - near) / (far - near);
			r._M23 = -1.0;
			r._M32 = -2.0 * far * near / (far - near);

			return r;
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a frustrum perspective projection matrix, using FOV angle.
		/// </summary>
		/// <param name="fovy">
		/// A <see cref="double"/> that specifies the vertical Field Of View angle, in degrees.
		/// </param>
		/// <param name="aspectRatio">
		/// A <see cref="double"/> that specifies the view aspect ratio (i.e. the width / height ratio).
		/// </param>
		/// <param name="near">
		/// A <see cref="double"/> that specifies the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="double"/> that specifies the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public static Matrix4x4d Perspective(double fovy, double aspectRatio, double near, double far)
		{
			if (fovy <= 0.0 || fovy >= 180.0)
				throw new ArgumentOutOfRangeException(nameof(fovy), "not in range (0, 180)");
			if (Math.Abs(near) < double.Epsilon)
				throw new ArgumentOutOfRangeException(nameof(near), "zero not allowed");
			if (Math.Abs(far) < Math.Abs(near))
				throw new ArgumentOutOfRangeException(nameof(far), "less than near");

			double ymax = near * (double)Math.Tan(Angle.ToRadians(fovy / 2.0));
			double xmax = ymax * aspectRatio;

			return Frustrum(-xmax, +xmax, -ymax, +ymax, near, far);
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling an asymmetric frustrum perspective projection matrix, using FOV angles.
		/// </summary>
		/// <param name="leftFov">
		/// A <see cref="double"/> that specifies the left plane FOV angle, in degrees.
		/// </param>
		/// <param name="rightFov">
		/// A <see cref="double"/> that specifies the right plane FOV angle, in degrees.
		/// </param>
		/// <param name="bottomFov">
		/// A <see cref="double"/> that specifies the bottom plane FOV angle, in degrees.
		/// </param>
		/// <param name="topFov">
		/// A <see cref="double"/> that specifies the top plane FOV angle, in degrees.
		/// </param>
		/// <param name="near">
		/// A <see cref="double"/> that specifies the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="double"/> that specifies the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public static Matrix4x4d Perspective(double leftFov, double rightFov, double bottomFov, double topFov, double near, double far)
		{
			return Frustrum(
				near * (double)Math.Tan(Angle.ToRadians(leftFov)),
				near * (double)Math.Tan(Angle.ToRadians(rightFov)),
				near * (double)Math.Tan(Angle.ToRadians(bottomFov)),
				near * (double)Math.Tan(Angle.ToRadians(topFov)),
				near, far
			);
		}

		#endregion

		#region View Model

		/// <summary>
		/// Get the translation of this Matrix4x4d.
		/// </summary>
		public Vertex3d Position
		{
			get { return ((Vertex3d)new Vertex4d(_M30, _M31, _M32, _M33)); }
		}

		/// <summary>
		/// Get the forward vector of this Matrix4x4d.
		/// </summary>
		public Vertex3d ForwardVector
		{
			get { return new Vertex3d(-_M20, -_M21, -_M22).Normalized; }
		}

		/// <summary>
		/// Get the right vector of this Matrix4x4d.
		/// </summary>
		public Vertex3d RightVector
		{
			get { return new Vertex3d(_M00, _M01, _M02).Normalized; }
		}

		/// <summary>
		/// Get the up vector of this Matrix4x4d.
		/// </summary>
		public Vertex3d UpVector
		{
			get { return new Vertex3d(_M10, _M11, _M12).Normalized; }
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a view transformation.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3d"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3d"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3d"/> that specify the up vector of the view camera abstraction.
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public static Matrix4x4d LookAt(Vertex3d eyePosition, Vertex3d targetPosition, Vertex3d upVector)
		{
			return LookAtDirection(eyePosition, targetPosition - eyePosition, upVector);
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a view transformation.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3d"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="forwardVector">
		/// A <see cref="Vertex3d"/> that specify the direction of the view. It will be normalized.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3d"/> that specify the up vector of the view camera abstraction. It will be normalized
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="forwardVector"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public static Matrix4x4d LookAtDirection(Vertex3d eyePosition, Vertex3d forwardVector, Vertex3d upVector)
		{
			Vertex3d rightVector;

			forwardVector.Normalize();
			
			rightVector = forwardVector ^ upVector.Normalized;
			if (rightVector.Module() <= 0.0)
				rightVector = Vertex3d.UnitX;
			else
				rightVector.Normalize();

			upVector = (rightVector ^ forwardVector).Normalized;

			// Compute view matrix
			Matrix4x4d r = new Matrix4x4d();

			// Row 0: right vector
			r._M00 = rightVector.x;
			r._M10 = rightVector.y;
			r._M20 = rightVector.z;
			// Row 1: up vector
			r._M01 = upVector.x;
			r._M11 = upVector.y;
			r._M21 = upVector.z;
			// Row 2: opposite of forward vector
			r._M02 = -forwardVector.x;
			r._M12 = -forwardVector.y;
			r._M22 = -forwardVector.z;

			r._M33 = 1.0;

			// Eye position
			r.Translate(-eyePosition.x, -eyePosition.y, -eyePosition.z);

			return r;
		}

		#endregion

		#region Translation

		/// <summary>
		/// Construct a Matrix4x4d modelling a translation.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the translation on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a translation matrix.
		/// </returns>
		public static Matrix4x4d Translated(double x, double y, double z)
		{
			Matrix4x4d r = new Matrix4x4d();

			r._M00 = r._M11 = r._M22 = r._M33 = 1.0;
			r._M30 = x;
			r._M31 = y;
			r._M32 = z;

			return r;
		}

		/// <summary>
		/// Translates this Matrix4x4d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the translation on Z axis.
		/// </param>
		public void Translate(double x, double y, double z)
		{
			this = this * Translated(x, y, z);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Construct a Matrix4x4d modelling a rotation around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a matrix rotating on X axis.
		/// </returns>
		public static Matrix4x4d RotatedX(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix4x4d r = new Matrix4x4d();

			r._M11 = +cosa;
			r._M21 = -sina;
			r._M12 = +sina;
			r._M22 = +cosa;
			r._M00 = r._M33 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4d around the X axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateX(double angle)
		{
			this = this * RotatedX(angle);
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a rotation around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a matrix rotating on Y axis.
		/// </returns>
		public static Matrix4x4d RotatedY(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix4x4d r = new Matrix4x4d();

			r._M00 = +cosa;
			r._M20 = +sina;
			r._M02 = -sina;
			r._M22 = +cosa;
			r._M11 = r._M33 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4d around the Y axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateY(double angle)
		{
			this = this * RotatedY(angle);
		}

		/// <summary>
		/// Construct a Matrix4x4d modelling a rotation around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a matrix rotating on Z axis.
		/// </returns>
		public static Matrix4x4d RotatedZ(double angle)
		{
			double a = Angle.ToRadians(angle);
			double cosa = (double)Math.Cos(a);
			double sina = (double)Math.Sin(a);
			Matrix4x4d r = new Matrix4x4d();
		
			r._M00 = +cosa;
			r._M10 = -sina;
			r._M01 = +sina;
			r._M11 = +cosa;
			r._M22 = r._M33 = 1.0;

			return r;
		}

		/// <summary>
		/// Rotates this Matrix4x4d around the Z axis.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that specifies the rotation angle, in degrees.
		/// </param>
		public void RotateZ(double angle)
		{
			this = this * RotatedZ(angle);
		}

		#endregion

		#region Scaling

		/// <summary>
		/// Compute the scaled of this Matrix4x4d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the scale on Z axis.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4d"/> representing a scaling matrix.
		/// </returns>
		public static Matrix4x4d Scaled(double x, double y, double z)
		{
			Matrix4x4d scaled = new Matrix4x4d();

			scaled._M00 = x;
			scaled._M11 = y;
			scaled._M22 = z;
			scaled._M33 = 1.0;

			return scaled;
		}

		/// <summary>
		/// Scale this Matrix4x4d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specifies the scale on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specifies the scale on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specifies the scale on Z axis.
		/// </param>
		public void Scale(double x, double y, double z)
		{
			this = this * Scaled(x, y, z);
		}

		#endregion

		#region Tranposition

		/// <summary>
		/// Compute the transpose of this Matrix4x4d.
		/// </summary>
		public Matrix4x4d Transposed
		{
			get
			{
				Matrix4x4d tranposed = new Matrix4x4d();

				tranposed._M00 = _M00;
				tranposed._M10 = _M01;
				tranposed._M20 = _M02;
				tranposed._M30 = _M03;
				tranposed._M01 = _M10;
				tranposed._M11 = _M11;
				tranposed._M21 = _M12;
				tranposed._M31 = _M13;
				tranposed._M02 = _M20;
				tranposed._M12 = _M21;
				tranposed._M22 = _M22;
				tranposed._M32 = _M23;
				tranposed._M03 = _M30;
				tranposed._M13 = _M31;
				tranposed._M23 = _M32;
				tranposed._M33 = _M33;

				return tranposed;
			}
		}

		/// <summary>
		/// Transpose this Matrix4x4d.
		/// </summary>
		public void Transpose()
		{
			_M01 = Interlocked.Exchange(ref _M10, _M01);
			_M02 = Interlocked.Exchange(ref _M20, _M02);
			_M12 = Interlocked.Exchange(ref _M21, _M12);
			_M03 = Interlocked.Exchange(ref _M30, _M03);
			_M13 = Interlocked.Exchange(ref _M31, _M13);
			_M23 = Interlocked.Exchange(ref _M32, _M23);
		}

		#endregion

		#region Inversion

		/// <summary>
		/// Compute the determinant of this Matrix4x4d.
		/// </summary>
		public double Determinant
		{
			get
			{
				Matrix3x3d c0 = new Matrix3x3d(this, 0, 0);
				Matrix3x3d c1 = new Matrix3x3d(this, 0, 1);
				Matrix3x3d c2 = new Matrix3x3d(this, 0, 2);
				Matrix3x3d c3 = new Matrix3x3d(this, 0, 3);

				return +c0.Determinant * _M00 + -c1.Determinant * _M01 + +c2.Determinant * _M02 + -c3.Determinant * _M03;
			}
		}

		/// <summary>
		/// Compute the inverse of this Matrix4x4d.
		/// </summary>
		public Matrix4x4d Inverse
		{
			get
			{
				double inv00 =  _M11 * _M22 * _M33 - _M11 * _M23 * _M32 - _M21 * _M12 * _M33 + _M21 * _M13 * _M32 + _M31 * _M12 * _M23 - _M31 * _M13 * _M22;
				double inv10 = -_M10 * _M22 * _M33 + _M10 * _M23 * _M32 + _M20 * _M12 * _M33 - _M20 * _M13 * _M32 - _M30 * _M12 * _M23 + _M30 * _M13 * _M22;
				double inv20 =  _M10 * _M21 * _M33 - _M10 * _M23 * _M31 - _M20 * _M11 * _M33 + _M20 * _M13 * _M31 + _M30 * _M11 * _M23 - _M30 * _M13 * _M21;
				double inv30 = -_M10 * _M21 * _M32 + _M10 * _M22 * _M31 + _M20 * _M11 * _M32 - _M20 * _M12 * _M31 - _M30 * _M11 * _M22 + _M30 * _M12 * _M21;
				double inv01 = -_M01 * _M22 * _M33 + _M01 * _M23 * _M32 + _M21 * _M02 * _M33 - _M21 * _M03 * _M32 - _M31 * _M02 * _M23 + _M31 * _M03 * _M22;
				double inv11 =  _M00 * _M22 * _M33 - _M00 * _M23 * _M32 - _M20 * _M02 * _M33 + _M20 * _M03 * _M32 + _M30 * _M02 * _M23 - _M30 * _M03 * _M22;
				double inv21 = -_M00 * _M21 * _M33 + _M00 * _M23 * _M31 + _M20 * _M01 * _M33 - _M20 * _M03 * _M31 - _M30 * _M01 * _M23 + _M30 * _M03 * _M21;
				double inv31 =  _M00 * _M21 * _M32 - _M00 * _M22 * _M31 - _M20 * _M01 * _M32 + _M20 * _M02 * _M31 + _M30 * _M01 * _M22 - _M30 * _M02 * _M21;
				double inv02 =  _M01 * _M12 * _M33 - _M01 * _M13 * _M32 - _M11 * _M02 * _M33 + _M11 * _M03 * _M32 + _M31 * _M02 * _M13 - _M31 * _M03 * _M12;
				double inv12 = -_M00 * _M12 * _M33 + _M00 * _M13 * _M32 + _M10 * _M02 * _M33 - _M10 * _M03 * _M32 - _M30 * _M02 * _M13 + _M30 * _M03 * _M12;
				double inv22 =  _M00 * _M11 * _M33 - _M00 * _M13 * _M31 - _M10 * _M01 * _M33 + _M10 * _M03 * _M31 + _M30 * _M01 * _M13 - _M30 * _M03 * _M11;
				double inv32 = -_M00 * _M11 * _M32 + _M00 * _M12 * _M31 + _M10 * _M01 * _M32 - _M10 * _M02 * _M31 - _M30 * _M01 * _M12 + _M30 * _M02 * _M11;
				double inv03 = -_M01 * _M12 * _M23 + _M01 * _M13 * _M22 + _M11 * _M02 * _M23 - _M11 * _M03 * _M22 - _M21 * _M02 * _M13 + _M21 * _M03 * _M12;
				double inv13 =  _M00 * _M12 * _M23 - _M00 * _M13 * _M22 - _M10 * _M02 * _M23 + _M10 * _M03 * _M22 + _M20 * _M02 * _M13 - _M20 * _M03 * _M12;
				double inv23 = -_M00 * _M11 * _M23 + _M00 * _M13 * _M21 + _M10 * _M01 * _M23 - _M10 * _M03 * _M21 - _M20 * _M01 * _M13 + _M20 * _M03 * _M11;
				double inv33 =  _M00 * _M11 * _M22 - _M00 * _M12 * _M21 - _M10 * _M01 * _M22 + _M10 * _M02 * _M21 + _M20 * _M01 * _M12 - _M20 * _M02 * _M11;

				double det = _M00 * inv00 + _M01 * inv10 + _M02 * inv20 + _M03 * inv30;

				if (Math.Abs(det) < 1e-6f)
					throw new InvalidOperationException("not invertible");

				det = 1.0 / det;

				return new Matrix4x4d(
					det * inv00, det * inv01, det * inv02, det * inv03, 
					det * inv10, det * inv11, det * inv12, det * inv13, 
					det * inv20, det * inv21, det * inv22, det * inv23, 
					det * inv30, det * inv31, det * inv32, det * inv33
				);
			}
		}

		/// <summary>
		/// Invert this Matrix4x4d.
		/// </summary>
		public void Invert()
		{
			this = Inverse;
		}

		#endregion

		#region Notable Matrices

		/// <summary>
		/// Zero matrix.
		/// </summary>
		public static readonly Matrix4x4d Zero;

		/// <summary>
		/// Identity matrix.
		/// </summary>
		public static readonly Matrix4x4d Identity = new Matrix4x4d(
			1.0, 0.0, 0.0, 0.0, 
			0.0, 1.0, 0.0, 0.0, 
			0.0, 0.0, 1.0, 0.0, 
			0.0, 0.0, 0.0, 1.0
		);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Matrix4x4d is equal to another Matrix4x4d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x4d"/> to compare with this Matrix4x4d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x4d other, double precision)
		{
			if (Math.Abs(_M00 - other._M00) > precision)
				return (false);
			if (Math.Abs(_M01 - other._M01) > precision)
				return (false);
			if (Math.Abs(_M02 - other._M02) > precision)
				return (false);
			if (Math.Abs(_M03 - other._M03) > precision)
				return (false);
			if (Math.Abs(_M10 - other._M10) > precision)
				return (false);
			if (Math.Abs(_M11 - other._M11) > precision)
				return (false);
			if (Math.Abs(_M12 - other._M12) > precision)
				return (false);
			if (Math.Abs(_M13 - other._M13) > precision)
				return (false);
			if (Math.Abs(_M20 - other._M20) > precision)
				return (false);
			if (Math.Abs(_M21 - other._M21) > precision)
				return (false);
			if (Math.Abs(_M22 - other._M22) > precision)
				return (false);
			if (Math.Abs(_M23 - other._M23) > precision)
				return (false);
			if (Math.Abs(_M30 - other._M30) > precision)
				return (false);
			if (Math.Abs(_M31 - other._M31) > precision)
				return (false);
			if (Math.Abs(_M32 - other._M32) > precision)
				return (false);
			if (Math.Abs(_M33 - other._M33) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Matrix4x4d is equal to another Matrix4x4d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Matrix4x4d"/> to compare with this Matrix4x4d.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix4x4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Matrix4x4d other)
		{
			return _M00 == other._M00 && _M01 == other._M01 && _M02 == other._M02 && _M03 == other._M03 && _M10 == other._M10 && _M11 == other._M11 && _M12 == other._M12 && _M13 == other._M13 && _M20 == other._M20 && _M21 == other._M21 && _M22 == other._M22 && _M23 == other._M23 && _M30 == other._M30 && _M31 == other._M31 && _M32 == other._M32 && _M33 == other._M33;
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
			if (obj.GetType() != typeof(Matrix4x4d))
				return (false);
			
			return (Equals((Matrix4x4d)obj));
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
				int result = 0;

				result = (result * 397) ^ _M00.GetHashCode();
				result = (result * 397) ^ _M01.GetHashCode();
				result = (result * 397) ^ _M02.GetHashCode();
				result = (result * 397) ^ _M03.GetHashCode();
				result = (result * 397) ^ _M10.GetHashCode();
				result = (result * 397) ^ _M11.GetHashCode();
				result = (result * 397) ^ _M12.GetHashCode();
				result = (result * 397) ^ _M13.GetHashCode();
				result = (result * 397) ^ _M20.GetHashCode();
				result = (result * 397) ^ _M21.GetHashCode();
				result = (result * 397) ^ _M22.GetHashCode();
				result = (result * 397) ^ _M23.GetHashCode();
				result = (result * 397) ^ _M30.GetHashCode();
				result = (result * 397) ^ _M31.GetHashCode();
				result = (result * 397) ^ _M32.GetHashCode();
				result = (result * 397) ^ _M33.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Matrix4x4d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="string"/> that represents this Matrix4x4d.
		/// </returns>
		public override string ToString()
		{
			return $"||{_M00}, {_M01}, {_M02}, {_M03}||{_M10}, {_M11}, {_M12}, {_M13}||{_M20}, {_M21}, {_M22}, {_M23}||{_M30}, {_M31}, {_M32}, {_M33}||";
		}

		#endregion
	}

}
