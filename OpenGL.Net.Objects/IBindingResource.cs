
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Interface implemented by those objects that can be bound to a graphics context.
	/// </summary>
	public interface IBindingResource
	{
		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		int BindingTarget { get; }

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void Bind(GraphicsContext ctx);

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void Unbind(GraphicsContext ctx);

		/// <summary>
		/// Check whether this IBindingResource is currently bound on the specified graphics context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for querying the current binding state.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this IBindingResource is currently bound on <paramref name="ctx"/>.
		/// </returns>
		bool IsBound(GraphicsContext ctx);
	}
}
