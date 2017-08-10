
// Copyright (C) 2011-2017 Luca Piccioni
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
	/// Exception thrown from classed used for shader operations.
	/// </summary>
	public class ShaderException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderException specifying a message.
		/// </summary>
		/// <param name="message">
		/// A <see cref="String"/> that specify an additional message.
		/// </param>
		public ShaderException(string message) :
			base((int)ErrorCode.InvalidOperation, message)
		{
			
		}

		/// <summary>
		/// Construct a ShaderException specifying the message to format.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specify an additional message format string.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:System.Object[]"/> that specify formatted arguments in <paramref name="format"/>.
		/// </param>
		public ShaderException(string format, params object[] args) :
			this(String.Format(format, args))
		{
			
		}

		#endregion
	}
}
