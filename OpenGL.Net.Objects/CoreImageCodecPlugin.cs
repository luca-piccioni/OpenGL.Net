
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OpenGL.Objects
{
	/// <summary>
	/// Basic <see cref="IImageCodecPlugin"/> implementation based on actual .NET framework implementation.
	/// </summary>
	public class CoreImagingImageCodecPlugin : IImageCodecPlugin
	{
		#region OpenGL Interoperability

		static void ConvertImageFormat(System.Drawing.Imaging.ImageFormat from, out string to)
		{
			if (from.Guid == System.Drawing.Imaging.ImageFormat.Bmp.Guid) {
				to = ImageFormat.Bitmap;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid) {
				to = ImageFormat.Jpeg;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid) {
				to = ImageFormat.Png;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Exif.Guid) {
				to = ImageFormat.Exif;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Tiff.Guid) {
				to = ImageFormat.Tiff;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid) {
				to = ImageFormat.Gif;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Icon.Guid) {
				to = ImageFormat.Ico;
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Emf.Guid) {
				throw new ArgumentException(String.Format("not supported image format {0}", from));
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.MemoryBmp.Guid) {
				throw new ArgumentException(String.Format("not supported image format {0}", from));
			} else if (from.Guid == System.Drawing.Imaging.ImageFormat.Wmf.Guid) {
				throw new ArgumentException(String.Format("not supported image format {0}", from));
			} else
				throw new ArgumentException(String.Format("not supported image format {0}", from));
		}

		static void ConvertImageFormat(string from, out System.Drawing.Imaging.ImageFormat to)
		{
			switch (from) {
				case ImageFormat.Bitmap:
					to = System.Drawing.Imaging.ImageFormat.Bmp;
					break;
				case ImageFormat.Jpeg:
					to = System.Drawing.Imaging.ImageFormat.Jpeg;
					break;
				case ImageFormat.Png:
					to = System.Drawing.Imaging.ImageFormat.Png;
					break;
				case ImageFormat.Exif:
					to = System.Drawing.Imaging.ImageFormat.Exif;
					break;
				case ImageFormat.Tiff:
					to = System.Drawing.Imaging.ImageFormat.Tiff;
					break;
				case ImageFormat.Gif:
					to = System.Drawing.Imaging.ImageFormat.Gif;
					break;
				case ImageFormat.Ico:
					to = System.Drawing.Imaging.ImageFormat.Icon;
					break;
				default:
					throw new NotSupportedException(String.Format("{0} is not supported image format", from));
			}
		}

		static void ConvertPixelFormat(System.Drawing.Bitmap bitmap, out PixelLayout to)
		{
			System.Drawing.Imaging.PixelFormat from = bitmap.PixelFormat;
			int flags = bitmap.Flags;

			bool sRGB = false;

#if false
			foreach (System.Drawing.Imaging.PropertyItem exifProperty in bitmap.PropertyItems) {
				switch (exifProperty.Id) {
					case ImageCodecPlugin.ExifTagColorSpace:
						ImageCodecPlugin.ExifColorSpace value = (ImageCodecPlugin.ExifColorSpace)BitConverter.ToUInt16(exifProperty.Value, 0);

						switch (value) {
							case ImageCodecPlugin.ExifColorSpace.sRGB:
								sRGB = true;
								break;
							default:
								break;
						}
						break;
					case ImageCodecPlugin.ExifTagGamma:
						UInt32 a1 = BitConverter.ToUInt32(exifProperty.Value, 0);
						UInt32 a2 = BitConverter.ToUInt32(exifProperty.Value, 4);
						Double gamma = (Double)a1 / (Double)a2;


						break;
				}
			}

#endif

			if        ((flags & (int)ImageFlags.ColorSpaceRgb) != 0) {
				ConvertPixelFormatRgb(from, out to, sRGB);
			} else if ((flags & (int)ImageFlags.ColorSpaceGray) != 0) {
				switch (from) {
					case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
					case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
					case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
						to = PixelLayout.R8;
						break;
					case System.Drawing.Imaging.PixelFormat.Format16bppGrayScale:
						to = PixelLayout.R16;
						break;
					case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
						to = PixelLayout.BGRA32;
						break;
					default:
						throw new ArgumentException(String.Format("GRAY pixel format {0} not supported", from));
				}
				
			} else if ((flags & (int)ImageFlags.ColorSpaceYcck) != 0) {
				throw new ArgumentException(String.Format("YCCK pixel format {0} not supported", from));
			} else if ((flags & (int)ImageFlags.ColorSpaceYcbcr) != 0) {
				ConvertPixelFormatRgb(from, out to, sRGB);
			} else if ((flags & (int)ImageFlags.ColorSpaceCmyk) != 0) {
				throw new ArgumentException(String.Format("CMYK pixel format {0} not supported", from));
			} else {
				ConvertPixelFormatNoFlags(from, out to, sRGB);
			}
		}

		private static void ConvertPixelFormatNoFlags(System.Drawing.Imaging.PixelFormat from, out PixelLayout to, bool sRGB)
		{
			switch (from) {
				case System.Drawing.Imaging.PixelFormat.Format16bppRgb555:
					to = PixelLayout.BGR15;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppRgb565:
					to = PixelLayout.BGR16;
					break;
				case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
					to = sRGB ? PixelLayout.SBGR24 : PixelLayout.BGR24;
					break;
				case System.Drawing.Imaging.PixelFormat.Format32bppRgb:
					to = PixelLayout.BGRA32;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppArgb1555:
					to = PixelLayout.BGR15;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppGrayScale:
					to = PixelLayout.R16;
					break;
				case System.Drawing.Imaging.PixelFormat.Format48bppRgb:
					to = PixelLayout.BGR48;
					break;
				case System.Drawing.Imaging.PixelFormat.Format64bppPArgb:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
				case System.Drawing.Imaging.PixelFormat.Canonical:
					to = (sRGB) ? PixelLayout.SBGR24 : PixelLayout.BGR24;
					break;
				case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
					to = PixelLayout.BGRA32;
					break;
				case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
				default:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
			}
		}

		private static void ConvertPixelFormatRgb(System.Drawing.Imaging.PixelFormat from, out PixelLayout to, bool sRGB)
		{
			switch (from) {
				case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
				case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
				case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
					to = PixelLayout.BGR24;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppRgb555:
					to = PixelLayout.BGR15;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppRgb565:
					to = PixelLayout.BGR16;
					break;
				case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
					to = sRGB ? PixelLayout.SBGR24 : PixelLayout.BGR24;
					break;
				case System.Drawing.Imaging.PixelFormat.Format32bppRgb:
					to = PixelLayout.BGRA32;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppArgb1555:
					to = PixelLayout.BGR15;
					break;
				case System.Drawing.Imaging.PixelFormat.Format16bppGrayScale:
					to = PixelLayout.R16;
					break;
				case System.Drawing.Imaging.PixelFormat.Format48bppRgb:
					to = PixelLayout.BGR48;
					break;
				case System.Drawing.Imaging.PixelFormat.Format64bppPArgb:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
				case System.Drawing.Imaging.PixelFormat.Canonical:
					to = (sRGB) ? PixelLayout.SBGR24 : PixelLayout.BGR24;
					break;
				case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
					to = PixelLayout.BGRA32;
					break;
				case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
				default:
					throw new ArgumentException(String.Format("RGB pixel format {0} not supported", from));
			}
		}

		static void ConvertPixelFormat(PixelLayout from, out System.Drawing.Imaging.PixelFormat to, out int flags)
		{
			switch (from) {
				case PixelLayout.R8:
					to = System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
					flags = (int)ImageFlags.ColorSpaceGray;
					break;
				case PixelLayout.R16:
					to = System.Drawing.Imaging.PixelFormat.Format16bppGrayScale;
					flags = (int)ImageFlags.ColorSpaceGray;
					break;
				case PixelLayout.BGR15:
					to = System.Drawing.Imaging.PixelFormat.Format16bppRgb555;
					flags = (int)ImageFlags.ColorSpaceRgb;
					break;
				case PixelLayout.BGR16:
					to = System.Drawing.Imaging.PixelFormat.Format16bppRgb565;
					flags = (int)ImageFlags.ColorSpaceRgb;
					break;
				case PixelLayout.BGR24:
					to = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
					flags = (int)ImageFlags.ColorSpaceRgb;
					break;
				case PixelLayout.BGRA32:
					to = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
					flags = (int)ImageFlags.ColorSpaceRgb;
					break;
				default:
					throw new ArgumentException(String.Format("pixel format {0} not supported", from));
			}
		}

		#endregion

		#region IImageCodecPlugin Implementation

		/// <summary>
		/// Plugin name.
		/// </summary>
		public string Name { get { return ("CoreImaging"); } }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current
		/// process.
		/// </returns>
		public bool CheckAvailability()
		{
			// This plugin is always available
			return (true);
		}

		/// <summary>
		/// Gets the list of media formats supported for reading.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can read.
		/// </value>
		public IEnumerable<string> SupportedReadFormats
		{
			get
			{
				List<string> supportedFormats = new List<string>();

				foreach (ImageCodecInfo decoder in ImageCodecInfo.GetImageDecoders()) {
					if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Bmp.Guid)
						supportedFormats.Add(ImageFormat.Bitmap);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid)
						supportedFormats.Add(ImageFormat.Jpeg);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Icon.Guid)
						supportedFormats.Add(ImageFormat.Ico);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Png.Guid)
						supportedFormats.Add(ImageFormat.Png);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Tiff.Guid)
						supportedFormats.Add(ImageFormat.Tiff);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Gif.Guid)
						supportedFormats.Add(ImageFormat.Gif);
					else if (decoder.FormatID == System.Drawing.Imaging.ImageFormat.Exif.Guid)
						supportedFormats.Add(ImageFormat.Exif);
				}

				return (supportedFormats);
			}
		}

		/// <summary>
		/// Check whether an media format is supported for reading.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to test for read support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public bool IsReadSupported(string format)
		{
			System.Drawing.Imaging.ImageFormat imagingFormat;

			try {
				ConvertImageFormat(format, out imagingFormat);
			} catch (NotSupportedException) {
				return (false);
			}

			int formatIndex = Array.FindIndex(ImageCodecInfo.GetImageDecoders(), 0, delegate(ImageCodecInfo item) {
				return (item.FormatID == imagingFormat.Guid);
			});

			return (formatIndex >= 0);
		}

		/// <summary>
		/// Gets the list of media formats supported for writing.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can write.
		/// </value>
		public IEnumerable<string> SupportedWriteFormats
		{
			get
			{
				List<string> supportedFormats = new List<string>();

				foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders()) {
					if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Bmp.Guid)
						supportedFormats.Add(ImageFormat.Bitmap);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid)
						supportedFormats.Add(ImageFormat.Jpeg);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Icon.Guid)
						supportedFormats.Add(ImageFormat.Ico);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Png.Guid)
						supportedFormats.Add(ImageFormat.Png);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Tiff.Guid)
						supportedFormats.Add(ImageFormat.Tiff);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Gif.Guid)
						supportedFormats.Add(ImageFormat.Gif);
					else if (encoder.FormatID == System.Drawing.Imaging.ImageFormat.Exif.Guid)
						supportedFormats.Add(ImageFormat.Exif);
				}

				return (supportedFormats);
			}
		}

		/// <summary>
		/// Check whether an media format is supported for writing.
		/// </summary>
		/// <param name="format">
		/// An <see cref="String"/> that specify the media format to test for write support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public bool IsWriteSupported(string format)
		{
			System.Drawing.Imaging.ImageFormat imagingFormat;

			try {
				ConvertImageFormat(format, out imagingFormat);
			} catch (NotSupportedException) {
				return (false);
			}

			int formatIndex = Array.FindIndex(ImageCodecInfo.GetImageEncoders(), 0, delegate(ImageCodecInfo item) {
				return (item.FormatID == imagingFormat.Guid);
			});

			return (formatIndex >= 0);
		}

		/// <summary>
		/// Determine the plugin priority for a certain image format.
		/// </summary>
		/// <param name="format">
		/// An <see cref="ImageFormat"/> specifying the image format to test for priority.
		/// </param>
		/// <returns>
		/// It returns an integer value indicating the priority of this implementation respect other ones supporting the same
		/// image format. Conventionally, a value of 0 indicates a totally impartial plugin implementation; a value less than 0 indicates
		/// a more confident implementation respect other plugins; a value greater than 0 indicates a fallback implementation respect other
		/// plugins.
		/// 
		/// This implementation of this routine returns -1. The reasoning is that this plugin implementation is very slow in Query and Load, due
		/// the .NET abstraction. However, it is a very usefull fallback plugin since it can open the most of common image formats.
		/// </returns>
		public int GetPriority(string format)
		{
			switch (format) {
				default:
					return (-1);
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <see cref="ImageInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public ImageInfo QueryInfo(string path, ImageCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (QueryInfo(fs, criteria));
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <see cref="ImageInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public ImageInfo QueryInfo(Stream stream, ImageCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			ImageInfo info = new ImageInfo();
			
			using (Bitmap iBitmap = new Bitmap(stream)) {
				PixelLayout iBitmapPixelType;
				string containerFormat;

				ConvertImageFormat(iBitmap.RawFormat, out containerFormat);
				ConvertPixelFormat(iBitmap, out iBitmapPixelType);

				info.ContainerFormat = containerFormat;
				info.PixelType = iBitmapPixelType;
				info.Width = (uint)iBitmap.Width;
				info.Height = (uint)iBitmap.Height;
			}

			return (info);
		}

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <see cref="Image"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public Image Load(string path, ImageCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (Load(fs, criteria));
			}
		}

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <see cref="Image"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public Image Load(Stream stream, ImageCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			using (System.Drawing.Bitmap iBitmap = new System.Drawing.Bitmap(stream)) {
				Image image;
				PixelLayout pType, pConvType;

				// Allocate image raster
				ConvertPixelFormat(iBitmap, out pType);

				// Check for hardware/software support
				if (pType.IsSupportedInternalFormat() == false) {
					if (criteria.IsSet(ImageCodecCriteria.SoftwareSupport) && (bool)criteria[ImageCodecCriteria.SoftwareSupport]) {
						// Pixel type not directly supported by hardware... try to guess suitable software conversion
						throw new NotImplementedException("pixel type " + pType.ToString() + " is not supported by hardware neither software");
					} else
						throw new InvalidOperationException("pixel type " + pType.ToString() + " is not supported by hardware");
				} else
					pConvType = pType;

				image = new Image();
				image.Create(pType, (uint)iBitmap.Width, (uint)iBitmap.Height);

				switch (iBitmap.PixelFormat) {
					case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
					case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
					case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
						if (Khronos.Platform.RunningMono) {
							// Bug 676362 - Bitmap Clone does not format return image to requested PixelFormat
							// https://bugzilla.novell.com/show_bug.cgi?id=676362
							//
							// ATM no mono version has resolved the bug; current workaround is performing image
							// sampling pixel by pixel, using internal conversion routines, even if it is very slow
						
							LoadBitmapByPixel(iBitmap, image);
						} else
							LoadBitmapByClone(iBitmap, image);
						break;
					default:
						LoadBitmapByLockBits(iBitmap, image);
						break;
				}
				
				return (image);
			}
		}

		/// <summary>
		/// Internal method for creating Image from Bitmap.
		/// </summary>
		/// <param name="bitmap">
		/// A <see cref="Drawing.Bitmap"/> to be converted into an <see cref="Image"/> instance.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify image conversion criteria.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Image"/> instance that's equivalent to <paramref name="bitmap"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bitmap"/> or <see cref="criteria"/> is null.
		/// </exception>
		internal static Image LoadFromBitmap(Bitmap bitmap, ImageCodecCriteria criteria)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			PixelLayout pType, pConvType;

			// Allocate image raster
			ConvertPixelFormat(bitmap, out pType);

			// Check for hardware/software support
			if (pType.IsSupportedInternalFormat() == false) {
				if (criteria.IsSet(ImageCodecCriteria.SoftwareSupport) && ((bool)criteria[ImageCodecCriteria.SoftwareSupport])) {
					// Pixel type not directly supported by hardware... try to guess suitable software conversion
					throw new NotImplementedException(String.Format("pixel type {0} is not supported by hardware neither software", pType));
				} else
					throw new InvalidOperationException(String.Format("pixel type {0} is not supported by hardware", pType));
			} else
				pConvType = pType;

			Image image = new Image(pType, (uint)bitmap.Width, (uint)bitmap.Height);

			switch (bitmap.PixelFormat) {
				case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
				case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
				case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
					if (Khronos.Platform.RunningMono) {
						// Bug 676362 - Bitmap Clone does not format return image to requested PixelFormat
						// https://bugzilla.novell.com/show_bug.cgi?id=676362
						//
						// ATM no mono version has resolved the bug; current workaround is performing image
						// sampling pixel by pixel, using internal conversion routines, even if it is very slow
						
						LoadBitmapByPixel(bitmap, image);
					} else
						LoadBitmapByClone(bitmap, image);
					break;
				default:
					LoadBitmapByLockBits(bitmap, image);
					break;
			}
			
			return (image);
		}

		/// <summary>
		/// Loads the bitmap by locking its bits.
		/// </summary>
		/// <param name="bitmap">
		/// A <see cref="Drawing.Bitmap"/> to be converted into an <see cref="Image"/> instance.
		/// </param>
		/// <param name='image'>
		/// A <see cref="Image"/> instance that will store <paramref name="bitmap"/> data.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bitmap"/> or <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="image"/> line stride is greater than <paramref name="bitmap"/> line
		/// stride. This never happens if <paramref name="image"/> is dimensionally compatible with <paramref name="bitmap"/>.
		/// </exception>
		private static void LoadBitmapByLockBits(Bitmap bitmap, Image image)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");
			if (image == null)
				throw new ArgumentNullException("image");

			System.Drawing.Imaging.BitmapData iBitmapData = null;
			IntPtr imageData = image.ImageBuffer;

			try {
				// Obtain source and destination data pointers
				iBitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);

				// Copy Bitmap data dst Image
				unsafe {
					byte* hImageDataPtr = (byte*)imageData.ToPointer();
					byte* iBitmapDataPtr = (byte*)iBitmapData.Scan0.ToPointer();
					uint hImageDataStride = image.Stride;
					uint iBitmapDataStride = (uint)iBitmapData.Stride;
					
					if (hImageDataStride > iBitmapDataStride)
						throw new InvalidOperationException("invalid bitmap stride");

					// .NET Image library stores bitmap scan line data in memory padded dst 4 bytes boundaries
					// .NET Image Library present a bottom up image, so invert the scan line order

					iBitmapDataPtr = iBitmapDataPtr + ((image.Height-1) * iBitmapDataStride);

					for (uint line = 0; line < image.Height; line++, hImageDataPtr += hImageDataStride, iBitmapDataPtr -= iBitmapDataStride)
						Memory.Copy(hImageDataPtr, iBitmapDataPtr, hImageDataStride);
				}
			} finally {
				if (iBitmapData != null)
					bitmap.UnlockBits(iBitmapData);
			}
		}
		
		/// <summary>
		/// Loads the bitmap by cloning its data to a more compatible format.
		/// </summary>
		/// <param name="bitmap">
		/// A <see cref="Drawing.Bitmap"/> to be converted into an <see cref="Image"/> instance.
		/// </param>
		/// <param name='image'>
		/// A <see cref="Image"/> instance that will store <paramref name="bitmap"/> data.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bitmap"/> or <paramref name="image"/> is null.
		/// </exception>
		/// <remarks>
		/// <para>
		/// Cloning <paramref name="bitmap"/> is useful whenever the bitmap have a pixel format not directly portable
		/// to any well-known format (i.e. 1 bit pixel, palettized pixel, etc.).
		/// </para>
		/// <para>
		/// This method is very memory consuming, because cloning cause to use additionally memory.
		/// </para>
		/// </remarks>
		private static void LoadBitmapByPixel(Bitmap bitmap, Image image)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");
			if (image == null)
				throw new ArgumentNullException("image");

			// FIXME Maybe this method is no more necessary
			throw new NotImplementedException();

#if false
			for (uint y = 0; y < image.Height; y++) {
				for (uint x = 0; x < image.Width; x++) {
					System.Drawing.Color bitmapColor = bitmap.GetPixel((int)x, (int)y);
					
					//image[x, y] = Pixel.GetNativeIColor(new ColorRGBA32(bitmapColor.R, bitmapColor.G, bitmapColor.B, bitmapColor.A), image.PixelLayout);
					//image[x, y] = new ColorBGR24(bitmapColor.R, bitmapColor.G, bitmapColor.B);
				}
			}
#endif
		}

		/// <summary>
		/// Loads the bitmap by cloning its data to a more compatible format.
		/// </summary>
		/// <param name="bitmap">
		/// A <see cref="Drawing.Bitmap"/> to be converted into an <see cref="Image"/> instance.
		/// </param>
		/// <param name='image'>
		/// A <see cref="Image"/> instance that will store <paramref name="bitmap"/> data.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bitmap"/> or <paramref name="image"/> is null.
		/// </exception>
		/// <remarks>
		/// <para>
		/// Cloning <paramref name="bitmap"/> is useful whenever the bitmap have a pixel format not directly portable
		/// to any well-known format (i.e. 1 bit pixel, palettized pixel, etc.).
		/// </para>
		/// <para>
		/// This method is very memory consuming, because cloning cause to use additionally memory.
		/// </para>
		/// </remarks>
		private static void LoadBitmapByClone(Bitmap bitmap, Image image)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");
			if (image == null)
				throw new ArgumentNullException("image");

			System.Drawing.Imaging.PixelFormat iBitmapFormat;
			int iBitmapFlags;

			// Determine the clone bitmap pixel format
			ConvertPixelFormat(image.PixelLayout, out iBitmapFormat, out iBitmapFlags);
			// Clone image converting the pixel format
			using (System.Drawing.Bitmap clonedBitmap = bitmap.Clone(new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height), iBitmapFormat)) {
				LoadBitmapByLockBits(clonedBitmap, image);
			}
		}

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="image">
		/// A <see cref="Image"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="image"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="image"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public void Save(string path, Image image, string format, ImageCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write)) {
				Save(fs, image, format, criteria);
			}
		}

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="IO.Stream"/> which stores the media data.
		/// </param>
		/// <param name="image">
		/// A <see cref="Image"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="image"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="image"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public void Save(Stream stream, Image image, string format, ImageCodecCriteria criteria)
		{
			System.Drawing.Imaging.ImageFormat bitmapFormat;
			System.Drawing.Imaging.PixelFormat bitmapPixelFormat;
			int iBitmapFlags;

			ConvertImageFormat(format, out bitmapFormat);
			ConvertPixelFormat(image.PixelLayout, out bitmapPixelFormat, out iBitmapFlags);

			// Obtain source and destination data pointers
			using (Bitmap bitmap = new Bitmap((int)image.Width, (int)image.Height, bitmapPixelFormat)) {

				#region Copy Image To Bitmap

				BitmapData iBitmapData = null;
				IntPtr imageData = image.ImageBuffer;

				try {
					iBitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

					// Copy Image data dst Bitmap
					unsafe {
						byte* hImageDataPtr = (byte*)imageData.ToPointer();
						byte* iBitmapDataPtr = (byte*)iBitmapData.Scan0.ToPointer();
						uint hImageDataStride = image.Stride;
						uint iBitmapDataStride = (uint)iBitmapData.Stride;
						
						// .NET Image Library stores bitmap scan line data in memory padded dst 4 bytes boundaries
						// .NET Image Library expect a bottom up image, so invert the scan line order

						iBitmapDataPtr = iBitmapDataPtr + ((image.Height-1) * iBitmapDataStride);

						for (uint line = 0; line < image.Height; line++, hImageDataPtr += hImageDataStride, iBitmapDataPtr -= iBitmapDataStride)
							Memory.Copy(iBitmapDataPtr, hImageDataPtr, hImageDataStride);
					}
				} finally {
					if (iBitmapData != null)
						bitmap.UnlockBits(iBitmapData);
				}

				#endregion

				#region Support Indexed Pixel Formats

				if ((iBitmapFlags & (int)ImageFlags.ColorSpaceGray) != 0) {
					ColorPalette bitmapPalette = bitmap.Palette;

					switch (bitmapPixelFormat) {
						case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
							// Create grayscale palette
							for (int i = 0; i <= 255; i++)
								bitmapPalette.Entries[i] = Color.FromArgb(i, i, i);
							break;
					}

					bitmap.Palette = bitmapPalette;
				}

				#endregion

				// Save image with the specified format
				ImageCodecInfo encoderInfo = Array.Find(ImageCodecInfo.GetImageEncoders(), delegate(ImageCodecInfo item) {
					return (item.FormatID == bitmapFormat.Guid);
				});

				EncoderParameters encoderParams = null;

				try {
					EncoderParameters encoderInfoParamList = bitmap.GetEncoderParameterList(encoderInfo.Clsid);
					EncoderParameter[] encoderInfoParams = encoderInfoParamList != null ? encoderInfoParamList.Param : null;
					bool supportQuality = false;
					int paramsCount = 0;

					if (encoderInfoParams != null) {
						Array.ForEach(encoderInfoParams, delegate(EncoderParameter item) {
							if (item.Encoder.Guid == Encoder.Quality.Guid) {
								supportQuality = true;
								paramsCount++;
							}
						});
					}

					encoderParams = new EncoderParameters(paramsCount);

					paramsCount = 0;
					if (supportQuality)
						encoderParams.Param[paramsCount++] = new EncoderParameter(Encoder.Quality, 100);
				} catch (Exception) {
					// Encoder does not support parameters
				}

				bitmap.Save(stream, encoderInfo, encoderParams);
			}
		}

		#endregion
	}
}
