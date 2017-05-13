
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
		/// Binding for glIsRenderbufferOES.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static bool IsRenderbufferOES(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbufferOES != null, "pglIsRenderbufferOES not implemented");
			retValue = Delegates.pglIsRenderbufferOES(renderbuffer);
			LogCommand("glIsRenderbufferOES", retValue, renderbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindRenderbufferOES(RenderbufferTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferOES != null, "pglBindRenderbufferOES not implemented");
			Delegates.pglBindRenderbufferOES((Int32)target, renderbuffer);
			LogCommand("glBindRenderbufferOES", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteRenderbuffersOES.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void DeleteRenderbuffersOES(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersOES != null, "pglDeleteRenderbuffersOES not implemented");
					Delegates.pglDeleteRenderbuffersOES((Int32)renderbuffers.Length, p_renderbuffers);
					LogCommand("glDeleteRenderbuffersOES", null, renderbuffers.Length, renderbuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenRenderbuffersOES.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenRenderbuffersOES(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersOES != null, "pglGenRenderbuffersOES not implemented");
					Delegates.pglGenRenderbuffersOES((Int32)renderbuffers.Length, p_renderbuffers);
					LogCommand("glGenRenderbuffersOES", null, renderbuffers.Length, renderbuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenRenderbuffersOES.
		/// </summary>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static UInt32 GenRenderbuffersOES()
		{
			UInt32[] retValue = new UInt32[1];
			GenRenderbuffersOES(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageOES != null, "pglRenderbufferStorageOES not implemented");
			Delegates.pglRenderbufferStorageOES((Int32)target, (Int32)internalformat, width, height);
			LogCommand("glRenderbufferStorageOES", null, target, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetRenderbufferParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:RenderbufferParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetRenderbufferParameterOES(RenderbufferTarget target, RenderbufferParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivOES != null, "pglGetRenderbufferParameterivOES not implemented");
					Delegates.pglGetRenderbufferParameterivOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetRenderbufferParameterivOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsFramebufferOES.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static bool IsFramebufferOES(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebufferOES != null, "pglIsFramebufferOES not implemented");
			retValue = Delegates.pglIsFramebufferOES(framebuffer);
			LogCommand("glIsFramebufferOES", retValue, framebuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindFramebufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindFramebufferOES(FramebufferTarget target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferOES != null, "pglBindFramebufferOES not implemented");
			Delegates.pglBindFramebufferOES((Int32)target, framebuffer);
			LogCommand("glBindFramebufferOES", null, target, framebuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteFramebuffersOES.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void DeleteFramebuffersOES(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersOES != null, "pglDeleteFramebuffersOES not implemented");
					Delegates.pglDeleteFramebuffersOES((Int32)framebuffers.Length, p_framebuffers);
					LogCommand("glDeleteFramebuffersOES", null, framebuffers.Length, framebuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFramebuffersOES.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenFramebuffersOES(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersOES != null, "pglGenFramebuffersOES not implemented");
					Delegates.pglGenFramebuffersOES((Int32)framebuffers.Length, p_framebuffers);
					LogCommand("glGenFramebuffersOES", null, framebuffers.Length, framebuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFramebuffersOES.
		/// </summary>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static UInt32 GenFramebuffersOES()
		{
			UInt32[] retValue = new UInt32[1];
			GenFramebuffersOES(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glCheckFramebufferStatusOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusOES != null, "pglCheckFramebufferStatusOES not implemented");
			retValue = Delegates.pglCheckFramebufferStatusOES((Int32)target);
			LogCommand("glCheckFramebufferStatusOES", (FramebufferStatus)retValue, target			);
			DebugCheckErrors(retValue);

			return ((FramebufferStatus)retValue);
		}

		/// <summary>
		/// Binding for glFramebufferRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferOES != null, "pglFramebufferRenderbufferOES not implemented");
			Delegates.pglFramebufferRenderbufferOES((Int32)target, (Int32)attachment, (Int32)renderbuffertarget, renderbuffer);
			LogCommand("glFramebufferRenderbufferOES", null, target, attachment, renderbuffertarget, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DOES != null, "pglFramebufferTexture2DOES not implemented");
			Delegates.pglFramebufferTexture2DOES((Int32)target, (Int32)attachment, (Int32)textarget, texture, level);
			LogCommand("glFramebufferTexture2DOES", null, target, attachment, textarget, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFramebufferAttachmentParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:FramebufferAttachmentParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetFramebufferAttachmentParameterOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivOES != null, "pglGetFramebufferAttachmentParameterivOES not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivOES((Int32)target, (Int32)attachment, (Int32)pname, p_params);
					LogCommand("glGetFramebufferAttachmentParameterivOES", null, target, attachment, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenerateMipmapOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenerateMipmapOES(TextureTarget target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapOES != null, "pglGenerateMipmapOES not implemented");
			Delegates.pglGenerateMipmapOES((Int32)target);
			LogCommand("glGenerateMipmapOES", null, target			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsRenderbufferOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsRenderbufferOES(UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindRenderbufferOES", ExactSpelling = true)]
			internal extern static void glBindRenderbufferOES(Int32 target, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteRenderbuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenRenderbuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glGenRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderbufferStorageOES", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageOES(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetRenderbufferParameterivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetRenderbufferParameterivOES(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsFramebufferOES", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFramebufferOES(UInt32 framebuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindFramebufferOES", ExactSpelling = true)]
			internal extern static void glBindFramebufferOES(Int32 target, UInt32 framebuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteFramebuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenFramebuffersOES", ExactSpelling = true)]
			internal extern static unsafe void glGenFramebuffersOES(Int32 n, UInt32* framebuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCheckFramebufferStatusOES", ExactSpelling = true)]
			internal extern static Int32 glCheckFramebufferStatusOES(Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferRenderbufferOES", ExactSpelling = true)]
			internal extern static void glFramebufferRenderbufferOES(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTexture2DOES", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameterivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferAttachmentParameterivOES(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenerateMipmapOES", ExactSpelling = true)]
			internal extern static void glGenerateMipmapOES(Int32 target);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsRenderbufferOES(UInt32 renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glIsRenderbufferOES pglIsRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindRenderbufferOES(Int32 target, UInt32 renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glBindRenderbufferOES pglBindRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glDeleteRenderbuffersOES pglDeleteRenderbuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenRenderbuffersOES(Int32 n, UInt32* renderbuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenRenderbuffersOES pglGenRenderbuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageOES(Int32 target, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glRenderbufferStorageOES pglRenderbufferStorageOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetRenderbufferParameterivOES(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGetRenderbufferParameterivOES pglGetRenderbufferParameterivOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFramebufferOES(UInt32 framebuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glIsFramebufferOES pglIsFramebufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFramebufferOES(Int32 target, UInt32 framebuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glBindFramebufferOES pglBindFramebufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glDeleteFramebuffersOES pglDeleteFramebuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFramebuffersOES(Int32 n, UInt32* framebuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenFramebuffersOES pglGenFramebuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glCheckFramebufferStatusOES(Int32 target);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glCheckFramebufferStatusOES pglCheckFramebufferStatusOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferRenderbufferOES(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glFramebufferRenderbufferOES pglFramebufferRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture2DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glFramebufferTexture2DOES pglFramebufferTexture2DOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferAttachmentParameterivOES(Int32 target, Int32 attachment, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameterivOES pglGetFramebufferAttachmentParameterivOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateMipmapOES(Int32 target);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenerateMipmapOES pglGenerateMipmapOES;

		}
	}

}
