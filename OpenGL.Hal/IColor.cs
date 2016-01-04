
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

namespace OpenGL
{
	/// <summary>
	/// Generic color interface.
	/// </summary>
	public interface IColor : IFragment
	{
		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		PixelLayout PixelType { get; }

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
		/// <exception cref="ArgumentException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components
		/// of IColor implementor.
		/// </exception>
		Single this[int c] { get; set; }
	}
}
