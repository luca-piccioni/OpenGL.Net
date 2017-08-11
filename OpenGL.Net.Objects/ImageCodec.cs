
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

using System.IO;

namespace OpenGL.Objects
{
	/// <summary>
	/// Image coder/decoder.
	/// </summary>
	public sealed class ImageCodec : MediaCodec<IImageCodecPlugin, Image, ImageInfo, ImageCodecCriteria>
	{
		#region Constructors

		/// <summary>
		/// The only instance of ImageCodec.
		/// </summary>
		public static readonly ImageCodec Instance = new ImageCodec();

		/// <summary>
		/// This type is a singleton.
		/// </summary>
		private ImageCodec() :
			base(PluginFactoryType, "GLO_IMAGE_CODEC_DIR")
		{
			// Common media description
			ExtractDescriptions(typeof(ImageFormat));
			// Core plugin always registered
#if !MONODROID
			RegisterPlugin(new CoreImagingImageCodecPlugin());
#endif
			// RegisterPlugin(new GdalImageCodecPlugin());
		}

		/// <summary>
		/// The type which following plugin factory conventions.
		/// </summary>
		private const string PluginFactoryType = "OpenGL.ImageCodecFactory";
		
		#endregion

		#region MediaCodec<IImageCodecPlugin, Image, ImageInfo> Overrides

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="format">
		/// The <see cref="String"/> which defines the format of the stream data.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="stream"/> is not readable or seekable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no plugin is available for <paramref name="format"/> (filtered by
		/// <paramref name="criteria"/>) or all plugins are not able to load media from
		/// <paramref name="stream"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if <paramref name="format"/> is not supported by any loaded plugin.
		/// </exception>
		public override Image Load(Stream stream, string format, ImageCodecCriteria criteria)
		{
			// Base implementation
			Image image = base.Load(stream, format, criteria);
			// Fix container format in MediaInformation
			image.MediaInformation.ContainerFormat = format;

			return (image);
		}

		/// <summary>
		/// Creates the default media codec criteria.
		/// </summary>
		/// <returns>
		/// The default media codec criteria.
		/// </returns>
		protected override ImageCodecCriteria CreateDefaultMediaCodecCriteria()
		{
			return (new ImageCodecCriteria());
		}

		#endregion
	}
}
