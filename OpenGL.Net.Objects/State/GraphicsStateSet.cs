
// Copyright (C) 2011-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// A set of GraphicsState.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class collects <see cref="GraphicsState"/> instances to specify a set of parameters that affect drawing
	/// operations. Each <see cref="GraphicsState"/> instance is applied, replacing the previous state having the same
	/// type (<see cref="IGraphicsState.StateIdentifier"/>).
	/// </para>
	/// <para>
	/// Usually rendering operations are ordered by the state they requires, and the order is meant to
	/// minimize the state changes. The state is applied only if the actually one is different to the one
	/// to be applied. This operation is performed using Merge method.
	/// </para>
	/// </remarks>
	[DebuggerDisplay("GraphicsStateSet: States={_RenderStates.Count}")]
	public class GraphicsStateSet
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GraphicsStateSet()
		{
			int index;

			index = ViewportState.StateSetIndex;
			index = PixelAlignmentState.StateSetIndex;
			index = PrimitiveRestartState.StateSetIndex;
			index = TransformState.StateSetIndex;
			index = CullFaceState.StateSetIndex;
			index = BlendState.StateSetIndex;
			index = DepthTestState.StateSetIndex;
			index = PolygonModeState.StateSetIndex;
			index = PolygonOffsetState.StateSetIndex;
			index = ShaderUniformState.StateSetIndex;
			index = LightsState.StateSetIndex;
			index = MaterialState.StateSetIndex;
			index = ShadowsState.StateSetIndex;
			index = WriteMaskState.StateSetIndex;
		}

		#endregion

		#region State Factory

		/// <summary>
		/// Factory method for getting the default render state set.
		/// </summary>
		/// <returns>
		/// It returns a GraphicsStateSet representing the default state set.
		/// </returns>
		public static GraphicsStateSet GetDefaultSet()
		{
			GraphicsStateSet renderStateSet = new GraphicsStateSet();

			// Instantiate all context-bound states
			renderStateSet.DefineState(PixelAlignmentState.DefaultState);
			renderStateSet.DefineState(TransformState.DefaultState);
			renderStateSet.DefineState(DepthTestState.DefaultState);
			renderStateSet.DefineState(BlendState.DefaultState);
			renderStateSet.DefineState(CullFaceState.DefaultState);
			renderStateSet.DefineState(PolygonOffsetState.DefaultState);

			return (renderStateSet);
		}

		/// <summary>
		/// Factory method for getting the current render state set.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining the state vector.
		/// </param>
		/// <returns>
		/// It returns a GraphicsStateSet representing the currently active state vector.
		/// </returns>
		public static GraphicsStateSet GetCurrentStateSet(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			GraphicsStateSet renderStateSet = new GraphicsStateSet();

			// Instantiate all context-bound states
			renderStateSet.DefineState(new PolygonModeState(ctx));
			renderStateSet.DefineState(new BlendState(ctx));
			renderStateSet.DefineState(new DepthTestState(ctx));
			renderStateSet.DefineState(new CullFaceState(ctx));
			//renderStateSet.DefineState(new RenderBufferState(ctx));
			//renderStateSet.DefineState(new ViewportState(ctx));
			//renderStateSet.DefineState(new TransformState(ctx));
			
			return (renderStateSet);
		}

		#endregion

		#region Set Definition

		/// <summary>
		/// Define/override a state.
		/// </summary>
		/// <param name="renderState">
		/// A <see cref="IGraphicsState"/> that specify how the render state is modified.
		/// </param>
		public void DefineState(IGraphicsState renderState)
		{
			if (renderState == null)
				throw new ArgumentNullException("renderState");
			if (renderState.StateIndex >= _RenderStates.Length)
				throw new ArgumentException(renderState.GetType() + " not registered", "renderState");

			// Reference the new state, loose the previous one
			_RenderStates[renderState.StateIndex] = renderState;
		}

		/// <summary>
		/// Undefine a state.
		/// </summary>
		/// <param name="stateId">
		/// A <see cref="String"/> that identify a specific state to undefine.
		/// </param>
		public void UndefineState(int stateIndex)
		{
			if (stateIndex >= _RenderStates.Length)
				throw new ArgumentOutOfRangeException("stateIndex");

			// Remove state
			_RenderStates[stateIndex] = null;
		}

		/// <summary>
		/// Determine whether a specific state is defined in this set.
		/// </summary>
		/// <param name="stateId">
		/// A <see cref="String"/> that identify a specific state.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether a state is defined in this GraphicsStateSet.
		/// </returns>
		public bool IsDefinedState(int stateIndex)
		{
			if (stateIndex >= _RenderStates.Length)
				throw new ArgumentOutOfRangeException("stateIndex");

			return (_RenderStates[stateIndex] != null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="stateId"></param>
		/// <returns></returns>
		public IGraphicsState this[int stateIndex]
		{
			get
			{
				// Defensive
				Debug.Assert(stateIndex < _RenderStates.Length);
				if (stateIndex >= _RenderStates.Length)
					return (null);

				return (_RenderStates[stateIndex]);
			}
			set
			{
				if (value == null)
					throw new InvalidOperationException("null state not allowed");
				
				DefineState(value);
			}
		}

		/// <summary>
		/// An enumerable of the states collected by this GraphicsStateSet.
		/// </summary>
		public IEnumerable<IGraphicsState> States { get { return (_RenderStates); } }

		/// <summary>
		/// The set of GraphicsState.
		/// </summary>
		private readonly IGraphicsState[] _RenderStates = new IGraphicsState[GraphicsState.GetStateCount()];

		#endregion

		#region Application

		public void Create(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					state.Create(ctx, shaderProgram);
		}

		public void Delete()
		{
			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					state.Delete();
		}

		/// <summary>
		/// Apply the set of GraphicsState collected by this instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining the state vector.
		/// </param>
		public void Apply(GraphicsContext ctx)
		{
			Apply(ctx, null);
		}

		/// <summary>
		/// Apply the set of GraphicsState collected by this instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining the state vector.
		/// </param>
		/// <param name="program">
		/// A <see cref="ShaderProgram"/> defining the uniform state. This value can be null.
		/// </param>
		public void Apply(GraphicsContext ctx, ShaderProgram program)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Apply known states
			foreach (IGraphicsState state in _RenderStates) {
				if (state == null)
					continue;

				// Apply state if:
				// - the state is context-bound, or
				// - the state is program-bound and a shader program is currently in use
				if (state.IsContextBound || (state.IsProgramBound && program != null))
					state.Apply(ctx, program);
			}
		}

		#endregion

		#region Stack Support

		/// <summary>
		/// Clone this GraphicsStateSet.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this GraphicsStateSet.
		/// </returns>
		public GraphicsStateSet Push()
		{
			GraphicsStateSet clone = new GraphicsStateSet();

			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					clone.DefineState(state.Push());

			return (clone);
		}

		/// <summary>
		/// Merge this state set with another one.
		/// </summary>
		/// <param name="stateSet">
		/// A <see cref="GraphicsStateSet"/> to be merged with this GraphicsStateSet.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a call to this routine, this GraphicsStateSet store the union of the previous information
		/// and of the information of <paramref name="stateSet"/>.
		/// </para>
		/// <para>
		/// The semantic of the merge result is dependent by each <see cref="IGraphicsState"/> defined in both
		/// state sets.
		/// </para>
		/// <para>
		/// In the case a kind of GraphicsState is defined only in this GraphicsStateSet, the specific state remains
		/// unchanged, except when the state is not inheritable; in this case the specific state will be undefined.
		/// </para>
		/// <para>
		/// In the case a kind of GraphicsState is defined only in <paramref name="stateSet"/>, that state will be
		/// defined equally in this GraphicsStateSet.
		/// </para>
		/// <para>
		/// In the case a kind of GraphicsState is defined by both state sets, the state defined in this GraphicsStateSet
		/// will be merged with the one defined in <paramref name="stateSet"/>, by calling <see cref="IGraphicsState.Merge"/>.
		/// </para>
		/// </remarks>
		public void Merge(GraphicsStateSet stateSet)
		{
			if (stateSet == null)
				throw new ArgumentNullException("stateSet");

			for (int i = 0; i < _RenderStates.Length; i++) {
				IGraphicsState currentState = _RenderStates[i];
				IGraphicsState otherState = stateSet[i];

				if (currentState != null && otherState != null)
					_RenderStates[i].Merge(otherState);
				else if (currentState == null && otherState != null)
					_RenderStates[i] = otherState.Push();
			}
		}

		#endregion
	}
}
