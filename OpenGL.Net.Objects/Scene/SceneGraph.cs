
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
using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Directed graphs of <see cref="SceneObject"/>.
	/// </summary>
	public class SceneGraph : SceneObject
	{
		#region Scene References

		/// <summary>
		/// 
		/// </summary>
		public SceneObjectCamera CurrentView { get { return (_CurrentView); } }

		/// <summary>
		/// 
		/// </summary>
		private SceneObjectCamera _CurrentView;

		#endregion

		#region Draw

		/// <summary>
		/// Draw this SceneGraph.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		public void Draw(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			using (SceneGraphContext ctxScene = new SceneGraphContext(this, _CurrentView)) {
				ObjectBatchContext objectBatchContext = new ObjectBatchContext();

				// Override model-view-projection matrices if a camera is defined
				if (_CurrentView != null) {
					LocalProjection = _CurrentView.ProjectionMatrix;
					LocalModel = _CurrentView.LocalModel.GetInverseMatrix();
				}

				// View-frustum culling
				objectBatchContext.ViewFrustumPlanes = Plane.GetFrustumPlanes(LocalProjection);
				// Collect geometries to be batched
				Stopwatch sw = Stopwatch.StartNew();
				TraverseDirect(ctx, ctxScene, _TraverseDrawContext, objectBatchContext);
				sw.Stop();
				// Sort geometries
				// ...

				Console.WriteLine("Objects selection: {0} objects in {1} ms", objectBatchContext.Objects.Count, sw.ElapsedMilliseconds);

				// Draw all batches
				sw = Stopwatch.StartNew();
				foreach (ObjectBatch objectBatch in objectBatchContext.Objects)
					objectBatch.Draw(ctx);
				sw.Stop();
				Console.WriteLine("Objects drawing: {0} objects in {1} ms", objectBatchContext.Objects.Count, sw.ElapsedMilliseconds);

				Resource.CheckResourceLeaks();
			}
		}

		/// <summary>
		/// Traverse delegate for collecting geometries to be drawn.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene"></param>
		/// <param name="sceneObject"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		private static bool DrawDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			ObjectBatchContext objectBatchContext = (ObjectBatchContext)data;

			SceneObjectGeometry sceneGeometry = sceneObject as SceneObjectGeometry;
			if (sceneGeometry != null) {
				GraphicsStateSet sceneGeometryState = ctxScene.GraphicsStateStack.Current;
				TransformStateBase sceneGeometryModel = (TransformStateBase)sceneGeometryState[TransformStateBase.StateId];

				// Test geometry culling
				if (sceneGeometry.BoundingVolume != null) {
					if (sceneGeometry.BoundingVolume.IsClipped(objectBatchContext.ViewFrustumPlanes, sceneGeometryModel.ModelView))
						return (true);		// Continue traversing
				}
				// Object is drawn
				objectBatchContext.Objects.Add(new ObjectBatch(sceneGeometry.Program, sceneGeometry.VertexArray, sceneGeometryState.Copy()));
			}

			return (true);
		}

		/// <summary>
		/// 
		/// </summary>
		class ObjectBatchContext
		{
			/// <summary>
			/// Pre-compute view-frustum planes to cull scene objects.
			/// </summary>
			public IEnumerable<Plane> ViewFrustumPlanes;

			/// <summary>
			/// Objects to be drawn.
			/// </summary>
			public readonly List<ObjectBatch> Objects = new List<ObjectBatch>();
		}

		/// <summary>
		/// Basic drawing unit.
		/// </summary>
		class ObjectBatch
		{
			#region Constructors

			/// <summary>
			/// Construct an ObjectBatch.
			/// </summary>
			/// <param name="program"></param>
			/// <param name="vertexArray"></param>
			/// <param name="state"></param>
			public ObjectBatch(ShaderProgram program, VertexArrayObject vertexArray, State.GraphicsStateSet state)
			{
				if (vertexArray == null)
					throw new ArgumentNullException("vertexArray");
				if (state == null)
					throw new ArgumentNullException("state");

				Program = program;      // It may be null to support fixed pipeline
				VertexArray = vertexArray;
				State = state;
			}

			#endregion

			#region Batch Drawing

			/// <summary>
			/// Optional shader program used for drawing.
			/// </summary>
			public readonly ShaderProgram Program;

			/// <summary>
			/// Vertex arrays to be rasterized.
			/// </summary>
			public readonly VertexArrayObject VertexArray;

			/// <summary>
			/// Current state to be applied to <see cref="Program"/> and the current server state.
			/// </summary>
			public readonly State.GraphicsStateSet State;

			/// <summary>
			/// Draw this batch.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public void Draw(GraphicsContext ctx)
			{
				State.Apply(ctx, Program);
				VertexArray.Draw(ctx, Program);
			}

			#endregion
		}

		/// <summary>
		/// The <see cref="TraverseContext"/> used for processing the scene graph
		/// </summary>
		private static TraverseContext _TraverseDrawContext = new TraverseContext(DrawDelegate, DrawPreDelegate, DrawPostDelegate);

		#endregion

		#region SceneGraphObject Overrides

		/// <summary>
		/// Add a <see cref="SceneObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneGraphObject">
		/// The <see cref="SceneObject"/> to be included in the children list of this instance.
		/// </param>
		public override void AddChild(SceneObject sceneGraphObject)
		{
			// Base implementation
			base.AddChild(sceneGraphObject);
			// Set default view
			if ((_CurrentView == null) && (sceneGraphObject is SceneObjectCamera))
				_CurrentView = (SceneObjectCamera)sceneGraphObject;
		}

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected internal override void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			CheckCurrentContext(ctx);

			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(ObjectState);
			try {
				// Draw all children
				foreach (SceneObject sceneGraphObject in _Children)
					sceneGraphObject.Draw(ctx, ctxScene);
			} finally {
				ctxScene.GraphicsStateStack.Pop();
			}
		}

		#endregion
	}
}
