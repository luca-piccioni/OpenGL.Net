using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using OpenGL;

// Dependency under Linux, specifically Ubuntu 16.04: sudo apt install libgles2-mesa-dev

namespace WindowlessTriangle
{
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			string envDebug = Environment.GetEnvironmentVariable("DEBUG");
			if (envDebug == "GL"
			    #if DEBUG
			    || true
			    #endif
			)
			{
				KhronosApi.Log += delegate (object sender, KhronosLogEventArgs e)
				{
					Console.WriteLine(e.ToString());
				};
				KhronosApi.LogEnabled = true;
			}

			try
			{
				Egl.IsRequired = Egl.IsAvailable;

				// Render
				using (var nativeBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 800, 600))
				using (var deviceContext = DeviceContext.Create(nativeBuffer))
				using (var bitmap = new Bitmap(800, 600, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
				{
					Render(deviceContext, bitmap);
					bitmap.Save("Result.png");
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine($"Unexpected exception: {exception}");
			}
		}

		private static void Render(DeviceContext deviceContext, Bitmap result)
		{
			if (deviceContext == null)
			{
				throw new ArgumentNullException(nameof(deviceContext));
			}
			if (result == null)
			{
				throw new ArgumentNullException(nameof(result));
			}

			var glContext = IntPtr.Zero;
			uint framebuffer = 0;
			uint renderbuffer = 0;
			uint shaderProgram = 0;

			try
			{
				// Create context and make current on this thread
				if ((glContext = deviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
				{
					throw new Exception("GL Context creation failed");
				}

				deviceContext.MakeCurrent(glContext);

				// Load shaders;
				var shaderVars = new ShaderVariables();
				shaderProgram = LoadShaders(_vertexShader, _fragmentShader, shaderVars);

				// Create framebuffer resources
				framebuffer = Gl.GenFramebuffer();
				Gl.BindFramebuffer(FramebufferTarget.Framebuffer, framebuffer);

				renderbuffer = Gl.GenRenderbuffer();
				Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, renderbuffer);
				Gl.RenderbufferStorage(RenderbufferTarget.Renderbuffer, InternalFormat.Rgba8, result.Width, result.Height);
				Gl.FramebufferRenderbuffer(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, RenderbufferTarget.Renderbuffer, renderbuffer);

				var status = Gl.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
				if (status != FramebufferStatus.FramebufferComplete)
				{
					Console.WriteLine($"!!!!!! Framebuffer not complete: {status}");
				}

				// Render onto bitmap
				DrawObjects(result.Width, result.Height, shaderProgram, shaderVars);

				var bitmapData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				try
				{
					Gl.ReadPixels(0, 0, result.Width, result.Height, OpenGL.PixelFormat.Rgba, PixelType.UnsignedByte, bitmapData.Scan0);
				}
				finally
				{
					result.UnlockBits(bitmapData);
				}
			}
			finally
			{
				if (shaderProgram != 0)
					Gl.DeleteProgram(shaderProgram);

				Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, 0);
				if (renderbuffer != 0)
					Gl.DeleteRenderbuffers(renderbuffer);

				Gl.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
				if (framebuffer != 0)
					Gl.DeleteFramebuffers(framebuffer);

				if (glContext != IntPtr.Zero)
					deviceContext.DeleteContext(glContext);
			}
		}

		private static void DrawObjects(int w, int h, uint shaderProgram, ShaderVariables shaderVars)
		{
			var projectionMatrix = new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f);

			Gl.Viewport(0, 0, w, h);

			Gl.ClearColor(0.0f, 0.0f, 0.0f, 0.0f); // BGRA because of messed up mismatch between OpenGL and C#: the former is RGBA, the latter is ARGB, and it's really easy to royally confused.
			Gl.ClearDepth(0);
			Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			Gl.UseProgram(shaderProgram);

			using (var arrayPosition = new MemoryLock(_arrayPosition))
			using (var arrayColor = new MemoryLock(_arrayColor))
			{
				Gl.VertexAttribPointer(shaderVars.Attributes["aPosition"], 3, VertexAttribType.Float, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray(shaderVars.Attributes["aPosition"]);

				Gl.VertexAttribPointer(shaderVars.Attributes["aColor"], 4, VertexAttribType.Float, false, 0, arrayColor.Address);
				Gl.EnableVertexAttribArray(shaderVars.Attributes["aColor"]);

				Gl.UniformMatrix4(shaderVars.Uniforms["uMVP"], 1, false, projectionMatrix.ToArray());

				Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
			}
		}

		private static uint LoadShaders(string vertexShaderSource, string fragmentShaderSource, ShaderVariables shaderVars)
		{
			var infolog = new StringBuilder(1024);
			int infologLength;
			int compiled;

			// Vertex shader
			var vertexShader = Gl.CreateShader(ShaderType.VertexShader);
			var shaderLines = vertexShaderSource.Split('\n').Select(line => line.TrimEnd() + "\n").ToArray();
			Gl.ShaderSource(vertexShader, shaderLines);
			Gl.CompileShader(vertexShader);
			Gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == Gl.FALSE)
			{
				Gl.GetShaderInfoLog(vertexShader, 1024, out infologLength, infolog);
			}

			// Fragment shader
			var fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
			Gl.ShaderSource(fragmentShader, fragmentShaderSource.Split('\n').Select(line => line.TrimEnd() + "\n").ToArray());
			Gl.CompileShader(fragmentShader);
			Gl.GetShader(fragmentShader, ShaderParameterName.CompileStatus, out compiled);
			if (compiled == Gl.FALSE)
			{
				Gl.GetShaderInfoLog(fragmentShader, 1024, out infologLength, infolog);
			}

			// Program
			var program = Gl.CreateProgram();
			Gl.AttachShader(program, vertexShader);
			Gl.AttachShader(program, fragmentShader);
			Gl.LinkProgram(program);

			int linked;
			Gl.GetProgram(program, Gl.LINK_STATUS, out linked);
			if (linked == Gl.FALSE)
			{
				Gl.GetProgramInfoLog(program, 1024, out infologLength, infolog);
			}

			// Get and store the variable locations, could do with some error detection.
			var uniformKeys = new List<string>(shaderVars.Uniforms.Keys);
			foreach (var varName in uniformKeys)
			{
				shaderVars.Uniforms[varName] = Gl.GetUniformLocation(program, varName);
			}

			var attributeKeys = new List<string>(shaderVars.Attributes.Keys);
			foreach (var varName in attributeKeys)
			{
				shaderVars.Attributes[varName] = (uint)Gl.GetAttribLocation(program, varName);
			}

			// Clean up
			Gl.DetachShader(program, vertexShader);
			Gl.DetachShader(program, fragmentShader);
			Gl.DeleteShader(vertexShader);
			Gl.DeleteShader(fragmentShader);

			return program;
		}

		private class ShaderVariables
		{
			// Uniforms
			public Dictionary<string, int> Uniforms = new Dictionary<string, int>()
			{
				["uMVP"] = 0,
			};

			// Attributes
			public Dictionary<string, uint> Attributes = new Dictionary<string, uint>()
			{
				["aPosition"] = 0,
				["aColor"] = 0,
			};
		}

		private static string _vertexShader = @"
uniform mat4 uMVP;
attribute vec3 aPosition;
attribute vec4 aColor;
varying vec4 vColor;
void main() {
	gl_Position = uMVP * vec4(aPosition, 1.0);
	vColor = aColor;
}
";

		private static string _fragmentShader = @"
precision mediump float;
varying vec4 vColor;
void main() {
	gl_FragColor = vColor.bgra; /* Swizzle the color to match the Bitmap's color order*/
}
";

		private static readonly float[] _arrayPosition = new float[] {
			0.0f, 0.0f, 0.0f,
			0.5f, 1.0f, 0.0f,
			1.0f, 0.0f, 0.0f,
		};

		private static readonly float[] _arrayColor = new float[] {
			1.0f, 0.0f, 0.0f, 1.0f,
			0.0f, 1.0f, 0.0f, 1.0f,
			0.0f, 0.0f, 1.0f, 1.0f,
		};

	}
}
