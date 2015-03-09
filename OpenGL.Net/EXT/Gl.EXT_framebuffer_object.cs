
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
		/// Value of GL_INVALID_FRAMEBUFFER_OPERATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;

		/// <summary>
		/// Value of GL_MAX_RENDERBUFFER_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_BINDING_EXT = 0x8CA6;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_BINDING_EXT = 0x8CA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_COMPLETE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNSUPPORTED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;

		/// <summary>
		/// Value of GL_MAX_COLOR_ATTACHMENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT0_EXT = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT1_EXT = 0x8CE1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT2_EXT = 0x8CE2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT3_EXT = 0x8CE3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT4_EXT = 0x8CE4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT5_EXT = 0x8CE5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT6_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT6_EXT = 0x8CE6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT7_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT7_EXT = 0x8CE7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT8_EXT = 0x8CE8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT9_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT9_EXT = 0x8CE9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT10_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT10_EXT = 0x8CEA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT11_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT11_EXT = 0x8CEB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT12_EXT = 0x8CEC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT13_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT13_EXT = 0x8CED;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT14_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT14_EXT = 0x8CEE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT15_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int COLOR_ATTACHMENT15_EXT = 0x8CEF;

		/// <summary>
		/// Value of GL_DEPTH_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int DEPTH_ATTACHMENT_EXT = 0x8D00;

		/// <summary>
		/// Value of GL_STENCIL_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_ATTACHMENT_EXT = 0x8D20;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int FRAMEBUFFER_EXT = 0x8D40;

		/// <summary>
		/// Value of GL_RENDERBUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_EXT = 0x8D41;

		/// <summary>
		/// Value of GL_RENDERBUFFER_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_WIDTH_EXT = 0x8D42;

		/// <summary>
		/// Value of GL_RENDERBUFFER_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_HEIGHT_EXT = 0x8D43;

		/// <summary>
		/// Value of GL_RENDERBUFFER_INTERNAL_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;

		/// <summary>
		/// Value of GL_STENCIL_INDEX1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_INDEX1_EXT = 0x8D46;

		/// <summary>
		/// Value of GL_STENCIL_INDEX4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_INDEX4_EXT = 0x8D47;

		/// <summary>
		/// Value of GL_STENCIL_INDEX8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_INDEX8_EXT = 0x8D48;

		/// <summary>
		/// Value of GL_STENCIL_INDEX16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int STENCIL_INDEX16_EXT = 0x8D49;

		/// <summary>
		/// Value of GL_RENDERBUFFER_RED_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_RED_SIZE_EXT = 0x8D50;

		/// <summary>
		/// Value of GL_RENDERBUFFER_GREEN_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BLUE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52;

		/// <summary>
		/// Value of GL_RENDERBUFFER_ALPHA_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53;

		/// <summary>
		/// Value of GL_RENDERBUFFER_DEPTH_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54;

		/// <summary>
		/// Value of GL_RENDERBUFFER_STENCIL_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public const int RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55;

		/// <summary>
		/// Binding for glIsRenderbufferEXT.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static bool IsRenderbufferEXT(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbufferEXT != null, "pglIsRenderbufferEXT not implemented");
			retValue = Delegates.pglIsRenderbufferEXT(renderbuffer);
			CallLog("glIsRenderbufferEXT({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindRenderbufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindRenderbufferEXT(int target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferEXT != null, "pglBindRenderbufferEXT not implemented");
			Delegates.pglBindRenderbufferEXT(target, renderbuffer);
			CallLog("glBindRenderbufferEXT({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteRenderbuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteRenderbufferEXT(Int32 n, UInt32[] renderbuffers)
		{
			Debug.Assert(renderbuffers.Length >= n);
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersEXT != null, "pglDeleteRenderbuffersEXT not implemented");
					Delegates.pglDeleteRenderbuffersEXT(n, p_renderbuffers);
					CallLog("glDeleteRenderbuffersEXT({0}, {1})", n, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteRenderbuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteRenderbufferEXT(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersEXT != null, "pglDeleteRenderbuffersEXT not implemented");
					Delegates.pglDeleteRenderbuffersEXT((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glDeleteRenderbuffersEXT({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenRenderbuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenRenderbufferEXT(Int32 n, UInt32[] renderbuffers)
		{
			Debug.Assert(renderbuffers.Length >= n);
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersEXT != null, "pglGenRenderbuffersEXT not implemented");
					Delegates.pglGenRenderbuffersEXT(n, p_renderbuffers);
					CallLog("glGenRenderbuffersEXT({0}, {1})", n, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenRenderbuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenRenderbufferEXT(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersEXT != null, "pglGenRenderbuffersEXT not implemented");
					Delegates.pglGenRenderbuffersEXT((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glGenRenderbuffersEXT({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void RenderbufferStorageEXT(int target, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageEXT != null, "pglRenderbufferStorageEXT not implemented");
			Delegates.pglRenderbufferStorageEXT(target, internalformat, width, height);
			CallLog("glRenderbufferStorageEXT({0}, {1}, {2}, {3})", target, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetRenderbufferParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GetRenderbufferParameterEXT(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivEXT != null, "pglGetRenderbufferParameterivEXT not implemented");
					Delegates.pglGetRenderbufferParameterivEXT(target, pname, p_params);
					CallLog("glGetRenderbufferParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsFramebufferEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static bool IsFramebufferEXT(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebufferEXT != null, "pglIsFramebufferEXT not implemented");
			retValue = Delegates.pglIsFramebufferEXT(framebuffer);
			CallLog("glIsFramebufferEXT({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void BindFramebufferEXT(int target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferEXT != null, "pglBindFramebufferEXT not implemented");
			Delegates.pglBindFramebufferEXT(target, framebuffer);
			CallLog("glBindFramebufferEXT({0}, {1})", target, framebuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteFramebuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteFramebuffersEXT(Int32 n, UInt32[] framebuffers)
		{
			Debug.Assert(framebuffers.Length >= n);
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersEXT != null, "pglDeleteFramebuffersEXT not implemented");
					Delegates.pglDeleteFramebuffersEXT(n, p_framebuffers);
					CallLog("glDeleteFramebuffersEXT({0}, {1})", n, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteFramebuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void DeleteFramebuffersEXT(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersEXT != null, "pglDeleteFramebuffersEXT not implemented");
					Delegates.pglDeleteFramebuffersEXT((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glDeleteFramebuffersEXT({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenFramebuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenFramebuffersEXT(Int32 n, UInt32[] framebuffers)
		{
			Debug.Assert(framebuffers.Length >= n);
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersEXT != null, "pglGenFramebuffersEXT not implemented");
					Delegates.pglGenFramebuffersEXT(n, p_framebuffers);
					CallLog("glGenFramebuffersEXT({0}, {1})", n, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenFramebuffersEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenFramebuffersEXT(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersEXT != null, "pglGenFramebuffersEXT not implemented");
					Delegates.pglGenFramebuffersEXT((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glGenFramebuffersEXT({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCheckFramebufferStatusEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static int CheckFramebufferStatusEXT(int target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusEXT != null, "pglCheckFramebufferStatusEXT not implemented");
			retValue = Delegates.pglCheckFramebufferStatusEXT(target);
			CallLog("glCheckFramebufferStatusEXT({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glFramebufferTexture1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferTexture1DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture1DEXT != null, "pglFramebufferTexture1DEXT not implemented");
			Delegates.pglFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture1DEXT({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferTexture2DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DEXT != null, "pglFramebufferTexture2DEXT not implemented");
			Delegates.pglFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture2DEXT({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferTexture3DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			Debug.Assert(Delegates.pglFramebufferTexture3DEXT != null, "pglFramebufferTexture3DEXT not implemented");
			Delegates.pglFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
			CallLog("glFramebufferTexture3DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferRenderbufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void FramebufferRenderbufferEXT(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferEXT != null, "pglFramebufferRenderbufferEXT not implemented");
			Delegates.pglFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
			CallLog("glFramebufferRenderbufferEXT({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFramebufferAttachmentParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GetFramebufferAttachmentParameterEXT(int target, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivEXT != null, "pglGetFramebufferAttachmentParameterivEXT not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivEXT(target, attachment, pname, p_params);
					CallLog("glGetFramebufferAttachmentParameterivEXT({0}, {1}, {2}, {3})", target, attachment, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenerateMipmapEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		public static void GenerateMipmapEXT(int target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapEXT != null, "pglGenerateMipmapEXT not implemented");
			Delegates.pglGenerateMipmapEXT(target);
			CallLog("glGenerateMipmapEXT({0})", target);
			DebugCheckErrors();
		}

	}

}
