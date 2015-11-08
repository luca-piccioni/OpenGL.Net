
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

namespace OpenGL
{
	/// <summary>
	/// Generic interface log logging.
	/// </summary>
	public interface ILogger
	{
		#region Identation

		/// <summary>
		/// Indent subsequent logging messages.
		/// </summary>
		void Indent();

		/// <summary>
		/// Unindent subsequent logging messages.
		/// </summary>
		void Unindent();

		#endregion

		#region Logging Routines

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Verbose level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Verbose(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Verbose level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Verbose(string format, params object[] args);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Debug level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Debug(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Debug level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Debug(string format, params object[] args);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Info level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Info(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Info level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Info(string format, params object[] args);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Warn level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Warn(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Warn level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Warn(string format, params object[] args);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Error level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Error(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Error level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Error(string format, params object[] args);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Fatal level.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log</param>
		void Fatal(string message, Exception exception);

		/// <summary>
		/// Log a message object with the log4net.Core.Level.Fatal level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items.</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		void Fatal(string format, params object[] args);

		#endregion
	}
}