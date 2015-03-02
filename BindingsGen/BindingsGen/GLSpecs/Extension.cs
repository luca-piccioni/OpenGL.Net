
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
	/// 
	/// </summary>
	[DebuggerDisplay("Extension: Supported={Supported} Comment={Comment} Protect={Protect}")]
	public class Extension : IFeature
	{
		#region Specification

		/// <summary>
		/// Extension name.
		/// </summary>
		[XmlAttribute("name")]
		public String Name;

		/// <summary>
		/// A regular expression, with an implicit ˆ and $ bracketing it, which should match the api tag of a set
		/// of <see cref="Feature"/>.
		/// </summary>
		[XmlAttribute("supported")]
		public String Supported;

		/// <summary>
		/// An additional preprocessor token used to protect an extension definition. Usually another feature or extension
		/// name. Rarely used, for odd circumstances where the definition of an extension requires another to be defined 
		/// first.
		/// </summary>
		[XmlAttribute("protect")]
		public String Protect;

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		[XmlElement("require")]
		public readonly List<FeatureCommand> Requirements = new List<FeatureCommand>();

		#endregion

		#region IFeature Implementation

		/// <summary>
		/// Get the feature name.
		/// </summary>
		string IFeature.Name
		{
			get { return (Name); }
		}

		#endregion
	}
}
