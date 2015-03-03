
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
using System.Text;
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
		public readonly List<String> TypeDecorators = new List<String>();

		/// <summary>
		/// 
		/// </summary>
		public String TypeDecorator
		{
			get
			{
				if (TypeDecorators.Count > 0)
					return (TypeDecorators[TypeDecorators.Count - 1].Trim());

				return (null);
			}
		}

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

		#region Code Generation - Implementation

		/// <summary>
		/// Determine whether this CommandParameter can be used in a safe context.
		/// </summary>
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

		/// <summary>
		/// Determine whether this CommandParameter must be used in a fixed context.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		internal bool IsFixed(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ManagedImplementationType;
			string importType = ImportType;

			if (Regex.IsMatch(implementationType.ToLower(), @"(string|bool)\[\]"))
				return (Regex.IsMatch(importType.ToLower(), @"(string|bool)\*"));
			if (implementationType.EndsWith("[]"))
				return (true);

			return (false);
		}

		/// <summary>
		/// Determine whether this CommandParameter must be used in a pinned context.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		internal bool IsPinned(RegistryContext ctx, Command parentCommand)
		{
			return (Type == "Object");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		/// <remarks>
		/// <para>
		/// In the generale case, the implementation type corresponds to <see cref="ManagedImplementationType"/>.
		/// </para>
		/// <para>
		/// In the case the implementation type is a managed array, but the specification assert a length equals to
		/// 1, and <paramref name="parentCommand"/> is a "Get" implementation, the implementation type is converted
		/// to a basic type, with an "out" modifier.
		/// </para>
		/// <para>
		/// 
		/// </para>
		/// </remarks>
		public string GetImplementationType(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ManagedImplementationType;

			// Type[] + Length=1 -> out Type
			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length == "1") && (parentCommand.IsGetImplementation(ctx)))
				implementationType = implementationType.Substring(0, implementationType.Length - 2);
			// String + Length!=null && !IsConst -> [Out] StringBuilder (in Get commands)
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && (parentCommand.IsGetImplementation(ctx)))
				implementationType = "StringBuilder";

			return (implementationType);
		}

		public string GetImplementationTypeModifier(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ManagedImplementationType;

			// Type[] + Length=1 -> out Type
			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length == "1") && (parentCommand.IsGetImplementation(ctx)))
				return ("out");

			return (null);
		}

		public string GetImplementationTypeAttributes(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ManagedImplementationType;
			string attribute = null;

			// String + Length!=null && !IsConst -> [Out] StringBuilder (in Get commands)
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && (parentCommand.IsGetImplementation(ctx)))
				attribute = "[Out]";
			// Type[] + Length!=null + !IsConst -> [Out] StringBuilder
//			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length != null) && (parentCommand.IsGetImplementation(ctx)))
//				attribute = "[Out]";

			return (attribute);
		}

		/// <summary>
		/// Get the parameter type for managed implementation.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The parameter type for managed implementation is <see cref="ImportType"/> for basic (value) types. In
		/// the case the type is a pointer type (reference), translate the type to a managed array.
		/// </para>
		/// <para>
		/// In the case the <see cref="InputType"/> is a <code>void*</code>, is will be translated into <see cref="IntPtr"/>.
		/// </para>
		/// </remarks>
		private string ManagedImplementationType
		{
			get
			{
				string implementationType = ImportType;

				implementationType = implementationType.Replace("*", "[]");

				// void* > IntPtr
				if (implementationType == "void[]")
					implementationType = "IntPtr";

				return (implementationType);
			}
		}

		public string ImplementationName
		{
			get { return (ImportName); }
		}

		public string FixedLocalVarName
		{
			get
			{
				string fixedName = String.Format("p_{0}", Name);

				return (TypeMap.IsCsKeyword(fixedName) ? "@" + fixedName : fixedName);
			}
		}

		public string PinnedLocalVarName
		{
			get
			{
				string pinnedName = String.Format("pin_{0}", Name);

				return (TypeMap.IsCsKeyword(pinnedName) ? "@" + pinnedName : pinnedName);
			}
		}

		public string DelegateCallVarName
		{
			get
			{
				string delegateVarName = ImplementationName;

				if ((ManagedImplementationType == "IntPtr") && (ImportType != "IntPtr"))
					delegateVarName = String.Format("{0}.ToPointer()", ImplementationName);

				return (delegateVarName);
			}
		}

		#endregion

		#region Code Generation - Overloads

		internal CommandParameter GetStronglyTypedParam(RegistryContext ctx, Command parentCommand)
		{
			CommandParameter param = (CommandParameter)MemberwiseClone();

			if (param.IsStrongCompatible(ctx, parentCommand)) {
				param.Type = param.Group;
				param.TypeDecorators.Clear();
				param.OverridenParameter = this;
			}

			return (param);
		}

		internal bool IsStrongCompatible(RegistryContext ctx, Command parentCommand)
		{
			if (GetImplementationType(ctx, parentCommand) == "bool")
				return (false);

			return ((IsSafe == true) && (Group != null) && (ctx.Registry.Groups.FindIndex(delegate(EnumerantGroup item) { return (item.Name == Group); }) >= 0));
		}

		internal CommandParameter GetPinnedObjectParam(RegistryContext ctx, Command parentCommand)
		{
			CommandParameter param = (CommandParameter)MemberwiseClone();

			if (param.IsPinnedCompatible(ctx, parentCommand)) {
				param.Type = "Object";
				param.TypeDecorators.Clear();
				param.OverridenParameter = this;
			}

			return (param);
		}

		internal bool IsPinnedCompatible(RegistryContext ctx, Command parentCommand)
		{
			return (IsConstant && (GetImplementationType(ctx, parentCommand) == "IntPtr"));
		}

		#endregion

		#region Code Generation - Delegate

		public string GetDelegateType(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ImportType;

			// String + Length!=null -> [Out] StringBuilder
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && (parentCommand.IsGetImplementation(ctx)))
				implementationType = "StringBuilder";

			return (implementationType.Trim());
		}

		public string GetDelegateTypeModifier(RegistryContext ctx, Command parentCommand)
		{
			return (null);
		}

		public string GetDelegateTypeAttributes(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = ManagedImplementationType;
			string attribute = null;

			// String + Length!=null -> [Out] StringBuilder
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && (parentCommand.IsGetImplementation(ctx)))
				attribute = "[Out]";

			return (attribute);
		}

		#endregion

		#region Code Generation - Import

		public string ImportType
		{
			get
			{
				string typeDecorator = TypeDecorator != null ? TypeDecorator.Trim() : null;
				string type = Type != null ? Type.Trim() : null;

				if (typeDecorator != null) {
					// glPathGlyphIndexRangeNV: <param><ptype>GLuint</ptype> <name>baseAndCount</name>[2]</param>
					if (Regex.Match(typeDecorator, @"\[\d+\]").Success)
						typeDecorator = "*";
				}

				if (type != null) {
					// Remove any const modifier
					type = type.Replace("const", String.Empty);
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

		public string ImportName
		{
			get { return (TypeMap.IsCsKeyword(Name) ? "@" + Name : Name); }
		}

		#endregion

		#region Code Generation - Common

		public bool IsConstant
		{
			get
			{
				if (TypeDecorators.FindIndex(delegate(string item) { return (item.Trim() == "const"); }) >= 0)
					return (true);

				if ((TypeDecorators.Count == 1) && (TypeDecorators[0].StartsWith("const")))
					return (true);

				return (false);
			}
		}

		#endregion
	}
}
