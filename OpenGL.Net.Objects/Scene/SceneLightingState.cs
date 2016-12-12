
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

		/// <summary>
		/// Currently active lights.
		/// </summary>
		public readonly List<Scene.Light> SceneLights = new List<Scene.Light>();

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
				Light[] lights = new Light[SceneLights.Count];

				for (int i = 0; i < SceneLights.Count; i++)
					lights[i] = SceneLights[i].ToLightState(CurrentSceneContext);

				return (lights);
			}
		}

		/// <summary>
		/// The enabled lights count.
		/// </summary>
		[ShaderUniformState()]
		public override int LightsCount { get { return (SceneLights.Count); } }

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
