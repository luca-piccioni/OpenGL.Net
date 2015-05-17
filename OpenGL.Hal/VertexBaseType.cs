
// Copyright (C) 2009-2015 Luca Piccioni
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

using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Base type of vertex components.
	/// </summary>
	public enum VertexBaseType
	{
		/// <summary>
		/// Signed byte components.
		/// </summary>
		Byte = Gl.BYTE,
		/// <summary>
		/// Unsigned byte components.
		/// </summary>
		UByte = Gl.UNSIGNED_BYTE,
		/// <summary>
		/// Signed short components.
		/// </summary>
		Short = Gl.SHORT,
		/// <summary>
		/// Unsigned short components.
		/// </summary>
		UShort = Gl.UNSIGNED_SHORT,
		/// <summary>
		/// Signed integer components.
		/// </summary>
		Int = Gl.INT,
		/// <summary>
		/// Unsigned integer components.
		/// </summary>
		UInt = Gl.UNSIGNED_INT,
		/// <summary>
		/// Single-precision floating-point components.
		/// </summary>
		Float = Gl.FLOAT,
		/// <summary>
		/// Double-precision floating-point components.
		/// </summary>
		Double = Gl.DOUBLE,
		/// <summary>
		/// Half-precision floating-point components.
		/// </summary>
		Half = Gl.HALF_FLOAT,

		/// <summary>
		/// Value internally used for indicating an undefined vertex array base type.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		Undefined
	}
}