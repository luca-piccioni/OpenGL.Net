
// Copyright (C) 2017 Luca Piccioni
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

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Flags controlling the <see cref="SceneObject"/>.
	/// </summary>
	[Flags]
	public enum SceneObjectFlags
	{
		None =					0x0000,

		/// <summary>
		/// The bounding-box is visible.
		/// </summary>
		BoundingBox =			0x0001,
	}
}
