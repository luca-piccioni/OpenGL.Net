
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
	/// Pixel planes attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPlanesAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelPlanesAttribute"/> class.
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