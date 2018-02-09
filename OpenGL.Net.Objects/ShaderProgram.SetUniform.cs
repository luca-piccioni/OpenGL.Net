
// Copyright (C) 2017 Luca Piccioni
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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
			SetUniform(ctx, uniformName, new Vertex2f(x, y));
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
			SetUniform(ctx, uniformName, new Vertex3f(x, y, z));
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
			SetUniform(ctx, uniformName, new Vertex4f(x, y, z, w));
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
		}

		/// <summary>
		/// Set uniform state variable (array of float variable).
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
		public void SetUniform(GraphicsContext ctx, string uniformName, float[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			_UniformBackend.SetUniform(ctx, this, uniform, v);
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

			_UniformBackend.SetUniform(ctx, this, uniform, v);
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
		/// A <see cref="T:Vertex3f[]"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3f[] v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);
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

			_UniformBackend.SetUniform(ctx, this, uniform, v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			_UniformBackend.SetUniform(ctx, this, uniform, v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT, Gl.BOOL);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex2i v = new Vertex2i(x, y);
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, x, y);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex3i v = new Vertex3i(x, y, z);
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, x, y, z);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			Vertex4i v = new Vertex4i(x, y, z, w);
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, x, y, z, w);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
		}

		#endregion

		#region Set Uniform (unsigned integer vector variant)

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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT, Gl.BOOL);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex2ui v = new Vertex2ui(x, y);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex3ui v = new Vertex3ui(x, y, z);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex4ui v = new Vertex4ui(x, y, z, w);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex2ui v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
		/// <param name="v">
		/// A <see cref="Vertex3ui"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex3ui v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> holding the uniform variabile data (first component).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Vertex4ui v)
		{
			CheckCurrentContext(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
		}

		#endregion

		#region Set Uniform (boolean vector data)

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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex2i v = new Vertex2i(x ? 1 : 0, y ? 1 : 0);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex3i v = new Vertex3i(x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			Vertex4i v = new Vertex4i(x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.BOOL_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
		/// A <see cref="Matrix3x3f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3f m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(m) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT3);

			_UniformBackend.SetUniform(ctx, this, uniform, m);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(m);
#endif
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
		/// A <see cref="Matrix4x4f"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4f m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(m) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT4);

			_UniformBackend.SetUniform(ctx, this, uniform, m);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(m);
#endif
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
		/// <param name="texture">
		/// A <see cref="Texture"/> holding the uniform variabile data (the texture name).
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Texture texture)
		{
			CheckThatExistence(ctx, texture);

			uint textureUnitIndex = texture.GetTextureUnit(ctx);

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			// Force parameter application
			ctx.Bind(texture);

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(textureUnitIndex) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, texture.SamplerType);

			// Set uniform value (sampler)
			// Cast to Int32 since the sampler type can be set only with glUniform1i
			_UniformBackend.SetUniform(ctx, this, uniform, (int)textureUnitIndex);

			// Validate program
			Validate();

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(textureUnitIndex);
#endif
		}

		#endregion

#if !MONODROID

		#region Set Uniform (double-precision floating-point vector data)

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

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
			SetUniform(ctx, uniformName, new Vertex2d(x, y));
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
			SetUniform(ctx, uniformName, new Vertex3d(x, y, z));
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
			SetUniform(ctx, uniformName, new Vertex4d(x, y, z, w));
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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC2);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC3);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

#if ENABLE_LAZY_UNIFORM_VALUE
			if (uniform.IsValueChanged(v) == false)
				return;
#endif

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_VEC4);

			_UniformBackend.SetUniform(ctx, this, uniform, v);

#if ENABLE_LAZY_UNIFORM_VALUE
			uniform.CacheValue(v);
#endif
		}

		#endregion

		#region Set Uniform (double-precision floating-point matrix data)

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
		/// A <see cref="Matrix3x3d"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3d m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.DOUBLE_MAT3);

			_UniformBackend.SetUniform(ctx, this, uniform, m);
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
		/// A <see cref="Matrix4x4d"/> holding the uniform variabile data.
		/// </param>
		public void SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4d m)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				return;

			CheckProgramBinding();
			CheckUniformType(uniform, Gl.FLOAT_MAT4);

			_UniformBackend.SetUniform(ctx, this, uniform, m);
		}

		#endregion

#endif

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

			if        (valueType == typeof(Vertex2f)) {
				SetUniform(ctx, uniformName, (Vertex2f)value);
			} else if (valueType == typeof(Vertex3f)) {
				SetUniform(ctx, uniformName, (Vertex3f)value);
			} else if (valueType == typeof(Vertex4f)) {
				SetUniform(ctx, uniformName, (Vertex4f)value);
			} else if (valueType == typeof(Vertex2i)) {
				SetUniform(ctx, uniformName, (Vertex2i)value);
			} else if (valueType == typeof(Vertex3i)) {
				SetUniform(ctx, uniformName, (Vertex3i)value);
			} else if (valueType == typeof(Vertex4i)) {
				SetUniform(ctx, uniformName, (Vertex4i)value);
			} else if (valueType == typeof(int)) {
				SetUniform(ctx, uniformName, (int)value);
			} else if (valueType == typeof(float)) {
				SetUniform(ctx, uniformName, (float)value);
			} else if (valueType == typeof(ColorRGBAF)) {
				SetUniform(ctx, uniformName, (ColorRGBAF)value);
			} else if (valueType == typeof(Texture2d)) {
				SetUniform(ctx, uniformName, (Texture2d)value);
			} else if (valueType == typeof(TextureCube)) {
				SetUniform(ctx, uniformName, (TextureCube)value);
			} else
				throw new NotSupportedException(valueType + "is not supported by SetUniform(GraphicsContext, string, object");
		}

		#endregion
	}
}
