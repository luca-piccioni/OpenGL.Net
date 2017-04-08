
// Copyright (C) 2013-2016 Luca Piccioni
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
	/// State tracking the transformation state (double-precision implementation).
	/// </summary>
	[DebuggerDisplay("TransformStateDouble: View={View} Transform={TransformModel} ModelView={ModelView} LocalModel={LocalModel}")]
	public class TransformStateDouble : TransformStateBase
	{
		#region Constructors

		/// <summary>
		/// Default TransformStateDouble.
		/// </summary>
		public TransformStateDouble()
		{

		}

		/// <summary>
		/// Construct the current TransformStateDouble (compatibility profile only).
		/// </summary>
		public TransformStateDouble(GraphicsContext ctx)
		{

		}

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for TransformStateDouble.
		/// </summary>
		public static TransformStateDouble DefaultState { get { return (new TransformStateDouble()); } }

		#endregion

		#region TransformStateBase Overrides

		/// <summary>
		/// The local model matrix. Transform object-space to universe-space. This property has a lazy initialization: if
		/// not accessed, no model matrix is defined.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (_LocalModel ?? (_LocalModel = new ModelMatrixDouble())); } }

		/// <summary>
		/// Utility routine for checking the actual definition of LocalModel, without triggering the lazy initialization.
		/// </summary>
		protected override bool HasLocalModel { get { return (_LocalModel != null); } }

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrixDouble _LocalModel;

		/// <summary>
		/// The local projection: the projection matrix used for defining <see cref="LocalModelViewProjection"/>.
		/// </summary>
		public override IProjectionMatrix LocalProjection
		{
			get { return (_LocalProjection); }
			set
			{
				if (value != null) {
					ProjectionMatrixDouble projectionMatrix = value.Clone() as ProjectionMatrixDouble;
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
		private ProjectionMatrixDouble _LocalProjection;

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
		private ModelMatrixDouble _LocalModelView;

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
					return (_LocalModelViewProjection = (ModelMatrixDouble)_LocalProjection.Multiply(_LocalModelView));
				} else
					return (_LocalModelViewProjection);
			}
			set
			{
				if (value != null) {
					ModelMatrixDouble modelviewprojMatrix = value.Clone() as ModelMatrixDouble;
					if (modelviewprojMatrix == null)
						throw new InvalidOperationException("value is not ModelMatrixDouble");
					_LocalModelViewProjection = modelviewprojMatrix;
				} else
					_LocalModelViewProjection = null;
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ModelMatrixDouble _LocalModelViewProjection;

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Push()
		{
			TransformStateDouble copiedState = (TransformStateDouble)base.Push();

			if (_LocalProjection != null)
				copiedState._LocalProjection = (ProjectionMatrixDouble)_LocalProjection.Clone();
			copiedState._LocalModel = new ModelMatrixDouble(_LocalModel);

			return (copiedState);
		}

		#endregion
	}
}
