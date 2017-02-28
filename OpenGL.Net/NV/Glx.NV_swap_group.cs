
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Binding for glXJoinSwapGroupNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool JoinSwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32 group)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXJoinSwapGroupNV != null, "pglXJoinSwapGroupNV not implemented");
			retValue = Delegates.pglXJoinSwapGroupNV(dpy, drawable, group);
			LogFunction("glXJoinSwapGroupNV(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), drawable.ToString("X8"), group, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXBindSwapBarrierNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool BindSwapBarrierNV(IntPtr dpy, UInt32 group, UInt32 barrier)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXBindSwapBarrierNV != null, "pglXBindSwapBarrierNV not implemented");
			retValue = Delegates.pglXBindSwapBarrierNV(dpy, group, barrier);
			LogFunction("glXBindSwapBarrierNV(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), group, barrier, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQuerySwapGroupNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool QuerySwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32[] group, UInt32[] barrier)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_group = group)
				fixed (UInt32* p_barrier = barrier)
				{
					Debug.Assert(Delegates.pglXQuerySwapGroupNV != null, "pglXQuerySwapGroupNV not implemented");
					retValue = Delegates.pglXQuerySwapGroupNV(dpy, drawable, p_group, p_barrier);
					LogFunction("glXQuerySwapGroupNV(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), drawable.ToString("X8"), LogValue(group), LogValue(barrier), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryMaxSwapGroupsNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="maxGroups">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxBarriers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool QueryMaxSwapGroupsNV(IntPtr dpy, int screen, UInt32[] maxGroups, UInt32[] maxBarriers)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_maxGroups = maxGroups)
				fixed (UInt32* p_maxBarriers = maxBarriers)
				{
					Debug.Assert(Delegates.pglXQueryMaxSwapGroupsNV != null, "pglXQueryMaxSwapGroupsNV not implemented");
					retValue = Delegates.pglXQueryMaxSwapGroupsNV(dpy, screen, p_maxGroups, p_maxBarriers);
					LogFunction("glXQueryMaxSwapGroupsNV(0x{0}, {1}, {2}, {3}) = {4}", dpy.ToString("X8"), screen, LogValue(maxGroups), LogValue(maxBarriers), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryFrameCountNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool QueryFrameCountNV(IntPtr dpy, int screen, UInt32[] count)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_count = count)
				{
					Debug.Assert(Delegates.pglXQueryFrameCountNV != null, "pglXQueryFrameCountNV not implemented");
					retValue = Delegates.pglXQueryFrameCountNV(dpy, screen, p_count);
					LogFunction("glXQueryFrameCountNV(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), screen, LogValue(count), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXResetFrameCountNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_swap_group")]
		public static bool ResetFrameCountNV(IntPtr dpy, int screen)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXResetFrameCountNV != null, "pglXResetFrameCountNV not implemented");
			retValue = Delegates.pglXResetFrameCountNV(dpy, screen);
			LogFunction("glXResetFrameCountNV(0x{0}, {1}) = {2}", dpy.ToString("X8"), screen, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXJoinSwapGroupNV", ExactSpelling = true)]
			internal extern static unsafe bool glXJoinSwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32 group);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindSwapBarrierNV", ExactSpelling = true)]
			internal extern static unsafe bool glXBindSwapBarrierNV(IntPtr dpy, UInt32 group, UInt32 barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQuerySwapGroupNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQuerySwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32* group, UInt32* barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryMaxSwapGroupsNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryMaxSwapGroupsNV(IntPtr dpy, int screen, UInt32* maxGroups, UInt32* maxBarriers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryFrameCountNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryFrameCountNV(IntPtr dpy, int screen, UInt32* count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXResetFrameCountNV", ExactSpelling = true)]
			internal extern static unsafe bool glXResetFrameCountNV(IntPtr dpy, int screen);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXJoinSwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32 group);

			internal static glXJoinSwapGroupNV pglXJoinSwapGroupNV;

			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXBindSwapBarrierNV(IntPtr dpy, UInt32 group, UInt32 barrier);

			internal static glXBindSwapBarrierNV pglXBindSwapBarrierNV;

			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQuerySwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32* group, UInt32* barrier);

			internal static glXQuerySwapGroupNV pglXQuerySwapGroupNV;

			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryMaxSwapGroupsNV(IntPtr dpy, int screen, UInt32* maxGroups, UInt32* maxBarriers);

			internal static glXQueryMaxSwapGroupsNV pglXQueryMaxSwapGroupsNV;

			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryFrameCountNV(IntPtr dpy, int screen, UInt32* count);

			internal static glXQueryFrameCountNV pglXQueryFrameCountNV;

			[RequiredByFeature("GLX_NV_swap_group")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXResetFrameCountNV(IntPtr dpy, int screen);

			internal static glXResetFrameCountNV pglXResetFrameCountNV;

		}
	}

}
