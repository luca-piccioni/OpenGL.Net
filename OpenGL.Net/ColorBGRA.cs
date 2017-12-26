
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
	/// BGRA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRA32 : IColorRGBA<byte>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRA32 specifying BGR components.
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
		public ColorBGRA32(byte r, byte g, byte b) :
			this(r, g, b, byte.MaxValue)
		{

		}

		/// <summary>
		/// Construct a ColorBGRA32 specifying BGRA components.
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
		public ColorBGRA32(byte r, byte g, byte b, byte a)
		{
			// Setup RGBA components
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public byte b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public byte g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public byte r;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public byte a;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA32"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator byte[](ColorBGRA32 a)
		{
			byte[] v = new byte[4];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;
			v[3] = a.a;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA32"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4ub(ColorBGRA32 a)
		{
			return (new Vertex4ub(a.r, a.g, a.b, a.a));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRA32"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRA32(Color a)
		{
			ColorBGRA32 c = new ColorBGRA32();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA32"/> to be casted.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorBGRA32"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorBGRA32 operator*(ColorBGRA32 a, float scalar)
		{
			ColorBGRA32 v = new ColorBGRA32();

			v.b = (byte)(a.b * scalar);
			v.g = (byte)(a.g * scalar);
			v.r = (byte)(a.r * scalar);
			v.a = (byte)(a.a * scalar);

			return (v);
		}

		#endregion

		#region IColorRGBA<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Get or set the alpha component.
		/// </summary>
		public byte Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRA32); } }

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
		{
			get
			{
				switch (c) {
					case 2: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 0: return ((float)Blue  / byte.MaxValue);
					case 3: return ((float)Alpha / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 2: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 0: Blue =  (byte)(value * byte.MaxValue); break;
					case 3: Alpha = (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// BGRA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRA64 : IColorRGBA<ushort>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRA64 specifying BGR components.
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
		public ColorBGRA64(ushort r, ushort g, ushort b) :
			this(r, g, b, ushort.MaxValue)
		{

		}

		/// <summary>
		/// Construct a ColorBGRA64 specifying BGRA components.
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
		public ColorBGRA64(ushort r, ushort g, ushort b, ushort a)
		{
			// Setup RGBA components
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public ushort b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public ushort g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public ushort r;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public ushort a;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA64"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ushort[](ColorBGRA64 a)
		{
			ushort[] v = new ushort[4];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;
			v[3] = a.a;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA64"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4us(ColorBGRA64 a)
		{
			return (new Vertex4us(a.r, a.g, a.b, a.a));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRA64"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRA64(Color a)
		{
			ColorBGRA64 c = new ColorBGRA64();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRA64"/> to be casted.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorBGRA64"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorBGRA64 operator*(ColorBGRA64 a, float scalar)
		{
			ColorBGRA64 v = new ColorBGRA64();

			v.b = (ushort)(a.b * scalar);
			v.g = (ushort)(a.g * scalar);
			v.r = (ushort)(a.r * scalar);
			v.a = (ushort)(a.a * scalar);

			return (v);
		}

		#endregion

		#region IColorRGBA<ushort> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public ushort Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public ushort Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public ushort Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Get or set the alpha component.
		/// </summary>
		public ushort Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRA64); } }

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
		{
			get
			{
				switch (c) {
					case 2: return ((float)Red   / ushort.MaxValue);
					case 1: return ((float)Green / ushort.MaxValue);
					case 0: return ((float)Blue  / ushort.MaxValue);
					case 3: return ((float)Alpha / ushort.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 2: Red =   (ushort)(value * ushort.MaxValue); break;
					case 1: Green = (ushort)(value * ushort.MaxValue); break;
					case 0: Blue =  (ushort)(value * ushort.MaxValue); break;
					case 3: Alpha = (ushort)(value * ushort.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// BGRA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRAF : IColorRGBA<float>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRAF specifying BGR components.
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
		public ColorBGRAF(float r, float g, float b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// Construct a ColorBGRAF specifying BGRA components.
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
		public ColorBGRAF(float r, float g, float b, float a)
		{
			// Setup RGBA components
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public float b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public float g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public float r;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public float a;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator float[](ColorBGRAF a)
		{
			float[] v = new float[4];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;
			v[3] = a.a;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(ColorBGRAF a)
		{
			return (new Vertex4f(a.r, a.g, a.b, a.a));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRAF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRAF(Color a)
		{
			ColorBGRAF c = new ColorBGRAF();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAF"/> to be casted.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorBGRAF"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorBGRAF operator*(ColorBGRAF a, float scalar)
		{
			ColorBGRAF v = new ColorBGRAF();

			v.b = (float)(a.b * scalar);
			v.g = (float)(a.g * scalar);
			v.r = (float)(a.r * scalar);
			v.a = (float)(a.a * scalar);

			return (v);
		}

		#endregion

		#region IColorRGBA<float> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public float Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public float Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public float Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Get or set the alpha component.
		/// </summary>
		public float Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRAF); } }

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
		{
			get
			{
				switch (c) {
					case 2: return (Red);
					case 1: return (Green);
					case 0: return (Blue);
					case 3: return (Alpha);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 2: Red =   (float)value; break;
					case 1: Green = (float)value; break;
					case 0: Blue =  (float)value; break;
					case 3: Alpha = (float)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// BGRA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRAHF : IColorRGBA<HalfFloat>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRAHF specifying BGR components.
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
		public ColorBGRAHF(HalfFloat r, HalfFloat g, HalfFloat b) :
			this(r, g, b, (HalfFloat)1.0f)
		{

		}

		/// <summary>
		/// Construct a ColorBGRAHF specifying BGRA components.
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
		public ColorBGRAHF(HalfFloat r, HalfFloat g, HalfFloat b, HalfFloat a)
		{
			// Setup RGBA components
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public HalfFloat b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public HalfFloat g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public HalfFloat r;

		/// <summary>
		/// Alpha color components.
		/// </summary>
		public HalfFloat a;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator HalfFloat[](ColorBGRAHF a)
		{
			HalfFloat[] v = new HalfFloat[4];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;
			v[3] = a.a;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex4hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4hf(ColorBGRAHF a)
		{
			return (new Vertex4hf(a.r, a.g, a.b, a.a));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRAHF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRAHF(Color a)
		{
			ColorBGRAHF c = new ColorBGRAHF();

			c[0] = (float)a.R / byte.MaxValue;
			c[1] = (float)a.G / byte.MaxValue;
			c[2] = (float)a.B / byte.MaxValue;
			c[3] = (float)a.A / byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRAHF"/> to be casted.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="ColorBGRAHF"/> that equals to the multiplication of <paramref name="a"/> with <paramref name="scalar"/>.
		/// </returns>
		public static ColorBGRAHF operator*(ColorBGRAHF a, float scalar)
		{
			ColorBGRAHF v = new ColorBGRAHF();

			v.b = (HalfFloat)(a.b * scalar);
			v.g = (HalfFloat)(a.g * scalar);
			v.r = (HalfFloat)(a.r * scalar);
			v.a = (HalfFloat)(a.a * scalar);

			return (v);
		}

		#endregion

		#region IColorRGBA<HalfFloat> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public HalfFloat Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public HalfFloat Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public HalfFloat Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Get or set the alpha component.
		/// </summary>
		public HalfFloat Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRAHF); } }

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
		{
			get
			{
				switch (c) {
					case 2: return (Red);
					case 1: return (Green);
					case 0: return (Blue);
					case 3: return (Alpha);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 2: Red =   (HalfFloat)value; break;
					case 1: Green = (HalfFloat)value; break;
					case 0: Blue =  (HalfFloat)value; break;
					case 3: Alpha = (HalfFloat)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

}
