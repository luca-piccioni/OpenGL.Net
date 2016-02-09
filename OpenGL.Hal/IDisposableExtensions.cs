
using System;
using System.Runtime.CompilerServices;

namespace OpenGL
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
