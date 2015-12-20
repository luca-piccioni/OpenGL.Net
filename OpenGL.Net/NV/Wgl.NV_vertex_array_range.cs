
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
		/// Binding for wglAllocateMemoryNV.
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
			CallLog("wglAllocateMemoryNV({0}, {1}, {2}, {3}) = {4}", size, readfreq, writefreq, priority, retValue.ToString("X8"));
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for wglFreeMemoryNV.
		/// </summary>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_vertex_array_range")]
		public static void FreeMemoryNV(IntPtr pointer)
		{
			Debug.Assert(Delegates.pwglFreeMemoryNV != null, "pwglFreeMemoryNV not implemented");
			Delegates.pwglFreeMemoryNV(pointer);
			CallLog("wglFreeMemoryNV(0x{0})", pointer.ToString("X8"));
			DebugCheckErrors();
		}

	}

}
