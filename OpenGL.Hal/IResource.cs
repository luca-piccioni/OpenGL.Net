
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
	/// A shared resource.
	/// </summary>
	public interface IResource : IDisposable
	{
		#region Resource Sharing

		/// <summary>
		/// Number of shared instances of this IResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances. In this way, typical IDisposable
		/// implementation wouldn't throw exception because the resource is referenced.
		/// </remarks>
		uint RefCount { get; }

		/// <summary>
		/// Increment the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the IResource to be disposed, acquiring a sort
		/// of ownership of this instance.
		/// </remarks>
		void IncRef();

		/// <summary>
		/// Decrement the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed using .
		/// </para>
		/// <para>
		/// This method should be meant almost equals to <see cref="IDisposable.Dispose"/> method (since it can dispose
		/// conditionally the instance). Sadly, code analysis tools could detect that IDisposable fields won't be disposed
		/// by some classes.
		/// </para>
		/// </remarks>
		void DecRef();

		#endregion
	}
}
