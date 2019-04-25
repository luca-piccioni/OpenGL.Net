
// Copyright (C) 2019 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	[TestFixture]
	class ShaderProgramTest : TestBase
	{
		#region Attach/Detach Shader

		

		#endregion

		#region Examples

		public void ExampleCreateShaderProgram(GraphicsContext ctx, IEnumerable<Shader> shaderObjects)
		{
			ShaderProgram shaderProgram = new ShaderProgram("SampleProgram");

			foreach (Shader shader in shaderObjects)
				shaderProgram.AttachShader(shader);

			shaderProgram.Create(ctx);
		}

		public void ExampleSetShaderProgramUniform(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			// uniform vec4 my_Vec4Uniform;
			shaderProgram.SetUniform(ctx, "my_Vec4Uniform", new Vertex4f(1.0f));
			// uniform int my_IntUniform;
			shaderProgram.SetUniform(ctx, "my_IntUniform", 255);
			// uniform int my_BoolUniform;
			shaderProgram.SetUniform(ctx, "my_BoolUniform", false);
			// uniform int my_ArrayUniform[4];
			shaderProgram.SetUniform(ctx, "my_ArrayUniform", new int[] { 1, 2, 3, 4 });
			// uniform mat4 my_Mat4Uniform;
			shaderProgram.SetUniform(ctx, "my_Mat4Uniform", Matrix4x4d.Identity);
		}

		#endregion
	}
}
