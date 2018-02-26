
// Copyright (C) 2017 Luca Piccioni
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Reflection;
#if NETFRAMEWORK
using System.Xml.Serialization;
#endif

namespace Khronos
{
	/// <summary>
	/// Contains metedata information for Khronos API commands.
	/// </summary>
#if NETFRAMEWORK
	[XmlType("KhronosLogMap")]
#endif
	public sealed class KhronosLogMap
	{
		#region XML Schema

		/// <summary>
		/// Commands.
		/// </summary>
#if NETFRAMEWORK
		[XmlElement("command")]
#endif
		public Command[] Commands
		{
			get { return _Commands.Values.ToArray(); }
			set
			{
				_Commands.Clear();

				if (value == null)
					return;

				foreach (Command command in value)
					_Commands[command.Name] = command;
			}
		}

		/// <summary>
		/// Commands mapped for documentation.
		/// </summary>
		private readonly Dictionary<string, Command> _Commands = new Dictionary<string, Command>();

		/// <summary>
		/// Command element.
		/// </summary>
#if NETFRAMEWORK
		[XmlType("command")]
#endif
		public sealed class Command
		{
			/// <summary>
			/// Command name.
			/// </summary>
#if NETFRAMEWORK
			[XmlAttribute("name")]
#endif
			public string Name;

			/// <summary>
			/// Command parameters flags.
			/// </summary>
#if NETFRAMEWORK
			[XmlElement("param")]
#endif
			public CommandParam[] Params;
		}

		/// <summary>
		/// Command parameter element.
		/// </summary>
#if NETFRAMEWORK
		[XmlType("command_param")]
#endif
		public sealed class CommandParam
		{
#if NETFRAMEWORK
			[XmlAttribute("name")]
#endif
			public string Name;

#if NETFRAMEWORK
			[XmlAttribute("flags")]
			[DefaultValue(KhronosLogCommandParameterFlags.None)]
#endif
			public KhronosLogCommandParameterFlags Flags = KhronosLogCommandParameterFlags.None;
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
		internal static KhronosLogMap Load(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException(nameof(resourcePath));

#if NETFRAMEWORK
			using (Stream xmlStream = Assembly.GetCallingAssembly().GetManifestResourceStream(resourcePath)) {
				if (xmlStream == null)
					throw new ArgumentException($"resource {resourcePath} not defined in calling assembly", nameof(resourcePath));
				return (KhronosLogMap)_XmlSerializer.Deserialize(xmlStream);
			}
#else
			throw new NotImplementedException();
#endif
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
		internal static void Save(string resourcePath, KhronosLogMap logMap)
		{
			if (resourcePath == null)
				throw new ArgumentNullException(nameof(resourcePath));
			if (logMap == null)
				throw new ArgumentNullException(nameof(logMap));

#if NETFRAMEWORK
			using (FileStream fs = new FileStream(resourcePath, FileMode.Create, FileAccess.Write)) {
				_XmlSerializer.Serialize(fs, logMap);
			}
#else
			throw new NotImplementedException();
#endif
		}

#if NETFRAMEWORK
		/// <summary>
		/// XML serializer used by <see cref="Load"/> for loading log maps.
		/// </summary>
		private static readonly XmlSerializer _XmlSerializer = new XmlSerializer(typeof(KhronosLogMap));
#endif

		#endregion

		#region Information Query

		//public string GetCommandParameterName(string commandName, int paramIndex)
		//{
		//	CommandParam commandParam = GetCommandParam(commandName, paramIndex);

		//	return commandParam == null ? $"param{paramIndex}" : commandParam.Name;
		//}

		/// <summary>
		/// Get the flags associated to the parameters of a command.
		/// </summary>
		/// <param name="commandName">
		/// A <see cref="string"/> that specify the name of the command.
		/// </param>
		/// <param name="paramIndex">
		/// A <see cref="int"/> that specify the index of the parameter (zero based).
		/// </param>
		/// <returns>
		/// It returns the <see cref="KhronosLogCommandParameterFlags"/> associated with the parameter.
		/// </returns>
		public KhronosLogCommandParameterFlags GetCommandParameterFlag(string commandName, int paramIndex)
		{
			CommandParam commandParam = GetCommandParam(commandName, paramIndex);

			return commandParam?.Flags ?? KhronosLogCommandParameterFlags.None;
		}

		private Command GetCommand(string commandName)
		{
			if (commandName == null)
				throw new ArgumentNullException(nameof(commandName));

			Command command;

			if (_Commands.TryGetValue(commandName, out command))
				return command;

			return null;
		}

		private CommandParam GetCommandParam(string commandName, int paramIndex)
		{
			if (paramIndex < 0)
				throw new ArgumentOutOfRangeException(nameof(paramIndex), paramIndex, "it cannot be negative");

			Command command = GetCommand(commandName);
			if (command == null)
				return null;

			if (paramIndex >= command.Params.Length)
				throw new ArgumentOutOfRangeException(nameof(paramIndex), paramIndex, "greater than the number of parameters");

			 return command.Params[paramIndex];
		}

		#endregion
	}
}