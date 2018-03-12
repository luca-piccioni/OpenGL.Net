
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

using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// Extension methods for <see cref="PixelLayout"/> enumeration.
	/// </summary>
	public static class PixelLayoutExtensions
	{
		#region Pixel Layout Metadata

		public static PixelSpace GetSpace(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.R32:
				case PixelLayout.GRAY16S:
				case PixelLayout.RF:
				case PixelLayout.RD:
				case PixelLayout.RHF:
					return PixelSpace.Red;
				case PixelLayout.RGB8:
				case PixelLayout.RGB15:
				case PixelLayout.RGB16:
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGB96:
				case PixelLayout.RGBF:
				case PixelLayout.RGBHF:
				case PixelLayout.RGBD:
					return PixelSpace.RGB;
				case PixelLayout.SRGB24:
					return PixelSpace.sRGB;
				case PixelLayout.SBGR24:
					return PixelSpace.sBGR;
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
					return PixelSpace.sRGB;
				case PixelLayout.BGR8:
				case PixelLayout.BGR15:
				case PixelLayout.BGR16:
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
					return PixelSpace.BGR;
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
					return PixelSpace.BGRA;
				case PixelLayout.YVU410:
				case PixelLayout.YVU420:
				case PixelLayout.YUYV:
				case PixelLayout.YYUV:
				case PixelLayout.YVYU:
				case PixelLayout.UYVY:
				case PixelLayout.VYUY:
				case PixelLayout.YUV422P:
				case PixelLayout.YUV411P:
				case PixelLayout.Y41P:
				case PixelLayout.YUV444:
				case PixelLayout.YUV555:
				case PixelLayout.YUV565:
				case PixelLayout.YUV32:
				case PixelLayout.YUV410:
				case PixelLayout.YUV420:
				case PixelLayout.HI240:
				case PixelLayout.HM12:
				case PixelLayout.M420:
					return PixelSpace.YUV;
				case PixelLayout.CMY24:
					return PixelSpace.CMY;
				case PixelLayout.CMYK32:
				case PixelLayout.CMYK64:
				case PixelLayout.CMYKA40:
					return PixelSpace.CMYK;
				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
					return PixelSpace.Depth;
				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
					return PixelSpace.DepthStencil;
				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return PixelSpace.Integer;
				default:
					throw new InvalidOperationException($"unrecognized PixelLayout {type}");
			}
		}

		public static byte GetBitsCount(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.R8:
				case PixelLayout.RGB8:
				case PixelLayout.BGR8:
					return 8;
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				case PixelLayout.RHF:
				case PixelLayout.RGB15:
				case PixelLayout.RGB16:
				case PixelLayout.BGR15:
				case PixelLayout.BGR16:
				case PixelLayout.Depth16:
					return 16;
				case PixelLayout.RGB24:
				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
				case PixelLayout.BGR24:
				case PixelLayout.CMY24:
				case PixelLayout.Depth24:
					return 24;
				case PixelLayout.R32:
				case PixelLayout.RF:
				case PixelLayout.RGBA32:
				case PixelLayout.BGRA32:
				case PixelLayout.CMYK32:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Integer1:
				case PixelLayout.UInteger1:
					return 32;
				case PixelLayout.CMYKA40:
				case PixelLayout.Depth32FStencil8:
					return 40;
				case PixelLayout.RGB48:
				case PixelLayout.RGBHF:
				case PixelLayout.BGR48:
				case PixelLayout.BGRHF:
					return 48;
				case PixelLayout.RD:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAHF:
				case PixelLayout.CMYK64:
				case PixelLayout.Integer2:
				case PixelLayout.UInteger2:
					return 64;
				case PixelLayout.RGB96:
				case PixelLayout.RGBF:
				case PixelLayout.BGRF:
				case PixelLayout.Integer3:
				case PixelLayout.UInteger3:
					return 96;
				case PixelLayout.RGBAF:
				case PixelLayout.BGRAF:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger4:
					return 128;
				case PixelLayout.RGBD:
					return 172;

				default:
					throw new InvalidOperationException($"unrecognized PixelLayout {type}");
			}
		}

		public static byte GetBytesCount(this PixelLayout type)
		{
			return (byte)(((GetBitsCount(type) + 7) / 8) & 0xFF);
		}

		public static Type GetStructType(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.R8:
					return typeof(ColorR8);
				case PixelLayout.R16:
					return typeof(ColorR16);
				case PixelLayout.R32:
					return typeof(ColorR32);
				case PixelLayout.RF:
					return typeof(ColorRF);
				case PixelLayout.RD:
					return typeof(ColorRD);
				case PixelLayout.RHF:
					return typeof(ColorRHF);
				case PixelLayout.RGB8:
					return typeof(ColorRGB8);
				case PixelLayout.RGB15:
					return typeof(ColorRGB15);
				case PixelLayout.RGB16:
					return typeof(ColorRGB16);
				case PixelLayout.RGB24:
					return typeof(ColorRGB24);
				case PixelLayout.RGB48:
					return typeof(ColorRGB48);
				case PixelLayout.RGB96:
					return typeof(ColorRGB96);
				case PixelLayout.RGBF:
					return typeof(ColorRGBF);
				case PixelLayout.RGBHF:
					return typeof(ColorRGBHF);
				case PixelLayout.RGBD:
					return typeof(ColorRGBD);
				case PixelLayout.RGBA32:
					return typeof(ColorRGBA32);
				case PixelLayout.RGBA64:
					return typeof(ColorRGBA64);
				case PixelLayout.RGBAF:
					return typeof(ColorRGBAF);
				case PixelLayout.RGBAHF:
					return typeof(ColorRGBAHF);
				case PixelLayout.Depth16:
					return typeof(ushort);
				case PixelLayout.Depth32:
					return typeof(uint);
				case PixelLayout.DepthF:
					return typeof(float);
				default:
					throw new InvalidOperationException($"unrecognized PixelLayout {type}");
			}
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
					return false;
				default:
					return true;
			}
		}

		public static bool IsPackedFormat(this PixelLayout type)
		{
			return !IsPlanarFormat(type);
		}

		public static bool IsPlanarFormat(this PixelLayout type)
		{
			switch (type) {
				case PixelLayout.YVU410:
				case PixelLayout.YVU420:
				case PixelLayout.YUV422P:
				case PixelLayout.YUV411P:
					return true;
				default:
					return false;		// Not listed YUV format are considered packed
			}
		}
	
		/// <summary>
		/// Determine whether a pixel type represents a color.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		private static bool IsColor(this PixelLayout type)
		{
			switch (GetSpace(type)) {
				case PixelSpace.Depth:
				case PixelSpace.DepthStencil:
					return false;
				default:
					return true;
			}
		}

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
		public static InternalFormat ToInternalFormat(this PixelLayout type)
		{
			switch (type) {

				#region RGB/BGR Formats

				case PixelLayout.RGB8:
				case PixelLayout.BGR8:	
					return InternalFormat.Rgb8;
#if !MONODROID
				case PixelLayout.RGB15:
				case PixelLayout.BGR15:
					return InternalFormat.Rgb5;
#endif
				case PixelLayout.RGB16:
				case PixelLayout.BGR16:
					return InternalFormat.Rgb8;
				case PixelLayout.RGB24:
				case PixelLayout.BGR24:
					return InternalFormat.Rgb8;
				case PixelLayout.RGB48:
				case PixelLayout.BGR48:
					return InternalFormat.Rgb16;
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.BGRF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.Rgba32f;
					else
						return InternalFormat.Rgb8;
				case PixelLayout.RGBHF:
				case PixelLayout.BGRHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.Rgb16f;
					else
						return InternalFormat.Rgb8;

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return InternalFormat.Srgb8;

				#endregion

				#region RGBA/BGRA Formats

				//case PixelLayout.RGB30A2:
				//case PixelLayout.BGR30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.BGRA32:
					return InternalFormat.Rgba8;
				case PixelLayout.RGBA64:
				case PixelLayout.BGRA64:
					return InternalFormat.Rgba16;
				case PixelLayout.RGBAF:
				case PixelLayout.BGRAF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.Rgba32f;
					else
						return InternalFormat.Rgba8;
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRAHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.Rgba16f;
					else
						return InternalFormat.Rgba8;

				#endregion

				#region GRAY Internal Formats

				case PixelLayout.R8:
					return InternalFormat.R8;
				case PixelLayout.R16:
					return InternalFormat.R16;
				case PixelLayout.GRAY16S:
					return InternalFormat.R16Snorm;
				case PixelLayout.RF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.R32f;
					else
						return InternalFormat.R8;
				case PixelLayout.RHF:
					if (Gl.CurrentExtensions.TextureFloat_ARB)
						return InternalFormat.R16f;
					else
						return InternalFormat.R8;

				#endregion

				#region GRAYA Formats

				//case PixelLayout.GRAYAF:
				//	return (Gl.RG32F);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
					return InternalFormat.DepthComponent16;
				case PixelLayout.Depth24:
					return InternalFormat.DepthComponent24;
				case PixelLayout.Depth32:
					return InternalFormat.DepthComponent32;
				case PixelLayout.DepthF:
					return InternalFormat.DepthComponent32f;

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return InternalFormat.Depth24Stencil8;
				case PixelLayout.Depth32FStencil8:
					return InternalFormat.Depth32fStencil8;

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
					return InternalFormat.R32i;
				case PixelLayout.Integer2:
					return InternalFormat.Rg32i;
				case PixelLayout.Integer3:
					return InternalFormat.Rgb32i;
				case PixelLayout.Integer4:
					return InternalFormat.Rgba32i;
				case PixelLayout.UInteger1:
					return InternalFormat.R32ui;
				case PixelLayout.UInteger2:
					return InternalFormat.Rg32ui;
				case PixelLayout.UInteger3:
					return InternalFormat.Rgb32ui;
				case PixelLayout.UInteger4:
					return InternalFormat.Rgba32ui;

				#endregion

				default:
					throw new Exception($"unsupported pixel internal format {type}");
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
					return Gl.CurrentExtensions.PackedPixels_EXT;
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
					return true;
				case PixelLayout.RGBF:
				case PixelLayout.RGBAF:
					return Gl.CurrentExtensions.TextureFloat_ARB;
				case PixelLayout.RGBD:
					return false;

				case PixelLayout.RGBHF:
				case PixelLayout.RGBAHF:
					return Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB;

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return Gl.CurrentExtensions.TextureSRGB_EXT;

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				//case PixelLayout.BGR30A2:
					return Gl.CurrentExtensions.PackedPixels_EXT;
				case PixelLayout.BGR15:
					return Gl.CurrentExtensions.PackedPixels_EXT && Gl.CurrentExtensions.TextureSwizzle_ARB;
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return Gl.CurrentExtensions.Bgra_EXT;
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.TextureFloat_ARB;
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB;

				#endregion

				#region GRAY Formats

				case PixelLayout.R8:
				case PixelLayout.R16:
					return Gl.CurrentExtensions.TextureSwizzle_ARB;
				case PixelLayout.GRAY16S:
					return Gl.CurrentExtensions.TextureSnorm_EXT;
				case PixelLayout.RF:
					return Gl.CurrentExtensions.TextureSwizzle_ARB && Gl.CurrentExtensions.TextureFloat_ARB;
				case PixelLayout.RHF:
					return Gl.CurrentExtensions.TextureSwizzle_ARB && Gl.CurrentExtensions.TextureFloat_ARB && Gl.CurrentExtensions.HalfFloatPixel_ARB;

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
					return false;

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
					return Gl.CurrentExtensions.DepthTexture_ARB;
				case PixelLayout.DepthF:
					return Gl.CurrentExtensions.DepthBufferFloat_ARB;

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return Gl.CurrentExtensions.DepthTexture_ARB;
				case PixelLayout.Depth32FStencil8:
					return Gl.CurrentExtensions.DepthBufferFloat_ARB;

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
					return Gl.CurrentExtensions.TextureInteger_EXT;

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
		public static PixelFormat ToDataFormat(this PixelLayout type)
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
					return PixelFormat.Rgb;
				case PixelLayout.RGB15:
					return PixelFormat.Rgba;

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
					return PixelFormat.Rgb;
#if !MONODROID
				case PixelLayout.SBGR24:
					return PixelFormat.Bgr;
#endif

				#endregion

				#region RGBA Internal Formats

				//case PixelLayout.RGB30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
					return PixelFormat.Rgba;

				#endregion

				#region BGR Internal Formats

				case PixelLayout.BGR8:				// Uses Gl.UNSIGNED_BYTE_2_3_3_REV as data type
				case PixelLayout.BGR16:             // Uses Gl.UNSIGNED_SHORT_5_6_5_REV as data type
					return PixelFormat.Rgb;
#if !MONODROID
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
					return PixelFormat.Bgr;
#endif
				case PixelLayout.BGR15:
					return PixelFormat.Rgba;		// Uses texture swizzle A = NONE and Gl.UNSIGNED_SHORT_5_5_5_1_REV as data type

				#endregion

				#region BGRA

				//case PixelLayout.BGR30A2:           // Uses Gl.UNSIGNED_INT_2_10_10_10_REV as data type
				//	return (PixelFormat.Rgba);
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
					return PixelFormat.Bgra;

				#endregion

				#region GRAY

				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				case PixelLayout.RF:
				case PixelLayout.RHF:
					return PixelFormat.Red;

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
					return PixelFormat.DepthComponent;

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
					return PixelFormat.DepthStencil;

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.UInteger1:
					return PixelFormat.RedInteger;
				case PixelLayout.Integer2:
				case PixelLayout.UInteger2:
					return PixelFormat.RgInteger;
				case PixelLayout.Integer3:
				case PixelLayout.UInteger3:
					return PixelFormat.RgbInteger;
				case PixelLayout.Integer4:
				case PixelLayout.UInteger4:
					return PixelFormat.RgbaInteger;

				#endregion

				default:
					throw new InvalidOperationException($"unsupported pixel format {type}");
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
					return Gl.CurrentExtensions.PackedPixels_EXT;
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBF:
				case PixelLayout.RGBAF:
					return true;
				case PixelLayout.RGBD:
					return false;

				case PixelLayout.RGBHF:
				case PixelLayout.RGBAHF:
					return Gl.CurrentExtensions.HalfFloatPixel_ARB;

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return Gl.CurrentExtensions.TextureSRGB_EXT;

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				//case PixelLayout.BGR30A2:
					return Gl.CurrentExtensions.PackedPixels_EXT;
				case PixelLayout.BGR15:
					return Gl.CurrentExtensions.PackedPixels_EXT && Gl.CurrentExtensions.TextureSwizzle_ARB;
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return Gl.CurrentExtensions.Bgra_EXT;
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return Gl.CurrentExtensions.Bgra_EXT;
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return Gl.CurrentExtensions.Bgra_EXT && Gl.CurrentExtensions.HalfFloatPixel_ARB;

				#endregion

				#region GRAY Formats

				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				//case PixelLayout.GRAYF:
					return true;
				
				case PixelLayout.RHF:
					return Gl.CurrentExtensions.HalfFloatPixel_ARB;

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
					return false;

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
					return false;

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
					return false;

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
					return Gl.CurrentExtensions.TextureInteger_EXT;

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
				return false;
			if (IsSupportedInternalFormat(internalFormat) == false)
				return false;

			// Data format and internal format shall match by color/no-color
			if (IsColor(dataFormat) != IsColor(internalFormat))
				return false;
			// Integer color format must have integer data format
			if (internalFormat.IsIntegerPixel() != dataFormat.IsIntegerPixel())
				return false;
			// Floating-point color format must have not-integer data format
			if (internalFormat.IsFloatPixel() && dataFormat.IsIntegerPixel())
				return false;

			return true;
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
				return false;
			if (IsSupportedInternalFormat(texFormat) == false)
				return false;

			// Check whether 'texFormat' and 'imgFormat' are color formats
			if (IsColor(texFormat) != IsColor(imgFormat))
				return false;
			// Check whether 'texFormat' is integer and 'imgFormat' is not integer
			if (IsIntegerPixel(texFormat) != IsIntegerPixel(imgFormat))
				return false;
			// Check whether 'texFormat' is not integer and 'imgFormat' is integer
			if (IsIntegerPixel(texFormat) == false && IsIntegerPixel(imgFormat))
				return false;

			return true;
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
		/// It returns a <see cref="PixelType"/> corresponding to <paramref name="type"/>.
		/// </returns>
		public static PixelType ToPixelType(this PixelLayout type)
		{
			switch (type) {

				#region RGB Data Types

#if !MONODROID
				case PixelLayout.RGB8:
					return PixelType.UnsignedByte332;
#endif
				case PixelLayout.RGB15:
					return PixelType.UnsignedShort5551;
				case PixelLayout.RGB16:
					return PixelType.UnsignedShort565;
				case PixelLayout.RGB24:
					return PixelType.UnsignedByte;
				case PixelLayout.RGB48:
					return PixelType.UnsignedShort;
				case PixelLayout.RGBF:
					return PixelType.Float;
#if !MONODROID
				case PixelLayout.RGBD:
					return PixelType.Double;
#endif
				case PixelLayout.RGBHF:
					return PixelType.HalfFloat;

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return PixelType.UnsignedByte;

				#endregion

				#region RGBA Data Types

				//case PixelLayout.RGB30A2:
				//	return (PixelType.UnsignedInt1010102);
				case PixelLayout.RGBA32:
					return PixelType.UnsignedByte;
				case PixelLayout.RGBA64:
					return PixelType.UnsignedShort;
				case PixelLayout.RGBAF:
					return PixelType.Float;
				case PixelLayout.RGBAHF:
					return PixelType.HalfFloat;

				#endregion

				#region BGR Data Types

#if !MONODROID
				case PixelLayout.BGR8:
					return PixelType.UnsignedByte233Rev;
#endif
				case PixelLayout.BGR15:
					return PixelType.UnsignedShort1555Rev;
#if !MONODROID
				case PixelLayout.BGR16:
					return PixelType.UnsignedShort565Rev;
#endif
				case PixelLayout.BGR24:
					return PixelType.UnsignedByte;
				case PixelLayout.BGR48:
					return PixelType.UnsignedShort;
				case PixelLayout.BGRF:
					return PixelType.Float;
				case PixelLayout.BGRHF:
					return PixelType.HalfFloat;

				#endregion

				#region BGRA Data Types

				//case PixelLayout.BGR30A2:
				//	return (PixelType.UnsignedInt2101010Rev);
				case PixelLayout.BGRA32:
					return PixelType.UnsignedByte;
				case PixelLayout.BGRA64:
					return PixelType.UnsignedShort;
				case PixelLayout.BGRAF:
					return PixelType.Float;
				case PixelLayout.BGRAHF:
					return PixelType.HalfFloat;

				#endregion

				#region GRAY Data Types

				case PixelLayout.R8:
					return PixelType.UnsignedByte;
				case PixelLayout.R16:
					return PixelType.UnsignedShort;
				case PixelLayout.GRAY16S:
					return PixelType.Short;
				case PixelLayout.RF:
					return PixelType.Float;
				case PixelLayout.RHF:
					return PixelType.HalfFloat;

				#endregion

				#region GRAYA Data Types

				//case PixelLayout.GRAYAF:
				//	return (PixelType.Float);

				#endregion

				#region Depth/Stencil Data Types

				case PixelLayout.Depth16:
					return PixelType.UnsignedShort;
				case PixelLayout.Depth24:
					return PixelType.UnsignedInt;
				case PixelLayout.Depth32:
					return PixelType.UnsignedInt;
				case PixelLayout.Depth24Stencil8:
					return PixelType.UnsignedInt;
				case PixelLayout.Depth32FStencil8:
				case PixelLayout.DepthF:
					return PixelType.Float;

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
					return PixelType.Int;
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return PixelType.UnsignedInt;

				#endregion

				default:
					throw new Exception($"unsupported textel data type {type}");
			}
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a unsigned integer (normalized) pixel.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		public static bool IsUnsignedPixel(this PixelLayout type)
		{
			return IsFloatPixel(type) == false && IsIntegerPixel(type) == false;
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a (single/double/half precision) floating-point pixel.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		public static bool IsFloatPixel(this PixelLayout type)
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
					return true;
				default:
					return false;
			}
		}

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		public static bool IsIntegerPixel(this PixelLayout type) { return IsSignedIntegerPixel(type) || IsUnsignedIntegerPixel(type); }

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		public static bool IsSignedIntegerPixel(this PixelLayout type)
		{
			return type == PixelLayout.Integer1 || type == PixelLayout.Integer2 || type == PixelLayout.Integer3 || type == PixelLayout.Integer4;
		}

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type">
		/// This <see cref="PixelLayout"/> to test.
		/// </param>
		/// <returns></returns>
		public static bool IsUnsignedIntegerPixel(this PixelLayout type)
		{
			return type == PixelLayout.UInteger1 || type == PixelLayout.UInteger2 || type == PixelLayout.UInteger3 || type == PixelLayout.UInteger4;
		}

		#endregion
	}
}
