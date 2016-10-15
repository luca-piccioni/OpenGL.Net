
// Copyright (C) 2015-2016 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PACK_RESAMPLE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		public const int PACK_RESAMPLE_SGIX = 0x842E;

		/// <summary>
		/// Value of GL_UNPACK_RESAMPLE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		public const int UNPACK_RESAMPLE_SGIX = 0x842F;

		/// <summary>
		/// Value of GL_RESAMPLE_REPLICATE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		public const int RESAMPLE_REPLICATE_SGIX = 0x8433;

		/// <summary>
		/// Value of GL_RESAMPLE_ZERO_FILL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		public const int RESAMPLE_ZERO_FILL_SGIX = 0x8434;

		/// <summary>
		/// Value of GL_RESAMPLE_DECIMATE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		public const int RESAMPLE_DECIMATE_SGIX = 0x8430;

	}

}
