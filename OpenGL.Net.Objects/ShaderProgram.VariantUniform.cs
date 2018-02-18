
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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenGL.Objects
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

			UniformBinding uniform = GetUniform(ctx, uniformName);

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
#if !MONODROID
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
#endif
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
			SetVariantUniform(ctx, uniformName, v.r, v.g, v.b, v.a);
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
			SetVariantUniform(ctx, uniformName, x, 0.0, 0.0, 0.0);
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
			SetVariantUniform(ctx, uniformName, x, y, 0.0, 0.0);
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
			SetVariantUniform(ctx, uniformName, x, y, z, 0.00);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);

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
#if !MONODROID
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
#endif
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
		/// A <see cref="Matrix3x3f"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix3x3f m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat3x3:
					SetUniform(ctx, uniformName, m);
					break;
#if !MONODROID
				case ShaderUniformType.DoubleMat3x3:
					SetUniform(ctx, uniformName, (Matrix3x3d)m);
					break;
#endif
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
		/// A <see cref="Matrix4x4f"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix4x4f m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat4x4:
					SetUniform(ctx, uniformName, m);
					break;
#if !MONODROID
				case ShaderUniformType.DoubleMat4x4:
					SetUniform(ctx, uniformName, (Matrix4x4d)m);
					break;
#endif
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
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix3x3d m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat3x3:
					SetUniform(ctx, uniformName, (Matrix3x3f)m);
					break;
#if !MONODROID
				case ShaderUniformType.DoubleMat3x3:
					SetUniform(ctx, uniformName, m);
					break;
#endif
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
		/// A <see cref="Matrix4x4d"/> holding the uniform variabile data.
		/// </param>
		public void SetVariantUniform(GraphicsContext ctx, string uniformName, Matrix4x4d m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			switch (uniform.UniformType) {
				case ShaderUniformType.Mat4x4:
					SetUniform(ctx, uniformName, (Matrix4x4f)m);
					break;
#if !MONODROID
				case ShaderUniformType.DoubleMat4x4:
					SetUniform(ctx, uniformName, m);
					break;
#endif
				default:
					throw new ShaderException("unable to set double-precision floating-point matrix 4x4 data to uniform of type {0}", uniform.UniformType);
			}
		}

		#endregion
	}
}
