using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

using Cairo;
using Gtk;
using OpenGL;

namespace HelloTriangle.GTK
{
	[ToolboxItem(true)]
	class GlWidget : DrawingArea
	{
		public GlWidget()
		{
			DoubleBuffered = false;
		}

		protected override void OnRealized()
		{
			// Base implementation
			base.OnRealized();

			IntPtr winHandle = GetWindowHandle();

			if (winHandle != IntPtr.Zero) {
				_DeviceContext = DeviceContext.Create(IntPtr.Zero, GetWindowHandle());
				_DeviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				_GraphicsContext = _DeviceContext.CreateContext(IntPtr.Zero);
			}
		}

		protected override bool OnDrawn(Context cr)
		{
			// Base implementation
			//bool ret = base.OnDrawn(cr);

			_DeviceContext.MakeCurrent(_GraphicsContext);

			Gl.ClearColor(1.0f, 0.0f, 0.0f, 0.0f);

			Gl.Viewport(0, 0, 100, 100);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			_DeviceContext.SwapBuffers();

			return (true);
		}

		private IntPtr GetWindowHandle()
		{
			return (gdk_win32_window_get_handle(Window.Handle));
		}

		[SuppressUnmanagedCodeSecurity, DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gdk_win32_window_get_handle(IntPtr d);

		private DeviceContext _DeviceContext;

		private IntPtr _GraphicsContext;
	}

	class ExampleWindow : Window
	{
		public ExampleWindow() : base("Hello Triangle (GTK#)")
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
