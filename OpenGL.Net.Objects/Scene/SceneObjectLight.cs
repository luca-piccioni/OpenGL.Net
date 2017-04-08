
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

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Base class for defining scene lighting.
	/// </summary>
	public abstract class SceneObjectLight : SceneObject
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static SceneObjectLight()
		{
			_BiasMatrix = new ModelMatrix(new float[] {
				0.5f, 0.0f, 0.0f, 0.0f,
				0.0f, 0.5f, 0.0f, 0.0f,
				0.0f, 0.0f, 0.5f, 0.0f,
				0.5f, 0.5f, 0.5f, 1.0f,
			});
		}

		/// <summary>
		/// Construct a SceneObjectLight.
		/// </summary>
		public SceneObjectLight()
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectLight.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectLight(string id) : base(id)
		{
			
		}

		/// <summary>
		/// Force static initialization for this class.
		/// </summary>
		internal static void Touch()
		{
			// Static initialization
		}

		#endregion

		#region Light Model

		/// <summary>
		/// Create the corresponding <see cref="LightsState.Light"/> for this object.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="LightsState.Light"/> equivalent to this SceneObjectLight.
		/// </returns>
		public abstract LightsState.Light ToLight(GraphicsContext ctx, SceneGraphContext sceneCtx);

		/// <summary>
		/// The internal light parameters.
		/// </summary>
		/// <param name="light">
		/// The <see cref="LightsState.Light"/> to be set.
		/// </param>
		protected void SetLightParameters(SceneGraphContext sceneCtx, LightsState.Light light)
		{
			light.AmbientColor = AmbientColor;
			light.DiffuseColor = DiffuseColor;
			light.SpecularColor = SpecularColor;

			light.ShadowMapIndex = -1;
		}

		/// <summary>
		/// Light ambient color.
		/// </summary>
		public ColorRGBA AmbientColor = ColorRGBA.ColorWhite;

		/// <summary>
		/// Light diffuse color.
		/// </summary>
		public ColorRGBA DiffuseColor = ColorRGBA.ColorWhite;

		/// <summary>
		/// Light specular color.
		/// </summary>
		public ColorRGBA SpecularColor = ColorRGBA.ColorWhite;

		#endregion

		#region Shadow Mapping

		/// <summary>
		/// Get or set whether this light defines a shadow map.
		/// </summary>
		public bool HasShadowMap
		{
			get { return (_HasShadowMap && ShadowTexture != null); }
			set { _HasShadowMap = value; }
		}

		/// <summary>
		/// Whether this light defines a shadow map.
		/// </summary>
		private bool _HasShadowMap = true;

		/// <summary>
		/// The shadow map texture.
		/// </summary>
		protected virtual Texture ShadowTexture { get { return (null); } }

		/// <summary>
		/// Allocate resources required for shadow mapping.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected virtual void LinkShadowMapResources(GraphicsContext ctx)
		{

		}

		/// <summary>
		/// Update shadow map.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		public virtual void UpdateShadowMap(GraphicsContext ctx, SceneGraph shadowGraph)
		{

		}

		/// <summary>
		/// Bias matrix for accessing shadow maps.
		/// </summary>
		protected static readonly IModelMatrix _BiasMatrix;

		#endregion

		#region SceneObject Overrides

		/// <summary>
		/// Get the object type. Used for avoiding reflection.
		/// </summary>
		public override uint ObjectType { get { return (_ObjectType); } }

		/// <summary>
		/// Get the object type of this SceneObject class.
		/// </summary>
		public static uint ClassObjectType { get { return (_ObjectType); } }

		/// <summary>
		/// The object identifier for this class of SceneObject.
		/// </summary>
		private static readonly uint _ObjectType = NextObjectType();

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Allocate resources for 
			LinkShadowMapResources(ctx);
			// Base implementation
			base.CreateObject(ctx);
		}

		#endregion
	}
}
