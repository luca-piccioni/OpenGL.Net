
// Copyright (C) 2017 Luca Piccioni
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

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Manage lights in <see cref="SceneGraph"/>.
	/// </summary>
	class SceneLightManager
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SceneLightManager()
		{
			_LightState.Push(new State.LightsState());
		}

		#endregion

		#region Light Zone Management

		/// <summary>
		/// The current zone.
		/// </summary>
		public State.LightsState CurrentZone
		{
			get { return (_LightState.Peek()); }
		}

		public void ManageObject(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");

			if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType)
				ManageObject(ctx, ctxScene, (SceneObjectLightZone)sceneObject);
			else if (sceneObject.ObjectType == SceneObjectLight.ClassObjectType)
				ManageObject(ctx, ctxScene, (SceneObjectLight)sceneObject);
		}

		public void PostObject(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");

			if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType)
				PostObject(ctx, ctxScene, (SceneObjectLightZone)sceneObject);
		}

		private void ManageObject(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObjectLightZone sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");

			if (_LightState.Count == 1)
				ShadowLights.Clear();
			_LightState.Push(new State.LightsState());

			ctxScene.GraphicsStateStack.Current.DefineState(CurrentZone);
		}

		private void PostObject(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObjectLightZone sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");

			_LightState.Pop();
			
			ctxScene.GraphicsStateStack.Current.DefineState(CurrentZone);
		}

		private void ManageObject(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObjectLight sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");

			State.LightsState.Light lightObject = sceneObject.ToLight(ctx, ctxScene);
			
			CurrentZone.Lights.Add(lightObject);

			if (sceneObject.HasShadowMap) {
				lightObject.ShadowMapIndex = ShadowLights.Count;
				if (ShadowLights.Contains(sceneObject) == false)
					ShadowLights.Add(sceneObject);
			}
		}

		/// <summary>
		/// The light state reflecting the current
		/// </summary>
		private readonly Stack<State.LightsState> _LightState = new Stack<State.LightsState>();

		#endregion

		#region Shadow Mapping

		public void GenerateShadowMaps(GraphicsContext ctx, SceneGraph sceneGraph)
		{
			if (sceneGraph == null)
				throw new ArgumentNullException("sceneGraph");

			// Push current viewport to be restore later
			State.ViewportState currentViewport = new State.ViewportState(ctx);
			foreach (SceneObjectLight sceneLight in ShadowLights) {
				using (SceneGraph shadowGraph = new SceneGraph(sceneGraph,
							//SceneGraphFlags.CullingViewFrustum | SceneGraphFlags.StateSorting
							SceneGraphFlags.None
						))
				{
					shadowGraph.SceneRoot.ObjectState.DefineState(new State.CullFaceState(CullFaceMode.Back));
					sceneLight.UpdateShadowMap(ctx, shadowGraph);
				}
			}

			// Restore viewport
			currentViewport.Apply(ctx, null);
			// Restore cull face state to default
			 State.CullFaceState.DefaultState.Apply(ctx, null);
		}

		/// <summary>
		/// Light found in <see cref="_Lights"/>, but requiring a shadow map generation.
		/// </summary>
		public readonly List<SceneObjectLight> ShadowLights = new List<SceneObjectLight>();

		#endregion
	}
}
