
// Copyright (C) 2009-2015 Luca Piccioni
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
	/// Batch primitives and relative states.
	/// </summary>
	public class VertexBatchObject : VertexArrayObject
	{
		#region Batching Vertex Elements

		/// <summary>
		/// A collection of indices reference input arrays.
		/// </summary>
		protected class BatchVertexElementArray : VertexElementArray
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices. If it null, no indices are
			/// used for drawing; instead, <paramref name="count"/> contiguos array elements are drawns, starting from
			/// <paramref name="offset"/>. If it is not null, <paramref name="count"/> indices are drawn starting from
			/// <paramref name="offset"/>.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public BatchVertexElementArray(PrimitiveType mode, ElementBufferObject indices, uint offset, uint count) :
				base(mode, indices, offset, count)
			{
				
			}

			/// <summary>
			/// Specify which elements shall be drawn by indexing them.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices. If it null, no indices are
			/// used for drawing; instead, all array elements are drawns, starting from the first one. If it is not null, all
			/// indices are drawn starting from the first one.
			/// </param>
			public BatchVertexElementArray(PrimitiveType mode, ElementBufferObject indices) :
				this(mode, indices, 0, 0)
			{

			}

			/// <summary>
			/// Specify which elements shall be drawn, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public BatchVertexElementArray(PrimitiveType mode, uint offset, uint count) :
				this(mode, null, offset, count)
			{

			}

			/// <summary>
			/// Specify how all elements shall be drawn.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			public BatchVertexElementArray(PrimitiveType mode) :
				this(mode, null, 0, 0)
			{

			}

			#endregion

			#region Batch Information

			/// <summary>
			/// The state used for rendering this elements.
			/// </summary>
			private State.GraphicsStateSet StateSet;

			#endregion

			#region VertexElementArray Overrides

			/// <summary>
			/// Draw the elements defined by this VertexElementArray.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="vertexArray">
			/// The <see cref="VertexArrayObject"/> which this VertexElementArray belongs to.
			/// </param>
			public override void Draw(GraphicsContext ctx, ShaderProgram shaderProgram, VertexArrayObject vertexArray)
			{
				// Before draw elements, set the graphics state
				StateSet.Apply(ctx, shaderProgram);
				// Base implementation
				base.Draw(ctx, shaderProgram, vertexArray);
			}

			#endregion
		}

		/// <summary>
		/// Specifies how to render an array of vertices, along with the required attributes and relative state.
		/// </summary>
		protected class GeometryContext
		{
			#region Constructors

			/// <summary>
			/// Construct a GeometryContext.
			/// </summary>
			/// <param name="primitive">
			/// A <see cref="PrimitiveType"/> that specify the type of the geometry to build.
			/// </param>
			public GeometryContext(PrimitiveType primitive)
			{
				Primitive = primitive;
			}

			#endregion

			#region Geometry Information

			/// <summary>
			/// The type of the primitive.
			/// </summary>
			public readonly PrimitiveType Primitive;

			#endregion

			#region Geometry Attributes

			/// <summary>
			/// Array of vertices defining the geometry vertices positions.
			/// </summary>
			/// <remarks>
			/// Positions are stored in a <see cref="List{Vertex4f>"/>; in this way we can store 2D and 3D
			/// vertices.
			/// </remarks>
			public readonly List<Vertex4f> Positions = new List<Vertex4f>();

			#endregion

			#region Geometry State

			/// <summary>
			/// State required for rendering the geometry.
			/// </summary>
			public State.GraphicsState State;

			#endregion
		}

		/// <summary>
		/// Batch context.
		/// </summary>
		protected class Context : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Construct a Context, specifing the vertex position components count.
			/// </summary>
			/// <param name="componentsCount">
			/// A <see cref="UInt32"/> that specify the vertex position components count.
			/// </param>
			/// <exception cref="ArgumentOutOfRangeException">
			/// Exception thrown if <paramref name="componentsCount"/> is less than 2 or greater than 4.
			/// </exception>
			public Context(uint componentsCount)
			{
				if ((componentsCount < 2) || (componentsCount > 4))
					throw new ArgumentOutOfRangeException("componentsCount", "it must be in the range [2,4]");

				PositionComponentsCount = componentsCount;
			}

			#endregion

			#region Context Geometries

			/// <summary>
			/// Begin a new geometry.
			/// </summary>
			/// <param name="primitive">
			/// A <see cref="PrimitiveType"/> that specify the type of the geometry to begin.
			/// </param>
			public void Begin(PrimitiveType primitive)
			{
				GeometryContext currentContext = CurrentContext;

				if (currentContext != null) {
					switch (primitive) {
						case PrimitiveType.Points:
						case PrimitiveType.Lines:
						case PrimitiveType.Triangles:
							// The above primitives can be batched right now: reuse the current GeometryContext
							if (currentContext.Primitive == primitive)
								return;
							break;
					}
				}

				// New geometry...
				currentContext = new GeometryContext(primitive);
				// ...become the current one
				Geometries.Add(currentContext);
			}

			/// <summary>
			/// Currently defined geometry.
			/// </summary>
			public GeometryContext CurrentContext
			{
				get
				{
					return (Geometries.Count > 0) ? Geometries[Geometries.Count - 1] : null;
				}
			}

			/// <summary>
			/// Number of components defining the vertices position.
			/// </summary>
			public readonly uint PositionComponentsCount;

			/// <summary>
			/// Geometries to batch.
			/// </summary>
			public readonly List<GeometryContext> Geometries = new List<GeometryContext>();

			#endregion

			#region Context State Stack

			/// <summary>
			/// The state stack used for keeping track of state changes applied to batch geometries.
			/// </summary>
			public readonly State.GraphicsStateSetStack StateStack = new State.GraphicsStateSetStack();

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				StateStack.Dispose();
			}

			#endregion
		}

		#endregion

		#region Batch Definition

		/// <summary>
		/// Begin the batch definition.
		/// </summary>
		public void BeginDefinition(uint componentsCount)
		{
			if (_Context != null)
				throw new InvalidOperationException("already in definition");
			_Context = new Context(componentsCount);
		}

		/// <summary>
		/// End the batch definition.
		/// </summary>
		public void EndDefinition()
		{
			if (_Context == null)
				throw new InvalidOperationException("not in definition");

			// Batch geometries defined between BeginDefinition and this method call


			// No more in definition state
			_Context.Dispose();
			_Context = null;
		}

		/// <summary>
		/// Current definition context.
		/// </summary>
		private Context _Context;

		#endregion

		#region Batch State

		public State.GraphicsStateSet CurrentState
		{
			get
			{
				return (_Context.StateStack.Current.Copy());
			}
		}

		#endregion

		#region Line Definition

		/// <summary>
		/// Draw a 2D line.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="Single"/> that specify the X coordinate of the line vertex.
		/// </param>
		/// <param name="y1">
		/// A <see cref="Single"/> that specify the Y coordinate of the line vertex.
		/// </param>
		/// <param name="x2">
		/// A <see cref="Single"/> that specify the X coordinate of the line vertex.
		/// </param>
		/// <param name="y2">
		/// A <see cref="Single"/> that specify the Y coordinate of the line vertex.
		/// </param>
		public void DrawLine(float x1, float y1, float x2, float y2)
		{
			_Context.Begin(PrimitiveType.Lines);
			_Context.CurrentContext.Positions.Add(new Vertex4f(x1, y1));
			_Context.CurrentContext.Positions.Add(new Vertex4f(x2, y2));
		}

		/// <summary>
		/// Draw a 2D line strip.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="Single"/> that specify the X coordinate of the line vertex.
		/// </param>
		/// <param name="y1">
		/// A <see cref="Single"/> that specify the Y coordinate of the line vertex.
		/// </param>
		/// <param name="coords">
		/// A <see cref="Single[]"/> that specify successive X/Y coordinate tuples defining
		/// the line strip.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="coords"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="coord"/> length is odd or zero.
		/// </exception>
		public void DrawLineStrip(float x1, float y1, params float[] coords)
		{
			if (coords == null)
				throw new ArgumentNullException("coords");
			if ((coords.Length == 0) || ((coords.Length % 2) != 0))
				throw new ArgumentException("invalid length", "coords");

			_Context.Begin(PrimitiveType.LineStrip);
			_Context.CurrentContext.Positions.Add(new Vertex4f(x1, y1));
			for (int i = 0; i < coords.Length; i += 2)
				_Context.CurrentContext.Positions.Add(new Vertex4f(coords[i], coords[i+1]));
		}

		/// <summary>
		/// Draw a 2D line loop.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="Single"/> that specify the X coordinate of the line vertex.
		/// </param>
		/// <param name="y1">
		/// A <see cref="Single"/> that specify the Y coordinate of the line vertex.
		/// </param>
		/// <param name="x2">
		/// A <see cref="Single"/> that specify the X coordinate of the line vertex.
		/// </param>
		/// <param name="y2">
		/// A <see cref="Single"/> that specify the Y coordinate of the line vertex.
		/// </param>
		/// <param name="coords">
		/// A <see cref="Single[]"/> that specify successive X/Y coordinate tuples defining
		/// the line loop.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="coords"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="coord"/> length is odd or zero.
		/// </exception>
		public void DrawLineLoop(float x1, float y1, float x2, float y2, params float[] coords)
		{
			if (coords == null)
				throw new ArgumentNullException("coords");
			if ((coords.Length == 0) || ((coords.Length % 2) != 0))
				throw new ArgumentException("invalid length", "coords");

			_Context.Begin(PrimitiveType.LineLoop);
			_Context.CurrentContext.Positions.Add(new Vertex4f(x1, y1));
			_Context.CurrentContext.Positions.Add(new Vertex4f(x2, y2));
			for (int i = 0; i < coords.Length; i += 2)
				_Context.CurrentContext.Positions.Add(new Vertex4f(coords[i], coords[i + 1]));
		}

		#endregion
	}
}
