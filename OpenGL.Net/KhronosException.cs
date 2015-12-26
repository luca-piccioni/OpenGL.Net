
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

using System;

namespace OpenGL
{
	/// <summary>
	/// Basic exception thrown by KhronosApi classes.
	/// </summary>
	public class KhronosException : InvalidOperationException
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		public KhronosException(int errorCode)
		{

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
		public KhronosException(int errorCode, String message) :
			base(message)
		{

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
		public KhronosException(int errorCode, String message, Exception innerException) :
			base(message, innerException)
		{

		}

		#endregion

		#region Error Code

		/// <summary>
		/// Khronos error code.
		/// </summary>
		public readonly int ErrCode;

		#endregion
	}
}
