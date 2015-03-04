
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
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Special flags for <see cref="Command"/>.
	/// </summary>
	[Flags]
	public enum CommandFlags
	{
		/// <summary>
		/// Default behaviour.
		/// </summary>
		None =			0x00,

		/// <summary>
		/// Do not generate any implementation.
		/// </summary>
		Disable =		0x01,

		/// <summary>
		/// Do not generate glGetError call.
		/// </summary>
		NoGetError =	0x02,

		/// <summary>
		/// Generate an "out" parameter even if the declared array length is not 1.
		/// </summary>
		OutParam =		0x04,
	}

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
				sCommandFlagsDatabase = (CommandFlagsDatabase)serialize.Deserialize(sr);
			}
		}

		/// <summary>
		/// The only instance of CommandFlagsDatabase.
		/// </summary>
		private static readonly CommandFlagsDatabase sCommandFlagsDatabase;

		#endregion

		#region Information

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
			[XmlAttribute("name")]
			public string Name;

			/// <summary>
			/// Force a specific name for command (as specification name).
			/// </summary>
			[XmlElement("rename")]
			public string Rename;

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
			foreach (CommandItem commandItem in sCommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name))
					return (commandItem.Flags);
			}

			return (CommandFlags.None);
		}

		public static string GetCommandImplementationName(Command command)
		{
			foreach (CommandItem commandItem in sCommandFlagsDatabase.Commands) {
				if (Regex.IsMatch(command.Prototype.Name, commandItem.Name))
					return (commandItem.Rename ?? null);
			}

			return (null);
		}

		public static string GetCommandVisibility(Command command)
		{
			foreach (CommandItem commandItem in sCommandFlagsDatabase.Commands) {
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

		/// <summary>
		/// Command items.
		/// </summary>
		[XmlElement("command")]
		public readonly List<CommandItem> Commands = new List<CommandItem>();

		#endregion
	}
}
