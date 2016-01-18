using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenGL;

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

			// Create Newton program
			_NewtonProgram = ShadersLibrary.Instance.CreateProgram("Newton");
			_NewtonProgram.AddFeedbackVarying("hal_VertexPosition");
			_NewtonProgram.AddFeedbackVarying("hal_VertexSpeed");
			_NewtonProgram.AddFeedbackVarying("hal_VertexAcceleration");
			_NewtonProgram.AddFeedbackVarying("hal_VertexMass");
			_NewtonProgram.Create(ctx);

			// Initialize first vertex array
			NewtonVertex[] newtonArray = new NewtonVertex[VertexCount];
			Random random = new Random();

			for (int i = 0; i < newtonArray.Length; i++) {
				NewtonVertex newtonVertex = new NewtonVertex();

				newtonVertex.Position = new Vertex3f(RandomNormalized(), RandomNormalized(), RandomNormalized());
				newtonVertex.Speed = new Vertex3f(RandomNormalized(), RandomNormalized(), RandomNormalized());
				newtonVertex.Acceleration = new Vertex3f();
				newtonVertex.Mass = RandomNormalized();

				newtonArray[i] = newtonVertex;
			}

			// Create vertex arrays
			ArrayBufferObjectBase newtonVertexArrayBuffer1, newtonVertexArrayBuffer2;

			_NewtonVertexArray1 = CreateVertexArray(newtonArray, out newtonVertexArrayBuffer1);
			_NewtonVertexArray2 = CreateVertexArray(null, out newtonVertexArrayBuffer2);

			_NewtonVertexArray1.SetTransformFeedback(CreateFeedbackBuffer(newtonVertexArrayBuffer2));
			_NewtonVertexArray2.SetTransformFeedback(CreateFeedbackBuffer(newtonVertexArrayBuffer1));

			_NewtonVertexArray1.Create(ctx);
			_NewtonVertexArray2.Create(ctx);

			// Starts from initialized buffer
			_NewtonVertexArray = _NewtonVertexArray1;

			// Clear color
			framebuffer.SetClearColor(new ColorRGBAF(0.0f, 0.0f, 0.0f));
		}

		private float RandomNormalized()
		{
			return (float)((_Random.NextDouble() - 0.5) * 2.0);
		}

		private static Random _Random = new Random();

		private VertexArrayObject CreateVertexArray(NewtonVertex[] array, out ArrayBufferObjectBase interleavedArrayBuffer)
		{
			VertexArrayObject newtonVertexArray = new VertexArrayObject();
			ArrayBufferObjectInterleaved newtonVertexArrayBuffer = new ArrayBufferObjectInterleaved(typeof(NewtonVertex), BufferObjectHint.DynamicGpuDraw);

			if (array != null)
				newtonVertexArrayBuffer.Create(array);
			else
				newtonVertexArrayBuffer.Create(VertexCount);
			newtonVertexArray.SetArray(newtonVertexArrayBuffer, 0, VertexArraySemantic.Position);
			newtonVertexArray.SetArray(newtonVertexArrayBuffer, 1, VertexArraySemantic.Speed);
			newtonVertexArray.SetArray(newtonVertexArrayBuffer, 2, VertexArraySemantic.Acceleration);
			newtonVertexArray.SetArray(newtonVertexArrayBuffer, 3, VertexArraySemantic.Mass);
			newtonVertexArray.SetElementArray(PrimitiveType.Points);

			interleavedArrayBuffer = newtonVertexArrayBuffer;

			return (newtonVertexArray);
		}

		const uint VertexCount = 1024;

		private FeedbackBufferObject CreateFeedbackBuffer(ArrayBufferObjectBase interleavedArrayBuffer)
		{
			FeedbackBufferObject newtonFeedbackBuffer = new FeedbackBufferObject();

			newtonFeedbackBuffer.AttachArray(0, interleavedArrayBuffer, 0);
			newtonFeedbackBuffer.AttachArray(1, interleavedArrayBuffer, 1);
			newtonFeedbackBuffer.AttachArray(2, interleavedArrayBuffer, 2);
			newtonFeedbackBuffer.AttachArray(3, interleavedArrayBuffer, 3);
			newtonFeedbackBuffer.EnableRasterizer = true;

			return (newtonFeedbackBuffer);
		}

		private void SampleGraphicsControl_Render(object sender, GraphicsControlEventArgs e)
		{
			GraphicsContext ctx = e.Context;
			GraphicsSurface framebuffer = e.Framebuffer;

			if (_AnimationBegin == DateTime.MinValue)
				_AnimationBegin = DateTime.UtcNow;

			PerspectiveProjectionMatrix matrixProjection = new PerspectiveProjectionMatrix();
			Matrix4x4 matrixView;

			// Set projection
			matrixProjection.SetPerspective(60.0f, (float)ClientSize.Width / (float)ClientSize.Height, 1.0f, 1000.0f);
			// Set view
			ModelMatrix matrixViewModel = new ModelMatrix();
			matrixViewModel.RotateX(_ViewElevation);
			matrixViewModel.RotateY(_ViewAzimuth);
			matrixViewModel.Translate(0.0f, 0.0f, _ViewDistance);
			matrixView = matrixViewModel.GetInverseMatrix();

			_NewtonProgram.Bind(ctx);
			_NewtonProgram.SetUniform(ctx, "hal_ModelViewProjection", matrixProjection * matrixView);
			_NewtonProgram.SetUniform(ctx, "hal_FrameTimeInterval", (float)(DateTime.UtcNow - _AnimationBegin).TotalSeconds);

			_NewtonVertexArray.Draw(ctx, _NewtonProgram);

			SwapNewtonVertexArrays();

			// Issue another rendering
			SampleGraphicsControl.Invalidate();
		}

		private void SwapNewtonVertexArrays()
		{
			if (ReferenceEquals(_NewtonVertexArray, _NewtonVertexArray2))
				_NewtonVertexArray = _NewtonVertexArray1;
			else
				_NewtonVertexArray = _NewtonVertexArray2;
		}

		/// <summary>
		/// Program used for rendering the example.
		/// </summary>
		ShaderProgram _NewtonProgram;

		/// <summary>
		/// The actual vertex array used for drawing/computing.
		/// </summary>
		VertexArrayObject _NewtonVertexArray;

		/// <summary>
		/// Vertex arrays (set 1).
		/// </summary>
		VertexArrayObject _NewtonVertexArray1;

		/// <summary>
		/// Vertex arrays (set 2).
		/// </summary>
		VertexArrayObject _NewtonVertexArray2;

		DateTime _AnimationBegin = DateTime.MinValue;

		private float _ViewDistance = 2.0f;

		private float _ViewAzimuth;

		private float _ViewElevation;

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
				_ViewElevation -= yDelta * 90.0f;

				_MouseCursor = e.Location;

				SampleGraphicsControl.Invalidate();
			}
		}

		private Point _MouseCursor;
	}
}
