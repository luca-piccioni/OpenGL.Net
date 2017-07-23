
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
		/// [GL] Value of GL_COLOR_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int COLOR_ATTACHMENT_EXT = 0x90F0;

		/// <summary>
		/// [GL] Value of GL_MULTIVIEW_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int MULTIVIEW_EXT = 0x90F1;

		/// <summary>
		/// [GL] Value of GL_MAX_MULTIVIEW_BUFFERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;

		/// <summary>
		/// [GL] Binding for glReadBufferIndexedEXT.
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:ReadBufferMode"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public static void ReadBufferIndexedEXT(ReadBufferMode src, Int32 index)
		{
			Debug.Assert(Delegates.pglReadBufferIndexedEXT != null, "pglReadBufferIndexedEXT not implemented");
			Delegates.pglReadBufferIndexedEXT((Int32)src, index);
			LogCommand("glReadBufferIndexedEXT", null, src, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDrawBuffersIndexedEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public static void DrawBuffersIndexedEXT(Int32[] location, Int32[] indices)
		{
			unsafe {
				fixed (Int32* p_location = location)
				fixed (Int32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglDrawBuffersIndexedEXT != null, "pglDrawBuffersIndexedEXT not implemented");
					Delegates.pglDrawBuffersIndexedEXT((Int32)location.Length, p_location, p_indices);
					LogCommand("glDrawBuffersIndexedEXT", null, location.Length, location, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetIntegeri_vEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public static void GetIntegerEXT(Int32 target, UInt32 index, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_vEXT != null, "pglGetIntegeri_vEXT not implemented");
					Delegates.pglGetIntegeri_vEXT(target, index, p_data);
					LogCommand("glGetIntegeri_vEXT", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glReadBufferIndexedEXT", ExactSpelling = true)]
			internal extern static void glReadBufferIndexedEXT(Int32 src, Int32 index);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawBuffersIndexedEXT", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffersIndexedEXT(Int32 n, Int32* location, Int32* indices);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetIntegeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegeri_vEXT(Int32 target, UInt32 index, Int32* data);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glReadBufferIndexedEXT(Int32 src, Int32 index);

			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			[ThreadStatic]
			internal static glReadBufferIndexedEXT pglReadBufferIndexedEXT;

			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDrawBuffersIndexedEXT(Int32 n, Int32* location, Int32* indices);

			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			[ThreadStatic]
			internal static glDrawBuffersIndexedEXT pglDrawBuffersIndexedEXT;

			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetIntegeri_vEXT(Int32 target, UInt32 index, Int32* data);

			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			[ThreadStatic]
			internal static glGetIntegeri_vEXT pglGetIntegeri_vEXT;

		}
	}

}
