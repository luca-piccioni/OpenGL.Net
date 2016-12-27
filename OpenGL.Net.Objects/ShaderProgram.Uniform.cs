
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Shader Program Uniforms

		#region Set Uniform (generic object)

		/// <summary>
		/// Set uniform state variable (any known object type).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="value">
		/// A <see cref="Object"/> holding the uniform variabile data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="uniformName"/> is null.
		/// </exception>
		public void SetUniform(GraphicsContext ctx, string uniformName, object value)
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
					SetUniform(ctx, uniformName, matrix4x4);
					return;
				}

				Matrix3x3 matrix3x3 = value as Matrix3x3;
				if (matrix3x3 != null) {
					SetUniform(ctx, uniformName, matrix3x3);
					return;
				}

				throw new NotSupportedException();
			} else if (valueType == typeof(Vertex2f)) {
				SetUniform(ctx, uniformName, (Vertex2f)value);
				return;
			} else if (valueType == typeof(Vertex3f)) {
				SetUniform(ctx, uniformName, (Vertex3f)value);
				return;
			} else if (valueType == typeof(Vertex4f)) {
				SetUniform(ctx, uniformName, (Vertex4f)value);
				return;
			} else if (valueType == typeof(Vertex2i)) {
				SetUniform(ctx, uniformName, (Vertex2i)value);
				return;
			} else if (valueType == typeof(Vertex3i)) {
				SetUniform(ctx, uniformName, (Vertex3i)value);
				return;
			} else if (valueType == typeof(Vertex4i)) {
				SetUniform(ctx, uniformName, (Vertex4i)value);
				return;
			} else if (valueType == typeof(int)) {
				SetUniform(ctx, uniformName, (int)value);
				return;
			} else if (valueType == typeof(float)) {
				SetUniform(ctx, uniformName, (float)value);
				return;
			} else if (valueType == typeof(ColorRGBAF)) {
				SetUniform(ctx, uniformName, (ColorRGBAF)value);
				return;
			} else if (valueType == typeof(Texture2d)) {
				SetUniform(ctx, uniformName, (Texture2d)value);
				return;
			} else if (valueType == typeof(TextureCube)) {
				SetUniform(ctx, uniformName, (TextureCube)value);
				return;
			} else
				throw new NotSupportedException();

			MethodInfo setUniformMethod;

			if (_SetUniformMethods.TryGetValue(value.GetType(), out setUniformMethod) == false) {
				setUniformMethod = typeof(ShaderProgram).GetMethod("SetUniform", new Type[] { typeof(GraphicsContext), typeof(string), value.GetType() });
				_SetUniformMethods[value.GetType()] = setUniformMethod;
			}

			if (setUniformMethod != null) {
				// Avoid stack overflow
				if (setUniformMethod.GetParameters()[2].ParameterType == typeof(object))
					throw new NotSupportedException(value.GetType() + " is not supported");

				try {
					setUniformMethod.Invoke(this, new object[] { ctx, uniformName, value });
				} catch (TargetInvocationException targetInvocationException) {
					throw targetInvocationException.InnerException;
				}
			} else
				throw new NotSupportedException(value.GetType() + " is not supported");
		}

		/// <summary>
		/// Methods used for setting uniform values.
		/// </summary>
		private static readonly Dictionary<Type, MethodInfo> _SetUniformMethods = new Dictionary<Type, MethodInfo>();

		/// <summary>
		/// Methods used for getting uniform values.
		/// </summary>
		private static readonly Dictionary<Type, MethodInfo> _GetUniformMethods = new Dictionary<Type, MethodInfo>();

		#endregion

		#region Set/Get Uniform (single-precision floating point vector data)

		/// <summary>
		/// Set uniform state variable (floating-point variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, float v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			// Set uniform value
			Gl.Uniform1(uniform.Location, v);
		}

		/// <summary>
		/// Set uniform state variable (vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, float x, float y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			// Set uniform value
			Gl.Uniform2(uniform.Location, x, y);
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
		/// <param name="x">
		/// A <see cref="Single"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the uniform variabile data (third component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, float x, float y, float z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			// Set uniform value
			Gl.Uniform3(uniform.Location, x, y, z);
		}

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/> holding the uniform variabile data (fourth component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, float x, float y, float z, float w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			// Set uniform value
			Gl.Uniform4(uniform.Location, x, y, z, w);
		}

		/// <summary>
		/// Set uniform state variable (vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex2f v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			unsafe {
				Gl.Uniform2(uniform.Location, 1, (float*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (array of vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex2f[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			unsafe {
				fixed (Vertex2f* p_v = v) {
					Gl.Uniform2(uniform.Location, v.Length, (float*)p_v);
				}
			}
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
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3f v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			unsafe
			{
				Gl.Uniform3(uniform.Location, 1, (float*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (array of vec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f[]"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3f[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			unsafe
			{
				fixed (Vertex3f* p_v = v) {
					Gl.Uniform3(uniform.Location, v.Length, (float*)p_v);
				}
			}
		}

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex4f v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			unsafe
			{
				Gl.Uniform4(uniform.Location, 1, (float*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (array of vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex4f[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			unsafe
			{
				fixed (Vertex4f* p_v = v) {
					Gl.Uniform4(uniform.Location, v.Length, (float*)p_v);
				}
			}
		}

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="ColorRGBAF"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			unsafe {
				Gl.Uniform4(uniform.Location, 1, (float*)&v);
			}
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
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3 v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			SetUniform(ctx, uniformName, v.X, v.Y, v.Z);
		}

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="ColorRGBAF"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, ColorRGBA v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			SetUniform(ctx, uniformName, v.Red, v.Green, v.Blue, v.Alpha);
		}

		/// <summary>
		/// Get uniform value (float variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			float[] value = new float[1];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (vec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			float[] value = new float[2];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (vec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y, out float z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			float[] value = new float[3];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (vec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y, out float z, out float w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			float[] value = new float[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Set/Get Uniform (double-precision floating-point vector data)

		/// <summary>
		/// Set uniform state variable (double variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Double"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, double v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE);

			// Set uniform value
			Gl.Uniform1(uniform.Location, v);
		}

		/// <summary>
		/// Set uniform state variable (dvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, double x, double y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC2);

			// Set uniform value
			Gl.Uniform2(uniform.Location, x, y);
		}

		/// <summary>
		/// Set uniform state variable (dvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the uniform variabile data (third component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, double x, double y, double z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC3);

			// Set uniform value
			Gl.Uniform3(uniform.Location, x, y, z);
		}

		/// <summary>
		/// Set uniform state variable (dvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Double"/> holding the uniform variabile data (fourth component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, double x, double y, double z, double w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC4);

			// Set uniform value
			Gl.Uniform4(uniform.Location, x, y, z, w);
		}

		/// <summary>
		/// Set uniform state variable (dvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex2d v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC2);

			unsafe {
				Gl.Uniform2(uniform.Location, 1, (double*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (dvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3d v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC3);

			unsafe {
				Gl.Uniform3(uniform.Location, 1, (double*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (dvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex4d v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC4);

			unsafe
			{
				Gl.Uniform4(uniform.Location, 1, (double*)&v);
			}
		}

		/// <summary>
		/// Get uniform value (double variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Double"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.DOUBLE);

			double[] value = new double[1];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (dvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.DOUBLE_VEC2);

			double[] value = new double[2];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (dvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y, out double z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.DOUBLE_VEC3);

			double[] value = new double[3];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (dvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Double"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y, out double z, out double w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.DOUBLE_VEC4);

			double[] value = new double[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Set/Get Uniform (integer vector variant)

		/// <summary>
		/// Set uniform state variable (int variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Int32"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, int v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT, Gl.BOOL);

			// Set uniform value
			Gl.Uniform1(uniform.Location, v);
		}

		/// <summary>
		/// Set uniform state variable (ivec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, int x, int y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			// Set uniform value
			Gl.Uniform2(uniform.Location, x, y);
		}

		/// <summary>
		/// Set uniform state variable (ivec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the uniform variabile data (third component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, int x, int y, int z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			// Set uniform value
			Gl.Uniform3(uniform.Location, x, y, z);
		}

		/// <summary>
		/// Set uniform state variable (ivec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Int32"/> holding the uniform variabile data (fourth component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, int x, int y, int z, int w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			// Set uniform value
			Gl.Uniform4(uniform.Location, x, y, z, w);
		}

		/// <summary>
		/// Set uniform state variable (ivec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex2i v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			unsafe
			{
				Gl.Uniform2(uniform.Location, 1, (int*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (ivec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3i"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3i v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			unsafe
			{
				Gl.Uniform3(uniform.Location, 1, (int*)&v);
			}
		}

		/// <summary>
		/// Set uniform state variable (ivec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex4i v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			unsafe
			{
				Gl.Uniform4(uniform.Location, 1, (int*)&v);
			}
		}

		/// <summary>
		/// Get uniform value (int variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Int32"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.INT, Gl.BOOL);

			int[] value = new int[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (ivec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			int[] value = new int[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (ivec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y, out int z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			int[] value = new int[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (ivec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y, out int z, out int w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			int[] value = new int[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Set/Get Uniform (unsigned integer vector variant)

		/// <summary>
		/// Set uniform state variable (uint variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="UInt32"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, uint v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT, Gl.BOOL);

			// Set uniform value
			Gl.Uniform1(uniform.Location, v);
		}

		/// <summary>
		/// Set uniform state variable (uvec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, uint x, uint y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC2, Gl.BOOL_VEC2);

			// Set uniform value
			Gl.Uniform2(uniform.Location, x, y);
		}

		/// <summary>
		/// Set uniform state variable (uvec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, uint x, uint y, uint z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC3, Gl.BOOL_VEC3);

			// Set uniform value
			Gl.Uniform3(uniform.Location, x, y, z);
		}

		/// <summary>
		/// Set uniform state variable (uvec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> holding the uniform variabile data (fourth component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, uint x, uint y, uint z, uint w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC4, Gl.BOOL_VEC4);

			// Set uniform value
			Gl.Uniform4(uniform.Location, x, y, z, w);
		}

		/// <summary>
		/// Get uniform value (uint variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.UNSIGNED_INT, Gl.BOOL);

			uint[] value = new uint[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (uvec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC2, Gl.BOOL_VEC2);

			uint[] value = new uint[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (uvec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y, out uint z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC3, Gl.BOOL_VEC3);

			uint[] value = new uint[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (uvec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y, out uint z, out uint w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC4, Gl.BOOL_VEC4);

			uint[] value = new uint[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Set/Get Uniform (boolean vector data)

		/// <summary>
		/// Set uniform state variable (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Boolean"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, bool v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL);

			// Set uniform value
			Gl.Uniform1(uniform.Location, v ? 1 : 0);
		}

		/// <summary>
		/// Set uniform state variable (bvec2 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC2);

			// Set uniform value
			Gl.Uniform2(uniform.Location, x ? 1 : 0, y ? 1 : 0);
		}

		/// <summary>
		/// Set uniform state variable (bvec3 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC3);

			// Set uniform value
			Gl.Uniform3(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);
		}

		/// <summary>
		/// Set uniform state variable (bvec4 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> holding the uniform variabile data (fourth component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z, bool w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC4);

			// Set uniform value
			Gl.Uniform4(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);
		}

		/// <summary>
		/// Get uniform value (boolean variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.BOOL);

			int[] value = new int[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.BOOL_VEC2);

			int[] value = new int[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y, out bool z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.BOOL_VEC3);

			int[] value = new int[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
			z = value[1] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y, out bool z, out bool w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckUniformType(uniform, Gl.BOOL_VEC4);

			int[] value = new int[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
			z = value[1] != 0;
			w = value[1] != 0;
		}

		#endregion

		#region Set/Get Uniform (single-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (m == null)
				throw new ArgumentNullException("m");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat2x2:
					if ((m.Width != 2) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat2x3:
					if ((m.Width != 2) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2x3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat2x4:
					if ((m.Width != 2) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2x4(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x2:
					if ((m.Width != 3) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3x2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x3:
					if ((m.Width != 3) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x4:
					if ((m.Width != 3) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3x4(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x2:
					if ((m.Width != 4) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4x2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x3:
					if ((m.Width != 4) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4x3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x4:
					if ((m.Width != 4) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
					break;
				default:
					throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
			}
		}

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (m == null)
				throw new ArgumentNullException("m");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT3);

			// Set uniform value
			Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
		}

		/// <summary>
		/// Set uniform state variable (mat4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (m == null)
				throw new ArgumentNullException("m");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT4);

			// Set uniform value
			Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
		}

		#endregion

		#region Set/Get Uniform (double-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (m == null)
				throw new ArgumentNullException("m");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat2x2:
					if ((m.Width != 2) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat2x3:
					if ((m.Width != 2) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2x3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat2x4:
					if ((m.Width != 2) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix2x4(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x2:
					if ((m.Width != 3) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3x2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x3:
					if ((m.Width != 3) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat3x4:
					if ((m.Width != 3) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix3x4(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x2:
					if ((m.Width != 4) || (m.Height != 2))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4x2(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x3:
					if ((m.Width != 4) || (m.Height != 3))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4x3(uniform.Location, 1, false, m.Buffer);
					break;
				case ShaderUniformType.Mat4x4:
					if ((m.Width != 4) || (m.Height != 4))
						throw new ArgumentException("matrix size mismatch");
					Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
					break;
				default:
					throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
			}
		}

		/// <summary>
		/// Set uniform state variable (dmat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble3x3"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble3x3 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_MAT3);

			// Set uniform value
			Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
		}

		/// <summary>
		/// Set uniform state variable (dmat4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble4x4"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble4x4 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT4);

			// Set uniform value
			Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
		}

		#endregion

		#region Set/Get Uniform (sampler-compatible data)

		/// <summary>
		/// Set uniform state variable (sampler1D, sampler2D, sampler3D, samplerCube variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="tex">
		/// A <see cref="Texture"/> holding the uniform variabile data (the texture name).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Texture tex)
		{
			SetUniform(ctx, uniformName, tex, _TexActiveUnit++);
		}

		/// <summary>
		/// Set uniform state variable (sampler1D, sampler2D, sampler3D, samplerCube variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="tex">
		/// A <see cref="Texture"/> holding the uniform variabile data (the texture name).
		/// </param>
		/// <param name="texUnit">
		/// A <see cref="Int32"/> that specify the texture unit processing the texture <paramref name="tex"/>.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Texture tex, uint texUnit)
		{
			CheckThatExistence(ctx, tex);

			UniformBinding uniform = GetUniform(uniformName);

			CheckProgramBinding();
			CheckUniformType(uniform, tex.SamplerType);

			// Activate texture unit
			Gl.ActiveTexture(Gl.TEXTURE0 + (int)texUnit);
			// Bind texture (on active texture unit)
			ctx.Bind(tex);
			// Apply texture parameters
			tex.ApplyParameters(ctx);

			// Set uniform value (sampler)
			// Cast to Int32 since the sampler type can be set only with glUniform1i
			Gl.Uniform1(uniform.Location, (int)texUnit);

			// Validate program
			Validate();
		}

		/// <summary>
		/// 
		/// </summary>
		public void ResetTextureUnits()
		{
			_TexActiveUnit = 0;
		}

		/// <summary>
		/// The current active texture unit.
		/// </summary>
		private uint _TexActiveUnit;

		#endregion

		/// <summary>
		/// The number of slots used for storing uniform data.
		/// </summary>
		public uint UniformSlots { get { return (_DefaultBlockUniformSlots); } }

		/// <summary>
		/// Collection of active uniforms on this ShaderProgram.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This list may be not exahustive as someone could think: this list is initialize at link time, and its contents
		/// is determined by the current OpenGL driver used. To check effectively the uniform variable activeness, use
		/// <see cref="IsActiveUniform"/> method.
		/// </para>
		/// <para>
		/// After a call to <see cref="IsActiveUniform"/> method, the uniform variable (only if active) will be collected in
		/// the collection returned by this property.
		/// </para>
		/// </remarks>
		public ICollection<string> ActiveUniforms
		{
			get
			{
				return (_UniformMap.Keys);
			}
		}

		/// <summary>
		/// Determine whether an uniform is active or not.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> which specify the uniform name.
		/// </param>
		/// <returns>
		/// </returns>
		public bool IsActiveUniform(string uniformName)
		{
			return (_UniformMap.ContainsKey(uniformName));
		}

		/// <summary>
		/// Request uniform variable location.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> of the uniform variable used.
		/// </param>
		/// <returns></returns>
		private UniformBinding GetUniform(string uniformName)
		{
			if (uniformName == null)
				throw new ArgumentNullException("uniformName");

			UniformBinding uniformBinding;
			string semanticName;

			// Known semantic overrides uniform name
			if (_UniformSemantic.TryGetValue(uniformName, out semanticName))
				uniformName = semanticName;

			if (_UniformMap.TryGetValue(uniformName, out uniformBinding) == false)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			return (uniformBinding);
		}

		/// <summary>
		/// Check uniform variable coherence.
		/// </summary>
		/// <param name="uniform">
		/// A <see cref="UniformBinding"/> that specify the uniform name to check.
		/// </param>
		/// <param name="uniformRequestTypes">
		/// A sequence of OpenGL constants that are the allowed types for the specified uniform.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the type of the uniform variable <paramref name="uniform"/> does not match any value specified by <paramref name="uniformRequestTypes"/>.
		/// </exception>
		[Conditional("DEBUG")]
		private static void CheckUniformType(UniformBinding uniform, params int[] uniformRequestTypes)
		{
			if (uniform == null)
				throw new ArgumentNullException("uniform");
			if (uniformRequestTypes == null)
				throw new ArgumentNullException("uniformRequestTypes");

			/* ! Check: required uniform type shall correspond */
			foreach (int uniformReqtype in uniformRequestTypes)
				if ((int)uniform.UniformType == uniformReqtype)
					return;

			// 3.3.0 NVIDIA 310.44 confuse float uniforms (maybe in structs?) as vec4
			if (uniform.UniformType == ShaderUniformType.Vec4)
				return;

			throw new InvalidOperationException("uniform type mismatch");
		}

		/// <summary>
		/// Check whether this ShaderProgram is bound.
		/// </summary>
		[Conditional("DEBUG")]
		private void CheckProgramBinding()
		{
			int program;

			Gl.Get(Gl.CURRENT_PROGRAM, out program);

			if (program == InvalidObjectName || program != ObjectName)
				throw new InvalidOperationException("no shader program bound");
		}

		/// <summary>
		/// Shader program uniform binding.
		/// </summary>
		[DebuggerDisplay("UniformBinding { Name={Name} Location={Location} Type={UniformType} }")]
		private class UniformBinding
		{
			/// <summary>
			/// Construct a UniformBinding.
			/// </summary>
			/// <param name="uniformName">
			/// A <see cref="String"/> that specify the uniform variable name.
			/// </param>
			/// <param name="uniformIndex">
			/// </param>
			/// <param name="uniformLocation">
			/// </param>
			/// <param name="uniformType">
			/// A <see cref="ShaderUniformType"/> that specify the uniform variable type.
			/// </param>
			public UniformBinding(string uniformName, uint uniformIndex, int uniformLocation, ShaderUniformType uniformType)
			{
				if (uniformName == null)
					throw new ArgumentNullException("uniformName");

				Name = uniformName;
				Index = uniformIndex;
				Location = uniformLocation;
				UniformType = uniformType;
			}

			/// <summary>
			/// The uniform variable name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// Uniform index. The uniform index is used for <see cref="Gl.GetActiveUniform"/> OpenGL call.
			/// </summary>
			public readonly uint Index;

			/// <summary>
			/// Uniform location.
			/// </summary>
			public readonly int Location;

			/// <summary>
			/// Uniform type.
			/// </summary>
			public readonly ShaderUniformType UniformType = ShaderUniformType.Unknown;
		}

		/// <summary>
		/// Map active uniform location with uniform name.
		/// </summary>
		private readonly Dictionary<string, UniformBinding> _UniformMap = new Dictionary<string, UniformBinding>();

		/// <summary>
		/// Uniform slots used by the default block of this shader program.
		/// </summary>
		private uint _DefaultBlockUniformSlots;

		#endregion
	}
}
