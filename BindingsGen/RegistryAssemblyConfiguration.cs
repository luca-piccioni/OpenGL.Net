
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
		[XmlElement("Name")]
		public string Name;

		/// <summary>
		/// Minimum version of the API to be implemented.
		/// </summary>
		[XmlElement("MinApiVersion")]
		public string MinApiVersion;

		/// <summary>
		/// Maximum version of the API to be implemented.
		/// </summary>
		[XmlElement("MinApiVersion")]
		public string MaxApiVersion;

		/// <summary>
		/// API to be implemented.
		/// </summary>
		[XmlElement("MinApiVersion")]
		public string Api;

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
	}
}
