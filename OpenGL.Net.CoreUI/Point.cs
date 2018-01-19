
// Copyright (c) 2017 Luca Piccioni
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

namespace OpenGL.CoreUI
{
	/// <summary>
	/// Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.
	/// </summary>
	public struct Point
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Point class with the specified coordinates.
		/// </summary>
		/// <param name="x">
		/// The horizontal position of the point.
		/// </param>
		/// <param name="y">
		/// The vertical position of the point.
		/// </param>
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Initializes a new instance of the Point class using coordinates specified by an integer value.
		/// </summary>
		/// <param name="v">
		/// A 32-bit integer that specifies the coordinates for the new Point.
		/// </param>
		public Point(int v) : this(v, v)
		{
			
		}

		/// <summary>
		/// Initializes a new instance of the Point class from a Size.
		/// </summary>
		/// <param name="size">
		/// A Size that specifies the coordinates for the new Point.
		/// </param>
		public Point(Size size)
		{
			X = size.Width;
			Y = size.Height;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Gets or sets the x-coordinate of this Point.
		/// </summary>
		public int X;

		/// <summary>
		/// Gets or sets the y-coordinate of this Point.
		/// </summary>
		public int Y;

		/// <summary>
		/// Gets a value indicating whether this Point is empty.
		/// </summary>
		public bool IsEmpty { get { return X == 0 && Y == 0; } }

		#endregion

		#region Notable Size

		/// <summary>
		/// Represents a Point that has X and Y values set to zero.
		/// </summary>
		public static readonly Point Empty = new Point(0, 0);

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Point v1, Point v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Point v1, Point v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Point is equal to another Size.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Point"/> to compare with this Point.
		/// </param>
		/// <returns>
		/// It returns true if the this Point is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Point other)
		{
			return X == other.X && Y == other.Y;
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return false;
			if (obj.GetType() != typeof(Point))
				return false;
			
			return Equals((Point)obj);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Point.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Point.
		/// </returns>
		public override string ToString()
		{
			return $"Point: {X}x{Y}";
		}

		#endregion
	}
}
