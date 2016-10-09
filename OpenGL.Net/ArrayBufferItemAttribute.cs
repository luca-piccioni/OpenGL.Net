
// Copyright (C) 2011-2016 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Attribute assigned to those types having a direct representation in buffer.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This Attribute is required for detecting an OpenGL sub-array inside a buffer object. All those
	/// types not specifying this Attribute cannot be used for managing buffer object data.
	/// </para>
	/// </remarks>
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = false)]
	[DebuggerDisplay("ArrayBufferItemAttribute: ArrayType={ArrayType} ArraySize{ArraySize} Normalized{Normalized}")]
	public class ArrayBufferItemAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferItemAttribute for vector items.
		/// </summary>
		/// <param name="arrayType">
		/// A <see cref="VertexBaseType"/> describing the vector components type.
		/// </param>
		/// <param name="arrayLength">
		/// A <see cref="UInt32"/> that specify the vector length.
		/// </param>
		public ArrayBufferItemAttribute(VertexBaseType arrayType, uint arrayLength)
			: this(arrayType, 1, arrayLength)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferItemAttribute for matrix items.
		/// </summary>
		/// <param name="arrayType">
		/// A <see cref="VertexBaseType"/> describing the matrix components type.
		/// </param>
		/// <param name="matrixColumns">
		/// A <see cref="UInt32"/> that specify the matrix columns count.
		/// </param>
		/// <param name="matrixRows">
		/// A <see cref="UInt32"/> that specify the matrix rows count.
		/// </param>
		public ArrayBufferItemAttribute(VertexBaseType arrayType, uint matrixColumns, uint matrixRows)
		{
			ArrayType = arrayType.GetArrayBufferType(matrixRows, matrixColumns);
			ArrayBaseType = arrayType;
			ArrayLength = matrixRows;
			ArrayRank = matrixColumns;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexArrayType"></param>
		public ArrayBufferItemAttribute(ArrayBufferItemType vertexArrayType)
		{
			ArrayType = vertexArrayType;
			ArrayBaseType = vertexArrayType.GetVertexBaseType();
			ArrayLength = vertexArrayType.GetArrayLength();
			ArrayRank = vertexArrayType.GetArrayRank();
		}

		#endregion

		#region Structure Information

		/// <summary>
		/// The array type.
		/// </summary>
		public readonly ArrayBufferItemType ArrayType;

		/// <summary>
		/// The array base type.
		/// </summary>
		public readonly VertexBaseType ArrayBaseType;

		/// <summary>
		/// The array length.
		/// </summary>
		public readonly uint ArrayLength;

		/// <summary>
		/// The array rank.
		/// </summary>
		public readonly uint ArrayRank;

		/// <summary>
		/// Indicates whether the integer data shall be interpreted as normalized floating-point.
		/// </summary>
		public bool Normalized;

		/// <summary>
		/// Indicated whether this field should be ignored in special cases.
		/// </summary>
		public bool Ignore;

		#endregion
	}
}