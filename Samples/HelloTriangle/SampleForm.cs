
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

using System;
using System.Windows.Forms;

using OpenGL;

namespace HelloTriangle
{
	/// <summary>
	/// Hello triangle sample.
	/// </summary>
	public partial class SampleForm : Form
	{
		/// <summary>
		/// Construct a SampleForm.
		/// </summary>
		public SampleForm()
		{
			InitializeComponent();
		}

		private void RenderControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			
		}

		private void RenderControl_Render(object sender, GlControlEventArgs e)
		{
			Control senderControl = (Control)sender;

			Gl.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height);

			if (Gl.CurrentVersion >= Gl.Version_110) {
				// Old school OpenGL 1.1
				Gl.MatrixMode(MatrixMode.Projection);
				Gl.LoadIdentity();
				Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

				Gl.MatrixMode(MatrixMode.Modelview);
				Gl.LoadIdentity();

				Gl.Clear(ClearBufferMask.ColorBufferBit);

				// Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
				using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition)) 
				using (MemoryLock vertexColorLock = new MemoryLock(_ArrayColor))
				{
					// Note: the use of MemoryLock objects is necessary to pin vertex arrays since they can be reallocated by GC
					// at any time between the Gl.VertexPointer execution and the Gl.DrawArrays execution

					Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
					Gl.EnableClientState(EnableCap.VertexArray);

					Gl.ColorPointer(3, ColorPointerType.Float, 0, vertexColorLock.Address);
					Gl.EnableClientState(EnableCap.ColorArray);

					Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
				}
			} else {
				// Old school OpenGL
				Gl.MatrixMode(MatrixMode.Projection);
				Gl.LoadIdentity();
				Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

				Gl.MatrixMode(MatrixMode.Modelview);
				Gl.LoadIdentity();

				Gl.Clear(ClearBufferMask.ColorBufferBit);

				Gl.Begin(PrimitiveType.Triangles);
				Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
				Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
				Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
				Gl.End();
			}
		}

		/// <summary>
		/// Vertex position array.
		/// </summary>
		private static readonly float[] _ArrayPosition = new float[] {
			0.0f, 0.0f,
			0.5f, 1.0f,
			1.0f, 0.0f
		};

		/// <summary>
		/// Vertex color array.
		/// </summary>
		private static readonly float[] _ArrayColor = new float[] {
			1.0f, 0.0f, 0.0f,
			0.0f, 1.0f, 0.0f,
			0.0f, 0.0f, 1.0f
		};
	}
}
