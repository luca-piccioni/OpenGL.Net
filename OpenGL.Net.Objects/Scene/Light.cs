
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
	/// Light abstraction.
	/// </summary>
	public abstract class Light
	{
		#region Properties

		/// <summary>
		/// Light ambient color.
		/// </summary>
		public ColorRGBA AmbientColor = ColorRGBA.ColorBlack;

		/// <summary>
		/// Light diffuse color.
		/// </summary>
		public ColorRGBA DiffuseColor = ColorRGBA.ColorWhite;

		/// <summary>
		/// Light specular color.
		/// </summary>
		public ColorRGBA SpecularColor = ColorRGBA.ColorBlack;

		#endregion

		#region Abstract Interface

		/// <summary>
		/// Convert to <see cref="LightsStateBase.Light"/>.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="LightsStateBase.Light"/> corresponding o this Light.
		/// </returns>
		internal virtual LightsStateBase.Light ToLightState(SceneGraphContext sceneCtx)
		{
			LightsStateBase.Light lightState = new LightsStateBase.Light();

			lightState.AmbientColor = AmbientColor;
			lightState.DiffuseColor = DiffuseColor;
			lightState.SpecularColor = SpecularColor;

			return (lightState);
		}

		#endregion
	}
}
