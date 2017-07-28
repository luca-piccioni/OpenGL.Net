
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
	/// Pixel precision attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPrecisionAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="OpenGL.PixelPrecisionAttribute"/> class.
		/// </summary>
		/// <param name='componentBits'>
		/// The number of bits assigned to each pixel components.
		/// </param>
		public PixelPrecisionAttribute(params byte[] componentBits)
		{
			if ((componentBits == null) || (componentBits.Length == 0))
				throw new ArgumentException("no components", "componentBits");

			// Component bits
			PixelBits = 0;
			foreach (byte bits in componentBits)
				PixelBits += bits;
			// Derive component precision by relative bit count
			PixelPrecision = new double[componentBits.Length];
			for (int i = 0; i < componentBits.Length; i++)
				PixelPrecision[i] = 1.0 / (1 << componentBits[i]);
		}

		/// <summary>
		/// Construct <see cref="PixelPrecisionAttribute"/> class.
		/// </summary>
		/// <param name="epsilon">
		/// The precision of the pixel components.
		/// </param>
		/// <param name='componentBits'>
		/// The number of bits assigned to each pixel components.
		/// </param>
		public PixelPrecisionAttribute(double epsilon, params byte[] componentBits)
		{
			if ((componentBits == null) || (componentBits.Length == 0))
				throw new ArgumentException("no components", "componentBits");

			// Component bits
			PixelBits = 0;
			foreach (byte bits in componentBits)
				PixelBits += bits;
			// Fix precision for all components
			PixelPrecision = new double[componentBits.Length];
			for (int i = 0; i < componentBits.Length; i++)
				PixelPrecision[i] = epsilon;
		}

		/// <summary>
		/// The number of bits to represent color component.
		/// </summary>
		public readonly byte PixelBits;

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly double[] PixelPrecision;
	}
}