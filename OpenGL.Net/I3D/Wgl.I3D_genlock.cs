
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_MULTIVIEW_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_MULTIVIEW_I3D = 0x2044;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EXTERNAL_SYNC_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_SYNC_I3D = 0x2045;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EXTERNAL_FIELD_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_FIELD_I3D = 0x2046;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EXTERNAL_TTL_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_TTL_I3D = 0x2047;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_DIGITAL_SYNC_I3D = 0x2048;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_DIGITAL_FIELD_I3D = 0x2049;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_FALLING_I3D = 0x204A;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EDGE_RISING_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_RISING_I3D = 0x204B;

		/// <summary>
		/// Value of WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_BOTH_I3D = 0x204C;

		/// <summary>
		/// Binding for wglEnableGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool EnableGenlockI3D(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnableGenlockI3D != null, "pwglEnableGenlockI3D not implemented");
			retValue = Delegates.pwglEnableGenlockI3D(hDC);
			LogFunction("wglEnableGenlockI3D(0x{0}) = {1}", hDC.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDisableGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool DisableGenlockI3D(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDisableGenlockI3D != null, "pwglDisableGenlockI3D not implemented");
			retValue = Delegates.pwglDisableGenlockI3D(hDC);
			LogFunction("wglDisableGenlockI3D(0x{0}) = {1}", hDC.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglIsEnabledGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool IsEnabledGenlockI3D(IntPtr hDC, [Out] bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglIsEnabledGenlockI3D != null, "pwglIsEnabledGenlockI3D not implemented");
					retValue = Delegates.pwglIsEnabledGenlockI3D(hDC, p_pFlag);
					LogFunction("wglIsEnabledGenlockI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), LogValue(pFlag), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGenlockSourceI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uSource">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceI3D(IntPtr hDC, UInt32 uSource)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceI3D != null, "pwglGenlockSourceI3D not implemented");
			retValue = Delegates.pwglGenlockSourceI3D(hDC, uSource);
			LogFunction("wglGenlockSourceI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), uSource, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGenlockSourceI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uSource">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32[] uSource)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_uSource = uSource)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceI3D != null, "pwglGetGenlockSourceI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceI3D(hDC, p_uSource);
					LogFunction("wglGetGenlockSourceI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), LogValue(uSource), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGenlockSourceEdgeI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uEdge">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceEdgeI3D != null, "pwglGenlockSourceEdgeI3D not implemented");
			retValue = Delegates.pwglGenlockSourceEdgeI3D(hDC, uEdge);
			LogFunction("wglGenlockSourceEdgeI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), uEdge, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGenlockSourceEdgeI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uEdge">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32[] uEdge)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_uEdge = uEdge)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceEdgeI3D != null, "pwglGetGenlockSourceEdgeI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceEdgeI3D(hDC, p_uEdge);
					LogFunction("wglGetGenlockSourceEdgeI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), LogValue(uEdge), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGenlockSampleRateI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uRate">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSampleRateI3D != null, "pwglGenlockSampleRateI3D not implemented");
			retValue = Delegates.pwglGenlockSampleRateI3D(hDC, uRate);
			LogFunction("wglGenlockSampleRateI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), uRate, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGenlockSampleRateI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uRate">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32[] uRate)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_uRate = uRate)
				{
					Debug.Assert(Delegates.pwglGetGenlockSampleRateI3D != null, "pwglGetGenlockSampleRateI3D not implemented");
					retValue = Delegates.pwglGetGenlockSampleRateI3D(hDC, p_uRate);
					LogFunction("wglGetGenlockSampleRateI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), LogValue(uRate), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGenlockSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uDelay">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceDelayI3D != null, "pwglGenlockSourceDelayI3D not implemented");
			retValue = Delegates.pwglGenlockSourceDelayI3D(hDC, uDelay);
			LogFunction("wglGenlockSourceDelayI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), uDelay, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGenlockSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uDelay">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32[] uDelay)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_uDelay = uDelay)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceDelayI3D != null, "pwglGetGenlockSourceDelayI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceDelayI3D(hDC, p_uDelay);
					LogFunction("wglGetGenlockSourceDelayI3D(0x{0}, {1}) = {2}", hDC.ToString("X8"), LogValue(uDelay), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryGenlockMaxSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uMaxLineDelay">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="uMaxPixelDelay">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool QueryGenlockMaxSourceDelayI3D(IntPtr hDC, UInt32[] uMaxLineDelay, UInt32[] uMaxPixelDelay)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_uMaxLineDelay = uMaxLineDelay)
				fixed (UInt32* p_uMaxPixelDelay = uMaxPixelDelay)
				{
					Debug.Assert(Delegates.pwglQueryGenlockMaxSourceDelayI3D != null, "pwglQueryGenlockMaxSourceDelayI3D not implemented");
					retValue = Delegates.pwglQueryGenlockMaxSourceDelayI3D(hDC, p_uMaxLineDelay, p_uMaxPixelDelay);
					LogFunction("wglQueryGenlockMaxSourceDelayI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), LogValue(uMaxLineDelay), LogValue(uMaxPixelDelay), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnableGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnableGenlockI3D(IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDisableGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDisableGenlockI3D(IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglIsEnabledGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceI3D(IntPtr hDC, UInt32 uSource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceI3D(IntPtr hDC, UInt32* uSource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceEdgeI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceEdgeI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, UInt32* uEdge);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSampleRateI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSampleRateI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSampleRateI3D(IntPtr hDC, UInt32* uRate);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceDelayI3D(IntPtr hDC, UInt32* uDelay);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, UInt32* uMaxLineDelay, UInt32* uMaxPixelDelay);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnableGenlockI3D(IntPtr hDC);

			[ThreadStatic]
			internal static wglEnableGenlockI3D pwglEnableGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDisableGenlockI3D(IntPtr hDC);

			[ThreadStatic]
			internal static wglDisableGenlockI3D pwglDisableGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);

			[ThreadStatic]
			internal static wglIsEnabledGenlockI3D pwglIsEnabledGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceI3D(IntPtr hDC, UInt32 uSource);

			[ThreadStatic]
			internal static wglGenlockSourceI3D pwglGenlockSourceI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceI3D(IntPtr hDC, UInt32* uSource);

			[ThreadStatic]
			internal static wglGetGenlockSourceI3D pwglGetGenlockSourceI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);

			[ThreadStatic]
			internal static wglGenlockSourceEdgeI3D pwglGenlockSourceEdgeI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, UInt32* uEdge);

			[ThreadStatic]
			internal static wglGetGenlockSourceEdgeI3D pwglGetGenlockSourceEdgeI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);

			[ThreadStatic]
			internal static wglGenlockSampleRateI3D pwglGenlockSampleRateI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSampleRateI3D(IntPtr hDC, UInt32* uRate);

			[ThreadStatic]
			internal static wglGetGenlockSampleRateI3D pwglGetGenlockSampleRateI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);

			[ThreadStatic]
			internal static wglGenlockSourceDelayI3D pwglGenlockSourceDelayI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceDelayI3D(IntPtr hDC, UInt32* uDelay);

			[ThreadStatic]
			internal static wglGetGenlockSourceDelayI3D pwglGetGenlockSourceDelayI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, UInt32* uMaxLineDelay, UInt32* uMaxPixelDelay);

			[ThreadStatic]
			internal static wglQueryGenlockMaxSourceDelayI3D pwglQueryGenlockMaxSourceDelayI3D;

		}
	}

}
