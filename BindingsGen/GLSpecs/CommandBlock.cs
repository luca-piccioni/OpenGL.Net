
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Block of command.s
	/// </summary>
	public class CommandBlock
	{
		#region Specification

		/// <summary>
		/// Command block namespace.
		/// </summary>
		[XmlAttribute("namespace")]
		public String Namespace;

		/// <summary>
		/// Commands grouped by this CommandBlock.
		/// </summary>
		[XmlElement("command")]
		public readonly List<Command> Commands = new List<Command>();

		#endregion

		#region Information LInkage

		public void Link(RegistryContext ctx)
		{
			foreach (Command command in Commands)
				command.Link(ctx);

			// Remove enumerants not required by anyone
			Commands.RemoveAll(delegate(Command item) {
				if (item.RequiredBy.Count == 0)
					return (true);
				return (false);
			});
		}

		#endregion
	}
}
