
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
		/// Value of GL_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_SGI = 0x80D0;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2;

		/// <summary>
		/// Value of GL_PROXY_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_COLOR_TABLE_SGI = 0x80D3;

		/// <summary>
		/// Value of GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4;

		/// <summary>
		/// Value of GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5;

		/// <summary>
		/// Value of GL_COLOR_TABLE_SCALE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_SCALE_SGI = 0x80D6;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BIAS_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_BIAS_SGI = 0x80D7;

		/// <summary>
		/// Value of GL_COLOR_TABLE_FORMAT_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_FORMAT_SGI = 0x80D8;

		/// <summary>
		/// Value of GL_COLOR_TABLE_WIDTH_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_WIDTH_SGI = 0x80D9;

		/// <summary>
		/// Value of GL_COLOR_TABLE_RED_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_RED_SIZE_SGI = 0x80DA;

		/// <summary>
		/// Value of GL_COLOR_TABLE_GREEN_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB;

		/// <summary>
		/// Value of GL_COLOR_TABLE_BLUE_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC;

		/// <summary>
		/// Value of GL_COLOR_TABLE_ALPHA_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD;

		/// <summary>
		/// Value of GL_COLOR_TABLE_LUMINANCE_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE;

		/// <summary>
		/// Value of GL_COLOR_TABLE_INTENSITY_SIZE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_table")]
		public const int COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF;

		/// <summary>
		/// Binding for glColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableSGI(ColorTableTargetSGI target, int internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglColorTableSGI != null, "pglColorTableSGI not implemented");
			Delegates.pglColorTableSGI((int)target, internalformat, width, (int)format, (int)type, table);
			CallLog("glColorTableSGI({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableSGI(ColorTableTargetSGI target, int internalformat, Int32 width, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				ColorTableSGI(target, internalformat, width, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glColorTableParameterfvSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableParameterSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglColorTableParameterfvSGI != null, "pglColorTableParameterfvSGI not implemented");
					Delegates.pglColorTableParameterfvSGI((int)target, (int)pname, p_params);
					CallLog("glColorTableParameterfvSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTableParameterivSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void ColorTableParameterSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglColorTableParameterivSGI != null, "pglColorTableParameterivSGI not implemented");
					Delegates.pglColorTableParameterivSGI((int)target, (int)pname, p_params);
					CallLog("glColorTableParameterivSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void CopyColorTableSGI(ColorTableTargetSGI target, int internalformat, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyColorTableSGI != null, "pglCopyColorTableSGI not implemented");
			Delegates.pglCopyColorTableSGI((int)target, internalformat, x, y, width);
			CallLog("glCopyColorTableSGI({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetColorTableSGI != null, "pglGetColorTableSGI not implemented");
			Delegates.pglGetColorTableSGI((int)target, (int)format, (int)type, table);
			CallLog("glGetColorTableSGI({0}, {1}, {2}, {3})", target, format, type, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetColorTableSGI(target, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetColorTableParameterfvSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterfvSGI != null, "pglGetColorTableParameterfvSGI not implemented");
					Delegates.pglGetColorTableParameterfvSGI((int)target, (int)pname, p_params);
					CallLog("glGetColorTableParameterfvSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableParameterivSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterivSGI != null, "pglGetColorTableParameterivSGI not implemented");
					Delegates.pglGetColorTableParameterivSGI((int)target, (int)pname, p_params);
					CallLog("glGetColorTableParameterivSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
