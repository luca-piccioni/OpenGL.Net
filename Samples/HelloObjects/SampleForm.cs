
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
using System.Collections.Generic;
using System.Diagnostics;
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

		private SceneObjectGeometry CreateCubeGeometry()
		{
			SceneObjectGeometry cubeGeometry = new SceneObjectGeometry("Cube");

			#region State

			cubeGeometry.ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
			cubeGeometry.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			cubeGeometry.ObjectState.DefineState(new TransformState());

			MaterialState cubeMaterialState = new MaterialState();
			cubeMaterialState.FrontMaterial = new MaterialState.Material(ColorRGBAF.ColorWhite * 0.5f);
			cubeMaterialState.FrontMaterial.Ambient = ColorRGBAF.ColorWhite * 0.5f;
			cubeMaterialState.FrontMaterial.Diffuse = ColorRGBAF.ColorRed;
			cubeMaterialState.FrontMaterial.Specular = ColorRGBAF.ColorWhite * 0.05f;
			cubeMaterialState.FrontMaterial.Shininess = 0.5f;
			cubeGeometry.ObjectState.DefineState(cubeMaterialState);

			#endregion

			#region Vertex Arrays

			if (_CubeArrayPosition == null) {
				_CubeArrayPosition = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
				_CubeArrayPosition.Create(ArrayPosition);
			}

			if (_CubeArrayColor == null) {
				_CubeArrayColor = new ArrayBufferObject<ColorRGBF>(BufferObjectHint.StaticCpuDraw);
				_CubeArrayColor.Create(ArrayColors);
			}

			if (_CubeArrayNormal == null) {
				_CubeArrayNormal = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
				_CubeArrayNormal.Create(ArrayNormals);
			}

			if (_CubeArrays == null) {
				_CubeArrays = new VertexArrayObject();
				_CubeArrays.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
				_CubeArrays.SetArray(_CubeArrayColor, VertexArraySemantic.Color);
				_CubeArrays.SetArray(_CubeArrayNormal, VertexArraySemantic.Normal);
				_CubeArrays.SetElementArray(PrimitiveType.Triangles);
			}

			cubeGeometry.VertexArray = _CubeArrays;

			#endregion

			#region Program

			cubeGeometry.BoundingVolume = new BoundingBox(-Vertex3f.One * _CubeSize, Vertex3f.One * _CubeSize);

			#endregion

			return (cubeGeometry);
		}

		/// <summary>
		/// Scene drawn on screen.
		/// </summary>
		SceneGraph _CubeScene;

		/// <summary>
		/// Shared array buffer: vertex positions.
		/// </summary>
		ArrayBufferObject<Vertex3f> _CubeArrayPosition;

		/// <summary>
		/// Shared array buffer: vertex colors.
		/// </summary>
		ArrayBufferObject<ColorRGBF> _CubeArrayColor;

		/// <summary>
		/// Shared array buffer: vertex normals.
		/// </summary>
		ArrayBufferObject<Vertex3f> _CubeArrayNormal;

		VertexArrayObject _CubeArrays;

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

			skyboxObject.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Skybox");
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

		#region Mesh Loading

		private SceneObject CreateMesh()
		{
			// C:\Users\Luca\Source\Repos\OpenGL.Net\Samples\HelloObjects\Data\dongu8n0am0w-BumbleBee\BumbleBee\RB-BumbleBee.obj | VH-BumbleBee.obj
			// 
			SceneObject bumbleBee = SceneObjectCodec.Instance.Load(@"C:\Users\Luca\Source\Repos\OpenGL.Net\Samples\HelloObjects\Data\dongu8n0am0w-BumbleBee\BumbleBee\RB-BumbleBee.obj");

			bumbleBee.ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
			bumbleBee.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			bumbleBee.LocalModel.Translate(0.0f, -10.0f);
			bumbleBee.LocalModel.Scale(0.03f);
			bumbleBee.LocalModel.RotateX(-90.0f);
			bumbleBee.LocalModel.RotateZ(90.0f);

			return bumbleBee;
		}

		#endregion

		#region Event Handling

		private void SampleForm_Load(object sender, EventArgs e)
		{
			AnimationTimer.Enabled = true;
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

			// Global lighting
			SceneObjectLightZone globalLightZone = new SceneObjectLightZone();

			SceneObjectLightDirectional globalLightObject = new SceneObjectLightDirectional();
			globalLightObject.Direction = (-Vertex3f.UnitX + Vertex3f.UnitY - Vertex3f.UnitZ).Normalized;
			globalLightZone.AddChild(globalLightObject);

			SceneObjectLightPoint localLightObject = new SceneObjectLightPoint();
			localLightObject.LocalModel.Translate(0.0, -5.0f, 0.0);
			localLightObject.AttenuationFactors.Y = 0.1f;
			//globalLightZone.AddChild(localLightObject);

			_CubeScene.AddChild(globalLightZone);

			// Cube
			float Size = (float)Math.Sqrt(300.0f);
			const float Multiplier = 10.0f;

			int materialIndex = 0;

			for (float x = -Size / 2.0f * Multiplier; x < Size / 2.0f * Multiplier; x += Multiplier) {
				for (float y = -Size / 2.0f * Multiplier; y < Size / 2.0f * Multiplier; y += Multiplier, materialIndex++) {
					SceneObjectGeometry cubeInstance = CreateCubeGeometry();

					cubeInstance.LocalModel.Translate(x, 0.0f, y);
					cubeInstance.LocalModel.Scale(0.25f);

					// Enable/Disable blending
					if ((materialIndex % 2) == 0) {
						cubeInstance.ObjectState.DefineState(new BlendState(BlendEquationModeEXT.FuncAdd, BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha));
					}

					// Enable/Disable blending
					switch (materialIndex % 3) {
						case 0:
							cubeInstance.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+LambertVertex", new ShaderCompilerContext("GLO_COLOR_PER_VERTEX"));
							break;
						case 1:
							cubeInstance.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+Color");
							break;
						case 2:
							cubeInstance.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+PhongFragment");
							break;
					}

					globalLightZone.AddChild(cubeInstance);
				}
			}
			globalLightZone.AddChild(CreateMesh());
			// Skybox
			//if ((sceneObject = CreateSkyBoxObject()) != null)
			//	_CubeScene.AddChild(sceneObject);

			KhronosApi.LogEnabled = false;

			_CubeScene.Create(_Context);

			KhronosApi.LogEnabled = true;
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
			_CubeScene.CurrentView.LocalModel.Translate(_ViewStrideLat, _ViewStrideAlt, 0.0f);
			_CubeScene.CurrentView.LocalModel.RotateY(_ViewAzimuth);
			_CubeScene.CurrentView.LocalModel.RotateX(_ViewElevation);
			_CubeScene.CurrentView.LocalModel.Translate(0.0f, 0.0f, _ViewLever);
			_CubeScene.CurrentView.ProjectionMatrix = new PerspectiveProjectionMatrix(45.0f, senderAspectRatio, 0.5f, 10000.0f);

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

		private float _ViewStrideLat, _ViewStrideAlt;

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

		private Point? _Mouse;

		private void ObjectsControl_MouseWheel(object sender, MouseEventArgs e)
		{
			_ViewLever += e.Delta / 60.0f;
			_ViewLever = Math.Max(2.5f, _ViewLever);
		}

		private void ObjectsControl_KeyDown(object sender, KeyEventArgs e)
		{
			if (_PressedKeys.Contains(e.KeyCode) == false)
				_PressedKeys.Add(e.KeyCode);
		}

		private void ObjectsControl_KeyUp(object sender, KeyEventArgs e)
		{
			_PressedKeys.Remove(e.KeyCode);
		}

		/// <summary>
		/// Currently pressed keys
		/// </summary>
		private readonly List<Keys> _PressedKeys = new List<Keys>();

		#endregion

		#region Animation

		private void UpdateTimer_Tick(object sender, EventArgs args)
		{
			foreach (Keys pressedKey in _PressedKeys) {
				switch (pressedKey) {
					case Keys.A:
						_ViewStrideLat -= 0.1f;
						break;
					case Keys.D:
						_ViewStrideLat += 0.1f;
						break;
					case Keys.W:
						_ViewStrideAlt += 0.1f;
						break;
					case Keys.S:
						_ViewStrideAlt -= 0.1f;
						break;
				}
			}

			ObjectsControl.Invalidate();
		}

		#endregion

		#endregion
	}
}
