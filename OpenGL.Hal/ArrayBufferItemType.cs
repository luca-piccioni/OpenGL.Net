
// Copyright (C) 2012-2013 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// The type of the data collected by <see cref="ArrayBufferObject"/>.
	/// </summary>
	public enum ArrayBufferItemType
	{
		#region Single-Precision Floating-Point Types

		/// <summary>
		/// A single single-precision floating-point value.
		/// </summary>
		Float,
		/// <summary>
		/// A vector of two single-precision floating-point values.
		/// </summary>
		Float2,
		/// <summary>
		/// A vector of three single-precision floating-point values.
		/// </summary>
		Float3,
		/// <summary>
		/// A vector of four single-precision floating-point values.
		/// </summary>
		Float4,

		#endregion

		#region Half-Precision Floating-Point Types

		/// <summary>
		/// A single half-precision floating-point value.
		/// </summary>
		Half,
		/// <summary>
		/// A vector of two half-precision floating-point values.
		/// </summary>
		Half2,
		/// <summary>
		/// A vector of three half-precision floating-point values.
		/// </summary>
		Half3,
		/// <summary>
		/// A vector of four half-precision floating-point values.
		/// </summary>
		Half4,

		#endregion

		#region Double-Precision Floating-Point Types

		/// <summary>
		/// A single double-precision floating-point value.
		/// </summary>
		Double,
		/// <summary>
		/// A vector of two double-precision floating-point values.
		/// </summary>
		Double2,
		/// <summary>
		/// A vector of three double-precision floating-point values.
		/// </summary>
		Double3,
		/// <summary>
		/// A vector of four double-precision floating-point values.
		/// </summary>
		Double4,

		#endregion

		#region Signed Integer Types

		/// <summary>
		/// A single signed byte value.
		/// </summary>
		Byte,
		/// <summary>
		/// A vector of two signed byte values.
		/// </summary>
		Byte2,
		/// <summary>
		/// A vector of three signed byte values.
		/// </summary>
		Byte3,
		/// <summary>
		/// A vector of four signed byte values.
		/// </summary>
		Byte4,

		/// <summary>
		/// A single signed short integer value.
		/// </summary>
		Short,
		/// <summary>
		/// A vector of two signed short integer values.
		/// </summary>
		Short2,
		/// <summary>
		/// A vector of three signed short integer values.
		/// </summary>
		Short3,
		/// <summary>
		/// A vector of four signed short integer values.
		/// </summary>
		Short4,

		/// <summary>
		/// A single signed integer value.
		/// </summary>
		Int,
		/// <summary>
		/// A vector of two signed integer values.
		/// </summary>
		Int2,
		/// <summary>
		/// A vector of three signed integer values.
		/// </summary>
		Int3,
		/// <summary>
		/// A vector of four signed integer values.
		/// </summary>
		Int4,

		#endregion

		#region Unsigned Integer Types

		/// <summary>
		/// A single unsigned byte value.
		/// </summary>
		UByte,
		/// <summary>
		/// A vector of two unsigned byte values.
		/// </summary>
		UByte2,
		/// <summary>
		/// A vector of three unsigned byte values.
		/// </summary>
		UByte3,
		/// <summary>
		/// A vector of four unsigned byte values.
		/// </summary>
		UByte4,

		/// <summary>
		/// A single unsigned short integer value.
		/// </summary>
		UShort,
		/// <summary>
		/// A vector of two unsigned short integer values.
		/// </summary>
		UShort2,
		/// <summary>
		/// A vector of three unsigned short integer values.
		/// </summary>
		UShort3,
		/// <summary>
		/// A vector of four unsigned short integer values.
		/// </summary>
		UShort4,

		/// <summary>
		/// A single unsigned integer value.
		/// </summary>
		UInt,
		/// <summary>
		/// A vector of two unsigned integer values.
		/// </summary>
		UInt2,
		/// <summary>
		/// A vector of three unsigned integer values.
		/// </summary>
		UInt3,
		/// <summary>
		/// A vector of four unsigned integer values.
		/// </summary>
		UInt4,

		#endregion

		#region Single-Precision Floating-Point Matrix Types

		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 2 rows.
		/// </summary>
		Float2x2,
		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 3 rows.
		/// </summary>
		Float2x3,
		/// <summary>
		/// A single-precision floating-point matrix of 2 columns and 4 rows.
		/// </summary>
		Float2x4,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 2 rows.
		/// </summary>
		Float3x2,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 3 rows.
		/// </summary>
		Float3x3,
		/// <summary>
		/// A single-precision floating-point matrix of 3 columns and 4 rows.
		/// </summary>
		Float3x4,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 2 rows.
		/// </summary>
		Float4x2,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 3 rows.
		/// </summary>
		Float4x3,
		/// <summary>
		/// A single-precision floating-point matrix of 4 columns and 4 rows.
		/// </summary>
		Float4x4,

		#endregion

		#region Double-Precision Floating-Point Matrix Types

		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 2 rows.
		/// </summary>
		Double2x2,
		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 3 rows.
		/// </summary>
		Double2x3,
		/// <summary>
		/// A double-precision floating-point matrix of 2 columns and 4 rows.
		/// </summary>
		Double2x4,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 2 rows.
		/// </summary>
		Double3x2,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 3 rows.
		/// </summary>
		Double3x3,
		/// <summary>
		/// A double-precision floating-point matrix of 3 columns and 4 rows.
		/// </summary>
		Double3x4,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 2 rows.
		/// </summary>
		Double4x2,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 3 rows.
		/// </summary>
		Double4x3,
		/// <summary>
		/// A double-precision floating-point matrix of 4 columns and 4 rows.
		/// </summary>
		Double4x4,

		#endregion

		/// <summary>
		/// A fictive value indicating that the values are complex (packed and/or interleaved).
		/// </summary>
		[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
		Complex
	}
}
