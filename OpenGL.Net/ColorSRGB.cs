
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
	/// sRGB color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorSRGB24 : IColorRGB<byte>
	{
		#region Structure
		
		/// <summary>
		/// Red component for sRGB color. 
		/// </summary>
		private byte r;

		/// <summary>
		/// Green component for sRGB color. 
		/// </summary>
		private byte g;

		/// <summary>
		/// Blue component for sRGB color. 
		/// </summary>
		private byte b;
		
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
		public Single this[int c]
		{
			get {
				Single comp;

				switch (c) {
					case 0: Pixel.ConvertColor_SRGB_RGB((Single)Red   / byte.MaxValue, out comp); break;
					case 1: Pixel.ConvertColor_SRGB_RGB((Single)Green / byte.MaxValue, out comp); break;
					case 2: Pixel.ConvertColor_SRGB_RGB((Single)Blue  / byte.MaxValue, out comp); break;
					default:
						throw new IndexOutOfRangeException();
				}

				return (comp);
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");

				float comp;

				Pixel.ConvertColor_RGB_SRGB(value, out comp);

				switch (c) {
					case 0: Red =   (byte)(comp * byte.MaxValue); break;
					case 1: Green = (byte)(comp * byte.MaxValue); break;
					case 2: Blue =  (byte)(comp * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// sBGR color (24 bits).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ColorSBGR24 : IColorRGB<Byte>
	{
		#region Structure
		
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
		public PixelLayout PixelType { get { return (PixelLayout.SBGR24); } }

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
		public Single this[int c]
		{
			get {
				Single comp;

				switch (c) {
					case 2: Pixel.ConvertColor_SRGB_RGB((Single)Red   / byte.MaxValue, out comp); break;
					case 1: Pixel.ConvertColor_SRGB_RGB((Single)Green / byte.MaxValue, out comp); break;
					case 0: Pixel.ConvertColor_SRGB_RGB((Single)Blue  / byte.MaxValue, out comp); break;
					default:
						throw new IndexOutOfRangeException();
				}

				return (comp);
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");

				float comp;

				Pixel.ConvertColor_RGB_SRGB(value, out comp);

				switch (c) {
					case 2: Red =   (byte)(comp * byte.MaxValue); break;
					case 1: Green = (byte)(comp * byte.MaxValue); break;
					case 0: Blue =  (byte)(comp * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}
		
		#endregion
	}
}
