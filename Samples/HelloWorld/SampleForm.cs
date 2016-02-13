using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenGL;
using OpenGL.Scene;

namespace HelloNewton
{
	public partial class SampleForm : Form
	{
		public SampleForm()
		{
			InitializeComponent();
		}

		private void SampleGraphicsControl_GraphicsContextCreated(object sender, GraphicsControlEventArgs e)
		{
			GraphicsContext ctx = e.Context;
			GraphicsSurface framebuffer = e.Framebuffer;

#if DEBUG
			_GeometryClipmapObject = new GeometryClipmapObject(4, 4, _BlockUnit);
#else
			_GeometryClipmapObject = new GeometryClipmapObject(7, 7, _BlockUnit);
#endif

			string workingDir = Directory.GetCurrentDirectory();

			_GeometryClipmapObject.SetTerrainElevationFactory(Path.Combine(workingDir, @"..\..\..\Data\Terrain.vrt"), 45.5, 10.5);

			_GeometryClipmapScene = new SceneGraph();
			_GeometryClipmapScene.AddChild(new SceneGraphCameraObject());
			_GeometryClipmapScene.AddChild(_GeometryClipmapObject);
			_GeometryClipmapScene.Create(ctx);

			// Set projection
			PerspectiveProjectionMatrix matrixProjection = new PerspectiveProjectionMatrix();
			matrixProjection.SetPerspective(_ViewFov / 16.0f * 9.0f, (float)ClientSize.Width / (float)ClientSize.Height, 0.1f, 110000.0f);
			_GeometryClipmapScene.CurrentView.ProjectionMatrix = matrixProjection;

			// Clear color
			framebuffer.SetClearColor(new ColorRGBAF(0.0f, 0.0f, 0.0f));
		}

		private void SampleGraphicsControl_Render(object sender, GraphicsControlEventArgs e)
		{
			GraphicsContext ctx = e.Context;
			GraphicsSurface framebuffer = e.Framebuffer;

			// Update position
			KeyTimer_Tick();

			// Define view
			_GeometryClipmapScene.CurrentView.LocalModel.SetIdentity();
			_GeometryClipmapScene.CurrentView.LocalModel.Translate(_ViewPosition);
			_GeometryClipmapScene.CurrentView.LocalModel.RotateY(_ViewAzimuth);
			_GeometryClipmapScene.CurrentView.LocalModel.RotateX(_ViewElevation);

			Gl.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);

			// Draw geometry clipmap
			_GeometryClipmapScene.Draw(ctx);

			SampleGraphicsControl.Invalidate();
		}

		private SceneGraph _GeometryClipmapScene;

		GeometryClipmapObject _GeometryClipmapObject;

		private float _ViewFov = 60.0f;

		private float _ViewAzimuth;

		private float _ViewElevation;

		private Vertex3f _ViewPosition = new Vertex3f(0.0f, 25.0f, 0.0f);

		private float _BlockUnit = 100.0f;

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			// Setup FoV using wheel
			float ticks = e.Delta / 120.0f;

			_ViewFov += ticks;

			PerspectiveProjectionMatrix matrixProjection = new PerspectiveProjectionMatrix();
			matrixProjection.SetPerspective(_ViewFov / 16.0f * 9.0f, (float)ClientSize.Width / (float)ClientSize.Height, 0.1f, 110000.0f);

			_GeometryClipmapScene.CurrentView.ProjectionMatrix = matrixProjection;

			// Base implementation
			base.OnMouseWheel(e);
		}

		private void SampleGraphicsControl_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) != 0) {
				_MouseCursor = e.Location;
			}
		}

		private void SampleGraphicsControl_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) != 0) {
				Point delta = e.Location - new Size(_MouseCursor);
				float xDelta = (float)delta.X / (float)ClientSize.Width;
				float yDelta = (float)delta.Y / (float)ClientSize.Height;

				_ViewAzimuth -= xDelta * 180.0f;
				_ViewElevation += yDelta * 90.0f;

				_MouseCursor = e.Location;

				SampleGraphicsControl.Invalidate();
			}
		}

		private Point _MouseCursor;

		private void SampleGraphicsControl_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.W:
				case Keys.S:
				case Keys.A:
				case Keys.D:
				case Keys.PageUp:
				case Keys.PageDown:
					_PressedKeys[e.KeyCode] = true;
					break;
				case Keys.R:
					_ViewPosition = new Vertex3f();
					_ViewAzimuth = 0.0f;
					_ViewElevation = 0.0f;
					break;
				case Keys.Space:
					_GeometryClipmapObject.PositionCorrection = !_GeometryClipmapObject.PositionCorrection;
					break;
			}
		}

		private void SampleGraphicsControl_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.W:
				case Keys.S:
				case Keys.A:
				case Keys.D:
				case Keys.PageUp:
				case Keys.PageDown:
					_PressedKeys[e.KeyCode] = false;
					break;
			}
		}

		private void KeyTimer_Tick()
		{
			foreach (KeyValuePair<Keys, bool> pair in _PressedKeys) {
				if (pair.Value == false)
					continue;

				float step = _BlockUnit * 0.1163f;

				switch (pair.Key) {
					case Keys.W:
						_ViewPosition = _ViewPosition + (Vertex3f)(_GeometryClipmapScene.CurrentView.LocalModel.ForwardVector * step);
						break;
					case Keys.S:
						_ViewPosition = _ViewPosition - (Vertex3f)(_GeometryClipmapScene.CurrentView.LocalModel.ForwardVector * step);
						break;
					case Keys.A:
						_ViewPosition = _ViewPosition - (Vertex3f)(_GeometryClipmapScene.CurrentView.LocalModel.RightVector * step);
						break;
					case Keys.D:
						_ViewPosition = _ViewPosition + (Vertex3f)(_GeometryClipmapScene.CurrentView.LocalModel.RightVector * step);
						break;
					case Keys.PageUp:
						_ViewPosition = _ViewPosition + new Vertex3f(0.0f, +step, 0.0f);
						break;
					case Keys.PageDown:
						_ViewPosition = _ViewPosition + new Vertex3f(0.0f, -step, 0.0f);
						break;
				}
			}
		}

		/// <summary>
		/// Pressed keys map.
		/// </summary>
		private readonly Dictionary<Keys, bool> _PressedKeys = new Dictionary<Keys, bool>();
	}
}
