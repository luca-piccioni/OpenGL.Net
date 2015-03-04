
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
using System.IO;
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
			SpecSerializer.UnknownAttribute += SpecSerializer_UnknownAttribute;
			SpecSerializer.UnknownElement += SpecSerializer_UnknownElement;
		}

		/// <summary>
		/// Construct a RegistryContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build. It determines:
		/// - The name of the class to be generated (i.e. Gl, Wgl, Glx);
		/// - The features selection to include in the generated sources
		/// </param>
		/// <param name="registryPath">
		/// A <see cref="String"/> that specifies the path of the OpenGL specification to parse.
		/// </param>
		public RegistryContext(string @class, string registryPath)
		{
			// Store the class
			Class = @class;
			// Load and parse OpenGL specification
			using (StreamReader sr = new StreamReader(registryPath)) {
				Registry = ((Registry)SpecSerializer.Deserialize(sr));
				Registry.Link(this);
			}
			// Loads the extension dictionary
			ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			// Loads the words dictionary
			WordsDictionary = SpecWordsDictionary.Load(String.Format("BindingsGen.GLSpecs.{0}Words.xml", @class));
		}

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		public readonly string Class;

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		public readonly Registry Registry;

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
		private static readonly XmlSerializer SpecSerializer = new XmlSerializer(typeof(Registry));
	}
}