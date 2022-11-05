
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
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Registry enumerant.
	/// </summary>
	[DebuggerDisplay("Enumerant: Name={Name} Value={Value} Api={Api} Type={Type} Alias={Alias}")]
	public class Enumerant
	{
		#region Specification

		/// <summary>
		/// Enumerant name, a legal C preprocessor token name.
		/// </summary>
		[XmlAttribute("name")]
		public string Name;

		/// <summary>
		/// Enumerant value, a legal C constant (usually a hexadecimal integer).
		/// </summary>
		[XmlAttribute("value")]
		public string Value;

		/// <summary>
		/// An API name which specializes this definition of the named enum, so that different APIs may
		/// have different values for the same token (used to address a few accidental incompatibilities
		/// between GL and GL ES).
		/// </summary>
		[XmlAttribute("api")]
		public string Api;

		/// <summary>
		/// A legal C suffix for the value to force it to a specific type. Currently only u and ull are used,
		/// for unsigned 32- and 64-bit integer values, respectively. Separated from the value field since this
		/// eases parsing and sorting of values, and is rarely used.
		/// </summary>
		[XmlAttribute("type")]
		public string Type;

		/// <summary>
		/// A name of another enumerant this is an alias of, used where token names have been changed as a result
		/// of profile changes or for consistency purposes. An enumerant alias is simply a different name for the
		/// exact same value. At present, enumerants which are promoted from extension to core API status are not
		/// tagged as aliases - just enumerants tagged as aliases in the Changed Tokens sections of appendices to
		/// the OpenGL Specification. This might change in the future.
		/// </summary>
		[XmlAttribute("alias")]
		public string Alias;

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public string Command;

		/// <summary>
		/// The group(s) which this enumeration belongs to.
		/// </summary>
		public string[] Groups
		{
			get
			{
				return Group != null ? Regex.Split(Group, ",") : null;
			}
		}

		/// <summary>
		/// The group(s) which this enumeration belongs to.
		/// </summary>
		[XmlAttribute("group")]
		public string Group;

		#endregion

		#region Utilities

		public string Vendor
		{
			get
			{
				return (GetVendor(Name));
			}
		}

		public static string GetVendor(string enumerantName)
		{
			Match vendorMatch = Regex.Match(enumerantName, @"^.*_(?<Vendor>[A-Z0-9]+)$");

			if (vendorMatch.Success == false)
				throw new NotSupportedException();

			return (vendorMatch.Groups["Vendor"].Value);
		}

		public static bool IsArbVendor(string enumerantName)
		{
			switch (Extension.GetVendor(enumerantName)) {
				case "ARB":
				case "KHR":
					return (true);
				default:
					return (false);
			}
		}

		#endregion

		#region Promotion and Deprecation

		/// <summary>
		/// Enumerant alias (EnumAlias overrides this Enumerant).
		/// </summary>
		[XmlIgnore]
		public Enumerant EnumAlias;

		/// <summary>
		/// Symbols aliased (AliasOf[*] are overriden by this Enumerant).
		/// </summary>
		[XmlIgnore]
		public readonly List<Enumerant> AliasOf = new List<Enumerant>();

		/// <summary>
		/// Determine whether this enumerant is deprecated.
		/// </summary>
		public bool IsDeprecated
		{
			get { return (RemovedBy.Count > 0); }
		}

		#endregion

		#region Information Linkage

		/// <summary>
		/// Link other information against this enumerant.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> holding the registry information to link.
		/// </param>
		internal void Link(RegistryContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			RequiredBy.Clear();
			RequiredBy.AddRange(GetFeaturesRequiringEnum(ctx));

			RemovedBy.Clear();
			RemovedBy.AddRange(GetFeaturesRemovingEnum(ctx));
		}

		/// <summary>
		/// Get a list of <see cref="IFeature"/> requiring this enumerant.
		/// </summary>
		/// <param name="registry">
		///  A <see cref="Registry"/> holding the registry information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:IEnumerable{IFeature}"/> listing all features requiring this enumerant.
		/// </returns>
		private IEnumerable<IFeature> GetFeaturesRequiringEnum(RegistryContext ctx)
		{
			List<IFeature> features = new List<IFeature>();

			// Features
			foreach (Feature feature in ctx.Registry.Features) {
				if (feature.Api != null && !ctx.IsSupportedApi(feature.Api))
					continue;

				int requirementIndex = feature.Requirements.FindIndex(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Enums.FindIndex(delegate(FeatureCommand.Item subitem) {
						return (subitem.Name == Name);
					});

					return (enumIndex != -1);
				});

				if (requirementIndex != -1)
					features.Add(feature);
			}

			// Extensions
			foreach (Extension extension in ctx.Registry.Extensions) {
				if (extension.Supported != null && !ctx.IsSupportedApi(extension.Supported))
					continue;

				int requirementIndex = extension.Requirements.FindIndex(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Enums.FindIndex(delegate(FeatureCommand.Item subitem) {
						return (subitem.Name == Name);
					});

					return (enumIndex != -1);
				});

				if (requirementIndex != -1)
					features.Add(extension);
			}

			return (features);
		}

		/// <summary>
		/// Get a list of <see cref="IFeature"/> removing this enumerant.
		/// </summary>
		/// <param name="registry">
		///  A <see cref="Registry"/> holding the registry information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:IEnumerable{IFeature}"/> listing all features removing this enumerant.
		/// </returns>
		private IEnumerable<IFeature> GetFeaturesRemovingEnum(RegistryContext ctx)
		{
			List<IFeature> features = new List<IFeature>();

			// Features
			foreach (Feature feature in ctx.Registry.Features) {
				if (feature.Api != null && !ctx.IsSupportedApi(feature.Api))
					continue;

				int requirementIndex = feature.Removals.FindIndex(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Enums.FindIndex(delegate(FeatureCommand.Item subitem) {
						return (subitem.Name == Name);
					});

					return (enumIndex != -1);
				});

				if (requirementIndex != -1)
					features.Add(feature);
			}

			return (features);
		}

		/// <summary>
		/// List of <see cref="IFeature"/> that requires this Enumerant.
		/// </summary>
		[XmlIgnore]
		public readonly List<IFeature> RequiredBy = new List<IFeature>();

		/// <summary>
		/// List of <see cref="IFeature"/> that removes this Enumerant.
		/// </summary>
		[XmlIgnore]
		public readonly List<IFeature> RemovedBy = new List<IFeature>();

		/// <summary>
		/// Parent <see cref="EnumerantBlock"/> defining this Enumerant.
		/// </summary>
		internal EnumerantBlock ParentEnumerantBlock;

		#endregion

		#region Code Generation

		/// <summary>
		/// Generate the C# source code for this enumerant.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		internal void GenerateSource(SourceStreamWriter sw, RegistryContext ctx)
		{
			if (sw == null)
				throw new ArgumentNullException(nameof(sw));

			GenerateDocumentation(sw, ctx);

			GenerateRequirements(sw, ctx);

			// This metadata is used for procedure logging function
			bool requiresLogAttribute = ParentEnumerantBlock.Type == "bitmask";

			if (requiresLogAttribute == true) {
				if (ParentEnumerantBlock.Type == "bitmask")
					sw.WriteLine("[Log(BitmaskName = \"{0}\")]", ParentEnumerantBlock.Namespace);
			}

			//if (IsDeprecated) {
			//	sw.Write("#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE" + Environment.NewLine);
			//	sw.WriteLine("[Obsolete(\"Deprecated/removed by {0}.\")]", SpecificationStyle.GetKhronosVersionHumanReadable(RemovedBy[0].Name));
			//	sw.Write("#endif" + Environment.NewLine);
			//}

			sw.WriteLine(Declaration);
		}

		internal void GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx)
		{
			if (ctx.RefPages.Count > 0)
				ctx.RefPages.GenerateDocumentation(sw, ctx, this);
		}

		internal void GenerateRequirements(SourceStreamWriter sw, RegistryContext ctx)
		{
			string classDefaultApi = ctx.Class.ToLower();

			List<IFeature> requiredByFeatures = RequiredBy;
			foreach (Enumerant aliasOf in AliasOf)
				requiredByFeatures = requiredByFeatures.Union(aliasOf.RequiredBy).ToList();

			foreach (IFeature feature in requiredByFeatures)
				sw.WriteLine(feature.GenerateRequiredByAttribute(null, classDefaultApi));
			
			foreach (IFeature feature in RemovedBy)
				sw.WriteLine(feature.GenerateRemovedByAttribute(classDefaultApi));
		}

		/// <summary>
		/// Get the actual enumerant implementation name.
		/// </summary>
		public string ImplementationName
		{
			get
			{
				if (Name == null)
					throw new InvalidOperationException("missing specification");
				return (SpecificationStyle.GetEnumBindingName(Name));
			}
		}

		public string DeclarationType
		{
			get
			{
				if (Value == null)
					throw new InvalidOperationException("missing specification");

				string type, value = Value;

				// Remove trailing \r
				value = value.TrimEnd('\r');
				// Remove parenthesis
				if (value.StartsWith("(") && value.EndsWith(")"))
					value = value.Substring(1, value.Length - 2);

				if (value.StartsWith("0x")) {
					if ((value.Length > 10) || (value.EndsWith("ull"))) {       // 0xXXXXXXXXXXull
						type = "ulong";
					} else if (Regex.IsMatch(value, @"0x\w{8}") && (Name.Contains("_BIT") || Name.Contains("_MASK"))) {
						type = "uint";
					} else if (Regex.IsMatch(value, @"0x\w{8}") && ImplementationName.StartsWith("SWAP_")) {
						type = "uint";
					} else if (Regex.IsMatch(value, @"0x[8F]\w{7}")) {
						type = "uint";
					} else {                                                    // 0xXXXX
						type = "int";
					}
				} else if (value.EndsWith("u")) {
					type = "uint";
				} else if (value.EndsWith("f")) {
					type = "float";
				} else if (value.StartsWith("\"")) {
					type = "string";
				} else {
					type = "int";
				}

				return type;
			}
		}

		private string DeclarationValue
		{
			get
			{
				if (Value == null)
					throw new InvalidOperationException("missing specification");

				string value = Value;

				// Remove trailing \r
				value = value.TrimEnd('\r');
				// Remove parenthesis
				if (value.StartsWith("(") && value.EndsWith(")"))
					value = value.Substring(1, value.Length - 2);

				if (value.StartsWith("0x")) {
					if ((value.Length > 10) || (value.EndsWith("ull"))) {       // 0xXXXXXXXXXXull
						value = value.Substring(0, value.Length - 3);
					}
				}

				// Patterns
				Match castMatch;

				if ((castMatch = Regex.Match(value, @"\(\([\w\d_]+\)\(?(?<value>(\+|\-)?[\d\.]+)\)?\)")).Success)
					value = castMatch.Groups["value"].Value;

				if ((castMatch = Regex.Match(value, @"\([\w\d_]+\)\(?(?<value>(\+|\-)?[\d\.]+f?)\)?")).Success)
					value = castMatch.Groups["value"].Value;

				return value;
			}
		}

		/// <summary>
		/// Get the actual enumerant declaration.
		/// </summary>
		private string Declaration
		{
			get
			{
				if (Value == null)
					throw new InvalidOperationException("missing specification");

				return $"public const {DeclarationType} {ImplementationName} = {DeclarationValue};";
			}
		}

		#endregion
	}
}
