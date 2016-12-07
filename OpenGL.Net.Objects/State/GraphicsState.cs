
// Copyright (C) 2009-2016 Luca Piccioni
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
	/// Generic render state.
	/// </summary>
	[DebuggerDisplay("GraphicsState: Id={StateIdentifier} Inheritable={Inheritable}")]
	public abstract class GraphicsState : UserGraphicsResource, IGraphicsState
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsState.
		/// </summary>
		protected GraphicsState()
		{

		}

		/// <summary>
		/// Construct a GraphicsState, specifying whether it is inheritable.
		/// </summary>
		/// <param name="inheritable"></param>
		protected GraphicsState(bool inheritable)
		{
			// Inheritable flag
			_Inheritable = inheritable;
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Compare two GraphicsState for equality
		/// </summary>
		/// <param name="state1">
		/// A <see cref="GraphicsState"/> to compare with <paramref name="state2"/>.
		/// </param>
		/// <param name="state2">
		/// A <see cref="GraphicsState"/> to compare with <paramref name="state1"/>.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="state1"/> equals to <paramref name="state2"/>, otherwise false.
		/// </returns>
		public static bool operator==(GraphicsState state1, GraphicsState state2)
		{
			return (Equals(state1, state2));
		}

		/// <summary>
		/// Compare two GraphicsState for equality
		/// </summary>
		/// <param name="state1">
		/// A <see cref="GraphicsState"/> to compare with <paramref name="state2"/>.
		/// </param>
		/// <param name="state2">
		/// A <see cref="GraphicsState"/> to compare with <paramref name="state1"/>.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="state1"/> equals to <paramref name="state2"/>, otherwise false.
		/// </returns>
		public static bool operator!=(GraphicsState state1, GraphicsState state2)
		{
			return (!Equals(state1, state2));
		}

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);

			if (obj.GetType().IsSubclassOf(typeof(GraphicsState)) == false)
				return (false);

			return Equals((GraphicsState) obj);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			return (StateIdentifier.GetHashCode());
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (StateIdentifier);
		}

		#endregion

		#region IGraphicsState Implementation

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public abstract string StateIdentifier { get; }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		public virtual bool IsContextBound { get { return (true); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public virtual bool IsShaderProgramBound { get { return (false); } }

		/// <summary>
		/// Apply the render state define by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used in conjuction with <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> holding the uniform state.
		/// </param>
		public abstract void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram);

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
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
		public abstract void Merge(IGraphicsState state);

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
		public virtual bool Equals(IGraphicsState other)
		{
			if (other == null)
				throw new ArgumentNullException("other");

			return (other.StateIdentifier == StateIdentifier);
		}

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public virtual IGraphicsState Copy()
		{
			GraphicsState copiedState = (GraphicsState)MemberwiseClone();

			// New copy shall have a reference count of 0
			copiedState.ResetRefCount();

			return (copiedState);
		}

		/// <summary>
		/// Flag indicating whether this state is inheritable.
		/// </summary>
		private bool _Inheritable = true;

		#endregion
	}
}
