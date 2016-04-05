
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
using System.IO;
using System.Runtime.InteropServices;

using OSGeo.GDAL;

namespace OpenGL
{
	/// <summary>
	/// <see cref="IImageCodecPlugin"/> implementation based on GDAL library.
	/// </summary>
	class GdalImageCodecPlugin : IImageCodecPlugin
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GdalImageCodecPlugin()
		{
			AllRegister();
		}

		internal static void AllRegister()
		{
			if (_AllRegister)
				return;

			try {
				Gdal.AllRegister();
			} catch {
				// Fail-safe: plugin not available
				_GdalAvailable = false;
			}
			_AllRegister = true;
		}

		private static bool _AllRegister;

		#endregion

		#region IImageCodecPlugin Implementation

		/// <summary>
		/// Plugin name.
		/// </summary>
		public string Name { get { return ("GDAL"); } }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current
		/// process.
		/// </returns>
		public bool CheckAvailability()
		{
			// This plugin is available only if GDAL library is found
			return (_GdalAvailable);
		}

		/// <summary>
		/// Flag indicating whether GDAL is available.
		/// </summary>
		private static bool _GdalAvailable = true;

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

				supportedFormats.Add(ImageFormat.Dted);
				supportedFormats.Add(ImageFormat.Smrt);

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
			switch (format) {
				case ImageFormat.Dted:
				case ImageFormat.Smrt:
				case ImageFormat.Vrt:
					return (true);
				default:
					return (false);
			}
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
				return (new List<string>());
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
			ImageInfo info = new ImageInfo();



			return (info);
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
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
			using (Dataset dataset = Gdal.Open(path, Access.GA_ReadOnly)) {
				return (Load(dataset, criteria));
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

			const int BufferBlockSize = 4096;

			byte[] buffer = new byte[stream.Length];
			int bufferOffset = 0, bytesRed;

			// Read the stream content
			while ((bytesRed = stream.Read(buffer, bufferOffset, BufferBlockSize)) > 0)
				bufferOffset += bytesRed;

			GCHandle bufferHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			try {
				Gdal.FileFromMemBuffer("/vsimem/GdalLoad", buffer.Length, bufferHandle.AddrOfPinnedObject());
				using (Dataset dataset = Gdal.Open("/vsimem/GdalLoad", Access.GA_ReadOnly)) {
					return (Load(dataset, criteria));
				}
			} finally {
				// Release virtual path
				Gdal.Unlink("/vsimem/GdalLoad");
				bufferHandle.Free();
			}
		}

		private static Image Load(Dataset dataset, ImageCodecCriteria criteria)
		{
			if (dataset == null)
				throw new ArgumentNullException("dataset");

			ColorInterp[] bandSemantic = new ColorInterp[dataset.RasterCount];

			for (int i = 1; i <= dataset.RasterCount; i++) {
				using (Band band = dataset.GetRasterBand(i)) {
					bandSemantic[i - 1] = band.GetColorInterpretation();
				}
			}

			switch (bandSemantic[0]) {
				case ColorInterp.GCI_GrayIndex:
					return (Load_GrayIndex(dataset, 1, criteria));
				default:
					throw new NotSupportedException();

				// Driver dependent definitions
				case ColorInterp.GCI_Undefined:
					switch (dataset.RasterCount) {
						case 1:
							switch (dataset.GetDriver().ShortName) {
								case "SRTMHGT":
								case "VRT":
									return (Load_GrayIndex(dataset, 1, criteria));
								default:
									throw new NotSupportedException();
							}
						default:
							throw new NotSupportedException();
				}
			}
		}

		internal static Image Load_GrayIndex(Dataset dataset, int bandIndex, ImageCodecCriteria criteria)
		{
			return (Load_GrayIndex(dataset, bandIndex, criteria, null));
		}

		internal static Image Load_GrayIndex(Dataset dataset, int bandIndex, ImageCodecCriteria criteria, Image image)
		{
			using (Band band = dataset.GetRasterBand(bandIndex)) {
				Rectangle? rasterSection = criteria.ImageSection;

				if (rasterSection.HasValue == false)
					rasterSection = new Rectangle(0, 0, band.XSize, band.YSize);

				uint width = (uint)rasterSection.Value.Width, height = (uint)rasterSection.Value.Height;

				if (image == null) {
					switch (band.DataType) {
						case OSGeo.GDAL.DataType.GDT_Byte:
							image = new Image(PixelLayout.R8, width, height);
							break;
						case OSGeo.GDAL.DataType.GDT_Int16:
							image = new Image(PixelLayout.GRAY16S, width, height);
							break;
						case OSGeo.GDAL.DataType.GDT_Float32:
							image = new Image(PixelLayout.RF, width, height);
							break;
						default:
							throw new NotSupportedException();
					}
				}

				try {
					if (rasterSection.Value.Left < 0 || rasterSection.Value.Right >= band.XSize)
						return (null); // throw new ArgumentOutOfRangeException("criteria", "section out of bounds");
					if (rasterSection.Value.Top < 0 || rasterSection.Value.Bottom >= band.YSize)
						return (null); // throw new ArgumentOutOfRangeException("criteria", "section out of bounds");
				} catch {
					return (null);
				}

				// Read raster
				CPLErr err = dataset.ReadRaster(
					rasterSection.Value.X, rasterSection.Value.Y, rasterSection.Value.Width, rasterSection.Value.Height,
					image.ImageBuffer, (int)image.Width, (int)image.Height,
					band.DataType, 1, new int[] { bandIndex }, 0, 0, 0
				);

				// Error handling
				switch (err) {
					case CPLErr.CE_None:
						break;
				}

				return (image);
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
			
		}

		#endregion
	}
}
