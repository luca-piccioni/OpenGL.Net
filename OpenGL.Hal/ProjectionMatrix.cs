
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
	/// Projection matrix.
	/// </summary>
	public abstract class ProjectionMatrix : Matrix4x4
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
		/// An array of <see cref="System.Single"/>, representing the matrix components in column-major order.
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
		public abstract float Near { get; }

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public abstract float Far { get; }

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
		/// A <see cref="System.Single"/> that specify a positive 
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
		
		#region Matrix4x4 Overrides

		/// <summary>
		/// Clone this ProjectionMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this ProjectionMatrix, but returns it modelled as ModelMatrix!.
		/// </returns>
		public override Matrix Clone()
		{
			return (new ModelMatrix(this));
		}

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
		/// A <see cref="System.Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="System.Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="System.Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="System.Single"/> indicating the distance of the top plane, in world units
		/// </param>
		public OrthoProjectionMatrix(float left, float right, float bottom, float top)
		{
			SetOrtho(left, right, bottom, top, -1.0f, +1.0f);
		}

		/// <summary>
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		/// <param name="left">
		/// A <see cref="System.Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="System.Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="System.Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="System.Single"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="System.Single"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="System.Single"/> indicating the distance of the far plane, in world units
		/// </param>
		public OrthoProjectionMatrix(float left, float right, float bottom, float top, float near, float far)
		{
			SetOrtho(left, right, bottom, top, near, far);
		}

		/// <summary>
		/// Construct a OrthoProjectionMatrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="System.Single"/>, representing the matrix components in column-major order.
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
		/// A <see cref="System.Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="System.Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="System.Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="System.Single"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="System.Single"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="System.Single"/> indicating the distance of the far plane, in world units
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
		/// A <see cref="System.Single"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="System.Single"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="System.Single"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="System.Single"/> indicating the distance of the top plane, in world units
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
		/// Get the near plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override float Near
		{
			get
			{
				float a = this[2, 2], b = this[3, 2];

				return (2.0f * ((a + 1.0f) / (a - 1.0f) - 0.5f) * b);
			}
		}

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override float Far
		{
			get
			{
				float a = this[2, 2], b = this[3, 2];

				return (-0.5f * b * ((a - 1.0f) / (a + 1.0f) - 1.0f));
			}
		}

		#endregion

		#region Matrix4x4 Overrides

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
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		public PerspectiveProjectionMatrix()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a OrthoProjectionMatrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="System.Single"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public PerspectiveProjectionMatrix(float[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// PerspectiveProjectionMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="PerspectiveProjectionMatrix"/> to be copied.
		/// </param>
		public PerspectiveProjectionMatrix(PerspectiveProjectionMatrix m)
			: base(m)
		{

		}

		#endregion

		#region Projections

		/// <summary>
		/// Set frustrum projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="System.Single"/>
		/// </param>
		/// <param name="right">
		/// A <see cref="System.Single"/>
		/// </param>
		/// <param name="bottom">
		/// A <see cref="System.Single"/>
		/// </param>
		/// <param name="top">
		/// A <see cref="System.Single"/>
		/// </param>
		/// <param name="near">
		/// A <see cref="System.Single"/>
		/// </param>
		/// <param name="far">
		/// A <see cref="System.Single"/>
		/// </param>
		public void SetFustrum(float left, float right, float bottom, float top, float near, float far)
		{
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
		public void SetPerspective(float fovy, float aspectRatio, float near, float far)
		{
			float ymax = near * (float)Math.Tan(fovy * Math.PI / 360.0);
			float xmax = ymax * aspectRatio;

			SetFustrum(-xmax, +xmax, -ymax, +ymax, near, far);
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
		/// Get the near plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override float Near
		{
			get
			{
				float a = this[2, 2], b = this[3, 2];

				return (2.0f * ((a + 1.0f) / (a - 1.0f) - 0.5f) * b);
			}
		}

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override float Far
		{
			get
			{
				float a = this[2, 2], b = this[3, 2];

				return (-0.5f * b * ((a - 1.0f) / (a + 1.0f) - 1.0f));
			}
		}

		#endregion

		#region Matrix4x4 Overrides

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
