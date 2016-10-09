
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

namespace OpenGL
{
	/// <summary>
	/// Class describing a vertex array buffer item.
	/// </summary>
	public class ArrayBufferItem : IEquatable<ArrayBufferItem>
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferItem specifying the vertex base type and the array item length.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> that specify the basic type of the array item.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify the number of components of the array item.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="vertexBaseType"/> is <see cref="VertexBaseType.Undefined"/>.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="vertexLength"/> is outside the valid range (greater than 0,
		/// less than or equal to 4).
		/// </exception>
		public ArrayBufferItem(VertexBaseType vertexBaseType, uint vertexLength) :
			this(vertexBaseType, vertexLength, 1)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferItem specifying the vertex base type and the array item length and rank.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> that specify the basic type of the array item.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify the number of components of the array item.
		/// </param>
		/// <param name="vertexRank">
		/// A <see cref="UInt32"/> that specify the rank of the array item (matrix columns count).
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="vertexLength"/> or <paramref name="vertexRank"/> are outside
		/// the valid range (greater than 0, less than or equal to 4).
		/// </exception>
		public ArrayBufferItem(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank)
		{
			if (vertexLength < 1 || vertexLength > 4)
				throw new ArgumentOutOfRangeException("vertexLength", vertexLength, "must be in [1,4] range");
			if (vertexRank < 1 || vertexRank > 4)
				throw new ArgumentOutOfRangeException("vertexRank", vertexRank, "must be in [1,4] range");

			ArrayType = vertexBaseType.GetArrayBufferType(vertexLength, vertexRank);
		}

		/// <summary>
		/// Construct an ArrayBufferItem from a <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that synthetize all informations about a vertex array buffer item.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="vertexArrayType"/> is <see cref="ArrayBufferItemType.Complex"/>.
		/// </exception>
		public ArrayBufferItem(ArrayBufferItemType vertexArrayType)
		{
			ArrayType = vertexArrayType;
		}

		/// <summary>
		/// Construct an ArrayBufferItem from a <see cref="ArrayBufferItemAttribute"/>.
		/// </summary>
		/// <param name="attribute">
		/// A <see cref="ArrayBufferItemAttribute"/> describing the vertex array buffer item.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="attribute"/> is null.
		/// </exception>
		public ArrayBufferItem(ArrayBufferItemAttribute attribute)
		{
			if (attribute == null)
				throw new ArgumentNullException("attribute");

			ArrayType = attribute.ArrayBaseType.GetArrayBufferType(attribute.ArrayLength, attribute.ArrayRank);
		}

		#endregion

		#region Array Information

		/// <summary>
		/// The vertex array item type.
		/// </summary>
		public readonly ArrayBufferItemType ArrayType;

		/// <summary>
		/// The vertex array item base type.
		/// </summary>
		public VertexBaseType BaseType { get { return (ArrayType.GetVertexBaseType()); } }

		/// <summary>
		/// The number of components of the vertex array buffer item.
		/// </summary>
		public uint ArrayLength { get { return (ArrayType.GetArrayLength()); } }

		/// <summary>
		/// Determine whether the base type is a floating-point value.
		/// </summary>
		public bool IsFloat { get { return (BaseType.IsFloatBaseType()); } }

		#endregion

		#region Array Item Normalization

		/// <summary>
		/// Determine whether the integer values shall be considered normalized floating-point.
		/// </summary>
		public bool Normalized
		{
			get { return (_Normalized); }
			set { _Normalized = value; }
		}

		/// <summary>
		/// Determine whether the integer values shall be considered normalized floating-point.
		/// </summary>
		private bool _Normalized;

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
					return (Gl.CurrentExtensions.HalfFloatVertex_ARB);
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
			return (IsDataSupported(ctx, arrayType.GetVertexBaseType()));
		}

		#endregion

		#region Get Array Type

		/// <summary>
		/// Get the corresponding <see cref="ArrayBufferItemType"/> from a <see cref="ArrayType"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="ArrayType"/> indicating the structure describing the vertex array buffer item.
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

			throw new ArgumentException("not corresponding information", "type");
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

			ArrayBufferItemAttribute attribute = (ArrayBufferItemAttribute)Attribute.GetCustomAttribute(type, typeof(ArrayBufferItemAttribute));
			if (attribute != null)
				return (attribute.ArrayBaseType);

			throw new ArgumentException(String.Format("unable to match type {0}", type.Name));
		}

		/// <summary>
		/// Get the array components base type of the vertex array attribute item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array attribute item type.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static VertexBaseType GetArrayBaseType(ShaderAttributeType shaderAttributeType)
		{
			switch (shaderAttributeType) {
				case ShaderAttributeType.Float:
				case ShaderAttributeType.Vec2:
				case ShaderAttributeType.Vec3:
				case ShaderAttributeType.Vec4:
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat4x4:
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat2x4:
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat3x4:
				case ShaderAttributeType.Mat4x2:
				case ShaderAttributeType.Mat4x3:
					return (VertexBaseType.Float);
				case ShaderAttributeType.Int:
				case ShaderAttributeType.IntVec2:
				case ShaderAttributeType.IntVec3:
				case ShaderAttributeType.IntVec4:
					return (VertexBaseType.Int);
				case ShaderAttributeType.UInt:
				case ShaderAttributeType.UIntVec2:
				case ShaderAttributeType.UIntVec3:
				case ShaderAttributeType.UIntVec4:
					return (VertexBaseType.UInt);
				case ShaderAttributeType.Double:
				case ShaderAttributeType.DoubleVec2:
				case ShaderAttributeType.DoubleVec3:
				case ShaderAttributeType.DoubleVec4:
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat4x4:
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat2x4:
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat3x4:
				case ShaderAttributeType.DoubleMat4x2:
				case ShaderAttributeType.DoubleMat4x3:
					return (VertexBaseType.Double);
				default:
					throw new ArgumentException(String.Format("unrecognized shader attribute type {0}", shaderAttributeType));
			}
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
