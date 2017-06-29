
// Copyright (C) 2017 Luca Piccioni
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

using Gtk;
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

			glWidget.SetSizeRequest(100, 100);

			DeleteEvent += delegate { Application.Quit(); };
			ShowAll();
		}
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
