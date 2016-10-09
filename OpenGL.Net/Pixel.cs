
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Reference class for describing pixel/textel formats.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class offer a list of pixel types which are available for defining surface color buffers, texture context and pixel transfer
	/// operations. It offers methods for converting a set of pixels from a type to another also. It offers also an abstraction layer
	/// for integrating the this Pixel notation to OpenGL implementation.
	/// </para>
	/// <para>
	/// A pixel is completely identified by the enumeration <see cref="PixelLayout"/>. This enumeration defines all known pixel formats. This
	/// type is used on all those methods which requires a pixel format definition. From this compact representation, it's possible to
	/// retrieve complete information by getting a <see cref="Pixel.Format"/> (by calling <see cref="GetPixelFormat"/> method): this structure
	/// describe completly the pixel format.
	/// 
	/// It is also possible to obtain only specific pixel format information by calling some specialized routine, such as:
	/// - <see cref="GetPixelSpace"/>
	/// - <see cref="GetComponentsCount"/>
	/// - <see cref="GetComponentBits"/>
	/// - <see cref="GetPixelBits"/>
	/// - <see cref="GetPixelBytes"/>
	/// - <see cref="IsColorPixel"/>
	/// 
	/// However, all above information (and some more) can be obtained by getting a <see cref="Pixel.Format"/>.
	/// </para>
	/// <para>
	/// When managing multiple OpenGL versions, it can happen that a pixel/textel format is not supported natively (by driver/hardware combination). The
	/// abstraction layer used for OpenGL integration can be used to determine whether a pixel format is suitable for the following operations:
	/// - Texture format specification (internal format)
	/// - Texture unpack operations (upload texture data)
	/// - Texture pack operations (download texture data)
	/// - (Framebuffer pack|unpack)?
	/// </para>
	/// <para>
	/// When a pixel/textel format is not supported, the only solution is to convert the data source to a pixel format which is supported by the current
	/// implementation. By converting a color buffer it is possible to achieve an equivalent result by converting the source/destination color buffer.
	/// 
	/// The Pixel class offers a conversion routine which is able to convert most of combination of pixel formats defined in <see cref="PixelLayout"/>. To test
	/// whether the pixel format conversion is actually supported, application should call <see cref="IsConvertionSupported"/>. This routine determine
	/// whether a conversion from a pixel format to another is implemented.
	/// 
	/// The conversion is executed by <see cref="ConvertItemType"/> method.
	/// 
	/// For better support for OpenGL integration, the Pixel class offers also an algorithm to determine the best pixel format conversion for supporting
	/// OpenGL pack and unpack operations. Without this feature an application shall test pixel format conversion support and destination pixel type support;
	/// moreover, it is necessary the test for color precision loss due color conversion and the extra data storage required for holding the converted
	/// pixel source buffer.
	/// 
	/// To determine the best pixel format conversion for operating on OpenGL objects, application shall use <see cref="GuessBestSupportedConvertion"/>. Of
	/// course this is not necessary whenever the source color buffer format is supported by the underlying implementation used.
	/// </para>
	/// </remarks>
	public static class Pixel
	{
		#region Pixel Conversion

		/// <summary>
		/// Check whether a color conversion is supported.
		/// </summary>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> indicating the source pixel type.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> indicating the destination pixel type.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating that the conversion is supported or not.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown in the case <paramref name="srcType"/> or <paramref name="dstType"/> are <see cref="PixelLayout.None"/>.
		/// </exception>
		public static bool IsConvertionSupported(PixelLayout srcType, PixelLayout dstType)
		{
			if (srcType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type None", "srcType");
			if (dstType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type None", "dstType");

			return (GetConversionMethod(srcType, dstType) != null);
		}

		/// <summary>
		/// ConvertItemType a pixel array from a format to another one.
		/// </summary>
		/// <param name="src">
		/// A <see cref="Object"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color source used for conversion.
		/// </param>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="src"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="Object"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color destination used for conversion.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="dst"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the width of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the height of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception thrown in the case it is not possible to convert colors from <paramref name="src"/> to <paramref name="dst"/>.
		/// </exception>
		public static void Convert(object src, PixelLayout srcType, object dst, PixelLayout dstType, uint width, uint height)
		{
			GCHandle srcHandle = GCHandle.Alloc(src, GCHandleType.Pinned);
			try {
				GCHandle dstHandle = GCHandle.Alloc(src, GCHandleType.Pinned);
				try {
					Convert(srcHandle.AddrOfPinnedObject(), srcType, dstHandle.AddrOfPinnedObject(), dstType, width, height);
				} finally {
					dstHandle.Free();
				}
			} finally {
				srcHandle.Free();
			}
		}

		/// <summary>
		/// ConvertItemType a pixel array from a format to another one.
		/// </summary>
		/// <param name="src">
		/// A <see cref="IntPtr"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color source used for conversion.
		/// </param>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="src"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="IntPtr"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color destination used for conversion.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="dst"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the width of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the height of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception thrown in the case it is not possible to convert colors from <paramref name="src"/> to <paramref name="dst"/>.
		/// </exception>
		public static void Convert(IntPtr src, PixelLayout srcType, IntPtr dst, PixelLayout dstType, uint width, uint height)
		{
			MethodInfo conversionMethod = GetConversionMethod(srcType, dstType);

			if (conversionMethod == null)
				throw new NotImplementedException(String.Format("pixel convetion from {0} to {1} not implemented", srcType, dstType));
			conversionMethod.Invoke(null, new object[] {src, dst, width, height});
		}

		/// <summary>
		/// Flags used for customizing best pixel format conversion algorithm of <see cref="GuessBestSupportedConvertion"/>.
		/// </summary>
		/// <remarks>
		/// At the moment this enumeration is not meaninful. It is defined for future uses.
		/// </remarks>
		[Flags()]
		public enum SupportedConversionFlags : uint
		{
			/// <summary>
			/// The default flags for choosing the best supported format.
			/// </summary>
			Default =						0x0000,
		}

		/// <summary>
		/// Guess the best pixel conversion starting from a pixel type.
		/// </summary>
		/// <param name="src">
		/// A <see cref="PixelLayout"/> indicating the source pixel format to convert.
		/// </param>
		/// <returns>
		/// It returns a <see cref="PixelLayout"/> suitable for converting <paramref name="src"/>. In the case no
		/// pixel conversion method is found, it returns <see cref="PixelLayout.None"/>.
		/// </returns>
		/// <seealso cref="GuessBestSupportedConvertion(PixelLayout, SupportedConversionFlags)"/>
		public static PixelLayout GuessBestSupportedConvertion(PixelLayout src)
		{
			return (GuessBestSupportedConvertion(src, SupportedConversionFlags.Default));
		}

		/// <summary>
		/// Guess the best pixel conversion starting from a pixel type.
		/// </summary>
		/// <param name="src">
		/// A <see cref="PixelLayout"/> indicating the source pixel format to convert.
		/// </param>
		/// <param name="flags">
		/// A <see cref="SupportedConversionFlags"/> indicating special criteria used for determining the best supported
		/// conversion.
		/// </param>
		/// <returns>
		/// It returns a <see cref="PixelLayout"/> suitable for converting <paramref name="src"/>. In the case no
		/// pixel conversion method is found, it returns <see cref="PixelLayout.None"/>.
		/// </returns>
		/// <remarks>
		/// This routine is able to determine the best conversion method for pixel having the type <paramref name="src"/>. Generally
		/// the conversion method shall not degrade pixel components precision, indeed the conversion method will result in a larger
		/// pixel representation.
		/// 
		/// Suitable converted pixel types depends on the real support on the current host and on the current implementation.
		/// Hardware support is determined by calling <see cref="OpenGL.Pixel.IsSupportedInternalFormat"/>, while software support is determined
		/// by calling <see cref="OpenGL.Pixel.IsConvertionSupported"/>.
		/// 
		/// Source pixels having a color space <see cref="Pixel.Space.Rgb"/> or <see cref="Pixel.Space.Bgr"/> can be converted
		/// with each other since these two color spaces are equivalent.
		/// Source pixels having a color space <see cref="Pixel.Space.Gray"/> can be converted in pixel types having color space
		/// <see cref="Pixel.Space.Rgb"/> or <see cref="Pixel.Space.Bgr"/>.
		/// </remarks>
		/// <seealso cref="IsConvertionSupported"/>
		public static PixelLayout GuessBestSupportedConvertion(PixelLayout src, SupportedConversionFlags flags)
		{
			// Integer formats are not supported for conversion
			if (src.IsGlIntegerPixel() == true)
				return (PixelLayout.None);

			Array pTypesArray = Enum.GetValues(typeof(PixelLayout));		// Every pixel type
			List<PixelLayout> sameColorSpace = new List<PixelLayout>();
			List<PixelLayout> equivalentColorSpace = new List<PixelLayout>();

			PixelLayoutInfo srcFormatInfo = src.GetPixelFormat();
			PixelSpace srcSpace = srcFormatInfo.ColorSpace;

			foreach (PixelLayout pType in pTypesArray) {
				if ((pType != PixelLayout.None) && (pType.IsGlIntegerPixel() == false) && (pType.IsSupportedInternalFormat() == true)) {
					PixelLayoutInfo dstFormatInfo = pType.GetPixelFormat();
					PixelSpace dstSpace = dstFormatInfo.ColorSpace;

					// Match only pixel format compatible with conversion (float with float), having hardware support

					if (srcSpace == dstSpace)
						sameColorSpace.Add(pType);			// Same colorspace
					else if ((srcSpace == PixelSpace.Bgr) && (dstSpace == PixelSpace.Rgb))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (RGB <-> BGR)
					else if ((srcSpace == PixelSpace.sRgb) && (dstSpace == PixelSpace.Rgb))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (sRGB <-> RGB)
					else if ((srcSpace == PixelSpace.sBgr) && (dstSpace == PixelSpace.Rgb))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (sBGR <-> RGB)
					else if ((srcSpace == PixelSpace.Red) && ((dstSpace == PixelSpace.Rgb) || (dstSpace == PixelSpace.Bgr)))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (GRAY -> RGB or GRAY -> BGR)
					else if ((srcSpace == PixelSpace.CMY) && ((dstSpace == PixelSpace.Rgb) || (dstSpace == PixelSpace.Bgr)))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (CMY -> RGB or CMY -> BGR)
					else if ((srcSpace == PixelSpace.CMYK) && ((dstSpace == PixelSpace.Rgb) || (dstSpace == PixelSpace.Bgr)))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (CMYK -> RGB or CMYK -> BGR)
					else if ((srcSpace == PixelSpace.CMYKA) && ((dstSpace == PixelSpace.Rgba) || (dstSpace == PixelSpace.Bgra)))
						equivalentColorSpace.Add(pType);	// Equivalent colorspace (CMYKA -> RGB or CMYKA -> BGR)
				}
			}

#if false

			// Try to match 'src' pixel type with a pixel type having the same color space
			// Destination pixel formats are sorted in order to minimize as much as possible information loss due pixel
			// format precision
			sameColorSpace.Sort(delegate(PixelLayout a, PixelLayout b) {
				double aepsilon = GetPixelFormat(a).GetOverallPrecision();
				double bepsilon = GetPixelFormat(b).GetOverallPrecision();

				return (bepsilon.CompareTo(aepsilon));
			});
			foreach (PixelLayout pType in sameColorSpace) {
				if (IsConvertionSupported(src, pType) == true)
					return (pType);
			}

			// Try to match 'src' pixel type with a pixel type having an equivalent color space
			// Destination pixel formats are sorted in order to minimize as much as possible information loss due pixel
			// format precision
			equivalentColorSpace.Sort(delegate(PixelLayout a, PixelLayout b) {
				double aepsilon = GetPixelFormat(a).GetOverallPrecision();
				double bepsilon = GetPixelFormat(b).GetOverallPrecision();

				return (bepsilon.CompareTo(aepsilon));
			});
			foreach (PixelLayout pType in equivalentColorSpace) {
				if (IsConvertionSupported(src, pType) == true)
					return (pType);
			}
#endif

			return (PixelLayout.None);
		}

		/// <summary>
		/// Determine the routine able to convert pixel array (by reflection).
		/// </summary>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> determining the source array pixel format.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> determining the destination array pixel format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="MethodInfo"/> pointing to the conversion method. In the case the conversion
		/// is not implemeneted, it returns null.
		/// </returns>
		private static MethodInfo GetConversionMethod(PixelLayout srcType, PixelLayout dstType)
		{
			return (typeof(Pixel).GetMethod(
				GetConvertionMethodName(srcType, dstType),
				BindingFlags.NonPublic | BindingFlags.Static, null,
				new Type[] { typeof(IntPtr), typeof(IntPtr), typeof(uint), typeof(uint) }, null
			));
		}

		/// <summary>
		/// Determine the name of the routine able to convert two pixel bi-dimensional vectors.
		/// </summary>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> determining the source array pixel format.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> determining the destination array pixel format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> determining the method name able to convert an array of
		/// pixel from <paramref name="srcType"/> to <paramref name="dstType"/>.
		/// </returns>
		private static string GetConvertionMethodName(PixelLayout srcType, PixelLayout dstType)
		{
			return (String.Format("Convert_{0}_{1}", srcType.ToString(), dstType.ToString()));
		}

		#region IColor Convertion Support

		private static void Convert_RGB_RGB<T, Y>(object src, object dst, uint width, uint height) where T : IColor where Y : IColor
		{
			T[,] srcArray = (T[,])src;
			Y[,] dstArray = (Y[,])dst;
			Y sColor = default(Y);

			for (uint y = 0; y < height; y++) {
				for (uint x = 0; x < width; x++) {
					for (int c = 0; c < 3; c++)
						sColor[c] = srcArray[y, x][c];
					dstArray[y, x] = sColor;
				}
			}
		}

		private static void Convert_BGR_BGR<T, Y>(object src, object dst, uint width, uint height) where T : IColor where Y : IColor
		{
			Convert_RGB_RGB<T, Y>(src, dst, width, height);
		}

		private static void Convert_RGB_BGR<T, Y>(object src, object dst, uint width, uint height) where T : IColor where Y : IColor
		{
			T[,] srcArray = (T[,])src;
			Y[,] dstArray = (Y[,])dst;
			Y sColor = default(Y);

			for (uint y = 0; y < height; y++) {
				for (uint x = 0; x < width; x++) {
					for (int c = 0; c < 3; c++)
						sColor[2 - c] = srcArray[y, x][c];
					dstArray[y, x] = sColor;
				}
			}
		}

		private static void Convert_BGR_RGB<T, Y>(object src, object dst, uint width, uint height) where T : IColor where Y : IColor
		{
			Convert_RGB_BGR<T, Y>(src, dst, width, height);
		}

		#endregion

		#region Convertion From RGB

		private static void Convert_RGB8_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorRGB8, ColorRGB24>(src, dst, width, height);
		}

		private static void Convert_RGB15_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorRGB15, ColorRGB24>(src, dst, width, height);
		}

		private static void Convert_RGB16_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorRGB16, ColorRGB24>(src, dst, width, height);
		}

		private static void Convert_RGBF_RGBD(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorRGBF, ColorRGBD>(src, dst, width, height);
		}

		private static void Convert_RGBD_RGBF(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorRGBD, ColorRGBF>(src, dst, width, height);
		}

		private static void Convert_RGB24_BGR24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcBytes = 3, dstBytes = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcBytes;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstBytes;

					for (; (pSrcBuffer < pSrcBufferEnd) || (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcBytes, pDstBuffer += dstBytes) {
						pDstBuffer[0] = pSrcBuffer[2];
						pDstBuffer[1] = pSrcBuffer[1];
						pDstBuffer[2] = pSrcBuffer[0];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_RGBHF_RGBF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 3, dstStride = 3;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					int *pDstBuffer = (int*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = HalfFloat.HalfToFloat(pSrcBuffer[0]);
						pDstBuffer[1] = HalfFloat.HalfToFloat(pSrcBuffer[1]);
						pDstBuffer[2] = HalfFloat.HalfToFloat(pSrcBuffer[2]);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_RGBHF_BGRF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 3, dstStride = 3;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					int *pDstBuffer = (int*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[2] = HalfFloat.HalfToFloat(pSrcBuffer[0]);
						pDstBuffer[1] = HalfFloat.HalfToFloat(pSrcBuffer[1]);
						pDstBuffer[0] = HalfFloat.HalfToFloat(pSrcBuffer[2]);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_RGBF_RGBHF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 3, dstStride = 3;

				unsafe {
					int *pSrcBuffer = (int*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = HalfFloat.FloatToHalf(pSrcBuffer[0]);
						pDstBuffer[1] = HalfFloat.FloatToHalf(pSrcBuffer[1]);
						pDstBuffer[2] = HalfFloat.FloatToHalf(pSrcBuffer[2]);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_RGBF_BGRHF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 3, dstStride = 3;

				unsafe {
					int *pSrcBuffer = (int*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[2] = HalfFloat.FloatToHalf(pSrcBuffer[0]);
						pDstBuffer[1] = HalfFloat.FloatToHalf(pSrcBuffer[1]);
						pDstBuffer[0] = HalfFloat.FloatToHalf(pSrcBuffer[2]);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		internal static void ConvertColor_RGB_SRGB(float rgb, out float srgb)
		{
			if (rgb < 0.0f)					// Clamp minimum
				srgb = (0.0f);
			else if (rgb < 0.003138f)		// Amplify lower intensity
				srgb = (12.92f * rgb);
			else if (rgb < 1.0)				// sRGB compression
				srgb = (1.055f * (float)Math.Pow(rgb, 0.41666) - 0.055f);
			else							// Clampl maximum
				srgb = (1.0f);
		}

		#endregion

		#region Conversion From sRGB/sBGR

		private static void Convert_SRGB24_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_RGB_RGB<ColorSRGB24, ColorRGB24>(src, dst, width, height);
		}

		private static void Convert_SBGR24_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_BGR_RGB<ColorSBGR24, ColorRGB24>(src, dst, width, height);
		}

		internal static void ConvertColor_SRGB_RGB(float srgb, out float rgb)
		{
			if (srgb <= 0.04045)
				rgb = (srgb / 12.92f);
			else
				rgb = ((float)Math.Pow((srgb + 0.055) / 1.055, 2.4));
		}

		#endregion

		#region Convertion From RGBA

		private static void Convert_RGBA32_RGB24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 4, dstStride = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) || (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = pSrcBuffer[0];
						pDstBuffer[1] = pSrcBuffer[1];
						pDstBuffer[2] = pSrcBuffer[2];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		#endregion

		#region Convertion From BGR

		private static void Convert_BGR8_BGR24(object src, object dst, uint width, uint height)
		{
			Convert_BGR_BGR<ColorBGR8, ColorBGR24>(src, dst, width, height);
		}

		private static void Convert_BGR15_BGR24(object src, object dst, uint width, uint height)
		{
			Convert_BGR_BGR<ColorBGR15, ColorBGR24>(src, dst, width, height);
		}

		private static void Convert_BGR16_BGR24(object src, object dst, uint width, uint height)
		{
			Convert_BGR_BGR<ColorBGR16, ColorBGR24>(src, dst, width, height);
		}

		private static void Convert_BGR24_RGB24(object src, object dst, uint width, uint height)
		{
			Convert_RGB24_BGR24(src, dst, width, height);
		}

		private static void Convert_BGRHF_RGBF(object src, object dst, uint width, uint height)
		{
			Convert_RGBHF_BGRF(src, dst, width, height);
		}

		private static void Convert_BGRF_RGBHF(object src, object dst, uint width, uint height)
		{
			Convert_RGBF_BGRHF(src, dst, width, height);
		}

		#endregion

		#region Convertion From BGRA

		#endregion

		#region Convertion From GRAY

		/// <summary>
		/// Convert a GRAY16S to GRAY8 pixel array.
		/// </summary>
		/// <param name="src"></param>
		/// <param name="dst"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		private static void Convert_GRAY16S_GRAY8(IntPtr src, IntPtr dst, uint width, uint height)
		{
			unsafe {
				const uint srcStride = 2, dstStride = 1;

				short* srcPtr = (short*)src.ToPointer(), srcPtrEnd = srcPtr + width * height * srcStride;
				byte* dstPtr = (byte*)dst.ToPointer(), dstPtrEnd = dstPtr + width * height * dstStride;

				for (; (srcPtr < srcPtrEnd) && (dstPtr < dstPtrEnd); srcPtr += srcStride, dstPtr += dstStride) {
					double srcNormalized = *srcPtr / (double)Int16.MaxValue;

					*dstPtr = (byte)(Math.Abs(srcNormalized) * Byte.MaxValue);
				}
			}
		}

		private static void Convert_GRAY8_RGB24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = pSrcBuffer[0];
						pDstBuffer[1] = pSrcBuffer[0];
						pDstBuffer[2] = pSrcBuffer[0];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAY16_RGB48(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 3;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = pSrcBuffer[0];
						pDstBuffer[1] = pSrcBuffer[0];
						pDstBuffer[2] = pSrcBuffer[0];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAY32_RGB96(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 3;

				unsafe {
					uint *pSrcBuffer = (uint*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					uint *pDstBuffer = (uint*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = pSrcBuffer[0];
						pDstBuffer[1] = pSrcBuffer[0];
						pDstBuffer[2] = pSrcBuffer[0];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAYHF_RGB48(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 3;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = (ushort)(HalfFloat.ToFloat(pSrcBuffer[0]) * (float)0xFFFF);
						pDstBuffer[1] = (ushort)(HalfFloat.ToFloat(pSrcBuffer[0]) * (float)0xFFFF);
						pDstBuffer[2] = (ushort)(HalfFloat.ToFloat(pSrcBuffer[0]) * (float)0xFFFF);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAYF_RGB96(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 3;

				unsafe {
					float *pSrcBuffer = (float*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					uint *pDstBuffer = (uint*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						pDstBuffer[0] = (uint)(pSrcBuffer[0] * (float)0xFFFFFFFF);
						pDstBuffer[1] = (uint)(pSrcBuffer[0] * (float)0xFFFFFFFF);
						pDstBuffer[2] = (uint)(pSrcBuffer[0] * (float)0xFFFFFFFF);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAYHF_GRAYF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 1;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					int *pDstBuffer = (int*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride)
						pDstBuffer[0] = HalfFloat.HalfToFloat(pSrcBuffer[0]);
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_GRAYF_GRAYHF(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 1, dstStride = 1;

				unsafe {
					int *pSrcBuffer = (int*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride)
						pDstBuffer[0] = HalfFloat.FloatToHalf(pSrcBuffer[0]);
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		#endregion

		#region Convertion From CMY(K)(A)

		private static void Convert_CMY24_RGB24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 3, dstStride = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride)
						ConvertColor_CMY_RGB(pSrcBuffer[0], pSrcBuffer[1], pSrcBuffer[2], out pDstBuffer[0], out pDstBuffer[1], out pDstBuffer[2]);
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_CMYK32_RGB24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 4, dstStride = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						// Derive CMYK components (single-precision floating-point normalized to [0.0f, 1.0f])
						float c = (float)pSrcBuffer[0] / (float)Byte.MaxValue;
						float m = (float)pSrcBuffer[1] / (float)Byte.MaxValue;
						float y = (float)pSrcBuffer[2] / (float)Byte.MaxValue;
						float k = (float)pSrcBuffer[3] / (float)Byte.MaxValue;
						// Follow conversion formula
						float r, g, b;

						ConvertColor_CMYK_RGB(c, m, y, k, out r, out g, out b);

						// Clamp RGB values
						pDstBuffer[0] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, r)) * (float)Byte.MaxValue);
						pDstBuffer[1] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, g)) * (float)Byte.MaxValue);
						pDstBuffer[2] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, b)) * (float)Byte.MaxValue);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_CMYK64_RGB48(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 4, dstStride = 3;

				unsafe {
					ushort *pSrcBuffer = (ushort*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					ushort *pDstBuffer = (ushort*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						// Derive CMYK components (single-precision floating-point normalized to [0.0f, 1.0f])
						float c = (float)pSrcBuffer[0] / (float)UInt16.MaxValue;
						float m = (float)pSrcBuffer[1] / (float)UInt16.MaxValue;
						float y = (float)pSrcBuffer[2] / (float)UInt16.MaxValue;
						float k = (float)pSrcBuffer[3] / (float)UInt16.MaxValue;
						// Follow conversion formula
						float r, g, b;

						ConvertColor_CMYK_RGB(c, m, y, k, out r, out g, out b);

						// Clamp RGB values
						pDstBuffer[0] = (ushort)((float)Math.Max(0.0f, Math.Min(1.0f, r)) * (float)UInt16.MaxValue);
						pDstBuffer[1] = (ushort)((float)Math.Max(0.0f, Math.Min(1.0f, g)) * (float)UInt16.MaxValue);
						pDstBuffer[2] = (ushort)((float)Math.Max(0.0f, Math.Min(1.0f, b)) * (float)UInt16.MaxValue);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_CMYKA40_CMYK32(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 5, dstStride = 4;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						float r = (float)(Byte.MaxValue - pSrcBuffer[0]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;
						float g = (float)(Byte.MaxValue - pSrcBuffer[1]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;
						float b = (float)(Byte.MaxValue - pSrcBuffer[2]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;

						pDstBuffer[0] = pSrcBuffer[0];
						pDstBuffer[1] = pSrcBuffer[1];
						pDstBuffer[2] = pSrcBuffer[2];
						pDstBuffer[3] = pSrcBuffer[3];
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		private static void Convert_CMYKA40_RGB24(object src, object dst, uint width, uint height)
		{
			GCHandle pSrcData = GCHandle.Alloc(src, GCHandleType.Pinned), pDstData = GCHandle.Alloc(dst, GCHandleType.Pinned);

			try {
				const uint srcStride = 5, dstStride = 3;

				unsafe {
					byte *pSrcBuffer = (byte*)pSrcData.AddrOfPinnedObject().ToPointer(), pSrcBufferEnd = pSrcBuffer + width * height * srcStride;
					byte *pDstBuffer = (byte*)pDstData.AddrOfPinnedObject().ToPointer(), pDstBufferEnd = pDstBuffer + width * height * dstStride;

					for (; (pSrcBuffer < pSrcBufferEnd) && (pDstBuffer < pDstBufferEnd); pSrcBuffer += srcStride, pDstBuffer += dstStride) {
						float r = (float)(Byte.MaxValue - pSrcBuffer[0]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;
						float g = (float)(Byte.MaxValue - pSrcBuffer[1]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;
						float b = (float)(Byte.MaxValue - pSrcBuffer[2]) * (float)(Byte.MaxValue - pSrcBuffer[3]) / (float)Byte.MaxValue;

						pDstBuffer[0] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, r)) * (float)Byte.MaxValue);
						pDstBuffer[1] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, g)) * (float)Byte.MaxValue);
						pDstBuffer[2] = (byte)((float)Math.Max(0.0f, Math.Min(1.0f, b)) * (float)Byte.MaxValue);
					}
				}
			} finally {
				if (pSrcData.IsAllocated == true)
					pSrcData.Free();
				if (pDstData.IsAllocated == true)
					pDstData.Free();
			}
		}

		internal static void ConvertColor_CMY_RGB(Byte c, Byte m, Byte y, out Byte r, out Byte g, out Byte b)
		{
			// CMY to RGB conversion
			//
			// R = 1 - C
			// G = 1 - M
			// B = 1 - Y

			r = (Byte)(Byte.MaxValue - c);
			g = (Byte)(Byte.MaxValue - m);
			b = (Byte)(Byte.MaxValue - y);
		}

		internal static void ConvertColor_CMY_RGB(UInt16 c, UInt16 m, UInt16 y, out UInt16 r, out UInt16 g, out UInt16 b)
		{
			// CMY to RGB conversion
			//
			// R = 1 - C
			// G = 1 - M
			// B = 1 - Y

			r = (UInt16)(UInt16.MaxValue - c);
			g = (UInt16)(UInt16.MaxValue - m);
			b = (UInt16)(UInt16.MaxValue - y);
		}

		internal static void ConvertColor_CMY_RGB(float c, float m, float y, out float r, out float g, out float b)
		{
			// CMY to RGB conversion
			//
			// R = 1 - C
			// G = 1 - M
			// B = 1 - Y

			r = 1.0f - c;
			g = 1.0f - m;
			b = 1.0f - y;
		}

		internal static void ConvertColor_CMYK_RGB(float c, float m, float y, float k, out float r, out float g, out float b)
		{
			// CMYK to RGB conversion
			//
			// R = CLAMP(1 - (C * (1 - K) + K))
			// G = CLAMP(1 - (M * (1 - K) + K))
			// B = CLAMP(1 - (Y * (1 - K) + K))
			//
			// This formula is derived from the conversion chain CMYK -> CMY -> RGB

			r = 1.0f - (c * (1.0f - k) + k);
			g = 1.0f - (m * (1.0f - k) + k);
			b = 1.0f - (y * (1.0f - k) + k);
		}

		#endregion

		#endregion
	}
}