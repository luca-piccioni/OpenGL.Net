
// Copyright (C) 2012-2017 Luca Piccioni
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

namespace OpenGL.Objects.State
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
		/// The local model matrix. Transform object-space to universe-space. This property has a lazy initialization: if
		/// not accessed, no model matrix is defined.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (_LocalModel ?? (_LocalModel = new ModelMatrix())); } }

		/// <summary>
		/// Utility routine for checking the actual definition of LocalModel, without triggering the lazy initialization.
		/// </summary>
		protected override bool HasLocalModel { get { return (_LocalModel != null); } }

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModel;

		/// <summary>
		/// The local projection: the projection matrix used for defining <see cref="LocalModelViewProjection"/>.
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
					_LocalProjection = null;
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ProjectionMatrix _LocalProjection;

		/// <summary>
		/// Get or set the combined model-view matrix. This property defaults to null. It must be set manually to have a
		/// meaninful value.
		/// </summary>
		public override IModelMatrix LocalModelView
		{
			get { return (_LocalModelView); }
			set
			{
				if (value != null) {
					ModelMatrix modelviewMatrix = value.Clone() as ModelMatrix;
					if (modelviewMatrix == null)
						throw new InvalidOperationException("value is not ModelMatrix");
					_LocalModelView = modelviewMatrix;
				} else
					_LocalModelView = null;
			}
		}

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModelView;

		/// <summary>
		/// Get the combined model-view-projection matrix. This property has a lazy initialization: if not accessed, no
		/// model-view-projection matrix is defined. To automatically initialize this property without exception, the
		/// <see cref="LocalProjection"/> and <see cref="LocalModelView"/> must be defined. It is possible to set
		/// manually this property: doing so it will return a copy of the value.
		/// </summary>
		public override IModelMatrix LocalModelViewProjection
		{
			get
			{
				if (_LocalModelViewProjection == null) {
					if (_LocalModelView == null || _LocalProjection == null)
						throw new InvalidOperationException("unable to compute LocalModelViewProjection");
					return (_LocalModelViewProjection = new ModelMatrix(_LocalProjection * _LocalModelView));
				} else
					return (_LocalModelViewProjection);
			}
			set
			{
				if (value != null) {
					ModelMatrix modelviewprojMatrix = value.Clone() as ModelMatrix;
					if (modelviewprojMatrix == null)
						throw new InvalidOperationException("value is not ModelMatrix");
					_LocalModelViewProjection = modelviewprojMatrix;
				} else
					_LocalModelViewProjection = null;
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModelViewProjection;

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Push()
		{
			TransformState copiedState = (TransformState)base.Push();

			if (_LocalProjection != null)
				copiedState._LocalProjection = (ProjectionMatrix)_LocalProjection.Clone();
			if (_LocalModel != null)
				copiedState._LocalModel = new ModelMatrix(_LocalModel);
			if (_LocalModelView != null)
				copiedState._LocalModelView = new ModelMatrix(_LocalModelView);
			if (_LocalModelViewProjection != null)
				copiedState._LocalModelViewProjection = new ModelMatrix(_LocalModelViewProjection);

			return (copiedState);
		}

		#endregion
	}
}
