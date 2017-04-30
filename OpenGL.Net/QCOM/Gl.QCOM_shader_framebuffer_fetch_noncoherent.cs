
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
		/// [GL] Value of GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_shader_framebuffer_fetch_noncoherent", Api = "gles2")]
		public const int FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2;

		/// <summary>
		/// Binding for glFramebufferFetchBarrierQCOM.
		/// </summary>
		[RequiredByFeature("GL_QCOM_shader_framebuffer_fetch_noncoherent", Api = "gles2")]
		public static void FramebufferFetchBarrierQCOM()
		{
			Debug.Assert(Delegates.pglFramebufferFetchBarrierQCOM != null, "pglFramebufferFetchBarrierQCOM not implemented");
			Delegates.pglFramebufferFetchBarrierQCOM();
			LogCommand("glFramebufferFetchBarrierQCOM", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferFetchBarrierQCOM", ExactSpelling = true)]
			internal extern static void glFramebufferFetchBarrierQCOM();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_shader_framebuffer_fetch_noncoherent", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferFetchBarrierQCOM();

			[ThreadStatic]
			internal static glFramebufferFetchBarrierQCOM pglFramebufferFetchBarrierQCOM;

		}
	}

}
