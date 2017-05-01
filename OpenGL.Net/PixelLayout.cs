
// Copyright (C) 2012-2017 Luca Piccioni
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
using System.Collections.Generic;

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

		#region Red Pixel Types

		/// <summary>
		/// Grayscale composed by 8 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(8)]
		[PixelStructure(typeof(ColorR8))]
		R8,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(16)]
		[PixelStructure(typeof(ColorR16))]
		R16,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(32)]
		[PixelStructure(typeof(ColorR32))]
		R32,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(16)]
		GRAY16S,
		/// <summary>
		/// Grayscale composed by floating point number (32 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(Single.Epsilon, 32)]
		[PixelStructure(typeof(ColorRF))]
		RF,
		/// <summary>
		/// Grayscale composed by floating point number (64 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(Double.Epsilon, 64)]
		[PixelStructure(typeof(ColorRD))]
		RD,
		/// <summary>
		/// Grayscale composed by half floating point number (16 bit IEEE floating point).
		/// </summary>
		[PixelColorspace(PixelSpace.Red)]
		[PixelComponents(1)]
		[PixelPrecision(HalfFloat.Epsilon, 16)]
		[PixelStructure(typeof(ColorRHF))]
		RHF,

		#endregion

		#region Grayscale and Alpha Pixel Types

		///// <summary>
		///// Grayscale and alpha composed by floating point number (32 bit IEEE floating point).
		///// </summary>
		//[PixelColorspace(PixelSpace.GrayAlpha)]
		//[PixelComponents(2)]
		//[PixelPrecision(Single.Epsilon, 32, 32)]
		//[PixelStructure(typeof(ColorGRAYAF))]
		//GRAYAF,

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
		/// RGB composed by 96 bits (32 bit per component).
		/// </summary>
		[PixelColorspace(PixelSpace.Rgb)]
		[PixelComponents(3)]
		[PixelPrecision(32, 32, 32)]
		[PixelStructure(typeof(ColorRGB96))]
		RGB96,
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

		///// <summary>
		///// RGBA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		///// </summary>
		//[PixelColorspace(PixelSpace.Rgba)]
		//[PixelComponents(4)]
		//[PixelPrecision(10, 10, 10, 2)]
		//[PixelStructure(typeof(ColorRGB30A2))]
		//RGB30A2,
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

		///// <summary>
		///// BGRA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		///// </summary>
		//[PixelColorspace(PixelSpace.Bgra)]
		//[PixelComponents(4)]
		//[PixelPrecision(10, 10, 10, 2)]
		//[PixelStructure(typeof(ColorBGR30A2))]
		//BGR30A2,
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
	/// Extension methods for <see cref="PixelLayout"/> enumeration.
	/// </summary>
	public static class PixelLayoutExtensions
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static PixelLayoutExtensions()
		{
			foreach (object enumValue in Enum.GetValues(typeof(PixelLayout))) {
				PixelLayout pixelType = (PixelLayout)enumValue;

				if (pixelType == PixelLayout.None)
					continue;	// Invalid pixel format

				_PixelFormats.Add(pixelType, new PixelLayoutInfo(pixelType));
			}
		}

		#endregion

		#region Cached Information

		/// <summary>
		/// Get the pixel format corresponding to <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> which is requested its format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Pixel.Format"/> corresponding to <paramref name="type"/>.
		/// </returns>
		public static PixelLayoutInfo GetPixelFormat(this PixelLayout type)
		{
			if (_PixelFormats.ContainsKey(type) == false)
				throw new ArgumentException("unknown pixel type " + type, "type");

			return (_PixelFormats[type]);
		}

		public static bool IsLinearFormat(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.RGBHF:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
				case PixelLayout.RF:
				case PixelLayout.RHF:
				//case PixelLayout.GRAYAF:
					return (false);
				default:
					return (true);
			}
		}

		public static bool IsPackedPixel(this PixelLayout type)
		{
			return (!IsPlanarFormat(type));
		}

		public static bool IsPlanarFormat(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.YVU410:
				case PixelLayout.YVU420:
				case PixelLayout.YUV422P:
				case PixelLayout.YUV411P:
					return (true);
				default:
					return (false);		// Not listed YUV format are considered packed
			}
		}
	
		/// <summary>
		/// Determine whether a pixel type represents a color.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		private static bool IsColorPixel(this PixelLayout type)
		{
			switch (GetPixelFormat(type).ColorSpace) {
				case PixelSpace.Depth:
				case PixelSpace.DepthStencil:
					return (false);
				default:
					return (true);
			}
		}

		/// <summary>
		/// Collection of known pixel types.
		/// </summary>
		private static readonly Dictionary<PixelLayout, PixelLayoutInfo> _PixelFormats = new Dictionary<PixelLayout, PixelLayoutInfo>();

		#endregion

		#region Internal Format

		/// <summary>
		/// Determine the OpenGL internal format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL internal format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel internal format.
		/// </returns>
		public static InternalFormat GetGlInternalFormat(this PixelLayout type)
		{
			switch (type) {

				#region RGB/BGR Formats

				case PixelLayout.RGB8:
				case PixelLayout.BGR8:	
					return (InternalFormat.Rgb8);
				case PixelLayout.RGB15:
				case PixelLayout.BGR15:
					return (InternalFormat.Rgb5);
				case PixelLayout.RGB16:
				case PixelLayout.BGR16:
					return (InternalFormat.Rgb8);
				case PixelLayout.RGB24:
				case PixelLayout.BGR24:
					return (InternalFormat.Rgb8);
				case PixelLayout.RGB48:
				case PixelLayout.BGR48:
					return (InternalFormat.Rgb16);
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.BGRF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.Rgba32f);
					else
						return (InternalFormat.Rgb8);
				case PixelLayout.RGBHF:
				case PixelLayout.BGRHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.Rgb16f);
					else
						return (InternalFormat.Rgb8);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (InternalFormat.Srgb8);

				#endregion

				#region RGBA/BGRA Formats

				//case PixelLayout.RGB30A2:
				//case PixelLayout.BGR30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.BGRA32:
					return (InternalFormat.Rgba8);
				case PixelLayout.RGBA64:
				case PixelLayout.BGRA64:
					return (InternalFormat.Rgba16);
				case PixelLayout.RGBAF:
				case PixelLayout.BGRAF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.Rgba32f);
					else
						return (InternalFormat.Rgba8);
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRAHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.Rgba16f);
					else
						return (InternalFormat.Rgba8);

				#endregion

				#region GRAY Internal Formats

				case PixelLayout.R8:
					return (InternalFormat.R8);
				case PixelLayout.R16:
					return (InternalFormat.R16);
				case PixelLayout.GRAY16S:
					return (InternalFormat.R16Snorm);
				case PixelLayout.RF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.R32f);
					else
						return (InternalFormat.R8);
				case PixelLayout.RHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB == true)
						return (InternalFormat.R16f);
					else
						return (InternalFormat.R8);

				#endregion

				#region GRAYA Formats

				//case PixelLayout.GRAYAF:
				//	return (Gl.RG32F);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
					return (InternalFormat.DepthComponent16);
				case PixelLayout.Depth24:
					return (InternalFormat.DepthComponent24);
				case PixelLayout.Depth32:
					return (InternalFormat.DepthComponent32);
				case PixelLayout.DepthF:
					return (InternalFormat.DepthComponent32f);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return (InternalFormat.Depth24Stencil8);
				case PixelLayout.Depth32FStencil8:
					return (InternalFormat.Depth32fStencil8);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
					return (InternalFormat.R32i);
				case PixelLayout.Integer2:
					return (InternalFormat.Rg32i);
				case PixelLayout.Integer3:
					return (InternalFormat.Rgb32i);
				case PixelLayout.Integer4:
					return (InternalFormat.Rgba32i);
				case PixelLayout.UInteger1:
					return (InternalFormat.R32ui);
				case PixelLayout.UInteger2:
					return (InternalFormat.Rg32ui);
				case PixelLayout.UInteger3:
					return (InternalFormat.Rgb32ui);
				case PixelLayout.UInteger4:
					return (InternalFormat.Rgba32ui);

				#endregion

				default:
					throw new Exception(String.Format("unsupported pixel internal format {0}", type));
			}
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by some OpenGL implementation as internal format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, and it is stored internally with
		/// the same pixel format.
		/// </returns>
		public static bool IsSupportedInternalFormat(this PixelLayout type)
		{
			switch (type) {

				#region RGB/RGBA Formats

				case PixelLayout.RGB8:
				case PixelLayout.RGB16:
				//case PixelLayout.RGB30A2:
				case PixelLayout.RGB15:
					return (Gl.CurrentExtensions.PackedPixels_EXT);
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
					return (true);
				case PixelLayout.RGBF:
				case PixelLayout.RGBAF:
					return (Gl.CurrentExtensions.TextureFloat_ARB);
				case PixelLayout.RGBD:
					return (false);

				case PixelLayout.RGBHF:
				case PixelLayout.RGBAHF:
					return (Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (Gl.CurrentExtensions.TextureSRGB_EXT);

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				//case PixelLayout.BGR30A2:
					return (Gl.CurrentExtensions.PackedPixels_EXT);
				case PixelLayout.BGR15:
					return (Gl.CurrentExtensions.PackedPixels_EXT && Gl.CurrentExtensions.TextureSwizzle_ARB);
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return (Gl.CurrentExtensions.Bgra_EXT);
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return (Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.TextureFloat_ARB);
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return (Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				case PixelLayout.R8:
				case PixelLayout.R16:
					return (Gl.CurrentExtensions.TextureSwizzle_ARB);
				case PixelLayout.GRAY16S:
					return (Gl.CurrentExtensions.TextureSnorm_EXT);
				case PixelLayout.RF:
					return (Gl.CurrentExtensions.TextureSwizzle_ARB && Gl.CurrentExtensions.TextureFloat_ARB);
				case PixelLayout.RHF:
					return (Gl.CurrentExtensions.TextureSwizzle_ARB && Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				//case PixelLayout.GRAYAF:
				//	return (Gl.CurrentExtensions.TextureRg_ARB && Gl.CurrentExtensions.TextureSwizzle_ARB && Gl.CurrentExtensions.TextureFloat_ARB);

				#endregion

				#region CMYK Formats

				case PixelLayout.CMY24:
				case PixelLayout.CMYK32:
				case PixelLayout.CMYK64:
				case PixelLayout.CMYKA40:
					return (false);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
					return (Gl.CurrentExtensions.DepthTexture_ARB);
				case PixelLayout.DepthF:
					return (Gl.CurrentExtensions.DepthBufferFloat_ARB);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return (Gl.CurrentExtensions.DepthTexture_ARB);
				case PixelLayout.Depth32FStencil8:
					return (Gl.CurrentExtensions.DepthBufferFloat_ARB);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return (Gl.CurrentExtensions.TextureInteger_EXT);

				#endregion

				default:
					throw new ArgumentException("unknown pixel format " + type);
			}
		}

		#endregion

		#region Data Format

		/// <summary>
		/// Determine the OpenGL format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel format.
		/// </returns>
		public static PixelFormat GetGlFormat(this PixelLayout type)
		{
			switch (type) {

				#region RGB Internal Formats

				case PixelLayout.RGB8:
				case PixelLayout.RGB16:
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.RGBHF:
					return (PixelFormat.Rgb);
				case PixelLayout.RGB15:
					return (PixelFormat.Rgba);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
					return (PixelFormat.Rgb);
				case PixelLayout.SBGR24:
					return (PixelFormat.Bgr);

				#endregion

				#region RGBA Internal Formats

				//case PixelLayout.RGB30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
					return (PixelFormat.Rgba);

				#endregion

				#region BGR Internal Formats

				case PixelLayout.BGR8:				// Uses Gl.UNSIGNED_BYTE_2_3_3_REV as data type
				case PixelLayout.BGR16:             // Uses Gl.UNSIGNED_SHORT_5_6_5_REV as data type
					return (PixelFormat.Rgb);
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
					return (PixelFormat.Bgr);
				case PixelLayout.BGR15:
					return (PixelFormat.Rgba);		// Uses texture swizzle A = NONE and Gl.UNSIGNED_SHORT_5_5_5_1_REV as data type

				#endregion

				#region BGRA

				//case PixelLayout.BGR30A2:           // Uses Gl.UNSIGNED_INT_2_10_10_10_REV as data type
				//	return (PixelFormat.Rgba);
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
					return (PixelFormat.Bgra);

				#endregion

				#region GRAY

				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				case PixelLayout.RF:
				case PixelLayout.RHF:
					return (PixelFormat.Red);

				#endregion

				#region GRAYA Formats

				//case PixelLayout.GRAYAF:
				//	return (PixelFormat.Rg);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
					return (PixelFormat.DepthComponent);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
					return (PixelFormat.DepthStencil);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.UInteger1:
					return (PixelFormat.RedInteger);
				case PixelLayout.Integer2:
				case PixelLayout.UInteger2:
					return (PixelFormat.RgInteger);
				case PixelLayout.Integer3:
				case PixelLayout.UInteger3:
					return (PixelFormat.RgbInteger);
				case PixelLayout.Integer4:
				case PixelLayout.UInteger4:
					return (PixelFormat.RgbaInteger);

				#endregion

				default:
					throw new InvalidOperationException(String.Format("unsupported pixel format {0}", type));
			}
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as data format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, but it could be stored in
		/// another pixel format.
		/// </returns>
		/// <remarks>
		/// The OpenGL support is dependent on what extensions have been implemented by current driver/hardware. The following
		/// capabilities are tested:
		/// - <see cref="Gl.Extensions.Bgra_EXT"/>
		/// - <see cref="Gl.Extensions.PackedPixels_EXT"/>
		/// - <see cref="Gl.Extensions.TextureSwizzle_ARB"/>
		/// - <see cref="Gl.Extensions.HalfFloatPixel_ARB"/>
		/// 
		/// The main difference from <see cref="IsSupportedInternalFormat"/> is that the texture data submission could be specified using a pixel
		/// type <paramref name="type"/>, but OpenGL driver stores texture data internally using a different pixel format. This could lead to
		/// precision loss when specifying data from high-precision pixel formats (such as <see cref="PixelLayout.RGBF"/>. Indeed, it is implied that
		/// if IsSupportedInternalFormat(type) is true also IsSupportedSetDataFormat(type) is true (but not viceversa).
		/// 
		/// 
		/// </remarks>
		public static bool IsSupportedDataFormat(this PixelLayout type)
		{
			switch (type) {

				#region RGB/RGBA Formats

				case PixelLayout.RGB8:
				case PixelLayout.RGB16:
				//case PixelLayout.RGB30A2:
				case PixelLayout.RGB15:
					return (Gl.CurrentExtensions.PackedPixels_EXT);
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBF:
				case PixelLayout.RGBAF:
					return (true);
				case PixelLayout.RGBD:
					return (false);

				case PixelLayout.RGBHF:
				case PixelLayout.RGBAHF:
					return (Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (Gl.CurrentExtensions.TextureSRGB_EXT);

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				//case PixelLayout.BGR30A2:
					return (Gl.CurrentExtensions.PackedPixels_EXT);
				case PixelLayout.BGR15:
					return (Gl.CurrentExtensions.PackedPixels_EXT && Gl.CurrentExtensions.TextureSwizzle_ARB);
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return (Gl.CurrentExtensions.Bgra_EXT);
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return (Gl.CurrentExtensions.Bgra_EXT);
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return (Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				//case PixelLayout.GRAYF:
					return (true);
				
				case PixelLayout.RHF:
					return (Gl.CurrentExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAYA Formats

				//case PixelLayout.GRAYAF:
				//	return (Gl.CurrentExtensions.TextureRg_ARB);

				#endregion

				#region CMYK Formats

				case PixelLayout.CMY24:
				case PixelLayout.CMYK32:
				case PixelLayout.CMYK64:
				case PixelLayout.CMYKA40:
					return (false);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
					return (false);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
					return (false);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return (Gl.CurrentExtensions.TextureInteger_EXT);

				#endregion

				default:
					throw new ArgumentException("unknown pixel format " + type);
			}
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as data format for uploading
		/// texture data with a specific internal format.
		/// </summary>
		/// <param name="dataFormat">
		/// A <see cref="PixelLayout"/> to test for OpenGL support as data format in conjunction with the internal format <paramref name="internalFormat"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="PixelLayout"/> that specify the texture internal format.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		public static bool IsSupportedSetDataFormat(this PixelLayout dataFormat, PixelLayout internalFormat)
		{
			// Source and destination format shall be supported
			if (IsSupportedDataFormat(dataFormat) == false)
				return (false);
			if (IsSupportedInternalFormat(internalFormat) == false)
				return (false);

			// Data format and internal format shall match by color/no-color
			if (IsColorPixel(dataFormat) != IsColorPixel(internalFormat))
				return (false);
			// Integer color format must have integer data format
			if (internalFormat.IsGlIntegerPixel() != dataFormat.IsGlIntegerPixel())
				return (false);
			// Floating-point color format must have not-integer data format
			if ((internalFormat.IsGlFloatPixel() == true) && (dataFormat.IsGlIntegerPixel() == true))
				return (false);

			return (true);
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as data format for downloading
		/// texture data with a specific internal format.
		/// </summary>
		/// <param name="texFormat">
		/// The underlying texture internal format.
		/// </param>
		/// <param name="imgFormat">
		/// 
		/// </param>
		/// <returns></returns>
		public static bool IsSupportedGetDataFormat(this PixelLayout texFormat, PixelLayout imgFormat)
		{
			// Source and destination format shall be supported
			if (IsSupportedDataFormat(imgFormat) == false)
				return (false);
			if (IsSupportedInternalFormat(texFormat) == false)
				return (false);

			// Check whether 'texFormat' and 'imgFormat' are color formats
			if (IsColorPixel(texFormat) != IsColorPixel(imgFormat))
				return (false);
			// Check whether 'texFormat' is integer and 'imgFormat' is not integer
			if (IsGlIntegerPixel(texFormat) != IsGlIntegerPixel(imgFormat))
				return (false);
			// Check whether 'texFormat' is not integer and 'imgFormat' is integer
			if ((IsGlIntegerPixel(texFormat) == false) && (IsGlIntegerPixel(imgFormat) == true))
				return (false);

			return (true);
		}

		#endregion

		#region Pixel Type

		/// <summary>
		/// Determine the OpenGL data format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL data format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel data format.
		/// </returns>
		public static PixelType GetPixelType(this PixelLayout type)
		{
			switch (type) {

				#region RGB Data Types

				case PixelLayout.RGB8:
					return (PixelType.UnsignedByte332);
				case PixelLayout.RGB15:
					return (PixelType.UnsignedShort5551);
				case PixelLayout.RGB16:
					return (PixelType.UnsignedShort565);
				case PixelLayout.RGB24:
					return (PixelType.UnsignedByte);
				case PixelLayout.RGB48:
					return (PixelType.UnsignedShort);
				case PixelLayout.RGBF:
					return (PixelType.Float);
				case PixelLayout.RGBD:
					return (PixelType.Double);
				case PixelLayout.RGBHF:
					return (PixelType.HalfFloat);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (PixelType.UnsignedByte);

				#endregion

				#region RGBA Data Types

				//case PixelLayout.RGB30A2:
				//	return (PixelType.UnsignedInt1010102);
				case PixelLayout.RGBA32:
					return (PixelType.UnsignedInt8888);
				case PixelLayout.RGBA64:
					return (PixelType.UnsignedShort);
				case PixelLayout.RGBAF:
					return (PixelType.Float);
				case PixelLayout.RGBAHF:
					return (PixelType.HalfFloat);

				#endregion

				#region BGR Data Types

				case PixelLayout.BGR8:
					return (PixelType.UnsignedByte233Rev);
				case PixelLayout.BGR15:
					return (PixelType.UnsignedShort1555Rev);
				case PixelLayout.BGR16:
					return (PixelType.UnsignedShort565Rev);
				case PixelLayout.BGR24:
					return (PixelType.UnsignedByte);
				case PixelLayout.BGR48:
					return (PixelType.UnsignedShort);
				case PixelLayout.BGRF:
					return (PixelType.Float);
				case PixelLayout.BGRHF:
					return (PixelType.HalfFloat);

				#endregion

				#region BGRA Data Types

				//case PixelLayout.BGR30A2:
				//	return (PixelType.UnsignedInt2101010Rev);
				case PixelLayout.BGRA32:
					return (PixelType.UnsignedByte);
				case PixelLayout.BGRA64:
					return (PixelType.UnsignedShort);
				case PixelLayout.BGRAF:
					return (PixelType.Float);
				case PixelLayout.BGRAHF:
					return (PixelType.HalfFloat);

				#endregion

				#region GRAY Data Types

				case PixelLayout.R8:
					return (PixelType.UnsignedByte);
				case PixelLayout.R16:
					return (PixelType.UnsignedShort);
				case PixelLayout.GRAY16S:
					return (PixelType.Short);
				case PixelLayout.RF:
					return (PixelType.Float);
				case PixelLayout.RHF:
					return (PixelType.HalfFloat);

				#endregion

				#region GRAYA Data Types

				//case PixelLayout.GRAYAF:
				//	return (PixelType.Float);

				#endregion

				#region Depth/Stencil Data Types

				case PixelLayout.Depth16:
					return (PixelType.UnsignedShort);
				case PixelLayout.Depth24:
					return (PixelType.UnsignedInt);
				case PixelLayout.Depth32:
					return (PixelType.UnsignedInt);
				case PixelLayout.Depth24Stencil8:
					return (PixelType.UnsignedInt);
				case PixelLayout.Depth32FStencil8:
				case PixelLayout.DepthF:
					return (PixelType.Float);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
					return (PixelType.Int);
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return (PixelType.UnsignedInt);

				#endregion

				default:
					throw new Exception(String.Format("unsupported textel data type {0}", type));
			}
		}

		/// <summary>
		/// Determine the OpenGL data format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL data format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel data format.
		/// </returns>
		public static int GetPixelTypeCore(this PixelLayout type)
		{
			return ((int)GetPixelType(type));
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a unsigned integer (normalized) pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlUnsignedPixel(this PixelLayout type)
		{
			return ((IsGlFloatPixel(type) == false) && (IsGlIntegerPixel(type) == false));
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a (single/double/half precision) floating-point pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlFloatPixel(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.RGBHF:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
				case PixelLayout.RF:
				case PixelLayout.RHF:
				//case PixelLayout.GRAYAF:
					return (true);
				default:
					return (false);
			}
		}

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlIntegerPixel(this PixelLayout type) { return (GetPixelFormat(type).ColorSpace == PixelSpace.Integer); }

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlSignedIntegerPixel(this PixelLayout type)
		{
			if (IsGlIntegerPixel(type))
				throw new ArgumentException("not integer type", "type");

			switch (type) {
				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
					return (true);
				default:
					return (false);
			}
		}

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlUnsignedIntegerPixel(this PixelLayout type)
		{
			if (IsGlIntegerPixel(type))
				throw new ArgumentException("not integer type", "type");

			switch (type) {
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return (true);
				default:
					return (false);
			}
		}

		#endregion
	}
}
