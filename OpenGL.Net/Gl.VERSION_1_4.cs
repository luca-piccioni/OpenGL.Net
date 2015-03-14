
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
		/// Value of GL_BLEND_DST_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_DST_RGB = 0x80C8;

		/// <summary>
		/// Value of GL_BLEND_SRC_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_SRC_RGB = 0x80C9;

		/// <summary>
		/// Value of GL_BLEND_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_DST_ALPHA = 0x80CA;

		/// <summary>
		/// Value of GL_BLEND_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_SRC_ALPHA = 0x80CB;

		/// <summary>
		/// Value of GL_POINT_FADE_THRESHOLD_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT16 = 0x81A5;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT24 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT24 = 0x81A6;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT32 = 0x81A7;

		/// <summary>
		/// Value of GL_MIRRORED_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int MIRRORED_REPEAT = 0x8370;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_LOD_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;

		/// <summary>
		/// Value of GL_TEXTURE_LOD_BIAS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_LOD_BIAS = 0x8501;

		/// <summary>
		/// Value of GL_INCR_WRAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int INCR_WRAP = 0x8507;

		/// <summary>
		/// Value of GL_DECR_WRAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DECR_WRAP = 0x8508;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_DEPTH_SIZE = 0x884A;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_COMPARE_MODE = 0x884C;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_FUNC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_COMPARE_FUNC = 0x884D;

		/// <summary>
		/// Value of GL_POINT_SIZE_MIN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MIN = 0x8126;

		/// <summary>
		/// Value of GL_POINT_SIZE_MAX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MAX = 0x8127;

		/// <summary>
		/// Value of GL_POINT_DISTANCE_ATTENUATION symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_DISTANCE_ATTENUATION = 0x8129;

		/// <summary>
		/// Value of GL_GENERATE_MIPMAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP = 0x8191;

		/// <summary>
		/// Value of GL_GENERATE_MIPMAP_HINT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP_HINT = 0x8192;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_SOURCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_SOURCE = 0x8450;

		/// <summary>
		/// Value of GL_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE = 0x8451;

		/// <summary>
		/// Value of GL_FRAGMENT_DEPTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FRAGMENT_DEPTH = 0x8452;

		/// <summary>
		/// Value of GL_CURRENT_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_FOG_COORDINATE = 0x8453;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_TYPE = 0x8454;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_STRIDE = 0x8455;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_POINTER = 0x8456;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY = 0x8457;

		/// <summary>
		/// Value of GL_COLOR_SUM symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_SUM = 0x8458;

		/// <summary>
		/// Value of GL_CURRENT_SECONDARY_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_SECONDARY_COLOR = 0x8459;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_SIZE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_SIZE = 0x845A;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_TYPE = 0x845B;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_POINTER = 0x845D;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY = 0x845E;

		/// <summary>
		/// Value of GL_TEXTURE_FILTER_CONTROL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_FILTER_CONTROL = 0x8500;

		/// <summary>
		/// Value of GL_DEPTH_TEXTURE_MODE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_TEXTURE_MODE = 0x884B;

		/// <summary>
		/// Value of GL_COMPARE_R_TO_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPARE_R_TO_TEXTURE = 0x884E;

		/// <summary>
		/// Value of GL_FUNC_ADD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_ADD = 0x8006;

		/// <summary>
		/// Value of GL_FUNC_SUBTRACT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_SUBTRACT = 0x800A;

		/// <summary>
		/// Value of GL_FUNC_REVERSE_SUBTRACT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_REVERSE_SUBTRACT = 0x800B;

		/// <summary>
		/// Value of GL_MIN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MIN = 0x8007;

		/// <summary>
		/// Value of GL_MAX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX = 0x8008;

		/// <summary>
		/// Value of GL_CONSTANT_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_COLOR = 0x8001;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;

		/// <summary>
		/// Value of GL_CONSTANT_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_ALPHA = 0x8003;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;

		/// <summary>
		/// specify pixel arithmetic for RGB and alpha components separately
		/// </summary>
		/// <param name="sfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha)
		{
			if        (Delegates.pglBlendFuncSeparate != null) {
				Delegates.pglBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
				CallLog("glBlendFuncSeparate({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			} else if (Delegates.pglBlendFuncSeparateEXT != null) {
				Delegates.pglBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
				CallLog("glBlendFuncSeparateEXT({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			} else if (Delegates.pglBlendFuncSeparateINGR != null) {
				Delegates.pglBlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
				CallLog("glBlendFuncSeparateINGR({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			} else
				throw new NotImplementedException("glBlendFuncSeparate (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Points to an array of starting indices in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Points to an array of the number of indices to be rendered.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the first and count
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawArrays(PrimitiveType mode, Int32[] first, Int32[] count, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					if        (Delegates.pglMultiDrawArrays != null) {
						Delegates.pglMultiDrawArrays((int)mode, p_first, p_count, drawcount);
						CallLog("glMultiDrawArrays({0}, {1}, {2}, {3})", mode, first, count, drawcount);
					} else if (Delegates.pglMultiDrawArraysEXT != null) {
						Delegates.pglMultiDrawArraysEXT((int)mode, p_first, p_count, drawcount);
						CallLog("glMultiDrawArraysEXT({0}, {1}, {2}, {3})", mode, first, count, drawcount);
					} else
						throw new NotImplementedException("glMultiDrawArrays (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count and indices arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawElements(PrimitiveType mode, Int32[] count, int type, IntPtr indices, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				{
					if        (Delegates.pglMultiDrawElements != null) {
						Delegates.pglMultiDrawElements((int)mode, p_count, type, indices, drawcount);
						CallLog("glMultiDrawElements({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, drawcount);
					} else if (Delegates.pglMultiDrawElementsEXT != null) {
						Delegates.pglMultiDrawElementsEXT((int)mode, p_count, type, indices, drawcount);
						CallLog("glMultiDrawElementsEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, drawcount);
					} else
						throw new NotImplementedException("glMultiDrawElements (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count and indices arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawElements(int mode, Int32[] count, int type, Object indices, Int32 drawcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElements(mode, count, type, pin_indices.AddrOfPinnedObject(), drawcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count and indices arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawElements(PrimitiveType mode, Int32[] count, int type, Object indices, Int32 drawcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElements(mode, count, type, pin_indices.AddrOfPinnedObject(), drawcount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, float param)
		{
			if        (Delegates.pglPointParameterf != null) {
				Delegates.pglPointParameterf(pname, param);
				CallLog("glPointParameterf({0}, {1})", pname, param);
			} else if (Delegates.pglPointParameterfARB != null) {
				Delegates.pglPointParameterfARB(pname, param);
				CallLog("glPointParameterfARB({0}, {1})", pname, param);
			} else if (Delegates.pglPointParameterfEXT != null) {
				Delegates.pglPointParameterfEXT(pname, param);
				CallLog("glPointParameterfEXT({0}, {1})", pname, param);
			} else if (Delegates.pglPointParameterfSGIS != null) {
				Delegates.pglPointParameterfSGIS(pname, param);
				CallLog("glPointParameterfSGIS({0}, {1})", pname, param);
			} else
				throw new NotImplementedException("glPointParameterf (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglPointParameterfv != null) {
						Delegates.pglPointParameterfv(pname, p_params);
						CallLog("glPointParameterfv({0}, {1})", pname, @params);
					} else if (Delegates.pglPointParameterfvARB != null) {
						Delegates.pglPointParameterfvARB(pname, p_params);
						CallLog("glPointParameterfvARB({0}, {1})", pname, @params);
					} else if (Delegates.pglPointParameterfvEXT != null) {
						Delegates.pglPointParameterfvEXT(pname, p_params);
						CallLog("glPointParameterfvEXT({0}, {1})", pname, @params);
					} else if (Delegates.pglPointParameterfvSGIS != null) {
						Delegates.pglPointParameterfvSGIS(pname, p_params);
						CallLog("glPointParameterfvSGIS({0}, {1})", pname, @params);
					} else
						throw new NotImplementedException("glPointParameterfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, Int32 param)
		{
			if        (Delegates.pglPointParameteri != null) {
				Delegates.pglPointParameteri(pname, param);
				CallLog("glPointParameteri({0}, {1})", pname, param);
			} else if (Delegates.pglPointParameteriNV != null) {
				Delegates.pglPointParameteriNV(pname, param);
				CallLog("glPointParameteriNV({0}, {1})", pname, param);
			} else
				throw new NotImplementedException("glPointParameteri (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglPointParameteriv != null) {
						Delegates.pglPointParameteriv(pname, p_params);
						CallLog("glPointParameteriv({0}, {1})", pname, @params);
					} else if (Delegates.pglPointParameterivNV != null) {
						Delegates.pglPointParameterivNV(pname, p_params);
						CallLog("glPointParameterivNV({0}, {1})", pname, @params);
					} else
						throw new NotImplementedException("glPointParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float coord)
		{
			if        (Delegates.pglFogCoordf != null) {
				Delegates.pglFogCoordf(coord);
				CallLog("glFogCoordf({0})", coord);
			} else if (Delegates.pglFogCoordfEXT != null) {
				Delegates.pglFogCoordfEXT(coord);
				CallLog("glFogCoordfEXT({0})", coord);
			} else
				throw new NotImplementedException("glFogCoordf (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float[] coord)
		{
			unsafe {
				fixed (float* p_coord = coord)
				{
					if        (Delegates.pglFogCoordfv != null) {
						Delegates.pglFogCoordfv(p_coord);
						CallLog("glFogCoordfv({0})", coord);
					} else if (Delegates.pglFogCoordfvEXT != null) {
						Delegates.pglFogCoordfvEXT(p_coord);
						CallLog("glFogCoordfvEXT({0})", coord);
					} else
						throw new NotImplementedException("glFogCoordfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double coord)
		{
			if        (Delegates.pglFogCoordd != null) {
				Delegates.pglFogCoordd(coord);
				CallLog("glFogCoordd({0})", coord);
			} else if (Delegates.pglFogCoorddEXT != null) {
				Delegates.pglFogCoorddEXT(coord);
				CallLog("glFogCoorddEXT({0})", coord);
			} else
				throw new NotImplementedException("glFogCoordd (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double[] coord)
		{
			unsafe {
				fixed (double* p_coord = coord)
				{
					if        (Delegates.pglFogCoorddv != null) {
						Delegates.pglFogCoorddv(p_coord);
						CallLog("glFogCoorddv({0})", coord);
					} else if (Delegates.pglFogCoorddvEXT != null) {
						Delegates.pglFogCoorddvEXT(p_coord);
						CallLog("glFogCoorddvEXT({0})", coord);
					} else
						throw new NotImplementedException("glFogCoorddv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> 
		/// are accepted. The initial value is <see cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglFogCoordPointer != null) {
				Delegates.pglFogCoordPointer((int)type, stride, pointer);
				CallLog("glFogCoordPointer({0}, {1}, {2})", type, stride, pointer);
			} else if (Delegates.pglFogCoordPointerEXT != null) {
				Delegates.pglFogCoordPointerEXT((int)type, stride, pointer);
				CallLog("glFogCoordPointerEXT({0}, {1}, {2})", type, stride, pointer);
			} else
				throw new NotImplementedException("glFogCoordPointer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> 
		/// are accepted. The initial value is <see cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> 
		/// are accepted. The initial value is <see cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
		{
			if        (Delegates.pglSecondaryColor3b != null) {
				Delegates.pglSecondaryColor3b(red, green, blue);
				CallLog("glSecondaryColor3b({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3bEXT != null) {
				Delegates.pglSecondaryColor3bEXT(red, green, blue);
				CallLog("glSecondaryColor3bEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3b (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3bv != null) {
						Delegates.pglSecondaryColor3bv(p_v);
						CallLog("glSecondaryColor3bv({0})", v);
					} else if (Delegates.pglSecondaryColor3bvEXT != null) {
						Delegates.pglSecondaryColor3bvEXT(p_v);
						CallLog("glSecondaryColor3bvEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3bv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double red, double green, double blue)
		{
			if        (Delegates.pglSecondaryColor3d != null) {
				Delegates.pglSecondaryColor3d(red, green, blue);
				CallLog("glSecondaryColor3d({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3dEXT != null) {
				Delegates.pglSecondaryColor3dEXT(red, green, blue);
				CallLog("glSecondaryColor3dEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3dv != null) {
						Delegates.pglSecondaryColor3dv(p_v);
						CallLog("glSecondaryColor3dv({0})", v);
					} else if (Delegates.pglSecondaryColor3dvEXT != null) {
						Delegates.pglSecondaryColor3dvEXT(p_v);
						CallLog("glSecondaryColor3dvEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float red, float green, float blue)
		{
			if        (Delegates.pglSecondaryColor3f != null) {
				Delegates.pglSecondaryColor3f(red, green, blue);
				CallLog("glSecondaryColor3f({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3fEXT != null) {
				Delegates.pglSecondaryColor3fEXT(red, green, blue);
				CallLog("glSecondaryColor3fEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3fv != null) {
						Delegates.pglSecondaryColor3fv(p_v);
						CallLog("glSecondaryColor3fv({0})", v);
					} else if (Delegates.pglSecondaryColor3fvEXT != null) {
						Delegates.pglSecondaryColor3fvEXT(p_v);
						CallLog("glSecondaryColor3fvEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32 red, Int32 green, Int32 blue)
		{
			if        (Delegates.pglSecondaryColor3i != null) {
				Delegates.pglSecondaryColor3i(red, green, blue);
				CallLog("glSecondaryColor3i({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3iEXT != null) {
				Delegates.pglSecondaryColor3iEXT(red, green, blue);
				CallLog("glSecondaryColor3iEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3iv != null) {
						Delegates.pglSecondaryColor3iv(p_v);
						CallLog("glSecondaryColor3iv({0})", v);
					} else if (Delegates.pglSecondaryColor3ivEXT != null) {
						Delegates.pglSecondaryColor3ivEXT(p_v);
						CallLog("glSecondaryColor3ivEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16 red, Int16 green, Int16 blue)
		{
			if        (Delegates.pglSecondaryColor3s != null) {
				Delegates.pglSecondaryColor3s(red, green, blue);
				CallLog("glSecondaryColor3s({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3sEXT != null) {
				Delegates.pglSecondaryColor3sEXT(red, green, blue);
				CallLog("glSecondaryColor3sEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3sv != null) {
						Delegates.pglSecondaryColor3sv(p_v);
						CallLog("glSecondaryColor3sv({0})", v);
					} else if (Delegates.pglSecondaryColor3svEXT != null) {
						Delegates.pglSecondaryColor3svEXT(p_v);
						CallLog("glSecondaryColor3svEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte red, byte green, byte blue)
		{
			if        (Delegates.pglSecondaryColor3ub != null) {
				Delegates.pglSecondaryColor3ub(red, green, blue);
				CallLog("glSecondaryColor3ub({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3ubEXT != null) {
				Delegates.pglSecondaryColor3ubEXT(red, green, blue);
				CallLog("glSecondaryColor3ubEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3ub (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3ubv != null) {
						Delegates.pglSecondaryColor3ubv(p_v);
						CallLog("glSecondaryColor3ubv({0})", v);
					} else if (Delegates.pglSecondaryColor3ubvEXT != null) {
						Delegates.pglSecondaryColor3ubvEXT(p_v);
						CallLog("glSecondaryColor3ubvEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3ubv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32 red, UInt32 green, UInt32 blue)
		{
			if        (Delegates.pglSecondaryColor3ui != null) {
				Delegates.pglSecondaryColor3ui(red, green, blue);
				CallLog("glSecondaryColor3ui({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3uiEXT != null) {
				Delegates.pglSecondaryColor3uiEXT(red, green, blue);
				CallLog("glSecondaryColor3uiEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3uiv != null) {
						Delegates.pglSecondaryColor3uiv(p_v);
						CallLog("glSecondaryColor3uiv({0})", v);
					} else if (Delegates.pglSecondaryColor3uivEXT != null) {
						Delegates.pglSecondaryColor3uivEXT(p_v);
						CallLog("glSecondaryColor3uivEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16 red, UInt16 green, UInt16 blue)
		{
			if        (Delegates.pglSecondaryColor3us != null) {
				Delegates.pglSecondaryColor3us(red, green, blue);
				CallLog("glSecondaryColor3us({0}, {1}, {2})", red, green, blue);
			} else if (Delegates.pglSecondaryColor3usEXT != null) {
				Delegates.pglSecondaryColor3usEXT(red, green, blue);
				CallLog("glSecondaryColor3usEXT({0}, {1}, {2})", red, green, blue);
			} else
				throw new NotImplementedException("glSecondaryColor3us (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					if        (Delegates.pglSecondaryColor3usv != null) {
						Delegates.pglSecondaryColor3usv(p_v);
						CallLog("glSecondaryColor3usv({0})", v);
					} else if (Delegates.pglSecondaryColor3usvEXT != null) {
						Delegates.pglSecondaryColor3usvEXT(p_v);
						CallLog("glSecondaryColor3usvEXT({0})", v);
					} else
						throw new NotImplementedException("glSecondaryColor3usv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> are accepted. The initial value is <see 
		/// cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglSecondaryColorPointer != null) {
				Delegates.pglSecondaryColorPointer(size, (int)type, stride, pointer);
				CallLog("glSecondaryColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			} else if (Delegates.pglSecondaryColorPointerEXT != null) {
				Delegates.pglSecondaryColorPointerEXT(size, (int)type, stride, pointer);
				CallLog("glSecondaryColorPointerEXT({0}, {1}, {2}, {3})", size, type, stride, pointer);
			} else
				throw new NotImplementedException("glSecondaryColorPointer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> are accepted. The initial value is <see 
		/// cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> are accepted. The initial value is <see 
		/// cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double x, double y)
		{
			if        (Delegates.pglWindowPos2d != null) {
				Delegates.pglWindowPos2d(x, y);
				CallLog("glWindowPos2d({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2dARB != null) {
				Delegates.pglWindowPos2dARB(x, y);
				CallLog("glWindowPos2dARB({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2dMESA != null) {
				Delegates.pglWindowPos2dMESA(x, y);
				CallLog("glWindowPos2dMESA({0}, {1})", x, y);
			} else
				throw new NotImplementedException("glWindowPos2d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglWindowPos2dv != null) {
						Delegates.pglWindowPos2dv(p_v);
						CallLog("glWindowPos2dv({0})", v);
					} else if (Delegates.pglWindowPos2dvARB != null) {
						Delegates.pglWindowPos2dvARB(p_v);
						CallLog("glWindowPos2dvARB({0})", v);
					} else if (Delegates.pglWindowPos2dvMESA != null) {
						Delegates.pglWindowPos2dvMESA(p_v);
						CallLog("glWindowPos2dvMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos2dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float x, float y)
		{
			if        (Delegates.pglWindowPos2f != null) {
				Delegates.pglWindowPos2f(x, y);
				CallLog("glWindowPos2f({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2fARB != null) {
				Delegates.pglWindowPos2fARB(x, y);
				CallLog("glWindowPos2fARB({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2fMESA != null) {
				Delegates.pglWindowPos2fMESA(x, y);
				CallLog("glWindowPos2fMESA({0}, {1})", x, y);
			} else
				throw new NotImplementedException("glWindowPos2f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglWindowPos2fv != null) {
						Delegates.pglWindowPos2fv(p_v);
						CallLog("glWindowPos2fv({0})", v);
					} else if (Delegates.pglWindowPos2fvARB != null) {
						Delegates.pglWindowPos2fvARB(p_v);
						CallLog("glWindowPos2fvARB({0})", v);
					} else if (Delegates.pglWindowPos2fvMESA != null) {
						Delegates.pglWindowPos2fvMESA(p_v);
						CallLog("glWindowPos2fvMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32 x, Int32 y)
		{
			if        (Delegates.pglWindowPos2i != null) {
				Delegates.pglWindowPos2i(x, y);
				CallLog("glWindowPos2i({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2iARB != null) {
				Delegates.pglWindowPos2iARB(x, y);
				CallLog("glWindowPos2iARB({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2iMESA != null) {
				Delegates.pglWindowPos2iMESA(x, y);
				CallLog("glWindowPos2iMESA({0}, {1})", x, y);
			} else
				throw new NotImplementedException("glWindowPos2i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglWindowPos2iv != null) {
						Delegates.pglWindowPos2iv(p_v);
						CallLog("glWindowPos2iv({0})", v);
					} else if (Delegates.pglWindowPos2ivARB != null) {
						Delegates.pglWindowPos2ivARB(p_v);
						CallLog("glWindowPos2ivARB({0})", v);
					} else if (Delegates.pglWindowPos2ivMESA != null) {
						Delegates.pglWindowPos2ivMESA(p_v);
						CallLog("glWindowPos2ivMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos2iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16 x, Int16 y)
		{
			if        (Delegates.pglWindowPos2s != null) {
				Delegates.pglWindowPos2s(x, y);
				CallLog("glWindowPos2s({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2sARB != null) {
				Delegates.pglWindowPos2sARB(x, y);
				CallLog("glWindowPos2sARB({0}, {1})", x, y);
			} else if (Delegates.pglWindowPos2sMESA != null) {
				Delegates.pglWindowPos2sMESA(x, y);
				CallLog("glWindowPos2sMESA({0}, {1})", x, y);
			} else
				throw new NotImplementedException("glWindowPos2s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglWindowPos2sv != null) {
						Delegates.pglWindowPos2sv(p_v);
						CallLog("glWindowPos2sv({0})", v);
					} else if (Delegates.pglWindowPos2svARB != null) {
						Delegates.pglWindowPos2svARB(p_v);
						CallLog("glWindowPos2svARB({0})", v);
					} else if (Delegates.pglWindowPos2svMESA != null) {
						Delegates.pglWindowPos2svMESA(p_v);
						CallLog("glWindowPos2svMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos2sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double x, double y, double z)
		{
			if        (Delegates.pglWindowPos3d != null) {
				Delegates.pglWindowPos3d(x, y, z);
				CallLog("glWindowPos3d({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3dARB != null) {
				Delegates.pglWindowPos3dARB(x, y, z);
				CallLog("glWindowPos3dARB({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3dMESA != null) {
				Delegates.pglWindowPos3dMESA(x, y, z);
				CallLog("glWindowPos3dMESA({0}, {1}, {2})", x, y, z);
			} else
				throw new NotImplementedException("glWindowPos3d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglWindowPos3dv != null) {
						Delegates.pglWindowPos3dv(p_v);
						CallLog("glWindowPos3dv({0})", v);
					} else if (Delegates.pglWindowPos3dvARB != null) {
						Delegates.pglWindowPos3dvARB(p_v);
						CallLog("glWindowPos3dvARB({0})", v);
					} else if (Delegates.pglWindowPos3dvMESA != null) {
						Delegates.pglWindowPos3dvMESA(p_v);
						CallLog("glWindowPos3dvMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos3dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float x, float y, float z)
		{
			if        (Delegates.pglWindowPos3f != null) {
				Delegates.pglWindowPos3f(x, y, z);
				CallLog("glWindowPos3f({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3fARB != null) {
				Delegates.pglWindowPos3fARB(x, y, z);
				CallLog("glWindowPos3fARB({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3fMESA != null) {
				Delegates.pglWindowPos3fMESA(x, y, z);
				CallLog("glWindowPos3fMESA({0}, {1}, {2})", x, y, z);
			} else
				throw new NotImplementedException("glWindowPos3f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglWindowPos3fv != null) {
						Delegates.pglWindowPos3fv(p_v);
						CallLog("glWindowPos3fv({0})", v);
					} else if (Delegates.pglWindowPos3fvARB != null) {
						Delegates.pglWindowPos3fvARB(p_v);
						CallLog("glWindowPos3fvARB({0})", v);
					} else if (Delegates.pglWindowPos3fvMESA != null) {
						Delegates.pglWindowPos3fvMESA(p_v);
						CallLog("glWindowPos3fvMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32 x, Int32 y, Int32 z)
		{
			if        (Delegates.pglWindowPos3i != null) {
				Delegates.pglWindowPos3i(x, y, z);
				CallLog("glWindowPos3i({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3iARB != null) {
				Delegates.pglWindowPos3iARB(x, y, z);
				CallLog("glWindowPos3iARB({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3iMESA != null) {
				Delegates.pglWindowPos3iMESA(x, y, z);
				CallLog("glWindowPos3iMESA({0}, {1}, {2})", x, y, z);
			} else
				throw new NotImplementedException("glWindowPos3i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglWindowPos3iv != null) {
						Delegates.pglWindowPos3iv(p_v);
						CallLog("glWindowPos3iv({0})", v);
					} else if (Delegates.pglWindowPos3ivARB != null) {
						Delegates.pglWindowPos3ivARB(p_v);
						CallLog("glWindowPos3ivARB({0})", v);
					} else if (Delegates.pglWindowPos3ivMESA != null) {
						Delegates.pglWindowPos3ivMESA(p_v);
						CallLog("glWindowPos3ivMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16 x, Int16 y, Int16 z)
		{
			if        (Delegates.pglWindowPos3s != null) {
				Delegates.pglWindowPos3s(x, y, z);
				CallLog("glWindowPos3s({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3sARB != null) {
				Delegates.pglWindowPos3sARB(x, y, z);
				CallLog("glWindowPos3sARB({0}, {1}, {2})", x, y, z);
			} else if (Delegates.pglWindowPos3sMESA != null) {
				Delegates.pglWindowPos3sMESA(x, y, z);
				CallLog("glWindowPos3sMESA({0}, {1}, {2})", x, y, z);
			} else
				throw new NotImplementedException("glWindowPos3s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglWindowPos3sv != null) {
						Delegates.pglWindowPos3sv(p_v);
						CallLog("glWindowPos3sv({0})", v);
					} else if (Delegates.pglWindowPos3svARB != null) {
						Delegates.pglWindowPos3svARB(p_v);
						CallLog("glWindowPos3svARB({0})", v);
					} else if (Delegates.pglWindowPos3svMESA != null) {
						Delegates.pglWindowPos3svMESA(p_v);
						CallLog("glWindowPos3svMESA({0})", v);
					} else
						throw new NotImplementedException("glWindowPos3sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the blend color
		/// </summary>
		/// <param name="red">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="green">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="blue">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="alpha">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public static void BlendColor(float red, float green, float blue, float alpha)
		{
			if        (Delegates.pglBlendColor != null) {
				Delegates.pglBlendColor(red, green, blue, alpha);
				CallLog("glBlendColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			} else if (Delegates.pglBlendColorEXT != null) {
				Delegates.pglBlendColorEXT(red, green, blue, alpha);
				CallLog("glBlendColorEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			} else
				throw new NotImplementedException("glBlendColor (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the equation used for both the RGB blend equation and the Alpha blend equation
		/// </summary>
		/// <param name="mode">
		/// specifies how source and destination colors are combined. It must be <see cref="Gl.FUNC_ADD"/>, <see 
		/// cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public static void BlendEquation(int mode)
		{
			if        (Delegates.pglBlendEquation != null) {
				Delegates.pglBlendEquation(mode);
				CallLog("glBlendEquation({0})", mode);
			} else if (Delegates.pglBlendEquationEXT != null) {
				Delegates.pglBlendEquationEXT(mode);
				CallLog("glBlendEquationEXT({0})", mode);
			} else
				throw new NotImplementedException("glBlendEquation (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
