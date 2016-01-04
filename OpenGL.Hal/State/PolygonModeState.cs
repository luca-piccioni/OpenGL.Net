
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
	public class PolygonModeState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		public PolygonModeState()
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mode"></param>
		public PolygonModeState(PolygonMode mode)
		{
			RasterMode = mode;
		}

		/// <summary>
		/// Construct the current PolygonModeState.
		/// </summary>
		/// <param name='ctx'>
		/// Context.
		/// </param>
		public PolygonModeState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			int[] modes = new int[2];

			Gl.Get(GetPName.PolygonMode, modes);
			RasterMode = (PolygonMode)modes[0];
		}

		#endregion

		#region Polygon Mode State Definition

		/// <summary>
		/// Specify how polygon is rasterized.
		/// </summary>
		public PolygonMode RasterMode { get { return (_RasterMode); } set { _RasterMode = value; } }

		/// <summary>
		/// Specify how polygon is rasterized.
		/// </summary>
		private PolygonMode _RasterMode = PolygonMode.Fill;

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
		public static string StateId = "OpenGL.PolygonMode";

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

			// Set polygon mode
			Gl.PolygonMode(MaterialFace.FrontAndBack, RasterMode);
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

			PolygonModeState otherState = state as PolygonModeState;

			if (otherState == null)
				throw new ArgumentException("not a PolygonModeState", "state");

			_RasterMode = otherState._RasterMode;
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
			Debug.Assert(other is PolygonModeState);

			PolygonModeState otherState = (PolygonModeState) other;

			if (RasterMode != otherState.RasterMode)
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
			return (String.Format("{0}: RasterMode={1}", StateIdentifier, RasterMode));
		}
		
		#endregion
	}
}
