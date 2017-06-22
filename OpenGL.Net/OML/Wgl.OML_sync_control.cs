
// Copyright (C) 2015-2017 Luca Piccioni
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
		/// [WGL] Binding for wglGetSyncValuesOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool GetSyncValuesOML(IntPtr hdc, [Out] Int64[] ust, [Out] Int64[] msc, [Out] Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglGetSyncValuesOML != null, "pwglGetSyncValuesOML not implemented");
					retValue = Delegates.pwglGetSyncValuesOML(hdc, p_ust, p_msc, p_sbc);
					LogCommand("wglGetSyncValuesOML", retValue, hdc, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetMscRateOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numerator">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="denominator">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool GetMscRateOML(IntPtr hdc, [Out] Int32[] numerator, [Out] Int32[] denominator)
		{
			bool retValue;

			unsafe {
				fixed (Int32* p_numerator = numerator)
				fixed (Int32* p_denominator = denominator)
				{
					Debug.Assert(Delegates.pwglGetMscRateOML != null, "pwglGetMscRateOML not implemented");
					retValue = Delegates.pwglGetMscRateOML(hdc, p_numerator, p_denominator);
					LogCommand("wglGetMscRateOML", retValue, hdc, numerator, denominator					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglSwapBuffersMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder)
		{
			Int64 retValue;

			Debug.Assert(Delegates.pwglSwapBuffersMscOML != null, "pwglSwapBuffersMscOML not implemented");
			retValue = Delegates.pwglSwapBuffersMscOML(hdc, target_msc, divisor, remainder);
			LogCommand("wglSwapBuffersMscOML", retValue, hdc, target_msc, divisor, remainder			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglSwapLayerBuffersMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fuPlanes">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder)
		{
			Int64 retValue;

			Debug.Assert(Delegates.pwglSwapLayerBuffersMscOML != null, "pwglSwapLayerBuffersMscOML not implemented");
			retValue = Delegates.pwglSwapLayerBuffersMscOML(hdc, fuPlanes, target_msc, divisor, remainder);
			LogCommand("wglSwapLayerBuffersMscOML", retValue, hdc, fuPlanes, target_msc, divisor, remainder			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglWaitForMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64[] ust, Int64[] msc, Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglWaitForMscOML != null, "pwglWaitForMscOML not implemented");
					retValue = Delegates.pwglWaitForMscOML(hdc, target_msc, divisor, remainder, p_ust, p_msc, p_sbc);
					LogCommand("wglWaitForMscOML", retValue, hdc, target_msc, divisor, remainder, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglWaitForSbcOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_sbc">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool WaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64[] ust, Int64[] msc, Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglWaitForSbcOML != null, "pwglWaitForSbcOML not implemented");
					retValue = Delegates.pwglWaitForSbcOML(hdc, target_sbc, p_ust, p_msc, p_sbc);
					LogCommand("wglWaitForSbcOML", retValue, hdc, target_sbc, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetSyncValuesOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetSyncValuesOML(IntPtr hdc, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetMscRateOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetMscRateOML(IntPtr hdc, Int32* numerator, Int32* denominator);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapBuffersMscOML", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int64 wglSwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapLayerBuffersMscOML", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int64 wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglWaitForMscOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglWaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglWaitForSbcOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglWaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetSyncValuesOML(IntPtr hdc, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglGetSyncValuesOML pwglGetSyncValuesOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetMscRateOML(IntPtr hdc, Int32* numerator, Int32* denominator);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglGetMscRateOML pwglGetMscRateOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int64 wglSwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglSwapBuffersMscOML pwglSwapBuffersMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int64 wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglSwapLayerBuffersMscOML pwglSwapLayerBuffersMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglWaitForMscOML pwglWaitForMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			[ThreadStatic]
			internal static wglWaitForSbcOML pwglWaitForSbcOML;

		}
	}

}
