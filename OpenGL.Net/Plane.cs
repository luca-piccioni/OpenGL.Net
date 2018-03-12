
// Copyright (C) 2010-2017 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenGL
{
	/// <summary>
	/// Plane abstraction.
	/// </summary>
	[DebuggerDisplay("Plane: Normal={Normal} Distance={Distance}")]
	public struct Planef
	{
		#region Constructors

		/// <summary>
		/// Construct a plane from a normal and a distance from origin.
		/// </summary>
		/// <param name="normal">
		/// A <see cref="Vertex3f"/> representing the plane normal.
		/// </param>
		/// <param name="d">
		/// A <see cref="float"/> representing the distance between the plane and the origin.
		/// </param>
		public Planef(Vertex3f normal, float d)
		{
			_A = _B = _C = _D = 0.0f;

			Normal = normal;
			Distance = d;
		}

		/// <summary>
		/// Construct a plane from a normal and a point.
		/// </summary>
		/// <param name="normal">
		/// A <see cref="Vertex3f"/> representing the plane normal.
		/// </param>
		/// <param name="point">
		/// A <see cref="Vertex3f"/> representing the point considered for constructing the plane.
		/// </param>
		public Planef(Vertex3f normal, Vertex3f point)
		{
			_A = _B = _C = _D = 0.0f;
			
			Normal = normal;
			Distance = normal * point;
		}

		/// <summary>
		/// Construct a plane from 3 coplanar points.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v3">
		/// A <see cref="Vertex3f"/> representing one plane coplanar point.
		/// </param>
		public Planef(Vertex3f v1, Vertex3f v2, Vertex3f v3)
		{
			_A = _B = _C = _D = 0.0f;
			
			Vertex3f edge1 = v2 - v1, edge2 = v3 - v1;

			Normal = edge1 ^ edge2;
			Distance = Normal * v1;
		}

		private Planef(float a, float b, float c, float d)
		{
			_A = _B = _C = _D = 0.0f;
			
			Normal = new Vertex3f(a, b, c);
			Distance = d;
		}

		#endregion

		#region Structure

		/// <summary>
		/// 1th plane component.
		/// </summary>
		private float _A;

		/// <summary>
		/// 2th plane component.
		/// </summary>
		private float _B;

		/// <summary>
		/// 3th plane component.
		/// </summary>
		private float _C;

		/// <summary>
		/// 4th plane component (distance).
		/// </summary>
		private float _D;

		#endregion

		#region Plane Equation

		/// <summary>
		/// Plane normal vector.
		/// </summary>
		public Vertex3f Normal
		{
			get { return new Vertex3f(_A, _B, _C); }
			set {
				Vertex3f n = value.Normalized;
				
				_A = n.x;
				_B = n.y;
				_C = n.z;
			}
		}

		/// <summary>
		/// Distance of plane from origin.
		/// </summary>
		public float Distance { get { return _D; } set { _D = value; } }

		#endregion

		#region Frustrum Planes Extration

		/// <summary>
		/// Extract all six planes from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{Planef}"/> containing all six clipping planes defined
		/// by <paramref name="mvp"/>.
		/// </returns>
		public static IEnumerable<Planef> GetFrustumPlanes(Matrix4x4f mvp)
		{
			return new List<Planef>(6) {
				GetFrustumLeftPlane(mvp),
				GetFrustumRightPlane(mvp),
				GetFrustumNearPlane(mvp),
				GetFrustumFarPlane(mvp),
				GetFrustumBottomPlane(mvp),
				GetFrustumTopPlane(mvp)
			};
		}

		/// <summary>
		/// Extract the left plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the left clipping plane.
		/// </returns>
		public static Planef GetFrustumLeftPlane(Matrix4x4f mvp)
		{
			return NormalizePlane(mvp.Row3 + mvp.Row0);
		}

		/// <summary>
		/// Extract the right plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the right clipping plane.
		/// </returns>
		public static Planef GetFrustumRightPlane(Matrix4x4f mvp)
		{
			return NormalizePlane(mvp.Row3 - mvp.Row0);
		}

		/// <summary>
		/// Extract the bottom plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the bottom clipping plane.
		/// </returns>
		public static Planef GetFrustumBottomPlane(Matrix4x4f mvp)
		{
			return NormalizePlane(mvp.Row0 + mvp.Row1);
		}

		/// <summary>
		/// Extract the top plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the top clipping plane.
		/// </returns>
		public static Planef GetFrustumTopPlane(Matrix4x4f mvp)
		{
			return NormalizePlane(mvp.Row0 - mvp.Row1);
		}

		/// <summary>
		/// Extract the near plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the near clipping plane.
		/// </returns>
		public static Planef GetFrustumNearPlane(Matrix4x4f mvp)
		{
			Planef plane = NormalizePlane(mvp.Row0 + mvp.Row2);
			plane.Distance = -plane.Distance;
			return plane;
		}

		/// <summary>
		/// Extract the far plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planef"/> defining the far clipping plane.
		/// </returns>
		public static Planef GetFrustumFarPlane(Matrix4x4f mvp)
		{
			Planef plane = NormalizePlane(mvp.Row3 - mvp.Row2);
			plane.Distance = -plane.Distance;
			return plane;
		}

		/// <summary>
		/// Creates a normalized plane.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/> that specify the plane components.
		/// </param>
		/// <returns>
		/// It returns the normalized plane.
		/// </returns>
		private static Planef NormalizePlane(Vertex4f v)
		{
			return NormalizePlane(v.x, v.y, v.z, v.w);
		}

		/// <summary>
		/// Creates a normalized plane.
		/// </summary>
		/// <param name="a">
		/// A <see cref="float"/> that specify the 1th plane component.
		/// </param>
		/// <param name="b">
		/// A <see cref="float"/> that specify the 2th plane component.
		/// </param>
		/// <param name="c">
		/// A <see cref="float"/> that specify the 3th plane component.
		/// </param>
		/// <param name="d">
		/// A <see cref="float"/> that specify the 4th plane component.
		/// </param>
		/// <returns>
		/// It returns the normalized plane.
		/// </returns>
		private static Planef NormalizePlane(float a, float b, float c, float d)
		{
			float module = (float)Math.Sqrt(a * a + b * b + c * c);

			return new Planef(a / module, b / module, c / module, d / module);
		}

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
			return Normal * p - Distance;
		}

		#endregion
	}

	/// <summary>
	/// Plane abstraction.
	/// </summary>
	[DebuggerDisplay("Plane: Normal={Normal} Distance={Distance}")]
	public struct Planed
	{
		#region Constructors

		/// <summary>
		/// Construct a plane from a normal and a distance from origin.
		/// </summary>
		/// <param name="normal">
		/// A <see cref="Vertex3d"/> representing the plane normal.
		/// </param>
		/// <param name="d">
		/// A <see cref="double"/> representing the distance between the plane and the origin.
		/// </param>
		public Planed(Vertex3d normal, double d)
		{
			_A = _B = _C = _D = 0.0;

			Normal = normal;
			Distance = d;
		}

		/// <summary>
		/// Construct a plane from a normal and a point.
		/// </summary>
		/// <param name="normal">
		/// A <see cref="Vertex3d"/> representing the plane normal.
		/// </param>
		/// <param name="point">
		/// A <see cref="Vertex3d"/> representing the point considered for constructing the plane.
		/// </param>
		public Planed(Vertex3d normal, Vertex3d point)
		{
			_A = _B = _C = _D = 0.0;
			
			Normal = normal;
			Distance = normal * point;
		}

		/// <summary>
		/// Construct a plane from 3 coplanar points.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> representing one plane coplanar point.
		/// </param>
		/// <param name="v3">
		/// A <see cref="Vertex3d"/> representing one plane coplanar point.
		/// </param>
		public Planed(Vertex3d v1, Vertex3d v2, Vertex3d v3)
		{
			_A = _B = _C = _D = 0.0;
			
			Vertex3d edge1 = v2 - v1, edge2 = v3 - v1;

			Normal = edge1 ^ edge2;
			Distance = Normal * v1;
		}

		private Planed(double a, double b, double c, double d)
		{
			_A = _B = _C = _D = 0.0;
			
			Normal = new Vertex3d(a, b, c);
			Distance = d;
		}

		#endregion

		#region Structure

		/// <summary>
		/// 1th plane component.
		/// </summary>
		private double _A;

		/// <summary>
		/// 2th plane component.
		/// </summary>
		private double _B;

		/// <summary>
		/// 3th plane component.
		/// </summary>
		private double _C;

		/// <summary>
		/// 4th plane component (distance).
		/// </summary>
		private double _D;

		#endregion

		#region Plane Equation

		/// <summary>
		/// Plane normal vector.
		/// </summary>
		public Vertex3d Normal
		{
			get { return new Vertex3d(_A, _B, _C); }
			set {
				Vertex3d n = value.Normalized;
				
				_A = n.x;
				_B = n.y;
				_C = n.z;
			}
		}

		/// <summary>
		/// Distance of plane from origin.
		/// </summary>
		public double Distance { get { return _D; } set { _D = value; } }

		#endregion

		#region Frustrum Planes Extration

		/// <summary>
		/// Extract all six planes from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{Planed}"/> containing all six clipping planes defined
		/// by <paramref name="mvp"/>.
		/// </returns>
		public static IEnumerable<Planed> GetFrustumPlanes(Matrix4x4d mvp)
		{
			return new List<Planed>(6) {
				GetFrustumLeftPlane(mvp),
				GetFrustumRightPlane(mvp),
				GetFrustumNearPlane(mvp),
				GetFrustumFarPlane(mvp),
				GetFrustumBottomPlane(mvp),
				GetFrustumTopPlane(mvp)
			};
		}

		/// <summary>
		/// Extract the left plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the left clipping plane.
		/// </returns>
		public static Planed GetFrustumLeftPlane(Matrix4x4d mvp)
		{
			return NormalizePlane(mvp.Row3 + mvp.Row0);
		}

		/// <summary>
		/// Extract the right plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the right clipping plane.
		/// </returns>
		public static Planed GetFrustumRightPlane(Matrix4x4d mvp)
		{
			return NormalizePlane(mvp.Row3 - mvp.Row0);
		}

		/// <summary>
		/// Extract the bottom plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the bottom clipping plane.
		/// </returns>
		public static Planed GetFrustumBottomPlane(Matrix4x4d mvp)
		{
			return NormalizePlane(mvp.Row0 + mvp.Row1);
		}

		/// <summary>
		/// Extract the top plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the top clipping plane.
		/// </returns>
		public static Planed GetFrustumTopPlane(Matrix4x4d mvp)
		{
			return NormalizePlane(mvp.Row0 - mvp.Row1);
		}

		/// <summary>
		/// Extract the near plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the near clipping plane.
		/// </returns>
		public static Planed GetFrustumNearPlane(Matrix4x4d mvp)
		{
			Planed plane = NormalizePlane(mvp.Row0 + mvp.Row2);
			plane.Distance = -plane.Distance;
			return plane;
		}

		/// <summary>
		/// Extract the far plane from a model-view-projection matrix.
		/// </summary>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4d"/> that specify the matrix used for drawing the clipped object.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Planed"/> defining the far clipping plane.
		/// </returns>
		public static Planed GetFrustumFarPlane(Matrix4x4d mvp)
		{
			Planed plane = NormalizePlane(mvp.Row3 - mvp.Row2);
			plane.Distance = -plane.Distance;
			return plane;
		}

		/// <summary>
		/// Creates a normalized plane.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/> that specify the plane components.
		/// </param>
		/// <returns>
		/// It returns the normalized plane.
		/// </returns>
		private static Planed NormalizePlane(Vertex4d v)
		{
			return NormalizePlane(v.x, v.y, v.z, v.w);
		}

		/// <summary>
		/// Creates a normalized plane.
		/// </summary>
		/// <param name="a">
		/// A <see cref="double"/> that specify the 1th plane component.
		/// </param>
		/// <param name="b">
		/// A <see cref="double"/> that specify the 2th plane component.
		/// </param>
		/// <param name="c">
		/// A <see cref="double"/> that specify the 3th plane component.
		/// </param>
		/// <param name="d">
		/// A <see cref="double"/> that specify the 4th plane component.
		/// </param>
		/// <returns>
		/// It returns the normalized plane.
		/// </returns>
		private static Planed NormalizePlane(double a, double b, double c, double d)
		{
			double module = (double)Math.Sqrt(a * a + b * b + c * c);

			return new Planed(a / module, b / module, c / module, d / module);
		}

		#endregion

		#region Plane Operations

		/// <summary>
		/// Compute distance between a point and this plane.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3d"/> representing a point.
		/// </param>
		/// <returns>
		/// It returns the distance between a point and this plane. In the case the distance is positive, the point is on the positive side of the
		/// plane (following Normal direction), otherwise the distance is negative.
		/// </returns>
#if NET45
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
		public double GetDistance(Vertex3d p)
		{
			return Normal * p - Distance;
		}

		#endregion
	}

}
