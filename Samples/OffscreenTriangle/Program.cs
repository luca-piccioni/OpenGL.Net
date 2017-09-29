
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Drawing;
using System.Drawing.Imaging;

using Khronos;
using OpenGL;

namespace OffscreenTriangle
{
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			string envDebug = Environment.GetEnvironmentVariable("DEBUG");
			if (envDebug == "GL") {
				Khronos.KhronosApi.Log += delegate(object sender, KhronosLogEventArgs e) {
					Console.WriteLine(e.ToString());
				};
				Khronos.KhronosApi.LogEnabled = true;
			}

			try {
				// Gl.CurrentExtensions.FramebufferObject_ARB = false;		// Test P-Buffer
				// Egl.IsRequired = Egl.IsAvailable;						// Test EGL (not yet working)

				if (Gl.CurrentExtensions.FramebufferObject_ARB) {
					using (DeviceContext deviceContext = DeviceContext.Create()) {
						RenderOsdFramebuffer(deviceContext);
					}
				} else {
					// Fallback to old-school pbuffer
					using (INativePBuffer nativeBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 800, 600)) {
						using (DeviceContext deviceContext = DeviceContext.Create(nativeBuffer)) {
							RenderOsdPBuffer(deviceContext);
						}
					}
				}
			} catch (Exception exception) {
				Console.WriteLine("Unexpected exception: {0}", exception.ToString());
			}
		}

		private static void RenderOsdFramebuffer(DeviceContext deviceContext)
		{
			IntPtr glContext = IntPtr.Zero;
			uint framebuffer = 0;
			uint renderbuffer = 0;

			try {
				// Create context and make current on this thread
				if ((glContext = deviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
					throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error()); // XXX
				deviceContext.MakeCurrent(glContext);

				// Create framebuffer resources
				int w = Math.Min(800, Gl.CurrentLimits.MaxRenderbufferSize);
				int h = Math.Min(600, Gl.CurrentLimits.MaxRenderbufferSize);

				renderbuffer = Gl.GenRenderbuffer();
				Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, renderbuffer);
				Gl.RenderbufferStorage(RenderbufferTarget.Renderbuffer, InternalFormat.Rgb8, w, h);

				framebuffer = Gl.GenFramebuffer();
				Gl.BindFramebuffer(FramebufferTarget.ReadFramebuffer, framebuffer);
				Gl.BindFramebuffer(FramebufferTarget.Framebuffer, framebuffer);
				Gl.FramebufferRenderbuffer(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, RenderbufferTarget.Renderbuffer, renderbuffer);

				FramebufferStatus framebufferStatus = Gl.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
				if (framebufferStatus != FramebufferStatus.FramebufferComplete)
					throw new InvalidOperationException("framebuffer not complete");

				Gl.DrawBuffers(Gl.COLOR_ATTACHMENT0);

				RenderOsd(w, h);

				Gl.ReadBuffer(ReadBufferMode.ColorAttachment0);

				SnapshotOsd(w, h);

			} finally {
				if (renderbuffer != 0)
					Gl.DeleteRenderbuffers(renderbuffer);
				if (framebuffer != 0)
					Gl.DeleteFramebuffers(framebuffer);
				if (glContext != IntPtr.Zero)
					deviceContext.DeleteContext(glContext);
			}
		}

		private static void RenderOsdPBuffer(DeviceContext deviceContext)
		{
			IntPtr glContext = IntPtr.Zero;
			uint framebuffer = 0;
			uint renderbuffer = 0;

			try {
				// Create context and make current on this thread
				if ((glContext = deviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
					throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error()); // XXX
				deviceContext.MakeCurrent(glContext);

				// Create framebuffer resources
				int w = Math.Min(800, 800);
				int h = Math.Min(600, 800);

				RenderOsd(w, h);
				SnapshotOsd(w, h);

			} finally {
				if (renderbuffer != 0)
					Gl.DeleteRenderbuffers(renderbuffer);
				if (framebuffer != 0)
					Gl.DeleteFramebuffers(framebuffer);
				if (glContext != IntPtr.Zero)
					deviceContext.DeleteContext(glContext);
			}
		}

		private static void RenderOsd(int w, int h)
		{
			Gl.Viewport(0, 0, w, h);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);
			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();

			Gl.Begin(PrimitiveType.Triangles);
			Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
			Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
			Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
			Gl.End();
		}

		private static void SnapshotOsd(int w, int h)
		{
			using (Bitmap bitmap = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb)) {
				BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				try {
					Gl.ReadPixels(0, 0, w, h, OpenGL.PixelFormat.Rgb, PixelType.UnsignedByte, bitmapData.Scan0);
				} finally {
					bitmap.UnlockBits(bitmapData);
				}

				bitmap.Save("Snapshot.png");
			}
		}
	}
}
