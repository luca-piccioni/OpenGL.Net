
// Copyright (C) 2017 Luca Piccioni
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
	/// EventArgs providing information about an API command call.
	/// </summary>
	public sealed class KhronosLogEventArgs : EventArgs
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosLogEventArgs.
		/// </summary>
		/// <param name="comment">
		/// A <see cref="string"/> that specifies the comment string.
		/// </param>
		internal KhronosLogEventArgs(string comment)
		{
			_Comment = comment;
		}

		/// <summary>
		/// Construct a KhronosLogEventArgs.
		/// </summary>
		/// <param name="logContext">
		/// A <see cref="KhronosLogContext"/> holding information about the API logged.
		/// </param>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the command.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments of the <paramref name="name"/> command.
		/// </param>
		/// <param name="retvalue">
		/// The <see cref="Object"/> returned by the function.
		/// </param>
		internal KhronosLogEventArgs(KhronosLogContext logContext, string name, object[] args, object retvalue)
		{
			if (name == null)
				throw new ArgumentNullException(nameof(name));

			_LogContext = logContext;
			Name = name;
			Args = args;
			ReturnValue = retvalue;
		}

		#endregion

		#region Command Information

		/// <summary>
		/// Optional logging context holding information about the API logged.
		/// </summary>
		private readonly KhronosLogContext _LogContext;

		/// <summary>
		/// Command name.
		/// </summary>
		public readonly string Name;

		/// <summary>
		/// Command call arguments.
		/// </summary>
		public readonly object[] Args;

		/// <summary>
		/// The command returned value, if any.
		/// </summary>
		public readonly object ReturnValue;

		#endregion

		#region Comment Information

		/// <summary>
		/// Comment string.
		/// </summary>
		private readonly string _Comment;

		#endregion

		#region Object Overrides

		/// <summary>
		/// Get the event information.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="string"/> representing this KhronosLogEventArgs.
		/// </returns>
		public override string ToString()
		{
			if (Name != null && _LogContext != null)
				return _LogContext.ToString(Name, ReturnValue, Args);
			
			return _Comment ?? string.Empty;
		}

		#endregion
	}
}
