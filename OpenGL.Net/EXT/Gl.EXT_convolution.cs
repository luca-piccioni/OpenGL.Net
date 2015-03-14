
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
		/// Value of GL_CONVOLUTION_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_1D_EXT = 0x8010;

		/// <summary>
		/// Value of GL_CONVOLUTION_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_2D_EXT = 0x8011;

		/// <summary>
		/// Value of GL_SEPARABLE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int SEPARABLE_2D_EXT = 0x8012;

		/// <summary>
		/// Value of GL_CONVOLUTION_BORDER_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_BORDER_MODE_EXT = 0x8013;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FILTER_SCALE_EXT = 0x8014;

		/// <summary>
		/// Value of GL_CONVOLUTION_FILTER_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FILTER_BIAS_EXT = 0x8015;

		/// <summary>
		/// Value of GL_REDUCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int REDUCE_EXT = 0x8016;

		/// <summary>
		/// Value of GL_CONVOLUTION_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_FORMAT_EXT = 0x8017;

		/// <summary>
		/// Value of GL_CONVOLUTION_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_WIDTH_EXT = 0x8018;

		/// <summary>
		/// Value of GL_CONVOLUTION_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int CONVOLUTION_HEIGHT_EXT = 0x8019;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int MAX_CONVOLUTION_WIDTH_EXT = 0x801A;

		/// <summary>
		/// Value of GL_MAX_CONVOLUTION_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_RED_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_GREEN_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_BLUE_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;

		/// <summary>
		/// Value of GL_POST_CONVOLUTION_ALPHA_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_convolution")]
		public const int POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;

		/// <summary>
		/// Binding for glConvolutionFilter1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter1DEXT(ConvolutionTargetEXT target, int internalformat, Int32 width, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglConvolutionFilter1DEXT != null, "pglConvolutionFilter1DEXT not implemented");
			Delegates.pglConvolutionFilter1DEXT((int)target, internalformat, width, (int)format, (int)type, image);
			CallLog("glConvolutionFilter1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, width, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter1DEXT.
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter1DEXT(int target, int internalformat, Int32 width, int format, int type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter1DEXT(target, internalformat, width, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionFilter1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter1DEXT(ConvolutionTargetEXT target, int internalformat, Int32 width, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter1DEXT(target, internalformat, width, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionFilter2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter2DEXT(ConvolutionTargetEXT target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglConvolutionFilter2DEXT != null, "pglConvolutionFilter2DEXT not implemented");
			Delegates.pglConvolutionFilter2DEXT((int)target, internalformat, width, height, (int)format, (int)type, image);
			CallLog("glConvolutionFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, internalformat, width, height, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionFilter2DEXT.
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter2DEXT(target, internalformat, width, height, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionFilter2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionFilter2DEXT(ConvolutionTargetEXT target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				ConvolutionFilter2DEXT(target, internalformat, width, height, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glConvolutionParameterfEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float @params)
		{
			Debug.Assert(Delegates.pglConvolutionParameterfEXT != null, "pglConvolutionParameterfEXT not implemented");
			Delegates.pglConvolutionParameterfEXT((int)target, (int)pname, @params);
			CallLog("glConvolutionParameterfEXT({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameterfvEXT != null, "pglConvolutionParameterfvEXT not implemented");
					Delegates.pglConvolutionParameterfvEXT((int)target, (int)pname, p_params);
					CallLog("glConvolutionParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameteriEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, Int32 @params)
		{
			Debug.Assert(Delegates.pglConvolutionParameteriEXT != null, "pglConvolutionParameteriEXT not implemented");
			Delegates.pglConvolutionParameteriEXT((int)target, (int)pname, @params);
			CallLog("glConvolutionParameteriEXT({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glConvolutionParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void ConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameterivEXT != null, "pglConvolutionParameterivEXT not implemented");
					Delegates.pglConvolutionParameterivEXT((int)target, (int)pname, p_params);
					CallLog("glConvolutionParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyConvolutionFilter1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		[RequiredByFeature("GL_EXT_convolution")]
		public static void CopyConvolutionFilter1DEXT(ConvolutionTargetEXT target, int internalformat, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyConvolutionFilter1DEXT != null, "pglCopyConvolutionFilter1DEXT not implemented");
			Delegates.pglCopyConvolutionFilter1DEXT((int)target, internalformat, x, y, width);
			CallLog("glCopyConvolutionFilter1DEXT({0}, {1}, {2}, {3}, {4})", target, internalformat, x, y, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyConvolutionFilter2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
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
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void CopyConvolutionFilter2DEXT(ConvolutionTargetEXT target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyConvolutionFilter2DEXT != null, "pglCopyConvolutionFilter2DEXT not implemented");
			Delegates.pglCopyConvolutionFilter2DEXT((int)target, internalformat, x, y, width, height);
			CallLog("glCopyConvolutionFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalformat, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilterEXT != null, "pglGetConvolutionFilterEXT not implemented");
			Delegates.pglGetConvolutionFilterEXT((int)target, (int)format, (int)type, image);
			CallLog("glGetConvolutionFilterEXT({0}, {1}, {2}, {3})", target, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(int target, int format, int type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilterEXT(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilterEXT(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfvEXT != null, "pglGetConvolutionParameterfvEXT not implemented");
					Delegates.pglGetConvolutionParameterfvEXT((int)target, (int)pname, p_params);
					CallLog("glGetConvolutionParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterivEXT != null, "pglGetConvolutionParameterivEXT not implemented");
					Delegates.pglGetConvolutionParameterivEXT((int)target, (int)pname, p_params);
					CallLog("glGetConvolutionParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilterEXT != null, "pglGetSeparableFilterEXT not implemented");
			Delegates.pglGetSeparableFilterEXT((int)target, (int)format, (int)type, row, column, span);
			CallLog("glGetSeparableFilterEXT({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(int target, int format, int type, Object row, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilterEXT(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, Object row, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilterEXT(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// Binding for glSeparableFilter2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
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
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void SeparableFilter2DEXT(SeparableTargetEXT target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr row, IntPtr column)
		{
			Debug.Assert(Delegates.pglSeparableFilter2DEXT != null, "pglSeparableFilter2DEXT not implemented");
			Delegates.pglSeparableFilter2DEXT((int)target, internalformat, width, height, (int)format, (int)type, row, column);
			CallLog("glSeparableFilter2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, internalformat, width, height, format, type, row, column);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSeparableFilter2DEXT.
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
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void SeparableFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, Object row, Object column)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			try {
				SeparableFilter2DEXT(target, internalformat, width, height, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
			}
		}

		/// <summary>
		/// Binding for glSeparableFilter2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
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
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void SeparableFilter2DEXT(SeparableTargetEXT target, int internalformat, Int32 width, Int32 height, PixelFormat format, PixelType type, Object row, Object column)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			try {
				SeparableFilter2DEXT(target, internalformat, width, height, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
			}
		}

	}

}
