
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Vertex defined as reference type (single-precision implementation).
	/// </summary>
	[DebuggerDisplay("Vertex3: X={x} Y={y} Z={z}")]
	public class Vertex3 : ICopiable<Vertex3>
	{
		#region Constructors
		
		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		public Vertex3()
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex3(float v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3(float[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3(Vertex3f other)
			: this(other.x, other.y, other.z)
		{

		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3(Vertex3 other)
			: this(other.X, other.Y, other.X)
		{

		}

		#endregion

		#region Vector Components

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X;

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y;

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator float[](Vertex3 a)
		{
			float[] v = new float[3];

			v[0] = a.X;
			v[1] = a.Y;
			v[2] = a.Z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex3 a)
		{
			Vertex3f v = new Vertex3f();

			v.x = a.X;
			v.y = a.Y;
			v.z = a.Z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex3d(Vertex3 a)
		{
			Vertex3d v = new Vertex3d();

			v.x = a.X;
			v.y = a.Y;
			v.z = a.Z;

			return (v);
		}
		
		/// <summary>
		/// Cast to VertexDouble3 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/>
		/// </param>
		/// <returns>
		/// A <see cref="VertexDouble3"/>
		/// </returns>
		public static implicit operator VertexDouble3(Vertex3 a)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = a.X;
			v.y = a.Y;
			v.z = a.Z;

			return (v);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3 Zero = new Vertex3(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3 One = new Vertex3(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3 UnitX = new Vertex3(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3 UnitY = new Vertex3(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3 UnitZ = new Vertex3(0.0f, 0.0f, 1.0f);

		#endregion

		#region ICopiable<Vertex3> Implementation

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see name="Vertex3"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(Vertex3 other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			X = other.X;
			Y = other.Y;
			Z = other.Z;
		}

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Object"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(object other)
		{
			if (other is Vertex3)
				Copy(other as Vertex3);					// Copoy reference type
			else if (other is Vertex3f)
				Copy(new Vertex3((Vertex3f)other));		// Copy corresponding value type, for animation system
			else
				throw new ArgumentException("not supported object", "other");
		}

		#endregion
	}

	/// <summary>
	/// Vertex defined as reference type (double-precision implementation).
	/// </summary>
	[DebuggerDisplay("VertexDouble3: X={x} Y={y} Z={z}")]
	public class VertexDouble3 : ICopiable<VertexDouble3>
	{
		#region Constructors
		
		/// <summary>
		/// Construct a VertexDouble3.
		/// </summary>
		public VertexDouble3()
		{

		}

		/// <summary>
		/// Construct a VertexDouble3.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Double"/> that specify the value of every component.
		/// </param>
		public VertexDouble3(double v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3 constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Double"/>
		/// </param>
		public VertexDouble3(double[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Construct a VertexDouble3.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/>
		/// </param>
		public VertexDouble3(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Construct a VertexDouble3.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3d"/>
		/// </param>
		public VertexDouble3(Vertex3d other)
			: this(other.x, other.y, other.z)
		{

		}

		/// <summary>
		/// Construct a VertexDouble3.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public VertexDouble3(VertexDouble3 other)
			: this(other.x, other.y, other.z)
		{

		}

		#endregion

		#region Vector Components

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public double x;

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public double y;

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public double z;

		#endregion
		
		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static VertexDouble3 operator -(VertexDouble3 v1)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = -v1.x;
			v.y = -v1.y;
			v.z = -v1.z;

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <returns>
		/// A <see cref="VertexDouble3"/>
		/// </returns>
		public static VertexDouble3 operator +(VertexDouble3 v1, VertexDouble3 v2)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = v1.x + v2.x;
			v.y = v1.y + v2.y;
			v.z = v1.z + v2.z;

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <returns>
		/// A <see cref="VertexDouble3"/>
		/// </returns>
		public static VertexDouble3 operator -(VertexDouble3 v1, VertexDouble3 v2)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = v1.x - v2.x;
			v.y = v1.y - v2.y;
			v.z = v1.z - v2.z;

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static VertexDouble3 operator *(VertexDouble3 v1, float scalar)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = v1.x * scalar;
			v.y = v1.y * scalar;
			v.z = v1.z * scalar;

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static VertexDouble3 operator /(VertexDouble3 v1, float scalar)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = v1.x / scalar;
			v.y = v1.y / scalar;
			v.z = v1.z / scalar;

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="VertexDouble3"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="VertexDouble3"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Double"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static double operator *(VertexDouble3 v1, VertexDouble3 v2)
		{
			return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static VertexDouble3 operator ^(VertexDouble3 v1, VertexDouble3 v2)
		{
			VertexDouble3 v = new VertexDouble3();

			v.x = v1.y * v2.z - v1.z * v2.y;
			v.y = v1.z * v2.x - v1.x * v2.z;
			v.z = v1.x * v2.y - v1.y * v2.x;

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="VertexDouble3"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexDouble3"/> which represents the transformed vertex.
		/// </returns>
		public static VertexDouble3 operator *(VertexDouble3 v, MatrixDouble4x4 m)
		{
			VertexDouble3 r = new VertexDouble3();

			r.x = (v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3];
			r.y = (v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3];
			r.z = (v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3];

			return (r);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator double[](VertexDouble3 a)
		{
			double[] v = new double[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static explicit operator Vertex3f(VertexDouble3 a)
		{
			Vertex3f v = new Vertex3f();

			v.x = (float)a.x;
			v.y = (float)a.y;
			v.z = (float)a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex3d(VertexDouble3 a)
		{
			Vertex3d v = new Vertex3d();

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;

			return (v);
		}
		
		/// <summary>
		/// Cast to Vertex3 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="VertexDouble3"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3"/>
		/// </returns>
		public static explicit operator Vertex3(VertexDouble3 a)
		{
			Vertex3 v = new Vertex3();

			v.X = (float)a.x;
			v.Y = (float)a.y;
			v.Z = (float)a.z;

			return (v);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly VertexDouble3 Zero = new VertexDouble3(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly VertexDouble3 One = new VertexDouble3(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly VertexDouble3 UnitX = new VertexDouble3(1.0, 0.0, 0.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly VertexDouble3 UnitY = new VertexDouble3(0.0, 1.0, 0.0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly VertexDouble3 UnitZ = new VertexDouble3(0.0, 0.0, 1.0);

		#endregion
		
		#region ICopiable<VertexDouble3> Implementation

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see name="VertexDouble3"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(VertexDouble3 other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			this.x = other.x;
			this.y = other.y;
			this.z = other.z;
		}

		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Object"/> that specify the object from where the information is copied.
		/// </param>
		public void Copy(object other)
		{
			if (other is VertexDouble3)
				Copy(other as VertexDouble3);				// Copoy reference type
			else if (other is Vertex3d)
				Copy(new VertexDouble3((Vertex3d)other));	// Copy corresponding value type, for animation system
			else
				throw new ArgumentException("not supported object", "other");
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 3)]
	[DebuggerDisplay("Vertex3b: X={x} Y={y} Z={z}")]
	public struct Vertex3b : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="SByte"/> that specify the value of every component.
		/// </param>
		public Vertex3b(SByte v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="SByte"/>
		/// </param>
		public Vertex3b(SByte[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="SByte"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="SByte"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="SByte"/>
		/// </param>
		public Vertex3b(SByte x, SByte y, SByte z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3b"/>
		/// </param>
		public Vertex3b(Vertex3b other)
			: this(other.x, other.y, other.z)
		{

		}

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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3b v1, Vertex3b v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3b v1, Vertex3b v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((sbyte)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = (sbyte)value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((sbyte)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3b.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3b.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (unsigned byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 3)]
	[DebuggerDisplay("Vertex3ub: X={x} Y={y} Z={z}")]
	public struct Vertex3ub : IVertex3, IEquatable<IVertex3>
	{
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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3ub v1, Vertex3ub v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3ub v1, Vertex3ub v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((byte)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = (byte)value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((byte)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3ub.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3ub.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 3)]
	[DebuggerDisplay("Vertex3s: X={x} Y={y} Z={z}")]
	public struct Vertex3s : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Int16"/> that specify the value of every component.
		/// </param>
		public Vertex3s(Int16 v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Int16"/>
		/// </param>
		public Vertex3s(Int16[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Int16"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Int16"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Int16"/>
		/// </param>
		public Vertex3s(Int16 x, Int16 y, Int16 z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3s(Vertex3s other)
			: this(other.x, other.y, other.z)
		{

		}

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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3s v1, Vertex3s v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3s v1, Vertex3s v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to Vertex3i operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/>
		/// </returns>
		public static explicit operator Vertex3i(Vertex3s a)
		{
			Vertex3i v;

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;

			return (v);
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((short)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((short)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((short)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3s.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3s.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (unsigned short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 3)]
	[DebuggerDisplay("Vertex3us: X={x} Y={y} Z={z}")]
	public struct Vertex3us : IVertex3, IEquatable<IVertex3>
	{
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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3us v1, Vertex3us v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3us v1, Vertex3us v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((ushort)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((ushort)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((ushort)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 3)]
	[DebuggerDisplay("Vertex3i: X={x} Y={y} Z={z}")]
	public struct Vertex3i : IVertex3, IColorInteger3<int>, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Int32"/>
		/// </param>
		public Vertex3i(int[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Int32"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/>
		/// </param>
		public Vertex3i(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3i v1, Vertex3i v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3i v1, Vertex3i v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((int)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((int)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((int)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger3<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.Integer3); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		int IColorInteger3<int>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		int IColorInteger3<int>.Y { get { return (y); } }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		int IColorInteger3<int>.Z { get { return (z); } }

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (unsigned integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 3)]
	[DebuggerDisplay("Vertex3ui: X={x} Y={y} Z={z}")]
	public struct Vertex3ui : IVertex3, IColorInteger3<uint>, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="UInt32"/>
		/// </param>
		public Vertex3ui(uint[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="UInt32"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/>
		/// </param>
		public Vertex3ui(uint x, uint y, uint z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

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

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3ui v1, Vertex3ui v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3ui v1, Vertex3ui v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((uint)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((uint)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((uint)value); }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger3<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.UInteger3); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		uint IColorInteger3<uint>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		uint IColorInteger3<uint>.Y { get { return (y); } }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		uint IColorInteger3<uint>.Z { get { return (z); } }

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 3)]
	[DebuggerDisplay("Vertex3f: X={x} Y={y} Z={z}")]
	public struct Vertex3f : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex3f(float v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3f(float[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3f(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3f(Vertex3f other)
			: this(other.x, other.y, other.z)
		{

		}

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

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex3f operator -(Vertex3f v1)
		{
			Vertex3f v;

			v.x = -v1.x;
			v.y = -v1.y;
			v.z = -v1.z;

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3f operator +(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = v1.x + v2.x;
			v.y = v1.y + v2.y;
			v.z = v1.z + v2.z;

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3f operator -(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = v1.x - v2.x;
			v.y = v1.y - v2.y;
			v.z = v1.z - v2.z;

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3f operator *(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = v1.x * scalar;
			v.y = v1.y * scalar;
			v.z = v1.z * scalar;

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex3f operator /(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = v1.x / scalar;
			v.y = v1.y / scalar;
			v.z = v1.z / scalar;

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3f v1, Vertex3f v2)
		{
			return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = v1.y * v2.z - v1.z * v2.y;
			v.y = v1.z * v2.x - v1.x * v2.z;
			v.z = v1.x * v2.y - v1.y * v2.x;

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3];
			r.y = (v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3];
			r.z = (v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3];

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
		public static bool operator ==(Vertex3f v1, Vertex3f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3f v1, Vertex3f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator float[](Vertex3f a)
		{
			float[] v = new float[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex2f(Vertex3f a)
		{
			Vertex2f v;

			v.x = a.x;
			v.y = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static implicit operator Vertex4f(Vertex3f a)
		{
			Vertex4f v;

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;
			v.w = 1.0f;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static implicit operator Vertex3d(Vertex3f a)
		{
			return (new Vertex3d(a.x, a.y, a.z));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static implicit operator Vertex4d(Vertex3f a)
		{
			return (new Vertex4d(a.x, a.y, a.z, 1.0));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator ColorRGBAF(Vertex3f a)
		{
			return (new ColorRGBAF(a.x, a.y, a.z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute bidimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (x * x);
			float y2 = (y * y);
			float z2 = (z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				return;
				//throw new DivideByZeroException("zero length normalization");

			this /= Module();
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3f Normalized
		{
			get
			{
				Vertex3f normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3f Zero = new Vertex3f(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3f One = new Vertex3f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3f UnitX = new Vertex3f(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3f UnitY = new Vertex3f(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3f UnitZ = new Vertex3f(0.0f, 0.0f, 1.0f);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = value; }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= 1e-6f)
				return (false);
			if (Math.Abs(Y - other.Y) >= 1e-6f)
				return (false);
			if (Math.Abs(Z - other.Z) >= 1e-6f)
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
			if (obj.GetType().GetInterface("IVertex") == null)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 3)]
	[DebuggerDisplay("Vertex3d: X={x} Y={y} Z={z}")]
	public struct Vertex3d : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Double"/>
		/// </param>
		public Vertex3d(double[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3d(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3d"/>
		/// </param>
		public Vertex3d(Vertex3d other)
		{
			x = other.x;
			y = other.y;
			z = other.z;
		}

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

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex3d operator -(Vertex3d v1)
		{
			Vertex3d v;

			v.x = -v1.x;
			v.y = -v1.y;
			v.z = -v1.z;

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3d operator +(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = v1.x + v2.x;
			v.y = v1.y + v2.y;
			v.z = v1.z + v2.z;

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3d operator -(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = v1.x - v2.x;
			v.y = v1.y - v2.y;
			v.z = v1.z - v2.z;

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3d operator *(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = v1.x * scalar;
			v.y = v1.y * scalar;
			v.z = v1.z * scalar;

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex3d operator /(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = v1.x / scalar;
			v.y = v1.y / scalar;
			v.z = v1.z / scalar;

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static double operator *(Vertex3d v1, Vertex3d v2)
		{
			return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3d operator ^(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = v1.y * v2.z - v1.z * v2.y;
			v.y = v1.z * v2.x - v1.x * v2.z;
			v.z = v1.x * v2.y - v1.y * v2.x;

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3d operator *(Vertex3d v, Matrix4x4 m)
		{
			Vertex3d r;

			r.x = (v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + m[3, 0];
			r.y = (v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + m[3, 1];
			r.z = (v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + m[3, 2];

			return (r);
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static Vertex3d operator %(Vertex3d v1, Vertex3d v2)
		{
			return (new Vertex3d(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z));
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static Vertex3d operator %(Vertex3d v1, double scalar)
		{
			return (new Vertex3d(v1.x % scalar, v1.y % scalar, v1.z % scalar));
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3d v1, Vertex3d v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3d v1, Vertex3d v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex3d a)
		{
			Vertex3f v;

			v.x = (float)a.x;
			v.y = (float)a.y;
			v.z = (float)a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static implicit operator Vertex4d(Vertex3d a)
		{
			Vertex4d v;

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;
			v.w = 1.0;

			return (v);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute absolute vertex.
		/// </summary>
		/// <returns>
		/// It returns the vertex absolute.
		/// </returns>
		public Vertex3d Abs()
		{
			return (new Vertex3d(Math.Abs(x), Math.Abs(y), Math.Abs(z)));
		}

		/// <summary>
		/// Compute vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex module.
		/// </returns>
		public double Module()
		{
			double x2 = (x * x);
			double y2 = (y * y);
			double z2 = (z * z);

			return (Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			this /= Module();
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3d Normalized
		{
			get
			{
				Vertex3d normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3d Zero = new Vertex3d(0.0, 0.0, 0.0);

		/// <summary>
		/// Unit vertex.
		/// </summary>
		public static readonly Vertex3d One = new Vertex3d(1.0, 1.0, 1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3d UnitX = new Vertex3d(1.0, 0.0, 0.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3d UnitY = new Vertex3d(0.0, 1.0, 0.0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3d UnitZ = new Vertex3d(0.0, 0.0, 1.0);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = value; }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Single.Epsilon)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3d.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Tridimensional vertex value type (half-float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 3)]
	[DebuggerDisplay("Vertex3hf: X={x} Y={y} Z={z}")]
	public struct Vertex3hf : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(HalfFloat v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(float v)
			: this(v, v, v)
		{

		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// An array of <see cref="HalfFloat"/>
		/// </param>
		public Vertex3hf(HalfFloat[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3hf(float[] v)
			: this(v[0], v[1], v[2])
		{

		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="HalfFloat"/>
		/// </param>
		public Vertex3hf(HalfFloat x, HalfFloat y, HalfFloat z)
			: this((float)x, (float)y, (float)z)
		{

		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex3hf(float x, float y, float z)
		{
			this.x = (HalfFloat)x;
			this.y = (HalfFloat)y;
			this.z = (HalfFloat)z;
		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/>
		/// </param>
		public Vertex3hf(Vertex3hf other)
			: this(other.x, other.y, other.z)
		{

		}

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

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex3hf operator -(Vertex3hf v1)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(-v1.x);
			v.y = (HalfFloat)(-v1.y);
			v.z = (HalfFloat)(-v1.z);

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/>
		/// </returns>
		public static Vertex3hf operator +(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);
			v.z = (HalfFloat)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/>
		/// </returns>
		public static Vertex3hf operator -(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);
			v.z = (HalfFloat)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static Vertex3hf operator *(Vertex3hf v1, float scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);
			v.z = (HalfFloat)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/>
		/// </returns>
		public static Vertex3hf operator /(Vertex3hf v1, float scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);
			v.z = (HalfFloat)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3hf v1, Vertex3hf v2)
		{
			return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3f v;

			v.x = v1.y * v2.z - v1.z * v2.y;
			v.y = v1.z * v2.x - v1.x * v2.z;
			v.z = v1.x * v2.y - v1.y * v2.x;

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3hf operator *(Vertex3hf v, Matrix4x4 m)
		{
			Vertex3hf r;

			r.x = (HalfFloat)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (HalfFloat)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (HalfFloat)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

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
		public static bool operator ==(Vertex3hf v1, Vertex3hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3hf v1, Vertex3hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator float[](Vertex3hf a)
		{
			float[] v = new float[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex2f(Vertex3hf a)
		{
			Vertex2f v;

			v.x = a.x;
			v.y = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex4f(Vertex3hf a)
		{
			Vertex4f v;

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;
			v.w = 1.0f;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex3d(Vertex3hf a)
		{
			Vertex3d v;

			v.x = a.x;
			v.y = a.y;
			v.z = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator ColorRGBAF(Vertex3hf a)
		{
			return (new ColorRGBAF(a.x, a.y, a.z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute bidimensional vertex module.
		/// </summary>
		/// <returns>It returns the vertex vector module.</returns>
		public float Module()
		{
			float x2 = (x * x);
			float y2 = (y * y);
			float z2 = (z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= Module();
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3hf Normalized
		{
			get
			{
				Vertex3hf normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3hf Zero = new Vertex3hf(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3hf One = new Vertex3hf(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3hf UnitX = new Vertex3hf(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3hf UnitY = new Vertex3hf(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3hf UnitZ = new Vertex3hf(0.0f, 0.0f, 1.0f);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = (HalfFloat)value; }
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= 1e-6f)
				return (false);
			if (Math.Abs(Y - other.Y) >= 1e-6f)
				return (false);
			if (Math.Abs(Z - other.Z) >= 1e-6f)
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
			if (obj.GetType().GetInterface("IVertex") == null)
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
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();
				result = (result * 397) ^ Z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}
}