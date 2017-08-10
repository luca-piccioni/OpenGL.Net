
// Copyright (C) 2009-2017 Luca Piccioni
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
	/// Depth test render state.
	/// </summary>
	[DebuggerDisplay("DepthTestState: Enabled={Enabled} Function={Function}")]
	public class DepthTestState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default DepthTestState.
		/// </summary>
		public DepthTestState()
		{
			
		}

		/// <summary>
		/// Construct a DepthTestState.
		/// </summary>
		/// <param name="depthFunction">
		/// A <see cref="DepthFunction"/> that specify the test function to apply.
		/// </param>
		public DepthTestState(DepthFunction depthFunction)
		{
			_Enabled = true;
			_Function = depthFunction;
		}

		/// <summary>
		/// Construct the current DepthTestState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining this GraphicsState.
		/// </param>
		public DepthTestState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Depth test enabled
			_Enabled = Gl.IsEnabled(EnableCap.DepthTest);

			// Depth function
			int depthFunction;

			Gl.Get(GetPName.DepthFunc, out depthFunction);
			_Function = (DepthFunction)depthFunction;
		}

		#endregion

		#region Information

		/// <summary>
		/// Get or set the enable flag of the depth test.
		/// </summary>
		/// <remarks>
		/// The default value is <see cref="DepthFunction.Less"/>.
		/// </remarks>
		public bool Enabled
		{
			get { return (_Enabled); }
			set { _Enabled = value; }
		}

		/// <summary>
		/// Depth test enabled flag.
		/// </summary>
		private bool _Enabled;

		/// <summary>
		/// Get or set the depth test function.
		/// </summary>
		/// <remarks>
		/// The default value is <see cref="DepthFunction.Less"/>.
		/// </remarks>
		public DepthFunction Function
		{
			get { return (_Function); }
			set { _Function = value; }
		}

		/// <summary>
		/// Depth test function.
		/// </summary>
		private DepthFunction _Function = DepthFunction.Less;
		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for DepthTestState.
		/// </summary>
		public static DepthTestState DefaultState { get { return (new DepthTestState()); } }

		#endregion
		
		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static string StateId = "OpenGL.Depth";

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

			DepthTestState currentState = (DepthTestState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			if (_Enabled) {
				// Enable depth test
				Gl.Enable(EnableCap.DepthTest);
				// Specify depth function
				Gl.DepthFunc(Function);
			} else {
				// Disable depth test
				Gl.Disable(EnableCap.DepthTest);
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, DepthTestState currentState)
		{
			if (_Enabled) {
				// Enable depth test
				if (currentState.Enabled == false)
					Gl.Enable(EnableCap.DepthTest);
				// Specify depth function
				if (currentState.Function != Function)
					Gl.DepthFunc(Function);
			} else {
				// Disable depth test
				if (currentState != null && currentState.Enabled == true)
					Gl.Disable(EnableCap.DepthTest);
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

			DepthTestState otherState = state as DepthTestState;

			if (otherState == null)
				throw new ArgumentException("not a DepthTestState", "state");

			_Enabled = otherState._Enabled;
			_Function = otherState._Function;
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
			Debug.Assert(other is DepthTestState);

			DepthTestState otherState = (DepthTestState)other;

			if (otherState.Enabled != Enabled)
				return (false);
			if (otherState.Function != Function)
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
			return (String.Format("{0}: Function={1}", StateIdentifier, Function));
		}

		#endregion
	}
}
