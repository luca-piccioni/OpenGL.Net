
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

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)(((bgr >> 5) & 0x07) << 5); }
			set { bgr = (byte)unchecked((bgr & ~0xE0) | (value >> 5) << 5); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)(((bgr >> 3) & 0x07) << 5); }
			set { bgr = (byte)unchecked((bgr & ~0x38) | (value >> 5) << 3); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)(((bgr >> 0) & 0x03) << 6); }
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

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)(((bgr >> 10) & 0x1F) << 3); }
			set { bgr = (ushort)unchecked((bgr & ~0x7C00) | (value >> 3) << 10); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)(((bgr >> 5) & 0x1F) << 3); }
			set { bgr = (ushort)unchecked((bgr & ~0x3E0) | (value >> 3) << 5); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)(((bgr >> 0) & 0x1F) << 3); }
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

		#region IColorRGB<byte> Implementation

		/// <summary>
		/// Get or set the red component.
		/// </summary>
		public byte Red
		{
			get { return (byte)(((bgr >> 11) & 0x1F) << 3); }
			set { bgr = (ushort)unchecked((bgr & ~0xF800) | (value >> 3) << 11); }
		}
		
		/// <summary>
		/// Get or set the green component.
		/// </summary>
		public byte Green
		{
			get { return (byte)(((bgr >> 5) & 0x3F) << 2); }
			set { bgr = (ushort)unchecked((bgr & ~0x7E0) | (value >> 2) << 5); }
		}
		
		/// <summary>
		/// Get or set the blue component.
		/// </summary>
		public byte Blue
		{
			get { return (byte)(((bgr >> 0) & 0x1F) << 3); }
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
