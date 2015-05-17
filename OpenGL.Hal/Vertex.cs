
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
using System.Runtime.InteropServices;

namespace OpenGL
{
	#region Single-Precision Matrices

	/// <summary>
	/// Generic matrix interface.
	/// </summary>
	public interface ISingleMatrix
	{
		/// <summary>
		/// Get or set matrix components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="System.UInt32"/> that specify the component's column index.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the component's row index.
		/// </param>
		float this[uint c, uint r] { get; set; }

		/// <summary>
		/// Convert this structure to a <see cref="Matrix"/> instance.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Matrix"/> instance equivalent to this ISingleMatrix.
		/// </returns>
		Matrix ToMatrix();
	}

	/// <summary>
	/// Matrix composed by 2 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 2, 4)]
	public struct Matrix2x4 : ISingleMatrix
	{
		#region Structure

		/// <summary>
		/// Matrix2x4 first column.
		/// </summary>
		private Vertex4f Column0;

		/// <summary>
		/// Matrix2x4 second column.
		/// </summary>
		private Vertex4f Column1;

		#endregion

		#region ISingleMatrix Implementation

		/// <summary>
		/// Get or set matrix components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="System.UInt32"/> that specify the component's column index.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the component's row index.
		/// </param>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						return (Column0[r]);
					case 1:
						return (Column1[r]);
					default:
						throw new ArgumentException("out of bounds", "c");
				}
			}
			set
			{
				switch (c) {
					case 0:
						Column0[r] = value;
						break;
					case 1:
						Column1[r] = value;
						break;
					default:
						throw new ArgumentException("out of bounds", "c");
				}
			}
		}

		/// <summary>
		/// Convert this structure to a <see cref="Matrix"/> instance.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Matrix"/> instance equivalent to this ISingleMatrix.
		/// </returns>
		public Matrix ToMatrix()
		{
			return (null);
		}

		#endregion
	}

	/// <summary>
	/// Matrix composed by 4 columns and 4 rows.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 4, 4)]
	public struct Matrix4 : ISingleMatrix
	{
		#region Structure

		/// <summary>
		/// Matrix4 first column.
		/// </summary>
		private Vertex4f Column0;

		/// <summary>
		/// Matrix4 second column.
		/// </summary>
		private Vertex4f Column1;

		/// <summary>
		/// Matrix4 third column.
		/// </summary>
		private Vertex4f Column2;

		/// <summary>
		/// Matrix4 fourth column.
		/// </summary>
		private Vertex4f Column3;

		#endregion

		#region ISingleMatrix Implementation

		/// <summary>
		/// Get or set matrix components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="System.UInt32"/> that specify the component's column index.
		/// </param>
		/// <param name="r">
		/// A <see cref="System.UInt32"/> that specify the component's row index.
		/// </param>
		public float this[uint c, uint r]
		{
			get
			{
				switch (c) {
					case 0:
						return (Column0[r]);
					case 1:
						return (Column1[r]);
					case 2:
						return (Column2[r]);
					case 3:
						return (Column3[r]);
					default:
						throw new ArgumentException("out of bounds", "c");
				}
			}
			set
			{
				switch (c) {
					case 0:
						Column0[r] = value;
						break;
					case 1:
						Column1[r] = value;
						break;
					case 2:
						Column2[r] = value;
						break;
					case 3:
						Column3[r] = value;
						break;
					default:
						throw new ArgumentException("out of bounds", "c");
				}
			}
		}

		/// <summary>
		/// Convert this structure to a <see cref="Matrix"/> instance.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Matrix"/> instance equivalent to this ISingleMatrix.
		/// </returns>
		public Matrix ToMatrix()
		{
			Matrix matrix = new Matrix4x4();

			for (uint r = 0; r < 4; r++)
				matrix[0, r] = Column0[r];
			for (uint r = 0; r < 4; r++)
				matrix[1, r] = Column1[r];
			for (uint r = 0; r < 4; r++)
				matrix[2, r] = Column2[r];
			for (uint r = 0; r < 4; r++)
				matrix[3, r] = Column3[r];

			return (matrix);
		}

		/// <summary>
		/// Convert this structure to a <see cref="Matrix"/> instance.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Matrix"/> instance equivalent to this ISingleMatrix.
		/// </returns>
		public Matrix4x4 ToMatrix4x4()
		{
			return ((Matrix4x4)ToMatrix());
		}

		#endregion
	}

	#endregion
}
