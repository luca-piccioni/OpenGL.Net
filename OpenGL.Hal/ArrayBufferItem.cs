
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

namespace OpenGL
{
	/// <summary>
	/// Class describing a vertex array buffer item.
	/// </summary>
	public class ArrayBufferItem : IEquatable<ArrayBufferItem>
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexBaseType"></param>
		/// <param name="vertexLength"></param>
		public ArrayBufferItem(VertexBaseType vertexBaseType, uint vertexLength)
			: this(vertexBaseType, vertexLength, 1)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexBaseType"></param>
		/// <param name="vertexLength"></param>
		/// <param name="vertexRank"></param>
		public ArrayBufferItem(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank)
		{
			if (vertexBaseType == VertexBaseType.Undefined)
				throw new ArgumentException("invalid", "vertexBaseType");

			mVertexArrayType = GetArrayType(vertexBaseType, vertexLength, vertexRank);
			mVertexBaseType = vertexBaseType;
		}

		/// <summary>
		/// Construct an ArrayBufferItem from a <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that synthetize all informations about a vertex array buffer item.
		/// </param>
		public ArrayBufferItem(ArrayBufferItemType vertexArrayType)
		{
			if (vertexArrayType == ArrayBufferItemType.Complex)
				throw new ArgumentException("invalid", "vertexArrayType");

			mVertexArrayType = vertexArrayType;
			mVertexBaseType = GetArrayBaseType(mVertexArrayType);
		}

		/// <summary>
		/// Construct an ArrayBufferItem from a <see cref="ArrayBufferItemAttribute"/>.
		/// </summary>
		/// <param name="attribute">
		/// A <see cref="ArrayBufferItemAttribute"/> describing the vertex array buffer item.
		/// </param>
		public ArrayBufferItem(ArrayBufferItemAttribute attribute)
		{
			if (attribute == null)
				throw new ArgumentNullException("attribute");

			mVertexArrayType = GetArrayType(attribute.ArrayBaseType, attribute.ArrayLength, attribute.ArrayRank);
			mVertexBaseType = GetArrayBaseType(mVertexArrayType);
		}

		#endregion

		#region Array Information

		/// <summary>
		/// The base type of each component of the vertex array buffer item.
		/// </summary>
		public VertexBaseType BaseType { get { return (mVertexBaseType); } }

		/// <summary>
		/// The type of this vertex array buffer item.
		/// </summary>
		public ArrayBufferItemType Type
		{
			get { return (mVertexArrayType); }
		}

		/// <summary>
		/// The number of components of the vertex array buffer item.
		/// </summary>
		public uint ArrayLength { get { return (GetArrayLength(mVertexArrayType)); } }

		/// <summary>
		/// Determine whether the base type is a floating-point value.
		/// </summary>
		public bool IsFloat { get { return (IsFloatBaseType(mVertexArrayType)); } }

		/// <summary>
		/// The vertex array item base type.
		/// </summary>
		private readonly VertexBaseType mVertexBaseType;

		/// <summary>
		/// The vertex array item type.
		/// </summary>
		private readonly ArrayBufferItemType mVertexArrayType;

		#endregion

		#region Array Item Normalization

		/// <summary>
		/// Determine whether the integer values shall be considered normalized floating-point.
		/// </summary>
		public bool Normalized
		{
			get { return (mNormalized); }
			set { mNormalized = value; }
		}

		/// <summary>
		/// Determine whether the integer values shall be considered normalized floating-point.
		/// </summary>
		private bool mNormalized;

		#endregion

		#region Static Utilities

		#region OpenGL Support

		/// <summary>
		/// Check whether a <see cref="VertexBaseType"/> is supported by current OpenGL implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify the OpenGL implementation.
		/// </param>
		/// <param name="baseType">
		/// A <see cref="VertexBaseType"/> to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether vertex attributes data can be specified with vertices having
		/// the base type <paramref name="baseType"/>.
		/// </returns>
		public static bool IsDataSupported(GraphicsContext ctx, VertexBaseType baseType)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			switch (baseType) {
				case VertexBaseType.Half:
					return (ctx.Caps.GlExtensions.HalfFloatVertex_ARB);
				default:
					return (true);
			}
		}

		/// <summary>
		/// Check whether a <see cref="VertexBaseType"/> is supported by current OpenGL implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify the OpenGL implementation.
		/// </param>
		/// <param name="arrayType">
		/// A <see cref="ArrayBufferItemType"/> to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether vertex attributes data can be specified with vertices having
		/// the base type <paramref name="arrayType"/>.
		/// </returns>
		public static bool IsDataSupported(GraphicsContext ctx, ArrayBufferItemType arrayType)
		{
			return (IsDataSupported(ctx, GetArrayBaseType(arrayType)));
		}

		#endregion

		#region Get Array Type

		/// <summary>
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a set of parameters.
		/// </summary>
		/// <param name="baseType">
		/// A <see cref="VertexBaseType"/> indicating the type of the components of the vertex array buffer item.
		/// </param>
		/// <param name="length">
		/// A <see cref="System.UInt32"/> indicating the length of the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferItemType"/> having a base type equals to <paramref name="baseType"/>, a
		/// length equals to <paramref name="length"/> and a rank equals to 1 (implicit).
		/// </returns>
		public static ArrayBufferItemType GetArrayType(VertexBaseType baseType, uint length)
		{
			return (GetArrayType(baseType, length, 1));
		}

		/// <summary>
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a set of parameters.
		/// </summary>
		/// <param name="baseType">
		/// A <see cref="VertexBaseType"/> indicating the type of the components of the vertex array buffer item.
		/// </param>
		/// <param name="length">
		/// A <see cref="System.UInt32"/> indicating the length of the vertex array buffer item.
		/// </param>
		/// <param name="rank">
		/// A <see cref="System.UInt32"/> indicating the rank of the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferItemType"/> having a base type equals to <paramref name="baseType"/>, a
		/// length equals to <paramref name="length"/> and a rank equals to <paramref name="rank"/>.
		/// </returns>
		public static ArrayBufferItemType GetArrayType(VertexBaseType baseType, uint length, uint rank)
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
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a <see cref="Type"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="Type"/> indicating the structure describing the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferItemType"/> corresponding to <paramref name="type"/>.
		/// </returns>
		public static ArrayBufferItemType GetArrayType(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			if (type == typeof(SByte))
				return (ArrayBufferItemType.Byte);
			if (type == typeof(Int16))
				return (ArrayBufferItemType.Short);
			if (type == typeof(Int32))
				return (ArrayBufferItemType.Int);

			if (type == typeof(Byte))
				return (ArrayBufferItemType.UByte);
			if (type == typeof(UInt16))
				return (ArrayBufferItemType.UShort);
			if (type == typeof(UInt32))
				return (ArrayBufferItemType.UInt);

			if (type == typeof(Single))
				return (ArrayBufferItemType.Float);
			if (type == typeof(Double))
				return (ArrayBufferItemType.Double);
			if (type == typeof(HalfFloat))
				return (ArrayBufferItemType.Half);

			ArrayBufferItemAttribute attribute = (ArrayBufferItemAttribute) Attribute.GetCustomAttribute(type, typeof(ArrayBufferItemAttribute));
			if (attribute != null)
				return (attribute.ArrayType);

			return (ArrayBufferItemType.Complex);
		}

		#endregion

		#region Get Array Base Type

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
		public static VertexBaseType GetArrayBaseType(ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
				case ArrayBufferItemType.Byte2:
				case ArrayBufferItemType.Byte3:
				case ArrayBufferItemType.Byte4:
					return (VertexBaseType.Byte);
				case ArrayBufferItemType.UByte:
				case ArrayBufferItemType.UByte2:
				case ArrayBufferItemType.UByte3:
				case ArrayBufferItemType.UByte4:
					return (VertexBaseType.UByte);
				case ArrayBufferItemType.Short:
				case ArrayBufferItemType.Short2:
				case ArrayBufferItemType.Short3:
				case ArrayBufferItemType.Short4:
					return (VertexBaseType.Short);
				case ArrayBufferItemType.UShort:
				case ArrayBufferItemType.UShort2:
				case ArrayBufferItemType.UShort3:
				case ArrayBufferItemType.UShort4:
					return (VertexBaseType.UShort);
				case ArrayBufferItemType.Int:
				case ArrayBufferItemType.Int2:
				case ArrayBufferItemType.Int3:
				case ArrayBufferItemType.Int4:
					return (VertexBaseType.Int);
				case ArrayBufferItemType.UInt:
				case ArrayBufferItemType.UInt2:
				case ArrayBufferItemType.UInt3:
				case ArrayBufferItemType.UInt4:
					return (VertexBaseType.UInt);
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
					return (VertexBaseType.Float);
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
					return (VertexBaseType.Double);
				case ArrayBufferItemType.Half:
				case ArrayBufferItemType.Half2:
				case ArrayBufferItemType.Half3:
				case ArrayBufferItemType.Half4:
					return (VertexBaseType.Half);
				default:
					throw new NotSupportedException("unsupported vertex array base type of " + vertexArrayType);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static VertexBaseType GetArrayBaseType(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			if (type == typeof(Single))
				return (VertexBaseType.Float);
			if (type == typeof(HalfFloat))
				return (VertexBaseType.Half);
			if (type == typeof(Int32))
				return (VertexBaseType.Int);
			if (type == typeof(UInt32))
				return (VertexBaseType.UInt);
			if (type == typeof(Int16))
				return (VertexBaseType.Short);
			if (type == typeof(UInt16))
				return (VertexBaseType.UShort);
			if (type == typeof(Byte))
				return (VertexBaseType.UByte);
			if (type == typeof(SByte))
				return (VertexBaseType.Byte);

			throw new ArgumentException(String.Format("unable to match type {0}", type.Name));
		}

		#endregion

		#region Is Float

		/// <summary>
		/// Determine whether a base type is a floating-point value.
		/// </summary>
		public static bool IsFloatBaseType(VertexBaseType vertexBaseType)
		{
			switch (vertexBaseType) {
					case VertexBaseType.Float:
					case VertexBaseType.Half:
					case VertexBaseType.Double:
						return (true);
					default:
						return (false);
				}
		}

		/// <summary>
		/// Determine whether a vertex array type is composed by floating-point value(s).
		/// </summary>
		public static bool IsFloatBaseType(ArrayBufferItemType vertexArrayType)
		{
			return (IsFloatBaseType(GetArrayBaseType(vertexArrayType)));
		}
		
		#endregion

		#region Array Length & Rank

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
		public static uint GetArrayLength(ArrayBufferItemType vertexArrayType)
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
					return (1);
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
					return (2);
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
					return (3);
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
					return (4);
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
		public static uint GetArrayRank(ArrayBufferItemType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Float2x2:
				case ArrayBufferItemType.Float3x2:
				case ArrayBufferItemType.Float4x2:
				case ArrayBufferItemType.Double2x2:
				case ArrayBufferItemType.Double3x2:
				case ArrayBufferItemType.Double4x2:
					return (2);
				case ArrayBufferItemType.Float2x3:
				case ArrayBufferItemType.Float3x3:
				case ArrayBufferItemType.Float4x3:
				case ArrayBufferItemType.Double2x3:
				case ArrayBufferItemType.Double3x3:
				case ArrayBufferItemType.Double4x3:
					return (3);
				case ArrayBufferItemType.Float2x4:
				case ArrayBufferItemType.Float3x4:
				case ArrayBufferItemType.Float4x4:
				case ArrayBufferItemType.Double2x4:
				case ArrayBufferItemType.Double3x4:
				case ArrayBufferItemType.Double4x4:
					return (4);
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
					return (1);
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
		public static bool IsArraySimpleType(ArrayBufferItemType vertexArrayType)
		{
			return ((GetArrayLength(vertexArrayType) == 1) && (GetArrayRank(vertexArrayType) == 1));
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
		public static bool IsArrayVectorType(ArrayBufferItemType vertexArrayType)
		{
			return ((GetArrayLength(vertexArrayType) > 1) && (GetArrayRank(vertexArrayType) == 1));
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
		public static bool IsArrayMatrixType(ArrayBufferItemType vertexArrayType)
		{
			return (GetArrayRank(vertexArrayType) > 1);
		}

		#endregion

		#region Array Item Size

		/// <summary>
		/// Get the size of a vertex array buffer item.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the size of the vertex array buffer type having the type <paramref name="vertexBaseType"/>, in bytes.
		/// </returns>
		public static uint GetArrayItemSize(VertexBaseType vertexBaseType)
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
				case VertexBaseType.Double:
					return (8);
				default:
					throw new NotSupportedException("base type not supported");
			}
		}

		/// <summary>
		/// Get the size of a vertex array buffer item.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the size of the vertex array buffer type having the type <paramref name="vertexArrayType"/>, in bytes.
		/// </returns>
		public static uint GetArrayItemSize(ArrayBufferItemType vertexArrayType)
		{
			uint baseTypeSize = GetArrayItemSize(GetArrayBaseType(vertexArrayType));
			uint length = GetArrayLength(vertexArrayType);
			uint rank = GetArrayRank(vertexArrayType);

			return (baseTypeSize * length * rank);
		}

		#endregion

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="ArrayBufferItem"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="ArrayBufferItem"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> equals <paramref name="right"/>.
		/// </returns>
		public static bool operator==(ArrayBufferItem left, ArrayBufferItem right)
		{
			if (ReferenceEquals(left, right))
				return (true);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.Equals(right));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="ArrayBufferItem"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="ArrayBufferItem"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> doesn't equals <paramref name="right"/>.
		/// </returns>
		public static bool operator!=(ArrayBufferItem left, ArrayBufferItem right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (!left.Equals(right));
		}

		#endregion

		#region IEquatable<ArrayBufferItem> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ArrayBufferItem other)
		{
			if (ReferenceEquals(null, other))
				return false;
			
			if (BaseType != other.BaseType)
				return (false);
			if (ArrayLength != other.ArrayLength)
				return (false);
			if (Normalized != other.Normalized)
				return (false);

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
				return false;
			if (obj.GetType() != typeof(IVertex3))
				return false;

			return (Equals((ArrayBufferItem)obj));
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
				int result = BaseType.GetHashCode();
				result = (result * 397) ^ ArrayLength.GetHashCode();
				result = (result * 397) ^ Normalized.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}
