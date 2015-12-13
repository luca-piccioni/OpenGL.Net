
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
	/// The types available in a ShaderPrograms.
	/// </summary>
	public enum ShaderUniformType
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = 0,

		#region Single-Precision Floating-Point Types

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

		#endregion

		#region Double Precision Floating-Point Types

		/// <summary>
		/// A single double-precision floating-point value.
		/// </summary>
		Double = Gl.DOUBLE,
		/// <summary>
		/// A vector of two double-precision floating-point values.
		/// </summary>
		DoubleVec2 = Gl.DOUBLE_VEC2,
		/// <summary>
		/// A vector of three double-precision floating-point values.
		/// </summary>
		DoubleVec3 = Gl.DOUBLE_VEC3,
		/// <summary>
		/// A vector of four double-precision floating-point values.
		/// </summary>
		DoubleVec4 = Gl.DOUBLE_VEC4,

		#endregion

		#region Signed Integer Types

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

		#endregion

		#region Unsigned Integer Types

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

		#endregion

		#region Boolean Types

		/// <summary>
		/// A single boolean value.
		/// </summary>
		Bool = Gl.BOOL,
		/// <summary>
		/// A vector of two boolean values.
		/// </summary>
		BoolVec2 = Gl.BOOL_VEC2,
		/// <summary>
		/// A vector of three boolean values.
		/// </summary>
		BoolVec3 = Gl.BOOL_VEC3,
		/// <summary>
		/// A vector of four boolean values.
		/// </summary>
		BoolVec4 = Gl.BOOL_VEC4,

		#endregion

		#region Square Single-Precision Floating-Point Matrix Types

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

		#endregion

		#region Non-Square Single-Precision Floating-Point Matrix Types

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

		#endregion

		#region Square Double-Precision Floating-Point Matrix Types

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

		#endregion

		#region Non-Square Double-Precision Floating-Point Matrix Types

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
		/// A matrix of four rows and two columns of double-precision floating-point values.
		/// </summary>
		DoubleMat4x2 = Gl.DOUBLE_MAT4x2,
		/// <summary>
		/// A matrix of four rows and three columns of double-precision floating-point values.
		/// </summary>
		DoubleMat4x3 = Gl.DOUBLE_MAT4x3,

		#endregion

		#region Floating-Point (Normalized) Texture Samplers

		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		Sampler1D = Gl.SAMPLER_1D,
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		Sampler2D = Gl.SAMPLER_2D,
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		Sampler2DRect = Gl.SAMPLER_2D_RECT,
		/// <summary>
		/// Texture 3D sampler.
		/// </summary>
		Sampler3D = Gl.SAMPLER_3D,
		/// <summary>
		/// Texture cube sampler.
		/// </summary>
		SamplerCube = Gl.SAMPLER_CUBE,

		#endregion

		#region Shadow Texture Samplers

		/// <summary>
		/// Depth texture 1D sampler.
		/// </summary>
		Sampler1DShadow = Gl.SAMPLER_1D_SHADOW,
		/// <summary>
		/// Depth texture 2D sampler.
		/// </summary>
		Sampler2DShadow = Gl.SAMPLER_2D_SHADOW,
		/// <summary>
		/// Depth texture rectangle sampler.
		/// </summary>
		Sampler2DRectShadow = Gl.SAMPLER_2D_RECT_SHADOW,
		/// <summary>
		/// Depth texture cube sampler.
		/// </summary>
		SamplerCubeShadow = Gl.SAMPLER_CUBE_SHADOW,

		#endregion

		#region Texture Array Samplers

		/// <summary>
		/// Texture 1D array sampler.
		/// </summary>
		Sampler1DArray = Gl.SAMPLER_1D_ARRAY,
		/// <summary>
		/// Texture 2D array sampler.
		/// </summary>
		Sampler2DArray = Gl.SAMPLER_2D_ARRAY,

		#endregion

		#region Shadow Texture Array Samplers

		/// <summary>
		/// Depth texture 1D array sampler.
		/// </summary>
		Sampler1DArrayShadow = Gl.SAMPLER_1D_ARRAY_SHADOW,
		/// <summary>
		/// Depth texture 2D array sampler.
		/// </summary>
		Sampler2DArrayShadow = Gl.SAMPLER_2D_ARRAY_SHADOW,

		#endregion

		#region Multisample Texture Samplers

		/// <summary>
		/// Multisample texture 2D sampler.
		/// </summary>
		Sampler2DMultisample = Gl.SAMPLER_2D_MULTISAMPLE,
		/// <summary>
		/// Multisample texture 2D array sampler.
		/// </summary>
		Sampler2DMultisampleArray = Gl.SAMPLER_2D_MULTISAMPLE_ARRAY,

		#endregion

		#region Texture Buffer Sampler

		/// <summary>
		/// Texture buffer sampler.
		/// </summary>
		SamplerBuffer = Gl.SAMPLER_BUFFER,

		#endregion

		#region Integer Texture Sampler

		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		IntSampler1D = Gl.INT_SAMPLER_1D,
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		IntSampler2D = Gl.INT_SAMPLER_2D,
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		IntSampler2DRect = Gl.INT_SAMPLER_2D_RECT,
		/// <summary>
		/// Texture 3D sampler.
		/// </summary>
		IntSampler3D = Gl.INT_SAMPLER_3D,
		/// <summary>
		/// Texture cube sampler.
		/// </summary>
		IntSamplerCube = Gl.INT_SAMPLER_CUBE,

		#endregion

		#region Integer Texture Array Sampler

		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		IntSampler1DArray = Gl.INT_SAMPLER_1D_ARRAY,
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		IntSampler2DArray = Gl.INT_SAMPLER_2D_ARRAY,

		#endregion

		#region Unsigned Integer Texture Sampler

		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		UIntSampler1D = Gl.UNSIGNED_INT_SAMPLER_1D,
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		UIntSampler2D = Gl.UNSIGNED_INT_SAMPLER_2D,
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		UIntSampler2DRect = Gl.UNSIGNED_INT_SAMPLER_2D_RECT,
		/// <summary>
		/// Texture 3D sampler.
		/// </summary>
		UIntSampler3D = Gl.UNSIGNED_INT_SAMPLER_3D,
		/// <summary>
		/// Texture cube sampler.
		/// </summary>
		UIntSamplerCube = Gl.UNSIGNED_INT_SAMPLER_CUBE,

		#endregion
	}
}
