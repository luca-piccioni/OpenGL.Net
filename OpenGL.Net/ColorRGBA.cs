
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
#if HAVE_SYSTEM_DRAWING
using System.Drawing;
#endif
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBA32 : IEquatable<ColorRGBA32>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBA32 specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="byte"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="byte"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="byte"/> that specify the blue component.
		/// </param>
		public ColorRGBA32(byte r, byte g, byte b) :
			this(r, g, b, byte.MaxValue)
		{

		}

		/// <summary>
		/// Construct a ColorRGBA32 specifying RGBA components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="byte"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="byte"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="byte"/> that specify the blue component.
		/// </param>
		/// <param name="a">
		/// A <see cref="byte"/> that specify the alpha component.
		/// </param>
		public ColorRGBA32(byte r, byte g, byte b, byte a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public byte r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public byte g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public byte b;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public byte a;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA32"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA32"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorRGBA32 operator*(ColorRGBA32 a, float scalar)
		{
			return new ColorRGBA32((byte)(a.r * scalar), (byte)(a.g * scalar), (byte)(a.b * scalar), (byte)(a.a * scalar));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA32"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator byte[](ColorRGBA32 a)
		{
			return new[] { a.r, a.g, a.b, a.a };
		}

		/// <summary>
		/// Cast to Vertex4ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA32"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4ub(ColorRGBA32 a)
		{
			return new Vertex4ub(a.r, a.g, a.b, a.a);
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBA32"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBA32(Color a)
		{
			ColorRGBA32 c = new ColorRGBA32();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return c;
		}

#endif
		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(ColorRGBA32 v1, ColorRGBA32 v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(ColorRGBA32 v1, ColorRGBA32 v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBA32 ColorWhite = new ColorRGBA32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBA32 ColorBlack = new ColorRGBA32(0, 0, 0, byte.MaxValue);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBA32 ColorRed = new ColorRGBA32(byte.MaxValue, 0, 0, byte.MaxValue);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBA32 ColorGreen = new ColorRGBA32(0, byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBA32 ColorBlue = new ColorRGBA32(0, 0, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBA32 ColorYellow = new ColorRGBA32(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBA32 ColorMagenta = new ColorRGBA32(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBA32 ColorCyan = new ColorRGBA32(0, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBA32); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{			get
			{
				switch (c) {
					case 0: return (float)r / byte.MaxValue;
					case 1: return (float)g / byte.MaxValue;
					case 2: return (float)b / byte.MaxValue;
					case 3: return (float)a / byte.MaxValue;
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r = (byte)(value * byte.MaxValue); break;
					case 1: g = (byte)(value * byte.MaxValue); break;
					case 2: b = (byte)(value * byte.MaxValue); break;
					case 3: a = (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this ColorRGBA32 is equal to another ColorRGBA32, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="ColorRGBA32"/> to compare with this ColorRGBA32.
		/// </param>
		/// <param name="precision">
		/// The <see cref="byte"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this ColorRGBA32 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBA32 other, byte precision)
		{
			if (Math.Abs(r - other.r) > precision)
				return false;
			if (Math.Abs(g - other.g) > precision)
				return false;
			if (Math.Abs(b - other.b) > precision)
				return false;
			if (Math.Abs(a - other.a) > precision)
				return false;

			return true;
		}

		/// <summary>
		/// Indicates whether the this ColorRGBA32 is equal to another ColorRGBA32.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBA32 other)
		{
			return r == other.r && g == other.g && b == other.b && a == other.a;
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
			if (obj.GetType() != typeof(ColorRGBA32))
				return false;
			
			return Equals((ColorRGBA32)obj);
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
				int result = r.GetHashCode();
				result = (result * 397) ^ g.GetHashCode();
				result = (result * 397) ^ b.GetHashCode();
				result = (result * 397) ^ a.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBA64 : IEquatable<ColorRGBA64>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBA64 specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="ushort"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="ushort"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="ushort"/> that specify the blue component.
		/// </param>
		public ColorRGBA64(ushort r, ushort g, ushort b) :
			this(r, g, b, ushort.MaxValue)
		{

		}

		/// <summary>
		/// Construct a ColorRGBA64 specifying RGBA components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="ushort"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="ushort"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="ushort"/> that specify the blue component.
		/// </param>
		/// <param name="a">
		/// A <see cref="ushort"/> that specify the alpha component.
		/// </param>
		public ColorRGBA64(ushort r, ushort g, ushort b, ushort a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public ushort r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public ushort g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public ushort b;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public ushort a;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA64"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA64"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorRGBA64 operator*(ColorRGBA64 a, float scalar)
		{
			return new ColorRGBA64((ushort)(a.r * scalar), (ushort)(a.g * scalar), (ushort)(a.b * scalar), (ushort)(a.a * scalar));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA64"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ushort[](ColorRGBA64 a)
		{
			return new[] { a.r, a.g, a.b, a.a };
		}

		/// <summary>
		/// Cast to Vertex4us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBA64"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4us(ColorRGBA64 a)
		{
			return new Vertex4us(a.r, a.g, a.b, a.a);
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBA64"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBA64(Color a)
		{
			ColorRGBA64 c = new ColorRGBA64();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return c;
		}

#endif
		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(ColorRGBA64 v1, ColorRGBA64 v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(ColorRGBA64 v1, ColorRGBA64 v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBA64 ColorWhite = new ColorRGBA64(ushort.MaxValue, ushort.MaxValue, ushort.MaxValue, ushort.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBA64 ColorBlack = new ColorRGBA64(0, 0, 0, ushort.MaxValue);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBA64 ColorRed = new ColorRGBA64(ushort.MaxValue, 0, 0, ushort.MaxValue);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBA64 ColorGreen = new ColorRGBA64(0, ushort.MaxValue, 0, ushort.MaxValue);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBA64 ColorBlue = new ColorRGBA64(0, 0, ushort.MaxValue, ushort.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBA64 ColorYellow = new ColorRGBA64(ushort.MaxValue, ushort.MaxValue, 0, ushort.MaxValue);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBA64 ColorMagenta = new ColorRGBA64(ushort.MaxValue, 0, ushort.MaxValue, ushort.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBA64 ColorCyan = new ColorRGBA64(0, ushort.MaxValue, ushort.MaxValue, ushort.MaxValue);

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBA64); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{			get
			{
				switch (c) {
					case 0: return (float)r / ushort.MaxValue;
					case 1: return (float)g / ushort.MaxValue;
					case 2: return (float)b / ushort.MaxValue;
					case 3: return (float)a / ushort.MaxValue;
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r = (ushort)(value * ushort.MaxValue); break;
					case 1: g = (ushort)(value * ushort.MaxValue); break;
					case 2: b = (ushort)(value * ushort.MaxValue); break;
					case 3: a = (ushort)(value * ushort.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this ColorRGBA64 is equal to another ColorRGBA64, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="ColorRGBA64"/> to compare with this ColorRGBA64.
		/// </param>
		/// <param name="precision">
		/// The <see cref="ushort"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this ColorRGBA64 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBA64 other, ushort precision)
		{
			if (Math.Abs(r - other.r) > precision)
				return false;
			if (Math.Abs(g - other.g) > precision)
				return false;
			if (Math.Abs(b - other.b) > precision)
				return false;
			if (Math.Abs(a - other.a) > precision)
				return false;

			return true;
		}

		/// <summary>
		/// Indicates whether the this ColorRGBA64 is equal to another ColorRGBA64.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBA64 other)
		{
			return r == other.r && g == other.g && b == other.b && a == other.a;
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
			if (obj.GetType() != typeof(ColorRGBA64))
				return false;
			
			return Equals((ColorRGBA64)obj);
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
				int result = r.GetHashCode();
				result = (result * 397) ^ g.GetHashCode();
				result = (result * 397) ^ b.GetHashCode();
				result = (result * 397) ^ a.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBAF : IEquatable<ColorRGBAF>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBAF specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="float"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="float"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="float"/> that specify the blue component.
		/// </param>
		public ColorRGBAF(float r, float g, float b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// Construct a ColorRGBAF specifying RGBA components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="float"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="float"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="float"/> that specify the blue component.
		/// </param>
		/// <param name="a">
		/// A <see cref="float"/> that specify the alpha component.
		/// </param>
		public ColorRGBAF(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public float r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public float g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public float b;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public float a;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAF"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAF"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorRGBAF operator*(ColorRGBAF a, float scalar)
		{
			return new ColorRGBAF((float)(a.r * scalar), (float)(a.g * scalar), (float)(a.b * scalar), (float)(a.a * scalar));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator float[](ColorRGBAF a)
		{
			return new[] { a.r, a.g, a.b, a.a };
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(ColorRGBAF a)
		{
			return new Vertex4f(a.r, a.g, a.b, a.a);
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBAF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBAF(Color a)
		{
			ColorRGBAF c = new ColorRGBAF();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return c;
		}

#endif
		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(ColorRGBAF v1, ColorRGBAF v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(ColorRGBAF v1, ColorRGBAF v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBAF ColorWhite = new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBAF ColorBlack = new ColorRGBAF(0.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBAF ColorRed = new ColorRGBAF(1.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBAF ColorGreen = new ColorRGBAF(0.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBAF ColorBlue = new ColorRGBAF(0.0f, 0.0f, 1.0f, 1.0f);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBAF ColorYellow = new ColorRGBAF(1.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBAF ColorMagenta = new ColorRGBAF(1.0f, 0.0f, 1.0f, 1.0f);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBAF ColorCyan = new ColorRGBAF(0.0f, 1.0f, 1.0f, 1.0f);

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBAF); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{			get
			{
				switch (c) {
					case 0: return r;
					case 1: return g;
					case 2: return b;
					case 3: return a;
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r = (float)value; break;
					case 1: g = (float)value; break;
					case 2: b = (float)value; break;
					case 3: a = (float)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this ColorRGBAF is equal to another ColorRGBAF, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="ColorRGBAF"/> to compare with this ColorRGBAF.
		/// </param>
		/// <param name="precision">
		/// The <see cref="float"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this ColorRGBAF is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBAF other, float precision)
		{
			if (Math.Abs(r - other.r) > precision)
				return false;
			if (Math.Abs(g - other.g) > precision)
				return false;
			if (Math.Abs(b - other.b) > precision)
				return false;
			if (Math.Abs(a - other.a) > precision)
				return false;

			return true;
		}

		/// <summary>
		/// Indicates whether the this ColorRGBAF is equal to another ColorRGBAF.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBAF other)
		{
			return r == other.r && g == other.g && b == other.b && a == other.a;
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
			if (obj.GetType() != typeof(ColorRGBAF))
				return false;
			
			return Equals((ColorRGBAF)obj);
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
				int result = r.GetHashCode();
				result = (result * 397) ^ g.GetHashCode();
				result = (result * 397) ^ b.GetHashCode();
				result = (result * 397) ^ a.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBAHF : IEquatable<ColorRGBAHF>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBAHF specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="HalfFloat"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="HalfFloat"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="HalfFloat"/> that specify the blue component.
		/// </param>
		public ColorRGBAHF(HalfFloat r, HalfFloat g, HalfFloat b) :
			this(r, g, b, (HalfFloat)1.0f)
		{

		}

		/// <summary>
		/// Construct a ColorRGBAHF specifying RGBA components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="HalfFloat"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="HalfFloat"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="HalfFloat"/> that specify the blue component.
		/// </param>
		/// <param name="a">
		/// A <see cref="HalfFloat"/> that specify the alpha component.
		/// </param>
		public ColorRGBAHF(HalfFloat r, HalfFloat g, HalfFloat b, HalfFloat a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public HalfFloat r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public HalfFloat g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public HalfFloat b;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public HalfFloat a;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAHF"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="float"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAHF"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorRGBAHF operator*(ColorRGBAHF a, float scalar)
		{
			return new ColorRGBAHF((HalfFloat)(a.r * scalar), (HalfFloat)(a.g * scalar), (HalfFloat)(a.b * scalar), (HalfFloat)(a.a * scalar));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator HalfFloat[](ColorRGBAHF a)
		{
			return new[] { a.r, a.g, a.b, a.a };
		}

		/// <summary>
		/// Cast to Vertex4hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBAHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4hf(ColorRGBAHF a)
		{
			return new Vertex4hf(a.r, a.g, a.b, a.a);
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBAHF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBAHF(Color a)
		{
			ColorRGBAHF c = new ColorRGBAHF();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return c;
		}

#endif
		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(ColorRGBAHF v1, ColorRGBAHF v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(ColorRGBAHF v1, ColorRGBAHF v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBAHF ColorWhite = new ColorRGBAHF((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBAHF ColorBlack = new ColorRGBAHF((HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBAHF ColorRed = new ColorRGBAHF((HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBAHF ColorGreen = new ColorRGBAHF((HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBAHF ColorBlue = new ColorRGBAHF((HalfFloat)0.0f, (HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBAHF ColorYellow = new ColorRGBAHF((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBAHF ColorMagenta = new ColorRGBAHF((HalfFloat)1.0f, (HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBAHF ColorCyan = new ColorRGBAHF((HalfFloat)0.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBAHF); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{			get
			{
				switch (c) {
					case 0: return r;
					case 1: return g;
					case 2: return b;
					case 3: return a;
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r = (HalfFloat)value; break;
					case 1: g = (HalfFloat)value; break;
					case 2: b = (HalfFloat)value; break;
					case 3: a = (HalfFloat)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this ColorRGBAHF is equal to another ColorRGBAHF, tolerating an absolute error.
		/// </summary>
		/// <param name="other">
		/// The <see cref="ColorRGBAHF"/> to compare with this ColorRGBAHF.
		/// </param>
		/// <param name="precision">
		/// The <see cref="HalfFloat"/> that specifies the maximum absolute error tollerance.
		/// </param>
		/// <returns>
		/// It returns true if the this ColorRGBAHF is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBAHF other, HalfFloat precision)
		{
			if (Math.Abs(r - other.r) > precision)
				return false;
			if (Math.Abs(g - other.g) > precision)
				return false;
			if (Math.Abs(b - other.b) > precision)
				return false;
			if (Math.Abs(a - other.a) > precision)
				return false;

			return true;
		}

		/// <summary>
		/// Indicates whether the this ColorRGBAHF is equal to another ColorRGBAHF.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBAHF other)
		{
			return r == other.r && g == other.g && b == other.b && a == other.a;
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
			if (obj.GetType() != typeof(ColorRGBAHF))
				return false;
			
			return Equals((ColorRGBAHF)obj);
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
				int result = r.GetHashCode();
				result = (result * 397) ^ g.GetHashCode();
				result = (result * 397) ^ b.GetHashCode();
				result = (result * 397) ^ a.GetHashCode();

				return result;
			}
		}

		#endregion
	}

}
