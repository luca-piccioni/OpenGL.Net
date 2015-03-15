
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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlRoot("registry")]
	public class Registry
	{
		#region Basic

		/// <summary>
		/// Contains arbitrary text, such as a copyright statement.
		/// </summary>
		[XmlElement("comment")]
		public String Comment;

		/// <summary>
		/// The <see cref="Groups"/> contains individual <see cref="EnumerantGroup"/> describing some of the group
		/// annotations used for return and parameter types.
		/// </summary>
		[XmlArray("types")]
		[XmlArrayItem("type")]
		public readonly List<Type> Types = new List<Type>();

		#endregion

		#region Enumerants

		/// <summary>
		/// The <see cref="Groups"/> contains individual <see cref="EnumerantGroup"/> describing some of the group
		/// annotations used for return and parameter types.
		/// </summary>
		[XmlArray("groups")]
		[XmlArrayItem("group")]
		public readonly List<EnumerantGroup> Groups = new List<EnumerantGroup>();

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("enums")]
		public readonly List<EnumerantBlock> Enums = new List<EnumerantBlock>();

		/// <summary>
		/// Enumerants in this Registry.
		/// </summary>
		public List<Enumerant> Enumerants
		{
			get
			{
				List<Enumerant> enumerants = new List<Enumerant>();

				foreach (EnumerantBlock enumerantBlock in Enums)
					enumerants.AddRange(enumerantBlock.Enums);

				return (enumerants);
			}
		}

		public Enumerant GetGlEnumerant(string name)
		{
			Enumerant enumerant;

			if (mGlEnumerants.TryGetValue(name, out enumerant))
				return (enumerant);

			return (null);
		}

		private readonly Dictionary<string, Enumerant> mGlEnumerants = new Dictionary<string, Enumerant>();

		#endregion

		#region Commands

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("commands")]
		public readonly List<CommandBlock> CommandBlocks = new List<CommandBlock>();

		public List<Command> Commands
		{
			get
			{
				List<Command> commands = new List<Command>();

				foreach (CommandBlock commandBlock in CommandBlocks)
					commands.AddRange(commandBlock.Commands);

				return (commands);
			}
		}

		public Command GetCommand(string name)
		{
			Command command;

			if (mCommandRegistry.TryGetValue(name, out command) == false)
				return (null);

			return (command);
		}

		private readonly Dictionary<string, Command> mCommandRegistry = new Dictionary<string,Command>();

		#endregion

		#region Features & Extensions

		/// <summary>
		/// It defines API feature interfaces (API versions, more or less). One item per feature set.
		/// </summary>
		[XmlElement("feature")]
		public readonly List<Feature> Features = new List<Feature>();

		/// <summary>
		/// The <see cref="Extensions"/> contains individual <see cref="Extension"/> defining API extension interface.
		/// </summary>
		[XmlArray("extensions")]
		[XmlArrayItem("extension")]
		public readonly List<Extension> Extensions = new List<Extension>();

		public IEnumerable<IFeature> AllFeatures(RegistryContext ctx)
		{
			foreach (Feature feature in Features) {
				if (feature.Api == ctx.Class.ToLower())
					yield return feature;
			}

			List<Extension> extensions = new List<Extension>(Extensions);

			extensions.RemoveAll(delegate(Extension item) {
				return (item.Supported != null && !Regex.IsMatch(ctx.Class.ToLowerInvariant(), item.Supported));
			});

			extensions.Sort(delegate(Extension x, Extension y) {
				int xIndex = ExtensionIndices.GetIndex(x.Name);
				int yIndex = ExtensionIndices.GetIndex(y.Name);

				if (xIndex != yIndex)
					return (xIndex.CompareTo(yIndex));
				else
					return (x.Name.CompareTo(y.Name));
			});

			foreach (Extension extension in extensions)
				yield return extension;
		}

		#endregion

		#region Information Linkage

		/// <summary>
		/// Link registry information elements.
		/// </summary>
		internal void Link(RegistryContext ctx)
		{
			foreach (EnumerantBlock enumerantBlock in Enums)
				enumerantBlock.Link(ctx);
			foreach (CommandBlock commandBlock in CommandBlocks)
				commandBlock.Link(ctx);

			// Index commands
			foreach (Command command in Commands)
				mCommandRegistry.Add(command.Prototype.Name, command);
			// Link command aliases
			foreach (Command command in Commands) {
				if (command.Alias == null)
					continue;
				Command aliasCommand = GetCommand(command.Alias.Name);
				aliasCommand.Aliases.Add(command);
			}

			// Index required enumerants
			foreach (Enumerant enumerant in Enumerants) {
				if ((enumerant.Api == null) || (Regex.IsMatch(ctx.Class.ToUpperInvariant(), enumerant.Api)))
					mGlEnumerants[enumerant.Name] = enumerant;
			}
			// Link enumerant aliases
			foreach (Enumerant enumerant in Enumerants) {
				if (enumerant.Alias != null)
					enumerant.EnumAlias = GetGlEnumerant(enumerant.Alias);

				if (enumerant.EnumAlias == null) {
					foreach (string extensionPostfix in ctx.ExtensionsDictionary.Words) {
						if (!enumerant.Name.EndsWith("_" + extensionPostfix))
							continue;

						Enumerant enumerantAlias = null;
						string aliasName = enumerant.Name.Substring(0, enumerant.Name.Length - (extensionPostfix.Length + 1));
						bool isArb = extensionPostfix == "ARB", isExt = extensionPostfix == "EXT";

						if (!isArb && !isExt) {
							// Core enumerant
							enumerantAlias = GetGlEnumerant(aliasName);
							// ARB enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetGlEnumerant(aliasName + "_ARB");
							// EXT enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetGlEnumerant(aliasName + "_EXT");
						} else if (isExt) {
							// Core enumerant
							enumerantAlias = GetGlEnumerant(aliasName);
							// ARB enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetGlEnumerant(aliasName + "_ARB");
						} else if (isArb) {
							// Core enumerant
							enumerantAlias = GetGlEnumerant(aliasName);
						}

						if (enumerantAlias != null) {
							if (enumerantAlias.Value == enumerant.Value) {
								enumerant.EnumAlias = enumerantAlias;
								enumerantAlias.AliasOf.Add(enumerant);
							}
						}
					}
				}
			}
		}

		#endregion
	}
}
