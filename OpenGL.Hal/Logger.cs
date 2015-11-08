
// Copyright (C) 2011-2013 Luca Piccioni
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//   
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

using log4net;
using log4net.Core;

namespace OpenGL
{
	/// <summary>
	/// Default logger implementation.
	/// </summary>
	class Logger : ILogger
	{
		#region Constructors

		/// <summary>
		/// Construct a logger for a specific type.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specify the type referred on the logging.
		/// </param>
		public Logger(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			// Store declaring type
			_DeclaringType = type;
			// Create logger
			_Logger = LogManager.GetLogger(_DeclaringType);
		}

		#endregion

		#region Logging

		/// <summary>
		/// Logging declaring type.
		/// </summary>
		private readonly Type _DeclaringType;

		/// <summary>
		/// Logger for declaring type.
		/// </summary>
		private readonly ILog _Logger;

		/// <summary>
		/// Enabled flag. Useful in special cases where no log is required.
		/// </summary>
		public static bool Enabled = true;

		#endregion

		#region ILogger Implementation

		/// <summary>
		/// Indent subsequent logging messages.
		/// </summary>
		public void Indent()
		{
			mIndentLevel++;
		}

		/// <summary>
		/// Unindent subsequent logging messages.
		/// </summary>
		public void Unindent()
		{
			if (mIndentLevel == 0)
				throw new InvalidOperationException("bad indentation");
			mIndentLevel--;
		}

		private static string IdentationPrefix()
		{
			return (new String(' ', (int)mIndentLevel * 4));
		}

		/// <summary>
		/// Current identation level.
		/// </summary>
		private static uint mIndentLevel;

		public void Verbose(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Verbose, IdentationPrefix() + message, exception);
		}

		public void Verbose(string format, params object[] args)
		{
			Verbose(String.Format(format, args), (Exception)null);
		}

		public void Debug(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Debug, IdentationPrefix() + message, exception);
		}

		public void Debug(string format, params object[] args)
		{
			Debug(String.Format(format, args), (Exception)null);
		}

		public void Info(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Info, IdentationPrefix() + message, exception);
		}

		public void Info(string format, params object[] args)
		{
			Info(String.Format(format, args), (Exception)null);
		}

		public void Warn(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Warn, IdentationPrefix() + message, exception);
		}

		public void Warn(string format, params object[] args)
		{
			Warn(String.Format(format, args), (Exception)null);
		}

		public void Error(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Error, IdentationPrefix() + message, exception);
		}

		public void Error(string format, params object[] args)
		{
			Error(String.Format(format, args), (Exception)null);
		}

		public void Fatal(string message, Exception exception)
		{
			if (Enabled)
				_Logger.Logger.Log(_DeclaringType, Level.Fatal, IdentationPrefix() + message, exception);
		}

		public void Fatal(string format, params object[] args)
		{
			Fatal(String.Format(format, args), (Exception)null);
		}

		#endregion
	}
}