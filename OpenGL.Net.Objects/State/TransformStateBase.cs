
// Copyright (C) 2012-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// State tracking the transformation state.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The transform state exposes a set of matrices that are dedicated of the transformation of three-dimensional
	/// points and vectors in order to project them onto the screen:
	/// - Projection
	/// - Model-view
	/// - Normal
	/// </para>
	/// </remarks>
	[DebuggerDisplay("TransformState: Projection={Projection} ModelView={ModelView}")]
	public class TransformState : ShaderUniformStateBase
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static TransformState()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(TransformState));
		}

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for PixelAlignmentState.
		/// </summary>
		public static TransformState DefaultState { get { return (new TransformState()); } }

		#endregion

		#region Transform State

		/// <summary>
		/// The actual model-view matrix used for transforming vertex arrays space.
		/// </summary>
		[ShaderUniformState]
		public Matrix4x4f? Projection { get; set; }

		/// <summary>
		/// The actual model-view matrix used for transforming vertex arrays space.
		/// </summary>
		[ShaderUniformState]
		public Matrix4x4f ModelView { get; set; } = Matrix4x4f.Identity;

		/// <summary>
		/// The actual model-view-projection matrix used for drawing vertex arrays.
		/// </summary>
		[ShaderUniformState]
		public Matrix4x4f? ModelViewProjection
		{
			get
			{
				if (!_ModelViewProjection.HasValue && Projection.HasValue)
					return Projection.Value * ModelView;		// Lazily computed
				
				return _ModelViewProjection;
			}
			set { _ModelViewProjection = value; }
		}

		/// <summary>
		/// Backend value for ModelViewProjection.
		/// </summary>
		private Matrix4x4f? _ModelViewProjection;

		/// <summary>
		/// The normal matrix, derived from <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState]
		public Matrix3x3f NormalMatrix { get { return (new Matrix3x3f(ModelView, 3, 3).Inverse.Transposed); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformState derived classes.
		/// </summary>
		public static string StateId = "OpenGL.TransformState";

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
		private static readonly int _StateIndex = NextStateIndex();

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

			if (shaderProgram == null) {

				// Fixed pipeline rendering requires server state
				
#if !MONODROID
				Matrix4x4f p = Projection ?? Matrix4x4f.Identity;

				if (ctx.Extensions.DirectStateAccess_EXT) {
					// Set projection and model-view matrix
					Gl.MatrixLoadfEXT(MatrixMode.Projection, p);
					Gl.MatrixLoadfEXT(MatrixMode.Modelview, ModelView);
				} else {
					// Set projection matrix
					Gl.MatrixMode(MatrixMode.Projection);
					Gl.LoadMatrixf(p);
					// Set model-view matrix
					Gl.MatrixMode(MatrixMode.Modelview);
					Gl.LoadMatrixf(ModelView);
				}
#else
				throw new NotSupportedException("fixed pipeline not supported");
#endif
			} else {
				// Shader implementation (TransformState.glsl)
				ctx.Bind(shaderProgram);

				// Usual matrices
				Debug.Assert(ModelViewProjection.HasValue);
				if (ModelViewProjection.HasValue)
					shaderProgram.SetUniform(ctx, "glo_ModelViewProjection", ModelViewProjection.Value);

				if (shaderProgram.IsActiveUniform("glo_NormalMatrix"))
					shaderProgram.SetUniform(ctx, "glo_NormalMatrix", NormalMatrix);

				if (shaderProgram.IsActiveUniform("glo_ModelView"))
					shaderProgram.SetUniform(ctx, "glo_ModelView", ModelView);
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
				throw new ArgumentNullException(nameof(state));

			try {
				TransformState otherState = (TransformState)state;

				if (otherState.Projection.HasValue)
					Projection = otherState.Projection.Value;
				ModelView = ModelView * otherState.ModelView;
				if (_ModelViewProjection.HasValue && !otherState.Projection.HasValue)
					_ModelViewProjection = _ModelViewProjection.Value * otherState.ModelView;
				else
					_ModelViewProjection = otherState.ModelViewProjection.Value;
				Debug.Assert(_ModelViewProjection.HasValue);
				Debug.Assert(_ModelViewProjection.Value.Equals((Matrix4x4f)(Projection * ModelView), 1e-3f));
			} catch (InvalidCastException) {
				throw new ArgumentException("not a TransformState", nameof(state));
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
			return (string.Empty);
		}

		/// <summary>
		/// The uniform state of this TransformState.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
