
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
using System.Collections.Generic;

namespace OpenGL.Objects.Scene
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
		/// <param name="min"></param>
		/// <param name="max"></param>
		public BoundingBox(Vertex3f min, Vertex3f max)
		{
			if (Math.Abs(min.x) < Single.Epsilon && Math.Abs(max.x) < Single.Epsilon) {
				min.x = -0.1f;
				max.x = +0.1f;
			}

			if (Math.Abs(min.y) < Single.Epsilon && Math.Abs(max.y) < Single.Epsilon) {
				min.y = -0.1f;
				max.y = +0.1f;
			}

			if (Math.Abs(min.z) < Single.Epsilon && Math.Abs(max.z) < Single.Epsilon) {
				min.z = -0.1f;
				max.z = +0.1f;
			}

			_Bounds[0] = min;
			_Bounds[1] = max;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="o"></param>
		/// <param name="w"></param>
		/// <param name="h"></param>
		/// <param name="d"></param>
		public BoundingBox(Vertex3f o, float w, float h, float d)
		{
			float w2 = w / 2.0f, h2 = h / 2.0f, d2 = d / 2.0f;

			if (w2 < Single.Epsilon) w2 = 0.2f;
			if (h2 < Single.Epsilon) h2 = 0.2f;
			if (d2 < Single.Epsilon) d2 = 0.2f;

			_Bounds[0] = new Vertex3f(o.x - w2, o.y - h2, o.z - d2);
			_Bounds[1] = new Vertex3f(o.x + w2, o.y + h2, o.z + d2);
		}

		#endregion

		#region Box Definition

		public Vertex3f MinPosition
		{
			get { return (_Bounds[0]); }
			set { _Bounds[0] = value; }
		}

		public Vertex3f MaxPosition
		{
			get { return (_Bounds[1]); }
			set { _Bounds[1] = value; }
		}

		public Vertex3f Size { get { return (MaxPosition - MinPosition); } }

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
		/// Offset of the bounding volume w.r.t. the underlying object origin.
		/// </summary>
		public Vertex3f Position
		{
			get
			{
				return ((MaxPosition + MinPosition) / 2.0f);
			}
		}

		/// <summary>
		/// Minimum distance at which the volume cannot be intersected w.r.t. <see cref="Position"/>.
		/// </summary>
		public float Radius { get { return (MaxPosition.Module()); } }

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
		public bool IsClipped(IEnumerable<Plane> clippingPlanes, IMatrix4x4 viewModel)
		{
			if (clippingPlanes == null)
				throw new ArgumentNullException("clippingPlanes");

			Vertex3f[] boundVertices = new Vertex3f[8];
			Vertex3f[] viewVertices = new Vertex3f[2];

			for (int i = 0; i < 2; i++)
				viewVertices[i] = (Vertex3f)viewModel.Multiply(_Bounds[i]); 

			// Lower box vertices
			boundVertices[0] = new Vertex3f(viewVertices[1].x, viewVertices[0].y, viewVertices[1].z);
			boundVertices[1] = new Vertex3f(viewVertices[0].x, viewVertices[0].y, viewVertices[1].z);
			boundVertices[2] = new Vertex3f(viewVertices[0].x, viewVertices[0].y, viewVertices[0].z);
			boundVertices[3] = new Vertex3f(viewVertices[1].x, viewVertices[0].y, viewVertices[0].z);
			// Higher box vertices
			boundVertices[4] = new Vertex3f(viewVertices[1].x, viewVertices[1].y, viewVertices[1].z);
			boundVertices[5] = new Vertex3f(viewVertices[0].x, viewVertices[1].y, viewVertices[1].z);
			boundVertices[6] = new Vertex3f(viewVertices[0].x, viewVertices[1].y, viewVertices[0].z);
			boundVertices[7] = new Vertex3f(viewVertices[1].x, viewVertices[1].y, viewVertices[0].z);

			foreach (Plane clipPlane in clippingPlanes) {
				bool outsidePlane = true;

				for (int i = 0; i < boundVertices.Length && outsidePlane; i++)
					outsidePlane &= clipPlane.GetDistance(boundVertices[i]) < 0.0f;

				if (outsidePlane)
					return (true);
			}

			return (false);
		}

		#endregion
	}
}
