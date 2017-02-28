
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_IMAGE_BUFFER_MIN_ACCESS_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		[Log(BitmaskName = "WGLImageBufferMaskI3D")]
		public const int IMAGE_BUFFER_MIN_ACCESS_I3D = 0x00000001;

		/// <summary>
		/// Value of WGL_IMAGE_BUFFER_LOCK_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_image_buffer")]
		[Log(BitmaskName = "WGLImageBufferMaskI3D")]
		public const int IMAGE_BUFFER_LOCK_I3D = 0x00000002;

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
					LogFunction("wglAssociateImageBufferEventsI3D(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), LogValue(pEvent), LogValue(pAddress), LogValue(pSize), count, retValue);
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
					LogFunction("wglReleaseImageBufferEventsI3D(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), LogValue(pAddress), count, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglAssociateImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_image_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);

			[ThreadStatic]
			internal static wglCreateImageBufferI3D pwglCreateImageBufferI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);

			[ThreadStatic]
			internal static wglDestroyImageBufferI3D pwglDestroyImageBufferI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);

			[ThreadStatic]
			internal static wglAssociateImageBufferEventsI3D pwglAssociateImageBufferEventsI3D;

			[RequiredByFeature("WGL_I3D_image_buffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);

			[ThreadStatic]
			internal static wglReleaseImageBufferEventsI3D pwglReleaseImageBufferEventsI3D;

		}
	}

}
