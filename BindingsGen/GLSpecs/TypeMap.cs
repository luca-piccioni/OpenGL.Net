
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Maps names/value pairs.
	/// </summary>
	[XmlType("typemap")]
	public class TypeMap
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static TypeMap()
		{
			XmlSerializer typeMapSerializer = new XmlSerializer(typeof(TypeMap));

			// Load C# type mapping
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CsTypeMap.xml")) {
				Debug.Assert(stream != null, "stream != null");
				CsTypeMap = (TypeMap)typeMapSerializer.Deserialize(stream);
			}
		}

		#endregion

		#region Type Map

		/// <summary>
		/// Pair associating a value to a name.
		/// </summary>
		public class Pair
		{
			/// <summary>
			/// The name of the pair.
			/// </summary>
			[XmlAttribute("name")]
			public String Name;

			/// <summary>
			/// The value associated to <see cref="Name"/>.
			/// </summary>
			[XmlAttribute("value")]
			public String Value;

			/// <summary>
			/// The base type actually used instead of <see cref="Value"/>.
			/// </summary>
			[XmlAttribute("base")]
			public String BaseType;
		}

		/// <summary>
		/// The pairs.
		/// </summary>
		[XmlElement("type")]
		public readonly List<Pair> Map = new List<Pair>();

		/// <summary>
		/// Get the value associated to a registered name.
		/// </summary>
		/// <param name="type">
		/// A <see cref="String"/> that specifies the name to map.
		/// </param>
		/// <returns>
		/// It returns the value corresponding to <paramref name="type"/> in the case it is known, otherwise
		/// it returns <paramref name="type"/>.
		/// </returns>
		public string MapType(string type)
		{
			return (MapType(type, true));
		}

		/// <summary>
		/// Get the value associated to a registered name.
		/// </summary>
		/// <param name="type">
		/// A <see cref="String"/> that specifies the name to map.
		/// </param>
		/// <returns>
		/// It returns the value corresponding to <paramref name="type"/> in the case it is known, otherwise
		/// it returns <paramref name="type"/>.
		/// </returns>
		public string MapType(string type, bool @base)
		{
			Pair value = Map.Find(delegate(Pair item) { return (item.Name == type); });

			if (value != null) {
				if (@base)
					return (value.BaseType ?? value.Value);
				else
					return (value.Value);
			} else
				return (type);
		}

		#endregion

		#region C# Language Utilities

		/// <summary>
		/// C# type mapping.
		/// </summary>
		public static readonly TypeMap CsTypeMap;

		/// <summary>
		/// Determine whether a token is a reserved C# word.
		/// </summary>
		/// <param name="token">
		/// A <see cref="String"/> that specifies the token to be asserted.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="token"/> is a reserved C# word.
		/// </returns>
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
