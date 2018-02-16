
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
using System.Text;

using Khronos;
using OpenGL;

namespace HelloTriangle.VideoCore
{
	class Program
	{
		static void Main()
		{
			try {
				string envDebug = Environment.GetEnvironmentVariable("DEBUG");
				if (envDebug == "GL") {
					Khronos.KhronosApi.Log += delegate(object sender, KhronosLogEventArgs e) {
						Console.WriteLine(e.ToString());
					};
					Khronos.KhronosApi.LogEnabled = true;
				}

				// RPi runs on EGL
				Egl.IsRequired = true;

				if (Egl.IsAvailable == false)
					throw new InvalidOperationException("EGL is not available. Aborting.");

				using (VideoCoreWindow nativeWindow = new VideoCoreWindow()) {
					using (DeviceContext eglContext = DeviceContext.Create(nativeWindow.Display, nativeWindow.Handle)) {

						eglContext.ChoosePixelFormat(new DevicePixelFormat(32));

						IntPtr glContext = eglContext.CreateContext(IntPtr.Zero);

						eglContext.MakeCurrent(glContext);

						Initialize();

						Gl.Viewport(0, 0, 1920, 1080);
						Gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);

						while (true) {
							Gl.Clear(ClearBufferMask.ColorBufferBit);
							Draw();
							eglContext.SwapBuffers();
							break;
						}
						
						System.Threading.Thread.Sleep(10000);

						Terminate();
						eglContext.DeleteContext(glContext);
					}
				}
				
			} catch (Exception exception) {
				Console.WriteLine(exception.ToString());
			}
		}

		private static void Initialize()
		{
			// Create resources
			StringBuilder infolog = new StringBuilder(1024);
			int infologLength;
			int compiled;

			infolog.EnsureCapacity(1024);

			// Vertex shader
			uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
			Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
			Gl.CompileShader(vertexShader);
			Gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(vertexShader, 1024, out infologLength, infolog);
			}

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
			Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
			Gl.CompileShader(fragmentShader);
			Gl.GetShader(fragmentShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(fragmentShader, 1024, out infologLength, infolog);
			}

			// Program
			_Es2_Program = Gl.CreateProgram();
			Gl.AttachShader(_Es2_Program, vertexShader);
			Gl.AttachShader(_Es2_Program, fragmentShader);
			Gl.LinkProgram(_Es2_Program);

			int linked;
			Gl.GetProgram(_Es2_Program, ProgramProperty.LinkStatus, out linked);

			if (linked == 0) {
				Gl.GetProgramInfoLog(_Es2_Program, 1024, out infologLength, infolog);
			}

			_Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
			_Es2_Program_Location_aPosition = Gl.GetAttribLocation(_Es2_Program, "aPosition");
			_Es2_Program_Location_aColor = Gl.GetAttribLocation(_Es2_Program, "aColor");
		}

		private static void Draw()
		{
			Gl.Viewport(0, 0, 1920, 1080);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Gl.UseProgram(_Es2_Program);

			using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
			using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
			{
				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aPosition, 2, VertexAttribType.Float, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aPosition);

				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aColor, 3, VertexAttribType.Float, false, 0, arrayColor.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aColor);

				Gl.UniformMatrix4f(_Es2_Program_Location_uMVP, 1, false, Matrix4x4f.Ortho(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f));

				Gl.DrawArrays(PrimitiveType.Triangles,  0, 3);
			}
		}

		private static void Terminate()
		{
			if (_Es2_Program != 0)
				Gl.DeleteProgram(_Es2_Program);
			_Es2_Program = 0;
		}

		private static uint _Es2_Program;

		private static int _Es2_Program_Location_aPosition;

		private static int _Es2_Program_Location_aColor;

		private static int _Es2_Program_Location_uMVP;

		private static readonly string[] _Es2_ShaderVertexSource = new string[] {
			"uniform mat4 uMVP;\n",
			"attribute vec2 aPosition;\n",
			"attribute vec3 aColor;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
			"	vColor = aColor;\n",
			"}\n"
		};

		private static readonly string[] _Es2_ShaderFragmentSource = new string[] {
			"precision mediump float;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_FragColor = vec4(vColor, 1.0);\n",
			"}\n"
		};

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
		private static readonly float[] _ArrayColor = new float[] {
			1.0f, 0.0f, 0.0f,
			0.0f, 1.0f, 0.0f,
			0.0f, 0.0f, 1.0f
		};
	}
}
