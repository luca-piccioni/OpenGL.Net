
// Copyright (C) 2015 Luca Piccioni
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
// US

using System;

namespace OpenGL
{
	/// <summary>
	/// Version abstraction for Khrono APIs.
	/// </summary>
	public class KhronosVersion : IEquatable<KhronosVersion>, IComparable<KhronosVersion>
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
		/// </exception>
		public KhronosVersion(int major, int minor) :
			this(major, minor, 0)
		{

		}
		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="revision">
		/// A <see cref="Int32"/> that specifies that revision version number.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
		/// <paramref name="revision"/> are less than 0.
		/// </exception>
		public KhronosVersion(int major, int minor, int revision)
		{
			if (major <= 0)
				throw new ArgumentException("less or equal to 0 not allowed", "major");
			if (minor <= 0)
				throw new ArgumentException("less than 0 not allowed", "minor");
			if (revision <= 0)
				throw new ArgumentException("less than 0 not allowed", "revision");

			Major = major;
			Minor = minor;
			Revision = revision;
		}

		#endregion

		#region Version Numbers

		/// <summary>
		/// Major version number.
		/// </summary>
		public int Major;

		/// <summary>
		/// Minor version number.
		/// </summary>
		public int Minor;

		/// <summary>
		/// Revision version number.
		/// </summary>
		public int Revision;

		#endregion

		#region Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> equals <paramref name="right"/>.
		/// </returns>
		public static bool operator ==(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (true);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.Equals(right));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> doesn't equals <paramref name="right"/>.
		/// </returns>
		public static bool operator !=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (!left.Equals(right));
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is greater than <paramref name="right"/>.
		/// </returns>
		public static bool operator >(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (false);

			return (left.CompareTo(right) > 0);
		}

		/// <summary>
		/// Lower than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is lower than <paramref name="right"/>.
		/// </returns>
		public static bool operator <(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return (false);
			if (ReferenceEquals(left, null))
				return (true);

			return (left.CompareTo(right) < 0);
		}

		#endregion

		#region IEquatable<KhronosVersion> Implementation

		/// <summary>
		/// Returns a boolean value indicating whether this instance is equal to <paramref name="other"/>.
		/// </summary>
		/// <param name="other">
		/// The KhronosVersion to be compared with this KhronosVersion.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="other"/> equals to this instance.
		/// </returns>
		public bool Equals(KhronosVersion other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);

			return ((Major == other.Major) && (Minor == other.Minor && (Revision == other.Revision)));
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
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);
			if ((obj.GetType() != typeof(KhronosVersion)) && (obj.GetType().IsSubclassOf(typeof(KhronosVersion)) == false))
				return (false);

			return (Equals((KhronosVersion)obj));
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
				int result = base.GetHashCode();

				result = (result * 397) ^ Major.GetHashCode();
				result = (result * 397) ^ Minor.GetHashCode();
				result = (result * 397) ^ Revision.GetHashCode();

				return result;
			}
		}

		#endregion

		#region IComparable<KhronosVersion> Implementation

		/// <summary>
		/// Compares this instance to a specified KhronosVersion and returns an integer
		/// that indicates whether the value of this instance is less than, equal to, or
		/// greater than the value of the specified KhronosVersion.
		/// </summary>
		/// <param name="other">
		/// A <see cref="KhronosVersion"/> to compare.
		/// </param>
		/// <returns>
		/// </returns>
		public int CompareTo(KhronosVersion other)
		{
			if (ReferenceEquals(this, other))
				return (0);
			if (ReferenceEquals(null, other))
				return (+1);

			int majorCompareTo = Major.CompareTo(other.Major);
			if (majorCompareTo != 0)
				return (majorCompareTo);

			int minorCompareTo = Minor.CompareTo(other.Minor);
			if (minorCompareTo != 0)
				return (minorCompareTo);

			int revCompareTo = Revision.CompareTo(other.Revision);
			if (revCompareTo != 0)
				return (revCompareTo);

			return (0);
		}

		#endregion
	}
}
