
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

namespace OpenGL
{
	/// <summary>
	/// Generic color interface.
	/// </summary>
	public interface IColor : IFragment
	{
		/// <summary>
		/// Get the correponding PixelLayout of this IColor.
		/// </summary>
		PixelLayout PixelType { get; }

		/// <summary>
		/// Color component access.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component is converted to/from a normalized floating point number.
		/// </returns>
		Single this[int c] { get; set; }
	}

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
	/// RGBA color interface.
	/// </summary>
	public interface IColorRGBA<T> : IColorRGB<T>
	{
		/// <summary>
		/// Alpha component property. 
		/// </summary>
		T Alpha { get; set; }
	}
}
