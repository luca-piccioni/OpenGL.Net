
using Android.App;
using Android.OS;
using Android.Content.PM;

using OpenGL;

namespace HelloTriangle.Xamarin
{
	[Activity(Label = "HelloTriangle.Xamarin", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden)]
	public class MainActivity : Activity
	{
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

		private void SurfaceView_ContextCreated(object sender, GlSurfaceViewEventArgs e)
		{
			
		}

		private void SurfaceView_Render(object sender, GlSurfaceViewEventArgs e)
		{
			System.Random randon = new System.Random(System.DateTime.UtcNow.Millisecond);
			float c = (float)randon.NextDouble();

			Gl.Viewport(0, 0, 25, 25);
			Gl.ClearColor(c, 0.0f, 0.0f, 1.0f);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			//if (Gl.CurrentVersion >= Gl.Version_110) {
			//	// Old school OpenGL 1.1
			//	// Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
			//	using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition)) 
			//	using (MemoryLock vertexColorLock = new MemoryLock(_ArrayColor))
			//	{
			//		// Note: the use of MemoryLock objects is necessary to pin vertex arrays since they can be reallocated by GC
			//		// at any time between the Gl.VertexPointer execution and the Gl.DrawArrays execution

			//		Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
			//		Gl.EnableClientState(EnableCap.VertexArray);

			//		Gl.ColorPointer(3, ColorPointerType.Float, 0, vertexColorLock.Address);
			//		Gl.EnableClientState(EnableCap.ColorArray);

			//		Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
			//	}
			//} else {
			//	// Old school OpenGL
			//	Gl.Begin(PrimitiveType.Triangles);
			//	Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
			//	Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
			//	Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
			//	Gl.End();
			//}
		}

		private void SurfaceView_ContextDestroying(object sender, GlSurfaceViewEventArgs e)
		{
			
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
	}
}

