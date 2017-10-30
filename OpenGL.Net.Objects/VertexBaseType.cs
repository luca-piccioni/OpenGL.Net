
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Base type of vertex components.
	/// </summary>
	public enum VertexBaseType
	{
		/// <summary>
		/// Signed byte components.
		/// </summary>
		Byte = Gl.BYTE,

		/// <summary>
		/// Unsigned byte components.
		/// </summary>
		UByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Signed short components.
		/// </summary>
		Short = Gl.SHORT,

		/// <summary>
		/// Unsigned short components.
		/// </summary>
		UShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Signed integer components.
		/// </summary>
		Int = Gl.INT,

		/// <summary>
		/// Unsigned integer components.
		/// </summary>
		UInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Single-precision floating-point components.
		/// </summary>
		Float = Gl.FLOAT,

#if !MONODROID

		/// <summary>
		/// Double-precision floating-point components.
		/// </summary>
		Double = Gl.DOUBLE,

#endif

		/// <summary>
		/// Half-precision floating-point components.
		/// </summary>
		Half = Gl.HALF_FLOAT,
	}

	/// <summary>
	/// Extension methods for <see cref="VertexBaseType"/> enumeration.
	/// </summary>
	public static class VertexBaseTypeExtensions
	{
		#region Base Type

		/// <summary>
		/// Determine whether a base type is a floating-point value.
		/// </summary>
		public static bool IsFloatBaseType(this VertexBaseType vertexBaseType)
		{
			switch (vertexBaseType) {
					case VertexBaseType.Float:
					case VertexBaseType.Half:
#if !MONODROID
					case VertexBaseType.Double:
#endif
						return (true);
					default:
						return (false);
				}
		}

		/// <summary>
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a set of parameters.
		/// </summary>
		/// <param name="baseType">
		/// A <see cref="VertexBaseType"/> indicating the type of the components of the vertex array buffer item.
		/// </param>
		/// <param name="length">
		/// A <see cref="UInt32"/> indicating the length of the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferItemType"/> having a base type equals to <paramref name="baseType"/>, a
		/// length equals to <paramref name="length"/> and a rank equals to 1 (implicit).
		/// </returns>
		public static ArrayBufferItemType GetArrayBufferType(VertexBaseType baseType, uint length)
		{
			return (baseType.GetArrayBufferType(length, 1));
		}

		/// <summary>
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a set of parameters.
		/// </summary>
		/// <param name="baseType">
		/// A <see cref="VertexBaseType"/> indicating the type of the components of the vertex array buffer item.
		/// </param>
		/// <param name="length">
		/// A <see cref="UInt32"/> indicating the length of the vertex array buffer item.
		/// </param>
		/// <param name="rank">
		/// A <see cref="UInt32"/> indicating the rank of the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferItemType"/> having a base type equals to <paramref name="baseType"/>, a
		/// length equals to <paramref name="length"/> and a rank equals to <paramref name="rank"/>.
		/// </returns>
		public static ArrayBufferItemType GetArrayBufferType(this VertexBaseType baseType, uint length, uint rank)
		{
			if ((length < 1) || (length > 4))
				throw new ArgumentOutOfRangeException("length", length, "it must be in the range [1..4]");
			if ((rank < 1) || (rank > 4))
				throw new ArgumentOutOfRangeException("rank", rank, "it must be in the range [1..4]");
			if ((rank > 1) && (length == 1))
				throw new InvalidOperationException("bad combination of rank and length");

			switch (baseType) {

				#region VertexBaseType.Byte

				case VertexBaseType.Byte:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Byte);
								case 2:
									return (ArrayBufferItemType.Byte2);
								case 3:
									return (ArrayBufferItemType.Byte3);
								case 4:
									return (ArrayBufferItemType.Byte4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Byte with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Byte with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.UByte

				case VertexBaseType.UByte:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.UByte);
								case 2:
									return (ArrayBufferItemType.UByte2);
								case 3:
									return (ArrayBufferItemType.UByte3);
								case 4:
									return (ArrayBufferItemType.UByte4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of UByte with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of UByte with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.Short

				case VertexBaseType.Short:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Short);
								case 2:
									return (ArrayBufferItemType.Short2);
								case 3:
									return (ArrayBufferItemType.Short3);
								case 4:
									return (ArrayBufferItemType.Short4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Short with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Short with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.UShort

				case VertexBaseType.UShort:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.UShort);
								case 2:
									return (ArrayBufferItemType.UShort2);
								case 3:
									return (ArrayBufferItemType.UShort3);
								case 4:
									return (ArrayBufferItemType.UShort4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of UShort with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of UShort with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.Int

				case VertexBaseType.Int:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Int);
								case 2:
									return (ArrayBufferItemType.Int2);
								case 3:
									return (ArrayBufferItemType.Int3);
								case 4:
									return (ArrayBufferItemType.Int4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Int with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Int with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.UInt

				case VertexBaseType.UInt:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.UInt);
								case 2:
									return (ArrayBufferItemType.UInt2);
								case 3:
									return (ArrayBufferItemType.UInt3);
								case 4:
									return (ArrayBufferItemType.UInt4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of UInt with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of UInt with rank {0}", rank));
					}

				#endregion

				#region VertexBaseType.Float

				case VertexBaseType.Float:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Float);
								case 2:
									return (ArrayBufferItemType.Float2);
								case 3:
									return (ArrayBufferItemType.Float3);
								case 4:
									return (ArrayBufferItemType.Float4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Float with rank {0} and length {1}", rank, length));
							}
						case 2:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Float2x2);
								case 3:
									return (ArrayBufferItemType.Float2x3);
								case 4:
									return (ArrayBufferItemType.Float2x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Float with rank {0} and length {1}", rank, length));
							}
						case 3:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Float3x2);
								case 3:
									return (ArrayBufferItemType.Float3x3);
								case 4:
									return (ArrayBufferItemType.Float3x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Float with rank {0} and length {1}", rank, length));
							}
						case 4:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Float4x2);
								case 3:
									return (ArrayBufferItemType.Float4x3);
								case 4:
									return (ArrayBufferItemType.Float4x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Float with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Float with rank {0}", rank));
					}

				#endregion

#if !MONODROID

				#region VertexBaseType.Double

				case VertexBaseType.Double:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Double);
								case 2:
									return (ArrayBufferItemType.Double2);
								case 3:
									return (ArrayBufferItemType.Double3);
								case 4:
									return (ArrayBufferItemType.Double4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Double with rank {0} and length {1}", rank, length));
							}
						case 2:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Double2x2);
								case 3:
									return (ArrayBufferItemType.Double2x3);
								case 4:
									return (ArrayBufferItemType.Double2x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Double with rank {0} and length {1}", rank, length));
							}
						case 3:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Double3x2);
								case 3:
									return (ArrayBufferItemType.Double3x3);
								case 4:
									return (ArrayBufferItemType.Double3x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Double with rank {0} and length {1}", rank, length));
							}
						case 4:
							switch (length) {
								case 2:
									return (ArrayBufferItemType.Double4x2);
								case 3:
									return (ArrayBufferItemType.Double4x3);
								case 4:
									return (ArrayBufferItemType.Double4x4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Double with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Double with rank {0}", rank));
					}

				#endregion

#endif

				#region VertexBaseType.Half

				case VertexBaseType.Half:
					switch (rank) {
						case 1:
							switch (length) {
								case 1:
									return (ArrayBufferItemType.Half);
								case 2:
									return (ArrayBufferItemType.Half2);
								case 3:
									return (ArrayBufferItemType.Half3);
								case 4:
									return (ArrayBufferItemType.Half4);
								default:
									throw new NotSupportedException(String.Format("unsupported vertex array base type of Half with rank {0} and length {1}", rank, length));
							}
						default:
							throw new NotSupportedException(String.Format("unsupported vertex array base type of Half with rank {0}", rank));
					}

				#endregion

				default:
					throw new NotSupportedException(String.Format("unsupported vertex array base type of {0}", baseType));
			}
		}

		/// <summary>
		/// Get the size of a vertex array buffer item.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the size of the vertex array buffer type having the type <paramref name="vertexBaseType"/>, in bytes.
		/// </returns>
		public static uint GetSize(this VertexBaseType vertexBaseType)
		{
			switch (vertexBaseType) {
				case VertexBaseType.Byte:
				case VertexBaseType.UByte:
					return (1);
				case VertexBaseType.Short:
				case VertexBaseType.UShort:
				case VertexBaseType.Half:
					return (2);
				case VertexBaseType.Float:
				case VertexBaseType.Int:
				case VertexBaseType.UInt:
					return (4);
#if !MONODROID
				case VertexBaseType.Double:
					return (8);
#endif
				default:
					throw new NotSupportedException("base type not supported");
			}
		}

		#endregion
	}
}