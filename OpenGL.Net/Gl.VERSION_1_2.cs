
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
		/// Value of GL_UNSIGNED_BYTE_3_3_2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_BYTE_3_3_2 = 0x8032;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_5_5_1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8 = 0x8035;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10_10_10_2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_10_10_10_2 = 0x8036;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_3D = 0x806A;

		/// <summary>
		/// Value of GL_PACK_SKIP_IMAGES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_SKIP_IMAGES = 0x806B;

		/// <summary>
		/// Value of GL_PACK_IMAGE_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PACK_IMAGE_HEIGHT = 0x806C;

		/// <summary>
		/// Value of GL_UNPACK_SKIP_IMAGES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNPACK_SKIP_IMAGES = 0x806D;

		/// <summary>
		/// Value of GL_UNPACK_IMAGE_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNPACK_IMAGE_HEIGHT = 0x806E;

		/// <summary>
		/// Value of GL_TEXTURE_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_3D = 0x806F;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int PROXY_TEXTURE_3D = 0x8070;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_DEPTH = 0x8071;

		/// <summary>
		/// Value of GL_TEXTURE_WRAP_R symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_WRAP_R = 0x8072;

		/// <summary>
		/// Value of GL_MAX_3D_TEXTURE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_3D_TEXTURE_SIZE = 0x8073;

		/// <summary>
		/// Value of GL_UNSIGNED_BYTE_2_3_3_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_BYTE_2_3_3_REV = 0x8362;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_6_5 = 0x8363;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_5_6_5_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_5_6_5_REV = 0x8364;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_4_4_4_4_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

		/// <summary>
		/// Value of GL_UNSIGNED_SHORT_1_5_5_5_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_8_8_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int UNSIGNED_INT_8_8_8_8_REV = 0x8367;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_2_10_10_10_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public const int UNSIGNED_INT_2_10_10_10_REV = 0x8368;

		/// <summary>
		/// Value of GL_BGR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int BGR = 0x80E0;

		/// <summary>
		/// Value of GL_BGRA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_array_bgra")]
		[RequiredByFeature("GL_EXT_vertex_array_bgra")]
		public const int BGRA = 0x80E1;

		/// <summary>
		/// Value of GL_MAX_ELEMENTS_VERTICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_VERTICES = 0x80E8;

		/// <summary>
		/// Value of GL_MAX_ELEMENTS_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int MAX_ELEMENTS_INDICES = 0x80E9;

		/// <summary>
		/// Value of GL_CLAMP_TO_EDGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int CLAMP_TO_EDGE = 0x812F;

		/// <summary>
		/// Value of GL_TEXTURE_MIN_LOD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MIN_LOD = 0x813A;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_LOD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LOD = 0x813B;

		/// <summary>
		/// Value of GL_TEXTURE_BASE_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_BASE_LEVEL = 0x813C;

		/// <summary>
		/// Value of GL_TEXTURE_MAX_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int TEXTURE_MAX_LEVEL = 0x813D;

		/// <summary>
		/// Value of GL_SMOOTH_POINT_SIZE_RANGE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to POINT_SIZE_RANGE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int SMOOTH_POINT_SIZE_RANGE = 0x0B12;

		/// <summary>
		/// Value of GL_SMOOTH_POINT_SIZE_GRANULARITY symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to POINT_SIZE_GRANULARITY.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;

		/// <summary>
		/// Value of GL_SMOOTH_LINE_WIDTH_RANGE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to LINE_WIDTH_RANGE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int SMOOTH_LINE_WIDTH_RANGE = 0x0B22;

		/// <summary>
		/// Value of GL_SMOOTH_LINE_WIDTH_GRANULARITY symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to LINE_WIDTH_GRANULARITY.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;

		/// <summary>
		/// Value of GL_ALIASED_LINE_WIDTH_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;

		/// <summary>
		/// Value of GL_RESCALE_NORMAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RESCALE_NORMAL = 0x803A;

		/// <summary>
		/// Value of GL_LIGHT_MODEL_COLOR_CONTROL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

		/// <summary>
		/// Value of GL_SINGLE_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SINGLE_COLOR = 0x81F9;

		/// <summary>
		/// Value of GL_SEPARATE_SPECULAR_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SEPARATE_SPECULAR_COLOR = 0x81FA;

		/// <summary>
		/// Value of GL_ALIASED_POINT_SIZE_RANGE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALIASED_POINT_SIZE_RANGE = 0x846D;

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in indices.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in indices.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// glDrawRangeElements is a restricted form of glDrawElements. mode, start, end, and count match the corresponding 
		/// arguments to glDrawElements, with the additional constraint that all values in the arrays count must lie between start 
		/// and end, inclusive.
		/// Implementations denote recommended maximum amounts of vertex and index data, which may be queried by calling glGet with 
		/// argument GL_MAX_ELEMENTS_VERTICES and GL_MAX_ELEMENTS_INDICES. If end-start+1 is greater than the value of 
		/// GL_MAX_ELEMENTS_VERTICES, or if count is greater than the value of GL_MAX_ELEMENTS_INDICES, then the call may operate at 
		/// reduced performance. There is no requirement that all vertices in the range startend be referenced. However, the 
		/// implementation may partially process unused vertices, reducing performance from what could be achieved with an optimal 
		/// index set.
		/// When glDrawRangeElements is called, it uses count sequential elements from an enabled array, starting at start to 
		/// construct a sequence of geometric primitives. mode specifies what kind of primitives are constructed, and how the array 
		/// elements construct these primitives. If more than one array is enabled, each is used.
		/// Vertex attributes that are modified by glDrawRangeElements have an unspecified value after glDrawRangeElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - It is an error for indices to lie outside the range startend, but implementations may not check for this situation. Such 
		///   indices cause implementation-dependent behavior.
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if count is negative.
		/// - GL_INVALID_VALUE is generated if end&lt;start.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_ELEMENTS_VERTICES
		/// - glGet with argument GL_MAX_ELEMENTS_INDICES
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices)
		{
			if        (Delegates.pglDrawRangeElements != null) {
				Delegates.pglDrawRangeElements(mode, start, end, count, type, indices);
				CallLog("glDrawRangeElements({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else if (Delegates.pglDrawRangeElementsEXT != null) {
				Delegates.pglDrawRangeElementsEXT(mode, start, end, count, type, indices);
				CallLog("glDrawRangeElementsEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else
				throw new NotImplementedException("glDrawRangeElements (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in indices.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in indices.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// glDrawRangeElements is a restricted form of glDrawElements. mode, start, end, and count match the corresponding 
		/// arguments to glDrawElements, with the additional constraint that all values in the arrays count must lie between start 
		/// and end, inclusive.
		/// Implementations denote recommended maximum amounts of vertex and index data, which may be queried by calling glGet with 
		/// argument GL_MAX_ELEMENTS_VERTICES and GL_MAX_ELEMENTS_INDICES. If end-start+1 is greater than the value of 
		/// GL_MAX_ELEMENTS_VERTICES, or if count is greater than the value of GL_MAX_ELEMENTS_INDICES, then the call may operate at 
		/// reduced performance. There is no requirement that all vertices in the range startend be referenced. However, the 
		/// implementation may partially process unused vertices, reducing performance from what could be achieved with an optimal 
		/// index set.
		/// When glDrawRangeElements is called, it uses count sequential elements from an enabled array, starting at start to 
		/// construct a sequence of geometric primitives. mode specifies what kind of primitives are constructed, and how the array 
		/// elements construct these primitives. If more than one array is enabled, each is used.
		/// Vertex attributes that are modified by glDrawRangeElements have an unspecified value after glDrawRangeElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - It is an error for indices to lie outside the range startend, but implementations may not check for this situation. Such 
		///   indices cause implementation-dependent behavior.
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if count is negative.
		/// - GL_INVALID_VALUE is generated if end&lt;start.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_ELEMENTS_VERTICES
		/// - glGet with argument GL_MAX_ELEMENTS_INDICES
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void DrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices)
		{
			if        (Delegates.pglDrawRangeElements != null) {
				Delegates.pglDrawRangeElements((int)mode, start, end, count, type, indices);
				CallLog("glDrawRangeElements({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else if (Delegates.pglDrawRangeElementsEXT != null) {
				Delegates.pglDrawRangeElementsEXT((int)mode, start, end, count, type, indices);
				CallLog("glDrawRangeElementsEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			} else
				throw new NotImplementedException("glDrawRangeElements (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// render primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="start">
		/// Specifies the minimum array index contained in indices.
		/// </param>
		/// <param name="end">
		/// Specifies the maximum array index contained in indices.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <remarks>
		/// glDrawRangeElements is a restricted form of glDrawElements. mode, start, end, and count match the corresponding 
		/// arguments to glDrawElements, with the additional constraint that all values in the arrays count must lie between start 
		/// and end, inclusive.
		/// Implementations denote recommended maximum amounts of vertex and index data, which may be queried by calling glGet with 
		/// argument GL_MAX_ELEMENTS_VERTICES and GL_MAX_ELEMENTS_INDICES. If end-start+1 is greater than the value of 
		/// GL_MAX_ELEMENTS_VERTICES, or if count is greater than the value of GL_MAX_ELEMENTS_INDICES, then the call may operate at 
		/// reduced performance. There is no requirement that all vertices in the range startend be referenced. However, the 
		/// implementation may partially process unused vertices, reducing performance from what could be achieved with an optimal 
		/// index set.
		/// When glDrawRangeElements is called, it uses count sequential elements from an enabled array, starting at start to 
		/// construct a sequence of geometric primitives. mode specifies what kind of primitives are constructed, and how the array 
		/// elements construct these primitives. If more than one array is enabled, each is used.
		/// Vertex attributes that are modified by glDrawRangeElements have an unspecified value after glDrawRangeElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - It is an error for indices to lie outside the range startend, but implementations may not check for this situation. Such 
		///   indices cause implementation-dependent behavior.
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if count is negative.
		/// - GL_INVALID_VALUE is generated if end&lt;start.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_ELEMENTS_VERTICES
		/// - glGet with argument GL_MAX_ELEMENTS_INDICES
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElements(mode, start, end, count, type, pin_indices.AddrOfPinnedObject());
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enable and disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>.
		/// To define texture images, call <see cref="Gl.TexImage3D"/>. The arguments describe the parameters of the texture image, 
		/// such as height, width, depth, width of the border, level-of-detail number (see Gl.TexParameter), and number of color 
		/// components provided. The last three arguments describe how the image is represented in memory; they are identical to the 
		/// pixel formats used for Gl.DrawPixels.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// of the texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image 
		/// state to 0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array 
		/// level greater than or equal to 1.
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>. These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>, to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// string of unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// as eight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore).
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a texture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image. The final element corresponds to the upper right corner of the texture image.
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// these symbolic values:
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolution and format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximates that requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specified by <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/> must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL 
		/// will replace the internal format with the symbolic constant for a specific internal format and compress the texture 
		/// before storage. If no corresponding internal format is available, or the GL can not compress that image for any reason, 
		/// the internal format is instead replaced with a corresponding base internal format.
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>, <see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>, or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// or luminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// the sRGB encoded component cs to a linear component cl is:
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045
		/// Assume cs is the sRGB component in the range [0,1].
		/// Use the <see cref="Gl.PROXY_TEXTURE_3D"/> target to try out a resolution and format. The implementation will update and 
		/// recompute its best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0.
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-component image uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// uses all of the RGBA components.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_3D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_3D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constants other than <see cref="Gl.STENCIL_INDEX"/> and <see cref="Gl.DEPTH_COMPONENT"/> are accepted.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/> is not <see cref="Gl.COLOR_INDEX"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0.
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returned value of <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   accepted resolution and format symbolic constants.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref 
		///   name="depth"/> is less than 0 or greater than 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> cannot be represented as 2k+2⁡border for some 
		///   integer value of k.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> or <paramref name="internalFormat"/> is 
		///   <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage3D"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/>
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexImage3D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels)
		{
			if        (Delegates.pglTexImage3D != null) {
				Delegates.pglTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
				CallLog("glTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else if (Delegates.pglTexImage3DEXT != null) {
				Delegates.pglTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);
				CallLog("glTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else if (Delegates.pglTexImage3DOES != null) {
				Delegates.pglTexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels);
				CallLog("glTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else
				throw new NotImplementedException("glTexImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enable and disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>.
		/// To define texture images, call <see cref="Gl.TexImage3D"/>. The arguments describe the parameters of the texture image, 
		/// such as height, width, depth, width of the border, level-of-detail number (see Gl.TexParameter), and number of color 
		/// components provided. The last three arguments describe how the image is represented in memory; they are identical to the 
		/// pixel formats used for Gl.DrawPixels.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// of the texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image 
		/// state to 0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array 
		/// level greater than or equal to 1.
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>. These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>, to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// string of unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// as eight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore).
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a texture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image. The final element corresponds to the upper right corner of the texture image.
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// these symbolic values:
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolution and format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximates that requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specified by <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/> must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL 
		/// will replace the internal format with the symbolic constant for a specific internal format and compress the texture 
		/// before storage. If no corresponding internal format is available, or the GL can not compress that image for any reason, 
		/// the internal format is instead replaced with a corresponding base internal format.
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>, <see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>, or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// or luminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// the sRGB encoded component cs to a linear component cl is:
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045
		/// Assume cs is the sRGB component in the range [0,1].
		/// Use the <see cref="Gl.PROXY_TEXTURE_3D"/> target to try out a resolution and format. The implementation will update and 
		/// recompute its best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0.
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-component image uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// uses all of the RGBA components.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_3D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_3D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constants other than <see cref="Gl.STENCIL_INDEX"/> and <see cref="Gl.DEPTH_COMPONENT"/> are accepted.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/> is not <see cref="Gl.COLOR_INDEX"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0.
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returned value of <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   accepted resolution and format symbolic constants.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref 
		///   name="depth"/> is less than 0 or greater than 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> cannot be represented as 2k+2⁡border for some 
		///   integer value of k.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> or <paramref name="internalFormat"/> is 
		///   <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage3D"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/>
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexImage3D != null) {
				Delegates.pglTexImage3D((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
				CallLog("glTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else if (Delegates.pglTexImage3DEXT != null) {
				Delegates.pglTexImage3DEXT((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
				CallLog("glTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else if (Delegates.pglTexImage3DOES != null) {
				Delegates.pglTexImage3DOES((int)target, level, internalformat, width, height, depth, border, (int)format, (int)type, pixels);
				CallLog("glTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, level, internalformat, width, height, depth, border, format, type, pixels);
			} else
				throw new NotImplementedException("glTexImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// that are at least 16 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support 3D texture images 
		/// that are at least 16 texels high.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2k+2⁡border for some integer k. All implementations support 3D texture images 
		/// that are at least 16 texels deep.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enable and disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>.
		/// To define texture images, call <see cref="Gl.TexImage3D"/>. The arguments describe the parameters of the texture image, 
		/// such as height, width, depth, width of the border, level-of-detail number (see Gl.TexParameter), and number of color 
		/// components provided. The last three arguments describe how the image is represented in memory; they are identical to the 
		/// pixel formats used for Gl.DrawPixels.
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// of the texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image 
		/// state to 0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array 
		/// level greater than or equal to 1.
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>. These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>, to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// string of unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// as eight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore).
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// a texture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store.
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image. The final element corresponds to the upper right corner of the texture image.
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// these symbolic values:
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolution and format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximates that requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specified by <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/> must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL 
		/// will replace the internal format with the symbolic constant for a specific internal format and compress the texture 
		/// before storage. If no corresponding internal format is available, or the GL can not compress that image for any reason, 
		/// the internal format is instead replaced with a corresponding base internal format.
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>, <see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>, or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// or luminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// the sRGB encoded component cs to a linear component cl is:
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045
		/// Assume cs is the sRGB component in the range [0,1].
		/// Use the <see cref="Gl.PROXY_TEXTURE_3D"/> target to try out a resolution and format. The implementation will update and 
		/// recompute its best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0.
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-component image uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// uses all of the RGBA components.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_3D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_3D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constants other than <see cref="Gl.STENCIL_INDEX"/> and <see cref="Gl.DEPTH_COMPONENT"/> are accepted.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/> is not <see cref="Gl.COLOR_INDEX"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0.
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returned value of <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   accepted resolution and format symbolic constants.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref 
		///   name="depth"/> is less than 0 or greater than 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> cannot be represented as 2k+2⁡border for some 
		///   integer value of k.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or 
		///   <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> and <paramref name="format"/> is not <see cref="Gl.RGB"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> or <paramref name="internalFormat"/> is 
		///   <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the buffer object's data store is currently mapped.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and the data would be unpacked from the buffer object such that the memory reads 
		///   required would exceed the data store size.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/> target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   needed to store in memory a datum indicated by <paramref name="type"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage3D"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/>
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexImage3D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage3D. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
		/// glTexSubImage3D and glTextureSubImage3D redefine a contiguous subregion of an existing three-dimensional or 
		/// two-dimensioanl array texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// with x indices xoffset and xoffset+width-1, inclusive, y indices yoffset and yoffset+height-1, inclusive, and z indices 
		/// zoffset and zoffset+depth-1, inclusive. For three-dimensional textures, the z index refers to the third dimension. For 
		/// two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside 
		/// the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero 
		/// width, height, or depth but such a specification has no effect.
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// is specified, pixels is treated as a byte offset into the buffer object's data store.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage3D if texture is not the name of an existing texture object.
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant.
		/// - GL_INVALID_ENUM is generated if type is not a type constant.
		/// - GL_INVALID_VALUE is generated if level is less than 0.
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		///   zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, d is the 
		///   GL_TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		///   border width.
		/// - GL_INVALID_VALUE is generated if width, height, or depth is less than 0.
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		///   operation.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5, or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2, or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA.
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   buffer object's data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixels is not evenly divisible into the number of bytes needed to store in memory a datum indicated by type.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage3D != null) {
				Delegates.pglTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
				CallLog("glTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else if (Delegates.pglTexSubImage3DEXT != null) {
				Delegates.pglTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
				CallLog("glTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else if (Delegates.pglTexSubImage3DOES != null) {
				Delegates.pglTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
				CallLog("glTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage3D. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
		/// glTexSubImage3D and glTextureSubImage3D redefine a contiguous subregion of an existing three-dimensional or 
		/// two-dimensioanl array texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// with x indices xoffset and xoffset+width-1, inclusive, y indices yoffset and yoffset+height-1, inclusive, and z indices 
		/// zoffset and zoffset+depth-1, inclusive. For three-dimensional textures, the z index refers to the third dimension. For 
		/// two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside 
		/// the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero 
		/// width, height, or depth but such a specification has no effect.
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// is specified, pixels is treated as a byte offset into the buffer object's data store.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage3D if texture is not the name of an existing texture object.
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant.
		/// - GL_INVALID_ENUM is generated if type is not a type constant.
		/// - GL_INVALID_VALUE is generated if level is less than 0.
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		///   zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, d is the 
		///   GL_TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		///   border width.
		/// - GL_INVALID_VALUE is generated if width, height, or depth is less than 0.
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		///   operation.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5, or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2, or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA.
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   buffer object's data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixels is not evenly divisible into the number of bytes needed to store in memory a datum indicated by type.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			if        (Delegates.pglTexSubImage3D != null) {
				Delegates.pglTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
				CallLog("glTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else if (Delegates.pglTexSubImage3DEXT != null) {
				Delegates.pglTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
				CallLog("glTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else if (Delegates.pglTexSubImage3DOES != null) {
				Delegates.pglTexSubImage3DOES((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, (int)type, pixels);
				CallLog("glTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			} else
				throw new NotImplementedException("glTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexSubImage3D. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
		/// glTexSubImage3D and glTextureSubImage3D redefine a contiguous subregion of an existing three-dimensional or 
		/// two-dimensioanl array texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// with x indices xoffset and xoffset+width-1, inclusive, y indices yoffset and yoffset+height-1, inclusive, and z indices 
		/// zoffset and zoffset+depth-1, inclusive. For three-dimensional textures, the z index refers to the third dimension. For 
		/// two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside 
		/// the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero 
		/// width, height, or depth but such a specification has no effect.
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// is specified, pixels is treated as a byte offset into the buffer object's data store.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage3D if texture is not the name of an existing texture object.
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant.
		/// - GL_INVALID_ENUM is generated if type is not a type constant.
		/// - GL_INVALID_VALUE is generated if level is less than 0.
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		///   zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, d is the 
		///   GL_TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		///   border width.
		/// - GL_INVALID_VALUE is generated if width, height, or depth is less than 0.
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		///   operation.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5, or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2, or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA.
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   buffer object's data store is currently mapped.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixels is not evenly divisible into the number of bytes needed to store in memory a datum indicated by type.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// copy a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/>
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage3D"/> replaces a rectangular portion of a three-dimensional texture image with pixels from 
		/// the current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.TexSubImage3D).
		/// The screen-aligned pixel rectangle with lower left corner at (<paramref name="x"/>,\ <paramref name="y"/>) and with 
		/// width <paramref name="width"/> and height <paramref name="height"/> replaces the portion of the texture array with x 
		/// indices <paramref name="xoffset"/> through xoffset+width-1, inclusive, and y indices <paramref name="yoffset"/> through 
		/// yoffset+height-1, inclusive, at z index <paramref name="zoffset"/> and at the mipmap level specified by <paramref 
		/// name="level"/>.
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// final conversion. At this point, all pixel component values are clamped to the range 01 and then converted to the 
		/// texture's internal format for storage in the texel array.
		/// The destination rectangle in the texture array may not include any texels outside the texture array as it was originally 
		/// specified. It is not an error to specify a subtexture with zero width or height, but such a specification has no effect.
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the read 
		/// window associated with the current rendering context, then the values obtained for those pixels are undefined.
		/// No change is made to the internalformat, width, height, depth, or border parameters of the specified texture array or to 
		/// texel values outside the specified subregion.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if /<paramref name="target"/> is not <see cref="Gl.TEXTURE_3D"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage3D 
		///   operation.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0.
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_3D_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, 
		///   yoffset+height&gt;h-b, zoffset&lt;-b, or zoffset+1&gt;d-b, where w is the <see cref="Gl.TEXTURE_WIDTH"/>, h is the <see 
		///   cref="Gl.TEXTURE_HEIGHT"/>, d is the <see cref="Gl.TEXTURE_DEPTH"/>, and b is the <see cref="Gl.TEXTURE_BORDER"/> of the 
		///   texture image being modified. Note that w, h, and d include twice the border width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexSubImage3D"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyTexSubImage3D != null) {
				Delegates.pglCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage3DEXT != null) {
				Delegates.pglCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage3DOES != null) {
				Delegates.pglCopyTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a three-dimensional texture subimage
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/>
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyTexSubImage3D"/> replaces a rectangular portion of a three-dimensional texture image with pixels from 
		/// the current <see cref="Gl.READ_BUFFER"/> (rather than from main memory, as is the case for Gl.TexSubImage3D).
		/// The screen-aligned pixel rectangle with lower left corner at (<paramref name="x"/>,\ <paramref name="y"/>) and with 
		/// width <paramref name="width"/> and height <paramref name="height"/> replaces the portion of the texture array with x 
		/// indices <paramref name="xoffset"/> through xoffset+width-1, inclusive, and y indices <paramref name="yoffset"/> through 
		/// yoffset+height-1, inclusive, at z index <paramref name="zoffset"/> and at the mipmap level specified by <paramref 
		/// name="level"/>.
		/// The pixels in the rectangle are processed exactly as if Gl.CopyPixels had been called, but the process stops just before 
		/// final conversion. At this point, all pixel component values are clamped to the range 01 and then converted to the 
		/// texture's internal format for storage in the texel array.
		/// The destination rectangle in the texture array may not include any texels outside the texture array as it was originally 
		/// specified. It is not an error to specify a subtexture with zero width or height, but such a specification has no effect.
		/// If any of the pixels within the specified rectangle of the current <see cref="Gl.READ_BUFFER"/> are outside the read 
		/// window associated with the current rendering context, then the values obtained for those pixels are undefined.
		/// No change is made to the internalformat, width, height, depth, or border parameters of the specified texture array or to 
		/// texel values outside the specified subregion.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if /<paramref name="target"/> is not <see cref="Gl.TEXTURE_3D"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if the texture array has not been defined by a previous Gl.TexImage3D 
		///   operation.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0.
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if level&gt;log2⁡max, where max is the returned value of <see 
		///   cref="Gl.MAX_3D_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, 
		///   yoffset+height&gt;h-b, zoffset&lt;-b, or zoffset+1&gt;d-b, where w is the <see cref="Gl.TEXTURE_WIDTH"/>, h is the <see 
		///   cref="Gl.TEXTURE_HEIGHT"/>, d is the <see cref="Gl.TEXTURE_DEPTH"/>, and b is the <see cref="Gl.TEXTURE_BORDER"/> of the 
		///   texture image being modified. Note that w, h, and d include twice the border width.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyTexSubImage3D"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_2")]
		public static void CopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			if        (Delegates.pglCopyTexSubImage3D != null) {
				Delegates.pglCopyTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage3DEXT != null) {
				Delegates.pglCopyTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else if (Delegates.pglCopyTexSubImage3DOES != null) {
				Delegates.pglCopyTexSubImage3DOES((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
				CallLog("glCopyTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			} else
				throw new NotImplementedException("glCopyTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
