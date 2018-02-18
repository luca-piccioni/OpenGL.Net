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
#if HAVE_SYSTEM_DRAWING
using System.Drawing;
#endif
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB8
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB8 specifying RGB components.
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
		public ColorRGB8(byte r, byte g, byte b)
		{
			// Reset structure
			rgb = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// RGB color components (packed).
		/// </summary>
		public byte rgb;

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB8"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB8(Color a)
		{
			ColorRGB8 c = new ColorRGB8();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB8 ColorWhite = new ColorRGB8(byte.MaxValue, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB8 ColorBlack = new ColorRGB8(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB8 ColorRed = new ColorRGB8(byte.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB8 ColorGreen = new ColorRGB8(0, byte.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB8 ColorBlue = new ColorRGB8(0, 0, byte.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB8 ColorYellow = new ColorRGB8(byte.MaxValue, byte.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB8 ColorMagenta = new ColorRGB8(byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB8 ColorCyan = new ColorRGB8(0, byte.MaxValue, byte.MaxValue);

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((rgb >> 5) & 0x07) / (float)0x07) * byte.MaxValue); }
			set { rgb = (byte)unchecked((rgb & ~0xE0) | (value >> 5) << 5); }
		}

		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((rgb >> 3) & 0x07) / (float)0x07) * byte.MaxValue); }
			set { rgb = (byte)unchecked((rgb & ~0x38) | (value >> 5) << 3); }
		}

		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((rgb >> 0) & 0x03) / (float)0x03) * byte.MaxValue); }
			set { rgb = (byte)unchecked((rgb & ~0x03) | (value >> 6)); }
		}

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB8); } }

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
					case 0: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 2: return ((float)Blue  / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 2: Blue =  (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB15
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB15 specifying RGB components.
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
		public ColorRGB15(byte r, byte g, byte b)
		{
			// Reset structure
			rgb = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// RGB color components (packed).
		/// </summary>
		public ushort rgb;

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB15"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB15(Color a)
		{
			ColorRGB15 c = new ColorRGB15();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB15 ColorWhite = new ColorRGB15(byte.MaxValue, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB15 ColorBlack = new ColorRGB15(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB15 ColorRed = new ColorRGB15(byte.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB15 ColorGreen = new ColorRGB15(0, byte.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB15 ColorBlue = new ColorRGB15(0, 0, byte.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB15 ColorYellow = new ColorRGB15(byte.MaxValue, byte.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB15 ColorMagenta = new ColorRGB15(byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB15 ColorCyan = new ColorRGB15(0, byte.MaxValue, byte.MaxValue);

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((rgb >> 10) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0x7C00) | (value >> 3) << 10); }
		}

		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((rgb >> 5) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0x3E0) | (value >> 3) << 5); }
		}

		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((rgb >> 0) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0x1F) | (value >> 3)); }
		}

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB15); } }

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
					case 0: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 2: return ((float)Blue  / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 2: Blue =  (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB16
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB16 specifying RGB components.
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
		public ColorRGB16(byte r, byte g, byte b)
		{
			// Reset structure
			rgb = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// RGB color components (packed).
		/// </summary>
		public ushort rgb;

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB16"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB16(Color a)
		{
			ColorRGB16 c = new ColorRGB16();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB16 ColorWhite = new ColorRGB16(byte.MaxValue, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB16 ColorBlack = new ColorRGB16(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB16 ColorRed = new ColorRGB16(byte.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB16 ColorGreen = new ColorRGB16(0, byte.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB16 ColorBlue = new ColorRGB16(0, 0, byte.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB16 ColorYellow = new ColorRGB16(byte.MaxValue, byte.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB16 ColorMagenta = new ColorRGB16(byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB16 ColorCyan = new ColorRGB16(0, byte.MaxValue, byte.MaxValue);

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((rgb >> 11) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0xF800) | (value >> 3) << 11); }
		}

		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((rgb >> 5) & 0x3F) / (float)0x3F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0x7E0) | (value >> 2) << 5); }
		}

		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((rgb >> 0) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { rgb = (ushort)unchecked((rgb & ~0x1F) | (value >> 3)); }
		}

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB16); } }

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
					case 0: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 2: return ((float)Blue  / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 2: Blue =  (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB24
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB24 specifying RGB components.
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
		public ColorRGB24(byte r, byte g, byte b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBA32 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA32"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorRGBA32(ColorRGB24 a)
		{
			return (new ColorRGBA32(a.r, a.g, a.b, byte.MaxValue));
		}
		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator byte[](ColorRGB24 a)
		{
			byte[] v = new byte[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3ub(ColorRGB24 a)
		{
			return (new Vertex3ub(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB24"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB24(Color a)
		{
			ColorRGB24 c = new ColorRGB24();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB24 ColorWhite = new ColorRGB24(byte.MaxValue, byte.MaxValue, byte.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB24 ColorBlack = new ColorRGB24(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB24 ColorRed = new ColorRGB24(byte.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB24 ColorGreen = new ColorRGB24(0, byte.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB24 ColorBlue = new ColorRGB24(0, 0, byte.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB24 ColorYellow = new ColorRGB24(byte.MaxValue, byte.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB24 ColorMagenta = new ColorRGB24(byte.MaxValue, 0, byte.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB24 ColorCyan = new ColorRGB24(0, byte.MaxValue, byte.MaxValue);

		#endregion

		#region IColorRGB<byte> Implementation

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

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB24); } }

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
					case 0: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 2: return ((float)Blue  / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 2: Blue =  (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB48
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB48 specifying RGB components.
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
		public ColorRGB48(ushort r, ushort g, ushort b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBA64 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA64"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorRGBA64(ColorRGB48 a)
		{
			return (new ColorRGBA64(a.r, a.g, a.b, ushort.MaxValue));
		}
		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ushort[](ColorRGB48 a)
		{
			ushort[] v = new ushort[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3us(ColorRGB48 a)
		{
			return (new Vertex3us(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB48"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB48(Color a)
		{
			ColorRGB48 c = new ColorRGB48();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB48 ColorWhite = new ColorRGB48(ushort.MaxValue, ushort.MaxValue, ushort.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB48 ColorBlack = new ColorRGB48(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB48 ColorRed = new ColorRGB48(ushort.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB48 ColorGreen = new ColorRGB48(0, ushort.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB48 ColorBlue = new ColorRGB48(0, 0, ushort.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB48 ColorYellow = new ColorRGB48(ushort.MaxValue, ushort.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB48 ColorMagenta = new ColorRGB48(ushort.MaxValue, 0, ushort.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB48 ColorCyan = new ColorRGB48(0, ushort.MaxValue, ushort.MaxValue);

		#endregion

		#region IColorRGB<ushort> Implementation

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

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB48); } }

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
					case 0: return ((float)Red   / ushort.MaxValue);
					case 1: return ((float)Green / ushort.MaxValue);
					case 2: return ((float)Blue  / ushort.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (ushort)(value * ushort.MaxValue); break;
					case 1: Green = (ushort)(value * ushort.MaxValue); break;
					case 2: Blue =  (ushort)(value * ushort.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB96
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGB96 specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="uint"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="uint"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="uint"/> that specify the blue component.
		/// </param>
		public ColorRGB96(uint r, uint g, uint b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
		}
		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public uint r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public uint g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public uint b;
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB96"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:uint[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator uint[](ColorRGB96 a)
		{
			uint[] v = new uint[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ui operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGB96"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3ui(ColorRGB96 a)
		{
			return (new Vertex3ui(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGB96"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGB96(Color a)
		{
			ColorRGB96 c = new ColorRGB96();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGB96 ColorWhite = new ColorRGB96(uint.MaxValue, uint.MaxValue, uint.MaxValue);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGB96 ColorBlack = new ColorRGB96(0, 0, 0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGB96 ColorRed = new ColorRGB96(uint.MaxValue, 0, 0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGB96 ColorGreen = new ColorRGB96(0, uint.MaxValue, 0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGB96 ColorBlue = new ColorRGB96(0, 0, uint.MaxValue);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGB96 ColorYellow = new ColorRGB96(uint.MaxValue, uint.MaxValue, 0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGB96 ColorMagenta = new ColorRGB96(uint.MaxValue, 0, uint.MaxValue);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGB96 ColorCyan = new ColorRGB96(0, uint.MaxValue, uint.MaxValue);

		#endregion

		#region IColorRGB<uint> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public uint Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public uint Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public uint Blue
		{
			get { return (b); }
			set { b = value; }
		}

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB96); } }

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
					case 0: return ((float)Red   / uint.MaxValue);
					case 1: return ((float)Green / uint.MaxValue);
					case 2: return ((float)Blue  / uint.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (uint)(value * uint.MaxValue); break;
					case 1: Green = (uint)(value * uint.MaxValue); break;
					case 2: Blue =  (uint)(value * uint.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBF
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBF specifying RGB components.
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
		public ColorRGBF(float r, float g, float b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBAF operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAF"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorRGBAF(ColorRGBF a)
		{
			return (new ColorRGBAF(a.r, a.g, a.b, 1.0f));
		}
		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator float[](ColorRGBF a)
		{
			float[] v = new float[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(ColorRGBF a)
		{
			return (new Vertex3f(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBF(Color a)
		{
			ColorRGBF c = new ColorRGBF();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBF ColorWhite = new ColorRGBF(1.0f, 1.0f, 1.0f);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBF ColorBlack = new ColorRGBF(0.0f, 0.0f, 0.0f);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBF ColorRed = new ColorRGBF(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBF ColorGreen = new ColorRGBF(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBF ColorBlue = new ColorRGBF(0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBF ColorYellow = new ColorRGBF(1.0f, 1.0f, 0.0f);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBF ColorMagenta = new ColorRGBF(1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBF ColorCyan = new ColorRGBF(0.0f, 1.0f, 1.0f);

		#endregion

		#region IColorRGB<float> Implementation

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

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBF); } }

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
					case 0: return (Red);
					case 1: return (Green);
					case 2: return (Blue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (float)value; break;
					case 1: Green = (float)value; break;
					case 2: Blue =  (float)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBD
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBD specifying RGB components.
		/// </summary>
		/// <param name="r">
		/// A <see cref="double"/> that specify the red component.
		/// </param>
		/// <param name="g">
		/// A <see cref="double"/> that specify the green component.
		/// </param>
		/// <param name="b">
		/// A <see cref="double"/> that specify the blue component.
		/// </param>
		public ColorRGBD(double r, double g, double b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
		}
		#endregion

		#region Structure

		/// <summary>
		/// Red color components.
		/// </summary>
		public double r;

		/// <summary>
		/// Green color components.
		/// </summary>
		public double g;

		/// <summary>
		/// Blue color components.
		/// </summary>
		public double b;
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBD"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator double[](ColorRGBD a)
		{
			double[] v = new double[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBD"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(ColorRGBD a)
		{
			return (new Vertex3d(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBD"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBD(Color a)
		{
			ColorRGBD c = new ColorRGBD();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBD ColorWhite = new ColorRGBD(1.0, 1.0, 1.0);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBD ColorBlack = new ColorRGBD(0.0, 0.0, 0.0);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBD ColorRed = new ColorRGBD(1.0, 0.0, 0.0);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBD ColorGreen = new ColorRGBD(0.0, 1.0, 0.0);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBD ColorBlue = new ColorRGBD(0.0, 0.0, 1.0);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBD ColorYellow = new ColorRGBD(1.0, 1.0, 0.0);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBD ColorMagenta = new ColorRGBD(1.0, 0.0, 1.0);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBD ColorCyan = new ColorRGBD(0.0, 1.0, 1.0);

		#endregion

		#region IColorRGB<double> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public double Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public double Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public double Blue
		{
			get { return (b); }
			set { b = value; }
		}

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBD); } }

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
					case 0: return ((float)Red);
					case 1: return ((float)Green);
					case 2: return ((float)Blue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (double)value; break;
					case 1: Green = (double)value; break;
					case 2: Blue =  (double)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBHF
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRGBHF specifying RGB components.
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
		public ColorRGBHF(HalfFloat r, HalfFloat g, HalfFloat b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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
		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBAHF operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAHF"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorRGBAHF(ColorRGBHF a)
		{
			return (new ColorRGBAHF(a.r, a.g, a.b, (HalfFloat)1.0f));
		}
		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator HalfFloat[](ColorRGBHF a)
		{
			HalfFloat[] v = new HalfFloat[3];

			v[0] = a.r;
			v[1] = a.g;
			v[2] = a.b;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorRGBHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3hf(ColorRGBHF a)
		{
			return (new Vertex3hf(a.r, a.g, a.b));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorRGBHF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorRGBHF(Color a)
		{
			ColorRGBHF c = new ColorRGBHF();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region IColorRGB<HalfFloat> Implementation

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

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBHF); } }

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
					case 0: return (Red);
					case 1: return (Green);
					case 2: return (Blue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: Red =   (HalfFloat)value; break;
					case 1: Green = (HalfFloat)value; break;
					case 2: Blue =  (HalfFloat)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

}
