
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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenGL;

namespace HelloNewton
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Log.ConfigureLogFile("Log.config");

#if DEBUG
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
#endif

			// UI initialization (before accessing GraphicsContext and others)
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//OpenGL.Scene.Terrain.Query(@"D:\__dds.cr.usgs.gov\srtm\version2_1\SRTM30\w180s10");

			// Check requirements
			StringBuilder missingReq = new StringBuilder();

			if (!Gl.CurrentExtensions.VertexShader_ARB)
				missingReq.Append("- GL_ARB_vertex_shader\n");
			if (!Gl.CurrentExtensions.PrimitiveRestart)
				missingReq.Append("- OpenGL 3.1\n");
			if (!Gl.CurrentExtensions.InstancedArrays)
				missingReq.Append("- GL_ARB_instanced_arrays or OpenGL 3.2\n");

			if (missingReq.Length > 0)
			{
				MessageBox.Show(
					String.Format("Unable to run sample. The following required extensions are not implemented:\n {0}", missingReq.ToString()),
					"Error...", MessageBoxButtons.OK, MessageBoxIcon.Error
				);

				return;
			}

			// Run UI
			Application.Run(new SampleForm());
		}
	}
}
