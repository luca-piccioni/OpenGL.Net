
// Copyright (C) 2017 Luca Piccioni
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

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace BindingsGen
{
	/// <summary>
	/// Configuration for <see cref="RegistryAssembly"/>.
	/// </summary>
	[XmlRoot("RegistryAssemblyConfiguration")]
	[XmlType("RegistryAssemblyConfiguration")]
	public class RegistryAssemblyConfiguration
	{
		#region API Matching

		/// <summary>
		/// The configuration name.
		/// </summary>
		[XmlAttribute("Name")]
		public string Name;

		/// <summary>
		/// Range of version of a specific API.
		/// </summary>
		[XmlType("VersionRange")]
		public class VersionRange
		{
			/// <summary>
			/// API to be implemented.
			/// </summary>
			[XmlAttribute("Api")]
			public string Api;

			/// <summary>
			/// Regular expression for matching specific profile.
			/// </summary>
			[XmlAttribute("Profile")]
			public string Profile;
		}

		/// <summary>
		/// Features
		/// </summary>
		[XmlElement("Feature")]
		public readonly List<VersionRange> Features = new List<VersionRange>();

		/// <summary>
		/// Extesion to be implemented.
		/// </summary>
		[XmlArray("Extensions")]
		[XmlArrayItem("Extension")]
		public readonly List<string> Extensions = new List<string>();

		#endregion

		#region Platform API Matching

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("PlatformApi")]
		[DefaultValue(DefaultPlatformApi)]
		public string PlatformApi = DefaultPlatformApi;

		/// <summary>
		/// Default value for <see cref="PlatformApi"/>.
		/// </summary>
		private const string DefaultPlatformApi = "wgl|glx|egl";

		#endregion

		#region Resource Loading

		public static RegistryAssemblyConfiguration Load(string path)
		{
			using (Stream sr = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)) {
				XmlSerializer serializer = new XmlSerializer(typeof(RegistryAssemblyConfiguration));

				return ((RegistryAssemblyConfiguration)serializer.Deserialize(sr));
			}
		}

		#endregion
	}
}
