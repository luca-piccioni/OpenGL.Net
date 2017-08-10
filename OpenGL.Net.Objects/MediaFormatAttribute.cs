
// Copyright (C) 2012-2017 Luca Piccioni
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
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	/// <summary>
	/// Media format attribute.
	/// </summary>
	/// <remarks>
	/// This attribute is used to describe a media. Actually supported media types are:
	/// - Still images (by means of <see cref="OpenGL.Raster.ImageFormat"/>
	/// - Elementary video streams (by means of <see cref="OpenGL.Video.VideoFormat"/>
	/// - Multimedia streams (by means of <see cref="OpenGL.Video.VideoContainerFormat"/>
	/// </remarks>
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class MediaFormatAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenGL.MediaFormatAttribute"/> class.
		/// </summary>
		/// <param name='shortDescr'>
		/// A <see cref="String"/> that specify the short description of the media.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shortDescr"/> is null.
		/// </exception>
		public MediaFormatAttribute(string shortDescr)
		{
			if (shortDescr == null)
				throw new ArgumentNullException("shortDescr");

			ShortDescription = shortDescr;
		}

		/// <summary>
		/// The media format short description. This field is always defined.
		/// </summary>
		public readonly string ShortDescription;

		/// <summary>
		/// The media long description. This field can be null.
		/// </summary>
		public string LongDescription;

		/// <summary>
		/// A list of file extensions, pipe ('|') separated, usually used for this format. This field can be null.
		/// </summary>
		public string FileExtensions;

		/// <summary>
		/// The media URL pattern regular expression.
		/// </summary>
		public string MediaPattern;

		/// <summary>
		/// Flag indicating whether this format is abstract (not real format, i.e. Unknown).
		/// </summary>
		public bool Abstract;

		/// <summary>
		/// Matchs an URL pattern for this media format.
		/// </summary>
		/// <param name='input'>
		/// A <see cref="String"/> that specify the pattern to match.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="input"/> can match the media format extensions.
		/// </returns>
		public bool MatchPattern(string input)
		{
			// By file extension
			if (FileExtensions != null) {
				string extensions = FileExtensions;

				// Match every extension? Need to escape
				if (extensions.Contains("*"))
					extensions = Regex.Escape(extensions);

				if (Regex.IsMatch(input, String.Format(@".*\.({0})$", extensions), RegexOptions.IgnoreCase))
					return (true);
			}
			// By media pattern
			if (MediaPattern != null) {
				if (Regex.IsMatch(input, MediaPattern))
					return (true);
			}

			// Match everything if not file extensions and media pattern are not defined
			return ((FileExtensions == null) && (MediaPattern == null));
		}
	}
}
