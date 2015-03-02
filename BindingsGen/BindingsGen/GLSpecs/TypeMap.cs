using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlType("typemap")]
	public class TypeMap
	{
		static TypeMap()
		{
			XmlSerializer typeMapSerializer = new XmlSerializer(typeof(TypeMap));

			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CsTypeMap.xml")) {
				Debug.Assert(stream != null, "stream != null");
				CsTypeMap = (TypeMap)typeMapSerializer.Deserialize(stream);
			}
		}

		public static readonly TypeMap CsTypeMap;

		public class Pair
		{
			[XmlAttribute("name")]
			public String Name;

			[XmlAttribute("value")]
			public String Value;
		}

		[XmlElement("type")]
		public readonly List<Pair> Map = new List<Pair>();

		public string MapType(string type)
		{
			Pair value = Map.Find(delegate(Pair item) { return (item.Name == type); });

			//Debug.Assert(value != null);
			return (value != null ? value.Value : type);
		}

		#region Language Utilities

		public static bool IsCsKeyword(string token)
		{
			foreach (string k in sCsKeywords)
				if (k == token) return (true);
			return (false);
		}

		/// <summary>
		/// C# keywords.
		/// </summary>
		private static readonly string[] sCsKeywords = new string[] {
			"abstract", "event", "new", "struct",
			"as", "explicit", "null", "switch",
			"base", "extern", "object", "this",
			"bool", "false", "operator", "throw",
			"break", "finally", "out", "true",
			"byte",  "fixed", "override", "try",
			"case", "float", "params", "typeof",
			"catch", "for", "private", "uint",
			"char", "foreach", "protected", "ulong",
			"checked", "goto", "public", "unchecked",
			"class", "if", "readonly", "unsafe",
			"const", "implicit", "ref", "ushort",
			"continue", "in", "return", "using",
			"decimal", "int", "sbyte", "virtual",
			"default", "interface", "sealed", "volatile",
			"delegate", "internal", "short", "void",
			"do", "is", "sizeof", "while",
			"double", "lock", "stackalloc", 
			"else", "long", "static", 
			"enum", "namespace", "string", 
		};

		#endregion
	}
}
