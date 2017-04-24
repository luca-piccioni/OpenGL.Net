
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
	public partial class Gl
	{
		/// <summary>
		/// Binding for glDrawVkImageNV.
		/// </summary>
		/// <param name="vkImage">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="s0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="s1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t1">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
		public static void DrawVkImageNV(UInt64 vkImage, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
		{
			Debug.Assert(Delegates.pglDrawVkImageNV != null, "pglDrawVkImageNV not implemented");
			Delegates.pglDrawVkImageNV(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
			LogCommand("glDrawVkImageNV", null, vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVkProcAddrNV.
		/// </summary>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
		public static Gl.VulkanProc GetVkProcAddrNV(String name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglGetVkProcAddrNV != null, "pglGetVkProcAddrNV not implemented");
			retValue = Delegates.pglGetVkProcAddrNV(name);
			LogCommand("glGetVkProcAddrNV", (Gl.VulkanProc)Marshal.PtrToStructure(retValue, typeof(Gl.VulkanProc)), name			);
			DebugCheckErrors(retValue);

			return ((Gl.VulkanProc)Marshal.PtrToStructure(retValue, typeof(Gl.VulkanProc)));
		}

		/// <summary>
		/// Binding for glWaitVkSemaphoreNV.
		/// </summary>
		/// <param name="vkSemaphore">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
		public static void WaitVkSemaphoreNV(UInt64 vkSemaphore)
		{
			Debug.Assert(Delegates.pglWaitVkSemaphoreNV != null, "pglWaitVkSemaphoreNV not implemented");
			Delegates.pglWaitVkSemaphoreNV(vkSemaphore);
			LogCommand("glWaitVkSemaphoreNV", null, vkSemaphore			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSignalVkSemaphoreNV.
		/// </summary>
		/// <param name="vkSemaphore">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
		public static void SignalVkSemaphoreNV(UInt64 vkSemaphore)
		{
			Debug.Assert(Delegates.pglSignalVkSemaphoreNV != null, "pglSignalVkSemaphoreNV not implemented");
			Delegates.pglSignalVkSemaphoreNV(vkSemaphore);
			LogCommand("glSignalVkSemaphoreNV", null, vkSemaphore			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSignalVkFenceNV.
		/// </summary>
		/// <param name="vkFence">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
		public static void SignalVkFenceNV(UInt64 vkFence)
		{
			Debug.Assert(Delegates.pglSignalVkFenceNV != null, "pglSignalVkFenceNV not implemented");
			Delegates.pglSignalVkFenceNV(vkFence);
			LogCommand("glSignalVkFenceNV", null, vkFence			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawVkImageNV", ExactSpelling = true)]
			internal extern static void glDrawVkImageNV(UInt64 vkImage, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVkProcAddrNV", ExactSpelling = true)]
			internal extern static IntPtr glGetVkProcAddrNV(String name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWaitVkSemaphoreNV", ExactSpelling = true)]
			internal extern static void glWaitVkSemaphoreNV(UInt64 vkSemaphore);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSignalVkSemaphoreNV", ExactSpelling = true)]
			internal extern static void glSignalVkSemaphoreNV(UInt64 vkSemaphore);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSignalVkFenceNV", ExactSpelling = true)]
			internal extern static void glSignalVkFenceNV(UInt64 vkFence);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawVkImageNV(UInt64 vkImage, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

			[ThreadStatic]
			internal static glDrawVkImageNV pglDrawVkImageNV;

			[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetVkProcAddrNV(String name);

			[ThreadStatic]
			internal static glGetVkProcAddrNV pglGetVkProcAddrNV;

			[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWaitVkSemaphoreNV(UInt64 vkSemaphore);

			[ThreadStatic]
			internal static glWaitVkSemaphoreNV pglWaitVkSemaphoreNV;

			[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSignalVkSemaphoreNV(UInt64 vkSemaphore);

			[ThreadStatic]
			internal static glSignalVkSemaphoreNV pglSignalVkSemaphoreNV;

			[RequiredByFeature("GL_NV_draw_vulkan_image", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSignalVkFenceNV(UInt64 vkFence);

			[ThreadStatic]
			internal static glSignalVkFenceNV pglSignalVkFenceNV;

		}
	}

}
