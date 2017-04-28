
// Copyright (C) 2017 Luca Piccioni
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
using System.Linq;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace OpenGL
{
	/// <summary>
	/// Contains metedata information for Khronos API commands.
	/// </summary>
	[XmlType("KhronosLogMap")]
	public sealed class KhronosLogMap
	{
		#region XML Schema

		/// <summary>
		/// Commands.
		/// </summary>
		[XmlElement("command")]
		public Command[] Commands
		{
			get { return (_Commands.Values.ToArray()); }
			set
			{
				_Commands.Clear();

				if (value != null) {
					foreach (Command command in value)
						_Commands[command.Name] = command;
				}
			}
		}

		/// <summary>
		/// Commands mapped for documentation.
		/// </summary>
		private readonly Dictionary<string, Command> _Commands = new Dictionary<string, Command>();

		/// <summary>
		/// Command element.
		/// </summary>
		[XmlType("command")]
		public sealed class Command
		{
			/// <summary>
			/// Command name.
			/// </summary>
			[XmlAttribute("name")]
			public string Name;

			/// <summary>
			/// Command parameters flags.
			/// </summary>
			[XmlElement("param")]
			public CommandParam[] Params;
		}

		/// <summary>
		/// Command parameter element.
		/// </summary>
		[XmlType("command_param")]
		public sealed class CommandParam
		{
			[XmlAttribute("name")]
			public string Name;

			[XmlAttribute("flags")]
			[DefaultValue(CommandParameterFlags.None)]
			public CommandParameterFlags Flags = CommandParameterFlags.None;
		}

		/// <summary>
		/// Command parameter element.
		/// </summary>
		public enum CommandParameterFlags
		{
			[XmlEnum("none")]
			None =				0x0000,
			[XmlEnum("enum")]
			Enum =				0x0001,
		}

		#endregion

		#region Load/Save

		/// <summary>
		/// Load a <see cref="KhronosLogMap"/> from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the path of the Khronos API log map resource.
		/// </param>
		/// <returns>
		/// It returns the <see cref="KhronosLogMap"/> loaded from <paramref name="resourcePath"/>.
		/// </returns>
		public static KhronosLogMap Load(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");

			using (Stream xmlStream = Assembly.GetCallingAssembly().GetManifestResourceStream(resourcePath)) {
				return ((KhronosLogMap)_XmlSerializer.Deserialize(xmlStream));
			}
		}

		/// <summary>
		/// Load a <see cref="KhronosLogMap"/> from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the path of the Khronos API log map resource.
		/// </param>
		/// <param name="logMap">
		/// The <see cref="KhronosLogMap"/> to be serialized into <paramref name="resourcePath"/>.
		/// </param>
		public static void Save(string resourcePath, KhronosLogMap logMap)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");
			if (logMap == null)
				throw new ArgumentNullException("logMap");

			using (FileStream fs = new FileStream(resourcePath, FileMode.Create, FileAccess.Write)) {
				_XmlSerializer.Serialize(fs, logMap);
			}
		}

		/// <summary>
		/// XML serializer used by <see cref="Load"/> for loading log maps.
		/// </summary>
		private static XmlSerializer _XmlSerializer = new XmlSerializer(typeof(KhronosLogMap));

		#endregion

		#region Information Query

		public string GetCommandParameterName(string commandName, int paramIndex)
		{
			CommandParam commandParam = GetCommandParam(commandName, paramIndex);
			if (commandParam == null)
				return (String.Format("param{0}", paramIndex));

			return (commandParam.Name);
		}

		public CommandParameterFlags GetCommandParameterFlag(string commandName, int paramIndex)
		{
			CommandParam commandParam = GetCommandParam(commandName, paramIndex);
			if (commandParam == null)
				return (CommandParameterFlags.None);

			return (commandParam.Flags);
		}

		private Command GetCommand(string commandName)
		{
			if (commandName == null)
				throw new ArgumentNullException("commandName");

			Command command;

			if (_Commands.TryGetValue(commandName, out command))
				return (command);

			return (null);
		}

		private CommandParam GetCommandParam(string commandName, int paramIndex)
		{
			if (paramIndex < 0)
				throw new ArgumentOutOfRangeException("paramIndex", paramIndex, "it cannot be negative");

			Command command = GetCommand(commandName);
			if (command == null)
				return (null);

			if (paramIndex >= command.Params.Length)
				throw new ArgumentOutOfRangeException("paramIndex", paramIndex, "greater than the number of parameters");

			 return (command.Params[paramIndex]);
		}

		#endregion
	}
}