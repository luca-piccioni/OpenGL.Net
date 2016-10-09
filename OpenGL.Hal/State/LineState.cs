
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
	/// Specify how lines are rasterized.
	/// </summary>
	[DebuggerDisplay("LineState: Width={Width}")]
	public class LineState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LineState()
		{

		}

		/// <summary>
		/// Construct a LineState specifying the line width.
		/// </summary>
		/// <param name="width">
		/// A <see cref="Single"/> that specify the line width, in pixels.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is a zero or negative value.
		/// </exception>
		public LineState(float width)
		{
			if (width <= 0.0f)
				throw new ArgumentException("zero or negative value not allowed", "width");

			_Width = width;
		}

		/// <summary>
		/// Construct the current LineState.
		/// </summary>
		/// <param name='ctx'>
		/// The <see cref="GraphicsContext"/> defining the line state.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		public LineState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			Gl.Get(Gl.LINE_WIDTH, out _Width);
		}

		#endregion

		#region Line State Definition

		/// <summary>
		/// Specify the width of rasterized lines, in pixels.
		/// </summary>
		public float Width
		{
			get { return (_Width); }
			set { _Width = value; } }

		/// <summary>
		/// 
		/// </summary>
		private float _Width = 1.0f;

		#endregion

		#region Forward Compatible Profile Support

		/// <summary>
		/// Get or set the uniform variable that determine the actual line with in shader programs designed for a
		/// forward compatibility profile.
		/// </summary>
		public string UniformName
		{
			get { return (_UniformName); }
			set
			{
				_UniformName = String.IsNullOrEmpty(value) ? DefaultUniformName : value;
			}
		}

		/// <summary>
		/// The uniform variable that determine the actual line with in shader programs designed for a
		/// forward compatibility profile.
		/// </summary>
		private string _UniformName = DefaultUniformName;

		/// <summary>
		/// Default uniform variable name.
		/// </summary>
		/// <remarks>
		/// This value is derived by the OpenGL.Hal line shader.
		/// </remarks>
		private const string DefaultUniformName = "hal_LineWidth";

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for LineState.
		/// </summary>
		public static LineState DefaultState { get { return (new LineState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of LineState.
		/// </summary>
		public static string StateId = "OpenGL.Line";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public override bool IsShaderProgramBound { get { return (true); } }

		/// <summary>
		/// Set LineState state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Debug.Assert(Width >= 0.0f);
			Debug.Assert(!String.IsNullOrEmpty(UniformName));

			// Set the line width
			if ((ctx.IsCompatibleProfile == true) || (shaderProgram == null) || (_Width <= 1.0)) {
				float[] validRange = Gl.CurrentLimits.AliasedLineWidthRange;
				float actualWidth = Math.Max(validRange[0], Math.Min(_Width, validRange[1]));

				// LineWidth shall be called in the case drawing in immediate mode, or when no shader program
				// is bound or when the line width is less than 1.0f
				Gl.LineWidth(actualWidth);

			} else if ((shaderProgram != null) && (shaderProgram.IsActiveUniform(UniformName) == true)) {

				// Note that the width is not clamped in the higher boundary.

				// In forward compatibility profiles, it is not possible to draw lines with a width greater than 1.0f; this
				// mean that 'shaderProgram' possibly setup a geometry shader that takes the responsability of drawing a
				// line with a width greater than 1.0f
				shaderProgram.SetUniform(ctx, UniformName, _Width);
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

			if (Math.Abs(otherState._Width - _Width) >= Double.Epsilon)
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
			return (String.Format("{0}: Width={1}", StateIdentifier, Width));
		}

		#endregion
	}
}
