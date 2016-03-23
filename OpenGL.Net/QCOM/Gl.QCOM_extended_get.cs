
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
		/// Value of GL_TEXTURE_WIDTH_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_WIDTH_QCOM = 0x8BD2;

		/// <summary>
		/// Value of GL_TEXTURE_HEIGHT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_HEIGHT_QCOM = 0x8BD3;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_DEPTH_QCOM = 0x8BD4;

		/// <summary>
		/// Value of GL_TEXTURE_INTERNAL_FORMAT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;

		/// <summary>
		/// Value of GL_TEXTURE_FORMAT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_FORMAT_QCOM = 0x8BD6;

		/// <summary>
		/// Value of GL_TEXTURE_TYPE_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_TYPE_QCOM = 0x8BD7;

		/// <summary>
		/// Value of GL_TEXTURE_IMAGE_VALID_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;

		/// <summary>
		/// Value of GL_TEXTURE_NUM_LEVELS_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;

		/// <summary>
		/// Value of GL_TEXTURE_TARGET_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_TARGET_QCOM = 0x8BDA;

		/// <summary>
		/// Value of GL_TEXTURE_OBJECT_VALID_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;

		/// <summary>
		/// Value of GL_STATE_RESTORE symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public const int STATE_RESTORE = 0x8BDC;

		/// <summary>
		/// Binding for glExtGetTexturesQCOM.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxTextures">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numTextures">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetTexturesQCOM(UInt32[] textures, Int32 maxTextures, Int32[] numTextures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (Int32* p_numTextures = numTextures)
				{
					Debug.Assert(Delegates.pglExtGetTexturesQCOM != null, "pglExtGetTexturesQCOM not implemented");
					Delegates.pglExtGetTexturesQCOM(p_textures, maxTextures, p_numTextures);
					LogFunction("glExtGetTexturesQCOM({0}, {1}, {2})", LogValue(textures), maxTextures, LogValue(numTextures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetBuffersQCOM.
		/// </summary>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numBuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetBuffersQCOM(UInt32[] buffers, Int32[] numBuffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (Int32* p_numBuffers = numBuffers)
				{
					Debug.Assert(Delegates.pglExtGetBuffersQCOM != null, "pglExtGetBuffersQCOM not implemented");
					Delegates.pglExtGetBuffersQCOM(p_buffers, (Int32)buffers.Length, p_numBuffers);
					LogFunction("glExtGetBuffersQCOM({0}, {1}, {2})", LogValue(buffers), buffers.Length, LogValue(numBuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetRenderbuffersQCOM.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numRenderbuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetRenderbuffersQCOM(UInt32[] renderbuffers, Int32[] numRenderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				fixed (Int32* p_numRenderbuffers = numRenderbuffers)
				{
					Debug.Assert(Delegates.pglExtGetRenderbuffersQCOM != null, "pglExtGetRenderbuffersQCOM not implemented");
					Delegates.pglExtGetRenderbuffersQCOM(p_renderbuffers, (Int32)renderbuffers.Length, p_numRenderbuffers);
					LogFunction("glExtGetRenderbuffersQCOM({0}, {1}, {2})", LogValue(renderbuffers), renderbuffers.Length, LogValue(numRenderbuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetFramebuffersQCOM.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numFramebuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetFramebuffersQCOM(UInt32[] framebuffers, Int32[] numFramebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				fixed (Int32* p_numFramebuffers = numFramebuffers)
				{
					Debug.Assert(Delegates.pglExtGetFramebuffersQCOM != null, "pglExtGetFramebuffersQCOM not implemented");
					Delegates.pglExtGetFramebuffersQCOM(p_framebuffers, (Int32)framebuffers.Length, p_numFramebuffers);
					LogFunction("glExtGetFramebuffersQCOM({0}, {1}, {2})", LogValue(framebuffers), framebuffers.Length, LogValue(numFramebuffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetTexLevelParameterivQCOM.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetTexLevelParameterivQCOM(UInt32 texture, Int32 face, Int32 level, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglExtGetTexLevelParameterivQCOM != null, "pglExtGetTexLevelParameterivQCOM not implemented");
					Delegates.pglExtGetTexLevelParameterivQCOM(texture, face, level, pname, p_params);
					LogFunction("glExtGetTexLevelParameterivQCOM({0}, {1}, {2}, {3}, {4})", texture, LogEnumName(face), level, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtTexObjectStateOverrideiQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtTexObjectStateOverrideiQCOM(Int32 target, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglExtTexObjectStateOverrideiQCOM != null, "pglExtTexObjectStateOverrideiQCOM not implemented");
			Delegates.pglExtTexObjectStateOverrideiQCOM(target, pname, param);
			LogFunction("glExtTexObjectStateOverrideiQCOM({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetTexSubImageQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetTexSubImageQCOM(Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr texels)
		{
			Debug.Assert(Delegates.pglExtGetTexSubImageQCOM != null, "pglExtGetTexSubImageQCOM not implemented");
			Delegates.pglExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
			LogFunction("glExtGetTexSubImageQCOM({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", LogEnumName(target), level, xoffset, yoffset, zoffset, width, height, depth, LogEnumName(format), LogEnumName(type), texels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glExtGetBufferPointervQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get", Api = "gles1|gles2")]
		public static void ExtGetBufferPointervQCOM(Int32 target, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglExtGetBufferPointervQCOM != null, "pglExtGetBufferPointervQCOM not implemented");
					Delegates.pglExtGetBufferPointervQCOM(target, p_params);
					LogFunction("glExtGetBufferPointervQCOM({0}, {1})", LogEnumName(target), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
