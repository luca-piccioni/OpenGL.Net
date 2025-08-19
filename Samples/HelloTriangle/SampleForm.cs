
// Copyright (C) 2016-2018 Luca Piccioni
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
using System.Windows.Forms;
using System.Text;

using Khronos;
using OpenGL;

namespace HelloTriangle
{
	/// <summary>
	/// Sample drawing a simple, rotating and colored triangle.
	/// </summary>
	/// <remarks>
	/// Supports:
	/// - OpenGL 3.2
	/// - OpenGL 1.1/1.0 (deprecated)
	/// - OpenGL ES2
	/// </remarks>
	public partial class SampleForm : Form
	{
		#region Constructors

		/// <summary>
		/// Construct a SampleForm.
		/// </summary>
		public SampleForm()
		{
			InitializeComponent();
		}

        #endregion

        #region Event Handling

        /// <summary>
        /// Allocate GL resources or GL states.
        /// </summary>
        /// <param name="sender">
        /// The <see cref="object"/> that has rasied the event.
        /// </param>
        /// <param name="e">
        /// The <see cref="GlControlEventArgs"/> that specifies the event arguments.
        /// </param>
        private void RenderControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			GlControl glControl = (GlControl)sender;
            _debugProc = GLDebugProc;

            // GL Debugging
            if (Gl.CurrentExtensions != null && Gl.CurrentExtensions.DebugOutput_ARB) {
				Gl.DebugMessageCallback(_debugProc, IntPtr.Zero);
				Gl.DebugMessageControl(DebugSource.DontCare, DebugType.DontCare, DebugSeverity.DontCare, 0, null, true);
			}

			// Allocate resources and/or setup GL states
			switch (Gl.CurrentVersion.Api) {
				case KhronosVersion.ApiGl:
					if      (Gl.CurrentVersion >= Gl.Version_320)
						RenderControl_CreateGL320();
					else
						RenderControl_CreateGL100();
					break;
				case KhronosVersion.ApiGles2:
					RenderControl_CreateGLES2();
					break;
			}

			// Uses multisampling, if available
			if (Gl.CurrentVersion != null && Gl.CurrentVersion.Api == KhronosVersion.ApiGl && glControl.MultisampleBits > 0)
				Gl.Enable(EnableCap.Multisample);
		}

		private void RenderControl_Render(object sender, GlControlEventArgs e)
		{
			// Common GL commands
			Control senderControl = (Control)sender;

			Gl.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			switch (Gl.CurrentVersion.Api) {
				case KhronosVersion.ApiGl:
					if      (Gl.CurrentVersion >= Gl.Version_320)
						RenderControl_RenderGL320();
					else if (Gl.CurrentVersion >= Gl.Version_110)
						RenderControl_RenderGL110();
					else
						RenderControl_RenderGL100();
					break;
				case KhronosVersion.ApiGles2:
					RenderControl_RenderGLES2();
					break;
			}
		}

		private void RenderControl_ContextUpdate(object sender, GlControlEventArgs e)
		{
			// Change triangle rotation
			_Angle = (_Angle + 0.1f) % 45.0f;
		}

		private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
		{
			_Program?.Dispose();
			_VertexArray?.Dispose();
		}

		private static void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam)
		{
			string strMessage;

			// Decode message string
			unsafe {
				strMessage = Encoding.ASCII.GetString((byte*)message.ToPointer(), length);
			}

			Console.WriteLine($"{source}, {type}, {severity}: {strMessage}");
		}

		#endregion

		#region Immediate Mode

		// Note: this methods are written for didactic purposes; they use old fixed pipeline methods, and
		// should be used.

		/// <summary>
		/// Setup GL state for OpenGL 1.1/1.0.
		/// </summary>
		private void RenderControl_CreateGL100()
		{
			// Setup projection matrix, only once since it remains fixed for the application lifetime

			// Projection matrix selector
			Gl.MatrixMode(MatrixMode.Projection);
			// Load (reset) to identity
			Gl.LoadIdentity();
			// Multiply with orthographic projection
			Gl.Ortho(0.0, 1.0, 0.0, 1.0, 0.0, 1.0);
		}

		/// <summary>
		/// Old school OpenGL 1.0 drawing.
		/// </summary>
		private void RenderControl_RenderGL100()
		{
			// Setup model-view matrix

			// Model-view matrix selector
			Gl.MatrixMode(MatrixMode.Modelview);
			// Load (reset) to identity
			Gl.LoadIdentity();
			// Multiply with rotation matrix (around Z axis)
			Gl.Rotate(_Angle, 0.0f, 0.0f, 1.0f);

			// Draw triangle using immediate mode (8 draw call)

			// Start drawing triangles
			Gl.Begin(PrimitiveType.Triangles);

			// Feed triangle data: color and position
			// Note: vertex attributes (color, texture coordinates, ...) are specified before position information
			// Note: vertex data is passed using method calls (performance killer!)
			Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
			Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
			Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);

			// Triangles ends
			Gl.End();
		}

		/// <summary>
		/// Old school OpenGL 1.1 drawing.
		/// </summary>
		private void RenderControl_RenderGL110()
		{
			// Setup model-view matrix (as previously)

			// Model-view matrix selector
			Gl.MatrixMode(MatrixMode.Modelview);
			// Load (reset) to identity
			Gl.LoadIdentity();
			// Multiply with rotation matrix (around Z axis)
			Gl.Rotate(_Angle, 0.0f, 0.0f, 1.0f);

			// Draw triangle using immediate mode

			// Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
			using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition)) 
			using (MemoryLock vertexColorLock = new MemoryLock(_ArrayColor))
			{
				// Note: the use of MemoryLock objects is necessary to pin vertex arrays since they can be reallocated by GC
				// at any time between the Gl.VertexPointer execution and the Gl.DrawArrays execution

				// Set current client memory pointer for position: a vertex of 2 floats
				Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
				// Position is used for drawing
				Gl.EnableClientState(EnableCap.VertexArray);

				// Set current client memory pointer for color: a vertex of 3 floats
				Gl.ColorPointer(3, (ColorPointerType)Gl.FLOAT, 0, vertexColorLock.Address);
				// Color is used for drawing
				Gl.EnableClientState(EnableCap.ColorArray);

				// Note: enabled client state and client memory pointers are a GL state, and theorically they could be
				// set only at creation time. However, memory should be pinned for application lifetime.

				// Start drawing triangles (3 vertices -> 1 triangle)
				// Note: vertex attributes are streamed from client memory to GPU
				Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
			}
		}

		#endregion

		#region Common Shading

		// Note: abstractions for drawing using programmable pipeline.

		/// <summary>
		/// Shader object abstraction.
		/// </summary>
		private class Object : IDisposable
		{
			public Object(ShaderType shaderType, string[] source)
			{
				if (source == null)
					throw new ArgumentNullException(nameof(source));

				// Create
				ShaderName = Gl.CreateShader(shaderType);
				// Submit source code
				Gl.ShaderSource(ShaderName, source);
				// Compile
				Gl.CompileShader(ShaderName);
				// Check compilation status
				int compiled;

				Gl.GetShader(ShaderName, ShaderParameterName.CompileStatus, out compiled);
				if (compiled != 0)
					return;

				// Throw exception on compilation errors
				const int logMaxLength = 1024;

				StringBuilder infolog = new StringBuilder(logMaxLength);
				int infologLength;

				Gl.GetShaderInfoLog(ShaderName, logMaxLength, out infologLength, infolog);

				throw new InvalidOperationException($"unable to compile shader: {infolog}");
			}

			public readonly uint ShaderName;

			public void Dispose()
			{
				Gl.DeleteShader(ShaderName);
			}
		}

		/// <summary>
		/// Program abstraction.
		/// </summary>
		private class Program : IDisposable
		{
			public Program(string[] vertexSource, string[] fragmentSource)
			{
				// Create vertex and frament shaders
				// Note: they can be disposed after linking to program; resources are freed when deleting the program
				using (Object vObject = new Object(ShaderType.VertexShader, vertexSource))
				using (Object fObject = new Object(ShaderType.FragmentShader, fragmentSource))
				{
					// Create program
					ProgramName = Gl.CreateProgram();
					// Attach shaders
					Gl.AttachShader(ProgramName, vObject.ShaderName);
					Gl.AttachShader(ProgramName, fObject.ShaderName);
					// Link program
					Gl.LinkProgram(ProgramName);

					// Check linkage status
					int linked;

					Gl.GetProgram(ProgramName, ProgramProperty.LinkStatus, out linked);

					if (linked == 0) {
						const int logMaxLength = 1024;

						StringBuilder infolog = new StringBuilder(logMaxLength);
						int infologLength;

						Gl.GetProgramInfoLog(ProgramName, 1024, out infologLength, infolog);

						throw new InvalidOperationException($"unable to link program: {infolog}");
					}
					
					// Get uniform locations
					if ((LocationMVP = Gl.GetUniformLocation(ProgramName, "uMVP")) < 0)
						throw new InvalidOperationException("no uniform uMVP");

					// Get attributes locations
					if ((LocationPosition = Gl.GetAttribLocation(ProgramName, "aPosition")) < 0)
						throw new InvalidOperationException("no attribute aPosition");
					if ((LocationColor = Gl.GetAttribLocation(ProgramName, "aColor")) < 0)
						throw new InvalidOperationException("no attribute aColor");
				}
			}

			public readonly uint ProgramName;

			public readonly int LocationMVP;

			public readonly int LocationPosition;

			public readonly int LocationColor;

			public void Dispose()
			{
				Gl.DeleteProgram(ProgramName);
			}
		}

		/// <summary>
		/// Buffer abstraction.
		/// </summary>
		private class Buffer : IDisposable
		{
			public Buffer(float[] buffer)
			{
				if (buffer == null)
					throw new ArgumentNullException(nameof(buffer));

				// Generate a buffer name: buffer does not exists yet
				BufferName = Gl.GenBuffer();
				// First bind create the buffer, determining its type
				Gl.BindBuffer(BufferTarget.ArrayBuffer, BufferName);
				// Set buffer information, 'buffer' is pinned automatically
				Gl.BufferData(BufferTarget.ArrayBuffer, (uint)(4 * buffer.Length), buffer, BufferUsage.StaticDraw);
			}

			public readonly uint BufferName;

			public void Dispose()
			{
				Gl.DeleteBuffers(BufferName);
			}
		}

		/// <summary>
		/// Vertex array abstraction.
		/// </summary>
		private class VertexArray : IDisposable
		{
			public VertexArray(Program program, float[] positions, float[] colors)
			{
				if (program == null)
					throw new ArgumentNullException(nameof(program));

				// Allocate buffers referenced by this vertex array
				_BufferPosition = new Buffer(positions);
				_BufferColor = new Buffer(colors);
				
				// Generate VAO name
				ArrayName = Gl.GenVertexArray();
				// First bind create the VAO
				Gl.BindVertexArray(ArrayName);

				// Set position attribute

				// Select the buffer object
				Gl.BindBuffer(BufferTarget.ArrayBuffer, _BufferPosition.BufferName);
				// Format the vertex information: 2 floats from the current buffer
				Gl.VertexAttribPointer((uint)program.LocationPosition, 2, VertexAttribPointerType.Float, false, 0, IntPtr.Zero);
				// Enable attribute
				Gl.EnableVertexAttribArray((uint)program.LocationPosition);

				// As above, but for color attribute
				Gl.BindBuffer(BufferTarget.ArrayBuffer, _BufferColor.BufferName);
				Gl.VertexAttribPointer((uint)program.LocationColor, 3, VertexAttribPointerType.Float, false, 0, IntPtr.Zero);
				Gl.EnableVertexAttribArray((uint)program.LocationColor);
			}

			public readonly uint ArrayName;

			private readonly Buffer _BufferPosition;

			private readonly Buffer _BufferColor;

			public void Dispose()
			{
				Gl.DeleteVertexArrays(ArrayName);

				_BufferPosition.Dispose();
				_BufferColor.Dispose();
			}
		}

		/// <summary>
		/// The program used for drawing the triangle.
		/// </summary>
		private Program _Program;

		/// <summary>
		/// The vertex arrays used for drawing the triangle.
		/// </summary>
		private VertexArray _VertexArray;

		#endregion

		#region Shaders

		private void RenderControl_CreateGL320()
		{
			_Program = new Program(_VertexSourceGL, _FragmentSourceGL);
			_VertexArray = new VertexArray(_Program, _ArrayPosition, _ArrayColor);
		}

		private void RenderControl_RenderGL320()
		{
			// Compute the model-view-projection on CPU
			Matrix4x4f projection = Matrix4x4f.Ortho2D(-1.0f, +1.0f, -1.0f, +1.0f);
			Matrix4x4f modelview = Matrix4x4f.Translated(-0.5f, -0.5f, 0.0f) * Matrix4x4f.RotatedZ(_Angle);

			// Select the program for drawing
			Gl.UseProgram(_Program.ProgramName);
			// Set uniform state
			Gl.UniformMatrix4f(_Program.LocationMVP, 1, false, projection * modelview);
			// Use the vertex array
			Gl.BindVertexArray(_VertexArray.ArrayName);
			// Draw triangle
			// Note: vertex attributes are streamed from GPU memory
			Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
		}

		private readonly string[] _VertexSourceGL = {
			"#version 150 compatibility\n",
			"uniform mat4 uMVP;\n",
			"in vec2 aPosition;\n",
			"in vec3 aColor;\n",
			"out vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
			"	vColor = aColor;\n",
			"}\n"
		};

		private readonly string[] _FragmentSourceGL = {
			"#version 150 compatibility\n",
			"in vec3 vColor;\n",
			"void main() {\n",
			"	gl_FragColor = vec4(vColor, 1.0);\n",
			"}\n"
		};

		#endregion

		#region Shaders (ES2)

		private void RenderControl_CreateGLES2()
		{
			// Create program
			_Program = new Program(_VertexSourceGLES2, _FragmentSourceGLES2);
		}

		private void RenderControl_RenderGLES2()
		{
			Matrix4x4f projection = Matrix4x4f.Ortho2D(0.0f, 1.0f, 0.0f, 1.0f);
			Matrix4x4f modelview = Matrix4x4f.RotatedZ(_Angle);

			Gl.UseProgram(_Program.ProgramName);

			using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
			using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
			{
				Gl.VertexAttribPointer((uint)_Program.LocationPosition, 2, VertexAttribPointerType.Float, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray((uint)_Program.LocationPosition);

				Gl.VertexAttribPointer((uint)_Program.LocationColor, 3, VertexAttribPointerType.Float, false, 0, arrayColor.Address);
				Gl.EnableVertexAttribArray((uint)_Program.LocationColor);

				Gl.UniformMatrix4f(_Program.LocationMVP, 1, false, projection * modelview);

				Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
			}
		}

		private readonly string[] _VertexSourceGLES2 = {
			"uniform mat4 uMVP;\n",
			"attribute vec2 aPosition;\n",
			"attribute vec3 aColor;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
			"	vColor = aColor;\n",
			"}\n"
		};

		private readonly string[] _FragmentSourceGLES2 = {
			"precision mediump float;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_FragColor = vec4(vColor, 1.0);\n",
			"}\n"
		};

		#endregion

		#region Common Data

		private static float _Angle;

		/// <summary>
		/// Vertex position array.
		/// </summary>
		private static readonly float[] _ArrayPosition = new float[] {
			0.0f, 0.0f,
			1.0f, 0.0f,
			1.0f, 1.0f
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

        Gl.DebugProc _debugProc;
    }
}
