
// Copyright (C) 2016-2017 Luca Piccioni
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

using OpenGL;
using OpenGL.CoreUI;

namespace HelloTriangle.CoreUI
{
	class Program
	{
		static void Main(string[] args)
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextCreated += NativeWindow_ContextCreated;
				nativeWindow.Render += NativeWindow_Render;

				nativeWindow.Create(0, 0, 640, 480);
				nativeWindow.Show();
				nativeWindow.Run();
			}
		}

		private static void NativeWindow_ContextCreated(object sender, NativeWindowEventArgs e)
		{
			NativeWindow nativeWindow = (NativeWindow)sender;

			// Here you can allocate resources or initialize state
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0, 0.0, 1.0, 0.0, 1.0);

			// Uses multisampling, if available
			if (nativeWindow.MultisampleBits > 0)
				Gl.Enable(EnableCap.Multisample);
		}

		private static void NativeWindow_Render(object sender, NativeWindowEventArgs e)
		{
			NativeWindow nativeWindow = (NativeWindow)sender;

			Gl.Viewport(0, 0, (int)nativeWindow.Width, (int)nativeWindow.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			// Animate triangle
			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();

			// Old school OpenGL
			Gl.Begin(PrimitiveType.Triangles);
			Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
			Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
			Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
			Gl.End();
		}
	}
}
