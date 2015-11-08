
//  Copyright (C) 2013 Luca Piccioni
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Wrapper stream used for specifying a simple URI for certain media sources.
	/// </summary>
	public class MediaStream : Stream
	{
		#region Constructors

		/// <summary>
		/// Construct a MediaStream specifying an URI.
		/// </summary>
		/// <param name="uri">
		/// 
		/// </param>
		/// <param name="streamMode"></param>
		/// <param name="streamAccess"></param>
		public MediaStream(string uri, FileMode streamMode, FileAccess streamAccess)
		{
			const string UriRegex = @"^(?<BaseUri>\w+)://(?<Path>.*)$";

			if (uri == null)
				throw new ArgumentNullException("uri");

			Match uriMatch = Regex.Match(uri, UriRegex);

			if (!uriMatch.Success)
				throw new InvalidOperationException("not recognized URI");

			// Store original URI
			mMediaUri = uri;
			mStreamAccess = streamAccess;
			// Open the stream for special cases
			mMediaUriScheme = uriMatch.Groups["BaseUri"].Value;
			mMediaUriPath = uriMatch.Groups["Path"].Value;

			if (mMediaUriScheme == UriSchemeFile) {
				mBackendStream = new FileStream(mMediaUriPath, streamMode, streamAccess);
			}
		}

		#endregion

		#region URI Scheme Utilities

		/// <summary>
		/// Compose an URI for local file.
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		public static string GetFileScheme(string filePath)
		{
			if (filePath == null)
				throw new ArgumentNullException("filePath");

			return (String.Format("{0}://{1}", UriSchemeFile, filePath));
		}

		/// <summary>
		/// Compose an URI for capture device.
		/// </summary>
		/// <param name="captureDevice">
		/// A <see cref="System.String"/> that specify the video capture device.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.String"/> that follows the URI pattern for the specified
		/// capture device.
		/// </returns>
		public static string GetCaptureScheme(string captureDevice)
		{
			if (captureDevice == null)
				throw new ArgumentNullException("captureDevice");

			return (String.Format("{0}://{1}", UriSchemeCapture, captureDevice));
		}

		/// <summary>
		/// The URI scheme for file.
		/// </summary>
		public static readonly string UriSchemeFile = Uri.UriSchemeFile;

		/// <summary>
		/// The URI scheme for file on World Wide Web.
		/// </summary>
		public static readonly string UriSchemeHttp = Uri.UriSchemeHttp;

		/// <summary>
		/// The URI scheme for file on File Transfer Protocol service.
		/// </summary>
		public static readonly string UriSchemeFtp = Uri.UriSchemeFtp;

		/// <summary>
		/// The URI scheme for capture devices.
		/// </summary>
		public static readonly string UriSchemeCapture = "capture";

		#endregion

		#region Uniform Resource Identifier

		/// <summary>
		/// The URI that specify the media.
		/// </summary>
		public string MediaUri { get { return (mMediaUri); } }

		/// <summary>
		/// The URI that specify the media prefix.
		/// </summary>
		public string MediaUriScheme { get { return (mMediaUriScheme); } }

		/// <summary>
		/// The URI that specify the path media, without prefix.
		/// </summary>
		public string MediaUriPath { get { return (mMediaUriPath); } }

		/// <summary>
		/// The URI that specify the media.
		/// </summary>
		private readonly string mMediaUri;

		/// <summary>
		/// The URI that specify the media prefix.
		/// </summary>
		private readonly string mMediaUriScheme;

		/// <summary>
		/// The URI that specify the path media, without prefix.
		/// </summary>
		private readonly string mMediaUriPath;

		#endregion

		#region Stream Overrides

		/// <summary>
		/// When overridden in a derived class, clears all buffers for this stream and causes any buffered data
		/// to be written to the underlying device.
		/// </summary>
		/// <exception cref="NotSupportedException">
		/// This method is not supported.
		/// </exception>
		public override void Flush()
		{
			if (mBackendStream == null)
				throw new NotSupportedException();

			mBackendStream.Flush();
		}

		/// <summary>
		/// When overridden in a derived class, sets the position within the current stream.
		/// </summary>
		/// <returns>
		/// The new position within the current stream.
		/// </returns>
		/// <param name="offset">
		/// A byte offset relative to the origin parameter.
		/// </param>
		/// <param name="origin">
		/// A value of type <see cref="T:System.IO.SeekOrigin"/> indicating the reference point used to obtain
		/// the new position.
		/// </param>
		/// <exception cref="NotSupportedException">
		/// This method is not supported.
		/// </exception>
		public override long Seek(long offset, SeekOrigin origin)
		{
			if (mBackendStream == null)
				throw new NotSupportedException();

			return (mBackendStream.Seek(offset, origin));
		}

		/// <summary>
		/// When overridden in a derived class, sets the length of the current stream.
		/// </summary>
		/// <param name="value">
		/// The desired length of the current stream in bytes.
		/// </param>
		/// <exception cref="NotSupportedException">
		/// This method is not supported.
		/// </exception>
		public override void SetLength(long value)
		{
			if (mBackendStream == null)
				throw new NotSupportedException();

			mBackendStream.SetLength(value);
		}

		/// <summary>
		/// When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
		/// </summary>
		/// <returns>
		/// The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.
		/// </returns>
		/// <param name="offset">
		/// The zero-based byte offset in buffer at which to begin storing the data read from the current stream.
		/// </param>
		/// <param name="count">
		/// The maximum number of bytes to be read from the current stream.
		/// </param>
		/// <param name="buffer">
		/// An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and
		/// (offset + count - 1) replaced by the bytes read from the current source.
		/// </param>
		/// <exception cref="NotSupportedException">
		/// This method is not supported.
		/// </exception>
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (mBackendStream == null)
				throw new NotSupportedException();

			return (mBackendStream.Read(buffer, offset, count));
		}

		/// <summary>
		/// When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
		/// </summary>
		/// <param name="offset">
		/// The zero-based byte offset in buffer at which to begin copying bytes to the current stream.
		/// </param>
		/// <param name="count">
		/// The number of bytes to be written to the current stream.
		/// </param>
		/// <param name="buffer">
		/// An array of bytes. This method copies count bytes from buffer to the current stream.
		/// </param>
		/// <exception cref="NotSupportedException">
		/// This method is not supported.
		/// </exception>
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (mBackendStream == null)
				throw new NotSupportedException();
			
			mBackendStream.Write(buffer, offset, count);
		}

		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports reading.
		/// </summary>
		/// <returns>
		/// It returns always false.
		/// </returns>
		public override bool CanRead
		{
			get { return ((mBackendStream != null && mBackendStream.CanRead) || ((mStreamAccess & FileAccess.Read) != 0)); }
		}

		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports seeking.
		/// </summary>
		/// <returns>
		/// It returns always false.
		/// </returns>
		public override bool CanSeek
		{
			get { return (mBackendStream != null && mBackendStream.CanSeek); }
		}

		/// <summary>
		/// When overridden in a derived class, gets a value indicating whether the current stream supports writing.
		/// </summary>
		/// <returns>
		/// It returns always false.
		/// </returns>
		public override bool CanWrite
		{
			get { return ((mBackendStream != null && mBackendStream.CanWrite) || ((mStreamAccess & FileAccess.Write) != 0)); }
		}

		/// <summary>
		/// When overridden in a derived class, gets the length in bytes of the stream.
		/// </summary>
		/// <returns>
		/// It returns always 0.
		/// </returns>
		public override long Length
		{
			get { return (mBackendStream != null ? mBackendStream.Length : 0); }
		}

		/// <summary>
		/// When overridden in a derived class, gets or sets the position within the current stream.
		/// </summary>
		/// <returns>
		/// The current position within the stream.
		/// </returns>
		public override long Position
		{
			get { return (mBackendStream != null ? mBackendStream.Position : 0); }
			set { if (mBackendStream != null) mBackendStream.Position = value; }
		}

		/// <summary>
		/// The back-end stream, if any.
		/// </summary>
		private readonly Stream mBackendStream;

		/// <summary>
		/// The access granted for streaming.
		/// </summary>
		private readonly FileAccess mStreamAccess;

		#endregion
	}
}
