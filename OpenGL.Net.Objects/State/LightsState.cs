
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
using System.Runtime.InteropServices;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// OpenGL.Net light shading model.
	/// </summary>
	public class LightsState : ShaderUniformState
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static LightsState()
		{
			// Has nested types
			DetectTypeProperties(typeof(LightsState));
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(LightsState));
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LightsState()
		{
			LightModel = new LightModelType(ColorRGBAF.ColorWhite);
			Lights = new Light[8];
		}

		#endregion

		#region Structures

		/// <summary>
		/// Light model global parameters.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		[ShaderUniformState()]
		public struct LightModelType
		{
			/// <summary>
			/// Construct a LightModelType with a specific ambientLighting.
			/// </summary>
			/// <param name="ambientLighting"></param>
			public LightModelType(ColorRGBAF ambientLighting)
			{
				AmbientLighting = ambientLighting;
			}

			/// <summary>
			/// The ambient lighting.
			/// </summary>
			[ShaderUniformState("AmbientLighting")]
			public ColorRGBAF AmbientLighting;
		}

		/// <summary>
		/// Light structure.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		[ShaderUniformState()]
		public struct Light
		{
			#region Constructors

			/// <summary>
			/// Construct Light with a diffuse color.
			/// </summary>
			/// <param name="diffuse"></param>
			public Light(ColorRGBAF diffuse)
			{
				AmbientColor = ColorRGBAF.ColorBlack;
				DiffuseColor = diffuse;
				SpecularColor = ColorRGBAF.ColorBlack;
				Direction = Vertex3f.UnitY;
				Position = Vertex4f.Zero;
				HalfVector = Vertex3f.Zero;
				AttenuationFactors = Vertex3f.Zero;
				FallOff = Vertex2f.Zero;
			}

			#endregion

			#region Common Parameters (All Lights)

			/// <summary>
			/// Light ambient color.
			/// </summary>
			[ShaderUniformState("AmbientColor")]
			public ColorRGBAF AmbientColor;

			/// <summary>
			/// Light diffuse color.
			/// </summary>
			[ShaderUniformState("DiffuseColor")]
			public ColorRGBAF DiffuseColor;

			/// <summary>
			/// Light specular color.
			/// </summary>
			[ShaderUniformState("SpecularColor")]
			public ColorRGBAF SpecularColor;

			#endregion

			#region Model Parameters

			/// <summary>
			/// The light position vector (used by directional and spot lights).
			/// </summary>
			[ShaderUniformState("Direction")]
			public Vertex3f Direction;

			/// <summary>
			/// The light position vector (used by point and spot lights).
			/// </summary>
			[ShaderUniformState("Position")]
			public Vertex4f Position;

			/// <summary>
			/// The light half-vector (used by directional lights).
			/// </summary>
			[ShaderUniformState("HalfVector")]
			public Vertex3f HalfVector;

			/// <summary>
			/// The light attenuation factors (X: constant; Y: linear; Z: quadratic; used by point and spot lights).
			/// </summary>
			[ShaderUniformState("AttenuationFactors")]
			public Vertex3f AttenuationFactors;

			/// <summary>
			/// The spot fall-off parameters (X: fall-off angle in degrees; Y: fall-off exponent, used by spot lights).
			/// </summary>
			[ShaderUniformState("FallOff")]
			public Vertex2f FallOff;

			#endregion
		}

		#endregion

		#region Lights State

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public LightModelType LightModel;

		/// <summary>
		/// Lights state.
		/// </summary>
		[ShaderUniformState("glo_Light")]
		public Light[] Lights;

		/// <summary>
		/// The enabled lights count.
		/// </summary>
		[ShaderUniformState()]
		public int LightsCount;

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformStateBase derived classes.
		/// </summary>
		public static string StateId = "OpenGL.Net.LightsState";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always true, since it supports also fixed pipeline.
		/// </remarks>
		public override bool IsContextBound { get { return (true); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public override bool IsShaderProgramBound { get { return (true); } }

		/// <summary>
		/// Apply this TransformStateBase.
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

				throw new NotImplementedException();
			} else {
				// Base implementation
				base.ApplyState(ctx, shaderProgram);
			}
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		/// <remarks>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");

			TransformStateBase otherState = state as TransformStateBase;

			if (otherState == null)
				throw new ArgumentException("not a TransformStateBase", "state");

			
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
			return (String.Empty);
		}

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
