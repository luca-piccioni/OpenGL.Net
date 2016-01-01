
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
			mModes = modes;
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

			Gl.Get(Gl.POLYGON_OFFSET_FACTOR, out _Factor);
			Gl.Get(Gl.POLYGON_OFFSET_UNITS, out _Units);
		}

		#endregion

		#region Polygon Offset State Definition

		/// <summary>
		/// Modes affected by this state.
		/// </summary>
		[Flags]
		public enum Mode
		{
			/// <summary>
			/// No offset.
			/// </summary>
			Disabled = 0x00,
			/// <summary>
			/// Offset applied to rasterized points.
			/// </summary>
			Point = 0x01,
			/// <summary>
			/// Offset applied to rasterized lines.
			/// </summary>
			Line = 0x02,
			/// <summary>
			/// Offset applied to rasterized polygons.
			/// </summary>
			Fill = 0x04,
			/// <summary>
			/// Offset applied to rasterized fragments.
			/// </summary>
			All = Point | Line | Fill,
		}

		/// <summary>
		/// Modes affected by the polygon offset.
		/// </summary>
		public Mode Modes { get { return (mModes); } set { mModes = value; } }

		/// <summary>
		/// Specify the offset applied to depth of the polygon.
		/// </summary>
		public float Factor { get { return (_Factor); } set { _Factor = value; } }

		/// <summary>
		/// Specify the units of <see cref="Factor"/>.
		/// </summary>
		public float Units { get { return (_Units); } set { _Units = value; } }

		/// <summary>
		/// Modes affected
		/// </summary>
		private Mode mModes = Mode.All;

		/// <summary>
		/// Specify the offset applied to depth of the polygon.
		/// </summary>
		private float _Factor;

		/// <summary>
		/// 
		/// </summary>
		private float _Units = 1.0f;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for BlendState.
		/// </summary>
		public static PolygonModeState DefaultState { get { return (new PolygonModeState()); } }

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

			// Enable polygon offset for all primitive
			if ((mModes & Mode.Point) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetPoint);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetPoint);
			}

			if ((mModes & Mode.Line) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetLine);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetLine);
			}

			if ((mModes & Mode.Fill) != 0) {
				Gl.Enable(EnableCap.PolygonOffsetFill);
			} else {
				Gl.Disable(EnableCap.PolygonOffsetFill);
			}

			// Set polygon offset
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

			mModes = otherState.mModes;
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

			if (mModes != otherState.mModes)
				return (false);
			if (Math.Abs(_Factor - otherState._Factor) > Double.Epsilon)
				return (false);
			if (Math.Abs(_Units - otherState._Units) > Double.Epsilon)
				return (false);

			return (true);
		}

		#endregion
	}
}
