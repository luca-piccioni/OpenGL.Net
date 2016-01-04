
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

using System;

namespace OpenGL
{
	/// <summary>
	/// Attribute indicating whether a field shall indicate an OpenGL implementation limit.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class GraphicsLimitAttribute : Attribute
	{
		/// <summary>
		/// Construct a GraphicsLimitAttribute.
		/// </summary>
		/// <param name="enum">
		/// A <see cref="Int32"/> that specify the OpenGL enumeration value to used with Gl.Get and Gl.GetString routines.
		/// </param>
		public GraphicsLimitAttribute(int @enum)
		{
			EnumValue = @enum;
		}

		/// <summary>
		/// The enumeration value representing the limit.
		/// </summary>
		public readonly int EnumValue;

		/// <summary>
		/// In the case the limit is composed by an array, this property specify the array length.
		/// </summary>
		public uint ArrayLenght { get { return (mArrayLength); } set { mArrayLength = value; } }

		/// <summary>
		/// In the case the limit is composed by an array, this field specify the array length.
		/// </summary>
		private uint mArrayLength = 0;
	}
}
