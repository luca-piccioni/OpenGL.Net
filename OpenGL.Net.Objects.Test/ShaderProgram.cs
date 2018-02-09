using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL.Objects.Test
{
	class ShaderProgramTest
	{
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
	}
}
