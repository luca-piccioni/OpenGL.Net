
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
	/// Specify how polygons are rasterized.
	/// </summary>
	public class LineState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		public LineState()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="width"></param>
		public LineState(float width)
		{
			_Width = width;
		}

		/// <summary>
		/// Construct the current PolygonOffsetState.
		/// </summary>
		/// <param name='ctx'>
		/// Context.
		/// </param>
		public LineState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Gl.Get(Gl.LINE_WIDTH, out _Width);
		}

		#endregion

		#region Line State Definition

		/// <summary>
		/// Specify the width of rasterized lines.
		/// </summary>
		public float Width { get { return (_Width); } set { _Width = value; } }

		/// <summary>
		/// 
		/// </summary>
		private float _Width = 1.0f;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for LineState.
		/// </summary>
		public static LineState DefaultState { get { return (new LineState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.Line";

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
		/// Set ShaderProgram state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="sProgram"/>.
		/// </param>
		/// <param name="sProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram sProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Set the line width
			if (ctx.IsCompatibleProfile || (_Width <= 1.0))
				Gl.LineWidth(_Width);
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

			LineState otherState = state as LineState;

			if (otherState == null)
				throw new ArgumentException("not a LineState", "state");

			_Width = otherState._Width;
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
			Debug.Assert(other is LineState);

			LineState otherState = (LineState)other;

			return (Math.Abs(otherState._Width - _Width) < Double.Epsilon);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("{0}: Width={1}", StateIdentifier, Width));
		}

		#endregion
	}
}
