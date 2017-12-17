
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
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Commands flags database.
	/// </summary>
	[XmlRoot("command_overrides")]
	public sealed class CommandFlagsDatabase
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static CommandFlagsDatabase()
		{
			XmlSerializer serialize = new XmlSerializer(typeof(CommandFlagsDatabase));

			using (Stream sr = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CommandFlags.xml")) {
				_CommandFlagsDatabase = (CommandFlagsDatabase)serialize.Deserialize(sr);
			}
		}

		/// <summary>
		/// The only instance of CommandFlagsDatabase.
		/// </summary>
		private static readonly CommandFlagsDatabase _CommandFlagsDatabase;

		#endregion

		#region Enumerants

		/// <summary>
		/// Enumerant extentension.
		/// </summary>
		public class EnumerantItem
		{
			/// <summary>
			/// Regular expression used to match a set of OpenGL registry enumerant groups.
			/// </summary>
			[XmlAttribute("name")]
			public string Name;

			/// <summary>
			/// Enumeration alias, overriding the name generation.
			/// </summary>
			[XmlAttribute("alias")]
			public string Alias;

			/// <summary>
			/// Attribute corresponding /registry/enums/[@type].
			/// </summary>
			[XmlAttribute("type")]
			public string Type;

			/// <summary>
			/// Disable code generation for this enumeration.
			/// </summary>
			[XmlAttribute("disable")]
			public bool Disable;

			/// <summary>
			/// Prefix to be removed to enumeration values.
			/// </summary>
			[XmlAttribute("prefix")]
			public string ItemPrefix;

			/// <summary>
			/// Enumerants to be implictly added to the enumerant group.
			/// </summary>
			[XmlElement("add_enum")]
			public readonly List<string> AddEnumerants = new List<string>();

			/// <summary>
			/// Custom enumerant value.
			/// </summary>
			public class Value
			{
				/// <summary>
				/// Name (unprocessed) of the enumeration.
				/// </summary>
				[XmlText()]
				public string Name;

				/// <summary>
				/// Value (raw, not proceesable) of the enumeration value.
				/// </summary>
				[XmlAttribute("value")]
				public string Definition;
			}

			// <summary>
			/// Enumerants to be implictly added to the enumerant group.
			/// </summary>
			[XmlElement("add_enum_value")]
			public readonly List<Value> AddEnumerantValues = new List<Value>();
		}

		/// <summary>
		/// Get the <see cref="EnumerantItem"/> matching with an enumerant group name.
		/// </summary>
		/// <param name="enumName">
		/// 
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		public static EnumerantItem FindEnumerant(string enumName)
		{
			if (enumName == null)
				throw new ArgumentNullException(nameof(enumName));

			return (_CommandFlagsDatabase.Enumerants.Find(delegate (EnumerantItem item) {
				return (Regex.IsMatch(enumName, item.Name) || (item.Alias != null && Regex.IsMatch(enumName, "^" + item.Alias + "$")));
			}));
		}

		/// <summary>
		/// Enumerants items.
		/// </summary>
		[XmlElement("enumerant")]
		public readonly List<EnumerantItem> Enumerants = new List<EnumerantItem>();

		#endregion

		#region Commands

		/// <summary>
		/// Command scope visibility.
		/// </summary>
		public enum Visibility
		{
			/// <summary>
			/// Private member.
			/// </summary>
			[XmlEnum("private")]
			Private,

			/// <summary>
			/// Public member.
			/// </summary>
			[XmlEnum("public")]
			Public
		}

		/// <summary>
		/// Command specific flags.
		/// </summary>
		public class CommandItem
		{
			/// <summary>
			/// Regular expression used to match a set of OpenGL registry commands.
			/// </summary>
			[XmlAttribute("name")]
			public string Name;

			/// <summary>
			/// Force a specific name for command (as specification name).
			/// </summary>
			[XmlElement("rename")]
			public string Rename;

			/// <summary>
			/// Flags applied to <see cref="ParameterItem"/>
			/// </summary>
			[Flags]
			public enum ParameterItemFlags
			{
				/// <summary>
				/// No flags
				/// </summary>
				None =				0x0000,

				/// <summary>
				/// The procedure logging format argument will call KhronoApi.LogEnumName method.
				/// </summary>
				LogAsEnum =			0x0001,

                /// <summary>
                /// 
                /// </summary>
                LosAsAttribsList =  0x0002,
			}

			/// <summary>
			/// Command item argment.
			/// </summary>
			public class ParameterItem
			{
				/// <summary>
				/// Argument identifier.
				/// </summary>
				[XmlAttribute("id")]
				public string Id;

				/// <summary>
				/// Argument index, zero based.
				/// </summary>
				[XmlAttribute("index")]
				public int Index = -1;

				/// <summary>
				/// Force a specific name for command argument (as specification name).
				/// </summary>
				[XmlElement("rename")]
				public string Rename;

				/// <summary>
				/// Force a specific type for command argument (as specification name).
				/// </summary>
				[XmlElement("retype")]
				public string Retype;

				/// <summary>
				/// Force a specific modified for command argument.
				/// </summary>
				[XmlElement("modifier")]
				public string Modifier;

				/// <summary>
				/// Parameter flags.
				/// </summary>
				[XmlElement("flags")]
				[DefaultValue(ParameterItemFlags.None)]
				public ParameterItemFlags Flags = ParameterItemFlags.None;
			}

			/// <summary>
			/// Rename a specific argument name for command.
			/// </summary>
			/// <remarks>
			/// The format is PreviousArg;NewArg
			/// </remarks>
			[XmlElement("param")]
			public List<ParameterItem> Parameters;

			/// <summary>
			/// Force scope visibility (default is public).
			/// </summary>
			[XmlElement("visibility")]
			public Visibility Visibility = Visibility.Public;

			[XmlElement("flags")]
			public CommandFlags Flags;
		}

		public static CommandFlags GetCommandFlags(Command command)
		{
			CommandFlags commandFlags = CommandFlags.None;

			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name))
					commandFlags |= commandItem.Flags;
			}

			return (commandFlags);
		}

		public static string GetCommandImplementationName(Command command)
		{
			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name))
					if (commandItem.Rename != null)
						return (commandItem.Rename);
			}

			return (null);
		}

		public static string GetCommandVisibility(Command command)
		{
			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name)) {
					switch (commandItem.Visibility) {
						case Visibility.Public:
						default:
							return ("public");
						case Visibility.Private:
							return ("private");
					}
				}
			}

			return ("public");
		}

		public static string GetCommandArgumentAlternativeName(Command command, CommandParameter arg)
		{
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (arg == null)
				throw new ArgumentNullException(nameof(arg));

			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name)) {
					foreach (CommandItem.ParameterItem parameterItem in commandItem.Parameters) {
						if (parameterItem.Id == arg.Name && parameterItem.Rename != null)
							return (parameterItem.Rename);
					}
				}
			}

			// arg.Name
			return (null);
		}

		public static string GetCommandArgumentAlternativeType(Command command, CommandParameter arg)
		{
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (arg == null)
				throw new ArgumentNullException(nameof(arg));

			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name)) {
					foreach (CommandItem.ParameterItem parameterItem in commandItem.Parameters) {
						if (parameterItem.Id == arg.Name && parameterItem.Retype != null)
							return (parameterItem.Retype);
					}
				}
			}

			// arg.Name
			return (null);
		}

		public static string GetCommandArgumentModifier(Command command, CommandParameter arg)
		{
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (arg == null)
				throw new ArgumentNullException(nameof(arg));

			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name)) {
					for (int i = 0; i < commandItem.Parameters.Count; i++) {
						CommandItem.ParameterItem parameterItem = commandItem.Parameters[i];

						if (parameterItem.Id != null && parameterItem.Id == arg.Name && parameterItem.Modifier != null)
							return (parameterItem.Modifier);
						if (parameterItem.Index == arg.GetCommandIndex(command) && parameterItem.Modifier != null)
							return (parameterItem.Modifier);
					}
				}
			}

			// arg.Name
			return (null);
		}

		public static CommandItem.ParameterItemFlags GetCommandParameterFlags(Command command, CommandParameter arg)
		{
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (arg == null)
				throw new ArgumentNullException(nameof(arg));

			CommandItem.ParameterItemFlags parameterFlags = CommandItem.ParameterItemFlags.None;

			foreach (CommandItem commandItem in _CommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name)) {
					foreach (CommandItem.ParameterItem parameterItem in commandItem.Parameters) {
						if (parameterItem.Id == arg.Name)
							parameterFlags |= parameterItem.Flags;
					}
				}
			}

			return (parameterFlags);
		}

		/// <summary>
		/// Command items.
		/// </summary>
		[XmlElement("command")]
		public readonly List<CommandItem> Commands = new List<CommandItem>();

		#endregion

		#region Limits

		public class Limit
		{
			[XmlAttribute("name")]
			public string Name;

			[XmlAttribute("type")]
			public string Type = "int";

			[XmlAttribute("length")]
			public int Length = 1;
		}

		/// <summary>
		/// Limits.
		/// </summary>
		[XmlElement("limit")]
		public readonly List<Limit> Limits = new List<Limit>();

		/// <summary>
		/// Limits.
		/// </summary>
		[XmlElement("exclude_limit")]
		public readonly List<Limit> ExcludedLimits = new List<Limit>();

		public static List<Limit> GetLimits()
		{
			return (_CommandFlagsDatabase.Limits);
		}

		public static Limit GetLimit(string enumName)
		{
			foreach (Limit limit in _CommandFlagsDatabase.Limits) {
				if (enumName == limit.Name)
					return (limit);
			}

			return (null);
		}

		public static bool IsExcludedLimit(string enumName)
		{
			foreach (Limit limit in _CommandFlagsDatabase.ExcludedLimits) {
				if (Regex.IsMatch(enumName, limit.Name))
					return (true);
			}

			return (false);
		}

		#endregion
	}
}
