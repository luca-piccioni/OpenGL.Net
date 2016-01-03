
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
using System.Collections.Generic;
using System.Reflection;

namespace OpenGL
{
	public partial class ShaderProgram
	{
		#region Set/Get Variant Uniforms

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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, object value)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (value == null)
				throw new ArgumentNullException("value");

			MethodInfo setUniformMethod;

			if (_SetVariantUniformMethods.TryGetValue(value.GetType(), out setUniformMethod) == false) {
				setUniformMethod = typeof(ShaderProgram).GetMethod("SetVariantUniform", new Type[] { typeof(GraphicsContext), typeof(string), value.GetType() });
				_SetVariantUniformMethods[value.GetType()] = setUniformMethod;
			}

			if (setUniformMethod != null) {
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
		private static readonly Dictionary<Type, MethodInfo> _SetVariantUniformMethods = new Dictionary<Type, MethodInfo>();

		#endregion

		#region Set/Get Variant Uniform (single-precision floating-point vector data)

		/// <summary>
		/// Set uniform variable from single-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// Other components than the first one are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, float x)
		{
			SetUniform(ctx, uniformName, x, 0.0f, 0.0f, 0.0f);
		}

		/// <summary>
		/// Set uniform variable from single-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniform variable length is less than 2, the higher components specified as
		/// arguments are ignored; otherwise, other components are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, float x, float y)
		{
			SetUniform(ctx, uniformName, x, y, 0.0f, 0.0f);
		}

		/// <summary>
		/// Set uniform variable from single-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniform variable length is less than 3, the higher components specified as
		/// arguments are ignored; otherwise, other components are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, float x, float y, float z)
		{
			SetUniform(ctx, uniformName, x, y, z, 0.0f);
		}

		/// <summary>
		/// Set uniform variable from single-precision floating-point data (variant type).
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniofmr variable length is less than 4, the higher components specified as
		/// arguments are ignored. The single-precision floating-point data is converted accordingly
		/// to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, float x, float y, float z, float w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Float:
					SetUniform(ctx, uniformName, x);
					break;
				case ShaderUniformType.Vec2:
					SetUniform(ctx, uniformName, x, y);
					break;
				case ShaderUniformType.Vec3:
					SetUniform(ctx, uniformName, x, y, z);
					break;
				case ShaderUniformType.Vec4:
					SetUniform(ctx, uniformName, x, y, z, w);
					break;
				case ShaderUniformType.Double:
					SetUniform(ctx, uniformName, (double)x);
					break;
				case ShaderUniformType.DoubleVec2:
					SetUniform(ctx, uniformName, (double)x, (double)y);
					break;
				case ShaderUniformType.DoubleVec3:
					SetUniform(ctx, uniformName, (double)x, (double)y, (double)z);
					break;
				case ShaderUniformType.DoubleVec4:
					SetUniform(ctx, uniformName, (double)x, (double)y, (double)z, (double)w);
					break;
				case ShaderUniformType.Int:
					SetUniform(ctx, uniformName, (int)x);
					break;
				case ShaderUniformType.IntVec2:
					SetUniform(ctx, uniformName, (int)x, (int)y);
					break;
				case ShaderUniformType.IntVec3:
					SetUniform(ctx, uniformName, (int)x, (int)y, (int)z);
					break;
				case ShaderUniformType.IntVec4:
					SetUniform(ctx, uniformName, (int)x, (int)y, (int)z);
					break;
				case ShaderUniformType.UInt:
					SetUniform(ctx, uniformName, (uint)x);
					break;
				case ShaderUniformType.UIntVec2:
					SetUniform(ctx, uniformName, (uint)x, (uint)y);
					break;
				case ShaderUniformType.UIntVec3:
					SetUniform(ctx, uniformName, (uint)x, (uint)y, (uint)z);
					break;
				case ShaderUniformType.UIntVec4:
					SetUniform(ctx, uniformName, (uint)x, (uint)y, (uint)z);
					break;
				default:
					throw new ShaderException("unable to set single-precision floating-point data to uniform of type {0}", uniform.UniformType);
			}
		}

		/// <summary>
		/// Set uniform state variable (variant type variable).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex2f v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex3f v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y, v.z);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable)
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex4f v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y, v.z, v.w);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable)
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, ColorRGBAF v)
		{
			SetVariantUniform(ctx, uniformName, v.Red, v.Green, v.Blue, v.Alpha);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable)
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex3 v)
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
		/// A <see cref="ColorRGBA"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, ColorRGBA v)
		{
			if (v == null)
				throw new ArgumentNullException("v");

			SetUniform(ctx, uniformName, v.Red, v.Green, v.Blue, v.Alpha);
		}

		#endregion

		#region Set/Get Variant Uniform (double-precision floating-point vector data)

		/// <summary>
		/// Set uniform variable from double-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// Other components than the first one are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, double x)
		{
			SetUniform(ctx, uniformName, x, 0.0, 0.0, 0.0);
		}

		/// <summary>
		/// Set uniform variable from double-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniform variable length is less than 2, the higher components specified as
		/// arguments are ignored; otherwise, other components are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, double x, double y)
		{
			SetUniform(ctx, uniformName, x, y, 0.0, 0.0);
		}

		/// <summary>
		/// Set uniform variable from double-precision floating-point data.
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniform variable length is less than 3, the higher components specified as
		/// arguments are ignored; otherwise, other components are reset to 0.0. The single-precision
		/// floating-point data is converted accordingly to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, double x, double y, double z)
		{
			SetUniform(ctx, uniformName, x, y, z, 0.00);
		}

		/// <summary>
		/// Set uniform variable from double-precision floating-point data (variant type).
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
		/// <remarks>
		/// <para>
		/// The uniform variable type could be one of the following :
		/// - float, vec2, vec3, vec4
		/// - double, dvec2, dvec3, dvec4
		/// - int, ivec2, ivec3, ivec4
		/// - uint, uvec2, uvec3, uvec4
		/// </para>
		/// <para>
		/// In the case the uniofmr variable length is less than 4, the higher components specified as
		/// arguments are ignored. The single-precision floating-point data is converted accordingly
		/// to the uniform variable type.
		/// </para>
		/// </remarks>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, double x, double y, double z, double w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Float:
					SetUniform(ctx, uniformName, (float)x);
					break;
				case ShaderUniformType.Vec2:
					SetUniform(ctx, uniformName, (float)x, (float)y);
					break;
				case ShaderUniformType.Vec3:
					SetUniform(ctx, uniformName, (float)x, (float)y, (float)z);
					break;
				case ShaderUniformType.Vec4:
					SetUniform(ctx, uniformName, (float)x, (float)y, (float)z, (float)w);
					break;
				case ShaderUniformType.Double:
					SetUniform(ctx, uniformName, x);
					break;
				case ShaderUniformType.DoubleVec2:
					SetUniform(ctx, uniformName, x, y);
					break;
				case ShaderUniformType.DoubleVec3:
					SetUniform(ctx, uniformName, x, y, z);
					break;
				case ShaderUniformType.DoubleVec4:
					SetUniform(ctx, uniformName, x, y, z, w);
					break;
				case ShaderUniformType.Int:
					SetUniform(ctx, uniformName, (int)x);
					break;
				case ShaderUniformType.IntVec2:
					SetUniform(ctx, uniformName, (int)x, (int)y);
					break;
				case ShaderUniformType.IntVec3:
					SetUniform(ctx, uniformName, (int)x, (int)y, (int)z);
					break;
				case ShaderUniformType.IntVec4:
					SetUniform(ctx, uniformName, (int)x, (int)y, (int)z);
					break;
				case ShaderUniformType.UInt:
					SetUniform(ctx, uniformName, (uint)x);
					break;
				case ShaderUniformType.UIntVec2:
					SetUniform(ctx, uniformName, (uint)x, (uint)y);
					break;
				case ShaderUniformType.UIntVec3:
					SetUniform(ctx, uniformName, (uint)x, (uint)y, (uint)z);
					break;
				case ShaderUniformType.UIntVec4:
					SetUniform(ctx, uniformName, (uint)x, (uint)y, (uint)z);
					break;
				default:
					throw new ShaderException("unable to set double-precision floating-point data to uniform os type {0}", uniform.UniformType);
			}
		}

		/// <summary>
		/// Set uniform state variable (variant type variable).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex2d v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex3d v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y, v.z);
		}

		/// <summary>
		/// Set uniform state variable (variant type variable)
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Vertex4d v)
		{
			SetVariantUniform(ctx, uniformName, v.x, v.y, v.z, v.w);
		}

		#endregion

		#region Set/Get Variant Uniform (single-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (variant type).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix3x3 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat3x3:
					SetUniform(ctx, uniformName, m);
					break;
				case ShaderUniformType.DoubleMat3x3:
					SetUniform(ctx, uniformName, (MatrixDouble3x3)m);
					break;
				default:
					throw new ShaderException("unable to set single-precision floating-point matrix 3x3 data to uniform of type {0}", uniform.UniformType);
			}
		}

		/// <summary>
		/// Set uniform state variable (variant type).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix4x4 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat4x4:
					SetUniform(ctx, uniformName, m);
					break;
				case ShaderUniformType.DoubleMat4x4:
					SetUniform(ctx, uniformName, (MatrixDouble4x4)m);
					break;
				default:
					throw new ShaderException("unable to set single-precision floating-point matrix 4x4 data to uniform of type {0}", uniform.UniformType);
			}
		}

		#endregion

		#region Set/Get Variant Uniform (double-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (variant type).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, MatrixDouble3x3 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat3x3:
					SetUniform(ctx, uniformName, (Matrix3x3)m);
					break;
				case ShaderUniformType.DoubleMat3x3:
					SetUniform(ctx, uniformName, m);
					break;
				default:
					throw new ShaderException("unable to set double-precision floating-point matrix 3x3 data to uniform of type {0}", uniform.UniformType);
			}
		}

		/// <summary>
		/// Set uniform state variable (variant type).
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, MatrixDouble4x4 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat4x4:
					SetUniform(ctx, uniformName, (Matrix4x4)m);
					break;
				case ShaderUniformType.DoubleMat4x4:
					SetUniform(ctx, uniformName, m);
					break;
				default:
					throw new ShaderException("unable to set double-precision floating-point matrix 4x4 data to uniform of type {0}", uniform.UniformType);
			}
		}

		#endregion

		#region Set/Get Variant Uniform (matrix interfaces)

		/// <summary>
		/// Set uniform state variable (variant type).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="IMatrix3x3"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, IMatrix3x3 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat3x3:
					SetUniform(ctx, uniformName, (Matrix3x3)m);
					break;
				case ShaderUniformType.DoubleMat3x3:
					SetUniform(ctx, uniformName, (MatrixDouble3x3)m);
					break;
				default:
					throw new ShaderException("unable to set double-precision floating-point matrix 3x3 data to uniform of type {0}", uniform.UniformType);
			}
		}

		/// <summary>
		/// Set uniform state variable (variant type).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="IMatrix4x4"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, IMatrix4x4 m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat4x4:
					SetUniform(ctx, uniformName, (Matrix4x4)m);
					break;
				case ShaderUniformType.DoubleMat4x4:
					SetUniform(ctx, uniformName, (MatrixDouble4x4)m);
					break;
				default:
					throw new ShaderException("unable to set double-precision floating-point matrix 4x4 data to uniform of type {0}", uniform.UniformType);
			}
		}

		#endregion
	}
}
