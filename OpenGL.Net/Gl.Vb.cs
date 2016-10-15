
// Copyright (C) 2015-2016 Luca Piccioni
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
			/// <remarks>
			/// </remarks>
			/// <exception cref="InvalidOperationException">
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
				LogFunction("glClear({0})", mask);
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glViewport({0}, {1}, {2}, {3})", x, y, width, height);
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
			/// <remarks>
			/// </remarks>
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
						LogFunction("glBitmap({0}, {1}, {2}, {3}, {4}, {5}, {6})", width, height, xorig, yorig, xmove, ymove, LogValue(bitmap));
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
				LogFunction("glIndexd({0})", c);
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
						LogFunction("glIndexdv({0})", LogValue(c));
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
				LogFunction("glIndexf({0})", c);
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
						LogFunction("glIndexfv({0})", LogValue(c));
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
				LogFunction("glIndexi({0})", c);
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
						LogFunction("glIndexiv({0})", LogValue(c));
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
				LogFunction("glIndexs({0})", c);
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
						LogFunction("glIndexsv({0})", LogValue(c));
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glFogf({0}, {1})", pname, param);
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
			/// <remarks>
			/// </remarks>
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
						LogFunction("glFogfv({0}, {1})", pname, LogValue(@params));
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glFogi({0}, {1})", pname, param);
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
			/// <remarks>
			/// </remarks>
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
						LogFunction("glFogiv({0}, {1})", pname, LogValue(@params));
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glAccum({0}, {1})", op, value);
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
				LogFunction("glIndexub({0})", c);
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
						LogFunction("glIndexubv({0})", LogValue(c));
					}
				}
				DebugCheckErrors(null);
			}

			/// <summary>
			/// initialize a texture as a data alias of another texture's data store
			/// </summary>
			/// <param name="texture">
			/// Specifies the texture object to be initialized as a view.
			/// </param>
			/// <param name="target">
			/// Specifies the target to be used for the newly initialized texture.
			/// </param>
			/// <param name="origtexture">
			/// Specifies the name of a texture object of which to make a view.
			/// </param>
			/// <param name="internalformat">
			/// Specifies the internal format for the newly created view.
			/// </param>
			/// <param name="minlevel">
			/// Specifies lowest level of detail of the view.
			/// </param>
			/// <param name="numlevels">
			/// Specifies the number of levels of detail to include in the view.
			/// </param>
			/// <param name="minlayer">
			/// Specifies the index of the first layer to include in the view.
			/// </param>
			/// <param name="numlayers">
			/// Specifies the number of layers to include in the view.
			/// </param>
			/// <remarks>
			/// </remarks>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_VALUE is generated if <paramref name="minlayer"/> or <paramref name="minlevel"/> are larger than the greatest 
			/// layer or level of <paramref name="origtexture"/>.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not compatible with the target of <paramref 
			/// name="origtexture"/>.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if the dimensions of <paramref name="origtexture"/> are greater than the maximum 
			/// supported dimensions for <paramref name="target"/>.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is not compatible with the internal format of 
			/// <paramref name="origtexture"/>.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has already been bound or otherwise given a target.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for <paramref name="origtexture"/> is not 
			/// Gl.TRUE.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_OPERATION is generated if <paramref name="origtexture"/> is not the name of an existing texture object.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_VALUE is generaged if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP and <paramref name="numlayers"/> is 
			/// not 6, or if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP_ARRAY and <paramref name="numlayers"/> is not an integer 
			/// multiple of 6.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, 
			/// Gl.TEXTURE_RECTANGLE, or Gl.TEXTURE_2D_MULTISAMPLE and <paramref name="numlayers"/> does not equal 1.
			/// </exception>
			/// <exception cref="InvalidOperationException">
			/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> zero or is not the name of a texture previously returned 
			/// from a successful call to glGenTextures.
			/// </exception>
			/// <seealso cref="Gl.TexStorage1D"/>
			/// <seealso cref="Gl.TexStorage2D"/>
			/// <seealso cref="Gl.TexStorage3D"/>
			/// <seealso cref="Gl.GetTexParameter"/>
			[AliasOf("glTextureViewEXT")]
			[AliasOf("glTextureViewOES")]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
			[RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
			public static void Texture(UInt32 texture, Int32 target, UInt32 origtexture, Int32 internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
			{
				Debug.Assert(Delegates.pglTextureView != null, "pglTextureView not implemented");
				Delegates.pglTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
				LogFunction("glTextureView({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, LogEnumName(target), origtexture, LogEnumName(internalformat), minlevel, numlevels, minlayer, numlayers);
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
				LogFunction("glFogx({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
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
						LogFunction("glFogxv({0}, {1})", LogEnumName(pname), LogValue(param));
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glHistogram({0}, {1}, {2}, {3})", LogEnumName(target), width, LogEnumName(internalformat), sink);
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
			/// <remarks>
			/// </remarks>
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
				LogFunction("glMinmax({0}, {1}, {2})", LogEnumName(target), LogEnumName(internalformat), sink);
				DebugCheckErrors(null);
			}

		}
}

}
