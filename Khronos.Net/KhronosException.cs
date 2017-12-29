
// Copyright (C) 2015-2017 Luca Piccioni
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

namespace Khronos
{
	/// <summary>
	/// Basic exception thrown by KhronosApi classes.
	/// </summary>
	public abstract class KhronosException : InvalidOperationException
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		protected KhronosException(int errorCode)
		{
			ErrorCode = errorCode;
		}

		/// <summary>
		/// Construct a KhronosException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		protected KhronosException(int errorCode, string message) :
			base(message)
		{
			ErrorCode = errorCode;
		}

		/// <summary>
		/// Construct a KhronosException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		/// <param name="innerException">
		/// The <see cref="Exception"/> wrapped by this Exception.
		/// </param>
		protected KhronosException(int errorCode, string message, Exception innerException) :
			base(message, innerException)
		{
			ErrorCode = errorCode;
		}

		#endregion

		#region Error Code

		/// <summary>
		/// Khronos error code.
		/// </summary>
		public readonly int ErrorCode;

		#endregion
	}
}
