
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

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Scene object representing a geometry.
	/// </summary>
	public class SceneObjectGeometry : SceneObject
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		public SceneObjectGeometry()
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectGeometry(string id) : base(id)
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		/// <param name="vertexArray">
		/// A <see cref="Objects.VertexArrays"/> that specifies the geometry primitive arrays.
		/// </param>
		/// <param name="program">
		/// A <see cref="ShaderProgram"/> that specifies the program used for shading <paramref name="vertexArray"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="vertexArray"/> is null.
		/// </exception>
		public SceneObjectGeometry(string id, VertexArrays vertexArray, ShaderProgram program) : base(id)
		{
			if (vertexArray == null)
				throw new ArgumentNullException("vertexArray");

			_VertexArray = vertexArray;
			_Program = program;
		}

		/// <summary>
		/// Force static initialization for this class.
		/// </summary>
		internal static void Touch()
		{
			// Static initialization
		}

		#endregion

		#region Geometry Common Resources

		/// <summary>
		/// Get or set the geometry primitive arrays, shared to all geometry instances, if any.
		/// </summary>
		public VertexArrays VertexArray
		{
			get { return (_VertexArray); }
			set
			{
				SwapGpuResources(value, ref _VertexArray);

				// Compute bounding box, if possible
				if (_VertexArray != null)
					_BoundingVolume = ComputeBoundingVolume(value);
			}
		}

		/// <summary>
		/// Primitive arrays.
		/// </summary>
		private VertexArrays _VertexArray;

		/// <summary>
		/// Shader tag used for creating the actual program at run-time. The program is shared , shared to all
		/// geometry instances, if any
		/// </summary>
		public ShadersLibrary.ProgramTag ProgramTag
		{
			get; set;
		}

		/// <summary>
		/// Get or set the shader used for drawing the geometry. It is automatically created if this property
		/// is null and <see cref="ProgramTag"/> is not null. The program is shared , shared to all
		/// geometry instances, if any
		/// </summary>
		public ShaderProgram Program
		{
			get { return (_Program); }
			set { SwapGpuResources(value, ref _Program); }
		}

		/// <summary>
		/// Shader used for drawing the geometry.
		/// </summary>
		private ShaderProgram _Program;

		/// <summary>
		/// Geometry object flags.
		/// </summary>
		public SceneObjectGeometryFlags Flags = SceneObjectGeometryFlags.ShadowCaster | SceneObjectGeometryFlags.ShadowReceiver;

		#endregion

		#region Geometry Instances

		/// <summary>
		/// Geometry instance.
		/// </summary>
		internal class Geometry : SceneObjectBatch, IDisposable
		{
			#region Constructors

			public Geometry(VertexArrays vertexArray) :
				base(vertexArray)
			{
				vertexArray.IncRef();
			}

			public Geometry(State.GraphicsStateSet state) :
				base(state)
			{
				
			}

			public Geometry(ShaderProgram program) :
				base(program)
			{
				program.IncRef();
			}

			/// <summary>
			/// Construct an Geometry.
			/// </summary>
			/// <param name="vertexArray">
			/// 
			/// </param>
			/// <param name="state"></param>
			/// <param name="program"></param>
			public Geometry(VertexArrays vertexArray, State.GraphicsStateSet state, ShaderProgram program) :
				base(vertexArray, state, program)
			{
				vertexArray.IncRef();
				if (program != null)
					program.IncRef();
			}

			#endregion

			#region Instance-only Resources

			/// <summary>
			/// Shader tag used for creating the actual program at run-time.
			/// </summary>
			public ShadersLibrary.ProgramTag ProgramTag
			{
				get; set;
			}

			/// <summary>
			/// Allocate resources requires for rendering this geometry.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public void Create(GraphicsContext ctx)
			{
				// Create geometry state, if necessary
				if (VertexArray != null && VertexArray.Exists(ctx) == false)
					VertexArray.Create(ctx);
				// Define program, if necessary
				if (Program == null && ProgramTag != null)
					Program = ctx.CreateProgram(ProgramTag);
				// Create program, if necessary
				if (Program != null && Program.Exists(ctx) == false)
					Program.Create(ctx);

				// Create program-dependent state
				if (State != null)
					State.Create(ctx, Program);
			}

			#endregion

			#region View Frustum Culling

			/// <summary>
			/// Bounding volume for <see cref="VertexArray"/>, if any.
			/// </summary>
			public IBoundingVolume BoundingVolume;

			#endregion

			#region SceneObjectBatch Overrides

			/// <summary>
			/// Vertex arrays to be rasterized.
			/// </summary>
			public override VertexArrays VertexArray
			{
				get { return (base.VertexArray); }
				set
				{
					// Base implementation
					base.VertexArray = value;
					// Compute bounding box, if possible
					if (value != null)
						BoundingVolume = ComputeBoundingVolume(value);
				}
			}

			#endregion

			#region IDisposable Implementation

			public void Dispose()
			{
				if (VertexArray != null)
					VertexArray.DecRef();
				if (Program != null)
					Program.DecRef();
				State.Delete();
			}

			#endregion
		}

		public void AddGeometry(VertexArrays vertexArray)
		{
			_GeometryInstances.Add(new Geometry(vertexArray));
		}

		public void AddGeometry(VertexArrays vertexArray, State.GraphicsStateSet state)
		{
			_GeometryInstances.Add(new Geometry(vertexArray, state, null));
		}

		public void AddGeometry(State.GraphicsStateSet state)
		{
			_GeometryInstances.Add(new Geometry(state));
		}

		public void AddGeometry(ShaderProgram program)
		{
			_GeometryInstances.Add(new Geometry(program));
		}

		/// <summary>
		/// Get all geometries compositing this SceneObjectGeometry.
		/// </summary>
		/// <param name="currentState">
		/// A <see cref="State.GraphicsStateSet"/> that specifies the current graphics state to be merged with
		/// each returned geometry.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{SceneObjectBatch}"/>.
		/// </returns>
		private IEnumerable<SceneObjectBatch> GetGeometries(GraphicsStateSet currentState)
		{
			if (currentState == null)
				throw new ArgumentNullException("currentState");

			if (_GeometryInstances.Count > 0) {
				foreach (Geometry sceneObjectBatch in _GeometryInstances) {
					GraphicsStateSet geometryState;

					if (sceneObjectBatch.State != null) {
						geometryState = currentState.Push();
						geometryState.Merge(sceneObjectBatch.State);
					} else
						geometryState = currentState;

					yield return (new SceneObjectBatch(
						sceneObjectBatch.VertexArray ?? VertexArray,
						geometryState,
						sceneObjectBatch.Program ?? Program
					));
				}
			} else {
				if (VertexArray == null)
					yield break;

				yield return (new SceneObjectBatch(VertexArray, currentState, Program));
			}
		}

		/// <summary>
		/// Get all geometries compositing this SceneObjectGeometry, filtering them using view-frustum.
		/// </summary>
		/// <param name="currentState">
		/// A <see cref="State.GraphicsStateSet"/> that specifies the current graphics state to be merged with
		/// each returned geometry.
		/// </param>
		/// <param name="clippingPlanes">
		/// 
		/// </param>
		/// <param name="viewModel">
		/// 
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{SceneObjectBatch}"/>.
		/// </returns>
		private IEnumerable<SceneObjectBatch> GetGeometriesViewFrustum(SceneGraphContext ctxScene)
		{
			GraphicsStateSet currentState = ctxScene.GraphicsStateStack.Current.Push();
			TransformState sceneGeometryModel = (TransformState)currentState[TransformState.StateSetIndex];
			Matrix4x4f viewModel = sceneGeometryModel.ModelView;

			if (_GeometryInstances.Count > 0) {
				foreach (Geometry sceneObjectBatch in _GeometryInstances) {
					IBoundingVolume instanceVolume = sceneObjectBatch.BoundingVolume ?? _BoundingVolume;

					if (instanceVolume != null && instanceVolume.IsClipped(ctxScene.ViewFrustumPlanes, viewModel))
						continue;

					GraphicsStateSet geometryState;

					if (sceneObjectBatch.State != null) {
						geometryState = currentState.Push();
						geometryState.Merge(sceneObjectBatch.State);
					} else
						geometryState = currentState;

					yield return (new SceneObjectBatch(
						sceneObjectBatch.VertexArray ?? VertexArray,
						geometryState,
						sceneObjectBatch.Program ?? Program
					));
				}
			} else {
				if (_BoundingVolume != null && _BoundingVolume.IsClipped(ctxScene.ViewFrustumPlanes, viewModel))
					yield break;

				if (VertexArray == null)
					yield break;

				yield return (new SceneObjectBatch(VertexArray, currentState, Program));
			}
		}


		/// <summary>
		/// Geometry instances.
		/// </summary>
		private readonly List<Geometry> _GeometryInstances = new List<Geometry>();

		#endregion

		#region Bounding Volume

		internal IEnumerable<SceneObjectBatch> GetBoundingVolumes(SceneGraphContext ctxScene)
		{
			GraphicsStateSet currentState = ctxScene.GraphicsStateStack.Current.Push();
			TransformState sceneGeometryModel = (TransformState)currentState[TransformState.StateSetIndex];
			Matrix4x4f viewModel = sceneGeometryModel.ModelView;

			if (_GeometryInstances.Count > 0) {
				foreach (Geometry sceneObjectBatch in _GeometryInstances) {
					IBoundingVolume instanceVolume = sceneObjectBatch.BoundingVolume ?? _BoundingVolume;

					if (instanceVolume != null && instanceVolume.IsClipped(ctxScene.ViewFrustumPlanes, viewModel))
						continue;

					GraphicsStateSet volumeState = currentState.Push();

					SetBoundingVolumeState(instanceVolume, volumeState);

					yield return (new SceneObjectBatch(
						_BoundingVolumeArray,
						volumeState,
						_BoundingVolumeProgram
					));
				}
			} else {
				if (_BoundingVolume == null || _BoundingVolume.IsClipped(ctxScene.ViewFrustumPlanes, viewModel))
					yield break;

				GraphicsStateSet volumeState = currentState.Push();

				SetBoundingVolumeState(_BoundingVolume, volumeState);

				yield return (new SceneObjectBatch(_BoundingVolumeArray, volumeState, _BoundingVolumeProgram));
			}
		}

		private static void SetBoundingVolumeState(IBoundingVolume boundingVolume, GraphicsStateSet volumeState)
		{
			if (boundingVolume == null)
				throw new ArgumentNullException("boundingVolume");
			if (volumeState == null)
				throw new ArgumentNullException("volumeState");

			if (boundingVolume.GetType() == typeof(BoundingBox)) {
				SetBoundingVolumeState((BoundingBox)boundingVolume, volumeState);
			} else
				throw new NotImplementedException();
		}

		private static void SetBoundingVolumeState(BoundingBox boundingVolume, GraphicsStateSet volumeState)
		{
			// Set transform state
			TransformState transformState = (TransformState)volumeState[TransformState.StateSetIndex];
			if (transformState == null)
				return;

			Vertex3f min = boundingVolume.MinPosition, max = boundingVolume.MaxPosition;
			Vertex3f size = boundingVolume.Size;
			Vertex3f avg = (max + min) / 2.0f;

			// Scale model matrix in order to represent the bounding box with the correct size and barycenter
			transformState.ModelViewProjection =
				transformState.ModelViewProjection * 
				Matrix4x4f.Translated(avg.x, avg.y, avg.z) *
				Matrix4x4f.Scaled(size.x, size.y, size.z);
		}

		/// <summary>
		/// Automatically computes bounding box for the specified vertex arrays.
		/// </summary>
		/// <param name="vertexArrayObject">
		/// 
		/// </param>
		/// <returns>
		/// It returns the <see cref="IBoundingVolume"/> for <paramref name="vertexArrayObject"/>, if possible.
		/// </returns>
		private static IBoundingVolume ComputeBoundingVolume(VertexArrays vertexArrayObject)
		{
			if (vertexArrayObject == null)
				throw new ArgumentNullException("vertexArrayObject");

			VertexArrays.IVertexArray vertexArray = vertexArrayObject.GetVertexArray(VertexArraySemantic.Position);
			if (vertexArray == null)
				return (null);

			ArrayBufferBase positionArray = vertexArray.Array;
			Type positionArrayType = positionArray.GetType();

			if (positionArrayType == typeof(ArrayBuffer<Vertex4f>)) {
				ArrayBuffer<Vertex4f> positionArray4f = (ArrayBuffer<Vertex4f>)positionArray;
				Vertex4f min = Vertex4f.Maximum, max = Vertex4f.Minimum;
				positionArray4f.MinMax(out min, out max);

				return (new BoundingBox((Vertex3f)min, (Vertex3f)max));
			} else if (positionArrayType == typeof(ArrayBuffer<Vertex3f>)) {
				ArrayBuffer<Vertex3f> positionArray3f = (ArrayBuffer<Vertex3f>)positionArray;
				Vertex3f min = Vertex3f.Maximum, max = Vertex3f.Minimum;
				positionArray3f.MinMax(out min, out max);

				return (new BoundingBox(min, max));
			} else
				return (null);
		}

		/// <summary>
		/// Bounding volume for <see cref="VertexArray"/>, if any.
		/// </summary>
		private IBoundingVolume _BoundingVolume;

		/// <summary>
		/// Create vertex arrays representing the <see cref="IBoundingVolume"/>, using lines delimiting the box volume.
		/// </summary>
		/// <param name="bbox"></param>
		/// <returns></returns>
		private static VertexArrays CreateBoundingVolumeArrays(IBoundingVolume bbox)
		{
			if (bbox.GetType() == typeof(BoundingBox))
				return (CreateBoundingBoxArrays());
			else
				throw new NotImplementedException();
		}

		/// <summary>
		/// Create vertex arrays representing the bounding box, using lines delimiting the box volume.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="VertexArrays"/> representing a normalized bounding box volume.
		/// </returns>
		private static VertexArrays CreateBoundingBoxArrays()
		{
			VertexArrays bboxArray = new VertexArrays();
			ArrayBuffer<Vertex3f> bboxVPositionArray = new ArrayBuffer<Vertex3f>();
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

		/// <summary>
		/// Vertex arrays for drawing bounding boxes.
		/// </summary>
		private VertexArrays _BoundingVolumeArray;

		/// <summary>
		/// Shader program used for drawing bounding volumes.
		/// </summary>
		private ShaderProgram _BoundingVolumeProgram;

		#endregion

		#region SceneObjectGeometry Overrides

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
		/// Get geometries related to this object.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="ctxScene"></param>
		/// <returns></returns>
		internal override IEnumerable<SceneObjectBatch> GetGeometries(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			List<SceneObjectBatch> geometries = new List<SceneObjectBatch>();

			GraphicsStateSet sceneGeometryState = ctxScene.GraphicsStateStack.Current.Push();
			TransformState sceneGeometryModel = (TransformState)sceneGeometryState[TransformState.StateSetIndex];

			if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.CullingViewFrustum) != 0)
				// View-frustum culling
				geometries.AddRange(GetGeometriesViewFrustum(ctxScene));
			else
				// All geometries
				geometries.AddRange(GetGeometries(sceneGeometryState));

			// Bounding volumes
			if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.BoundingVolumes) != 0) {
				if ((ctxScene.Scene.SceneFlags & SceneGraphFlags.CullingViewFrustum) != 0)
					// View-frustum culling
					geometries.AddRange(GetBoundingVolumes(ctxScene));
			}

			return (geometries);
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
			// Bounding box - Shared program
			LinkResource(_BoundingVolumeProgram = ctx.CreateProgram("OpenGL.Standard"));

			// Bounding box - Shared arrays
			const string BoundBoxArraysId = "SceneObjectGeometry.BoundingVolumeArrays";

			VertexArrays boundingBoxArrays = (VertexArrays)ctx.GetSharedResource(BoundBoxArraysId);
			if (_BoundingVolume != null && boundingBoxArrays == null) {
				boundingBoxArrays = CreateBoundingVolumeArrays(_BoundingVolume);
				ctx.SetSharedResource(BoundBoxArraysId, boundingBoxArrays);
			}
			if (boundingBoxArrays != null)
				LinkResource(_BoundingVolumeArray = boundingBoxArrays);

			// Create geometry state, if necessary
			if (VertexArray != null && VertexArray.Exists(ctx) == false)
				VertexArray.Create(ctx);
			// Define program, if necessary
			if (Program == null && ProgramTag != null)
				Program = ctx.CreateProgram(ProgramTag);
			// Create program, if necessary
			if (Program != null && Program.Exists(ctx) == false)
				Program.Create(ctx);

			// Create instance-only resources
			foreach (Geometry geometry in _GeometryInstances)
				geometry.Create(ctx);

			// Create object state, but associating state to program
			ObjectState.Create(ctx, Program);
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
				foreach (Geometry geometry in _GeometryInstances)
					geometry.Dispose();
				VertexArray = null;
				Program = null;
			}
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
