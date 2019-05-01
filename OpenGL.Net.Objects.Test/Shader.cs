
// Copyright (C) 2017-2019 Luca Piccioni
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
	[TestFixture(Category = "Objects")]
	class ShaderTest : TestBase
	{
		[Test]
		public void Shader_TestLoadSource()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				Assert.Throws<ArgumentNullException>(() => shader.LoadSource((System.IO.Stream)null));
				Assert.Throws<ArgumentNullException>(() => shader.LoadSource((string)null));
				Assert.Throws<ArgumentNullException>(() => shader.LoadSource((IEnumerable<string>)null));
				
				Assert.Throws<ArgumentException>(() => shader.LoadSource("Not.Existing.Resource"));

				// Can reload source anytime
				Assert.DoesNotThrow(() => shader.LoadSource(new[] { "#version 150", "void main {}" }));
				Assert.DoesNotThrow(() => shader.LoadSource(new[] { "#version 150", "void main { /* Another */}" }));
			}
		}

		[Test]
		public void Shader_TestSourceGeneration_NewLinesOptional()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				shader.LoadSource(new [] {
					"#version 150",
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// - No need to include new lines
				Assert.IsTrue(Array.TrueForAll(shader.CompiledStrings, (string item) => item.EndsWith("\n")));

				shader.LoadSource(new [] {
					"#version 150", // Intentionally without new line (it should be added)
					"void main() {\n",
					"	gl_Position = vec4(0, 0, 0, 1);\n",
					"}\n",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// New lines are allowed too, and generated source dont add further new lines
				Assert.IsTrue(Array.TrueForAll(shader.CompiledStrings, (string item) => item.EndsWith("\n") && !item.EndsWith("\n\n")));

				shader.LoadSource(new [] {
					"#version 150\nvoid main() {\ngl_Position = vec4(0, 0, 0, 1);\n}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// Multiline array items are split automatically
				Assert.Greater(shader.CompiledStrings.Length, 1);
				Assert.IsTrue(Array.TrueForAll(shader.CompiledStrings, (string item) => item.EndsWith("\n") && !item.EndsWith("\n\n")));
			}
		}

		[Test]
		public void Shader_TestSourceGeneration_VersionDirectiveOptional()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// #version directive may be omitted (uses current context version)
				Assert.IsTrue(shader.CompiledStrings[0].StartsWith("#version "));
			}
		}

		[Test]
		public void Shader_TestSourceGeneration_CommentsOmitted()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				shader.LoadSource(new [] {
					"// Comments shall be omitted in compiled strings",
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"// Even here!",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// C++ style comments are removed automatically
				Assert.IsTrue(Array.TrueForAll(shader.CompiledStrings, (string item) => !item.StartsWith("//")));

				shader.LoadSource(new [] {
					"/* Comments shall be omitted in compiled strings */",
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"/* Even here! */",
					"   /* ...but multiline",
					"      comments are not removed (yet) */",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// C++ style comments are removed automatically
				Assert.IsTrue(Array.TrueForAll(shader.CompiledStrings, (string item) => !item.StartsWith("/*")));
			}
		}

		[Test]
		public void Shader_TestCompilation()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				// Correct compilation
				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context));
				Assert.IsTrue(shader.IsCompiled);

				// Incorrect compilation
				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1)",	// Error: missing ';'
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				// Failed compilation will throw proper exception
				Assert.Throws<ShaderException>(() => shader.Create(_Context));
				// Of course, is not compiled
				Assert.IsFalse(shader.IsCompiled);
				// But we have the compiled strings
				Assert.IsNotNull(shader.CompiledStrings);
			}
		}

		[Test]
		public void Shader_TestCompilationParam()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				ShaderCompilerContext cctx = null;

				cctx = new ShaderCompilerContext();
				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				// Compiler context is required (use Create(GraphicsContext) instead)
				Assert.Throws<ArgumentNullException>(() => shader.Create(_Context, null));
				Assert.IsFalse(shader.IsCompiled);

				// Default compiler context let compile
				Assert.DoesNotThrow(() => shader.Create(_Context, new ShaderCompilerContext()));
				Assert.IsTrue(shader.IsCompiled);
			}
		}

		[Test]
		public void Shader_TestCompilationParam_Version()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				ShaderCompilerContext cctx = new ShaderCompilerContext() {
					ShaderVersion = new GlslVersion(1, 4, GlslVersion.ApiGlsl)
				};

				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context, cctx));
				Assert.IsTrue(shader.IsCompiled);

				// Requesting a specific shader version, automatic #version respect it
				Assert.AreEqual("#version 140\n", shader.CompiledStrings[0]);
			}
		}

		[Test]
		public void Shader_TestCompilationParam_VersionWithProfile()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				ShaderCompilerContext cctx = new ShaderCompilerContext() {
					ShaderVersion = new GlslVersion(1, 5, GlslVersion.ApiGlsl)
				};

				shader.LoadSource(new [] {
					"void main() {",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				Assert.DoesNotThrow(() => shader.Create(_Context, cctx));
				Assert.IsTrue(shader.IsCompiled);

				// Requesting a specific shader version, automatic #version respect it
				Assert.AreEqual("#version 150 compatibility\n", shader.CompiledStrings[0]);
			}
		}

		[Test]
		public void Shader_TestCompilationParam_Defines()
		{
			using (Shader shader = new Shader(ShaderType.VertexShader)) {
				ShaderCompilerContext cctx = new ShaderCompilerContext() {
					Defines = new List<string> { "TEST_ENABLED" }
				};

				shader.LoadSource(new [] {
					"void main() {",
					"#if TEST_ENABLED",
					"	gl_Position = vec4(0, 0, 0, 1);",
					"#else",
					"	gl_Position = vec4(0, 0, 0, 1)",
					"#endif",
					"}",
				});
				Assert.IsFalse(shader.IsCompiled);

				// A #define TEST_ENABLED 1 is defined before the loaded source
				Assert.DoesNotThrow(() => shader.Create(_Context, cctx));
				Assert.IsTrue(shader.IsCompiled);

				// Requesting a specific shader version, automatic #version respect it
				Assert.IsTrue(Array.Exists(shader.CompiledStrings, (string item) => item == "#define TEST_ENABLED 1\n"));
			}
		}

		#region Examples

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

		#endregion
	}
}
