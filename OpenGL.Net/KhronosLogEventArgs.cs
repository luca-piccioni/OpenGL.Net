
// Copyright (C) 2017 Luca Piccioni
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
using System.Text;

namespace OpenGL
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
		/// <param name="logContext">
		/// A <see cref="KhronosLogContext"/> holding information about the API logged.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specifies the format string.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments for <paramref name="format"/>.
		/// </param>
		internal KhronosLogEventArgs(string format, params object[] args)
		{
			_Comment = String.Format(format, args);
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
				throw new ArgumentNullException("name");
			Name = name;
			Args = args;
			ReturnValue = retvalue;
			_LogContext = logContext;
		}

		#endregion

		#region Event Information

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

		/// <summary>
		/// Optional logging context holding information about the API logged.
		/// </summary>
		private readonly KhronosLogContext _LogContext;

		#endregion

		#region Comment Information

		/// <summary>
		/// Comment string.
		/// </summary>
		private readonly string _Comment;

		#endregion

		#region Object Overrides

		public override string ToString()
		{
			if (Name != null)
				return (_LogContext.ToString(Name, ReturnValue, Args));
			else
				return (_Comment);
		}

		#endregion
	}
}
