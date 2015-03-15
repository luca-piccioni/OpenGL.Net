
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
		/// Binding for wglMakeContextCurrentEXT.
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
		[RequiredByFeature("WGL_EXT_make_current_read")]
		public static bool MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeContextCurrentEXT != null, "pwglMakeContextCurrentEXT not implemented");
			retValue = Delegates.pwglMakeContextCurrentEXT(hDrawDC, hReadDC, hglrc);
			CallLog("wglMakeContextCurrentEXT({0}, {1}, {2}) = {3}", hDrawDC, hReadDC, hglrc, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetCurrentReadDCEXT.
		/// </summary>
		[RequiredByFeature("WGL_EXT_make_current_read")]
		public static IntPtr GetCurrentReadDCEXT()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentReadDCEXT != null, "pwglGetCurrentReadDCEXT not implemented");
			retValue = Delegates.pwglGetCurrentReadDCEXT();
			CallLog("wglGetCurrentReadDCEXT() = {0}", retValue);

			return (retValue);
		}

	}

}
