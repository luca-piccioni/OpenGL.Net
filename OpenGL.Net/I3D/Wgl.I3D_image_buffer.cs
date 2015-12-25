
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
		/// Value of WGL_IMAGE_BUFFER_MIN_ACCESS_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public const uint IMAGE_BUFFER_MIN_ACCESS_I3D = 0x00000001;

		/// <summary>
		/// Value of WGL_IMAGE_BUFFER_LOCK_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public const uint IMAGE_BUFFER_LOCK_I3D = 0x00000002;

		/// <summary>
		/// Binding for wglCreateImageBufferI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dwSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uFlags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateImageBufferI3D != null, "pwglCreateImageBufferI3D not implemented");
			retValue = Delegates.pwglCreateImageBufferI3D(hDC, dwSize, uFlags);
			LogFunction("wglCreateImageBufferI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), dwSize, uFlags, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDestroyImageBufferI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyImageBufferI3D != null, "pwglDestroyImageBufferI3D not implemented");
			retValue = Delegates.pwglDestroyImageBufferI3D(hDC, pAddress);
			LogFunction("wglDestroyImageBufferI3D(0x{0}, 0x{1}) = {2}", hDC.ToString("X8"), pAddress.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglAssociateImageBufferEventsI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pEvent">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="pSize">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, Int32[] pSize, UInt32 count)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_pEvent = pEvent)
				fixed (IntPtr* p_pAddress = pAddress)
				fixed (Int32* p_pSize = pSize)
				{
					Debug.Assert(Delegates.pwglAssociateImageBufferEventsI3D != null, "pwglAssociateImageBufferEventsI3D not implemented");
					retValue = Delegates.pwglAssociateImageBufferEventsI3D(hDC, p_pEvent, p_pAddress, p_pSize, count);
					LogFunction("wglAssociateImageBufferEventsI3D(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), pEvent, pAddress, pSize, count, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleaseImageBufferEventsI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pAddress">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		public static bool ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr[] pAddress, UInt32 count)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_pAddress = pAddress)
				{
					Debug.Assert(Delegates.pwglReleaseImageBufferEventsI3D != null, "pwglReleaseImageBufferEventsI3D not implemented");
					retValue = Delegates.pwglReleaseImageBufferEventsI3D(hDC, p_pAddress, count);
					LogFunction("wglReleaseImageBufferEventsI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), pAddress, count, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
