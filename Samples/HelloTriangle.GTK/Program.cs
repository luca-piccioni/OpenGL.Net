
// Copyright (C) 2017 Luca Piccioni
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

using Gtk;
using OpenGL;
using OpenGL.GTK3;

namespace HelloTriangle.GTK
{
	class ExampleWindow : Window
	{
		public ExampleWindow() : base("Hello Triangle (GTK# 3)")
		{
			SetDefaultSize(800, 600);
			SetPosition(WindowPosition.Center);

			GlWidget glWidget = new GlWidget();

			Add(glWidget);

			glWidget.Hexpand = true;
			glWidget.Vexpand = true;

			glWidget.SetSizeRequest(100, 100);
			glWidget.SizeAllocated += GlWidget_SizeAllocated;
			glWidget.ContextCreated += GlWidget_ContextCreated;
			glWidget.Render += GlWidget_Render;

			DeleteEvent += delegate { Application.Quit(); };
			ShowAll();
		}

		private void GlWidget_SizeAllocated(object o, SizeAllocatedArgs args)
		{
			Gl.Viewport(0, 0, args.Allocation.Width, args.Allocation.Height);
		}

		private void GlWidget_Render(object sender, GlWidgetEventArgs e)
		{
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			// Animate triangle
			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();
			Gl.Rotate(_Angle, 0.0f, 0.0f, 1.0f);

			if (Gl.CurrentVersion >= Gl.Version_110) {
				// Old school OpenGL 1.1
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
				Gl.Begin(PrimitiveType.Triangles);
				Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
				Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
				Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
				Gl.End();
			}
		}

		private void GlWidget_ContextCreated(object sender, GlWidgetEventArgs e)
		{
			// Here you can allocate resources or initialize state
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0, 0.0, 1.0, 0.0, 1.0);
		}

		#region Common Data

		private static float _Angle;

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

		#endregion
	}

	static class Program
	{
		/// <summary>
		/// Punto di ingresso principale dell'applicazione.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Init();
			new ExampleWindow();
			Application.Run();
		}
	}
}
