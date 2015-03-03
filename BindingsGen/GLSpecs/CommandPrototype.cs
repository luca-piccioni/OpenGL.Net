
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
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Command prototype.
	/// </summary>
	[DebuggerDisplay("CommandPrototype: Definition={Definition} Name={Name}")]
	public class CommandPrototype
	{
		#region Specification

		/// <summary>
		/// The "unsafe" returned type (used in case <see cref="Type"/> is not defined).
		/// </summary>
		[XmlText()]
		public String Definition;

		/// <summary>
		/// The "unsafe" returned type.
		/// </summary>
		[XmlElement("ptype")]
		public String Type;

		/// <summary>
		/// The name of the underlying Command.
		/// </summary>
		[XmlElement("name")]
		public String Name;

		/// <summary>
		/// Determines the returned type, strongly typed (if defined).
		/// </summary>
		[XmlAttribute("group")]
		public String Group;

		#endregion

		#region Code Generation

		internal string ImplementationReturnType
		{
			get
			{
				string delegateType = DelegateReturnType;

				if ((Group != null) && (Group == "String"))
					return ("String");

				return (delegateType);
			}
		}

		internal string DelegateReturnType
		{
			get
			{
				if ((Group != null) && (Group == "String"))
					return ("IntPtr");

				string typeDecorator = Definition != null ? Definition.Trim() : null;

				if ((Type != null) && (typeDecorator != null))
					return (TypeMap.CsTypeMap.MapType(Type.Trim() + typeDecorator));
				else if (Type != null)
					return (TypeMap.CsTypeMap.MapType(Type.Trim()));
				else if (typeDecorator != null)
					return (TypeMap.CsTypeMap.MapType(typeDecorator));
				else
					return ("IntPtr");
			}
		}

		#endregion
	}
}
