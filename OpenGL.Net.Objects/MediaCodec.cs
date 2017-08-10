
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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Generic media coder/decoder, based on plugins implementations.
	/// </summary>
	/// <typeparam name="TPlugin">
	/// A <see cref="IMediaCodecPlugin{TMedia,TMediaInfo}"/> type, indicating the interface implemented by the plugin.
	/// </typeparam>
	/// <typeparam name="TMedia">
	/// A <see cref="IMedia{TMediaInfo}"/> type, indicating the concrete class of the media.
	/// </typeparam>
	/// <typeparam name="TMediaInfo">
	/// A <see cref="MediaInfo"/> that stored information about <typeparamref name="TMedia"/>
	/// </typeparam>
	/// <remarks>
	/// <para>
	/// Allow to access to <typeparamref name="TMedia"/> information easily, by using:
	/// - <see cref="GetBriefDescription"/>
	/// - <see cref="GetLongDescription"/>
	/// - <see cref="GetFormatsFromUrl"/>
	/// - <see cref="GetFileExtensions"/>
	/// </para>
	/// <para>
	/// The <typeparamref name="TMedia"/> can be specified using a URL string, that follows the pattern:
	/// {UrlType}://
	/// </para>
	/// </remarks>
	public abstract class MediaCodec<TPlugin, TMedia, TMediaInfo, TMediaCodecCriteria> : PluginLoader<TPlugin>
		where TPlugin : class, IMediaCodecPlugin<TMedia, TMediaInfo, TMediaCodecCriteria>
		where TMedia : class, IMedia<TMediaInfo>
		where TMediaInfo : MediaInfo
		where TMediaCodecCriteria : MediaCodecCriteria
	{
		#region Constructors

		/// <summary>
		/// Construct a <see cref="MediaCodec{TPlugin,TMedia,TMediaInfo}"/>, loading plugins from current directory.
		/// </summary>
		/// <param name='pluginFactoryType'>
		/// Plugin factory type used for loading managed plugins. If it null, only unmanaged plugins
		/// will be loaded.
		/// </param>
		protected MediaCodec(string pluginFactoryType)
			: base(pluginFactoryType)
		{
			
		}

		/// <summary>
		/// Construct a <see cref="OpenGL.MediaCodec{TPlugin,TMedia,TMediaInfo}"/>, loading plugins from current directory and optionally
		/// from a directory path specified via environment.
		/// </summary>
		/// <param name="pluginFactoryType">
		/// Plugin factory type used for loading managed plugins. If it null, only unmanaged plugins
		/// will be loaded.
		/// </param>
		/// <param name="environDir">
		/// Environment variable name used for getting an additional directory from where load plugins.
		/// </param>
		protected MediaCodec(string pluginFactoryType, string environDir)
			: base(pluginFactoryType, environDir)
		{
			
		}

		#endregion

		#region Media Format Description

		/// <summary>
		/// Gets the brief description of a media format.
		/// </summary>
		/// <param name='mediaFormat'>
		/// A <see cref="String"/> that specify the media format.
		/// </param>
		/// <returns>
		/// The brief description of <paramref name="mediaFormat"/>.
		/// </returns>
		public string GetBriefDescription(string mediaFormat)
		{
			return (mCodecDescriptions[mediaFormat].ShortDescription);
		}

		/// <summary>
		/// Gets the long description of a media format.
		/// </summary>
		/// <param name='mediaFormat'>
		/// A <see cref="String"/> that specify the media format.
		/// </param>
		/// <returns>
		/// The long description of <paramref name="mediaFormat"/>.
		/// </returns>
		public string GetLongDescription(string mediaFormat)
		{
			return (mCodecDescriptions[mediaFormat].LongDescription);
		}

		/// <summary>
		/// Gets the supported read formats.
		/// </summary>
		/// <value>
		/// A <see cref="IEnumerable{TMediaFormat}"/> that specify all media formats supported for reading.
		/// </value>
		public ICollection<string> SupportedReadFormats
		{
			get
			{
				List<string> readFormats = new List<string>();

				foreach (string mediaFormat in mCodecDescriptions.Keys) {
					foreach (TPlugin plugin in Plugins) {
						if (plugin.IsReadSupported(mediaFormat)) {
							readFormats.Add(mediaFormat);
							break;
						}
					}
				}

				return (readFormats);
			}
		}

		/// <summary>
		/// Gets the supported media for writing.
		/// </summary>
		/// <value>
		/// A set of media formats that specify all media formats supported for reading.
		/// </value>
		public ICollection<string> SupportedWriteFormats
		{
			get
			{
				List<string> writeFormats = new List<string>();

				foreach (string mediaFormat in mCodecDescriptions.Keys) {
					foreach (TPlugin plugin in Plugins) {
						if (plugin.IsWriteSupported(mediaFormat)) {
							writeFormats.Add(mediaFormat);
							break;
						}
					}
				}

				return (writeFormats);
			}
		}

		/// <summary>
		/// Gets the possible media formats from URL.
		/// </summary>
		/// <param name="url">
		/// A <see cref="String"/> that specify the URL where media is located.
		/// </param>
		/// <returns>
		/// A <see cref="IEnumerable{TMediaFormat}"/> enumerating all possible media formats given <paramref name="url"/>. This
		/// method could return an empty enumeration.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		public IEnumerable<string> GetFormatsFromUrl(string url)
		{
			if (url == null)
				throw new ArgumentNullException("url");
			
			List<string> mediaFormats = new List<string>();

			foreach (KeyValuePair<string, MediaFormatAttribute> pair in mCodecDescriptions) {
				MediaFormatAttribute mediaFormat = pair.Value;

				if (mediaFormat.MatchPattern(url))
					mediaFormats.Add(pair.Key);
			}

			return (mediaFormats);
		}

		/// <summary>
		/// Gets the file extensions for the specified media format.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specify the format of the media to query extensions.
		/// </param>
		/// <returns>
		/// The file extensions usually used for the <paramref name="format"/>. This method can return an
		/// empty enumeration.
		/// </returns>
		public IEnumerable<string> GetFileExtensions(string format)
		{
			MediaFormatAttribute mediaFormat;

			if (mCodecDescriptions.TryGetValue(format, out mediaFormat)) {
				if (mediaFormat.FileExtensions != null)
					return (mediaFormat.FileExtensions.Split('|'));
				// Empty enumerable
				return (new List<string>());
			} else
				throw new NotSupportedException(String.Format("media format {0} not supported", format));
		}

		/// <summary>
		/// Get the media format derived from the media input string.
		/// </summary>
		/// <param name="input">
		/// A <see cref="String"/> that specify the media input string where the media is located (that
		/// is usually a file path).
		/// </param>
		/// <returns>
		/// It returns the media format if any known media format recognize a proper pattern in <paramref name="input"/>, otherwise
		/// it returns null.
		/// </returns>
		public string GetFormatFromExtension(string input)
		{
			if (input == null)
				throw new ArgumentNullException("input");

			foreach (KeyValuePair<string, MediaFormatAttribute> pair in mCodecDescriptions) {
				if (pair.Value.MatchPattern(input))
					return (pair.Key);
			}

			return (null);
		}

		/// <summary>
		/// Construct a string suitable for <see cref="Windows.Forms.OpenFileDialog.Filter"/> property.
		/// </summary>
		/// <returns>
		/// It returns a string specifying the file filter usable on dialogs selecting a file for reading media
		/// managed by this MediaCodec instance.
		/// </returns>
		public string GetReadFileDialogFilter()
		{
			StringBuilder sb = new StringBuilder();

			// Determine all extension filter
			StringBuilder sbAllExtensions = new StringBuilder();

			foreach (string readFormat in SupportedReadFormats) {
				foreach (string extension in GetFileExtensions(readFormat))
					sbAllExtensions.AppendFormat("*.{0};", extension);
			}
			// Remove trailing semicolon
			sbAllExtensions.Remove(sbAllExtensions.Length - 1, 1);

			// File filter - All media
			sb.AppendFormat("All media|{0}|", sbAllExtensions);
			
			// File filter - Specific media
			foreach (string readFormat in SupportedReadFormats) {
				StringBuilder sbExtensions = new StringBuilder();

				foreach (string extension in GetFileExtensions(readFormat))
					sbExtensions.AppendFormat("*.{0};", extension);
				// Remove trailing semicolon
				sbExtensions.Remove(sbExtensions.Length - 1, 1);

				string extensionList = sbExtensions.ToString();

				sb.AppendFormat("{0} - {1} ({2})", GetBriefDescription(readFormat), GetLongDescription(readFormat), extensionList);
				sb.AppendFormat("|{0}", extensionList);
				sb.Append("|");
			}

			// File filter - All files
			sb.AppendFormat("All files|*.*");

			return (sb.ToString());
		}

		/// <summary>
		/// Construct a string suitable for <see cref="Windows.Forms.SaveFileDialog.Filter"/> property.
		/// </summary>
		/// <returns>
		/// It returns a string specifying the file filter usable on dialogs selecting a file for writing media
		/// managed by this MediaCodec instance.
		/// </returns>
		public string GetWriteFileDialogFilter(out string[] mediaFormats)
		{
			StringBuilder sb = new StringBuilder();

			ICollection<string> writeFormats = SupportedWriteFormats;
			
			// Outputs the media format list
			mediaFormats = new string[writeFormats.Count + 1];
			mediaFormats[0] = null;
			writeFormats.CopyTo(mediaFormats, 1);

			// Determine all extension filter
			StringBuilder sbAllExtensions = new StringBuilder();

			foreach (string readFormat in SupportedReadFormats) {
				foreach (string extension in GetFileExtensions(readFormat))
					sbAllExtensions.AppendFormat("*.{0};", extension);
			}
			// Remove trailing semicolon
			sbAllExtensions.Remove(sbAllExtensions.Length - 1, 1);

			// File filter - All media
			sb.AppendFormat("Any media|{0}|", sbAllExtensions);

			// File filter - Specific media
			foreach (string readFormat in writeFormats) {
				StringBuilder sbExtensions = new StringBuilder();

				foreach (string extension in GetFileExtensions(readFormat))
					sbExtensions.AppendFormat("*.{0};", extension);
				// Remove trailing semicolon
				sbExtensions.Remove(sbExtensions.Length - 1, 1);

				string extensionList = sbExtensions.ToString();

				if (extensionList.Length < 16)
					sb.AppendFormat("{0} - {1} ({2})", GetBriefDescription(readFormat), GetLongDescription(readFormat), extensionList);
				else
					sb.AppendFormat("{0} - {1}", GetBriefDescription(readFormat), GetLongDescription(readFormat));
				sb.AppendFormat("|{0}", extensionList);
				sb.Append("|");
			}

			// Remove trailing pipe
			sb.Remove(sb.Length - 1, 1);

			return (sb.ToString());
		}

		/// <summary>
		/// Extracts the media descriptions via reflection on a <see cref="Type"/>.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Dictionary{TMediaFormat,MediaFormatAttribute}"/> mapping all known media formats with the relative
		/// <see cref="MediaFormatAttribute"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="type"/> is null.
		/// </exception>
		protected void ExtractDescriptions(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			Dictionary<string, MediaFormatAttribute> formatDescriptions = new Dictionary<string, MediaFormatAttribute>();

			FieldInfo[] mediaFormatMembers = type.GetFields(BindingFlags.Public | BindingFlags.Static);

			foreach (FieldInfo mediaFormatField in mediaFormatMembers) {
				MediaFormatAttribute mediaFormatAttribute = (MediaFormatAttribute)Attribute.GetCustomAttribute(mediaFormatField, typeof(MediaFormatAttribute));

				if ((mediaFormatAttribute != null) && (mediaFormatAttribute.Abstract == false))
					formatDescriptions[(string)mediaFormatField.GetValue(null)] = mediaFormatAttribute;
			}

			foreach (KeyValuePair<string, MediaFormatAttribute> pair in formatDescriptions) {
				if (mCodecDescriptions.ContainsKey(pair.Key)) {
					Resource.Log("The type {0} define media {1}, but it is ignored because it is already defined elsewhere.", type, pair.Key);
					continue;
				}

				mCodecDescriptions.Add(pair.Key, pair.Value);
			}
		}

		/// <summary>
		/// The media format descriptions.
		/// </summary>
		private readonly Dictionary<string, MediaFormatAttribute> mCodecDescriptions = new Dictionary<string, MediaFormatAttribute>();

		#endregion

		#region Codec Criteria

		/// <summary>
		/// String value used for filtering the available plugin list by the plugin name.
		/// </summary>
		public static readonly string PluginName = "PluginName";

		/// <summary>
		/// Creates the default media codec criteria.
		/// </summary>
		/// <returns>
		/// The default <see cref="MediaCodecCriteria"/> for this <see cref="MediaCodec{TPlugin,TMedia,TMediaInfo}"/>. The
		/// object returned by this method will be used for Load and Save methods when a <see cref="MediaCodecCriteria"/> is not
		/// specified.
		/// </returns>
		protected abstract TMediaCodecCriteria CreateDefaultMediaCodecCriteria();

		/// <summary>
		/// Filters the plugins (used for reading) by criteria.
		/// </summary>
		/// <param name="plugins">
		/// A <see cref="List{TPlugin}"/> that contains all available plugins.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="TMediaCodecCriteria"/> that specify the plugin filtering criteria.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{TPlugin}"/> that satisfy the criteria <paramref name="criteria"/>.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Exception thrown if <paramref name="plugins"/> of <paramref name="criteria"/> is null.
		/// </exception>
		protected virtual List<TPlugin> FilterReadPlugins(List<TPlugin> plugins, TMediaCodecCriteria criteria)
		{
			if (plugins == null)
				throw new ArgumentNullException("plugins");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			// Criteria: PluginName
			if (criteria.IsSet(PluginName)) {
				plugins = plugins.FindAll(delegate(TPlugin obj) {
					return (obj.Name == (string)criteria[PluginName]);
				});
			}

			return (plugins);
		}

		/// <summary>
		/// Filters the plugins (used for reading) by media format.
		/// </summary>
		/// <param name="plugins">
		/// A <see cref="List{TPlugin}"/> that contains all available plugins.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the criteria for filtering.
		/// </param>
		/// <returns>
		/// The plugins which can read <see cref="format"/>.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		private List<TPlugin> FilterReadPlugins(List<TPlugin> plugins, string format)
		{
			if (plugins == null)
				throw new ArgumentNullException("plugins");

			// Criteria: PluginName
			plugins = plugins.FindAll(delegate(TPlugin obj) {
				return (obj.IsReadSupported(format));
			});

			return (plugins);
		}

		/// <summary>
		/// Filters the plugins (used for reading) by criteria.
		/// </summary>
		/// <returns>
		/// The read plugins.
		/// </returns>
		/// <param name='plugins'>
		/// The actual plugin list.
		/// </param>
		/// <param name='criteria'>
		/// Criteria.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		protected virtual List<TPlugin> FilterWritePlugins(List<TPlugin> plugins, TMediaCodecCriteria criteria)
		{
			if (plugins == null)
				throw new ArgumentNullException("plugins");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			// Criteria: PluginName
			if (criteria.IsSet(PluginName)) {
				plugins = plugins.FindAll(delegate(TPlugin obj) {
					return (obj.Name == (string)criteria[PluginName]);
				});
			}

			return (plugins);
		}

		/// <summary>
		/// Filters the plugins (used for writing) to media format.
		/// </summary>
		/// <param name='plugins'>
		/// The actual plugin list.
		/// </param>
		/// <param name="format">
		/// </param>
		/// <returns>
		/// The plugins which can read media with format <paramref name="format"/>.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		private List<TPlugin> FilterWritePlugins(List<TPlugin> plugins, string format)
		{
			if (plugins == null)
				throw new ArgumentNullException("plugins");

			plugins = plugins.FindAll(delegate(TPlugin obj) {
				return (obj.IsWriteSupported(format));
			});

			return (plugins);
		}

		#endregion

		#region Media Information Query

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the file path where media data is stored.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (QueryInfo(fs, CreateDefaultMediaCodecCriteria()));
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the file path where media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(string path, TMediaCodecCriteria criteria)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (QueryInfo(fs, criteria));
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="uri">
		/// A <see cref="Uri"/> that specify the resource location where media data is stored.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(Uri uri)
		{
			return (QueryInfo(uri, CreateDefaultMediaCodecCriteria()));
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="uri">
		/// A <see cref="Uri"/> that specify the resource location where media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(Uri uri, TMediaCodecCriteria criteria)
		{
			if (uri == null)
				throw new ArgumentNullException("uri");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			string localPath = GetLocalUriPath(uri);

			using (FileStream fs = new FileStream(localPath, FileMode.Open, FileAccess.Read)) {
				return (QueryInfo(fs, criteria));
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <returns>
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(Stream stream)
		{
			return (QueryInfo(stream, CreateDefaultMediaCodecCriteria()));
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
		/// A <typeparamref name="TMediaInfo"/> containing information about the specified media.
		/// </returns>
		public TMediaInfo QueryInfo(Stream stream, TMediaCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (stream.CanRead == false)
				throw new ArgumentException(String.Format("unable to read from stream"));
			if (stream.CanSeek == false)
				throw new ArgumentException(String.Format("stream is not seekable"));
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			List<TPlugin> supportedPlugins = Plugins;

			// Class filtering
			if (supportedPlugins != null)
				supportedPlugins = FilterReadPlugins(supportedPlugins, criteria);
			if (supportedPlugins == null)
				throw new InvalidOperationException("no plugin available");

			foreach (TPlugin plugin in supportedPlugins) {
				try {
					// Rewind stream
					if (stream.CanSeek)
						stream.Seek(0, SeekOrigin.Begin);
					// Try to get information
					return (plugin.QueryInfo(stream, criteria));
				} catch {

				}
			}

			// Don't returns not assigned information
			throw new InvalidOperationException(String.Format("no plugin can query information on media"));
		}

		#endregion

		#region Media Loading

		/// <summary>
		/// Load media from a local file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the resource path where the media data is stored.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		public TMedia Load(string path)
		{
			return (Load(path, CreateDefaultMediaCodecCriteria()));
		}

		/// <summary>
		/// Load media from a local file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the resource path where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Eception thrown if no media plugin can open <paramref name="path"/>.
		/// </exception>
		public TMedia Load(string path, TMediaCodecCriteria criteria)
		{
			if (path == null)
				throw new ArgumentNullException("uri");

			foreach (string format in GetFormatsFromUrl(path)) {
				return (Load(path, format, criteria));
			}

			throw new InvalidOperationException(String.Format("no format recognized from URI \"{0}\"", path));
		}

		/// <summary>
		/// Load media from a local file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the resource path where the media data is stored.
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
		public virtual TMedia Load(string path, string format, TMediaCodecCriteria criteria)
		{
			if (path == null)
				throw new ArgumentNullException("uri");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			List<TPlugin> supportedPlugins = GetLoadPlugins(format, criteria);
			StringBuilder exceptionMessage = new StringBuilder();

			foreach (TPlugin plugin in supportedPlugins) {
				try {
					// Try to get information
					return (plugin.Load(path, criteria));
				} catch (Exception exception) {
					if (supportedPlugins.Count > 1) {
						exceptionMessage.AppendLine(String.Format("- '{0}' exception: {1};", plugin.Name, exception.Message));
						continue;
					}

					throw new InvalidOperationException(String.Format("no plugin can load media: {0}", exception.Message), exception);
				}
			}

			// Remove trailing carriage return.
			exceptionMessage = exceptionMessage.Remove(exceptionMessage.Length - 1, 1);
			// Don't returns not assigned information
			throw new InvalidOperationException(String.Format("no plugin can load media; the reasons are:\n{0}", exceptionMessage));
		}

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="format">
		/// The <see cref="String"/> which defines the format of the stream data.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		public TMedia Load(Stream stream, string format)
		{
			return (Load(stream, format, CreateDefaultMediaCodecCriteria()));
		}

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
		public virtual TMedia Load(Stream stream, string format, TMediaCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (criteria == null)
				throw new ArgumentNullException("criteria");
			if (stream.CanRead == false)
				throw new ArgumentException("unable to read from stream");

			List<TPlugin> supportedPlugins = GetLoadPlugins(format, criteria);
			StringBuilder exceptionMessage = new StringBuilder();

			foreach (TPlugin plugin in supportedPlugins) {
				try {
					// Rewind stream
					if (stream.CanSeek)
						stream.Seek(0, SeekOrigin.Begin);
					// Try to get information
					return (plugin.Load(stream, criteria));
				} catch (Exception exception) {
					if (supportedPlugins.Count > 1) {
						exceptionMessage.AppendLine(String.Format("- '{0}' exception: {1};", plugin.Name, exception.Message));
						continue;
					}

					throw new InvalidOperationException(String.Format("no plugin can load media: {0}", exception.Message));
				}
			}

			// Remove trailing carriage return.
			exceptionMessage = exceptionMessage.Remove(exceptionMessage.Length - 1, 1);
			// Don't returns not assigned information
			throw new InvalidOperationException(String.Format("no plugin can load media; the reasons are:\n{0}", exceptionMessage));
		}

		private List<TPlugin> GetLoadPlugins(string format, TMediaCodecCriteria criteria)
		{
			List<TPlugin> supportedPlugins = Plugins;

			// Format filtering
			if (supportedPlugins != null)
				supportedPlugins = FilterReadPlugins(supportedPlugins, format);
			if ((supportedPlugins == null) || (supportedPlugins.Count == 0))
				throw new NotSupportedException(String.Format("format {0} is not supported", format));
			// Class filtering
			supportedPlugins = FilterReadPlugins(supportedPlugins, criteria);
			if ((supportedPlugins == null) || (supportedPlugins.Count == 0))
				throw new InvalidOperationException("no plugin available");

			return (supportedPlugins);
		}

		#endregion

		#region Media Saving

		/// <summary>
		/// Save media to a <see cref="IO.Stream"/>.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the file path where media data is stored.
		/// </param>
		/// <param name="media">
		/// A <typeparamref name="TMedia"/> that holds the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="media"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if at least one of the parameters <paramref name="path"/> or <paramref name="media"/>
		/// is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// This exception is thrown if no plugin cannot save the image <paramref name="media"/> on <paramref name="path"/>.
		/// </exception>
		public void Save(string path, TMedia media, string format, TMediaCodecCriteria criteria)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (media == null)
				throw new ArgumentNullException("media");

			string tempMediaPath = Path.GetTempFileName();
			bool alreadyExisting = File.Exists(path);

			try {
				// Save media (on temporary file)
				using (FileStream fs = new FileStream(tempMediaPath, FileMode.Create, FileAccess.Write)) {
					Save(fs, media, format, criteria);
				}
				// Place saved media
				if (alreadyExisting)
					File.Copy(tempMediaPath, path, true);		// Copy existing file (overwriting)
				else
					File.Move(tempMediaPath, path);				// Move temporary file
			} catch {
				File.Delete(tempMediaPath);
				throw;
			}
		}

		/// <summary>
		/// Save media to a <see cref="IO.Stream"/>.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="IO.Stream"/> that stores the media data.
		/// </param>
		/// <param name="media">
		/// A <typeparamref name="TMedia"/> that holds the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="media"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an image stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if at least one of the parameters <paramref name="stream"/> or <paramref name="media"/>
		/// is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="stream"/> cannot be seek or cannot be written.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// This exception is thrown if no plugin cannot save the media <paramref name="media"/> on the stream <paramref name="stream"/>.
		/// </exception>
		public void Save(Stream stream, TMedia media, string format, TMediaCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (media == null)
				throw new ArgumentNullException("media");
			if (stream.CanWrite == false)
				throw new ArgumentException(String.Format("unable to write to stream"));
			if (stream.CanSeek == false)
				throw new ArgumentException(String.Format("unable to seek on stream"));

			List<TPlugin> supportedPlugins = Plugins;

			// Format filtering
			if (supportedPlugins != null)
				supportedPlugins = FilterWritePlugins(supportedPlugins, format);
			if (supportedPlugins == null)
				throw new NotSupportedException(String.Format("format {0} is not supported", format));
			// Class filtering
			if (criteria != null)
				supportedPlugins = FilterWritePlugins(supportedPlugins, criteria);
			if (supportedPlugins == null)
				throw new InvalidOperationException("no plugin available");

			StringBuilder pluginLog = new StringBuilder();

			// Write image pixel data
			foreach (TPlugin plugin in supportedPlugins) {
				try {
					// Position file cursor at beginning
					if (stream.CanSeek)
						stream.Seek(0, SeekOrigin.Begin);
					// Save image pixel data
					plugin.Save(stream, media, format, criteria);
					return;
				} catch (Exception exception) {
					pluginLog.AppendLine(String.Format("- Exception of plugin '{0}': {1}", plugin.Name, exception.Message));
				}
			}

			throw new InvalidOperationException(String.Format("no plugin can save media. Detailed information:\n{0}", pluginLog));
		}

		#endregion

		#region Common Uri Management

		/// <summary>
		/// Gets the local URI path.
		/// </summary>
		/// <param name='uri'>
		/// A <see cref="Uri"/> that specify the resource (local or remote).
		/// </param>
		/// <returns>
		/// The local path of the file representing the resource specified by <paramref name="uri"/>.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Exception thrown if <paramref name="uri"/> is null.
		/// </exception>
		/// <remarks>
		/// This method will download locally the resource localized with <paramref name="uri"/>, if it is
		/// a remote one.
		/// </remarks>
		private static string GetLocalUriPath(Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException("uri");

			string localPath;

			// Download file, if necessary
			if (uri.IsFile == false) {
				localPath = Path.GetTempFileName();

				try {
					using (System.Net.WebClient webClient = new System.Net.WebClient()) {
						webClient.DownloadFile(uri, localPath);
					}
				} catch {
					File.Delete(localPath);
					throw;
				}
			} else
				localPath = uri.LocalPath;

			return (localPath);
		}

		#endregion

		#region PluginLoader<TPlugin> Overrides

		/// <summary>
		/// Loads a managed plugin type implementation from a dynamically loaded library.
		/// </summary>
		/// <param name="pluginPath">
		/// A <see cref="String"/> that specify the path of the dynamically loaded library.
		/// </param>
		/// <param name="pluginFactoryType">
		/// A <see cref="String"/> that specify the full name of the type that create the plugin. This type
		/// shall have a method named CreatePlugin which returns a <typeparamref name="TPlugin"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="pluginPath"/> or <paramref name="pluginFactoryType"/> are null.
		/// </exception>
		/// <exception cref="FileNotFoundException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> cannot be found.
		/// </exception>
		/// <exception cref="FileLoadException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> cannot be loaded.
		/// </exception>
		/// <exception cref="BadImageFormatException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> is not a valid assembly.
		/// </exception>
		protected override TPlugin LoadManagedPlugin(string pluginPath, string pluginFactoryType)
		{
			// Base implementation
			TPlugin plugin = base.LoadManagedPlugin(pluginPath, pluginFactoryType);

			// Check media formats on plugin type
			if (plugin != null) {
				ExtractDescriptions(plugin.GetType());
			}
				
			return (plugin);
		}

		#endregion
	}
}

