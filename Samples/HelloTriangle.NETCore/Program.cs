using System;

using OpenGL;
using OpenGL.CoreUI;

namespace HelloTriangle.NETCore
{
	class Program
	{
		static void Main(string[] args)
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 256, 256, NativeWindowStyle.Overlapped);
				nativeWindow.Show();
				nativeWindow.Run();
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
					throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error());	// XXX
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
					throw new System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error());	// XXX
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
			//using (Bitmap bitmap = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb)) {
			//	BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			//	try {
			//		Gl.ReadPixels(0, 0, w, h, OpenGL.PixelFormat.Rgb, PixelType.UnsignedByte, bitmapData.Scan0);
			//	} finally {
			//		bitmap.UnlockBits(bitmapData);
			//	}

			//	bitmap.Save("Snapshot.png");
			//}
		}
	}
}