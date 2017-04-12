
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Runtime.CompilerServices;

namespace OpenGL.Objects
{
	public static class IDisposableExtensions
	{
		/// <summary>
		/// Values in a ConditionalWeakTable need to be a reference type,
		/// so box the refcount int in a class.
		/// </summary>
		private class ReferenceCount
		{
			public int Count;
		}
 
		/// <summary>
		/// Increment the reference count for the specified <see cref="IDisposable"/>.
		/// </summary>
		/// <param name="disposable">
		/// The <see cref="IDisposable"/> that is referenced by multiple actors.
		/// </param>
		public static void IncRef(this IDisposable disposable)
		{
			lock (_RefCountsLock) {
				ReferenceCount refCount = _RefCounts.GetOrCreateValue(disposable);
				refCount.Count++;
			}
		}
 
		/// <summary>
		/// Decrement the reference count for the specified <see cref="IDisposable"/>.
		/// </summary>
		/// <param name="disposable">
		/// The <see cref="IDisposable"/> that is referenced by multiple actors.
		/// </param>
		/// <remarks>
		/// The <paramref name="disposable"/> instance is disposed in the case the reference count is zero after
		/// the execution of this method.
		/// </remarks>
		public static void DecRef(this IDisposable disposable)
		{
			lock (_RefCountsLock) {
				ReferenceCount refCount = _RefCounts.GetOrCreateValue(disposable);

				// Decrement reference count
				if (refCount.Count > 0)
					refCount.Count--;

				if (refCount.Count > 0)
					return;

				// No more reference
				_RefCounts.Remove(disposable);
				// Dispose it
				disposable.Dispose();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private static readonly ConditionalWeakTable<IDisposable, ReferenceCount> _RefCounts = new ConditionalWeakTable<IDisposable, ReferenceCount>();

		/// <summary>
		/// Object used for synchronizing accesses to <see cref="_RefCounts"/>.
		/// </summary>
		private static readonly object _RefCountsLock = new object();
	}
}
