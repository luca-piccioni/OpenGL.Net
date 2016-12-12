
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

namespace OpenGL.Objects.Scene
{
	public class SceneObjectLight : SceneObject
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

		#endregion

		#region Light Model

		/// <summary>
		/// Light model.
		/// </summary>
		public Light Light;

		#endregion
	}
}
