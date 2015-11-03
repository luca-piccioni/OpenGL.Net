
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Pixel precision attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPrecisionAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelPrecisionAttribute"/> class.
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
		/// Construct <see cref="Derm.PixelPrecisionAttribute"/> class.
		/// </summary>
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