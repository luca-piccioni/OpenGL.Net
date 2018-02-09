
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
using System.Collections.Generic;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// OpenGL.Net shadow shading model.
	/// </summary>
	public class ShadowsState : ShaderUniformStateBase
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ShadowsState()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(ShadowsState));
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ShadowsState()
		{
			
		}

		#endregion

		#region Shadows State

		/// <summary>
		/// Add a shadow map to ths state.
		/// </summary>
		/// <param name="shadowMap">
		/// The <see cref="Texture2d"/> that specifies the shadow map texture.
		/// </param>
		/// <param name="mvp">
		/// The <see cref="Matrix4x4f"/> that specifies the model-view-projection-bias matrix to transform vertex
		/// from object-space to light-space.
		/// </param>
		public void AddShadowMap(Texture2d shadowMap, Matrix4x4f mvp)
		{
			_ShadowMap2D.Add(new ShadowMap2DContext(shadowMap, mvp));
		}

		/// <summary>
		/// Shadow map based on 2D texture.
		/// </summary>
		struct ShadowMap2DContext
		{
			/// <summary>
			/// Construct a ShadowMap2DContext.
			/// </summary>
			/// <param name="shadowMap">
			/// The <see cref="Texture2d"/> that specifies the shadow map texture.
			/// </param>
			/// <param name="mvp">
			/// The <see cref="Matrix4x4f"/> that specifies the model-view-projection-bias matrix to transform vertex
			/// from object-space to light-space.
			/// </param>
			public ShadowMap2DContext(Texture2d shadowMap, Matrix4x4f mvp)
			{
				if (shadowMap == null)
					throw new ArgumentNullException("shadowMap");
				if (mvp == null)
					throw new ArgumentNullException("mvp");

				ShadowMap = shadowMap;
				ModelViewProjectionBias = mvp;
			}

			/// <summary>
			/// The shadow map backend (2D texture).
			/// </summary>
			public readonly Texture2d ShadowMap;

			/// <summary>
			/// The model-view-projection-bias matrix to transform vertex from object-space to light-space.
			/// </summary>
			public readonly Matrix4x4f ModelViewProjectionBias;
		}

		/// <summary>
		/// List of shadow maps, based on 2D texture.
		/// </summary>
		private readonly List<ShadowMap2DContext> _ShadowMap2D = new List<ShadowMap2DContext>();

		/// <summary>
		/// 
		/// </summary>
		[ShaderUniformState("glo_ShadowMap2D")]
		private Texture2d[] ShadowMap2D
		{
			get
			{
				return (_ShadowMap2D.ConvertAll(delegate(ShadowMap2DContext item) { return (item.ShadowMap); }).ToArray());
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[ShaderUniformState("glo_ShadowMap2D_MVP")]
		private Matrix4x4f[] ShadowMap2DMvp
		{
			get
			{
				return (_ShadowMap2D.ConvertAll(delegate(ShadowMap2DContext item) { return (item.ModelViewProjectionBias); }).ToArray());
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[ShaderUniformState("glo_ShadowMap2D_Count")]
		private int ShadowMap2DCount { get { return (_ShadowMap2D.Count); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformState derived classes.
		/// </summary>
		public static string StateId = "OpenGL.ShadowsState";

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
		public override bool IsContextBound { get { return (false); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public override bool IsProgramBound { get { return (true); } }

		/// <summary>
		/// Apply this TransformState.
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

			#region Shadow Map 2D (Dummy)

			// Dummy shadow map: Texture2d
			// Note: necessary to avoid undefined behavior on glo_ShadowMap2D samplers
			string resourceClassId = "OpenGL.Objects.ShadowMap.DummyTexture2d";

			Texture2d dummyShadowMap = (Texture2d)ctx.GetSharedResource(resourceClassId);

			if (dummyShadowMap == null) {
				dummyShadowMap = new Texture2d(1, 1, PixelLayout.Depth16);
				dummyShadowMap.SamplerParams.CompareMode = true;
				dummyShadowMap.SamplerParams.CompareFunc = DepthFunction.Never;
				dummyShadowMap.Create(ctx);

				ctx.SetSharedResource(resourceClassId, dummyShadowMap);
			}

			#endregion

			ctx.Bind(shaderProgram);

			shaderProgram.SetUniform(ctx, "glo_ShadowMap2D_Count", _ShadowMap2D.Count);
			for (int i = 0; i < 4; i++) {
				if (i < _ShadowMap2D.Count) {
					shaderProgram.SetUniform(ctx, "glo_ShadowMap2D_MVP[" + i + "]", _ShadowMap2D[i].ModelViewProjectionBias);
					shaderProgram.SetUniform(ctx, "glo_ShadowMap2D[" + i + "]", _ShadowMap2D[i].ShadowMap);
				} else
					shaderProgram.SetUniform(ctx, "glo_ShadowMap2D[" + i + "]", dummyShadowMap);
			}
		}

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Push()
		{
			// LXXX
			return (this);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			// Avoid merging: state is passed as reference.
			throw new InvalidOperationException();
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
