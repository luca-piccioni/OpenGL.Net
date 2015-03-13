
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_PBUFFER_IMAGE_BIT_TAO symbol.
		/// </summary>
		public const int PBUFFER_IMAGE_BIT_TAO = 0x0008;

		/// <summary>
		/// Value of EGL_PBUFFER_PALETTE_IMAGE_BIT_TAO symbol.
		/// </summary>
		public const int PBUFFER_PALETTE_IMAGE_BIT_TAO = 0x0010;

		/// <summary>
		/// Value of EGL_INTEROP_BIT_KHR symbol.
		/// </summary>
		public const int INTEROP_BIT_KHR = 0x0010;

		/// <summary>
		/// Value of EGL_OPENMAX_IL_BIT_KHR symbol.
		/// </summary>
		public const int OPENMAX_IL_BIT_KHR = 0x0020;

		/// <summary>
		/// Value of EGL_SHARED_IMAGE_NOK symbol.
		/// </summary>
		public const int SHARED_IMAGE_NOK = 0x30DA;

		/// <summary>
		/// Value of EGL_BUFFER_COUNT_NV symbol.
		/// </summary>
		public const int BUFFER_COUNT_NV = 0x321D;

	}

}
