
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
					LogFunction("wglIsEnabledFrameLockI3D({0}) = {1}", pFlag, retValue);
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
					LogFunction("wglQueryFrameLockMasterI3D({0}) = {1}", pFlag, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
