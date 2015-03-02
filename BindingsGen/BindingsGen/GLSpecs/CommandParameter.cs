
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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Registry command parameter.
	/// </summary>
	[DebuggerDisplay("CommandParameter: Name={Name} Group={Group} Length={Length} Type={Type}")]
	public class CommandParameter
	{
		#region Specification

		/// <summary>
		/// Group name, an arbitrary string
		/// </summary>
		[XmlAttribute("group")]
		public String Group;

		/// <summary>
		/// The parameter length, either an integer specifying the number of elements of the parameter <ptype>, or a
		/// complex string expression with poorly defined syntax, usually representing a length that is computed as a
		/// combination of other command parameter values, and possibly current GL state as well.
		/// </summary>
		[XmlAttribute("len")]
		public String Length;

		/// <summary>
		/// The Type is optional, and contains text which is a valid type name found in Type, and indicates that this
		/// type must be previously defined for the definition of the command to succeed. Builtin C types, and any derived
		/// types which are expected to be found in other header files, should not be wrapped in Type.
		/// </summary>
		[XmlElement("ptype")]
		public String Type;

		/// <summary>
		/// 
		/// </summary>
		[XmlText()]
		public String TypeDecorator;

		/// <summary>
		/// The name is required, and contains the parameter name being described.
		/// </summary>
		[XmlElement("name")]
		public String Name;

		/// <summary>
		/// Overriden parameter.
		/// </summary>
		[XmlIgnore()]
		public CommandParameter OverridenParameter;

		#endregion

		#region Code Generation

		internal bool IsSafe
		{
			get
			{
				string importType = ImportType;

				if (importType.EndsWith("*") || (importType == "IntPtr"))
					return (false);

				return (true);
			}
		}

		internal bool IsFixed
		{
			get
			{
				string implementationType = ImplementationType;
				string importType = ImportType;

				if (Regex.IsMatch(implementationType.ToLower(), @"(string|bool)\[\]"))
					return (Regex.IsMatch(importType.ToLower(), @"(string|bool)\*"));
				if (implementationType.EndsWith("[]"))
					return (true);

				return (false);
			}
		}

		internal bool IsStrong(Registry registry)
		{
			if (ImplementationType == "bool")
				return (false);

			return ((IsSafe == true) && (Group != null) && (registry.Groups.FindIndex(delegate(EnumerantGroup item) { return (item.Name == Group); }) >= 0));
		}

		internal CommandParameter StronglyTyped(Registry registry)
		{
			CommandParameter param = (CommandParameter)MemberwiseClone();

			if (param.IsStrong(registry)) {
				param.Type = param.Group;
				param.TypeDecorator = null;
				param.OverridenParameter = this;
			}

			return (param);
		}

		public string ImplementationName
		{
			get { return (ImportName); }
		}

		public string ImportName
		{
			get { return (TypeMap.IsCsKeyword(Name) ? "@" + Name : Name); }
		}

		public string ImplementationType
		{
			get {
				string implementationType = ImportType;

				implementationType = implementationType.Replace("*", "[]");

				if (implementationType == "void[]")
					implementationType = "IntPtr";

				return (implementationType);
			}
		}

		public string ImportType
		{
			get
			{
				string typeDecorator = TypeDecorator != null ? TypeDecorator.Trim() : null;

				if (typeDecorator != null) {
					// glPathGlyphIndexRangeNV: <param><ptype>GLuint</ptype> <name>baseAndCount</name>[2]</param>
					if (Regex.Match(typeDecorator, @"\[\d+\]").Success)
						typeDecorator = "*";
				}

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

		public string FixedLocalVarName
		{
			get
			{
				string fixedName = String.Format("p_{0}", Name);

				return (TypeMap.IsCsKeyword(fixedName) ? "@" + fixedName : fixedName);
			}
		}

		public string DelegateCallVarName
		{
			get
			{
				string delegateVarName = ImplementationName;

				if ((ImplementationType == "IntPtr") && (ImportType != "IntPtr"))
					delegateVarName = String.Format("{0}.ToPointer()", ImplementationName);

				return (delegateVarName);
			}
		}

		#endregion
	}
}
