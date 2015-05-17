
// Copyright (C) 2011-2015 Luca Piccioni
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
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	[DebuggerDisplay("ArrayBufferItemAttribute ArrayType={ArrayType} ArraySize{ArraySize} Normalized{Normalized}")]
	public class ArrayBufferItemAttribute : Attribute
	{
		/// <summary>
		/// Construct an ArrayBufferItemAttribute for vector items.
		/// </summary>
		/// <param name="arrayType">
		/// A <see cref="VertexBaseType"/> describing the vector components type.
		/// </param>
		/// <param name="arrayLength">
		/// A <see cref="System.UInt32"/> that specify the vector length.
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
		/// A <see cref="System.UInt32"/> that specify the matrix columns count.
		/// </param>
		/// <param name="matrixRows">
		/// A <see cref="System.UInt32"/> that specify the matrix rows count.
		/// </param>
		public ArrayBufferItemAttribute(VertexBaseType arrayType, uint matrixColumns, uint matrixRows)
		{
			mArrayType = arrayType;
			mArrayLength = matrixRows;
			mArrayRank = matrixColumns;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexArrayType"></param>
		public ArrayBufferItemAttribute(ArrayBufferItemType vertexArrayType)
		{
			mArrayType = ArrayBufferItem.GetArrayBaseType(vertexArrayType);
			mArrayLength = ArrayBufferItem.GetArrayLength(vertexArrayType);
			mArrayRank = ArrayBufferItem.GetArrayRank(vertexArrayType);
		}

		/// <summary>
		/// The array type.
		/// </summary>
		public ArrayBufferItemType ArrayType { get { return (ArrayBufferItem.GetArrayType(mArrayType, ArrayLength, ArrayRank)); } }

		/// <summary>
		/// The array base type.
		/// </summary>
		public VertexBaseType ArrayBaseType { get { return (mArrayType); } }

		/// <summary>
		/// The array length.
		/// </summary>
		public uint ArrayLength { get { return (mArrayLength); } }

		/// <summary>
		/// The array rank.
		/// </summary>
		public uint ArrayRank { get { return (mArrayRank); } }

		/// <summary>
		/// Indicates whether the integer data shall be interpreted as normalized floating-point.
		/// </summary>
		public bool Normalized;

		/// <summary>
		/// The array type.
		/// </summary>
		private readonly VertexBaseType mArrayType;

		/// <summary>
		/// The array length.
		/// </summary>
		private readonly uint mArrayLength;

		/// <summary>
		/// The array rank.
		/// </summary>
		private readonly uint mArrayRank;
	}
}