
// Copyright (C) 2010-2017 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenGL
{
	/// <summary>
	/// Plane abstraction.
	/// </summary>
	[DebuggerDisplay("Plane: Normal={Normal} Distance={Distance} Name={Name}")]
	public class Plane
	{
		#region Constructors

		/// <summary>
		/// Construct a plane specifying its name.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specify the plane name. It can be null for empty name.
		/// </param>
		private Plane(string name)
		{
			Name = name ?? String.Empty;
		}

		/// <summary>
		/// Construct a plane from a normal and a distance from origin.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specify the plane name. It can be null for empty name.
		/// </param>
		/// <param name="normal">
		/// A <see cref="Vertex3f"/> representing the plane normal.
		/// </param>
		/// <param name="d">
		/// A <see cref="Single"/> representing the distance between the plane and the origin.
		/// </param>
		public Plane(string name, Vertex3f normal, float d) : this(name)
		{
			Normal = normal;
			Distance = d;
		}

		/// <summary>
		/// Construct a plane from a normal and a point.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specify the plane name. It can be null for empty name.
		/// </param>
		/// <param name="normal">
		/// A <see cref="Vertex3f"/> representing the plane normal.
		/// </param>
		/// <param name="point">
		/// A <see cref="Vertex3f"/> representing the point considered for constructing the plane.
		/// </param>
		public Plane(string name, Vertex3f normal, Vertex3f point) : this(name)
		{
			Normal = normal;
			Distance = normal * point;
		}

		/// <summary>
		/// Construct a plane from 3 coplanar points.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specify the plane name. It can be null for empty name.
		/// </param>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v3">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		public Plane(string name, Vertex3f v1, Vertex3f v2, Vertex3f v3) : this(name)
		{
			Vertex3f edge1 = v2 - v1, edge2 = v3 - v1;

			Normal = edge1 ^ edge2;
			Distance = Normal * v1;
		}

		private Plane(string name, float a, float b, float c, float d) : this(name)
		{
			Normal = new Vertex3f(a, b, c);
			Distance = d;
		}

		#endregion

		#region Plane Definition

		/// <summary>
		/// Name of the plane.
		/// </summary>
		public readonly string Name;

		/// <summary>
		/// Plane normal vector.
		/// </summary>
		public Vertex3f Normal
		{
			get { return (_Normal); }
			set {
				_Normal = value;
				_Normal.Normalize();
			}
		}

		/// <summary>
		/// Plane normal.
		/// </summary>
		private Vertex3f _Normal;

		/// <summary>
		/// 
		/// </summary>
		public float Distance
		{
			get { return (_Distance); }
			set { _Distance = value; }
		}

		/// <summary>
		/// Distance from origin.
		/// </summary>
		private float _Distance;

		#endregion

		#region Frustrum Planes Extration

		/// <summary>
		/// Extract all six planes from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{Plane}"/> containing all six clipping planes defined
		/// by <paramref name="modelViewProjection"/>.
		/// </returns>
		public static IEnumerable<Plane> GetFrustumPlanes(IMatrix4x4 modelViewProjection)
		{
			List<Plane> planes = new List<Plane>(6);

			planes.Add(GetFrustumLeftPlane(modelViewProjection));
			planes.Add(GetFrustumRightPlane(modelViewProjection));
			planes.Add(GetFrustumNearPlane(modelViewProjection));
			planes.Add(GetFrustumFarPlane(modelViewProjection));
			planes.Add(GetFrustumBottomPlane(modelViewProjection));
			planes.Add(GetFrustumTopPlane(modelViewProjection));

			return (planes);
		}

		/// <summary>
		/// Extract the left plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the left clipping plane.
		/// </returns>
		public static Plane GetFrustumLeftPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(0));

			return (NormalizePlane(NameLeft, a + b));
		}

		/// <summary>
		/// Extract the right plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the right clipping plane.
		/// </returns>
		public static Plane GetFrustumRightPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(0));

			return (NormalizePlane(NameRight, a - b));
		}

		/// <summary>
		/// Extract the bottom plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the bottom clipping plane.
		/// </returns>
		public static Plane GetFrustumBottomPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(1));

			return (NormalizePlane(NameBottom, a + b));
		}

		/// <summary>
		/// Extract the top plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the top clipping plane.
		/// </returns>
		public static Plane GetFrustumTopPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(1));

			return (NormalizePlane(NameTop, a - b));
		}

		/// <summary>
		/// Extract the near plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the near clipping plane.
		/// </returns>
		public static Plane GetFrustumNearPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(2));

			Plane plane = NormalizePlane(NameFar, a + b);
			plane.Distance = -plane.Distance;
			return (plane);
		}

		/// <summary>
		/// Extract the far plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="modelViewProjection">
		/// The <see cref="IMatrix4x4"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Plane"/> defining the far clipping plane.
		/// </returns>
		public static Plane GetFrustumFarPlane(IMatrix4x4 modelViewProjection)
		{
			// Compute plane
			Vertex4d a = new Vertex4d(modelViewProjection.GetRow(3));
			Vertex4d b = new Vertex4d(modelViewProjection.GetRow(2));

			Plane plane = NormalizePlane(NameFar, a - b);
			plane.Distance = -plane.Distance;
			return (plane);
		}

		/// <summary>
		/// Creates a normalized plane.
		/// </summary>
		/// <param name="r">
		/// A <see cref="Vertex4d"/> that specify the plane parameters. Distance is the last component of <paramref name="r"/>.
		/// </param>
		/// <returns>
		/// It returns the normalized plane.
		/// </returns>
		private static Plane NormalizePlane(string name, Vertex4d r)
		{
			double module = Math.Sqrt(r.x * r.x + r.y * r.y + r.z * r.z);

			return (new Plane(name, (float)(r.x / module), (float)(r.y / module), (float)(r.z / module), (float)(r.w / module)));
		}

		/// <summary>
		/// Name of the left plane of the frustum.
		/// </summary>
		private const string NameLeft = "Left";

		/// <summary>
		/// Name of the right plane of the frustum.
		/// </summary>
		private const string NameRight = "Right";

		/// <summary>
		/// Name of the bottom plane of the frustum.
		/// </summary>
		private const string NameBottom = "Bottom";

		/// <summary>
		/// Name of the top plane of the frustum.
		/// </summary>
		private const string NameTop = "Top";

		/// <summary>
		/// Name of the near plane of the frustum.
		/// </summary>
		private const string NameNear = "Near";

		/// <summary>
		/// Name of the far plane of the frustum.
		/// </summary>
		private const string NameFar = "Far";

		#endregion

		#region Plane Operations

		/// <summary>
		/// Compute distance between a point and this plane.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3f"/> representing a point.
		/// </param>
		/// <returns>
		/// It returns the distance between a point and this plane. In the case the distance is positive, the point is on the positive side of the
		/// plane (following Normal direction), otherwise the distance is negative.
		/// </returns>
#if NET45
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
		public float GetDistance(Vertex3f p)
		{
			return ((Normal * p) - Distance);
		}

		#endregion
	}
}
