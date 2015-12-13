
// Copyright (C) 2011-2012 Luca Piccioni
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
using System.Reflection;
using System.Xml.Serialization;

namespace OpenGL
{
	[XmlType("Licence")]
	public class ShaderLibraryLicence
	{
		[XmlAttribute("Id")]
		public string Id;

		[XmlText()]
		public string LicenceText;
	}

	/// <summary>
	/// A shader library configuration.
	/// </summary>
	[XmlType("ShaderLibrary")]
	public class ShaderLibraryConfiguration
	{
		/// <summary>
		/// The path where the configuration were loaded (absolute path).
		/// </summary>
		/// <remarks>
		/// This field is the absolute path used for loading this ShaderLibraryConfiguration.
		/// </remarks>
		[XmlIgnore()]
		public string ConfigurationPath;

		/// <summary>
		/// Last modification date.
		/// </summary>
		[XmlIgnore()]
		public DateTime ModificationDate = DateTime.MaxValue;

		/// <summary>
		/// The namespace of the generated C# source.
		/// </summary>
		[XmlAttribute("CodeNamespace")]
		public string CodeNamespace;

		/// <summary>
		/// List of shader configuration modules.
		/// </summary>
		[XmlElement("Module")]
		public ShaderLibraryModule[] Modules;

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("Licence")]
		public List<ShaderLibraryLicence> Licences = new List<ShaderLibraryLicence>();

		public string GetLicenceText(string id)
		{
			ShaderLibraryLicence libraryLicence = Licences.Find(delegate(ShaderLibraryLicence licence) { return licence.Id == id; });

			if (libraryLicence != null)
				return (libraryLicence.LicenceText);

			return (null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="identifier"></param>
		/// <returns></returns>
		public ShaderLibraryObject GetObject(string identifier)
		{
			foreach (ShaderLibraryModule module in Modules) {
				foreach (ShaderLibraryObject shaderObject in module.ShaderObjects) {
					if (shaderObject.ClassName == identifier)
						return (shaderObject);
				}
			}

			return (null);
		}

		public IEnumerable<ShaderLibraryObject>  Objects
		{
			get
			{
				List<ShaderLibraryObject> objects = new List<ShaderLibraryObject>();

				foreach (ShaderLibraryModule module in Modules)
					objects.AddRange(module.ShaderObjects);

				return (objects);
			}
		}

		/// <summary>
		/// Generate shader library source code.
		/// </summary>
		public void Generate()
		{
			Generate(new ShaderLibraryConfiguration[] { this });
		}

		/// <summary>
		/// Generate shader library source code.
		/// </summary>
		/// <param name="libraries">
		/// A collection of libraries used for cross-referencing shader library objects.
		/// </param>
		public void Generate(IEnumerable<ShaderLibraryConfiguration> libraries)
		{
			if (libraries == null)
				throw new ArgumentNullException("libraries");
			if ((Modules == null) || (Modules.Length == 0))
				throw new InvalidOperationException("no modules in library");
			if (String.IsNullOrEmpty(ConfigurationPath))
				throw new InvalidOperationException("no path defined");

			string currentDirectory = Directory.GetCurrentDirectory();
			string libraryDirectory = Path.GetDirectoryName(ConfigurationPath);

			if (String.IsNullOrEmpty(libraryDirectory))
				throw new InvalidOperationException("no directory name");

			// Change current directory to base configuration directory
			Directory.SetCurrentDirectory(libraryDirectory);

			foreach (ShaderLibraryModule shaderModule in Modules) {
				if (String.IsNullOrEmpty(shaderModule.CodeNamespace))
					shaderModule.CodeNamespace = CodeNamespace;

				shaderModule.Generate(this, libraries, true);
			}

			// Restore application working directory
			Directory.SetCurrentDirectory(currentDirectory);
		}

		/// <summary>
		/// Load a shader library configuration.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static ShaderLibraryConfiguration Load(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			ShaderLibraryConfiguration configuration;

			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				configuration = (ShaderLibraryConfiguration)sShaderLibrarySerializer.Deserialize(fs);
			}

			// Additional information: configuration path
			configuration.ConfigurationPath = Path.GetFullPath(path);
			// Additional information: last modification date
			configuration.ModificationDate = new FileInfo(path).LastWriteTime;

			return (configuration);
		}

		/// <summary>
		/// Save a shader library configuration.
		/// </summary>
		/// <param name="configuration"></param>
		public static void Save(ShaderLibraryConfiguration configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException("configuration");
			if (String.IsNullOrEmpty(configuration.ConfigurationPath))
				throw new ArgumentException("no path defined", "configuration");

			using (FileStream fs = new FileStream(configuration.ConfigurationPath, FileMode.Create, FileAccess.Write)) {
				sShaderLibrarySerializer.Serialize(fs, configuration);
			}
		}

		/// <summary>
		/// XML serializer for ShaderLibraryConfiguration.
		/// </summary>
		private static readonly XmlSerializer sShaderLibrarySerializer = new XmlSerializer(typeof(ShaderLibraryConfiguration));

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
	}
}
