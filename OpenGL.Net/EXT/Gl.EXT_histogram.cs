
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
		/// Value of GL_HISTOGRAM_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_EXT = 0x8024;

		/// <summary>
		/// Value of GL_PROXY_HISTOGRAM_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int PROXY_HISTOGRAM_EXT = 0x8025;

		/// <summary>
		/// Value of GL_HISTOGRAM_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_WIDTH_EXT = 0x8026;

		/// <summary>
		/// Value of GL_HISTOGRAM_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_FORMAT_EXT = 0x8027;

		/// <summary>
		/// Value of GL_HISTOGRAM_RED_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_RED_SIZE_EXT = 0x8028;

		/// <summary>
		/// Value of GL_HISTOGRAM_GREEN_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_GREEN_SIZE_EXT = 0x8029;

		/// <summary>
		/// Value of GL_HISTOGRAM_BLUE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_BLUE_SIZE_EXT = 0x802A;

		/// <summary>
		/// Value of GL_HISTOGRAM_ALPHA_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_ALPHA_SIZE_EXT = 0x802B;

		/// <summary>
		/// Value of GL_HISTOGRAM_LUMINANCE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C;

		/// <summary>
		/// Value of GL_HISTOGRAM_SINK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int HISTOGRAM_SINK_EXT = 0x802D;

		/// <summary>
		/// Value of GL_MINMAX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX_EXT = 0x802E;

		/// <summary>
		/// Value of GL_MINMAX_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX_FORMAT_EXT = 0x802F;

		/// <summary>
		/// Value of GL_MINMAX_SINK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int MINMAX_SINK_EXT = 0x8030;

		/// <summary>
		/// Value of GL_TABLE_TOO_LARGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_histogram")]
		public const int TABLE_TOO_LARGE_EXT = 0x8031;

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
			Delegates.pglGetHistogramEXT((int)target, reset, (int)format, (int)type, values);
			CallLog("glGetHistogramEXT({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetHistogramEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetHistogramEXT(int target, bool reset, int format, int type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetHistogramEXT(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
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
		public static void GetHistogramParameterEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterfvEXT != null, "pglGetHistogramParameterfvEXT not implemented");
					Delegates.pglGetHistogramParameterfvEXT((int)target, (int)pname, p_params);
					CallLog("glGetHistogramParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
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
		public static void GetHistogramParameterEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterivEXT != null, "pglGetHistogramParameterivEXT not implemented");
					Delegates.pglGetHistogramParameterivEXT((int)target, (int)pname, p_params);
					CallLog("glGetHistogramParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
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
			Delegates.pglGetMinmaxEXT((int)target, reset, (int)format, (int)type, values);
			CallLog("glGetMinmaxEXT({0}, {1}, {2}, {3}, {4})", target, reset, format, type, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void GetMinmaxEXT(int target, bool reset, int format, int type, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetMinmaxEXT(target, reset, format, type, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
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
		public static void GetMinmaxParameterEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterfvEXT != null, "pglGetMinmaxParameterfvEXT not implemented");
					Delegates.pglGetMinmaxParameterfvEXT((int)target, (int)pname, p_params);
					CallLog("glGetMinmaxParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
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
		public static void GetMinmaxParameterEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMinmaxParameterivEXT != null, "pglGetMinmaxParameterivEXT not implemented");
					Delegates.pglGetMinmaxParameterivEXT((int)target, (int)pname, p_params);
					CallLog("glGetMinmaxParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glHistogramEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sink">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void HistogramEXT(HistogramTargetEXT target, Int32 width, int internalformat, bool sink)
		{
			Debug.Assert(Delegates.pglHistogramEXT != null, "pglHistogramEXT not implemented");
			Delegates.pglHistogramEXT((int)target, width, internalformat, sink);
			CallLog("glHistogramEXT({0}, {1}, {2}, {3})", target, width, internalformat, sink);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sink">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void MinmaxEXT(MinmaxTargetEXT target, int internalformat, bool sink)
		{
			Debug.Assert(Delegates.pglMinmaxEXT != null, "pglMinmaxEXT not implemented");
			Delegates.pglMinmaxEXT((int)target, internalformat, sink);
			CallLog("glMinmaxEXT({0}, {1}, {2})", target, internalformat, sink);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResetHistogramEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void ResetHistogramEXT(HistogramTargetEXT target)
		{
			Debug.Assert(Delegates.pglResetHistogramEXT != null, "pglResetHistogramEXT not implemented");
			Delegates.pglResetHistogramEXT((int)target);
			CallLog("glResetHistogramEXT({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResetMinmaxEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTargetEXT"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_histogram")]
		public static void ResetMinmaxEXT(MinmaxTargetEXT target)
		{
			Debug.Assert(Delegates.pglResetMinmaxEXT != null, "pglResetMinmaxEXT not implemented");
			Delegates.pglResetMinmaxEXT((int)target);
			CallLog("glResetMinmaxEXT({0})", target);
			DebugCheckErrors();
		}

	}

}
