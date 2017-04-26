
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
	/// <summary>
	/// Class for scoping those methods conflicting with other fields/enums.
	/// </summary>
	public partial class Gl
	{
		public static class VB
		{
			/// <summary>
			/// clear buffers to preset values
			/// </summary>
			/// <param name="mask">
			/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are Gl.COLOR_BUFFER_BIT, 
			/// Gl.DEPTH_BUFFER_BIT, and Gl.STENCIL_BUFFER_BIT.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if any bit other than the three defined bits is set in <paramref name="mask"/>.
			/// </exception>
			/// <seealso cref="Gl.ColorMask"/>
			/// <seealso cref="Gl.DepthMask"/>
			/// <seealso cref="Gl.DrawBuffer"/>
			/// <seealso cref="Gl.Scissor"/>
			/// <seealso cref="Gl.StencilMask"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			public static void Clear(ClearBufferMask mask)
			{
				Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
				Delegates.pglClear((UInt32)mask);
				LogCommand("glClear", null, mask				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the viewport
			/// </summary>
			/// <param name="x">
			/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
			/// </param>
			/// <param name="y">
			/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
			/// </param>
			/// <param name="width">
			/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
			/// and <paramref name="height"/> are set to the dimensions of that window.
			/// </param>
			/// <param name="height">
			/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
			/// and <paramref name="height"/> are set to the dimensions of that window.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Viewport is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.DepthRange"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
			{
				Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
				Delegates.pglViewport(x, y, width, height);
				LogCommand("glViewport", null, x, y, width, height				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// draw a bitmap
			/// </summary>
			/// <param name="width">
			/// Specify the pixel width and height of the bitmap image.
			/// </param>
			/// <param name="height">
			/// Specify the pixel width and height of the bitmap image.
			/// </param>
			/// <param name="xorig">
			/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
			/// with right and up being the positive axes.
			/// </param>
			/// <param name="yorig">
			/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
			/// with right and up being the positive axes.
			/// </param>
			/// <param name="xmove">
			/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
			/// </param>
			/// <param name="ymove">
			/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
			/// </param>
			/// <param name="bitmap">
			/// Specifies the address of the bitmap image.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
			/// buffer object's data store is currently mapped.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
			/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Bitmap is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.BindBuffer"/>
			/// <seealso cref="Gl.DrawPixels"/>
			/// <seealso cref="Gl.PixelStore"/>
			/// <seealso cref="Gl.PixelTransfer"/>
			/// <seealso cref="Gl.RasterPos"/>
			/// <seealso cref="Gl.WindowPos"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Bitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
			{
				unsafe {
					fixed (byte* p_bitmap = bitmap)
					{
						Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
						Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
						LogCommand("glBitmap", null, width, height, xorig, yorig, xmove, ymove, bitmap						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(double c)
			{
				Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
				Delegates.pglIndexd(c);
				LogCommand("glIndexd", null, c				);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(double[] c)
			{
				unsafe {
					fixed (double* p_c = c)
					{
						Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
						Delegates.pglIndexdv(p_c);
						LogCommand("glIndexdv", null, c						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(float c)
			{
				Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
				Delegates.pglIndexf(c);
				LogCommand("glIndexf", null, c				);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(float[] c)
			{
				unsafe {
					fixed (float* p_c = c)
					{
						Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
						Delegates.pglIndexfv(p_c);
						LogCommand("glIndexfv", null, c						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(Int32 c)
			{
				Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
				Delegates.pglIndexi(c);
				LogCommand("glIndexi", null, c				);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(Int32[] c)
			{
				unsafe {
					fixed (Int32* p_c = c)
					{
						Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
						Delegates.pglIndexiv(p_c);
						LogCommand("glIndexiv", null, c						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(Int16 c)
			{
				Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
				Delegates.pglIndexs(c);
				LogCommand("glIndexs", null, c				);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(Int16[] c)
			{
				unsafe {
					fixed (Int16* p_c = c)
					{
						Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
						Delegates.pglIndexsv(p_c);
						LogCommand("glIndexsv", null, c						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// specify fog parameters
			/// </summary>
			/// <param name="pname">
			/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
			/// Gl.FOG_COORD_SRC are accepted.
			/// </param>
			/// <param name="param">
			/// Specifies the value that <paramref name="pname"/> will be set to.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
			/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.Enable"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Fog(FogParameter pname, float param)
			{
				Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
				Delegates.pglFogf((Int32)pname, param);
				LogCommand("glFogf", null, pname, param				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// specify fog parameters
			/// </summary>
			/// <param name="pname">
			/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
			/// Gl.FOG_COORD_SRC are accepted.
			/// </param>
			/// <param name="params">
			/// A <see cref="T:float[]"/>.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
			/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.Enable"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Fog(FogParameter pname, float[] @params)
			{
				unsafe {
					fixed (float* p_params = @params)
					{
						Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
						Delegates.pglFogfv((Int32)pname, p_params);
						LogCommand("glFogfv", null, pname, @params						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// specify fog parameters
			/// </summary>
			/// <param name="pname">
			/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
			/// Gl.FOG_COORD_SRC are accepted.
			/// </param>
			/// <param name="param">
			/// Specifies the value that <paramref name="pname"/> will be set to.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
			/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.Enable"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Fog(FogParameter pname, Int32 param)
			{
				Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
				Delegates.pglFogi((Int32)pname, param);
				LogCommand("glFogi", null, pname, param				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// specify fog parameters
			/// </summary>
			/// <param name="pname">
			/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
			/// Gl.FOG_COORD_SRC are accepted.
			/// </param>
			/// <param name="params">
			/// A <see cref="T:Int32[]"/>.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
			/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.Enable"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Fog(FogParameter pname, Int32[] @params)
			{
				unsafe {
					fixed (Int32* p_params = @params)
					{
						Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
						Delegates.pglFogiv((Int32)pname, p_params);
						LogCommand("glFogiv", null, pname, @params						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// operate on the accumulation buffer
			/// </summary>
			/// <param name="op">
			/// Specifies the accumulation buffer operation. Symbolic constants Gl.ACCUM, Gl.LOAD, Gl.ADD, Gl.MULT, and Gl.RETURN are 
			/// accepted.
			/// </param>
			/// <param name="value">
			/// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op"/> determines how 
			/// <paramref name="value"/> is used.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="op"/> is not an accepted value.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if there is no accumulation buffer.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Accum is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.Clear"/>
			/// <seealso cref="Gl.ClearAccum"/>
			/// <seealso cref="Gl.CopyPixels"/>
			/// <seealso cref="Gl.DrawBuffer"/>
			/// <seealso cref="Gl.Get"/>
			/// <seealso cref="Gl.ReadBuffer"/>
			/// <seealso cref="Gl.ReadPixels"/>
			/// <seealso cref="Gl.Scissor"/>
			/// <seealso cref="Gl.StencilOp"/>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Accum(AccumOp op, float value)
			{
				Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
				Delegates.pglAccum((Int32)op, value);
				LogCommand("glAccum", null, op, value				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(byte c)
			{
				Debug.Assert(Delegates.pglIndexub != null, "pglIndexub not implemented");
				Delegates.pglIndexub(c);
				LogCommand("glIndexub", null, c				);
			}

			/// <summary>
			/// set the current color index
			/// </summary>
			/// <param name="c">
			/// Specifies the new value for the current color index.
			/// </param>
			/// <seealso cref="Gl.Color"/>
			/// <seealso cref="Gl.IndexPointer"/>
			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public static void Index(byte[] c)
			{
				unsafe {
					fixed (byte* p_c = c)
					{
						Debug.Assert(Delegates.pglIndexubv != null, "pglIndexubv not implemented");
						Delegates.pglIndexubv(p_c);
						LogCommand("glIndexubv", null, c						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// Binding for glFogx.
			/// </summary>
			/// <param name="pname">
			/// A <see cref="T:Int32"/>.
			/// </param>
			/// <param name="param">
			/// A <see cref="T:IntPtr"/>.
			/// </param>
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			public static void Fog(Int32 pname, IntPtr param)
			{
				Debug.Assert(Delegates.pglFogx != null, "pglFogx not implemented");
				Delegates.pglFogx(pname, param);
				LogCommand("glFogx", null, pname, param				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// Binding for glFogxv.
			/// </summary>
			/// <param name="pname">
			/// A <see cref="T:Int32"/>.
			/// </param>
			/// <param name="param">
			/// A <see cref="T:IntPtr[]"/>.
			/// </param>
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			public static void Fog(Int32 pname, IntPtr[] param)
			{
				unsafe {
					fixed (IntPtr* p_param = param)
					{
						Debug.Assert(Delegates.pglFogxv != null, "pglFogxv not implemented");
						Delegates.pglFogxv(pname, p_param);
						LogCommand("glFogxv", null, pname, param						);
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// define histogram table
			/// </summary>
			/// <param name="target">
			/// The histogram whose parameters are to be set. Must be one of Gl.HISTOGRAM or Gl.PROXY_HISTOGRAM.
			/// </param>
			/// <param name="width">
			/// The number of entries in the histogram table. Must be a power of 2.
			/// </param>
			/// <param name="internalformat">
			/// The format of entries in the histogram table. Must be one of Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
			/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
			/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
			/// Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
			/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, or Gl.RGBA16.
			/// </param>
			/// <param name="sink">
			/// If Gl.TRUE, pixels will be consumed by the histogramming process and no drawing or texture loading will take place. If 
			/// Gl.FALSE, pixels will proceed to the minmax process after histogramming.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than zero or is not a power of 2.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.TABLE_TOO_LARGE is generated if <paramref name="target"/> is Gl.HISTOGRAM and the histogram table specified is too 
			/// large for the implementation.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Histogram is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.GetHistogram"/>
			/// <seealso cref="Gl.ResetHistogram"/>
			[AliasOf("glHistogramEXT")]
			[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_histogram")]
			public static void Histogram(Int32 target, Int32 width, Int32 internalformat, bool sink)
			{
				Debug.Assert(Delegates.pglHistogram != null, "pglHistogram not implemented");
				Delegates.pglHistogram(target, width, internalformat, sink);
				LogCommand("glHistogram", null, target, width, internalformat, sink				);
				DebugCheckErrors(null);
			}

			/// <summary>
			/// define minmax table
			/// </summary>
			/// <param name="target">
			/// The minmax table whose parameters are to be set. Must be Gl.MINMAX.
			/// </param>
			/// <param name="internalformat">
			/// The format of entries in the minmax table. Must be one of Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, 
			/// Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8, Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, 
			/// Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8, Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, 
			/// Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA, Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, 
			/// Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, or Gl.RGBA16.
			/// </param>
			/// <param name="sink">
			/// If Gl.TRUE, pixels will be consumed by the minmax process and no drawing or texture loading will take place. If 
			/// Gl.FALSE, pixels will proceed to the final conversion process after minmax.
			/// </param>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the allowable values.
			/// </exception>
			/// <exception cref="KhronosException">
			/// Gl.INVALID_OPERATION is generated if Gl.Minmax is executed between the execution of Gl\.Begin and the corresponding 
			/// execution of Gl\.End.
			/// </exception>
			/// <seealso cref="Gl.GetMinmax"/>
			/// <seealso cref="Gl.ResetMinmax"/>
			[AliasOf("glMinmaxEXT")]
			[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_histogram")]
			public static void Minmax(Int32 target, Int32 internalformat, bool sink)
			{
				Debug.Assert(Delegates.pglMinmax != null, "pglMinmax not implemented");
				Delegates.pglMinmax(target, internalformat, sink);
				LogCommand("glMinmax", null, target, internalformat, sink				);
				DebugCheckErrors(null);
			}

		}

		public static class VBEnum
		{
			/// <summary>
			/// Value of GL_CLEAR symbol.
			/// </summary>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			public const int CLEAR = 0x1500;

			/// <summary>
			/// Gl.Get: When used with non-indexed variants of glGet (such as glGetIntegerv), data returns four values: the x and y 
			/// window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates are both 
			/// set to 0, and the width and height are set to the width and height of the window into which the GL will do its 
			/// rendering. See Gl.Viewport. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns four 
			/// values: the x and y window coordinates of the indexed viewport, followed by its width and height. Initially the x and y 
			/// window coordinates are both set to 0, and the width and height are set to the width and height of the window into which 
			/// the GL will do its rendering. See glViewportIndexedf.
			/// </summary>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			public const int VIEWPORT = 0x0BA2;

			/// <summary>
			/// Value of GL_BITMAP symbol (DEPRECATED).
			/// </summary>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public const int BITMAP = 0x1A00;

			/// <summary>
			/// Value of GL_INDEX symbol.
			/// </summary>
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
			public const int INDEX = 0x8222;

			/// <summary>
			/// <para>
			/// Gl.Enable: If enabled and no fragment shader is active, blend a fog color into the post-texturing color. See Gl.Fog.
			/// </para>
			/// <para>
			/// Gl.Get: params returns a single boolean value indicating whether fogging is enabled. The initial value is Gl.FALSE. See 
			/// Gl.Fog.
			/// </para>
			/// </summary>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_NV_register_combiners")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public const int FOG = 0x0B60;

			/// <summary>
			/// Gl.Accum: Obtains R, G, B, and A values from the buffer currently selected for reading (see Gl.ReadBuffer). Each 
			/// component value is divided by 2n-1, where n is the number of bits allocated to each color component in the currently 
			/// selected buffer. The result is a floating-point value in the range 01, which is multiplied by value and added to the 
			/// corresponding pixel component in the accumulation buffer, thereby updating the accumulation buffer.
			/// </summary>
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public const int ACCUM = 0x0100;

			/// <summary>
			/// <para>
			/// Gl.Enable: If enabled, histogram incoming RGBA color values. See Gl.Histogram.
			/// </para>
			/// <para>
			/// Gl.Get: params returns a single boolean value indicating whether histogram is enabled. The initial value is Gl.FALSE. 
			/// See Gl.Histogram.
			/// </para>
			/// </summary>
			[AliasOf("GL_HISTOGRAM_EXT")]
			[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_histogram")]
			public const int HISTOGRAM = 0x8024;

			/// <summary>
			/// <para>
			/// Gl.Enable: If enabled, compute the minimum and maximum values of incoming RGBA color values. See Gl.Minmax.
			/// </para>
			/// <para>
			/// Gl.Get: params returns a single boolean value indicating whether pixel minmax values are computed. The initial value is 
			/// Gl.FALSE. See Gl.Minmax.
			/// </para>
			/// </summary>
			[AliasOf("GL_MINMAX_EXT")]
			[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_histogram")]
			public const int MINMAX = 0x802E;

		}
}

}
