
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
	public class Batch
	{
		#region Batching Elements

		/// <summary>
		/// Specifies how to render an array of vertices, along with the required state.
		/// </summary>
		protected class GeometryContext
		{
			/// <summary>
			/// Construct a GeometryContext.
			/// </summary>
			/// <param name="primitive"></param>
			public GeometryContext(PrimitiveType primitive)
			{
				Primitive = primitive;
			}

			/// <summary>
			/// The type of the primitive.
			/// </summary>
			public readonly PrimitiveType Primitive;

			/// <summary>
			/// Array of vertices defining the geometry vertices positions.
			/// </summary>
			public readonly List<Vertex4f> Positions = new List<Vertex4f>();

			/// <summary>
			/// State required for rendering the geometry.
			/// </summary>
			public State.GraphicsState State;
		}

		/// <summary>
		/// Batch context.
		/// </summary>
		protected class Context
		{
			public Context(uint componentsCount)
			{
				if ((componentsCount < 2) || (componentsCount > 4))
					throw new ArgumentOutOfRangeException("componentsCount", "it must be in the range [2,4]");

				PositionComponentsCount = componentsCount;
			}

			/// <summary>
			/// Begin a new geometry.
			/// </summary>
			/// <param name="primitive"></param>
			public void Begin(PrimitiveType primitive)
			{
				GeometryContext currentContext = CurrentContext;

				if (currentContext == null || currentContext.Primitive != primitive) {
					// New geometry...
					currentContext = new GeometryContext(primitive);
					// ...become the current one
					Geometries.Add(currentContext);
				}
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
			/// Geometries to batch.
			/// </summary>
			public readonly List<GeometryContext> Geometries = new List<GeometryContext>();

			/// <summary>
			/// Number of components defining the vertices position.
			/// </summary>
			public readonly uint PositionComponentsCount;
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
			_Context = null;
		}

		/// <summary>
		/// Current definition context.
		/// </summary>
		private Context _Context;

		#endregion

		#region Line Definition

		public void DefineLine(float x1, float y1, float x2, float y2)
		{

		}

		#endregion
	}
}
