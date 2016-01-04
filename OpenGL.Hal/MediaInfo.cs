
//  Copyright (C) 2012-2013 Luca Piccioni
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
using System.Collections.Generic;
using System.Reflection;

namespace OpenGL
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
					mTagInfo[tagName] = infoTagAttribute;
					// Register default value
					if (infoTagAttribute.DefaultValue != null)
						SetTag(tagName, infoTagAttribute.DefaultValue);
				}
			}
		}

		/// <summary>
		/// Generic tag collection.
		/// </summary>
		private readonly TagFieldMap mTagInfo = new TagFieldMap();

		#endregion

		#region Generic Tags

		/// <summary>
		/// The count of tags defined in this MediaInfo.
		/// </summary>
		public uint TagCount
		{
			get {
				return ((uint)mTags.Values.Count);
			}
		}

		/// <summary>
		/// The complete list of Tags included in this MediaInfo.
		/// </summary>
		public IEnumerable<KeyValuePair<string, object>> Tags
		{
			get {
				foreach (KeyValuePair<string, object> pair in mTags)
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

			return (mTags.ContainsKey(id) && mTags[id] != null);
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

			if (mTagInfo.TryGetValue(id, out infoTagAttribute)) {

				// Information available

				if (value != null && !infoTagAttribute.TagType.IsAssignableFrom(value.GetType()))
					throw new ArgumentException(String.Format("the tag {0} expects a value of type {1}, instead a {2} is supplied", id, infoTagAttribute.TagType.Name, value.GetType().Name), "value");
			}

			mTags[id] = value;
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
			tag = mTags[id];

			// Check tag type
			if (!(tag is T))
				throw new ArgumentException(String.Format("tag {0} is not a {1}", id, typeof(T).Name));

			return ((T)tag);
		}

		/// <summary>
		/// Generic tag collection.
		/// </summary>
		private readonly Dictionary<string, object> mTags = new Dictionary<string,object>();

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

			mTagType = valueType;
		}

		/// <summary>
		/// The type of the tag value.
		/// </summary>
		public Type TagType { get { return (mTagType); } }

		/// <summary>
		/// The default value of the tag.
		/// </summary>
		public object DefaultValue;

		/// <summary>
		/// The type of the tag value.
		/// </summary>
		private readonly Type mTagType = typeof(object);
	}
}

