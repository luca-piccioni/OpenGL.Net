
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Text;
using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 2.0 API.
	/// </summary>
	[TestFixture]
	[Category("GL_VERSION_2_0")]
	partial class Gl_VERSION_2_0 : TestBaseGL
	{
		/// <summary>
		/// Test Gl.GetString.
		/// </summary>
		[Test]
		public void TestGetString()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES))
				Assert.Inconclusive("OpenGL 2.0 or OpenGL ES 2.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{

				#region Gl.SHADING_LANGUAGE_VERSION

				string shadingLanguageVersion = Gl.GetString(StringName.ShadingLanguageVersion);

				Console.WriteLine("Shading Language version: {0}", shadingLanguageVersion);

				#endregion

			}
		}

		/// <summary>
		/// Test Gl.CreateProgram.
		/// </summary>
		[Test]
		public void TestCreateProgram()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES))
				Assert.Inconclusive("OpenGL 2.0 or OpenGL ES 2.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint program = Gl.CreateProgram();
				Assert.AreNotEqual(0, program, "Gl.CreateProgram failure");

				try {
					Assert.IsTrue(Gl.IsProgram(program));
				} finally {
					if (program != 0) {
						Gl.DeleteProgram(program);
						Assert.IsFalse(Gl.IsProgram(program), "Gl.DeleteProgram failure");
					}
				}
			}
		}

		/// <summary>
		/// Test Gl.CreateProgram.
		/// </summary>
		[Test]
		public void TestCreateShader()
		{
			if (!HasVersion(Gl.Version_200) && !HasVersion(Gl.Version_200_ES))
				Assert.Inconclusive("OpenGL 2.0 or OpenGL ES 2.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint shader = Gl.CreateShader(ShaderType.VertexShader);
				try {
					Assert.AreNotEqual(0, shader, "Gl.CreateShader failure");
					Assert.IsTrue(Gl.IsShader(shader));

					int shaderGet;

					Gl.GetShader(shader, ShaderParameterName.ShaderType, out shaderGet);
					Assert.AreEqual(Gl.VERTEX_SHADER, shaderGet);
					Gl.GetShader(shader, ShaderParameterName.DeleteStatus, out shaderGet);
					Assert.AreEqual(Gl.FALSE, shaderGet);
					Gl.GetShader(shader, ShaderParameterName.CompileStatus, out shaderGet);
					Assert.AreEqual(Gl.FALSE, shaderGet);

				} finally {
					if (shader != 0) {
						Gl.DeleteShader(shader);
						Assert.IsFalse(Gl.IsShader(shader), "Gl.DeleteShader failure");
					}
				}
			}
		}

		private uint CreateProgramUniform(string[] srcVertex, string[] srcFragment)
		{
			uint shaderVertex = 0, shaderFragment = 0, program = 0;
			
			try {
				int compileStatus;

				shaderVertex = Gl.CreateShader(ShaderType.VertexShader);
				Gl.ShaderSource(shaderVertex, srcVertex);
				Gl.CompileShader(shaderVertex);
				Gl.GetShader(shaderVertex, ShaderParameterName.CompileStatus, out compileStatus);
				if (compileStatus == 0)
					throw new InvalidOperationException("unable to compiler vertex shader: " + GetShaderInfoLog(shaderVertex));

				shaderFragment = Gl.CreateShader(ShaderType.FragmentShader);
				Gl.ShaderSource(shaderFragment, srcFragment);
				Gl.CompileShader(shaderFragment);
				Gl.GetShader(shaderFragment, ShaderParameterName.CompileStatus, out compileStatus);
				if (compileStatus == 0)
					throw new InvalidOperationException("unable to compiler fragment shader: " + GetShaderInfoLog(shaderFragment));

				program = Gl.CreateProgram();
				Gl.AttachShader(program, shaderVertex);
				Gl.AttachShader(program, shaderFragment);
				Gl.LinkProgram(program);
				Gl.GetProgram(program, ProgramProperty.LinkStatus, out compileStatus);
				if (compileStatus == 0)
					throw new InvalidOperationException("unable to link program");

				Gl.UseProgram(program);
			} catch {
				if (shaderVertex != 0)
					Gl.DeleteShader(shaderVertex);
				if (shaderFragment != 0)
					Gl.DeleteShader(shaderFragment);
				if (shaderFragment != 0)
					Gl.DeleteProgram(program);

				throw;
			}
			

			return (program);
		}

		private string GetShaderInfoLog(uint shader)
		{
			const int MaxLength = 1024;

			StringBuilder infoLog = new StringBuilder(MaxLength);
			int length;

			Gl.GetShaderInfoLog(shader, MaxLength, out length, infoLog);

			return (infoLog.ToString());
		}
	}
}
