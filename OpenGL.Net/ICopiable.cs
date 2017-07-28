
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

namespace OpenGL
{
	/// <summary>
	/// Interface implemented by those objects that can copy data from another instance.
	/// </summary>
	public interface ICopiable
	{
		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Object"/> that specify the object from where the information is copied.
		/// </param>
		void Copy(object other);
	}

	/// <summary>
	/// Interface implemented by those objects that can copy data from another instance.
	/// </summary>
	public interface ICopiable<T> : ICopiable
	{
		/// <summary>
		/// Copy the object content to this instance.
		/// </summary>
		/// <param name="other">
		/// A <typeparamref name="T"/> that specify the object from where the information is copied.
		/// </param>
		void Copy(T other);
	}
}
