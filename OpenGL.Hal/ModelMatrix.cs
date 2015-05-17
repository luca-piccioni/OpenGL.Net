
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
	/// Model matrix implementation.
	/// </summary>
	/// <remarks>
	/// <para>
	/// ModelMatrix class allow to manage a tranformation matrix. It is a 4x4 matrix
	/// of floating point values. These values are able to transform a vertex coordinate.
	/// </para>
	/// </remarks>
	public sealed class ModelMatrix : Matrix4x4, IModelMatrix
	{
		#region Constructors

		/// <summary>
		/// ModelMatrix constructor.
		/// </summary>
		/// <remarks>
		/// It set this ModelMatrix to identity.
		/// </remarks>
		public ModelMatrix()
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
		public ModelMatrix(float[] values)
			: base(values)
		{
		
		}

		/// <summary>
		/// Construct ModelMatrix from a <see cref="Matrix4x4"/>.
		/// </summary>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> to be copied.
		/// </param>
		public ModelMatrix(Matrix4x4 m)
			: base(m)
		{

		}

		/// <summary>
		/// ModelMatrix copy constructor.
		/// </summary>
		/// <param name="m">
		/// A <see cref="ModelMatrix"/> to be copied.
		/// </param>
		public ModelMatrix(ModelMatrix m)
			: base(m)
		{

		}

		#endregion

		#region View Matrix Transform Functions

		/// <summary>
		/// Get/set the forward vector of this model-view matrix.
		/// </summary>
		public Vertex3f ForwardVector
		{
			get
			{
				Vertex3f forwardVector;

				forwardVector.x = this[2, 0];
				forwardVector.y = this[2, 1];
				forwardVector.z = this[2, 2];

				return ((-forwardVector).Normalized);
			}
			set
			{
				Vertex3f upVector = UpVector;
				Vertex3f targetPosition = Position + value.Normalized;

				LookAtTarget(Position, targetPosition, upVector);
			}
		}

		/// <summary>
		/// Get the right vector of this model-view matrix.
		/// </summary>
		public Vertex3f RightVector
		{
			get
			{
				Vertex3f rightVector;

				rightVector.x = this[0, 0];
				rightVector.y = this[0, 1];
				rightVector.z = this[0, 2];

				return (rightVector.Normalized);
			}
		}

		/// <summary>
		/// Get/set the up vector of this model-view matrix.
		/// </summary>
		public Vertex3f UpVector
		{
			get
			{
				Vertex3f upVector;

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
		public void LookAtTarget(Vertex3f targetPosition)
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
		public void LookAtTarget(Vertex3f eyePosition, Vertex3f targetPosition)
		{
			LookAtTarget(eyePosition, targetPosition, Vertex3f.UnitY);
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
		public void LookAtTarget(Vertex3f eyePosition, Vertex3f targetPosition, Vertex3f upVector)
		{
			LookAtDirection(eyePosition, eyePosition - targetPosition, upVector);
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
		public void LookAtDirection(Vertex3f eyePosition, Vertex3f forwardVector, Vertex3f upVector)
		{
			Vertex3f rightVector;

			// Normalize forward vector
			forwardVector.Normalize();
			// Normalize up vector
			upVector.Normalize();
			// Compute the right vector (cross-product between forward and up vectors; right is perperndicular to the plane)
			rightVector = forwardVector ^ upVector;
			rightVector.Normalize();
			// Derive up vector
			upVector = rightVector ^ forwardVector;
			upVector.Normalize();

			// Compute view matrix
			ModelMatrix lookatMatrix = new ModelMatrix(), positionMatrix = new ModelMatrix();

			// Row 0: right vector
			lookatMatrix[0, 0] = rightVector.x;
			lookatMatrix[1, 0] = rightVector.y;
			lookatMatrix[2, 0] = rightVector.z;
			// Row 1: up vector
			lookatMatrix[0, 1] = upVector.x;
			lookatMatrix[1, 1] = upVector.y;
			lookatMatrix[2, 1] = upVector.z;
			// Row 2: opposite of forward vector
			lookatMatrix[0, 2] = forwardVector.x;
			lookatMatrix[1, 2] = forwardVector.y;
			lookatMatrix[2, 2] = forwardVector.z;

			// Eye position
			positionMatrix.Translate(-eyePosition);

			// Complete look-at matrix
			Set(lookatMatrix * positionMatrix);
			Set(GetInverseMatrix());
		}

		#endregion

		#region Transform Functions

		#region Translation

		/// <summary>
		/// Get the translation of this ModelMatrix.
		/// </summary>
		public Vertex3f Position
		{
			get
			{
				return ((Vertex3f)new Vertex4f(this[3, 0], this[3, 1], this[3, 2], this[3, 3]));
			}
			set
			{
				this[3, 0] = value.x;
				this[3, 1] = value.y;
				this[3, 2] = value.z;
				this[3, 3] = 1.0f;
			}
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> indicating the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> indicating the translation on Y axis.
		/// </param>
		public void Translate(float x, float y)
		{
			ModelMatrix translationMatrix = new ModelMatrix();

			translationMatrix[3, 0] = x;
			translationMatrix[3, 1] = y;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> indicating the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> indicating the translation on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> indicating the translation on Z axis.
		/// </param>
		public void Translate(float x, float y, float z)
		{
			ModelMatrix translationMatrix = new ModelMatrix();

			translationMatrix[3, 0] = x;
			translationMatrix[3, 1] = y;
			translationMatrix[3, 2] = z;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrix.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex2f"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex2f p)
		{
			ModelMatrix translationMatrix = new ModelMatrix();

			translationMatrix[3, 0] = p.x;
			translationMatrix[3, 1] = p.y;

			Set(this * translationMatrix);
		}

		/// <summary>
		/// Accumulate a translation on this ModelMatrix.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3f"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex3f p)
		{
			ModelMatrix translationMatrix = new ModelMatrix();

			translationMatrix[3, 0] = p.x;
			translationMatrix[3, 1] = p.y;
			translationMatrix[3, 2] = p.z;

			Set(this * translationMatrix);
		}

		#endregion

		#region Rotation

		/// <summary>
		/// Setup this matrix to represent a rotation on the X axis.
		/// </summary>
		/// <param name="angle">
		/// The rotation angle, in degree.
		/// </param>
		public void RotateX(float angle)
		{
			ModelMatrix rotationMatrix = new ModelMatrix();

			float cosa = (float)Math.Cos(angle * Angle.DegreeToRadian);
			float sina = (float)Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[1, 1] = +cosa;
			rotationMatrix[2, 1] = -sina;
			rotationMatrix[1, 2] = +sina;
			rotationMatrix[2, 2] = +cosa;

			Set(this * rotationMatrix);
		}

		/// <summary>
		/// Setup this matrix to represent a rotation on the Y axis.
		/// </summary>
		/// <param name="angle">
		/// The rotation angle, in degree.
		/// </param>
		public void RotateY(float angle)
		{
			ModelMatrix rotationMatrix = new ModelMatrix();

			float cosa = (float)Math.Cos(angle * Angle.DegreeToRadian);
			float sina = (float)Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[0, 0] = +cosa;
			rotationMatrix[2, 0] = +sina;
			rotationMatrix[0, 2] = -sina;
			rotationMatrix[2, 2] = +cosa;

			Set(this * rotationMatrix);
		}

		/// <summary>
		/// Setup this matrix to represent a rotation on the Z axis.
		/// </summary>
		/// <param name="angle">
		/// The rotation angle, in degree.
		/// </param>
		public void RotateZ(float angle)
		{
			ModelMatrix rotationMatrix = new ModelMatrix();

			float cosa = (float)Math.Cos(angle * Angle.DegreeToRadian);
			float sina = (float)Math.Sin(angle * Angle.DegreeToRadian);

			rotationMatrix[0, 0] = +cosa;
			rotationMatrix[1, 0] = -sina;
			rotationMatrix[0, 1] = +sina;
			rotationMatrix[1, 1] = +cosa;

			Set(this * rotationMatrix);
		}

		#endregion

		#region Scaling

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="System.Single"/> holding the scaling factor on X, Y and Z axes.
		/// </param>
		public void Scale(float s)
		{
			ModelMatrix scaleModel = new ModelMatrix();
			scaleModel.SetScale(s);

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Single"/> holding the scaling factor on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Single"/> holding the scaling factor on Y axis.
		/// </param>
		public void Scale(float x, float y)
		{
			ModelMatrix scaleModel = new ModelMatrix();
			scaleModel.SetScale(x, y);

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
		public void Scale(float x, float y, float z)
		{
			ModelMatrix scaleModel = new ModelMatrix();
			scaleModel.SetScale(x, y, z);

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex2f"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex2f s)
		{
			ModelMatrix scaleModel = new ModelMatrix();
			scaleModel.SetScale(s.x, s.y);

			Set(this * scaleModel);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex3f"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex3f s)
		{
			ModelMatrix scaleModel = new ModelMatrix();
			scaleModel.SetScale(s);

			Set(this * scaleModel);
		}

		/// <summary>
		/// Scale this ModelMatrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex3f"/> holding the scaling factors on three dimensions.
		/// </param>
		public void SetScale(Vertex3f s)
		{
			SetScale(s.x, s.y, s.z);
		}

		/// <summary>
		/// Scale this ModelMatrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex2f"/> holding the scaling factors on two dimensions.
		/// </param>
		public void SetScale(Vertex2f s)
		{
			SetScale(s.x, s.y, 1.0f);
		}

		/// <summary>
		/// Scale this ModelMatrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Single"/> holding the scaling factor on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Single"/> holding the scaling factor on Y axis.
		/// </param>
		/// <param name="z">
		/// A <see cref="System.Single"/> holding the scaling factor on Z axis.
		/// </param>
		public void SetScale(float x, float y, float z)
		{
			SetIdentity();

			base[0, 0] = x;
			base[1, 1] = y;
			base[2, 2] = z;
		}

		/// <summary>
		/// Scale this ModelMatrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Single"/> holding the scaling factor on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Single"/> holding the scaling factor on Y axis.
		/// </param>
		public void SetScale(float x, float y)
		{
			SetScale(x, y, 1.0f);
		}

		/// <summary>
		/// Scale this ModelMatrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="System.Single"/> holding the scaling factor on X, Y and Z axes.
		/// </param>
		public void SetScale(float s)
		{
			SetScale(s, s, s);
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
		public static Vertex4f operator *(ModelMatrix m, Vertex3f v)
		{
			return ((Matrix4x4)m * (Vertex4f)v);
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
		public static Vertex4f operator *(ModelMatrix m, Vertex4f v)
		{
			return ((Matrix4x4)m * v);
		}

		/// <summary>
		/// Rotate a ModelMatrix in three-dimensional space using Quaternion.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="q"></param>
		/// <returns></returns>
		public static Matrix4x4 operator *(ModelMatrix m, Quaternion q)
		{
			return ((Matrix4x4)m * q);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrix operator +(ModelMatrix m, Vertex3f v)
		{
			ModelMatrix res = new ModelMatrix(m);

			res.Translate(v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrix operator -(ModelMatrix m, Vertex3f v)
		{
			ModelMatrix res = new ModelMatrix(m);

			res.Translate(-v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in three-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrix operator +(ModelMatrix m, Vertex2f v)
		{
			ModelMatrix res = new ModelMatrix(m);

			res.Translate(v);

			return (res);
		}

		/// <summary>
		/// Translate a ModelMatrix in two-dimensional space.
		/// </summary>
		/// <param name="m"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		public static ModelMatrix operator -(ModelMatrix m, Vertex2f v)
		{
			ModelMatrix res = new ModelMatrix(m);

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
		public static ModelMatrix operator *(ModelMatrix m1, ModelMatrix m2)
		{
			// Allocate product matrix
			ModelMatrix prod = new ModelMatrix();

			// Compute product
			ComputeMatrixProduct(prod, m1, m2);

			return (prod);
		}

		#endregion
		
		#region Cast Operators

		/// <summary>
		/// Cast from ModelMatrixDouble to ModelMatrix operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="ModelMatrixDouble"/> to be converted to <see cref="ModelMatrix"/>.
		/// </param>
		/// <returns>
		/// A <see cref="ModelMatrix"/> equivalent to <paramref name="a"/>.
		/// </returns>
		public static explicit operator ModelMatrix(ModelMatrixDouble a)
		{
			if (a == null)
				return (null);
			
			ModelMatrix matrix = new ModelMatrix();

			for (int i = 0; i < 16; i++)
				matrix.MatrixBuffer[i] = (float)a.MatrixBuffer[i];

			return (matrix);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Compute the transpose of this ModelMatrix.
		/// </summary>
		/// <returns>
		/// A <see cref="ModelMatrix"/> which hold the transpose of this ModelMatrix.
		/// </returns>
		public new ModelMatrix Transpose()
		{
			ModelMatrix transpose = new ModelMatrix();

			// Transpose matrix
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					transpose[r, c] = this[c, r];

			return (transpose);
		}

		#endregion
		
		#region Matrix4x4 Overrides

		/// <summary>
		/// Clone this ModelMatrix.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this ModelMatrix.
		/// </returns>
		public override Matrix Clone()
		{
			return (new ModelMatrix(this));
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
			return (String.Format("ModelMatrix: Position={0}, Rotation={1}", Position.ToString(), Rotation));
		}

		#endregion

		#region IModelMatrix Implementation

		/// <summary>
		/// Get the translation of this ModelMatrix.
		/// </summary>
		Vertex4d IModelMatrix.Position
		{
			get
			{
				return (new Vertex4d(this[3, 0], this[3, 1], this[3, 2], this[3, 3]));
			}
			set
			{
				this[3, 0] = (float)value.x;
				this[3, 1] = (float)value.y;
				this[3, 2] = (float)value.z;
				this[3, 3] = (float)value.w;
			}
		}

		/// <summary>
		/// Accumulate a translation on this model matrix.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Double"/> indicating the translation on X axis.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Double"/> indicating the translation on Y axis.
		/// </param>
		public void Translate(double x, double y)
		{
			Translate((float)x, (float)y);
		}

		/// <summary>
		/// Accumulate a translation on this model matrix.
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
			Translate((float)x, (float)y, (float)z);
		}

		/// <summary>
		/// Accumulate a translation on this model matrix.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex2d"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex2d p)
		{
			Translate((float)p.x, (float)p.y);
		}

		/// <summary>
		/// Accumulate a translation on this model matrix.
		/// </summary>
		/// <param name="p">
		/// A <see cref="Vertex3d"/> that specifies the translation.
		/// </param>
		public void Translate(Vertex3d p)
		{
			Translate((float)p.x, (float)p.y, (float)p.z);
		}

		/// <summary>
		/// Get the rotation of this ModelMatrix.
		/// </summary>
		public Quaternion Rotation
		{
			get
			{
				Vertex4f quaternionParams = new Vertex4f();

				// The formula
				// 
				// q4 = 0.5 * sqrt(1 + a11 + a22 + a33)
				// q1 = 1.0 / (4*q4) * (a32 - a23)
				// q2 = 1.0 / (4*q4) * (a13 - a31)
				// q3 = 1.0 / (4*q4) * (a21 - a12)
				
				quaternionParams.w = (float)(0.5 * Math.Sqrt(1.0f + this[0, 0] + this[1, 1] + this[2, 2]));
				quaternionParams.x = (1.0f / (4.0f * quaternionParams.w)) * (this[2, 1] - this[1, 2]);
				quaternionParams.y = (1.0f / (4.0f * quaternionParams.w)) * (this[0, 2] - this[2, 0]);
				quaternionParams.z = (1.0f / (4.0f * quaternionParams.w)) * (this[1, 0] - this[0, 1]);
				
				quaternionParams.w = (float)(0.5 * Math.Sqrt(1.0f + this[0, 0] + this[1, 1] + this[2, 2]));
				quaternionParams.x = (1.0f / (4.0f * quaternionParams.w)) * (this[1, 2] - this[2, 1]);
				quaternionParams.y = (1.0f / (4.0f * quaternionParams.w)) * (this[2, 0] - this[0, 2]);
				quaternionParams.z = (1.0f / (4.0f * quaternionParams.w)) * (this[0, 1] - this[1, 0]);
				
#if false
				// Formula 2
				// 
				// q1 = 0.5 * sqrt(1 + a11 - a22 - a33)
				// q2 = 1.0 / (4*q1) * (a12 + a21)
				// q3 = 1.0 / (4*q1) * (a13 + a31)
				// q4 = 1.0 / (4*q1) * (a32 - a23)

				quaternionParams.w = (float)(0.5 * Math.Sqrt(1.0f + this[0, 0] - this[1, 1] - this[2, 2]));
				quaternionParams.x = (1.0f / (4.0f * quaternionParams.w)) * (this[0, 1] + this[1, 0]);
				quaternionParams.y = (1.0f / (4.0f * quaternionParams.w)) * (this[0, 2] + this[2, 0]);
				quaternionParams.z = (1.0f / (4.0f * quaternionParams.w)) * (this[2, 1] - this[1, 2]);
				
#endif

				return (new Quaternion(quaternionParams.x, quaternionParams.y, quaternionParams.z, quaternionParams.w));
			}
		}

		/// <summary>
		/// Accumulate a rotation to this ModelMatrix.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		public void Rotate(Quaternion q)
		{
			if (q == null)
				throw new ArgumentNullException("q");

			Set((Matrix4x4)this * (Matrix4x4)q);
		}

		/// <summary>
		/// Accumulate a rotation around the X axis to this model matrix.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation around the X axis.
		/// </param>
		public void RotateX(double angle)
		{
			RotateX((float)angle);
		}

		/// <summary>
		/// Accumulate a rotation around the X axis to this model matrix.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation around the X axis.
		/// </param>
		public void RotateY(double angle)
		{
			RotateY((float)angle);
		}

		/// <summary>
		/// Accumulate a rotation around the X axis to this model matrix.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="System.Double"/> representing the rotation around the X axis.
		/// </param>
		public void RotateZ(double angle)
		{
			RotateZ((float)angle);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="System.Double"/> holding the scaling factor on X, Y and Z axes.
		/// </param>
		public void Scale(double s)
		{
			Scale((float)s);
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
			Scale((float)x, (float)y);
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
			Scale((float)x, (float)y, (float)z);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex2d"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex2d s)
		{
			Scale((float)s.x, (float)s.y);
		}

		/// <summary>
		/// Accumulate a scaling to this model matrix.
		/// </summary>
		/// <param name="s">
		/// A <see cref="Vertex3d"/> holding the scaling factors on three dimensions.
		/// </param>
		public void Scale(Vertex3d s)
		{
			Scale((float)s.x, (float)s.y, (float)s.z);
		}

		/// <summary>
		/// Get/set the forward vector of this view matrix.
		/// </summary>
		Vertex3d IModelMatrix.ForwardVector
		{
			get { return ((Vertex3d)ForwardVector); }
			set { ForwardVector = (Vertex3f) value; }
		}

		/// <summary>
		/// Get the right vector of this view matrix.
		/// </summary>
		Vertex3d IModelMatrix.RightVector
		{
			get { return ((Vertex3d)RightVector); }
			set { }
		}

		/// <summary>
		/// Get/set the up vector of this view matrix.
		/// </summary>
		Vertex3d IModelMatrix.UpVector
		{
			get { return ((Vertex3d)UpVector); }
			set { UpVector = (Vertex3f)value; }
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3d"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <remarks>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from current position, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to the current up vector.
		/// </remarks>
		public void LookAtTarget(Vertex3d targetPosition)
		{
			LookAtTarget((Vertex3f)targetPosition);
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3d"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3d"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <remarks>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to the current up vector.
		/// </remarks>
		public void LookAtTarget(Vertex3d eyePosition, Vertex3d targetPosition)
		{
			LookAtTarget((Vertex3f)eyePosition, (Vertex3f)targetPosition);
		}

		/// <summary>
		/// Compute a model-view matrix in order to simulate the gluLookAt mithical GLU routine.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3d"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="targetPosition">
		/// A <see cref="Vertex3d"/> that specify the eye target position, in local coordinates.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3d"/> that specify the up vector of the view camera abstraction.
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="targetPosition"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public void LookAtTarget(Vertex3d eyePosition, Vertex3d targetPosition, Vertex3d upVector)
		{
			LookAtTarget((Vertex3f)eyePosition, (Vertex3f)targetPosition, (Vertex3f)upVector);
		}

		/// <summary>
		/// Setup this model matrix to view the universe in a certain direction.
		/// </summary>
		/// <param name="eyePosition">
		/// A <see cref="Vertex3d"/> that specify the eye position, in local coordinates.
		/// </param>
		/// <param name="forwardVector">
		/// A <see cref="Vertex3d"/> that specify the direction of the view. It will be normalized.
		/// </param>
		/// <param name="upVector">
		/// A <see cref="Vertex3d"/> that specify the up vector of the view camera abstraction. It will be normalized
		/// </param>
		/// <returns>
		/// It returns a view transformation matrix used to transform the world coordinate, in order to view
		/// the world from <paramref name="eyePosition"/>, looking at <paramref name="forwardVector"/> having
		/// an up direction equal to <paramref name="upVector"/>.
		/// </returns>
		public void LookAtDirection(Vertex3d eyePosition, Vertex3d forwardVector, Vertex3d upVector)
		{
			LookAtTarget((Vertex3f)eyePosition, (Vertex3f)forwardVector, (Vertex3f)upVector);
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
			ModelMatrix rModelMatrix = new ModelMatrix();

			ModelMatrix modelMatrix = a as ModelMatrix;
			if (modelMatrix != null) {
				ComputeMatrixProduct(rModelMatrix, this, modelMatrix);
				return (rModelMatrix);
			}

			ModelMatrixDouble modelMatrixDouble = a as ModelMatrixDouble;
			if (modelMatrixDouble != null) {
				ComputeMatrixProduct(rModelMatrix, this, modelMatrixDouble);
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
