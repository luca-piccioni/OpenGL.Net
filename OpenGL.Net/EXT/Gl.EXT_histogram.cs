
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
		/// [GL] Binding for glGetHistogramEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetHistogramEXT(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetHistogramEXT != null, "pglGetHistogramEXT not implemented");
			Delegates.pglGetHistogramEXT((Int32)target, reset, (Int32)format, (Int32)type, values);
			LogCommand("glGetHistogramEXT", null, target, reset, format, type, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetHistogramEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetHistogramEXT(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetHistogramEXT(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glGetHistogramParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetHistogramParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetHistogramParameterEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterfvEXT != null, "pglGetHistogramParameterfvEXT not implemented");
					Delegates.pglGetHistogramParameterfvEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetHistogramParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetHistogramParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetHistogramParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetHistogramParameterEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterivEXT != null, "pglGetHistogramParameterivEXT not implemented");
					Delegates.pglGetHistogramParameterivEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetHistogramParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxEXT(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmaxEXT != null, "pglGetMinmaxEXT not implemented");
			Delegates.pglGetMinmaxEXT((Int32)target, reset, (Int32)format, (Int32)type, values);
			LogCommand("glGetMinmaxEXT", null, target, reset, format, type, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxEXT(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetMinmaxEXT(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glGetMinmaxParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetMinmaxParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxParameterEXT(MinmaxTarget target, GetMinmaxParameterPNameEXT pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterfvEXT != null, "pglGetMinmaxParameterfvEXT not implemented");
					Delegates.pglGetMinmaxParameterfvEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetMinmaxParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMinmaxParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetMinmaxParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxParameterEXT(MinmaxTarget target, GetMinmaxParameterPNameEXT pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterivEXT != null, "pglGetMinmaxParameterivEXT not implemented");
					Delegates.pglGetMinmaxParameterivEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetMinmaxParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetHistogramEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetHistogramParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterfvEXT(Int32 target, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetHistogramParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMinmaxEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMinmaxParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameterfvEXT(Int32 target, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMinmaxParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMinmaxParameterivEXT(Int32 target, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetHistogramEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetHistogramEXT pglGetHistogramEXT;

			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetHistogramParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetHistogramParameterfvEXT pglGetHistogramParameterfvEXT;

			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetHistogramParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetHistogramParameterivEXT pglGetHistogramParameterivEXT;

			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMinmaxEXT(Int32 target, bool reset, Int32 format, Int32 type, IntPtr values);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetMinmaxEXT pglGetMinmaxEXT;

			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMinmaxParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetMinmaxParameterfvEXT pglGetMinmaxParameterfvEXT;

			[RequiredByFeature("GL_EXT_histogram")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMinmaxParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_histogram")]
			[ThreadStatic]
			internal static glGetMinmaxParameterivEXT pglGetMinmaxParameterivEXT;

		}
	}

}
