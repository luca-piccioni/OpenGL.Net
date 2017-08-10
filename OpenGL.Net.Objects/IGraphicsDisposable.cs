
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
	/// Disposable interface extended to support graphics resources disposition.
	/// </summary>
	public interface IGraphicsDisposable : IDisposable
	{
		/// <summary>
		/// Dispose graphics resources using the underlying <see cref="GraphicsContext"/>.
		/// </summary>
		/// <param name='ctx'>
		/// A <see cref="GraphicsContext"/> which have access to the <see cref="IGraphicsDisposable"/> graphics resources. Expect
		/// that this context is current on the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// The instance shall be considered disposed as it were called <see cref="IDisposable.Dispose"/>, but in addition
		/// this method will release this instance resources.
		/// </para>
		/// </remarks>
		void Dispose(GraphicsContext ctx);
	}
}

