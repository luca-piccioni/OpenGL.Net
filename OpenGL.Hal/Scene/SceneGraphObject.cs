
// Copyright (C) 2016 Luca Piccioni
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

using OpenGL.Collections;
using OpenGL.State;

namespace OpenGL.Scene
{
	/// <summary>
	/// Scene object.
	/// </summary>
	public class SceneGraphObject : GraphicsResource, IGraphNode
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneGraphObject() : this(String.Empty)
		{

		}

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneGraphObject(string id) : base(id)
		{
			// The graphics state TransformState is always defined
			_ObjectState.DefineState(new TransformState());
		}

		#endregion

		#region Graphics Hierarchy

		/// <summary>
		/// Add a <see cref="SceneGraphObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneGraphObject">
		/// The <see cref="SceneGraphObject"/> to be included in the children list of this instance.
		/// </param>
		public virtual void AddChild(SceneGraphObject sceneGraphObject)
		{
			if (sceneGraphObject == null)
				throw new ArgumentNullException("sceneGraphObject");
			if (sceneGraphObject._ParentObject != null)
				throw new ArgumentException("already in graph");

			// Set the parent to this instance
			sceneGraphObject._ParentObject = this;
			// Include object in children list
			_Children.Add(sceneGraphObject);
			LinkResource(sceneGraphObject);
		}

		/// <summary>
		/// The SceneGraphObject that links this instance to the scene graph. If it null, this
		/// instance is the root node.
		/// </summary>
		private SceneGraphObject _ParentObject;

		/// <summary>
		/// Children drawn after this SceneGraphObject.
		/// </summary>
		protected readonly List<SceneGraphObject> _Children = new List<SceneGraphObject>();

		#endregion

		#region Local Model

		/// <summary>
		/// The local projection: the projection matrix of the current verte arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public IMatrix4x4 LocalProjection
		{
			get { return (((TransformState)_ObjectState[TransformState.StateId]).LocalProjection); }
			set { ((TransformState)_ObjectState[TransformState.StateId]).LocalProjection = value; }
		}

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public IModelMatrix LocalModel
		{
			get { return (((TransformState)_ObjectState[TransformState.StateId]).LocalModel); }
			set { ((TransformState)_ObjectState[TransformState.StateId]).LocalModel.Set(value); }
		}

		#endregion

		#region Updating

		/// <summary>
		/// Update this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctxScene"/>.
		/// </exception>
		protected internal virtual void Update(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			CheckCurrentContext(ctx);

			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			// Update this object
			UpdateThis(ctx, ctxScene);
			// Update all children
			foreach (SceneGraphObject sceneGraphObject in _Children)
				sceneGraphObject.Update(ctx, ctxScene);
		}

		/// <summary>
		/// Update this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected virtual void UpdateThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			
		}

		#endregion

		#region Drawing

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctxScene"/>.
		/// </exception>
		protected internal virtual void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			CheckCurrentContext(ctx);

			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(_ObjectState);

			try {
				// Draw this object
				DrawThis(ctx, ctxScene);
				// Draw all children
				foreach (SceneGraphObject sceneGraphObject in _Children)
					sceneGraphObject.Draw(ctx, ctxScene);
			} finally {
				ctxScene.GraphicsStateStack.Pop();
			}
		}

		/// <summary>
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected virtual void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			
		}

		/// <summary>
		/// The state relative to this SceneGraphObject.
		/// </summary>
		protected readonly GraphicsStateSet _ObjectState = new GraphicsStateSet();

		#endregion

		#region Resource Management

		/// <summary>
		/// Link a resource associated with this SceneGraphObject.
		/// </summary>
		/// <param name="graphicsResource">
		/// A <see cref="IGraphicsResource"/> that will be created and disposed along with this SceneGraphObject instance.
		/// </param>
		/// <remarks>
		/// The <paramref name="graphicsResource"/> can be shared across multiple SceneGraphObject instances.
		/// </remarks>
		protected void LinkResource(IGraphicsResource graphicsResource)
		{
			if (graphicsResource == null)
				throw new ArgumentNullException("graphicsResource");

			// Formally a resource can be linked multiple times, but probably it is caused by a copy & paste error
			Debug.Assert(!_Resources.Contains(graphicsResource));

			// By default, threat resources as shared ones
			graphicsResource.IncRef();
			// Let create/dispose it
			_Resources.Add(graphicsResource);
		}

		/// <summary>
		/// List of resources used by this SceneGraphObject.
		/// </summary>
		private readonly List<IGraphicsResource> _Resources = new List<IGraphicsResource>();

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// SceneGraphObject class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("15B3AE47-5703-4349-A02D-35C90AEF9F14");

		/// <summary>
		/// SceneGraphObject class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// This implementation returns always false.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx) { return (false); }

		/// <summary>
		/// Determine whether this GeometryClipmapObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this GeometryClipmapObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this GeometryClipmapObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (true);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <remarks>
		/// All resources linked with <see cref="LinkResource(IGraphicsResource)"/> will be automatically created.
		/// </remarks>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Base implementation
			base.CreateObject(ctx);

			// Allocate all resources
			foreach (IGraphicsResource graphicsResource in _Resources)
				graphicsResource.Create(ctx);
			// Propagate creation to hierarchy
			foreach (SceneGraphObject sceneGraphObject in _Children)
				sceneGraphObject.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			// Dispose all resource
			if (disposing) {
				foreach (IGraphicsResource graphicsResource in _Resources)
					graphicsResource.DecRef();
				_Resources.Clear();

				// Propagate disposition to hierarchy
				foreach (SceneGraphObject sceneGraphObject in _Children)
					sceneGraphObject.Dispose();
			}
		}

		#endregion

		#region IGraphNode Overrides

		/// <summary>
		/// The graph nodes linked to this node.
		/// </summary>
		IEnumerable<IGraphNode> IGraphNode.SubNodes { get { return (_Children); } }

		#endregion
	}
}
