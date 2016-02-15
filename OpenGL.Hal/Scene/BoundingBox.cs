
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

namespace OpenGL.Scene
{
	/// <summary>
	/// Bounding box.
	/// </summary>
	public class BoundingBox : IBoundingVolume
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="o"></param>
		/// <param name="w"></param>
		/// <param name="h"></param>
		/// <param name="d"></param>
		public BoundingBox(Vertex3f o, float w, float h, float d)
		{
			float w2 = w/2.0f, h2 = h/2.0f, d2 = d/2.0f;

			_Bounds[0] = new Vertex3f(o.x-w2, o.y-h2, o.z-d2);
			_Bounds[1] = new Vertex3f(o.x+w2, o.y+h2, o.z+d2);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		public BoundingBox(Vertex3f min, Vertex3f max)
		{
			_Bounds[0] = min;
			_Bounds[1] = max;
		}

		#endregion

		#region Box Definition

		/// <summary>
		/// Box vertices bounds.
		/// </summary>
		private readonly Vertex3f[] _Bounds = new Vertex3f[] {
			new Vertex3f(Single.MaxValue, Single.MaxValue, Single.MaxValue),
			new Vertex3f(Single.MinValue, Single.MinValue, Single.MinValue)
		};

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
		public bool IsClipped(IEnumerable<Plane> clippingPlanes)
		{
			if (clippingPlanes == null)
				throw new ArgumentNullException("clippingPlanes");

			Vertex3f[] boundVertices = new Vertex3f[8];

			// Lower box vertices
			boundVertices[0] = new Vertex3f(_Bounds[1].x, _Bounds[0].y, _Bounds[1].z);
			boundVertices[1] = new Vertex3f(_Bounds[0].x, _Bounds[0].y, _Bounds[1].z);
			boundVertices[2] = new Vertex3f(_Bounds[0].x, _Bounds[0].y, _Bounds[0].z);
			boundVertices[3] = new Vertex3f(_Bounds[1].x, _Bounds[0].y, _Bounds[0].z);

			// Higher box vertices
			boundVertices[4] = new Vertex3f(_Bounds[1].x, _Bounds[1].y, _Bounds[1].z);
			boundVertices[5] = new Vertex3f(_Bounds[0].x, _Bounds[1].y, _Bounds[1].z);
			boundVertices[6] = new Vertex3f(_Bounds[0].x, _Bounds[1].y, _Bounds[0].z);
			boundVertices[7] = new Vertex3f(_Bounds[1].x, _Bounds[1].y, _Bounds[0].z);

			foreach (Plane clipPlane in clippingPlanes) {
				bool outsidePlane = true;

				for (int i = 0; i < boundVertices.Length && outsidePlane; i++)
					outsidePlane &= clipPlane.GetDistance(boundVertices[i]) < 0.0f;

				if (outsidePlane)
					return (true);
			}

			return (false);
		}

		/// <summary>
		/// Check whether a three-dimensional position relies in this BoundBox.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3f"/> that specifies the position.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the position <paramref name="p"/> is inside this BoundBox.
		/// </returns>
		public virtual bool IsWithinVolume(Vertex3f p)
		{
			return (
				(p.x >= _Bounds[0].x) && (p.x <= _Bounds[1].x) &&
				(p.y >= _Bounds[0].y) && (p.y <= _Bounds[1].y) &&
				(p.z >= _Bounds[0].z) && (p.z <= _Bounds[1].z)
				);
		}

		#endregion
	}
}
