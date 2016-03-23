
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
		/// Value of GL_PACK_RESAMPLE_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int PACK_RESAMPLE_OML = 0x8984;

		/// <summary>
		/// Value of GL_UNPACK_RESAMPLE_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int UNPACK_RESAMPLE_OML = 0x8985;

		/// <summary>
		/// Value of GL_RESAMPLE_REPLICATE_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int RESAMPLE_REPLICATE_OML = 0x8986;

		/// <summary>
		/// Value of GL_RESAMPLE_ZERO_FILL_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int RESAMPLE_ZERO_FILL_OML = 0x8987;

		/// <summary>
		/// Value of GL_RESAMPLE_AVERAGE_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int RESAMPLE_AVERAGE_OML = 0x8988;

		/// <summary>
		/// Value of GL_RESAMPLE_DECIMATE_OML symbol.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		public const int RESAMPLE_DECIMATE_OML = 0x8989;

	}

}
