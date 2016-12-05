
// Copyright (C) 2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using OpenGL;
using OpenGL.Objects;

namespace HelloObjects
{
	/// <summary>
	/// OpenGL.Objects sample application.
	/// </summary>
	public partial class SampleForm : Form
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SampleForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Resources and State

		/// <summary>
		/// The GL context.
		/// </summary>
		GraphicsContext _Context;

		#endregion

		#region Colored Cube

		private void InitializeCube()
		{
			// Create the program, using the embedded shaders lbrary
			_CubeProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.Standard+Color");
			_CubeProgram.Create(_Context);

			// Allocate arrays - Position
			_CubeArrayPosition = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
			_CubeArrayPosition.Create(ArrayPosition);
			// Allocate arrays - Color
			ArrayBufferObject<ColorRGBF> arrayColor = new ArrayBufferObject<ColorRGBF>(BufferObjectHint.StaticCpuDraw);
			arrayColor.Create(ArrayColors);
			// Define vertex arrays
			_CubeVertexArray = new VertexArrayObject();
			_CubeVertexArray.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
			_CubeVertexArray.SetArray(arrayColor, VertexArraySemantic.Color);
			_CubeVertexArray.SetElementArray(PrimitiveType.Triangles);
			_CubeVertexArray.Create(_Context);
		}

		private void TerminateCube()
		{
			if (_CubeVertexArray != null) {
				_CubeVertexArray.Dispose();
				_CubeVertexArray = null;
			}
			if (_CubeProgram != null) {
				_CubeProgram.Dispose();
				_CubeProgram = null;
			}
		}

		private void RenderCube(PerspectiveProjectionMatrix projectionMatrix, ModelMatrix viewMatrix)
		{
			// Gl.FrontFace(FrontFaceDirection.Ccw);

			// Model matrix
			ModelMatrix modelMatrix = new ModelMatrix();
			modelMatrix.RotateZ(_CubeRotationH);
			modelMatrix.RotateY(_CubeRotationP);
			
			_Context.Bind(_CubeProgram);
			_CubeProgram.SetUniform(_Context, "glo_ModelViewProjection", projectionMatrix * viewMatrix.GetInverseMatrix() * modelMatrix);
			_CubeVertexArray.Draw(_Context, _CubeProgram);
		}

		/// <summary>
		/// Rotation angles of the cube, in degrees.
		/// </summary>
		private float _CubeRotationH, _CubeRotationP;

		/// <summary>
		/// The shader program drawing the cube.
		/// </summary>
		ShaderProgram _CubeProgram;

		/// <summary>
		/// The vertex arrays defining the cube information.
		/// </summary>
		VertexArrayObject _CubeVertexArray;

		/// <summary>
		/// Shared array buffer: vertex positions
		/// </summary>
		ArrayBufferObject<Vertex3f> _CubeArrayPosition;

		#endregion

		#region Cube Mapping

		private void InitializeCubeMapping()
		{
			if (!Gl.CurrentExtensions.TextureCubeMap_ARB)
				return;

			#region Program

			_CubeMappingProgram = ShadersLibrary.Instance.CreateProgram("OpenGL.CubeMapping");
			_CubeMappingProgram.Create(_Context);

			#endregion

			#region Texture

			OpenGL.Objects.Image[] cubeMap = new OpenGL.Objects.Image[6];

			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.posx.jpg"))
				cubeMap[0] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);
			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.negx.jpg"))
				cubeMap[1] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);
			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.posy.jpg"))
				cubeMap[2] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);
			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.negy.jpg"))
				cubeMap[3] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);
			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.posz.jpg"))
				cubeMap[4] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);
			using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HelloObjects.Data.PiazzaDelPopolo.negz.jpg"))
				cubeMap[5] = ImageCodec.Instance.Load(imageStream, ImageFormat.Jpeg);

			foreach (OpenGL.Objects.Image image in cubeMap)
				image.FlipVertically();

			_CubeMapTexture = new TextureCube();
			_CubeMapTexture.Create(_Context, PixelLayout.RGB24, cubeMap);

			#endregion

			#region Vertex Array

			// Define vertex arrays
			_CubeMappingVertexArray = new VertexArrayObject();
			_CubeMappingVertexArray.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
			_CubeMappingVertexArray.SetElementArray(PrimitiveType.Triangles);
			_CubeMappingVertexArray.Create(_Context);

			#endregion
		}

		private void TerminateCubeMapping()
		{
			if (_CubeMapTexture != null) {
				_CubeMapTexture.Dispose();
				_CubeMapTexture = null;
			}
		}

		private void RenderCubeMapping(PerspectiveProjectionMatrix projectionMatrix, ModelMatrix viewMatrix)
		{
			Gl.FrontFace(FrontFaceDirection.Cw);

			// Model matrix
			ModelMatrix modelMatrix = new ModelMatrix();
			modelMatrix.Scale(160.0f);

			_Context.Bind(_CubeMappingProgram);
			_CubeMappingProgram.ResetTextureUnits();
			_CubeMappingProgram.SetUniform(_Context, "glo_ModelViewProjection", projectionMatrix * viewMatrix.GetInverseMatrix() * modelMatrix);
			_CubeMappingProgram.SetUniform(_Context, "glo_CubeMapTexture", _CubeMapTexture);
			_CubeMappingVertexArray.Draw(_Context, _CubeMappingProgram);
		}

		/// <summary>
		/// The shader program drawing the cube.
		/// </summary>
		ShaderProgram _CubeMappingProgram;

		/// <summary>
		/// The vertex arrays defining the cube information.
		/// </summary>
		VertexArrayObject _CubeMappingVertexArray;

		/// <summary>
		/// Cube texture for implementing environment mapping.
		/// </summary>
		private TextureCube _CubeMapTexture;

		#endregion

		#region Event Handling

		private void SampleForm_Load(object sender, EventArgs e)
		{
			ObjectsControl.MouseWheel += ObjectsControl_MouseWheel;
		}

		/// <summary>
		/// Allocate resources for rendering.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			// Wrap GL context with GraphicsContext
			_Context = new GraphicsContext(e.DeviceContext, e.RenderContext);

			InitializeCube();
			InitializeCubeMapping();

			// Set required server state
			Gl.Enable(EnableCap.DepthTest);
		}

		/// <summary>
		/// Dispose resources allocated by <see cref="ObjectsControl_ContextCreated"/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextDestroying(object sender, GlControlEventArgs e)
		{
			TerminateCubeMapping();
			TerminateCube();

			_Context.Dispose();
		}

		/// <summary>
		/// Update framebuffer.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_Render(object sender, GlControlEventArgs e)
		{
			Control senderControl = (Control)sender;
			float senderAspectRatio = (float)senderControl.Width / senderControl.Height;

			// Clear
			Gl.Viewport(0, 0, senderControl.Width, senderControl.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			// Projection matrix - Perspective
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix(45.0f, senderAspectRatio, 0.1f, 400.0f);

			// View matrix
			ModelMatrix viewMatrix = new ModelMatrix();
			//viewMatrix.LookAtTarget(new Vertex3f(2.0f, -2.0f, 2.0f), Vertex3f.Zero);
			viewMatrix.RotateY(_ViewAzimuth);
			viewMatrix.RotateX(_ViewElevation);
			viewMatrix.Translate(0.0f, 0.0f, _ViewLever);

			RenderCube(projectionMatrix, viewMatrix);
			RenderCubeMapping(projectionMatrix, viewMatrix);
		}

		private const float _CubeSize = 1.0f;

		private Vertex3f[] ArrayPosition
		{
			get
			{
				Vertex3f[] arrayPosition = new Vertex3f[36];
				int i = 0;

				// +Y
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);

				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, -_CubeSize);

				// -Y
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, +_CubeSize);

				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, +_CubeSize);

				// +X
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);

				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, +_CubeSize);

				// -X
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, +_CubeSize);

				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, -_CubeSize);

				// +Z
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);

				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, +_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, +_CubeSize);

				// -Z
				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(-_CubeSize, +_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, -_CubeSize);

				arrayPosition[i++] = new Vertex3f(-_CubeSize, -_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, +_CubeSize, -_CubeSize);
				arrayPosition[i++] = new Vertex3f(+_CubeSize, -_CubeSize, -_CubeSize);

				return (arrayPosition);
			}
		}

		private Vertex3f[] ArrayNormals
		{
			get
			{
				Vertex3f[] arrayNormal = new Vertex3f[36];
				int v = 0;

				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = Vertex3f.UnitY;
				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = -Vertex3f.UnitY;
				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = Vertex3f.UnitX;
				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = -Vertex3f.UnitX;
				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = Vertex3f.UnitZ;
				for (int i = 0; i < 6; i++)
					arrayNormal[v++] = -Vertex3f.UnitZ;

				return (arrayNormal);
			}
		}

		private ColorRGBF[] ArrayColors
		{
			get
			{
				ColorRGBF[] arrayColor = new ColorRGBF[36];
				int v = 0;

				for (int i = 0; i < 12; i++)
					arrayColor[v++] = ColorRGBF.ColorRed;
				for (int i = 0; i < 12; i++)
					arrayColor[v++] = ColorRGBF.ColorGreen;
				for (int i = 0; i < 12; i++)
					arrayColor[v++] = ColorRGBF.ColorBlue;

				return (arrayColor);
			}
		}

		private void ObjectsControl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_Mouse = e.Location;
		}

		private void ObjectsControl_MouseMove(object sender, MouseEventArgs e)
		{
			if (_Mouse.HasValue) {
				Point delta = _Mouse.Value - (Size)e.Location;

				_ViewAzimuth += delta.X * 0.5f;
				_ViewElevation += delta.Y * 0.5f;

				_Mouse = e.Location;
			}
		}

		private void ObjectsControl_MouseUp(object sender, MouseEventArgs e)
		{
			_Mouse = null;
		}

		private void ObjectsControl_MouseWheel(object sender, MouseEventArgs e)
		{
			_ViewLever += e.Delta / 60.0f;
			_ViewLever = Math.Max(2.5f, _ViewLever);
		}

		private Point? _Mouse;

		private float _ViewAzimuth;

		private float _ViewElevation;

		private float _ViewLever = 4.0f;

		private void UpdateTimer_Tick(object sender, EventArgs e)
		{
			_CubeRotationH += 1.0f;
			_CubeRotationP += 0.5f;
			ObjectsControl.Invalidate();
		}

		#endregion
	}
}
