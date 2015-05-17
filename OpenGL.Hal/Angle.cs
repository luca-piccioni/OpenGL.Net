
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
	/// Frequently used operations and definitions on angles.
	/// </summary>
	public sealed class Angle
	{
		/// <summary>
		/// Constant for converting degrees to radians.
		/// </summary>
		public const double DegreeToRadian = Math.PI / 180.0;

		/// <summary>
		/// Constant for converting radians to degree.
		/// </summary>
		public const double RadianToDegree = 180.0 / Math.PI;

		/// <summary>
		/// Normalize an angle in the range [0,360).
		/// </summary>
		/// <param name="angle">
		/// A <see cref="Double"/> that is the angle to be normalized, in degrees.
		/// </param>
		/// <returns>
		/// It returns the normalized value of <paramref name="angle"/>.
		/// </returns>
		public static double Normalize(double angle)
		{
			return (Math.IEEERemainder(angle, 360.0));
		}
	}
}
