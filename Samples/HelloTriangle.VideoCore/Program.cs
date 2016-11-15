using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenGL;

namespace HelloTriangle.VideoCore
{
	class Program
	{
		static void Main()
		{
			try {
				string envDebug = Environment.GetEnvironmentVariable("GL_DEBUG");

				if (envDebug == "YES") {
					KhronosApi.RegisterApplicationLogDelegate(delegate (string format, object[] args) {
						Console.WriteLine(format, args);
					});
				}

				if (Wfc.IsAvailable)
					return;

				// RPi runs on EGL
				Egl.IsRequired = true;

				if (Egl.IsAvailable == false)
					throw new InvalidOperationException("EGL is not available. Aborting.");

				using (VideoCoreWindow nativeWindow = new VideoCoreWindow()) {
					using (DeviceContext eglContext = DeviceContext.Create(nativeWindow.Display, nativeWindow.Handle)) {

						eglContext.ChoosePixelFormat(new DevicePixelFormat(32));

						IntPtr glContext = eglContext.CreateContext(IntPtr.Zero);

						eglContext.MakeCurrent(glContext);

						Gl.Viewport(0, 0, 1920, 1080);
						Gl.ClearColor(1.0f, 0.0f, 0.0f, 0.0f);
						Gl.Clear(ClearBufferMask.ColorBufferBit);

						Gl.Flush();
						eglContext.SwapBuffers();

						System.Threading.Thread.Sleep(10000);

						eglContext.DeleteContext(glContext);
					}
				}
				
			} catch (Exception exception) {
				Console.WriteLine(exception.ToString());
			}
		}
	}
}
