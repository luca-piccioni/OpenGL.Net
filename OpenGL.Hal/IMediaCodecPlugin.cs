
// Copyright (C) 2012-2013 Luca Piccioni
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;

namespace OpenGL
{
	/// <summary>
	/// Generic media codec plugin interface.
	/// </summary>
	/// <typeparam name="TMedia">
	/// A <see cref="IMedia{TMediaInfo}"/> type, indicating the concrete class of the media.
	/// </typeparam>
	/// <typeparam name="TMediaInfo">
	/// A <see cref="MediaInfo"/> that stored information about <typeparamref name="TMedia"/>
	/// </typeparam>
	public interface IMediaCodecPlugin<TMedia, TMediaInfo> : IPlugin where TMedia : IMedia<TMediaInfo> where TMediaInfo : MediaInfo
	{
		#region Managed Stream Codec Implementation

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specifies parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		TMediaInfo QueryInfo(Stream stream, MediaCodecCriteria criteria);

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specifies parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		TMedia Load(Stream stream, MediaCodecCriteria criteria);

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="System.IO.Stream"/> which stores the media data.
		/// </param>
		/// <param name="media">
		/// A <typeparamref name="TMedia"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="System.String"/> that specifies the media format to used for saving <paramref name="media"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specifies parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="media"/> or <paramref name="criteria"/> is null.
		/// </exception>
		void Save(Stream stream, TMedia media, string format, MediaCodecCriteria criteria);

		#endregion

		#region Plugin Support Queries

		/// <summary>
		/// Gets the list of media formats supported for reading.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can read.
		/// </value>
		IEnumerable<string> SupportedReadFormats { get; }

		/// <summary>
		/// Check whether an media format is supported for reading.
		/// </summary>
		/// <param name="format">
		/// An <see cref="System.String"/> that specifies the media format to test for read support.
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		bool IsReadSupported(string format);

		/// <summary>
		/// Gets the list of media formats supported for writing.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can write.
		/// </value>
		IEnumerable<string> SupportedWriteFormats { get; }

		/// <summary>
		/// Check whether an media format is supported for writing.
		/// </summary>
		/// <param name="format">
		/// An <see cref="System.String"/> that specifies the media format to test for write support.
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		bool IsWriteSupported(string format);

		/// <summary>
		/// Determine the plugin priority for a certain image format.
		/// </summary>
		/// <param name="format">
		/// An <see cref="System.String"/> that specifies the media format to test for priority.
		/// </param>
		/// <returns>
		/// It returns an integer value indicating the priority of this implementation respect other ones supporting the same
		/// image format. Conventionally, a value of 0 indicates a totally impartial plugin implementation; a value less than 0 indicates
		/// a more confident implementation respect other plugins; a value greater than 0 indicates a fallback implementation respect other
		/// plugins.
		/// </returns>
		int GetPriority(string format);

		#endregion
	}
}

