
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