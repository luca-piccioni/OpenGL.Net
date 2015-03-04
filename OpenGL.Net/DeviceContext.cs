
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Device context.
	/// </summary>
	public abstract class DeviceContext : IDeviceContext
	{
		#region IDeviceContext Implementation

		/// <summary>
		/// Number of shared instances of this IRenderResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get { return (mRefCount); } }

		/// <summary>
		/// Increment the shared IRenderResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			mRefCount++;
		}

		/// <summary>
		/// Decrement the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed.
		/// </remarks>
		public void DecRef()
		{
			// Instance could be never referenced with IncRef
			if (mRefCount > 0)
				mRefCount--;

			// Automatically dispose when no references are available
			if (mRefCount == 0)
				Dispose();
		}

		/// <summary>
		/// Reset the reference count of this instance.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This should be used in normal code.
		/// </para>
		/// <para>
		/// This routine could be useful in the case the deep-copoy implementation uses <see cref="Object.MemberwiseClone"/>,
		/// indeed copying the reference count.
		/// </para>
		/// </remarks>
		protected void ResetRefCount() { mRefCount = 0; }

		/// <summary>
		/// The count of references for this RenderResource.
		/// </summary>
		private uint mRefCount;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~DeviceContext()
		{
			Debug.Assert(IsDisposed);
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
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				// Mark as disposed
				mDisposed = true;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			GC.SuppressFinalize(this);
			Dispose(true);
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool mDisposed;

		#endregion
	}
}

