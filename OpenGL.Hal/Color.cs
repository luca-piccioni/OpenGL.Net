
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenGL
{
	#region RGB Color

	/// <summary>
	/// RGB color interface.
	/// </summary>
	public interface IColorRGB<T> : IColor
	{
		/// <summary>
		/// Red component property.
		/// </summary>
		T Red { get; set; }
		
		/// <summary>
		/// Green component property.
		/// </summary>
		T Green { get; set; }
		
		/// <summary>
		/// Blue component property.
		/// </summary>
		T Blue { get; set; }
	}

	/// <summary>
	/// RGB color (8 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB8 : IColorRGB<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Packed Red-Green-Blue components for RGB color. 
		/// </summary>
		private Byte rgb;
		
		#endregion
		
		#region IColorRGB<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB8); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Blue / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Blue = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)(((rgb >> 5) & 0x07) << 5); }
			set {
				// Reset previous red value
				rgb &= unchecked((Byte)~0xE0);
				// Assign current red component
				rgb |= (Byte)unchecked((((Byte)value >> 5) & (Byte)0x7) << 5);
			}
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)(((rgb >>  2) & 0x07) << 5); }
			set {  
				// Reset previous green value
				rgb &= unchecked((Byte)~0x1C);
				// Assign current green component
				rgb |= (Byte)unchecked((((Byte)value >> 5) & (Byte)0x07) << 2);
			}
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)(((rgb >>  0) & 0x03) << 6); }
			set {
				// Reset previous blue value
				rgb &= unchecked((Byte)~0x03);
				// Assign current blue component
				rgb |= (Byte)unchecked((((Byte)value >> 6) & (Byte)0x03) << 0);
			}
		}
		
		#endregion
	}

	/// <summary>
	/// RGB color (15 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB15 : IColorRGB<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Packed Red-Green-Blue components for RGB color. 
		/// </summary>
		private UInt16 rgb;

		#endregion

		#region IColorRGB<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB15); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Blue / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Blue = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)((((UInt16)rgb >> 11) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0xF800);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 11);
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)((((UInt16)rgb >> 6) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0x07C0);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 6);
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)((((UInt16)rgb >> 1) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0x001F);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 1);
			}
		}

		#endregion
	}

	/// <summary>
	/// RGB color (16 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB16 : IColorRGB<Byte>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Packed Red-Green-Blue components for RGB color. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// The RGB color components disposition is represented in the following:
		/// <i>MSB -------- LSB</i>
		/// <i>RRRRRGGGGGGBBBBB</i>
		/// </para>
		/// </remarks>
		private UInt16 rgb;
		
		#endregion
		
		#region IColorRGBA<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB16); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Blue / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Blue = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)((((UInt16)rgb >> 11) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0xF800);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 11);
			}
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)((((UInt16)rgb >> 5) & (UInt16)0x003F) << 2); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0x07E0);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 2) & (UInt16)0x003F) << 5);
			}
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)((((UInt16)rgb >> 0) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				rgb &= unchecked((UInt16)~0x001F);
				// Assign current green component
				rgb |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 0);
			}
		}
		
		#endregion
	}

	/// <summary>
	/// RGB color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB24 : IColorRGB<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGB24(byte r, byte g, byte b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}
		
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private Byte r;

		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private Byte g;

		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private Byte b;
		
		#endregion

		#region IColorRGB<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB24); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Blue / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (Byte)(0xFF * value);
						break;
					case 1:
						Green = (Byte)(0xFF * value);
						break;
					case 2:
						Blue = (Byte)(0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGB color (48 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB48 : IColorRGB<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private UInt16 r;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private UInt16 g;
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private UInt16 b;

		#endregion

		#region IColorRGB<UInt16> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB48); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Blue / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (b); }
			set { b = value; }
		}

		#endregion
	}

	/// <summary>
	/// RGB color (single-precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBF : IColorRGB<Single>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Constructor. 
		/// </summary>
		public ColorRGBF(Single r, Single g, Single b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c"></param>
		public ColorRGBF(ColorRGBF c)
		{
			this.r = c.r;
			this.g = c.g;
			this.b = c.b;
		}
		
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private Single r;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private Single g;
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private Single b;
		
		#endregion
		
		#region IColorRGB<Single> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Red);
					case 1:
						return (Green);
					case 2:
						return (Blue);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Red = value;
						break;
					case 1:
						Green = value;
						break;
					case 2:
						Blue = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Single Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Single Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGB color (double-precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBD : IColorRGB<Double>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private Double r;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private Double g;
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private Double b;
		
		#endregion
		
		#region IColorRGB<Single> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBD); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red);
					case 1:
						return ((Single)Green);
					case 2:
						return ((Single)Blue);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Red = (Double)value;
						break;
					case 1:
						Green = (Double)value;
						break;
					case 2:
						Blue = (Double)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Double Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Double Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Double Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGB color (half floating point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBHF : IColorRGB<HalfFloat>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGBHF(HalfFloat r, HalfFloat g, HalfFloat b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c"></param>
		public ColorRGBHF(ColorRGBHF c)
		{
			this.r = c.r;
			this.g = c.g;
			this.b = c.b;
		}

		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private HalfFloat r;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private HalfFloat g;
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private HalfFloat b;

		#endregion

		#region IColorRGB<HalfFloat> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBHF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red);
					case 1:
						return ((Single)Green);
					case 2:
						return ((Single)Blue);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Red = (HalfFloat)value;
						break;
					case 1:
						Green = (HalfFloat)value;
						break;
					case 2:
						Blue = (HalfFloat)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public HalfFloat Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public HalfFloat Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public HalfFloat Blue
		{
			get { return (b); }
			set { b = value; }
		}

		#endregion
	}

	#endregion

	#region sRGB/sBGR Color

	/// <summary>
	/// sRGB color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorSRGB24 : IColorRGB<Byte>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Red component for sRGB color. 
		/// </summary>
		private Byte r;
		/// <summary>
		/// Green component for sRGB color. 
		/// </summary>
		private Byte g;
		/// <summary>
		/// Blue component for sRGB color. 
		/// </summary>
		private Byte b;
		
		#endregion
		
		#region IColorRGB<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.SRGB24); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				Single comp;

				switch (c) {
					case 0:
						Pixel.ConvertColor_SRGB_RGB((Single)Red / (Single)0xFF, out comp);
						break;
					case 1:
						Pixel.ConvertColor_SRGB_RGB((Single)Green / (Single)0xFF, out comp);
						break;
					case 2:
						Pixel.ConvertColor_SRGB_RGB((Single)Blue / (Single)0xFF, out comp);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}

				return (comp);
			}
			set {
				Single comp;

				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");

				Pixel.ConvertColor_RGB_SRGB(value, out comp);

				switch (c) {
					case 0:
						Red = (Byte)(0xFF * comp);
						break;
					case 1:
						Green = (Byte)(0xFF * comp);
						break;
					case 2:
						Blue = (Byte)(0xFF * comp);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// sBGR color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorSBGR24 : IColorBGR<Byte>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Blue component for sBGR color. 
		/// </summary>
		private Byte b;
		/// <summary>
		/// Green component for sBGR color. 
		/// </summary>
		private Byte g;
		/// <summary>
		/// Red component for sBGR color. 
		/// </summary>
		private Byte r;
		
		#endregion
		
		#region IColorRGB<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.SBGR24); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				Single comp;

				switch (c) {
					case 0:
						Pixel.ConvertColor_SRGB_RGB((Single)Blue / (Single)0xFF, out comp);
						break;
					case 1:
						Pixel.ConvertColor_SRGB_RGB((Single)Green / (Single)0xFF, out comp);
						break;
					case 2:
						Pixel.ConvertColor_SRGB_RGB((Single)Red / (Single)0xFF, out comp);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}

				return (comp);
			}
			set {
				Single comp;

				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");

				Pixel.ConvertColor_RGB_SRGB(value, out comp);

				switch (c) {
					case 0:
						Blue = (Byte)(0xFF * comp);
						break;
					case 1:
						Green = (Byte)(0xFF * comp);
						break;
					case 2:
						Red = (Byte)(0xFF * comp);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		#endregion
	}

	#endregion

	#region RGBA Color

	/// <summary>
	/// RGBA color interface.
	/// </summary>
	public interface IColorRGBA<T> : IColorRGB<T>
	{
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		T Alpha { get; set; }
	}

	/// <summary>
	/// RGBA color (30 bits per RGB and 2 bits per A).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGB30A2 : IColorRGBA<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGB30A2(Single r, Single g, Single b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorRGB30A2(Single r, Single g, Single b, Single a)
		{
			rgba = 0;
		}
		
		/// <summary>
		/// Packed Red/Green/Blue/Alpha components for RGBA color. 
		/// </summary>
		public UInt32 rgba;
		
		#endregion
		
		#region IColorRGBA<UInt16> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGB30A2); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Blue / (Single)0xFFFF);
					case 3:
						return ((Single)Alpha / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					case 3:
						Alpha = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (UInt16)((((UInt32)rgba >> 22) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt32)~0xFFC00000);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 22);
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (UInt16)((((UInt32)rgba >> 12) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt16)~0x3FF000);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 12);
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (UInt16)((((UInt32)rgba >> 2) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt16)~0x0FFC);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 2);
			}
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public UInt16 Alpha
		{
			get { return (UInt16)((((UInt32)rgba >> 0) & (UInt32)0x0003) << 14); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt16)~0x0003);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 14) & (UInt32)0x0003) << 0);
			}
		}
		
		#endregion
	}
	
	/// <summary>
	/// RGBA color (32 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 4)]
	public struct ColorRGBA32 : IColorRGBA<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGBA32(Single r, Single g, Single b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorRGBA32(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = (Byte)(0xFF * r);
			this.g = (Byte)(0xFF * g);
			this.b = (Byte)(0xFF * b);
			this.a = (Byte)(0xFF * a);
		}
		
		/// <summary>
		/// Red component for RGBA color. 
		/// </summary>
		public Byte r;
		/// <summary>
		/// Green component for RGBA color. 
		/// </summary>
		public Byte g;
		/// <summary>
		/// Blue component for RGBA color. 
		/// </summary>
		public Byte b;
		/// <summary>
		/// Alpha component for RGBA color. 
		/// </summary>
		public Byte a;
		
		#endregion
		
		#region IColorRGBA<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBA32); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Blue / (Single)0xFF);
					case 3:
						return ((Single)Alpha / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 3:
						Alpha = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Byte Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGBA color (64 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 4)]
	public struct ColorRGBA64 : IColorRGBA<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGBA64(Single r, Single g, Single b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorRGBA64(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = (UInt16)(0xFFFF * r);
			this.g = (UInt16)(0xFFFF * g);
			this.b = (UInt16)(0xFFFF * b);
			this.a = (UInt16)(0xFFFF * a);
		}
		
		/// <summary>
		/// Red component for RGBA color. 
		/// </summary>
		public UInt16 r;
		/// <summary>
		/// Green component for RGBA color. 
		/// </summary>
		public UInt16 g;
		/// <summary>
		/// Blue component for RGBA color. 
		/// </summary>
		public UInt16 b;
		/// <summary>
		/// Alpha component for RGBA color. 
		/// </summary>
		public UInt16 a;
		
		#endregion
		
		#region IColorRGBA<UInt16> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBA64); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Blue / (Single)0xFFFF);
					case 3:
						return ((Single)Alpha / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					case 3:
						Alpha = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public UInt16 Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGBA color (single-precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 4)]
	public struct ColorRGBAF : IColorRGBA<Single>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorRGBAF(Single r, Single g, Single b) :
			this(r, g, b, 1.0f)
		{
			
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorRGBAF(Single r, Single g, Single b, Single a) 
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		/// <summary>
		/// ColorRGBAF (copy) constructor.
		/// </summary>
		/// <param name="c">
		/// The <see cref="ColorRGBAF"/> dst be copied.
		/// </param>
		public ColorRGBAF(ColorRGBAF c)
		{
			this.r = c.r;
			this.g = c.g;
			this.b = c.b;
			this.a = c.a;
		}
		
		/// <summary>
		/// Red component for RGBA color. 
		/// </summary>
		private Single r;
		/// <summary>
		/// Green component for RGBA color. 
		/// </summary>
		private Single g;
		/// <summary>
		/// Blue component for RGBA color. 
		/// </summary>
		private Single b;
		/// <summary>
		/// Alpha component for RGBA color. 
		/// </summary>
		private Single a;
		
		#endregion

		#region Cast

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns>
		/// </returns>
		public static explicit operator float[](ColorRGBAF value)
		{
			float[] v = new float[4];
			
			v[0] = value.r;
			v[1] = value.g;
			v[2] = value.b;
			v[3] = value.a;
			
			return (v);
		}
		
		#endregion

		#region Notable Colors

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBAF RedColor = new ColorRGBAF(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBAF GreenColor = new ColorRGBAF(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBAF BlueColor = new ColorRGBAF(0.0f, 0.0f, 1.0f);

		#endregion

		#region IColorRGBA<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBAF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Red);
					case 1:
						return (Green);
					case 2:
						return (Blue);
					case 3:
						return (Alpha);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Red = value;
						break;
					case 1:
						Green = value;
						break;
					case 2:
						Blue = value;
						break;
					case 3:
						Alpha = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public Single Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Single Blue
		{
			get { return (b); }
			set { b = value; }
		}
		
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Single Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion

		#region Object Overrides

		///<summary>
		/// Converts this IColor into a human-legible string representation.
		///</summary>
		///<returns>
		///The string representation of this instance.
		///</returns>
		public override string ToString()
		{
			return (String.Format("{0} {1} {2} {3}", Red, Green, Blue, Alpha));
		}

		#endregion
	}

	/// <summary>
	/// RGB color (half floating point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorRGBAHF : IColorRGBA<HalfFloat>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorRGBAHF(HalfFloat r, HalfFloat g, HalfFloat b, HalfFloat a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		/// <summary>
		/// ColorRGBAHF (copy) constructor.
		/// </summary>
		/// <param name="c">
		/// The <see cref="ColorRGBAHF"/> dst be copied.
		/// </param>
		public ColorRGBAHF(ColorRGBAHF c)
		{
			this.r = c.r;
			this.g = c.g;
			this.b = c.b;
			this.a = c.a;
		}

		/// <summary>
		/// Red component for RGBA color. 
		/// </summary>
		private HalfFloat r;
		/// <summary>
		/// Green component for RGBA color. 
		/// </summary>
		private HalfFloat g;
		/// <summary>
		/// Blue component for RGBA color. 
		/// </summary>
		private HalfFloat b;
		/// <summary>
		/// Alpha component for RGBA color. 
		/// </summary>
		private HalfFloat a;

		#endregion

		#region IColorRGBA<HalfFloat> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RGBAHF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Red);
					case 1:
						return ((Single)Green);
					case 2:
						return ((Single)Blue);
					case 3:
						return ((Single)Alpha);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Red = (HalfFloat)value;
						break;
					case 1:
						Green = (HalfFloat)value;
						break;
					case 2:
						Blue = (HalfFloat)value;
						break;
					case 3:
						Alpha = (HalfFloat)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public HalfFloat Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public HalfFloat Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public HalfFloat Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public HalfFloat Alpha
		{
			get { return (a); }
			set { a = value; }
		}

		#endregion
	}
	
	#endregion

	#region BGR Color

	/// <summary>
	/// BGR color interface.
	/// </summary>
	public interface IColorBGR<T> : IColor
	{
		/// <summary>
		/// Blue component property.
		/// </summary>
		T Blue { get; set; }

		/// <summary>
		/// Green component property.
		/// </summary>
		T Green { get; set; }

		/// <summary>
		/// Red component property.
		/// </summary>
		T Red { get; set; }
	}

	/// <summary>
	/// BGR color (8 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR8 : IColorBGR<Byte>
	{
		#region Storage

		/// <summary>
		/// RGB color (8 bits).
		/// </summary>
		private Byte bgr;

		#endregion

		#region IColorRGB<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR8); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Red / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Red = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)((((Byte)bgr >> 6) & (Byte)0x03) << 6); }
			set {
				// Reset previous green value
				bgr &= unchecked((Byte)~0xC0);
				// Assign current green component
				bgr |= (Byte)unchecked((((Byte)value >> 6) & (Byte)0x03) << 6);
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)((((Byte)bgr >> 3) & (Byte)0x07) << 5); }
			set {
				// Reset previous green value
				bgr &= unchecked((Byte)~0x38);
				// Assign current green component
				bgr |= (Byte)unchecked((((Byte)value >> 5) & (Byte)0x07) << 3);
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)(((bgr >> 0) & 0x07) << 5); }
			set {
				// Reset previous green value
				bgr &= unchecked((Byte)~0x07);
				// Assign current green component
				bgr |= (Byte)unchecked((((Byte)value >> 5) & (Byte)0x07) << 0);
			}
		}

		#endregion
	}

	/// <summary>
	/// BGR color (16 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR15 : IColorBGR<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Packed Blue-Green-Red components for BGR color. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// The RGB color components disposition is represented in the following:
		/// <i>MSB -------- LSB</i>
		/// <i>XBBBBBGGGGGRRRRR</i>
		/// </para>
		/// </remarks>
		private UInt16 bgr;

		#endregion

		#region IColorBGR<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR15); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Red / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Red = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)((((UInt16)bgr >> 11) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0xF800);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 11);
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)((((UInt16)bgr >> 6) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0x0380);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 6);
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)((((UInt16)bgr >> 1) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0x001F);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 1);
			}
		}

		#endregion
	}

	/// <summary>
	/// BGR color (16 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR16 : IColorBGR<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Packed Blue-Green-Red components for BGR color. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// The RGB color components disposition is represented in the following:
		/// <i>MSB -------- LSB</i>
		/// <i>BBBBBGGGGGGRRRRR</i>
		/// </para>
		/// </remarks>
		private UInt16 bgr;

		#endregion

		#region IColorBGR<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR16); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Red / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Red = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (Byte)((((UInt16)bgr >> 11) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0x7C00);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 11);
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (Byte)((((UInt16)bgr >> 5) & (UInt16)0x003F) << 2); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0x07E0);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 2) & (UInt16)0x003F) << 5);
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (Byte)((((UInt16)bgr >> 0) & (UInt16)0x001F) << 3); }
			set {
				// Reset previous green value
				bgr &= unchecked((UInt16)~0x001F);
				// Assign current green component
				bgr |= (UInt16)unchecked((((UInt16)value >> 3) & (UInt16)0x001F) << 0);
			}
		}

		#endregion
	}

	/// <summary>
	/// BGR color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR24 : IColorBGR<Byte>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private Byte b;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private Byte g;
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private Byte r;
		
		#endregion
		
		#region IColorBGR<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR24); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Red / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Red = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// BGR color (48 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR48 : IColorBGR<UInt16>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private UInt16 b;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private UInt16 g;
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private UInt16 r;
		
		#endregion
		
		#region IColorBGR<UInt16> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR48); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Red / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (g); }
			set { g = value; }
		}
		
		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// BGR color (single-precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRF : IColorBGR<Single>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private Single b;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private Single g;
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private Single r;
		
		#endregion
		
		#region IColorBGR<Single> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Blue);
					case 1:
						return (Green);
					case 2:
						return (Red);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Blue = value;
						break;
					case 1:
						Green = value;
						break;
					case 2:
						Red = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Single Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Single Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Single Alpha
		{
			get { return (0); }
			set { }
		}
		
		#endregion
	}

	/// <summary>
	/// BGR color (half-precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRHF : IColorBGR<HalfFloat>
	{
		#region Constructors & Structure
		
		/// <summary>
		/// Blue component for RGB color. 
		/// </summary>
		private HalfFloat b;
		/// <summary>
		/// Green component for RGB color. 
		/// </summary>
		private HalfFloat g;
		/// <summary>
		/// Red component for RGB color. 
		/// </summary>
		private HalfFloat r;
		
		#endregion
		
		#region IColorBGR<Single> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRHF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Blue);
					case 1:
						return (Green);
					case 2:
						return (Red);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Blue = (HalfFloat)value;
						break;
					case 1:
						Green = (HalfFloat)value;
						break;
					case 2:
						Red = (HalfFloat)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public HalfFloat Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public HalfFloat Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public HalfFloat Red
		{
			get { return (r); }
			set { r = value; }
		}
		
		#endregion
	}

	#endregion

	#region BGRA Color

	/// <summary>
	/// ARGB color interface.
	/// </summary>
	public interface IColorBGRA<T> : IColorBGR<T>
	{
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		T Alpha { get; set; }
	}

	/// <summary>
	/// BGRA color (30 bits per BGR and 2 bits per A).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGR30A2 : IColorRGBA<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorBGR30A2(Single r, Single g, Single b) :
			this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorBGR30A2(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));
			
			rgba = 0;
		}
		
		/// <summary>
		/// Packed Blue/Green/Red/Alpha components for BGRA color. 
		/// </summary>
		public UInt32 rgba;
		
		#endregion
		
		#region IColorBGRA<UInt16> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGR30A2); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Red / (Single)0xFFFF);
					case 3:
						return ((Single)Alpha / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					case 3:
						Alpha = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (UInt16)((((UInt32)rgba >> 22) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt32)~0xFFC00000);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 22);
			}
		}
		
		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (UInt16)((((UInt32)rgba >> 12) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt32)~0x3FF000);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 12);
			}
		}
		
		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (UInt16)((((UInt32)rgba >> 2) & (UInt32)0x03FF) << 6); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt32)~0x0FFC);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 6) & (UInt32)0x03FF) << 2);
			}
		}
		
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public UInt16 Alpha
		{
			get { return (UInt16)((((UInt32)rgba >> 0) & (UInt32)0x0003) << 14); }
			set {
				// Reset previous green value
				rgba &= unchecked((UInt32)~0x0003);
				// Assign current green component
				rgba |= (UInt32)unchecked((((UInt32)value >> 14) & (UInt32)0x0003) << 0);
			}
		}
		
		#endregion
	}

	/// <summary>
	/// BGRA color (32 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRA32 : IColorBGRA<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorBGRA32(Single r, Single g, Single b) : this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorBGRA32(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = (Byte)(0xFF * r);
			this.g = (Byte)(0xFF * g);
			this.b = (Byte)(0xFF * b);
			this.a = (Byte)(0xFF * a);
		}

		/// <summary>
		/// Blue component for ABGR color.
		/// </summary>
		public Byte b;
		/// <summary>
		/// Green component for ABGR color.
		/// </summary>
		public Byte g;
		/// <summary>
		/// Red component for ABGR color.
		/// </summary>
		public Byte r;
		/// <summary>
		/// Alpha component for ABGR color.
		/// </summary>
		public Byte a;

		#endregion

		#region IColorBGRA<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRA32); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFF);
					case 1:
						return ((Single)Green / (Single)0xFF);
					case 2:
						return ((Single)Red / (Single)0xFF);
					case 3:
						return ((Single)Alpha / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Green = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Red = (Byte)((Single)0xFF * value);
						break;
					case 3:
						Alpha = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Byte Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Byte Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Byte Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Byte Alpha
		{
			get { return (a); }
			set { a = value; }
		}

		#endregion
	}

	/// <summary>
	/// BGRA color (64 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRA64 : IColorBGRA<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorBGRA64(Single r, Single g, Single b) : this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorBGRA64(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = (UInt16)(0xFFFF * r);
			this.g = (UInt16)(0xFFFF * g);
			this.b = (UInt16)(0xFFFF * b);
			this.a = (UInt16)(0xFFFF * a);
		}

		/// <summary>
		/// Blue component for BGRA color.
		/// </summary>
		public UInt16 b;
		/// <summary>
		/// Green component for BGRA color.
		/// </summary>
		public UInt16 g;
		/// <summary>
		/// Red component for BGRA color.
		/// </summary>
		public UInt16 r;
		/// <summary>
		/// Alpha component for BGRA color.
		/// </summary>
		public UInt16 a;

		#endregion

		#region IColorBGRA<UInt16> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRA64); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Blue / (Single)0xFFFF);
					case 1:
						return ((Single)Green / (Single)0xFFFF);
					case 2:
						return ((Single)Red / (Single)0xFFFF);
					case 3:
						return ((Single)Alpha / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = (UInt16)((Single)0xFFFF * value);
						break;
					case 1:
						Green = (UInt16)((Single)0xFFFF * value);
						break;
					case 2:
						Red = (UInt16)((Single)0xFFFF * value);
						break;
					case 3:
						Alpha = (UInt16)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public UInt16 Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public UInt16 Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public UInt16 Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public UInt16 Alpha
		{
			get { return (a); }
			set { a = value; }
		}

		#endregion
	}

	/// <summary>
	/// BGRA color (single precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRAF : IColorBGRA<Single>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorBGRAF(Single r, Single g, Single b) : this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorBGRAF(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		/// <summary>
		/// Blue component for BGRA color.
		/// </summary>
		public Single b;
		/// <summary>
		/// Green component for BGRA color.
		/// </summary>
		public Single g;
		/// <summary>
		/// Red component for BGRA color.
		/// </summary>
		public Single r;
		/// <summary>
		/// Alpha component for BGRA color.
		/// </summary>
		public Single a;

		#endregion

		#region IColorBGRA<Single> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRAF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Blue);
					case 1:
						return (Green);
					case 2:
						return (Red);
					case 3:
						return (Alpha);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Blue = value;
						break;
					case 1:
						Green = value;
						break;
					case 2:
						Red = value;
						break;
					case 3:
						Alpha = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public Single Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public Single Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Single Alpha
		{
			get { return (a); }
			set { a = value; }
		}

		#endregion
	}

	/// <summary>
	/// BGRA color (single precision floating-point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorBGRAHF : IColorBGRA<HalfFloat>
	{
		#region Constructors & Structure

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public ColorBGRAHF(Single r, Single g, Single b) : this(r, g, b, 1.0f)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		public ColorBGRAHF(Single r, Single g, Single b, Single a)
		{
			Debug.Assert((r >= 0.0f) && (r <= 1.0f));
			Debug.Assert((g >= 0.0f) && (g <= 1.0f));
			Debug.Assert((b >= 0.0f) && (b <= 1.0f));
			Debug.Assert((a >= 0.0f) && (a <= 1.0f));

			this.r = (HalfFloat)r;
			this.g = (HalfFloat)g;
			this.b = (HalfFloat)b;
			this.a = (HalfFloat)a;
		}

		/// <summary>
		/// Blue component for BGRA color.
		/// </summary>
		public HalfFloat b;
		/// <summary>
		/// Green component for BGRA color.
		/// </summary>
		public HalfFloat g;
		/// <summary>
		/// Red component for BGRA color.
		/// </summary>
		public HalfFloat r;
		/// <summary>
		/// Alpha component for BGRA color.
		/// </summary>
		public HalfFloat a;

		#endregion

		#region IColorBGRA<HalfFloat> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.BGRAHF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Blue);
					case 1:
						return (Green);
					case 2:
						return (Red);
					case 3:
						return (Alpha);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Blue = (HalfFloat)value;
						break;
					case 1:
						Green = (HalfFloat)value;
						break;
					case 2:
						Red = (HalfFloat)value;
						break;
					case 3:
						Alpha = (HalfFloat)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Blue component property. 
		/// </summary>
		public HalfFloat Blue
		{
			get { return (b); }
			set { b = value; }
		}

		/// <summary>
		/// Green component property. 
		/// </summary>
		public HalfFloat Green
		{
			get { return (g); }
			set { g = value; }
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public HalfFloat Red
		{
			get { return (r); }
			set { r = value; }
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public HalfFloat Alpha
		{
			get { return (a); }
			set { a = value; }
		}

		#endregion
	}

	#endregion

	#region Grayscale Color

	/// <summary>
	/// Single component color interface.
	/// </summary>
	public interface IColorGRAY<T> : IColor
	{
		/// <summary>
		/// Unique component property.
		/// </summary>
		T Level { get; set; }
	}

	/// <summary>
	/// Single component color (8 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAY8 : IColorGRAY<Byte>
	{
		#region Storage

		/// <summary>
		/// Unique component color (8 bits).
		/// </summary>
		private Byte c;

		#endregion

		#region IColorGRAY<Byte> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAY8); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Level / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Level = (Byte)(value * 0xFF);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Luminance component property.
		/// </summary>
		public Byte Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		#endregion
	}

	/// <summary>
	/// Single component color (16 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAY16 : IColorGRAY<UInt16>
	{
		#region Storage

		/// <summary>
		/// Unique component color (16 bits).
		/// </summary>
		private UInt16 c;

		#endregion

		#region IColorGRAY<UInt16> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAY16); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Level / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Level = (UInt16)(value * 0xFFFF);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Luminance component property.
		/// </summary>
		public UInt16 Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		#endregion
	}

	/// <summary>
	/// Single component color (16 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAY16S : IColorGRAY<Int16>
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorGRAY16S specifying its level.
		/// </summary>
		/// <param name="level">
		/// A <see cref="Int16"/> that specify the grayscale level.
		/// </param>
		public ColorGRAY16S(Int16 level)
		{
			c = level;
		}

		#endregion

		#region Storage

		/// <summary>
		/// Unique component color (16 bits).
		/// </summary>
		private Int16 c;

		#endregion

		#region IColorGRAY<UInt16> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAY16S); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Level / (Single)0x7FFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < -1.0f) || (value > +1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Level = (Int16)(value * 0x7FFF);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Luminance component property.
		/// </summary>
		public Int16 Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		#endregion
	}

	/// <summary>
	/// Single component color (32 bits IEEE floating point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAYF : IColorGRAY<Single>
	{
		#region Storage

		/// <summary>
		/// Unique component color (Single).
		/// </summary>
		private Single c;

		#endregion

		#region IColorGRAY<Single> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAYF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Level);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Level = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		#endregion
	}

	/// <summary>
	/// Single component color (32 bits IEEE floating point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAYHF : IColorGRAY<HalfFloat>
	{
		#region Storage

		/// <summary>
		/// Unique component color (half-precision floating-point).
		/// </summary>
		private HalfFloat c;

		#endregion

		#region IColorGRAY<Single> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAYHF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Level);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Level = (HalfFloat)value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public HalfFloat Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		#endregion
	}

	#endregion

	#region Grayscale and Alpha Color

	/// <summary>
	/// Double component color interface.
	/// </summary>
	public interface IColorGRAYA<T> : IColorGRAY<T>
	{
		/// <summary>
		/// Alpha property.
		/// </summary>
		T Alpha { get; set; }
	}

	/// <summary>
	/// Double component color (32 bits IEEE floating point).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorGRAYAF : IColorGRAYA<Single>
	{
		#region Storage

		/// <summary>
		/// Unique component color (Single).
		/// </summary>
		private Single c;

		/// <summary>
		/// Alpha component color (Single).
		/// </summary>
		private Single a;

		#endregion

		#region IColorGRAY<Single> Implementation

		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.GRAYAF); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return (Level);
					case 1:
						return (Alpha);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				switch (c) {
					case 0:
						Level = value;
						break;
					case 1:
						Alpha = value;
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}

		/// <summary>
		/// Red component property. 
		/// </summary>
		public Single Level
		{
			get { return (c); }
			set {
				c = value;
			}
		}

		/// <summary>
		/// Alpha component property. 
		/// </summary>
		public Single Alpha
		{
			get { return (a); }
			set {
				a = value;
			}
		}

		#endregion
	}

	#endregion

	#region CMYK Color

	/// <summary>
	/// CMYK color interface.
	/// </summary>
	public interface IColorCMYK<T> : IColor
	{
		/// <summary>
		/// Cyan component property.
		/// </summary>
		T Cyan { get; set; }
		
		/// <summary>
		/// Magenta component property.
		/// </summary>
		T Magenta { get; set; }
		
		/// <summary>
		/// Yellow component property.
		/// </summary>
		T Yellow { get; set; }

		/// <summary>
		/// Yellow component property.
		/// </summary>
		T Black { get; set; }
	}

	/// <summary>
	/// CMY color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorCMY24 : IColorCMYK<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Cyan component for CMYK color. 
		/// </summary>
		public Byte c;
		/// <summary>
		/// Magenta component for CMYK color. 
		/// </summary>
		public Byte m;
		/// <summary>
		/// Yellow component for CMYK color. 
		/// </summary>
		public Byte y;
		
		#endregion
		
		#region IColorCMYK<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.CMY24); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Cyan / (Single)0xFF);
					case 1:
						return ((Single)Magenta / (Single)0xFF);
					case 2:
						return ((Single)Yellow / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Cyan = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Magenta = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Yellow = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Cyan component property. 
		/// </summary>
		public Byte Cyan
		{
			get { return (c); }
			set { c = value; }
		}
		
		/// <summary>
		/// Magenta component property. 
		/// </summary>
		public Byte Magenta
		{
			get { return (m); }
			set { m = value; }
		}
		
		/// <summary>
		/// Yellow component property. 
		/// </summary>
		public Byte Yellow
		{
			get { return (y); }
			set { y = value; }
		}
		
		/// <summary>
		/// Black component property. 
		/// </summary>
		public Byte Black
		{
			get { return (0); }
			set { throw new NotImplementedException(); }
		}
		
		#endregion
	}

	/// <summary>
	/// CMYK color (32 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorCMYK32 : IColorCMYK<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Cyan component for CMYK color. 
		/// </summary>
		public Byte c;
		/// <summary>
		/// Magenta component for CMYK color. 
		/// </summary>
		public Byte m;
		/// <summary>
		/// Yellow component for CMYK color. 
		/// </summary>
		public Byte y;
		/// <summary>
		/// Black component for CMYK color. 
		/// </summary>
		public Byte k;
		
		#endregion
		
		#region IColorCMYK<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.CMYK32); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Cyan / (Single)0xFF);
					case 1:
						return ((Single)Magenta / (Single)0xFF);
					case 2:
						return ((Single)Yellow / (Single)0xFF);
					case 3:
						return ((Single)Black / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Cyan = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Magenta = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Yellow = (Byte)((Single)0xFF * value);
						break;
					case 3:
						Black = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Cyan component property. 
		/// </summary>
		public Byte Cyan
		{
			get { return (c); }
			set { c = value; }
		}
		
		/// <summary>
		/// Magenta component property. 
		/// </summary>
		public Byte Magenta
		{
			get { return (m); }
			set { m = value; }
		}
		
		/// <summary>
		/// Yellow component property. 
		/// </summary>
		public Byte Yellow
		{
			get { return (y); }
			set { y = value; }
		}
		
		/// <summary>
		/// Black component property. 
		/// </summary>
		public Byte Black
		{
			get { return (k); }
			set { k = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// CMYK color (32 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorCMYK64 : IColorCMYK<UInt16>
	{
		#region Constructors & Structure

		/// <summary>
		/// Cyan component for CMYK color. 
		/// </summary>
		public UInt16 c;
		/// <summary>
		/// Magenta component for CMYK color. 
		/// </summary>
		public UInt16 m;
		/// <summary>
		/// Yellow component for CMYK color. 
		/// </summary>
		public UInt16 y;
		/// <summary>
		/// Black component for CMYK color. 
		/// </summary>
		public UInt16 k;
		
		#endregion
		
		#region IColorCMYK<UShort> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.CMYK64); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Cyan / (Single)0xFFFF);
					case 1:
						return ((Single)Magenta / (Single)0xFFFF);
					case 2:
						return ((Single)Yellow / (Single)0xFFFF);
					case 3:
						return ((Single)Black / (Single)0xFFFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Cyan = (Byte)((Single)0xFFFF * value);
						break;
					case 1:
						Magenta = (Byte)((Single)0xFFFF * value);
						break;
					case 2:
						Yellow = (Byte)((Single)0xFFFF * value);
						break;
					case 3:
						Black = (Byte)((Single)0xFFFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Cyan component property. 
		/// </summary>
		public UInt16 Cyan
		{
			get { return (c); }
			set { c = value; }
		}
		
		/// <summary>
		/// Magenta component property. 
		/// </summary>
		public UInt16 Magenta
		{
			get { return (m); }
			set { m = value; }
		}
		
		/// <summary>
		/// Yellow component property. 
		/// </summary>
		public UInt16 Yellow
		{
			get { return (y); }
			set { y = value; }
		}
		
		/// <summary>
		/// Black component property. 
		/// </summary>
		public UInt16 Black
		{
			get { return (k); }
			set { k = value; }
		}
		
		#endregion
	}

	/// <summary>
	/// RGBA color interface.
	/// </summary>
	public interface IColorCMYKA<T> : IColorCMYK<T>
	{
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		T Alpha { get; set; }
	}

	/// <summary>
	/// CMYK color (32 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorCMYKA40 : IColorCMYK<Byte>
	{
		#region Constructors & Structure

		/// <summary>
		/// Cyan component for CMYKA color. 
		/// </summary>
		public Byte c;
		/// <summary>
		/// Magenta component for CMYKA color. 
		/// </summary>
		public Byte m;
		/// <summary>
		/// Yellow component for CMYKA color. 
		/// </summary>
		public Byte y;
		/// <summary>
		/// Black component for CMYKA color. 
		/// </summary>
		public Byte k;
		/// <summary>
		/// Alpha component for CMYKA color. 
		/// </summary>
		public Byte a;
		
		#endregion
		
		#region IColorCMYKA<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.CMYKA40); } }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index (0 based).
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number,
		/// where 0.0f indicates lowest intensity, while 1.0f indicated highest intensity.
		/// </returns>
		public Single this[int c]
		{
			get {
				switch (c) {
					case 0:
						return ((Single)Cyan / (Single)0xFF);
					case 1:
						return ((Single)Magenta / (Single)0xFF);
					case 2:
						return ((Single)Yellow / (Single)0xFF);
					case 3:
						return ((Single)Black / (Single)0xFF);
					case 4:
						return ((Single)Alpha / (Single)0xFF);
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
			set {
				if ((value < 0.0f) || (value > 1.0f))
					throw new ArgumentException(String.Format("component value not normalized for pixel type {0}", PixelType), "value");
				switch (c) {
					case 0:
						Cyan = (Byte)((Single)0xFF * value);
						break;
					case 1:
						Magenta = (Byte)((Single)0xFF * value);
						break;
					case 2:
						Yellow = (Byte)((Single)0xFF * value);
						break;
					case 3:
						Black = (Byte)((Single)0xFF * value);
						break;
					case 4:
						Alpha = (Byte)((Single)0xFF * value);
						break;
					default:
						throw new ArgumentException(String.Format("invalid component index {0} for pixel type {1}", c, PixelType), "c");
				}
			}
		}
		
		/// <summary>
		/// Cyan component property. 
		/// </summary>
		public Byte Cyan
		{
			get { return (c); }
			set { c = value; }
		}
		
		/// <summary>
		/// Magenta component property. 
		/// </summary>
		public Byte Magenta
		{
			get { return (m); }
			set { m = value; }
		}
		
		/// <summary>
		/// Yellow component property. 
		/// </summary>
		public Byte Yellow
		{
			get { return (y); }
			set { y = value; }
		}
		
		/// <summary>
		/// Black component property. 
		/// </summary>
		public Byte Black
		{
			get { return (k); }
			set { k = value; }
		}

		/// <summary>
		/// Black component property. 
		/// </summary>
		public Byte Alpha
		{
			get { return (a); }
			set { a = value; }
		}
		
		#endregion
	}

	#endregion

	#region Integer Color

	/// <summary>
	/// One integer component color interface.
	/// </summary>
	public interface IColorInteger1<T> : IFragment
	{
		/// <summary>
		/// Get the first integer component.
		/// </summary>
		T X { get; }
	}

	/// <summary>
	/// Two integer component color interface.
	/// </summary>
	public interface IColorInteger2<T> : IFragment
	{
		/// <summary>
		/// Get the first integer component.
		/// </summary>
		T X { get; }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		T Y { get; }
	}

	/// <summary>
	/// Three integer component color interface.
	/// </summary>
	public interface IColorInteger3<T> : IFragment
	{
		/// <summary>
		/// Get the first integer component.
		/// </summary>
		T X { get; }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		T Y { get; }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		T Z { get; }
	}

	/// <summary>
	/// Four integer component color interface.
	/// </summary>
	public interface IColorInteger4<T> : IFragment
	{
		/// <summary>
		/// Get the first integer component.
		/// </summary>
		T X { get; }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		T Y { get; }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		T Z { get; }

		/// <summary>
		/// Get the fourth integer component.
		/// </summary>
		T W { get; }
	}

	#endregion

	#region Luminance/Chrominance Color

	/// <summary>
	/// YUYV color (2 components per pixel).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorPackedYUYV : IFragment
	{
		#region Constructors & Structure

		/// <summary>
		/// Packed YUV component for color.
		/// </summary>
		private Byte S;
		/// <summary>
		/// Packed YUV component for color.
		/// </summary>
		private Byte T;

		#endregion
		
		#region IColorRGB<Byte> Implementation
		
		/// <summary>
		/// PixelLayout of this IColor. 
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.YUYV); } }

		#endregion
	}

	#endregion
}
