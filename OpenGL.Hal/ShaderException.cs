
// Copyright (C) 2011-2012 Luca Piccioni
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
	/// Exception thrown from classed used for shader operations.
	/// </summary>
	public class ShaderException : GraphicsException
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderException specifying a message.
		/// </summary>
		/// <param name="message">
		/// A <see cref="System.String"/> that specifies an additional message.
		/// </param>
		public ShaderException(string message) : base(ErrorCode.InvalidOperation, message)
		{
			
		}

		/// <summary>
		/// Construct a ShaderException specifying the error code and a message.
		/// </summary>
		/// <param name="format">
		/// A <see cref="System.String"/> that specifies an additional message format string.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:System.Object[]"/> that specifies formatted arguments in <paramref name="format"/>.
		/// </param>
		public ShaderException(string format, params object[] args) : this(String.Format(format, args))
		{
			
		}

		#endregion
	}
}
