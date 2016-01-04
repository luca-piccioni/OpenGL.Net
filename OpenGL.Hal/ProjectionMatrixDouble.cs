
// Copyright (C) 2013-2015 Luca Piccioni
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
	public abstract class ProjectionMatrixDouble : MatrixDouble4x4
	{
		#region Constructors

		/// <summary>
		/// ProjectionMatrixDouble constructor.
		/// </summary>
		/// <remarks>
		/// It set this ProjectionMatrixDouble to identity.
		/// </remarks>
		protected ProjectionMatrixDouble()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Double"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		protected ProjectionMatrixDouble(double[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// ProjectionMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ProjectionMatrixDouble"/> to be copied.
		/// </param>
		protected ProjectionMatrixDouble(ProjectionMatrixDouble m)
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
		public abstract double Near { get; }

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public abstract double Far { get; }

		#endregion
	}

	/// <summary>
	/// Orthographic projection matrix.
	/// </summary>
	public class OrthoProjectionMatrixDouble : ProjectionMatrixDouble
	{
		#region Constructors

		/// <summary>
		/// OrthoProjectionMatrix constructor.
		/// </summary>
		public OrthoProjectionMatrixDouble()
		{
			SetOrtho2D(-1.0f, +1.0f, -1.0f, +1.0f);
		}

		/// <summary>
		/// OrthoProjectionMatrixDouble constructor.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Double"/> indicating the distance of the top plane, in world units
		/// </param>
		public OrthoProjectionMatrixDouble(double left, double right, double bottom, double top)
		{
			SetOrtho(left, right, bottom, top, -1.0f, +1.0f);
		}

		/// <summary>
		/// OrthoProjectionMatrixDouble constructor.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Double"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="Double"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="Double"/> indicating the distance of the far plane, in world units
		/// </param>
		public OrthoProjectionMatrixDouble(double left, double right, double bottom, double top, double near, double far)
		{
			SetOrtho(left, right, bottom, top, near, far);
		}

		/// <summary>
		/// Construct a OrthoProjectionMatrixDouble from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Double"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public OrthoProjectionMatrixDouble(double[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// OrthoProjectionMatrixDouble copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="OrthoProjectionMatrix"/> to be copied.
		/// </param>
		public OrthoProjectionMatrixDouble(OrthoProjectionMatrixDouble m)
			: base(m)
		{

		}

		#endregion

		#region Orthographic Projection

		/// <summary>
		/// Set orthographic projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Double"/> indicating the distance of the top plane, in world units
		/// </param>
		/// <param name="near">
		/// A <see cref="Double"/> indicating the distance of the near plane, in world units
		/// </param>
		/// <param name="far">
		/// A <see cref="Double"/> indicating the distance of the far plane, in world units
		/// </param>
		public void SetOrtho(double left, double right, double bottom, double top, double near, double far)
		{
			// Column 1
			this[0, 0] = 2.0 / (right - left);
			this[0, 1] = 0.0;
			this[0, 2] = 0.0;
			this[0, 3] = 0.0;
			// Column 2
			this[1, 0] = 0.0;
			this[1, 1] = 2.0 / (top - bottom);
			this[1, 2] = 0.0;
			this[1, 3] = 0.0;
			// Column 3
			this[2, 0] = 0.0;
			this[2, 1] = 0.0;
			this[2, 2] = -2.0 / (far - near);
			this[2, 3] = 0.0;
			// Column 4
			this[3, 0] = -(right + left) / (right - left);
			this[3, 1] = -(top + bottom) / (top - bottom);
			this[3, 2] = -(far + near) / (far - near);
			this[3, 3] = 1.0;
		}

		/// <summary>
		/// Set bidimensional orthographic projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Double"/> indicating the distance of the left plane, in world units.
		/// </param>
		/// <param name="right">
		/// A <see cref="Double"/> indicating the distance of the right plane, in world units
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Double"/> indicating the distance of the bottom plane, in world units
		/// </param>
		/// <param name="top">
		/// A <see cref="Double"/> indicating the distance of the top plane, in world units
		/// </param>
		public void SetOrtho2D(double left, double right, double bottom, double top)
		{
			SetOrtho(left, right, bottom, top, -1.0, +1.0);
		}

		#endregion

		#region OrthoProjectionMatrix Methods

		/// <summary>
		/// Compute the transpose of this OrthoProjectionMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="OrthoProjectionMatrix"/> which hold the transpose of this OrthoProjectionMatrix.
		/// </returns>
		public new OrthoProjectionMatrixDouble Transpose()
		{
			OrthoProjectionMatrixDouble transpose = new OrthoProjectionMatrixDouble();

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
		public override double Near
		{
			get
			{
				double a = this[2, 2], b = this[3, 2];

				return (2.0 * ((a + 1.0) / (a - 1.0) - 0.5) * b);
			}
		}

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override double Far
		{
			get
			{
				double a = this[2, 2], b = this[3, 2];

				return (-0.5 * b * ((a - 1.0) / (a + 1.0) - 1.0));
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
		public override MatrixDouble Clone()
		{
			return (new OrthoProjectionMatrixDouble(this));
		}

		#endregion
	}

	/// <summary>
	/// Perspective projection matrix.
	/// </summary>
	public class PerspectiveProjectionMatrixDouble : ProjectionMatrixDouble
	{
		#region Constructors

		/// <summary>
		/// PerspectiveProjectionMatrixDouble constructor.
		/// </summary>
		public PerspectiveProjectionMatrixDouble()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a PerspectiveProjectionMatrixDouble from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="Double"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public PerspectiveProjectionMatrixDouble(double[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// PerspectiveProjectionMatrixDouble copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="PerspectiveProjectionMatrix"/> to be copied.
		/// </param>
		public PerspectiveProjectionMatrixDouble(PerspectiveProjectionMatrixDouble m)
			: base(m)
		{

		}

		#endregion

		#region Projections

		/// <summary>
		/// Set frustrum projection matrix.
		/// </summary>
		/// <param name="left">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="right">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="bottom">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="top">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="near">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="far">
		/// A <see cref="Double"/>
		/// </param>
		public void SetFustrum(double left, double right, double bottom, double top, double near, double far)
		{
			// Column 1
			this[0, 0] = 2.0 * near / (right - left);
			this[0, 1] = 0.0;
			this[0, 2] = 0.0;
			this[0, 3] = 0.0;
			// Column 2
			this[1, 0] = 0.0;
			this[1, 1] = 2.0 * near / (top - bottom);
			this[1, 2] = 0.0;
			this[1, 3] = 0.0;
			// Column 3
			this[2, 0] = (right + left) / (right - left);
			this[2, 1] = (top + bottom) / (top - bottom);
			this[2, 2] = (-far - near) / (far - near);
			this[2, 3] = -1.0;
			// Coumn 4
			this[3, 0] = 0.0;
			this[3, 1] = 0.0;
			this[3, 2] = -2.0 * far * near / (far - near);
			this[3, 3] = 0.0;
		}

		/// <summary>
		/// Set a perspective projection matrix.
		/// </summary>
		public void SetPerspective(double fovy, double aspectRatio, double near, double far)
		{
			double ymax = near * Math.Tan(fovy * Math.PI / 360.0);
			double xmax = ymax * aspectRatio;

			SetFustrum(-xmax, +xmax, -ymax, +ymax, near, far);
		}

		#endregion

		#region PerspectiveProjectionMatrix Methods

		/// <summary>
		/// Compute the transpose of this PerspectiveProjectionMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="PerspectiveProjectionMatrix"/> which hold the transpose of this PerspectiveProjectionMatrix.
		/// </returns>
		public new PerspectiveProjectionMatrixDouble Transpose()
		{
			PerspectiveProjectionMatrixDouble transpose = new PerspectiveProjectionMatrixDouble();

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
		public override double Near
		{
			get
			{
				double a = this[2, 2], b = this[3, 2];

				return (2.0f * ((a + 1.0f) / (a - 1.0f) - 0.5f) * b);
			}
		}

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		/// <remarks>
		/// The far plane distance computation is based directly on matrix components.
		/// </remarks>
		public override double Far
		{
			get
			{
				double a = this[2, 2], b = this[3, 2];

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
		public override MatrixDouble Clone()
		{
			return (new PerspectiveProjectionMatrixDouble(this));
		}

		#endregion
	}
}
