
// Copyright (C) 2016-2017 Luca Piccioni
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

		private SceneObjectGeometry CreatePlane()
		{
			SceneObjectGeometry geometry = new SceneObjectGeometry("Plane");

			geometry.VertexArray = VertexArrays.CreatePlane(1.0f, 1.0f, -1.0f, 1, 1);
			// geometry.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back) { Culling = false });
			geometry.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard");

			return (geometry);
		}

		private SceneObjectGeometry CreateCubeGeometry()
		{
			SceneObjectGeometry cubeGeometry = new SceneObjectGeometry("Cube");

			#region State

			cubeGeometry.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			cubeGeometry.ObjectState.DefineState(new TransformState());

			MaterialState cubeMaterialState = new MaterialState();
			cubeMaterialState.FrontMaterial = new MaterialState.Material(ColorRGBAF.ColorWhite * 0.5f);
			cubeMaterialState.FrontMaterial.Ambient = ColorRGBAF.ColorBlack;
			cubeMaterialState.FrontMaterial.Diffuse = ColorRGBAF.ColorWhite * 0.5f;
			cubeMaterialState.FrontMaterial.Specular = ColorRGBAF.ColorWhite * 0.5f;
			cubeMaterialState.FrontMaterial.Shininess = 10.0f;
			cubeGeometry.ObjectState.DefineState(cubeMaterialState);

			#endregion

			#region Vertex Arrays

			if (_CubeArrayPosition == null) {
				_CubeArrayPosition = new ArrayBuffer<Vertex3f>();
				_CubeArrayPosition.Create(ArrayPosition);
			}

			if (_CubeArrayColor == null) {
				_CubeArrayColor = new ArrayBuffer<ColorRGBF>();
				_CubeArrayColor.Create(ArrayColors);
			}

			if (_CubeArrayNormal == null) {
				_CubeArrayNormal = new ArrayBuffer<Vertex3f>();
				_CubeArrayNormal.Create(ArrayNormals);
			}

			if (_CubeArrays == null) {
				_CubeArrays = new VertexArrays();
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
		ArrayBuffer<Vertex3f> _CubeArrayPosition;

		/// <summary>
		/// Shared array buffer: vertex colors.
		/// </summary>
		ArrayBuffer<ColorRGBF> _CubeArrayColor;

		/// <summary>
		/// Shared array buffer: vertex normals.
		/// </summary>
		ArrayBuffer<Vertex3f> _CubeArrayNormal;

		VertexArrays _CubeArrays;

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

		#region Material Sphere

		private SceneObjectGeometry CreateSphere(string material)
		{
			SceneObjectGeometry sphereGeometry = new SceneObjectGeometry("Sphere");

			sphereGeometry.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			sphereGeometry.ObjectState.DefineState(new TransformState());
			sphereGeometry.LocalModelView = Matrix4x4f.Translated(0.0f, 4.0f, 0.0f);

			sphereGeometry.VertexArray = VertexArrays.CreateSphere(4.0f, 32, 32);

			ArrayBuffer<Vertex2f> texCoordBuffer = new ArrayBuffer<Vertex2f>();
			texCoordBuffer.Create(sphereGeometry.VertexArray.ArrayLength);
			sphereGeometry.VertexArray.SetArray(texCoordBuffer, VertexArraySemantic.TexCoord);

			ArrayBuffer<Vertex3f> tanCoordBuffer = new ArrayBuffer<Vertex3f>();
			tanCoordBuffer.Create(sphereGeometry.VertexArray.ArrayLength);
			sphereGeometry.VertexArray.SetArray(tanCoordBuffer, VertexArraySemantic.Tangent);

			ArrayBuffer<Vertex3f> bitanCoordBuffer = new ArrayBuffer<Vertex3f>();
			bitanCoordBuffer.Create(sphereGeometry.VertexArray.ArrayLength);
			sphereGeometry.VertexArray.SetArray(bitanCoordBuffer, VertexArraySemantic.Bitangent);

			sphereGeometry.VertexArray.GenerateTexCoords(new VertexArrayTexGen.Sphere());
			sphereGeometry.VertexArray.GenerateTangents();

			sphereGeometry.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+PhongFragment");

			SetSphereMaterial(sphereGeometry, material);

			return (sphereGeometry);
		}

		private void SetSphereMaterial(SceneObjectGeometry sphere, string material)
		{
			MaterialState sphereMaterial = new MaterialState();
			sphereMaterial.FrontMaterial = new MaterialState.Material(ColorRGBAF.ColorWhite);
			sphereMaterial.FrontMaterial.Ambient = ColorRGBAF.ColorWhite * 0.2f;
			sphereMaterial.FrontMaterial.Diffuse = ColorRGBAF.ColorWhite * 0.8f;
			sphereMaterial.FrontMaterial.Specular = ColorRGBAF.ColorWhite * 1.0f;
			sphereMaterial.FrontMaterial.Shininess = 32.0f;

			sphere.ObjectState.DefineState(sphereMaterial);

			if (material == null)
				return;

			string basePath = Path.Combine("Data", "PhotosculptTextures");
			string textureFilename, texturePath;

			textureFilename = String.Format("photosculpt-{0}-{1}.jpg", material, "diffuse");
			texturePath = Path.Combine(basePath, textureFilename);
			if (File.Exists(texturePath)) {
				try {
					Image textureImage = ImageCodec.Instance.Load(texturePath);
					Texture2d texture = new Texture2d();

					texture.GenerateMipmaps();
					texture.SamplerParams.MinFilter = TextureMinFilter.LinearMipmapNearest;
					texture.SamplerParams.WrapCoordR = TextureWrapMode.Repeat; // Texture.Wrap.MirroredRepeat;
					texture.SamplerParams.WrapCoordS = TextureWrapMode.Repeat;
					texture.Create(textureImage);

					sphereMaterial.FrontMaterialDiffuseTexture = texture;
					sphereMaterial.FrontMaterialDiffuseTexCoord = 0;
				} catch (Exception exception) {
					throw new InvalidOperationException(String.Format("unable to load texture {0}", texturePath), exception);
				}
			}

			textureFilename = String.Format("photosculpt-{0}-{1}.jpg", material, "normal");
			texturePath = Path.Combine(basePath, textureFilename);
			if (File.Exists(texturePath)) {
				try {
					Image textureImage = ImageCodec.Instance.Load(texturePath);
					Texture2d texture = new Texture2d();

					texture.GenerateMipmaps();
					texture.SamplerParams.MinFilter = TextureMinFilter.LinearMipmapNearest;
					texture.SamplerParams.WrapCoordR = TextureWrapMode.Repeat;
					texture.SamplerParams.WrapCoordS = TextureWrapMode.Repeat;
					texture.Create(textureImage);

					sphereMaterial.FrontMaterialNormalTexture = texture;
					sphereMaterial.FrontMaterialNormalTexCoord = 0;
				} catch (Exception exception) {
					throw new InvalidOperationException(String.Format("unable to load texture {0}", texturePath), exception);
				}
			}

			textureFilename = String.Format("photosculpt-{0}-{1}.jpg", material, "specular");
			texturePath = Path.Combine(basePath, textureFilename);
			if (File.Exists(texturePath)) {
				try {
					Image textureImage = ImageCodec.Instance.Load(texturePath);
					Texture2d texture = new Texture2d();

					texture.GenerateMipmaps();
					texture.SamplerParams.MinFilter = TextureMinFilter.LinearMipmapNearest;
					texture.SamplerParams.WrapCoordR = TextureWrapMode.Repeat;
					texture.SamplerParams.WrapCoordS = TextureWrapMode.Repeat;
					texture.Create(textureImage);

					sphereMaterial.FrontMaterialSpecularTexture = texture;
					sphereMaterial.FrontMaterialSpecularTexCoord = 0;
				} catch (Exception exception) {
					throw new InvalidOperationException(String.Format("unable to load texture {0}", texturePath), exception);
				}
			}

			textureFilename = String.Format("photosculpt-{0}-{1}.jpg", material, "ambientocclusion");
			texturePath = Path.Combine(basePath, textureFilename);
			if (File.Exists(texturePath)) {
				try {
					Image textureImage = ImageCodec.Instance.Load(texturePath);
					Texture2d texture = new Texture2d();

					texture.GenerateMipmaps();
					texture.SamplerParams.MinFilter = TextureMinFilter.LinearMipmapNearest;
					texture.SamplerParams.WrapCoordR = TextureWrapMode.Repeat;
					texture.SamplerParams.WrapCoordS = TextureWrapMode.Repeat;
					texture.Create(textureImage);

					sphereMaterial.FrontMaterialAmbientTexture = texture;
					sphereMaterial.FrontMaterialAmbientTexCoord = 0;
				} catch (Exception exception) {
					throw new InvalidOperationException(String.Format("unable to load texture {0}", texturePath), exception);
				}
			}

			textureFilename = String.Format("photosculpt-{0}-{1}.jpg", material, "displace");
			texturePath = Path.Combine(basePath, textureFilename);
			if (File.Exists(texturePath)) {
				try {
					Image textureImage = ImageCodec.Instance.Load(texturePath);
					Texture2d texture = new Texture2d();

					// texture.RequestMipmapsCreation();
					texture.SamplerParams.WrapCoordR = TextureWrapMode.Repeat;
					texture.SamplerParams.WrapCoordS = TextureWrapMode.Repeat;
					texture.SamplerParams.MinFilter = TextureMinFilter.Nearest;
					texture.SamplerParams.MagFilter = TextureMagFilter.Nearest;
					texture.MipmapMaxLevel = 0;
					texture.Create(textureImage);

					sphereMaterial.FrontMaterialDisplacementTexture = texture;
					// sphereMaterial.FrontMaterialDisplacementTexCoord = 0;
					sphereMaterial.FrontMaterialDisplacementFactor = 0.2f;
				} catch (Exception exception) {
					throw new InvalidOperationException(String.Format("unable to load texture {0}", texturePath), exception);
				}
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

			skyboxObject.LocalModelView = Matrix4x4f.Scaled(170.0f, 170.0f, 170.0f);

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
			skyboxObject.VertexArray = new VertexArrays();
			skyboxObject.VertexArray.SetArray(_CubeArrayPosition, VertexArraySemantic.Position);
			skyboxObject.VertexArray.SetElementArray(PrimitiveType.Triangles);
			skyboxObject.VertexArray.Create(_Context);

			#endregion

			return (skyboxObject);
		}

		#endregion

		#region Mesh Loading

		private SceneObject CreateBumbleBeeRB()
		{
			SceneObject bumbleBee = SceneObjectCodec.Instance.Load(@"Data\BumbleBee\RB-BumbleBee.obj");

			bumbleBee.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			bumbleBee.LocalModelView =
				Matrix4x4f.Translated(0.0f, 0.0f, 0.0f) *
				Matrix4x4f.Scaled(0.03f, 0.03f, 0.03f) *
				Matrix4x4f.RotatedX(-90.0f) *
				Matrix4x4f.RotatedZ(+90.0f);

			bumbleBee.ObjectFlags = SceneObjectFlags.BoundingBox;

			return bumbleBee;
		}

		private SceneObject CreateBumbleBeeVH()
		{
			SceneObject bumbleBee = SceneObjectCodec.Instance.Load(@"Data\BumbleBee\VH-BumbleBee.obj");

			bumbleBee.ObjectState.DefineState(new CullFaceState(FrontFaceDirection.Ccw, CullFaceMode.Back));
			bumbleBee.LocalModelView =
				Matrix4x4f.Translated(-10.0f, 0.0f, 0.0f) *
				Matrix4x4f.Scaled(0.03f, 0.03f, 0.03f) *
				Matrix4x4f.RotatedX(-90.0f) *
				Matrix4x4f.RotatedZ(+90.0f);

			bumbleBee.ObjectFlags = SceneObjectFlags.BoundingBox;

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
			_CubeScene = new SceneGraph(SceneGraphFlags.None) {
				SceneRoot = new SceneObjectGeometry(),
				CurrentView = new SceneObjectCamera()
			};

			// Root object
			// _CubeScene.SceneRoot.ObjectState.DefineState(new DepthTestState(DepthFunction.Less));

			// Camera object
			_CubeScene.SceneRoot.Link(_CubeScene.CurrentView);

			// Horizontal plane
			_CubeScene.SceneRoot.Link(CreatePlane());

			// Create scene resource
			_CubeScene.Create(_Context);

			Gl.ClearColor(0.1f, 0.1f, 0.1f, 0.0f);

			Gl.Enable(EnableCap.Multisample);
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
			GlControl senderControl = (GlControl)sender;
			float senderAspectRatio = (float)senderControl.Width / senderControl.Height;

			// Clear
			Gl.Viewport(0, 0, senderControl.Width, senderControl.Height);
			Gl.ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
			Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			_CubeScene.CurrentView.ProjectionMatrix = Matrix4x4f.Perspective(45.0f, senderAspectRatio, 0.1f, 100.0f);
			// _CubeScene.CurrentView.LocalModelView = Matrix4x4f.Translated(0.0f, 0.0f, 10.0f);
			//_CubeScene.CurrentView.LocalModelView =
			//	Matrix4x4f.Translated(_ViewStrideLat, _ViewStrideAlt, 0.0f) *
			//	Matrix4x4f.RotatedY(_ViewAzimuth) *
			//	Matrix4x4f.RotatedX(_ViewElevation) *
			//	Matrix4x4f.Translated(0.0f, 0.0f, _ViewLever);
			//_CubeScene.CurrentView.LocalModelView =
			//	Matrix4x4f.Translated(0.0f, 0.0f, _ViewLever) *
			//	Matrix4x4f.RotatedX(_ViewElevation) *
			//	Matrix4x4f.RotatedY(_ViewAzimuth) *
			//	Matrix4x4f.Translated(_ViewStrideLat, _ViewStrideAlt, 0.0f);
			_CubeScene.UpdateViewMatrix();

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

		private void UpdateGlobalLight()
		{
			float az = Angle.ToRadians(_GlobalLightAz);
			float el = Angle.ToRadians(_GlobalLightEl);
			float xAz = (float)Math.Cos(az), yAz = (float)Math.Sin(az);
			float xEl = (float)Math.Cos(el), yEl = (float)Math.Sin(el);

			Vertex3f dir = new Vertex3f(
				xAz, yEl, yAz
			);

			// _GlobalLightObject.Direction = dir.Normalized;
		}

		private float _GlobalLightAz, _GlobalLightEl;

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
				System.Drawing.Point delta = _Mouse.Value - (System.Drawing.Size)e.Location;

				_ViewAzimuth += delta.X * 0.5f;
				_ViewElevation += delta.Y * 0.5f;

				_Mouse = e.Location;
			}
		}

		private void ObjectsControl_MouseUp(object sender, MouseEventArgs e)
		{
			_Mouse = null;
		}

		private System.Drawing.Point? _Mouse;

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

					case Keys.J:
						_GlobalLightAz += 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.L:
						_GlobalLightAz -= 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.I:
						_GlobalLightEl += 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.K:
						_GlobalLightEl -= 1.0f;
						UpdateGlobalLight();
						break;
				}
			}

			ObjectsControl.Invalidate();
		}

		#endregion

		#endregion
	}
}
