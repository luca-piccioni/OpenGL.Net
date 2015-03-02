using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlRoot("map")]
	public class SpecTokensDictionary
	{
		public class Token
		{
			[XmlAttribute("src")]
			public String Source;

			[XmlAttribute("dst")]
			public String Destination;
		}

		public static SpecTokensDictionary Load(string path)
		{
			using (Stream sr = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)) {
				XmlSerializer serializer = new XmlSerializer(typeof(SpecTokensDictionary));

				return ((SpecTokensDictionary)serializer.Deserialize(sr));
			}
		}

		/// <summary>
		/// Words dictionary.
		/// </summary>
		[XmlElement("token")]
		public readonly List<Token> Words = new List<Token>();
	}
}
