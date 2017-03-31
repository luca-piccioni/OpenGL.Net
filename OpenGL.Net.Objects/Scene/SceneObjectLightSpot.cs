
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
		public Vertex3 Direction;

		/// <summary>
		/// Fall-off angle, in degrees.
		/// </summary>
		public float FalloffAngle;

		/// <summary>
		/// Fall-off exponent.
		/// </summary>
		public float FalloffExponent;

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
		private Texture2d _ShadowMap;

		/// <summary>
		/// Shadow program.
		/// </summary>
		private ShaderProgram _ShadowProgram;

		/// <summary>
		/// The matrix required for projecting world space vertex to light view space.
		/// </summary>
		private IMatrix4x4 _ShadowViewMatrix;

		#endregion

		#region SceneObjectLight Overrides

		/// <summary>
		/// Create the corresponding <see cref="LightsState.Light"/> for this object.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="LightsState.Light"/> equivalent to this SceneObjectLight.
		/// </returns>
		public override LightsState.Light ToLight(GraphicsContext ctx, SceneGraphContext sceneCtx)
		{
			LightsState.LightSpot light = new LightsState.LightSpot();

			SetLightParameters(sceneCtx, light);

			IModelMatrix worldModel = WorldModel;
			IMatrix3x3 normalMatrix = worldModel.GetComplementMatrix(3, 3).GetInverseMatrix().Transpose();

			light.Direction = ((Vertex3f)normalMatrix.Multiply((Vertex3f)Direction)).Normalized;
			light.Position = (Vertex3f)worldModel.Multiply(Vertex3f.Zero);
			light.AttenuationFactors = AttenuationFactors;
			light.FallOff = new Vertex2f((float)Math.Cos(Angle.ToRadians(FalloffAngle)), FalloffExponent);

			// Shadow mapping
			if (_ShadowMap != null && _ShadowViewMatrix != null) {
				light.ShadowMapIndex =  (int)_ShadowMap.GetTextureUnit(ctx);
				light.ShadowMapMvp.Set(_BiasMatrix.Multiply(_ShadowViewMatrix));
				light.ShadowMap2D = _ShadowMap;
			} else {
				light.ShadowMapIndex = -1;
				light.ShadowMap2D = null;
			}

			return (light);
		}

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
				_ShadowMapSize = (uint)Math.Min(Gl.CurrentLimits.MaxTexture2DSize, _ShadowMapSize);

				LinkResource(_ShadowMap = new Texture2d(_ShadowMapSize, _ShadowMapSize, ShadowMapFormat));
				_ShadowMap.SamplerParams.MinFilter = TextureMinFilter.Nearest;
				_ShadowMap.SamplerParams.MagFilter = TextureMagFilter.Nearest;
				_ShadowMap.SamplerParams.WrapCoordS = _ShadowMap.SamplerParams.WrapCoordT = TextureWrapMode.Repeat;
				_ShadowMap.SamplerParams.CompareMode = true;
			}

			if (_ShadowFramebuffer == null) {
				LinkResource(_ShadowFramebuffer = new Framebuffer());
				_ShadowFramebuffer.AttachDepth(_ShadowMap);
			}
			
			if (_ShadowProgram == null)
				LinkResource(_ShadowProgram = ctx.CreateProgram("OpenGL.ShadowMap"));
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

			// Set light view
			shadowGraph.LocalProjection = new PerspectiveProjectionMatrix(FalloffAngle, 1.0f, 0.1f, 100.0f);
			shadowGraph.LocalModel = LocalModel;

			_ShadowFramebuffer.BindDraw(ctx);
			_ShadowFramebuffer.Clear(ctx, ClearBufferMask.DepthBufferBit);

			//WriteMaskState.NonColorMaskState.Apply(ctx, null);

			shadowGraph.Draw(ctx, _ShadowProgram);

			_ShadowFramebuffer.UnbindDraw(ctx);

			// View matrix snapshot
			_ShadowViewMatrix = LocalModel.GetInverseMatrix();

			//WriteMaskState.DefaultState.Apply(ctx, null);
		}

		#endregion
	}
}
