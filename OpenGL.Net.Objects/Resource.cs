
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects
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
		[Conditional("DEBUG")]
		public static void CheckResourceLeaks()
		{
			if (_LivingResources.Count > 0) {
				Log("Leaking {0} resources.", _LivingResources.Count);
				foreach (Resource resource in _LivingResources) {
					Log("Resource {0} (ref count: {1}, disposed: {2})", resource.GetType().Name, resource.RefCount, resource.IsDisposed);
				}
			} else
				Log("No resource leak.");
		}

		[Conditional("DEBUG")]
		private void NotifyDiedResource()
		{
			// Remove this GraphicsResource from the living ones
			bool res = _LivingResources.Remove(this);
			Debug.Assert(res);
		}

		[Conditional("DEBUG")]
		private void TrackResourceLifetime()
		{
			// Store stack trace
			_ConstructorStackTrace = GetResourceConstructorStackTrace();
			// Collect this ResourceResource for lifetime tracking
			_LivingResources.Add(this);
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
		private string _ConstructorStackTrace;

		/// <summary>
		/// Collect living RenderResources.
		/// </summary>
		private static readonly List<Resource> _LivingResources = new List<Resource>();

		#endregion

		#region Resource Management

		/// <summary>
		/// Link a resource used by this UserGraphicsResource.
		/// </summary>
		/// <param name="resource">
		/// The <see cref="IResource"/> that will be linked by this UserGraphicsResource. It will be referenced till
		/// this instance disposition. You should not manually reference this instance for the UserGraphicsResource lifetime.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resource"/> is null.
		/// </exception>
		protected void LinkResource(IResource resource)
		{
			if (resource == null)
				throw new ArgumentNullException("resource");

			// Reference resources
			resource.IncRef();
			// Unreference at disposition
			Debug.Assert(!_Resources.Contains(resource));
			_Resources.Add(resource);
		}

		/// <summary>
		/// Unlink a resource used by this UserGraphicsResource.
		/// </summary>
		/// <param name="resource">
		/// The <see cref="IResource"/> that will be unlinked from this UserGraphicsResource. It will be unreferenced.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resource"/> is null.
		/// </exception>
		protected void UnlinkResource(IResource resource)
		{
			if (resource == null)
				throw new ArgumentNullException("resource");

			// Unreference at disposition
			bool res = _Resources.Remove(resource);
			Debug.Assert(res);
			// No more referenced
			resource.DecRef();
		}

		/// <summary>
		/// Unlink all resources.
		/// </summary>
		private void UnlinkResources()
		{
			foreach (IResource resource in _Resources)
				resource.DecRef();
			_Resources.Clear();
		}

		/// <summary>
		/// Replace a linked resource with another one.
		/// </summary>
		/// <typeparam name="T">
		/// Any type implementing <see cref="IResource"/>
		/// </typeparam>
		/// <param name="value">
		/// The <typeparamref name="T"/> that replace the current resource.
		/// </param>
		/// <param name="current">
		/// The <typeparamref name="T"/> currently linked to this Resource.
		/// </param>
		protected void SwapResources<T>(T value, ref T current) where T : IResource
		{
			if (current != null)
				UnlinkResource(current);
			current = value;
			if (value != null)
				LinkResource(value);
		}

		/// <summary>
		/// Resources used by this UserGraphicsResource.
		/// </summary>
		private readonly List<IResource> _Resources = new List<IResource>();

		#endregion

		#region Resource Logging

		/// <summary>
		/// Delegate used for logging using application procedures.
		/// </summary>
		public delegate void ProcedureLogDelegate(string format, params object[] args);

		/// <summary>
		/// Register a callback used to notify the application about a procedure log.
		/// </summary>
		/// <param name="callback">
		/// The <see cref="ProcedureLogDelegate"/> used to notify application about a procedure log event.
		/// </param>
		public static void RegisterApplicationLogDelegate(ProcedureLogDelegate callback)
		{
			_ProcLogCallbacks.Add(callback);

			// Automatically query information
			_ProcLogEnabled = _ProcLogCallbacks.Count == 1;
		}

		/// <summary>
		/// Delegate for logging using application framework.
		/// </summary>
		private static readonly List<ProcedureLogDelegate> _ProcLogCallbacks = new List<ProcedureLogDelegate>();

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		public static bool LogEnabled { get { return (_ProcLogEnabled); } set { _ProcLogEnabled = value; } }

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		private static bool _ProcLogEnabled;

		/// <summary>
		/// Log a procedure call.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specifies the format string.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments of the <paramref name="format"/>.
		/// </param>
		[Conditional("GL_DEBUG")]
		protected internal static void Log(string format, params object[] args)
		{
			if (format == null)
				throw new ArgumentNullException("format");

			// Global flag
			if (_ProcLogEnabled == false)
				return;

			foreach (ProcedureLogDelegate logDelegate in _ProcLogCallbacks) {
				try {
					logDelegate(format, args);
				} catch { }
			}
		}

		#endregion

		#region IResource Implementation

		/// <summary>
		/// Number of shared instances of this IGraphicsResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get { return (_RefCount); } }

		/// <summary>
		/// Increment the shared IGraphicsResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			_RefCount++;
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
			// Debug.Assert(_RefCount > 0);
			if (_RefCount > 0)
				_RefCount--;

			// Automatically dispose when no references are available
			if (_RefCount == 0)
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
		protected void ResetRefCount() { _RefCount = 0; }

		/// <summary>
		/// The count of references for this GraphicsResource.
		/// </summary>
		private uint _RefCount;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~Resource()
		{
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get { return (_Disposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
				UnlinkResources();
		}

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
			// Avoid re-run of Dispose
			if (_Disposed) return;

			// Dispose is equivalent to DecRef()...
			// This allow using{} even on referenced variables, as long the GraphicsResource is referenced in the using block
			if (_RefCount > 0)
				_RefCount--;
			if (_RefCount > 0)
				return;

			// Do not call Dispose(bool) twice
			GC.SuppressFinalize(this);
			// Dispose this object
			Dispose(_Disposed = true);
			// Mark as disposed
			NotifyDiedResource();
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		protected bool _Disposed;

		#endregion
	}
}
