
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
using System.Collections.Generic;

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
		#region Transform State
		
		/// <summary>
		/// The matrix used for viewing the universe. It can be null in the case the information
		/// is not required; in this case it is included in <see cref="ModelView"/>.
		/// </summary>
		public abstract IModelMatrix View { get; internal set; }

		/// <summary>
		/// The local model.
		/// </summary>
		public abstract IModelMatrix LocalModel { get; }

		/// <summary>
		/// The final model of this state, that is <see cref="LocalModel"/> multiplied with each <see cref="IModelTransform"/>
		/// collected by <see cref="Transforms"/>.
		/// </summary>
		public abstract IModelMatrix TransformModel { get; }
		
		/// <summary>
		/// The final model of this state, that is <see cref="View"/> multiplied with <see cref="TransformModel"/>.
		/// </summary>
		public abstract IModelMatrix ModelView { get; }

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
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("{0}: View=[{1}] TransformModel=[{2}] ModelView=[{3}] {4}", StateIdentifier, View != null ? View.ToString() : "null", TransformModel, ModelView, GetType().Name));
		}
		
		#endregion
	}
}
