
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
using System.Text;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Each EnumerantGroup defines a single group annotation.
	/// </summary>
	[DebuggerDisplay("EnumerantGroup: Name={" + nameof(Name) + "}")]
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
				throw new ArgumentNullException(nameof(sw));
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			bool bitmask = Enums.TrueForAll(delegate(Enumerant item) {
				Enumerant actualEnumerant = ctx.Registry.GetEnumerant(item.Name);

				return (actualEnumerant == null || actualEnumerant.ParentEnumerantBlock.Type == "bitmask");
			});

			// Collect group enumerants by their value
			Dictionary<string, List<Enumerant>> groupEnums = new Dictionary<string, List<Enumerant>>();

			// ...include all enums defined in this group
			foreach (Enumerant item in Enums) {
				Enumerant itemValue = ctx.Registry.GetEnumerant(item.Name);

				if (itemValue != null) {
					if (!groupEnums.ContainsKey(itemValue.Value))
						groupEnums.Add(itemValue.Value, new List<Enumerant>());
					groupEnums[itemValue.Value].Add(itemValue);
				}
			}

			// Modify canonical enumeration (value/block/group) definition
			CommandFlagsDatabase.EnumerantItem enumerantExtension = CommandFlagsDatabase.FindEnumerant(Name);

			if (enumerantExtension != null) {
				// ...override group information
				if (enumerantExtension.Type != null) {
					switch (enumerantExtension.Type) {
						case "bitmask":
							bitmask = true;
							break;
					}
				}

				// ...include all enums to be added by additional configuration
				foreach (string addedEnum in enumerantExtension.AddEnumerants) {
					Enumerant addedEnumValue = ctx.Registry.GetEnumerant(addedEnum);

					if (addedEnumValue != null) {
						if (!groupEnums.ContainsKey(addedEnumValue.Value))
							groupEnums.Add(addedEnumValue.Value, new List<Enumerant>());

						// Note: since specification can be updated while the CommandFlags.xml is not in synch, the specification
						// may defined missed enumerant values. In this case do not add enumerant value
						if (groupEnums[addedEnumValue.Value].Contains(addedEnumValue) == false)
							groupEnums[addedEnumValue.Value].Add(addedEnumValue);
					}
				}
			}

			// Make enumerants distinct (discard duplicated enumerants, mainly from extensions _ARB, _EXT, ...)
			List<Enumerant> uniqueEnums = new List<Enumerant>();

			foreach (KeyValuePair<string, List<Enumerant>> pair in groupEnums) {
				if (pair.Value.Count > 1) {
					List<Enumerant> uniqueNames = new List<Enumerant>();

					foreach (Enumerant item in pair.Value) {
						if (item.Alias != null)
							continue;
						if (item.EnumAlias != null)
							continue;
						if (uniqueNames.FindIndex(delegate(Enumerant item1) { return (item.Name.StartsWith(item1.Name)); }) >= 0)
							continue;

						if (uniqueNames.FindIndex(delegate(Enumerant item1) { return (item1.Name.StartsWith(item.Name)); }) >= 0)
							uniqueNames.RemoveAll(delegate(Enumerant item1) { return (item1.Name.StartsWith(item.Name)); });

						uniqueNames.Add(item);
					}

					uniqueEnums.AddRange(uniqueNames);
				} else
					uniqueEnums.AddRange(pair.Value);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// Strongly typed enumeration {0}.", Name);
			sw.WriteLine("/// </summary>");
			if (bitmask)
				sw.WriteLine("[Flags()]");
			sw.WriteLine("public enum {0}{1}", Name, bitmask ? " : uint" : String.Empty);
			sw.WriteLine("{");
			sw.Indent();
			foreach (Enumerant enumerant in uniqueEnums) {
				List<Enumerant> allEnums = groupEnums[enumerant.Value];
				string bindingName = enumerant.EnumAlias == null ? enumerant.ImplementationName : enumerant.EnumAlias.ImplementationName;
				string camelCase = SpecificationStyle.GetCamelCase(bindingName);

				if (enumerantExtension != null && enumerantExtension.ItemPrefix != null && camelCase.StartsWith(enumerantExtension.ItemPrefix))
					camelCase = camelCase.Substring(enumerantExtension.ItemPrefix.Length);

				sw.WriteLine("/// <summary>");
				if (allEnums.Count > 1) {
					StringBuilder sb = new StringBuilder();

					sb.Append("Strongly typed for value ");
					for (int i = 0; i < allEnums.Count; i++) {
						sb.Append(allEnums[i].Name);
						if (i < allEnums.Count - 1)
							sb.Append(", ");
					}
					sb.Append(".");

					foreach (string docLine in RegistryDocumentation.SplitDocumentationLines(sb.ToString()))
						sw.WriteLine("/// {0}", docLine);
				} else
					sw.WriteLine("/// Strongly typed for value {0}.", enumerant.Name);
				sw.WriteLine("/// </summary>");

				Enumerant enumvalue = ctx.Registry.GetEnumerant(ctx.Class.ToUpperInvariant() + "_" + bindingName);
				string classDefaultApi = ctx.Class.ToLower();

				if (enumvalue != null) {
					// RequiredByFeature
					foreach (IFeature feature in enumvalue.RequiredBy)
						sw.WriteLine(feature.GenerateRequiredByAttribute(null, classDefaultApi));
					// RequiredByFeature (from aliases) Note: not sure that Profile is considered here
					foreach (Enumerant aliasOf in enumvalue.AliasOf) {
						foreach (IFeature feature in aliasOf.RequiredBy)
							sw.WriteLine(feature.GenerateRequiredByAttribute(null, classDefaultApi));
					}
					// RemovedByFeature
					foreach (IFeature feature in enumvalue.RemovedBy)
						sw.WriteLine(feature.GenerateRemovedByAttribute(classDefaultApi));
				}

				sw.WriteLine("{0} = {1}.{2},", camelCase, ctx.Class, bindingName);
				sw.WriteLine();
			}
			sw.Unindent();
			sw.WriteLine("}");
		}

		#endregion
	}
}
