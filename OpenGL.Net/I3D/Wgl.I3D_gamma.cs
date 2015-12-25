
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_GAMMA_TABLE_SIZE_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_gamma")]
		public const int GAMMA_TABLE_SIZE_I3D = 0x204E;

		/// <summary>
		/// Value of WGL_GAMMA_EXCLUDE_DESKTOP_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_gamma")]
		public const int GAMMA_EXCLUDE_DESKTOP_I3D = 0x204F;

		/// <summary>
		/// Binding for wglGetGammaTableParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglGetGammaTableParametersI3D != null, "pwglGetGammaTableParametersI3D not implemented");
					retValue = Delegates.pwglGetGammaTableParametersI3D(hDC, iAttribute, p_piValue);
					LogFunction("wglGetGammaTableParametersI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), iAttribute, piValue, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglSetGammaTableParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglSetGammaTableParametersI3D != null, "pwglSetGammaTableParametersI3D not implemented");
					retValue = Delegates.pwglSetGammaTableParametersI3D(hDC, iAttribute, p_piValue);
					LogFunction("wglSetGammaTableParametersI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), iAttribute, piValue, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGammaTableI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="puRed">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <param name="puGreen">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <param name="puBlue">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16[] puRed, [Out] UInt16[] puGreen, [Out] UInt16[] puBlue)
		{
			bool retValue;

			unsafe {
				fixed (UInt16* p_puRed = puRed)
				fixed (UInt16* p_puGreen = puGreen)
				fixed (UInt16* p_puBlue = puBlue)
				{
					Debug.Assert(Delegates.pwglGetGammaTableI3D != null, "pwglGetGammaTableI3D not implemented");
					retValue = Delegates.pwglGetGammaTableI3D(hDC, iEntries, p_puRed, p_puGreen, p_puBlue);
					LogFunction("wglGetGammaTableI3D(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), iEntries, puRed, puGreen, puBlue, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglSetGammaTableI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="puRed">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <param name="puGreen">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <param name="puBlue">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16[] puRed, UInt16[] puGreen, UInt16[] puBlue)
		{
			bool retValue;

			unsafe {
				fixed (UInt16* p_puRed = puRed)
				fixed (UInt16* p_puGreen = puGreen)
				fixed (UInt16* p_puBlue = puBlue)
				{
					Debug.Assert(Delegates.pwglSetGammaTableI3D != null, "pwglSetGammaTableI3D not implemented");
					retValue = Delegates.pwglSetGammaTableI3D(hDC, iEntries, p_puRed, p_puGreen, p_puBlue);
					LogFunction("wglSetGammaTableI3D(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), iEntries, puRed, puGreen, puBlue, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
