
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
using static OpenGL.Objects.Scene.SceneObject;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Directed graphs of <see cref="SceneObject"/>.
	/// </summary>
	public sealed class SceneGraph : UserGraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneGraph.
		/// </summary>
		public SceneGraph()
		{

		}

		/// <summary>
		/// Construct a SceneGraph.
		/// </summary>
		/// <param name="otherScene">
		/// The <see cref="SceneGraph"/> to be copied.
		/// </param>
		public SceneGraph(SceneGraph otherScene)
		{
			if (otherScene == null)
				throw new ArgumentNullException("otherScene");

			_Flags = otherScene._Flags;
			CurrentView = otherScene.CurrentView;
			LocalProjection = otherScene.LocalProjection;
			LocalModel = otherScene.LocalModel;
			SceneRoot = otherScene.SceneRoot;
		}

		/// <summary>
		/// Force static initialization for this class.
		/// </summary>
		internal static void Touch()
		{
			// Static initialization
		}

		#endregion

		#region View

		/// <summary>
		/// The view projection.
		/// </summary>
		public IProjectionMatrix LocalProjection
		{
			get { return (_ViewProjection); }
			set { _ViewProjection = value; }
		}

		/// <summary>
		/// The view projection.
		/// </summary>
		private IProjectionMatrix _ViewProjection;

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public IModelMatrix LocalModel
		{
			get { return (_ViewModel); }
			set { _ViewModel = value; }
		}

		/// <summary>
		/// The view projection.
		/// </summary>
		private IModelMatrix _ViewModel;

		#endregion

		#region Root Object

		/// <summary>
		/// 
		/// </summary>
		public SceneObjectCamera CurrentView
		{
			get { return (_CurrentView); }
			set { _CurrentView = value; }
		}

		/// <summary>
		/// Set current graph view to <see cref="CurrentView"/>.
		/// </summary>
		public void UpdateViewMatrix()
		{
			if (_CurrentView != null) {
				LocalProjection = _CurrentView.ProjectionMatrix;
				LocalModel = _CurrentView.LocalModel.GetInverseMatrix();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private SceneObjectCamera _CurrentView;

		/// <summary>
		/// Get or set the <see cref="SceneObject"/> defining the scene.
		/// </summary>
		public SceneObject SceneRoot
		{
			get { return (_SceneRoot); }
			set { SwapGpuResources(value, ref _SceneRoot); }
		}

		/// <summary>
		/// The <see cref="SceneObject"/> defining the scene.
		/// </summary>
		private SceneObject _SceneRoot;

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
		private SceneGraphFlags _Flags =
			SceneGraphFlags.CullingViewFrustum |
			SceneGraphFlags.StateSorting |
			SceneGraphFlags.ShadowMaps | SceneGraphFlags.BoundingVolumes;

		/// <summary>
		/// Draw this SceneGraph.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		public void Draw(GraphicsContext ctx)
		{
			Draw(ctx, null);
		}

		/// <summary>
		/// Draw this SceneGraph.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="programOverride">
		/// A <see cref="ShaderProgram"/> that overrides the default one used for rendering the batch. It can be null.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram programOverride)
		{
			CheckCurrentContext(ctx);

			// View parameters
			SceneRoot.LocalProjection = LocalProjection;
			SceneRoot.LocalModel = LocalModel;

			using (SceneGraphContext ctxScene = new SceneGraphContext(this)) {
				ObjectBatchContext objectBatchContext = new ObjectBatchContext();

				#region Scene Graph Traversal

				// View parameters - Frustum culling
				objectBatchContext.ViewFrustumPlanes = Plane.GetFrustumPlanes(LocalProjection);
				// Collect geometries to be batched
				SceneRoot.TraverseDirect(ctx, ctxScene, _TraverseDrawContext, objectBatchContext);

				#endregion

				#region Shadow Mapping

				if ((SceneFlags & SceneGraphFlags.ShadowMaps) != 0) {

					KhronosApi.LogComment("*** Update Shadow Maps");

					foreach (SceneObjectLight sceneLight in objectBatchContext.ShadowLights) {
						using (SceneGraph shadowGraph = new SceneGraph(this)) {
							// Avoid stack overflow
							shadowGraph.SceneFlags &= ~SceneGraphFlags.BoundingVolumes;
							shadowGraph.SceneFlags &= ~SceneGraphFlags.ShadowMaps;
							shadowGraph.SceneFlags &= ~SceneGraphFlags.CullingViewFrustum;

							sceneLight.UpdateShadowMap(ctx, shadowGraph);
						}
					}
				}

				#endregion

				#region Draw

				// Sort geometries
				List<SceneObjectBatch> sceneObjects = objectBatchContext.Objects;
				if (((SceneFlags & SceneGraphFlags.StateSorting) != 0) && (_SorterRoot != null))
					sceneObjects = _SorterRoot.Sort(objectBatchContext.Objects);

				// Draw all batches
				KhronosApi.LogComment("*** Draw Graph");
				foreach (SceneObjectBatch objectBatch in sceneObjects)
					objectBatch.Draw(ctx, programOverride);

				#endregion
			}
		}

		private static bool GraphDrawPreDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			// Update object before applying state
			sceneObject.UpdateThis(ctx, ctxScene);
			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(sceneObject.ObjectState);

			return (true);
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

				// SceneObjectGeometry

				SceneObjectGeometry sceneGeometry = (SceneObjectGeometry)sceneObject;
				GraphicsStateSet sceneGeometryState = ctxScene.GraphicsStateStack.Current.Push();
				TransformStateBase sceneGeometryModel = (TransformStateBase)sceneGeometryState[TransformStateBase.StateSetIndex];

				IEnumerable<SceneObjectBatch> geometries;

				if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.CullingViewFrustum) != 0)
					// View-frustum culling
					geometries = sceneGeometry.GetGeometries(sceneGeometryState, objectBatchContext.ViewFrustumPlanes, sceneGeometryModel.ModelView);
				else
					// All geometries
					geometries = sceneGeometry.GetGeometries(sceneGeometryState);

				objectBatchContext.Objects.AddRange(geometries);

				// Bounding volumes
				if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {
					if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.CullingViewFrustum) != 0)
						// View-frustum culling
						geometries = sceneGeometry.GetBoundingVolumes(sceneGeometryState, objectBatchContext.ViewFrustumPlanes, sceneGeometryModel.ModelView);
					else
						geometries = null;
				} else
					geometries = null;

				if (geometries != null)
					objectBatchContext.Objects.AddRange(geometries);

			} else if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType && (ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {

				// SceneObjectLightZone

				SceneObjectLightZone sceneObjectLightZone = (SceneObjectLightZone)sceneObject;

				// TODO: Push instead of Clear to support stacked zones
				objectBatchContext.Lights.Clear();
				objectBatchContext.LightZone = sceneObjectLightZone;

			} else if (sceneObject.ObjectType == SceneObjectLight.ClassObjectType && (ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {

				// SceneObjectLight
				SceneObjectLight sceneObjectLight = (SceneObjectLight)sceneObject;

				// Temporary store light to update the light zone
				objectBatchContext.Lights.Add((SceneObjectLight)sceneObject);
				// Collect lights requiring shadow map update
				if (sceneObjectLight.HasShadowMap && objectBatchContext.ShadowLights.Contains(sceneObjectLight) == false)
					objectBatchContext.ShadowLights.Add(sceneObjectLight);
			}

			return (true);
		}

		private static bool GraphDrawPostDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			ObjectBatchContext objectBatchContext = (ObjectBatchContext)data;

			if (sceneObject.ObjectType == SceneObjectLightZone.ClassObjectType && (ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {
				SceneObjectLightZone sceneObjectLightZone = (SceneObjectLightZone)sceneObject;

				sceneObjectLightZone.ResetLights(ctx, ctxScene, objectBatchContext.Lights);
				// TODO: Pop instead of Clear to support stacked zones
				objectBatchContext.Lights.Clear();
			}

			// Restore previous state
			ctxScene.GraphicsStateStack.Pop();

			return (true);
		}

		/// <summary>
		/// Context used for pass information during scene graph traversal.
		/// </summary>
		class ObjectBatchContext
		{
			#region Uniform Information

			/// <summary>
			/// Pre-compute view-frustum planes to cull scene objects.
			/// </summary>
			public IEnumerable<Plane> ViewFrustumPlanes;

			#endregion

			#region Collections

			/// <summary>
			/// Objects to be drawn.
			/// </summary>
			public readonly List<SceneObjectBatch> Objects = new List<SceneObjectBatch>();

			#endregion

			#region Lighting

			/// <summary>
			/// The current light zone, if any.
			/// </summary>
			public SceneObjectLightZone LightZone;

			/// <summary>
			/// Lights to be associated to the current light zone.
			/// </summary>
			public readonly List<SceneObjectLight> Lights = new List<SceneObjectLight>();

			/// <summary>
			/// Lights required to update the shadow map.
			/// </summary>
			public readonly List<SceneObjectLight> ShadowLights = new List<SceneObjectLight>();

			#endregion
		}

		/// <summary>
		/// The <see cref="TraverseContext"/> used for processing the scene graph
		/// </summary>
		private static TraverseContext _TraverseDrawContext = new TraverseContext(GraphDrawDelegate, GraphDrawPreDelegate, GraphDrawPostDelegate);

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
	}
}
