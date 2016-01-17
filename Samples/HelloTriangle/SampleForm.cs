using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenGL;

namespace HelloTriangle
{
	public partial class SampleForm : Form
	{
		public SampleForm()
		{
			InitializeComponent();
		}

		private void SampleGraphicsControl_GraphicsContextCreated(object sender, GraphicsControlEventArgs e)
		{
			// Allocate resources for drawing the triangle
			_Triangle = new VertexArrayObject();
			

        }

		private void SampleGraphicsControl_GraphicsContextDestroyed(object sender, GraphicsControlEventArgs e)
		{
			// Dispose resources
			_Triangle.Dispose(e.Context);
        }

		private void SampleGraphicsControl_Render(object sender, GraphicsControlEventArgs e)
		{
			// Draw the vertex arrays
			_Triangle.Draw(e.Context);
        }

		VertexArrayObject _Triangle;
	}
}
