
// Copyright (C) 2016 Luca Piccioni
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

using System.Windows.Forms;

using OpenGL;

namespace HelloTriangle.Hal
{
	public partial class SampleForm : Form
	{
		public SampleForm()
		{
			InitializeComponent();
		}

		private void GraphicsControl_GraphicsContextCreated(object sender, OpenGL.GraphicsControlEventArgs e)
		{
			// Program
			_Program = ShadersLibrary.Instance.CreateProgram("OpenGL.Standard+Color");
			_Program.Create(e.Context);

			// Position array buffer
			ArrayBufferObject<Vertex2f> _ArrayPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);
			_ArrayPosition.Create(e.Context, new Vertex2f[] {
				new Vertex2f(0.0f, 0.0f),
				new Vertex2f(0.5f, 1.0f),
				new Vertex2f(1.0f, 0.0f)
			});

			// Color array buffer
			ArrayBufferObject<ColorRGBF> _ArrayColor = new ArrayBufferObject<ColorRGBF>(BufferObjectHint.StaticCpuDraw);
			_ArrayColor.Create(e.Context, new ColorRGBF[] {
				new ColorRGBF(1.0f, 0.0f, 0.0f),
				new ColorRGBF(0.0f, 1.0f, 0.0f),
				new ColorRGBF(0.0f, 0.0f, 1.0f)
			});

			// Vertex array
			_VertexArray = new VertexArrayObject();
			_VertexArray.SetArray(_ArrayPosition, VertexArraySemantic.Position);
			_VertexArray.SetArray(_ArrayColor, VertexArraySemantic.Color);
			_VertexArray.SetElementArray(PrimitiveType.Triangles, 0, 3);
			_VertexArray.Create(e.Context);
		}

		private void GraphicsControl_GraphicsContextDestroying(object sender, GraphicsControlEventArgs e)
		{
			if (_Program != null)
				_Program.Dispose();
			if (_VertexArray != null)
				_VertexArray.Dispose();
		}

		private void GraphicsControl_Draw(object sender, GraphicsControlEventArgs e)
		{
			GraphicsContext ctx = e.Context;
			IGraphicsSurface fb = e.Framebuffer;

			Gl.Viewport(0, 0, (int)fb.Width, (int)fb.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			ctx.Bind(_Program);
			_Program.SetUniform(ctx, "hal_ModelViewProjection", new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f));
			_VertexArray.Draw(ctx, _Program);
		}

		/// <summary>
		/// The program used for drawing.
		/// </summary>
		private ShaderProgram _Program;

		/// <summary>
		/// Vertex array collecting the actual data used for drawing.
		/// </summary>
		private VertexArrayObject _VertexArray;
	}
}
