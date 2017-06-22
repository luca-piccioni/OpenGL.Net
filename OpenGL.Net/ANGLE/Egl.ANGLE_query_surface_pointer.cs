
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
		/// [EGL] Binding for eglQuerySurfacePointerANGLE.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_ANGLE_query_surface_pointer")]
		public static bool QuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQuerySurfacePointerANGLE != null, "peglQuerySurfacePointerANGLE not implemented");
					retValue = Delegates.peglQuerySurfacePointerANGLE(dpy, surface, attribute, p_value);
					LogCommand("eglQuerySurfacePointerANGLE", retValue, dpy, surface, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQuerySurfacePointerANGLE", ExactSpelling = true)]
			internal extern static unsafe bool eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_ANGLE_query_surface_pointer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_ANGLE_query_surface_pointer")]
			internal static eglQuerySurfacePointerANGLE peglQuerySurfacePointerANGLE;

		}
	}

}
