
// Copyright (C) 2011-2015 Luca Piccioni
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

namespace OpenGL.State
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
	/// to be applied. This operation is performed using <see cref="Merge"/> method.
	/// </para>
	/// </remarks>
	[DebuggerDisplay("GraphicsStateSet: States={mRenderStates.Count} Customs={mCustomStates.Count}")]
	public class GraphicsStateSet : GraphicsResource
	{
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
			renderStateSet.DefineState(UniformColorState.DefaultState);
			renderStateSet.DefineState(TransformState.DefaultState);

			//renderStateSet.DefineState(PolygonModeState.DefaultState);
			//renderStateSet.DefineState(BlendState.DefaultState);
			//renderStateSet.DefineState(DepthTestState.DefaultState);
			//renderStateSet.DefineState(CullFaceState.DefaultState);
			//renderStateSet.DefineState(RenderBufferState.DefaultState);
			renderStateSet.DefineState(ViewportState.DefaultState);

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
			renderStateSet.DefineState(new RenderBufferState(ctx));
			renderStateSet.DefineState(new ViewportState(ctx));
			renderStateSet.DefineState(new TransformState(ctx));
			
			sLog.Verbose("Detected current state set:");
			foreach (KeyValuePair<string, IGraphicsState> pair in renderStateSet.mRenderStates)
				sLog.Verbose(pair.Value.ToString());
			
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

			// Store/override state
			if (renderState.StateIdentifier != null) {
				// Unreference previous state
				IGraphicsState previousState;

				if (mRenderStates.TryGetValue(renderState.StateIdentifier, out previousState) && (previousState != null))
					previousState.DecRef();

				mRenderStates[renderState.StateIdentifier] = renderState;
			} else
				mCustomStates.Add(renderState);

			// Reference the new state
			renderState.IncRef();
		}

		/// <summary>
		/// Undefine a state.
		/// </summary>
		/// <param name="stateId">
		/// A <see cref="String"/> that identify a specific state to undefine.
		/// </param>
		public void UndefineState(string stateId)
		{
			if (stateId == null)
				throw new ArgumentNullException("stateId");

			// Unreference previous state
			IGraphicsState previousState;
			if (mRenderStates.TryGetValue(stateId, out previousState) && previousState != null)
				previousState.DecRef();
			// Remove state
			mRenderStates.Remove(stateId);
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
		public bool IsDefinedState(string stateId)
		{
			if (stateId == null)
				throw new ArgumentNullException("stateId");

			return (mRenderStates.ContainsKey(stateId));
		}

		/// <summary>
		/// Undefine all custom states.
		/// </summary>
		public void UndefineCustomStates()
		{
			// Unreference all custom states
			foreach (GraphicsState customState in mCustomStates)
				customState.DecRef();
			// Remove all custom states
			mCustomStates.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="stateId"></param>
		/// <returns></returns>
		public IGraphicsState this[string stateId]
		{
			get
			{
				IGraphicsState state;

				if (mRenderStates.TryGetValue(stateId, out state))
					return (state);

				return (null);
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
		public IEnumerable<IGraphicsState> States
		{
			get
			{
				foreach (IGraphicsState state in mRenderStates.Values)
					yield return state;
				foreach (IGraphicsState state in mCustomStates)
					yield return state;
			}
		}

		/// <summary>
		/// The set of GraphicsState.
		/// </summary>
		private readonly Dictionary<string, IGraphicsState> mRenderStates = new Dictionary<string, IGraphicsState>();

		/// <summary>
		/// A list of custom states, applied after <see cref="mRenderStates"/>.
		/// </summary>
		private readonly List<IGraphicsState> mCustomStates = new List<IGraphicsState>();

		#endregion

		#region State Set Application

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
			foreach (KeyValuePair<string, IGraphicsState> pair in mRenderStates) {
				IGraphicsState state = pair.Value;
				
				if (state.IsContextBound && (currentStateSet != null) && (currentStateSet.IsDefinedState(state.StateIdentifier))) {
					IGraphicsState currentState = currentStateSet[state.StateIdentifier];

					if (currentState.Inheritable && state.Equals(currentState))
						continue;
				}

				// Apply state if the state is context-bound, or a shader is currently in use
				if ((program != null) || (state.IsContextBound))
					state.ApplyState(ctx, program);
			}

			// Apply custom states, if any
			foreach (GraphicsState customState in mCustomStates) {
				if ((program != null) || (customState.IsContextBound))
					customState.ApplyState(ctx, program);
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
			foreach (GraphicsState state in thisSetStates) {
				IGraphicsState otherState = stateSet[state.StateIdentifier];

				if (state.Inheritable == false) {
					// Do not include non-inheritable states
					UndefineState(state.StateIdentifier);
					// Include merged state, if defined
					if (otherState != null)
						DefineState(otherState);
				} else {
					if (otherState != null)
						state.Merge(otherState);
				}
			}
			// Include states not defined by this
			foreach (GraphicsState state in stateSet.States)
				if (IsDefinedState(state.StateIdentifier) == false)
					DefineState(state);
		}

		/// <summary>
		/// Merge this GraphicsStateSet with a current state.
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
		/// <returns></returns>
		internal GraphicsStateSet Merge(GraphicsContext ctx, ShaderProgram program, GraphicsStateSet currentStateSet)
		{
			GraphicsStateSet mergedState = new GraphicsStateSet();

			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (currentStateSet == null)
				throw new ArgumentNullException("currentStateSet");

			// Apply most recent states
			foreach (KeyValuePair<string, IGraphicsState> pair in mRenderStates)
				mergedState.DefineState(pair.Value.Copy());

			// Keep inherited states
			foreach (KeyValuePair<string, IGraphicsState> pair in currentStateSet.mRenderStates) {
				IGraphicsState state = pair.Value;

				if (mergedState.IsDefinedState(state.StateIdentifier) == false)
					mergedState.DefineState(state.Copy());
				else
					mergedState[state.StateIdentifier].Merge(state);
			}

			mergedState.Apply(ctx, program);

			return (mergedState);
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

			foreach (KeyValuePair<string, IGraphicsState> pair in mRenderStates)
				clone.mRenderStates.Add(pair.Key, pair.Value.Copy());

			return (clone);
		}

		#endregion
		
		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("A2D35FBD-7918-4CD6-85A2-465D41474DF1");

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a false, since this is not a real OpenGL object.
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (false);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			foreach (GraphicsState renderState in mRenderStates.Values)
				if (renderState.Exists(ctx) == false)
					renderState.Create(ctx);
			foreach (GraphicsState renderState in mCustomStates)
				if (renderState.Exists(ctx) == false)
					renderState.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Identifiable states
				foreach (GraphicsState renderState in mRenderStates.Values)
					renderState.DecRef();
				mRenderStates.Clear();
				// Custom states
				UndefineCustomStates();
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
