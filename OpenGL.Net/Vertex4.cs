
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
	[DebuggerDisplay("Vertex4ub: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ub : IEquatable<Vertex4ub>
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
		/// A <see cref="T:byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex4ub(byte[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (byte)1) { }

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
		public Vertex4ub(byte x, byte y, byte z) : this(x, y, z, 1) { }

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
			return (Vertex3ub)v1 + (Vertex3ub)v2;
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
			return (Vertex3ub)v1 - (Vertex3ub)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator *(Vertex4ub v1, byte scalar)
		{
			return new Vertex4ub((byte)(v1.x * scalar), (byte)(v1.y * scalar), (byte)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator *(Vertex4ub v1, float scalar)
		{
			return new Vertex4ub((byte)(v1.x * scalar), (byte)(v1.y * scalar), (byte)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator /(Vertex4ub v1, byte scalar)
		{
			return new Vertex4ub((byte)(v1.x / scalar), (byte)(v1.y / scalar), (byte)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ub operator /(Vertex4ub v1, float scalar)
		{
			return new Vertex4ub((byte)(v1.x / scalar), (byte)(v1.y / scalar), (byte)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator byte[](Vertex4ub a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3ub operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3ub(Vertex4ub v)
		{
			return new Vertex3ub((byte)((float)v.x / v.w), (byte)((float)v.y / v.w), (byte)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4ub v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4ub v)
		{
			Vertex3ub v3 = (Vertex3ub)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4ub v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3ub)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ub holding the minumum values.
		/// </returns>
		public static Vertex4ub Min(params Vertex4ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue, z = (byte)byte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				byte w = v[i].w;
				x = (byte)Math.Min(x, v[i].x / w);
				y = (byte)Math.Min(y, v[i].y / w);
				z = (byte)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4ub(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ub holding the minumum values.
		/// </returns>
		public static unsafe Vertex4ub Min(Vertex4ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			byte x = (byte)byte.MaxValue, y = (byte)byte.MaxValue, z = (byte)byte.MaxValue;

			for (uint i = 0; i < count; i++) {
				byte w = v[i].w;
				x = (byte)Math.Min(x, v[i].x / w);
				y = (byte)Math.Min(y, v[i].y / w);
				z = (byte)Math.Min(z, v[i].z / w);
			}

			return new Vertex4ub(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ub holding the maximum values.
		/// </returns>
		public static Vertex4ub Max(params Vertex4ub[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue, z = (byte)byte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				byte w = v[i].w;
				x = (byte)Math.Max(x, v[i].x / w);
				y = (byte)Math.Max(y, v[i].y / w);
				z = (byte)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4ub(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ub holding the maximum values.
		/// </returns>
		public static unsafe Vertex4ub Max(Vertex4ub* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			byte x = (byte)byte.MinValue, y = (byte)byte.MinValue, z = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				byte w = v[i].w;
				x = (byte)Math.Max(x, v[i].x / w);
				y = (byte)Math.Max(y, v[i].y / w);
				z = (byte)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4ub(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4ub"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4ub[] v, out Vertex4ub min, out Vertex4ub max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue, minz = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue, maxz = (byte)byte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				byte w = (byte)v[i].w, x = (byte)(v[i].x / w), y = (byte)(v[i].y / w), z = (byte)(v[i].z / w);
				minx = (byte)Math.Min(minx, x); miny = (byte)Math.Min(miny, y); minz = (byte)Math.Min(minz, z);
				maxx = (byte)Math.Max(maxx, x); maxy = (byte)Math.Max(maxy, y); maxz = (byte)Math.Max(maxz, z);
			}

			min = new Vertex4ub(minx, miny, minz);
			max = new Vertex4ub(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4ub, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ub*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4ub"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4ub"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4ub* v, uint count, out Vertex4ub min, out Vertex4ub max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			byte minx = (byte)byte.MaxValue, miny = (byte)byte.MaxValue, minz = (byte)byte.MaxValue;
			byte maxx = (byte)byte.MinValue, maxy = (byte)byte.MinValue, maxz = (byte)byte.MinValue;

			for (uint i = 0; i < count; i++) {
				byte w = (byte)v[i].w, x = (byte)(v[i].x / w), y = (byte)(v[i].y / w), z = (byte)(v[i].z / w);
				minx = (byte)Math.Min(minx, x); miny = (byte)Math.Min(miny, y); minz = (byte)Math.Min(minz, z);
				maxx = (byte)Math.Max(maxx, x); maxy = (byte)Math.Max(maxy, y); maxz = (byte)Math.Max(maxz, z);
			}

			min = new Vertex4ub(minx, miny, minz);
			max = new Vertex4ub(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4ub Minimum = new Vertex4ub(byte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4ub Maximum = new Vertex4ub(byte.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4ub is equal to another Vertex4ub, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4ub"/> to compare with this Vertex4ub.
		/// </param>
		/// <param name="precision">
		/// The <see cref="byte"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4ub is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4ub other, byte precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4ub is equal to another Vertex4ub.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4ub"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4ub other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4ub))
				return (false);
			
			return (Equals((Vertex4ub)obj));
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
	[DebuggerDisplay("Vertex4b: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4b : IEquatable<Vertex4b>
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
		/// A <see cref="T:sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex4b(sbyte[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (sbyte)1) { }

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
		public Vertex4b(sbyte x, sbyte y, sbyte z) : this(x, y, z, 1) { }

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
		/// The Vertex4b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4b operator -(Vertex4b v)
		{
			return new Vertex4b((sbyte)(-v.x), (sbyte)(-v.y), (sbyte)(-v.z), (sbyte)(-v.w));
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
			return (Vertex3b)v1 + (Vertex3b)v2;
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
			return (Vertex3b)v1 - (Vertex3b)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator *(Vertex4b v1, sbyte scalar)
		{
			return new Vertex4b((sbyte)(v1.x * scalar), (sbyte)(v1.y * scalar), (sbyte)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator *(Vertex4b v1, float scalar)
		{
			return new Vertex4b((sbyte)(v1.x * scalar), (sbyte)(v1.y * scalar), (sbyte)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator /(Vertex4b v1, sbyte scalar)
		{
			return new Vertex4b((sbyte)(v1.x / scalar), (sbyte)(v1.y / scalar), (sbyte)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4b operator /(Vertex4b v1, float scalar)
		{
			return new Vertex4b((sbyte)(v1.x / scalar), (sbyte)(v1.y / scalar), (sbyte)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator sbyte[](Vertex4b a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3b operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3b(Vertex4b v)
		{
			return new Vertex3b((sbyte)((float)v.x / v.w), (sbyte)((float)v.y / v.w), (sbyte)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4b v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4b v)
		{
			Vertex3b v3 = (Vertex3b)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4b v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3b)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4b holding the minumum values.
		/// </returns>
		public static Vertex4b Min(params Vertex4b[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue, z = (sbyte)sbyte.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				sbyte w = v[i].w;
				x = (sbyte)Math.Min(x, v[i].x / w);
				y = (sbyte)Math.Min(y, v[i].y / w);
				z = (sbyte)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4b(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4b holding the minumum values.
		/// </returns>
		public static unsafe Vertex4b Min(Vertex4b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			sbyte x = (sbyte)sbyte.MaxValue, y = (sbyte)sbyte.MaxValue, z = (sbyte)sbyte.MaxValue;

			for (uint i = 0; i < count; i++) {
				sbyte w = v[i].w;
				x = (sbyte)Math.Min(x, v[i].x / w);
				y = (sbyte)Math.Min(y, v[i].y / w);
				z = (sbyte)Math.Min(z, v[i].z / w);
			}

			return new Vertex4b(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4b holding the maximum values.
		/// </returns>
		public static Vertex4b Max(params Vertex4b[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue, z = (sbyte)sbyte.MinValue;

			for (int i = 0; i < v.Length; i++) {
				sbyte w = v[i].w;
				x = (sbyte)Math.Max(x, v[i].x / w);
				y = (sbyte)Math.Max(y, v[i].y / w);
				z = (sbyte)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4b(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4b holding the maximum values.
		/// </returns>
		public static unsafe Vertex4b Max(Vertex4b* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			sbyte x = (sbyte)sbyte.MinValue, y = (sbyte)sbyte.MinValue, z = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				sbyte w = v[i].w;
				x = (sbyte)Math.Max(x, v[i].x / w);
				y = (sbyte)Math.Max(y, v[i].y / w);
				z = (sbyte)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4b(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4b"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4b[] v, out Vertex4b min, out Vertex4b max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue, minz = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue, maxz = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				sbyte w = (sbyte)v[i].w, x = (sbyte)(v[i].x / w), y = (sbyte)(v[i].y / w), z = (sbyte)(v[i].z / w);
				minx = (sbyte)Math.Min(minx, x); miny = (sbyte)Math.Min(miny, y); minz = (sbyte)Math.Min(minz, z);
				maxx = (sbyte)Math.Max(maxx, x); maxy = (sbyte)Math.Max(maxy, y); maxz = (sbyte)Math.Max(maxz, z);
			}

			min = new Vertex4b(minx, miny, minz);
			max = new Vertex4b(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4b, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4b*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4b"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4b"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4b* v, uint count, out Vertex4b min, out Vertex4b max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			sbyte minx = (sbyte)sbyte.MaxValue, miny = (sbyte)sbyte.MaxValue, minz = (sbyte)sbyte.MaxValue;
			sbyte maxx = (sbyte)sbyte.MinValue, maxy = (sbyte)sbyte.MinValue, maxz = (sbyte)sbyte.MinValue;

			for (uint i = 0; i < count; i++) {
				sbyte w = (sbyte)v[i].w, x = (sbyte)(v[i].x / w), y = (sbyte)(v[i].y / w), z = (sbyte)(v[i].z / w);
				minx = (sbyte)Math.Min(minx, x); miny = (sbyte)Math.Min(miny, y); minz = (sbyte)Math.Min(minz, z);
				maxx = (sbyte)Math.Max(maxx, x); maxy = (sbyte)Math.Max(maxy, y); maxz = (sbyte)Math.Max(maxz, z);
			}

			min = new Vertex4b(minx, miny, minz);
			max = new Vertex4b(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4b Minimum = new Vertex4b(sbyte.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4b Maximum = new Vertex4b(sbyte.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4b is equal to another Vertex4b, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4b"/> to compare with this Vertex4b.
		/// </param>
		/// <param name="precision">
		/// The <see cref="sbyte"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4b is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4b other, sbyte precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4b is equal to another Vertex4b.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4b"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4b other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4b))
				return (false);
			
			return (Equals((Vertex4b)obj));
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
	[DebuggerDisplay("Vertex4us: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4us : IEquatable<Vertex4us>
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
		/// A <see cref="T:ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex4us(ushort[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (ushort)1) { }

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
		public Vertex4us(ushort x, ushort y, ushort z) : this(x, y, z, 1) { }

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
			return (Vertex3us)v1 + (Vertex3us)v2;
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
			return (Vertex3us)v1 - (Vertex3us)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator *(Vertex4us v1, ushort scalar)
		{
			return new Vertex4us((ushort)(v1.x * scalar), (ushort)(v1.y * scalar), (ushort)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator *(Vertex4us v1, float scalar)
		{
			return new Vertex4us((ushort)(v1.x * scalar), (ushort)(v1.y * scalar), (ushort)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator /(Vertex4us v1, ushort scalar)
		{
			return new Vertex4us((ushort)(v1.x / scalar), (ushort)(v1.y / scalar), (ushort)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4us operator /(Vertex4us v1, float scalar)
		{
			return new Vertex4us((ushort)(v1.x / scalar), (ushort)(v1.y / scalar), (ushort)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator ushort[](Vertex4us a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3us operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3us(Vertex4us v)
		{
			return new Vertex3us((ushort)((float)v.x / v.w), (ushort)((float)v.y / v.w), (ushort)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4us v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4us v)
		{
			Vertex3us v3 = (Vertex3us)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4us v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3us)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4us holding the minumum values.
		/// </returns>
		public static Vertex4us Min(params Vertex4us[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue, z = (ushort)ushort.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				ushort w = v[i].w;
				x = (ushort)Math.Min(x, v[i].x / w);
				y = (ushort)Math.Min(y, v[i].y / w);
				z = (ushort)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4us(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4us holding the minumum values.
		/// </returns>
		public static unsafe Vertex4us Min(Vertex4us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			ushort x = (ushort)ushort.MaxValue, y = (ushort)ushort.MaxValue, z = (ushort)ushort.MaxValue;

			for (uint i = 0; i < count; i++) {
				ushort w = v[i].w;
				x = (ushort)Math.Min(x, v[i].x / w);
				y = (ushort)Math.Min(y, v[i].y / w);
				z = (ushort)Math.Min(z, v[i].z / w);
			}

			return new Vertex4us(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4us holding the maximum values.
		/// </returns>
		public static Vertex4us Max(params Vertex4us[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue, z = (ushort)ushort.MinValue;

			for (int i = 0; i < v.Length; i++) {
				ushort w = v[i].w;
				x = (ushort)Math.Max(x, v[i].x / w);
				y = (ushort)Math.Max(y, v[i].y / w);
				z = (ushort)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4us(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4us holding the maximum values.
		/// </returns>
		public static unsafe Vertex4us Max(Vertex4us* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			ushort x = (ushort)ushort.MinValue, y = (ushort)ushort.MinValue, z = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				ushort w = v[i].w;
				x = (ushort)Math.Max(x, v[i].x / w);
				y = (ushort)Math.Max(y, v[i].y / w);
				z = (ushort)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4us(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4us"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4us[] v, out Vertex4us min, out Vertex4us max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue, minz = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue, maxz = (ushort)ushort.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				ushort w = (ushort)v[i].w, x = (ushort)(v[i].x / w), y = (ushort)(v[i].y / w), z = (ushort)(v[i].z / w);
				minx = (ushort)Math.Min(minx, x); miny = (ushort)Math.Min(miny, y); minz = (ushort)Math.Min(minz, z);
				maxx = (ushort)Math.Max(maxx, x); maxy = (ushort)Math.Max(maxy, y); maxz = (ushort)Math.Max(maxz, z);
			}

			min = new Vertex4us(minx, miny, minz);
			max = new Vertex4us(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4us, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4us*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4us"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4us"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4us* v, uint count, out Vertex4us min, out Vertex4us max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			ushort minx = (ushort)ushort.MaxValue, miny = (ushort)ushort.MaxValue, minz = (ushort)ushort.MaxValue;
			ushort maxx = (ushort)ushort.MinValue, maxy = (ushort)ushort.MinValue, maxz = (ushort)ushort.MinValue;

			for (uint i = 0; i < count; i++) {
				ushort w = (ushort)v[i].w, x = (ushort)(v[i].x / w), y = (ushort)(v[i].y / w), z = (ushort)(v[i].z / w);
				minx = (ushort)Math.Min(minx, x); miny = (ushort)Math.Min(miny, y); minz = (ushort)Math.Min(minz, z);
				maxx = (ushort)Math.Max(maxx, x); maxy = (ushort)Math.Max(maxy, y); maxz = (ushort)Math.Max(maxz, z);
			}

			min = new Vertex4us(minx, miny, minz);
			max = new Vertex4us(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4us Minimum = new Vertex4us(ushort.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4us Maximum = new Vertex4us(ushort.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4us is equal to another Vertex4us, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4us"/> to compare with this Vertex4us.
		/// </param>
		/// <param name="precision">
		/// The <see cref="ushort"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4us is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4us other, ushort precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4us is equal to another Vertex4us.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4us"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4us other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4us))
				return (false);
			
			return (Equals((Vertex4us)obj));
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
	[DebuggerDisplay("Vertex4s: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4s : IEquatable<Vertex4s>
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
		/// A <see cref="T:short[]"/> that specify the value of every component.
		/// </param>
		public Vertex4s(short[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (short)1) { }

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
		public Vertex4s(short x, short y, short z) : this(x, y, z, 1) { }

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
		/// The Vertex4s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4s operator -(Vertex4s v)
		{
			return new Vertex4s((short)(-v.x), (short)(-v.y), (short)(-v.z), (short)(-v.w));
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
			return (Vertex3s)v1 + (Vertex3s)v2;
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
			return (Vertex3s)v1 - (Vertex3s)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator *(Vertex4s v1, short scalar)
		{
			return new Vertex4s((short)(v1.x * scalar), (short)(v1.y * scalar), (short)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator *(Vertex4s v1, float scalar)
		{
			return new Vertex4s((short)(v1.x * scalar), (short)(v1.y * scalar), (short)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator /(Vertex4s v1, short scalar)
		{
			return new Vertex4s((short)(v1.x / scalar), (short)(v1.y / scalar), (short)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4s operator /(Vertex4s v1, float scalar)
		{
			return new Vertex4s((short)(v1.x / scalar), (short)(v1.y / scalar), (short)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:short[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator short[](Vertex4s a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3s operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3s(Vertex4s v)
		{
			return new Vertex3s((short)((float)v.x / v.w), (short)((float)v.y / v.w), (short)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4s v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4s v)
		{
			Vertex3s v3 = (Vertex3s)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4s v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3s)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4s holding the minumum values.
		/// </returns>
		public static Vertex4s Min(params Vertex4s[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			short x = (short)short.MaxValue, y = (short)short.MaxValue, z = (short)short.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				short w = v[i].w;
				x = (short)Math.Min(x, v[i].x / w);
				y = (short)Math.Min(y, v[i].y / w);
				z = (short)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4s(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4s holding the minumum values.
		/// </returns>
		public static unsafe Vertex4s Min(Vertex4s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			short x = (short)short.MaxValue, y = (short)short.MaxValue, z = (short)short.MaxValue;

			for (uint i = 0; i < count; i++) {
				short w = v[i].w;
				x = (short)Math.Min(x, v[i].x / w);
				y = (short)Math.Min(y, v[i].y / w);
				z = (short)Math.Min(z, v[i].z / w);
			}

			return new Vertex4s(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4s holding the maximum values.
		/// </returns>
		public static Vertex4s Max(params Vertex4s[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			short x = (short)short.MinValue, y = (short)short.MinValue, z = (short)short.MinValue;

			for (int i = 0; i < v.Length; i++) {
				short w = v[i].w;
				x = (short)Math.Max(x, v[i].x / w);
				y = (short)Math.Max(y, v[i].y / w);
				z = (short)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4s(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4s holding the maximum values.
		/// </returns>
		public static unsafe Vertex4s Max(Vertex4s* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			short x = (short)short.MinValue, y = (short)short.MinValue, z = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				short w = v[i].w;
				x = (short)Math.Max(x, v[i].x / w);
				y = (short)Math.Max(y, v[i].y / w);
				z = (short)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4s(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4s"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4s[] v, out Vertex4s min, out Vertex4s max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue, minz = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue, maxz = (short)short.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				short w = (short)v[i].w, x = (short)(v[i].x / w), y = (short)(v[i].y / w), z = (short)(v[i].z / w);
				minx = (short)Math.Min(minx, x); miny = (short)Math.Min(miny, y); minz = (short)Math.Min(minz, z);
				maxx = (short)Math.Max(maxx, x); maxy = (short)Math.Max(maxy, y); maxz = (short)Math.Max(maxz, z);
			}

			min = new Vertex4s(minx, miny, minz);
			max = new Vertex4s(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4s, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4s*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4s"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4s"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4s* v, uint count, out Vertex4s min, out Vertex4s max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			short minx = (short)short.MaxValue, miny = (short)short.MaxValue, minz = (short)short.MaxValue;
			short maxx = (short)short.MinValue, maxy = (short)short.MinValue, maxz = (short)short.MinValue;

			for (uint i = 0; i < count; i++) {
				short w = (short)v[i].w, x = (short)(v[i].x / w), y = (short)(v[i].y / w), z = (short)(v[i].z / w);
				minx = (short)Math.Min(minx, x); miny = (short)Math.Min(miny, y); minz = (short)Math.Min(minz, z);
				maxx = (short)Math.Max(maxx, x); maxy = (short)Math.Max(maxy, y); maxz = (short)Math.Max(maxz, z);
			}

			min = new Vertex4s(minx, miny, minz);
			max = new Vertex4s(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4s Minimum = new Vertex4s(short.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4s Maximum = new Vertex4s(short.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4s is equal to another Vertex4s, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4s"/> to compare with this Vertex4s.
		/// </param>
		/// <param name="precision">
		/// The <see cref="short"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4s is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4s other, short precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4s is equal to another Vertex4s.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4s"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4s other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4s))
				return (false);
			
			return (Equals((Vertex4s)obj));
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
	[DebuggerDisplay("Vertex4ui: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ui : IEquatable<Vertex4ui>
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
		/// A <see cref="T:uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex4ui(uint[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (uint)1) { }

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
		public Vertex4ui(uint x, uint y, uint z) : this(x, y, z, 1) { }

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

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 16;

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
			return (Vertex3ui)v1 + (Vertex3ui)v2;
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
			return (Vertex3ui)v1 - (Vertex3ui)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator *(Vertex4ui v1, uint scalar)
		{
			return new Vertex4ui((uint)(v1.x * scalar), (uint)(v1.y * scalar), (uint)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator *(Vertex4ui v1, float scalar)
		{
			return new Vertex4ui((uint)(v1.x * scalar), (uint)(v1.y * scalar), (uint)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator /(Vertex4ui v1, uint scalar)
		{
			return new Vertex4ui((uint)(v1.x / scalar), (uint)(v1.y / scalar), (uint)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4ui operator /(Vertex4ui v1, float scalar)
		{
			return new Vertex4ui((uint)(v1.x / scalar), (uint)(v1.y / scalar), (uint)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:uint[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator uint[](Vertex4ui a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3ui operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3ui(Vertex4ui v)
		{
			return new Vertex3ui((uint)((float)v.x / v.w), (uint)((float)v.y / v.w), (uint)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4ui v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4ui v)
		{
			Vertex3ui v3 = (Vertex3ui)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4ui v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3ui)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ui holding the minumum values.
		/// </returns>
		public static Vertex4ui Min(params Vertex4ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue, z = (uint)uint.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				uint w = v[i].w;
				x = (uint)Math.Min(x, v[i].x / w);
				y = (uint)Math.Min(y, v[i].y / w);
				z = (uint)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4ui(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ui holding the minumum values.
		/// </returns>
		public static unsafe Vertex4ui Min(Vertex4ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			uint x = (uint)uint.MaxValue, y = (uint)uint.MaxValue, z = (uint)uint.MaxValue;

			for (uint i = 0; i < count; i++) {
				uint w = v[i].w;
				x = (uint)Math.Min(x, v[i].x / w);
				y = (uint)Math.Min(y, v[i].y / w);
				z = (uint)Math.Min(z, v[i].z / w);
			}

			return new Vertex4ui(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ui holding the maximum values.
		/// </returns>
		public static Vertex4ui Max(params Vertex4ui[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue, z = (uint)uint.MinValue;

			for (int i = 0; i < v.Length; i++) {
				uint w = v[i].w;
				x = (uint)Math.Max(x, v[i].x / w);
				y = (uint)Math.Max(y, v[i].y / w);
				z = (uint)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4ui(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4ui holding the maximum values.
		/// </returns>
		public static unsafe Vertex4ui Max(Vertex4ui* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			uint x = (uint)uint.MinValue, y = (uint)uint.MinValue, z = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				uint w = v[i].w;
				x = (uint)Math.Max(x, v[i].x / w);
				y = (uint)Math.Max(y, v[i].y / w);
				z = (uint)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4ui(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4ui"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4ui[] v, out Vertex4ui min, out Vertex4ui max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue, minz = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue, maxz = (uint)uint.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				uint w = (uint)v[i].w, x = (uint)(v[i].x / w), y = (uint)(v[i].y / w), z = (uint)(v[i].z / w);
				minx = (uint)Math.Min(minx, x); miny = (uint)Math.Min(miny, y); minz = (uint)Math.Min(minz, z);
				maxx = (uint)Math.Max(maxx, x); maxy = (uint)Math.Max(maxy, y); maxz = (uint)Math.Max(maxz, z);
			}

			min = new Vertex4ui(minx, miny, minz);
			max = new Vertex4ui(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4ui, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4ui*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4ui"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4ui"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4ui* v, uint count, out Vertex4ui min, out Vertex4ui max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			uint minx = (uint)uint.MaxValue, miny = (uint)uint.MaxValue, minz = (uint)uint.MaxValue;
			uint maxx = (uint)uint.MinValue, maxy = (uint)uint.MinValue, maxz = (uint)uint.MinValue;

			for (uint i = 0; i < count; i++) {
				uint w = (uint)v[i].w, x = (uint)(v[i].x / w), y = (uint)(v[i].y / w), z = (uint)(v[i].z / w);
				minx = (uint)Math.Min(minx, x); miny = (uint)Math.Min(miny, y); minz = (uint)Math.Min(minz, z);
				maxx = (uint)Math.Max(maxx, x); maxy = (uint)Math.Max(maxy, y); maxz = (uint)Math.Max(maxz, z);
			}

			min = new Vertex4ui(minx, miny, minz);
			max = new Vertex4ui(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4ui Minimum = new Vertex4ui(uint.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4ui Maximum = new Vertex4ui(uint.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4ui is equal to another Vertex4ui, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4ui"/> to compare with this Vertex4ui.
		/// </param>
		/// <param name="precision">
		/// The <see cref="uint"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4ui is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4ui other, uint precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4ui is equal to another Vertex4ui.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4ui"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4ui other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4ui))
				return (false);
			
			return (Equals((Vertex4ui)obj));
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
	[DebuggerDisplay("Vertex4i: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4i : IEquatable<Vertex4i>
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
		/// A <see cref="T:int[]"/> that specify the value of every component.
		/// </param>
		public Vertex4i(int[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (int)1) { }

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
		public Vertex4i(int x, int y, int z) : this(x, y, z, 1) { }

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
		/// The Vertex4i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4i operator -(Vertex4i v)
		{
			return new Vertex4i((int)(-v.x), (int)(-v.y), (int)(-v.z), (int)(-v.w));
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
			return (Vertex3i)v1 + (Vertex3i)v2;
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
			return (Vertex3i)v1 - (Vertex3i)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator *(Vertex4i v1, int scalar)
		{
			return new Vertex4i((int)(v1.x * scalar), (int)(v1.y * scalar), (int)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator *(Vertex4i v1, float scalar)
		{
			return new Vertex4i((int)(v1.x * scalar), (int)(v1.y * scalar), (int)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator /(Vertex4i v1, int scalar)
		{
			return new Vertex4i((int)(v1.x / scalar), (int)(v1.y / scalar), (int)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4i operator /(Vertex4i v1, float scalar)
		{
			return new Vertex4i((int)(v1.x / scalar), (int)(v1.y / scalar), (int)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:int[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator int[](Vertex4i a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3i operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3i(Vertex4i v)
		{
			return new Vertex3i((int)((float)v.x / v.w), (int)((float)v.y / v.w), (int)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4i v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4i v)
		{
			Vertex3i v3 = (Vertex3i)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4i v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3i)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4i holding the minumum values.
		/// </returns>
		public static Vertex4i Min(params Vertex4i[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			int x = (int)int.MaxValue, y = (int)int.MaxValue, z = (int)int.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				int w = v[i].w;
				x = (int)Math.Min(x, v[i].x / w);
				y = (int)Math.Min(y, v[i].y / w);
				z = (int)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4i(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4i holding the minumum values.
		/// </returns>
		public static unsafe Vertex4i Min(Vertex4i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			int x = (int)int.MaxValue, y = (int)int.MaxValue, z = (int)int.MaxValue;

			for (uint i = 0; i < count; i++) {
				int w = v[i].w;
				x = (int)Math.Min(x, v[i].x / w);
				y = (int)Math.Min(y, v[i].y / w);
				z = (int)Math.Min(z, v[i].z / w);
			}

			return new Vertex4i(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4i holding the maximum values.
		/// </returns>
		public static Vertex4i Max(params Vertex4i[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			int x = (int)int.MinValue, y = (int)int.MinValue, z = (int)int.MinValue;

			for (int i = 0; i < v.Length; i++) {
				int w = v[i].w;
				x = (int)Math.Max(x, v[i].x / w);
				y = (int)Math.Max(y, v[i].y / w);
				z = (int)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4i(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4i holding the maximum values.
		/// </returns>
		public static unsafe Vertex4i Max(Vertex4i* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			int x = (int)int.MinValue, y = (int)int.MinValue, z = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				int w = v[i].w;
				x = (int)Math.Max(x, v[i].x / w);
				y = (int)Math.Max(y, v[i].y / w);
				z = (int)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4i(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4i"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4i[] v, out Vertex4i min, out Vertex4i max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue, minz = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue, maxz = (int)int.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				int w = (int)v[i].w, x = (int)(v[i].x / w), y = (int)(v[i].y / w), z = (int)(v[i].z / w);
				minx = (int)Math.Min(minx, x); miny = (int)Math.Min(miny, y); minz = (int)Math.Min(minz, z);
				maxx = (int)Math.Max(maxx, x); maxy = (int)Math.Max(maxy, y); maxz = (int)Math.Max(maxz, z);
			}

			min = new Vertex4i(minx, miny, minz);
			max = new Vertex4i(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4i, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4i*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4i"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4i"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4i* v, uint count, out Vertex4i min, out Vertex4i max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			int minx = (int)int.MaxValue, miny = (int)int.MaxValue, minz = (int)int.MaxValue;
			int maxx = (int)int.MinValue, maxy = (int)int.MinValue, maxz = (int)int.MinValue;

			for (uint i = 0; i < count; i++) {
				int w = (int)v[i].w, x = (int)(v[i].x / w), y = (int)(v[i].y / w), z = (int)(v[i].z / w);
				minx = (int)Math.Min(minx, x); miny = (int)Math.Min(miny, y); minz = (int)Math.Min(minz, z);
				maxx = (int)Math.Max(maxx, x); maxy = (int)Math.Max(maxy, y); maxz = (int)Math.Max(maxz, z);
			}

			min = new Vertex4i(minx, miny, minz);
			max = new Vertex4i(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4i Minimum = new Vertex4i(int.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4i Maximum = new Vertex4i(int.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4i is equal to another Vertex4i, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4i"/> to compare with this Vertex4i.
		/// </param>
		/// <param name="precision">
		/// The <see cref="int"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4i is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4i other, int precision)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4i is equal to another Vertex4i.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4i"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4i other)
		{
			bool undefined = Math.Abs(w) <= 0;
			bool otherUndefined = Math.Abs(other.w) <= 0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4i))
				return (false);
			
			return (Equals((Vertex4i)obj));
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
	[DebuggerDisplay("Vertex4f: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4f : IEquatable<Vertex4f>
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
		/// A <see cref="T:float[]"/> that specify the value of every component.
		/// </param>
		public Vertex4f(float[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (float)1.0f) { }

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
		public Vertex4f(float x, float y, float z) : this(x, y, z, 1.0f) { }

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
		/// The Vertex4f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4f operator -(Vertex4f v)
		{
			return new Vertex4f((float)(-v.x), (float)(-v.y), (float)(-v.z), (float)(-v.w));
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
			return (Vertex3f)v1 + (Vertex3f)v2;
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
			return (Vertex3f)v1 - (Vertex3f)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v1, float scalar)
		{
			return new Vertex4f((float)(v1.x * scalar), (float)(v1.y * scalar), (float)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4f operator /(Vertex4f v1, float scalar)
		{
			return new Vertex4f((float)(v1.x / scalar), (float)(v1.y / scalar), (float)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator float[](Vertex4f a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4f v)
		{
			return new Vertex3f((float)((float)v.x / v.w), (float)((float)v.y / v.w), (float)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4f v)
		{
			Vertex3f v3 = (Vertex3f)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4f v)
		{
			Vertex3f v3 = (Vertex3f)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4f v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3f)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4f holding the minumum values.
		/// </returns>
		public static Vertex4f Min(params Vertex4f[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

#if HAVE_NUMERICS
			Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);

			for (uint i = 0; i < v.Length; i++)
				min = Vector3.Min(min, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);

			return (new Vertex4f(min.X, min.Y, min.Z));
#else
			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				float w = v[i].w;
				x = (float)Math.Min(x, v[i].x / w);
				y = (float)Math.Min(y, v[i].y / w);
				z = (float)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4f(x, y, z));
#endif
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4f holding the minumum values.
		/// </returns>
		public static unsafe Vertex4f Min(Vertex4f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

#if HAVE_NUMERICS
			Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);

			for (uint i = 0; i < count; i++)
				min = Vector3.Min(min, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);

			return new Vertex4f(min.X, min.Y, min.Z);
#else
			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (uint i = 0; i < count; i++) {
				float w = v[i].w;
				x = (float)Math.Min(x, v[i].x / w);
				y = (float)Math.Min(y, v[i].y / w);
				z = (float)Math.Min(z, v[i].z / w);
			}

			return new Vertex4f(x, y, z);
#endif
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4f holding the maximum values.
		/// </returns>
		public static Vertex4f Max(params Vertex4f[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
#if HAVE_NUMERICS
			Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

			for (uint i = 0; i < v.Length; i++)
				max = Vector3.Max(max, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);

			return (new Vertex4f(max.X, max.Y, max.Z));
#else
			float x = (float)float.MinValue, y = (float)float.MinValue, z = (float)float.MinValue;

			for (int i = 0; i < v.Length; i++) {
				float w = v[i].w;
				x = (float)Math.Max(x, v[i].x / w);
				y = (float)Math.Max(y, v[i].y / w);
				z = (float)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4f(x, y, z));
#endif
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4f holding the maximum values.
		/// </returns>
		public static unsafe Vertex4f Max(Vertex4f* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
#if HAVE_NUMERICS
			Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

			for (uint i = 0; i < count; i++)
				max = Vector3.Max(max, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);

			return (new Vertex4f(max.X, max.Y, max.Z));
#else
			float x = (float)float.MinValue, y = (float)float.MinValue, z = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				float w = v[i].w;
				x = (float)Math.Max(x, v[i].x / w);
				y = (float)Math.Max(y, v[i].y / w);
				z = (float)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4f(x, y, z));
#endif
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4f"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4f[] v, out Vertex4f min, out Vertex4f max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
#if HAVE_NUMERICS
			Vector3 vmin = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 vmax = new Vector3(float.MinValue, float.MinValue, float.MinValue);

			for (uint i = 0; i < v.Length; i++) {
				Vector3 v3 = new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w;

				vmin = Vector3.Min(vmin, v3);
				vmax = Vector3.Max(vmax, v3);
			}

			min = new Vertex4f(vmin.X, vmin.Y, vmin.Z);
			max = new Vertex4f(vmax.X, vmax.Y, vmax.Z);
#else
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue, minz = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue, maxz = (float)float.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				float w = (float)v[i].w, x = (float)(v[i].x / w), y = (float)(v[i].y / w), z = (float)(v[i].z / w);
				minx = (float)Math.Min(minx, x); miny = (float)Math.Min(miny, y); minz = (float)Math.Min(minz, z);
				maxx = (float)Math.Max(maxx, x); maxy = (float)Math.Max(maxy, y); maxz = (float)Math.Max(maxz, z);
			}

			min = new Vertex4f(minx, miny, minz);
			max = new Vertex4f(maxx, maxy, maxz);
#endif
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4f, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4f*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4f"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4f"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4f* v, uint count, out Vertex4f min, out Vertex4f max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
#if HAVE_NUMERICS
			Vector3 vmin = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 vmax = new Vector3(float.MinValue, float.MinValue, float.MinValue);

			for (uint i = 0; i < count; i++) {
				Vector3 v3 = new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w;

				vmin = Vector3.Min(vmin, v3);
				vmax = Vector3.Max(vmax, v3);
			}

			min = new Vertex4f(vmin.X, vmin.Y, vmin.Z);
			max = new Vertex4f(vmax.X, vmax.Y, vmax.Z);
#else
			float minx = (float)float.MaxValue, miny = (float)float.MaxValue, minz = (float)float.MaxValue;
			float maxx = (float)float.MinValue, maxy = (float)float.MinValue, maxz = (float)float.MinValue;

			for (uint i = 0; i < count; i++) {
				float w = (float)v[i].w, x = (float)(v[i].x / w), y = (float)(v[i].y / w), z = (float)(v[i].z / w);
				minx = (float)Math.Min(minx, x); miny = (float)Math.Min(miny, y); minz = (float)Math.Min(minz, z);
				maxx = (float)Math.Max(maxx, x); maxy = (float)Math.Max(maxy, y); maxz = (float)Math.Max(maxz, z);
			}

			min = new Vertex4f(minx, miny, minz);
			max = new Vertex4f(maxx, maxy, maxz);
#endif
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4f Minimum = new Vertex4f(float.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4f Maximum = new Vertex4f(float.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4f is equal to another Vertex4f, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4f"/> to compare with this Vertex4f.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4f is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4f other, float precision)
		{
			bool undefined = Math.Abs(w) <= 0.0f;
			bool otherUndefined = Math.Abs(other.w) <= 0.0f;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4f is equal to another Vertex4f.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4f"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4f other)
		{
			bool undefined = Math.Abs(w) <= 0.0f;
			bool otherUndefined = Math.Abs(other.w) <= 0.0f;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4f))
				return (false);
			
			return (Equals((Vertex4f)obj));
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
	[DebuggerDisplay("Vertex4d: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4d : IEquatable<Vertex4d>
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
		/// A <see cref="T:double[]"/> that specify the value of every component.
		/// </param>
		public Vertex4d(double[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (double)1.0) { }

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
		public Vertex4d(double x, double y, double z) : this(x, y, z, 1.0) { }

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

		/// <summary>
		/// Structure size.
		/// </summary>
		public const int Size = 32;

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
			return new Vertex4d((double)(-v.x), (double)(-v.y), (double)(-v.z), (double)(-v.w));
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
			return (Vertex3d)v1 + (Vertex3d)v2;
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
			return (Vertex3d)v1 - (Vertex3d)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator *(Vertex4d v1, double scalar)
		{
			return new Vertex4d((double)(v1.x * scalar), (double)(v1.y * scalar), (double)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator *(Vertex4d v1, float scalar)
		{
			return new Vertex4d((double)(v1.x * scalar), (double)(v1.y * scalar), (double)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator /(Vertex4d v1, double scalar)
		{
			return new Vertex4d((double)(v1.x / scalar), (double)(v1.y / scalar), (double)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4d operator /(Vertex4d v1, float scalar)
		{
			return new Vertex4d((double)(v1.x / scalar), (double)(v1.y / scalar), (double)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex4d a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4d v)
		{
			return new Vertex3d(v.x / v.w, v.y / v.w, v.z / v.w);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4d v)
		{
			Vertex3d v3 = (Vertex3d)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4d v)
		{
			Vertex3d v3 = (Vertex3d)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex4d v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3d)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4d holding the minumum values.
		/// </returns>
		public static Vertex4d Min(params Vertex4d[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			double x = (double)double.MaxValue, y = (double)double.MaxValue, z = (double)double.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				double w = v[i].w;
				x = (double)Math.Min(x, v[i].x / w);
				y = (double)Math.Min(y, v[i].y / w);
				z = (double)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4d(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4d holding the minumum values.
		/// </returns>
		public static unsafe Vertex4d Min(Vertex4d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			double x = (double)double.MaxValue, y = (double)double.MaxValue, z = (double)double.MaxValue;

			for (uint i = 0; i < count; i++) {
				double w = v[i].w;
				x = (double)Math.Min(x, v[i].x / w);
				y = (double)Math.Min(y, v[i].y / w);
				z = (double)Math.Min(z, v[i].z / w);
			}

			return new Vertex4d(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4d holding the maximum values.
		/// </returns>
		public static Vertex4d Max(params Vertex4d[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			double x = (double)double.MinValue, y = (double)double.MinValue, z = (double)double.MinValue;

			for (int i = 0; i < v.Length; i++) {
				double w = v[i].w;
				x = (double)Math.Max(x, v[i].x / w);
				y = (double)Math.Max(y, v[i].y / w);
				z = (double)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4d(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4d holding the maximum values.
		/// </returns>
		public static unsafe Vertex4d Max(Vertex4d* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			double x = (double)double.MinValue, y = (double)double.MinValue, z = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				double w = v[i].w;
				x = (double)Math.Max(x, v[i].x / w);
				y = (double)Math.Max(y, v[i].y / w);
				z = (double)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4d(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4d"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4d[] v, out Vertex4d min, out Vertex4d max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue, minz = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue, maxz = (double)double.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				double w = (double)v[i].w, x = (double)(v[i].x / w), y = (double)(v[i].y / w), z = (double)(v[i].z / w);
				minx = (double)Math.Min(minx, x); miny = (double)Math.Min(miny, y); minz = (double)Math.Min(minz, z);
				maxx = (double)Math.Max(maxx, x); maxy = (double)Math.Max(maxy, y); maxz = (double)Math.Max(maxz, z);
			}

			min = new Vertex4d(minx, miny, minz);
			max = new Vertex4d(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4d, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4d*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4d"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4d"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4d* v, uint count, out Vertex4d min, out Vertex4d max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			double minx = (double)double.MaxValue, miny = (double)double.MaxValue, minz = (double)double.MaxValue;
			double maxx = (double)double.MinValue, maxy = (double)double.MinValue, maxz = (double)double.MinValue;

			for (uint i = 0; i < count; i++) {
				double w = (double)v[i].w, x = (double)(v[i].x / w), y = (double)(v[i].y / w), z = (double)(v[i].z / w);
				minx = (double)Math.Min(minx, x); miny = (double)Math.Min(miny, y); minz = (double)Math.Min(minz, z);
				maxx = (double)Math.Max(maxx, x); maxy = (double)Math.Max(maxy, y); maxz = (double)Math.Max(maxz, z);
			}

			min = new Vertex4d(minx, miny, minz);
			max = new Vertex4d(maxx, maxy, maxz);
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

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4d Minimum = new Vertex4d(double.MinValue);

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4d Maximum = new Vertex4d(double.MaxValue);

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4d is equal to another Vertex4d, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4d"/> to compare with this Vertex4d.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4d is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4d other, double precision)
		{
			bool undefined = Math.Abs(w) <= 0.0;
			bool otherUndefined = Math.Abs(other.w) <= 0.0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4d is equal to another Vertex4d.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4d"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4d other)
		{
			bool undefined = Math.Abs(w) <= 0.0;
			bool otherUndefined = Math.Abs(other.w) <= 0.0;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4d))
				return (false);
			
			return (Equals((Vertex4d)obj));
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
	[DebuggerDisplay("Vertex4hf: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4hf : IEquatable<Vertex4hf>
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
		/// A <see cref="T:HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex4hf(HalfFloat[] v) : this(v[0], v[1], v[2], v.Length > 3 ? v[3] : (HalfFloat)(HalfFloat)1.0f) { }

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
		public Vertex4hf(HalfFloat x, HalfFloat y, HalfFloat z) : this(x, y, z, (HalfFloat)1.0f) { }

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
		/// The Vertex4hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex4hf operator -(Vertex4hf v)
		{
			return new Vertex4hf((HalfFloat)(-v.x), (HalfFloat)(-v.y), (HalfFloat)(-v.z), (HalfFloat)(-v.w));
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
			return (Vertex3hf)v1 + (Vertex3hf)v2;
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
			return (Vertex3hf)v1 - (Vertex3hf)v2;
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="HalfFloat"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v1, HalfFloat scalar)
		{
			return new Vertex4hf((HalfFloat)(v1.x * scalar), (HalfFloat)(v1.y * scalar), (HalfFloat)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v1, float scalar)
		{
			return new Vertex4hf((HalfFloat)(v1.x * scalar), (HalfFloat)(v1.y * scalar), (HalfFloat)(v1.z * scalar), v1.w);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="HalfFloat"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator /(Vertex4hf v1, HalfFloat scalar)
		{
			return new Vertex4hf((HalfFloat)(v1.x / scalar), (HalfFloat)(v1.y / scalar), (HalfFloat)(v1.z / scalar), v1.w);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex4hf operator /(Vertex4hf v1, float scalar)
		{
			return new Vertex4hf((HalfFloat)(v1.x / scalar), (HalfFloat)(v1.y / scalar), (HalfFloat)(v1.z / scalar), v1.w);
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
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator HalfFloat[](Vertex4hf a)
		{
			return new[] { a.x, a.y, a.z, a.w };
		}

		/// <summary>
		/// Cast to Vertex3hf operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> initialized with the vector components, after normalizing homogeneous coordinate.
		/// </returns>
		public static explicit operator Vertex3hf(Vertex4hf v)
		{
			return new Vertex3hf((HalfFloat)((float)v.x / v.w), (HalfFloat)((float)v.y / v.w), (HalfFloat)((float)v.z / v.w));
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return new Vertex2f((float)v3.x, (float)v3.y);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return new Vertex3f((float)v3.x, (float)v3.y, (float)v3.z);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex4hf v)
		{
			return new Vertex4f((float)v.x, (float)v.y, (float)v.z, (float)v.w);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3d(Vertex4hf v)
		{
			Vertex3hf v3 = (Vertex3hf)v;

			return new Vertex3d(v3.x, v3.y, v3.z);
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex4hf v)
		{
			return new Vertex4d(v.x, v.y, v.z, v.w);
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
			return (float)Math.Sqrt(ModuleSquared());
		}

		/// <summary>
		/// Compute tridimensional vertex module, squared.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module, squared.
		/// </returns>
		public float ModuleSquared()
		{
			return ((Vertex3hf)this).ModuleSquared();
		}

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

				return normalized;
			}
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4hf holding the minumum values.
		/// </returns>
		public static Vertex4hf Min(params Vertex4hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue, z = (HalfFloat)HalfFloat.MaxValue;

			for (int i = 0; i < v.Length; i++) {
				HalfFloat w = v[i].w;
				x = (HalfFloat)Math.Min(x, v[i].x / w);
				y = (HalfFloat)Math.Min(y, v[i].y / w);
				z = (HalfFloat)Math.Min(z, v[i].z / w);
			}

			return (new Vertex4hf(x, y, z));
		}

		/// <summary>
		/// Get the minimum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4hf holding the minumum values.
		/// </returns>
		public static unsafe Vertex4hf Min(Vertex4hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));

			HalfFloat x = (HalfFloat)HalfFloat.MaxValue, y = (HalfFloat)HalfFloat.MaxValue, z = (HalfFloat)HalfFloat.MaxValue;

			for (uint i = 0; i < count; i++) {
				HalfFloat w = v[i].w;
				x = (HalfFloat)Math.Min(x, v[i].x / w);
				y = (HalfFloat)Math.Min(y, v[i].y / w);
				z = (HalfFloat)Math.Min(z, v[i].z / w);
			}

			return new Vertex4hf(x, y, z);
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf[]"/> that specify the values to be processed.
		/// </param>
		/// <returns>
		/// It returns the Vertex4hf holding the maximum values.
		/// </returns>
		public static Vertex4hf Max(params Vertex4hf[] v)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue, z = (HalfFloat)HalfFloat.MinValue;

			for (int i = 0; i < v.Length; i++) {
				HalfFloat w = v[i].w;
				x = (HalfFloat)Math.Max(x, v[i].x / w);
				y = (HalfFloat)Math.Max(y, v[i].y / w);
				z = (HalfFloat)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4hf(x, y, z));
		}

		/// <summary>
		/// Get the maximum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <returns>
		/// It returns the Vertex4hf holding the maximum values.
		/// </returns>
		public static unsafe Vertex4hf Max(Vertex4hf* v, uint count)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			HalfFloat x = (HalfFloat)HalfFloat.MinValue, y = (HalfFloat)HalfFloat.MinValue, z = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				HalfFloat w = v[i].w;
				x = (HalfFloat)Math.Max(x, v[i].x / w);
				y = (HalfFloat)Math.Max(y, v[i].y / w);
				z = (HalfFloat)Math.Max(z, v[i].z / w);
			}

			return (new Vertex4hf(x, y, z));
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf[]"/> that specifies the values to be processed.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4hf"/> that returns the maximum value.
		/// </param>
		public static void MinMax(Vertex4hf[] v, out Vertex4hf min, out Vertex4hf max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue, minz = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue, maxz = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < v.Length; i++) {
				HalfFloat w = (HalfFloat)v[i].w, x = (HalfFloat)(v[i].x / w), y = (HalfFloat)(v[i].y / w), z = (HalfFloat)(v[i].z / w);
				minx = (HalfFloat)Math.Min(minx, x); miny = (HalfFloat)Math.Min(miny, y); minz = (HalfFloat)Math.Min(minz, z);
				maxx = (HalfFloat)Math.Max(maxx, x); maxy = (HalfFloat)Math.Max(maxy, y); maxz = (HalfFloat)Math.Max(maxz, z);
			}

			min = new Vertex4hf(minx, miny, minz);
			max = new Vertex4hf(maxx, maxy, maxz);
		}

		/// <summary>
		/// Get the minimum and maximum of an array of Vertex4hf, component-wise.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Vertex4hf*"/> that specifies the values to be processed.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies how many elements to process.
		/// </param>
		/// <param name="min">
		/// A <see cref="Vertex4hf"/> that returns the minimum value.
		/// </param>
		/// <param name="max">
		/// A <see cref="Vertex4hf"/> that returns the maximum value.
		/// </param>
		public static unsafe void MinMax(Vertex4hf* v, uint count, out Vertex4hf min, out Vertex4hf max)
		{
			if (v == null)
				throw new ArgumentNullException(nameof(v));
			
			HalfFloat minx = (HalfFloat)HalfFloat.MaxValue, miny = (HalfFloat)HalfFloat.MaxValue, minz = (HalfFloat)HalfFloat.MaxValue;
			HalfFloat maxx = (HalfFloat)HalfFloat.MinValue, maxy = (HalfFloat)HalfFloat.MinValue, maxz = (HalfFloat)HalfFloat.MinValue;

			for (uint i = 0; i < count; i++) {
				HalfFloat w = (HalfFloat)v[i].w, x = (HalfFloat)(v[i].x / w), y = (HalfFloat)(v[i].y / w), z = (HalfFloat)(v[i].z / w);
				minx = (HalfFloat)Math.Min(minx, x); miny = (HalfFloat)Math.Min(miny, y); minz = (HalfFloat)Math.Min(minz, z);
				maxx = (HalfFloat)Math.Max(maxx, x); maxy = (HalfFloat)Math.Max(maxy, y); maxz = (HalfFloat)Math.Max(maxz, z);
			}

			min = new Vertex4hf(minx, miny, minz);
			max = new Vertex4hf(maxx, maxy, maxz);
		}

		#endregion
		
		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4hf Zero = new Vertex4hf((HalfFloat)0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4hf One = new Vertex4hf((HalfFloat)1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4hf UnitX = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4hf UnitY = new Vertex4hf((HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4hf UnitZ = new Vertex4hf((HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Vertex with lowest values.
		/// </summary>
		public static readonly Vertex4hf Minimum = new Vertex4hf(new HalfFloat(HalfFloat.MinValue));

		/// <summary>
		/// Vertex with highest values.
		/// </summary>
		public static readonly Vertex4hf Maximum = new Vertex4hf(new HalfFloat(HalfFloat.MaxValue));

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Vertex4hf is equal to another Vertex4hf, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Vertex4hf"/> to compare with this Vertex4hf.
		/// </param>
		/// <param name="precision">
		/// The <see cref="HalfFloat"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this Vertex4hf is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4hf other, HalfFloat precision)
		{
			bool undefined = Math.Abs(w) <= (HalfFloat)0.0f;
			bool otherUndefined = Math.Abs(other.w) <= (HalfFloat)0.0f;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false) {
				if (Math.Abs(x / w - other.x / other.w) > precision)
					return (false);
				if (Math.Abs(y / w - other.y / other.w) > precision)
					return (false);
				if (Math.Abs(z / w - other.z / other.w) > precision)
					return (false);
			} else {
				if (Math.Abs(x - other.x) > precision)
					return (false);
				if (Math.Abs(y - other.y) > precision)
					return (false);
				if (Math.Abs(z - other.z) > precision)
					return (false);
			}

			return (true);
		}

		/// <summary>
		/// Indicates whether the this Vertex4hf is equal to another Vertex4hf.
		/// </summary>
		/// <param name="other">
		/// An <see cref="Vertex4hf"/> to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Vertex4hf other)
		{
			bool undefined = Math.Abs(w) <= (HalfFloat)0.0f;
			bool otherUndefined = Math.Abs(other.w) <= (HalfFloat)0.0f;

			if (undefined != otherUndefined)
				return (false);

			if (undefined == false)
				return (x / w == other.x / other.w && y / w == other.y / other.w && z / w == other.z / other.w);
			else
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
			if (obj.GetType() != typeof(Vertex4hf))
				return (false);
			
			return (Equals((Vertex4hf)obj));
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