
// Copyright (C) 2015 Luca Piccioni
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

#pragma warning disable 618

using System;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings.
	/// </summary>
	public partial class Gl : ProcLoader
	{
		#region Imports Management

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "opengl32.dll";

		#endregion

		#region Debugging

		/// <summary>
		/// Get or set the enable flag for the OpenGL call log.
		/// </summary>
		public static bool CallLogEnabled
		{
			get { return (sCallLogEnabled); }
			set { sCallLogEnabled = value; }
		}

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		[Conditional("DEBUG")]
		private static void DebugCheckErrors()
		{
			ErrorCode error = GetError();

			if (error != ErrorCode.NoError)
				throw new InvalidOperationException(error.ToString());
		}

		/// <summary>
		/// OpenGL logging utility.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that speficies the format string.
		/// </param>
		/// <param name="args">
		/// A variable arrays of objects used for rendering the <paramref name="format"/>.
		/// </param>
		[Conditional("OPENGL_NET_CALL_LOG_ENABLED")]
		private static void CallLog(string format, params object[] args)
		{
			if (sCallLogEnabled == false)
				return;


		}

		/// <summary>
		/// The enable flag for the OpenGL call log.
		/// </summary>
		private static bool sCallLogEnabled;

		#endregion
	}
}
