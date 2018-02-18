
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
using System.Diagnostics;
using System.Runtime.InteropServices;

#if HAVE_NUMERICS
using System.Numerics;
#endif

namespace OpenGL
{
	/// <summary>
	/// Vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3ub: X={x} Y={y} Z={z}")]
	public struct Vertex3ub : IEquatable<Vertex3ub>
	{
		#region Constructors

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the value of every component.
		/// </param>
		public Vertex3ub(byte v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex3ub(byte[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3ub constructor.
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
		public Vertex3ub(byte x, byte y, byte z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 3;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ub operator +(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x + v2.x);
			v.y = (byte)(v1.y + v2.y);
			v.z = (byte)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ub operator -(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x - v2.x);
			v.y = (byte)(v1.y - v2.y);
			v.z = (byte)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, float scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, double scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, float scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, double scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3ub v1, Vertex3ub v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, byte scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, byte scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

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

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator byte[](Vertex3ub a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4ub"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4ub(Vertex3ub a)
		{
			return new Vertex4ub(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3ub a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3ub a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3ub Normalized
		{
			get
			{
				Vertex3ub normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ub holding the minumum values.
		/// </returns>
		public static Vertex3ub Min(params Vertex3ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue, z = (byte)byte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (byte)Math.Min(x, v[i].x);
				y = (byte)Math.Min(y, v[i].y);
				z = (byte)Math.Min(z, v[i].z);
			}

			return (new Vertex3ub(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ub holding the minumum values.
		/// </returns>
		public unsafe static Vertex3ub Min(Vertex3ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue, z = (byte)byte.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (byte)Math.Min(x, v[i].x);
				y = (byte)Math.Min(y, v[i].y);
				z = (byte)Math.Min(z, v[i].z);
			}

			return (new Vertex3ub(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ub holding the maximum values.
		/// </returns>
		public static Vertex3ub Max(params Vertex3ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue, z = (byte)byte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (byte)Math.Max(x, v[i].x);
				y = (byte)Math.Max(y, v[i].y);
				z = (byte)Math.Max(z, v[i].z);
			}

			return (new Vertex3ub(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ub holding the maximum values.
		/// </returns>
		public unsafe static Vertex3ub Max(Vertex3ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue, z = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (byte)Math.Max(x, v[i].x);
				y = (byte)Math.Max(y, v[i].y);
				z = (byte)Math.Max(z, v[i].z);
			}

			return (new Vertex3ub(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3ub"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3ub[] v, out Vertex3ub min, out Vertex3ub max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue, minz = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue, maxz = (byte)byte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (byte)Math.Min(minx, v[i].x); miny = (byte)Math.Min(miny, v[i].y); minz = (byte)Math.Min(minz, v[i].z);
				maxx = (byte)Math.Max(maxx, v[i].x); maxy = (byte)Math.Max(maxy, v[i].y); maxz = (byte)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3ub(minx, miny, minz);
			max = new Vertex3ub(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3ub"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3ub* v, uint count, out Vertex3ub min, out Vertex3ub max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue, minz = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue, maxz = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (byte)Math.Min(minx, v[i].x); miny = (byte)Math.Min(miny, v[i].y); minz = (byte)Math.Min(minz, v[i].z);
				maxx = (byte)Math.Max(maxx, v[i].x); maxy = (byte)Math.Max(maxy, v[i].y); maxz = (byte)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3ub(minx, miny, minz);
			max = new Vertex3ub(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3ub Zero = new Vertex3ub(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3ub One = new Vertex3ub(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3ub UnitX = new Vertex3ub(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3ub UnitY = new Vertex3ub(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3ub UnitZ = new Vertex3ub(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3ub Minimum = new Vertex3ub(byte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3ub Maximum = new Vertex3ub(byte.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3ub is equal to another Vertex3ub, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3ub"/> to compare with this Vertex3ub.
		/// </param>
		/// <param name="precision">
		/// The <see cref="byte"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3ub is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3ub other, byte precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3ub is equal to another Vertex3ub.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3ub"/> to compare with this Vertex3ub.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3ub is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3ub other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3ub))
				return (false);
			
			return (Equals((Vertex3ub)obj));
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
	/// Vertex value type (sbyte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3b: X={x} Y={y} Z={z}")]
	public struct Vertex3b : IEquatable<Vertex3b>
	{
		#region Constructors

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the value of every component.
		/// </param>
		public Vertex3b(sbyte v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex3b(sbyte[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3b constructor.
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
		public Vertex3b(sbyte x, sbyte y, sbyte z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 3;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3b operator -(Vertex3b v)
		{
			return (new Vertex3b((sbyte)(-v.x), (sbyte)(-v.y), (sbyte)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3b operator +(Vertex3b v1, Vertex3b v2)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x + v2.x);
			v.y = (sbyte)(v1.y + v2.y);
			v.z = (sbyte)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3b operator -(Vertex3b v1, Vertex3b v2)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x - v2.x);
			v.y = (sbyte)(v1.y - v2.y);
			v.z = (sbyte)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, float scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, double scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, float scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, double scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3b v1, Vertex3b v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3b v1, Vertex3b v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, sbyte scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, sbyte scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

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

		#region Cast Operators

		/// <summary>
		/// Cast to sbyte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator sbyte[](Vertex3b a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4b operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4b"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4b(Vertex3b a)
		{
			return new Vertex4b(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3b a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3b a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3b Normalized
		{
			get
			{
				Vertex3b normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3b holding the minumum values.
		/// </returns>
		public static Vertex3b Min(params Vertex3b[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue, z = (sbyte)sbyte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (sbyte)Math.Min(x, v[i].x);
				y = (sbyte)Math.Min(y, v[i].y);
				z = (sbyte)Math.Min(z, v[i].z);
			}

			return (new Vertex3b(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3b holding the minumum values.
		/// </returns>
		public unsafe static Vertex3b Min(Vertex3b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue, z = (sbyte)sbyte.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (sbyte)Math.Min(x, v[i].x);
				y = (sbyte)Math.Min(y, v[i].y);
				z = (sbyte)Math.Min(z, v[i].z);
			}

			return (new Vertex3b(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3b holding the maximum values.
		/// </returns>
		public static Vertex3b Max(params Vertex3b[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue, z = (sbyte)sbyte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (sbyte)Math.Max(x, v[i].x);
				y = (sbyte)Math.Max(y, v[i].y);
				z = (sbyte)Math.Max(z, v[i].z);
			}

			return (new Vertex3b(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3b holding the maximum values.
		/// </returns>
		public unsafe static Vertex3b Max(Vertex3b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue, z = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (sbyte)Math.Max(x, v[i].x);
				y = (sbyte)Math.Max(y, v[i].y);
				z = (sbyte)Math.Max(z, v[i].z);
			}

			return (new Vertex3b(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3b"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3b[] v, out Vertex3b min, out Vertex3b max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue, minz = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue, maxz = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (sbyte)Math.Min(minx, v[i].x); miny = (sbyte)Math.Min(miny, v[i].y); minz = (sbyte)Math.Min(minz, v[i].z);
				maxx = (sbyte)Math.Max(maxx, v[i].x); maxy = (sbyte)Math.Max(maxy, v[i].y); maxz = (sbyte)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3b(minx, miny, minz);
			max = new Vertex3b(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3b"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3b* v, uint count, out Vertex3b min, out Vertex3b max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue, minz = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue, maxz = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (sbyte)Math.Min(minx, v[i].x); miny = (sbyte)Math.Min(miny, v[i].y); minz = (sbyte)Math.Min(minz, v[i].z);
				maxx = (sbyte)Math.Max(maxx, v[i].x); maxy = (sbyte)Math.Max(maxy, v[i].y); maxz = (sbyte)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3b(minx, miny, minz);
			max = new Vertex3b(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3b Zero = new Vertex3b(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3b One = new Vertex3b(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3b UnitX = new Vertex3b(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3b UnitY = new Vertex3b(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3b UnitZ = new Vertex3b(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3b Minimum = new Vertex3b(sbyte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3b Maximum = new Vertex3b(sbyte.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3b is equal to another Vertex3b, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3b"/> to compare with this Vertex3b.
		/// </param>
		/// <param name="precision">
		/// The <see cref="sbyte"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3b is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3b other, sbyte precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3b is equal to another Vertex3b.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3b"/> to compare with this Vertex3b.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3b is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3b other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3b))
				return (false);
			
			return (Equals((Vertex3b)obj));
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
	/// Vertex value type (ushort coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3us: X={x} Y={y} Z={z}")]
	public struct Vertex3us : IEquatable<Vertex3us>
	{
		#region Constructors

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the value of every component.
		/// </param>
		public Vertex3us(ushort v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex3us(ushort[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3us constructor.
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
		public Vertex3us(ushort x, ushort y, ushort z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 6;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3us operator +(Vertex3us v1, Vertex3us v2)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x + v2.x);
			v.y = (ushort)(v1.y + v2.y);
			v.z = (ushort)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3us operator -(Vertex3us v1, Vertex3us v2)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x - v2.x);
			v.y = (ushort)(v1.y - v2.y);
			v.z = (ushort)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, float scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, double scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, float scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, double scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3us v1, Vertex3us v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3us v1, Vertex3us v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, ushort scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, ushort scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

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

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ushort[](Vertex3us a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4us"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4us(Vertex3us a)
		{
			return new Vertex4us(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3us a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3us a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3us Normalized
		{
			get
			{
				Vertex3us normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3us holding the minumum values.
		/// </returns>
		public static Vertex3us Min(params Vertex3us[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue, z = (ushort)ushort.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (ushort)Math.Min(x, v[i].x);
				y = (ushort)Math.Min(y, v[i].y);
				z = (ushort)Math.Min(z, v[i].z);
			}

			return (new Vertex3us(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3us holding the minumum values.
		/// </returns>
		public unsafe static Vertex3us Min(Vertex3us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue, z = (ushort)ushort.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (ushort)Math.Min(x, v[i].x);
				y = (ushort)Math.Min(y, v[i].y);
				z = (ushort)Math.Min(z, v[i].z);
			}

			return (new Vertex3us(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3us holding the maximum values.
		/// </returns>
		public static Vertex3us Max(params Vertex3us[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue, z = (ushort)ushort.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (ushort)Math.Max(x, v[i].x);
				y = (ushort)Math.Max(y, v[i].y);
				z = (ushort)Math.Max(z, v[i].z);
			}

			return (new Vertex3us(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3us holding the maximum values.
		/// </returns>
		public unsafe static Vertex3us Max(Vertex3us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue, z = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (ushort)Math.Max(x, v[i].x);
				y = (ushort)Math.Max(y, v[i].y);
				z = (ushort)Math.Max(z, v[i].z);
			}

			return (new Vertex3us(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3us"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3us[] v, out Vertex3us min, out Vertex3us max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue, minz = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue, maxz = (ushort)ushort.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (ushort)Math.Min(minx, v[i].x); miny = (ushort)Math.Min(miny, v[i].y); minz = (ushort)Math.Min(minz, v[i].z);
				maxx = (ushort)Math.Max(maxx, v[i].x); maxy = (ushort)Math.Max(maxy, v[i].y); maxz = (ushort)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3us(minx, miny, minz);
			max = new Vertex3us(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3us"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3us* v, uint count, out Vertex3us min, out Vertex3us max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue, minz = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue, maxz = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (ushort)Math.Min(minx, v[i].x); miny = (ushort)Math.Min(miny, v[i].y); minz = (ushort)Math.Min(minz, v[i].z);
				maxx = (ushort)Math.Max(maxx, v[i].x); maxy = (ushort)Math.Max(maxy, v[i].y); maxz = (ushort)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3us(minx, miny, minz);
			max = new Vertex3us(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3us Zero = new Vertex3us(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3us One = new Vertex3us(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3us UnitX = new Vertex3us(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3us UnitY = new Vertex3us(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3us UnitZ = new Vertex3us(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3us Minimum = new Vertex3us(ushort.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3us Maximum = new Vertex3us(ushort.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3us is equal to another Vertex3us, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3us"/> to compare with this Vertex3us.
		/// </param>
		/// <param name="precision">
		/// The <see cref="ushort"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3us is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3us other, ushort precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3us is equal to another Vertex3us.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3us"/> to compare with this Vertex3us.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3us is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3us other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3us))
				return (false);
			
			return (Equals((Vertex3us)obj));
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3us.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3us.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3s: X={x} Y={y} Z={z}")]
	public struct Vertex3s : IEquatable<Vertex3s>
	{
		#region Constructors

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the value of every component.
		/// </param>
		public Vertex3s(short v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:short[]"/> that specify the value of every component.
		/// </param>
		public Vertex3s(short[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3s constructor.
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
		public Vertex3s(short x, short y, short z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 6;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3s operator -(Vertex3s v)
		{
			return (new Vertex3s((short)(-v.x), (short)(-v.y), (short)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3s operator +(Vertex3s v1, Vertex3s v2)
		{
			Vertex3s v;

			v.x = (short)(v1.x + v2.x);
			v.y = (short)(v1.y + v2.y);
			v.z = (short)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3s operator -(Vertex3s v1, Vertex3s v2)
		{
			Vertex3s v;

			v.x = (short)(v1.x - v2.x);
			v.y = (short)(v1.y - v2.y);
			v.z = (short)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, float scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, double scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, float scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, double scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3s v1, Vertex3s v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3s v1, Vertex3s v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, short scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, short scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

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
		/// Cast to short[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:short[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator short[](Vertex3s a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4s operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4s"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4s(Vertex3s a)
		{
			return new Vertex4s(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3s a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3s a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3s Normalized
		{
			get
			{
				Vertex3s normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3s holding the minumum values.
		/// </returns>
		public static Vertex3s Min(params Vertex3s[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			short x = (short)short.MaxValue, y = (short)short.MaxValue, z = (short)short.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (short)Math.Min(x, v[i].x);
				y = (short)Math.Min(y, v[i].y);
				z = (short)Math.Min(z, v[i].z);
			}

			return (new Vertex3s(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3s holding the minumum values.
		/// </returns>
		public unsafe static Vertex3s Min(Vertex3s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			short x = (short)short.MaxValue, y = (short)short.MaxValue, z = (short)short.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (short)Math.Min(x, v[i].x);
				y = (short)Math.Min(y, v[i].y);
				z = (short)Math.Min(z, v[i].z);
			}

			return (new Vertex3s(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3s holding the maximum values.
		/// </returns>
		public static Vertex3s Max(params Vertex3s[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short x = (short)short.MinValue, y = (short)short.MinValue, z = (short)short.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (short)Math.Max(x, v[i].x);
				y = (short)Math.Max(y, v[i].y);
				z = (short)Math.Max(z, v[i].z);
			}

			return (new Vertex3s(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3s holding the maximum values.
		/// </returns>
		public unsafe static Vertex3s Max(Vertex3s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short x = (short)short.MinValue, y = (short)short.MinValue, z = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (short)Math.Max(x, v[i].x);
				y = (short)Math.Max(y, v[i].y);
				z = (short)Math.Max(z, v[i].z);
			}

			return (new Vertex3s(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3s"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3s[] v, out Vertex3s min, out Vertex3s max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue, minz = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue, maxz = (short)short.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (short)Math.Min(minx, v[i].x); miny = (short)Math.Min(miny, v[i].y); minz = (short)Math.Min(minz, v[i].z);
				maxx = (short)Math.Max(maxx, v[i].x); maxy = (short)Math.Max(maxy, v[i].y); maxz = (short)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3s(minx, miny, minz);
			max = new Vertex3s(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3s"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3s* v, uint count, out Vertex3s min, out Vertex3s max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue, minz = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue, maxz = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (short)Math.Min(minx, v[i].x); miny = (short)Math.Min(miny, v[i].y); minz = (short)Math.Min(minz, v[i].z);
				maxx = (short)Math.Max(maxx, v[i].x); maxy = (short)Math.Max(maxy, v[i].y); maxz = (short)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3s(minx, miny, minz);
			max = new Vertex3s(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3s Zero = new Vertex3s(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3s One = new Vertex3s(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3s UnitX = new Vertex3s(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3s UnitY = new Vertex3s(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3s UnitZ = new Vertex3s(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3s Minimum = new Vertex3s(short.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3s Maximum = new Vertex3s(short.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3s is equal to another Vertex3s, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3s"/> to compare with this Vertex3s.
		/// </param>
		/// <param name="precision">
		/// The <see cref="short"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3s is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3s other, short precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3s is equal to another Vertex3s.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3s"/> to compare with this Vertex3s.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3s is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3s other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3s))
				return (false);
			
			return (Equals((Vertex3s)obj));
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
	/// Vertex value type (uint coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3ui: X={x} Y={y} Z={z}")]
	public struct Vertex3ui : IEquatable<Vertex3ui>
	{
		#region Constructors

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the value of every component.
		/// </param>
		public Vertex3ui(uint v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex3ui(uint[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3ui constructor.
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

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 12;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ui operator +(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x + v2.x);
			v.y = (uint)(v1.y + v2.y);
			v.z = (uint)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ui operator -(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x - v2.x);
			v.y = (uint)(v1.y - v2.y);
			v.z = (uint)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, float scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, double scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, float scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, double scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3ui v1, Vertex3ui v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, uint scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, uint scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

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

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:uint[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator uint[](Vertex3ui a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4ui operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4ui"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4ui(Vertex3ui a)
		{
			return new Vertex4ui(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3ui a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3ui a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3ui Normalized
		{
			get
			{
				Vertex3ui normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ui holding the minumum values.
		/// </returns>
		public static Vertex3ui Min(params Vertex3ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue, z = (uint)uint.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (uint)Math.Min(x, v[i].x);
				y = (uint)Math.Min(y, v[i].y);
				z = (uint)Math.Min(z, v[i].z);
			}

			return (new Vertex3ui(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ui holding the minumum values.
		/// </returns>
		public unsafe static Vertex3ui Min(Vertex3ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue, z = (uint)uint.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (uint)Math.Min(x, v[i].x);
				y = (uint)Math.Min(y, v[i].y);
				z = (uint)Math.Min(z, v[i].z);
			}

			return (new Vertex3ui(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ui holding the maximum values.
		/// </returns>
		public static Vertex3ui Max(params Vertex3ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue, z = (uint)uint.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (uint)Math.Max(x, v[i].x);
				y = (uint)Math.Max(y, v[i].y);
				z = (uint)Math.Max(z, v[i].z);
			}

			return (new Vertex3ui(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3ui holding the maximum values.
		/// </returns>
		public unsafe static Vertex3ui Max(Vertex3ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue, z = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (uint)Math.Max(x, v[i].x);
				y = (uint)Math.Max(y, v[i].y);
				z = (uint)Math.Max(z, v[i].z);
			}

			return (new Vertex3ui(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3ui"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3ui[] v, out Vertex3ui min, out Vertex3ui max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue, minz = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue, maxz = (uint)uint.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (uint)Math.Min(minx, v[i].x); miny = (uint)Math.Min(miny, v[i].y); minz = (uint)Math.Min(minz, v[i].z);
				maxx = (uint)Math.Max(maxx, v[i].x); maxy = (uint)Math.Max(maxy, v[i].y); maxz = (uint)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3ui(minx, miny, minz);
			max = new Vertex3ui(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3ui"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3ui* v, uint count, out Vertex3ui min, out Vertex3ui max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue, minz = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue, maxz = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (uint)Math.Min(minx, v[i].x); miny = (uint)Math.Min(miny, v[i].y); minz = (uint)Math.Min(minz, v[i].z);
				maxx = (uint)Math.Max(maxx, v[i].x); maxy = (uint)Math.Max(maxy, v[i].y); maxz = (uint)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3ui(minx, miny, minz);
			max = new Vertex3ui(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3ui Zero = new Vertex3ui(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3ui One = new Vertex3ui(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3ui UnitX = new Vertex3ui(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3ui UnitY = new Vertex3ui(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3ui UnitZ = new Vertex3ui(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3ui Minimum = new Vertex3ui(uint.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3ui Maximum = new Vertex3ui(uint.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3ui is equal to another Vertex3ui, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3ui"/> to compare with this Vertex3ui.
		/// </param>
		/// <param name="precision">
		/// The <see cref="uint"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3ui is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3ui other, uint precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3ui is equal to another Vertex3ui.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3ui"/> to compare with this Vertex3ui.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3ui is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3ui other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3ui))
				return (false);
			
			return (Equals((Vertex3ui)obj));
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3ui.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3ui.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (int coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3i: X={x} Y={y} Z={z}")]
	public struct Vertex3i : IEquatable<Vertex3i>
	{
		#region Constructors

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the value of every component.
		/// </param>
		public Vertex3i(int v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:int[]"/> that specify the value of every component.
		/// </param>
		public Vertex3i(int[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3i constructor.
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

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 12;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3i operator -(Vertex3i v)
		{
			return (new Vertex3i((int)(-v.x), (int)(-v.y), (int)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3i operator +(Vertex3i v1, Vertex3i v2)
		{
			Vertex3i v;

			v.x = (int)(v1.x + v2.x);
			v.y = (int)(v1.y + v2.y);
			v.z = (int)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3i operator -(Vertex3i v1, Vertex3i v2)
		{
			Vertex3i v;

			v.x = (int)(v1.x - v2.x);
			v.y = (int)(v1.y - v2.y);
			v.z = (int)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, float scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, double scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, float scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, double scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3i v1, Vertex3i v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3i v1, Vertex3i v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, int scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, int scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

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

		#region Cast Operators

		/// <summary>
		/// Cast to int[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:int[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator int[](Vertex3i a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4i operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4i"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4i(Vertex3i a)
		{
			return new Vertex4i(a.x, a.y, a.z, 1);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3i a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3i a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3i Normalized
		{
			get
			{
				Vertex3i normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3i holding the minumum values.
		/// </returns>
		public static Vertex3i Min(params Vertex3i[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			int x = (int)int.MaxValue, y = (int)int.MaxValue, z = (int)int.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (int)Math.Min(x, v[i].x);
				y = (int)Math.Min(y, v[i].y);
				z = (int)Math.Min(z, v[i].z);
			}

			return (new Vertex3i(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3i holding the minumum values.
		/// </returns>
		public unsafe static Vertex3i Min(Vertex3i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			int x = (int)int.MaxValue, y = (int)int.MaxValue, z = (int)int.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (int)Math.Min(x, v[i].x);
				y = (int)Math.Min(y, v[i].y);
				z = (int)Math.Min(z, v[i].z);
			}

			return (new Vertex3i(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3i holding the maximum values.
		/// </returns>
		public static Vertex3i Max(params Vertex3i[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int x = (int)int.MinValue, y = (int)int.MinValue, z = (int)int.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (int)Math.Max(x, v[i].x);
				y = (int)Math.Max(y, v[i].y);
				z = (int)Math.Max(z, v[i].z);
			}

			return (new Vertex3i(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3i holding the maximum values.
		/// </returns>
		public unsafe static Vertex3i Max(Vertex3i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int x = (int)int.MinValue, y = (int)int.MinValue, z = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (int)Math.Max(x, v[i].x);
				y = (int)Math.Max(y, v[i].y);
				z = (int)Math.Max(z, v[i].z);
			}

			return (new Vertex3i(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3i"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3i[] v, out Vertex3i min, out Vertex3i max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue, minz = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue, maxz = (int)int.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (int)Math.Min(minx, v[i].x); miny = (int)Math.Min(miny, v[i].y); minz = (int)Math.Min(minz, v[i].z);
				maxx = (int)Math.Max(maxx, v[i].x); maxy = (int)Math.Max(maxy, v[i].y); maxz = (int)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3i(minx, miny, minz);
			max = new Vertex3i(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3i"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3i* v, uint count, out Vertex3i min, out Vertex3i max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue, minz = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue, maxz = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (int)Math.Min(minx, v[i].x); miny = (int)Math.Min(miny, v[i].y); minz = (int)Math.Min(minz, v[i].z);
				maxx = (int)Math.Max(maxx, v[i].x); maxy = (int)Math.Max(maxy, v[i].y); maxz = (int)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3i(minx, miny, minz);
			max = new Vertex3i(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3i Zero = new Vertex3i(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3i One = new Vertex3i(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3i UnitX = new Vertex3i(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3i UnitY = new Vertex3i(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3i UnitZ = new Vertex3i(0, 0, 1);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3i Minimum = new Vertex3i(int.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3i Maximum = new Vertex3i(int.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3i is equal to another Vertex3i, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3i"/> to compare with this Vertex3i.
		/// </param>
		/// <param name="precision">
		/// The <see cref="int"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3i is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3i other, int precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3i is equal to another Vertex3i.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3i"/> to compare with this Vertex3i.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3i is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3i other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3i))
				return (false);
			
			return (Equals((Vertex3i)obj));
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3i.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3i.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3f: X={x} Y={y} Z={z}")]
	public struct Vertex3f : IEquatable<Vertex3f>
	{
		#region Constructors

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the value of every component.
		/// </param>
		public Vertex3f(float v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/> that specify the value of every component.
		/// </param>
		public Vertex3f(float[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3f constructor.
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
		public Vertex3f(float x, float y, float z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 12;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3f operator -(Vertex3f v)
		{
			return (new Vertex3f((float)(-v.x), (float)(-v.y), (float)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator +(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = (float)(v1.x + v2.x);
			v.y = (float)(v1.y + v2.y);
			v.z = (float)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator -(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = (float)(v1.x - v2.x);
			v.y = (float)(v1.y - v2.y);
			v.z = (float)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v1, double scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator /(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator /(Vertex3f v1, double scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);

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
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
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

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

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
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator float[](Vertex3f a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3f a)
		{
			return new Vertex4f(a.x, a.y, a.z, 1.0f);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3f a)
		{
			return new Vertex3d(a.x, a.y, a.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3f a)
		{
			return new Vertex4d(a.x, a.y, a.z, 1.0);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
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

		/// <summary>
		/// Get the minimum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3f holding the minumum values.
		/// </returns>
		public static Vertex3f Min(params Vertex3f[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (float)Math.Min(x, v[i].x);
				y = (float)Math.Min(y, v[i].y);
				z = (float)Math.Min(z, v[i].z);
			}

			return (new Vertex3f(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3f holding the minumum values.
		/// </returns>
		public unsafe static Vertex3f Min(Vertex3f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (float)Math.Min(x, v[i].x);
				y = (float)Math.Min(y, v[i].y);
				z = (float)Math.Min(z, v[i].z);
			}

			return (new Vertex3f(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3f holding the maximum values.
		/// </returns>
		public static Vertex3f Max(params Vertex3f[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float x = (float)float.MinValue, y = (float)float.MinValue, z = (float)float.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (float)Math.Max(x, v[i].x);
				y = (float)Math.Max(y, v[i].y);
				z = (float)Math.Max(z, v[i].z);
			}

			return (new Vertex3f(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3f holding the maximum values.
		/// </returns>
		public unsafe static Vertex3f Max(Vertex3f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float x = (float)float.MinValue, y = (float)float.MinValue, z = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (float)Math.Max(x, v[i].x);
				y = (float)Math.Max(y, v[i].y);
				z = (float)Math.Max(z, v[i].z);
			}

			return (new Vertex3f(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3f"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3f[] v, out Vertex3f min, out Vertex3f max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue, minz = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue, maxz = (float)float.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (float)Math.Min(minx, v[i].x); miny = (float)Math.Min(miny, v[i].y); minz = (float)Math.Min(minz, v[i].z);
				maxx = (float)Math.Max(maxx, v[i].x); maxy = (float)Math.Max(maxy, v[i].y); maxz = (float)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3f(minx, miny, minz);
			max = new Vertex3f(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3f"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3f* v, uint count, out Vertex3f min, out Vertex3f max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue, minz = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue, maxz = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (float)Math.Min(minx, v[i].x); miny = (float)Math.Min(miny, v[i].y); minz = (float)Math.Min(minz, v[i].z);
				maxx = (float)Math.Max(maxx, v[i].x); maxy = (float)Math.Max(maxy, v[i].y); maxz = (float)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3f(minx, miny, minz);
			max = new Vertex3f(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3f Minimum = new Vertex3f(float.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3f Maximum = new Vertex3f(float.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3f is equal to another Vertex3f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3f"/> to compare with this Vertex3f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3f other, float precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3f is equal to another Vertex3f.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3f"/> to compare with this Vertex3f.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3f other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3f))
				return (false);
			
			return (Equals((Vertex3f)obj));
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
	/// Vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3d: X={x} Y={y} Z={z}")]
	public struct Vertex3d : IEquatable<Vertex3d>
	{
		#region Constructors

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the value of every component.
		/// </param>
		public Vertex3d(double v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/> that specify the value of every component.
		/// </param>
		public Vertex3d(double[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3d constructor.
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
		public Vertex3d(double x, double y, double z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 24;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3d to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3d operator -(Vertex3d v)
		{
			return (new Vertex3d((double)(-v.x), (double)(-v.y), (double)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3d operator +(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = (double)(v1.x + v2.x);
			v.y = (double)(v1.y + v2.y);
			v.z = (double)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3d operator -(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = (double)(v1.x - v2.x);
			v.y = (double)(v1.y - v2.y);
			v.z = (double)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator *(Vertex3d v1, float scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator *(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator /(Vertex3d v1, float scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator /(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3d v1, Vertex3d v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3d v1, Vertex3d v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

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
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator double[](Vertex3d a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3d a)
		{
			return new Vertex4d(a.x, a.y, a.z, 1.0);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3d a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3d a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
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

		/// <summary>
		/// Get the minimum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3d holding the minumum values.
		/// </returns>
		public static Vertex3d Min(params Vertex3d[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			double x = (double)double.MaxValue, y = (double)double.MaxValue, z = (double)double.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (double)Math.Min(x, v[i].x);
				y = (double)Math.Min(y, v[i].y);
				z = (double)Math.Min(z, v[i].z);
			}

			return (new Vertex3d(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3d holding the minumum values.
		/// </returns>
		public unsafe static Vertex3d Min(Vertex3d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			double x = (double)double.MaxValue, y = (double)double.MaxValue, z = (double)double.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (double)Math.Min(x, v[i].x);
				y = (double)Math.Min(y, v[i].y);
				z = (double)Math.Min(z, v[i].z);
			}

			return (new Vertex3d(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3d holding the maximum values.
		/// </returns>
		public static Vertex3d Max(params Vertex3d[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double x = (double)double.MinValue, y = (double)double.MinValue, z = (double)double.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (double)Math.Max(x, v[i].x);
				y = (double)Math.Max(y, v[i].y);
				z = (double)Math.Max(z, v[i].z);
			}

			return (new Vertex3d(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3d holding the maximum values.
		/// </returns>
		public unsafe static Vertex3d Max(Vertex3d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double x = (double)double.MinValue, y = (double)double.MinValue, z = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (double)Math.Max(x, v[i].x);
				y = (double)Math.Max(y, v[i].y);
				z = (double)Math.Max(z, v[i].z);
			}

			return (new Vertex3d(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3d"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3d[] v, out Vertex3d min, out Vertex3d max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue, minz = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue, maxz = (double)double.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (double)Math.Min(minx, v[i].x); miny = (double)Math.Min(miny, v[i].y); minz = (double)Math.Min(minz, v[i].z);
				maxx = (double)Math.Max(maxx, v[i].x); maxy = (double)Math.Max(maxy, v[i].y); maxz = (double)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3d(minx, miny, minz);
			max = new Vertex3d(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3d"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3d* v, uint count, out Vertex3d min, out Vertex3d max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue, minz = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue, maxz = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (double)Math.Min(minx, v[i].x); miny = (double)Math.Min(miny, v[i].y); minz = (double)Math.Min(minz, v[i].z);
				maxx = (double)Math.Max(maxx, v[i].x); maxy = (double)Math.Max(maxy, v[i].y); maxz = (double)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3d(minx, miny, minz);
			max = new Vertex3d(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3d Zero = new Vertex3d(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3d One = new Vertex3d(1.0);

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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3d Minimum = new Vertex3d(double.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3d Maximum = new Vertex3d(double.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3d is equal to another Vertex3d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3d"/> to compare with this Vertex3d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3d other, double precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3d is equal to another Vertex3d.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3d"/> to compare with this Vertex3d.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3d other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3d))
				return (false);
			
			return (Equals((Vertex3d)obj));
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
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (HalfFloat coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[DebuggerDisplay("Vertex3hf: X={x} Y={y} Z={z}")]
	public struct Vertex3hf : IEquatable<Vertex3hf>
	{
		#region Constructors

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(HalfFloat v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(HalfFloat[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3hf constructor.
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
		public Vertex3hf(HalfFloat x, HalfFloat y, HalfFloat z)
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
		/// Structure size.
		/// </summary>
		public const int Size = 6;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3hf operator -(Vertex3hf v)
		{
			return (new Vertex3hf((HalfFloat)(-v.x), (HalfFloat)(-v.y), (HalfFloat)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
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
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
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
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
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
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator *(Vertex3hf v1, double scalar)
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
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
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
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator /(Vertex3hf v1, double scalar)
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
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
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

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

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
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator HalfFloat[](Vertex3hf a)
		{
			return new[] { a.x, a.y, a.z };
		}

		/// <summary>
		/// Cast to Vertex4hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4hf"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4hf(Vertex3hf a)
		{
			return new Vertex4hf(a.x, a.y, a.z, new HalfFloat(1.0f));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3hf a)
		{
			return new Vertex3f((float)a.x, (float)a.y, (float)a.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3hf a)
		{
			return new Vertex4f((float)a.x, (float)a.y, (float)a.z, 1.0f);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			return ((float)Math.Sqrt(ModuleSquared()));
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return (x2 + y2 + z2);
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) >= Single.Epsilon)
				this /= length;
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

		/// <summary>
		/// Get the minimum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3hf holding the minumum values.
		/// </returns>
		public static Vertex3hf Min(params Vertex3hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue, z = (HalfFloat)HalfFloat.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				x = (HalfFloat)Math.Min(x, v[i].x);
				y = (HalfFloat)Math.Min(y, v[i].y);
				z = (HalfFloat)Math.Min(z, v[i].z);
			}

			return (new Vertex3hf(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3hf holding the minumum values.
		/// </returns>
		public unsafe static Vertex3hf Min(Vertex3hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue, z = (HalfFloat)HalfFloat.MaxValue;

			for (uint i = 0; i < count; i++) {
				x = (HalfFloat)Math.Min(x, v[i].x);
				y = (HalfFloat)Math.Min(y, v[i].y);
				z = (HalfFloat)Math.Min(z, v[i].z);
			}

			return (new Vertex3hf(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf[]"/> that specifies the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex3hf holding the maximum values.
		/// </returns>
		public static Vertex3hf Max(params Vertex3hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue, z = (HalfFloat)HalfFloat.MinValue;

			for (int i = 0; i < v.Length; i++) {
				x = (HalfFloat)Math.Max(x, v[i].x);
				y = (HalfFloat)Math.Max(y, v[i].y);
				z = (HalfFloat)Math.Max(z, v[i].z);
			}

			return (new Vertex3hf(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex3hf holding the maximum values.
		/// </returns>
		public unsafe static Vertex3hf Max(Vertex3hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue, z = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				x = (HalfFloat)Math.Max(x, v[i].x);
				y = (HalfFloat)Math.Max(y, v[i].y);
				z = (HalfFloat)Math.Max(z, v[i].z);
			}

			return (new Vertex3hf(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3hf"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex3hf[] v, out Vertex3hf min, out Vertex3hf max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue, minz = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue, maxz = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				minx = (HalfFloat)Math.Min(minx, v[i].x); miny = (HalfFloat)Math.Min(miny, v[i].y); minz = (HalfFloat)Math.Min(minz, v[i].z);
				maxx = (HalfFloat)Math.Max(maxx, v[i].x); maxy = (HalfFloat)Math.Max(maxy, v[i].y); maxz = (HalfFloat)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3hf(minx, miny, minz);
			max = new Vertex3hf(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex3hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex3hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex3hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex3hf"/> that returns the maximum value.
		/// </param>
		public unsafe static void MinMax(Vertex3hf* v, uint count, out Vertex3hf min, out Vertex3hf max)
		{
			if (v == null)
				throw new ArgumentNullException("v");
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue, minz = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue, maxz = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				minx = (HalfFloat)Math.Min(minx, v[i].x); miny = (HalfFloat)Math.Min(miny, v[i].y); minz = (HalfFloat)Math.Min(minz, v[i].z);
				maxx = (HalfFloat)Math.Max(maxx, v[i].x); maxy = (HalfFloat)Math.Max(maxy, v[i].y); maxz = (HalfFloat)Math.Max(maxz, v[i].z);
			}

			min = new Vertex3hf(minx, miny, minz);
			max = new Vertex3hf(maxx, maxy, maxz);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3hf Zero = new Vertex3hf(new HalfFloat(0.0f));

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3hf One = new Vertex3hf(new HalfFloat(1.0f));

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3hf UnitX = new Vertex3hf(new HalfFloat(1.0f), new HalfFloat(0.0f), new HalfFloat(0.0f));

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3hf UnitY = new Vertex3hf(new HalfFloat(0.0f), new HalfFloat(1.0f), new HalfFloat(0.0f));

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3hf UnitZ = new Vertex3hf(new HalfFloat(0.0f), new HalfFloat(0.0f), new HalfFloat(1.0f));

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex3hf Minimum = new Vertex3hf(new HalfFloat(HalfFloat.MinValue));

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex3hf Maximum = new Vertex3hf(new HalfFloat(HalfFloat.MaxValue));

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex3hf is equal to another Vertex3hf, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3hf"/> to compare with this Vertex3hf.
		/// </param>
		/// <param name="precision">
		/// The <see cref="HalfFloat"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3hf is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3hf other, HalfFloat precision)
		{
			if (Math.Abs(x - other.x) > precision)
				return (false);
			if (Math.Abs(y - other.y) > precision)
				return (false);
			if (Math.Abs(z - other.z) > precision)
				return (false);

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex3hf is equal to another Vertex3hf.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex3hf"/> to compare with this Vertex3hf.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex3hf is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex3hf other)
		{
			return (x == other.x && y == other.y && z == other.z);
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
			if (obj.GetType() != typeof(Vertex3hf))
				return (false);
			
			return (Equals((Vertex3hf)obj));
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

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3hf.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3hf.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

}
