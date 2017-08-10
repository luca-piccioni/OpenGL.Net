
// Copyright (C) 2016-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Runtime.CompilerServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// 
	/// </summary>
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
