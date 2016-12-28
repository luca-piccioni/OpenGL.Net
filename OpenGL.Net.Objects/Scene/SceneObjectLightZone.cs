
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

using System.Collections.Generic;

namespace OpenGL.Objects.Scene
{
	public class SceneObjectLightZone : SceneObjectLight
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneObjectLightZone.
		/// </summary>
		public SceneObjectLightZone()
		{
			ObjectState.DefineState(new SceneLightingState());
		}

		/// <summary>
		/// Construct a SceneObjectLightZone.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectLightZone(string id) : base(id)
		{
			ObjectState.DefineState(new SceneLightingState());
		}

		#endregion

		#region SceneObjectLight Overrides

		/// <summary>
		/// Update this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected internal override void UpdateThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			List<SceneObject> lightObjects = FindChildren(delegate(SceneObject item) { return (item is SceneObjectLight); });

			SceneLightingState lightingState = (SceneLightingState)ObjectState[SceneLightingState.StateSetIndex];

			lightingState.CurrentSceneContext = ctxScene;
			lightingState.ResetLights();
			lightingState.AddLights(lightObjects.ConvertAll(delegate(SceneObject item) { return ((SceneObjectLight)item); }));
		}

		#endregion
	}
}
