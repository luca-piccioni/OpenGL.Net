
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
	/// <summary>
	/// Generic scene object informations.
	/// </summary>
	public class SceneObjectInfo : MediaInfo
	{
		#region SceneObject Tags

		/// <summary>
		/// The media semantic
		/// </summary>
		[MediaInfoTag(typeof(string))]
		public const string TagContainerFormat = "ContainerFormat";

		#endregion

		#region Image Information

		/// <summary>
		/// The image container format.
		/// </summary>
		public string ContainerFormat
		{
			get { return (GetTag<string>(TagContainerFormat)); }
			set { SetTag(TagContainerFormat, value); }
		}

		#endregion
	}
}
