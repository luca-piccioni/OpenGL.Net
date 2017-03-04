
// Copyright (C) 2010-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	public partial class UniformBufferObject
	{
		#region Set Uniform (single-precision floating-point vector data)

		/// <summary>
		/// Set uniform state variable (floating-point variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, float v)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			Set(v, (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (vec2 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Vertex2f v)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			Set(v, (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (vec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Vertex3f v)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			Set(v, (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Vertex4f v)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			Set(v, (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (array of vec2 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single[]"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, float[] v)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			// uniform.CheckType(Gl.FLOAT, Gl.BOOL);

			ulong offset = (ulong)uniform.Offset;

			for (int i = 0; i < v.Length; i++, offset = (ulong)uniform.ArrayStride)
				Set(v[i], offset);
		}

		#endregion

		#region Set/Get Uniform (single-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (mat* variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Matrix m)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			Set(m.ToArray(), (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Matrix3x3 m)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_MAT3);

			Set(m.ToArray(), (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Matrix3x3f m)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_MAT3);

			Set(m, (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (mat4 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Matrix4x4 m)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_MAT4);

			Set(m.ToArray(), (ulong)uniform.Offset);
		}

		/// <summary>
		/// Set uniform state variable (mat4 variable).
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(string uniformName, Matrix4x4f m)
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			uniform.CheckType(Gl.FLOAT_MAT4);

			Set(m, (ulong)uniform.Offset);
		}

		#endregion

		#region Set Uniform (generic structured data)

		public void SetUniform<T>(string uniformName, T v) where T : struct
		{
			UniformSegment uniform = GetUniform(uniformName);
			if (uniform == null)
				return;

			// uniform.CheckType(Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			Set(v, (ulong)uniform.Offset);
		}

		#endregion

		#region IShaderUniformContainer Implementation
		
		bool IShaderUniformContainer.IsActiveUniform(string uniformName)
		{
			return (_UniformSegments.ContainsKey(uniformName));
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, float v)
		{
			SetUniform(uniformName, v);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex2f v)
		{
			SetUniform(uniformName, v);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex3f v)
		{
			SetUniform(uniformName, v);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex4f v)
		{
			SetUniform(uniformName, v);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, float[] v)
		{
			SetUniform(uniformName, v);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex2f[] v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex3f[] v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex4f[] v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF[] v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, int v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex2i v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex3i v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex4i v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, uint v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex2ui v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex3ui v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex4ui v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, bool v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z, bool w)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Matrix m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3 m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3f m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4 m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4f m)
		{
			SetUniform(uniformName, m);
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Texture texture)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, double v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex2d v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex3d v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, Vertex4d v)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble3x3 m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble4x4 m)
		{
			throw new NotImplementedException();
		}

		void IShaderUniformContainer.SetUniform(GraphicsContext ctx, string uniformName, object value)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (value == null)
				throw new ArgumentNullException("value");

			Type valueType = value.GetType();

			Matrix valueMatrix = value as Matrix;
			if (valueMatrix != null) {
				Matrix4x4 matrix4x4 = value as Matrix4x4;
				if (matrix4x4 != null) {
					SetUniform(uniformName, matrix4x4);
					return;
				}

				Matrix3x3 matrix3x3 = value as Matrix3x3;
				if (matrix3x3 != null) {
					SetUniform(uniformName, matrix3x3);
					return;
				}

				throw new NotSupportedException(valueType + "is not supported by SetUniform(GraphicsContext, string, object");
			} else if (valueType == typeof(Vertex2f)) {
				SetUniform(uniformName, (Vertex2f)value);
			} else if (valueType == typeof(Vertex3f)) {
				SetUniform(uniformName, (Vertex3f)value);
			} else if (valueType == typeof(Vertex4f)) {
				SetUniform(uniformName, (Vertex4f)value);
			} else if (valueType == typeof(Vertex2i)) {
				SetUniform(uniformName, (Vertex2i)value);
			} else if (valueType == typeof(Vertex3i)) {
				SetUniform(uniformName, (Vertex3i)value);
			} else if (valueType == typeof(Vertex4i)) {
				SetUniform(uniformName, (Vertex4i)value);
			} else if (valueType == typeof(int)) {
				SetUniform(uniformName, (int)value);
			} else if (valueType == typeof(float)) {
				SetUniform(uniformName, (float)value);
			} else if (valueType == typeof(ColorRGBAF)) {
				SetUniform(uniformName, (ColorRGBAF)value);
			} else
				throw new NotSupportedException(valueType + "is not supported by SetUniform(GraphicsContext, string, object");
		}

		#endregion
	}
}
