
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
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Group feature requirements, removals and types.
	/// </summary>
	[DebuggerDisplay("FeatureCommand: Profile={Profile} Comment={Comment} Api={Api}")]
	public class FeatureCommand
	{
		#region Specification

		/// <summary>
		/// A string name of an API profile. Interfaces in the tag are only required (or removed) if the
		/// specified profile is being generated. If not specified, interfaces are required (or removed)
		/// for all API profiles.
		/// </summary>
		[XmlAttribute("profile")]
		public String Profile;

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		/// <summary>
		/// An API name (see section 4.2). Interfaces in the tag are only required (or removed) if the specified
		/// API is being generated. If not specified, interfaces are required (or removed) for all APIs.
		/// </summary>
		/// <remarks>
		/// The api attribute is only supported inside <extension> tags, since <feature> tags already define a
		/// specific API.
		/// </remarks>
		[XmlAttribute("api")]
		public String Api;

		/// <summary>
		/// Generic item required or removed by this FeatureCommand.
		/// </summary>
		[DebuggerDisplay("Item: Name={Name} Comment={Comment}")]
		public class Item
		{
			/// <summary>
			/// Parameterless constructor.
			/// </summary>
			public Item() { }

			/// <summary>
			/// Parameterless constructor.
			/// </summary>
			public Item(string name) { Name = name; }

			/// <summary>
			/// Item name.
			/// </summary>
			[XmlAttribute("name")]
			public String Name;

			/// <summary>
			/// Arbitrary string.
			/// </summary>
			[XmlAttribute("comment")]
			public String Comment;
		}

		/// <summary>
		/// It specifies an required (or removed) command defined in <see cref="Registry"/>.
		/// </summary>
		[XmlElement("command")]
		public readonly List<Item> Commands = new List<Item>();

		/// <summary>
		/// It specifies an required (or removed) enumeration defined in <see cref="Registry"/>.
		/// </summary>
		[XmlElement("enum")]
		public readonly List<Item> Enums = new List<Item>();

		/// <summary>
		/// It specifies an required (or removed) type defined in <see cref="Registry"/>.
		/// </summary>
		[XmlElement("type")]
		public readonly List<Item> Types = new List<Item>();

		#endregion
	}
}
