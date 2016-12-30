
// Copyright (C) 2011-2016 Luca Piccioni
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
using System.Reflection;

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
	public class GraphicsStateSet : IResource
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GraphicsStateSet()
		{
			int index;

			index = TransformStateBase.StateSetIndex;
			index = CullFaceState.StateSetIndex;
			index = BlendState.StateSetIndex;
			index = DepthTestState.StateSetIndex;
			index = PolygonModeState.StateSetIndex;
			index = PolygonOffsetState.StateSetIndex;
			index = ShaderUniformState.StateSetIndex;
			index = LightsStateBase.StateSetIndex;
			index = MaterialState.StateSetIndex;
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
			renderStateSet.DefineState(TransformState.DefaultState);
			renderStateSet.DefineState(DepthTestState.DefaultState);
			renderStateSet.DefineState(BlendState.DefaultState);
			renderStateSet.DefineState(CullFaceState.DefaultState);

			// renderStateSet.DefineState(UniformColorState.DefaultState);
			//renderStateSet.DefineState(PolygonModeState.DefaultState);
			//renderStateSet.DefineState(CullFaceState.DefaultState);
			//renderStateSet.DefineState(RenderBufferState.DefaultState);
			//renderStateSet.DefineState(ViewportState.DefaultState);

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
			renderStateSet.DefineState(new TransformState(ctx));
			
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

			int stateIndex = renderState.StateIndex;

			// Unreference previous state
			IGraphicsState previousState;

			if ((previousState = _RenderStates[stateIndex]) != null)
				previousState.DecRef();

			// Reference the new state
			_RenderStates[stateIndex] = renderState;
			renderState.IncRef();
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

			// Unreference previous state
			IGraphicsState previousState;

			if ((previousState = _RenderStates[stateIndex]) != null)
				previousState.DecRef();
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

		#region State Set Application

		public void Create(GraphicsContext ctx)
		{
			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					state.CreateState(ctx);
		}

		/// <summary>
		/// Apply the set of GraphicsState collected by this instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining the state vector.
		/// </param>
		public void Apply(GraphicsContext ctx)
		{
			Apply(ctx, null, null);
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
			Apply(ctx, program, null);
		}

		/// <summary>
		/// Apply the set of GraphicsState collected by this instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining the state vector.
		/// </param>
		/// <param name="program">
		/// A <see cref="ShaderProgram"/> defining the uniform state.
		/// </param>
		/// <param name="currentStateSet">
		/// 
		/// </param>
		private void Apply(GraphicsContext ctx, ShaderProgram program, GraphicsStateSet currentStateSet)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Reset texture unit state
			if (program != null)
				program.ResetTextureUnits();

			// Apply known states
			foreach (IGraphicsState state in _RenderStates) {
				if (state == null)
					continue;

				if (state.IsContextBound && (currentStateSet != null) && (currentStateSet.IsDefinedState(state.StateIndex))) {
					IGraphicsState currentState = currentStateSet[state.StateIndex];

					if (state.Equals(currentState))
						continue;
				}

				// Apply state if:
				// - the state is context-bound, or
				// - the state is program-bound and a shader program is currently in use
				if (state.IsContextBound || (state.IsShaderProgramBound && program != null))
					state.ApplyState(ctx, program);
			}
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

			List<IGraphicsState> thisSetStates = new List<IGraphicsState>(States);

			// Merge states defined by stateSet
			for (int i = 0; i < _RenderStates.Length; i++) {
				IGraphicsState currentState = _RenderStates[i];
				IGraphicsState otherState = stateSet[i];

				if (currentState != null && otherState != null)
					_RenderStates[i].Merge(otherState);
				else if (currentState == null && otherState != null)
					_RenderStates[i] = otherState.Copy();
			}
		}

		#endregion

		#region Deep Copy

		/// <summary>
		/// Clone this GraphicsStateSet.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this GraphicsStateSet.
		/// </returns>
		public GraphicsStateSet Copy()
		{
			GraphicsStateSet clone = new GraphicsStateSet();

			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					clone.DefineState(state.Copy());

			return (clone);
		}

		#endregion
		
		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger _Log = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region IResource Implementation

		/// <summary>
		/// Number of shared instances of this IGraphicsResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get { return (_RefCount); } }

		/// <summary>
		/// Increment the shared IGraphicsResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			_RefCount++;
		}

		/// <summary>
		/// Decrement the shared IGraphicsResource reference count.
		/// </summary>
		/// <remarks>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed.
		/// </remarks>
		public void DecRef()
		{
			// Instance could be never referenced with IncRef
			Debug.Assert(_RefCount > 0);
			if (_RefCount > 0)
				_RefCount--;

			// Automatically dispose when no references are available
			if (_RefCount == 0)
				Dispose();
		}

		/// <summary>
		/// Reset the reference count of this instance.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This should be used in normal code.
		/// </para>
		/// <para>
		/// This routine could be useful in the case the deep-copoy implementation uses <see cref="Object.MemberwiseClone"/>,
		/// indeed copying the reference count.
		/// </para>
		/// </remarks>
		protected void ResetRefCount() { _RefCount = 0; }

		/// <summary>
		/// The count of references for this GraphicsResource.
		/// </summary>
		private uint _RefCount;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			foreach (IGraphicsState state in _RenderStates)
				if (state != null)
					state.DecRef();
		}

		#endregion
	}
}
