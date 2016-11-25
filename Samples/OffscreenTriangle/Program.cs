
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
using System.Drawing.Imaging;

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
				KhronosApi.RegisterApplicationLogDelegate(delegate (string format, object[] args) {
					Console.WriteLine(format, args);
				});
			}

			try {
				if (Gl.CurrentExtensions.FramebufferObject_ARB == false)
					throw new InvalidOperationException("GL_ARB_framebuffer_object not implemented");

				using (DeviceContext deviceContext = DeviceContext.Create()) {
					IntPtr glContext = IntPtr.Zero;
					uint framebuffer = 0;
					uint renderbuffer = 0;

					try {
						// Create context and make current on this thread
						if ((glContext = deviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
							throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error());	// XXX
						deviceContext.MakeCurrent(glContext);

						// Create framebuffer resources
						int w = Math.Min(800, Gl.CurrentLimits.MaxRenderBufferSize);
						int h = Math.Min(600, Gl.CurrentLimits.MaxRenderBufferSize);

						renderbuffer = Gl.GenRenderbuffer();
						Gl.BindRenderbuffer(Gl.RENDERBUFFER, renderbuffer);
						Gl.RenderbufferStorage(Gl.RENDERBUFFER, Gl.RGB8, w, h);

						framebuffer = Gl.GenFramebuffer();
						Gl.BindFramebuffer(Gl.READ_FRAMEBUFFER, framebuffer);
						Gl.BindFramebuffer(Gl.FRAMEBUFFER, framebuffer);
						Gl.FramebufferRenderbuffer(Gl.FRAMEBUFFER, Gl.COLOR_ATTACHMENT0, Gl.RENDERBUFFER, renderbuffer);

						int framebufferStatus = Gl.CheckFramebufferStatus(Gl.FRAMEBUFFER);
						if (framebufferStatus != Gl.FRAMEBUFFER_COMPLETE)
							throw new InvalidOperationException("framebuffer not complete");

						Gl.DrawBuffers(Gl.COLOR_ATTACHMENT0);

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

						Gl.ReadBuffer(ReadBufferMode.ColorAttachment0);

						using (Bitmap bitmap = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb)) {
							BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
							try {
								Gl.ReadPixels(0, 0, w, h, OpenGL.PixelFormat.Rgb, PixelType.UnsignedByte, bitmapData.Scan0);
							} finally {
								bitmap.UnlockBits(bitmapData);
							}

							bitmap.Save("Snapshot.png");
						}

					} finally {
						if (renderbuffer != 0)
							Gl.DeleteRenderbuffers(renderbuffer);
						if (framebuffer != 0)
							Gl.DeleteFramebuffers(framebuffer);
						if (glContext != IntPtr.Zero)
							deviceContext.DeleteContext(glContext);
					}
				}
			} catch (Exception exception) {
				Console.WriteLine("Unexpected exception: {0}", exception.ToString());
			}
		}
	}
}
