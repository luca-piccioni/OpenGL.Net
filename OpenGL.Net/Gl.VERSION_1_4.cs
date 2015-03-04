
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
		/// <remarks>
		/// In RGBA mode, pixels can be drawn using a function that blends the incoming (source) RGBA values with the RGBA values 
		/// that are already in the frame buffer (the destination values). Blending is initially disabled. Use Gl.Enable and 
		/// Gl.Disable with argument <see cref="Gl.BLEND"/> to enable and disable blending.
		/// <see cref="Gl.BlendFuncSeparate"/> defines the operation of blending when it is enabled. <paramref name="srcRGB"/> 
		/// specifies which method is used to scale the source RGB-color components. <paramref name="dstRGB"/> specifies which 
		/// method is used to scale the destination RGB-color components. Likewise, <paramref name="srcAlpha"/> specifies which 
		/// method is used to scale the source alpha color component, and <paramref name="dstAlpha"/> specifies which method is used 
		/// to scale the destination alpha component. The possible methods are described in the following table. Each method defines 
		/// four scale factors, one each for red, green, blue, and alpha.
		/// In the table and in subsequent equations, source and destination color components are referred to as RsGsBsAs and 
		/// RdGdBdAd. The color specified by Gl.BlendColor is referred to as RcGcBcAc. They are understood to have integer values 
		/// between 0 and kRkGkBkA, where
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: k sub c = 2 sup {m sub c} - 1:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi 
		/// mathvariant="italic">c</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:msup><mml:mn>2</mml:mn><mml:mfenced open="" 
		/// close=""><mml:msub><mml:mi mathvariant="italic">m</mml:mi><mml:mi 
		/// mathvariant="italic">c</mml:mi></mml:msub></mml:mfenced></mml:msup><mml:mo>-</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		/// and mRmGmBmA is the number of red, green, blue, and alpha bitplanes.
		/// Source and destination scale factors are referred to as sRsGsBsA and dRdGdBdA. All scale factors have range 01.
		/// In the table,
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: i = min (A sub s , 1 - {A sub d}):--><mml:mrow><mml:mi 
		/// mathvariant="italic">i</mml:mi><mml:mo>=</mml:mo><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfenced open="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi 
		/// mathvariant="italic">s</mml:mi></mml:msub><mml:mrow><mml:mn>1</mml:mn><mml:mo>-</mml:mo><mml:mfenced open="" 
		/// close=""><mml:msub><mml:mi mathvariant="italic">A</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub></mml:mfenced></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		/// To determine the blended RGBA values of a pixel when drawing in RGBA mode, the system uses the following equations:
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: R sub d = min ( k sub R, R sub s s sub R + R sub d d sub R 
		/// ):--><mml:mrow><mml:msub><mml:mi mathvariant="italic">R</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfenced open="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi mathvariant="italic">R</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mi mathvariant="italic">R</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi 
		/// mathvariant="italic">R</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: G sub d = min ( k sub G, G sub s s sub G + G sub d d sub G 
		/// ):--><mml:mrow><mml:msub><mml:mi mathvariant="italic">G</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfenced open="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi mathvariant="italic">G</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mi mathvariant="italic">G</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi 
		/// mathvariant="italic">G</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: B sub d = min ( k sub B, B sub s s sub B + B sub d d sub B 
		/// ):--><mml:mrow><mml:msub><mml:mi mathvariant="italic">B</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfenced open="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi mathvariant="italic">B</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mi mathvariant="italic">B</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi 
		/// mathvariant="italic">B</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: A sub d = min ( k sub A, A sub s s sub A + A sub d d sub A 
		/// ):--><mml:mrow><mml:msub><mml:mi mathvariant="italic">A</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfenced open="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi mathvariant="italic">A</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mi mathvariant="italic">A</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi 
		/// mathvariant="italic">A</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		/// Despite the apparent precision of the above equations, blending arithmetic is not exactly specified, because blending 
		/// operates with imprecise integer color values. However, a blend factor that should be equal to 1 is guaranteed not to 
		/// modify its multiplicand, and a blend factor equal to 0 reduces its multiplicand to 0. For example, when <paramref 
		/// name="srcRGB"/> is <see cref="Gl.SRC_ALPHA"/>, <paramref name="dstRGB"/> is <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, and As 
		/// is equal to kA, the equations reduce to simple replacement:
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: R sub d = R sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: G sub d = G sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: B sub d = B sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!-- eqn: A sub d = A sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi mathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="srcRGB"/> or <paramref name="dstRGB"/> is not an 
		///   accepted value.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendFuncSeparate"/> is executed between the execution 
		///   of Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.BLEND_SRC_RGB"/>
		/// - Gl.Get with argument <see cref="Gl.BLEND_SRC_ALPHA"/>
		/// - Gl.Get with argument <see cref="Gl.BLEND_DST_RGB"/>
		/// - Gl.Get with argument <see cref="Gl.BLEND_DST_ALPHA"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.BLEND"/>
		/// <summary>
		/// Binding for glBlendFuncSeparate.
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
		/// <remarks>
		/// glMultiDrawArrays specifies multiple sets of geometric primitives with very few subroutine calls. Instead of calling a 
		/// GL procedure to pass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify 
		/// separate arrays of vertices, normals, and colors and use them to construct a sequence of primitives with a single call 
		/// to glMultiDrawArrays.
		/// glMultiDrawArrays behaves identically to glDrawArrays except that drawcount separate ranges of elements are specified 
		/// instead.
		/// When glMultiDrawArrays is called, it uses count sequential elements from each enabled array to construct a sequence of 
		/// geometric primitives, beginning with element first. mode specifies what kind of primitives are constructed, and how the 
		/// array elements construct those primitives.
		/// Vertex attributes that are modified by glMultiDrawArrays have an unspecified value after glMultiDrawArrays returns. 
		/// Attributes that aren't modified remain well defined.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if drawcount is negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawArrays(int mode, Int32[] first, Int32[] count, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					if        (Delegates.pglMultiDrawArrays != null) {
						Delegates.pglMultiDrawArrays(mode, p_first, p_count, drawcount);
						CallLog("glMultiDrawArrays({0}, {1}, {2}, {3})", mode, first, count, drawcount);
					} else if (Delegates.pglMultiDrawArraysEXT != null) {
						Delegates.pglMultiDrawArraysEXT(mode, p_first, p_count, drawcount);
						CallLog("glMultiDrawArraysEXT({0}, {1}, {2}, {3})", mode, first, count, drawcount);
					} else
						throw new NotImplementedException("glMultiDrawArrays (and other aliases) are not implemented");
				}
			}
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
		/// <remarks>
		/// glMultiDrawArrays specifies multiple sets of geometric primitives with very few subroutine calls. Instead of calling a 
		/// GL procedure to pass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify 
		/// separate arrays of vertices, normals, and colors and use them to construct a sequence of primitives with a single call 
		/// to glMultiDrawArrays.
		/// glMultiDrawArrays behaves identically to glDrawArrays except that drawcount separate ranges of elements are specified 
		/// instead.
		/// When glMultiDrawArrays is called, it uses count sequential elements from each enabled array to construct a sequence of 
		/// geometric primitives, beginning with element first. mode specifies what kind of primitives are constructed, and how the 
		/// array elements construct those primitives.
		/// Vertex attributes that are modified by glMultiDrawArrays have an unspecified value after glMultiDrawArrays returns. 
		/// Attributes that aren't modified remain well defined.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if drawcount is negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// <remarks>
		/// glMultiDrawElements specifies multiple sets of geometric primitives with very few subroutine calls. Instead of calling a 
		/// GL function to pass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate 
		/// arrays of vertices, normals, and so on, and use them to construct a sequence of primitives with a single call to 
		/// glMultiDrawElements.
		/// glMultiDrawElements is identical in operation to glDrawElements except that drawcount separate lists of elements are 
		/// specified.
		/// Vertex attributes that are modified by glMultiDrawElements have an unspecified value after glMultiDrawElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if drawcount is negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawElements(int mode, Int32[] count, int type, IntPtr indices, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				{
					if        (Delegates.pglMultiDrawElements != null) {
						Delegates.pglMultiDrawElements(mode, p_count, type, indices, drawcount);
						CallLog("glMultiDrawElements({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, drawcount);
					} else if (Delegates.pglMultiDrawElementsEXT != null) {
						Delegates.pglMultiDrawElementsEXT(mode, p_count, type, indices, drawcount);
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
		/// <remarks>
		/// glMultiDrawElements specifies multiple sets of geometric primitives with very few subroutine calls. Instead of calling a 
		/// GL function to pass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate 
		/// arrays of vertices, normals, and so on, and use them to construct a sequence of primitives with a single call to 
		/// glMultiDrawElements.
		/// glMultiDrawElements is identical in operation to glDrawElements except that drawcount separate lists of elements are 
		/// specified.
		/// Vertex attributes that are modified by glMultiDrawElements have an unspecified value after glMultiDrawElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if drawcount is negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// <remarks>
		/// glMultiDrawElements specifies multiple sets of geometric primitives with very few subroutine calls. Instead of calling a 
		/// GL function to pass each individual vertex, normal, texture coordinate, edge flag, or color, you can prespecify separate 
		/// arrays of vertices, normals, and so on, and use them to construct a sequence of primitives with a single call to 
		/// glMultiDrawElements.
		/// glMultiDrawElements is identical in operation to glDrawElements except that drawcount separate lists of elements are 
		/// specified.
		/// Vertex attributes that are modified by glMultiDrawElements have an unspecified value after glMultiDrawElements returns. 
		/// Attributes that aren't modified maintain their previous values.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value.
		/// - GL_INVALID_VALUE is generated if drawcount is negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		///   the buffer object's data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
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
		/// <remarks>
		/// The following values are accepted for pname:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if the value specified for GL_POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// - GL_INVALID_ENUM is generated If the value specified for GL_POINT_SPRITE_COORD_ORIGIN is not GL_LOWER_LEFT or 
		///   GL_UPPER_LEFT.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POINT_FADE_THRESHOLD_SIZE
		/// - glGet with argument GL_POINT_SPRITE_COORD_ORIGIN
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PointSize"/>
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
		/// <remarks>
		/// The following values are accepted for pname:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if the value specified for GL_POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// - GL_INVALID_ENUM is generated If the value specified for GL_POINT_SPRITE_COORD_ORIGIN is not GL_LOWER_LEFT or 
		///   GL_UPPER_LEFT.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POINT_FADE_THRESHOLD_SIZE
		/// - glGet with argument GL_POINT_SPRITE_COORD_ORIGIN
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PointSize"/>
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
		/// <remarks>
		/// The following values are accepted for pname:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if the value specified for GL_POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// - GL_INVALID_ENUM is generated If the value specified for GL_POINT_SPRITE_COORD_ORIGIN is not GL_LOWER_LEFT or 
		///   GL_UPPER_LEFT.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POINT_FADE_THRESHOLD_SIZE
		/// - glGet with argument GL_POINT_SPRITE_COORD_ORIGIN
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PointSize"/>
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
		/// <remarks>
		/// The following values are accepted for pname:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if the value specified for GL_POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// - GL_INVALID_ENUM is generated If the value specified for GL_POINT_SPRITE_COORD_ORIGIN is not GL_LOWER_LEFT or 
		///   GL_UPPER_LEFT.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POINT_FADE_THRESHOLD_SIZE
		/// - glGet with argument GL_POINT_SPRITE_COORD_ORIGIN
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PointSize"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoord"/> specifies the fog coordinate that is associated with each vertex and the current raster 
		/// position. The value specified is interpolated and used in computing the fog color (see Gl.Fog).
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_FOG_COORD"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoord"/> specifies the fog coordinate that is associated with each vertex and the current raster 
		/// position. The value specified is interpolated and used in computing the fog color (see Gl.Fog).
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_FOG_COORD"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoord"/> specifies the fog coordinate that is associated with each vertex and the current raster 
		/// position. The value specified is interpolated and used in computing the fog color (see Gl.Fog).
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_FOG_COORD"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoord"/> specifies the fog coordinate that is associated with each vertex and the current raster 
		/// position. The value specified is interpolated and used in computing the fog color (see Gl.Fog).
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_FOG_COORD"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoordPointer"/> specifies the location and data format of an array of fog coordinates to use when 
		/// rendering. <paramref name="type"/> specifies the data type of each fog coordinate, and <paramref name="stride"/> 
		/// specifies the byte stride from one fog coordinate to the next, allowing vertices and attributes to be packed into a 
		/// single array or stored in separate arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a fog 
		/// coordinate array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as fog coordinate vertex array 
		/// client-side state (<see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>).
		/// When a fog coordinate array is specified, <paramref name="type"/>, <paramref name="stride"/>, and <paramref 
		/// name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object binding.
		/// To enable and disable the fog coordinate array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.FOG_COORD_ARRAY"/>. If enabled, the fog coordinate array is used when Gl.DrawArrays, Gl.MultiDrawArrays, 
		/// Gl.DrawElements, Gl.MultiDrawElements, Gl.DrawRangeElements, or Gl.ArrayElement is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not either <see cref="Gl.FLOAT"/> or <see 
		///   cref="Gl.DOUBLE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG_COORD_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.FOG_COORD_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(int type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglFogCoordPointer != null) {
				Delegates.pglFogCoordPointer(type, stride, pointer);
				CallLog("glFogCoordPointer({0}, {1}, {2})", type, stride, pointer);
			} else if (Delegates.pglFogCoordPointerEXT != null) {
				Delegates.pglFogCoordPointerEXT(type, stride, pointer);
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
		/// <remarks>
		/// <see cref="Gl.FogCoordPointer"/> specifies the location and data format of an array of fog coordinates to use when 
		/// rendering. <paramref name="type"/> specifies the data type of each fog coordinate, and <paramref name="stride"/> 
		/// specifies the byte stride from one fog coordinate to the next, allowing vertices and attributes to be packed into a 
		/// single array or stored in separate arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a fog 
		/// coordinate array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as fog coordinate vertex array 
		/// client-side state (<see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>).
		/// When a fog coordinate array is specified, <paramref name="type"/>, <paramref name="stride"/>, and <paramref 
		/// name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object binding.
		/// To enable and disable the fog coordinate array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.FOG_COORD_ARRAY"/>. If enabled, the fog coordinate array is used when Gl.DrawArrays, Gl.MultiDrawArrays, 
		/// Gl.DrawElements, Gl.MultiDrawElements, Gl.DrawRangeElements, or Gl.ArrayElement is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not either <see cref="Gl.FLOAT"/> or <see 
		///   cref="Gl.DOUBLE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG_COORD_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.FOG_COORD_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
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
		/// <remarks>
		/// <see cref="Gl.FogCoordPointer"/> specifies the location and data format of an array of fog coordinates to use when 
		/// rendering. <paramref name="type"/> specifies the data type of each fog coordinate, and <paramref name="stride"/> 
		/// specifies the byte stride from one fog coordinate to the next, allowing vertices and attributes to be packed into a 
		/// single array or stored in separate arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a fog 
		/// coordinate array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as fog coordinate vertex array 
		/// client-side state (<see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>).
		/// When a fog coordinate array is specified, <paramref name="type"/>, <paramref name="stride"/>, and <paramref 
		/// name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object binding.
		/// To enable and disable the fog coordinate array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.FOG_COORD_ARRAY"/>. If enabled, the fog coordinate array is used when Gl.DrawArrays, Gl.MultiDrawArrays, 
		/// Gl.DrawElements, Gl.MultiDrawElements, Gl.DrawRangeElements, or Gl.ArrayElement is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not either <see cref="Gl.FLOAT"/> or <see 
		///   cref="Gl.DOUBLE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG_COORD_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.FOG_COORD_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.FOG_COORD_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// The GL stores both a primary four-valued RGBA color and a secondary four-valued RGBA color (where alpha is always set to 
		/// 0.0) that is associated with every vertex.
		/// The secondary color is interpolated and applied to each fragment during rasterization when <see cref="Gl.COLOR_SUM"/> is 
		/// enabled. When lighting is enabled, and <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value of the secondary 
		/// color is assigned the value computed from the specular term of the lighting computation. Both the primary and secondary 
		/// current colors are applied to each fragment, regardless of the state of <see cref="Gl.COLOR_SUM"/>, under such 
		/// conditions. When <see cref="Gl.SEPARATE_SPECULAR_COLOR"/> is specified, the value returned from querying the current 
		/// secondary color is undefined.
		/// <see cref="Gl.SecondaryColor3b"/>, <see cref="Gl.SecondaryColor3s"/>, and <see cref="Gl.SecondaryColor3i"/> take three 
		/// signed byte, short, or long integers as arguments. When v is appended to the name, the color commands can take a pointer 
		/// to an array of such values.
		/// Color values are stored in floating-point format, with unspecified mantissa and exponent sizes. Unsigned integer color 
		/// components, when specified, are linearly mapped to floating-point values such that the largest representable value maps 
		/// to 1.0 (full intensity), and 0 maps to 0.0 (zero intensity). Signed integer color components, when specified, are 
		/// linearly mapped to floating-point values such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. (Note that this mapping does not convert 0 precisely to 0.0). Floating-point 
		/// values are mapped directly.
		/// Neither floating-point nor signed integer values are clamped to the range 01 before the current color is updated. 
		/// However, color components are clamped to this range before they are interpolated or written into a color buffer.
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.RGBA_MODE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.COLOR_SUM"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
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
		/// <remarks>
		/// <see cref="Gl.SecondaryColorPointer"/> specifies the location and data format of an array of color components to use 
		/// when rendering. <paramref name="size"/> specifies the number of components per color, and must be 3. <paramref 
		/// name="type"/> specifies the data type of each color component, and <paramref name="stride"/> specifies the byte stride 
		/// from one color to the next, allowing vertices and attributes to be packed into a single array or stored in separate 
		/// arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// secondary color array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as secondary color vertex array 
		/// client-side state (<see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>).
		/// When a secondary color array is specified, <paramref name="size"/>, <paramref name="type"/>, <paramref name="stride"/>, 
		/// and <paramref name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object 
		/// binding.
		/// To enable and disable the secondary color array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.SECONDARY_COLOR_ARRAY"/>. If enabled, the secondary color array is used when Gl.ArrayElement, 
		/// Gl.DrawArrays, Gl.MultiDrawArrays, Gl.DrawElements, Gl.MultiDrawElements, or Gl.DrawRangeElements is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="size"/> is not 3.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not an accepted value.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.SECONDARY_COLOR_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_SIZE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglSecondaryColorPointer != null) {
				Delegates.pglSecondaryColorPointer(size, type, stride, pointer);
				CallLog("glSecondaryColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			} else if (Delegates.pglSecondaryColorPointerEXT != null) {
				Delegates.pglSecondaryColorPointerEXT(size, type, stride, pointer);
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
		/// <remarks>
		/// <see cref="Gl.SecondaryColorPointer"/> specifies the location and data format of an array of color components to use 
		/// when rendering. <paramref name="size"/> specifies the number of components per color, and must be 3. <paramref 
		/// name="type"/> specifies the data type of each color component, and <paramref name="stride"/> specifies the byte stride 
		/// from one color to the next, allowing vertices and attributes to be packed into a single array or stored in separate 
		/// arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// secondary color array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as secondary color vertex array 
		/// client-side state (<see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>).
		/// When a secondary color array is specified, <paramref name="size"/>, <paramref name="type"/>, <paramref name="stride"/>, 
		/// and <paramref name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object 
		/// binding.
		/// To enable and disable the secondary color array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.SECONDARY_COLOR_ARRAY"/>. If enabled, the secondary color array is used when Gl.ArrayElement, 
		/// Gl.DrawArrays, Gl.MultiDrawArrays, Gl.DrawElements, Gl.MultiDrawElements, or Gl.DrawRangeElements is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="size"/> is not 3.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not an accepted value.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.SECONDARY_COLOR_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_SIZE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
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
		/// <remarks>
		/// <see cref="Gl.SecondaryColorPointer"/> specifies the location and data format of an array of color components to use 
		/// when rendering. <paramref name="size"/> specifies the number of components per color, and must be 3. <paramref 
		/// name="type"/> specifies the data type of each color component, and <paramref name="stride"/> specifies the byte stride 
		/// from one color to the next, allowing vertices and attributes to be packed into a single array or stored in separate 
		/// arrays.
		/// If a non-zero named buffer object is bound to the <see cref="Gl.ARRAY_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// secondary color array is specified, <paramref name="pointer"/> is treated as a byte offset into the buffer object's data 
		/// store. Also, the buffer object binding (<see cref="Gl.ARRAY_BUFFER_BINDING"/>) is saved as secondary color vertex array 
		/// client-side state (<see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>).
		/// When a secondary color array is specified, <paramref name="size"/>, <paramref name="type"/>, <paramref name="stride"/>, 
		/// and <paramref name="pointer"/> are saved as client-side state, in addition to the current vertex array buffer object 
		/// binding.
		/// To enable and disable the secondary color array, call Gl.EnableClientState and Gl.DisableClientState with the argument 
		/// <see cref="Gl.SECONDARY_COLOR_ARRAY"/>. If enabled, the secondary color array is used when Gl.ArrayElement, 
		/// Gl.DrawArrays, Gl.MultiDrawArrays, Gl.DrawElements, Gl.MultiDrawElements, or Gl.DrawRangeElements is called.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="size"/> is not 3.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not an accepted value.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is negative.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.SECONDARY_COLOR_ARRAY"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_SIZE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_TYPE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_STRIDE"/>
		/// - Gl.Get with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_BUFFER_BINDING"/>
		/// - Gl.Get with argument <see cref="Gl.ARRAY_BUFFER_BINDING"/>
		/// - Gl.GetPointerv with argument <see cref="Gl.SECONDARY_COLOR_ARRAY_POINTER"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL maintains a 3D position in window coordinates. This position, called the raster position, is used to position 
		/// pixel and bitmap write operations. It is maintained with subpixel accuracy. See Gl.Bitmap, Gl.DrawPixels, and 
		/// Gl.CopyPixels.
		/// <see cref="Gl.WindowPos2"/> specifies the x and y coordinates, while z is implicitly set to 0. <see 
		/// cref="Gl.WindowPos3"/> specifies all three coordinates. The w coordinate of the current raster position is always set to 
		/// 1.0.
		/// <see cref="Gl.WindowPos"/> directly updates the x and y coordinates of the current raster position with the values 
		/// specified. That is, the values are neither transformed by the current modelview and projection matrices, nor by the 
		/// viewport-to-window transform. The z coordinate of the current raster position is updated in the following manner:
		/// z=nfn+z×f-n⁢if⁢z&lt;=0if⁢z&gt;=1otherwise
		/// where n is <see cref="Gl.DEPTH_RANGE"/>'s near value, and f is <see cref="Gl.DEPTH_RANGE"/>'s far value. See 
		/// Gl.DepthRange.
		/// The specified coordinates are not clip-tested, causing the raster position to always be valid.
		/// The current raster position also includes some associated color data and texture coordinates. If lighting is enabled, 
		/// then <see cref="Gl.CURRENT_RASTER_COLOR"/> (in RGBA mode) or <see cref="Gl.CURRENT_RASTER_INDEX"/> (in color index mode) 
		/// is set to the color produced by the lighting calculation (see Gl.Light, Gl.LightModel, and Gl.ShadeModel). If lighting 
		/// is disabled, current color (in RGBA mode, state variable <see cref="Gl.CURRENT_COLOR"/>) or color index (in color index 
		/// mode, state variable <see cref="Gl.CURRENT_INDEX"/>) is used to update the current raster color. <see 
		/// cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> (in RGBA mode) is likewise updated.
		/// Likewise, <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> is updated as a function of <see 
		/// cref="Gl.CURRENT_TEXTURE_COORDS"/>, based on the texture matrix and the texture generation functions (see Gl.TexGen). 
		/// The <see cref="Gl.CURRENT_RASTER_DISTANCE"/> is set to the <see cref="Gl.CURRENT_FOG_COORD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.WindowPos"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/>
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
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
		/// <remarks>
		/// The GL_BLEND_COLOR may be used to calculate the source and destination blending factors. The color components are 
		/// clamped to the range 01 before being stored. See glBlendFunc for a complete description of the blending operations. 
		/// Initially the GL_BLEND_COLOR is set to (0, 0, 0, 0).
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with an argument of GL_BLEND_COLOR
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.removedTypes"/>
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
		/// <remarks>
		/// The blend equations determine how a new pixel (the ''source'' color) is combined with a pixel already in the framebuffer 
		/// (the ''destination'' color). This function sets both the RGB blend equation and the alpha blend equation to a single 
		/// equation.
		/// These equations use the source and destination blend factors specified by either Gl.BlendFunc or Gl.BlendFuncSeparate. 
		/// See Gl.BlendFunc or Gl.BlendFuncSeparate for a description of the various blend factors.
		/// In the equations that follow, source and destination color components are referred to as RsGsBsAs and RdGdBdAd, 
		/// respectively. The result color is referred to as RrGrBrAr. The source and destination blend factors are denoted sRsGsBsA 
		/// and dRdGdBdA, respectively. For these equations all color components are understood to have values in the range 01. Mode 
		/// RGB Components Alpha Component <see cref="Gl.FUNC_ADD"/>Rr=Rs⁢sR+Rd⁢dRGr=Gs⁢sG+Gd⁢dGBr=Bs⁢sB+Bd⁢dBAr=As⁢sA+Ad⁢dA<see 
		/// cref="Gl.FUNC_SUBTRACT"/>Rr=Rs⁢sR-Rd⁢dRGr=Gs⁢sG-Gd⁢dGBr=Bs⁢sB-Bd⁢dBAr=As⁢sA-Ad⁢dA<see 
		/// cref="Gl.FUNC_REVERSE_SUBTRACT"/>Rr=Rd⁢dR-Rs⁢sRGr=Gd⁢dG-Gs⁢sGBr=Bd⁢dB-Bs⁢sBAr=Ad⁢dA-As⁢sA<see 
		/// cref="Gl.MIN"/>Rr=min⁡RsRdGr=min⁡GsGdBr=min⁡BsBdAr=min⁡AsAd<see 
		/// cref="Gl.MAX"/>Rr=max⁡RsRdGr=max⁡GsGdBr=max⁡BsBdAr=max⁡AsAd
		/// The results of these equations are clamped to the range 01.
		/// The <see cref="Gl.MIN"/> and <see cref="Gl.MAX"/> equations are useful for applications that analyze image data (image 
		/// thresholding against a constant color, for example). The <see cref="Gl.FUNC_ADD"/> equation is useful for antialiasing 
		/// and transparency, among other things.
		/// Initially, both the RGB blend equation and the alpha blend equation are set to <see cref="Gl.FUNC_ADD"/>.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is not one of <see cref="Gl.FUNC_ADD"/>, <see 
		///   cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see cref="Gl.MAX"/>, or <see cref="Gl.MIN"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendEquation"/> is executed between the execution of 
		///   Gl.Begin and the corresponding execution of Gl.End.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_RGB"/>
		/// - Gl.Get with an argument of <see cref="Gl.BLEND_EQUATION_ALPHA"/>
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
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
