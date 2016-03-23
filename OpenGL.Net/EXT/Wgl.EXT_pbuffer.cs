
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
		/// Value of WGL_OPTIMAL_PBUFFER_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int OPTIMAL_PBUFFER_WIDTH_EXT = 0x2031;

		/// <summary>
		/// Value of WGL_OPTIMAL_PBUFFER_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int OPTIMAL_PBUFFER_HEIGHT_EXT = 0x2032;

		/// <summary>
		/// Binding for wglCreatePbufferEXT.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iWidth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iHeight">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglCreatePbufferEXT != null, "pwglCreatePbufferEXT not implemented");
					retValue = Delegates.pwglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, p_piAttribList);
					LogFunction("wglCreatePbufferEXT(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), iPixelFormat, iWidth, iHeight, LogValue(piAttribList), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetPbufferDCEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static IntPtr GetPbufferDCEXT(IntPtr hPbuffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetPbufferDCEXT != null, "pwglGetPbufferDCEXT not implemented");
			retValue = Delegates.pwglGetPbufferDCEXT(hPbuffer);
			LogFunction("wglGetPbufferDCEXT(0x{0}) = {1}", hPbuffer.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleasePbufferDCEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC)
		{
			int retValue;

			Debug.Assert(Delegates.pwglReleasePbufferDCEXT != null, "pwglReleasePbufferDCEXT not implemented");
			retValue = Delegates.pwglReleasePbufferDCEXT(hPbuffer, hDC);
			LogFunction("wglReleasePbufferDCEXT(0x{0}, 0x{1}) = {2}", hPbuffer.ToString("X8"), hDC.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDestroyPbufferEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static bool DestroyPbufferEXT(IntPtr hPbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyPbufferEXT != null, "pwglDestroyPbufferEXT not implemented");
			retValue = Delegates.pwglDestroyPbufferEXT(hPbuffer);
			LogFunction("wglDestroyPbufferEXT(0x{0}) = {1}", hPbuffer.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryPbufferEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static bool QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryPbufferEXT != null, "pwglQueryPbufferEXT not implemented");
					retValue = Delegates.pwglQueryPbufferEXT(hPbuffer, iAttribute, p_piValue);
					LogFunction("wglQueryPbufferEXT(0x{0}, {1}, {2}) = {3}", hPbuffer.ToString("X8"), iAttribute, LogValue(piValue), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
