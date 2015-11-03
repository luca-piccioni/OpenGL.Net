
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_BUFFER_SWAP_COMPLETE_INTEL_MASK symbol.
		/// </summary>
		[RequiredByFeature("GLX_INTEL_swap_event")]
		public const uint BUFFER_SWAP_COMPLETE_INTEL_MASK = 0x04000000;

		/// <summary>
		/// Value of GLX_EXCHANGE_COMPLETE_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GLX_INTEL_swap_event")]
		public const int EXCHANGE_COMPLETE_INTEL = 0x8180;

		/// <summary>
		/// Value of GLX_COPY_COMPLETE_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GLX_INTEL_swap_event")]
		public const int COPY_COMPLETE_INTEL = 0x8181;

		/// <summary>
		/// Value of GLX_FLIP_COMPLETE_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GLX_INTEL_swap_event")]
		public const int FLIP_COMPLETE_INTEL = 0x8182;

	}

}
