
// Copyright (C) 2012-2017 Luca Piccioni
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
