
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
	/// Pixel planes attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPlanesAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="OpenGL.PixelPlanesAttribute"/> class.
		/// </summary>
		/// <param name='planeCount'>
		/// The number of separate planes defining the pixel color.
		/// </param>
		/// <param name="xratio">
		/// The ratio between the Y plane horizontal length and the U/V plane horizontal length.
		/// </param>
		/// <param name="yratio">
		/// The ratio between the Y plane vertical length and the U/V plane vertical length.
		/// </param>
		public PixelPlanesAttribute(byte planeCount, byte xratio, byte yratio)
		{
			PixelPlanes = planeCount;
			XRatio = xratio;
			YRatio = yratio;
		}

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly byte PixelPlanes;

		/// <summary>
		/// The ratio between the Y plane horizontal length and the U/V plane horizontal length.
		/// </summary>
		public readonly byte XRatio;

		/// <summary>
		/// The ratio between the Y plane vertical length and the U/V plane vertical length.
		/// </summary>
		public readonly byte YRatio;
	}
}