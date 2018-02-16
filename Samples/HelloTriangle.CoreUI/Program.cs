
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
using System.Text;

using OpenGL;
using OpenGL.CoreUI;

namespace HelloTriangle.CoreUI
{
	static class Program
	{
		#region Application Entry Point

		[STAThread()]
		static void Main(string[] args)
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextCreated += NativeWindow_ContextCreated;
				nativeWindow.Render += NativeWindow_Render;
				nativeWindow.KeyDown += (object obj, NativeWindowKeyEventArgs e) => {
					switch (e.Key) {
						case KeyCode.Escape:
							nativeWindow.Stop();
							break;

						case KeyCode.F:
							nativeWindow.Fullscreen = !nativeWindow.Fullscreen;
							break;
					}
				};
				nativeWindow.Animation = true;

				nativeWindow.Create(0, 0, 128, 128, NativeWindowStyle.Overlapped);

				nativeWindow.Show();
				nativeWindow.Run();
			}
		}

		#endregion

		#region Event Handling

		private static void NativeWindow_ContextCreated(object sender, NativeWindowEventArgs e)
		{
			NativeWindow nativeWindow = (NativeWindow)sender;

			Gl.ReadBuffer(ReadBufferMode.Back);

			Gl.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);

			Gl.Enable(EnableCap.Blend);
			Gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

			Gl.LineWidth(2.5f);

			CreateResources();
		}

		private static void NativeWindow_Render(object sender, NativeWindowEventArgs e)
		{
			NativeWindow nativeWindow = (NativeWindow)sender;

			Gl.Viewport(0, 0, (int)nativeWindow.Width, (int)nativeWindow.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Gl.UseProgram(_CubeEdgeProgram);
			
			// Compute MVP
			Matrix4x4f proj = Matrix4x4f.Perspective(60.0f, (float)nativeWindow.Width / nativeWindow.Height, 0.5f, 1e6f);
			Matrix4x4f view = Matrix4x4f.LookAt(Vertex3f.One * 7.0f, Vertex3f.Zero, Vertex3f.UnitY);
			Matrix4x4f model = Matrix4x4f.RotatedY(_Angle) * Matrix4x4f.RotatedZ(_Angle);

			Gl.BindVertexArray(_CubeVao);

			Gl.UniformMatrix4f(_CubeEdgeProgram_Location_uMVP, 1, false, proj * view * model);

			foreach (float scale4d in new float[] { 64.0f, 32.0f, 16.0f, 8.0f, 4.0f, 2.0f, 1.0f, 0.5f, 0.25f, 0.125f }) {
				Gl.Uniform1(_CubeEdgeProgram_Location_uScale4D, scale4d * _Zooom);
				Gl.Uniform4(_CubeEdgeProgram_Location_uColor, 0.0f, 0.3f, 1.0f, Math.Min(1.0f, scale4d * _Zooom / 2.0f));
				Gl.DrawElements(PrimitiveType.Lines, _CubeEdges.Length, DrawElementsType.UnsignedShort, IntPtr.Zero);
			}

			_Angle += 360.0f / (25.0f * 5);
			_Zooom -= 0.025f;

			if (_Zooom < 0.5f)
				_Zooom = 1.0f;

			// Save PNG frame
			//if (_FrameNo < 125) {
			//	using (Bitmap bitmap = new Bitmap((int)nativeWindow.Width, (int)nativeWindow.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb)) {
			//		BitmapData bitmapData = bitmap.LockBits(new Rectangle(System.Drawing.Point.Empty, bitmap.Size), ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

			//		Gl.ReadPixels(0, 0, (int)nativeWindow.Width, (int)nativeWindow.Height, OpenGL.PixelFormat.Bgr, PixelType.UnsignedByte, bitmapData.Scan0);

			//		bitmap.Save(String.Format("Frame_{0:D3}.png", _FrameNo++));
			//	}
			//}
		}

		#endregion

		#region Tesseract

		private static float _Angle;

		private static float _Zooom = 1.0f;

		private static uint _FrameNo = 0;

		private static void CreateResources()
		{
			CreateCubeEdgeProgram();
			CreateCubeEdgeVertexArray();
		}

		private static void CreateCubeEdgeProgram()
		{
			StringBuilder infolog = new StringBuilder(1024);
			int infologLength;
			int compiled;

			infolog.EnsureCapacity(1024);

			// Vertex shader
			uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
			Gl.ShaderSource(vertexShader, _CubeEdgeProgramVertexSource);
			Gl.CompileShader(vertexShader);
			Gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(vertexShader, 1024, out infologLength, infolog);
			}

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
			Gl.ShaderSource(fragmentShader, _CubeEdgeProgramFragmentSource);
			Gl.CompileShader(fragmentShader);
			Gl.GetShader(fragmentShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(fragmentShader, 1024, out infologLength, infolog);
			}

			// Program
			_CubeEdgeProgram = Gl.CreateProgram();
			Gl.AttachShader(_CubeEdgeProgram, vertexShader);
			Gl.AttachShader(_CubeEdgeProgram, fragmentShader);
			Gl.LinkProgram(_CubeEdgeProgram);

			int linked;
			Gl.GetProgram(_CubeEdgeProgram, ProgramProperty.LinkStatus, out linked);

			if (linked == 0) {
				Gl.GetProgramInfoLog(_CubeEdgeProgram, 1024, out infologLength, infolog);
			}

			_CubeEdgeProgram_Location_uMVP = Gl.GetUniformLocation(_CubeEdgeProgram, "uMVP");
			_CubeEdgeProgram_Location_uScale4D = Gl.GetUniformLocation(_CubeEdgeProgram, "uScale4D");
			_CubeEdgeProgram_Location_uColor = Gl.GetUniformLocation(_CubeEdgeProgram, "uColor");
			_CubeEdgeProgram_Location_aPosition = Gl.GetAttribLocation(_CubeEdgeProgram, "aPosition");
		}

		private static void CreateCubeEdgeVertexArray()
		{
			_CubeVao = Gl.GenVertexArray();
			Gl.BindVertexArray(_CubeVao);

			_CubeVerticesBuffer = Gl.GenBuffer();
			Gl.BindBuffer(BufferTarget.ArrayBuffer, _CubeVerticesBuffer);
			Gl.BufferData(BufferTarget.ArrayBuffer, (uint)(Vertex3f.Size * _CubeVertices.Length), _CubeVertices, BufferUsage.StaticDraw);

			Gl.EnableVertexAttribArray(0);
			Gl.VertexAttribPointer(0, 3, VertexAttribType.Float, false, 0, IntPtr.Zero);

			_CubeEdgesBuffer = Gl.GenBuffer();
			Gl.BindBuffer(BufferTarget.ElementArrayBuffer, _CubeEdgesBuffer);
			Gl.BufferData(BufferTarget.ElementArrayBuffer, (uint)(2 * _CubeEdges.Length), _CubeEdges, BufferUsage.StaticDraw);
		}

		private static void ReleaseResouces()
		{
			Gl.DeleteBuffers(_CubeVerticesBuffer, _CubeEdgesBuffer);
			Gl.DeleteVertexArrays(_CubeVao);
		}

		private static uint _CubeEdgeProgram;

		private static int _CubeEdgeProgram_Location_uMVP;

		private static int _CubeEdgeProgram_Location_uScale4D;

		private static int _CubeEdgeProgram_Location_uColor;

		private static int _CubeEdgeProgram_Location_aPosition;

		private static readonly string[] _CubeEdgeProgramVertexSource = new string[] {
			"#version 330\n",
			"uniform mat4 uMVP;\n",
			"uniform float uScale4D = 1.0;\n",
			"in vec3 aPosition;\n",
			"out vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, uScale4D);\n",
			"}\n"
		};

		private static readonly string[] _CubeEdgeProgramFragmentSource = new string[] {
			"#version 330\n",
			"uniform vec4 uColor = vec4(1.0);\n",
			"void main() {\n",
			"	gl_FragColor = uColor;\n",
			"}\n"
		};

		private static uint _CubeVerticesBuffer;

		private static uint _CubeEdgesBuffer;

		private static uint _CubeVao;

		private static Vertex3f[] _CubeVertices = new Vertex3f[] {
			new Vertex3f(-1.0f, -1.0f, -1.0f),
			new Vertex3f(+1.0f, -1.0f, -1.0f),
			new Vertex3f(+1.0f, +1.0f, -1.0f),
			new Vertex3f(-1.0f, +1.0f, -1.0f),
			new Vertex3f(-1.0f, -1.0f, +1.0f),
			new Vertex3f(+1.0f, -1.0f, +1.0f),
			new Vertex3f(+1.0f, +1.0f, +1.0f),
			new Vertex3f(-1.0f, +1.0f, +1.0f),
		};

		private static ushort[] _CubeEdges = new ushort[] {
			0, 1, 1, 2, 2, 3, 3, 0,
			4, 5, 5, 6, 6, 7, 7, 4,
			0, 4, 1, 5, 2, 6, 3, 7
		};

		#endregion
	}
}
