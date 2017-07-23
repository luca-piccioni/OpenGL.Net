
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Binding for glXGetSyncValuesOML.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
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
		[RequiredByFeature("GLX_OML_sync_control")]
		public static bool GetSyncValuesOML(IntPtr dpy, IntPtr drawable, [Out] Int64[] ust, [Out] Int64[] msc, [Out] Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pglXGetSyncValuesOML != null, "pglXGetSyncValuesOML not implemented");
					retValue = Delegates.pglXGetSyncValuesOML(dpy, drawable, p_ust, p_msc, p_sbc);
					LogCommand("glXGetSyncValuesOML", retValue, dpy, drawable, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXGetMscRateOML.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numerator">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="denominator">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_OML_sync_control")]
		public static bool GetMscRateOML(IntPtr dpy, IntPtr drawable, [Out] Int32[] numerator, [Out] Int32[] denominator)
		{
			bool retValue;

			unsafe {
				fixed (Int32* p_numerator = numerator)
				fixed (Int32* p_denominator = denominator)
				{
					Debug.Assert(Delegates.pglXGetMscRateOML != null, "pglXGetMscRateOML not implemented");
					retValue = Delegates.pglXGetMscRateOML(dpy, drawable, p_numerator, p_denominator);
					LogCommand("glXGetMscRateOML", retValue, dpy, drawable, numerator, denominator					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXSwapBuffersMscOML.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
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
		[RequiredByFeature("GLX_OML_sync_control")]
		public static Int64 SwapBuffersMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder)
		{
			Int64 retValue;

			Debug.Assert(Delegates.pglXSwapBuffersMscOML != null, "pglXSwapBuffersMscOML not implemented");
			retValue = Delegates.pglXSwapBuffersMscOML(dpy, drawable, target_msc, divisor, remainder);
			LogCommand("glXSwapBuffersMscOML", retValue, dpy, drawable, target_msc, divisor, remainder			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXWaitForMscOML.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
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
		[RequiredByFeature("GLX_OML_sync_control")]
		public static bool WaitForMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder, Int64[] ust, Int64[] msc, Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pglXWaitForMscOML != null, "pglXWaitForMscOML not implemented");
					retValue = Delegates.pglXWaitForMscOML(dpy, drawable, target_msc, divisor, remainder, p_ust, p_msc, p_sbc);
					LogCommand("glXWaitForMscOML", retValue, dpy, drawable, target_msc, divisor, remainder, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXWaitForSbcOML.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
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
		[RequiredByFeature("GLX_OML_sync_control")]
		public static bool WaitForSbcOML(IntPtr dpy, IntPtr drawable, Int64 target_sbc, Int64[] ust, Int64[] msc, Int64[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (Int64* p_ust = ust)
				fixed (Int64* p_msc = msc)
				fixed (Int64* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pglXWaitForSbcOML != null, "pglXWaitForSbcOML not implemented");
					retValue = Delegates.pglXWaitForSbcOML(dpy, drawable, target_sbc, p_ust, p_msc, p_sbc);
					LogCommand("glXWaitForSbcOML", retValue, dpy, drawable, target_sbc, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetSyncValuesOML", ExactSpelling = true)]
			internal extern static unsafe bool glXGetSyncValuesOML(IntPtr dpy, IntPtr drawable, Int64* ust, Int64* msc, Int64* sbc);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetMscRateOML", ExactSpelling = true)]
			internal extern static unsafe bool glXGetMscRateOML(IntPtr dpy, IntPtr drawable, Int32* numerator, Int32* denominator);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXSwapBuffersMscOML", ExactSpelling = true)]
			internal extern static unsafe Int64 glXSwapBuffersMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXWaitForMscOML", ExactSpelling = true)]
			internal extern static unsafe bool glXWaitForMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXWaitForSbcOML", ExactSpelling = true)]
			internal extern static unsafe bool glXWaitForSbcOML(IntPtr dpy, IntPtr drawable, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_OML_sync_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXGetSyncValuesOML(IntPtr dpy, IntPtr drawable, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("GLX_OML_sync_control")]
			internal static glXGetSyncValuesOML pglXGetSyncValuesOML;

			[RequiredByFeature("GLX_OML_sync_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXGetMscRateOML(IntPtr dpy, IntPtr drawable, Int32* numerator, Int32* denominator);

			[RequiredByFeature("GLX_OML_sync_control")]
			internal static glXGetMscRateOML pglXGetMscRateOML;

			[RequiredByFeature("GLX_OML_sync_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate Int64 glXSwapBuffersMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder);

			[RequiredByFeature("GLX_OML_sync_control")]
			internal static glXSwapBuffersMscOML pglXSwapBuffersMscOML;

			[RequiredByFeature("GLX_OML_sync_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXWaitForMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("GLX_OML_sync_control")]
			internal static glXWaitForMscOML pglXWaitForMscOML;

			[RequiredByFeature("GLX_OML_sync_control")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool glXWaitForSbcOML(IntPtr dpy, IntPtr drawable, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

			[RequiredByFeature("GLX_OML_sync_control")]
			internal static glXWaitForSbcOML pglXWaitForSbcOML;

		}
	}

}
