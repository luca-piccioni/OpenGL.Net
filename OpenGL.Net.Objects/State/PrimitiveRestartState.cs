
// Copyright (C) 2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Specify the primitive restart parameters.
	/// </summary>
	public sealed class PrimitiveRestartState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Construct the default PrimitiveRestartState (disabled primitive restart, restart index equals to 0).
		/// </summary>
		public PrimitiveRestartState()
		{

		}

		/// <summary>
		/// Construct an enabled PrimitiveRestartState specifying the restart index.
		/// </summary>
		/// <param name="restartIndex">
		/// The <see cref="UInt32"/> that specifies the primitive restart index.
		/// </param>
		public PrimitiveRestartState(UInt32 restartIndex)
		{
			Enabled = true;
			RestartIndex = restartIndex;
		}

		#endregion

		#region Information

		/// <summary>
		/// Flag indicating whether the primitive restart feature is enabled.
		/// </summary>
		public readonly bool Enabled;

		/// <summary>
		/// Index value used for restarting the primitive.
		/// </summary>
		public readonly uint RestartIndex;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for PrimitiveRestartState.
		/// </summary>
		public static PrimitiveRestartState DefaultState { get { return (new PrimitiveRestartState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.PrimitiveRestart";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public static int StateSetIndex { get { return (_StateIndex); } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public override int StateIndex { get { return (_StateIndex); } }

		/// <summary>
		/// The index for this GraphicsState.
		/// </summary>
		private static int _StateIndex = NextStateIndex();

		/// <summary>
		/// Set ShaderProgram state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="program"/>.
		/// </param>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void Apply(GraphicsContext ctx, ShaderProgram program)
		{
			GraphicsResource.CheckCurrentContext(ctx);

			PrimitiveRestartState currentState = (PrimitiveRestartState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			if (Enabled) {
				// Enable
#if !MONODROID
				if (Gl.CurrentExtensions.PrimitiveRestart) {
					Gl.Enable(EnableCap.PrimitiveRestart);
					Gl.PrimitiveRestartIndex(RestartIndex);
				} else if (Gl.CurrentExtensions.PrimitiveRestart_NV) {
					Gl.EnableClientState(EnableCap.PrimitiveRestartNv);
					Gl.PrimitiveRestartIndexNV(RestartIndex);
				} else
					throw new InvalidOperationException("primitive restart not supported");
#else
				if (Gl.CurrentExtensions.PrimitiveRestart)
					Gl.Enable(EnableCap.PrimitiveRestartFixedIndex);
				else
					throw new InvalidOperationException("primitive restart not supported");
#endif
			} else {
				// Disable
#if !MONODROID
				if (Gl.CurrentExtensions.PrimitiveRestart) {
					Gl.Disable(EnableCap.PrimitiveRestart);
				} else if (Gl.CurrentExtensions.PrimitiveRestart_NV) {
					Gl.DisableClientState(EnableCap.PrimitiveRestartNv);
				} else
					throw new InvalidOperationException("primitive restart not supported");
#else
				if (Gl.CurrentExtensions.PrimitiveRestart)
					Gl.Disable(EnableCap.PrimitiveRestartFixedIndex);
				else
					throw new InvalidOperationException("primitive restart not supported");
#endif
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, PrimitiveRestartState currentState)
		{
			if (Enabled != currentState.Enabled) {
				if (Enabled) {
#if !MONODROID
					if (Gl.CurrentExtensions.PrimitiveRestart) {
						Gl.Enable(EnableCap.PrimitiveRestart);
					} else if (Gl.CurrentExtensions.PrimitiveRestart_NV) {
						Gl.EnableClientState(EnableCap.PrimitiveRestartNv);
					} else
						throw new InvalidOperationException("primitive restart not supported");
#else
					if (Gl.CurrentExtensions.PrimitiveRestart)
						Gl.Enable(EnableCap.PrimitiveRestartFixedIndex);
					else
						throw new InvalidOperationException("primitive restart not supported");
#endif
				} else {
#if !MONODROID
					if (Gl.CurrentExtensions.PrimitiveRestart) {
						Gl.Disable(EnableCap.PrimitiveRestart);
					} else if (Gl.CurrentExtensions.PrimitiveRestart_NV) {
						Gl.DisableClientState(EnableCap.PrimitiveRestartNv);
					} else
						throw new InvalidOperationException("primitive restart not supported");
#else
					if (Gl.CurrentExtensions.PrimitiveRestart)
						Gl.Disable(EnableCap.PrimitiveRestartFixedIndex);
					else
						throw new InvalidOperationException("primitive restart not supported");
#endif
				}
			}
#if !MONODROID
			if (RestartIndex != currentState.RestartIndex) {
				if (Gl.CurrentExtensions.PrimitiveRestart) {
					Gl.PrimitiveRestartIndex(RestartIndex);
				} else if (Gl.CurrentExtensions.PrimitiveRestart_NV) {
					Gl.PrimitiveRestartIndexNV(RestartIndex);
				} else
					throw new InvalidOperationException("primitive restart not supported");
			}
#endif
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			// Ignore merge operation
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

			Debug.Assert(other is PrimitiveRestartState);
			PrimitiveRestartState otherState = (PrimitiveRestartState)other;

			if (Enabled != otherState.Enabled)
				return (false);
			if (RestartIndex != otherState.RestartIndex)
				return (false);

			return (true);
		}

		#endregion
	}
}
