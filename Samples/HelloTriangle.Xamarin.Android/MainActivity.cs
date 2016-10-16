
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

		private void SurfaceView_ContextCreated(object sender, GlSurfaceViewEventArgs e)
		{
			Es2_ContextCreated();
		}

		private void SurfaceView_Render(object sender, GlSurfaceViewEventArgs e)
		{
			GLSurfaceView glSurfaceView = (GLSurfaceView)sender;

			Gl.Viewport(0, 0, glSurfaceView.Width, glSurfaceView.Height);
			Gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Es2_Render();
		}

		private void SurfaceView_ContextDestroying(object sender, GlSurfaceViewEventArgs e)
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
			uint vertexShader = Gl.CreateShader(Gl.VERTEX_SHADER);
			Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
			Gl.CompileShader(vertexShader);

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(Gl.FRAGMENT_SHADER);
			Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
			Gl.CompileShader(fragmentShader);

			// Program
			_Es2_Program = Gl.CreateProgram();
			Gl.AttachShader(_Es2_Program, vertexShader);
			Gl.AttachShader(_Es2_Program, fragmentShader);
			Gl.LinkProgram(_Es2_Program);

			_Es2_Program_Location_vPosition = Gl.GetAttribLocation(_Es2_Program, "vPosition");
			_Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
		}

		private void Es2_Render()
		{
			OrthoProjectionMatrix projectionMatrix = new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f);

			Gl.UseProgram(_Es2_Program);

			using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition)) {
				Gl.VertexAttribPointer((uint)_Es2_Program_Location_vPosition, 3, Gl.FLOAT, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_vPosition);

				if (_Es2_Program_Location_uMVP != -1)
					Gl.UniformMatrix4(_Es2_Program_Location_uMVP, 1, false, projectionMatrix.ToArray());

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

		private int _Es2_Program_Location_vPosition;

		private int _Es2_Program_Location_uMVP;

		private readonly string[] _Es2_ShaderVertexSource = new string[] {
			"uniform mat4 uMVP;\n",
			"attribute vec2 vPosition;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(vPosition, 0.0, 1.0);\n",
			"}\n"
		};

		private readonly string[] _Es2_ShaderFragmentSource = new string[] {
			"void main() {\n",
			"	gl_FragColor = vec4(1.0, 1.0, 1.0, 1.0);\n",
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

