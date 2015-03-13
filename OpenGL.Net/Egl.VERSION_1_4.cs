
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
		/// Value of EGL_DEFAULT_DISPLAY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int DEFAULT_DISPLAY = 0;

		/// <summary>
		/// Value of EGL_MULTISAMPLE_RESOLVE_BOX_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE_BOX_BIT = 0x0200;

		/// <summary>
		/// Value of EGL_MULTISAMPLE_RESOLVE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE = 0x3099;

		/// <summary>
		/// Value of EGL_MULTISAMPLE_RESOLVE_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE_DEFAULT = 0x309A;

		/// <summary>
		/// Value of EGL_MULTISAMPLE_RESOLVE_BOX symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE_BOX = 0x309B;

		/// <summary>
		/// Value of EGL_OPENGL_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int OPENGL_API = 0x30A2;

		/// <summary>
		/// Value of EGL_OPENGL_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int OPENGL_BIT = 0x0008;

		/// <summary>
		/// Value of EGL_SWAP_BEHAVIOR_PRESERVED_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int SWAP_BEHAVIOR_PRESERVED_BIT = 0x0400;

		/// <summary>
		/// Binding for eglGetCurrentContext.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public static IntPtr GetCurrentContext()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentContext != null, "peglGetCurrentContext not implemented");
			retValue = Delegates.peglGetCurrentContext();
			CallLog("eglGetCurrentContext() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
