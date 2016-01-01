
// Copyright (C) 2013-2015 Luca Piccioni
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
	/// State tracking the transformation state (double-precision implementation).
	/// </summary>
	[DebuggerDisplay("TransformStateDouble View={View} Transform={TransformModel} ModelView={ModelView} LocalModel={LocalModel}")]
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

		#region Transform State
		
		/// <summary>
		/// The matrix used for viewing the universe.
		/// </summary>
		public override IModelMatrix View
		{
			get { return (mViewMatrix); }
			internal set { mViewMatrix = new ModelMatrixDouble(value); }
		}

		/// <summary>
		/// The local model of this state.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (mLocalModel); } }

		/// <summary>
		/// The final model of this state, that is <see cref="LocalModel"/> multiplied with each <see cref="IModelTransform"/>
		/// collected by <see cref="TransformStateBase.Transforms"/>.
		/// </summary>
		public override IModelMatrix TransformModel
		{
			get
			{
				// Initial model is the stored one
				IModelMatrix localModel = new ModelMatrixDouble(mLocalModel);

				return (localModel);
			}
		}
		
		/// <summary>
		/// The final model of this state, that is <see cref="View"/> multiplied with <see cref="TransformModel"/>.
		/// </summary>
		public override IModelMatrix ModelView { get { return (mModelView); } }
		
		/// <summary>
		/// The matrix used for viewing the universe.
		/// </summary>
		/// <remarks>
		/// This is meant as the transform state only of the "camera" model, indeed the inverse of the camera node.
		/// </remarks>
		internal ModelMatrixDouble mViewMatrix;
		
		/// <summary>
		/// The local model of this state.
		/// </summary>
		protected ModelMatrixDouble mLocalModel = new ModelMatrixDouble();
		
		/// <summary>
		/// The final model of this state, that is <see cref="View"/> multiplied with <see cref="TransformModel"/>.
		/// </summary>
		private ModelMatrixDouble mModelView = new ModelMatrix();

		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for TransformStateDouble.
		/// </summary>
		public static TransformStateDouble DefaultState { get { return (new TransformStateDouble()); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="GraphicsState.StateIdentifier"/> of this state.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a call to this routine, this IGraphicsState store the union of the previous information
		/// and of the information of <paramref name="state"/>.
		/// </para>
		/// <para>
		/// The semantic of the merge result is dependent on the actual implementation of this IGraphicsState. Normally
		/// the merge method will copy <paramref name="state"/> into this IGraphicsState, but other state could do
		/// different operations.
		/// </para>
		/// </remarks>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");
			if (state.StateIdentifier != StateId)
				throw new ArgumentException("state id mismatch", "state");

			TransformStateBase transformState = (TransformStateBase)state;
			IModelMatrix stateModel = transformState.TransformModel;
			
			// Inherith view matrix, if any (usually it is null)
			if (transformState.View != null) {
				mViewMatrix = (ModelMatrixDouble)transformState.View;
				mModelView.Set(stateModel.Multiply(transformState.ModelView));
			} else
				mModelView.Set(mModelView.Multiply(stateModel));
			// Update world model (do not copy Transforms: embed in LocalModel)
			mLocalModel.Set(TransformModel.Multiply(stateModel));
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="GraphicsState"/> to compare to this GraphicsState.
		/// </param>
		/// <returns>
		/// It returns true if the current object is equal to <paramref name="other"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method test only whether <paramref name="other"/> type equals to this type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="other"/> is null.
		/// </exception>
		public override bool Equals(IGraphicsState other)
		{
			if (base.Equals(other) == false)
				return (false);
			Debug.Assert(other is TransformStateDouble);

			return (false);
		}

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Copy()
		{
			TransformStateDouble copiedState = new TransformStateDouble();		// Do not use base.Copy()!
			
			// Copy View
			if (mViewMatrix != null)
				copiedState.mViewMatrix = new ModelMatrixDouble(mViewMatrix);
			// Copy LocalModel
			copiedState.mLocalModel = new ModelMatrixDouble(mLocalModel);

			return (copiedState);
		}
		
		#endregion
	}
}
