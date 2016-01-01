
// Copyright (C) 2010-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Any resource that is involved in the rendering operations.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class in the main implementation of the <see cref="IGraphicsResource"/> interface. This is the suggested implementation; in the case it
	/// is not possible to inherit class (i.e. a class is already inheriting from another one), it is possible to implement directly the
	/// <see cref="IGraphicsResource"/>.
	/// </para>
	/// <para>
	/// Most of the IGraphicsResource interface is implemented. The GraphicsResource inheritor shall implement the following methods:
	/// - <see cref="CreateName"/>: this method is virtual and it always throw a <see cref="NotImplementedException"/>. It shall generate an
	///   object name of a specific object class (determined by inheritor). It is called in the <see cref="IGraphicsResource.Create"/> implementation.
	/// - <see cref="CreateObject"/>: this method is virtual, and it can be overriden to actually create an useful object. Base implementation
	///   is empty. It is called in the <see cref="IGraphicsResource.Create"/> implementation, after <see cref="CreateName"/>.
	/// - <see cref="Delete"/>: this method is abstract, and it shall delete the object name and resources of this GraphicsResource instance.
	///   The implementation is dependent on the specific object class (determined by inheritor).
	/// - <see cref="Exists"/>: this method is virtual, but throw always <see cref="NotImplementedException"/>. Inheritor shall override this
	///   method since the implementation is dependent on the specific object class (determined by inheritor).
	/// </para>
	/// <para>
	/// This class defines also an invalid object name <see cref="InvalidObjectName"/>. Despite the name, this field doesn't actually specifies
	/// an invalid object name for all object classes. OpenGL specification usually uses this value for indicating an invalid object name, but it
	/// is not always the case (i.e. for framebuffer objects, InvalidObjectName indicates the default framebuffer object).
	/// 
	/// However, this name shall never be generated from <see cref="Create"/>.
	/// </para>
	/// </remarks>
	public abstract class GraphicsResource : Resource, IGraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsResource.
		/// </summary>
		protected GraphicsResource()
			: this(String.Empty)
		{
			
		}

		/// <summary>
		/// Construct a GraphicsResource, specifying its identifier.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that identifies this GraphicsResource.
		/// </param>
		protected GraphicsResource(string identifier)
		{
			try {
				if (identifier == null)
					throw new ArgumentNullException("identifier");

				// Store identifier
				_Identifier = identifier;
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Resource Name Management

		/// <summary>
		/// Invalid object name.
		/// </summary>
		public const uint InvalidObjectName = 0;

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns a boolean value indicating whether this GraphicsResource implementation requires a name
		/// generation on creation. In the case this routine returns true, the routine <see cref="CreateName"/>
		/// will be called (and it must be overriden). In  the case this routine returns false, the routine
		/// <see cref="CreateName"/> won't be called (and indeed it is not necessary to override it) and a
		/// name is generated automatically in a context-independent manner.
		/// </para>
		/// <para>
		/// This implementation returns always true.
		/// </para>
		/// </returns>
		protected virtual bool RequiresName(GraphicsContext ctx)
		{
			return (true);
		}

		/// <summary>
		/// Create a GraphicsResource name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this GraphicsResource.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected virtual uint CreateName(GraphicsContext ctx)
		{
			throw new NotImplementedException(String.Format("class {0} not implementing CreateName", GetType().Name));
		}

		/// <summary>
		/// Delete a GraphicsResource name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected virtual void DeleteName(GraphicsContext ctx, uint name)
		{
			throw new NotImplementedException(String.Format("class {0} not implementing DeleteName", GetType().Name));
		}

		/// <summary>
		/// Utility routine for generating resource names by object class.
		/// </summary>
		/// <param name="objectClass">
		/// A <see cref="System.Guid"/> that specify the resource class.
		/// </param>
		/// <returns>
		/// It returns an unused name for the resource class <paramref name="objectClass"/>.
		/// </returns>
		/// <remarks>
		/// This routine must not be used for those resource named managed directly by the underlying
		/// OpenGL implementation.
		/// </remarks>
		internal static uint GetFakeObjectName(Guid objectClass)
		{
			uint fakeObjectName = InvalidObjectName;

			lock (sClientObjectNamesLock) {
				// Ensure managed object class
				if (sClientObjectNames.ContainsKey(objectClass) == false)
					sClientObjectNames[objectClass] = InvalidObjectName;
				// Create name automatically
				fakeObjectName = ++sClientObjectNames[objectClass];
			}

			return (fakeObjectName);
		}

		/// <summary>
		/// Common name database for objects not supported by OpenGL context.
		/// </summary>
		private static readonly Dictionary<Guid, uint> sClientObjectNames = new Dictionary<Guid, uint>();

		/// <summary>
		/// Lock for accessing <see cref="sClientObjectNames"/>.
		/// </summary>
		private static readonly object sClientObjectNamesLock = new object();

		#endregion

		#region Resource Management

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected virtual void CreateObject(GraphicsContext ctx) { }

		#endregion

		#region Resource Overrides

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Release resources allocated by this GraphicsResource
				if (ObjectName != InvalidObjectName) {
					GraphicsContext currentContext = GraphicsContext.GetCurrentContext();

					if ((currentContext == null) || (currentContext.ObjectNameSpace != _ObjectNameSpace)) {

						// No current context, or current context not managing this resource. Indeed, use
						// the GraphicsGarbageService to collect this resource

						if (_ObjectNameSpace != Guid.Empty) {
							GraphicsGarbageService garbageService = GraphicsGarbageService.GetService(_ObjectNameSpace);
							if (garbageService == null)
								throw new InvalidOperationException("no garbage service");
							garbageService.CollectGarbage(this);
						}
					} else {
						Dispose(currentContext);
					}
				}	
			}
		}

		#endregion

		#region IGraphicResource Implementation

		/// <summary>
		/// Resource identifier.
		/// </summary>
		/// <remarks>
		/// This string is used to identify this GraphicsResource among a collection. This identifier has to be
		/// unique in order to be collected by <see cref="RenderResourceDb"/>.
		/// </remarks>
		public string Identifier { get { return (_Identifier); } }

		/// <summary>
		/// Object class.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The object class identify the resource type. It cannot be <see cref="System.Guid.Empty"/>, but a meaninfull
		/// value. The allowed values are determine in the concrete implementation of the IGraphicsResource
		/// implementation.
		/// </para>
		/// </remarks>
		public abstract Guid ObjectClass { get; }

		/// <summary>
		/// Get the OpenGL object name generated for this GraphicsResource.
		/// </summary>
		public uint ObjectName
		{
			get { return (_Object); }
			protected set { _Object = value; }
		}

		/// <summary>
		/// OpenGL object namespace used for creating this GraphicsResource.
		/// </summary>
		/// <remarks>
		/// This property determine the correct association between this object and the render contextes used
		/// for drawing.
		/// </remarks>
		public Guid ObjectNamespace { get { return (_ObjectNameSpace); } }

		/// <summary>
		/// Determine whether this GraphicsResource really exists.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this object exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The current implementation actually does not test for object existence, but it tests for object name space
		/// correspondence, indicating a relationship between this GraphicsResource and the GraphicsContext used for creating
		/// this resource.
		/// </para>
		/// <para>
		/// Inheritors that managed an OpenGL resource shall override this method in order to check the effective existence of
		/// this GraphicsResource agains <paramref name="ctx"/>. In counterpart, if the resource is not managed directly by
		/// OpenGL, this routine could be leaved as is.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		public virtual bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Object not created
			if (ObjectName == InvalidObjectName)
				return (false);

			// Test only name space... specific test shall be executed by derived classes
			return (ctx.ObjectNameSpace == _ObjectNameSpace);
		}

		/// <summary>
		/// Create this GraphicsResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object. The object space of this <see cref="GraphicsContext"/> is used
		/// to generate <see cref="ObjectName"/>, and all contextes sharing lists with this parameter can handle this IGraphicsResource.
		/// The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// After this method, the resource must be in a "working" state, having all context-dependent information defined in the object
		/// namespace of the context <paramref name="ctx"/>.
		/// </para>
		/// <para>
		/// This method shall be the preferred way to allocate graphic resources. The allocation happens in the object namespace of
		/// <paramref name="ctx"/>, and an object cannot be allocated for more than one context at time. The normal way is to share
		/// the object namespace between different instances of <see cref="GraphicsContext"/> (de-facto they share the same object
		/// namespace.
		/// </para>
		/// <para>
		/// After a successfull call to Create, <see cref="Exists"/> shall return true.
		/// </para>
		/// <para>
		/// The actual implementation does:
		/// - Creates an object name, if required. It the current implementation requires an object name (<see cref="RequiresName"/>) it
		///   calls <see cref="CreateName"/> method; otherwise, it automatically generate resource name based on <see cref="ObjectClass"/>
		///   property (resources having the same class will never have name conflicts, even of different render contextes).
		/// - Create the object. The actual implementation of the object creation is defined by <see cref="CreateObject"/> method.
		/// </para>
		/// <para>
		/// In some GraphicsResource implementation is allowed to have null context resources (i.e. <see cref="GraphicsWindow"/>).
		/// </para>
		/// </remarks>
		/// <seealso cref="Delete"/>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the object has been already created.
		/// </exception>
		public virtual void Create(GraphicsContext ctx)
		{
			if (_Object != InvalidObjectName && _ObjectNameSpace != ctx.ObjectNameSpace)
				throw new InvalidOperationException("cross-context resource leak");

			// Create object name
			if (RequiresName(ctx) == false) {
				// The a fake name for this object
				if (_Object == InvalidObjectName)
					_Object = GetFakeObjectName(ObjectClass);
				if (_Object == InvalidObjectName)
					throw new InvalidOperationException("unable to create name for " + GetType().Name);
				// Store object name space to check on deletion
				if (ctx != null)
					_ObjectNameSpace = ctx.ObjectNameSpace;
			} else {
				if (ctx == null)
					throw new ArgumentNullException("ctx");
				if (ctx.IsCurrent == false)
					throw new ArgumentException("not current to this thread", "ctx");

				// Create a name for this resource
				if (ObjectName == InvalidObjectName)
					_Object = CreateName(ctx);
				if (_Object == InvalidObjectName)
					throw new InvalidOperationException("unable to create name for " + GetType().Name);
				// Store object name space to check on deletion
				_ObjectNameSpace = ctx.ObjectNameSpace;
			}
			// Create object
			CreateObject(ctx);
		}

		/// <summary>
		/// Delete this GraphicsResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object. The IGraphicsResource shall belong to the object space to this
		/// <see cref="GraphicsContext"/>. The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// After this method, the resource must have deallocated every graphic resource associated with it. Normally it should be possible
		/// to create again the resources by calling <see cref="Create"/>.
		/// </para>
		/// <para>
		/// This methods shall be the preferred way to deallocate graphic resources.
		/// </para>
		/// <para>
		/// After a successfull call to Create, <see cref="Exists"/> shall return true.
		/// </para>
		/// <para>
		/// The actual implementation deletes the name (<see cref="DeleteName"/>) only if the implementation requires a context related name
		/// (<see cref="RequiresName"/>). In the case derived classes requires more complex resource deletion pattern, this method could
		/// be overriden for that purpose, paying attention to call the base implementation.
		/// </para>
		/// </remarks>
		/// <seealso cref="Create"/>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if this object doesn't exists for <paramref name="ctx"/> (this is determined by calling <see cref="Exists"/>
		/// method), or this resource has a name and <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public virtual void Delete(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current to this thread", "ctx");
			if (Exists(ctx) == false)
				throw new ArgumentException("object namespace mismatch", "ctx");
			if (RefCount > 0)
				throw new InvalidOperationException("reference count greater than zero");

			// Delete object name
			if (RequiresName(ctx))
				DeleteName(ctx, _Object);
			// Reset object name space
			_ObjectNameSpace = Guid.Empty;
			// Ensure non valid object name
			_Object = InvalidObjectName;
		}

		/// <summary>
		/// Dispose graphics resources using the underlying <see cref="GraphicsContext"/>.
		/// </summary>
		/// <param name='ctx'>
		/// A <see cref="GraphicsContext"/> which have access to the <see cref="IRenderDisposable"/> graphics resources.
		/// </param>
		/// <remarks>
		/// <para>
		/// The instance shall be considered disposed as it were called <see cref="IDisposable.Dispose"/>, but in addition
		/// this method will release this instance resources.
		/// </para>
		/// <para>
		/// The <see cref="Dispose()"/> method should try to release the underlying resources by getting the optional graphics
		/// context current on the calling thread.
		/// </para>
		/// </remarks>
		public virtual void Dispose(GraphicsContext ctx)
		{
			// By default, delete object
			Delete(ctx);
		}

		/// <summary>
		/// GraphicsResource identifier.
		/// </summary>
		private readonly string _Identifier;

		/// <summary>
		/// GraphicsResource name.
		/// </summary>
		/// <remarks>
		/// A value of <see cref="InvalidObjectName"/> indicates that this GraphicsResource name is not yet created.
		/// </remarks>
		private uint _Object = InvalidObjectName;

		/// <summary>
		/// GraphicsResource name space.
		/// </summary>
		/// <remarks>
		/// A value of <see cref="System.Guid.Empty"/> indicates that this GraphicsResource doesn't belong to
		/// any context name space (i.e. its name is not yet created).
		/// </remarks>
		private Guid _ObjectNameSpace = Guid.Empty;

		#endregion
	}
}
