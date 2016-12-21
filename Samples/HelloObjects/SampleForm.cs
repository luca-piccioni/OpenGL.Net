
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
using OpenGL.Objects.Scene;
using OpenGL.Objects.State;

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

		#region Colored Cube

		private SceneObject CreateCubeGeometry()
		{
			_CubeArrayPosition = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
			_CubeArrayPosition.Create(ArrayPosition);

			// C:\Users\Luca\Source\Repos\OpenGL.Net\Samples\HelloObjects\Data\dongu8n0am0w-BumbleBee\BumbleBee\RB-BumbleBee.obj | VH-BumbleBee.obj
			// 
			SceneObject bb8 = SceneObjectCodec.Instance.Load(@"C:\Users\Luca\Source\Repos\OpenGL.Net\Samples\HelloObjects\Data\dongu8n0am0w-BumbleBee\BumbleBee\VH-BumbleBee.obj");

			bb8.ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
			bb8.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			bb8.LocalModel.Scale(0.1f);
			bb8.LocalModel.RotateX(-90.0f);
			bb8.LocalModel.RotateZ(90.0f);

			return bb8;

			SceneObjectGeometry cubeGeometry = new SceneObjectGeometry("Cube");

			#region State

			cubeGeometry.ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
			cubeGeometry.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			cubeGeometry.ObjectState.DefineState(new TransformState());

			MaterialState cubeMaterialState = new MaterialState();
			cubeMaterialState.FrontMaterial = new MaterialState.Material(ColorRGBAF.ColorWhite);
			cubeMaterialState.FrontMaterial.Ambient = ColorRGBAF.ColorWhite * 0.5f;
			cubeMaterialState.FrontMaterial.Specular = ColorRGBAF.ColorMagenta;
			cubeMaterialState.FrontMaterial.Shininess = 0.5f;
			cubeGeometry.ObjectState.DefineState(cubeMaterialState);

			#endregion

			#region Vertex Arrays

			_CubeArrayPosition = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
			_CubeArrayPosition.Create(ArrayPosition);

			ArrayBufferObject<ColorRGBF> arrayColor = new ArrayBufferObject<ColorRGBF>(BufferObjectHint.StaticCpuDraw);
			arrayColor.Create(ArrayColors);

			ArrayBufferObject<Vertex3f> arrayNormal = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
			arrayNormal.Create(ArrayNormals);
			
			cubeGeometry.VertexArray = new VertexArrayObject();
			cubeGeometry.VertexArray.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
			cubeGeometry.VertexArray.SetArray(arrayColor, VertexArraySemantic.Color);
			cubeGeometry.VertexArray.SetArray(arrayNormal, VertexArraySemantic.Normal);
			cubeGeometry.VertexArray.SetElementArray(PrimitiveType.Triangles);

			#endregion

			#region Program

			cubeGeometry.Program = ShadersLibrary.Instance.CreateProgram("OpenGL.Standard+PhongFragment");
			cubeGeometry.Program.CompilationParams.Defines.Add("GLO_COLOR_PER_VERTEX");
			cubeGeometry.Program.CompilationParams.Defines.Add("GLO_MAX_LIGHTS_COUNT 4");

			#endregion

			return (cubeGeometry);
		}

		/// <summary>
		/// Scene drawn on screen.
		/// </summary>
		SceneGraph _CubeScene;

		/// <summary>
		/// Shared array buffer: vertex positions
		/// </summary>
		ArrayBufferObject<Vertex3f> _CubeArrayPosition;

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

		#endregion

		#region Cube Mapping

		private SceneObject CreateSkyBoxObject()
		{
			if (!Gl.CurrentExtensions.TextureCubeMap_ARB)
				return (null);

			SceneObjectGeometry skyboxObject = new SceneObjectGeometry();

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

			TextureCube cubeMapTexture = new TextureCube();
			cubeMapTexture.Create(PixelLayout.RGB24, cubeMap);

			#endregion

			#region State

			skyboxObject.LocalModel.Scale(170.0f);

			skyboxObject.ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
			skyboxObject.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Cw, CullFaceMode.Back));

			ShaderUniformState skyboxUniformState = new ShaderUniformState("OpenGL.Skybox");
			skyboxUniformState.SetUniformState("glo_CubeMapTexture", cubeMapTexture);
			skyboxObject.ObjectState.DefineState(skyboxUniformState);

			#endregion

			#region Program

			skyboxObject.Program = ShadersLibrary.Instance.CreateProgram("OpenGL.Skybox");
			skyboxObject.Program.Create(_Context);

			#endregion

			#region Vertex Array

			// Define vertex arrays
			skyboxObject.VertexArray = new VertexArrayObject();
			skyboxObject.VertexArray.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
			skyboxObject.VertexArray.SetElementArray(PrimitiveType.Triangles);
			skyboxObject.VertexArray.Create(_Context);

			#endregion

			return (skyboxObject);
		}

		#endregion

		#region Event Handling

		private void SampleForm_Load(object sender, EventArgs e)
		{
			ObjectsControl.MouseWheel += ObjectsControl_MouseWheel;
		}

		#region Rendering

		/// <summary>
		/// Allocate resources for rendering.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			// Wrap GL context with GraphicsContext
			_Context = new GraphicsContext(e.DeviceContext, e.RenderContext);
			// Scene
			_CubeScene = new SceneGraph();
			_CubeScene.AddChild(new SceneObjectCamera());

			SceneObject sceneObject;

			// Global lighting
			SceneObjectLightZone globalLightZone = new SceneObjectLightZone();

			SceneObjectLightDirectional globalLightObject = new SceneObjectLightDirectional();
			globalLightObject.Direction = Vertex3f.UnitY;
			globalLightZone.AddChild(globalLightObject);

			SceneObjectLightPoint localLightObject = new SceneObjectLightPoint();
			localLightObject.LocalModel.Translate(0.0, -5.0f, 0.0);
			localLightObject.AttenuationFactors.Y = 0.1f;
			//globalLightZone.AddChild(localLightObject);

			_CubeScene.AddChild(globalLightZone);

			// Cube
			globalLightZone.AddChild(CreateCubeGeometry());
			// Skybox
			if ((sceneObject = CreateSkyBoxObject()) != null)
				_CubeScene.AddChild(sceneObject);

			_CubeScene.Create(_Context);
		}

		/// <summary>
		/// Dispose resources allocated by <see cref="ObjectsControl_ContextCreated"/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextDestroying(object sender, GlControlEventArgs e)
		{
			_CubeScene.Dispose();
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

			_CubeScene.CurrentView.LocalModel.SetIdentity();
			_CubeScene.CurrentView.LocalModel.RotateY(_ViewAzimuth);
			_CubeScene.CurrentView.LocalModel.RotateX(_ViewElevation);
			_CubeScene.CurrentView.LocalModel.Translate(0.0f, 0.0f, _ViewLever);
			_CubeScene.CurrentView.ProjectionMatrix = new PerspectiveProjectionMatrix(45.0f, senderAspectRatio, 0.1f, 400.0f);

			_CubeScene.Draw(_Context);
		}

		/// <summary>
		/// The GL context.
		/// </summary>
		GraphicsContext _Context;

		/// <summary>
		/// Azimuth angle of the view-point.
		/// </summary>
		private float _ViewAzimuth;

		/// <summary>
		/// Elevation angle of the view-point.
		/// </summary>
		private float _ViewElevation;

		/// <summary>
		/// lever arm of the view-point.
		/// </summary>
		private float _ViewLever = 4.0f;

		#endregion

		#region Mouse Input

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

		#endregion

		#region Animation

		private void UpdateTimer_Tick(object sender, EventArgs e)
		{
			SceneObject cubeObject = _CubeScene.FindChild(delegate(SceneObject item) { return (item.Identifier == "Cube"); });

			if (cubeObject != null) {
				cubeObject.LocalModel.RotateY(1.0f);
				cubeObject.LocalModel.RotateX(0.85f);
			}

			ObjectsControl.Invalidate();
		}

		#endregion

		#endregion
	}
}
