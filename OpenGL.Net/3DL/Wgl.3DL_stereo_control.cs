
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_STEREO_EMITTER_ENABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_ENABLE_3DL = 0x2055;

		/// <summary>
		/// Value of WGL_STEREO_EMITTER_DISABLE_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_EMITTER_DISABLE_3DL = 0x2056;

		/// <summary>
		/// Value of WGL_STEREO_POLARITY_NORMAL_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_NORMAL_3DL = 0x2057;

		/// <summary>
		/// Value of WGL_STEREO_POLARITY_INVERT_3DL symbol.
		/// </summary>
		[RequiredByFeature("WGL_3DL_stereo_control")]
		public const int STEREO_POLARITY_INVERT_3DL = 0x2058;

		/// <summary>
		/// Binding for wglSetStereoEmitterState3DL.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uState">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool SetStereoEmitter3DL(IntPtr hDC, UInt32 uState)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSetStereoEmitterState3DL != null, "pwglSetStereoEmitterState3DL not implemented");
			retValue = Delegates.pwglSetStereoEmitterState3DL(hDC, uState);
			CallLog("wglSetStereoEmitterState3DL({0}, {1}) = {2}", hDC, uState, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
