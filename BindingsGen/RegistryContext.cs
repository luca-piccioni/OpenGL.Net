
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL specification context.
	/// </summary>
	public class RegistryContext
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryContext()
		{
			_SpecSerializer.UnknownAttribute += SpecSerializer_UnknownAttribute;
			_SpecSerializer.UnknownElement += SpecSerializer_UnknownElement;
		}

		/// <summary>
		/// Construct a RegistryContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build. It determines:
		/// - The name of the class to be generated (i.e. Gl, Wgl, Glx);
		/// - The features selection to include in the generated sources
		/// </param>
		/// <param name="wordsClass">
		/// A <see cref="String"/> that specifies the name of the words dictionary used for semplifying
		/// names in this context. If it is null, it is automatically determined with <paramref name="class"/>.
		/// </param>
		private RegistryContext(string @class, string wordsClass)
		{
			// Store the class
			Class = @class;
			// Set supported APIs
			List<string> apis = new List<string> { Class.ToLower() };

			if (Class == "Gl") {
				// No need to add glcore, since gl is still a superset of glcore
				// apis.Add("glcore");
				// Support GS ES 1/2
				apis.Add("gles1");
				apis.Add("gles2");
				apis.Add("glsc2");
			}

			SupportedApi = apis.ToArray();
			// Loads the extension dictionary
			ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			// Loads the words dictionary
			WordsDictionary = SpecWordsDictionary.Load($"BindingsGen.GLSpecs.{wordsClass ?? @class}Words.xml");
		}

		/// <summary>
		/// Construct a RegistryContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build. It determines:
		/// - The name of the class to be generated (i.e. Gl, Wgl, Glx);
		/// - The features selection to include in the generated sources
		/// </param>
		/// <param name="wordsClass">
		/// A <see cref="String"/> that specifies the name of the words dictionary used for semplifying
		/// names in this context. If it is null, it is automatically determined with <paramref name="class"/>.
		/// </param>
		/// <param name="registryPath">
		/// A <see cref="String"/> that specifies the path of the OpenGL specification to parse.
		/// </param>
		public RegistryContext(string @class, string wordsClass, string registryPath) :
			this(@class, wordsClass)
		{
			using (StreamReader sr = new StreamReader(registryPath)) {
				Registry specRegistry = (Registry)_SpecSerializer.Deserialize(sr);
				Registry = specRegistry;
				specRegistry.Link(this);

				Registry = specRegistry;
			}
		}

		/// <summary>
		/// Construct a RegistryContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build. It determines:
		/// - The name of the class to be generated (i.e. Gl, Wgl, Glx);
		/// - The features selection to include in the generated sources
		/// </param>
		/// <param name="wordsClass">
		/// A <see cref="String"/> that specifies the name of the words dictionary used for semplifying
		/// names in this context. If it is null, it is automatically determined with <paramref name="class"/>.
		/// </param>
		/// <param name="registry">
		/// A <see cref="IRegistry"/> that specifies the elements of the OpenGL specification.
		/// </param>
		public RegistryContext(string @class, string wordsClass, IRegistry registry) :
			this(@class, wordsClass)
		{
			Registry = registry;
		}

		/// <summary>
		/// Determine whether an API element is supported by the generated class.
		/// </summary>
		/// <param name="api">
		/// A <see cref="String"/> that specify the regular expression of the API element to be evaluated.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="api"/> specify a supported API.
		/// </returns>
		public bool IsSupportedApi(string api)
		{
			if (api == null)
				throw new ArgumentNullException(nameof(api));

			string regexApi = $"^{api}$";

			return SupportedApi.Any(supportedApi => Regex.IsMatch(supportedApi, regexApi));
		}

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		public readonly string Class;

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		public readonly string[] SupportedApi;

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		public readonly IRegistry Registry;

		/// <summary>
		/// The Khronos reference pages.
		/// </summary>
		internal readonly List<IRegistryDocumentation> RefPages = new List<IRegistryDocumentation>();

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		public readonly SpecWordsDictionary ExtensionsDictionary;

		/// <summary>
		/// The words dictionary.
		/// </summary>
		public readonly SpecWordsDictionary WordsDictionary;

		/// <summary>
		/// Notify about unknown OpenGL specification elements.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="XmlSerializer"/> parsing the OpenGL specification.
		/// </param>
		/// <param name="e">
		/// A <see cref="XmlElementEventArgs"/> that specifies the event arguments.
		/// </param>
		private static void SpecSerializer_UnknownElement(object sender, XmlElementEventArgs e)
		{
			if (e.Element.Name == "unused")
				return;
			Console.WriteLine("Unknown element {0} at {1}:{2}.", e.Element.Name, e.LineNumber, e.LinePosition);
		}

		/// <summary>
		/// Notify about unknown OpenGL specification attributes.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="XmlSerializer"/> parsing the OpenGL specification.
		/// </param>
		/// <param name="e">
		/// A <see cref="XmlAttributeEventArgs"/> that specifies the event arguments.
		/// </param>
		private static void SpecSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
		{
			Console.WriteLine("Unknown attribute {0} at {1}:{2}.", e.Attr.Name, e.LineNumber, e.LinePosition);
		}

		/// <summary>
		/// OpenGL specification parser.
		/// </summary>
		private static readonly XmlSerializer _SpecSerializer = new XmlSerializer(typeof(Registry));
	}
}