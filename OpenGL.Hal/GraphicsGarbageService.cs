
// Copyright (C) 2010-2015 Luca Piccioni
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//   
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;

namespace OpenGL
{
	/// <summary>
	/// Generic OpenGL resource garbage collector.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class is used to collect <see cref="IGraphicsResource"/> instances for releasing resources, even if
	/// the disposing thread is not the one which the corresponding context is current on.
	/// </para>
	/// </remarks>
	public class GraphicsGarbageService : GraphicsKernelService
	{
		#region Constructors
		
		/// <summary>
		/// GraphicsGarbageService constructor.
		/// </summary>
		public GraphicsGarbageService() : base(ThisServiceName, ExecutionModel.Context)
		{
			
		}

		/// <summary>
		/// This service name.
		/// </summary>
		private static readonly string ThisServiceName = "OpenGL.GraphicsGarbageService";

		#endregion

		#region Garbage Management

		/// <summary>
		/// Collect rendering object for associated resource deletion.
		/// </summary>
		/// <param name="garbage">
		/// A <see cref="IGraphicsResource"/> which need to be released. It has to be a created object.
		/// </param>
		/// <remarks>
		/// <para>
		/// This routine collect a <see cref="IGraphicsResource"/> instance for later resource deletion. <paramref name="garbage"/>
		/// resources will be effectively released on <see cref="DeleteGarbage"/> method call with the approriate arguments.
		/// </para>
		/// <para>
		/// Note that <paramref name="garbage"/> won't be finalized by .NET runtime garbage collector until it is effectively
		/// released.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="garbage"/> is null.
		/// </exception>
		internal void CollectGarbage(IGraphicsResource garbage)
		{
			if (garbage == null)
				throw new ArgumentNullException("garbage");

			lock (mGarbageItemsLock) {
				mGarbageItems.Add(garbage);
			}
		}

		/// <summary>
		/// Count the number of collected object for a specific object space.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify the object space.
		/// </param>
		/// <returns>
		/// It returns the number of objects collected for garbage in the object space specified by <paramref name="ctx"/>.
		/// </returns>
		public uint GetGarbageObjectCount(GraphicsContext ctx)
		{
			uint count = 0;

			foreach (IGraphicsResource obj in mGarbageItems) {
				if (obj.Exists(ctx) == true)
					count++;
			}

			return (count);
		}

		/// <summary>
		/// Delete all collected garbage.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have been created (or sharing with the one) the collected
		/// objects by this service.
		/// </param>
		/// <remarks>
		/// <para>
		/// This routine calls <see cref="IGraphicsResource.Delete"/> for each collected <see cref="IGraphicsResource"/> (by using
		/// <see cref="CollectGarbage"/>).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		public void DeleteGarbage(GraphicsContext ctx)
		{
			List<IGraphicsResource> rObjectDeleted = new List<IGraphicsResource>();

			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("context not current", "ctx");

			lock (mGarbageItemsLock) {
				foreach (IGraphicsResource obj in mGarbageItems) {
					if (obj.Exists(ctx)) {
						// Collect for later remotion
						rObjectDeleted.Add(obj);
						// Always dispose (untrack object lifeftime)
						if (obj.Exists(ctx))
							obj.Delete(ctx);
						obj.Dispose();
					}
				}

				// Remove deleted resources
				foreach (IGraphicsResource obj in rObjectDeleted)
					mGarbageItems.Remove(obj);
			}
		}

		#endregion

		#region RenderKernelContextService Overrides

		/// <summary>
		/// Get the GraphicsGarbageService for the specified render context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify the object name space of the service.
		/// </param>
		/// <returns>
		/// It returns a GraphicsGarbageService which handle objects generated in the same namespace of <paramref name="ctx"/>.
		/// </returns>
		public static GraphicsGarbageService GetService(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return ((GraphicsGarbageService)GetService(ctx.ObjectNameSpace, ThisServiceName));
		}

		/// <summary>
		/// Get the GraphicsGarbageService for the specified object name space.
		/// </summary>
		/// <param name="rObjectNameSpace">
		/// A <see cref="Guid"/> that specify the object name space of the service.
		/// </param>
		/// <returns>
		/// It returns a GraphicsGarbageService which handle objects generated in the name space <paramref name="rObjectNameSpace"/>.
		/// </returns>
		internal static GraphicsGarbageService GetService(Guid rObjectNameSpace)
		{
			return ((GraphicsGarbageService)GetService(rObjectNameSpace, ThisServiceName));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx">
		/// </param>
		public override void ContextExecute(GraphicsContext ctx)
		{
			DeleteGarbage(ctx);
		}

		/// <summary>
		/// Garbage list.
		/// </summary>
		private static List<IGraphicsResource> mGarbageItems = new List<IGraphicsResource>();

		/// <summary>
		/// Garbage list lock.
		/// </summary>
		private static object mGarbageItemsLock = new object();

		#endregion
	}
}