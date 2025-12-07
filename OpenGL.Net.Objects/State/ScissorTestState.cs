
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
	public class ScissorTestState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default ScissorState (scissor disabled).
		/// </summary>
		public ScissorTestState()
		{
			
		}

		/// <summary>
		/// Construct the current ScissorState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining this GraphicsState.
		/// </param>
		public ScissorTestState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			Enabled = Gl.IsEnabled(EnableCap.ScissorTest);
		}

		/// <summary>
		/// Construct a ScissorState (scissor enabled).
		/// </summary>
		public ScissorTestState(int x, int y, uint w, uint h)
		{
			Enabled = true;
			X = x;
			Y = y;
			Width = w;
			Height = h;
		}

		#endregion

		#region Information

		/// <summary>
		/// Get or set the enable flag of the scissor.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Scissor X coordinate, in pixels.
		/// </summary>
		private int X { get; set; }

		/// <summary>
		/// Scissor Y coordinate, in pixels.
		/// </summary>
		private int Y { get; set; }

		/// <summary>
		/// Scissor width, in pixels.
		/// </summary>
		private uint Width { get; set; }

		/// <summary>
		/// Scissor height, in pixels.
		/// </summary>
		private uint Height { get; set; }

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for DepthTestState.
		/// </summary>
		public static ScissorTestState DefaultState { get { return (new ScissorTestState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static string StateId = "OpenGL.ScissorTest";

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
				throw new ArgumentNullException(nameof(ctx));

			ScissorTestState currentState = (ScissorTestState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			if (Enabled) {
				// Enable scissor test
				Gl.Enable(EnableCap.ScissorTest);
				// Set scissor coordinates
				Gl.Scissor(X, Y, (int)Width, (int)Height);
			} else {
				// Disable depth test
				Gl.Disable(EnableCap.ScissorTest);
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, ScissorTestState currentState)
		{
			if (Enabled) {
				// Enable scissor test
				if (currentState.Enabled == false)
					Gl.Enable(EnableCap.ScissorTest);
				// Set scissor coordinates
				Gl.Scissor(X, Y, (int)Width, (int)Height);
			} else {
				// Disable depth test
				if (currentState != null && currentState.Enabled)
					Gl.Disable(EnableCap.ScissorTest);
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
				throw new ArgumentNullException(nameof(state));

			ScissorTestState otherState = state as ScissorTestState;

			if (otherState == null)
				throw new ArgumentException("not a ScissorTestState", nameof(state));

			Enabled = otherState.Enabled;
			X = otherState.X;
			Y = otherState.Y;
			Width = otherState.Width;
			Height = otherState.Height;
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
			Debug.Assert(other is ScissorTestState);

			ScissorTestState otherState = (ScissorTestState)other;

			if (otherState.Enabled != Enabled)
				return false;
			if (otherState.X != X)
				return false;
			if (otherState.Y != Y)
				return false;
			if (otherState.Width != Width)
				return false;
			if (otherState.Height != Height)
				return false;

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
			return ($"{StateIdentifier}: Enabled={Enabled} X={X} Y={Y} W={Width} H={Height}");
		}

		#endregion
	}
}
