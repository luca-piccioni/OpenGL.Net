
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

namespace OpenGL.Scene
{
	/// <summary>
	/// Scene object representing a view point.
	/// </summary>
	public class SceneGraphCameraObject : SceneGraphObject
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneGraphCameraObject.
		/// </summary>
		public SceneGraphCameraObject()
		{
			
		}

		#endregion

		#region Camera Properties

		/// <summary>
		/// Get or set the projection for this SceneGraphCameraObject.
		/// </summary>
		public IProjectionMatrix ProjectionMatrix
		{
			get { return (_ProjectionMatrix); }
			set { _ProjectionMatrix = (IProjectionMatrix)value.Clone(); }
		}

		/// <summary>
		/// The projection defined for this SceneGraphCameraObject.
		/// </summary>
		private IProjectionMatrix _ProjectionMatrix;

		#endregion
	}
}
