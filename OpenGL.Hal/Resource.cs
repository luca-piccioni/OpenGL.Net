
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Any resource that manage a considerable amount of resources.
	/// </summary>
	public class Resource : IResource
	{
		#region Constructors

		/// <summary>
		/// Construct a Resource.
		/// </summary>
		protected Resource()
		{
			try {
				// Track resource lifetime
				TrackResourceLifetime();
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Resource Lifetime

		/// <summary>
		/// 
		/// </summary>
		public static void CheckResourceLeaks()
		{
			foreach (Resource resource in mLivingResources)
				Debug.Assert(resource.IsDisposed, String.Format("resource not disposed ({0} references), created at {1}", resource.RefCount, resource.mConstructorStackTrace));
		}

		[Conditional("DEBUG")]
		private void TrackResourceLifetime()
		{
			// Store stack trace
			mConstructorStackTrace = GetResourceConstructorStackTrace();
			// Collect this ResourceResource for lifetime tracking
			mLivingResources.Add(this);
		}

		/// <summary>
		/// Determine the GraphicsResource constructor stack trace.
		/// </summary>
		/// <returns>
		/// It returns the stack trace wat the moment of construction of thsi GraphicsResource.
		/// </returns>
		private static string GetResourceConstructorStackTrace()
		{
			string envStackTrace = Environment.StackTrace;

			// Remove leading lines
			int lineStartIndex = 0;

			for (int i = 0; i < 4; i++)
				lineStartIndex = envStackTrace.IndexOf('\n', lineStartIndex, envStackTrace.Length - lineStartIndex) + 1;

			envStackTrace = envStackTrace.Substring(lineStartIndex + 1);

			return (envStackTrace);
		}

		/// <summary>
		/// The stack trace at construction time.
		/// </summary>
		private string mConstructorStackTrace;

		/// <summary>
		/// Collect living RenderResources.
		/// </summary>
		private static readonly List<Resource> mLivingResources = new List<Resource>();

		#endregion

		#region IResource Implementation

		/// <summary>
		/// Number of shared instances of this IGraphicsResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get { return (mRefCount); } }

		/// <summary>
		/// Increment the shared IGraphicsResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			mRefCount++;
		}

		/// <summary>
		/// Decrement the shared IGraphicsResource reference count.
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
		/// The count of references for this GraphicsResource.
		/// </summary>
		private uint mRefCount;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~Resource()
		{
			Debug.Assert(IsDisposed, String.Format("resource not disposed ({0} references), created at {1}", RefCount, mConstructorStackTrace));
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
		/// A <see cref="System.Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected virtual void Dispose(bool disposing) { }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Derived classes can extend the resource disposition by overriding the method <see cref="Dispose(System.Boolean)"/>.
		/// </para>
		/// <para>
		/// The finalize will be suppressed by calling this method.
		/// </para>
		/// </remarks>
		public virtual void Dispose()
		{
			// Dispose is equivalent to DecRef()...
			// This allow using{} even on referenced variables, as long the GraphicsResource is referenced in the using block
			if (mRefCount > 0)
				mRefCount--;
			if (mRefCount > 0)
				return;

			// Do not call Dispose(bool) twice
			GC.SuppressFinalize(this);
			// Dispose this object
			Dispose(true);
			// Mark as disposed
			mDisposed = true;

			// Remove this GraphicsResource from the living ones
			mLivingResources.RemoveAll(delegate(Resource resource) { return ReferenceEquals(resource, this); });
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool mDisposed;

		#endregion
	}
}
