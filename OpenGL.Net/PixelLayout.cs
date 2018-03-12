
// Copyright (C) 2012-2018 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// ReSharper disable InconsistentNaming

namespace OpenGL
{
	/// <summary>
	/// Pixel format model.
	/// </summary>
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
		R8,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		R16,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		R32,
		/// <summary>
		/// Grayscale composed by 16 bits.
		/// </summary>
		GRAY16S,
		/// <summary>
		/// Grayscale composed by floating point number (32 bit IEEE floating point).
		/// </summary>
		RF,
		/// <summary>
		/// Grayscale composed by floating point number (64 bit IEEE floating point).
		/// </summary>
		RD,
		/// <summary>
		/// Grayscale composed by half floating point number (16 bit IEEE floating point).
		/// </summary>
		RHF,

		#endregion

		#region RGB Pixel Types

		/// <summary>
		/// RGB composed by 8 bits (2/3 bit per component).
		/// </summary>
		RGB8,
		/// <summary>
		/// RGB composed by 15 bits (5/6 bit per component).
		/// </summary>
		RGB15,
		/// <summary>
		/// RGB composed by 16 bits (5/6 bit per component).
		/// </summary>
		RGB16,
		/// <summary>
		/// RGB composed by 24 bits (8 bit per component).
		/// </summary>
		RGB24,
		/// <summary>
		/// RGB composed by 48 bits (16 bit per component).
		/// </summary>
		RGB48,
		/// <summary>
		/// RGB composed by 96 bits (32 bit per component).
		/// </summary>
		RGB96,
		/// <summary>
		/// RGB composed by 3 single-precision floating-point.
		/// </summary>
		RGBF,
		/// <summary>
		/// RGB composed by 3 half-precision floating-point.
		/// </summary>
		RGBHF,
		/// <summary>
		/// RGB composed by 3 double-precision floating-point.
		/// </summary>
		RGBD,

		#endregion

		#region sRGB/sBGR Pixel Types

		/// <summary>
		/// sRGB composed by 24 bits (8 bit per component).
		/// </summary>
		SRGB24,
		/// <summary>
		/// sBGR composed by 24 bits (8 bit per component).
		/// </summary>
		SBGR24,

		#endregion

		#region RGBA Pixel Types

		///// <summary>
		///// RGBA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		///// </summary>
		//RGB30A2,
		/// <summary>
		/// RGBA composed by 32 bits (8 bit per component).
		/// </summary>
		RGBA32,
		/// <summary>
		/// RGBA composed by 64 bits (16 bit per component).
		/// </summary>
		RGBA64,
		/// <summary>
		/// RGBA composed by 4 (normalized) floating point numbers.
		/// </summary>
		RGBAF,
		/// <summary>
		/// RGBA composed by 4 (normalized) half floating point numbers.
		/// </summary>
		RGBAHF,

		#endregion

		#region BGR Pixel Types

		/// <summary>
		/// BGR composed by 8 bits (2/3 bit per component).
		/// </summary>
		BGR8,
		/// <summary>
		/// BGR composed by 15 bits (5 bit per component).
		/// </summary>
		BGR15,
		/// <summary>
		/// BGR composed by 16 bits (5/6 bit per component).
		/// </summary>
		BGR16,
		/// <summary>
		/// BGR composed by 24 bits (8 bit per component).
		/// </summary>
		BGR24,
		/// <summary>
		/// BGR composed by 48 bits (16 bit per component).
		/// </summary>
		BGR48,
		/// <summary>
		/// BGR composed by 3 (normalized) floating point numbers.
		/// </summary>
		BGRF,
		/// <summary>
		/// RGB composed by 3 (normalized) half floating point numbers.
		/// </summary>
		BGRHF,

		#endregion

		#region BGRA Pixel Types

		///// <summary>
		///// BGRA composed by 32 bits (30 bit per RGB components, 2 bit per A component).
		///// </summary>
		//BGR30A2,
		/// <summary>
		/// BGRA composed by 32 bits (8 bit per component).
		/// </summary>
		BGRA32,
		/// <summary>
		/// BGRA composed by 64 bits (16 bit per component).
		/// </summary>
		BGRA64,
		/// <summary>
		/// BGRA composed by 4 (normalized) floating point numbers.
		/// </summary>
		BGRAF,
		/// <summary>
		/// BGRA composed by 4 (normalized) half floating point numbers.
		/// </summary>
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
		YVU420 =			(((uint)'Y') << 0) | (((uint)'V') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// In this format each four bytes is two pixels. Each four bytes is two Y's, a Cb and a Cr. Each Y goes to one of the pixels,
		/// and the Cb and Cr belong to both pixels. As you can see, the Cr and Cb components have half the horizontal resolution of the Y
		/// component. YUYV is known in the Windows environment as YUY2.
		/// </remarks>
		YUYV =				(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'Y') << 16) | (((uint)'V') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		YYUV =				(((uint)'Y') << 0) | (((uint)'Y') << 8) | (((uint)'U') << 16) | (((uint)'V') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		YVYU =				(((uint)'Y') << 0) | (((uint)'V') << 8) | (((uint)'Y') << 16) | (((uint)'U') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
		UYVY =				(((uint)'U') << 0) | (((uint)'Y') << 8) | (((uint)'V') << 16) | (((uint)'Y') << 24),
		/// <summary>
		/// YVU 4:2:2 (16 bits).
		/// </summary>
		/// <remarks>
		/// Variation of YUYV with different order of samples in memory
		/// </remarks>
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
		Y41P =				(((uint)'Y') << 0) | (((uint)'4') << 8) | (((uint)'1') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// YVU 4-4-4 (16 bits, xxxxyyyy uuuuvvvv).
		/// </summary>
		YUV444 =			(((uint)'Y') << 0) | (((uint)'4') << 8) | (((uint)'4') << 16) | (((uint)'4') << 24),
		/// <summary>
		/// YVU 5-5-5 (16 bits).
		/// </summary>
		YUV555 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'0') << 24),
		/// <summary>
		/// YVU 5-6-5 (16 bits).
		/// </summary>
		YUV565 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'V') << 16) | (((uint)'P') << 24),
		/// <summary>
		/// YVU 8-8-8-8 (32 bits).
		/// </summary>
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
		YUV420 =			(((uint)'Y') << 0) | (((uint)'U') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// 8-bit color (8 bits).
		/// </summary>
		HI240 =				(((uint)'H') << 0) | (((uint)'I') << 8) | (((uint)'2') << 16) | (((uint)'4') << 24),
		/// <summary>
		/// YUV 4:2:0 16x16 macroblocks (8 bits).
		/// </summary>
		HM12 =				(((uint)'H') << 0) | (((uint)'M') << 8) | (((uint)'1') << 16) | (((uint)'2') << 24),
		/// <summary>
		/// YUV 4:2:0 (12 bits, 2 lines Y, 1 line UV interleaved).
		/// </summary>
		M420 =				(((uint)'M') << 0) | (((uint)'4') << 8) | (((uint)'2') << 16) | (((uint)'0') << 24),

		#endregion

		#region CMY(K)(A) Pixel Types

		/// <summary>
		/// CMY composed by 24 bits (8 bit per component).
		/// </summary>
		CMY24,
		/// <summary>
		/// CMYK composed by 32 bits (8 bit per component).
		/// </summary>
		CMYK32,
		/// <summary>
		/// CMYK composed by 64 bits (16 bit per component).
		/// </summary>
		CMYK64,
		/// <summary>
		/// CMYKA composed by 40 bits (8 bit per component).
		/// </summary>
		CMYKA40,

		#endregion

		#region Depth Pixel Types

		/// <summary>
		/// Depth value (16 bit).
		/// </summary>
		Depth16,
		/// <summary>
		/// Depth value (24 bit).
		/// </summary>
		Depth24,
		/// <summary>
		/// Depth value (32 bit).
		/// </summary>
		Depth32,
		/// <summary>
		/// Depth value (single-precision floating-point).
		/// </summary>
		DepthF,

		#endregion

		#region Combined Depth/Stencil Pixel Types

		/// <summary>
		/// Combined depth/stencil value (24 bit for depth, 8 bit for stencil).
		/// </summary>
		Depth24Stencil8,
		/// <summary>
		/// Combined depth/stencil value (32 bit for depth, 8 bit for stencil).
		/// </summary>
		Depth32FStencil8,

		#endregion

		#region Integer Types

		/// <summary>
		/// Signed integer format (1 component 32 bit wide).
		/// </summary>
		Integer1,
		/// <summary>
		/// Signed integer format (2 component 32 bit wide).
		/// </summary>
		Integer2,
		/// <summary>
		/// Signed integer format (3 component 32 bit wide).
		/// </summary>
		Integer3,
		/// <summary>
		/// Signed integer format (4 component 32 bit wide).
		/// </summary>
		Integer4,
		/// <summary>
		/// Unsigned integer format (1 component 32 bit wide).
		/// </summary>
		UInteger1,
		/// <summary>
		/// Unsigned integer format (2 component 32 bit wide).
		/// </summary>
		UInteger2,
		/// <summary>
		/// Unsigned integer format (3 component 32 bit wide).
		/// </summary>
		UInteger3,
		/// <summary>
		/// Unsigned integer format (4 component 32 bit wide).
		/// </summary>
		UInteger4,

		#endregion
	}
}
