
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Generic render state.
	/// </summary>
	[DebuggerDisplay("GraphicsState: Id={StateIdentifier}")]
	public abstract class GraphicsState : IGraphicsState
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

		#region State Index

		/// <summary>
		/// Get the next state index.
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		protected static int NextStateIndex()
		{
			return (_StateIndex++);
		}

		/// <summary>
		/// Get the total number of <see cref="IGraphicsState"/> implementations.
		/// </summary>
		/// <returns></returns>
		protected internal static int GetStateCount() { return (_StateIndex); }

		/// <summary>
		/// The current state index for GraphicsState.
		/// </summary>
		private static int _StateIndex;

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

		#region Object Overrides

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

			try {
				return Equals((GraphicsState)obj);
			} catch (InvalidCastException) {
				return (false);
			}
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
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public abstract int StateIndex { get; }

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		public virtual bool IsContextBound { get { return (true); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public virtual bool IsProgramBound { get { return (false); } }

		/// <summary>
		/// Create or update resources defined by this IGraphicsState, based on the associated <see cref="ShaderProgram"/>.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> that will be used in conjunction with this IGraphicsState.
		/// </param>
		public virtual void Create(GraphicsContext ctx, ShaderProgram shaderProgram)
		{

		}

		/// <summary>
		/// Dispose resources allocated by <see cref="Create(GraphicsContext, ShaderProgram)"/>.
		/// </summary>
		public virtual void Delete()
		{

		}

		/// <summary>
		/// Apply the render state define by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used in conjuction with <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> holding the uniform state.
		/// </param>
		public abstract void Apply(GraphicsContext ctx, ShaderProgram shaderProgram);

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public virtual IGraphicsState Push()
		{
			return ((GraphicsState)MemberwiseClone());
		}

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

			return (other.StateIndex == StateIndex);
		}

		/// <summary>
		/// Flag indicating whether this state is inheritable.
		/// </summary>
		private bool _Inheritable = true;

		#endregion
	}
}
