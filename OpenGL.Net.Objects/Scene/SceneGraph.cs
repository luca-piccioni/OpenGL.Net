
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
			: this(SceneGraphFlags.CullingViewFrustum | SceneGraphFlags.StateSorting | SceneGraphFlags.Lighting | SceneGraphFlags.ShadowMaps)
		{
			
		}

		/// <summary>
		/// Construct a SceneGraph.
		/// </summary>
		public SceneGraph(SceneGraphFlags flags)
		{
			_Flags = flags;

			if ((_Flags & SceneGraphFlags.Lighting) != 0)
				_LightManager = new SceneLightManager();
		}

		/// <summary>
		/// Construct a SceneGraph.
		/// </summary>
		/// <param name="otherScene">
		/// The <see cref="SceneGraph"/> to be copied.
		/// </param>
		public SceneGraph(SceneGraph otherScene, SceneGraphFlags flags)
			: this(flags)
		{
			if (otherScene == null)
				throw new ArgumentNullException("otherScene");

			CurrentView = otherScene.CurrentView;
			ProjectionMatrix = otherScene.ProjectionMatrix;
			ViewMatrix = otherScene.ViewMatrix;
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
		/// The projection matrix.
		/// </summary>
		public Matrix4x4f ProjectionMatrix { get; set; }

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public Matrix4x4f ViewMatrix { get; set; } = Matrix4x4f.Identity;

		/// <summary>
		/// 
		/// </summary>
		public SceneObjectCamera CurrentView
		{
			get { return (_CurrentView); }
			set
			{
				_CurrentView = value;
				UpdateViewMatrix();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private SceneObjectCamera _CurrentView;

		/// <summary>
		/// Set current graph view to <see cref="CurrentView"/>.
		/// </summary>
		public void UpdateViewMatrix()
		{
			if (_CurrentView != null) {
				ProjectionMatrix = _CurrentView.ProjectionMatrix;
				if (_CurrentView.LocalModelView.HasValue)
					ViewMatrix = _CurrentView.LocalModelView.Value.Inverse;
			}
		}

		#endregion

		#region Root Object

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
		}

		/// <summary>
		/// Scene graph flags.
		/// </summary>
		private readonly SceneGraphFlags _Flags;

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
			SceneRoot.LocalProjection = ProjectionMatrix;
			SceneRoot.LocalModelView = ViewMatrix;
			SceneRoot.LocalModelViewProjection = ProjectionMatrix * ViewMatrix;

			using (SceneGraphContext ctxScene = new SceneGraphContext(this)) {
				ObjectBatchContext objectBatchContext = new ObjectBatchContext();

				// Traverse the scene graph
				SceneRoot.TraverseDirect(ctx, ctxScene, _TraverseDrawContext, objectBatchContext);
				// Generate shadow maps
				if ((SceneFlags & SceneGraphFlags.Lighting) != 0 && (SceneFlags & SceneGraphFlags.ShadowMaps) != 0)
					_LightManager.GenerateShadowMaps(ctx, this);

				// Sort geometries
				List<SceneObjectBatch> sceneObjects = objectBatchContext.Objects;
				if (((SceneFlags & SceneGraphFlags.StateSorting) != 0) && (_SorterRoot != null))
					sceneObjects = _SorterRoot.Sort(objectBatchContext.Objects);

				// Draw all batches
				Khronos.KhronosApi.LogComment("*** Draw Graph");
				foreach (SceneObjectBatch objectBatch in sceneObjects)
					objectBatch.Draw(ctx, programOverride);

				// Debug: shadow maps
				if ((SceneFlags & SceneGraphFlags.Lighting) != 0 && (SceneFlags & SceneGraphFlags.ShadowMaps) != 0)
					DisplayShadowMaps(ctx);
			}
		}

		private static bool GraphDrawPreDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
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

			// Collect available geometries
			IEnumerable<SceneObjectBatch> geometries = sceneObject.GetGeometries(ctx, ctxScene);
			if (geometries != null)
				objectBatchContext.Objects.AddRange(geometries);

			// Perform lighting
			if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.Lighting) != 0)
				ctxScene.Scene._LightManager.ManageObject(ctx, ctxScene, sceneObject);

			return (true);
		}

		private static bool GraphDrawPostDelegate(GraphicsContext ctx, SceneGraphContext ctxScene, SceneObject sceneObject, object data)
		{
			ObjectBatchContext objectBatchContext = (ObjectBatchContext)data;

			// Restore previous state
			ctxScene.GraphicsStateStack.Pop();

			// Perform lighting
			if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.Lighting) != 0)
				ctxScene.Scene._LightManager.PostObject(ctx, ctxScene, sceneObject);

			return (true);
		}

		/// <summary>
		/// Context used for pass information during scene graph traversal.
		/// </summary>
		class ObjectBatchContext
		{
			#region Collections

			/// <summary>
			/// Objects to be drawn.
			/// </summary>
			public readonly List<SceneObjectBatch> Objects = new List<SceneObjectBatch>();

			#endregion
		}

		/// <summary>
		/// The <see cref="TraverseContext"/> used for processing the scene graph
		/// </summary>
		private static readonly TraverseContext _TraverseDrawContext = new TraverseContext(GraphDrawDelegate, GraphDrawPreDelegate, GraphDrawPostDelegate);

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

		#region Lighting

		[Conditional("DEBUG")]
		private void LinkShadowMapResources(GraphicsContext ctx)
		{
			LinkResource(_ShadowMapQuad = new VertexArrays());

			ArrayBuffer<Vertex2f> positionArray = new ArrayBuffer<Vertex2f>(BufferUsage.StaticDraw);
			positionArray.Create(new Vertex2f[] {
				new Vertex2f(0.0f, 0.0f), new Vertex2f(1.0f, 0.0f), new Vertex2f(1.0f, 1.0f),
				new Vertex2f(0.0f, 1.0f), new Vertex2f(0.0f, 0.0f), new Vertex2f(1.0f, 1.0f),
			});
			positionArray.Create(ctx);

			_ShadowMapQuad.SetArray(positionArray, VertexArraySemantic.Position);
			_ShadowMapQuad.SetArray(positionArray, VertexArraySemantic.TexCoord);
			_ShadowMapQuad.SetElementArray(PrimitiveType.Triangles);
			_ShadowMapQuad.Create(ctx);

			LinkResource(_ShadowMapDebugProgram = ctx.CreateProgram("OpenGL.Specialized+Depth"));
		}

		[Conditional("DEBUG")]
		private void DisplayShadowMaps(GraphicsContext ctx)
		{
			State.ViewportState viewportState = new State.ViewportState(ctx);
			Matrix4x4f model = Matrix4x4f.Identity;

			// No depth test
			State.DepthTestState.DefaultState.Apply(ctx, null);

			ctx.Bind(_ShadowMapDebugProgram);

			for (int i = 0; i < _LightManager.ShadowLights.Count; i++) {
				SceneObjectLight shadowLight = _LightManager.ShadowLights[i];
				SceneObjectLightSpot shadowSpotLight = shadowLight as SceneObjectLightSpot;
				if (shadowSpotLight == null)
					continue;

				Texture2d shadowTex = shadowSpotLight._ShadowMap;
				shadowTex.SamplerParams.CompareMode = false;

				Matrix4x4f quadModel = model;
				quadModel.Scale(shadowTex.Width / 4.0f, shadowTex.Height / 4.0f, 1.0f);

				_ShadowMapDebugProgram.SetUniform(ctx, "glo_ModelViewProjection", Matrix4x4f.Ortho2D(0.0f, viewportState.Width, 0.0f, viewportState.Height) * quadModel);
				_ShadowMapDebugProgram.SetUniform(ctx, "glo_NearFar", new Vertex2f(0.1f, 100.0f));
				_ShadowMapDebugProgram.SetUniform(ctx, "glo_Texture", shadowTex);
				
				_ShadowMapQuad.Draw(ctx, _ShadowMapDebugProgram);

				shadowTex.SamplerParams.CompareMode = true;

				// Stride right
				model.Translate(shadowTex.Width, 0.0f, 0.0f);
			}
		}

		/// <summary>
		/// Program used for drawing shadow maps.
		/// </summary>
		private ShaderProgram _ShadowMapDebugProgram;

		/// <summary>
		/// Quadrilateral for drawing shadow maps.
		/// </summary>
		private VertexArrays _ShadowMapQuad;

		/// <summary>
		/// The scene graph light manager.
		/// </summary>
		private readonly SceneLightManager _LightManager;

		#endregion

		#region Overrides

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Resources
			LinkShadowMapResources(ctx);
			// Base implementation
			base.CreateObject(ctx);
		}

		#endregion
	}
}
