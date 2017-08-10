
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
using System.Drawing;

namespace OpenGL.Objects
{
	/// <summary>
	/// Image codec criteria.
	/// </summary>
	public class ImageCodecCriteria : MediaCodecCriteria
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ImageCodecCriteria()
		{
			// Good compromize between quality and size
			this[QualityPreset] = 0.75f;
			// Uses software support: wider pixel format support
			this[SoftwareSupport] = true;
			// By default, all area
			this[_ImageSection] = new Nullable<Rectangle>();
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ImageCodecCriteria(Rectangle section) : this()
		{
			// Specific area
			this[_ImageSection] = new Nullable<Rectangle>(section);
		}

		#endregion

		#region ImageCodecCriteria Value Names

		/// <summary>
		/// Floating-point value used by selected plugins to determine some generic quality preset.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The plugin can ignore the quality setting specified. The value is normalized in the range [0.0, 1.0], where 1.0 means the
		/// highest quality. Usually this preset shall not reduce fundamental image parameters, such as image extents or pixel precision.
		/// </para>
		/// </remarks>
		public static readonly string QualityPreset = "QualityPreset";

		/// <summary>
		/// Boolean value used by selected plugin to determine whether to convert image in order to support hardware formats.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The plugin will check whether the native pixel format is available on current hardware. In the case hardware is not capable
		/// to represent the image and this criteria is set to false, then the plugin refuse to load the image. Otherwise, it try to
		/// convert the image pixel format in order to have a pixel format compatible with the hardware.
		/// </para>
		/// </remarks>
		public static readonly string SoftwareSupport = "SoftwareSupport";

		#region Image Section

		/// <summary>
		/// The <see cref="Rectangle"/> that specify the section of the image to load. If it is not defined or it is
		/// null, the entire image area is considered.
		/// </summary>
		public Rectangle? ImageSection
		{
			get { return (Get<Rectangle?>(_ImageSection)); }
			set { this[_ImageSection] = value; }
		}

		/// <summary>
		/// The <see cref="Rectangle"/> that specify the section of the image to load. If it is not defined or it is
		/// null, the entire image area is considered.
		/// </summary>
		private static readonly string _ImageSection = "ImageSection";

		#endregion

		#endregion
	}
}