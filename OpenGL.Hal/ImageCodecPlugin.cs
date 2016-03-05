
// Copyright (C) 2016 Luca Piccioni
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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OpenGL
{
	/// <summary>
	/// 
	/// </summary>
	class ImageCodecPlugin : MediaCodecPlugin<Image, ImageInfo, ImageCodecCriteria>, IImageCodecPlugin
	{
		#region Constructors

		public ImageCodecPlugin(string assemblyPath) :
			base(assemblyPath, "CreateImageCodecPluginFactory")
		{
			// Get plugin callbacks
			Delegate createFactoryDelegate = CreatePluginFactoryDelegate<CreateFactoryDelegate>();
			_PluginDelegates = (Delegates)createFactoryDelegate.Method.Invoke(null, null);;
			_PluginHandle = _PluginDelegates.PluginDelegates.Create();		/// XXX IDisposable
		}

		#endregion

		#region P/Invoke On Plugin

		/// <summary>
		/// Delegate used for creating plaugin factory.
		/// </summary>
		/// <returns></returns>
		private delegate Delegates CreateFactoryDelegate();

		/// <summary>
		/// 
		/// </summary>
		private CreateFactoryDelegate _CreateFactory;

		/// <summary>
		/// The actual plugin implementation.
		/// </summary>
		private Delegates _PluginDelegates;

		/// <summary>
		/// The plugin handle.
		/// </summary>
		private IntPtr _PluginHandle;

		#endregion

		#region MediaCodecPlugin<Image, ImageInfo, ImageCodecCriteria> Overrides

		/// <summary>
		/// Plugin name.
		/// </summary>
		public override string Name { get { return (_PluginDelegates.PluginDelegates.GetName(IntPtr.Zero)); } }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current
		/// process.
		/// </returns>
		public override bool CheckAvailability()
		{
			return (true);
		}

		/// <summary>
		/// Gets the list of media formats supported for reading.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can read.
		/// </value>
		public override IEnumerable<string> SupportedReadFormats
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
		public override bool IsReadSupported(string format)
		{
			return (false);
		}

		/// <summary>
		/// Gets the list of media formats supported for writing.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can write.
		/// </value>
		public override IEnumerable<string> SupportedWriteFormats
		{
			get
			{
				List<string> supportedFormats = new List<string>();

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
		public override bool IsWriteSupported(string format)
		{
			return (false);
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
		public override int GetPriority(string format)
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
		public override ImageInfo QueryInfo(string path, ImageCodecCriteria criteria)
		{
			return (null);
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
		public override ImageInfo QueryInfo(Stream stream, ImageCodecCriteria criteria)
		{
			return (null);
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
		public override Image Load(string path, ImageCodecCriteria criteria)
		{
			return (null);
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
		public override Image Load(Stream stream, ImageCodecCriteria criteria)
		{
			return (null);
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
		public override void Save(string path, Image image, string format, ImageCodecCriteria criteria)
		{
			
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
		public override void Save(Stream stream, Image image, string format, ImageCodecCriteria criteria)
		{
			
		}

		#endregion
	}
}
