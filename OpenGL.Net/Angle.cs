
// Copyright (C) 2012-2017 Luca Piccioni
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
		/// Normalize an angle in the range [0,360).
		/// </summary>
		/// <param name="angle">
		/// A <see cref="Double"/> that is the angle to be normalized, in degrees.
		/// </param>
		/// <returns>
		/// It returns the normalized value of <paramref name="angle"/>.
		/// </returns>
		public static double Normalize360(double angle)
		{
			return (Math.IEEERemainder(angle, 360.0));
		}

		/// <summary>
		/// Convert angle from radian units to degree units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="Double"/> that specifies the angle to convert, in radians.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Double"/> that is <paramref name="radians"/>, but expressed in degress.
		/// </returns>
		public static double ToDegrees(double radians)
		{
			return (radians / Math.PI * 180.0);
		}

		/// <summary>
		/// Convert angle from radian units to degree units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="Single"/> that specifies the angle to convert, in radians.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Single"/> that is <paramref name="radians"/>, but expressed in degress.
		/// </returns>
		public static float ToDegrees(float radians)
		{
			return (radians / (float)Math.PI * 180.0f);
		}

		/// <summary>
		/// Convert angle from degree units to radian units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="Double"/> that specifies the angle to convert, in degress.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Double"/> that is <paramref name="radians"/>, but expressed in radians.
		/// </returns>
		public static double ToRadians(double degrees)
		{
			return (degrees / 180.0 * Math.PI);
		}

		/// <summary>
		/// Convert angle from degree units to radian units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="Single"/> that specifies the angle to convert, in degress.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Single"/> that is <paramref name="radians"/>, but expressed in radians.
		/// </returns>
		public static float ToRadians(float degrees)
		{
			return (degrees / 180.0f * (float)Math.PI);
		}
	}
}
