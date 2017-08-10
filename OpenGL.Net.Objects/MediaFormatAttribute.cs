
// Copyright (C) 2012-2017 Luca Piccioni
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
