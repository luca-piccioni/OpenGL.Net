
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
	/// Registry command.
	/// </summary>
	[DebuggerDisplay("Command: Prototype={Prototype} Comment={Comment}")]
	public class Command
	{
		#region Specification

		/// <summary>
		/// GLX protocol element.
		/// </summary>
		[DebuggerDisplay("GlxProto: Type={Type} Code={Code}")]
		public class GlxProto
		{
			/// <summary>
			/// GLX command type.
			/// </summary>
			[XmlAttribute("type")]
			public String Type;

			/// <summary>
			/// GLX command code.
			/// </summary>
			[XmlAttribute("opcode")]
			public String Code;

			/// <summary>
			/// GLX command name.
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
		/// Command alias information.
		/// </summary>
		[DebuggerDisplay("CommandAlias: Name={" + nameof(Name) + "}")]
		public class CommandAlias
		{
			#region Specification

			/// <summary>
			/// Arbitrary string.
			/// </summary>
			[XmlAttribute("name")]
			public String Name;

			#endregion
		}

		/// <summary>
		/// Vector command alias information.
		/// </summary>
		[DebuggerDisplay("VectorCommandAlias: Name={" + nameof(Name) + "}")]
		public class VectorCommandAlias
		{
			/// <summary>
			/// Vector equivalent command name.
			/// </summary>
			[XmlAttribute("name")]
			public string Name;
		}

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public string Comment;

		/// <summary>
		/// Command prototype.
		/// </summary>
		[XmlElement("proto")]
		public CommandPrototype Prototype;

		/// <summary>
		/// Command parameters.
		/// </summary>
		[XmlElement("param")]
		public readonly List<CommandParameter> Parameters = new List<CommandParameter>();

		private List<CommandParameter> GetDefaultParameters(RegistryContext ctx)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameter(commandParameter));

			return (parameters);
		}

		private List<CommandParameter> GetStrongParameters(RegistryContext ctx)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameterStrong(commandParameter, ctx, this));

			return (parameters);
		}

		private List<CommandParameter> GetPinnedParameters(RegistryContext ctx, bool strong)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameterPinned(commandParameter, ctx, this, strong));

			return (parameters);
		}

		private List<CommandParameter> GetOutParameters(RegistryContext ctx, bool strong)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameterOut(commandParameter, ctx, this, strong));

			return (parameters);
		}

		private List<CommandParameter> GetOutLastParameters(RegistryContext ctx)
		{
			List<CommandParameter> parameters = GetDefaultParameters(ctx);

			parameters.RemoveAt(parameters.Count - 1);
			parameters.Add(new CommandParameterOut(Parameters[Parameters.Count - 1], ctx, this, false));

			return (parameters);
		}

		private List<CommandParameter> GetArrayLengthParameters(RegistryContext ctx)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameterArrayLength(commandParameter, ctx, this));

			return (parameters);
		}

		private List<CommandParameter> GetUnsafeParameters(RegistryContext ctx)
		{
			List<CommandParameter> parameters = new List<CommandParameter>();

			foreach (CommandParameter commandParameter in Parameters)
				parameters.Add(new CommandParameterUnsafe(commandParameter, ctx, this));

			return (parameters);
		}

		/// <summary>
		/// Command alias.
		/// </summary>
		[XmlElement("alias")]
		public CommandAlias Alias;

		/// <summary>
		/// Vector command alias.
		/// </summary>
		[XmlElement("vecequiv")]
		public VectorCommandAlias VectorAlias;

		/// <summary>
		/// GLX protocol information.
		/// </summary>
		[XmlElement("glx")]
		public readonly List<GlxProto> Glx = new List<GlxProto>();

		#endregion

		#region Declared Aliases

		/// <summary>
		/// List of <see cref="Command"/> that are equivalent to this Command.
		/// </summary>
		[XmlIgnore()]
		public readonly List<Command> Aliases = new List<Command>();

		#endregion

		#region Code Generation - Import

		/// <summary>
		/// Get the name of the command import.
		/// </summary>
		private string ImportName
		{
			get { return (Prototype.Name); }
		}

		#endregion

		#region Code Generation - Delegate

		/// <summary>
		/// Get the name of the command delegate.
		/// </summary>
		private string DelegateName
		{
			get { return ("p" + ImportName); }
		}

		/// <summary>
		/// Get the delegate return type.
		/// </summary>
		private string DelegateReturnType
		{
			get
			{
				if (Regex.IsMatch(Prototype.DelegateReturnType, @"(Gl|Glx|Wgl)\.\w+") == true)
					return ("IntPtr");
				else
					return (Prototype.DelegateReturnType);
			}
		}

		/// <summary>
		/// Generate the command delegate source code.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		internal void GenerateDelegate(SourceStreamWriter sw, RegistryContext ctx)
		{
			// Attributes required for checking API commands support
			string classDefaultApi = ctx.Class.ToLower();

			foreach (IFeature feature in RequiredBy)
				sw.WriteLine(feature.GenerateRequiredByAttribute(/* EntryPoint not required */ null, classDefaultApi));

			foreach (IFeature feature in RemovedBy)
				sw.WriteLine(feature.GenerateRemovedByAttribute(classDefaultApi));

			// Not yet sure if it is really necessary
			sw.WriteLine("[SuppressUnmanagedCodeSecurity]");

			// return: MarshalAs
			switch (Prototype.Type) {
				case "GLboolean":			// <type>typedef unsigned char <name>GLboolean</name>;</type> (gl.xml)
					sw.WriteLine("[return: MarshalAs(UnmanagedType.I1)]");
					break;
				case "BOOL":				// typedef int BOOL; (WinDef.h)
				case "EGLBoolean":			// <type>typedef unsigned int <name>EGLBoolean</name>;</type> (egl.xml)
				case "Bool":				// #define Bool int (XLib.h)
				case "WFCboolean":			// typedef enum { } WFCboolean; (wfc.h) -.-
					// Default marshaler
					// sw.WriteLine("[return: MarshalAs(UnmanagedType.I4)]");
					break;
				default:
					// None
					break;
			}

			// Delegate type definition
			sw.WriteIdentation(); sw.Write("internal "); sw.Write("delegate ");

			sw.Write("{0} {1}(", DelegateReturnType, ImportName);

			int paramCount = Parameters.Count;

			foreach (CommandParameter param in Parameters) {
				string paramAttributes = param.GetDelegateTypeAttributes(ctx, this);
				string paramModifier = param.GetDelegateTypeModifier(ctx, this);

				if (paramAttributes != null)
					sw.Write("{0} ", paramAttributes);
				if (paramModifier != null)
					sw.Write("{0} ", paramModifier);


				sw.Write("{0} {1}", param.GetDelegateType(ctx, this), param.ImportName);
				paramCount--;
				if (paramCount > 0)
					sw.Write(", ");
			}
			sw.Write(");");
			sw.WriteLine();

			sw.WriteLine();

			foreach (IFeature feature in RequiredBy)
				sw.WriteLine(feature.GenerateRequiredByAttribute(this, classDefaultApi));

			foreach (IFeature feature in RemovedBy)
				sw.WriteLine(feature.GenerateRemovedByAttribute(classDefaultApi));

			// Multithreaded GL support
			// Required on Windows platform: different threads can bind different OpenGL context, which can have different entry points
			if (ctx.Class == "Gl")
				sw.WriteLine("[ThreadStatic]");

			// Delegate field
			sw.WriteLine("internal static {0} {1};", ImportName, DelegateName);
		}

		#endregion

		#region Code Generation - Implementation

		/// <summary>
		/// Get the name of the command implementation (without overloading).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		private string GetImplementationNameBase(RegistryContext ctx)
		{
			string implementationName = ImportName;
			string prefix = ctx.Class.ToLower();

			if (prefix == "glx")
				prefix = "glX";

			if (implementationName.StartsWith(prefix))
				implementationName = implementationName.Substring(prefix.Length);

			return (implementationName);
		}

		/// <summary>
		/// Get the name of the command implementation (with overloading).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> used for manipulating the command import name.
		/// </param>
		internal string GetImplementationName(RegistryContext ctx)
		{
			string overridenName = CommandFlagsDatabase.GetCommandImplementationName(this);

			if (overridenName == null) {
				string implementationName = GetImplementationNameBase(ctx);

				return (ctx.WordsDictionary.GetOverridableName(ctx, implementationName));
			} else
				return (overridenName);
		}

		/// <summary>
		/// Get the name of the command implementation (with overloading).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> used for manipulating the command import name.
		/// </param>
		internal string GetImplementationName(RegistryContext ctx, out string extensionName)
		{
			string overridenName = CommandFlagsDatabase.GetCommandImplementationName(this);

			if (overridenName == null) {
				string implementationName = GetImplementationNameBase(ctx);

				overridenName = ctx.WordsDictionary.GetOverridableName(ctx, implementationName);
			}

			// Determine extension name, if any
			extensionName = String.Empty;

			foreach (string extName in ctx.ExtensionsDictionary.Words) {
				if (overridenName.EndsWith(extName)) {
					extensionName = extName;
					break;
				}
			}

			return (overridenName);
		}

		/// <summary>
		/// Get the local variable storing the returned value.
		/// </summary>
		private string ReturnVariableName => "retValue";

		/// <summary>
		/// Get the implementation return type.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		private string GetImplementationReturnType(RegistryContext ctx)
		{
			if ((Prototype.Group != null) && (ctx.Registry.Groups.FindIndex(delegate(EnumerantGroup item) { return (item.Name == Prototype.Group); }) >= 0)) {
				if (Prototype.Group != "Boolean")
					return (Prototype.Group);
			}

			return (Prototype.ImplementationReturnType);
		}

		/// <summary>
		/// Determine whether the command implementation requires unsafe signature.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the method implementation parameters requires
		/// a fixed statement.
		/// </returns>
		private bool IsUnsafeImplementationSignature(RegistryContext ctx, List<CommandParameter> commandParams)
		{
			// Return type is a pointer
			if (GetImplementationReturnType(ctx).EndsWith("*"))
				return (true);

			// At least one command parameter is a CommandParameterUnsafe
			if (commandParams.Exists(delegate (CommandParameter item) { return (item is CommandParameterUnsafe); }))
				return (true);

			return (false);
		}

		/// <summary>
		/// Determine whether the command implementation requires fixed statement(s).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the method implementation parameters requires
		/// a fixed statement.
		/// </returns>
		private bool IsFixedImplementation(RegistryContext ctx, List<CommandParameter> commandParams)
		{
			foreach (CommandParameter param in commandParams)
				if (param.IsFixed(ctx, this))
					return (true);

			return (false);
		}

		/// <summary>
		/// Determine whether the command implementation requires fixed statement(s).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the method implementation parameters requires
		/// a fixed statement.
		/// </returns>
		private bool IsSafeMarshalImplementation(RegistryContext ctx, List<CommandParameter> commandParams)
		{
			foreach (CommandParameter param in commandParams)
				if (param.IsSafeMarshal(this))
					return (true);

			return (false);
		}

		/// <summary>
		/// Determine whether the command implementation requires GC pinned statement(s).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the method implementation parameters requires
		/// a pinned statement.
		/// </returns>
		private bool IsPinnedImplementation(RegistryContext ctx, List<CommandParameter> commandParams)
		{
			foreach (CommandParameter param in commandParams)
				if (param.IsPinned(ctx, this))
					return (true);

			return (false);
		}

		/// <summary>
		/// Generate a list of function parameters determining the overloaded methods.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <returns></returns>
		private List<CommandParameter>[] GetOverridenImplementations(RegistryContext ctx)
		{
			List<List<CommandParameter>> overridenParameters = new List<List<CommandParameter>>();

			// Force plain parameters
			bool plainParams = (Flags & CommandFlags.ForcePlainParams) != 0;
			// At least an array parameter that can out 1 element only
			bool outParamCompatible = CommandParameterOut.IsCompatible(ctx, this);
			// The last parameter is 'out-compatible', and flags allow to generate the override
			bool outLastParamCompatible = ((Flags & CommandFlags.OutParamLast) != 0) && CommandParameterOut.IsCompatible(ctx, this, Parameters[Parameters.Count - 1]);
			// At least a parameter that have a strongly typed representation
			bool isStrongCompatible = CommandParameterStrong.IsCompatible(ctx, this);
			// At least a parameter in meant as pointer/array, that can be represented using structs
			bool isPinnedObjCompatible = CommandParameterPinned.IsCompatible(ctx, this);
			// At least one parameter is an array with length correlated with another parameter
			bool isArrayLengthCompatible = CommandParameterArrayLength.IsCompatible(ctx, this);
			// At least one parameter is a pointer, 
			bool isUnsafeCompatible = ((Flags & CommandFlags.UnsafeParams) != 0) && CommandParameterUnsafe.IsCompatible(ctx, this);

			// Standard implementation - default
			if (plainParams || (!isArrayLengthCompatible && !isStrongCompatible))
				overridenParameters.Add(Parameters);

			// Strongly typed implementation
			if (isStrongCompatible)
				overridenParameters.Add(GetStrongParameters(ctx));

			// Pinned object implementation
			if (isPinnedObjCompatible) {
				if (plainParams && isStrongCompatible)
					overridenParameters.Add(GetPinnedParameters(ctx, false));
				overridenParameters.Add(GetPinnedParameters(ctx, true));
			}

			// Out modifier implementation
			if (outParamCompatible && !outLastParamCompatible) {
				if (plainParams && isStrongCompatible)
					overridenParameters.Add(GetOutParameters(ctx, false));
				overridenParameters.Add(GetOutParameters(ctx, true));
			}

			// Out modifier implementation (last parameter only)
			if (outLastParamCompatible)
				overridenParameters.Add(GetOutLastParameters(ctx));

			// Array Length overrides
			if (isArrayLengthCompatible)
				overridenParameters.Add(GetArrayLengthParameters(ctx));

			if (isUnsafeCompatible)
				overridenParameters.Add(GetUnsafeParameters(ctx));

			return (overridenParameters.ToArray());
		}

		/// <summary>
		/// Generate the command implementations source code (all overloads).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		internal void GenerateImplementations(SourceStreamWriter sw, RegistryContext ctx)
		{
			List<CommandParameter>[] overridenParams = GetOverridenImplementations(ctx);

			for (int i = 0; i < overridenParams.Length; i++) {
				// Generate implementation
				GenerateImplementation(sw, ctx, overridenParams[i]);
				// Separate next implementation with a new line, if not the last
				if (i < overridenParams.Length - 1)
					sw.WriteLine();
			}

			if (IsGenImplementation(ctx)) {
				sw.WriteLine();
				GenerateImplementation_GenOneObject(sw, ctx);
			}

			if ((CommandFlagsDatabase.GetCommandFlags(this) & CommandFlags.GenericParams) != 0) {
				sw.WriteLine();
				GenerateImplementation_Generics(sw, ctx);
			}
		}

		/// <summary>
		/// Generate the command implementation source code.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		private void GenerateImplementation(SourceStreamWriter sw, RegistryContext ctx, List<CommandParameter> commandParams)
		{
			bool isPinnedImplementation = commandParams.FindIndex(delegate(CommandParameter item) { return (item is CommandParameterPinned); }) >= 0;

			if (!isPinnedImplementation)
				GenerateImplementation_Default(sw, ctx, commandParams);
			else
				GenerateImplementation_Pinned(sw, ctx, commandParams);
		}

		/// <summary>
		/// Generate the command implementation signature and the method documentation.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		private void GenerateImplementation_Signature(SourceStreamWriter sw, RegistryContext ctx, List<CommandParameter> commandParams)
		{
			GenerateImplementation_Signature(sw, ctx, commandParams, GetImplementationName(ctx), GetImplementationReturnType(ctx), null);
		}

		/// <summary>
		/// Generate the command implementation signature and the method documentation.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		private void GenerateImplementation_Signature(SourceStreamWriter sw, RegistryContext ctx, List<CommandParameter> commandParams, string implementationName, string returnType, string constraints)
		{
			// Documentation
			if (ctx.RefPages.Count > 0)
				ctx.RefPages.GenerateDocumentation(sw, ctx, this, true, commandParams);

			string classDefaultApi = ctx.Class.ToLower();

			foreach (IFeature feature in RequiredBy)
				sw.WriteLine(feature.GenerateRequiredByAttribute(null /* Not required */, classDefaultApi));

			foreach (IFeature feature in RemovedBy)
				sw.WriteLine(feature.GenerateRemovedByAttribute(classDefaultApi));

			#region Signature

			sw.WriteIdentation();

			// Signature
			sw.Write("{0} static ", CommandFlagsDatabase.GetCommandVisibility(this));
			if (IsUnsafeImplementationSignature(ctx, commandParams))
				sw.Write("unsafe ");
			sw.Write("{0} {1}(", returnType, implementationName);
			// Signature - Parameters
			int paramCount = commandParams.FindAll(delegate(CommandParameter item) { return (!item.IsImplicit(ctx, this)); }).Count;

			foreach (CommandParameter param in commandParams) {
				// Skip in signature implicit parameters
				if (param.IsImplicit(ctx, this))
					continue;

				string paramAttributes = param.GetImplementationTypeAttributes(ctx, this);
				string paramModifier = param.GetImplementationTypeModifier(ctx, this);

				if (paramAttributes != null)
					sw.Write("{0} ", paramAttributes);
				if (paramModifier != null)
					sw.Write("{0} ", paramModifier);

				if ((paramCount == 1) && (param.IsManagedArray(ctx, this)) && ((Flags & CommandFlags.VariadicParams) != 0))
					sw.Write("params ");

				sw.Write("{0} {1}", param.GetImplementationType(ctx, this), param.ImplementationName);
				paramCount--;
				if (paramCount > 0)
					sw.Write(", ");
			}
			sw.Write(")");

			// Write method constrains
			if (constraints != null)
				sw.Write(" " + constraints);

			sw.WriteLine();

			#endregion
		}

		/// <summary>
		/// Generate the command implementation (fixed variant).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		private void GenerateImplementation_Default(SourceStreamWriter sw, RegistryContext ctx, List<CommandParameter> commandParams)
		{
			Command aliasCommand = this;

			// The implementation returned type
			string returnType = aliasCommand.GetImplementationReturnType(ctx);
			// Is fixed implementation
			bool fixedImplementation = IsFixedImplementation(ctx, commandParams) || IsSafeMarshalImplementation(ctx, commandParams);

			// Signature
			GenerateImplementation_Signature(sw, ctx, commandParams);

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			#region Debug Assertions

			// Debug assertions
			foreach (CommandParameter param in commandParams)
				param.WriteDebugAssertion(sw, ctx, this);

			#endregion

			#region Local Variables

			// Local variable: returned value
			if (HasReturnValue) {
				sw.WriteLine("{0} {1};", DelegateReturnType, ReturnVariableName);
				sw.WriteLine();
			}

			#endregion

			#region Unsafe Block (Open)

			if (fixedImplementation) {
				sw.WriteLine("unsafe {");								// (1)
				sw.Indent();

				foreach (CommandParameter param in commandParams)
					param.WriteFixedStatement(sw, ctx, this);

				sw.WriteLine("{");										// (2)
				sw.Indent();
			}

			#endregion

			sw.WriteLine("Debug.Assert(Delegates.{0} != null, \"{0} not implemented\");", aliasCommand.DelegateName);

			#region Delegate Call

			sw.WriteIdentation();

			// Local return value
			if (HasReturnValue) 
				sw.Write("{0} = ", ReturnVariableName);

			sw.Write("Delegates.{0}(", aliasCommand.DelegateName);

			#region Parameters

			for (int i = 0; i < commandParams.Count; i++) {
				CommandParameter param = commandParams[i];

				param.WriteDelegateParam(sw, ctx, this);

				if (i != Parameters.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			sw.Write(";");
			sw.WriteLine();

			#endregion

			#region Call Log

			// Log command
			sw.WriteIdentation(); sw.Write("LogCommand(\"{0}\"", aliasCommand.ImportName);
			// Return value
			if (HasReturnValue) {
				sw.Write(", ");
				CommandParameter.WriteCallLogArgParam(sw, GetReturnValueExpression(ctx), returnType);
			} else {
				sw.Write(", null");
			}
			// Arguments
			if (commandParams.Count > 0) {
				sw.Write(", ");
				for (int i = 0; i < commandParams.Count; i++) {
					commandParams[i].WriteCallLogArgParam(sw, ctx, this);
					if (i < commandParams.Count - 1)
						sw.Write(", ");
				}
			}
			// End LogCommand
			sw.WriteLine(");");

			#endregion

			#region Unsafe Block (Close)

			if (fixedImplementation)
			{
				sw.Unindent();
				sw.WriteLine("}");										// (2) CLOSED
				sw.Unindent();
				sw.WriteLine("}");										// (1) CLOSED
			}

			#endregion

			// Check call errors
			if ((Flags & CommandFlags.NoGetError) == 0) {
				string returnValue = "null";

				// Optionally pass the returned value to error checking method
				if (HasReturnValue && !IsUnsafeImplementationSignature(ctx, commandParams))
					returnValue = ReturnVariableName;

				sw.WriteLine("DebugCheckErrors({0});", returnValue);
			}

			// Returns value
			if (HasReturnValue) {
				sw.WriteLine();
				sw.WriteLine("return ({0});", GetReturnValueExpression(ctx));
			}

			sw.Unindent();
			sw.WriteLine("}");
		}

		/// <summary>
		/// Generate the command implementation (pinned variant).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <param name="commandParams">
		/// A <see cref="T:List{CommandParameter}"/> determining the method overload.
		/// </param>
		private void GenerateImplementation_Pinned(SourceStreamWriter sw, RegistryContext ctx, List<CommandParameter> commandParams)
		{
			// Signature
			GenerateImplementation_Signature(sw, ctx, commandParams);

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			#region Pinned Object Block (Open)

			foreach (CommandParameter param in commandParams)
				param.WritePinnedVariable(sw, ctx, this);

			sw.WriteLine("try {");
			sw.Indent();

			#endregion

			#region Implementation Call

			sw.WriteIdentation();
			if (HasReturnValue)
				sw.Write("return (");

			sw.Write("{0}(", GetImplementationName(ctx));

			#region Parameters

			for (int i = 0; i < commandParams.Count; i++) {
				CommandParameter param = commandParams[i];

				param.WriteDelegateParam(sw, ctx, this);

				if (i != commandParams.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			if (HasReturnValue)
				sw.Write(")");
			sw.Write(";");
			sw.WriteLine();

			#endregion

			#region Pinned Object Block (Close)

			sw.Unindent();
			sw.WriteLine("} finally {");
			sw.Indent();

			foreach (CommandParameter param in commandParams)
				param.WriteUnpinCommand(sw, ctx, this);

			sw.Unindent();
			sw.WriteLine("}");

			#endregion

			sw.Unindent();
			sw.WriteLine("}");
		}

		/// <summary>
		/// Generate the command implementation (generate one object variant).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		private void GenerateImplementation_GenOneObject(SourceStreamWriter sw, RegistryContext ctx)
		{
			List<CommandParameter> commandParams = new List<CommandParameter>();

			// Remove plularity suffix
			string implementationName = GetSingularMethodName(ctx);

			// Force parameter type implementation
			foreach (CommandParameter commandParameter in Parameters)
				commandParams.Add(new CommandParameterArrayLength(commandParameter, ctx, this));

			List<CommandParameterArrayLength> arrayParameters = new List<CommandParameterArrayLength>();
			List<CommandParameter> signatureParams = commandParams.FindAll(delegate(CommandParameter item) {
				bool compatible = CommandParameterArrayLength.IsCompatible(ctx, this, item);
				bool arrayLengthParam = CommandParameterArrayLength.IsArrayLengthParameter(item, ctx, this);

				if (compatible)
					arrayParameters.Add((CommandParameterArrayLength)item);

				return (!compatible && !arrayLengthParam);
			});

			Debug.Assert(arrayParameters.Count == 1);
			CommandParameterArrayLength returnParameter = arrayParameters[0];
			string returnParameterType = returnParameter.GetImplementationType(ctx, this);

			// Remove []
			returnParameterType = returnParameterType.Substring(0, returnParameterType.Length - 2);

			// Signature
			GenerateImplementation_Signature(sw, ctx, signatureParams, implementationName, returnParameterType, null);

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			#region Local Variables

			sw.WriteLine("{0} {1};", returnParameterType, ReturnVariableName);

			#endregion

			#region Unsafe Block (Open)

			sw.WriteLine("unsafe {");								// (1)
			sw.Indent();

			#endregion

			#region Delegate Call

			sw.WriteIdentation();
			sw.Write("Delegates.{0}(", DelegateName);

			#region Parameters

			for (int i = 0; i < commandParams.Count; i++) {
				CommandParameter param = commandParams[i];

				if      (CommandParameterArrayLength.IsArrayLengthParameter(param, ctx, this))
					sw.Write("1");
				else if (CommandParameterArrayLength.IsCompatible(ctx, this, param))
					sw.Write("&" + ReturnVariableName);
				else if (CommandParameterStrong.IsCompatible(ctx, this, param))
					param.WriteDelegateParam(sw, ctx, this);
				else
					param.WriteDelegateParam(sw, ctx, this);

				if (i != commandParams.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			sw.Write(";");
			sw.WriteLine();

			#region Call Log

			// Log command
			sw.WriteIdentation(); sw.Write("LogCommand(\"{0}\"", ImportName);
			sw.Write(", null");
			// Arguments
			if (commandParams.Count > 0) {
				sw.Write(", ");
				for (int i = 0; i < commandParams.Count; i++) {
					CommandParameter param = commandParams[i];

					if      (CommandParameterArrayLength.IsArrayLengthParameter(param, ctx, this))
						sw.Write("1");
					else if (CommandParameterArrayLength.IsCompatible(ctx, this, param))
						sw.Write("\"{ \" + " + ReturnVariableName + " + \" }\"");
					else
						commandParams[i].WriteCallLogArgParam(sw, ctx, this);

					if (i < commandParams.Count - 1)
						sw.Write(", ");
				}
			}
			// End LogCommand
			sw.WriteLine(");");

			#endregion

			#endregion

			#region Unsafe Block (Close)

			sw.Unindent();
			sw.WriteLine("}");										// (1) CLOSED

			#endregion

			// Check call errors
			if ((Flags & CommandFlags.NoGetError) == 0) {
				string returnValue = "null";

				// Optionally pass the returned value to error checking method
				if (HasReturnValue && !IsUnsafeImplementationSignature(ctx, commandParams))
					returnValue = ReturnVariableName;

				sw.WriteLine("DebugCheckErrors({0});", returnValue);
			}

			sw.WriteLine("return ({0});", ReturnVariableName);

			sw.Unindent();
			sw.WriteLine("}");
		}

		private string GetSingularMethodName(RegistryContext ctx)
		{
			// Remove plularity suffix
			string implementationExtension;
			string implementationName = GetImplementationName(ctx, out implementationExtension);

			implementationName = implementationName.Substring(0, implementationName.Length - implementationExtension.Length);

			if      (implementationName.EndsWith("ies"))
				implementationName = implementationName.Substring(0, implementationName.Length - 3) + "y";
			else if (implementationName.EndsWith("s"))
				implementationName = implementationName.Substring(0, implementationName.Length - 1);

			return (implementationName + implementationExtension);
		}

		/// <summary>
		/// Generate the command implementation (generic variant).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		private void GenerateImplementation_Generics(SourceStreamWriter sw, RegistryContext ctx)
		{
			Command aliasCommand = this;

			// The implementation returned type
			string returnType = aliasCommand.GetImplementationReturnType(ctx);

			// Identify the generic argument:
			// - It must a array/pointer type
			// - It must be the last one
			List<CommandParameter> genericParameters = GetStrongParameters(ctx);

			CommandParameter genericParam = genericParameters[genericParameters.Count - 1];
			CommandParameter originalParam = Parameters[Parameters.Count - 1];

			if (genericParam.IsManagedArray(ctx, this) == false)
				throw new NotSupportedException("generic parameter is not an array");

			// Change the argument in order to have a generic ref
			genericParam.Type = "T";
			genericParam.TypeDecorators.Clear();
			genericParam.ModifierOverride = IsGetImplementation(ctx) ? "out" : null;
			
			// Determine the method name
			// - It must end with 'v'
			// - It must include the argument type (i.e. glUniform2iv -> Uniform2i)
			string implementationName = Prototype.Name.Substring(ctx.Class.Length);
			string extensionPostfix;
			string apiImplementationName = GetImplementationName(ctx, out extensionPostfix);

			if (implementationName.EndsWith(extensionPostfix))
				implementationName = implementationName.Substring(0, implementationName.Length - extensionPostfix.Length);

			if      (implementationName.EndsWith("i_v"))	// Special for glGetFloati_v -> glGetFloat with 3 params
				implementationName = implementationName.Substring(0, implementationName.Length - 3);
			else if (implementationName.EndsWith("v"))
				implementationName = implementationName.Substring(0, implementationName.Length - 1);

			if (extensionPostfix != null)
				implementationName = implementationName + extensionPostfix;

			// Signature (generic with constraints
			GenerateImplementation_Signature(sw, ctx, genericParameters, implementationName + "<T>", GetImplementationReturnType(ctx), "where T : struct");

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			sw.WriteLine("Debug.Assert(Delegates.{0} != null, \"{0} not implemented\");", DelegateName);

			if (genericParam.ModifierOverride == "out")
				sw.WriteLine("{0} = default(T);", genericParam.ImplementationName);

			sw.WriteLine("#if NETCOREAPP1_1");

			#region .NET Core 1.1

			sw.WriteLine("GCHandle valueHandle = GCHandle.Alloc({0});", genericParam.ImplementationName);
			sw.WriteLine("try {");
			sw.Indent();

			sw.WriteLine("unsafe {");
			sw.Indent();

			#region Delegate Call

			sw.WriteIdentation();

			// Local return value
			if (HasReturnValue) 
				sw.Write("{0} = ", ReturnVariableName);

			sw.Write("Delegates.{0}(", DelegateName);

			#region Parameters

			for (int i = 0; i < genericParameters.Count; i++) {
				CommandParameter param = genericParameters[i];

				if (i < genericParameters.Count - 1) {
					param.WriteDelegateParam(sw, ctx, this);
				} else {
					sw.Write("({0}){1}.ToPointer()", originalParam.GetImportType(this), "valueHandle.AddrOfPinnedObject()");
				}

				if (i != Parameters.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			sw.Write(";");
			sw.WriteLine();
			sw.Unindent();

			#endregion

			sw.WriteLine("}");
			sw.Unindent();

			sw.WriteLine("} finally {");
			sw.Indent();
			sw.WriteLine("valueHandle.Free();");
			sw.Unindent();
			sw.WriteLine("}");

			#endregion

			sw.WriteLine("#else");

			#region Default: __makeref

			// Unsafe block
			sw.WriteLine("unsafe {");
			sw.Indent();

			#region Local Variables

			string typedReferenceVarName = "ref" + SpecificationStyle.GetCamelCase(genericParam.Name);
			string typedReferencePtrVarName = "ref" + SpecificationStyle.GetCamelCase(genericParam.Name) + "Ptr";

			sw.WriteLine("TypedReference {0} = __makeref({1});", typedReferenceVarName, genericParam.ImplementationName);
			sw.WriteLine("IntPtr {0} = *(IntPtr*)(&{1});", typedReferencePtrVarName, typedReferenceVarName);
			sw.WriteLine();

			#endregion

			#region Delegate Call

			sw.WriteIdentation();

			// Local return value
			if (HasReturnValue) 
				sw.Write("{0} = ", ReturnVariableName);

			sw.Write("Delegates.{0}(", DelegateName);

			#region Parameters

			for (int i = 0; i < genericParameters.Count; i++) {
				CommandParameter param = genericParameters[i];

				if (i < genericParameters.Count - 1) {
					param.WriteDelegateParam(sw, ctx, this);
				} else {
					sw.Write("({0}){1}.ToPointer()", originalParam.GetImportType(this), typedReferencePtrVarName);
				}

				if (i != Parameters.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			sw.Write(";");
			sw.WriteLine();

			#endregion

			// Unsafe block
			sw.Unindent();
			sw.WriteLine("}");

			#endregion

			sw.WriteLine("#endif");

			#region Call Log

			// Log command
			sw.WriteIdentation(); sw.Write("LogCommand(\"{0}\"", ImportName);
			// Return value
			if (HasReturnValue) {
				sw.Write(", ");
				CommandParameter.WriteCallLogArgParam(sw, GetReturnValueExpression(ctx), returnType);
			} else {
				sw.Write(", null");
			}
			// Arguments
			if (genericParameters.Count > 0) {
				sw.Write(", ");
				for (int i = 0; i < genericParameters.Count; i++) {
					genericParameters[i].WriteCallLogArgParam(sw, ctx, this);
					if (i < genericParameters.Count - 1)
						sw.Write(", ");
				}
			}
			// End LogCommand
			sw.WriteLine(");");

			#endregion

			// Check call errors
			if ((Flags & CommandFlags.NoGetError) == 0) {
				string returnValue = "null";

				// Optionally pass the returned value to error checking method
				if (HasReturnValue && !IsUnsafeImplementationSignature(ctx, genericParameters))
					returnValue = ReturnVariableName;

				sw.WriteLine("DebugCheckErrors({0});", returnValue);
			}

			// Returns value
			if (HasReturnValue) {
				sw.WriteLine();
				sw.WriteLine("return ({0});", GetReturnValueExpression(ctx));
			}

			// Implementation block
			sw.Unindent();
			sw.WriteLine("}");
		}

		/// <summary>
		/// Generate the command implementation (generic variant).
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used to write the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		private void GenerateImplementation_GenericsArray(SourceStreamWriter sw, RegistryContext ctx)
		{
			// Identify the generic argument:
			// - It must a array/pointer type
			// - It must be the last one
			List<CommandParameter> genericParameters = GetStrongParameters(ctx);

			CommandParameter genericParam = genericParameters[genericParameters.Count - 1];
			CommandParameter originalParam = Parameters[Parameters.Count - 1];

			if (genericParam.IsManagedArray(ctx, this) == false)
				throw new NotSupportedException("generic parameter is not an array");

			// Change the argument in order to have a generic ref
			genericParam.Type = "T*";
			genericParam.TypeDecorators.Clear();
			// genericParam.ModifierOverride = "ref";
			
			// Determine the method name
			// - It must end with 'v'
			// - It must include the argument type (i.e. glUniform2iv -> Uniform2i)
			string implementationName = Prototype.Name.Substring(ctx.Class.Length);

			if (implementationName.EndsWith("v") == false)
				throw new NotSupportedException("not a vector command");
			implementationName = implementationName.Substring(0, implementationName.Length - 1);

			// Signature (generic with constraints
			GenerateImplementation_Signature(sw, ctx, genericParameters, implementationName + "<T>", GetImplementationReturnType(ctx), "where T : struct");

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			// Unsafe block
			sw.WriteLine("unsafe {");
			sw.Indent();

			#region Local Variables

			string typedReferenceVarName = "ref" + SpecificationStyle.GetCamelCase(genericParam.Name);
			string typedReferencePtrVarName = "ref" + SpecificationStyle.GetCamelCase(genericParam.Name) + "Ptr";

			sw.WriteLine("TypedReference {0} = __makeref({1});", typedReferenceVarName, genericParam.ImplementationName);
			sw.WriteLine("IntPtr {0} = *(IntPtr*)(&{1});", typedReferencePtrVarName, typedReferenceVarName);
			sw.WriteLine();

			#endregion

			#region Unsafe Method Call

			sw.WriteIdentation();
			sw.Write("{0}(", GetImplementationName(ctx));

			#region Parameters

			for (int i = 0; i < genericParameters.Count; i++) {
				CommandParameter param = genericParameters[i];

				if (i < genericParameters.Count - 1) {
					param.WriteDelegateParam(sw, ctx, this);
				} else {
					sw.Write("({0}){1}.ToPointer()", originalParam.GetImportType(this), typedReferencePtrVarName);
				}

				if (i != Parameters.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");
			sw.Write(";");
			sw.WriteLine();

			#endregion

			// Unsafe block
			sw.Unindent();
			sw.WriteLine("}");

			// Implementation block
			sw.Unindent();
			sw.WriteLine("}");
		}

		#endregion

		#region Code Generation - Common Information

		/// <summary>
		/// Flags controlling the code generation.
		/// </summary>
		public CommandFlags Flags { get { return (CommandFlagsDatabase.GetCommandFlags(this)); } }

		/// <summary>
		/// Get whether the command has a return value.
		/// </summary>
		private bool HasReturnValue
		{
			get { return (Prototype.ImplementationReturnType != "void"); }
		}

		private string GetReturnValueExpression(RegistryContext ctx)
		{
			// The implementation returned type
			string returnType = GetImplementationReturnType(ctx);
			// The delegate returned type
			string delegateReturnType = DelegateReturnType;
			// Returned value must be marshalled as string
			bool marshalReturnedString = HasReturnValue && (returnType.ToLower() == "string") && (delegateReturnType.ToLower() != "string");
			// Returned value must be marshalled as structure
			bool marshalReturnedStruct = HasReturnValue && (DelegateReturnType == "IntPtr") && (GetImplementationReturnType(ctx) != "IntPtr");

            // Note: it seems that GL implementations should managed UTF8 strings
			if (marshalReturnedString)
				return (String.Format("PtrToString({0})", ReturnVariableName));
			else if (marshalReturnedStruct)
				return (String.Format("({1})Marshal.PtrToStructure({0}, typeof({1}))", ReturnVariableName, GetImplementationReturnType(ctx)));
			else if (returnType != delegateReturnType)
				return (String.Format("({1}){0}", ReturnVariableName, GetImplementationReturnType(ctx)));
			else
				return (String.Format("{0}", ReturnVariableName));
		}

		/// <summary>
		/// Determine whether the command parameters are safe.
		/// </summary>
		private bool IsSafeImplementation
		{
			get
			{
				foreach (CommandParameter param in Parameters)
					if (param.IsSafe == false)
						return (false);

				return (true);
			}
		}

		/// <summary>
		/// Determine whether this command is a "Get" command (that is, it returns information to the caller).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Command is a Get command.
		/// </returns>
		internal bool IsGetImplementation(RegistryContext ctx)
		{
			string implementationName = GetImplementationNameBase(ctx);

			return (implementationName.StartsWith("Get") || implementationName.StartsWith("Are") || implementationName.StartsWith("Is"));
		}

		/// <summary>
		/// Determine whether this command is a "Gen" command (that is, generate OpenGL objects).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Command is a Gen command.
		/// </returns>
		internal bool IsGenImplementation(RegistryContext ctx)
		{
			if (GetImplementationReturnType(ctx) != "void")
				return (false);
			if (!CommandParameterArrayLength.IsCompatible(ctx, this))
				return (false);

			string implementationName = GetImplementationNameBase(ctx);

			return (implementationName.StartsWith("Gen") || implementationName.StartsWith("Create"));
		}

		/// <summary>
		/// Determine the extension postfix of this command.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the OpenGL registry information.
		/// </param>
		/// <returns>
		/// It returns the string that identifies the extension suffix of this method, if found; otherwise,
		/// it returns an empty string.
		/// </returns>
		internal string GetExtensionPostfix(RegistryContext ctx)
		{
			string name = Prototype.Name;

			foreach (string ext in ctx.ExtensionsDictionary.Words)
				if (name.EndsWith(ext))
					return (ext);

			return (String.Empty);
		}

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
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			RequiredBy.Clear();
			RequiredBy.AddRange(GetFeaturesRequiringCommand(ctx));

			RemovedBy.Clear();
			RemovedBy.AddRange(GetFeaturesRemovingCommand(ctx));

			foreach (CommandParameter commandParameter in Parameters)
				commandParameter.ParentCommand = this;
		}

		/// <summary>
		/// Get a list of <see cref="IFeature"/> requiring this enumerant.
		/// </summary>
		/// <param name="ctx">
		///  A <see cref="RegistryContext"/> holding the registry information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:IEnumerable{IFeature}"/> listing all features requiring this enumerant.
		/// </returns>
		private IEnumerable<IFeature> GetFeaturesRequiringCommand(RegistryContext ctx)
		{
			List<IFeature> features = new List<IFeature>();

			// Features
			foreach (Feature feature in ctx.Registry.Features) {
				if (feature.Api != null && !ctx.IsSupportedApi(feature.Api))
					continue;

				List<FeatureCommand> requirementIndexes = feature.Requirements.FindAll(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Commands.FindIndex(delegate (FeatureCommand.Item subitem) {
						return (subitem.Name == Prototype.Name);
					});

					return (enumIndex != -1);
				});

				foreach (FeatureCommand featureCommand in requirementIndexes) {
					if (featureCommand.Api != null || featureCommand.Profile != null)
						features.Add(new FeatureProfile(feature, featureCommand.Api, featureCommand.Profile));
					else
						features.Add(feature);
				}
			}

			// Extensions
			foreach (Extension extension in ctx.Registry.Extensions) {
				if (extension.Supported != null && !ctx.IsSupportedApi(extension.Supported))
					continue;

				List<FeatureCommand> requirementIndexes = extension.Requirements.FindAll(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Commands.FindIndex(delegate(FeatureCommand.Item subitem) {
						foreach (Command commandAlias in Aliases)
							if (subitem.Name == commandAlias.Prototype.Name)
								return (true);

						return (subitem.Name == Prototype.Name);
					});

					return (enumIndex != -1);
				});

				foreach (FeatureCommand featureCommand in requirementIndexes) {
					if (featureCommand.Api != null || featureCommand.Profile != null)
						features.Add(new ExtensionProfile(extension, featureCommand.Api, featureCommand.Profile));
					else
						features.Add(extension);
				}
			}

			return (features);
		}

		/// <summary>
		/// Get a list of <see cref="IFeature"/> removing this enumerant.
		/// </summary>
		/// <param name="registry">
		///  A <see cref="Registry"/> holding the registry information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:IEnumerable{IFeature}"/> listing all features removing this enumerant.
		/// </returns>
		private IEnumerable<IFeature> GetFeaturesRemovingCommand(RegistryContext ctx)
		{
			List<IFeature> features = new List<IFeature>();

			// Features
			foreach (Feature feature in ctx.Registry.Features) {
				if (feature.Api != null && !ctx.IsSupportedApi(feature.Api))
					continue;

				List<FeatureCommand> requirementIndexes = feature.Removals.FindAll(delegate(FeatureCommand item) {
					if (item.Api != null && !ctx.IsSupportedApi(item.Api))
						return (false);

					int enumIndex = item.Commands.FindIndex(delegate(FeatureCommand.Item subitem) {
						foreach (Command commandAlias in Aliases)
							if (subitem.Name == commandAlias.Prototype.Name)
								return (true);
						return (subitem.Name == Prototype.Name);
					});

					return (enumIndex != -1);
				});

				foreach (FeatureCommand featureCommand in requirementIndexes) {
					if (featureCommand.Api != null || featureCommand.Profile != null)
						features.Add(new FeatureProfile(feature, featureCommand.Api, featureCommand.Profile));
					else
						features.Add(feature);
				}
			}

			return (features);
		}

		/// <summary>
		/// List of <see cref="IFeature"/> that requires this Enumerant.
		/// </summary>
		[XmlIgnore]
		public readonly List<IFeature> RequiredBy = new List<IFeature>();

		/// <summary>
		/// List of <see cref="IFeature"/> that removes this Enumerant.
		/// </summary>
		[XmlIgnore]
		public readonly List<IFeature> RemovedBy = new List<IFeature>();

		#endregion
	}
}
