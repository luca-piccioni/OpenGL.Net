
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
		/// Binding for wglEnableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool EnableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnableFrameLockI3D != null, "pwglEnableFrameLockI3D not implemented");
			retValue = Delegates.pwglEnableFrameLockI3D();
			LogFunction("wglEnableFrameLockI3D() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDisableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool DisableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDisableFrameLockI3D != null, "pwglDisableFrameLockI3D not implemented");
			retValue = Delegates.pwglDisableFrameLockI3D();
			LogFunction("wglDisableFrameLockI3D() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglIsEnabledFrameLockI3D.
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
					LogFunction("wglIsEnabledFrameLockI3D({0}) = {1}", LogValue(pFlag), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryFrameLockMasterI3D.
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
					LogFunction("wglQueryFrameLockMasterI3D({0}) = {1}", LogValue(pFlag), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglEnableFrameLockI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDisableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglDisableFrameLockI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglIsEnabledFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglIsEnabledFrameLockI3D(bool* pFlag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryFrameLockMasterI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameLockMasterI3D(bool* pFlag);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglEnableFrameLockI3D();

			[ThreadStatic]
			internal static wglEnableFrameLockI3D pwglEnableFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglDisableFrameLockI3D();

			[ThreadStatic]
			internal static wglDisableFrameLockI3D pwglDisableFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledFrameLockI3D(bool* pFlag);

			[ThreadStatic]
			internal static wglIsEnabledFrameLockI3D pwglIsEnabledFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryFrameLockMasterI3D(bool* pFlag);

			[ThreadStatic]
			internal static wglQueryFrameLockMasterI3D pwglQueryFrameLockMasterI3D;

		}
	}

}
