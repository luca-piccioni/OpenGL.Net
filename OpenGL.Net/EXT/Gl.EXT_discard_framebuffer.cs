
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
	public partial class Gl
	{
		/// <summary>
		/// Binding for glDiscardFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachments">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		public static void DiscardFramebufferEXT(Int32 target, Int32[] attachments)
		{
			unsafe {
				fixed (Int32* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglDiscardFramebufferEXT != null, "pglDiscardFramebufferEXT not implemented");
					Delegates.pglDiscardFramebufferEXT(target, (Int32)attachments.Length, p_attachments);
					LogFunction("glDiscardFramebufferEXT({0}, {1}, {2})", LogEnumName(target), attachments.Length, LogEnumName(attachments));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDiscardFramebufferEXT", ExactSpelling = true)]
			internal extern static unsafe void glDiscardFramebufferEXT(Int32 target, Int32 numAttachments, Int32* attachments);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDiscardFramebufferEXT(Int32 target, Int32 numAttachments, Int32* attachments);

			[ThreadStatic]
			internal static glDiscardFramebufferEXT pglDiscardFramebufferEXT;

		}
	}

}
