
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
		public String Name;

		/// <summary>
		/// Enumerant value, a legal C constant (usually a hexadecimal integer).
		/// </summary>
		[XmlAttribute("value")]
		public String Value;

		/// <summary>
		/// An API name which specializes this definition of the named enum, so that different APIs may
		/// have different values for the same token (used to address a few accidental incompatibilities
		/// between GL and GL ES).
		/// </summary>
		[XmlAttribute("api")]
		public String Api;

		/// <summary>
		/// A legal C suffix for the value to force it to a specific type. Currently only u and ull are used,
		/// for unsigned 32- and 64-bit integer values, respectively. Separated from the value field since this
		/// eases parsing and sorting of values, and is rarely used.
		/// </summary>
		[XmlAttribute("type")]
		public String Type;

		/// <summary>
		/// A name of another enumerant this is an alias of, used where token names have been changed as a result
		/// of profile changes or for consistency purposes. An enumerant alias is simply a different name for the
		/// exact same value. At present, enumerants which are promoted from extension to core API status are not
		/// tagged as aliases - just enumerants tagged as aliases in the Changed Tokens sections of appendices to
		/// the OpenGL Specification. This might change in the future.
		/// </summary>
		[XmlAttribute("alias")]
		public String Alias;

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Command;

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
				throw new ArgumentNullException("ctx");

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
				throw new ArgumentNullException("sw");

			if (ctx.RefPages.Count > 0)
				ctx.RefPages.GenerateDocumentation(sw, ctx, this);

			string classDefaultApi = ctx.Class.ToLower();

			foreach (Enumerant aliasOf in AliasOf)
				sw.WriteLine("[AliasOf(\"{0}\")]", aliasOf.Name);

			foreach (IFeature feature in RequiredBy) {
				if (feature.Api != null && feature.Api != classDefaultApi)
					sw.WriteLine("[RequiredByFeature(\"{0}\", Api = \"{1}\")]", feature.Name, feature.Api);
				else
					sw.WriteLine("[RequiredByFeature(\"{0}\")]", feature.Name);
			}

			foreach (Enumerant aliasOf in AliasOf) {
				foreach (IFeature feature in aliasOf.RequiredBy) {
					if (feature.Api != null && feature.Api != classDefaultApi)
						sw.WriteLine("[RequiredByFeature(\"{0}\", Api = \"{1}\")]", feature.Name, feature.Api);
					else
						sw.WriteLine("[RequiredByFeature(\"{0}\")]", feature.Name);
				}
			}
			foreach (IFeature feature in RemovedBy) {
				if (feature.Api != null && feature.Api != classDefaultApi)
					sw.WriteLine("[RemovedByFeature(\"{0}\", Api = \"{1}\")]", feature.Name, feature.Api);
				else
					sw.WriteLine("[RemovedByFeature(\"{0}\")]", feature.Name);
			}

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

		/// <summary>
		/// Get the actual enumerant declaration.
		/// </summary>
		private string Declaration
		{
			get
			{
				if (Value == null)
					throw new InvalidOperationException("missing specification");

				string type, value;

				if (Value.StartsWith("0x")) {
					if ((Value.Length > 10) || (Value.EndsWith("ull"))) {		// 0xXXXXXXXXXXull
						// Remove ull suffix
						value = Value.Substring(0, Value.Length - 3);
						type = "ulong";
					} else if (Regex.IsMatch(Value, @"0x\w{8}") && (Name.Contains("_BIT") || Name.Contains("_MASK"))) {
						value = Value;
						type = "uint";
					} else if (Regex.IsMatch(Value, @"0x\w{8}") && ImplementationName.StartsWith("SWAP_")) {
						value = Value;
						type = "uint";
					} else if (Regex.IsMatch(Value, @"0x[8F]\w{7}")) {
						value = Value;
						type = "uint";
					} else {													// 0xXXXX
						value = Value;
						type = "int";
					}

				} else if (Value.StartsWith("\"")) {
					value = Value;
					type = "string";	
				} else {
					value = Value;
					type = "int";
				}

				Match castMatch;

				if ((castMatch = Regex.Match(value, @"\(\(\w+\)\(?(?<value>(\+|\-)?\d+)\)?\)")).Success) {
					value = castMatch.Groups["value"].Value;
				}


				return (String.Format("public const {0} {1} = {2};", type, ImplementationName, value));
			}
		}

		#endregion
	}
}
