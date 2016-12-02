
// Copyright (C) 2011-2016 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Generic image informations.
	/// </summary>
	public class ImageInfo : MediaInfo
	{
		#region Image Tags

		/// <summary>
		/// The media semantic
		/// </summary>
		[MediaInfoTag(typeof(ImageSemantic), DefaultValue = ImageSemantic.Color)]
		public const string TagSemantic = "Semantic";

		/// <summary>
		/// The media semantic
		/// </summary>
		[MediaInfoTag(typeof(string))]
		public const string TagContainerFormat = "ContainerFormat";

		/// <summary>
		/// The device used for acquiring the media.
		/// </summary>
		[MediaInfoTag(typeof(IConvertible), DefaultValue = 1.0f)]
		public const string TagGamma = "Gamma";

		#endregion

		#region Image Information

		/// <summary>
		/// The image container format.
		/// </summary>
		public string ContainerFormat
		{
			get { return (GetTag<string>(TagContainerFormat)); }
			set { SetTag(TagContainerFormat, value); }
		}

		/// <summary>
		/// The semantic of the image data.
		/// </summary>
		public ImageSemantic Semantic
		{
			get { return (GetTag<ImageSemantic>(TagSemantic)); }
			set { SetTag(TagSemantic, value); }
		}

		/// <summary>
		/// The image gamma.
		/// </summary>
		public float Gamma
		{
			get { return (GetTag<float>(TagGamma)); }
			set { SetTag(TagGamma, value); }
		}

		#endregion

		/// <summary>
		/// Original image pixel type.
		/// </summary>
		/// <remarks>
		/// This field will be updated by <see cref="Image.MediaInformation"/> automatically.
		/// </remarks>
		public PixelLayout PixelType;

		/// <summary>
		/// Image width (in pixels).
		/// </summary>
		/// <remarks>
		/// This field will be updated by <see cref="Image.MediaInformation"/> automatically.
		/// </remarks>
		public uint Width;

		/// <summary>
		/// Image height (in pixels);
		/// </summary>
		/// <remarks>
		/// This field will be updated by <see cref="Image.MediaInformation"/> automatically.
		/// </remarks>
		public uint Height;
	}
}
