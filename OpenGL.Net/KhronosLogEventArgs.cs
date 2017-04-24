
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
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the command.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments of the <paramref name="name"/> command.
		/// </param>
		/// <param name="retvalue">
		/// The <see cref="Object"/> returned by the function.
		/// </param>
		internal KhronosLogEventArgs(string name, object[] args, object retvalue)
		{
			if (name == null)
				throw new ArgumentNullException("name");
			Name = name;
			Args = args;
			ReturnValue = retvalue;
		}

		#endregion

		#region Command Information

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

		#region Default Value Formatting

		private object FormatArg(object arg)
		{
			Type argType = arg.GetType();

			if (argType == typeof(string[]))
				return (FormatArg((string[])arg));
			else if (argType.IsArray)
				return (FormatArg((Array)arg));
			if (argType == typeof(IntPtr))
				return (FormatArg((IntPtr)arg));
			else
				return (arg);
		}

		private object FormatArg(string[] arg)
		{
			if (arg != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (string arrayItem in arg)
					sb.AppendFormat("{0},", arrayItem.Replace("\n", "\\n"));
				if (arg.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		private object FormatArg(Array arg)
		{
			if (arg != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (object arrayItem in arg)
					sb.AppendFormat("{0},", arrayItem.ToString());
				if (arg.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		private object FormatArg(IntPtr arg)
		{
			return ("0x" + arg.ToString("X8"));
		}

		#endregion

		#region Object Overrides

		public override string ToString()
		{
			if (Name != null)
				return (ToString_Command());
			else
				return (ToString_Comment());
		}

		private string ToString_Command()
		{
			// Format string
			StringBuilder sbFormat = new StringBuilder();
			int formatIdx = 1;

			sbFormat.Append("{0}(");
			if (Args != null && Args.Length > 0) {
				for (int i = 0; i < Args.Length; i++)
					sbFormat.AppendFormat("{{{0}}}, ", formatIdx++);
				sbFormat.Remove(sbFormat.Length - 2, 2);
			}
			sbFormat.Append(")");
			if (ReturnValue != null)
				sbFormat.AppendFormat(" = {{{0}}}", formatIdx++);

			// Format arguments
			List<object> formatArgs = new List<object>();

			formatArgs.Add(Name);
			if (Args != null) {
				foreach (object arg in Args)
					formatArgs.Add(FormatArg(arg));
			}
			if (ReturnValue != null)
				formatArgs.Add(FormatArg(ReturnValue));

			// Returns formatted string
			return (String.Format(sbFormat.ToString(), formatArgs.ToArray()));
		}

		private string ToString_Comment()
		{
			return (_Comment);
		}

		#endregion
	}
}
