
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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR8 : IColorRGB<byte>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR8 specifying RGB components.
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
		public ColorBGR8(byte r, byte g, byte b)
		{
			// Reset structure
			bgr = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// BGR color components (packed).
		/// </summary>
		public byte bgr;

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
		/// A <see cref="T:ColorBGR8"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR8(Color a)
		{
			ColorBGR8 c = new ColorBGR8();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((bgr >> 5) & 0x07) / (float)0x07) * byte.MaxValue); }
			set { bgr = (byte)unchecked((bgr & ~0xE0) | (value >> 5) << 5); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((bgr >> 3) & 0x07) / (float)0x07) * byte.MaxValue); }
			set { bgr = (byte)unchecked((bgr & ~0x38) | (value >> 5) << 3); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((bgr >> 0) & 0x03) / (float)0x03) * byte.MaxValue); }
			set { bgr = (byte)unchecked((bgr & ~0x03) | (value >> 6)); }
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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR15 : IColorRGB<byte>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR15 specifying RGB components.
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
		public ColorBGR15(byte r, byte g, byte b)
		{
			// Reset structure
			bgr = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// BGR color components (packed).
		/// </summary>
		public ushort bgr;

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
		/// A <see cref="T:ColorBGR15"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR15(Color a)
		{
			ColorBGR15 c = new ColorBGR15();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((bgr >> 10) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0x7C00) | (value >> 3) << 10); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((bgr >> 5) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0x3E0) | (value >> 3) << 5); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((bgr >> 0) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0x1F) | (value >> 3)); }
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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR16 : IColorRGB<byte>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR16 specifying RGB components.
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
		public ColorBGR16(byte r, byte g, byte b)
		{
			// Reset structure
			bgr = 0;
			// Setup RGB components
			Red = r; Green = g; Blue = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// BGR color components (packed).
		/// </summary>
		public ushort bgr;

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
		/// A <see cref="T:ColorBGR16"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR16(Color a)
		{
			ColorBGR16 c = new ColorBGR16();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

		#endregion

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)((((bgr >> 11) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0xF800) | (value >> 3) << 11); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)((((bgr >> 5) & 0x3F) / (float)0x3F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0x7E0) | (value >> 2) << 5); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)((((bgr >> 0) & 0x1F) / (float)0x1F) * byte.MaxValue); }
			set { bgr = (ushort)unchecked((bgr & ~0x1F) | (value >> 3)); }
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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR24 : IColorRGB<byte>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR24 specifying RGB components.
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
		public ColorBGR24(byte r, byte g, byte b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBA32 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA32"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorBGRA32(ColorBGR24 a)
		{
			return (new ColorBGRA32(a.r, a.g, a.b, byte.MaxValue));
		}
		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:byte[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator byte[](ColorBGR24 a)
		{
			byte[] v = new byte[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ub operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR24"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ub"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3ub(ColorBGR24 a)
		{
			return (new Vertex3ub(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGR24"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR24(Color a)
		{
			ColorBGR24 c = new ColorBGR24();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR48 : IColorRGB<ushort>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR48 specifying RGB components.
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
		public ColorBGR48(ushort r, ushort g, ushort b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBA64 operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBA64"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorBGRA64(ColorBGR48 a)
		{
			return (new ColorBGRA64(a.r, a.g, a.b, ushort.MaxValue));
		}
		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ushort[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ushort[](ColorBGR48 a)
		{
			ushort[] v = new ushort[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3us operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR48"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4us"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3us(ColorBGR48 a)
		{
			return (new Vertex3us(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGR48"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR48(Color a)
		{
			ColorBGR48 c = new ColorBGR48();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR96 : IColorRGB<uint>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGR96 specifying RGB components.
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
		public ColorBGR96(uint r, uint g, uint b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public uint b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public uint g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public uint r;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR96"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:uint[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator uint[](ColorBGR96 a)
		{
			uint[] v = new uint[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3ui operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGR96"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4ui"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3ui(ColorBGR96 a)
		{
			return (new Vertex3ui(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGR96"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGR96(Color a)
		{
			ColorBGR96 c = new ColorBGR96();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRF : IColorRGB<float>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRF specifying RGB components.
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
		public ColorBGRF(float r, float g, float b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBAF operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAF"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorBGRAF(ColorBGRF a)
		{
			return (new ColorBGRAF(a.r, a.g, a.b, 1.0f));
		}
		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:float[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator float[](ColorBGRF a)
		{
			float[] v = new float[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(ColorBGRF a)
		{
			return (new Vertex3f(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRF(Color a)
		{
			ColorBGRF c = new ColorBGRF();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRD : IColorRGB<double>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRD specifying RGB components.
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
		public ColorBGRD(double r, double g, double b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Blue color components.
		/// </summary>
		public double b;

		/// <summary>
		/// Green color components.
		/// </summary>
		public double g;

		/// <summary>
		/// Red color components.
		/// </summary>
		public double r;

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRD"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:double[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator double[](ColorBGRD a)
		{
			double[] v = new double[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRD"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(ColorBGRD a)
		{
			return (new Vertex3d(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRD"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRD(Color a)
		{
			ColorBGRD c = new ColorBGRD();

			c[0] = (float)a.R / Byte.MaxValue;
			c[1] = (float)a.G / Byte.MaxValue;
			c[2] = (float)a.B / Byte.MaxValue;

			return (c);
		}

#endif

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
	/// BGR color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRHF : IColorRGB<HalfFloat>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorBGRHF specifying RGB components.
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
		public ColorBGRHF(HalfFloat r, HalfFloat g, HalfFloat b)
		{
			// Setup RGB components
			this.r = r;
			this.g = g;
			this.b = b;
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

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ColorRGBAHF operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ColorRGBAHF"/> initialized with the vector components.
		/// </returns>
		public static implicit operator ColorBGRAHF(ColorBGRHF a)
		{
			return (new ColorBGRAHF(a.r, a.g, a.b, (HalfFloat)1.0f));
		}
		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static implicit operator HalfFloat[](ColorBGRHF a)
		{
			HalfFloat[] v = new HalfFloat[3];

			v[0] = a.b;
			v[1] = a.g;
			v[2] = a.r;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3hf operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ColorBGRHF"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4hf"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3hf(ColorBGRHF a)
		{
			return (new Vertex3hf(a.b, a.g, a.r));
		}

#if HAVE_SYSTEM_DRAWING

		/// <summary>
		/// Cast from Color operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Color"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="T:ColorBGRHF"/> initialized with the color components.
		/// </returns>
		public static explicit operator ColorBGRHF(Color a)
		{
			ColorBGRHF c = new ColorBGRHF();

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
