
// Copyright (C) 2012-2016 Luca Piccioni
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
using System.Reflection;

namespace OpenGL.State
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
	public abstract class TransformStateBase : ShaderUniformState
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
		/// The local projection: the projection matrix of the current verte arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public abstract IMatrix4x4 LocalProjection { get; set; }

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public abstract IModelMatrix LocalModel { get; }

		#endregion

		#region Transform State

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public abstract IMatrix4x4 Projection { get; internal set; }

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public abstract IMatrix4x4 InverseProjection { get; }

		/// <summary>
		/// The actual model-view matrix used for transforming vertex arrays object space.
		/// </summary>
		[ShaderUniformState()]
		public abstract IModelMatrix ModelView { get; internal set; }

		/// <summary>
		/// The actual model-view-projection matrix used for drawing vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public abstract IModelMatrix ModelViewProjection { get; internal set; }

		/// <summary>
		/// The inverse of <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public abstract IModelMatrix InverseModelView { get; }

		/// <summary>
		/// The inverse of <see cref="ModelViewProjection"/>.
		/// </summary>
		[ShaderUniformState()]
		public abstract IModelMatrix InverseModelViewProjection { get; }

		/// <summary>
		/// The normal matrix, derived from <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public abstract IModelMatrix NormalMatrix { get; }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.TransformState";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

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
			if (shaderProgram == null) {

				// Fixed pipeline rendering requires server state

				// Set projection matrix
				Gl.MatrixMode(MatrixMode.Projection);
				Gl.LoadMatrix(Projection.ToArray());
				// Set model-view matrix
				Gl.MatrixMode(MatrixMode.Modelview);
				Gl.LoadMatrix(ModelView.ToArray());
				
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
			return (String.Empty);
		}

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
