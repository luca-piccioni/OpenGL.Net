
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
