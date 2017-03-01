







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
	/// BGRA color.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 4)]
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
	[ArrayBufferItem(VertexBaseType.UShort, 4)]
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
	[ArrayBufferItem(VertexBaseType.Float, 4)]
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
	[ArrayBufferItem(VertexBaseType.Half, 4)]
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
