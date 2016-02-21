
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
using System.Diagnostics;

namespace OpenGL.State
{
	/// <summary>
	/// State tracking the transformation state (single-precision implementation).
	/// </summary>
	[DebuggerDisplay("TransformState LocalModel={LocalModel} LocalProjection={LocalProjection} LocalModel={LocalModel}")]
	public class TransformState : TransformStateBase
	{
		#region Constructors

		/// <summary>
		/// Default TransformStateSingle.
		/// </summary>
		public TransformState()
		{

		}

		/// <summary>
		/// Construct the current TransformStateSingle (compatibility profile only).
		/// </summary>
		public TransformState(GraphicsContext ctx)
		{

		}

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for TransformState.
		/// </summary>
		public static TransformState DefaultState { get { return (new TransformState()); } }

		#endregion

		#region TransformStateBase Overrides

		/// <summary>
		/// The local projection: the projection matrix of the current verte arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public override IProjectionMatrix LocalProjection
		{
			get { return (_LocalProjection); }
			set
			{
				if (value != null) {
					ProjectionMatrix projectionMatrix = value.Clone() as ProjectionMatrix;
					if (projectionMatrix == null)
						throw new InvalidOperationException("value is not ProjectionMatrix");
					_LocalProjection = projectionMatrix;
				} else
					_LocalProjection = null;		// Inherited projection matrix
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ProjectionMatrix _LocalProjection;

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (_LocalModel); } }

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModel = new ModelMatrix();

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Copy()
		{
			TransformState copiedState = (TransformState)base.Copy();

			if (_LocalProjection != null)
				copiedState._LocalProjection = (ProjectionMatrix)_LocalProjection.Clone();
			copiedState._LocalModel = new ModelMatrix(_LocalModel);

			return (copiedState);
		}

		#endregion
	}
}
