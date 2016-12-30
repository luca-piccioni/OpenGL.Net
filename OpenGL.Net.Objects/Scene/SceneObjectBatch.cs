
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
using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	class SceneObjectBatch
	{
		#region Constructors

		/// <summary>
		/// Construct an ObjectBatch.
		/// </summary>
		/// <param name="program"></param>
		/// <param name="vertexArray"></param>
		/// <param name="state"></param>
		public SceneObjectBatch(ShaderProgram program, VertexArrayObject vertexArray, State.GraphicsStateSet state)
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
		public readonly GraphicsStateSet State;

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
}
