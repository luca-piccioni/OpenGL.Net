
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
	public class MaterialState : ShaderUniformStateBase
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static MaterialState()
		{
			// Has nested types
			DetectTypeProperties(typeof(MaterialState));
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(MaterialState));
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MaterialState()
		{
			
		}

		#endregion

		#region Structures

		/// <summary>
		/// Light model global parameters.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		[ShaderUniformState()]
		public struct Material
		{
			/// <summary>
			/// Construct a Material with a specific diffuse color.
			/// </summary>
			/// <param name="diffuse"></param>
			public Material(ColorRGBAF diffuse)
			{
				Ambient = ColorRGBAF.ColorBlack;
				Emissive = ColorRGBAF.ColorBlack;
				Diffuse = diffuse;
				Specular = ColorRGBAF.ColorBlack;
				Shininess = 1.0f;
			}

			/// <summary>
			/// The ambient color.
			/// </summary>
			[ShaderUniformState("AmbientColor")]
			public ColorRGBAF Ambient;

			/// <summary>
			/// The emissive color.
			/// </summary>
			[ShaderUniformState("EmissiveColor")]
			public ColorRGBAF Emissive;

			/// <summary>
			/// The diffuse color.
			/// </summary>
			[ShaderUniformState("DiffuseColor")]
			public ColorRGBAF Diffuse;

			/// <summary>
			/// The specular color.
			/// </summary>
			[ShaderUniformState("SpecularColor")]
			public ColorRGBAF Specular;

			/// <summary>
			/// Material shininess.
			/// </summary>
			[ShaderUniformState("Shininess")]
			public float Shininess;
		}

		#endregion

		#region Material State

		/// <summary>
		/// The front face material
		/// </summary>
		[ShaderUniformState()]
		public Material FrontMaterial;

		/// <summary>
		/// The front face material texture for emission component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialEmissionTexture;

		/// <summary>
		/// The front face material texture for emission component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialEmissionTexCoord = -1;

		/// <summary>
		/// The front face material texture for ambient component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialAmbientTexture;

		/// <summary>
		/// The front face material texture for ambient component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialAmbientTexCoord = -1;

		/// <summary>
		/// The front face material texture for diffuse component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialDiffuseTexture;

		/// <summary>
		/// The front face material texture for diffuse component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialDiffuseTexCoord = -1;

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformStateBase derived classes.
		/// </summary>
		public static string StateId = "OpenGL.Net.MaterialState";

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
