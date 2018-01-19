
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
	/// Replacement for System.Drawing.Size, not available on every supported platform.
	/// </summary>
	public struct Size : IEquatable<Size>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Size structure from the specified dimensions.
		/// </summary>
		/// <param name="width">
		/// The width component of the new Size.
		/// </param>
		/// <param name="height">
		/// The height component of the new Size.
		/// </param>
		public Size(int width, int height)
		{
			Width = width;
			Height = height;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Gets or sets the horizontal component of this Size structure.
		/// </summary>
		public int Width;

		/// <summary>
		/// Gets or sets the vertical component of this Size structure.
		/// </summary>
		public int Height;

		/// <summary>
		/// Tests whether this Size structure has width and height of 0.
		/// </summary>
		public bool IsEmpty { get { return Width == 0 && Height == 0; } }

		#endregion

		#region Notable Size

		/// <summary>
		/// Gets a Size structure that has a Height and Width value of 0.
		/// </summary>
		public static readonly Size Empty = new Size(0, 0);

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Size v1, Size v2)
		{
			return v1.Equals(v2);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Size v1, Size v2)
		{
			return !v1.Equals(v2);
		}

		#endregion

		#region IEquatable Implementation

		/// <summary>
		/// Indicates whether the this Size is equal to another Size.
		/// </summary>
		/// <param name="other">
		/// The <see cref="Size"/> to compare with this Size.
		/// </param>
		/// <returns>
		/// It returns true if the this Size is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(Size other)
		{
			return Width == other.Width && Height == other.Height;
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
			if (obj.GetType() != typeof(Size))
				return false;
			
			return Equals((Size)obj);
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
				int result = Width.GetHashCode();
				result = (result * 397) ^ Height.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Size.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Size.
		/// </returns>
		public override string ToString()
		{
			return $"Size: {Width}x{Height}";
		}

		#endregion
	}
}
