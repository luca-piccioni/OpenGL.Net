
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
		/// Binding for glXGetProcAddressARB.
		/// </summary>
		/// <param name="procName">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GLX_ARB_get_proc_address")]
		public static IntPtr GetProcAddressARB(byte[] procName)
		{
			IntPtr retValue;

			unsafe {
				fixed (byte* p_procName = procName)
				{
					Debug.Assert(Delegates.pglXGetProcAddressARB != null, "pglXGetProcAddressARB not implemented");
					retValue = Delegates.pglXGetProcAddressARB(p_procName);
					LogFunction("glXGetProcAddressARB({0}) = {1}", LogValue(procName), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetProcAddressARB", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetProcAddressARB(byte* procName);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_ARB_get_proc_address")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetProcAddressARB(byte* procName);

			internal static glXGetProcAddressARB pglXGetProcAddressARB;

		}
	}

}
