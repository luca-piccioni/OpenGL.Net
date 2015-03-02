
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Each EnumerantGroup defines a single group annotation.
	/// </summary>
	[DebuggerDisplay("EnumerantGroup: Name={Name}")]
	public class EnumerantGroup
	{
		#region Specification

		/// <summary>
		/// Group name, an arbitrary string for grouping a set of enums together within a broader namespace.
		/// </summary>
		[XmlAttribute("name")]
		public String Name;

		/// <summary>
		/// EnumerantGroup may contain zero or more <see cref="Enumerant"/>. Each <see cref="Enumerant"/> tag may contain
		/// only a name attribute, which should correspond to a <see cref="Enumerant"/> definition in an
		/// <see cref="EnumerantBlock"/>.
		/// </summary>
		[XmlElement("enum")]
		public readonly List<Enumerant> Enums = new List<Enumerant>();

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		#endregion

		#region Code Generation

		internal void GenerateSource(SourceStreamWriter sw, RegistryContext ctx)
		{
			if (sw == null)
				throw new ArgumentNullException("sw");
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			bool bitmask = Enums.TrueForAll(delegate(Enumerant item) {
				Enumerant actualEnumerant = ctx.Registry.GetGlEnumerant(item.Name);

				return (actualEnumerant.ParentEnumerantBlock.Type == "bitmask");
			});

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// Strongly typed enumeration {0}.", Name);
			sw.WriteLine("/// </summary>");
			if (bitmask)
				sw.WriteLine("[Flags()]");
			sw.WriteLine("public enum {0}{1}", Name, bitmask ? " : uint" : String.Empty);
			sw.WriteLine("{");
			sw.Indent();
			foreach (Enumerant enumerant in Enums) {
				string camelCase = SpecificationStyle.GetCamelCase(enumerant.ImplementationName);
				string bindingName = enumerant.ImplementationName;

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Strongly typed for value {0}.", enumerant.Name);
				sw.WriteLine("/// </summary>");
				sw.WriteLine("{0} = Gl.{1},", camelCase, bindingName);
				sw.WriteLine();
			}
			sw.Unindent();
			sw.WriteLine("}");
		}

		#endregion
	}
}
