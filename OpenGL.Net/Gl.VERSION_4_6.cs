
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_SHADER_BINARY_FORMAT_SPIR_V symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int SHADER_BINARY_FORMAT_SPIR_V = 0x9551;

		/// <summary>
		/// [GL] Value of GL_SPIR_V_BINARY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int SPIR_V_BINARY = 0x9552;

		/// <summary>
		/// [GL] Value of GL_PARAMETER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int PARAMETER_BUFFER = 0x80EE;

		/// <summary>
		/// [GL] Value of GL_PARAMETER_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int PARAMETER_BUFFER_BINDING = 0x80EF;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_FLAG_NO_ERROR_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;

		/// <summary>
		/// [GL] Value of GL_VERTICES_SUBMITTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int VERTICES_SUBMITTED = 0x82EE;

		/// <summary>
		/// [GL] Value of GL_PRIMITIVES_SUBMITTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int PRIMITIVES_SUBMITTED = 0x82EF;

		/// <summary>
		/// [GL] Value of GL_VERTEX_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int VERTEX_SHADER_INVOCATIONS = 0x82F0;

		/// <summary>
		/// [GL] Value of GL_TESS_CONTROL_SHADER_PATCHES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int TESS_CONTROL_SHADER_PATCHES = 0x82F1;

		/// <summary>
		/// [GL] Value of GL_TESS_EVALUATION_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int FRAGMENT_SHADER_INVOCATIONS = 0x82F4;

		/// <summary>
		/// [GL] Value of GL_COMPUTE_SHADER_INVOCATIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int COMPUTE_SHADER_INVOCATIONS = 0x82F5;

		/// <summary>
		/// [GL] Value of GL_CLIPPING_INPUT_PRIMITIVES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int CLIPPING_INPUT_PRIMITIVES = 0x82F6;

		/// <summary>
		/// [GL] Value of GL_CLIPPING_OUTPUT_PRIMITIVES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;

		/// <summary>
		/// [GL] Value of GL_POLYGON_OFFSET_CLAMP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_polygon_offset_clamp", Api = "gl|glcore")]
		public const int POLYGON_OFFSET_CLAMP = 0x8E1B;

		/// <summary>
		/// [GL] Value of GL_SPIR_V_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_spirv_extensions", Api = "gl|glcore")]
		public const int SPIR_V_EXTENSIONS = 0x9553;

		/// <summary>
		/// [GL] Value of GL_NUM_SPIR_V_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_spirv_extensions", Api = "gl|glcore")]
		public const int NUM_SPIR_V_EXTENSIONS = 0x9554;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_MAX_ANISOTROPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_texture_filter_anisotropic", Api = "gl|glcore")]
		public const int TEXTURE_MAX_ANISOTROPY = 0x84FE;

		/// <summary>
		/// [GL] Value of GL_MAX_TEXTURE_MAX_ANISOTROPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_texture_filter_anisotropic", Api = "gl|glcore")]
		public const int MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;

		/// <summary>
		/// [GL] Value of GL_TRANSFORM_FEEDBACK_OVERFLOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;

		/// <summary>
		/// [GL] Value of GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_6")]
		public const int TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;

		/// <summary>
		/// [GL] glSpecializeShader: Binding for glSpecializeShader.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pEntryPoint">
		/// A <see cref="T:string"/>.
		/// </param>
		/// <param name="numSpecializationConstants">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pConstantIndex">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="pConstantValue">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
		public static void SpecializeShader(uint shader, string pEntryPoint, uint numSpecializationConstants, uint[] pConstantIndex, uint[] pConstantValue)
		{
			unsafe {
				fixed (uint* p_pConstantIndex = pConstantIndex)
				fixed (uint* p_pConstantValue = pConstantValue)
				{
					Debug.Assert(Delegates.pglSpecializeShader != null, "pglSpecializeShader not implemented");
					Delegates.pglSpecializeShader(shader, pEntryPoint, numSpecializationConstants, p_pConstantIndex, p_pConstantValue);
					LogCommand("glSpecializeShader", null, shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiDrawArraysIndirectCount: Binding for glMultiDrawArraysIndirectCount.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectCount != null, "pglMultiDrawArraysIndirectCount not implemented");
			Delegates.pglMultiDrawArraysIndirectCount((int)mode, indirect, drawcount, maxdrawcount, stride);
			LogCommand("glMultiDrawArraysIndirectCount", null, mode, indirect, drawcount, maxdrawcount, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiDrawArraysIndirectCount: Binding for glMultiDrawArraysIndirectCount.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirect(PrimitiveType mode, object indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirect(mode, pin_indirect.AddrOfPinnedObject(), drawcount, maxdrawcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// [GL] glMultiDrawElementsIndirectCount: Binding for glMultiDrawElementsIndirectCount.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirect(PrimitiveType mode, int type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectCount != null, "pglMultiDrawElementsIndirectCount not implemented");
			Delegates.pglMultiDrawElementsIndirectCount((int)mode, type, indirect, drawcount, maxdrawcount, stride);
			LogCommand("glMultiDrawElementsIndirectCount", null, mode, type, indirect, drawcount, maxdrawcount, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiDrawElementsIndirectCount: Binding for glMultiDrawElementsIndirectCount.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirect(PrimitiveType mode, int type, object indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirect(mode, type, pin_indirect.AddrOfPinnedObject(), drawcount, maxdrawcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// [GL] glPolygonOffsetClamp: Binding for glPolygonOffsetClamp.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="clamp">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_6")]
		[RequiredByFeature("GL_ARB_polygon_offset_clamp", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
		public static void PolygonOffsetClamp(float factor, float units, float clamp)
		{
			Debug.Assert(Delegates.pglPolygonOffsetClamp != null, "pglPolygonOffsetClamp not implemented");
			Delegates.pglPolygonOffsetClamp(factor, units, clamp);
			LogCommand("glPolygonOffsetClamp", null, factor, units, clamp			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glSpecializeShader(uint shader, string pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore", EntryPoint = "glSpecializeShaderARB")]
			[ThreadStatic]
			internal static glSpecializeShader pglSpecializeShader;

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiDrawArraysIndirectCount(int mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectCount pglMultiDrawArraysIndirectCount;

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiDrawElementsIndirectCount(int mode, int type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectCount pglMultiDrawElementsIndirectCount;

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_polygon_offset_clamp", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glPolygonOffsetClamp(float factor, float units, float clamp);

			[RequiredByFeature("GL_VERSION_4_6")]
			[RequiredByFeature("GL_ARB_polygon_offset_clamp", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2", EntryPoint = "glPolygonOffsetClampEXT")]
			[ThreadStatic]
			internal static glPolygonOffsetClamp pglPolygonOffsetClamp;

		}
	}

}
