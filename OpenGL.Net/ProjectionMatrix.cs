
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Projection matrix.
	/// </summary>
	[DebuggerDisplay("ProjectionMatrix: Near={Near}, Far={Far} FocalLength={FocalLength} AspectRatio={AspectRatio}")]
	public abstract class ProjectionMatrix : Matrix4x4, IProjectionMatrix
	{
		#region Constructors

		/// <summary>
		/// ProjectionMatrix constructor.
		/// </summary>
		/// <remarks>
		/// It set this ModelMatrix to identity.
		/// </remarks>
		protected ProjectionMatrix()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		protected ProjectionMatrix(float[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// ProjectionMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ProjectionMatrix"/> to be copied.
		/// </param>
		protected ProjectionMatrix(ProjectionMatrix m)
			: base(m)
		{

		}

		#endregion

		#region Projection Parameters

		/// <summary>
		/// Get the near plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public float Near
		{
			get
			{
				return (Plane.GetFrustumNearPlane(this).Distance);
			}
		}

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public float Far
		{
			get
			{
				return (Plane.GetFrustumFarPlane(this).Distance);
			}
		}

		/// <summary>
		/// The projection focal length.
		/// </summary>
		public float FocalLength { get { return (this[0, 0]); } }

		/// <summary>
		/// The projection aspect ratio.
		/// </summary>
		public float AspectRatio { get { return (1.0f / this[1, 1] * this[0, 0]); } }

		#endregion

		#region Infinity Projection

		/// <summary>
		/// Get the infinity projection.
		/// </summary>
		public Matrix4x4 GetInfinityProjection()
		{
			return (GetInfinityProjection(2.4e-7f));
		}

		/// <summary>
		/// Get the infinity projection.
		/// </summary>
		/// <param name="epsilon">
		/// A <see cref="Single"/> that specify a positive 
		/// </param>
		public Matrix4x4 GetInfinityProjection(float epsilon)
		{
			if (epsilon < 0.0f)
				throw new ArgumentException("less than zero", "epsilon");

			Matrix4x4 infinityMatrix = new Matrix4x4(this);

			infinityMatrix[2, 2] = -1.0f;
			infinityMatrix[2, 3] = epsilon - 1.0f;
			infinityMatrix[3, 2] = (epsilon - 2.0f) * Near;

			return (infinityMatrix);
		}

		#endregion

		#region IProjectionMatrix Implementation

		/// <summary>
		/// Get the near plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		double IProjectionMatrix.Near { get { return (Near); } }

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		double IProjectionMatrix.Far { get { return (Far); } }

		#endregion
	}

	/// <summary>
	/// Orthographic projection matrix.
	/// </summary>
	public class OrthoProjectionMatrix : ProjectionMatrix
	{
		#region Constructors

		/// <summary>
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		public OrthoProjectionMatrix()
		{
			SetOrtho2D(-1.0f, +1.0f, -1.0f, +1.0f);
		}

		/// <summary>
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Single"/> indicating the distance of the top plane, in world units
		/// </param>
		public OrthoProjectionMatrix(float left, float right, float bottom, float top)
		{
			SetOrtho(left, right, bottom, top, -1.0f, +1.0f);
		}

		/// <summary>
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Single"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="Single"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="Single"/> indicating the distance of the far plane, in world units
		/// </param>
		public OrthoProjectionMatrix(float left, float right, float bottom, float top, float near, float far)
		{
			SetOrtho(left, right, bottom, top, near, far);
		}

		/// <summary>
		/// Construct a OrthoProjectionMatrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public OrthoProjectionMatrix(float[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// OrthoProjectionMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="OrthoProjectionMatrix"/> to be copied.
		/// </param>
		public OrthoProjectionMatrix(OrthoProjectionMatrix m)
			: base(m)
		{

		}

		#endregion

		#region Orthographic Projection

		/// <summary>
		/// Set orthographic projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Single"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="Single"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="Single"/> indicating the distance of the far plane, in world units
		/// </param>
		public void SetOrtho(float left, float right, float bottom, float top, float near, float far)
		{
			// Column 1
			this[0, 0] = 2.0f / (right - left);
			this[0, 1] = 0.0f;
			this[0, 2] = 0.0f;
			this[0, 3] = 0.0f;
			// Column 2
			this[1, 0] = 0.0f;
			this[1, 1] = 2.0f / (top - bottom);
			this[1, 2] = 0.0f;
			this[1, 3] = 0.0f;
			// Column 3
			this[2, 0] = 0.0f;
			this[2, 1] = 0.0f;
			this[2, 2] = -2.0f / (far - near);
			this[2, 3] = 0.0f;
			// Column 4
			this[3, 0] = -(right + left) / (right - left);
			this[3, 1] = -(top + bottom) / (top - bottom);
			this[3, 2] = -(far + near) / (far - near);
			this[3, 3] = 1.0f;
		}

		/// <summary>
		/// Set bidimensional orthographic projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Single"/> indicating the distance of the top plane, in world units
		/// </param>
		public void SetOrtho2D(float left, float right, float bottom, float top)
		{
			SetOrtho(left, right, bottom, top, -1.0f, +1.0f);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this OrthoProjectionMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="OrthoProjectionMatrix"/> which hold the transpose of this OrthoProjectionMatrix.
		/// </returns>
		public new OrthoProjectionMatrix Transpose()
		{
			OrthoProjectionMatrix transpose = new OrthoProjectionMatrix();

			// Transpose matrix
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		#endregion

		#region ProjectionMatrix Overrides

		/// <summary>
		/// Clone this ProjectionMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this ProjectionMatrix.
		/// </returns>
		public override Matrix Clone()
		{
			return (new OrthoProjectionMatrix(this));
		}

		#endregion
	}

	/// <summary>
	/// Perspective projection matrix.
	/// </summary>
	public class PerspectiveProjectionMatrix : ProjectionMatrix
	{
		#region Constructors

		/// <summary>
		/// Parameterless constructor, !! Attention: not a valid projection: initializing to identity !!.
		/// </summary>
		public PerspectiveProjectionMatrix()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a symmetric PerspectiveProjectionMatrix.
		/// </summary>
		/// <param name="fovy">
		/// A <see cref="Single"/> that specify the vertical Field Of View, in degrees.
		/// </param>
		/// <param name="aspectRatio">
		/// A <see cref="Single"/> that specify the view aspect ratio (i.e. the width / height ratio).
		/// </param>
		/// <param name="near">
		/// A <see cref="Single"/> that specify the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="Single"/> that specify the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public PerspectiveProjectionMatrix(float fovy, float aspectRatio, float near, float far)
		{
			SetPerspective(fovy, aspectRatio, near, far);
		}

		/// <summary>
		/// PerspectiveProjectionMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="PerspectiveProjectionMatrix"/> to be copied.
		/// </param>
		public PerspectiveProjectionMatrix(PerspectiveProjectionMatrix m) : base(m)
		{

		}

		#endregion

		#region Projections

		/// <summary>
		/// Set frustrum projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Single"/> that specify the frustum left plane distance.
		/// </param>
		/// <param name="right">
		/// A <see cref="Single"/> that specify the frustum right plane distance.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Single"/> that specify the frustum bottom plane distance.
		/// </param>
		/// <param name="top">
		/// A <see cref="Single"/> that specify the frustum top plane distance.
		/// </param>
		/// <param name="near">
		/// A <see cref="Single"/> that specify the frustum near plane distance.
		/// </param>
		/// <param name="far">
		/// A <see cref="Single"/> that specify the frustum far plane distance.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the parameter have an invalid set of values.
		/// </exception>
		public void SetFrustrum(float left, float right, float bottom, float top, float near, float far)
		{
			if (Math.Abs(right - left) < Single.Epsilon)
				throw new ArgumentException("left/right planes are coincident");
			if (Math.Abs(top - bottom) < Single.Epsilon)
				throw new ArgumentException("top/bottom planes are coincident");
			if (Math.Abs(far - near) < Single.Epsilon)
				throw new ArgumentException("far/near planes are coincident");

			// Column 1
			this[0, 0] = 2.0f * near / (right - left);
			this[0, 1] = 0.0f;
			this[0, 2] = 0.0f;
			this[0, 3] = 0.0f;
			// Column 2
			this[1, 0] = 0.0f;
			this[1, 1] = 2.0f * near / (top - bottom);
			this[1, 2] = 0.0f;
			this[1, 3] = 0.0f;
			// Column 3
			this[2, 0] = (right + left) / (right - left);
			this[2, 1] = (top + bottom) / (top - bottom);
			this[2, 2] = (-far - near) / (far - near);
			this[2, 3] = -1.0f;
			// Coumn 4
			this[3, 0] = 0.0f;
			this[3, 1] = 0.0f;
			this[3, 2] = -2.0f * far * near / (far - near);
			this[3, 3] = 0.0f;
		}

		/// <summary>
		/// Set a perspective projection matrix.
		/// </summary>
		/// <param name="fovy">
		/// A <see cref="Single"/> that specify the vertical Field Of View, in degrees.
		/// </param>
		/// <param name="aspectRatio">
		/// A <see cref="Single"/> that specify the view aspect ratio (i.e. the width / height ratio).
		/// </param>
		/// <param name="near">
		/// A <see cref="Single"/> that specify the distance of the frustum near plane.
		/// </param>
		/// <param name="far">
		/// A <see cref="Single"/> that specify the distance of the frustum far plane.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if at least one parameter has an invalid value.
		/// </exception>
		public void SetPerspective(float fovy, float aspectRatio, float near, float far)
		{
			if (fovy <= 0.0f || fovy > 180.0f)
				throw new ArgumentOutOfRangeException("fovy", "not in range [0, 180]");
			if (Math.Abs(near) < Single.Epsilon)
				throw new ArgumentOutOfRangeException("near", "zero not allowed");
			if (Math.Abs(far) < Math.Abs(near))
				throw new ArgumentOutOfRangeException("far", "less than near");

			float ymax = near * (float)Math.Tan(Angle.ToRadians(fovy / 2.0f));
			float xmax = ymax * aspectRatio;

			SetFrustrum(-xmax, +xmax, -ymax, +ymax, near, far);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="leftFov"></param>
		/// <param name="rightFov"></param>
		/// <param name="bottomFov"></param>
		/// <param name="topFov"></param>
		/// <param name="near"></param>
		/// <param name="far"></param>
		public void SetPerspective(float leftFov, float rightFov, float bottomFov, float topFov, float near, float far)
		{
			SetFrustrum(
				-near * (float)Math.Tan(Angle.ToRadians(leftFov)),
				+near * (float)Math.Tan(Angle.ToRadians(rightFov)),
				-near * (float)Math.Tan(Angle.ToRadians(bottomFov)),
				+near * (float)Math.Tan(Angle.ToRadians(topFov)),
				near, far
			);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this PerspectiveProjectionMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="PerspectiveProjectionMatrix"/> which hold the transpose of this PerspectiveProjectionMatrix.
		/// </returns>
		public new PerspectiveProjectionMatrix Transpose()
		{
			PerspectiveProjectionMatrix transpose = new PerspectiveProjectionMatrix();

			// Transpose matrix
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		#endregion

		#region ProjectionMatrix Overrides

		/// <summary>
		/// Clone this ProjectionMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this ProjectionMatrix.
		/// </returns>
		public override Matrix Clone()
		{
			return (new PerspectiveProjectionMatrix(this));
		}

		#endregion
	}
}
