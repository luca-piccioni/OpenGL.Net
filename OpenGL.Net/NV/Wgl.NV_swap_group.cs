
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
		/// Binding for wglJoinSwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool JoinSwapGroupNV(IntPtr hDC, UInt32 group)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglJoinSwapGroupNV != null, "pwglJoinSwapGroupNV not implemented");
			retValue = Delegates.pwglJoinSwapGroupNV(hDC, group);
			LogFunction("wglJoinSwapGroupNV(0x{0}, {1}) = {2}", hDC.ToString("X8"), group, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglBindSwapBarrierNV.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool BindSwapBarrierNV(UInt32 group, UInt32 barrier)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindSwapBarrierNV != null, "pwglBindSwapBarrierNV not implemented");
			retValue = Delegates.pwglBindSwapBarrierNV(group, barrier);
			LogFunction("wglBindSwapBarrierNV({0}, {1}) = {2}", group, barrier, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQuerySwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QuerySwapGroupNV(IntPtr hDC, UInt32[] group, UInt32[] barrier)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_group = group)
				fixed (UInt32* p_barrier = barrier)
				{
					Debug.Assert(Delegates.pwglQuerySwapGroupNV != null, "pwglQuerySwapGroupNV not implemented");
					retValue = Delegates.pwglQuerySwapGroupNV(hDC, p_group, p_barrier);
					LogFunction("wglQuerySwapGroupNV(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), group, barrier, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryMaxSwapGroupsNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxGroups">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxBarriers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryMaxSwapGroupsNV(IntPtr hDC, UInt32[] maxGroups, UInt32[] maxBarriers)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_maxGroups = maxGroups)
				fixed (UInt32* p_maxBarriers = maxBarriers)
				{
					Debug.Assert(Delegates.pwglQueryMaxSwapGroupsNV != null, "pwglQueryMaxSwapGroupsNV not implemented");
					retValue = Delegates.pwglQueryMaxSwapGroupsNV(hDC, p_maxGroups, p_maxBarriers);
					LogFunction("wglQueryMaxSwapGroupsNV(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), maxGroups, maxBarriers, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryFrameCountNV(IntPtr hDC, UInt32[] count)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_count = count)
				{
					Debug.Assert(Delegates.pwglQueryFrameCountNV != null, "pwglQueryFrameCountNV not implemented");
					retValue = Delegates.pwglQueryFrameCountNV(hDC, p_count);
					LogFunction("wglQueryFrameCountNV(0x{0}, {1}) = {2}", hDC.ToString("X8"), count, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglResetFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool ResetFrameCountNV(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglResetFrameCountNV != null, "pwglResetFrameCountNV not implemented");
			retValue = Delegates.pwglResetFrameCountNV(hDC);
			LogFunction("wglResetFrameCountNV(0x{0}) = {1}", hDC.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
