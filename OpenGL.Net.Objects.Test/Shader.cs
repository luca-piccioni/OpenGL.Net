
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

using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test ShaderObject class.
	/// </summary>
	[TestFixture]
	class ShaderObjectTest
	{
		public void ExampleCreateObject(GraphicsContext ctx)
		{
			// Create a Shader instance, specifying the execution stage
			Shader shaderObject = new Shader(ShaderType.VertexShader);
			// Specify directly the shader source
			shaderObject.LoadSource(new string[] {
				"uniform mat4 my_ModelViewProjection;",
				"vec4 my_Position;",
				"void main() {",
				"	gl_Position = my_ModelViewProjection * my_Position;",
				"}"
			});
			// Compile the shader source
			shaderObject.Create(ctx);
		}

		public void ExampleCreateObjectFromStream(GraphicsContext ctx)
		{
			// Create a Shader instance, specifying the execution stage
			Shader shaderObject = new Shader(ShaderType.VertexShader);
			// Specify the shader source using Stream
			using (System.IO.FileStream fs = new System.IO.FileStream("shaderPath.glsl", System.IO.FileMode.Open, System.IO.FileAccess.Read)) {
				shaderObject.LoadSource(fs);
			}
			// Compile the shader source
			shaderObject.Create(ctx);
		}

		public void ExampleCreateObjectFromResource(GraphicsContext ctx)
		{
			// Create a Shader instance, specifying the execution stage
			Shader shaderObject = new Shader(ShaderType.VertexShader);
			// Specify shader source using embedded resource
			shaderObject.LoadSource("SampleNamespace.Subnamespace.ResourceName");
			// Compile the shader source
			shaderObject.Create(ctx);
		}
	}
}
