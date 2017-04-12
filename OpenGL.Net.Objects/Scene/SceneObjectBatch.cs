
// Copyright (C) 2016-2017 Luca Piccioni
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

		internal SceneObjectBatch(VertexArrays vertexArray)
		{
			if (vertexArray == null)
				throw new ArgumentNullException("vertexArray");
			VertexArray = vertexArray;
		}

		internal SceneObjectBatch(State.GraphicsStateSet state)
		{
			if (state == null)
				throw new ArgumentNullException("state");
			State = state;
		}

		internal SceneObjectBatch(ShaderProgram program)
		{
			if (program == null)
				throw new ArgumentNullException("program");
			Program = program;
		}

		/// <summary>
		/// Construct an SceneObjectBatch.
		/// </summary>
		/// <param name="vertexArray">
		/// 
		/// </param>
		/// <param name="state"></param>
		/// <param name="program"></param>
		public SceneObjectBatch(VertexArrays vertexArray, State.GraphicsStateSet state, ShaderProgram program)
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
		public ShaderProgram Program
		{
			get { return (_Program); }
			set { _Program = value; }
		}

		/// <summary>
		/// Optional shader program used for drawing.
		/// </summary>
		private ShaderProgram _Program;

		/// <summary>
		/// Vertex arrays to be rasterized.
		/// </summary>
		public virtual VertexArrays VertexArray
		{
			get { return (_VertexArray); }
			set { _VertexArray = value;; }
		}

		/// <summary>
		/// Vertex arrays to be rasterized.
		/// </summary>
		private VertexArrays _VertexArray;

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
			Draw(ctx, null);
		}

		/// <summary>
		/// Draw this batch.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="programOverride">
		/// A <see cref="ShaderProgram"/> that overrides the default one used for rendering the batch. It can be null.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram programOverride)
		{
			State.Apply(ctx, programOverride ?? Program);
			VertexArray.Draw(ctx, programOverride ?? Program);
		}

		#endregion
	}
}
