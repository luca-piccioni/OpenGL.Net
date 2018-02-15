
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
using System.Collections.Generic;
using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Base class for defining scene lighting.
	/// </summary>
	public class SceneObjectLightSpot : SceneObjectLightPoint
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneObjectLightSpot.
		/// </summary>
		public SceneObjectLightSpot()
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectLightSpot.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectLightSpot(string id) : base(id)
		{
			
		}

		#endregion

		#region Light Model

		/// <summary>
		/// Direction of the spot.
		/// </summary>
		public Vertex3f Direction;

		/// <summary>
		/// Fall-off angle, in degrees.
		/// </summary>
		public float FalloffAngle;

		/// <summary>
		/// Fall-off exponent.
		/// </summary>
		public float FalloffExponent;

		/// <summary>
		/// The matrix describing the orientation of the spot light.
		/// </summary>
		private Matrix4x4f LightMatrix
		{
			get
			{
				Vertex3f lightRotationAxis = Direction ^ -Vertex3f.UnitZ;
				float lightRotationAngle = (float)Angle.ToDegrees(Math.Acos(-Vertex3f.UnitZ * Direction));

				return ((Matrix4x4f)new Quaternion(lightRotationAxis, lightRotationAngle));
			}
		}

		#endregion

		#region Shadow Mapping

		/// <summary>
		/// Get or set the shadow map size, in pixels.
		/// </summary>
		public uint ShadowMapSize
		{
			get { return (_ShadowMapSize); }
			set
			{
				if (_ShadowMap != null)
					throw new InvalidOperationException("already created");
				_ShadowMapSize = value;
			}
		}

		/// <summary>
		/// Shadow map size, in pixels.
		/// </summary>
		private uint _ShadowMapSize = 1024;

		/// <summary>
		/// Get or set the shadow map size, in pixels.
		/// </summary>
		public PixelLayout ShadowMapFormat
		{
			get { return (_ShadowMapFormat); }
			set
			{
				if (_ShadowMap != null)
					throw new InvalidOperationException("already created");

				switch (value) {
					case PixelLayout.Depth16:
					case PixelLayout.Depth24:
					case PixelLayout.Depth32:
					case PixelLayout.DepthF:
						_ShadowMapFormat = value;
						break;
					default:
						throw new InvalidOperationException("not a depth format");
				}
			}
		}

		/// <summary>
		/// Shadow map internal format.
		/// </summary>
		private PixelLayout _ShadowMapFormat = PixelLayout.Depth24;

		/// <summary>
		/// Framebuffer for shadow map generation.
		/// </summary>
		private Framebuffer _ShadowFramebuffer;

		/// <summary>
		/// Shadow map.
		/// </summary>
		internal Texture2d _ShadowMap;

		/// <summary>
		/// Shadow program.
		/// </summary>
		private ShaderProgram _ShadowProgram;

		/// <summary>
		/// The matrix required for projecting world space vertex to light view space.
		/// </summary>
		private Matrix4x4f _ShadowViewMatrix;

		#endregion

		#region Bounding Volume

		private void LinkBoundingVolumeResources(GraphicsContext ctx)
		{
			string resourceClassId = "OpenGL.Objects.SceneObjectLightSpot.BoundingVolume";

			#region Arrays

			string arrayId = resourceClassId + ".Array";

			if ((_BoundingVolumeArrays = (VertexArrays)ctx.GetSharedResource(arrayId)) == null) {
				_BoundingVolumeArrays = VertexArrays.CreateCone(1.0f, 1.0f, 16);
				_BoundingVolumeArrays.Create(ctx);
				ctx.SetSharedResource(arrayId, _BoundingVolumeArrays);
			}
			LinkResource(_BoundingVolumeArrays);

			#endregion

			#region Program

			string programId = resourceClassId + ".Program";

			if ((_BoundingVolumeProgram = (ShaderProgram)ctx.GetSharedResource(programId)) == null) {
				_BoundingVolumeProgram = ctx.CreateProgram("OpenGL.Standard");
				ctx.SetSharedResource(programId, _BoundingVolumeProgram);
			}
			LinkResource(_BoundingVolumeArrays);

			#endregion
		}

		/// <summary>
		/// Arrays used for representing the light bounding volume.
		/// </summary>
		private VertexArrays _BoundingVolumeArrays;

		/// <summary>
		/// Program used for drawing <see cref="_BoundingVolumeArrays"/>.
		/// </summary>
		private ShaderProgram _BoundingVolumeProgram;

		#endregion

		#region SceneObjectLight Overrides

		internal override IEnumerable<SceneObjectBatch> GetGeometries(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {
				GraphicsStateSet boundingVolumeState = ctxScene.GraphicsStateStack.Current.Push();

				// Transform
				TransformState boundingVolumeModel = (TransformState)boundingVolumeState[TransformState.StateSetIndex];

				float lightVolumeDepth = 100.0f;
				float lightVolumeSize = lightVolumeDepth * (float)Math.Tan(Angle.ToRadians(FalloffAngle));

				boundingVolumeModel.ModelViewProjection =
					(boundingVolumeModel.ModelViewProjection * LightMatrix) *
					Matrix4x4f.Translated(0.0f, 0.0f, lightVolumeDepth) *
					Matrix4x4f.Scaled(lightVolumeSize, lightVolumeSize, lightVolumeDepth);

				// Uniform color
				ShaderUniformState uniformState = new ShaderUniformState("UniformState");
				uniformState.SetUniformState("glo_UniformColor", new ColorRGBAF(1.0f, 1.0f, 0.0f, 0.5f));
				boundingVolumeState.DefineState(uniformState);
				// Alpha blending
				boundingVolumeState.DefineState(BlendState.AlphaBlending);

				yield return new SceneObjectBatch(
					_BoundingVolumeArrays,
					boundingVolumeState,
					_BoundingVolumeProgram
				);
			}

			yield break;
		}

		/// <summary>
		/// Create the corresponding <see cref="LightsState.Light"/> for this object.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="LightsState.Light"/> equivalent to this SceneObjectLight.
		/// </returns>
		public override LightsState.Light ToLight(GraphicsContext ctx, SceneGraphContext sceneCtx)
		{
			TransformState transformState = (TransformState)sceneCtx.GraphicsStateStack.Current[TransformState.StateSetIndex];
			LightsState.LightSpot light = new LightsState.LightSpot();

			SetLightParameters(sceneCtx, light);

			Matrix4x4f worldModel = transformState.ModelView;
			Matrix3x3f normalMatrix = new Matrix3x3f(worldModel, 3, 3).Inverse.Transposed;

			light.Direction = (normalMatrix * (Vertex3f)Direction).Normalized;
			light.Position = (Vertex3f)(worldModel * Vertex3f.Zero);
			light.AttenuationFactors = AttenuationFactors;
			light.FallOff = new Vertex2f((float)Math.Cos(Angle.ToRadians(FalloffAngle)), FalloffExponent);

			// Shadow mapping
			if (_ShadowMap != null) {
				// Determined later: light.ShadowMapIndex
				light.ShadowMapMvp = _ShadowViewMatrix;
				light.ShadowMap2D = _ShadowMap;
			} else {
				light.ShadowMapIndex = -1;
				light.ShadowMap2D = null;
			}

			return (light);
		}

		/// <summary>
		/// The shadow map texture.
		/// </summary>
		protected override Texture ShadowTexture { get { return (_ShadowMap); } }

		/// <summary>
		/// Allocate resources required for shadow mapping.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void LinkShadowMapResources(GraphicsContext ctx)
		{
			if (_ShadowMap == null) {
				// Eventually clamp shadow map size to the current implementation limit
				_ShadowMapSize = (uint)Math.Min(Gl.CurrentLimits.MaxTextureSize, _ShadowMapSize);

				LinkResource(_ShadowMap = new Texture2d(_ShadowMapSize, _ShadowMapSize, ShadowMapFormat));
				_ShadowMap.SamplerParams.MinFilter = TextureMinFilter.Nearest;
				_ShadowMap.SamplerParams.MagFilter = TextureMagFilter.Nearest;
#if !MONODROID
				_ShadowMap.SamplerParams.WrapCoordS = _ShadowMap.SamplerParams.WrapCoordT = TextureWrapMode.Clamp;
#endif
				_ShadowMap.SamplerParams.CompareMode = true;
				_ShadowMap.SamplerParams.CompareFunc = DepthFunction.Less;
			}

			if (_ShadowFramebuffer == null) {
				LinkResource(_ShadowFramebuffer = new Framebuffer());
				_ShadowFramebuffer.AttachDepth(_ShadowMap);
			}
			
			if (_ShadowProgram == null)
				LinkResource(_ShadowProgram = ctx.CreateProgram("OpenGL.Specialized+Depth"));
		}

		/// <summary>
		/// Update shadow map.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		public override void UpdateShadowMap(GraphicsContext ctx, SceneGraph shadowGraph)
		{
			CheckCurrentContext(ctx);
			if (shadowGraph == null)
				throw new ArgumentNullException("shadowGraph");

			// Compute light matrix
			Matrix4x4f viewMatrix = Matrix4x4f.LookAtDirection(LocalModelView.Value.Position, (Vertex3f)Direction, Vertex3f.UnitY); // LocalModel.Multiply(LightMatrix.GetInverseMatrix()).GetInverseMatrix();

			// Set light scene view
			shadowGraph.ProjectionMatrix = Matrix4x4f.Perspective(FalloffAngle * 2.0f, 1.0f, 0.1f, 100.0f);
			shadowGraph.ViewMatrix = viewMatrix;

			_ShadowFramebuffer.BindDraw(ctx);

			// Reset viewport
			new ViewportState(0, 0, (int)_ShadowMap.Width, (int)_ShadowMap.Height).Apply(ctx, null);

			_ShadowFramebuffer.Clear(ctx, ClearBufferMask.DepthBufferBit);

			shadowGraph.Draw(ctx, _ShadowProgram);

			_ShadowFramebuffer.UnbindDraw(ctx);

			// Cache view matrix
			_ShadowViewMatrix = _BiasMatrix * shadowGraph.ProjectionMatrix * viewMatrix;
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Allocate resources for light bounding volume rendering
			LinkBoundingVolumeResources(ctx);
			// Base implementation
			base.CreateObject(ctx);
		}

		#endregion
	}
}
