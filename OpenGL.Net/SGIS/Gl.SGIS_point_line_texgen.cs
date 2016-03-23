
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_EYE_DISTANCE_TO_POINT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int EYE_DISTANCE_TO_POINT_SGIS = 0x81F0;

		/// <summary>
		/// Value of GL_OBJECT_DISTANCE_TO_POINT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1;

		/// <summary>
		/// Value of GL_EYE_DISTANCE_TO_LINE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int EYE_DISTANCE_TO_LINE_SGIS = 0x81F2;

		/// <summary>
		/// Value of GL_OBJECT_DISTANCE_TO_LINE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3;

		/// <summary>
		/// Value of GL_EYE_POINT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int EYE_POINT_SGIS = 0x81F4;

		/// <summary>
		/// Value of GL_OBJECT_POINT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int OBJECT_POINT_SGIS = 0x81F5;

		/// <summary>
		/// Value of GL_EYE_LINE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int EYE_LINE_SGIS = 0x81F6;

		/// <summary>
		/// Value of GL_OBJECT_LINE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		public const int OBJECT_LINE_SGIS = 0x81F7;

	}

}
