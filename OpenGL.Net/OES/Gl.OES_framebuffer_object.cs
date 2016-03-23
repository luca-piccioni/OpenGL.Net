
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
			LogFunction("glIsRenderbufferOES({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindRenderbufferOES(Int32 target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferOES != null, "pglBindRenderbufferOES not implemented");
			Delegates.pglBindRenderbufferOES(target, renderbuffer);
			LogFunction("glBindRenderbufferOES({0}, {1})", LogEnumName(target), renderbuffer);
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
					LogFunction("glDeleteRenderbuffersOES({0}, {1})", renderbuffers.Length, LogValue(renderbuffers));
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
					LogFunction("glGenRenderbuffersOES({0}, {1})", renderbuffers.Length, LogValue(renderbuffers));
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void RenderbufferStorageOES(Int32 target, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageOES != null, "pglRenderbufferStorageOES not implemented");
			Delegates.pglRenderbufferStorageOES(target, internalformat, width, height);
			LogFunction("glRenderbufferStorageOES({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetRenderbufferParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetRenderbufferParameterOES(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivOES != null, "pglGetRenderbufferParameterivOES not implemented");
					Delegates.pglGetRenderbufferParameterivOES(target, pname, p_params);
					LogFunction("glGetRenderbufferParameterivOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
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
			LogFunction("glIsFramebufferOES({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindFramebufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindFramebufferOES(Int32 target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferOES != null, "pglBindFramebufferOES not implemented");
			Delegates.pglBindFramebufferOES(target, framebuffer);
			LogFunction("glBindFramebufferOES({0}, {1})", LogEnumName(target), framebuffer);
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
					LogFunction("glDeleteFramebuffersOES({0}, {1})", framebuffers.Length, LogValue(framebuffers));
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
					LogFunction("glGenFramebuffersOES({0}, {1})", framebuffers.Length, LogValue(framebuffers));
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static Int32 CheckFramebufferStatusOES(Int32 target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusOES != null, "pglCheckFramebufferStatusOES not implemented");
			retValue = Delegates.pglCheckFramebufferStatusOES(target);
			LogFunction("glCheckFramebufferStatusOES({0}) = {1}", LogEnumName(target), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFramebufferRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferRenderbufferOES(Int32 target, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferOES != null, "pglFramebufferRenderbufferOES not implemented");
			Delegates.pglFramebufferRenderbufferOES(target, attachment, renderbuffertarget, renderbuffer);
			LogFunction("glFramebufferRenderbufferOES({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(attachment), LogEnumName(renderbuffertarget), renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferTexture2DOES(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DOES != null, "pglFramebufferTexture2DOES not implemented");
			Delegates.pglFramebufferTexture2DOES(target, attachment, textarget, texture, level);
			LogFunction("glFramebufferTexture2DOES({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(attachment), LogEnumName(textarget), texture, level);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFramebufferAttachmentParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetFramebufferAttachmentParameterOES(Int32 target, Int32 attachment, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivOES != null, "pglGetFramebufferAttachmentParameterivOES not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivOES(target, attachment, pname, p_params);
					LogFunction("glGetFramebufferAttachmentParameterivOES({0}, {1}, {2}, {3})", LogEnumName(target), LogEnumName(attachment), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenerateMipmapOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenerateMipmapOES(Int32 target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapOES != null, "pglGenerateMipmapOES not implemented");
			Delegates.pglGenerateMipmapOES(target);
			LogFunction("glGenerateMipmapOES({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

	}

}
