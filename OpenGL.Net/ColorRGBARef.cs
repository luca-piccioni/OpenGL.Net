
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
	/// Color defined as reference type.
	/// </summary>
	public class ColorRGBA
	{
		#region Constructors

		public ColorRGBA(float v)
			: this(v, v, v, v)
		{

		}

		public ColorRGBA(float r, float g, float b)
			: this(r, g, b, 1.0f)
		{

		}

		public ColorRGBA(float r, float g, float b, float a)
		{
			Red = r;
			Green = g;
			Blue = b;
			Alpha = a;
		}

		public ColorRGBA(ColorRGBA c)
		{
			Red = c.Red;
			Green = c.Green;
			Blue = c.Blue;
			Alpha = c.Alpha;
		}

		public ColorRGBA(ColorRGBAF c)
		{
			Red = c.Red;
			Green = c.Green;
			Blue = c.Blue;
			Alpha = c.Alpha;
		}

		#endregion

		#region Color Components

		/// <summary>
		/// Red component.
		/// </summary>
		public float Red;

		/// <summary>
		/// Green component.
		/// </summary>
		public float Green;

		/// <summary>
		/// Blue component.
		/// </summary>
		public float Blue;

		/// <summary>
		/// Alpha component.
		/// </summary>
		public float Alpha;

		#endregion

		#region Cast

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns>
		/// </returns>
		public static explicit operator float[] (ColorRGBA value)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			float[] v = new float[4];

			v[0] = value.Red;
			v[1] = value.Green;
			v[2] = value.Blue;
			v[3] = value.Alpha;

			return (v);
		}

		#endregion
	}
}
