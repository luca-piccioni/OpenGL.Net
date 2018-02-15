
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
		public Vertex3f Direction = Vertex3f.UnitY;

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

			TransformState transformState = (TransformState)sceneCtx.GraphicsStateStack.Current[TransformState.StateSetIndex];
			Matrix3x3f normalMatrix = transformState.NormalMatrix;

			light.Direction = (normalMatrix * (Vertex3f)Direction).Normalized;
			light.HalfVector = (Vertex3f.UnitZ + light.Direction).Normalized;

			return (light);
		}

		#endregion
	}
}
