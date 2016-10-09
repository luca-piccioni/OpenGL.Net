
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

using System;
using System.Collections.Generic;
using System.IO;

using NUnit.Framework;

namespace OpenGL.Hal.Test.Shaders
{
	/// <summary>
	/// Test Line shader.
	/// </summary>
	[TestFixture]
	class LineShaderTest : ShaderTestBase
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
			if (!Gl.CurrentExtensions.GeometryShader4_ARB && !Gl.CurrentExtensions.GeometryShader4_EXT)
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
		/// Test Line shader.
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
		/// Test Line shader.
		/// </summary>
		[Test]
		public void TestLineColorShader()
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
		/// Test Line shader.
		/// </summary>
		[Test]
		public void TestLineShaderRender()
		{
			using (ShaderProgram shaderProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.Line")) {
				Assert.DoesNotThrow(delegate () { shaderProgram.Create(_Context); });

				using (VertexArrayObject vao = new VertexArrayObject()) {
					List<Vertex2f> vertices = new List<Vertex2f>();

					for (float y = 0.375f; y < _Framebuffer.Height; y += 2.0f) {
						vertices.Add(new Vertex2f(0.0f, y));
						vertices.Add(new Vertex2f(_Framebuffer.Width, y));
					}

					// Setup ABO (Position)
					ArrayBufferObject abo = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
					abo.Create(vertices.ToArray());

					// Setup VAO
					vao.SetArray(abo, VertexArraySemantic.Position);
					vao.SetElementArray(PrimitiveType.Lines);
					vao.Create(_Context);

					// Draw test
					Image feedbackImageFixed = null, feedbackImageShader = null;

					try {
						Gl.Viewport(0, 0, (int)_Framebuffer.Width, (int)_Framebuffer.Height);

						#region Fixed pipeline

						_Framebuffer.SetClearColor(new ColorRGBAF(0.0f, 0.0f, 0.0f));
						_Framebuffer.Clear(_Context);

						Gl.MatrixMode(MatrixMode.Projection);
						Gl.LoadMatrix(new OrthoProjectionMatrix(0.0f, _Framebuffer.Width, 0.0f, _Framebuffer.Height).ToArray());
						Gl.MatrixMode(MatrixMode.Modelview);
						Gl.LoadIdentity();
						Gl.Color3(1.0f, 1.0f, 1.0f);
						Gl.LineWidth(1.0f);

						vao.Draw(_Context);

						feedbackImageFixed = _Framebuffer.ReadColorBuffer(_Context, 0, 0, 0, _Framebuffer.Width, _Framebuffer.Height, PixelLayout.R8);
						ImageCodec.Instance.Save(
							Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LineProgram.Fixed.png"),
							feedbackImageFixed, ImageFormat.Png, null
						);

						#endregion

						#region Shader pipeline

						_Framebuffer.SetClearColor(new ColorRGBAF(0.0f, 0.0f, 0.0f));
						_Framebuffer.Clear(_Context);

						_Context.Bind(shaderProgram);
						shaderProgram.SetUniform(_Context, "hal_ModelViewProjection", RenderProjectionMatrix);
						shaderProgram.SetUniform(_Context, "hal_UniformColor", new ColorRGBA(1.0f, 1.0f, 1.0f));
						shaderProgram.SetUniform(_Context, "hal_LineWidth", 1.0f);
						shaderProgram.SetUniform(_Context, "hal_ViewportSize", new Vertex2f(_Framebuffer.Width, _Framebuffer.Height));

						vao.Draw(_Context, shaderProgram);

						feedbackImageShader = _Framebuffer.ReadColorBuffer(_Context, 0, 0, 0, _Framebuffer.Width, _Framebuffer.Height, PixelLayout.R8);
						ImageCodec.Instance.Save(
							Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LineProgram.Shader.png"),
							feedbackImageShader, ImageFormat.Png, null
						);

						#endregion

						// Compare results

					} finally {
						if (feedbackImageFixed != null)
							feedbackImageFixed.Dispose();
						if (feedbackImageShader != null)
							feedbackImageShader.Dispose();
					}
				}

				//// Get rendering feedback
				//using (Image feedbackImage = _Framebuffer.ReadColorBuffer(_Context, 0, 0, 0, _Framebuffer.Width, _Framebuffer.Height, PixelLayout.GRAY8)) {
					

				//	// Drawn only even lines
				//	for (uint y = 0; y < _Framebuffer.Height; y++) {
				//		for (uint x = 0; x < _Framebuffer.Width; x++) {
				//			ColorGRAY8 fragment = (ColorGRAY8)feedbackImage[x, y];

				//			Assert.AreEqual((y % 2) == 0 ? 255 : 0, fragment.Level, String.Format("Color mismatch at {0}x{1}", x, y));
				//		}
				//	}
				//}
			}
		}

		private static readonly ProjectionMatrix RenderProjectionMatrix = new OrthoProjectionMatrix(0.0f, 16.0f, 0.0f, 16.0f);
	}
}
