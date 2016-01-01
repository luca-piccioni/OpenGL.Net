
// Copyright (C) 2012-2015 Luca Piccioni
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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace OpenGL.State
{
	/// <summary>
	/// Class describing a partial uniform state of a <see cref="ShaderProgram"/>
	/// </summary>
	public class ShaderUniformState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderUniformState.
		/// </summary>
		public ShaderUniformState()
		{
			
		}

		#endregion

		#region Uniform Block Support

		/// <summary>
		/// Get the shader uniform block semantic (used if the renderer support OpenGL uniform blocks).
		/// </summary>
		public virtual string BlockSemantic { get { return (null); } }

		#endregion

		#region Shader Uniform State Application

		/// <summary>
		/// Apply this state to a shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to share common state between shaders.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> that specify this uniform state.
		/// </param>
		/// <param name="uniformScope">
		/// A <see cref="System.String"/> that specify the scope the uniform variable.
		/// </param>
		private void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram, string uniformScope)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");

			
		}

		#endregion

		#region GraphicsState Overrides
		
		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			
		}

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (GetType().FullName); } }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always false.
		/// </remarks>
		public override bool IsContextBound { get { return (false); } }

		/// <summary>
		/// Apply this depth test render state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");

			// Apply uniforms found using reflection
			ApplyState(ctx, shaderProgram, String.Empty);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");

			ShaderUniformState otherState = state as ShaderUniformState;

			if (otherState == null)
				throw new ArgumentException("not a ShaderUniformState", "state");
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="GraphicsState"/> to compare to this GraphicsState.
		/// </param>
		/// <returns>
		/// It returns true if the current object is equal to <paramref name="other"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method test only whether <paramref name="other"/> type equals to this type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="other"/> is null.
		/// </exception>
		public override bool Equals(IGraphicsState other)
		{
			if (base.Equals(other) == false)
				return (false);
			Debug.Assert(other is ShaderUniformState);

			ShaderUniformState otherState = (ShaderUniformState) other;
			GraphicsContext ctx = GraphicsContext.GetCurrentContext();

			if (ctx == null)
				throw new InvalidOperationException("no current context");

			return (false);
		}

		#endregion
	}
}
