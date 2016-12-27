
// Copyright (C) 2012-2016 Luca Piccioni
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
using System.Collections.Generic;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Sphere boudary.
	/// </summary>
	public sealed class BoundingSphere : IBoundingVolume
	{
		#region Constructors

		/// <summary>
		/// Construct a BoundingSphere.
		/// </summary>
		/// <param name="radius">
		/// A <see cref="Single"/> that specify the sphere radius.
		/// </param>
		public BoundingSphere(float radius)
		{
			if (radius < 0.0f)
				throw new ArgumentException("it must be positive", "radius");

			_Radius = radius;
		}

		#endregion

		#region Sphere Definition

		/// <summary>
		/// Bounding sphere radius.
		/// </summary>
		public float Radius
		{
			get { return (_Radius); }
			set { _Radius = value; }
		}

		/// <summary>
		/// Bounding sphere radius.
		/// </summary>
		private float _Radius;

		#endregion

		#region IBoundVolume Implementation

		/// <summary>
		/// Determine whether this bound volume is clipped by all specified planes.
		/// </summary>
		/// <param name="clippingPlanes">
		/// A <see cref="IEnumerable{Plane}"/> that are used to perform geometry clipping.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this bound volume is entirely
		/// clipped by <paramref name="clippingPlanes"/>.
		/// </returns>
		public bool IsClipped(IEnumerable<Plane> clippingPlanes, IModelMatrix objectViewModel)
		{
			Vertex3f sphereOrigin = (Vertex3f)objectViewModel.Position;

			foreach (Plane plane in clippingPlanes) {
				if (plane.GetDistance(sphereOrigin) < _Radius)
					return (true);
			}

			return (false);
		}

		/// <summary>
		/// Draw the bounding volume.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		public void Draw(GraphicsContext ctx, IModelMatrix objectViewModel)
		{

		}

		#endregion
	}
}