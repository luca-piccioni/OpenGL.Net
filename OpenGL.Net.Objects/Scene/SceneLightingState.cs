
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

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// OpenGL.Net scene graph light shading model.
	/// </summary>
	class SceneLightingState : LightsStateBase
	{
		#region Active Lights

		public void AddLights(IEnumerable<SceneObjectLight> lights)
		{
			foreach (SceneObjectLight sceneObjectLight in lights)
				if (_SceneLights.Contains(sceneObjectLight) == false)
					_SceneLights.Add(sceneObjectLight);
			UpdateLightState(CurrentSceneContext);
		}

		public void ResetLights()
		{
			_SceneLights.Clear();
			_Lights = null;
		}

		private void UpdateLightState(SceneGraphContext ctxScene)
		{
			_Lights = new Light[_SceneLights.Count];

			for (int i = 0; i < _SceneLights.Count; i++)
				_Lights[i] = _SceneLights[i].ToLightState(ctxScene);
		}

		/// <summary>
		/// Currently active lights.
		/// </summary>
		private readonly List<SceneObjectLight> _SceneLights = new List<SceneObjectLight>();

		private Light[] _Lights;

		public SceneGraphContext CurrentSceneContext;

		#endregion

		#region LightStateBase Overrides

		/// <summary>
		/// Lights state.
		/// </summary>
		[ShaderUniformState("glo_Light")]
		public override Light[] Lights
		{
			get
			{
				if (_Lights == null && _SceneLights.Count > 0)
					UpdateLightState(CurrentSceneContext);
				return (_Lights ?? new Light[0]);
			}
		}

		/// <summary>
		/// The enabled lights count.
		/// </summary>
		[ShaderUniformState()]
		public override int LightsCount { get { return (_Lights != null ? _Lights.Length : 0); } }

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a call to this routine, this IGraphicsState store the union of the previous information
		/// and of the information of <paramref name="state"/>.
		/// </para>
		/// <para>
		/// The semantic of the merge result is dependent on the actual implementation of this IGraphicsState. Normally
		/// the merge method will copy <paramref name="state"/> into this IGraphicsState, but other state could do
		/// different operations.
		/// </para>
		/// </remarks>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");

			SceneLightingState otherState = state as SceneLightingState;

			if (otherState == null)
				throw new ArgumentException("not a SceneLightingState", "state");
		}

		#endregion
	}
}
