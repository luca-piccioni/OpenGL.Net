
// Copyright (C) 2011-2012 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace OpenGL
{
	/// <summary>
	/// An enumeration listing all supported types of a shader attribute.
	/// </summary>
	public enum ShaderAttributeType
	{
		/// <summary>
		/// A single single-precision floating-point value.
		/// </summary>
		Float = Gl.FLOAT,
		/// <summary>
		/// A vector of two single-precision floating-point values.
		/// </summary>
		Vec2 = Gl.FLOAT_VEC2,
		/// <summary>
		/// A vector of three single-precision floating-point values.
		/// </summary>
		Vec3 = Gl.FLOAT_VEC3,
		/// <summary>
		/// A vector of four single-precision floating-point values.
		/// </summary>
		Vec4 = Gl.FLOAT_VEC4,
		/// <summary>
		/// A matrix of two rows and two columns of single-precision floating-point values.
		/// </summary>
		Mat2x2 = Gl.FLOAT_MAT2,
		/// <summary>
		/// A matrix of three rows and three columns of single-precision floating-point values.
		/// </summary>
		Mat3x3 = Gl.FLOAT_MAT3,
		/// <summary>
		/// A matrix of four rows and four columns of single-precision floating-point values.
		/// </summary>
		Mat4x4 = Gl.FLOAT_MAT4,
		/// <summary>
		/// A matrix of three rows and two columns of single-precision floating-point values.
		/// </summary>
		Mat2x3 = Gl.FLOAT_MAT2x3,
		/// <summary>
		/// A matrix of four rows and two columns of single-precision floating-point values.
		/// </summary>
		Mat2x4 = Gl.FLOAT_MAT2x4,
		/// <summary>
		/// A matrix of two rows and three columns of single-precision floating-point values.
		/// </summary>
		Mat3x2 = Gl.FLOAT_MAT3x2,
		/// <summary>
		/// A matrix of four rows and three columns of single-precision floating-point values.
		/// </summary>
		Mat3x4 = Gl.FLOAT_MAT3x4,
		/// <summary>
		/// A matrix of four rows and two columns of single-precision floating-point values.
		/// </summary>
		Mat4x2 = Gl.FLOAT_MAT4x2,
		/// <summary>
		/// A matrix of four rows and three columns of single-precision floating-point values.
		/// </summary>
		Mat4x3 = Gl.FLOAT_MAT4x3,
		/// <summary>
		/// A single signed integer value.
		/// </summary>
		Int = Gl.INT,
		/// <summary>
		/// A vector of two signed integer values.
		/// </summary>
		IntVec2 = Gl.INT_VEC2,
		/// <summary>
		/// A vector of three signed integer values.
		/// </summary>
		IntVec3 = Gl.INT_VEC3,
		/// <summary>
		/// A vector of four signed integer values.
		/// </summary>
		IntVec4 = Gl.INT_VEC4,
		/// <summary>
		/// A single unsigned integer value.
		/// </summary>
		UInt = Gl.UNSIGNED_INT,
		/// <summary>
		/// A vector of two unsigned integer values.
		/// </summary>
		UIntVec2 = Gl.UNSIGNED_INT_VEC2,
		/// <summary>
		/// A vector of three unsigned integer values.
		/// </summary>
		UIntVec3 = Gl.UNSIGNED_INT_VEC3,
		/// <summary>
		/// A vector of four unsigned integer values.
		/// </summary>
		UIntVec4 = Gl.UNSIGNED_INT_VEC4,
		/// <summary>
		/// A single double-precision floating-point value.
		/// </summary>
		Double = Gl.DOUBLE,
		/// <summary>
		/// A vector of two double-precision floating-point value.
		/// </summary>
		DoubleVec2 = Gl.DOUBLE_VEC2,
		/// <summary>
		/// A vector of three double-precision floating-point value.
		/// </summary>
		DoubleVec3 = Gl.DOUBLE_VEC3,
		/// <summary>
		/// A vector of four double-precision floating-point value.
		/// </summary>
		DoubleVec4 = Gl.DOUBLE_VEC4,
		/// <summary>
		/// A matrix of two rows and two columns of double-precision floating-point values.
		/// </summary>
		DoubleMat2x2 = Gl.DOUBLE_MAT2,
		/// <summary>
		/// A matrix of three rows and three columns of double-precision floating-point values.
		/// </summary>
		DoubleMat3x3 = Gl.DOUBLE_MAT3,
		/// <summary>
		/// A matrix of four rows and four columns of double-precision floating-point values.
		/// </summary>
		DoubleMat4x4 = Gl.DOUBLE_MAT4,
		/// <summary>
		/// A matrix of three rows and two columns of double-precision floating-point values.
		/// </summary>
		DoubleMat2x3 = Gl.DOUBLE_MAT2x3,
		/// <summary>
		/// A matrix of four rows and two columns of double-precision floating-point values.
		/// </summary>
		DoubleMat2x4 = Gl.DOUBLE_MAT2x4,
		/// <summary>
		/// A matrix of two rows and three columns of double-precision floating-point values.
		/// </summary>
		DoubleMat3x2 = Gl.DOUBLE_MAT3x2,
		/// <summary>
		/// A matrix of four rows and three columns of double-precision floating-point values.
		/// </summary>
		DoubleMat3x4 = Gl.DOUBLE_MAT3x4,
		/// <summary>
		/// A matrix of two rows and four columns of double-precision floating-point values.
		/// </summary>
		DoubleMat4x2 = Gl.DOUBLE_MAT4x2,
		/// <summary>
		/// A matrix of three rows and four columns of double-precision floating-point values.
		/// </summary>
		DoubleMat4x3 = Gl.DOUBLE_MAT4x3,
	}
}