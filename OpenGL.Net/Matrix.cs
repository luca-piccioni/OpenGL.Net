
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

using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace OpenGL
{
	/// <summary>
	/// Matrix composed by 2 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x2f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x2f specifying the matrix columns.
		/// </summary>
		public Matrix2x2f(Vertex2f c0, Vertex2f c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x2f column n. 1.
		/// </summary>
		public Vertex2f Column0;

		/// <summary>
		/// Matrix2x2f column n. 2.
		/// </summary>
		public Vertex2f Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x2f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(2, 2, Column0.x, Column0.y, Column1.x, Column1.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x3f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x3f specifying the matrix columns.
		/// </summary>
		public Matrix2x3f(Vertex3f c0, Vertex3f c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x3f column n. 1.
		/// </summary>
		public Vertex3f Column0;

		/// <summary>
		/// Matrix2x3f column n. 2.
		/// </summary>
		public Vertex3f Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x3f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(2, 3, Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x4f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x4f specifying the matrix columns.
		/// </summary>
		public Matrix2x4f(Vertex4f c0, Vertex4f c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x4f column n. 1.
		/// </summary>
		public Vertex4f Column0;

		/// <summary>
		/// Matrix2x4f column n. 2.
		/// </summary>
		public Vertex4f Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x4f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(2, 4, Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x2f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x2f specifying the matrix columns.
		/// </summary>
		public Matrix3x2f(Vertex2f c0, Vertex2f c1, Vertex2f c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x2f column n. 1.
		/// </summary>
		public Vertex2f Column0;

		/// <summary>
		/// Matrix3x2f column n. 2.
		/// </summary>
		public Vertex2f Column1;

		/// <summary>
		/// Matrix3x2f column n. 3.
		/// </summary>
		public Vertex2f Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x2f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(3, 2, Column0.x, Column0.y, Column1.x, Column1.y, Column2.x, Column2.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x3f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x3f specifying the matrix columns.
		/// </summary>
		public Matrix3x3f(Vertex3f c0, Vertex3f c1, Vertex3f c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x3f column n. 1.
		/// </summary>
		public Vertex3f Column0;

		/// <summary>
		/// Matrix3x3f column n. 2.
		/// </summary>
		public Vertex3f Column1;

		/// <summary>
		/// Matrix3x3f column n. 3.
		/// </summary>
		public Vertex3f Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x3f to Matrix3x3.
		/// </summary>
		public Matrix3x3 ToMatrix()
		{
			return (new Matrix3x3(new[] { Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z, Column2.x, Column2.y, Column2.z }));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x4f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x4f specifying the matrix columns.
		/// </summary>
		public Matrix3x4f(Vertex4f c0, Vertex4f c1, Vertex4f c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x4f column n. 1.
		/// </summary>
		public Vertex4f Column0;

		/// <summary>
		/// Matrix3x4f column n. 2.
		/// </summary>
		public Vertex4f Column1;

		/// <summary>
		/// Matrix3x4f column n. 3.
		/// </summary>
		public Vertex4f Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x4f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(3, 4, Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w, Column2.x, Column2.y, Column2.z, Column2.w));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x2f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x2f specifying the matrix columns.
		/// </summary>
		public Matrix4x2f(Vertex2f c0, Vertex2f c1, Vertex2f c2, Vertex2f c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x2f column n. 1.
		/// </summary>
		public Vertex2f Column0;

		/// <summary>
		/// Matrix4x2f column n. 2.
		/// </summary>
		public Vertex2f Column1;

		/// <summary>
		/// Matrix4x2f column n. 3.
		/// </summary>
		public Vertex2f Column2;

		/// <summary>
		/// Matrix4x2f column n. 4.
		/// </summary>
		public Vertex2f Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x2f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(4, 2, Column0.x, Column0.y, Column1.x, Column1.y, Column2.x, Column2.y, Column3.x, Column3.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x3f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x3f specifying the matrix columns.
		/// </summary>
		public Matrix4x3f(Vertex3f c0, Vertex3f c1, Vertex3f c2, Vertex3f c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x3f column n. 1.
		/// </summary>
		public Vertex3f Column0;

		/// <summary>
		/// Matrix4x3f column n. 2.
		/// </summary>
		public Vertex3f Column1;

		/// <summary>
		/// Matrix4x3f column n. 3.
		/// </summary>
		public Vertex3f Column2;

		/// <summary>
		/// Matrix4x3f column n. 4.
		/// </summary>
		public Vertex3f Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x3f to Matrix.
		/// </summary>
		public Matrix ToMatrix()
		{
			return (new Matrix(4, 3, Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z, Column2.x, Column2.y, Column2.z, Column3.x, Column3.y, Column3.z));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x4f
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x4f specifying the matrix columns.
		/// </summary>
		public Matrix4x4f(Vertex4f c0, Vertex4f c1, Vertex4f c2, Vertex4f c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x4f column n. 1.
		/// </summary>
		public Vertex4f Column0;

		/// <summary>
		/// Matrix4x4f column n. 2.
		/// </summary>
		public Vertex4f Column1;

		/// <summary>
		/// Matrix4x4f column n. 3.
		/// </summary>
		public Vertex4f Column2;

		/// <summary>
		/// Matrix4x4f column n. 4.
		/// </summary>
		public Vertex4f Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x4f to Matrix4x4.
		/// </summary>
		public Matrix4x4 ToMatrix()
		{
			return (new Matrix4x4(new[] { Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w, Column2.x, Column2.y, Column2.z, Column2.w, Column3.x, Column3.y, Column3.z, Column3.w }));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x2d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x2d specifying the matrix columns.
		/// </summary>
		public Matrix2x2d(Vertex2d c0, Vertex2d c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x2d column n. 1.
		/// </summary>
		public Vertex2d Column0;

		/// <summary>
		/// Matrix2x2d column n. 2.
		/// </summary>
		public Vertex2d Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x2d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(2, 2, Column0.x, Column0.y, Column1.x, Column1.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x3d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x3d specifying the matrix columns.
		/// </summary>
		public Matrix2x3d(Vertex3d c0, Vertex3d c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x3d column n. 1.
		/// </summary>
		public Vertex3d Column0;

		/// <summary>
		/// Matrix2x3d column n. 2.
		/// </summary>
		public Vertex3d Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x3d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(2, 3, Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 2 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix2x4d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix2x4d specifying the matrix columns.
		/// </summary>
		public Matrix2x4d(Vertex4d c0, Vertex4d c1)
		{
			Column0 = c0;
			Column1 = c1;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix2x4d column n. 1.
		/// </summary>
		public Vertex4d Column0;

		/// <summary>
		/// Matrix2x4d column n. 2.
		/// </summary>
		public Vertex4d Column1;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix2x4d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(2, 4, Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x2d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x2d specifying the matrix columns.
		/// </summary>
		public Matrix3x2d(Vertex2d c0, Vertex2d c1, Vertex2d c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x2d column n. 1.
		/// </summary>
		public Vertex2d Column0;

		/// <summary>
		/// Matrix3x2d column n. 2.
		/// </summary>
		public Vertex2d Column1;

		/// <summary>
		/// Matrix3x2d column n. 3.
		/// </summary>
		public Vertex2d Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x2d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(3, 2, Column0.x, Column0.y, Column1.x, Column1.y, Column2.x, Column2.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x3d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x3d specifying the matrix columns.
		/// </summary>
		public Matrix3x3d(Vertex3d c0, Vertex3d c1, Vertex3d c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x3d column n. 1.
		/// </summary>
		public Vertex3d Column0;

		/// <summary>
		/// Matrix3x3d column n. 2.
		/// </summary>
		public Vertex3d Column1;

		/// <summary>
		/// Matrix3x3d column n. 3.
		/// </summary>
		public Vertex3d Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x3d to MatrixDouble3x3.
		/// </summary>
		public MatrixDouble3x3 ToMatrix()
		{
			return (new MatrixDouble3x3(new[] { Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z, Column2.x, Column2.y, Column2.z }));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 3 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix3x4d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix3x4d specifying the matrix columns.
		/// </summary>
		public Matrix3x4d(Vertex4d c0, Vertex4d c1, Vertex4d c2)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix3x4d column n. 1.
		/// </summary>
		public Vertex4d Column0;

		/// <summary>
		/// Matrix3x4d column n. 2.
		/// </summary>
		public Vertex4d Column1;

		/// <summary>
		/// Matrix3x4d column n. 3.
		/// </summary>
		public Vertex4d Column2;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix3x4d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(3, 4, Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w, Column2.x, Column2.y, Column2.z, Column2.w));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 2 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x2d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x2d specifying the matrix columns.
		/// </summary>
		public Matrix4x2d(Vertex2d c0, Vertex2d c1, Vertex2d c2, Vertex2d c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x2d column n. 1.
		/// </summary>
		public Vertex2d Column0;

		/// <summary>
		/// Matrix4x2d column n. 2.
		/// </summary>
		public Vertex2d Column1;

		/// <summary>
		/// Matrix4x2d column n. 3.
		/// </summary>
		public Vertex2d Column2;

		/// <summary>
		/// Matrix4x2d column n. 4.
		/// </summary>
		public Vertex2d Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x2d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(4, 2, Column0.x, Column0.y, Column1.x, Column1.y, Column2.x, Column2.y, Column3.x, Column3.y));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 3 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x3d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x3d specifying the matrix columns.
		/// </summary>
		public Matrix4x3d(Vertex3d c0, Vertex3d c1, Vertex3d c2, Vertex3d c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x3d column n. 1.
		/// </summary>
		public Vertex3d Column0;

		/// <summary>
		/// Matrix4x3d column n. 2.
		/// </summary>
		public Vertex3d Column1;

		/// <summary>
		/// Matrix4x3d column n. 3.
		/// </summary>
		public Vertex3d Column2;

		/// <summary>
		/// Matrix4x3d column n. 4.
		/// </summary>
		public Vertex3d Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x3d to MatrixDouble.
		/// </summary>
		public MatrixDouble ToMatrix()
		{
			return (new MatrixDouble(4, 3, Column0.x, Column0.y, Column0.z, Column1.x, Column1.y, Column1.z, Column2.x, Column2.y, Column2.z, Column3.x, Column3.y, Column3.z));
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Matrix4x4d
	{
		#region Structure

		/// <summary>
		/// Construct a Matrix4x4d specifying the matrix columns.
		/// </summary>
		public Matrix4x4d(Vertex4d c0, Vertex4d c1, Vertex4d c2, Vertex4d c3)
		{
			Column0 = c0;
			Column1 = c1;
			Column2 = c2;
			Column3 = c3;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Matrix4x4d column n. 1.
		/// </summary>
		public Vertex4d Column0;

		/// <summary>
		/// Matrix4x4d column n. 2.
		/// </summary>
		public Vertex4d Column1;

		/// <summary>
		/// Matrix4x4d column n. 3.
		/// </summary>
		public Vertex4d Column2;

		/// <summary>
		/// Matrix4x4d column n. 4.
		/// </summary>
		public Vertex4d Column3;

		#endregion

		#region ToMatrix

		/// <summary>
		/// Convert this Matrix4x4d to MatrixDouble4x4.
		/// </summary>
		public MatrixDouble4x4 ToMatrix()
		{
			return (new MatrixDouble4x4(new[] { Column0.x, Column0.y, Column0.z, Column0.w, Column1.x, Column1.y, Column1.z, Column1.w, Column2.x, Column2.y, Column2.z, Column2.w, Column3.x, Column3.y, Column3.z, Column3.w }));
		}

		#endregion
	}

}
