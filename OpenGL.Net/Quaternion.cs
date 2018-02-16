
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

// ReSharper disable InconsistentNaming

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
	public struct Quaternion
	{
		#region Constructors

		/// <summary>
		/// Construct a Quaternion from quaternion components.
		/// </summary>
		/// <param name="q1">
		/// A <see cref="double"/> that specify the quaternion component <i>q1</i>.
		/// </param>
		/// <param name="q2">
		/// A <see cref="double"/> that specify the quaternion component <i>q2</i>.
		/// </param>
		/// <param name="q3">
		/// A <see cref="double"/> that specify the quaternion component <i>q3</i>.
		/// </param>
		/// <param name="q4">
		/// A <see cref="double"/> that specify the quaternion component <i>q4</i> (scalar component).
		/// </param>
		public Quaternion(double q1, double q2, double q3, double q4)
		{
			// Set the default rotation axis
			_DefaultVector = Vertex3d.UnitY;
			// Setup quaternion components
			_Vector.x = q1;
			_Vector.y = q2;
			_Vector.z = q3;
			_CosAngle = q4;
			// Derive default rotation vector (due quaternion definition)
			_DefaultVector = RotationVector;
		}

		/// <summary>
		/// Quaternion constructor from euler rotation axis and rotation angle.
		/// </summary>
		/// <param name="rVector">
		/// A <see cref="Vertex3d"/> representing the rotation axis.
		/// </param>
		/// <param name="rAngle">
		/// A <see cref="float"/> representing the rotation angle (in degrees).
		/// </param>
		/// <remarks>
		/// This constructor is the base implementation for each other constructor.
		/// </remarks>
		public Quaternion(Vertex3f rVector, float rAngle)
		{
			// Set the default rotation axis
			_DefaultVector = rVector;
			// Make compiler happy
			_Vector = new Vertex3d();
			_CosAngle = 0.0f;

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
			// Set the default rotation axis
			_DefaultVector = other._DefaultVector;
			// Copy quaternion fields
			_Vector = other._Vector;
			_CosAngle = other._CosAngle;
		}

		#endregion

		#region Structure

		/// <summary>
		/// The default rotation axis used by this quaternion when it is an identity.
		/// </summary>
		private Vertex3d _DefaultVector;

		/// <summary>
		/// Quaternion vector values.
		/// </summary>
		/// <remarks>
		/// If the quaternion is defined as a vector {q1, q2, q3, q4}, this field corresponds to the
		/// vector component {q1, q2, q3}. This is not actually a vector!
		/// </remarks>
		private Vertex3d _Vector;

		/// <summary>
		/// Quaternion "scalar" component.
		/// </summary>
		/// <remarks>
		/// If the quaternion is defined as a vector {q1, q2, q3, q4}, this field corresponds to the
		/// scalar component q4. This is not actually an angle!
		/// </remarks>
		private double _CosAngle;

		#endregion

		#region Euler Definitions

		/// <summary>
		/// Get or set the quaternion rotation unit vector.
		/// </summary>
		public Vertex3f RotationVector
		{
			get
			{
				if (_Vector.ModuleSquared() >= float.Epsilon)
					_DefaultVector = _Vector.Normalized;
					
				return (Vertex3f)_DefaultVector;
			}
			set { SetEuler(value, RotationAngle); }
		}

		/// <summary>
		/// Get or set the quaternion rotation angle (in degrees).
		/// </summary>
		public float RotationAngle
		{
			get { return (float)Angle.ToDegrees(2.0 * Math.Acos(_CosAngle)); }
			set { SetEuler(RotationVector, value); }
		}

		/// <summary>
		/// Set quaternion using rotation axis and rotation angle.
		/// </summary>
		/// <param name="rVector">
		/// A <see cref="Vertex3d"/> representing the rotation axis. It will be normalized.
		/// </param>
		/// <param name="rAngle">
		/// A <see cref="float"/> representing the rotation angle (in degrees).
		/// </param>
		/// <remarks>
		/// This quaternion will result normalized.
		/// </remarks>
		public void SetEuler(Vertex3f rVector, float rAngle)
		{
			double qAngle = Angle.ToRadians(rAngle / 2.0f);
			double qAngleSin = Math.Sin(qAngle);

			_Vector.x = qAngleSin * rVector.x;
			_Vector.y = qAngleSin * rVector.y;
			_Vector.z = qAngleSin * rVector.z;
			_CosAngle = Math.Cos(qAngle);

			// Ensure normalized quaternion
			Normalize();
		}

		#endregion

		#region Quaternion Properties

		/// <summary>
		/// Quaternion <i>q1</i> component.
		/// </summary>
		public float X { get { return (float)_Vector.x; } set { _Vector.x = value; } }

		/// <summary>
		/// Quaternion <i>q2</i> component.
		/// </summary>
		public float Y { get { return (float)_Vector.y; } set { _Vector.y = value; } }

		/// <summary>
		/// Quaternion <i>q3</i> component.
		/// </summary>
		public float Z { get { return (float)_Vector.z; } set { _Vector.z = value; } }

		/// <summary>
		/// Quaternion <i>q4</i> component.
		/// </summary>
		public float W { get { return (float)_CosAngle; } set { _CosAngle = value; } }

		/// <summary>
		/// Compute this Quaternion magnitude.
		/// </summary>
		public double Magnitude
		{
			get {
				double x2 = _Vector.x * _Vector.x;
				double y2 = _Vector.y * _Vector.y;
				double z2 = _Vector.z * _Vector.z;
				double w2 = _CosAngle * _CosAngle;

				return Math.Sqrt(x2 + y2 + z2 + w2);
			}
		}

		/// <summary>
		/// Determine whether this quaternion is identity (no rotation).
		/// </summary>
		public bool IsIdentity
		{
			get
			{
				if (Math.Abs(_Vector.Module()) >= float.Epsilon)
					return false;
				if (Math.Abs(_CosAngle - 1.0f) >= float.Epsilon)
					return false;

				return true;
			}
		}

		/// <summary>
		/// Determine whether this quaternion is normalized.
		/// </summary>
		public bool IsNormalized
		{
			get { return Math.Abs(Magnitude - 1.0) < float.Epsilon; }
		}

		#endregion

		#region Quaternion Operations

		/// <summary>
		/// Normalize this Quaternion.
		/// </summary>
		public void Normalize()
		{
			double magnitude = Magnitude;

			if (magnitude >= float.Epsilon) {
				double scale = 1.0 / magnitude;

				_Vector *= scale;
				_CosAngle *= scale;	
			} else
				throw new InvalidOperationException("zero magnitude quaternion");
		}

		/// <summary>
		/// Conjugate this Quaternion.
		/// </summary>
		public void Conjugate()
		{
			_Vector = -_Vector;
		}

		/// <summary>
		/// Get the conjugate of this Quaternion.
		/// </summary>
		public Quaternion Conjugated
		{
			get
			{
				Quaternion conjugate = new Quaternion(this);

				conjugate._Vector = -conjugate._Vector;

				return conjugate;
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
			
			double x1 = q1._Vector.x, y1 = q1._Vector.y, z1 = q1._Vector.z, w1 = q1._CosAngle;
			double x2 = q2._Vector.x, y2 = q2._Vector.y, z2 = q2._Vector.z, w2 = q2._CosAngle;

			double _q1 = w1*x2 + x1*w2 + y1*z2 - z1*y2;
			double _q2 = w1*y2 + y1*w2 + x1*z2 - z1*x2;
			double _q3 = w1*z2 + z1*w2 + x1*y2 - y1*x2;
			double _q4 = w1*w2 - x1*x2 - y1*y2 - z1*z2;

			return new Quaternion(_q1, _q2, _q3, _q4);
		}

		/// <summary>
		/// Rotates a vector.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> rotating on <paramref name="q"/>.
		/// </param>
		/// <returns>
		/// The rotated <see cref="Vertex3f"/>.
		/// </returns>
		public static Vertex3f operator *(Quaternion q, Vertex3f v)
		{
			return (Matrix3x3f)q * v;
		}

		/// <summary>
		/// Rotates a vector.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> rotating on <paramref name="q"/>.
		/// </param>
		/// <returns>
		/// The rotated <see cref="Vertex3d"/>.
		/// </returns>
		public static Vertex3d operator *(Quaternion q, Vertex3d v)
		{
			return (Matrix3x3d)q * v;
		}

		/// <summary>
		/// Rotates a vector.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> rotating on <paramref name="q"/>.
		/// </param>
		/// <returns>
		/// The rotated <see cref="Vertex3f"/>.
		/// </returns>
		public static Vertex4f operator *(Quaternion q, Vertex4f v)
		{
			return (Matrix4x4f)q * v;
		}

		/// <summary>
		/// Rotates a vector.
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> representing the rotation.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> rotating on <paramref name="q"/>.
		/// </param>
		/// <returns>
		/// The rotated <see cref="Vertex4d"/>.
		/// </returns>
		public static Vertex4d operator *(Quaternion q, Vertex4d v)
		{
			return (Matrix4x4d)q * v;
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix3x3f"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix3x3f"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix3x3f(Quaternion q)
		{
			Matrix3x3f dcm = new Matrix3x3f();		// Direction cosine matrix
			double q1 = q._Vector.x, q2 = q._Vector.y, q3 = q._Vector.z, q4 = q._CosAngle;
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

			return dcm;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix3x3d"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix3x3d"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix3x3d(Quaternion q)
		{
			Matrix3x3d dcm = new Matrix3x3d();		// Direction cosine matrix
			double q1 = q._Vector.x, q2 = q._Vector.y, q3 = q._Vector.z, q4 = q._CosAngle;
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

			return dcm;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4f"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix4x4f"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix4x4f(Quaternion q)
		{
			Matrix4x4f dcm = new Matrix4x4f();		// Direction cosine matrix
			double q1 = q._Vector.x, q2 = q._Vector.y, q3 = q._Vector.z, q4 = q._CosAngle;
			double q1__2 = q1*q1, q2__2 = q2*q2, q3__2 = q3*q3;
			
			dcm[0,0] = (float)(1.0f -  2.0f * (q2__2 + q3__2));
			dcm[1,0] = (float)(		   2.0f * (q1*q2 - q3*q4));
			dcm[2,0] = (float)(		   2.0f * (q1*q3 + q2*q4));
			dcm[3,0] = 0.0f;

			dcm[0,1] = (float)(		   2.0f * (q1*q2 + q3*q4));
			dcm[1,1] = (float)(1.0f -  2.0f * (q1__2 + q3__2));
			dcm[2,1] = (float)(		   2.0f * (q2*q3 - q1*q4));
			dcm[3,1] = 0.0f;

			dcm[0,2] = (float)(		   2.0f * (q1*q3 - q2*q4));
			dcm[1,2] = (float)(		   2.0f * (q1*q4 + q2*q3));
			dcm[2,2] = (float)( 1.0f - 2.0f * (q1__2 + q2__2));
			dcm[3,2] = 0.0f;

			dcm[0,3] = 0.0f;
			dcm[1,3] = 0.0f;
			dcm[2,3] = 0.0f;
			dcm[3,3] = 1.0f;

			return dcm;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="q">
		/// A <see cref="Quaternion"/> to be casted to <see cref="Matrix4x4d"/>.
		/// </param>
		/// <returns>
		/// It returns <see cref="Matrix4x4d"/> representing the equivalent rotation matrix.
		/// </returns>
		public static explicit operator Matrix4x4d(Quaternion q)
		{
			Matrix4x4d dcm = new Matrix4x4d();		// Direction cosine matrix
			double q1 = q._Vector.x, q2 = q._Vector.y, q3 = q._Vector.z, q4 = q._CosAngle;
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

			return dcm;
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
		/// Returns a <see cref="string"/> that represents this Quaternion.
		/// </returns>
		public override string ToString()
		{
			return $"Axis: {RotationVector} Angle: {RotationAngle}";
		}

		#endregion
	}
}