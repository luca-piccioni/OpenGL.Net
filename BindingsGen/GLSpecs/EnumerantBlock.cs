
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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// The EnumerantBlock contains individual <see cref="Enumerant"/> tags describing each of the token (enumerant)
	/// names used in the API.
	/// </summary>
	[DebuggerDisplay("EnumerantBlock: Namespace={Namespace} Type={Type} Vendor={Vendor} Comment={Comment}")]
	public class EnumerantBlock
	{
		#region Specification

		/// <summary>
		/// A string for grouping many different enums together, currently unused but typically something like GL
		/// for all enums in the OpenGL / OpenGL ES shared namespace. Multiple <see cref="Enumerant"/> tags can share
		/// the same namespace.
		/// </summary>
		[XmlAttribute("namespace")]
		public String Namespace;

		/// <summary>
		/// 
		/// </summary>
		[XmlAttribute("group")]
		public String Group;

		/// <summary>
		/// A string describing the data type of the values of this group of enums, currently unused. The only string
		/// used at present in the is bitmask.
		/// </summary>
		[XmlAttribute("type")]
		public String Type;

		/// <summary>
		/// Integers defining the start and end of a reserved range of enumerants for a particular vendor or purpose.
		/// Start must be less or equal to End. These fields define formal enumerant allocations within a namespace, and
		/// are made by the Khronos Registrar on request from implementers following the enum allocation policy.
		/// </summary>
		[XmlAttribute("start")]
		public String Start;

		/// <summary>
		/// Integers defining the start and end of a reserved range of enumerants for a particular vendor or purpose.
		/// Start must be less or equal to End. These fields define formal enumerant allocations within a namespace, and
		/// are made by the Khronos Registrar on request from implementers following the enum allocation policy.
		/// </summary>
		[XmlAttribute("end")]
		public String End;

		/// <summary>
		/// A string describing the vendor or purposes to whom a reserved range of enumerants is allocated.
		/// </summary>
		[XmlAttribute("vendor")]
		public String Vendor;
		
		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		/// <summary>
		/// Enumerants belonging to this block.
		/// </summary>
		[XmlElement("enum")]
		public readonly List<Enumerant> Enums = new List<Enumerant>();

		#endregion

		#region Information Linkage

		/// <summary>
		/// Link other information against this enumerant.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> holding the registry information to link.
		/// </param>
		internal void Link(RegistryContext ctx)
		{
			foreach (Enumerant enumerant in Enums) {
				// Link
				enumerant.ParentEnumerantBlock = this;
				if ((enumerant.Type == null) && (Type == "bitmask"))
					enumerant.Type = "u";
				// Recurse
				enumerant.Link(ctx);
			}

			Enums.RemoveAll(delegate(Enumerant item) {
				if (item.RequiredBy.Count == 0)
					return (true);
				if (item.Api != null && !ctx.IsSupportedApi(item.Api))
					return (true);
				return (false);
			});
		}

		#endregion
	}
}
