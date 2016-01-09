
// Copyright (C) 2015 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Hal.Test.Shaders
{
	/// <summary>
	/// Test Line shader.
	/// </summary>
	[TestFixture]
	class LineProgram : ShaderTestBase
	{
		/// <summary>
		/// Test Line program vertex shader object.
		/// </summary>
		[Test]
		public void TestVertex()
		{
			using (ShaderObject shaderObject = new ShaderObject(ShaderStage.Vertex)) {
				// Load source
				Assert.DoesNotThrow(delegate() { shaderObject.LoadSource("OpenGL.Shaders.Line.Vertex.glsl"); });
				// Compile
				Assert.DoesNotThrow(delegate() { shaderObject.Create(_Context); });
			}
		}

		/// <summary>
		/// Test Line program geometry shader object.
		/// </summary>
		[Test]
		public void TestGeometry()
		{
			if (!_Context.Caps.GlExtensions.GeometryShader4_ARB && !_Context.Caps.GlExtensions.GeometryShader4_EXT)
				Assert.Inconclusive("geometry shader not supported");

			using (ShaderObject shaderObject = new ShaderObject(ShaderStage.Geometry)) {
				// Load source
				Assert.DoesNotThrow(delegate () { shaderObject.LoadSource("OpenGL.Shaders.Line.Geometry.glsl"); });
				// Compile
				Assert.DoesNotThrow(delegate () { shaderObject.Create(_Context); });
			}
		}

		/// <summary>
		/// Test Line program fragment shader object.
		/// </summary>
		[Test]
		public void TestFragment()
		{
			using (ShaderObject shaderObject = new ShaderObject(ShaderStage.Fragment)) {
				// Load source
				Assert.DoesNotThrow(delegate () { shaderObject.LoadSource("OpenGL.Shaders.Line.Fragment.glsl"); });
				// Compile
				Assert.DoesNotThrow(delegate () { shaderObject.Create(_Context); });
			}

			using (ShaderObject shaderObject = new ShaderObject(ShaderStage.Fragment)) {
				// Load source
				Assert.DoesNotThrow(delegate () { shaderObject.LoadSource("OpenGL.Shaders.Line.Fragment.glsl"); });
				// Compile
				Assert.DoesNotThrow(delegate () { shaderObject.Create(_Context, new ShaderCompilerContext("HAL_COLOR_PER_VERTEX")); });
			}
		}

		/// <summary>
		/// Test Line program.
		/// </summary>
		[Test]
		public void TestLineProgram()
		{
			using (ShaderProgram shaderProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.Line")) {
				Assert.DoesNotThrow(delegate() { shaderProgram.Create(_Context); });

				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_ModelViewProjection"));
				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_UniformColor"));
				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_LineWidth"));
				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_ViewportSize"));

				Assert.IsTrue(shaderProgram.IsActiveAttribute("hal_Position"));
			}
		}

		/// <summary>
		/// Test Line program.
		/// </summary>
		[Test]
		public void TestLineColorProgram()
		{
			using (ShaderProgram shaderProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.Line")) {
				Assert.DoesNotThrow(delegate () { shaderProgram.Create(_Context, new ShaderCompilerContext("HAL_COLOR_PER_VERTEX")); });

				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_ModelViewProjection"));
				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_LineWidth"));
				Assert.IsTrue(shaderProgram.IsActiveUniform("hal_ViewportSize"));

				Assert.IsTrue(shaderProgram.IsActiveAttribute("hal_Position"));
				Assert.IsTrue(shaderProgram.IsActiveAttribute("hal_Color"));
			}
		}

		/// <summary>
		/// Test Line program.
		/// </summary>
		[Test]
		public void TestLineProgramRender()
		{
			using (ShaderProgram shaderProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.Line")) {
				Assert.DoesNotThrow(delegate () { shaderProgram.Create(_Context); });

				shaderProgram.Bind(_Context);
				shaderProgram.SetUniform(_Context, "hal_ModelViewProjection", RenderProjectionMatrix);
				shaderProgram.SetUniform(_Context, "hal_UniformColor", new ColorRGBA(1.0f, 1.0f, 1.0f));
				shaderProgram.SetUniform(_Context, "hal_LineWidth", 1.0f);
				shaderProgram.SetUniform(_Context, "hal_ViewportSize", new Vertex2f(_Framebuffer.Width, _Framebuffer.Height));

				// Issue rendering
				_Framebuffer.SetClearColor(new ColorRGBAF(0.0f, 0.0f, 0.0f));
				_Framebuffer.Clear(_Context);
				

				// Get rendering feedback
				using (Image feedbackImage = _Framebuffer.ReadColorBuffer(_Context, 0, 0, 0, 16, 16, PixelLayout.GRAY8)) {

				}
			}
		}

		private static readonly ProjectionMatrix RenderProjectionMatrix = new OrthoProjectionMatrix(0.0f, 16.0f, 0.0f, 16.0f);
	}
}
