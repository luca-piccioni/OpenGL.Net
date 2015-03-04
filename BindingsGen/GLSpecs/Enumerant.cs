
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

		#region Deprecation

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
				if (feature.Api != null && feature.Api != ctx.Class.ToLowerInvariant())
					continue;

				int requirementIndex = feature.Requirements.FindIndex(delegate(FeatureCommand item) {
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
				if (extension.Supported != null && !Regex.IsMatch(ctx.Class.ToLowerInvariant(), extension.Supported))
					continue;

				int requirementIndex = extension.Requirements.FindIndex(delegate(FeatureCommand item) {
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
				if (feature.Api != null && feature.Api != ctx.Class.ToLowerInvariant())
					continue;

				int requirementIndex = feature.Removals.FindIndex(delegate(FeatureCommand item) {
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
		private readonly List<IFeature> RequiredBy = new List<IFeature>();

		/// <summary>
		/// List of <see cref="IFeature"/> that removes this Enumerant.
		/// </summary>
		private readonly List<IFeature> RemovedBy = new List<IFeature>();

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
		internal void GenerateSource(SourceStreamWriter sw)
		{
			if (sw == null)
				throw new ArgumentNullException("sw");

			bool requireRemarks = (Alias != null);

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// Value of {0} symbol{1}.", Name, IsDeprecated ? " (DEPRECATED)" : String.Empty);
			sw.WriteLine("/// </summary>");

			if (requireRemarks) {
				sw.WriteLine("/// <remarks>");

				if (Alias != null) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// This enumerant is equaivalent to {0}.", SpecificationStyle.GetEnumBindingName(Alias));
					sw.WriteLine("/// </para>");
				}
				
				sw.WriteLine("/// </remarks>");
			}

			foreach (IFeature feature in RequiredBy)
				sw.WriteLine("[RequiredByFeature(\"{0}\")]", feature.Name);
			foreach (IFeature feature in RemovedBy)
				sw.WriteLine("[RemovedByFeature(\"{0}\")]", feature.Name);

			if (IsDeprecated) {
				sw.Write("#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE" + Environment.NewLine);
				sw.WriteLine("[Obsolete(\"Deprecated/removed by {0}.\")]", SpecificationStyle.GetHumanToken(RemovedBy[0].Name));
				sw.Write("#endif" + Environment.NewLine);
			}

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
					} else if (Value.Length == 10) {							// 0xXXXXXXXX
						value = Value;
						type = "uint";
					} else {													// 0xXXXX
						value = Value;
						type = "int";
					}
						
				} else {
					value = Value;
					type = "int";
				}


				return (String.Format("public const {0} {1} = {2};", type, ImplementationName, value));
			}
		}

		#endregion
	}
}
