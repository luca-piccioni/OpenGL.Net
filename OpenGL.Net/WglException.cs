
// Copyright (C) 2015-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.ComponentModel;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// Exception thrown by Wgl class.
	/// </summary>
	public sealed class WglException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a WglException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		internal WglException(int errorCode) :
			base(errorCode, GetErrorMessage(errorCode), new Win32Exception(errorCode))
		{

		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="errorCode"></param>
		/// <returns>
		/// It returns a description of <paramref name="errorCode"/>, asssuming that is a value returned
		/// by <see cref="Gl.GetError"/>.
		/// </returns>
		private static string GetErrorMessage(int errorCode)
		{
			switch (errorCode) {

				default:
					return $"unknown error code 0x{errorCode:X8}";
				case Gl.NO_ERROR:
					return "no error";

				// WGL_ARB_create_context
				case Wgl.ERROR_INVALID_VERSION_ARB:
					return "invalid version";
				// WGL_ARB_create_context_profile
				case Wgl.ERROR_INVALID_PROFILE_ARB:
					return "invalid profile";
				// WGL_ARB_make_current_read
				case Wgl.ERROR_INVALID_PIXEL_TYPE_ARB:
					return "invalid pixel type";
				case Wgl.ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB:
					return "incompatible device contexts";
				// WGL_NV_gpu_affinity
				case Wgl.ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV:
					return "incompatible affinity mask";
				case Wgl.ERROR_MISSING_AFFINITY_MASK_NV:
					return "missing affinity mask";
			}
		}

		#endregion
	}
}
