
// Copyright (C) 2015 Luca Piccioni
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
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("Extension: Supported={Supported} Comment={Comment} Protect={Protect}")]
	public class Extension : IFeature
	{
		#region Specification

		/// <summary>
		/// Extension name.
		/// </summary>
		[XmlAttribute("name")]
		public String Name;

		/// <summary>
		/// A regular expression, with an implicit ˆ and $ bracketing it, which should match the api tag of a set
		/// of <see cref="Feature"/>.
		/// </summary>
		[XmlAttribute("supported")]
		public String Supported;

		/// <summary>
		/// An additional preprocessor token used to protect an extension definition. Usually another feature or extension
		/// name. Rarely used, for odd circumstances where the definition of an extension requires another to be defined 
		/// first.
		/// </summary>
		[XmlAttribute("protect")]
		public String Protect;

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		[XmlElement("require")]
		public readonly List<FeatureCommand> Requirements = new List<FeatureCommand>();

		#endregion

		#region Utilities

		public string Vendor
		{
			get {
				return (GetVendor(Name));
			}
		}

		public static string GetVendor(string extensionName)
		{
			Match vendorMatch = Regex.Match(extensionName, @"^(GL|WGL|GLX|GLU|EGL)_(?<Vendor>[^_]+).*");

			if (vendorMatch.Success == false)
				throw new NotSupportedException();

			return (vendorMatch.Groups["Vendor"].Value);
		}

		public static bool IsArbVendor(string extensionName)
		{
			switch (Extension.GetVendor(extensionName)) {
				case "ARB":
				case "KHR":
					return (true);
				default:
					return (false);
			}
		}

		#endregion

		#region IFeature Implementation

		/// <summary>
		/// Get the feature name.
		/// </summary>
		string IFeature.Name
		{
			get {
				return (Name);
			}
		}

		/// <summary>
		/// Get the name of the API(s) supporting this IFeature.
		/// </summary>
		string IFeature.Api
		{
			get {
				return (Supported);
			}
		}

		/// <summary>
		/// Get the name of the API profile supporting this IFeature.
		/// </summary>
		string IFeature.Profile
		{
			get {
				return (null);
			}
		}

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		IEnumerable<FeatureCommand> IFeature.Requirements
		{
			get {
				return (Requirements);
			}
		}

		public bool Equals(IFeature other)
		{
			if (ReferenceEquals(this, other))
				return (true);

			IFeature thisFeature = (IFeature)this;

			if (thisFeature.Name != other.Name)
				return (false);
			if (thisFeature.Api != other.Api)
				return (false);
			if (thisFeature.Profile != other.Profile)
				return (false);

			return (true);
		}

		#endregion

		#region Object Overrides

		public override bool Equals(object obj)
		{
			IFeature objFeature = obj as IFeature;

			if (objFeature != null)
				return (Equals(objFeature));

			// Base implementation
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			IFeature thisFeature = (IFeature)this;

			int result = thisFeature.Name.GetHashCode();

			if (thisFeature.Api != null)
				result = (result * 397) ^ thisFeature.Api.GetHashCode();
			if (thisFeature.Profile != null)
				result = (result * 397) ^ thisFeature.Profile.GetHashCode();

			return base.GetHashCode();
		}

		#endregion
	}

	class ExtensionProfile : IFeature
	{
		#region Constructors

		public ExtensionProfile(Extension extension, string profile)
			: this(extension, null, profile)
		{

		}

		public ExtensionProfile(Extension extension, string api, string profile)
		{
			_Extension = extension;
			_Api = api;
			Profile = profile;
		}

		private readonly Extension _Extension;

		public string Api
		{
			get {
				return (_Api ?? _Extension.Supported);
			}
		}

		private readonly string _Api;

		public readonly string Profile;

		#endregion

		#region IFeature Implementation

		/// <summary>
		/// Get the feature name.
		/// </summary>
		string IFeature.Name
		{
			get {
				return (_Extension.Name);
			}
		}

		/// <summary>
		/// Get the name of the API(s) supporting this IFeature.
		/// </summary>
		string IFeature.Api
		{
			get {
				return (Api);
			}
		}

		/// <summary>
		/// Get the name of the API profile supporting this IFeature.
		/// </summary>
		string IFeature.Profile
		{
			get {
				return (Profile);
			}
		}

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		IEnumerable<FeatureCommand> IFeature.Requirements
		{
			get {
				return (_Extension.Requirements);
			}
		}

		public bool Equals(IFeature other)
		{
			if (ReferenceEquals(this, other))
				return (true);

			IFeature thisFeature = (IFeature)this;

			if (thisFeature.Name != other.Name)
				return (false);
			if (thisFeature.Api != other.Api)
				return (false);
			if (thisFeature.Profile != other.Profile)
				return (false);

			return (true);
		}

		#endregion

		#region Object Overrides

		public override bool Equals(object obj)
		{
			IFeature objFeature = obj as IFeature;

			if (objFeature != null)
				return (Equals(objFeature));

			// Base implementation
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			IFeature thisFeature = (IFeature)this;

			int result = thisFeature.Name.GetHashCode();

			if (thisFeature.Api != null)
				result = (result * 397) ^ thisFeature.Api.GetHashCode();
			if (thisFeature.Profile != null)
				result = (result * 397) ^ thisFeature.Profile.GetHashCode();

			return base.GetHashCode();
		}

		#endregion
	}
}
