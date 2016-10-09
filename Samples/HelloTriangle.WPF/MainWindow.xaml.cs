
using System;
using System.Windows;
using System.Windows.Forms;

using OpenGL;

namespace HelloTriangle.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void HostControl_Loaded(object sender, RoutedEventArgs e)
		{
			OpenGL.GlControl glControl = (OpenGL.GlControl)HostControl.Child;

			glControl.ContextCreated += GlControl_ContextCreated;
			glControl.Render += GlControl_Render;
		}

		private void GlControl_ContextCreated(object sender, OpenGL.GlControlEventArgs e)
		{
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();
		}

		private void GlControl_Render(object sender, OpenGL.GlControlEventArgs e)
		{
			Control senderControl = (Control)sender;

			// FIXME I wonder why the viewport is affected when the GlControl is hosted in WPF windows.
			int vpx = -senderControl.ClientSize.Width;
			int vpy = -senderControl.ClientSize.Height;
			int vpw = senderControl.ClientSize.Width * 2;
			int vph = senderControl.ClientSize.Height * 2;

			Gl.Viewport(vpx, vpy, vpw, vph);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

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

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}
	}
}
