
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
using System.Diagnostics;

namespace OpenGL.State
{
	/// <summary>
	/// State tracking the transformation state.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The transform state define a set of matrices that are dedicated 
	/// </para>
	/// </remarks>
	[DebuggerDisplay("ViewportState")]
	public sealed class ViewportState : ShaderUniformState
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public ViewportState(float width, float height)
		{
			ViewportSize = new Vertex2f(width, height);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx"></param>
		public ViewportState(GraphicsContext ctx)
		{
			int[] viewportCoords = new int[4];

			// Get current viewport
			Gl.Get(Gl.VIEWPORT, viewportCoords);
			ViewportSize = new Vertex2f(viewportCoords[2] - viewportCoords[0], viewportCoords[3] - viewportCoords[1]);
		}

		#endregion

		#region Viewport Information

		/// <summary>
		/// The viewport size.
		/// </summary>
		public Vertex2f ViewportSize;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for BlendState.
		/// </summary>
		public static ViewportState DefaultState { get { return (new ViewportState(0, 0)); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.State.Viewport";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always true.
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
			int[] viewportCoords = new int[4];

			// Get current viewport
			Gl.Get(GetPName.Viewport, viewportCoords);
			ViewportSize = new Vertex2f(viewportCoords[2] - viewportCoords[0], viewportCoords[3] - viewportCoords[1]);

			// Base implementation
			base.ApplyState(ctx, shaderProgram);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="GraphicsState.StateIdentifier"/> of this state.
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
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");
			if (state.StateIdentifier != StateId)
				throw new ArgumentException("state id mismatch", "state");

			ViewportState previousState = (ViewportState)state;

			ViewportSize = previousState.ViewportSize;
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
			Debug.Assert(other is ViewportState);

			ViewportState otherState = (ViewportState)other;

			if (ViewportSize != otherState.ViewportSize)
				return (false);

			return (true);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("{0}: ViewportSize={1}x{2}", StateIdentifier, ViewportSize.X, ViewportSize.Y));
		}

		#endregion
	}
}
