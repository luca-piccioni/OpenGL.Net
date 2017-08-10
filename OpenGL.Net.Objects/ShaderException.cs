
// Copyright (C) 2011-2017 Luca Piccioni
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
