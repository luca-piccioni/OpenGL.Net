
// Copyright (C) 2012-2017 Luca Piccioni
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
	/// Attribute for marking a pixel format as non-linear one.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Linearity of a pixel is meant as the capability of the pixel format to represent a color in a fixed
	/// range, usually representable in the uniform range [0.0, 1.0]. This characteristic allow to blend two
	/// colors correctly, since a function of two linear functions is still linear.
	/// </para>
	/// <para>
	/// Non-linear pixel formats may be blended after has been converted into a linear pixel format.
	/// </para>
	/// </remarks>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelNonLinearAttribute : Attribute
	{

	}
}