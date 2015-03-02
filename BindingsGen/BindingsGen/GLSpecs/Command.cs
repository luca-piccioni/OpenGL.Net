
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
		[DebuggerDisplay("CommandAlias: Name={Name}")]
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
		[DebuggerDisplay("VectorCommandAlias: Name={Name}")]
		public class VectorCommandAlias
		{
			/// <summary>
			/// Vector equivalent command name.
			/// </summary>
			[XmlAttribute("name")]
			public String Name;
		}

		/// <summary>
		/// Arbitrary string.
		/// </summary>
		[XmlAttribute("comment")]
		public String Comment;

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

		#region Code Generation - Import

		/// <summary>
		/// Get the name of the command import.
		/// </summary>
		private string ImportName
		{
			get { return (Prototype.Name); }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="registry"></param>
		internal void GenerateImport(SourceStreamWriter sw, Registry registry)
		{
			sw.WriteLine("[SuppressUnmanagedCodeSecurity()]");
			sw.WriteLine("[DllImport(Library, EntryPoint = \"{0}\", ExactSpelling = true)]", ImportName);

			sw.WriteIdentation(); sw.Write("internal extern static ");
			if (IsSafeImplementation == false) sw.Write("unsafe ");

			sw.Write("{0} {1}(", DelegateReturnType, ImportName);

			int paramCount = Parameters.Count;

			foreach (CommandParameter param in Parameters) {
				sw.Write("{0} {1}", param.ImportType, param.ImportName);
				paramCount--;
				if (paramCount > 0)
					sw.Write(", ");
			}
			sw.Write(");");
			sw.WriteLine();
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
			get { return (Prototype.DelegateReturnType); }
		}

		internal void GenerateDelegate(SourceStreamWriter sw, Registry registry)
		{
			sw.WriteLine("[SuppressUnmanagedCodeSecurity()]");

			sw.WriteIdentation(); sw.Write("internal ");
			if (IsSafeImplementation == false) sw.Write("unsafe ");
			sw.Write("delegate ");

			sw.Write("{0} {1}(", DelegateReturnType, ImportName);

			int paramCount = Parameters.Count;

			foreach (CommandParameter param in Parameters) {
				sw.Write("{0} {1}", param.ImportType, param.ImportName);
				paramCount--;
				if (paramCount > 0)
					sw.Write(", ");
			}
			sw.Write(");");
			sw.WriteLine();

			sw.WriteLine("[ThreadStatic]");
			sw.WriteLine("internal static {0} {1};", ImportName, DelegateName);
		}

		#endregion

		#region Code Generation - Implementation

		/// <summary>
		/// Get the name of the command implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> used for manipulating the command import name.
		/// </param>
		private string GetImplementationName(RegistryContext ctx)
		{
			string implementationName = Prototype.Name;
			string prefix = ctx.Class.ToLower();

			if (implementationName.StartsWith(prefix))
				implementationName = implementationName.Substring(prefix.Length);

			return (ctx.WordsDictionary.GetOverridableName(ctx, implementationName));
		}

		/// <summary>
		/// Get the local variable storing the returned value.
		/// </summary>
		private string ReturnVariableName { get { return ("retValue"); } }

		/// <summary>
		/// Get the implementation return type.
		/// </summary>
		private string GetImplementationReturnType(Registry registry)
		{
			if ((Prototype.Group != null) && (registry.Groups.FindIndex(delegate(EnumerantGroup item) { return (item.Name == Prototype.Group); }) >= 0)) {
				if (Prototype.Group != "Boolean")
					return (Prototype.Group);
			}

			return (Prototype.ImplementationReturnType);
		}

		private bool IsFixedImplementation(List<CommandParameter> commandParams)
		{
			foreach (CommandParameter param in commandParams)
				if (param.IsFixed)
					return (true);

			return (false);
		}

		private List<CommandParameter>[] GetOverridenImplementations(Registry registry)
		{
			List<List<CommandParameter>> overridenParameters = new List<List<CommandParameter>>();

			// Standard implementation
			overridenParameters.Add(Parameters);

			// Stronly typed implementation
			if (!Parameters.TrueForAll(delegate(CommandParameter item) { return (item.IsStrong(registry) == false); })) {
				List<CommandParameter> parameters = new List<CommandParameter>();

				foreach (CommandParameter commandParameter in Parameters)
					parameters.Add(commandParameter.StronglyTyped(registry));

				overridenParameters.Add(parameters);
			}

			return (overridenParameters.ToArray());
		}

		internal void GenerateImplementations(RegistryContext ctx, SourceStreamWriter sw, Registry registry)
		{
			List<CommandParameter>[] overridenParams = GetOverridenImplementations(registry);

			for (int i = 0; i < overridenParams.Length; i++) {
				// Generate implementation
				GenerateImplementation(ctx, sw, registry, overridenParams[i]);
				// Separate next implementation with a new line, if not the last
				if (i < overridenParams.Length - 1)
					sw.WriteLine();
			}
		}
		
		internal void GenerateImplementation(RegistryContext ctx, SourceStreamWriter sw, Registry registry, List<CommandParameter> commandParams)
		{
			bool fixedImplementation = IsFixedImplementation(commandParams);

			// Documentation
			//RegistryDocumentation.GenerateCommandDocumentation(sw, this);

			#region Signature

			// Signature
			sw.WriteIdentation(); sw.Write("public static {0} {1}(", GetImplementationReturnType(registry), GetImplementationName(ctx));
			// Signature - Parameters
			int paramCount = commandParams.Count;

			foreach (CommandParameter param in commandParams) {
				sw.Write("{0} {1}", param.ImplementationType, param.ImplementationName);
				paramCount--;
				if (paramCount > 0)
					sw.Write(", ");
			}
			sw.Write(")");
			sw.WriteLine();

			#endregion

			// Implementation block
			sw.WriteLine("{");
			sw.Indent();

			#region Loca Variables

			// Local variable: returned value
			if (HasReturnValue) {
				sw.WriteLine("{0} {1};", GetImplementationReturnType(registry), ReturnVariableName);
				sw.WriteLine();
			}

			#endregion

			#region Unsafe Block (Open)

			if (fixedImplementation) {
				sw.WriteLine("unsafe {");								// (1)
				sw.Indent();
				foreach (CommandParameter param in Parameters) {
					if (param.IsFixed == false)
						continue;
					sw.WriteLine("fixed ({0} {1} = {2})", param.ImportType, param.FixedLocalVarName, param.ImplementationName);
				}
				sw.WriteLine("{");										// (2)
				sw.Indent();
			}

			#endregion

			// Assert delegate existing
			sw.WriteLine("Debug.Assert(Delegates.{0} != null, \"{0} not implemented\");", DelegateName);

			#region Delegate Call

			string returnType = GetImplementationReturnType(registry), delegateReturnType = DelegateReturnType;
			bool marshalReturnedString = HasReturnValue && (returnType.ToLower() == "string") && (delegateReturnType.ToLower() != "string");

			sw.WriteIdentation();

			#region Return Value Management (Open)

			if (HasReturnValue) {
				// Local return value || Inlined return
				sw.Write("{0} = ", ReturnVariableName);
				// Stronly typed returns need a cast
				if (returnType != delegateReturnType)
					sw.Write("({0})", returnType);

				// To String type conversion?
				if (marshalReturnedString)
					sw.Write("Marshal.PtrToStringAnsi(");
			}

			#endregion

			sw.Write("Delegates.{0}(", DelegateName);

			#region Parameters

			for (int i = 0; i < commandParams.Count; i++) {
				CommandParameter param = commandParams[i];

				if (param.IsFixed) {
					sw.Write(param.FixedLocalVarName);
				} else {
					if (param.OverridenParameter != null)
						sw.Write("({0})", param.OverridenParameter.ImportType);
					sw.Write(param.DelegateCallVarName);
				}

				if (i != Parameters.Count - 1)
					sw.Write(", ");
			}

			#endregion

			sw.Write(")");

			#region Return Value Management (Close)

			if (marshalReturnedString)
				sw.Write(")");

			#endregion

			sw.Write(";");
			sw.WriteLine();

			// Delegate call
			//sw.WriteLine(GenerateImplementation_DelegateCall(ctx, registry));

			#endregion

			#region Unsafe Block (Close)

			if (fixedImplementation) {
				sw.Unindent();
				sw.WriteLine("}");										// (2) CLOSED
				sw.Unindent();
				sw.WriteLine("}");										// (1) CLOSED
			}

			#endregion

			#region Call Log

			sw.WriteIdentation(); sw.Write("CallLog(");

			#region Call Log - Format String

			sw.Write("\"{0}(", ImportName);
			for (int i = 0; i < commandParams.Count; i++) {
				sw.Write("{{{0}}}", i);
				if (i < commandParams.Count - 1)
					sw.Write(", ");
			}
			sw.Write(")");

			if (HasReturnValue)
				sw.Write(" = {{{0}}}", commandParams.Count);

			sw.Write("\"");

			#endregion

			#region Call Log - Format Arguments

			if ((commandParams.Count > 0) || HasReturnValue) {
				sw.Write(", ");

				for (int i = 0; i < commandParams.Count; i++) {
					CommandParameter commandParameter = commandParams[i];

					sw.Write("{0}", commandParameter.ImplementationName);
					if (i < commandParams.Count - 1)
						sw.Write(", ");
				}
			}

			// Return value
			if (HasReturnValue) {
				if (commandParams.Count > 0)
					sw.Write(", ");
				sw.Write("{0}", ReturnVariableName);
			}

			#endregion

			sw.Write(");");
			sw.WriteLine();

			#endregion

			// Check call errors
			sw.WriteLine("DebugCheckErrors();");

			// Returns value
			if (HasReturnValue) {
				sw.WriteLine();
				sw.WriteLine("return ({0});", ReturnVariableName);
			}

			sw.Unindent();
			sw.WriteLine("}");
		}

		#endregion

		#region Code Generation - Common Information

		/// <summary>
		/// Get whether the command has a return value.
		/// </summary>
		private bool HasReturnValue
		{
			get { return (Prototype.ImplementationReturnType != "void"); }
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

		#endregion
	}
}
