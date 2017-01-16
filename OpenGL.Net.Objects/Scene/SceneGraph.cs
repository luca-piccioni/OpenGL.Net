
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
	public sealed class SceneGraph : SceneObject
	{
		#region Constructors

		/// <summary>
		/// Force static initialization for this class.
		/// </summary>
		internal static void Touch()
		{
			// Static initialization
		}

		#endregion

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
		/// Get or set the scene graph flags.
		/// </summary>
		public SceneGraphFlags SceneFlags
		{
			get { return (_Flags); }
			set { _Flags = value; }
		}

		/// <summary>
		/// Scene graph flags.
		/// </summary>
		private SceneGraphFlags _Flags = SceneGraphFlags.None; // SceneGraphFlags.CullingViewFrustum | SceneGraphFlags.StateSorting; // | SceneGraphFlags.BoundingVolumes;

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
				TraverseDirect(ctx, ctxScene, _TraverseDrawContext, objectBatchContext);
				
				// Sort geometries
				List<SceneObjectBatch> sceneObjects = objectBatchContext.Objects;
				if (((SceneFlags & SceneGraphFlags.StateSorting) != 0) && (_SorterRoot != null))
					sceneObjects = _SorterRoot.Sort(objectBatchContext.Objects);

				// Draw all batches
				foreach (SceneObjectBatch objectBatch in sceneObjects)
					objectBatch.Draw(ctx);
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
		private static bool GraphDrawDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			ObjectBatchContext objectBatchContext = (ObjectBatchContext)data;

			if (sceneObject.ObjectType == SceneObjectGeometry.ClassObjectType) {
				SceneObjectGeometry sceneGeometry = (SceneObjectGeometry)sceneObject;
				GraphicsStateSet sceneGeometryState = ctxScene.GraphicsStateStack.Current;
				TransformStateBase sceneGeometryModel = (TransformStateBase)sceneGeometryState[TransformStateBase.StateSetIndex];

				if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.CullingViewFrustum) != 0)
					// View-frustum culling
					objectBatchContext.Objects.AddRange(sceneGeometry.GetGeometries(sceneGeometryState, objectBatchContext.ViewFrustumPlanes, sceneGeometryModel.ModelView));
				else
					// All geometries
					objectBatchContext.Objects.AddRange(sceneGeometry.GetGeometries(sceneGeometryState));

				// Bounding volumes
				if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {
					
				}
			} else if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType) {
				SceneObjectLightZone sceneObjectLightZone = (SceneObjectLightZone)sceneObject;

				// TODO: Push instead of Clear to support stacked zones
				objectBatchContext.Lights.Clear();
				objectBatchContext.LightZone = sceneObjectLightZone;
			} else if (sceneObject.ObjectType == SceneObjectLight.ClassObjectType) {
				objectBatchContext.Lights.Add((SceneObjectLight)sceneObject);
			}

			return (true);
		}

		private static bool GraphDrawPostDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			ObjectBatchContext objectBatchContext = (ObjectBatchContext)data;

			if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType) {
				SceneObjectLightZone sceneObjectLightZone = (SceneObjectLightZone)sceneObject;

				sceneObjectLightZone.ResetLights(ctxScene, objectBatchContext.Lights);
				// TODO: Pop instead of Clear to support stacked zones
				objectBatchContext.Lights.Clear();
			}

			// Restore previous state
			ctxScene.GraphicsStateStack.Pop();

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
			public readonly List<SceneObjectBatch> Objects = new List<SceneObjectBatch>();

			/// <summary>
			/// The current light zone, if any.
			/// </summary>
			public SceneObjectLightZone LightZone;

			/// <summary>
			/// Lights to be associated to the current light zone.
			/// </summary>
			public readonly List<SceneObjectLight> Lights = new List<SceneObjectLight>();
		}

		/// <summary>
		/// The <see cref="TraverseContext"/> used for processing the scene graph
		/// </summary>
		private static TraverseContext _TraverseDrawContext = new TraverseContext(GraphDrawDelegate, DrawPreDelegate, GraphDrawPostDelegate);

		#endregion

		#region State Sorting

		private static SceneGraphSorter CreateDefaultSorter()
		{
			// Object are discrimated by translucent ones and opaque ones
			SceneObjectSorterBlend sorterBlend = new SceneObjectSorterBlend();
			// Blend disabled -> Split by Program
			// Note: 
			SceneObjectSorterProgram sorterProgram = new SceneObjectSorterProgram();
			// Blend enabled -> Sort by distance
			// Note: distance sorting is required for having a correct visual of transparencies

			// Link
			sorterBlend.SorterA = sorterProgram;

			return (sorterBlend);
		}

		private SceneGraphSorter _SorterRoot = CreateDefaultSorter();

		#endregion

		#region Bounding Volumes Resources

		private VertexArrayObject CreateBBoxVertexArray(IBoundingVolume bbox)
		{
			if (bbox.GetType() == typeof(BoundingBox))
				return (_BoundingBoxArray);
			else
				throw new NotImplementedException();
		}

		private VertexArrayObject CreateBBoxVertexArray()
		{
			VertexArrayObject bboxArray = new VertexArrayObject();
			ArrayBufferObject<Vertex3f> bboxVPositionArray = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);
			bboxVPositionArray.Create(new Vertex3f[] {
				// Lower
				new Vertex3f(-0.5f, -0.5f, -0.5f), new Vertex3f(+0.5f, -0.5f, -0.5f),
				new Vertex3f(+0.5f, -0.5f, -0.5f), new Vertex3f(+0.5f, -0.5f, +0.5f),
				new Vertex3f(+0.5f, -0.5f, +0.5f), new Vertex3f(-0.5f, -0.5f, +0.5f),
				new Vertex3f(-0.5f, -0.5f, +0.5f), new Vertex3f(-0.5f, -0.5f, -0.5f),
				// Upper
				new Vertex3f(-0.5f, +0.5f, -0.5f), new Vertex3f(+0.5f, +0.5f, -0.5f),
				new Vertex3f(+0.5f, +0.5f, -0.5f), new Vertex3f(+0.5f, +0.5f, +0.5f),
				new Vertex3f(+0.5f, +0.5f, +0.5f), new Vertex3f(-0.5f, +0.5f, +0.5f),
				new Vertex3f(-0.5f, +0.5f, +0.5f), new Vertex3f(-0.5f, +0.5f, -0.5f),
				// Verticals
				new Vertex3f(-0.5f, -0.5f, -0.5f), new Vertex3f(-0.5f, +0.5f, -0.5f),
				new Vertex3f(+0.5f, -0.5f, -0.5f), new Vertex3f(+0.5f, +0.5f, -0.5f),
				new Vertex3f(+0.5f, -0.5f, +0.5f), new Vertex3f(+0.5f, +0.5f, +0.5f),
				new Vertex3f(-0.5f, -0.5f, +0.5f), new Vertex3f(-0.5f, +0.5f, +0.5f),
			});
			bboxArray.SetArray(bboxVPositionArray, VertexArraySemantic.Position);

			bboxArray.SetElementArray(PrimitiveType.Lines);

			return (bboxArray);
		}

		private GraphicsStateSet CreateBBoxState(IBoundingVolume bbox)
		{
			GraphicsStateSet bboxState;

			if (bbox.GetType() == typeof(BoundingBox))
				bboxState = CreateBBoxState((BoundingBox)bbox);
			else
				throw new NotImplementedException();

			// No blending
			bboxState.DefineState(new BlendState());

			return (bboxState);
		}

		private GraphicsStateSet CreateBBoxState(BoundingBox bbox)
		{
			GraphicsStateSet bboxState = new GraphicsStateSet();
			TransformState bboxTransformState = new TransformState();

			bboxTransformState.LocalModel.Translate(bbox.Position);
			bboxTransformState.LocalModel.Scale(bbox.Size);
			bboxState.DefineState(bboxTransformState);

			return (bboxState);
		}

		/// <summary>
		/// Vertex arrays for drawing bounding boxes.
		/// </summary>
		private VertexArrayObject _BoundingBoxArray = new VertexArrayObject();

		/// <summary>
		/// Shader program used for drawing bounding volumes.
		/// </summary>
		private ShaderProgram _BoundingVolumeProgram;

		#endregion

		#region SceneGraphObject Overrides

		/// <summary>
		/// Get the object type. Used for avoiding reflection.
		/// </summary>
		public override uint ObjectType { get { return (_ObjectType); } }

		/// <summary>
		/// Get the object type of this SceneObject class.
		/// </summary>
		public static uint ClassObjectType { get { return (_ObjectType); } }

		/// <summary>
		/// The object identifier for this class of SceneObject.
		/// </summary>
		private static readonly uint _ObjectType = NextObjectType();

		/// <summary>
		/// Add a <see cref="SceneObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneGraphObject">
		/// The <see cref="SceneObject"/> to be included in the children list of this instance.
		/// </param>
		public override void Link(SceneObject sceneGraphObject)
		{
			// Base implementation
			base.Link(sceneGraphObject);
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
			// Bounding volume program
			LinkResource(_BoundingVolumeProgram = ctx.CreateProgram("OpenGL.Standard"));
			// Bounding volume arrays
			LinkResource(_BoundingBoxArray = CreateBBoxVertexArray());

			// Base implementation
			base.CreateObject(ctx);

			// Collect geometries to be batched
			using (SceneGraphContext ctxScene = new SceneGraphContext(this)) {
				TraverseDirect(ctx, ctxScene, _TraverseCreateContext, null);
			}
		}

		/// <summary>
		/// Traverse delegate for creating resources.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for creating resources.
		/// </param>
		/// <param name="ctxScene"></param>
		/// <param name="sceneObject"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		private static bool CreateDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			SceneObjectGeometry sceneGeometry = sceneObject as SceneObjectGeometry;
			if (sceneGeometry != null) {
				GraphicsStateSet sceneGeometryState = ctxScene.GraphicsStateStack.Current;

				sceneGeometryState.Create(ctx, sceneGeometry.Program);
			}

			return (true);
		}

		private static bool CreatePreDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(sceneObject.ObjectState);

			return (true);
		}

		/// <summary>
		/// The <see cref="TraverseContext"/> used for processing the scene graph
		/// </summary>
		private static TraverseContext _TraverseCreateContext = new TraverseContext(CreateDelegate, CreatePreDelegate, DrawPostDelegate);

		#endregion
	}
}
