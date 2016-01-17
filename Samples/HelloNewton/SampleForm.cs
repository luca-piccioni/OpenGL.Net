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
			GraphicsContext ctx = e.Context;

			// Create Newton program
			_NewtonProgram = ShadersLibrary.Instance.CreateProgram("Newton");
			_NewtonProgram.AddFeedbackVarying("hal_VertexPosition");
			_NewtonProgram.AddFeedbackVarying("hal_VertexSpeed");
			_NewtonProgram.AddFeedbackVarying("hal_VertexAcceleration");
			_NewtonProgram.Create(ctx);
        }

		private void SampleGraphicsControl_GraphicsContextDestroyed(object sender, GraphicsControlEventArgs e)
		{
			
		}

		private void SampleGraphicsControl_Render(object sender, GraphicsControlEventArgs e)
		{
			
		}

		ShaderProgram _NewtonProgram;
	}
}
