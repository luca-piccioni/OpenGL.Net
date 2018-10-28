
// Copyright (C) 2012-2017 Luca Piccioni
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

// ReSharper disable InconsistentNaming

using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// The type of the data collected in OpenGL array buffers.
	/// </summary>
	public enum ArrayBufferItemType
	{
		#region Single-Precision Floating-Point Types

		/// <summary>
		/// A single single-precision floating-point value.
		/// </summary>
		Float,
		/// <summary>
		/// A vector of two single-precision floating-point values.
		/// </summary>
		Float2,
		/// <summary>
		/// A vector of three single-precision floating-point values.
		/// </summary>
		Float3,
		/// <summary>
		/// A vector of four single-precision floating-point values.
		/// </summary>
		Float4,

		#endregion

		#region Half-Precision Floating-Point Types

		/// <summary>
		/// A single half-precision floating-point value.
		/// </summary>
		Half,
		/// <summary>
		/// A vector of two half-precision floating-point values.
		/// </summary>
		Half2,
		/// <summary>
		/// A vector of three half-precision floating-point values.
		/// </summary>
		Half3,
		/// <summary>
		/// A vector of four half-precision floating-point values.
		/// </summary>
		Half4,

		#endregion

		#region Double-Precision Floating-Point Types

		/// <summary>
		/// A single double-precision floating-point value.
		/// </summary>
		Double,
		/// <summary>
		/// A vector of two double-precision floating-point values.
		/// </summary>
		Double2,
		/// <summary>
		/// A vector of three double-precision floating-point values.
		/// </summary>
		Double3,
		/// <summary>
		/// A vector of four double-precision floating-point values.
		/// </summary>
		Double4,

		#endregion

		#region Signed Integer Types

		/// <summary>
		/// A single signed byte value.
		/// </summary>
		Byte,
		/// <summary>
		/// A vector of two signed byte values.
		/// </summary>
		Byte2,
		/// <summary>
		/// A vector of three signed byte values.
		/// </summary>
		Byte3,
		/// <summary>
		/// A vector of four signed byte values.
		/// </summary>
		Byte4,

		/// <summary>
		/// A single signed short integer value.
		/// </summary>
		Short,
		/// <summary>
		/// A vector of two signed short integer values.
		/// </summary>
		Short2,
		/// <summary>
		/// A vector of three signed short integer values.
		/// </summary>
		Short3,
		/// <summary>
		/// A vector of four signed short integer values.
		/// </summary>
		Short4,

		/// <summary>
		/// A single signed integer value.
		/// </summary>
		Int,
		/// <summary>
		/// A vector of two signed integer values.
		/// </summary>
		Int2,
		/// <summary>
		/// A vector of three signed integer values.
		/// </summary>
		Int3,
		/// <summary>
		/// A vector of four signed integer values.
		/// </summary>
		Int4,

		#endregion

		#region Unsigned Integer Types

		/// <summary>
		/// A single unsigned byte value.
		/// </summary>
		UByte,
		/// <summary>
		/// A vector of two unsigned byte values.
		/// </summary>
		UByte2,
		/// <summary>
		/// A vector of three unsigned byte values.
		/// </summary>
		UByte3,
		/// <summary>
		/// A vector of four unsigned byte values.
		/// </summary>
		UByte4,

		/// <summary>
		/// A single unsigned short integer value.
		/// </summary>
		UShort,
		/// <summary>
		/// A vector of two unsigned short integer values.
		/// </summary>
		UShort2,
		/// <summary>
		/// A vector of three unsigned short integer values.
		/// </summary>
		UShort3,
		/// <summary>
		/// A vector of four unsigned short integer values.
		/// </summary>
		UShort4,

		/// <summary>
		/// A single unsigned integer value.
		/// </summary>
		UInt,
		/// <summary>
		/// A vector of two unsigned integer values.
		/// </summary>
		UInt2,
		/// <summary>
		/// A vector of three unsigned integer values.
		/// </summary>
		UInt3,
		/// <summary>
		/// A vector of four unsigned integer values.
		/// </summary>
		UInt4,

		#endregion

		#region Single-Precision Floating-Point Matrix Types

		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 2 rows.
		/// </summary>
		Float2x2,
		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 3 rows.
		/// </summary>
		Float2x3,
		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 4 rows.
		/// </summary>
		Float2x4,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 2 rows.
		/// </summary>
		Float3x2,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 3 rows.
		/// </summary>
		Float3x3,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 4 rows.
		/// </summary>
		Float3x4,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 2 rows.
		/// </summary>
		Float4x2,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 3 rows.
		/// </summary>
		Float4x3,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 4 rows.
		/// </summary>
		Float4x4,

		#endregion

		#region Double-Precision Floating-Point Matrix Types

		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 2 rows.
		/// </summary>
		Double2x2,
		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 3 rows.
		/// </summary>
		Double2x3,
		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 4 rows.
		/// </summary>
		Double2x4,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 2 rows.
		/// </summary>
		Double3x2,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 3 rows.
		/// </summary>
		Double3x3,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 4 rows.
		/// </summary>
		Double3x4,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 2 rows.
		/// </summary>
		Double4x2,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 3 rows.
		/// </summary>
		Double4x3,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 4 rows.
		/// </summary>
		Double4x4,

		#endregion
	}

	/// <summary>
	/// Extension methods for <see cref="ArrayBufferItemType"/> enumeration.
	/// </summary>
	public static class ArrayBufferItemTypeExtensions
	{
		#region Base Type

		/// <summary>
		/// Get the array components base type of the vertex array buffer item.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static VertexBaseType GetVertexBaseType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
				case ArrayBufferItemType.Byte2:
				case ArrayBufferItemType.Byte3:
				case ArrayBufferItemType.Byte4:
					return VertexBaseType.Byte;
				case ArrayBufferItemType.UByte:
				case ArrayBufferItemType.UByte2:
				case ArrayBufferItemType.UByte3:
				case ArrayBufferItemType.UByte4:
					return VertexBaseType.UByte;
				case ArrayBufferItemType.Short:
				case ArrayBufferItemType.Short2:
				case ArrayBufferItemType.Short3:
				case ArrayBufferItemType.Short4:
					return VertexBaseType.Short;
				case ArrayBufferItemType.UShort:
				case ArrayBufferItemType.UShort2:
				case ArrayBufferItemType.UShort3:
				case ArrayBufferItemType.UShort4:
					return VertexBaseType.UShort;
				case ArrayBufferItemType.Int:
				case ArrayBufferItemType.Int2:
				case ArrayBufferItemType.Int3:
				case ArrayBufferItemType.Int4:
					return VertexBaseType.Int;
				case ArrayBufferItemType.UInt:
				case ArrayBufferItemType.UInt2:
				case ArrayBufferItemType.UInt3:
				case ArrayBufferItemType.UInt4:
					return VertexBaseType.UInt;
				case ArrayBufferItemType.Float:
				case ArrayBufferItemType.Float2:
				case ArrayBufferItemType.Float3:
				case ArrayBufferItemType.Float4:
				case ArrayBufferItemType.Float2x2:
				case ArrayBufferItemType.Float2x3:
				case ArrayBufferItemType.Float2x4:
				case ArrayBufferItemType.Float3x2:
				case ArrayBufferItemType.Float3x3:
				case ArrayBufferItemType.Float3x4:
				case ArrayBufferItemType.Float4x2:
				case ArrayBufferItemType.Float4x3:
				case ArrayBufferItemType.Float4x4:
					return VertexBaseType.Float;
#if !MONODROID
				case ArrayBufferItemType.Double:
				case ArrayBufferItemType.Double2:
				case ArrayBufferItemType.Double3:
				case ArrayBufferItemType.Double4:
				case ArrayBufferItemType.Double2x2:
				case ArrayBufferItemType.Double2x3:
				case ArrayBufferItemType.Double2x4:
				case ArrayBufferItemType.Double3x2:
				case ArrayBufferItemType.Double3x3:
				case ArrayBufferItemType.Double3x4:
				case ArrayBufferItemType.Double4x2:
				case ArrayBufferItemType.Double4x3:
				case ArrayBufferItemType.Double4x4:
					return VertexBaseType.Double;
#endif
				case ArrayBufferItemType.Half:
				case ArrayBufferItemType.Half2:
				case ArrayBufferItemType.Half3:
				case ArrayBufferItemType.Half4:
					return VertexBaseType.Half;
				default:
					throw new NotSupportedException("unsupported vertex array base type of " + vertexArrayType);
			}
		}

		/// <summary>
		/// Determine whether a vertex array type is composed by floating-point value(s).
		/// </summary>
		public static bool IsFloatBaseType(this ArrayBufferItemType vertexArrayType)
		{
			return vertexArrayType.GetVertexBaseType().IsFloatBaseType();
		}

		/// <summary>
		/// Get the size of a vertex array buffer item, in bytes.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the size of the vertex array buffer type having the type <paramref name="vertexArrayType"/>, in bytes.
		/// </returns>
		public static uint GetItemSize(this ArrayBufferItemType vertexArrayType)
		{
			uint baseTypeSize = vertexArrayType.GetVertexBaseType().GetSize();
			uint length = vertexArrayType.GetArrayLength();
			uint rank = vertexArrayType.GetArrayRank();

			return baseTypeSize * length * rank;
		}

		#endregion

		#region Length & Rank

		/// <summary>
		/// Get the number of components of the vertex array buffer item.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the count of the components of the vertex array buffer item. It will be a value
		/// from 1 (inclusive) to 4 (inclusive). For matrices, this value indicates the matrix height (column-major order).
		/// </returns>
		public static uint GetArrayLength(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
				case ArrayBufferItemType.UByte:
				case ArrayBufferItemType.Short:
				case ArrayBufferItemType.UShort:
				case ArrayBufferItemType.Int:
				case ArrayBufferItemType.UInt:
				case ArrayBufferItemType.Float:
				case ArrayBufferItemType.Double:
				case ArrayBufferItemType.Half:
					return 1;
				case ArrayBufferItemType.Byte2:
				case ArrayBufferItemType.UByte2:
				case ArrayBufferItemType.Short2:
				case ArrayBufferItemType.UShort2:
				case ArrayBufferItemType.Int2:
				case ArrayBufferItemType.UInt2:
				case ArrayBufferItemType.Float2:
				case ArrayBufferItemType.Double2:
				case ArrayBufferItemType.Half2:
				case ArrayBufferItemType.Float2x2:
				case ArrayBufferItemType.Float2x3:
				case ArrayBufferItemType.Float2x4:
				case ArrayBufferItemType.Double2x2:
				case ArrayBufferItemType.Double2x3:
				case ArrayBufferItemType.Double2x4:
					return 2;
				case ArrayBufferItemType.Byte3:
				case ArrayBufferItemType.UByte3:
				case ArrayBufferItemType.Short3:
				case ArrayBufferItemType.UShort3:
				case ArrayBufferItemType.Int3:
				case ArrayBufferItemType.UInt3:
				case ArrayBufferItemType.Float3:
				case ArrayBufferItemType.Double3:
				case ArrayBufferItemType.Half3:
				case ArrayBufferItemType.Float3x2:
				case ArrayBufferItemType.Float3x3:
				case ArrayBufferItemType.Float3x4:
				case ArrayBufferItemType.Double3x2:
				case ArrayBufferItemType.Double3x3:
				case ArrayBufferItemType.Double3x4:
					return 3;
				case ArrayBufferItemType.Byte4:
				case ArrayBufferItemType.UByte4:
				case ArrayBufferItemType.Short4:
				case ArrayBufferItemType.UShort4:
				case ArrayBufferItemType.Int4:
				case ArrayBufferItemType.UInt4:
				case ArrayBufferItemType.Float4:
				case ArrayBufferItemType.Double4:
				case ArrayBufferItemType.Half4:
				case ArrayBufferItemType.Float4x2:
				case ArrayBufferItemType.Float4x3:
				case ArrayBufferItemType.Float4x4:
				case ArrayBufferItemType.Double4x2:
				case ArrayBufferItemType.Double4x3:
				case ArrayBufferItemType.Double4x4:
					return 4;
				default:
					throw new NotSupportedException("unsupported vertex array length of " + vertexArrayType);
			}
		}

		/// <summary>
		/// Get the rank of the vertex array buffer item (that is, the number of <i>vec4</i> attributes requires).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the rank of the vertex array buffer item. It will be a value
		/// from 1 (inclusive) to 4 (inclusive). For matrices, this value indicates the matrix width (column-major order),
		/// while for simpler types the value will be 1.
		/// </returns>
		public static uint GetArrayRank(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Float2x2:
				case ArrayBufferItemType.Float3x2:
				case ArrayBufferItemType.Float4x2:
				case ArrayBufferItemType.Double2x2:
				case ArrayBufferItemType.Double3x2:
				case ArrayBufferItemType.Double4x2:
					return 2;
				case ArrayBufferItemType.Float2x3:
				case ArrayBufferItemType.Float3x3:
				case ArrayBufferItemType.Float4x3:
				case ArrayBufferItemType.Double2x3:
				case ArrayBufferItemType.Double3x3:
				case ArrayBufferItemType.Double4x3:
					return 3;
				case ArrayBufferItemType.Float2x4:
				case ArrayBufferItemType.Float3x4:
				case ArrayBufferItemType.Float4x4:
				case ArrayBufferItemType.Double2x4:
				case ArrayBufferItemType.Double3x4:
				case ArrayBufferItemType.Double4x4:
					return 4;
				case ArrayBufferItemType.Byte:
				case ArrayBufferItemType.UByte:
				case ArrayBufferItemType.Short:
				case ArrayBufferItemType.UShort:
				case ArrayBufferItemType.Int:
				case ArrayBufferItemType.UInt:
				case ArrayBufferItemType.Float:
				case ArrayBufferItemType.Double:
				case ArrayBufferItemType.Half:
				case ArrayBufferItemType.Byte2:
				case ArrayBufferItemType.UByte2:
				case ArrayBufferItemType.Short2:
				case ArrayBufferItemType.UShort2:
				case ArrayBufferItemType.Int2:
				case ArrayBufferItemType.UInt2:
				case ArrayBufferItemType.Float2:
				case ArrayBufferItemType.Double2:
				case ArrayBufferItemType.Half2:
				case ArrayBufferItemType.Byte3:
				case ArrayBufferItemType.UByte3:
				case ArrayBufferItemType.Short3:
				case ArrayBufferItemType.UShort3:
				case ArrayBufferItemType.Int3:
				case ArrayBufferItemType.UInt3:
				case ArrayBufferItemType.Float3:
				case ArrayBufferItemType.Double3:
				case ArrayBufferItemType.Half3:
				case ArrayBufferItemType.Byte4:
				case ArrayBufferItemType.UByte4:
				case ArrayBufferItemType.Short4:
				case ArrayBufferItemType.UShort4:
				case ArrayBufferItemType.Int4:
				case ArrayBufferItemType.UInt4:
				case ArrayBufferItemType.Float4:
				case ArrayBufferItemType.Double4:
				case ArrayBufferItemType.Half4:
					return 1;
				default:
					throw new NotSupportedException("unsupported vertex array rank of " + vertexArrayType);
			}
		}

		/// <summary>
		/// Get whether a <see cref="ArrayBufferItemType"/> is a simple type (float, int, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a simple type.
		/// </returns>
		public static bool IsArraySimpleType(this ArrayBufferItemType vertexArrayType)
		{
			return vertexArrayType.GetArrayLength() == 1 && vertexArrayType.GetArrayRank() == 1;
		}

		/// <summary>
		/// Get whether a <see cref="ArrayBufferItemType"/> is a vector type (vec2, vec3, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a vector type.
		/// </returns>
		public static bool IsArrayVectorType(this ArrayBufferItemType vertexArrayType)
		{
			return vertexArrayType.GetArrayLength() > 1 && vertexArrayType.GetArrayRank() == 1;
		}

		/// <summary>
		/// Get whether a <see cref="ArrayBufferItemType"/> is a matrix type (mat2, mat4, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a matrix type.
		/// </returns>
		public static bool IsArrayMatrixType(this ArrayBufferItemType vertexArrayType)
		{
			return GetArrayRank(vertexArrayType) > 1;
		}

		/// <summary>
		/// Get the correponding type for the column of the matrix type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a matrix type.
		/// </returns>
		public static ArrayBufferItemType GetMatrixColumnType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Float2x2:
				case ArrayBufferItemType.Float2x3:
				case ArrayBufferItemType.Float2x4:
					return ArrayBufferItemType.Float2;
				case ArrayBufferItemType.Float3x2:
				case ArrayBufferItemType.Float3x3:
				case ArrayBufferItemType.Float3x4:
					return ArrayBufferItemType.Float3;
				case ArrayBufferItemType.Float4x2:
				case ArrayBufferItemType.Float4x3:
				case ArrayBufferItemType.Float4x4:
					return ArrayBufferItemType.Float4;
				case ArrayBufferItemType.Double2x2:
				case ArrayBufferItemType.Double2x3:
				case ArrayBufferItemType.Double2x4:
					return ArrayBufferItemType.Double2;
				case ArrayBufferItemType.Double3x2:
				case ArrayBufferItemType.Double3x3:
				case ArrayBufferItemType.Double3x4:
					return ArrayBufferItemType.Double3;
				case ArrayBufferItemType.Double4x2:
				case ArrayBufferItemType.Double4x3:
				case ArrayBufferItemType.Double4x4:
					return ArrayBufferItemType.Double4;
				default:
					throw new NotImplementedException();
			}
		}

		#endregion

		#region Fixed Pipeline Array Base Type

		/// <summary>
		/// Get the array components base type of the vertex array attribute item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array attribute item type.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static VertexPointerType GetVertexPointerType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType.GetVertexBaseType()) {
				case VertexBaseType.Short:
					return VertexPointerType.Short;
				case VertexBaseType.Int:
					return VertexPointerType.Int;
				case VertexBaseType.Float:
					return VertexPointerType.Float;
#if !MONODROID
				case VertexBaseType.Double:
					return VertexPointerType.Double;
#endif
				default:
					throw new NotSupportedException($"vertex pointer of type {vertexArrayType} not supported");
			}
		}

		/// <summary>
		/// Get the array components base type of the vertex array attribute item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array attribute item type.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static ColorPointerType GetColorPointerType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType.GetVertexBaseType()) {
				case VertexBaseType.Byte:
					return ColorPointerType.Byte;
				case VertexBaseType.UByte:
					return ColorPointerType.UnsignedByte;
				case VertexBaseType.Short:
					return ColorPointerType.Short;
				case VertexBaseType.UShort:
					return ColorPointerType.UnsignedShort;
				case VertexBaseType.Int:
					return ColorPointerType.Int;
				case VertexBaseType.UInt:
					return ColorPointerType.UnsignedInt;
				case VertexBaseType.Float:
					return ColorPointerType.Float;
#if !MONODROID
				case VertexBaseType.Double:
					return ColorPointerType.Double;
#endif
				default:
					throw new NotSupportedException($"color pointer of type {vertexArrayType} not supported");
			}
		}

		/// <summary>
		/// Get the array components base type of the vertex array attribute item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array attribute item type.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static NormalPointerType GetNormalPointerType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType.GetVertexBaseType()) {
				case VertexBaseType.Byte:
					return NormalPointerType.Byte;
				case VertexBaseType.Short:
					return NormalPointerType.Short;
				case VertexBaseType.Int:
					return NormalPointerType.Int;
				case VertexBaseType.Float:
					return NormalPointerType.Float;
#if !MONODROID
				case VertexBaseType.Double:
					return NormalPointerType.Double;
#endif
				default:
					throw new NotSupportedException($"normal pointer of type {vertexArrayType} not supported");
			}
		}

		/// <summary>
		/// Get the array components base type of the vertex array attribute item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array attribute item type.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static TexCoordPointerType GetTexCoordPointerType(this ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType.GetVertexBaseType()) {
				case VertexBaseType.Short:
					return TexCoordPointerType.Short;
				case VertexBaseType.Int:
					return TexCoordPointerType.Int;
				case VertexBaseType.Float:
					return TexCoordPointerType.Float;
#if !MONODROID
				case VertexBaseType.Double:
					return TexCoordPointerType.Double;
#endif
				default:
					throw new NotSupportedException($"vertex pointer of type {vertexArrayType} not supported");
			}
		}

		#endregion
	}
}
