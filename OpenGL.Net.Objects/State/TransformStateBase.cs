
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
	/// State tracking the transformation state (abstract implementation).
	/// </summary>
	/// <remarks>
	/// <para>
	/// The transform state exposes a set of matrices that are dedicated of the transformation of three-dimensional
	/// points and vectors in order to project them onto the screen.
	/// </para>
	/// <para>
	/// 
	/// </para>
	/// </remarks>
	public abstract class TransformStateBase : ShaderUniformStateBase
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static TransformStateBase()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(TransformStateBase));
		}

		#endregion

		#region Local Transform State

		/// <summary>
		/// The local model matrix. Transform object-space to universe-space. This property has a lazy initialization: if
		/// not accessed, no model matrix is defined.
		/// </summary>
		public abstract IModelMatrix LocalModel { get; }

		/// <summary>
		/// Utility routine for checking the actual definition of LocalModel, without triggering the lazy initialization.
		/// </summary>
		protected abstract bool HasLocalModel { get; }

		/// <summary>
		/// The local projection: the projection matrix used for defining <see cref="LocalModelViewProjection"/>.
		/// </summary>
		public abstract IProjectionMatrix LocalProjection { get; set; }

		/// <summary>
		/// Get or set the combined model-view matrix. This property defaults to null. It must be set manually to have a
		/// meaninful value.
		/// </summary>
		public abstract IModelMatrix LocalModelView { get; set; }

		/// <summary>
		/// Get the combined model-view-projection matrix. This property has a lazy initialization: if not accessed, no
		/// model-view-projection matrix is defined. To automatically initialize this property without exception, the
		/// <see cref="LocalProjection"/> and <see cref="LocalModelView"/> must be defined. It is possible to set
		/// manually this property: doing so it will return a copy of the value.
		/// </summary>
		public abstract IModelMatrix LocalModelViewProjection { get; set; }

		#endregion

		#region Transform State

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public virtual IMatrix4x4 Projection { get { return (LocalProjection); } }

		/// <summary>
		/// The actual model matrix used for transforming vertex arrays space.
		/// </summary>
		[ShaderUniformState()]
		public virtual IModelMatrix Model { get { return (LocalModel); } }

		/// <summary>
		/// The actual model-view matrix used for transforming vertex arrays space.
		/// </summary>
		[ShaderUniformState()]
		public virtual IModelMatrix ModelView { get { return (LocalModelView); } }

		/// <summary>
		/// The actual model-view-projection matrix used for drawing vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public virtual IMatrix4x4 ModelViewProjection { get { return (LocalModelViewProjection); } }

		/// <summary>
		/// The normal matrix, derived from <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public virtual IMatrix3x3 NormalMatrix
		{
			get
			{
				return (ModelView != null ? LocalModelView.GetComplementMatrix(3, 3).GetInverseMatrix().Transpose() : null);
			}
		}

		/// <summary>
		/// Near and far distances.
		/// </summary>
		[ShaderUniformState()]
		public Vertex2f DepthDistances { get { return (LocalProjection != null ? new Vertex2f((float)LocalProjection.Near, (float)LocalProjection.Far) : new Vertex2f()); } }

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public virtual IMatrix4x4 InverseProjection { get { return (Projection != null ? Projection.GetInverseMatrix() : null); } }

		/// <summary>
		/// The inverse of <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public virtual IModelMatrix InverseModelView { get { return (ModelView != null ? ModelView.GetInverseMatrix() : null); } }

		/// <summary>
		/// The inverse of <see cref="ModelViewProjection"/>.
		/// </summary>
		[ShaderUniformState()]
		public virtual IMatrix4x4 InverseModelViewProjection { get { return (ModelViewProjection != null ? ModelViewProjection.GetInverseMatrix() : null); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the TransformStateBase derived classes.
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
		/// Apply this TransformStateBase.
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
				if (ctx.Extensions.DirectStateAccess_EXT) {
					// Set projection and model-view matrix
					Gl.MatrixLoadEXT(MatrixMode.Projection, Projection.ToArray());
					Gl.MatrixLoadEXT(MatrixMode.Modelview, ModelView.ToArray());
				} else {
					// Set projection matrix
					Gl.MatrixMode(MatrixMode.Projection);
					Gl.LoadMatrix(Projection.ToArray());
					// Set model-view matrix
					Gl.MatrixMode(MatrixMode.Modelview);
					Gl.LoadMatrix(ModelView.ToArray());
				}
#else
				throw new NotSupportedException("fixed pipeline not supported");
#endif
			} else {
				// Shader implementation (TransformState.glsl)
				ctx.Bind(shaderProgram);

				// Usual matrices
				Debug.Assert(ModelViewProjection != null, "no model-view-projection matrix");
				shaderProgram.SetUniform(ctx, "glo_ModelViewProjection", ModelViewProjection);
				if (shaderProgram.IsActiveUniform("glo_NormalMatrix"))
					shaderProgram.SetUniform(ctx, "glo_NormalMatrix", NormalMatrix);
				if (Projection != null)
					shaderProgram.SetUniform(ctx, "glo_Projection", Projection);
				if (shaderProgram.IsActiveUniform("glo_Model"))
					shaderProgram.SetUniform(ctx, "glo_Model", Model);
				if (shaderProgram.IsActiveUniform("glo_ModelView"))
					shaderProgram.SetUniform(ctx, "glo_ModelView", ModelView);

				if (shaderProgram.IsActiveUniform("glo_InverseProjection"))
					shaderProgram.SetUniform(ctx, "glo_InverseProjection", InverseProjection);
				if (shaderProgram.IsActiveUniform("glo_InverseModelView"))
					shaderProgram.SetUniform(ctx, "glo_InverseModelView", InverseModelView);
				if (shaderProgram.IsActiveUniform("glo_InverseModelViewProjection"))
					shaderProgram.SetUniform(ctx, "glo_InverseModelViewProjection", InverseModelViewProjection);

				if (Projection != null)
					shaderProgram.SetUniform(ctx, "glo_DepthDistances", DepthDistances);
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

			try {
				TransformStateBase otherState = (TransformStateBase)state;

				// Projection
				if (otherState.LocalProjection != null)
					LocalProjection = otherState.LocalProjection;
				
				if (otherState.HasLocalModel) {
					// LocalModel update
					LocalModel.Set(LocalModel.Multiply(otherState.LocalModel));
					// LocalModelView update
					if (LocalModelView != null)
						LocalModelView.Set(LocalModelView.Multiply(otherState.LocalModel));
					else if (otherState.LocalModelView != null)
						LocalModelView = otherState.LocalModelView;
					// LocalModelViewProjection update
					LocalModelViewProjection.Set(LocalModelViewProjection.Multiply(otherState.LocalModel));
				}
			} catch (InvalidCastException) {
				throw new ArgumentException("not a TransformStateBase", "state");
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
			return (String.Empty);
		}

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
