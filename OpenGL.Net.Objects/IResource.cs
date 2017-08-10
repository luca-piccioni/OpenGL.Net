
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

namespace OpenGL.Objects
{
	/// <summary>
	/// A shared resource.
	/// </summary>
	public interface IResource : IDisposable
	{
		#region Resource Sharing

		/// <summary>
		/// Number of shared instances of this IResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances. In this way, typical IDisposable
		/// implementation wouldn't throw exception because the resource is referenced.
		/// </remarks>
		uint RefCount { get; }

		/// <summary>
		/// Increment the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the IResource to be disposed, acquiring a sort
		/// of ownership of this instance.
		/// </remarks>
		void IncRef();

		/// <summary>
		/// Decrement the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed using .
		/// </para>
		/// <para>
		/// This method should be meant almost equals to <see cref="IDisposable.Dispose"/> method (since it can dispose
		/// conditionally the instance). Sadly, code analysis tools could detect that IDisposable fields won't be disposed
		/// by some classes.
		/// </para>
		/// </remarks>
		void DecRef();

		#endregion
	}
}
