
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glGetDriverControlsQCOM.
		/// </summary>
		/// <param name="num">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControls">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void GetDriverControlsQCOM([Out] Int32[] num, [Out] UInt32[] driverControls)
		{
			unsafe {
				fixed (Int32* p_num = num)
				fixed (UInt32* p_driverControls = driverControls)
				{
					Debug.Assert(Delegates.pglGetDriverControlsQCOM != null, "pglGetDriverControlsQCOM not implemented");
					Delegates.pglGetDriverControlsQCOM(p_num, (Int32)driverControls.Length, p_driverControls);
					LogFunction("glGetDriverControlsQCOM({0}, {1}, {2})", LogValue(num), driverControls.Length, LogValue(driverControls));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetDriverControlStringQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControlString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder driverControlString)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglGetDriverControlStringQCOM != null, "pglGetDriverControlStringQCOM not implemented");
					Delegates.pglGetDriverControlStringQCOM(driverControl, bufSize, p_length, driverControlString);
					LogFunction("glGetDriverControlStringQCOM({0}, {1}, {2}, {3})", driverControl, bufSize, LogValue(length), driverControlString);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEnableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void EnableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglEnableDriverControlQCOM != null, "pglEnableDriverControlQCOM not implemented");
			Delegates.pglEnableDriverControlQCOM(driverControl);
			LogFunction("glEnableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_driver_control", Api = "gles1|gles2")]
		public static void DisableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglDisableDriverControlQCOM != null, "pglDisableDriverControlQCOM not implemented");
			Delegates.pglDisableDriverControlQCOM(driverControl);
			LogFunction("glDisableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors(null);
		}

	}

}
