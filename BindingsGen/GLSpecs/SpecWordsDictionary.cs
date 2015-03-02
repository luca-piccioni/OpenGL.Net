
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
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlRoot("words")]
	public class SpecWordsDictionary
	{
		public static SpecWordsDictionary Load(string path)
		{
			using (Stream sr = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)) {
				XmlSerializer serializer = new XmlSerializer(typeof(SpecWordsDictionary));

				return ((SpecWordsDictionary)serializer.Deserialize(sr));
			}
		}

		/// <summary>
		/// Words dictionary.
		/// </summary>
		[XmlElement("word")]
		public readonly List<string> Words = new List<string>();

		public bool HasWord(string word)
		{
			return (Words.Contains(word));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="specificationName"></param>
		/// <returns></returns>
		public string GetOverridableName(RegistryContext ctx, string specificationName)
		{
			if (String.IsNullOrEmpty(specificationName))
				throw new ArgumentNullException("specificationName");

			// Extract extension
			string nameExtension = null;

			foreach (string word in ctx.ExtensionsDictionary.Words) {
				if (specificationName.EndsWith(word)) {
					nameExtension = word;
					break;
				}
			}

			if (nameExtension != null)
				specificationName = specificationName.Substring(0, specificationName.Length - nameExtension.Length);

			string postfix = specificationName;

			foreach (string word in Words) {
				postfix = postfix.Replace(word, String.Empty);

				if (postfix.Length == 0)
					break;
			}

			if ((postfix.Length > 0) && specificationName.EndsWith(postfix) && (ctx.ExtensionsDictionary.HasWord(postfix) == false))
				specificationName = specificationName.Substring(0, specificationName.Length - postfix.Length);

			if (nameExtension != null)
				specificationName += nameExtension;

			return (specificationName);
		}
	}
}
