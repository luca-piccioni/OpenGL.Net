
// Copyright (C) 2009-2017 Luca Piccioni
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
	[ArrayBufferItem(VertexBaseType.UByte, 2)]
	[DebuggerDisplay("Vertex2ub: X={x} Y={y}")]
	public struct Vertex2ub : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte"/> that specify the value of every component.
		/// </param>
		public Vertex2ub(byte v) : this(v, v) { }

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex2ub(byte[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:byte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:byte"/> that specify the Y coordinate.
		/// </param>
		public Vertex2ub(byte x, byte y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2ub"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2ub(Vertex2ub other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public byte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public byte y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 2;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ub operator +(Vertex2ub v1, Vertex2ub v2)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x + v2.x);
			v.y = (byte)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ub operator -(Vertex2ub v1, Vertex2ub v2)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x - v2.x);
			v.y = (byte)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, float scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, double scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, float scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, double scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2ub v1, Vertex2ub v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, byte scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, byte scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2ub v1, Vertex2ub v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator byte[](Vertex2ub a)
		{
			byte[] v = new byte[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2ub a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2ub v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2ub v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2ub v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2ub v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2ub v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2ub v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2ub Normalized
		{
			get
			{
				Vertex2ub normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ub holding the minumum values.
		/// </returns>
		public static Vertex2ub Min(params Vertex2ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (byte)Math.Min(x, v[i].x);
				y = (byte)Math.Min(y, v[i].y);
			}

			return (new Vertex2ub(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ub holding the minumum values.
		/// </returns>
		public unsafe static Vertex2ub Min(Vertex2ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (byte)Math.Min(x, v[i].x);
				y = (byte)Math.Min(y, v[i].y);
			}

			return (new Vertex2ub(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ub holding the maximum values.
		/// </returns>
		public static Vertex2ub Max(params Vertex2ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (byte)Math.Max(x, v[i].x);
				y = (byte)Math.Max(y, v[i].y);
			}

			return (new Vertex2ub(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ub holding the maximum values.
		/// </returns>
		public unsafe static Vertex2ub Max(Vertex2ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (byte)Math.Max(x, v[i].x);
				y = (byte)Math.Max(y, v[i].y);
			}

			return (new Vertex2ub(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2ub"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2ub[] v, out Vertex2ub min, out Vertex2ub max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (byte)Math.Min(minx, v[i].x); miny = (byte)Math.Min(miny, v[i].y);
				maxx = (byte)Math.Max(maxx, v[i].x); maxy = (byte)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2ub(minx, miny);
			max = new Vertex2ub(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2ub"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2ub* v, uint count, out Vertex2ub min, out Vertex2ub max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (byte)Math.Min(minx, v[i].x); miny = (byte)Math.Min(miny, v[i].y);
				maxx = (byte)Math.Max(maxx, v[i].x); maxy = (byte)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2ub(minx, miny);
			max = new Vertex2ub(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2ub Zero = new Vertex2ub(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2ub One = new Vertex2ub(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2ub UnitX = new Vertex2ub(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2ub UnitY = new Vertex2ub(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2ub Minimum = new Vertex2ub(byte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2ub Maximum = new Vertex2ub(byte.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2ub.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2ub.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (sbyte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 2)]
	[DebuggerDisplay("Vertex2b: X={x} Y={y}")]
	public struct Vertex2b : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte"/> that specify the value of every component.
		/// </param>
		public Vertex2b(sbyte v) : this(v, v) { }

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex2b(sbyte[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/> that specify the Y coordinate.
		/// </param>
		public Vertex2b(sbyte x, sbyte y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2b"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2b(Vertex2b other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public sbyte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public sbyte y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 2;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2b operator -(Vertex2b v)
		{
			return (new Vertex2b((sbyte)(-v.x), (sbyte)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2b operator +(Vertex2b v1, Vertex2b v2)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x + v2.x);
			v.y = (sbyte)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2b operator -(Vertex2b v1, Vertex2b v2)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x - v2.x);
			v.y = (sbyte)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, float scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, double scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, float scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, double scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2b v1, Vertex2b v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, sbyte scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, sbyte scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2b v1, Vertex2b v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2b v1, Vertex2b v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to sbyte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator sbyte[](Vertex2b a)
		{
			sbyte[] v = new sbyte[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2b a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2b v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2b v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2b v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2b v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2b v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2b v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2b Normalized
		{
			get
			{
				Vertex2b normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2b holding the minumum values.
		/// </returns>
		public static Vertex2b Min(params Vertex2b[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (sbyte)Math.Min(x, v[i].x);
				y = (sbyte)Math.Min(y, v[i].y);
			}

			return (new Vertex2b(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2b holding the minumum values.
		/// </returns>
		public unsafe static Vertex2b Min(Vertex2b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (sbyte)Math.Min(x, v[i].x);
				y = (sbyte)Math.Min(y, v[i].y);
			}

			return (new Vertex2b(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2b holding the maximum values.
		/// </returns>
		public static Vertex2b Max(params Vertex2b[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (sbyte)Math.Max(x, v[i].x);
				y = (sbyte)Math.Max(y, v[i].y);
			}

			return (new Vertex2b(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2b holding the maximum values.
		/// </returns>
		public unsafe static Vertex2b Max(Vertex2b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (sbyte)Math.Max(x, v[i].x);
				y = (sbyte)Math.Max(y, v[i].y);
			}

			return (new Vertex2b(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2b"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2b[] v, out Vertex2b min, out Vertex2b max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (sbyte)Math.Min(minx, v[i].x); miny = (sbyte)Math.Min(miny, v[i].y);
				maxx = (sbyte)Math.Max(maxx, v[i].x); maxy = (sbyte)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2b(minx, miny);
			max = new Vertex2b(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2b"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2b* v, uint count, out Vertex2b min, out Vertex2b max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (sbyte)Math.Min(minx, v[i].x); miny = (sbyte)Math.Min(miny, v[i].y);
				maxx = (sbyte)Math.Max(maxx, v[i].x); maxy = (sbyte)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2b(minx, miny);
			max = new Vertex2b(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2b Zero = new Vertex2b(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2b One = new Vertex2b(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2b UnitX = new Vertex2b(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2b UnitY = new Vertex2b(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2b Minimum = new Vertex2b(sbyte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2b Maximum = new Vertex2b(sbyte.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2b.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2b.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (ushort coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 2)]
	[DebuggerDisplay("Vertex2us: X={x} Y={y}")]
	public struct Vertex2us : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:ushort"/> that specify the value of every component.
		/// </param>
		public Vertex2us(ushort v) : this(v, v) { }

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex2us(ushort[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:ushort"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:ushort"/> that specify the Y coordinate.
		/// </param>
		public Vertex2us(ushort x, ushort y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2us"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2us(Vertex2us other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public ushort y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 4;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2us operator +(Vertex2us v1, Vertex2us v2)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x + v2.x);
			v.y = (ushort)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2us operator -(Vertex2us v1, Vertex2us v2)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x - v2.x);
			v.y = (ushort)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, float scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, double scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, float scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, double scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2us v1, Vertex2us v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, ushort scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, ushort scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2us v1, Vertex2us v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2us v1, Vertex2us v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator ushort[](Vertex2us a)
		{
			ushort[] v = new ushort[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2us a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2us v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2us v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2us v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2us v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2us v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2us v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2us Normalized
		{
			get
			{
				Vertex2us normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2us holding the minumum values.
		/// </returns>
		public static Vertex2us Min(params Vertex2us[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (ushort)Math.Min(x, v[i].x);
				y = (ushort)Math.Min(y, v[i].y);
			}

			return (new Vertex2us(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2us holding the minumum values.
		/// </returns>
		public unsafe static Vertex2us Min(Vertex2us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (ushort)Math.Min(x, v[i].x);
				y = (ushort)Math.Min(y, v[i].y);
			}

			return (new Vertex2us(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2us holding the maximum values.
		/// </returns>
		public static Vertex2us Max(params Vertex2us[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (ushort)Math.Max(x, v[i].x);
				y = (ushort)Math.Max(y, v[i].y);
			}

			return (new Vertex2us(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2us holding the maximum values.
		/// </returns>
		public unsafe static Vertex2us Max(Vertex2us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (ushort)Math.Max(x, v[i].x);
				y = (ushort)Math.Max(y, v[i].y);
			}

			return (new Vertex2us(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2us"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2us[] v, out Vertex2us min, out Vertex2us max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (ushort)Math.Min(minx, v[i].x); miny = (ushort)Math.Min(miny, v[i].y);
				maxx = (ushort)Math.Max(maxx, v[i].x); maxy = (ushort)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2us(minx, miny);
			max = new Vertex2us(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2us"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2us* v, uint count, out Vertex2us min, out Vertex2us max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (ushort)Math.Min(minx, v[i].x); miny = (ushort)Math.Min(miny, v[i].y);
				maxx = (ushort)Math.Max(maxx, v[i].x); maxy = (ushort)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2us(minx, miny);
			max = new Vertex2us(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2us Zero = new Vertex2us(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2us One = new Vertex2us(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2us UnitX = new Vertex2us(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2us UnitY = new Vertex2us(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2us Minimum = new Vertex2us(ushort.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2us Maximum = new Vertex2us(ushort.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2us.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2us.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 2)]
	[DebuggerDisplay("Vertex2s: X={x} Y={y}")]
	public struct Vertex2s : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:short"/> that specify the value of every component.
		/// </param>
		public Vertex2s(short v) : this(v, v) { }

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:short[]"/> that specify the value of every component.
		/// </param>
		public Vertex2s(short[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:short"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:short"/> that specify the Y coordinate.
		/// </param>
		public Vertex2s(short x, short y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2s"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2s(Vertex2s other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public short y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 4;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2s operator -(Vertex2s v)
		{
			return (new Vertex2s((short)(-v.x), (short)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2s operator +(Vertex2s v1, Vertex2s v2)
		{
			Vertex2s v;

			v.x = (short)(v1.x + v2.x);
			v.y = (short)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2s operator -(Vertex2s v1, Vertex2s v2)
		{
			Vertex2s v;

			v.x = (short)(v1.x - v2.x);
			v.y = (short)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, float scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, double scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, float scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, double scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2s v1, Vertex2s v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, short scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, short scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2s v1, Vertex2s v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2s v1, Vertex2s v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to short[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:short[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator short[](Vertex2s a)
		{
			short[] v = new short[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2s a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2s v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2s v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2s v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2s v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2s v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2s v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2s Normalized
		{
			get
			{
				Vertex2s normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2s holding the minumum values.
		/// </returns>
		public static Vertex2s Min(params Vertex2s[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			short x = (short)short.MaxValue, y = (short)short.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (short)Math.Min(x, v[i].x);
				y = (short)Math.Min(y, v[i].y);
			}

			return (new Vertex2s(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2s holding the minumum values.
		/// </returns>
		public unsafe static Vertex2s Min(Vertex2s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			short x = (short)short.MaxValue, y = (short)short.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (short)Math.Min(x, v[i].x);
				y = (short)Math.Min(y, v[i].y);
			}

			return (new Vertex2s(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2s holding the maximum values.
		/// </returns>
		public static Vertex2s Max(params Vertex2s[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short x = (short)short.MinValue, y = (short)short.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (short)Math.Max(x, v[i].x);
				y = (short)Math.Max(y, v[i].y);
			}

			return (new Vertex2s(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2s holding the maximum values.
		/// </returns>
		public unsafe static Vertex2s Max(Vertex2s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short x = (short)short.MinValue, y = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (short)Math.Max(x, v[i].x);
				y = (short)Math.Max(y, v[i].y);
			}

			return (new Vertex2s(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2s"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2s[] v, out Vertex2s min, out Vertex2s max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (short)Math.Min(minx, v[i].x); miny = (short)Math.Min(miny, v[i].y);
				maxx = (short)Math.Max(maxx, v[i].x); maxy = (short)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2s(minx, miny);
			max = new Vertex2s(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2s"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2s* v, uint count, out Vertex2s min, out Vertex2s max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (short)Math.Min(minx, v[i].x); miny = (short)Math.Min(miny, v[i].y);
				maxx = (short)Math.Max(maxx, v[i].x); maxy = (short)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2s(minx, miny);
			max = new Vertex2s(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2s Zero = new Vertex2s(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2s One = new Vertex2s(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2s UnitX = new Vertex2s(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2s UnitY = new Vertex2s(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2s Minimum = new Vertex2s(short.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2s Maximum = new Vertex2s(short.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2s.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2s.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (uint coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 2)]
	[DebuggerDisplay("Vertex2ui: X={x} Y={y}")]
	public struct Vertex2ui : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:uint"/> that specify the value of every component.
		/// </param>
		public Vertex2ui(uint v) : this(v, v) { }

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex2ui(uint[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:uint"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:uint"/> that specify the Y coordinate.
		/// </param>
		public Vertex2ui(uint x, uint y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2ui"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2ui(Vertex2ui other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public uint y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 8;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ui operator +(Vertex2ui v1, Vertex2ui v2)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x + v2.x);
			v.y = (uint)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ui operator -(Vertex2ui v1, Vertex2ui v2)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x - v2.x);
			v.y = (uint)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, float scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, double scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, float scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, double scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2ui v1, Vertex2ui v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, uint scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, uint scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2ui v1, Vertex2ui v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:uint[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator uint[](Vertex2ui a)
		{
			uint[] v = new uint[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2ui a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2ui v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2ui v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2ui v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2ui v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2ui v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2ui v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2ui Normalized
		{
			get
			{
				Vertex2ui normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ui holding the minumum values.
		/// </returns>
		public static Vertex2ui Min(params Vertex2ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (uint)Math.Min(x, v[i].x);
				y = (uint)Math.Min(y, v[i].y);
			}

			return (new Vertex2ui(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ui holding the minumum values.
		/// </returns>
		public unsafe static Vertex2ui Min(Vertex2ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (uint)Math.Min(x, v[i].x);
				y = (uint)Math.Min(y, v[i].y);
			}

			return (new Vertex2ui(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ui holding the maximum values.
		/// </returns>
		public static Vertex2ui Max(params Vertex2ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (uint)Math.Max(x, v[i].x);
				y = (uint)Math.Max(y, v[i].y);
			}

			return (new Vertex2ui(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2ui holding the maximum values.
		/// </returns>
		public unsafe static Vertex2ui Max(Vertex2ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (uint)Math.Max(x, v[i].x);
				y = (uint)Math.Max(y, v[i].y);
			}

			return (new Vertex2ui(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2ui"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2ui[] v, out Vertex2ui min, out Vertex2ui max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (uint)Math.Min(minx, v[i].x); miny = (uint)Math.Min(miny, v[i].y);
				maxx = (uint)Math.Max(maxx, v[i].x); maxy = (uint)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2ui(minx, miny);
			max = new Vertex2ui(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2ui"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2ui* v, uint count, out Vertex2ui min, out Vertex2ui max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (uint)Math.Min(minx, v[i].x); miny = (uint)Math.Min(miny, v[i].y);
				maxx = (uint)Math.Max(maxx, v[i].x); maxy = (uint)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2ui(minx, miny);
			max = new Vertex2ui(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2ui Zero = new Vertex2ui(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2ui One = new Vertex2ui(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2ui UnitX = new Vertex2ui(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2ui UnitY = new Vertex2ui(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2ui Minimum = new Vertex2ui(uint.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2ui Maximum = new Vertex2ui(uint.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2ui.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2ui.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (int coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 2)]
	[DebuggerDisplay("Vertex2i: X={x} Y={y}")]
	public struct Vertex2i : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:int"/> that specify the value of every component.
		/// </param>
		public Vertex2i(int v) : this(v, v) { }

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:int[]"/> that specify the value of every component.
		/// </param>
		public Vertex2i(int[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:int"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int"/> that specify the Y coordinate.
		/// </param>
		public Vertex2i(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2i"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2i(Vertex2i other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public int y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 8;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2i operator -(Vertex2i v)
		{
			return (new Vertex2i((int)(-v.x), (int)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2i operator +(Vertex2i v1, Vertex2i v2)
		{
			Vertex2i v;

			v.x = (int)(v1.x + v2.x);
			v.y = (int)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2i operator -(Vertex2i v1, Vertex2i v2)
		{
			Vertex2i v;

			v.x = (int)(v1.x - v2.x);
			v.y = (int)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, float scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, double scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, float scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, double scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2i v1, Vertex2i v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, int scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, int scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2i v1, Vertex2i v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2i v1, Vertex2i v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to int[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:int[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator int[](Vertex2i a)
		{
			int[] v = new int[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2i a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2i v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2i v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2i v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2i v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2i v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2i v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2i Normalized
		{
			get
			{
				Vertex2i normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2i holding the minumum values.
		/// </returns>
		public static Vertex2i Min(params Vertex2i[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			int x = (int)int.MaxValue, y = (int)int.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (int)Math.Min(x, v[i].x);
				y = (int)Math.Min(y, v[i].y);
			}

			return (new Vertex2i(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2i holding the minumum values.
		/// </returns>
		public unsafe static Vertex2i Min(Vertex2i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			int x = (int)int.MaxValue, y = (int)int.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (int)Math.Min(x, v[i].x);
				y = (int)Math.Min(y, v[i].y);
			}

			return (new Vertex2i(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2i holding the maximum values.
		/// </returns>
		public static Vertex2i Max(params Vertex2i[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int x = (int)int.MinValue, y = (int)int.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (int)Math.Max(x, v[i].x);
				y = (int)Math.Max(y, v[i].y);
			}

			return (new Vertex2i(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2i holding the maximum values.
		/// </returns>
		public unsafe static Vertex2i Max(Vertex2i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int x = (int)int.MinValue, y = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (int)Math.Max(x, v[i].x);
				y = (int)Math.Max(y, v[i].y);
			}

			return (new Vertex2i(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2i"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2i[] v, out Vertex2i min, out Vertex2i max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (int)Math.Min(minx, v[i].x); miny = (int)Math.Min(miny, v[i].y);
				maxx = (int)Math.Max(maxx, v[i].x); maxy = (int)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2i(minx, miny);
			max = new Vertex2i(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2i"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2i* v, uint count, out Vertex2i min, out Vertex2i max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (int)Math.Min(minx, v[i].x); miny = (int)Math.Min(miny, v[i].y);
				maxx = (int)Math.Max(maxx, v[i].x); maxy = (int)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2i(minx, miny);
			max = new Vertex2i(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2i Zero = new Vertex2i(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2i One = new Vertex2i(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2i UnitX = new Vertex2i(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2i UnitY = new Vertex2i(0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2i Minimum = new Vertex2i(int.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2i Maximum = new Vertex2i(int.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2i.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2i.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 2)]
	[DebuggerDisplay("Vertex2f: X={x} Y={y}")]
	public struct Vertex2f : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float"/> that specify the value of every component.
		/// </param>
		public Vertex2f(float v) : this(v, v) { }

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/> that specify the value of every component.
		/// </param>
		public Vertex2f(float[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/> that specify the Y coordinate.
		/// </param>
		public Vertex2f(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2f"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2f(Vertex2f other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public float x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public float y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 8;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2f operator -(Vertex2f v)
		{
			return (new Vertex2f((float)(-v.x), (float)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2f operator +(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = (float)(v1.x + v2.x);
			v.y = (float)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2f operator -(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = (float)(v1.x - v2.x);
			v.y = (float)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator *(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator *(Vertex2f v1, double scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator /(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator /(Vertex2f v1, double scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2f v1, Vertex2f v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2f v1, Vertex2f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2f v1, Vertex2f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator float[](Vertex2f a)
		{
			float[] v = new float[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2f a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2f v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2f v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2f v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2f v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2f v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2f Normalized
		{
			get
			{
				Vertex2f normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2f holding the minumum values.
		/// </returns>
		public static Vertex2f Min(params Vertex2f[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			float x = (float)float.MaxValue, y = (float)float.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (float)Math.Min(x, v[i].x);
				y = (float)Math.Min(y, v[i].y);
			}

			return (new Vertex2f(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2f holding the minumum values.
		/// </returns>
		public unsafe static Vertex2f Min(Vertex2f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			float x = (float)float.MaxValue, y = (float)float.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (float)Math.Min(x, v[i].x);
				y = (float)Math.Min(y, v[i].y);
			}

			return (new Vertex2f(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2f holding the maximum values.
		/// </returns>
		public static Vertex2f Max(params Vertex2f[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float x = (float)float.MinValue, y = (float)float.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (float)Math.Max(x, v[i].x);
				y = (float)Math.Max(y, v[i].y);
			}

			return (new Vertex2f(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2f holding the maximum values.
		/// </returns>
		public unsafe static Vertex2f Max(Vertex2f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float x = (float)float.MinValue, y = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (float)Math.Max(x, v[i].x);
				y = (float)Math.Max(y, v[i].y);
			}

			return (new Vertex2f(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2f"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2f[] v, out Vertex2f min, out Vertex2f max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (float)Math.Min(minx, v[i].x); miny = (float)Math.Min(miny, v[i].y);
				maxx = (float)Math.Max(maxx, v[i].x); maxy = (float)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2f(minx, miny);
			max = new Vertex2f(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2f"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2f* v, uint count, out Vertex2f min, out Vertex2f max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (float)Math.Min(minx, v[i].x); miny = (float)Math.Min(miny, v[i].y);
				maxx = (float)Math.Max(maxx, v[i].x); maxy = (float)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2f(minx, miny);
			max = new Vertex2f(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2f Zero = new Vertex2f(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2f One = new Vertex2f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2f UnitX = new Vertex2f(1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2f UnitY = new Vertex2f(0.0f, 1.0f);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2f Minimum = new Vertex2f(float.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2f Maximum = new Vertex2f(float.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 2)]
	[DebuggerDisplay("Vertex2d: X={x} Y={y}")]
	public struct Vertex2d : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double"/> that specify the value of every component.
		/// </param>
		public Vertex2d(double v) : this(v, v) { }

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/> that specify the value of every component.
		/// </param>
		public Vertex2d(double[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/> that specify the Y coordinate.
		/// </param>
		public Vertex2d(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2d"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2d(Vertex2d other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public double x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public double y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 16;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2d to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2d operator -(Vertex2d v)
		{
			return (new Vertex2d((double)(-v.x), (double)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2d operator +(Vertex2d v1, Vertex2d v2)
		{
			Vertex2d v;

			v.x = (double)(v1.x + v2.x);
			v.y = (double)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2d operator -(Vertex2d v1, Vertex2d v2)
		{
			Vertex2d v;

			v.x = (double)(v1.x - v2.x);
			v.y = (double)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator *(Vertex2d v1, float scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator *(Vertex2d v1, double scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator /(Vertex2d v1, float scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator /(Vertex2d v1, double scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2d v1, Vertex2d v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2d v1, Vertex2d v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2d v1, Vertex2d v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2d a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}
		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2d v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2d v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2d v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2d v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2d v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2d Normalized
		{
			get
			{
				Vertex2d normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2d holding the minumum values.
		/// </returns>
		public static Vertex2d Min(params Vertex2d[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			double x = (double)double.MaxValue, y = (double)double.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (double)Math.Min(x, v[i].x);
				y = (double)Math.Min(y, v[i].y);
			}

			return (new Vertex2d(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2d holding the minumum values.
		/// </returns>
		public unsafe static Vertex2d Min(Vertex2d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			double x = (double)double.MaxValue, y = (double)double.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (double)Math.Min(x, v[i].x);
				y = (double)Math.Min(y, v[i].y);
			}

			return (new Vertex2d(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2d holding the maximum values.
		/// </returns>
		public static Vertex2d Max(params Vertex2d[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double x = (double)double.MinValue, y = (double)double.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (double)Math.Max(x, v[i].x);
				y = (double)Math.Max(y, v[i].y);
			}

			return (new Vertex2d(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2d holding the maximum values.
		/// </returns>
		public unsafe static Vertex2d Max(Vertex2d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double x = (double)double.MinValue, y = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (double)Math.Max(x, v[i].x);
				y = (double)Math.Max(y, v[i].y);
			}

			return (new Vertex2d(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2d"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2d[] v, out Vertex2d min, out Vertex2d max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (double)Math.Min(minx, v[i].x); miny = (double)Math.Min(miny, v[i].y);
				maxx = (double)Math.Max(maxx, v[i].x); maxy = (double)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2d(minx, miny);
			max = new Vertex2d(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2d"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2d* v, uint count, out Vertex2d min, out Vertex2d max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (double)Math.Min(minx, v[i].x); miny = (double)Math.Min(miny, v[i].y);
				maxx = (double)Math.Max(maxx, v[i].x); maxy = (double)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2d(minx, miny);
			max = new Vertex2d(maxx, maxy);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2d Zero = new Vertex2d(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2d One = new Vertex2d(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2d UnitX = new Vertex2d(1.0, 0.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2d UnitY = new Vertex2d(0.0, 1.0);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex2d Minimum = new Vertex2d(double.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex2d Maximum = new Vertex2d(double.MaxValue);

		#endregion

		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2d.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (HalfFloat coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 2)]
	[DebuggerDisplay("Vertex2hf: X={x} Y={y}")]
	public struct Vertex2hf : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex2hf(HalfFloat v) : this(v, v) { }

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex2hf(HalfFloat[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:HalfFloat"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:HalfFloat"/> that specify the Y coordinate.
		/// </param>
		public Vertex2hf(HalfFloat x, HalfFloat y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2hf"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2hf(Vertex2hf other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat y;

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 4;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v)
		{
			return (new Vertex2hf((HalfFloat)(-v.x), (HalfFloat)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2hf operator +(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator *(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator *(Vertex2hf v1, double scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator /(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator /(Vertex2hf v1, double scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2hf v1, Vertex2hf v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2hf v1, Vertex2hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator HalfFloat[](Vertex2hf a)
		{
			HalfFloat[] v = new HalfFloat[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2hf a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2hf v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2hf v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2hf v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2hf v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2hf v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2hf v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
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
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			Debug.Assert(Math.Abs(length) >= Single.Epsilon);
			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex2hf Normalized
		{
			get
			{
				Vertex2hf normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2hf holding the minumum values.
		/// </returns>
		public static Vertex2hf Min(params Vertex2hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (HalfFloat)Math.Min(x, v[i].x);
				y = (HalfFloat)Math.Min(y, v[i].y);
			}

			return (new Vertex2hf(x, y));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2hf holding the minumum values.
		/// </returns>
		public unsafe static Vertex2hf Min(Vertex2hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (HalfFloat)Math.Min(x, v[i].x);
				y = (HalfFloat)Math.Min(y, v[i].y);
			}

			return (new Vertex2hf(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex2hf holding the maximum values.
		/// </returns>
		public static Vertex2hf Max(params Vertex2hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (HalfFloat)Math.Max(x, v[i].x);
				y = (HalfFloat)Math.Max(y, v[i].y);
			}

			return (new Vertex2hf(x, y));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex2hf holding the maximum values.
		/// </returns>
		public unsafe static Vertex2hf Max(Vertex2hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (HalfFloat)Math.Max(x, v[i].x);
				y = (HalfFloat)Math.Max(y, v[i].y);
			}

			return (new Vertex2hf(x, y));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2hf"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex2hf[] v, out Vertex2hf min, out Vertex2hf max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (HalfFloat)Math.Min(minx, v[i].x); miny = (HalfFloat)Math.Min(miny, v[i].y);
				maxx = (HalfFloat)Math.Max(maxx, v[i].x); maxy = (HalfFloat)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2hf(minx, miny);
			max = new Vertex2hf(maxx, maxy);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex2hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex2hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex2hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex2hf"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex2hf* v, uint count, out Vertex2hf min, out Vertex2hf max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (HalfFloat)Math.Min(minx, v[i].x); miny = (HalfFloat)Math.Min(miny, v[i].y);
				maxx = (HalfFloat)Math.Max(maxx, v[i].x); maxy = (HalfFloat)Math.Max(maxy, v[i].y);
			}

			min = new Vertex2hf(minx, miny);
			max = new Vertex2hf(maxx, maxy);
		}

		#endregion
		#region IVertex2 Implementation

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
					case 2: return (0.0f);
					case 3: return (1.0f);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
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
			
			try {
				return (Equals((IVertex2)obj));
			} catch(InvalidCastException) { return (false); }
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2hf.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2hf.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

}