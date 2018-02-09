
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
using System.Collections.Generic;
using System.Diagnostics;

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Scene object.
	/// </summary>
	public abstract class SceneObject : UserGraphicsResource, IMedia<SceneObjectInfo>
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static SceneObject()
		{
			// Static initialization
			SceneGraph.Touch();
			SceneObjectCamera.Touch();
			SceneObjectGeometry.Touch();
			SceneObjectLight.Touch();
			SceneObjectLightZone.Touch();
		}

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObject() : this(String.Empty)
		{

		}

		/// <summary>
		/// Construct a SceneGraphObject.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObject(string id) : base(id)
		{
			// The graphics state TransformState is always defined
			ObjectState.DefineState(new TransformState());
		}

		#endregion

		#region Object Type

		/// <summary>
		/// Get the object type. Used for avoiding reflection.
		/// </summary>
		public abstract uint ObjectType { get; }

		/// <summary>
		/// The the count of the known object types.
		/// </summary>
		public static uint ObjectTypesCount { get { return ((uint)_ObjectType); } }

		/// <summary>
		/// Get the next unused object type.
		/// </summary>
		/// <returns></returns>
		protected static uint NextObjectType()
		{
			return ((uint)System.Threading.Interlocked.Increment(ref _ObjectType));
		}

		/// <summary>
		/// Tracking object identifier.
		/// </summary>
		private static int _ObjectType = 0;

		#endregion

		#region Scene Hierarchy

		/// <summary>
		/// Link a <see cref="SceneObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneObject">
		/// The <see cref="SceneObject"/> to be included in the children list of this instance.
		/// </param>
		public virtual void Link(SceneObject sceneObject)
		{
			if (sceneObject == null)
				throw new ArgumentNullException("sceneObject");
			if (sceneObject._ParentObject != null)
				throw new ArgumentException("already in graph");

			// Set the parent to this instance
			sceneObject._ParentObject = this;
			// Include object in children list
			_Children.Add(sceneObject);
			// Automatic disposition
			LinkResource(sceneObject);
		}

		/// <summary>
		/// Unlink this SceneObject from the graph.
		/// </summary>
		public void Unlink()
		{
			if (_ParentObject == null)
				throw new ArgumentException("not in graph");

			// Remove from parent list
			bool res = _ParentObject._Children.Remove(this);
			Debug.Assert(res);
			// Undo automatic disposition
			_ParentObject.UnlinkResource(this);
			// Reset parent reference
			_ParentObject = null;
		}

		/// <summary>
		/// Remove all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to remove.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that indicates whether at least an object was removed from the graph.
		/// </returns>
		public bool Unlink(Predicate<SceneObject> match)
		{
			return (Unlink(match, true));
		}

		/// <summary>
		/// Remove all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to remove.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that indicates whether at least an object was removed from the graph.
		/// </returns>
		public bool Unlink(Predicate<SceneObject> match, bool recurse)
		{
			if (match == null)
				throw new ArgumentNullException("match");

			bool res = false;

			List<SceneObject> macthingObjects = _Children.FindAll(match);
			foreach (SceneObject matchingObject in macthingObjects)
				matchingObject.Unlink();

			res |= macthingObjects.Count > 0;

			if (recurse) {
				foreach (SceneObject sceneObject in _Children)
					res |= sceneObject.Unlink(match, true);
			}

			return (res);
		}

		/// <summary>
		/// The SceneGraphObject that links this instance to the scene graph. If it null, this
		/// instance is the root node.
		/// </summary>
		private SceneObject _ParentObject;

		/// <summary>
		/// Children drawn after this SceneGraphObject.
		/// </summary>
		protected readonly List<SceneObject> _Children = new List<SceneObject>();

		#endregion

		#region Traversing

		/// <summary>
		/// Delegate for visiting <see cref="SceneObject"/> instanced during scene graph traversal.
		/// </summary>
		/// <param name="sceneObject">
		/// The <see cref="SceneObject"/> currently visited by the delegate function.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> indicating whether the traversal function shall continue.
		/// </returns>
		protected internal delegate bool TraverseBaseDelegate(SceneObject sceneObject, object data);

		/// <summary>
		/// Delegate for visiting <see cref="SceneObject"/> instanced during scene graph traversal.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing/updating objects, if any.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing/updating objects, if any.
		/// </param>
		/// <param name="sceneObject">
		/// The <see cref="SceneObject"/> currently visited by the delegate function.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> indicating whether the traversal function shall continue.
		/// </returns>
		protected internal delegate bool TraverseDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data);

		/// <summary>
		/// Context holding information for executing scene graph traversal.
		/// </summary>
		protected internal class TraverseContext
		{
			#region Constructors

			/// <summary>
			/// Construct a TraverseContext.
			/// </summary>
			/// <param name="visit">
			/// The <see cref="TraverseDelegate"/> used for visiting the underlying scene graph nodes.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="visit"/> is null.
			/// </exception>
			public TraverseContext(TraverseDelegate visit) :
				this(visit, null, null)
			{

			}

			/// <summary>
			/// Construct a TraverseContext.
			/// </summary>
			/// <param name="visit">
			/// The <see cref="TraverseDelegate"/> used for visiting the underlying scene graph nodes.
			/// </param>
			/// <param name="pre">
			/// The <see cref="TraverseDelegate"/> executed before <paramref name="visit"/>. It can be null.
			/// </param>
			/// <param name="post">
			/// The <see cref="TraverseDelegate"/> executed after <paramref name="visit"/>. It can be null.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="visit"/> is null.
			/// </exception>
			public TraverseContext(TraverseDelegate visit, TraverseDelegate pre, TraverseDelegate post)
			{
				if (visit == null)
					throw new ArgumentNullException("visit");

				Visit = visit;
				PreContract = pre;
				PostContract = post;
			}

			#endregion

			#region Callbacks

			/// <summary>
			/// Visit the underlying node.
			/// </summary>
			public readonly TraverseDelegate Visit;

			/// <summary>
			/// Function executed before <see cref="Visit"/>. It can be null.
			/// </summary>
			public readonly TraverseDelegate PreContract;

			/// <summary>
			/// Function executed after <see cref="Visit"/>. It can be null.
			/// </summary>
			public readonly TraverseDelegate PostContract;

			#endregion
		}

		/// <summary>
		/// Traverse the scene graph from the current SceneObject to the leaf SceneObject.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing/updating objects, if any.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing/updating objects, if any.
		/// </param>
		/// <param name="traverseFunc">
		/// The <see cref="TraverseDelegate"/> executed for each SceneObject instance visited during traversal.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="traverseFunc"/> is null.
		/// </exception>
		protected internal void TraverseDirect(GraphicsContext ctx, SceneGraphContext ctxScene, TraverseContext traverseFunc, object data)
		{
			CheckCurrentContext(ctx);

			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");
			if (traverseFunc == null)
				throw new ArgumentNullException("traverseFunc");

			traverseFunc.PreContract?.Invoke(ctx, ctxScene, this, data);
			try {
				// Visit this object
				if (traverseFunc.Visit(ctx, ctxScene, this, data) == false)
					return;
				// Visit children
				foreach (SceneObject sceneObject in _Children)
					sceneObject.TraverseDirect(ctx, ctxScene, traverseFunc, data);
			} finally {
				traverseFunc.PostContract?.Invoke(ctx, ctxScene, this, data);
			}
		}

		protected internal void TraverseUpwards(TraverseBaseDelegate traverseFunc)
		{
			if (traverseFunc == null)
				throw new ArgumentNullException("traverseFunc");

			// Visit this object till to root
			for (SceneObject graphCursor = this; graphCursor != null; graphCursor = graphCursor._ParentObject) {
				if (traverseFunc(graphCursor, null) == false)
					return;
			}
		}

		#endregion

		#region Find Children

		/// <summary>
		/// Find all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public List<SceneObject> FindChildren(Predicate<SceneObject> match)
		{
			return (FindChildren(match, true));
		}

		/// <summary>
		/// Find all <see cref="SceneObject"/> instances matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public virtual List<SceneObject> FindChildren(Predicate<SceneObject> match, bool recurse)
		{
			if (match == null)
				throw new ArgumentNullException("match");

			List<SceneObject> foundChildren = new List<SceneObject>();

			foundChildren.AddRange(_Children.FindAll(match));

			if (recurse) {
				foreach (SceneObject sceneObject in _Children)
					foundChildren.AddRange(sceneObject.FindChildren(match, true));
			}

			return (foundChildren);
		}

		/// <summary>
		/// Find the first <see cref="SceneObject"/> instance matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public SceneObject FindChild(Predicate<SceneObject> match)
		{
			return (FindChild(match, true));
		}

		/// <summary>
		/// Find the first <see cref="SceneObject"/> instance matching a predicate.
		/// </summary>
		/// <param name="match">
		/// The <see cref="Predicate{SceneObject}"/> delegate that defines the conditions of the objects to find.
		/// </param>
		/// <param name="recurse">
		/// A <see cref="Boolean"/> indicating whether the operation shall be recursed on the graph hierarchy.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{SceneObject}"/> holding all <see cref="SceneObject"/> instances
		/// found by this method.
		/// </returns>
		public SceneObject FindChild(Predicate<SceneObject> match, bool recurse)
		{
			List<SceneObject> foundChildren = FindChildren(match, recurse);

			if (foundChildren.Count > 0)
				return (foundChildren[0]);
			else
				return (null);
		}

		#endregion

		public uint CountChildren()
		{
			uint count = (uint)_Children.Count;

			foreach (SceneObject child in _Children)
				count += child.CountChildren();

			return (count);
		}

		#region Local Model

		/// <summary>
		/// The local projection: the projection matrix of the current vertex arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public Matrix4x4f? LocalProjection
		{
			get { return ((TransformState)ObjectState[TransformState.StateSetIndex]).Projection; }
			set { ((TransformState)ObjectState[TransformState.StateSetIndex]).Projection = value; }
		}

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public Matrix4x4f? LocalModelView
		{
			get { return _LocalModelView; }
			set
			{
				_LocalModelView = value;
				((TransformState)ObjectState[TransformState.StateSetIndex]).ModelView = value ?? Matrix4x4f.Identity;
			}
		}

		/// <summary>
		/// Backend value for LocalModelView.
		/// </summary>
		private Matrix4x4f? _LocalModelView;

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public Matrix4x4f? LocalModelViewProjection
		{
			get { return (((TransformState)ObjectState[TransformState.StateSetIndex]).ModelViewProjection); }
			set { ((TransformState)ObjectState[TransformState.StateSetIndex]).ModelViewProjection = value; }
		}

		/// <summary>
		/// The world model: the transform of the current vertex arrays object space, considering inherited
		/// transform states from parent objects.
		/// </summary>
		public Matrix4x4f WorldModel
		{
			get
			{
				Stack<Matrix4x4f> modelStack = new Stack<Matrix4x4f>();
				SceneObject cursor = this;
				Matrix4x4f worldModel = new Matrix4x4f();

				while (cursor != null) {
					// Store local model
					if (cursor.LocalModelView.HasValue)
						modelStack.Push(cursor.LocalModelView.Value);
					// Go to parent, if any
					cursor = cursor._ParentObject;
				}

				while (modelStack.Count > 0)
					worldModel = worldModel * modelStack.Pop();

				return (worldModel);
			}
		}

		#endregion

		#region Object Flags

		/// <summary>
		/// Get or set the scene graph flags (not recursive).
		/// </summary>
		public SceneObjectFlags ObjectFlags
		{
			get { return (_Flags); }
			set { _Flags = value; }
		}

		public void SetObjectFlags(SceneObjectFlags flags, bool recursive)
		{
			_Flags = flags;
			if (recursive)
				_FlagsRecursive = flags;
		}

		public void AddObjectFlags(SceneObjectFlags flags, bool recursive)
		{
			_Flags |= flags;
			if (recursive)
				_FlagsRecursive |= flags;
		}

		public void RemoveObjectFlags(SceneObjectFlags flags)
		{
			_Flags &= ~flags;
			_FlagsRecursive &= ~flags;
		}

		/// <summary>
		/// Scene object flags.
		/// </summary>
		private SceneObjectFlags _Flags = SceneObjectFlags.None;

		/// <summary>
		/// Flags indicating which values are recursive.
		/// </summary>
		private SceneObjectFlags _FlagsRecursive = SceneObjectFlags.None;

		#endregion

		#region Drawing

		/// <summary>
		/// Get geometries related to this object.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="ctxScene"></param>
		/// <returns></returns>
		internal virtual IEnumerable<SceneObjectBatch> GetGeometries(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			return (null);
		}

		/// <summary>
		/// The state relative to this SceneGraphObject.
		/// </summary>
		public readonly GraphicsStateSet ObjectState = new GraphicsStateSet();

		#endregion

		#region Culling

		/// <summary>
		/// Set bounding volume used for testing visibility.
		/// </summary>
		public IBoundingVolume BoundingVolume
		{
			get { return (_BoundingVolume); }
			set
			{
				_BoundingVolume = value;
				_BoundingVolumeDirty = true;
			}
		}

		/// <summary>
		/// Bounding volume used for testing visibility.
		/// </summary>
		private IBoundingVolume _BoundingVolume;

		/// <summary>
		/// 
		/// </summary>
		internal bool _BoundingVolumeDirty;

		#endregion

		#region GraphicsResource Overrides

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
			// Create object state
			ObjectState.Create(ctx, null);
			// Base implementation
			base.CreateObject(ctx);
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
			if (disposing) {
				// Dispose resources associated to the graphics state
				ObjectState.Delete();
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion

		#region IMedia<SceneObjectInfo> Implementation

		/// <summary>
		/// Gets the media information of this instance.
		/// </summary>
		public SceneObjectInfo MediaInformation
		{
			get
			{
				// Other information may be modified by external code

				return (_SceneObjectInfo);
			}
		}

		/// <summary>
		/// Media information.
		/// </summary>
		private readonly SceneObjectInfo _SceneObjectInfo = new SceneObjectInfo();

		#endregion
	}
}
