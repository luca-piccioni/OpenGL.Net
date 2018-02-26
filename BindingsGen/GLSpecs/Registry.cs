
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	[XmlRoot("registry")]
	public class Registry : IRegistry
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

		#region Enumerant Groups

		/// <summary>
		/// The <see cref="Groups"/> contains individual <see cref="EnumerantGroup"/> describing some of the group
		/// annotations used for return and parameter types.
		/// </summary>
		[XmlArray("groups")]
		[XmlArrayItem("group")]
		public List<EnumerantGroup> Groups { get { return (_Groups); } }

		private readonly List<EnumerantGroup> _Groups = new List<EnumerantGroup>();

		public EnumerantGroup GetEnumerantGroup(string name)
		{
			EnumerantGroup enumerantGroup;

			if (_EnumerantGroupRegistry.TryGetValue(name, out enumerantGroup) == false)
				return (null);

			return (enumerantGroup);
		}

		private readonly Dictionary<string, EnumerantGroup> _EnumerantGroupRegistry = new Dictionary<string, EnumerantGroup>();

		#endregion

		#region Enumerant Blocks

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("enums")]
		public readonly List<EnumerantBlock> Enums = new List<EnumerantBlock>();

		#endregion

		#region Enumerants

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

		public Enumerant GetEnumerant(string name)
		{
			Enumerant enumerant;

			if (_EnumerantRegistry.TryGetValue(name, out enumerant))
				return (enumerant);

			return (null);
		}

		public Enumerant GetEnumerantNoCase(string name)
		{
			name = name.ToLowerInvariant();

			foreach (KeyValuePair<string, Enumerant> pair in _EnumerantRegistry) {
				string enumnocase = pair.Value.ImplementationName.ToLowerInvariant();

				if (enumnocase == name)
					return (pair.Value);
			}

			return (null);
		}

		private readonly Dictionary<string, Enumerant> _EnumerantRegistry = new Dictionary<string, Enumerant>();

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

			if (_CommandRegistry.TryGetValue(name, out command) == false)
				return (null);

			return (command);
		}

		private readonly Dictionary<string, Command> _CommandRegistry = new Dictionary<string,Command>();

		#endregion

		#region Features & Extensions

		/// <summary>
		/// It defines API feature interfaces (API versions, more or less). One item per feature set.
		/// </summary>
		[XmlElement("feature")]
		public List<Feature> Features { get { return (_Features); } }

		private readonly List<Feature> _Features = new List<Feature>();

		/// <summary>
		/// The <see cref="Extensions"/> contains individual <see cref="Extension"/> defining API extension interface.
		/// </summary>
		[XmlArray("extensions")]
		[XmlArrayItem("extension")]
		public List<Extension> Extensions { get { return (_Extensions); } }

		private readonly List<Extension> _Extensions = new List<Extension>();

		public IEnumerable<IFeature> AllFeatures(RegistryContext ctx)
		{
			List<Feature> features = Features.FindAll(delegate(Feature item) {
				return (ctx.IsSupportedApi(item.Api));
			});

			features.Sort(delegate(Feature x, Feature y) {
				Khronos.KhronosVersion xVersion = Khronos.KhronosVersion.ParseFeature(x.Name);
				Khronos.KhronosVersion yVersion = Khronos.KhronosVersion.ParseFeature(y.Name);

				if (xVersion.Api != yVersion.Api) {
					int xPriority = GetVersionApiPriority(xVersion.Api);
					int yPriority = GetVersionApiPriority(yVersion.Api);

					if (xPriority != yPriority)
						return (xPriority.CompareTo(yPriority));
					else
						return (x.Name.CompareTo(y.Name));
				} else
					return (xVersion.CompareTo(yVersion));
			});

			foreach (Feature feature in features)
				yield return feature;

			List<Extension> extensions = new List<Extension>(Extensions);

			extensions.RemoveAll(delegate(Extension item) {
				return (item.Supported != null && !ctx.IsSupportedApi(item.Supported));
			});

			extensions.Sort(delegate(Extension x, Extension y) {
				int xVendor = GetExtensionVendorPriority(x.Vendor), yVendor = GetExtensionVendorPriority(y.Vendor);

				if (xVendor != yVendor)
					return (GetExtensionVendorPriority(x.Vendor).CompareTo(GetExtensionVendorPriority(y.Vendor)));

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

		private static int GetVersionApiPriority(string api)
		{
			switch (api) {
				case Khronos.KhronosVersion.ApiGl:
					return (-1000);
				case Khronos.KhronosVersion.ApiGles1:
					return (-501);
				case Khronos.KhronosVersion.ApiGles2:
					return (-500);
				default:
					return (0);
			}
		}

		private static int GetExtensionVendorPriority(string vendor)
		{
			switch (vendor) {
				case "ARB":
					return (-1000);
				case "EXT":
					return (-500);
				case "OES":
					return (-1);
				//case "NV":
				//	return (-2);
				//case "AMD":
				//	return (-1);
				default:
					return (0);
			}
		}

		#endregion

		#region Information Linkage

		/// <summary>
		/// Link registry information elements.
		/// </summary>
		internal void Link(RegistryContext ctx)
		{
			// Index enumeration groups
			foreach (EnumerantGroup enumerantGroup in Groups) {
				if (_EnumerantGroupRegistry.ContainsKey(enumerantGroup.Name)) {
					Console.WriteLine("Enumeration group {0} is duplicated. Ignoring the late definition.", enumerantGroup.Name);
					continue;
				}
				_EnumerantGroupRegistry.Add(enumerantGroup.Name, enumerantGroup);
			}
				
			// Index commands
			foreach (Command command in Commands)
				_CommandRegistry.Add(command.Prototype.Name, command);

			// Link command aliases
			foreach (Command command in Commands) {
				if (command.Alias == null)
					continue;
				Command aliasCommand = GetCommand(command.Alias.Name);

				if (aliasCommand != null)
					aliasCommand.Aliases.Add(command);
				else
					Console.WriteLine("Command {0} has an undefined alias {1}.", command.Prototype.Name, command.Alias.Name);
			}

			foreach (EnumerantBlock enumerantBlock in Enums)
				enumerantBlock.Link(ctx);
			foreach (CommandBlock commandBlock in CommandBlocks)
				commandBlock.Link(ctx);

			// Index required enumerants
			foreach (Enumerant enumerant in Enumerants) {
				if ((enumerant.Api == null) || (ctx.IsSupportedApi(enumerant.Api)))
					_EnumerantRegistry[enumerant.Name] = enumerant;
			}
			// Link enumerant aliases
			foreach (Enumerant enumerant in Enumerants) {
				if (enumerant.Alias != null)
					enumerant.EnumAlias = GetEnumerant(enumerant.Alias);

				if (enumerant.EnumAlias == null) {
					foreach (string extensionPostfix in ctx.ExtensionsDictionary.Words) {
						if (!enumerant.Name.EndsWith("_" + extensionPostfix))
							continue;

						Enumerant enumerantAlias = null;
						string aliasName = enumerant.Name.Substring(0, enumerant.Name.Length - (extensionPostfix.Length + 1));
						bool isArb = extensionPostfix == "ARB", isExt = extensionPostfix == "EXT";

						if (!isArb && !isExt) {
							// Core enumerant
							enumerantAlias = GetEnumerant(aliasName);
							// ARB enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetEnumerant(aliasName + "_ARB");
							// EXT enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetEnumerant(aliasName + "_EXT");
						} else if (isExt) {
							// Core enumerant
							enumerantAlias = GetEnumerant(aliasName);
							// ARB enumerant
							if (enumerantAlias == null)
								enumerantAlias = GetEnumerant(aliasName + "_ARB");
						} else if (isArb) {
							// Core enumerant
							enumerantAlias = GetEnumerant(aliasName);
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
