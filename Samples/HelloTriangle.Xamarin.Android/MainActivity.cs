
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

using Android.App;
using Android.OS;
using Android.Content.PM;

using OpenGL;

namespace HelloTriangle.Xamarin
{
	[Activity(Label = "HelloTriangle.Xamarin", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden)]
	public class MainActivity : Activity
	{
		#region Rendering

		private void SurfaceView_ContextCreated(object sender, GLSurfaceViewEventArgs e)
		{
			Es2_ContextCreated();
		}

		private void SurfaceView_Render(object sender, GLSurfaceViewEventArgs e)
		{
			GLSurfaceView glSurfaceView = (GLSurfaceView)sender;

			Gl.Viewport(0, 0, glSurfaceView.Width, glSurfaceView.Height);
			Gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Es2_Render();
		}

		private void SurfaceView_ContextDestroying(object sender, GLSurfaceViewEventArgs e)
		{
			Es2_ContextDestroying();
		}

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

		#endregion

		#region Rendering (ES 2.0)

		private void Es2_ContextCreated()
		{
			// Vertex shader
			uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
			Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
			Gl.CompileShader(vertexShader);

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
			Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
			Gl.CompileShader(fragmentShader);

			// Program
			_Es2_Program = Gl.CreateProgram();
			Gl.AttachShader(_Es2_Program, vertexShader);
			Gl.AttachShader(_Es2_Program, fragmentShader);
			Gl.LinkProgram(_Es2_Program);

			// Check for linking errors
			int lStatus;

			Gl.GetProgram(_Es2_Program, ProgramProperty.LinkStatus, out lStatus);

			if (lStatus != Gl.TRUE) {
				const int MaxInfoLength = 4096;

				StringBuilder logInfo = new StringBuilder(MaxInfoLength);
				int logLength;

				// Obtain compilation log
				Gl.GetProgramInfoLog(_Es2_Program, MaxInfoLength, out logLength, logInfo);

				// Stop link process
				StringBuilder sb = new StringBuilder(logInfo.Capacity);

				string[] compilerLogLines = logInfo.ToString().Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
				foreach (string logLine in compilerLogLines)
					sb.AppendLine("  $ " + logLine);

				throw new InvalidOperationException(sb.ToString());
			}
			_Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
			_Es2_Program_Location_aPosition = Gl.GetAttribLocation(_Es2_Program, "aPosition");
			_Es2_Program_Location_aColor = Gl.GetAttribLocation(_Es2_Program, "aColor");
		}

		private void Es2_Render()
		{
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

		private void Es2_ContextDestroying()
		{
			if (_Es2_Program != 0)
				Gl.DeleteProgram(_Es2_Program);
			_Es2_Program = 0;
		}

		private uint _Es2_Program;

		private int _Es2_Program_Location_aPosition;

		private int _Es2_Program_Location_aColor;

		private int _Es2_Program_Location_uMVP;

		private readonly string[] _Es2_ShaderVertexSource = new string[] {
			"uniform mat4 uMVP;\n",
			"attribute vec2 aPosition;\n",
			"attribute vec3 aColor;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
			"	vColor = aColor;\n",
			"}\n"
		};

		private readonly string[] _Es2_ShaderFragmentSource = new string[] {
			"precision mediump float;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_FragColor = vec4(vColor, 1.0);\n",
			"}\n"
		};

		#endregion

		#region Activity Overrides

		protected override void OnCreate(Bundle bundle)
		{
			// Base implementation
			base.OnCreate(bundle);

			// Surface view
			GLSurfaceView surfaceView = new GLSurfaceView(this);

			surfaceView.ContextCreated += SurfaceView_ContextCreated;
			surfaceView.Render += SurfaceView_Render;
			surfaceView.ContextDestroying += SurfaceView_ContextDestroying;
			
			SetContentView(surfaceView);
		}

		#endregion
	}
}

