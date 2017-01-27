
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
		/// A <see cref="VertexArrayObject"/> that specifies the geometry primitive arrays.
		/// </param>
		/// <param name="program">
		/// A <see cref="ShaderProgram"/> that specifies the program used for shading <paramref name="vertexArray"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="vertexArray"/> is null.
		/// </exception>
		public SceneObjectGeometry(string id, VertexArrayObject vertexArray, ShaderProgram program) : base(id)
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

		#region Geometry Definition

		/// <summary>
		/// Get or set the geometry primitive arrays, shared to all geometry instances, if any.
		/// </summary>
		public VertexArrayObject VertexArray
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
		private VertexArrayObject _VertexArray;

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

		#endregion

		#region Geometry Instances

		/// <summary>
		/// Geometry instance.
		/// </summary>
		internal class Geometry : SceneObjectBatch
		{
			#region Constructors

			public Geometry(VertexArrayObject vertexArray) :
				base(vertexArray)
			{
				
			}

			public Geometry(State.GraphicsStateSet state) :
				base(state)
			{
				
			}

			public Geometry(ShaderProgram program) :
				base(program)
			{
				
			}

			/// <summary>
			/// Construct an Geometry.
			/// </summary>
			/// <param name="vertexArray">
			/// 
			/// </param>
			/// <param name="state"></param>
			/// <param name="program"></param>
			public Geometry(VertexArrayObject vertexArray, State.GraphicsStateSet state, ShaderProgram program) :
				base(vertexArray, state, program)
			{
				
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
			public override VertexArrayObject VertexArray
			{
				get { return (base.VertexArray); }
				protected set
				{
					// Base implementation
					base.VertexArray = value;
					// Compute bounding box, if possible
					if (value != null)
						BoundingVolume = SceneObjectGeometry.ComputeBoundingVolume(value);
				}
			}

			#endregion
		}

		internal IEnumerable<SceneObjectBatch> GetGeometries(State.GraphicsStateSet currentState)
		{
			if (_GeometryInstances.Count > 0) {
				foreach (Geometry sceneObjectBatch in _GeometryInstances) {
					State.GraphicsStateSet geometryState;

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
				yield return (new SceneObjectBatch(VertexArray, currentState, Program));
			}
		}

		public void AddGeometry(VertexArrayObject vertexArray)
		{
			_GeometryInstances.Add(new Geometry(vertexArray));
		}

		public void AddGeometry(VertexArrayObject vertexArray, State.GraphicsStateSet state)
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
		/// Geometry instances.
		/// </summary>
		private readonly List<Geometry> _GeometryInstances = new List<Geometry>();

		#endregion

		#region View Frustum Culling

		internal IEnumerable<SceneObjectBatch> GetGeometries(State.GraphicsStateSet currentState, IEnumerable<Plane> clippingPlanes, IMatrix4x4 viewModel)
		{
			if (_GeometryInstances.Count > 0) {
				foreach (Geometry sceneObjectBatch in _GeometryInstances) {
					IBoundingVolume instanceVolume = sceneObjectBatch.BoundingVolume ?? _BoundingVolume;

					if (instanceVolume != null && instanceVolume.IsClipped(clippingPlanes, viewModel))
						continue;

					State.GraphicsStateSet geometryState;

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
				if (_BoundingVolume != null && _BoundingVolume.IsClipped(clippingPlanes, viewModel))
					yield break;

				yield return (new SceneObjectBatch(VertexArray, currentState, Program));
			}
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
		private static IBoundingVolume ComputeBoundingVolume(VertexArrayObject vertexArrayObject)
		{
			if (vertexArrayObject == null)
				throw new ArgumentNullException("vertexArrayObject");

			VertexArrayObject.IVertexArray vertexArray = vertexArrayObject.GetVertexArray(VertexArraySemantic.Position);
			if (vertexArray == null)
				return (null);

			ArrayBufferObjectBase positionArray = vertexArray.Array;
			Type positionArrayType = positionArray.GetType();

			if (positionArrayType == typeof(ArrayBufferObject<Vertex4f>)) {
				ArrayBufferObject<Vertex4f> positionArray4f = (ArrayBufferObject<Vertex4f>)positionArray;
				Vertex4f min = Vertex4f.Maximum, max = Vertex4f.Minimum;
				positionArray4f.MinMax(out min, out max);

				return (new BoundingBox((Vertex3f)min, (Vertex3f)max));
			} else if (positionArrayType == typeof(ArrayBufferObject<Vertex3f>)) {
				ArrayBufferObject<Vertex3f> positionArray3f = (ArrayBufferObject<Vertex3f>)positionArray;
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
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected override void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			// Apply current state
			ctxScene.GraphicsStateStack.Current.Apply(ctx, _Program);
			// Draw arrays
			_VertexArray.Draw(ctx, _Program);
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

			// In place base.CreateObject implementation

			// Create object state
			ObjectState.Create(ctx, Program);
			// Base implementation
			base.CreateObject(ctx);
			// Propagate creation to hierarchy
			foreach (SceneObject sceneGraphObject in _Children)
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
			if (disposing) {
				VertexArray = null;
				Program = null;
			}
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
