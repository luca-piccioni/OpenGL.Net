
// Copyright (C) 2009-2015 Luca Piccioni
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
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Pixel()
		{
			foreach (object enumValue in Enum.GetValues(typeof(PixelLayout))) {
				PixelLayout pixelType = (PixelLayout)enumValue;

				if (pixelType == PixelLayout.None)
					continue;	// Invalid pixel format

				sPixelFormats.Add(pixelType, new PixelLayoutInfo(pixelType));
			}
		}

		#endregion

		#region Pixel Information

		/// <summary>
		/// Get the pixel format corresponding to <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> which is requested its format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Pixel.Format"/> corresponding to <paramref name="type"/>.
		/// </returns>
		public static PixelLayoutInfo GetPixelFormat(PixelLayout type)
		{
			if (sPixelFormats.ContainsKey(type) == false)
				throw new ArgumentException("unknown pixel type " + type, "type");

			return (sPixelFormats[type]);
		}

		public static bool IsLinearFormat(PixelLayout type)
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
				case PixelLayout.GRAYF:
				case PixelLayout.GRAYHF:
				case PixelLayout.GRAYAF:
					return (false);
				default:
					return (true);
			}
		}

		public static bool IsPackedPixel(PixelLayout type)
		{
			return (!IsPlanarFormat(type));
		}

		public static bool IsPlanarFormat(PixelLayout type)
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
		private static bool IsColorPixel(PixelLayout type)
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
		private static readonly Dictionary<PixelLayout, PixelLayoutInfo> sPixelFormats = new Dictionary<PixelLayout, PixelLayoutInfo>();

		#endregion

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

			return (GetConversionMethod(srcType, dstType, typeof(IntPtr)) != null);
		}

		/// <summary>
		/// ConvertItemType a pixel array from a format to another one.
		/// </summary>
		/// <param name="src">
		/// A <see cref="System.Object"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color source used for conversion.
		/// </param>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="src"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="System.Object"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color destination used for conversion.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="dst"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="System.UInt32"/> that specify the width of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <param name="height">
		/// A <see cref="System.UInt32"/> that specify the height of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception thrown in the case it is not possible to convert colors from <paramref name="src"/> to <paramref name="dst"/>.
		/// </exception>
		public static void Convert(object src, PixelLayout srcType, object dst, PixelLayout dstType, uint width, uint height)
		{
			MethodInfo mInfo = GetConversionMethod(srcType, dstType, typeof(object));

			if (mInfo == null)
				throw new NotImplementedException(String.Format("pixel convetion from {0} to {1} not implemented", srcType, dstType));
			mInfo.Invoke(null, new object[] {src, dst, width, height});
		}

		/// <summary>
		/// ConvertItemType a pixel array from a format to another one.
		/// </summary>
		/// <param name="src">
		/// A <see cref="System.IntPtr"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color source used for conversion.
		/// </param>
		/// <param name="srcType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="src"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="System.IntPtr"/> pointing to a bi-dimensional array of structures deriving from <see cref="IColor"/>. This array
		/// is the color destination used for conversion.
		/// </param>
		/// <param name="dstType">
		/// A <see cref="PixelLayout"/> that specify the structure type of <paramref name="dst"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="System.UInt32"/> that specify the width of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <param name="height">
		/// A <see cref="System.UInt32"/> that specify the height of the bi-dimensional arrays <paramref name="src"/> and <paramref name="dst"/>
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception thrown in the case it is not possible to convert colors from <paramref name="src"/> to <paramref name="dst"/>.
		/// </exception>
		public static void Convert(IntPtr src, PixelLayout srcType, IntPtr dst, PixelLayout dstType, uint width, uint height)
		{
			MethodInfo mInfo = GetConversionMethod(srcType, dstType, typeof(IntPtr));

			if (mInfo == null)
				throw new NotImplementedException(String.Format("pixel convetion from {0} to {1} not implemented", srcType, dstType));
			mInfo.Invoke(null, new object[] {src, dst, width, height});
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
			if (Pixel.IsGlIntegerPixel(src) == true)
				return (PixelLayout.None);

			Array pTypesArray = Enum.GetValues(typeof(PixelLayout));		// Every pixel type
			List<PixelLayout> sameColorSpace = new List<PixelLayout>();
			List<PixelLayout> equivalentColorSpace = new List<PixelLayout>();

			PixelLayoutInfo srcFormatInfo = GetPixelFormat(src);
			PixelSpace srcSpace = srcFormatInfo.ColorSpace;

			foreach (PixelLayout pType in pTypesArray) {
				if ((pType != PixelLayout.None) && (Pixel.IsGlIntegerPixel(pType) == false) && (IsSupportedInternalFormat(pType) == true)) {
					PixelLayoutInfo dstFormatInfo = GetPixelFormat(pType);
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
					else if ((srcSpace == PixelSpace.Gray) && ((dstSpace == PixelSpace.Rgb) || (dstSpace == PixelSpace.Bgr)))
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
		private static MethodInfo GetConversionMethod(PixelLayout srcType, PixelLayout dstType, Type dataType)
		{
			if (dataType == null)
				throw new ArgumentNullException("dataType");

			return (typeof(Pixel).GetMethod(
				GetConvertionMethodName(srcType, dstType),
				BindingFlags.NonPublic | BindingFlags.Static, null,
				new Type[] { dataType, dataType, typeof(uint), typeof(uint) }, null
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
		/// It returns a <see cref="System.String"/> determining the method name able to convert an array of
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

		#region OpenGL Interoperability

		#region Internal Format

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as internal format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, and it is stored internally with
		/// the same pixel format.
		/// </returns>
		public static bool IsSupportedInternalFormat(PixelLayout type)
		{
			return (IsSupportedInternalFormat(type, GraphicsContext.CurrentCaps));
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as internal format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify which OpenGL extension are supported.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, and it is stored internally with
		/// the same pixel format.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw when <paramref name="ctx"/> is null.
		/// </exception>
		public static bool IsSupportedInternalFormat(PixelLayout type, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			return (IsSupportedInternalFormat(type, ctx.Caps));
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by some OpenGL implementation as internal format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> that declares which extension are supported by a particoular OpenGL version.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, and it is stored internally with
		/// the same pixel format.
		/// </returns>
		/// <remarks>
		/// The OpenGL support is dependent on what extensions have been implemented by current driver/hardware. The following
		/// capabilities are tested:
		/// - <see cref="GraphicsContext.Capabilities.BgraFormat"/>
		/// - <see cref="GraphicsContext.Capabilities.PackedFormats"/>
		/// - <see cref="GraphicsContext.Capabilities.GlExtensions.TextureSwizzle_ARB"/>
		/// - <see cref="GraphicsContext.Capabilities.GlExtensions.HalfFloatPixel_ARB"/>
		/// - <see cref="GraphicsContext.Capabilities.TextureFloat"/>
		/// The above extension are widely supported, even by old entry-level graphic chipset; but for having a robust
		/// support, those extentions are always checked when dialing with pixel types, in order to avoid errors on
		/// texture uploads.
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.BgraFormat"/> OpenGL
		/// extension:
		/// - <see cref="Type.BGR24"/>
		/// - <see cref="Type.BGRF"/>
		/// - <see cref="Type.BGRHF"/>
		/// - <see cref="Type.BGRAF"/>
		/// - <see cref="Type.BGRAHF"/>
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.PackedFormats"/> OpenGL
		/// extension:
		/// - <see cref="Type.RGB8"/>
		/// - <see cref="Type.RGB15"/>
		/// - <see cref="Type.RGB16"/>
		/// - <see cref="Type.RGB30A2"/>
		/// - <see cref="Type.BGR8"/>
		/// - <see cref="Type.BGR15"/>
		/// - <see cref="Type.BGR16"/>
		/// - <see cref="Type.BGR30A2"/>
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.GlExtensions.TextureSwizzle_ARB"/> OpenGL
		/// extension:
		/// - <see cref="Type.RGB15"/>
		/// - <see cref="Type.BGR15"/>
		/// - <see cref="Type.GRAY8"/>
		/// - <see cref="Type.GRAY16"/>
		/// - <see cref="Type.GRAY32"/>
		/// - <see cref="Type.GRAYF"/>
		/// - <see cref="Type.GRAYAF"/>
		/// - <see cref="Type.GRAYHF"/>
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.GlExtensions.HalfFloatPixel_ARB"/> and on
		/// <see cref="GraphicsContext.Capabilities.TextureFloat"/> OpenGL extensions:
		/// - <see cref="Type.RGBHF"/>
		/// - <see cref="Type.RGBAHF"/>
		/// - <see cref="Type.BGRHF"/>
		/// - <see cref="Type.BGRAHF"/>
		/// - <see cref="Type.GRAYHF"/>
		/// - <see cref="Type.GRAYAF"/>
		/// In the case only <see cref="GraphicsContext.Capabilities.TextureFloat"/> is supported, half floating-point formats are "hopefully"
		/// converted in float as internal format.
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.GlExtensions.TextureRg_ARB"/> OpenGL
		/// extension:
		/// - <see cref="Type.GRAYAF"/>
		/// 
		/// The following pixel formats are dependent on the <see cref="GraphicsContext.Capabilities.GlExtensions.DepthTexture_ARB"/> OpenGL extension:
		/// - <see cref="Type.Depth16"/>
		/// - <see cref="Type.Depth24"/>
		/// - <see cref="Type.Depth32"/>
		/// - <see cref="Type.DepthF"/>
		/// </remarks>
		private static bool IsSupportedInternalFormat(PixelLayout type, GraphicsCapabilities caps)
		{
			switch (type) {

				#region RGB/RGBA Formats

				case PixelLayout.RGB8:
				case PixelLayout.RGB16:
				case PixelLayout.RGB30A2:
				case PixelLayout.RGB15:
					return (caps.GlExtensions.PackedPixels_EXT);
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
					return (true);
				case PixelLayout.RGBF:
				case PixelLayout.RGBAF:
					return (caps.GlExtensions.TextureFloat_ARB);
				case PixelLayout.RGBD:
					return (false);

				case PixelLayout.RGBHF:
				case PixelLayout.RGBAHF:
					return (caps.GlExtensions.TextureFloat_ARB && caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (caps.GlExtensions.TextureSRGB_EXT);

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				case PixelLayout.BGR30A2:
					return (caps.GlExtensions.PackedPixels_EXT);
				case PixelLayout.BGR15:
					return (caps.GlExtensions.PackedPixels_EXT && caps.GlExtensions.TextureSwizzle_ARB);
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return (caps.GlExtensions.Bgra_EXT);
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return (caps.GlExtensions.Bgra_EXT && caps.GlExtensions.TextureFloat_ARB);
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return (caps.GlExtensions.Bgra_EXT && caps.GlExtensions.TextureFloat_ARB && caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				case PixelLayout.GRAY8:
				case PixelLayout.GRAY16:
					return (caps.GlExtensions.TextureSwizzle_ARB);
				case PixelLayout.GRAYF:
					return (caps.GlExtensions.TextureSwizzle_ARB && caps.GlExtensions.TextureFloat_ARB);
				case PixelLayout.GRAYHF:
					return (caps.GlExtensions.TextureSwizzle_ARB && caps.GlExtensions.TextureFloat_ARB && caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				case PixelLayout.GRAYAF:
					return (caps.GlExtensions.TextureRg_ARB && caps.GlExtensions.TextureSwizzle_ARB && caps.GlExtensions.TextureFloat_ARB);

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
					return (caps.GlExtensions.DepthTexture_ARB);
				case PixelLayout.DepthF:
					return (caps.GlExtensions.DepthBufferFloat_ARB);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return (caps.GlExtensions.DepthTexture_ARB);
				case PixelLayout.Depth32FStencil8:
					return (caps.GlExtensions.DepthBufferFloat_ARB);

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
					return (caps.GlExtensions.TextureInteger_EXT);

				#endregion

				default:
					throw new ArgumentException("unknown pixel format " + type);
			}
		}

		#endregion

		#region Data Format

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
		public static bool IsSupportedDataFormat(PixelLayout type)
		{
			return (IsSupportedDataFormat(type, GraphicsContext.CurrentCaps));
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as data format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify which OpenGL extension are supported.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, but it could be stored in
		/// another pixel format.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw when <paramref name="ctx"/> is null.
		/// </exception>
		public static bool IsSupportedDataFormat(PixelLayout type, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			return (IsSupportedDataFormat(type, ctx.Caps));
		}

		/// <summary>
		/// Determine whether a <see cref="PixelLayout"/> is supported by current OpenGL implementation as data format.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to test for OpenGL support.
		/// </param>
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> that declares which extension are supported by a particoular OpenGL version.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the current OpenGL implementation supports for the pixel type <paramref name="type"/>. The
		/// OpenGL support means that texture data could be specified in the pixel format <paramref name="type"/>, but it could be stored in
		/// another pixel format.
		/// </returns>
		/// <remarks>
		/// The OpenGL support is dependent on what extensions have been implemented by current driver/hardware. The following
		/// capabilities are tested:
		/// - <see cref="GraphicsContext.Capabilities.BgraFormat"/>
		/// - <see cref="GraphicsContext.Capabilities.PackedFormats"/>
		/// - <see cref="GraphicsContext.Capabilities.GlExtensions.TextureSwizzle_ARB"/>
		/// - <see cref="GraphicsContext.Capabilities.GlExtensions.HalfFloatPixel_ARB"/>
		/// 
		/// The main difference from <see cref="IsSupportedInternalFormat"/> is that the texture data submission could be specified using a pixel
		/// type <paramref name="type"/>, but OpenGL driver stores texture data internally using a different pixel format. This could lead to
		/// precision loss when specifying data from high-precision pixel formats (such as <see cref="PixelLayout.RGBF"/>. Indeed, it is implied that
		/// if IsSupportedInternalFormat(type) is true also IsSupportedSetDataFormat(type) is true (but not viceversa).
		/// 
		/// 
		/// </remarks>
		private static bool IsSupportedDataFormat(PixelLayout type, GraphicsCapabilities caps)
		{
			switch (type) {

				#region RGB/RGBA Formats

				case PixelLayout.RGB8:
				case PixelLayout.RGB16:
				case PixelLayout.RGB30A2:
				case PixelLayout.RGB15:
					return (caps.GlExtensions.PackedPixels_EXT);
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
					return (caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (caps.GlExtensions.TextureSRGB_EXT);

				#endregion

				#region BGR/BGRA Formats

				case PixelLayout.BGR8:
				case PixelLayout.BGR16:
				case PixelLayout.BGR30A2:
					return (caps.GlExtensions.PackedPixels_EXT);
				case PixelLayout.BGR15:
					return (caps.GlExtensions.PackedPixels_EXT && caps.GlExtensions.TextureSwizzle_ARB);
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
					return (caps.GlExtensions.Bgra_EXT);
				case PixelLayout.BGRAF:
				case PixelLayout.BGRF:
					return (caps.GlExtensions.Bgra_EXT);
				case PixelLayout.BGRHF:
				case PixelLayout.BGRAHF:
					return (caps.GlExtensions.Bgra_EXT && caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAY Formats

				case PixelLayout.GRAY8:
				case PixelLayout.GRAY16:
				case PixelLayout.GRAYF:
					return (true);
				
				case PixelLayout.GRAYHF:
					return (caps.GlExtensions.HalfFloatPixel_ARB);

				#endregion

				#region GRAYA Formats

				case PixelLayout.GRAYAF:
					return (caps.GlExtensions.TextureRg_ARB);

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
					return (caps.GlExtensions.TextureInteger_EXT);

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
		public static bool IsSupportedSetDataFormat(PixelLayout dataFormat, PixelLayout internalFormat)
		{
			return (IsSupportedSetDataFormat(dataFormat, internalFormat, GraphicsContext.CurrentCaps));
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
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify which OpenGL extension are supported.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw when <paramref name="ctx"/> is null.
		/// </exception>
		public static bool IsSupportedSetDataFormat(PixelLayout dataFormat, PixelLayout internalFormat, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			return (IsSupportedSetDataFormat(dataFormat, internalFormat, ctx.Caps));
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
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> that declares which extension are supported by a particoular OpenGL version.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		private static bool IsSupportedSetDataFormat(PixelLayout dataFormat, PixelLayout internalFormat, GraphicsCapabilities caps)
		{
			// Source and destination format shall be supported
			if (IsSupportedDataFormat(dataFormat, caps) == false)
				return (false);
			if (IsSupportedInternalFormat(internalFormat, caps) == false)
				return (false);

			// Data format and internal format shall match by color/no-color
			if (IsColorPixel(dataFormat) != IsColorPixel(internalFormat))
				return (false);
			// Integer color format must have integer data format
			if (IsGlIntegerPixel(internalFormat) != IsGlIntegerPixel(dataFormat))
				return (false);
			// Floating-point color format must have not-integer data format
			if ((IsGlFloatPixel(internalFormat) == true) && (IsGlIntegerPixel(dataFormat) == true))
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
		public static bool IsSupportedGetDataFormat(PixelLayout texFormat, PixelLayout imgFormat)
		{
			return (IsSupportedGetDataFormat(texFormat, imgFormat, GraphicsContext.CurrentCaps));
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
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify which OpenGL extension are supported.
		/// </param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw when <paramref name="ctx"/> is null.
		/// </exception>
		public static bool IsSupportedGetDataFormat(PixelLayout texFormat, PixelLayout imgFormat, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			return (IsSupportedGetDataFormat(texFormat, imgFormat, ctx.Caps));
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
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> that declares which extension are supported by a particoular OpenGL version.
		/// </param>
		/// <returns></returns>
		private static bool IsSupportedGetDataFormat(PixelLayout texFormat, PixelLayout imgFormat, GraphicsCapabilities caps)
		{
			// Source and destination format shall be supported
			if (IsSupportedDataFormat(imgFormat, caps) == false)
				return (false);
			if (IsSupportedInternalFormat(texFormat, caps) == false)
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

		/// <summary>
		/// Determine the OpenGL internal format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL internal format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel internal format.
		/// </returns>
		public static int GetGlInternalFormat(PixelLayout type)
		{
			return (GetGlInternalFormat(type, GraphicsContext.CurrentCaps));
		}

		/// <summary>
		/// Determine the OpenGL internal format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL internal format.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specify which extensions are supported.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel internal format.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw when <paramref name="ctx"/> is null.
		/// </exception>
		public static int GetGlInternalFormat(PixelLayout type, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			return (GetGlInternalFormat(type, ctx.Caps));
		}

		/// <summary>
		/// Determine the OpenGL internal format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL internal format.
		/// </param>
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> that specify which extension are supported.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel internal format.
		/// </returns>
		private static int GetGlInternalFormat(PixelLayout type, GraphicsCapabilities caps)
		{
			switch (type) {

				#region RGB/BGR Formats

				case PixelLayout.RGB8:
				case PixelLayout.BGR8:
					return (Gl.RGB);
				case PixelLayout.RGB15:
				case PixelLayout.BGR15:
					return (Gl.RGB5);
				case PixelLayout.RGB16:
				case PixelLayout.BGR16:
					return (Gl.RGB);
				case PixelLayout.RGB24:
				case PixelLayout.BGR24:
					return (Gl.RGB8);
				case PixelLayout.RGB48:
				case PixelLayout.BGR48:
					return (Gl.RGB16);
				case PixelLayout.RGBF:
				case PixelLayout.RGBD:
				case PixelLayout.BGRF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.RGB32F);
					else
						return (Gl.RGB);
				case PixelLayout.RGBHF:
				case PixelLayout.BGRHF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.RGB16F);
					else
						return (Gl.RGB);

				#endregion

				#region sRGB Formats

				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
					return (Gl.SRGB8);

				#endregion

				#region RGBA/BGRA Formats

				case PixelLayout.RGB30A2:
				case PixelLayout.BGR30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.BGRA32:
					return (Gl.RGBA);
				case PixelLayout.RGBA64:
				case PixelLayout.BGRA64:
					return (Gl.RGBA16);
				case PixelLayout.RGBAF:
				case PixelLayout.BGRAF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.RGBA32F);
					else
						return (Gl.RGBA);
				case PixelLayout.RGBAHF:
				case PixelLayout.BGRAHF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.RGBA16F);
					else
						return (Gl.RGBA);

				#endregion

				#region GRAY Internal Formats

				case PixelLayout.GRAY8:
					return (Gl.R8);
				case PixelLayout.GRAY16:
					return (Gl.R16);
				case PixelLayout.GRAYF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.R32F);
					else
						return (Gl.RED);
				case PixelLayout.GRAYHF:
					if (caps.GlExtensions.TextureFloat_ARB == true)
						return (Gl.R16F);
					else
						return (Gl.RED);

				#endregion

				#region GRAYA Formats

				case PixelLayout.GRAYAF:
					return (Gl.RG32F);

				#endregion

				#region Depth Formats

				case PixelLayout.Depth16:
					return (Gl.DEPTH_COMPONENT16);
				case PixelLayout.Depth24:
					return (Gl.DEPTH_COMPONENT24);
				case PixelLayout.Depth32:
					return (Gl.DEPTH_COMPONENT32);
				case PixelLayout.DepthF:
					return (Gl.DEPTH_COMPONENT32F);

				#endregion

				#region Depth/Stencil Formats

				case PixelLayout.Depth24Stencil8:
					return (Gl.DEPTH24_STENCIL8);
				case PixelLayout.Depth32FStencil8:
					return (Gl.DEPTH32F_STENCIL8);

				#endregion

				#region Integer Formats

				case PixelLayout.Integer1:
					return (Gl.R32I);
				case PixelLayout.Integer2:
					return (Gl.RG32I);
				case PixelLayout.Integer3:
					return (Gl.RGB32I);
				case PixelLayout.Integer4:
					return (Gl.RGBA32I);
				case PixelLayout.UInteger1:
					return (Gl.R32UI);
				case PixelLayout.UInteger2:
					return (Gl.RG32UI);
				case PixelLayout.UInteger3:
					return (Gl.RGB32UI);
				case PixelLayout.UInteger4:
					return (Gl.RGBA32UI);

				#endregion

				default:
					throw new Exception(String.Format("unsupported pixel internal format {0}", type));
			}
		}

		/// <summary>
		/// Determine the OpenGL format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel format.
		/// </returns>
		public static PixelFormat GetGlFormat(PixelLayout type)
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

				case PixelLayout.RGB30A2:
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

				case PixelLayout.BGR30A2:           // Uses Gl.UNSIGNED_INT_2_10_10_10_REV as data type
					return (PixelFormat.Rgba);
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
					return (PixelFormat.Bgra);

				#endregion

				#region GRAY

				case PixelLayout.GRAY8:
				case PixelLayout.GRAY16:
				case PixelLayout.GRAYF:
				case PixelLayout.GRAYHF:
					return (PixelFormat.Red);

				#endregion

				#region GRAYA Formats

				case PixelLayout.GRAYAF:
					return (PixelFormat.Rg);

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
		/// Determine the OpenGL data format corresponding to a <see cref="PixelLayout"/>.
		/// </summary>
		/// <param name="type">
		/// A <see cref="PixelLayout"/> to determine the OpenGL data format.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel data format.
		/// </returns>
		public static PixelType GetPixelType(PixelLayout type)
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

				case PixelLayout.RGB30A2:
					return (PixelType.UnsignedInt1010102);
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

				case PixelLayout.BGR30A2:
					return (PixelType.UnsignedInt2101010Rev);
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

				case PixelLayout.GRAY8:
					return (PixelType.UnsignedByte);
				case PixelLayout.GRAY16:
					return (PixelType.UnsignedShort);
				case PixelLayout.GRAYF:
					return (PixelType.Float);
				case PixelLayout.GRAYHF:
					return (PixelType.HalfFloat);

				#endregion

				#region GRAYA Data Types

				case PixelLayout.GRAYAF:
					return (PixelType.Float);

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
		/// It returns a <see cref="System.Int32"/> corresponding to the OpenGL enumeration value
		/// for the pixel/textel data format.
		/// </returns>
		public static int GetPixelTypeCore(PixelLayout type)
		{
			return ((int)GetPixelType(type));
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a unsigned integer (normalized) pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlUnsignedPixel(PixelLayout type)
		{
			return ((IsGlFloatPixel(type) == false) && (IsGlIntegerPixel(type) == false));
		}

		/// <summary>
		/// Determine whether a PixelLayout represents a (single/double/half precision) floating-point pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlFloatPixel(PixelLayout type)
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
				case PixelLayout.GRAYF:
				case PixelLayout.GRAYHF:
				case PixelLayout.GRAYAF:
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
		public static bool IsGlIntegerPixel(PixelLayout type) { return (GetPixelFormat(type).ColorSpace == PixelSpace.Integer); }

		/// <summary>
		/// Determine whether a PixelLayout represents an integral pixel.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsGlSignedIntegerPixel(PixelLayout type)
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
		public static bool IsGlUnsignedIntegerPixel(PixelLayout type)
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