
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
		public bool IsClipped(IEnumerable<Plane> clippingPlanes, State.TransformState objectModel)
		{
			Vertex3f sphereOrigin = (Vertex3f)objectModel.ModelView.Position;

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

		Vertex3f IBoundingVolume.Position
		{
			get {
				throw new NotImplementedException();
			}
		}

		float IBoundingVolume.Radius
		{
			get {
				throw new NotImplementedException();
			}
		}

		bool IBoundingVolume.IsClipped(IEnumerable<Plane> clippingPlanes, IMatrix4x4 viewModel)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}