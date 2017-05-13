
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
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXSwapIntervalSGI.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGI_swap_control")]
		public static int SwapIntervalSGI(int interval)
		{
			int retValue;

			Debug.Assert(Delegates.pglXSwapIntervalSGI != null, "pglXSwapIntervalSGI not implemented");
			retValue = Delegates.pglXSwapIntervalSGI(interval);
			LogCommand("glXSwapIntervalSGI", retValue, interval			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapIntervalSGI", ExactSpelling = true)]
			internal extern static int glXSwapIntervalSGI(int interval);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGI_swap_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glXSwapIntervalSGI(int interval);

			[RequiredByFeature("GLX_SGI_swap_control")]
			internal static glXSwapIntervalSGI pglXSwapIntervalSGI;

		}
	}

}
