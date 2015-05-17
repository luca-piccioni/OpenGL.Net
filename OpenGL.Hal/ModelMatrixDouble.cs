
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
	/// Model matrix implementation.
	/// </summary>
	/// <remarks>
	/// <para>
	/// ModelMatrix class allow to manage a tranformation matrix. It is a 4x4 matrix
	/// of floating point values. These values are able to transform a vertex coordinate.
	/// </para>
	/// </remarks>
	public sealed class ModelMatrixDouble : MatrixDouble4x4, IModelMatrix
	{
		#region Constructors

		/// <summary>
		/// ModelMatrix constructor.
		/// </summary>
		/// <remarks>
		/// It set this ModelMatrix to identity.
		/// </remarks>
		public ModelMatrixDouble()
		{
			SetIdentity();
		}

		/// <summary>
		/// Construct a matrix from a sequence of components.
		/// </summary>
		/// <param name="values">
		/// An array of <see cref="System.Double"/>, representing the matrix components in column-major order.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="values"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="values"/> length differs from 16.
		/// </exception>
		public ModelMatrixDouble(double[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// Construct ModelMatrixDouble from a <see cref="MatrixDouble4x4"/>.
		/// </summary>
		/// <param name="m">
		/// A <see cref="MatrixDouble4x4"/> to be copied.
		/// </param>
		public ModelMatrixDouble(MatrixDouble4x4 m)
			: base(m)
		{

		}

		/// <summary>
		/// ModelMatrixDouble copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ModelMatrix"/> to be copied.
		/// </param>
		public ModelMatrixDouble(ModelMatrixDouble m)
			: base(m)
		{

		}
		
		/// <summary>
		/// Construct a matrix which is a copy of another matrix.
		/// </summary>
		/// <param name="m">
		/// A <see cref="IMatrix"/> to be copied.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="m"/> is null.
		/// </exception>
		public ModelMatrixDouble(IMatrix m)
			: base(m)
		{
			
		}

		#endregion

		#region Transform Functions

		#region Translation

		/// <summary>
		/// Get or set the position of the model.
		/// </summary>
		public Vertex3d Position
		{
			get
			{
				return ((Vertex3d)new Vertex4d(this[3, 0], this[3, 1], this[3, 2], this[3, 3]));
			}
			set
			{
				this[3, 0] = value.x;
				this[3, 1] = value.y;
				this[3, 2] = value.z;
				this[3, 3] = 1.0;
			}
		}

		#endregion

		#endregion

		#region Operators

		/// <summary>
		/// Compute the product of a ModelMatrix with a Vertex3f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ModelMatrix"/> that specifies the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specifies the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and
		/// the vector <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		public static Vertex4d operator *(ModelMatrixDouble m, Vertex3d v)
		{
			return ((MatrixDouble4x4)m * (Vertex4d)v);
		}

		/// <summary>
		/// Compute the product of a ModelMatrix with a Vertex4f.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ModelMatrix"/> that specifies the left multiplication operand.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specifies the right vector operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> resulting from the product of the matrix <paramref name="m"/> and
		/// the vector <paramref name="v"/>. This operator is used to transform a vector by a matrix.
		/// </returns>
		public static Vertex4d operator *(ModelMatrixDouble m, Vertex4d v)
		{
			return ((MatrixDouble4x4)m * v);
		}

		/// <summary>
		/// Rotate a ModelMatrix in three-dimensional space using Quaternion.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="q"></param>
		/// <returns></returns>
		public static MatrixDouble4x4 operator *(ModelMatrixDouble m, Quaternion q)
		{
			return ((MatrixDouble4x4)m * q);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrixDouble operator +(ModelMatrixDouble m, Vertex3d v)
		{
			ModelMatrixDouble res = new ModelMatrixDouble(m);

			res.Translate(v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrixDouble operator -(ModelMatrixDouble m, Vertex3d v)
		{
			ModelMatrixDouble res = new ModelMatrixDouble(m);

			res.Translate(-v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrixDouble operator +(ModelMatrixDouble m, Vertex2d v)
		{
			ModelMatrixDouble res = new ModelMatrixDouble(m);

			res.Translate(v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in two-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrixDouble operator -(ModelMatrixDouble m, Vertex2d v)
		{
			ModelMatrixDouble res = new ModelMatrixDouble(m);

			res.Translate(-v);

			return (res);
		}

		/// <summary>
		/// Compute the product of two ModelMatrix.
		/// </summary>
		/// <param name="m1">
		/// A <see cref="Matrix4x4"/> that specifies the left multiplication operand.
		/// </param>
		/// <param name="m2">
		/// A <see cref="Matrix4x4"/> that specifies the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="Matrix4x4"/> resulting from the product of the matrix <paramref name="m1"/> and
		/// the matrix <paramref name="m2"/>. This operator is used to concatenate successive transformations.
		/// </returns>
		public static ModelMatrixDouble operator *(ModelMatrixDouble m1, ModelMatrixDouble m2)
		{
			// Allocate product matrix
			ModelMatrixDouble prod = new ModelMatrixDouble();

			// Compute product
			ComputeMatrixProduct(prod, m1, m2);

			return (prod);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this ModelMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="ModelMatrix"/> which hold the transpose of this ModelMatrix.
		/// </returns>
		public new ModelMatrixDouble Transpose()
		{
			ModelMatrixDouble transpose = new ModelMatrixDouble();

			// Transpose matrix
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from ModelMatrix to ModelMatrixDouble operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ModelMatrix"/> to be converted to <see cref="ModelMatrixDouble"/>.
		/// </param>
		/// <returns>
		/// A <see cref="ModelMatrixDouble"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static implicit operator ModelMatrixDouble(ModelMatrix a)
		{
			if (a == null)
				return (null);
			
			ModelMatrixDouble matrix = new ModelMatrixDouble();

			for (int i = 0; i < 16; i++)
				matrix.MatrixBuffer[i] = a.MatrixBuffer[i];

			return (matrix);
		}
		
		#endregion
		
		#region MatrixDouble4x4 Overrides

		/// <summary>
		/// Clone this ModelMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this ModelMatrix.
		/// </returns>
		public override MatrixDouble Clone()
		{
			return (new ModelMatrixDouble(this));
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this ModelMatrix.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="System.String"/> that represents this ModelMatrix.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("ModelMatrixDouble: Position={0}, Rotation={1}", Position.ToString(), Rotation));
		}

		#endregion

		#region IModelMatrix Implementation

		/// <summary>
		/// Get the translation of this ModelMatrixDouble.
		/// </summary>
		Vertex4d IModelMatrix.Position
		{
			get
			{
				return (new Vertex4d(this[3, 0], this[3, 1], this[3, 2], this[3, 3]));
			}
			set
			{
				this[3, 0] = value.x;
				this[3, 1] = value.y;
				this[3, 2] = value.z;
				this[3, 3] = value.w;
			}
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrixDouble.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Double"/> indicating the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Double"/> indicating the translation on Y axis.
		/// </param>
		public void Translate(double x, double y)
		{
			ModelMatrixDouble translationMatrix = new ModelMatrixDouble();

			translationMatrix[3, 0] = x;
			translationMatrix[3, 1] = y;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrixDouble.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Double"/> indicating the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Double"/> indicating the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="System.Double"/> indicating the translation on Z axis.
		/// </param>
		public void Translate(double x, double y, double z)
		{
			ModelMatrixDouble translationMatrix = new ModelMatrixDouble();

			translationMatrix[3, 0] = x;
			translationMatrix[3, 1] = y;
			translationMatrix[3, 2] = z;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrixDouble.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex2d"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex2d p)
		{
			ModelMatrixDouble translationMatrix = new ModelMatrixDouble();

			translationMatrix[3, 0] = p.x;
			translationMatrix[3, 1] = p.y;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrixDouble.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3d"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex3d p)
		{
			ModelMatrixDouble translationMatrix = new ModelMatrixDouble();

			translationMatrix[3, 0] = p.x;
			translationMatrix[3, 1] = p.y;
			translationMatrix[3, 2] = p.z;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Get the rotation of this ModelMatrix.
		/// </summary>
		public Quaternion Rotation
		{
			get
			{
				Vertex4d quaternionParams = new Vertex4d();

				// The formula
				// 
				// q4 = 0.5 * sqrt(1 + a11 + a22 + a33)
				// q1 = 1.0 / (4*q4) * (a32 - a23)
				// q2 = 1.0 / (4*q4) * (a13 - a31)
				// q3 = 1.0 / (4*q4) * (a21 - a12)

				quaternionParams.w = (float)(0.5 * Math.Sqrt(1.0f + this[0, 0] + this[1, 1] + this[2, 2]));
				quaternionParams.x = (1.0 / (4.0 * quaternionParams.w)) * (this[1, 2] - this[2, 1]);
				quaternionParams.y = (1.0 / (4.0 * quaternionParams.w)) * (this[2, 0] - this[0, 2]);
				quaternionParams.z = (1.0 / (4.0 * quaternionParams.w)) * (this[0, 1] - this[1, 0]);

				return (new Quaternion(quaternionParams.x, quaternionParams.y, quaternionParams.z, quaternionParams.w));
			}
		}

		/// <summary>
		/// Accumulate a rotation to this ModelMatrixDouble.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		public void Rotate(Quaternion q)
		{
			if (q == null)
				throw new ArgumentNullException("q");

			Set((MatrixDouble4x4)this * (MatrixDouble4x4)q);
		}

		/// <summary>
		/// Accumulate a rotation on X axis to this ModelMatrixDouble.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation angle, in degrees.
		/// </param>
		public void RotateX(double angle)
		{
			ModelMatrixDouble rotationMatrix = new ModelMatrixDouble();
			double cosa = Math.Cos(angle * Angle.DegreeToRadian);
			double sina = Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[1, 1] = +cosa;
			rotationMatrix[2, 1] = -sina;
			rotationMatrix[1, 2] = +sina;
			rotationMatrix[2, 2] = +cosa;

			Set((MatrixDouble4x4)this * (MatrixDouble4x4)rotationMatrix);
		}

		/// <summary>
		/// Accumulate a rotation on Y axis to this ModelMatrixDouble.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation angle, in degrees.
		/// </param>
		public void RotateY(double angle)
		{
			ModelMatrixDouble rotationMatrix = new ModelMatrixDouble();
			double cosa = Math.Cos(angle * Angle.DegreeToRadian);
			double sina = Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[0, 0] = +cosa;
			rotationMatrix[2, 0] = +sina;
			rotationMatrix[0, 2] = -sina;
			rotationMatrix[2, 2] = +cosa;

			Set((MatrixDouble4x4)this * (MatrixDouble4x4)rotationMatrix);
		}

		/// <summary>
		/// Accumulate a rotation on Z axis to this ModelMatrixDouble.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation angle, in degrees.
		/// </param>
		public void RotateZ(double angle)
		{
			ModelMatrixDouble rotationMatrix = new ModelMatrixDouble();
			double cosa = Math.Cos(angle * Angle.DegreeToRadian);
			double sina = Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[0, 0] = +cosa;
			rotationMatrix[1, 0] = -sina;
			rotationMatrix[0, 1] = +sina;
			rotationMatrix[1, 1] = +cosa;

			Set((MatrixDouble4x4)this * (MatrixDouble4x4)rotationMatrix);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="System.Double"/> holding the scaling factor on X, Y and Z axes.
		/// </param>
		public void Scale(double s)
		{
			ModelMatrixDouble scaleModel = new ModelMatrixDouble();

			scaleModel[0, 0] = s;
			scaleModel[1, 1] = s;
			scaleModel[2, 2] = s;

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Double"/> holding the scaling factor on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Double"/> holding the scaling factor on Y axis.
		/// </param>
		public void Scale(double x, double y)
		{
			ModelMatrixDouble scaleModel = new ModelMatrixDouble();

			scaleModel[0, 0] = x;
			scaleModel[1, 1] = y;

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Double"/> holding the scaling factor on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Double"/> holding the scaling factor on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="System.Double"/> holding the scaling factor on Z axis.
		/// </param>
		public void Scale(double x, double y, double z)
		{
			ModelMatrixDouble scaleModel = new ModelMatrixDouble();

			scaleModel[0, 0] = x;
			scaleModel[1, 1] = y;
			scaleModel[2, 2] = z;

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex2d"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex2d s)
		{
			ModelMatrixDouble scaleModel = new ModelMatrixDouble();

			scaleModel[0, 0] = s.x;
			scaleModel[1, 1] = s.y;

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex3d"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex3d s)
		{
			ModelMatrixDouble scaleModel = new ModelMatrixDouble();

			scaleModel[0, 0] = s.x;
			scaleModel[1, 1] = s.y;
			scaleModel[2, 2] = s.z;

			Set(this * scaleModel);
		}

		/// <summary>
		/// Get/set the forward vector of this model-view matrix.
		/// </summary>
		public Vertex3d ForwardVector
		{
			get
			{
				Vertex3d forwardVector;

				forwardVector.x = this[2, 0];
				forwardVector.y = this[2, 1];
				forwardVector.z = this[2, 2];

				return ((-forwardVector).Normalized);
			}
			set
			{
				Vertex3d upVector = UpVector;
				Vertex3d targetPosition = Position + value.Normalized;

				LookAtTarget(Position, targetPosition, upVector);
			}
		}

		/// <summary>
		/// Get the right vector of this model-view matrix.
		/// </summary>
		public Vertex3d RightVector
		{
			get
			{
				Vertex3d rightVector;

				rightVector.x = this[0, 0];
				rightVector.y = this[0, 1];
				rightVector.z = this[0, 2];

				return (rightVector.Normalized);
			}
			set { }
		}

		/// <summary>
		/// Get/set the up vector of this model-view matrix.
		/// </summary>
		public Vertex3d UpVector
		{
			get
			{
				Vertex3d upVector;

				upVector.x = this[1, 0];
				upVector.y = this[1, 1];
				upVector.z = this[1, 2];

				return (upVector.Normalized);
			}
			set
			{
				LookAtDirection(Position, ForwardVector, value.Normalized);
			}
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3f"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <remarks>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from current position, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to the current up vector.
		/// </remarks>
		public void LookAtTarget(Vertex3d targetPosition)
		{
			LookAtTarget(Position, targetPosition);
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3f"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3f"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <remarks>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to the current up vector.
		/// </remarks>
		public void LookAtTarget(Vertex3d eyePosition, Vertex3d targetPosition)
		{
			LookAtTarget(eyePosition, targetPosition, Vertex3d.UnitY);
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3f"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3f"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3f"/> that specify the up vector of the view camera abstraction.
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public void LookAtTarget(Vertex3d eyePosition, Vertex3d targetPosition, Vertex3d upVector)
		{
			LookAtDirection(eyePosition, targetPosition - eyePosition, upVector);
		}

		/// <summary>
		/// Setup this matrix to view the universe in a certain direction.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3f"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="forwardVector">
		/// A <see cref="Vertex3f"/> that specify the direction of the view. It will be normalized.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3f"/> that specify the up vector of the view camera abstraction. It will be normalized
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="forwardVector"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public void LookAtDirection(Vertex3d eyePosition, Vertex3d forwardVector, Vertex3d upVector)
		{
			Vertex3d rightVector;

			// Normalize forward vector
			forwardVector.Normalize();
			// Normalize up vector (it should already be normalized)
			upVector.Normalize();
			// Compute the right vector (cross-product between forward and up vectors; right is perperndicular to the plane)
			rightVector = forwardVector ^ upVector;
			rightVector.Normalize();
			// Derive up vector
			upVector = rightVector ^ forwardVector;

			// Compute view matrix
			ModelMatrixDouble lookatMatrix = new ModelMatrixDouble(), positionMatrix = new ModelMatrixDouble();

			// Row 0: right vector
			lookatMatrix[0, 0] = rightVector.x;
			lookatMatrix[0, 1] = rightVector.y;
			lookatMatrix[0, 2] = rightVector.z;
			// Row 1: up vector
			lookatMatrix[1, 0] = upVector.x;
			lookatMatrix[1, 1] = upVector.y;
			lookatMatrix[1, 2] = upVector.z;
			// Row 2: opposite of forward vector
			lookatMatrix[2, 0] = -forwardVector.x;
			lookatMatrix[2, 1] = -forwardVector.y;
			lookatMatrix[2, 2] = -forwardVector.z;

			// Eye position
			positionMatrix.Translate(eyePosition);

			// Complete look-at matrix
			Set(positionMatrix * lookatMatrix);
		}

		/// <summary>
		/// Inverse Matrix of this Matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IMatrix"/> representing the inverse matrix of this Matrix.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The exception is thrown if this Matrix is not square, or it's determinant is 0.0.
		/// </exception>
		IModelMatrix IModelMatrix.GetInverseMatrix()
		{
			return ((IModelMatrix)base.GetInverseMatrix());
		}

		/// <summary>
		/// Multiply this IModelMatrix with another IModelMatrix.
		/// </summary>
		/// <param name="a">
		/// A <see cref="IModelMatrix"/> that specifies the right multiplication operand.
		/// </param>
		/// <returns>
		/// A <see cref="IModelMatrix"/> resulting from the product of this matrix and the matrix <paramref name="a"/>.
		/// </returns>
		IModelMatrix IModelMatrix.Multiply(IModelMatrix a)
		{
			ModelMatrixDouble rModelMatrix = new ModelMatrixDouble();

			ModelMatrixDouble modelMatrixDouble = a as ModelMatrixDouble;
			if (modelMatrixDouble != null) {
				ComputeMatrixProduct(rModelMatrix, this, modelMatrixDouble);
				return (rModelMatrix);
			}

			ModelMatrix modelMatrix = a as ModelMatrix;
			if (modelMatrix != null) {
				ComputeMatrixProduct(rModelMatrix, this, modelMatrix);
				return (rModelMatrix);
			}

			throw new NotSupportedException(String.Format("multiplication of {0} by {1} is not supported", GetType(), a.GetType()));
		}

		/// <summary>
		/// Compute the transpose of this model matrix.
		/// </summary>
		/// <returns>
		/// A <see cref="IModelMatrix"/> which hold the transpose of this model matrix.
		/// </returns>
		IModelMatrix IModelMatrix.Transpose()
		{
			return (Transpose());
		}

		#endregion
	}
}
