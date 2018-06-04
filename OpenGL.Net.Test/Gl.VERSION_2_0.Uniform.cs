
// Copyright (C) 2017-2018 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Test
{
	partial class Gl_VERSION_2_0
	{
		#region glUniform1fv

		private uint CreateProgramUniform1f()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform float uVec = 0.0;\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform1f()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform1f();

				try {
					float uniformStruct;
					float[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformfv
					uniformValue = Array1(1.0f);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(0.0f), uniformValue);

					// glGetUniformfv
					uniformStruct = 1.0f;
					Gl.GetUniformf(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(0.0f, uniformStruct);
				
					// glUniform1f
					uniformValue = Array1(0.0f);
					Gl.Uniform1(uniformLoc, Array1(1.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(1.0f), uniformValue);

					// glUniform1fv
					uniformValue = Array1(0.0f);
					Gl.Uniform1(uniformLoc, Array1(9.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(9.0f), uniformValue);

					// glUniform1fv
					uniformValue = Array1(0.0f);
					uniformStruct = 5.0f;
					Gl.Uniform1f(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(5.0f), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform1iv

		private uint CreateProgramUniform1i()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform int uVec = 0;\n",
				"void main() {\n",
				"	gl_Position = vec4(float(uVec));\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform1i()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform1i();

				try {
					int uniformStruct;
					int[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformiv
					uniformValue = Array1(1);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(0), uniformValue);

					// glGetUniformiv
					uniformStruct = 1;
					Gl.GetUniformi(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(0, uniformStruct);
				
					// glUniform1i
					uniformValue = Array1(0);
					Gl.Uniform1(uniformLoc, Array1(1));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(1), uniformValue);

					// glUniform1iv
					uniformValue = Array1(0);
					Gl.Uniform1(uniformLoc, Array1(9));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(9), uniformValue);

					// glUniform1iv
					uniformValue = Array1(0);
					uniformStruct = 5;
					Gl.Uniform1i(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(5), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform1uiv

		private uint CreateProgramUniform1ui()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform uint uVec = 0u;\n",
				"void main() {\n",
				"	gl_Position = vec4(float(uVec));\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform1ui()
		{
			if (!HasVersion(Gl.Version_300) && !HasVersion(Gl.Version_300_ES) && !HasExtension("GL_EXT_gpu_shader4"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform1ui();

				try {
					uint uniformStruct;
					uint[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformuiv
					uniformValue = Array1(1u);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(0u), uniformValue);

					// glGetUniformuiv
					uniformStruct = 1u;
					Gl.GetUniformui(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(0u, uniformStruct);
				
					// glUniform1ui
					uniformValue = Array1(0u);
					Gl.Uniform1(uniformLoc, Array1(1u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(1u), uniformValue);

					// glUniform1uiv
					uniformValue = Array1(0u);
					Gl.Uniform1(uniformLoc, Array1(9u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(9u), uniformValue);

					// glUniform1uiv
					uniformValue = Array1(0u);
					uniformStruct = 5u;
					Gl.Uniform1ui(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(5u), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#if !MONODROID

		#region glUniform1dv

		private uint CreateProgramUniform1d()
		{
			string[] srcVertex = {
				"#version 150\n",
				"#extension GL_ARB_gpu_shader_fp64 : enable\n",
				"uniform double uVec = 0.0;\n",
				"void main() {\n",
				"	gl_Position = vec4(float(uVec));\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform1d()
		{
			if (!HasVersion(Gl.Version_400) && !HasExtension("GL_ARB_gpu_shader_fp64"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform1d();

				try {
					double uniformStruct;
					double[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformdv
					uniformValue = Array1(1.0);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(0.0), uniformValue);

					// glGetUniformdv
					uniformStruct = 1.0;
					Gl.GetUniformd(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(0.0, uniformStruct);
				
					// glUniform1d
					uniformValue = Array1(0.0);
					Gl.Uniform1(uniformLoc, Array1(1.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(1.0), uniformValue);

					// glUniform1dv
					uniformValue = Array1(0.0);
					Gl.Uniform1(uniformLoc, Array1(9.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(9.0), uniformValue);

					// glUniform1dv
					uniformValue = Array1(0.0);
					uniformStruct = 5.0;
					Gl.Uniform1d(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array1(5.0), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#endif
		#region glUniform2fv

		private uint CreateProgramUniform2f()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform vec2 uVec = vec2(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 0, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform2f()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform2f();

				try {
					Vertex2f uniformStruct;
					float[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformfv
					uniformValue = Array2(1.0f);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(0.0f), uniformValue);

					// glGetUniformfv
					uniformStruct = new Vertex2f(1.0f);
					Gl.GetUniformf(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex2f.Zero, uniformStruct);
				
					// glUniform2f
					uniformValue = Array2(0.0f);
					Gl.Uniform2(uniformLoc, Array2(1.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(1.0f), uniformValue);

					// glUniform2fv
					uniformValue = Array2(0.0f);
					Gl.Uniform2(uniformLoc, Array2(9.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(9.0f), uniformValue);

					// glUniform2fv
					uniformValue = Array2(0.0f);
					uniformStruct = new Vertex2f(5.0f);
					Gl.Uniform2f(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(5.0f), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform2iv

		private uint CreateProgramUniform2i()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform ivec2 uVec = ivec2(0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 0, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform2i()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform2i();

				try {
					Vertex2i uniformStruct;
					int[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformiv
					uniformValue = Array2(1);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(0), uniformValue);

					// glGetUniformiv
					uniformStruct = new Vertex2i(1);
					Gl.GetUniformi(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex2i.Zero, uniformStruct);
				
					// glUniform2i
					uniformValue = Array2(0);
					Gl.Uniform2(uniformLoc, Array2(1));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(1), uniformValue);

					// glUniform2iv
					uniformValue = Array2(0);
					Gl.Uniform2(uniformLoc, Array2(9));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(9), uniformValue);

					// glUniform2iv
					uniformValue = Array2(0);
					uniformStruct = new Vertex2i(5);
					Gl.Uniform2i(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(5), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform2uiv

		private uint CreateProgramUniform2ui()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform uvec2 uVec = uvec2(0u);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 0, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform2ui()
		{
			if (!HasVersion(Gl.Version_300) && !HasVersion(Gl.Version_300_ES) && !HasExtension("GL_EXT_gpu_shader4"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform2ui();

				try {
					Vertex2ui uniformStruct;
					uint[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformuiv
					uniformValue = Array2(1u);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(0u), uniformValue);

					// glGetUniformuiv
					uniformStruct = new Vertex2ui(1u);
					Gl.GetUniformui(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex2ui.Zero, uniformStruct);
				
					// glUniform2ui
					uniformValue = Array2(0u);
					Gl.Uniform2(uniformLoc, Array2(1u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(1u), uniformValue);

					// glUniform2uiv
					uniformValue = Array2(0u);
					Gl.Uniform2(uniformLoc, Array2(9u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(9u), uniformValue);

					// glUniform2uiv
					uniformValue = Array2(0u);
					uniformStruct = new Vertex2ui(5u);
					Gl.Uniform2ui(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(5u), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#if !MONODROID

		#region glUniform2dv

		private uint CreateProgramUniform2d()
		{
			string[] srcVertex = {
				"#version 150\n",
				"#extension GL_ARB_gpu_shader_fp64 : enable\n",
				"uniform dvec2 uVec = dvec2(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 0, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform2d()
		{
			if (!HasVersion(Gl.Version_400) && !HasExtension("GL_ARB_gpu_shader_fp64"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform2d();

				try {
					Vertex2d uniformStruct;
					double[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformdv
					uniformValue = Array2(1.0);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(0.0), uniformValue);

					// glGetUniformdv
					uniformStruct = new Vertex2d(1.0);
					Gl.GetUniformd(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex2d.Zero, uniformStruct);
				
					// glUniform2d
					uniformValue = Array2(0.0);
					Gl.Uniform2(uniformLoc, Array2(1.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(1.0), uniformValue);

					// glUniform2dv
					uniformValue = Array2(0.0);
					Gl.Uniform2(uniformLoc, Array2(9.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(9.0), uniformValue);

					// glUniform2dv
					uniformValue = Array2(0.0);
					uniformStruct = new Vertex2d(5.0);
					Gl.Uniform2d(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array2(5.0), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#endif
		#region glUniform3fv

		private uint CreateProgramUniform3f()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform vec3 uVec = vec3(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform3f()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform3f();

				try {
					Vertex3f uniformStruct;
					float[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformfv
					uniformValue = Array3(1.0f);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(0.0f), uniformValue);

					// glGetUniformfv
					uniformStruct = new Vertex3f(1.0f);
					Gl.GetUniformf(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex3f.Zero, uniformStruct);
				
					// glUniform3f
					uniformValue = Array3(0.0f);
					Gl.Uniform3(uniformLoc, Array3(1.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(1.0f), uniformValue);

					// glUniform3fv
					uniformValue = Array3(0.0f);
					Gl.Uniform3(uniformLoc, Array3(9.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(9.0f), uniformValue);

					// glUniform3fv
					uniformValue = Array3(0.0f);
					uniformStruct = new Vertex3f(5.0f);
					Gl.Uniform3f(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(5.0f), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform3iv

		private uint CreateProgramUniform3i()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform ivec3 uVec = ivec3(0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform3i()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform3i();

				try {
					Vertex3i uniformStruct;
					int[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformiv
					uniformValue = Array3(1);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(0), uniformValue);

					// glGetUniformiv
					uniformStruct = new Vertex3i(1);
					Gl.GetUniformi(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex3i.Zero, uniformStruct);
				
					// glUniform3i
					uniformValue = Array3(0);
					Gl.Uniform3(uniformLoc, Array3(1));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(1), uniformValue);

					// glUniform3iv
					uniformValue = Array3(0);
					Gl.Uniform3(uniformLoc, Array3(9));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(9), uniformValue);

					// glUniform3iv
					uniformValue = Array3(0);
					uniformStruct = new Vertex3i(5);
					Gl.Uniform3i(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(5), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform3uiv

		private uint CreateProgramUniform3ui()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform uvec3 uVec = uvec3(0u);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform3ui()
		{
			if (!HasVersion(Gl.Version_300) && !HasVersion(Gl.Version_300_ES) && !HasExtension("GL_EXT_gpu_shader4"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform3ui();

				try {
					Vertex3ui uniformStruct;
					uint[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformuiv
					uniformValue = Array3(1u);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(0u), uniformValue);

					// glGetUniformuiv
					uniformStruct = new Vertex3ui(1u);
					Gl.GetUniformui(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex3ui.Zero, uniformStruct);
				
					// glUniform3ui
					uniformValue = Array3(0u);
					Gl.Uniform3(uniformLoc, Array3(1u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(1u), uniformValue);

					// glUniform3uiv
					uniformValue = Array3(0u);
					Gl.Uniform3(uniformLoc, Array3(9u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(9u), uniformValue);

					// glUniform3uiv
					uniformValue = Array3(0u);
					uniformStruct = new Vertex3ui(5u);
					Gl.Uniform3ui(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(5u), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#if !MONODROID

		#region glUniform3dv

		private uint CreateProgramUniform3d()
		{
			string[] srcVertex = {
				"#version 150\n",
				"#extension GL_ARB_gpu_shader_fp64 : enable\n",
				"uniform dvec3 uVec = dvec3(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec, 1);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform3d()
		{
			if (!HasVersion(Gl.Version_400) && !HasExtension("GL_ARB_gpu_shader_fp64"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform3d();

				try {
					Vertex3d uniformStruct;
					double[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformdv
					uniformValue = Array3(1.0);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(0.0), uniformValue);

					// glGetUniformdv
					uniformStruct = new Vertex3d(1.0);
					Gl.GetUniformd(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex3d.Zero, uniformStruct);
				
					// glUniform3d
					uniformValue = Array3(0.0);
					Gl.Uniform3(uniformLoc, Array3(1.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(1.0), uniformValue);

					// glUniform3dv
					uniformValue = Array3(0.0);
					Gl.Uniform3(uniformLoc, Array3(9.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(9.0), uniformValue);

					// glUniform3dv
					uniformValue = Array3(0.0);
					uniformStruct = new Vertex3d(5.0);
					Gl.Uniform3d(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array3(5.0), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#endif
		#region glUniform4fv

		private uint CreateProgramUniform4f()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform vec4 uVec = vec4(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform4f()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform4f();

				try {
					Vertex4f uniformStruct;
					float[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformfv
					uniformValue = Array4(1.0f);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(0.0f), uniformValue);

					// glGetUniformfv
					uniformStruct = new Vertex4f(1.0f);
					Gl.GetUniformf(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex4f.Zero, uniformStruct);
				
					// glUniform4f
					uniformValue = Array4(0.0f);
					Gl.Uniform4(uniformLoc, Array4(1.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(1.0f), uniformValue);

					// glUniform4fv
					uniformValue = Array4(0.0f);
					Gl.Uniform4(uniformLoc, Array4(9.0f));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(9.0f), uniformValue);

					// glUniform4fv
					uniformValue = Array4(0.0f);
					uniformStruct = new Vertex4f(5.0f);
					Gl.Uniform4f(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(5.0f), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform4iv

		private uint CreateProgramUniform4i()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform ivec4 uVec = ivec4(0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform4i()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES) && !HasExtension("GL_ARB_shader_objects"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform4i();

				try {
					Vertex4i uniformStruct;
					int[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformiv
					uniformValue = Array4(1);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(0), uniformValue);

					// glGetUniformiv
					uniformStruct = new Vertex4i(1);
					Gl.GetUniformi(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex4i.Zero, uniformStruct);
				
					// glUniform4i
					uniformValue = Array4(0);
					Gl.Uniform4(uniformLoc, Array4(1));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(1), uniformValue);

					// glUniform4iv
					uniformValue = Array4(0);
					Gl.Uniform4(uniformLoc, Array4(9));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(9), uniformValue);

					// glUniform4iv
					uniformValue = Array4(0);
					uniformStruct = new Vertex4i(5);
					Gl.Uniform4i(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(5), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

		#region glUniform4uiv

		private uint CreateProgramUniform4ui()
		{
			string[] srcVertex = {
				"#version 150\n",
				"uniform uvec4 uVec = uvec4(0u);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform4ui()
		{
			if (!HasVersion(Gl.Version_300) && !HasVersion(Gl.Version_300_ES) && !HasExtension("GL_EXT_gpu_shader4"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform4ui();

				try {
					Vertex4ui uniformStruct;
					uint[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformuiv
					uniformValue = Array4(1u);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(0u), uniformValue);

					// glGetUniformuiv
					uniformStruct = new Vertex4ui(1u);
					Gl.GetUniformui(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex4ui.Zero, uniformStruct);
				
					// glUniform4ui
					uniformValue = Array4(0u);
					Gl.Uniform4(uniformLoc, Array4(1u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(1u), uniformValue);

					// glUniform4uiv
					uniformValue = Array4(0u);
					Gl.Uniform4(uniformLoc, Array4(9u));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(9u), uniformValue);

					// glUniform4uiv
					uniformValue = Array4(0u);
					uniformStruct = new Vertex4ui(5u);
					Gl.Uniform4ui(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(5u), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#if !MONODROID

		#region glUniform4dv

		private uint CreateProgramUniform4d()
		{
			string[] srcVertex = {
				"#version 150\n",
				"#extension GL_ARB_gpu_shader_fp64 : enable\n",
				"uniform dvec4 uVec = dvec4(0.0);\n",
				"void main() {\n",
				"	gl_Position = vec4(uVec);\n",
				"}\n"
			};

			return CreateProgramUniform(srcVertex, _SrcFragment);
		}

		/// <summary>
		/// Test Uniform3* methods.
		/// </summary>
		[Test]
		public void Uniform4d()
		{
			if (!HasVersion(Gl.Version_400) && !HasExtension("GL_ARB_gpu_shader_fp64"))
				Assert.Inconclusive("required features not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = CreateProgramUniform4d();

				try {
					Vertex4d uniformStruct;
					double[] uniformValue;

					int uniformLoc = Gl.GetUniformLocation(program, "uVec");
					if (uniformLoc < 0)
						throw new InvalidOperationException("no uniform variable");

					// glGetUniformdv
					uniformValue = Array4(1.0);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(0.0), uniformValue);

					// glGetUniformdv
					uniformStruct = new Vertex4d(1.0);
					Gl.GetUniformd(program, uniformLoc, out uniformStruct);
					Assert.AreEqual(Vertex4d.Zero, uniformStruct);
				
					// glUniform4d
					uniformValue = Array4(0.0);
					Gl.Uniform4(uniformLoc, Array4(1.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(1.0), uniformValue);

					// glUniform4dv
					uniformValue = Array4(0.0);
					Gl.Uniform4(uniformLoc, Array4(9.0));
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(9.0), uniformValue);

					// glUniform4dv
					uniformValue = Array4(0.0);
					uniformStruct = new Vertex4d(5.0);
					Gl.Uniform4d(uniformLoc, 1, uniformStruct);
					Gl.GetUniform(program, uniformLoc, uniformValue);
					CollectionAssert.AreEqual(Array4(5.0), uniformValue);
				} finally {
					Gl.DeleteProgram(program);
				}
			}
		}

		#endregion

#endif
		#region Common

		private static T[] Array1<T>(T value) { return new T[] { value }; }

		private static T[] Array2<T>(T value) { return new T[] { value, value }; }

		private static T[] Array3<T>(T value) { return new T[] { value, value, value }; }

		private static T[] Array4<T>(T value) { return new T[] { value, value, value, value }; }

		private static string[] _SrcFragment = new string[] {
			"#version 150\n",
			"out vec4 oColor;\n",
			"void main() {\n",
			"	oColor = vec4(1.0);\n",
			"}\n"
		};

		#endregion
	}
}
