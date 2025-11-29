
// Copyright (C) 2017 Luca Piccioni
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
