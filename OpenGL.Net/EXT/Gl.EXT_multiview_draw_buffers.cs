
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int COLOR_ATTACHMENT_EXT = 0x90F0;

		/// <summary>
		/// Value of GL_MULTIVIEW_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int MULTIVIEW_EXT = 0x90F1;

		/// <summary>
		/// Value of GL_MAX_MULTIVIEW_BUFFERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;

		/// <summary>
		/// Binding for glReadBufferIndexedEXT.
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public static void ReadBufferIndexedEXT(Int32 src, Int32 index)
		{
			Debug.Assert(Delegates.pglReadBufferIndexedEXT != null, "pglReadBufferIndexedEXT not implemented");
			Delegates.pglReadBufferIndexedEXT(src, index);
			LogFunction("glReadBufferIndexedEXT({0}, {1})", LogEnumName(src), index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawBuffersIndexedEXT.
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
					LogFunction("glDrawBuffersIndexedEXT({0}, {1}, {2})", location.Length, LogEnumName(location), LogValue(indices));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetIntegeri_vEXT.
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
					LogFunction("glGetIntegeri_vEXT({0}, {1}, {2})", LogEnumName(target), index, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
