
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
		/// Value of GL_RGB_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGB_S3TC = 0x83A0;

		/// <summary>
		/// Value of GL_RGB4_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGB4_S3TC = 0x83A1;

		/// <summary>
		/// Value of GL_RGBA_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGBA_S3TC = 0x83A2;

		/// <summary>
		/// Value of GL_RGBA4_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGBA4_S3TC = 0x83A3;

		/// <summary>
		/// Value of GL_RGBA_DXT5_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGBA_DXT5_S3TC = 0x83A4;

		/// <summary>
		/// Value of GL_RGBA4_DXT5_S3TC symbol.
		/// </summary>
		[RequiredByFeature("GL_S3_s3tc")]
		public const int RGBA4_DXT5_S3TC = 0x83A5;

	}

}
