






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
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 4)]
	public struct ColorRGBA32 : IColorRGBA<byte>
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
		/// <param name="a">
		/// A <see cref="byte"/> that specify the alpha component.
		/// </param>
		public ColorRGBA32(byte r, byte g, byte b, byte a)
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
		{
			get
			{
				switch (c) {
					case 0: return ((float)Red   / byte.MaxValue);
					case 1: return ((float)Green / byte.MaxValue);
					case 2: return ((float)Blue  / byte.MaxValue);
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
					case 0: Red =   (byte)(value * byte.MaxValue); break;
					case 1: Green = (byte)(value * byte.MaxValue); break;
					case 2: Blue =  (byte)(value * byte.MaxValue); break;
					case 3: Alpha = (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}

		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 4)]
	public struct ColorRGBA64 : IColorRGBA<ushort>
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
		/// <param name="a">
		/// A <see cref="ushort"/> that specify the alpha component.
		/// </param>
		public ColorRGBA64(ushort r, ushort g, ushort b, ushort a)
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
		{
			get
			{
				switch (c) {
					case 0: return ((float)Red   / ushort.MaxValue);
					case 1: return ((float)Green / ushort.MaxValue);
					case 2: return ((float)Blue  / ushort.MaxValue);
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
					case 0: Red =   (ushort)(value * ushort.MaxValue); break;
					case 1: Green = (ushort)(value * ushort.MaxValue); break;
					case 2: Blue =  (ushort)(value * ushort.MaxValue); break;
					case 3: Alpha = (ushort)(value * ushort.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}

		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 4)]
	public struct ColorRGBAF : IColorRGBA<float>
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
		/// <param name="a">
		/// A <see cref="float"/> that specify the alpha component.
		/// </param>
		public ColorRGBAF(float r, float g, float b, float a)
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
		{
			get
			{
				switch (c) {
					case 0: return (Red);
					case 1: return (Green);
					case 2: return (Blue);
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
					case 0: Red =   (float)value; break;
					case 1: Green = (float)value; break;
					case 2: Blue =  (float)value; break;
					case 3: Alpha = (float)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}

		}

		#endregion
	}

	/// <summary>
	/// RGBA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 4)]
	public struct ColorRGBAHF : IColorRGBA<HalfFloat>
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
		/// <param name="a">
		/// A <see cref="HalfFloat"/> that specify the alpha component.
		/// </param>
		public ColorRGBAHF(HalfFloat r, HalfFloat g, HalfFloat b, HalfFloat a)
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
		{
			get
			{
				switch (c) {
					case 0: return (Red);
					case 1: return (Green);
					case 2: return (Blue);
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
					case 0: Red =   (HalfFloat)value; break;
					case 1: Green = (HalfFloat)value; break;
					case 2: Blue =  (HalfFloat)value; break;
					case 3: Alpha = (HalfFloat)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}

		}

		#endregion
	}

}
