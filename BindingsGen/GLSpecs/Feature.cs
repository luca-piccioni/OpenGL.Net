
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
	/// A feature is the set of interfaces (enumerants and commands) defined by a particular API and version, suc
	/// as OpenGL 4.0 or OpenGL ES 3.0, and includes all API profiles of that version.
	/// </summary>
	[DebuggerDisplay("Feature: Api={Api} Name={Name} Version={Version}")]
	public class Feature : IFeature
	{
		#region Specification

		/// <summary>
		/// API name this feature is for, such as gl or gles2.
		/// </summary>
		[XmlAttribute("api")]
		public String Api;

		/// <summary>
		/// Version name, used as the C preprocessor token under which the version’s interfaces are protected against
		/// multiple inclusion. Example: GL_VERSION_4_2.
		/// </summary>
		[XmlAttribute("name")]
		public String Name;

		/// <summary>
		/// An additional preprocessor token used to protect a feature definition. Usually another feature or extension
		/// name. Rarely used, for odd circumstances where the definition of a feature or extension requires another to
		/// be defined first.
		/// </summary>
		[XmlAttribute("protect")]
		public String Protect;

		/// <summary>
		/// The feature version number, usually a string interpreted as majorNumber:minorNumber. Example: 4.2.
		/// </summary>
		[XmlAttribute("version")]
		public String Version;

		/// <summary>
		/// The feature version number.
		/// </summary>
		[XmlAttribute("number")]
		public String Number;

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this feature.
		/// </summary>
		[XmlElement("require")]
		public readonly List<FeatureCommand> Requirements = new List<FeatureCommand>();

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is removed from this feature.
		/// </summary>
		[XmlElement("remove")]
		public readonly List<FeatureCommand> Removals = new List<FeatureCommand>();

		#endregion

		#region Version Support

		/// <summary>
		/// Determine whether the version of this feature relates to OpenGL ES.
		/// </summary>
		public bool IsEsVersion
		{
			get
			{
				return (Name != null && Regex.IsMatch(Name, "GL_(VERSION_)?ES_.*"));
			}
		}

		/// <summary>
		/// Determine whether the version of this feature relates to OpenGL SC.
		/// </summary>
		public bool IsScVersion
		{
			get
			{
				return (Name != null && Regex.IsMatch(Name, "GL_SC_VERSION_.*"));
			}
		}

		#endregion

		#region IFeature Implementation

		/// <summary>
		/// Get the feature name.
		/// </summary>
		string IFeature.Name
		{
			get { return (Name); }
		}

		/// <summary>
		/// Get the name of the API(s) supporting this IFeature.
		/// </summary>
		string IFeature.Api { get { return (Api); } }

		/// <summary>
		/// Get the name of the API profile supporting this IFeature.
		/// </summary>
		string IFeature.Profile { get { return (null); } }

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		IEnumerable<FeatureCommand> IFeature.Requirements { get { return (Requirements); } }

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

	class FeatureProfile : IFeature
	{
		#region Constructors

		public FeatureProfile(Feature feature, string profile)
			: this(feature, null, profile)
		{
			
		}

		public FeatureProfile(Feature feature, string api, string profile)
		{
			_Feature = feature;
			_Api = api;
			Profile = profile;
		}

		private readonly Feature _Feature;

		public string Api
		{
			get { return (_Api ?? _Feature.Api); }
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
			get { return (_Feature.Name); }
		}

		/// <summary>
		/// Get the name of the API(s) supporting this IFeature.
		/// </summary>
		string IFeature.Api { get { return (Api); } }

		/// <summary>
		/// Get the name of the API profile supporting this IFeature.
		/// </summary>
		string IFeature.Profile { get { return (Profile); } }

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		IEnumerable<FeatureCommand> IFeature.Requirements { get { return (_Feature.Requirements); } }

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
