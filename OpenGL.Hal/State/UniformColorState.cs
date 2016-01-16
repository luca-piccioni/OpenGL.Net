
// Copyright (C) 2016 Luca Piccioni
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
using System.Collections.Generic;

namespace OpenGL.State
{
	/// <summary>
	/// Graphics state for defining the current uniform color.
	/// </summary>
	public class UniformColorState : ShaderUniformState
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static UniformColorState()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(UniformColorState));
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public UniformColorState()
		{
			
		}

		/// <summary>
		/// Construct a UniformColorState getting the current color of a <see cref="GraphicsContext"/>, if possible.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> defining the current color.
		/// </param>
		public UniformColorState(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Get current color
			float[] currentColor = new float[4];

			Gl.Get(GetPName.CurrentColor, currentColor);

			// Store the current color
			UniformColor.Red = currentColor[0];
			UniformColor.Green = currentColor[1];
			UniformColor.Blue = currentColor[2];
			UniformColor.Alpha = currentColor[3];
		}

		#endregion

		#region Current Uniform Color

		/// <summary>
		/// The uniform color state.
		/// </summary>
		[ShaderUniformState()]
		public readonly ColorRGBA UniformColor = new ColorRGBA(1.0f);

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for UniformColorState.
		/// </summary>
		public static UniformColorState DefaultState { get { return (new UniformColorState()); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.CurrentColor";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always true, even if the server state is deprecrated in forward-compatibility profiles.
		/// </remarks>
		public override bool IsContextBound { get { return (true); } }

		/// <summary>
		/// Apply this depth test render state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			CheckCurrentContext(ctx);

			if (shaderProgram == null) {

				// Fixed pipeline rendering requires server state

				Gl.Color4((float[])UniformColor);

			} else {
				// Base implementation
				base.ApplyState(ctx, shaderProgram);
			}
		}

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected override Dictionary<string, UniformStateMember> UniformState { get { return (_UniformProperties); } }

		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("UniformColorState: UniformColor={0}", UniformColor));
		}

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
