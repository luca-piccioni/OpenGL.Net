
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
		/// Value of ERROR_INVALID_PIXEL_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("ERROR_INVALID_PIXEL_TYPE_EXT")]
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public const int ERROR_INVALID_PIXEL_TYPE_ARB = 0x2043;

		/// <summary>
		/// Value of ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public const int ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = 0x2054;

		/// <summary>
		/// Binding for wglMakeContextCurrentARB.
		/// </summary>
		/// <param name="hDrawDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hReadDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public static bool MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeContextCurrentARB != null, "pwglMakeContextCurrentARB not implemented");
			retValue = Delegates.pwglMakeContextCurrentARB(hDrawDC, hReadDC, hglrc);
			CallLog("wglMakeContextCurrentARB({0}, {1}, {2}) = {3}", hDrawDC, hReadDC, hglrc, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetCurrentReadDCARB.
		/// </summary>
		[RequiredByFeature("WGL_ARB_make_current_read")]
		public static IntPtr GetCurrentReadDCARB()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentReadDCARB != null, "pwglGetCurrentReadDCARB not implemented");
			retValue = Delegates.pwglGetCurrentReadDCARB();
			CallLog("wglGetCurrentReadDCARB() = {0}", retValue);

			return (retValue);
		}

	}

}
