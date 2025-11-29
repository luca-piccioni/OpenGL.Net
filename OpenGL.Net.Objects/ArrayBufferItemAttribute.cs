
// Copyright (C) 2011-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects
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