
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
	/// Frequently used operations and definitions on angles.
	/// </summary>
	public sealed class Angle
	{
		/// <summary>
		/// Normalize an angle in the range [0,360).
		/// </summary>
		/// <param name="angle">
		/// A <see cref="double"/> that is the angle to be normalized, in degrees.
		/// </param>
		/// <returns>
		/// It returns the normalized value of <paramref name="angle"/>.
		/// </returns>
		public static double Normalize360(double angle)
		{
			return Math.IEEERemainder(angle, 360.0);
		}

		/// <summary>
		/// Normalize an angle in the range [0,360).
		/// </summary>
		/// <param name="angle">
		/// A <see cref="float"/> that is the angle to be normalized, in degrees.
		/// </param>
		/// <returns>
		/// It returns the normalized value of <paramref name="angle"/>.
		/// </returns>
		public static float Normalize360(float angle)
		{
			return (float)Math.IEEERemainder(angle, 360.0);
		}

		/// <summary>
		/// Convert angle from radian units to degree units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="double"/> that specifies the angle to convert, in radians.
		/// </param>
		/// <returns>
		/// It returns a <see cref="double"/> that is <paramref name="radians"/>, but expressed in degress.
		/// </returns>
		public static double ToDegrees(double radians)
		{
			return radians / Math.PI * 180.0;
		}

		/// <summary>
		/// Convert angle from radian units to degree units.
		/// </summary>
		/// <param name="radians">
		/// A <see cref="float"/> that specifies the angle to convert, in radians.
		/// </param>
		/// <returns>
		/// It returns a <see cref="float"/> that is <paramref name="radians"/>, but expressed in degress.
		/// </returns>
		public static float ToDegrees(float radians)
		{
			return radians / (float)Math.PI * 180.0f;
		}

		/// <summary>
		/// Convert angle from degree units to radian units.
		/// </summary>
		/// <param name="degrees">
		/// A <see cref="double"/> that specifies the angle to convert, in degress.
		/// </param>
		/// <returns>
		/// It returns a <see cref="double"/> that is <paramref name="degrees"/>, but expressed in radians.
		/// </returns>
		public static double ToRadians(double degrees)
		{
			return degrees / 180.0 * Math.PI;
		}

		/// <summary>
		/// Convert angle from degree units to radian units.
		/// </summary>
		/// <param name="degrees">
		/// A <see cref="float"/> that specifies the angle to convert, in degress.
		/// </param>
		/// <returns>
		/// It returns a <see cref="float"/> that is <paramref name="degrees"/>, but expressed in radians.
		/// </returns>
		public static float ToRadians(float degrees)
		{
			return degrees / 180.0f * (float)Math.PI;
		}
	}
}
