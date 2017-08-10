
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
using System.Reflection;

namespace OpenGL.Objects
{
	using TagFieldMap = Dictionary<string, MediaInfoTagAttribute>;

	/// <summary>
	/// Generic media information.
	/// </summary>
	public abstract class MediaInfo
	{
		#region Constructors

		/// <summary>
		/// Construct a MediaInfo.
		/// </summary>
		protected MediaInfo()
		{
			DetectTagInformation();
		}

		#endregion

		#region Tag Field Mapping

		/// <summary>
		/// Collect information about information tags.
		/// </summary>
		private void DetectTagInformation()
		{
			FieldInfo[] tagFields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

			foreach (FieldInfo tagField in tagFields) {
				// Must be a string
				if (tagField.FieldType != typeof(string))
					continue;

				MediaInfoTagAttribute infoTagAttribute = Attribute.GetCustomAttribute(tagField, typeof (MediaInfoTagAttribute)) as MediaInfoTagAttribute;

				if (infoTagAttribute != null) {
					string tagName = (string) tagField.GetValue(this);

					if (tagName == null)
						throw new InvalidOperationException(String.Format("null tag name for field {0}.{1}", GetType().Name, tagField.Name));

					// Register tag information
					_TagInfo[tagName] = infoTagAttribute;
					// Register default value
					if (infoTagAttribute.DefaultValue != null)
						SetTag(tagName, infoTagAttribute.DefaultValue);
				}
			}
		}

		/// <summary>
		/// Generic tag collection.
		/// </summary>
		private readonly TagFieldMap _TagInfo = new TagFieldMap();

		#endregion

		#region Generic Tags

		/// <summary>
		/// The count of tags defined in this MediaInfo.
		/// </summary>
		public uint TagCount
		{
			get {
				return ((uint)_Tags.Values.Count);
			}
		}

		/// <summary>
		/// The complete list of Tags included in this MediaInfo.
		/// </summary>
		public IEnumerable<KeyValuePair<string, object>> Tags
		{
			get {
				foreach (KeyValuePair<string, object> pair in _Tags)
					yield return (pair);
			}
		}

		/// <summary>
		/// Determine whether this MediaInfo has defined a specific tag.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> which identify a tag.
		/// </param>
		public bool HasTag(string id)
		{
			if (id == null)
				throw new ArgumentNullException("id");

			return (_Tags.ContainsKey(id) && _Tags[id] != null);
		}

		/// <summary>
		/// Set a tag to this ImageInfo
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> which identify a tag.
		/// </param>
		/// <param name="value">
		/// A <see cref="Object"/> which define the tag value.
		/// </param>
		public void SetTag(string id, object value)
		{
			if (id == null)
				throw new ArgumentNullException("id");

			MediaInfoTagAttribute infoTagAttribute;

			if (_TagInfo.TryGetValue(id, out infoTagAttribute)) {

				// Information available

				if (value != null && !infoTagAttribute.TagType.IsAssignableFrom(value.GetType()))
					throw new ArgumentException(String.Format("the tag {0} expects a value of type {1}, instead a {2} is supplied", id, infoTagAttribute.TagType.Name, value.GetType().Name), "value");
			}

			_Tags[id] = value;
		}

		/// <summary>
		/// Get a tag value from this ImageInfo.
		/// </summary>
		/// <typeparam name="T">
		/// The type of the tag value.
		/// </typeparam>
		/// <param name="id">
		/// A <see cref="String"/> which identify a tag.
		/// </param>
		/// <returns>
		/// It returns the value of the tag.
		/// </returns>
		public T GetTag<T>(string id)
		{
			object tag;

			if (HasTag(id) == false)
				throw new ArgumentException(String.Format("tag {0} not defined", id));

			// Get the tag object
			tag = _Tags[id];

			// Check tag type
			if (!(tag is T))
				throw new ArgumentException(String.Format("tag {0} is not a {1}", id, typeof(T).Name));

			return ((T)tag);
		}

		/// <summary>
		/// Generic tag collection.
		/// </summary>
		private readonly Dictionary<string, object> _Tags = new Dictionary<string,object>();

		#endregion

		#region Conventional Tags Identifiers

		/// <summary>
		/// The media comment.
		/// </summary>
		[MediaInfoTag(typeof(string))]
		public const string TagComment = "Comment";

		/// <summary>
		/// The person who has acquired the media.
		/// </summary>
		[MediaInfoTag(typeof(string))]
		public const string TagAcquisitionArtist = "AcquisitionArtist";

		/// <summary>
		/// The device used for acquiring the media.
		/// </summary>
		[MediaInfoTag(typeof(string))]
		public const string TagAcquisitionDevice = "AcquisitionDevice";

		#endregion
	}

	/// <summary>
	/// Attribute that specify contraints for fields
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	class MediaInfoTagAttribute : Attribute
	{
		/// <summary>
		/// Construct a MediaInfoTagAttribute.
		/// </summary>
		public MediaInfoTagAttribute()
		{
			
		}

		/// <summary>
		/// Construct a MediaInfoTagAttribute that specify the tag value type.
		/// </summary>
		/// <param name="valueType">
		/// A <see cref="Type"/> that specify the tag value type.
		/// </param>
		public MediaInfoTagAttribute(Type valueType)
		{
			if (valueType == null)
				throw new ArgumentNullException("valueType");

			_TagType = valueType;
		}

		/// <summary>
		/// The type of the tag value.
		/// </summary>
		public Type TagType { get { return (_TagType); } }

		/// <summary>
		/// The default value of the tag.
		/// </summary>
		public object DefaultValue;

		/// <summary>
		/// The type of the tag value.
		/// </summary>
		private readonly Type _TagType = typeof(object);
	}
}

