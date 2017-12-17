
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
	/// Registry command parameter.
	/// </summary>
	[DebuggerDisplay("CommandParameter: Name={Name} Group={Group} Length={Length} Type={Type}")]
	public class CommandParameter : ICommandParameter
	{
		#region Constructors

		/// <summary>
		/// Parameterless constructor.
		/// </summary>
		public CommandParameter()
		{
		
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="otherParam">
		/// Another CommandParameter to be copied.
		/// </param>
		public CommandParameter(CommandParameter otherParam)
		{
			if (otherParam == null)
				throw new ArgumentNullException(nameof(otherParam));

			Group = otherParam.Group;
			Length = otherParam.Length;
			Type = otherParam.Type;
			TypeDecorators = new List<string>(otherParam.TypeDecorators);
			Name = otherParam.Name;
			ParentCommand = otherParam.ParentCommand;

			OverridenParameter = otherParam;
		}

		#endregion

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
		public List<String> TypeDecorators = new List<String>();

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

		#region Length Management

		/// <summary>
		/// Get the length mode for this parameter.
		/// </summary>
		public CommandParameterLengthMode LengthMode
		{
			get
			{
				// No length information
				if (String.IsNullOrEmpty(Length))
					return (CommandParameterLengthMode.None);

				// Constant length?
				uint constLength;
				if (UInt32.TryParse(Length, out constLength))
					return (CommandParameterLengthMode.Constant);

				// Argument?
				if (ParentCommand.Parameters.Exists(delegate(CommandParameter item) { return (item.Name == Length); }))
					return (CommandParameterLengthMode.ArgumentReference);

				// Argument multiple?
				Match argumentMultipleMatch = Regex.Match(Length, @"(?<Arg>\w[\w\d_]*)\*(\d+)");
				if (argumentMultipleMatch.Success) {
					string argumentMultipleName = argumentMultipleMatch.Groups["Arg"].Value;
					if (ParentCommand.Parameters.Exists(delegate(CommandParameter item) { return (item.Name == argumentMultipleName); }))
						return (CommandParameterLengthMode.ArgumentMultiple);
				}

				return (CommandParameterLengthMode.Complex);
			}
		}

		public uint LengthConstant
		{
			get
			{
				uint constLength;

				if (UInt32.TryParse(Length, out constLength))
					return (constLength);

				throw new InvalidOperationException("not a const-length constraint");
			}
		}

		public string LengthArgument
		{
			get
			{
				Match argumentMultipleMatch = Regex.Match(Length, @"(?<Arg>\w[\w\d_]*)\*(?<Mul>\d+)");
				if (argumentMultipleMatch.Success)
					return (argumentMultipleMatch.Groups["Arg"].Value);

				throw new InvalidOperationException("not a multiple-length constraint");
			}
		}

		public uint LengthMultiple
		{
			get
			{
				Match argumentMultipleMatch = Regex.Match(Length, @"(?<Arg>\w[\w\d_]*)\*(?<Mul>\d+)");
				if (argumentMultipleMatch.Success) {
					string argumentMultipleValue = argumentMultipleMatch.Groups["Mul"].Value;
					
					return (UInt32.Parse(argumentMultipleValue));
				}

				throw new InvalidOperationException("not a multiple-length constraint");
			}
		}

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
		/// Determine whether this CommandParameter can be used in a safe context when marshalling argument.
		/// </summary>
		internal bool IsSafeMarshal(Command parentCommand)
		{
			if ((GetManagedImplementationType(parentCommand) == "IntPtr") && (GetImportType(parentCommand) != "IntPtr"))
				return (true);

			return (false);
		}

		/// <summary>
		/// Determine whether this CommandParameter must be used in a fixed context.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		internal virtual bool IsFixed(RegistryContext ctx, Command parentCommand)
		{
			string modifier = CommandFlagsDatabase.GetCommandArgumentModifier(parentCommand, this);
			if (modifier == "ref" || modifier == "out")
				return (false);

			string implementationType = GetManagedImplementationType(parentCommand);
			string importType = GetImportType(parentCommand);

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
			return (Type == "object");
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
		/// </remarks>
		public virtual string GetImplementationType(RegistryContext ctx, Command parentCommand)
		{
			string modifier = CommandFlagsDatabase.GetCommandArgumentModifier(parentCommand, this);
			string implementationType = GetManagedImplementationType(parentCommand);

			// Type[] + Length=1 -> out Type
			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length == "1") && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				implementationType = implementationType.Substring(0, implementationType.Length - 2);
			// String + Length!=null && !IsConst -> [Out] StringBuilder (in Get commands)
			if ((IsConstant == false) && (implementationType == "string") && (Length != null) && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				implementationType = "StringBuilder";
			// Support 'ref' argument
			if ((modifier == "ref" || modifier == "out") && implementationType.EndsWith("[]"))
				implementationType = modifier + " " + implementationType.Substring(0, implementationType.Length - 2);

			return (implementationType);
		}

		public string GetImplementationTypeModifier(RegistryContext ctx, Command parentCommand)
		{
			// Support ref argument
			if (ModifierOverride != null)
				return (ModifierOverride);

			string implementationType = GetManagedImplementationType(parentCommand);

			// Type[] + Length=1 -> out Type
			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length == "1") && (parentCommand.IsGetImplementation(ctx)))
				return ("out");
			// Type[] + Length=1 -> out Type
			if ((IsConstant == false) && implementationType.EndsWith("[]") && (Length == "1") && ((parentCommand.Flags & CommandFlags.OutParam) != 0))
				return ("out");

			return (null);
		}

		public string ModifierOverride;

		public string GetImplementationTypeAttributes(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = GetManagedImplementationType(parentCommand);
			string implementationMod = GetImplementationTypeModifier(ctx, parentCommand);
			string attribute = null;

			// String + Length!=null && !IsConst -> [Out] StringBuilder (in Get commands)
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				attribute = "[Out]";
			// Array && !IsConst -> [Out] T[] (in Get commands)
			if ((IsConstant == false) && (implementationType.EndsWith("[]")) && ((implementationMod != "out") && (implementationMod != "ref")) && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				attribute = "[Out]";

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
		public string GetManagedImplementationType(Command parentCommand)
		{
			string implementationType = GetImportType(parentCommand);

			implementationType = implementationType.Replace("*", "[]");

			// void* > IntPtr
			if (implementationType == "void[]")
				implementationType = "IntPtr";

			return (implementationType);
		}

		/// <summary>
		/// Get the command parameter name, without altering it for language conformance (i.e. the '@' escaping character).
		/// </summary>
		public string ImplementationNameRaw
		{
			get
			{
				if (ParentCommand != null) {
					string alternativeName = CommandFlagsDatabase.GetCommandArgumentAlternativeName(ParentCommand, this);

					return (alternativeName ?? Name);
				} else
					return (Name);
			}
		}

		/// <summary>
		/// Get the command parameter name.
		/// </summary>
		public string ImplementationName
		{
			get
			{
				string rawName = ImplementationNameRaw;

				return (TypeMap.IsCsKeyword(rawName) ? "@" + rawName : rawName);
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

		public virtual string GetDelegateCallVarName(Command parentCommand)
		{
			string delegateVarName = ImplementationName;

			if ((GetManagedImplementationType(parentCommand) == "IntPtr") && (GetImportType(parentCommand) != "IntPtr"))
				delegateVarName = String.Format("{0}.ToPointer()", ImplementationName);

			return (delegateVarName);
		}

		#endregion

		#region Code Generation - Delegate

		public string GetDelegateType(RegistryContext ctx, Command parentCommand)
		{
			string modifier = CommandFlagsDatabase.GetCommandArgumentModifier(parentCommand, this);
			string implementationType = GetImportType(parentCommand);

			// String + Length!=null -> [Out] StringBuilder
			if ((IsConstant == false) && (implementationType == "string") && (Length != null) && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				implementationType = "StringBuilder";
			// Support 'ref' argument
			if ((modifier == "ref" || modifier == "out") &&  implementationType.EndsWith("*"))
				implementationType = modifier + " " + implementationType.Substring(0, implementationType.Length - 1);

			return (implementationType.Trim());
		}

		public string GetDelegateTypeModifier(RegistryContext ctx, Command parentCommand)
		{
			return (null);
		}

		public string GetDelegateTypeAttributes(RegistryContext ctx, Command parentCommand)
		{
			string implementationType = GetManagedImplementationType(parentCommand);
			string attribute = null;

			// String + Length!=null -> [Out] StringBuilder
			if ((IsConstant == false) && (implementationType == "String") && (Length != null) && ((parentCommand.IsGetImplementation(ctx) || ((parentCommand.Flags & CommandFlags.OutParam) != 0))))
				attribute = "[Out]";

			switch (SpecificationType) {
				case "GLboolean":		// bool
					attribute = (attribute ?? String.Empty) + "[MarshalAs(UnmanagedType.I1)]";
					break;
				// Note: MarshalAsAttribute not applicable to bool*!
				//case "GLboolean*":		// bool[]
				//	attribute = (attribute ?? String.Empty) + "[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)]";
				//	break;
			}

			return (attribute);
		}

		#endregion

		#region Code Generation - Import

		public string GetImportType()
		{
			if (ParentCommand == null)
				throw new InvalidOperationException("no parent command");
			return (GetImportType(ParentCommand));
		}

		public string GetImportType(Command parentCommand)
		{
			string retype = CommandFlagsDatabase.GetCommandArgumentAlternativeType(parentCommand, this);
			if (retype != null)
				return (TypeMap.CsTypeMap.MapType(retype));

			return (ImportType);
		}

		private string SpecificationType
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

				if (type != null && type.StartsWith("const ")) {
					// Remove any const modifier at the beginning of the type
					// does .NET can take advantage of this information? AFAIK no
					type = type.Substring(5); // .Replace("const", String.Empty);
				}

				string importType = "IntPtr";

				if ((type != null) && (typeDecorator != null))
					importType = type + typeDecorator;
				else if (type != null)
					importType = type;
				else if (typeDecorator != null)
					importType = typeDecorator;

				return (importType);
			}
		}

		private string ImportType
		{
			get
			{
				string specificationType = SpecificationType;

				// Special type handling for GLboolean arrays as arguments: they are marshaled as bytes!
				switch (specificationType) {
					case "GLboolean*":
						specificationType = "byte*";
						break;
				}

				return (TypeMap.CsTypeMap.MapType(specificationType));
			}
		}

		public string ImportName
		{
			get { return (TypeMap.IsCsKeyword(Name) ? "@" + Name : Name); }
		}

		#endregion

		#region Code Generation - Common

		public bool IsManagedArray(RegistryContext ctx, Command parentCommand)
		{
			return (GetImplementationType(ctx, parentCommand).EndsWith("[]"));
		}

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

		public bool IsEnum
		{
			get
			{
                CommandFlagsDatabase.CommandItem.ParameterItemFlags paramFlags = CommandFlagsDatabase.GetCommandParameterFlags(ParentCommand, this);

                if ((paramFlags & CommandFlagsDatabase.CommandItem.ParameterItemFlags.LogAsEnum) != 0)
                    return (true);
                
				switch (Type) {
					case "GLenum":
					case "EGLenum":
						return (true);
					default:
						return (false);
				}
			}
		}

		#endregion

		#region Information Linkage

		public int GetCommandIndex(Command parentCommand)
		{
			return (parentCommand.Parameters.IndexOf(this));
		}

		/// <summary>
		/// The parent command which this command parameter belongs to.
		/// </summary>
		[XmlIgnore()]
		public Command ParentCommand;

		#endregion

		#region ICommandParameter Implementation

		public virtual bool IsImplicit(RegistryContext ctx, Command parentCommand) { return (false); }

		public virtual void WriteDebugAssertion(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			switch (LengthMode) {
				case CommandParameterLengthMode.Constant:
					// Note:
					// - The argument must be an Array instance
					if (IsManagedArray(ctx, parentCommand))
						sw.WriteLine("Debug.Assert({0}.Length >= {1});", ImplementationName, LengthConstant);
					break;
				case CommandParameterLengthMode.ArgumentMultiple:
					uint multiple = LengthMultiple;

					// Note:
					// - The array must provide 'n' elements for each unit in counter parameter
					if (IsManagedArray(ctx, parentCommand) && multiple > 1)
						sw.WriteLine("Debug.Assert({0}.Length > 0 && ({0}.Length % {1}) == 0, \"empty or not multiple of {1}\");", ImplementationName, multiple);
					break;
			}
		}

		public virtual void WriteFixedStatement(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsFixed(ctx, parentCommand) == false)
				return;

			string dereference = String.Empty;

			switch (GetImplementationTypeModifier(ctx, parentCommand)) {
				case "out":
				case "ref":
					dereference = "&";
					break;
			}

			sw.WriteLine("fixed ({0} {1} = {2}{3})", GetImportType(parentCommand), FixedLocalVarName, dereference, ImplementationName);
		}

		public virtual void WriteImplementationParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			sw.Write(GetDelegateCallVarName(parentCommand));
		}

		public virtual void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsFixed(ctx, parentCommand) == false) {
				string modifier = CommandFlagsDatabase.GetCommandArgumentModifier(parentCommand, this);

				if (modifier != null)
					sw.Write(modifier + " ");

				sw.Write(GetDelegateCallVarName(parentCommand));
			} else
				sw.Write(FixedLocalVarName);
		}

		public virtual void WriteCallLogFormatParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand, int paramIndex)
		{
			string implementationType = GetImplementationType(ctx, parentCommand);
			bool safeImplementationType = !implementationType.EndsWith("*") && implementationType != "IntPtr";

			if (safeImplementationType == false)
				sw.Write("0x{{{0}}}", paramIndex);
			else
				sw.Write("{{{0}}}", paramIndex);
		}

		public virtual void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			CommandFlagsDatabase.CommandItem.ParameterItemFlags parameterFlags = CommandFlagsDatabase.GetCommandParameterFlags(parentCommand, this);

			//if (((Type != null) && (Type == "GLenum")) || ((parameterFlags & CommandFlagsDatabase.CommandItem.ParameterItemFlags.LogAsEnum) != 0))
			//	sw.Write("LogEnumName({0})", ImplementationName);
			//else if (IsManagedArray && GetImplementationTypeModifier(ctx, parentCommand) != "out")
			//	sw.Write("LogValue({0})", ImplementationName);
			//else
				WriteCallLogArgParam(sw, ImplementationName, GetImplementationType(ctx, parentCommand));
		}

		public static void WriteCallLogArgParam(SourceStreamWriter sw, string implementationName, string implementationType)
		{
			if (implementationType.EndsWith("*"))
				sw.Write("new IntPtr({0})", implementationName);
			//else if (implementationType == "IntPtr")
			//	sw.Write("{0}.ToString(\"X8\")", implementationName);
			else
				sw.Write("{0}", implementationName);
		}

		public virtual void WritePinnedVariable(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			// No code for common parameter
		}

		public virtual void WriteUnpinCommand(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			// No code for common parameter
		}

		#endregion
	}
}
