
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Interface implemented by those objects that can be bound to a graphics context.
	/// </summary>
	public interface IBindingIndexResource
	{
		/// <summary>
		/// Object name used for this IBindingIndexResource.
		/// </summary>
		uint ObjectName { get; }

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		BufferTarget GetBindingTarget(GraphicsContext ctx);

		/// <summary>
		/// Current binding point of the IBindingIndexResource.
		/// </summary>
		/// <remarks>
		/// The UNIFORM_BUFFER target has a binding index.
		/// </remarks>
		uint BindingIndex { get; set; }
	}
}
