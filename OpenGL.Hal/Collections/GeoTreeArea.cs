
// Copyright (C) 2016 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Collections
{
	/// <summary>
	/// Area abstraction specialized for <see cref="GeoTree{T}"/>.
	/// </summary>
	[DebuggerDisplay("GeoTreeArea: Position={Centre} Size={LinearWidth}x{LinearHeight} m")]
	public class GeoTreeArea
	{
		#region Constructors

		/// <summary>
		/// Construct a GeoTreeArea specifying the position and the size.
		/// </summary>
		/// <param name="centre">
		/// A <see cref="Vertex2d"/> that specifies the position of the centre coordinate of the GeoTreeArea.
		/// </param>
		/// <param name="size">
		/// A <see cref="Vertex2d"/> that specifies the size of the GeoTreeArea.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="size"/> is not an allowed value.
		/// </exception>
		public GeoTreeArea(Vertex2d centre, Vertex2d size)
		{
			if (size <= Vertex2d.Zero)
				throw new ArgumentException("size");

			Centre = centre;
			Size = size;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Position of the centre of the GeoTreeArea, in degrees.
		/// </summary>
		public Vertex2d Centre;

		/// <summary>
		/// Size of the GeoTreeArea, in degrees.
		/// </summary>
		public Vertex2d Size;

		/// <summary>
		/// Width of the GeoTreeArea, in meters.
		/// </summary>
		public double LinearWidth
		{
			get
			{
				double w1 = Vincenty.GetDistance(LLCoord, LRCoord);
				double w2 = Vincenty.GetDistance(ULCoord, URCoord);

				return ((w1 + w2) / 2.0);
			}
		}

		/// <summary>
		/// Height of the GeoTreeArea, in meters.
		/// </summary>
		public double LinearHeight
		{
			get
			{
				double h1 = Vincenty.GetDistance(ULCoord, LLCoord);
				double h2 = Vincenty.GetDistance(URCoord, LRCoord);

				return ((h1 + h2) / 2.0);
			}
		}

		/// <summary>
		/// Lower-left area coordinate.
		/// </summary>
		public Vertex2d LLCoord { get { return (new Vertex2d(Centre.X - Size.X / 2.0, Centre.Y - Size.Y / 2.0)); } }

		/// <summary>
		/// Lower-right area coordinate.
		/// </summary>
		public Vertex2d LRCoord { get { return (new Vertex2d(Centre.X + Size.X / 2.0, Centre.Y - Size.Y / 2.0)); } }

		/// <summary>
		/// Upper-left area coordinate.
		/// </summary>
		public Vertex2d ULCoord { get { return (new Vertex2d(Centre.X - Size.X / 2.0, Centre.Y + Size.Y / 2.0)); } }

		/// <summary>
		/// Upper-right area coordinate.
		/// </summary>
		public Vertex2d URCoord { get { return (new Vertex2d(Centre.X + Size.X / 2.0, Centre.Y + Size.Y / 2.0)); } }

		#endregion

		#region Operators

		/// <summary>
		/// Scale by a scalar operator.
		/// </summary>
		/// <param name="x">
		/// The <see cref="GeoTreeArea"/> to be scaled.
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> that specifies the scalar scaling factor.
		/// </param>
		/// <returns>
		/// It returns the <see cref="GeoTreeArea"/> that resulted from the scaling of <paramref name="x"/> by <paramref name="y"/>.
		/// </returns>
		public static GeoTreeArea operator *(GeoTreeArea x, double y)
		{
			return (new GeoTreeArea(x.Centre, x.Size * y));
		}

		/// <summary>
		/// Scale by a scalar operator.
		/// </summary>
		/// <param name="x">
		/// The <see cref="GeoTreeArea"/> to be scaled.
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> that specifies the scalar scaling factor.
		/// </param>
		/// <returns>
		/// It returns the <see cref="GeoTreeArea"/> that resulted from the scaling of <paramref name="x"/> by <paramref name="y"/>.
		/// </returns>
		public static GeoTreeArea operator /(GeoTreeArea x, double y)
		{
			return (new GeoTreeArea(x.Centre, x.Size / y));
		}

		#endregion

		#region Set Functions

		/// <summary>
		/// Determine whether a <see cref="Vertex2d"/> in within with this GeoTreeArea.
		/// </summary>
		/// <param name="point">
		/// The <see cref="Vertex2d"/> to be tested for intersection.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="point"/> intersect with this GeoTreeArea.
		/// </returns>
		public bool Intersect(Vertex2d point)
		{
			Vertex2d size2 = Size / 2.0;
			Vertex2d min = Centre - size2, max = Centre + size2;

			if ((point.x < min.x) || (point.x > max.x))
				return (false);
			if ((point.y < min.y) || (point.y > max.y))
				return (false);

			return (true);
		}

		/// <summary>
		/// Determine whether a <see cref="GeoTreeArea"/> intersect with this GeoTreeArea.
		/// </summary>
		/// <param name="otherArea">
		/// The <see cref="GeoTreeArea"/> to be tested for intersection.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="otherArea"/> intersect with this GeoTreeArea.
		/// </returns>
		public bool Intersect(GeoTreeArea otherArea)
		{
			Vertex2d otherSize2 = otherArea.Size / 2.0;
			Vertex2d otherMin = otherArea.Centre - otherSize2, otherMax = otherArea.Centre + otherSize2;

			Vertex2d size2 = Size / 2.0;
			Vertex2d min = Centre - size2, max = Centre + size2;

			if ((otherMin.x > max.x) || (otherMax.x < min.x))
				return (false);
			if ((otherMin.y > max.y) || (otherMax.y < min.y))
				return (false);

			return (true);
		}

		/// <summary>
		/// Determine whether a <see cref="GeoTreeArea"/> is included in this GeoTreeArea.
		/// </summary>
		/// <param name="otherArea">
		/// The <see cref="GeoTreeArea"/> to be tested for inclusion.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="otherArea"/> is included in this GeoTreeArea.
		/// </returns>
		public bool Include(GeoTreeArea otherArea)
		{
			Vertex2d otherSize2 = otherArea.Size / 2.0;
			Vertex2d otherMin = otherArea.Centre - otherSize2, otherMax = otherArea.Centre + otherSize2;

			Vertex2d size2 = Size / 2.0;
			Vertex2d min = Centre - size2, max = Centre + size2;

			return (otherMin >= min && otherMax <= max);
		}

		/// <summary>
		/// Computes the <see cref="GeoTreeArea"/> resulting from the intersection of a GeoTreeArea with this GeoTreeArea.
		/// </summary>
		/// <param name="otherArea">
		/// The <see cref="GeoTreeArea"/> to be intersected with this GeoTreeArea.
		/// </param>
		/// <returns>
		/// It returns a <see cref="GeoTreeArea"/> that is the intersection of this GeoTreeArea with <paramref name="otherArea"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="otherArea"/> is null.
		/// </exception>
		public GeoTreeArea GetIntersection(GeoTreeArea otherArea)
		{
			if (otherArea == null)
				throw new ArgumentNullException("otherArea");

			// No intersection?
			if (Intersect(otherArea) == false)
				return (new GeoTreeArea(Vertex2d.Zero, Vertex2d.Zero));

			Vertex2d otherSize2 = otherArea.Size / 2.0;
			Vertex2d otherMin = otherArea.Centre - otherSize2, otherMax = otherArea.Centre + otherSize2;

			Vertex2d size2 = Size / 2.0;
			Vertex2d min = Centre - size2, max = Centre + size2;

			Vertex2d iMin = new Vertex2d(Math.Max(min.x, otherMin.x), Math.Max(min.y, otherMin.y));
			Vertex2d iMax = new Vertex2d(Math.Min(max.x, otherMax.x), Math.Min(max.y, otherMax.y));

			return (new GeoTreeArea((iMin + iMax) / 2.0, iMax - iMin));
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Represents the current <see cref="GeoTreeArea"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GeoTreeArea"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("GeoTreeArea: Centre={0} Size={1}", Centre, Size));
		}

		#endregion
	}
}
