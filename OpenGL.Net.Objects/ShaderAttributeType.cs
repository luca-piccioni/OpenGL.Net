
// Copyright (C) 2011-2017 Luca Piccioni
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

namespace OpenGL.Objects
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

#if !MONODROID
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

#endif
	}

	/// <summary>
	/// Extension methods for <see cref="ShaderAttributeType"/> enumeration.
	/// </summary>
	public static class ShaderAttributeTypeExtensions
	{
		#region Base Type

		/// <summary>
		/// Get the array components base type of the vertex array buffer item.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		public static VertexBaseType GetVertexBaseType(this ShaderAttributeType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ShaderAttributeType.Float:
				case ShaderAttributeType.Vec2:
				case ShaderAttributeType.Vec3:
				case ShaderAttributeType.Vec4:
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat2x4:
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat3x4:
				case ShaderAttributeType.Mat4x2:
				case ShaderAttributeType.Mat4x3:
				case ShaderAttributeType.Mat4x4:
					return (VertexBaseType.Float);
#if !MONODROID
				case ShaderAttributeType.Double:
				case ShaderAttributeType.DoubleVec2:
				case ShaderAttributeType.DoubleVec3:
				case ShaderAttributeType.DoubleVec4:
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat2x4:
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat3x4:
				case ShaderAttributeType.DoubleMat4x2:
				case ShaderAttributeType.DoubleMat4x3:
				case ShaderAttributeType.DoubleMat4x4:
					return (VertexBaseType.Double);
#endif
				case ShaderAttributeType.Int:
				case ShaderAttributeType.IntVec2:
				case ShaderAttributeType.IntVec3:
				case ShaderAttributeType.IntVec4:
					return (VertexBaseType.Int);
				case ShaderAttributeType.UInt:
				case ShaderAttributeType.UIntVec2:
				case ShaderAttributeType.UIntVec3:
				case ShaderAttributeType.UIntVec4:
					return (VertexBaseType.UInt);
				default:
					throw new NotSupportedException("unsupported vertex array base type of " + vertexArrayType);
			}
		}

		#endregion

		#region Length & Rank

		/// <summary>
		/// Get the number of components of the vertex array buffer item.
		/// </summary>
		/// <param name="shaderAttributeType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the count of the components of the vertex array buffer item. It will be a value
		/// from 1 (inclusive) to 4 (inclusive). For matrices, this value indicates the matrix height (column-major order).
		/// </returns>
		public static uint GetArrayLength(this ShaderAttributeType shaderAttributeType)
		{
			switch (shaderAttributeType) {
				case ShaderAttributeType.Float:
#if !MONODROID
				case ShaderAttributeType.Double:
#endif
				case ShaderAttributeType.Int:
				case ShaderAttributeType.UInt:
					return (1);
				case ShaderAttributeType.Vec2:
#if !MONODROID
				case ShaderAttributeType.DoubleVec2:
#endif
				case ShaderAttributeType.IntVec2:
				case ShaderAttributeType.UIntVec2:
					return (2);
				case ShaderAttributeType.Vec3:
#if !MONODROID
				case ShaderAttributeType.DoubleVec3:
#endif
				case ShaderAttributeType.IntVec3:
				case ShaderAttributeType.UIntVec3:
					return (3);
				case ShaderAttributeType.Vec4:
#if !MONODROID
				case ShaderAttributeType.DoubleVec4:
#endif
				case ShaderAttributeType.IntVec4:
				case ShaderAttributeType.UIntVec4:
					return (4);
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat2x4:
#if !MONODROID
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat2x4:
#endif
					return (2);
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat3x4:
#if !MONODROID
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat3x4:
#endif
					return (3);
				case ShaderAttributeType.Mat4x2:
				case ShaderAttributeType.Mat4x3:
				case ShaderAttributeType.Mat4x4:
#if !MONODROID
				case ShaderAttributeType.DoubleMat4x2:
				case ShaderAttributeType.DoubleMat4x3:
				case ShaderAttributeType.DoubleMat4x4:
#endif
					return (4);
				default:
					throw new NotSupportedException("unsupported vertex array length of " + shaderAttributeType);
			}
		}

		/// <summary>
		/// Get the rank of the vertex array buffer item (that is, the number of <i>vec4</i> attributes requires).
		/// </summary>
		/// <param name="shaderAttributeType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns the rank of the vertex array buffer item. It will be a value
		/// from 1 (inclusive) to 4 (inclusive). For matrices, this value indicates the matrix width (column-major order),
		/// while for simpler types the value will be 1.
		/// </returns>
		public static uint GetArrayRank(this ShaderAttributeType shaderAttributeType)
		{
			switch (shaderAttributeType) {
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat4x2:
#if !MONODROID
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat4x2:
#endif
					return (2);
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat4x3:
#if !MONODROID
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat4x3:
#endif
					return (3);
				case ShaderAttributeType.Mat2x4:
				case ShaderAttributeType.Mat3x4:
				case ShaderAttributeType.Mat4x4:
#if !MONODROID
				case ShaderAttributeType.DoubleMat2x4:
				case ShaderAttributeType.DoubleMat3x4:
				case ShaderAttributeType.DoubleMat4x4:
#endif
					return (4);
				case ShaderAttributeType.Float:
#if !MONODROID
				case ShaderAttributeType.Double:
#endif
				case ShaderAttributeType.Int:
				case ShaderAttributeType.UInt:
				case ShaderAttributeType.Vec2:
#if !MONODROID
				case ShaderAttributeType.DoubleVec2:
#endif
				case ShaderAttributeType.IntVec2:
				case ShaderAttributeType.UIntVec2:
				case ShaderAttributeType.Vec3:
#if !MONODROID
				case ShaderAttributeType.DoubleVec3:
#endif
				case ShaderAttributeType.IntVec3:
				case ShaderAttributeType.UIntVec3:
				case ShaderAttributeType.Vec4:
#if !MONODROID
				case ShaderAttributeType.DoubleVec4:
#endif
				case ShaderAttributeType.IntVec4:
				case ShaderAttributeType.UIntVec4:
					return (1);
				default:
					throw new NotSupportedException("unsupported vertex array rank of " + shaderAttributeType);
			}
		}

		/// <summary>
		/// Get whether a <see cref="ShaderAttributeType"/> is a simple type (float, int, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a simple type.
		/// </returns>
		public static bool IsArraySimpleType(this ShaderAttributeType vertexArrayType)
		{
			return ((vertexArrayType.GetArrayLength() == 1) && (vertexArrayType.GetArrayRank() == 1));
		}

		/// <summary>
		/// Get whether a <see cref="ShaderAttributeType"/> is a vector type (vec2, vec3, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a vector type.
		/// </returns>
		public static bool IsArrayVectorType(this ShaderAttributeType vertexArrayType)
		{
			return ((vertexArrayType.GetArrayLength() > 1) && (vertexArrayType.GetArrayRank() == 1));
		}

		/// <summary>
		/// Get whether a <see cref="ShaderAttributeType"/> is a matrix type (mat2, mat4, ...).
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a matrix type.
		/// </returns>
		public static bool IsArrayMatrixType(this ShaderAttributeType vertexArrayType)
		{
			return (GetArrayRank(vertexArrayType) > 1);
		}

		/// <summary>
		/// Get the correponding type for the column of the matrix type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ShaderAttributeType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="vertexArrayType"/> is a matrix type.
		/// </returns>
		public static ShaderAttributeType GetMatrixColumnType(this ShaderAttributeType vertexArrayType)
		{
			switch (vertexArrayType) {
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat2x4:
					return ShaderAttributeType.Vec2;
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat3x4:
					return ShaderAttributeType.Vec3;
				case ShaderAttributeType.Mat4x2:
				case ShaderAttributeType.Mat4x3:
				case ShaderAttributeType.Mat4x4:
					return ShaderAttributeType.Vec4;
#if !MONODROID
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat2x4:
					return ShaderAttributeType.DoubleVec2;
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat3x4:
					return ShaderAttributeType.DoubleVec3;
				case ShaderAttributeType.DoubleMat4x2:
				case ShaderAttributeType.DoubleMat4x3:
				case ShaderAttributeType.DoubleMat4x4:
					return ShaderAttributeType.DoubleVec4;
#endif
				default:
					throw new ArgumentException();
			}
		}

		#endregion
	}
}