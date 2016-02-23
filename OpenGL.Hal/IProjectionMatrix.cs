
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

namespace OpenGL
{
	/// <summary>
	/// Common interface implemented by <see cref="ProjectionMatrix"/> and <see cref="ProjectionMatrixDouble"/> classes.
	/// </summary>
	public interface IProjectionMatrix : IMatrix4x4
	{
		/// <summary>
		/// Get the near plane distance of this projection matrix.
		/// </summary>
		double Near { get; }

		/// <summary>
		/// Get the far plane distance of this projection matrix.
		/// </summary>
		double Far { get; }
	}
}
