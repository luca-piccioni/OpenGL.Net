
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
	/// Quaternion.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Quaternion are used to represents a rotation in a three-dimensional space.
	/// </para>
	/// <para>
	/// Theory links:
	/// - http://en.wikipedia.org/wiki/Quaternions_and_spatial_rotation
	/// - http://en.wikipedia.org/wiki/Rotation_representation
	/// </para>
	/// </remarks>
	public class Quaternion
	{
		#region Constructors

		/// <summary>
		/// Construct a Quaternion from quaternion components.
		/// </summary>
		/// <param name="q1">
		/// A <see cref="Double"/> that specify the quaternion component <i>q1</i>.
		/// </param>
		/// <param name="q2">
		/// A <see cref="Double"/> that specify the quaternion component <i>q2</i>.
		/// </param>
		/// <param name="q3">
		/// A <see cref="Double"/> that specify the quaternion component <i>q3</i>.
		/// </param>
		/// <param name="q4">
		/// A <see cref="Double"/> that specify the quaternion component <i>q4</i> (scalar component).
		/// </param>
		public Quaternion(double q1, double q2, double q3, double q4)
		{
			// Set the default rotation axis
			mDefaultVector = Vertex3d.UnitY;
			// Setup quaternion components
			mVector.x = q1;
			mVector.y = q2;
			mVector.z = q3;
			mCosAngle = q4;
			// Derive default rotation vector (due quaternion definition)
			mDefaultVector = (Vertex3d)RotationVector;
		}

		/// <summary>
		/// Quaternion constructor from euler rotation axis and rotation angle.
		/// </summary>
		/// <param name="rVector">
		/// A <see cref="Vertex3f"/> representing the rotation axis.
		/// </param>
		/// <param name="rAngle">
		/// A <see cref="System.Single"/> representing the rotation angle (in degrees).
		/// </param>
		/// <remarks>
		/// This constructor is the base implementation for each other constructor.
		/// </remarks>
		public Quaternion(Vertex3f rVector, float rAngle)
		{
			// Set the default rotation axis
			mDefaultVector = (Vertex3d)rVector;
			// Make compiler happy
			mVector = new Vertex3d();
			mCosAngle = 0.0f;

			// Set quaternion
			SetEuler(rVector, rAngle);
		}

		/// <summary>
		/// Quaternion constructor from euler rotation axis and rotation angle.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Quaternion"/> representing the rotation axis.
		/// </param>
		public Quaternion(Quaternion other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			// Set the default rotation axis
			mDefaultVector = other.mDefaultVector;
			// Copy quaternion fields
			mVector = other.mVector;
			mCosAngle = other.mCosAngle;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The default rotation axis used by this quaternion when it is an identity.
		/// </summary>
		private Vertex3d mDefaultVector;

		/// <summary>
		/// Quaternion vector values.
		/// </summary>
		/// <remarks>
		/// If the quaternion is defined as a vector {q1, q2, q3, q4}, this field corresponds to the
		/// vector component {q1, q2, q3}. This is not actually a vector!
		/// </remarks>
		private Vertex3d mVector;

		/// <summary>
		/// Quaternion "scalar" component.
		/// </summary>
		/// <remarks>
		/// If the quaternion is defined as a vector {q1, q2, q3, q4}, this field corresponds to the
		/// scalar component q4. This is not actually an angle!
		/// </remarks>
		private double mCosAngle;

		#endregion

		#region Euler Definitions

		/// <summary>
		/// Get or set the quaternion rotation unit vector.
		/// </summary>
		public Vertex3f RotationVector
		{
			get
			{
				if (mVector.Module() >= Single.Epsilon)
					mDefaultVector = mVector.Normalized;
					
				return (Vertex3f)(mDefaultVector);
			}
			set { SetEuler(value, RotationAngle); }
		}

		/// <summary>
		/// Get or set the quaternion rotation angle (in degrees).
		/// </summary>
		public float RotationAngle
		{
			get { return (float)(2.0 * Math.Acos(mCosAngle) * Angle.RadianToDegree); }
			set { SetEuler(RotationVector, value); }
		}

		/// <summary>
		/// Set quaternion using rotation axis and rotation angle.
		/// </summary>
		/// <param name="rVector">
		/// A <see cref="Vertex3f"/> representing the rotation axis. It will be normalized.
		/// </param>
		/// <param name="rAngle">
		/// A <see cref="System.Single"/> representing the rotation angle (in degrees).
		/// </param>
		/// <remarks>
		/// This quaternion will result normalized.
		/// </remarks>
		public void SetEuler(Vertex3f rVector, float rAngle)
		{
			double qAngle = rAngle * Angle.DegreeToRadian / 2.0;
			double qAngleSin = Math.Sin(qAngle);

			mVector.x = qAngleSin * rVector.x;
			mVector.y = qAngleSin * rVector.y;
			mVector.z = qAngleSin * rVector.z;
			mCosAngle = Math.Cos(qAngle);

			// Ensure normalized quaternion
			Normalize();
		}

		#endregion

		#region Quaternion Properties

		/// <summary>
		/// Quaternion <i>q1</i> component.
		/// </summary>
		public float X { get { return ((float)mVector.x); } set { mVector.x = value; } }

		/// <summary>
		/// Quaternion <i>q2</i> component.
		/// </summary>
		public float Y { get { return ((float)mVector.y); } set { mVector.y = value; } }

		/// <summary>
		/// Quaternion <i>q3</i> component.
		/// </summary>
		public float Z { get { return ((float)mVector.z); } set { mVector.z = value; } }

		/// <summary>
		/// Quaternion <i>q4</i> component.
		/// </summary>
		public float W { get { return ((float)mCosAngle); } set { mCosAngle = value; } }

		/// <summary>
		/// Compute this Quaternion magnitude.
		/// </summary>
		public double Magnitude
		{
			get {
				double x2 = mVector.x * mVector.x;
				double y2 = mVector.y * mVector.y;
				double z2 = mVector.z * mVector.z;
				double w2 = mCosAngle * mCosAngle;

				return (Math.Sqrt(x2 + y2 + z2 + w2));
			}
		}

		/// <summary>
		/// Determine whether this quaternion is identity (no rotation).
		/// </summary>
		public bool IsIdentity
		{
			get
			{
				if (Math.Abs(mVector.Module()) >= Single.Epsilon)
					return (false);
				if (Math.Abs(mCosAngle - 1.0f) >= Single.Epsilon)
					return (false);

				return (true);
			}
		}

		/// <summary>
		/// Determine whether this quaternion is normalized.
		/// </summary>
		public bool IsNormalized
		{
			get { return (Math.Abs(Magnitude - 1.0) < Single.Epsilon); }
		}

		#endregion

		#region Quaternion Operations

		/// <summary>
		/// Normalize this Quaternion.
		/// </summary>
		public void Normalize()
		{
			double magnitude = Magnitude;

			if (magnitude >= Single.Epsilon) {
				double scale = 1.0 / Magnitude;

				mVector *= scale;
				mCosAngle *= scale;	
			} else
				throw new InvalidOperationException("zero magnitude quaternion");
		}

		/// <summary>
		/// Conjugate this Quaternion.
		/// </summary>
		public Quaternion Conjugate
		{
			get
			{
				Quaternion conjugate = this;

				conjugate.mVector = -conjugate.mVector;

				return (conjugate);
			}
		}

		#endregion

		#region Arithmetich Operators

		/// <summary>
		/// Quaternion multiplication (concatenate rotations).
		/// </summary>
		/// <param name="q1">
		/// A <see cref="Quaternion"/> representing the left multiplication operand. This rotation is the "starting" state.
		/// </param>
		/// <param name="q2">
		/// A <see cref="Quaternion"/> representing the right multiplication operand. This rotation is applied to <paramref name="q1"/>.
		/// </param>
		/// <returns>
		/// It returns the multiplication between two quaternions.
		/// </returns>
		public static Quaternion operator *(Quaternion q1, Quaternion q2)
		{
//			double x1 = q1.mVector.x, y1 = q1.mVector.y, z1 = q1.mVector.z, w1 = q1.mCosAngle;
//			double x2 = q2.mVector.x, y2 = q2.mVector.y, z2 = q2.mVector.z, w2 = q2.mCosAngle;
//
//			double _q1 = w2 * x1 + x2 * w1 - y2 * z1 + z2 * y1;
//			double _q2 = w2 * y1 + x2 * z1 + y2 * w1 - z2 * x1;
//			double _q3 = w2 * z1 - x2 * y1 + y2 * x1 + z2 * w1;
//			double _q4 = w2 * w1 - x2 * x1 - y2 * y1 - z2 * z1;
//
//			return (new Quaternion(_q1, _q2, _q3, _q4));
			
			double x1 = q1.mVector.x, y1 = q1.mVector.y, z1 = q1.mVector.z, w1 = q1.mCosAngle;
			double x2 = q2.mVector.x, y2 = q2.mVector.y, z2 = q2.mVector.z, w2 = q2.mCosAngle;

			double _q1 = w1*x2 + x1*w2 + y1*z2 - z1*y2;
			double _q2 = w1*y2 + y1*w2 + x1*z2 - z1*x2;
			double _q3 = w1*z2 + z1*w2 + x1*y2 - y1*x2;
			double _q4 = w1*w2 - x1*x2 - y1*y2 - z1*z2;

			return (new Quaternion(_q1, _q2, _q3, _q4));
		}
		
		#endregion

		#region Cast Operators

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix3x3"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix3x3(Quaternion q)
		{
			Matrix3x3 dcm = new Matrix3x3();		// Direction cosine matrix
			double q1 = q.mVector.x, q2 = q.mVector.y, q3 = q.mVector.z, q4 = q.mCosAngle;
			double q1__2 = q1*q1, q2__2 = q2*q2, q3__2 = q3*q3;
			
			dcm[0,0] = (float)(1.0f - 2.0f * (q2__2 + q3__2));
			dcm[1,0] = (float)(		  2.0f * (q1*q2 - q3*q4));
			dcm[2,0] = (float)(		  2.0f * (q1*q3 + q2*q4));

			dcm[0,1] = (float)(		  2.0f * (q1*q2 + q3*q4));
			dcm[1,1] = (float)(1.0f - 2.0f * (q1__2 + q3__2));
			dcm[2,1] = (float)(		  2.0f * (q2*q3 - q1*q4));

			dcm[0,2] = (float)(		  2.0f * (q1*q3 - q2*q4));
			dcm[1,2] = (float)(		  2.0f * (q1*q4 + q2*q3));
			dcm[2,2] = (float)( 1.0f - 2.0f * (q1__2 + q2__2));

			return (dcm);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix3x3"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator MatrixDouble3x3(Quaternion q)
		{
			MatrixDouble3x3 dcm = new MatrixDouble3x3();		// Direction cosine matrix
			double q1 = q.mVector.x, q2 = q.mVector.y, q3 = q.mVector.z, q4 = q.mCosAngle;
			double q1__2 = q1 * q1, q2__2 = q2 * q2, q3__2 = q3 * q3;

			dcm[0, 0] = 1.0 - 2.0 * (q2__2 + q3__2);
			dcm[1, 0] = 2.0 * (q1 * q2 - q3 * q4);
			dcm[2, 0] = 2.0 * (q1 * q3 + q2 * q4);

			dcm[0, 1] = 2.0 * (q1 * q2 + q3 * q4);
			dcm[1, 1] = 1.0 - 2.0f * (q1__2 + q3__2);
			dcm[2, 1] = 2.0 * (q2 * q3 - q1 * q4);

			dcm[0, 2] = 2.0 * (q1 * q3 - q2 * q4);
			dcm[1, 2] = 2.0 * (q1 * q4 + q2 * q3);
			dcm[2, 2] = 1.0 - 2.0f * (q1__2 + q2__2);

			return (dcm);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="ModelMatrix"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix4x4(Quaternion q)
		{
			Matrix4x4 dcm = new Matrix4x4();		// Direction cosine matrix
			double q1 = q.mVector.x, q2 = q.mVector.y, q3 = q.mVector.z, q4 = q.mCosAngle;
			double q1__2 = q1*q1, q2__2 = q2*q2, q3__2 = q3*q3;
			
			dcm[0,0] = (float)(1.0f - 2.0f * (q2__2 + q3__2));
			dcm[1,0] = (float)(		  2.0f * (q1*q2 - q3*q4));
			dcm[2,0] = (float)(		  2.0f * (q1*q3 + q2*q4));
			dcm[3,0] = 0.0f;

			dcm[0,1] = (float)(		  2.0f * (q1*q2 + q3*q4));
			dcm[1,1] = (float)(1.0f - 2.0f * (q1__2 + q3__2));
			dcm[2,1] = (float)(		  2.0f * (q2*q3 - q1*q4));
			dcm[3,1] = 0.0f;

			dcm[0,2] = (float)(		  2.0f * (q1*q3 - q2*q4));
			dcm[1,2] = (float)(		  2.0f * (q1*q4 + q2*q3));
			dcm[2,2] = (float)( 1.0f - 2.0f * (q1__2 + q2__2));
			dcm[3,2] = 0.0f;

			dcm[0,3] = 0.0f;
			dcm[1,3] = 0.0f;
			dcm[2,3] = 0.0f;
			dcm[3,3] = 1.0f;

			return (dcm);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="ModelMatrix"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator MatrixDouble4x4(Quaternion q)
		{
			MatrixDouble4x4 dcm = new MatrixDouble4x4();		// Direction cosine matrix
			double q1 = q.mVector.x, q2 = q.mVector.y, q3 = q.mVector.z, q4 = q.mCosAngle;
			double q1__2 = q1 * q1, q2__2 = q2 * q2, q3__2 = q3 * q3;

			dcm[0, 0] = 1.0 - 2.0 * (q2__2 + q3__2);
			dcm[1, 0] = 2.0 * (q1 * q2 - q3 * q4);
			dcm[2, 0] = 2.0 * (q1 * q3 + q2 * q4);
			dcm[3, 0] = 0.0;

			dcm[0, 1] = 2.0 * (q1 * q2 + q3 * q4);
			dcm[1, 1] = 1.0 - 2.0f * (q1__2 + q3__2);
			dcm[2, 1] = 2.0 * (q2 * q3 - q1 * q4);
			dcm[3, 1] = 0.0;

			dcm[0, 2] = 2.0 * (q1 * q3 - q2 * q4);
			dcm[1, 2] = 2.0 * (q1 * q4 + q2 * q3);
			dcm[2, 2] = 1.0 - 2.0f * (q1__2 + q2__2);
			dcm[3, 2] = 0.0;

			dcm[0, 3] = 0.0;
			dcm[1, 3] = 0.0;
			dcm[2, 3] = 0.0;
			dcm[3, 3] = 1.0;

			return (dcm);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="ModelMatrix"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator ModelMatrix(Quaternion q)
		{
			ModelMatrix dcm = new ModelMatrix();		// Direction cosine matrix
			double q1 = q.mVector.x, q2 = q.mVector.y, q3 = q.mVector.z, q4 = q.mCosAngle;
			double q1__2 = q1*q1, q2__2 = q2*q2, q3__2 = q3*q3;
			
			dcm[0,0] = (float)(1.0f - 2.0f * (q2__2 + q3__2));
			dcm[1,0] = (float)(		  2.0f * (q1*q2 - q3*q4));
			dcm[2,0] = (float)(		  2.0f * (q1*q3 + q2*q4));
			dcm[3,0] = 0.0f;

			dcm[0,1] = (float)(		  2.0f * (q1*q2 + q3*q4));
			dcm[1,1] = (float)(1.0f - 2.0f * (q1__2 + q3__2));
			dcm[2,1] = (float)(		  2.0f * (q2*q3 - q1*q4));
			dcm[3,1] = 0.0f;

			dcm[0,2] = (float)(		  2.0f * (q1*q3 - q2*q4));
			dcm[1,2] = (float)(		  2.0f * (q1*q4 + q2*q3));
			dcm[2,2] = (float)( 1.0f - 2.0f * (q1__2 + q2__2));
			dcm[3,2] = 0.0f;

			dcm[0,3] = 0.0f;
			dcm[1,3] = 0.0f;
			dcm[2,3] = 0.0f;
			dcm[3,3] = 1.0f;

			return (dcm);
		}

		#endregion

		#region Notable Quaternions

		/// <summary>
		/// Identity quaternion (no rotation).
		/// </summary>
		public static readonly Quaternion Identity = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Quaternion.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="System.String"/> that represents this Quaternion.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("Axis: {0} Angle: {1}", RotationVector, RotationAngle));
		}

		#endregion
	}
}