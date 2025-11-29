
// Copyright (C) 2016-2017 Luca Piccioni
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
				Shininess = 32.0f;
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

			/// <summary>
			/// Apply this MaterialState
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
			/// </param>
			/// <param name="shaderProgram">
			/// The <see cref="ShaderProgram"/> which has the state set.
			/// </param>
			public void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram, string prefix)
			{
				shaderProgram.SetUniform(ctx, prefix + ".AmbientColor", Ambient);
				shaderProgram.SetUniform(ctx, prefix + ".EmissiveColor", Emissive);
				shaderProgram.SetUniform(ctx, prefix + ".DiffuseColor", Diffuse);
				shaderProgram.SetUniform(ctx, prefix + ".SpecularColor", Specular);
				shaderProgram.SetUniform(ctx, prefix + ".Shininess", Shininess);
			}
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
		public Texture2d FrontMaterialEmissionTexture
		{
			get { return (_FrontMaterialEmissionTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialEmissionTexture); }
		}

		/// <summary>
		/// The front face material texture for emission component, if any.
		/// </summary>
		private Texture2d _FrontMaterialEmissionTexture;

		/// <summary>
		/// The front face material texture for emission component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialEmissionTexCoord = -1;

		/// <summary>
		/// The front face material texture for diffuse component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialDiffuseTexture
		{
			get { return (_FrontMaterialDiffuseTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialDiffuseTexture); }
		}

		/// <summary>
		/// The front face material texture for diffuse component, if any.
		/// </summary>
		private Texture2d _FrontMaterialDiffuseTexture;

		/// <summary>
		/// The front face material texture for diffuse component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialDiffuseTexCoord = -1;

		/// <summary>
		/// The front face material texture for normal component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialNormalTexture
		{
			get { return (_FrontMaterialNormalTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialNormalTexture); }
		}

		/// <summary>
		/// The front face material texture for normal component, if any.
		/// </summary>
		private Texture2d _FrontMaterialNormalTexture;

		/// <summary>
		/// The front face material texture for normal component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialNormalTexCoord = -1;

		/// <summary>
		/// The front face material texture for specular component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialSpecularTexture
		{
			get { return (_FrontMaterialSpecularTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialSpecularTexture); }
		}

		/// <summary>
		/// The front face material texture for specular component, if any.
		/// </summary>
		private Texture2d _FrontMaterialSpecularTexture;

		/// <summary>
		/// The front face material texture for specular component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialSpecularTexCoord = -1;

		/// <summary>
		/// The front face material texture for ambient component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialAmbientTexture
		{
			get { return (_FrontMaterialAmbientTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialAmbientTexture); }
		}

		/// <summary>
		/// The front face material texture for ambient component, if any.
		/// </summary>
		private Texture2d _FrontMaterialAmbientTexture;

		/// <summary>
		/// The front face material texture for ambient component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialAmbientTexCoord = -1;

		/// <summary>
		/// The front face material texture for displacement component, if any.
		/// </summary>
		[ShaderUniformState()]
		public Texture2d FrontMaterialDisplacementTexture
		{
			get { return (_FrontMaterialDisplacementTexture); }
			set { GraphicsResource.Swap(value, ref _FrontMaterialDisplacementTexture); }
		}

		/// <summary>
		/// The front face material texture for displacement component, if any.
		/// </summary>
		private Texture2d _FrontMaterialDisplacementTexture;

		/// <summary>
		/// The front face material texture for displacement component, if any.
		/// </summary>
		[ShaderUniformState()]
		public int FrontMaterialDisplacementTexCoord = -1;

		/// <summary>
		/// The front face material texture for displacement component, if any.
		/// </summary>
		[ShaderUniformState()]
		public float FrontMaterialDisplacementFactor = 1.0f;

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformState derived classes.
		/// </summary>
		public static string StateId = "OpenGL.MaterialState";

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
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always true, since it supports also fixed pipeline.
		/// </remarks>
		public override bool IsContextBound { get { return (true); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public override bool IsProgramBound { get { return (true); } }

		/// <summary>
		/// Dispose resources allocated by <see cref="Create(GraphicsContext, ShaderProgram)"/>.
		/// </summary>
		public override void Delete()
		{
			FrontMaterialEmissionTexture = null;
			FrontMaterialDiffuseTexture = null;
			FrontMaterialNormalTexture = null;
			FrontMaterialSpecularTexture = null;
			FrontMaterialAmbientTexture = null;
			FrontMaterialDisplacementTexture = null;
		}

		/// <summary>
		/// Apply this MaterialState
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void Apply(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			GraphicsResource.CheckCurrentContext(ctx);

			if (shaderProgram == null) {
				// Fixed pipeline rendering requires server state
				throw new NotImplementedException();
			} else {
				// Custom implementation
				ctx.Bind(shaderProgram);

				FrontMaterial.ApplyState(ctx, shaderProgram, "glo_FrontMaterial");

				if (FrontMaterialEmissionTexture != null)
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialEmissionTexture", FrontMaterialEmissionTexture);
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialEmissionTexCoord", FrontMaterialEmissionTexCoord);

				if (FrontMaterialDiffuseTexture != null)
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialDiffuseTexture", FrontMaterialDiffuseTexture);
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialDiffuseTexCoord", FrontMaterialDiffuseTexCoord);

				if (FrontMaterialNormalTexture != null)
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialNormalTexture", FrontMaterialNormalTexture);
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialNormalTexCoord", FrontMaterialNormalTexCoord);

				if (FrontMaterialSpecularTexture != null)
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialSpecularTexture", FrontMaterialSpecularTexture);
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialSpecularTexCoord", FrontMaterialSpecularTexCoord);

				if (FrontMaterialAmbientTexture != null)
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialAmbientTexture", FrontMaterialAmbientTexture);
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialAmbientTexCoord", FrontMaterialAmbientTexCoord);

				if (FrontMaterialDisplacementTexture != null) {
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialDisplacementTexture", FrontMaterialDisplacementTexture);
					shaderProgram.SetUniform(ctx, "glo_FrontMaterialDisplacementFactor", FrontMaterialDisplacementFactor);
				}
				shaderProgram.SetUniform(ctx, "glo_FrontMaterialDisplacementTexCoord", FrontMaterialDisplacementTexCoord);
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

			TransformState otherState = state as TransformState;

			if (otherState == null)
				throw new ArgumentException("not a TransformState", "state");
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
		/// The uniform state of this TransformState.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
