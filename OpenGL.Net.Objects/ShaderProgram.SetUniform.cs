
// Copyright (C) 2017 Luca Piccioni
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

// Symbol for enabling shader program uniforms value caching: performance gain avoding redundant Uniform* calls
#define ENABLE_LAZY_UNIFORM_VALUE

using System;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Set Uniform (single-precision floating-point vector data)

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
			CheckCurrentContext(ctx);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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
			CheckCurrentContext(ctx);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, new Vertex2f(x, y)) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(this, uniform, x, y);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, new Vertex2f(x, y));
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, new Vertex3f(x, y, z)) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(this, uniform, x, y, z);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, new Vertex3f(x, y, z));
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, new Vertex4f(x, y, z, w)) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, x, y, z, w);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, new Vertex4f(x, y, z, w));
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(this, uniform, v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(this, uniform, v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, v);
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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
		public void SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, v);
		}

		#endregion

		#region Set Uniform (integer vector data)

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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT, Gl.BOOL);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex2i v = new Vertex2i(x, y);
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(this, uniform, x, y);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex3i v = new Vertex3i(x, y, z);
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(this, uniform, x, y, z);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex4i v = new Vertex4i(x, y, z, w);
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, x, y, z, w);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
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

#if ENABLE_LAZY_UNIFORM_VALUE
			if (IsUniformValueChanged(uniformName, v) == false)
				return;
#endif

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			CacheUniformValue(uniformName, v);
#endif
		}

		#endregion
	}
}
