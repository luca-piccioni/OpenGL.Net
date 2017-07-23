
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Binding for wglAllocateMemoryNV.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="readfreq">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="writefreq">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="priority">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_vertex_array_range")]
		public static IntPtr AllocateMemoryNV(Int32 size, float readfreq, float writefreq, float priority)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglAllocateMemoryNV != null, "pwglAllocateMemoryNV not implemented");
			retValue = Delegates.pwglAllocateMemoryNV(size, readfreq, writefreq, priority);
			LogCommand("wglAllocateMemoryNV", retValue, size, readfreq, writefreq, priority			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglFreeMemoryNV.
		/// </summary>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_vertex_array_range")]
		public static void FreeMemoryNV(IntPtr pointer)
		{
			Debug.Assert(Delegates.pwglFreeMemoryNV != null, "pwglFreeMemoryNV not implemented");
			Delegates.pwglFreeMemoryNV(pointer);
			LogCommand("wglFreeMemoryNV", null, pointer			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglAllocateMemoryNV", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglAllocateMemoryNV(Int32 size, float readfreq, float writefreq, float priority);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglFreeMemoryNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglFreeMemoryNV(IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_vertex_array_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr wglAllocateMemoryNV(Int32 size, float readfreq, float writefreq, float priority);

			[RequiredByFeature("WGL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static wglAllocateMemoryNV pwglAllocateMemoryNV;

			[RequiredByFeature("WGL_NV_vertex_array_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void wglFreeMemoryNV(IntPtr pointer);

			[RequiredByFeature("WGL_NV_vertex_array_range")]
			[ThreadStatic]
			internal static wglFreeMemoryNV pwglFreeMemoryNV;

		}
	}

}
