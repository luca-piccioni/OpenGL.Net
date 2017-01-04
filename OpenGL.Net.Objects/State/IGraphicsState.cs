
// Copyright (C) 2012-2016 Luca Piccioni
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

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Interface implemented by those object able to determine the graphics state.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A render state is the union of the OpenGL context state (blend, depth, etc...) and a shader uniform state, both used
	/// for rendering.
	/// </para>
	/// </remarks>
	public interface IGraphicsState : IResource, IEquatable<IGraphicsState>
	{
		#region State Properties

		/// <summary>
		/// The identifier of this IGraphicsState implementation.
		/// </summary>
		string StateIdentifier { get; }

		/// <summary>
		/// Unique index assigned to this IGraphicsState.
		/// </summary>
		int StateIndex { get; }

		/// <summary>
		/// Flag indicating whether the state is applied to a <see cref="GraphicsContext"/>.
		/// </summary>
		bool IsContextBound { get; }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		bool IsShaderProgramBound { get; }

		#endregion

		#region State Application

		/// <summary>
		/// Create or update resources defined by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		void CreateState(GraphicsContext ctx);

		/// <summary>
		/// Apply the render state defined by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used in conjuction with <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> holding the uniform state.
		/// </param>
		void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram);

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a call to this routine, this IGraphicsState store the union of the previous information
		/// and of the information of <paramref name="state"/>.
		/// </para>
		/// <para>
		/// The semantic of the merge result is dependent on the actual implementation of this IGraphicsState. Normally
		/// the merge method will copy <paramref name="state"/> into this IGraphicsState, but other state could do
		/// different operations.
		/// </para>
		/// </remarks>
		void Merge(IGraphicsState state);

		#endregion

		#region Uniform Block

		/// <summary>
		/// The name of the uniform buffer object used for holding uniform state information.
		/// </summary>
		int UniformBlockName { get; }

		#endregion

		#region State Copy

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		IGraphicsState Copy();

		#endregion
	}
}
