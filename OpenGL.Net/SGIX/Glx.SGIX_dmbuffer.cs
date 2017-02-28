
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
		/// Value of GLX_DIGITAL_MEDIA_PBUFFER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_dmbuffer")]
		public const int DIGITAL_MEDIA_PBUFFER_SGIX = 0x8024;

		/// <summary>
		/// Binding for glXAssociateDMPbufferSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="dmbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_dmbuffer")]
		public static bool AssociateDMPbufferSGIX(IntPtr dpy, IntPtr pbuffer, IntPtr[] @params, IntPtr dmbuffer)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglXAssociateDMPbufferSGIX != null, "pglXAssociateDMPbufferSGIX not implemented");
					retValue = Delegates.pglXAssociateDMPbufferSGIX(dpy, pbuffer, p_params, dmbuffer);
					LogFunction("glXAssociateDMPbufferSGIX(0x{0}, 0x{1}, {2}, 0x{3}) = {4}", dpy.ToString("X8"), pbuffer.ToString("X8"), LogValue(@params), dmbuffer.ToString("X8"), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXAssociateDMPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe bool glXAssociateDMPbufferSGIX(IntPtr dpy, IntPtr pbuffer, IntPtr* @params, IntPtr dmbuffer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_dmbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXAssociateDMPbufferSGIX(IntPtr dpy, IntPtr pbuffer, IntPtr* @params, IntPtr dmbuffer);

			internal static glXAssociateDMPbufferSGIX pglXAssociateDMPbufferSGIX;

		}
	}

}
