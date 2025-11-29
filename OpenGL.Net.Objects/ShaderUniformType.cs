
// Copyright (C) 2011-2015 Luca Piccioni
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

namespace OpenGL.Objects
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

#if !MONODROID

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

#endif

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

#if !MONODROID

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

#endif

		#region Floating-Point (Normalized) Texture Samplers

#if !MONODROID
		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		Sampler1D = Gl.SAMPLER_1D,
#endif
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		Sampler2D = Gl.SAMPLER_2D,
#if !MONODROID
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		Sampler2DRect = Gl.SAMPLER_2D_RECT,
#endif
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

#if !MONODROID
		/// <summary>
		/// Depth texture 1D sampler.
		/// </summary>
		Sampler1DShadow = Gl.SAMPLER_1D_SHADOW,
#endif
		/// <summary>
		/// Depth texture 2D sampler.
		/// </summary>
		Sampler2DShadow = Gl.SAMPLER_2D_SHADOW,
#if !MONODROID
		/// <summary>
		/// Depth texture rectangle sampler.
		/// </summary>
		Sampler2DRectShadow = Gl.SAMPLER_2D_RECT_SHADOW,
#endif
		/// <summary>
		/// Depth texture cube sampler.
		/// </summary>
		SamplerCubeShadow = Gl.SAMPLER_CUBE_SHADOW,

		#endregion

#if !MONODROID

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

#endif

		#region Shadow Texture Array Samplers

#if !MONODROID
		/// <summary>
		/// Depth texture 1D array sampler.
		/// </summary>
		Sampler1DArrayShadow = Gl.SAMPLER_1D_ARRAY_SHADOW,
#endif
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

#if !MONODROID
		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		IntSampler1D = Gl.INT_SAMPLER_1D,
#endif
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		IntSampler2D = Gl.INT_SAMPLER_2D,
#if !MONODROID
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		IntSampler2DRect = Gl.INT_SAMPLER_2D_RECT,
#endif
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

#if !MONODROID
		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		IntSampler1DArray = Gl.INT_SAMPLER_1D_ARRAY,
#endif
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		IntSampler2DArray = Gl.INT_SAMPLER_2D_ARRAY,

		#endregion

		#region Unsigned Integer Texture Sampler

#if !MONODROID
		/// <summary>
		/// Texture 1D sampler.
		/// </summary>
		UIntSampler1D = Gl.UNSIGNED_INT_SAMPLER_1D,
#endif
		/// <summary>
		/// Texture 2D sampler.
		/// </summary>
		UIntSampler2D = Gl.UNSIGNED_INT_SAMPLER_2D,
#if !MONODROID
		/// <summary>
		/// Texture rectangle sampler.
		/// </summary>
		UIntSampler2DRect = Gl.UNSIGNED_INT_SAMPLER_2D_RECT,
#endif
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
