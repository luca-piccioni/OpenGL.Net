
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 4)]
	[DebuggerDisplay("Vertex4ub: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ub : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the value of every component.
		/// </param>
		public Vertex4ub(byte v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex4ub(byte[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4ub constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="byte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="byte"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="byte"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="byte"/> that specify the W coordinate.
		/// </param>
		public Vertex4ub(byte x, byte y, byte z, byte w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4ub constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4ub"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4ub(Vertex4ub other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public byte x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public byte y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public byte z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public byte w;

		#endregion

		#region Arithmetic Operators


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4ub operator +(Vertex4ub v1, Vertex4ub v2)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x + v2.x);
			v.y = (byte)(v1.y + v2.y);
			v.z = (byte)(v1.z + v2.z);
			v.w = (byte)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4ub operator -(Vertex4ub v1, Vertex4ub v2)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x - v2.x);
			v.y = (byte)(v1.y - v2.y);
			v.z = (byte)(v1.z - v2.z);
			v.w = (byte)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator *(Vertex4ub v1, float scalar)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);
			v.w = (byte)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator *(Vertex4ub v1, double scalar)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);
			v.w = (byte)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator /(Vertex4ub v1, float scalar)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);
			v.w = (byte)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator /(Vertex4ub v1, double scalar)
		{
			Vertex4ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);
			v.w = (byte)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4ub v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4ub v1, Vertex4ub v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4ub v1, Vertex4ub v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="byte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator byte[](Vertex4ub a)
		{
			byte[] v = new byte[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3ub(Vertex4ub v)
		{
			return (new Vertex3ub(
				(byte)((float)v.x / (float)v.w),
				(byte)((float)v.y / (float)v.w),
				(byte)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4ub v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4ub v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3ub)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3ub v = ((Vertex3ub)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (byte)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4ub Normalized
		{
			get
			{
				Vertex4ub normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4ub Zero = new Vertex4ub(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4ub One = new Vertex4ub(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4ub UnitX = new Vertex4ub(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4ub UnitY = new Vertex4ub(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4ub UnitZ = new Vertex4ub(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [0.0, 1.0].
		/// </summary>
		public float W
		{
			get { return ((float)w / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				w = (byte)(value * (float)byte.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4ub.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4ub.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (sbyte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 4)]
	[DebuggerDisplay("Vertex4b: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4b : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the value of every component.
		/// </param>
		public Vertex4b(sbyte v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex4b(sbyte[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4b constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="sbyte"/> that specify the W coordinate.
		/// </param>
		public Vertex4b(sbyte x, sbyte y, sbyte z, sbyte w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4b constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4b"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4b(Vertex4b other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public sbyte x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public sbyte y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public sbyte z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public sbyte w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4b operator -(Vertex4b v)
		{
			return (new Vertex4b((sbyte)(-v.x), (sbyte)(-v.y), (sbyte)(-v.z), (sbyte)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4b operator +(Vertex4b v1, Vertex4b v2)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x + v2.x);
			v.y = (sbyte)(v1.y + v2.y);
			v.z = (sbyte)(v1.z + v2.z);
			v.w = (sbyte)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4b operator -(Vertex4b v1, Vertex4b v2)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x - v2.x);
			v.y = (sbyte)(v1.y - v2.y);
			v.z = (sbyte)(v1.z - v2.z);
			v.w = (sbyte)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator *(Vertex4b v1, float scalar)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);
			v.w = (sbyte)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator *(Vertex4b v1, double scalar)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);
			v.w = (sbyte)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator /(Vertex4b v1, float scalar)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);
			v.w = (sbyte)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator /(Vertex4b v1, double scalar)
		{
			Vertex4b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);
			v.w = (sbyte)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4b v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4b v1, Vertex4b v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4b v1, Vertex4b v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to sbyte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator sbyte[](Vertex4b a)
		{
			sbyte[] v = new sbyte[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3b operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3b(Vertex4b v)
		{
			return (new Vertex3b(
				(sbyte)((float)v.x / (float)v.w),
				(sbyte)((float)v.y / (float)v.w),
				(sbyte)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4b v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4b v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3b)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3b v = ((Vertex3b)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (sbyte)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4b Normalized
		{
			get
			{
				Vertex4b normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4b Zero = new Vertex4b(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4b One = new Vertex4b(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4b UnitX = new Vertex4b(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4b UnitY = new Vertex4b(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4b UnitZ = new Vertex4b(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float W
		{
			get { return ((float)(w - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				w = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4b.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4b.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (ushort coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 4)]
	[DebuggerDisplay("Vertex4us: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4us : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the value of every component.
		/// </param>
		public Vertex4us(ushort v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex4us(ushort[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4us constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="ushort"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="ushort"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="ushort"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="ushort"/> that specify the W coordinate.
		/// </param>
		public Vertex4us(ushort x, ushort y, ushort z, ushort w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4us constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4us"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4us(Vertex4us other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public ushort y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public ushort z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public ushort w;

		#endregion

		#region Arithmetic Operators


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4us operator +(Vertex4us v1, Vertex4us v2)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x + v2.x);
			v.y = (ushort)(v1.y + v2.y);
			v.z = (ushort)(v1.z + v2.z);
			v.w = (ushort)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4us operator -(Vertex4us v1, Vertex4us v2)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x - v2.x);
			v.y = (ushort)(v1.y - v2.y);
			v.z = (ushort)(v1.z - v2.z);
			v.w = (ushort)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator *(Vertex4us v1, float scalar)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);
			v.w = (ushort)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator *(Vertex4us v1, double scalar)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);
			v.w = (ushort)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator /(Vertex4us v1, float scalar)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);
			v.w = (ushort)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator /(Vertex4us v1, double scalar)
		{
			Vertex4us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);
			v.w = (ushort)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4us v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4us v1, Vertex4us v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4us v1, Vertex4us v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ushort[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator ushort[](Vertex4us a)
		{
			ushort[] v = new ushort[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3us(Vertex4us v)
		{
			return (new Vertex3us(
				(ushort)((float)v.x / (float)v.w),
				(ushort)((float)v.y / (float)v.w),
				(ushort)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4us v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4us v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3us)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3us v = ((Vertex3us)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (ushort)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4us Normalized
		{
			get
			{
				Vertex4us normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4us Zero = new Vertex4us(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4us One = new Vertex4us(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4us UnitX = new Vertex4us(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4us UnitY = new Vertex4us(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4us UnitZ = new Vertex4us(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [0.0, 1.0].
		/// </summary>
		public float W
		{
			get { return ((float)w / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				w = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4us.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4us.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 4)]
	[DebuggerDisplay("Vertex4s: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4s : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the value of every component.
		/// </param>
		public Vertex4s(short v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short[]"/> that specify the value of every component.
		/// </param>
		public Vertex4s(short[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4s constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="short"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="short"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="short"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="short"/> that specify the W coordinate.
		/// </param>
		public Vertex4s(short x, short y, short z, short w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4s constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4s"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4s(Vertex4s other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public short y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public short z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public short w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4s operator -(Vertex4s v)
		{
			return (new Vertex4s((short)(-v.x), (short)(-v.y), (short)(-v.z), (short)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4s operator +(Vertex4s v1, Vertex4s v2)
		{
			Vertex4s v;

			v.x = (short)(v1.x + v2.x);
			v.y = (short)(v1.y + v2.y);
			v.z = (short)(v1.z + v2.z);
			v.w = (short)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4s operator -(Vertex4s v1, Vertex4s v2)
		{
			Vertex4s v;

			v.x = (short)(v1.x - v2.x);
			v.y = (short)(v1.y - v2.y);
			v.z = (short)(v1.z - v2.z);
			v.w = (short)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator *(Vertex4s v1, float scalar)
		{
			Vertex4s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);
			v.w = (short)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator *(Vertex4s v1, double scalar)
		{
			Vertex4s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);
			v.w = (short)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator /(Vertex4s v1, float scalar)
		{
			Vertex4s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);
			v.w = (short)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator /(Vertex4s v1, double scalar)
		{
			Vertex4s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);
			v.w = (short)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4s v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4s v1, Vertex4s v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4s v1, Vertex4s v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to short[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="short[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator short[](Vertex4s a)
		{
			short[] v = new short[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3s operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3s(Vertex4s v)
		{
			return (new Vertex3s(
				(short)((float)v.x / (float)v.w),
				(short)((float)v.y / (float)v.w),
				(short)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4s v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4s v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3s)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3s v = ((Vertex3s)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (short)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4s Normalized
		{
			get
			{
				Vertex4s normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4s Zero = new Vertex4s(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4s One = new Vertex4s(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4s UnitX = new Vertex4s(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4s UnitY = new Vertex4s(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4s UnitZ = new Vertex4s(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float W
		{
			get { return ((float)(w - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				w = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4s.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4s.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (uint coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 4)]
	[DebuggerDisplay("Vertex4ui: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ui : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the value of every component.
		/// </param>
		public Vertex4ui(uint v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex4ui(uint[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4ui constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="uint"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="uint"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="uint"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="uint"/> that specify the W coordinate.
		/// </param>
		public Vertex4ui(uint x, uint y, uint z, uint w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4ui constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4ui"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4ui(Vertex4ui other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public uint y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public uint z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public uint w;

		#endregion

		#region Arithmetic Operators


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4ui operator +(Vertex4ui v1, Vertex4ui v2)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x + v2.x);
			v.y = (uint)(v1.y + v2.y);
			v.z = (uint)(v1.z + v2.z);
			v.w = (uint)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4ui operator -(Vertex4ui v1, Vertex4ui v2)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x - v2.x);
			v.y = (uint)(v1.y - v2.y);
			v.z = (uint)(v1.z - v2.z);
			v.w = (uint)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator *(Vertex4ui v1, float scalar)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);
			v.w = (uint)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator *(Vertex4ui v1, double scalar)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);
			v.w = (uint)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator /(Vertex4ui v1, float scalar)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);
			v.w = (uint)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator /(Vertex4ui v1, double scalar)
		{
			Vertex4ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);
			v.w = (uint)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4ui v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4ui v1, Vertex4ui v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4ui v1, Vertex4ui v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="uint[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator uint[](Vertex4ui a)
		{
			uint[] v = new uint[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ui operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3ui(Vertex4ui v)
		{
			return (new Vertex3ui(
				(uint)((float)v.x / (float)v.w),
				(uint)((float)v.y / (float)v.w),
				(uint)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4ui v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4ui v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3ui)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3ui v = ((Vertex3ui)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (uint)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4ui Normalized
		{
			get
			{
				Vertex4ui normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4ui Zero = new Vertex4ui(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4ui One = new Vertex4ui(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4ui UnitX = new Vertex4ui(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4ui UnitY = new Vertex4ui(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4ui UnitZ = new Vertex4ui(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [0.0, 1.0].
		/// </summary>
		public float W
		{
			get { return ((float)w / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				w = (uint)(value * (float)uint.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4ui.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4ui.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (int coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 4)]
	[DebuggerDisplay("Vertex4i: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4i : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the value of every component.
		/// </param>
		public Vertex4i(int v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int[]"/> that specify the value of every component.
		/// </param>
		public Vertex4i(int[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="int"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="int"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="int"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="int"/> that specify the W coordinate.
		/// </param>
		public Vertex4i(int x, int y, int z, int w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4i constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4i"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4i(Vertex4i other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public int y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public int z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public int w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4i operator -(Vertex4i v)
		{
			return (new Vertex4i((int)(-v.x), (int)(-v.y), (int)(-v.z), (int)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4i operator +(Vertex4i v1, Vertex4i v2)
		{
			Vertex4i v;

			v.x = (int)(v1.x + v2.x);
			v.y = (int)(v1.y + v2.y);
			v.z = (int)(v1.z + v2.z);
			v.w = (int)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4i operator -(Vertex4i v1, Vertex4i v2)
		{
			Vertex4i v;

			v.x = (int)(v1.x - v2.x);
			v.y = (int)(v1.y - v2.y);
			v.z = (int)(v1.z - v2.z);
			v.w = (int)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator *(Vertex4i v1, float scalar)
		{
			Vertex4i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);
			v.w = (int)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator *(Vertex4i v1, double scalar)
		{
			Vertex4i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);
			v.w = (int)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator /(Vertex4i v1, float scalar)
		{
			Vertex4i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);
			v.w = (int)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator /(Vertex4i v1, double scalar)
		{
			Vertex4i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);
			v.w = (int)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4i v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4i v1, Vertex4i v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4i v1, Vertex4i v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to int[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="int[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator int[](Vertex4i a)
		{
			int[] v = new int[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3i operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3i(Vertex4i v)
		{
			return (new Vertex3i(
				(int)((float)v.x / (float)v.w),
				(int)((float)v.y / (float)v.w),
				(int)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4i v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4i v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3i)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3i v = ((Vertex3i)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (int)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4i Normalized
		{
			get
			{
				Vertex4i normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4i Zero = new Vertex4i(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4i One = new Vertex4i(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4i UnitX = new Vertex4i(1, 0, 0, 1);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4i UnitY = new Vertex4i(0, 1, 0, 1);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4i UnitZ = new Vertex4i(0, 0, 1, 1);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate W, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float W
		{
			get { return ((float)(w - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				w = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4i.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4i.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 4)]
	[DebuggerDisplay("Vertex4f: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4f : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the value of every component.
		/// </param>
		public Vertex4f(float v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float[]"/> that specify the value of every component.
		/// </param>
		public Vertex4f(float[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="float"/> that specify the W coordinate.
		/// </param>
		public Vertex4f(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4f"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4f(Vertex4f other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public float x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public float y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public float z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public float w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4f operator -(Vertex4f v)
		{
			return (new Vertex4f((float)(-v.x), (float)(-v.y), (float)(-v.z), (float)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4f operator +(Vertex4f v1, Vertex4f v2)
		{
			Vertex4f v;

			v.x = (float)(v1.x + v2.x);
			v.y = (float)(v1.y + v2.y);
			v.z = (float)(v1.z + v2.z);
			v.w = (float)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4f operator -(Vertex4f v1, Vertex4f v2)
		{
			Vertex4f v;

			v.x = (float)(v1.x - v2.x);
			v.y = (float)(v1.y - v2.y);
			v.z = (float)(v1.z - v2.z);
			v.w = (float)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v1, float scalar)
		{
			Vertex4f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);
			v.w = (float)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v1, double scalar)
		{
			Vertex4f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);
			v.w = (float)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator /(Vertex4f v1, float scalar)
		{
			Vertex4f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);
			v.w = (float)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator /(Vertex4f v1, double scalar)
		{
			Vertex4f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);
			v.w = (float)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4f v1, Vertex4f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4f v1, Vertex4f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="float[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator float[](Vertex4f a)
		{
			float[] v = new float[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4f v)
		{
			return (new Vertex3f(
				(float)((float)v.x / (float)v.w),
				(float)((float)v.y / (float)v.w),
				(float)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4f v)
		{
			Vertex3f v3 = (Vertex3f)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4f v)
		{
			Vertex3f v3 = (Vertex3f)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4f v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3f)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3f v = ((Vertex3f)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (float)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4f Normalized
		{
			get
			{
				Vertex4f normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4f Zero = new Vertex4f(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4f One = new Vertex4f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4f UnitX = new Vertex4f(1.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4f UnitY = new Vertex4f(0.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4f UnitZ = new Vertex4f(0.0f, 0.0f, 1.0f, 1.0f);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate W, unclamped range.
		/// </summary>
		public float W
		{
			get { return ((float)w); }
			set { w = (float)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}, {3:F4}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 4)]
	[DebuggerDisplay("Vertex4d: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4d : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the value of every component.
		/// </param>
		public Vertex4d(double v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double[]"/> that specify the value of every component.
		/// </param>
		public Vertex4d(double[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="double"/> that specify the W coordinate.
		/// </param>
		public Vertex4d(double x, double y, double z, double w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4d"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4d(Vertex4d other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public double x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public double y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public double z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public double w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4d to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4d operator -(Vertex4d v)
		{
			return (new Vertex4d((double)(-v.x), (double)(-v.y), (double)(-v.z), (double)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4d operator +(Vertex4d v1, Vertex4d v2)
		{
			Vertex4d v;

			v.x = (double)(v1.x + v2.x);
			v.y = (double)(v1.y + v2.y);
			v.z = (double)(v1.z + v2.z);
			v.w = (double)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4d operator -(Vertex4d v1, Vertex4d v2)
		{
			Vertex4d v;

			v.x = (double)(v1.x - v2.x);
			v.y = (double)(v1.y - v2.y);
			v.z = (double)(v1.z - v2.z);
			v.w = (double)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator *(Vertex4d v1, float scalar)
		{
			Vertex4d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);
			v.w = (double)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator *(Vertex4d v1, double scalar)
		{
			Vertex4d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);
			v.w = (double)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator /(Vertex4d v1, float scalar)
		{
			Vertex4d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);
			v.w = (double)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator /(Vertex4d v1, double scalar)
		{
			Vertex4d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);
			v.w = (double)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4d v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4d v1, Vertex4d v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4d v1, Vertex4d v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex4d a)
		{
			double[] v = new double[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4d v)
		{
			return (new Vertex3d(v.x / v.w, v.y / v.w, v.z / v.w));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4d v)
		{
			Vertex3d v3 = (Vertex3d)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4d v)
		{
			Vertex3d v3 = (Vertex3d)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4d v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3d)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3d v = ((Vertex3d)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (double)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4d Normalized
		{
			get
			{
				Vertex4d normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4d Zero = new Vertex4d(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4d One = new Vertex4d(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4d UnitX = new Vertex4d(1.0, 0.0, 0.0, 1.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4d UnitY = new Vertex4d(0.0, 1.0, 0.0, 1.0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4d UnitZ = new Vertex4d(0.0, 0.0, 1.0, 1.0);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate W, unclamped range.
		/// </summary>
		public float W
		{
			get { return ((float)w); }
			set { w = (double)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4d.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}, {3:F4}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (HalfFloat coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 4)]
	[DebuggerDisplay("Vertex4hf: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4hf : IVertex4, IEquatable<IVertex4>
	{
		#region Constructors

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex4hf(HalfFloat v) : this(v, v, v, v) { }

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex4hf(HalfFloat[] v) : this(v[0], v[1], v[2], v[3]) { }

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="HalfFloat"/> that specify the Z coordinate.
		/// </param>
		/// <param name="w">
		/// A <see cref="HalfFloat"/> that specify the W coordinate.
		/// </param>
		public Vertex4hf(HalfFloat x, HalfFloat y, HalfFloat z, HalfFloat w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex4hf"/> that specify the vertex to be copied.
		/// </param>
		public Vertex4hf(Vertex4hf other) : this(other.x, other.y, other.z, other.w) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat z;

		/// <summary>
		/// W coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex4hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4hf operator -(Vertex4hf v)
		{
			return (new Vertex4hf((HalfFloat)(-v.x), (HalfFloat)(-v.y), (HalfFloat)(-v.z), (HalfFloat)(-v.w)));
		}


		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4hf operator +(Vertex4hf v1, Vertex4hf v2)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);
			v.z = (HalfFloat)(v1.z + v2.z);
			v.w = (HalfFloat)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex4hf operator -(Vertex4hf v1, Vertex4hf v2)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);
			v.z = (HalfFloat)(v1.z - v2.z);
			v.w = (HalfFloat)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v1, float scalar)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);
			v.z = (HalfFloat)(v1.z * scalar);
			v.w = (HalfFloat)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v1, double scalar)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);
			v.z = (HalfFloat)(v1.z * scalar);
			v.w = (HalfFloat)(v1.w * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator /(Vertex4hf v1, float scalar)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);
			v.z = (HalfFloat)(v1.z / scalar);
			v.w = (HalfFloat)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator /(Vertex4hf v1, double scalar)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);
			v.z = (HalfFloat)(v1.z / scalar);
			v.w = (HalfFloat)(v1.w / scalar);

			return (v);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4hf v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + (v.w * m[3, 0]));
			r.y = (float)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + (v.w * m[3, 1]));
			r.z = (float)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + (v.w * m[3, 2]));
			r.w = (float)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + (v.w * m[3, 3]));

			return (r);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex4hf v1, Vertex4hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex4hf v1, Vertex4hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator HalfFloat[](Vertex4hf a)
		{
			HalfFloat[] v = new HalfFloat[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3hf(Vertex4hf v)
		{
			return (new Vertex3hf(
				(HalfFloat)((float)v.x / (float)v.w),
				(HalfFloat)((float)v.y / (float)v.w),
				(HalfFloat)((float)v.z / (float)v.w)
			));
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return (new Vertex2f(v3.X, v3.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return (new Vertex3f(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4hf v)
		{
			return (new Vertex4f(v.X, v.Y, v.X, v.W));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return (new Vertex3d(v3.X, v3.Y, v3.Z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4hf v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, v.W));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module() { return (((Vertex3hf)this).Module()); }

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			Vertex3hf v = ((Vertex3hf)this).Normalized;
			x = v.x;
			y = v.y;
			z = v.z;
			w = (HalfFloat)1;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4hf Normalized
		{
			get
			{
				Vertex4hf normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		
		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate W, unclamped range.
		/// </summary>
		public float W
		{
			get { return ((float)w); }
			set { w = (HalfFloat)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					case 3: return (W);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					case 3: W = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex4> Implementation

		/// <summary>
		/// Indicates whether the this IVertex4 is equal to another IVertex4.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex4 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);
			if (Math.Abs(W - other.W) >= Epsilon)
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
				return (false);
			if (obj.GetType().GetInterface("IVertex4") == null)
				return (false);

			return (Equals((IVertex3)obj));
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
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();
				result = (result * 397) ^ w.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex4hf.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex4hf.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}, {3:F4}|", x, y, z, w));
		}

		#endregion
	}

}