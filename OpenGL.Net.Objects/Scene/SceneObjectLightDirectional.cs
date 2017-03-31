
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
	public class SceneObjectLightDirectional : SceneObjectLight
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneObjectLightDirectional.
		/// </summary>
		public SceneObjectLightDirectional()
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectLightDirectional.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectLightDirectional(string id) : base(id)
		{
			
		}

		#endregion

		#region Light Model

		/// <summary>
		/// The direction of the light source (i.e. not the light direction).
		/// </summary>
		public Vertex3 Direction = Vertex3.UnitY;

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
			LightsState.LightDirectional light = new LightsState.LightDirectional();

			SetLightParameters(sceneCtx, light);

			TransformStateBase transformState = (TransformStateBase)sceneCtx.GraphicsStateStack.Current[TransformStateBase.StateSetIndex];
			IMatrix3x3 normalMatrix = transformState.NormalMatrix;

			light.Direction = ((Vertex3f)normalMatrix.Multiply((Vertex3f)Direction)).Normalized;
			light.HalfVector = (Vertex3f.UnitZ + light.Direction).Normalized;

			return (light);
		}

		#endregion
	}
}
