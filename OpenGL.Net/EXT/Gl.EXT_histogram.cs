
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
		/// Binding for glGetHistogramEXT.
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
			LogFunction("glGetHistogramEXT({0}, {1}, {2}, {3}, 0x{4})", target, reset, format, type, values.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetHistogramEXT.
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
		/// Binding for glGetHistogramParameterfvEXT.
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
					LogFunction("glGetHistogramParameterfvEXT({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetHistogramParameterivEXT.
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
					LogFunction("glGetHistogramParameterivEXT({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
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
		public static void GetMinmaxEXT(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetMinmaxEXT != null, "pglGetMinmaxEXT not implemented");
			Delegates.pglGetMinmaxEXT((Int32)target, reset, (Int32)format, (Int32)type, values);
			LogFunction("glGetMinmaxEXT({0}, {1}, {2}, {3}, 0x{4})", target, reset, format, type, values.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
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
		public static void GetMinmaxEXT(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetMinmaxEXT(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// Binding for glGetMinmaxParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetMinmaxParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxParameterEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterfvEXT != null, "pglGetMinmaxParameterfvEXT not implemented");
					Delegates.pglGetMinmaxParameterfvEXT((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMinmaxParameterfvEXT({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMinmaxParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetMinmaxParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxParameterEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterivEXT != null, "pglGetMinmaxParameterivEXT not implemented");
					Delegates.pglGetMinmaxParameterivEXT((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMinmaxParameterivEXT({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
