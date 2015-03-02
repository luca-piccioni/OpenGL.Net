
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Information about GL type.
	/// </summary>
	[DebuggerDisplay("Type: Name={Name} Api={Api} Comment={Comment}")]
	public class Type
	{
		#region Specification

		/// <summary>
		/// Another type name this type requires to complete its definition.
		/// </summary>
		[XmlAttribute("requires")]
		public String Requires;

		/// <summary>
		/// Name of this type (if not defined in the tag body).
		/// </summary>
		[XmlAttribute("name")]
		public String NameAttribute;

		/// <summary>
		/// Name of this type (if not defined in the tag body).
		/// </summary>
		[XmlElement("name")]
		public String Name;

		/// <summary>
		/// An API name (see <feature> below) which specializes this definition of the named type, so that the same
		/// API types may have different definitions for e.g. GL ES and GL.
		/// </summary>
		[XmlAttribute("api")]
		public String Api;

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("apientry")]
		public String ApiEntry;

		/// <summary>
		/// Arbitrary string
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		/// <summary>
		/// C language definition.
		/// </summary>
		[XmlText()]
		public String Definition;

		#endregion
	}
}
