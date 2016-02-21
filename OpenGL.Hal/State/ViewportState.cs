
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.State
{
	/// <summary>
	/// State tracking the viewport state.
	/// </summary>
	[DebuggerDisplay("ViewportState: Size={Viewport}")]
	public class ViewportState : ShaderUniformState
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ViewportState()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(ViewportState));
		}

		/// <summary>
		/// Construct a ViewportState specifing the width and the height of the viewport.
		/// </summary>
		/// <param name="width">
		/// A <see cref="Int32"/> that specify the width of the viewport.
		/// </param>
		/// <param name="height">
		/// A <see cref="Int32"/> that specify the height of the viewport.
		/// </param>
		public ViewportState(int width, int height)
		{
			Viewport = new Vertex4i(0, 0, width, height);
		}

		/// <summary>
		/// Construct a ViewportState representing the current viewport state.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> holding the viewport state.
		/// </param>
		public ViewportState(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Get current viewport
			int[] viewportCoords = new int[4];
			Gl.Get(Gl.VIEWPORT, viewportCoords);
			Viewport = new Vertex4i(viewportCoords[0], viewportCoords[1], viewportCoords[2], viewportCoords[3]);
		}

		/// <summary>
		/// Construct the default ViewportState corresponding to a specific <see cref="GraphicsSurface"/>.
		/// </summary>
		/// <param name="graphicsSurface">
		/// The <see cref="GraphicsSurface"/> that specify tha default viewport extents.
		/// </param>
		public ViewportState(GraphicsSurface graphicsSurface)
		{
			if (graphicsSurface == null)
				throw new ArgumentNullException("graphicsSurface");

			Viewport = new Vertex4i(0, 0, (int)graphicsSurface.Width, (int)graphicsSurface.Height);
		}

		#endregion

		#region Viewport Information

		/// <summary>
		/// Get the width of the viewport, in pixels.
		/// </summary>
		public int ViewportWidth { get { return (Viewport.z); } }

		/// <summary>
		/// Get the height of the viewport, in pixels.
		/// </summary>
		public int ViewportHeight { get { return (Viewport.w); } }

		/// <summary>
		/// The viewport position and size, packed into a <see cref="Vertex4i"/>.
		/// </summary>
		public Vertex4i Viewport;

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
		public const string StateId = "OpenGL.State.Viewport";

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
		public override bool IsContextBound { get { return (true); } }

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

			// Server state
			Gl.Viewport(Viewport.x, Viewport.y, Viewport.z, Viewport.w);
			// Base implementation (shader application)
			if (shaderProgram != null)
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

			Viewport = previousState.Viewport;
		}

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected override Dictionary<string, UniformStateMember> UniformState { get { return (_UniformProperties); } }

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

			if (Viewport != otherState.Viewport)
				return (false);

			return (true);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("{0}: Viewport={1}", StateIdentifier, Viewport));
		}

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
