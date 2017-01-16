
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
		public abstract LightsState.Light ToLight(SceneGraphContext sceneCtx);

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
		}

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
		public ColorRGBA SpecularColor = ColorRGBA.ColorWhite;

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

		#endregion
	}
}
