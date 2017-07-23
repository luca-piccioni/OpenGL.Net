
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
		/// [WGL] Binding for wglEnableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool EnableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnableFrameLockI3D != null, "pwglEnableFrameLockI3D not implemented");
			retValue = Delegates.pwglEnableFrameLockI3D();
			LogCommand("wglEnableFrameLockI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDisableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool DisableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDisableFrameLockI3D != null, "pwglDisableFrameLockI3D not implemented");
			retValue = Delegates.pwglDisableFrameLockI3D();
			LogCommand("wglDisableFrameLockI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglIsEnabledFrameLockI3D.
		/// </summary>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool IsEnabledFrameLockI3D([Out] bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglIsEnabledFrameLockI3D != null, "pwglIsEnabledFrameLockI3D not implemented");
					retValue = Delegates.pwglIsEnabledFrameLockI3D(p_pFlag);
					LogCommand("wglIsEnabledFrameLockI3D", retValue, pFlag					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglQueryFrameLockMasterI3D.
		/// </summary>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool QueryFrameLockMasterI3D(bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglQueryFrameLockMasterI3D != null, "pwglQueryFrameLockMasterI3D not implemented");
					retValue = Delegates.pwglQueryFrameLockMasterI3D(p_pFlag);
					LogCommand("wglQueryFrameLockMasterI3D", retValue, pFlag					);
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
			[DllImport(Library, EntryPoint = "wglEnableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglEnableFrameLockI3D();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDisableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglDisableFrameLockI3D();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglIsEnabledFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglIsEnabledFrameLockI3D(bool* pFlag);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryFrameLockMasterI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameLockMasterI3D(bool* pFlag);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool wglEnableFrameLockI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[ThreadStatic]
			internal static wglEnableFrameLockI3D pwglEnableFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool wglDisableFrameLockI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[ThreadStatic]
			internal static wglDisableFrameLockI3D pwglDisableFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglIsEnabledFrameLockI3D(bool* pFlag);

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[ThreadStatic]
			internal static wglIsEnabledFrameLockI3D pwglIsEnabledFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryFrameLockMasterI3D(bool* pFlag);

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[ThreadStatic]
			internal static wglQueryFrameLockMasterI3D pwglQueryFrameLockMasterI3D;

		}
	}

}
