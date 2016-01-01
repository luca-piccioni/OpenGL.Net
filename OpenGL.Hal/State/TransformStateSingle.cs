
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
using System.Diagnostics;

namespace OpenGL.State
{
	/// <summary>
	/// State tracking the transformation state (single-precision implementation).
	/// </summary>
	[DebuggerDisplay("TransformStateSingle View={View} Transform={TransformModel} ModelView={ModelView} LocalModel={LocalModel}")]
	public class TransformStateSingle : TransformStateBase
	{
		#region Constructors

		/// <summary>
		/// Default TransformStateSingle.
		/// </summary>
		public TransformStateSingle()
		{

		}

		/// <summary>
		/// Construct the current TransformStateSingle (compatibility profile only).
		/// </summary>
		public TransformStateSingle(GraphicsContext ctx)
		{

		}

		#endregion

		#region Transform State
		
		/// <summary>
		/// The matrix used for viewing the universe. It can be null.
		/// </summary>
		public override IModelMatrix View
		{
			get { return (mViewMatrix); }
			internal set { mViewMatrix = new ModelMatrix((Matrix4x4)value); }
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
				IModelMatrix localModel = new ModelMatrix(mLocalModel);

				return (localModel);
			}
		}
		
		/// <summary>
		/// The final model of this state, that is <see cref="View"/> multiplied with <see cref="TransformModel"/>.
		/// </summary>
		public override IModelMatrix ModelView
		{
			get
			{
				return (View != null ? View.Multiply(TransformModel) : TransformModel);
			}
		}
		
		/// <summary>
		/// The matrix used for viewing the universe.
		/// </summary>
		/// <remarks>
		/// This is meant as the transform state only of the "camera" model, indeed the inverse of the camera node.
		/// </remarks>
		private ModelMatrix mViewMatrix;
		
		/// <summary>
		/// The local model of this state.
		/// </summary>
		private ModelMatrix mLocalModel = new ModelMatrix();

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for TransformState.
		/// </summary>
		public static TransformStateSingle DefaultState { get { return (new TransformStateSingle()); } }

		#endregion

		#region ShaderUniformState Overrides

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="RenderState.StateIdentifier"/> of this state.
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
			if (transformState.View != null)
				mViewMatrix = (ModelMatrix)transformState.View;
			// Update world model (do not copy Transforms: embed in LocalModel)
			mLocalModel.Set(TransformModel.Multiply(stateModel));
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="RenderState"/> to compare to this RenderState.
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
			Debug.Assert(other is TransformStateSingle);

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
			TransformStateSingle copiedState = new TransformStateSingle();		// Do not use base.Copy()!
			
			// Copy View
			if (mViewMatrix != null)
				copiedState.mViewMatrix = new ModelMatrix(mViewMatrix);
			// Copy LocalModel
			copiedState.mLocalModel = new ModelMatrix(mLocalModel);

			return (copiedState);
		}

		#endregion
	}
}
