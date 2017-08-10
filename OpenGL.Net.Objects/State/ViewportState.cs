
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
	[DebuggerDisplay("ViewportState: Modes={Modes} Factor={Factor} Units={Units}")]
	public class ViewportState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Construct the ViewportState representing the current state.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> that specifies
		/// </param>
		public ViewportState(int x, int y, int w, int h)
		{
			_Viewport[0] = x;
			_Viewport[1] = y;
			_Viewport[2] = w;
			_Viewport[3] = h;
		}

		/// <summary>
		/// Construct the ViewportState representing the current state.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> that specifies
		/// </param>
		public ViewportState(GraphicsContext ctx)
		{
			Gl.Get(GetPName.Viewport, _Viewport);
		}

		#endregion

		#region Information

		/// <summary>
		/// Get the position of the viewport.
		/// </summary>
		public Vertex2i Position { get { return (new Vertex2i(_Viewport[0], _Viewport[1])); } }

		/// <summary>
		/// Get the size of the viewport.
		/// </summary>
		public Vertex2i Size { get { return (new Vertex2i(_Viewport[2], _Viewport[3])); } }

		public int Width { get { return (_Viewport[2]); } }

		public int Height { get { return (_Viewport[3]); } }

		/// <summary>
		/// Viewport coordinates.
		/// </summary>
		private readonly int[] _Viewport = new int[4];

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.Viewport";

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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			ViewportState currentState = (ViewportState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			Gl.Viewport(_Viewport[0], _Viewport[1], _Viewport[2], _Viewport[3]);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, ViewportState currentState)
		{
			if (_Viewport[0] != currentState._Viewport[0] || _Viewport[1] != currentState._Viewport[1] ||
				_Viewport[2] != currentState._Viewport[2] || _Viewport[3] != currentState._Viewport[3])
				Gl.Viewport(_Viewport[0], _Viewport[1], _Viewport[2], _Viewport[3]);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			throw new InvalidOperationException();
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

			return (true);
		}

		#endregion
	}
}
