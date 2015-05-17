
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Interface implementated by those classes that are referenceable.
	/// </summary>
	public interface IReferenceable
	{
		/// <summary>
		/// Increment reference count of this instance.
		/// </summary>
		void Ref();

		/// <summary>
		/// Decrement reference count of this instance.
		/// </summary>
		void Unref();

		/// <summary>
		/// References the count.
		/// </summary>
		uint RefCount { get; }
	}
}

