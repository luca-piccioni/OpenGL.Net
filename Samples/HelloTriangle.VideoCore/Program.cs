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
				string envDebug = Environment.GetEnvironmentVariable("DEBUG");

				if (envDebug == "GL") {
					KhronosApi.RegisterApplicationLogDelegate(delegate (string format, object[] args) {
						Console.WriteLine(format, args);
					});
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
			uint vertexShader = Gl.CreateShader(Gl.VERTEX_SHADER);
			Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
			Gl.CompileShader(vertexShader);
			Gl.GetShader(vertexShader, Gl.COMPILE_STATUS, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(vertexShader, 1024, out infologLength, infolog);
			}

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(Gl.FRAGMENT_SHADER);
			Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
			Gl.CompileShader(fragmentShader);
			Gl.GetShader(fragmentShader, Gl.COMPILE_STATUS, out compiled);
			if (compiled == 0) {
				Gl.GetShaderInfoLog(fragmentShader, 1024, out infologLength, infolog);
			}

			// Program
			_Es2_Program = Gl.CreateProgram();
			Gl.AttachShader(_Es2_Program, vertexShader);
			Gl.AttachShader(_Es2_Program, fragmentShader);
			Gl.LinkProgram(_Es2_Program);

			int linked;
			Gl.GetProgram(_Es2_Program, Gl.LINK_STATUS, out linked);

			if (linked == 0) {
				Gl.GetProgramInfoLog(_Es2_Program, 1024, out infologLength, infolog);
			}

			_Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
			_Es2_Program_Location_aPosition = Gl.GetAttribLocation(_Es2_Program, "aPosition");
			_Es2_Program_Location_aColor = Gl.GetAttribLocation(_Es2_Program, "aColor");
		}

		private static void Draw()
		{
			OrthoProjectionMatrix projectionMatrix = new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f);

			Gl.Viewport(0, 0, 1920, 1080);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Gl.UseProgram(_Es2_Program);

			using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
			using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
			{
				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aPosition, 2, Gl.FLOAT, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aPosition);

				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aColor, 3, Gl.FLOAT, false, 0, arrayColor.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aColor);

				Gl.UniformMatrix4(_Es2_Program_Location_uMVP, 1, false, projectionMatrix.ToArray());

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
