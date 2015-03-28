
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
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlRoot("extensions")]
	public class ExtensionIndices
	{
		static ExtensionIndices()
		{
			// Load extension indices
			using (Stream sr = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.ExtIndices.xml")) {
				XmlSerializer serializer = new XmlSerializer(typeof(ExtensionIndices));

				sExtensionIndices = (ExtensionIndices)serializer.Deserialize(sr);
			}

			// Build map
			foreach (Index index in sExtensionIndices.Indices) {
				string extension = index.Extension.Trim();

				if (!Extension.IsArbVendor(extension))
					continue;

				foreach (string extensionItem in Regex.Split(extension, " ")) {
					sExtensionIndices.mIndicesMap.Add(extensionItem, index.IndexValue);
				}
			}

			// Build map
			sVendorExtensionIndices = new ExtensionIndices();
			foreach (Index index in sExtensionIndices.Indices) {
				string extension = index.Extension.Trim();

				if (Extension.IsArbVendor(extension))
					continue;

				foreach (string extensionItem in Regex.Split(extension, " ")) {
					sVendorExtensionIndices.mIndicesMap.Add(extensionItem, index.IndexValue);
				}
			}
		}

		public static void Touch() { }

		public class Index
		{
			[XmlAttribute("index")]
			public int IndexValue;

			[XmlText()]
			public string Extension;
		}

		[XmlElement("extension")]
		public readonly List<Index> Indices = new List<Index>();

		public static int GetIndex(string extension)
		{
			int index;

			if (Extension.IsArbVendor(extension)) {
				if (sExtensionIndices.mIndicesMap.TryGetValue(extension, out index))
					return (index);

				Console.WriteLine("Extension {0} has automatically assigned the index {1}", extension, sUnknownExtensionIndex + 1);

				sExtensionIndices.mIndicesMap.Add(extension, ++sUnknownExtensionIndex);

				return (sUnknownExtensionIndex);
			} else {
				if (sVendorExtensionIndices.mIndicesMap.TryGetValue(extension, out index))
					return (index);

				Console.WriteLine("Extension {0} has automatically assigned the index {1}", extension, sUnknownExtensionIndex + 1);

				sVendorExtensionIndices.mIndicesMap.Add(extension, ++sUnknownExtensionIndex);

				return (sUnknownExtensionIndex);
			}
		}

		private static int sUnknownExtensionIndex = UInt16.MaxValue;

		private readonly Dictionary<string, int> mIndicesMap = new Dictionary<string,int>();

		private static readonly ExtensionIndices sExtensionIndices;

		private static readonly ExtensionIndices sVendorExtensionIndices;
	}
}
