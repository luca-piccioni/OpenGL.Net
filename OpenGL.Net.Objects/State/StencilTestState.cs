
// Copyright (C) 2018 Luca Piccioni
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
	/// Stencil test state.
	/// </summary>
	public class StencilTestState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default StencilTestState (stencil test disabled).
		/// </summary>
		public StencilTestState()
		{

		}

		#endregion

		#region Information

		/// <summary>
		/// Get or set the enable flag of the stencil test.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO, 
		/// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
		/// </summary>
		public StencilOp StencilTestFail { get; set; } = StencilOp.Keep;

		/// <summary>
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. It accepts 
		/// the same symbolic constants StencilOp. The initial value is Gl.KEEP.
		/// </summary>
		public StencilOp DepthTestFail { get; set; } = StencilOp.Keep;

		/// <summary>
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. DpPass accepts the same symbolic 
		/// constants in StencilOp. The initial value is Gl.KEEP.
		/// </summary>
		public StencilOp DepthTestPass { get; set; } = StencilOp.Keep;

		/// <summary>
		/// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL, 
		/// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
		/// </summary>
		public StencilFunction Function { get; set; } = StencilFunction.Always;

		/// <summary>
		///  Specifies the reference value for the stencil test. @ref is clamped to the range 02n-1, where n is the 
		/// number of bitplanes in the stencil buffer. The initial value is 0.
		/// </summary>
		public int Ref { get; set; }

		/// <summary>
		/// Specifies a mask that is ANDed with bosth the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </summary>
		public uint Mask { get; set; } = 0xFFFFFFFF;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for DepthTestState.
		/// </summary>
		public static StencilTestState DefaultState { get { return (new StencilTestState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static string StateId = "OpenGL.StencilTest";

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
		/// Apply this depth test render state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="program"/>.
		/// </param>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void Apply(GraphicsContext ctx, ShaderProgram program)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			StencilTestState currentState = (StencilTestState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			if (Enabled) {
				// Enable depth test
				Gl.Enable(EnableCap.StencilTest);
				// Set stencil function
				Gl.StencilFunc(Function, Ref, Mask);
				// Set stencil operations
				Gl.StencilOp(StencilTestFail, DepthTestFail, DepthTestPass);
			} else {
				// Disable depth test
				Gl.Disable(EnableCap.StencilTest);
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, StencilTestState currentState)
		{
			if (Enabled) {
				// Enable depth test
				if (currentState.Enabled == false)
					Gl.Enable(EnableCap.StencilTest);
				// Set stencil function
				if (currentState.Function != Function || currentState.Ref != Ref || currentState.Mask != Mask)
					Gl.StencilFunc(Function, Ref, Mask);
				// Set stencil function
				if (currentState.StencilTestFail != StencilTestFail || currentState.DepthTestFail != DepthTestFail || currentState.DepthTestPass != DepthTestPass)
					Gl.StencilOp(StencilTestFail, DepthTestFail, DepthTestPass);
			} else {
				// Disable depth test
				if (currentState != null && currentState.Enabled == true)
					Gl.Disable(EnableCap.StencilTest);
			}
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

			StencilTestState otherState = state as StencilTestState;

			if (otherState == null)
				throw new ArgumentException("not a StencilTestState", "state");

			Enabled = otherState.Enabled;
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
			Debug.Assert(other is StencilTestState);

			StencilTestState otherState = (StencilTestState)other;

			if (otherState.Enabled != Enabled)
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
			return (String.Format("{0}: Enabled={1}", StateIdentifier, Enabled));
		}

		#endregion
	}
}
