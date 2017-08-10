
// Copyright (C) 2012-2017 Luca Piccioni
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
	public interface IGraphicsState : IEquatable<IGraphicsState>
	{
		#region Identification

		/// <summary>
		/// The identifier of this IGraphicsState implementation.
		/// </summary>
		string StateIdentifier { get; }

		/// <summary>
		/// Unique index assigned to this IGraphicsState.
		/// </summary>
		int StateIndex { get; }

		#endregion

		#region State Information

		/// <summary>
		/// Flag indicating whether the state is applied to a <see cref="GraphicsContext"/>.
		/// </summary>
		bool IsContextBound { get; }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		bool IsProgramBound { get; }

		/// <summary>
		/// Create or update resources defined by this IGraphicsState, based on the associated <see cref="ShaderProgram"/>.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> that will be used in conjunction with this IGraphicsState.
		/// </param>
		void Create(GraphicsContext ctx, ShaderProgram shaderProgram);

		/// <summary>
		/// Dispose resources allocated by <see cref="Create(GraphicsContext, ShaderProgram)"/>.
		/// </summary>
		void Delete();

		/// <summary>
		/// Apply the render state defined by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used in conjuction with <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> holding the uniform state.
		/// </param>
		void Apply(GraphicsContext ctx, ShaderProgram shaderProgram);

		#endregion

		#region Stack Support

		/// <summary>
		/// Push/copy this state onto the stack, to be restored later.
		/// </summary>
		/// <returns>
		/// It returns the most appropriate IGraphicsState for managing a set of state on a stack structure.
		/// </returns>
		IGraphicsState Push();

		/// <summary>
		/// Merge this state with another one, generally after a <see cref="Push"/> execution.
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
	}
}
