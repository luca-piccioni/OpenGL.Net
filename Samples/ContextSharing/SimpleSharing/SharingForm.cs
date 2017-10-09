
// Copyright (C) 2017 Luca Piccioni
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
using System.Runtime.InteropServices;
using System.Windows.Forms;

using OpenGL;

namespace SimpleSharing
{
	public partial class SharingForm : Form
	{
		public SharingForm()
		{
			InitializeComponent();
		}

		private uint _SharedTexture;

		private void GlControl1_ContextCreated(object sender, OpenGL.GlControlEventArgs e)
		{
			// Here you can allocate resources or initialize state
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();

			Gl.Enable(EnableCap.Texture2d);

			// Shared resource
			_SharedTexture = Gl.GenTexture();
			Gl.BindTexture(TextureTarget.Texture2d, _SharedTexture);

			Bitmap sharedTexture = new Bitmap(Properties.Resources.Logo);
			BitmapData iBitmapData = null;
			try {
				iBitmapData = sharedTexture.LockBits(new Rectangle(0, 0, sharedTexture.Width, sharedTexture.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, sharedTexture.PixelFormat);

				Gl.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba, sharedTexture.Width, sharedTexture.Height, 0, OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, iBitmapData.Scan0);
			} finally {
				if (iBitmapData != null)
					sharedTexture.UnlockBits(iBitmapData);
			}

			Gl.GenerateMipmap(TextureTarget.Texture2d);
		}

		private void GlControl2_ContextCreated(object sender, OpenGL.GlControlEventArgs e)
		{
			// Here you can allocate resources or initialize state
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(1.0, 0.0f, 1.0, 0.0, 0.0, 1.0);

			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();

			Gl.Enable(EnableCap.Texture2d);
		}

		private void GlControl_Render(object sender, GlControlEventArgs e)
		{
			Control senderControl = (Control)sender;

			Gl.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Gl.Rotate(_Angle, 0.0f, 0.0f, 1.0f);

			// This method is shared between the two GlControl
			// Uses the texture created with the GlControl1 on both controls
			Gl.BindTexture(TextureTarget.Texture2d, _SharedTexture);

			if (Gl.CurrentVersion >= Gl.Version_110) {
				// Old school OpenGL 1.1
				// Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
				using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition)) 
				using (MemoryLock vertexTexCoordLock = new MemoryLock(_ArrayTexCoord))
				{
					Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
					Gl.EnableClientState(EnableCap.VertexArray);

					Gl.TexCoordPointer(2, TexCoordPointerType.Float, 0, vertexTexCoordLock.Address);
					Gl.EnableClientState(EnableCap.TextureCoordArray);

					Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
				}
			} else {
				// Old school OpenGL
				Gl.Begin(PrimitiveType.Triangles);
				for (int i = 0; i < _ArrayPosition.Length; i += 2) {
					Gl.TexCoord2(_ArrayTexCoord[i], _ArrayTexCoord[i+1]);
					Gl.Vertex2(_ArrayPosition[i], _ArrayPosition[i+1]);
				}
				Gl.End();
			}

			_Angle += 1.0f;
		}

		private float _Angle;

		/// <summary>
		/// Vertex position array.
		/// </summary>
		private static readonly float[] _ArrayPosition = new float[] {
			0.0f, 0.0f,
			0.5f, 1.0f,
			1.0f, 0.0f
		};

		/// <summary>
		/// Vertex color array.
		/// </summary>
		private static readonly float[] _ArrayTexCoord = new float[] {
			0.0f, 0.0f,
			0.5f, 1.0f,
			1.0f, 0.0f,
		};
	}
}
