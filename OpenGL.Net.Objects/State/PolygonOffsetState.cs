
// Copyright (C) 2012-2015 Luca Piccioni
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
	/// Specify how polygons are rasterized.
	/// </summary>
	[DebuggerDisplay("PolygonOffsetState: Modes={Modes} Factor={Factor} Units={Units}")]
	public class PolygonOffsetState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		public PolygonOffsetState()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="factor"></param>
		/// <param name="units"></param>
		public PolygonOffsetState(float factor, float units) :
			this(Mode.All, factor, units)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="modes"></param>
		/// <param name="factor"></param>
		/// <param name="units"></param>
		public PolygonOffsetState(Mode modes, float factor, float units)
		{
			_Modes = modes;
			_Factor = factor;
			_Units = units;
		}

		/// <summary>
		/// Construct the current PolygonOffsetState.
		/// </summary>
		/// <param name='ctx'>
		/// Context.
		/// </param>
		public PolygonOffsetState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Mode modes = Mode.None;

			if (Gl.IsEnabled(EnableCap.PolygonOffsetPoint))
				modes |= Mode.Point;
			if (Gl.IsEnabled(EnableCap.PolygonOffsetLine))
				modes |= Mode.Line;
			if (Gl.IsEnabled(EnableCap.PolygonOffsetFill))
				modes |= Mode.Fill;

			Gl.Get(Gl.POLYGON_OFFSET_FACTOR, out _Factor);
			Gl.Get(Gl.POLYGON_OFFSET_UNITS, out _Units);
		}

		#endregion

		#region Information

		/// <summary>
		/// Modes affected by this state.
		/// </summary>
		[Flags]
		public enum Mode
		{
			/// <summary>
			/// No offset.
			/// </summary>
			None =			0x00,

			/// <summary>
			/// Offset applied to rasterized points.
			/// </summary>
			Point =			0x01,

			/// <summary>
			/// Offset applied to rasterized lines.
			/// </summary>
			Line =			0x02,

			/// <summary>
			/// Offset applied to rasterized polygons.
			/// </summary>
			Fill =			0x04,

			/// <summary>
			/// Offset applied to rasterized fragments.
			/// </summary>
			All =			Point | Line | Fill,
		}

		/// <summary>
		/// Modes affected by the polygon offset.
		/// </summary>
		public Mode Modes { get { return (_Modes); } set { _Modes = value; } }

		/// <summary>
		/// Modes affected
		/// </summary>
		private Mode _Modes = Mode.None;

		/// <summary>
		/// Specify the offset applied to depth of the polygon.
		/// </summary>
		public float Factor { get { return (_Factor); } set { _Factor = value; } }

		/// <summary>
		/// Specifies a scale factor that is used to create a variable depth offset for each polygon.
		/// </summary>
		private float _Factor;

		/// <summary>
		/// Specify the units of <see cref="Factor"/>.
		/// </summary>
		public float Units { get { return (_Units); } set { _Units = value; } }

		/// <summary>
		/// Is multiplied by an implementation-specific value to create a constant depth offset.
		/// </summary>
		private float _Units;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for PolygonOffsetState.
		/// </summary>
		public static PolygonOffsetState DefaultState { get { return (new PolygonOffsetState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.PolygonOffset";

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

			PolygonOffsetState currentState = (PolygonOffsetState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			// Enable polygon offset for all primitive
			if ((_Modes & Mode.Point) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetPoint);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetPoint);
			}

			if ((_Modes & Mode.Line) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetLine);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetLine);
			}

			if ((_Modes & Mode.Fill) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetFill);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetFill);
			}

			// Set polygon offset
			Gl.PolygonOffset(_Factor, _Units);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, PolygonOffsetState currentState)
		{
			if (currentState._Modes != _Modes) {
				bool currentMode, thisMode;

				currentMode = (currentState._Modes & Mode.Point) != 0;
				thisMode = (_Modes & Mode.Point) != 0;
				if (currentMode != thisMode) {
					if (thisMode)
						Gl.Enable(EnableCap.PolygonOffsetPoint);
					else
						Gl.Disable(EnableCap.PolygonOffsetPoint);
				}

				currentMode = (currentState._Modes & Mode.Line) != 0;
				thisMode = (_Modes & Mode.Line) != 0;
				if (currentMode != thisMode) {
					if (thisMode)
						Gl.Enable(EnableCap.PolygonOffsetLine);
					else
						Gl.Disable(EnableCap.PolygonOffsetLine);
				}

				currentMode = (currentState._Modes & Mode.Fill) != 0;
				thisMode = (_Modes & Mode.Fill) != 0;
				if (currentMode != thisMode) {
					if (thisMode)
						Gl.Enable(EnableCap.PolygonOffsetFill);
					else
						Gl.Disable(EnableCap.PolygonOffsetFill);
				}
			}

			// Set polygon offset
			if (Math.Abs(currentState._Factor - _Factor) >= Single.Epsilon || Math.Abs(currentState._Units - _Units) >= Single.Epsilon)
				Gl.PolygonOffset(_Factor, _Units);
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

			PolygonOffsetState otherState = state as PolygonOffsetState;

			if (otherState == null)
				throw new ArgumentException("not a PolygonOffsetState", "state");

			_Modes = otherState._Modes;
			_Factor = otherState._Factor;
			_Units = otherState._Units;
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
			Debug.Assert(other is PolygonOffsetState);

			PolygonOffsetState otherState = (PolygonOffsetState)other;

			if (_Modes != otherState._Modes)
				return (false);
			if (Math.Abs(_Factor - otherState._Factor) >= Single.Epsilon)
				return (false);
			if (Math.Abs(_Units - otherState._Units) >= Single.Epsilon)
				return (false);

			return (true);
		}

		#endregion
	}
}
