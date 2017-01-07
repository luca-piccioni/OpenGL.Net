
// Copyright (C) 2012-2016 Luca Piccioni
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

using System.Collections.Generic;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Interface for describing a volume bounding a geometry.
	/// </summary>
	public interface IBoundingVolume
	{
		/// <summary>
		/// Offset of the bounding volume w.r.t. the underlying object origin.
		/// </summary>
		Vertex3f Position { get; }

		/// <summary>
		/// Minimum distance at which the volume cannot be intersected w.r.t. <see cref="Position"/>.
		/// </summary>
		float Radius { get; }

		/// <summary>
		/// Determine whether this bound volume is clipped by all specified planes.
		/// </summary>
		/// <param name="clippingPlanes">
		/// A <see cref="IEnumerable{Plane}"/> that are used to perform geometry clipping.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this bound volume is entirely
		/// clipped by <paramref name="clippingPlanes"/>.
		/// </returns>
		bool IsClipped(IEnumerable<Plane> clippingPlanes, IMatrix4x4 viewModel);
	}
}