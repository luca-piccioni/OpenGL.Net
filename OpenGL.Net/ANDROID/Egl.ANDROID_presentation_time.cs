
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
	public partial class Egl
	{
		/// <summary>
		/// Binding for eglPresentationTimeANDROID.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="time">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("EGL_ANDROID_presentation_time")]
		public static bool PresentationTimeANDROID(IntPtr dpy, IntPtr surface, Int64 time)
		{
			bool retValue;

			Debug.Assert(Delegates.peglPresentationTimeANDROID != null, "peglPresentationTimeANDROID not implemented");
			retValue = Delegates.peglPresentationTimeANDROID(dpy, surface, time);
			LogCommand("eglPresentationTimeANDROID", retValue, dpy, surface, time			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglPresentationTimeANDROID", ExactSpelling = true)]
			internal extern static unsafe bool eglPresentationTimeANDROID(IntPtr dpy, IntPtr surface, Int64 time);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_ANDROID_presentation_time")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglPresentationTimeANDROID(IntPtr dpy, IntPtr surface, Int64 time);

			internal static eglPresentationTimeANDROID peglPresentationTimeANDROID;

		}
	}

}
