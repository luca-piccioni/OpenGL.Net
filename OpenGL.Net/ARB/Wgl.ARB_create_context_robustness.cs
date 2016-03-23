
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context_robustness")]
		[Log(BitmaskName = "WGLContextFlagsMask")]
		public const uint CONTEXT_ROBUST_ACCESS_BIT_ARB = 0x00000004;

		/// <summary>
		/// Value of WGL_LOSE_CONTEXT_ON_RESET_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context_robustness")]
		public const int LOSE_CONTEXT_ON_RESET_ARB = 0x8252;

		/// <summary>
		/// Value of WGL_CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context_robustness")]
		public const int CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;

		/// <summary>
		/// Value of WGL_NO_RESET_NOTIFICATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context_robustness")]
		public const int NO_RESET_NOTIFICATION_ARB = 0x8261;

	}

}
