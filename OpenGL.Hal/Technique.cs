
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

namespace OpenGL
{
	/// <summary>
	/// Drawing technique.
	/// </summary>
	public class Technique : UserGraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a Technique.
		/// </summary>
		/// <param name="vertexArray">
		/// The vertex array feeding data to the GPU pipeline.
		/// </param>
		/// <param name="shaderProgram">
		/// Shader program used for drawing. If it is null, it is assumed that the OpenGL
		/// fixed pipeline program is used.
		/// </param>
		/// <param name="stateSet">
		/// The graphics state set applied before the technique is executed.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="vertexArray"/> is null.
		/// </exception>
		public Technique(VertexArrayObject vertexArray, ShaderProgram shaderProgram, State.GraphicsStateSet stateSet)
		{
			if (vertexArray == null)
				throw new ArgumentNullException("vertexArray");

			VertexArray = vertexArray;
			Program = shaderProgram;
			StateSet = stateSet;

			LinkResource(vertexArray);
			if (shaderProgram != null)
				LinkResource(shaderProgram);
			if (stateSet != null)
				LinkResource(stateSet);
		}

		#endregion

		#region Technique Resources

		/// <summary>
		/// The vertex array feeding data to the GPU pipeline.
		/// </summary>
		public readonly VertexArrayObject VertexArray;

		/// <summary>
		/// Shader program used for drawing. If it is null, it is assumed that the OpenGL
		/// fixed pipeline program is used.
		/// </summary>
		public ShaderProgram Program;

		/// <summary>
		/// The graphics state set applied before the technique is executed.
		/// </summary>
		public State.GraphicsStateSet StateSet;

		#endregion

		#region Technique Methods

		/// <summary>
		/// Draw using this Technique.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing using this Technique.
		/// </param>
		public void Draw(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			if (StateSet != null)
				StateSet.Apply(ctx, Program);

			VertexArray.Draw(ctx, Program);
		}

		#endregion
	}
}
