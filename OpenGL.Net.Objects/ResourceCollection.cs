
// Copyright (C) 2012-2017 Luca Piccioni
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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// Generic collection for referencing <see cref="IResource"/> instances.
	/// </summary>
	/// <typeparam name="T">
	/// A class that implements the <see cref="IResource"/> interface.
	/// </typeparam>
	public class ResourceCollection<T> : ICollection<T>, IDisposable where T : class, IResource
	{
		#region Collection Methods

		/// <summary>
		/// Add a set of items to this collection.
		/// </summary>
		/// <param name="items">
		/// The set to add to this collection.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="items"/> is null.
		/// </exception>
		public void AddRange(IEnumerable items)
		{
			if (items == null)
				throw new ArgumentNullException("items");

			foreach (T item in items)
				if (item != null)
					Add(item);
		}

		/// <summary>
		/// Add a set of items to this collection.
		/// </summary>
		/// <param name="items">
		/// The set to add to this collection.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="items"/> is null.
		/// </exception>
		public void AddRange(IEnumerable<T> items)
		{
			if (items == null)
				throw new ArgumentNullException("items");

			foreach (T item in items)
				if (item != null)
					Add(item);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T this[int index]
		{
			get { return (mResources[index]); }
			set { mResources[index] = value; }
		}

		#endregion

		#region ICollection<IGraphicsResource> Implementation

		/// <summary>
		/// Adds an item to this collection.
		/// </summary>
		/// <param name="item">
		/// The object to add to this collection.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="item"/> is null.
		/// </exception>
		public void Add(T item)
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");
			if (item == null)
				throw new ArgumentNullException("item");

			// Reference the reasource
			item.IncRef();
			// Collect resource
			mResources.Add(item);
		}

		/// <summary>
		/// Removes all items from ththis collection.
		/// </summary>
		public void Clear()
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");

			foreach (T resource in mResources)
				resource.DecRef();
			mResources.Clear();
		}

		/// <summary>
		/// Determines whether this collection contains a specific value.
		/// </summary>
		/// <param name="item">
		/// The object to locate in this collection.
		/// </param>
		/// <returns>
		/// It returns true if item is found in this collection; otherwise, false.
		/// </returns>
		public bool Contains(T item)
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");
			return (mResources.Contains(item));
		}

		/// <summary>
		/// Copies the elements of this collection to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
		/// </summary>
		/// <param name="array">
		/// The one-dimensional <see cref="T:System.Array"/> that is the destination of the elements copied from this collection.
		/// The <see cref="T:System.Array"/> must have zero-based indexing.</param>
		/// <param name="arrayIndex">
		/// The zero-based index in array at which copying begins.
		/// </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// exception thrown if <paramref name="arrayIndex"/> is less than 0.
		/// </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="T:System.ArgumentException">
		/// Exception thrown if array is multidimensional. or <paramref name="arrayIndex"/> is equal to or greater than the length of array; or
		/// the number of elements in the source collection is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination
		/// array; or Type T cannot be cast automatically to the type of the destination array.
		/// </exception>
		public void CopyTo(T[] array, int arrayIndex)
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");
			mResources.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Removes the first occurrence of a specific object from this collection.
		/// </summary>
		/// <param name="item">
		/// The object to remove from this collection.</param>
		/// <returns>
		/// It returns true if item was successfully removed from this collection; otherwise, false. This method also
		/// returns false if item is not found in the this collection.
		/// </returns>
		public bool Remove(T item)
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");

			bool flag = mResources.Remove(item);

			if (flag)
				item.DecRef();

			return (flag);
		}

		/// <summary>
		/// Gets the number of elements contained in this collection.
		/// </summary>
		/// <returns>
		/// The number of elements contained in this collection.
		/// </returns>
		public int Count
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("ResourceCollection");
				return (mResources.Count);
			}
		}

		/// <summary>
		/// Gets a value indicating whether this collection is read-only.
		/// </summary>
		/// <returns>
		/// It returns true if this collection is read-only; otherwise, false.
		/// </returns>
		public bool IsReadOnly { get { return (false); } }

		/// <summary>
		/// The collection of resources.
		/// </summary>
		private readonly List<T> mResources = new List<T>();

		#endregion

		#region IEnumerable Implementation

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="IEnumerator{T}"/> that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator<T> GetEnumerator()
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");
			return (mResources.GetEnumerator());
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="IEnumerator"/> object that can be used to iterate through the collection.
		/// </returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			if (IsDisposed)
				throw new ObjectDisposedException("ResourceCollection");
			return GetEnumerator();
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~ResourceCollection()
		{
			Debug.Assert(IsDisposed, "ResourceCollection not disposed");
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get { return (mDisposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			// Clearing unreference all collected resources
			if (disposing)
				Clear();
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public virtual void Dispose()
		{
			// Do not call Dispose(bool) twice
			GC.SuppressFinalize(this);

			// Dispose this object
			Dispose(true);

			// Mask as disposed
			mDisposed = true;
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool mDisposed;

		#endregion
	}
}
