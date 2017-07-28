
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
