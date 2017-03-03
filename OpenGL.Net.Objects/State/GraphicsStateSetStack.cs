
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// A stack of <see cref="GraphicsStateSet"/>.
	/// </summary>
	public class GraphicsStateSetStack
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsStateSetStack.
		/// </summary>
		public GraphicsStateSetStack()
		{
			GraphicsStateSet defaultSet = GraphicsStateSet.GetDefaultSet();

			// The stack always defines a current state
			_StateSetStack.AddLast(defaultSet);
		}

		/// <summary>
		/// Construct a GraphicsStateSetStack representing the current state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to query the state.
		/// </param>
		public GraphicsStateSetStack(GraphicsContext ctx)
		{
			GraphicsStateSet defaultSet = GraphicsStateSet.GetCurrentStateSet(ctx);

			// The stack always defines a current state
			_StateSetStack.AddLast(defaultSet);
		}

		#endregion

		#region Current State Set

		/// <summary>
		/// Get the current <see cref="GraphicsStateSet"/> on top of this stack.
		/// </summary>
		public GraphicsStateSet Current
		{
			get
			{
				return (_StateSetStack.Last.Value);
			}
		}

		#endregion

		#region Stack Implementation

		/// <summary>
		/// Push a copy of the current state set onto the stack.
		/// </summary>
		public void Push()
		{
			GraphicsStateSet currentStateSetCopy = Current.Push();

			// Set the copy as the current state set
			_StateSetStack.AddLast(currentStateSetCopy);
		}

		/// <summary>
		/// Push a copy of the current state set onto the stack.
		/// </summary>
		/// <param name="mergedState">
		/// A <see cref="GraphicsStateSet"/> to be merged on current render state set after having pushed it
		/// onto the stack.
		/// </param>
		public void Push(GraphicsStateSet mergedState)
		{
			if (mergedState == null)
				throw new ArgumentNullException("mergedState");

			// Push the current state onto the stack
			Push();
			// Merge current state with the specified one
			Current.Merge(mergedState);
		}

		/// <summary>
		/// Pop the current state on top of the stack.
		/// </summary>
		public void Pop()
		{
			if (_StateSetStack.Count == 1)
				throw new InvalidOperationException("stack underflow");

			GraphicsStateSet currentStateSet = Current;

			// Restore previous state set
			_StateSetStack.RemoveLast();
		}

		/// <summary>
		/// Remove every element on this stack.
		/// </summary>
		public void Clear()
		{
			// Remove every state set included on the stack, except the first one
			while (_StateSetStack.Count > 1) {
				_StateSetStack.RemoveLast();
			}
		}

		/// <summary>
		/// The GraphicsStateSet stack.
		/// </summary>
		private readonly LinkedList<GraphicsStateSet> _StateSetStack = new LinkedList<GraphicsStateSet>();

		#endregion
	}
}
