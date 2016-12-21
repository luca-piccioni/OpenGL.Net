
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
	/// Color defined as reference type.
	/// </summary>
	public class ColorRGBA : IEquatable<ColorRGBA>
	{
		#region Constructors

		public ColorRGBA(float v)
			: this(v, v, v, v)
		{

		}

		public ColorRGBA(float r, float g, float b)
			: this(r, g, b, 1.0f)
		{

		}

		public ColorRGBA(float r, float g, float b, float a)
		{
			Red = r;
			Green = g;
			Blue = b;
			Alpha = a;
		}

		public ColorRGBA(ColorRGBA c)
		{
			Red = c.Red;
			Green = c.Green;
			Blue = c.Blue;
			Alpha = c.Alpha;
		}

		public ColorRGBA(ColorRGBAF c)
		{
			Red = c.Red;
			Green = c.Green;
			Blue = c.Blue;
			Alpha = c.Alpha;
		}

		#endregion

		#region Color Components

		/// <summary>
		/// Red component.
		/// </summary>
		public float Red;

		/// <summary>
		/// Green component.
		/// </summary>
		public float Green;

		/// <summary>
		/// Blue component.
		/// </summary>
		public float Blue;

		/// <summary>
		/// Alpha component.
		/// </summary>
		public float Alpha;

		#endregion

		#region Notable Colors

		/// <summary>
		/// White color.
		/// </summary>
		public static readonly ColorRGBA ColorWhite = new ColorRGBA(1.0f, 1.0f, 1.0f, 1.0f);

		/// <summary>
		/// Black color.
		/// </summary>
		public static readonly ColorRGBA ColorBlack = new ColorRGBA(0.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Red color.
		/// </summary>
		public static readonly ColorRGBA ColorRed = new ColorRGBA(1.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Green color.
		/// </summary>
		public static readonly ColorRGBA ColorGreen = new ColorRGBA(0.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Blue color.
		/// </summary>
		public static readonly ColorRGBA ColorBlue = new ColorRGBA(0.0f, 0.0f, 1.0f, 1.0f);

		/// <summary>
		/// Yellow color.
		/// </summary>
		public static readonly ColorRGBA ColorYellow = new ColorRGBA(1.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Magenta color.
		/// </summary>
		public static readonly ColorRGBA ColorMagenta = new ColorRGBA(1.0f, 0.0f, 1.0f, 1.0f);

		/// <summary>
		/// Cyan color.
		/// </summary>
		public static readonly ColorRGBA ColorCyan = new ColorRGBA(0.0f, 1.0f, 1.0f, 1.0f);

		#endregion

		#region Cast

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns>
		/// </returns>
		public static implicit operator float[] (ColorRGBA value)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			float[] v = new float[4];

			v[0] = value.Red;
			v[1] = value.Green;
			v[2] = value.Blue;
			v[3] = value.Alpha;

			return (v);
		}

		public static implicit operator ColorRGBAF(ColorRGBA value)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			return (new ColorRGBAF(value.Red, value.Green, value.Blue, value.Alpha));
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(ColorRGBA v1, ColorRGBA v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(ColorRGBA v1, ColorRGBA v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region IEquatable<ColorRGBA> Implementation

		/// <summary>
		/// Indicates whether the this ColorRGBA is equal to another ColorRGBA.
		/// </summary>
		/// <param name="other">
		/// An ColorRGBA to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this ColorRGBA is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ColorRGBA other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(Red - other.Red) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Green - other.Green) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Blue - other.Blue) >= Single.Epsilon)
				return (false);
			if (Math.Abs(Alpha - other.Alpha) >= Single.Epsilon)
				return (false);

			return (true);
		}

		#endregion

		#region Object Overrides

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
				return (false);

			ColorRGBA otherObj = obj as ColorRGBA;
			if (otherObj == null)
				return (false);

			return (Equals(otherObj));
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
				int result = Red.GetHashCode();
				result = (result * 397) ^ Green.GetHashCode();
				result = (result * 397) ^ Blue.GetHashCode();
				result = (result * 397) ^ Alpha.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}
