
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
		/// The local projection: the projection matrix of the current verte arrays, without considering inherited
		/// transform states of parent objects. It can be null to specify whether the projection is inherited from the
		/// previous state.
		/// </summary>
		public override IMatrix4x4 LocalProjection
		{
			get { return (_LocalProjection); }
			set
			{
				if (value != null)
					_LocalProjection = new Matrix4x4(value);
				else
					_LocalProjection = null;        // Inherited projection matrix
			}
		}

		/// <summary>
		/// The local model: the transformation of the current vertex arrays object space, without considering
		/// inherited transform states of parent objects.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (_LocalModel); } }

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private MatrixDouble4x4 _LocalProjection;

		/// <summary>
		/// The local model of this state.
		/// </summary>
		private readonly ModelMatrixDouble _LocalModel = new ModelMatrixDouble();

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public override IMatrix4x4 Projection { get { return (null); } internal set { } }

		/// <summary>
		/// The actual projection matrix used for projecting vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public override IMatrix4x4 InverseProjection { get { return (null); } }

		/// <summary>
		/// The actual model-view matrix used for transforming vertex arrays object space.
		/// </summary>
		[ShaderUniformState()]
		public override IModelMatrix ModelView { get { return (null); } internal set { } }

		/// <summary>
		/// The actual model-view-projection matrix used for drawing vertex arrays.
		/// </summary>
		[ShaderUniformState()]
		public override IModelMatrix ModelViewProjection { get { return (null); } internal set { } }

		/// <summary>
		/// The inverse of <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public override IModelMatrix InverseModelView { get { return (null); } }

		/// <summary>
		/// The inverse of <see cref="ModelViewProjection"/>.
		/// </summary>
		[ShaderUniformState()]
		public override IModelMatrix InverseModelViewProjection { get { return (null); } }

		/// <summary>
		/// The normal matrix, derived from <see cref="ModelView"/>.
		/// </summary>
		[ShaderUniformState()]
		public override IModelMatrix NormalMatrix { get { return (null); } }

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

#if false
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
#endif
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

			return (copiedState);
		}
		
#endregion
	}
}
