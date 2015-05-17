
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Pixel format.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A pixel format specify completely the following information:
	/// - The color space
	/// - The pixel memory layout (bits and bit-mask per component)
	/// - The maximum component precision
	/// A pixel format specify partially the following information:
	/// - The color linearity
	/// </para>
	/// <para>
	/// The color linearity is fully determined on unsigned integer formats and packed formats. Pixel format
	/// having single-precision (or half-precision) floating-point components can store as linear color, but
	/// they cannot be expected to do it; it's up to application to manage the color linearity.
	/// </para>
	/// </remarks>
	public enum PixelLayout : uint
	{
		/// <summary>
		/// Unspecified pixel type.
		/// </summary>
		None,

		#region Grayscale Pixel Types

		/// <summary>
		/// Grayscale composed by 8 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Gray)]
		[PixelComponents(1)]
		[PixelPrecision(8)]
		[PixelStructure(typeof(ColorGRAY8))]
		GRAY8,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Gray)]
		[PixelComponents(1)]
		[PixelPrecision(16)]
		[PixelStructure(typeof(ColorGRAY16))]
		GRAY16,
		/// <summary>
		/// Grayscale composed by floating point number (32 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.Gray)]
		[PixelComponents(1)]
		[PixelPrecision(Single.Epsilon, 32)]
		[PixelStructure(typeof(ColorGRAYF))]
		GRAYF,
		/// <summary>
		/// Grayscale composed by half floating point number (16 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.Gray)]
		[PixelComponents(1)]
		[PixelPrecision(HalfFloat.Epsilon, 16)]
		[PixelStructure(typeof(ColorGRAYHF))]
		GRAYHF,

		#endregion

		#region Grayscale and Alpha Pixel Types

		/// <summary>
		/// Grayscale and alpha composed by floating point number (32 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.GrayAlpha)]
		[PixelComponents(2)]
		[PixelPrecision(Single.Epsilon, 32, 32)]
		[PixelStructure(typeof(ColorGRAYAF))]
		GRAYAF,

		#endregion

		#region RGB Pixel Types

		/// <summary>
		/// RGB composed by 8 bits (2/3 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(3, 3, 2)]
		[PixelStructure(typeof(ColorRGB8))]
		RGB8,
		/// <summary>
		/// RGB composed by 15 bits (5/6 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		[PixelStructure(typeof(ColorRGB15))]
		RGB15,
		/// <summary>
		/// RGB composed by 16 bits (5/6 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(5, 6, 5)]
		[PixelStructure(typeof(ColorRGB16))]
		RGB16,
		/// <summary>
		/// RGB composed by 24 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		[PixelStructure(typeof(ColorRGB24))]
		RGB24,
		/// <summary>
		/// RGB composed by 48 bits (16 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(16, 16, 16)]
		[PixelStructure(typeof(ColorRGB48))]
		RGB48,
		/// <summary>
		/// RGB composed by 3 single-precision floating-point.
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(Single.Epsilon, 32, 32, 32)]
		[PixelStructure(typeof(ColorRGBF))]
		RGBF,
		/// <summary>
		/// RGB composed by 3 half-precision floating-point.
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(HalfFloat.Epsilon, 16, 16, 16)]
		[PixelStructure(typeof(ColorRGBHF))]
		RGBHF,
		/// <summary>
		/// RGB composed by 3 double-precision floating-point.
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(Double.Epsilon, 64, 64, 64)]
		[PixelStructure(typeof(ColorRGBD))]
		RGBD,

		#endregion

		#region sRGB/sBGR Pixel Types

		/// <summary>
		/// sRGB composed by 24 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.sRgb)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		[PixelStructure(typeof(ColorSRGB24))]
		[PixelNonLinearAttribute()]
		SRGB24,
		/// <summary>
		/// sBGR composed by 24 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.sBgr)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		[PixelStructure(typeof(ColorSBGR24))]
		[PixelNonLinearAttribute()]
		SBGR24,

		#endregion

		#region RGBA Pixel Types

		/// <summary>
		/// RGBA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgba)]
		[PixelComponents(4)]
		[PixelPrecision(10, 10, 10, 2)]
		[PixelStructure(typeof(ColorRGB30A2))]
		RGB30A2,
		/// <summary>
		/// RGBA composed by 32 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgba)]
		[PixelComponents(4)]
		[PixelPrecision(8, 8, 8, 8)]
		[PixelStructure(typeof(ColorRGBA32))]
		RGBA32,
		/// <summary>
		/// RGBA composed by 64 bits (16 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgba)]
		[PixelComponents(4)]
		[PixelPrecision(16, 16, 16, 16)]
		[PixelStructure(typeof(ColorRGBA64))]
		RGBA64,
		/// <summary>
		/// RGBA composed by 4 (normalized) floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Rgba)]
		[PixelComponents(4)]
		[PixelPrecision(Single.Epsilon, 32, 32, 32, 32)]
		[PixelStructure(typeof(ColorRGBAF))]
		RGBAF,
		/// <summary>
		/// RGBA composed by 4 (normalized) half floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Rgba)]
		[PixelComponents(4)]
		[PixelPrecision(HalfFloat.Epsilon, 16, 16, 16, 16)]
		[PixelStructure(typeof(ColorRGBAHF))]
		RGBAHF,

		#endregion

		#region BGR Pixel Types

		/// <summary>
		/// BGR composed by 8 bits (2/3 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(2, 3, 3)]
		[PixelStructure(typeof(ColorBGR8))]
		BGR8,
		/// <summary>
		/// BGR composed by 15 bits (5 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		[PixelStructure(typeof(ColorBGR15))]
		BGR15,
		/// <summary>
		/// BGR composed by 16 bits (5/6 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(5, 6, 5)]
		[PixelStructure(typeof(ColorBGR16))]
		BGR16,
		/// <summary>
		/// BGR composed by 24 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		[PixelStructure(typeof(ColorBGR24))]
		BGR24,
		/// <summary>
		/// BGR composed by 48 bits (16 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(16, 16, 16)]
		[PixelStructure(typeof(ColorBGR48))]
		BGR48,
		/// <summary>
		/// BGR composed by 3 (normalized) floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(Single.Epsilon, 32, 32, 32)]
		[PixelStructure(typeof(ColorBGRF))]
		BGRF,
		/// <summary>
		/// RGB composed by 3 (normalized) half floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Bgr)]
		[PixelComponents(3)]
		[PixelPrecision(HalfFloat.Epsilon, 16, 16, 16)]
		[PixelStructure(typeof(ColorBGRHF))]
		BGRHF,

		#endregion

		#region BGRA Pixel Types

		/// <summary>
		/// BGRA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgra)]
		[PixelComponents(4)]
		[PixelPrecision(10, 10, 10, 2)]
		[PixelStructure(typeof(ColorBGR30A2))]
		BGR30A2,
		/// <summary>
		/// BGRA composed by 32 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgra)]
		[PixelComponents(4)]
		[PixelPrecision(8, 8, 8, 8)]
		[PixelStructure(typeof(ColorBGRA32))]
		BGRA32,
		/// <summary>
		/// BGRA composed by 64 bits (16 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Bgra)]
		[PixelComponents(4)]
		[PixelPrecision(16, 16, 16, 16)]
		[PixelStructure(typeof(ColorBGRA64))]
		BGRA64,
		/// <summary>
		/// BGRA composed by 4 (normalized) floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Bgra)]
		[PixelComponents(4)]
		[PixelPrecision(Single.Epsilon, 32, 32, 32, 32)]
		[PixelStructure(typeof(ColorBGRAF))]
		BGRAF,
		/// <summary>
		/// BGRA composed by 4 (normalized) half floating point numbers.
		/// </summary>
		[PixelColorspace(PixelSpace.Bgra)]
		[PixelComponents(4)]
		[PixelPrecision(HalfFloat.Epsilon, 16, 16, 16, 16)]
		[PixelStructure(typeof(ColorBGRAHF))]
		BGRAHF,

		#endregion

		#region Luminance/Chrominance Pixel Types

		/// <summary>
		/// YVU 4:1:0 (9 bits).
		/// </summary>
		/// <remarks>
		/// The three components are separated into three sub-images or planes. The Y plane is first. The Y plane has one byte per pixel. For
		/// YVU410, the Cr plane immediately follows the Y plane in memory. The Cr plane is ¼ the width and ¼ the height of the Y plane (and of the
		/// image). Each Cr belongs to 16 pixels, a four-by-four square of the image. Following the Cr plane is the Cb plane, just like the
		/// Cr plane. YUV410 is the same, except the Cb plane comes first, then the Cr plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have ¼ as many pad bytes after their rows. In other words, four Cx
		/// rows (including padding) are exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelPlanesAttribute(3, 4, 4)]
		[PixelPrecision(3, 3, 3)]
		YVU410 =			(((uint)'Y') << 0) | (((uint)'V') << 8) | (((uint)'U') << 16) | (((uint)'9') << 24),
		/// <summary>
		/// YVU 4:2:0 (12 bits).
		/// </summary>
		/// <remarks>
		/// These are planar formats, as opposed to a packed format. The three components are separated into three sub- images or planes. The Y plane
		/// is first. The Y plane has one byte per pixel. For YVU420, the Cr plane immediately follows the Y plane in memory. The Cr plane is half the
		/// width and half the height of the Y plane (and of the image). Each Cr belongs to four pixels, a two-by-two square of the image. For example,
		/// Cr0 belongs to Y'00, Y'01, Y'10, and Y'11. Following the Cr plane is the Cb plane, just like the Cr plane. YUV420 is the same except the Cb
		/// plane comes first, then the Cr plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have half as many pad bytes after their rows. In other words, two Cx
		/// rows (including padding) is exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelPlanesAttribute(3, 2, 2)]
		[PixelPrecision(4, 4, 4)]
		YVU420 =			(((uint)'Y') << 0) | (((uint)'V') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// In this format each four bytes is two pixels. Each four bytes is two Y's, a Cb and a Cr. Each Y goes to one of the pixels,
		/// and the Cb and Cr belong to both pixels. As you can see, the Cr and Cb components have half the horizontal resolution of the Y
		/// component. YUYV is known in the Windows environment as YUY2.
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		YUYV =				(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'Y') << 16) | (((uint)'V') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		YYUV =				(((uint)'Y') << 0) | (((uint)'Y') << 8) | (((uint)'U') << 16) | (((uint)'V') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		YVYU =				(((uint)'Y') << 0) | (((uint)'V') << 8) | (((uint)'Y') << 16) | (((uint)'U') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		UYVY =				(((uint)'U') << 0) | (((uint)'Y') << 8) | (((uint)'V') << 16) | (((uint)'Y') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		VYUY =				(((uint)'V') << 0) | (((uint)'Y') << 8) | (((uint)'U') << 16) | (((uint)'Y') << 24),
		/// <summary>
		/// Planar YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// This format is not commonly used. This is a planar version of the YUYV format. The three components are separated
		/// into three sub-images or planes. The Y plane is first. The Y plane has one byte per pixel. The Cb plane immediately
		/// follows the Y plane in memory. The Cb plane is half the width of the Y plane (and of the image). Each Cb belongs to
		/// two pixels. For example, Cb0 belongs to Y'00, Y'01. Following the Cb plane is the Cr plane, just like the Cb plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have half as many pad bytes after their rows.
		/// In other words, two Cx rows (including padding) is exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelPlanesAttribute(3, 2, 2)]
		[PixelPrecision(5, 5, 5)]
		YUV422P =			(((uint)'4') << 0) | (((uint)'2') << 8) | (((uint)'2') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// Planar YVU 4:1:1 (16 bits).
		/// </summary>
		/// <remarks>
		/// This format is not commonly used. This is a planar format similar to the 4:2:2 planar format except with half as many
		/// chroma. The three components are separated into three sub-images or planes. The Y plane is first. The Y plane has one
		/// byte per pixel. The Cb plane immediately follows the Y plane in memory. The Cb plane is ¼ the width of the Y plane (and
		/// of the image). Each Cb belongs to 4 pixels all on the same row. For example, Cb0 belongs to Y'00, Y'01, Y'02 and Y'03. Following
		/// the Cb plane is the Cr plane, just like the Cb plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have ¼ as many pad bytes after their rows. In other
		/// words, four C x rows (including padding) is exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelPlanesAttribute(3, 4, 4)]
		[PixelPrecision(5, 5, 5)]
		YUV411P =			(((uint)'4') << 0) | (((uint)'1') << 8) | (((uint)'1') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// YVU 4:1:1 (12 bits).
		/// </summary>
		/// <remarks>
		/// In this format each 12 bytes is eight pixels. In the twelve bytes are two CbCr pairs and eight Y's. The first CbCr
		/// pair goes with the first four Y's, and the second CbCr pair goes with the other four Y's. The Cb and Cr components have one
		/// fourth the horizontal resolution of the Y component.
		///
		/// Do not confuse this format with YUV411P. Y41P is derived from "YUV 4:1:1 packed", while YUV411P stands for "YUV 4:1:1 planar".
		///
		/// Example of 8 × 4 pixel image:
		/// start + 0:	Cb00	Y'00	Cr00	Y'01	Cb01	Y'02	Cr01	Y'03	Y'04	Y'05	Y'06	Y'07
		/// start + 12:	Cb10	Y'10	Cr10	Y'11	Cb11	Y'12	Cr11	Y'13	Y'14	Y'15	Y'16	Y'17
		/// start + 24:	Cb20	Y'20	Cr20	Y'21	Cb21	Y'22	Cr21	Y'23	Y'24	Y'25	Y'26	Y'27
		/// start + 36:	Cb30	Y'30	Cr30	Y'31	Cb31	Y'32	Cr31	Y'33	Y'34	Y'35	Y'36	Y'37
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(4, 4, 4)]
		Y41P =				(((uint)'Y') << 0) | (((uint)'4') << 8) | (((uint)'1') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// YVU 4-4-4 (16 bits, xxxxyyyy uuuuvvvv).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(4, 4, 4)]
		YUV444 =			(((uint)'Y') << 0) | (((uint)'4') << 8) | (((uint)'4') << 16) | (((uint)'4') << 24),
		/// <summary>
		/// YVU 5-5-5 (16 bits).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 5, 5)]
		YUV555 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'0') << 24),
		/// <summary>
		/// YVU 5-6-5 (16 bits).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(5, 6, 5)]
		YUV565 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// YVU 8-8-8-8 (32 bits).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		YUV32 =				(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'4') << 24),
		/// <summary>
		/// YVU 4:1:0 (9 bits).
		/// </summary>
		/// <remarks>
		/// The three components are separated into three sub-images or planes. The Y plane is first. The Y plane has one byte per pixel. For
		/// YUV410, the Cr plane immediately follows the Y plane in memory. The Cr plane is ¼ the width and ¼ the height of the Y plane (and of the
		/// image). Each Cr belongs to 16 pixels, a four-by-four square of the image. Following the Cr plane is the Cb plane, just like the
		/// Cr plane. YUV410 is the same, except the Cb plane comes first, then the Cr plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have ¼ as many pad bytes after their rows. In other words, four Cx
		/// rows (including padding) are exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(3, 3, 3)]
		YUV410 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'9') << 24),
		/// <summary>
		/// YVU 4:2:0 (12 bits).
		/// </summary>
		/// <remarks>
		/// These are planar formats, as opposed to a packed format. The three components are separated into three sub- images or planes. The Y plane
		/// is first. The Y plane has one byte per pixel. For YVU420, the Cr plane immediately follows the Y plane in memory. The Cr plane is half the
		/// width and half the height of the Y plane (and of the image). Each Cr belongs to four pixels, a two-by-two square of the image. For example,
		/// Cr0 belongs to Y'00, Y'01, Y'10, and Y'11. Following the Cr plane is the Cb plane, just like the Cr plane. YUV420 is the same except the Cb
		/// plane comes first, then the Cr plane.
		///
		/// If the Y plane has pad bytes after each row, then the Cr and Cb planes have half as many pad bytes after their rows. In other words, two Cx
		/// rows (including padding) is exactly as long as one Y row (including padding).
		/// </remarks>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(4, 4, 4)]
		YUV420 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// 8-bit color (8 bits).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(3, 3, 3)]
		HI240 =				(((uint)'H') << 0) | (((uint)'I') << 8) | (((uint)'2') << 16) | (((uint)'4') << 24),
		/// <summary>
		/// YUV 4:2:0 16x16 macroblocks (8 bits).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(2, 2, 2)]
		HM12 =				(((uint)'H') << 0) | (((uint)'M') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// YUV 4:2:0 (12 bits, 2 lines Y, 1 line UV interleaved).
		/// </summary>
		[PixelColorspace(PixelSpace.YUV)]
		[PixelComponents(3)]
		[PixelPrecision(4, 4, 4)]
		M420 =				(((uint)'M') << 0) | (((uint)'4') << 8) | (((uint)'2') << 16) | (((uint)'0') << 24),

		#endregion

		#region CMY(K)(A) Pixel Types

		/// <summary>
		/// CMY composed by 24 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.CMY)]
		[PixelComponents(3)]
		[PixelPrecision(8, 8, 8)]
		CMY24,
		/// <summary>
		/// CMYK composed by 32 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.CMYK)]
		[PixelComponents(4)]
		[PixelPrecision(8, 8, 8, 8)]
		CMYK32,
		/// <summary>
		/// CMYK composed by 64 bits (16 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.CMYK)]
		[PixelComponents(4)]
		[PixelPrecision(16, 16, 16, 16)]
		CMYK64,
		/// <summary>
		/// CMYKA composed by 40 bits (8 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.CMYKA)]
		[PixelComponents(5)]
		[PixelPrecision(8, 8, 8, 8)]
		CMYKA40,

		#endregion

		#region Depth Pixel Types

		/// <summary>
		/// Depth value (16 bit).
		/// </summary>
		[PixelColorspace(PixelSpace.Depth)]
		[PixelComponents(1)]
		[PixelPrecision(16)]
		Depth16,
		/// <summary>
		/// Depth value (24 bit).
		/// </summary>
		[PixelColorspace(PixelSpace.Depth)]
		[PixelComponents(1)]
		[PixelPrecision(24)]
		Depth24,
		/// <summary>
		/// Depth value (32 bit).
		/// </summary>
		[PixelColorspace(PixelSpace.Depth)]
		[PixelComponents(1)]
		[PixelPrecision(32)]
		Depth32,
		/// <summary>
		/// Depth value (single-precision floating-point).
		/// </summary>
		[PixelColorspace(PixelSpace.Depth)]
		[PixelComponents(1)]
		[PixelPrecision(Single.Epsilon, 32)]
		DepthF,

		#endregion

		#region Combined Depth/Stencil Pixel Types

		/// <summary>
		/// Combined depth/stencil value (24 bit for depth, 8 bit for stencil).
		/// </summary>
		[PixelColorspace(PixelSpace.DepthStencil)]
		[PixelComponents(2)]
		[PixelPrecision(24, 8)]
		Depth24Stencil8,
		/// <summary>
		/// Combined depth/stencil value (32 bit for depth, 8 bit for stencil).
		/// </summary>
		[PixelColorspace(PixelSpace.DepthStencil)]
		[PixelComponents(2)]
		[PixelPrecision(32, 8)]
		Depth32FStencil8,

		#endregion

		#region Integer Types

		/// <summary>
		/// Signed integer format (1 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32)]
		Integer1,
		/// <summary>
		/// Signed integer format (2 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32)]
		Integer2,
		/// <summary>
		/// Signed integer format (3 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32, 32)]
		Integer3,
		/// <summary>
		/// Signed integer format (4 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32, 32, 32)]
		Integer4,
		/// <summary>
		/// Unsigned integer format (1 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32)]
		UInteger1,
		/// <summary>
		/// Unsigned integer format (2 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32)]
		UInteger2,
		/// <summary>
		/// Unsigned integer format (3 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32, 32)]
		UInteger3,
		/// <summary>
		/// Unsigned integer format (4 component 32 bit wide).
		/// </summary>
		[PixelColorspace(PixelSpace.Integer)]
		[PixelComponents(1)]
		[PixelPrecision(32, 32, 32, 32)]
		UInteger4,

		#endregion
	}

	/// <summary>
	/// Pixel colorspace attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelColorspaceAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelColorspaceAttribute"/> class.
		/// </summary>
		/// <param name='pixelSpace'>
		/// The pixel color space.
		/// </param>
		public PixelColorspaceAttribute(PixelSpace pixelSpace)
		{
			PixelSpace = pixelSpace;
		}

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly PixelSpace PixelSpace;
	}

	/// <summary>
	/// Pixel components attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelComponentsAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelComponentsAttribute"/> class.
		/// </summary>
		/// <param name='pixelSpace'>
		/// The pixel color component count.
		/// </param>
		public PixelComponentsAttribute(byte pixelComponents)
		{
			PixelComponents = pixelComponents;
		}

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly byte PixelComponents;
	}

	/// <summary>
	/// Pixel planes attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPlanesAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelPlanesAttribute"/> class.
		/// </summary>
		/// <param name='planeCount'>
		/// The number of separate planes defining the pixel color.
		/// </param>
		/// <param name="xratio">
		/// The ratio between the Y plane horizontal length and the U/V plane horizontal length.
		/// </param>
		/// <param name="yratio">
		/// The ratio between the Y plane vertical length and the U/V plane vertical length.
		/// </param>
		public PixelPlanesAttribute(byte planeCount, byte xratio, byte yratio)
		{
			PixelPlanes = planeCount;
			XRatio = xratio;
			YRatio = yratio;
		}

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly byte PixelPlanes;

		/// <summary>
		/// The ratio between the Y plane horizontal length and the U/V plane horizontal length.
		/// </summary>
		public readonly byte XRatio;

		/// <summary>
		/// The ratio between the Y plane vertical length and the U/V plane vertical length.
		/// </summary>
		public readonly byte YRatio;
	}

	/// <summary>
	/// Pixel precision attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelPrecisionAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelPrecisionAttribute"/> class.
		/// </summary>
		/// <param name='componentBits'>
		/// The number of bits assigned to each pixel components.
		/// </param>
		public PixelPrecisionAttribute(params byte[] componentBits)
		{
			if ((componentBits == null) || (componentBits.Length == 0))
				throw new ArgumentException("no components", "componentBits");

			// Component bits
			PixelBits = 0;
			foreach (byte bits in componentBits)
				PixelBits += bits;
			// Derive component precision by relative bit count
			PixelPrecision = new double[componentBits.Length];
			for (int i = 0; i < componentBits.Length; i++)
				PixelPrecision[i] = 1.0 / (1 << componentBits[i]);
		}

		/// <summary>
		/// Construct <see cref="Derm.PixelPrecisionAttribute"/> class.
		/// </summary>
		/// <param name='componentBits'>
		/// The number of bits assigned to each pixel components.
		/// </param>
		public PixelPrecisionAttribute(double epsilon, params byte[] componentBits)
		{
			if ((componentBits == null) || (componentBits.Length == 0))
				throw new ArgumentException("no components", "componentBits");

			// Component bits
			PixelBits = 0;
			foreach (byte bits in componentBits)
				PixelBits += bits;
			// Fix precision for all components
			PixelPrecision = new double[componentBits.Length];
			for (int i = 0; i < componentBits.Length; i++)
				PixelPrecision[i] = epsilon;
		}

		/// <summary>
		/// The number of bits to represent color component.
		/// </summary>
		public readonly byte PixelBits;

		/// <summary>
		/// The pixel color space.
		/// </summary>
		public readonly double[] PixelPrecision;
	}

	/// <summary>
	/// Pixel size attribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelSizeAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelSizeAttribute"/> class.
		/// </summary>
		/// <param name="size">
		/// The number of bytes used by a single pixel.
		/// </param>
		public PixelSizeAttribute(byte size)
		{
			PixelBytes = size;
		}

		/// <summary>
		/// The number of bits to represent color component.
		/// </summary>
		public readonly byte PixelBytes;
	}

	/// <summary>
	/// Attribute for marking a pixel format as non-linear one.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Linearity of a pixel is meant as the capability of the pixel format to represent a color in a fixed
	/// range, usually representable in the uniform range [0.0, 1.0]. This characteristic allow to blend two
	/// colors correctly, since a function of two linear functions is still linear.
	/// </para>
	/// <para>
	/// Non-linear pixel formats may be blended after has been converted into a linear pixel format.
	/// </para>
	/// </remarks>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelNonLinearAttribute : Attribute
	{
	
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelStructureAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="Derm.PixelStructureAttribute"/> class.
		/// </summary>
		/// <param name="type">
		/// The structure type able to represent the pixel.
		/// </param>
		public PixelStructureAttribute(Type type)
		{
			PixelStructureType = type;
		}

		/// <summary>
		/// The number of bits to represent color component.
		/// </summary>
		public readonly Type PixelStructureType;
	}
}
