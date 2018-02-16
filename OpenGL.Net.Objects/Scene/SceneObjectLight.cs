
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
			_BiasMatrix = new Matrix4x4f(new[] {
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
		public ColorRGBAF AmbientColor = ColorRGBAF.ColorWhite;

		/// <summary>
		/// Light diffuse color.
		/// </summary>
		public ColorRGBAF DiffuseColor = ColorRGBAF.ColorWhite;

		/// <summary>
		/// Light specular color.
		/// </summary>
		public ColorRGBAF SpecularColor = ColorRGBAF.ColorWhite;

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
		protected static readonly Matrix4x4f _BiasMatrix;

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
