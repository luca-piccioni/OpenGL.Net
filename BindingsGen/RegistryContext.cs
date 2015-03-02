
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
	public class RegistryContext
	{
		static RegistryContext()
		{
			SpecSerializer.UnknownAttribute += SpecSerializer_UnknownAttribute;
			SpecSerializer.UnknownElement += SpecSerializer_UnknownElement;
		}

		public RegistryContext(string @class, string registryPath)
		{
			Class = @class;
			using (StreamReader sr = new StreamReader(registryPath)) {
				Registry = ((Registry)SpecSerializer.Deserialize(sr));
				Registry.Link();
			}
			ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			WordsDictionary = SpecWordsDictionary.Load(String.Format("BindingsGen.GLSpecs.{0}Words.xml", @class));
		}

		public readonly string Class;

		public readonly Registry Registry;

		/// <summary>
		/// 
		/// </summary>
		public readonly SpecWordsDictionary ExtensionsDictionary;

		/// <summary>
		/// 
		/// </summary>
		public readonly SpecWordsDictionary WordsDictionary;

		static void SpecSerializer_UnknownElement(object sender, XmlElementEventArgs e)
		{
			if (e.Element.Name == "unused")
				return;
			Console.WriteLine("Unknown element {0} at {1}:{2}.", e.Element.Name, e.LineNumber, e.LinePosition);
		}

		static void SpecSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
		{
			Console.WriteLine("Unknown attribute {0} at {1}:{2}.", e.Attr.Name, e.LineNumber, e.LinePosition);
		}

		private static readonly XmlSerializer SpecSerializer = new XmlSerializer(typeof(Registry));
	}
}